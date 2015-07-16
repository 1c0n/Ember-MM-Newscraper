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

'TODO: 1.5 - TV Show renaming (including "dump folder")
'TODO: 1.5 - Support VIDEO_TS/BDMV folders for TV Shows

Imports System.IO
Imports System.Text.RegularExpressions
Imports EmberAPI
Imports NLog
Imports System.Diagnostics

Public Class dlgImgSelectTV

#Region "Fields"
    Shared logger As Logger = NLog.LogManager.GetCurrentClassLogger()

    Friend WithEvents bwDownloadFanart As New System.ComponentModel.BackgroundWorker
    Friend WithEvents bwLoadData As New System.ComponentModel.BackgroundWorker
    Friend WithEvents bwLoadImages As New System.ComponentModel.BackgroundWorker

    Private DefaultImagesContainer As New MediaContainers.ImagesContainer
    Private DefaultEpisodeImagesContainer As New List(Of MediaContainers.EpisodeOrSeasonImagesContainer)
    Private DefaultSeasonImagesContainer As New List(Of MediaContainers.EpisodeOrSeasonImagesContainer)
    Private SearchResultsContainer As New MediaContainers.SearchResultsContainer_TV

    Private tmpShowContainer As New Structures.DBTV

    Private iCounter As Integer = 0
    Private iLeft As Integer = 5
    Private iTop As Integer = 5
    Private lblImage() As Label
    Private pbImage() As PictureBox
    Private pnlImage() As Panel
    Private SelImgType As Enums.ImageType_TV
    Private SelSeason As Integer = -999
    Private _id As Integer = -1
    Private _season As Integer = -999
    Private _type As Enums.ImageType_TV = Enums.ImageType_TV.All
    Private _withcurrent As Boolean = True
    Private _ScrapeType As Enums.ScrapeType_Movie_MovieSet_TV

#End Region 'Fields

#Region "Properties"

    Public ReadOnly Property Results As Structures.DBTV
        Get
            Return tmpShowContainer
        End Get
    End Property

#End Region 'Properties

#Region "Methods"

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        Me.Left = Master.AppPos.Left + (Master.AppPos.Width - Me.Width) \ 2
        Me.Top = Master.AppPos.Top + (Master.AppPos.Height - Me.Height) \ 2
        Me.StartPosition = FormStartPosition.Manual
    End Sub

    Public Function SetDefaults() As Boolean
        Dim iSeason As Integer = -1
        Dim iEpisode As Integer = -1
        Dim iProgress As Integer = 11

        Me.bwLoadImages.ReportProgress(tmpShowContainer.Seasons.Count + tmpShowContainer.Episodes.Count + iProgress, "defaults")

        ''AllSeason Banner
        'If (Me._type = Enums.ImageType_TV.All OrElse Me._type = Enums.ImageType_TV.AllSeasonsBanner) AndAlso Master.eSettings.TVASBannerAnyEnabled AndAlso DefaultImagesContainer.SeasonBanner.WebImage.Image Is Nothing Then
        '    Dim defImg As MediaContainers.Image = Nothing
        '    Images.GetPreferredTVASBanner(SearchResultsContainer.SeasonBanners, SearchResultsContainer.ShowBanners, defImg)

        '    If defImg IsNot Nothing Then
        '        DefaultImagesContainer.SeasonBanner = defImg
        '    End If
        'End If
        'If Me.bwLoadImages.CancellationPending Then
        '    Return True
        'End If
        'Me.bwLoadImages.ReportProgress(1, "progress")

        ''AllSeason Fanart
        'If (Me._type = Enums.ImageType_TV.All OrElse Me._type = Enums.ImageType_TV.AllSeasonsFanart) AndAlso Master.eSettings.TVASFanartAnyEnabled AndAlso DefaultImagesContainer.SeasonFanart.WebImage.Image Is Nothing Then
        '    Dim defImg As MediaContainers.Image = Nothing
        '    Images.GetPreferredTVASFanart(SearchResultsContainer.ShowFanarts, defImg)

        '    If defImg IsNot Nothing Then
        '        DefaultImagesContainer.SeasonFanart = defImg
        '    End If
        'End If
        'If Me.bwLoadImages.CancellationPending Then
        '    Return True
        'End If
        'Me.bwLoadImages.ReportProgress(2, "progress")

        ''AllSeason Landscape
        'If (Me._type = Enums.ImageType_TV.All OrElse Me._type = Enums.ImageType_TV.AllSeasonsLandscape) AndAlso Master.eSettings.TVASLandscapeAnyEnabled AndAlso DefaultImagesContainer.SeasonLandscape.WebImage.Image Is Nothing Then
        '    Dim defImg As MediaContainers.Image = Nothing
        '    Images.GetPreferredTVASLandscape(SearchResultsContainer.SeasonLandscapes, SearchResultsContainer.ShowLandscapes, defImg)

        '    If defImg IsNot Nothing Then
        '        DefaultImagesContainer.SeasonLandscape = defImg
        '    End If
        'End If
        'If Me.bwLoadImages.CancellationPending Then
        '    Return True
        'End If
        'Me.bwLoadImages.ReportProgress(3, "progress")

        ''AllSeason Poster
        'If (Me._type = Enums.ImageType_TV.All OrElse Me._type = Enums.ImageType_TV.AllSeasonsPoster) AndAlso Master.eSettings.TVASPosterAnyEnabled AndAlso DefaultImagesContainer.SeasonPoster.WebImage.Image Is Nothing Then
        '    Dim defImg As MediaContainers.Image = Nothing
        '    Images.GetPreferredTVASPoster(SearchResultsContainer.SeasonPosters, SearchResultsContainer.ShowPosters, defImg)

        '    If defImg IsNot Nothing Then
        '        DefaultImagesContainer.SeasonPoster = defImg
        '    End If
        'End If
        'If Me.bwLoadImages.CancellationPending Then
        '    Return True
        'End If
        'Me.bwLoadImages.ReportProgress(4, "progress")

        'Show Banner
        If (Me._type = Enums.ImageType_TV.All OrElse Me._type = Enums.ImageType_TV.ShowBanner) AndAlso Master.eSettings.TVShowBannerAnyEnabled AndAlso tmpShowContainer.ImagesContainer.Banner.WebImage.Image Is Nothing Then
            Dim defImg As MediaContainers.Image = Nothing
            Images.GetPreferredTVShowBanner(SearchResultsContainer.ShowBanners, defImg)

            If defImg IsNot Nothing Then
                DefaultImagesContainer.Banner = defImg
                tmpShowContainer.ImagesContainer.Banner = defImg
            End If
        End If
        If Me.bwLoadImages.CancellationPending Then
            Return True
        End If
        Me.bwLoadImages.ReportProgress(5, "progress")

        'Show CharacterArt
        If (Me._type = Enums.ImageType_TV.All OrElse Me._type = Enums.ImageType_TV.ShowCharacterArt) AndAlso Master.eSettings.TVShowCharacterArtAnyEnabled AndAlso tmpShowContainer.ImagesContainer.CharacterArt.WebImage.Image Is Nothing Then
            Dim defImg As MediaContainers.Image = Nothing
            Images.GetPreferredTVShowCharacterArt(SearchResultsContainer.ShowCharacterArts, defImg)

            If defImg IsNot Nothing Then
                DefaultImagesContainer.CharacterArt = defImg
                tmpShowContainer.ImagesContainer.CharacterArt = defImg
            End If
        End If
        If Me.bwLoadImages.CancellationPending Then
            Return True
        End If
        Me.bwLoadImages.ReportProgress(6, "progress")

        'Show ClearArt
        If (Me._type = Enums.ImageType_TV.All OrElse Me._type = Enums.ImageType_TV.ShowClearArt) AndAlso Master.eSettings.TVShowClearArtAnyEnabled AndAlso tmpShowContainer.ImagesContainer.ClearArt.WebImage.Image Is Nothing Then
            Dim defImg As MediaContainers.Image = Nothing
            Images.GetPreferredTVShowClearArt(SearchResultsContainer.ShowClearArts, defImg)

            If defImg IsNot Nothing Then
                DefaultImagesContainer.ClearArt = defImg
                tmpShowContainer.ImagesContainer.ClearArt = defImg
            End If
        End If
        If Me.bwLoadImages.CancellationPending Then
            Return True
        End If
        Me.bwLoadImages.ReportProgress(7, "progress")

        'Show ClearLogo
        If (Me._type = Enums.ImageType_TV.All OrElse Me._type = Enums.ImageType_TV.ShowClearLogo) AndAlso Master.eSettings.TVShowClearLogoAnyEnabled AndAlso tmpShowContainer.ImagesContainer.ClearLogo.WebImage.Image Is Nothing Then
            Dim defImg As MediaContainers.Image = Nothing
            Images.GetPreferredTVShowClearLogo(SearchResultsContainer.ShowClearLogos, defImg)

            If defImg IsNot Nothing Then
                DefaultImagesContainer.ClearLogo = defImg
                tmpShowContainer.ImagesContainer.ClearLogo = defImg
            End If
        End If
        If Me.bwLoadImages.CancellationPending Then
            Return True
        End If
        Me.bwLoadImages.ReportProgress(8, "progress")

        'Show Fanart
        If (Me._type = Enums.ImageType_TV.All OrElse Me._type = Enums.ImageType_TV.ShowFanart OrElse Me._type = Enums.ImageType_TV.EpisodeFanart) AndAlso tmpShowContainer.ImagesContainer.Fanart.WebImage.Image Is Nothing Then 'TODO: add *FanartEnabled check
            Dim defImg As MediaContainers.Image = Nothing
            Images.GetPreferredTVShowFanart(SearchResultsContainer.ShowFanarts, defImg)

            If defImg IsNot Nothing Then
                DefaultImagesContainer.Fanart = defImg
                tmpShowContainer.ImagesContainer.Fanart = defImg
            End If
        End If
        If Me.bwLoadImages.CancellationPending Then
            Return True
        End If
        Me.bwLoadImages.ReportProgress(9, "progress")

        'Show Landscape
        If (Me._type = Enums.ImageType_TV.All OrElse Me._type = Enums.ImageType_TV.ShowLandscape) AndAlso Master.eSettings.TVShowLandscapeAnyEnabled AndAlso tmpShowContainer.ImagesContainer.Landscape.WebImage.Image Is Nothing Then
            Dim defImg As MediaContainers.Image = Nothing
            Images.GetPreferredTVShowLandscape(SearchResultsContainer.ShowLandscapes, defImg)

            If defImg IsNot Nothing Then
                DefaultImagesContainer.Landscape = defImg
                tmpShowContainer.ImagesContainer.Landscape = defImg
            End If
        End If
        If Me.bwLoadImages.CancellationPending Then
            Return True
        End If
        Me.bwLoadImages.ReportProgress(10, "progress")

        'Show Poster
        If (Me._type = Enums.ImageType_TV.All OrElse Me._type = Enums.ImageType_TV.ShowPoster) AndAlso Master.eSettings.TVShowPosterAnyEnabled AndAlso tmpShowContainer.ImagesContainer.Poster.WebImage.Image Is Nothing Then
            Dim defImg As MediaContainers.Image = Nothing
            Images.GetPreferredTVShowPoster(SearchResultsContainer.ShowPosters, defImg)

            If defImg IsNot Nothing Then
                DefaultImagesContainer.Poster = defImg
                tmpShowContainer.ImagesContainer.Poster = defImg
            End If
        End If
        If Me.bwLoadImages.CancellationPending Then
            Return True
        End If
        Me.bwLoadImages.ReportProgress(11, "progress")

        'Season Banner/Fanart/Poster
        If Me._type = Enums.ImageType_TV.All OrElse Me._type = Enums.ImageType_TV.SeasonPoster OrElse Me._type = Enums.ImageType_TV.SeasonBanner OrElse Me._type = Enums.ImageType_TV.SeasonFanart Then
            For Each cSeason As Structures.DBTV In tmpShowContainer.Seasons
                iSeason = cSeason.TVSeason.Season

                'Season Banner
                If (Me._type = Enums.ImageType_TV.All OrElse Me._type = Enums.ImageType_TV.SeasonBanner) AndAlso Master.eSettings.TVSeasonBannerAnyEnabled AndAlso cSeason.ImagesContainer.Banner.WebImage.Image Is Nothing Then
                    Dim defImg As MediaContainers.Image = Nothing
                    Images.GetPreferredTVSeasonBanner(SearchResultsContainer.SeasonBanners, defImg, iSeason)

                    If defImg IsNot Nothing Then
                        cSeason.ImagesContainer.Banner = defImg
                    End If
                End If

                'Season Fanart
                If (Me._type = Enums.ImageType_TV.All OrElse Me._type = Enums.ImageType_TV.SeasonFanart) AndAlso Master.eSettings.TVSeasonFanartAnyEnabled AndAlso cSeason.ImagesContainer.Fanart.WebImage.Image Is Nothing Then
                    Dim defImg As MediaContainers.Image = Nothing
                    Images.GetPreferredTVSeasonFanart(SearchResultsContainer.SeasonFanarts, SearchResultsContainer.ShowFanarts, defImg, iSeason)

                    If defImg IsNot Nothing Then
                        cSeason.ImagesContainer.Fanart = defImg
                    End If
                End If

                'Season Landscape
                If (Me._type = Enums.ImageType_TV.All OrElse Me._type = Enums.ImageType_TV.SeasonLandscape) AndAlso Master.eSettings.TVSeasonLandscapeAnyEnabled AndAlso cSeason.ImagesContainer.Landscape.WebImage.Image Is Nothing Then
                    Dim defImg As MediaContainers.Image = Nothing
                    Images.GetPreferredTVSeasonLandscape(SearchResultsContainer.SeasonLandscapes, defImg, iSeason)

                    If defImg IsNot Nothing Then
                        cSeason.ImagesContainer.Landscape = defImg
                    End If
                End If

                'Season Poster
                If (Me._type = Enums.ImageType_TV.All OrElse Me._type = Enums.ImageType_TV.SeasonPoster) AndAlso Master.eSettings.TVSeasonPosterAnyEnabled AndAlso cSeason.ImagesContainer.Poster.WebImage.Image Is Nothing Then
                    Dim defImg As MediaContainers.Image = Nothing
                    Images.GetPreferredTVSeasonPoster(SearchResultsContainer.SeasonPosters, defImg, iSeason)

                    If defImg IsNot Nothing Then
                        cSeason.ImagesContainer.Poster = defImg
                    End If
                End If

                If Me.bwLoadImages.CancellationPending Then
                    Return True
                End If
                Me.bwLoadImages.ReportProgress(iProgress, "progress")
                iProgress += 1
            Next
        End If

        'Episode Fanart/Poster
        If Me._type = Enums.ImageType_TV.All Then
            For Each cEpisode As Structures.DBTV In tmpShowContainer.Episodes
                iEpisode = cEpisode.TVEp.Episode
                iSeason = cEpisode.TVEp.Season

                'Episode Fanart
                If (Me._type = Enums.ImageType_TV.All OrElse Me._type = Enums.ImageType_TV.EpisodeFanart) AndAlso Master.eSettings.TVEpisodeFanartAnyEnabled AndAlso cEpisode.ImagesContainer.Fanart.WebImage.Image Is Nothing Then
                    Dim defImg As MediaContainers.Image = Nothing
                    Images.GetPreferredTVEpisodeFanart(SearchResultsContainer.EpisodeFanarts, SearchResultsContainer.ShowFanarts, defImg, iEpisode, iSeason)

                    If defImg IsNot Nothing Then
                        cEpisode.ImagesContainer.Fanart = defImg
                    End If
                End If
                'Episode Poster
                If (Me._type = Enums.ImageType_TV.All OrElse Me._type = Enums.ImageType_TV.EpisodePoster) AndAlso Master.eSettings.TVEpisodePosterAnyEnabled AndAlso cEpisode.ImagesContainer.Poster.WebImage.Image Is Nothing Then
                    Dim defImg As MediaContainers.Image = Nothing
                    Images.GetPreferredTVEpisodePoster(SearchResultsContainer.EpisodePosters, defImg, iEpisode, iSeason)

                    If defImg IsNot Nothing Then
                        cEpisode.ImagesContainer.Poster = defImg
                    End If
                End If

                If Me.bwLoadImages.CancellationPending Then
                    Return True
                End If
                Me.bwLoadImages.ReportProgress(iProgress, "progress")
                iProgress += 1
            Next
        End If

        Return False
    End Function

    Public Overloads Function ShowDialog(ByVal ShowID As Integer, ByVal Type As Enums.ImageType_TV, ByVal ScrapeType As Enums.ScrapeType_Movie_MovieSet_TV, ByVal WithCurrent As Boolean) As System.Windows.Forms.DialogResult
        Me._id = ShowID
        Me._type = Type
        Me._withcurrent = WithCurrent
        Me._ScrapeType = ScrapeType
        Return MyBase.ShowDialog
    End Function

    Public Overloads Function ShowDialog(ByVal ShowID As Integer, ByVal Type As Enums.ImageType_TV, ByVal Season As Integer, ByVal CurrentImage As Images) As Images
        Me._id = ShowID
        Me._type = Type
        Me._season = Season
        Me.pbCurrent.Image = CurrentImage.Image
        Me.pbCurrent.Tag = CurrentImage

        If MyBase.ShowDialog = Windows.Forms.DialogResult.OK Then
            Return CType(Me.pbCurrent.Tag, Images)
        Else
            Return Nothing
        End If
    End Function

    Private Sub AddImage(ByVal sDescription As String, ByVal iIndex As Integer, ByVal fTag As MediaContainers.Image)
        Try
            ReDim Preserve Me.pnlImage(iIndex)
            ReDim Preserve Me.pbImage(iIndex)
            ReDim Preserve Me.lblImage(iIndex)
            Me.pnlImage(iIndex) = New Panel()
            Me.pbImage(iIndex) = New PictureBox()
            Me.lblImage(iIndex) = New Label()
            Me.pbImage(iIndex).Name = iIndex.ToString
            Me.pnlImage(iIndex).Name = iIndex.ToString
            Me.lblImage(iIndex).Name = iIndex.ToString
            Me.pnlImage(iIndex).Size = New Size(187, 187)
            Me.pbImage(iIndex).Size = New Size(181, 151)
            Me.lblImage(iIndex).Size = New Size(181, 30)
            Me.pnlImage(iIndex).BackColor = Color.White
            Me.pnlImage(iIndex).BorderStyle = BorderStyle.FixedSingle
            Me.pbImage(iIndex).SizeMode = PictureBoxSizeMode.Zoom
            Me.lblImage(iIndex).AutoSize = False
            Me.lblImage(iIndex).BackColor = Color.White
            Me.lblImage(iIndex).TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            Me.lblImage(iIndex).Text = sDescription
            Me.pbImage(iIndex).Image = fTag.WebImage.Image
            Me.pnlImage(iIndex).Left = iLeft
            Me.pbImage(iIndex).Left = 3
            Me.lblImage(iIndex).Left = 0
            Me.pnlImage(iIndex).Top = iTop
            Me.pbImage(iIndex).Top = 3
            Me.lblImage(iIndex).Top = 151
            Me.pnlImage(iIndex).Tag = fTag
            Me.pbImage(iIndex).Tag = fTag
            Me.lblImage(iIndex).Tag = fTag
            Me.pnlImages.Controls.Add(Me.pnlImage(iIndex))
            Me.pnlImage(iIndex).Controls.Add(Me.pbImage(iIndex))
            Me.pnlImage(iIndex).Controls.Add(Me.lblImage(iIndex))
            Me.pnlImage(iIndex).BringToFront()
            AddHandler pbImage(iIndex).Click, AddressOf pbImage_Click
            AddHandler pbImage(iIndex).DoubleClick, AddressOf pbImage_DoubleClick
            AddHandler pnlImage(iIndex).Click, AddressOf pnlImage_Click
            AddHandler lblImage(iIndex).Click, AddressOf lblImage_Click

            AddHandler pbImage(iIndex).MouseWheel, AddressOf MouseWheelEvent
            AddHandler pnlImage(iIndex).MouseWheel, AddressOf MouseWheelEvent
            AddHandler lblImage(iIndex).MouseWheel, AddressOf MouseWheelEvent

        Catch ex As Exception
            logger.Error(New StackFrame().GetMethod().Name, ex)
        End Try

        Me.iCounter += 1

        If Me.iCounter = 3 Then
            Me.iCounter = 0
            Me.iLeft = 5
            Me.iTop += 192
        Else
            Me.iLeft += 192
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        If Me.bwLoadData.IsBusy Then Me.bwLoadData.CancelAsync()
        If Me.bwLoadImages.IsBusy Then Me.bwLoadImages.CancelAsync()

        While Me.bwLoadData.IsBusy OrElse Me.bwLoadImages.IsBusy
            Application.DoEvents()
            Threading.Thread.Sleep(50)
        End While

        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        DoneAndClose()
    End Sub
    ''' <summary>
    ''' Downloading fullsize images for preview in Edit Episode / Season / Show dialog
    ''' </summary>
    ''' <remarks>All other images will be downloaded while saving to DB</remarks>
    Private Sub DoneAndClose()
        Me.lblStatus.Text = Master.eLang.GetString(952, "Downloading Fullsize Image...")
        Me.pbStatus.Style = ProgressBarStyle.Marquee
        Me.pnlStatus.Visible = True

        'Banner
        If Not String.IsNullOrEmpty(tmpShowContainer.ImagesContainer.Banner.LocalFile) AndAlso File.Exists(tmpShowContainer.ImagesContainer.Banner.LocalFile) Then
            tmpShowContainer.ImagesContainer.Banner.WebImage.FromFile(tmpShowContainer.ImagesContainer.Banner.LocalFile)
        ElseIf Not String.IsNullOrEmpty(tmpShowContainer.ImagesContainer.Banner.URL) AndAlso Not String.IsNullOrEmpty(tmpShowContainer.ImagesContainer.Banner.LocalFile) Then
            tmpShowContainer.ImagesContainer.Banner.WebImage.Clear()
            tmpShowContainer.ImagesContainer.Banner.WebImage.FromWeb(tmpShowContainer.ImagesContainer.Banner.URL)
            If tmpShowContainer.ImagesContainer.Banner.WebImage.Image IsNot Nothing Then
                Directory.CreateDirectory(Directory.GetParent(tmpShowContainer.ImagesContainer.Banner.LocalFile).FullName)
                tmpShowContainer.ImagesContainer.Banner.WebImage.Save(tmpShowContainer.ImagesContainer.Banner.LocalFile)
            End If
        End If

        'CharacterArt
        If Not String.IsNullOrEmpty(tmpShowContainer.ImagesContainer.CharacterArt.LocalFile) AndAlso File.Exists(tmpShowContainer.ImagesContainer.CharacterArt.LocalFile) Then
            tmpShowContainer.ImagesContainer.CharacterArt.WebImage.FromFile(tmpShowContainer.ImagesContainer.CharacterArt.LocalFile)
        ElseIf Not String.IsNullOrEmpty(tmpShowContainer.ImagesContainer.CharacterArt.URL) AndAlso Not String.IsNullOrEmpty(tmpShowContainer.ImagesContainer.CharacterArt.LocalFile) Then
            tmpShowContainer.ImagesContainer.CharacterArt.WebImage.Clear()
            tmpShowContainer.ImagesContainer.CharacterArt.WebImage.FromWeb(tmpShowContainer.ImagesContainer.CharacterArt.URL)
            If tmpShowContainer.ImagesContainer.CharacterArt.WebImage.Image IsNot Nothing Then
                Directory.CreateDirectory(Directory.GetParent(tmpShowContainer.ImagesContainer.CharacterArt.LocalFile).FullName)
                tmpShowContainer.ImagesContainer.CharacterArt.WebImage.Save(tmpShowContainer.ImagesContainer.CharacterArt.LocalFile)
            End If
        End If

        'ClearArt
        If Not String.IsNullOrEmpty(tmpShowContainer.ImagesContainer.ClearArt.LocalFile) AndAlso File.Exists(tmpShowContainer.ImagesContainer.ClearArt.LocalFile) Then
            tmpShowContainer.ImagesContainer.ClearArt.WebImage.FromFile(tmpShowContainer.ImagesContainer.ClearArt.LocalFile)
        ElseIf Not String.IsNullOrEmpty(tmpShowContainer.ImagesContainer.ClearArt.URL) AndAlso Not String.IsNullOrEmpty(tmpShowContainer.ImagesContainer.ClearArt.LocalFile) Then
            tmpShowContainer.ImagesContainer.ClearArt.WebImage.Clear()
            tmpShowContainer.ImagesContainer.ClearArt.WebImage.FromWeb(tmpShowContainer.ImagesContainer.ClearArt.URL)
            If tmpShowContainer.ImagesContainer.ClearArt.WebImage.Image IsNot Nothing Then
                Directory.CreateDirectory(Directory.GetParent(tmpShowContainer.ImagesContainer.ClearArt.LocalFile).FullName)
                tmpShowContainer.ImagesContainer.ClearArt.WebImage.Save(tmpShowContainer.ImagesContainer.ClearArt.LocalFile)
            End If
        End If

        'ClearLogo
        If Not String.IsNullOrEmpty(tmpShowContainer.ImagesContainer.ClearLogo.LocalFile) AndAlso File.Exists(tmpShowContainer.ImagesContainer.ClearLogo.LocalFile) Then
            tmpShowContainer.ImagesContainer.ClearLogo.WebImage.FromFile(tmpShowContainer.ImagesContainer.ClearLogo.LocalFile)
        ElseIf Not String.IsNullOrEmpty(tmpShowContainer.ImagesContainer.ClearLogo.URL) AndAlso Not String.IsNullOrEmpty(tmpShowContainer.ImagesContainer.ClearLogo.LocalFile) Then
            tmpShowContainer.ImagesContainer.ClearLogo.WebImage.Clear()
            tmpShowContainer.ImagesContainer.ClearLogo.WebImage.FromWeb(tmpShowContainer.ImagesContainer.ClearLogo.URL)
            If tmpShowContainer.ImagesContainer.ClearLogo.WebImage.Image IsNot Nothing Then
                Directory.CreateDirectory(Directory.GetParent(tmpShowContainer.ImagesContainer.ClearLogo.LocalFile).FullName)
                tmpShowContainer.ImagesContainer.ClearLogo.WebImage.Save(tmpShowContainer.ImagesContainer.ClearLogo.LocalFile)
            End If
        End If

        'Fanart
        If Not String.IsNullOrEmpty(tmpShowContainer.ImagesContainer.Fanart.LocalFile) AndAlso File.Exists(tmpShowContainer.ImagesContainer.Fanart.LocalFile) Then
            tmpShowContainer.ImagesContainer.Fanart.WebImage.FromFile(tmpShowContainer.ImagesContainer.Fanart.LocalFile)
        ElseIf Not String.IsNullOrEmpty(tmpShowContainer.ImagesContainer.Fanart.URL) AndAlso Not String.IsNullOrEmpty(tmpShowContainer.ImagesContainer.Fanart.LocalFile) Then
            tmpShowContainer.ImagesContainer.Fanart.WebImage.Clear()
            tmpShowContainer.ImagesContainer.Fanart.WebImage.FromWeb(tmpShowContainer.ImagesContainer.Fanart.URL)
            If tmpShowContainer.ImagesContainer.Fanart.WebImage.Image IsNot Nothing Then
                Directory.CreateDirectory(Directory.GetParent(tmpShowContainer.ImagesContainer.Fanart.LocalFile).FullName)
                tmpShowContainer.ImagesContainer.Fanart.WebImage.Save(tmpShowContainer.ImagesContainer.Fanart.LocalFile)
            End If
        End If

        'Landscape
        If Not String.IsNullOrEmpty(tmpShowContainer.ImagesContainer.Landscape.LocalFile) AndAlso File.Exists(tmpShowContainer.ImagesContainer.Landscape.LocalFile) Then
            tmpShowContainer.ImagesContainer.Landscape.WebImage.FromFile(tmpShowContainer.ImagesContainer.Landscape.LocalFile)
        ElseIf Not String.IsNullOrEmpty(tmpShowContainer.ImagesContainer.Landscape.URL) AndAlso Not String.IsNullOrEmpty(tmpShowContainer.ImagesContainer.Landscape.LocalFile) Then
            tmpShowContainer.ImagesContainer.Landscape.WebImage.Clear()
            tmpShowContainer.ImagesContainer.Landscape.WebImage.FromWeb(tmpShowContainer.ImagesContainer.Landscape.URL)
            If tmpShowContainer.ImagesContainer.Landscape.WebImage.Image IsNot Nothing Then
                Directory.CreateDirectory(Directory.GetParent(tmpShowContainer.ImagesContainer.Landscape.LocalFile).FullName)
                tmpShowContainer.ImagesContainer.Landscape.WebImage.Save(tmpShowContainer.ImagesContainer.Landscape.LocalFile)
            End If
        End If

        'Poster
        If Not String.IsNullOrEmpty(tmpShowContainer.ImagesContainer.Poster.LocalFile) AndAlso File.Exists(tmpShowContainer.ImagesContainer.Poster.LocalFile) Then
            tmpShowContainer.ImagesContainer.Poster.WebImage.FromFile(tmpShowContainer.ImagesContainer.Poster.LocalFile)
        ElseIf Not String.IsNullOrEmpty(tmpShowContainer.ImagesContainer.Poster.URL) AndAlso Not String.IsNullOrEmpty(tmpShowContainer.ImagesContainer.Poster.LocalFile) Then
            tmpShowContainer.ImagesContainer.Poster.WebImage.Clear()
            tmpShowContainer.ImagesContainer.Poster.WebImage.FromWeb(tmpShowContainer.ImagesContainer.Poster.URL)
            If tmpShowContainer.ImagesContainer.Poster.WebImage.Image IsNot Nothing Then
                Directory.CreateDirectory(Directory.GetParent(tmpShowContainer.ImagesContainer.Poster.LocalFile).FullName)
                tmpShowContainer.ImagesContainer.Poster.WebImage.Save(tmpShowContainer.ImagesContainer.Poster.LocalFile)
            End If
        End If

        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub bwLoadData_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bwLoadData.DoWork
        Dim SIC As MediaContainers.EpisodeOrSeasonImagesContainer
        Dim iProgress As Integer = 1

        Me.bwLoadData.ReportProgress(tmpShowContainer.Episodes.Count, "current")

        If Me.bwLoadData.CancellationPending Then
            e.Cancel = True
            Return
        End If

        Select Case Me._type
            'Case Enums.ImageType_TV.AllSeasonsBanner
            '    ImageResultsContainer.SeasonBanner = CType(Me.pbCurrent.Tag, MediaContainers.Image)
            'Case Enums.ImageType_TV.AllSeasonsFanart
            '    ImageResultsContainer.SeasonFanart = CType(Me.pbCurrent.Tag, MediaContainers.Image)
            'Case Enums.ImageType_TV.AllSeasonsLandscape
            '    ImageResultsContainer.SeasonLandscape = CType(Me.pbCurrent.Tag, MediaContainers.Image)
            'Case Enums.ImageType_TV.AllSeasonsPoster
            '    ImageResultsContainer.SeasonPoster = CType(Me.pbCurrent.Tag, MediaContainers.Image)
            'Case Enums.ImageType_TV.SeasonPoster
            '    SIC = New MediaContainers.EpisodeOrSeasonImagesContainer
            '    SIC.Season = Me._season
            '    SIC.Poster = CType(Me.pbCurrent.Tag, MediaContainers.Image)
            '    ImageResultsContainer.SeasonImages.Add(SIC)
            'Case Enums.ImageType_TV.SeasonBanner
            '    SIC = New MediaContainers.EpisodeOrSeasonImagesContainer
            '    SIC.Season = Me._season
            '    SIC.Banner = CType(Me.pbCurrent.Tag, MediaContainers.Image)
            '    ImageResultsContainer.SeasonImages.Add(SIC)
            'Case Enums.ImageType_TV.SeasonFanart
            '    SIC = New MediaContainers.EpisodeOrSeasonImagesContainer
            '    SIC.Season = Me._season
            '    SIC.Fanart = CType(Me.pbCurrent.Tag, MediaContainers.Image)
            '    ImageResultsContainer.SeasonImages.Add(SIC)
            'Case Enums.ImageType_TV.SeasonLandscape
            '    SIC = New MediaContainers.EpisodeOrSeasonImagesContainer
            '    SIC.Season = Me._season
            '    SIC.Landscape = CType(Me.pbCurrent.Tag, MediaContainers.Image)
            '    ImageResultsContainer.SeasonImages.Add(SIC)
            'Case Enums.ImageType_TV.ShowBanner
            '    ImageResultsContainer.ShowBanner = CType(Me.pbCurrent.Tag, MediaContainers.Image)
            'Case Enums.ImageType_TV.ShowCharacterArt
            '    ImageResultsContainer.ShowCharacterArt = CType(Me.pbCurrent.Tag, MediaContainers.Image)
            'Case Enums.ImageType_TV.ShowClearArt
            '    ImageResultsContainer.ShowClearArt = CType(Me.pbCurrent.Tag, MediaContainers.Image)
            'Case Enums.ImageType_TV.ShowClearLogo
            '    ImageResultsContainer.ShowClearLogo = CType(Me.pbCurrent.Tag, MediaContainers.Image)
            'Case Enums.ImageType_TV.ShowFanart, Enums.ImageType_TV.EpisodeFanart
            '    ImageResultsContainer.ShowFanart = CType(Me.pbCurrent.Tag, MediaContainers.Image)
            'Case Enums.ImageType_TV.ShowLandscape
            '    ImageResultsContainer.ShowLandscape = CType(Me.pbCurrent.Tag, MediaContainers.Image)
            'Case Enums.ImageType_TV.ShowPoster
            '    ImageResultsContainer.ShowPoster = CType(Me.pbCurrent.Tag, MediaContainers.Image)
            Case Enums.ImageType_TV.All
                If _withcurrent Then
                    If Master.eSettings.TVShowBannerAnyEnabled AndAlso Me.tmpShowContainer.ImagesContainer.Banner.WebImage.Image IsNot Nothing Then
                        DefaultImagesContainer.Banner = Me.tmpShowContainer.ImagesContainer.Banner
                    End If
                    If Me.bwLoadData.CancellationPending Then
                        e.Cancel = True
                        Return
                    End If

                    If Master.eSettings.TVShowCharacterArtAnyEnabled AndAlso Me.tmpShowContainer.ImagesContainer.CharacterArt.WebImage.Image IsNot Nothing Then
                        DefaultImagesContainer.CharacterArt = Me.tmpShowContainer.ImagesContainer.CharacterArt
                    End If
                    If Me.bwLoadData.CancellationPending Then
                        e.Cancel = True
                        Return
                    End If

                    If Master.eSettings.TVShowClearArtAnyEnabled AndAlso Me.tmpShowContainer.ImagesContainer.ClearArt.WebImage.Image IsNot Nothing Then
                        DefaultImagesContainer.ClearArt = Me.tmpShowContainer.ImagesContainer.ClearArt
                    End If
                    If Me.bwLoadData.CancellationPending Then
                        e.Cancel = True
                        Return
                    End If

                    If Master.eSettings.TVShowClearLogoAnyEnabled AndAlso Me.tmpShowContainer.ImagesContainer.ClearLogo.WebImage.Image IsNot Nothing Then
                        DefaultImagesContainer.ClearLogo = Me.tmpShowContainer.ImagesContainer.ClearLogo
                    End If
                    If Me.bwLoadData.CancellationPending Then
                        e.Cancel = True
                        Return
                    End If

                    If Master.eSettings.TVShowFanartAnyEnabled AndAlso Me.tmpShowContainer.ImagesContainer.Fanart.WebImage.Image IsNot Nothing Then
                        DefaultImagesContainer.Fanart = Me.tmpShowContainer.ImagesContainer.Fanart
                    End If
                    If Me.bwLoadData.CancellationPending Then
                        e.Cancel = True
                        Return
                    End If

                    If Master.eSettings.TVShowLandscapeAnyEnabled AndAlso Me.tmpShowContainer.ImagesContainer.Landscape.WebImage.Image IsNot Nothing Then
                        DefaultImagesContainer.Landscape = Me.tmpShowContainer.ImagesContainer.Landscape
                    End If
                    If Me.bwLoadData.CancellationPending Then
                        e.Cancel = True
                        Return
                    End If

                    If Master.eSettings.TVShowPosterAnyEnabled AndAlso Me.tmpShowContainer.ImagesContainer.Poster.WebImage.Image IsNot Nothing Then
                        DefaultImagesContainer.Poster = Me.tmpShowContainer.ImagesContainer.Poster
                    End If
                    If Me.bwLoadData.CancellationPending Then
                        e.Cancel = True
                        Return
                    End If

                    'If Master.eSettings.TVASBannerAnyEnabled AndAlso Not String.IsNullOrEmpty(tmpShowContainer.AllSeason.BannerPath) Then
                    '    DefaultImagesContainer.SeasonBanner = Me.tmpShowContainer.Show.ImagesContainer.SeasonBanner
                    'End If
                    'If Me.bwLoadData.CancellationPending Then
                    '    e.Cancel = True
                    '    Return
                    'End If

                    'If Master.eSettings.TVASFanartAnyEnabled AndAlso Not String.IsNullOrEmpty(tmpShowContainer.AllSeason.FanartPath) Then
                    '    DefaultImagesContainer.SeasonFanart = Me.tmpShowContainer.Show.ImagesContainer.SeasonFanart
                    'End If
                    'If Me.bwLoadData.CancellationPending Then
                    '    e.Cancel = True
                    '    Return
                    'End If

                    'If Master.eSettings.TVASLandscapeAnyEnabled AndAlso Not String.IsNullOrEmpty(tmpShowContainer.AllSeason.LandscapePath) Then
                    '    DefaultImagesContainer.SeasonLandscape = Me.tmpShowContainer.Show.ImagesContainer.SeasonLandscape
                    'End If
                    'If Me.bwLoadData.CancellationPending Then
                    '    e.Cancel = True
                    '    Return
                    'End If

                    'If Master.eSettings.TVASPosterAnyEnabled AndAlso Not String.IsNullOrEmpty(tmpShowContainer.AllSeason.PosterPath) Then
                    '    DefaultImagesContainer.SeasonPoster = Me.tmpShowContainer.Show.ImagesContainer.SeasonPoster
                    'End If
                    'If Me.bwLoadData.CancellationPending Then
                    '    e.Cancel = True
                    '    Return
                    'End If

                    For Each sSeason As Structures.DBTV In tmpShowContainer.Seasons
                        SIC = New MediaContainers.EpisodeOrSeasonImagesContainer
                        SIC.Season = sSeason.TVSeason.Season
                        If Master.eSettings.TVSeasonBannerAnyEnabled AndAlso sSeason.ImagesContainer.Banner.WebImage.Image IsNot Nothing Then
                            SIC.Banner = sSeason.ImagesContainer.Banner
                        End If
                        If Master.eSettings.TVSeasonFanartAnyEnabled AndAlso sSeason.ImagesContainer.Fanart.WebImage.Image IsNot Nothing Then
                            SIC.Fanart = sSeason.ImagesContainer.Fanart
                        End If
                        If Master.eSettings.TVSeasonLandscapeAnyEnabled AndAlso sSeason.ImagesContainer.Landscape.WebImage.Image IsNot Nothing Then
                            SIC.Landscape = sSeason.ImagesContainer.Landscape
                        End If
                        If Master.eSettings.TVSeasonPosterAnyEnabled AndAlso sSeason.ImagesContainer.Poster.WebImage.Image IsNot Nothing Then
                            SIC.Poster = sSeason.ImagesContainer.Poster
                        End If
                        DefaultSeasonImagesContainer.Add(SIC)
                        If Me.bwLoadData.CancellationPending Then
                            e.Cancel = True
                            Return
                        End If
                    Next

                    For Each sEpisode As Structures.DBTV In tmpShowContainer.Episodes
                        SIC = New MediaContainers.EpisodeOrSeasonImagesContainer
                        SIC.Episode = sEpisode.TVEp.Episode
                        SIC.Season = sEpisode.TVEp.Season
                        If Master.eSettings.TVEpisodeFanartAnyEnabled AndAlso sEpisode.ImagesContainer.Fanart.WebImage.Image IsNot Nothing Then
                            SIC.Fanart = sEpisode.ImagesContainer.Fanart
                        End If
                        If Master.eSettings.TVEpisodePosterAnyEnabled AndAlso sEpisode.ImagesContainer.Poster.WebImage.Image IsNot Nothing Then
                            SIC.Poster = sEpisode.ImagesContainer.Poster
                        End If
                        DefaultEpisodeImagesContainer.Add(SIC)
                        If Me.bwLoadData.CancellationPending Then
                            e.Cancel = True
                            Return
                        End If
                    Next
                    'Else
                    '    For Each sEpisode As Structures.DBTV In tmpShowContainer.Episodes
                    '        Try
                    '            iSeason = sEpisode.TVEp.Season

                    '            If ImageResultsContainer.SeasonImages.Where(Function(s) s.Season = iSeason).Count = 0 Then
                    '                SIC = New MediaContainers.EpisodeOrSeasonImagesContainer
                    '                SIC.Season = iSeason
                    '                ImageResultsContainer.SeasonImages.Add(SIC)
                    '            End If

                    '            If Me.bwLoadData.CancellationPending Then
                    '                e.Cancel = True
                    '                Return
                    '            End If

                    '            Me.bwLoadData.ReportProgress(iProgress, "progress")
                    '            iProgress += 1
                    '        Catch ex As Exception
                    '            logger.Error(New StackFrame().GetMethod().Name, ex)
                    '        End Try
                    '    Next
                End If
        End Select
    End Sub

    Private Sub bwLoadData_ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles bwLoadData.ProgressChanged
        If e.UserState.ToString = "progress" Then
            Me.pbStatus.Value = e.ProgressPercentage
        ElseIf e.UserState.ToString = "current" Then
            Me.lblStatus.Text = Master.eLang.GetString(953, "Loading Current Images...")
            Me.pbStatus.Value = 0
            Me.pbStatus.Maximum = e.ProgressPercentage
        Else
            Me.pbStatus.Value = 0
            Me.pbStatus.Maximum = e.ProgressPercentage
        End If
    End Sub

    Private Sub bwLoadData_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bwLoadData.RunWorkerCompleted
        If Not e.Cancelled Then
            Me.GenerateList()

            Me.lblStatus.Text = Master.eLang.GetString(954, "(Down)Loading New Images...")
            Me.bwLoadImages.WorkerReportsProgress = True
            Me.bwLoadImages.WorkerSupportsCancellation = True
            Me.bwLoadImages.RunWorkerAsync()
        End If
    End Sub

    Private Sub bwLoadImages_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bwLoadImages.DoWork
        e.Cancel = Me.DownloadAllImages()
    End Sub

    Private Sub bwLoadImages_ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles bwLoadImages.ProgressChanged
        If e.UserState.ToString = "progress" Then
            Me.pbStatus.Value = e.ProgressPercentage
        ElseIf e.UserState.ToString = "defaults" Then
            Me.lblStatus.Text = Master.eLang.GetString(955, "Setting Defaults...")
            Me.pbStatus.Value = 0
            Me.pbStatus.Maximum = e.ProgressPercentage
        Else
            Me.pbStatus.Value = 0
            Me.pbStatus.Maximum = e.ProgressPercentage
        End If
    End Sub

    Private Sub bwLoadImages_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bwLoadImages.RunWorkerCompleted
        Me.pnlStatus.Visible = False
        If _ScrapeType = Enums.ScrapeType_Movie_MovieSet_TV.FullAuto Then
            DoneAndClose()
        Else
            If Not e.Cancelled Then
                Me.tvList.Enabled = True
                Me.tvList.Visible = True
                If Me.tvList.Nodes.Count > 0 Then
                    Me.tvList.SelectedNode = Me.tvList.Nodes(0)
                End If
                Me.tvList.Focus()

                Me.btnOK.Enabled = True
            End If

            Me.pbCurrent.Visible = True
            Me.lblCurrentImage.Visible = True
        End If
    End Sub

    Private Sub CheckCurrentImage()
        Me.pbDelete.Visible = Me.pbCurrent.Image IsNot Nothing AndAlso Me.pbCurrent.Visible
        Me.pbUndo.Visible = Me.pbCurrent.Visible
    End Sub

    Private Sub ClearImages()
        Try
            Me.iCounter = 0
            Me.iLeft = 5
            Me.iTop = 5
            Me.pbCurrent.Image = Nothing
            Me.pbCurrent.Tag = Nothing

            If Me.pnlImages.Controls.Count > 0 Then
                For i As Integer = 0 To Me.pnlImage.Count - 1
                    If Me.pnlImage(i) IsNot Nothing Then
                        If Me.lblImage(i) IsNot Nothing AndAlso Me.pnlImage(i).Contains(Me.lblImage(i)) Then Me.pnlImage(i).Controls.Remove(Me.lblImage(i))
                        If Me.pbImage(i) IsNot Nothing AndAlso Me.pnlImage(i).Contains(Me.pbImage(i)) Then Me.pnlImage(i).Controls.Remove(Me.pbImage(i))
                        If Me.pnlImages.Contains(Me.pnlImage(i)) Then Me.pnlImages.Controls.Remove(Me.pnlImage(i))
                    End If
                Next
            End If
        Catch ex As Exception
            logger.Error(New StackFrame().GetMethod().Name, ex)
        End Try
    End Sub

    Private Sub dlgTVImageSelect_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        AddHandler pnlImages.MouseWheel, AddressOf MouseWheelEvent
        AddHandler MyBase.MouseWheel, AddressOf MouseWheelEvent
        AddHandler tvList.MouseWheel, AddressOf MouseWheelEvent

        Functions.PNLDoubleBuffer(Me.pnlImages)

        Me.SetUp()
    End Sub

    Public Overloads Function ShowDialog(ByRef DBTV As Structures.DBTV, ByVal Type As Enums.ImageType_TV, ByRef ImagesContainer As MediaContainers.SearchResultsContainer_TV, Optional ByVal _isEdit As Boolean = False) As DialogResult
        Me.SearchResultsContainer = ImagesContainer
        Me.tmpShowContainer = DBTV
        Return MyBase.ShowDialog()
    End Function

    Private Sub dlgTVImageSelect_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Me.bwLoadData.WorkerReportsProgress = True
        Me.bwLoadData.WorkerSupportsCancellation = True
        Me.bwLoadData.RunWorkerAsync()
    End Sub

    Private Sub DoSelect(ByVal iIndex As Integer, ByVal SelTag As MediaContainers.Image)
        Try
            For i As Integer = 0 To Me.pnlImage.Count - 1
                Me.pnlImage(i).BackColor = Color.White
                Me.lblImage(i).BackColor = Color.White
                Me.lblImage(i).ForeColor = Color.Black
            Next

            Me.pnlImage(iIndex).BackColor = Color.Blue
            Me.lblImage(iIndex).BackColor = Color.Blue
            Me.lblImage(iIndex).ForeColor = Color.White

            SetImage(SelTag)

            Me.CheckCurrentImage()
        Catch ex As Exception
            logger.Error(New StackFrame().GetMethod().Name, ex)
        End Try
    End Sub
    ''' <summary>
    ''' Cahe all images in Temp folder
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function DownloadAllImages() As Boolean
        Dim iProgress As Integer = 1
        Dim uniqueID As String = String.Empty

        'get the TVDB ID for proper caching or cache all images in "mixed" folder
        If tmpShowContainer.TVShow Is Nothing OrElse (tmpShowContainer.TVShow IsNot Nothing AndAlso String.IsNullOrEmpty(tmpShowContainer.TVShow.TVDBID)) Then
            uniqueID = Master.DB.LoadTVShowFromDB(tmpShowContainer.ShowID, False).TVShow.TVDBID
        Else
            uniqueID = tmpShowContainer.TVShow.TVDBID
        End If
        If String.IsNullOrEmpty(uniqueID) Then
            uniqueID = "mixed"
        End If

        Me.bwLoadImages.ReportProgress(SearchResultsContainer.EpisodeFanarts.Count + SearchResultsContainer.EpisodePosters.Count + SearchResultsContainer.SeasonBanners.Count + _
                                       SearchResultsContainer.SeasonFanarts.Count + SearchResultsContainer.SeasonLandscapes.Count + SearchResultsContainer.SeasonPosters.Count + _
                                       SearchResultsContainer.ShowBanners.Count + SearchResultsContainer.ShowCharacterArts.Count + SearchResultsContainer.ShowClearArts.Count + _
                                       SearchResultsContainer.ShowClearLogos.Count + SearchResultsContainer.ShowFanarts.Count + SearchResultsContainer.ShowLandscapes.Count + _
                                       SearchResultsContainer.ShowPosters.Count, "max")

        'Create chaching paths

        'Banner Show
        For Each img In SearchResultsContainer.ShowBanners
            img.LocalFile = Path.Combine(Master.TempPath, String.Concat("Shows", Path.DirectorySeparatorChar, uniqueID, Path.DirectorySeparatorChar, "showbanners", Path.DirectorySeparatorChar, Path.GetFileName(img.URL)))
            If Not String.IsNullOrEmpty(img.ThumbURL) Then
                img.LocalThumb = Path.Combine(Master.TempPath, String.Concat("Shows", Path.DirectorySeparatorChar, uniqueID, Path.DirectorySeparatorChar, "showbanners\_thumbs", Path.DirectorySeparatorChar, Path.GetFileName(img.URL)))
            End If
        Next

        'Banner Season
        For Each img In SearchResultsContainer.SeasonBanners
            img.LocalFile = Path.Combine(Master.TempPath, String.Concat("Shows", Path.DirectorySeparatorChar, uniqueID, Path.DirectorySeparatorChar, "seasonbanners", Path.DirectorySeparatorChar, Path.GetFileName(img.URL)))
            If Not String.IsNullOrEmpty(img.ThumbURL) Then
                img.LocalThumb = Path.Combine(Master.TempPath, String.Concat("Shows", Path.DirectorySeparatorChar, uniqueID, Path.DirectorySeparatorChar, "seasonbanners\_thumbs", Path.DirectorySeparatorChar, Path.GetFileName(img.URL)))
            End If
        Next

        'CharacterArt Show
        For Each img In SearchResultsContainer.ShowCharacterArts
            img.LocalFile = Path.Combine(Master.TempPath, String.Concat("Shows", Path.DirectorySeparatorChar, uniqueID, Path.DirectorySeparatorChar, "showcharacterarts", Path.DirectorySeparatorChar, Path.GetFileName(img.URL)))
            If Not String.IsNullOrEmpty(img.ThumbURL) Then
                img.LocalThumb = Path.Combine(Master.TempPath, String.Concat("Shows", Path.DirectorySeparatorChar, uniqueID, Path.DirectorySeparatorChar, "showcharacterarts\_thumbs", Path.DirectorySeparatorChar, Path.GetFileName(img.URL)))
            End If
        Next

        'ClearArt Show
        For Each img In SearchResultsContainer.ShowClearArts
            img.LocalFile = Path.Combine(Master.TempPath, String.Concat("Shows", Path.DirectorySeparatorChar, uniqueID, Path.DirectorySeparatorChar, "showcleararts", Path.DirectorySeparatorChar, Path.GetFileName(img.URL)))
            If Not String.IsNullOrEmpty(img.ThumbURL) Then
                img.LocalThumb = Path.Combine(Master.TempPath, String.Concat("Shows", Path.DirectorySeparatorChar, uniqueID, Path.DirectorySeparatorChar, "showcleararts\_thumbs", Path.DirectorySeparatorChar, Path.GetFileName(img.URL)))
            End If
        Next

        'ClearLogo Show
        For Each img In SearchResultsContainer.ShowClearLogos
            img.LocalFile = Path.Combine(Master.TempPath, String.Concat("Shows", Path.DirectorySeparatorChar, uniqueID, Path.DirectorySeparatorChar, "showclearlogos", Path.DirectorySeparatorChar, Path.GetFileName(img.URL)))
            If Not String.IsNullOrEmpty(img.ThumbURL) Then
                img.LocalThumb = Path.Combine(Master.TempPath, String.Concat("Shows", Path.DirectorySeparatorChar, uniqueID, Path.DirectorySeparatorChar, "showclearlogos\_thumbs", Path.DirectorySeparatorChar, Path.GetFileName(img.URL)))
            End If
        Next

        'Fanart Episode
        For Each img In SearchResultsContainer.EpisodeFanarts
            img.LocalFile = Path.Combine(Master.TempPath, String.Concat("Shows", Path.DirectorySeparatorChar, uniqueID, Path.DirectorySeparatorChar, "episodefanarts", Path.DirectorySeparatorChar, Path.GetFileName(img.URL)))
            If Not String.IsNullOrEmpty(img.ThumbURL) Then
                img.LocalThumb = Path.Combine(Master.TempPath, String.Concat("Shows", Path.DirectorySeparatorChar, uniqueID, Path.DirectorySeparatorChar, "episodefanarts\_thumbs", Path.DirectorySeparatorChar, Path.GetFileName(img.URL)))
            End If
        Next

        'Fanart Show
        For Each img In SearchResultsContainer.ShowFanarts
            img.LocalFile = Path.Combine(Master.TempPath, String.Concat("Shows", Path.DirectorySeparatorChar, uniqueID, Path.DirectorySeparatorChar, "showfanarts", Path.DirectorySeparatorChar, Path.GetFileName(img.URL)))
            If Not String.IsNullOrEmpty(img.ThumbURL) Then
                img.LocalThumb = Path.Combine(Master.TempPath, String.Concat("Shows", Path.DirectorySeparatorChar, uniqueID, Path.DirectorySeparatorChar, "showfanarts\_thumbs", Path.DirectorySeparatorChar, Path.GetFileName(img.URL)))
            End If
        Next

        'Landscape Show
        For Each img In SearchResultsContainer.ShowLandscapes
            img.LocalFile = Path.Combine(Master.TempPath, String.Concat("Shows", Path.DirectorySeparatorChar, uniqueID, Path.DirectorySeparatorChar, "showlandscapes", Path.DirectorySeparatorChar, Path.GetFileName(img.URL)))
            If Not String.IsNullOrEmpty(img.ThumbURL) Then
                img.LocalThumb = Path.Combine(Master.TempPath, String.Concat("Shows", Path.DirectorySeparatorChar, uniqueID, Path.DirectorySeparatorChar, "showlandscapes\_thumbs", Path.DirectorySeparatorChar, Path.GetFileName(img.URL)))
            End If
        Next

        'Landscape Season
        For Each img In SearchResultsContainer.SeasonLandscapes
            img.LocalFile = Path.Combine(Master.TempPath, String.Concat("Shows", Path.DirectorySeparatorChar, uniqueID, Path.DirectorySeparatorChar, "seasonlandscapes", Path.DirectorySeparatorChar, Path.GetFileName(img.URL)))
            If Not String.IsNullOrEmpty(img.ThumbURL) Then
                img.LocalThumb = Path.Combine(Master.TempPath, String.Concat("Shows", Path.DirectorySeparatorChar, uniqueID, Path.DirectorySeparatorChar, "seasonlandscapes\_thumbs", Path.DirectorySeparatorChar, Path.GetFileName(img.URL)))
            End If
        Next

        'Poster Episode
        For Each img In SearchResultsContainer.EpisodePosters
            img.LocalFile = Path.Combine(Master.TempPath, String.Concat("Shows", Path.DirectorySeparatorChar, uniqueID, Path.DirectorySeparatorChar, "episodeposters", Path.DirectorySeparatorChar, Path.GetFileName(img.URL)))
            If Not String.IsNullOrEmpty(img.ThumbURL) Then
                img.LocalThumb = Path.Combine(Master.TempPath, String.Concat("Shows", Path.DirectorySeparatorChar, uniqueID, Path.DirectorySeparatorChar, "episodeposters\_thumbs", Path.DirectorySeparatorChar, Path.GetFileName(img.URL)))
            End If
        Next

        'Poster Show
        For Each img In SearchResultsContainer.ShowPosters
            img.LocalFile = Path.Combine(Master.TempPath, String.Concat("Shows", Path.DirectorySeparatorChar, uniqueID, Path.DirectorySeparatorChar, "showposters", Path.DirectorySeparatorChar, Path.GetFileName(img.URL)))
            If Not String.IsNullOrEmpty(img.ThumbURL) Then
                img.LocalThumb = Path.Combine(Master.TempPath, String.Concat("Shows", Path.DirectorySeparatorChar, uniqueID, Path.DirectorySeparatorChar, "showposters\_thumbs", Path.DirectorySeparatorChar, Path.GetFileName(img.URL)))
            End If
        Next

        'Poster Season
        For Each img In SearchResultsContainer.SeasonPosters
            img.LocalFile = Path.Combine(Master.TempPath, String.Concat("Shows", Path.DirectorySeparatorChar, uniqueID, Path.DirectorySeparatorChar, "seasonposters", Path.DirectorySeparatorChar, Path.GetFileName(img.URL)))
            If Not String.IsNullOrEmpty(img.ThumbURL) Then
                img.LocalThumb = Path.Combine(Master.TempPath, String.Concat("Shows", Path.DirectorySeparatorChar, uniqueID, Path.DirectorySeparatorChar, "seasonposters\_thumbs", Path.DirectorySeparatorChar, Path.GetFileName(img.URL)))
            End If
        Next

        'Start images caching

        'Episode Fanarts
        If Me._type = Enums.ImageType_TV.All OrElse Me._type = Enums.ImageType_TV.EpisodeFanart Then
            For Each tImg As MediaContainers.Image In SearchResultsContainer.EpisodeFanarts
                If File.Exists(tImg.LocalThumb) Then
                    tImg.WebImage.FromFile(tImg.LocalThumb)
                ElseIf File.Exists(tImg.LocalFile) AndAlso String.IsNullOrEmpty(tImg.ThumbURL) Then
                    tImg.WebImage.FromFile(tImg.LocalFile)
                Else
                    If Not String.IsNullOrEmpty(tImg.ThumbURL) Then
                        tImg.WebImage.FromWeb(tImg.ThumbURL)
                        If tImg.WebImage.Image IsNot Nothing Then
                            Directory.CreateDirectory(Directory.GetParent(tImg.LocalThumb).FullName)
                            tImg.WebImage.Save(tImg.LocalThumb)
                        End If
                    ElseIf Not String.IsNullOrEmpty(tImg.URL) Then
                        tImg.WebImage.FromWeb(tImg.URL)
                        If tImg.WebImage.Image IsNot Nothing Then
                            Directory.CreateDirectory(Directory.GetParent(tImg.LocalFile).FullName)
                            tImg.WebImage.Save(tImg.LocalFile)
                        End If
                    End If
                End If

                If Me.bwLoadImages.CancellationPending Then
                    Return True
                End If

                Me.bwLoadImages.ReportProgress(iProgress, "progress")
                iProgress += 1
            Next
        End If

        'Episode Posters
        If Me._type = Enums.ImageType_TV.All OrElse Me._type = Enums.ImageType_TV.EpisodePoster Then
            For Each tImg As MediaContainers.Image In SearchResultsContainer.EpisodePosters
                If File.Exists(tImg.LocalThumb) Then
                    tImg.WebImage.FromFile(tImg.LocalThumb)
                ElseIf File.Exists(tImg.LocalFile) AndAlso String.IsNullOrEmpty(tImg.ThumbURL) Then
                    tImg.WebImage.FromFile(tImg.LocalFile)
                Else
                    If Not String.IsNullOrEmpty(tImg.ThumbURL) Then
                        tImg.WebImage.FromWeb(tImg.ThumbURL)
                        If tImg.WebImage.Image IsNot Nothing Then
                            Directory.CreateDirectory(Directory.GetParent(tImg.LocalThumb).FullName)
                            tImg.WebImage.Save(tImg.LocalThumb)
                        End If
                    ElseIf Not String.IsNullOrEmpty(tImg.URL) Then
                        tImg.WebImage.FromWeb(tImg.URL)
                        If tImg.WebImage.Image IsNot Nothing Then
                            Directory.CreateDirectory(Directory.GetParent(tImg.LocalFile).FullName)
                            tImg.WebImage.Save(tImg.LocalFile)
                        End If
                    End If
                End If

                If Me.bwLoadImages.CancellationPending Then
                    Return True
                End If

                Me.bwLoadImages.ReportProgress(iProgress, "progress")
                iProgress += 1
            Next
        End If

        'Season Poster / AllSeasons Poster
        If Me._type = Enums.ImageType_TV.All OrElse Me._type = Enums.ImageType_TV.SeasonPoster OrElse Me._type = Enums.ImageType_TV.AllSeasonsPoster Then
            For Each tImg As MediaContainers.Image In SearchResultsContainer.EpisodePosters
                If File.Exists(tImg.LocalThumb) Then
                    tImg.WebImage.FromFile(tImg.LocalThumb)
                ElseIf File.Exists(tImg.LocalFile) AndAlso String.IsNullOrEmpty(tImg.ThumbURL) Then
                    tImg.WebImage.FromFile(tImg.LocalFile)
                Else
                    If Not String.IsNullOrEmpty(tImg.ThumbURL) Then
                        tImg.WebImage.FromWeb(tImg.ThumbURL)
                        If tImg.WebImage.Image IsNot Nothing Then
                            Directory.CreateDirectory(Directory.GetParent(tImg.LocalThumb).FullName)
                            tImg.WebImage.Save(tImg.LocalThumb)
                        End If
                    ElseIf Not String.IsNullOrEmpty(tImg.URL) Then
                        tImg.WebImage.FromWeb(tImg.URL)
                        If tImg.WebImage.Image IsNot Nothing Then
                            Directory.CreateDirectory(Directory.GetParent(tImg.LocalFile).FullName)
                            tImg.WebImage.Save(tImg.LocalFile)
                        End If
                    End If
                End If

                If Me.bwLoadImages.CancellationPending Then
                    Return True
                End If

                Me.bwLoadImages.ReportProgress(iProgress, "progress")
                iProgress += 1
            Next
        End If

        'Season Banner / AllSeasons Banner
        If Me._type = Enums.ImageType_TV.All OrElse Me._type = Enums.ImageType_TV.SeasonBanner OrElse Me._type = Enums.ImageType_TV.AllSeasonsBanner Then
            For Each tImg As MediaContainers.Image In SearchResultsContainer.SeasonBanners
                If File.Exists(tImg.LocalThumb) Then
                    tImg.WebImage.FromFile(tImg.LocalThumb)
                ElseIf File.Exists(tImg.LocalFile) AndAlso String.IsNullOrEmpty(tImg.ThumbURL) Then
                    tImg.WebImage.FromFile(tImg.LocalFile)
                Else
                    If Not String.IsNullOrEmpty(tImg.ThumbURL) Then
                        tImg.WebImage.FromWeb(tImg.ThumbURL)
                        If tImg.WebImage.Image IsNot Nothing Then
                            Directory.CreateDirectory(Directory.GetParent(tImg.LocalThumb).FullName)
                            tImg.WebImage.Save(tImg.LocalThumb)
                        End If
                    ElseIf Not String.IsNullOrEmpty(tImg.URL) Then
                        tImg.WebImage.FromWeb(tImg.URL)
                        If tImg.WebImage.Image IsNot Nothing Then
                            Directory.CreateDirectory(Directory.GetParent(tImg.LocalFile).FullName)
                            tImg.WebImage.Save(tImg.LocalFile)
                        End If
                    End If
                End If

                If Me.bwLoadImages.CancellationPending Then
                    Return True
                End If

                Me.bwLoadImages.ReportProgress(iProgress, "progress")
                iProgress += 1
            Next
        End If

        'Season Fanart  /AllSeasons Fanart
        If Me._type = Enums.ImageType_TV.All OrElse Me._type = Enums.ImageType_TV.SeasonFanart OrElse Me._type = Enums.ImageType_TV.AllSeasonsFanart Then
            For Each tImg As MediaContainers.Image In SearchResultsContainer.SeasonFanarts
                If File.Exists(tImg.LocalThumb) Then
                    tImg.WebImage.FromFile(tImg.LocalThumb)
                ElseIf File.Exists(tImg.LocalFile) AndAlso String.IsNullOrEmpty(tImg.ThumbURL) Then
                    tImg.WebImage.FromFile(tImg.LocalFile)
                Else
                    If Not String.IsNullOrEmpty(tImg.ThumbURL) Then
                        tImg.WebImage.FromWeb(tImg.ThumbURL)
                        If tImg.WebImage.Image IsNot Nothing Then
                            Directory.CreateDirectory(Directory.GetParent(tImg.LocalThumb).FullName)
                            tImg.WebImage.Save(tImg.LocalThumb)
                        End If
                    ElseIf Not String.IsNullOrEmpty(tImg.URL) Then
                        tImg.WebImage.FromWeb(tImg.URL)
                        If tImg.WebImage.Image IsNot Nothing Then
                            Directory.CreateDirectory(Directory.GetParent(tImg.LocalFile).FullName)
                            tImg.WebImage.Save(tImg.LocalFile)
                        End If
                    End If
                End If

                If Me.bwLoadImages.CancellationPending Then
                    Return True
                End If

                Me.bwLoadImages.ReportProgress(iProgress, "progress")
                iProgress += 1
            Next
        End If

        'Season Landscape  /AllSeasons Landscape
        If Me._type = Enums.ImageType_TV.All OrElse Me._type = Enums.ImageType_TV.SeasonLandscape OrElse Me._type = Enums.ImageType_TV.AllSeasonsLandscape Then
            For Each tImg As MediaContainers.Image In SearchResultsContainer.SeasonLandscapes
                If File.Exists(tImg.LocalThumb) Then
                    tImg.WebImage.FromFile(tImg.LocalThumb)
                ElseIf File.Exists(tImg.LocalFile) AndAlso String.IsNullOrEmpty(tImg.ThumbURL) Then
                    tImg.WebImage.FromFile(tImg.LocalFile)
                Else
                    If Not String.IsNullOrEmpty(tImg.ThumbURL) Then
                        tImg.WebImage.FromWeb(tImg.ThumbURL)
                        If tImg.WebImage.Image IsNot Nothing Then
                            Directory.CreateDirectory(Directory.GetParent(tImg.LocalThumb).FullName)
                            tImg.WebImage.Save(tImg.LocalThumb)
                        End If
                    ElseIf Not String.IsNullOrEmpty(tImg.URL) Then
                        tImg.WebImage.FromWeb(tImg.URL)
                        If tImg.WebImage.Image IsNot Nothing Then
                            Directory.CreateDirectory(Directory.GetParent(tImg.LocalFile).FullName)
                            tImg.WebImage.Save(tImg.LocalFile)
                        End If
                    End If
                End If

                If Me.bwLoadImages.CancellationPending Then
                    Return True
                End If

                Me.bwLoadImages.ReportProgress(iProgress, "progress")
                iProgress += 1
            Next
        End If

        'Show Poster / AllSeasons Poster
        If Me._type = Enums.ImageType_TV.All OrElse Me._type = Enums.ImageType_TV.ShowPoster OrElse Me._type = Enums.ImageType_TV.AllSeasonsPoster Then
            For Each tImg As MediaContainers.Image In SearchResultsContainer.ShowPosters
                If File.Exists(tImg.LocalThumb) Then
                    tImg.WebImage.FromFile(tImg.LocalThumb)
                ElseIf File.Exists(tImg.LocalFile) AndAlso String.IsNullOrEmpty(tImg.ThumbURL) Then
                    tImg.WebImage.FromFile(tImg.LocalFile)
                Else
                    If Not String.IsNullOrEmpty(tImg.ThumbURL) Then
                        tImg.WebImage.FromWeb(tImg.ThumbURL)
                        If tImg.WebImage.Image IsNot Nothing Then
                            Directory.CreateDirectory(Directory.GetParent(tImg.LocalThumb).FullName)
                            tImg.WebImage.Save(tImg.LocalThumb)
                        End If
                    ElseIf Not String.IsNullOrEmpty(tImg.URL) Then
                        tImg.WebImage.FromWeb(tImg.URL)
                        If tImg.WebImage.Image IsNot Nothing Then
                            Directory.CreateDirectory(Directory.GetParent(tImg.LocalFile).FullName)
                            tImg.WebImage.Save(tImg.LocalFile)
                        End If
                    End If
                End If

                If Me.bwLoadImages.CancellationPending Then
                    Return True
                End If

                Me.bwLoadImages.ReportProgress(iProgress, "progress")
                iProgress += 1
            Next
        End If

        'Show Banner / AllSeasons Banner
        If Me._type = Enums.ImageType_TV.All OrElse Me._type = Enums.ImageType_TV.ShowBanner OrElse Me._type = Enums.ImageType_TV.AllSeasonsBanner Then
            For Each tImg As MediaContainers.Image In SearchResultsContainer.ShowBanners
                If File.Exists(tImg.LocalThumb) Then
                    tImg.WebImage.FromFile(tImg.LocalThumb)
                ElseIf File.Exists(tImg.LocalFile) AndAlso String.IsNullOrEmpty(tImg.ThumbURL) Then
                    tImg.WebImage.FromFile(tImg.LocalFile)
                Else
                    If Not String.IsNullOrEmpty(tImg.ThumbURL) Then
                        tImg.WebImage.FromWeb(tImg.ThumbURL)
                        If tImg.WebImage.Image IsNot Nothing Then
                            Directory.CreateDirectory(Directory.GetParent(tImg.LocalThumb).FullName)
                            tImg.WebImage.Save(tImg.LocalThumb)
                        End If
                    ElseIf Not String.IsNullOrEmpty(tImg.URL) Then
                        tImg.WebImage.FromWeb(tImg.URL)
                        If tImg.WebImage.Image IsNot Nothing Then
                            Directory.CreateDirectory(Directory.GetParent(tImg.LocalFile).FullName)
                            tImg.WebImage.Save(tImg.LocalFile)
                        End If
                    End If
                End If

                If Me.bwLoadImages.CancellationPending Then
                    Return True
                End If

                Me.bwLoadImages.ReportProgress(iProgress, "progress")
                iProgress += 1
            Next
        End If

        'Show CharacterArt
        If Me._type = Enums.ImageType_TV.All OrElse Me._type = Enums.ImageType_TV.ShowCharacterArt Then
            For Each tImg As MediaContainers.Image In SearchResultsContainer.ShowCharacterArts
                If File.Exists(tImg.LocalThumb) Then
                    tImg.WebImage.FromFile(tImg.LocalThumb)
                ElseIf File.Exists(tImg.LocalFile) AndAlso String.IsNullOrEmpty(tImg.ThumbURL) Then
                    tImg.WebImage.FromFile(tImg.LocalFile)
                Else
                    If Not String.IsNullOrEmpty(tImg.ThumbURL) Then
                        tImg.WebImage.FromWeb(tImg.ThumbURL)
                        If tImg.WebImage.Image IsNot Nothing Then
                            Directory.CreateDirectory(Directory.GetParent(tImg.LocalThumb).FullName)
                            tImg.WebImage.Save(tImg.LocalThumb)
                        End If
                    ElseIf Not String.IsNullOrEmpty(tImg.URL) Then
                        tImg.WebImage.FromWeb(tImg.URL)
                        If tImg.WebImage.Image IsNot Nothing Then
                            Directory.CreateDirectory(Directory.GetParent(tImg.LocalFile).FullName)
                            tImg.WebImage.Save(tImg.LocalFile)
                        End If
                    End If
                End If

                If Me.bwLoadImages.CancellationPending Then
                    Return True
                End If

                Me.bwLoadImages.ReportProgress(iProgress, "progress")
                iProgress += 1
            Next
        End If

        'Show ClearArt
        If Me._type = Enums.ImageType_TV.All OrElse Me._type = Enums.ImageType_TV.ShowClearArt Then
            For Each tImg As MediaContainers.Image In SearchResultsContainer.ShowClearArts
                If File.Exists(tImg.LocalThumb) Then
                    tImg.WebImage.FromFile(tImg.LocalThumb)
                ElseIf File.Exists(tImg.LocalFile) AndAlso String.IsNullOrEmpty(tImg.ThumbURL) Then
                    tImg.WebImage.FromFile(tImg.LocalFile)
                Else
                    If Not String.IsNullOrEmpty(tImg.ThumbURL) Then
                        tImg.WebImage.FromWeb(tImg.ThumbURL)
                        If tImg.WebImage.Image IsNot Nothing Then
                            Directory.CreateDirectory(Directory.GetParent(tImg.LocalThumb).FullName)
                            tImg.WebImage.Save(tImg.LocalThumb)
                        End If
                    ElseIf Not String.IsNullOrEmpty(tImg.URL) Then
                        tImg.WebImage.FromWeb(tImg.URL)
                        If tImg.WebImage.Image IsNot Nothing Then
                            Directory.CreateDirectory(Directory.GetParent(tImg.LocalFile).FullName)
                            tImg.WebImage.Save(tImg.LocalFile)
                        End If
                    End If
                End If

                If Me.bwLoadImages.CancellationPending Then
                    Return True
                End If

                Me.bwLoadImages.ReportProgress(iProgress, "progress")
                iProgress += 1
            Next
        End If

        'Show ClearLogo
        If Me._type = Enums.ImageType_TV.All OrElse Me._type = Enums.ImageType_TV.ShowClearLogo Then
            For Each tImg As MediaContainers.Image In SearchResultsContainer.ShowClearLogos
                If File.Exists(tImg.LocalThumb) Then
                    tImg.WebImage.FromFile(tImg.LocalThumb)
                ElseIf File.Exists(tImg.LocalFile) AndAlso String.IsNullOrEmpty(tImg.ThumbURL) Then
                    tImg.WebImage.FromFile(tImg.LocalFile)
                Else
                    If Not String.IsNullOrEmpty(tImg.ThumbURL) Then
                        tImg.WebImage.FromWeb(tImg.ThumbURL)
                        If tImg.WebImage.Image IsNot Nothing Then
                            Directory.CreateDirectory(Directory.GetParent(tImg.LocalThumb).FullName)
                            tImg.WebImage.Save(tImg.LocalThumb)
                        End If
                    ElseIf Not String.IsNullOrEmpty(tImg.URL) Then
                        tImg.WebImage.FromWeb(tImg.URL)
                        If tImg.WebImage.Image IsNot Nothing Then
                            Directory.CreateDirectory(Directory.GetParent(tImg.LocalFile).FullName)
                            tImg.WebImage.Save(tImg.LocalFile)
                        End If
                    End If
                End If

                If Me.bwLoadImages.CancellationPending Then
                    Return True
                End If

                Me.bwLoadImages.ReportProgress(iProgress, "progress")
                iProgress += 1
            Next
        End If

        'Show Landscape / AllSeasons Landscape
        If Me._type = Enums.ImageType_TV.All OrElse Me._type = Enums.ImageType_TV.ShowLandscape OrElse Me._type = Enums.ImageType_TV.AllSeasonsLandscape Then
            For Each tImg As MediaContainers.Image In SearchResultsContainer.ShowLandscapes
                If File.Exists(tImg.LocalThumb) Then
                    tImg.WebImage.FromFile(tImg.LocalThumb)
                ElseIf File.Exists(tImg.LocalFile) AndAlso String.IsNullOrEmpty(tImg.ThumbURL) Then
                    tImg.WebImage.FromFile(tImg.LocalFile)
                Else
                    If Not String.IsNullOrEmpty(tImg.ThumbURL) Then
                        tImg.WebImage.FromWeb(tImg.ThumbURL)
                        If tImg.WebImage.Image IsNot Nothing Then
                            Directory.CreateDirectory(Directory.GetParent(tImg.LocalThumb).FullName)
                            tImg.WebImage.Save(tImg.LocalThumb)
                        End If
                    ElseIf Not String.IsNullOrEmpty(tImg.URL) Then
                        tImg.WebImage.FromWeb(tImg.URL)
                        If tImg.WebImage.Image IsNot Nothing Then
                            Directory.CreateDirectory(Directory.GetParent(tImg.LocalFile).FullName)
                            tImg.WebImage.Save(tImg.LocalFile)
                        End If
                    End If
                End If

                If Me.bwLoadImages.CancellationPending Then
                    Return True
                End If

                Me.bwLoadImages.ReportProgress(iProgress, "progress")
                iProgress += 1
            Next
        End If

        'Show Fanart / AllSeasons Fanart / Season Fanart / Episode Fanart
        If Me._type = Enums.ImageType_TV.All OrElse Me._type = Enums.ImageType_TV.ShowFanart OrElse Me._type = Enums.ImageType_TV.AllSeasonsFanart OrElse Me._type = Enums.ImageType_TV.SeasonFanart OrElse Me._type = Enums.ImageType_TV.EpisodeFanart Then
            For Each tImg As MediaContainers.Image In SearchResultsContainer.ShowFanarts
                If File.Exists(tImg.LocalThumb) Then
                    tImg.WebImage.FromFile(tImg.LocalThumb)
                ElseIf File.Exists(tImg.LocalFile) AndAlso String.IsNullOrEmpty(tImg.ThumbURL) Then
                    tImg.WebImage.FromFile(tImg.LocalFile)
                Else
                    If Not String.IsNullOrEmpty(tImg.ThumbURL) Then
                        tImg.WebImage.FromWeb(tImg.ThumbURL)
                        If tImg.WebImage.Image IsNot Nothing Then
                            Directory.CreateDirectory(Directory.GetParent(tImg.LocalThumb).FullName)
                            tImg.WebImage.Save(tImg.LocalThumb)
                        End If
                    ElseIf Not String.IsNullOrEmpty(tImg.URL) Then
                        tImg.WebImage.FromWeb(tImg.URL)
                        If tImg.WebImage.Image IsNot Nothing Then
                            Directory.CreateDirectory(Directory.GetParent(tImg.LocalFile).FullName)
                            tImg.WebImage.Save(tImg.LocalFile)
                        End If
                    End If
                End If

                If Me.bwLoadImages.CancellationPending Then
                    Return True
                End If

                Me.bwLoadImages.ReportProgress(iProgress, "progress")
                iProgress += 1
            Next
        End If

        Return Me.SetDefaults()
    End Function

    Private Sub DownloadFullsizeImage(ByVal iTag As MediaContainers.Image, ByRef tImage As Images)
        Dim sHTTP As New HTTP

        If Not String.IsNullOrEmpty(iTag.LocalFile) AndAlso File.Exists(iTag.LocalFile) Then
            tImage.FromFile(iTag.LocalFile)
        ElseIf Not String.IsNullOrEmpty(iTag.LocalFile) AndAlso Not String.IsNullOrEmpty(iTag.URL) Then
            Me.lblStatus.Text = Master.eLang.GetString(952, "Downloading Fullsize Image...")
            Me.pbStatus.Style = ProgressBarStyle.Marquee
            Me.pnlStatus.Visible = True

            Application.DoEvents()

            tImage.FromWeb(iTag.URL)
            If tImage.Image IsNot Nothing Then
                Directory.CreateDirectory(Directory.GetParent(iTag.LocalFile).FullName)
                tImage.Save(iTag.LocalFile)
            End If

            sHTTP = Nothing

            Me.pnlStatus.Visible = False
        End If

    End Sub

    Private Sub GenerateList()
        If (Me._type = Enums.ImageType_TV.All OrElse Me._type = Enums.ImageType_TV.ShowBanner) AndAlso Master.eSettings.TVShowBannerAnyEnabled Then Me.tvList.Nodes.Add(New TreeNode With {.Text = Master.eLang.GetString(658, "TV Show Banner"), .Tag = "showb", .ImageIndex = 0, .SelectedImageIndex = 0})
        If (Me._type = Enums.ImageType_TV.All OrElse Me._type = Enums.ImageType_TV.ShowCharacterArt) AndAlso Master.eSettings.TVShowCharacterArtAnyEnabled Then Me.tvList.Nodes.Add(New TreeNode With {.Text = Master.eLang.GetString(1011, "TV Show CharacterArt"), .Tag = "showch", .ImageIndex = 1, .SelectedImageIndex = 1})
        If (Me._type = Enums.ImageType_TV.All OrElse Me._type = Enums.ImageType_TV.ShowClearArt) AndAlso Master.eSettings.TVShowClearArtAnyEnabled Then Me.tvList.Nodes.Add(New TreeNode With {.Text = Master.eLang.GetString(1013, "TV Show ClearArt"), .Tag = "showca", .ImageIndex = 2, .SelectedImageIndex = 2})
        If (Me._type = Enums.ImageType_TV.All OrElse Me._type = Enums.ImageType_TV.ShowClearLogo) AndAlso Master.eSettings.TVShowClearLogoAnyEnabled Then Me.tvList.Nodes.Add(New TreeNode With {.Text = Master.eLang.GetString(1012, "TV Show ClearLogo"), .Tag = "showcl", .ImageIndex = 3, .SelectedImageIndex = 3})
        If (Me._type = Enums.ImageType_TV.All OrElse Me._type = Enums.ImageType_TV.ShowFanart OrElse Me._type = Enums.ImageType_TV.EpisodeFanart) AndAlso (Master.eSettings.TVShowFanartAnyEnabled OrElse Master.eSettings.TVEpisodeFanartAnyEnabled) Then Me.tvList.Nodes.Add(New TreeNode With {.Text = If(Me._type = Enums.ImageType_TV.EpisodeFanart, Master.eLang.GetString(688, "Episode Fanart"), Master.eLang.GetString(684, "TV Show Fanart")), .Tag = "showf", .ImageIndex = 4, .SelectedImageIndex = 4})
        If (Me._type = Enums.ImageType_TV.All OrElse Me._type = Enums.ImageType_TV.ShowLandscape) AndAlso Master.eSettings.TVShowLandscapeAnyEnabled Then Me.tvList.Nodes.Add(New TreeNode With {.Text = Master.eLang.GetString(1010, "TV Show Landscape"), .Tag = "showl", .ImageIndex = 5, .SelectedImageIndex = 5})
        If (Me._type = Enums.ImageType_TV.All OrElse Me._type = Enums.ImageType_TV.ShowPoster) AndAlso Master.eSettings.TVShowPosterAnyEnabled Then Me.tvList.Nodes.Add(New TreeNode With {.Text = Master.eLang.GetString(956, "TV Show Poster"), .Tag = "showp", .ImageIndex = 6, .SelectedImageIndex = 6})
        If (Me._type = Enums.ImageType_TV.All OrElse Me._type = Enums.ImageType_TV.AllSeasonsBanner) AndAlso Master.eSettings.TVASBannerAnyEnabled Then Me.tvList.Nodes.Add(New TreeNode With {.Text = Master.eLang.GetString(1014, "All Seasons Banner"), .Tag = "allb", .ImageIndex = 0, .SelectedImageIndex = 0})
        If (Me._type = Enums.ImageType_TV.All OrElse Me._type = Enums.ImageType_TV.AllSeasonsFanart) AndAlso Master.eSettings.TVASFanartAnyEnabled Then Me.tvList.Nodes.Add(New TreeNode With {.Text = Master.eLang.GetString(1015, "All Seasons Fanart"), .Tag = "allf", .ImageIndex = 4, .SelectedImageIndex = 4})
        If (Me._type = Enums.ImageType_TV.All OrElse Me._type = Enums.ImageType_TV.AllSeasonsLandscape) AndAlso Master.eSettings.TVASLandscapeAnyEnabled Then Me.tvList.Nodes.Add(New TreeNode With {.Text = Master.eLang.GetString(1016, "All Seasons Landscape"), .Tag = "alll", .ImageIndex = 5, .SelectedImageIndex = 5})
        If (Me._type = Enums.ImageType_TV.All OrElse Me._type = Enums.ImageType_TV.AllSeasonsPoster) AndAlso Master.eSettings.TVASPosterAnyEnabled Then Me.tvList.Nodes.Add(New TreeNode With {.Text = Master.eLang.GetString(735, "All Seasons Poster"), .Tag = "allp", .ImageIndex = 6, .SelectedImageIndex = 6})

        Dim TnS As TreeNode
        If Me._type = Enums.ImageType_TV.All Then
            For Each cSeason As Structures.DBTV In tmpShowContainer.Seasons.OrderBy(Function(s) s.TVSeason.Season)
                TnS = New TreeNode(String.Format(Master.eLang.GetString(726, "Season {0}"), cSeason.TVSeason.Season), 7, 7)
                If Master.eSettings.TVSeasonBannerAnyEnabled Then TnS.Nodes.Add(New TreeNode With {.Text = Master.eLang.GetString(1017, "Season Banner"), .Tag = String.Concat("b", cSeason.TVSeason.Season), .ImageIndex = 0, .SelectedImageIndex = 0})
                If Master.eSettings.TVSeasonFanartAnyEnabled Then TnS.Nodes.Add(New TreeNode With {.Text = Master.eLang.GetString(686, "Season Fanart"), .Tag = String.Concat("f", cSeason.TVSeason.Season), .ImageIndex = 4, .SelectedImageIndex = 4})
                If Master.eSettings.TVSeasonLandscapeAnyEnabled Then TnS.Nodes.Add(New TreeNode With {.Text = Master.eLang.GetString(1018, "Season Landscape"), .Tag = String.Concat("l", cSeason.TVSeason.Season), .ImageIndex = 5, .SelectedImageIndex = 5})
                If Master.eSettings.TVSeasonPosterAnyEnabled Then TnS.Nodes.Add(New TreeNode With {.Text = Master.eLang.GetString(685, "Season Posters"), .Tag = String.Concat("p", cSeason.TVSeason.Season), .ImageIndex = 6, .SelectedImageIndex = 6})
                Me.tvList.Nodes.Add(TnS)
            Next
        ElseIf Me._type = Enums.ImageType_TV.SeasonBanner Then
            If Master.eSettings.TVSeasonBannerAnyEnabled Then Me.tvList.Nodes.Add(New TreeNode With {.Text = String.Format(Master.eLang.GetString(1019, "Season {0} Banner"), Me._season), .Tag = String.Concat("b", Me._season)})
        ElseIf Me._type = Enums.ImageType_TV.SeasonFanart Then
            If Master.eSettings.TVSeasonFanartAnyEnabled Then Me.tvList.Nodes.Add(New TreeNode With {.Text = String.Format(Master.eLang.GetString(962, "Season {0} Fanart"), Me._season), .Tag = String.Concat("f", Me._season)})
        ElseIf Me._type = Enums.ImageType_TV.SeasonLandscape Then
            If Master.eSettings.TVSeasonLandscapeAnyEnabled Then Me.tvList.Nodes.Add(New TreeNode With {.Text = String.Format(Master.eLang.GetString(1020, "Season {0} Landscape"), Me._season), .Tag = String.Concat("l", Me._season)})
        ElseIf Me._type = Enums.ImageType_TV.SeasonPoster Then
            If Master.eSettings.TVSeasonPosterAnyEnabled Then Me.tvList.Nodes.Add(New TreeNode With {.Text = String.Format(Master.eLang.GetString(961, "Season {0} Posters"), Me._season), .Tag = String.Concat("p", Me._season)})
        End If

        Me.tvList.ExpandAll()
    End Sub

    Private Sub lblImage_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim iindex As Integer = Convert.ToInt32(DirectCast(sender, Label).Name)
        Me.DoSelect(iindex, DirectCast(DirectCast(sender, Label).Tag, MediaContainers.Image))
    End Sub

    Private Sub MouseWheelEvent(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Dim vScrollPosition As Integer = pnlImages.VerticalScroll.Value
        vScrollPosition -= Math.Sign(e.Delta) * 50
        vScrollPosition = Math.Max(0, vScrollPosition)
        vScrollPosition = Math.Min(vScrollPosition, pnlImages.VerticalScroll.Maximum)
        pnlImages.AutoScrollPosition = New Point(pnlImages.AutoScrollPosition.X, vScrollPosition)
        pnlImages.Invalidate()
    End Sub

    Private Sub pbDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbDelete.Click
        Me.pbCurrent.Image = Nothing
        Me.pbCurrent.Tag = Nothing
        Me.SetImage(New MediaContainers.Image)
    End Sub

    Private Sub pbImage_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.DoSelect(Convert.ToInt32(DirectCast(sender, PictureBox).Name), DirectCast(DirectCast(sender, PictureBox).Tag, MediaContainers.Image))
    End Sub

    Private Sub pbImage_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim tImages As New Images
        Dim iTag As MediaContainers.Image = DirectCast(DirectCast(sender, PictureBox).Tag, MediaContainers.Image)
        DownloadFullsizeImage(iTag, tImages)

        ModulesManager.Instance.RuntimeObjects.InvokeOpenImageViewer(tImages.Image)
    End Sub

    Private Sub pbUndo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbUndo.Click
        If Me.SelSeason = -999 Then
            If SelImgType = Enums.ImageType_TV.ShowBanner Then
                tmpShowContainer.ImagesContainer.Banner = DefaultImagesContainer.Banner
                Me.pbCurrent.Image = tmpShowContainer.ImagesContainer.Banner.WebImage.Image
                Me.pbCurrent.Tag = tmpShowContainer.ImagesContainer.Banner
            ElseIf SelImgType = Enums.ImageType_TV.ShowCharacterArt Then
                tmpShowContainer.ImagesContainer.CharacterArt = DefaultImagesContainer.CharacterArt
                Me.pbCurrent.Image = tmpShowContainer.ImagesContainer.CharacterArt.WebImage.Image
                Me.pbCurrent.Tag = tmpShowContainer.ImagesContainer.CharacterArt
            ElseIf SelImgType = Enums.ImageType_TV.ShowClearArt Then
                tmpShowContainer.ImagesContainer.ClearArt = DefaultImagesContainer.ClearArt
                Me.pbCurrent.Image = tmpShowContainer.ImagesContainer.ClearArt.WebImage.Image
                Me.pbCurrent.Tag = tmpShowContainer.ImagesContainer.ClearArt
            ElseIf SelImgType = Enums.ImageType_TV.ShowClearLogo Then
                tmpShowContainer.ImagesContainer.ClearLogo = DefaultImagesContainer.ClearLogo
                Me.pbCurrent.Image = tmpShowContainer.ImagesContainer.ClearLogo.WebImage.Image
                Me.pbCurrent.Tag = tmpShowContainer.ImagesContainer.ClearLogo
            ElseIf SelImgType = Enums.ImageType_TV.ShowFanart Then
                tmpShowContainer.ImagesContainer.Fanart = DefaultImagesContainer.Fanart
                Me.pbCurrent.Image = tmpShowContainer.ImagesContainer.Fanart.WebImage.Image
                Me.pbCurrent.Tag = tmpShowContainer.ImagesContainer.Fanart
            ElseIf SelImgType = Enums.ImageType_TV.ShowPoster Then
                tmpShowContainer.ImagesContainer.Poster = DefaultImagesContainer.Poster
                Me.pbCurrent.Image = tmpShowContainer.ImagesContainer.Poster.WebImage.Image
                Me.pbCurrent.Tag = tmpShowContainer.ImagesContainer.Poster
            End If
            'ElseIf Me.SelSeason = 999 Then
            'If SelImgType = Enums.ImageType_TV.AllSeasonsBanner Then
            '    ImageResultsContainer.SeasonBanner = DefaultImagesContainer.SeasonBanner
            '    Me.pbCurrent.Image = ImageResultsContainer.SeasonBanner.WebImage.Image
            '    Me.pbCurrent.Tag = ImageResultsContainer.SeasonBanner
            'ElseIf SelImgType = Enums.ImageType_TV.AllSeasonsFanart Then
            '    ImageResultsContainer.SeasonFanart = DefaultImagesContainer.SeasonFanart
            '    Me.pbCurrent.Image = ImageResultsContainer.SeasonFanart.WebImage.Image
            '    Me.pbCurrent.Tag = ImageResultsContainer.SeasonFanart
            'ElseIf SelImgType = Enums.ImageType_TV.AllSeasonsLandscape Then
            '    ImageResultsContainer.SeasonLandscape = DefaultImagesContainer.SeasonLandscape
            '    Me.pbCurrent.Image = ImageResultsContainer.SeasonLandscape.WebImage.Image
            '    Me.pbCurrent.Tag = ImageResultsContainer.SeasonLandscape
            'ElseIf SelImgType = Enums.ImageType_TV.AllSeasonsPoster Then
            '    ImageResultsContainer.SeasonPoster = DefaultImagesContainer.SeasonPoster
            '    Me.pbCurrent.Image = ImageResultsContainer.SeasonPoster.WebImage.Image
            '    Me.pbCurrent.Tag = ImageResultsContainer.SeasonPoster
            'End If
        Else
            If SelImgType = Enums.ImageType_TV.SeasonBanner Then
                Dim sImg As MediaContainers.Image = DefaultSeasonImagesContainer.FirstOrDefault(Function(s) s.Season = Me.SelSeason).Banner
                tmpShowContainer.Seasons.FirstOrDefault(Function(s) s.TVSeason.Season = Me.SelSeason).ImagesContainer.Banner = sImg
                Me.pbCurrent.Image = sImg.WebImage.Image
                Me.pbCurrent.Tag = sImg
            ElseIf SelImgType = Enums.ImageType_TV.SeasonFanart Then
                Dim sImg As MediaContainers.Image = DefaultSeasonImagesContainer.FirstOrDefault(Function(s) s.Season = Me.SelSeason).Fanart
                tmpShowContainer.Seasons.FirstOrDefault(Function(s) s.TVSeason.Season = Me.SelSeason).ImagesContainer.Fanart = sImg
                Me.pbCurrent.Image = sImg.WebImage.Image
                Me.pbCurrent.Tag = sImg
            ElseIf SelImgType = Enums.ImageType_TV.SeasonLandscape Then
                Dim sImg As MediaContainers.Image = DefaultSeasonImagesContainer.FirstOrDefault(Function(s) s.Season = Me.SelSeason).Landscape
                tmpShowContainer.Seasons.FirstOrDefault(Function(s) s.TVSeason.Season = Me.SelSeason).ImagesContainer.Landscape = sImg
                Me.pbCurrent.Image = sImg.WebImage.Image
                Me.pbCurrent.Tag = sImg
            ElseIf SelImgType = Enums.ImageType_TV.SeasonPoster Then
                Dim sImg As MediaContainers.Image = DefaultSeasonImagesContainer.FirstOrDefault(Function(s) s.Season = Me.SelSeason).Poster
                tmpShowContainer.Seasons.FirstOrDefault(Function(s) s.TVSeason.Season = Me.SelSeason).ImagesContainer.Poster = sImg
                Me.pbCurrent.Image = sImg.WebImage.Image
                Me.pbCurrent.Tag = sImg
            End If
        End If
    End Sub

    Private Sub pnlImage_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim iIndex As Integer = Convert.ToInt32(DirectCast(sender, Panel).Name)
        Me.DoSelect(iIndex, DirectCast(DirectCast(sender, Panel).Tag, MediaContainers.Image))
    End Sub

    Private Sub SetImage(ByVal SelTag As MediaContainers.Image)
        If SelTag.WebImage.Image IsNot Nothing Then
            Me.pbCurrent.Image = SelTag.WebImage.Image
            Me.pbCurrent.Tag = SelTag
        End If

        If Me.SelSeason = -999 Then
            If SelImgType = Enums.ImageType_TV.ShowBanner Then
                tmpShowContainer.ImagesContainer.Banner = SelTag
            ElseIf SelImgType = Enums.ImageType_TV.ShowCharacterArt Then
                tmpShowContainer.ImagesContainer.CharacterArt = SelTag
            ElseIf SelImgType = Enums.ImageType_TV.ShowClearArt Then
                tmpShowContainer.ImagesContainer.ClearArt = SelTag
            ElseIf SelImgType = Enums.ImageType_TV.ShowClearLogo Then
                tmpShowContainer.ImagesContainer.ClearLogo = SelTag
            ElseIf SelImgType = Enums.ImageType_TV.ShowLandscape Then
                tmpShowContainer.ImagesContainer.Landscape = SelTag
            ElseIf SelImgType = Enums.ImageType_TV.ShowFanart Then
                tmpShowContainer.ImagesContainer.Fanart = SelTag
            ElseIf SelImgType = Enums.ImageType_TV.ShowPoster Then
                tmpShowContainer.ImagesContainer.Poster = SelTag
            End If
            'ElseIf Me.SelSeason = 999 Then
            '    If SelImgType = Enums.ImageType_TV.AllSeasonsBanner Then
            '        ImageResultsContainer.SeasonBanner = SelTag
            '    ElseIf SelImgType = Enums.ImageType_TV.AllSeasonsFanart Then
            '        ImageResultsContainer.SeasonFanart = SelTag
            '    ElseIf SelImgType = Enums.ImageType_TV.AllSeasonsLandscape Then
            '        ImageResultsContainer.SeasonLandscape = SelTag
            '    ElseIf SelImgType = Enums.ImageType_TV.AllSeasonsPoster Then
            '        ImageResultsContainer.SeasonPoster = SelTag
            '    End If
        Else
            If SelImgType = Enums.ImageType_TV.SeasonBanner Then
                tmpShowContainer.Seasons.FirstOrDefault(Function(s) s.TVSeason.Season = Me.SelSeason).ImagesContainer.Banner = SelTag
            ElseIf SelImgType = Enums.ImageType_TV.SeasonFanart Then
                tmpShowContainer.Seasons.FirstOrDefault(Function(s) s.TVSeason.Season = Me.SelSeason).ImagesContainer.Fanart = SelTag
            ElseIf SelImgType = Enums.ImageType_TV.SeasonLandscape Then
                tmpShowContainer.Seasons.FirstOrDefault(Function(s) s.TVSeason.Season = Me.SelSeason).ImagesContainer.Landscape = SelTag
            ElseIf SelImgType = Enums.ImageType_TV.SeasonPoster Then
                tmpShowContainer.Seasons.FirstOrDefault(Function(s) s.TVSeason.Season = Me.SelSeason).ImagesContainer.Poster = SelTag
            End If
        End If
    End Sub

    Private Sub SetUp()
        Me.Text = Master.eLang.GetString(963, "TV Image Selection")
        Me.btnOK.Text = Master.eLang.GetString(179, "OK")
        Me.btnCancel.Text = Master.eLang.GetString(167, "Cancel")
        Me.lblCurrentImage.Text = Master.eLang.GetString(964, "Current Image:")
    End Sub

    Private Sub tvList_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles tvList.AfterSelect
        Dim iCount As Integer = 0

        ClearImages()
        If e.Node.Tag IsNot Nothing AndAlso Not String.IsNullOrEmpty(e.Node.Tag.ToString) Then
            Me.pbCurrent.Visible = True
            Me.lblCurrentImage.Visible = True

            'Show Banner
            If e.Node.Tag.ToString = "showb" Then
                Me.SelSeason = -999
                Me.SelImgType = Enums.ImageType_TV.ShowBanner
                If tmpShowContainer.ImagesContainer.Banner IsNot Nothing AndAlso tmpShowContainer.ImagesContainer.Banner.WebImage IsNot Nothing AndAlso tmpShowContainer.ImagesContainer.Banner.WebImage.Image IsNot Nothing Then
                    Me.pbCurrent.Image = tmpShowContainer.ImagesContainer.Banner.WebImage.Image
                Else
                    Me.pbCurrent.Image = Nothing
                End If
                iCount = 0
                For Each tvImage As MediaContainers.Image In SearchResultsContainer.ShowBanners
                    If tvImage IsNot Nothing AndAlso tvImage.WebImage IsNot Nothing AndAlso tvImage.WebImage.Image IsNot Nothing Then
                        Dim imgText As String = String.Empty
                        If CDbl(tvImage.Width) = 0 OrElse CDbl(tvImage.Height) = 0 Then
                            imgText = String.Format("{0}x{1}", tvImage.WebImage.Image.Size.Width, tvImage.WebImage.Image.Size.Height & Environment.NewLine & tvImage.LongLang)
                        Else
                            imgText = String.Format("{0}x{1}", tvImage.Width, tvImage.Height & Environment.NewLine & tvImage.LongLang)
                        End If
                        Me.AddImage(imgText, iCount, tvImage)
                    End If
                    iCount += 1
                Next

                'Show Characterart
            ElseIf e.Node.Tag.ToString = "showch" Then
                Me.SelSeason = -999
                Me.SelImgType = Enums.ImageType_TV.ShowCharacterArt
                If tmpShowContainer.ImagesContainer.CharacterArt IsNot Nothing AndAlso tmpShowContainer.ImagesContainer.CharacterArt.WebImage IsNot Nothing AndAlso tmpShowContainer.ImagesContainer.CharacterArt.WebImage.Image IsNot Nothing Then
                    Me.pbCurrent.Image = tmpShowContainer.ImagesContainer.CharacterArt.WebImage.Image
                Else
                    Me.pbCurrent.Image = Nothing
                End If
                iCount = 0
                For Each tvImage As MediaContainers.Image In SearchResultsContainer.ShowCharacterArts
                    If tvImage IsNot Nothing AndAlso tvImage.WebImage IsNot Nothing AndAlso tvImage.WebImage.Image IsNot Nothing Then
                        Dim imgText As String = String.Empty
                        If CDbl(tvImage.Width) = 0 OrElse CDbl(tvImage.Height) = 0 Then
                            imgText = String.Format("{0}x{1}", tvImage.WebImage.Image.Size.Width, tvImage.WebImage.Image.Size.Height & Environment.NewLine & tvImage.LongLang)
                        Else
                            imgText = String.Format("{0}x{1}", tvImage.Width, tvImage.Height & Environment.NewLine & tvImage.LongLang)
                        End If
                        Me.AddImage(imgText, iCount, tvImage)
                    End If
                    iCount += 1
                Next

                'Show ClearArt
            ElseIf e.Node.Tag.ToString = "showca" Then
                Me.SelSeason = -999
                Me.SelImgType = Enums.ImageType_TV.ShowClearArt
                If tmpShowContainer.ImagesContainer.ClearArt IsNot Nothing AndAlso tmpShowContainer.ImagesContainer.ClearArt.WebImage IsNot Nothing AndAlso tmpShowContainer.ImagesContainer.ClearArt.WebImage.Image IsNot Nothing Then
                    Me.pbCurrent.Image = tmpShowContainer.ImagesContainer.ClearArt.WebImage.Image
                Else
                    Me.pbCurrent.Image = Nothing
                End If
                iCount = 0
                For Each tvImage As MediaContainers.Image In SearchResultsContainer.ShowClearArts
                    If tvImage IsNot Nothing AndAlso tvImage.WebImage IsNot Nothing AndAlso tvImage.WebImage.Image IsNot Nothing Then
                        Dim imgText As String = String.Empty
                        If CDbl(tvImage.Width) = 0 OrElse CDbl(tvImage.Height) = 0 Then
                            imgText = String.Format("{0}x{1}", tvImage.WebImage.Image.Size.Width, tvImage.WebImage.Image.Size.Height & Environment.NewLine & tvImage.LongLang)
                        Else
                            imgText = String.Format("{0}x{1}", tvImage.Width, tvImage.Height & Environment.NewLine & tvImage.LongLang)
                        End If
                        Me.AddImage(imgText, iCount, tvImage)
                    End If
                    iCount += 1
                Next

                'Show ClearLogo
            ElseIf e.Node.Tag.ToString = "showcl" Then
                Me.SelSeason = -999
                Me.SelImgType = Enums.ImageType_TV.ShowClearLogo
                If tmpShowContainer.ImagesContainer.ClearLogo IsNot Nothing AndAlso tmpShowContainer.ImagesContainer.ClearLogo.WebImage IsNot Nothing AndAlso tmpShowContainer.ImagesContainer.ClearLogo.WebImage.Image IsNot Nothing Then
                    Me.pbCurrent.Image = tmpShowContainer.ImagesContainer.ClearLogo.WebImage.Image
                Else
                    Me.pbCurrent.Image = Nothing
                End If
                iCount = 0
                For Each tvImage As MediaContainers.Image In SearchResultsContainer.ShowClearLogos
                    If tvImage IsNot Nothing AndAlso tvImage.WebImage IsNot Nothing AndAlso tvImage.WebImage.Image IsNot Nothing Then
                        Dim imgText As String = String.Empty
                        If CDbl(tvImage.Width) = 0 OrElse CDbl(tvImage.Height) = 0 Then
                            imgText = String.Format("{0}x{1}", tvImage.WebImage.Image.Size.Width, tvImage.WebImage.Image.Size.Height & Environment.NewLine & tvImage.LongLang)
                        Else
                            imgText = String.Format("{0}x{1}", tvImage.Width, tvImage.Height & Environment.NewLine & tvImage.LongLang)
                        End If
                        Me.AddImage(imgText, iCount, tvImage)
                    End If
                    iCount += 1
                Next

                'Show Fanart
            ElseIf e.Node.Tag.ToString = "showf" Then
                Me.SelSeason = -999
                Me.SelImgType = Enums.ImageType_TV.ShowFanart
                If tmpShowContainer.ImagesContainer.Fanart IsNot Nothing AndAlso tmpShowContainer.ImagesContainer.Fanart.WebImage IsNot Nothing AndAlso tmpShowContainer.ImagesContainer.Fanart.WebImage.Image IsNot Nothing Then
                    Me.pbCurrent.Image = tmpShowContainer.ImagesContainer.Fanart.WebImage.Image
                Else
                    Me.pbCurrent.Image = Nothing
                End If
                iCount = 0
                For Each tvImage As MediaContainers.Image In SearchResultsContainer.ShowFanarts
                    If tvImage IsNot Nothing AndAlso tvImage.WebImage IsNot Nothing AndAlso tvImage.WebImage.Image IsNot Nothing Then
                        Dim imgText As String = String.Empty
                        If CDbl(tvImage.Width) = 0 OrElse CDbl(tvImage.Height) = 0 Then
                            imgText = String.Format("{0}x{1}", tvImage.WebImage.Image.Size.Width, tvImage.WebImage.Image.Size.Height & Environment.NewLine & tvImage.LongLang)
                        Else
                            imgText = String.Format("{0}x{1}", tvImage.Width, tvImage.Height & Environment.NewLine & tvImage.LongLang)
                        End If
                        Me.AddImage(imgText, iCount, tvImage)
                    End If
                    iCount += 1
                Next

                'Show Landscape
            ElseIf e.Node.Tag.ToString = "showl" Then
                Me.SelSeason = -999
                Me.SelImgType = Enums.ImageType_TV.ShowLandscape
                If tmpShowContainer.ImagesContainer.Landscape IsNot Nothing AndAlso tmpShowContainer.ImagesContainer.Landscape.WebImage IsNot Nothing AndAlso tmpShowContainer.ImagesContainer.Landscape.WebImage.Image IsNot Nothing Then
                    Me.pbCurrent.Image = tmpShowContainer.ImagesContainer.Landscape.WebImage.Image
                Else
                    Me.pbCurrent.Image = Nothing
                End If
                iCount = 0
                For Each tvImage As MediaContainers.Image In SearchResultsContainer.ShowLandscapes
                    If tvImage IsNot Nothing AndAlso tvImage.WebImage IsNot Nothing AndAlso tvImage.WebImage.Image IsNot Nothing Then
                        Dim imgText As String = String.Empty
                        If CDbl(tvImage.Width) = 0 OrElse CDbl(tvImage.Height) = 0 Then
                            imgText = String.Format("{0}x{1}", tvImage.WebImage.Image.Size.Width, tvImage.WebImage.Image.Size.Height & Environment.NewLine & tvImage.LongLang)
                        Else
                            imgText = String.Format("{0}x{1}", tvImage.Width, tvImage.Height & Environment.NewLine & tvImage.LongLang)
                        End If
                        Me.AddImage(imgText, iCount, tvImage)
                    End If
                    iCount += 1
                Next

                'Show Poster
            ElseIf e.Node.Tag.ToString = "showp" Then
                Me.SelSeason = -999
                Me.SelImgType = Enums.ImageType_TV.ShowPoster
                If tmpShowContainer.ImagesContainer.Poster IsNot Nothing AndAlso tmpShowContainer.ImagesContainer.Poster.WebImage IsNot Nothing AndAlso tmpShowContainer.ImagesContainer.Poster.WebImage.Image IsNot Nothing Then
                    Me.pbCurrent.Image = tmpShowContainer.ImagesContainer.Poster.WebImage.Image
                Else
                    Me.pbCurrent.Image = Nothing
                End If
                iCount = 0
                For Each tvImage As MediaContainers.Image In SearchResultsContainer.ShowPosters
                    If tvImage IsNot Nothing AndAlso tvImage.WebImage IsNot Nothing AndAlso tvImage.WebImage.Image IsNot Nothing Then
                        Dim imgText As String = String.Empty
                        If CDbl(tvImage.Width) = 0 OrElse CDbl(tvImage.Height) = 0 Then
                            imgText = String.Format("{0}x{1}", tvImage.WebImage.Image.Size.Width, tvImage.WebImage.Image.Size.Height & Environment.NewLine & tvImage.LongLang)
                        Else
                            imgText = String.Format("{0}x{1}", tvImage.Width, tvImage.Height & Environment.NewLine & tvImage.LongLang)
                        End If
                        Me.AddImage(imgText, iCount, tvImage)
                    End If
                    iCount += 1
                Next

                'AllSeasons Banner
                'ElseIf e.Node.Tag.ToString = "allb" Then
                '    Me.SelSeason = 999
                '    Me.SelImgType = Enums.ImageType_TV.AllSeasonsBanner
                '    If ImageResultsContainer.SeasonBanner IsNot Nothing AndAlso ImageResultsContainer.SeasonBanner.WebImage IsNot Nothing AndAlso ImageResultsContainer.SeasonBanner.WebImage.Image IsNot Nothing Then
                '        Me.pbCurrent.Image = ImageResultsContainer.SeasonBanner.WebImage.Image
                '    Else
                '        Me.pbCurrent.Image = Nothing
                '    End If
                '    iCount = 0
                '    For Each tvImage As MediaContainers.Image In SearchResultsContainer.SeasonBanners.Where(Function(f) f.Season = 999)
                '        If tvImage IsNot Nothing AndAlso tvImage.WebImage IsNot Nothing AndAlso tvImage.WebImage.Image IsNot Nothing Then
                '            Dim imgText As String = String.Empty
                '            If CDbl(tvImage.Width) = 0 OrElse CDbl(tvImage.Height) = 0 Then
                '                imgText = String.Format("{0}x{1}", tvImage.WebImage.Image.Size.Width, tvImage.WebImage.Image.Size.Height & Environment.NewLine & tvImage.LongLang)
                '            Else
                '                imgText = String.Format("{0}x{1}", tvImage.Width, tvImage.Height & Environment.NewLine & tvImage.LongLang)
                '            End If
                '            Me.AddImage(imgText, iCount, tvImage)
                '        End If
                '        iCount += 1
                '    Next
                '    For Each tvImage As MediaContainers.Image In SearchResultsContainer.ShowBanners
                '        If tvImage IsNot Nothing AndAlso tvImage.WebImage IsNot Nothing AndAlso tvImage.WebImage.Image IsNot Nothing Then
                '            Dim imgText As String = String.Empty
                '            If CDbl(tvImage.Width) = 0 OrElse CDbl(tvImage.Height) = 0 Then
                '                imgText = String.Format("{0}x{1}", tvImage.WebImage.Image.Size.Width, tvImage.WebImage.Image.Size.Height & Environment.NewLine & tvImage.LongLang)
                '            Else
                '                imgText = String.Format("{0}x{1}", tvImage.Width, tvImage.Height & Environment.NewLine & tvImage.LongLang)
                '            End If
                '            Me.AddImage(imgText, iCount, tvImage)
                '        End If
                '        iCount += 1
                '    Next

                '    'AllSeasons Fanart
                'ElseIf e.Node.Tag.ToString = "allf" Then
                '    Me.SelSeason = 999
                '    Me.SelImgType = Enums.ImageType_TV.AllSeasonsFanart
                '    If ImageResultsContainer.SeasonFanart IsNot Nothing AndAlso ImageResultsContainer.SeasonFanart.WebImage IsNot Nothing AndAlso ImageResultsContainer.SeasonFanart.WebImage.Image IsNot Nothing Then
                '        Me.pbCurrent.Image = ImageResultsContainer.SeasonFanart.WebImage.Image
                '    Else
                '        Me.pbCurrent.Image = Nothing
                '    End If
                '    iCount = 0
                '    For Each tvImage As MediaContainers.Image In SearchResultsContainer.ShowFanarts
                '        If tvImage IsNot Nothing AndAlso tvImage.WebImage IsNot Nothing AndAlso tvImage.WebImage.Image IsNot Nothing Then
                '            Dim imgText As String = String.Empty
                '            If CDbl(tvImage.Width) = 0 OrElse CDbl(tvImage.Height) = 0 Then
                '                imgText = String.Format("{0}x{1}", tvImage.WebImage.Image.Size.Width, tvImage.WebImage.Image.Size.Height & Environment.NewLine & tvImage.LongLang)
                '            Else
                '                imgText = String.Format("{0}x{1}", tvImage.Width, tvImage.Height & Environment.NewLine & tvImage.LongLang)
                '            End If
                '            Me.AddImage(imgText, iCount, tvImage)
                '        End If
                '        iCount += 1
                '    Next

                '    'AllSeasons Landscape
                'ElseIf e.Node.Tag.ToString = "alll" Then
                '    Me.SelSeason = 999
                '    Me.SelImgType = Enums.ImageType_TV.AllSeasonsLandscape
                '    If ImageResultsContainer.SeasonLandscape IsNot Nothing AndAlso ImageResultsContainer.SeasonLandscape.WebImage IsNot Nothing AndAlso ImageResultsContainer.SeasonLandscape.WebImage.Image IsNot Nothing Then
                '        Me.pbCurrent.Image = ImageResultsContainer.SeasonLandscape.WebImage.Image
                '    Else
                '        Me.pbCurrent.Image = Nothing
                '    End If
                '    iCount = 0
                '    For Each tvImage As MediaContainers.Image In SearchResultsContainer.SeasonLandscapes.Where(Function(f) f.Season = 999)
                '        If tvImage IsNot Nothing AndAlso tvImage.WebImage IsNot Nothing AndAlso tvImage.WebImage.Image IsNot Nothing Then
                '            Dim imgText As String = String.Empty
                '            If CDbl(tvImage.Width) = 0 OrElse CDbl(tvImage.Height) = 0 Then
                '                imgText = String.Format("{0}x{1}", tvImage.WebImage.Image.Size.Width, tvImage.WebImage.Image.Size.Height & Environment.NewLine & tvImage.LongLang)
                '            Else
                '                imgText = String.Format("{0}x{1}", tvImage.Width, tvImage.Height & Environment.NewLine & tvImage.LongLang)
                '            End If
                '            Me.AddImage(imgText, iCount, tvImage)
                '        End If
                '        iCount += 1
                '    Next
                '    For Each tvImage As MediaContainers.Image In SearchResultsContainer.ShowLandscapes
                '        If tvImage IsNot Nothing AndAlso tvImage.WebImage IsNot Nothing AndAlso tvImage.WebImage.Image IsNot Nothing Then
                '            Dim imgText As String = String.Empty
                '            If CDbl(tvImage.Width) = 0 OrElse CDbl(tvImage.Height) = 0 Then
                '                imgText = String.Format("{0}x{1}", tvImage.WebImage.Image.Size.Width, tvImage.WebImage.Image.Size.Height & Environment.NewLine & tvImage.LongLang)
                '            Else
                '                imgText = String.Format("{0}x{1}", tvImage.Width, tvImage.Height & Environment.NewLine & tvImage.LongLang)
                '            End If
                '            Me.AddImage(imgText, iCount, tvImage)
                '        End If
                '        iCount += 1
                '    Next

                '    'AllSeasons Poster
                'ElseIf e.Node.Tag.ToString = "allp" Then
                '    Me.SelSeason = 999
                '    Me.SelImgType = Enums.ImageType_TV.AllSeasonsPoster
                '    If ImageResultsContainer.SeasonPoster IsNot Nothing AndAlso ImageResultsContainer.SeasonPoster.WebImage IsNot Nothing AndAlso ImageResultsContainer.SeasonPoster.WebImage.Image IsNot Nothing Then
                '        Me.pbCurrent.Image = ImageResultsContainer.SeasonPoster.WebImage.Image
                '    Else
                '        Me.pbCurrent.Image = Nothing
                '    End If
                '    iCount = 0
                '    For Each tvImage As MediaContainers.Image In SearchResultsContainer.SeasonPosters.Where(Function(f) f.Season = 999)
                '        If tvImage IsNot Nothing AndAlso tvImage.WebImage IsNot Nothing AndAlso tvImage.WebImage.Image IsNot Nothing Then
                '            Dim imgText As String = String.Empty
                '            If CDbl(tvImage.Width) = 0 OrElse CDbl(tvImage.Height) = 0 Then
                '                imgText = String.Format("{0}x{1}", tvImage.WebImage.Image.Size.Width, tvImage.WebImage.Image.Size.Height & Environment.NewLine & tvImage.LongLang)
                '            Else
                '                imgText = String.Format("{0}x{1}", tvImage.Width, tvImage.Height & Environment.NewLine & tvImage.LongLang)
                '            End If
                '            Me.AddImage(imgText, iCount, tvImage)
                '        End If
                '        iCount += 1
                '    Next
                '    For Each tvImage As MediaContainers.Image In SearchResultsContainer.ShowPosters
                '        If tvImage IsNot Nothing AndAlso tvImage.WebImage IsNot Nothing AndAlso tvImage.WebImage.Image IsNot Nothing Then
                '            Dim imgText As String = String.Empty
                '            If CDbl(tvImage.Width) = 0 OrElse CDbl(tvImage.Height) = 0 Then
                '                imgText = String.Format("{0}x{1}", tvImage.WebImage.Image.Size.Width, tvImage.WebImage.Image.Size.Height & Environment.NewLine & tvImage.LongLang)
                '            Else
                '                imgText = String.Format("{0}x{1}", tvImage.Width, tvImage.Height & Environment.NewLine & tvImage.LongLang)
                '            End If
                '            Me.AddImage(imgText, iCount, tvImage)
                '        End If
                '        iCount += 1
                '    Next
            Else
                Dim tMatch As Match = Regex.Match(e.Node.Tag.ToString, "(?<type>f|p|b|l)(?<num>[0-9]+)")
                If tMatch.Success Then

                    'Season Banner
                    If tMatch.Groups("type").Value = "b" Then
                        Me.SelSeason = Convert.ToInt32(tMatch.Groups("num").Value)
                        Me.SelImgType = Enums.ImageType_TV.SeasonBanner
                        Dim tBanner As MediaContainers.Image = tmpShowContainer.Seasons.FirstOrDefault(Function(f) f.TVSeason.Season = Me.SelSeason).ImagesContainer.Banner
                        If tBanner IsNot Nothing AndAlso tBanner IsNot Nothing AndAlso tBanner.WebImage IsNot Nothing Then
                            Me.pbCurrent.Image = tBanner.WebImage.Image
                        Else
                            Me.pbCurrent.Image = Nothing
                        End If
                        iCount = 0
                        For Each tvImage As MediaContainers.Image In SearchResultsContainer.SeasonBanners.Where(Function(s) s.Season = SelSeason)
                            If tvImage IsNot Nothing AndAlso tvImage.WebImage IsNot Nothing AndAlso tvImage.WebImage.Image IsNot Nothing Then
                                Dim imgText As String = String.Empty
                                If CDbl(tvImage.Width) = 0 OrElse CDbl(tvImage.Height) = 0 Then
                                    imgText = String.Format("{0}x{1}", tvImage.WebImage.Image.Size.Width, tvImage.WebImage.Image.Size.Height & Environment.NewLine & tvImage.LongLang)
                                Else
                                    imgText = String.Format("{0}x{1}", tvImage.Width, tvImage.Height & Environment.NewLine & tvImage.LongLang)
                                End If
                                Me.AddImage(imgText, iCount, tvImage)
                            End If
                            iCount += 1
                        Next

                        'Season Fanart
                    ElseIf tMatch.Groups("type").Value = "f" Then
                        Me.SelSeason = Convert.ToInt32(tMatch.Groups("num").Value)
                        Me.SelImgType = Enums.ImageType_TV.SeasonFanart
                        Dim tFanart As MediaContainers.Image = tmpShowContainer.Seasons.FirstOrDefault(Function(f) f.TVSeason.Season = Me.SelSeason).ImagesContainer.Fanart
                        If tFanart IsNot Nothing AndAlso tFanart IsNot Nothing AndAlso tFanart.WebImage IsNot Nothing AndAlso tFanart.WebImage.Image IsNot Nothing Then
                            Me.pbCurrent.Image = tFanart.WebImage.Image
                        Else
                            Me.pbCurrent.Image = Nothing
                        End If
                        iCount = 0
                        For Each tvImage As MediaContainers.Image In SearchResultsContainer.ShowFanarts
                            If tvImage IsNot Nothing AndAlso tvImage.WebImage IsNot Nothing AndAlso tvImage.WebImage.Image IsNot Nothing Then
                                Dim imgText As String = String.Empty
                                If CDbl(tvImage.Width) = 0 OrElse CDbl(tvImage.Height) = 0 Then
                                    imgText = String.Format("{0}x{1}", tvImage.WebImage.Image.Size.Width, tvImage.WebImage.Image.Size.Height & Environment.NewLine & tvImage.LongLang)
                                Else
                                    imgText = String.Format("{0}x{1}", tvImage.Width, tvImage.Height & Environment.NewLine & tvImage.LongLang)
                                End If
                                Me.AddImage(imgText, iCount, tvImage)
                            End If
                            iCount += 1
                        Next

                        'Season Landscape
                    ElseIf tMatch.Groups("type").Value = "l" Then
                        Me.SelSeason = Convert.ToInt32(tMatch.Groups("num").Value)
                        Me.SelImgType = Enums.ImageType_TV.SeasonLandscape
                        Dim tLandscape As MediaContainers.Image = tmpShowContainer.Seasons.FirstOrDefault(Function(f) f.TVSeason.Season = Me.SelSeason).ImagesContainer.Landscape
                        If tLandscape IsNot Nothing AndAlso tLandscape IsNot Nothing AndAlso tLandscape.WebImage IsNot Nothing Then
                            Me.pbCurrent.Image = tLandscape.WebImage.Image
                        Else
                            Me.pbCurrent.Image = Nothing
                        End If
                        iCount = 0
                        For Each tvImage As MediaContainers.Image In SearchResultsContainer.SeasonLandscapes.Where(Function(s) s.Season = SelSeason)
                            If tvImage IsNot Nothing AndAlso tvImage.WebImage IsNot Nothing AndAlso tvImage.WebImage.Image IsNot Nothing Then
                                Dim imgText As String = String.Empty
                                If CDbl(tvImage.Width) = 0 OrElse CDbl(tvImage.Height) = 0 Then
                                    imgText = String.Format("{0}x{1}", tvImage.WebImage.Image.Size.Width, tvImage.WebImage.Image.Size.Height & Environment.NewLine & tvImage.LongLang)
                                Else
                                    imgText = String.Format("{0}x{1}", tvImage.Width, tvImage.Height & Environment.NewLine & tvImage.LongLang)
                                End If
                                Me.AddImage(imgText, iCount, tvImage)
                            End If
                            iCount += 1
                        Next

                        'Season Poster
                    ElseIf tMatch.Groups("type").Value = "p" Then
                        Me.SelSeason = Convert.ToInt32(tMatch.Groups("num").Value)
                        Me.SelImgType = Enums.ImageType_TV.SeasonPoster
                        Dim tPoster As MediaContainers.Image = tmpShowContainer.Seasons.FirstOrDefault(Function(f) f.TVSeason.Season = Me.SelSeason).ImagesContainer.Poster
                        If tPoster IsNot Nothing AndAlso tPoster IsNot Nothing AndAlso tPoster.WebImage IsNot Nothing Then
                            Me.pbCurrent.Image = tPoster.WebImage.Image
                        Else
                            Me.pbCurrent.Image = Nothing
                        End If
                        iCount = 0
                        For Each tvImage As MediaContainers.Image In SearchResultsContainer.SeasonPosters.Where(Function(s) s.Season = SelSeason)
                            If tvImage IsNot Nothing AndAlso tvImage.WebImage IsNot Nothing AndAlso tvImage.WebImage.Image IsNot Nothing Then
                                Dim imgText As String = String.Empty
                                If CDbl(tvImage.Width) = 0 OrElse CDbl(tvImage.Height) = 0 Then
                                    imgText = String.Format("{0}x{1}", tvImage.WebImage.Image.Size.Width, tvImage.WebImage.Image.Size.Height & Environment.NewLine & tvImage.LongLang)
                                Else
                                    imgText = String.Format("{0}x{1}", tvImage.Width, tvImage.Height & Environment.NewLine & tvImage.LongLang)
                                End If
                                Me.AddImage(imgText, iCount, tvImage)
                            End If
                            iCount += 1
                        Next
                    End If
                End If
            End If
        Else
            Me.pbCurrent.Image = Nothing
            Me.pbCurrent.Visible = False
            Me.lblCurrentImage.Visible = False
        End If
    End Sub

#End Region 'Methods

#Region "Nested Types"

#End Region 'Nested Types

End Class