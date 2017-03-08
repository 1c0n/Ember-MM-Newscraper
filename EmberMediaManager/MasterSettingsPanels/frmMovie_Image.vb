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

Public Class frmMovie_Image
    Implements Interfaces.MasterSettingsPanel

#Region "Fields"

    Shared logger As Logger = LogManager.GetCurrentClassLogger

    Dim _ePanelType As Enums.SettingsPanelType = Enums.SettingsPanelType.Movie
    Dim _intImageIndex As Integer = 6
    Dim _intOrder As Integer = 500
    Dim _strName As String = "Movie_Image"
    Dim _strTitle As String = Master.eLang.GetString(497, "Images")

    Private _bDGVWidthCalculated As Boolean

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
        With Master.eSettings.Movie.ImageSettings
            cbMovieBannerPrefSize.SelectedValue = .BannerPrefSize
            cbMovieClearArtPrefSize.SelectedValue = .ClearArtPrefSize
            cbMovieClearLogoPrefSize.SelectedValue = .ClearLogoPrefSize
            cbMovieDiscArtPrefSize.SelectedValue = .DiscArtPrefSize
            cbMovieExtrafanartsPrefSize.SelectedValue = .ExtrafanartsPrefSize
            cbMovieExtrathumbsPrefSize.SelectedValue = .ExtrathumbsPrefSize
            cbMovieFanartPrefSize.SelectedValue = .FanartPrefSize
            cbMovieLandscapePrefSize.SelectedValue = .LandscapePrefSize
            cbMoviePosterPrefSize.SelectedValue = .PosterPrefSize
            chkMovieActorThumbsKeepExisting.Checked = .ActorThumbsKeepExisting
            chkMovieBannerKeepExisting.Checked = .BannerKeepExisting
            chkMovieBannerPrefSizeOnly.Checked = .BannerPrefSizeOnly
            txtMovieBannerHeight.Text = .BannerMaxHeight.ToString
            txtMovieBannerWidth.Text = .BannerMaxWidth.ToString
            chkMovieClearArtKeepExisting.Checked = .ClearArtKeepExisting
            chkMovieClearArtPrefSizeOnly.Checked = .ClearArtPrefSizeOnly
            chkMovieClearLogoKeepExisting.Checked = .ClearLogoKeepExisting
            chkMovieClearLogoPrefSizeOnly.Checked = .ClearLogoPrefSizeOnly
            chkMovieDiscArtKeepExisting.Checked = .DiscArtKeepExisting
            chkMovieDiscArtPrefSizeOnly.Checked = .DiscArtPrefSizeOnly
            chkMovieExtrafanartsKeepExisting.Checked = .ExtrafanartsKeepExisting
            chkMovieExtrafanartsPrefSizeOnly.Checked = .ExtrafanartsPrefSizeOnly
            chkMovieExtrafanartsPreselect.Checked = .ExtrafanartsPreselect
            txtMovieExtrafanartsHeight.Text = .ExtrafanartsMaxHeight.ToString
            txtMovieExtrafanartsWidth.Text = .ExtrafanartsMaxWidth.ToString
            chkMovieExtrathumbsCreatorAutoThumbs.Checked = .ExtrathumbsCreatorAuto
            chkMovieExtrathumbsCreatorNoBlackBars.Checked = .ExtrathumbsCreatorNoBlackBars
            chkMovieExtrathumbsCreatorNoSpoilers.Checked = .ExtrathumbsCreatorNoSpoilers
            chkMovieExtrathumbsCreatorUseETasFA.Checked = .ExtrathumbsCreatorUseETasFA
            chkMovieExtrathumbsKeepExisting.Checked = .ExtrathumbsKeepExisting
            chkMovieExtrathumbsPrefSizeOnly.Checked = .ExtrathumbsPrefSizeOnly
            chkMovieExtrathumbsPreselect.Checked = .ExtrathumbsPreselect
            txtMovieExtrathumbsHeight.Text = .ExtrathumbsMaxHeight.ToString
            txtMovieExtrathumbsWidth.Text = .ExtrathumbsMaxWidth.ToString
            chkMovieFanartKeepExisting.Checked = .FanartKeepExisting
            chkMovieFanartPrefSizeOnly.Checked = .FanartPrefSizeOnly
            txtMovieFanartHeight.Text = .FanartMaxHeight.ToString
            txtMovieFanartWidth.Text = .FanartMaxWidth.ToString
            chkMovieImagesCacheEnabled.Checked = .ImagesCacheEnabled
            chkMovieImagesDisplayImageSelect.Checked = .ImagesDisplayImageSelect
            chkMovieImagesForceLanguage.Checked = .ImagesForceLanguage
            If .ImagesMediaLanguageOnly Then
                chkMovieImagesMediaLanguageOnly.Checked = True
                chkMovieImagesGetBlankImages.Checked = .ImagesGetBlankImages
                chkMovieImagesGetEnglishImages.Checked = .ImagesGetEnglishImages
            End If
            chkMovieImagesNotSaveURLToNfo.Checked = .ImagesNotSaveURLToNfo
            chkMovieLandscapeKeepExisting.Checked = .LandscapeKeepExisting
            chkMovieLandscapePrefSizeOnly.Checked = .LandscapePrefSizeOnly
            chkMoviePosterKeepExisting.Checked = .PosterKeepExisting
            chkMoviePosterPrefSizeOnly.Checked = .PosterPrefSizeOnly
            txtMoviePosterHeight.Text = .PosterMaxHeight.ToString
            txtMoviePosterWidth.Text = .PosterMaxWidth.ToString
            txtMovieExtrafanartsLimit.Text = .ExtrafanartsLimit.ToString
            txtMovieExtrathumbsLimit.Text = .ExtrathumbsLimit.ToString

            Try
                cbMovieImagesForcedLanguage.Items.Clear()
                cbMovieImagesForcedLanguage.Items.AddRange((From lLang In APIXML.ScraperLanguagesXML.Languages Select lLang.Name).Distinct.ToArray)
                If cbMovieImagesForcedLanguage.Items.Count > 0 Then
                    If Not String.IsNullOrEmpty(.ImagesForcedLanguage) Then
                        Dim tLanguage As languageProperty = APIXML.ScraperLanguagesXML.Languages.FirstOrDefault(Function(l) l.Abbrevation_MainLanguage = .ImagesForcedLanguage)
                        If tLanguage IsNot Nothing Then
                            cbMovieImagesForcedLanguage.Text = tLanguage.Name
                        Else
                            tLanguage = APIXML.ScraperLanguagesXML.Languages.FirstOrDefault(Function(l) l.Abbreviation.StartsWith(.ImagesForcedLanguage))
                            If tLanguage IsNot Nothing Then
                                cbMovieImagesForcedLanguage.Text = tLanguage.Name
                            Else
                                cbMovieImagesForcedLanguage.Text = APIXML.ScraperLanguagesXML.Languages.FirstOrDefault(Function(l) l.Abbrevation_MainLanguage = "en").Name
                            End If
                        End If
                    Else
                        cbMovieImagesForcedLanguage.Text = APIXML.ScraperLanguagesXML.Languages.FirstOrDefault(Function(l) l.Abbrevation_MainLanguage = "en").Name
                    End If
                End If
            Catch ex As Exception
                logger.Error(ex, New StackFrame().GetMethod().Name)
            End Try
        End With
    End Sub

    Public Sub SaveSetup() Implements Interfaces.MasterSettingsPanel.SaveSetup
        With Master.eSettings.Movie.ImageSettings
            .ActorThumbsKeepExisting = chkMovieActorThumbsKeepExisting.Checked
            .BannerMaxHeight = If(Not String.IsNullOrEmpty(txtMovieBannerHeight.Text), Convert.ToInt32(txtMovieBannerHeight.Text), 0)
            .BannerKeepExisting = chkMovieBannerKeepExisting.Checked
            .BannerPrefSize = CType(cbMovieBannerPrefSize.SelectedItem, KeyValuePair(Of String, Enums.ImageSize)).Value
            .BannerPrefSizeOnly = chkMovieBannerPrefSizeOnly.Checked
            .BannerMaxWidth = If(Not String.IsNullOrEmpty(txtMovieBannerWidth.Text), Convert.ToInt32(txtMovieBannerWidth.Text), 0)
            .ClearArtKeepExisting = chkMovieClearArtKeepExisting.Checked
            .ClearArtPrefSize = CType(cbMovieClearArtPrefSize.SelectedItem, KeyValuePair(Of String, Enums.ImageSize)).Value
            .ClearArtPrefSizeOnly = chkMovieClearArtPrefSizeOnly.Checked
            .ClearLogoKeepExisting = chkMovieClearLogoKeepExisting.Checked
            .ClearLogoPrefSize = CType(cbMovieClearLogoPrefSize.SelectedItem, KeyValuePair(Of String, Enums.ImageSize)).Value
            .ClearLogoPrefSizeOnly = chkMovieClearLogoPrefSizeOnly.Checked
            .DiscArtKeepExisting = chkMovieDiscArtKeepExisting.Checked
            .DiscArtPrefSize = CType(cbMovieDiscArtPrefSize.SelectedItem, KeyValuePair(Of String, Enums.ImageSize)).Value
            .DiscArtPrefSizeOnly = chkMovieDiscArtPrefSizeOnly.Checked
            .ExtrafanartsMaxHeight = If(Not String.IsNullOrEmpty(txtMovieExtrafanartsHeight.Text), Convert.ToInt32(txtMovieExtrafanartsHeight.Text), 0)
            .ExtrafanartsLimit = If(Not String.IsNullOrEmpty(txtMovieExtrafanartsLimit.Text), Convert.ToInt32(txtMovieExtrafanartsLimit.Text), 0)
            .ExtrafanartsKeepExisting = chkMovieExtrafanartsKeepExisting.Checked
            .ExtrafanartsPrefSize = CType(cbMovieExtrafanartsPrefSize.SelectedItem, KeyValuePair(Of String, Enums.ImageSize)).Value
            .ExtrafanartsPrefSizeOnly = chkMovieExtrafanartsPrefSizeOnly.Checked
            .ExtrafanartsPreselect = chkMovieExtrafanartsPreselect.Checked
            .ExtrafanartsMaxWidth = If(Not String.IsNullOrEmpty(txtMovieExtrafanartsWidth.Text), Convert.ToInt32(txtMovieExtrafanartsWidth.Text), 0)
            .ExtrathumbsCreatorAuto = chkMovieExtrathumbsCreatorAutoThumbs.Checked
            .ExtrathumbsCreatorNoBlackBars = chkMovieExtrathumbsCreatorNoBlackBars.Checked
            .ExtrathumbsCreatorNoSpoilers = chkMovieExtrathumbsCreatorNoSpoilers.Checked
            .ExtrathumbsCreatorUseETasFA = chkMovieExtrathumbsCreatorUseETasFA.Checked
            .ExtrathumbsMaxHeight = If(Not String.IsNullOrEmpty(txtMovieExtrathumbsHeight.Text), Convert.ToInt32(txtMovieExtrathumbsHeight.Text), 0)
            .ExtrathumbsLimit = If(Not String.IsNullOrEmpty(txtMovieExtrathumbsLimit.Text), Convert.ToInt32(txtMovieExtrathumbsLimit.Text), 0)
            .ExtrathumbsKeepExisting = chkMovieExtrathumbsKeepExisting.Checked
            .ExtrathumbsPrefSize = CType(cbMovieExtrathumbsPrefSize.SelectedItem, KeyValuePair(Of String, Enums.ImageSize)).Value
            .ExtrathumbsPrefSizeOnly = chkMovieExtrathumbsPrefSizeOnly.Checked
            .ExtrathumbsPreselect = chkMovieExtrathumbsPreselect.Checked
            .ExtrathumbsMaxWidth = If(Not String.IsNullOrEmpty(txtMovieExtrathumbsWidth.Text), Convert.ToInt32(txtMovieExtrathumbsWidth.Text), 0)
            .FanartMaxHeight = If(Not String.IsNullOrEmpty(txtMovieFanartHeight.Text), Convert.ToInt32(txtMovieFanartHeight.Text), 0)
            .FanartKeepExisting = chkMovieFanartKeepExisting.Checked
            .FanartPrefSize = CType(cbMovieFanartPrefSize.SelectedItem, KeyValuePair(Of String, Enums.ImageSize)).Value
            .FanartPrefSizeOnly = chkMovieFanartPrefSizeOnly.Checked
            .FanartMaxWidth = If(Not String.IsNullOrEmpty(txtMovieFanartWidth.Text), Convert.ToInt32(txtMovieFanartWidth.Text), 0)
            .ImagesCacheEnabled = chkMovieImagesCacheEnabled.Checked
            .ImagesDisplayImageSelect = chkMovieImagesDisplayImageSelect.Checked
            If Not String.IsNullOrEmpty(cbMovieImagesForcedLanguage.Text) Then
                .ImagesForcedLanguage = APIXML.ScraperLanguagesXML.Languages.FirstOrDefault(Function(l) l.Name = cbMovieImagesForcedLanguage.Text).Abbrevation_MainLanguage
            End If
            .ImagesForceLanguage = chkMovieImagesForceLanguage.Checked
            .ImagesGetBlankImages = chkMovieImagesGetBlankImages.Checked
            .ImagesGetEnglishImages = chkMovieImagesGetEnglishImages.Checked
            .ImagesMediaLanguageOnly = chkMovieImagesMediaLanguageOnly.Checked
            .ImagesNotSaveURLToNfo = chkMovieImagesNotSaveURLToNfo.Checked
            .LandscapeKeepExisting = chkMovieLandscapeKeepExisting.Checked
            .LandscapePrefSize = CType(cbMovieLandscapePrefSize.SelectedItem, KeyValuePair(Of String, Enums.ImageSize)).Value
            .LandscapePrefSizeOnly = chkMovieLandscapePrefSizeOnly.Checked
            .PosterMaxHeight = If(Not String.IsNullOrEmpty(txtMoviePosterHeight.Text), Convert.ToInt32(txtMoviePosterHeight.Text), 0)
            .PosterKeepExisting = chkMoviePosterKeepExisting.Checked
            .PosterPrefSize = CType(cbMoviePosterPrefSize.SelectedItem, KeyValuePair(Of String, Enums.ImageSize)).Value
            .PosterPrefSizeOnly = chkMoviePosterPrefSizeOnly.Checked
            .PosterMaxWidth = If(Not String.IsNullOrEmpty(txtMoviePosterWidth.Text), Convert.ToInt32(txtMoviePosterWidth.Text), 0)
        End With
    End Sub

#End Region 'Interface Methods

#Region "Methods"

    Private Sub LoadMovieBannerSizes()
        Dim items As New Dictionary(Of String, Enums.ImageSize)
        items.Add(Master.eLang.GetString(745, "Any"), Enums.ImageSize.Any)
        items.Add("1000x185", Enums.ImageSize.HD185)
        cbMovieBannerPrefSize.DataSource = items.ToList
        cbMovieBannerPrefSize.DisplayMember = "Key"
        cbMovieBannerPrefSize.ValueMember = "Value"
    End Sub

    Private Sub LoadMovieClearArtSizes()
        Dim items As New Dictionary(Of String, Enums.ImageSize)
        items.Add(Master.eLang.GetString(745, "Any"), Enums.ImageSize.Any)
        items.Add("1000x562", Enums.ImageSize.HD562)
        items.Add("500x281", Enums.ImageSize.SD281)
        cbMovieClearArtPrefSize.DataSource = items.ToList
        cbMovieClearArtPrefSize.DisplayMember = "Key"
        cbMovieClearArtPrefSize.ValueMember = "Value"
    End Sub

    Private Sub LoadMovieClearLogoSizes()
        Dim items As New Dictionary(Of String, Enums.ImageSize)
        items.Add(Master.eLang.GetString(745, "Any"), Enums.ImageSize.Any)
        items.Add("800x310", Enums.ImageSize.HD310)
        items.Add("400x155", Enums.ImageSize.SD155)
        cbMovieClearLogoPrefSize.DataSource = items.ToList
        cbMovieClearLogoPrefSize.DisplayMember = "Key"
        cbMovieClearLogoPrefSize.ValueMember = "Value"
    End Sub

    Private Sub LoadMovieDiscArtSizes()
        Dim items As New Dictionary(Of String, Enums.ImageSize)
        items.Add(Master.eLang.GetString(745, "Any"), Enums.ImageSize.Any)
        items.Add("1000x1000", Enums.ImageSize.HD1000)
        cbMovieDiscArtPrefSize.DataSource = items.ToList
        cbMovieDiscArtPrefSize.DisplayMember = "Key"
        cbMovieDiscArtPrefSize.ValueMember = "Value"
    End Sub

    Private Sub LoadMovieFanartSizes()
        Dim items As New Dictionary(Of String, Enums.ImageSize)
        items.Add(Master.eLang.GetString(745, "Any"), Enums.ImageSize.Any)
        items.Add("3840x2160", Enums.ImageSize.UHD2160)
        items.Add("2560x1440", Enums.ImageSize.QHD1440)
        items.Add("1920x1080", Enums.ImageSize.HD1080)
        items.Add("1280x720", Enums.ImageSize.HD720)
        items.Add("Thumb", Enums.ImageSize.Thumb)
        cbMovieExtrafanartsPrefSize.DataSource = items.ToList
        cbMovieExtrafanartsPrefSize.DisplayMember = "Key"
        cbMovieExtrafanartsPrefSize.ValueMember = "Value"
        cbMovieExtrathumbsPrefSize.DataSource = items.ToList
        cbMovieExtrathumbsPrefSize.DisplayMember = "Key"
        cbMovieExtrathumbsPrefSize.ValueMember = "Value"
        cbMovieFanartPrefSize.DataSource = items.ToList
        cbMovieFanartPrefSize.DisplayMember = "Key"
        cbMovieFanartPrefSize.ValueMember = "Value"
    End Sub

    Private Sub LoadMovieLandscapeSizes()
        Dim items As New Dictionary(Of String, Enums.ImageSize)
        items.Add(Master.eLang.GetString(745, "Any"), Enums.ImageSize.Any)
        items.Add("1000x562", Enums.ImageSize.HD562)
        cbMovieLandscapePrefSize.DataSource = items.ToList
        cbMovieLandscapePrefSize.DisplayMember = "Key"
        cbMovieLandscapePrefSize.ValueMember = "Value"
    End Sub

    Private Sub LoadMoviePosterSizes()
        Dim items As New Dictionary(Of String, Enums.ImageSize)
        items.Add(Master.eLang.GetString(745, "Any"), Enums.ImageSize.Any)
        items.Add("2000x3000", Enums.ImageSize.UHD3000)
        items.Add("1400x2100", Enums.ImageSize.UHD2100)
        items.Add("1000x1500", Enums.ImageSize.HD1500)
        items.Add("1000x1426", Enums.ImageSize.HD1426)
        cbMoviePosterPrefSize.DataSource = items.ToList
        cbMoviePosterPrefSize.DisplayMember = "Key"
        cbMoviePosterPrefSize.ValueMember = "Value"
    End Sub

    Private Sub SetUp()
        LoadMovieBannerSizes()
        LoadMovieClearArtSizes()
        LoadMovieClearLogoSizes()
        LoadMovieDiscArtSizes()
        LoadMovieFanartSizes()
        LoadMovieLandscapeSizes()
        LoadMoviePosterSizes()

        'Preselect in "Image Select" dialog
        Dim strPreselectInImageSelectDialog As String = Master.eLang.GetString(1023, "Preselect in ""Image Select"" dialog")
        chkMovieExtrafanartsPreselect.Text = strPreselectInImageSelectDialog
        chkMovieExtrathumbsPreselect.Text = strPreselectInImageSelectDialog

        lblKeepExisting.Text = Master.eLang.GetString(971, "Keep existing")
        lblLimit.Text = Master.eLang.GetString(578, "Limit")
        lblHeight.Text = Master.eLang.GetString(480, "Max Height")
        lblWidth.Text = Master.eLang.GetString(479, "Max Width")
        lblOnly.Text = Master.eLang.GetString(145, "Only")
        lblPreferredSize.Text = Master.eLang.GetString(482, "Preferred Size")
        lblBanner.Text = Master.eLang.GetString(838, "Banner")
        lblClearArt.Text = Master.eLang.GetString(1096, "ClearArt")
        lblClearLogo.Text = Master.eLang.GetString(1097, "ClearLogo")
        lblDiscArt.Text = Master.eLang.GetString(1098, "DiscArt")
        chkMovieImagesDisplayImageSelect.Text = Master.eLang.GetString(499, "Display ""Image Select"" dialog while single scraping")
        lblActorThumbs.Text = Master.eLang.GetString(991, "Actor Thumbs")
        chkMovieImagesGetBlankImages.Text = Master.eLang.GetString(1207, "Also Get Blank Images")
        chkMovieImagesGetEnglishImages.Text = Master.eLang.GetString(737, "Also Get English Images")
        chkMovieImagesNotSaveURLToNfo.Text = Master.eLang.GetString(498, "Do not save URLs to NFO")
        chkMovieImagesCacheEnabled.Text = Master.eLang.GetString(249, "Enable Image Caching")
        lblExtrafanarts.Text = Master.eLang.GetString(992, "Extrafanarts")
        lblExtrathumbs.Text = Master.eLang.GetString(153, "Extrathumbs")
        lblFanart.Text = Master.eLang.GetString(149, "Fanart")
        chkMovieImagesForceLanguage.Text = Master.eLang.GetString(1034, "Force Language")
        gbMovieImagesOpts.Text = Master.eLang.GetString(497, "Images")
        lblLandscape.Text = Master.eLang.GetString(1059, "Landscape")
        chkMovieImagesMediaLanguageOnly.Text = Master.eLang.GetString(736, "Only Get Images for the Media Language")
        lblPoster.Text = Master.eLang.GetString(148, "Poster")
        gbMovieImagesLanguageOpts.Text = Master.eLang.GetString(741, "Preferred Language")
        chkMovieExtrathumbsCreatorAutoThumbs.Text = Master.eLang.GetString(1475, "Create thumbs instead of using fanarts")
        chkMovieExtrathumbsCreatorNoBlackBars.Text = Master.eLang.GetString(1474, "Remove Black Bars")
        chkMovieExtrathumbsCreatorNoSpoilers.Text = Master.eLang.GetString(1473, "No Spoilers")
        chkMovieExtrathumbsCreatorUseETasFA.Text = Master.eLang.GetString(1476, "Only create thumbs if no fanart found")
        lblFanart.Text = Master.eLang.GetString(149, "Fanart")
        gbMovieImagesExtrathumbsCreatorOpts.Text = Master.eLang.GetString(1477, "Create Thumbnails")

        clsAPITemp.ConvertToScraperGridView(dgvBanner, Master.ScraperList.FindAll(Function(f) f.ScraperCapatibilities.Contains(Enums.ScraperCapatibility.Movie_Image_Banner)))
        clsAPITemp.ConvertToScraperGridView(dgvClearArt, Master.ScraperList.FindAll(Function(f) f.ScraperCapatibilities.Contains(Enums.ScraperCapatibility.Movie_Image_ClearArt)))
        clsAPITemp.ConvertToScraperGridView(dgvClearLogo, Master.ScraperList.FindAll(Function(f) f.ScraperCapatibilities.Contains(Enums.ScraperCapatibility.Movie_Image_ClearLogo)))
        clsAPITemp.ConvertToScraperGridView(dgvDiscArt, Master.ScraperList.FindAll(Function(f) f.ScraperCapatibilities.Contains(Enums.ScraperCapatibility.Movie_Image_DiscArt)))
        clsAPITemp.ConvertToScraperGridView(dgvExtrafanarts, Master.ScraperList.FindAll(Function(f) f.ScraperCapatibilities.Contains(Enums.ScraperCapatibility.Movie_Image_Fanart)))
        clsAPITemp.ConvertToScraperGridView(dgvExtrathumbs, Master.ScraperList.FindAll(Function(f) f.ScraperCapatibilities.Contains(Enums.ScraperCapatibility.Movie_Image_Fanart)))
        clsAPITemp.ConvertToScraperGridView(dgvFanart, Master.ScraperList.FindAll(Function(f) f.ScraperCapatibilities.Contains(Enums.ScraperCapatibility.Movie_Image_Fanart)))
        clsAPITemp.ConvertToScraperGridView(dgvLandscape, Master.ScraperList.FindAll(Function(f) f.ScraperCapatibilities.Contains(Enums.ScraperCapatibility.Movie_Image_Landscape)))
        clsAPITemp.ConvertToScraperGridView(dgvPoster, Master.ScraperList.FindAll(Function(f) f.ScraperCapatibilities.Contains(Enums.ScraperCapatibility.Movie_Image_Poster)))
    End Sub

    Private Sub EnableApplyButton() Handles _
        cbMovieBannerPrefSize.SelectedIndexChanged,
        cbMovieClearArtPrefSize.SelectedIndexChanged,
        cbMovieClearLogoPrefSize.SelectedIndexChanged,
        cbMovieDiscArtPrefSize.SelectedIndexChanged,
        cbMovieExtrafanartsPrefSize.SelectedIndexChanged,
        cbMovieExtrathumbsPrefSize.SelectedIndexChanged,
        cbMovieFanartPrefSize.SelectedIndexChanged,
        cbMovieImagesForcedLanguage.SelectedIndexChanged,
        cbMovieLandscapePrefSize.SelectedIndexChanged,
        cbMoviePosterPrefSize.SelectedIndexChanged,
        chkMovieActorThumbsKeepExisting.CheckedChanged,
        chkMovieBannerKeepExisting.CheckedChanged,
        chkMovieBannerPrefSizeOnly.CheckedChanged,
        chkMovieClearArtKeepExisting.CheckedChanged,
        chkMovieClearArtPrefSizeOnly.CheckedChanged,
        chkMovieClearLogoKeepExisting.CheckedChanged,
        chkMovieClearLogoPrefSizeOnly.CheckedChanged,
        chkMovieDiscArtKeepExisting.CheckedChanged,
        chkMovieDiscArtPrefSizeOnly.CheckedChanged,
        chkMovieExtrafanartsKeepExisting.CheckedChanged,
        chkMovieExtrafanartsPrefSizeOnly.CheckedChanged,
        chkMovieExtrafanartsPreselect.CheckedChanged,
        chkMovieExtrathumbsCreatorNoBlackBars.CheckedChanged,
        chkMovieExtrathumbsCreatorNoSpoilers.CheckedChanged,
        chkMovieExtrathumbsKeepExisting.CheckedChanged,
        chkMovieExtrathumbsPrefSizeOnly.CheckedChanged,
        chkMovieExtrathumbsPreselect.CheckedChanged,
        chkMovieFanartKeepExisting.CheckedChanged,
        chkMovieFanartPrefSizeOnly.CheckedChanged,
        chkMovieImagesCacheEnabled.CheckedChanged,
        chkMovieImagesDisplayImageSelect.CheckedChanged,
        chkMovieImagesGetBlankImages.CheckedChanged,
        chkMovieImagesGetEnglishImages.CheckedChanged,
        chkMovieImagesNotSaveURLToNfo.CheckedChanged,
        chkMovieLandscapeKeepExisting.CheckedChanged,
        chkMovieLandscapePrefSizeOnly.CheckedChanged,
        chkMoviePosterKeepExisting.CheckedChanged,
        chkMoviePosterPrefSizeOnly.CheckedChanged,
        txtMovieBannerHeight.TextChanged,
        txtMovieBannerWidth.TextChanged,
        txtMovieExtrafanartsHeight.TextChanged,
        txtMovieExtrafanartsLimit.TextChanged,
        txtMovieExtrafanartsWidth.TextChanged,
        txtMovieExtrathumbsHeight.TextChanged,
        txtMovieExtrathumbsLimit.TextChanged,
        txtMovieExtrathumbsWidth.TextChanged,
        txtMovieFanartHeight.TextChanged,
        txtMovieFanartWidth.TextChanged,
        txtMoviePosterHeight.TextChanged,
        txtMoviePosterWidth.TextChanged

        Handle_SettingsChanged()
    End Sub

    Private Sub txtMovieBannerWidth_KeyPress(sender As Object, e As Windows.Forms.KeyPressEventArgs) Handles txtMovieBannerWidth.KeyPress
        e.Handled = StringUtils.NumericOnly(e.KeyChar)
    End Sub

    Private Sub txtMovieBannerHeight_KeyPress(sender As Object, e As Windows.Forms.KeyPressEventArgs) Handles txtMovieBannerHeight.KeyPress
        e.Handled = StringUtils.NumericOnly(e.KeyChar)
    End Sub

    Private Sub chkMovieExtrathumbsCreatorAutoThumbs_CheckedChanged(sender As Object, e As EventArgs) Handles chkMovieExtrathumbsCreatorAutoThumbs.CheckedChanged
        EnableApplyButton()

        If chkMovieExtrathumbsCreatorAutoThumbs.Checked = True Then
            chkMovieExtrathumbsCreatorUseETasFA.Checked = False
        End If
    End Sub

    Private Sub chkMovieExtrathumbsCreatorUseETasFA_CheckedChanged(sender As Object, e As EventArgs) Handles chkMovieExtrathumbsCreatorUseETasFA.CheckedChanged
        EnableApplyButton()

        If chkMovieExtrathumbsCreatorUseETasFA.Checked = True Then
            chkMovieExtrathumbsCreatorAutoThumbs.Checked = False
        End If
    End Sub

    Private Sub txtMovieExtrathumbsHeight_KeyPress(sender As Object, e As Windows.Forms.KeyPressEventArgs) Handles txtMovieExtrathumbsHeight.KeyPress
        e.Handled = StringUtils.NumericOnly(e.KeyChar)
    End Sub

    Private Sub txtMovieExtrathumbsWidth_KeyPress(sender As Object, e As Windows.Forms.KeyPressEventArgs) Handles txtMovieExtrathumbsWidth.KeyPress
        e.Handled = StringUtils.NumericOnly(e.KeyChar)
    End Sub

    Private Sub txtMovieExtrathumbsLimit_KeyPress(sender As Object, e As Windows.Forms.KeyPressEventArgs) Handles txtMovieExtrathumbsLimit.KeyPress
        e.Handled = StringUtils.NumericOnly(e.KeyChar)
    End Sub

    Private Sub txtMovieExtrafanartsHeight_KeyPress(sender As Object, e As Windows.Forms.KeyPressEventArgs) Handles txtMovieExtrafanartsHeight.KeyPress
        e.Handled = StringUtils.NumericOnly(e.KeyChar)
    End Sub

    Private Sub txtMovieExtrafanartsWidth_KeyPress(sender As Object, e As Windows.Forms.KeyPressEventArgs) Handles txtMovieExtrafanartsWidth.KeyPress
        e.Handled = StringUtils.NumericOnly(e.KeyChar)
    End Sub

    Private Sub txtMovieExtrafanartsLimit_KeyPress(sender As Object, e As Windows.Forms.KeyPressEventArgs) Handles txtMovieExtrafanartsLimit.KeyPress
        e.Handled = StringUtils.NumericOnly(e.KeyChar)
    End Sub

    Private Sub chkMovieImagesMediaLanguageOnly_CheckedChanged(sender As Object, e As EventArgs) Handles chkMovieImagesMediaLanguageOnly.CheckedChanged
        EnableApplyButton()

        chkMovieImagesGetBlankImages.Enabled = chkMovieImagesMediaLanguageOnly.Checked
        chkMovieImagesGetEnglishImages.Enabled = chkMovieImagesMediaLanguageOnly.Checked

        If Not chkMovieImagesMediaLanguageOnly.Checked Then
            chkMovieImagesGetBlankImages.Checked = False
            chkMovieImagesGetEnglishImages.Checked = False
        End If
    End Sub

    Private Sub chkMovieImagesForceLanguage_CheckedChanged(sender As Object, e As EventArgs) Handles chkMovieImagesForceLanguage.CheckedChanged
        EnableApplyButton()

        cbMovieImagesForcedLanguage.Enabled = chkMovieImagesForceLanguage.Checked
    End Sub

    Private Sub txtMoviePosterWidth_KeyPress(sender As Object, e As Windows.Forms.KeyPressEventArgs) Handles txtMoviePosterWidth.KeyPress
        e.Handled = StringUtils.NumericOnly(e.KeyChar)
    End Sub

    Private Sub txtMoviePosterHeight_KeyPress(sender As Object, e As Windows.Forms.KeyPressEventArgs) Handles txtMoviePosterHeight.KeyPress
        e.Handled = StringUtils.NumericOnly(e.KeyChar)
    End Sub

    Private Sub txtMovieFanartWidth_KeyPress(sender As Object, e As Windows.Forms.KeyPressEventArgs) Handles txtMovieFanartWidth.KeyPress
        e.Handled = StringUtils.NumericOnly(e.KeyChar)
    End Sub

    Private Sub txtMovieFanartHeight_KeyPress(sender As Object, e As Windows.Forms.KeyPressEventArgs) Handles txtMovieFanartHeight.KeyPress
        e.Handled = StringUtils.NumericOnly(e.KeyChar)
    End Sub
    ''' <summary>
    ''' Workaround to autosize the DGV based on column widths without change the row hights
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub pnlSettings_VisibleChanged(sender As Object, e As EventArgs) Handles pnlSettings.VisibleChanged
        If Not _bDGVWidthCalculated AndAlso CType(sender, Panel).Visible Then
            TableLayoutPanel1.SuspendLayout()
            For i As Integer = 0 To TableLayoutPanel1.Controls.Count - 1
                Dim nType As Type = TableLayoutPanel1.Controls(i).GetType
                If nType.Name = "DataGridView" Then
                    Dim nDataGridView As DataGridView = CType(TableLayoutPanel1.Controls(i), DataGridView)
                    Dim intWidth As Integer = 0
                    For Each nColumn As DataGridViewColumn In nDataGridView.Columns
                        intWidth += nColumn.Width
                    Next
                    nDataGridView.Width = intWidth + 1
                End If
            Next
            TableLayoutPanel1.ResumeLayout()
            _bDGVWidthCalculated = True
        End If
    End Sub

#End Region 'Methods

End Class