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
' # HD Movie Logos -> logo.png (choose this first)
' # ClearLOGOs -> logo.png (use this as a backup if no HD Logo in the lanaguage specified)
' # ClearART -> clearart.png (use this as a backup if no HD ClearArt, in the language specified)
' # HDClearART -> clearart.png (choose this first)
' # cdART -> disc.png
' # Movie Backgrounds -> Fanart (this is the only fanart.tv artwork that might overlap with 'typical' artwork scraping from IMDB/TMDB)
' # Movie Banner -> Banner (not poster - Frodo supports both now, <moviename>-poster.jpg/png and <moviename>-banner.jpg/png or poster.jpg/png and banner.jpg/png)
' # Movie Thumbs -> landscape.png
' # Special note - the Logos and ClearArts are language-specific and should be tagged with the appropriate language. Will want to have a setting allowing users to specify a language so as not to get a bunch of foreign-language artwork.
' # 1) Logo.png - to be added at a later stage, today is not possible to save
' # 2) Clearart.png - to be added at a later stage, today is not possible to save
' # 3) Disc.png - to be added at a later stage, today is not possible to save
' # 4) Landscape.png - to be added at a later stage, today is not possible to save
' # language is in image properties

Imports System.IO
Imports System.IO.Compression
Imports System.Text
Imports System.Text.RegularExpressions
Imports EmberAPI
Imports NLog
Imports System.Diagnostics

Namespace FanartTVs

    Public Class Scraper

#Region "Fields"

        Shared logger As Logger = NLog.LogManager.GetCurrentClassLogger()

        Friend WithEvents bwFANARTTV As New System.ComponentModel.BackgroundWorker

#End Region 'Fields

#Region "Events"

        '		Public Event PostersDownloaded(ByVal Posters As List(Of MediaContainers.Image))

        '		Public Event ProgressUpdated(ByVal iPercent As Integer)

#End Region 'Events

#Region "Methods"

        'Public Sub New(ByRef sMySettings As FanartTV_Image.sMySettings)
        '    FanartTv.API.Key = "ea68f9d0847c1b7643813c70cbfc0196"
        '    FanartTv.API.cKey = sMySettings.ApiKey
        '    Dim Test = New FanartTv.Movies.Latest()
        '    If FanartTv.API.ErrorOccurred Then
        '        If Not IsNothing(FanartTv.API.ErrorMessage) Then
        '            logger.Error(FanartTv.API.ErrorMessage)
        '        End If
        '    End If
        'End Sub

        'Public Sub Cancel()
        '	If Me.bwFANARTTV.IsBusy Then Me.bwFANARTTV.CancelAsync()

        '	While Me.bwFANARTTV.IsBusy
        '		Application.DoEvents()
        '		Threading.Thread.Sleep(50)
        '	End While
        'End Sub

        'Public Sub GetImagesAsync(ByVal sURL As String)
        '	Try
        '		If Not bwFANARTTV.IsBusy Then
        '			bwFANARTTV.WorkerSupportsCancellation = True
        '			bwFANARTTV.WorkerReportsProgress = True
        '			bwFANARTTV.RunWorkerAsync(New Arguments With {.Parameter = sURL})
        '		End If
        '	Catch ex As Exception
        '		logger.Error(New StackFrame().GetMethod().Name,ex)
        '	End Try
        'End Sub

        Public Function GetImages_Movie_MovieSet(ByVal imdbID_tmdbID As String, ByVal FilteredModifier As Structures.ScrapeModifier, ByRef Settings As MySettings) As MediaContainers.SearchResultsContainer
            Dim alImagesContainer As New MediaContainers.SearchResultsContainer

            Try
                FanartTv.API.Key = "ea68f9d0847c1b7643813c70cbfc0196"
                FanartTv.API.cKey = Settings.ApiKey

                Dim Results = New FanartTv.Movies.Movie(imdbID_tmdbID)
                If Results Is Nothing OrElse FanartTv.API.ErrorOccurred Then
                    If FanartTv.API.ErrorMessage IsNot Nothing Then
                        logger.Error(FanartTv.API.ErrorMessage)
                    End If
                    Return Nothing
                End If
                If bwFANARTTV.CancellationPending Then Return Nothing

                'Banner
                If FilteredModifier.MainBanner AndAlso Results.List.Moviebanner IsNot Nothing Then
                    For Each image In Results.List.Moviebanner
                        Dim tmpPoster As New MediaContainers.Image With { _
                            .Height = "185", _
                            .Likes = CInt(image.Likes), _
                            .LongLang = If(String.IsNullOrEmpty(image.Lang), String.Empty, Localization.ISOGetLangByCode2(image.Lang)), _
                            .Scraper = "Fanart.tv", _
                            .ShortLang = image.Lang, _
                            .URLOriginal = image.Url, _
                            .URLThumb = image.Url.Replace("/fanart/", "/preview/"), _
                            .Width = "1000"}

                        alImagesContainer.MainBanners.Add(tmpPoster)
                    Next
                End If

                'ClearArt
                If FilteredModifier.MainClearArt Then
                    If Results.List.Hdmovieclearart IsNot Nothing Then
                        For Each image In Results.List.Hdmovieclearart
                            Dim tmpPoster As New MediaContainers.Image With { _
                                .Height = "562", _
                                .Likes = CInt(image.Likes), _
                                .LongLang = If(String.IsNullOrEmpty(image.Lang), String.Empty, Localization.ISOGetLangByCode2(image.Lang)), _
                                .Scraper = "Fanart.tv", _
                                .ShortLang = image.Lang, _
                                .URLOriginal = image.Url, _
                                .URLThumb = image.Url.Replace("/fanart/", "/preview/"), _
                                .Width = "1000"}

                            alImagesContainer.MainClearArts.Add(tmpPoster)
                        Next
                    End If
                    If Results.List.Movieart IsNot Nothing AndAlso Not Settings.ClearArtOnlyHD Then
                        For Each image In Results.List.Movieart
                            Dim tmpPoster As New MediaContainers.Image With { _
                                .Height = "281", _
                                .Likes = CInt(image.Likes), _
                                .LongLang = If(String.IsNullOrEmpty(image.Lang), String.Empty, Localization.ISOGetLangByCode2(image.Lang)), _
                                .Scraper = "Fanart.tv", _
                                .ShortLang = image.Lang, _
                                .URLOriginal = image.Url, _
                                .URLThumb = image.Url.Replace("/fanart/", "/preview/"), _
                                .Width = "500"}

                            alImagesContainer.MainClearArts.Add(tmpPoster)
                        Next
                    End If
                End If

                'ClearLogo
                If FilteredModifier.MainClearLogo Then
                    If Results.List.Hdmovielogo IsNot Nothing Then
                        For Each image In Results.List.Hdmovielogo
                            Dim tmpPoster As New MediaContainers.Image With { _
                                .Height = "310", _
                                .Likes = CInt(image.Likes), _
                                .LongLang = If(String.IsNullOrEmpty(image.Lang), String.Empty, Localization.ISOGetLangByCode2(image.Lang)), _
                                .Scraper = "Fanart.tv", _
                                .ShortLang = image.Lang, _
                                .URLOriginal = image.Url, _
                                .URLThumb = image.Url.Replace("/fanart/", "/preview/"), _
                                .Width = "800"}

                            alImagesContainer.MainClearLogos.Add(tmpPoster)
                        Next
                    End If

                    If Results.List.Movielogo IsNot Nothing AndAlso Not Settings.ClearLogoOnlyHD Then
                        For Each image In Results.List.Movielogo
                            Dim tmpPoster As New MediaContainers.Image With { _
                                .Height = "155", _
                                .Likes = CInt(image.Likes), _
                                .LongLang = If(String.IsNullOrEmpty(image.Lang), String.Empty, Localization.ISOGetLangByCode2(image.Lang)), _
                                .Scraper = "Fanart.tv", _
                                .ShortLang = image.Lang, _
                                .URLOriginal = image.Url, _
                                .URLThumb = image.Url.Replace("/fanart/", "/preview/"), _
                                .Width = "400"}

                            alImagesContainer.MainClearLogos.Add(tmpPoster)
                        Next
                    End If
                End If

                'DiscArt
                If FilteredModifier.MainDiscArt AndAlso Results.List.Moviedisc IsNot Nothing Then
                    For Each image In Results.List.Moviedisc
                        Dim tmpPoster As New MediaContainers.Image With { _
                            .Disc = CInt(image.Disc), _
                            .DiscType = image.DiscType, _
                            .Height = "1000", _
                            .Likes = CInt(image.Likes), _
                            .LongLang = If(String.IsNullOrEmpty(image.Lang), String.Empty, Localization.ISOGetLangByCode2(image.Lang)), _
                            .Scraper = "Fanart.tv", _
                            .ShortLang = image.Lang, _
                            .URLOriginal = image.Url, _
                            .URLThumb = image.Url.Replace("/fanart/", "/preview/"), _
                            .Width = "1000"}

                        alImagesContainer.MainDiscArts.Add(tmpPoster)
                    Next
                End If

                'Fanart
                If (FilteredModifier.MainEFanarts OrElse FilteredModifier.MainEThumbs OrElse FilteredModifier.MainFanart) AndAlso Results.List.Moviebackground IsNot Nothing Then
                    For Each image In Results.List.Moviebackground
                        alImagesContainer.MainFanarts.Add(New MediaContainers.Image With {.URLOriginal = image.Url, .URLThumb = image.Url.Replace("/fanart/", "/preview/"), .Width = "1920", .Height = "1080", .Scraper = "Fanart.tv", .ShortLang = image.Lang, .LongLang = If(String.IsNullOrEmpty(image.Lang), "", Localization.ISOGetLangByCode2(image.Lang)), .Likes = CInt(image.Likes)})
                    Next
                End If

                'Landscape
                If FilteredModifier.MainLandscape AndAlso Results.List.Moviethumb IsNot Nothing Then
                    For Each image In Results.List.Moviethumb
                        Dim tmpPoster As New MediaContainers.Image With { _
                            .Height = "562", _
                            .Likes = CInt(image.Likes), _
                            .LongLang = If(String.IsNullOrEmpty(image.Lang), String.Empty, Localization.ISOGetLangByCode2(image.Lang)), _
                            .Scraper = "Fanart.tv", _
                            .ShortLang = image.Lang, _
                            .URLOriginal = image.Url, _
                            .URLThumb = image.Url.Replace("/fanart/", "/preview/"), _
                            .Width = "1000"}

                        alImagesContainer.MainLandscapes.Add(tmpPoster)
                    Next
                End If

                'Poster
                If FilteredModifier.MainPoster AndAlso Results.List.Movieposter IsNot Nothing Then
                    For Each image In Results.List.Movieposter
                        Dim tmpPoster As New MediaContainers.Image With { _
                            .Height = "1426", _
                            .Likes = CInt(image.Likes), _
                            .LongLang = If(String.IsNullOrEmpty(image.Lang), String.Empty, Localization.ISOGetLangByCode2(image.Lang)), _
                            .Scraper = "Fanart.tv", _
                            .ShortLang = image.Lang, _
                            .URLOriginal = image.Url, _
                            .URLThumb = image.Url.Replace("/fanart/", "/preview/"), _
                            .Width = "1000"}

                        alImagesContainer.MainPosters.Add(tmpPoster)
                    Next
                End If

            Catch ex As Exception
                logger.Error(New StackFrame().GetMethod().Name, ex)
            End Try

            Return alImagesContainer
        End Function

        Public Function GetImages_TV(ByVal tvdbID As String, ByVal FilteredModifier As Structures.ScrapeModifier, ByRef Settings As MySettings) As MediaContainers.SearchResultsContainer
            Dim alContainer As New MediaContainers.SearchResultsContainer

            Try
                FanartTv.API.Key = "ea68f9d0847c1b7643813c70cbfc0196"
                FanartTv.API.cKey = Settings.ApiKey

                Dim Results = New FanartTv.TV.Show(tvdbID)
                If Results Is Nothing OrElse FanartTv.API.ErrorOccurred Then
                    If FanartTv.API.ErrorMessage IsNot Nothing Then
                        logger.Error(FanartTv.API.ErrorMessage)
                    End If
                    Return Nothing
                End If
                If bwFANARTTV.CancellationPending Then Return Nothing

                'MainBanner
                If FilteredModifier.MainBanner AndAlso Results.List.Tvbanner IsNot Nothing Then
                    For Each image In Results.List.Tvbanner
                        Dim tmpPoster As New MediaContainers.Image With { _
                            .Height = "185", _
                            .Likes = CInt(image.Likes), _
                            .LongLang = If(String.IsNullOrEmpty(image.Lang), String.Empty, Localization.ISOGetLangByCode2(image.Lang)), _
                            .Scraper = "Fanart.tv", _
                            .ShortLang = image.Lang, _
                            .TVBannerType = Enums.TVBannerType.Any, _
                            .URLOriginal = image.Url, _
                            .URLThumb = image.Url.Replace("/fanart/", "/preview/"), _
                            .Width = "1000"}

                        alContainer.MainBanners.Add(tmpPoster)
                    Next
                End If

                'SeasonBanner
                If FilteredModifier.SeasonBanner AndAlso Results.List.Seasonbanner IsNot Nothing Then
                    For Each image In Results.List.Seasonbanner
                        Dim tmpPoster As New MediaContainers.Image With { _
                            .Height = "185", _
                            .Likes = CInt(image.Likes), _
                            .LongLang = If(String.IsNullOrEmpty(image.Lang), String.Empty, Localization.ISOGetLangByCode2(image.Lang)), _
                            .Scraper = "Fanart.tv", _
                            .Season = If(image.Season = "all", 999, CInt(image.Season)), _
                            .ShortLang = image.Lang, _
                            .TVBannerType = Enums.TVBannerType.Any, _
                            .URLOriginal = image.Url, _
                            .URLThumb = image.Url.Replace("/fanart/", "/preview/"), _
                            .Width = "1000"}

                        alContainer.SeasonBanners.Add(tmpPoster)
                    Next
                End If

                'MainCharacterArt
                If FilteredModifier.MainCharacterArt AndAlso Results.List.Characterart IsNot Nothing Then
                    For Each image In Results.List.Characterart
                        Dim tmpPoster As New MediaContainers.Image With { _
                            .Height = "512", _
                            .Likes = CInt(image.Likes), _
                            .LongLang = If(String.IsNullOrEmpty(image.Lang), String.Empty, Localization.ISOGetLangByCode2(image.Lang)), _
                            .Scraper = "Fanart.tv", _
                            .ShortLang = image.Lang, _
                            .URLOriginal = image.Url, _
                            .URLThumb = image.Url.Replace("/fanart/", "/preview/"), _
                            .Width = "512"}

                        alContainer.MainCharacterArts.Add(tmpPoster)
                    Next
                End If

                'MainClearArt
                If FilteredModifier.MainClearArt Then
                    If Results.List.Hdclearart IsNot Nothing Then
                        For Each image In Results.List.Hdclearart
                            Dim tmpPoster As New MediaContainers.Image With { _
                                .Height = "562", _
                                .Likes = CInt(image.Likes), _
                                .LongLang = If(String.IsNullOrEmpty(image.Lang), String.Empty, Localization.ISOGetLangByCode2(image.Lang)), _
                                .Scraper = "Fanart.tv", _
                                .ShortLang = image.Lang, _
                                .URLOriginal = image.Url, _
                                .URLThumb = image.Url.Replace("/fanart/", "/preview/"), _
                                .Width = "1000"}

                            alContainer.MainClearArts.Add(tmpPoster)
                        Next
                    End If
                    If Results.List.Clearart IsNot Nothing AndAlso Not Settings.ClearArtOnlyHD Then
                        For Each image In Results.List.Clearart
                            Dim tmpPoster As New MediaContainers.Image With { _
                                .Height = "281", _
                                .Likes = CInt(image.Likes), _
                                .LongLang = If(String.IsNullOrEmpty(image.Lang), String.Empty, Localization.ISOGetLangByCode2(image.Lang)), _
                                .Scraper = "Fanart.tv", _
                                .ShortLang = image.Lang, _
                                .URLOriginal = image.Url, _
                                .URLThumb = image.Url.Replace("/fanart/", "/preview/"), _
                                .Width = "500"}

                            alContainer.MainClearArts.Add(tmpPoster)
                        Next
                    End If
                End If

                'MainClearLogo
                If FilteredModifier.MainClearLogo Then
                    If Results.List.HdTListvlogo IsNot Nothing Then
                        For Each Image In Results.List.HdTListvlogo
                            Dim tmpPoster As New MediaContainers.Image With { _
                                .Height = "310", _
                                .Likes = CInt(Image.Likes), _
                                .LongLang = If(String.IsNullOrEmpty(Image.Lang), String.Empty, Localization.ISOGetLangByCode2(Image.Lang)), _
                                .Scraper = "Fanart.tv", _
                                .ShortLang = Image.Lang, _
                                .URLOriginal = Image.Url, _
                                .URLThumb = Image.Url.Replace("/fanart/", "/preview/"), _
                                .Width = "800"}

                            alContainer.MainClearLogos.Add(tmpPoster)
                        Next
                    End If
                    If Results.List.Clearlogo IsNot Nothing AndAlso Not Settings.ClearLogoOnlyHD Then
                        For Each Image In Results.List.Clearlogo
                            Dim tmpPoster As New MediaContainers.Image With { _
                                .Height = "155", _
                                .Likes = CInt(Image.Likes), _
                                .LongLang = If(String.IsNullOrEmpty(Image.Lang), String.Empty, Localization.ISOGetLangByCode2(Image.Lang)), _
                                .Scraper = "Fanart.tv", _
                                .ShortLang = Image.Lang, _
                                .URLOriginal = Image.Url, _
                                .URLThumb = Image.Url.Replace("/fanart/", "/preview/"), _
                                .Width = "400"}

                            alContainer.MainClearLogos.Add(tmpPoster)
                        Next
                    End If
                End If

                'MainFanart
                If FilteredModifier.MainFanart AndAlso Results.List.Showbackground IsNot Nothing Then
                    For Each image In Results.List.Showbackground
                        alContainer.MainFanarts.Add(New MediaContainers.Image With {.URLOriginal = image.Url, .Width = "1920", .Height = "1080", .URLThumb = image.Url.Replace("/fanart/", "/preview/"), .Scraper = "Fanart.tv", .ShortLang = image.Lang, .LongLang = If(String.IsNullOrEmpty(image.Lang), "", Localization.ISOGetLangByCode2(image.Lang)), .Likes = CInt(image.Likes)})
                    Next
                End If

                'MainLandscape
                If FilteredModifier.MainLandscape AndAlso Results.List.Tvthumb IsNot Nothing Then
                    For Each Image In Results.List.Tvthumb
                        Dim tmpPoster As New MediaContainers.Image With { _
                            .Height = "281", _
                            .Likes = CInt(Image.Likes), _
                            .LongLang = If(String.IsNullOrEmpty(Image.Lang), String.Empty, Localization.ISOGetLangByCode2(Image.Lang)), _
                            .Scraper = "Fanart.tv", _
                            .ShortLang = Image.Lang, _
                            .URLOriginal = Image.Url, _
                            .URLThumb = Image.Url.Replace("/fanart/", "/preview/"), _
                            .Width = "500"}

                        alContainer.MainLandscapes.Add(tmpPoster)
                    Next
                End If

                'SeasonLandscape
                If FilteredModifier.SeasonLandscape AndAlso Results.List.Seasonthumb IsNot Nothing Then
                    For Each Image In Results.List.Seasonthumb
                        Dim tmpPoster As New MediaContainers.Image With { _
                            .Height = "281", _
                            .Likes = CInt(Image.Likes), _
                            .LongLang = If(String.IsNullOrEmpty(Image.Lang), String.Empty, Localization.ISOGetLangByCode2(Image.Lang)), _
                            .Scraper = "Fanart.tv", _
                            .Season = If(Image.Season = "all", 999, CInt(Image.Season)), _
                            .ShortLang = Image.Lang, _
                            .TVBannerType = Enums.TVBannerType.Any, _
                            .URLOriginal = Image.Url, _
                            .URLThumb = Image.Url.Replace("/fanart/", "/preview/"), _
                            .Width = "500"}

                        alContainer.SeasonLandscapes.Add(tmpPoster)
                    Next
                End If

                'MainPoster
                If FilteredModifier.MainPoster AndAlso Results.List.Tvposter IsNot Nothing Then
                    For Each image In Results.List.Tvposter
                        Dim tmpPoster As New MediaContainers.Image With { _
                            .Height = "1426", _
                            .Likes = CInt(image.Likes), _
                            .LongLang = If(String.IsNullOrEmpty(image.Lang), String.Empty, Localization.ISOGetLangByCode2(image.Lang)), _
                            .Scraper = "Fanart.tv", _
                            .ShortLang = image.Lang, _
                            .TVBannerType = Enums.TVBannerType.Any, _
                            .URLOriginal = image.Url, _
                            .URLThumb = image.Url.Replace("/fanart/", "/preview/"), _
                            .Width = "1000"}

                        alContainer.MainPosters.Add(tmpPoster)
                    Next
                End If

                'SeasonPoster
                If FilteredModifier.SeasonPoster AndAlso Results.List.Seasonposter IsNot Nothing Then
                    For Each image In Results.List.Seasonposter
                        Dim tmpPoster As New MediaContainers.Image With { _
                            .Height = "1426", _
                            .Likes = CInt(image.Likes), _
                            .LongLang = If(String.IsNullOrEmpty(image.Lang), String.Empty, Localization.ISOGetLangByCode2(image.Lang)), _
                            .Scraper = "Fanart.tv", _
                            .Season = If(image.Season = "all", 999, CInt(image.Season)), _
                            .ShortLang = image.Lang, _
                            .TVBannerType = Enums.TVBannerType.Any, _
                            .URLOriginal = image.Url, _
                            .URLThumb = image.Url.Replace("/fanart/", "/preview/"), _
                            .Width = "1000"}

                        alContainer.SeasonPosters.Add(tmpPoster)
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
            Dim ClearArtOnlyHD As Boolean
            Dim ClearLogoOnlyHD As Boolean

#End Region 'Fields

        End Structure

#End Region 'Nested Types

    End Class

End Namespace

