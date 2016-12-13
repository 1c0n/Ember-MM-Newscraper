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
Imports System.Xml.Serialization
Imports System.Net
Imports System.Drawing
Imports System.Windows.Forms
Imports NLog

Public Class Settings

#Region "Fields"

    Shared logger As Logger = LogManager.GetCurrentClassLogger()
    Private Shared _XMLSettings As New clsXMLSettings

#End Region 'Fields

#Region "Constructors"

    Public Sub New()
        SetDefaults()
    End Sub

#End Region 'Constructors

    'Trick: all the data is now in the shared private variable _XMLSettings. To avoid changing EVERY reference to a settings
    ' we create here property stubs that read the corresponding property of the _XMLSettings

#Region "Properties"

    Public Property MovieClearArtPrefSize() As Enums.MovieClearArtSize
        Get
            Return _XMLSettings.MovieClearArtPrefSize
        End Get
        Set(ByVal value As Enums.MovieClearArtSize)
            _XMLSettings.MovieClearArtPrefSize = value
        End Set
    End Property

    Public Property MovieClearArtPrefSizeOnly() As Boolean
        Get
            Return _XMLSettings.MovieClearArtPrefSizeOnly
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieClearArtPrefSizeOnly = value
        End Set
    End Property

    Public Property MovieClearLogoPrefSize() As Enums.MovieClearLogoSize
        Get
            Return _XMLSettings.MovieClearLogoPrefSize
        End Get
        Set(ByVal value As Enums.MovieClearLogoSize)
            _XMLSettings.MovieClearLogoPrefSize = value
        End Set
    End Property

    Public Property MovieClearLogoPrefSizeOnly() As Boolean
        Get
            Return _XMLSettings.MovieClearLogoPrefSizeOnly
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieClearLogoPrefSizeOnly = value
        End Set
    End Property

    Public Property MovieDiscArtPrefSize() As Enums.MovieDiscArtSize
        Get
            Return _XMLSettings.MovieDiscArtPrefSize
        End Get
        Set(ByVal value As Enums.MovieDiscArtSize)
            _XMLSettings.MovieDiscArtPrefSize = value
        End Set
    End Property

    Public Property MovieDiscArtPrefSizeOnly() As Boolean
        Get
            Return _XMLSettings.MovieDiscArtPrefSizeOnly
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieDiscArtPrefSizeOnly = value
        End Set
    End Property

    Public Property MovieLandscapePrefSize() As Enums.MovieLandscapeSize
        Get
            Return _XMLSettings.MovieLandscapePrefSize
        End Get
        Set(ByVal value As Enums.MovieLandscapeSize)
            _XMLSettings.MovieLandscapePrefSize = value
        End Set
    End Property

    Public Property MovieLandscapePrefSizeOnly() As Boolean
        Get
            Return _XMLSettings.MovieLandscapePrefSizeOnly
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieLandscapePrefSizeOnly = value
        End Set
    End Property

    Public Property TVShowCharacterArtPrefSize() As Enums.TVCharacterArtSize
        Get
            Return _XMLSettings.TVShowCharacterArtPrefSize
        End Get
        Set(ByVal value As Enums.TVCharacterArtSize)
            _XMLSettings.TVShowCharacterArtPrefSize = value
        End Set
    End Property

    Public Property TVShowCharacterArtPrefSizeOnly() As Boolean
        Get
            Return _XMLSettings.TVShowCharacterArtPrefSizeOnly
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVShowCharacterArtPrefSizeOnly = value
        End Set
    End Property

    Public Property TVShowClearArtPrefSize() As Enums.TVClearArtSize
        Get
            Return _XMLSettings.TVShowClearArtPrefSize
        End Get
        Set(ByVal value As Enums.TVClearArtSize)
            _XMLSettings.TVShowClearArtPrefSize = value
        End Set
    End Property

    Public Property TVShowClearArtPrefSizeOnly() As Boolean
        Get
            Return _XMLSettings.TVShowClearArtPrefSizeOnly
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVShowClearArtPrefSizeOnly = value
        End Set
    End Property

    Public Property TVShowClearLogoPrefSize() As Enums.TVClearLogoSize
        Get
            Return _XMLSettings.TVShowClearLogoPrefSize
        End Get
        Set(ByVal value As Enums.TVClearLogoSize)
            _XMLSettings.TVShowClearLogoPrefSize = value
        End Set
    End Property

    Public Property TVShowClearLogoPrefSizeOnly() As Boolean
        Get
            Return _XMLSettings.TVShowClearLogoPrefSizeOnly
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVShowClearLogoPrefSizeOnly = value
        End Set
    End Property

    Public Property TVShowLandscapePrefSize() As Enums.TVLandscapeSize
        Get
            Return _XMLSettings.TVShowLandscapePrefSize
        End Get
        Set(ByVal value As Enums.TVLandscapeSize)
            _XMLSettings.TVShowLandscapePrefSize = value
        End Set
    End Property

    Public Property TVShowLandscapePrefSizeOnly() As Boolean
        Get
            Return _XMLSettings.TVShowLandscapePrefSizeOnly
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVShowLandscapePrefSizeOnly = value
        End Set
    End Property

    Public Property TVSeasonLandscapePrefSize() As Enums.TVLandscapeSize
        Get
            Return _XMLSettings.TVSeasonLandscapePrefSize
        End Get
        Set(ByVal value As Enums.TVLandscapeSize)
            _XMLSettings.TVSeasonLandscapePrefSize = value
        End Set
    End Property

    Public Property TVSeasonLandscapePrefSizeOnly() As Boolean
        Get
            Return _XMLSettings.TVSeasonLandscapePrefSizeOnly
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVSeasonLandscapePrefSizeOnly = value
        End Set
    End Property

    Public Property MovieSetClearArtPrefSize() As Enums.MovieClearArtSize
        Get
            Return _XMLSettings.MovieSetClearArtPrefSize
        End Get
        Set(ByVal value As Enums.MovieClearArtSize)
            _XMLSettings.MovieSetClearArtPrefSize = value
        End Set
    End Property

    Public Property MovieSetClearArtPrefSizeOnly() As Boolean
        Get
            Return _XMLSettings.MovieSetClearArtPrefSizeOnly
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieSetClearArtPrefSizeOnly = value
        End Set
    End Property

    Public Property MovieSetClearlogoPrefSize() As Enums.MovieClearLogoSize
        Get
            Return _XMLSettings.MovieSetClearlogoPrefSize
        End Get
        Set(ByVal value As Enums.MovieClearLogoSize)
            _XMLSettings.MovieSetClearlogoPrefSize = value
        End Set
    End Property

    Public Property MovieSetClearLogoPrefSizeOnly() As Boolean
        Get
            Return _XMLSettings.MovieSetClearLogoPrefSizeOnly
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieSetClearLogoPrefSizeOnly = value
        End Set
    End Property

    Public Property MovieSetDiscArtPrefSize() As Enums.MovieDiscArtSize
        Get
            Return _XMLSettings.MovieSetDiscArtPrefSize
        End Get
        Set(ByVal value As Enums.MovieDiscArtSize)
            _XMLSettings.MovieSetDiscArtPrefSize = value
        End Set
    End Property

    Public Property MovieSetDiscArtPrefSizeOnly() As Boolean
        Get
            Return _XMLSettings.MovieSetDiscArtPrefSizeOnly
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieSetDiscArtPrefSizeOnly = value
        End Set
    End Property

    Public Property MovieSetLandscapePrefSize() As Enums.MovieLandscapeSize
        Get
            Return _XMLSettings.MovieSetLandscapePrefSize
        End Get
        Set(ByVal value As Enums.MovieLandscapeSize)
            _XMLSettings.MovieSetLandscapePrefSize = value
        End Set
    End Property

    Public Property MovieSetLandscapePrefSizeOnly() As Boolean
        Get
            Return _XMLSettings.MovieSetLandscapePrefSizeOnly
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieSetLandscapePrefSizeOnly = value
        End Set
    End Property

    Public Property MovieScraperCastLimit() As Integer
        Get
            Return _XMLSettings.MovieScraperCastLimit
        End Get
        Set(ByVal value As Integer)
            _XMLSettings.MovieScraperCastLimit = value
        End Set
    End Property

    Public Property MovieActorThumbsKeepExisting() As Boolean
        Get
            Return _XMLSettings.MovieActorThumbsKeepExisting
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieActorThumbsKeepExisting = value
        End Set
    End Property

    Public Property TVAllSeasonsPosterHeight() As Integer
        Get
            Return _XMLSettings.TVAllSeasonsPosterHeight
        End Get
        Set(ByVal value As Integer)
            _XMLSettings.TVAllSeasonsPosterHeight = value
        End Set
    End Property

    Public Property TVAllSeasonsPosterWidth() As Integer
        Get
            Return _XMLSettings.TVAllSeasonsPosterWidth
        End Get
        Set(ByVal value As Integer)
            _XMLSettings.TVAllSeasonsPosterWidth = value
        End Set
    End Property

    Public Property GeneralShowGenresText() As Boolean
        Get
            Return _XMLSettings.GeneralShowGenresText
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.GeneralShowGenresText = value
        End Set
    End Property

    Public Property MovieGeneralLanguage() As String
        Get
            Return _XMLSettings.MovieGeneralLanguage
        End Get
        Set(ByVal value As String)
            _XMLSettings.MovieGeneralLanguage = If(String.IsNullOrEmpty(value), "en-US", value)
        End Set
    End Property

    Public Property TVGeneralLanguage() As String
        Get
            Return _XMLSettings.TVGeneralLanguage
        End Get
        Set(ByVal value As String)
            _XMLSettings.TVGeneralLanguage = If(String.IsNullOrEmpty(value), "en-US", value)
        End Set
    End Property

    Public Property MovieClickScrape() As Boolean
        Get
            Return _XMLSettings.MovieClickScrape
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieClickScrape = value
        End Set
    End Property

    Public Property MovieClickScrapeAsk() As Boolean
        Get
            Return _XMLSettings.MovieClickScrapeAsk
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieClickScrapeAsk = value
        End Set
    End Property

    Public Property MovieBackdropsAuto() As Boolean
        Get
            Return _XMLSettings.MovieBackdropsAuto
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieBackdropsAuto = value
        End Set
    End Property

    Public Property MovieIMDBURL() As String
        Get
            Return _XMLSettings.MovieIMDBURL
        End Get
        Set(ByVal value As String)
            _XMLSettings.MovieIMDBURL = value
        End Set
    End Property

    Public Property MovieBackdropsPath() As String
        Get
            Return _XMLSettings.MovieBackdropsPath
        End Get
        Set(ByVal value As String)
            _XMLSettings.MovieBackdropsPath = value
        End Set
    End Property

    Public Property MovieScraperCastWithImgOnly() As Boolean
        Get
            Return _XMLSettings.MovieScraperCastWithImgOnly
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieScraperCastWithImgOnly = value
        End Set
    End Property

    Public Property MovieScraperCertLang() As String
        Get
            Return _XMLSettings.MovieScraperCertLang
        End Get
        Set(ByVal value As String)
            _XMLSettings.MovieScraperCertLang = value
        End Set
    End Property

    Public Property GeneralCheckUpdates() As Boolean
        Get
            Return _XMLSettings.GeneralCheckUpdates
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.GeneralCheckUpdates = value
        End Set
    End Property

    Public Property MovieCleanDB() As Boolean
        Get
            Return _XMLSettings.MovieCleanDB
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieCleanDB = value
        End Set
    End Property

    Public Property MovieSetCleanDB() As Boolean
        Get
            Return _XMLSettings.MovieSetCleanDB
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieSetCleanDB = value
        End Set
    End Property

    Public Property MovieSetCleanFiles() As Boolean
        Get
            Return _XMLSettings.MovieSetCleanFiles
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieSetCleanFiles = value
        End Set
    End Property

    Public Property CleanDotFanartJPG() As Boolean
        Get
            Return _XMLSettings.CleanDotFanartJPG
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.CleanDotFanartJPG = value
        End Set
    End Property

    Public Property CleanExtrathumbs() As Boolean
        Get
            Return _XMLSettings.CleanExtrathumbs
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.CleanExtrathumbs = value
        End Set
    End Property

    Public Property CleanFanartJPG() As Boolean
        Get
            Return _XMLSettings.CleanFanartJPG
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.CleanFanartJPG = value
        End Set
    End Property

    Public Property CleanFolderJPG() As Boolean
        Get
            Return _XMLSettings.CleanFolderJPG
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.CleanFolderJPG = value
        End Set
    End Property

    Public Property CleanMovieFanartJPG() As Boolean
        Get
            Return _XMLSettings.CleanMovieFanartJPG
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.CleanMovieFanartJPG = value
        End Set
    End Property

    Public Property CleanMovieJPG() As Boolean
        Get
            Return _XMLSettings.CleanMovieJPG
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.CleanMovieJPG = value
        End Set
    End Property

    Public Property CleanMovieNameJPG() As Boolean
        Get
            Return _XMLSettings.CleanMovieNameJPG
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.CleanMovieNameJPG = value
        End Set
    End Property

    Public Property CleanMovieNFO() As Boolean
        Get
            Return _XMLSettings.CleanMovieNFO
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.CleanMovieNFO = value
        End Set
    End Property

    Public Property CleanMovieNFOB() As Boolean
        Get
            Return _XMLSettings.CleanMovieNFOB
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.CleanMovieNFOB = value
        End Set
    End Property

    Public Property CleanMovieTBN() As Boolean
        Get
            Return _XMLSettings.CleanMovieTBN
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.CleanMovieTBN = value
        End Set
    End Property

    Public Property CleanMovieTBNB() As Boolean
        Get
            Return _XMLSettings.CleanMovieTBNB
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.CleanMovieTBNB = value
        End Set
    End Property

    Public Property CleanPosterJPG() As Boolean
        Get
            Return _XMLSettings.CleanPosterJPG
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.CleanPosterJPG = value
        End Set
    End Property

    Public Property CleanPosterTBN() As Boolean
        Get
            Return _XMLSettings.CleanPosterTBN
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.CleanPosterTBN = value
        End Set
    End Property

    Public Property FileSystemCleanerWhitelistExts() As List(Of String)
        Get
            Return _XMLSettings.FileSystemCleanerWhitelistExts
        End Get
        Set(ByVal value As List(Of String))
            _XMLSettings.FileSystemCleanerWhitelistExts = value
        End Set
    End Property

    Public Property FileSystemCleanerWhitelist() As Boolean
        Get
            Return _XMLSettings.FileSystemCleanerWhitelist
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.FileSystemCleanerWhitelist = value
        End Set
    End Property

    Public Property TVDisplayMissingEpisodes() As Boolean
        Get
            Return _XMLSettings.TVDisplayMissingEpisodes
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVDisplayMissingEpisodes = value
        End Set
    End Property

    Public Property TVDisplayStatus() As Boolean
        Get
            Return _XMLSettings.TVDisplayStatus
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVDisplayStatus = value
        End Set
    End Property

    Public Property MovieImagesDisplayImageSelect() As Boolean
        Get
            Return _XMLSettings.MovieImagesDisplayImageSelect
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieImagesDisplayImageSelect = value
        End Set
    End Property

    Public Property MovieSetImagesDisplayImageSelect() As Boolean
        Get
            Return _XMLSettings.MovieSetImagesDisplayImageSelect
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieSetImagesDisplayImageSelect = value
        End Set
    End Property

    Public Property TVImagesDisplayImageSelect() As Boolean
        Get
            Return _XMLSettings.TVImagesDisplayImageSelect
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVImagesDisplayImageSelect = value
        End Set
    End Property

    Public Property MovieDisplayYear() As Boolean
        Get
            Return _XMLSettings.MovieDisplayYear
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieDisplayYear = value
        End Set
    End Property

    Public Property TVScraperOptionsOrdering() As Enums.EpisodeOrdering
        Get
            Return _XMLSettings.TVScraperOptionsOrdering
        End Get
        Set(ByVal value As Enums.EpisodeOrdering)
            _XMLSettings.TVScraperOptionsOrdering = value
        End Set
    End Property

    <XmlArray("Addons")>
    <XmlArrayItem("Addon")>
    Public Property Addons() As List(Of AddonsManager._XMLAddonClass)
        Get
            Return _XMLSettings.Addons
        End Get
        Set(ByVal value As List(Of AddonsManager._XMLAddonClass))
            _XMLSettings.Addons = value
        End Set
    End Property

    Public Property MovieScraperMetaDataIFOScan() As Boolean
        Get
            Return _XMLSettings.MovieScraperMetaDataIFOScan
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieScraperMetaDataIFOScan = value
        End Set
    End Property

    Public Property TVEpisodeFanartHeight() As Integer
        Get
            Return _XMLSettings.TVEpisodeFanartHeight
        End Get
        Set(ByVal value As Integer)
            _XMLSettings.TVEpisodeFanartHeight = value
        End Set
    End Property

    Public Property TVEpisodeFanartWidth() As Integer
        Get
            Return _XMLSettings.TVEpisodeFanartWidth
        End Get
        Set(ByVal value As Integer)
            _XMLSettings.TVEpisodeFanartWidth = value
        End Set
    End Property

    Public Property TVEpisodeFilterCustom() As List(Of String)
        Get
            Return _XMLSettings.TVEpisodeFilterCustom
        End Get
        Set(ByVal value As List(Of String))
            _XMLSettings.TVEpisodeFilterCustom = value
        End Set
    End Property

    Public Property TVLockEpisodeLanguageA() As Boolean
        Get
            Return _XMLSettings.TVLockEpisodeLanguageA
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVLockEpisodeLanguageA = value
        End Set
    End Property

    Public Property TVLockEpisodeLanguageV() As Boolean
        Get
            Return _XMLSettings.TVLockEpisodeLanguageV
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVLockEpisodeLanguageV = value
        End Set
    End Property

    Public Property TVLockEpisodeActors() As Boolean
        Get
            Return _XMLSettings.TVLockEpisodeActors
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVLockEpisodeActors = value
        End Set
    End Property

    Public Property TVLockEpisodeAired() As Boolean
        Get
            Return _XMLSettings.TVLockEpisodeAired
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVLockEpisodeAired = value
        End Set
    End Property

    Public Property TVLockEpisodeCredits() As Boolean
        Get
            Return _XMLSettings.TVLockEpisodeCredits
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVLockEpisodeCredits = value
        End Set
    End Property

    Public Property TVLockEpisodeDirector() As Boolean
        Get
            Return _XMLSettings.TVLockEpisodeDirector
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVLockEpisodeDirector = value
        End Set
    End Property

    Public Property TVLockEpisodeGuestStars() As Boolean
        Get
            Return _XMLSettings.TVLockEpisodeGuestStars
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVLockEpisodeGuestStars = value
        End Set
    End Property

    Public Property TVLockEpisodePlot() As Boolean
        Get
            Return _XMLSettings.TVLockEpisodePlot
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVLockEpisodePlot = value
        End Set
    End Property

    Public Property TVLockEpisodeRating() As Boolean
        Get
            Return _XMLSettings.TVLockEpisodeRating
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVLockEpisodeRating = value
        End Set
    End Property

    Public Property TVLockEpisodeUserRating() As Boolean
        Get
            Return _XMLSettings.TVLockEpisodeUserRating
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVLockEpisodeUserRating = value
        End Set
    End Property

    Public Property TVLockEpisodeRuntime() As Boolean
        Get
            Return _XMLSettings.TVLockEpisodeRuntime
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVLockEpisodeRuntime = value
        End Set
    End Property

    Public Property TVLockEpisodeTitle() As Boolean
        Get
            Return _XMLSettings.TVLockEpisodeTitle
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVLockEpisodeTitle = value
        End Set
    End Property

    Public Property TVEpisodePosterHeight() As Integer
        Get
            Return _XMLSettings.TVEpisodePosterHeight
        End Get
        Set(ByVal value As Integer)
            _XMLSettings.TVEpisodePosterHeight = value
        End Set
    End Property

    Public Property TVEpisodePosterWidth() As Integer
        Get
            Return _XMLSettings.TVEpisodePosterWidth
        End Get
        Set(ByVal value As Integer)
            _XMLSettings.TVEpisodePosterWidth = value
        End Set
    End Property

    Public Property TVEpisodeProperCase() As Boolean
        Get
            Return _XMLSettings.TVEpisodeProperCase
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVEpisodeProperCase = value
        End Set
    End Property

    Public Property FileSystemExpertCleaner() As Boolean
        Get
            Return _XMLSettings.FileSystemExpertCleaner
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.FileSystemExpertCleaner = value
        End Set
    End Property

    Public Property TVShowExtrafanartsHeight() As Integer
        Get
            Return _XMLSettings.TVShowExtrafanartsHeight
        End Get
        Set(ByVal value As Integer)
            _XMLSettings.TVShowExtrafanartsHeight = value
        End Set
    End Property

    Public Property MovieExtrafanartsHeight() As Integer
        Get
            Return _XMLSettings.MovieExtrafanartsHeight
        End Get
        Set(ByVal value As Integer)
            _XMLSettings.MovieExtrafanartsHeight = value
        End Set
    End Property

    Public Property MovieExtrathumbsHeight() As Integer
        Get
            Return _XMLSettings.MovieExtrathumbsHeight
        End Get
        Set(ByVal value As Integer)
            _XMLSettings.MovieExtrathumbsHeight = value
        End Set
    End Property

    Public Property MovieExtrathumbsLimit() As Integer
        Get
            Return _XMLSettings.MovieExtrathumbsLimit
        End Get
        Set(ByVal value As Integer)
            _XMLSettings.MovieExtrathumbsLimit = value
        End Set
    End Property

    Public Property TVShowExtrafanartsLimit() As Integer
        Get
            Return _XMLSettings.TVShowExtrafanartsLimit
        End Get
        Set(ByVal value As Integer)
            _XMLSettings.TVShowExtrafanartsLimit = value
        End Set
    End Property

    Public Property MovieExtrafanartsLimit() As Integer
        Get
            Return _XMLSettings.MovieExtrafanartsLimit
        End Get
        Set(ByVal value As Integer)
            _XMLSettings.MovieExtrafanartsLimit = value
        End Set
    End Property

    Public Property MovieFanartHeight() As Integer
        Get
            Return _XMLSettings.MovieFanartHeight
        End Get
        Set(ByVal value As Integer)
            _XMLSettings.MovieFanartHeight = value
        End Set
    End Property

    Public Property MovieSetFanartHeight() As Integer
        Get
            Return _XMLSettings.MovieSetFanartHeight
        End Get
        Set(ByVal value As Integer)
            _XMLSettings.MovieSetFanartHeight = value
        End Set
    End Property

    Public Property TVShowExtrafanartsPrefOnly() As Boolean
        Get
            Return _XMLSettings.TVShowExtrafanartsPrefOnly
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVShowExtrafanartsPrefOnly = value
        End Set
    End Property

    Public Property MovieExtrafanartsPrefSizeOnly() As Boolean
        Get
            Return _XMLSettings.MovieExtrafanartsPrefSizeOnly
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieExtrafanartsPrefSizeOnly = value
        End Set
    End Property

    Public Property MovieExtrathumbsCreatorAutoThumbs() As Boolean
        Get
            Return _XMLSettings.MovieExtrathumbsCreatorAutoThumbs
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieExtrathumbsCreatorAutoThumbs = value
        End Set
    End Property
    Public Property MovieExtrathumbsCreatorNoBlackBars() As Boolean
        Get
            Return _XMLSettings.MovieExtrathumbsCreatorNoBlackBars
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieExtrathumbsCreatorNoBlackBars = value
        End Set
    End Property

    Public Property MovieExtrathumbsCreatorNoSpoilers() As Boolean
        Get
            Return _XMLSettings.MovieExtrathumbsCreatorNoSpoilers
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieExtrathumbsCreatorNoSpoilers = value
        End Set
    End Property

    Public Property MovieExtrathumbsCreatorUseETasFA() As Boolean
        Get
            Return _XMLSettings.MovieExtrathumbsCreatorUseETasFA
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieExtrathumbsCreatorUseETasFA = value
        End Set
    End Property

    Public Property MovieExtrathumbsPrefSizeOnly() As Boolean
        Get
            Return _XMLSettings.MovieExtrathumbsPrefSizeOnly
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieExtrathumbsPrefSizeOnly = value
        End Set
    End Property

    Public Property MovieFanartPrefSizeOnly() As Boolean
        Get
            Return _XMLSettings.MovieFanartPrefSizeOnly
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieFanartPrefSizeOnly = value
        End Set
    End Property

    Public Property TVShowExtrafanartsWidth() As Integer
        Get
            Return _XMLSettings.TVShowExtrafanartsWidth
        End Get
        Set(ByVal value As Integer)
            _XMLSettings.TVShowExtrafanartsWidth = value
        End Set
    End Property

    Public Property MovieExtrafanartsWidth() As Integer
        Get
            Return _XMLSettings.MovieExtrafanartsWidth
        End Get
        Set(ByVal value As Integer)
            _XMLSettings.MovieExtrafanartsWidth = value
        End Set
    End Property

    Public Property MovieExtrathumbsWidth() As Integer
        Get
            Return _XMLSettings.MovieExtrathumbsWidth
        End Get
        Set(ByVal value As Integer)
            _XMLSettings.MovieExtrathumbsWidth = value
        End Set
    End Property

    Public Property MovieFanartWidth() As Integer
        Get
            Return _XMLSettings.MovieFanartWidth
        End Get
        Set(ByVal value As Integer)
            _XMLSettings.MovieFanartWidth = value
        End Set
    End Property

    Public Property MovieSetFanartWidth() As Integer
        Get
            Return _XMLSettings.MovieSetFanartWidth
        End Get
        Set(ByVal value As Integer)
            _XMLSettings.MovieSetFanartWidth = value
        End Set
    End Property

    Public Property MovieScraperTop250() As Boolean
        Get
            Return _XMLSettings.MovieScraperTop250
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieScraperTop250 = value
        End Set
    End Property

    Public Property MovieScraperCollectionID() As Boolean
        Get
            Return _XMLSettings.MovieScraperCollectionID
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieScraperCollectionID = value
        End Set
    End Property

    Public Property MovieScraperCollectionsAuto() As Boolean
        Get
            Return _XMLSettings.MovieScraperCollectionsAuto
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieScraperCollectionsAuto = value
        End Set
    End Property

    Public Property MovieScraperCollectionsExtendedInfo() As Boolean
        Get
            Return _XMLSettings.MovieScraperCollectionsExtendedInfo
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieScraperCollectionsExtendedInfo = value
        End Set
    End Property

    Public Property MovieScraperCountry() As Boolean
        Get
            Return _XMLSettings.MovieScraperCountry
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieScraperCountry = value
        End Set
    End Property

    Public Property MovieScraperCast() As Boolean
        Get
            Return _XMLSettings.MovieScraperCast
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieScraperCast = value
        End Set
    End Property

    Public Property MovieScraperCert() As Boolean
        Get
            Return _XMLSettings.MovieScraperCert
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieScraperCert = value
        End Set
    End Property

    Public Property MovieScraperMPAA() As Boolean
        Get
            Return _XMLSettings.MovieScraperMPAA
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieScraperMPAA = value
        End Set
    End Property

    Public Property MovieScraperMPAANotRated() As String
        Get
            Return _XMLSettings.MovieScraperMPAANotRated
        End Get
        Set(ByVal value As String)
            _XMLSettings.MovieScraperMPAANotRated = value
        End Set
    End Property

    Public Property MovieScraperDirector() As Boolean
        Get
            Return _XMLSettings.MovieScraperDirector
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieScraperDirector = value
        End Set
    End Property

    Public Property MovieScraperGenre() As Boolean
        Get
            Return _XMLSettings.MovieScraperGenre
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieScraperGenre = value
        End Set
    End Property

    Public Property MovieScraperOriginalTitle() As Boolean
        Get
            Return _XMLSettings.MovieScraperOriginalTitle
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieScraperOriginalTitle = value
        End Set
    End Property


    Public Property MovieScraperOutline() As Boolean
        Get
            Return _XMLSettings.MovieScraperOutline
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieScraperOutline = value
        End Set
    End Property

    Public Property MovieScraperPlot() As Boolean
        Get
            Return _XMLSettings.MovieScraperPlot
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieScraperPlot = value
        End Set
    End Property


    Public Property MovieScraperRating() As Boolean
        Get
            Return _XMLSettings.MovieScraperRating
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieScraperRating = value
        End Set
    End Property


    Public Property MovieScraperUserRating() As Boolean
        Get
            Return _XMLSettings.MovieScraperUserRating
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieScraperUserRating = value
        End Set
    End Property

    Public Property MovieScraperRelease() As Boolean
        Get
            Return _XMLSettings.MovieScraperRelease
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieScraperRelease = value
        End Set
    End Property

    Public Property MovieScraperRuntime() As Boolean
        Get
            Return _XMLSettings.MovieScraperRuntime
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieScraperRuntime = value
        End Set
    End Property

    Public Property MovieScraperStudio() As Boolean
        Get
            Return _XMLSettings.MovieScraperStudio
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieScraperStudio = value
        End Set
    End Property
    Public Property MovieScraperStudioLimit() As Integer
        Get
            Return _XMLSettings.MovieScraperStudioLimit
        End Get
        Set(ByVal value As Integer)
            _XMLSettings.MovieScraperStudioLimit = value
        End Set
    End Property

    Public Property MovieScraperStudioWithImgOnly() As Boolean
        Get
            Return _XMLSettings.MovieScraperStudioWithImgOnly
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieScraperStudioWithImgOnly = value
        End Set
    End Property

    Public Property MovieScraperTagline() As Boolean
        Get
            Return _XMLSettings.MovieScraperTagline
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieScraperTagline = value
        End Set
    End Property

    Public Property MovieScraperTitle() As Boolean
        Get
            Return _XMLSettings.MovieScraperTitle
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieScraperTitle = value
        End Set
    End Property

    Public Property MovieScraperTrailer() As Boolean
        Get
            Return _XMLSettings.MovieScraperTrailer
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieScraperTrailer = value
        End Set
    End Property

    Public Property MovieScraperCredits() As Boolean
        Get
            Return _XMLSettings.MovieScraperCredits
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieScraperCredits = value
        End Set
    End Property

    Public Property MovieScraperYear() As Boolean
        Get
            Return _XMLSettings.MovieScraperYear
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieScraperYear = value
        End Set
    End Property

    Public Property MovieFilterCustom() As List(Of String)
        Get
            Return _XMLSettings.MovieFilterCustom
        End Get
        Set(ByVal value As List(Of String))
            _XMLSettings.MovieFilterCustom = value
        End Set
    End Property

    Public Property GeneralFilterPanelIsRaisedMovie() As Boolean
        Get
            Return _XMLSettings.GeneralFilterPanelIsRaisedMovie
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.GeneralFilterPanelIsRaisedMovie = value
        End Set
    End Property

    Public Property GeneralFilterPanelIsRaisedMovieSet() As Boolean
        Get
            Return _XMLSettings.GeneralFilterPanelIsRaisedMovieSet
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.GeneralFilterPanelIsRaisedMovieSet = value
        End Set
    End Property

    Public Property GeneralFilterPanelIsRaisedTVShow() As Boolean
        Get
            Return _XMLSettings.GeneralFilterPanelIsRaisedTVShow
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.GeneralFilterPanelIsRaisedTVShow = value
        End Set
    End Property

    Public Property MovieGeneralFlagLang() As String
        Get
            Return _XMLSettings.MovieGeneralFlagLang
        End Get
        Set(ByVal value As String)
            _XMLSettings.MovieGeneralFlagLang = value
        End Set
    End Property

    Public Property MovieScraperCleanFields() As Boolean
        Get
            Return _XMLSettings.MovieScraperCleanFields
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieScraperCleanFields = value
        End Set
    End Property

    Public Property TVScraperCleanFields() As Boolean
        Get
            Return _XMLSettings.TVScraperCleanFields
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVScraperCleanFields = value
        End Set
    End Property

    Public Property MovieScraperCleanPlotOutline() As Boolean
        Get
            Return _XMLSettings.MovieScraperCleanPlotOutline
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieScraperCleanPlotOutline = value
        End Set
    End Property

    Public Property MovieScraperGenreLimit() As Integer
        Get
            Return _XMLSettings.MovieScraperGenreLimit
        End Get
        Set(ByVal value As Integer)
            _XMLSettings.MovieScraperGenreLimit = value
        End Set
    End Property

    Public Property MovieGeneralIgnoreLastScan() As Boolean
        Get
            Return _XMLSettings.MovieGeneralIgnoreLastScan
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieGeneralIgnoreLastScan = value
        End Set
    End Property

    Public Property GeneralInfoPanelStateMovie() As Integer
        Get
            Return _XMLSettings.GeneralInfoPanelStateMovie
        End Get
        Set(ByVal value As Integer)
            _XMLSettings.GeneralInfoPanelStateMovie = value
        End Set
    End Property

    Public Property GeneralInfoPanelStateMovieSet() As Integer
        Get
            Return _XMLSettings.GeneralInfoPanelStateMovieSet
        End Get
        Set(ByVal value As Integer)
            _XMLSettings.GeneralInfoPanelStateMovieSet = value
        End Set
    End Property

    Public Property GeneralLanguage() As String
        Get
            Return _XMLSettings.GeneralLanguage
        End Get
        Set(ByVal value As String)
            _XMLSettings.GeneralLanguage = value
        End Set
    End Property

    Public Property MovieLevTolerance() As Integer
        Get
            Return _XMLSettings.MovieLevTolerance
        End Get
        Set(ByVal value As Integer)
            _XMLSettings.MovieLevTolerance = value
        End Set
    End Property
    Public Property MovieLockActors() As Boolean
        Get
            Return _XMLSettings.MovieLockActors
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieLockActors = value
        End Set
    End Property

    Public Property MovieLockCollectionID() As Boolean
        Get
            Return _XMLSettings.MovieLockCollectionID
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieLockCollectionID = value
        End Set
    End Property

    Public Property MovieLockCollections() As Boolean
        Get
            Return _XMLSettings.MovieLockCollections
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieLockCollections = value
        End Set
    End Property

    Public Property MovieLockCountry() As Boolean
        Get
            Return _XMLSettings.MovieLockCountry
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieLockCountry = value
        End Set
    End Property

    Public Property MovieLockDirector() As Boolean
        Get
            Return _XMLSettings.MovieLockDirector
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieLockDirector = value
        End Set
    End Property

    Public Property MovieLockGenre() As Boolean
        Get
            Return _XMLSettings.MovieLockGenre
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieLockGenre = value
        End Set
    End Property

    Public Property MovieScraperUseDetailView() As Boolean
        Get
            Return _XMLSettings.MovieScraperUseDetailView
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieScraperUseDetailView = value
        End Set
    End Property

    Public Property MovieLockOutline() As Boolean
        Get
            Return _XMLSettings.MovieLockOutline
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieLockOutline = value
        End Set
    End Property

    Public Property MovieLockPlot() As Boolean
        Get
            Return _XMLSettings.MovieLockPlot
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieLockPlot = value
        End Set
    End Property


    Public Property MovieLockRating() As Boolean
        Get
            Return _XMLSettings.MovieLockRating
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieLockRating = value
        End Set
    End Property


    Public Property MovieLockUserRating() As Boolean
        Get
            Return _XMLSettings.MovieLockUserRating
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieLockUserRating = value
        End Set
    End Property

    Public Property MovieLockReleaseDate() As Boolean
        Get
            Return _XMLSettings.MovieLockReleaseDate
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieLockReleaseDate = value
        End Set
    End Property

    Public Property MovieLockLanguageV() As Boolean
        Get
            Return _XMLSettings.MovieLockLanguageV
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieLockLanguageV = value
        End Set
    End Property

    Public Property MovieLockLanguageA() As Boolean
        Get
            Return _XMLSettings.MovieLockLanguageA
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieLockLanguageA = value
        End Set
    End Property

    Public Property MovieLockMPAA() As Boolean
        Get
            Return _XMLSettings.MovieLockMPAA
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieLockMPAA = value
        End Set
    End Property

    Public Property MovieLockCert() As Boolean
        Get
            Return _XMLSettings.MovieLockCert
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieLockCert = value
        End Set
    End Property

    Public Property MovieLockRuntime() As Boolean
        Get
            Return _XMLSettings.MovieLockRuntime
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieLockRuntime = value
        End Set
    End Property

    Public Property MovieLockTags() As Boolean
        Get
            Return _XMLSettings.MovieLockTags
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieLockTags = value
        End Set
    End Property

    Public Property MovieLockTop250() As Boolean
        Get
            Return _XMLSettings.MovieLockTop250
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieLockTop250 = value
        End Set
    End Property

    Public Property MovieLockCredits() As Boolean
        Get
            Return _XMLSettings.MovieLockCredits
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieLockCredits = value
        End Set
    End Property

    Public Property MovieLockYear() As Boolean
        Get
            Return _XMLSettings.MovieLockYear
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieLockYear = value
        End Set
    End Property

    Public Property MovieScraperCertFSK() As Boolean
        Get
            Return _XMLSettings.MovieScraperCertFSK
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieScraperCertFSK = value
        End Set
    End Property

    Public Property TVScraperShowCertFSK() As Boolean
        Get
            Return _XMLSettings.TVScraperShowCertFSK
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVScraperShowCertFSK = value
        End Set
    End Property
    Public Property MovieLockStudio() As Boolean
        Get
            Return _XMLSettings.MovieLockStudio
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieLockStudio = value
        End Set
    End Property

    Public Property MovieLockTagline() As Boolean
        Get
            Return _XMLSettings.MovieLockTagline
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieLockTagline = value
        End Set
    End Property

    Public Property MovieLockTitle() As Boolean
        Get
            Return _XMLSettings.MovieLockTitle
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieLockTitle = value
        End Set
    End Property
    Public Property MovieLockOriginalTitle() As Boolean
        Get
            Return _XMLSettings.MovieLockOriginalTitle
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieLockOriginalTitle = value
        End Set
    End Property
    Public Property MovieLockTrailer() As Boolean
        Get
            Return _XMLSettings.MovieLockTrailer
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieLockTrailer = value
        End Set
    End Property

    Public Property MovieGeneralCustomMarker1Color() As Integer
        Get
            Return _XMLSettings.MovieGeneralCustomMarker1Color
        End Get
        Set(ByVal value As Integer)
            _XMLSettings.MovieGeneralCustomMarker1Color = value
        End Set
    End Property

    Public Property MovieGeneralCustomMarker2Color() As Integer
        Get
            Return _XMLSettings.MovieGeneralCustomMarker2Color
        End Get
        Set(ByVal value As Integer)
            _XMLSettings.MovieGeneralCustomMarker2Color = value
        End Set
    End Property

    Public Property MovieGeneralCustomMarker3Color() As Integer
        Get
            Return _XMLSettings.MovieGeneralCustomMarker3Color
        End Get
        Set(ByVal value As Integer)
            _XMLSettings.MovieGeneralCustomMarker3Color = value
        End Set
    End Property

    Public Property MovieGeneralCustomMarker4Color() As Integer
        Get
            Return _XMLSettings.MovieGeneralCustomMarker4Color
        End Get
        Set(ByVal value As Integer)
            _XMLSettings.MovieGeneralCustomMarker4Color = value
        End Set
    End Property

    Public Property MovieGeneralCustomMarker1Name() As String
        Get
            Return _XMLSettings.MovieGeneralCustomMarker1Name
        End Get
        Set(ByVal value As String)
            _XMLSettings.MovieGeneralCustomMarker1Name = value
        End Set
    End Property

    Public Property MovieGeneralCustomMarker2Name() As String
        Get
            Return _XMLSettings.MovieGeneralCustomMarker2Name
        End Get
        Set(ByVal value As String)
            _XMLSettings.MovieGeneralCustomMarker2Name = value
        End Set
    End Property

    Public Property MovieGeneralCustomMarker3Name() As String
        Get
            Return _XMLSettings.MovieGeneralCustomMarker3Name
        End Get
        Set(ByVal value As String)
            _XMLSettings.MovieGeneralCustomMarker3Name = value
        End Set
    End Property

    Public Property MovieGeneralCustomMarker4Name() As String
        Get
            Return _XMLSettings.MovieGeneralCustomMarker4Name
        End Get
        Set(ByVal value As String)
            _XMLSettings.MovieGeneralCustomMarker4Name = value
        End Set
    End Property

    Public Property MovieGeneralCustomScrapeButtonEnabled() As Boolean
        Get
            Return _XMLSettings.MovieGeneralCustomScrapeButtonEnabled
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieGeneralCustomScrapeButtonEnabled = value
        End Set
    End Property

    Public Property MovieGeneralCustomScrapeButtonModifierType() As Enums.ScrapeModifierType
        Get
            Return _XMLSettings.MovieGeneralCustomScrapeButtonModifierType
        End Get
        Set(ByVal value As Enums.ScrapeModifierType)
            _XMLSettings.MovieGeneralCustomScrapeButtonModifierType = value
        End Set
    End Property

    Public Property MovieGeneralCustomScrapeButtonScrapeType() As Enums.ScrapeType
        Get
            Return _XMLSettings.MovieGeneralCustomScrapeButtonScrapeType
        End Get
        Set(ByVal value As Enums.ScrapeType)
            _XMLSettings.MovieGeneralCustomScrapeButtonScrapeType = value
        End Set
    End Property

    Public Property MovieSetGeneralCustomScrapeButtonEnabled() As Boolean
        Get
            Return _XMLSettings.MovieSetGeneralCustomScrapeButtonEnabled
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieSetGeneralCustomScrapeButtonEnabled = value
        End Set
    End Property

    Public Property MovieSetGeneralCustomScrapeButtonModifierType() As Enums.ScrapeModifierType
        Get
            Return _XMLSettings.MovieSetGeneralCustomScrapeButtonModifierType
        End Get
        Set(ByVal value As Enums.ScrapeModifierType)
            _XMLSettings.MovieSetGeneralCustomScrapeButtonModifierType = value
        End Set
    End Property

    Public Property MovieSetGeneralCustomScrapeButtonScrapeType() As Enums.ScrapeType
        Get
            Return _XMLSettings.MovieSetGeneralCustomScrapeButtonScrapeType
        End Get
        Set(ByVal value As Enums.ScrapeType)
            _XMLSettings.MovieSetGeneralCustomScrapeButtonScrapeType = value
        End Set
    End Property

    Public Property TVGeneralCustomScrapeButtonEnabled() As Boolean
        Get
            Return _XMLSettings.TVGeneralCustomScrapeButtonEnabled
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVGeneralCustomScrapeButtonEnabled = value
        End Set
    End Property

    Public Property TVGeneralCustomScrapeButtonModifierType() As Enums.ScrapeModifierType
        Get
            Return _XMLSettings.TVGeneralCustomScrapeButtonModifierType
        End Get
        Set(ByVal value As Enums.ScrapeModifierType)
            _XMLSettings.TVGeneralCustomScrapeButtonModifierType = value
        End Set
    End Property

    Public Property TVGeneralCustomScrapeButtonScrapeType() As Enums.ScrapeType
        Get
            Return _XMLSettings.TVGeneralCustomScrapeButtonScrapeType
        End Get
        Set(ByVal value As Enums.ScrapeType)
            _XMLSettings.TVGeneralCustomScrapeButtonScrapeType = value
        End Set
    End Property

    Public Property MovieGeneralMarkNew() As Boolean
        Get
            Return _XMLSettings.MovieGeneralMarkNew
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieGeneralMarkNew = value
        End Set
    End Property

    Public Property MovieSetGeneralMarkNew() As Boolean
        Get
            Return _XMLSettings.MovieSetGeneralMarkNew
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieSetGeneralMarkNew = value
        End Set
    End Property

    Public Property TVGeneralClickScrape() As Boolean
        Get
            Return _XMLSettings.TVGeneralClickScrape
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVGeneralClickScrape = value
        End Set
    End Property

    Public Property TVGeneralClickScrapeAsk() As Boolean
        Get
            Return _XMLSettings.TVGeneralClickScrapeask
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVGeneralClickScrapeask = value
        End Set
    End Property

    Public Property TVGeneralMarkNewEpisodes() As Boolean
        Get
            Return _XMLSettings.TVGeneralMarkNewEpisodes
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVGeneralMarkNewEpisodes = value
        End Set
    End Property

    Public Property TVGeneralMarkNewShows() As Boolean
        Get
            Return _XMLSettings.TVGeneralMarkNewShows
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVGeneralMarkNewShows = value
        End Set
    End Property

    Public Property MovieMetadataPerFileType() As List(Of MetadataPerType)
        Get
            Return _XMLSettings.MovieMetadataPerFileType
        End Get
        Set(ByVal value As List(Of MetadataPerType))
            _XMLSettings.MovieMetadataPerFileType = value
        End Set
    End Property

    Public Property MovieMissingBanner() As Boolean
        Get
            Return _XMLSettings.MovieMissingBanner
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieMissingBanner = value
        End Set
    End Property

    Public Property MovieMissingClearArt() As Boolean
        Get
            Return _XMLSettings.MovieMissingClearArt
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieMissingClearArt = value
        End Set
    End Property

    Public Property MovieMissingClearLogo() As Boolean
        Get
            Return _XMLSettings.MovieMissingClearLogo
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieMissingClearLogo = value
        End Set
    End Property

    Public Property MovieMissingDiscArt() As Boolean
        Get
            Return _XMLSettings.MovieMissingDiscArt
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieMissingDiscArt = value
        End Set
    End Property

    Public Property MovieMissingExtrathumbs() As Boolean
        Get
            Return _XMLSettings.MovieMissingExtrathumbs
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieMissingExtrathumbs = value
        End Set
    End Property

    Public Property MovieMissingExtrafanarts() As Boolean
        Get
            Return _XMLSettings.MovieMissingExtrafanarts
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieMissingExtrafanarts = value
        End Set
    End Property

    Public Property MovieMissingFanart() As Boolean
        Get
            Return _XMLSettings.MovieMissingFanart
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieMissingFanart = value
        End Set
    End Property

    Public Property MovieMissingLandscape() As Boolean
        Get
            Return _XMLSettings.MovieMissingLandscape
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieMissingLandscape = value
        End Set
    End Property

    Public Property MovieMissingNFO() As Boolean
        Get
            Return _XMLSettings.MovieMissingNFO
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieMissingNFO = value
        End Set
    End Property

    Public Property MovieMissingPoster() As Boolean
        Get
            Return _XMLSettings.MovieMissingPoster
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieMissingPoster = value
        End Set
    End Property

    Public Property MovieMissingSubtitles() As Boolean
        Get
            Return _XMLSettings.MovieMissingSubtitles
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieMissingSubtitles = value
        End Set
    End Property

    Public Property MovieMissingTheme() As Boolean
        Get
            Return _XMLSettings.MovieMissingTheme
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieMissingTheme = value
        End Set
    End Property

    Public Property MovieMissingTrailer() As Boolean
        Get
            Return _XMLSettings.MovieMissingTrailer
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieMissingTrailer = value
        End Set
    End Property

    Public Property MovieSetBannerPrefSizeOnly() As Boolean
        Get
            Return _XMLSettings.MovieSetBannerPrefSizeOnly
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieSetBannerPrefSizeOnly = value
        End Set
    End Property

    Public Property MovieSetBannerResize() As Boolean
        Get
            Return _XMLSettings.MovieSetBannerResize
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieSetBannerResize = value
        End Set
    End Property

    Public Property MovieSetClickScrape() As Boolean
        Get
            Return _XMLSettings.MovieSetClickScrape
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieSetClickScrape = value
        End Set
    End Property

    Public Property MovieSetClickScrapeAsk() As Boolean
        Get
            Return _XMLSettings.MovieSetClickScrapeAsk
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieSetClickScrapeAsk = value
        End Set
    End Property

    Public Property MovieSetFanartPrefSizeOnly() As Boolean
        Get
            Return _XMLSettings.MovieSetFanartPrefSizeOnly
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieSetFanartPrefSizeOnly = value
        End Set
    End Property

    Public Property MovieSetFanartResize() As Boolean
        Get
            Return _XMLSettings.MovieSetFanartResize
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieSetFanartResize = value
        End Set
    End Property

    Public Property MovieSetLockPlot() As Boolean
        Get
            Return _XMLSettings.MovieSetLockPlot
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieSetLockPlot = value
        End Set
    End Property

    Public Property MovieSetLockTitle() As Boolean
        Get
            Return _XMLSettings.MovieSetLockTitle
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieSetLockTitle = value
        End Set
    End Property

    Public Property MovieSetPosterPrefSizeOnly() As Boolean
        Get
            Return _XMLSettings.MovieSetPosterPrefSizeOnly
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieSetPosterPrefSizeOnly = value
        End Set
    End Property

    Public Property MovieSetPosterResize() As Boolean
        Get
            Return _XMLSettings.MovieSetPosterResize
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieSetPosterResize = value
        End Set
    End Property

    Public Property MovieSetMissingBanner() As Boolean
        Get
            Return _XMLSettings.MovieSetMissingBanner
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieSetMissingBanner = value
        End Set
    End Property

    Public Property MovieSetMissingClearArt() As Boolean
        Get
            Return _XMLSettings.MovieSetMissingClearArt
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieSetMissingClearArt = value
        End Set
    End Property

    Public Property MovieSetMissingClearLogo() As Boolean
        Get
            Return _XMLSettings.MovieSetMissingClearLogo
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieSetMissingClearLogo = value
        End Set
    End Property

    Public Property MovieSetMissingDiscArt() As Boolean
        Get
            Return _XMLSettings.MovieSetMissingDiscArt
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieSetMissingDiscArt = value
        End Set
    End Property

    Public Property MovieSetMissingFanart() As Boolean
        Get
            Return _XMLSettings.MovieSetMissingFanart
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieSetMissingFanart = value
        End Set
    End Property

    Public Property MovieSetMissingLandscape() As Boolean
        Get
            Return _XMLSettings.MovieSetMissingLandscape
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieSetMissingLandscape = value
        End Set
    End Property

    Public Property MovieSetMissingNFO() As Boolean
        Get
            Return _XMLSettings.MovieSetMissingNFO
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieSetMissingNFO = value
        End Set
    End Property

    Public Property MovieSetMissingPoster() As Boolean
        Get
            Return _XMLSettings.MovieSetMissingPoster
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieSetMissingPoster = value
        End Set
    End Property

    Public Property MovieSetScraperPlot() As Boolean
        Get
            Return _XMLSettings.MovieSetScraperPlot
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieSetScraperPlot = value
        End Set
    End Property

    Public Property GeneralImageFilter() As Boolean
        Get
            Return _XMLSettings.GeneralImageFilter
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.GeneralImageFilter = value
        End Set
    End Property

    Public Property GeneralImageFilterAutoscraper() As Boolean
        Get
            Return _XMLSettings.GeneralImageFilterAutoscraper
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.GeneralImageFilterAutoscraper = value
        End Set
    End Property
    Public Property GeneralImageFilterFanart() As Boolean
        Get
            Return _XMLSettings.GeneralImageFilterFanart
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.GeneralImageFilterFanart = value
        End Set
    End Property

    Public Property GeneralImageFilterImagedialog() As Boolean
        Get
            Return _XMLSettings.GeneralImageFilterImagedialog
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.GeneralImageFilterImagedialog = value
        End Set
    End Property
    Public Property GeneralImageFilterPoster() As Boolean
        Get
            Return _XMLSettings.GeneralImageFilterPoster
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.GeneralImageFilterPoster = value
        End Set
    End Property

    Public Property GeneralImageFilterPosterMatchTolerance() As Integer
        Get
            Return _XMLSettings.GeneralImageFilterPosterMatchTolerance
        End Get
        Set(ByVal value As Integer)
            _XMLSettings.GeneralImageFilterPosterMatchTolerance = value
        End Set
    End Property

    Public Property GeneralImageFilterFanartMatchTolerance() As Integer
        Get
            Return _XMLSettings.GeneralImageFilterFanartMatchTolerance
        End Get
        Set(ByVal value As Integer)
            _XMLSettings.GeneralImageFilterFanartMatchTolerance = value
        End Set
    End Property

    Public Property MovieSetScraperTitle() As Boolean
        Get
            Return _XMLSettings.MovieSetScraperTitle
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieSetScraperTitle = value
        End Set
    End Property

    Public Property GeneralMovieTheme() As String
        Get
            Return _XMLSettings.GeneralMovieTheme
        End Get
        Set(ByVal value As String)
            _XMLSettings.GeneralMovieTheme = value
        End Set
    End Property

    Public Property GeneralMovieSetTheme() As String
        Get
            Return _XMLSettings.GeneralMovieSetTheme
        End Get
        Set(ByVal value As String)
            _XMLSettings.GeneralMovieSetTheme = value
        End Set
    End Property

    Public Property GeneralDaemonPath() As String
        Get
            Return _XMLSettings.GeneralDaemonPath
        End Get
        Set(ByVal value As String)
            _XMLSettings.GeneralDaemonPath = value
        End Set
    End Property

    Public Property GeneralDaemonDrive() As String
        Get
            Return _XMLSettings.GeneralDaemonDrive
        End Get
        Set(ByVal value As String)
            _XMLSettings.GeneralDaemonDrive = value
        End Set
    End Property

    Public Property GeneralDoubleClickScrape() As Boolean
        Get
            Return _XMLSettings.GeneralDoubleClickScrape
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.GeneralDoubleClickScrape = value
        End Set
    End Property

    Public Property MovieTrailerDefaultSearch() As String
        Get
            Return _XMLSettings.MovieTrailerDefaultSearch
        End Get
        Set(ByVal value As String)
            _XMLSettings.MovieTrailerDefaultSearch = value
        End Set
    End Property

    Public Property GeneralDisplayBanner() As Boolean
        Get
            Return _XMLSettings.GeneralDisplayBanner
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.GeneralDisplayBanner = value
        End Set
    End Property

    Public Property GeneralDisplayCharacterArt() As Boolean
        Get
            Return _XMLSettings.GeneralDisplayCharacterArt
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.GeneralDisplayCharacterArt = value
        End Set
    End Property

    Public Property GeneralDisplayClearArt() As Boolean
        Get
            Return _XMLSettings.GeneralDisplayClearArt
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.GeneralDisplayClearArt = value
        End Set
    End Property

    Public Property GeneralDisplayClearLogo() As Boolean
        Get
            Return _XMLSettings.GeneralDisplayClearLogo
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.GeneralDisplayClearLogo = value
        End Set
    End Property

    Public Property GeneralDisplayDiscArt() As Boolean
        Get
            Return _XMLSettings.GeneralDisplayDiscArt
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.GeneralDisplayDiscArt = value
        End Set
    End Property

    Public Property GeneralDisplayFanart() As Boolean
        Get
            Return _XMLSettings.GeneralDisplayFanart
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.GeneralDisplayFanart = value
        End Set
    End Property

    Public Property GeneralDisplayFanartSmall() As Boolean
        Get
            Return _XMLSettings.GeneralDisplayFanartSmall
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.GeneralDisplayFanartSmall = value
        End Set
    End Property

    Public Property GeneralDisplayLandscape() As Boolean
        Get
            Return _XMLSettings.GeneralDisplayLandscape
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.GeneralDisplayLandscape = value
        End Set
    End Property

    Public Property GeneralDisplayPoster() As Boolean
        Get
            Return _XMLSettings.GeneralDisplayPoster
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.GeneralDisplayPoster = value
        End Set
    End Property

    Public Property TVEpisodeFilterCustomIsEmpty() As Boolean
        Get
            Return _XMLSettings.TVEpisodeFilterCustomIsEmpty
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVEpisodeFilterCustomIsEmpty = value
        End Set
    End Property

    Public Property TVEpisodeNoFilter() As Boolean
        Get
            Return _XMLSettings.TVEpisodeNoFilter
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVEpisodeNoFilter = value
        End Set
    End Property

    Public Property MovieFilterCustomIsEmpty() As Boolean
        Get
            Return _XMLSettings.MovieFilterCustomIsEmpty
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieFilterCustomIsEmpty = value
        End Set
    End Property

    Public Property MovieImagesNotSaveURLToNfo() As Boolean
        Get
            Return _XMLSettings.MovieImagesNotSaveURLToNfo
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieImagesNotSaveURLToNfo = value
        End Set
    End Property

    Public Property TVShowFilterCustomIsEmpty() As Boolean
        Get
            Return _XMLSettings.TVShowFilterCustomIsEmpty
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVShowFilterCustomIsEmpty = value
        End Set
    End Property

    Public Property FileSystemNoStackExts() As List(Of String)
        Get
            Return _XMLSettings.FileSystemNoStackExts
        End Get
        Set(ByVal value As List(Of String))
            _XMLSettings.FileSystemNoStackExts = value
        End Set
    End Property

    Public Property MovieSortTokensIsEmpty() As Boolean
        Get
            Return _XMLSettings.MovieSortTokensIsEmpty
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieSortTokensIsEmpty = value
        End Set
    End Property

    Public Property MovieSetSortTokensIsEmpty() As Boolean
        Get
            Return _XMLSettings.MovieSetSortTokensIsEmpty
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieSetSortTokensIsEmpty = value
        End Set
    End Property

    Public Property TVSortTokensIsEmpty() As Boolean
        Get
            Return _XMLSettings.TVSortTokensIsEmpty
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVSortTokensIsEmpty = value
        End Set
    End Property

    Public Property OMMDummyFormat() As Integer
        Get
            Return _XMLSettings.OMMDummyFormat
        End Get
        Set(ByVal value As Integer)
            _XMLSettings.OMMDummyFormat = value
        End Set
    End Property

    Public Property OMMDummyTagline() As String
        Get
            Return _XMLSettings.OMMDummyTagline
        End Get
        Set(ByVal value As String)
            _XMLSettings.OMMDummyTagline = value
        End Set
    End Property

    Public Property OMMDummyTop() As String
        Get
            Return _XMLSettings.OMMDummyTop
        End Get
        Set(ByVal value As String)
            _XMLSettings.OMMDummyTop = value
        End Set
    End Property

    Public Property OMMDummyUseBackground() As Boolean
        Get
            Return _XMLSettings.OMMDummyUseBackground
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.OMMDummyUseBackground = value
        End Set
    End Property

    Public Property OMMDummyUseFanart() As Boolean
        Get
            Return _XMLSettings.OMMDummyUseFanart
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.OMMDummyUseFanart = value
        End Set
    End Property

    Public Property OMMDummyUseOverlay() As Boolean
        Get
            Return _XMLSettings.OMMDummyUseOverlay
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.OMMDummyUseOverlay = value
        End Set
    End Property

    Public Property OMMMediaStubTagline() As String
        Get
            Return _XMLSettings.OMMMediaStubTagline
        End Get
        Set(ByVal value As String)
            _XMLSettings.OMMMediaStubTagline = value
        End Set
    End Property

    Public Property MovieScraperCertOnlyValue() As Boolean
        Get
            Return _XMLSettings.MovieScraperCertOnlyValue
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieScraperCertOnlyValue = value
        End Set
    End Property

    Public Property TVScraperShowCertOnlyValue() As Boolean
        Get
            Return _XMLSettings.TVScraperShowCertOnlyValue
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVScraperShowCertOnlyValue = value
        End Set
    End Property

    Public Property TVAllSeasonsBannerKeepExisting() As Boolean
        Get
            Return _XMLSettings.TVAllSeasonsBannerKeepExisting
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVAllSeasonsBannerKeepExisting = value
        End Set
    End Property

    Public Property TVAllSeasonsFanartKeepExisting() As Boolean
        Get
            Return _XMLSettings.TVAllSeasonsFanartKeepExisting
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVAllSeasonsFanartKeepExisting = value
        End Set
    End Property

    Public Property TVAllSeasonsLandscapeKeepExisting() As Boolean
        Get
            Return _XMLSettings.TVAllSeasonsLandscapeKeepExisting
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVAllSeasonsLandscapeKeepExisting = value
        End Set
    End Property

    Public Property TVAllSeasonsPosterKeepExisting() As Boolean
        Get
            Return _XMLSettings.TVAllSeasonsPosterKeepExisting
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVAllSeasonsPosterKeepExisting = value
        End Set
    End Property

    Public Property TVEpisodeFanartKeepExisting() As Boolean
        Get
            Return _XMLSettings.TVEpisodeFanartKeepExisting
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVEpisodeFanartKeepExisting = value
        End Set
    End Property

    Public Property TVEpisodePosterKeepExisting() As Boolean
        Get
            Return _XMLSettings.TVEpisodePosterKeepExisting
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVEpisodePosterKeepExisting = value
        End Set
    End Property

    Public Property TVShowExtrafanartsKeepExisting() As Boolean
        Get
            Return _XMLSettings.TVShowExtrafanartsKeepExisting
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVShowExtrafanartsKeepExisting = value
        End Set
    End Property

    Public Property MovieExtrafanartsKeepExisting() As Boolean
        Get
            Return _XMLSettings.MovieExtrafanartsKeepExisting
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieExtrafanartsKeepExisting = value
        End Set
    End Property

    Public Property MovieExtrathumbsKeepExisting() As Boolean
        Get
            Return _XMLSettings.MovieExtrathumbsKeepExisting
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieExtrathumbsKeepExisting = value
        End Set
    End Property

    Public Property MovieFanartKeepExisting() As Boolean
        Get
            Return _XMLSettings.MovieFanartKeepExisting
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieFanartKeepExisting = value
        End Set
    End Property

    Public Property GeneralOverwriteNfo() As Boolean
        Get
            Return _XMLSettings.GeneralOverwriteNfo
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.GeneralOverwriteNfo = value
        End Set
    End Property

    Public Property MoviePosterKeepExisting() As Boolean
        Get
            Return _XMLSettings.MoviePosterKeepExisting
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MoviePosterKeepExisting = value
        End Set
    End Property

    Public Property TVSeasonBannerKeepExisting() As Boolean
        Get
            Return _XMLSettings.TVSeasonBannerKeepExisting
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVSeasonBannerKeepExisting = value
        End Set
    End Property

    Public Property TVShowCharacterArtKeepExisting() As Boolean
        Get
            Return _XMLSettings.TVShowCharacterArtKeepExisting
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVShowCharacterArtKeepExisting = value
        End Set
    End Property

    Public Property TVShowClearArtKeepExisting() As Boolean
        Get
            Return _XMLSettings.TVShowClearArtKeepExisting
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVShowClearArtKeepExisting = value
        End Set
    End Property

    Public Property TVShowClearLogoKeepExisting() As Boolean
        Get
            Return _XMLSettings.TVShowClearLogoKeepExisting
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVShowClearLogoKeepExisting = value
        End Set
    End Property

    Public Property TVSeasonLandscapeKeepExisting() As Boolean
        Get
            Return _XMLSettings.TVSeasonLandscapeKeepExisting
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVSeasonLandscapeKeepExisting = value
        End Set
    End Property

    Public Property TVShowLandscapeKeepExisting() As Boolean
        Get
            Return _XMLSettings.TVShowLandscapeKeepExisting
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVShowLandscapeKeepExisting = value
        End Set
    End Property

    Public Property TVSeasonFanartKeepExisting() As Boolean
        Get
            Return _XMLSettings.TVSeasonFanartKeepExisting
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVSeasonFanartKeepExisting = value
        End Set
    End Property

    Public Property TVSeasonPosterKeepExisting() As Boolean
        Get
            Return _XMLSettings.TVSeasonPosterKeepExisting
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVSeasonPosterKeepExisting = value
        End Set
    End Property

    Public Property TVShowBannerKeepExisting() As Boolean
        Get
            Return _XMLSettings.TVShowBannerKeepExisting
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVShowBannerKeepExisting = value
        End Set
    End Property

    Public Property TVShowFanartKeepExisting() As Boolean
        Get
            Return _XMLSettings.TVShowFanartKeepExisting
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVShowFanartKeepExisting = value
        End Set
    End Property

    Public Property TVShowPosterKeepExisting() As Boolean
        Get
            Return _XMLSettings.TVShowPosterKeepExisting
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVShowPosterKeepExisting = value
        End Set
    End Property

    Public Property MovieBannerKeepExisting() As Boolean
        Get
            Return _XMLSettings.MovieBannerKeepExisting
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieBannerKeepExisting = value
        End Set
    End Property

    Public Property MovieDiscArtKeepExisting() As Boolean
        Get
            Return _XMLSettings.MovieDiscArtKeepExisting
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieDiscArtKeepExisting = value
        End Set
    End Property

    Public Property MovieLandscapeKeepExisting() As Boolean
        Get
            Return _XMLSettings.MovieLandscapeKeepExisting
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieLandscapeKeepExisting = value
        End Set
    End Property

    Public Property MovieClearArtKeepExisting() As Boolean
        Get
            Return _XMLSettings.MovieClearArtKeepExisting
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieClearArtKeepExisting = value
        End Set
    End Property

    Public Property MovieClearLogoKeepExisting() As Boolean
        Get
            Return _XMLSettings.MovieClearLogoKeepExisting
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieClearLogoKeepExisting = value
        End Set
    End Property

    Public Property MovieSetBannerKeepExisting() As Boolean
        Get
            Return _XMLSettings.MovieSetBannerKeepExisting
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieSetBannerKeepExisting = value
        End Set
    End Property

    Public Property MovieSetClearArtKeepExisting() As Boolean
        Get
            Return _XMLSettings.MovieSetClearArtKeepExisting
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieSetClearArtKeepExisting = value
        End Set
    End Property

    Public Property MovieSetClearLogoKeepExisting() As Boolean
        Get
            Return _XMLSettings.MovieSetClearLogoKeepExisting
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieSetClearLogoKeepExisting = value
        End Set
    End Property

    Public Property MovieSetDiscArtKeepExisting() As Boolean
        Get
            Return _XMLSettings.MovieSetDiscArtKeepExisting
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieSetDiscArtKeepExisting = value
        End Set
    End Property

    Public Property MovieSetFanartKeepExisting() As Boolean
        Get
            Return _XMLSettings.MovieSetFanartKeepExisting
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieSetFanartKeepExisting = value
        End Set
    End Property

    Public Property MovieSetLandscapeKeepExisting() As Boolean
        Get
            Return _XMLSettings.MovieSetLandscapeKeepExisting
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieSetLandscapeKeepExisting = value
        End Set
    End Property

    Public Property MovieSetPosterKeepExisting() As Boolean
        Get
            Return _XMLSettings.MovieSetPosterKeepExisting
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieSetPosterKeepExisting = value
        End Set
    End Property

    Public Property MovieBannerPrefSizeOnly() As Boolean
        Get
            Return _XMLSettings.MovieBannerPrefSizeOnly
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieBannerPrefSizeOnly = value
        End Set
    End Property

    Public Property MovieBannerResize() As Boolean
        Get
            Return _XMLSettings.MovieBannerResize
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieBannerResize = value
        End Set
    End Property

    Public Property MovieTrailerKeepExisting() As Boolean
        Get
            Return _XMLSettings.MovieTrailerKeepExisting
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieTrailerKeepExisting = value
        End Set
    End Property

    Public Property MovieThemeKeepExisting() As Boolean
        Get
            Return _XMLSettings.MovieThemeKeepExisting
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieThemeKeepExisting = value
        End Set
    End Property

    Public Property TVShowThemeKeepExisting() As Boolean
        Get
            Return _XMLSettings.TVShowThemeKeepExisting
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVShowThemeKeepExisting = value
        End Set
    End Property

    Public Property MovieScraperPlotForOutline() As Boolean
        Get
            Return _XMLSettings.MovieScraperPlotForOutline
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieScraperPlotForOutline = value
        End Set
    End Property

    Public Property MovieScraperPlotForOutlineIfEmpty() As Boolean
        Get
            Return _XMLSettings.MovieScraperPlotForOutlineIfEmpty
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieScraperPlotForOutlineIfEmpty = value
        End Set
    End Property

    Public Property MovieScraperOutlineLimit() As Integer
        Get
            Return _XMLSettings.MovieScraperOutlineLimit
        End Get
        Set(ByVal value As Integer)
            _XMLSettings.MovieScraperOutlineLimit = value
        End Set
    End Property

    Public Property GeneralImagesGlassOverlay() As Boolean
        Get
            Return _XMLSettings.GeneralImagesGlassOverlay
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.GeneralImagesGlassOverlay = value
        End Set
    End Property

    Public Property MoviePosterHeight() As Integer
        Get
            Return _XMLSettings.MoviePosterHeight
        End Get
        Set(ByVal value As Integer)
            _XMLSettings.MoviePosterHeight = value
        End Set
    End Property

    Public Property MovieSetPosterHeight() As Integer
        Get
            Return _XMLSettings.MovieSetPosterHeight
        End Get
        Set(ByVal value As Integer)
            _XMLSettings.MovieSetPosterHeight = value
        End Set
    End Property

    Public Property MoviePosterPrefSizeOnly() As Boolean
        Get
            Return _XMLSettings.MoviePosterPrefSizeOnly
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MoviePosterPrefSizeOnly = value
        End Set
    End Property

    Public Property MoviePosterWidth() As Integer
        Get
            Return _XMLSettings.MoviePosterWidth
        End Get
        Set(ByVal value As Integer)
            _XMLSettings.MoviePosterWidth = value
        End Set
    End Property

    Public Property MovieSetPosterWidth() As Integer
        Get
            Return _XMLSettings.MovieSetPosterWidth
        End Get
        Set(ByVal value As Integer)
            _XMLSettings.MovieSetPosterWidth = value
        End Set
    End Property

    Public Property TVAllSeasonsPosterPrefSize() As Enums.TVPosterSize
        Get
            Return _XMLSettings.TVAllSeasonsPosterPrefSize
        End Get
        Set(ByVal value As Enums.TVPosterSize)
            _XMLSettings.TVAllSeasonsPosterPrefSize = value
        End Set
    End Property

    Public Property TVEpisodeFanartPrefSize() As Enums.TVFanartSize
        Get
            Return _XMLSettings.TVEpisodeFanartPrefSize
        End Get
        Set(ByVal value As Enums.TVFanartSize)
            _XMLSettings.TVEpisodeFanartPrefSize = value
        End Set
    End Property

    Public Property MovieFanartPrefSize() As Enums.MovieFanartSize
        Get
            Return _XMLSettings.MovieFanartPrefSize
        End Get
        Set(ByVal value As Enums.MovieFanartSize)
            _XMLSettings.MovieFanartPrefSize = value
        End Set
    End Property

    Public Property MovieSetFanartPrefSize() As Enums.MovieFanartSize
        Get
            Return _XMLSettings.MovieSetFanartPrefSize
        End Get
        Set(ByVal value As Enums.MovieFanartSize)
            _XMLSettings.MovieSetFanartPrefSize = value
        End Set
    End Property

    Public Property MovieExtrafanartsPrefSize() As Enums.MovieFanartSize
        Get
            Return _XMLSettings.MovieExtrafanartsPrefSize
        End Get
        Set(ByVal value As Enums.MovieFanartSize)
            _XMLSettings.MovieExtrafanartsPrefSize = value
        End Set
    End Property

    Public Property MovieExtrathumbsPrefSize() As Enums.MovieFanartSize
        Get
            Return _XMLSettings.MovieExtrathumbsPrefSize
        End Get
        Set(ByVal value As Enums.MovieFanartSize)
            _XMLSettings.MovieExtrathumbsPrefSize = value
        End Set
    End Property

    Public Property MoviePosterPrefSize() As Enums.MoviePosterSize
        Get
            Return _XMLSettings.MoviePosterPrefSize
        End Get
        Set(ByVal value As Enums.MoviePosterSize)
            _XMLSettings.MoviePosterPrefSize = value
        End Set
    End Property

    Public Property MovieSetPosterPrefSize() As Enums.MoviePosterSize
        Get
            Return _XMLSettings.MovieSetPosterPrefSize
        End Get
        Set(ByVal value As Enums.MoviePosterSize)
            _XMLSettings.MovieSetPosterPrefSize = value
        End Set
    End Property

    Public Property TVSeasonFanartPrefSize() As Enums.TVFanartSize
        Get
            Return _XMLSettings.TVSeasonFanartPrefSize
        End Get
        Set(ByVal value As Enums.TVFanartSize)
            _XMLSettings.TVSeasonFanartPrefSize = value
        End Set
    End Property

    Public Property TVAllSeasonsFanartPrefSize() As Enums.TVFanartSize
        Get
            Return _XMLSettings.TVAllSeasonsFanartPrefSize
        End Get
        Set(ByVal value As Enums.TVFanartSize)
            _XMLSettings.TVAllSeasonsFanartPrefSize = value
        End Set
    End Property

    Public Property TVAllSeasonsBannerPrefSizeOnly() As Boolean
        Get
            Return _XMLSettings.TVAllSeasonsBannerPrefSizeOnly
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVAllSeasonsBannerPrefSizeOnly = value
        End Set
    End Property

    Public Property TVAllSeasonsFanartPrefSizeOnly() As Boolean
        Get
            Return _XMLSettings.TVAllSeasonsFanartPrefSizeOnly
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVAllSeasonsFanartPrefSizeOnly = value
        End Set
    End Property

    Public Property TVAllSeasonsPosterPrefSizeOnly() As Boolean
        Get
            Return _XMLSettings.TVAllSeasonsPosterPrefSizeOnly
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVAllSeasonsPosterPrefSizeOnly = value
        End Set
    End Property

    Public Property TVEpisodeFanartPrefSizeOnly() As Boolean
        Get
            Return _XMLSettings.TVEpisodeFanartPrefSizeOnly
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVEpisodeFanartPrefSizeOnly = value
        End Set
    End Property

    Public Property TVEpisodePosterPrefSizeOnly() As Boolean
        Get
            Return _XMLSettings.TVEpisodePosterPrefSizeOnly
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVEpisodePosterPrefSizeOnly = value
        End Set
    End Property

    Public Property TVSeasonBannerPrefSizeOnly() As Boolean
        Get
            Return _XMLSettings.TVSeasonBannerPrefSizeOnly
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVSeasonBannerPrefSizeOnly = value
        End Set
    End Property

    Public Property TVSeasonFanartPrefSizeOnly() As Boolean
        Get
            Return _XMLSettings.TVSeasonFanartPrefSizeOnly
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVSeasonFanartPrefSizeOnly = value
        End Set
    End Property

    Public Property TVSeasonPosterPrefSizeOnly() As Boolean
        Get
            Return _XMLSettings.TVSeasonPosterPrefSizeOnly
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVSeasonPosterPrefSizeOnly = value
        End Set
    End Property

    Public Property TVShowBannerPrefSizeOnly() As Boolean
        Get
            Return _XMLSettings.TVShowBannerPrefSizeOnly
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVShowBannerPrefSizeOnly = value
        End Set
    End Property

    Public Property TVShowExtrafanartsPrefSizeOnly() As Boolean
        Get
            Return _XMLSettings.TVShowExtrafanartsPrefSizeOnly
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVShowExtrafanartsPrefSizeOnly = value
        End Set
    End Property

    Public Property TVShowFanartPrefSizeOnly() As Boolean
        Get
            Return _XMLSettings.TVShowFanartPrefSizeOnly
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVShowFanartPrefSizeOnly = value
        End Set
    End Property

    Public Property TVShowPosterPrefSizeOnly() As Boolean
        Get
            Return _XMLSettings.TVShowPosterPrefSizeOnly
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVShowPosterPrefSizeOnly = value
        End Set
    End Property

    Public Property TVEpisodePosterPrefSize() As Enums.TVEpisodePosterSize
        Get
            Return _XMLSettings.TVEpisodePosterPrefSize
        End Get
        Set(ByVal value As Enums.TVEpisodePosterSize)
            _XMLSettings.TVEpisodePosterPrefSize = value
        End Set
    End Property

    Public Property TVSeasonPosterPrefSize() As Enums.TVSeasonPosterSize
        Get
            Return _XMLSettings.TVSeasonPosterPrefSize
        End Get
        Set(ByVal value As Enums.TVSeasonPosterSize)
            _XMLSettings.TVSeasonPosterPrefSize = value
        End Set
    End Property

    Public Property TVShowBannerPrefSize() As Enums.TVBannerSize
        Get
            Return _XMLSettings.TVShowBannerPrefSize
        End Get
        Set(ByVal value As Enums.TVBannerSize)
            _XMLSettings.TVShowBannerPrefSize = value
        End Set
    End Property

    Public Property TVShowBannerPrefType() As Enums.TVBannerType
        Get
            Return _XMLSettings.TVShowBannerPrefType
        End Get
        Set(ByVal value As Enums.TVBannerType)
            _XMLSettings.TVShowBannerPrefType = value
        End Set
    End Property

    Public Property MovieBannerPrefSize() As Enums.MovieBannerSize
        Get
            Return _XMLSettings.MovieBannerPrefSize
        End Get
        Set(ByVal value As Enums.MovieBannerSize)
            _XMLSettings.MovieBannerPrefSize = value
        End Set
    End Property

    Public Property MovieSetBannerPrefSize() As Enums.MovieBannerSize
        Get
            Return _XMLSettings.MovieSetBannerPrefSize
        End Get
        Set(ByVal value As Enums.MovieBannerSize)
            _XMLSettings.MovieSetBannerPrefSize = value
        End Set
    End Property

    Public Property TVAllSeasonsBannerPrefSize() As Enums.TVBannerSize
        Get
            Return _XMLSettings.TVAllSeasonsBannerPrefSize
        End Get
        Set(ByVal value As Enums.TVBannerSize)
            _XMLSettings.TVAllSeasonsBannerPrefSize = value
        End Set
    End Property

    Public Property TVAllSeasonsBannerPrefType() As Enums.TVBannerType
        Get
            Return _XMLSettings.TVAllSeasonsBannerPrefType
        End Get
        Set(ByVal value As Enums.TVBannerType)
            _XMLSettings.TVAllSeasonsBannerPrefType = value
        End Set
    End Property

    Public Property TVSeasonBannerPrefSize() As Enums.TVBannerSize
        Get
            Return _XMLSettings.TVSeasonBannerPrefSize
        End Get
        Set(ByVal value As Enums.TVBannerSize)
            _XMLSettings.TVSeasonBannerPrefSize = value
        End Set
    End Property

    Public Property TVSeasonBannerPrefType() As Enums.TVBannerType
        Get
            Return _XMLSettings.TVSeasonBannerPrefType
        End Get
        Set(ByVal value As Enums.TVBannerType)
            _XMLSettings.TVSeasonBannerPrefType = value
        End Set
    End Property

    Public Property TVShowExtrafanartsPrefSize() As Enums.TVFanartSize
        Get
            Return _XMLSettings.TVShowExtrafanartsPrefSize
        End Get
        Set(ByVal value As Enums.TVFanartSize)
            _XMLSettings.TVShowExtrafanartsPrefSize = value
        End Set
    End Property

    Public Property TVShowFanartPrefSize() As Enums.TVFanartSize
        Get
            Return _XMLSettings.TVShowFanartPrefSize
        End Get
        Set(ByVal value As Enums.TVFanartSize)
            _XMLSettings.TVShowFanartPrefSize = value
        End Set
    End Property

    Public Property TVShowPosterPrefSize() As Enums.TVPosterSize
        Get
            Return _XMLSettings.TVShowPosterPrefSize
        End Get
        Set(ByVal value As Enums.TVPosterSize)
            _XMLSettings.TVShowPosterPrefSize = value
        End Set
    End Property

    Public Property MovieTrailerMinVideoQual() As Enums.TrailerVideoQuality
        Get
            Return _XMLSettings.MovieTrailerMinVideoQual
        End Get
        Set(ByVal value As Enums.TrailerVideoQuality)
            _XMLSettings.MovieTrailerMinVideoQual = value
        End Set
    End Property

    Public Property MovieTrailerPrefVideoQual() As Enums.TrailerVideoQuality
        Get
            Return _XMLSettings.MovieTrailerPrefVideoQual
        End Get
        Set(ByVal value As Enums.TrailerVideoQuality)
            _XMLSettings.MovieTrailerPrefVideoQual = value
        End Set
    End Property

    Public Property MovieProperCase() As Boolean
        Get
            Return _XMLSettings.MovieProperCase
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieProperCase = value
        End Set
    End Property

    Public Property ProxyCredentials() As NetworkCredential
        Get
            Return _XMLSettings.ProxyCredentials
        End Get
        Set(ByVal value As NetworkCredential)
            _XMLSettings.ProxyCredentials = value
        End Set
    End Property

    Public Property ProxyPort() As Integer
        Get
            Return _XMLSettings.ProxyPort
        End Get
        Set(ByVal value As Integer)
            _XMLSettings.ProxyPort = value
        End Set
    End Property

    Public Property ProxyURI() As String
        Get
            Return _XMLSettings.ProxyURI
        End Get
        Set(ByVal value As String)
            _XMLSettings.ProxyURI = value
        End Set
    End Property

    Public Property TVAllSeasonsBannerResize() As Boolean
        Get
            Return _XMLSettings.TVAllSeasonsBannerResize
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVAllSeasonsBannerResize = value
        End Set
    End Property

    Public Property TVAllSeasonsPosterResize() As Boolean
        Get
            Return _XMLSettings.TVAllSeasonsPosterResize
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVAllSeasonsPosterResize = value
        End Set
    End Property

    Public Property TVAllSeasonsFanartResize() As Boolean
        Get
            Return _XMLSettings.TVAllSeasonsFanartResize
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVAllSeasonsFanartResize = value
        End Set
    End Property

    Public Property TVEpisodeFanartResize() As Boolean
        Get
            Return _XMLSettings.TVEpisodeFanartResize
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVEpisodeFanartResize = value
        End Set
    End Property

    Public Property TVEpisodePosterResize() As Boolean
        Get
            Return _XMLSettings.TVEpisodePosterResize
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVEpisodePosterResize = value
        End Set
    End Property

    Public Property TVShowExtrafanartsResize() As Boolean
        Get
            Return _XMLSettings.TVShowExtrafanartsResize
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVShowExtrafanartsResize = value
        End Set
    End Property

    Public Property MovieExtrafanartsResize() As Boolean
        Get
            Return _XMLSettings.MovieExtrafanartsResize
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieExtrafanartsResize = value
        End Set
    End Property

    Public Property MovieExtrafanartsPreselect() As Boolean
        Get
            Return _XMLSettings.MovieExtrafanartsPreselect
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieExtrafanartsPreselect = value
        End Set
    End Property

    Public Property MovieExtrathumbsPreselect() As Boolean
        Get
            Return _XMLSettings.MovieExtrathumbsPreselect
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieExtrathumbsPreselect = value
        End Set
    End Property

    Public Property TVShowExtrafanartsPreselect() As Boolean
        Get
            Return _XMLSettings.TVShowExtrafanartsPreselect
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVShowExtrafanartsPreselect = value
        End Set
    End Property

    Public Property MovieExtrathumbsResize() As Boolean
        Get
            Return _XMLSettings.MovieExtrathumbsResize
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieExtrathumbsResize = value
        End Set
    End Property

    Public Property MovieFanartResize() As Boolean
        Get
            Return _XMLSettings.MovieFanartResize
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieFanartResize = value
        End Set
    End Property

    Public Property MoviePosterResize() As Boolean
        Get
            Return _XMLSettings.MoviePosterResize
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MoviePosterResize = value
        End Set
    End Property

    Public Property TVSeasonBannerResize() As Boolean
        Get
            Return _XMLSettings.TVSeasonBannerResize
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVSeasonBannerResize = value
        End Set
    End Property

    Public Property TVSeasonFanartResize() As Boolean
        Get
            Return _XMLSettings.TVSeasonFanartResize
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVSeasonFanartResize = value
        End Set
    End Property

    Public Property TVSeasonPosterResize() As Boolean
        Get
            Return _XMLSettings.TVSeasonPosterResize
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVSeasonPosterResize = value
        End Set
    End Property

    Public Property TVShowBannerResize() As Boolean
        Get
            Return _XMLSettings.TVShowBannerResize
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVShowBannerResize = value
        End Set
    End Property

    Public Property TVShowFanartResize() As Boolean
        Get
            Return _XMLSettings.TVShowFanartResize
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVShowFanartResize = value
        End Set
    End Property

    Public Property TVShowPosterResize() As Boolean
        Get
            Return _XMLSettings.TVShowPosterResize
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVShowPosterResize = value
        End Set
    End Property

    Public Property MovieScraperDurationRuntimeFormat() As String
        Get
            Return _XMLSettings.MovieScraperDurationRuntimeFormat
        End Get
        Set(ByVal value As String)
            _XMLSettings.MovieScraperDurationRuntimeFormat = value
        End Set
    End Property

    Public Property TVScraperDurationRuntimeFormat() As String
        Get
            Return _XMLSettings.TVScraperDurationRuntimeFormat
        End Get
        Set(ByVal value As String)
            _XMLSettings.TVScraperDurationRuntimeFormat = value
        End Set
    End Property

    Public Property MovieScraperMetaDataScan() As Boolean
        Get
            Return _XMLSettings.MovieScraperMetaDataScan
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieScraperMetaDataScan = value
        End Set
    End Property

    Public Property MovieScanOrderModify() As Boolean
        Get
            Return _XMLSettings.MovieScanOrderModify
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieScanOrderModify = value
        End Set
    End Property

    Public Property TVScraperMetaDataScan() As Boolean
        Get
            Return _XMLSettings.TVScraperMetaDataScan
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVScraperMetaDataScan = value
        End Set
    End Property

    Public Property TVScraperEpisodeActors() As Boolean
        Get
            Return _XMLSettings.TVScraperEpisodeActors
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVScraperEpisodeActors = value
        End Set
    End Property

    Public Property TVScraperEpisodeAired() As Boolean
        Get
            Return _XMLSettings.TVScraperEpisodeAired
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVScraperEpisodeAired = value
        End Set
    End Property

    Public Property TVScraperEpisodeCredits() As Boolean
        Get
            Return _XMLSettings.TVScraperEpisodeCredits
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVScraperEpisodeCredits = value
        End Set
    End Property

    Public Property TVScraperEpisodeDirector() As Boolean
        Get
            Return _XMLSettings.TVScraperEpisodeDirector
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVScraperEpisodeDirector = value
        End Set
    End Property

    Public Property TVScraperEpisodeGuestStars() As Boolean
        Get
            Return _XMLSettings.TVScraperEpisodeGuestStars
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVScraperEpisodeGuestStars = value
        End Set
    End Property

    Public Property TVScraperEpisodeGuestStarsToActors() As Boolean
        Get
            Return _XMLSettings.TVScraperEpisodeGuestStarsToActors
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVScraperEpisodeGuestStarsToActors = value
        End Set
    End Property

    Public Property TVScraperEpisodePlot() As Boolean
        Get
            Return _XMLSettings.TVScraperEpisodePlot
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVScraperEpisodePlot = value
        End Set
    End Property

    Public Property TVScraperEpisodeRating() As Boolean
        Get
            Return _XMLSettings.TVScraperEpisodeRating
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVScraperEpisodeRating = value
        End Set
    End Property

    Public Property TVScraperEpisodeUserRating() As Boolean
        Get
            Return _XMLSettings.TVScraperEpisodeUserRating
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVScraperEpisodeUserRating = value
        End Set
    End Property

    Public Property TVScraperEpisodeRuntime() As Boolean
        Get
            Return _XMLSettings.TVScraperEpisodeRuntime
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVScraperEpisodeRuntime = value
        End Set
    End Property

    Public Property TVScraperEpisodeTitle() As Boolean
        Get
            Return _XMLSettings.TVScraperEpisodeTitle
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVScraperEpisodeTitle = value
        End Set
    End Property

    Public Property TVScraperSeasonAired() As Boolean
        Get
            Return _XMLSettings.TVScraperSeasonAired
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVScraperSeasonAired = value
        End Set
    End Property

    Public Property TVScraperSeasonPlot() As Boolean
        Get
            Return _XMLSettings.TVScraperSeasonPlot
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVScraperSeasonPlot = value
        End Set
    End Property

    Public Property TVScraperSeasonTitle() As Boolean
        Get
            Return _XMLSettings.TVScraperSeasonTitle
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVScraperSeasonTitle = value
        End Set
    End Property

    Public Property TVScraperShowActors() As Boolean
        Get
            Return _XMLSettings.TVScraperShowActors
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVScraperShowActors = value
        End Set
    End Property

    Public Property TVScraperShowCreators() As Boolean
        Get
            Return _XMLSettings.TVScraperShowCreators
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVScraperShowCreators = value
        End Set
    End Property

    Public Property TVScraperShowCountry() As Boolean
        Get
            Return _XMLSettings.TVScraperShowCountry
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVScraperShowCountry = value
        End Set
    End Property

    Public Property TVScraperShowEpiGuideURL() As Boolean
        Get
            Return _XMLSettings.TVScraperShowEpiGuideURL
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVScraperShowEpiGuideURL = value
        End Set
    End Property

    Public Property TVScraperShowGenre() As Boolean
        Get
            Return _XMLSettings.TVScraperShowGenre
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVScraperShowGenre = value
        End Set
    End Property

    Public Property TVScraperShowMPAA() As Boolean
        Get
            Return _XMLSettings.TVScraperShowMPAA
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVScraperShowMPAA = value
        End Set
    End Property

    Public Property TVScraperShowOriginalTitle() As Boolean
        Get
            Return _XMLSettings.TVScraperShowOriginalTitle
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVScraperShowOriginalTitle = value
        End Set
    End Property

    Public Property TVScraperShowCert() As Boolean
        Get
            Return _XMLSettings.TVScraperShowCert
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVScraperShowCert = value
        End Set
    End Property

    Public Property TVScraperShowCertLang() As String
        Get
            Return _XMLSettings.TVScraperShowCertLang
        End Get
        Set(ByVal value As String)
            _XMLSettings.TVScraperShowCertLang = value
        End Set
    End Property

    Public Property TVScraperShowMPAANotRated() As String
        Get
            Return _XMLSettings.TVScraperShowMPAANotRated
        End Get
        Set(ByVal value As String)
            _XMLSettings.TVScraperShowMPAANotRated = value
        End Set
    End Property

    Public Property TVScraperShowPlot() As Boolean
        Get
            Return _XMLSettings.TVScraperShowPlot
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVScraperShowPlot = value
        End Set
    End Property

    Public Property TVScraperShowPremiered() As Boolean
        Get
            Return _XMLSettings.TVScraperShowPremiered
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVScraperShowPremiered = value
        End Set
    End Property

    Public Property TVScraperShowRating() As Boolean
        Get
            Return _XMLSettings.TVScraperShowRating
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVScraperShowRating = value
        End Set
    End Property

    Public Property TVScraperShowUserRating() As Boolean
        Get
            Return _XMLSettings.TVScraperShowUserRating
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVScraperShowUserRating = value
        End Set
    End Property

    Public Property TVScraperShowRuntime() As Boolean
        Get
            Return _XMLSettings.TVScraperShowRuntime
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVScraperShowRuntime = value
        End Set
    End Property

    Public Property TVScraperShowStatus() As Boolean
        Get
            Return _XMLSettings.TVScraperShowStatus
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVScraperShowStatus = value
        End Set
    End Property

    Public Property TVScraperShowStudio() As Boolean
        Get
            Return _XMLSettings.TVScraperShowStudio
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVScraperShowStudio = value
        End Set
    End Property

    Public Property TVScraperShowTitle() As Boolean
        Get
            Return _XMLSettings.TVScraperShowTitle
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVScraperShowTitle = value
        End Set
    End Property

    Public Property TVSeasonFanartHeight() As Integer
        Get
            Return _XMLSettings.TVSeasonFanartHeight
        End Get
        Set(ByVal value As Integer)
            _XMLSettings.TVSeasonFanartHeight = value
        End Set
    End Property

    Public Property TVSeasonFanartWidth() As Integer
        Get
            Return _XMLSettings.TVSeasonFanartWidth
        End Get
        Set(ByVal value As Integer)
            _XMLSettings.TVSeasonFanartWidth = value
        End Set
    End Property

    Public Property TVAllSeasonsBannerWidth() As Integer
        Get
            Return _XMLSettings.TVAllSeasonsBannerWidth
        End Get
        Set(ByVal value As Integer)
            _XMLSettings.TVAllSeasonsBannerWidth = value
        End Set
    End Property

    Public Property TVSeasonBannerWidth() As Integer
        Get
            Return _XMLSettings.TVSeasonBannerWidth
        End Get
        Set(ByVal value As Integer)
            _XMLSettings.TVSeasonBannerWidth = value
        End Set
    End Property

    Public Property TVAllSeasonsFanartWidth() As Integer
        Get
            Return _XMLSettings.TVAllSeasonsFanartWidth
        End Get
        Set(ByVal value As Integer)
            _XMLSettings.TVAllSeasonsFanartWidth = value
        End Set
    End Property

    Public Property TVShowBannerWidth() As Integer
        Get
            Return _XMLSettings.TVShowBannerWidth
        End Get
        Set(ByVal value As Integer)
            _XMLSettings.TVShowBannerWidth = value
        End Set
    End Property

    Public Property MovieBannerWidth() As Integer
        Get
            Return _XMLSettings.MovieBannerWidth
        End Get
        Set(ByVal value As Integer)
            _XMLSettings.MovieBannerWidth = value
        End Set
    End Property

    Public Property MovieSetBannerWidth() As Integer
        Get
            Return _XMLSettings.MovieSetBannerWidth
        End Get
        Set(ByVal value As Integer)
            _XMLSettings.MovieSetBannerWidth = value
        End Set
    End Property

    Public Property TVAllSeasonsBannerHeight() As Integer
        Get
            Return _XMLSettings.TVAllSeasonsBannerHeight
        End Get
        Set(ByVal value As Integer)
            _XMLSettings.TVAllSeasonsBannerHeight = value
        End Set
    End Property

    Public Property TVSeasonBannerHeight() As Integer
        Get
            Return _XMLSettings.TVSeasonBannerHeight
        End Get
        Set(ByVal value As Integer)
            _XMLSettings.TVSeasonBannerHeight = value
        End Set
    End Property

    Public Property TVAllSeasonsFanartHeight() As Integer
        Get
            Return _XMLSettings.TVAllSeasonsFanartHeight
        End Get
        Set(ByVal value As Integer)
            _XMLSettings.TVAllSeasonsFanartHeight = value
        End Set
    End Property

    Public Property TVShowBannerHeight() As Integer
        Get
            Return _XMLSettings.TVShowBannerHeight
        End Get
        Set(ByVal value As Integer)
            _XMLSettings.TVShowBannerHeight = value
        End Set
    End Property

    Public Property MovieBannerHeight() As Integer
        Get
            Return _XMLSettings.MovieBannerHeight
        End Get
        Set(ByVal value As Integer)
            _XMLSettings.MovieBannerHeight = value
        End Set
    End Property

    Public Property MovieSetBannerHeight() As Integer
        Get
            Return _XMLSettings.MovieSetBannerHeight
        End Get
        Set(ByVal value As Integer)
            _XMLSettings.MovieSetBannerHeight = value
        End Set
    End Property

    Public Property TVSeasonPosterHeight() As Integer
        Get
            Return _XMLSettings.TVSeasonPosterHeight
        End Get
        Set(ByVal value As Integer)
            _XMLSettings.TVSeasonPosterHeight = value
        End Set
    End Property

    Public Property TVSeasonPosterWidth() As Integer
        Get
            Return _XMLSettings.TVSeasonPosterWidth
        End Get
        Set(ByVal value As Integer)
            _XMLSettings.TVSeasonPosterWidth = value
        End Set
    End Property

    Public Property GeneralShowLangFlags() As Boolean
        Get
            Return _XMLSettings.GeneralShowLangFlags
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.GeneralShowLangFlags = value
        End Set
    End Property

    Public Property GeneralShowImgDims() As Boolean
        Get
            Return _XMLSettings.GeneralShowImgDims
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.GeneralShowImgDims = value
        End Set
    End Property

    Public Property GeneralShowImgNames() As Boolean
        Get
            Return _XMLSettings.GeneralShowImgNames
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.GeneralShowImgNames = value
        End Set
    End Property

    Public Property TVShowFanartHeight() As Integer
        Get
            Return _XMLSettings.TVShowFanartHeight
        End Get
        Set(ByVal value As Integer)
            _XMLSettings.TVShowFanartHeight = value
        End Set
    End Property

    Public Property TVShowFanartWidth() As Integer
        Get
            Return _XMLSettings.TVShowFanartWidth
        End Get
        Set(ByVal value As Integer)
            _XMLSettings.TVShowFanartWidth = value
        End Set
    End Property

    Public Property TVShowFilterCustom() As List(Of String)
        Get
            Return _XMLSettings.TVShowFilterCustom
        End Get
        Set(ByVal value As List(Of String))
            _XMLSettings.TVShowFilterCustom = value
        End Set
    End Property

    Public Property GeneralInfoPanelStateTVShow() As Integer
        Get
            Return _XMLSettings.GeneralInfoPanelStateTVShow
        End Get
        Set(ByVal value As Integer)
            _XMLSettings.GeneralInfoPanelStateTVShow = value
        End Set
    End Property

    Public Property TVLockShowGenre() As Boolean
        Get
            Return _XMLSettings.TVLockShowGenre
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVLockShowGenre = value
        End Set
    End Property

    Public Property TVLockShowOriginalTitle() As Boolean
        Get
            Return _XMLSettings.TVLockShowOriginalTitle
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVLockShowOriginalTitle = value
        End Set
    End Property

    Public Property TVLockShowPlot() As Boolean
        Get
            Return _XMLSettings.TVLockShowPlot
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVLockShowPlot = value
        End Set
    End Property

    Public Property TVLockSeasonPlot() As Boolean
        Get
            Return _XMLSettings.TVLockSeasonPlot
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVLockSeasonPlot = value
        End Set
    End Property

    Public Property TVLockSeasonTitle() As Boolean
        Get
            Return _XMLSettings.TVLockSeasonTitle
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVLockSeasonTitle = value
        End Set
    End Property

    Public Property TVLockShowRating() As Boolean
        Get
            Return _XMLSettings.TVLockShowRating
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVLockShowRating = value
        End Set
    End Property

    Public Property TVLockShowUserRating() As Boolean
        Get
            Return _XMLSettings.TVLockShowUserRating
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVLockShowUserRating = value
        End Set
    End Property

    Public Property TVLockShowRuntime() As Boolean
        Get
            Return _XMLSettings.TVLockShowRuntime
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVLockShowRuntime = value
        End Set
    End Property

    Public Property TVLockShowStatus() As Boolean
        Get
            Return _XMLSettings.TVLockShowStatus
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVLockShowStatus = value
        End Set
    End Property

    Public Property TVLockShowStudio() As Boolean
        Get
            Return _XMLSettings.TVLockShowStudio
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVLockShowStudio = value
        End Set
    End Property

    Public Property TVLockShowTitle() As Boolean
        Get
            Return _XMLSettings.TVLockShowTitle
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVLockShowTitle = value
        End Set
    End Property

    Public Property TVLockShowMPAA() As Boolean
        Get
            Return _XMLSettings.TVLockShowMPAA
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVLockShowMPAA = value
        End Set
    End Property

    Public Property TVLockShowPremiered() As Boolean
        Get
            Return _XMLSettings.TVLockShowPremiered
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVLockShowPremiered = value
        End Set
    End Property

    Public Property TVLockShowActors() As Boolean
        Get
            Return _XMLSettings.TVLockShowActors
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVLockShowActors = value
        End Set
    End Property

    Public Property TVLockShowCountry() As Boolean
        Get
            Return _XMLSettings.TVLockShowCountry
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVLockShowCountry = value
        End Set
    End Property

    Public Property TVLockShowCert() As Boolean
        Get
            Return _XMLSettings.TVLockShowCert
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVLockShowCert = value
        End Set
    End Property

    Public Property TVLockShowCreators() As Boolean
        Get
            Return _XMLSettings.TVLockShowCreators
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVLockShowCreators = value
        End Set
    End Property

    Public Property TVShowPosterHeight() As Integer
        Get
            Return _XMLSettings.TVShowPosterHeight
        End Get
        Set(ByVal value As Integer)
            _XMLSettings.TVShowPosterHeight = value
        End Set
    End Property

    Public Property TVShowPosterWidth() As Integer
        Get
            Return _XMLSettings.TVShowPosterWidth
        End Get
        Set(ByVal value As Integer)
            _XMLSettings.TVShowPosterWidth = value
        End Set
    End Property

    Public Property TVShowProperCase() As Boolean
        Get
            Return _XMLSettings.TVShowProperCase
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVShowProperCase = value
        End Set
    End Property

    Public Property MovieSkipLessThan() As Integer
        Get
            Return _XMLSettings.MovieSkipLessThan
        End Get
        Set(ByVal value As Integer)
            _XMLSettings.MovieSkipLessThan = value
        End Set
    End Property

    Public Property MovieSkipStackedSizeCheck() As Boolean
        Get
            Return _XMLSettings.MovieSkipStackedSizeCheck
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieSkipStackedSizeCheck = value
        End Set
    End Property

    Public Property TVSkipLessThan() As Integer
        Get
            Return _XMLSettings.TVSkipLessThan
        End Get
        Set(ByVal value As Integer)
            _XMLSettings.TVSkipLessThan = value
        End Set
    End Property

    Public Property MovieSortBeforeScan() As Boolean
        Get
            Return _XMLSettings.MovieSortBeforeScan
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieSortBeforeScan = value
        End Set
    End Property

    Public Property SortPath() As String
        Get
            Return _XMLSettings.SortPath
        End Get
        Set(ByVal value As String)
            _XMLSettings.SortPath = value
        End Set
    End Property

    Public Property MovieSortTokens() As List(Of String)
        Get
            Return _XMLSettings.MovieSortTokens
        End Get
        Set(ByVal value As List(Of String))
            _XMLSettings.MovieSortTokens = value
        End Set
    End Property

    Public Property MovieSetSortTokens() As List(Of String)
        Get
            Return _XMLSettings.MovieSetSortTokens
        End Get
        Set(ByVal value As List(Of String))
            _XMLSettings.MovieSetSortTokens = value
        End Set
    End Property

    Public Property TVSortTokens() As List(Of String)
        Get
            Return _XMLSettings.TVSortTokens
        End Get
        Set(ByVal value As List(Of String))
            _XMLSettings.TVSortTokens = value
        End Set
    End Property

    Public Property GeneralSourceFromFolder() As Boolean
        Get
            Return _XMLSettings.GeneralSourceFromFolder
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.GeneralSourceFromFolder = value
        End Set
    End Property

    Public Property GeneralMainFilterSortColumn_Movies() As Integer
        Get
            Return _XMLSettings.GeneralMainFilterSortColumn_Movies
        End Get
        Set(ByVal value As Integer)
            _XMLSettings.GeneralMainFilterSortColumn_Movies = value
        End Set
    End Property

    Public Property GeneralMainFilterSortColumn_MovieSets() As Integer
        Get
            Return _XMLSettings.GeneralMainFilterSortColumn_MovieSets
        End Get
        Set(ByVal value As Integer)
            _XMLSettings.GeneralMainFilterSortColumn_MovieSets = value
        End Set
    End Property

    Public Property GeneralMainFilterSortColumn_Shows() As Integer
        Get
            Return _XMLSettings.GeneralMainFilterSortColumn_Shows
        End Get
        Set(ByVal value As Integer)
            _XMLSettings.GeneralMainFilterSortColumn_Shows = value
        End Set
    End Property

    Public Property GeneralMainFilterSortOrder_Movies() As Integer
        Get
            Return _XMLSettings.GeneralMainFilterSortOrder_Movies
        End Get
        Set(ByVal value As Integer)
            _XMLSettings.GeneralMainFilterSortOrder_Movies = value
        End Set
    End Property

    Public Property GeneralMainFilterSortOrder_MovieSets() As Integer
        Get
            Return _XMLSettings.GeneralMainFilterSortOrder_MovieSets
        End Get
        Set(ByVal value As Integer)
            _XMLSettings.GeneralMainFilterSortOrder_MovieSets = value
        End Set
    End Property

    Public Property GeneralMainFilterSortOrder_Shows() As Integer
        Get
            Return _XMLSettings.GeneralMainFilterSortOrder_Shows
        End Get
        Set(ByVal value As Integer)
            _XMLSettings.GeneralMainFilterSortOrder_Shows = value
        End Set
    End Property

    Public Property GeneralSplitterDistanceMain() As Integer
        Get
            Return _XMLSettings.GeneralSplitterDistanceMain
        End Get
        Set(ByVal value As Integer)
            _XMLSettings.GeneralSplitterDistanceMain = value
        End Set
    End Property

    Public Property GeneralSplitterDistanceTVShow() As Integer
        Get
            Return _XMLSettings.GeneralSplitterDistanceTVShow
        End Get
        Set(ByVal value As Integer)
            _XMLSettings.GeneralSplitterDistanceTVShow = value
        End Set
    End Property

    Public Property GeneralSplitterDistanceTVSeason() As Integer
        Get
            Return _XMLSettings.GeneralSplitterDistanceTVSeason
        End Get
        Set(ByVal value As Integer)
            _XMLSettings.GeneralSplitterDistanceTVSeason = value
        End Set
    End Property

    Public Property TVCleanDB() As Boolean
        Get
            Return _XMLSettings.TVCleanDB
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVCleanDB = value
        End Set
    End Property

    Public Property GeneralTVEpisodeTheme() As String
        Get
            Return _XMLSettings.GeneralTVEpisodeTheme
        End Get
        Set(ByVal value As String)
            _XMLSettings.GeneralTVEpisodeTheme = value
        End Set
    End Property

    Public Property TVGeneralFlagLang() As String
        Get
            Return _XMLSettings.TVGeneralFlagLang
        End Get
        Set(ByVal value As String)
            _XMLSettings.TVGeneralFlagLang = value
        End Set
    End Property

    Public Property TVGeneralIgnoreLastScan() As Boolean
        Get
            Return _XMLSettings.TVGeneralIgnoreLastScan
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVGeneralIgnoreLastScan = value
        End Set
    End Property

    Public Property TVMetadataPerFileType() As List(Of MetadataPerType)
        Get
            Return _XMLSettings.TVMetadataPerFileType
        End Get
        Set(ByVal value As List(Of MetadataPerType))
            _XMLSettings.TVMetadataPerFileType = value
        End Set
    End Property

    Public Property TVScanOrderModify() As Boolean
        Get
            Return _XMLSettings.TVScanOrderModify
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVScanOrderModify = value
        End Set
    End Property

    Public Property TVMultiPartMatching() As String
        Get
            Return _XMLSettings.TVMultiPartMatching
        End Get
        Set(ByVal value As String)
            _XMLSettings.TVMultiPartMatching = value
        End Set
    End Property

    Public Property TVShowMatching() As List(Of regexp)
        Get
            Return _XMLSettings.TVShowMatching
        End Get
        Set(ByVal value As List(Of regexp))
            _XMLSettings.TVShowMatching = value
        End Set
    End Property

    Public Property MovieGeneralMediaListSorting() As List(Of ListSorting)
        Get
            Return _XMLSettings.MovieGeneralMediaListSorting
        End Get
        Set(ByVal value As List(Of ListSorting))
            _XMLSettings.MovieGeneralMediaListSorting = value
        End Set
    End Property

    Public Property MovieSetGeneralMediaListSorting() As List(Of ListSorting)
        Get
            Return _XMLSettings.MovieSetGeneralMediaListSorting
        End Get
        Set(ByVal value As List(Of ListSorting))
            _XMLSettings.MovieSetGeneralMediaListSorting = value
        End Set
    End Property

    Public Property TVGeneralEpisodeListSorting() As List(Of ListSorting)
        Get
            Return _XMLSettings.TVGeneralEpisodeListSorting
        End Get
        Set(ByVal value As List(Of ListSorting))
            _XMLSettings.TVGeneralEpisodeListSorting = value
        End Set
    End Property

    Public Property TVGeneralSeasonListSorting() As List(Of ListSorting)
        Get
            Return _XMLSettings.TVGeneralSeasonListSorting
        End Get
        Set(ByVal value As List(Of ListSorting))
            _XMLSettings.TVGeneralSeasonListSorting = value
        End Set
    End Property

    Public Property TVGeneralShowListSorting() As List(Of ListSorting)
        Get
            Return _XMLSettings.TVGeneralShowListSorting
        End Get
        Set(ByVal value As List(Of ListSorting))
            _XMLSettings.TVGeneralShowListSorting = value
        End Set
    End Property

    Public Property GeneralTVShowTheme() As String
        Get
            Return _XMLSettings.GeneralTVShowTheme
        End Get
        Set(ByVal value As String)
            _XMLSettings.GeneralTVShowTheme = value
        End Set
    End Property

    Public Property MovieScraperCertForMPAA() As Boolean
        Get
            Return _XMLSettings.MovieScraperCertForMPAA
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieScraperCertForMPAA = value
        End Set
    End Property

    Public Property TVScraperShowCertForMPAA() As Boolean
        Get
            Return _XMLSettings.TVScraperShowCertForMPAA
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVScraperShowCertForMPAA = value
        End Set
    End Property

    Public Property MovieScraperCertForMPAAFallback() As Boolean
        Get
            Return _XMLSettings.MovieScraperCertForMPAAFallback
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieScraperCertForMPAAFallback = value
        End Set
    End Property

    Public Property TVScraperShowCertForMPAAFallback() As Boolean
        Get
            Return _XMLSettings.TVScraperShowCertForMPAAFallback
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVScraperShowCertForMPAAFallback = value
        End Set
    End Property

    Public Property TVScraperUseDisplaySeasonEpisode() As Boolean
        Get
            Return _XMLSettings.TVScraperUseDisplaySeasonEpisode
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVScraperUseDisplaySeasonEpisode = value
        End Set
    End Property

    Public Property MovieScraperUseMDDuration() As Boolean
        Get
            Return _XMLSettings.MovieScraperUseMDDuration
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieScraperUseMDDuration = value
        End Set
    End Property

    Public Property TVScraperUseMDDuration() As Boolean
        Get
            Return _XMLSettings.TVScraperUseMDDuration
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVScraperUseMDDuration = value
        End Set
    End Property

    Public Property TVScraperUseSRuntimeForEp() As Boolean
        Get
            Return _XMLSettings.TVScraperUseSRuntimeForEp
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVScraperUseSRuntimeForEp = value
        End Set
    End Property

    Public Property FileSystemValidExts() As List(Of String)
        Get
            Return _XMLSettings.FileSystemValidExts
        End Get
        Set(ByVal value As List(Of String))
            _XMLSettings.FileSystemValidExts = value
        End Set
    End Property

    Public Property FileSystemValidSubtitlesExts() As List(Of String)
        Get
            Return _XMLSettings.FileSystemValidSubtitlesExts
        End Get
        Set(ByVal value As List(Of String))
            _XMLSettings.FileSystemValidSubtitlesExts = value
        End Set
    End Property

    Public Property FileSystemValidThemeExts() As List(Of String)
        Get
            Return _XMLSettings.FileSystemValidThemeExts
        End Get
        Set(ByVal value As List(Of String))
            _XMLSettings.FileSystemValidThemeExts = value
        End Set
    End Property

    Public Property Version() As String
        Get
            Return _XMLSettings.Version
        End Get
        Set(ByVal value As String)
            _XMLSettings.Version = value
        End Set
    End Property

    Public Property GeneralWindowLoc() As Point
        Get
            Return _XMLSettings.GeneralWindowLoc
        End Get
        Set(ByVal value As Point)
            _XMLSettings.GeneralWindowLoc = value
        End Set
    End Property

    Public Property GeneralWindowSize() As Size
        Get
            Return _XMLSettings.GeneralWindowSize
        End Get
        Set(ByVal value As Size)
            _XMLSettings.GeneralWindowSize = value
        End Set
    End Property

    Public Property GeneralWindowState() As FormWindowState
        Get
            Return _XMLSettings.GeneralWindowState
        End Get
        Set(ByVal value As FormWindowState)
            _XMLSettings.GeneralWindowState = value
        End Set
    End Property

    Public Property Username() As String
        Get
            Return _XMLSettings.Username
        End Get
        Set(ByVal value As String)
            _XMLSettings.Username = value
        End Set
    End Property

    Public Property Password() As String
        Get
            Return _XMLSettings.Password
        End Get
        Set(ByVal value As String)
            _XMLSettings.Password = value
        End Set
    End Property

    Public Property GeneralDateTime() As Enums.DateTime
        Get
            Return _XMLSettings.GeneralDateTime
        End Get
        Set(ByVal value As Enums.DateTime)
            _XMLSettings.GeneralDateTime = value
        End Set
    End Property

    Public Property GeneralDateAddedIgnoreNFO() As Boolean
        Get
            Return _XMLSettings.GeneralDateAddedIgnoreNFO
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.GeneralDateAddedIgnoreNFO = value
        End Set
    End Property

    Public Property GeneralDigitGrpSymbolVotes() As Boolean
        Get
            Return _XMLSettings.GeneralDigitGrpSymbolVotes
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.GeneralDigitGrpSymbolVotes = value
        End Set
    End Property

    Public Property MovieImagesCacheEnabled() As Boolean
        Get
            Return _XMLSettings.MovieImagesCacheEnabled
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieImagesCacheEnabled = value
        End Set
    End Property

    Public Property MovieSetImagesCacheEnabled() As Boolean
        Get
            Return _XMLSettings.MovieSetImagesCacheEnabled
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieSetImagesCacheEnabled = value
        End Set
    End Property

    Public Property TVImagesCacheEnabled() As Boolean
        Get
            Return _XMLSettings.TVImagesCacheEnabled
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVImagesCacheEnabled = value
        End Set
    End Property

    Public Property MovieImagesGetBlankImages() As Boolean
        Get
            Return _XMLSettings.MovieImagesGetBlankImages
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieImagesGetBlankImages = value
        End Set
    End Property

    Public Property MovieImagesGetEnglishImages() As Boolean
        Get
            Return _XMLSettings.MovieImagesGetEnglishImages
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieImagesGetEnglishImages = value
        End Set
    End Property

    Public Property MovieImagesForcedLanguage() As String
        Get
            Return _XMLSettings.MovieImagesForcedLanguage
        End Get
        Set(ByVal value As String)
            _XMLSettings.MovieImagesForcedLanguage = value
        End Set
    End Property

    Public Property MovieImagesForceLanguage() As Boolean
        Get
            Return _XMLSettings.MovieImagesForceLanguage
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieImagesForceLanguage = value
        End Set
    End Property

    Public Property MovieImagesMediaLanguageOnly() As Boolean
        Get
            Return _XMLSettings.MovieImagesMediaLanguageOnly
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieImagesMediaLanguageOnly = value
        End Set
    End Property

    Public Property MovieSetImagesForcedLanguage() As String
        Get
            Return _XMLSettings.MovieSetImagesForcedLanguage
        End Get
        Set(ByVal value As String)
            _XMLSettings.MovieSetImagesForcedLanguage = value
        End Set
    End Property

    Public Property MovieSetImagesForceLanguage() As Boolean
        Get
            Return _XMLSettings.MovieSetImagesForceLanguage
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieSetImagesForceLanguage = value
        End Set
    End Property

    Public Property MovieSetImagesGetBlankImages() As Boolean
        Get
            Return _XMLSettings.MovieSetImagesGetBlankImages
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieSetImagesGetBlankImages = value
        End Set
    End Property

    Public Property MovieSetImagesGetEnglishImages() As Boolean
        Get
            Return _XMLSettings.MovieSetImagesGetEnglishImages
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieSetImagesGetEnglishImages = value
        End Set
    End Property

    Public Property MovieSetImagesMediaLanguageOnly() As Boolean
        Get
            Return _XMLSettings.MovieSetImagesMediaLanguageOnly
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieSetImagesMediaLanguageOnly = value
        End Set
    End Property

    Public Property TVImagesGetBlankImages() As Boolean
        Get
            Return _XMLSettings.TVImagesGetBlankImages
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVImagesGetBlankImages = value
        End Set
    End Property

    Public Property TVImagesGetEnglishImages() As Boolean
        Get
            Return _XMLSettings.TVImagesGetEnglishImages
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVImagesGetEnglishImages = value
        End Set
    End Property

    Public Property TVImagesForceLanguage() As Boolean
        Get
            Return _XMLSettings.TVImagesForceLanguage
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVImagesForceLanguage = value
        End Set
    End Property

    Public Property TVImagesForcedLanguage() As String
        Get
            Return _XMLSettings.TVImagesForcedLanguage
        End Get
        Set(ByVal value As String)
            _XMLSettings.TVImagesForcedLanguage = value
        End Set
    End Property

    Public Property TVImagesMediaLanguageOnly() As Boolean
        Get
            Return _XMLSettings.TVImagesMediaLanguageOnly
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVImagesMediaLanguageOnly = value
        End Set
    End Property

    Public Property MovieUseAD() As Boolean
        Get
            Return _XMLSettings.MovieUseAD
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieUseAD = value
        End Set
    End Property

    Public Property MovieUseExtended() As Boolean
        Get
            Return _XMLSettings.MovieUseExtended
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieUseExtended = value
        End Set
    End Property

    Public Property MovieUseFrodo() As Boolean
        Get
            Return _XMLSettings.MovieUseFrodo
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieUseFrodo = value
        End Set
    End Property

    Public Property MovieActorThumbsFrodo() As Boolean
        Get
            Return _XMLSettings.MovieActorThumbsFrodo
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieActorThumbsFrodo = value
        End Set
    End Property

    Public Property MovieBannerAD() As Boolean
        Get
            Return _XMLSettings.MovieBannerAD
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieBannerAD = value
        End Set
    End Property

    Public Property MovieBannerExtended() As Boolean
        Get
            Return _XMLSettings.MovieBannerExtended
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieBannerExtended = value
        End Set
    End Property

    Public Property MovieClearArtAD() As Boolean
        Get
            Return _XMLSettings.MovieClearArtAD
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieClearArtAD = value
        End Set
    End Property

    Public Property MovieClearArtExtended() As Boolean
        Get
            Return _XMLSettings.MovieClearArtExtended
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieClearArtExtended = value
        End Set
    End Property

    Public Property MovieClearLogoAD() As Boolean
        Get
            Return _XMLSettings.MovieClearLogoAD
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieClearLogoAD = value
        End Set
    End Property

    Public Property MovieClearLogoExtended() As Boolean
        Get
            Return _XMLSettings.MovieClearLogoExtended
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieClearLogoExtended = value
        End Set
    End Property

    Public Property MovieDiscArtAD() As Boolean
        Get
            Return _XMLSettings.MovieDiscArtAD
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieDiscArtAD = value
        End Set
    End Property

    Public Property MovieDiscArtExtended() As Boolean
        Get
            Return _XMLSettings.MovieDiscArtExtended
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieDiscArtExtended = value
        End Set
    End Property

    Public Property MovieExtrafanartsFrodo() As Boolean
        Get
            Return _XMLSettings.MovieExtrafanartsFrodo
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieExtrafanartsFrodo = value
        End Set
    End Property

    Public Property MovieExtrathumbsFrodo() As Boolean
        Get
            Return _XMLSettings.MovieExtrathumbsFrodo
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieExtrathumbsFrodo = value
        End Set
    End Property

    Public Property MovieFanartFrodo() As Boolean
        Get
            Return _XMLSettings.MovieFanartFrodo
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieFanartFrodo = value
        End Set
    End Property

    Public Property MovieLandscapeAD() As Boolean
        Get
            Return _XMLSettings.MovieLandscapeAD
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieLandscapeAD = value
        End Set
    End Property

    Public Property MovieLandscapeExtended() As Boolean
        Get
            Return _XMLSettings.MovieLandscapeExtended
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieLandscapeExtended = value
        End Set
    End Property

    Public Property MovieNFOFrodo() As Boolean
        Get
            Return _XMLSettings.MovieNFOFrodo
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieNFOFrodo = value
        End Set
    End Property

    Public Property MoviePosterFrodo() As Boolean
        Get
            Return _XMLSettings.MoviePosterFrodo
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MoviePosterFrodo = value
        End Set
    End Property

    Public Property MovieTrailerFrodo() As Boolean
        Get
            Return _XMLSettings.MovieTrailerFrodo
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieTrailerFrodo = value
        End Set
    End Property

    Public Property MovieUseEden() As Boolean
        Get
            Return _XMLSettings.MovieUseEden
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieUseEden = value
        End Set
    End Property

    Public Property MovieActorThumbsEden() As Boolean
        Get
            Return _XMLSettings.MovieActorThumbsEden
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieActorThumbsEden = value
        End Set
    End Property

    Public Property MovieExtrafanartsEden() As Boolean
        Get
            Return _XMLSettings.MovieExtrafanartsEden
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieExtrafanartsEden = value
        End Set
    End Property

    Public Property MovieExtrathumbsEden() As Boolean
        Get
            Return _XMLSettings.MovieExtrathumbsEden
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieExtrathumbsEden = value
        End Set
    End Property

    Public Property MovieFanartEden() As Boolean
        Get
            Return _XMLSettings.MovieFanartEden
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieFanartEden = value
        End Set
    End Property

    Public Property MovieNFOEden() As Boolean
        Get
            Return _XMLSettings.MovieNFOEden
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieNFOEden = value
        End Set
    End Property

    Public Property MoviePosterEden() As Boolean
        Get
            Return _XMLSettings.MoviePosterEden
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MoviePosterEden = value
        End Set
    End Property

    Public Property MovieTrailerEden() As Boolean
        Get
            Return _XMLSettings.MovieTrailerEden
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieTrailerEden = value
        End Set
    End Property

    Public Property MovieThemeTvTunesEnable() As Boolean
        Get
            Return _XMLSettings.MovieThemeTvTunesEnable
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieThemeTvTunesEnable = value
        End Set
    End Property

    Public Property MovieThemeTvTunesCustom() As Boolean
        Get
            Return _XMLSettings.MovieThemeTvTunesCustom
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieThemeTvTunesCustom = value
        End Set
    End Property

    Public Property MovieThemeTvTunesCustomPath() As String
        Get
            Return _XMLSettings.MovieThemeTvTunesCustomPath
        End Get
        Set(ByVal value As String)
            _XMLSettings.MovieThemeTvTunesCustomPath = value
        End Set
    End Property

    Public Property MovieThemeTvTunesMoviePath() As Boolean
        Get
            Return _XMLSettings.MovieThemeTvTunesMoviePath
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieThemeTvTunesMoviePath = value
        End Set
    End Property

    Public Property MovieThemeTvTunesSub() As Boolean
        Get
            Return _XMLSettings.MovieThemeTvTunesSub
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieThemeTvTunesSub = value
        End Set
    End Property

    Public Property MovieThemeTvTunesSubDir() As String
        Get
            Return _XMLSettings.MovieThemeTvTunesSubDir
        End Get
        Set(ByVal value As String)
            _XMLSettings.MovieThemeTvTunesSubDir = value
        End Set
    End Property

    Public Property TVShowThemeTvTunesEnable() As Boolean
        Get
            Return _XMLSettings.TVShowThemeTvTunesEnable
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVShowThemeTvTunesEnable = value
        End Set
    End Property

    Public Property TVShowThemeTvTunesCustom() As Boolean
        Get
            Return _XMLSettings.TVShowThemeTvTunesCustom
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVShowThemeTvTunesCustom = value
        End Set
    End Property

    Public Property TVShowThemeTvTunesCustomPath() As String
        Get
            Return _XMLSettings.TVShowThemeTvTunesCustomPath
        End Get
        Set(ByVal value As String)
            _XMLSettings.TVShowThemeTvTunesCustomPath = value
        End Set
    End Property

    Public Property TVShowThemeTvTunesShowPath() As Boolean
        Get
            Return _XMLSettings.TVShowThemeTvTunesShowPath
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVShowThemeTvTunesShowPath = value
        End Set
    End Property

    Public Property TVShowThemeTvTunesSub() As Boolean
        Get
            Return _XMLSettings.TVShowThemeTvTunesSub
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVShowThemeTvTunesSub = value
        End Set
    End Property

    Public Property TVShowThemeTvTunesSubDir() As String
        Get
            Return _XMLSettings.TVShowThemeTvTunesSubDir
        End Get
        Set(ByVal value As String)
            _XMLSettings.TVShowThemeTvTunesSubDir = value
        End Set
    End Property

    Public Property MovieScraperXBMCTrailerFormat() As Boolean
        Get
            Return _XMLSettings.MovieScraperXBMCTrailerFormat
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieScraperXBMCTrailerFormat = value
        End Set
    End Property

    Public Property MovieXBMCProtectVTSBDMV() As Boolean
        Get
            Return _XMLSettings.MovieXBMCProtectVTSBDMV
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieXBMCProtectVTSBDMV = value
        End Set
    End Property

    Public Property MovieUseYAMJ() As Boolean
        Get
            Return _XMLSettings.MovieUseYAMJ
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieUseYAMJ = value
        End Set
    End Property

    Public Property MovieBannerYAMJ() As Boolean
        Get
            Return _XMLSettings.MovieBannerYAMJ
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieBannerYAMJ = value
        End Set
    End Property

    Public Property MovieFanartYAMJ() As Boolean
        Get
            Return _XMLSettings.MovieFanartYAMJ
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieFanartYAMJ = value
        End Set
    End Property

    Public Property MovieNFOYAMJ() As Boolean
        Get
            Return _XMLSettings.MovieNFOYAMJ
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieNFOYAMJ = value
        End Set
    End Property

    Public Property MoviePosterYAMJ() As Boolean
        Get
            Return _XMLSettings.MoviePosterYAMJ
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MoviePosterYAMJ = value
        End Set
    End Property

    Public Property MovieTrailerYAMJ() As Boolean
        Get
            Return _XMLSettings.MovieTrailerYAMJ
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieTrailerYAMJ = value
        End Set
    End Property

    Public Property MovieScraperCollectionsYAMJCompatibleSets() As Boolean
        Get
            Return _XMLSettings.MovieScraperCollectionsYAMJCompatibleSets
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieScraperCollectionsYAMJCompatibleSets = value
        End Set
    End Property

    Public Property MovieYAMJWatchedFile() As Boolean
        Get
            Return _XMLSettings.MovieYAMJWatchedFile
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieYAMJWatchedFile = value
        End Set
    End Property

    Public Property MovieYAMJWatchedFolder() As String
        Get
            Return _XMLSettings.MovieYAMJWatchedFolder
        End Get
        Set(ByVal value As String)
            _XMLSettings.MovieYAMJWatchedFolder = value
        End Set
    End Property

    Public Property MovieUseNMJ() As Boolean
        Get
            Return _XMLSettings.MovieUseNMJ
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieUseNMJ = value
        End Set
    End Property

    Public Property MovieBannerNMJ() As Boolean
        Get
            Return _XMLSettings.MovieBannerNMJ
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieBannerNMJ = value
        End Set
    End Property

    Public Property MovieFanartNMJ() As Boolean
        Get
            Return _XMLSettings.MovieFanartNMJ
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieFanartNMJ = value
        End Set
    End Property

    Public Property MovieNFONMJ() As Boolean
        Get
            Return _XMLSettings.MovieNFONMJ
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieNFONMJ = value
        End Set
    End Property

    Public Property MoviePosterNMJ() As Boolean
        Get
            Return _XMLSettings.MoviePosterNMJ
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MoviePosterNMJ = value
        End Set
    End Property

    Public Property MovieTrailerNMJ() As Boolean
        Get
            Return _XMLSettings.MovieTrailerNMJ
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieTrailerNMJ = value
        End Set
    End Property

    Public Property MovieUseBoxee() As Boolean
        Get
            Return _XMLSettings.MovieUseBoxee
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieUseBoxee = value
        End Set
    End Property

    Public Property MovieFanartBoxee() As Boolean
        Get
            Return _XMLSettings.MovieFanartBoxee
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieFanartBoxee = value
        End Set
    End Property

    Public Property MovieNFOBoxee() As Boolean
        Get
            Return _XMLSettings.MovieNFOBoxee
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieNFOBoxee = value
        End Set
    End Property

    Public Property MoviePosterBoxee() As Boolean
        Get
            Return _XMLSettings.MoviePosterBoxee
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MoviePosterBoxee = value
        End Set
    End Property

    Public Property MovieUseExpert() As Boolean
        Get
            Return _XMLSettings.MovieUseExpert
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieUseExpert = value
        End Set
    End Property

    Public Property MovieActorThumbsExpertSingle() As Boolean
        Get
            Return _XMLSettings.MovieActorThumbsExpertSingle
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieActorThumbsExpertSingle = value
        End Set
    End Property

    Public Property MovieActorThumbsExtExpertSingle() As String
        Get
            Return _XMLSettings.MovieActorThumbsExtExpertSingle
        End Get
        Set(ByVal value As String)
            _XMLSettings.MovieActorThumbsExtExpertSingle = value
        End Set
    End Property

    Public Property MovieBannerExpertSingle() As String
        Get
            Return _XMLSettings.MovieBannerExpertSingle
        End Get
        Set(ByVal value As String)
            _XMLSettings.MovieBannerExpertSingle = value
        End Set
    End Property

    Public Property MovieClearArtExpertSingle() As String
        Get
            Return _XMLSettings.MovieClearArtExpertSingle
        End Get
        Set(ByVal value As String)
            _XMLSettings.MovieClearArtExpertSingle = value
        End Set
    End Property

    Public Property MovieClearLogoExpertSingle() As String
        Get
            Return _XMLSettings.MovieClearLogoExpertSingle
        End Get
        Set(ByVal value As String)
            _XMLSettings.MovieClearLogoExpertSingle = value
        End Set
    End Property

    Public Property MovieDiscArtExpertSingle() As String
        Get
            Return _XMLSettings.MovieDiscArtExpertSingle
        End Get
        Set(ByVal value As String)
            _XMLSettings.MovieDiscArtExpertSingle = value
        End Set
    End Property

    Public Property MovieExtrafanartsExpertSingle() As Boolean
        Get
            Return _XMLSettings.MovieExtrafanartsExpertSingle
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieExtrafanartsExpertSingle = value
        End Set
    End Property

    Public Property MovieExtrathumbsExpertSingle() As Boolean
        Get
            Return _XMLSettings.MovieExtrathumbsExpertSingle
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieExtrathumbsExpertSingle = value
        End Set
    End Property

    Public Property MovieFanartExpertSingle() As String
        Get
            Return _XMLSettings.MovieFanartExpertSingle
        End Get
        Set(ByVal value As String)
            _XMLSettings.MovieFanartExpertSingle = value
        End Set
    End Property

    Public Property MovieLandscapeExpertSingle() As String
        Get
            Return _XMLSettings.MovieLandscapeExpertSingle
        End Get
        Set(ByVal value As String)
            _XMLSettings.MovieLandscapeExpertSingle = value
        End Set
    End Property

    Public Property MovieNFOExpertSingle() As String
        Get
            Return _XMLSettings.MovieNFOExpertSingle
        End Get
        Set(ByVal value As String)
            _XMLSettings.MovieNFOExpertSingle = value
        End Set
    End Property

    Public Property MoviePosterExpertSingle() As String
        Get
            Return _XMLSettings.MoviePosterExpertSingle
        End Get
        Set(ByVal value As String)
            _XMLSettings.MoviePosterExpertSingle = value
        End Set
    End Property

    Public Property MovieStackExpertSingle() As Boolean
        Get
            Return _XMLSettings.MovieStackExpertSingle
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieStackExpertSingle = value
        End Set
    End Property

    Public Property MovieTrailerExpertSingle() As String
        Get
            Return _XMLSettings.MovieTrailerExpertSingle
        End Get
        Set(ByVal value As String)
            _XMLSettings.MovieTrailerExpertSingle = value
        End Set
    End Property

    Public Property MovieUnstackExpertSingle() As Boolean
        Get
            Return _XMLSettings.MovieUnstackExpertSingle
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieUnstackExpertSingle = value
        End Set
    End Property

    Public Property MovieActorThumbsExpertMulti() As Boolean
        Get
            Return _XMLSettings.MovieActorThumbsExpertMulti
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieActorThumbsExpertMulti = value
        End Set
    End Property

    Public Property MovieActorThumbsExtExpertMulti() As String
        Get
            Return _XMLSettings.MovieActorThumbsExtExpertMulti
        End Get
        Set(ByVal value As String)
            _XMLSettings.MovieActorThumbsExtExpertMulti = value
        End Set
    End Property

    Public Property MovieBannerExpertMulti() As String
        Get
            Return _XMLSettings.MovieBannerExpertMulti
        End Get
        Set(ByVal value As String)
            _XMLSettings.MovieBannerExpertMulti = value
        End Set
    End Property

    Public Property MovieClearArtExpertMulti() As String
        Get
            Return _XMLSettings.MovieClearArtExpertMulti
        End Get
        Set(ByVal value As String)
            _XMLSettings.MovieClearArtExpertMulti = value
        End Set
    End Property

    Public Property MovieClearLogoExpertMulti() As String
        Get
            Return _XMLSettings.MovieClearLogoExpertMulti
        End Get
        Set(ByVal value As String)
            _XMLSettings.MovieClearLogoExpertMulti = value
        End Set
    End Property

    Public Property MovieDiscArtExpertMulti() As String
        Get
            Return _XMLSettings.MovieDiscArtExpertMulti
        End Get
        Set(ByVal value As String)
            _XMLSettings.MovieDiscArtExpertMulti = value
        End Set
    End Property

    Public Property MovieFanartExpertMulti() As String
        Get
            Return _XMLSettings.MovieFanartExpertMulti
        End Get
        Set(ByVal value As String)
            _XMLSettings.MovieFanartExpertMulti = value
        End Set
    End Property

    Public Property MovieLandscapeExpertMulti() As String
        Get
            Return _XMLSettings.MovieLandscapeExpertMulti
        End Get
        Set(ByVal value As String)
            _XMLSettings.MovieLandscapeExpertMulti = value
        End Set
    End Property

    Public Property MovieNFOExpertMulti() As String
        Get
            Return _XMLSettings.MovieNFOExpertMulti
        End Get
        Set(ByVal value As String)
            _XMLSettings.MovieNFOExpertMulti = value
        End Set
    End Property

    Public Property MoviePosterExpertMulti() As String
        Get
            Return _XMLSettings.MoviePosterExpertMulti
        End Get
        Set(ByVal value As String)
            _XMLSettings.MoviePosterExpertMulti = value
        End Set
    End Property

    Public Property MovieStackExpertMulti() As Boolean
        Get
            Return _XMLSettings.MovieStackExpertMulti
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieStackExpertMulti = value
        End Set
    End Property

    Public Property MovieTrailerExpertMulti() As String
        Get
            Return _XMLSettings.MovieTrailerExpertMulti
        End Get
        Set(ByVal value As String)
            _XMLSettings.MovieTrailerExpertMulti = value
        End Set
    End Property

    Public Property MovieUnstackExpertMulti() As Boolean
        Get
            Return _XMLSettings.MovieUnstackExpertMulti
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieUnstackExpertMulti = value
        End Set
    End Property

    Public Property MovieActorThumbsExpertVTS() As Boolean
        Get
            Return _XMLSettings.MovieActorThumbsExpertVTS
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieActorThumbsExpertVTS = value
        End Set
    End Property

    Public Property MovieActorThumbsExtExpertVTS() As String
        Get
            Return _XMLSettings.MovieActorThumbsExtExpertVTS
        End Get
        Set(ByVal value As String)
            _XMLSettings.MovieActorThumbsExtExpertVTS = value
        End Set
    End Property

    Public Property MovieBannerExpertVTS() As String
        Get
            Return _XMLSettings.MovieBannerExpertVTS
        End Get
        Set(ByVal value As String)
            _XMLSettings.MovieBannerExpertVTS = value
        End Set
    End Property

    Public Property MovieClearArtExpertVTS() As String
        Get
            Return _XMLSettings.MovieClearArtExpertVTS
        End Get
        Set(ByVal value As String)
            _XMLSettings.MovieClearArtExpertVTS = value
        End Set
    End Property

    Public Property MovieClearLogoExpertVTS() As String
        Get
            Return _XMLSettings.MovieClearLogoExpertVTS
        End Get
        Set(ByVal value As String)
            _XMLSettings.MovieClearLogoExpertVTS = value
        End Set
    End Property

    Public Property MovieDiscArtExpertVTS() As String
        Get
            Return _XMLSettings.MovieDiscArtExpertVTS
        End Get
        Set(ByVal value As String)
            _XMLSettings.MovieDiscArtExpertVTS = value
        End Set
    End Property

    Public Property MovieExtrafanartsExpertVTS() As Boolean
        Get
            Return _XMLSettings.MovieExtrafanartsExpertVTS
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieExtrafanartsExpertVTS = value
        End Set
    End Property

    Public Property MovieExtrathumbsExpertVTS() As Boolean
        Get
            Return _XMLSettings.MovieExtrathumbsExpertVTS
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieExtrathumbsExpertVTS = value
        End Set
    End Property

    Public Property MovieFanartExpertVTS() As String
        Get
            Return _XMLSettings.MovieFanartExpertVTS
        End Get
        Set(ByVal value As String)
            _XMLSettings.MovieFanartExpertVTS = value
        End Set
    End Property

    Public Property MovieLandscapeExpertVTS() As String
        Get
            Return _XMLSettings.MovieLandscapeExpertVTS
        End Get
        Set(ByVal value As String)
            _XMLSettings.MovieLandscapeExpertVTS = value
        End Set
    End Property

    Public Property MovieNFOExpertVTS() As String
        Get
            Return _XMLSettings.MovieNFOExpertVTS
        End Get
        Set(ByVal value As String)
            _XMLSettings.MovieNFOExpertVTS = value
        End Set
    End Property

    Public Property MoviePosterExpertVTS() As String
        Get
            Return _XMLSettings.MoviePosterExpertVTS
        End Get
        Set(ByVal value As String)
            _XMLSettings.MoviePosterExpertVTS = value
        End Set
    End Property

    Public Property MovieRecognizeVTSExpertVTS() As Boolean
        Get
            Return _XMLSettings.MovieRecognizeVTSExpertVTS
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieRecognizeVTSExpertVTS = value
        End Set
    End Property

    Public Property MovieTrailerExpertVTS() As String
        Get
            Return _XMLSettings.MovieTrailerExpertVTS
        End Get
        Set(ByVal value As String)
            _XMLSettings.MovieTrailerExpertVTS = value
        End Set
    End Property

    Public Property MovieUseBaseDirectoryExpertVTS() As Boolean
        Get
            Return _XMLSettings.MovieUseBaseDirectoryExpertVTS
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieUseBaseDirectoryExpertVTS = value
        End Set
    End Property

    Public Property MovieActorThumbsExpertBDMV() As Boolean
        Get
            Return _XMLSettings.MovieActorThumbsExpertBDMV
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieActorThumbsExpertBDMV = value
        End Set
    End Property

    Public Property MovieActorThumbsExtExpertBDMV() As String
        Get
            Return _XMLSettings.MovieActorThumbsExtExpertBDMV
        End Get
        Set(ByVal value As String)
            _XMLSettings.MovieActorThumbsExtExpertBDMV = value
        End Set
    End Property

    Public Property MovieBannerExpertBDMV() As String
        Get
            Return _XMLSettings.MovieBannerExpertBDMV
        End Get
        Set(ByVal value As String)
            _XMLSettings.MovieBannerExpertBDMV = value
        End Set
    End Property

    Public Property MovieClearArtExpertBDMV() As String
        Get
            Return _XMLSettings.MovieClearArtExpertBDMV
        End Get
        Set(ByVal value As String)
            _XMLSettings.MovieClearArtExpertBDMV = value
        End Set
    End Property

    Public Property MovieClearLogoExpertBDMV() As String
        Get
            Return _XMLSettings.MovieClearLogoExpertBDMV
        End Get
        Set(ByVal value As String)
            _XMLSettings.MovieClearLogoExpertBDMV = value
        End Set
    End Property

    Public Property MovieDiscArtExpertBDMV() As String
        Get
            Return _XMLSettings.MovieDiscArtExpertBDMV
        End Get
        Set(ByVal value As String)
            _XMLSettings.MovieDiscArtExpertBDMV = value
        End Set
    End Property

    Public Property MovieExtrafanartsExpertBDMV() As Boolean
        Get
            Return _XMLSettings.MovieExtrafanartsExpertBDMV
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieExtrafanartsExpertBDMV = value
        End Set
    End Property

    Public Property MovieExtrathumbsExpertBDMV() As Boolean
        Get
            Return _XMLSettings.MovieExtrathumbsExpertBDMV
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieExtrathumbsExpertBDMV = value
        End Set
    End Property

    Public Property MovieFanartExpertBDMV() As String
        Get
            Return _XMLSettings.MovieFanartExpertBDMV
        End Get
        Set(ByVal value As String)
            _XMLSettings.MovieFanartExpertBDMV = value
        End Set
    End Property

    Public Property MovieLandscapeExpertBDMV() As String
        Get
            Return _XMLSettings.MovieLandscapeExpertBDMV
        End Get
        Set(ByVal value As String)
            _XMLSettings.MovieLandscapeExpertBDMV = value
        End Set
    End Property

    Public Property MovieNFOExpertBDMV() As String
        Get
            Return _XMLSettings.MovieNFOExpertBDMV
        End Get
        Set(ByVal value As String)
            _XMLSettings.MovieNFOExpertBDMV = value
        End Set
    End Property

    Public Property MoviePosterExpertBDMV() As String
        Get
            Return _XMLSettings.MoviePosterExpertBDMV
        End Get
        Set(ByVal value As String)
            _XMLSettings.MoviePosterExpertBDMV = value
        End Set
    End Property

    Public Property MovieTrailerExpertBDMV() As String
        Get
            Return _XMLSettings.MovieTrailerExpertBDMV
        End Get
        Set(ByVal value As String)
            _XMLSettings.MovieTrailerExpertBDMV = value
        End Set
    End Property

    Public Property MovieUseBaseDirectoryExpertBDMV() As Boolean
        Get
            Return _XMLSettings.MovieUseBaseDirectoryExpertBDMV
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieUseBaseDirectoryExpertBDMV = value
        End Set
    End Property

    Public Property MovieSetBannerExtended() As Boolean
        Get
            Return _XMLSettings.MovieSetBannerExtended
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieSetBannerExtended = value
        End Set
    End Property

    Public Property MovieSetClearArtExtended() As Boolean
        Get
            Return _XMLSettings.MovieSetClearArtExtended
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieSetClearArtExtended = value
        End Set
    End Property

    Public Property MovieSetClearLogoExtended() As Boolean
        Get
            Return _XMLSettings.MovieSetClearLogoExtended
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieSetClearLogoExtended = value
        End Set
    End Property

    Public Property MovieSetDiscArtExtended() As Boolean
        Get
            Return _XMLSettings.MovieSetDiscArtExtended
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieSetDiscArtExtended = value
        End Set
    End Property

    Public Property MovieSetFanartExtended() As Boolean
        Get
            Return _XMLSettings.MovieSetFanartExtended
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieSetFanartExtended = value
        End Set
    End Property

    Public Property MovieSetLandscapeExtended() As Boolean
        Get
            Return _XMLSettings.MovieSetLandscapeExtended
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieSetLandscapeExtended = value
        End Set
    End Property

    Public Property MovieSetPathExtended() As String
        Get
            Return _XMLSettings.MovieSetPathExtended
        End Get
        Set(ByVal value As String)
            _XMLSettings.MovieSetPathExtended = value
        End Set
    End Property

    Public Property MovieSetPosterExtended() As Boolean
        Get
            Return _XMLSettings.MovieSetPosterExtended
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieSetPosterExtended = value
        End Set
    End Property

    Public Property MovieSetUseExtended() As Boolean
        Get
            Return _XMLSettings.MovieSetUseExtended
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieSetUseExtended = value
        End Set
    End Property

    Public Property MovieSetUseMSAA() As Boolean
        Get
            Return _XMLSettings.MovieSetUseMSAA
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieSetUseMSAA = value
        End Set
    End Property

    Public Property MovieSetBannerMSAA() As Boolean
        Get
            Return _XMLSettings.MovieSetBannerMSAA
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieSetBannerMSAA = value
        End Set
    End Property

    Public Property MovieSetClearArtMSAA() As Boolean
        Get
            Return _XMLSettings.MovieSetClearArtMSAA
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieSetClearArtMSAA = value
        End Set
    End Property

    Public Property MovieSetClearLogoMSAA() As Boolean
        Get
            Return _XMLSettings.MovieSetClearLogoMSAA
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieSetClearLogoMSAA = value
        End Set
    End Property

    Public Property MovieSetFanartMSAA() As Boolean
        Get
            Return _XMLSettings.MovieSetFanartMSAA
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieSetFanartMSAA = value
        End Set
    End Property

    Public Property MovieSetLandscapeMSAA() As Boolean
        Get
            Return _XMLSettings.MovieSetLandscapeMSAA
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieSetLandscapeMSAA = value
        End Set
    End Property

    Public Property MovieSetPathMSAA() As String
        Get
            Return _XMLSettings.MovieSetPathMSAA
        End Get
        Set(ByVal value As String)
            _XMLSettings.MovieSetPathMSAA = value
        End Set
    End Property

    Public Property MovieSetPosterMSAA() As Boolean
        Get
            Return _XMLSettings.MovieSetPosterMSAA
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieSetPosterMSAA = value
        End Set
    End Property

    Public Property MovieSetUseExpert() As Boolean
        Get
            Return _XMLSettings.MovieSetUseExpert
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.MovieSetUseExpert = value
        End Set
    End Property

    Public Property MovieSetBannerExpertSingle() As String
        Get
            Return _XMLSettings.MovieSetBannerExpertSingle
        End Get
        Set(ByVal value As String)
            _XMLSettings.MovieSetBannerExpertSingle = value
        End Set
    End Property

    Public Property MovieSetClearArtExpertSingle() As String
        Get
            Return _XMLSettings.MovieSetClearArtExpertSingle
        End Get
        Set(ByVal value As String)
            _XMLSettings.MovieSetClearArtExpertSingle = value
        End Set
    End Property

    Public Property MovieSetClearLogoExpertSingle() As String
        Get
            Return _XMLSettings.MovieSetClearLogoExpertSingle
        End Get
        Set(ByVal value As String)
            _XMLSettings.MovieSetClearLogoExpertSingle = value
        End Set
    End Property

    Public Property MovieSetDiscArtExpertSingle() As String
        Get
            Return _XMLSettings.MovieSetDiscArtExpertSingle
        End Get
        Set(ByVal value As String)
            _XMLSettings.MovieSetDiscArtExpertSingle = value
        End Set
    End Property

    Public Property MovieSetFanartExpertSingle() As String
        Get
            Return _XMLSettings.MovieSetFanartExpertSingle
        End Get
        Set(ByVal value As String)
            _XMLSettings.MovieSetFanartExpertSingle = value
        End Set
    End Property

    Public Property MovieSetLandscapeExpertSingle() As String
        Get
            Return _XMLSettings.MovieSetLandscapeExpertSingle
        End Get
        Set(ByVal value As String)
            _XMLSettings.MovieSetLandscapeExpertSingle = value
        End Set
    End Property

    Public Property MovieSetNFOExpertSingle() As String
        Get
            Return _XMLSettings.MovieSetNFOExpertSingle
        End Get
        Set(ByVal value As String)
            _XMLSettings.MovieSetNFOExpertSingle = value
        End Set
    End Property

    Public Property MovieSetPathExpertSingle() As String
        Get
            Return _XMLSettings.MovieSetPathExpertSingle
        End Get
        Set(ByVal value As String)
            _XMLSettings.MovieSetPathExpertSingle = value
        End Set
    End Property

    Public Property MovieSetPosterExpertSingle() As String
        Get
            Return _XMLSettings.MovieSetPosterExpertSingle
        End Get
        Set(ByVal value As String)
            _XMLSettings.MovieSetPosterExpertSingle = value
        End Set
    End Property

    Public Property MovieSetBannerExpertParent() As String
        Get
            Return _XMLSettings.MovieSetBannerExpertParent
        End Get
        Set(ByVal value As String)
            _XMLSettings.MovieSetBannerExpertParent = value
        End Set
    End Property

    Public Property MovieSetClearArtExpertParent() As String
        Get
            Return _XMLSettings.MovieSetClearArtExpertParent
        End Get
        Set(ByVal value As String)
            _XMLSettings.MovieSetClearArtExpertParent = value
        End Set
    End Property

    Public Property MovieSetClearLogoExpertParent() As String
        Get
            Return _XMLSettings.MovieSetClearLogoExpertParent
        End Get
        Set(ByVal value As String)
            _XMLSettings.MovieSetClearLogoExpertParent = value
        End Set
    End Property

    Public Property MovieSetDiscArtExpertParent() As String
        Get
            Return _XMLSettings.MovieSetDiscArtExpertParent
        End Get
        Set(ByVal value As String)
            _XMLSettings.MovieSetDiscArtExpertParent = value
        End Set
    End Property

    Public Property MovieSetFanartExpertParent() As String
        Get
            Return _XMLSettings.MovieSetFanartExpertParent
        End Get
        Set(ByVal value As String)
            _XMLSettings.MovieSetFanartExpertParent = value
        End Set
    End Property

    Public Property MovieSetLandscapeExpertParent() As String
        Get
            Return _XMLSettings.MovieSetLandscapeExpertParent
        End Get
        Set(ByVal value As String)
            _XMLSettings.MovieSetLandscapeExpertParent = value
        End Set
    End Property

    Public Property MovieSetNFOExpertParent() As String
        Get
            Return _XMLSettings.MovieSetNFOExpertParent
        End Get
        Set(ByVal value As String)
            _XMLSettings.MovieSetNFOExpertParent = value
        End Set
    End Property

    Public Property MovieSetPosterExpertParent() As String
        Get
            Return _XMLSettings.MovieSetPosterExpertParent
        End Get
        Set(ByVal value As String)
            _XMLSettings.MovieSetPosterExpertParent = value
        End Set
    End Property

    Public Property TVUseBoxee() As Boolean
        Get
            Return _XMLSettings.TVUseBoxee
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVUseBoxee = value
        End Set
    End Property

    Public Property TVUseEden() As Boolean
        Get
            Return _XMLSettings.TVUseEden
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVUseEden = value
        End Set
    End Property

    Public Property TVUseExpert() As Boolean
        Get
            Return _XMLSettings.TVUseExpert
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVUseExpert = value
        End Set
    End Property

    Public Property TVUseAD() As Boolean
        Get
            Return _XMLSettings.TVUseAD
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVUseAD = value
        End Set
    End Property

    Public Property TVUseExtended() As Boolean
        Get
            Return _XMLSettings.TVUseExtended
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVUseExtended = value
        End Set
    End Property

    Public Property TVUseFrodo() As Boolean
        Get
            Return _XMLSettings.TVUseFrodo
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVUseFrodo = value
        End Set
    End Property

    Public Property TVUseYAMJ() As Boolean
        Get
            Return _XMLSettings.TVUseYAMJ
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVUseYAMJ = value
        End Set
    End Property

    Public Property TVShowActorThumbsExpert() As Boolean
        Get
            Return _XMLSettings.TVShowActorThumbsExpert
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVShowActorThumbsExpert = value
        End Set
    End Property

    Public Property TVShowActorThumbsExtExpert() As String
        Get
            Return _XMLSettings.TVShowActorThumbsExtExpert
        End Get
        Set(ByVal value As String)
            _XMLSettings.TVShowActorThumbsExtExpert = value
        End Set
    End Property

    Public Property TVShowActorThumbsFrodo() As Boolean
        Get
            Return _XMLSettings.TVShowActorThumbsFrodo
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVShowActorThumbsFrodo = value
        End Set
    End Property

    Public Property TVShowBannerBoxee() As Boolean
        Get
            Return _XMLSettings.TVShowBannerBoxee
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVShowBannerBoxee = value
        End Set
    End Property

    Public Property TVShowBannerExpert() As String
        Get
            Return _XMLSettings.TVShowBannerExpert
        End Get
        Set(ByVal value As String)
            _XMLSettings.TVShowBannerExpert = value
        End Set
    End Property

    Public Property TVShowBannerFrodo() As Boolean
        Get
            Return _XMLSettings.TVShowBannerFrodo
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVShowBannerFrodo = value
        End Set
    End Property

    Public Property TVShowBannerYAMJ() As Boolean
        Get
            Return _XMLSettings.TVShowBannerYAMJ
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVShowBannerYAMJ = value
        End Set
    End Property

    Public Property TVShowCharacterArtExpert() As String
        Get
            Return _XMLSettings.TVShowCharacterArtExpert
        End Get
        Set(ByVal value As String)
            _XMLSettings.TVShowCharacterArtExpert = value
        End Set
    End Property

    Public Property TVShowClearArtExpert() As String
        Get
            Return _XMLSettings.TVShowClearArtExpert
        End Get
        Set(ByVal value As String)
            _XMLSettings.TVShowClearArtExpert = value
        End Set
    End Property

    Public Property TVShowClearLogoExpert() As String
        Get
            Return _XMLSettings.TVShowClearLogoExpert
        End Get
        Set(ByVal value As String)
            _XMLSettings.TVShowClearLogoExpert = value
        End Set
    End Property

    Public Property TVShowExtrafanartsExpert() As Boolean
        Get
            Return _XMLSettings.TVShowExtrafanartsExpert
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVShowExtrafanartsExpert = value
        End Set
    End Property

    Public Property TVShowExtrafanartsFrodo() As Boolean
        Get
            Return _XMLSettings.TVShowExtrafanartsFrodo
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVShowExtrafanartsFrodo = value
        End Set
    End Property

    Public Property TVShowFanartBoxee() As Boolean
        Get
            Return _XMLSettings.TVShowFanartBoxee
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVShowFanartBoxee = value
        End Set
    End Property

    Public Property TVShowFanartExpert() As String
        Get
            Return _XMLSettings.TVShowFanartExpert
        End Get
        Set(ByVal value As String)
            _XMLSettings.TVShowFanartExpert = value
        End Set
    End Property

    Public Property TVShowFanartFrodo() As Boolean
        Get
            Return _XMLSettings.TVShowFanartFrodo
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVShowFanartFrodo = value
        End Set
    End Property

    Public Property TVShowFanartYAMJ() As Boolean
        Get
            Return _XMLSettings.TVShowFanartYAMJ
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVShowFanartYAMJ = value
        End Set
    End Property

    Public Property TVShowLandscapeExpert() As String
        Get
            Return _XMLSettings.TVShowLandscapeExpert
        End Get
        Set(ByVal value As String)
            _XMLSettings.TVShowLandscapeExpert = value
        End Set
    End Property

    Public Property TVShowNFOExpert() As String
        Get
            Return _XMLSettings.TVShowNFOExpert
        End Get
        Set(ByVal value As String)
            _XMLSettings.TVShowNFOExpert = value
        End Set
    End Property

    Public Property TVShowNFOBoxee() As Boolean
        Get
            Return _XMLSettings.TVShowNFOBoxee
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVShowNFOBoxee = value
        End Set
    End Property

    Public Property TVShowPosterBoxee() As Boolean
        Get
            Return _XMLSettings.TVShowPosterBoxee
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVShowPosterBoxee = value
        End Set
    End Property

    Public Property TVShowPosterExpert() As String
        Get
            Return _XMLSettings.TVShowPosterExpert
        End Get
        Set(ByVal value As String)
            _XMLSettings.TVShowPosterExpert = value
        End Set
    End Property

    Public Property TVShowNFOFrodo() As Boolean
        Get
            Return _XMLSettings.TVShowNFOFrodo
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVShowNFOFrodo = value
        End Set
    End Property

    Public Property TVShowPosterFrodo() As Boolean
        Get
            Return _XMLSettings.TVShowPosterFrodo
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVShowPosterFrodo = value
        End Set
    End Property

    Public Property TVShowNFOYAMJ() As Boolean
        Get
            Return _XMLSettings.TVShowNFOYAMJ
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVShowNFOYAMJ = value
        End Set
    End Property

    Public Property TVShowPosterYAMJ() As Boolean
        Get
            Return _XMLSettings.TVShowPosterYAMJ
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVShowPosterYAMJ = value
        End Set
    End Property

    Public Property TVShowActorThumbsKeepExisting() As Boolean
        Get
            Return _XMLSettings.TVShowActorThumbsKeepExisting
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVShowActorThumbsKeepExisting = value
        End Set
    End Property

    Public Property TVAllSeasonsBannerExpert() As String
        Get
            Return _XMLSettings.TVAllSeasonsBannerExpert
        End Get
        Set(ByVal value As String)
            _XMLSettings.TVAllSeasonsBannerExpert = value
        End Set
    End Property

    Public Property TVAllSeasonsFanartExpert() As String
        Get
            Return _XMLSettings.TVAllSeasonsFanartExpert
        End Get
        Set(ByVal value As String)
            _XMLSettings.TVAllSeasonsFanartExpert = value
        End Set
    End Property

    Public Property TVAllSeasonsLandscapeExpert() As String
        Get
            Return _XMLSettings.TVAllSeasonsLandscapeExpert
        End Get
        Set(ByVal value As String)
            _XMLSettings.TVAllSeasonsLandscapeExpert = value
        End Set
    End Property

    Public Property TVAllSeasonsPosterExpert() As String
        Get
            Return _XMLSettings.TVAllSeasonsPosterExpert
        End Get
        Set(ByVal value As String)
            _XMLSettings.TVAllSeasonsPosterExpert = value
        End Set
    End Property

    Public Property TVSeasonBannerExpert() As String
        Get
            Return _XMLSettings.TVSeasonBannerExpert
        End Get
        Set(ByVal value As String)
            _XMLSettings.TVSeasonBannerExpert = value
        End Set
    End Property

    Public Property TVSeasonBannerFrodo() As Boolean
        Get
            Return _XMLSettings.TVSeasonBannerFrodo
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVSeasonBannerFrodo = value
        End Set
    End Property

    Public Property TVSeasonBannerYAMJ() As Boolean
        Get
            Return _XMLSettings.TVSeasonBannerYAMJ
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVSeasonBannerYAMJ = value
        End Set
    End Property

    Public Property TVSeasonFanartExpert() As String
        Get
            Return _XMLSettings.TVSeasonFanartExpert
        End Get
        Set(ByVal value As String)
            _XMLSettings.TVSeasonFanartExpert = value
        End Set
    End Property

    Public Property TVSeasonFanartFrodo() As Boolean
        Get
            Return _XMLSettings.TVSeasonFanartFrodo
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVSeasonFanartFrodo = value
        End Set
    End Property

    Public Property TVSeasonFanartYAMJ() As Boolean
        Get
            Return _XMLSettings.TVSeasonFanartYAMJ
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVSeasonFanartYAMJ = value
        End Set
    End Property

    Public Property TVSeasonLandscapeExpert() As String
        Get
            Return _XMLSettings.TVSeasonLandscapeExpert
        End Get
        Set(ByVal value As String)
            _XMLSettings.TVSeasonLandscapeExpert = value
        End Set
    End Property

    Public Property TVSeasonPosterBoxee() As Boolean
        Get
            Return _XMLSettings.TVSeasonPosterBoxee
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVSeasonPosterBoxee = value
        End Set
    End Property

    Public Property TVSeasonPosterExpert() As String
        Get
            Return _XMLSettings.TVSeasonPosterExpert
        End Get
        Set(ByVal value As String)
            _XMLSettings.TVSeasonPosterExpert = value
        End Set
    End Property

    Public Property TVSeasonPosterFrodo() As Boolean
        Get
            Return _XMLSettings.TVSeasonPosterFrodo
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVSeasonPosterFrodo = value
        End Set
    End Property

    Public Property TVSeasonPosterYAMJ() As Boolean
        Get
            Return _XMLSettings.TVSeasonPosterYAMJ
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVSeasonPosterYAMJ = value
        End Set
    End Property

    Public Property TVEpisodeActorThumbsExpert() As Boolean
        Get
            Return _XMLSettings.TVEpisodeActorThumbsExpert
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVEpisodeActorThumbsExpert = value
        End Set
    End Property

    Public Property TVEpisodeActorThumbsExtExpert() As String
        Get
            Return _XMLSettings.TVEpisodeActorThumbsExtExpert
        End Get
        Set(ByVal value As String)
            _XMLSettings.TVEpisodeActorThumbsExtExpert = value
        End Set
    End Property

    Public Property TVEpisodeActorThumbsFrodo() As Boolean
        Get
            Return _XMLSettings.TVEpisodeActorThumbsFrodo
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVEpisodeActorThumbsFrodo = value
        End Set
    End Property

    Public Property TVEpisodeFanartExpert() As String
        Get
            Return _XMLSettings.TVEpisodeFanartExpert
        End Get
        Set(ByVal value As String)
            _XMLSettings.TVEpisodeFanartExpert = value
        End Set
    End Property

    Public Property TVEpisodeNFOExpert() As String
        Get
            Return _XMLSettings.TVEpisodeNFOExpert
        End Get
        Set(ByVal value As String)
            _XMLSettings.TVEpisodeNFOExpert = value
        End Set
    End Property

    Public Property TVEpisodeNFOBoxee() As Boolean
        Get
            Return _XMLSettings.TVEpisodeNFOBoxee
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVEpisodeNFOBoxee = value
        End Set
    End Property

    Public Property TVEpisodePosterBoxee() As Boolean
        Get
            Return _XMLSettings.TVEpisodePosterBoxee
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVEpisodePosterBoxee = value
        End Set
    End Property

    Public Property TVEpisodePosterExpert() As String
        Get
            Return _XMLSettings.TVEpisodePosterExpert
        End Get
        Set(ByVal value As String)
            _XMLSettings.TVEpisodePosterExpert = value
        End Set
    End Property

    Public Property TVEpisodeNFOFrodo() As Boolean
        Get
            Return _XMLSettings.TVEpisodeNFOFrodo
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVEpisodeNFOFrodo = value
        End Set
    End Property

    Public Property TVEpisodePosterFrodo() As Boolean
        Get
            Return _XMLSettings.TVEpisodePosterFrodo
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVEpisodePosterFrodo = value
        End Set
    End Property

    Public Property TVEpisodeNFOYAMJ() As Boolean
        Get
            Return _XMLSettings.TVEpisodeNFOYAMJ
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVEpisodeNFOYAMJ = value
        End Set
    End Property

    Public Property TVEpisodePosterYAMJ() As Boolean
        Get
            Return _XMLSettings.TVEpisodePosterYAMJ
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVEpisodePosterYAMJ = value
        End Set
    End Property

    Public Property TVEpisodeActorThumbsKeepExisting() As Boolean
        Get
            Return _XMLSettings.TVEpisodeActorThumbsKeepExisting
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVEpisodeActorThumbsKeepExisting = value
        End Set
    End Property

    Public Property TVShowClearLogoAD() As Boolean
        Get
            Return _XMLSettings.TVShowClearLogoAD
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVShowClearLogoAD = value
        End Set
    End Property

    Public Property TVShowClearLogoExtended() As Boolean
        Get
            Return _XMLSettings.TVShowClearLogoExtended
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVShowClearLogoExtended = value
        End Set
    End Property

    Public Property TVShowClearArtAD() As Boolean
        Get
            Return _XMLSettings.TVShowClearArtAD
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVShowClearArtAD = value
        End Set
    End Property

    Public Property TVShowClearArtExtended() As Boolean
        Get
            Return _XMLSettings.TVShowClearArtExtended
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVShowClearArtExtended = value
        End Set
    End Property

    Public Property TVShowCharacterArtAD() As Boolean
        Get
            Return _XMLSettings.TVShowCharacterArtAD
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVShowCharacterArtAD = value
        End Set
    End Property

    Public Property TVShowCharacterArtExtended() As Boolean
        Get
            Return _XMLSettings.TVShowCharacterArtExtended
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVShowCharacterArtExtended = value
        End Set
    End Property

    Public Property TVShowLandscapeAD() As Boolean
        Get
            Return _XMLSettings.TVShowLandscapeAD
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVShowLandscapeAD = value
        End Set
    End Property

    Public Property TVShowLandscapeExtended() As Boolean
        Get
            Return _XMLSettings.TVShowLandscapeExtended
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVShowLandscapeExtended = value
        End Set
    End Property

    Public Property TVSeasonLandscapeAD() As Boolean
        Get
            Return _XMLSettings.TVSeasonLandscapeAD
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVSeasonLandscapeAD = value
        End Set
    End Property

    Public Property TVSeasonLandscapeExtended() As Boolean
        Get
            Return _XMLSettings.TVSeasonLandscapeExtended
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVSeasonLandscapeExtended = value
        End Set
    End Property

    Public Property TVShowMissingBanner() As Boolean
        Get
            Return _XMLSettings.TVShowMissingBanner
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVShowMissingBanner = value
        End Set
    End Property

    Public Property TVSeasonMissingBanner() As Boolean
        Get
            Return _XMLSettings.TVSeasonMissingBanner
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVSeasonMissingBanner = value
        End Set
    End Property

    Public Property TVShowMissingCharacterArt() As Boolean
        Get
            Return _XMLSettings.TVShowMissingCharacterArt
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVShowMissingCharacterArt = value
        End Set
    End Property

    Public Property TVShowMissingClearArt() As Boolean
        Get
            Return _XMLSettings.TVShowMissingClearArt
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVShowMissingClearArt = value
        End Set
    End Property

    Public Property TVShowMissingClearLogo() As Boolean
        Get
            Return _XMLSettings.TVShowMissingClearLogo
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVShowMissingClearLogo = value
        End Set
    End Property

    Public Property TVShowMissingExtrafanarts() As Boolean
        Get
            Return _XMLSettings.TVShowMissingExtrafanarts
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVShowMissingExtrafanarts = value
        End Set
    End Property

    Public Property TVShowMissingFanart() As Boolean
        Get
            Return _XMLSettings.TVShowMissingFanart
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVShowMissingFanart = value
        End Set
    End Property

    Public Property TVSeasonMissingFanart() As Boolean
        Get
            Return _XMLSettings.TVSeasonMissingFanart
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVSeasonMissingFanart = value
        End Set
    End Property

    Public Property TVEpisodeMissingFanart() As Boolean
        Get
            Return _XMLSettings.TVEpisodeMissingFanart
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVEpisodeMissingFanart = value
        End Set
    End Property

    Public Property TVShowMissingLandscape() As Boolean
        Get
            Return _XMLSettings.TVShowMissingLandscape
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVShowMissingLandscape = value
        End Set
    End Property

    Public Property TVSeasonMissingLandscape() As Boolean
        Get
            Return _XMLSettings.TVSeasonMissingLandscape
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVSeasonMissingLandscape = value
        End Set
    End Property

    Public Property TVShowMissingNFO() As Boolean
        Get
            Return _XMLSettings.TVShowMissingNFO
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVShowMissingNFO = value
        End Set
    End Property

    Public Property TVEpisodeMissingNFO() As Boolean
        Get
            Return _XMLSettings.TVEpisodeMissingNFO
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVEpisodeMissingNFO = value
        End Set
    End Property

    Public Property TVShowMissingPoster() As Boolean
        Get
            Return _XMLSettings.TVShowMissingPoster
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVShowMissingPoster = value
        End Set
    End Property

    Public Property TVSeasonMissingPoster() As Boolean
        Get
            Return _XMLSettings.TVSeasonMissingPoster
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVSeasonMissingPoster = value
        End Set
    End Property

    Public Property TVEpisodeMissingPoster() As Boolean
        Get
            Return _XMLSettings.TVEpisodeMissingPoster
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVEpisodeMissingPoster = value
        End Set
    End Property

    Public Property TVShowMissingTheme() As Boolean
        Get
            Return _XMLSettings.TVShowMissingTheme
        End Get
        Set(ByVal value As Boolean)
            _XMLSettings.TVShowMissingTheme = value
        End Set
    End Property

#End Region 'Properties

#Region "Methods"

    Public Sub Load()
        'Cocotus, Load from central "Settings" folder if it exists!
        Dim configpath As String = Path.Combine(Master.SettingsPath, "Settings.xml")

        Try
            If File.Exists(configpath) Then
                Dim objStreamReader As New StreamReader(configpath)
                Dim xXMLSettings As New XmlSerializer(_XMLSettings.GetType)

                _XMLSettings = CType(xXMLSettings.Deserialize(objStreamReader), clsXMLSettings)
                objStreamReader.Close()
                'Now we deserialize just the data in a local, shared, variable. So we can reference to us
                Master.eSettings = Me
            End If
        Catch ex As Exception
            logger.Error(ex, New StackFrame().GetMethod().Name)
            logger.Info("An attempt is made to repair the Settings.xml")
            Try
                Using srSettings As New StreamReader(configpath)
                    Dim sSettings As String = srSettings.ReadToEnd
                    'old Fanart/Poster sizes
                    sSettings = System.Text.RegularExpressions.Regex.Replace(sSettings, "PrefSize>Xlrg<", "PrefSize>Any<")
                    sSettings = System.Text.RegularExpressions.Regex.Replace(sSettings, "PrefSize>Lrg<", "PrefSize>Any<")
                    sSettings = System.Text.RegularExpressions.Regex.Replace(sSettings, "PrefSize>Mid<", "PrefSize>Any<")
                    sSettings = System.Text.RegularExpressions.Regex.Replace(sSettings, "PrefSize>Small<", "PrefSize>Any<")
                    'old Trailer Audio/Video quality
                    sSettings = System.Text.RegularExpressions.Regex.Replace(sSettings, "Qual>All<", "Qual>Any<")
                    'old allseasons/season/tvshow banner type
                    sSettings = System.Text.RegularExpressions.Regex.Replace(sSettings, "PrefType>None<", "PrefType>Any<")
                    'old seasonposter size HD1000
                    sSettings = System.Text.RegularExpressions.Regex.Replace(sSettings, "<TVSeasonPosterPrefSize>HD1000</TVSeasonPosterPrefSize>",
                                                                             "<TVSeasonPosterPrefSize>Any</TVSeasonPosterPrefSize>")

                    Dim xXMLSettings As New XmlSerializer(_XMLSettings.GetType)
                    Using reader As TextReader = New StringReader(sSettings)
                        _XMLSettings = CType(xXMLSettings.Deserialize(reader), clsXMLSettings)
                    End Using
                    'Now we deserialize just the data in a local, shared, variable. So we can reference to us
                    Master.eSettings = Me
                    logger.Info("AdvancedSettings.xml successfully repaired")
                End Using
            Catch ex2 As Exception
                logger.Error(ex2, New StackFrame().GetMethod().Name)
                File.Copy(configpath, String.Concat(configpath, "_backup"), True)
                Master.eSettings = New Settings
            End Try
        End Try

        SetDefaultsForLists(Enums.DefaultSettingType.All, False)

        ' Fix added to avoid to have no movie NFO saved
        If Not (Master.eSettings.MovieUseBoxee Or Master.eSettings.MovieUseEden Or Master.eSettings.MovieUseExpert Or Master.eSettings.MovieUseFrodo Or Master.eSettings.MovieUseNMJ Or Master.eSettings.MovieUseYAMJ) Then
            Master.eSettings.MovieUseFrodo = True
            Master.eSettings.MovieActorThumbsFrodo = True
            Master.eSettings.MovieExtrafanartsFrodo = True
            Master.eSettings.MovieExtrathumbsFrodo = True
            Master.eSettings.MovieFanartFrodo = True
            Master.eSettings.MovieNFOFrodo = True
            Master.eSettings.MoviePosterFrodo = True
            Master.eSettings.MovieThemeTvTunesEnable = True
            Master.eSettings.MovieThemeTvTunesMoviePath = True
            Master.eSettings.MovieTrailerFrodo = True
            Master.eSettings.MovieScraperXBMCTrailerFormat = True
        End If

        ' Fix added to avoid to have no tv show NFO saved
        If Not (Master.eSettings.TVUseBoxee OrElse Master.eSettings.TVUseEden OrElse Master.eSettings.TVUseExpert OrElse Master.eSettings.TVUseFrodo OrElse Master.eSettings.TVUseYAMJ) Then
            Master.eSettings.TVUseFrodo = True
            Master.eSettings.TVEpisodeActorThumbsFrodo = True
            Master.eSettings.TVEpisodeNFOFrodo = True
            Master.eSettings.TVEpisodePosterFrodo = True
            Master.eSettings.TVSeasonBannerFrodo = True
            Master.eSettings.TVSeasonFanartFrodo = True
            Master.eSettings.TVSeasonPosterFrodo = True
            Master.eSettings.TVShowActorThumbsFrodo = True
            Master.eSettings.TVShowBannerFrodo = True
            Master.eSettings.TVShowExtrafanartsFrodo = True
            Master.eSettings.TVShowFanartFrodo = True
            Master.eSettings.TVShowNFOFrodo = True
            Master.eSettings.TVShowPosterFrodo = True
        End If
    End Sub

    Public Sub Save()
        Try
            Dim xmlSerial As New XmlSerializer(GetType(Settings))
            Dim xmlWriter As New StreamWriter(Path.Combine(Master.SettingsPath, "Settings.xml"))
            xmlSerial.Serialize(xmlWriter, Master.eSettings)
            xmlWriter.Close()
        Catch ex As Exception
            logger.Error(ex, New StackFrame().GetMethod().Name)
        End Try
    End Sub
    ''' <summary>
    ''' Defines all default settings for a new installation
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub SetDefaults()
        CleanDotFanartJPG = False
        CleanExtrathumbs = False
        CleanFanartJPG = False
        CleanFolderJPG = False
        CleanMovieJPG = False
        CleanMovieNFO = False
        CleanMovieNFOB = False
        CleanMovieTBN = False
        CleanMovieTBNB = False
        CleanMovieFanartJPG = False
        CleanMovieNameJPG = False
        CleanPosterJPG = False
        CleanPosterTBN = False
        Addons = New List(Of AddonsManager._XMLAddonClass)
        FileSystemCleanerWhitelist = False
        FileSystemCleanerWhitelistExts = New List(Of String)
        FileSystemExpertCleaner = False
        FileSystemNoStackExts = New List(Of String)
        FileSystemValidExts = New List(Of String)
        FileSystemValidSubtitlesExts = New List(Of String)
        FileSystemValidThemeExts = New List(Of String)
        GeneralCheckUpdates = False
        GeneralDaemonDrive = String.Empty
        GeneralDaemonPath = String.Empty
        GeneralDateAddedIgnoreNFO = False
        GeneralDateTime = Enums.DateTime.Now
        GeneralDigitGrpSymbolVotes = False
        GeneralDisplayBanner = True
        GeneralDisplayCharacterArt = True
        GeneralDisplayClearArt = True
        GeneralDisplayClearLogo = True
        GeneralDisplayDiscArt = True
        GeneralDisplayFanart = True
        GeneralDisplayFanartSmall = True
        GeneralDisplayLandscape = True
        GeneralDisplayPoster = True
        GeneralDoubleClickScrape = False
        GeneralFilterPanelIsRaisedMovie = False
        GeneralFilterPanelIsRaisedMovieSet = False
        GeneralFilterPanelIsRaisedTVShow = False
        GeneralImageFilter = True
        GeneralImageFilterAutoscraper = True
        GeneralImageFilterFanart = True
        GeneralImageFilterFanartMatchTolerance = 4
        GeneralImageFilterImagedialog = False
        GeneralImageFilterPoster = False
        GeneralImageFilterPosterMatchTolerance = 1
        GeneralImagesGlassOverlay = False
        GeneralInfoPanelStateMovie = 200
        GeneralInfoPanelStateMovieSet = 200
        GeneralInfoPanelStateTVShow = 200
        GeneralLanguage = "English_(en_US)"
        GeneralMainFilterSortColumn_MovieSets = 1
        GeneralMainFilterSortColumn_Movies = 3
        GeneralMainFilterSortColumn_Shows = 1
        GeneralMainFilterSortOrder_MovieSets = 0
        GeneralMainFilterSortOrder_Movies = 0
        GeneralMainFilterSortOrder_Shows = 0
        GeneralMovieSetTheme = "Default"
        GeneralMovieTheme = "Default"
        GeneralOverwriteNfo = False
        GeneralShowGenresText = True
        GeneralShowImgDims = True
        GeneralShowImgNames = True
        GeneralShowLangFlags = True
        GeneralSourceFromFolder = False
        GeneralSplitterDistanceMain = 550
        GeneralSplitterDistanceTVSeason = 200
        GeneralSplitterDistanceTVShow = 200
        GeneralTVEpisodeTheme = "Default"
        GeneralTVShowTheme = "Default"
        GeneralWindowLoc = New Point(10, 10)
        GeneralWindowSize = New Size(1024, 768)
        GeneralWindowState = FormWindowState.Maximized
        MovieActorThumbsExtExpertBDMV = ".jpg"
        MovieActorThumbsExtExpertMulti = ".jpg"
        MovieActorThumbsExtExpertSingle = ".jpg"
        MovieActorThumbsExtExpertVTS = ".jpg"
        MovieActorThumbsKeepExisting = False
        MovieBackdropsAuto = False
        MovieBackdropsPath = String.Empty
        MovieBannerHeight = 0
        MovieBannerKeepExisting = False
        MovieBannerPrefSizeOnly = False
        MovieBannerPrefSize = Enums.MovieBannerSize.Any
        MovieBannerResize = False
        MovieBannerWidth = 0
        MovieCleanDB = False
        MovieClearArtKeepExisting = False
        MovieClearArtPrefSize = Enums.MovieClearArtSize.Any
        MovieClearArtPrefSizeOnly = False
        MovieClearLogoKeepExisting = False
        MovieClearLogoPrefSize = Enums.MovieClearLogoSize.Any
        MovieClearLogoPrefSizeOnly = False
        MovieClickScrape = False
        MovieClickScrapeAsk = False
        MovieDiscArtKeepExisting = False
        MovieDiscArtPrefSize = Enums.MovieDiscArtSize.Any
        MovieDiscArtPrefSizeOnly = False
        MovieDisplayYear = False
        MovieExtrafanartsHeight = 0
        MovieExtrafanartsLimit = 4
        MovieExtrafanartsKeepExisting = False
        MovieExtrafanartsPrefSizeOnly = False
        MovieExtrafanartsPrefSize = Enums.MovieFanartSize.Any
        MovieExtrafanartsPreselect = True
        MovieExtrafanartsResize = False
        MovieExtrafanartsWidth = 0
        MovieExtrathumbsCreatorAutoThumbs = False
        MovieExtrathumbsCreatorNoBlackBars = False
        MovieExtrathumbsCreatorNoSpoilers = False
        MovieExtrathumbsCreatorUseETasFA = False
        MovieExtrathumbsHeight = 0
        MovieExtrathumbsLimit = 4
        MovieExtrathumbsKeepExisting = False
        MovieExtrathumbsPrefSizeOnly = False
        MovieExtrathumbsPrefSize = 0
        MovieExtrathumbsPreselect = True
        MovieExtrathumbsResize = False
        MovieExtrathumbsWidth = 0
        MovieFanartHeight = 0
        MovieFanartKeepExisting = False
        MovieFanartPrefSizeOnly = False
        MovieFanartPrefSize = Enums.MovieFanartSize.Any
        MovieFanartResize = False
        MovieFanartWidth = 0
        MovieFilterCustom = New List(Of String)
        MovieFilterCustomIsEmpty = False
        MovieGeneralCustomMarker1Color = -32704
        MovieGeneralCustomMarker2Color = -16776961
        MovieGeneralCustomMarker3Color = -12582784
        MovieGeneralCustomMarker4Color = -16711681
        MovieGeneralCustomMarker1Name = String.Empty
        MovieGeneralCustomMarker2Name = String.Empty
        MovieGeneralCustomMarker3Name = String.Empty
        MovieGeneralCustomMarker4Name = String.Empty
        MovieGeneralCustomScrapeButtonEnabled = False
        MovieGeneralCustomScrapeButtonModifierType = Enums.ScrapeModifierType.All
        MovieGeneralCustomScrapeButtonScrapeType = Enums.ScrapeType.NewSkip
        MovieGeneralFlagLang = String.Empty
        MovieGeneralIgnoreLastScan = True
        MovieGeneralLanguage = "en-US"
        MovieGeneralMarkNew = False
        MovieGeneralMediaListSorting = New List(Of ListSorting)
        MovieImagesCacheEnabled = False
        MovieImagesDisplayImageSelect = True
        MovieImagesForcedLanguage = "en"
        MovieImagesForceLanguage = False
        MovieImagesGetBlankImages = False
        MovieImagesGetEnglishImages = False
        MovieImagesMediaLanguageOnly = False
        MovieImagesNotSaveURLToNfo = False
        MovieIMDBURL = String.Empty
        MovieLandscapeKeepExisting = False
        MovieLandscapePrefSize = Enums.MovieLandscapeSize.Any
        MovieLandscapePrefSizeOnly = False
        MovieLevTolerance = 0
        MovieLockActors = False
        MovieLockCert = False
        MovieLockCollectionID = False
        MovieLockCollections = False
        MovieLockCountry = False
        MovieLockDirector = False
        MovieLockGenre = False
        MovieLockLanguageA = False
        MovieLockLanguageV = False
        MovieLockMPAA = False
        MovieLockOriginalTitle = False
        MovieLockOutline = False
        MovieLockPlot = False
        MovieLockRating = False
        MovieLockReleaseDate = False
        MovieLockRuntime = False
        MovieLockStudio = False
        MovieLockTags = False
        MovieLockTagline = False
        MovieLockTitle = False
        MovieLockTop250 = False
        MovieLockTrailer = False
        MovieLockUserRating = False
        MovieLockCredits = False
        MovieLockYear = False
        MovieMetadataPerFileType = New List(Of MetadataPerType)
        MovieMissingBanner = False
        MovieMissingClearArt = False
        MovieMissingClearLogo = False
        MovieMissingDiscArt = False
        MovieMissingExtrafanarts = False
        MovieMissingExtrathumbs = False
        MovieMissingFanart = False
        MovieMissingLandscape = False
        MovieMissingNFO = False
        MovieMissingPoster = False
        MovieMissingSubtitles = False
        MovieMissingTheme = False
        MovieMissingTrailer = False
        MoviePosterHeight = 0
        MoviePosterKeepExisting = False
        MoviePosterPrefSizeOnly = False
        MoviePosterPrefSize = Enums.MoviePosterSize.Any
        MoviePosterResize = False
        MoviePosterWidth = 0
        MovieProperCase = True
        MovieScanOrderModify = False
        MovieScraperCast = True
        MovieScraperCastLimit = 0
        MovieScraperCastWithImgOnly = False
        MovieScraperCertForMPAA = False
        MovieScraperCertForMPAAFallback = False
        MovieScraperCert = False
        MovieScraperCertLang = String.Empty
        MovieScraperCleanFields = False
        MovieScraperCleanPlotOutline = False
        MovieScraperCollectionID = True
        MovieScraperCollectionsAuto = True
        MovieScraperCollectionsExtendedInfo = False
        MovieScraperCollectionsYAMJCompatibleSets = False
        MovieScraperCountry = True
        MovieScraperDirector = True
        MovieScraperDurationRuntimeFormat = "<m>"
        MovieScraperGenre = True
        MovieScraperGenreLimit = 0
        MovieScraperMetaDataIFOScan = True
        MovieScraperMetaDataScan = True
        MovieScraperMPAA = True
        MovieScraperMPAANotRated = String.Empty
        MovieScraperOriginalTitle = True
        MovieScraperCertOnlyValue = False
        MovieScraperOutline = True
        MovieScraperOutlineLimit = 350
        MovieScraperPlot = True
        MovieScraperPlotForOutline = False
        MovieScraperPlotForOutlineIfEmpty = False
        MovieScraperRating = True
        MovieScraperRelease = True
        MovieScraperRuntime = True
        MovieScraperStudio = True
        MovieScraperStudioLimit = 0
        MovieScraperStudioWithImgOnly = False
        MovieScraperTagline = True
        MovieScraperTitle = True
        MovieScraperTop250 = True
        MovieScraperTrailer = True
        MovieScraperUseDetailView = False
        MovieScraperUseMDDuration = True
        MovieScraperUserRating = True
        MovieScraperCertFSK = False
        MovieScraperCredits = True
        MovieScraperXBMCTrailerFormat = False
        MovieScraperYear = True
        MovieSetBannerHeight = 0
        MovieSetBannerKeepExisting = False
        MovieSetBannerPrefSizeOnly = False
        MovieSetBannerPrefSize = Enums.MovieBannerSize.Any
        MovieSetBannerResize = False
        MovieSetBannerWidth = 0
        MovieSetCleanDB = False
        MovieSetCleanFiles = False
        MovieSetClearArtKeepExisting = False
        MovieSetClearArtPrefSize = Enums.MovieClearArtSize.Any
        MovieSetClearArtPrefSizeOnly = False
        MovieSetClearLogoKeepExisting = False
        MovieSetClearlogoPrefSize = Enums.MovieClearLogoSize.Any
        MovieSetClearLogoPrefSizeOnly = False
        MovieSetClickScrape = False
        MovieSetClickScrapeAsk = False
        MovieSetDiscArtKeepExisting = False
        MovieSetDiscArtPrefSize = Enums.MovieDiscArtSize.Any
        MovieSetDiscArtPrefSizeOnly = False
        MovieSetFanartHeight = 0
        MovieSetFanartKeepExisting = False
        MovieSetFanartPrefSizeOnly = False
        MovieSetFanartPrefSize = Enums.MovieFanartSize.Any
        MovieSetFanartResize = False
        MovieSetFanartWidth = 0
        MovieSetGeneralCustomScrapeButtonEnabled = False
        MovieSetGeneralCustomScrapeButtonModifierType = Enums.ScrapeModifierType.All
        MovieSetGeneralCustomScrapeButtonScrapeType = Enums.ScrapeType.NewSkip
        MovieSetGeneralMarkNew = False
        MovieSetGeneralMediaListSorting = New List(Of ListSorting)
        MovieSetImagesCacheEnabled = False
        MovieSetImagesDisplayImageSelect = True
        MovieSetImagesForcedLanguage = "en"
        MovieSetImagesForceLanguage = False
        MovieSetImagesGetBlankImages = False
        MovieSetImagesGetEnglishImages = False
        MovieSetImagesMediaLanguageOnly = False
        MovieSetLandscapeKeepExisting = False
        MovieSetLandscapePrefSize = Enums.MovieLandscapeSize.Any
        MovieSetLandscapePrefSizeOnly = False
        MovieSetLockPlot = False
        MovieSetLockTitle = False
        MovieSetMissingBanner = False
        MovieSetMissingClearArt = False
        MovieSetMissingClearLogo = False
        MovieSetMissingDiscArt = False
        MovieSetMissingFanart = False
        MovieSetMissingLandscape = False
        MovieSetMissingNFO = False
        MovieSetMissingPoster = False
        MovieSetPosterHeight = 0
        MovieSetPosterKeepExisting = False
        MovieSetPosterPrefSizeOnly = False
        MovieSetPosterPrefSize = Enums.MoviePosterSize.Any
        MovieSetPosterResize = False
        MovieSetPosterWidth = 0
        MovieSetScraperPlot = True
        MovieSetScraperTitle = True
        MovieSkipLessThan = 0
        MovieSkipStackedSizeCheck = False
        MovieSortBeforeScan = False
        MovieSortTokens = New List(Of String)
        MovieSetSortTokens = New List(Of String)
        MovieSortTokensIsEmpty = False
        MovieSetSortTokensIsEmpty = False
        MovieThemeTvTunesEnable = True
        MovieThemeKeepExisting = False
        MovieTrailerDefaultSearch = "trailer"
        MovieTrailerKeepExisting = False
        MovieTrailerMinVideoQual = Enums.TrailerVideoQuality.Any
        MovieTrailerPrefVideoQual = Enums.TrailerVideoQuality.Any
        OMMDummyFormat = 0
        OMMDummyTagline = String.Empty
        OMMDummyTop = String.Empty
        OMMDummyUseBackground = True
        OMMDummyUseFanart = True
        OMMDummyUseOverlay = True
        OMMMediaStubTagline = String.Empty
        Password = String.Empty
        ProxyCredentials = New NetworkCredential
        ProxyPort = 0
        ProxyURI = String.Empty
        SortPath = String.Empty
        TVAllSeasonsBannerHeight = 0
        TVAllSeasonsBannerKeepExisting = False
        TVAllSeasonsBannerPrefSize = Enums.TVBannerSize.Any
        TVAllSeasonsBannerPrefSizeOnly = False
        TVAllSeasonsBannerPrefType = Enums.TVBannerType.Any
        TVAllSeasonsBannerResize = False
        TVAllSeasonsBannerWidth = 0
        TVAllSeasonsFanartHeight = 0
        TVAllSeasonsFanartKeepExisting = False
        TVAllSeasonsFanartPrefSize = Enums.TVFanartSize.Any
        TVAllSeasonsFanartPrefSizeOnly = False
        TVAllSeasonsFanartResize = False
        TVAllSeasonsFanartWidth = 0
        TVAllSeasonsLandscapeKeepExisting = False
        'TVAllSeasonsLandscapeKeepPrefSize = Enums.TVLandscapeSize.Any
        'TVAllSeasonsLandscapeKeepPrefSizeOnly = False
        TVAllSeasonsPosterHeight = 0
        TVAllSeasonsPosterKeepExisting = False
        TVAllSeasonsPosterPrefSize = Enums.TVPosterSize.Any
        TVAllSeasonsPosterPrefSizeOnly = False
        TVAllSeasonsPosterResize = False
        TVAllSeasonsPosterWidth = 0
        TVCleanDB = False
        TVDisplayMissingEpisodes = True
        TVDisplayStatus = False
        TVEpisodeActorThumbsExtExpert = ".jpg"
        TVEpisodeActorThumbsKeepExisting = False
        TVEpisodeFanartHeight = 0
        TVEpisodeFanartKeepExisting = False
        TVEpisodeFanartPrefSize = Enums.TVFanartSize.Any
        TVEpisodeFanartPrefSizeOnly = False
        TVEpisodeFanartResize = False
        TVEpisodeFanartWidth = 0
        TVEpisodeFilterCustom = New List(Of String)
        TVEpisodeFilterCustomIsEmpty = False
        TVEpisodeMissingFanart = False
        TVEpisodeMissingNFO = False
        TVEpisodeMissingPoster = False
        TVEpisodeNoFilter = True
        TVEpisodePosterHeight = 0
        TVEpisodePosterKeepExisting = False
        TVEpisodePosterPrefSize = Enums.TVEpisodePosterSize.Any
        TVEpisodePosterPrefSizeOnly = False
        TVEpisodePosterResize = False
        TVEpisodePosterWidth = 0
        TVEpisodeProperCase = True
        TVGeneralClickScrape = False
        TVGeneralClickScrapeAsk = False
        TVGeneralCustomScrapeButtonEnabled = False
        TVGeneralCustomScrapeButtonModifierType = Enums.ScrapeModifierType.All
        TVGeneralCustomScrapeButtonScrapeType = Enums.ScrapeType.NewSkip
        TVGeneralEpisodeListSorting = New List(Of ListSorting)
        TVGeneralFlagLang = String.Empty
        TVGeneralIgnoreLastScan = True
        TVGeneralLanguage = "en-US"
        TVGeneralMarkNewEpisodes = False
        TVGeneralMarkNewShows = False
        TVGeneralSeasonListSorting = New List(Of ListSorting)
        TVGeneralShowListSorting = New List(Of ListSorting)
        TVImagesCacheEnabled = True
        TVImagesDisplayImageSelect = True
        TVImagesForcedLanguage = "en"
        TVImagesForceLanguage = False
        TVImagesGetBlankImages = False
        TVImagesGetEnglishImages = False
        TVImagesMediaLanguageOnly = False
        TVLockEpisodeActors = False
        TVLockEpisodeAired = False
        TVLockEpisodeCredits = False
        TVLockEpisodeDirector = False
        TVLockEpisodeGuestStars = False
        TVLockEpisodeLanguageA = False
        TVLockEpisodeLanguageV = False
        TVLockEpisodePlot = False
        TVLockEpisodeRating = False
        TVLockEpisodeRuntime = False
        TVLockEpisodeTitle = False
        TVLockEpisodeUserRating = False
        TVLockSeasonPlot = False
        TVLockSeasonTitle = False
        TVLockShowActors = False
        TVLockShowCert = False
        TVLockShowCreators = False
        TVLockShowCountry = False
        TVLockShowGenre = False
        TVLockShowMPAA = False
        TVLockShowOriginalTitle = False
        TVLockShowPlot = False
        TVLockShowPremiered = False
        TVLockShowRating = False
        TVLockShowRuntime = False
        TVLockShowStatus = False
        TVLockShowStudio = False
        TVLockShowTitle = False
        TVLockShowUserRating = False
        TVMetadataPerFileType = New List(Of MetadataPerType)
        TVMultiPartMatching = "^[-_ex]+([0-9]+(?:(?:[a-i]|\.[1-9])(?![0-9]))?)"
        TVScanOrderModify = False
        TVScraperCleanFields = False
        TVScraperDurationRuntimeFormat = "<m>"
        TVScraperEpisodeActors = True
        TVScraperEpisodeAired = True
        TVScraperEpisodeCredits = True
        TVScraperEpisodeDirector = True
        TVScraperEpisodeGuestStars = True
        TVScraperEpisodeGuestStarsToActors = False
        TVScraperEpisodePlot = True
        TVScraperEpisodeRating = True
        TVScraperEpisodeRuntime = True
        TVScraperEpisodeTitle = True
        TVScraperEpisodeUserRating = True
        TVScraperMetaDataScan = True
        TVScraperOptionsOrdering = Enums.EpisodeOrdering.Standard
        TVScraperSeasonAired = True
        TVScraperSeasonPlot = True
        TVScraperSeasonTitle = False
        TVScraperShowActors = True
        TVScraperShowCert = False
        TVScraperShowCertForMPAA = False
        TVScraperShowCertForMPAAFallback = False
        TVScraperShowCertFSK = False
        TVScraperShowCertLang = String.Empty
        TVScraperShowCertOnlyValue = False
        TVScraperShowCreators = True
        TVScraperShowCountry = True
        TVScraperShowEpiGuideURL = False
        TVScraperShowGenre = True
        TVScraperShowMPAA = True
        TVScraperShowMPAANotRated = String.Empty
        TVScraperShowOriginalTitle = True
        TVScraperShowPlot = True
        TVScraperShowPremiered = True
        TVScraperShowRating = True
        TVScraperShowRuntime = True
        TVScraperShowStatus = True
        TVScraperShowStudio = True
        TVScraperShowTitle = True
        TVScraperShowUserRating = True
        TVScraperUseDisplaySeasonEpisode = True
        TVScraperUseMDDuration = True
        TVScraperUseSRuntimeForEp = True
        TVSeasonBannerHeight = 0
        TVSeasonBannerKeepExisting = False
        TVSeasonBannerPrefSize = Enums.TVBannerSize.Any
        TVSeasonBannerPrefSizeOnly = False
        TVSeasonBannerPrefType = Enums.TVBannerType.Any
        TVSeasonBannerResize = False
        TVSeasonBannerWidth = 0
        TVSeasonFanartHeight = 0
        TVSeasonFanartKeepExisting = False
        TVSeasonFanartPrefSize = Enums.TVFanartSize.Any
        TVSeasonFanartPrefSizeOnly = False
        TVSeasonFanartPrefSizeOnly = False
        TVSeasonFanartResize = False
        TVSeasonFanartWidth = 0
        TVSeasonLandscapeKeepExisting = False
        TVSeasonLandscapePrefSize = Enums.TVLandscapeSize.Any
        TVSeasonLandscapePrefSizeOnly = False
        TVSeasonMissingBanner = False
        TVSeasonMissingFanart = False
        TVSeasonMissingLandscape = False
        TVSeasonMissingPoster = False
        TVSeasonPosterHeight = 0
        TVSeasonPosterKeepExisting = False
        TVSeasonPosterPrefSize = Enums.TVSeasonPosterSize.Any
        TVSeasonPosterPrefSizeOnly = False
        TVSeasonPosterPrefSizeOnly = False
        TVSeasonPosterResize = False
        TVSeasonPosterWidth = 0
        TVShowActorThumbsExtExpert = ".jpg"
        TVShowActorThumbsKeepExisting = False
        TVShowBannerHeight = 0
        TVShowBannerKeepExisting = False
        TVShowBannerPrefSize = Enums.TVBannerSize.Any
        TVShowBannerPrefSizeOnly = False
        TVShowBannerPrefType = Enums.TVBannerType.Any
        TVShowBannerResize = False
        TVShowBannerWidth = 0
        TVShowCharacterArtKeepExisting = False
        TVShowCharacterArtPrefSize = Enums.TVCharacterArtSize.Any
        TVShowCharacterArtPrefSizeOnly = False
        TVShowClearArtKeepExisting = False
        TVShowClearLogoKeepExisting = False
        TVShowExtrafanartsLimit = 4
        TVShowExtrafanartsKeepExisting = False
        TVShowExtrafanartsPrefOnly = False
        TVShowExtrafanartsPrefSize = Enums.TVFanartSize.Any
        TVShowExtrafanartsPrefSizeOnly = False
        TVShowExtrafanartsPreselect = True
        TVShowExtrafanartsResize = False
        TVShowExtrafanartsHeight = 0
        TVShowExtrafanartsWidth = 0
        TVShowFanartHeight = 0
        TVShowFanartKeepExisting = False
        TVShowFanartPrefSize = Enums.TVFanartSize.Any
        TVShowFanartPrefSizeOnly = False
        TVShowFanartResize = False
        TVShowFanartWidth = 0
        TVShowFilterCustom = New List(Of String)
        TVShowFilterCustomIsEmpty = False
        TVShowLandscapeKeepExisting = False
        TVShowMatching = New List(Of regexp)
        TVShowMissingBanner = False
        TVShowMissingCharacterArt = False
        TVShowMissingClearArt = False
        TVShowMissingClearLogo = False
        TVShowMissingExtrafanarts = False
        TVShowMissingFanart = False
        TVShowMissingLandscape = False
        TVShowMissingNFO = False
        TVShowMissingPoster = False
        TVShowMissingTheme = False
        TVShowPosterHeight = 0
        TVShowPosterKeepExisting = False
        TVShowPosterPrefSize = Enums.TVPosterSize.Any
        TVShowPosterPrefSizeOnly = False
        TVShowPosterResize = False
        TVShowPosterWidth = 0
        TVShowProperCase = True
        TVShowThemeKeepExisting = False
        TVSkipLessThan = 0
        TVSortTokens = New List(Of String)
        TVSortTokensIsEmpty = False
        Username = String.Empty
        Version = String.Empty
    End Sub

    Public Sub SetDefaultsForLists(ByVal Type As Enums.DefaultSettingType, ByVal Force As Boolean)
        If (Type = Enums.DefaultSettingType.All OrElse Type = Enums.DefaultSettingType.MovieFilters) AndAlso (Force OrElse (Master.eSettings.MovieFilterCustom.Count <= 0 AndAlso Not Master.eSettings.MovieFilterCustomIsEmpty)) Then
            Master.eSettings.MovieFilterCustom.Clear()
            Master.eSettings.MovieFilterCustom.Add("(?i)[\W_]\(?\d{4}\)?.*")    'year in brakets
            Master.eSettings.MovieFilterCustom.Add("(?i)[\W_]tt\d*")            'IMDB ID
            Master.eSettings.MovieFilterCustom.Add("(?i)[\W_]blu[\W_]?ray.*")
            Master.eSettings.MovieFilterCustom.Add("(?i)[\W_]bd[\W_]?rip.*")
            Master.eSettings.MovieFilterCustom.Add("(?i)[\W_]3d.*")
            Master.eSettings.MovieFilterCustom.Add("(?i)[\W_]dvd.*")
            Master.eSettings.MovieFilterCustom.Add("(?i)[\W_]720.*")
            Master.eSettings.MovieFilterCustom.Add("(?i)[\W_]1080.*")
            Master.eSettings.MovieFilterCustom.Add("(?i)[\W_]1440.*")
            Master.eSettings.MovieFilterCustom.Add("(?i)[\W_]2160.*")
            Master.eSettings.MovieFilterCustom.Add("(?i)[\W_]4k.*")
            Master.eSettings.MovieFilterCustom.Add("(?i)[\W_]ac3.*")
            Master.eSettings.MovieFilterCustom.Add("(?i)[\W_]dts.*")
            Master.eSettings.MovieFilterCustom.Add("(?i)[\W_]divx.*")
            Master.eSettings.MovieFilterCustom.Add("(?i)[\W_]xvid.*")
            Master.eSettings.MovieFilterCustom.Add("(?i)[\W_]dc[\W_]?.*")
            Master.eSettings.MovieFilterCustom.Add("(?i)[\W_]dir(ector'?s?)?\s?cut.*")
            Master.eSettings.MovieFilterCustom.Add("(?i)[\W_]extended.*")
            Master.eSettings.MovieFilterCustom.Add("(?i)[\W_]hd(tv)?.*")
            Master.eSettings.MovieFilterCustom.Add("(?i)[\W_]unrated.*")
            Master.eSettings.MovieFilterCustom.Add("(?i)[\W_]uncut.*")
            Master.eSettings.MovieFilterCustom.Add("(?i)[\W_]german.*")
            Master.eSettings.MovieFilterCustom.Add("(?i)[\W_]([a-z]{3}|multi)[sd]ub.*")
            Master.eSettings.MovieFilterCustom.Add("(?i)[\W_]\[offline\].*")
            Master.eSettings.MovieFilterCustom.Add("(?i)[\W_]ntsc.*")
            Master.eSettings.MovieFilterCustom.Add("[\W_]PAL[\W_]?.*")
            Master.eSettings.MovieFilterCustom.Add("\.[->] ")                   'convert dots to space
            Master.eSettings.MovieFilterCustom.Add("_[->] ")                    'convert underscore to space
        End If

        If (Type = Enums.DefaultSettingType.All OrElse Type = Enums.DefaultSettingType.ShowFilters) AndAlso (Force OrElse (Master.eSettings.TVShowFilterCustom.Count <= 0 AndAlso Not Master.eSettings.TVShowFilterCustomIsEmpty)) Then
            Master.eSettings.TVShowFilterCustom.Clear()
            Master.eSettings.TVShowFilterCustom.Add("[\W_]\(?\d{4}\)?.*")
            'would there ever be season or episode info in the show folder name??
            'Master.eSettings.TVShowFilterCustom.Add("(?i)([\W_]+\s?)?s[0-9]+[\W_]*e[0-9]+(\])*")
            'Master.eSettings.TVShowFilterCustom.Add("(?i)([\W_]+\s?)?[0-9]+x[0-9]+(\])*")
            'Master.eSettings.TVShowFilterCustom.Add("(?i)([\W_]+\s?)?s(eason)?[\W_]*[0-9]+(\])*")
            'Master.eSettings.TVShowFilterCustom.Add("(?i)([\W_]+\s?)?e(pisode)?[\W_]*[0-9]+(\])*")
            Master.eSettings.TVShowFilterCustom.Add("(?i)[\W_]blu[\W_]?ray.*")
            Master.eSettings.TVShowFilterCustom.Add("(?i)[\W_]bd[\W_]?rip.*")
            Master.eSettings.TVShowFilterCustom.Add("(?i)[\W_]dvd.*")
            Master.eSettings.TVShowFilterCustom.Add("(?i)[\W_]720.*")
            Master.eSettings.TVShowFilterCustom.Add("(?i)[\W_]1080.*")
            Master.eSettings.TVShowFilterCustom.Add("(?i)[\W_]1440.*")
            Master.eSettings.TVShowFilterCustom.Add("(?i)[\W_]2160.*")
            Master.eSettings.TVShowFilterCustom.Add("(?i)[\W_]4k.*")
            Master.eSettings.TVShowFilterCustom.Add("(?i)[\W_]ac3.*")
            Master.eSettings.TVShowFilterCustom.Add("(?i)[\W_]dts.*")
            Master.eSettings.TVShowFilterCustom.Add("(?i)[\W_]divx.*")
            Master.eSettings.TVShowFilterCustom.Add("(?i)[\W_]xvid.*")
            Master.eSettings.TVShowFilterCustom.Add("(?i)[\W_]dc[\W_]?.*")
            Master.eSettings.TVShowFilterCustom.Add("(?i)[\W_]dir(ector'?s?)?\s?cut.*")
            Master.eSettings.TVShowFilterCustom.Add("(?i)[\W_]extended.*")
            Master.eSettings.TVShowFilterCustom.Add("(?i)[\W_]hd(tv)?.*")
            Master.eSettings.TVShowFilterCustom.Add("(?i)[\W_]unrated.*")
            Master.eSettings.TVShowFilterCustom.Add("(?i)[\W_]uncut.*")
            Master.eSettings.TVShowFilterCustom.Add("(?i)[\W_]([a-z]{3}|multi)[sd]ub.*")
            Master.eSettings.TVShowFilterCustom.Add("(?i)[\W_]\[offline\].*")
            Master.eSettings.TVShowFilterCustom.Add("(?i)[\W_]ntsc.*")
            Master.eSettings.TVShowFilterCustom.Add("[\W_]PAL[\W_]?.*")
            Master.eSettings.TVShowFilterCustom.Add("\.[->] ")                  'convert dots to space
            Master.eSettings.TVShowFilterCustom.Add("_[->] ")                   'convert underscore to space
        End If

        If (Type = Enums.DefaultSettingType.All OrElse Type = Enums.DefaultSettingType.EpFilters) AndAlso (Force OrElse (Master.eSettings.TVEpisodeFilterCustom.Count <= 0 AndAlso Not Master.eSettings.TVEpisodeFilterCustomIsEmpty)) Then
            Master.eSettings.TVEpisodeFilterCustom.Clear()
            Master.eSettings.TVEpisodeFilterCustom.Add("[\W_]\(?\d{4}\)?.*")
            Master.eSettings.TVEpisodeFilterCustom.Add("(?i)([\W_]+\s?)?s[0-9]+[\W_]*([-e][0-9]+)+(\])*")
            Master.eSettings.TVEpisodeFilterCustom.Add("(?i)([\W_]+\s?)?[0-9]+([-x][0-9]+)+(\])*")
            Master.eSettings.TVEpisodeFilterCustom.Add("(?i)([\W_]+\s?)?s(eason)?[\W_]*[0-9]+(\])*")
            Master.eSettings.TVEpisodeFilterCustom.Add("(?i)([\W_]+\s?)?e(pisode)?[\W_]*[0-9]+(\])*")
            Master.eSettings.TVEpisodeFilterCustom.Add("(?i)[\W_]blu[\W_]?ray.*")
            Master.eSettings.TVEpisodeFilterCustom.Add("(?i)[\W_]bd[\W_]?rip.*")
            Master.eSettings.TVEpisodeFilterCustom.Add("(?i)[\W_]dvd.*")
            Master.eSettings.TVEpisodeFilterCustom.Add("(?i)[\W_]720.*")
            Master.eSettings.TVEpisodeFilterCustom.Add("(?i)[\W_]1080.*")
            Master.eSettings.TVEpisodeFilterCustom.Add("(?i)[\W_]1440.*")
            Master.eSettings.TVEpisodeFilterCustom.Add("(?i)[\W_]2160.*")
            Master.eSettings.TVEpisodeFilterCustom.Add("(?i)[\W_]4k.*")
            Master.eSettings.TVEpisodeFilterCustom.Add("(?i)[\W_]ac3.*")
            Master.eSettings.TVEpisodeFilterCustom.Add("(?i)[\W_]dts.*")
            Master.eSettings.TVEpisodeFilterCustom.Add("(?i)[\W_]divx.*")
            Master.eSettings.TVEpisodeFilterCustom.Add("(?i)[\W_]xvid.*")
            Master.eSettings.TVEpisodeFilterCustom.Add("(?i)[\W_]dc[\W_]?.*")
            Master.eSettings.TVEpisodeFilterCustom.Add("(?i)[\W_]dir(ector'?s?)?\s?cut.*")
            Master.eSettings.TVEpisodeFilterCustom.Add("(?i)[\W_]extended.*")
            Master.eSettings.TVEpisodeFilterCustom.Add("(?i)[\W_]hd(tv)?.*")
            Master.eSettings.TVEpisodeFilterCustom.Add("(?i)[\W_]unrated.*")
            Master.eSettings.TVEpisodeFilterCustom.Add("(?i)[\W_]uncut.*")
            Master.eSettings.TVEpisodeFilterCustom.Add("(?i)[\W_]([a-z]{3}|multi)[sd]ub.*")
            Master.eSettings.TVEpisodeFilterCustom.Add("(?i)[\W_]\[offline\].*")
            Master.eSettings.TVEpisodeFilterCustom.Add("(?i)[\W_]ntsc.*")
            Master.eSettings.TVEpisodeFilterCustom.Add("[\W_]PAL[\W_]?.*")
            Master.eSettings.TVEpisodeFilterCustom.Add("\.[->] ")               'convert dots to space
            Master.eSettings.TVEpisodeFilterCustom.Add("_[->] ")                'convert underscore to space
            Master.eSettings.TVEpisodeFilterCustom.Add(" - [->] ")                'convert space-minus-space to space
        End If

        If (Type = Enums.DefaultSettingType.All OrElse Type = Enums.DefaultSettingType.MovieSortTokens) AndAlso (Force OrElse (Master.eSettings.MovieSortTokens.Count <= 0 AndAlso Not Master.eSettings.MovieSortTokensIsEmpty)) Then
            Master.eSettings.MovieSortTokens.Clear()
            Master.eSettings.MovieSortTokens.Add("the[\W_]")
            Master.eSettings.MovieSortTokens.Add("a[\W_]")
            Master.eSettings.MovieSortTokens.Add("an[\W_]")
            Master.eSettings.MovieSortTokens.Add("der[\W_]")
            Master.eSettings.MovieSortTokens.Add("die[\W_]")
            Master.eSettings.MovieSortTokens.Add("das[\W_]")
        End If

        If (Type = Enums.DefaultSettingType.All OrElse Type = Enums.DefaultSettingType.MovieSetSortTokens) AndAlso (Force OrElse (Master.eSettings.MovieSetSortTokens.Count <= 0 AndAlso Not Master.eSettings.MovieSetSortTokensIsEmpty)) Then
            Master.eSettings.MovieSetSortTokens.Clear()
            Master.eSettings.MovieSetSortTokens.Add("the[\W_]")
            Master.eSettings.MovieSetSortTokens.Add("a[\W_]")
            Master.eSettings.MovieSetSortTokens.Add("an[\W_]")
            Master.eSettings.MovieSetSortTokens.Add("der[\W_]")
            Master.eSettings.MovieSetSortTokens.Add("die[\W_]")
            Master.eSettings.MovieSetSortTokens.Add("das[\W_]")
        End If

        If (Type = Enums.DefaultSettingType.All OrElse Type = Enums.DefaultSettingType.TVSortTokens) AndAlso (Force OrElse (Master.eSettings.TVSortTokens.Count <= 0 AndAlso Not Master.eSettings.TVSortTokensIsEmpty)) Then
            Master.eSettings.TVSortTokens.Clear()
            Master.eSettings.TVSortTokens.Add("the[\W_]")
            Master.eSettings.TVSortTokens.Add("a[\W_]")
            Master.eSettings.TVSortTokens.Add("an[\W_]")
            Master.eSettings.TVSortTokens.Add("der[\W_]")
            Master.eSettings.TVSortTokens.Add("die[\W_]")
            Master.eSettings.TVSortTokens.Add("das[\W_]")
        End If

        If (Type = Enums.DefaultSettingType.All OrElse Type = Enums.DefaultSettingType.ValidExts) AndAlso (Force OrElse Master.eSettings.FileSystemValidExts.Count <= 0) Then
            Master.eSettings.FileSystemValidExts.Clear()
            Master.eSettings.FileSystemValidExts.AddRange(".avi,.divx,.mkv,.iso,.mpg,.mp4,.mpeg,.wmv,.wma,.mov,.mts,.m2t,.img,.dat,.bin,.cue,.ifo,.vob,.dvb,.evo,.asf,.asx,.avs,.nsv,.ram,.ogg,.ogm,.ogv,.flv,.swf,.nut,.viv,.rar,.m2ts,.dvr-ms,.ts,.m4v,.rmvb,.webm,.disc,.3gpp".Split(","c))
        End If

        If (Type = Enums.DefaultSettingType.All OrElse Type = Enums.DefaultSettingType.ValidSubtitleExts) AndAlso (Force OrElse Master.eSettings.FileSystemValidSubtitlesExts.Count <= 0) Then
            Master.eSettings.FileSystemValidSubtitlesExts.Clear()
            Master.eSettings.FileSystemValidSubtitlesExts.AddRange(".sst,.srt,.sub,.ssa,.aqt,.smi,.sami,.jss,.mpl,.rt,.idx,.ass".Split(","c))
        End If

        If (Type = Enums.DefaultSettingType.All OrElse Type = Enums.DefaultSettingType.ValidThemeExts) AndAlso (Force OrElse Master.eSettings.FileSystemValidThemeExts.Count <= 0) Then
            Master.eSettings.FileSystemValidThemeExts.Clear()
            Master.eSettings.FileSystemValidThemeExts.AddRange(".flac,.m4a,.mp3,.wav,.wma".Split(","c))
        End If

        If (Type = Enums.DefaultSettingType.All OrElse Type = Enums.DefaultSettingType.TVShowMatching) AndAlso (Force OrElse Master.eSettings.TVShowMatching.Count <= 0) Then
            Master.eSettings.TVShowMatching.Clear()
            Master.eSettings.TVShowMatching.Add(New regexp With {.ID = 0, .byDate = False, .defaultSeason = -1, .Regexp = "s([0-9]+)[ ._-]*e([0-9]+(?:(?:[a-i]|\.[1-9])(?![0-9]))?)([^\\\/]*)$"})
            Master.eSettings.TVShowMatching.Add(New regexp With {.ID = 1, .byDate = False, .defaultSeason = 1, .Regexp = "[\\._ -]()e(?:p[ ._-]?)?([0-9]+(?:(?:[a-i]|\.[1-9])(?![0-9]))?)([^\\\/]*)$"})
            Master.eSettings.TVShowMatching.Add(New regexp With {.ID = 2, .byDate = True, .defaultSeason = -1, .Regexp = "([0-9]{4})[.-]([0-9]{2})[.-]([0-9]{2})"})
            Master.eSettings.TVShowMatching.Add(New regexp With {.ID = 3, .byDate = True, .defaultSeason = -1, .Regexp = "([0-9]{2})[.-]([0-9]{2})[.-]([0-9]{4})"})
            Master.eSettings.TVShowMatching.Add(New regexp With {.ID = 4, .byDate = False, .defaultSeason = -1, .Regexp = "[\\\/._ \[\(-]([0-9]+)x([0-9]+(?:(?:[a-i]|\.[1-9])(?![0-9]))?)([^\\\/]*)$"})
            Master.eSettings.TVShowMatching.Add(New regexp With {.ID = 5, .byDate = False, .defaultSeason = -1, .Regexp = "[\\\/._ -]([0-9]+)([0-9][0-9](?:(?:[a-i]|\.[1-9])(?![0-9]))?)([._ -][^\\\/]*)$"})
            Master.eSettings.TVShowMatching.Add(New regexp With {.ID = 6, .byDate = False, .defaultSeason = 1, .Regexp = "[\\\/._ -]p(?:ar)?t[_. -]()([ivx]+|[0-9]+)([._ -][^\\\/]*)$"})
        End If

        If (Type = Enums.DefaultSettingType.All OrElse Type = Enums.DefaultSettingType.MovieListSorting) AndAlso (Force OrElse Master.eSettings.MovieGeneralMediaListSorting.Count <= 0) Then
            Master.eSettings.MovieGeneralMediaListSorting.Clear()
            Master.eSettings.MovieGeneralMediaListSorting.Add(New ListSorting With {.DisplayIndex = 0, .Hide = False, .Column = "ListTitle", .LabelID = 21, .LabelText = "Title"})
            Master.eSettings.MovieGeneralMediaListSorting.Add(New ListSorting With {.DisplayIndex = 1, .Hide = True, .Column = "OriginalTitle", .LabelID = 302, .LabelText = "Original Title"})
            Master.eSettings.MovieGeneralMediaListSorting.Add(New ListSorting With {.DisplayIndex = 2, .Hide = True, .Column = "Year", .LabelID = 278, .LabelText = "Year"})
            Master.eSettings.MovieGeneralMediaListSorting.Add(New ListSorting With {.DisplayIndex = 3, .Hide = True, .Column = "MPAA", .LabelID = 401, .LabelText = "MPAA"})
            Master.eSettings.MovieGeneralMediaListSorting.Add(New ListSorting With {.DisplayIndex = 4, .Hide = True, .Column = "Rating", .LabelID = 400, .LabelText = "Rating"})
            Master.eSettings.MovieGeneralMediaListSorting.Add(New ListSorting With {.DisplayIndex = 5, .Hide = True, .Column = "Top250", .LabelID = -1, .LabelText = "Top250"})
            Master.eSettings.MovieGeneralMediaListSorting.Add(New ListSorting With {.DisplayIndex = 6, .Hide = True, .Column = "Imdb", .LabelID = 61, .LabelText = "IMDB ID"})
            Master.eSettings.MovieGeneralMediaListSorting.Add(New ListSorting With {.DisplayIndex = 7, .Hide = True, .Column = "TMDB", .LabelID = 933, .LabelText = "TMDB ID"})
            Master.eSettings.MovieGeneralMediaListSorting.Add(New ListSorting With {.DisplayIndex = 8, .Hide = False, .Column = "NfoPath", .LabelID = 150, .LabelText = "NFO"})
            Master.eSettings.MovieGeneralMediaListSorting.Add(New ListSorting With {.DisplayIndex = 9, .Hide = False, .Column = "BannerPath", .LabelID = 838, .LabelText = "Banner"})
            Master.eSettings.MovieGeneralMediaListSorting.Add(New ListSorting With {.DisplayIndex = 10, .Hide = False, .Column = "ClearArtPath", .LabelID = 1096, .LabelText = "ClearArt"})
            Master.eSettings.MovieGeneralMediaListSorting.Add(New ListSorting With {.DisplayIndex = 11, .Hide = False, .Column = "ClearLogoPath", .LabelID = 1097, .LabelText = "ClearLogo"})
            Master.eSettings.MovieGeneralMediaListSorting.Add(New ListSorting With {.DisplayIndex = 12, .Hide = False, .Column = "DiscArtPath", .LabelID = 1098, .LabelText = "DiscArt"})
            Master.eSettings.MovieGeneralMediaListSorting.Add(New ListSorting With {.DisplayIndex = 13, .Hide = False, .Column = "EFanartsPath", .LabelID = 992, .LabelText = "Extrafanarts"})
            Master.eSettings.MovieGeneralMediaListSorting.Add(New ListSorting With {.DisplayIndex = 14, .Hide = False, .Column = "EThumbsPath", .LabelID = 153, .LabelText = "Extrathumbs"})
            Master.eSettings.MovieGeneralMediaListSorting.Add(New ListSorting With {.DisplayIndex = 15, .Hide = False, .Column = "FanartPath", .LabelID = 149, .LabelText = "Fanart"})
            Master.eSettings.MovieGeneralMediaListSorting.Add(New ListSorting With {.DisplayIndex = 16, .Hide = False, .Column = "LandscapePath", .LabelID = 1035, .LabelText = "Landscape"})
            Master.eSettings.MovieGeneralMediaListSorting.Add(New ListSorting With {.DisplayIndex = 17, .Hide = False, .Column = "PosterPath", .LabelID = 148, .LabelText = "Poster"})
            Master.eSettings.MovieGeneralMediaListSorting.Add(New ListSorting With {.DisplayIndex = 18, .Hide = False, .Column = "HasSub", .LabelID = 152, .LabelText = "Subtitles"})
            Master.eSettings.MovieGeneralMediaListSorting.Add(New ListSorting With {.DisplayIndex = 19, .Hide = False, .Column = "ThemePath", .LabelID = 1118, .LabelText = "Theme"})
            Master.eSettings.MovieGeneralMediaListSorting.Add(New ListSorting With {.DisplayIndex = 20, .Hide = False, .Column = "TrailerPath", .LabelID = 151, .LabelText = "Trailer"})
            Master.eSettings.MovieGeneralMediaListSorting.Add(New ListSorting With {.DisplayIndex = 21, .Hide = False, .Column = "HasSet", .LabelID = 1295, .LabelText = "Part of a MovieSet"})
            Master.eSettings.MovieGeneralMediaListSorting.Add(New ListSorting With {.DisplayIndex = 22, .Hide = False, .Column = "iLastPlayed", .LabelID = 981, .LabelText = "Watched"})
        End If

        If (Type = Enums.DefaultSettingType.All OrElse Type = Enums.DefaultSettingType.MovieSetListSorting) AndAlso (Force OrElse Master.eSettings.MovieSetGeneralMediaListSorting.Count <= 0) Then
            Master.eSettings.MovieSetGeneralMediaListSorting.Clear()
            Master.eSettings.MovieSetGeneralMediaListSorting.Add(New ListSorting With {.DisplayIndex = 0, .Hide = False, .Column = "ListTitle", .LabelID = 21, .LabelText = "Title"})
            Master.eSettings.MovieSetGeneralMediaListSorting.Add(New ListSorting With {.DisplayIndex = 1, .Hide = False, .Column = "NfoPath", .LabelID = 150, .LabelText = "NFO"})
            Master.eSettings.MovieSetGeneralMediaListSorting.Add(New ListSorting With {.DisplayIndex = 2, .Hide = False, .Column = "BannerPath", .LabelID = 838, .LabelText = "Banner"})
            Master.eSettings.MovieSetGeneralMediaListSorting.Add(New ListSorting With {.DisplayIndex = 3, .Hide = False, .Column = "ClearArtPath", .LabelID = 1096, .LabelText = "ClearArt"})
            Master.eSettings.MovieSetGeneralMediaListSorting.Add(New ListSorting With {.DisplayIndex = 4, .Hide = False, .Column = "ClearLogoPath", .LabelID = 1097, .LabelText = "ClearLogo"})
            Master.eSettings.MovieSetGeneralMediaListSorting.Add(New ListSorting With {.DisplayIndex = 5, .Hide = False, .Column = "DiscArtPath", .LabelID = 1098, .LabelText = "DiscArt"})
            Master.eSettings.MovieSetGeneralMediaListSorting.Add(New ListSorting With {.DisplayIndex = 6, .Hide = False, .Column = "FanartPath", .LabelID = 149, .LabelText = "Fanart"})
            Master.eSettings.MovieSetGeneralMediaListSorting.Add(New ListSorting With {.DisplayIndex = 7, .Hide = False, .Column = "LandscapePath", .LabelID = 1035, .LabelText = "Landscape"})
            Master.eSettings.MovieSetGeneralMediaListSorting.Add(New ListSorting With {.DisplayIndex = 8, .Hide = False, .Column = "PosterPath", .LabelID = 148, .LabelText = "Poster"})
        End If

        If (Type = Enums.DefaultSettingType.All OrElse Type = Enums.DefaultSettingType.TVEpisodeListSorting) AndAlso (Force OrElse Master.eSettings.TVGeneralEpisodeListSorting.Count <= 0) Then
            Master.eSettings.TVGeneralEpisodeListSorting.Clear()
            Master.eSettings.TVGeneralEpisodeListSorting.Add(New ListSorting With {.DisplayIndex = 0, .Hide = False, .Column = "Title", .LabelID = 21, .LabelText = "Title"})
            Master.eSettings.TVGeneralEpisodeListSorting.Add(New ListSorting With {.DisplayIndex = 1, .Hide = False, .Column = "NfoPath", .LabelID = 150, .LabelText = "NFO"})
            Master.eSettings.TVGeneralEpisodeListSorting.Add(New ListSorting With {.DisplayIndex = 2, .Hide = True, .Column = "FanartPath", .LabelID = 149, .LabelText = "Fanart"})
            Master.eSettings.TVGeneralEpisodeListSorting.Add(New ListSorting With {.DisplayIndex = 3, .Hide = False, .Column = "PosterPath", .LabelID = 148, .LabelText = "Poster"})
            Master.eSettings.TVGeneralEpisodeListSorting.Add(New ListSorting With {.DisplayIndex = 4, .Hide = False, .Column = "HasSub", .LabelID = 152, .LabelText = "Subtitles"})
            Master.eSettings.TVGeneralEpisodeListSorting.Add(New ListSorting With {.DisplayIndex = 5, .Hide = False, .Column = "Playcount", .LabelID = 981, .LabelText = "Watched"})
        End If

        If (Type = Enums.DefaultSettingType.All OrElse Type = Enums.DefaultSettingType.TVSeasonListSorting) AndAlso (Force OrElse Master.eSettings.TVGeneralSeasonListSorting.Count <= 0) Then
            Master.eSettings.TVGeneralSeasonListSorting.Clear()
            Master.eSettings.TVGeneralSeasonListSorting.Add(New ListSorting With {.DisplayIndex = 0, .Hide = False, .Column = "SeasonText", .LabelID = 650, .LabelText = "Season"})
            Master.eSettings.TVGeneralSeasonListSorting.Add(New ListSorting With {.DisplayIndex = 1, .Hide = True, .Column = "Episodes", .LabelID = 682, .LabelText = "Episodes"})
            Master.eSettings.TVGeneralSeasonListSorting.Add(New ListSorting With {.DisplayIndex = 2, .Hide = False, .Column = "BannerPath", .LabelID = 838, .LabelText = "Banner"})
            Master.eSettings.TVGeneralSeasonListSorting.Add(New ListSorting With {.DisplayIndex = 3, .Hide = False, .Column = "FanartPath", .LabelID = 149, .LabelText = "Fanart"})
            Master.eSettings.TVGeneralSeasonListSorting.Add(New ListSorting With {.DisplayIndex = 4, .Hide = False, .Column = "LandscapePath", .LabelID = 1035, .LabelText = "Landscape"})
            Master.eSettings.TVGeneralSeasonListSorting.Add(New ListSorting With {.DisplayIndex = 5, .Hide = False, .Column = "PosterPath", .LabelID = 148, .LabelText = "Poster"})
            Master.eSettings.TVGeneralSeasonListSorting.Add(New ListSorting With {.DisplayIndex = 6, .Hide = False, .Column = "HasWatched", .LabelID = 981, .LabelText = "Watched"})
        End If

        If (Type = Enums.DefaultSettingType.All OrElse Type = Enums.DefaultSettingType.TVShowListSorting) AndAlso (Force OrElse Master.eSettings.TVGeneralShowListSorting.Count <= 0) Then
            Master.eSettings.TVGeneralShowListSorting.Clear()
            Master.eSettings.TVGeneralShowListSorting.Add(New ListSorting With {.DisplayIndex = 0, .Hide = False, .Column = "ListTitle", .LabelID = 21, .LabelText = "Title"})
            Master.eSettings.TVGeneralShowListSorting.Add(New ListSorting With {.DisplayIndex = 1, .Hide = True, .Column = "strOriginalTitle", .LabelID = 302, .LabelText = "Original Title"})
            Master.eSettings.TVGeneralShowListSorting.Add(New ListSorting With {.DisplayIndex = 2, .Hide = True, .Column = "Status", .LabelID = 215, .LabelText = "Status"})
            Master.eSettings.TVGeneralShowListSorting.Add(New ListSorting With {.DisplayIndex = 3, .Hide = True, .Column = "Episodes", .LabelID = 682, .LabelText = "Episodes"})
            Master.eSettings.TVGeneralShowListSorting.Add(New ListSorting With {.DisplayIndex = 4, .Hide = False, .Column = "NfoPath", .LabelID = 150, .LabelText = "NFO"})
            Master.eSettings.TVGeneralShowListSorting.Add(New ListSorting With {.DisplayIndex = 5, .Hide = False, .Column = "BannerPath", .LabelID = 838, .LabelText = "Banner"})
            Master.eSettings.TVGeneralShowListSorting.Add(New ListSorting With {.DisplayIndex = 6, .Hide = False, .Column = "CharacterArtPath", .LabelID = 1140, .LabelText = "CharacterArt"})
            Master.eSettings.TVGeneralShowListSorting.Add(New ListSorting With {.DisplayIndex = 7, .Hide = False, .Column = "ClearArtPath", .LabelID = 1096, .LabelText = "ClearArt"})
            Master.eSettings.TVGeneralShowListSorting.Add(New ListSorting With {.DisplayIndex = 8, .Hide = False, .Column = "ClearLogoPath", .LabelID = 1097, .LabelText = "ClearLogo"})
            Master.eSettings.TVGeneralShowListSorting.Add(New ListSorting With {.DisplayIndex = 9, .Hide = False, .Column = "EFanartsPath", .LabelID = 992, .LabelText = "Extrafanarts"})
            Master.eSettings.TVGeneralShowListSorting.Add(New ListSorting With {.DisplayIndex = 10, .Hide = False, .Column = "FanartPath", .LabelID = 149, .LabelText = "Fanart"})
            Master.eSettings.TVGeneralShowListSorting.Add(New ListSorting With {.DisplayIndex = 11, .Hide = False, .Column = "LandscapePath", .LabelID = 1035, .LabelText = "Landscape"})
            Master.eSettings.TVGeneralShowListSorting.Add(New ListSorting With {.DisplayIndex = 12, .Hide = False, .Column = "PosterPath", .LabelID = 148, .LabelText = "Poster"})
            Master.eSettings.TVGeneralShowListSorting.Add(New ListSorting With {.DisplayIndex = 13, .Hide = False, .Column = "ThemePath", .LabelID = 1118, .LabelText = "Theme"})
            Master.eSettings.TVGeneralShowListSorting.Add(New ListSorting With {.DisplayIndex = 14, .Hide = False, .Column = "HasWatched", .LabelID = 981, .LabelText = "Watched"})
        End If
    End Sub

    Public Function GetMovieSetsArtworkPaths() As List(Of String)
        Dim Paths As New List(Of String)
        If Not String.IsNullOrEmpty(MovieSetPathExpertSingle) Then Paths.Add(MovieSetPathExpertSingle)
        If Not String.IsNullOrEmpty(MovieSetPathExtended) Then Paths.Add(MovieSetPathExtended)
        If Not String.IsNullOrEmpty(MovieSetPathMSAA) Then Paths.Add(MovieSetPathMSAA)
        Paths = Paths.Distinct().ToList() 'remove double entries
        Return Paths
    End Function

    Public Function FilenameAnyEnabled(ByVal tContentType As Enums.ContentType, ByVal tImageType As Enums.ScrapeModifierType) As Boolean
        Dim bResult As Boolean
        Select Case tContentType
            Case Enums.ContentType.Movie
                Select Case tImageType
                    Case Enums.ScrapeModifierType.MainActorThumbs
                        Return FilenameAnyEnabled_Movie_Actorthumbs()
                    Case Enums.ScrapeModifierType.MainBanner
                        Return FilenameAnyEnabled_Movie_Banner()
                    Case Enums.ScrapeModifierType.MainClearArt
                        Return FilenameAnyEnabled_Movie_ClearArt()
                    Case Enums.ScrapeModifierType.MainClearLogo
                        Return FilenameAnyEnabled_Movie_ClearLogo()
                    Case Enums.ScrapeModifierType.MainDiscArt
                        Return FilenameAnyEnabled_Movie_DiscArt()
                    Case Enums.ScrapeModifierType.MainExtrafanarts
                        Return FilenameAnyEnabled_Movie_Extrafanarts()
                    Case Enums.ScrapeModifierType.MainExtrathumbs
                        Return FilenameAnyEnabled_Movie_Extrathumbs()
                    Case Enums.ScrapeModifierType.MainFanart
                        Return FilenameAnyEnabled_Movie_Fanart()
                    Case Enums.ScrapeModifierType.MainLandscape
                        Return FilenameAnyEnabled_Movie_Landscape()
                    Case Enums.ScrapeModifierType.MainNFO
                        Return FilenameAnyEnabled_Movie_NFO()
                    Case Enums.ScrapeModifierType.MainPoster
                        Return FilenameAnyEnabled_Movie_Poster()
                    Case Enums.ScrapeModifierType.MainTheme
                        Return FilenameAnyEnabled_Movie_Theme()
                    Case Enums.ScrapeModifierType.MainTrailer
                        Return FilenameAnyEnabled_Movie_Trailer()
                End Select
            Case Enums.ContentType.MovieSet
                Select Case tImageType
                    Case Enums.ScrapeModifierType.MainBanner
                        Return FilenameAnyEnabled_MovieSet_Banner()
                    Case Enums.ScrapeModifierType.MainClearArt
                        Return FilenameAnyEnabled_MovieSet_ClearArt()
                    Case Enums.ScrapeModifierType.MainClearLogo
                        Return FilenameAnyEnabled_MovieSet_ClearLogo()
                    Case Enums.ScrapeModifierType.MainDiscArt
                        Return FilenameAnyEnabled_MovieSet_DiscArt()
                    Case Enums.ScrapeModifierType.MainFanart
                        Return FilenameAnyEnabled_MovieSet_Fanart()
                    Case Enums.ScrapeModifierType.MainLandscape
                        Return FilenameAnyEnabled_MovieSet_Landscape()
                    Case Enums.ScrapeModifierType.MainNFO
                        Return FilenameAnyEnabled_MovieSet_NFO()
                    Case Enums.ScrapeModifierType.MainPoster
                        Return FilenameAnyEnabled_MovieSet_Poster()
                End Select
            Case Enums.ContentType.TVEpisode
                Select Case tImageType
                    Case Enums.ScrapeModifierType.EpisodeActorThumbs
                        Return FilenameAnyEnabled_TVEpisode_ActorThumbs()
                    Case Enums.ScrapeModifierType.EpisodeFanart
                        Return FilenameAnyEnabled_TVEpisode_Fanart()
                    Case Enums.ScrapeModifierType.EpisodeNFO
                        Return FilenameAnyEnabled_TVEpisode_NFO()
                    Case Enums.ScrapeModifierType.EpisodePoster
                        Return FilenameAnyEnabled_TVEpisode_Poster()
                End Select
            Case Enums.ContentType.TVSeason
                Select Case tImageType
                    Case Enums.ScrapeModifierType.AllSeasonsBanner
                        Return FilenameAnyEnabled_TVAllSeasons_Banner()
                    Case Enums.ScrapeModifierType.AllSeasonsFanart
                        Return FilenameAnyEnabled_TVAllSeasons_Fanart()
                    Case Enums.ScrapeModifierType.AllSeasonsLandscape
                        Return FilenameAnyEnabled_TVAllSeasons_Landscape()
                    Case Enums.ScrapeModifierType.AllSeasonsPoster
                        Return FilenameAnyEnabled_TVAllSeasons_Poster()
                    Case Enums.ScrapeModifierType.SeasonBanner
                        Return FilenameAnyEnabled_TVSeason_Banner()
                    Case Enums.ScrapeModifierType.SeasonFanart
                        Return FilenameAnyEnabled_TVSeason_Fanart()
                    Case Enums.ScrapeModifierType.SeasonLandscape
                        Return FilenameAnyEnabled_TVSeason_Landscape()
                    Case Enums.ScrapeModifierType.SeasonPoster
                        Return FilenameAnyEnabled_TVSeason_Poster()
                End Select
            Case Enums.ContentType.TVShow
                Select Case tImageType
                    Case Enums.ScrapeModifierType.MainActorThumbs
                        Return FilenameAnyEnabled_TVShow_ActorTumbs()
                    Case Enums.ScrapeModifierType.MainBanner
                        Return FilenameAnyEnabled_TVShow_Banner()
                    Case Enums.ScrapeModifierType.MainCharacterArt
                        Return FilenameAnyEnabled_TVShow_CharacterArt()
                    Case Enums.ScrapeModifierType.MainClearArt
                        Return FilenameAnyEnabled_TVShow_ClearArt()
                    Case Enums.ScrapeModifierType.MainClearLogo
                        Return FilenameAnyEnabled_TVShow_ClearLogo()
                    Case Enums.ScrapeModifierType.MainExtrafanarts
                        Return FilenameAnyEnabled_TVShow_Extrafanarts()
                    Case Enums.ScrapeModifierType.MainFanart
                        Return FilenameAnyEnabled_TVShow_Fanart()
                    Case Enums.ScrapeModifierType.MainLandscape
                        Return FilenameAnyEnabled_TVShow_Landscape()
                    Case Enums.ScrapeModifierType.MainNFO
                        Return FilenameAnyEnabled_TVShow_NFO()
                    Case Enums.ScrapeModifierType.MainPoster
                        Return FilenameAnyEnabled_TVShow_Poster()
                    Case Enums.ScrapeModifierType.MainTheme
                        Return FilenameAnyEnabled_TVShow_Theme()
                End Select
        End Select
        Return bResult
    End Function

    Public Function FilenameAnyEnabled_Movie_Actorthumbs() As Boolean
        Return MovieActorThumbsEden OrElse MovieActorThumbsFrodo OrElse
            (MovieUseExpert AndAlso ((MovieActorThumbsExpertBDMV AndAlso Not String.IsNullOrEmpty(MovieActorThumbsExtExpertBDMV)) OrElse (MovieActorThumbsExpertMulti AndAlso Not String.IsNullOrEmpty(MovieActorThumbsExtExpertMulti)) OrElse (MovieActorThumbsExpertSingle AndAlso Not String.IsNullOrEmpty(MovieActorThumbsExtExpertSingle)) OrElse (MovieActorThumbsExpertVTS AndAlso Not String.IsNullOrEmpty(MovieActorThumbsExtExpertVTS))))
    End Function

    Public Function FilenameAnyEnabled_Movie_Banner() As Boolean
        Return MovieBannerAD OrElse MovieBannerExtended OrElse MovieBannerNMJ OrElse MovieBannerYAMJ OrElse
            (MovieUseExpert AndAlso (Not String.IsNullOrEmpty(MovieBannerExpertBDMV) OrElse Not String.IsNullOrEmpty(MovieBannerExpertMulti) OrElse Not String.IsNullOrEmpty(MovieBannerExpertSingle) OrElse Not String.IsNullOrEmpty(MovieBannerExpertVTS)))
    End Function

    Public Function FilenameAnyEnabled_Movie_ClearArt() As Boolean
        Return MovieClearArtAD OrElse MovieClearArtExtended OrElse
            (MovieUseExpert AndAlso (Not String.IsNullOrEmpty(MovieClearArtExpertBDMV) OrElse Not String.IsNullOrEmpty(MovieClearArtExpertMulti) OrElse Not String.IsNullOrEmpty(MovieClearArtExpertSingle) OrElse Not String.IsNullOrEmpty(MovieClearArtExpertVTS)))
    End Function

    Public Function FilenameAnyEnabled_Movie_ClearLogo() As Boolean
        Return MovieClearLogoAD OrElse MovieClearLogoExtended OrElse
            (MovieUseExpert AndAlso (Not String.IsNullOrEmpty(MovieClearLogoExpertBDMV) OrElse Not String.IsNullOrEmpty(MovieClearLogoExpertMulti) OrElse Not String.IsNullOrEmpty(MovieClearLogoExpertSingle) OrElse Not String.IsNullOrEmpty(MovieClearLogoExpertVTS)))
    End Function

    Public Function FilenameAnyEnabled_Movie_DiscArt() As Boolean
        Return MovieDiscArtAD OrElse MovieDiscArtExtended OrElse
            (MovieUseExpert AndAlso (Not String.IsNullOrEmpty(MovieDiscArtExpertBDMV) OrElse Not String.IsNullOrEmpty(MovieDiscArtExpertMulti) OrElse Not String.IsNullOrEmpty(MovieDiscArtExpertSingle) OrElse Not String.IsNullOrEmpty(MovieDiscArtExpertVTS)))
    End Function

    Public Function FilenameAnyEnabled_Movie_Extrafanarts() As Boolean
        Return MovieExtrafanartsEden OrElse MovieExtrafanartsFrodo OrElse
            (MovieUseExpert AndAlso (MovieExtrafanartsExpertBDMV OrElse MovieExtrafanartsExpertSingle OrElse MovieExtrafanartsExpertVTS))
    End Function

    Public Function FilenameAnyEnabled_Movie_Extrathumbs() As Boolean
        Return MovieExtrathumbsEden OrElse MovieExtrathumbsFrodo OrElse
            (MovieUseExpert AndAlso (MovieExtrathumbsExpertBDMV OrElse MovieExtrathumbsExpertSingle OrElse MovieExtrathumbsExpertVTS))
    End Function

    Public Function FilenameAnyEnabled_Movie_Fanart() As Boolean
        Return MovieFanartBoxee OrElse MovieFanartEden OrElse MovieFanartFrodo OrElse MovieFanartNMJ OrElse MovieFanartYAMJ OrElse
            (MovieUseExpert AndAlso (Not String.IsNullOrEmpty(MovieFanartExpertBDMV) OrElse Not String.IsNullOrEmpty(MovieFanartExpertMulti) OrElse Not String.IsNullOrEmpty(MovieFanartExpertSingle) OrElse Not String.IsNullOrEmpty(MovieFanartExpertVTS)))
    End Function

    Public Function FilenameAnyEnabled_Movie_Landscape() As Boolean
        Return MovieLandscapeAD OrElse MovieLandscapeExtended OrElse
            (MovieUseExpert AndAlso (Not String.IsNullOrEmpty(MovieLandscapeExpertBDMV) OrElse Not String.IsNullOrEmpty(MovieLandscapeExpertMulti) OrElse Not String.IsNullOrEmpty(MovieLandscapeExpertSingle) OrElse Not String.IsNullOrEmpty(MovieLandscapeExpertVTS)))
    End Function

    Public Function FilenameAnyEnabled_Movie_NFO() As Boolean
        Return MovieNFOBoxee OrElse MovieNFOEden OrElse MovieNFOFrodo OrElse MovieNFONMJ OrElse MovieNFOYAMJ OrElse
            (MovieUseExpert AndAlso (Not String.IsNullOrEmpty(MovieNFOExpertBDMV) OrElse Not String.IsNullOrEmpty(MovieNFOExpertMulti) OrElse Not String.IsNullOrEmpty(MovieNFOExpertSingle) OrElse Not String.IsNullOrEmpty(MovieNFOExpertVTS)))
    End Function

    Public Function FilenameAnyEnabled_Movie_Poster() As Boolean
        Return MoviePosterBoxee OrElse MoviePosterEden OrElse MoviePosterFrodo OrElse MoviePosterNMJ OrElse MoviePosterYAMJ OrElse
            (MovieUseExpert AndAlso (Not String.IsNullOrEmpty(MoviePosterExpertBDMV) OrElse Not String.IsNullOrEmpty(MoviePosterExpertMulti) OrElse Not String.IsNullOrEmpty(MoviePosterExpertSingle) OrElse Not String.IsNullOrEmpty(MoviePosterExpertVTS)))
    End Function

    Public Function FilenameAnyEnabled_Movie_Theme() As Boolean
        Return MovieThemeTvTunesEnable AndAlso (MovieThemeTvTunesMoviePath OrElse (MovieThemeTvTunesCustom AndAlso Not String.IsNullOrEmpty(MovieThemeTvTunesCustomPath) OrElse (MovieThemeTvTunesSub AndAlso Not String.IsNullOrEmpty(MovieThemeTvTunesSubDir))))
    End Function

    Public Function FilenameAnyEnabled_Movie_Trailer() As Boolean
        Return MovieTrailerEden OrElse MovieTrailerFrodo OrElse MovieTrailerNMJ OrElse MovieTrailerYAMJ OrElse
            (MovieUseExpert AndAlso (Not String.IsNullOrEmpty(MovieTrailerExpertBDMV) OrElse Not String.IsNullOrEmpty(MovieTrailerExpertMulti) OrElse Not String.IsNullOrEmpty(MovieTrailerExpertSingle) OrElse Not String.IsNullOrEmpty(MovieTrailerExpertVTS)))
    End Function

    Public Function FilenameAnyEnabled_MovieSet_Banner() As Boolean
        Return (MovieSetBannerExtended AndAlso Not String.IsNullOrEmpty(MovieSetPathExtended)) OrElse
            (MovieSetBannerMSAA AndAlso Not String.IsNullOrEmpty(MovieSetPathMSAA)) OrElse
            (MovieSetUseExpert AndAlso (Not String.IsNullOrEmpty(MovieSetPosterExpertParent) OrElse (Not String.IsNullOrEmpty(MovieSetPathExpertSingle) AndAlso Not String.IsNullOrEmpty(MovieSetPosterExpertSingle))))
    End Function

    Public Function FilenameAnyEnabled_MovieSet_ClearArt() As Boolean
        Return (MovieSetClearArtExtended AndAlso Not String.IsNullOrEmpty(MovieSetPathExtended)) OrElse
            (MovieSetClearArtMSAA AndAlso Not String.IsNullOrEmpty(MovieSetPathMSAA)) OrElse
            (MovieSetUseExpert AndAlso (Not String.IsNullOrEmpty(MovieSetClearArtExpertParent) OrElse (Not String.IsNullOrEmpty(MovieSetPathExpertSingle) AndAlso Not String.IsNullOrEmpty(MovieSetClearArtExpertSingle))))
    End Function

    Public Function FilenameAnyEnabled_MovieSet_ClearLogo() As Boolean
        Return (MovieSetClearLogoExtended AndAlso Not String.IsNullOrEmpty(MovieSetPathExtended)) OrElse
            (MovieSetClearLogoMSAA AndAlso Not String.IsNullOrEmpty(MovieSetPathMSAA)) OrElse
            (MovieSetUseExpert AndAlso (Not String.IsNullOrEmpty(MovieSetClearLogoExpertParent) OrElse (Not String.IsNullOrEmpty(MovieSetPathExpertSingle) AndAlso Not String.IsNullOrEmpty(MovieSetClearLogoExpertSingle))))
    End Function

    Public Function FilenameAnyEnabled_MovieSet_DiscArt() As Boolean
        Return (MovieSetDiscArtExtended AndAlso Not String.IsNullOrEmpty(MovieSetPathExtended)) OrElse
            (MovieSetUseExpert AndAlso (Not String.IsNullOrEmpty(MovieSetDiscArtExpertParent) OrElse (Not String.IsNullOrEmpty(MovieSetPathExpertSingle) AndAlso Not String.IsNullOrEmpty(MovieSetDiscArtExpertSingle))))
    End Function

    Public Function FilenameAnyEnabled_MovieSet_Fanart() As Boolean
        Return (MovieSetFanartExtended AndAlso Not String.IsNullOrEmpty(MovieSetPathExtended)) OrElse
            (MovieSetFanartMSAA AndAlso Not String.IsNullOrEmpty(MovieSetPathMSAA)) OrElse
            (MovieSetUseExpert AndAlso (Not String.IsNullOrEmpty(MovieSetFanartExpertParent) OrElse (Not String.IsNullOrEmpty(MovieSetPathExpertSingle) AndAlso Not String.IsNullOrEmpty(MovieSetFanartExpertSingle))))
    End Function

    Public Function FilenameAnyEnabled_MovieSet_Landscape() As Boolean
        Return (MovieSetLandscapeExtended AndAlso Not String.IsNullOrEmpty(MovieSetPathExtended)) OrElse
            (MovieSetLandscapeMSAA AndAlso Not String.IsNullOrEmpty(MovieSetPathMSAA)) OrElse
            (MovieSetUseExpert AndAlso (Not String.IsNullOrEmpty(MovieSetLandscapeExpertParent) OrElse (Not String.IsNullOrEmpty(MovieSetPathExpertSingle) AndAlso Not String.IsNullOrEmpty(MovieSetLandscapeExpertSingle))))
    End Function

    Public Function FilenameAnyEnabled_MovieSet_NFO() As Boolean
        Return (MovieSetUseExpert AndAlso (Not String.IsNullOrEmpty(MovieSetNFOExpertParent) OrElse (Not String.IsNullOrEmpty(MovieSetPathExpertSingle) AndAlso Not String.IsNullOrEmpty(MovieSetNFOExpertSingle))))
    End Function

    Public Function FilenameAnyEnabled_MovieSet_Poster() As Boolean
        Return (MovieSetPosterExtended AndAlso Not String.IsNullOrEmpty(MovieSetPathExtended)) OrElse
            (MovieSetPosterMSAA AndAlso Not String.IsNullOrEmpty(MovieSetPathMSAA)) OrElse
            (MovieSetUseExpert AndAlso (Not String.IsNullOrEmpty(MovieSetPosterExpertParent) OrElse (Not String.IsNullOrEmpty(MovieSetPathExpertSingle) AndAlso Not String.IsNullOrEmpty(MovieSetPosterExpertSingle))))
    End Function

    Public Function FilenameAnyEnabled_TVAllSeasons_Banner() As Boolean
        Return TVSeasonBannerFrodo OrElse
            (TVUseExpert AndAlso Not String.IsNullOrEmpty(TVAllSeasonsBannerExpert))
    End Function

    Public Function FilenameAnyEnabled_TVAllSeasons_Fanart() As Boolean
        Return TVSeasonFanartFrodo OrElse
            (TVUseExpert AndAlso Not String.IsNullOrEmpty(TVAllSeasonsFanartExpert))
    End Function

    Public Function FilenameAnyEnabled_TVAllSeasons_Landscape() As Boolean
        Return TVSeasonLandscapeAD OrElse TVSeasonLandscapeExtended OrElse
            (TVUseExpert AndAlso Not String.IsNullOrEmpty(TVAllSeasonsLandscapeExpert))
    End Function

    Public Function FilenameAnyEnabled_TVAllSeasons_Poster() As Boolean
        Return TVSeasonPosterFrodo OrElse
            (TVUseExpert AndAlso Not String.IsNullOrEmpty(TVAllSeasonsPosterExpert))
    End Function

    Public Function FilenameAnyEnabled_TVEpisode_ActorThumbs() As Boolean
        Return TVEpisodeActorThumbsFrodo OrElse
            (TVUseExpert AndAlso TVEpisodeActorThumbsExpert AndAlso Not String.IsNullOrEmpty(TVEpisodeActorThumbsExtExpert))
    End Function

    Public Function FilenameAnyEnabled_TVEpisode_Fanart() As Boolean
        Return (TVUseExpert AndAlso Not String.IsNullOrEmpty(TVEpisodeFanartExpert))
    End Function

    Public Function FilenameAnyEnabled_TVEpisode_NFO() As Boolean
        Return TVEpisodeNFOBoxee OrElse TVEpisodeNFOFrodo OrElse TVEpisodeNFOYAMJ OrElse
            (TVUseExpert AndAlso Not String.IsNullOrEmpty(TVEpisodeNFOExpert))
    End Function

    Public Function FilenameAnyEnabled_TVEpisode_Poster() As Boolean
        Return TVEpisodePosterBoxee OrElse TVEpisodePosterFrodo OrElse TVEpisodePosterYAMJ OrElse
            (TVUseExpert AndAlso Not String.IsNullOrEmpty(TVEpisodePosterExpert))
    End Function

    Public Function FilenameAnyEnabled_TVSeason_Banner() As Boolean
        Return TVSeasonBannerFrodo OrElse TVSeasonBannerYAMJ OrElse
            (TVUseExpert AndAlso Not String.IsNullOrEmpty(TVSeasonBannerExpert))
    End Function

    Public Function FilenameAnyEnabled_TVSeason_Fanart() As Boolean
        Return TVSeasonFanartFrodo OrElse TVSeasonFanartYAMJ OrElse
            (TVUseExpert AndAlso Not String.IsNullOrEmpty(TVSeasonFanartExpert))
    End Function

    Public Function FilenameAnyEnabled_TVSeason_Landscape() As Boolean
        Return TVSeasonLandscapeAD OrElse TVSeasonLandscapeExtended OrElse
            (TVUseExpert AndAlso Not String.IsNullOrEmpty(TVSeasonLandscapeExpert))
    End Function

    Public Function FilenameAnyEnabled_TVSeason_Poster() As Boolean
        Return TVSeasonPosterBoxee OrElse TVSeasonPosterFrodo OrElse TVSeasonPosterYAMJ OrElse
            (TVUseExpert AndAlso Not String.IsNullOrEmpty(TVSeasonPosterExpert))
    End Function

    Public Function FilenameAnyEnabled_TVShow_ActorTumbs() As Boolean
        Return TVShowActorThumbsFrodo OrElse
            (TVUseExpert AndAlso TVShowActorThumbsExpert AndAlso Not String.IsNullOrEmpty(TVShowActorThumbsExtExpert))
    End Function

    Public Function FilenameAnyEnabled_TVShow_Banner() As Boolean
        Return TVShowBannerBoxee OrElse TVShowBannerFrodo OrElse TVShowBannerYAMJ OrElse
            (TVUseExpert AndAlso Not String.IsNullOrEmpty(TVShowBannerExpert))
    End Function

    Public Function FilenameAnyEnabled_TVShow_CharacterArt() As Boolean
        Return TVShowCharacterArtAD OrElse TVShowCharacterArtExtended OrElse
            (TVUseExpert AndAlso Not String.IsNullOrEmpty(TVShowCharacterArtExpert))
    End Function

    Public Function FilenameAnyEnabled_TVShow_ClearArt() As Boolean
        Return TVShowClearArtAD OrElse TVShowClearArtExtended OrElse
            (TVUseExpert AndAlso Not String.IsNullOrEmpty(TVShowClearArtExpert))
    End Function

    Public Function FilenameAnyEnabled_TVShow_ClearLogo() As Boolean
        Return TVShowClearLogoAD OrElse TVShowClearLogoExtended OrElse
            (TVUseExpert AndAlso Not String.IsNullOrEmpty(TVShowClearLogoExpert))
    End Function

    Public Function FilenameAnyEnabled_TVShow_Extrafanarts() As Boolean
        Return TVShowExtrafanartsFrodo OrElse
            (TVUseExpert AndAlso TVShowExtrafanartsExpert)
    End Function

    Public Function FilenameAnyEnabled_TVShow_Fanart() As Boolean
        Return TVShowFanartBoxee OrElse TVShowFanartFrodo OrElse TVShowFanartYAMJ OrElse
            (TVUseExpert AndAlso Not String.IsNullOrEmpty(TVShowFanartExpert))
    End Function

    Public Function FilenameAnyEnabled_TVShow_Landscape() As Boolean
        Return TVShowLandscapeAD OrElse TVShowLandscapeExtended OrElse
            (TVUseExpert AndAlso Not String.IsNullOrEmpty(TVShowLandscapeExpert))
    End Function

    Public Function FilenameAnyEnabled_TVShow_NFO() As Boolean
        Return TVShowNFOBoxee OrElse TVShowNFOFrodo OrElse TVShowNFOYAMJ OrElse
            (TVUseExpert AndAlso Not String.IsNullOrEmpty(TVShowNFOExpert))
    End Function

    Public Function FilenameAnyEnabled_TVShow_Poster() As Boolean
        Return TVShowPosterBoxee OrElse TVShowPosterFrodo OrElse TVShowPosterYAMJ OrElse
            (TVUseExpert AndAlso Not String.IsNullOrEmpty(TVShowPosterExpert))
    End Function

    Public Function FilenameAnyEnabled_TVShow_Theme() As Boolean
        Return TVShowThemeTvTunesEnable AndAlso (TVShowThemeTvTunesShowPath OrElse (TVShowThemeTvTunesCustom AndAlso Not String.IsNullOrEmpty(TVShowThemeTvTunesCustomPath) OrElse (TVShowThemeTvTunesSub AndAlso Not String.IsNullOrEmpty(TVShowThemeTvTunesSubDir))))
    End Function

    Public Function MissingItemsAnyEnabled_Movie() As Boolean
        Return MovieMissingBanner OrElse MovieMissingClearArt OrElse MovieMissingClearLogo OrElse MovieMissingDiscArt OrElse MovieMissingExtrafanarts OrElse
            MovieMissingExtrathumbs OrElse MovieMissingFanart OrElse MovieMissingLandscape OrElse MovieMissingNFO OrElse MovieMissingPoster OrElse
            MovieMissingSubtitles OrElse MovieMissingTheme OrElse MovieMissingTrailer
    End Function

    Public Function MissingItemsAnyEnabled_MovieSet() As Boolean
        Return MovieSetMissingBanner OrElse MovieSetMissingClearArt OrElse MovieSetMissingClearLogo OrElse MovieSetMissingDiscArt OrElse
            MovieSetMissingFanart OrElse MovieSetMissingLandscape OrElse MovieSetMissingNFO OrElse MovieSetMissingPoster
    End Function

    Public Function MissingItemsAnyEnabled_TVEpisode() As Boolean
        Return TVEpisodeMissingFanart OrElse TVEpisodeMissingNFO OrElse TVEpisodeMissingPoster
    End Function

    Public Function MissingItemsAnyEnabled_TVSeason() As Boolean
        Return TVSeasonMissingBanner OrElse TVSeasonMissingFanart OrElse TVSeasonMissingLandscape OrElse TVSeasonMissingPoster
    End Function

    Public Function MissingItemsAnyEnabled_TVShow() As Boolean
        Return TVShowMissingBanner OrElse TVShowMissingCharacterArt OrElse TVShowMissingClearArt OrElse TVShowMissingClearLogo OrElse
            TVShowMissingExtrafanarts OrElse TVShowMissingFanart OrElse TVShowMissingLandscape OrElse TVShowMissingNFO OrElse
            TVShowMissingPoster OrElse TVShowMissingTheme
    End Function

#End Region 'Methods

#Region "Nested Types"

    Public Class MetadataPerType

#Region "Fields"

        Private _filetype As String
        Private _metadata As MediaContainers.Fileinfo

#End Region 'Fields

#Region "Constructors"

        Public Sub New()
            Clear()
        End Sub

#End Region 'Constructors

#Region "Properties"

        Public Property FileType() As String
            Get
                Return _filetype
            End Get
            Set(ByVal value As String)
                _filetype = value
            End Set
        End Property

        Public Property MetaData() As MediaContainers.Fileinfo
            Get
                Return _metadata
            End Get
            Set(ByVal value As MediaContainers.Fileinfo)
                _metadata = value
            End Set
        End Property

#End Region 'Properties

#Region "Methods"

        Public Sub Clear()
            _filetype = String.Empty
            _metadata = New MediaContainers.Fileinfo
        End Sub

#End Region 'Methods

    End Class

    Public Class ListSorting

#Region "Fields"

        Private _column As String
        Private _displayindex As Integer
        Private _hide As Boolean
        Private _labelid As Integer
        Private _labeltext As String

#End Region 'Fields

#Region "Constructors"

        Public Sub New()
            Clear()
        End Sub

#End Region 'Constructors

#Region "Properties"
        ''' <summary>
        ''' Column name in database (need to be exactly like column name in DB)
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property Column() As String
            Get
                Return _column
            End Get
            Set(ByVal value As String)
                _column = value
            End Set
        End Property

        Public Property DisplayIndex() As Integer
            Get
                Return _displayindex
            End Get
            Set(ByVal value As Integer)
                _displayindex = value
            End Set
        End Property
        ''' <summary>
        ''' Hide or show column in media lists
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property Hide() As Boolean
            Get
                Return _hide
            End Get
            Set(ByVal value As Boolean)
                _hide = value
            End Set
        End Property
        ''' <summary>
        ''' ID of string in Master.eLangs.GetString
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property LabelID() As Integer
            Get
                Return _labelid
            End Get
            Set(ByVal value As Integer)
                _labelid = value
            End Set
        End Property
        ''' <summary>
        ''' Default text for the LabelID in Master.eLangs.GetString
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property LabelText() As String
            Get
                Return _labeltext
            End Get
            Set(ByVal value As String)
                _labeltext = value
            End Set
        End Property

#End Region 'Properties

#Region "Methods"

        Public Sub Clear()
            _column = String.Empty
            _displayindex = -1
            _hide = False
            _labelid = 1
            _labeltext = String.Empty
        End Sub

#End Region 'Methods

    End Class

    Public Class regexp

#Region "Fields"

        Private _bydate As Boolean
        Private _defaultSeason As Integer
        Private _id As Integer
        Private _regexp As String

#End Region 'Fields

#Region "Constructors"

        Public Sub New()
            Clear()
        End Sub

#End Region 'Constructors

#Region "Properties"

        Public Property byDate() As Boolean
            Get
                Return _bydate
            End Get
            Set(ByVal value As Boolean)
                _bydate = value
            End Set
        End Property

        Public Property defaultSeason() As Integer
            Get
                Return _defaultSeason
            End Get
            Set(ByVal value As Integer)
                _defaultSeason = value
            End Set
        End Property

        Public Property ID() As Integer
            Get
                Return _id
            End Get
            Set(ByVal value As Integer)
                _id = value
            End Set
        End Property

        Public Property Regexp() As String
            Get
                Return _regexp
            End Get
            Set(ByVal value As String)
                _regexp = value
            End Set
        End Property

#End Region 'Properties

#Region "Methods"

        Public Sub Clear()
            _bydate = False
            _defaultSeason = -1
            _id = -1
            _regexp = String.Empty
        End Sub

#End Region 'Methods

    End Class

#End Region 'Nested Types

End Class