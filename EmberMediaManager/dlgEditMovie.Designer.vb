﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgEditMovie
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgEditMovie))
        Dim ListViewGroup1 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Local Subtitles", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("1")
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.lblTopDetails = New System.Windows.Forms.Label()
        Me.lblTopTitle = New System.Windows.Forms.Label()
        Me.pbTopLogo = New System.Windows.Forms.PictureBox()
        Me.tcEdit = New System.Windows.Forms.TabControl()
        Me.tpDetails = New System.Windows.Forms.TabPage()
        Me.txtMPAA = New System.Windows.Forms.TextBox()
        Me.pbStar10 = New System.Windows.Forms.PictureBox()
        Me.pbStar9 = New System.Windows.Forms.PictureBox()
        Me.pbStar8 = New System.Windows.Forms.PictureBox()
        Me.pbStar7 = New System.Windows.Forms.PictureBox()
        Me.pbStar6 = New System.Windows.Forms.PictureBox()
        Me.txtOriginalTitle = New System.Windows.Forms.TextBox()
        Me.lblOriginalTitle = New System.Windows.Forms.Label()
        Me.txtCountry = New System.Windows.Forms.TextBox()
        Me.lblCountry = New System.Windows.Forms.Label()
        Me.txtVideoSource = New System.Windows.Forms.TextBox()
        Me.lblVideoSource = New System.Windows.Forms.Label()
        Me.btnActorDown = New System.Windows.Forms.Button()
        Me.btnActorUp = New System.Windows.Forms.Button()
        Me.lblSortTilte = New System.Windows.Forms.Label()
        Me.txtSortTitle = New System.Windows.Forms.TextBox()
        Me.btnPlayTrailer = New System.Windows.Forms.Button()
        Me.btnDLTrailer = New System.Windows.Forms.Button()
        Me.clbGenre = New System.Windows.Forms.CheckedListBox()
        Me.btnStudio = New System.Windows.Forms.Button()
        Me.lblStudio = New System.Windows.Forms.Label()
        Me.txtStudio = New System.Windows.Forms.TextBox()
        Me.lblTrailerURL = New System.Windows.Forms.Label()
        Me.txtTrailer = New System.Windows.Forms.TextBox()
        Me.txtReleaseDate = New System.Windows.Forms.TextBox()
        Me.lblReleaseDate = New System.Windows.Forms.Label()
        Me.lblCredits = New System.Windows.Forms.Label()
        Me.txtCredits = New System.Windows.Forms.TextBox()
        Me.lblCerts = New System.Windows.Forms.Label()
        Me.txtCerts = New System.Windows.Forms.TextBox()
        Me.lblRuntime = New System.Windows.Forms.Label()
        Me.txtRuntime = New System.Windows.Forms.TextBox()
        Me.lblMPAADesc = New System.Windows.Forms.Label()
        Me.txtMPAADesc = New System.Windows.Forms.TextBox()
        Me.btnEditActor = New System.Windows.Forms.Button()
        Me.btnAddActor = New System.Windows.Forms.Button()
        Me.btnManual = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.lblActors = New System.Windows.Forms.Label()
        Me.lvActors = New System.Windows.Forms.ListView()
        Me.colID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colRole = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colThumb = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lbMPAA = New System.Windows.Forms.ListBox()
        Me.lblGenre = New System.Windows.Forms.Label()
        Me.lblMPAA = New System.Windows.Forms.Label()
        Me.lblDirector = New System.Windows.Forms.Label()
        Me.txtDirector = New System.Windows.Forms.TextBox()
        Me.txtTop250 = New System.Windows.Forms.TextBox()
        Me.lblTop250 = New System.Windows.Forms.Label()
        Me.lblPlot = New System.Windows.Forms.Label()
        Me.txtPlot = New System.Windows.Forms.TextBox()
        Me.lblOutline = New System.Windows.Forms.Label()
        Me.txtOutline = New System.Windows.Forms.TextBox()
        Me.lblTagline = New System.Windows.Forms.Label()
        Me.txtTagline = New System.Windows.Forms.TextBox()
        Me.pbStar5 = New System.Windows.Forms.PictureBox()
        Me.pbStar4 = New System.Windows.Forms.PictureBox()
        Me.pbStar3 = New System.Windows.Forms.PictureBox()
        Me.pbStar2 = New System.Windows.Forms.PictureBox()
        Me.pbStar1 = New System.Windows.Forms.PictureBox()
        Me.txtVotes = New System.Windows.Forms.TextBox()
        Me.lblVotes = New System.Windows.Forms.Label()
        Me.lblRating = New System.Windows.Forms.Label()
        Me.mtxtYear = New System.Windows.Forms.MaskedTextBox()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.tpPoster = New System.Windows.Forms.TabPage()
        Me.btnSetPosterDL = New System.Windows.Forms.Button()
        Me.btnRemovePoster = New System.Windows.Forms.Button()
        Me.lblPosterSize = New System.Windows.Forms.Label()
        Me.btnSetPosterScrape = New System.Windows.Forms.Button()
        Me.btnSetPosterLocal = New System.Windows.Forms.Button()
        Me.pbPoster = New System.Windows.Forms.PictureBox()
        Me.tpBanner = New System.Windows.Forms.TabPage()
        Me.btnSetBannerDL = New System.Windows.Forms.Button()
        Me.btnRemoveBanner = New System.Windows.Forms.Button()
        Me.lblBannerSize = New System.Windows.Forms.Label()
        Me.btnSetBannerScrape = New System.Windows.Forms.Button()
        Me.btnSetBannerLocal = New System.Windows.Forms.Button()
        Me.pbBanner = New System.Windows.Forms.PictureBox()
        Me.tpLandscape = New System.Windows.Forms.TabPage()
        Me.btnSetLandscapeDL = New System.Windows.Forms.Button()
        Me.btnRemoveLandscape = New System.Windows.Forms.Button()
        Me.lblLandscapeSize = New System.Windows.Forms.Label()
        Me.btnSetLandscapeScrape = New System.Windows.Forms.Button()
        Me.btnSetLandscapeLocal = New System.Windows.Forms.Button()
        Me.pbLandscape = New System.Windows.Forms.PictureBox()
        Me.tpClearArt = New System.Windows.Forms.TabPage()
        Me.btnSetClearArtDL = New System.Windows.Forms.Button()
        Me.btnRemoveClearArt = New System.Windows.Forms.Button()
        Me.lblClearArtSize = New System.Windows.Forms.Label()
        Me.btnSetClearArtScrape = New System.Windows.Forms.Button()
        Me.btnSetClearArtLocal = New System.Windows.Forms.Button()
        Me.pbClearArt = New System.Windows.Forms.PictureBox()
        Me.tpClearLogo = New System.Windows.Forms.TabPage()
        Me.btnSetClearLogoDL = New System.Windows.Forms.Button()
        Me.btnRemoveClearLogo = New System.Windows.Forms.Button()
        Me.lblClearLogoSize = New System.Windows.Forms.Label()
        Me.btnSetClearLogoScrape = New System.Windows.Forms.Button()
        Me.btnSetClearLogoLocal = New System.Windows.Forms.Button()
        Me.pbClearLogo = New System.Windows.Forms.PictureBox()
        Me.tpDiscArt = New System.Windows.Forms.TabPage()
        Me.btnSetDiscArtDL = New System.Windows.Forms.Button()
        Me.btnRemoveDiscArt = New System.Windows.Forms.Button()
        Me.lblDiscArtSize = New System.Windows.Forms.Label()
        Me.btnSetDiscArtScrape = New System.Windows.Forms.Button()
        Me.btnSetDiscArtLocal = New System.Windows.Forms.Button()
        Me.pbDiscArt = New System.Windows.Forms.PictureBox()
        Me.tpFanart = New System.Windows.Forms.TabPage()
        Me.btnSetFanartDL = New System.Windows.Forms.Button()
        Me.btnRemoveFanart = New System.Windows.Forms.Button()
        Me.lblFanartSize = New System.Windows.Forms.Label()
        Me.btnSetFanartScrape = New System.Windows.Forms.Button()
        Me.btnSetFanartLocal = New System.Windows.Forms.Button()
        Me.pbFanart = New System.Windows.Forms.PictureBox()
        Me.tpEFanarts = New System.Windows.Forms.TabPage()
        Me.lblEFanartsSize = New System.Windows.Forms.Label()
        Me.pnlEFanartsBG = New System.Windows.Forms.Panel()
        Me.pnlEFanartsSetAsFanart = New System.Windows.Forms.Panel()
        Me.btnEFanartsSetAsFanart = New System.Windows.Forms.Button()
        Me.btnEFanartsRefresh = New System.Windows.Forms.Button()
        Me.btnEFanartsRemove = New System.Windows.Forms.Button()
        Me.pnlMovieEFanartsQueue = New System.Windows.Forms.Panel()
        Me.lbMovieEFanartsQueue = New System.Windows.Forms.Label()
        Me.btnMovieEFanartsTransfer = New System.Windows.Forms.Button()
        Me.pbEFanarts = New System.Windows.Forms.PictureBox()
        Me.tpEThumbs = New System.Windows.Forms.TabPage()
        Me.lblEThumbsSize = New System.Windows.Forms.Label()
        Me.pnlEThumbsBG = New System.Windows.Forms.Panel()
        Me.pnlMovieETQueue = New System.Windows.Forms.Panel()
        Me.lbMovieEThumbsQueue = New System.Windows.Forms.Label()
        Me.btnMovieEThumbsTransfer = New System.Windows.Forms.Button()
        Me.pnlEThumbsSetAsFanart = New System.Windows.Forms.Panel()
        Me.btnEThumbsSetAsFanart = New System.Windows.Forms.Button()
        Me.btnEThumbsRefresh = New System.Windows.Forms.Button()
        Me.btnEThumbsRemove = New System.Windows.Forms.Button()
        Me.btnEThumbsDown = New System.Windows.Forms.Button()
        Me.btnEThumbsUp = New System.Windows.Forms.Button()
        Me.pbEThumbs = New System.Windows.Forms.PictureBox()
        Me.tpFrameExtraction = New System.Windows.Forms.TabPage()
        Me.pnlFrameExtrator = New System.Windows.Forms.Panel()
        Me.tpSubtitles = New System.Windows.Forms.TabPage()
        Me.lblSubtitlesPreview = New System.Windows.Forms.Label()
        Me.txtSubtitlesPreview = New System.Windows.Forms.TextBox()
        Me.lvSubtitles = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnRemoveSubtitle = New System.Windows.Forms.Button()
        Me.btnSetubtitleDL = New System.Windows.Forms.Button()
        Me.btnSetSubtitleScrape = New System.Windows.Forms.Button()
        Me.btnSetSubtitleLocal = New System.Windows.Forms.Button()
        Me.tpTrailer = New System.Windows.Forms.TabPage()
        Me.pnlTrailerPreview = New System.Windows.Forms.Panel()
        Me.pnlTrailerPreviewNoPlayer = New System.Windows.Forms.Panel()
        Me.tblTrailerPreviewNoPlayer = New System.Windows.Forms.TableLayoutPanel()
        Me.lblTrailerPreviewNoPlayer = New System.Windows.Forms.Label()
        Me.btnSetTrailerDL = New System.Windows.Forms.Button()
        Me.btnRemoveTrailer = New System.Windows.Forms.Button()
        Me.btnSetTrailerScrape = New System.Windows.Forms.Button()
        Me.btnSetTrailerLocal = New System.Windows.Forms.Button()
        Me.tpTheme = New System.Windows.Forms.TabPage()
        Me.pnlThemePreview = New System.Windows.Forms.Panel()
        Me.pnlThemePreviewNoPlayer = New System.Windows.Forms.Panel()
        Me.tblThemePreviewNoPlayer = New System.Windows.Forms.TableLayoutPanel()
        Me.lblThemePreviewNoPlayer = New System.Windows.Forms.Label()
        Me.btnSetThemeDL = New System.Windows.Forms.Button()
        Me.btnRemoveTheme = New System.Windows.Forms.Button()
        Me.btnSetThemeScrape = New System.Windows.Forms.Button()
        Me.btnSetThemeLocal = New System.Windows.Forms.Button()
        Me.tpMetaData = New System.Windows.Forms.TabPage()
        Me.pnlFileInfo = New System.Windows.Forms.Panel()
        Me.tpMediaStub = New System.Windows.Forms.TabPage()
        Me.lblMediaStubMessage = New System.Windows.Forms.Label()
        Me.lblMediaStubTitle = New System.Windows.Forms.Label()
        Me.txtMediaStubMessage = New System.Windows.Forms.TextBox()
        Me.txtMediaStubTitle = New System.Windows.Forms.TextBox()
        Me.ofdLocalFiles = New System.Windows.Forms.OpenFileDialog()
        Me.chkMark = New System.Windows.Forms.CheckBox()
        Me.btnRescrape = New System.Windows.Forms.Button()
        Me.btnChangeMovie = New System.Windows.Forms.Button()
        Me.tmrDelay = New System.Windows.Forms.Timer(Me.components)
        Me.chkWatched = New System.Windows.Forms.CheckBox()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.tsFilename = New System.Windows.Forms.ToolStripStatusLabel()
        Me.txtLastPlayed = New System.Windows.Forms.TextBox()
        Me.pnlTop.SuspendLayout()
        CType(Me.pbTopLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tcEdit.SuspendLayout()
        Me.tpDetails.SuspendLayout()
        CType(Me.pbStar10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbStar9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbStar8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbStar7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbStar6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbStar5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbStar4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbStar3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbStar2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbStar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpPoster.SuspendLayout()
        CType(Me.pbPoster, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpBanner.SuspendLayout()
        CType(Me.pbBanner, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpLandscape.SuspendLayout()
        CType(Me.pbLandscape, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpClearArt.SuspendLayout()
        CType(Me.pbClearArt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpClearLogo.SuspendLayout()
        CType(Me.pbClearLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpDiscArt.SuspendLayout()
        CType(Me.pbDiscArt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpFanart.SuspendLayout()
        CType(Me.pbFanart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpEFanarts.SuspendLayout()
        Me.pnlEFanartsSetAsFanart.SuspendLayout()
        Me.pnlMovieEFanartsQueue.SuspendLayout()
        CType(Me.pbEFanarts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpEThumbs.SuspendLayout()
        Me.pnlMovieETQueue.SuspendLayout()
        Me.pnlEThumbsSetAsFanart.SuspendLayout()
        CType(Me.pbEThumbs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpFrameExtraction.SuspendLayout()
        Me.tpSubtitles.SuspendLayout()
        Me.tpTrailer.SuspendLayout()
        Me.pnlTrailerPreview.SuspendLayout()
        Me.pnlTrailerPreviewNoPlayer.SuspendLayout()
        Me.tblTrailerPreviewNoPlayer.SuspendLayout()
        Me.tpTheme.SuspendLayout()
        Me.pnlThemePreview.SuspendLayout()
        Me.pnlThemePreviewNoPlayer.SuspendLayout()
        Me.tblThemePreviewNoPlayer.SuspendLayout()
        Me.tpMetaData.SuspendLayout()
        Me.tpMediaStub.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OK_Button.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.OK_Button.Location = New System.Drawing.Point(856, 593)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Cancel_Button.Location = New System.Drawing.Point(929, 593)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        '
        'pnlTop
        '
        Me.pnlTop.BackColor = System.Drawing.Color.LightSteelBlue
        Me.pnlTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlTop.Controls.Add(Me.lblTopDetails)
        Me.pnlTop.Controls.Add(Me.lblTopTitle)
        Me.pnlTop.Controls.Add(Me.pbTopLogo)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(1008, 64)
        Me.pnlTop.TabIndex = 2
        '
        'lblTopDetails
        '
        Me.lblTopDetails.AutoSize = True
        Me.lblTopDetails.BackColor = System.Drawing.Color.Transparent
        Me.lblTopDetails.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblTopDetails.ForeColor = System.Drawing.Color.White
        Me.lblTopDetails.Location = New System.Drawing.Point(61, 38)
        Me.lblTopDetails.Name = "lblTopDetails"
        Me.lblTopDetails.Size = New System.Drawing.Size(205, 13)
        Me.lblTopDetails.TabIndex = 1
        Me.lblTopDetails.Text = "Edit the details for the selected movie."
        '
        'lblTopTitle
        '
        Me.lblTopTitle.AutoSize = True
        Me.lblTopTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTopTitle.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblTopTitle.ForeColor = System.Drawing.Color.White
        Me.lblTopTitle.Location = New System.Drawing.Point(58, 3)
        Me.lblTopTitle.Name = "lblTopTitle"
        Me.lblTopTitle.Size = New System.Drawing.Size(137, 32)
        Me.lblTopTitle.TabIndex = 0
        Me.lblTopTitle.Text = "Edit Movie"
        '
        'pbTopLogo
        '
        Me.pbTopLogo.BackColor = System.Drawing.Color.Transparent
        Me.pbTopLogo.Image = CType(resources.GetObject("pbTopLogo.Image"), System.Drawing.Image)
        Me.pbTopLogo.Location = New System.Drawing.Point(7, 8)
        Me.pbTopLogo.Name = "pbTopLogo"
        Me.pbTopLogo.Size = New System.Drawing.Size(48, 48)
        Me.pbTopLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pbTopLogo.TabIndex = 0
        Me.pbTopLogo.TabStop = False
        '
        'tcEdit
        '
        Me.tcEdit.Controls.Add(Me.tpDetails)
        Me.tcEdit.Controls.Add(Me.tpPoster)
        Me.tcEdit.Controls.Add(Me.tpBanner)
        Me.tcEdit.Controls.Add(Me.tpLandscape)
        Me.tcEdit.Controls.Add(Me.tpClearArt)
        Me.tcEdit.Controls.Add(Me.tpClearLogo)
        Me.tcEdit.Controls.Add(Me.tpDiscArt)
        Me.tcEdit.Controls.Add(Me.tpFanart)
        Me.tcEdit.Controls.Add(Me.tpEFanarts)
        Me.tcEdit.Controls.Add(Me.tpEThumbs)
        Me.tcEdit.Controls.Add(Me.tpFrameExtraction)
        Me.tcEdit.Controls.Add(Me.tpSubtitles)
        Me.tcEdit.Controls.Add(Me.tpTrailer)
        Me.tcEdit.Controls.Add(Me.tpTheme)
        Me.tcEdit.Controls.Add(Me.tpMetaData)
        Me.tcEdit.Controls.Add(Me.tpMediaStub)
        Me.tcEdit.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tcEdit.Location = New System.Drawing.Point(4, 70)
        Me.tcEdit.Name = "tcEdit"
        Me.tcEdit.SelectedIndex = 0
        Me.tcEdit.Size = New System.Drawing.Size(1004, 517)
        Me.tcEdit.TabIndex = 3
        '
        'tpDetails
        '
        Me.tpDetails.Controls.Add(Me.txtMPAA)
        Me.tpDetails.Controls.Add(Me.pbStar10)
        Me.tpDetails.Controls.Add(Me.pbStar9)
        Me.tpDetails.Controls.Add(Me.pbStar8)
        Me.tpDetails.Controls.Add(Me.pbStar7)
        Me.tpDetails.Controls.Add(Me.pbStar6)
        Me.tpDetails.Controls.Add(Me.txtOriginalTitle)
        Me.tpDetails.Controls.Add(Me.lblOriginalTitle)
        Me.tpDetails.Controls.Add(Me.txtCountry)
        Me.tpDetails.Controls.Add(Me.lblCountry)
        Me.tpDetails.Controls.Add(Me.txtVideoSource)
        Me.tpDetails.Controls.Add(Me.lblVideoSource)
        Me.tpDetails.Controls.Add(Me.btnActorDown)
        Me.tpDetails.Controls.Add(Me.btnActorUp)
        Me.tpDetails.Controls.Add(Me.lblSortTilte)
        Me.tpDetails.Controls.Add(Me.txtSortTitle)
        Me.tpDetails.Controls.Add(Me.btnPlayTrailer)
        Me.tpDetails.Controls.Add(Me.btnDLTrailer)
        Me.tpDetails.Controls.Add(Me.clbGenre)
        Me.tpDetails.Controls.Add(Me.btnStudio)
        Me.tpDetails.Controls.Add(Me.lblStudio)
        Me.tpDetails.Controls.Add(Me.txtStudio)
        Me.tpDetails.Controls.Add(Me.lblTrailerURL)
        Me.tpDetails.Controls.Add(Me.txtTrailer)
        Me.tpDetails.Controls.Add(Me.txtReleaseDate)
        Me.tpDetails.Controls.Add(Me.lblReleaseDate)
        Me.tpDetails.Controls.Add(Me.lblCredits)
        Me.tpDetails.Controls.Add(Me.txtCredits)
        Me.tpDetails.Controls.Add(Me.lblCerts)
        Me.tpDetails.Controls.Add(Me.txtCerts)
        Me.tpDetails.Controls.Add(Me.lblRuntime)
        Me.tpDetails.Controls.Add(Me.txtRuntime)
        Me.tpDetails.Controls.Add(Me.lblMPAADesc)
        Me.tpDetails.Controls.Add(Me.txtMPAADesc)
        Me.tpDetails.Controls.Add(Me.btnEditActor)
        Me.tpDetails.Controls.Add(Me.btnAddActor)
        Me.tpDetails.Controls.Add(Me.btnManual)
        Me.tpDetails.Controls.Add(Me.btnRemove)
        Me.tpDetails.Controls.Add(Me.lblActors)
        Me.tpDetails.Controls.Add(Me.lvActors)
        Me.tpDetails.Controls.Add(Me.lbMPAA)
        Me.tpDetails.Controls.Add(Me.lblGenre)
        Me.tpDetails.Controls.Add(Me.lblMPAA)
        Me.tpDetails.Controls.Add(Me.lblDirector)
        Me.tpDetails.Controls.Add(Me.txtDirector)
        Me.tpDetails.Controls.Add(Me.txtTop250)
        Me.tpDetails.Controls.Add(Me.lblTop250)
        Me.tpDetails.Controls.Add(Me.lblPlot)
        Me.tpDetails.Controls.Add(Me.txtPlot)
        Me.tpDetails.Controls.Add(Me.lblOutline)
        Me.tpDetails.Controls.Add(Me.txtOutline)
        Me.tpDetails.Controls.Add(Me.lblTagline)
        Me.tpDetails.Controls.Add(Me.txtTagline)
        Me.tpDetails.Controls.Add(Me.pbStar5)
        Me.tpDetails.Controls.Add(Me.pbStar4)
        Me.tpDetails.Controls.Add(Me.pbStar3)
        Me.tpDetails.Controls.Add(Me.pbStar2)
        Me.tpDetails.Controls.Add(Me.pbStar1)
        Me.tpDetails.Controls.Add(Me.txtVotes)
        Me.tpDetails.Controls.Add(Me.lblVotes)
        Me.tpDetails.Controls.Add(Me.lblRating)
        Me.tpDetails.Controls.Add(Me.mtxtYear)
        Me.tpDetails.Controls.Add(Me.lblYear)
        Me.tpDetails.Controls.Add(Me.lblTitle)
        Me.tpDetails.Controls.Add(Me.txtTitle)
        Me.tpDetails.Location = New System.Drawing.Point(4, 22)
        Me.tpDetails.Name = "tpDetails"
        Me.tpDetails.Padding = New System.Windows.Forms.Padding(3)
        Me.tpDetails.Size = New System.Drawing.Size(996, 491)
        Me.tpDetails.TabIndex = 0
        Me.tpDetails.Text = "Details"
        Me.tpDetails.UseVisualStyleBackColor = True
        '
        'txtMPAA
        '
        Me.txtMPAA.BackColor = System.Drawing.SystemColors.Window
        Me.txtMPAA.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txtMPAA.Location = New System.Drawing.Point(691, 281)
        Me.txtMPAA.Name = "txtMPAA"
        Me.txtMPAA.Size = New System.Drawing.Size(213, 22)
        Me.txtMPAA.TabIndex = 73
        '
        'pbStar10
        '
        Me.pbStar10.Location = New System.Drawing.Point(223, 220)
        Me.pbStar10.Name = "pbStar10"
        Me.pbStar10.Size = New System.Drawing.Size(24, 24)
        Me.pbStar10.TabIndex = 72
        Me.pbStar10.TabStop = False
        '
        'pbStar9
        '
        Me.pbStar9.Location = New System.Drawing.Point(199, 220)
        Me.pbStar9.Name = "pbStar9"
        Me.pbStar9.Size = New System.Drawing.Size(24, 24)
        Me.pbStar9.TabIndex = 71
        Me.pbStar9.TabStop = False
        '
        'pbStar8
        '
        Me.pbStar8.Location = New System.Drawing.Point(175, 220)
        Me.pbStar8.Name = "pbStar8"
        Me.pbStar8.Size = New System.Drawing.Size(24, 24)
        Me.pbStar8.TabIndex = 70
        Me.pbStar8.TabStop = False
        '
        'pbStar7
        '
        Me.pbStar7.Location = New System.Drawing.Point(151, 220)
        Me.pbStar7.Name = "pbStar7"
        Me.pbStar7.Size = New System.Drawing.Size(24, 24)
        Me.pbStar7.TabIndex = 69
        Me.pbStar7.TabStop = False
        '
        'pbStar6
        '
        Me.pbStar6.Location = New System.Drawing.Point(127, 220)
        Me.pbStar6.Name = "pbStar6"
        Me.pbStar6.Size = New System.Drawing.Size(24, 24)
        Me.pbStar6.TabIndex = 68
        Me.pbStar6.TabStop = False
        '
        'txtOriginalTitle
        '
        Me.txtOriginalTitle.BackColor = System.Drawing.SystemColors.Window
        Me.txtOriginalTitle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txtOriginalTitle.Location = New System.Drawing.Point(7, 63)
        Me.txtOriginalTitle.Name = "txtOriginalTitle"
        Me.txtOriginalTitle.Size = New System.Drawing.Size(252, 22)
        Me.txtOriginalTitle.TabIndex = 3
        '
        'lblOriginalTitle
        '
        Me.lblOriginalTitle.AutoSize = True
        Me.lblOriginalTitle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblOriginalTitle.Location = New System.Drawing.Point(5, 47)
        Me.lblOriginalTitle.Name = "lblOriginalTitle"
        Me.lblOriginalTitle.Size = New System.Drawing.Size(76, 13)
        Me.lblOriginalTitle.TabIndex = 2
        Me.lblOriginalTitle.Text = "Original Title:"
        '
        'txtCountry
        '
        Me.txtCountry.BackColor = System.Drawing.SystemColors.Window
        Me.txtCountry.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txtCountry.Location = New System.Drawing.Point(8, 265)
        Me.txtCountry.Name = "txtCountry"
        Me.txtCountry.Size = New System.Drawing.Size(251, 22)
        Me.txtCountry.TabIndex = 12
        '
        'lblCountry
        '
        Me.lblCountry.AutoSize = True
        Me.lblCountry.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblCountry.Location = New System.Drawing.Point(5, 250)
        Me.lblCountry.Name = "lblCountry"
        Me.lblCountry.Size = New System.Drawing.Size(52, 13)
        Me.lblCountry.TabIndex = 11
        Me.lblCountry.Text = "Country:"
        '
        'txtVideoSource
        '
        Me.txtVideoSource.BackColor = System.Drawing.SystemColors.Window
        Me.txtVideoSource.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txtVideoSource.Location = New System.Drawing.Point(691, 423)
        Me.txtVideoSource.Name = "txtVideoSource"
        Me.txtVideoSource.Size = New System.Drawing.Size(213, 22)
        Me.txtVideoSource.TabIndex = 48
        '
        'lblVideoSource
        '
        Me.lblVideoSource.AutoSize = True
        Me.lblVideoSource.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblVideoSource.Location = New System.Drawing.Point(689, 408)
        Me.lblVideoSource.Name = "lblVideoSource"
        Me.lblVideoSource.Size = New System.Drawing.Size(78, 13)
        Me.lblVideoSource.TabIndex = 47
        Me.lblVideoSource.Text = "Video Source:"
        '
        'btnActorDown
        '
        Me.btnActorDown.Image = CType(resources.GetObject("btnActorDown.Image"), System.Drawing.Image)
        Me.btnActorDown.Location = New System.Drawing.Point(486, 305)
        Me.btnActorDown.Name = "btnActorDown"
        Me.btnActorDown.Size = New System.Drawing.Size(23, 23)
        Me.btnActorDown.TabIndex = 34
        Me.btnActorDown.UseVisualStyleBackColor = True
        '
        'btnActorUp
        '
        Me.btnActorUp.Image = CType(resources.GetObject("btnActorUp.Image"), System.Drawing.Image)
        Me.btnActorUp.Location = New System.Drawing.Point(462, 305)
        Me.btnActorUp.Name = "btnActorUp"
        Me.btnActorUp.Size = New System.Drawing.Size(23, 23)
        Me.btnActorUp.TabIndex = 33
        Me.btnActorUp.UseVisualStyleBackColor = True
        '
        'lblSortTilte
        '
        Me.lblSortTilte.AutoSize = True
        Me.lblSortTilte.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblSortTilte.Location = New System.Drawing.Point(5, 87)
        Me.lblSortTilte.Name = "lblSortTilte"
        Me.lblSortTilte.Size = New System.Drawing.Size(56, 13)
        Me.lblSortTilte.TabIndex = 4
        Me.lblSortTilte.Text = "Sort Title:"
        '
        'txtSortTitle
        '
        Me.txtSortTitle.BackColor = System.Drawing.SystemColors.Window
        Me.txtSortTitle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txtSortTitle.Location = New System.Drawing.Point(7, 102)
        Me.txtSortTitle.Name = "txtSortTitle"
        Me.txtSortTitle.Size = New System.Drawing.Size(252, 22)
        Me.txtSortTitle.TabIndex = 5
        '
        'btnPlayTrailer
        '
        Me.btnPlayTrailer.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPlayTrailer.Image = Global.Ember_Media_Manager.My.Resources.Resources.Play_Icon
        Me.btnPlayTrailer.Location = New System.Drawing.Point(659, 462)
        Me.btnPlayTrailer.Name = "btnPlayTrailer"
        Me.btnPlayTrailer.Size = New System.Drawing.Size(23, 23)
        Me.btnPlayTrailer.TabIndex = 52
        Me.btnPlayTrailer.UseVisualStyleBackColor = True
        '
        'btnDLTrailer
        '
        Me.btnDLTrailer.Image = CType(resources.GetObject("btnDLTrailer.Image"), System.Drawing.Image)
        Me.btnDLTrailer.Location = New System.Drawing.Point(630, 462)
        Me.btnDLTrailer.Name = "btnDLTrailer"
        Me.btnDLTrailer.Size = New System.Drawing.Size(23, 23)
        Me.btnDLTrailer.TabIndex = 53
        Me.btnDLTrailer.UseVisualStyleBackColor = True
        '
        'clbGenre
        '
        Me.clbGenre.BackColor = System.Drawing.SystemColors.Window
        Me.clbGenre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.clbGenre.CheckOnClick = True
        Me.clbGenre.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.clbGenre.FormattingEnabled = True
        Me.clbGenre.IntegralHeight = False
        Me.clbGenre.Location = New System.Drawing.Point(8, 386)
        Me.clbGenre.Name = "clbGenre"
        Me.clbGenre.Size = New System.Drawing.Size(251, 102)
        Me.clbGenre.Sorted = True
        Me.clbGenre.TabIndex = 24
        '
        'btnStudio
        '
        Me.btnStudio.Image = CType(resources.GetObject("btnStudio.Image"), System.Drawing.Image)
        Me.btnStudio.Location = New System.Drawing.Point(658, 383)
        Me.btnStudio.Name = "btnStudio"
        Me.btnStudio.Size = New System.Drawing.Size(23, 23)
        Me.btnStudio.TabIndex = 44
        Me.btnStudio.UseVisualStyleBackColor = True
        '
        'lblStudio
        '
        Me.lblStudio.AutoSize = True
        Me.lblStudio.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblStudio.Location = New System.Drawing.Point(273, 369)
        Me.lblStudio.Name = "lblStudio"
        Me.lblStudio.Size = New System.Drawing.Size(44, 13)
        Me.lblStudio.TabIndex = 42
        Me.lblStudio.Text = "Studio:"
        '
        'txtStudio
        '
        Me.txtStudio.BackColor = System.Drawing.SystemColors.Window
        Me.txtStudio.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txtStudio.Location = New System.Drawing.Point(275, 384)
        Me.txtStudio.Name = "txtStudio"
        Me.txtStudio.Size = New System.Drawing.Size(377, 22)
        Me.txtStudio.TabIndex = 43
        '
        'lblTrailerURL
        '
        Me.lblTrailerURL.AutoSize = True
        Me.lblTrailerURL.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblTrailerURL.Location = New System.Drawing.Point(272, 448)
        Me.lblTrailerURL.Name = "lblTrailerURL"
        Me.lblTrailerURL.Size = New System.Drawing.Size(65, 13)
        Me.lblTrailerURL.TabIndex = 49
        Me.lblTrailerURL.Text = "Trailer URL:"
        '
        'txtTrailer
        '
        Me.txtTrailer.BackColor = System.Drawing.SystemColors.Window
        Me.txtTrailer.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txtTrailer.Location = New System.Drawing.Point(274, 463)
        Me.txtTrailer.Name = "txtTrailer"
        Me.txtTrailer.Size = New System.Drawing.Size(350, 22)
        Me.txtTrailer.TabIndex = 50
        '
        'txtReleaseDate
        '
        Me.txtReleaseDate.BackColor = System.Drawing.SystemColors.Window
        Me.txtReleaseDate.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txtReleaseDate.Location = New System.Drawing.Point(74, 182)
        Me.txtReleaseDate.Name = "txtReleaseDate"
        Me.txtReleaseDate.Size = New System.Drawing.Size(185, 22)
        Me.txtReleaseDate.TabIndex = 14
        '
        'lblReleaseDate
        '
        Me.lblReleaseDate.AutoSize = True
        Me.lblReleaseDate.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblReleaseDate.Location = New System.Drawing.Point(71, 167)
        Me.lblReleaseDate.Name = "lblReleaseDate"
        Me.lblReleaseDate.Size = New System.Drawing.Size(76, 13)
        Me.lblReleaseDate.TabIndex = 13
        Me.lblReleaseDate.Text = "Release Date:"
        '
        'lblCredits
        '
        Me.lblCredits.AutoSize = True
        Me.lblCredits.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblCredits.Location = New System.Drawing.Point(271, 331)
        Me.lblCredits.Name = "lblCredits"
        Me.lblCredits.Size = New System.Drawing.Size(46, 13)
        Me.lblCredits.TabIndex = 40
        Me.lblCredits.Text = "Credits:"
        '
        'txtCredits
        '
        Me.txtCredits.BackColor = System.Drawing.SystemColors.Window
        Me.txtCredits.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txtCredits.Location = New System.Drawing.Point(273, 346)
        Me.txtCredits.Name = "txtCredits"
        Me.txtCredits.Size = New System.Drawing.Size(408, 22)
        Me.txtCredits.TabIndex = 41
        '
        'lblCerts
        '
        Me.lblCerts.AutoSize = True
        Me.lblCerts.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblCerts.Location = New System.Drawing.Point(272, 408)
        Me.lblCerts.Name = "lblCerts"
        Me.lblCerts.Size = New System.Drawing.Size(86, 13)
        Me.lblCerts.TabIndex = 45
        Me.lblCerts.Text = "Certification(s):"
        '
        'txtCerts
        '
        Me.txtCerts.BackColor = System.Drawing.SystemColors.Window
        Me.txtCerts.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txtCerts.Location = New System.Drawing.Point(274, 423)
        Me.txtCerts.Name = "txtCerts"
        Me.txtCerts.Size = New System.Drawing.Size(408, 22)
        Me.txtCerts.TabIndex = 46
        '
        'lblRuntime
        '
        Me.lblRuntime.AutoSize = True
        Me.lblRuntime.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblRuntime.Location = New System.Drawing.Point(5, 290)
        Me.lblRuntime.Name = "lblRuntime"
        Me.lblRuntime.Size = New System.Drawing.Size(54, 13)
        Me.lblRuntime.TabIndex = 15
        Me.lblRuntime.Text = "Runtime:"
        '
        'txtRuntime
        '
        Me.txtRuntime.BackColor = System.Drawing.SystemColors.Window
        Me.txtRuntime.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txtRuntime.Location = New System.Drawing.Point(7, 305)
        Me.txtRuntime.Name = "txtRuntime"
        Me.txtRuntime.Size = New System.Drawing.Size(66, 22)
        Me.txtRuntime.TabIndex = 16
        '
        'lblMPAADesc
        '
        Me.lblMPAADesc.AutoSize = True
        Me.lblMPAADesc.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblMPAADesc.Location = New System.Drawing.Point(689, 329)
        Me.lblMPAADesc.Name = "lblMPAADesc"
        Me.lblMPAADesc.Size = New System.Drawing.Size(142, 13)
        Me.lblMPAADesc.TabIndex = 38
        Me.lblMPAADesc.Text = "MPAA Rating Description:"
        '
        'txtMPAADesc
        '
        Me.txtMPAADesc.BackColor = System.Drawing.SystemColors.Window
        Me.txtMPAADesc.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txtMPAADesc.Location = New System.Drawing.Point(691, 345)
        Me.txtMPAADesc.Multiline = True
        Me.txtMPAADesc.Name = "txtMPAADesc"
        Me.txtMPAADesc.Size = New System.Drawing.Size(213, 60)
        Me.txtMPAADesc.TabIndex = 39
        '
        'btnEditActor
        '
        Me.btnEditActor.Image = CType(resources.GetObject("btnEditActor.Image"), System.Drawing.Image)
        Me.btnEditActor.Location = New System.Drawing.Point(302, 304)
        Me.btnEditActor.Name = "btnEditActor"
        Me.btnEditActor.Size = New System.Drawing.Size(23, 23)
        Me.btnEditActor.TabIndex = 32
        Me.btnEditActor.UseVisualStyleBackColor = True
        '
        'btnAddActor
        '
        Me.btnAddActor.Image = CType(resources.GetObject("btnAddActor.Image"), System.Drawing.Image)
        Me.btnAddActor.Location = New System.Drawing.Point(273, 304)
        Me.btnAddActor.Name = "btnAddActor"
        Me.btnAddActor.Size = New System.Drawing.Size(23, 23)
        Me.btnAddActor.TabIndex = 31
        Me.btnAddActor.UseVisualStyleBackColor = True
        '
        'btnManual
        '
        Me.btnManual.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnManual.Location = New System.Drawing.Point(896, 462)
        Me.btnManual.Name = "btnManual"
        Me.btnManual.Size = New System.Drawing.Size(92, 23)
        Me.btnManual.TabIndex = 54
        Me.btnManual.Text = "Manual Edit"
        Me.btnManual.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.Image = CType(resources.GetObject("btnRemove.Image"), System.Drawing.Image)
        Me.btnRemove.Location = New System.Drawing.Point(658, 304)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(23, 23)
        Me.btnRemove.TabIndex = 35
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'lblActors
        '
        Me.lblActors.AutoSize = True
        Me.lblActors.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblActors.Location = New System.Drawing.Point(271, 142)
        Me.lblActors.Name = "lblActors"
        Me.lblActors.Size = New System.Drawing.Size(43, 13)
        Me.lblActors.TabIndex = 29
        Me.lblActors.Text = "Actors:"
        '
        'lvActors
        '
        Me.lvActors.BackColor = System.Drawing.SystemColors.Window
        Me.lvActors.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvActors.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colID, Me.colName, Me.colRole, Me.colThumb})
        Me.lvActors.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lvActors.FullRowSelect = True
        Me.lvActors.Location = New System.Drawing.Point(273, 156)
        Me.lvActors.Name = "lvActors"
        Me.lvActors.Size = New System.Drawing.Size(408, 147)
        Me.lvActors.TabIndex = 30
        Me.lvActors.UseCompatibleStateImageBehavior = False
        Me.lvActors.View = System.Windows.Forms.View.Details
        '
        'colID
        '
        Me.colID.Text = "ID"
        Me.colID.Width = 0
        '
        'colName
        '
        Me.colName.Text = "Name"
        Me.colName.Width = 110
        '
        'colRole
        '
        Me.colRole.Text = "Role"
        Me.colRole.Width = 100
        '
        'colThumb
        '
        Me.colThumb.Text = "Thumb"
        Me.colThumb.Width = 174
        '
        'lbMPAA
        '
        Me.lbMPAA.BackColor = System.Drawing.SystemColors.Window
        Me.lbMPAA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbMPAA.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lbMPAA.FormattingEnabled = True
        Me.lbMPAA.Location = New System.Drawing.Point(691, 156)
        Me.lbMPAA.Name = "lbMPAA"
        Me.lbMPAA.Size = New System.Drawing.Size(213, 119)
        Me.lbMPAA.TabIndex = 37
        '
        'lblGenre
        '
        Me.lblGenre.AutoSize = True
        Me.lblGenre.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblGenre.Location = New System.Drawing.Point(5, 371)
        Me.lblGenre.Name = "lblGenre"
        Me.lblGenre.Size = New System.Drawing.Size(41, 13)
        Me.lblGenre.TabIndex = 23
        Me.lblGenre.Text = "Genre:"
        '
        'lblMPAA
        '
        Me.lblMPAA.AutoSize = True
        Me.lblMPAA.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblMPAA.Location = New System.Drawing.Point(689, 142)
        Me.lblMPAA.Name = "lblMPAA"
        Me.lblMPAA.Size = New System.Drawing.Size(80, 13)
        Me.lblMPAA.TabIndex = 36
        Me.lblMPAA.Text = "MPAA Rating:"
        '
        'lblDirector
        '
        Me.lblDirector.AutoSize = True
        Me.lblDirector.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblDirector.Location = New System.Drawing.Point(5, 330)
        Me.lblDirector.Name = "lblDirector"
        Me.lblDirector.Size = New System.Drawing.Size(51, 13)
        Me.lblDirector.TabIndex = 21
        Me.lblDirector.Text = "Director:"
        '
        'txtDirector
        '
        Me.txtDirector.BackColor = System.Drawing.SystemColors.Window
        Me.txtDirector.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txtDirector.Location = New System.Drawing.Point(7, 345)
        Me.txtDirector.Name = "txtDirector"
        Me.txtDirector.Size = New System.Drawing.Size(252, 22)
        Me.txtDirector.TabIndex = 22
        '
        'txtTop250
        '
        Me.txtTop250.BackColor = System.Drawing.SystemColors.Window
        Me.txtTop250.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txtTop250.Location = New System.Drawing.Point(156, 305)
        Me.txtTop250.Name = "txtTop250"
        Me.txtTop250.Size = New System.Drawing.Size(43, 22)
        Me.txtTop250.TabIndex = 20
        '
        'lblTop250
        '
        Me.lblTop250.AutoSize = True
        Me.lblTop250.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblTop250.Location = New System.Drawing.Point(153, 290)
        Me.lblTop250.Name = "lblTop250"
        Me.lblTop250.Size = New System.Drawing.Size(50, 13)
        Me.lblTop250.TabIndex = 19
        Me.lblTop250.Text = "Top 250:"
        '
        'lblPlot
        '
        Me.lblPlot.AutoSize = True
        Me.lblPlot.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblPlot.Location = New System.Drawing.Point(497, 7)
        Me.lblPlot.Name = "lblPlot"
        Me.lblPlot.Size = New System.Drawing.Size(31, 13)
        Me.lblPlot.TabIndex = 27
        Me.lblPlot.Text = "Plot:"
        '
        'txtPlot
        '
        Me.txtPlot.AcceptsReturn = True
        Me.txtPlot.BackColor = System.Drawing.SystemColors.Window
        Me.txtPlot.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txtPlot.Location = New System.Drawing.Point(499, 22)
        Me.txtPlot.Multiline = True
        Me.txtPlot.Name = "txtPlot"
        Me.txtPlot.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtPlot.Size = New System.Drawing.Size(405, 112)
        Me.txtPlot.TabIndex = 28
        '
        'lblOutline
        '
        Me.lblOutline.AutoSize = True
        Me.lblOutline.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblOutline.Location = New System.Drawing.Point(271, 7)
        Me.lblOutline.Name = "lblOutline"
        Me.lblOutline.Size = New System.Drawing.Size(48, 13)
        Me.lblOutline.TabIndex = 25
        Me.lblOutline.Text = "Outline:"
        '
        'txtOutline
        '
        Me.txtOutline.AcceptsReturn = True
        Me.txtOutline.BackColor = System.Drawing.SystemColors.Window
        Me.txtOutline.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txtOutline.Location = New System.Drawing.Point(273, 22)
        Me.txtOutline.Multiline = True
        Me.txtOutline.Name = "txtOutline"
        Me.txtOutline.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtOutline.Size = New System.Drawing.Size(220, 112)
        Me.txtOutline.TabIndex = 26
        '
        'lblTagline
        '
        Me.lblTagline.AutoSize = True
        Me.lblTagline.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblTagline.Location = New System.Drawing.Point(5, 127)
        Me.lblTagline.Name = "lblTagline"
        Me.lblTagline.Size = New System.Drawing.Size(47, 13)
        Me.lblTagline.TabIndex = 6
        Me.lblTagline.Text = "Tagline:"
        '
        'txtTagline
        '
        Me.txtTagline.BackColor = System.Drawing.SystemColors.Window
        Me.txtTagline.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txtTagline.Location = New System.Drawing.Point(7, 142)
        Me.txtTagline.Name = "txtTagline"
        Me.txtTagline.Size = New System.Drawing.Size(252, 22)
        Me.txtTagline.TabIndex = 7
        '
        'pbStar5
        '
        Me.pbStar5.Location = New System.Drawing.Point(103, 220)
        Me.pbStar5.Name = "pbStar5"
        Me.pbStar5.Size = New System.Drawing.Size(24, 24)
        Me.pbStar5.TabIndex = 67
        Me.pbStar5.TabStop = False
        '
        'pbStar4
        '
        Me.pbStar4.Location = New System.Drawing.Point(79, 220)
        Me.pbStar4.Name = "pbStar4"
        Me.pbStar4.Size = New System.Drawing.Size(24, 24)
        Me.pbStar4.TabIndex = 66
        Me.pbStar4.TabStop = False
        '
        'pbStar3
        '
        Me.pbStar3.Location = New System.Drawing.Point(55, 220)
        Me.pbStar3.Name = "pbStar3"
        Me.pbStar3.Size = New System.Drawing.Size(24, 24)
        Me.pbStar3.TabIndex = 65
        Me.pbStar3.TabStop = False
        '
        'pbStar2
        '
        Me.pbStar2.Location = New System.Drawing.Point(31, 220)
        Me.pbStar2.Name = "pbStar2"
        Me.pbStar2.Size = New System.Drawing.Size(24, 24)
        Me.pbStar2.TabIndex = 64
        Me.pbStar2.TabStop = False
        '
        'pbStar1
        '
        Me.pbStar1.Location = New System.Drawing.Point(7, 220)
        Me.pbStar1.Name = "pbStar1"
        Me.pbStar1.Size = New System.Drawing.Size(24, 24)
        Me.pbStar1.TabIndex = 63
        Me.pbStar1.TabStop = False
        '
        'txtVotes
        '
        Me.txtVotes.BackColor = System.Drawing.SystemColors.Window
        Me.txtVotes.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txtVotes.Location = New System.Drawing.Point(81, 305)
        Me.txtVotes.Name = "txtVotes"
        Me.txtVotes.Size = New System.Drawing.Size(66, 22)
        Me.txtVotes.TabIndex = 18
        '
        'lblVotes
        '
        Me.lblVotes.AutoSize = True
        Me.lblVotes.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblVotes.Location = New System.Drawing.Point(78, 290)
        Me.lblVotes.Name = "lblVotes"
        Me.lblVotes.Size = New System.Drawing.Size(38, 13)
        Me.lblVotes.TabIndex = 17
        Me.lblVotes.Text = "Votes:"
        '
        'lblRating
        '
        Me.lblRating.AutoSize = True
        Me.lblRating.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblRating.Location = New System.Drawing.Point(5, 207)
        Me.lblRating.Name = "lblRating"
        Me.lblRating.Size = New System.Drawing.Size(44, 13)
        Me.lblRating.TabIndex = 10
        Me.lblRating.Text = "Rating:"
        '
        'mtxtYear
        '
        Me.mtxtYear.BackColor = System.Drawing.SystemColors.Window
        Me.mtxtYear.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.mtxtYear.Location = New System.Drawing.Point(7, 182)
        Me.mtxtYear.Mask = "####"
        Me.mtxtYear.Name = "mtxtYear"
        Me.mtxtYear.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.mtxtYear.Size = New System.Drawing.Size(50, 22)
        Me.mtxtYear.TabIndex = 9
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblYear.Location = New System.Drawing.Point(5, 167)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(32, 13)
        Me.lblYear.TabIndex = 8
        Me.lblYear.Text = "Year:"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(5, 7)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(32, 13)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Title:"
        '
        'txtTitle
        '
        Me.txtTitle.BackColor = System.Drawing.SystemColors.Window
        Me.txtTitle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txtTitle.Location = New System.Drawing.Point(7, 22)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(252, 22)
        Me.txtTitle.TabIndex = 1
        '
        'tpPoster
        '
        Me.tpPoster.Controls.Add(Me.btnSetPosterDL)
        Me.tpPoster.Controls.Add(Me.btnRemovePoster)
        Me.tpPoster.Controls.Add(Me.lblPosterSize)
        Me.tpPoster.Controls.Add(Me.btnSetPosterScrape)
        Me.tpPoster.Controls.Add(Me.btnSetPosterLocal)
        Me.tpPoster.Controls.Add(Me.pbPoster)
        Me.tpPoster.Location = New System.Drawing.Point(4, 22)
        Me.tpPoster.Name = "tpPoster"
        Me.tpPoster.Padding = New System.Windows.Forms.Padding(3)
        Me.tpPoster.Size = New System.Drawing.Size(996, 491)
        Me.tpPoster.TabIndex = 1
        Me.tpPoster.Text = "Poster"
        Me.tpPoster.UseVisualStyleBackColor = True
        '
        'btnSetPosterDL
        '
        Me.btnSetPosterDL.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnSetPosterDL.Image = CType(resources.GetObject("btnSetPosterDL.Image"), System.Drawing.Image)
        Me.btnSetPosterDL.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSetPosterDL.Location = New System.Drawing.Point(810, 184)
        Me.btnSetPosterDL.Name = "btnSetPosterDL"
        Me.btnSetPosterDL.Size = New System.Drawing.Size(96, 83)
        Me.btnSetPosterDL.TabIndex = 3
        Me.btnSetPosterDL.Text = "Change Poster (Download)"
        Me.btnSetPosterDL.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSetPosterDL.UseVisualStyleBackColor = True
        '
        'btnRemovePoster
        '
        Me.btnRemovePoster.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnRemovePoster.Image = CType(resources.GetObject("btnRemovePoster.Image"), System.Drawing.Image)
        Me.btnRemovePoster.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnRemovePoster.Location = New System.Drawing.Point(810, 373)
        Me.btnRemovePoster.Name = "btnRemovePoster"
        Me.btnRemovePoster.Size = New System.Drawing.Size(96, 83)
        Me.btnRemovePoster.TabIndex = 4
        Me.btnRemovePoster.Text = "Remove Poster"
        Me.btnRemovePoster.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnRemovePoster.UseVisualStyleBackColor = True
        '
        'lblPosterSize
        '
        Me.lblPosterSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPosterSize.Location = New System.Drawing.Point(8, 8)
        Me.lblPosterSize.Name = "lblPosterSize"
        Me.lblPosterSize.Size = New System.Drawing.Size(105, 23)
        Me.lblPosterSize.TabIndex = 0
        Me.lblPosterSize.Text = "Size: (XXXXxXXXX)"
        Me.lblPosterSize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblPosterSize.Visible = False
        '
        'btnSetPosterScrape
        '
        Me.btnSetPosterScrape.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnSetPosterScrape.Image = CType(resources.GetObject("btnSetPosterScrape.Image"), System.Drawing.Image)
        Me.btnSetPosterScrape.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSetPosterScrape.Location = New System.Drawing.Point(810, 95)
        Me.btnSetPosterScrape.Name = "btnSetPosterScrape"
        Me.btnSetPosterScrape.Size = New System.Drawing.Size(96, 83)
        Me.btnSetPosterScrape.TabIndex = 2
        Me.btnSetPosterScrape.Text = "Change Poster (Scrape)"
        Me.btnSetPosterScrape.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSetPosterScrape.UseVisualStyleBackColor = True
        '
        'btnSetPosterLocal
        '
        Me.btnSetPosterLocal.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnSetPosterLocal.Image = CType(resources.GetObject("btnSetPosterLocal.Image"), System.Drawing.Image)
        Me.btnSetPosterLocal.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSetPosterLocal.Location = New System.Drawing.Point(810, 6)
        Me.btnSetPosterLocal.Name = "btnSetPosterLocal"
        Me.btnSetPosterLocal.Size = New System.Drawing.Size(96, 83)
        Me.btnSetPosterLocal.TabIndex = 1
        Me.btnSetPosterLocal.Text = "Change Poster (Local Browse)"
        Me.btnSetPosterLocal.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSetPosterLocal.UseVisualStyleBackColor = True
        '
        'pbPoster
        '
        Me.pbPoster.BackColor = System.Drawing.Color.DimGray
        Me.pbPoster.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbPoster.Location = New System.Drawing.Point(6, 6)
        Me.pbPoster.Name = "pbPoster"
        Me.pbPoster.Size = New System.Drawing.Size(800, 450)
        Me.pbPoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbPoster.TabIndex = 0
        Me.pbPoster.TabStop = False
        '
        'tpBanner
        '
        Me.tpBanner.Controls.Add(Me.btnSetBannerDL)
        Me.tpBanner.Controls.Add(Me.btnRemoveBanner)
        Me.tpBanner.Controls.Add(Me.lblBannerSize)
        Me.tpBanner.Controls.Add(Me.btnSetBannerScrape)
        Me.tpBanner.Controls.Add(Me.btnSetBannerLocal)
        Me.tpBanner.Controls.Add(Me.pbBanner)
        Me.tpBanner.Location = New System.Drawing.Point(4, 22)
        Me.tpBanner.Name = "tpBanner"
        Me.tpBanner.Padding = New System.Windows.Forms.Padding(3)
        Me.tpBanner.Size = New System.Drawing.Size(996, 491)
        Me.tpBanner.TabIndex = 8
        Me.tpBanner.Text = "Banner"
        Me.tpBanner.UseVisualStyleBackColor = True
        '
        'btnSetBannerDL
        '
        Me.btnSetBannerDL.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnSetBannerDL.Image = CType(resources.GetObject("btnSetBannerDL.Image"), System.Drawing.Image)
        Me.btnSetBannerDL.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSetBannerDL.Location = New System.Drawing.Point(810, 184)
        Me.btnSetBannerDL.Name = "btnSetBannerDL"
        Me.btnSetBannerDL.Size = New System.Drawing.Size(96, 83)
        Me.btnSetBannerDL.TabIndex = 9
        Me.btnSetBannerDL.Text = "Change Banner (Download)"
        Me.btnSetBannerDL.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSetBannerDL.UseVisualStyleBackColor = True
        '
        'btnRemoveBanner
        '
        Me.btnRemoveBanner.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnRemoveBanner.Image = CType(resources.GetObject("btnRemoveBanner.Image"), System.Drawing.Image)
        Me.btnRemoveBanner.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnRemoveBanner.Location = New System.Drawing.Point(810, 373)
        Me.btnRemoveBanner.Name = "btnRemoveBanner"
        Me.btnRemoveBanner.Size = New System.Drawing.Size(96, 83)
        Me.btnRemoveBanner.TabIndex = 10
        Me.btnRemoveBanner.Text = "Remove Banner"
        Me.btnRemoveBanner.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnRemoveBanner.UseVisualStyleBackColor = True
        '
        'lblBannerSize
        '
        Me.lblBannerSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBannerSize.Location = New System.Drawing.Point(8, 8)
        Me.lblBannerSize.Name = "lblBannerSize"
        Me.lblBannerSize.Size = New System.Drawing.Size(105, 23)
        Me.lblBannerSize.TabIndex = 5
        Me.lblBannerSize.Text = "Size: (XXXXxXXXX)"
        Me.lblBannerSize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblBannerSize.Visible = False
        '
        'btnSetBannerScrape
        '
        Me.btnSetBannerScrape.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnSetBannerScrape.Image = CType(resources.GetObject("btnSetBannerScrape.Image"), System.Drawing.Image)
        Me.btnSetBannerScrape.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSetBannerScrape.Location = New System.Drawing.Point(810, 95)
        Me.btnSetBannerScrape.Name = "btnSetBannerScrape"
        Me.btnSetBannerScrape.Size = New System.Drawing.Size(96, 83)
        Me.btnSetBannerScrape.TabIndex = 8
        Me.btnSetBannerScrape.Text = "Change Banner (Scrape)"
        Me.btnSetBannerScrape.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSetBannerScrape.UseVisualStyleBackColor = True
        '
        'btnSetBannerLocal
        '
        Me.btnSetBannerLocal.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnSetBannerLocal.Image = CType(resources.GetObject("btnSetBannerLocal.Image"), System.Drawing.Image)
        Me.btnSetBannerLocal.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSetBannerLocal.Location = New System.Drawing.Point(810, 6)
        Me.btnSetBannerLocal.Name = "btnSetBannerLocal"
        Me.btnSetBannerLocal.Size = New System.Drawing.Size(96, 83)
        Me.btnSetBannerLocal.TabIndex = 7
        Me.btnSetBannerLocal.Text = "Change Banner (Local Browse)"
        Me.btnSetBannerLocal.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSetBannerLocal.UseVisualStyleBackColor = True
        '
        'pbBanner
        '
        Me.pbBanner.BackColor = System.Drawing.Color.DimGray
        Me.pbBanner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbBanner.Location = New System.Drawing.Point(6, 6)
        Me.pbBanner.Name = "pbBanner"
        Me.pbBanner.Size = New System.Drawing.Size(800, 450)
        Me.pbBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbBanner.TabIndex = 6
        Me.pbBanner.TabStop = False
        '
        'tpLandscape
        '
        Me.tpLandscape.Controls.Add(Me.btnSetLandscapeDL)
        Me.tpLandscape.Controls.Add(Me.btnRemoveLandscape)
        Me.tpLandscape.Controls.Add(Me.lblLandscapeSize)
        Me.tpLandscape.Controls.Add(Me.btnSetLandscapeScrape)
        Me.tpLandscape.Controls.Add(Me.btnSetLandscapeLocal)
        Me.tpLandscape.Controls.Add(Me.pbLandscape)
        Me.tpLandscape.Location = New System.Drawing.Point(4, 22)
        Me.tpLandscape.Name = "tpLandscape"
        Me.tpLandscape.Size = New System.Drawing.Size(996, 491)
        Me.tpLandscape.TabIndex = 9
        Me.tpLandscape.Text = "Landscape"
        Me.tpLandscape.UseVisualStyleBackColor = True
        '
        'btnSetLandscapeDL
        '
        Me.btnSetLandscapeDL.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnSetLandscapeDL.Image = CType(resources.GetObject("btnSetLandscapeDL.Image"), System.Drawing.Image)
        Me.btnSetLandscapeDL.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSetLandscapeDL.Location = New System.Drawing.Point(810, 184)
        Me.btnSetLandscapeDL.Name = "btnSetLandscapeDL"
        Me.btnSetLandscapeDL.Size = New System.Drawing.Size(96, 83)
        Me.btnSetLandscapeDL.TabIndex = 9
        Me.btnSetLandscapeDL.Text = "Change Landscape (Download)"
        Me.btnSetLandscapeDL.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSetLandscapeDL.UseVisualStyleBackColor = True
        '
        'btnRemoveLandscape
        '
        Me.btnRemoveLandscape.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnRemoveLandscape.Image = CType(resources.GetObject("btnRemoveLandscape.Image"), System.Drawing.Image)
        Me.btnRemoveLandscape.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnRemoveLandscape.Location = New System.Drawing.Point(810, 373)
        Me.btnRemoveLandscape.Name = "btnRemoveLandscape"
        Me.btnRemoveLandscape.Size = New System.Drawing.Size(96, 83)
        Me.btnRemoveLandscape.TabIndex = 10
        Me.btnRemoveLandscape.Text = "Remove Landscape"
        Me.btnRemoveLandscape.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnRemoveLandscape.UseVisualStyleBackColor = True
        '
        'lblLandscapeSize
        '
        Me.lblLandscapeSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblLandscapeSize.Location = New System.Drawing.Point(8, 8)
        Me.lblLandscapeSize.Name = "lblLandscapeSize"
        Me.lblLandscapeSize.Size = New System.Drawing.Size(105, 23)
        Me.lblLandscapeSize.TabIndex = 5
        Me.lblLandscapeSize.Text = "Size: (XXXXxXXXX)"
        Me.lblLandscapeSize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblLandscapeSize.Visible = False
        '
        'btnSetLandscapeScrape
        '
        Me.btnSetLandscapeScrape.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnSetLandscapeScrape.Image = CType(resources.GetObject("btnSetLandscapeScrape.Image"), System.Drawing.Image)
        Me.btnSetLandscapeScrape.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSetLandscapeScrape.Location = New System.Drawing.Point(810, 95)
        Me.btnSetLandscapeScrape.Name = "btnSetLandscapeScrape"
        Me.btnSetLandscapeScrape.Size = New System.Drawing.Size(96, 83)
        Me.btnSetLandscapeScrape.TabIndex = 8
        Me.btnSetLandscapeScrape.Text = "Change Landscape (Scrape)"
        Me.btnSetLandscapeScrape.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSetLandscapeScrape.UseVisualStyleBackColor = True
        '
        'btnSetLandscapeLocal
        '
        Me.btnSetLandscapeLocal.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnSetLandscapeLocal.Image = CType(resources.GetObject("btnSetLandscapeLocal.Image"), System.Drawing.Image)
        Me.btnSetLandscapeLocal.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSetLandscapeLocal.Location = New System.Drawing.Point(810, 6)
        Me.btnSetLandscapeLocal.Name = "btnSetLandscapeLocal"
        Me.btnSetLandscapeLocal.Size = New System.Drawing.Size(96, 83)
        Me.btnSetLandscapeLocal.TabIndex = 7
        Me.btnSetLandscapeLocal.Text = "Change Landscape (Local Browse)"
        Me.btnSetLandscapeLocal.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSetLandscapeLocal.UseVisualStyleBackColor = True
        '
        'pbLandscape
        '
        Me.pbLandscape.BackColor = System.Drawing.Color.DimGray
        Me.pbLandscape.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbLandscape.Location = New System.Drawing.Point(6, 6)
        Me.pbLandscape.Name = "pbLandscape"
        Me.pbLandscape.Size = New System.Drawing.Size(800, 450)
        Me.pbLandscape.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbLandscape.TabIndex = 6
        Me.pbLandscape.TabStop = False
        '
        'tpClearArt
        '
        Me.tpClearArt.Controls.Add(Me.btnSetClearArtDL)
        Me.tpClearArt.Controls.Add(Me.btnRemoveClearArt)
        Me.tpClearArt.Controls.Add(Me.lblClearArtSize)
        Me.tpClearArt.Controls.Add(Me.btnSetClearArtScrape)
        Me.tpClearArt.Controls.Add(Me.btnSetClearArtLocal)
        Me.tpClearArt.Controls.Add(Me.pbClearArt)
        Me.tpClearArt.Location = New System.Drawing.Point(4, 22)
        Me.tpClearArt.Name = "tpClearArt"
        Me.tpClearArt.Size = New System.Drawing.Size(996, 491)
        Me.tpClearArt.TabIndex = 11
        Me.tpClearArt.Text = "ClearArt"
        Me.tpClearArt.UseVisualStyleBackColor = True
        '
        'btnSetClearArtDL
        '
        Me.btnSetClearArtDL.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnSetClearArtDL.Image = CType(resources.GetObject("btnSetClearArtDL.Image"), System.Drawing.Image)
        Me.btnSetClearArtDL.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSetClearArtDL.Location = New System.Drawing.Point(810, 184)
        Me.btnSetClearArtDL.Name = "btnSetClearArtDL"
        Me.btnSetClearArtDL.Size = New System.Drawing.Size(96, 83)
        Me.btnSetClearArtDL.TabIndex = 9
        Me.btnSetClearArtDL.Text = "Change ClearArt (Download)"
        Me.btnSetClearArtDL.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSetClearArtDL.UseVisualStyleBackColor = True
        '
        'btnRemoveClearArt
        '
        Me.btnRemoveClearArt.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnRemoveClearArt.Image = CType(resources.GetObject("btnRemoveClearArt.Image"), System.Drawing.Image)
        Me.btnRemoveClearArt.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnRemoveClearArt.Location = New System.Drawing.Point(810, 373)
        Me.btnRemoveClearArt.Name = "btnRemoveClearArt"
        Me.btnRemoveClearArt.Size = New System.Drawing.Size(96, 83)
        Me.btnRemoveClearArt.TabIndex = 10
        Me.btnRemoveClearArt.Text = "Remove ClearArt"
        Me.btnRemoveClearArt.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnRemoveClearArt.UseVisualStyleBackColor = True
        '
        'lblClearArtSize
        '
        Me.lblClearArtSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblClearArtSize.Location = New System.Drawing.Point(8, 8)
        Me.lblClearArtSize.Name = "lblClearArtSize"
        Me.lblClearArtSize.Size = New System.Drawing.Size(105, 23)
        Me.lblClearArtSize.TabIndex = 5
        Me.lblClearArtSize.Text = "Size: (XXXXxXXXX)"
        Me.lblClearArtSize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblClearArtSize.Visible = False
        '
        'btnSetClearArtScrape
        '
        Me.btnSetClearArtScrape.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnSetClearArtScrape.Image = CType(resources.GetObject("btnSetClearArtScrape.Image"), System.Drawing.Image)
        Me.btnSetClearArtScrape.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSetClearArtScrape.Location = New System.Drawing.Point(810, 95)
        Me.btnSetClearArtScrape.Name = "btnSetClearArtScrape"
        Me.btnSetClearArtScrape.Size = New System.Drawing.Size(96, 83)
        Me.btnSetClearArtScrape.TabIndex = 8
        Me.btnSetClearArtScrape.Text = "Change ClearArt (Scrape)"
        Me.btnSetClearArtScrape.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSetClearArtScrape.UseVisualStyleBackColor = True
        '
        'btnSetClearArtLocal
        '
        Me.btnSetClearArtLocal.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnSetClearArtLocal.Image = CType(resources.GetObject("btnSetClearArtLocal.Image"), System.Drawing.Image)
        Me.btnSetClearArtLocal.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSetClearArtLocal.Location = New System.Drawing.Point(810, 6)
        Me.btnSetClearArtLocal.Name = "btnSetClearArtLocal"
        Me.btnSetClearArtLocal.Size = New System.Drawing.Size(96, 83)
        Me.btnSetClearArtLocal.TabIndex = 7
        Me.btnSetClearArtLocal.Text = "Change ClearArt (Local Browse)"
        Me.btnSetClearArtLocal.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSetClearArtLocal.UseVisualStyleBackColor = True
        '
        'pbClearArt
        '
        Me.pbClearArt.BackColor = System.Drawing.Color.DimGray
        Me.pbClearArt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbClearArt.Location = New System.Drawing.Point(6, 6)
        Me.pbClearArt.Name = "pbClearArt"
        Me.pbClearArt.Size = New System.Drawing.Size(800, 450)
        Me.pbClearArt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbClearArt.TabIndex = 6
        Me.pbClearArt.TabStop = False
        '
        'tpClearLogo
        '
        Me.tpClearLogo.Controls.Add(Me.btnSetClearLogoDL)
        Me.tpClearLogo.Controls.Add(Me.btnRemoveClearLogo)
        Me.tpClearLogo.Controls.Add(Me.lblClearLogoSize)
        Me.tpClearLogo.Controls.Add(Me.btnSetClearLogoScrape)
        Me.tpClearLogo.Controls.Add(Me.btnSetClearLogoLocal)
        Me.tpClearLogo.Controls.Add(Me.pbClearLogo)
        Me.tpClearLogo.Location = New System.Drawing.Point(4, 22)
        Me.tpClearLogo.Name = "tpClearLogo"
        Me.tpClearLogo.Size = New System.Drawing.Size(996, 491)
        Me.tpClearLogo.TabIndex = 12
        Me.tpClearLogo.Text = "ClearLogo"
        Me.tpClearLogo.UseVisualStyleBackColor = True
        '
        'btnSetClearLogoDL
        '
        Me.btnSetClearLogoDL.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnSetClearLogoDL.Image = CType(resources.GetObject("btnSetClearLogoDL.Image"), System.Drawing.Image)
        Me.btnSetClearLogoDL.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSetClearLogoDL.Location = New System.Drawing.Point(810, 184)
        Me.btnSetClearLogoDL.Name = "btnSetClearLogoDL"
        Me.btnSetClearLogoDL.Size = New System.Drawing.Size(96, 83)
        Me.btnSetClearLogoDL.TabIndex = 9
        Me.btnSetClearLogoDL.Text = "Change ClearLogo (Download)"
        Me.btnSetClearLogoDL.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSetClearLogoDL.UseVisualStyleBackColor = True
        '
        'btnRemoveClearLogo
        '
        Me.btnRemoveClearLogo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnRemoveClearLogo.Image = CType(resources.GetObject("btnRemoveClearLogo.Image"), System.Drawing.Image)
        Me.btnRemoveClearLogo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnRemoveClearLogo.Location = New System.Drawing.Point(810, 373)
        Me.btnRemoveClearLogo.Name = "btnRemoveClearLogo"
        Me.btnRemoveClearLogo.Size = New System.Drawing.Size(96, 83)
        Me.btnRemoveClearLogo.TabIndex = 10
        Me.btnRemoveClearLogo.Text = "Remove ClearLogo"
        Me.btnRemoveClearLogo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnRemoveClearLogo.UseVisualStyleBackColor = True
        '
        'lblClearLogoSize
        '
        Me.lblClearLogoSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblClearLogoSize.Location = New System.Drawing.Point(8, 8)
        Me.lblClearLogoSize.Name = "lblClearLogoSize"
        Me.lblClearLogoSize.Size = New System.Drawing.Size(105, 23)
        Me.lblClearLogoSize.TabIndex = 5
        Me.lblClearLogoSize.Text = "Size: (XXXXxXXXX)"
        Me.lblClearLogoSize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblClearLogoSize.Visible = False
        '
        'btnSetClearLogoScrape
        '
        Me.btnSetClearLogoScrape.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnSetClearLogoScrape.Image = CType(resources.GetObject("btnSetClearLogoScrape.Image"), System.Drawing.Image)
        Me.btnSetClearLogoScrape.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSetClearLogoScrape.Location = New System.Drawing.Point(810, 95)
        Me.btnSetClearLogoScrape.Name = "btnSetClearLogoScrape"
        Me.btnSetClearLogoScrape.Size = New System.Drawing.Size(96, 83)
        Me.btnSetClearLogoScrape.TabIndex = 8
        Me.btnSetClearLogoScrape.Text = "Change ClearLogo (Scrape)"
        Me.btnSetClearLogoScrape.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSetClearLogoScrape.UseVisualStyleBackColor = True
        '
        'btnSetClearLogoLocal
        '
        Me.btnSetClearLogoLocal.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnSetClearLogoLocal.Image = CType(resources.GetObject("btnSetClearLogoLocal.Image"), System.Drawing.Image)
        Me.btnSetClearLogoLocal.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSetClearLogoLocal.Location = New System.Drawing.Point(810, 6)
        Me.btnSetClearLogoLocal.Name = "btnSetClearLogoLocal"
        Me.btnSetClearLogoLocal.Size = New System.Drawing.Size(96, 83)
        Me.btnSetClearLogoLocal.TabIndex = 7
        Me.btnSetClearLogoLocal.Text = "Change ClearLogo (Local Browse)"
        Me.btnSetClearLogoLocal.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSetClearLogoLocal.UseVisualStyleBackColor = True
        '
        'pbClearLogo
        '
        Me.pbClearLogo.BackColor = System.Drawing.Color.DimGray
        Me.pbClearLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbClearLogo.Location = New System.Drawing.Point(6, 6)
        Me.pbClearLogo.Name = "pbClearLogo"
        Me.pbClearLogo.Size = New System.Drawing.Size(800, 450)
        Me.pbClearLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbClearLogo.TabIndex = 6
        Me.pbClearLogo.TabStop = False
        '
        'tpDiscArt
        '
        Me.tpDiscArt.Controls.Add(Me.btnSetDiscArtDL)
        Me.tpDiscArt.Controls.Add(Me.btnRemoveDiscArt)
        Me.tpDiscArt.Controls.Add(Me.lblDiscArtSize)
        Me.tpDiscArt.Controls.Add(Me.btnSetDiscArtScrape)
        Me.tpDiscArt.Controls.Add(Me.btnSetDiscArtLocal)
        Me.tpDiscArt.Controls.Add(Me.pbDiscArt)
        Me.tpDiscArt.Location = New System.Drawing.Point(4, 22)
        Me.tpDiscArt.Name = "tpDiscArt"
        Me.tpDiscArt.Size = New System.Drawing.Size(996, 491)
        Me.tpDiscArt.TabIndex = 10
        Me.tpDiscArt.Text = "DiscArt"
        Me.tpDiscArt.UseVisualStyleBackColor = True
        '
        'btnSetDiscArtDL
        '
        Me.btnSetDiscArtDL.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnSetDiscArtDL.Image = CType(resources.GetObject("btnSetDiscArtDL.Image"), System.Drawing.Image)
        Me.btnSetDiscArtDL.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSetDiscArtDL.Location = New System.Drawing.Point(810, 184)
        Me.btnSetDiscArtDL.Name = "btnSetDiscArtDL"
        Me.btnSetDiscArtDL.Size = New System.Drawing.Size(96, 83)
        Me.btnSetDiscArtDL.TabIndex = 9
        Me.btnSetDiscArtDL.Text = "Change DiscArt (Download)"
        Me.btnSetDiscArtDL.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSetDiscArtDL.UseVisualStyleBackColor = True
        '
        'btnRemoveDiscArt
        '
        Me.btnRemoveDiscArt.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnRemoveDiscArt.Image = CType(resources.GetObject("btnRemoveDiscArt.Image"), System.Drawing.Image)
        Me.btnRemoveDiscArt.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnRemoveDiscArt.Location = New System.Drawing.Point(810, 373)
        Me.btnRemoveDiscArt.Name = "btnRemoveDiscArt"
        Me.btnRemoveDiscArt.Size = New System.Drawing.Size(96, 83)
        Me.btnRemoveDiscArt.TabIndex = 10
        Me.btnRemoveDiscArt.Text = "Remove DiscArt"
        Me.btnRemoveDiscArt.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnRemoveDiscArt.UseVisualStyleBackColor = True
        '
        'lblDiscArtSize
        '
        Me.lblDiscArtSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDiscArtSize.Location = New System.Drawing.Point(8, 8)
        Me.lblDiscArtSize.Name = "lblDiscArtSize"
        Me.lblDiscArtSize.Size = New System.Drawing.Size(105, 23)
        Me.lblDiscArtSize.TabIndex = 5
        Me.lblDiscArtSize.Text = "Size: (XXXXxXXXX)"
        Me.lblDiscArtSize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblDiscArtSize.Visible = False
        '
        'btnSetDiscArtScrape
        '
        Me.btnSetDiscArtScrape.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnSetDiscArtScrape.Image = CType(resources.GetObject("btnSetDiscArtScrape.Image"), System.Drawing.Image)
        Me.btnSetDiscArtScrape.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSetDiscArtScrape.Location = New System.Drawing.Point(810, 95)
        Me.btnSetDiscArtScrape.Name = "btnSetDiscArtScrape"
        Me.btnSetDiscArtScrape.Size = New System.Drawing.Size(96, 83)
        Me.btnSetDiscArtScrape.TabIndex = 8
        Me.btnSetDiscArtScrape.Text = "Change DiscArt (Scrape)"
        Me.btnSetDiscArtScrape.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSetDiscArtScrape.UseVisualStyleBackColor = True
        '
        'btnSetDiscArtLocal
        '
        Me.btnSetDiscArtLocal.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnSetDiscArtLocal.Image = CType(resources.GetObject("btnSetDiscArtLocal.Image"), System.Drawing.Image)
        Me.btnSetDiscArtLocal.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSetDiscArtLocal.Location = New System.Drawing.Point(810, 6)
        Me.btnSetDiscArtLocal.Name = "btnSetDiscArtLocal"
        Me.btnSetDiscArtLocal.Size = New System.Drawing.Size(96, 83)
        Me.btnSetDiscArtLocal.TabIndex = 7
        Me.btnSetDiscArtLocal.Text = "Change DiscArt (Local Browse)"
        Me.btnSetDiscArtLocal.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSetDiscArtLocal.UseVisualStyleBackColor = True
        '
        'pbDiscArt
        '
        Me.pbDiscArt.BackColor = System.Drawing.Color.DimGray
        Me.pbDiscArt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbDiscArt.Location = New System.Drawing.Point(6, 6)
        Me.pbDiscArt.Name = "pbDiscArt"
        Me.pbDiscArt.Size = New System.Drawing.Size(800, 450)
        Me.pbDiscArt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbDiscArt.TabIndex = 6
        Me.pbDiscArt.TabStop = False
        '
        'tpFanart
        '
        Me.tpFanart.Controls.Add(Me.btnSetFanartDL)
        Me.tpFanart.Controls.Add(Me.btnRemoveFanart)
        Me.tpFanart.Controls.Add(Me.lblFanartSize)
        Me.tpFanart.Controls.Add(Me.btnSetFanartScrape)
        Me.tpFanart.Controls.Add(Me.btnSetFanartLocal)
        Me.tpFanart.Controls.Add(Me.pbFanart)
        Me.tpFanart.Location = New System.Drawing.Point(4, 22)
        Me.tpFanart.Name = "tpFanart"
        Me.tpFanart.Size = New System.Drawing.Size(996, 491)
        Me.tpFanart.TabIndex = 2
        Me.tpFanart.Text = "Fanart"
        Me.tpFanart.UseVisualStyleBackColor = True
        '
        'btnSetFanartDL
        '
        Me.btnSetFanartDL.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnSetFanartDL.Image = CType(resources.GetObject("btnSetFanartDL.Image"), System.Drawing.Image)
        Me.btnSetFanartDL.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSetFanartDL.Location = New System.Drawing.Point(810, 184)
        Me.btnSetFanartDL.Name = "btnSetFanartDL"
        Me.btnSetFanartDL.Size = New System.Drawing.Size(96, 83)
        Me.btnSetFanartDL.TabIndex = 3
        Me.btnSetFanartDL.Text = "Change Fanart (Download)"
        Me.btnSetFanartDL.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSetFanartDL.UseVisualStyleBackColor = True
        '
        'btnRemoveFanart
        '
        Me.btnRemoveFanart.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnRemoveFanart.Image = CType(resources.GetObject("btnRemoveFanart.Image"), System.Drawing.Image)
        Me.btnRemoveFanart.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnRemoveFanart.Location = New System.Drawing.Point(810, 373)
        Me.btnRemoveFanart.Name = "btnRemoveFanart"
        Me.btnRemoveFanart.Size = New System.Drawing.Size(96, 83)
        Me.btnRemoveFanart.TabIndex = 4
        Me.btnRemoveFanart.Text = "Remove Fanart"
        Me.btnRemoveFanart.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnRemoveFanart.UseVisualStyleBackColor = True
        '
        'lblFanartSize
        '
        Me.lblFanartSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFanartSize.Location = New System.Drawing.Point(8, 8)
        Me.lblFanartSize.Name = "lblFanartSize"
        Me.lblFanartSize.Size = New System.Drawing.Size(105, 23)
        Me.lblFanartSize.TabIndex = 0
        Me.lblFanartSize.Text = "Size: (XXXXxXXXX)"
        Me.lblFanartSize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblFanartSize.Visible = False
        '
        'btnSetFanartScrape
        '
        Me.btnSetFanartScrape.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnSetFanartScrape.Image = CType(resources.GetObject("btnSetFanartScrape.Image"), System.Drawing.Image)
        Me.btnSetFanartScrape.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSetFanartScrape.Location = New System.Drawing.Point(810, 95)
        Me.btnSetFanartScrape.Name = "btnSetFanartScrape"
        Me.btnSetFanartScrape.Size = New System.Drawing.Size(96, 83)
        Me.btnSetFanartScrape.TabIndex = 2
        Me.btnSetFanartScrape.Text = "Change Fanart (Scrape)"
        Me.btnSetFanartScrape.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSetFanartScrape.UseVisualStyleBackColor = True
        '
        'btnSetFanartLocal
        '
        Me.btnSetFanartLocal.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnSetFanartLocal.Image = CType(resources.GetObject("btnSetFanartLocal.Image"), System.Drawing.Image)
        Me.btnSetFanartLocal.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSetFanartLocal.Location = New System.Drawing.Point(810, 6)
        Me.btnSetFanartLocal.Name = "btnSetFanartLocal"
        Me.btnSetFanartLocal.Size = New System.Drawing.Size(96, 83)
        Me.btnSetFanartLocal.TabIndex = 1
        Me.btnSetFanartLocal.Text = "Change Fanart (Local Browse)"
        Me.btnSetFanartLocal.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSetFanartLocal.UseVisualStyleBackColor = True
        '
        'pbFanart
        '
        Me.pbFanart.BackColor = System.Drawing.Color.DimGray
        Me.pbFanart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbFanart.Location = New System.Drawing.Point(6, 6)
        Me.pbFanart.Name = "pbFanart"
        Me.pbFanart.Size = New System.Drawing.Size(800, 450)
        Me.pbFanart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbFanart.TabIndex = 1
        Me.pbFanart.TabStop = False
        '
        'tpEFanarts
        '
        Me.tpEFanarts.Controls.Add(Me.lblEFanartsSize)
        Me.tpEFanarts.Controls.Add(Me.pnlEFanartsBG)
        Me.tpEFanarts.Controls.Add(Me.pnlEFanartsSetAsFanart)
        Me.tpEFanarts.Controls.Add(Me.btnEFanartsRefresh)
        Me.tpEFanarts.Controls.Add(Me.btnEFanartsRemove)
        Me.tpEFanarts.Controls.Add(Me.pnlMovieEFanartsQueue)
        Me.tpEFanarts.Controls.Add(Me.pbEFanarts)
        Me.tpEFanarts.Location = New System.Drawing.Point(4, 22)
        Me.tpEFanarts.Name = "tpEFanarts"
        Me.tpEFanarts.Padding = New System.Windows.Forms.Padding(3)
        Me.tpEFanarts.Size = New System.Drawing.Size(996, 491)
        Me.tpEFanarts.TabIndex = 6
        Me.tpEFanarts.Text = "Extrafanarts"
        Me.tpEFanarts.UseVisualStyleBackColor = True
        '
        'lblEFanartsSize
        '
        Me.lblEFanartsSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEFanartsSize.Location = New System.Drawing.Point(178, 10)
        Me.lblEFanartsSize.Name = "lblEFanartsSize"
        Me.lblEFanartsSize.Size = New System.Drawing.Size(105, 23)
        Me.lblEFanartsSize.TabIndex = 16
        Me.lblEFanartsSize.Text = "Size: (XXXXxXXXX)"
        Me.lblEFanartsSize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblEFanartsSize.Visible = False
        '
        'pnlEFanartsBG
        '
        Me.pnlEFanartsBG.AutoScroll = True
        Me.pnlEFanartsBG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlEFanartsBG.Location = New System.Drawing.Point(5, 8)
        Me.pnlEFanartsBG.Name = "pnlEFanartsBG"
        Me.pnlEFanartsBG.Size = New System.Drawing.Size(165, 408)
        Me.pnlEFanartsBG.TabIndex = 15
        '
        'pnlEFanartsSetAsFanart
        '
        Me.pnlEFanartsSetAsFanart.BackColor = System.Drawing.Color.LightGray
        Me.pnlEFanartsSetAsFanart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlEFanartsSetAsFanart.Controls.Add(Me.btnEFanartsSetAsFanart)
        Me.pnlEFanartsSetAsFanart.Location = New System.Drawing.Point(718, 403)
        Me.pnlEFanartsSetAsFanart.Name = "pnlEFanartsSetAsFanart"
        Me.pnlEFanartsSetAsFanart.Size = New System.Drawing.Size(109, 39)
        Me.pnlEFanartsSetAsFanart.TabIndex = 14
        '
        'btnEFanartsSetAsFanart
        '
        Me.btnEFanartsSetAsFanart.Enabled = False
        Me.btnEFanartsSetAsFanart.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnEFanartsSetAsFanart.Image = CType(resources.GetObject("btnEFanartsSetAsFanart.Image"), System.Drawing.Image)
        Me.btnEFanartsSetAsFanart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEFanartsSetAsFanart.Location = New System.Drawing.Point(2, 3)
        Me.btnEFanartsSetAsFanart.Name = "btnEFanartsSetAsFanart"
        Me.btnEFanartsSetAsFanart.Size = New System.Drawing.Size(103, 32)
        Me.btnEFanartsSetAsFanart.TabIndex = 0
        Me.btnEFanartsSetAsFanart.Text = "Set As Fanart"
        Me.btnEFanartsSetAsFanart.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEFanartsSetAsFanart.UseVisualStyleBackColor = True
        '
        'btnEFanartsRefresh
        '
        Me.btnEFanartsRefresh.Image = CType(resources.GetObject("btnEFanartsRefresh.Image"), System.Drawing.Image)
        Me.btnEFanartsRefresh.Location = New System.Drawing.Point(87, 422)
        Me.btnEFanartsRefresh.Name = "btnEFanartsRefresh"
        Me.btnEFanartsRefresh.Size = New System.Drawing.Size(23, 23)
        Me.btnEFanartsRefresh.TabIndex = 12
        Me.btnEFanartsRefresh.UseVisualStyleBackColor = True
        '
        'btnEFanartsRemove
        '
        Me.btnEFanartsRemove.Image = CType(resources.GetObject("btnEFanartsRemove.Image"), System.Drawing.Image)
        Me.btnEFanartsRemove.Location = New System.Drawing.Point(147, 422)
        Me.btnEFanartsRemove.Name = "btnEFanartsRemove"
        Me.btnEFanartsRemove.Size = New System.Drawing.Size(23, 23)
        Me.btnEFanartsRemove.TabIndex = 13
        Me.btnEFanartsRemove.UseVisualStyleBackColor = True
        '
        'pnlMovieEFanartsQueue
        '
        Me.pnlMovieEFanartsQueue.BackColor = System.Drawing.Color.LightGray
        Me.pnlMovieEFanartsQueue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlMovieEFanartsQueue.Controls.Add(Me.lbMovieEFanartsQueue)
        Me.pnlMovieEFanartsQueue.Controls.Add(Me.btnMovieEFanartsTransfer)
        Me.pnlMovieEFanartsQueue.Location = New System.Drawing.Point(626, 11)
        Me.pnlMovieEFanartsQueue.Name = "pnlMovieEFanartsQueue"
        Me.pnlMovieEFanartsQueue.Size = New System.Drawing.Size(201, 69)
        Me.pnlMovieEFanartsQueue.TabIndex = 8
        Me.pnlMovieEFanartsQueue.Visible = False
        '
        'lbMovieEFanartsQueue
        '
        Me.lbMovieEFanartsQueue.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lbMovieEFanartsQueue.Location = New System.Drawing.Point(3, 3)
        Me.lbMovieEFanartsQueue.Name = "lbMovieEFanartsQueue"
        Me.lbMovieEFanartsQueue.Size = New System.Drawing.Size(193, 26)
        Me.lbMovieEFanartsQueue.TabIndex = 0
        Me.lbMovieEFanartsQueue.Text = "You have extrafanarts queued to be transferred to the movie directory."
        Me.lbMovieEFanartsQueue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnMovieEFanartsTransfer
        '
        Me.btnMovieEFanartsTransfer.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnMovieEFanartsTransfer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMovieEFanartsTransfer.Location = New System.Drawing.Point(53, 32)
        Me.btnMovieEFanartsTransfer.Name = "btnMovieEFanartsTransfer"
        Me.btnMovieEFanartsTransfer.Size = New System.Drawing.Size(103, 32)
        Me.btnMovieEFanartsTransfer.TabIndex = 1
        Me.btnMovieEFanartsTransfer.Text = "Transfer Now"
        Me.btnMovieEFanartsTransfer.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnMovieEFanartsTransfer.UseVisualStyleBackColor = True
        '
        'pbEFanarts
        '
        Me.pbEFanarts.BackColor = System.Drawing.Color.DimGray
        Me.pbEFanarts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbEFanarts.Location = New System.Drawing.Point(176, 8)
        Me.pbEFanarts.Name = "pbEFanarts"
        Me.pbEFanarts.Size = New System.Drawing.Size(728, 437)
        Me.pbEFanarts.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbEFanarts.TabIndex = 10
        Me.pbEFanarts.TabStop = False
        '
        'tpEThumbs
        '
        Me.tpEThumbs.Controls.Add(Me.lblEThumbsSize)
        Me.tpEThumbs.Controls.Add(Me.pnlEThumbsBG)
        Me.tpEThumbs.Controls.Add(Me.pnlMovieETQueue)
        Me.tpEThumbs.Controls.Add(Me.pnlEThumbsSetAsFanart)
        Me.tpEThumbs.Controls.Add(Me.btnEThumbsRefresh)
        Me.tpEThumbs.Controls.Add(Me.btnEThumbsRemove)
        Me.tpEThumbs.Controls.Add(Me.btnEThumbsDown)
        Me.tpEThumbs.Controls.Add(Me.btnEThumbsUp)
        Me.tpEThumbs.Controls.Add(Me.pbEThumbs)
        Me.tpEThumbs.Location = New System.Drawing.Point(4, 22)
        Me.tpEThumbs.Name = "tpEThumbs"
        Me.tpEThumbs.Size = New System.Drawing.Size(996, 491)
        Me.tpEThumbs.TabIndex = 4
        Me.tpEThumbs.Text = "Extrathumbs"
        Me.tpEThumbs.UseVisualStyleBackColor = True
        '
        'lblEThumbsSize
        '
        Me.lblEThumbsSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEThumbsSize.Location = New System.Drawing.Point(178, 10)
        Me.lblEThumbsSize.Name = "lblEThumbsSize"
        Me.lblEThumbsSize.Size = New System.Drawing.Size(105, 23)
        Me.lblEThumbsSize.TabIndex = 17
        Me.lblEThumbsSize.Text = "Size: (XXXXxXXXX)"
        Me.lblEThumbsSize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblEThumbsSize.Visible = False
        '
        'pnlEThumbsBG
        '
        Me.pnlEThumbsBG.AutoScroll = True
        Me.pnlEThumbsBG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlEThumbsBG.Location = New System.Drawing.Point(5, 8)
        Me.pnlEThumbsBG.Name = "pnlEThumbsBG"
        Me.pnlEThumbsBG.Size = New System.Drawing.Size(165, 408)
        Me.pnlEThumbsBG.TabIndex = 7
        '
        'pnlMovieETQueue
        '
        Me.pnlMovieETQueue.BackColor = System.Drawing.Color.LightGray
        Me.pnlMovieETQueue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlMovieETQueue.Controls.Add(Me.lbMovieEThumbsQueue)
        Me.pnlMovieETQueue.Controls.Add(Me.btnMovieEThumbsTransfer)
        Me.pnlMovieETQueue.Location = New System.Drawing.Point(626, 11)
        Me.pnlMovieETQueue.Name = "pnlMovieETQueue"
        Me.pnlMovieETQueue.Size = New System.Drawing.Size(201, 69)
        Me.pnlMovieETQueue.TabIndex = 1
        Me.pnlMovieETQueue.Visible = False
        '
        'lbMovieEThumbsQueue
        '
        Me.lbMovieEThumbsQueue.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lbMovieEThumbsQueue.Location = New System.Drawing.Point(3, 3)
        Me.lbMovieEThumbsQueue.Name = "lbMovieEThumbsQueue"
        Me.lbMovieEThumbsQueue.Size = New System.Drawing.Size(193, 26)
        Me.lbMovieEThumbsQueue.TabIndex = 0
        Me.lbMovieEThumbsQueue.Text = "You have extrathumbs queued to be transferred to the movie directory."
        Me.lbMovieEThumbsQueue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnMovieEThumbsTransfer
        '
        Me.btnMovieEThumbsTransfer.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnMovieEThumbsTransfer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMovieEThumbsTransfer.Location = New System.Drawing.Point(53, 32)
        Me.btnMovieEThumbsTransfer.Name = "btnMovieEThumbsTransfer"
        Me.btnMovieEThumbsTransfer.Size = New System.Drawing.Size(103, 32)
        Me.btnMovieEThumbsTransfer.TabIndex = 1
        Me.btnMovieEThumbsTransfer.Text = "Transfer Now"
        Me.btnMovieEThumbsTransfer.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnMovieEThumbsTransfer.UseVisualStyleBackColor = True
        '
        'pnlEThumbsSetAsFanart
        '
        Me.pnlEThumbsSetAsFanart.BackColor = System.Drawing.Color.LightGray
        Me.pnlEThumbsSetAsFanart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlEThumbsSetAsFanart.Controls.Add(Me.btnEThumbsSetAsFanart)
        Me.pnlEThumbsSetAsFanart.Location = New System.Drawing.Point(718, 403)
        Me.pnlEThumbsSetAsFanart.Name = "pnlEThumbsSetAsFanart"
        Me.pnlEThumbsSetAsFanart.Size = New System.Drawing.Size(109, 39)
        Me.pnlEThumbsSetAsFanart.TabIndex = 6
        '
        'btnEThumbsSetAsFanart
        '
        Me.btnEThumbsSetAsFanart.Enabled = False
        Me.btnEThumbsSetAsFanart.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnEThumbsSetAsFanart.Image = CType(resources.GetObject("btnEThumbsSetAsFanart.Image"), System.Drawing.Image)
        Me.btnEThumbsSetAsFanart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEThumbsSetAsFanart.Location = New System.Drawing.Point(2, 3)
        Me.btnEThumbsSetAsFanart.Name = "btnEThumbsSetAsFanart"
        Me.btnEThumbsSetAsFanart.Size = New System.Drawing.Size(103, 32)
        Me.btnEThumbsSetAsFanart.TabIndex = 0
        Me.btnEThumbsSetAsFanart.Text = "Set As Fanart"
        Me.btnEThumbsSetAsFanart.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEThumbsSetAsFanart.UseVisualStyleBackColor = True
        '
        'btnEThumbsRefresh
        '
        Me.btnEThumbsRefresh.Image = CType(resources.GetObject("btnEThumbsRefresh.Image"), System.Drawing.Image)
        Me.btnEThumbsRefresh.Location = New System.Drawing.Point(87, 422)
        Me.btnEThumbsRefresh.Name = "btnEThumbsRefresh"
        Me.btnEThumbsRefresh.Size = New System.Drawing.Size(23, 23)
        Me.btnEThumbsRefresh.TabIndex = 4
        Me.btnEThumbsRefresh.UseVisualStyleBackColor = True
        '
        'btnEThumbsRemove
        '
        Me.btnEThumbsRemove.Image = CType(resources.GetObject("btnEThumbsRemove.Image"), System.Drawing.Image)
        Me.btnEThumbsRemove.Location = New System.Drawing.Point(147, 422)
        Me.btnEThumbsRemove.Name = "btnEThumbsRemove"
        Me.btnEThumbsRemove.Size = New System.Drawing.Size(23, 23)
        Me.btnEThumbsRemove.TabIndex = 5
        Me.btnEThumbsRemove.UseVisualStyleBackColor = True
        '
        'btnEThumbsDown
        '
        Me.btnEThumbsDown.Enabled = False
        Me.btnEThumbsDown.Image = CType(resources.GetObject("btnEThumbsDown.Image"), System.Drawing.Image)
        Me.btnEThumbsDown.Location = New System.Drawing.Point(28, 422)
        Me.btnEThumbsDown.Name = "btnEThumbsDown"
        Me.btnEThumbsDown.Size = New System.Drawing.Size(23, 23)
        Me.btnEThumbsDown.TabIndex = 3
        Me.btnEThumbsDown.UseVisualStyleBackColor = True
        Me.btnEThumbsDown.Visible = False
        '
        'btnEThumbsUp
        '
        Me.btnEThumbsUp.Enabled = False
        Me.btnEThumbsUp.Image = CType(resources.GetObject("btnEThumbsUp.Image"), System.Drawing.Image)
        Me.btnEThumbsUp.Location = New System.Drawing.Point(4, 422)
        Me.btnEThumbsUp.Name = "btnEThumbsUp"
        Me.btnEThumbsUp.Size = New System.Drawing.Size(23, 23)
        Me.btnEThumbsUp.TabIndex = 2
        Me.btnEThumbsUp.UseVisualStyleBackColor = True
        Me.btnEThumbsUp.Visible = False
        '
        'pbEThumbs
        '
        Me.pbEThumbs.BackColor = System.Drawing.Color.DimGray
        Me.pbEThumbs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbEThumbs.Location = New System.Drawing.Point(176, 8)
        Me.pbEThumbs.Name = "pbEThumbs"
        Me.pbEThumbs.Size = New System.Drawing.Size(728, 437)
        Me.pbEThumbs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbEThumbs.TabIndex = 2
        Me.pbEThumbs.TabStop = False
        '
        'tpFrameExtraction
        '
        Me.tpFrameExtraction.Controls.Add(Me.pnlFrameExtrator)
        Me.tpFrameExtraction.Location = New System.Drawing.Point(4, 22)
        Me.tpFrameExtraction.Name = "tpFrameExtraction"
        Me.tpFrameExtraction.Padding = New System.Windows.Forms.Padding(3)
        Me.tpFrameExtraction.Size = New System.Drawing.Size(996, 491)
        Me.tpFrameExtraction.TabIndex = 3
        Me.tpFrameExtraction.Text = "Frame Extraction"
        Me.tpFrameExtraction.UseVisualStyleBackColor = True
        '
        'pnlFrameExtrator
        '
        Me.pnlFrameExtrator.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlFrameExtrator.Location = New System.Drawing.Point(3, 3)
        Me.pnlFrameExtrator.Name = "pnlFrameExtrator"
        Me.pnlFrameExtrator.Size = New System.Drawing.Size(990, 485)
        Me.pnlFrameExtrator.TabIndex = 0
        '
        'tpSubtitles
        '
        Me.tpSubtitles.Controls.Add(Me.lblSubtitlesPreview)
        Me.tpSubtitles.Controls.Add(Me.txtSubtitlesPreview)
        Me.tpSubtitles.Controls.Add(Me.lvSubtitles)
        Me.tpSubtitles.Controls.Add(Me.btnRemoveSubtitle)
        Me.tpSubtitles.Controls.Add(Me.btnSetubtitleDL)
        Me.tpSubtitles.Controls.Add(Me.btnSetSubtitleScrape)
        Me.tpSubtitles.Controls.Add(Me.btnSetSubtitleLocal)
        Me.tpSubtitles.Location = New System.Drawing.Point(4, 22)
        Me.tpSubtitles.Name = "tpSubtitles"
        Me.tpSubtitles.Size = New System.Drawing.Size(996, 491)
        Me.tpSubtitles.TabIndex = 15
        Me.tpSubtitles.Text = "Subtitles"
        Me.tpSubtitles.UseVisualStyleBackColor = True
        '
        'lblSubtitlesPreview
        '
        Me.lblSubtitlesPreview.AutoSize = True
        Me.lblSubtitlesPreview.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblSubtitlesPreview.Location = New System.Drawing.Point(10, 295)
        Me.lblSubtitlesPreview.Name = "lblSubtitlesPreview"
        Me.lblSubtitlesPreview.Size = New System.Drawing.Size(51, 13)
        Me.lblSubtitlesPreview.TabIndex = 37
        Me.lblSubtitlesPreview.Text = "Preview:"
        '
        'txtSubtitlesPreview
        '
        Me.txtSubtitlesPreview.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txtSubtitlesPreview.Location = New System.Drawing.Point(6, 311)
        Me.txtSubtitlesPreview.Multiline = True
        Me.txtSubtitlesPreview.Name = "txtSubtitlesPreview"
        Me.txtSubtitlesPreview.ReadOnly = True
        Me.txtSubtitlesPreview.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtSubtitlesPreview.Size = New System.Drawing.Size(800, 145)
        Me.txtSubtitlesPreview.TabIndex = 11
        '
        'lvSubtitles
        '
        Me.lvSubtitles.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvSubtitles.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.lvSubtitles.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lvSubtitles.FullRowSelect = True
        ListViewGroup1.Header = "Local Subtitles"
        ListViewGroup1.Name = "LocalSubtitles"
        Me.lvSubtitles.Groups.AddRange(New System.Windows.Forms.ListViewGroup() {ListViewGroup1})
        Me.lvSubtitles.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        ListViewItem1.Group = ListViewGroup1
        Me.lvSubtitles.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1})
        Me.lvSubtitles.Location = New System.Drawing.Point(6, 6)
        Me.lvSubtitles.MultiSelect = False
        Me.lvSubtitles.Name = "lvSubtitles"
        Me.lvSubtitles.Size = New System.Drawing.Size(800, 261)
        Me.lvSubtitles.TabIndex = 10
        Me.lvSubtitles.UseCompatibleStateImageBehavior = False
        Me.lvSubtitles.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Width = 25
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Width = 550
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Width = 100
        '
        'btnRemoveSubtitle
        '
        Me.btnRemoveSubtitle.Enabled = False
        Me.btnRemoveSubtitle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnRemoveSubtitle.Image = CType(resources.GetObject("btnRemoveSubtitle.Image"), System.Drawing.Image)
        Me.btnRemoveSubtitle.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnRemoveSubtitle.Location = New System.Drawing.Point(810, 373)
        Me.btnRemoveSubtitle.Name = "btnRemoveSubtitle"
        Me.btnRemoveSubtitle.Size = New System.Drawing.Size(96, 83)
        Me.btnRemoveSubtitle.TabIndex = 9
        Me.btnRemoveSubtitle.Text = "Remove Subtitle"
        Me.btnRemoveSubtitle.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnRemoveSubtitle.UseVisualStyleBackColor = True
        '
        'btnSetubtitleDL
        '
        Me.btnSetubtitleDL.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnSetubtitleDL.Image = CType(resources.GetObject("btnSetubtitleDL.Image"), System.Drawing.Image)
        Me.btnSetubtitleDL.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSetubtitleDL.Location = New System.Drawing.Point(810, 184)
        Me.btnSetubtitleDL.Name = "btnSetubtitleDL"
        Me.btnSetubtitleDL.Size = New System.Drawing.Size(96, 83)
        Me.btnSetubtitleDL.TabIndex = 6
        Me.btnSetubtitleDL.Text = "Add Subtitle (Download)"
        Me.btnSetubtitleDL.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSetubtitleDL.UseVisualStyleBackColor = True
        '
        'btnSetSubtitleScrape
        '
        Me.btnSetSubtitleScrape.Enabled = False
        Me.btnSetSubtitleScrape.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnSetSubtitleScrape.Image = CType(resources.GetObject("btnSetSubtitleScrape.Image"), System.Drawing.Image)
        Me.btnSetSubtitleScrape.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSetSubtitleScrape.Location = New System.Drawing.Point(810, 95)
        Me.btnSetSubtitleScrape.Name = "btnSetSubtitleScrape"
        Me.btnSetSubtitleScrape.Size = New System.Drawing.Size(96, 83)
        Me.btnSetSubtitleScrape.TabIndex = 5
        Me.btnSetSubtitleScrape.Text = "Add Subtitle (Scrape)"
        Me.btnSetSubtitleScrape.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSetSubtitleScrape.UseVisualStyleBackColor = True
        '
        'btnSetSubtitleLocal
        '
        Me.btnSetSubtitleLocal.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnSetSubtitleLocal.Image = CType(resources.GetObject("btnSetSubtitleLocal.Image"), System.Drawing.Image)
        Me.btnSetSubtitleLocal.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSetSubtitleLocal.Location = New System.Drawing.Point(810, 6)
        Me.btnSetSubtitleLocal.Name = "btnSetSubtitleLocal"
        Me.btnSetSubtitleLocal.Size = New System.Drawing.Size(96, 83)
        Me.btnSetSubtitleLocal.TabIndex = 4
        Me.btnSetSubtitleLocal.Text = "Add Subtitle (Local Browse)"
        Me.btnSetSubtitleLocal.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSetSubtitleLocal.UseVisualStyleBackColor = True
        '
        'tpTrailer
        '
        Me.tpTrailer.Controls.Add(Me.pnlTrailerPreview)
        Me.tpTrailer.Controls.Add(Me.btnSetTrailerDL)
        Me.tpTrailer.Controls.Add(Me.btnRemoveTrailer)
        Me.tpTrailer.Controls.Add(Me.btnSetTrailerScrape)
        Me.tpTrailer.Controls.Add(Me.btnSetTrailerLocal)
        Me.tpTrailer.Location = New System.Drawing.Point(4, 22)
        Me.tpTrailer.Name = "tpTrailer"
        Me.tpTrailer.Size = New System.Drawing.Size(996, 491)
        Me.tpTrailer.TabIndex = 13
        Me.tpTrailer.Text = "Trailer"
        Me.tpTrailer.UseVisualStyleBackColor = True
        '
        'pnlTrailerPreview
        '
        Me.pnlTrailerPreview.BackColor = System.Drawing.Color.DimGray
        Me.pnlTrailerPreview.Controls.Add(Me.pnlTrailerPreviewNoPlayer)
        Me.pnlTrailerPreview.Location = New System.Drawing.Point(6, 6)
        Me.pnlTrailerPreview.Name = "pnlTrailerPreview"
        Me.pnlTrailerPreview.Size = New System.Drawing.Size(800, 450)
        Me.pnlTrailerPreview.TabIndex = 13
        '
        'pnlTrailerPreviewNoPlayer
        '
        Me.pnlTrailerPreviewNoPlayer.BackColor = System.Drawing.Color.White
        Me.pnlTrailerPreviewNoPlayer.Controls.Add(Me.tblTrailerPreviewNoPlayer)
        Me.pnlTrailerPreviewNoPlayer.Location = New System.Drawing.Point(285, 203)
        Me.pnlTrailerPreviewNoPlayer.Name = "pnlTrailerPreviewNoPlayer"
        Me.pnlTrailerPreviewNoPlayer.Size = New System.Drawing.Size(242, 56)
        Me.pnlTrailerPreviewNoPlayer.TabIndex = 0
        '
        'tblTrailerPreviewNoPlayer
        '
        Me.tblTrailerPreviewNoPlayer.AutoSize = True
        Me.tblTrailerPreviewNoPlayer.ColumnCount = 1
        Me.tblTrailerPreviewNoPlayer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblTrailerPreviewNoPlayer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblTrailerPreviewNoPlayer.Controls.Add(Me.lblTrailerPreviewNoPlayer, 0, 0)
        Me.tblTrailerPreviewNoPlayer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblTrailerPreviewNoPlayer.Location = New System.Drawing.Point(0, 0)
        Me.tblTrailerPreviewNoPlayer.Name = "tblTrailerPreviewNoPlayer"
        Me.tblTrailerPreviewNoPlayer.RowCount = 1
        Me.tblTrailerPreviewNoPlayer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblTrailerPreviewNoPlayer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56.0!))
        Me.tblTrailerPreviewNoPlayer.Size = New System.Drawing.Size(242, 56)
        Me.tblTrailerPreviewNoPlayer.TabIndex = 0
        '
        'lblTrailerPreviewNoPlayer
        '
        Me.lblTrailerPreviewNoPlayer.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTrailerPreviewNoPlayer.AutoSize = True
        Me.lblTrailerPreviewNoPlayer.Location = New System.Drawing.Point(52, 21)
        Me.lblTrailerPreviewNoPlayer.Name = "lblTrailerPreviewNoPlayer"
        Me.lblTrailerPreviewNoPlayer.Size = New System.Drawing.Size(137, 13)
        Me.lblTrailerPreviewNoPlayer.TabIndex = 0
        Me.lblTrailerPreviewNoPlayer.Text = "no Media Player enabled"
        '
        'btnSetTrailerDL
        '
        Me.btnSetTrailerDL.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnSetTrailerDL.Image = CType(resources.GetObject("btnSetTrailerDL.Image"), System.Drawing.Image)
        Me.btnSetTrailerDL.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSetTrailerDL.Location = New System.Drawing.Point(810, 184)
        Me.btnSetTrailerDL.Name = "btnSetTrailerDL"
        Me.btnSetTrailerDL.Size = New System.Drawing.Size(96, 83)
        Me.btnSetTrailerDL.TabIndex = 7
        Me.btnSetTrailerDL.Text = "Change Trailer (Download)"
        Me.btnSetTrailerDL.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSetTrailerDL.UseVisualStyleBackColor = True
        '
        'btnRemoveTrailer
        '
        Me.btnRemoveTrailer.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnRemoveTrailer.Image = CType(resources.GetObject("btnRemoveTrailer.Image"), System.Drawing.Image)
        Me.btnRemoveTrailer.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnRemoveTrailer.Location = New System.Drawing.Point(810, 373)
        Me.btnRemoveTrailer.Name = "btnRemoveTrailer"
        Me.btnRemoveTrailer.Size = New System.Drawing.Size(96, 83)
        Me.btnRemoveTrailer.TabIndex = 8
        Me.btnRemoveTrailer.Text = "Remove Trailer"
        Me.btnRemoveTrailer.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnRemoveTrailer.UseVisualStyleBackColor = True
        '
        'btnSetTrailerScrape
        '
        Me.btnSetTrailerScrape.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnSetTrailerScrape.Image = CType(resources.GetObject("btnSetTrailerScrape.Image"), System.Drawing.Image)
        Me.btnSetTrailerScrape.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSetTrailerScrape.Location = New System.Drawing.Point(810, 95)
        Me.btnSetTrailerScrape.Name = "btnSetTrailerScrape"
        Me.btnSetTrailerScrape.Size = New System.Drawing.Size(96, 83)
        Me.btnSetTrailerScrape.TabIndex = 6
        Me.btnSetTrailerScrape.Text = "Change Trailer (Scrape)"
        Me.btnSetTrailerScrape.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSetTrailerScrape.UseVisualStyleBackColor = True
        '
        'btnSetTrailerLocal
        '
        Me.btnSetTrailerLocal.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnSetTrailerLocal.Image = CType(resources.GetObject("btnSetTrailerLocal.Image"), System.Drawing.Image)
        Me.btnSetTrailerLocal.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSetTrailerLocal.Location = New System.Drawing.Point(810, 6)
        Me.btnSetTrailerLocal.Name = "btnSetTrailerLocal"
        Me.btnSetTrailerLocal.Size = New System.Drawing.Size(96, 83)
        Me.btnSetTrailerLocal.TabIndex = 5
        Me.btnSetTrailerLocal.Text = "Change Trailer (Local Browse)"
        Me.btnSetTrailerLocal.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSetTrailerLocal.UseVisualStyleBackColor = True
        '
        'tpTheme
        '
        Me.tpTheme.Controls.Add(Me.pnlThemePreview)
        Me.tpTheme.Controls.Add(Me.btnSetThemeDL)
        Me.tpTheme.Controls.Add(Me.btnRemoveTheme)
        Me.tpTheme.Controls.Add(Me.btnSetThemeScrape)
        Me.tpTheme.Controls.Add(Me.btnSetThemeLocal)
        Me.tpTheme.Location = New System.Drawing.Point(4, 22)
        Me.tpTheme.Name = "tpTheme"
        Me.tpTheme.Size = New System.Drawing.Size(996, 491)
        Me.tpTheme.TabIndex = 14
        Me.tpTheme.Text = "Theme"
        Me.tpTheme.UseVisualStyleBackColor = True
        '
        'pnlThemePreview
        '
        Me.pnlThemePreview.BackColor = System.Drawing.Color.DimGray
        Me.pnlThemePreview.Controls.Add(Me.pnlThemePreviewNoPlayer)
        Me.pnlThemePreview.Location = New System.Drawing.Point(6, 6)
        Me.pnlThemePreview.Name = "pnlThemePreview"
        Me.pnlThemePreview.Size = New System.Drawing.Size(800, 450)
        Me.pnlThemePreview.TabIndex = 14
        '
        'pnlThemePreviewNoPlayer
        '
        Me.pnlThemePreviewNoPlayer.BackColor = System.Drawing.Color.White
        Me.pnlThemePreviewNoPlayer.Controls.Add(Me.tblThemePreviewNoPlayer)
        Me.pnlThemePreviewNoPlayer.Location = New System.Drawing.Point(285, 203)
        Me.pnlThemePreviewNoPlayer.Name = "pnlThemePreviewNoPlayer"
        Me.pnlThemePreviewNoPlayer.Size = New System.Drawing.Size(242, 56)
        Me.pnlThemePreviewNoPlayer.TabIndex = 0
        '
        'tblThemePreviewNoPlayer
        '
        Me.tblThemePreviewNoPlayer.AutoSize = True
        Me.tblThemePreviewNoPlayer.ColumnCount = 1
        Me.tblThemePreviewNoPlayer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblThemePreviewNoPlayer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblThemePreviewNoPlayer.Controls.Add(Me.lblThemePreviewNoPlayer, 0, 0)
        Me.tblThemePreviewNoPlayer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblThemePreviewNoPlayer.Location = New System.Drawing.Point(0, 0)
        Me.tblThemePreviewNoPlayer.Name = "tblThemePreviewNoPlayer"
        Me.tblThemePreviewNoPlayer.RowCount = 1
        Me.tblThemePreviewNoPlayer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblThemePreviewNoPlayer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56.0!))
        Me.tblThemePreviewNoPlayer.Size = New System.Drawing.Size(242, 56)
        Me.tblThemePreviewNoPlayer.TabIndex = 0
        '
        'lblThemePreviewNoPlayer
        '
        Me.lblThemePreviewNoPlayer.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblThemePreviewNoPlayer.AutoSize = True
        Me.lblThemePreviewNoPlayer.Location = New System.Drawing.Point(52, 21)
        Me.lblThemePreviewNoPlayer.Name = "lblThemePreviewNoPlayer"
        Me.lblThemePreviewNoPlayer.Size = New System.Drawing.Size(137, 13)
        Me.lblThemePreviewNoPlayer.TabIndex = 0
        Me.lblThemePreviewNoPlayer.Text = "no Media Player enabled"
        '
        'btnSetThemeDL
        '
        Me.btnSetThemeDL.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnSetThemeDL.Image = CType(resources.GetObject("btnSetThemeDL.Image"), System.Drawing.Image)
        Me.btnSetThemeDL.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSetThemeDL.Location = New System.Drawing.Point(810, 184)
        Me.btnSetThemeDL.Name = "btnSetThemeDL"
        Me.btnSetThemeDL.Size = New System.Drawing.Size(96, 83)
        Me.btnSetThemeDL.TabIndex = 7
        Me.btnSetThemeDL.Text = "Change Theme (Download)"
        Me.btnSetThemeDL.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSetThemeDL.UseVisualStyleBackColor = True
        '
        'btnRemoveTheme
        '
        Me.btnRemoveTheme.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnRemoveTheme.Image = CType(resources.GetObject("btnRemoveTheme.Image"), System.Drawing.Image)
        Me.btnRemoveTheme.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnRemoveTheme.Location = New System.Drawing.Point(810, 373)
        Me.btnRemoveTheme.Name = "btnRemoveTheme"
        Me.btnRemoveTheme.Size = New System.Drawing.Size(96, 83)
        Me.btnRemoveTheme.TabIndex = 8
        Me.btnRemoveTheme.Text = "Remove Theme"
        Me.btnRemoveTheme.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnRemoveTheme.UseVisualStyleBackColor = True
        '
        'btnSetThemeScrape
        '
        Me.btnSetThemeScrape.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnSetThemeScrape.Image = CType(resources.GetObject("btnSetThemeScrape.Image"), System.Drawing.Image)
        Me.btnSetThemeScrape.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSetThemeScrape.Location = New System.Drawing.Point(810, 95)
        Me.btnSetThemeScrape.Name = "btnSetThemeScrape"
        Me.btnSetThemeScrape.Size = New System.Drawing.Size(96, 83)
        Me.btnSetThemeScrape.TabIndex = 6
        Me.btnSetThemeScrape.Text = "Change Theme (Scrape)"
        Me.btnSetThemeScrape.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSetThemeScrape.UseVisualStyleBackColor = True
        '
        'btnSetThemeLocal
        '
        Me.btnSetThemeLocal.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnSetThemeLocal.Image = CType(resources.GetObject("btnSetThemeLocal.Image"), System.Drawing.Image)
        Me.btnSetThemeLocal.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSetThemeLocal.Location = New System.Drawing.Point(810, 6)
        Me.btnSetThemeLocal.Name = "btnSetThemeLocal"
        Me.btnSetThemeLocal.Size = New System.Drawing.Size(96, 83)
        Me.btnSetThemeLocal.TabIndex = 5
        Me.btnSetThemeLocal.Text = "Change Theme (Local Browse)"
        Me.btnSetThemeLocal.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSetThemeLocal.UseVisualStyleBackColor = True
        '
        'tpMetaData
        '
        Me.tpMetaData.Controls.Add(Me.pnlFileInfo)
        Me.tpMetaData.Location = New System.Drawing.Point(4, 22)
        Me.tpMetaData.Name = "tpMetaData"
        Me.tpMetaData.Padding = New System.Windows.Forms.Padding(3)
        Me.tpMetaData.Size = New System.Drawing.Size(996, 491)
        Me.tpMetaData.TabIndex = 5
        Me.tpMetaData.Text = "Meta Data"
        Me.tpMetaData.UseVisualStyleBackColor = True
        '
        'pnlFileInfo
        '
        Me.pnlFileInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlFileInfo.Location = New System.Drawing.Point(3, 3)
        Me.pnlFileInfo.Name = "pnlFileInfo"
        Me.pnlFileInfo.Size = New System.Drawing.Size(990, 485)
        Me.pnlFileInfo.TabIndex = 0
        '
        'tpMediaStub
        '
        Me.tpMediaStub.Controls.Add(Me.lblMediaStubMessage)
        Me.tpMediaStub.Controls.Add(Me.lblMediaStubTitle)
        Me.tpMediaStub.Controls.Add(Me.txtMediaStubMessage)
        Me.tpMediaStub.Controls.Add(Me.txtMediaStubTitle)
        Me.tpMediaStub.Location = New System.Drawing.Point(4, 22)
        Me.tpMediaStub.Name = "tpMediaStub"
        Me.tpMediaStub.Size = New System.Drawing.Size(996, 491)
        Me.tpMediaStub.TabIndex = 7
        Me.tpMediaStub.Text = "Media Stub"
        Me.tpMediaStub.UseVisualStyleBackColor = True
        '
        'lblMediaStubMessage
        '
        Me.lblMediaStubMessage.AutoSize = True
        Me.lblMediaStubMessage.Location = New System.Drawing.Point(203, 231)
        Me.lblMediaStubMessage.Name = "lblMediaStubMessage"
        Me.lblMediaStubMessage.Size = New System.Drawing.Size(56, 13)
        Me.lblMediaStubMessage.TabIndex = 3
        Me.lblMediaStubMessage.Text = "Message:"
        '
        'lblMediaStubTitle
        '
        Me.lblMediaStubTitle.AutoSize = True
        Me.lblMediaStubTitle.Location = New System.Drawing.Point(203, 170)
        Me.lblMediaStubTitle.Name = "lblMediaStubTitle"
        Me.lblMediaStubTitle.Size = New System.Drawing.Size(32, 13)
        Me.lblMediaStubTitle.TabIndex = 2
        Me.lblMediaStubTitle.Text = "Title:"
        '
        'txtMediaStubMessage
        '
        Me.txtMediaStubMessage.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtMediaStubMessage.Location = New System.Drawing.Point(206, 247)
        Me.txtMediaStubMessage.Name = "txtMediaStubMessage"
        Me.txtMediaStubMessage.Size = New System.Drawing.Size(472, 22)
        Me.txtMediaStubMessage.TabIndex = 1
        '
        'txtMediaStubTitle
        '
        Me.txtMediaStubTitle.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtMediaStubTitle.Location = New System.Drawing.Point(206, 186)
        Me.txtMediaStubTitle.Name = "txtMediaStubTitle"
        Me.txtMediaStubTitle.Size = New System.Drawing.Size(260, 22)
        Me.txtMediaStubTitle.TabIndex = 0
        '
        'chkMark
        '
        Me.chkMark.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chkMark.AutoSize = True
        Me.chkMark.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMark.Location = New System.Drawing.Point(12, 597)
        Me.chkMark.Name = "chkMark"
        Me.chkMark.Size = New System.Drawing.Size(86, 17)
        Me.chkMark.TabIndex = 5
        Me.chkMark.Text = "Mark Movie"
        Me.chkMark.UseVisualStyleBackColor = True
        '
        'btnRescrape
        '
        Me.btnRescrape.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnRescrape.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnRescrape.Image = CType(resources.GetObject("btnRescrape.Image"), System.Drawing.Image)
        Me.btnRescrape.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRescrape.Location = New System.Drawing.Point(403, 593)
        Me.btnRescrape.Name = "btnRescrape"
        Me.btnRescrape.Size = New System.Drawing.Size(98, 23)
        Me.btnRescrape.TabIndex = 7
        Me.btnRescrape.Text = "Re-scrape"
        Me.btnRescrape.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRescrape.UseVisualStyleBackColor = True
        '
        'btnChangeMovie
        '
        Me.btnChangeMovie.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnChangeMovie.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnChangeMovie.Image = CType(resources.GetObject("btnChangeMovie.Image"), System.Drawing.Image)
        Me.btnChangeMovie.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnChangeMovie.Location = New System.Drawing.Point(534, 593)
        Me.btnChangeMovie.Name = "btnChangeMovie"
        Me.btnChangeMovie.Size = New System.Drawing.Size(107, 23)
        Me.btnChangeMovie.TabIndex = 8
        Me.btnChangeMovie.Text = "Change Movie"
        Me.btnChangeMovie.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnChangeMovie.UseVisualStyleBackColor = True
        '
        'tmrDelay
        '
        Me.tmrDelay.Interval = 250
        '
        'chkWatched
        '
        Me.chkWatched.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chkWatched.AutoSize = True
        Me.chkWatched.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkWatched.Location = New System.Drawing.Point(135, 597)
        Me.chkWatched.Name = "chkWatched"
        Me.chkWatched.Size = New System.Drawing.Size(72, 17)
        Me.chkWatched.TabIndex = 6
        Me.chkWatched.Text = "Watched"
        Me.chkWatched.UseVisualStyleBackColor = True
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsFilename})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 619)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(1008, 22)
        Me.StatusStrip.SizingGrip = False
        Me.StatusStrip.TabIndex = 9
        Me.StatusStrip.Text = "StatusStrip1"
        '
        'tsFilename
        '
        Me.tsFilename.Name = "tsFilename"
        Me.tsFilename.Size = New System.Drawing.Size(55, 17)
        Me.tsFilename.Text = "Filename"
        '
        'txtLastPlayed
        '
        Me.txtLastPlayed.BackColor = System.Drawing.SystemColors.Window
        Me.txtLastPlayed.Enabled = False
        Me.txtLastPlayed.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txtLastPlayed.Location = New System.Drawing.Point(215, 592)
        Me.txtLastPlayed.Name = "txtLastPlayed"
        Me.txtLastPlayed.Size = New System.Drawing.Size(118, 22)
        Me.txtLastPlayed.TabIndex = 74
        '
        'dlgEditMovie
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(1008, 641)
        Me.Controls.Add(Me.txtLastPlayed)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.chkWatched)
        Me.Controls.Add(Me.btnChangeMovie)
        Me.Controls.Add(Me.btnRescrape)
        Me.Controls.Add(Me.chkMark)
        Me.Controls.Add(Me.Cancel_Button)
        Me.Controls.Add(Me.OK_Button)
        Me.Controls.Add(Me.pnlTop)
        Me.Controls.Add(Me.tcEdit)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgEditMovie"
        Me.Text = "Edit Movie"
        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()
        CType(Me.pbTopLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tcEdit.ResumeLayout(False)
        Me.tpDetails.ResumeLayout(False)
        Me.tpDetails.PerformLayout()
        CType(Me.pbStar10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbStar9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbStar8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbStar7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbStar6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbStar5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbStar4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbStar3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbStar2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbStar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpPoster.ResumeLayout(False)
        CType(Me.pbPoster, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpBanner.ResumeLayout(False)
        CType(Me.pbBanner, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpLandscape.ResumeLayout(False)
        CType(Me.pbLandscape, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpClearArt.ResumeLayout(False)
        CType(Me.pbClearArt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpClearLogo.ResumeLayout(False)
        CType(Me.pbClearLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpDiscArt.ResumeLayout(False)
        CType(Me.pbDiscArt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpFanart.ResumeLayout(False)
        CType(Me.pbFanart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpEFanarts.ResumeLayout(False)
        Me.pnlEFanartsSetAsFanart.ResumeLayout(False)
        Me.pnlMovieEFanartsQueue.ResumeLayout(False)
        CType(Me.pbEFanarts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpEThumbs.ResumeLayout(False)
        Me.pnlMovieETQueue.ResumeLayout(False)
        Me.pnlEThumbsSetAsFanart.ResumeLayout(False)
        CType(Me.pbEThumbs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpFrameExtraction.ResumeLayout(False)
        Me.tpSubtitles.ResumeLayout(False)
        Me.tpSubtitles.PerformLayout()
        Me.tpTrailer.ResumeLayout(False)
        Me.pnlTrailerPreview.ResumeLayout(False)
        Me.pnlTrailerPreviewNoPlayer.ResumeLayout(False)
        Me.pnlTrailerPreviewNoPlayer.PerformLayout()
        Me.tblTrailerPreviewNoPlayer.ResumeLayout(False)
        Me.tblTrailerPreviewNoPlayer.PerformLayout()
        Me.tpTheme.ResumeLayout(False)
        Me.pnlThemePreview.ResumeLayout(False)
        Me.pnlThemePreviewNoPlayer.ResumeLayout(False)
        Me.pnlThemePreviewNoPlayer.PerformLayout()
        Me.tblThemePreviewNoPlayer.ResumeLayout(False)
        Me.tblThemePreviewNoPlayer.PerformLayout()
        Me.tpMetaData.ResumeLayout(False)
        Me.tpMediaStub.ResumeLayout(False)
        Me.tpMediaStub.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents pnlTop As System.Windows.Forms.Panel
    Friend WithEvents pbTopLogo As System.Windows.Forms.PictureBox
    Friend WithEvents lblTopDetails As System.Windows.Forms.Label
    Friend WithEvents lblTopTitle As System.Windows.Forms.Label
    Friend WithEvents tcEdit As System.Windows.Forms.TabControl
    Friend WithEvents tpDetails As System.Windows.Forms.TabPage
    Friend WithEvents lblMPAADesc As System.Windows.Forms.Label
    Friend WithEvents txtMPAADesc As System.Windows.Forms.TextBox
    Friend WithEvents btnEditActor As System.Windows.Forms.Button
    Friend WithEvents btnAddActor As System.Windows.Forms.Button
    Friend WithEvents btnManual As System.Windows.Forms.Button
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents lblActors As System.Windows.Forms.Label
    Friend WithEvents lvActors As System.Windows.Forms.ListView
    Friend WithEvents colName As System.Windows.Forms.ColumnHeader
    Friend WithEvents colRole As System.Windows.Forms.ColumnHeader
    Friend WithEvents colThumb As System.Windows.Forms.ColumnHeader
    Friend WithEvents lbMPAA As System.Windows.Forms.ListBox
    Friend WithEvents lblGenre As System.Windows.Forms.Label
    Friend WithEvents lblMPAA As System.Windows.Forms.Label
    Friend WithEvents lblDirector As System.Windows.Forms.Label
    Friend WithEvents txtDirector As System.Windows.Forms.TextBox
    Friend WithEvents txtTop250 As System.Windows.Forms.TextBox
    Friend WithEvents lblTop250 As System.Windows.Forms.Label
    Friend WithEvents lblPlot As System.Windows.Forms.Label
    Friend WithEvents txtPlot As System.Windows.Forms.TextBox
    Friend WithEvents lblOutline As System.Windows.Forms.Label
    Friend WithEvents txtOutline As System.Windows.Forms.TextBox
    Friend WithEvents lblTagline As System.Windows.Forms.Label
    Friend WithEvents txtTagline As System.Windows.Forms.TextBox
    Friend WithEvents pbStar5 As System.Windows.Forms.PictureBox
    Friend WithEvents pbStar4 As System.Windows.Forms.PictureBox
    Friend WithEvents pbStar3 As System.Windows.Forms.PictureBox
    Friend WithEvents pbStar2 As System.Windows.Forms.PictureBox
    Friend WithEvents pbStar1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtVotes As System.Windows.Forms.TextBox
    Friend WithEvents lblVotes As System.Windows.Forms.Label
    Friend WithEvents lblRating As System.Windows.Forms.Label
    Friend WithEvents mtxtYear As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblYear As System.Windows.Forms.Label
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents txtTitle As System.Windows.Forms.TextBox
    Friend WithEvents tpPoster As System.Windows.Forms.TabPage
    Friend WithEvents tpFanart As System.Windows.Forms.TabPage
    Friend WithEvents btnSetPosterLocal As System.Windows.Forms.Button
    Friend WithEvents pbPoster As System.Windows.Forms.PictureBox
    Friend WithEvents btnSetFanartLocal As System.Windows.Forms.Button
    Friend WithEvents pbFanart As System.Windows.Forms.PictureBox
    Friend WithEvents ofdLocalFiles As System.Windows.Forms.OpenFileDialog
    Friend WithEvents lblRuntime As System.Windows.Forms.Label
    Friend WithEvents txtRuntime As System.Windows.Forms.TextBox
    Friend WithEvents txtReleaseDate As System.Windows.Forms.TextBox
    Friend WithEvents lblReleaseDate As System.Windows.Forms.Label
    Friend WithEvents lblCredits As System.Windows.Forms.Label
    Friend WithEvents txtCredits As System.Windows.Forms.TextBox
    Friend WithEvents lblCerts As System.Windows.Forms.Label
    Friend WithEvents txtCerts As System.Windows.Forms.TextBox
    Friend WithEvents lblTrailerURL As System.Windows.Forms.Label
    Friend WithEvents txtTrailer As System.Windows.Forms.TextBox
    Friend WithEvents btnSetPosterScrape As System.Windows.Forms.Button
    Friend WithEvents btnSetFanartScrape As System.Windows.Forms.Button
    Friend WithEvents lblPosterSize As System.Windows.Forms.Label
    Friend WithEvents lblFanartSize As System.Windows.Forms.Label
    Friend WithEvents lblStudio As System.Windows.Forms.Label
    Friend WithEvents txtStudio As System.Windows.Forms.TextBox
    Friend WithEvents tpFrameExtraction As System.Windows.Forms.TabPage
    Friend WithEvents chkMark As System.Windows.Forms.CheckBox
    Friend WithEvents tpEThumbs As System.Windows.Forms.TabPage
    Friend WithEvents pbEThumbs As System.Windows.Forms.PictureBox
    Friend WithEvents btnEThumbsDown As System.Windows.Forms.Button
    Friend WithEvents btnEThumbsUp As System.Windows.Forms.Button
    Friend WithEvents btnEThumbsRemove As System.Windows.Forms.Button
    Friend WithEvents btnRescrape As System.Windows.Forms.Button
    Friend WithEvents btnChangeMovie As System.Windows.Forms.Button
    Friend WithEvents btnRemovePoster As System.Windows.Forms.Button
    Friend WithEvents btnRemoveFanart As System.Windows.Forms.Button
    Friend WithEvents btnEThumbsRefresh As System.Windows.Forms.Button
    Friend WithEvents btnStudio As System.Windows.Forms.Button
    Friend WithEvents clbGenre As System.Windows.Forms.CheckedListBox
    Friend WithEvents pnlEThumbsSetAsFanart As System.Windows.Forms.Panel
    Friend WithEvents btnEThumbsSetAsFanart As System.Windows.Forms.Button
    Friend WithEvents btnDLTrailer As System.Windows.Forms.Button
    Friend WithEvents btnPlayTrailer As System.Windows.Forms.Button
    Friend WithEvents pnlMovieETQueue As System.Windows.Forms.Panel
    Friend WithEvents lbMovieEThumbsQueue As System.Windows.Forms.Label
    Friend WithEvents btnMovieEThumbsTransfer As System.Windows.Forms.Button
    Friend WithEvents btnSetPosterDL As System.Windows.Forms.Button
    Friend WithEvents btnSetFanartDL As System.Windows.Forms.Button
    Friend WithEvents tpMetaData As System.Windows.Forms.TabPage
    Friend WithEvents pnlFileInfo As System.Windows.Forms.Panel
    Friend WithEvents lblSortTilte As System.Windows.Forms.Label
    Friend WithEvents txtSortTitle As System.Windows.Forms.TextBox
    Friend WithEvents tmrDelay As System.Windows.Forms.Timer
    Friend WithEvents btnActorDown As System.Windows.Forms.Button
    Friend WithEvents btnActorUp As System.Windows.Forms.Button
    Friend WithEvents pnlFrameExtrator As System.Windows.Forms.Panel
    Friend WithEvents txtVideoSource As System.Windows.Forms.TextBox
    Friend WithEvents lblVideoSource As System.Windows.Forms.Label
    Friend WithEvents lblCountry As System.Windows.Forms.Label
    Friend WithEvents txtCountry As System.Windows.Forms.TextBox
    Friend WithEvents txtOriginalTitle As System.Windows.Forms.TextBox
    Friend WithEvents lblOriginalTitle As System.Windows.Forms.Label
    Friend WithEvents chkWatched As System.Windows.Forms.CheckBox
    Friend WithEvents tpEFanarts As System.Windows.Forms.TabPage
    Friend WithEvents pnlEFanartsSetAsFanart As System.Windows.Forms.Panel
    Friend WithEvents btnEFanartsSetAsFanart As System.Windows.Forms.Button
    Friend WithEvents btnEFanartsRefresh As System.Windows.Forms.Button
    Friend WithEvents btnEFanartsRemove As System.Windows.Forms.Button
    Friend WithEvents pnlMovieEFanartsQueue As System.Windows.Forms.Panel
    Friend WithEvents lbMovieEFanartsQueue As System.Windows.Forms.Label
    Friend WithEvents btnMovieEFanartsTransfer As System.Windows.Forms.Button
    Friend WithEvents pbEFanarts As System.Windows.Forms.PictureBox
    Friend WithEvents pnlEThumbsBG As System.Windows.Forms.Panel
    Friend WithEvents pnlEFanartsBG As System.Windows.Forms.Panel
    Friend WithEvents lblEFanartsSize As System.Windows.Forms.Label
    Friend WithEvents lblEThumbsSize As System.Windows.Forms.Label
    Friend WithEvents tpMediaStub As System.Windows.Forms.TabPage
    Friend WithEvents lblMediaStubMessage As System.Windows.Forms.Label
    Friend WithEvents lblMediaStubTitle As System.Windows.Forms.Label
    Friend WithEvents txtMediaStubMessage As System.Windows.Forms.TextBox
    Friend WithEvents txtMediaStubTitle As System.Windows.Forms.TextBox
    Friend WithEvents tpBanner As System.Windows.Forms.TabPage
    Friend WithEvents btnSetBannerDL As System.Windows.Forms.Button
    Friend WithEvents btnRemoveBanner As System.Windows.Forms.Button
    Friend WithEvents lblBannerSize As System.Windows.Forms.Label
    Friend WithEvents btnSetBannerScrape As System.Windows.Forms.Button
    Friend WithEvents btnSetBannerLocal As System.Windows.Forms.Button
    Friend WithEvents pbBanner As System.Windows.Forms.PictureBox
    Friend WithEvents tpLandscape As System.Windows.Forms.TabPage
    Friend WithEvents btnSetLandscapeDL As System.Windows.Forms.Button
    Friend WithEvents btnRemoveLandscape As System.Windows.Forms.Button
    Friend WithEvents lblLandscapeSize As System.Windows.Forms.Label
    Friend WithEvents btnSetLandscapeScrape As System.Windows.Forms.Button
    Friend WithEvents btnSetLandscapeLocal As System.Windows.Forms.Button
    Friend WithEvents pbLandscape As System.Windows.Forms.PictureBox
    Friend WithEvents tpClearArt As System.Windows.Forms.TabPage
    Friend WithEvents btnSetClearArtDL As System.Windows.Forms.Button
    Friend WithEvents btnRemoveClearArt As System.Windows.Forms.Button
    Friend WithEvents lblClearArtSize As System.Windows.Forms.Label
    Friend WithEvents btnSetClearArtScrape As System.Windows.Forms.Button
    Friend WithEvents btnSetClearArtLocal As System.Windows.Forms.Button
    Friend WithEvents pbClearArt As System.Windows.Forms.PictureBox
    Friend WithEvents tpClearLogo As System.Windows.Forms.TabPage
    Friend WithEvents btnSetClearLogoDL As System.Windows.Forms.Button
    Friend WithEvents btnRemoveClearLogo As System.Windows.Forms.Button
    Friend WithEvents lblClearLogoSize As System.Windows.Forms.Label
    Friend WithEvents btnSetClearLogoScrape As System.Windows.Forms.Button
    Friend WithEvents btnSetClearLogoLocal As System.Windows.Forms.Button
    Friend WithEvents pbClearLogo As System.Windows.Forms.PictureBox
    Friend WithEvents tpDiscArt As System.Windows.Forms.TabPage
    Friend WithEvents btnSetDiscArtDL As System.Windows.Forms.Button
    Friend WithEvents btnRemoveDiscArt As System.Windows.Forms.Button
    Friend WithEvents lblDiscArtSize As System.Windows.Forms.Label
    Friend WithEvents btnSetDiscArtScrape As System.Windows.Forms.Button
    Friend WithEvents btnSetDiscArtLocal As System.Windows.Forms.Button
    Friend WithEvents pbDiscArt As System.Windows.Forms.PictureBox
    Friend WithEvents tpTrailer As System.Windows.Forms.TabPage
    Friend WithEvents tpTheme As System.Windows.Forms.TabPage
    Friend WithEvents btnSetTrailerDL As System.Windows.Forms.Button
    Friend WithEvents btnRemoveTrailer As System.Windows.Forms.Button
    Friend WithEvents btnSetTrailerScrape As System.Windows.Forms.Button
    Friend WithEvents btnSetTrailerLocal As System.Windows.Forms.Button
    Friend WithEvents btnSetThemeDL As System.Windows.Forms.Button
    Friend WithEvents btnRemoveTheme As System.Windows.Forms.Button
    Friend WithEvents btnSetThemeScrape As System.Windows.Forms.Button
    Friend WithEvents btnSetThemeLocal As System.Windows.Forms.Button
    Friend WithEvents pbStar10 As System.Windows.Forms.PictureBox
    Friend WithEvents pbStar9 As System.Windows.Forms.PictureBox
    Friend WithEvents pbStar8 As System.Windows.Forms.PictureBox
    Friend WithEvents pbStar7 As System.Windows.Forms.PictureBox
    Friend WithEvents pbStar6 As System.Windows.Forms.PictureBox
    Friend WithEvents tpSubtitles As System.Windows.Forms.TabPage
    Friend WithEvents btnRemoveSubtitle As System.Windows.Forms.Button
    Friend WithEvents btnSetubtitleDL As System.Windows.Forms.Button
    Friend WithEvents btnSetSubtitleScrape As System.Windows.Forms.Button
    Friend WithEvents btnSetSubtitleLocal As System.Windows.Forms.Button
    Friend WithEvents lvSubtitles As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblSubtitlesPreview As System.Windows.Forms.Label
    Friend WithEvents txtSubtitlesPreview As System.Windows.Forms.TextBox
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents tsFilename As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents txtMPAA As System.Windows.Forms.TextBox
    Friend WithEvents pnlTrailerPreview As System.Windows.Forms.Panel
    Friend WithEvents pnlTrailerPreviewNoPlayer As System.Windows.Forms.Panel
    Friend WithEvents tblTrailerPreviewNoPlayer As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblTrailerPreviewNoPlayer As System.Windows.Forms.Label
    Friend WithEvents pnlThemePreview As System.Windows.Forms.Panel
    Friend WithEvents pnlThemePreviewNoPlayer As System.Windows.Forms.Panel
    Friend WithEvents tblThemePreviewNoPlayer As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblThemePreviewNoPlayer As System.Windows.Forms.Label
    Friend WithEvents colID As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtLastPlayed As System.Windows.Forms.TextBox

End Class
