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
Imports ScraperModule.TVDBs

Public Class TVDB_Image
    Implements Interfaces.ScraperModule_Image_TV

#Region "Fields"

    Shared logger As Logger = NLog.LogManager.GetCurrentClassLogger()

    Public Shared ConfigScrapeModifier As New Structures.ScrapeModifier_TV
    Public Shared _AssemblyName As String

    Private _MySettings As New sMySettings
    Private _Name As String = "TVDB_Image"
    Private _ScraperEnabled As Boolean = False
    Private _setup As frmTVDBMediaSettingsHolder
    Private _scraper As New Scraper

#End Region 'Fields

#Region "Events"

    Public Event ModuleSettingsChanged() Implements Interfaces.ScraperModule_Image_TV.ModuleSettingsChanged

    Public Event MovieScraperEvent(ByVal eType As Enums.ScraperEventType_TV, ByVal Parameter As Object) Implements Interfaces.ScraperModule_Image_TV.ScraperEvent

    Public Event SetupScraperChanged(ByVal name As String, ByVal State As Boolean, ByVal difforder As Integer) Implements Interfaces.ScraperModule_Image_TV.ScraperSetupChanged

    Public Event SetupNeedsRestart() Implements Interfaces.ScraperModule_Image_TV.SetupNeedsRestart

    Public Event ImagesDownloaded(ByVal Posters As List(Of MediaContainers.Image)) Implements Interfaces.ScraperModule_Image_TV.ImagesDownloaded

    Public Event ProgressUpdated(ByVal iPercent As Integer) Implements Interfaces.ScraperModule_Image_TV.ProgressUpdated

#End Region 'Events

#Region "Properties"

    ReadOnly Property ModuleName() As String Implements Interfaces.ScraperModule_Image_TV.ModuleName
        Get
            Return _Name
        End Get
    End Property

    ReadOnly Property ModuleVersion() As String Implements Interfaces.ScraperModule_Image_TV.ModuleVersion
        Get
            Return System.Diagnostics.FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetExecutingAssembly.Location).FileVersion.ToString
        End Get
    End Property

    Property ScraperEnabled() As Boolean Implements Interfaces.ScraperModule_Image_TV.ScraperEnabled
        Get
            Return _ScraperEnabled
        End Get
        Set(ByVal value As Boolean)
            _ScraperEnabled = value
        End Set
    End Property

#End Region 'Properties

#Region "Methods"

    Function QueryScraperCapabilities(ByVal cap As Enums.ScraperCapabilities_TV) As Boolean Implements Interfaces.ScraperModule_Image_TV.QueryScraperCapabilities
        Select Case cap
            Case Enums.ScraperCapabilities_TV.AllSeasonsBanner
                Return ConfigScrapeModifier.AllSeasonsBanner
            Case Enums.ScraperCapabilities_TV.AllSeasonsFanart
                Return ConfigScrapeModifier.AllSeasonsFanart
            Case Enums.ScraperCapabilities_TV.AllSeasonsPoster
                Return ConfigScrapeModifier.AllSeasonsPoster
            Case Enums.ScraperCapabilities_TV.SeasonBanner
                Return ConfigScrapeModifier.SeasonBanner
            Case Enums.ScraperCapabilities_TV.SeasonFanart
                Return ConfigScrapeModifier.SeasonFanart
            Case Enums.ScraperCapabilities_TV.SeasonPoster
                Return ConfigScrapeModifier.SeasonPoster
            Case Enums.ScraperCapabilities_TV.ShowBanner
                Return ConfigScrapeModifier.ShowBanner
            Case Enums.ScraperCapabilities_TV.ShowEFanarts
                Return ConfigScrapeModifier.ShowEFanarts
            Case Enums.ScraperCapabilities_TV.ShowFanart
                Return ConfigScrapeModifier.ShowFanart
            Case Enums.ScraperCapabilities_TV.ShowPoster
                Return ConfigScrapeModifier.ShowPoster
        End Select
        Return False
    End Function

    Private Sub Handle_ModuleSettingsChanged()
        RaiseEvent ModuleSettingsChanged()
    End Sub

    Private Sub Handle_SetupNeedsRestart()
        RaiseEvent SetupNeedsRestart()
    End Sub

    Private Sub Handle_SetupScraperChanged(ByVal state As Boolean, ByVal difforder As Integer)
        ScraperEnabled = state
        RaiseEvent SetupScraperChanged(String.Concat(Me._Name, "Scraper"), state, difforder)
    End Sub

    Sub Init(ByVal sAssemblyName As String) Implements Interfaces.ScraperModule_Image_TV.Init
        _AssemblyName = sAssemblyName
        LoadSettings()
    End Sub

    Function InjectSetupScraper() As Containers.SettingsPanel Implements Interfaces.ScraperModule_Image_TV.InjectSetupScraper
        Dim Spanel As New Containers.SettingsPanel
        _setup = New frmTVDBMediaSettingsHolder
        LoadSettings()
        _setup.chkEnabled.Checked = _ScraperEnabled
        _setup.chkGetBlankImages.Checked = _MySettings.GetBlankImages
        _setup.chkGetEnglishImages.Checked = _MySettings.GetEnglishImages
        _setup.chkPrefLanguageOnly.Checked = _MySettings.PrefLanguageOnly
        _setup.chkScrapeSeasonBanner.Checked = ConfigScrapeModifier.SeasonBanner
        _setup.chkScrapeSeasonFanart.Checked = ConfigScrapeModifier.SeasonFanart
        _setup.chkScrapeSeasonPoster.Checked = ConfigScrapeModifier.SeasonPoster
        _setup.chkScrapeShowBanner.Checked = ConfigScrapeModifier.ShowBanner
        _setup.chkScrapeShowFanart.Checked = ConfigScrapeModifier.ShowFanart
        _setup.chkScrapeShowPoster.Checked = ConfigScrapeModifier.ShowPoster
        _setup.txtApiKey.Text = _MySettings.ApiKey
        _setup.cbPrefLanguage.Text = _MySettings.PrefLanguage

        If Not String.IsNullOrEmpty(_MySettings.ApiKey) Then
            _setup.btnUnlockAPI.Text = Master.eLang.GetString(443, "Use embedded API Key")
            _setup.lblEMMAPI.Visible = False
            _setup.txtApiKey.Enabled = True
        End If

        _setup.orderChanged()

        Spanel.Name = String.Concat(Me._Name, "Scraper")
        Spanel.Text = "TVDB"
        Spanel.Prefix = "TVDBMedia_"
        Spanel.Order = 110
        Spanel.Parent = "pnlTVMedia"
        Spanel.Type = Master.eLang.GetString(653, "TV Shows")
        Spanel.ImageIndex = If(Me._ScraperEnabled, 9, 10)
        Spanel.Panel = Me._setup.pnlSettings

        AddHandler _setup.SetupScraperChanged, AddressOf Handle_SetupScraperChanged
        AddHandler _setup.ModuleSettingsChanged, AddressOf Handle_ModuleSettingsChanged
        AddHandler _setup.SetupNeedsRestart, AddressOf Handle_SetupNeedsRestart
        Return Spanel
    End Function

    Sub LoadSettings()
        _MySettings.ApiKey = clsAdvancedSettings.GetSetting("ApiKey", "")
        _MySettings.PrefLanguage = clsAdvancedSettings.GetSetting("PrefLanguage", "en")
        _MySettings.PrefLanguageOnly = clsAdvancedSettings.GetBooleanSetting("PrefLanguageOnly", False)
        _MySettings.GetBlankImages = clsAdvancedSettings.GetBooleanSetting("GetBlankImages", False)
        _MySettings.GetEnglishImages = clsAdvancedSettings.GetBooleanSetting("GetEnglishImages", False)

        ConfigScrapeModifier.SeasonBanner = clsAdvancedSettings.GetBooleanSetting("DoSeasonBanner", True)
        ConfigScrapeModifier.SeasonFanart = clsAdvancedSettings.GetBooleanSetting("DoSeasonFanart", True)
        ConfigScrapeModifier.SeasonLandscape = clsAdvancedSettings.GetBooleanSetting("DoSeasonLandscape", True)
        ConfigScrapeModifier.SeasonPoster = clsAdvancedSettings.GetBooleanSetting("DoSeasonPoster", True)
        ConfigScrapeModifier.ShowBanner = clsAdvancedSettings.GetBooleanSetting("DoShowBanner", True)
        ConfigScrapeModifier.ShowCharacterArt = clsAdvancedSettings.GetBooleanSetting("DoShowCharacterArt", True)
        ConfigScrapeModifier.ShowClearArt = clsAdvancedSettings.GetBooleanSetting("DoShowClearArt", True)
        ConfigScrapeModifier.ShowClearLogo = clsAdvancedSettings.GetBooleanSetting("DoShowClearLogo", True)
        ConfigScrapeModifier.ShowEFanarts = ConfigScrapeModifier.ShowFanart
        ConfigScrapeModifier.ShowFanart = clsAdvancedSettings.GetBooleanSetting("DoShowFanart", True)
        ConfigScrapeModifier.ShowLandscape = clsAdvancedSettings.GetBooleanSetting("DoShowLandscape", True)
        ConfigScrapeModifier.ShowPoster = clsAdvancedSettings.GetBooleanSetting("DoShowPoster", True)
    End Sub

    Sub SaveSettings()
        Using settings = New clsAdvancedSettings()
            settings.SetBooleanSetting("DoSeasonBanner", ConfigScrapeModifier.SeasonBanner)
            settings.SetBooleanSetting("DoSeasonFanart", ConfigScrapeModifier.SeasonFanart)
            settings.SetBooleanSetting("DoSeasonLandscape", ConfigScrapeModifier.SeasonLandscape)
            settings.SetBooleanSetting("DoSeasonPoster", ConfigScrapeModifier.SeasonPoster)
            settings.SetBooleanSetting("DoShowBanner", ConfigScrapeModifier.ShowBanner)
            settings.SetBooleanSetting("DoShowCharacterArt", ConfigScrapeModifier.ShowCharacterArt)
            settings.SetBooleanSetting("DoShowClearArt", ConfigScrapeModifier.ShowClearArt)
            settings.SetBooleanSetting("DoShowClearLogo", ConfigScrapeModifier.ShowClearLogo)
            settings.SetBooleanSetting("DoShowFanart", ConfigScrapeModifier.ShowFanart)
            settings.SetBooleanSetting("DoShowLandscape", ConfigScrapeModifier.ShowLandscape)
            settings.SetBooleanSetting("DoShowPoster", ConfigScrapeModifier.ShowPoster)

            settings.SetSetting("ApiKey", _setup.txtApiKey.Text)
            settings.SetSetting("PrefLanguage", _MySettings.PrefLanguage)
            settings.SetBooleanSetting("GetBlankImages", _MySettings.GetBlankImages)
            settings.SetBooleanSetting("GetEnglishImages", _MySettings.GetEnglishImages)
            settings.SetBooleanSetting("PrefLanguageOnly", _MySettings.PrefLanguageOnly)
        End Using
    End Sub

    Sub SaveSetupScraper(ByVal DoDispose As Boolean) Implements Interfaces.ScraperModule_Image_TV.SaveSetupScraper
        _MySettings.PrefLanguage = _setup.cbPrefLanguage.Text
        _MySettings.PrefLanguageOnly = _setup.chkPrefLanguageOnly.Checked
        _MySettings.GetBlankImages = _setup.chkGetBlankImages.Checked
        _MySettings.GetEnglishImages = _setup.chkGetEnglishImages.Checked
        ConfigScrapeModifier.SeasonBanner = _setup.chkScrapeSeasonBanner.Checked
        ConfigScrapeModifier.SeasonFanart = _setup.chkScrapeSeasonFanart.Checked
        ConfigScrapeModifier.SeasonPoster = _setup.chkScrapeSeasonPoster.Checked
        ConfigScrapeModifier.ShowBanner = _setup.chkScrapeShowBanner.Checked
        ConfigScrapeModifier.ShowFanart = _setup.chkScrapeShowFanart.Checked
        ConfigScrapeModifier.ShowPoster = _setup.chkScrapeShowPoster.Checked
        SaveSettings()
        If DoDispose Then
            RemoveHandler _setup.SetupScraperChanged, AddressOf Handle_SetupScraperChanged
            RemoveHandler _setup.ModuleSettingsChanged, AddressOf Handle_ModuleSettingsChanged
            RemoveHandler _setup.SetupNeedsRestart, AddressOf Handle_SetupNeedsRestart
            _setup.Dispose()
        End If
    End Sub

    Function Scraper(ByRef DBTV As Structures.DBTV, ByVal Type As Enums.ScraperCapabilities_TV, ByRef ImageList As List(Of MediaContainers.Image)) As Interfaces.ModuleResult Implements Interfaces.ScraperModule_Image_TV.Scraper
        logger.Trace("Started scrape TVDB")

        LoadSettings()

        Dim Settings As TVDBs.Scraper.sMySettings_ForScraper
        Settings.ApiKey = _MySettings.ApiKey
        Settings.GetBlankImages = _MySettings.GetBlankImages
        Settings.GetEnglishImages = _MySettings.GetEnglishImages
        Settings.PrefLanguage = _MySettings.PrefLanguage
        Settings.PrefLanguageOnly = _MySettings.PrefLanguageOnly

        If Not String.IsNullOrEmpty(DBTV.TVShow.ID) Then
            ImageList = _scraper.GetImages_TV(DBTV.TVShow.ID, Type, Settings)
        Else
            logger.Trace(String.Concat("No TVDB ID exist to search: ", DBTV.ListTitle))
        End If

        logger.Trace(New StackFrame().GetMethod().Name, "Finished scrape TVDB")
        Return New Interfaces.ModuleResult With {.breakChain = False}
    End Function

    Public Sub ScraperOrderChanged() Implements EmberAPI.Interfaces.ScraperModule_Image_TV.ScraperOrderChanged
        _setup.orderChanged()
    End Sub

#End Region 'Methods

#Region "Nested Types"

    Structure sMySettings

#Region "Fields"
        Dim ApiKey As String
        Dim GetEnglishImages As Boolean
        Dim GetBlankImages As Boolean
        Dim PrefLanguage As String
        Dim PrefLanguageOnly As Boolean
#End Region 'Fields

    End Structure

#End Region 'Nested Types

End Class
