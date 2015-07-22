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
Imports NLog
Imports System.Diagnostics

Public Class dlgEditTVShow

#Region "Fields"

    Shared logger As Logger = NLog.LogManager.GetCurrentClassLogger()

    Friend WithEvents bwEFanarts As New System.ComponentModel.BackgroundWorker

    Private tmpDBTVShow As New Structures.DBTV

    Private ActorThumbsHasChanged As Boolean = False
    Private lvwActorSorter As ListViewColumnSorter
    Private tmpRating As String

    'Extrafanarts
    Private efDeleteList As New List(Of String)
    Private EFanartsIndex As Integer = -1
    Private EFanartsList As New List(Of ExtraImages)
    Private EFanartsExtractor As New List(Of String)
    Private EFanartsWarning As Boolean = True
    Private hasClearedEF As Boolean = False
    Private iEFCounter As Integer = 0
    Private iEFLeft As Integer = 1
    Private iEFTop As Integer = 1
    Private pbEFImage() As PictureBox
    Private pnlEFImage() As Panel

#End Region 'Fields

#Region "Properties"

    Public ReadOnly Property Result As Structures.DBTV
        Get
            Return tmpDBTVShow
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

    Public Overloads Function ShowDialog(ByVal DBTVShow As Structures.DBTV) As DialogResult
        Me.tmpDBTVShow = DBTVShow
        Return MyBase.ShowDialog()
    End Function

    Private Sub btnActorDown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActorDown.Click
        If Me.lvActors.SelectedItems.Count > 0 AndAlso Me.lvActors.SelectedItems(0) IsNot Nothing AndAlso Me.lvActors.SelectedIndices(0) < (Me.lvActors.Items.Count - 1) Then
            Dim iIndex As Integer = Me.lvActors.SelectedIndices(0)
            Me.lvActors.Items.Insert(iIndex + 2, DirectCast(Me.lvActors.SelectedItems(0).Clone, ListViewItem))
            Me.lvActors.Items.RemoveAt(iIndex)
            Me.lvActors.Items(iIndex + 1).Selected = True
            Me.lvActors.Select()
        End If
    End Sub

    Private Sub btnActorUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActorUp.Click
        Try
            If Me.lvActors.SelectedItems.Count > 0 AndAlso Me.lvActors.SelectedItems(0) IsNot Nothing AndAlso Me.lvActors.SelectedIndices(0) > 0 Then
                Dim iIndex As Integer = Me.lvActors.SelectedIndices(0)
                Me.lvActors.Items.Insert(iIndex - 1, DirectCast(Me.lvActors.SelectedItems(0).Clone, ListViewItem))
                Me.lvActors.Items.RemoveAt(iIndex + 1)
                Me.lvActors.Items(iIndex - 1).Selected = True
                Me.lvActors.Select()
            End If
        Catch ex As Exception
            logger.Error(New StackFrame().GetMethod().Name, ex)
        End Try
    End Sub

    Private Sub btnAddActor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddActor.Click
        Try
            Dim eActor As New MediaContainers.Person
            Using dAddEditActor As New dlgAddEditActor
                eActor = dAddEditActor.ShowDialog(True)
            End Using
            If eActor IsNot Nothing Then
                Dim lvItem As ListViewItem = Me.lvActors.Items.Add(eActor.ID.ToString)
                lvItem.SubItems.Add(eActor.Name)
                lvItem.SubItems.Add(eActor.Role)
                lvItem.SubItems.Add(eActor.ThumbURL)
                ActorThumbsHasChanged = True
            End If
        Catch ex As Exception
            logger.Error(New StackFrame().GetMethod().Name, ex)
        End Try
    End Sub

    Private Sub AddEFImage(ByVal sDescription As String, ByVal iIndex As Integer, Extrafanart As ExtraImages)
        Try
            ReDim Preserve Me.pnlEFImage(iIndex)
            ReDim Preserve Me.pbEFImage(iIndex)
            Me.pnlEFImage(iIndex) = New Panel()
            Me.pbEFImage(iIndex) = New PictureBox()
            Me.pbEFImage(iIndex).Name = iIndex.ToString
            Me.pnlEFImage(iIndex).Name = iIndex.ToString
            Me.pnlEFImage(iIndex).Size = New Size(128, 72)
            Me.pbEFImage(iIndex).Size = New Size(128, 72)
            Me.pnlEFImage(iIndex).BackColor = Color.White
            Me.pnlEFImage(iIndex).BorderStyle = BorderStyle.FixedSingle
            Me.pbEFImage(iIndex).SizeMode = PictureBoxSizeMode.Zoom
            Me.pnlEFImage(iIndex).Tag = Extrafanart.Image
            Me.pbEFImage(iIndex).Tag = Extrafanart.Image
            Me.pbEFImage(iIndex).Image = CType(Extrafanart.Image.Image.Clone(), Image)
            Me.pnlEFImage(iIndex).Left = iEFLeft
            Me.pbEFImage(iIndex).Left = 0
            Me.pnlEFImage(iIndex).Top = iEFTop
            Me.pbEFImage(iIndex).Top = 0
            Me.pnlShowEFanartsBG.Controls.Add(Me.pnlEFImage(iIndex))
            Me.pnlEFImage(iIndex).Controls.Add(Me.pbEFImage(iIndex))
            Me.pnlEFImage(iIndex).BringToFront()
            AddHandler pbEFImage(iIndex).Click, AddressOf pbEFImage_Click
            AddHandler pnlEFImage(iIndex).Click, AddressOf pnlEFImage_Click
        Catch ex As Exception
            logger.Error(New StackFrame().GetMethod().Name, ex)
        End Try

        Me.iEFTop += 74

    End Sub

    Private Sub btnEditActor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditActor.Click
        Me.EditActor()
    End Sub

    Private Sub btnManual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnManual.Click
        Try
            If dlgManualEdit.ShowDialog(Me.tmpDBTVShow.NfoPath) = Windows.Forms.DialogResult.OK Then
                Me.tmpDBTVShow.TVShow = NFO.LoadTVShowFromNFO(Me.tmpDBTVShow.NfoPath)
                Me.FillInfo()
            End If
        Catch ex As Exception
            logger.Error(New StackFrame().GetMethod().Name, ex)
        End Try
    End Sub

    Private Sub btnRemoveShowBanner_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveShowBanner.Click
        Me.pbShowBanner.Image = Nothing
        Me.pbShowBanner.Tag = Nothing
        Me.tmpDBTVShow.ImagesContainer.Banner = New MediaContainers.Image
        Me.tmpDBTVShow.BannerPath = String.Empty

        Me.lblShowBannerSize.Text = String.Empty
        Me.lblShowBannerSize.Visible = False
    End Sub

    Private Sub btnRemoveShowCharacterArt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveShowCharacterArt.Click
        Me.pbShowCharacterArt.Image = Nothing
        Me.pbShowCharacterArt.Tag = Nothing
        Me.tmpDBTVShow.ImagesContainer.CharacterArt = New MediaContainers.Image
        Me.tmpDBTVShow.CharacterArtPath = String.Empty

        Me.lblShowCharacterArtSize.Text = String.Empty
        Me.lblShowCharacterArtSize.Visible = False
    End Sub

    Private Sub btnRemoveShowClearArt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveShowClearArt.Click
        Me.pbShowClearArt.Image = Nothing
        Me.pbShowClearArt.Tag = Nothing
        Me.tmpDBTVShow.ImagesContainer.ClearArt = New MediaContainers.Image
        Me.tmpDBTVShow.ClearArtPath = String.Empty

        Me.lblShowClearArtSize.Text = String.Empty
        Me.lblShowClearArtSize.Visible = False
    End Sub

    Private Sub btnRemoveShowClearLogo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveShowClearLogo.Click
        Me.pbShowClearLogo.Image = Nothing
        Me.pbShowClearLogo.Tag = Nothing
        Me.tmpDBTVShow.ImagesContainer.ClearLogo = New MediaContainers.Image
        Me.tmpDBTVShow.ClearLogoPath = String.Empty

        Me.lblShowClearLogoSize.Text = String.Empty
        Me.lblShowClearLogoSize.Visible = False
    End Sub

    Private Sub btnRemoveShowFanart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveShowFanart.Click
        Me.pbShowFanart.Image = Nothing
        Me.pbShowFanart.Tag = Nothing
        Me.tmpDBTVShow.ImagesContainer.Fanart = New MediaContainers.Image
        Me.tmpDBTVShow.FanartPath = String.Empty

        Me.lblShowFanartSize.Text = String.Empty
        Me.lblShowFanartSize.Visible = False
    End Sub

    Private Sub btnRemoveShowLandscape_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveShowLandscape.Click
        Me.pbShowLandscape.Image = Nothing
        Me.pbShowLandscape.Tag = Nothing
        Me.tmpDBTVShow.ImagesContainer.Landscape = New MediaContainers.Image
        Me.tmpDBTVShow.LandscapePath = String.Empty

        Me.lblShowLandscapeSize.Text = String.Empty
        Me.lblShowLandscapeSize.Visible = False
    End Sub

    Private Sub btnRemoveShowPoster_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveShowPoster.Click
        Me.pbShowPoster.Image = Nothing
        Me.pbShowPoster.Tag = Nothing
        Me.tmpDBTVShow.ImagesContainer.Poster = New MediaContainers.Image
        Me.tmpDBTVShow.PosterPath = String.Empty

        Me.lblShowPosterSize.Text = String.Empty
        Me.lblShowPosterSize.Visible = False
    End Sub

    Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click
        Me.DeleteActors()
    End Sub

    Private Sub btnSetShowBannerScrape_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetShowBannerScrape.Click
        Dim tImage As MediaContainers.Image = ModulesManager.Instance.TVSingleImageOnly(Me.tmpDBTVShow.TVShow.Title, Convert.ToInt32(Me.tmpDBTVShow.ShowID), Me.tmpDBTVShow.TVShow.TVDB, Enums.ImageType_TV.ShowBanner, 0, 0, Me.tmpDBTVShow.Language, Me.tmpDBTVShow.Ordering, CType(Me.tmpDBTVShow.ImagesContainer.Banner, MediaContainers.Image))

        If tImage IsNot Nothing AndAlso tImage.WebImage.Image IsNot Nothing Then
            Me.tmpDBTVShow.ImagesContainer.Banner = tImage
            Me.pbShowBanner.Image = tImage.WebImage.Image
            Me.pbShowBanner.Tag = tImage

            Me.lblShowBannerSize.Text = String.Format(Master.eLang.GetString(269, "Size: {0}x{1}"), Me.pbShowBanner.Image.Width, Me.pbShowBanner.Image.Height)
            Me.lblShowBannerSize.Visible = True
        End If
    End Sub

    Private Sub btnSetShowBannerLocal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetShowBannerLocal.Click
        Try
            With ofdImage
                .InitialDirectory = Me.tmpDBTVShow.ShowPath
                .Filter = Master.eLang.GetString(497, "Images") + "|*.jpg;*.png"
                .FilterIndex = 0
            End With

            If ofdImage.ShowDialog() = DialogResult.OK Then
                Dim tImage As New MediaContainers.Image
                tImage.WebImage.FromFile(ofdImage.FileName)
                If tImage.WebImage.Image IsNot Nothing Then
                    Me.tmpDBTVShow.ImagesContainer.Banner = tImage
                    Me.pbShowBanner.Image = tImage.WebImage.Image
                    Me.pbShowBanner.Tag = tImage

                    Me.lblShowBannerSize.Text = String.Format(Master.eLang.GetString(269, "Size: {0}x{1}"), Me.pbShowBanner.Image.Width, Me.pbShowBanner.Image.Height)
                    Me.lblShowBannerSize.Visible = True
                End If
            End If
        Catch ex As Exception
            logger.Error(New StackFrame().GetMethod().Name, ex)
        End Try
    End Sub

    Private Sub btnSetShowBannerDL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetShowBannerDL.Click
        Try
            Using dImgManual As New dlgImgManual
                If dImgManual.ShowDialog() = DialogResult.OK Then
                    Dim tImage As MediaContainers.Image = dImgManual.Results
                    If tImage.WebImage.Image IsNot Nothing Then
                        Me.tmpDBTVShow.ImagesContainer.Banner = tImage
                        Me.pbShowBanner.Image = tImage.WebImage.Image
                        Me.pbShowBanner.Tag = tImage

                        Me.lblShowBannerSize.Text = String.Format(Master.eLang.GetString(269, "Size: {0}x{1}"), Me.pbShowBanner.Image.Width, Me.pbShowBanner.Image.Height)
                        Me.lblShowBannerSize.Visible = True
                    End If
                End If
            End Using
        Catch ex As Exception
            logger.Error(New StackFrame().GetMethod().Name, ex)
        End Try
    End Sub

    Private Sub btnSetShowCharacterArtScrape_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetShowCharacterArtScrape.Click
        Dim tImage As MediaContainers.Image = ModulesManager.Instance.TVSingleImageOnly(Me.tmpDBTVShow.TVShow.Title, Convert.ToInt32(Me.tmpDBTVShow.ShowID), Me.tmpDBTVShow.TVShow.TVDB, Enums.ImageType_TV.ShowCharacterArt, 0, 0, Me.tmpDBTVShow.Language, Me.tmpDBTVShow.Ordering, CType(Me.tmpDBTVShow.ImagesContainer.CharacterArt, MediaContainers.Image))

        If tImage IsNot Nothing AndAlso tImage.WebImage.Image IsNot Nothing Then
            Me.tmpDBTVShow.ImagesContainer.CharacterArt = tImage
            Me.pbShowCharacterArt.Image = tImage.WebImage.Image
            Me.pbShowCharacterArt.Tag = tImage

            Me.lblShowCharacterArtSize.Text = String.Format(Master.eLang.GetString(269, "Size: {0}x{1}"), Me.pbShowCharacterArt.Image.Width, Me.pbShowCharacterArt.Image.Height)
            Me.lblShowCharacterArtSize.Visible = True
        End If
    End Sub

    Private Sub btnSetShowCharacterArtLocal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetShowCharacterArtLocal.Click
        Try
            With ofdImage
                .InitialDirectory = Me.tmpDBTVShow.ShowPath
                .Filter = Master.eLang.GetString(497, "Images") + "|*.jpg;*.png"
                .FilterIndex = 0
            End With

            If ofdImage.ShowDialog() = DialogResult.OK Then
                Dim tImage As New MediaContainers.Image
                tImage.WebImage.FromFile(ofdImage.FileName)
                If tImage.WebImage.Image IsNot Nothing Then
                    Me.tmpDBTVShow.ImagesContainer.CharacterArt = tImage
                    Me.pbShowCharacterArt.Image = tImage.WebImage.Image
                    Me.pbShowCharacterArt.Tag = tImage

                    Me.lblShowCharacterArtSize.Text = String.Format(Master.eLang.GetString(269, "Size: {0}x{1}"), Me.pbShowCharacterArt.Image.Width, Me.pbShowCharacterArt.Image.Height)
                    Me.lblShowCharacterArtSize.Visible = True
                End If
            End If
        Catch ex As Exception
            logger.Error(New StackFrame().GetMethod().Name, ex)
        End Try
    End Sub

    Private Sub btnSetShowCharacterArtDL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetShowCharacterArtDL.Click
        Try
            Using dImgManual As New dlgImgManual
                If dImgManual.ShowDialog() = DialogResult.OK Then
                    Dim tImage As MediaContainers.Image = dImgManual.Results
                    If tImage.WebImage.Image IsNot Nothing Then
                        Me.tmpDBTVShow.ImagesContainer.CharacterArt = tImage
                        Me.pbShowCharacterArt.Image = tImage.WebImage.Image
                        Me.pbShowCharacterArt.Tag = tImage

                        Me.lblShowCharacterArtSize.Text = String.Format(Master.eLang.GetString(269, "Size: {0}x{1}"), Me.pbShowCharacterArt.Image.Width, Me.pbShowCharacterArt.Image.Height)
                        Me.lblShowCharacterArtSize.Visible = True
                    End If
                End If
            End Using
        Catch ex As Exception
            logger.Error(New StackFrame().GetMethod().Name, ex)
        End Try
    End Sub

    Private Sub btnSetShowFanartDL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetShowFanartDL.Click
        Try
            Using dImgManual As New dlgImgManual
                If dImgManual.ShowDialog() = DialogResult.OK Then
                    Dim tImage As MediaContainers.Image = dImgManual.Results
                    If tImage.WebImage.Image IsNot Nothing Then
                        Me.tmpDBTVShow.ImagesContainer.Fanart = tImage
                        Me.pbShowFanart.Image = tImage.WebImage.Image
                        Me.pbShowFanart.Tag = tImage

                        Me.lblShowFanartSize.Text = String.Format(Master.eLang.GetString(269, "Size: {0}x{1}"), Me.pbShowFanart.Image.Width, Me.pbShowFanart.Image.Height)
                        Me.lblShowFanartSize.Visible = True
                    End If
                End If
            End Using
        Catch ex As Exception
            logger.Error(New StackFrame().GetMethod().Name, ex)
        End Try
    End Sub

    Private Sub btnSetShowClearArtScrape_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetShowClearArtScrape.Click
        Dim tImage As MediaContainers.Image = ModulesManager.Instance.TVSingleImageOnly(Me.tmpDBTVShow.TVShow.Title, Convert.ToInt32(Me.tmpDBTVShow.ShowID), Me.tmpDBTVShow.TVShow.TVDB, Enums.ImageType_TV.ShowClearArt, 0, 0, Me.tmpDBTVShow.Language, Me.tmpDBTVShow.Ordering, CType(Me.tmpDBTVShow.ImagesContainer.ClearArt, MediaContainers.Image))

        If tImage IsNot Nothing AndAlso tImage.WebImage.Image IsNot Nothing Then
            Me.tmpDBTVShow.ImagesContainer.ClearArt = tImage
            Me.pbShowClearArt.Image = tImage.WebImage.Image
            Me.pbShowClearArt.Tag = tImage

            Me.lblShowClearArtSize.Text = String.Format(Master.eLang.GetString(269, "Size: {0}x{1}"), Me.pbShowClearArt.Image.Width, Me.pbShowClearArt.Image.Height)
            Me.lblShowClearArtSize.Visible = True
        End If
    End Sub

    Private Sub btnSetShowClearArtLocal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetShowClearArtLocal.Click
        Try
            With ofdImage
                .InitialDirectory = Me.tmpDBTVShow.ShowPath
                .Filter = Master.eLang.GetString(497, "Images") + "|*.jpg;*.png"
                .FilterIndex = 0
            End With

            If ofdImage.ShowDialog() = DialogResult.OK Then
                Dim tImage As New MediaContainers.Image
                tImage.WebImage.FromFile(ofdImage.FileName)
                If tImage.WebImage.Image IsNot Nothing Then
                    Me.tmpDBTVShow.ImagesContainer.ClearArt = tImage
                    Me.pbShowClearArt.Image = tImage.WebImage.Image
                    Me.pbShowClearArt.Tag = tImage

                    Me.lblShowClearArtSize.Text = String.Format(Master.eLang.GetString(269, "Size: {0}x{1}"), Me.pbShowClearArt.Image.Width, Me.pbShowClearArt.Image.Height)
                    Me.lblShowClearArtSize.Visible = True
                End If
            End If
        Catch ex As Exception
            logger.Error(New StackFrame().GetMethod().Name, ex)
        End Try
    End Sub

    Private Sub btnSetShowClearArtDL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetShowClearArtDL.Click
        Try
            Using dImgManual As New dlgImgManual
                If dImgManual.ShowDialog() = DialogResult.OK Then
                    Dim tImage As MediaContainers.Image = dImgManual.Results
                    If tImage.WebImage.Image IsNot Nothing Then
                        Me.tmpDBTVShow.ImagesContainer.ClearArt = tImage
                        Me.pbShowClearArt.Image = tImage.WebImage.Image
                        Me.pbShowClearArt.Tag = tImage

                        Me.lblShowClearArtSize.Text = String.Format(Master.eLang.GetString(269, "Size: {0}x{1}"), Me.pbShowClearArt.Image.Width, Me.pbShowClearArt.Image.Height)
                        Me.lblShowClearArtSize.Visible = True
                    End If
                End If
            End Using
        Catch ex As Exception
            logger.Error(New StackFrame().GetMethod().Name, ex)
        End Try
    End Sub

    Private Sub btnSetShowClearLogoScrape_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetShowClearLogoScrape.Click
        Dim tImage As MediaContainers.Image = ModulesManager.Instance.TVSingleImageOnly(Me.tmpDBTVShow.TVShow.Title, Convert.ToInt32(Me.tmpDBTVShow.ShowID), Me.tmpDBTVShow.TVShow.TVDB, Enums.ImageType_TV.ShowClearLogo, 0, 0, Me.tmpDBTVShow.Language, Me.tmpDBTVShow.Ordering, CType(Me.tmpDBTVShow.ImagesContainer.ClearLogo, MediaContainers.Image))

        If tImage IsNot Nothing AndAlso tImage.WebImage.Image IsNot Nothing Then
            Me.tmpDBTVShow.ImagesContainer.ClearLogo = tImage
            Me.pbShowClearLogo.Image = tImage.WebImage.Image
            Me.pbShowClearLogo.Tag = tImage

            Me.lblShowClearLogoSize.Text = String.Format(Master.eLang.GetString(269, "Size: {0}x{1}"), Me.pbShowClearLogo.Image.Width, Me.pbShowClearLogo.Image.Height)
            Me.lblShowClearLogoSize.Visible = True
        End If
    End Sub

    Private Sub btnSetShowClearLogoLocal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetShowClearLogoLocal.Click
        Try
            With ofdImage
                .InitialDirectory = Me.tmpDBTVShow.ShowPath
                .Filter = Master.eLang.GetString(497, "Images") + "|*.jpg;*.png"
                .FilterIndex = 0
            End With

            If ofdImage.ShowDialog() = DialogResult.OK Then
                Dim tImage As New MediaContainers.Image
                tImage.WebImage.FromFile(ofdImage.FileName)
                If tImage.WebImage.Image IsNot Nothing Then
                    Me.tmpDBTVShow.ImagesContainer.ClearLogo = tImage
                    Me.pbShowClearLogo.Image = tImage.WebImage.Image
                    Me.pbShowClearLogo.Tag = tImage

                    Me.lblShowClearLogoSize.Text = String.Format(Master.eLang.GetString(269, "Size: {0}x{1}"), Me.pbShowClearLogo.Image.Width, Me.pbShowClearLogo.Image.Height)
                    Me.lblShowClearLogoSize.Visible = True
                End If
            End If
        Catch ex As Exception
            logger.Error(New StackFrame().GetMethod().Name, ex)
        End Try
    End Sub

    Private Sub btnSetShowClearLogoDL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetShowClearLogoDL.Click
        Try
            Using dImgManual As New dlgImgManual
                If dImgManual.ShowDialog() = DialogResult.OK Then
                    Dim tImage As MediaContainers.Image = dImgManual.Results
                    If tImage.WebImage.Image IsNot Nothing Then
                        Me.tmpDBTVShow.ImagesContainer.ClearLogo = tImage
                        Me.pbShowClearLogo.Image = tImage.WebImage.Image
                        Me.pbShowClearLogo.Tag = tImage

                        Me.lblShowClearLogoSize.Text = String.Format(Master.eLang.GetString(269, "Size: {0}x{1}"), Me.pbShowClearLogo.Image.Width, Me.pbShowClearLogo.Image.Height)
                        Me.lblShowClearLogoSize.Visible = True
                    End If
                End If
            End Using
        Catch ex As Exception
            logger.Error(New StackFrame().GetMethod().Name, ex)
        End Try
    End Sub

    Private Sub btnSetShowFanartScrape_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetShowFanartScrape.Click
        Dim tImage As MediaContainers.Image = ModulesManager.Instance.TVSingleImageOnly(Me.tmpDBTVShow.TVShow.Title, Convert.ToInt32(Me.tmpDBTVShow.ShowID), Me.tmpDBTVShow.TVShow.TVDB, Enums.ImageType_TV.ShowFanart, 0, 0, Me.tmpDBTVShow.Language, Me.tmpDBTVShow.Ordering, CType(Me.tmpDBTVShow.ImagesContainer.Fanart, MediaContainers.Image))

        If tImage IsNot Nothing AndAlso tImage.WebImage.Image IsNot Nothing Then
            Me.tmpDBTVShow.ImagesContainer.Fanart = tImage
            Me.pbShowFanart.Image = tImage.WebImage.Image
            Me.pbShowFanart.Tag = tImage

            Me.lblShowFanartSize.Text = String.Format(Master.eLang.GetString(269, "Size: {0}x{1}"), Me.pbShowFanart.Image.Width, Me.pbShowFanart.Image.Height)
            Me.lblShowFanartSize.Visible = True
        End If
    End Sub

    Private Sub btnSetShowFanartLocal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetShowFanartLocal.Click
        Try
            With ofdImage
                .InitialDirectory = Me.tmpDBTVShow.ShowPath
                .Filter = Master.eLang.GetString(497, "Images") + "|*.jpg;*.png"
                .FilterIndex = 4
            End With

            If ofdImage.ShowDialog() = DialogResult.OK Then
                Dim tImage As New MediaContainers.Image
                tImage.WebImage.FromFile(ofdImage.FileName)
                If tImage.WebImage.Image IsNot Nothing Then
                    Me.tmpDBTVShow.ImagesContainer.Fanart = tImage
                    Me.pbShowFanart.Image = tImage.WebImage.Image
                    Me.pbShowFanart.Tag = tImage

                    Me.lblShowFanartSize.Text = String.Format(Master.eLang.GetString(269, "Size: {0}x{1}"), Me.pbShowFanart.Image.Width, Me.pbShowFanart.Image.Height)
                    Me.lblShowFanartSize.Visible = True
                End If
            End If
        Catch ex As Exception
            logger.Error(New StackFrame().GetMethod().Name, ex)
        End Try
    End Sub

    Private Sub btnSetShowLandscapeScrape_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetShowLandscapeScrape.Click
        Dim tImage As MediaContainers.Image = ModulesManager.Instance.TVSingleImageOnly(Me.tmpDBTVShow.TVShow.Title, Convert.ToInt32(Me.tmpDBTVShow.ShowID), Me.tmpDBTVShow.TVShow.TVDB, Enums.ImageType_TV.ShowLandscape, 0, 0, Me.tmpDBTVShow.Language, Me.tmpDBTVShow.Ordering, CType(Me.tmpDBTVShow.ImagesContainer.Landscape, MediaContainers.Image))

        If tImage IsNot Nothing AndAlso tImage.WebImage.Image IsNot Nothing Then
            Me.tmpDBTVShow.ImagesContainer.Landscape = tImage
            Me.pbShowLandscape.Image = tImage.WebImage.Image
            Me.pbShowLandscape.Tag = tImage

            Me.lblShowLandscapeSize.Text = String.Format(Master.eLang.GetString(269, "Size: {0}x{1}"), Me.pbShowLandscape.Image.Width, Me.pbShowLandscape.Image.Height)
            Me.lblShowLandscapeSize.Visible = True
        End If
    End Sub

    Private Sub btnSetShowLandscapeLocal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetShowLandscapeLocal.Click
        Try
            With ofdImage
                .InitialDirectory = Me.tmpDBTVShow.ShowPath
                .Filter = Master.eLang.GetString(497, "Images") + "|*.jpg;*.png"
                .FilterIndex = 0
            End With

            If ofdImage.ShowDialog() = DialogResult.OK Then
                Dim tImage As New MediaContainers.Image
                tImage.WebImage.FromFile(ofdImage.FileName)
                If tImage.WebImage.Image IsNot Nothing Then
                    Me.tmpDBTVShow.ImagesContainer.Landscape = tImage
                    Me.pbShowLandscape.Image = tImage.WebImage.Image
                    Me.pbShowLandscape.Tag = tImage

                    Me.lblShowLandscapeSize.Text = String.Format(Master.eLang.GetString(269, "Size: {0}x{1}"), Me.pbShowLandscape.Image.Width, Me.pbShowLandscape.Image.Height)
                    Me.lblShowLandscapeSize.Visible = True
                End If
            End If
        Catch ex As Exception
            logger.Error(New StackFrame().GetMethod().Name, ex)
        End Try
    End Sub

    Private Sub btnSetShowLandscapeDL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetShowLandscapeDL.Click
        Try
            Using dImgManual As New dlgImgManual
                If dImgManual.ShowDialog() = DialogResult.OK Then
                    Dim tImage As MediaContainers.Image = dImgManual.Results
                    If tImage.WebImage.Image IsNot Nothing Then
                        Me.tmpDBTVShow.ImagesContainer.Landscape = tImage
                        Me.pbShowLandscape.Image = tImage.WebImage.Image
                        Me.pbShowLandscape.Tag = tImage

                        Me.lblShowLandscapeSize.Text = String.Format(Master.eLang.GetString(269, "Size: {0}x{1}"), Me.pbShowLandscape.Image.Width, Me.pbShowLandscape.Image.Height)
                        Me.lblShowLandscapeSize.Visible = True
                    End If
                End If
            End Using
        Catch ex As Exception
            logger.Error(New StackFrame().GetMethod().Name, ex)
        End Try
    End Sub

    Private Sub btnSetShowPosterDL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetShowPosterDL.Click
        Try
            Using dImgManual As New dlgImgManual
                If dImgManual.ShowDialog() = DialogResult.OK Then
                    Dim tImage As MediaContainers.Image = dImgManual.Results
                    If tImage.WebImage.Image IsNot Nothing Then
                        Me.tmpDBTVShow.ImagesContainer.Poster = tImage
                        Me.pbShowPoster.Image = tImage.WebImage.Image
                        Me.pbShowPoster.Tag = tImage

                        Me.lblShowPosterSize.Text = String.Format(Master.eLang.GetString(269, "Size: {0}x{1}"), Me.pbShowPoster.Image.Width, Me.pbShowPoster.Image.Height)
                        Me.lblShowPosterSize.Visible = True
                    End If
                End If
            End Using
        Catch ex As Exception
            logger.Error(New StackFrame().GetMethod().Name, ex)
        End Try
    End Sub

    Private Sub btnSetShowPosterScrape_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetShowPosterScrape.Click
        Dim tImage As MediaContainers.Image = ModulesManager.Instance.TVSingleImageOnly(Me.tmpDBTVShow.TVShow.Title, Convert.ToInt32(Me.tmpDBTVShow.ShowID), Me.tmpDBTVShow.TVShow.TVDB, Enums.ImageType_TV.ShowPoster, 0, 0, Me.tmpDBTVShow.Language, Me.tmpDBTVShow.Ordering, CType(Me.tmpDBTVShow.ImagesContainer.Poster, MediaContainers.Image))

        If tImage IsNot Nothing AndAlso tImage.WebImage.Image IsNot Nothing Then
            Me.tmpDBTVShow.ImagesContainer.Poster = tImage
            Me.pbShowPoster.Image = tImage.WebImage.Image
            Me.pbShowPoster.Tag = tImage

            Me.lblShowPosterSize.Text = String.Format(Master.eLang.GetString(269, "Size: {0}x{1}"), Me.pbShowPoster.Image.Width, Me.pbShowPoster.Image.Height)
            Me.lblShowPosterSize.Visible = True
        End If
    End Sub

    Private Sub btnSetShowPosterLocal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetShowPosterLocal.Click
        Try
            With ofdImage
                .InitialDirectory = Me.tmpDBTVShow.ShowPath
                .Filter = Master.eLang.GetString(497, "Images") + "|*.jpg;*.png"
                .FilterIndex = 0
            End With

            If ofdImage.ShowDialog() = DialogResult.OK Then
                Dim tImage As New MediaContainers.Image
                tImage.WebImage.FromFile(ofdImage.FileName)
                If tImage.WebImage.Image IsNot Nothing Then
                    Me.tmpDBTVShow.ImagesContainer.Poster = tImage
                    Me.pbShowPoster.Image = tImage.WebImage.Image
                    Me.pbShowPoster.Tag = tImage

                    Me.lblShowPosterSize.Text = String.Format(Master.eLang.GetString(269, "Size: {0}x{1}"), Me.pbShowPoster.Image.Width, Me.pbShowPoster.Image.Height)
                    Me.lblShowPosterSize.Visible = True
                End If
            End If
        Catch ex As Exception
            logger.Error(New StackFrame().GetMethod().Name, ex)
        End Try
    End Sub

    Private Sub btnShowEFanartsRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowEFanartsRefresh.Click
        Me.RefreshEFanarts()
    End Sub

    Private Sub btnShowEFanartsRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowEFanartsRemove.Click
        Me.DeleteEFanarts()
        Me.RefreshEFanarts()
        Me.lblShowEFanartsSize.Text = ""
        Me.lblShowEFanartsSize.Visible = False
    End Sub

    Private Sub btnShowEFanartsSetAsFanart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowEFanartsSetAsFanart.Click
        If Not String.IsNullOrEmpty(Me.EFanartsList.Item(Me.EFanartsIndex).Path) AndAlso Me.EFanartsList.Item(Me.EFanartsIndex).Path.Substring(0, 1) = ":" Then
            Me.tmpDBTVShow.ImagesContainer.Fanart.WebImage.FromWeb(Me.EFanartsList.Item(Me.EFanartsIndex).Path.Substring(1, Me.EFanartsList.Item(Me.EFanartsIndex).Path.Length - 1))
        Else
            Me.tmpDBTVShow.ImagesContainer.Fanart.WebImage.FromFile(Me.EFanartsList.Item(Me.EFanartsIndex).Path)
        End If
        If Me.tmpDBTVShow.ImagesContainer.Fanart.WebImage.Image IsNot Nothing Then
            Me.pbShowFanart.Image = Me.tmpDBTVShow.ImagesContainer.Fanart.WebImage.Image
            Me.pbShowFanart.Tag = Me.tmpDBTVShow.ImagesContainer.Fanart

            Me.lblShowFanartSize.Text = String.Format(Master.eLang.GetString(269, "Size: {0}x{1}"), Me.pbShowFanart.Image.Width, Me.pbShowFanart.Image.Height)
            Me.lblShowFanartSize.Visible = True
        End If
    End Sub

    Private Sub BuildStars(ByVal sinRating As Single)
        '//
        ' Convert # rating to star images
        '\\

        Try
            'f'in MS and them leaving control arrays out of VB.NET
            With Me
                .pbStar1.Image = Nothing
                .pbStar2.Image = Nothing
                .pbStar3.Image = Nothing
                .pbStar4.Image = Nothing
                .pbStar5.Image = Nothing
                .pbStar6.Image = Nothing
                .pbStar7.Image = Nothing
                .pbStar8.Image = Nothing
                .pbStar9.Image = Nothing
                .pbStar10.Image = Nothing

                If sinRating >= 0.5 Then ' if rating is less than .5 out of ten, consider it a 0
                    Select Case (sinRating)
                        Case Is <= 0.5
                            .pbStar1.Image = My.Resources.starhalf
                            .pbStar2.Image = My.Resources.starempty
                            .pbStar3.Image = My.Resources.starempty
                            .pbStar4.Image = My.Resources.starempty
                            .pbStar5.Image = My.Resources.starempty
                            .pbStar6.Image = My.Resources.starempty
                            .pbStar7.Image = My.Resources.starempty
                            .pbStar8.Image = My.Resources.starempty
                            .pbStar9.Image = My.Resources.starempty
                            .pbStar10.Image = My.Resources.starempty
                        Case Is <= 1
                            .pbStar1.Image = My.Resources.star
                            .pbStar2.Image = My.Resources.starempty
                            .pbStar3.Image = My.Resources.starempty
                            .pbStar4.Image = My.Resources.starempty
                            .pbStar5.Image = My.Resources.starempty
                            .pbStar6.Image = My.Resources.starempty
                            .pbStar7.Image = My.Resources.starempty
                            .pbStar8.Image = My.Resources.starempty
                            .pbStar9.Image = My.Resources.starempty
                            .pbStar10.Image = My.Resources.starempty
                        Case Is <= 1.5
                            .pbStar1.Image = My.Resources.star
                            .pbStar2.Image = My.Resources.starhalf
                            .pbStar3.Image = My.Resources.starempty
                            .pbStar4.Image = My.Resources.starempty
                            .pbStar5.Image = My.Resources.starempty
                            .pbStar6.Image = My.Resources.starempty
                            .pbStar7.Image = My.Resources.starempty
                            .pbStar8.Image = My.Resources.starempty
                            .pbStar9.Image = My.Resources.starempty
                            .pbStar10.Image = My.Resources.starempty
                        Case Is <= 2
                            .pbStar1.Image = My.Resources.star
                            .pbStar2.Image = My.Resources.star
                            .pbStar3.Image = My.Resources.starempty
                            .pbStar4.Image = My.Resources.starempty
                            .pbStar5.Image = My.Resources.starempty
                            .pbStar6.Image = My.Resources.starempty
                            .pbStar7.Image = My.Resources.starempty
                            .pbStar8.Image = My.Resources.starempty
                            .pbStar9.Image = My.Resources.starempty
                            .pbStar10.Image = My.Resources.starempty
                        Case Is <= 2.5
                            .pbStar1.Image = My.Resources.star
                            .pbStar2.Image = My.Resources.star
                            .pbStar3.Image = My.Resources.starhalf
                            .pbStar4.Image = My.Resources.starempty
                            .pbStar5.Image = My.Resources.starempty
                            .pbStar6.Image = My.Resources.starempty
                            .pbStar7.Image = My.Resources.starempty
                            .pbStar8.Image = My.Resources.starempty
                            .pbStar9.Image = My.Resources.starempty
                            .pbStar10.Image = My.Resources.starempty
                        Case Is <= 3
                            .pbStar1.Image = My.Resources.star
                            .pbStar2.Image = My.Resources.star
                            .pbStar3.Image = My.Resources.star
                            .pbStar4.Image = My.Resources.starempty
                            .pbStar5.Image = My.Resources.starempty
                            .pbStar6.Image = My.Resources.starempty
                            .pbStar7.Image = My.Resources.starempty
                            .pbStar8.Image = My.Resources.starempty
                            .pbStar9.Image = My.Resources.starempty
                            .pbStar10.Image = My.Resources.starempty
                        Case Is <= 3.5
                            .pbStar1.Image = My.Resources.star
                            .pbStar2.Image = My.Resources.star
                            .pbStar3.Image = My.Resources.star
                            .pbStar4.Image = My.Resources.starhalf
                            .pbStar5.Image = My.Resources.starempty
                            .pbStar6.Image = My.Resources.starempty
                            .pbStar7.Image = My.Resources.starempty
                            .pbStar8.Image = My.Resources.starempty
                            .pbStar9.Image = My.Resources.starempty
                            .pbStar10.Image = My.Resources.starempty
                        Case Is <= 4
                            .pbStar1.Image = My.Resources.star
                            .pbStar2.Image = My.Resources.star
                            .pbStar3.Image = My.Resources.star
                            .pbStar4.Image = My.Resources.star
                            .pbStar5.Image = My.Resources.starempty
                            .pbStar6.Image = My.Resources.starempty
                            .pbStar7.Image = My.Resources.starempty
                            .pbStar8.Image = My.Resources.starempty
                            .pbStar9.Image = My.Resources.starempty
                            .pbStar10.Image = My.Resources.starempty
                        Case Is <= 4.5
                            .pbStar1.Image = My.Resources.star
                            .pbStar2.Image = My.Resources.star
                            .pbStar3.Image = My.Resources.star
                            .pbStar4.Image = My.Resources.star
                            .pbStar5.Image = My.Resources.starhalf
                            .pbStar6.Image = My.Resources.starempty
                            .pbStar7.Image = My.Resources.starempty
                            .pbStar8.Image = My.Resources.starempty
                            .pbStar9.Image = My.Resources.starempty
                            .pbStar10.Image = My.Resources.starempty
                        Case Is <= 5
                            .pbStar1.Image = My.Resources.star
                            .pbStar2.Image = My.Resources.star
                            .pbStar3.Image = My.Resources.star
                            .pbStar4.Image = My.Resources.star
                            .pbStar5.Image = My.Resources.star
                            .pbStar6.Image = My.Resources.starempty
                            .pbStar7.Image = My.Resources.starempty
                            .pbStar8.Image = My.Resources.starempty
                            .pbStar9.Image = My.Resources.starempty
                            .pbStar10.Image = My.Resources.starempty
                        Case Is <= 5.5
                            .pbStar1.Image = My.Resources.star
                            .pbStar2.Image = My.Resources.star
                            .pbStar3.Image = My.Resources.star
                            .pbStar4.Image = My.Resources.star
                            .pbStar5.Image = My.Resources.star
                            .pbStar6.Image = My.Resources.starhalf
                            .pbStar7.Image = My.Resources.starempty
                            .pbStar8.Image = My.Resources.starempty
                            .pbStar9.Image = My.Resources.starempty
                            .pbStar10.Image = My.Resources.starempty
                        Case Is <= 6
                            .pbStar1.Image = My.Resources.star
                            .pbStar2.Image = My.Resources.star
                            .pbStar3.Image = My.Resources.star
                            .pbStar4.Image = My.Resources.star
                            .pbStar5.Image = My.Resources.star
                            .pbStar6.Image = My.Resources.star
                            .pbStar7.Image = My.Resources.starempty
                            .pbStar8.Image = My.Resources.starempty
                            .pbStar9.Image = My.Resources.starempty
                            .pbStar10.Image = My.Resources.starempty
                        Case Is <= 6.5
                            .pbStar1.Image = My.Resources.star
                            .pbStar2.Image = My.Resources.star
                            .pbStar3.Image = My.Resources.star
                            .pbStar4.Image = My.Resources.star
                            .pbStar5.Image = My.Resources.star
                            .pbStar6.Image = My.Resources.star
                            .pbStar7.Image = My.Resources.starhalf
                            .pbStar8.Image = My.Resources.starempty
                            .pbStar9.Image = My.Resources.starempty
                            .pbStar10.Image = My.Resources.starempty
                        Case Is <= 7
                            .pbStar1.Image = My.Resources.star
                            .pbStar2.Image = My.Resources.star
                            .pbStar3.Image = My.Resources.star
                            .pbStar4.Image = My.Resources.star
                            .pbStar5.Image = My.Resources.star
                            .pbStar6.Image = My.Resources.star
                            .pbStar7.Image = My.Resources.star
                            .pbStar8.Image = My.Resources.starempty
                            .pbStar9.Image = My.Resources.starempty
                            .pbStar10.Image = My.Resources.starempty
                        Case Is <= 7.5
                            .pbStar1.Image = My.Resources.star
                            .pbStar2.Image = My.Resources.star
                            .pbStar3.Image = My.Resources.star
                            .pbStar4.Image = My.Resources.star
                            .pbStar5.Image = My.Resources.star
                            .pbStar6.Image = My.Resources.star
                            .pbStar7.Image = My.Resources.star
                            .pbStar8.Image = My.Resources.starhalf
                            .pbStar9.Image = My.Resources.starempty
                            .pbStar10.Image = My.Resources.starempty
                        Case Is <= 8
                            .pbStar1.Image = My.Resources.star
                            .pbStar2.Image = My.Resources.star
                            .pbStar3.Image = My.Resources.star
                            .pbStar4.Image = My.Resources.star
                            .pbStar5.Image = My.Resources.star
                            .pbStar6.Image = My.Resources.star
                            .pbStar7.Image = My.Resources.star
                            .pbStar8.Image = My.Resources.star
                            .pbStar9.Image = My.Resources.starempty
                            .pbStar10.Image = My.Resources.starempty
                        Case Is <= 8.5
                            .pbStar1.Image = My.Resources.star
                            .pbStar2.Image = My.Resources.star
                            .pbStar3.Image = My.Resources.star
                            .pbStar4.Image = My.Resources.star
                            .pbStar5.Image = My.Resources.star
                            .pbStar6.Image = My.Resources.star
                            .pbStar7.Image = My.Resources.star
                            .pbStar8.Image = My.Resources.star
                            .pbStar9.Image = My.Resources.starhalf
                            .pbStar10.Image = My.Resources.starempty
                        Case Is <= 9
                            .pbStar1.Image = My.Resources.star
                            .pbStar2.Image = My.Resources.star
                            .pbStar3.Image = My.Resources.star
                            .pbStar4.Image = My.Resources.star
                            .pbStar5.Image = My.Resources.star
                            .pbStar6.Image = My.Resources.star
                            .pbStar7.Image = My.Resources.star
                            .pbStar8.Image = My.Resources.star
                            .pbStar9.Image = My.Resources.star
                            .pbStar10.Image = My.Resources.starempty
                        Case Is <= 9.5
                            .pbStar1.Image = My.Resources.star
                            .pbStar2.Image = My.Resources.star
                            .pbStar3.Image = My.Resources.star
                            .pbStar4.Image = My.Resources.star
                            .pbStar5.Image = My.Resources.star
                            .pbStar6.Image = My.Resources.star
                            .pbStar7.Image = My.Resources.star
                            .pbStar8.Image = My.Resources.star
                            .pbStar9.Image = My.Resources.star
                            .pbStar10.Image = My.Resources.starhalf
                        Case Else
                            .pbStar1.Image = My.Resources.star
                            .pbStar2.Image = My.Resources.star
                            .pbStar3.Image = My.Resources.star
                            .pbStar4.Image = My.Resources.star
                            .pbStar5.Image = My.Resources.star
                            .pbStar6.Image = My.Resources.star
                            .pbStar7.Image = My.Resources.star
                            .pbStar8.Image = My.Resources.star
                            .pbStar9.Image = My.Resources.star
                            .pbStar10.Image = My.Resources.star
                    End Select
                End If
            End With
        Catch ex As Exception
            logger.Error(New StackFrame().GetMethod().Name, ex)
        End Try
    End Sub

    Private Sub bwEFanarts_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bwEFanarts.DoWork
        If Not Me.tmpDBTVShow.RemoveEFanarts OrElse hasClearedEF Then LoadEFanarts()
    End Sub

    Private Sub bwEFanarts_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bwEFanarts.RunWorkerCompleted
        Try
            If EFanartsList.Count > 0 Then
                For Each tEFanart As ExtraImages In EFanartsList
                    AddEFImage(tEFanart.Name, tEFanart.Index, tEFanart)
                Next
            End If
        Catch ex As Exception
            logger.Error(New StackFrame().GetMethod().Name, ex)
        End Try
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Try
            If Me.pnlEFImage IsNot Nothing Then
                For Each Pan In Me.pnlEFImage
                    CType(Pan.Tag, Images).Dispose()
                Next
            End If
            If Me.pbEFImage IsNot Nothing Then
                For Each Pan In Me.pbEFImage
                    CType(Pan.Tag, Images).Dispose()
                    Pan.Image.Dispose()
                Next
            End If
        Catch ex As Exception
            logger.Error(New StackFrame().GetMethod().Name, ex)
        End Try

        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub CleanUp()
        Try
            If Me.pnlEFImage IsNot Nothing Then
                For Each Pan In Me.pnlEFImage
                    CType(Pan.Tag, Images).Dispose()
                Next
            End If
            If Me.pbEFImage IsNot Nothing Then
                For Each Pan In Me.pbEFImage
                    CType(Pan.Tag, Images).Dispose()
                    Pan.Image.Dispose()
                Next
            End If
        Catch ex As Exception
            logger.Error(New StackFrame().GetMethod().Name, ex)
        End Try
    End Sub

    Private Sub DeleteActors()
        Try
            If Me.lvActors.Items.Count > 0 Then
                While Me.lvActors.SelectedItems.Count > 0
                    Me.lvActors.Items.Remove(Me.lvActors.SelectedItems(0))
                End While
                ActorThumbsHasChanged = True
            End If
        Catch ex As Exception
            logger.Error(New StackFrame().GetMethod().Name, ex)
        End Try
    End Sub

    Private Sub DeleteEFanarts()
        Try
            Dim iIndex As Integer = EFanartsIndex

            If iIndex >= 0 Then
                Dim tPath As String = Me.EFanartsList.Item(iIndex).Path
                If Me.EFanartsList.Item(iIndex).Path.Substring(0, 1) = ":" Then
                    Me.tmpDBTVShow.EFanarts.RemoveAll(Function(Str) Str = tPath)
                    EFanartsList.Remove(EFanartsList.Item(iIndex))
                Else
                    efDeleteList.Add(Me.EFanartsList.Item(iIndex).Path)
                    EFanartsList.Remove(EFanartsList.Item(iIndex))
                End If
                pbShowEFanarts.Image = Nothing
                btnShowEFanartsSetAsFanart.Enabled = False
            End If
        Catch ex As Exception
            logger.Error(New StackFrame().GetMethod().Name, ex)
        End Try
    End Sub

    Private Sub dlgEditShow_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Me.bwEFanarts.IsBusy Then Me.bwEFanarts.CancelAsync()
        While Me.bwEFanarts.IsBusy
            Application.DoEvents()
            Threading.Thread.Sleep(50)
        End While
    End Sub

    Private Sub dlgEditShow_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Me.tmpDBTVShow.IsOnline OrElse FileUtils.Common.CheckOnlineStatus_TVShow(Me.tmpDBTVShow, True) Then
            If Not Master.eSettings.TVShowBannerAnyEnabled Then Me.tcEditShow.TabPages.Remove(tpShowBanner)
            If Not Master.eSettings.TVShowCharacterArtAnyEnabled Then Me.tcEditShow.TabPages.Remove(tpShowCharacterArt)
            If Not Master.eSettings.TVShowClearArtAnyEnabled Then Me.tcEditShow.TabPages.Remove(tpShowClearArt)
            If Not Master.eSettings.TVShowClearLogoAnyEnabled Then Me.tcEditShow.TabPages.Remove(tpShowClearLogo)
            If Not Master.eSettings.TVShowEFanartsAnyEnabled Then Me.tcEditShow.TabPages.Remove(tpShowEFanarts)
            If Not Master.eSettings.TVShowFanartAnyEnabled Then Me.tcEditShow.TabPages.Remove(tpShowFanart)
            If Not Master.eSettings.TVShowLandscapeAnyEnabled Then Me.tcEditShow.TabPages.Remove(tpShowLandscape)
            If Not Master.eSettings.TVShowPosterAnyEnabled Then Me.tcEditShow.TabPages.Remove(tpShowPoster)

            Me.pbShowBanner.AllowDrop = True
            Me.pbShowCharacterArt.AllowDrop = True
            Me.pbShowClearArt.AllowDrop = True
            Me.pbShowClearLogo.AllowDrop = True
            Me.pbShowFanart.AllowDrop = True
            Me.pbShowLandscape.AllowDrop = True
            Me.pbShowPoster.AllowDrop = True

            Me.SetUp()

            Me.lvwActorSorter = New ListViewColumnSorter()
            Me.lvActors.ListViewItemSorter = Me.lvwActorSorter

            Dim iBackground As New Bitmap(Me.pnlTop.Width, Me.pnlTop.Height)
            Using g As Graphics = Graphics.FromImage(iBackground)
                g.FillRectangle(New Drawing2D.LinearGradientBrush(Me.pnlTop.ClientRectangle, Color.SteelBlue, Color.LightSteelBlue, Drawing2D.LinearGradientMode.Horizontal), pnlTop.ClientRectangle)
                Me.pnlTop.BackgroundImage = iBackground
            End Using

            Me.LoadGenres()
            Me.LoadRatings()

            Me.FillInfo()
        Else
            Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.Close()
        End If
    End Sub

    Private Sub DoSelectEF(ByVal iIndex As Integer, tPoster As MediaContainers.Image)
        Try
            Me.pbShowEFanarts.Image = tPoster.WebImage.Image
            Me.pbShowEFanarts.Tag = tPoster
            Me.btnShowEFanartsSetAsFanart.Enabled = True
            Me.EFanartsIndex = iIndex
            Me.lblShowEFanartsSize.Text = String.Format(Master.eLang.GetString(269, "Size: {0}x{1}"), Me.pbShowEFanarts.Image.Width, Me.pbShowEFanarts.Image.Height)
            Me.lblShowEFanartsSize.Visible = True
        Catch ex As Exception
            logger.Error(New StackFrame().GetMethod().Name, ex)
        End Try
    End Sub

    Private Sub EditActor()
        Try
            If Me.lvActors.SelectedItems.Count > 0 Then
                Dim lvwItem As ListViewItem = Me.lvActors.SelectedItems(0)
                Dim eActor As New MediaContainers.Person With {.ID = CInt(lvwItem.Text), .Name = lvwItem.SubItems(1).Text, .Role = lvwItem.SubItems(2).Text, .ThumbURL = lvwItem.SubItems(3).Text}
                Using dAddEditActor As New dlgAddEditActor
                    eActor = dAddEditActor.ShowDialog(False, eActor)
                End Using
                If eActor IsNot Nothing Then
                    lvwItem.Text = eActor.ID.ToString
                    lvwItem.SubItems(1).Text = eActor.Name
                    lvwItem.SubItems(2).Text = eActor.Role
                    lvwItem.SubItems(3).Text = eActor.ThumbURL
                    lvwItem.Selected = True
                    lvwItem.EnsureVisible()
                    ActorThumbsHasChanged = True
                End If
                eActor = Nothing
            End If
        Catch ex As Exception
            logger.Error(New StackFrame().GetMethod().Name, ex)
        End Try
    End Sub

    Private Sub FillInfo()
        With Me
            .cbOrdering.SelectedIndex = Me.tmpDBTVShow.Ordering
            .cbEpisodeSorting.SelectedIndex = Me.tmpDBTVShow.EpisodeSorting

            If Not String.IsNullOrEmpty(Me.tmpDBTVShow.TVShow.Title) Then .txtTitle.Text = Me.tmpDBTVShow.TVShow.Title
            If Not String.IsNullOrEmpty(Me.tmpDBTVShow.TVShow.Plot) Then .txtPlot.Text = Me.tmpDBTVShow.TVShow.Plot
            If Not String.IsNullOrEmpty(Me.tmpDBTVShow.TVShow.Premiered) Then .txtPremiered.Text = Me.tmpDBTVShow.TVShow.Premiered
            If Not String.IsNullOrEmpty(Me.tmpDBTVShow.TVShow.Runtime) Then .txtRuntime.Text = Me.tmpDBTVShow.TVShow.Runtime
            If Not String.IsNullOrEmpty(Me.tmpDBTVShow.TVShow.SortTitle) Then .txtSortTitle.Text = Me.tmpDBTVShow.TVShow.SortTitle
            If Not String.IsNullOrEmpty(Me.tmpDBTVShow.TVShow.Status) Then .txtStatus.Text = Me.tmpDBTVShow.TVShow.Status
            If Not String.IsNullOrEmpty(Me.tmpDBTVShow.TVShow.Studio) Then .txtStudio.Text = Me.tmpDBTVShow.TVShow.Studio
            If Not String.IsNullOrEmpty(Me.tmpDBTVShow.TVShow.Votes) Then .txtVotes.Text = Me.tmpDBTVShow.TVShow.Votes

            For i As Integer = 0 To .clbGenre.Items.Count - 1
                .clbGenre.SetItemChecked(i, False)
            Next
            If Not String.IsNullOrEmpty(Me.tmpDBTVShow.TVShow.Genre) Then
                Dim genreArray() As String
                genreArray = Me.tmpDBTVShow.TVShow.Genre.Split("/"c)
                For g As Integer = 0 To genreArray.Count - 1
                    If .clbGenre.FindString(genreArray(g).Trim) > 0 Then
                        .clbGenre.SetItemChecked(.clbGenre.FindString(genreArray(g).Trim), True)
                    End If
                Next

                If .clbGenre.CheckedItems.Count = 0 Then
                    .clbGenre.SetItemChecked(0, True)
                End If
            Else
                .clbGenre.SetItemChecked(0, True)
            End If

            Dim lvItem As ListViewItem
            .lvActors.Items.Clear()
            For Each imdbAct As MediaContainers.Person In Me.tmpDBTVShow.TVShow.Actors
                lvItem = .lvActors.Items.Add(imdbAct.ID.ToString)
                lvItem.SubItems.Add(imdbAct.Name)
                lvItem.SubItems.Add(imdbAct.Role)
                lvItem.SubItems.Add(imdbAct.ThumbURL)
            Next

            Dim tRating As Single = NumUtils.ConvertToSingle(Me.tmpDBTVShow.TVShow.Rating)
            .tmpRating = tRating.ToString
            .pbStar1.Tag = tRating
            .pbStar2.Tag = tRating
            .pbStar3.Tag = tRating
            .pbStar4.Tag = tRating
            .pbStar5.Tag = tRating
            .pbStar6.Tag = tRating
            .pbStar7.Tag = tRating
            .pbStar8.Tag = tRating
            .pbStar9.Tag = tRating
            .pbStar10.Tag = tRating
            If tRating > 0 Then .BuildStars(tRating)

            Me.SelectMPAA()

            If Master.eSettings.TVShowBannerAnyEnabled Then
                If Me.tmpDBTVShow.ImagesContainer.Banner.WebImage.Image IsNot Nothing Then
                    .pbShowBanner.Image = Me.tmpDBTVShow.ImagesContainer.Banner.WebImage.Image
                    .pbShowBanner.Tag = Me.tmpDBTVShow.ImagesContainer.Banner

                    .lblShowBannerSize.Text = String.Format(Master.eLang.GetString(269, "Size: {0}x{1}"), .pbShowBanner.Image.Width, .pbShowBanner.Image.Height)
                    .lblShowBannerSize.Visible = True
                End If
            End If

            If Master.eSettings.TVShowCharacterArtAnyEnabled Then
                If Me.tmpDBTVShow.ImagesContainer.CharacterArt.WebImage.Image IsNot Nothing Then
                    .pbShowCharacterArt.Image = Me.tmpDBTVShow.ImagesContainer.CharacterArt.WebImage.Image
                    .pbShowCharacterArt.Tag = Me.tmpDBTVShow.ImagesContainer.CharacterArt

                    .lblShowCharacterArtSize.Text = String.Format(Master.eLang.GetString(269, "Size: {0}x{1}"), .pbShowCharacterArt.Image.Width, .pbShowCharacterArt.Image.Height)
                    .lblShowCharacterArtSize.Visible = True
                End If
            End If

            If Master.eSettings.TVShowClearArtAnyEnabled Then
                If Me.tmpDBTVShow.ImagesContainer.ClearArt.WebImage.Image IsNot Nothing Then
                    .pbShowClearArt.Image = Me.tmpDBTVShow.ImagesContainer.ClearArt.WebImage.Image
                    .pbShowClearArt.Tag = Me.tmpDBTVShow.ImagesContainer.ClearArt

                    .lblShowClearArtSize.Text = String.Format(Master.eLang.GetString(269, "Size: {0}x{1}"), .pbShowClearArt.Image.Width, .pbShowClearArt.Image.Height)
                    .lblShowClearArtSize.Visible = True
                End If
            End If

            If Master.eSettings.TVShowClearLogoAnyEnabled Then
                If Me.tmpDBTVShow.ImagesContainer.ClearLogo.WebImage.Image IsNot Nothing Then
                    .pbShowClearLogo.Image = Me.tmpDBTVShow.ImagesContainer.ClearLogo.WebImage.Image
                    .pbShowClearLogo.Tag = Me.tmpDBTVShow.ImagesContainer.ClearLogo

                    .lblShowClearLogoSize.Text = String.Format(Master.eLang.GetString(269, "Size: {0}x{1}"), .pbShowClearLogo.Image.Width, .pbShowClearLogo.Image.Height)
                    .lblShowClearLogoSize.Visible = True
                End If
            End If

            If Master.eSettings.TVShowFanartAnyEnabled Then
                If Me.tmpDBTVShow.ImagesContainer.Fanart.WebImage.Image IsNot Nothing Then
                    .pbShowFanart.Image = Me.tmpDBTVShow.ImagesContainer.Fanart.WebImage.Image
                    .pbShowFanart.Tag = Me.tmpDBTVShow.ImagesContainer.Fanart

                    .lblShowFanartSize.Text = String.Format(Master.eLang.GetString(269, "Size: {0}x{1}"), .pbShowFanart.Image.Width, .pbShowFanart.Image.Height)
                    .lblShowFanartSize.Visible = True
                End If
            End If

            If Master.eSettings.TVShowLandscapeAnyEnabled Then
                If Me.tmpDBTVShow.ImagesContainer.Landscape.WebImage.Image IsNot Nothing Then
                    .pbShowLandscape.Image = Me.tmpDBTVShow.ImagesContainer.Landscape.WebImage.Image
                    .pbShowLandscape.Tag = Me.tmpDBTVShow.ImagesContainer.Landscape

                    .lblShowLandscapeSize.Text = String.Format(Master.eLang.GetString(269, "Size: {0}x{1}"), .pbShowLandscape.Image.Width, .pbShowLandscape.Image.Height)
                    .lblShowLandscapeSize.Visible = True
                End If
            End If

            If Master.eSettings.TVShowPosterAnyEnabled Then
                If Me.tmpDBTVShow.ImagesContainer.Poster.WebImage.Image IsNot Nothing Then
                    .pbShowPoster.Image = Me.tmpDBTVShow.ImagesContainer.Poster.WebImage.Image
                    .pbShowPoster.Tag = Me.tmpDBTVShow.ImagesContainer.Poster

                    .lblShowPosterSize.Text = String.Format(Master.eLang.GetString(269, "Size: {0}x{1}"), .pbShowPoster.Image.Width, .pbShowPoster.Image.Height)
                    .lblShowPosterSize.Visible = True
                End If
            End If

            .bwEFanarts.WorkerSupportsCancellation = True
            .bwEFanarts.RunWorkerAsync()

            If Master.eSettings.TVShowBannerAnyEnabled Then
                If Not ModulesManager.Instance.QueryScraperCapabilities_Image_TV(Enums.ScraperCapabilities_TV.ShowBanner) Then
                    .btnSetShowBannerScrape.Enabled = False
                End If
            Else
                tcEditShow.TabPages.Remove(tpShowBanner)
            End If

            If Master.eSettings.TVShowCharacterArtAnyEnabled Then
                If Not ModulesManager.Instance.QueryScraperCapabilities_Image_TV(Enums.ScraperCapabilities_TV.ShowCharacterArt) Then
                    .btnSetShowCharacterArtScrape.Enabled = False
                End If
            Else
                tcEditShow.TabPages.Remove(tpShowCharacterArt)
            End If

            If Master.eSettings.TVShowClearArtAnyEnabled Then
                If Not ModulesManager.Instance.QueryScraperCapabilities_Image_TV(Enums.ScraperCapabilities_TV.ShowClearArt) Then
                    .btnSetShowClearArtScrape.Enabled = False
                End If
            Else
                tcEditShow.TabPages.Remove(tpShowClearArt)
            End If

            If Master.eSettings.TVShowClearLogoAnyEnabled Then
                If Not ModulesManager.Instance.QueryScraperCapabilities_Image_TV(Enums.ScraperCapabilities_TV.ShowClearLogo) Then
                    .btnSetShowClearLogoScrape.Enabled = False
                End If
            Else
                tcEditShow.TabPages.Remove(tpShowClearLogo)
            End If

            If Master.eSettings.TVShowFanartAnyEnabled Then
                If Not ModulesManager.Instance.QueryScraperCapabilities_Image_TV(Enums.ScraperCapabilities_TV.ShowFanart) Then
                    .btnSetShowFanartScrape.Enabled = False
                End If
            Else
                tcEditShow.TabPages.Remove(tpShowFanart)
            End If

            If Master.eSettings.TVShowLandscapeAnyEnabled Then
                If Not ModulesManager.Instance.QueryScraperCapabilities_Image_TV(Enums.ScraperCapabilities_TV.ShowLandscape) Then
                    .btnSetShowLandscapeScrape.Enabled = False
                End If
            Else
                tcEditShow.TabPages.Remove(tpShowLandscape)
            End If

            If Master.eSettings.TVShowPosterAnyEnabled Then
                If Not ModulesManager.Instance.QueryScraperCapabilities_Image_TV(Enums.ScraperCapabilities_TV.ShowPoster) Then
                    .btnSetShowPosterScrape.Enabled = False
                End If
            Else
                tcEditShow.TabPages.Remove(tpShowPoster)
            End If

        End With
    End Sub

    Private Sub lbGenre_ItemCheck(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemCheckEventArgs) Handles clbGenre.ItemCheck
        If e.Index = 0 Then
            For i As Integer = 1 To clbGenre.Items.Count - 1
                Me.clbGenre.SetItemChecked(i, False)
            Next
        Else
            Me.clbGenre.SetItemChecked(0, False)
        End If
    End Sub

    Private Sub lbMPAA_DoubleClick(sender As Object, e As EventArgs) Handles lbMPAA.DoubleClick
        If Me.lbMPAA.SelectedItems.Count = 1 Then
            If Me.lbMPAA.SelectedIndex = 0 Then
                Me.txtMPAA.Text = String.Empty
            Else
                Me.txtMPAA.Text = Me.lbMPAA.SelectedItem.ToString
            End If
        End If
    End Sub

    Private Sub LoadEFanarts()
        Dim EF_tPath As String = String.Empty
        Dim EF_lFI As New List(Of String)
        Dim EF_i As Integer = 0
        Dim EF_max As Integer = 30 'limited the number of images to avoid a memory error

        For Each a In FileUtils.GetFilenameList.TVShow(Me.tmpDBTVShow.ShowPath, Enums.ModType.MainEFanarts)
            If Directory.Exists(a) Then
                EF_lFI.AddRange(Directory.GetFiles(a))
            End If
        Next

        Try
            If EF_lFI.Count > 0 Then

                ' load local Extrafanarts
                If EF_lFI.Count > 0 Then
                    For Each fanart As String In EF_lFI
                        Dim EFImage As New Images
                        If Me.bwEFanarts.CancellationPending Then Return
                        If Not Me.efDeleteList.Contains(fanart) Then
                            EFImage.FromFile(fanart)
                            EFanartsList.Add(New ExtraImages With {.Image = EFImage, .Name = Path.GetFileName(fanart), .Index = EF_i, .Path = fanart})
                            EF_i += 1
                            If EF_i >= EF_max Then Exit For
                        End If
                    Next
                End If
            End If

            ' load scraped Extrafanarts
            If Not Me.tmpDBTVShow.EFanarts Is Nothing Then
                If Not EF_i >= EF_max Then
                    For Each fanart As String In Me.tmpDBTVShow.EFanarts
                        Dim EFImage As New Images
                        If Not String.IsNullOrEmpty(fanart) Then
                            EFImage.FromWeb(fanart.Substring(1, fanart.Length - 1))
                        End If
                        If EFImage.Image IsNot Nothing Then
                            EFanartsList.Add(New ExtraImages With {.Image = EFImage, .Name = Path.GetFileName(fanart), .Index = EF_i, .Path = fanart})
                            EF_i += 1
                            If EF_i >= EF_max Then Exit For
                        End If
                    Next
                End If
            End If

            If EF_i >= EF_max AndAlso EFanartsWarning Then
                MessageBox.Show(String.Format(Master.eLang.GetString(1119, "To prevent a memory overflow will not display more than {0} Extrafanarts."), EF_max), Master.eLang.GetString(356, "Warning"), MessageBoxButtons.OK, MessageBoxIcon.Warning)
                EFanartsWarning = False 'show warning only one time
            End If

        Catch ex As Exception
            logger.Error(New StackFrame().GetMethod().Name, ex)
        End Try

        EF_lFI = Nothing
    End Sub

    Private Sub LoadGenres()
        Me.clbGenre.Items.Add(Master.eLang.None)

        Me.clbGenre.Items.AddRange(APIXML.GetGenreList)
    End Sub

    Private Sub LoadRatings()
        Me.lbMPAA.Items.Add(Master.eLang.None)
        If Not String.IsNullOrEmpty(Master.eSettings.TVScraperShowMPAANotRated) Then Me.lbMPAA.Items.Add(Master.eSettings.TVScraperShowMPAANotRated)
        Me.lbMPAA.Items.AddRange(APIXML.GetRatingList_TV)
    End Sub

    Private Sub lvActors_ColumnClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles lvActors.ColumnClick
        ' Determine if the clicked column is already the column that is
        ' being sorted.
        Try
            If (e.Column = Me.lvwActorSorter.SortColumn) Then
                ' Reverse the current sort direction for this column.
                If (Me.lvwActorSorter.Order = SortOrder.Ascending) Then
                    Me.lvwActorSorter.Order = SortOrder.Descending
                Else
                    Me.lvwActorSorter.Order = SortOrder.Ascending
                End If
            Else
                ' Set the column number that is to be sorted; default to ascending.
                Me.lvwActorSorter.SortColumn = e.Column
                Me.lvwActorSorter.Order = SortOrder.Ascending
            End If

            ' Perform the sort with these new sort options.
            Me.lvActors.Sort()
        Catch ex As Exception
            logger.Error(New StackFrame().GetMethod().Name, ex)
        End Try
    End Sub

    Private Sub lvActors_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvActors.DoubleClick
        EditActor()
    End Sub

    Private Sub lvEFanart_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Delete Then Me.DeleteEFanarts()
    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.SetInfo()
        Me.CleanUp()

        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub pbEFImage_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.DoSelectEF(Convert.ToInt32(DirectCast(sender, PictureBox).Name), DirectCast(DirectCast(sender, PictureBox).Tag, MediaContainers.Image))
    End Sub

    Private Sub pbShowBanner_DragDrop(sender As Object, e As DragEventArgs) Handles pbShowBanner.DragDrop
        Dim tImage As MediaContainers.Image = FileUtils.DragAndDrop.GetDoppedImage(e)
        If tImage.WebImage.Image IsNot Nothing Then
            Me.tmpDBTVShow.ImagesContainer.Banner = tImage
            Me.pbShowBanner.Image = tImage.WebImage.Image
            Me.pbShowBanner.Tag = tImage
            Me.lblShowBannerSize.Text = String.Format(Master.eLang.GetString(269, "Size: {0}x{1}"), Me.pbShowBanner.Image.Width, Me.pbShowBanner.Image.Height)
            Me.lblShowBannerSize.Visible = True
        End If
    End Sub

    Private Sub pbShowBanner_DragEnter(sender As Object, e As DragEventArgs) Handles pbShowBanner.DragEnter
        If FileUtils.DragAndDrop.CheckDroppedImage(e) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub pbShowCharacterArt_DragDrop(sender As Object, e As DragEventArgs) Handles pbShowCharacterArt.DragDrop
        Dim tImage As MediaContainers.Image = FileUtils.DragAndDrop.GetDoppedImage(e)
        If tImage.WebImage.Image IsNot Nothing Then
            Me.tmpDBTVShow.ImagesContainer.CharacterArt = tImage
            Me.pbShowCharacterArt.Image = tImage.WebImage.Image
            Me.pbShowCharacterArt.Tag = tImage
            Me.lblShowCharacterArtSize.Text = String.Format(Master.eLang.GetString(269, "Size: {0}x{1}"), Me.pbShowCharacterArt.Image.Width, Me.pbShowCharacterArt.Image.Height)
            Me.lblShowCharacterArtSize.Visible = True
        End If
    End Sub

    Private Sub pbShowCharacterArt_DragEnter(sender As Object, e As DragEventArgs) Handles pbShowCharacterArt.DragEnter
        If FileUtils.DragAndDrop.CheckDroppedImage(e) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub pbShowClearArt_DragDrop(sender As Object, e As DragEventArgs) Handles pbShowClearArt.DragDrop
        Dim tImage As MediaContainers.Image = FileUtils.DragAndDrop.GetDoppedImage(e)
        If tImage.WebImage.Image IsNot Nothing Then
            Me.tmpDBTVShow.ImagesContainer.ClearArt = tImage
            Me.pbShowClearArt.Image = tImage.WebImage.Image
            Me.pbShowClearArt.Tag = tImage
            Me.lblShowClearArtSize.Text = String.Format(Master.eLang.GetString(269, "Size: {0}x{1}"), Me.pbShowClearArt.Image.Width, Me.pbShowClearArt.Image.Height)
            Me.lblShowClearArtSize.Visible = True
        End If
    End Sub

    Private Sub pbShowClearArt_DragEnter(sender As Object, e As DragEventArgs) Handles pbShowClearArt.DragEnter
        If FileUtils.DragAndDrop.CheckDroppedImage(e) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub pbShowClearLogo_DragDrop(sender As Object, e As DragEventArgs) Handles pbShowClearLogo.DragDrop
        Dim tImage As MediaContainers.Image = FileUtils.DragAndDrop.GetDoppedImage(e)
        If tImage.WebImage.Image IsNot Nothing Then
            Me.tmpDBTVShow.ImagesContainer.ClearLogo = tImage
            Me.pbShowClearLogo.Image = tImage.WebImage.Image
            Me.pbShowClearLogo.Tag = tImage
            Me.lblShowClearLogoSize.Text = String.Format(Master.eLang.GetString(269, "Size: {0}x{1}"), Me.pbShowClearLogo.Image.Width, Me.pbShowClearLogo.Image.Height)
            Me.lblShowClearLogoSize.Visible = True
        End If
    End Sub

    Private Sub pbShowClearLogo_DragEnter(sender As Object, e As DragEventArgs) Handles pbShowClearLogo.DragEnter
        If FileUtils.DragAndDrop.CheckDroppedImage(e) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub pbShowFanart_DragDrop(sender As Object, e As DragEventArgs) Handles pbShowFanart.DragDrop
        Dim tImage As MediaContainers.Image = FileUtils.DragAndDrop.GetDoppedImage(e)
        If tImage.WebImage.Image IsNot Nothing Then
            Me.tmpDBTVShow.ImagesContainer.Fanart = tImage
            Me.pbShowFanart.Image = tImage.WebImage.Image
            Me.pbShowFanart.Tag = tImage
            Me.lblShowFanartSize.Text = String.Format(Master.eLang.GetString(269, "Size: {0}x{1}"), Me.pbShowFanart.Image.Width, Me.pbShowFanart.Image.Height)
            Me.lblShowFanartSize.Visible = True
        End If
    End Sub

    Private Sub pbShowFanart_DragEnter(sender As Object, e As DragEventArgs) Handles pbShowFanart.DragEnter
        If FileUtils.DragAndDrop.CheckDroppedImage(e) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub pbShowLandscape_DragDrop(sender As Object, e As DragEventArgs) Handles pbShowLandscape.DragDrop
        Dim tImage As MediaContainers.Image = FileUtils.DragAndDrop.GetDoppedImage(e)
        If tImage.WebImage.Image IsNot Nothing Then
            Me.tmpDBTVShow.ImagesContainer.Landscape = tImage
            Me.pbShowLandscape.Image = tImage.WebImage.Image
            Me.pbShowLandscape.Tag = tImage
            Me.lblShowLandscapeSize.Text = String.Format(Master.eLang.GetString(269, "Size: {0}x{1}"), Me.pbShowLandscape.Image.Width, Me.pbShowLandscape.Image.Height)
            Me.lblShowLandscapeSize.Visible = True
        End If
    End Sub

    Private Sub pbShowLandscape_DragEnter(sender As Object, e As DragEventArgs) Handles pbShowLandscape.DragEnter
        If FileUtils.DragAndDrop.CheckDroppedImage(e) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub pbShowPoster_DragDrop(sender As Object, e As DragEventArgs) Handles pbShowPoster.DragDrop
        Dim tImage As MediaContainers.Image = FileUtils.DragAndDrop.GetDoppedImage(e)
        If tImage.WebImage.Image IsNot Nothing Then
            Me.tmpDBTVShow.ImagesContainer.Poster = tImage
            Me.pbShowPoster.Image = tImage.WebImage.Image
            Me.pbShowPoster.Tag = tImage
            Me.lblShowPosterSize.Text = String.Format(Master.eLang.GetString(269, "Size: {0}x{1}"), Me.pbShowPoster.Image.Width, Me.pbShowPoster.Image.Height)
            Me.lblShowPosterSize.Visible = True
        End If
    End Sub

    Private Sub pbShowPoster_DragEnter(sender As Object, e As DragEventArgs) Handles pbShowPoster.DragEnter
        If FileUtils.DragAndDrop.CheckDroppedImage(e) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub pbStar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbStar1.Click
        Me.tmpRating = Me.pbStar1.Tag.ToString
    End Sub

    Private Sub pbStar1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pbStar1.MouseLeave
        Try
            Dim tmpDBL As Single = 0
            Single.TryParse(Me.tmpRating, tmpDBL)
            Me.BuildStars(tmpDBL)
        Catch ex As Exception
            logger.Error(New StackFrame().GetMethod().Name, ex)
        End Try
    End Sub

    Private Sub pbStar1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbStar1.MouseMove
        Try
            If e.X < 12 Then
                Me.pbStar1.Tag = 0.5
                Me.BuildStars(0.5)
            Else
                Me.pbStar1.Tag = 1
                Me.BuildStars(1)
            End If
        Catch ex As Exception
            logger.Error(New StackFrame().GetMethod().Name, ex)
        End Try
    End Sub

    Private Sub pbStar2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbStar2.Click
        Me.tmpRating = Me.pbStar2.Tag.ToString
    End Sub

    Private Sub pbStar2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pbStar2.MouseLeave
        Try
            Dim tmpDBL As Single = 0
            Single.TryParse(Me.tmpRating, tmpDBL)
            Me.BuildStars(tmpDBL)
        Catch ex As Exception
            logger.Error(New StackFrame().GetMethod().Name, ex)
        End Try
    End Sub

    Private Sub pbStar2_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbStar2.MouseMove
        Try
            If e.X < 12 Then
                Me.pbStar2.Tag = 1.5
                Me.BuildStars(1.5)
            Else
                Me.pbStar2.Tag = 2
                Me.BuildStars(2)
            End If
        Catch ex As Exception
            logger.Error(New StackFrame().GetMethod().Name, ex)
        End Try
    End Sub

    Private Sub pbStar3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbStar3.Click
        Me.tmpRating = Me.pbStar3.Tag.ToString
    End Sub

    Private Sub pbStar3_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pbStar3.MouseLeave
        Try
            Dim tmpDBL As Single = 0
            Single.TryParse(Me.tmpRating, tmpDBL)
            Me.BuildStars(tmpDBL)
        Catch ex As Exception
            logger.Error(New StackFrame().GetMethod().Name, ex)
        End Try
    End Sub

    Private Sub pbStar3_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbStar3.MouseMove
        Try
            If e.X < 12 Then
                Me.pbStar3.Tag = 2.5
                Me.BuildStars(2.5)
            Else
                Me.pbStar3.Tag = 3
                Me.BuildStars(3)
            End If
        Catch ex As Exception
            logger.Error(New StackFrame().GetMethod().Name, ex)
        End Try
    End Sub

    Private Sub pbStar4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbStar4.Click
        Me.tmpRating = Me.pbStar4.Tag.ToString
    End Sub

    Private Sub pbStar4_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pbStar4.MouseLeave
        Try
            Dim tmpDBL As Single = 0
            Single.TryParse(Me.tmpRating, tmpDBL)
            Me.BuildStars(tmpDBL)
        Catch ex As Exception
            logger.Error(New StackFrame().GetMethod().Name, ex)
        End Try
    End Sub

    Private Sub pbStar4_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbStar4.MouseMove
        Try
            If e.X < 12 Then
                Me.pbStar4.Tag = 3.5
                Me.BuildStars(3.5)
            Else
                Me.pbStar4.Tag = 4
                Me.BuildStars(4)
            End If
        Catch ex As Exception
            logger.Error(New StackFrame().GetMethod().Name, ex)
        End Try
    End Sub

    Private Sub pbStar5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbStar5.Click
        Me.tmpRating = Me.pbStar5.Tag.ToString
    End Sub

    Private Sub pbStar5_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pbStar5.MouseLeave
        Try
            Dim tmpDBL As Single = 0
            Single.TryParse(Me.tmpRating, tmpDBL)
            Me.BuildStars(tmpDBL)
        Catch ex As Exception
            logger.Error(New StackFrame().GetMethod().Name, ex)
        End Try
    End Sub

    Private Sub pbStar5_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbStar5.MouseMove
        Try
            If e.X < 12 Then
                Me.pbStar5.Tag = 4.5
                Me.BuildStars(4.5)
            Else
                Me.pbStar5.Tag = 5
                Me.BuildStars(5)
            End If
        Catch ex As Exception
            logger.Error(New StackFrame().GetMethod().Name, ex)
        End Try
    End Sub

    Private Sub pbStar6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbStar6.Click
        Me.tmpRating = Me.pbStar6.Tag.ToString
    End Sub

    Private Sub pbStar6_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pbStar6.MouseLeave
        Try
            Dim tmpDBL As Single = 0
            Single.TryParse(Me.tmpRating, tmpDBL)
            Me.BuildStars(tmpDBL)
        Catch ex As Exception
            logger.Error(New StackFrame().GetMethod().Name, ex)
        End Try
    End Sub

    Private Sub pbStar6_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbStar6.MouseMove
        Try
            If e.X < 12 Then
                Me.pbStar6.Tag = 5.5
                Me.BuildStars(5.5)
            Else
                Me.pbStar6.Tag = 6
                Me.BuildStars(6)
            End If
        Catch ex As Exception
            logger.Error(New StackFrame().GetMethod().Name, ex)
        End Try
    End Sub

    Private Sub pbStar7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbStar7.Click
        Me.tmpRating = Me.pbStar7.Tag.ToString
    End Sub

    Private Sub pbStar7_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pbStar7.MouseLeave
        Try
            Dim tmpDBL As Single = 0
            Single.TryParse(Me.tmpRating, tmpDBL)
            Me.BuildStars(tmpDBL)
        Catch ex As Exception
            logger.Error(New StackFrame().GetMethod().Name, ex)
        End Try
    End Sub

    Private Sub pbStar7_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbStar7.MouseMove
        Try
            If e.X < 12 Then
                Me.pbStar7.Tag = 6.5
                Me.BuildStars(6.5)
            Else
                Me.pbStar7.Tag = 7
                Me.BuildStars(7)
            End If
        Catch ex As Exception
            logger.Error(New StackFrame().GetMethod().Name, ex)
        End Try
    End Sub

    Private Sub pbStar8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbStar8.Click
        Me.tmpRating = Me.pbStar8.Tag.ToString
    End Sub

    Private Sub pbStar8_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pbStar8.MouseLeave
        Try
            Dim tmpDBL As Single = 0
            Single.TryParse(Me.tmpRating, tmpDBL)
            Me.BuildStars(tmpDBL)
        Catch ex As Exception
            logger.Error(New StackFrame().GetMethod().Name, ex)
        End Try
    End Sub

    Private Sub pbStar8_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbStar8.MouseMove
        Try
            If e.X < 12 Then
                Me.pbStar8.Tag = 7.5
                Me.BuildStars(7.5)
            Else
                Me.pbStar8.Tag = 8
                Me.BuildStars(8)
            End If
        Catch ex As Exception
            logger.Error(New StackFrame().GetMethod().Name, ex)
        End Try
    End Sub

    Private Sub pbStar9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbStar9.Click
        Me.tmpRating = Me.pbStar9.Tag.ToString
    End Sub

    Private Sub pbStar9_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pbStar9.MouseLeave
        Try
            Dim tmpDBL As Single = 0
            Single.TryParse(Me.tmpRating, tmpDBL)
            Me.BuildStars(tmpDBL)
        Catch ex As Exception
            logger.Error(New StackFrame().GetMethod().Name, ex)
        End Try
    End Sub

    Private Sub pbStar9_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbStar9.MouseMove
        Try
            If e.X < 12 Then
                Me.pbStar9.Tag = 8.5
                Me.BuildStars(8.5)
            Else
                Me.pbStar9.Tag = 9
                Me.BuildStars(9)
            End If
        Catch ex As Exception
            logger.Error(New StackFrame().GetMethod().Name, ex)
        End Try
    End Sub

    Private Sub pbStar10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbStar10.Click
        Me.tmpRating = Me.pbStar10.Tag.ToString
    End Sub

    Private Sub pbStar10_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pbStar10.MouseLeave
        Try
            Dim tmpDBL As Single = 0
            Single.TryParse(Me.tmpRating, tmpDBL)
            Me.BuildStars(tmpDBL)
        Catch ex As Exception
            logger.Error(New StackFrame().GetMethod().Name, ex)
        End Try
    End Sub

    Private Sub pbStar10_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbStar10.MouseMove
        Try
            If e.X < 12 Then
                Me.pbStar10.Tag = 9.5
                Me.BuildStars(9.5)
            Else
                Me.pbStar10.Tag = 10
                Me.BuildStars(10)
            End If
        Catch ex As Exception
            logger.Error(New StackFrame().GetMethod().Name, ex)
        End Try
    End Sub

    Private Sub pnlEFImage_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.DoSelectEF(Convert.ToInt32(DirectCast(sender, Panel).Name), DirectCast(DirectCast(sender, Panel).Tag, MediaContainers.Image))
    End Sub

    Private Sub RefreshEFanarts()
        Try
            If Me.bwEFanarts.IsBusy Then Me.bwEFanarts.CancelAsync()
            While Me.bwEFanarts.IsBusy
                Application.DoEvents()
                Threading.Thread.Sleep(50)
            End While

            Me.iEFTop = 1 ' set first image top position back to 1
            Me.EFanartsList.Clear()
            While Me.pnlShowEFanartsBG.Controls.Count > 0
                Me.pnlShowEFanartsBG.Controls(0).Dispose()
            End While

            Me.bwEFanarts.WorkerSupportsCancellation = True
            Me.bwEFanarts.RunWorkerAsync()
        Catch ex As Exception
            logger.Error(New StackFrame().GetMethod().Name, ex)
        End Try
    End Sub

    Private Sub SaveEFanartsList()
        Try
            For Each a In FileUtils.GetFilenameList.TVShow(Me.tmpDBTVShow.ShowPath, Enums.ModType.MainEFanarts)
                If Not String.IsNullOrEmpty(a) Then
                    If Me.tmpDBTVShow.RemoveEFanarts AndAlso Not hasClearedEF Then
                        FileUtils.Delete.DeleteDirectory(a)
                        hasClearedEF = True
                    Else
                        'first delete the ones from the delete list
                        For Each del As String In efDeleteList
                            File.Delete(Path.Combine(a, del))
                        Next

                        'now name the rest something arbitrary so we don't get any conflicts
                        For Each lItem As ExtraImages In EFanartsList
                            If Not lItem.Path.Substring(0, 1) = ":" Then
                                File.Move(lItem.Path, Path.Combine(Directory.GetParent(lItem.Path).FullName, String.Concat("temp", lItem.Name)))
                            End If
                        Next

                        'now rename them properly
                        For Each lItem As ExtraImages In EFanartsList
                            Dim efPath As String = lItem.Image.SaveAsTVShowExtrafanart(Me.tmpDBTVShow, lItem.Name)
                            If lItem.Index = 0 Then
                                Me.tmpDBTVShow.EFanartsPath = efPath
                            End If
                        Next

                        'now remove the temp images
                        Dim tList As New List(Of String)

                        If Directory.Exists(a) Then
                            tList.AddRange(Directory.GetFiles(a, "temp*.jpg"))
                            For Each tFile As String In tList
                                File.Delete(Path.Combine(a, tFile))
                            Next
                        End If
                    End If
                End If
            Next
        Catch ex As Exception
            logger.Error(New StackFrame().GetMethod().Name, ex)
        End Try
    End Sub

    Private Sub SelectMPAA()
        Try
            If Not String.IsNullOrEmpty(Me.tmpDBTVShow.TVShow.MPAA) Then
                Dim i As Integer = 0
                For ctr As Integer = 0 To Me.lbMPAA.Items.Count - 1
                    If Me.tmpDBTVShow.TVShow.MPAA.ToLower.StartsWith(Me.lbMPAA.Items.Item(ctr).ToString.ToLower) Then
                        i = ctr
                        Exit For
                    End If
                Next
                Me.lbMPAA.SelectedIndex = i
                Me.lbMPAA.TopIndex = i
                Me.txtMPAA.Text = Me.tmpDBTVShow.TVShow.MPAA
            End If

            If Me.lbMPAA.SelectedItems.Count = 0 Then
                Me.lbMPAA.SelectedIndex = 0
                Me.lbMPAA.TopIndex = 0
            End If
        Catch ex As Exception
            logger.Error(New StackFrame().GetMethod().Name, ex)
        End Try
    End Sub

    Private Sub txtPlot_KeyDown(ByVal sender As Object, e As KeyEventArgs) Handles txtPlot.KeyDown
        If e.KeyData = (Keys.Control Or Keys.A) Then
            Me.txtPlot.SelectAll()
        End If
    End Sub

    Private Sub SetInfo()
        Try
            With Me
                Me.tmpDBTVShow.Ordering = DirectCast(.cbOrdering.SelectedIndex, Enums.Ordering)
                Me.tmpDBTVShow.EpisodeSorting = DirectCast(.cbEpisodeSorting.SelectedIndex, Enums.EpisodeSorting)

                Me.tmpDBTVShow.TVShow.Title = .txtTitle.Text.Trim
                Me.tmpDBTVShow.TVShow.Plot = .txtPlot.Text.Trim
                Me.tmpDBTVShow.TVShow.Premiered = .txtPremiered.Text.Trim
                Me.tmpDBTVShow.TVShow.Runtime = .txtRuntime.Text.Trim
                Me.tmpDBTVShow.TVShow.SortTitle = .txtSortTitle.Text.Trim
                Me.tmpDBTVShow.TVShow.Status = .txtStatus.Text.Trim
                Me.tmpDBTVShow.TVShow.Studio = .txtStudio.Text.Trim
                Me.tmpDBTVShow.TVShow.Votes = .txtVotes.Text.Trim

                If Not String.IsNullOrEmpty(.txtTitle.Text) Then
                    If Master.eSettings.TVDisplayStatus AndAlso Not String.IsNullOrEmpty(.txtStatus.Text.Trim) Then
                        Me.tmpDBTVShow.ListTitle = String.Format("{0} ({1})", StringUtils.SortTokens_TV(.txtTitle.Text.Trim), .txtStatus.Text.Trim)
                    Else
                        Me.tmpDBTVShow.ListTitle = StringUtils.SortTokens_TV(.txtTitle.Text.Trim)
                    End If
                End If

                Me.tmpDBTVShow.TVShow.MPAA = .txtMPAA.Text.Trim

                Me.tmpDBTVShow.TVShow.Rating = .tmpRating

                If .clbGenre.CheckedItems.Count > 0 Then

                    If .clbGenre.CheckedIndices.Contains(0) Then
                        Me.tmpDBTVShow.TVShow.Genre = String.Empty
                    Else
                        Dim strGenre As String = String.Empty
                        Dim isFirst As Boolean = True
                        Dim iChecked = From iCheck In .clbGenre.CheckedItems
                        strGenre = String.Join(" / ", iChecked.ToArray)
                        Me.tmpDBTVShow.TVShow.Genre = strGenre.Trim
                    End If
                End If

                Me.tmpDBTVShow.TVShow.Actors.Clear()

                If .lvActors.Items.Count > 0 Then
                    Dim iOrder As Integer = 0
                    For Each lviActor As ListViewItem In .lvActors.Items
                        Dim addActor As New MediaContainers.Person
                        addActor.ID = CInt(lviActor.Text.Trim)
                        addActor.Name = lviActor.SubItems(1).Text.Trim
                        addActor.Role = lviActor.SubItems(2).Text.Trim
                        addActor.ThumbURL = lviActor.SubItems(3).Text.Trim
                        addActor.Order = iOrder
                        iOrder += 1
                        Me.tmpDBTVShow.TVShow.Actors.Add(addActor)
                    Next
                End If

                If Me.tmpDBTVShow.RemoveActorThumbs OrElse ActorThumbsHasChanged Then
                    For Each a In FileUtils.GetFilenameList.TVShow(Me.tmpDBTVShow.ShowPath, Enums.ModType.MainActorThumbs)
                        Dim tmpPath As String = Directory.GetParent(a.Replace("<placeholder>", "dummy")).FullName
                        If Directory.Exists(tmpPath) Then
                            FileUtils.Delete.DeleteDirectory(tmpPath)
                        End If
                    Next
                End If

                'Actor Thumbs
                If ActorThumbsHasChanged Then
                    For Each act As MediaContainers.Person In Me.tmpDBTVShow.TVShow.Actors
                        Dim img As New Images
                        img.FromWeb(act.ThumbURL)
                        If img.Image IsNot Nothing Then
                            act.ThumbPath = img.SaveAsTVShowActorThumb(act, Me.tmpDBTVShow)
                        Else
                            act.ThumbPath = String.Empty
                        End If
                    Next
                End If

            End With
        Catch ex As Exception
            logger.Error(New StackFrame().GetMethod().Name, ex)
        End Try
    End Sub

    Private Sub SetUp()
        Dim mTitle As String = Me.tmpDBTVShow.TVShow.Title
        Dim sTitle As String = String.Concat(Master.eLang.GetString(663, "Edit Show"), If(String.IsNullOrEmpty(mTitle), String.Empty, String.Concat(" - ", mTitle)))
        Me.Cancel_Button.Text = Master.eLang.GetString(167, "Cancel")
        Me.OK_Button.Text = Master.eLang.GetString(179, "OK")
        Me.Text = sTitle
        Me.btnManual.Text = Master.eLang.GetString(230, "Manual Edit")
        Me.btnRemoveShowBanner.Text = Master.eLang.GetString(1024, "Remove Banner")
        Me.btnRemoveShowCharacterArt.Text = Master.eLang.GetString(1145, "Remove CharacterArt")
        Me.btnRemoveShowClearArt.Text = Master.eLang.GetString(1087, "Remove ClearArt")
        Me.btnRemoveShowClearLogo.Text = Master.eLang.GetString(1091, "Remove ClearLogo")
        Me.btnRemoveShowFanart.Text = Master.eLang.GetString(250, "Remove Fanart")
        Me.btnRemoveShowLandscape.Text = Master.eLang.GetString(1034, "Remove Landscape")
        Me.btnRemoveShowPoster.Text = Master.eLang.GetString(247, "Remove Poster")
        Me.btnSetShowCharacterArtDL.Text = Master.eLang.GetString(1144, "Change CharacterArt (Download)")
        Me.btnSetShowCharacterArtLocal.Text = Master.eLang.GetString(1142, "Change CharacterArt (Local)")
        Me.btnSetShowCharacterArtScrape.Text = Master.eLang.GetString(1143, "Change CharacterArt (Scrape)")
        Me.btnSetShowClearArtDL.Text = Master.eLang.GetString(1086, "Change ClearArt (Download)")
        Me.btnSetShowClearArtLocal.Text = Master.eLang.GetString(1084, "Change ClearArt (Local)")
        Me.btnSetShowClearArtScrape.Text = Master.eLang.GetString(1085, "Change ClearArt (Scrape)")
        Me.btnSetShowClearLogoDL.Text = Master.eLang.GetString(1090, "Change ClearLogo (Download)")
        Me.btnSetShowClearLogoLocal.Text = Master.eLang.GetString(1088, "Change ClearLogo (Local)")
        Me.btnSetShowClearLogoScrape.Text = Master.eLang.GetString(1089, "Change ClearLogo (Scrape)")
        Me.btnSetShowBannerDL.Text = Master.eLang.GetString(1023, "Change Banner (Download)")
        Me.btnSetShowBannerLocal.Text = Master.eLang.GetString(1021, "Change Banner (Local)")
        Me.btnSetShowBannerScrape.Text = Master.eLang.GetString(1022, "Change Banner (Scrape)")
        Me.btnSetShowFanartDL.Text = Master.eLang.GetString(1033, "Change Landscape (Download)")
        Me.btnSetShowFanartLocal.Text = Master.eLang.GetString(252, "Change Fanart (Local)")
        Me.btnSetShowFanartScrape.Text = Master.eLang.GetString(251, "Change Fanart (Scrape)")
        Me.btnSetShowLandscapeDL.Text = Master.eLang.GetString(1033, "Change Landscape (Download)")
        Me.btnSetShowLandscapeLocal.Text = Master.eLang.GetString(1031, "Change Landscape (Local)")
        Me.btnSetShowLandscapeScrape.Text = Master.eLang.GetString(1032, "Change Landscape (Scrape)")
        Me.btnSetShowPosterDL.Text = Master.eLang.GetString(265, "Change Poster (Download)")
        Me.btnSetShowPosterLocal.Text = Master.eLang.GetString(249, "Change Poster (Local)")
        Me.btnSetShowPosterScrape.Text = Master.eLang.GetString(248, "Change Poster (Scrape)")
        Me.btnShowEFanartsSetAsFanart.Text = Master.eLang.GetString(255, "Set As Fanart")
        Me.colName.Text = Master.eLang.GetString(232, "Name")
        Me.colRole.Text = Master.eLang.GetString(233, "Role")
        Me.colThumb.Text = Master.eLang.GetString(234, "Thumb")
        Me.lblActors.Text = Master.eLang.GetString(231, "Actors:")
        Me.lblGenre.Text = Master.eLang.GetString(51, "Genre(s):")
        Me.lblEpisodeSorting.Text = String.Concat(Master.eLang.GetString(364, "Show Episodes by"), ":")
        Me.lblMPAA.Text = Master.eLang.GetString(235, "MPAA Rating:")
        Me.lblOrdering.Text = Master.eLang.GetString(739, "Episode Ordering:")
        Me.lblPlot.Text = Master.eLang.GetString(241, "Plot:")
        Me.lblPremiered.Text = String.Concat(Master.eLang.GetString(724, "Premiered"), ":")
        Me.lblRating.Text = Master.eLang.GetString(245, "Rating:")
        Me.lblRuntime.Text = Master.eLang.GetString(238, "Runtime:")
        Me.lblStatus.Text = String.Concat(Master.eLang.GetString(215, "Status"), ":")
        Me.lblStudio.Text = Master.eLang.GetString(226, "Studio:")
        Me.lblTitle.Text = Master.eLang.GetString(246, "Title:")
        Me.lblTopDetails.Text = Master.eLang.GetString(664, "Edit the details for the selected show.")
        Me.lblTopTitle.Text = Master.eLang.GetString(663, "Edit Show")
        Me.lblVotes.Text = Master.eLang.GetString(244, "Votes:")
        Me.tpShowBanner.Text = Master.eLang.GetString(838, "Banner")
        Me.tpShowCharacterArt.Text = Master.eLang.GetString(1140, "CharacterArt")
        Me.tpShowClearArt.Text = Master.eLang.GetString(1096, "ClearArt")
        Me.tpShowClearLogo.Text = Master.eLang.GetString(1097, "ClearLogo")
        Me.tpShowDetails.Text = Master.eLang.GetString(26, "Details")
        Me.tpShowEFanarts.Text = Master.eLang.GetString(992, "Extrafanarts")
        Me.tpShowFanart.Text = Master.eLang.GetString(149, "Fanart")
        Me.tpShowLandscape.Text = Master.eLang.GetString(1035, "Landscape")
        Me.tpShowPoster.Text = Master.eLang.GetString(148, "Poster")

        Me.cbOrdering.Items.Clear()
        Me.cbOrdering.Items.AddRange(New String() {Master.eLang.GetString(438, "Standard"), Master.eLang.GetString(1067, "DVD"), Master.eLang.GetString(839, "Absolute"), Master.eLang.GetString(1332, "Day Of Year")})

        Me.cbEpisodeSorting.Items.Clear()
        Me.cbEpisodeSorting.Items.AddRange(New String() {Master.eLang.GetString(755, "Episode #"), Master.eLang.GetString(728, "Aired")})
    End Sub

#End Region 'Methods

#Region "Nested Types"

    Friend Class ExtraImages

#Region "Fields"

        Private _image As New Images
        Private _index As Integer
        Private _name As String
        Private _path As String

#End Region 'Fields

#Region "Constructors"

        Friend Sub New()
            Clear()
        End Sub

#End Region 'Constructors

#Region "Properties"

        Friend Property Image() As Images
            Get
                Return _image
            End Get
            Set(ByVal value As Images)
                _image = value
            End Set
        End Property

        Friend Property Index() As Integer
            Get
                Return _index
            End Get
            Set(ByVal value As Integer)
                _index = value
            End Set
        End Property

        Friend Property Name() As String
            Get
                Return _name
            End Get
            Set(ByVal value As String)
                _name = value
            End Set
        End Property

        Friend Property Path() As String
            Get
                Return _path
            End Get
            Set(ByVal value As String)
                _path = value
            End Set
        End Property

#End Region 'Properties

#Region "Methods"

        Private Sub Clear()
            _image = Nothing
            _name = String.Empty
            _index = Nothing
            _path = String.Empty
        End Sub

#End Region 'Methods

    End Class

#End Region 'Nested Types

End Class