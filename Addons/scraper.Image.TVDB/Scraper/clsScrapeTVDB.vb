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
Imports System.IO.Compression
Imports System.Text
Imports System.Text.RegularExpressions
Imports EmberAPI
Imports NLog
Imports System.Diagnostics

Namespace TVDBs

    Public Class Scraper

#Region "Fields"

        Shared logger As Logger = NLog.LogManager.GetCurrentClassLogger()

        Friend WithEvents bwTVDB As New System.ComponentModel.BackgroundWorker

        Private _TVDBApi As TVDB.Web.WebInterface
        Private _TVDBMirror As TVDB.Model.Mirror
        Private _MySettings As MySettings

#End Region 'Fields

#Region "Events"

        '		Public Event PostersDownloaded(ByVal Posters As List(Of MediaContainers.Image))

        '		Public Event ProgressUpdated(ByVal iPercent As Integer)

#End Region 'Events

#Region "Methods"

        Public Sub New(ByVal Settings As MySettings)
            Try
                _MySettings = Settings

                If Not Directory.Exists(Path.Combine(Master.TempPath, "Shows")) Then Directory.CreateDirectory(Path.Combine(Master.TempPath, "Shows"))
                _TVDBApi = New TVDB.Web.WebInterface(_MySettings.ApiKey, Path.Combine(Master.TempPath, "Shows"))
                _TVDBMirror = New TVDB.Model.Mirror With {.Address = "http://thetvdb.com", .ContainsBannerFile = True, .ContainsXmlFile = True, .ContainsZipFile = False}

            Catch ex As Exception
                logger.Error(New StackFrame().GetMethod().Name, ex)
            End Try
        End Sub

        Public Function GetImages_TV(ByVal tvdbID As String, ByVal FilteredModifier As Structures.ScrapeModifier) As MediaContainers.SearchResultsContainer
            Dim alContainer As New MediaContainers.SearchResultsContainer

            Try
                Dim Results As TVDB.Model.SeriesDetails = _TVDBApi.GetFullSeriesById(CInt(tvdbID), _TVDBMirror).Result
                If Results Is Nothing Then
                    Return Nothing
                End If

                If bwTVDB.CancellationPending Then Return Nothing

                If Results.Banners IsNot Nothing Then

                    'Banner Show / AllSeasons
                    If (FilteredModifier.AllSeasonsBanner OrElse FilteredModifier.MainBanner) Then
                        For Each image As TVDB.Model.Banner In Results.Banners.Where(Function(f) f.Type = TVDB.Model.BannerTyp.series)
                            Dim img As New MediaContainers.Image With {.Height = "140", _
                                                                       .LongLang = Localization.ISOGetLangByCode2(image.Language), _
                                                                       .Scraper = "TVDB", _
                                                                       .Season = image.Season, _
                                                                       .ShortLang = image.Language, _
                                                                       .URLOriginal = String.Concat(_TVDBMirror.Address, "/banners/", image.BannerPath), _
                                                                       .URLThumb = If(Not String.IsNullOrEmpty(image.ThumbnailPath), String.Concat(_TVDBMirror.Address, "/banners/", image.ThumbnailPath), String.Empty), _
                                                                       .VoteAverage = CStr(image.Rating), _
                                                                       .VoteCount = image.RatingCount, _
                                                                       .Width = "758"}
                            alContainer.MainBanners.Add(img)
                        Next
                    End If

                    'Banner Season / AllSeasons
                    If (FilteredModifier.AllSeasonsBanner OrElse FilteredModifier.SeasonBanner) Then
                        For Each image As TVDB.Model.Banner In Results.Banners.Where(Function(f) f.Type = TVDB.Model.BannerTyp.season AndAlso f.BannerPath.Contains("seasonswide"))
                            Dim img As New MediaContainers.Image With {.Height = "140", _
                                                                       .LongLang = Localization.ISOGetLangByCode2(image.Language), _
                                                                       .Scraper = "TVDB", _
                                                                       .Season = image.Season, _
                                                                       .ShortLang = image.Language, _
                                                                       .URLOriginal = String.Concat(_TVDBMirror.Address, "/banners/", image.BannerPath), _
                                                                       .URLThumb = If(Not String.IsNullOrEmpty(image.ThumbnailPath), String.Concat(_TVDBMirror.Address, "/banners/", image.ThumbnailPath), String.Empty), _
                                                                       .VoteAverage = CStr(image.Rating), _
                                                                       .VoteCount = image.RatingCount, _
                                                                       .Width = "758"}
                            alContainer.SeasonBanners.Add(img)
                        Next
                    End If

                    'Fanart Show / AllSeasons / Season / Episode
                    If (FilteredModifier.AllSeasonsFanart OrElse FilteredModifier.EpisodeFanart OrElse FilteredModifier.MainFanart OrElse FilteredModifier.SeasonFanart) Then
                        For Each image As TVDB.Model.Banner In Results.Banners.Where(Function(f) f.Type = TVDB.Model.BannerTyp.fanart)
                            alContainer.MainFanarts.Add(New MediaContainers.Image With {.Height = StringUtils.StringToSize(image.Dimension).Height.ToString, _
                                                                                        .LongLang = Localization.ISOGetLangByCode2(image.Language), _
                                                                                        .Scraper = "TVDB", _
                                                                                        .Season = image.Season, _
                                                                                        .ShortLang = image.Language, _
                                                                                        .URLOriginal = String.Concat(_TVDBMirror.Address, "/banners/", image.BannerPath), _
                                                                                        .URLThumb = If(Not String.IsNullOrEmpty(image.ThumbnailPath), String.Concat(_TVDBMirror.Address, "/banners/", image.ThumbnailPath), String.Empty), _
                                                                                        .VoteAverage = CStr(image.Rating), _
                                                                                        .VoteCount = image.RatingCount, _
                                                                                        .Width = StringUtils.StringToSize(image.Dimension).Width.ToString})
                        Next
                    End If

                    'Poster Show / AllSeasons
                    If (FilteredModifier.AllSeasonsPoster OrElse FilteredModifier.MainPoster) Then
                        For Each image As TVDB.Model.Banner In Results.Banners.Where(Function(f) f.Type = TVDB.Model.BannerTyp.poster)
                            Dim img As New MediaContainers.Image With {.Height = StringUtils.StringToSize(image.Dimension).Height.ToString, _
                                                                       .LongLang = Localization.ISOGetLangByCode2(image.Language), _
                                                                       .Scraper = "TVDB", _
                                                                       .Season = image.Season, _
                                                                       .ShortLang = image.Language, _
                                                                       .URLOriginal = String.Concat(_TVDBMirror.Address, "/banners/", image.BannerPath), _
                                                                       .URLThumb = If(Not String.IsNullOrEmpty(image.ThumbnailPath), String.Concat(_TVDBMirror.Address, "/banners/", image.ThumbnailPath), String.Empty), _
                                                                       .VoteAverage = CStr(image.Rating), _
                                                                       .VoteCount = image.RatingCount, _
                                                                       .Width = StringUtils.StringToSize(image.Dimension).Width.ToString}
                            alContainer.MainPosters.Add(img)
                        Next
                    End If

                    'Poster Season  /AllSeasons
                    If (FilteredModifier.AllSeasonsPoster OrElse FilteredModifier.SeasonPoster) Then
                        For Each image As TVDB.Model.Banner In Results.Banners.Where(Function(f) f.Type = TVDB.Model.BannerTyp.season AndAlso Not f.BannerPath.Contains("seasonswide"))
                            Dim img As New MediaContainers.Image With {.Height = "578", _
                                                                       .LongLang = Localization.ISOGetLangByCode2(image.Language), _
                                                                       .Scraper = "TVDB", _
                                                                       .Season = image.Season, _
                                                                       .ShortLang = image.Language, _
                                                                       .URLThumb = If(Not String.IsNullOrEmpty(image.ThumbnailPath), String.Concat(_TVDBMirror.Address, "/banners/", image.ThumbnailPath), String.Empty), _
                                                                       .URLOriginal = String.Concat(_TVDBMirror.Address, "/banners/", image.BannerPath), _
                                                                       .VoteAverage = CStr(image.Rating), _
                                                                       .VoteCount = image.RatingCount, _
                                                                       .Width = "400"}
                            alContainer.SeasonPosters.Add(img)
                        Next
                    End If

                End If

            Catch ex As Exception
                logger.Error(New StackFrame().GetMethod().Name, ex)
            End Try

            Return alContainer
        End Function

        Public Function GetImages_TVEpisode(ByVal tvdbID As String, ByVal iSeason As Integer, ByVal iEpisode As Integer) As MediaContainers.SearchResultsContainer
            Dim alContainer As New MediaContainers.SearchResultsContainer

            Try
                Dim Results As TVDB.Model.SeriesDetails = _TVDBApi.GetFullSeriesById(CInt(tvdbID), _TVDBMirror).Result
                If Results Is Nothing Then
                    Return Nothing
                End If

                If bwTVDB.CancellationPending Then Return Nothing

                'Poster
                If Results.Series.Episodes IsNot Nothing Then
                    For Each tEpisode As TVDB.Model.Episode In Results.Series.Episodes.Where(Function(f) f.SeasonNumber = iSeason And f.CombinedEpisodeNumber = iEpisode)
                        Dim img As New MediaContainers.Image With { _
                            .Episode = tEpisode.Number, _
                            .Height = CStr(tEpisode.ThumbHeight), _
                            .LongLang = Localization.ISOGetLangByCode2(tEpisode.Language), _
                            .Scraper = "TVDB", _
                            .Season = tEpisode.SeasonNumber, _
                            .ShortLang = tEpisode.Language, _
                            .URLOriginal = String.Concat(_TVDBMirror.Address, "/banners/", tEpisode.PictureFilename), _
                            .URLThumb = If(Not String.IsNullOrEmpty(tEpisode.PictureFilename), String.Concat(_TVDBMirror.Address, "/banners/_cache/", tEpisode.PictureFilename), String.Empty), _
                            .Width = CStr(tEpisode.ThumbWidth)}

                        alContainer.EpisodePosters.Add(img)
                    Next
                End If

            Catch ex As Exception
                logger.Error(New StackFrame().GetMethod().Name, ex)
            End Try

            Return alContainer
        End Function


#End Region 'Methods

#Region "Nested Types"

        Private Structure Arguments

#Region "Fields"

            Dim Parameter As String
            Dim sType As String

#End Region 'Fields

        End Structure

        Private Structure Results

#Region "Fields"

            Dim Result As Object
            Dim ResultList As List(Of MediaContainers.Image)

#End Region 'Fields

        End Structure

        Structure MySettings

#Region "Fields"

            Dim ApiKey As String

#End Region 'Fields

        End Structure

#End Region 'Nested Types

    End Class

End Namespace

