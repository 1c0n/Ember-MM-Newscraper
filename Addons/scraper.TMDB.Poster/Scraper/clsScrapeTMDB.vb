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
Imports System.Diagnostics

Namespace TMDB

	Public Class Scraper

#Region "Fields"

        Shared logger As Logger = NLog.LogManager.GetCurrentClassLogger()
        Private _MySettings As TMDB.Scraper.MySettings

        Friend WithEvents bwTMDB As New System.ComponentModel.BackgroundWorker

#End Region 'Fields

#Region "Methods"

        'Public Sub Cancel()
        '	If bwTMDB.IsBusy Then bwTMDB.CancelAsync()

        '	While bwTMDB.IsBusy
        '		Application.DoEvents()
        '		Threading.Thread.Sleep(50)
        '	End While
        'End Sub

        'Public Sub GetImagesAsync(ByVal imdbID As String, ByVal Type As Enums.ScraperCapabilities)
        '    Try
        '        If Not bwTMDB.IsBusy Then
        '            bwTMDB.WorkerSupportsCancellation = True
        '            bwTMDB.WorkerReportsProgress = True
        '            bwTMDB.RunWorkerAsync(New Arguments With {.Parameter = imdbID, .Type = Type})
        '        End If
        '    Catch ex As Exception
        '        logger.Error(New StackFrame().GetMethod().Name,ex)
        '    End Try
        'End Sub

        Public Function GetImages_Movie_MovieSet(ByVal TMDBID As String, ByVal FilteredModifier As Structures.ScrapeModifier, ByRef Settings As MySettings, ByVal ContentType As Enums.ContentType) As MediaContainers.SearchResultsContainer
            Dim alImagesContainer As New MediaContainers.SearchResultsContainer

            If bwTMDB.CancellationPending Then Return Nothing

            Try
                Dim TMDBClient = New TMDbLib.Client.TMDbClient(Settings.APIKey)
                TMDBClient.GetConfig()

                Dim Results As TMDbLib.Objects.General.Images = Nothing
                If ContentType = Enums.ContentType.Movie Then
                    Results = TMDBClient.GetMovieImages(CInt(TMDBID))
                ElseIf ContentType = Enums.ContentType.MovieSet Then
                    Results = TMDBClient.GetCollectionImages(CInt(TMDBID))
                End If

                If Results Is Nothing Then
                    Return Nothing
                End If

                'Fanart
                If (FilteredModifier.MainEFanarts OrElse FilteredModifier.MainEThumbs OrElse FilteredModifier.MainFanart) AndAlso Results.Backdrops IsNot Nothing Then
                    For Each image In Results.Backdrops
                        Dim tmpImage As New MediaContainers.Image With { _
                            .Height = image.Height.ToString, _
                            .Likes = 0, _
                            .LongLang = If(String.IsNullOrEmpty(image.Iso_639_1), String.Empty, Localization.ISOGetLangByCode2(image.Iso_639_1)), _
                            .Scraper = "TMDB", _
                            .ShortLang = If(String.IsNullOrEmpty(image.Iso_639_1), String.Empty, image.Iso_639_1), _
                            .ThumbURL = TMDBClient.Config.Images.BaseUrl & "w300" & image.FilePath, _
                            .URL = TMDBClient.Config.Images.BaseUrl & "original" & image.FilePath, _
                            .VoteAverage = image.VoteAverage.ToString, _
                            .VoteCount = image.VoteCount, _
                            .Width = image.Width.ToString}

                        alImagesContainer.MainFanarts.Add(tmpImage)
                    Next
                End If

                'Poster
                If FilteredModifier.MainPoster AndAlso Results.Posters IsNot Nothing Then
                    For Each image In Results.Posters
                        Dim tmpImage As New MediaContainers.Image With { _
                                .Height = image.Height.ToString, _
                                .Likes = 0, _
                                .LongLang = If(String.IsNullOrEmpty(image.Iso_639_1), String.Empty, Localization.ISOGetLangByCode2(image.Iso_639_1)), _
                                .Scraper = "TMDB", _
                                .ShortLang = If(String.IsNullOrEmpty(image.Iso_639_1), String.Empty, image.Iso_639_1), _
                                .ThumbURL = TMDBClient.Config.Images.BaseUrl & "w185" & image.FilePath, _
                                .URL = TMDBClient.Config.Images.BaseUrl & "original" & image.FilePath, _
                                .VoteAverage = image.VoteAverage.ToString, _
                                .VoteCount = image.VoteCount, _
                                .Width = image.Width.ToString}

                        alImagesContainer.MainPosters.Add(tmpImage)
                    Next
                End If

            Catch ex As Exception
                logger.Error(New StackFrame().GetMethod().Name, ex)
            End Try

            Return alImagesContainer
        End Function

        Public Function GetImages_TV(ByVal tmdbID As String, ByVal FilteredModifier As Structures.ScrapeModifier, ByRef Settings As MySettings) As MediaContainers.SearchResultsContainer
            Dim alContainer As New MediaContainers.SearchResultsContainer

            If bwTMDB.CancellationPending Then Return Nothing

            Try
                Dim TMDBClient = New TMDbLib.Client.TMDbClient(Settings.APIKey)
                TMDBClient.GetConfig()

                Dim Results As TMDbLib.Objects.General.ImagesWithId = Nothing
                Results = TMDBClient.GetTvShowImages(CInt(tmdbID))

                If Results Is Nothing Then
                    Return Nothing
                End If

                'Fanart Show / AllSeasons / Season / Episode
                If (FilteredModifier.AllSeasonsFanart OrElse FilteredModifier.EpisodeFanart OrElse FilteredModifier.MainFanart OrElse FilteredModifier.SeasonFanart) AndAlso Results.Backdrops IsNot Nothing Then
                    For Each image In Results.Backdrops
                        Dim tmpImage As New MediaContainers.Image With { _
                            .Height = image.Height.ToString, _
                            .Likes = 0, _
                            .LongLang = If(String.IsNullOrEmpty(image.Iso_639_1), String.Empty, Localization.ISOGetLangByCode2(image.Iso_639_1)), _
                            .Scraper = "TMDB", _
                            .ShortLang = If(String.IsNullOrEmpty(image.Iso_639_1), String.Empty, image.Iso_639_1), _
                            .ThumbURL = TMDBClient.Config.Images.BaseUrl & "w300" & image.FilePath, _
                            .URL = TMDBClient.Config.Images.BaseUrl & "original" & image.FilePath, _
                            .VoteAverage = image.VoteAverage.ToString, _
                            .VoteCount = image.VoteCount, _
                            .Width = image.Width.ToString}

                        alContainer.MainFanarts.Add(tmpImage)
                    Next
                End If

                'Poster Show / AllSeasons
                If (FilteredModifier.AllSeasonsPoster OrElse FilteredModifier.MainPoster) AndAlso Results.Posters IsNot Nothing Then
                    For Each image In Results.Posters
                        Dim tmpImage As New MediaContainers.Image With { _
                                .Height = image.Height.ToString, _
                                .Likes = 0, _
                                .LongLang = If(String.IsNullOrEmpty(image.Iso_639_1), String.Empty, Localization.ISOGetLangByCode2(image.Iso_639_1)), _
                                .Scraper = "TMDB", _
                                .ShortLang = If(String.IsNullOrEmpty(image.Iso_639_1), String.Empty, image.Iso_639_1), _
                                .ThumbURL = TMDBClient.Config.Images.BaseUrl & "w185" & image.FilePath, _
                                .URL = TMDBClient.Config.Images.BaseUrl & "original" & image.FilePath, _
                                .VoteAverage = image.VoteAverage.ToString, _
                                .VoteCount = image.VoteCount, _
                                .Width = image.Width.ToString}

                        alContainer.MainPosters.Add(tmpImage)
                    Next
                End If

            Catch ex As Exception
                logger.Error(New StackFrame().GetMethod().Name, ex)
            End Try

            Return alContainer
        End Function

        Public Function GetImages_TVEpisode(ByVal tmdbID As String, ByRef iSeason As Integer, ByRef iEpisode As Integer, ByRef Settings As MySettings) As MediaContainers.SearchResultsContainer
            Dim alContainer As New MediaContainers.SearchResultsContainer

            If bwTMDB.CancellationPending Then Return Nothing

            Try
                Dim TMDBClient = New TMDbLib.Client.TMDbClient(Settings.APIKey)
                TMDBClient.GetConfig()

                Dim Results As TMDbLib.Objects.General.StillImages = Nothing
                Results = TMDBClient.GetTvEpisodeImages(CInt(tmdbID), iSeason, iEpisode)

                If Results Is Nothing Then
                    Return Nothing
                End If

                'Poster
                If Results.Stills IsNot Nothing Then
                    For Each image In Results.Stills
                        Dim tmpImage As New MediaContainers.Image With { _
                            .Episode = iEpisode, _
                            .Height = image.Height.ToString, _
                            .Likes = 0, _
                            .LongLang = If(String.IsNullOrEmpty(image.Iso_639_1), String.Empty, Localization.ISOGetLangByCode2(image.Iso_639_1)), _
                            .Scraper = "TMDB", _
                            .Season = iSeason, _
                            .ShortLang = If(String.IsNullOrEmpty(image.Iso_639_1), String.Empty, image.Iso_639_1), _
                            .ThumbURL = TMDBClient.Config.Images.BaseUrl & "w185" & image.FilePath, _
                            .URL = TMDBClient.Config.Images.BaseUrl & "original" & image.FilePath, _
                            .VoteAverage = image.VoteAverage.ToString, _
                            .VoteCount = image.VoteCount, _
                            .Width = image.Width.ToString}

                        alContainer.EpisodePosters.Add(tmpImage)
                    Next
                End If

            Catch ex As Exception
                logger.Error(New StackFrame().GetMethod().Name, ex)
            End Try

            Return alContainer
        End Function

        Public Function GetTMDBbyTVDB(ByRef tvdbID As String, ByRef Settings As MySettings) As String
            Dim tmdbID As String = String.Empty

            Try
                Dim TMDBClient = New TMDbLib.Client.TMDbClient(Settings.APIKey)
                tmdbID = TMDBClient.Find(TMDbLib.Objects.Find.FindExternalSource.TvDb, tvdbID).TvResults.Item(0).Id.ToString

            Catch ex As Exception
                logger.Error(New StackFrame().GetMethod().Name, ex)
            End Try

            Return tmdbID
        End Function

#End Region 'Methods

#Region "Nested Types"

        Private Structure Arguments

#Region "Fields"

            Dim Parameter As String
            Dim Type As Enums.ModifierType

#End Region 'Fields

        End Structure

        Structure MySettings

#Region "Fields"

            Dim APIKey As String

#End Region 'Fields

        End Structure

#End Region 'Nested Types

	End Class

End Namespace