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

Public Class IMDB_Data
    Implements Interfaces.ExternalModule


#Region "Fields"

    Shared logger As Logger = LogManager.GetCurrentClassLogger()

    Public Shared _AssemblyName As String
    Public Shared _ConfigScrapeOptions_Movie As New Structures.ScrapeOptions
    Public Shared _ConfigScrapeOptions_TV As New Structures.ScrapeOptions
    Public Shared _ConfigScrapeModifier_Movie As New Structures.ScrapeModifiers
    Public Shared _ConfigScrapeModifier_TV As New Structures.ScrapeModifiers

    Private _SpecialSettings_Movie As New SpecialSettings
    Private _SpecialSettings_TV As New SpecialSettings
    Private _name As String = "IMDB"
    Private _enabled As Boolean = True
    Private _setup_Movie As frmSettingsHolder_Movie
    Private _setup_TV As frmSettingsHolder_TV

#End Region 'Fields

#Region "Events"

    Public Event ModuleSettingsChanged() Implements Interfaces.ExternalModule.ModuleSettingsChanged
    Public Event SetupNeedsRestart() Implements Interfaces.ExternalModule.SetupNeedsRestart

#End Region 'Events

#Region "Properties"

    ReadOnly Property ModuleName() As String Implements Interfaces.ExternalModule.ModuleName
        Get
            Return _name
        End Get
    End Property

    ReadOnly Property ModuleVersion() As String Implements Interfaces.ExternalModule.ModuleVersion
        Get
            Return FileVersionInfo.GetVersionInfo(Reflection.Assembly.GetExecutingAssembly.Location).FileVersion.ToString
        End Get
    End Property

    Property Enabled() As Boolean Implements Interfaces.ExternalModule.Enabled
        Get
            Return _enabled
        End Get
        Set(ByVal value As Boolean)
            _enabled = value
        End Set
    End Property

#End Region 'Properties

#Region "Methods"

    Private Sub Handle_ModuleSettingsChanged()
        RaiseEvent ModuleSettingsChanged()
    End Sub

    Private Sub Handle_SetupNeedsRestart()
        RaiseEvent SetupNeedsRestart()
    End Sub

    Sub Init(ByVal sAssemblyName As String) Implements Interfaces.ExternalModule.Init
        _AssemblyName = sAssemblyName
        LoadSettings_Movie()
        LoadSettings_TV()
    End Sub

    Function InjectSetupScraper_Movie() As Containers.SettingsPanel Implements Interfaces.ExternalModule.InjectSettingsPanel
        Dim SPanel As New Containers.SettingsPanel
        _setup_Movie = New frmSettingsHolder_Movie
        LoadSettings_Movie()
        _setup_Movie.chkEnabled.Checked = _enabled

        _setup_Movie.chkActors.Checked = _ConfigScrapeOptions_Movie.bMainActors
        _setup_Movie.chkCertifications.Checked = _ConfigScrapeOptions_Movie.bMainCertifications
        _setup_Movie.chkCountries.Checked = _ConfigScrapeOptions_Movie.bMainCountries
        _setup_Movie.chkDirectors.Checked = _ConfigScrapeOptions_Movie.bMainDirectors
        _setup_Movie.chkGenres.Checked = _ConfigScrapeOptions_Movie.bMainGenres
        _setup_Movie.chkMPAA.Checked = _ConfigScrapeOptions_Movie.bMainMPAA
        _setup_Movie.chkOriginalTitle.Checked = _ConfigScrapeOptions_Movie.bMainOriginalTitle
        _setup_Movie.chkOutline.Checked = _ConfigScrapeOptions_Movie.bMainOutline
        _setup_Movie.chkPlot.Checked = _ConfigScrapeOptions_Movie.bMainPlot
        _setup_Movie.chkRating.Checked = _ConfigScrapeOptions_Movie.bMainRating
        _setup_Movie.chkRelease.Checked = _ConfigScrapeOptions_Movie.bMainRelease
        _setup_Movie.chkRuntime.Checked = _ConfigScrapeOptions_Movie.bMainRuntime
        _setup_Movie.chkStudios.Checked = _ConfigScrapeOptions_Movie.bMainStudios
        _setup_Movie.chkTagline.Checked = _ConfigScrapeOptions_Movie.bMainTagline
        _setup_Movie.chkTitle.Checked = _ConfigScrapeOptions_Movie.bMainTitle
        _setup_Movie.chkTop250.Checked = _ConfigScrapeOptions_Movie.bMainTop250
        _setup_Movie.chkTrailer.Checked = _ConfigScrapeOptions_Movie.bMainTrailer
        _setup_Movie.chkWriters.Checked = _ConfigScrapeOptions_Movie.bMainWriters
        _setup_Movie.chkYear.Checked = _ConfigScrapeOptions_Movie.bMainYear

        _setup_Movie.cbForceTitleLanguage.Text = _SpecialSettings_Movie.ForceTitleLanguage
        _setup_Movie.chkCountryAbbreviation.Checked = _SpecialSettings_Movie.CountryAbbreviation
        _setup_Movie.chkFallBackworldwide.Checked = _SpecialSettings_Movie.FallBackWorldwide
        _setup_Movie.chkPartialTitles.Checked = _SpecialSettings_Movie.SearchPartialTitles
        _setup_Movie.chkPopularTitles.Checked = _SpecialSettings_Movie.SearchPopularTitles
        _setup_Movie.chkTvTitles.Checked = _SpecialSettings_Movie.SearchTvTitles
        _setup_Movie.chkVideoTitles.Checked = _SpecialSettings_Movie.SearchVideoTitles
        _setup_Movie.chkShortTitles.Checked = _SpecialSettings_Movie.SearchShortTitles
        _setup_Movie.chkStudiowithDistributors.Checked = _SpecialSettings_Movie.StudiowithDistributors

        _setup_Movie.orderChanged()

        SPanel.Name = String.Concat(_name, "_Movie")
        SPanel.Text = "IMDB"
        SPanel.Prefix = "IMDBMovieInfo_"
        SPanel.Order = 110
        SPanel.Parent = "pnlMovieData"
        SPanel.Type = Master.eLang.GetString(36, "Movies")
        SPanel.ImageIndex = If(_enabled, 9, 10)
        SPanel.Panel = _setup_Movie.pnlSettings

        AddHandler _setup_Movie.ModuleSettingsChanged, AddressOf Handle_ModuleSettingsChanged
        Return SPanel
    End Function

    'Function InjectSetupScraper_TV() As Containers.SettingsPanel Implements Interfaces.ScraperModule_Data_TV.InjectSetupScraper
    '    Dim SPanel As New Containers.SettingsPanel
    '    _setup_TV = New frmSettingsHolder_TV
    '    LoadSettings_TV()
    '    _setup_TV.chkEnabled.Checked = _ScraperEnabled_TV

    '    _setup_TV.chkScraperEpActors.Checked = _ConfigScrapeOptions_TV.bEpisodeActors
    '    _setup_TV.chkScraperEpAired.Checked = _ConfigScrapeOptions_TV.bEpisodeAired
    '    _setup_TV.chkScraperEpCredits.Checked = _ConfigScrapeOptions_TV.bEpisodeCredits
    '    _setup_TV.chkScraperEpDirectors.Checked = _ConfigScrapeOptions_TV.bEpisodeDirectors
    '    _setup_TV.chkScraperEpPlot.Checked = _ConfigScrapeOptions_TV.bEpisodePlot
    '    _setup_TV.chkScraperEpRating.Checked = _ConfigScrapeOptions_TV.bEpisodeRating
    '    _setup_TV.chkScraperEpTitle.Checked = _ConfigScrapeOptions_TV.bEpisodeTitle
    '    _setup_TV.chkScraperShowActors.Checked = _ConfigScrapeOptions_TV.bMainActors
    '    _setup_TV.chkScraperShowCertifications.Checked = _ConfigScrapeOptions_TV.bMainCertifications
    '    _setup_TV.chkScraperShowCountries.Checked = _ConfigScrapeOptions_TV.bMainCountries
    '    _setup_TV.chkScraperShowCreators.Checked = _ConfigScrapeOptions_TV.bMainCreators
    '    _setup_TV.chkScraperShowGenres.Checked = _ConfigScrapeOptions_TV.bMainGenres
    '    _setup_TV.chkScraperShowOriginalTitle.Checked = _ConfigScrapeOptions_TV.bMainOriginalTitle
    '    _setup_TV.chkScraperShowPlot.Checked = _ConfigScrapeOptions_TV.bMainPlot
    '    _setup_TV.chkScraperShowPremiered.Checked = _ConfigScrapeOptions_TV.bMainPremiered
    '    _setup_TV.chkScraperShowRating.Checked = _ConfigScrapeOptions_TV.bMainRating
    '    _setup_TV.chkScraperShowRuntime.Checked = _ConfigScrapeOptions_TV.bMainRuntime
    '    _setup_TV.chkScraperShowStudios.Checked = _ConfigScrapeOptions_TV.bMainStudios
    '    _setup_TV.chkScraperShowTitle.Checked = _ConfigScrapeOptions_TV.bMainTitle

    '    _setup_TV.cbForceTitleLanguage.Text = _SpecialSettings_TV.ForceTitleLanguage
    '    _setup_TV.chkFallBackworldwide.Checked = _SpecialSettings_TV.FallBackWorldwide

    '    _setup_TV.orderChanged()

    '    SPanel.Name = String.Concat(_name, "_TV")
    '    SPanel.Text = "IMDB"
    '    SPanel.Prefix = "IMDBTVInfo_"
    '    SPanel.Order = 110
    '    SPanel.Parent = "pnlTVData"
    '    SPanel.Type = Master.eLang.GetString(653, "TV Shows")
    '    SPanel.ImageIndex = If(_ScraperEnabled_TV, 9, 10)
    '    SPanel.Panel = _setup_TV.pnlSettings

    '    AddHandler _setup_TV.SetupScraperChanged, AddressOf Handle_SetupScraperChanged_TV
    '    AddHandler _setup_TV.ModuleSettingsChanged, AddressOf Handle_ModuleSettingsChanged_TV
    '    Return SPanel
    'End Function

    Sub LoadSettings_Movie()
        _ConfigScrapeOptions_Movie.bMainActors = AdvancedSettings.GetBooleanSetting("DoCast", True, , Enums.ContentType.Movie)
        _ConfigScrapeOptions_Movie.bMainCertifications = AdvancedSettings.GetBooleanSetting("DoCert", True, , Enums.ContentType.Movie)
        _ConfigScrapeOptions_Movie.bMainCountries = AdvancedSettings.GetBooleanSetting("DoCountry", True, , Enums.ContentType.Movie)
        _ConfigScrapeOptions_Movie.bMainDirectors = AdvancedSettings.GetBooleanSetting("DoDirector", True, , Enums.ContentType.Movie)
        _ConfigScrapeOptions_Movie.bMainGenres = AdvancedSettings.GetBooleanSetting("DoGenres", True, , Enums.ContentType.Movie)
        _ConfigScrapeOptions_Movie.bMainMPAA = AdvancedSettings.GetBooleanSetting("DoMPAA", True, , Enums.ContentType.Movie)
        _ConfigScrapeOptions_Movie.bMainOriginalTitle = AdvancedSettings.GetBooleanSetting("DoOriginalTitle", True, , Enums.ContentType.Movie)
        _ConfigScrapeOptions_Movie.bMainOutline = AdvancedSettings.GetBooleanSetting("DoOutline", True, , Enums.ContentType.Movie)
        _ConfigScrapeOptions_Movie.bMainPlot = AdvancedSettings.GetBooleanSetting("DoPlot", True, , Enums.ContentType.Movie)
        _ConfigScrapeOptions_Movie.bMainRating = AdvancedSettings.GetBooleanSetting("DoRating", True, , Enums.ContentType.Movie)
        _ConfigScrapeOptions_Movie.bMainRelease = AdvancedSettings.GetBooleanSetting("DoRelease", True, , Enums.ContentType.Movie)
        _ConfigScrapeOptions_Movie.bMainRuntime = AdvancedSettings.GetBooleanSetting("DoRuntime", True, , Enums.ContentType.Movie)
        _ConfigScrapeOptions_Movie.bMainStudios = AdvancedSettings.GetBooleanSetting("DoStudio", True, , Enums.ContentType.Movie)
        _ConfigScrapeOptions_Movie.bMainTagline = AdvancedSettings.GetBooleanSetting("DoTagline", True, , Enums.ContentType.Movie)
        _ConfigScrapeOptions_Movie.bMainTitle = AdvancedSettings.GetBooleanSetting("DoTitle", True, , Enums.ContentType.Movie)
        _ConfigScrapeOptions_Movie.bMainTop250 = AdvancedSettings.GetBooleanSetting("DoTop250", True, , Enums.ContentType.Movie)
        _ConfigScrapeOptions_Movie.bMainTrailer = AdvancedSettings.GetBooleanSetting("DoTrailer", True, , Enums.ContentType.Movie)
        _ConfigScrapeOptions_Movie.bMainWriters = AdvancedSettings.GetBooleanSetting("DoWriters", True, , Enums.ContentType.Movie)
        _ConfigScrapeOptions_Movie.bMainYear = AdvancedSettings.GetBooleanSetting("DoYear", True, , Enums.ContentType.Movie)

        _SpecialSettings_Movie.CountryAbbreviation = AdvancedSettings.GetBooleanSetting("CountryAbbreviation", False, , Enums.ContentType.Movie)
        _SpecialSettings_Movie.FallBackWorldwide = AdvancedSettings.GetBooleanSetting("FallBackWorldwide", False, , Enums.ContentType.Movie)
        _SpecialSettings_Movie.ForceTitleLanguage = AdvancedSettings.GetSetting("ForceTitleLanguage", String.Empty, , Enums.ContentType.Movie)
        _SpecialSettings_Movie.SearchPartialTitles = AdvancedSettings.GetBooleanSetting("SearchPartialTitles", True, , Enums.ContentType.Movie)
        _SpecialSettings_Movie.SearchPopularTitles = AdvancedSettings.GetBooleanSetting("SearchPopularTitles", True, , Enums.ContentType.Movie)
        _SpecialSettings_Movie.SearchTvTitles = AdvancedSettings.GetBooleanSetting("SearchTvTitles", False, , Enums.ContentType.Movie)
        _SpecialSettings_Movie.SearchVideoTitles = AdvancedSettings.GetBooleanSetting("SearchVideoTitles", False, , Enums.ContentType.Movie)
        _SpecialSettings_Movie.SearchShortTitles = AdvancedSettings.GetBooleanSetting("SearchShortTitles", False, , Enums.ContentType.Movie)
        _SpecialSettings_Movie.StudiowithDistributors = AdvancedSettings.GetBooleanSetting("StudiowithDistributors", False, , Enums.ContentType.Movie)
    End Sub

    Sub LoadSettings_TV()
        _ConfigScrapeOptions_TV.bEpisodeActors = AdvancedSettings.GetBooleanSetting("DoActors", True, , Enums.ContentType.TVEpisode)
        _ConfigScrapeOptions_TV.bEpisodeAired = AdvancedSettings.GetBooleanSetting("DoAired", True, , Enums.ContentType.TVEpisode)
        _ConfigScrapeOptions_TV.bEpisodeCredits = AdvancedSettings.GetBooleanSetting("DoCredits", True, , Enums.ContentType.TVEpisode)
        _ConfigScrapeOptions_TV.bEpisodeDirectors = AdvancedSettings.GetBooleanSetting("DoDirector", True, , Enums.ContentType.TVEpisode)
        _ConfigScrapeOptions_TV.bEpisodePlot = AdvancedSettings.GetBooleanSetting("DoPlot", True, , Enums.ContentType.TVEpisode)
        _ConfigScrapeOptions_TV.bEpisodeRating = AdvancedSettings.GetBooleanSetting("DoRating", True, , Enums.ContentType.TVEpisode)
        _ConfigScrapeOptions_TV.bEpisodeTitle = AdvancedSettings.GetBooleanSetting("DoTitle", True, , Enums.ContentType.TVEpisode)
        _ConfigScrapeOptions_TV.bMainActors = AdvancedSettings.GetBooleanSetting("DoActors", True, , Enums.ContentType.TVShow)
        _ConfigScrapeOptions_TV.bMainCertifications = AdvancedSettings.GetBooleanSetting("DoCert", True, , Enums.ContentType.TVShow)
        _ConfigScrapeOptions_TV.bMainCountries = AdvancedSettings.GetBooleanSetting("DoCountry", True, , Enums.ContentType.TVShow)
        _ConfigScrapeOptions_TV.bMainCreators = AdvancedSettings.GetBooleanSetting("DoCreator", True, , Enums.ContentType.TVShow)
        _ConfigScrapeOptions_TV.bMainGenres = AdvancedSettings.GetBooleanSetting("DoGenre", True, , Enums.ContentType.TVShow)
        _ConfigScrapeOptions_TV.bMainOriginalTitle = AdvancedSettings.GetBooleanSetting("DoOriginalTitle", True, , Enums.ContentType.TVShow)
        _ConfigScrapeOptions_TV.bMainPlot = AdvancedSettings.GetBooleanSetting("DoPlot", True, , Enums.ContentType.TVShow)
        _ConfigScrapeOptions_TV.bMainPremiered = AdvancedSettings.GetBooleanSetting("DoPremiered", True, , Enums.ContentType.TVShow)
        _ConfigScrapeOptions_TV.bMainRating = AdvancedSettings.GetBooleanSetting("DoRating", True, , Enums.ContentType.TVShow)
        _ConfigScrapeOptions_TV.bMainRuntime = AdvancedSettings.GetBooleanSetting("DoRuntime", True, , Enums.ContentType.TVShow)
        _ConfigScrapeOptions_TV.bMainStudios = AdvancedSettings.GetBooleanSetting("DoStudio", True, , Enums.ContentType.TVShow)
        _ConfigScrapeOptions_TV.bMainTitle = AdvancedSettings.GetBooleanSetting("DoTitle", True, , Enums.ContentType.TVShow)

        _SpecialSettings_TV.FallBackWorldwide = AdvancedSettings.GetBooleanSetting("FallBackWorldwide", False, , Enums.ContentType.TVShow)
        _SpecialSettings_TV.ForceTitleLanguage = AdvancedSettings.GetSetting("ForceTitleLanguage", String.Empty, , Enums.ContentType.TVShow)
    End Sub

    Sub SaveSettings_Movie()
        Using settings = New AdvancedSettings()
            settings.SetBooleanSetting("DoCast", _ConfigScrapeOptions_Movie.bMainActors, , , Enums.ContentType.Movie)
            settings.SetBooleanSetting("DoCert", _ConfigScrapeOptions_Movie.bMainCertifications, , , Enums.ContentType.Movie)
            settings.SetBooleanSetting("DoCountry", _ConfigScrapeOptions_Movie.bMainCountries, , , Enums.ContentType.Movie)
            settings.SetBooleanSetting("DoDirector", _ConfigScrapeOptions_Movie.bMainDirectors, , , Enums.ContentType.Movie)
            settings.SetBooleanSetting("DoGenres", _ConfigScrapeOptions_Movie.bMainGenres, , , Enums.ContentType.Movie)
            settings.SetBooleanSetting("DoMPAA", _ConfigScrapeOptions_Movie.bMainMPAA, , , Enums.ContentType.Movie)
            settings.SetBooleanSetting("DoOriginalTitle", _ConfigScrapeOptions_Movie.bMainOriginalTitle, , , Enums.ContentType.Movie)
            settings.SetBooleanSetting("DoOutline", _ConfigScrapeOptions_Movie.bMainOutline, , , Enums.ContentType.Movie)
            settings.SetBooleanSetting("DoPlot", _ConfigScrapeOptions_Movie.bMainPlot, , , Enums.ContentType.Movie)
            settings.SetBooleanSetting("DoRating", _ConfigScrapeOptions_Movie.bMainRating, , , Enums.ContentType.Movie)
            settings.SetBooleanSetting("DoRelease", _ConfigScrapeOptions_Movie.bMainRelease, , , Enums.ContentType.Movie)
            settings.SetBooleanSetting("DoRuntime", _ConfigScrapeOptions_Movie.bMainRuntime, , , Enums.ContentType.Movie)
            settings.SetBooleanSetting("DoStudio", _ConfigScrapeOptions_Movie.bMainStudios, , , Enums.ContentType.Movie)
            settings.SetBooleanSetting("DoTagline", _ConfigScrapeOptions_Movie.bMainTagline, , , Enums.ContentType.Movie)
            settings.SetBooleanSetting("DoTitle", _ConfigScrapeOptions_Movie.bMainTitle, , , Enums.ContentType.Movie)
            settings.SetBooleanSetting("DoTop250", _ConfigScrapeOptions_Movie.bMainTop250, , , Enums.ContentType.Movie)
            settings.SetBooleanSetting("DoTrailer", _ConfigScrapeOptions_Movie.bMainTrailer, , , Enums.ContentType.Movie)
            settings.SetBooleanSetting("DoWriters", _ConfigScrapeOptions_Movie.bMainWriters, , , Enums.ContentType.Movie)
            settings.SetBooleanSetting("DoYear", _ConfigScrapeOptions_Movie.bMainYear, , , Enums.ContentType.Movie)
            settings.SetBooleanSetting("CountryAbbreviation", _SpecialSettings_Movie.CountryAbbreviation, , , Enums.ContentType.Movie)
            settings.SetBooleanSetting("FallBackWorldwide", _SpecialSettings_Movie.FallBackWorldwide, , , Enums.ContentType.Movie)
            settings.SetBooleanSetting("SearchPartialTitles", _SpecialSettings_Movie.SearchPartialTitles, , , Enums.ContentType.Movie)
            settings.SetBooleanSetting("SearchPopularTitles", _SpecialSettings_Movie.SearchPopularTitles, , , Enums.ContentType.Movie)
            settings.SetBooleanSetting("SearchTvTitles", _SpecialSettings_Movie.SearchTvTitles, , , Enums.ContentType.Movie)
            settings.SetBooleanSetting("SearchVideoTitles", _SpecialSettings_Movie.SearchVideoTitles, , , Enums.ContentType.Movie)
            settings.SetBooleanSetting("SearchShortTitles", _SpecialSettings_Movie.SearchShortTitles, , , Enums.ContentType.Movie)
            settings.SetSetting("ForceTitleLanguage", _SpecialSettings_Movie.ForceTitleLanguage, , , Enums.ContentType.Movie)
            settings.SetBooleanSetting("StudiowithDistributors", _SpecialSettings_Movie.StudiowithDistributors, , , Enums.ContentType.Movie)
        End Using
    End Sub

    Sub SaveSettings_TV()
        Using settings = New AdvancedSettings()
            settings.SetBooleanSetting("DoActors", _ConfigScrapeOptions_TV.bEpisodeActors, , , Enums.ContentType.TVEpisode)
            settings.SetBooleanSetting("DoAired", _ConfigScrapeOptions_TV.bEpisodeAired, , , Enums.ContentType.TVEpisode)
            settings.SetBooleanSetting("DoCredits", _ConfigScrapeOptions_TV.bEpisodeCredits, , , Enums.ContentType.TVEpisode)
            settings.SetBooleanSetting("DoDirector", _ConfigScrapeOptions_TV.bEpisodeDirectors, , , Enums.ContentType.TVEpisode)
            settings.SetBooleanSetting("DoPlot", _ConfigScrapeOptions_TV.bEpisodePlot, , , Enums.ContentType.TVEpisode)
            settings.SetBooleanSetting("DoRating", _ConfigScrapeOptions_TV.bEpisodeRating, , , Enums.ContentType.TVEpisode)
            settings.SetBooleanSetting("DoTitle", _ConfigScrapeOptions_TV.bEpisodeTitle, , , Enums.ContentType.TVEpisode)
            settings.SetBooleanSetting("DoActors", _ConfigScrapeOptions_TV.bMainActors, , , Enums.ContentType.TVShow)
            settings.SetBooleanSetting("DoCert", _ConfigScrapeOptions_TV.bMainCertifications, , , Enums.ContentType.TVShow)
            settings.SetBooleanSetting("DoCountry", _ConfigScrapeOptions_TV.bMainCountries, , , Enums.ContentType.TVShow)
            settings.SetBooleanSetting("DoCreator", _ConfigScrapeOptions_TV.bMainCreators, , , Enums.ContentType.TVShow)
            settings.SetBooleanSetting("DoGenre", _ConfigScrapeOptions_TV.bMainGenres, , , Enums.ContentType.TVShow)
            settings.SetBooleanSetting("DoOriginalTitle", _ConfigScrapeOptions_TV.bMainOriginalTitle, , , Enums.ContentType.TVShow)
            settings.SetBooleanSetting("DoPlot", _ConfigScrapeOptions_TV.bMainPlot, , , Enums.ContentType.TVShow)
            settings.SetBooleanSetting("DoPremiered", _ConfigScrapeOptions_TV.bMainPremiered, , , Enums.ContentType.TVShow)
            settings.SetBooleanSetting("DoRating", _ConfigScrapeOptions_TV.bMainRating, , , Enums.ContentType.TVShow)
            settings.SetBooleanSetting("DoRuntime", _ConfigScrapeOptions_TV.bMainRuntime, , , Enums.ContentType.TVShow)
            settings.SetBooleanSetting("DoStudio", _ConfigScrapeOptions_TV.bMainStudios, , , Enums.ContentType.TVShow)
            settings.SetBooleanSetting("DoTitle", _ConfigScrapeOptions_TV.bMainTitle, , , Enums.ContentType.TVShow)
            settings.SetBooleanSetting("FallBackWorldwide", _SpecialSettings_TV.FallBackWorldwide, , , Enums.ContentType.TVShow)
            settings.SetSetting("ForceTitleLanguage", _SpecialSettings_TV.ForceTitleLanguage, , , Enums.ContentType.TVShow)
        End Using
    End Sub

    Sub SaveSetupScraper_Movie(ByVal DoDispose As Boolean) Implements Interfaces.ExternalModule.SaveSettings
        _ConfigScrapeOptions_Movie.bMainActors = _setup_Movie.chkActors.Checked
        _ConfigScrapeOptions_Movie.bMainCertifications = _setup_Movie.chkCertifications.Checked
        _ConfigScrapeOptions_Movie.bMainCountries = _setup_Movie.chkCountries.Checked
        _ConfigScrapeOptions_Movie.bMainDirectors = _setup_Movie.chkDirectors.Checked
        _ConfigScrapeOptions_Movie.bMainGenres = _setup_Movie.chkGenres.Checked
        _ConfigScrapeOptions_Movie.bMainMPAA = _setup_Movie.chkMPAA.Checked
        _ConfigScrapeOptions_Movie.bMainOriginalTitle = _setup_Movie.chkOriginalTitle.Checked
        _ConfigScrapeOptions_Movie.bMainOutline = _setup_Movie.chkOutline.Checked
        _ConfigScrapeOptions_Movie.bMainPlot = _setup_Movie.chkPlot.Checked
        _ConfigScrapeOptions_Movie.bMainRating = _setup_Movie.chkRating.Checked
        _ConfigScrapeOptions_Movie.bMainRelease = _setup_Movie.chkRelease.Checked
        _ConfigScrapeOptions_Movie.bMainRuntime = _setup_Movie.chkRuntime.Checked
        _ConfigScrapeOptions_Movie.bMainStudios = _setup_Movie.chkStudios.Checked
        _ConfigScrapeOptions_Movie.bMainTagline = _setup_Movie.chkTagline.Checked
        _ConfigScrapeOptions_Movie.bMainTitle = _setup_Movie.chkTitle.Checked
        _ConfigScrapeOptions_Movie.bMainTop250 = _setup_Movie.chkTop250.Checked
        _ConfigScrapeOptions_Movie.bMainTrailer = _setup_Movie.chkTrailer.Checked
        _ConfigScrapeOptions_Movie.bMainWriters = _setup_Movie.chkWriters.Checked
        _ConfigScrapeOptions_Movie.bMainYear = _setup_Movie.chkYear.Checked

        _SpecialSettings_Movie.CountryAbbreviation = _setup_Movie.chkCountryAbbreviation.Checked
        _SpecialSettings_Movie.FallBackWorldwide = _setup_Movie.chkFallBackworldwide.Checked
        _SpecialSettings_Movie.ForceTitleLanguage = _setup_Movie.cbForceTitleLanguage.Text
        _SpecialSettings_Movie.SearchPartialTitles = _setup_Movie.chkPartialTitles.Checked
        _SpecialSettings_Movie.SearchPopularTitles = _setup_Movie.chkPopularTitles.Checked
        _SpecialSettings_Movie.SearchTvTitles = _setup_Movie.chkTvTitles.Checked
        _SpecialSettings_Movie.SearchVideoTitles = _setup_Movie.chkVideoTitles.Checked
        _SpecialSettings_Movie.SearchShortTitles = _setup_Movie.chkShortTitles.Checked
        _SpecialSettings_Movie.StudiowithDistributors = _setup_Movie.chkStudiowithDistributors.Checked

        SaveSettings_Movie()

        _ConfigScrapeOptions_TV.bEpisodeActors = _setup_TV.chkScraperEpActors.Checked
        _ConfigScrapeOptions_TV.bEpisodeAired = _setup_TV.chkScraperEpAired.Checked
        _ConfigScrapeOptions_TV.bEpisodeCredits = _setup_TV.chkScraperEpCredits.Checked
        _ConfigScrapeOptions_TV.bEpisodeDirectors = _setup_TV.chkScraperEpDirectors.Checked
        _ConfigScrapeOptions_TV.bEpisodePlot = _setup_TV.chkScraperEpPlot.Checked
        _ConfigScrapeOptions_TV.bEpisodeRating = _setup_TV.chkScraperEpRating.Checked
        _ConfigScrapeOptions_TV.bEpisodeTitle = _setup_TV.chkScraperEpTitle.Checked
        _ConfigScrapeOptions_TV.bMainActors = _setup_TV.chkScraperShowActors.Checked
        _ConfigScrapeOptions_TV.bMainCertifications = _setup_TV.chkScraperShowCertifications.Checked
        _ConfigScrapeOptions_TV.bMainCountries = _setup_TV.chkScraperShowCountries.Checked
        _ConfigScrapeOptions_TV.bMainCreators = _setup_TV.chkScraperShowCreators.Checked
        _ConfigScrapeOptions_TV.bMainGenres = _setup_TV.chkScraperShowGenres.Checked
        _ConfigScrapeOptions_TV.bMainOriginalTitle = _setup_TV.chkScraperShowOriginalTitle.Checked
        _ConfigScrapeOptions_TV.bMainPlot = _setup_TV.chkScraperShowPlot.Checked
        _ConfigScrapeOptions_TV.bMainPremiered = _setup_TV.chkScraperShowPremiered.Checked
        _ConfigScrapeOptions_TV.bMainRating = _setup_TV.chkScraperShowRating.Checked
        _ConfigScrapeOptions_TV.bMainRuntime = _setup_TV.chkScraperShowRuntime.Checked
        _ConfigScrapeOptions_TV.bMainStudios = _setup_TV.chkScraperShowStudios.Checked
        _ConfigScrapeOptions_TV.bMainTitle = _setup_TV.chkScraperShowTitle.Checked

        _SpecialSettings_TV.FallBackWorldwide = _setup_TV.chkFallBackworldwide.Checked
        _SpecialSettings_TV.ForceTitleLanguage = _setup_TV.cbForceTitleLanguage.Text

        SaveSettings_TV()
        If DoDispose Then
            RemoveHandler _setup_Movie.ModuleSettingsChanged, AddressOf Handle_ModuleSettingsChanged
            _setup_Movie.Dispose()
            _setup_TV.Dispose()
        End If
    End Sub
    ''' <summary>
    '''  Scrape MovieDetails from IMDB
    ''' </summary>
    ''' <param name="tDBElement">Movie to be scraped. oDBMovie as ByRef to use existing data for identifing movie and to fill with IMDB/TMDB ID for next scraper</param>
    ''' <returns>Database.DBElement Object (nMovie) which contains the scraped data</returns>
    ''' <remarks></remarks>
    Function Scraper_Movie(ByRef tDBElement As Database.DBElement) As Interfaces.ModuleResult Implements Interfaces.ExternalModule.Run
        logger.Trace("[IMDB_Data] [Scraper_Movie] [Start]")

        Dim nModuleResult As New Interfaces.ModuleResult

        LoadSettings_Movie()

        Dim _scraper As New IMDB.Scraper(_SpecialSettings_Movie)
        Dim FilteredOptions As Structures.ScrapeOptions = Functions.ScrapeOptionsAndAlso(tDBElement.ScrapeOptions, _ConfigScrapeOptions_Movie)

        If tDBElement.ScrapeModifiers.MainNFO AndAlso Not tDBElement.ScrapeModifiers.DoSearch Then
            If Not String.IsNullOrEmpty(tDBElement.MainDetails.IMDB) Then
                'IMDB-ID already available -> scrape and save data into an empty movie container (nMovie)
                nModuleResult.ScraperResult_Data = _scraper.GetMovieInfo(tDBElement.MainDetails.IMDB, False, FilteredOptions)
            ElseIf Not tDBElement.ScrapeType = Enums.ScrapeType.SingleScrape Then
                'no IMDB-ID for movie --> search first!
                nModuleResult.ScraperResult_Data = _scraper.GetSearchMovieInfo(tDBElement.MainDetails.Title, tDBElement.MainDetails.Year, tDBElement, tDBElement.ScrapeType, FilteredOptions)
                'if still no search result -> exit
                If nModuleResult.ScraperResult_Data Is Nothing Then Return Nothing
            End If
        End If

        If nModuleResult.ScraperResult_Data Is Nothing Then
            Select Case tDBElement.ScrapeType
                Case Enums.ScrapeType.AllAuto, Enums.ScrapeType.FilterAuto, Enums.ScrapeType.MarkedAuto, Enums.ScrapeType.MissingAuto, Enums.ScrapeType.NewAuto, Enums.ScrapeType.SelectedAuto
                    Return nModuleResult
            End Select
        Else
            Return Nothing
        End If

        If tDBElement.ScrapeType = Enums.ScrapeType.SingleScrape OrElse tDBElement.ScrapeType = Enums.ScrapeType.SingleAuto Then
            If String.IsNullOrEmpty(tDBElement.MainDetails.IMDB) AndAlso String.IsNullOrEmpty(tDBElement.MainDetails.TMDB) Then
                Using dlgSearch As New dlgIMDBSearchResults_Movie(_SpecialSettings_Movie, _scraper)
                    If dlgSearch.ShowDialog(tDBElement.MainDetails.Title, tDBElement.MainDetails.Year, tDBElement.Filename, FilteredOptions) = DialogResult.OK Then
                        nModuleResult.ScraperResult_Data = _scraper.GetMovieInfo(dlgSearch.Result.IMDB, False, FilteredOptions)
                        'if a movie is found, set DoSearch back to "false" for following scrapers
                        Dim nScrapeModifiers = tDBElement.ScrapeModifiers
                        nScrapeModifiers.DoSearch = False
                        tDBElement.ScrapeModifiers = nScrapeModifiers
                    Else
                        Return Nothing
                    End If
                End Using
            End If
        End If

        logger.Trace("[IMDB_Data] [Scraper_Movie] [Done]")
        Return nModuleResult
    End Function
    ''' <summary>
    '''  Scrape MovieDetails from IMDB
    ''' </summary>
    ''' <param name="tDBElement">TV Show to be scraped. DBTV as ByRef to use existing data for identifing tv show and to fill with IMDB/TMDB/TVDB ID for next scraper</param>
    ''' <param name="Options">What kind of data is being requested from the scrape(global scraper settings)</param>
    ''' <returns>Database.DBElement Object (nMovie) which contains the scraped data</returns>
    ''' <remarks></remarks>
    Function Scraper_TV(ByRef tDBElement As Database.DBElement) As Interfaces.ModuleResult_Data_TVShow Implements Interfaces.ScraperModule_Data_TV.Scraper_TVShow
        logger.Trace("[IMDB_Data] [Scraper_TV] [Start]")

        LoadSettings_TV()

        Dim nTVShow As MediaContainers.MainDetails = Nothing
        Dim _scraper As New IMDB.Scraper(_SpecialSettings_TV)
        Dim FilteredOptions As Structures.ScrapeOptions = Functions.ScrapeOptionsAndAlso(tDBElement.ScrapeOptions, _ConfigScrapeOptions_TV)

        If tDBElement.ScrapeModifiers.MainNFO AndAlso Not tDBElement.ScrapeModifiers.DoSearch Then
            If tDBElement.MainDetails.IMDBSpecified Then
                'IMDB-ID already available -> scrape and save data into an empty tvshow container (nTVShow)
                nTVShow = _scraper.GetTVShowInfo(tDBElement.MainDetails.IMDB, tDBElement.ScrapeModifiers, FilteredOptions, False)
            ElseIf Not tDBElement.ScrapeType = Enums.ScrapeType.SingleScrape Then
                'no IMDB-ID for tvshow --> search first!
                nTVShow = _scraper.GetSearchTVShowInfo(tDBElement.MainDetails.Title, tDBElement, tDBElement.ScrapeType, tDBElement.ScrapeModifiers, FilteredOptions)
                'if still no search result -> exit
                If nTVShow Is Nothing Then Return New Interfaces.ModuleResult_Data_TVShow With {.Result = Nothing}
            End If
        End If

        If nTVShow Is Nothing Then
            Select Case tDBElement.ScrapeType
                Case Enums.ScrapeType.AllAuto, Enums.ScrapeType.FilterAuto, Enums.ScrapeType.MarkedAuto, Enums.ScrapeType.MissingAuto, Enums.ScrapeType.NewAuto, Enums.ScrapeType.SelectedAuto
                    Return New Interfaces.ModuleResult_Data_TVShow With {.Result = Nothing}
            End Select
        Else
            Return New Interfaces.ModuleResult_Data_TVShow With {.Result = nTVShow}
        End If

        If tDBElement.ScrapeType = Enums.ScrapeType.SingleScrape OrElse tDBElement.ScrapeType = Enums.ScrapeType.SingleAuto Then
            If Not tDBElement.MainDetails.IMDBSpecified Then
                Using dlgSearch As New dlgIMDBSearchResults_TV(_SpecialSettings_TV, _scraper)
                    If dlgSearch.ShowDialog(tDBElement.MainDetails.Title, tDBElement.ShowPath, tDBElement.ScrapeModifiers, FilteredOptions) = DialogResult.OK Then
                        nTVShow = _scraper.GetTVShowInfo(dlgSearch.Result.IMDB, tDBElement.ScrapeModifiers, FilteredOptions, False)
                        'if a tvshow is found, set DoSearch back to "false" for following scrapers
                        Dim nScrapeModifiers = tDBElement.ScrapeModifiers
                        nScrapeModifiers.DoSearch = False
                        tDBElement.ScrapeModifiers = nScrapeModifiers
                    Else
                        Return New Interfaces.ModuleResult_Data_TVShow With {.Cancelled = True, .Result = Nothing}
                    End If
                End Using
            End If
        End If

        logger.Trace("[IMDB_Data] [Scraper_TV] [Done]")
        Return New Interfaces.ModuleResult_Data_TVShow With {.Result = nTVShow}
    End Function

    Public Function Scraper_TVEpisode(ByRef tDBElement As Database.DBElement) As Interfaces.ModuleResult_Data_TVEpisode Implements Interfaces.ScraperModule_Data_TV.Scraper_TVEpisode
        logger.Trace("[IMDB_Data] [Scraper_TVEpisode] [Start]")

        LoadSettings_TV()

        Dim nTVEpisode As New MediaContainers.MainDetails
        Dim _scraper As New IMDB.Scraper(_SpecialSettings_TV)
        Dim FilteredOptions As Structures.ScrapeOptions = Functions.ScrapeOptionsAndAlso(tDBElement.ScrapeOptions, _ConfigScrapeOptions_TV)

        If tDBElement.MainDetails.IMDBSpecified Then
            nTVEpisode = _scraper.GetTVEpisodeInfo(tDBElement.MainDetails.IMDB, FilteredOptions)
        ElseIf tDBElement.TVShowDetails.IMDBSpecified AndAlso tDBElement.MainDetails.SeasonSpecified AndAlso tDBElement.MainDetails.EpisodeSpecified Then
            nTVEpisode = _scraper.GetTVEpisodeInfo(tDBElement.TVShowDetails.IMDB, tDBElement.MainDetails.Season, tDBElement.MainDetails.Episode, FilteredOptions)
        Else
            logger.Trace("[IMDB_Data] [Scraper_TVEpisode] [Abort] No Episode and TV Show IMDB ID available")
            Return New Interfaces.ModuleResult_Data_TVEpisode With {.Result = Nothing}
        End If

        logger.Trace("[IMDB_Data] [Scraper_TVEpisode] [Done]")
        Return New Interfaces.ModuleResult_Data_TVEpisode With {.Result = nTVEpisode}
    End Function

    Public Function Scraper_TVSeason(ByRef tDBElement As Database.DBElement) As Interfaces.ModuleResult_Data_TVSeason Implements Interfaces.ScraperModule_Data_TV.Scraper_TVSeason
        Return New Interfaces.ModuleResult_Data_TVSeason With {.Result = Nothing}
    End Function

    Public Sub ScraperOrderChanged_Movie() Implements Interfaces.ScraperModule_Data_Movie.ScraperOrderChanged
        _setup_Movie.orderChanged()
    End Sub

    Public Sub ScraperOrderChanged_tv() Implements Interfaces.ScraperModule_Data_TV.ScraperOrderChanged
        _setup_TV.orderChanged()
    End Sub

#End Region 'Methods

#Region "Nested Types"

    Structure SpecialSettings

#Region "Fields"

        Dim FallBackWorldwide As Boolean
        Dim ForceTitleLanguage As String
        Dim SearchPartialTitles As Boolean
        Dim SearchPopularTitles As Boolean
        Dim SearchTvTitles As Boolean
        Dim SearchVideoTitles As Boolean
        Dim SearchShortTitles As Boolean
        Dim CountryAbbreviation As Boolean
        Dim StudiowithDistributors As Boolean

#End Region 'Fields

    End Structure

#End Region 'Nested Types

End Class