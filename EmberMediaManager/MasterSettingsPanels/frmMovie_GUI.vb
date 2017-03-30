﻿' ################################################################################
' #                             EMBER MEDIA MANAGER                              #
' ################################################################################
' ################################################################################
' # This file is part of Ember Media Manager.                                    #
' #                                                                              #
' # Ember Media Manager is free software: you can redistribute it and/or modify  #
' # it under the terms of the GNU General Public License as published by         #
' # the Free Software Foundation, either version 3 of the License, or            #
' # (at your option) any later version.                                          #
' #                                                                              #
' # Ember Media Manager is distributed in the hope that it will be useful,       #
' # but WITHOUT ANY WARRANTY; without even the implied warranty of               #
' # MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the                #
' # GNU General Public License for more details.                                 #
' #                                                                              #
' # You should have received a copy of the GNU General Public License            #
' # along with Ember Media Manager.  If not, see <http://www.gnu.org/licenses/>. #
' ################################################################################

Imports EmberAPI
Imports NLog

Public Class frmMovie_GUI
    Implements Interfaces.MasterSettingsPanel

#Region "Fields"

    Shared logger As Logger = LogManager.GetCurrentClassLogger()

    Dim _ePanelType As Enums.SettingsPanelType = Enums.SettingsPanelType.Movie
    Dim _intImageIndex As Integer = 0
    Dim _intOrder As Integer = 100
    Dim _strName As String = "Movie_GUI"
    Dim _strTitle As String = "GUI"

    Dim _medialistsorting As New MediaListSortingSpecification

#End Region 'Fields

#Region "Events"

    Public Event NeedsDBClean_Movie() Implements Interfaces.MasterSettingsPanel.NeedsDBClean_Movie
    Public Event NeedsDBClean_TV() Implements Interfaces.MasterSettingsPanel.NeedsDBClean_TV
    Public Event NeedsDBUpdate_Movie() Implements Interfaces.MasterSettingsPanel.NeedsDBUpdate_Movie
    Public Event NeedsDBUpdate_TV() Implements Interfaces.MasterSettingsPanel.NeedsDBUpdate_TV
    Public Event NeedsReload_Movie() Implements Interfaces.MasterSettingsPanel.NeedsReload_Movie
    Public Event NeedsReload_MovieSet() Implements Interfaces.MasterSettingsPanel.NeedsReload_MovieSet
    Public Event NeedsReload_TVEpisode() Implements Interfaces.MasterSettingsPanel.NeedsReload_TVEpisode
    Public Event NeedsReload_TVShow() Implements Interfaces.MasterSettingsPanel.NeedsReload_TVShow
    Public Event NeedsRestart() Implements Interfaces.MasterSettingsPanel.NeedsRestart
    Public Event SettingsChanged() Implements Interfaces.MasterSettingsPanel.SettingsChanged

#End Region 'Events

#Region "Properties"

    Public ReadOnly Property Order() As Integer Implements Interfaces.MasterSettingsPanel.Order
        Get
            Return _intOrder
        End Get
    End Property

#End Region 'Properties

#Region "Handles"

    Private Sub Handle_NeedsDBClean_Movie()
        RaiseEvent NeedsDBClean_Movie()
    End Sub

    Private Sub Handle_NeedsDBClean_TV()
        RaiseEvent NeedsDBClean_TV()
    End Sub

    Private Sub Handle_NeedsDBUpdate_Movie()
        RaiseEvent NeedsDBUpdate_Movie()
    End Sub

    Private Sub Handle_NeedsDBUpdate_TV()
        RaiseEvent NeedsDBUpdate_TV()
    End Sub

    Private Sub Handle_NeedsReload_Movie()
        RaiseEvent NeedsReload_Movie()
    End Sub

    Private Sub Handle_NeedsReload_MovieSet()
        RaiseEvent NeedsReload_MovieSet()
    End Sub

    Private Sub Handle_NeedsReload_TVEpisode()
        RaiseEvent NeedsReload_TVEpisode()
    End Sub

    Private Sub Handle_NeedsReload_TVShow()
        RaiseEvent NeedsReload_TVShow()
    End Sub

    Private Sub Handle_NeedsRestart()
        RaiseEvent NeedsRestart()
    End Sub

    Private Sub Handle_SettingsChanged()
        RaiseEvent SettingsChanged()
    End Sub

#End Region 'Handles

#Region "Constructors"

    Public Sub New()
        InitializeComponent()
        SetUp()
    End Sub

#End Region 'Constructors 

#Region "Interface Methods"

    Public Sub DoDispose() Implements Interfaces.MasterSettingsPanel.DoDispose
        Dispose()
    End Sub

    Public Function InjectSettingsPanel() As Containers.SettingsPanel Implements Interfaces.MasterSettingsPanel.InjectSettingsPanel
        LoadSettings()

        Dim nSettingsPanel As New Containers.SettingsPanel With {
            .ImageIndex = _intImageIndex,
            .Name = _strName,
            .Order = _intOrder,
            .Panel = pnlSettings,
            .Prefix = _strName,
            .Title = _strTitle,
            .Type = _ePanelType
        }

        Return nSettingsPanel
    End Function

    Public Sub LoadSettings()
        With Manager.mSettings.Movie.GUI
            btnMovieGeneralCustomMarker1.BackColor = Color.FromArgb(.CustomMarker1.Color)
            btnMovieGeneralCustomMarker2.BackColor = Color.FromArgb(.CustomMarker2.Color)
            btnMovieGeneralCustomMarker3.BackColor = Color.FromArgb(.CustomMarker3.Color)
            btnMovieGeneralCustomMarker4.BackColor = Color.FromArgb(.CustomMarker4.Color)
            cbMovieGeneralCustomScrapeButtonModifierType.SelectedValue = .CustomScrapeButton.ModifierType
            cbMovieGeneralCustomScrapeButtonScrapeType.SelectedValue = .CustomScrapeButton.ScrapeType
            cbMovieLanguageOverlay.SelectedItem = If(String.IsNullOrEmpty(.BestAudioStreamOfLanguage), Master.eLang.Disabled, .BestAudioStreamOfLanguage)
            chkMovieClickScrape.Checked = .ClickScrape
            chkMovieClickScrapeAsk.Checked = .ClickScrapeAsk
            If .CustomScrapeButton.Enabled Then
                rbMovieGeneralCustomScrapeButtonEnabled.Checked = True
            Else
                rbMovieGeneralCustomScrapeButtonDisabled.Checked = True
            End If
            txtMovieGeneralCustomMarker1.Text = .CustomMarker1.Name
            txtMovieGeneralCustomMarker2.Text = .CustomMarker2.Name
            txtMovieGeneralCustomMarker3.Text = .CustomMarker3.Name
            txtMovieGeneralCustomMarker4.Text = .CustomMarker4.Name
            chkMovieClickScrapeAsk.Enabled = chkMovieClickScrape.Checked

            _medialistsorting.AddRange(.MediaListSorting)
            LoadMovieGeneralMediaListSorting()
        End With
    End Sub

    Public Sub SaveSetup() Implements Interfaces.MasterSettingsPanel.SaveSetup
        With Manager.mSettings.Movie.GUI
            .ClickScrape = chkMovieClickScrape.Checked
            .ClickScrapeAsk = chkMovieClickScrapeAsk.Checked
            .CustomMarker1.Color = btnMovieGeneralCustomMarker1.BackColor.ToArgb
            .CustomMarker2.Color = btnMovieGeneralCustomMarker2.BackColor.ToArgb
            .CustomMarker3.Color = btnMovieGeneralCustomMarker3.BackColor.ToArgb
            .CustomMarker4.Color = btnMovieGeneralCustomMarker4.BackColor.ToArgb
            .CustomMarker1.Name = txtMovieGeneralCustomMarker1.Text
            .CustomMarker2.Name = txtMovieGeneralCustomMarker2.Text
            .CustomMarker3.Name = txtMovieGeneralCustomMarker3.Text
            .CustomMarker4.Name = txtMovieGeneralCustomMarker4.Text
            .CustomScrapeButton.Enabled = rbMovieGeneralCustomScrapeButtonEnabled.Checked
            .CustomScrapeButton.ModifierType = CType(cbMovieGeneralCustomScrapeButtonModifierType.SelectedItem, KeyValuePair(Of String, Enums.ScrapeModifierType)).Value
            .CustomScrapeButton.ScrapeType = CType(cbMovieGeneralCustomScrapeButtonScrapeType.SelectedItem, KeyValuePair(Of String, Enums.ScrapeType)).Value
            .BestAudioStreamOfLanguage = If(cbMovieLanguageOverlay.Text = Master.eLang.Disabled, String.Empty, cbMovieLanguageOverlay.Text)
            .MediaListSorting.Clear()
            .MediaListSorting.AddRange(_medialistsorting)
        End With
    End Sub

#End Region 'Interface Methods

#Region "Methods"

    Private Sub btnMovieGeneralCustomMarker1_Click(sender As Object, e As EventArgs) Handles btnMovieGeneralCustomMarker1.Click
        With cdColor
            If .ShowDialog = DialogResult.OK Then
                If Not .Color = Nothing Then
                    btnMovieGeneralCustomMarker1.BackColor = .Color
                    EnableApplyButton()
                End If
            End If
        End With
    End Sub

    Private Sub btnMovieGeneralCustomMarker2_Click(sender As Object, e As EventArgs) Handles btnMovieGeneralCustomMarker2.Click
        With cdColor
            If .ShowDialog = DialogResult.OK Then
                If Not .Color = Nothing Then
                    btnMovieGeneralCustomMarker2.BackColor = .Color
                    EnableApplyButton()
                End If
            End If
        End With
    End Sub

    Private Sub btnMovieGeneralCustomMarker3_Click(sender As Object, e As EventArgs) Handles btnMovieGeneralCustomMarker3.Click
        With cdColor
            If .ShowDialog = DialogResult.OK Then
                If Not .Color = Nothing Then
                    btnMovieGeneralCustomMarker3.BackColor = .Color
                    EnableApplyButton()
                End If
            End If
        End With
    End Sub

    Private Sub btnMovieGeneralCustomMarker4_Click(sender As Object, e As EventArgs) Handles btnMovieGeneralCustomMarker4.Click
        With cdColor
            If .ShowDialog = DialogResult.OK Then
                If Not .Color = Nothing Then
                    btnMovieGeneralCustomMarker4.BackColor = .Color
                    EnableApplyButton()
                End If
            End If
        End With
    End Sub

    Private Sub btnMovieGeneralMediaListSortingReset_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnMovieGeneralMediaListSortingReset.Click
        Manager.mSettings.Movie.GUI.MediaListSorting.SetDefaults(Enums.ContentType.Movie, True)
        _medialistsorting.Clear()
        _medialistsorting.AddRange(Manager.mSettings.Movie.GUI.MediaListSorting)
        LoadMovieGeneralMediaListSorting()
        EnableApplyButton()
    End Sub

    Private Sub btnMovieGeneralMediaListSortingUp_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnMovieGeneralMediaListSortingUp.Click
        Try
            If lvMovieGeneralMediaListSorting.Items.Count > 0 AndAlso lvMovieGeneralMediaListSorting.SelectedItems.Count > 0 AndAlso Not lvMovieGeneralMediaListSorting.SelectedItems(0).Index = 0 Then
                Dim selItem As MediaListSortingItemSpecification = _medialistsorting.FirstOrDefault(Function(r) r.DisplayIndex = Convert.ToInt32(lvMovieGeneralMediaListSorting.SelectedItems(0).Text))

                If selItem IsNot Nothing Then
                    lvMovieGeneralMediaListSorting.SuspendLayout()
                    Dim iIndex As Integer = _medialistsorting.IndexOf(selItem)
                    Dim selIndex As Integer = lvMovieGeneralMediaListSorting.SelectedIndices(0)
                    _medialistsorting.Remove(selItem)
                    _medialistsorting.Insert(iIndex - 1, selItem)

                    RenumberMovieGeneralMediaListSorting()
                    LoadMovieGeneralMediaListSorting()

                    If Not selIndex - 3 < 0 Then
                        lvMovieGeneralMediaListSorting.TopItem = lvMovieGeneralMediaListSorting.Items(selIndex - 3)
                    End If
                    lvMovieGeneralMediaListSorting.Items(selIndex - 1).Selected = True
                    lvMovieGeneralMediaListSorting.ResumeLayout()
                End If

                EnableApplyButton()
                lvMovieGeneralMediaListSorting.Focus()
            End If
        Catch ex As Exception
            logger.Error(ex, New StackFrame().GetMethod().Name)
        End Try
    End Sub

    Private Sub btnMovieGeneralMediaListSortingDown_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnMovieGeneralMediaListSortingDown.Click
        Try
            If lvMovieGeneralMediaListSorting.Items.Count > 0 AndAlso lvMovieGeneralMediaListSorting.SelectedItems.Count > 0 AndAlso lvMovieGeneralMediaListSorting.SelectedItems(0).Index < (lvMovieGeneralMediaListSorting.Items.Count - 1) Then
                Dim selItem As MediaListSortingItemSpecification = _medialistsorting.FirstOrDefault(Function(r) r.DisplayIndex = Convert.ToInt32(lvMovieGeneralMediaListSorting.SelectedItems(0).Text))

                If selItem IsNot Nothing Then
                    lvMovieGeneralMediaListSorting.SuspendLayout()
                    Dim iIndex As Integer = _medialistsorting.IndexOf(selItem)
                    Dim selIndex As Integer = lvMovieGeneralMediaListSorting.SelectedIndices(0)
                    _medialistsorting.Remove(selItem)
                    _medialistsorting.Insert(iIndex + 1, selItem)

                    RenumberMovieGeneralMediaListSorting()
                    LoadMovieGeneralMediaListSorting()

                    If Not selIndex - 2 < 0 Then
                        lvMovieGeneralMediaListSorting.TopItem = lvMovieGeneralMediaListSorting.Items(selIndex - 2)
                    End If
                    lvMovieGeneralMediaListSorting.Items(selIndex + 1).Selected = True
                    lvMovieGeneralMediaListSorting.ResumeLayout()
                End If

                EnableApplyButton()
                lvMovieGeneralMediaListSorting.Focus()
            End If
        Catch ex As Exception
            logger.Error(ex, New StackFrame().GetMethod().Name)
        End Try
    End Sub

    Private Sub chkMovieClickScrape_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkMovieClickScrape.CheckedChanged
        chkMovieClickScrapeAsk.Enabled = chkMovieClickScrape.Checked
        EnableApplyButton()
    End Sub

    Private Sub EnableApplyButton()

        Handle_SettingsChanged()
    End Sub

    Private Sub LoadMovieGeneralMediaListSorting()
        Dim lvItem As ListViewItem
        lvMovieGeneralMediaListSorting.Items.Clear()
        For Each rColumn As MediaListSortingItemSpecification In _medialistsorting.OrderBy(Function(f) f.DisplayIndex)
            lvItem = New ListViewItem(rColumn.DisplayIndex.ToString)
            lvItem.SubItems.Add(rColumn.Column)
            lvItem.SubItems.Add(Master.eLang.GetString(rColumn.LabelID, rColumn.LabelText))
            lvItem.SubItems.Add(If(rColumn.Hide, Master.eLang.GetString(300, "Yes"), Master.eLang.GetString(720, "No")))
            lvMovieGeneralMediaListSorting.Items.Add(lvItem)
        Next
    End Sub

    Private Sub LoadCustomScraperButtonModifierTypes_Movie()
        Dim items As New Dictionary(Of String, Enums.ScrapeModifierType)
        items.Add(Master.eLang.GetString(70, "All Items"), Enums.ScrapeModifierType.All)
        items.Add(Master.eLang.GetString(973, "Actor Thumbs Only"), Enums.ScrapeModifierType.MainActorThumbs)
        items.Add(Master.eLang.GetString(1060, "Banner Only"), Enums.ScrapeModifierType.MainBanner)
        items.Add(Master.eLang.GetString(1122, "ClearArt Only"), Enums.ScrapeModifierType.MainClearArt)
        items.Add(Master.eLang.GetString(1123, "ClearLogo Only"), Enums.ScrapeModifierType.MainClearLogo)
        items.Add(Master.eLang.GetString(1124, "DiscArt Only"), Enums.ScrapeModifierType.MainDiscArt)
        items.Add(Master.eLang.GetString(975, "Extrafanarts Only"), Enums.ScrapeModifierType.MainExtrafanarts)
        items.Add(Master.eLang.GetString(74, "Extrathumbs Only"), Enums.ScrapeModifierType.MainExtrathumbs)
        items.Add(Master.eLang.GetString(73, "Fanart Only"), Enums.ScrapeModifierType.MainFanart)
        items.Add(Master.eLang.GetString(1061, "Landscape Only"), Enums.ScrapeModifierType.MainLandscape)
        items.Add(Master.eLang.GetString(76, "Meta Data Only"), Enums.ScrapeModifierType.MainMeta)
        items.Add(Master.eLang.GetString(71, "NFO Only"), Enums.ScrapeModifierType.MainNFO)
        items.Add(Master.eLang.GetString(72, "Poster Only"), Enums.ScrapeModifierType.MainPoster)
        items.Add(Master.eLang.GetString(1125, "Theme Only"), Enums.ScrapeModifierType.MainTheme)
        items.Add(Master.eLang.GetString(75, "Trailer Only"), Enums.ScrapeModifierType.MainTrailer)
        cbMovieGeneralCustomScrapeButtonModifierType.DataSource = items.ToList
        cbMovieGeneralCustomScrapeButtonModifierType.DisplayMember = "Key"
        cbMovieGeneralCustomScrapeButtonModifierType.ValueMember = "Value"
    End Sub

    Private Sub LoadCustomScraperButtonScrapeTypes()
        Dim strAll As String = Master.eLang.GetString(68, "All")
        Dim strFilter As String = Master.eLang.GetString(624, "Current Filter")
        Dim strMarked As String = Master.eLang.GetString(48, "Marked")
        Dim strMissing As String = Master.eLang.GetString(40, "Missing Items")
        Dim strNew As String = Master.eLang.GetString(47, "New")

        Dim strAsk As String = Master.eLang.GetString(77, "Ask (Require Input If No Exact Match)")
        Dim strAuto As String = Master.eLang.GetString(69, "Automatic (Force Best Match)")
        Dim strSkip As String = Master.eLang.GetString(1041, "Skip (Skip If More Than One Match)")

        Dim items As New Dictionary(Of String, Enums.ScrapeType)
        items.Add(String.Concat(strAll, " - ", strAuto), Enums.ScrapeType.AllAuto)
        items.Add(String.Concat(strAll, " - ", strAsk), Enums.ScrapeType.AllAsk)
        items.Add(String.Concat(strAll, " - ", strSkip), Enums.ScrapeType.AllSkip)
        items.Add(String.Concat(strMissing, " - ", strAuto), Enums.ScrapeType.MissingAuto)
        items.Add(String.Concat(strMissing, " - ", strAsk), Enums.ScrapeType.MissingAsk)
        items.Add(String.Concat(strMissing, " - ", strSkip), Enums.ScrapeType.MissingSkip)
        items.Add(String.Concat(strNew, " - ", strAuto), Enums.ScrapeType.NewAuto)
        items.Add(String.Concat(strNew, " - ", strAsk), Enums.ScrapeType.NewAsk)
        items.Add(String.Concat(strNew, " - ", strSkip), Enums.ScrapeType.NewSkip)
        items.Add(String.Concat(strMarked, " - ", strAuto), Enums.ScrapeType.MarkedAuto)
        items.Add(String.Concat(strMarked, " - ", strAsk), Enums.ScrapeType.MarkedAsk)
        items.Add(String.Concat(strMarked, " - ", strSkip), Enums.ScrapeType.MarkedSkip)
        items.Add(String.Concat(strFilter, " - ", strAuto), Enums.ScrapeType.FilterAuto)
        items.Add(String.Concat(strFilter, " - ", strAsk), Enums.ScrapeType.FilterAsk)
        items.Add(String.Concat(strFilter, " - ", strSkip), Enums.ScrapeType.FilterSkip)
        cbMovieGeneralCustomScrapeButtonScrapeType.DataSource = items.ToList
        cbMovieGeneralCustomScrapeButtonScrapeType.DisplayMember = "Key"
        cbMovieGeneralCustomScrapeButtonScrapeType.ValueMember = "Value"
    End Sub

    Private Sub LoadLangs()
        cbMovieLanguageOverlay.Items.Add(Master.eLang.Disabled)
        cbMovieLanguageOverlay.Items.AddRange(Localization.ISOLangGetLanguagesList.ToArray)
    End Sub

    Private Sub lvMovieGeneralMediaListSorting_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles lvMovieGeneralMediaListSorting.MouseDoubleClick
        If lvMovieGeneralMediaListSorting.Items.Count > 0 AndAlso lvMovieGeneralMediaListSorting.SelectedItems.Count > 0 Then
            Dim selItem As MediaListSortingItemSpecification = _medialistsorting.FirstOrDefault(Function(r) r.DisplayIndex = Convert.ToInt32(lvMovieGeneralMediaListSorting.SelectedItems(0).Text))

            If selItem IsNot Nothing Then
                lvMovieGeneralMediaListSorting.SuspendLayout()
                selItem.Hide = Not selItem.Hide
                Dim topIndex As Integer = lvMovieGeneralMediaListSorting.TopItem.Index
                Dim selIndex As Integer = lvMovieGeneralMediaListSorting.SelectedIndices(0)

                LoadMovieGeneralMediaListSorting()

                lvMovieGeneralMediaListSorting.TopItem = lvMovieGeneralMediaListSorting.Items(topIndex)
                lvMovieGeneralMediaListSorting.Items(selIndex).Selected = True
                lvMovieGeneralMediaListSorting.ResumeLayout()
            End If

            EnableApplyButton()
            lvMovieGeneralMediaListSorting.Focus()
        End If
    End Sub

    Private Sub RenumberMovieGeneralMediaListSorting()
        For i As Integer = 0 To _medialistsorting.Count - 1
            _medialistsorting(i).DisplayIndex = i
        Next
    End Sub

    Private Sub rbMovieGeneralCustomScrapeButtonDisabled_CheckedChanged(sender As Object, e As EventArgs) Handles rbMovieGeneralCustomScrapeButtonDisabled.CheckedChanged
        If rbMovieGeneralCustomScrapeButtonDisabled.Checked Then
            cbMovieGeneralCustomScrapeButtonModifierType.Enabled = False
            cbMovieGeneralCustomScrapeButtonScrapeType.Enabled = False
            txtMovieGeneralCustomScrapeButtonModifierType.Enabled = False
            txtMovieGeneralCustomScrapeButtonScrapeType.Enabled = False
        End If
        EnableApplyButton()
    End Sub

    Private Sub rbMovieGeneralCustomScrapeButtonEnabled_CheckedChanged(sender As Object, e As EventArgs) Handles rbMovieGeneralCustomScrapeButtonEnabled.CheckedChanged
        If rbMovieGeneralCustomScrapeButtonEnabled.Checked Then
            cbMovieGeneralCustomScrapeButtonModifierType.Enabled = True
            cbMovieGeneralCustomScrapeButtonScrapeType.Enabled = True
            txtMovieGeneralCustomScrapeButtonModifierType.Enabled = True
            txtMovieGeneralCustomScrapeButtonScrapeType.Enabled = True
        End If
        EnableApplyButton()
    End Sub

    Private Sub SetUp()
        chkMovieClickScrapeAsk.Text = Master.eLang.GetString(852, "Ask On Click Scrape")
        colMovieGeneralMediaListSortingLabel.Text = Master.eLang.GetString(1331, "Column")
        lblMovieLanguageOverlay.Text = String.Concat(Master.eLang.GetString(436, "Display best Audio Stream with the following Language"), ":")
        chkMovieClickScrape.Text = Master.eLang.GetString(849, "Enable Click Scrape")
        colMovieGeneralMediaListSortingHide.Text = Master.eLang.GetString(465, "Hide")
        gbMovieGeneralMiscOpts.Text = Master.eLang.GetString(429, "Miscellaneous")
        gbMovieGeneralMediaListSorting.Text = Master.eLang.GetString(490, "Movie List Sorting")
        gbMovieGeneralCustomMarker.Text = Master.eLang.GetString(1190, "Custom Marker")
        lblMovieGeneralCustomMarker1.Text = String.Concat(Master.eLang.GetString(1191, "Custom"), " #1")
        lblMovieGeneralCustomMarker2.Text = String.Concat(Master.eLang.GetString(1191, "Custom"), " #2")
        lblMovieGeneralCustomMarker3.Text = String.Concat(Master.eLang.GetString(1191, "Custom"), " #3")
        lblMovieGeneralCustomMarker4.Text = String.Concat(Master.eLang.GetString(1191, "Custom"), " #4")

        LoadCustomScraperButtonModifierTypes_Movie()
        LoadCustomScraperButtonScrapeTypes()
        LoadLangs()
    End Sub

#End Region 'Methods

End Class