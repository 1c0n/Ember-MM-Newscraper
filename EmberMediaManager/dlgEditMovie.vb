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

Imports System
Imports System.IO
Imports System.Text.RegularExpressions
Imports EmberAPI
Imports NLog
Imports System.Net

Public Class dlgEditMovie

#Region "Events"

#End Region 'Events

#Region "Fields"
    Shared logger As Logger = NLog.LogManager.GetCurrentClassLogger()

    Friend WithEvents bwEThumbs As New System.ComponentModel.BackgroundWorker
    Friend WithEvents bwEFanarts As New System.ComponentModel.BackgroundWorker

    Private tmpDBMovie As New Database.DBElement

    Private CachePath As String = String.Empty
    Private fResults As New Containers.ImgResult
    Private isAborting As Boolean = False
    Private lvwActorSorter As ListViewColumnSorter
    'Private lvwEThumbsSorter As ListViewColumnSorter
    'Private lvwEFanartsSorter As ListViewColumnSorter
    Private ActorThumbsHasChanged As Boolean = False
    Private pResults As New Containers.ImgResult
    Private PreviousFrameValue As Integer
    Private MovieTrailer As New MediaContainers.Trailer
    Private MovieTheme As New Themes With {.isEdit = True}
    Private tmpRating As String = String.Empty
    Private AnyThemePlayerEnabled As Boolean = False
    Private AnyTrailerPlayerEnabled As Boolean = False

    'Extrathumbs
    Private etDeleteList As New List(Of String)
    Private EThumbsIndex As Integer = -1
    Private EThumbsList As New List(Of ExtraImages)
    Private EThumbsExtractor As New List(Of String)
    Private EThumbsWarning As Boolean = True
    Private iETCounter As Integer = 0
    Private iETLeft As Integer = 1
    Private iETTop As Integer = 1
    Private pbETImage() As PictureBox
    Private pnlETImage() As Panel

    'Extrafanarts
    Private efDeleteList As New List(Of String)
    Private EFanartsIndex As Integer = -1
    Private EFanartsList As New List(Of ExtraImages)
    Private EFanartsExtractor As New List(Of String)
    Private EFanartsWarning As Boolean = True
    Private iEFCounter As Integer = 0
    Private iEFLeft As Integer = 1
    Private iEFTop As Integer = 1
    Private pbEFImage() As PictureBox
    Private pnlEFImage() As Panel

#End Region 'Fields

#Region "Properties"

    Public ReadOnly Property Result As Database.DBElement
        Get
            Return tmpDBMovie
        End Get
    End Property

#End Region 'Properties

#Region "Methods"

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        Me.Left = Master.AppPos.Left + (Master.AppPos.Width - Me.Width) \ 2
        Me.Top = Master.AppPos.Top + (Master.AppPos.Height - Me.Height) \ 2
        Me.StartPosition = FormStartPosition.Manual
    End Sub

    Public Overloads Function ShowDialog(ByVal DBMovie As Database.DBElement) As DialogResult
        Me.tmpDBMovie = DBMovie
        Return MyBase.ShowDialog()
    End Function

    Private Sub AddETImage(ByVal sDescription As String, ByVal iIndex As Integer, Extrathumb As ExtraImages)
        Try
            ReDim Preserve Me.pnlETImage(iIndex)
            ReDim Preserve Me.pbETImage(iIndex)
            Me.pnlETImage(iIndex) = New Panel()
            Me.pbETImage(iIndex) = New PictureBox()
            Me.pbETImage(iIndex).Name = iIndex.ToString
            Me.pnlETImage(iIndex).Name = iIndex.ToString
            Me.pnlETImage(iIndex).Size = New Size(128, 72)
            Me.pbETImage(iIndex).Size = New Size(128, 72)
            Me.pnlETImage(iIndex).BackColor = Color.White
            Me.pnlETImage(iIndex).BorderStyle = BorderStyle.FixedSingle
            Me.pbETImage(iIndex).SizeMode = PictureBoxSizeMode.Zoom
            Me.pnlETImage(iIndex).Tag = Extrathumb.Image
            Me.pbETImage(iIndex).Tag = Extrathumb.Image
            Me.pbETImage(iIndex).Image = CType(Extrathumb.Image.Image.Clone(), Image)
            Me.pnlETImage(iIndex).Left = iETLeft
            Me.pbETImage(iIndex).Left = 0
            Me.pnlETImage(iIndex).Top = iETTop
            Me.pbETImage(iIndex).Top = 0
            Me.pnlEThumbsBG.Controls.Add(Me.pnlETImage(iIndex))
            Me.pnlETImage(iIndex).Controls.Add(Me.pbETImage(iIndex))
            Me.pnlETImage(iIndex).BringToFront()
            AddHandler pbETImage(iIndex).Click, AddressOf pbETImage_Click
            AddHandler pnlETImage(iIndex).Click, AddressOf pnlETImage_Click
        Catch ex As Exception
            logger.Error(New StackFrame().GetMethod().Name, ex)
        End Try

        Me.iETTop += 74

    End Sub

    Private Sub AddEFImage(ByVal sDescription As String, ByVal iIndex As Integer, Extrafanart As ExtraImages)
        Try
            ReDim Preserve Me.pnlEFImage(iIndex)
            ReDim Preserve Me.pbEFImage(iIndex)
            Me.pnlEFImage(iIndex) = New Panel()
            Me.pbEFImage(iIndex) = New PictureBox()
            Me.pbEFImage(iIndex).Name = iIndex.ToString
            Me.pnlEFImage(iIndex).Name = iIndex.ToString
            Me.pnlEFImage(iIndex).Size = New Size(128, 72)
            Me.pbEFImage(iIndex).Size = New Size(128, 72)
            Me.pnlEFImage(iIndex).BackColor = Color.White
            Me.pnlEFImage(iIndex).BorderStyle = BorderStyle.FixedSingle
            Me.pbEFImage(iIndex).SizeMode = PictureBoxSizeMode.Zoom
            Me.pnlEFImage(iIndex).Tag = Extrafanart.Image
            Me.pbEFImage(iIndex).Tag = Extrafanart.Image
            Me.pbEFImage(iIndex).Image = CType(Extrafanart.Image.Image.Clone(), Image)
            Me.pnlEFImage(iIndex).Left = iEFLeft
            Me.pbEFImage(iIndex).Left = 0
            Me.pnlEFImage(iIndex).Top = iEFTop
            Me.pbEFImage(iIndex).Top = 0
            Me.pnlEFanartsBG.Controls.Add(Me.pnlEFImage(iIndex))
            Me.pnlEFImage(iIndex).Controls.Add(Me.pbEFImage(iIndex))
            Me.pnlEFImage(iIndex).BringToFront()
            AddHandler pbEFImage(iIndex).Click, AddressOf pbEFImage_Click
            AddHandler pnlEFImage(iIndex).Click, AddressOf pnlEFImage_Click
        Catch ex As Exception
            logger.Error(New StackFrame().GetMethod().Name, ex)
        End Try

        Me.iEFTop += 74

    End Sub

    Private Sub pbETImage_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.DoSelectET(Convert.ToInt32(DirectCast(sender, PictureBox).Name), DirectCast(DirectCast(sender, PictureBox).Tag, Images))
    End Sub

    Private Sub pnlETImage_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.DoSelectET(Convert.ToInt32(DirectCast(sender, Panel).Name), DirectCast(DirectCast(sender, Panel).Tag, Images))
    End Sub

    Private Sub pbEFImage_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.DoSelectEF(Convert.ToInt32(DirectCast(sender, PictureBox).Name), DirectCast(DirectCast(sender, PictureBox).Tag, Images))
    End Sub

    Private Sub pnlEFImage_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.DoSelectEF(Convert.ToInt32(DirectCast(sender, Panel).Name), DirectCast(DirectCast(sender, Panel).Tag, Images))
    End Sub

    Private Sub DoSelectET(ByVal iIndex As Integer, tPoster As Images)
        Try
            Me.pbEThumbs.Image = tPoster.Image
            Me.pbEThumbs.Tag = tPoster
            Me.btnEThumbsSetAsFanart.Enabled = True
            Me.EThumbsIndex = iIndex
            Me.lblEThumbsSize.Text = String.Format(Master.eLang.GetString(269, "Size: {0}x{1}"), Me.pbEThumbs.Image.Width, Me.pbEThumbs.Image.Height)
            Me.lblEThumbsSize.Visible = True
        Catch ex As Exception
            logger.Error(New StackFrame().GetMethod().Name, ex)
        End Try
    End Sub

    Private Sub DoSelectEF(ByVal iIndex As Integer, tPoster As Images)
        Try
            Me.pbEFanarts.Image = tPoster.Image
            Me.pbEFanarts.Tag = tPoster
            Me.btnEFanartsSetAsFanart.Enabled = True
            Me.EFanartsIndex = iIndex
            Me.lblEFanartsSize.Text = String.Format(Master.eLang.GetString(269, "Size: {0}x{1}"), Me.pbEFanarts.Image.Width, Me.pbEFanarts.Image.Height)
            Me.lblEFanartsSize.Visible = True
        Catch ex As Exception
            logger.Error(New StackFrame().GetMethod().Name, ex)
        End Try
    End Sub

    Private Sub btnActorDown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActorDown.Click
        If Me.lvActors.SelectedItems.Count > 0 AndAlso Me.lvActors.SelectedItems(0) IsNot Nothing AndAlso Me.lvActors.SelectedIndices(0) < (Me.lvActors.Items.Count - 1) Then
            Dim iIndex As Integer = Me.lvActors.SelectedIndices(0)
            Me.lvActors.Items.Insert(iIndex + 2, DirectCast(Me.lvActors.SelectedItems(0).Clone, ListViewItem))
            Me.lvActors.Items.RemoveAt(iIndex)
            Me.lvActors.Items(iIndex + 1).Selected = True
            Me.lvActors.Select()
        End If
    End Sub

    Private Sub btnActorUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActorUp.Click
        Try
            If Me.lvActors.SelectedItems.Count > 0 AndAlso Me.lvActors.SelectedItems(0) IsNot Nothing AndAlso Me.lvActors.SelectedIndices(0) > 0 Then
                Dim iIndex As Integer = Me.lvActors.SelectedIndices(0)
                Me.lvActors.Items.Insert(iIndex - 1, DirectCast(Me.lvActors.SelectedItems(0).Clone, ListViewItem))
                Me.lvActors.Items.RemoveAt(iIndex + 1)
                Me.lvActors.Items(iIndex - 1).Selected = True
                Me.lvActors.Select()
            End If
        Catch ex As Exception
            logger.Error(New StackFrame().GetMethod().Name, ex)
        End Try
    End Sub

    Private Sub btnAddActor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddActor.Click
        Try
            Dim eActor As New MediaContainers.Person
            Using dAddEditActor As New dlgAddEditActor
                eActor = dAddEditActor.ShowDialog(True)
            End Using
            If eActor IsNot Nothing Then
                Dim lvItem As ListViewItem = Me.lvActors.Items.Add(eActor.ID.ToString)
                lvItem.SubItems.Add(eActor.Name)
                lvItem.SubItems.Add(eActor.Role)
                lvItem.SubItems.Add(eActor.ThumbURL)
                ActorThumbsHasChanged = True
            End If
        Catch ex As Exception
            logger.Error(New StackFrame().GetMethod().Name, ex)
        End Try
    End Sub

    Private Sub btnChangeMovie_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChangeMovie.Click
        Me.ThemeStop()
        Me.TrailerStop()
        Me.CleanUp()
        ' ***
        Me.DialogResult = System.Windows.Forms.DialogResult.Abort
        Me.Close()
    End Sub

    Private Sub btnDLTheme_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim aUrlList As New List(Of Themes)
        'Dim tURL As String = String.Empty
        'If Not ModulesManager.Instance.ScrapeTheme_Movie(Me.tmpDBMovie, aUrlList) Then
        '    Using dThemeSelect As New dlgThemeSelect()
        '        MovieTheme = dThemeSelect.ShowDialog(Me.tmpDBMovie, aUrlList)
        '    End Using
        'End If

        'If Not String.IsNullOrEmpty(MovieTheme.URL) Then
        '    'Me.btnPlayTheme.Enabled = True
        'End If
    End Sub

    Private Sub btnDLTrailer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDLTrailer.Click
        Dim tResults As New MediaContainers.Trailer
        Dim dlgTrlS As dlgTrailerSelect
        Dim tList As New List(Of MediaContainers.Trailer)
        Dim tURL As String = String.Empty

        Try
            dlgTrlS = New dlgTrailerSelect()
            If dlgTrlS.ShowDialog(Me.tmpDBMovie, tList, True, True, True) = Windows.Forms.DialogResult.OK Then
                tURL = dlgTrlS.Results.WebURL
            End If

            If Not String.IsNullOrEmpty(tURL) Then
                Me.btnPlayTrailer.Enabled = True
                Me.txtTrailer.Text = tURL
            End If
        Catch ex As Exception
            logger.Error(New StackFrame().GetMethod().Name, ex)
        End Try
    End Sub

    ' temporarily disabled
    'Private Sub btnEThumbsDown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEThumbsDown.Click
    '    Try
    '        If EThumbsList.Count > 0 AndAlso EThumbsIndex < (EThumbsList.Count - 1) Then
    '            Dim iIndex As Integer = EThumbsIndex
    '            EThumbsList.Item(iIndex).Index = EThumbsList.Item(iIndex).Index + 1
    '            EThumbsList.Item(iIndex + 1).Index = EThumbsList.Item(iIndex + 1).Index - 1
    '        End If
    '    Catch ex As Exception
    '        logger.Error(New StackFrame().GetMethod().Name, ex)
    '    End Try
    'End Sub

    Private Sub btnEditActor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditActor.Click
        EditActor()
    End Sub

    Private Sub btnManual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnManual.Click
        Try
            If dlgManualEdit.ShowDialog(Me.tmpDBMovie.NfoPath) = Windows.Forms.DialogResult.OK Then
                Me.tmpDBMovie.Movie = NFO.LoadMovieFromNFO(Me.tmpDBMovie.NfoPath, Me.tmpDBMovie.IsSingle)
                Me.FillInfo(False)
            End If
        Catch ex As Exception
            logger.Error(New StackFrame().GetMethod().Name, ex)
        End Try
    End Sub

    Private Sub btnPlayTrailer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlayTrailer.Click
        'TODO 2013/12/18 Dekker500 - This should be re-factored to use Functions.Launch. Why is the URL different for non-windows??? Need to test first before editing
        Try

            Dim tPath As String = String.Empty

            If Not String.IsNullOrEmpty(Me.txtTrailer.Text) Then
                tPath = String.Concat("""", Me.txtTrailer.Text, """")
            End If

            If Not String.IsNullOrEmpty(tPath) Then
                If Master.isWindows Then
                    If Regex.IsMatch(tPath, "plugin:\/\/plugin\.video\.youtube\/\?action=play_video&videoid=") Then
                        tPath = tPath.Replace("plugin://plugin.video.youtube/?action=play_video&videoid=", "http://www.youtube.com/watch?v=")
                    End If
                    Process.Start(tPath)
                Else
                    Using Explorer As New Process
                        Explorer.StartInfo.FileName = "xdg-open"
                        Explorer.StartInfo.Arguments = tPath
                        Explorer.Start()
                    End Using
                End If
            End If

        Catch
            MessageBox.Show(Master.eLang.GetString(270, "The trailer could not be played. This could be due to an invalid URI or you do not have the proper player to play the trailer type."), Master.eLang.GetString(271, "Error Playing Trailer"), MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub btnPlayTheme_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'TODO 2013/12/18 Dekker500 - This should be re-factored to use Functions.Launch. Why is the URL different for non-windows??? Need to test first before editing
        Try

            Dim tPath As String = String.Empty

            If Not String.IsNullOrEmpty(Me.tmpDBMovie.ThemePath) Then
                tPath = String.Concat("""", Me.tmpDBMovie.ThemePath, """")
            End If

            If Not String.IsNullOrEmpty(tPath) Then
                If Master.isWindows Then
                    Process.Start(tPath)
                Else
                    Using Explorer As New Process
                        Explorer.StartInfo.FileName = "xdg-open"
                        Explorer.StartInfo.Arguments = tPath
                        Explorer.Start()
                    End Using
                End If
            End If

        Catch
            MessageBox.Show(Master.eLang.GetString(1078, "The theme could not be played. This could due be you don't have the proper player to play the theme type."), Master.eLang.GetString(1079, "Error Playing Theme"), MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub btnRemoveBanner_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveBanner.Click
        Me.pbBanner.Image = Nothing
        Me.pbBanner.Tag = Nothing
        Me.tmpDBMovie.ImagesContainer.Banner = New MediaContainers.Image
    End Sub

    Private Sub btnRemoveClearArt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveClearArt.Click
        Me.pbClearArt.Image = Nothing
        Me.pbClearArt.Tag = Nothing
        Me.tmpDBMovie.ImagesContainer.ClearArt = New MediaContainers.Image
    End Sub

    Private Sub btnRemoveClearLogo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveClearLogo.Click
        Me.pbClearLogo.Image = Nothing
        Me.pbClearLogo.Tag = Nothing
        Me.tmpDBMovie.ImagesContainer.ClearLogo = New MediaContainers.Image
    End Sub

    Private Sub btnRemoveDiscArt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveDiscArt.Click
        Me.pbDiscArt.Image = Nothing
        Me.pbDiscArt.Tag = Nothing
        Me.tmpDBMovie.ImagesContainer.DiscArt = New MediaContainers.Image
    End Sub

    Private Sub btnRemoveFanart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveFanart.Click
        Me.pbFanart.Image = Nothing
        Me.pbFanart.Tag = Nothing
        Me.tmpDBMovie.ImagesContainer.Fanart = New MediaContainers.Image
    End Sub

    Private Sub btnRemoveLandscape_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveLandscape.Click
        Me.pbLandscape.Image = Nothing
        Me.pbLandscape.Tag = Nothing
        Me.tmpDBMovie.ImagesContainer.Landscape = New MediaContainers.Image
    End Sub

    Private Sub btnRemovePoster_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemovePoster.Click
        Me.pbPoster.Image = Nothing
        Me.pbPoster.Tag = Nothing
        Me.tmpDBMovie.ImagesContainer.Poster = New MediaContainers.Image
    End Sub

    Private Sub btnRemoveSubtitle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveSubtitle.Click
        Me.DeleteSubtitle()
    End Sub

    Private Sub btnRemoveTheme_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveTheme.Click
        Me.ThemeStop()
        'Me.axVLCTheme.playlist.items.clear()
        Me.MovieTheme.Dispose()
        Me.MovieTheme.toRemove = True
    End Sub

    Private Sub btnRemoveTrailer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveTrailer.Click
        Me.TrailerStop()
        Me.TrailerPlaylistClear()
        Me.MovieTrailer.WebTrailer.Dispose()
        Me.MovieTrailer.WebTrailer.toRemove = True
    End Sub

    Private Sub btnEThumbsRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEThumbsRemove.Click
        Me.DeleteEThumbs()
        Me.RefreshEThumbs()
        Me.lblEThumbsSize.Text = ""
        Me.lblEThumbsSize.Visible = False
    End Sub

    Private Sub btnEFanartsRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEFanartsRemove.Click
        Me.DeleteEFanarts()
        Me.RefreshEFanarts()
        Me.lblEFanartsSize.Text = ""
        Me.lblEFanartsSize.Visible = False
    End Sub

    Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click
        Me.DeleteActors()
    End Sub

    Private Sub btnRescrape_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRescrape.Click
        Me.ThemeStop()
        Me.TrailerStop()
        Me.CleanUp()
        ' ***
        Me.DialogResult = System.Windows.Forms.DialogResult.Retry
        Me.Close()
    End Sub

    Private Sub btnSetBannerDL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetBannerDL.Click
        Try
            Using dImgManual As New dlgImgManual
                Dim tImage As MediaContainers.Image
                If dImgManual.ShowDialog() = DialogResult.OK Then
                    tImage = dImgManual.Results
                    If tImage.WebImage.Image IsNot Nothing Then
                        Me.tmpDBMovie.ImagesContainer.Banner = tImage
                        Me.pbBanner.Image = Me.tmpDBMovie.ImagesContainer.Banner.WebImage.Image
                        Me.pbBanner.Tag = Me.tmpDBMovie.ImagesContainer.Banner

                        Me.lblBannerSize.Text = String.Format(Master.eLang.GetString(269, "Size: {0}x{1}"), Me.pbBanner.Image.Width, Me.pbBanner.Image.Height)
                        Me.lblBannerSize.Visible = True
                    End If
                End If
            End Using
        Catch ex As Exception
            logger.Error(New StackFrame().GetMethod().Name, ex)
        End Try
    End Sub

    Private Sub btnSetBannerScrape_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetBannerScrape.Click
        Dim aContainer As New MediaContainers.SearchResultsContainer
        Dim ScrapeModifier As New Structures.ScrapeModifier

        Functions.SetScrapeModifier(ScrapeModifier, Enums.ModifierType.MainBanner, True)
        If Not ModulesManager.Instance.ScrapeImage_Movie(Me.tmpDBMovie, aContainer, ScrapeModifier, True) Then
            If aContainer.MainBanners.Count > 0 Then
                Dim dlgImgS = New dlgImgSelectNew()
                If dlgImgS.ShowDialog(Me.tmpDBMovie, aContainer, ScrapeModifier, Enums.ContentType.Movie) = Windows.Forms.DialogResult.OK Then
                    Dim pResults As MediaContainers.Image = dlgImgS.Result.ImagesContainer.Banner
                    Me.tmpDBMovie.ImagesContainer.Banner = pResults
                    If pResults.WebImage.Image IsNot Nothing Then
                        Me.pbBanner.Image = CType(pResults.WebImage.Image.Clone(), Image)
                        Me.lblBannerSize.Text = String.Format(Master.eLang.GetString(269, "Size: {0}x{1}"), Me.pbBanner.Image.Width, Me.pbBanner.Image.Height)
                        Me.lblBannerSize.Visible = True
                    End If
                    Cursor = Cursors.Default
                End If
            Else
                MessageBox.Show(Master.eLang.GetString(1363, "No Banners found"), String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub btnSetBannerLocal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetBannerLocal.Click
        Try
            With ofdLocalFiles
                .InitialDirectory = Directory.GetParent(Me.tmpDBMovie.Filename).FullName
                .Filter = Master.eLang.GetString(497, "Images") + "|*.jpg;*.png"
                .FilterIndex = 0
            End With

            If ofdLocalFiles.ShowDialog() = DialogResult.OK Then
                Me.tmpDBMovie.ImagesContainer.Banner.WebImage.FromFile(ofdLocalFiles.FileName)
                Me.pbBanner.Image = Me.tmpDBMovie.ImagesContainer.Banner.WebImage.Image
                Me.pbBanner.Tag = Me.tmpDBMovie.ImagesContainer.Banner

                Me.lblBannerSize.Text = String.Format(Master.eLang.GetString(269, "Size: {0}x{1}"), Me.pbBanner.Image.Width, Me.pbBanner.Image.Height)
                Me.lblBannerSize.Visible = True
            End If
        Catch ex As Exception
            logger.Error(New StackFrame().GetMethod().Name, ex)
        End Try
    End Sub

    Private Sub btnSetClearArtDL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetClearArtDL.Click
        Try
            Using dImgManual As New dlgImgManual
                Dim tImage As MediaContainers.Image
                If dImgManual.ShowDialog() = DialogResult.OK Then
                    tImage = dImgManual.Results
                    If tImage.WebImage.Image IsNot Nothing Then
                        Me.tmpDBMovie.ImagesContainer.ClearArt = tImage
                        Me.pbClearArt.Image = Me.tmpDBMovie.ImagesContainer.ClearArt.WebImage.Image
                        Me.pbClearArt.Tag = Me.tmpDBMovie.ImagesContainer.ClearArt

                        Me.lblClearArtSize.Text = String.Format(Master.eLang.GetString(269, "Size: {0}x{1}"), Me.pbClearArt.Image.Width, Me.pbClearArt.Image.Height)
                        Me.lblClearArtSize.Visible = True
                    End If
                End If
            End Using
        Catch ex As Exception
            logger.Error(New StackFrame().GetMethod().Name, ex)
        End Try
    End Sub

    Private Sub btnSetClearArtScrape_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetClearArtScrape.Click
        Dim aContainer As New MediaContainers.SearchResultsContainer
        Dim ScrapeModifier As New Structures.ScrapeModifier

        Functions.SetScrapeModifier(ScrapeModifier, Enums.ModifierType.MainClearArt, True)
        If Not ModulesManager.Instance.ScrapeImage_Movie(Me.tmpDBMovie, aContainer, ScrapeModifier, True) Then
            If aContainer.MainClearArts.Count > 0 Then
                Dim dlgImgS = New dlgImgSelectNew()
                If dlgImgS.ShowDialog(Me.tmpDBMovie, aContainer, ScrapeModifier, Enums.ContentType.Movie) = Windows.Forms.DialogResult.OK Then
                    Dim pResults As MediaContainers.Image = dlgImgS.Result.ImagesContainer.ClearArt
                    Me.tmpDBMovie.ImagesContainer.ClearArt = pResults
                    If pResults.WebImage.Image IsNot Nothing Then
                        Me.pbClearArt.Image = CType(pResults.WebImage.Image.Clone(), Image)
                        Me.lblClearArtSize.Text = String.Format(Master.eLang.GetString(269, "Size: {0}x{1}"), Me.pbClearArt.Image.Width, Me.pbClearArt.Image.Height)
                        Me.lblClearArtSize.Visible = True
                    End If
                    Cursor = Cursors.Default
                End If
            Else
                MessageBox.Show(Master.eLang.GetString(1102, "No ClearArts found"), String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub btnSetClearArtLocal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetClearArtLocal.Click
        Try
            With ofdLocalFiles
                .InitialDirectory = Directory.GetParent(Me.tmpDBMovie.Filename).FullName
                .Filter = Master.eLang.GetString(497, "Images") + "|*.png"
                .FilterIndex = 0
            End With

            If ofdLocalFiles.ShowDialog() = DialogResult.OK Then
                Me.tmpDBMovie.ImagesContainer.ClearArt.WebImage.FromFile(ofdLocalFiles.FileName)
                Me.pbClearArt.Image = Me.tmpDBMovie.ImagesContainer.ClearArt.WebImage.Image
                Me.pbClearArt.Tag = Me.tmpDBMovie.ImagesContainer.ClearArt

                Me.lblClearArtSize.Text = String.Format(Master.eLang.GetString(269, "Size: {0}x{1}"), Me.pbClearArt.Image.Width, Me.pbClearArt.Image.Height)
                Me.lblClearArtSize.Visible = True
            End If
        Catch ex As Exception
            logger.Error(New StackFrame().GetMethod().Name, ex)
        End Try
    End Sub

    Private Sub btnSetClearLogoDL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetClearLogoDL.Click
        Try
            Using dImgManual As New dlgImgManual
                Dim tImage As MediaContainers.Image
                If dImgManual.ShowDialog() = DialogResult.OK Then
                    tImage = dImgManual.Results
                    If tImage.WebImage.Image IsNot Nothing Then
                        Me.tmpDBMovie.ImagesContainer.ClearLogo = tImage
                        Me.pbClearLogo.Image = Me.tmpDBMovie.ImagesContainer.ClearLogo.WebImage.Image
                        Me.pbClearLogo.Tag = Me.tmpDBMovie.ImagesContainer.ClearLogo

                        Me.lblClearLogoSize.Text = String.Format(Master.eLang.GetString(269, "Size: {0}x{1}"), Me.pbClearLogo.Image.Width, Me.pbClearLogo.Image.Height)
                        Me.lblClearLogoSize.Visible = True
                    End If
                End If
            End Using
        Catch ex As Exception
            logger.Error(New StackFrame().GetMethod().Name, ex)
        End Try
    End Sub

    Private Sub btnSetClearLogoScrape_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetClearLogoScrape.Click
        Dim aContainer As New MediaContainers.SearchResultsContainer
        Dim ScrapeModifier As New Structures.ScrapeModifier

        Functions.SetScrapeModifier(ScrapeModifier, Enums.ModifierType.MainClearLogo, True)
        If Not ModulesManager.Instance.ScrapeImage_Movie(Me.tmpDBMovie, aContainer, ScrapeModifier, True) Then
            If aContainer.MainClearLogos.Count > 0 Then
                Dim dlgImgS = New dlgImgSelectNew()
                If dlgImgS.ShowDialog(Me.tmpDBMovie, aContainer, ScrapeModifier, Enums.ContentType.Movie) = Windows.Forms.DialogResult.OK Then
                    Dim pResults As MediaContainers.Image = dlgImgS.Result.ImagesContainer.ClearLogo
                    Me.tmpDBMovie.ImagesContainer.ClearLogo = pResults
                    If pResults.WebImage.Image IsNot Nothing Then
                        Me.pbClearLogo.Image = CType(pResults.WebImage.Image.Clone(), Image)
                        Me.lblClearLogoSize.Text = String.Format(Master.eLang.GetString(269, "Size: {0}x{1}"), Me.pbClearLogo.Image.Width, Me.pbClearLogo.Image.Height)
                        Me.lblClearLogoSize.Visible = True
                    End If
                    Cursor = Cursors.Default
                End If
            Else
                MessageBox.Show(Master.eLang.GetString(1103, "No ClearLogos found"), String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub btnSetClearLogoLocal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetClearLogoLocal.Click
        Try
            With ofdLocalFiles
                .InitialDirectory = Directory.GetParent(Me.tmpDBMovie.Filename).FullName
                .Filter = Master.eLang.GetString(497, "Images") + "|*.png"
                .FilterIndex = 0
            End With

            If ofdLocalFiles.ShowDialog() = DialogResult.OK Then
                Me.tmpDBMovie.ImagesContainer.ClearLogo.WebImage.FromFile(ofdLocalFiles.FileName)
                Me.pbClearLogo.Image = Me.tmpDBMovie.ImagesContainer.ClearLogo.WebImage.Image
                Me.pbClearLogo.Tag = Me.tmpDBMovie.ImagesContainer.ClearLogo

                Me.lblClearLogoSize.Text = String.Format(Master.eLang.GetString(269, "Size: {0}x{1}"), Me.pbClearLogo.Image.Width, Me.pbClearLogo.Image.Height)
                Me.lblClearLogoSize.Visible = True
            End If
        Catch ex As Exception
            logger.Error(New StackFrame().GetMethod().Name, ex)
        End Try
    End Sub

    Private Sub btnSetDiscArtDL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetDiscArtDL.Click
        Try
            Using dImgManual As New dlgImgManual
                Dim tImage As MediaContainers.Image
                If dImgManual.ShowDialog() = DialogResult.OK Then
                    tImage = dImgManual.Results
                    If tImage.WebImage.Image IsNot Nothing Then
                        Me.tmpDBMovie.ImagesContainer.DiscArt = tImage
                        Me.pbDiscArt.Image = Me.tmpDBMovie.ImagesContainer.DiscArt.WebImage.Image
                        Me.pbDiscArt.Tag = Me.tmpDBMovie.ImagesContainer.DiscArt

                        Me.lblDiscArtSize.Text = String.Format(Master.eLang.GetString(269, "Size: {0}x{1}"), Me.pbDiscArt.Image.Width, Me.pbDiscArt.Image.Height)
                        Me.lblDiscArtSize.Visible = True
                    End If
                End If
            End Using
        Catch ex As Exception
            logger.Error(New StackFrame().GetMethod().Name, ex)
        End Try
    End Sub

    Private Sub btnSetDiscArtScrape_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetDiscArtScrape.Click
        Dim aContainer As New MediaContainers.SearchResultsContainer
        Dim ScrapeModifier As New Structures.ScrapeModifier

        Functions.SetScrapeModifier(ScrapeModifier, Enums.ModifierType.MainDiscArt, True)
        If Not ModulesManager.Instance.ScrapeImage_Movie(Me.tmpDBMovie, aContainer, ScrapeModifier, True) Then
            If aContainer.MainDiscArts.Count > 0 Then
                Dim dlgImgS = New dlgImgSelectNew()
                If dlgImgS.ShowDialog(Me.tmpDBMovie, aContainer, ScrapeModifier, Enums.ContentType.Movie) = Windows.Forms.DialogResult.OK Then
                    Dim pResults As MediaContainers.Image = dlgImgS.Result.ImagesContainer.DiscArt
                    Me.tmpDBMovie.ImagesContainer.DiscArt = pResults
                    If pResults.WebImage.Image IsNot Nothing Then
                        Me.pbDiscArt.Image = CType(pResults.WebImage.Image.Clone(), Image)
                        Me.lblDiscArtSize.Text = String.Format(Master.eLang.GetString(269, "Size: {0}x{1}"), Me.pbDiscArt.Image.Width, Me.pbDiscArt.Image.Height)
                        Me.lblDiscArtSize.Visible = True
                    End If
                    Cursor = Cursors.Default
                End If
            Else
                MessageBox.Show(Master.eLang.GetString(1104, "No DiscArts found"), String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub btnSetDiscArtLocal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetDiscArtLocal.Click
        Try
            With ofdLocalFiles
                .InitialDirectory = Directory.GetParent(Me.tmpDBMovie.Filename).FullName
                .Filter = Master.eLang.GetString(497, "Images") + "|*.png"
                .FilterIndex = 0
            End With

            If ofdLocalFiles.ShowDialog() = DialogResult.OK Then
                Me.tmpDBMovie.ImagesContainer.DiscArt.WebImage.FromFile(ofdLocalFiles.FileName)
                Me.pbDiscArt.Image = Me.tmpDBMovie.ImagesContainer.DiscArt.WebImage.Image
                Me.pbDiscArt.Tag = Me.tmpDBMovie.ImagesContainer.DiscArt

                Me.lblDiscArtSize.Text = String.Format(Master.eLang.GetString(269, "Size: {0}x{1}"), Me.pbDiscArt.Image.Width, Me.pbDiscArt.Image.Height)
                Me.lblDiscArtSize.Visible = True
            End If
        Catch ex As Exception
            logger.Error(New StackFrame().GetMethod().Name, ex)
        End Try
    End Sub

    Private Sub btnEThumbsSetAsFanart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEThumbsSetAsFanart.Click
        If Not String.IsNullOrEmpty(Me.EThumbsList.Item(Me.EThumbsIndex).Path) AndAlso Me.EThumbsList.Item(Me.EThumbsIndex).Path.Substring(0, 1) = ":" Then
            Me.tmpDBMovie.ImagesContainer.Fanart.WebImage.FromWeb(Me.EThumbsList.Item(Me.EThumbsIndex).Path.Substring(1, Me.EThumbsList.Item(Me.EThumbsIndex).Path.Length - 1))
        Else
            Me.tmpDBMovie.ImagesContainer.Fanart.WebImage.FromFile(Me.EThumbsList.Item(Me.EThumbsIndex).Path)
        End If
        If Me.tmpDBMovie.ImagesContainer.Fanart.WebImage.Image IsNot Nothing Then
            Me.pbFanart.Image = Me.tmpDBMovie.ImagesContainer.Fanart.WebImage.Image
            Me.pbFanart.Tag = Me.tmpDBMovie.ImagesContainer.Fanart

            Me.lblFanartSize.Text = String.Format(Master.eLang.GetString(269, "Size: {0}x{1}"), Me.pbFanart.Image.Width, Me.pbFanart.Image.Height)
            Me.lblFanartSize.Visible = True
        End If
    End Sub

    Private Sub btnEFanartsSetAsFanart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEFanartsSetAsFanart.Click
        If Not String.IsNullOrEmpty(Me.EFanartsList.Item(Me.EFanartsIndex).Path) AndAlso Me.EFanartsList.Item(Me.EFanartsIndex).Path.Substring(0, 1) = ":" Then
            Me.tmpDBMovie.ImagesContainer.Fanart.WebImage.FromWeb(Me.EFanartsList.Item(Me.EFanartsIndex).Path.Substring(1, Me.EFanartsList.Item(Me.EFanartsIndex).Path.Length - 1))
        Else
            Me.tmpDBMovie.ImagesContainer.Fanart.WebImage.FromFile(Me.EFanartsList.Item(Me.EFanartsIndex).Path)
        End If
        If Me.tmpDBMovie.ImagesContainer.Fanart.WebImage.Image IsNot Nothing Then
            Me.pbFanart.Image = Me.tmpDBMovie.ImagesContainer.Fanart.WebImage.Image
            Me.pbFanart.Tag = Me.tmpDBMovie.ImagesContainer.Fanart

            Me.lblFanartSize.Text = String.Format(Master.eLang.GetString(269, "Size: {0}x{1}"), Me.pbFanart.Image.Width, Me.pbFanart.Image.Height)
            Me.lblFanartSize.Visible = True
        End If
    End Sub

    Private Sub btnSetFanartDL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetFanartDL.Click
        Try
            Using dImgManual As New dlgImgManual
                Dim tImage As MediaContainers.Image
                If dImgManual.ShowDialog() = DialogResult.OK Then
                    tImage = dImgManual.Results
                    If tImage.WebImage.Image IsNot Nothing Then
                        Me.tmpDBMovie.ImagesContainer.Fanart = tImage
                        Me.pbFanart.Image = Me.tmpDBMovie.ImagesContainer.Fanart.WebImage.Image
                        Me.pbFanart.Tag = Me.tmpDBMovie.ImagesContainer.Fanart

                        Me.lblFanartSize.Text = String.Format(Master.eLang.GetString(269, "Size: {0}x{1}"), Me.pbFanart.Image.Width, Me.pbFanart.Image.Height)
                        Me.lblFanartSize.Visible = True
                    End If
                End If
            End Using
        Catch ex As Exception
            logger.Error(New StackFrame().GetMethod().Name, ex)
        End Try
    End Sub

    Private Sub btnSetFanartScrape_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetFanartScrape.Click
        Dim aContainer As New MediaContainers.SearchResultsContainer
        Dim ScrapeModifier As New Structures.ScrapeModifier

        Functions.SetScrapeModifier(ScrapeModifier, Enums.ModifierType.MainFanart, True)
        If Not ModulesManager.Instance.ScrapeImage_Movie(Me.tmpDBMovie, aContainer, ScrapeModifier, True) Then
            If aContainer.MainFanarts.Count > 0 Then
                Dim dlgImgS = New dlgImgSelectNew()
                If dlgImgS.ShowDialog(Me.tmpDBMovie, aContainer, ScrapeModifier, Enums.ContentType.Movie) = Windows.Forms.DialogResult.OK Then
                    Dim pResults As MediaContainers.Image = dlgImgS.Result.ImagesContainer.Fanart
                    Me.tmpDBMovie.ImagesContainer.Fanart = pResults
                    If pResults.WebImage.Image IsNot Nothing Then
                        Me.pbFanart.Image = CType(pResults.WebImage.Image.Clone(), Image)
                        Me.lblFanartSize.Text = String.Format(Master.eLang.GetString(269, "Size: {0}x{1}"), Me.pbFanart.Image.Width, Me.pbFanart.Image.Height)
                        Me.lblFanartSize.Visible = True
                    End If
                    Cursor = Cursors.Default
                End If
            Else
                MessageBox.Show(Master.eLang.GetString(970, "No Fanarts found"), String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If

        RefreshEFanarts()
        RefreshEThumbs()
    End Sub

    Private Sub btnSetFanartLocal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetFanartLocal.Click
        Try
            With ofdLocalFiles
                .InitialDirectory = Directory.GetParent(Me.tmpDBMovie.Filename).FullName
                .Filter = Master.eLang.GetString(497, "Images") + "|*.jpg;*.png"
                .FilterIndex = 4
            End With

            If ofdLocalFiles.ShowDialog() = DialogResult.OK Then
                Me.tmpDBMovie.ImagesContainer.Fanart.WebImage.FromFile(ofdLocalFiles.FileName)
                Me.pbFanart.Image = Me.tmpDBMovie.ImagesContainer.Fanart.WebImage.Image
                Me.pbFanart.Tag = Me.tmpDBMovie.ImagesContainer.Fanart

                Me.lblFanartSize.Text = String.Format(Master.eLang.GetString(269, "Size: {0}x{1}"), Me.pbFanart.Image.Width, Me.pbFanart.Image.Height)
                Me.lblFanartSize.Visible = True
            End If
        Catch ex As Exception
            logger.Error(New StackFrame().GetMethod().Name, ex)
        End Try
    End Sub

    Private Sub btnSetLandscapeDL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetLandscapeDL.Click
        Try
            Using dImgManual As New dlgImgManual
                Dim tImage As MediaContainers.Image
                If dImgManual.ShowDialog() = DialogResult.OK Then
                    tImage = dImgManual.Results
                    If tImage.WebImage.Image IsNot Nothing Then
                        Me.tmpDBMovie.ImagesContainer.Landscape = tImage
                        Me.pbLandscape.Image = Me.tmpDBMovie.ImagesContainer.Landscape.WebImage.Image
                        Me.pbLandscape.Tag = Me.tmpDBMovie.ImagesContainer.Landscape

                        Me.lblLandscapeSize.Text = String.Format(Master.eLang.GetString(269, "Size: {0}x{1}"), Me.pbLandscape.Image.Width, Me.pbLandscape.Image.Height)
                        Me.lblLandscapeSize.Visible = True
                    End If
                End If
            End Using
        Catch ex As Exception
            logger.Error(New StackFrame().GetMethod().Name, ex)
        End Try
    End Sub

    Private Sub btnSetLandscapeScrape_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetLandscapeScrape.Click
        Dim aContainer As New MediaContainers.SearchResultsContainer
        Dim ScrapeModifier As New Structures.ScrapeModifier

        Functions.SetScrapeModifier(ScrapeModifier, Enums.ModifierType.MainLandscape, True)
        If Not ModulesManager.Instance.ScrapeImage_Movie(Me.tmpDBMovie, aContainer, ScrapeModifier, True) Then
            If aContainer.MainLandscapes.Count > 0 Then
                Dim dlgImgS = New dlgImgSelectNew()
                If dlgImgS.ShowDialog(Me.tmpDBMovie, aContainer, ScrapeModifier, Enums.ContentType.Movie) = Windows.Forms.DialogResult.OK Then
                    Dim pResults As MediaContainers.Image = dlgImgS.Result.ImagesContainer.Landscape
                    Me.tmpDBMovie.ImagesContainer.Landscape = pResults
                    If pResults.WebImage.Image IsNot Nothing Then
                        Me.pbLandscape.Image = CType(pResults.WebImage.Image.Clone(), Image)
                        Me.lblLandscapeSize.Text = String.Format(Master.eLang.GetString(269, "Size: {0}x{1}"), Me.pbLandscape.Image.Width, Me.pbLandscape.Image.Height)
                        Me.lblLandscapeSize.Visible = True
                    End If
                    Cursor = Cursors.Default
                End If
            Else
                MessageBox.Show(Master.eLang.GetString(972, "No Landscapes found"), String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub btnSetLandscapeLocal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetLandscapeLocal.Click
        Try
            With ofdLocalFiles
                .InitialDirectory = Directory.GetParent(Me.tmpDBMovie.Filename).FullName
                .Filter = Master.eLang.GetString(497, "Images") + "|*.jpg;*.png"
                .FilterIndex = 0
            End With

            If ofdLocalFiles.ShowDialog() = DialogResult.OK Then
                Me.tmpDBMovie.ImagesContainer.Landscape.WebImage.FromFile(ofdLocalFiles.FileName)
                Me.pbLandscape.Image = Me.tmpDBMovie.ImagesContainer.Landscape.WebImage.Image
                Me.pbLandscape.Tag = Me.tmpDBMovie.ImagesContainer.Landscape

                Me.lblLandscapeSize.Text = String.Format(Master.eLang.GetString(269, "Size: {0}x{1}"), Me.pbLandscape.Image.Width, Me.pbLandscape.Image.Height)
                Me.lblLandscapeSize.Visible = True
            End If
        Catch ex As Exception
            logger.Error(New StackFrame().GetMethod().Name, ex)
        End Try
    End Sub

    Private Sub btnSetPosterDL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetPosterDL.Click
        Try
            Using dImgManual As New dlgImgManual
                Dim tImage As MediaContainers.Image
                If dImgManual.ShowDialog() = DialogResult.OK Then
                    tImage = dImgManual.Results
                    If tImage.WebImage.Image IsNot Nothing Then
                        Me.tmpDBMovie.ImagesContainer.Poster = tImage
                        Me.pbPoster.Image = Me.tmpDBMovie.ImagesContainer.Poster.WebImage.Image
                        Me.pbPoster.Tag = Me.tmpDBMovie.ImagesContainer.Poster

                        Me.lblPosterSize.Text = String.Format(Master.eLang.GetString(269, "Size: {0}x{1}"), Me.pbPoster.Image.Width, Me.pbPoster.Image.Height)
                        Me.lblPosterSize.Visible = True
                    End If
                End If
            End Using
        Catch ex As Exception
            logger.Error(New StackFrame().GetMethod().Name, ex)
        End Try
    End Sub

    Private Sub btnSetPosterScrape_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetPosterScrape.Click
        Dim aContainer As New MediaContainers.SearchResultsContainer
        Dim ScrapeModifier As New Structures.ScrapeModifier

        Functions.SetScrapeModifier(ScrapeModifier, Enums.ModifierType.MainPoster, True)
        If Not ModulesManager.Instance.ScrapeImage_Movie(Me.tmpDBMovie, aContainer, ScrapeModifier, True) Then
            If aContainer.MainPosters.Count > 0 Then
                Dim dlgImgS = New dlgImgSelectNew()
                If dlgImgS.ShowDialog(Me.tmpDBMovie, aContainer, ScrapeModifier, Enums.ContentType.Movie) = Windows.Forms.DialogResult.OK Then
                    Dim pResults As MediaContainers.Image = dlgImgS.Result.ImagesContainer.Poster
                    Me.tmpDBMovie.ImagesContainer.Poster = pResults
                    If pResults.WebImage.Image IsNot Nothing Then
                        Me.pbPoster.Image = CType(pResults.WebImage.Image.Clone(), Image)
                        Me.lblPosterSize.Text = String.Format(Master.eLang.GetString(269, "Size: {0}x{1}"), Me.pbPoster.Image.Width, Me.pbPoster.Image.Height)
                        Me.lblPosterSize.Visible = True
                    End If
                    Cursor = Cursors.Default
                End If
            Else
                MessageBox.Show(Master.eLang.GetString(972, "No Posters found"), String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub btnSetPosterLocal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetPosterLocal.Click
        Try
            With ofdLocalFiles
                .InitialDirectory = Directory.GetParent(Me.tmpDBMovie.Filename).FullName
                .Filter = Master.eLang.GetString(497, "Images") + "|*.jpg;*.png"
                .FilterIndex = 0
            End With

            If ofdLocalFiles.ShowDialog() = DialogResult.OK Then
                Me.tmpDBMovie.ImagesContainer.Poster.WebImage.FromFile(ofdLocalFiles.FileName)
                Me.pbPoster.Image = Me.tmpDBMovie.ImagesContainer.Poster.WebImage.Image
                Me.pbPoster.Tag = Me.tmpDBMovie.ImagesContainer.Poster

                Me.lblPosterSize.Text = String.Format(Master.eLang.GetString(269, "Size: {0}x{1}"), Me.pbPoster.Image.Width, Me.pbPoster.Image.Height)
                Me.lblPosterSize.Visible = True
            End If
        Catch ex As Exception
            logger.Error(New StackFrame().GetMethod().Name, ex)
        End Try
    End Sub

    'Private Sub btnSetMovieThemeDL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetMovieThemeDL.Click
    '    Dim tResults As New MediaContainers.Theme
    '    Dim dlgTheS As dlgThemeSelect
    '    Dim tList As New List(Of Themes)

    '    Try
    '        Me.ThemeStop()
    '        dlgTheS = New dlgThemeSelect()
    '        If dlgTheS.ShowDialog(Me.tmpDBMovie, tList) = Windows.Forms.DialogResult.OK Then
    '            tResults = dlgTheS.Results
    '            MovieTheme = dlgTheS.WebTheme
    '            ThemeAddToPlayer(MovieTheme)
    '        End If
    '    Catch ex As Exception
    '        logger.Error(New StackFrame().GetMethod().Name, ex)
    '    End Try
    'End Sub

    Private Sub btnSetThemeScrape_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetThemeScrape.Click
        Dim dlgThmS As dlgThemeSelect
        Dim aUrlList As New List(Of Themes)

        Try
            Me.ThemeStop()
            If Not ModulesManager.Instance.ScrapeTheme_Movie(Me.tmpDBMovie, aUrlList) Then
                If aUrlList.Count > 0 Then
                    dlgThmS = New dlgThemeSelect()
                    If dlgThmS.ShowDialog(Me.tmpDBMovie, aUrlList) = Windows.Forms.DialogResult.OK Then
                        MovieTheme = dlgThmS.Results.WebTheme
                        MovieTheme.isEdit = True
                        ThemeAddToPlayer(MovieTheme)
                    End If
                Else
                    MessageBox.Show(Master.eLang.GetString(1163, "No Themes found"), String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If

        Catch ex As Exception
            logger.Error(New StackFrame().GetMethod().Name, ex)
        End Try
    End Sub

    Private Sub btnSetThemeLocal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetThemeLocal.Click
        Try
            Me.ThemeStop()
            With ofdLocalFiles
                .InitialDirectory = Directory.GetParent(Me.tmpDBMovie.Filename).FullName
                .Filter = Master.eLang.GetString(1285, "Themes") + "|*.mp3;*.wav"
                .FilterIndex = 0
            End With

            If ofdLocalFiles.ShowDialog() = DialogResult.OK Then
                MovieTheme.FromFile(ofdLocalFiles.FileName)
                MovieTheme.isEdit = True
                ThemeAddToPlayer(MovieTheme)
            End If
        Catch ex As Exception
            logger.Error(New StackFrame().GetMethod().Name, ex)
        End Try
    End Sub

    Private Sub btnSetTrailerDL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetTrailerDL.Click
        Dim tResults As New MediaContainers.Trailer
        Dim dlgTrlS As dlgTrailerSelect
        Dim tList As New List(Of MediaContainers.Trailer)

        Try
            Me.TrailerStop()
            dlgTrlS = New dlgTrailerSelect()
            If dlgTrlS.ShowDialog(Me.tmpDBMovie, tList, False, True, True) = Windows.Forms.DialogResult.OK Then
                tResults = dlgTrlS.Results
                MovieTrailer = tResults
                TrailerPlaylistAdd(MovieTrailer)
            End If
        Catch ex As Exception
            logger.Error(New StackFrame().GetMethod().Name, ex)
        End Try
    End Sub

    Private Sub btnSetTrailerScrape_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetTrailerScrape.Click
        Dim dlgTrlS As dlgTrailerSelect
        Dim tList As New List(Of MediaContainers.Trailer)

        Try
            Me.TrailerStop()
            dlgTrlS = New dlgTrailerSelect()
            If dlgTrlS.ShowDialog(Me.tmpDBMovie, tList, False, True, True) = Windows.Forms.DialogResult.OK Then
                MovieTrailer = dlgTrlS.Results
                TrailerPlaylistAdd(MovieTrailer)
            End If
        Catch ex As Exception
            logger.Error(New StackFrame().GetMethod().Name, ex)
        End Try
    End Sub

    Private Sub btnSetTrailerLocal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetTrailerLocal.Click
        Try
            Me.TrailerStop()
            With ofdLocalFiles
                .InitialDirectory = Directory.GetParent(Me.tmpDBMovie.Filename).FullName
                .Filter = Master.eLang.GetString(1195, "Trailers") + "|*.mp4;*.avi"
                .FilterIndex = 0
            End With

            If ofdLocalFiles.ShowDialog() = DialogResult.OK Then
                MovieTrailer.WebTrailer.FromFile(ofdLocalFiles.FileName)
                MovieTrailer.WebTrailer.isEdit = True
                TrailerPlaylistAdd(MovieTrailer)
            End If
        Catch ex As Exception
            logger.Error(New StackFrame().GetMethod().Name, ex)
        End Try
    End Sub

    Private Sub btnStudio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStudio.Click
        Using dStudio As New dlgStudioSelect
            Dim tStudio As String = dStudio.ShowDialog(Me.tmpDBMovie)
            If Not String.IsNullOrEmpty(tStudio) Then
                Me.txtStudio.Text = tStudio
            End If
        End Using
    End Sub

    Private Sub btnEThumbsRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEThumbsRefresh.Click
        Me.RefreshEThumbs()
    End Sub

    Private Sub btnEFanartsRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEFanartsRefresh.Click
        Me.RefreshEFanarts()
    End Sub

    Private Sub ThemeStart()
        'If Me.axVLCTheme.playlist.isPlaying Then
        '    Me.axVLCTheme.playlist.togglePause()
        '    Me.btnThemePlay.Text = "Play"
        'Else
        '    Me.axVLCTheme.playlist.play()
        '    Me.btnThemePlay.Text = "Pause"
        'End If
    End Sub

    Private Sub ThemeStop()
        'Me.axVLCTheme.playlist.stop()
        'Me.btnThemePlay.Text = "Play"
    End Sub

    Private Sub ThemeAddToPlayer(ByVal Theme As Themes)
        'Dim Link As String = String.Empty
        'Me.axVLCTheme.playlist.stop()
        'Me.axVLCTheme.playlist.items.clear()
    End Sub

    Private Sub TrailerPlaylistAdd(ByVal Trailer As MediaContainers.Trailer)
        If AnyTrailerPlayerEnabled Then
            Dim paramsTrailerPreview As New List(Of Object)(New String() {Trailer.VideoURL})
            ModulesManager.Instance.RunGeneric(Enums.ModuleEventType.MediaPlayerPlaylistAdd_Video, paramsTrailerPreview, Nothing, True)
        End If
    End Sub

    Private Sub TrailerPlaylistClear()
        If AnyTrailerPlayerEnabled Then
            Dim paramsTrailerPreview As New List(Of Object)
            ModulesManager.Instance.RunGeneric(Enums.ModuleEventType.MediaPlayerPlaylistClear_Video, Nothing, Nothing, True)
        End If
    End Sub

    Private Sub TrailerStop()
        If AnyTrailerPlayerEnabled Then
            Dim paramsTrailerPreview As New List(Of Object)
            ModulesManager.Instance.RunGeneric(Enums.ModuleEventType.MediaPlayerStop_Video, Nothing, Nothing, True)
        End If
    End Sub

    ' temporarily disabled
    'Private Sub btnEThumbsUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEThumbsUp.Click
    '    Try
    '        If lvEThumbs.Items.Count > 0 AndAlso lvEThumbs.SelectedIndices(0) > 0 Then
    '            Dim iIndex As Integer = lvEThumbs.SelectedIndices(0)
    '            lvEThumbs.Items(iIndex).Text = String.Concat("  ", CStr(Convert.ToInt32(lvEThumbs.Items(iIndex).Text.Trim) - 1))
    '            lvEThumbs.Items(iIndex - 1).Text = String.Concat("  ", CStr(Convert.ToInt32(lvEThumbs.Items(iIndex - 1).Text.Trim) + 1))
    '            lvEThumbs.Sort()
    '        End If
    '    Catch ex As Exception
    '        logger.Error(New StackFrame().GetMethod().Name, ex)
    '    End Try
    'End Sub

    ' temporarily disabled
    'Private Sub btnEFanartsUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Try
    '        If lvEFanarts.Items.Count > 0 AndAlso lvEFanarts.SelectedIndices(0) > 0 Then
    '            Dim iIndex As Integer = lvEFanarts.SelectedIndices(0)
    '            lvEFanarts.Items(iIndex).Text = String.Concat("  ", CStr(Convert.ToInt32(lvEFanarts.Items(iIndex).Text.Trim) - 1))
    '            lvEFanarts.Items(iIndex - 1).Text = String.Concat("  ", CStr(Convert.ToInt32(lvEFanarts.Items(iIndex - 1).Text.Trim) + 1))
    '            lvEFanarts.Sort()
    '        End If
    '    Catch ex As Exception
    '        logger.Error(New StackFrame().GetMethod().Name, ex)
    '    End Try
    'End Sub

    Private Sub BuildStars(ByVal sinRating As Single)

        Try
            'f'in MS and them leaving control arrays out of VB.NET
            With Me
                .pbStar1.Image = Nothing
                .pbStar2.Image = Nothing
                .pbStar3.Image = Nothing
                .pbStar4.Image = Nothing
                .pbStar5.Image = Nothing
                .pbStar6.Image = Nothing
                .pbStar7.Image = Nothing
                .pbStar8.Image = Nothing
                .pbStar9.Image = Nothing
                .pbStar10.Image = Nothing

                If sinRating >= 0.5 Then ' if rating is less than .5 out of ten, consider it a 0
                    Select Case (sinRating)
                        Case Is <= 0.5
                            .pbStar1.Image = My.Resources.starhalf
                            .pbStar2.Image = My.Resources.starempty
                            .pbStar3.Image = My.Resources.starempty
                            .pbStar4.Image = My.Resources.starempty
                            .pbStar5.Image = My.Resources.starempty
                            .pbStar6.Image = My.Resources.starempty
                            .pbStar7.Image = My.Resources.starempty
                            .pbStar8.Image = My.Resources.starempty
                            .pbStar9.Image = My.Resources.starempty
                            .pbStar10.Image = My.Resources.starempty
                        Case Is <= 1
                            .pbStar1.Image = My.Resources.star
                            .pbStar2.Image = My.Resources.starempty
                            .pbStar3.Image = My.Resources.starempty
                            .pbStar4.Image = My.Resources.starempty
                            .pbStar5.Image = My.Resources.starempty
                            .pbStar6.Image = My.Resources.starempty
                            .pbStar7.Image = My.Resources.starempty
                            .pbStar8.Image = My.Resources.starempty
                            .pbStar9.Image = My.Resources.starempty
                            .pbStar10.Image = My.Resources.starempty
                        Case Is <= 1.5
                            .pbStar1.Image = My.Resources.star
                            .pbStar2.Image = My.Resources.starhalf
                            .pbStar3.Image = My.Resources.starempty
                            .pbStar4.Image = My.Resources.starempty
                            .pbStar5.Image = My.Resources.starempty
                            .pbStar6.Image = My.Resources.starempty
                            .pbStar7.Image = My.Resources.starempty
                            .pbStar8.Image = My.Resources.starempty
                            .pbStar9.Image = My.Resources.starempty
                            .pbStar10.Image = My.Resources.starempty
                        Case Is <= 2
                            .pbStar1.Image = My.Resources.star
                            .pbStar2.Image = My.Resources.star
                            .pbStar3.Image = My.Resources.starempty
                            .pbStar4.Image = My.Resources.starempty
                            .pbStar5.Image = My.Resources.starempty
                            .pbStar6.Image = My.Resources.starempty
                            .pbStar7.Image = My.Resources.starempty
                            .pbStar8.Image = My.Resources.starempty
                            .pbStar9.Image = My.Resources.starempty
                            .pbStar10.Image = My.Resources.starempty
                        Case Is <= 2.5
                            .pbStar1.Image = My.Resources.star
                            .pbStar2.Image = My.Resources.star
                            .pbStar3.Image = My.Resources.starhalf
                            .pbStar4.Image = My.Resources.starempty
                            .pbStar5.Image = My.Resources.starempty
                            .pbStar6.Image = My.Resources.starempty
                            .pbStar7.Image = My.Resources.starempty
                            .pbStar8.Image = My.Resources.starempty
                            .pbStar9.Image = My.Resources.starempty
                            .pbStar10.Image = My.Resources.starempty
                        Case Is <= 3
                            .pbStar1.Image = My.Resources.star
                            .pbStar2.Image = My.Resources.star
                            .pbStar3.Image = My.Resources.star
                            .pbStar4.Image = My.Resources.starempty
                            .pbStar5.Image = My.Resources.starempty
                            .pbStar6.Image = My.Resources.starempty
                            .pbStar7.Image = My.Resources.starempty
                            .pbStar8.Image = My.Resources.starempty
                            .pbStar9.Image = My.Resources.starempty
                            .pbStar10.Image = My.Resources.starempty
                        Case Is <= 3.5
                            .pbStar1.Image = My.Resources.star
                            .pbStar2.Image = My.Resources.star
                            .pbStar3.Image = My.Resources.star
                            .pbStar4.Image = My.Resources.starhalf
                            .pbStar5.Image = My.Resources.starempty
                            .pbStar6.Image = My.Resources.starempty
                            .pbStar7.Image = My.Resources.starempty
                            .pbStar8.Image = My.Resources.starempty
                            .pbStar9.Image = My.Resources.starempty
                            .pbStar10.Image = My.Resources.starempty
                        Case Is <= 4
                            .pbStar1.Image = My.Resources.star
                            .pbStar2.Image = My.Resources.star
                            .pbStar3.Image = My.Resources.star
                            .pbStar4.Image = My.Resources.star
                            .pbStar5.Image = My.Resources.starempty
                            .pbStar6.Image = My.Resources.starempty
                            .pbStar7.Image = My.Resources.starempty
                            .pbStar8.Image = My.Resources.starempty
                            .pbStar9.Image = My.Resources.starempty
                            .pbStar10.Image = My.Resources.starempty
                        Case Is <= 4.5
                            .pbStar1.Image = My.Resources.star
                            .pbStar2.Image = My.Resources.star
                            .pbStar3.Image = My.Resources.star
                            .pbStar4.Image = My.Resources.star
                            .pbStar5.Image = My.Resources.starhalf
                            .pbStar6.Image = My.Resources.starempty
                            .pbStar7.Image = My.Resources.starempty
                            .pbStar8.Image = My.Resources.starempty
                            .pbStar9.Image = My.Resources.starempty
                            .pbStar10.Image = My.Resources.starempty
                        Case Is <= 5
                            .pbStar1.Image = My.Resources.star
                            .pbStar2.Image = My.Resources.star
                            .pbStar3.Image = My.Resources.star
                            .pbStar4.Image = My.Resources.star
                            .pbStar5.Image = My.Resources.star
                            .pbStar6.Image = My.Resources.starempty
                            .pbStar7.Image = My.Resources.starempty
                            .pbStar8.Image = My.Resources.starempty
                            .pbStar9.Image = My.Resources.starempty
                            .pbStar10.Image = My.Resources.starempty
                        Case Is <= 5.5
                            .pbStar1.Image = My.Resources.star
                            .pbStar2.Image = My.Resources.star
                            .pbStar3.Image = My.Resources.star
                            .pbStar4.Image = My.Resources.star
                            .pbStar5.Image = My.Resources.star
                            .pbStar6.Image = My.Resources.starhalf
                            .pbStar7.Image = My.Resources.starempty
                            .pbStar8.Image = My.Resources.starempty
                            .pbStar9.Image = My.Resources.starempty
                            .pbStar10.Image = My.Resources.starempty
                        Case Is <= 6
                            .pbStar1.Image = My.Resources.star
                            .pbStar2.Image = My.Resources.star
                            .pbStar3.Image = My.Resources.star
                            .pbStar4.Image = My.Resources.star
                            .pbStar5.Image = My.Resources.star
                            .pbStar6.Image = My.Resources.star
                            .pbStar7.Image = My.Resources.starempty
                            .pbStar8.Image = My.Resources.starempty
                            .pbStar9.Image = My.Resources.starempty
                            .pbStar10.Image = My.Resources.starempty
                        Case Is <= 6.5
                            .pbStar1.Image = My.Resources.star
                            .pbStar2.Image = My.Resources.star
                            .pbStar3.Image = My.Resources.star
                            .pbStar4.Image = My.Resources.star
                            .pbStar5.Image = My.Resources.star
                            .pbStar6.Image = My.Resources.star
                            .pbStar7.Image = My.Resources.starhalf
                            .pbStar8.Image = My.Resources.starempty
                            .pbStar9.Image = My.Resources.starempty
                            .pbStar10.Image = My.Resources.starempty
                        Case Is <= 7
                            .pbStar1.Image = My.Resources.star
                            .pbStar2.Image = My.Resources.star
                            .pbStar3.Image = My.Resources.star
                            .pbStar4.Image = My.Resources.star
                            .pbStar5.Image = My.Resources.star
                            .pbStar6.Image = My.Resources.star
                            .pbStar7.Image = My.Resources.star
                            .pbStar8.Image = My.Resources.starempty
                            .pbStar9.Image = My.Resources.starempty
                            .pbStar10.Image = My.Resources.starempty
                        Case Is <= 7.5
                            .pbStar1.Image = My.Resources.star
                            .pbStar2.Image = My.Resources.star
                            .pbStar3.Image = My.Resources.star
                            .pbStar4.Image = My.Resources.star
                            .pbStar5.Image = My.Resources.star
                            .pbStar6.Image = My.Resources.star
                            .pbStar7.Image = My.Resources.star
                            .pbStar8.Image = My.Resources.starhalf
                            .pbStar9.Image = My.Resources.starempty
                            .pbStar10.Image = My.Resources.starempty
                        Case Is <= 8
                            .pbStar1.Image = My.Resources.star
                            .pbStar2.Image = My.Resources.star
                            .pbStar3.Image = My.Resources.star
                            .pbStar4.Image = My.Resources.star
                            .pbStar5.Image = My.Resources.star
                            .pbStar6.Image = My.Resources.star
                            .pbStar7.Image = My.Resources.star
                            .pbStar8.Image = My.Resources.star
                            .pbStar9.Image = My.Resources.starempty
                            .pbStar10.Image = My.Resources.starempty
                        Case Is <= 8.5
                            .pbStar1.Image = My.Resources.star
                            .pbStar2.Image = My.Resources.star
                            .pbStar3.Image = My.Resources.star
                            .pbStar4.Image = My.Resources.star
                            .pbStar5.Image = My.Resources.star
                            .pbStar6.Image = My.Resources.star
                            .pbStar7.Image = My.Resources.star
                            .pbStar8.Image = My.Resources.star
                            .pbStar9.Image = My.Resources.starhalf
                            .pbStar10.Image = My.Resources.starempty
                        Case Is <= 9
                            .pbStar1.Image = My.Resources.star
                            .pbStar2.Image = My.Resources.star
                            .pbStar3.Image = My.Resources.star
                            .pbStar4.Image = My.Resources.star
                            .pbStar5.Image = My.Resources.star
                            .pbStar6.Image = My.Resources.star
                            .pbStar7.Image = My.Resources.star
                            .pbStar8.Image = My.Resources.star
                            .pbStar9.Image = My.Resources.star
                            .pbStar10.Image = My.Resources.starempty
                        Case Is <= 9.5
                            .pbStar1.Image = My.Resources.star
                            .pbStar2.Image = My.Resources.star
                            .pbStar3.Image = My.Resources.star
                            .pbStar4.Image = My.Resources.star
                            .pbStar5.Image = My.Resources.star
                            .pbStar6.Image = My.Resources.star
                            .pbStar7.Image = My.Resources.star
                            .pbStar8.Image = My.Resources.star
                            .pbStar9.Image = My.Resources.star
                            .pbStar10.Image = My.Resources.starhalf
                        Case Else
                            .pbStar1.Image = My.Resources.star
                            .pbStar2.Image = My.Resources.star
                            .pbStar3.Image = My.Resources.star
                            .pbStar4.Image = My.Resources.star
                            .pbStar5.Image = My.Resources.star
                            .pbStar6.Image = My.Resources.star
                            .pbStar7.Image = My.Resources.star
                            .pbStar8.Image = My.Resources.star
                            .pbStar9.Image = My.Resources.star
                            .pbStar10.Image = My.Resources.star
                    End Select
                End If
            End With
        Catch ex As Exception
            logger.Error(New StackFrame().GetMethod().Name, ex)
        End Try
    End Sub

    Private Sub bwEThumbs_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bwEThumbs.DoWork
        Dim ET_lFI As New List(Of String)
        Dim ET_i As Integer = 0
        Dim ET_max As Integer = 30 'limited the number of images to avoid a memory error

        Try
            ' load local Extrathumbs
            'If Not Me.tmpDBMovie.RemoveEThumbs Then
            For Each a In FileUtils.GetFilenameList.Movie(Me.tmpDBMovie.Filename, Me.tmpDBMovie.IsSingle, Enums.ModifierType.MainEThumbs)
                If Directory.Exists(a) Then
                    ET_lFI.AddRange(Directory.GetFiles(a, "thumb*.jpg"))
                    If ET_lFI.Count > 0 Then Exit For 'load only first folder that has files to prevent duplicate loading
                End If
            Next

            If ET_lFI.Count > 0 Then
                For Each thumb As String In ET_lFI
                    Dim ETImage As New Images
                    If Me.bwEThumbs.CancellationPending Then Return
                    If Not Me.etDeleteList.Contains(thumb) Then
                        ETImage.FromFile(thumb)
                        EThumbsList.Add(New ExtraImages With {.Image = ETImage, .Name = Path.GetFileName(thumb), .Index = ET_i, .Path = thumb})
                        ET_i += 1
                        If ET_i >= ET_max Then Exit For
                    End If
                Next
            End If
            'End If

            ' load scraped Extrathumbs
            'If Not Me.tmpDBMovie.etList Is Nothing Then
            If Not ET_i >= ET_max Then
                'For Each thumb As String In Me.tmpDBMovie.etList
                '    Dim ETImage As New Images
                '    If Not String.IsNullOrEmpty(thumb) Then
                '        ETImage.FromWeb(thumb.Substring(1, thumb.Length - 1))
                '    End If
                '    If ETImage.Image IsNot Nothing Then
                '        EThumbsList.Add(New ExtraImages With {.Image = ETImage, .Name = Path.GetFileName(thumb), .Index = ET_i, .Path = thumb})
                '        ET_i += 1
                '        If ET_i >= ET_max Then Exit For
                '    End If
                'Next
            End If
            'End If

            'load MovieExtractor Extrathumbs
            If EThumbsExtractor.Count > 0 Then
                If Not ET_i >= ET_max Then
                    For Each thumb As String In EThumbsExtractor
                        Dim ETImage As New Images
                        If Me.bwEThumbs.CancellationPending Then Return
                        If Not Me.etDeleteList.Contains(thumb) Then
                            ETImage.FromFile(thumb)
                            EThumbsList.Add(New ExtraImages With {.Image = ETImage, .Name = Path.GetFileName(thumb), .Index = ET_i, .Path = thumb})
                            ET_i += 1
                            If ET_i >= ET_max Then Exit For
                        End If
                    Next
                End If
            End If

            If ET_i >= ET_max AndAlso EThumbsWarning Then
                MessageBox.Show(String.Format(Master.eLang.GetString(1120, "To prevent a memory overflow will not display more than {0} Extrathumbs."), ET_max), Master.eLang.GetString(356, "Warning"), MessageBoxButtons.OK, MessageBoxIcon.Warning)
                EThumbsWarning = False 'show warning only one time
            End If

        Catch ex As Exception
            logger.Error(New StackFrame().GetMethod().Name, ex)
        End Try

        ET_lFI = Nothing
    End Sub

    Private Sub bwEFanarts_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bwEFanarts.DoWork
        Dim EF_lFI As New List(Of String)
        Dim EF_i As Integer = 0
        Dim EF_max As Integer = 30 'limited the number of images to avoid a memory error

        Try
            ' load local Extrafanarts
            ' Not Me.tmpDBMovie.RemoveEFanarts Then
            For Each a In FileUtils.GetFilenameList.Movie(Me.tmpDBMovie.Filename, Me.tmpDBMovie.IsSingle, Enums.ModifierType.MainEFanarts)
                If Directory.Exists(a) Then
                    EF_lFI.AddRange(Directory.GetFiles(a, "*.jpg"))
                    If EF_lFI.Count > 0 Then Exit For 'load only first folder that has files to prevent duplicate loading
                End If
            Next

            If EF_lFI.Count > 0 Then
                For Each fanart As String In EF_lFI
                    Dim EFImage As New Images
                    If Me.bwEFanarts.CancellationPending Then Return
                    If Not Me.efDeleteList.Contains(fanart) Then
                        EFImage.FromFile(fanart)
                        EFanartsList.Add(New ExtraImages With {.Image = EFImage, .Name = Path.GetFileName(fanart), .Index = EF_i, .Path = fanart})
                        EF_i += 1
                        If EF_i >= EF_max Then Exit For
                    End If
                Next
            End If
            'End If

            ' load scraped Extrafanarts
            'If Not Me.tmpDBMovie.efList Is Nothing Then
            If Not EF_i >= EF_max Then
                'For Each fanart As String In Me.tmpDBMovie.efList
                '    Dim EFImage As New Images
                '    If Not String.IsNullOrEmpty(fanart) Then
                '        EFImage.FromWeb(fanart.Substring(1, fanart.Length - 1))
                '    End If
                '    If EFImage.Image IsNot Nothing Then
                '        EFanartsList.Add(New ExtraImages With {.Image = EFImage, .Name = Path.GetFileName(fanart), .Index = EF_i, .Path = fanart})
                '        EF_i += 1
                '        If EF_i >= EF_max Then Exit For
                '    End If
                'Next
            End If
            'End If

            'load MovieExtractor Extrafanarts
            If EFanartsExtractor.Count > 0 Then
                If Not EF_i >= EF_max Then
                    For Each thumb As String In EFanartsExtractor
                        Dim EFImage As New Images
                        If Me.bwEThumbs.CancellationPending Then Return
                        If Not Me.etDeleteList.Contains(thumb) Then
                            EFImage.FromFile(thumb)
                            EFanartsList.Add(New ExtraImages With {.Image = EFImage, .Name = Path.GetFileName(thumb), .Index = EF_i, .Path = thumb})
                            EF_i += 1
                            If EF_i >= EF_max Then Exit For
                        End If
                    Next
                End If
            End If

            If EF_i >= EF_max AndAlso EFanartsWarning Then
                MessageBox.Show(String.Format(Master.eLang.GetString(1119, "To prevent a memory overflow will not display more than {0} Extrafanarts."), EF_max), Master.eLang.GetString(356, "Warning"), MessageBoxButtons.OK, MessageBoxIcon.Warning)
                EFanartsWarning = False 'show warning only one time
            End If

        Catch ex As Exception
            logger.Error(New StackFrame().GetMethod().Name, ex)
        End Try

        EF_lFI = Nothing
    End Sub

    Private Sub bwEThumbs_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bwEThumbs.RunWorkerCompleted
        Try
            If EThumbsList.Count > 0 Then
                For Each tEThumb As ExtraImages In EThumbsList
                    AddETImage(tEThumb.Name, tEThumb.Index, tEThumb)
                Next
            End If
        Catch ex As Exception
            logger.Error(New StackFrame().GetMethod().Name, ex)
        End Try
    End Sub

    Private Sub bwEFanarts_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bwEFanarts.RunWorkerCompleted
        Try
            If EFanartsList.Count > 0 Then
                For Each tEFanart As ExtraImages In EFanartsList
                    AddEFImage(tEFanart.Name, tEFanart.Index, tEFanart)
                Next
            End If
        Catch ex As Exception
            logger.Error(New StackFrame().GetMethod().Name, ex)
        End Try
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.ThemeStop()
        Me.TrailerStop()
        Me.CleanUp()

        Me.tmpDBMovie = Master.DB.LoadMovieFromDB(Me.tmpDBMovie.ID)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub CleanUp()
        Try
            If File.Exists(Path.Combine(Master.TempPath, "poster.jpg")) Then
                File.Delete(Path.Combine(Master.TempPath, "poster.jpg"))
            End If

            If File.Exists(Path.Combine(Master.TempPath, "fanart.jpg")) Then
                File.Delete(Path.Combine(Master.TempPath, "fanart.jpg"))
            End If

            If File.Exists(Path.Combine(Master.TempPath, "frame.jpg")) Then
                File.Delete(Path.Combine(Master.TempPath, "frame.jpg"))
            End If

            If Directory.Exists(Path.Combine(Master.TempPath, "extrathumbs")) Then
                FileUtils.Delete.DeleteDirectory(Path.Combine(Master.TempPath, "extrathumbs"))
            End If

            If Directory.Exists(Path.Combine(Master.TempPath, "extrafanarts")) Then
                FileUtils.Delete.DeleteDirectory(Path.Combine(Master.TempPath, "extrafanarts"))
            End If

            If Directory.Exists(Path.Combine(Master.TempPath, "DashTrailer")) Then
                FileUtils.Delete.DeleteDirectory(Path.Combine(Master.TempPath, "DashTrailer"))
            End If

            If Me.pnlETImage IsNot Nothing Then
                For Each Pan In Me.pnlETImage
                    CType(Pan.Tag, Images).Dispose()
                Next
            End If
            If Me.pbETImage IsNot Nothing Then
                For Each Pan In Me.pbETImage
                    CType(Pan.Tag, Images).Dispose()
                    Pan.Image.Dispose()
                Next
            End If
            If Me.pnlEFImage IsNot Nothing Then
                For Each Pan In Me.pnlEFImage
                    CType(Pan.Tag, Images).Dispose()
                Next
            End If
            If Me.pbEFImage IsNot Nothing Then
                For Each Pan In Me.pbEFImage
                    CType(Pan.Tag, Images).Dispose()
                    Pan.Image.Dispose()
                Next
            End If
        Catch ex As Exception
            logger.Error(New StackFrame().GetMethod().Name, ex)
        End Try
    End Sub

    Private Sub DelayTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrDelay.Tick
        tmrDelay.Stop()
        'GrabTheFrame()
    End Sub

    Private Sub DeleteActors()
        Try
            If Me.lvActors.Items.Count > 0 Then
                While Me.lvActors.SelectedItems.Count > 0
                    Me.lvActors.Items.Remove(Me.lvActors.SelectedItems(0))
                End While
                ActorThumbsHasChanged = True
            End If
        Catch ex As Exception
            logger.Error(New StackFrame().GetMethod().Name, ex)
        End Try
    End Sub

    Private Sub DeleteEThumbs()
        Try
            Dim iIndex As Integer = EThumbsIndex

            If iIndex >= 0 Then
                Dim tPath As String = Me.EThumbsList.Item(iIndex).Path
                If Me.EThumbsList.Item(iIndex).Path.Substring(0, 1) = ":" Then
                    'Me.tmpDBMovie.etList.RemoveAll(Function(Str) Str = tPath)
                    EThumbsList.Remove(EThumbsList.Item(iIndex))
                Else
                    etDeleteList.Add(Me.EThumbsList.Item(iIndex).Path)
                    EThumbsList.Remove(EThumbsList.Item(iIndex))
                End If
                pbEThumbs.Image = Nothing
                btnEThumbsSetAsFanart.Enabled = False
            End If
            RenumberEThumbs()
        Catch ex As Exception
            logger.Error(New StackFrame().GetMethod().Name, ex)
        End Try
    End Sub

    Private Sub DeleteEFanarts()
        Try
            Dim iIndex As Integer = EFanartsIndex

            If iIndex >= 0 Then
                Dim tPath As String = Me.EFanartsList.Item(iIndex).Path
                If Me.EFanartsList.Item(iIndex).Path.Substring(0, 1) = ":" Then
                    'Me.tmpDBMovie.efList.RemoveAll(Function(Str) Str = tPath)
                    EFanartsList.Remove(EFanartsList.Item(iIndex))
                Else
                    efDeleteList.Add(Me.EFanartsList.Item(iIndex).Path)
                    EFanartsList.Remove(EFanartsList.Item(iIndex))
                End If
                pbEFanarts.Image = Nothing
                btnEFanartsSetAsFanart.Enabled = False
            End If
        Catch ex As Exception
            logger.Error(New StackFrame().GetMethod().Name, ex)
        End Try
    End Sub

    Private Sub dlgEditMovie_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        Me.MovieTheme.Dispose()
        Me.MovieTheme = Nothing

        Me.MovieTrailer.WebTrailer.Dispose()
        Me.MovieTrailer = Nothing

        If EFanartsList IsNot Nothing Then
            For Each Image In Me.EFanartsList
                Image.Image.Dispose()
                Image.Image = Nothing
            Next
            EFanartsList = Nothing
        End If

        If EThumbsList IsNot Nothing Then
            For Each Image In Me.EThumbsList
                Image.Image.Dispose()
                Image.Image = Nothing
            Next
            EThumbsList = Nothing
        End If
    End Sub

    Private Sub dlgEditMovie_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Me.bwEThumbs.IsBusy Then Me.bwEThumbs.CancelAsync()
        While Me.bwEThumbs.IsBusy
            Application.DoEvents()
            Threading.Thread.Sleep(50)
        End While

        If Me.bwEFanarts.IsBusy Then Me.bwEFanarts.CancelAsync()
        While Me.bwEFanarts.IsBusy
            Application.DoEvents()
            Threading.Thread.Sleep(50)
        End While
    End Sub

    Private Sub dlgEditMovie_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.pbBanner.AllowDrop = True
            Me.pbClearArt.AllowDrop = True
            Me.pbClearLogo.AllowDrop = True
            Me.pbDiscArt.AllowDrop = True
            Me.pbFanart.AllowDrop = True
            Me.pbLandscape.AllowDrop = True
            Me.pbPoster.AllowDrop = True

            Me.SetUp()
            ModulesManager.Instance.RunGeneric(Enums.ModuleEventType.BeforeEdit_Movie, Nothing, Me.tmpDBMovie)
            Me.lvwActorSorter = New ListViewColumnSorter()
            Me.lvActors.ListViewItemSorter = Me.lvwActorSorter
            'Me.lvwEThumbsSorter = New ListViewColumnSorter() With {.SortByText = True, .Order = SortOrder.Ascending, .NumericSort = True}
            'Me.lvEThumbs.ListViewItemSorter = Me.lvwEThumbsSorter
            'Me.lvwEFanartsSorter = New ListViewColumnSorter() With {.SortByText = True, .Order = SortOrder.Ascending, .NumericSort = True}
            'Me.lvEFanarts.ListViewItemSorter = Me.lvwEFanartsSorter

            Dim iBackground As New Bitmap(Me.pnlTop.Width, Me.pnlTop.Height)
            Using g As Graphics = Graphics.FromImage(iBackground)
                g.FillRectangle(New Drawing2D.LinearGradientBrush(Me.pnlTop.ClientRectangle, Color.SteelBlue, Color.LightSteelBlue, Drawing2D.LinearGradientMode.Horizontal), pnlTop.ClientRectangle)
                Me.pnlTop.BackgroundImage = iBackground
            End Using

            Dim dFileInfoEdit As New dlgFileInfo
            dFileInfoEdit.TopLevel = False
            dFileInfoEdit.FormBorderStyle = FormBorderStyle.None
            dFileInfoEdit.BackColor = Color.White
            dFileInfoEdit.Cancel_Button.Visible = False
            Me.pnlFileInfo.Controls.Add(dFileInfoEdit)
            Dim oldwidth As Integer = dFileInfoEdit.Width
            dFileInfoEdit.Width = pnlFileInfo.Width
            dFileInfoEdit.Height = pnlFileInfo.Height
            dFileInfoEdit.Show(False)

            Me.LoadGenres()
            Me.LoadRatings()

            Dim paramsFrameExtractor As New List(Of Object)(New Object() {New Panel})
            ModulesManager.Instance.RunGeneric(Enums.ModuleEventType.FrameExtrator_Movie, paramsFrameExtractor, Nothing, True)
            pnlFrameExtrator.Controls.Add(DirectCast(paramsFrameExtractor(0), Panel))
            If String.IsNullOrEmpty(pnlFrameExtrator.Controls.Item(0).Name) Then
                tcEdit.TabPages.Remove(tpFrameExtraction)
            End If

            Dim paramsThemePreview As New List(Of Object)(New Object() {New Panel})
            ModulesManager.Instance.RunGeneric(Enums.ModuleEventType.MediaPlayer_Audio, paramsThemePreview, Nothing, True)
            pnlThemePreview.Controls.Add(DirectCast(paramsThemePreview(0), Panel))
            If Not String.IsNullOrEmpty(pnlThemePreview.Controls.Item(1).Name) Then
                AnyThemePlayerEnabled = True
                pnlThemePreviewNoPlayer.Visible = False
            End If

            Dim paramsTrailerPreview As New List(Of Object)(New Object() {New Panel})
            ModulesManager.Instance.RunGeneric(Enums.ModuleEventType.MediaPlayer_Video, paramsTrailerPreview, Nothing, True)
            pnlTrailerPreview.Controls.Add(DirectCast(paramsTrailerPreview(0), Panel))
            If Not String.IsNullOrEmpty(pnlTrailerPreview.Controls.Item(1).Name) Then
                AnyTrailerPlayerEnabled = True
                pnlTrailerPreviewNoPlayer.Visible = False
            End If

            Me.FillInfo()

        Catch ex As Exception
            logger.Error(New StackFrame().GetMethod().Name, ex)
        End Try
    End Sub

    Private Sub dlgEditMovie_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Me.Activate()
    End Sub

    Private Sub EditActor()
        Try
            If Me.lvActors.SelectedItems.Count > 0 Then
                Dim lvwItem As ListViewItem = Me.lvActors.SelectedItems(0)
                Dim eActor As New MediaContainers.Person With {.ID = CInt(lvwItem.Text), .Name = lvwItem.SubItems(1).Text, .Role = lvwItem.SubItems(2).Text, .ThumbURL = lvwItem.SubItems(3).Text}
                Using dAddEditActor As New dlgAddEditActor
                    eActor = dAddEditActor.ShowDialog(False, eActor)
                End Using
                If eActor IsNot Nothing Then
                    lvwItem.Text = eActor.ID.ToString
                    lvwItem.SubItems(1).Text = eActor.Name
                    lvwItem.SubItems(2).Text = eActor.Role
                    lvwItem.SubItems(3).Text = eActor.ThumbURL
                    lvwItem.Selected = True
                    lvwItem.EnsureVisible()
                    ActorThumbsHasChanged = True
                End If
                eActor = Nothing
            End If
        Catch ex As Exception
            logger.Error(New StackFrame().GetMethod().Name, ex)
        End Try
    End Sub

    Private Sub FillInfo(Optional ByVal DoAll As Boolean = True)
        Try
            With Me
                If String.IsNullOrEmpty(Me.tmpDBMovie.NfoPath) Then
                    .btnManual.Enabled = False
                End If

                Me.chkMark.Checked = Me.tmpDBMovie.IsMark
                'cocotus, 2013/02 Playcount/Watched state support added
                'When Edit Movie-Page is loaded, checkbox will be unchecked of playcount=0 or not set at all... 
                If Me.tmpDBMovie.Movie.PlayCount = "" Or Me.tmpDBMovie.Movie.PlayCount = "0" Then
                    Me.chkWatched.Checked = False
                Else
                    'Playcount <> Empty and not 0 -> Tag filled -> Checked!
                    Me.chkWatched.Checked = True
                End If
                'cocotus end

                If Not String.IsNullOrEmpty(Me.tmpDBMovie.Movie.Title) Then
                    .txtTitle.Text = Me.tmpDBMovie.Movie.Title
                End If

                If Not String.IsNullOrEmpty(Me.tmpDBMovie.Movie.OriginalTitle) Then
                    .txtOriginalTitle.Text = Me.tmpDBMovie.Movie.OriginalTitle
                End If

                If Not String.IsNullOrEmpty(Me.tmpDBMovie.Movie.SortTitle) Then
                    .txtSortTitle.Text = Me.tmpDBMovie.Movie.SortTitle
                End If

                If Not String.IsNullOrEmpty(Me.tmpDBMovie.Movie.Tagline) Then
                    .txtTagline.Text = Me.tmpDBMovie.Movie.Tagline
                End If

                If Not String.IsNullOrEmpty(Me.tmpDBMovie.Movie.Year) Then
                    .mtxtYear.Text = Me.tmpDBMovie.Movie.Year
                End If

                If Not String.IsNullOrEmpty(Me.tmpDBMovie.Movie.Votes) Then
                    .txtVotes.Text = Me.tmpDBMovie.Movie.Votes
                End If

                If Not String.IsNullOrEmpty(Me.tmpDBMovie.Movie.Outline) Then
                    .txtOutline.Text = Me.tmpDBMovie.Movie.Outline
                End If

                If Not String.IsNullOrEmpty(Me.tmpDBMovie.Movie.Plot) Then
                    .txtPlot.Text = Me.tmpDBMovie.Movie.Plot
                End If

                If Not String.IsNullOrEmpty(Me.tmpDBMovie.Movie.Top250) Then
                    .txtTop250.Text = Me.tmpDBMovie.Movie.Top250
                End If

                If Me.tmpDBMovie.Movie.Countries.Count > 0 Then
                    .txtCountry.Text = Me.tmpDBMovie.Movie.Country
                End If

                If Not String.IsNullOrEmpty(Me.tmpDBMovie.Movie.Runtime) Then
                    .txtRuntime.Text = Me.tmpDBMovie.Movie.Runtime
                End If

                If Not String.IsNullOrEmpty(Me.tmpDBMovie.Movie.ReleaseDate) Then
                    .txtReleaseDate.Text = Me.tmpDBMovie.Movie.ReleaseDate
                End If

                If Me.tmpDBMovie.Movie.Directors.Count > 0 Then
                    .txtDirector.Text = Me.tmpDBMovie.Movie.Director
                End If

                If Me.tmpDBMovie.Movie.Credits.Count > 0 Then
                    .txtCredits.Text = Me.tmpDBMovie.Movie.OldCredits
                End If

                If Not String.IsNullOrEmpty(Me.tmpDBMovie.VideoSource) Then
                    .txtVideoSource.Text = Me.tmpDBMovie.VideoSource
                ElseIf Not String.IsNullOrEmpty(Me.tmpDBMovie.Movie.VideoSource) Then
                    .txtVideoSource.Text = Me.tmpDBMovie.Movie.VideoSource
                End If

                If Me.tmpDBMovie.Movie.Certifications.Count > 0 Then
                    .txtCerts.Text = Me.tmpDBMovie.Movie.Certification
                End If

                If Not String.IsNullOrEmpty(Me.tmpDBMovie.Movie.LastPlayed) Then
                    Dim timecode As Double = 0
                    Double.TryParse(Me.tmpDBMovie.Movie.LastPlayed, timecode)
                    If timecode > 0 Then
                        .txtLastPlayed.Text = Functions.ConvertFromUnixTimestamp(timecode).ToString("yyyy-MM-dd HH:mm:ss")
                    Else
                        .txtLastPlayed.Text = Me.tmpDBMovie.Movie.LastPlayed
                    End If
                End If

                Me.SelectMPAA()

                If String.IsNullOrEmpty(Me.tmpDBMovie.ThemePath) Then
                    '.btnPlayTheme.Enabled = False
                End If

                '.btnDLTheme.Enabled = Master.eSettings.MovieThemeEnable AndAlso Master.eSettings.MovieThemeAnyEnabled AndAlso ModulesManager.Instance.QueryTrailerScraperCapabilities(Enums.ScraperCapabilities.Theme)

                If Not String.IsNullOrEmpty(Me.tmpDBMovie.Movie.Trailer) Then
                    .txtTrailer.Text = Me.tmpDBMovie.Movie.Trailer
                    .btnPlayTrailer.Enabled = True
                Else
                    .btnPlayTrailer.Enabled = False
                End If

                .btnDLTrailer.Enabled = Master.DefaultOptions_Movie.bTrailer

                If Me.tmpDBMovie.Movie.Studios.Count > 0 Then
                    .txtStudio.Text = Me.tmpDBMovie.Movie.Studio
                End If

                For i As Integer = 0 To .clbGenre.Items.Count - 1
                    .clbGenre.SetItemChecked(i, False)
                Next
                If Me.tmpDBMovie.Movie.Genres.Count > 0 Then
                    For g As Integer = 0 To Me.tmpDBMovie.Movie.Genres.Count - 1
                        If .clbGenre.FindString(Me.tmpDBMovie.Movie.Genres(g).Trim) > 0 Then
                            .clbGenre.SetItemChecked(.clbGenre.FindString(Me.tmpDBMovie.Movie.Genres(g).Trim), True)
                        End If
                    Next

                    If .clbGenre.CheckedItems.Count = 0 Then
                        .clbGenre.SetItemChecked(0, True)
                    End If
                Else
                    .clbGenre.SetItemChecked(0, True)
                End If

                Dim lvItem As ListViewItem
                .lvActors.Items.Clear()
                For Each imdbAct As MediaContainers.Person In Me.tmpDBMovie.Movie.Actors
                    lvItem = .lvActors.Items.Add(imdbAct.ID.ToString)
                    lvItem.SubItems.Add(imdbAct.Name)
                    lvItem.SubItems.Add(imdbAct.Role)
                    lvItem.SubItems.Add(imdbAct.ThumbURL)
                Next

                If Not Me.tmpDBMovie.Filename = String.Empty AndAlso Me.tmpDBMovie.Movie.VideoSource = "" Then
                    Dim vSource As String = APIXML.GetVideoSource(Me.tmpDBMovie.Filename, False)
                    If Not String.IsNullOrEmpty(vSource) Then
                        Me.tmpDBMovie.VideoSource = vSource
                        Me.tmpDBMovie.Movie.VideoSource = Me.tmpDBMovie.VideoSource
                    ElseIf String.IsNullOrEmpty(Me.tmpDBMovie.VideoSource) AndAlso clsAdvancedSettings.GetBooleanSetting("MediaSourcesByExtension", False, "*EmberAPP") Then
                        Me.tmpDBMovie.VideoSource = clsAdvancedSettings.GetSetting(String.Concat("MediaSourcesByExtension:", Path.GetExtension(Me.tmpDBMovie.Filename)), String.Empty, "*EmberAPP")
                        Me.tmpDBMovie.Movie.VideoSource = Me.tmpDBMovie.VideoSource
                    ElseIf Not String.IsNullOrEmpty(Me.tmpDBMovie.Movie.VideoSource) Then
                        Me.tmpDBMovie.VideoSource = Me.tmpDBMovie.Movie.VideoSource
                    End If
                End If

                Dim tRating As Single = NumUtils.ConvertToSingle(Me.tmpDBMovie.Movie.Rating)
                .tmpRating = tRating.ToString
                .pbStar1.Tag = tRating
                .pbStar2.Tag = tRating
                .pbStar3.Tag = tRating
                .pbStar4.Tag = tRating
                .pbStar5.Tag = tRating
                .pbStar6.Tag = tRating
                .pbStar7.Tag = tRating
                .pbStar8.Tag = tRating
                .pbStar9.Tag = tRating
                .pbStar10.Tag = tRating
                If tRating > 0 Then .BuildStars(tRating)

                If DoAll Then
                    Dim pExt As String = Path.GetExtension(Me.tmpDBMovie.Filename).ToLower
                    If pExt = ".rar" OrElse pExt = ".iso" OrElse pExt = ".img" OrElse _
                    pExt = ".bin" OrElse pExt = ".cue" OrElse pExt = ".dat" OrElse _
                    pExt = ".disc" Then
                        tcEdit.TabPages.Remove(tpFrameExtraction)
                    Else
                        If Not pExt = ".disc" Then
                            tcEdit.TabPages.Remove(tpMediaStub)
                        End If
                    End If
                    .bwEThumbs.WorkerSupportsCancellation = True
                    .bwEThumbs.RunWorkerAsync()
                    .bwEFanarts.WorkerSupportsCancellation = True
                    .bwEFanarts.RunWorkerAsync()

                    'Images and TabPages

                    If Master.eSettings.MovieBannerAnyEnabled Then
                        If Not ModulesManager.Instance.QueryScraperCapabilities_Image_Movie(Enums.ModifierType.MainBanner) Then
                            .btnSetBannerScrape.Enabled = False
                        End If
                        If Me.tmpDBMovie.ImagesContainer.Banner.WebImage.Image IsNot Nothing Then
                            .pbBanner.Image = Me.tmpDBMovie.ImagesContainer.Banner.WebImage.Image
                            .pbBanner.Tag = Me.tmpDBMovie.ImagesContainer.Banner

                            .lblBannerSize.Text = String.Format(Master.eLang.GetString(269, "Size: {0}x{1}"), .pbBanner.Image.Width, .pbBanner.Image.Height)
                            .lblBannerSize.Visible = True
                        End If
                    Else
                        tcEdit.TabPages.Remove(tpBanner)
                    End If

                    If Master.eSettings.MovieClearArtAnyEnabled Then
                        If Not ModulesManager.Instance.QueryScraperCapabilities_Image_Movie(Enums.ModifierType.MainClearArt) Then
                            .btnSetClearArtScrape.Enabled = False
                        End If
                        If Me.tmpDBMovie.ImagesContainer.ClearArt.WebImage.Image IsNot Nothing Then
                            .pbClearArt.Image = Me.tmpDBMovie.ImagesContainer.ClearArt.WebImage.Image
                            .pbClearArt.Tag = Me.tmpDBMovie.ImagesContainer.ClearArt

                            .lblClearArtSize.Text = String.Format(Master.eLang.GetString(269, "Size: {0}x{1}"), .pbClearArt.Image.Width, .pbClearArt.Image.Height)
                            .lblClearArtSize.Visible = True
                        End If
                    Else
                        tcEdit.TabPages.Remove(tpClearArt)
                    End If

                    If Master.eSettings.MovieClearLogoAnyEnabled Then
                        If Not ModulesManager.Instance.QueryScraperCapabilities_Image_Movie(Enums.ModifierType.MainClearLogo) Then
                            .btnSetClearLogoScrape.Enabled = False
                        End If
                        If Me.tmpDBMovie.ImagesContainer.ClearLogo.WebImage.Image IsNot Nothing Then
                            .pbClearLogo.Image = Me.tmpDBMovie.ImagesContainer.ClearLogo.WebImage.Image
                            .pbClearLogo.Tag = Me.tmpDBMovie.ImagesContainer.ClearLogo

                            .lblClearLogoSize.Text = String.Format(Master.eLang.GetString(269, "Size: {0}x{1}"), .pbClearLogo.Image.Width, .pbClearLogo.Image.Height)
                            .lblClearLogoSize.Visible = True
                        End If
                    Else
                        tcEdit.TabPages.Remove(tpClearLogo)
                    End If

                    If Master.eSettings.MovieDiscArtAnyEnabled Then
                        If Not ModulesManager.Instance.QueryScraperCapabilities_Image_Movie(Enums.ModifierType.MainDiscArt) Then
                            .btnSetDiscArtScrape.Enabled = False
                        End If
                        If Me.tmpDBMovie.ImagesContainer.DiscArt.WebImage.Image IsNot Nothing Then
                            .pbDiscArt.Image = Me.tmpDBMovie.ImagesContainer.DiscArt.WebImage.Image
                            .pbDiscArt.Tag = Me.tmpDBMovie.ImagesContainer.DiscArt

                            .lblDiscArtSize.Text = String.Format(Master.eLang.GetString(269, "Size: {0}x{1}"), .pbDiscArt.Image.Width, .pbDiscArt.Image.Height)
                            .lblDiscArtSize.Visible = True
                        End If
                    Else
                        tcEdit.TabPages.Remove(tpDiscArt)
                    End If

                    If Master.eSettings.MovieFanartAnyEnabled Then
                        If Not ModulesManager.Instance.QueryScraperCapabilities_Image_Movie(Enums.ModifierType.MainFanart) Then
                            .btnSetFanartScrape.Enabled = False
                        End If
                        If Me.tmpDBMovie.ImagesContainer.Fanart.WebImage.Image IsNot Nothing Then
                            .pbFanart.Image = Me.tmpDBMovie.ImagesContainer.Fanart.WebImage.Image
                            .pbFanart.Tag = Me.tmpDBMovie.ImagesContainer.Fanart

                            .lblFanartSize.Text = String.Format(Master.eLang.GetString(269, "Size: {0}x{1}"), .pbFanart.Image.Width, .pbFanart.Image.Height)
                            .lblFanartSize.Visible = True
                        End If
                    Else
                        tcEdit.TabPages.Remove(tpFanart)
                    End If

                    If Master.eSettings.MovieLandscapeAnyEnabled Then
                        If Not ModulesManager.Instance.QueryScraperCapabilities_Image_Movie(Enums.ModifierType.MainLandscape) Then
                            .btnSetLandscapeScrape.Enabled = False
                        End If
                        If Me.tmpDBMovie.ImagesContainer.Landscape.WebImage.Image IsNot Nothing Then
                            .pbLandscape.Image = Me.tmpDBMovie.ImagesContainer.Landscape.WebImage.Image
                            .pbLandscape.Tag = Me.tmpDBMovie.ImagesContainer.Landscape

                            .lblLandscapeSize.Text = String.Format(Master.eLang.GetString(269, "Size: {0}x{1}"), .pbLandscape.Image.Width, .pbLandscape.Image.Height)
                            .lblLandscapeSize.Visible = True
                        End If
                    Else
                        tcEdit.TabPages.Remove(tpLandscape)
                    End If

                    If Master.eSettings.MoviePosterAnyEnabled Then
                        If Not ModulesManager.Instance.QueryScraperCapabilities_Image_Movie(Enums.ModifierType.MainPoster) Then
                            .btnSetPosterScrape.Enabled = False
                        End If
                        If Me.tmpDBMovie.ImagesContainer.Poster.WebImage.Image IsNot Nothing Then
                            .pbPoster.Image = Me.tmpDBMovie.ImagesContainer.Poster.WebImage.Image
                            .pbPoster.Tag = Me.tmpDBMovie.ImagesContainer.Poster

                            .lblPosterSize.Text = String.Format(Master.eLang.GetString(269, "Size: {0}x{1}"), .pbPoster.Image.Width, .pbPoster.Image.Height)
                            .lblPosterSize.Visible = True
                        End If
                    Else
                        tcEdit.TabPages.Remove(tpPoster)
                    End If




                    If Master.eSettings.MovieEFanartsAnyEnabled Then 'TODO: add buttons for extrafanarts
                        'If Not ModulesManager.Instance.QueryScraperCapabilities_Image_Movie(Enums.ScraperCapabilities.Fanart) Then
                        '    .btnSetMovieEFanarstScrape.Enabled = False
                        'End If
                    Else
                        tcEdit.TabPages.Remove(tpEFanarts)
                    End If

                    If Master.eSettings.MovieEThumbsAnyEnabled Then 'TODO: add buttons for extrathumbs
                        'If Not ModulesManager.Instance.QueryScraperCapabilities_Image_Movie(Enums.ScraperCapabilities.Fanart) Then
                        '    .btnSetMovieEThumbsScrape.Enabled = False
                        'End If
                    Else
                        tcEdit.TabPages.Remove(tpEThumbs)
                    End If

                    If Not Master.eSettings.MovieTrailerAnyEnabled Then
                        tcEdit.TabPages.Remove(tpTrailer)
                    End If

                    If Not Master.eSettings.MovieThemeAnyEnabled Then
                        tcEdit.TabPages.Remove(tpTheme)
                    End If

                    If Not String.IsNullOrEmpty(Me.tmpDBMovie.ThemePath) AndAlso Me.tmpDBMovie.ThemePath.Substring(0, 1) = ":" Then
                        MovieTheme.FromWeb(Me.tmpDBMovie.ThemePath.Substring(1, Me.tmpDBMovie.ThemePath.Length - 1))
                        ThemeAddToPlayer(MovieTheme)
                    ElseIf Not String.IsNullOrEmpty(Me.tmpDBMovie.ThemePath) Then
                        MovieTheme.FromFile(Me.tmpDBMovie.ThemePath)
                        ThemeAddToPlayer(MovieTheme)
                    End If

                    If Not String.IsNullOrEmpty(Me.tmpDBMovie.TrailerPath) AndAlso Me.tmpDBMovie.TrailerPath.Substring(0, 1) = ":" Then
                        MovieTrailer.WebTrailer.FromWeb(Me.tmpDBMovie.TrailerPath.Substring(1, Me.tmpDBMovie.TrailerPath.Length - 1))
                        TrailerPlaylistAdd(MovieTrailer)
                    ElseIf Not String.IsNullOrEmpty(Me.tmpDBMovie.TrailerPath) Then
                        MovieTrailer.WebTrailer.FromFile(Me.tmpDBMovie.TrailerPath)
                        TrailerPlaylistAdd(MovieTrailer)
                    End If

                    If Path.GetExtension(Me.tmpDBMovie.Filename).ToLower = ".disc" Then
                        Dim DiscStub As New MediaStub.DiscStub
                        DiscStub = MediaStub.LoadDiscStub(Me.tmpDBMovie.Filename)
                        .txtMediaStubTitle.Text = DiscStub.Title
                        .txtMediaStubMessage.Text = DiscStub.Message
                    End If

                    Me.LoadSubtitles()
                End If
            End With
        Catch ex As Exception
            logger.Error(New StackFrame().GetMethod().Name, ex)
        End Try
    End Sub

    Private Sub clbGenre_ItemCheck(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemCheckEventArgs) Handles clbGenre.ItemCheck
        If e.Index = 0 Then
            For i As Integer = 1 To clbGenre.Items.Count - 1
                Me.clbGenre.SetItemChecked(i, False)
            Next
        Else
            Me.clbGenre.SetItemChecked(0, False)
        End If
    End Sub

    Private Sub lbMPAA_DoubleClick(sender As Object, e As EventArgs) Handles lbMPAA.DoubleClick
        If Me.lbMPAA.SelectedItems.Count = 1 Then
            If Me.lbMPAA.SelectedIndex = 0 Then
                Me.txtMPAA.Text = String.Empty
            Else
                Me.txtMPAA.Text = Me.lbMPAA.SelectedItem.ToString
            End If
        End If
    End Sub

    Private Sub LoadGenres()
        '//
        ' Read all the genres from the xml and load into the list
        '\\

        Me.clbGenre.Items.Add(Master.eLang.None)

        Me.clbGenre.Items.AddRange(APIXML.GetGenreList)
    End Sub

    Private Sub LoadRatings()
        Me.lbMPAA.Items.Add(Master.eLang.None)
        If Not String.IsNullOrEmpty(Master.eSettings.MovieScraperMPAANotRated) Then Me.lbMPAA.Items.Add(Master.eSettings.MovieScraperMPAANotRated)
        Me.lbMPAA.Items.AddRange(APIXML.GetRatingList_Movie)
    End Sub

    Private Sub lvActors_ColumnClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles lvActors.ColumnClick
        ' Determine if the clicked column is already the column that is
        ' being sorted.
        Try
            If (e.Column = Me.lvwActorSorter.SortColumn) Then
                ' Reverse the current sort direction for this column.
                If (Me.lvwActorSorter.Order = SortOrder.Ascending) Then
                    Me.lvwActorSorter.Order = SortOrder.Descending
                Else
                    Me.lvwActorSorter.Order = SortOrder.Ascending
                End If
            Else
                ' Set the column number that is to be sorted; default to ascending.
                Me.lvwActorSorter.SortColumn = e.Column
                Me.lvwActorSorter.Order = SortOrder.Ascending
            End If

            ' Perform the sort with these new sort options.
            Me.lvActors.Sort()
        Catch ex As Exception
            logger.Error(New StackFrame().GetMethod().Name, ex)
        End Try
    End Sub

    Private Sub lvActors_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvActors.DoubleClick
        EditActor()
    End Sub

    Private Sub lvActors_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lvActors.KeyDown
        If e.KeyCode = Keys.Delete Then Me.DeleteActors()
    End Sub

    Private Sub lvEThumbs_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Delete Then Me.DeleteEThumbs()
    End Sub

    Private Sub lvEFanart_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Delete Then Me.DeleteEFanarts()
    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.ThemeStop()
        Me.TrailerStop()

        Me.SetInfo()
        Me.CleanUp()

        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub pbMovieBanner_DragDrop(sender As Object, e As DragEventArgs) Handles pbBanner.DragDrop
        Dim tImage As MediaContainers.Image = FileUtils.DragAndDrop.GetDoppedImage(e)
        If tImage.WebImage.Image IsNot Nothing Then
            Me.tmpDBMovie.ImagesContainer.Banner = tImage
            Me.pbBanner.Image = Me.tmpDBMovie.ImagesContainer.Banner.WebImage.Image
            Me.pbBanner.Tag = Me.tmpDBMovie.ImagesContainer.Banner
            Me.lblBannerSize.Text = String.Format(Master.eLang.GetString(269, "Size: {0}x{1}"), Me.pbBanner.Image.Width, Me.pbBanner.Image.Height)
            Me.lblBannerSize.Visible = True
        End If
    End Sub

    Private Sub pbMovieBanner_DragEnter(sender As Object, e As DragEventArgs) Handles pbBanner.DragEnter
        If FileUtils.DragAndDrop.CheckDroppedImage(e) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub pbMovieClearArt_DragDrop(sender As Object, e As DragEventArgs) Handles pbClearArt.DragDrop
        Dim tImage As MediaContainers.Image = FileUtils.DragAndDrop.GetDoppedImage(e)
        If tImage.WebImage.Image IsNot Nothing Then
            Me.tmpDBMovie.ImagesContainer.ClearArt = tImage
            Me.pbClearArt.Image = Me.tmpDBMovie.ImagesContainer.ClearArt.WebImage.Image
            Me.pbClearArt.Tag = Me.tmpDBMovie.ImagesContainer.ClearArt
            Me.lblClearArtSize.Text = String.Format(Master.eLang.GetString(269, "Size: {0}x{1}"), Me.pbClearArt.Image.Width, Me.pbClearArt.Image.Height)
            Me.lblClearArtSize.Visible = True
        End If
    End Sub

    Private Sub pbMovieClearArt_DragEnter(sender As Object, e As DragEventArgs) Handles pbClearArt.DragEnter
        If FileUtils.DragAndDrop.CheckDroppedImage(e) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub pbMovieClearLogo_DragDrop(sender As Object, e As DragEventArgs) Handles pbClearLogo.DragDrop
        Dim tImage As MediaContainers.Image = FileUtils.DragAndDrop.GetDoppedImage(e)
        If tImage.WebImage.Image IsNot Nothing Then
            Me.tmpDBMovie.ImagesContainer.ClearLogo = tImage
            Me.pbClearLogo.Image = Me.tmpDBMovie.ImagesContainer.ClearLogo.WebImage.Image
            Me.pbClearLogo.Tag = Me.tmpDBMovie.ImagesContainer.ClearLogo
            Me.lblClearLogoSize.Text = String.Format(Master.eLang.GetString(269, "Size: {0}x{1}"), Me.pbClearLogo.Image.Width, Me.pbClearLogo.Image.Height)
            Me.lblClearLogoSize.Visible = True
        End If
    End Sub

    Private Sub pbMovieClearLogo_DragEnter(sender As Object, e As DragEventArgs) Handles pbClearLogo.DragEnter
        If FileUtils.DragAndDrop.CheckDroppedImage(e) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub pbMovieDiscArt_DragDrop(sender As Object, e As DragEventArgs) Handles pbDiscArt.DragDrop
        Dim tImage As MediaContainers.Image = FileUtils.DragAndDrop.GetDoppedImage(e)
        If tImage.WebImage.Image IsNot Nothing Then
            Me.tmpDBMovie.ImagesContainer.DiscArt = tImage
            Me.pbDiscArt.Image = Me.tmpDBMovie.ImagesContainer.DiscArt.WebImage.Image
            Me.pbDiscArt.Tag = Me.tmpDBMovie.ImagesContainer.DiscArt
            Me.lblDiscArtSize.Text = String.Format(Master.eLang.GetString(269, "Size: {0}x{1}"), Me.pbDiscArt.Image.Width, Me.pbDiscArt.Image.Height)
            Me.lblDiscArtSize.Visible = True
        End If
    End Sub

    Private Sub pbMovieDiscArt_DragEnter(sender As Object, e As DragEventArgs) Handles pbDiscArt.DragEnter
        If FileUtils.DragAndDrop.CheckDroppedImage(e) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub pbMovieFanart_DragDrop(sender As Object, e As DragEventArgs) Handles pbFanart.DragDrop
        Dim tImage As MediaContainers.Image = FileUtils.DragAndDrop.GetDoppedImage(e)
        If tImage.WebImage.Image IsNot Nothing Then
            Me.tmpDBMovie.ImagesContainer.Fanart = tImage
            Me.pbFanart.Image = Me.tmpDBMovie.ImagesContainer.Fanart.WebImage.Image
            Me.pbFanart.Tag = Me.tmpDBMovie.ImagesContainer.Fanart
            Me.lblFanartSize.Text = String.Format(Master.eLang.GetString(269, "Size: {0}x{1}"), Me.pbFanart.Image.Width, Me.pbFanart.Image.Height)
            Me.lblFanartSize.Visible = True
        End If
    End Sub

    Private Sub pbMovieFanart_DragEnter(sender As Object, e As DragEventArgs) Handles pbFanart.DragEnter
        If FileUtils.DragAndDrop.CheckDroppedImage(e) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub pbMovieLandscape_DragDrop(sender As Object, e As DragEventArgs) Handles pbLandscape.DragDrop
        Dim tImage As MediaContainers.Image = FileUtils.DragAndDrop.GetDoppedImage(e)
        If tImage.WebImage.Image IsNot Nothing Then
            Me.tmpDBMovie.ImagesContainer.Landscape = tImage
            Me.pbLandscape.Image = Me.tmpDBMovie.ImagesContainer.Landscape.WebImage.Image
            Me.pbLandscape.Tag = Me.tmpDBMovie.ImagesContainer.Landscape
            Me.lblLandscapeSize.Text = String.Format(Master.eLang.GetString(269, "Size: {0}x{1}"), Me.pbLandscape.Image.Width, Me.pbLandscape.Image.Height)
            Me.lblLandscapeSize.Visible = True
        End If
    End Sub

    Private Sub pbMovieLandscape_DragEnter(sender As Object, e As DragEventArgs) Handles pbLandscape.DragEnter
        If FileUtils.DragAndDrop.CheckDroppedImage(e) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub pbMoviePoster_DragDrop(sender As Object, e As DragEventArgs) Handles pbPoster.DragDrop
        Dim tImage As MediaContainers.Image = FileUtils.DragAndDrop.GetDoppedImage(e)
        If tImage.WebImage.Image IsNot Nothing Then
            Me.tmpDBMovie.ImagesContainer.Poster = tImage
            Me.pbPoster.Image = Me.tmpDBMovie.ImagesContainer.Poster.WebImage.Image
            Me.pbPoster.Tag = Me.tmpDBMovie.ImagesContainer.Poster
            Me.lblPosterSize.Text = String.Format(Master.eLang.GetString(269, "Size: {0}x{1}"), Me.pbPoster.Image.Width, Me.pbPoster.Image.Height)
            Me.lblPosterSize.Visible = True
        End If
    End Sub

    Private Sub pbMoviePoster_DragEnter(sender As Object, e As DragEventArgs) Handles pbPoster.DragEnter
        If FileUtils.DragAndDrop.CheckDroppedImage(e) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub pbStar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbStar1.Click
        Me.tmpRating = Me.pbStar1.Tag.ToString
    End Sub

    Private Sub pbStar1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pbStar1.MouseLeave
        Try
            Dim tmpDBL As Single = 0
            Single.TryParse(Me.tmpRating, tmpDBL)
            Me.BuildStars(tmpDBL)
        Catch ex As Exception
            logger.Error(New StackFrame().GetMethod().Name, ex)
        End Try
    End Sub

    Private Sub pbStar1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbStar1.MouseMove
        Try
            If e.X < 12 Then
                Me.pbStar1.Tag = 0.5
                Me.BuildStars(0.5)
            Else
                Me.pbStar1.Tag = 1
                Me.BuildStars(1)
            End If
        Catch ex As Exception
            logger.Error(New StackFrame().GetMethod().Name, ex)
        End Try
    End Sub

    Private Sub pbStar2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbStar2.Click
        Me.tmpRating = Me.pbStar2.Tag.ToString
    End Sub

    Private Sub pbStar2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pbStar2.MouseLeave
        Try
            Dim tmpDBL As Single = 0
            Single.TryParse(Me.tmpRating, tmpDBL)
            Me.BuildStars(tmpDBL)
        Catch ex As Exception
            logger.Error(New StackFrame().GetMethod().Name, ex)
        End Try
    End Sub

    Private Sub pbStar2_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbStar2.MouseMove
        Try
            If e.X < 12 Then
                Me.pbStar2.Tag = 1.5
                Me.BuildStars(1.5)
            Else
                Me.pbStar2.Tag = 2
                Me.BuildStars(2)
            End If
        Catch ex As Exception
            logger.Error(New StackFrame().GetMethod().Name, ex)
        End Try
    End Sub

    Private Sub pbStar3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbStar3.Click
        Me.tmpRating = Me.pbStar3.Tag.ToString
    End Sub

    Private Sub pbStar3_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pbStar3.MouseLeave
        Try
            Dim tmpDBL As Single = 0
            Single.TryParse(Me.tmpRating, tmpDBL)
            Me.BuildStars(tmpDBL)
        Catch ex As Exception
            logger.Error(New StackFrame().GetMethod().Name, ex)
        End Try
    End Sub

    Private Sub pbStar3_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbStar3.MouseMove
        Try
            If e.X < 12 Then
                Me.pbStar3.Tag = 2.5
                Me.BuildStars(2.5)
            Else
                Me.pbStar3.Tag = 3
                Me.BuildStars(3)
            End If
        Catch ex As Exception
            logger.Error(New StackFrame().GetMethod().Name, ex)
        End Try
    End Sub

    Private Sub pbStar4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbStar4.Click
        Me.tmpRating = Me.pbStar4.Tag.ToString
    End Sub

    Private Sub pbStar4_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pbStar4.MouseLeave
        Try
            Dim tmpDBL As Single = 0
            Single.TryParse(Me.tmpRating, tmpDBL)
            Me.BuildStars(tmpDBL)
        Catch ex As Exception
            logger.Error(New StackFrame().GetMethod().Name, ex)
        End Try
    End Sub

    Private Sub pbStar4_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbStar4.MouseMove
        Try
            If e.X < 12 Then
                Me.pbStar4.Tag = 3.5
                Me.BuildStars(3.5)
            Else
                Me.pbStar4.Tag = 4
                Me.BuildStars(4)
            End If
        Catch ex As Exception
            logger.Error(New StackFrame().GetMethod().Name, ex)
        End Try
    End Sub

    Private Sub pbStar5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbStar5.Click
        Me.tmpRating = Me.pbStar5.Tag.ToString
    End Sub

    Private Sub pbStar5_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pbStar5.MouseLeave
        Try
            Dim tmpDBL As Single = 0
            Single.TryParse(Me.tmpRating, tmpDBL)
            Me.BuildStars(tmpDBL)
        Catch ex As Exception
            logger.Error(New StackFrame().GetMethod().Name, ex)
        End Try
    End Sub

    Private Sub pbStar5_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbStar5.MouseMove
        Try
            If e.X < 12 Then
                Me.pbStar5.Tag = 4.5
                Me.BuildStars(4.5)
            Else
                Me.pbStar5.Tag = 5
                Me.BuildStars(5)
            End If
        Catch ex As Exception
            logger.Error(New StackFrame().GetMethod().Name, ex)
        End Try
    End Sub

    Private Sub pbStar6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbStar6.Click
        Me.tmpRating = Me.pbStar6.Tag.ToString
    End Sub

    Private Sub pbStar6_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pbStar6.MouseLeave
        Try
            Dim tmpDBL As Single = 0
            Single.TryParse(Me.tmpRating, tmpDBL)
            Me.BuildStars(tmpDBL)
        Catch ex As Exception
            logger.Error(New StackFrame().GetMethod().Name, ex)
        End Try
    End Sub

    Private Sub pbStar6_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbStar6.MouseMove
        Try
            If e.X < 12 Then
                Me.pbStar6.Tag = 5.5
                Me.BuildStars(5.5)
            Else
                Me.pbStar6.Tag = 6
                Me.BuildStars(6)
            End If
        Catch ex As Exception
            logger.Error(New StackFrame().GetMethod().Name, ex)
        End Try
    End Sub

    Private Sub pbStar7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbStar7.Click
        Me.tmpRating = Me.pbStar7.Tag.ToString
    End Sub

    Private Sub pbStar7_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pbStar7.MouseLeave
        Try
            Dim tmpDBL As Single = 0
            Single.TryParse(Me.tmpRating, tmpDBL)
            Me.BuildStars(tmpDBL)
        Catch ex As Exception
            logger.Error(New StackFrame().GetMethod().Name, ex)
        End Try
    End Sub

    Private Sub pbStar7_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbStar7.MouseMove
        Try
            If e.X < 12 Then
                Me.pbStar7.Tag = 6.5
                Me.BuildStars(6.5)
            Else
                Me.pbStar7.Tag = 7
                Me.BuildStars(7)
            End If
        Catch ex As Exception
            logger.Error(New StackFrame().GetMethod().Name, ex)
        End Try
    End Sub

    Private Sub pbStar8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbStar8.Click
        Me.tmpRating = Me.pbStar8.Tag.ToString
    End Sub

    Private Sub pbStar8_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pbStar8.MouseLeave
        Try
            Dim tmpDBL As Single = 0
            Single.TryParse(Me.tmpRating, tmpDBL)
            Me.BuildStars(tmpDBL)
        Catch ex As Exception
            logger.Error(New StackFrame().GetMethod().Name, ex)
        End Try
    End Sub

    Private Sub pbStar8_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbStar8.MouseMove
        Try
            If e.X < 12 Then
                Me.pbStar8.Tag = 7.5
                Me.BuildStars(7.5)
            Else
                Me.pbStar8.Tag = 8
                Me.BuildStars(8)
            End If
        Catch ex As Exception
            logger.Error(New StackFrame().GetMethod().Name, ex)
        End Try
    End Sub

    Private Sub pbStar9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbStar9.Click
        Me.tmpRating = Me.pbStar9.Tag.ToString
    End Sub

    Private Sub pbStar9_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pbStar9.MouseLeave
        Try
            Dim tmpDBL As Single = 0
            Single.TryParse(Me.tmpRating, tmpDBL)
            Me.BuildStars(tmpDBL)
        Catch ex As Exception
            logger.Error(New StackFrame().GetMethod().Name, ex)
        End Try
    End Sub

    Private Sub pbStar9_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbStar9.MouseMove
        Try
            If e.X < 12 Then
                Me.pbStar9.Tag = 8.5
                Me.BuildStars(8.5)
            Else
                Me.pbStar9.Tag = 9
                Me.BuildStars(9)
            End If
        Catch ex As Exception
            logger.Error(New StackFrame().GetMethod().Name, ex)
        End Try
    End Sub

    Private Sub pbStar10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbStar10.Click
        Me.tmpRating = Me.pbStar10.Tag.ToString
    End Sub

    Private Sub pbStar10_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pbStar10.MouseLeave
        Try
            Dim tmpDBL As Single = 0
            Single.TryParse(Me.tmpRating, tmpDBL)
            Me.BuildStars(tmpDBL)
        Catch ex As Exception
            logger.Error(New StackFrame().GetMethod().Name, ex)
        End Try
    End Sub

    Private Sub pbStar10_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbStar10.MouseMove
        Try
            If e.X < 12 Then
                Me.pbStar10.Tag = 9.5
                Me.BuildStars(9.5)
            Else
                Me.pbStar10.Tag = 10
                Me.BuildStars(10)
            End If
        Catch ex As Exception
            logger.Error(New StackFrame().GetMethod().Name, ex)
        End Try
    End Sub

    Private Sub RefreshEThumbs()
        Try
            If Me.bwEThumbs.IsBusy Then Me.bwEThumbs.CancelAsync()
            While Me.bwEThumbs.IsBusy
                Application.DoEvents()
                Threading.Thread.Sleep(50)
            End While

            Me.iETTop = 1 ' set first image top position back to 1
            Me.EThumbsList.Clear()
            While Me.pnlEThumbsBG.Controls.Count > 0
                Me.pnlEThumbsBG.Controls(0).Dispose()
            End While

            Me.bwEThumbs.WorkerSupportsCancellation = True
            Me.bwEThumbs.RunWorkerAsync()
        Catch ex As Exception
            logger.Error(New StackFrame().GetMethod().Name, ex)
        End Try
    End Sub

    Private Sub RefreshEFanarts()
        Try
            If Me.bwEFanarts.IsBusy Then Me.bwEFanarts.CancelAsync()
            While Me.bwEFanarts.IsBusy
                Application.DoEvents()
                Threading.Thread.Sleep(50)
            End While

            Me.iEFTop = 1 ' set first image top position back to 1
            Me.EFanartsList.Clear()
            While Me.pnlEFanartsBG.Controls.Count > 0
                Me.pnlEFanartsBG.Controls(0).Dispose()
            End While

            Me.bwEFanarts.WorkerSupportsCancellation = True
            Me.bwEFanarts.RunWorkerAsync()
        Catch ex As Exception
            logger.Error(New StackFrame().GetMethod().Name, ex)
        End Try
    End Sub

    Private Sub RenumberEThumbs()
        For i As Integer = 0 To EThumbsList.Count - 1
            EThumbsList.Item(i).Index = i + 1
        Next
    End Sub

    Private Sub SaveEThumbsList()
        Try
            For Each a In FileUtils.GetFilenameList.Movie(Me.tmpDBMovie.Filename, Me.tmpDBMovie.IsSingle, Enums.ModifierType.MainEThumbs)
                If Directory.Exists(a) Then
                    FileUtils.Delete.DeleteDirectory(a)
                End If
            Next

            For Each eThumb As ExtraImages In EThumbsList
                Me.tmpDBMovie.EThumbsPath = eThumb.Image.SaveAsMovieExtrathumb(Me.tmpDBMovie)
            Next

        Catch ex As Exception
            logger.Error(New StackFrame().GetMethod().Name, ex)
        End Try
    End Sub

    Private Sub SaveEFanartsList()
        Try
            For Each a In FileUtils.GetFilenameList.Movie(Me.tmpDBMovie.Filename, Me.tmpDBMovie.IsSingle, Enums.ModifierType.MainEFanarts)
                If Directory.Exists(a) Then
                    FileUtils.Delete.DeleteDirectory(a)
                End If
            Next

            For Each eFanart As ExtraImages In EFanartsList
                Me.tmpDBMovie.EFanartsPath = eFanart.Image.SaveAsMovieExtrafanart(Me.tmpDBMovie, eFanart.Name)
            Next

        Catch ex As Exception
            logger.Error(New StackFrame().GetMethod().Name, ex)
        End Try
    End Sub

    Private Sub SelectMPAA()
        Try
            If Not String.IsNullOrEmpty(Me.tmpDBMovie.Movie.MPAA) Then
                If Master.eSettings.MovieScraperCertOnlyValue Then
                    Dim sItem As String = String.Empty
                    For i As Integer = 0 To Me.lbMPAA.Items.Count - 1
                        sItem = Me.lbMPAA.Items(i).ToString
                        If sItem.Contains(":") AndAlso sItem.Split(Convert.ToChar(":"))(1) = Me.tmpDBMovie.Movie.MPAA Then
                            Me.lbMPAA.SelectedIndex = i
                            Me.lbMPAA.TopIndex = i
                            Exit For
                        End If
                    Next
                Else
                    Dim i As Integer = 0
                    For ctr As Integer = 0 To Me.lbMPAA.Items.Count - 1
                        If Me.tmpDBMovie.Movie.MPAA.ToLower.StartsWith(Me.lbMPAA.Items.Item(ctr).ToString.ToLower) Then
                            i = ctr
                            Exit For
                        End If
                    Next
                    Me.lbMPAA.SelectedIndex = i
                    Me.lbMPAA.TopIndex = i

                    Dim strMPAA As String = String.Empty
                    Dim strMPAADesc As String = String.Empty
                    If i > 0 Then
                        strMPAA = Me.lbMPAA.Items.Item(i).ToString
                        strMPAADesc = Me.tmpDBMovie.Movie.MPAA.Replace(strMPAA, String.Empty).Trim
                        Me.txtMPAA.Text = strMPAA
                        Me.txtMPAADesc.Text = strMPAADesc
                    Else
                        Me.txtMPAA.Text = Me.tmpDBMovie.Movie.MPAA
                    End If
                End If
            End If

            If Me.lbMPAA.SelectedItems.Count = 0 Then
                Me.lbMPAA.SelectedIndex = 0
                Me.lbMPAA.TopIndex = 0
            End If

        Catch ex As Exception
            logger.Error(New StackFrame().GetMethod().Name, ex)
        End Try
    End Sub

    Private Sub SetInfo()
        Try
            With Me

                Me.OK_Button.Enabled = False
                Me.Cancel_Button.Enabled = False
                Me.btnRescrape.Enabled = False
                Me.btnChangeMovie.Enabled = False

                Me.tmpDBMovie.IsMark = Me.chkMark.Checked

                If Not String.IsNullOrEmpty(.txtSortTitle.Text) Then
                    Me.tmpDBMovie.Movie.SortTitle = .txtSortTitle.Text.Trim
                Else
                    Me.tmpDBMovie.Movie.SortTitle = StringUtils.SortTokens_Movie(.txtTitle.Text.Trim)
                End If

                Me.tmpDBMovie.Movie.Tagline = .txtTagline.Text.Trim
                Me.tmpDBMovie.Movie.Year = .mtxtYear.Text.Trim
                Me.tmpDBMovie.Movie.Votes = .txtVotes.Text.Trim
                Me.tmpDBMovie.Movie.Outline = .txtOutline.Text.Trim
                Me.tmpDBMovie.Movie.Plot = .txtPlot.Text.Trim
                Me.tmpDBMovie.Movie.Top250 = .txtTop250.Text.Trim
                Me.tmpDBMovie.Movie.Country = .txtCountry.Text.Trim
                Me.tmpDBMovie.Movie.Director = .txtDirector.Text.Trim
                Me.tmpDBMovie.Movie.Title = .txtTitle.Text.Trim
                Me.tmpDBMovie.Movie.Certification = .txtCerts.Text.Trim
                Me.tmpDBMovie.Movie.OriginalTitle = .txtOriginalTitle.Text.Trim
                Me.tmpDBMovie.Movie.MPAA = String.Concat(.txtMPAA.Text, " ", .txtMPAADesc.Text).Trim
                Me.tmpDBMovie.Movie.Runtime = .txtRuntime.Text.Trim
                Me.tmpDBMovie.Movie.ReleaseDate = .txtReleaseDate.Text.Trim
                Me.tmpDBMovie.Movie.OldCredits = .txtCredits.Text.Trim
                Me.tmpDBMovie.Movie.Studio = .txtStudio.Text.Trim
                Me.tmpDBMovie.VideoSource = .txtVideoSource.Text.Trim
                Me.tmpDBMovie.Movie.VideoSource = .txtVideoSource.Text.Trim
                Me.tmpDBMovie.Movie.Trailer = .txtTrailer.Text.Trim
                Me.tmpDBMovie.ListTitle = StringUtils.ListTitle_Movie(.txtTitle.Text, .mtxtYear.Text)

                If Not .tmpRating.Trim = String.Empty AndAlso .tmpRating.Trim <> "0" Then
                    Me.tmpDBMovie.Movie.Rating = .tmpRating
                Else
                    Me.tmpDBMovie.Movie.Rating = String.Empty
                End If

                'cocotus, 2013/02 Playcount/Watched state support added
                'if watched-checkbox is checked -> save Playcount=1 in nfo
                If chkWatched.Checked Then
                    'Only set to 1 if field was empty before (otherwise it would overwrite Playcount everytime which is not desirable)
                    If String.IsNullOrEmpty(Me.tmpDBMovie.Movie.PlayCount) Or Me.tmpDBMovie.Movie.PlayCount = "0" Then
                        Me.tmpDBMovie.Movie.PlayCount = "1"
                        Me.tmpDBMovie.Movie.LastPlayed = Date.Now.ToString("yyyy-MM-dd HH:mm:ss")
                    End If
                Else
                    'Unchecked Watched State -> Set Playcount back to 0, but only if it was filled before (check could save time)
                    If Integer.TryParse(Me.tmpDBMovie.Movie.PlayCount, 0) AndAlso CInt(Me.tmpDBMovie.Movie.PlayCount) > 0 Then
                        Me.tmpDBMovie.Movie.PlayCount = ""
                        Me.tmpDBMovie.Movie.LastPlayed = ""
                    End If
                End If
                'cocotus End

                If .clbGenre.CheckedItems.Count > 0 Then
                    If .clbGenre.CheckedIndices.Contains(0) Then
                        Me.tmpDBMovie.Movie.Genre = String.Empty
                    Else
                        Dim strGenre As String = String.Empty
                        Dim isFirst As Boolean = True
                        Dim iChecked = From iCheck In .clbGenre.CheckedItems
                        strGenre = String.Join(" / ", iChecked.ToArray)
                        Me.tmpDBMovie.Movie.Genre = strGenre.Trim
                    End If
                End If

                Me.tmpDBMovie.Movie.Actors.Clear()

                If .lvActors.Items.Count > 0 Then
                    Dim iOrder As Integer = 0
                    For Each lviActor As ListViewItem In .lvActors.Items
                        Dim addActor As New MediaContainers.Person
                        addActor.ID = CInt(lviActor.Text)
                        addActor.Name = lviActor.SubItems(1).Text.Trim
                        addActor.Role = lviActor.SubItems(2).Text.Trim
                        addActor.ThumbURL = lviActor.SubItems(3).Text.Trim
                        addActor.Order = iOrder
                        iOrder += 1
                        Me.tmpDBMovie.Movie.Actors.Add(addActor)
                    Next
                End If

                If ActorThumbsHasChanged Then
                    For Each act As MediaContainers.Person In Me.tmpDBMovie.Movie.Actors
                        Dim img As New Images
                        img.FromWeb(act.ThumbURL)
                        If img.Image IsNot Nothing Then
                            act.ThumbPath = img.SaveAsMovieActorThumb(act, Directory.GetParent(Me.tmpDBMovie.Filename).FullName, Me.tmpDBMovie)
                        Else
                            act.ThumbPath = String.Empty
                        End If
                    Next
                End If

                If Not String.IsNullOrEmpty(.MovieTheme.Extention) AndAlso Not MovieTheme.toRemove Then 'TODO: proper check, extention check is only a woraround
                    Dim tPath As String = .MovieTheme.SaveAsMovieTheme(Me.tmpDBMovie)
                    Me.tmpDBMovie.ThemePath = tPath
                Else
                    Themes.DeleteMovieTheme(Me.tmpDBMovie)
                    Me.tmpDBMovie.ThemePath = String.Empty
                End If

                If Not String.IsNullOrEmpty(.MovieTrailer.WebTrailer.Extention) AndAlso Not MovieTrailer.WebTrailer.toRemove Then 'TODO: proper check, extention check is only a woraround
                    If Master.eSettings.MovieTrailerDeleteExisting Then
                        Trailers.DeleteMovieTrailer(Me.tmpDBMovie)
                    End If
                    Dim tPath As String = .MovieTrailer.WebTrailer.SaveAsMovieTrailer(Me.tmpDBMovie)
                    Me.tmpDBMovie.TrailerPath = tPath
                Else
                    Trailers.DeleteMovieTrailer(Me.tmpDBMovie)
                    Me.tmpDBMovie.TrailerPath = String.Empty
                End If

                If Path.GetExtension(Me.tmpDBMovie.Filename) = ".disc" Then
                    Dim StubFile As String = Me.tmpDBMovie.Filename
                    Dim Title As String = Me.txtMediaStubTitle.Text
                    Dim Message As String = Me.txtMediaStubMessage.Text
                    MediaStub.SaveDiscStub(StubFile, Title, Message)
                End If

                If Not Master.eSettings.MovieImagesNotSaveURLToNfo AndAlso pResults.Posters.Count > 0 Then Me.tmpDBMovie.Movie.Thumb = pResults.Posters
                If Not Master.eSettings.MovieImagesNotSaveURLToNfo AndAlso fResults.Fanart.Thumb.Count > 0 Then Me.tmpDBMovie.Movie.Fanart = pResults.Fanart

                Dim removeSubtitles As New List(Of MediaInfo.Subtitle)
                For Each Subtitle In Me.tmpDBMovie.Subtitles
                    If Subtitle.toRemove Then
                        removeSubtitles.Add(Subtitle)
                    End If
                Next
                For Each Subtitle In removeSubtitles
                    If File.Exists(Subtitle.SubsPath) Then
                        File.Delete(Subtitle.SubsPath)
                    End If
                    Me.tmpDBMovie.Subtitles.Remove(Subtitle)
                Next

                .SaveEThumbsList()

                .SaveEFanartsList()

            End With
        Catch ex As Exception
            logger.Error(New StackFrame().GetMethod().Name, ex)
        End Try
    End Sub

    Private Sub SetUp()
        Dim mTitle As String = Me.tmpDBMovie.Movie.Title
        Dim sTitle As String = String.Concat(Master.eLang.GetString(25, "Edit Movie"), If(String.IsNullOrEmpty(mTitle), String.Empty, String.Concat(" - ", mTitle)))
        Me.Text = sTitle
        Me.tsFilename.Text = Me.tmpDBMovie.Filename
        Me.Cancel_Button.Text = Master.eLang.GetString(167, "Cancel")
        Me.OK_Button.Text = Master.eLang.GetString(179, "OK")
        Me.btnChangeMovie.Text = Master.eLang.GetString(32, "Change Movie")
        Me.btnManual.Text = Master.eLang.GetString(230, "Manual Edit")
        Me.btnEFanartsSetAsFanart.Text = Me.btnEThumbsSetAsFanart.Text
        Me.btnMovieEFanartsTransfer.Text = Me.btnMovieEThumbsTransfer.Text
        Me.btnEThumbsSetAsFanart.Text = Master.eLang.GetString(255, "Set As Fanart")
        Me.btnMovieEThumbsTransfer.Text = Master.eLang.GetString(254, "Transfer Now")
        Me.btnRemoveBanner.Text = Master.eLang.GetString(1024, "Remove Banner")
        Me.btnRemoveClearArt.Text = Master.eLang.GetString(1087, "Remove ClearArt")
        Me.btnRemoveClearLogo.Text = Master.eLang.GetString(1091, "Remove ClearLogo")
        Me.btnRemoveDiscArt.Text = Master.eLang.GetString(1095, "Remove DiscArt")
        Me.btnRemoveFanart.Text = Master.eLang.GetString(250, "Remove Fanart")
        Me.btnRemoveLandscape.Text = Master.eLang.GetString(1034, "Remove Landscape")
        Me.btnRemovePoster.Text = Master.eLang.GetString(247, "Remove Poster")
        Me.btnRemoveTrailer.Text = Master.eLang.GetString(1196, "Remove Trailer")
        Me.btnRescrape.Text = Master.eLang.GetString(716, "Re-Scrape")
        Me.btnSetBannerDL.Text = Master.eLang.GetString(1023, "Change Banner (Download)")
        Me.btnSetBannerLocal.Text = Master.eLang.GetString(1021, "Change Banner (Local)")
        Me.btnSetBannerScrape.Text = Master.eLang.GetString(1022, "Change Banner (Scrape)")
        Me.btnSetClearArtDL.Text = Master.eLang.GetString(1086, "Change ClearArt (Download)")
        Me.btnSetClearArtLocal.Text = Master.eLang.GetString(1084, "Change ClearArt (Local)")
        Me.btnSetClearArtScrape.Text = Master.eLang.GetString(1085, "Change ClearArt (Scrape)")
        Me.btnSetClearLogoDL.Text = Master.eLang.GetString(1090, "Change ClearLogo (Download)")
        Me.btnSetClearLogoLocal.Text = Master.eLang.GetString(1088, "Change ClearLogo (Local)")
        Me.btnSetClearLogoScrape.Text = Master.eLang.GetString(1089, "Change ClearLogo (Scrape)")
        Me.btnSetDiscArtDL.Text = Master.eLang.GetString(1094, "Change DiscArt (Download)")
        Me.btnSetDiscArtLocal.Text = Master.eLang.GetString(1092, "Change DiscArt (Local)")
        Me.btnSetDiscArtScrape.Text = Master.eLang.GetString(1093, "Change DiscArt (Scrape)")
        Me.btnSetFanartDL.Text = Master.eLang.GetString(266, "Change Fanart (Download)")
        Me.btnSetFanartLocal.Text = Master.eLang.GetString(252, "Change Fanart (Local)")
        Me.btnSetFanartScrape.Text = Master.eLang.GetString(251, "Change Fanart (Scrape)")
        Me.btnSetLandscapeDL.Text = Master.eLang.GetString(1033, "Change Landscape (Download)")
        Me.btnSetLandscapeLocal.Text = Master.eLang.GetString(1031, "Change Landscape (Local)")
        Me.btnSetLandscapeScrape.Text = Master.eLang.GetString(1032, "Change Landscape (Scrape)")
        Me.btnSetPosterDL.Text = Master.eLang.GetString(265, "Change Poster (Download)")
        Me.btnSetPosterLocal.Text = Master.eLang.GetString(249, "Change Poster (Local)")
        Me.btnSetPosterScrape.Text = Master.eLang.GetString(248, "Change Poster (Scrape)")
        Me.chkMark.Text = Master.eLang.GetString(23, "Mark")
        Me.chkWatched.Text = Master.eLang.GetString(981, "Watched")
        Me.colName.Text = Master.eLang.GetString(232, "Name")
        Me.colRole.Text = Master.eLang.GetString(233, "Role")
        Me.colThumb.Text = Master.eLang.GetString(234, "Thumb")
        Me.lbMovieEFanartsQueue.Text = Master.eLang.GetString(974, "You have extratfanarts queued to be transferred to the movie directory.")
        Me.lbMovieEThumbsQueue.Text = Master.eLang.GetString(253, "You have extrathumbs queued to be transferred to the movie directory.")
        Me.lblActors.Text = Master.eLang.GetString(231, "Actors:")
        Me.lblCerts.Text = Master.eLang.GetString(237, "Certification(s):")
        Me.lblCountry.Text = String.Concat(Master.eLang.GetString(301, "Country"), ":")
        Me.lblCredits.Text = Master.eLang.GetString(228, "Credits:")
        Me.lblDirector.Text = Master.eLang.GetString(239, "Director:")
        Me.lblVideoSource.Text = Master.eLang.GetString(824, "Video Source:")
        Me.lblGenre.Text = Master.eLang.GetString(51, "Genre(s):")
        Me.lblMPAA.Text = Master.eLang.GetString(235, "MPAA Rating:")
        Me.lblMPAADesc.Text = Master.eLang.GetString(229, "MPAA Rating Description:")
        Me.lblOriginalTitle.Text = String.Concat(Master.eLang.GetString(302, "Original Title"), ":")
        Me.lblOutline.Text = Master.eLang.GetString(242, "Plot Outline:")
        Me.lblPlot.Text = Master.eLang.GetString(241, "Plot:")
        Me.lblRating.Text = Master.eLang.GetString(245, "Rating:")
        Me.lblReleaseDate.Text = Master.eLang.GetString(236, "Release Date:")
        Me.lblRuntime.Text = Master.eLang.GetString(238, "Runtime:")
        Me.lblSortTilte.Text = String.Concat(Master.eLang.GetString(642, "Sort Title"), ":")
        Me.lblStudio.Text = Master.eLang.GetString(226, "Studio:")
        Me.lblTagline.Text = Master.eLang.GetString(243, "Tagline:")
        Me.lblTitle.Text = Master.eLang.GetString(246, "Title:")
        Me.lblTop250.Text = Master.eLang.GetString(240, "Top 250:")
        Me.lblTopDetails.Text = Master.eLang.GetString(224, "Edit the details for the selected movie.")
        Me.lblTopTitle.Text = Master.eLang.GetString(25, "Edit Movie")
        Me.lblTrailerURL.Text = Master.eLang.GetString(227, "Trailer URL:")
        Me.lblVotes.Text = Master.eLang.GetString(244, "Votes:")
        Me.lblYear.Text = Master.eLang.GetString(49, "Year:")
        Me.tpBanner.Text = Master.eLang.GetString(838, "Banner")
        Me.tpClearArt.Text = Master.eLang.GetString(1096, "ClearArt")
        Me.tpClearLogo.Text = Master.eLang.GetString(1097, "ClearLogo")
        Me.tpDetails.Text = Master.eLang.GetString(1098, "DiscArt")
        Me.tpDetails.Text = Master.eLang.GetString(26, "Details")
        Me.tpEFanarts.Text = Master.eLang.GetString(992, "Extrafanarts")
        Me.tpEThumbs.Text = Master.eLang.GetString(153, "Extrathumbs")
        Me.tpFanart.Text = Master.eLang.GetString(149, "Fanart")
        Me.tpFrameExtraction.Text = Master.eLang.GetString(256, "Frame Extraction")
        Me.tpLandscape.Text = Master.eLang.GetString(1059, "Landscape")
        Me.tpMetaData.Text = Master.eLang.GetString(866, "Metadata")
        Me.tpPoster.Text = Master.eLang.GetString(148, "Poster")
    End Sub

    Private Sub tcEditMovie_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tcEdit.SelectedIndexChanged
        Me.lvSubtitles.SelectedItems.Clear()
        Me.ThemeStop()
        Me.TrailerStop()
    End Sub

    Private Sub txtThumbCount_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = StringUtils.NumericOnly(e.KeyChar)
    End Sub

    Private Sub txtThumbCount_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.AcceptButton = Me.OK_Button
    End Sub

    Private Sub txtTrailer_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTrailer.TextChanged
        If StringUtils.isValidURL(txtTrailer.Text) Then
            Me.btnPlayTrailer.Enabled = True
        Else
            Me.btnPlayTrailer.Enabled = False
        End If
    End Sub

    Sub GenericRunCallBack(ByVal mType As Enums.ModuleEventType, ByRef _params As List(Of Object))
        If mType = Enums.ModuleEventType.FrameExtrator_Movie AndAlso _params IsNot Nothing Then
            If _params(0).ToString = "FanartToSave" Then
                Me.tmpDBMovie.ImagesContainer.Fanart.WebImage.FromFile(Path.Combine(Master.TempPath, "frame.jpg"))
                If Me.tmpDBMovie.ImagesContainer.Fanart.WebImage.Image IsNot Nothing Then
                    Me.pbFanart.Image = Me.tmpDBMovie.ImagesContainer.Fanart.WebImage.Image
                    Me.pbFanart.Tag = Me.tmpDBMovie.ImagesContainer.Fanart

                    Me.lblFanartSize.Text = String.Format(Master.eLang.GetString(269, "Size: {0}x{1}"), Me.pbFanart.Image.Width, Me.pbFanart.Image.Height)
                    Me.lblFanartSize.Visible = True
                End If
            ElseIf _params(0).ToString = "EFanartToSave" Then
                Dim fPath As String = _params(1).ToString
                If Not String.IsNullOrEmpty(fPath) AndAlso File.Exists(fPath) Then
                    EFanartsExtractor.Add(fPath)
                    Me.RefreshEFanarts()
                End If
            ElseIf _params(0).ToString = "EThumbToSave" Then
                Dim fPath As String = _params(1).ToString
                If Not String.IsNullOrEmpty(fPath) AndAlso File.Exists(fPath) Then
                    EThumbsExtractor.Add(fPath)
                    Me.RefreshEThumbs()
                End If
            End If
        End If
    End Sub

    Private Sub txtOutline_KeyDown(ByVal sender As Object, e As KeyEventArgs) Handles txtOutline.KeyDown
        If e.KeyData = (Keys.Control Or Keys.A) Then
            Me.txtOutline.SelectAll()
        End If
    End Sub

    Private Sub txtPlot_KeyDown(ByVal sender As Object, e As KeyEventArgs) Handles txtPlot.KeyDown
        If e.KeyData = (Keys.Control Or Keys.A) Then
            Me.txtPlot.SelectAll()
        End If
    End Sub

    Private Sub lvSubtitles_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lvSubtitles.KeyDown
        If e.KeyCode = Keys.Delete Then Me.DeleteSubtitle()
    End Sub

    Private Sub lvSubtitles_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvSubtitles.DoubleClick
        If lvSubtitles.SelectedItems.Count > 0 Then
            If lvSubtitles.SelectedItems.Item(0).Tag.ToString <> "Header" Then
                EditSubtitle()
            End If
        End If
    End Sub

    Private Sub lvSubtitles_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvSubtitles.SelectedIndexChanged
        If lvSubtitles.SelectedItems.Count > 0 Then
            If lvSubtitles.SelectedItems.Item(0).Tag.ToString = "Header" Then
                lvSubtitles.SelectedItems.Clear()
                btnRemoveSubtitle.Enabled = False
                txtSubtitlesPreview.Clear()
            Else
                btnRemoveSubtitle.Enabled = True
                txtSubtitlesPreview.Text = ReadSubtitle(Me.lvSubtitles.SelectedItems.Item(0).SubItems(1).Text.ToString)
            End If
        Else
            btnRemoveSubtitle.Enabled = False
            txtSubtitlesPreview.Clear()
        End If
    End Sub

    Private Function ReadSubtitle(ByVal sPath As String) As String
        Dim sText As String = String.Empty

        If Not String.IsNullOrEmpty(sPath) AndAlso File.Exists(sPath) Then
            Try
                Dim objReader As New StreamReader(sPath)

                sText = objReader.ReadToEnd

                objReader.Close()

                Return sText
            Catch ex As Exception
                logger.Error(New StackFrame().GetMethod().Name, ex)
            End Try
        End If

        Return String.Empty
    End Function

    Private Sub EditSubtitle()
        Try
            If lvSubtitles.SelectedItems.Count > 0 Then
                Dim i As ListViewItem = lvSubtitles.SelectedItems(0)
                Dim tmpFileInfo As New MediaInfo.Fileinfo
                tmpFileInfo.StreamDetails.Subtitle.AddRange(Me.tmpDBMovie.Subtitles)
                Using dEditStream As New dlgFIStreamEditor
                    Dim stream As Object = dEditStream.ShowDialog(i.Tag.ToString, tmpFileInfo, Convert.ToInt16(i.Text))
                    If Not stream Is Nothing Then
                        If i.Tag.ToString = Master.eLang.GetString(597, "Subtitle Stream") Then
                            Me.tmpDBMovie.Subtitles(Convert.ToInt16(i.Text)) = DirectCast(stream, MediaInfo.Subtitle)
                        End If
                        'NeedToRefresh = True
                        LoadSubtitles()
                    End If
                End Using
            End If
        Catch ex As Exception
            logger.Error(New StackFrame().GetMethod().Name, ex)
        End Try
    End Sub

    Private Sub DeleteSubtitle()
        Try
            If lvSubtitles.SelectedItems.Count > 0 Then
                Dim i As ListViewItem = lvSubtitles.SelectedItems(0)
                If i.Tag.ToString = Master.eLang.GetString(597, "Subtitle Stream") Then
                    Me.tmpDBMovie.Subtitles(Convert.ToInt16(i.Text)).toRemove = True
                End If
                'NeedToRefresh = True
                LoadSubtitles()
            End If
        Catch ex As Exception
            logger.Error(New StackFrame().GetMethod().Name, ex)
        End Try
    End Sub

    Private Sub LoadSubtitles()
        Dim c As Integer
        Dim g As New ListViewGroup
        Dim i As New ListViewItem
        lvSubtitles.Groups.Clear()
        lvSubtitles.Items.Clear()
        Try
            If Me.tmpDBMovie.Subtitles.Count > 0 Then
                g = New ListViewGroup
                g.Header = Master.eLang.GetString(597, "Subtitle Stream")
                lvSubtitles.Groups.Add(g)
                c = 1
                ' Fake Group Header
                i = New ListViewItem
                'i.UseItemStyleForSubItems = False
                i.ForeColor = Color.DarkBlue
                i.Tag = "Header"
                i.Text = String.Empty
                i.SubItems.Add(Master.eLang.GetString(60, "File Path"))
                i.SubItems.Add(Master.eLang.GetString(610, "Language"))
                i.SubItems.Add(Master.eLang.GetString(1288, "Type"))
                i.SubItems.Add(Master.eLang.GetString(1287, "Forced"))

                g.Items.Add(i)
                lvSubtitles.Items.Add(i)
                Dim s As MediaInfo.Subtitle
                For c = 0 To Me.tmpDBMovie.Subtitles.Count - 1
                    s = Me.tmpDBMovie.Subtitles(c)
                    If Not s Is Nothing Then
                        i = New ListViewItem
                        i.Tag = Master.eLang.GetString(597, "Subtitle Stream")
                        i.Text = c.ToString
                        i.SubItems.Add(s.SubsPath)
                        i.SubItems.Add(s.LongLanguage)
                        i.SubItems.Add(s.SubsType)
                        i.SubItems.Add(If(s.SubsForced, Master.eLang.GetString(300, "Yes"), Master.eLang.GetString(720, "No")))

                        If s.toRemove Then
                            i.ForeColor = Color.Red
                        End If

                        g.Items.Add(i)
                        lvSubtitles.Items.Add(i)
                    End If
                Next
            End If


        Catch ex As Exception
            logger.Error(New StackFrame().GetMethod().Name, ex)
        End Try
    End Sub

#End Region 'Methods

#Region "Nested Types"

    Friend Class ExtraImages

#Region "Fields"

        Private _image As New Images
        Private _index As Integer
        Private _name As String
        Private _path As String

#End Region 'Fields

#Region "Constructors"

        Friend Sub New()
            Clear()
        End Sub

#End Region 'Constructors

#Region "Properties"

        Friend Property Image() As Images
            Get
                Return _image
            End Get
            Set(ByVal value As Images)
                _image = value
            End Set
        End Property

        Friend Property Index() As Integer
            Get
                Return _index
            End Get
            Set(ByVal value As Integer)
                _index = value
            End Set
        End Property

        Friend Property Name() As String
            Get
                Return _name
            End Get
            Set(ByVal value As String)
                _name = value
            End Set
        End Property

        Friend Property Path() As String
            Get
                Return _path
            End Get
            Set(ByVal value As String)
                _path = value
            End Set
        End Property

#End Region 'Properties

#Region "Methods"

        Private Sub Clear()
            _image = Nothing
            _name = String.Empty
            _index = Nothing
            _path = String.Empty
        End Sub

#End Region 'Methods

    End Class

#End Region 'Nested Types

End Class