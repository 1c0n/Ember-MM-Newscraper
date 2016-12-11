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

Public Class Addon
    Implements Interfaces.Addon


#Region "Fields"

    Shared logger As Logger = LogManager.GetCurrentClassLogger()

    Public Shared _AssemblyName As String

    Private _strPrivateAPIKey As String = String.Empty
    Private _SpecialSettings_Movie As New SpecialSettings
    Private _SpecialSettings_MovieSet As New SpecialSettings
    Private _SpecialSettings_TV As New SpecialSettings
    Private _name As String = "TMDB"
    Private _enabled As Boolean = True
    Private _settingspanel As frmSettingsPanel

#End Region 'Fields

#Region "Events"

    Public Event EnabledChanged(ByVal strName As String, ByVal bEnabled As Boolean) Implements Interfaces.Addon.EnabledChanged
    Public Event GenericEvent(ByVal eType As Enums.AddonEventType, ByRef _params As List(Of Object)) Implements Interfaces.Addon.GenericEvent
    Public Event NeedsRestart() Implements Interfaces.Addon.NeedsRestart
    Public Event SettingsChanged() Implements Interfaces.Addon.SettingsChanged

#End Region 'Events

#Region "Properties"

    Property Enabled() As Boolean Implements Interfaces.Addon.Enabled
        Get
            Return _enabled
        End Get
        Set(ByVal value As Boolean)
            _enabled = value
        End Set
    End Property

    Public ReadOnly Property Capabilities_AddonEventTypes() As List(Of Enums.AddonEventType) Implements Interfaces.Addon.Capabilities_AddonEventTypes
        Get
            Return New List(Of Enums.AddonEventType)(New Enums.AddonEventType() {
                                                      Enums.AddonEventType.Scrape_Movie,
                                                      Enums.AddonEventType.Scrape_MovieSet,
                                                      Enums.AddonEventType.Scrape_TVEpisode,
                                                      Enums.AddonEventType.Scrape_TVSeason,
                                                      Enums.AddonEventType.Scrape_TVShow,
                                                      Enums.AddonEventType.Search_Movie,
                                                      Enums.AddonEventType.Search_MovieSet,
                                                      Enums.AddonEventType.Search_TVEpisode,
                                                      Enums.AddonEventType.Search_TVSeason,
                                                      Enums.AddonEventType.Search_TVShow
                                                      })
        End Get
    End Property

    ReadOnly Property Capabilities_ScraperCapatibility() As List(Of Enums.ScraperCapatibility) Implements Interfaces.Addon.Capabilities_ScraperCapatibility
        Get
            Return New List(Of Enums.ScraperCapatibility)(New Enums.ScraperCapatibility() {
                                                       Enums.ScraperCapatibility.Movie_Data_Actors,
                                                       Enums.ScraperCapatibility.Movie_Data_Certifications,
                                                       Enums.ScraperCapatibility.Movie_Data_CollectionID,
                                                       Enums.ScraperCapatibility.Movie_Data_Countries,
                                                       Enums.ScraperCapatibility.Movie_Data_Directors,
                                                       Enums.ScraperCapatibility.Movie_Data_Genres,
                                                       Enums.ScraperCapatibility.Movie_Data_OriginalTitle,
                                                       Enums.ScraperCapatibility.Movie_Data_Plot,
                                                       Enums.ScraperCapatibility.Movie_Data_Rating,
                                                       Enums.ScraperCapatibility.Movie_Data_ReleaseDate,
                                                       Enums.ScraperCapatibility.Movie_Data_Runtime,
                                                       Enums.ScraperCapatibility.Movie_Data_Studios,
                                                       Enums.ScraperCapatibility.Movie_Data_Tagline,
                                                       Enums.ScraperCapatibility.Movie_Data_Title,
                                                       Enums.ScraperCapatibility.Movie_Data_Trailer,
                                                       Enums.ScraperCapatibility.Movie_Data_Writers,
                                                       Enums.ScraperCapatibility.Movie_Data_Year,
                                                       Enums.ScraperCapatibility.MovieSet_Data_Plot,
                                                       Enums.ScraperCapatibility.MovieSet_Data_Title,
                                                       Enums.ScraperCapatibility.TVEpisode_Data_Actors,
                                                       Enums.ScraperCapatibility.TVEpisode_Data_Aired,
                                                       Enums.ScraperCapatibility.TVEpisode_Data_Directors,
                                                       Enums.ScraperCapatibility.TVEpisode_Data_GuestStars,
                                                       Enums.ScraperCapatibility.TVEpisode_Data_Plot,
                                                       Enums.ScraperCapatibility.TVEpisode_Data_Rating,
                                                       Enums.ScraperCapatibility.TVEpisode_Data_Title,
                                                       Enums.ScraperCapatibility.TVEpisode_Data_Writers,
                                                       Enums.ScraperCapatibility.TVSeason_Data_Aired,
                                                       Enums.ScraperCapatibility.TVSeason_Data_Plot,
                                                       Enums.ScraperCapatibility.TVSeason_Data_Title,
                                                       Enums.ScraperCapatibility.TVShow_Data_Actors,
                                                       Enums.ScraperCapatibility.TVShow_Data_Certification,
                                                       Enums.ScraperCapatibility.TVShow_Data_Countries,
                                                       Enums.ScraperCapatibility.TVShow_Data_Creators,
                                                       Enums.ScraperCapatibility.TVShow_Data_Genres,
                                                       Enums.ScraperCapatibility.TVShow_Data_OriginalTitle,
                                                       Enums.ScraperCapatibility.TVShow_Data_Plot,
                                                       Enums.ScraperCapatibility.TVShow_Data_Premiered,
                                                       Enums.ScraperCapatibility.TVShow_Data_Rating,
                                                       Enums.ScraperCapatibility.TVShow_Data_Runtime,
                                                       Enums.ScraperCapatibility.TVShow_Data_Status,
                                                       Enums.ScraperCapatibility.TVShow_Data_Studios,
                                                       Enums.ScraperCapatibility.TVShow_Data_Title
                                                       })
        End Get
    End Property

    ReadOnly Property IsBusy() As Boolean Implements Interfaces.Addon.IsBusy
        Get
            Return False
        End Get
    End Property

    ReadOnly Property Name() As String Implements Interfaces.Addon.Name
        Get
            Return _name
        End Get
    End Property

    ReadOnly Property Version() As String Implements Interfaces.Addon.Version
        Get
            Return Diagnostics.FileVersionInfo.GetVersionInfo(Reflection.Assembly.GetExecutingAssembly.Location).FileVersion.ToString
        End Get
    End Property

#End Region 'Properties

#Region "Methods"

    Private Sub Handle_NeedsRestart()
        RaiseEvent NeedsRestart()
    End Sub

    Private Sub Handle_SettingsChanged()
        RaiseEvent SettingsChanged()
    End Sub

    Public Sub Init(ByVal sAssemblyName As String) Implements Interfaces.Addon.Init
        _AssemblyName = sAssemblyName
        LoadSettings()
    End Sub

    Public Function InjectSettingsPanel() As Containers.SettingsPanel Implements Interfaces.Addon.InjectSettingsPanel
        LoadSettings()
        Dim nSettingsPanel As New Containers.SettingsPanel
        _settingspanel = New frmSettingsPanel
        _settingspanel.chkFallBackToEng_Movie.Checked = _SpecialSettings_Movie.FallBackToEng
        _settingspanel.chkFallBackToEng_MovieSet.Checked = _SpecialSettings_MovieSet.FallBackToEng
        _settingspanel.chkFallBackToEng_TV.Checked = _SpecialSettings_TV.FallBackToEng
        _settingspanel.chkIncludeAdultItems_Movie.Checked = _SpecialSettings_Movie.IncludeAdultItems
        _settingspanel.chkIncludeAdultItems_MovieSet.Checked = _SpecialSettings_MovieSet.IncludeAdultItems
        _settingspanel.chkIncludeAdultItems_TV.Checked = _SpecialSettings_TV.IncludeAdultItems
        _settingspanel.chkSearchDeviant_Movie.Checked = _SpecialSettings_Movie.SearchDeviant
        _settingspanel.txtApiKey.Text = _strPrivateAPIKey

        nSettingsPanel.Image = My.Resources.logo_stacked_blue
        nSettingsPanel.ImageIndex = -1
        nSettingsPanel.Name = _name
        nSettingsPanel.Panel = _settingspanel.pnlSettings
        nSettingsPanel.Prefix = "TMDB_"
        nSettingsPanel.Text = "TMDB"
        nSettingsPanel.Type = Enums.SettingsPanelType.Addon

        AddHandler _settingspanel.NeedsRestart, AddressOf Handle_NeedsRestart
        AddHandler _settingspanel.SettingsChanged, AddressOf Handle_SettingsChanged
        Return nSettingsPanel
    End Function

    Public Sub LoadSettings()
        'Global
        _strPrivateAPIKey = AdvancedSettings.GetSetting("APIKey", String.Empty)

        'Movie
        _SpecialSettings_Movie.APIKey = If(String.IsNullOrEmpty(_strPrivateAPIKey), "44810eefccd9cb1fa1d57e7b0d67b08d", _strPrivateAPIKey)
        _SpecialSettings_Movie.FallBackToEng = AdvancedSettings.GetBooleanSetting("FallBackToEn", False, , Enums.ContentType.Movie)
        _SpecialSettings_Movie.IncludeAdultItems = AdvancedSettings.GetBooleanSetting("IncludeAdultItems", False, , Enums.ContentType.Movie)
        _SpecialSettings_Movie.SearchDeviant = AdvancedSettings.GetBooleanSetting("SearchDeviant", False, , Enums.ContentType.Movie)

        'MovieSet
        _SpecialSettings_MovieSet.APIKey = If(String.IsNullOrEmpty(_strPrivateAPIKey), "44810eefccd9cb1fa1d57e7b0d67b08d", _strPrivateAPIKey)
        _SpecialSettings_MovieSet.FallBackToEng = AdvancedSettings.GetBooleanSetting("FallBackToEn", False, , Enums.ContentType.MovieSet)
        _SpecialSettings_MovieSet.IncludeAdultItems = AdvancedSettings.GetBooleanSetting("IncludeAdultItems", False, , Enums.ContentType.MovieSet)

        'TV
        _SpecialSettings_TV.APIKey = If(String.IsNullOrEmpty(_strPrivateAPIKey), "44810eefccd9cb1fa1d57e7b0d67b08d", _strPrivateAPIKey)
        _SpecialSettings_TV.FallBackToEng = AdvancedSettings.GetBooleanSetting("FallBackToEn", False, , Enums.ContentType.TV)
        _SpecialSettings_TV.IncludeAdultItems = AdvancedSettings.GetBooleanSetting("IncludeAdultItems", False, , Enums.ContentType.TV)
    End Sub
    ''' <summary>
    '''  Scrape MovieDetails from TMDB
    ''' </summary>
    ''' <param name="tDBElement">Movie to be scraped. DBMovie as ByRef to use existing data for identifing movie and to fill with IMDB/TMDB ID for next scraper</param>
    ''' <returns>Database.DBElement Object (nMovie) which contains the scraped data</returns>
    ''' <remarks></remarks>
    Public Function Run(ByRef tDBElement As Database.DBElement, ByVal eAddonEventType As Enums.AddonEventType, ByVal lstParams As List(Of Object)) As Interfaces.AddonResult Implements Interfaces.Addon.Run
        logger.Trace("[TMDB_Data] [Scraper] [Start]")
        Dim nModuleResult As New Interfaces.AddonResult

        LoadSettings()

        Select Case tDBElement.ContentType
            Case Enums.ContentType.Movie
                _SpecialSettings_Movie.PrefLanguage = tDBElement.Language

                Dim _scraper As New TMDB.Scraper(_SpecialSettings_Movie)

                Dim FilteredOptions As Structures.ScrapeOptions = Functions.ScrapeOptionsAndAlso(tDBElement.ScrapeOptions, Master.DefaultOptions_Movie) 'Todo: fix

                If tDBElement.ScrapeModifiers.MainNFO AndAlso Not tDBElement.ScrapeModifiers.DoSearch Then
                    If tDBElement.MainDetails.TMDBSpecified Then
                        'TMDB-ID already available -> scrape and save data into an empty movie container (nMovie)
                        nModuleResult.ScraperResult_Data = _scraper.GetInfo_Movie(tDBElement.MainDetails.TMDB, FilteredOptions, False)
                    ElseIf tDBElement.MainDetails.IMDBSpecified Then
                        'IMDB-ID already available -> scrape and save data into an empty movie container (nMovie)
                        nModuleResult.ScraperResult_Data = _scraper.GetInfo_Movie(tDBElement.MainDetails.IMDB, FilteredOptions, False)
                    ElseIf Not tDBElement.ScrapeType = Enums.ScrapeType.SingleScrape Then
                        'no IMDB-ID or TMDB-ID for movie --> search first and try to get ID!
                        If tDBElement.MainDetails.TitleSpecified Then
                            nModuleResult.ScraperResult_Data = _scraper.GetSearchMovieInfo(tDBElement.MainDetails.Title, tDBElement, tDBElement.ScrapeType, FilteredOptions)
                        End If
                        'if still no search result -> exit
                        If nModuleResult.ScraperResult_Data Is Nothing Then
                            logger.Trace("[TMDB_Data] [Scraper_Movie] [Abort] No search result found")
                            Return Nothing
                        End If
                    End If
                End If

                If nModuleResult.ScraperResult_Data Is Nothing Then
                    Select Case tDBElement.ScrapeType
                        Case Enums.ScrapeType.AllAuto, Enums.ScrapeType.FilterAuto, Enums.ScrapeType.MarkedAuto, Enums.ScrapeType.MissingAuto, Enums.ScrapeType.NewAuto, Enums.ScrapeType.SelectedAuto
                            logger.Trace("[TMDB_Data] [Scraper_Movie] [Abort] No search result found")
                            Return Nothing
                    End Select
                Else
                    Return nModuleResult
                End If

                If tDBElement.ScrapeType = Enums.ScrapeType.SingleScrape OrElse tDBElement.ScrapeType = Enums.ScrapeType.SingleAuto Then
                    If Not tDBElement.MainDetails.TMDBSpecified Then
                        Using dlgSearch As New dlgTMDBSearchResults_Movie(_SpecialSettings_Movie, _scraper)
                            If dlgSearch.ShowDialog(tDBElement.MainDetails.Title, tDBElement.Filename, FilteredOptions, tDBElement.MainDetails.Year) = DialogResult.OK Then
                                nModuleResult.ScraperResult_Data = _scraper.GetInfo_Movie(dlgSearch.Result.TMDB, FilteredOptions, False)
                                'if a movie is found, set DoSearch back to "false" for following scrapers
                                Dim nScrapeModifiers = tDBElement.ScrapeModifiers
                                nScrapeModifiers.DoSearch = False
                                tDBElement.ScrapeModifiers = nScrapeModifiers
                            Else
                                logger.Trace(String.Format("[TMDB_Data] [Scraper_Movie] [Cancelled] Cancelled by user"))
                                Return Nothing
                            End If
                        End Using
                    End If
                End If
            Case Enums.ContentType.MovieSet

        End Select

        logger.Trace("[TMDB_Data] [Scraper_Movie] [Done]")
        Return nModuleResult
    End Function

    'Function Scraper_MovieSet(ByRef tDBElement As Database.DBElement) As Interfaces.ModuleResult_Data_MovieSet Implements Interfaces.ScraperModule_Data_MovieSet.Scraper
    '    logger.Trace("[TMDB_Data] [Scraper_MovieSet] [Start]")

    '    LoadSettings_MovieSet()
    '    _SpecialSettings_MovieSet.PrefLanguage = tDBElement.Language

    '    Dim nMovieSet As MediaContainers.MainDetails = Nothing
    '    Dim _scraper As New TMDB.Scraper(_SpecialSettings_MovieSet)

    '    Dim FilteredOptions As Structures.ScrapeOptions = Functions.ScrapeOptionsAndAlso(tDBElement.ScrapeOptions, ConfigScrapeOptions_MovieSet)

    '    If tDBElement.ScrapeModifiers.MainNFO AndAlso Not tDBElement.ScrapeModifiers.DoSearch Then
    '        If tDBElement.MainDetails.TMDBSpecified Then
    '            'TMDB-ID already available -> scrape and save data into an empty movieset container (nMovieSet)
    '            nMovieSet = _scraper.GetInfo_MovieSet(tDBElement.MainDetails.TMDB, FilteredOptions, False)
    '        ElseIf Not tDBElement.ScrapeType = Enums.ScrapeType.SingleScrape Then
    '            'no ITMDB-ID for movieset --> search first and try to get ID!
    '            If tDBElement.MainDetails.TitleSpecified Then
    '                nMovieSet = _scraper.GetSearchMovieSetInfo(tDBElement.MainDetails.Title, tDBElement, tDBElement.ScrapeType, FilteredOptions)
    '            End If
    '            'if still no search result -> exit
    '            If nMovieSet Is Nothing Then
    '                logger.Trace(String.Format("[TMDB_Data] [Scraper_MovieSet] [Abort] No search result found"))
    '                Return New Interfaces.ModuleResult_Data_MovieSet With {.Result = Nothing}
    '            End If
    '        End If
    '    End If

    '    If nMovieSet Is Nothing Then
    '        Select Case tDBElement.ScrapeType
    '            Case Enums.ScrapeType.AllAuto, Enums.ScrapeType.FilterAuto, Enums.ScrapeType.MarkedAuto, Enums.ScrapeType.MissingAuto, Enums.ScrapeType.NewAuto, Enums.ScrapeType.SelectedAuto
    '                logger.Trace(String.Format("[TMDB_Data] [Scraper_MovieSet] [Abort] No search result found"))
    '                Return New Interfaces.ModuleResult_Data_MovieSet With {.Result = Nothing}
    '        End Select
    '    Else
    '        Return New Interfaces.ModuleResult_Data_MovieSet With {.Result = nMovieSet}
    '    End If

    '    If tDBElement.ScrapeType = Enums.ScrapeType.SingleScrape OrElse tDBElement.ScrapeType = Enums.ScrapeType.SingleAuto Then
    '        If Not tDBElement.MainDetails.TMDBSpecified Then
    '            Using dlgSearch As New dlgTMDBSearchResults_MovieSet(_SpecialSettings_MovieSet, _scraper)
    '                If dlgSearch.ShowDialog(tDBElement.MainDetails.Title, FilteredOptions) = DialogResult.OK Then
    '                    nMovieSet = _scraper.GetInfo_MovieSet(dlgSearch.Result.TMDB, FilteredOptions, False)
    '                    'if a movieset is found, set DoSearch back to "false" for following scrapers
    '                    Dim nScrapeModifiers = tDBElement.ScrapeModifiers
    '                    nScrapeModifiers.DoSearch = False
    '                    tDBElement.ScrapeModifiers = nScrapeModifiers
    '                Else
    '                    logger.Trace(String.Format("[TMDB_Data] [Scraper_MovieSet] [Cancelled] Cancelled by user"))
    '                    Return New Interfaces.ModuleResult_Data_MovieSet With {.Cancelled = True, .Result = Nothing}
    '                End If
    '            End Using
    '        End If
    '    End If

    '    logger.Trace("[TMDB_Data] [Scraper_MovieSet] [Done]")
    '    Return New Interfaces.ModuleResult_Data_MovieSet With {.Result = nMovieSet}
    'End Function
    '''' <summary>
    ''''  Scrape MovieDetails from TMDB
    '''' </summary>
    '''' <param name="tDBElement">TV Show to be scraped. DBTV as ByRef to use existing data for identifing tv show and to fill with IMDB/TMDB/TVDB ID for next scraper</param> 
    '''' <returns>Database.DBElement Object (nMovie) which contains the scraped data</returns>
    '''' <remarks></remarks>
    'Function Scraper_TV(ByRef tDBElement As Database.DBElement) As Interfaces.ModuleResult_Data_TVShow Implements Interfaces.ScraperModule_Data_TV.Scraper_TVShow
    '    logger.Trace("[TMDB_Data] [Scraper_TV] [Start]")

    '    LoadSettings_TV()
    '    _SpecialSettings_TV.PrefLanguage = tDBElement.Language

    '    Dim nTVShow As MediaContainers.MainDetails = Nothing
    '    Dim _scraper As New TMDB.Scraper(_SpecialSettings_TV)

    '    Dim FilteredOptions As Structures.ScrapeOptions = Functions.ScrapeOptionsAndAlso(tDBElement.ScrapeOptions, ConfigScrapeOptions_TV)

    '    If tDBElement.ScrapeModifiers.MainNFO AndAlso Not tDBElement.ScrapeModifiers.DoSearch Then
    '        If tDBElement.MainDetails.TMDBSpecified Then
    '            'TMDB-ID already available -> scrape and save data into an empty tv show container (nShow)
    '            nTVShow = _scraper.GetInfo_TVShow(tDBElement.MainDetails.TMDB, tDBElement.ScrapeModifiers, FilteredOptions, False)
    '        ElseIf tDBElement.MainDetails.TVDBSpecified Then
    '            tDBElement.MainDetails.TMDB = _scraper.GetTMDBbyTVDB(tDBElement.MainDetails.TVDB)
    '            If Not tDBElement.MainDetails.TMDBSpecified Then Return New Interfaces.ModuleResult_Data_TVShow With {.Result = Nothing}
    '            nTVShow = _scraper.GetInfo_TVShow(tDBElement.MainDetails.TMDB, tDBElement.ScrapeModifiers, FilteredOptions, False)
    '        ElseIf tDBElement.MainDetails.IMDBSpecified Then
    '            tDBElement.MainDetails.TMDB = _scraper.GetTMDBbyIMDB(tDBElement.MainDetails.IMDB)
    '            If Not tDBElement.MainDetails.TMDBSpecified Then Return New Interfaces.ModuleResult_Data_TVShow With {.Result = Nothing}
    '            nTVShow = _scraper.GetInfo_TVShow(tDBElement.MainDetails.TMDB, tDBElement.ScrapeModifiers, FilteredOptions, False)
    '        ElseIf Not tDBElement.ScrapeType = Enums.ScrapeType.SingleScrape Then
    '            'no TVDB-ID for tv show --> search first and try to get ID!
    '            If tDBElement.MainDetails.TitleSpecified Then
    '                nTVShow = _scraper.GetSearchTVShowInfo(tDBElement.MainDetails.Title, tDBElement, tDBElement.ScrapeType, tDBElement.ScrapeModifiers, FilteredOptions)
    '            End If
    '            'if still no search result -> exit
    '            If nTVShow Is Nothing Then
    '                logger.Trace(String.Format("[TMDB_Data] [Scraper_TV] [Abort] No search result found"))
    '                Return New Interfaces.ModuleResult_Data_TVShow With {.Result = Nothing}
    '            End If
    '        End If
    '    End If

    '    If nTVShow Is Nothing Then
    '        Select Case tDBElement.ScrapeType
    '            Case Enums.ScrapeType.AllAuto, Enums.ScrapeType.FilterAuto, Enums.ScrapeType.MarkedAuto, Enums.ScrapeType.MissingAuto, Enums.ScrapeType.NewAuto, Enums.ScrapeType.SelectedAuto
    '                logger.Trace(String.Format("[TMDB_Data] [Scraper_TV] [Abort] No search result found"))
    '                Return New Interfaces.ModuleResult_Data_TVShow With {.Result = Nothing}
    '        End Select
    '    Else
    '        Return New Interfaces.ModuleResult_Data_TVShow With {.Result = nTVShow}
    '    End If

    '    If tDBElement.ScrapeType = Enums.ScrapeType.SingleScrape OrElse tDBElement.ScrapeType = Enums.ScrapeType.SingleAuto Then
    '        If Not tDBElement.MainDetails.TMDBSpecified Then
    '            Using dlgSearch As New dlgTMDBSearchResults_TV(_SpecialSettings_TV, _scraper)
    '                If dlgSearch.ShowDialog(tDBElement.MainDetails.Title, tDBElement.ShowPath, FilteredOptions) = DialogResult.OK Then
    '                    nTVShow = _scraper.GetInfo_TVShow(dlgSearch.Result.TMDB, tDBElement.ScrapeModifiers, FilteredOptions, False)
    '                    'if a tvshow is found, set DoSearch back to "false" for following scrapers
    '                    Dim nScrapeModifiers = tDBElement.ScrapeModifiers
    '                    nScrapeModifiers.DoSearch = False
    '                    tDBElement.ScrapeModifiers = nScrapeModifiers
    '                Else
    '                    logger.Trace(String.Format("[TMDB_Data] [Scraper_TV] [Cancelled] Cancelled by user"))
    '                    Return New Interfaces.ModuleResult_Data_TVShow With {.Cancelled = True, .Result = Nothing}
    '                End If
    '            End Using
    '        End If
    '    End If

    '    logger.Trace("[TMDB_Data] [Scraper_TV] [Done]")
    '    Return New Interfaces.ModuleResult_Data_TVShow With {.Result = nTVShow}
    'End Function

    'Public Function Scraper_TVEpisode(ByRef tDBElement As Database.DBElement) As Interfaces.ModuleResult_Data_TVEpisode Implements Interfaces.ScraperModule_Data_TV.Scraper_TVEpisode
    '    logger.Trace("[TMDB_Data] [Scraper_TVEpisode] [Start]")

    '    LoadSettings_TV()
    '    _SpecialSettings_TV.PrefLanguage = tDBElement.Language

    '    Dim nTVEpisode As New MediaContainers.MainDetails
    '    Dim _scraper As New TMDB.Scraper(_SpecialSettings_TV)

    '    Dim FilteredOptions As Structures.ScrapeOptions = Functions.ScrapeOptionsAndAlso(tDBElement.ScrapeOptions, ConfigScrapeOptions_TV)

    '    If Not tDBElement.TVShowDetails.TMDBSpecified AndAlso tDBElement.TVShowDetails.TVDBSpecified Then
    '        tDBElement.TVShowDetails.TMDB = _scraper.GetTMDBbyTVDB(tDBElement.TVShowDetails.TVDB)
    '    End If

    '    If tDBElement.TVShowDetails.TMDBSpecified Then
    '        If Not tDBElement.MainDetails.Episode = -1 AndAlso Not tDBElement.MainDetails.Season = -1 Then
    '            nTVEpisode = _scraper.GetInfo_TVEpisode(CInt(tDBElement.TVShowDetails.TMDB), tDBElement.MainDetails.Season, tDBElement.MainDetails.Episode, FilteredOptions)
    '        ElseIf tDBElement.MainDetails.AiredSpecified Then
    '            nTVEpisode = _scraper.GetInfo_TVEpisode(CInt(tDBElement.TVShowDetails.TMDB), tDBElement.MainDetails.Aired, FilteredOptions)
    '        Else
    '            logger.Trace(String.Format("[TMDB_Data] [Scraper_TVEpisode] [Abort] No search result found"))
    '            Return New Interfaces.ModuleResult_Data_TVEpisode With {.Result = Nothing}
    '        End If
    '        'if still no search result -> exit
    '        If nTVEpisode Is Nothing Then
    '            logger.Trace(String.Format("[TMDB_Data] [Scraper_TVEpisode] [Abort] No search result found"))
    '            Return New Interfaces.ModuleResult_Data_TVEpisode With {.Result = Nothing}
    '        End If
    '    Else
    '        logger.Trace(String.Format("[TMDB_Data] [Scraper_TVEpisode] [Abort] No TV Show TMDB ID available"))
    '        Return New Interfaces.ModuleResult_Data_TVEpisode With {.Result = Nothing}
    '    End If

    '    logger.Trace("[TMDB_Data] [Scraper_TVEpisode] [Done]")
    '    Return New Interfaces.ModuleResult_Data_TVEpisode With {.Result = nTVEpisode}
    'End Function

    'Public Function Scraper_TVSeason(ByRef tDBElement As Database.DBElement) As Interfaces.ModuleResult_Data_TVSeason Implements Interfaces.ScraperModule_Data_TV.Scraper_TVSeason
    '    logger.Trace("[TMDB_Data] [Scraper_TVSeason] [Start]")

    '    LoadSettings_TV()
    '    _SpecialSettings_TV.PrefLanguage = tDBElement.Language

    '    Dim nTVSeason As New MediaContainers.MainDetails
    '    Dim _scraper As New TMDB.Scraper(_SpecialSettings_TV)

    '    Dim FilteredOptions As Structures.ScrapeOptions = Functions.ScrapeOptionsAndAlso(tDBElement.ScrapeOptions, ConfigScrapeOptions_TV)

    '    If Not tDBElement.TVShowDetails.TMDBSpecified AndAlso tDBElement.TVShowDetails.TVDBSpecified Then
    '        tDBElement.TVShowDetails.TMDB = _scraper.GetTMDBbyTVDB(tDBElement.TVShowDetails.TVDB)
    '    End If

    '    If tDBElement.TVShowDetails.TMDBSpecified Then
    '        If tDBElement.MainDetails.SeasonSpecified Then
    '            nTVSeason = _scraper.GetInfo_TVSeason(CInt(tDBElement.TVShowDetails.TMDB), tDBElement.MainDetails.Season, FilteredOptions)
    '        Else
    '            logger.Trace(String.Format("[TMDB_Data] [Scraper_TVSeason] [Abort] Season is not specified"))
    '            Return New Interfaces.ModuleResult_Data_TVSeason With {.Result = Nothing}
    '        End If
    '        'if still no search result -> exit
    '        If nTVSeason Is Nothing Then
    '            logger.Trace(String.Format("[TMDB_Data] [Scraper_TVSeason] [Abort] No search result found"))
    '            Return New Interfaces.ModuleResult_Data_TVSeason With {.Result = Nothing}
    '        End If
    '    Else
    '        logger.Trace(String.Format("[TMDB_Data] [Scraper_TVSeason] [Abort] No TV Show TMDB ID available"))
    '        Return New Interfaces.ModuleResult_Data_TVSeason With {.Result = Nothing}
    '    End If

    '    logger.Trace("[TMDB_Data] [Scraper_TVSeason] [Done]")
    '    Return New Interfaces.ModuleResult_Data_TVSeason With {.Result = nTVSeason}
    'End Function

    Public Sub SaveSettings()
        Using settings = New AdvancedSettings()
            'Global
            settings.SetSetting("APIKey", _settingspanel.txtApiKey.Text)

            'Movie
            settings.SetBooleanSetting("FallBackToEn", _SpecialSettings_Movie.FallBackToEng, , , Enums.ContentType.Movie)
            settings.SetBooleanSetting("IncludeAdultItems", _SpecialSettings_Movie.IncludeAdultItems, , , Enums.ContentType.Movie)
            settings.SetBooleanSetting("SearchDeviant", _SpecialSettings_Movie.SearchDeviant, , , Enums.ContentType.Movie)

            'MovieSet
            settings.SetBooleanSetting("FallBackToEn", _SpecialSettings_MovieSet.FallBackToEng, , , Enums.ContentType.MovieSet)
            settings.SetBooleanSetting("IncludeAdultItems", _SpecialSettings_MovieSet.IncludeAdultItems, , , Enums.ContentType.MovieSet)

            'TV
            settings.SetBooleanSetting("FallBackToEn", _SpecialSettings_TV.FallBackToEng, , , Enums.ContentType.TV)
            settings.SetBooleanSetting("IncludeAdultItems", _SpecialSettings_TV.IncludeAdultItems, , , Enums.ContentType.TV)
        End Using
    End Sub

    Public Sub SaveSetup(ByVal DoDispose As Boolean) Implements Interfaces.Addon.SaveSetup
        'Movie
        _SpecialSettings_Movie.FallBackToEng = _settingspanel.chkFallBackToEng_Movie.Checked
        _SpecialSettings_Movie.IncludeAdultItems = _settingspanel.chkIncludeAdultItems_Movie.Checked
        _SpecialSettings_Movie.SearchDeviant = _settingspanel.chkSearchDeviant_Movie.Checked

        'MovieSet
        _SpecialSettings_MovieSet.FallBackToEng = _settingspanel.chkFallBackToEng_MovieSet.Checked
        _SpecialSettings_MovieSet.IncludeAdultItems = _settingspanel.chkIncludeAdultItems_MovieSet.Checked

        'TV
        _SpecialSettings_TV.FallBackToEng = _settingspanel.chkFallBackToEng_TV.Checked
        _SpecialSettings_TV.IncludeAdultItems = _settingspanel.chkIncludeAdultItems_TV.Checked

        SaveSettings()
        If DoDispose Then
            RemoveHandler _settingspanel.SettingsChanged, AddressOf Handle_SettingsChanged
            _settingspanel.Dispose()
        End If
    End Sub

#End Region 'Methods

#Region "Nested Types"

    Structure SpecialSettings

#Region "Fields"

        Dim APIKey As String
        Dim FallBackToEng As Boolean
        Dim IncludeAdultItems As Boolean
        Dim PrefLanguage As String
        Dim SearchDeviant As Boolean

#End Region 'Fields

    End Structure

#End Region 'Nested Types

End Class