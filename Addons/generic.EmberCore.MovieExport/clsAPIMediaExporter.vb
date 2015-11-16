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
Imports System.IO
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Xml.Serialization

Public Class MediaExporter

#Region "Fields"

    Shared logger As Logger = NLog.LogManager.GetCurrentClassLogger()

    Private tCounter_Global As Integer
    Private tCounter_TVEpisode As Integer
    Private tCounter_TVSeason As Integer
    Private tExportSettings As New ExportSettings
    Private tMovieList As List(Of Database.DBElement)
    Private tTempPath As String = Path.Combine(Master.TempPath, "Export")
    Private tTVShowList As List(Of Database.DBElement)

#End Region 'Fields

#Region "Methods"

    Private Function Build_ContentPartMap(ByVal strPattern As String) As List(Of ContentPart)
        'here we transform the main pattern string into a content map
        Dim tContentPartMap As New List(Of ContentPart)
        Dim part As ContentPart
        Dim iNextPart = strPattern.IndexOf("<$$")
        Dim iEndPart As Integer

        While strPattern.Length > 0
            If iNextPart > 0 Then
                'create the non-looped section
                part = New ContentPart With {.isLooped = False}
                part.Content = strPattern.Substring(0, iNextPart)
                tContentPartMap.Add(part)
                strPattern = strPattern.Substring(iNextPart)
                iNextPart = strPattern.IndexOf("<$$")
            ElseIf iNextPart = -1 Then
                'no more sections found, add the remaining html code
                part = New ContentPart With {.isLooped = False}
                part.Content = strPattern
                tContentPartMap.Add(part)
                strPattern = String.Empty
            Else
                If strPattern.IndexOf("<$$MOVIE>") = 0 Then
                    'create the looped section for movies
                    iEndPart = strPattern.IndexOf("</$$MOVIE>")
                    part = New ContentPart With {.ContentType = Enums.ContentType.Movie, .isLooped = True}
                    part.Content = strPattern.Substring(9, iEndPart - 9)
                    tContentPartMap.Add(part)
                    strPattern = strPattern.Substring(iEndPart + 10)
                    iNextPart = strPattern.IndexOf("<$$")
                ElseIf strPattern.IndexOf("<$$TVSHOW>") = 0 Then
                    'create the looped section for tv shows
                    iEndPart = strPattern.IndexOf("</$$TVSHOW>")
                    part = New ContentPart With {.ContentType = Enums.ContentType.TVShow, .isLooped = True}
                    part.Content = strPattern.Substring(10, iEndPart - 10)

                    'check if we have an InnerContentPart
                    If Not part.Content.IndexOf("<$$") = -1 Then
                        part.innerContentPartMap = Build_ContentPartMap(part.Content)
                        part.Content = String.Empty
                    End If

                    tContentPartMap.Add(part)
                    strPattern = strPattern.Substring(iEndPart + 11)
                    iNextPart = strPattern.IndexOf("<$$")
                ElseIf strPattern.IndexOf("<$$TVSEASON>") = 0 Then
                    'create the looped section for tv seasons
                    iEndPart = strPattern.IndexOf("</$$TVSEASON>")
                    part = New ContentPart With {.ContentType = Enums.ContentType.TVSeason, .isLooped = True}
                    part.Content = strPattern.Substring(12, iEndPart - 12)

                    'check if we have an InnerContentPart
                    If Not part.Content.IndexOf("<$$") = -1 Then
                        part.innerContentPartMap = Build_ContentPartMap(part.Content)
                        part.Content = String.Empty
                    End If

                    tContentPartMap.Add(part)
                    strPattern = strPattern.Substring(iEndPart + 13)
                    iNextPart = strPattern.IndexOf("<$$")
                ElseIf strPattern.IndexOf("<$$TVEPISODE>") = 0 Then
                    'create the looped section for tv episodes
                    iEndPart = strPattern.IndexOf("</$$TVEPISODE>")
                    part = New ContentPart With {.ContentType = Enums.ContentType.TVEpisode, .isLooped = True}
                    part.Content = strPattern.Substring(13, iEndPart - 13)

                    'check if we have an InnerContentPart
                    If Not part.Content.IndexOf("<$$") = -1 Then
                        part.innerContentPartMap = Build_ContentPartMap(part.Content)
                        part.Content = String.Empty
                    End If

                    tContentPartMap.Add(part)
                    strPattern = strPattern.Substring(iEndPart + 14)
                    iNextPart = strPattern.IndexOf("<$$")
                End If
            End If
        End While

        Return tContentPartMap
    End Function

    Private Function Build_HTML(ByVal tContentPartMap As List(Of ContentPart),
                                Optional ByVal tTVShow As Database.DBElement = Nothing,
                                Optional ByVal tTVSeason As Database.DBElement = Nothing) As StringBuilder

        Dim HTMLBodyPart As New StringBuilder

        For Each part In tContentPartMap
            If part.isLooped Then
                'Movies
                If part.ContentType = Enums.ContentType.Movie Then
                    For Each tMovie As Database.DBElement In tMovieList
                        HTMLBodyPart.Append(ProcessPattern_Movie(part, tMovie))
                        tCounter_Global += 1
                    Next

                    'TV Shows
                ElseIf part.ContentType = Enums.ContentType.TVShow Then
                    For Each tShow As Database.DBElement In tTVShowList
                        HTMLBodyPart.Append(ProcessPattern_TVShow(part, tShow))
                        tCounter_Global += 1
                    Next

                    'TV Seasons
                ElseIf part.ContentType = Enums.ContentType.TVSeason Then
                    If tTVShow IsNot Nothing Then
                        tCounter_TVSeason = 1
                        For Each tSeason As Database.DBElement In tTVShow.Seasons.Where(Function(f) Not f.TVSeason.Season = 999)
                            HTMLBodyPart.Append(ProcessPattern_TVSeason(part, tTVShow, tSeason))
                            tCounter_TVSeason += 1
                        Next
                    End If

                    'TV Episodes
                ElseIf part.ContentType = Enums.ContentType.TVEpisode Then
                    If tTVShow IsNot Nothing AndAlso tTVSeason IsNot Nothing Then
                        tCounter_TVEpisode = 1
                        For Each tEpisode As Database.DBElement In tTVShow.Episodes
                            HTMLBodyPart.Append(ProcessPattern_TVEpisode(part, tTVShow, tEpisode))
                            tCounter_TVEpisode += 1
                        Next
                    End If
                End If
            Else
                HTMLBodyPart.Append(part.Content)
            End If
        Next

        Return HTMLBodyPart
    End Function

    Private Sub CreateTemplate()

    End Sub

    Private Function ExportImage(ByVal tImage As MediaContainers.Image, ByVal tImageType As Enums.ModifierType) As String
        Dim strPath As String = String.Empty

        If Not Directory.Exists(Path.Combine(tTempPath, "export")) Then Directory.CreateDirectory(Path.Combine(tTempPath, "export"))

        If File.Exists(tImage.LocalFilePath) Then
            Select Case tImageType
                Case Enums.ModifierType.EpisodeFanart
                    If tExportSettings.EpisodeFanarts Then
                        If Not tExportSettings.EpisodeFanarts_MaxHeight = -1 OrElse Not tExportSettings.EpisodeFanarts_MaxWidth = -1 Then
                            If tImage.LoadAndCache(Enums.ContentType.TV, True, True) Then
                                Dim nImg As Image = tImage.ImageOriginal.Image
                                ImageUtils.ResizeImage(nImg, tExportSettings.EpisodeFanarts_MaxWidth, tExportSettings.EpisodeFanarts_MaxHeight)
                                tImage.ImageOriginal.UpdateMSfromImg(nImg)
                                strPath = String.Format("export/{0}/{1}/{2}-fanart.jpg", tCounter_Global, tCounter_TVSeason, tCounter_TVEpisode)
                                tImage.ImageOriginal.Save(Path.Combine(tTempPath, strPath))
                                tImage.ImageOriginal.Image.Dispose()   'Dispose to save memory
                            End If
                        Else
                            strPath = String.Format("export/{0}/{1}/{2}-fanart.jpg", tCounter_Global, tCounter_TVSeason, tCounter_TVEpisode)
                            File.Copy(tImage.LocalFilePath, Path.Combine(tTempPath, strPath), True)
                        End If
                    End If
                Case Enums.ModifierType.EpisodePoster
                    If tExportSettings.EpisodePosters Then
                        If Not tExportSettings.EpisodePosters_MaxHeight = -1 OrElse Not tExportSettings.EpisodePosters_MaxWidth = -1 Then
                            If tImage.LoadAndCache(Enums.ContentType.TV, True, True) Then
                                Dim nImg As Image = tImage.ImageOriginal.Image
                                ImageUtils.ResizeImage(nImg, tExportSettings.EpisodePosters_MaxWidth, tExportSettings.EpisodePosters_MaxHeight)
                                tImage.ImageOriginal.UpdateMSfromImg(nImg)
                                strPath = String.Format("export/{0}/{1}/{2}-poster.jpg", tCounter_Global, tCounter_TVSeason, tCounter_TVEpisode)
                                tImage.ImageOriginal.Save(Path.Combine(tTempPath, strPath))
                                tImage.ImageOriginal.Image.Dispose() 'Dispose to save memory
                            End If
                        Else
                            strPath = String.Format("export/{0}/{1}/{2}-poster.jpg", tCounter_Global, tCounter_TVSeason, tCounter_TVEpisode)
                            File.Copy(tImage.LocalFilePath, Path.Combine(tTempPath, strPath), True)
                        End If
                    End If
                Case Enums.ModifierType.MainBanner
                    If tExportSettings.MainBanners Then
                        If Not tExportSettings.MainBanners_MaxHeight = -1 OrElse Not tExportSettings.MainBanners_MaxWidth = -1 Then
                            If tImage.LoadAndCache(Enums.ContentType.Movie, True, True) Then
                                Dim nImg As Image = tImage.ImageOriginal.Image
                                ImageUtils.ResizeImage(nImg, tExportSettings.MainBanners_MaxWidth, tExportSettings.MainBanners_MaxHeight)
                                tImage.ImageOriginal.UpdateMSfromImg(nImg)
                                strPath = String.Format("export/{0}-banner.jpg", tCounter_Global)
                                tImage.ImageOriginal.Save(Path.Combine(tTempPath, strPath))
                                tImage.ImageOriginal.Image.Dispose() 'Dispose to save memory
                            End If
                        Else
                            strPath = String.Format("export/{0}-banner.jpg", tCounter_Global)
                            File.Copy(tImage.LocalFilePath, Path.Combine(tTempPath, strPath), True)
                        End If
                    End If
                Case Enums.ModifierType.MainCharacterArt
                    If tExportSettings.MainCharacterarts Then
                        strPath = String.Format("export/{0}-characterart.png", tCounter_Global)
                        File.Copy(tImage.LocalFilePath, Path.Combine(tTempPath, strPath), True)
                    End If
                Case Enums.ModifierType.MainClearArt
                    If tExportSettings.MainClearArts Then
                        strPath = String.Format("export/{0}-clearart.png", tCounter_Global)
                        File.Copy(tImage.LocalFilePath, Path.Combine(tTempPath, strPath), True)
                    End If
                Case Enums.ModifierType.MainClearLogo
                    If tExportSettings.MainClearLogos Then
                        strPath = String.Format("export/{0}-clearlogo.png", tCounter_Global)
                        File.Copy(tImage.LocalFilePath, Path.Combine(tTempPath, strPath), True)
                    End If
                Case Enums.ModifierType.MainDiscArt
                    If tExportSettings.MainClearArts Then
                        strPath = String.Format("export/{0}-discart.png", tCounter_Global)
                        File.Copy(tImage.LocalFilePath, Path.Combine(tTempPath, strPath), True)
                    End If
                Case Enums.ModifierType.MainFanart
                    If tExportSettings.MainFanarts Then
                        If Not tExportSettings.MainFanarts_MaxHeight = -1 OrElse Not tExportSettings.MainFanarts_MaxWidth = -1 Then
                            If tImage.LoadAndCache(Enums.ContentType.Movie, True, True) Then
                                Dim nImg As Image = tImage.ImageOriginal.Image
                                ImageUtils.ResizeImage(nImg, tExportSettings.MainFanarts_MaxWidth, tExportSettings.MainFanarts_MaxHeight)
                                tImage.ImageOriginal.UpdateMSfromImg(nImg)
                                strPath = String.Format("export/{0}-fanart.jpg", tCounter_Global)
                                tImage.ImageOriginal.Save(Path.Combine(tTempPath, strPath))
                                tImage.ImageOriginal.Image.Dispose() 'Dispose to save memory
                            End If
                        Else
                            strPath = String.Format("export/{0}-fanart.jpg", tCounter_Global)
                            File.Copy(tImage.LocalFilePath, Path.Combine(tTempPath, strPath), True)
                        End If
                    End If
                Case Enums.ModifierType.MainLandscape
                    If tExportSettings.MainLandscapes Then
                        If Not tExportSettings.MainLandscapes_MaxHeight = -1 OrElse Not tExportSettings.MainLandscapes_MaxWidth = -1 Then
                            If tImage.LoadAndCache(Enums.ContentType.Movie, True, True) Then
                                Dim nImg As Image = tImage.ImageOriginal.Image
                                ImageUtils.ResizeImage(nImg, tExportSettings.MainLandscapes_MaxWidth, tExportSettings.MainLandscapes_MaxHeight)
                                tImage.ImageOriginal.UpdateMSfromImg(nImg)
                                strPath = String.Format("export/{0}-landscape.jpg", tCounter_Global)
                                tImage.ImageOriginal.Save(Path.Combine(tTempPath, strPath))
                                tImage.ImageOriginal.Image.Dispose() 'Dispose to save memory
                            End If
                        Else
                            strPath = String.Format("export/{0}-landscape.jpg", tCounter_Global)
                            File.Copy(tImage.LocalFilePath, Path.Combine(tTempPath, strPath), True)
                        End If
                    End If
                Case Enums.ModifierType.MainPoster
                    If tExportSettings.MainPosters Then
                        If Not tExportSettings.MainPosters_MaxHeight = -1 OrElse Not tExportSettings.MainPosters_MaxWidth = -1 Then
                            If tImage.LoadAndCache(Enums.ContentType.Movie, True, True) Then
                                Dim nImg As Image = tImage.ImageOriginal.Image
                                ImageUtils.ResizeImage(nImg, tExportSettings.MainPosters_MaxWidth, tExportSettings.MainPosters_MaxHeight)
                                tImage.ImageOriginal.UpdateMSfromImg(nImg)
                                strPath = String.Format("export/{0}-poster.jpg", tCounter_Global)
                                tImage.ImageOriginal.Save(Path.Combine(tTempPath, strPath))
                                tImage.ImageOriginal.Image.Dispose() 'Dispose to save memory
                            End If
                        Else
                            strPath = String.Format("export/{0}-poster.jpg", tCounter_Global)
                            File.Copy(tImage.LocalFilePath, Path.Combine(tTempPath, strPath), True)
                        End If
                    End If
                Case Enums.ModifierType.SeasonBanner
                    If tExportSettings.SeasonBanners Then
                        If Not tExportSettings.SeasonBanners_MaxHeight = -1 OrElse Not tExportSettings.SeasonBanners_MaxWidth = -1 Then
                            If tImage.LoadAndCache(Enums.ContentType.Movie, True, True) Then
                                Dim nImg As Image = tImage.ImageOriginal.Image
                                ImageUtils.ResizeImage(nImg, tExportSettings.SeasonBanners_MaxWidth, tExportSettings.SeasonBanners_MaxHeight)
                                tImage.ImageOriginal.UpdateMSfromImg(nImg)
                                strPath = String.Format("export/{0}/{1}-banner.jpg", tCounter_Global, tCounter_TVSeason)
                                tImage.ImageOriginal.Save(Path.Combine(tTempPath, strPath))
                                tImage.ImageOriginal.Image.Dispose() 'Dispose to save memory
                            End If
                        Else
                            strPath = String.Format("export/{0}/{1}-banner.jpg", tCounter_Global, tCounter_TVSeason)
                            File.Copy(tImage.LocalFilePath, Path.Combine(tTempPath, strPath), True)
                        End If
                    End If
                Case Enums.ModifierType.SeasonFanart
                    If tExportSettings.SeasonFanarts Then
                        If Not tExportSettings.SeasonFanarts_MaxHeight = -1 OrElse Not tExportSettings.SeasonFanarts_MaxWidth = -1 Then
                            If tImage.LoadAndCache(Enums.ContentType.Movie, True, True) Then
                                Dim nImg As Image = tImage.ImageOriginal.Image
                                ImageUtils.ResizeImage(nImg, tExportSettings.SeasonFanarts_MaxWidth, tExportSettings.SeasonFanarts_MaxHeight)
                                tImage.ImageOriginal.UpdateMSfromImg(nImg)
                                strPath = String.Format("export/{0}/{1}-fanart.jpg", tCounter_Global, tCounter_TVSeason)
                                tImage.ImageOriginal.Save(Path.Combine(tTempPath, strPath))
                                tImage.ImageOriginal.Image.Dispose() 'Dispose to save memory
                            End If
                        Else
                            strPath = String.Format("export/{0}/{1}-fanart.jpg", tCounter_Global, tCounter_TVSeason)
                            File.Copy(tImage.LocalFilePath, Path.Combine(tTempPath, strPath), True)
                        End If
                    End If
                Case Enums.ModifierType.SeasonLandscape
                    If tExportSettings.SeasonLandscapes Then
                        If Not tExportSettings.SeasonLandscapes_MaxHeight = -1 OrElse Not tExportSettings.SeasonLandscapes_MaxWidth = -1 Then
                            If tImage.LoadAndCache(Enums.ContentType.Movie, True, True) Then
                                Dim nImg As Image = tImage.ImageOriginal.Image
                                ImageUtils.ResizeImage(nImg, tExportSettings.SeasonLandscapes_MaxWidth, tExportSettings.SeasonLandscapes_MaxHeight)
                                tImage.ImageOriginal.UpdateMSfromImg(nImg)
                                strPath = String.Format("export/{0}/{1}-landscape.jpg", tCounter_Global, tCounter_TVSeason)
                                tImage.ImageOriginal.Save(Path.Combine(tTempPath, strPath))
                                tImage.ImageOriginal.Image.Dispose() 'Dispose to save memory
                            End If
                        Else
                            strPath = String.Format("export/{0}/{1}-landscape.jpg", tCounter_Global, tCounter_TVSeason)
                            File.Copy(tImage.LocalFilePath, Path.Combine(tTempPath, strPath), True)
                        End If
                    End If
                Case Enums.ModifierType.SeasonPoster
                    If tExportSettings.SeasonPosters Then
                        If Not tExportSettings.SeasonPosters_MaxHeight = -1 OrElse Not tExportSettings.SeasonPosters_MaxWidth = -1 Then
                            If tImage.LoadAndCache(Enums.ContentType.Movie, True, True) Then
                                Dim nImg As Image = tImage.ImageOriginal.Image
                                ImageUtils.ResizeImage(nImg, tExportSettings.SeasonPosters_MaxWidth, tExportSettings.SeasonPosters_MaxHeight)
                                tImage.ImageOriginal.UpdateMSfromImg(nImg)
                                strPath = String.Format("export/{0}/{1}-poster.jpg", tCounter_Global, tCounter_TVSeason)
                                tImage.ImageOriginal.Save(Path.Combine(tTempPath, strPath))
                                tImage.ImageOriginal.Image.Dispose() 'Dispose to save memory
                            End If
                        Else
                            strPath = String.Format("export/{0}/{1}-poster.jpg", tCounter_Global, tCounter_TVSeason)
                            File.Copy(tImage.LocalFilePath, Path.Combine(tTempPath, strPath), True)
                        End If
                    End If
            End Select
        End If

        Return strPath
    End Function

    Private Function GetAVImages(ByVal tDBElement As Database.DBElement, ByVal strRow As String, ByVal tContentType As Enums.ContentType) As String
        If APIXML.lFlags.Count > 0 Then
            Dim fiAV As New MediaInfo.Fileinfo
            Select Case tContentType
                Case Enums.ContentType.Movie
                    fiAV = tDBElement.Movie.FileInfo
                Case Enums.ContentType.TVEpisode
                    fiAV = tDBElement.TVEpisode.FileInfo
            End Select
            Dim tVideo As MediaInfo.Video = NFO.GetBestVideo(fiAV)
            Dim tAudio As MediaInfo.Audio = NFO.GetBestAudio(fiAV, False)

            Dim vresFlag As APIXML.Flag = APIXML.lFlags.FirstOrDefault(Function(f) f.Name = NFO.GetResFromDimensions(tVideo).ToLower AndAlso f.Type = APIXML.FlagType.VideoResolution)
            If vresFlag IsNot Nothing Then
                strRow = strRow.Replace("<$FLAG_VRES>", String.Concat("flags", Path.DirectorySeparatorChar, Path.GetFileName(vresFlag.Path))).Replace("\", "/")
            Else
                vresFlag = APIXML.lFlags.FirstOrDefault(Function(f) f.Name = "defaultscreen" AndAlso f.Type = APIXML.FlagType.VideoResolution)
                If vresFlag IsNot Nothing Then
                    strRow = strRow.Replace("<$FLAG_VRES>", String.Concat("flags", Path.DirectorySeparatorChar, Path.GetFileName(vresFlag.Path))).Replace("\", "/")
                End If
            End If

            'Dim vsourceFlag As APIXML.Flag = APIXML.lFlags.FirstOrDefault(Function(f) f.Name = APIXML.GetFileSource(AVMovie.Filename) AndAlso f.Type = APIXML.FlagType.VideoSource)
            Dim vsourceFlag As APIXML.Flag = APIXML.lFlags.FirstOrDefault(Function(f) f.Name.ToLower = tDBElement.VideoSource AndAlso f.Type = APIXML.FlagType.VideoSource)
            If vsourceFlag IsNot Nothing Then
                strRow = strRow.Replace("<$FLAG_VSOURCE>", String.Concat("flags", Path.DirectorySeparatorChar, Path.GetFileName(vsourceFlag.Path))).Replace("\", "/")
            Else
                vsourceFlag = APIXML.lFlags.FirstOrDefault(Function(f) f.Name = "defaultscreen" AndAlso f.Type = APIXML.FlagType.VideoSource)
                If vsourceFlag IsNot Nothing Then
                    strRow = strRow.Replace("<$FLAG_VSOURCE>", String.Concat("flags", Path.DirectorySeparatorChar, Path.GetFileName(vsourceFlag.Path))).Replace("\", "/")
                End If
            End If

            Dim vcodecFlag As APIXML.Flag = APIXML.lFlags.FirstOrDefault(Function(f) f.Name = tVideo.Codec.ToLower AndAlso f.Type = APIXML.FlagType.VideoCodec)
            If vcodecFlag IsNot Nothing Then
                strRow = strRow.Replace("<$FLAG_VTYPE>", String.Concat("flags", Path.DirectorySeparatorChar, Path.GetFileName(vcodecFlag.Path))).Replace("\", "/")
            Else
                vcodecFlag = APIXML.lFlags.FirstOrDefault(Function(f) f.Name = "defaultscreen" AndAlso f.Type = APIXML.FlagType.VideoCodec)
                If vcodecFlag IsNot Nothing Then
                    strRow = strRow.Replace("<$FLAG_VTYPE>", String.Concat("flags", Path.DirectorySeparatorChar, Path.GetFileName(vcodecFlag.Path))).Replace("\", "/")
                End If
            End If

            Dim acodecFlag As APIXML.Flag = APIXML.lFlags.FirstOrDefault(Function(f) f.Name = tAudio.Codec.ToLower AndAlso f.Type = APIXML.FlagType.AudioCodec)
            If acodecFlag IsNot Nothing Then
                strRow = strRow.Replace("<$FLAG_ATYPE>", String.Concat("flags", Path.DirectorySeparatorChar, Path.GetFileName(acodecFlag.Path))).Replace("\", "/")
            Else
                acodecFlag = APIXML.lFlags.FirstOrDefault(Function(f) f.Name = "defaultaudio" AndAlso f.Type = APIXML.FlagType.AudioCodec)
                If acodecFlag IsNot Nothing Then
                    strRow = strRow.Replace("<$FLAG_ATYPE>", String.Concat("flags", Path.DirectorySeparatorChar, Path.GetFileName(acodecFlag.Path))).Replace("\", "/")
                End If
            End If

            Dim achanFlag As APIXML.Flag = APIXML.lFlags.FirstOrDefault(Function(f) f.Name = tAudio.Channels AndAlso f.Type = APIXML.FlagType.AudioChan)
            If achanFlag IsNot Nothing Then
                strRow = strRow.Replace("<$FLAG_ACHAN>", String.Concat("flags", Path.DirectorySeparatorChar, Path.GetFileName(achanFlag.Path))).Replace("\", "/")
            Else
                achanFlag = APIXML.lFlags.FirstOrDefault(Function(f) f.Name = "defaultaudio" AndAlso f.Type = APIXML.FlagType.AudioChan)
                If achanFlag IsNot Nothing Then
                    strRow = strRow.Replace("<$FLAG_ACHAN>", String.Concat("flags", Path.DirectorySeparatorChar, Path.GetFileName(achanFlag.Path))).Replace("\", "/")
                End If
            End If
        End If
        Return strRow
    End Function

    Private Function GetFileSize(ByVal fPath As String) As String
        Dim fSize As Long = 0
        If StringUtils.IsStacked(Path.GetFileNameWithoutExtension(fPath), True) OrElse FileUtils.Common.isVideoTS(fPath) OrElse FileUtils.Common.isBDRip(fPath) Then
            Try
                Dim sExt As String = Path.GetExtension(fPath).ToLower
                Dim oFile As String = StringUtils.CleanStackingMarkers(fPath, False)
                Dim sFile As New List(Of String)
                Dim bIsVTS As Boolean = False

                If sExt = ".ifo" OrElse sExt = ".bup" OrElse sExt = ".vob" Then
                    bIsVTS = True
                End If

                If bIsVTS Then
                    Try
                        sFile.AddRange(Directory.GetFiles(Directory.GetParent(fPath).FullName, "VTS*.VOB"))
                    Catch
                    End Try
                ElseIf sExt = ".m2ts" Then
                    Try
                        sFile.AddRange(Directory.GetFiles(Directory.GetParent(fPath).FullName, "*.m2ts"))
                    Catch
                    End Try
                Else
                    Try
                        sFile.AddRange(Directory.GetFiles(Directory.GetParent(fPath).FullName, StringUtils.CleanStackingMarkers(Path.GetFileName(fPath), True)))
                    Catch
                    End Try
                End If

                For Each tFile As String In sFile
                    fSize += New FileInfo(tFile).Length
                Next
            Catch ex As Exception
            End Try
        Else
            fSize = New FileInfo(fPath).Length
        End If

        Select Case fSize
            Case 0 To 1023
                Return fSize & " Bytes"
            Case 1024 To 1048575
                Return String.Concat((fSize / 1024).ToString("###0.00"), " KB")
            Case 1048576 To 1043741824
                Return String.Concat((fSize / 1024 ^ 2).ToString("###0.00"), " MB")
            Case Is > 1043741824
                Return String.Concat((fSize / 1024 ^ 3).ToString("###0.00"), " GB")
        End Select

        Return "0 bytes"
    End Function

    Private Function ProcessPattern_Movie(ByVal tContentPart As ContentPart, ByVal tMovie As Database.DBElement) As String
        Dim strRow As String = tContentPart.Content

        Dim tVid As New MediaInfo.Video
        Dim tAud As New MediaInfo.Audio
        Dim tRes As String = String.Empty

        Dim _audBitrate As String = String.Empty
        Dim _audChannels As String = String.Empty
        Dim _audDetails As String = String.Empty
        Dim _audLanguage As String = String.Empty
        Dim _audLongLanguage As String = String.Empty
        Dim _subLanguage As String = String.Empty
        Dim _subLongLanguage As String = String.Empty
        Dim _subType As String = String.Empty
        Dim _vidAspect As String = String.Empty
        Dim _vidBitrate As String = String.Empty
        Dim _vidDetails As String = String.Empty
        Dim _vidDimensions As String = String.Empty
        Dim _vidDuration As String = String.Empty
        Dim _vidFileSize As String = String.Empty
        Dim _vidHeight As String = String.Empty
        Dim _vidLanguage As String = String.Empty
        Dim _vidLongLanguage As String = String.Empty
        Dim _vidMultiViewCount As String = String.Empty
        Dim _vidMultiViewLayout As String = String.Empty
        Dim _vidScantype As String = String.Empty
        Dim _vidStereoMode As String = String.Empty
        Dim _vidWidth As String = String.Empty

        'FileInfo
        If tMovie.Movie.FileInfo IsNot Nothing Then
            If tMovie.Movie.FileInfo.StreamDetails.Video.Count > 0 Then
                tVid = NFO.GetBestVideo(tMovie.Movie.FileInfo)
                tRes = NFO.GetResFromDimensions(tVid)

                _vidBitrate = tVid.Bitrate
                _vidFileSize = CStr(tVid.Filesize)
                _vidMultiViewCount = tVid.MultiViewCount
                _vidMultiViewLayout = tVid.MultiViewLayout
                _vidAspect = tVid.Aspect
                _vidDuration = tVid.Duration
                _vidHeight = tVid.Height
                _vidLanguage = tVid.Language
                _vidLongLanguage = tVid.LongLanguage
                _vidScantype = tVid.Scantype
                _vidStereoMode = tVid.StereoMode
                _vidWidth = tVid.Width
                _vidDetails = String.Format("{0} / {1}", If(String.IsNullOrEmpty(tRes), Master.eLang.GetString(138, "Unknown"), tRes), If(String.IsNullOrEmpty(tVid.Codec), Master.eLang.GetString(138, "Unknown"), tVid.Codec)).ToUpper
                _vidDimensions = NFO.GetDimensionsFromVideo(tVid)
            End If

            If tMovie.Movie.FileInfo.StreamDetails.Audio.Count > 0 Then
                tAud = NFO.GetBestAudio(tMovie.Movie.FileInfo, False)

                _audBitrate = tAud.Bitrate
                _audChannels = tAud.Channels
                _audLanguage = tAud.Language
                _audLongLanguage = tAud.LongLanguage
                _audDetails = String.Format("{0}ch / {1}", If(String.IsNullOrEmpty(tAud.Channels), Master.eLang.GetString(138, "Unknown"), tAud.Channels), If(String.IsNullOrEmpty(tAud.Codec), Master.eLang.GetString(138, "Unknown"), tAud.Codec)).ToUpper
            End If

            If tMovie.Movie.FileInfo.StreamDetails.Subtitle.Count > 0 Then
                Dim subtitleinfo As MediaInfo.Subtitle
                For c = 0 To tMovie.Movie.FileInfo.StreamDetails.Subtitle.Count - 1
                    subtitleinfo = tMovie.Movie.FileInfo.StreamDetails.Subtitle(c)
                    If Not subtitleinfo Is Nothing Then
                        If Not String.IsNullOrEmpty(subtitleinfo.Language) Then
                            _subLanguage = _subLanguage & ";" & subtitleinfo.Language
                        End If
                        If Not String.IsNullOrEmpty(subtitleinfo.LongLanguage) Then
                            _subLongLanguage = _subLongLanguage & ";" & subtitleinfo.LongLanguage
                        End If
                        If Not String.IsNullOrEmpty(subtitleinfo.SubsType) Then
                            _subType = _subType & ";" & subtitleinfo.SubsType
                        End If
                    End If
                Next
            End If
        End If

        'Special Strings
        strRow = strRow.Replace("<$COUNT>", tCounter_Global.ToString)
        strRow = strRow.Replace("<$DIRNAME>", StringUtils.HtmlEncode(Path.GetDirectoryName(tMovie.Filename)))
        strRow = strRow.Replace("<$FILENAME>", StringUtils.HtmlEncode(Path.GetFileName(tMovie.Filename)))
        strRow = strRow.Replace("<$NOW>", System.DateTime.Now.ToLongDateString) 'Save Build Date. might be useful info!
        strRow = strRow.Replace("<$PATH>", String.Empty)
        strRow = strRow.Replace("<$FILESIZE>", StringUtils.HtmlEncode(GetFileSize(tMovie.Filename)))

        'Images
        With tMovie.ImagesContainer
            strRow = strRow.Replace("<$BANNER_FILE>", ExportImage(.Banner, Enums.ModifierType.MainBanner))
            strRow = strRow.Replace("<$CLEARART_FILE>", ExportImage(.ClearArt, Enums.ModifierType.MainClearArt))
            strRow = strRow.Replace("<$CLEARLOGO_FILE>", ExportImage(.ClearLogo, Enums.ModifierType.MainClearLogo))
            strRow = strRow.Replace("<$DISCART_FILE>", ExportImage(.DiscArt, Enums.ModifierType.MainDiscArt))
            strRow = strRow.Replace("<$FANART_FILE>", ExportImage(.Fanart, Enums.ModifierType.MainFanart))
            strRow = strRow.Replace("<$LANDSCAPE_FILE>", ExportImage(.Landscape, Enums.ModifierType.MainLandscape))
            strRow = strRow.Replace("<$POSTER_FILE>", ExportImage(.Poster, Enums.ModifierType.MainPoster))
        End With

        'Title
        Dim Title As String = String.Empty
        If Not String.IsNullOrEmpty(tMovie.Movie.Title) Then
            Title = tMovie.Movie.Title
        Else
            Title = tMovie.ListTitle
        End If

        'Actors
        Dim ActorsList As New List(Of String)
        For Each tActor As MediaContainers.Person In tMovie.Movie.Actors
            ActorsList.Add(tActor.Name)
        Next

        'Fields
        strRow = strRow.Replace("<$ACTORS>", StringUtils.HtmlEncode(String.Join(", ", ActorsList.ToArray)))
        strRow = strRow.Replace("<$CERTIFICATIONS>", StringUtils.HtmlEncode(String.Join(" / ", tMovie.Movie.Certifications.ToArray)))
        strRow = strRow.Replace("<$COUNTRIES>", StringUtils.HtmlEncode(String.Join(" / ", tMovie.Movie.Countries.ToArray)))
        strRow = strRow.Replace("<$CREDITS>", StringUtils.HtmlEncode(String.Join(" / ", tMovie.Movie.Credits.ToArray)))
        strRow = strRow.Replace("<$DATEADDED>", StringUtils.HtmlEncode(Functions.ConvertFromUnixTimestamp(tMovie.DateAdded).ToString("dd.MM.yyyy")))
        strRow = strRow.Replace("<$DATEMODIFIED>", StringUtils.HtmlEncode(Functions.ConvertFromUnixTimestamp(tMovie.DateModified).ToString("dd.MM.yyyy")))
        strRow = strRow.Replace("<$DIRECTORS>", StringUtils.HtmlEncode(String.Join(" / ", tMovie.Movie.Directors.ToArray)))
        strRow = strRow.Replace("<$GENRES>", StringUtils.HtmlEncode(String.Join(" / ", tMovie.Movie.Genres.ToArray)))
        strRow = strRow.Replace("<$IMDBID>", StringUtils.HtmlEncode(tMovie.Movie.ID))
        strRow = strRow.Replace("<$LANGUAGE>", StringUtils.HtmlEncode(tMovie.Movie.Language))
        strRow = strRow.Replace("<$LASTPLAYED>", StringUtils.HtmlEncode(tMovie.Movie.LastPlayed))
        strRow = strRow.Replace("<$LISTTITLE>", StringUtils.HtmlEncode(tMovie.ListTitle))
        strRow = strRow.Replace("<$MPAA>", StringUtils.HtmlEncode(tMovie.Movie.MPAA))
        strRow = strRow.Replace("<$ORIGINALTITLE>", StringUtils.HtmlEncode(tMovie.Movie.OriginalTitle))
        strRow = strRow.Replace("<$OUTLINE>", StringUtils.HtmlEncode(tMovie.Movie.Outline))
        strRow = strRow.Replace("<$PLAYCOUNT>", CStr(tMovie.Movie.PlayCount))
        strRow = strRow.Replace("<$PLOT>", StringUtils.HtmlEncode(tMovie.Movie.Plot))
        strRow = strRow.Replace("<$RATING>", StringUtils.HtmlEncode(If(tMovie.Movie.RatingSpecified, Double.Parse(tMovie.Movie.Rating, Globalization.CultureInfo.InvariantCulture).ToString("N1", Globalization.CultureInfo.CurrentCulture), String.Empty)))
        strRow = strRow.Replace("<$RELEASEDATE>", StringUtils.HtmlEncode(tMovie.Movie.ReleaseDate))
        strRow = strRow.Replace("<$RUNTIME>", StringUtils.HtmlEncode(tMovie.Movie.Runtime))
        strRow = strRow.Replace("<$STUDIOS>", StringUtils.HtmlEncode(String.Join(" / ", tMovie.Movie.Studios.ToArray)))
        strRow = strRow.Replace("<$TAGLINE>", StringUtils.HtmlEncode(tMovie.Movie.Tagline))
        strRow = strRow.Replace("<$TAGS>", If(tMovie.Movie.TagsSpecified, StringUtils.HtmlEncode((String.Join(" / ", tMovie.Movie.Tags.ToArray))), String.Empty))
        strRow = strRow.Replace("<$TITLE>", StringUtils.HtmlEncode(Title))
        strRow = strRow.Replace("<$TMDBCOLID>", StringUtils.HtmlEncode(tMovie.Movie.TMDBColID))
        strRow = strRow.Replace("<$TMDBID>", StringUtils.HtmlEncode(tMovie.Movie.TMDBID))
        strRow = strRow.Replace("<$TOP250>", StringUtils.HtmlEncode(tMovie.Movie.Top250))
        strRow = strRow.Replace("<$TRAILER>", StringUtils.HtmlEncode(tMovie.Movie.Trailer))
        strRow = strRow.Replace("<$VIDEOSOURCE>", StringUtils.HtmlEncode(tMovie.Movie.VideoSource))
        strRow = strRow.Replace("<$VOTES>", StringUtils.HtmlEncode(If(tMovie.Movie.VotesSpecified, Double.Parse(tMovie.Movie.Votes, Globalization.CultureInfo.InvariantCulture).ToString("N0", Globalization.CultureInfo.CurrentCulture), String.Empty)))
        strRow = strRow.Replace("<$YEAR>", tMovie.Movie.Year)

        'Audio
        strRow = strRow.Replace("<$AUDIO>", _audDetails)
        strRow = strRow.Replace("<$AUDIOBITRATE>", _audBitrate)
        strRow = strRow.Replace("<$AUDIOCHANNELS>", _audChannels)
        strRow = strRow.Replace("<$AUDIOLANGUAGE>", _audLanguage)
        strRow = strRow.Replace("<$AUDIOLONGLANGUAGE>", _audLongLanguage)

        'Video
        strRow = strRow.Replace("<$VIDEO>", _vidDetails)
        strRow = strRow.Replace("<$VIDEOASPECT>", _vidAspect)
        strRow = strRow.Replace("<$VIDEOBITRATE>", _vidBitrate)
        strRow = strRow.Replace("<$VIDEODIMENSIONS>", _vidDimensions)
        strRow = strRow.Replace("<$VIDEODURATION>", _vidDuration)
        strRow = strRow.Replace("<$VIDEOFILESIZE>", _vidFileSize)
        strRow = strRow.Replace("<$VIDEOHEIGHT>", _vidHeight)
        strRow = strRow.Replace("<$VIDEOLANGUAGE>", _vidLanguage)
        strRow = strRow.Replace("<$VIDEOLONGLANGUAGE>", _vidLongLanguage)
        strRow = strRow.Replace("<$VIDEOMULTIVIEW>", _vidMultiViewCount)
        strRow = strRow.Replace("<$VIDEOSCANTYPE>", _vidScantype)
        strRow = strRow.Replace("<$VIDEOSTEREOMODE>", _vidStereoMode)
        strRow = strRow.Replace("<$VIDEOWIDTH>", _vidWidth)

        'Subtitle
        strRow = strRow.Replace("<$SUBTITLELANGUAGE>", _subLanguage)
        strRow = strRow.Replace("<$SUBTITLELONGLANGUAGE>", _subLongLanguage)
        strRow = strRow.Replace("<$SUBTITLETYPE>", _subType)

        'cocotus, 2013/02 Added support for new MediaInfo-fields
        'Row = Row.Replace("<$MOVIESETS>", StringUtils.HtmlEncode(AllMovieSetList)) 'A long string of all moviesets, seperated with ;!
        'strRow = strRow.Replace("<$TVSHOWS>", StringUtils.HtmlEncode(AllTVShowList)) 'A long string of all tvshows, seperated with |!
        'strRow = strRow.Replace("<$SET>", StringUtils.HtmlEncode(GetMovieSets(tMovie))) 'All sets which movie belongs to, seperated with ;!

        'Flags
        strRow = GetAVImages(tMovie, strRow, Enums.ContentType.Movie)

        Return strRow
    End Function

    Private Function ProcessPattern_Settings(ByVal strPattern As String) As String
        tExportSettings.Clear()

        Dim regSettings As Match = Regex.Match(strPattern, "<exportsettings>.*?</exportsettings>", RegexOptions.Singleline)
        If regSettings.Success Then
            Dim xmlSer As XmlSerializer = Nothing
            Using xmlSR As TextReader = New StringReader(regSettings.Value)
                xmlSer = New XmlSerializer(GetType(ExportSettings))
                tExportSettings = DirectCast(xmlSer.Deserialize(xmlSR), ExportSettings)
            End Using
            strPattern = strPattern.Replace(regSettings.Value, String.Empty)
        End If

        Return strPattern
    End Function

    Private Function ProcessPattern_TVEpisode(ByVal tContentPart As ContentPart, ByVal tShow As Database.DBElement, ByVal tEpisode As Database.DBElement) As String
        Dim strRow As String = tContentPart.Content

        'Special Strings
        strRow = strRow.Replace("<$COUNT>", tCounter_Global.ToString)
        strRow = strRow.Replace("<$COUNT_TVSEASON>", tCounter_TVSeason.ToString)
        strRow = strRow.Replace("<$COUNT_TVEPISODE>", tCounter_TVEpisode.ToString)
        strRow = strRow.Replace("<$MISSING>", If(tEpisode.FilenameID = -1, "true", "false"))

        'Images
        With tEpisode.ImagesContainer
            strRow = strRow.Replace("<$FANART_FILE>", ExportImage(.Fanart, Enums.ModifierType.EpisodeFanart))
            strRow = strRow.Replace("<$POSTER_FILE>", ExportImage(.Poster, Enums.ModifierType.EpisodePoster))
        End With

        'Actors
        Dim ActorsList_Episode As New List(Of String)
        For Each tActor As MediaContainers.Person In tEpisode.TVEpisode.Actors
            ActorsList_Episode.Add(tActor.Name)
        Next

        'Guest Stars
        Dim GuestStarsList_Episode As New List(Of String)
        For Each tActor As MediaContainers.Person In tEpisode.TVEpisode.GuestStars
            GuestStarsList_Episode.Add(tActor.Name)
        Next

        'Fields
        strRow = strRow.Replace("<$ACTORS>", StringUtils.HtmlEncode(String.Join(", ", ActorsList_Episode.ToArray)))
        strRow = strRow.Replace("<$AIRED>", StringUtils.HtmlEncode(tEpisode.TVEpisode.Aired))
        strRow = strRow.Replace("<$CREDITS>", StringUtils.HtmlEncode(String.Join(" / ", tEpisode.TVEpisode.Credits.ToArray)))
        strRow = strRow.Replace("<$DATEADDED>", StringUtils.HtmlEncode(Functions.ConvertFromUnixTimestamp(tEpisode.DateAdded).ToString("dd.MM.yyyy")))
        strRow = strRow.Replace("<$DIRECTORS>", StringUtils.HtmlEncode(String.Join(" / ", tEpisode.TVEpisode.Directors.ToArray)))
        strRow = strRow.Replace("<$EPISODE>", StringUtils.HtmlEncode(CStr(tEpisode.TVEpisode.Episode)))
        strRow = strRow.Replace("<$GUESTSTARS>", StringUtils.HtmlEncode(String.Join(" / ", GuestStarsList_Episode.ToArray)))
        strRow = strRow.Replace("<$IMDBID>", StringUtils.HtmlEncode(tEpisode.TVEpisode.IMDB))
        strRow = strRow.Replace("<$LASTPLAYED>", StringUtils.HtmlEncode(tEpisode.TVEpisode.LastPlayed))
        strRow = strRow.Replace("<$PLOT>", StringUtils.HtmlEncode(tEpisode.TVEpisode.Plot))
        strRow = strRow.Replace("<$RATING>", StringUtils.HtmlEncode(If(tEpisode.TVEpisode.RatingSpecified, Double.Parse(tEpisode.TVEpisode.Rating, Globalization.CultureInfo.InvariantCulture).ToString("N1", Globalization.CultureInfo.CurrentCulture), String.Empty)))
        strRow = strRow.Replace("<$RUNTIME>", StringUtils.HtmlEncode(tEpisode.TVEpisode.Runtime))
        strRow = strRow.Replace("<$SEASON>", StringUtils.HtmlEncode(CStr(tEpisode.TVEpisode.Season)))
        strRow = strRow.Replace("<$TITLE>", StringUtils.HtmlEncode(tEpisode.TVEpisode.Title))
        strRow = strRow.Replace("<$TMDBID>", StringUtils.HtmlEncode(tEpisode.TVEpisode.TMDB))
        strRow = strRow.Replace("<$TVDBID>", StringUtils.HtmlEncode(tEpisode.TVEpisode.TVDB))
        strRow = strRow.Replace("<$VIDEOSOURCE>", StringUtils.HtmlEncode(tEpisode.TVEpisode.VideoSource))
        strRow = strRow.Replace("<$VOTES>", StringUtils.HtmlEncode(If(tEpisode.TVEpisode.VotesSpecified, Double.Parse(tEpisode.TVEpisode.Votes, Globalization.CultureInfo.InvariantCulture).ToString("N0", Globalization.CultureInfo.CurrentCulture), String.Empty)))

        'Flags
        strRow = GetAVImages(tShow, strRow, Enums.ContentType.TVEpisode)

        Return strRow
    End Function

    Private Function ProcessPattern_TVSeason(ByVal tContentPart As ContentPart, ByVal tShow As Database.DBElement, ByVal tSeason As Database.DBElement) As String
        Dim strRow As String = tContentPart.Content

        If tContentPart.innerContentPartMap IsNot Nothing Then
            strRow = Build_HTML(DirectCast(tContentPart.innerContentPartMap, List(Of ContentPart)), tShow, tSeason).ToString
        End If

        'Special Strings
        strRow = strRow.Replace("<$COUNT>", tCounter_Global.ToString)
        strRow = strRow.Replace("<$COUNT_TVSEASON>", tCounter_TVSeason.ToString)

        'Images
        With tSeason.ImagesContainer
            strRow = strRow.Replace("<$BANNER_FILE>", ExportImage(.Banner, Enums.ModifierType.SeasonBanner))
            strRow = strRow.Replace("<$FANART_FILE>", ExportImage(.Fanart, Enums.ModifierType.SeasonFanart))
            strRow = strRow.Replace("<$LANDSCAPE_FILE>", ExportImage(.Landscape, Enums.ModifierType.SeasonLandscape))
            strRow = strRow.Replace("<$POSTER_FILE>", ExportImage(.Poster, Enums.ModifierType.SeasonPoster))
        End With

        'Fields
        strRow = strRow.Replace("<$AIRED>", StringUtils.HtmlEncode(tSeason.TVSeason.Aired))
        strRow = strRow.Replace("<$EPISODES>", StringUtils.HtmlEncode(CStr(tShow.Episodes.Where(Function(f) f.TVEpisode.Season = tSeason.TVSeason.Season).Count)))
        strRow = strRow.Replace("<$PLOT>", StringUtils.HtmlEncode(tSeason.TVSeason.Plot))
        strRow = strRow.Replace("<$SEASON>", StringUtils.HtmlEncode(CStr(tSeason.TVSeason.Season)))
        strRow = strRow.Replace("<$TITLE>", StringUtils.HtmlEncode(tSeason.TVSeason.Title))
        strRow = strRow.Replace("<$TMDBID>", StringUtils.HtmlEncode(tSeason.TVSeason.TMDB))
        strRow = strRow.Replace("<$TVDBID>", StringUtils.HtmlEncode(tSeason.TVSeason.TVDB))

        Return strRow
    End Function

    Private Function ProcessPattern_TVShow(ByVal tContentPart As ContentPart, ByVal tShow As Database.DBElement) As String
        Dim strRow As String = tContentPart.Content

        If tContentPart.innerContentPartMap IsNot Nothing Then
            strRow = Build_HTML(DirectCast(tContentPart.innerContentPartMap, List(Of ContentPart)), tShow).ToString
        End If

        'Special Strings
        strRow = strRow.Replace("<$COUNT>", tCounter_Global.ToString)
        strRow = strRow.Replace("<$NOW>", System.DateTime.Now.ToLongDateString) 'Save Build Date. might be useful info!
        strRow = strRow.Replace("<$PATH>", StringUtils.HtmlEncode(tShow.ShowPath))

        'Images
        With tShow.ImagesContainer
            strRow = strRow.Replace("<$BANNER_FILE>", ExportImage(.Banner, Enums.ModifierType.MainBanner))
            strRow = strRow.Replace("<$CHARACTERART_FILE>", ExportImage(.CharacterArt, Enums.ModifierType.MainCharacterArt))
            strRow = strRow.Replace("<$CLEARART_FILE>", ExportImage(.ClearArt, Enums.ModifierType.MainClearArt))
            strRow = strRow.Replace("<$CLEARLOGO_FILE>", ExportImage(.ClearLogo, Enums.ModifierType.MainClearLogo))
            strRow = strRow.Replace("<$FANART_FILE>", ExportImage(.Fanart, Enums.ModifierType.MainFanart))
            strRow = strRow.Replace("<$LANDSCAPE_FILE>", ExportImage(.Landscape, Enums.ModifierType.MainLandscape))
            strRow = strRow.Replace("<$POSTER_FILE>", ExportImage(.Poster, Enums.ModifierType.MainPoster))
        End With

        'Title
        Dim Title As String = String.Empty
        If Not String.IsNullOrEmpty(tShow.TVShow.Title) Then
            Title = tShow.TVShow.Title
        Else
            Title = tShow.ListTitle
        End If

        'Actors
        Dim ActorsList As New List(Of String)
        For Each tActor As MediaContainers.Person In tShow.TVShow.Actors
            ActorsList.Add(tActor.Name)
        Next

        'Fields
        strRow = strRow.Replace("<$ACTORS>", StringUtils.HtmlEncode(String.Join(", ", ActorsList.ToArray)))
        strRow = strRow.Replace("<$CERTIFICATIONS>", StringUtils.HtmlEncode(String.Join(" / ", tShow.TVShow.Certifications.ToArray)))
        strRow = strRow.Replace("<$COUNTRIES>", StringUtils.HtmlEncode(String.Join(" / ", tShow.TVShow.Countries.ToArray)))
        strRow = strRow.Replace("<$CREATORS>", StringUtils.HtmlEncode(String.Join(" / ", tShow.TVShow.Creators.ToArray)))
        strRow = strRow.Replace("<$DATEADDED>", StringUtils.HtmlEncode(Functions.ConvertFromUnixTimestamp(tShow.DateAdded).ToString("dd.MM.yyyy")))
        strRow = strRow.Replace("<$DATEMODIFIED>", StringUtils.HtmlEncode(Functions.ConvertFromUnixTimestamp(tShow.DateModified).ToString("dd.MM.yyyy")))
        strRow = strRow.Replace("<$DIRECTORS>", StringUtils.HtmlEncode(String.Join(" / ", tShow.TVShow.Directors.ToArray)))
        strRow = strRow.Replace("<$GENRES>", StringUtils.HtmlEncode(String.Join(" / ", tShow.TVShow.Genres.ToArray)))
        strRow = strRow.Replace("<$IMDBID>", StringUtils.HtmlEncode(tShow.TVShow.IMDB))
        strRow = strRow.Replace("<$LANGUAGE>", StringUtils.HtmlEncode(tShow.TVShow.Language))
        strRow = strRow.Replace("<$LISTTITLE>", StringUtils.HtmlEncode(tShow.ListTitle))
        strRow = strRow.Replace("<$MPAA>", StringUtils.HtmlEncode(tShow.TVShow.MPAA))
        strRow = strRow.Replace("<$ORIGINALTITLE>", StringUtils.HtmlEncode(tShow.TVShow.OriginalTitle))
        strRow = strRow.Replace("<$PLOT>", StringUtils.HtmlEncode(tShow.TVShow.Plot))
        strRow = strRow.Replace("<$PREMIERED>", StringUtils.HtmlEncode(tShow.TVShow.Premiered))
        strRow = strRow.Replace("<$RATING>", StringUtils.HtmlEncode(If(tShow.TVShow.RatingSpecified, Double.Parse(tShow.TVShow.Rating, Globalization.CultureInfo.InvariantCulture).ToString("N1", Globalization.CultureInfo.CurrentCulture), String.Empty)))
        strRow = strRow.Replace("<$RUNTIME>", StringUtils.HtmlEncode(tShow.TVShow.Runtime))
        strRow = strRow.Replace("<$STATUS>", StringUtils.HtmlEncode(tShow.TVShow.Status))
        strRow = strRow.Replace("<$STUDIOS>", StringUtils.HtmlEncode(String.Join(" / ", tShow.TVShow.Studios.ToArray)))
        strRow = strRow.Replace("<$TAGS>", If(tShow.TVShow.TagsSpecified, StringUtils.HtmlEncode((String.Join(" / ", tShow.TVShow.Tags.ToArray))), String.Empty))
        strRow = strRow.Replace("<$TITLE>", StringUtils.HtmlEncode(Title))
        strRow = strRow.Replace("<$TMDBID>", StringUtils.HtmlEncode(tShow.TVShow.TMDB))
        strRow = strRow.Replace("<$TVDBID>", tShow.TVShow.TVDB)
        strRow = strRow.Replace("<$VOTES>", StringUtils.HtmlEncode(If(tShow.TVShow.VotesSpecified, Double.Parse(tShow.TVShow.Votes, Globalization.CultureInfo.InvariantCulture).ToString("N0", Globalization.CultureInfo.CurrentCulture), String.Empty)))

        Return strRow
    End Function

#End Region 'Methods

#Region "Nested Types"

    Private Structure Arguments
        Dim destPath As String
        Dim resizePoster As Integer
        Dim srcPath As String
    End Structure

    Private Structure ContentPart
        Dim Content As String
        Dim ContentType As Enums.ContentType
        Dim innerContentPartMap As Object
        Dim isLooped As Boolean
    End Structure

    <Serializable()>
    <XmlRoot("exportsettings")>
    Class ExportSettings

#Region "Fields"

        Private _episodeposters As Boolean
        Private _episodeposters_maxheight As Integer
        Private _episodeposters_maxwidth As Integer
        Private _episodefanarts As Boolean
        Private _episodefanarts_maxheight As Integer
        Private _episodefanarts_maxwidth As Integer
        Private _flags As Boolean
        Private _mainbanners As Boolean
        Private _mainbanners_maxheight As Integer
        Private _mainbanners_maxwidth As Integer
        Private _maincharacterarts As Boolean
        Private _maincleararts As Boolean
        Private _mainclearlogos As Boolean
        Private _maindiscarts As Boolean
        Private _mainfanarts As Boolean
        Private _mainfanarts_maxheight As Integer
        Private _mainfanarts_maxwidth As Integer
        Private _mainlandscapes As Boolean
        Private _mainlandscapes_maxheight As Integer
        Private _mainlandscapes_maxwidth As Integer
        Private _mainposters As Boolean
        Private _mainposters_maxheight As Integer
        Private _mainposters_maxwidth As Integer
        Private _note As String
        Private _seasonbanners As Boolean
        Private _seasonbanners_maxheight As Integer
        Private _seasonbanners_maxwidth As Integer
        Private _seasonfanarts As Boolean
        Private _seasonfanarts_maxheight As Integer
        Private _seasonfanarts_maxwidth As Integer
        Private _seasonlandscapes As Boolean
        Private _seasonlandscapes_maxheight As Integer
        Private _seasonlandscapes_maxwidth As Integer
        Private _seasonposters As Boolean
        Private _seasonposters_maxheight As Integer
        Private _seasonposters_maxwidth As Integer

#End Region 'Fields

#Region "Properties"

        <XmlElement("episodefanarts")>
        Public Property EpisodeFanarts() As Boolean
            Get
                Return _episodefanarts
            End Get
            Set(ByVal value As Boolean)
                _episodefanarts = value
            End Set
        End Property

        <XmlElement("episodefanarts_maxheight")>
        Public Property EpisodeFanarts_MaxHeight() As Integer
            Get
                Return _episodefanarts_maxheight
            End Get
            Set(ByVal value As Integer)
                _episodefanarts_maxheight = value
            End Set
        End Property

        <XmlElement("episodefanarts_maxwidth")>
        Public Property EpisodeFanarts_MaxWidth() As Integer
            Get
                Return _episodefanarts_maxwidth
            End Get
            Set(ByVal value As Integer)
                _episodefanarts_maxwidth = value
            End Set
        End Property

        <XmlElement("episodeposters")>
        Public Property EpisodePosters() As Boolean
            Get
                Return _episodeposters
            End Get
            Set(ByVal value As Boolean)
                _episodeposters = value
            End Set
        End Property

        <XmlElement("episodeposters_maxheight")>
        Public Property EpisodePosters_MaxHeight() As Integer
            Get
                Return _episodeposters_maxheight
            End Get
            Set(ByVal value As Integer)
                _episodeposters_maxheight = value
            End Set
        End Property

        <XmlElement("episodeposters_maxwidth")>
        Public Property EpisodePosters_MaxWidth() As Integer
            Get
                Return _episodeposters_maxwidth
            End Get
            Set(ByVal value As Integer)
                _episodeposters_maxwidth = value
            End Set
        End Property

        <XmlElement("flags")>
        Public Property Flags() As Boolean
            Get
                Return _flags
            End Get
            Set(ByVal value As Boolean)
                _flags = value
            End Set
        End Property

        <XmlElement("mainbanners")>
        Public Property MainBanners() As Boolean
            Get
                Return _mainbanners
            End Get
            Set(ByVal value As Boolean)
                _mainbanners = value
            End Set
        End Property

        <XmlElement("mainbanners_maxheight")>
        Public Property MainBanners_MaxHeight() As Integer
            Get
                Return _mainbanners_maxheight
            End Get
            Set(ByVal value As Integer)
                _mainbanners_maxheight = value
            End Set
        End Property

        <XmlElement("mainbanners_maxwidth")>
        Public Property MainBanners_MaxWidth() As Integer
            Get
                Return _mainbanners_maxwidth
            End Get
            Set(ByVal value As Integer)
                _mainbanners_maxwidth = value
            End Set
        End Property

        <XmlElement("maincharacterarts")>
        Public Property MainCharacterarts() As Boolean
            Get
                Return _maincharacterarts
            End Get
            Set(ByVal value As Boolean)
                _maincharacterarts = value
            End Set
        End Property

        <XmlElement("maincleararts")>
        Public Property MainClearArts() As Boolean
            Get
                Return _maincleararts
            End Get
            Set(ByVal value As Boolean)
                _maincleararts = value
            End Set
        End Property

        <XmlElement("mainclearlogos")>
        Public Property MainClearLogos() As Boolean
            Get
                Return _mainclearlogos
            End Get
            Set(ByVal value As Boolean)
                _mainclearlogos = value
            End Set
        End Property

        <XmlElement("maindiscarts")>
        Public Property MainDiscArts() As Boolean
            Get
                Return _maindiscarts
            End Get
            Set(ByVal value As Boolean)
                _maindiscarts = value
            End Set
        End Property

        <XmlElement("mainfanarts")>
        Public Property MainFanarts() As Boolean
            Get
                Return _mainfanarts
            End Get
            Set(ByVal value As Boolean)
                _mainfanarts = value
            End Set
        End Property

        <XmlElement("mainfanarts_maxheight")>
        Public Property MainFanarts_MaxHeight() As Integer
            Get
                Return _mainfanarts_maxheight
            End Get
            Set(ByVal value As Integer)
                _mainfanarts_maxheight = value
            End Set
        End Property

        <XmlElement("mainfanarts_maxwidth")>
        Public Property MainFanarts_MaxWidth() As Integer
            Get
                Return _mainfanarts_maxwidth
            End Get
            Set(ByVal value As Integer)
                _mainfanarts_maxwidth = value
            End Set
        End Property

        <XmlElement("mainlandscapes")>
        Public Property MainLandscapes() As Boolean
            Get
                Return _mainlandscapes
            End Get
            Set(ByVal value As Boolean)
                _mainlandscapes = value
            End Set
        End Property

        <XmlElement("mainlandscapes_maxheight")>
        Public Property MainLandscapes_MaxHeight() As Integer
            Get
                Return _mainlandscapes_maxheight
            End Get
            Set(ByVal value As Integer)
                _mainlandscapes_maxheight = value
            End Set
        End Property

        <XmlElement("mainlandscapes_maxwidth")>
        Public Property MainLandscapes_MaxWidth() As Integer
            Get
                Return _mainlandscapes_maxwidth
            End Get
            Set(ByVal value As Integer)
                _mainlandscapes_maxwidth = value
            End Set
        End Property

        <XmlElement("mainposters")>
        Public Property MainPosters() As Boolean
            Get
                Return _mainposters
            End Get
            Set(ByVal value As Boolean)
                _mainposters = value
            End Set
        End Property

        <XmlElement("mainposters_maxheight")>
        Public Property MainPosters_MaxHeight() As Integer
            Get
                Return _mainposters_maxheight
            End Get
            Set(ByVal value As Integer)
                _mainposters_maxheight = value
            End Set
        End Property

        <XmlElement("mainposters_maxwidth")>
        Public Property MainPosters_MaxWidth() As Integer
            Get
                Return _mainposters_maxwidth
            End Get
            Set(ByVal value As Integer)
                _mainposters_maxwidth = value
            End Set
        End Property

        <XmlElement("note")>
        Public Property Note() As String
            Get
                Return _note
            End Get
            Set(ByVal value As String)
                _note = value
            End Set
        End Property

        <XmlElement("seasonbanners")>
        Public Property SeasonBanners() As Boolean
            Get
                Return _seasonbanners
            End Get
            Set(ByVal value As Boolean)
                _seasonbanners = value
            End Set
        End Property

        <XmlElement("seasonbanners_maxheight")>
        Public Property SeasonBanners_MaxHeight() As Integer
            Get
                Return _seasonbanners_maxheight
            End Get
            Set(ByVal value As Integer)
                _seasonbanners_maxheight = value
            End Set
        End Property

        <XmlElement("seasonbanners_maxwidth")>
        Public Property SeasonBanners_MaxWidth() As Integer
            Get
                Return _seasonbanners_maxwidth
            End Get
            Set(ByVal value As Integer)
                _seasonbanners_maxwidth = value
            End Set
        End Property

        <XmlElement("seasonfanarts")>
        Public Property SeasonFanarts() As Boolean
            Get
                Return _seasonfanarts
            End Get
            Set(ByVal value As Boolean)
                _seasonfanarts = value
            End Set
        End Property

        <XmlElement("seasonfanarts_maxheight")>
        Public Property SeasonFanarts_MaxHeight() As Integer
            Get
                Return _seasonfanarts_maxheight
            End Get
            Set(ByVal value As Integer)
                _seasonfanarts_maxheight = value
            End Set
        End Property

        <XmlElement("seasonfanarts_maxwidth")>
        Public Property SeasonFanarts_MaxWidth() As Integer
            Get
                Return _seasonfanarts_maxwidth
            End Get
            Set(ByVal value As Integer)
                _seasonfanarts_maxwidth = value
            End Set
        End Property

        <XmlElement("seasonlandscapes")>
        Public Property SeasonLandscapes() As Boolean
            Get
                Return _seasonlandscapes
            End Get
            Set(ByVal value As Boolean)
                _seasonlandscapes = value
            End Set
        End Property

        <XmlElement("seasonlandscapes_maxheight")>
        Public Property SeasonLandscapes_MaxHeight() As Integer
            Get
                Return _seasonlandscapes_maxheight
            End Get
            Set(ByVal value As Integer)
                _seasonlandscapes_maxheight = value
            End Set
        End Property

        <XmlElement("seasonlandscapes_maxwidth")>
        Public Property SeasonLandscapes_MaxWidth() As Integer
            Get
                Return _seasonlandscapes_maxwidth
            End Get
            Set(ByVal value As Integer)
                _seasonlandscapes_maxwidth = value
            End Set
        End Property

        <XmlElement("seasonposters")>
        Public Property SeasonPosters() As Boolean
            Get
                Return _seasonposters
            End Get
            Set(ByVal value As Boolean)
                _seasonposters = value
            End Set
        End Property

        <XmlElement("seasonposters_maxheight")>
        Public Property SeasonPosters_MaxHeight() As Integer
            Get
                Return _seasonposters_maxheight
            End Get
            Set(ByVal value As Integer)
                _seasonposters_maxheight = value
            End Set
        End Property

        <XmlElement("seasonposters_maxwidth")>
        Public Property SeasonPosters_MaxWidth() As Integer
            Get
                Return _seasonposters_maxwidth
            End Get
            Set(ByVal value As Integer)
                _seasonposters_maxwidth = value
            End Set
        End Property

#End Region 'Properties

#Region "Constructors"

        Public Sub New()
            Clear()
        End Sub

#End Region 'Constructors

#Region "Methods"

        Public Sub Clear()
            _episodefanarts = False
            _episodefanarts_maxheight = -1
            _episodefanarts_maxwidth = -1
            _episodeposters = False
            _episodeposters_maxheight = -1
            _episodeposters_maxwidth = -1
            _flags = False
            _mainbanners = False
            _mainbanners_maxheight = -1
            _mainbanners_maxwidth = -1
            _maincharacterarts = False
            _maincleararts = False
            _mainclearlogos = False
            _maindiscarts = False
            _mainfanarts = False
            _mainfanarts_maxheight = -1
            _mainfanarts_maxwidth = -1
            _mainlandscapes = False
            _mainlandscapes_maxheight = -1
            _mainlandscapes_maxwidth = -1
            _mainposters = False
            _mainposters_maxheight = -1
            _mainposters_maxwidth = -1
            _note = String.Empty
            _seasonbanners = False
            _seasonbanners_maxheight = -1
            _seasonbanners_maxwidth = -1
            _seasonfanarts = False
            _seasonfanarts_maxheight = -1
            _seasonfanarts_maxwidth = -1
            _seasonlandscapes = False
            _seasonlandscapes_maxheight = -1
            _seasonlandscapes_maxwidth = -1
            _seasonposters = False
            _seasonposters_maxheight = -1
            _seasonposters_maxwidth = -1
        End Sub

#End Region 'Methods

    End Class

#End Region 'Nested Types

End Class
