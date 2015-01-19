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

Imports System.IO
Imports EmberAPI
Imports RestSharp
Imports ScraperModule.FanartTVs
Imports NLog
Imports System.Diagnostics

Public Class FanartTV_Image
    Implements Interfaces.ScraperModule_Image_Movie
    Implements Interfaces.ScraperModule_Image_MovieSet
    Implements Interfaces.ScraperModule_Image_TV


#Region "Fields"
    Shared logger As Logger = NLog.LogManager.GetCurrentClassLogger()
    Public Shared ConfigScrapeModifier_Movie As New Structures.ScrapeModifier
    Public Shared ConfigScrapeModifier_MovieSet As New Structures.ScrapeModifier
    Public Shared ConfigScrapeModifier_TV As New Structures.ScrapeModifier
    Public Shared _AssemblyName As String

    ''' <summary>
    ''' Scraping Here
    ''' </summary>
    ''' <remarks></remarks>
    Private _MySettings_Movie As New sMySettings
    Private _MySettings_MovieSet As New sMySettings
    Private _MySettings_TV As New sMySettings
    Private _Name As String = "FanartTV_Poster"
    Private _ScraperEnabled_Movie As Boolean = False
    Private _ScraperEnabled_MovieSet As Boolean = False
    Private _ScraperEnabled_TV As Boolean = False
    Private _setup_Movie As frmFanartTVMediaSettingsHolder_Movie
    Private _setup_MovieSet As frmFanartTVMediaSettingsHolder_MovieSet
    Private _setup_TV As frmFanartTVMediaSettingsHolder_TV
    Private _scraper As New Scraper

#End Region 'Fields

#Region "Events"

    Public Event ModuleSettingsChanged_Movie() Implements Interfaces.ScraperModule_Image_Movie.ModuleSettingsChanged

    Public Event MovieScraperEvent_Movie(ByVal eType As Enums.ScraperEventType_Movie, ByVal Parameter As Object) Implements Interfaces.ScraperModule_Image_Movie.ScraperEvent

    Public Event SetupScraperChanged_Movie(ByVal name As String, ByVal State As Boolean, ByVal difforder As Integer) Implements Interfaces.ScraperModule_Image_Movie.ScraperSetupChanged

    Public Event SetupNeedsRestart_Movie() Implements Interfaces.ScraperModule_Image_Movie.SetupNeedsRestart

    Public Event ImagesDownloaded_Movie(ByVal Posters As List(Of MediaContainers.Image)) Implements Interfaces.ScraperModule_Image_Movie.ImagesDownloaded

    Public Event ProgressUpdated_Movie(ByVal iPercent As Integer) Implements Interfaces.ScraperModule_Image_Movie.ProgressUpdated


    Public Event ModuleSettingsChanged_MovieSet() Implements Interfaces.ScraperModule_Image_MovieSet.ModuleSettingsChanged

    Public Event MovieScraperEvent_MovieSet(ByVal eType As Enums.ScraperEventType_MovieSet, ByVal Parameter As Object) Implements Interfaces.ScraperModule_Image_MovieSet.ScraperEvent

    Public Event SetupScraperChanged_MovieSet(ByVal name As String, ByVal State As Boolean, ByVal difforder As Integer) Implements Interfaces.ScraperModule_Image_MovieSet.ScraperSetupChanged

    Public Event SetupNeedsRestart_MovieSet() Implements Interfaces.ScraperModule_Image_MovieSet.SetupNeedsRestart

    Public Event ImagesDownloaded_MovieSet(ByVal Posters As List(Of MediaContainers.Image)) Implements Interfaces.ScraperModule_Image_MovieSet.ImagesDownloaded

    Public Event ProgressUpdated_MovieSet(ByVal iPercent As Integer) Implements Interfaces.ScraperModule_Image_MovieSet.ProgressUpdated


    Public Event ModuleSettingsChanged_TV() Implements Interfaces.ScraperModule_Image_TV.ModuleSettingsChanged

    Public Event MovieScraperEvent_TV(ByVal eType As Enums.ScraperEventType_TV, ByVal Parameter As Object) Implements Interfaces.ScraperModule_Image_TV.ScraperEvent

    Public Event SetupScraperChanged_TV(ByVal name As String, ByVal State As Boolean, ByVal difforder As Integer) Implements Interfaces.ScraperModule_Image_TV.ScraperSetupChanged

    Public Event SetupNeedsRestart_TV() Implements Interfaces.ScraperModule_Image_TV.SetupNeedsRestart

    Public Event ImagesDownloaded_TV(ByVal Posters As List(Of MediaContainers.Image)) Implements Interfaces.ScraperModule_Image_TV.ImagesDownloaded

    Public Event ProgressUpdated_TV(ByVal iPercent As Integer) Implements Interfaces.ScraperModule_Image_TV.ProgressUpdated

#End Region 'Events

#Region "Properties"

    ReadOnly Property ModuleName() As String Implements Interfaces.ScraperModule_Image_Movie.ModuleName, Interfaces.ScraperModule_Image_MovieSet.ModuleName, Interfaces.ScraperModule_Image_TV.ModuleName
        Get
            Return _Name
        End Get
    End Property

    ReadOnly Property ModuleVersion() As String Implements Interfaces.ScraperModule_Image_Movie.ModuleVersion, Interfaces.ScraperModule_Image_MovieSet.ModuleVersion, Interfaces.ScraperModule_Image_TV.ModuleVersion
        Get
            Return System.Diagnostics.FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetExecutingAssembly.Location).FileVersion.ToString
        End Get
    End Property

    Property ScraperEnabled_Movie() As Boolean Implements Interfaces.ScraperModule_Image_Movie.ScraperEnabled
        Get
            Return _ScraperEnabled_Movie
        End Get
        Set(ByVal value As Boolean)
            _ScraperEnabled_Movie = value
        End Set
    End Property

    Property ScraperEnabled_MovieSet() As Boolean Implements Interfaces.ScraperModule_Image_MovieSet.ScraperEnabled
        Get
            Return _ScraperEnabled_MovieSet
        End Get
        Set(ByVal value As Boolean)
            _ScraperEnabled_MovieSet = value
        End Set
    End Property

    Property ScraperEnabled_TV() As Boolean Implements Interfaces.ScraperModule_Image_TV.ScraperEnabled
        Get
            Return _ScraperEnabled_TV
        End Get
        Set(ByVal value As Boolean)
            _ScraperEnabled_TV = value
        End Set
    End Property

#End Region 'Properties

#Region "Methods"

    Function QueryScraperCapabilities_Movie(ByVal cap As Enums.ScraperCapabilities) As Boolean Implements Interfaces.ScraperModule_Image_Movie.QueryScraperCapabilities
        Select Case cap
            Case Enums.ScraperCapabilities.Banner
                Return ConfigScrapeModifier_Movie.Banner
            Case Enums.ScraperCapabilities.ClearArt
                Return ConfigScrapeModifier_Movie.ClearArt
            Case Enums.ScraperCapabilities.ClearLogo
                Return ConfigScrapeModifier_Movie.ClearLogo
            Case Enums.ScraperCapabilities.DiscArt
                Return ConfigScrapeModifier_Movie.DiscArt
            Case Enums.ScraperCapabilities.Fanart
                Return ConfigScrapeModifier_Movie.Fanart
            Case Enums.ScraperCapabilities.Landscape
                Return ConfigScrapeModifier_Movie.Landscape
            Case Enums.ScraperCapabilities.Poster
                Return ConfigScrapeModifier_Movie.Poster
        End Select
        Return False
    End Function
    Function QueryScraperCapabilities_MovieSet(ByVal cap As Enums.ScraperCapabilities) As Boolean Implements Interfaces.ScraperModule_Image_MovieSet.QueryScraperCapabilities
        Select Case cap
            Case Enums.ScraperCapabilities.Banner
                Return ConfigScrapeModifier_MovieSet.Banner
            Case Enums.ScraperCapabilities.ClearArt
                Return ConfigScrapeModifier_MovieSet.ClearArt
            Case Enums.ScraperCapabilities.ClearLogo
                Return ConfigScrapeModifier_MovieSet.ClearLogo
            Case Enums.ScraperCapabilities.DiscArt
                Return ConfigScrapeModifier_MovieSet.DiscArt
            Case Enums.ScraperCapabilities.Fanart
                Return ConfigScrapeModifier_MovieSet.Fanart
            Case Enums.ScraperCapabilities.Landscape
                Return ConfigScrapeModifier_MovieSet.Landscape
            Case Enums.ScraperCapabilities.Poster
                Return ConfigScrapeModifier_MovieSet.Poster
        End Select
        Return False
    End Function

    Function QueryScraperCapabilities_TV(ByVal cap As Enums.ScraperCapabilities) As Boolean Implements Interfaces.ScraperModule_Image_TV.QueryScraperCapabilities
        Select Case cap
            Case Enums.ScraperCapabilities.Banner
                Return ConfigScrapeModifier_TV.Banner
            Case Enums.ScraperCapabilities.CharacterArt
                Return ConfigScrapeModifier_TV.CharacterArt
            Case Enums.ScraperCapabilities.ClearArt
                Return ConfigScrapeModifier_TV.ClearArt
            Case Enums.ScraperCapabilities.ClearLogo
                Return ConfigScrapeModifier_TV.ClearLogo
            Case Enums.ScraperCapabilities.Fanart
                Return ConfigScrapeModifier_TV.Fanart
            Case Enums.ScraperCapabilities.Landscape
                Return ConfigScrapeModifier_TV.Landscape
            Case Enums.ScraperCapabilities.Poster
                Return ConfigScrapeModifier_TV.Poster
        End Select
        Return False
    End Function

    Private Sub Handle_ModuleSettingsChanged_Movie()
        RaiseEvent ModuleSettingsChanged_Movie()
    End Sub

    Private Sub Handle_ModuleSettingsChanged_MovieSet()
        RaiseEvent ModuleSettingsChanged_MovieSet()
    End Sub

    Private Sub Handle_ModuleSettingsChanged_TV()
        RaiseEvent ModuleSettingsChanged_TV()
    End Sub

    Private Sub Handle_SetupNeedsRestart_Movie()
        RaiseEvent SetupNeedsRestart_Movie()
    End Sub

    Private Sub Handle_SetupNeedsRestart_MovieSet()
        RaiseEvent SetupNeedsRestart_MovieSet()
    End Sub

    Private Sub Handle_SetupNeedsRestart_TV()
        RaiseEvent SetupNeedsRestart_TV()
    End Sub

    Private Sub Handle_SetupScraperChanged_Movie(ByVal state As Boolean, ByVal difforder As Integer)
        ScraperEnabled_Movie = state
        RaiseEvent SetupScraperChanged_Movie(String.Concat(Me._Name, "_Movie"), state, difforder)
    End Sub

    Private Sub Handle_SetupScraperChanged_MovieSet(ByVal state As Boolean, ByVal difforder As Integer)
        ScraperEnabled_MovieSet = state
        RaiseEvent SetupScraperChanged_MovieSet(String.Concat(Me._Name, "_MovieSet"), state, difforder)
    End Sub

    Private Sub Handle_SetupScraperChanged_TV(ByVal state As Boolean, ByVal difforder As Integer)
        ScraperEnabled_TV = state
        RaiseEvent SetupScraperChanged_TV(String.Concat(Me._Name, "_TV"), state, difforder)
    End Sub

    Sub Init_Movie(ByVal sAssemblyName As String) Implements Interfaces.ScraperModule_Image_Movie.Init
        _AssemblyName = sAssemblyName
        LoadSettings_Movie()
    End Sub

    Sub Init_MovieSet(ByVal sAssemblyName As String) Implements Interfaces.ScraperModule_Image_MovieSet.Init
        _AssemblyName = sAssemblyName
        LoadSettings_MovieSet()
    End Sub

    Sub Init_TV(ByVal sAssemblyName As String) Implements Interfaces.ScraperModule_Image_TV.Init
        _AssemblyName = sAssemblyName
        LoadSettings_TV()
    End Sub

    Function InjectSetupScraper_Movie() As Containers.SettingsPanel Implements Interfaces.ScraperModule_Image_Movie.InjectSetupScraper
        Dim Spanel As New Containers.SettingsPanel
        _setup_Movie = New frmFanartTVMediaSettingsHolder_Movie
        LoadSettings_Movie()
        _setup_Movie.chkEnabled.Checked = _ScraperEnabled_Movie
        _setup_Movie.chkGetBlankImages.Checked = _MySettings_Movie.GetBlankImages
        _setup_Movie.chkGetEnglishImages.Checked = _MySettings_Movie.GetEnglishImages
        _setup_Movie.chkPrefLanguageOnly.Checked = _MySettings_Movie.PrefLanguageOnly
        _setup_Movie.chkScrapePoster.Checked = ConfigScrapeModifier_Movie.Poster
        _setup_Movie.chkScrapeFanart.Checked = ConfigScrapeModifier_Movie.Fanart
        _setup_Movie.chkScrapeBanner.Checked = ConfigScrapeModifier_Movie.Banner
        _setup_Movie.chkScrapeClearArt.Checked = ConfigScrapeModifier_Movie.ClearArt
        _setup_Movie.chkScrapeClearArtOnlyHD.Checked = _MySettings_Movie.ClearArtOnlyHD
        _setup_Movie.chkScrapeClearLogo.Checked = ConfigScrapeModifier_Movie.ClearLogo
        _setup_Movie.chkScrapeClearLogoOnlyHD.Checked = _MySettings_Movie.ClearLogoOnlyHD
        _setup_Movie.chkScrapeDiscArt.Checked = ConfigScrapeModifier_Movie.DiscArt
        _setup_Movie.chkScrapeLandscape.Checked = ConfigScrapeModifier_Movie.Landscape
        _setup_Movie.txtApiKey.Text = _MySettings_Movie.ApiKey
        _setup_Movie.cbPrefLanguage.Text = _MySettings_Movie.PrefLanguage

        If Not String.IsNullOrEmpty(_MySettings_Movie.ApiKey) Then
            _setup_Movie.btnUnlockAPI.Text = Master.eLang.GetString(443, "Use embedded API Key")
            _setup_Movie.lblEMMAPI.Visible = False
            _setup_Movie.txtApiKey.Enabled = True
        End If

        _setup_Movie.orderChanged()

        Spanel.Name = String.Concat(Me._Name, "_Movie")
        Spanel.Text = Master.eLang.GetString(788, "FanartTV")
        Spanel.Prefix = "FanartTVMovieMedia_"
        Spanel.Order = 110
        Spanel.Parent = "pnlMovieMedia"
        Spanel.Type = Master.eLang.GetString(36, "Movies")
        Spanel.ImageIndex = If(Me._ScraperEnabled_Movie, 9, 10)
        Spanel.Panel = Me._setup_Movie.pnlSettings

        AddHandler _setup_Movie.SetupScraperChanged, AddressOf Handle_SetupScraperChanged_Movie
        AddHandler _setup_Movie.ModuleSettingsChanged, AddressOf Handle_ModuleSettingsChanged_Movie
        AddHandler _setup_Movie.SetupNeedsRestart, AddressOf Handle_SetupNeedsRestart_Movie
        Return Spanel
    End Function

    Function InjectSetupScraper_MovieSet() As Containers.SettingsPanel Implements Interfaces.ScraperModule_Image_MovieSet.InjectSetupScraper
        Dim Spanel As New Containers.SettingsPanel
        _setup_MovieSet = New frmFanartTVMediaSettingsHolder_MovieSet
        LoadSettings_MovieSet()
        _setup_MovieSet.chkEnabled.Checked = _ScraperEnabled_MovieSet
        _setup_MovieSet.chkGetBlankImages.Checked = _MySettings_MovieSet.GetBlankImages
        _setup_MovieSet.chkGetEnglishImages.Checked = _MySettings_MovieSet.GetEnglishImages
        _setup_MovieSet.chkPrefLanguageOnly.Checked = _MySettings_MovieSet.PrefLanguageOnly
        _setup_MovieSet.chkScrapePoster.Checked = ConfigScrapeModifier_MovieSet.Poster
        _setup_MovieSet.chkScrapeFanart.Checked = ConfigScrapeModifier_MovieSet.Fanart
        _setup_MovieSet.chkScrapeBanner.Checked = ConfigScrapeModifier_MovieSet.Banner
        _setup_MovieSet.chkScrapeClearArt.Checked = ConfigScrapeModifier_MovieSet.ClearArt
        _setup_MovieSet.chkScrapeClearArtOnlyHD.Checked = _MySettings_MovieSet.ClearArtOnlyHD
        _setup_MovieSet.chkScrapeClearLogo.Checked = ConfigScrapeModifier_MovieSet.ClearLogo
        _setup_MovieSet.chkScrapeClearLogoOnlyHD.Checked = _MySettings_MovieSet.ClearLogoOnlyHD
        _setup_MovieSet.chkScrapeDiscArt.Checked = ConfigScrapeModifier_MovieSet.DiscArt
        _setup_MovieSet.chkScrapeLandscape.Checked = ConfigScrapeModifier_MovieSet.Landscape
        _setup_MovieSet.txtApiKey.Text = _MySettings_MovieSet.ApiKey
        _setup_MovieSet.cbPrefLanguage.Text = _MySettings_MovieSet.PrefLanguage

        If Not String.IsNullOrEmpty(_MySettings_MovieSet.ApiKey) Then
            _setup_MovieSet.btnUnlockAPI.Text = Master.eLang.GetString(443, "Use embedded API Key")
            _setup_MovieSet.lblEMMAPI.Visible = False
            _setup_MovieSet.txtApiKey.Enabled = True
        End If

        _setup_MovieSet.orderChanged()

        Spanel.Name = String.Concat(Me._Name, "_MovieSet")
        Spanel.Text = Master.eLang.GetString(788, "FanartTV")
        Spanel.Prefix = "FanartTVMovieSetMedia_"
        Spanel.Order = 110
        Spanel.Parent = "pnlMovieSetMedia"
        Spanel.Type = Master.eLang.GetString(1203, "MovieSets")
        Spanel.ImageIndex = If(Me._ScraperEnabled_MovieSet, 9, 10)
        Spanel.Panel = Me._setup_MovieSet.pnlSettings

        AddHandler _setup_MovieSet.SetupScraperChanged, AddressOf Handle_SetupScraperChanged_MovieSet
        AddHandler _setup_MovieSet.ModuleSettingsChanged, AddressOf Handle_ModuleSettingsChanged_MovieSet
        AddHandler _setup_MovieSet.SetupNeedsRestart, AddressOf Handle_SetupNeedsRestart_MovieSet
        Return Spanel
    End Function

    Function InjectSetupScraper_TV() As Containers.SettingsPanel Implements Interfaces.ScraperModule_Image_TV.InjectSetupScraper
        Dim Spanel As New Containers.SettingsPanel
        _setup_TV = New frmFanartTVMediaSettingsHolder_TV
        LoadSettings_TV()
        _setup_TV.chkEnabled.Checked = _ScraperEnabled_TV
        _setup_TV.chkGetBlankImages.Checked = _MySettings_TV.GetBlankImages
        _setup_TV.chkGetEnglishImages.Checked = _MySettings_TV.GetEnglishImages
        _setup_TV.chkPrefLanguageOnly.Checked = _MySettings_TV.PrefLanguageOnly
        _setup_TV.chkScrapePoster.Checked = ConfigScrapeModifier_TV.Poster
        _setup_TV.chkScrapeFanart.Checked = ConfigScrapeModifier_TV.Fanart
        _setup_TV.chkScrapeBanner.Checked = ConfigScrapeModifier_TV.Banner
        _setup_TV.chkScrapeCharacterArt.Checked = ConfigScrapeModifier_TV.CharacterArt
        _setup_TV.chkScrapeClearArt.Checked = ConfigScrapeModifier_TV.ClearArt
        _setup_TV.chkScrapeClearArtOnlyHD.Checked = _MySettings_TV.ClearArtOnlyHD
        _setup_TV.chkScrapeClearLogo.Checked = ConfigScrapeModifier_TV.ClearLogo
        _setup_TV.chkScrapeClearLogoOnlyHD.Checked = _MySettings_TV.ClearLogoOnlyHD
        _setup_TV.chkScrapeLandscape.Checked = ConfigScrapeModifier_TV.Landscape
        _setup_TV.txtApiKey.Text = _MySettings_TV.ApiKey
        _setup_TV.cbPrefLanguage.Text = _MySettings_TV.PrefLanguage

        If Not String.IsNullOrEmpty(_MySettings_TV.ApiKey) Then
            _setup_TV.btnUnlockAPI.Text = Master.eLang.GetString(443, "Use embedded API Key")
            _setup_TV.lblEMMAPI.Visible = False
            _setup_TV.txtApiKey.Enabled = True
        End If

        _setup_TV.orderChanged()

        Spanel.Name = String.Concat(Me._Name, "_TV")
        Spanel.Text = Master.eLang.GetString(788, "FanartTV")
        Spanel.Prefix = "FanartTVTVMedia_"
        Spanel.Order = 110
        Spanel.Parent = "pnlTVMedia"
        Spanel.Type = Master.eLang.GetString(653, "TV Shows")
        Spanel.ImageIndex = If(Me._ScraperEnabled_TV, 9, 10)
        Spanel.Panel = Me._setup_TV.pnlSettings

        AddHandler _setup_TV.SetupScraperChanged, AddressOf Handle_SetupScraperChanged_TV
        AddHandler _setup_TV.ModuleSettingsChanged, AddressOf Handle_ModuleSettingsChanged_TV
        AddHandler _setup_TV.SetupNeedsRestart, AddressOf Handle_SetupNeedsRestart_TV
        Return Spanel
    End Function

    Sub LoadSettings_Movie()
        _MySettings_Movie.ApiKey = clsAdvancedSettings.GetSetting("ApiKey", "", , Enums.Content_Type.Movie)
        _MySettings_Movie.PrefLanguage = clsAdvancedSettings.GetSetting("PrefLanguage", "en", , Enums.Content_Type.Movie)
        _MySettings_Movie.PrefLanguageOnly = clsAdvancedSettings.GetBooleanSetting("PrefLanguageOnly", False, , Enums.Content_Type.Movie)
        _MySettings_Movie.GetBlankImages = clsAdvancedSettings.GetBooleanSetting("GetBlankImages", False, , Enums.Content_Type.Movie)
        _MySettings_Movie.GetEnglishImages = clsAdvancedSettings.GetBooleanSetting("GetEnglishImages", False, , Enums.Content_Type.Movie)
        _MySettings_Movie.ClearArtOnlyHD = clsAdvancedSettings.GetBooleanSetting("ClearArtOnlyHD", False, , Enums.Content_Type.Movie)
        _MySettings_Movie.ClearLogoOnlyHD = clsAdvancedSettings.GetBooleanSetting("ClearLogoOnlyHD", False, , Enums.Content_Type.Movie)

        ConfigScrapeModifier_Movie.Poster = clsAdvancedSettings.GetBooleanSetting("DoPoster", True, , Enums.Content_Type.Movie)
        ConfigScrapeModifier_Movie.Fanart = clsAdvancedSettings.GetBooleanSetting("DoFanart", True, , Enums.Content_Type.Movie)
        ConfigScrapeModifier_Movie.Banner = clsAdvancedSettings.GetBooleanSetting("DoBanner", True, , Enums.Content_Type.Movie)
        ConfigScrapeModifier_Movie.ClearArt = clsAdvancedSettings.GetBooleanSetting("DoClearArt", True, , Enums.Content_Type.Movie)
        ConfigScrapeModifier_Movie.ClearLogo = clsAdvancedSettings.GetBooleanSetting("DoClearLogo", True, , Enums.Content_Type.Movie)
        ConfigScrapeModifier_Movie.DiscArt = clsAdvancedSettings.GetBooleanSetting("DoDiscArt", True, , Enums.Content_Type.Movie)
        ConfigScrapeModifier_Movie.Landscape = clsAdvancedSettings.GetBooleanSetting("DoLandscape", True, , Enums.Content_Type.Movie)
        ConfigScrapeModifier_Movie.EThumbs = ConfigScrapeModifier_Movie.Fanart
        ConfigScrapeModifier_Movie.EFanarts = ConfigScrapeModifier_Movie.Fanart
    End Sub

    Sub LoadSettings_MovieSet()
        _MySettings_MovieSet.ApiKey = clsAdvancedSettings.GetSetting("ApiKey", "", , Enums.Content_Type.MovieSet)
        _MySettings_MovieSet.PrefLanguage = clsAdvancedSettings.GetSetting("PrefLanguage", "en", , Enums.Content_Type.MovieSet)
        _MySettings_MovieSet.PrefLanguageOnly = clsAdvancedSettings.GetBooleanSetting("PrefLanguageOnly", False, , Enums.Content_Type.MovieSet)
        _MySettings_MovieSet.GetBlankImages = clsAdvancedSettings.GetBooleanSetting("GetBlankImages", False, , Enums.Content_Type.MovieSet)
        _MySettings_MovieSet.GetEnglishImages = clsAdvancedSettings.GetBooleanSetting("GetEnglishImages", False, , Enums.Content_Type.MovieSet)
        _MySettings_MovieSet.ClearArtOnlyHD = clsAdvancedSettings.GetBooleanSetting("ClearArtOnlyHD", False, , Enums.Content_Type.MovieSet)
        _MySettings_MovieSet.ClearLogoOnlyHD = clsAdvancedSettings.GetBooleanSetting("ClearLogoOnlyHD", False, , Enums.Content_Type.MovieSet)

        ConfigScrapeModifier_MovieSet.Poster = clsAdvancedSettings.GetBooleanSetting("DoPoster", True, , Enums.Content_Type.MovieSet)
        ConfigScrapeModifier_MovieSet.Fanart = clsAdvancedSettings.GetBooleanSetting("DoFanart", True, , Enums.Content_Type.MovieSet)
        ConfigScrapeModifier_MovieSet.Banner = clsAdvancedSettings.GetBooleanSetting("DoBanner", True, , Enums.Content_Type.MovieSet)
        ConfigScrapeModifier_MovieSet.ClearArt = clsAdvancedSettings.GetBooleanSetting("DoClearArt", True, , Enums.Content_Type.MovieSet)
        ConfigScrapeModifier_MovieSet.ClearLogo = clsAdvancedSettings.GetBooleanSetting("DoClearLogo", True, , Enums.Content_Type.MovieSet)
        ConfigScrapeModifier_MovieSet.DiscArt = clsAdvancedSettings.GetBooleanSetting("DoDiscArt", True, , Enums.Content_Type.MovieSet)
        ConfigScrapeModifier_MovieSet.Landscape = clsAdvancedSettings.GetBooleanSetting("DoLandscape", True, , Enums.Content_Type.MovieSet)
        ConfigScrapeModifier_MovieSet.EThumbs = ConfigScrapeModifier_MovieSet.Fanart
        ConfigScrapeModifier_MovieSet.EFanarts = ConfigScrapeModifier_MovieSet.Fanart
    End Sub

    Sub LoadSettings_TV()
        _MySettings_TV.ApiKey = clsAdvancedSettings.GetSetting("ApiKey", "", , Enums.Content_Type.TV)
        _MySettings_TV.PrefLanguage = clsAdvancedSettings.GetSetting("PrefLanguage", "en", , Enums.Content_Type.TV)
        _MySettings_TV.PrefLanguageOnly = clsAdvancedSettings.GetBooleanSetting("PrefLanguageOnly", False, , Enums.Content_Type.TV)
        _MySettings_TV.GetBlankImages = clsAdvancedSettings.GetBooleanSetting("GetBlankImages", False, , Enums.Content_Type.TV)
        _MySettings_TV.GetEnglishImages = clsAdvancedSettings.GetBooleanSetting("GetEnglishImages", False, , Enums.Content_Type.TV)
        _MySettings_TV.ClearArtOnlyHD = clsAdvancedSettings.GetBooleanSetting("ClearArtOnlyHD", False, , Enums.Content_Type.TV)
        _MySettings_TV.ClearLogoOnlyHD = clsAdvancedSettings.GetBooleanSetting("ClearLogoOnlyHD", False, , Enums.Content_Type.TV)

        ConfigScrapeModifier_TV.Banner = clsAdvancedSettings.GetBooleanSetting("DoBanner", True, , Enums.Content_Type.TV)
        ConfigScrapeModifier_TV.CharacterArt = clsAdvancedSettings.GetBooleanSetting("DoCharacterArt", True, , Enums.Content_Type.TV)
        ConfigScrapeModifier_TV.ClearArt = clsAdvancedSettings.GetBooleanSetting("DoClearArt", True, , Enums.Content_Type.TV)
        ConfigScrapeModifier_TV.ClearLogo = clsAdvancedSettings.GetBooleanSetting("DoClearLogo", True, , Enums.Content_Type.TV)
        ConfigScrapeModifier_TV.EFanarts = ConfigScrapeModifier_TV.Fanart
        ConfigScrapeModifier_TV.Fanart = clsAdvancedSettings.GetBooleanSetting("DoFanart", True, , Enums.Content_Type.TV)
        ConfigScrapeModifier_TV.Landscape = clsAdvancedSettings.GetBooleanSetting("DoLandscape", True, , Enums.Content_Type.TV)
        ConfigScrapeModifier_TV.Poster = clsAdvancedSettings.GetBooleanSetting("DoPoster", True, , Enums.Content_Type.TV)
    End Sub

    Sub SaveSettings_Movie()
        Using settings = New clsAdvancedSettings()
            settings.SetBooleanSetting("ClearArtOnlyHD", _MySettings_Movie.ClearArtOnlyHD, , , Enums.Content_Type.Movie)
            settings.SetBooleanSetting("ClearLogoOnlyHD", _MySettings_Movie.ClearLogoOnlyHD, , , Enums.Content_Type.Movie)
            settings.SetBooleanSetting("DoPoster", ConfigScrapeModifier_Movie.Poster, , , Enums.Content_Type.Movie)
            settings.SetBooleanSetting("DoFanart", ConfigScrapeModifier_Movie.Fanart, , , Enums.Content_Type.Movie)
            settings.SetBooleanSetting("DoBanner", ConfigScrapeModifier_Movie.Banner, , , Enums.Content_Type.Movie)
            settings.SetBooleanSetting("DoClearArt", ConfigScrapeModifier_Movie.ClearArt, , , Enums.Content_Type.Movie)
            settings.SetBooleanSetting("DoClearLogo", ConfigScrapeModifier_Movie.ClearLogo, , , Enums.Content_Type.Movie)
            settings.SetBooleanSetting("DoDiscArt", ConfigScrapeModifier_Movie.DiscArt, , , Enums.Content_Type.Movie)
            settings.SetBooleanSetting("DoLandscape", ConfigScrapeModifier_Movie.Landscape, , , Enums.Content_Type.Movie)

            settings.SetSetting("ApiKey", _setup_Movie.txtApiKey.Text, , , Enums.Content_Type.Movie)
            settings.SetSetting("PrefLanguage", _MySettings_Movie.PrefLanguage, , , Enums.Content_Type.Movie)
            settings.SetBooleanSetting("GetBlankImages", _MySettings_Movie.GetBlankImages, , , Enums.Content_Type.Movie)
            settings.SetBooleanSetting("GetEnglishImages", _MySettings_Movie.GetEnglishImages, , , Enums.Content_Type.Movie)
            settings.SetBooleanSetting("PrefLanguageOnly", _MySettings_Movie.PrefLanguageOnly, , , Enums.Content_Type.Movie)
        End Using
    End Sub

    Sub SaveSettings_MovieSet()
        Using settings = New clsAdvancedSettings()
            settings.SetBooleanSetting("ClearArtOnlyHD", _MySettings_MovieSet.ClearArtOnlyHD, , , Enums.Content_Type.MovieSet)
            settings.SetBooleanSetting("ClearLogoOnlyHD", _MySettings_MovieSet.ClearLogoOnlyHD, , , Enums.Content_Type.MovieSet)
            settings.SetBooleanSetting("DoPoster", ConfigScrapeModifier_MovieSet.Poster, , , Enums.Content_Type.MovieSet)
            settings.SetBooleanSetting("DoFanart", ConfigScrapeModifier_MovieSet.Fanart, , , Enums.Content_Type.MovieSet)
            settings.SetBooleanSetting("DoBanner", ConfigScrapeModifier_MovieSet.Banner, , , Enums.Content_Type.MovieSet)
            settings.SetBooleanSetting("DoClearArt", ConfigScrapeModifier_MovieSet.ClearArt, , , Enums.Content_Type.MovieSet)
            settings.SetBooleanSetting("DoClearLogo", ConfigScrapeModifier_MovieSet.ClearLogo, , , Enums.Content_Type.MovieSet)
            settings.SetBooleanSetting("DoDiscArt", ConfigScrapeModifier_MovieSet.DiscArt, , , Enums.Content_Type.MovieSet)
            settings.SetBooleanSetting("DoLandscape", ConfigScrapeModifier_MovieSet.Landscape, , , Enums.Content_Type.MovieSet)

            settings.SetSetting("ApiKey", _setup_MovieSet.txtApiKey.Text, , , Enums.Content_Type.MovieSet)
            settings.SetSetting("PrefLanguage", _MySettings_MovieSet.PrefLanguage, , , Enums.Content_Type.MovieSet)
            settings.SetBooleanSetting("GetBlankImages", _MySettings_MovieSet.GetBlankImages, , , Enums.Content_Type.MovieSet)
            settings.SetBooleanSetting("GetEnglishImages", _MySettings_MovieSet.GetEnglishImages, , , Enums.Content_Type.MovieSet)
            settings.SetBooleanSetting("PrefLanguageOnly", _MySettings_MovieSet.PrefLanguageOnly, , , Enums.Content_Type.MovieSet)
        End Using
    End Sub

    Sub SaveSettings_TV()
        Using settings = New clsAdvancedSettings()
            settings.SetBooleanSetting("ClearArtOnlyHD", _MySettings_TV.ClearArtOnlyHD, , , Enums.Content_Type.TV)
            settings.SetBooleanSetting("ClearLogoOnlyHD", _MySettings_TV.ClearLogoOnlyHD, , , Enums.Content_Type.TV)
            settings.SetBooleanSetting("DoBanner", ConfigScrapeModifier_TV.Banner, , , Enums.Content_Type.TV)
            settings.SetBooleanSetting("DoCharacterArt", ConfigScrapeModifier_TV.CharacterArt, , , Enums.Content_Type.TV)
            settings.SetBooleanSetting("DoClearArt", ConfigScrapeModifier_TV.ClearArt, , , Enums.Content_Type.TV)
            settings.SetBooleanSetting("DoClearLogo", ConfigScrapeModifier_TV.ClearLogo, , , Enums.Content_Type.TV)
            settings.SetBooleanSetting("DoFanart", ConfigScrapeModifier_TV.Fanart, , , Enums.Content_Type.TV)
            settings.SetBooleanSetting("DoLandscape", ConfigScrapeModifier_TV.Landscape, , , Enums.Content_Type.TV)
            settings.SetBooleanSetting("DoPoster", ConfigScrapeModifier_TV.Poster, , , Enums.Content_Type.TV)

            settings.SetSetting("ApiKey", _setup_TV.txtApiKey.Text, , , Enums.Content_Type.TV)
            settings.SetSetting("PrefLanguage", _MySettings_TV.PrefLanguage, , , Enums.Content_Type.TV)
            settings.SetBooleanSetting("GetBlankImages", _MySettings_TV.GetBlankImages, , , Enums.Content_Type.TV)
            settings.SetBooleanSetting("GetEnglishImages", _MySettings_TV.GetEnglishImages, , , Enums.Content_Type.TV)
            settings.SetBooleanSetting("PrefLanguageOnly", _MySettings_TV.PrefLanguageOnly, , , Enums.Content_Type.TV)
        End Using
    End Sub

    Sub SaveSetupScraper_Movie(ByVal DoDispose As Boolean) Implements Interfaces.ScraperModule_Image_Movie.SaveSetupScraper
        _MySettings_Movie.PrefLanguage = _setup_Movie.cbPrefLanguage.Text
        _MySettings_Movie.PrefLanguageOnly = _setup_Movie.chkPrefLanguageOnly.Checked
        _MySettings_Movie.GetBlankImages = _setup_Movie.chkGetBlankImages.Checked
        _MySettings_Movie.GetEnglishImages = _setup_Movie.chkGetEnglishImages.Checked
        _MySettings_Movie.ClearArtOnlyHD = _setup_Movie.chkScrapeClearArtOnlyHD.Checked
        _MySettings_Movie.ClearLogoOnlyHD = _setup_Movie.chkScrapeClearLogoOnlyHD.Checked
        ConfigScrapeModifier_Movie.Poster = _setup_Movie.chkScrapePoster.Checked
        ConfigScrapeModifier_Movie.Fanart = _setup_Movie.chkScrapeFanart.Checked
        ConfigScrapeModifier_Movie.Banner = _setup_Movie.chkScrapeBanner.Checked
        ConfigScrapeModifier_Movie.ClearArt = _setup_Movie.chkScrapeClearArt.Checked
        ConfigScrapeModifier_Movie.ClearLogo = _setup_Movie.chkScrapeClearLogo.Checked
        ConfigScrapeModifier_Movie.DiscArt = _setup_Movie.chkScrapeDiscArt.Checked
        ConfigScrapeModifier_Movie.Landscape = _setup_Movie.chkScrapeLandscape.Checked
        SaveSettings_Movie()
        If DoDispose Then
            RemoveHandler _setup_Movie.SetupScraperChanged, AddressOf Handle_SetupScraperChanged_Movie
            RemoveHandler _setup_Movie.ModuleSettingsChanged, AddressOf Handle_ModuleSettingsChanged_Movie
            RemoveHandler _setup_Movie.SetupNeedsRestart, AddressOf Handle_SetupNeedsRestart_Movie
            _setup_Movie.Dispose()
        End If
    End Sub

    Sub SaveSetupScraper_MovieSet(ByVal DoDispose As Boolean) Implements Interfaces.ScraperModule_Image_MovieSet.SaveSetupScraper
        _MySettings_MovieSet.PrefLanguage = _setup_MovieSet.cbPrefLanguage.Text
        _MySettings_MovieSet.PrefLanguageOnly = _setup_MovieSet.chkPrefLanguageOnly.Checked
        _MySettings_MovieSet.GetBlankImages = _setup_MovieSet.chkGetBlankImages.Checked
        _MySettings_MovieSet.GetEnglishImages = _setup_MovieSet.chkGetEnglishImages.Checked
        _MySettings_MovieSet.ClearArtOnlyHD = _setup_MovieSet.chkScrapeClearArtOnlyHD.Checked
        _MySettings_MovieSet.ClearLogoOnlyHD = _setup_MovieSet.chkScrapeClearLogoOnlyHD.Checked
        ConfigScrapeModifier_MovieSet.Poster = _setup_MovieSet.chkScrapePoster.Checked
        ConfigScrapeModifier_MovieSet.Fanart = _setup_MovieSet.chkScrapeFanart.Checked
        ConfigScrapeModifier_MovieSet.Banner = _setup_MovieSet.chkScrapeBanner.Checked
        ConfigScrapeModifier_MovieSet.ClearArt = _setup_MovieSet.chkScrapeClearArt.Checked
        ConfigScrapeModifier_MovieSet.ClearLogo = _setup_MovieSet.chkScrapeClearLogo.Checked
        ConfigScrapeModifier_MovieSet.DiscArt = _setup_MovieSet.chkScrapeDiscArt.Checked
        ConfigScrapeModifier_MovieSet.Landscape = _setup_MovieSet.chkScrapeLandscape.Checked
        SaveSettings_MovieSet()
        If DoDispose Then
            RemoveHandler _setup_MovieSet.SetupScraperChanged, AddressOf Handle_SetupScraperChanged_MovieSet
            RemoveHandler _setup_MovieSet.ModuleSettingsChanged, AddressOf Handle_ModuleSettingsChanged_MovieSet
            RemoveHandler _setup_MovieSet.SetupNeedsRestart, AddressOf Handle_SetupNeedsRestart_MovieSet
            _setup_MovieSet.Dispose()
        End If
    End Sub

    Sub SaveSetupScraper_TV(ByVal DoDispose As Boolean) Implements Interfaces.ScraperModule_Image_TV.SaveSetupScraper
        _MySettings_TV.PrefLanguage = _setup_TV.cbPrefLanguage.Text
        _MySettings_TV.PrefLanguageOnly = _setup_TV.chkPrefLanguageOnly.Checked
        _MySettings_TV.GetBlankImages = _setup_TV.chkGetBlankImages.Checked
        _MySettings_TV.GetEnglishImages = _setup_TV.chkGetEnglishImages.Checked
        _MySettings_TV.ClearArtOnlyHD = _setup_TV.chkScrapeClearArtOnlyHD.Checked
        _MySettings_TV.ClearLogoOnlyHD = _setup_TV.chkScrapeClearLogoOnlyHD.Checked
        ConfigScrapeModifier_TV.CharacterArt = _setup_TV.chkScrapeCharacterArt.Checked
        ConfigScrapeModifier_TV.Poster = _setup_TV.chkScrapePoster.Checked
        ConfigScrapeModifier_TV.Fanart = _setup_TV.chkScrapeFanart.Checked
        ConfigScrapeModifier_TV.Banner = _setup_TV.chkScrapeBanner.Checked
        ConfigScrapeModifier_TV.ClearArt = _setup_TV.chkScrapeClearArt.Checked
        ConfigScrapeModifier_TV.ClearLogo = _setup_TV.chkScrapeClearLogo.Checked
        ConfigScrapeModifier_TV.Landscape = _setup_TV.chkScrapeLandscape.Checked
        SaveSettings_TV()
        If DoDispose Then
            RemoveHandler _setup_TV.SetupScraperChanged, AddressOf Handle_SetupScraperChanged_TV
            RemoveHandler _setup_TV.ModuleSettingsChanged, AddressOf Handle_ModuleSettingsChanged_TV
            RemoveHandler _setup_TV.SetupNeedsRestart, AddressOf Handle_SetupNeedsRestart_TV
            _setup_TV.Dispose()
        End If
    End Sub

    Function Scraper(ByRef DBMovie As Structures.DBMovie, ByVal Type As Enums.ScraperCapabilities, ByRef ImageList As List(Of MediaContainers.Image)) As Interfaces.ModuleResult Implements Interfaces.ScraperModule_Image_Movie.Scraper
        logger.Trace("Started scrape FanartTV")

        LoadSettings_Movie()

        Dim Settings As FanartTVs.Scraper.sMySettings_ForScraper
        Settings.ApiKey = _MySettings_Movie.ApiKey
        Settings.ClearArtOnlyHD = _MySettings_Movie.ClearArtOnlyHD
        Settings.ClearLogoOnlyHD = _MySettings_Movie.ClearLogoOnlyHD
        Settings.GetBlankImages = _MySettings_Movie.GetBlankImages
        Settings.GetEnglishImages = _MySettings_Movie.GetEnglishImages
        Settings.PrefLanguage = _MySettings_Movie.PrefLanguage
        Settings.PrefLanguageOnly = _MySettings_Movie.PrefLanguageOnly

        If Not String.IsNullOrEmpty(DBMovie.Movie.ID) Then
            ImageList = _scraper.GetImages_Movie_MovieSet(DBMovie.Movie.ID, Type, Settings)
        ElseIf Not String.IsNullOrEmpty(DBMovie.Movie.TMDBID) Then
            ImageList = _scraper.GetImages_Movie_MovieSet(DBMovie.Movie.TMDBID, Type, Settings)
        Else
            logger.Trace(String.Concat("No IMDB and TMDB ID exist to search: ", DBMovie.ListTitle))
        End If

        logger.Trace(New StackFrame().GetMethod().Name, "Finished scrape FanartTV")
        Return New Interfaces.ModuleResult With {.breakChain = False}
    End Function

    Function Scraper(ByRef DBMovieset As Structures.DBMovieSet, ByVal Type As Enums.ScraperCapabilities, ByRef ImageList As List(Of MediaContainers.Image)) As Interfaces.ModuleResult Implements Interfaces.ScraperModule_Image_MovieSet.Scraper
        logger.Trace("Started scrape FanartTV")

        LoadSettings_MovieSet()

        If String.IsNullOrEmpty(DBMovieset.MovieSet.ID) Then
            If Not IsNothing(DBMovieset.Movies) AndAlso DBMovieset.Movies.Count > 0 Then
                DBMovieset.MovieSet.ID = ModulesManager.Instance.GetMovieCollectionID(DBMovieset.Movies.Item(0).Movie.ID)
            End If
        End If

        If Not String.IsNullOrEmpty(DBMovieset.MovieSet.ID) Then
            Dim Settings As FanartTVs.Scraper.sMySettings_ForScraper
            Settings.ApiKey = _MySettings_MovieSet.ApiKey
            Settings.ClearArtOnlyHD = _MySettings_MovieSet.ClearArtOnlyHD
            Settings.ClearLogoOnlyHD = _MySettings_MovieSet.ClearLogoOnlyHD
            Settings.GetBlankImages = _MySettings_MovieSet.GetBlankImages
            Settings.GetEnglishImages = _MySettings_MovieSet.GetEnglishImages
            Settings.PrefLanguage = _MySettings_MovieSet.PrefLanguage
            Settings.PrefLanguageOnly = _MySettings_MovieSet.PrefLanguageOnly

            ImageList = _scraper.GetImages_Movie_MovieSet(DBMovieset.MovieSet.ID, Type, Settings)
        End If

        logger.Trace("Finished scrape FanartTV")
        Return New Interfaces.ModuleResult With {.breakChain = False}
    End Function

    Function Scraper(ByRef DBTV As Structures.DBTV, ByVal Type As Enums.ScraperCapabilities, ByRef ImageList As List(Of MediaContainers.Image)) As Interfaces.ModuleResult Implements Interfaces.ScraperModule_Image_TV.Scraper
        logger.Trace("Started scrape FanartTV")

        LoadSettings_TV()

        Dim Settings As FanartTVs.Scraper.sMySettings_ForScraper
        Settings.ApiKey = _MySettings_TV.ApiKey
        Settings.ClearArtOnlyHD = _MySettings_TV.ClearArtOnlyHD
        Settings.ClearLogoOnlyHD = _MySettings_TV.ClearLogoOnlyHD
        Settings.GetBlankImages = _MySettings_TV.GetBlankImages
        Settings.GetEnglishImages = _MySettings_TV.GetEnglishImages
        Settings.PrefLanguage = _MySettings_TV.PrefLanguage
        Settings.PrefLanguageOnly = _MySettings_TV.PrefLanguageOnly

        If Not String.IsNullOrEmpty(DBTV.TVShow.ID) Then
            ImageList = _scraper.GetImages_TV(DBTV.TVShow.ID, Type, Settings)
        Else
            logger.Trace(String.Concat("No TVDB ID exist to search: ", DBTV.ListTitle))
        End If

        logger.Trace(New StackFrame().GetMethod().Name, "Finished scrape FanartTV")
        Return New Interfaces.ModuleResult With {.breakChain = False}
    End Function

    Public Sub ScraperOrderChanged_Movie() Implements EmberAPI.Interfaces.ScraperModule_Image_Movie.ScraperOrderChanged
        _setup_Movie.orderChanged()
    End Sub

    Public Sub ScraperOrderChanged_MovieSet() Implements EmberAPI.Interfaces.ScraperModule_Image_MovieSet.ScraperOrderChanged
        _setup_MovieSet.orderChanged()
    End Sub

    Public Sub ScraperOrderChanged_TV() Implements EmberAPI.Interfaces.ScraperModule_Image_TV.ScraperOrderChanged
        _setup_TV.orderChanged()
    End Sub

#End Region 'Methods

#Region "Nested Types"

    Structure sMySettings

#Region "Fields"
        Dim ApiKey As String
        Dim ClearArtOnlyHD As Boolean
        Dim ClearLogoOnlyHD As Boolean
        Dim GetEnglishImages As Boolean
        Dim GetBlankImages As Boolean
        Dim PrefLanguage As String
        Dim PrefLanguageOnly As Boolean
#End Region 'Fields

    End Structure

#End Region 'Nested Types

End Class