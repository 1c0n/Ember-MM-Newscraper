﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgSettings
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Catch ex As Exception
        End Try
        Try
            'Finally
            MyBase.Dispose(disposing)
        Catch ex As Exception
        End Try
    End Sub

    Delegate Sub DelegateSub(ByVal b As Boolean)

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgSettings))
        Me.gbGeneralMisc = New System.Windows.Forms.GroupBox()
        Me.gbGeneralDaemon = New System.Windows.Forms.GroupBox()
        Me.lblGeneralDaemonDrive = New System.Windows.Forms.Label()
        Me.cbGeneralDaemonDrive = New System.Windows.Forms.ComboBox()
        Me.btnGeneralDaemonPathBrowse = New System.Windows.Forms.Button()
        Me.txtGeneralDaemonPath = New System.Windows.Forms.TextBox()
        Me.lblGeneralDaemonPath = New System.Windows.Forms.Label()
        Me.chkGeneralImagesGlassOverlay = New System.Windows.Forms.CheckBox()
        Me.chkGeneralHideFanartSmall = New System.Windows.Forms.CheckBox()
        Me.chkGeneralCreationDate = New System.Windows.Forms.CheckBox()
        Me.chkGeneralShowGenresText = New System.Windows.Forms.CheckBox()
        Me.chkGeneralSourceFromFolder = New System.Windows.Forms.CheckBox()
        Me.chkGeneralHideFanart = New System.Windows.Forms.CheckBox()
        Me.chkGeneralInfoPanelAnim = New System.Windows.Forms.CheckBox()
        Me.chkGeneralHidePoster = New System.Windows.Forms.CheckBox()
        Me.chkGeneralShowImgDims = New System.Windows.Forms.CheckBox()
        Me.chkGeneralCheckUpdates = New System.Windows.Forms.CheckBox()
        Me.chkGeneralOverwriteNfo = New System.Windows.Forms.CheckBox()
        Me.lblGeneralOverwriteNfo = New System.Windows.Forms.Label()
        Me.gbGeneralThemes = New System.Windows.Forms.GroupBox()
        Me.cbGeneralTVEpisodeTheme = New System.Windows.Forms.ComboBox()
        Me.lblGeneralTVEpisodeTheme = New System.Windows.Forms.Label()
        Me.cbGeneralTVShowTheme = New System.Windows.Forms.ComboBox()
        Me.lblGeneralTVShowTheme = New System.Windows.Forms.Label()
        Me.cbGeneralMovieTheme = New System.Windows.Forms.ComboBox()
        Me.lblGeneralMovieTheme = New System.Windows.Forms.Label()
        Me.lblGeneralntLang = New System.Windows.Forms.Label()
        Me.cbGeneralLanguage = New System.Windows.Forms.ComboBox()
        Me.gbFileSystemCleanFiles = New System.Windows.Forms.GroupBox()
        Me.tcFileSystemCleaner = New System.Windows.Forms.TabControl()
        Me.tpFileSystemCleanerStandard = New System.Windows.Forms.TabPage()
        Me.chkCleanFolderJPG = New System.Windows.Forms.CheckBox()
        Me.chkCleanExtrathumbs = New System.Windows.Forms.CheckBox()
        Me.chkCleanMovieTBN = New System.Windows.Forms.CheckBox()
        Me.chkCleanMovieNameJPG = New System.Windows.Forms.CheckBox()
        Me.chkCleanMovieTBNb = New System.Windows.Forms.CheckBox()
        Me.chkCleanMovieJPG = New System.Windows.Forms.CheckBox()
        Me.chkCleanFanartJPG = New System.Windows.Forms.CheckBox()
        Me.chkCleanPosterJPG = New System.Windows.Forms.CheckBox()
        Me.chkCleanMovieFanartJPG = New System.Windows.Forms.CheckBox()
        Me.chkCleanPosterTBN = New System.Windows.Forms.CheckBox()
        Me.chkCleanMovieNFO = New System.Windows.Forms.CheckBox()
        Me.chkCleanDotFanartJPG = New System.Windows.Forms.CheckBox()
        Me.chkCleanMovieNFOb = New System.Windows.Forms.CheckBox()
        Me.tpFileSystemCleanerExpert = New System.Windows.Forms.TabPage()
        Me.chkFileSystemCleanerWhitelist = New System.Windows.Forms.CheckBox()
        Me.lblFileSystemCleanerWhitelist = New System.Windows.Forms.Label()
        Me.btnFileSystemCleanerWhitelistRemove = New System.Windows.Forms.Button()
        Me.btnFileSystemCleanerWhitelistAdd = New System.Windows.Forms.Button()
        Me.txtFileSystemCleanerWhitelist = New System.Windows.Forms.TextBox()
        Me.lstFileSystemCleanerWhitelist = New System.Windows.Forms.ListBox()
        Me.lblFileSystemCleanerWarning = New System.Windows.Forms.Label()
        Me.gbMovieGeneralMiscOpts = New System.Windows.Forms.GroupBox()
        Me.chkMovieClickScrape = New System.Windows.Forms.CheckBox()
        Me.chkMovieClickScrapeAsk = New System.Windows.Forms.CheckBox()
        Me.chkMovieGeneralMarkNew = New System.Windows.Forms.CheckBox()
        Me.pnlMovieImages = New System.Windows.Forms.Panel()
        Me.gbMovieActorThumbsOpts = New System.Windows.Forms.GroupBox()
        Me.chkMovieActorThumbsOverwrite = New System.Windows.Forms.CheckBox()
        Me.gbMovieClearArtOpts = New System.Windows.Forms.GroupBox()
        Me.chkMovieClearArtOverwrite = New System.Windows.Forms.CheckBox()
        Me.gbMovieClearLogoOpts = New System.Windows.Forms.GroupBox()
        Me.chkMovieClearLogoOverwrite = New System.Windows.Forms.CheckBox()
        Me.gbMovieDiscArtOpts = New System.Windows.Forms.GroupBox()
        Me.chkMovieDiscArtOverwrite = New System.Windows.Forms.CheckBox()
        Me.gbMovieBannerOpts = New System.Windows.Forms.GroupBox()
        Me.chkMovieBannerPrefOnly = New System.Windows.Forms.CheckBox()
        Me.txtMovieBannerWidth = New System.Windows.Forms.TextBox()
        Me.txtMovieBannerHeight = New System.Windows.Forms.TextBox()
        Me.lblMovieBannerQual = New System.Windows.Forms.Label()
        Me.tbMovieBannerQual = New System.Windows.Forms.TrackBar()
        Me.lblMovieBannerQ = New System.Windows.Forms.Label()
        Me.lblMovieBannerWidth = New System.Windows.Forms.Label()
        Me.lblMovieBannerHeight = New System.Windows.Forms.Label()
        Me.chkMovieBannerResize = New System.Windows.Forms.CheckBox()
        Me.lblMovieBannerType = New System.Windows.Forms.Label()
        Me.cbMovieBannerPrefType = New System.Windows.Forms.ComboBox()
        Me.chkMovieBannerOverwrite = New System.Windows.Forms.CheckBox()
        Me.gbMovieLandscapeOpts = New System.Windows.Forms.GroupBox()
        Me.chkMovieLandscapeOverwrite = New System.Windows.Forms.CheckBox()
        Me.gbMovieEFanartsOpts = New System.Windows.Forms.GroupBox()
        Me.lblMovieEFanartsLimit = New System.Windows.Forms.Label()
        Me.txtMovieEFanartsLimit = New System.Windows.Forms.TextBox()
        Me.chkMovieEFanartsPrefOnly = New System.Windows.Forms.CheckBox()
        Me.txtMovieEFanartsWidth = New System.Windows.Forms.TextBox()
        Me.txtMovieEFanartsHeight = New System.Windows.Forms.TextBox()
        Me.lblMovieEFanartsQual = New System.Windows.Forms.Label()
        Me.tbMovieEFanartsQual = New System.Windows.Forms.TrackBar()
        Me.lblMovieEFanartsQ = New System.Windows.Forms.Label()
        Me.lblMovieEFanartsWidth = New System.Windows.Forms.Label()
        Me.lblMovieEFanartsHeight = New System.Windows.Forms.Label()
        Me.chkMovieEFanartsResize = New System.Windows.Forms.CheckBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.cbMovieEFanartsPrefSize = New System.Windows.Forms.ComboBox()
        Me.chkMovieEFanartsOverwrite = New System.Windows.Forms.CheckBox()
        Me.gbMovieEThumbsOpts = New System.Windows.Forms.GroupBox()
        Me.lblMovieEThumbsLimit = New System.Windows.Forms.Label()
        Me.txtMovieEThumbsLimit = New System.Windows.Forms.TextBox()
        Me.chkMovieEThumbsPrefOnly = New System.Windows.Forms.CheckBox()
        Me.txtMovieEThumbsWidth = New System.Windows.Forms.TextBox()
        Me.txtMovieEThumbsHeight = New System.Windows.Forms.TextBox()
        Me.lblMovieEThumbsQual = New System.Windows.Forms.Label()
        Me.tbMovieEThumbsQual = New System.Windows.Forms.TrackBar()
        Me.lblMovieEThumbsQ = New System.Windows.Forms.Label()
        Me.lblMovieEThumbsWidth = New System.Windows.Forms.Label()
        Me.lblMovieEThumbsHeight = New System.Windows.Forms.Label()
        Me.chkMovieEThumbsResize = New System.Windows.Forms.CheckBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cbMovieEThumbsPrefSize = New System.Windows.Forms.ComboBox()
        Me.chkMovieEThumbsOverwrite = New System.Windows.Forms.CheckBox()
        Me.gbMovieImagesOpts = New System.Windows.Forms.GroupBox()
        Me.chkMovieScraperActorThumbs = New System.Windows.Forms.CheckBox()
        Me.chkMovieNoSaveImagesToNfo = New System.Windows.Forms.CheckBox()
        Me.gbMovieFanartOpts = New System.Windows.Forms.GroupBox()
        Me.txtMovieFanartWidth = New System.Windows.Forms.TextBox()
        Me.txtMovieFanartHeight = New System.Windows.Forms.TextBox()
        Me.chkMovieFanartPrefOnly = New System.Windows.Forms.CheckBox()
        Me.lblMovieFanartQual = New System.Windows.Forms.Label()
        Me.tbMovieFanartQual = New System.Windows.Forms.TrackBar()
        Me.lblMovieFanartQ = New System.Windows.Forms.Label()
        Me.lblMovieFanartWidth = New System.Windows.Forms.Label()
        Me.lblMovieFanartHeight = New System.Windows.Forms.Label()
        Me.chkMovieFanartResize = New System.Windows.Forms.CheckBox()
        Me.cbMovieFanartPrefSize = New System.Windows.Forms.ComboBox()
        Me.lblFanartSize = New System.Windows.Forms.Label()
        Me.chkMovieFanartOverwrite = New System.Windows.Forms.CheckBox()
        Me.gbMoviePosterOpts = New System.Windows.Forms.GroupBox()
        Me.chkMoviePosterPrefOnly = New System.Windows.Forms.CheckBox()
        Me.txtMoviePosterWidth = New System.Windows.Forms.TextBox()
        Me.txtMoviePosterHeight = New System.Windows.Forms.TextBox()
        Me.lblMoviePosterQual = New System.Windows.Forms.Label()
        Me.tbMoviePosterQual = New System.Windows.Forms.TrackBar()
        Me.lblMoviePosterQ = New System.Windows.Forms.Label()
        Me.lblMoviePosterWidth = New System.Windows.Forms.Label()
        Me.lblMoviePosterHeight = New System.Windows.Forms.Label()
        Me.chkMoviePosterResize = New System.Windows.Forms.CheckBox()
        Me.lblMoviePosterSize = New System.Windows.Forms.Label()
        Me.cbMoviePosterPrefSize = New System.Windows.Forms.ComboBox()
        Me.chkMoviePosterOverwrite = New System.Windows.Forms.CheckBox()
        Me.clbMovieGenre = New System.Windows.Forms.CheckedListBox()
        Me.gbMovieGeneralMediaListOpts = New System.Windows.Forms.GroupBox()
        Me.chkMovieWatchedCol = New System.Windows.Forms.CheckBox()
        Me.chkMovieEFanartsCol = New System.Windows.Forms.CheckBox()
        Me.txtMovieLevTolerance = New System.Windows.Forms.TextBox()
        Me.lblMovieLevTolerance = New System.Windows.Forms.Label()
        Me.chkMovieLevTolerance = New System.Windows.Forms.CheckBox()
        Me.gbMovieSortTokensOpts = New System.Windows.Forms.GroupBox()
        Me.btnMovieSortTokenRemove = New System.Windows.Forms.Button()
        Me.btnMovieSortTokenAdd = New System.Windows.Forms.Button()
        Me.txtMovieSortToken = New System.Windows.Forms.TextBox()
        Me.lstMovieSortTokens = New System.Windows.Forms.ListBox()
        Me.chkMovieDisplayYear = New System.Windows.Forms.CheckBox()
        Me.chkMovieEThumbsCol = New System.Windows.Forms.CheckBox()
        Me.chkMovieSubCol = New System.Windows.Forms.CheckBox()
        Me.chkMovieTrailerCol = New System.Windows.Forms.CheckBox()
        Me.chkMovieInfoCol = New System.Windows.Forms.CheckBox()
        Me.chkMovieFanartCol = New System.Windows.Forms.CheckBox()
        Me.chkMoviePosterCol = New System.Windows.Forms.CheckBox()
        Me.lvMovieSources = New System.Windows.Forms.ListView()
        Me.colID = CType(New System.Windows.Forms.ColumnHeader(),System.Windows.Forms.ColumnHeader)
        Me.colName = CType(New System.Windows.Forms.ColumnHeader(),System.Windows.Forms.ColumnHeader)
        Me.colPath = CType(New System.Windows.Forms.ColumnHeader(),System.Windows.Forms.ColumnHeader)
        Me.colRecur = CType(New System.Windows.Forms.ColumnHeader(),System.Windows.Forms.ColumnHeader)
        Me.colFolder = CType(New System.Windows.Forms.ColumnHeader(),System.Windows.Forms.ColumnHeader)
        Me.colSingle = CType(New System.Windows.Forms.ColumnHeader(),System.Windows.Forms.ColumnHeader)
        Me.btnMovieSourceRemove = New System.Windows.Forms.Button()
        Me.btnMovieSourceAdd = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnApply = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.pnlSettingsTop = New System.Windows.Forms.Panel()
        Me.lblSettingsTopDetails = New System.Windows.Forms.Label()
        Me.lblSettingsTopTitle = New System.Windows.Forms.Label()
        Me.pbSettingsTopLogo = New System.Windows.Forms.PictureBox()
        Me.ilSettings = New System.Windows.Forms.ImageList(Me.components)
        Me.tvSettingsList = New System.Windows.Forms.TreeView()
        Me.pnlGeneral = New System.Windows.Forms.Panel()
        Me.gbGeneralInterface = New System.Windows.Forms.GroupBox()
        Me.pnlMovieGeneral = New System.Windows.Forms.Panel()
        Me.gbMovieGenrealIMDBMirrorOpts = New System.Windows.Forms.GroupBox()
        Me.lblMovieIMDBMirror = New System.Windows.Forms.Label()
        Me.txtMovieIMDBURL = New System.Windows.Forms.TextBox()
        Me.gbMovieGeneralGenreFilterOpts = New System.Windows.Forms.GroupBox()
        Me.gbMovieGeneralFiltersOpts = New System.Windows.Forms.GroupBox()
        Me.btnMovieFilterReset = New System.Windows.Forms.Button()
        Me.btnMovieFilterDown = New System.Windows.Forms.Button()
        Me.btnMovieFilterUp = New System.Windows.Forms.Button()
        Me.chkMovieProperCase = New System.Windows.Forms.CheckBox()
        Me.btnMovieFilterRemove = New System.Windows.Forms.Button()
        Me.btnMovieFilterAdd = New System.Windows.Forms.Button()
        Me.txtMovieFilter = New System.Windows.Forms.TextBox()
        Me.lstMovieFilters = New System.Windows.Forms.ListBox()
        Me.gbMovieGeneralMissingItemsOpts = New System.Windows.Forms.GroupBox()
        Me.chkMovieMissingEFanarts = New System.Windows.Forms.CheckBox()
        Me.chkMovieMissingEThumbs = New System.Windows.Forms.CheckBox()
        Me.chkMovieMissingSubs = New System.Windows.Forms.CheckBox()
        Me.chkMovieMissingTrailer = New System.Windows.Forms.CheckBox()
        Me.chkMovieMissingNFO = New System.Windows.Forms.CheckBox()
        Me.chkMovieMissingFanart = New System.Windows.Forms.CheckBox()
        Me.chkMovieMissingPoster = New System.Windows.Forms.CheckBox()
        Me.pnlFileSystem = New System.Windows.Forms.Panel()
        Me.gbFileSystemNoStackExts = New System.Windows.Forms.GroupBox()
        Me.btnFileSystemNoStackExtsRemove = New System.Windows.Forms.Button()
        Me.btnFileSystemNoStackExtsAdd = New System.Windows.Forms.Button()
        Me.txtFileSystemNoStackExts = New System.Windows.Forms.TextBox()
        Me.lstFileSystemNoStackExts = New System.Windows.Forms.ListBox()
        Me.gbFileSystemValidExts = New System.Windows.Forms.GroupBox()
        Me.btnFileSystemValidExtsReset = New System.Windows.Forms.Button()
        Me.btnFileSystemValidExtsRemove = New System.Windows.Forms.Button()
        Me.btnFileSystemValidExtsAdd = New System.Windows.Forms.Button()
        Me.txtFileSystemValidExts = New System.Windows.Forms.TextBox()
        Me.lstFileSystemValidExts = New System.Windows.Forms.ListBox()
        Me.pnlProxy = New System.Windows.Forms.Panel()
        Me.gbProxyOpts = New System.Windows.Forms.GroupBox()
        Me.gbProxyCredsOpts = New System.Windows.Forms.GroupBox()
        Me.txtProxyDomain = New System.Windows.Forms.TextBox()
        Me.lblProxyDomain = New System.Windows.Forms.Label()
        Me.txtProxyPassword = New System.Windows.Forms.TextBox()
        Me.txtProxyUsername = New System.Windows.Forms.TextBox()
        Me.lblProxyUsername = New System.Windows.Forms.Label()
        Me.lblProxyPassword = New System.Windows.Forms.Label()
        Me.chkProxyCredsEnable = New System.Windows.Forms.CheckBox()
        Me.lblProxyPort = New System.Windows.Forms.Label()
        Me.lblProxyURI = New System.Windows.Forms.Label()
        Me.txtProxyPort = New System.Windows.Forms.TextBox()
        Me.txtProxyURI = New System.Windows.Forms.TextBox()
        Me.chkProxyEnable = New System.Windows.Forms.CheckBox()
        Me.gbMovieBackdropsFolder = New System.Windows.Forms.GroupBox()
        Me.chkMovieBackdropsAuto = New System.Windows.Forms.CheckBox()
        Me.btnMovieBackdropsBrowse = New System.Windows.Forms.Button()
        Me.txtMovieBackdropsPath = New System.Windows.Forms.TextBox()
        Me.lblSettingsCurrent = New System.Windows.Forms.Label()
        Me.pnlSettingsCurrentBGGradient = New System.Windows.Forms.Panel()
        Me.pnlCurrent = New System.Windows.Forms.Panel()
        Me.pbSettingsCurrent = New System.Windows.Forms.PictureBox()
        Me.pnlMovieSources = New System.Windows.Forms.Panel()
        Me.gbMovieSetsFolder = New System.Windows.Forms.GroupBox()
        Me.btnMovieMoviesetsBrowse = New System.Windows.Forms.Button()
        Me.txtMovieMoviesetsPath = New System.Windows.Forms.TextBox()
        Me.gbMovieFileNaming = New System.Windows.Forms.GroupBox()
        Me.tcMovieFileNaming = New System.Windows.Forms.TabControl()
        Me.tpMovieFileNamingXBMC = New System.Windows.Forms.TabPage()
        Me.gbMovieXBMCOptional = New System.Windows.Forms.GroupBox()
        Me.chkMovieXBMCProtectVTSBDMV = New System.Windows.Forms.CheckBox()
        Me.chkMovieXBMCTrailerFormat = New System.Windows.Forms.CheckBox()
        Me.gbMovieEden = New System.Windows.Forms.GroupBox()
        Me.chkMovieExtrafanartsEden = New System.Windows.Forms.CheckBox()
        Me.chkMovieExtrathumbsEden = New System.Windows.Forms.CheckBox()
        Me.chkMovieUseEden = New System.Windows.Forms.CheckBox()
        Me.chkMovieActorThumbsEden = New System.Windows.Forms.CheckBox()
        Me.chkMovieTrailerEden = New System.Windows.Forms.CheckBox()
        Me.chkMovieFanartEden = New System.Windows.Forms.CheckBox()
        Me.chkMoviePosterEden = New System.Windows.Forms.CheckBox()
        Me.chkMovieNFOEden = New System.Windows.Forms.CheckBox()
        Me.gbMovieFrodo = New System.Windows.Forms.GroupBox()
        Me.chkMovieExtrafanartsFrodo = New System.Windows.Forms.CheckBox()
        Me.chkMovieExtrathumbsFrodo = New System.Windows.Forms.CheckBox()
        Me.chkMovieUseFrodo = New System.Windows.Forms.CheckBox()
        Me.chkMovieLandscapeFrodo = New System.Windows.Forms.CheckBox()
        Me.chkMovieBannerFrodo = New System.Windows.Forms.CheckBox()
        Me.chkMovieDiscArtFrodo = New System.Windows.Forms.CheckBox()
        Me.chkMovieClearArtFrodo = New System.Windows.Forms.CheckBox()
        Me.chkMovieClearLogoFrodo = New System.Windows.Forms.CheckBox()
        Me.chkMovieActorThumbsFrodo = New System.Windows.Forms.CheckBox()
        Me.chkMovieTrailerFrodo = New System.Windows.Forms.CheckBox()
        Me.chkMovieFanartFrodo = New System.Windows.Forms.CheckBox()
        Me.chkMoviePosterFrodo = New System.Windows.Forms.CheckBox()
        Me.chkMovieNFOFrodo = New System.Windows.Forms.CheckBox()
        Me.tpMovieFileNamingNMT = New System.Windows.Forms.TabPage()
        Me.gbMovieNMTOptional = New System.Windows.Forms.GroupBox()
        Me.chkMovieYAMJCompatibleSets = New System.Windows.Forms.CheckBox()
        Me.btnMovieYAMJWatchedFilesBrowse = New System.Windows.Forms.Button()
        Me.txtMovieYAMJWatchedFolder = New System.Windows.Forms.TextBox()
        Me.chkMovieYAMJWatchedFile = New System.Windows.Forms.CheckBox()
        Me.gbMovieNMJ = New System.Windows.Forms.GroupBox()
        Me.chkMovieUseNMJ = New System.Windows.Forms.CheckBox()
        Me.chkMovieBannerNMJ = New System.Windows.Forms.CheckBox()
        Me.chkMovieTrailerNMJ = New System.Windows.Forms.CheckBox()
        Me.chkMovieFanartNMJ = New System.Windows.Forms.CheckBox()
        Me.chkMoviePosterNMJ = New System.Windows.Forms.CheckBox()
        Me.chkMovieNFONMJ = New System.Windows.Forms.CheckBox()
        Me.gbMovieYAMJ = New System.Windows.Forms.GroupBox()
        Me.chkMovieUseYAMJ = New System.Windows.Forms.CheckBox()
        Me.chkMovieBannerYAMJ = New System.Windows.Forms.CheckBox()
        Me.chkMovieTrailerYAMJ = New System.Windows.Forms.CheckBox()
        Me.chkMovieFanartYAMJ = New System.Windows.Forms.CheckBox()
        Me.chkMoviePosterYAMJ = New System.Windows.Forms.CheckBox()
        Me.chkMovieNFOYAMJ = New System.Windows.Forms.CheckBox()
        Me.tpMovieFileNamingExpert = New System.Windows.Forms.TabPage()
        Me.gbMovieExpert = New System.Windows.Forms.GroupBox()
        Me.tcMovieFileNamingExpert = New System.Windows.Forms.TabControl()
        Me.tpMovieFileNamingExpertSingle = New System.Windows.Forms.TabPage()
        Me.gbMovieExpertSingleOptionalSettings = New System.Windows.Forms.GroupBox()
        Me.chkMovieUnstackExpertSingle = New System.Windows.Forms.CheckBox()
        Me.chkMovieStackExpertSingle = New System.Windows.Forms.CheckBox()
        Me.chkMovieXBMCTrailerFormatExpertSingle = New System.Windows.Forms.CheckBox()
        Me.gbMovieExpertSingleOptionalImages = New System.Windows.Forms.GroupBox()
        Me.txtMovieActorThumbsExtExpertSingle = New System.Windows.Forms.TextBox()
        Me.chkMovieActorThumbsExpertSingle = New System.Windows.Forms.CheckBox()
        Me.chkMovieExtrafanartsExpertSingle = New System.Windows.Forms.CheckBox()
        Me.chkMovieExtrathumbsExpertSingle = New System.Windows.Forms.CheckBox()
        Me.lblMovieClearArtExpertSingle = New System.Windows.Forms.Label()
        Me.txtMoviePosterExpertSingle = New System.Windows.Forms.TextBox()
        Me.txtMovieFanartExpertSingle = New System.Windows.Forms.TextBox()
        Me.txtMovieTrailerExpertSingle = New System.Windows.Forms.TextBox()
        Me.txtMovieBannerExpertSingle = New System.Windows.Forms.TextBox()
        Me.txtMovieClearLogoExpertSingle = New System.Windows.Forms.TextBox()
        Me.txtMovieClearArtExpertSingle = New System.Windows.Forms.TextBox()
        Me.txtMovieLandscapeExpertSingle = New System.Windows.Forms.TextBox()
        Me.txtMovieDiscArtExpertSingle = New System.Windows.Forms.TextBox()
        Me.lblMovieLandscapeExpertSingle = New System.Windows.Forms.Label()
        Me.lblMovieDiscArtExpertSingle = New System.Windows.Forms.Label()
        Me.lblMovieBannerExpertSingle = New System.Windows.Forms.Label()
        Me.lblMovieTrailerExpertSingle = New System.Windows.Forms.Label()
        Me.lblMovieClearLogoExpertSingle = New System.Windows.Forms.Label()
        Me.lblMovieFanartExpertSingle = New System.Windows.Forms.Label()
        Me.lblMoviePosterExpertSingle = New System.Windows.Forms.Label()
        Me.txtMovieNFOExpertSingle = New System.Windows.Forms.TextBox()
        Me.lblMovieNFOExpertSingle = New System.Windows.Forms.Label()
        Me.tpMovieFileNamingExpertMulti = New System.Windows.Forms.TabPage()
        Me.gbMovieExpertMultiOptionalImages = New System.Windows.Forms.GroupBox()
        Me.txtMovieActorThumbsExtExpertMulti = New System.Windows.Forms.TextBox()
        Me.chkMovieActorThumbsExpertMulti = New System.Windows.Forms.CheckBox()
        Me.gbMovieExpertMultiOptionalSettings = New System.Windows.Forms.GroupBox()
        Me.chkMovieUnstackExpertMulti = New System.Windows.Forms.CheckBox()
        Me.chkMovieStackExpertMulti = New System.Windows.Forms.CheckBox()
        Me.chkMovieXBMCTrailerFormatExpertMulti = New System.Windows.Forms.CheckBox()
        Me.txtMoviePosterExpertMulti = New System.Windows.Forms.TextBox()
        Me.txtMovieFanartExpertMulti = New System.Windows.Forms.TextBox()
        Me.lblMovieClearArtExpertMulti = New System.Windows.Forms.Label()
        Me.txtMovieTrailerExpertMulti = New System.Windows.Forms.TextBox()
        Me.txtMovieBannerExpertMulti = New System.Windows.Forms.TextBox()
        Me.txtMovieClearLogoExpertMulti = New System.Windows.Forms.TextBox()
        Me.txtMovieClearArtExpertMulti = New System.Windows.Forms.TextBox()
        Me.txtMovieLandscapeExpertMulti = New System.Windows.Forms.TextBox()
        Me.txtMovieDiscArtExpertMulti = New System.Windows.Forms.TextBox()
        Me.lblMovieLandscapeExpertMulti = New System.Windows.Forms.Label()
        Me.lblMovieDiscArtExpertMulti = New System.Windows.Forms.Label()
        Me.lblMovieBannerExpertMulti = New System.Windows.Forms.Label()
        Me.lblMovieTrailerExpertMulti = New System.Windows.Forms.Label()
        Me.lblMovieClearLogoExpertMulti = New System.Windows.Forms.Label()
        Me.lblMovieFanartExpertMulti = New System.Windows.Forms.Label()
        Me.lblMoviePosterExpertMulti = New System.Windows.Forms.Label()
        Me.txtMovieNFOExpertMulti = New System.Windows.Forms.TextBox()
        Me.lblMovieNFOExpertMulti = New System.Windows.Forms.Label()
        Me.tpMovieFileNamingExpertVTS = New System.Windows.Forms.TabPage()
        Me.gbMovieExpertVTSOptionalSettings = New System.Windows.Forms.GroupBox()
        Me.chkMovieRecognizeVTSExpertVTS = New System.Windows.Forms.CheckBox()
        Me.chkMovieUseBaseDirectoryExpertVTS = New System.Windows.Forms.CheckBox()
        Me.chkMovieXBMCTrailerFormatExpertVTS = New System.Windows.Forms.CheckBox()
        Me.gbMovieExpertVTSOptionalImages = New System.Windows.Forms.GroupBox()
        Me.txtMovieActorThumbsExtExpertVTS = New System.Windows.Forms.TextBox()
        Me.chkMovieActorThumbsExpertVTS = New System.Windows.Forms.CheckBox()
        Me.chkMovieExtrafanartsExpertVTS = New System.Windows.Forms.CheckBox()
        Me.chkMovieExtrathumbsExpertVTS = New System.Windows.Forms.CheckBox()
        Me.lblMovieClearArtExpertVTS = New System.Windows.Forms.Label()
        Me.txtMoviePosterExpertVTS = New System.Windows.Forms.TextBox()
        Me.txtMovieFanartExpertVTS = New System.Windows.Forms.TextBox()
        Me.txtMovieTrailerExpertVTS = New System.Windows.Forms.TextBox()
        Me.txtMovieBannerExpertVTS = New System.Windows.Forms.TextBox()
        Me.txtMovieClearLogoExpertVTS = New System.Windows.Forms.TextBox()
        Me.txtMovieClearArtExpertVTS = New System.Windows.Forms.TextBox()
        Me.txtMovieLandscapeExpertVTS = New System.Windows.Forms.TextBox()
        Me.txtMovieDiscArtExpertVTS = New System.Windows.Forms.TextBox()
        Me.lblMovieLandscapeExpertVTS = New System.Windows.Forms.Label()
        Me.lblMovieDiscArtExpertVTS = New System.Windows.Forms.Label()
        Me.lblMovieBannerExpertVTS = New System.Windows.Forms.Label()
        Me.lblMovieTrailerExpertVTS = New System.Windows.Forms.Label()
        Me.lblMovieClearLogoExpertVTS = New System.Windows.Forms.Label()
        Me.lblMovieFanartExpertVTS = New System.Windows.Forms.Label()
        Me.lblMoviePosterExpertVTS = New System.Windows.Forms.Label()
        Me.txtMovieNFOExpertVTS = New System.Windows.Forms.TextBox()
        Me.lblMovieNFOExpertVTS = New System.Windows.Forms.Label()
        Me.tpMovieFileNamingExpertBDMV = New System.Windows.Forms.TabPage()
        Me.gbMovieExpertBDMVOptionalSettings = New System.Windows.Forms.GroupBox()
        Me.chkMovieUseBaseDirectoryExpertBDMV = New System.Windows.Forms.CheckBox()
        Me.chkMovieXBMCTrailerFormatExpertBDMV = New System.Windows.Forms.CheckBox()
        Me.gbMovieExpertBDMVOptionalImages = New System.Windows.Forms.GroupBox()
        Me.txtMovieActorThumbsExtExpertBDMV = New System.Windows.Forms.TextBox()
        Me.chkMovieActorThumbsExpertBDMV = New System.Windows.Forms.CheckBox()
        Me.chkMovieExtrafanartsExpertBDMV = New System.Windows.Forms.CheckBox()
        Me.chkMovieExtrathumbsExpertBDMV = New System.Windows.Forms.CheckBox()
        Me.lblMovieClearArtExpertBDMV = New System.Windows.Forms.Label()
        Me.txtMoviePosterExpertBDMV = New System.Windows.Forms.TextBox()
        Me.txtMovieFanartExpertBDMV = New System.Windows.Forms.TextBox()
        Me.txtMovieTrailerExpertBDMV = New System.Windows.Forms.TextBox()
        Me.txtMovieBannerExpertBDMV = New System.Windows.Forms.TextBox()
        Me.txtMovieClearLogoExpertBDMV = New System.Windows.Forms.TextBox()
        Me.txtMovieClearArtExpertBDMV = New System.Windows.Forms.TextBox()
        Me.txtMovieLandscapeExpertBDMV = New System.Windows.Forms.TextBox()
        Me.txtMovieDiscArtExpertBDMV = New System.Windows.Forms.TextBox()
        Me.lblMovieLandscapeExpertBDMV = New System.Windows.Forms.Label()
        Me.lblMovieDiscArtExpertBDMV = New System.Windows.Forms.Label()
        Me.lblMovieBannerExpertBDMV = New System.Windows.Forms.Label()
        Me.lblMovieTrailerExpertBDMV = New System.Windows.Forms.Label()
        Me.lblMovieClearLogoExpertBDMV = New System.Windows.Forms.Label()
        Me.lblMovieFanartExpertBDMV = New System.Windows.Forms.Label()
        Me.lblMoviePosterExpertBDMV = New System.Windows.Forms.Label()
        Me.txtMovieNFOExpertBDMV = New System.Windows.Forms.TextBox()
        Me.lblMovieNFOExpertBDMV = New System.Windows.Forms.Label()
        Me.chkMovieUseExpert = New System.Windows.Forms.CheckBox()
        Me.btnMovieSourceEdit = New System.Windows.Forms.Button()
        Me.gbMovieMiscOpts = New System.Windows.Forms.GroupBox()
        Me.chkMovieScanOrderModify = New System.Windows.Forms.CheckBox()
        Me.chkMovieSortBeforeScan = New System.Windows.Forms.CheckBox()
        Me.chkMovieGeneralIgnoreLastScan = New System.Windows.Forms.CheckBox()
        Me.chkMovieCleanDB = New System.Windows.Forms.CheckBox()
        Me.chkMovieSkipStackedSizeCheck = New System.Windows.Forms.CheckBox()
        Me.lblMovieSkipLessThanMB = New System.Windows.Forms.Label()
        Me.txtMovieSkipLessThan = New System.Windows.Forms.TextBox()
        Me.lblMovieSkipLessThan = New System.Windows.Forms.Label()
        Me.pnlTVGeneral = New System.Windows.Forms.Panel()
        Me.gbTVGeneralMediaListOpts = New System.Windows.Forms.GroupBox()
        Me.chkTVDisplayMissingEpisodes = New System.Windows.Forms.CheckBox()
        Me.gbTVGeneralListEpisodeOpts = New System.Windows.Forms.GroupBox()
        Me.chkTVEpisodeNfoCol = New System.Windows.Forms.CheckBox()
        Me.chkTVEpisodeFanartCol = New System.Windows.Forms.CheckBox()
        Me.chkTVEpisodePosterCol = New System.Windows.Forms.CheckBox()
        Me.gbTVGeneralListSeasonOpts = New System.Windows.Forms.GroupBox()
        Me.chkTVSeasonFanartCol = New System.Windows.Forms.CheckBox()
        Me.chkTVSeasonPosterCol = New System.Windows.Forms.CheckBox()
        Me.gbTVGeneralListShowOpts = New System.Windows.Forms.GroupBox()
        Me.chkTVShowNfoCol = New System.Windows.Forms.CheckBox()
        Me.chkTVShowFanartCol = New System.Windows.Forms.CheckBox()
        Me.chkTVShowPosterCol = New System.Windows.Forms.CheckBox()
        Me.gbTVEpisodeFilterOpts = New System.Windows.Forms.GroupBox()
        Me.btnTVEpisodeFilterReset = New System.Windows.Forms.Button()
        Me.chkTVEpisodeNoFilter = New System.Windows.Forms.CheckBox()
        Me.btnTVEpisodeFilterDown = New System.Windows.Forms.Button()
        Me.btnTVEpisodeFilterUp = New System.Windows.Forms.Button()
        Me.chkTVEpisodeProperCase = New System.Windows.Forms.CheckBox()
        Me.btnTVEpisodeFilterRemove = New System.Windows.Forms.Button()
        Me.btnTVEpisodeFilterAdd = New System.Windows.Forms.Button()
        Me.txtTVEpisodeFilter = New System.Windows.Forms.TextBox()
        Me.lstTVEpisodeFilter = New System.Windows.Forms.ListBox()
        Me.gbTVGeneralMiscOpts = New System.Windows.Forms.GroupBox()
        Me.chkTVGeneralMarkNewShows = New System.Windows.Forms.CheckBox()
        Me.chkTVGeneralMarkNewEpisodes = New System.Windows.Forms.CheckBox()
        Me.chkTVGeneralDisplayASPoster = New System.Windows.Forms.CheckBox()
        Me.gbTVShowFilterOpts = New System.Windows.Forms.GroupBox()
        Me.btnTVShowFilterReset = New System.Windows.Forms.Button()
        Me.btnTVShowFilterDown = New System.Windows.Forms.Button()
        Me.btnTVShowFilterUp = New System.Windows.Forms.Button()
        Me.chkTVShowProperCase = New System.Windows.Forms.CheckBox()
        Me.btnTVShowFilterRemove = New System.Windows.Forms.Button()
        Me.btnTVShowFilterAdd = New System.Windows.Forms.Button()
        Me.txtTVShowFilter = New System.Windows.Forms.TextBox()
        Me.lstTVShowFilter = New System.Windows.Forms.ListBox()
        Me.pnlTVSources = New System.Windows.Forms.Panel()
        Me.tcTVSources = New System.Windows.Forms.TabControl()
        Me.tpTVSourcesGeneral = New System.Windows.Forms.TabPage()
        Me.gbTVFileNaming = New System.Windows.Forms.GroupBox()
        Me.tcTVFileNaming = New System.Windows.Forms.TabControl()
        Me.tpTVFileNamingXBMC = New System.Windows.Forms.TabPage()
        Me.gbTVXBMCAdditional = New System.Windows.Forms.GroupBox()
<<<<<<< HEAD
        Me.btnTVBrowseTVTheme = New System.Windows.Forms.Button()
=======
        Me.btnTVShowTVThemeBrowse = New System.Windows.Forms.Button()
>>>>>>> upstream/master
        Me.txtTVShowTVThemeFolderXBMC = New System.Windows.Forms.TextBox()
        Me.chkTVShowTVThemeXBMC = New System.Windows.Forms.CheckBox()
        Me.chkTVSeasonLandscapeXBMC = New System.Windows.Forms.CheckBox()
        Me.chkTVShowLandscapeXBMC = New System.Windows.Forms.CheckBox()
        Me.chkTVShowCharacterArtXBMC = New System.Windows.Forms.CheckBox()
        Me.chkTVShowClearArtXBMC = New System.Windows.Forms.CheckBox()
        Me.chkTVShowClearLogoXBMC = New System.Windows.Forms.CheckBox()
        Me.gbTVFrodo = New System.Windows.Forms.GroupBox()
        Me.chkTVSeasonPosterFrodo = New System.Windows.Forms.CheckBox()
        Me.chkTVShowBannerFrodo = New System.Windows.Forms.CheckBox()
        Me.chkTVUseFrodo = New System.Windows.Forms.CheckBox()
        Me.chkTVEpisodeActorThumbsFrodo = New System.Windows.Forms.CheckBox()
        Me.chkTVSeasonBannerFrodo = New System.Windows.Forms.CheckBox()
        Me.chkTVEpisodePosterFrodo = New System.Windows.Forms.CheckBox()
        Me.chkTVShowActorThumbsFrodo = New System.Windows.Forms.CheckBox()
        Me.chkTVSeasonFanartFrodo = New System.Windows.Forms.CheckBox()
        Me.chkTVShowFanartFrodo = New System.Windows.Forms.CheckBox()
        Me.chkTVShowPosterFrodo = New System.Windows.Forms.CheckBox()
        Me.tpTVFileNamingNMT = New System.Windows.Forms.TabPage()
        Me.gbTVNMT = New System.Windows.Forms.GroupBox()
        Me.chkTVSeasonPosterNMJ = New System.Windows.Forms.CheckBox()
        Me.chkTVShowBannerNMJ = New System.Windows.Forms.CheckBox()
        Me.chkTVSeasonBannerNMJ = New System.Windows.Forms.CheckBox()
        Me.chkTVEpisodePosterNMJ = New System.Windows.Forms.CheckBox()
        Me.chkTVSeasonFanartNMJ = New System.Windows.Forms.CheckBox()
        Me.chkTVShowFanartNMJ = New System.Windows.Forms.CheckBox()
        Me.chkTVShowPosterNMJ = New System.Windows.Forms.CheckBox()
        Me.chkTVUseNMJ = New System.Windows.Forms.CheckBox()
        Me.gbTVYAMJ = New System.Windows.Forms.GroupBox()
        Me.chkTVSeasonPosterYAMJ = New System.Windows.Forms.CheckBox()
        Me.chkTVShowBannerYAMJ = New System.Windows.Forms.CheckBox()
        Me.chkTVSeasonBannerYAMJ = New System.Windows.Forms.CheckBox()
        Me.chkTVEpisodePosterYAMJ = New System.Windows.Forms.CheckBox()
        Me.chkTVSeasonFanartYAMJ = New System.Windows.Forms.CheckBox()
        Me.chkTVShowFanartYAMJ = New System.Windows.Forms.CheckBox()
        Me.chkTVShowPosterYAMJ = New System.Windows.Forms.CheckBox()
        Me.chkTVUseYAMJ = New System.Windows.Forms.CheckBox()
        Me.tpTVFileNamingExpert = New System.Windows.Forms.TabPage()
        Me.lvTVSources = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(),System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(),System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(),System.Windows.Forms.ColumnHeader)
        Me.gbTVSourcesMiscOpts = New System.Windows.Forms.GroupBox()
        Me.TVSkipLessThanMB = New System.Windows.Forms.Label()
        Me.txtTVSkipLessThan = New System.Windows.Forms.TextBox()
        Me.lblTVSkipLessThan = New System.Windows.Forms.Label()
        Me.chkTVScanOrderModify = New System.Windows.Forms.CheckBox()
        Me.chkTVGeneralIgnoreLastScan = New System.Windows.Forms.CheckBox()
        Me.chkTVCleanDB = New System.Windows.Forms.CheckBox()
        Me.btnTVSourceAdd = New System.Windows.Forms.Button()
        Me.btnTVSourceEdit = New System.Windows.Forms.Button()
        Me.btnRemTVSource = New System.Windows.Forms.Button()
        Me.tpTVSourcesRegex = New System.Windows.Forms.TabPage()
        Me.btnTVShowRegexGet = New System.Windows.Forms.Button()
        Me.btnTVShowRegexDown = New System.Windows.Forms.Button()
        Me.btnTVShowRegexUp = New System.Windows.Forms.Button()
        Me.btnTVShowRegexReset = New System.Windows.Forms.Button()
        Me.gbTVShowRegex = New System.Windows.Forms.GroupBox()
        Me.btnTVShowRegexClear = New System.Windows.Forms.Button()
        Me.lblTVSeasonMatch = New System.Windows.Forms.Label()
        Me.btnTVShowRegexAdd = New System.Windows.Forms.Button()
        Me.txtTVSeasonRegex = New System.Windows.Forms.TextBox()
        Me.lblTVEpisodeRetrieve = New System.Windows.Forms.Label()
        Me.cbTVSeasonRetrieve = New System.Windows.Forms.ComboBox()
        Me.lblTVSeasonRetrieve = New System.Windows.Forms.Label()
        Me.txtTVEpisodeRegex = New System.Windows.Forms.TextBox()
        Me.lblTVEpisodeMatch = New System.Windows.Forms.Label()
        Me.cbTVEpisodeRetrieve = New System.Windows.Forms.ComboBox()
        Me.btnTVShowRegexEdit = New System.Windows.Forms.Button()
        Me.btnTVShowRegexRemove = New System.Windows.Forms.Button()
        Me.lvTVShowRegex = New System.Windows.Forms.ListView()
        Me.colTVShowRegexID = CType(New System.Windows.Forms.ColumnHeader(),System.Windows.Forms.ColumnHeader)
        Me.colTVShowRegexSeason = CType(New System.Windows.Forms.ColumnHeader(),System.Windows.Forms.ColumnHeader)
        Me.colTVShowRegexSeasonApply = CType(New System.Windows.Forms.ColumnHeader(),System.Windows.Forms.ColumnHeader)
        Me.colTVShowRegexEpisode = CType(New System.Windows.Forms.ColumnHeader(),System.Windows.Forms.ColumnHeader)
        Me.colTVShowRegexEpisodeApply = CType(New System.Windows.Forms.ColumnHeader(),System.Windows.Forms.ColumnHeader)
        Me.fbdBrowse = New System.Windows.Forms.FolderBrowserDialog()
        Me.ToolTips = New System.Windows.Forms.ToolTip(Me.components)
        Me.pnlTVImages = New System.Windows.Forms.Panel()
        Me.tcTVImages = New System.Windows.Forms.TabControl()
        Me.tpTVShow = New System.Windows.Forms.TabPage()
        Me.gbTVShowCharacterArtOpts = New System.Windows.Forms.GroupBox()
        Me.chkTVShowCharacterArtOverwrite = New System.Windows.Forms.CheckBox()
        Me.gbTVShowClearArtOpts = New System.Windows.Forms.GroupBox()
        Me.chkTVShowClearArtOverwrite = New System.Windows.Forms.CheckBox()
        Me.gbTVShowClearLogoOpts = New System.Windows.Forms.GroupBox()
        Me.chkTVShowClearLogoOverwrite = New System.Windows.Forms.CheckBox()
        Me.gbTVShowLandscapeOpts = New System.Windows.Forms.GroupBox()
        Me.chkTVShowLandscapeOverwrite = New System.Windows.Forms.CheckBox()
        Me.gbTVShowBannerOpts = New System.Windows.Forms.GroupBox()
        Me.txtTVShowBannerWidth = New System.Windows.Forms.TextBox()
        Me.txtTVShowBannerHeight = New System.Windows.Forms.TextBox()
        Me.lblTVShowBannerQual = New System.Windows.Forms.Label()
        Me.tbTVShowBannerQual = New System.Windows.Forms.TrackBar()
        Me.lblTVShowBannerQ = New System.Windows.Forms.Label()
        Me.lblTVShowBannerWidth = New System.Windows.Forms.Label()
        Me.lblTVShowBannerHeight = New System.Windows.Forms.Label()
        Me.chkTVShowBannerResize = New System.Windows.Forms.CheckBox()
        Me.lblTVShowBannerType = New System.Windows.Forms.Label()
        Me.cbTVShowBannerPrefType = New System.Windows.Forms.ComboBox()
        Me.chkTVShowBannerOverwrite = New System.Windows.Forms.CheckBox()
        Me.gbTVShowPosterOpts = New System.Windows.Forms.GroupBox()
        Me.txtTVShowPosterWidth = New System.Windows.Forms.TextBox()
        Me.txtTVShowPosterHeight = New System.Windows.Forms.TextBox()
        Me.lblTVShowPosterQual = New System.Windows.Forms.Label()
        Me.tbTVShowPosterQual = New System.Windows.Forms.TrackBar()
        Me.lblTVShowPosterQ = New System.Windows.Forms.Label()
        Me.lblTVShowPosterWidth = New System.Windows.Forms.Label()
        Me.lblTVShowPosterHeight = New System.Windows.Forms.Label()
        Me.chkTVShowPosterResize = New System.Windows.Forms.CheckBox()
        Me.lblTVShowPosterSize = New System.Windows.Forms.Label()
        Me.cbTVShowPosterPrefSize = New System.Windows.Forms.ComboBox()
        Me.chkTVShowPosterOverwrite = New System.Windows.Forms.CheckBox()
        Me.gbTVShowFanartOpts = New System.Windows.Forms.GroupBox()
        Me.txtTVShowFanartWidth = New System.Windows.Forms.TextBox()
        Me.txtTVShowFanartHeight = New System.Windows.Forms.TextBox()
        Me.lblTVShowFanartQual = New System.Windows.Forms.Label()
        Me.tbTVShowFanartQual = New System.Windows.Forms.TrackBar()
        Me.lblTVShowFanartQ = New System.Windows.Forms.Label()
        Me.lblTVShowFanartWidth = New System.Windows.Forms.Label()
        Me.lblTVShowFanartHeight = New System.Windows.Forms.Label()
        Me.chkTVShowFanartResize = New System.Windows.Forms.CheckBox()
        Me.cbTVShowFanartPrefSize = New System.Windows.Forms.ComboBox()
        Me.lblTVShowFanartSize = New System.Windows.Forms.Label()
        Me.chkTVShowFanartOverwrite = New System.Windows.Forms.CheckBox()
        Me.tpTVAllSeasons = New System.Windows.Forms.TabPage()
        Me.gbTVASLandscapeOpts = New System.Windows.Forms.GroupBox()
        Me.chkTVASLandscapeOverwrite = New System.Windows.Forms.CheckBox()
        Me.gbTVASFanartOpts = New System.Windows.Forms.GroupBox()
        Me.txtTVASFanartWidth = New System.Windows.Forms.TextBox()
        Me.txtTVASFanartHeight = New System.Windows.Forms.TextBox()
        Me.lblTVASFanartQual = New System.Windows.Forms.Label()
        Me.tbTVASFanartQual = New System.Windows.Forms.TrackBar()
        Me.lblTVASFanartQ = New System.Windows.Forms.Label()
        Me.lblTVASFanartWidth = New System.Windows.Forms.Label()
        Me.lblTVASFanartHeight = New System.Windows.Forms.Label()
        Me.chkTVASFanartResize = New System.Windows.Forms.CheckBox()
        Me.cbTVASFanartPrefSize = New System.Windows.Forms.ComboBox()
        Me.lblTVASFanartSize = New System.Windows.Forms.Label()
        Me.chkTVASFanartOverwrite = New System.Windows.Forms.CheckBox()
        Me.gbTVASBannerOpts = New System.Windows.Forms.GroupBox()
        Me.txtTVASBannerWidth = New System.Windows.Forms.TextBox()
        Me.txtTVASBannerHeight = New System.Windows.Forms.TextBox()
        Me.lblTVASBannerQual = New System.Windows.Forms.Label()
        Me.tbTVASBannerQual = New System.Windows.Forms.TrackBar()
        Me.lblTVASBannerQ = New System.Windows.Forms.Label()
        Me.lblTVASBannerWidth = New System.Windows.Forms.Label()
        Me.lblTVASBannerHeight = New System.Windows.Forms.Label()
        Me.chkTVASBannerResize = New System.Windows.Forms.CheckBox()
        Me.lblTVASBannerType = New System.Windows.Forms.Label()
        Me.cbTVASBannerPrefType = New System.Windows.Forms.ComboBox()
        Me.chkTVASBannerOverwrite = New System.Windows.Forms.CheckBox()
        Me.gbTVASPosterOpts = New System.Windows.Forms.GroupBox()
        Me.txtTVASPosterWidth = New System.Windows.Forms.TextBox()
        Me.txtTVASPosterHeight = New System.Windows.Forms.TextBox()
        Me.lblTVASPosterQual = New System.Windows.Forms.Label()
        Me.tbTVASPosterQual = New System.Windows.Forms.TrackBar()
        Me.lblTVASPosterQ = New System.Windows.Forms.Label()
        Me.lblTVASPosterWidth = New System.Windows.Forms.Label()
        Me.lblTVASPosterHeight = New System.Windows.Forms.Label()
        Me.chkTVASPosterResize = New System.Windows.Forms.CheckBox()
        Me.lblTVASPosterSize = New System.Windows.Forms.Label()
        Me.cbTVASPosterPrefSize = New System.Windows.Forms.ComboBox()
        Me.chkTVASPosterOverwrite = New System.Windows.Forms.CheckBox()
        Me.tpTVSeason = New System.Windows.Forms.TabPage()
        Me.gbTVSeasonLandscapeOpts = New System.Windows.Forms.GroupBox()
        Me.chkTVSeasonLandscapeOverwrite = New System.Windows.Forms.CheckBox()
        Me.gbTVSeasonBannerOpts = New System.Windows.Forms.GroupBox()
        Me.txtTVSeasonBannerWidth = New System.Windows.Forms.TextBox()
        Me.txtTVSeasonBannerHeight = New System.Windows.Forms.TextBox()
        Me.lblTVSeasonBannerQual = New System.Windows.Forms.Label()
        Me.tbTVSeasonBannerQual = New System.Windows.Forms.TrackBar()
        Me.lblTVSeasonBannerQ = New System.Windows.Forms.Label()
        Me.lblTVSeasonBannerWidth = New System.Windows.Forms.Label()
        Me.lblTVSeasonBannerHeight = New System.Windows.Forms.Label()
        Me.chkTVSeasonBannerResize = New System.Windows.Forms.CheckBox()
        Me.lblTVSeasonBannerType = New System.Windows.Forms.Label()
        Me.cbTVSeasonBannerPrefType = New System.Windows.Forms.ComboBox()
        Me.chkTVSeasonBannerOverwrite = New System.Windows.Forms.CheckBox()
        Me.gbTVSeasonPosterOpts = New System.Windows.Forms.GroupBox()
        Me.txtTVSeasonPosterWidth = New System.Windows.Forms.TextBox()
        Me.txtTVSeasonPosterHeight = New System.Windows.Forms.TextBox()
        Me.lblTVSeasonPosterQual = New System.Windows.Forms.Label()
        Me.tbTVSeasonPosterQual = New System.Windows.Forms.TrackBar()
        Me.lblTVSeasonPosterQ = New System.Windows.Forms.Label()
        Me.lblTVSeasonPosterWidth = New System.Windows.Forms.Label()
        Me.lblTVSeasonPosterHeight = New System.Windows.Forms.Label()
        Me.chkTVSeasonPosterResize = New System.Windows.Forms.CheckBox()
        Me.lblTVSeasonPosterSize = New System.Windows.Forms.Label()
        Me.cbTVSeasonPosterPrefSize = New System.Windows.Forms.ComboBox()
        Me.chkTVSeasonPosterOverwrite = New System.Windows.Forms.CheckBox()
        Me.gbTVSeasonFanartOpts = New System.Windows.Forms.GroupBox()
        Me.txtTVSeasonFanartWidth = New System.Windows.Forms.TextBox()
        Me.txtTVSeasonFanartHeight = New System.Windows.Forms.TextBox()
        Me.lblTVSeasonFanartQual = New System.Windows.Forms.Label()
        Me.tbTVSeasonFanartQual = New System.Windows.Forms.TrackBar()
        Me.lblTVSeasonFanartQ = New System.Windows.Forms.Label()
        Me.lblTVSeasonFanartWidth = New System.Windows.Forms.Label()
        Me.lblTVSeasonFanartHeight = New System.Windows.Forms.Label()
        Me.chkTVSeasonFanartResize = New System.Windows.Forms.CheckBox()
        Me.cbTVSeasonFanartPrefSize = New System.Windows.Forms.ComboBox()
        Me.lblTVSeasonFanartSize = New System.Windows.Forms.Label()
        Me.chkTVSeasonFanartOverwrite = New System.Windows.Forms.CheckBox()
        Me.tpTVEpisode = New System.Windows.Forms.TabPage()
        Me.gbTVEpisodePosterOpts = New System.Windows.Forms.GroupBox()
        Me.txtTVEpisodePosterWidth = New System.Windows.Forms.TextBox()
        Me.txtTVEpisodePosterHeight = New System.Windows.Forms.TextBox()
        Me.lblTVEpisodePosterQual = New System.Windows.Forms.Label()
        Me.tbTVEpisodePosterQual = New System.Windows.Forms.TrackBar()
        Me.lblTVEpisodePosterQ = New System.Windows.Forms.Label()
        Me.lblTVEpisodePosterWidth = New System.Windows.Forms.Label()
        Me.lblTVEpisodePosterHeight = New System.Windows.Forms.Label()
        Me.chkTVEpisodePosterResize = New System.Windows.Forms.CheckBox()
        Me.chkTVEpisodePosterOverwrite = New System.Windows.Forms.CheckBox()
        Me.gbTVEpisodeFanartOpts = New System.Windows.Forms.GroupBox()
        Me.txtTVEpisodeFanartWidth = New System.Windows.Forms.TextBox()
        Me.txtTVEpisodeFanartHeight = New System.Windows.Forms.TextBox()
        Me.lblTVEpisodeFanartQual = New System.Windows.Forms.Label()
        Me.tbTVEpisodeFanartQual = New System.Windows.Forms.TrackBar()
        Me.lblTVEpisodeFanartQ = New System.Windows.Forms.Label()
        Me.lblTVEpisodeFanartWidth = New System.Windows.Forms.Label()
        Me.lblTVEpisodeFanartHeight = New System.Windows.Forms.Label()
        Me.chkTVEpisodeFanartResize = New System.Windows.Forms.CheckBox()
        Me.cbTVEpisodeFanartPrefSize = New System.Windows.Forms.ComboBox()
        Me.lblTVEpisodeFanartSize = New System.Windows.Forms.Label()
        Me.chkTVEpisodeFanartOverwrite = New System.Windows.Forms.CheckBox()
        Me.pnlTVScraper = New System.Windows.Forms.Panel()
        Me.gbTVScraperDurationOpts = New System.Windows.Forms.GroupBox()
        Me.lblTVScraperDurationRuntimeFormat = New System.Windows.Forms.Label()
        Me.chkTVScraperUseMDDuration = New System.Windows.Forms.CheckBox()
        Me.txtTVScraperDurationRuntimeFormat = New System.Windows.Forms.TextBox()
        Me.gbTVScraperFieldsOpts = New System.Windows.Forms.GroupBox()
        Me.gbTVScraperFieldsShowOpts = New System.Windows.Forms.GroupBox()
        Me.chkTVScraperShowStatus = New System.Windows.Forms.CheckBox()
        Me.chkTVScraperShowRating = New System.Windows.Forms.CheckBox()
        Me.chkTVScraperShowActors = New System.Windows.Forms.CheckBox()
        Me.chkTVScraperShowStudio = New System.Windows.Forms.CheckBox()
        Me.chkTVScraperShowPremiered = New System.Windows.Forms.CheckBox()
        Me.chkTVScraperShowEpiGuideURL = New System.Windows.Forms.CheckBox()
        Me.chkTVScraperShowMPAA = New System.Windows.Forms.CheckBox()
        Me.chkTVScraperShowPlot = New System.Windows.Forms.CheckBox()
        Me.chkTVScraperShowGenre = New System.Windows.Forms.CheckBox()
        Me.chkTVScraperShowTitle = New System.Windows.Forms.CheckBox()
        Me.gbTVScraperFieldsEpisodeOpts = New System.Windows.Forms.GroupBox()
        Me.chkTVScraperEpisodeActors = New System.Windows.Forms.CheckBox()
        Me.chkTVScraperEpisodeCredits = New System.Windows.Forms.CheckBox()
        Me.chkTVScraperEpisodeDirector = New System.Windows.Forms.CheckBox()
        Me.chkTVScraperEpisodePlot = New System.Windows.Forms.CheckBox()
        Me.chkTVScraperEpisodeRating = New System.Windows.Forms.CheckBox()
        Me.chkTVScraperEpisodeAired = New System.Windows.Forms.CheckBox()
        Me.chkTVScraperEpisodeTitle = New System.Windows.Forms.CheckBox()
        Me.chkTVScraperEpisodeEpisode = New System.Windows.Forms.CheckBox()
        Me.chkTVScraperEpisodeSeason = New System.Windows.Forms.CheckBox()
        Me.gbTVScraperGlobalLocksOpts = New System.Windows.Forms.GroupBox()
        Me.gbTVScraperGlobalLocksEpisodeOpts = New System.Windows.Forms.GroupBox()
        Me.chkTVLockEpisodeTitle = New System.Windows.Forms.CheckBox()
        Me.chkTVLockEpisodeRating = New System.Windows.Forms.CheckBox()
        Me.chkTVLockEpisodePlot = New System.Windows.Forms.CheckBox()
        Me.gbTVScraperGlobalLocksShowOpts = New System.Windows.Forms.GroupBox()
        Me.chkTVLockShowStatus = New System.Windows.Forms.CheckBox()
        Me.chkTVLockShowPlot = New System.Windows.Forms.CheckBox()
        Me.chkTVLockShowGenre = New System.Windows.Forms.CheckBox()
        Me.chkTVLockShowStudio = New System.Windows.Forms.CheckBox()
        Me.chkTVLockShowRating = New System.Windows.Forms.CheckBox()
        Me.chkTVLockShowTitle = New System.Windows.Forms.CheckBox()
        Me.gbTVScraperMetaDataOpts = New System.Windows.Forms.GroupBox()
        Me.gbTVScraperDefFIExtOpts = New System.Windows.Forms.GroupBox()
        Me.lstTVScraperDefFIExt = New System.Windows.Forms.ListBox()
        Me.txtTVScraperDefFIExt = New System.Windows.Forms.TextBox()
        Me.lblTVScraperDefFIExt = New System.Windows.Forms.Label()
        Me.btnTVScraperDefFIExtRemove = New System.Windows.Forms.Button()
        Me.btnTVScraperDefFIExtEdit = New System.Windows.Forms.Button()
        Me.btnTVScraperDefFIExtAdd = New System.Windows.Forms.Button()
        Me.cbTVLanguageOverlay = New System.Windows.Forms.ComboBox()
        Me.lblTVLanguageOverlay = New System.Windows.Forms.Label()
        Me.chkTVScraperMetaDataScan = New System.Windows.Forms.CheckBox()
        Me.gbTVScraperOptionsOpts = New System.Windows.Forms.GroupBox()
        Me.lblTVScraperRatingRegion = New System.Windows.Forms.Label()
        Me.cbTVScraperRatingRegion = New System.Windows.Forms.ComboBox()
        Me.lblTVScraperOptionsOrdering = New System.Windows.Forms.Label()
        Me.cbTVScraperOptionsOrdering = New System.Windows.Forms.ComboBox()
        Me.lblTVScraperUpdateTime = New System.Windows.Forms.Label()
        Me.cbTVScraperUpdateTime = New System.Windows.Forms.ComboBox()
        Me.gbMovieScraperFieldsOpts = New System.Windows.Forms.GroupBox()
        Me.chkMovieScraperCertification = New System.Windows.Forms.CheckBox()
        Me.chkMovieScraperTop250 = New System.Windows.Forms.CheckBox()
        Me.chkMovieScraperCountry = New System.Windows.Forms.CheckBox()
        Me.txtMovieScraperGenreLimit = New System.Windows.Forms.TextBox()
        Me.lblMovieScraperGenreLimit = New System.Windows.Forms.Label()
        Me.txtMovieScraperCastLimit = New System.Windows.Forms.TextBox()
        Me.lblMovieScraperCastLimit = New System.Windows.Forms.Label()
        Me.chkMovieScraperCrew = New System.Windows.Forms.CheckBox()
        Me.chkMovieScraperMusicBy = New System.Windows.Forms.CheckBox()
        Me.chkMovieScraperProducers = New System.Windows.Forms.CheckBox()
        Me.chkMovieScraperWriters = New System.Windows.Forms.CheckBox()
        Me.chkMovieScraperStudio = New System.Windows.Forms.CheckBox()
        Me.chkMovieScraperRuntime = New System.Windows.Forms.CheckBox()
        Me.chkMovieScraperPlot = New System.Windows.Forms.CheckBox()
        Me.chkMovieScraperOutline = New System.Windows.Forms.CheckBox()
        Me.chkMovieScraperGenre = New System.Windows.Forms.CheckBox()
        Me.chkMovieScraperDirector = New System.Windows.Forms.CheckBox()
        Me.chkMovieScraperTagline = New System.Windows.Forms.CheckBox()
        Me.chkMovieScraperCast = New System.Windows.Forms.CheckBox()
        Me.chkMovieScraperVotes = New System.Windows.Forms.CheckBox()
        Me.chkMovieScraperTrailer = New System.Windows.Forms.CheckBox()
        Me.chkMovieScraperRating = New System.Windows.Forms.CheckBox()
        Me.chkMovieScraperRelease = New System.Windows.Forms.CheckBox()
        Me.chkMovieScraperMPAA = New System.Windows.Forms.CheckBox()
        Me.chkMovieScraperYear = New System.Windows.Forms.CheckBox()
        Me.chkMovieScraperTitle = New System.Windows.Forms.CheckBox()
        Me.lblMovieScraperOutlineLimit = New System.Windows.Forms.Label()
        Me.txtMovieScraperOutlineLimit = New System.Windows.Forms.TextBox()
        Me.gbMovieScraperMetaDataOpts = New System.Windows.Forms.GroupBox()
        Me.gbMovieScraperDefFIExtOpts = New System.Windows.Forms.GroupBox()
        Me.lstMovieScraperDefFIExt = New System.Windows.Forms.ListBox()
        Me.txtMovieScraperDefFIExt = New System.Windows.Forms.TextBox()
        Me.lblMovieScraperDefFIExt = New System.Windows.Forms.Label()
        Me.btnMovieScraperDefFIExtRemove = New System.Windows.Forms.Button()
        Me.btnMovieScraperDefFIExtEdit = New System.Windows.Forms.Button()
        Me.btnMovieScraperDefFIExtAdd = New System.Windows.Forms.Button()
        Me.chkMovieScraperMetaDataIFOScan = New System.Windows.Forms.CheckBox()
        Me.cbMovieLanguageOverlay = New System.Windows.Forms.ComboBox()
        Me.lblMovieLanguageOverlay = New System.Windows.Forms.Label()
        Me.gbMovieScraperDurationFormatOpts = New System.Windows.Forms.GroupBox()
        Me.lblMovieScraperDurationRuntimeFormat = New System.Windows.Forms.Label()
        Me.txtMovieScraperDurationRuntimeFormat = New System.Windows.Forms.TextBox()
        Me.chkMovieScraperUseMDDuration = New System.Windows.Forms.CheckBox()
        Me.chkMovieScraperMetaDataScan = New System.Windows.Forms.CheckBox()
        Me.gbMovieScraperGlobalLocksOpts = New System.Windows.Forms.GroupBox()
        Me.chkMovieLockMPAA = New System.Windows.Forms.CheckBox()
        Me.chkMovieLockLanguageA = New System.Windows.Forms.CheckBox()
        Me.chkMovieLockLanguageV = New System.Windows.Forms.CheckBox()
        Me.chkMovieLockOutline = New System.Windows.Forms.CheckBox()
        Me.chkMovieLockPlot = New System.Windows.Forms.CheckBox()
        Me.chkMovieLockTrailer = New System.Windows.Forms.CheckBox()
        Me.chkMovieLockGenre = New System.Windows.Forms.CheckBox()
        Me.chkMovieLockStudio = New System.Windows.Forms.CheckBox()
        Me.chkMovieLockRating = New System.Windows.Forms.CheckBox()
        Me.chkMovieLockTagline = New System.Windows.Forms.CheckBox()
        Me.chkMovieLockTitle = New System.Windows.Forms.CheckBox()
        Me.gbMovieScraperMiscOpts = New System.Windows.Forms.GroupBox()
        Me.chkMovieScraperOutlinePlotEnglishOverwrite = New System.Windows.Forms.CheckBox()
        Me.chkMovieScraperTitleFallback = New System.Windows.Forms.CheckBox()
        Me.chkMovieScraperPlotForOutline = New System.Windows.Forms.CheckBox()
        Me.chkMovieScraperUseMPAAFSK = New System.Windows.Forms.CheckBox()
        Me.chkMovieScraperFullCast = New System.Windows.Forms.CheckBox()
        Me.chkMovieScraperForceTitle = New System.Windows.Forms.CheckBox()
        Me.cbMovieScraperForceTitle = New System.Windows.Forms.ComboBox()
        Me.chkMovieScraperOnlyValueForMPAA = New System.Windows.Forms.CheckBox()
        Me.chkMovieScraperOutlineForPlot = New System.Windows.Forms.CheckBox()
        Me.chkMovieScraperCastWithImg = New System.Windows.Forms.CheckBox()
        Me.chkMovieScraperCertForMPAA = New System.Windows.Forms.CheckBox()
        Me.chkMovieScraperFullCrew = New System.Windows.Forms.CheckBox()
        Me.cbMovieScraperCertLang = New System.Windows.Forms.ComboBox()
        Me.chkMovieScraperCertLang = New System.Windows.Forms.CheckBox()
        Me.pnlMovieScraper = New System.Windows.Forms.Panel()
        Me.tsSettingsTopMenu = New System.Windows.Forms.ToolStrip()
        Me.pnlSettingsMain = New System.Windows.Forms.Panel()
        Me.gbSettingsHelp = New System.Windows.Forms.GroupBox()
        Me.pbSettingsHelpLogo = New System.Windows.Forms.PictureBox()
        Me.lblHelp = New System.Windows.Forms.Label()
        Me.pnlSettingsHelp = New System.Windows.Forms.Panel()
        Me.pnlMovieTrailers = New System.Windows.Forms.Panel()
        Me.gbMovieTrailerOpts = New System.Windows.Forms.GroupBox()
        Me.cbMovieTrailerMinQual = New System.Windows.Forms.ComboBox()
        Me.lblMovieTrailerMinQual = New System.Windows.Forms.Label()
        Me.cbMovieTrailerPrefQual = New System.Windows.Forms.ComboBox()
        Me.lblMovieTrailerPrefQual = New System.Windows.Forms.Label()
        Me.chkMovieTrailerDeleteExisting = New System.Windows.Forms.CheckBox()
        Me.chkMovieTrailerOverwrite = New System.Windows.Forms.CheckBox()
        Me.chkMovieTrailerEnable = New System.Windows.Forms.CheckBox()
        Me.fileBrowse = New System.Windows.Forms.OpenFileDialog()
<<<<<<< HEAD
        Me.GroupBox4.SuspendLayout
        Me.gb_DAEMON.SuspendLayout
        Me.GroupBox29.SuspendLayout
        Me.GroupBox3.SuspendLayout
        Me.tcCleaner.SuspendLayout
        Me.tpStandard.SuspendLayout
        Me.tpExpert.SuspendLayout
        Me.GroupBox12.SuspendLayout
        Me.pnlMovieImages.SuspendLayout
        Me.gbMovieImagesEFanarts.SuspendLayout
        CType(Me.tbMovieEFanartsQual,System.ComponentModel.ISupportInitialize).BeginInit
        Me.gbMovieImagesEThumbs.SuspendLayout
        CType(Me.tbMovieEThumbsQual,System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox9.SuspendLayout
        Me.gbMovieImagesFanart.SuspendLayout
        CType(Me.tbMovieFanartQual,System.ComponentModel.ISupportInitialize).BeginInit
        Me.gbMovieImagesPoster.SuspendLayout
        CType(Me.tbMoviePosterQual,System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox2.SuspendLayout
        Me.GroupBox25.SuspendLayout
        Me.pnlTop.SuspendLayout
        CType(Me.pbTopLogo,System.ComponentModel.ISupportInitialize).BeginInit
        Me.pnlGeneral.SuspendLayout
        Me.gbInterface.SuspendLayout
        Me.pnlMovieGeneral.SuspendLayout
        Me.GroupBox30.SuspendLayout
        Me.gbGenreFilter.SuspendLayout
        Me.gbFilters.SuspendLayout
        Me.GroupBox27.SuspendLayout
        Me.pnlExtensions.SuspendLayout
        Me.GroupBox22.SuspendLayout
        Me.GroupBox18.SuspendLayout
        Me.pnlProxy.SuspendLayout
        Me.gbProxy.SuspendLayout
        Me.gbCreds.SuspendLayout
        Me.gbMovieBackdropsFolder.SuspendLayout
        Me.Panel1.SuspendLayout
        CType(Me.pbCurrent,System.ComponentModel.ISupportInitialize).BeginInit
        Me.pnlMovieSources.SuspendLayout
        Me.gbMovieSetsFolder.SuspendLayout
        Me.gbMovieFileNaming.SuspendLayout
        Me.tbcMovieFileNaming.SuspendLayout
=======
        Me.gbGeneralMisc.SuspendLayout
        Me.gbGeneralDaemon.SuspendLayout
        Me.gbGeneralThemes.SuspendLayout
        Me.gbFileSystemCleanFiles.SuspendLayout
        Me.tcFileSystemCleaner.SuspendLayout
        Me.tpFileSystemCleanerStandard.SuspendLayout
        Me.tpFileSystemCleanerExpert.SuspendLayout
        Me.gbMovieGeneralMiscOpts.SuspendLayout
        Me.pnlMovieImages.SuspendLayout
        Me.gbMovieActorThumbsOpts.SuspendLayout
        Me.gbMovieClearArtOpts.SuspendLayout
        Me.gbMovieClearLogoOpts.SuspendLayout
        Me.gbMovieDiscArtOpts.SuspendLayout
        Me.gbMovieBannerOpts.SuspendLayout
        CType(Me.tbMovieBannerQual,System.ComponentModel.ISupportInitialize).BeginInit
        Me.gbMovieLandscapeOpts.SuspendLayout
        Me.gbMovieEFanartsOpts.SuspendLayout
        CType(Me.tbMovieEFanartsQual,System.ComponentModel.ISupportInitialize).BeginInit
        Me.gbMovieEThumbsOpts.SuspendLayout
        CType(Me.tbMovieEThumbsQual,System.ComponentModel.ISupportInitialize).BeginInit
        Me.gbMovieImagesOpts.SuspendLayout
        Me.gbMovieFanartOpts.SuspendLayout
        CType(Me.tbMovieFanartQual,System.ComponentModel.ISupportInitialize).BeginInit
        Me.gbMoviePosterOpts.SuspendLayout
        CType(Me.tbMoviePosterQual,System.ComponentModel.ISupportInitialize).BeginInit
        Me.gbMovieGeneralMediaListOpts.SuspendLayout
        Me.gbMovieSortTokensOpts.SuspendLayout
        Me.pnlSettingsTop.SuspendLayout
        CType(Me.pbSettingsTopLogo,System.ComponentModel.ISupportInitialize).BeginInit
        Me.pnlGeneral.SuspendLayout
        Me.gbGeneralInterface.SuspendLayout
        Me.pnlMovieGeneral.SuspendLayout
        Me.gbMovieGenrealIMDBMirrorOpts.SuspendLayout
        Me.gbMovieGeneralGenreFilterOpts.SuspendLayout
        Me.gbMovieGeneralFiltersOpts.SuspendLayout
        Me.gbMovieGeneralMissingItemsOpts.SuspendLayout
        Me.pnlFileSystem.SuspendLayout
        Me.gbFileSystemNoStackExts.SuspendLayout
        Me.gbFileSystemValidExts.SuspendLayout
        Me.pnlProxy.SuspendLayout
        Me.gbProxyOpts.SuspendLayout
        Me.gbProxyCredsOpts.SuspendLayout
        Me.gbMovieBackdropsFolder.SuspendLayout
        Me.pnlCurrent.SuspendLayout
        CType(Me.pbSettingsCurrent,System.ComponentModel.ISupportInitialize).BeginInit
        Me.pnlMovieSources.SuspendLayout
        Me.gbMovieSetsFolder.SuspendLayout
        Me.gbMovieFileNaming.SuspendLayout
        Me.tcMovieFileNaming.SuspendLayout
>>>>>>> upstream/master
        Me.tpMovieFileNamingXBMC.SuspendLayout
        Me.gbMovieXBMCOptional.SuspendLayout
        Me.gbMovieEden.SuspendLayout
        Me.gbMovieFrodo.SuspendLayout
        Me.tpMovieFileNamingNMT.SuspendLayout
        Me.gbMovieNMTOptional.SuspendLayout
        Me.gbMovieNMJ.SuspendLayout
        Me.gbMovieYAMJ.SuspendLayout
        Me.tpMovieFileNamingExpert.SuspendLayout
        Me.gbMovieExpert.SuspendLayout
<<<<<<< HEAD
        Me.tbcMovieFileNamingExpert.SuspendLayout
=======
        Me.tcMovieFileNamingExpert.SuspendLayout
>>>>>>> upstream/master
        Me.tpMovieFileNamingExpertSingle.SuspendLayout
        Me.gbMovieExpertSingleOptionalSettings.SuspendLayout
        Me.gbMovieExpertSingleOptionalImages.SuspendLayout
        Me.tpMovieFileNamingExpertMulti.SuspendLayout
        Me.gbMovieExpertMultiOptionalImages.SuspendLayout
        Me.gbMovieExpertMultiOptionalSettings.SuspendLayout
<<<<<<< HEAD
        Me.tbMovieFileNamingExpertVTS.SuspendLayout
        Me.gbMovieExpertVTSOptionalSettings.SuspendLayout
        Me.gbMovieExpertVTSOptionalImages.SuspendLayout
        Me.tbMovieFileNamingExpertBDMV.SuspendLayout
        Me.gbMovieExpertBDMVOptionalSettings.SuspendLayout
        Me.gbMovieExpertBDMVOptionalImages.SuspendLayout
        Me.gbMovieMiscOptions.SuspendLayout
        Me.pnlTVGeneral.SuspendLayout
        Me.gbTVListOptions.SuspendLayout
        Me.gbEpisodeListOptions.SuspendLayout
        Me.gbSeasonListOptions.SuspendLayout
        Me.gbShowListOptions.SuspendLayout
        Me.gbEpFilter.SuspendLayout
        Me.gbTVMisc.SuspendLayout
        Me.gbShowFilter.SuspendLayout
        Me.pnlTVSources.SuspendLayout
        Me.TabControl2.SuspendLayout
        Me.TabPage3.SuspendLayout
        Me.gbTVFileNaming.SuspendLayout
        Me.tbcTVFileNaming.SuspendLayout
        Me.tpTVFileNamingXBMC.SuspendLayout
        Me.gbTVXBMCAdditional.SuspendLayout
        Me.gbTVFrodo.SuspendLayout
        Me.gbMiscTVSourceOpts.SuspendLayout
        Me.TabPage4.SuspendLayout
        Me.gbShowRegex.SuspendLayout
        Me.pnlTVImages.SuspendLayout
        Me.TabControl3.SuspendLayout
        Me.TabPage5.SuspendLayout
        Me.gbAllSPosterOpts.SuspendLayout
        CType(Me.tbAllSPosterQual,System.ComponentModel.ISupportInitialize).BeginInit
        Me.gbShowPosterOpts.SuspendLayout
        CType(Me.tbShowPosterQual,System.ComponentModel.ISupportInitialize).BeginInit
        Me.gbShowFanartOpts.SuspendLayout
        CType(Me.tbShowFanartQual,System.ComponentModel.ISupportInitialize).BeginInit
        Me.TabPage6.SuspendLayout
        Me.gbSeaPosterOpts.SuspendLayout
        CType(Me.tbSeaPosterQual,System.ComponentModel.ISupportInitialize).BeginInit
        Me.gbSeaFanartOpts.SuspendLayout
        CType(Me.tbSeaFanartQual,System.ComponentModel.ISupportInitialize).BeginInit
        Me.TabPage7.SuspendLayout
        Me.gbEpPosterOpts.SuspendLayout
        CType(Me.tbEpPosterQual,System.ComponentModel.ISupportInitialize).BeginInit
        Me.gbEpFanartOpts.SuspendLayout
        CType(Me.tbEpFanartQual,System.ComponentModel.ISupportInitialize).BeginInit
        Me.pnlTVScraper.SuspendLayout
        Me.gbTVScraperDuration.SuspendLayout
        Me.GroupBox32.SuspendLayout
        Me.GroupBox35.SuspendLayout
        Me.GroupBox34.SuspendLayout
        Me.GroupBox33.SuspendLayout
        Me.gbEpLocks.SuspendLayout
        Me.gbShowLocks.SuspendLayout
        Me.GroupBox31.SuspendLayout
        Me.gbTVMIDefaults.SuspendLayout
        Me.gbTVScraperOptions.SuspendLayout
        Me.gbOptions.SuspendLayout
        Me.GroupBox26.SuspendLayout
        Me.GroupBox28.SuspendLayout
        Me.gbRTFormat.SuspendLayout
        Me.GroupBox10.SuspendLayout
        Me.GroupBox1.SuspendLayout
        Me.pnlMovieScraper.SuspendLayout
        Me.gbHelp.SuspendLayout
        CType(Me.PictureBox2,System.ComponentModel.ISupportInitialize).BeginInit
        Me.Panel2.SuspendLayout
        Me.pnlMovieTrailers.SuspendLayout
        Me.GroupBox15.SuspendLayout
        Me.SuspendLayout
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.gb_DAEMON)
        Me.GroupBox4.Controls.Add(Me.chkImagesGlassOverlay)
        Me.GroupBox4.Controls.Add(Me.chkNoDisplayFanartSmall)
        Me.GroupBox4.Controls.Add(Me.chkSpecialDateAdd)
        Me.GroupBox4.Controls.Add(Me.chkShowGenresText)
        Me.GroupBox4.Controls.Add(Me.chkSourceFromFolder)
        Me.GroupBox4.Controls.Add(Me.chkNoDisplayFanart)
        Me.GroupBox4.Controls.Add(Me.chkInfoPanelAnim)
        Me.GroupBox4.Controls.Add(Me.chkNoDisplayPoster)
        Me.GroupBox4.Controls.Add(Me.chkShowDims)
        Me.GroupBox4.Controls.Add(Me.chkUpdates)
        Me.GroupBox4.Controls.Add(Me.chkOverwriteNfo)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(210, 3)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(537, 494)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = false
        Me.GroupBox4.Text = "Miscellaneous"
        '
        'gb_DAEMON
        '
        Me.gb_DAEMON.Controls.Add(Me.lbl_DAEMON_driveletter)
        Me.gb_DAEMON.Controls.Add(Me.cbo_DAEMON_driveletter)
        Me.gb_DAEMON.Controls.Add(Me.bt_DAEMON_Programpath)
        Me.gb_DAEMON.Controls.Add(Me.txt_DAEMON_Programpath)
        Me.gb_DAEMON.Controls.Add(Me.lbl_DAEMON_Programpath)
        Me.gb_DAEMON.Location = New System.Drawing.Point(6, 256)
        Me.gb_DAEMON.Name = "gb_DAEMON"
        Me.gb_DAEMON.Size = New System.Drawing.Size(396, 122)
        Me.gb_DAEMON.TabIndex = 13
        Me.gb_DAEMON.TabStop = false
        Me.gb_DAEMON.Text = "DAEMON Tools"
        '
        'lbl_DAEMON_driveletter
        '
        Me.lbl_DAEMON_driveletter.AutoSize = true
        Me.lbl_DAEMON_driveletter.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.lbl_DAEMON_driveletter.Location = New System.Drawing.Point(7, 29)
        Me.lbl_DAEMON_driveletter.Name = "lbl_DAEMON_driveletter"
        Me.lbl_DAEMON_driveletter.Size = New System.Drawing.Size(63, 13)
        Me.lbl_DAEMON_driveletter.TabIndex = 6
        Me.lbl_DAEMON_driveletter.Text = "Driveletter:"
        '
        'cbo_DAEMON_driveletter
        '
        Me.cbo_DAEMON_driveletter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_DAEMON_driveletter.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.cbo_DAEMON_driveletter.FormattingEnabled = true
        Me.cbo_DAEMON_driveletter.Items.AddRange(New Object() {"", "A:\", "B:\", "D:\", "E:\", "F:\", "G:\", "H:\", "I:\", "J:\", "K:\", "L:\", "M:\", "N:\", "O:\", "P:\", "Q:\", "R:\", "S:\", "T:\", "U:\", "V:\", "W:\", "X:\", "Y:\", "Z:\"})
        Me.cbo_DAEMON_driveletter.Location = New System.Drawing.Point(77, 30)
        Me.cbo_DAEMON_driveletter.Name = "cbo_DAEMON_driveletter"
        Me.cbo_DAEMON_driveletter.Size = New System.Drawing.Size(48, 21)
        Me.cbo_DAEMON_driveletter.TabIndex = 7
        '
        'bt_DAEMON_Programpath
        '
        Me.bt_DAEMON_Programpath.Location = New System.Drawing.Point(259, 82)
        Me.bt_DAEMON_Programpath.Name = "bt_DAEMON_Programpath"
        Me.bt_DAEMON_Programpath.Size = New System.Drawing.Size(25, 23)
        Me.bt_DAEMON_Programpath.TabIndex = 4
        Me.bt_DAEMON_Programpath.Text = "..."
        Me.bt_DAEMON_Programpath.UseVisualStyleBackColor = true
        '
        'txt_DAEMON_Programpath
        '
        Me.txt_DAEMON_Programpath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_DAEMON_Programpath.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txt_DAEMON_Programpath.Location = New System.Drawing.Point(9, 82)
        Me.txt_DAEMON_Programpath.Name = "txt_DAEMON_Programpath"
        Me.txt_DAEMON_Programpath.Size = New System.Drawing.Size(241, 22)
        Me.txt_DAEMON_Programpath.TabIndex = 3
        '
        'lbl_DAEMON_Programpath
        '
        Me.lbl_DAEMON_Programpath.AutoSize = true
        Me.lbl_DAEMON_Programpath.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lbl_DAEMON_Programpath.Location = New System.Drawing.Point(6, 68)
        Me.lbl_DAEMON_Programpath.Name = "lbl_DAEMON_Programpath"
        Me.lbl_DAEMON_Programpath.Size = New System.Drawing.Size(136, 13)
        Me.lbl_DAEMON_Programpath.TabIndex = 2
        Me.lbl_DAEMON_Programpath.Text = ".EXE path (i.e. DTLite.exe):"
        '
        'chkImagesGlassOverlay
        '
        Me.chkImagesGlassOverlay.AutoSize = true
        Me.chkImagesGlassOverlay.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkImagesGlassOverlay.Location = New System.Drawing.Point(10, 233)
        Me.chkImagesGlassOverlay.Name = "chkImagesGlassOverlay"
        Me.chkImagesGlassOverlay.Size = New System.Drawing.Size(171, 17)
        Me.chkImagesGlassOverlay.TabIndex = 12
        Me.chkImagesGlassOverlay.Text = "Enable Images Glass Overlay"
        Me.chkImagesGlassOverlay.UseVisualStyleBackColor = true
        '
        'chkNoDisplayFanartSmall
        '
        Me.chkNoDisplayFanartSmall.AutoSize = true
        Me.chkNoDisplayFanartSmall.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkNoDisplayFanartSmall.Location = New System.Drawing.Point(10, 210)
        Me.chkNoDisplayFanartSmall.Name = "chkNoDisplayFanartSmall"
        Me.chkNoDisplayFanartSmall.Size = New System.Drawing.Size(169, 17)
        Me.chkNoDisplayFanartSmall.TabIndex = 11
        Me.chkNoDisplayFanartSmall.Text = "Do Not Display Small Fanart"
        Me.chkNoDisplayFanartSmall.UseVisualStyleBackColor = true
        '
        'chkSpecialDateAdd
        '
        Me.chkSpecialDateAdd.AutoSize = true
        Me.chkSpecialDateAdd.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkSpecialDateAdd.Location = New System.Drawing.Point(10, 195)
        Me.chkSpecialDateAdd.Name = "chkSpecialDateAdd"
        Me.chkSpecialDateAdd.Size = New System.Drawing.Size(196, 17)
        Me.chkSpecialDateAdd.TabIndex = 10
        Me.chkSpecialDateAdd.Text = "Use file creation date of videofile"
        Me.chkSpecialDateAdd.UseVisualStyleBackColor = true
        '
        'chkShowGenresText
        '
        Me.chkShowGenresText.AutoSize = true
        Me.chkShowGenresText.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkShowGenresText.Location = New System.Drawing.Point(10, 178)
        Me.chkShowGenresText.Name = "chkShowGenresText"
        Me.chkShowGenresText.Size = New System.Drawing.Size(166, 17)
        Me.chkShowGenresText.TabIndex = 9
        Me.chkShowGenresText.Text = "Allways Display Genres Text"
        Me.chkShowGenresText.UseVisualStyleBackColor = true
        '
        'chkSourceFromFolder
        '
        Me.chkSourceFromFolder.AutoSize = true
        Me.chkSourceFromFolder.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkSourceFromFolder.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkSourceFromFolder.Location = New System.Drawing.Point(10, 110)
        Me.chkSourceFromFolder.Name = "chkSourceFromFolder"
        Me.chkSourceFromFolder.Size = New System.Drawing.Size(243, 17)
        Me.chkSourceFromFolder.TabIndex = 5
        Me.chkSourceFromFolder.Text = "Include Folder Name in Source Type Check"
        Me.chkSourceFromFolder.UseVisualStyleBackColor = true
        '
        'chkNoDisplayFanart
        '
        Me.chkNoDisplayFanart.AutoSize = true
        Me.chkNoDisplayFanart.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkNoDisplayFanart.Location = New System.Drawing.Point(10, 144)
        Me.chkNoDisplayFanart.Name = "chkNoDisplayFanart"
        Me.chkNoDisplayFanart.Size = New System.Drawing.Size(139, 17)
        Me.chkNoDisplayFanart.TabIndex = 7
        Me.chkNoDisplayFanart.Text = "Do Not Display Fanart"
        Me.chkNoDisplayFanart.UseVisualStyleBackColor = true
        '
        'chkInfoPanelAnim
        '
        Me.chkInfoPanelAnim.AutoSize = true
        Me.chkInfoPanelAnim.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkInfoPanelAnim.Location = New System.Drawing.Point(10, 94)
        Me.chkInfoPanelAnim.Name = "chkInfoPanelAnim"
        Me.chkInfoPanelAnim.Size = New System.Drawing.Size(148, 17)
        Me.chkInfoPanelAnim.TabIndex = 4
        Me.chkInfoPanelAnim.Text = "Enable Panel Animation"
        Me.chkInfoPanelAnim.UseVisualStyleBackColor = true
        '
        'chkNoDisplayPoster
        '
        Me.chkNoDisplayPoster.AutoSize = true
        Me.chkNoDisplayPoster.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkNoDisplayPoster.Location = New System.Drawing.Point(10, 127)
        Me.chkNoDisplayPoster.Name = "chkNoDisplayPoster"
        Me.chkNoDisplayPoster.Size = New System.Drawing.Size(138, 17)
        Me.chkNoDisplayPoster.TabIndex = 6
        Me.chkNoDisplayPoster.Text = "Do Not Display Poster"
        Me.chkNoDisplayPoster.UseVisualStyleBackColor = true
        '
        'chkShowDims
        '
        Me.chkShowDims.AutoSize = true
        Me.chkShowDims.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkShowDims.Location = New System.Drawing.Point(10, 161)
        Me.chkShowDims.Name = "chkShowDims"
        Me.chkShowDims.Size = New System.Drawing.Size(160, 17)
        Me.chkShowDims.TabIndex = 8
        Me.chkShowDims.Text = "Display Image Dimensions"
        Me.chkShowDims.UseVisualStyleBackColor = true
        '
        'chkUpdates
        '
        Me.chkUpdates.AutoSize = true
        Me.chkUpdates.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkUpdates.Location = New System.Drawing.Point(10, 20)
        Me.chkUpdates.Name = "chkUpdates"
        Me.chkUpdates.Size = New System.Drawing.Size(121, 17)
        Me.chkUpdates.TabIndex = 0
        Me.chkUpdates.Text = "Check for Updates"
        Me.chkUpdates.UseVisualStyleBackColor = true
        '
        'chkOverwriteNfo
        '
        Me.chkOverwriteNfo.AutoSize = true
        Me.chkOverwriteNfo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkOverwriteNfo.Location = New System.Drawing.Point(10, 54)
        Me.chkOverwriteNfo.Name = "chkOverwriteNfo"
        Me.chkOverwriteNfo.Size = New System.Drawing.Size(191, 17)
        Me.chkOverwriteNfo.TabIndex = 2
        Me.chkOverwriteNfo.Text = "Overwrite Non-conforming nfos"
        Me.chkOverwriteNfo.UseVisualStyleBackColor = true
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label5.Location = New System.Drawing.Point(20, 68)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(165, 24)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "(If unchecked, non-conforming nfos will be renamed to <filename>.info)"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox29
        '
        Me.GroupBox29.Controls.Add(Me.cbEpTheme)
        Me.GroupBox29.Controls.Add(Me.Label3)
        Me.GroupBox29.Controls.Add(Me.cbTVShowTheme)
        Me.GroupBox29.Controls.Add(Me.Label1)
        Me.GroupBox29.Controls.Add(Me.cbMovieTheme)
        Me.GroupBox29.Controls.Add(Me.Label35)
        Me.GroupBox29.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.GroupBox29.Location = New System.Drawing.Point(8, 61)
        Me.GroupBox29.Name = "GroupBox29"
        Me.GroupBox29.Size = New System.Drawing.Size(179, 166)
        Me.GroupBox29.TabIndex = 2
        Me.GroupBox29.TabStop = false
        Me.GroupBox29.Text = "Themes"
        '
        'cbEpTheme
        '
        Me.cbEpTheme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEpTheme.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.cbEpTheme.FormattingEnabled = true
        Me.cbEpTheme.Location = New System.Drawing.Point(9, 129)
        Me.cbEpTheme.Name = "cbEpTheme"
        Me.cbEpTheme.Size = New System.Drawing.Size(162, 21)
        Me.cbEpTheme.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label3.Location = New System.Drawing.Point(7, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Episode Theme:"
        '
        'cbTVShowTheme
        '
        Me.cbTVShowTheme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTVShowTheme.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.cbTVShowTheme.FormattingEnabled = true
        Me.cbTVShowTheme.Location = New System.Drawing.Point(9, 83)
        Me.cbTVShowTheme.Name = "cbTVShowTheme"
        Me.cbTVShowTheme.Size = New System.Drawing.Size(162, 21)
        Me.cbTVShowTheme.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "TV Show Theme:"
        '
        'cbMovieTheme
        '
        Me.cbMovieTheme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMovieTheme.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.cbMovieTheme.FormattingEnabled = true
        Me.cbMovieTheme.Location = New System.Drawing.Point(9, 38)
        Me.cbMovieTheme.Name = "cbMovieTheme"
        Me.cbMovieTheme.Size = New System.Drawing.Size(162, 21)
        Me.cbMovieTheme.TabIndex = 1
        '
        'Label35
        '
        Me.Label35.AutoSize = true
        Me.Label35.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label35.Location = New System.Drawing.Point(7, 23)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(77, 13)
        Me.Label35.TabIndex = 0
        Me.Label35.Text = "Movie Theme:"
        '
        'Label32
        '
        Me.Label32.AutoSize = true
        Me.Label32.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label32.Location = New System.Drawing.Point(6, 18)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(109, 13)
        Me.Label32.TabIndex = 0
        Me.Label32.Text = "Interface Language:"
        '
        'cbIntLang
        '
        Me.cbIntLang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbIntLang.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.cbIntLang.FormattingEnabled = true
        Me.cbIntLang.Location = New System.Drawing.Point(9, 34)
        Me.cbIntLang.Name = "cbIntLang"
        Me.cbIntLang.Size = New System.Drawing.Size(137, 21)
        Me.cbIntLang.TabIndex = 1
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.tcCleaner)
        Me.GroupBox3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(401, 6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(208, 385)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = false
        Me.GroupBox3.Text = "Clean Files"
        '
        'tcCleaner
        '
        Me.tcCleaner.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.tcCleaner.Controls.Add(Me.tpStandard)
        Me.tcCleaner.Controls.Add(Me.tpExpert)
        Me.tcCleaner.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.tcCleaner.Location = New System.Drawing.Point(6, 19)
        Me.tcCleaner.Name = "tcCleaner"
        Me.tcCleaner.SelectedIndex = 0
        Me.tcCleaner.Size = New System.Drawing.Size(196, 363)
        Me.tcCleaner.TabIndex = 0
        '
        'tpStandard
        '
        Me.tpStandard.BackColor = System.Drawing.Color.White
        Me.tpStandard.Controls.Add(Me.chkCleanFolderJPG)
        Me.tpStandard.Controls.Add(Me.chkCleanExtrathumbs)
        Me.tpStandard.Controls.Add(Me.chkCleanMovieTBN)
        Me.tpStandard.Controls.Add(Me.chkCleanMovieNameJPG)
        Me.tpStandard.Controls.Add(Me.chkCleanMovieTBNb)
        Me.tpStandard.Controls.Add(Me.chkCleanMovieJPG)
        Me.tpStandard.Controls.Add(Me.chkCleanFanartJPG)
        Me.tpStandard.Controls.Add(Me.chkCleanPosterJPG)
        Me.tpStandard.Controls.Add(Me.chkCleanMovieFanartJPG)
        Me.tpStandard.Controls.Add(Me.chkCleanPosterTBN)
        Me.tpStandard.Controls.Add(Me.chkCleanMovieNFO)
        Me.tpStandard.Controls.Add(Me.chkCleanDotFanartJPG)
        Me.tpStandard.Controls.Add(Me.chkCleanMovieNFOb)
        Me.tpStandard.Location = New System.Drawing.Point(4, 25)
        Me.tpStandard.Name = "tpStandard"
        Me.tpStandard.Padding = New System.Windows.Forms.Padding(3)
        Me.tpStandard.Size = New System.Drawing.Size(188, 334)
        Me.tpStandard.TabIndex = 0
        Me.tpStandard.Text = "Standard"
        Me.tpStandard.UseVisualStyleBackColor = true
=======
        Me.tpMovieFileNamingExpertVTS.SuspendLayout
        Me.gbMovieExpertVTSOptionalSettings.SuspendLayout
        Me.gbMovieExpertVTSOptionalImages.SuspendLayout
        Me.tpMovieFileNamingExpertBDMV.SuspendLayout
        Me.gbMovieExpertBDMVOptionalSettings.SuspendLayout
        Me.gbMovieExpertBDMVOptionalImages.SuspendLayout
        Me.gbMovieMiscOpts.SuspendLayout
        Me.pnlTVGeneral.SuspendLayout
        Me.gbTVGeneralMediaListOpts.SuspendLayout
        Me.gbTVGeneralListEpisodeOpts.SuspendLayout
        Me.gbTVGeneralListSeasonOpts.SuspendLayout
        Me.gbTVGeneralListShowOpts.SuspendLayout
        Me.gbTVEpisodeFilterOpts.SuspendLayout
        Me.gbTVGeneralMiscOpts.SuspendLayout
        Me.gbTVShowFilterOpts.SuspendLayout
        Me.pnlTVSources.SuspendLayout
        Me.tcTVSources.SuspendLayout
        Me.tpTVSourcesGeneral.SuspendLayout
        Me.gbTVFileNaming.SuspendLayout
        Me.tcTVFileNaming.SuspendLayout
        Me.tpTVFileNamingXBMC.SuspendLayout
        Me.gbTVXBMCAdditional.SuspendLayout
        Me.gbTVFrodo.SuspendLayout
        Me.tpTVFileNamingNMT.SuspendLayout
        Me.gbTVNMT.SuspendLayout
        Me.gbTVYAMJ.SuspendLayout
        Me.gbTVSourcesMiscOpts.SuspendLayout
        Me.tpTVSourcesRegex.SuspendLayout
        Me.gbTVShowRegex.SuspendLayout
        Me.pnlTVImages.SuspendLayout
        Me.tcTVImages.SuspendLayout
        Me.tpTVShow.SuspendLayout
        Me.gbTVShowCharacterArtOpts.SuspendLayout
        Me.gbTVShowClearArtOpts.SuspendLayout
        Me.gbTVShowClearLogoOpts.SuspendLayout
        Me.gbTVShowLandscapeOpts.SuspendLayout
        Me.gbTVShowBannerOpts.SuspendLayout
        CType(Me.tbTVShowBannerQual,System.ComponentModel.ISupportInitialize).BeginInit
        Me.gbTVShowPosterOpts.SuspendLayout
        CType(Me.tbTVShowPosterQual,System.ComponentModel.ISupportInitialize).BeginInit
        Me.gbTVShowFanartOpts.SuspendLayout
        CType(Me.tbTVShowFanartQual,System.ComponentModel.ISupportInitialize).BeginInit
        Me.tpTVAllSeasons.SuspendLayout
        Me.gbTVASLandscapeOpts.SuspendLayout
        Me.gbTVASFanartOpts.SuspendLayout
        CType(Me.tbTVASFanartQual,System.ComponentModel.ISupportInitialize).BeginInit
        Me.gbTVASBannerOpts.SuspendLayout
        CType(Me.tbTVASBannerQual,System.ComponentModel.ISupportInitialize).BeginInit
        Me.gbTVASPosterOpts.SuspendLayout
        CType(Me.tbTVASPosterQual,System.ComponentModel.ISupportInitialize).BeginInit
        Me.tpTVSeason.SuspendLayout
        Me.gbTVSeasonLandscapeOpts.SuspendLayout
        Me.gbTVSeasonBannerOpts.SuspendLayout
        CType(Me.tbTVSeasonBannerQual,System.ComponentModel.ISupportInitialize).BeginInit
        Me.gbTVSeasonPosterOpts.SuspendLayout
        CType(Me.tbTVSeasonPosterQual,System.ComponentModel.ISupportInitialize).BeginInit
        Me.gbTVSeasonFanartOpts.SuspendLayout
        CType(Me.tbTVSeasonFanartQual,System.ComponentModel.ISupportInitialize).BeginInit
        Me.tpTVEpisode.SuspendLayout
        Me.gbTVEpisodePosterOpts.SuspendLayout
        CType(Me.tbTVEpisodePosterQual,System.ComponentModel.ISupportInitialize).BeginInit
        Me.gbTVEpisodeFanartOpts.SuspendLayout
        CType(Me.tbTVEpisodeFanartQual,System.ComponentModel.ISupportInitialize).BeginInit
        Me.pnlTVScraper.SuspendLayout
        Me.gbTVScraperDurationOpts.SuspendLayout
        Me.gbTVScraperFieldsOpts.SuspendLayout
        Me.gbTVScraperFieldsShowOpts.SuspendLayout
        Me.gbTVScraperFieldsEpisodeOpts.SuspendLayout
        Me.gbTVScraperGlobalLocksOpts.SuspendLayout
        Me.gbTVScraperGlobalLocksEpisodeOpts.SuspendLayout
        Me.gbTVScraperGlobalLocksShowOpts.SuspendLayout
        Me.gbTVScraperMetaDataOpts.SuspendLayout
        Me.gbTVScraperDefFIExtOpts.SuspendLayout
        Me.gbTVScraperOptionsOpts.SuspendLayout
        Me.gbMovieScraperFieldsOpts.SuspendLayout
        Me.gbMovieScraperMetaDataOpts.SuspendLayout
        Me.gbMovieScraperDefFIExtOpts.SuspendLayout
        Me.gbMovieScraperDurationFormatOpts.SuspendLayout
        Me.gbMovieScraperGlobalLocksOpts.SuspendLayout
        Me.gbMovieScraperMiscOpts.SuspendLayout
        Me.pnlMovieScraper.SuspendLayout
        Me.gbSettingsHelp.SuspendLayout
        CType(Me.pbSettingsHelpLogo,System.ComponentModel.ISupportInitialize).BeginInit
        Me.pnlSettingsHelp.SuspendLayout
        Me.pnlMovieTrailers.SuspendLayout
        Me.gbMovieTrailerOpts.SuspendLayout
        Me.SuspendLayout
        '
        'gbGeneralMisc
        '
        Me.gbGeneralMisc.Controls.Add(Me.gbGeneralDaemon)
        Me.gbGeneralMisc.Controls.Add(Me.chkGeneralImagesGlassOverlay)
        Me.gbGeneralMisc.Controls.Add(Me.chkGeneralHideFanartSmall)
        Me.gbGeneralMisc.Controls.Add(Me.chkGeneralCreationDate)
        Me.gbGeneralMisc.Controls.Add(Me.chkGeneralShowGenresText)
        Me.gbGeneralMisc.Controls.Add(Me.chkGeneralSourceFromFolder)
        Me.gbGeneralMisc.Controls.Add(Me.chkGeneralHideFanart)
        Me.gbGeneralMisc.Controls.Add(Me.chkGeneralInfoPanelAnim)
        Me.gbGeneralMisc.Controls.Add(Me.chkGeneralHidePoster)
        Me.gbGeneralMisc.Controls.Add(Me.chkGeneralShowImgDims)
        Me.gbGeneralMisc.Controls.Add(Me.chkGeneralCheckUpdates)
        Me.gbGeneralMisc.Controls.Add(Me.chkGeneralOverwriteNfo)
        Me.gbGeneralMisc.Controls.Add(Me.lblGeneralOverwriteNfo)
        Me.gbGeneralMisc.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.gbGeneralMisc.Location = New System.Drawing.Point(210, 3)
        Me.gbGeneralMisc.Name = "gbGeneralMisc"
        Me.gbGeneralMisc.Size = New System.Drawing.Size(537, 494)
        Me.gbGeneralMisc.TabIndex = 1
        Me.gbGeneralMisc.TabStop = false
        Me.gbGeneralMisc.Text = "Miscellaneous"
        '
        'gbGeneralDaemon
        '
        Me.gbGeneralDaemon.Controls.Add(Me.lblGeneralDaemonDrive)
        Me.gbGeneralDaemon.Controls.Add(Me.cbGeneralDaemonDrive)
        Me.gbGeneralDaemon.Controls.Add(Me.btnGeneralDaemonPathBrowse)
        Me.gbGeneralDaemon.Controls.Add(Me.txtGeneralDaemonPath)
        Me.gbGeneralDaemon.Controls.Add(Me.lblGeneralDaemonPath)
        Me.gbGeneralDaemon.Location = New System.Drawing.Point(6, 256)
        Me.gbGeneralDaemon.Name = "gbGeneralDaemon"
        Me.gbGeneralDaemon.Size = New System.Drawing.Size(396, 122)
        Me.gbGeneralDaemon.TabIndex = 13
        Me.gbGeneralDaemon.TabStop = false
        Me.gbGeneralDaemon.Text = "DAEMON Tools"
        '
        'lblGeneralDaemonDrive
        '
        Me.lblGeneralDaemonDrive.AutoSize = true
        Me.lblGeneralDaemonDrive.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.lblGeneralDaemonDrive.Location = New System.Drawing.Point(7, 29)
        Me.lblGeneralDaemonDrive.Name = "lblGeneralDaemonDrive"
        Me.lblGeneralDaemonDrive.Size = New System.Drawing.Size(63, 13)
        Me.lblGeneralDaemonDrive.TabIndex = 6
        Me.lblGeneralDaemonDrive.Text = "Driveletter:"
        '
        'cbGeneralDaemonDrive
        '
        Me.cbGeneralDaemonDrive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbGeneralDaemonDrive.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.cbGeneralDaemonDrive.FormattingEnabled = true
        Me.cbGeneralDaemonDrive.Items.AddRange(New Object() {"", "A:\", "B:\", "D:\", "E:\", "F:\", "G:\", "H:\", "I:\", "J:\", "K:\", "L:\", "M:\", "N:\", "O:\", "P:\", "Q:\", "R:\", "S:\", "T:\", "U:\", "V:\", "W:\", "X:\", "Y:\", "Z:\"})
        Me.cbGeneralDaemonDrive.Location = New System.Drawing.Point(77, 30)
        Me.cbGeneralDaemonDrive.Name = "cbGeneralDaemonDrive"
        Me.cbGeneralDaemonDrive.Size = New System.Drawing.Size(48, 21)
        Me.cbGeneralDaemonDrive.TabIndex = 7
        '
        'btnGeneralDaemonPathBrowse
        '
        Me.btnGeneralDaemonPathBrowse.Location = New System.Drawing.Point(259, 82)
        Me.btnGeneralDaemonPathBrowse.Name = "btnGeneralDaemonPathBrowse"
        Me.btnGeneralDaemonPathBrowse.Size = New System.Drawing.Size(25, 23)
        Me.btnGeneralDaemonPathBrowse.TabIndex = 4
        Me.btnGeneralDaemonPathBrowse.Text = "..."
        Me.btnGeneralDaemonPathBrowse.UseVisualStyleBackColor = true
        '
        'txtGeneralDaemonPath
        '
        Me.txtGeneralDaemonPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGeneralDaemonPath.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtGeneralDaemonPath.Location = New System.Drawing.Point(9, 82)
        Me.txtGeneralDaemonPath.Name = "txtGeneralDaemonPath"
        Me.txtGeneralDaemonPath.Size = New System.Drawing.Size(241, 22)
        Me.txtGeneralDaemonPath.TabIndex = 3
        '
        'lblGeneralDaemonPath
        '
        Me.lblGeneralDaemonPath.AutoSize = true
        Me.lblGeneralDaemonPath.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblGeneralDaemonPath.Location = New System.Drawing.Point(6, 68)
        Me.lblGeneralDaemonPath.Name = "lblGeneralDaemonPath"
        Me.lblGeneralDaemonPath.Size = New System.Drawing.Size(136, 13)
        Me.lblGeneralDaemonPath.TabIndex = 2
        Me.lblGeneralDaemonPath.Text = ".EXE path (i.e. DTLite.exe):"
        '
        'chkGeneralImagesGlassOverlay
        '
        Me.chkGeneralImagesGlassOverlay.AutoSize = true
        Me.chkGeneralImagesGlassOverlay.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkGeneralImagesGlassOverlay.Location = New System.Drawing.Point(10, 233)
        Me.chkGeneralImagesGlassOverlay.Name = "chkGeneralImagesGlassOverlay"
        Me.chkGeneralImagesGlassOverlay.Size = New System.Drawing.Size(171, 17)
        Me.chkGeneralImagesGlassOverlay.TabIndex = 12
        Me.chkGeneralImagesGlassOverlay.Text = "Enable Images Glass Overlay"
        Me.chkGeneralImagesGlassOverlay.UseVisualStyleBackColor = true
        '
        'chkGeneralHideFanartSmall
        '
        Me.chkGeneralHideFanartSmall.AutoSize = true
        Me.chkGeneralHideFanartSmall.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkGeneralHideFanartSmall.Location = New System.Drawing.Point(10, 210)
        Me.chkGeneralHideFanartSmall.Name = "chkGeneralHideFanartSmall"
        Me.chkGeneralHideFanartSmall.Size = New System.Drawing.Size(169, 17)
        Me.chkGeneralHideFanartSmall.TabIndex = 11
        Me.chkGeneralHideFanartSmall.Text = "Do Not Display Small Fanart"
        Me.chkGeneralHideFanartSmall.UseVisualStyleBackColor = true
        '
        'chkGeneralCreationDate
        '
        Me.chkGeneralCreationDate.AutoSize = true
        Me.chkGeneralCreationDate.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkGeneralCreationDate.Location = New System.Drawing.Point(10, 195)
        Me.chkGeneralCreationDate.Name = "chkGeneralCreationDate"
        Me.chkGeneralCreationDate.Size = New System.Drawing.Size(196, 17)
        Me.chkGeneralCreationDate.TabIndex = 10
        Me.chkGeneralCreationDate.Text = "Use file creation date of videofile"
        Me.chkGeneralCreationDate.UseVisualStyleBackColor = true
        '
        'chkGeneralShowGenresText
        '
        Me.chkGeneralShowGenresText.AutoSize = true
        Me.chkGeneralShowGenresText.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkGeneralShowGenresText.Location = New System.Drawing.Point(10, 178)
        Me.chkGeneralShowGenresText.Name = "chkGeneralShowGenresText"
        Me.chkGeneralShowGenresText.Size = New System.Drawing.Size(166, 17)
        Me.chkGeneralShowGenresText.TabIndex = 9
        Me.chkGeneralShowGenresText.Text = "Allways Display Genres Text"
        Me.chkGeneralShowGenresText.UseVisualStyleBackColor = true
        '
        'chkGeneralSourceFromFolder
        '
        Me.chkGeneralSourceFromFolder.AutoSize = true
        Me.chkGeneralSourceFromFolder.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkGeneralSourceFromFolder.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkGeneralSourceFromFolder.Location = New System.Drawing.Point(10, 110)
        Me.chkGeneralSourceFromFolder.Name = "chkGeneralSourceFromFolder"
        Me.chkGeneralSourceFromFolder.Size = New System.Drawing.Size(243, 17)
        Me.chkGeneralSourceFromFolder.TabIndex = 5
        Me.chkGeneralSourceFromFolder.Text = "Include Folder Name in Source Type Check"
        Me.chkGeneralSourceFromFolder.UseVisualStyleBackColor = true
        '
        'chkGeneralHideFanart
        '
        Me.chkGeneralHideFanart.AutoSize = true
        Me.chkGeneralHideFanart.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkGeneralHideFanart.Location = New System.Drawing.Point(10, 144)
        Me.chkGeneralHideFanart.Name = "chkGeneralHideFanart"
        Me.chkGeneralHideFanart.Size = New System.Drawing.Size(139, 17)
        Me.chkGeneralHideFanart.TabIndex = 7
        Me.chkGeneralHideFanart.Text = "Do Not Display Fanart"
        Me.chkGeneralHideFanart.UseVisualStyleBackColor = true
        '
        'chkGeneralInfoPanelAnim
        '
        Me.chkGeneralInfoPanelAnim.AutoSize = true
        Me.chkGeneralInfoPanelAnim.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkGeneralInfoPanelAnim.Location = New System.Drawing.Point(10, 94)
        Me.chkGeneralInfoPanelAnim.Name = "chkGeneralInfoPanelAnim"
        Me.chkGeneralInfoPanelAnim.Size = New System.Drawing.Size(148, 17)
        Me.chkGeneralInfoPanelAnim.TabIndex = 4
        Me.chkGeneralInfoPanelAnim.Text = "Enable Panel Animation"
        Me.chkGeneralInfoPanelAnim.UseVisualStyleBackColor = true
        '
        'chkGeneralHidePoster
        '
        Me.chkGeneralHidePoster.AutoSize = true
        Me.chkGeneralHidePoster.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkGeneralHidePoster.Location = New System.Drawing.Point(10, 127)
        Me.chkGeneralHidePoster.Name = "chkGeneralHidePoster"
        Me.chkGeneralHidePoster.Size = New System.Drawing.Size(138, 17)
        Me.chkGeneralHidePoster.TabIndex = 6
        Me.chkGeneralHidePoster.Text = "Do Not Display Poster"
        Me.chkGeneralHidePoster.UseVisualStyleBackColor = true
        '
        'chkGeneralShowImgDims
        '
        Me.chkGeneralShowImgDims.AutoSize = true
        Me.chkGeneralShowImgDims.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkGeneralShowImgDims.Location = New System.Drawing.Point(10, 161)
        Me.chkGeneralShowImgDims.Name = "chkGeneralShowImgDims"
        Me.chkGeneralShowImgDims.Size = New System.Drawing.Size(160, 17)
        Me.chkGeneralShowImgDims.TabIndex = 8
        Me.chkGeneralShowImgDims.Text = "Display Image Dimensions"
        Me.chkGeneralShowImgDims.UseVisualStyleBackColor = true
        '
        'chkGeneralCheckUpdates
        '
        Me.chkGeneralCheckUpdates.AutoSize = true
        Me.chkGeneralCheckUpdates.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkGeneralCheckUpdates.Location = New System.Drawing.Point(10, 20)
        Me.chkGeneralCheckUpdates.Name = "chkGeneralCheckUpdates"
        Me.chkGeneralCheckUpdates.Size = New System.Drawing.Size(121, 17)
        Me.chkGeneralCheckUpdates.TabIndex = 0
        Me.chkGeneralCheckUpdates.Text = "Check for Updates"
        Me.chkGeneralCheckUpdates.UseVisualStyleBackColor = true
        '
        'chkGeneralOverwriteNfo
        '
        Me.chkGeneralOverwriteNfo.AutoSize = true
        Me.chkGeneralOverwriteNfo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkGeneralOverwriteNfo.Location = New System.Drawing.Point(10, 54)
        Me.chkGeneralOverwriteNfo.Name = "chkGeneralOverwriteNfo"
        Me.chkGeneralOverwriteNfo.Size = New System.Drawing.Size(191, 17)
        Me.chkGeneralOverwriteNfo.TabIndex = 2
        Me.chkGeneralOverwriteNfo.Text = "Overwrite Non-conforming nfos"
        Me.chkGeneralOverwriteNfo.UseVisualStyleBackColor = true
        '
        'lblGeneralOverwriteNfo
        '
        Me.lblGeneralOverwriteNfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblGeneralOverwriteNfo.Location = New System.Drawing.Point(20, 68)
        Me.lblGeneralOverwriteNfo.Name = "lblGeneralOverwriteNfo"
        Me.lblGeneralOverwriteNfo.Size = New System.Drawing.Size(165, 24)
        Me.lblGeneralOverwriteNfo.TabIndex = 3
        Me.lblGeneralOverwriteNfo.Text = "(If unchecked, non-conforming nfos will be renamed to <filename>.info)"
        Me.lblGeneralOverwriteNfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gbGeneralThemes
        '
        Me.gbGeneralThemes.Controls.Add(Me.cbGeneralTVEpisodeTheme)
        Me.gbGeneralThemes.Controls.Add(Me.lblGeneralTVEpisodeTheme)
        Me.gbGeneralThemes.Controls.Add(Me.cbGeneralTVShowTheme)
        Me.gbGeneralThemes.Controls.Add(Me.lblGeneralTVShowTheme)
        Me.gbGeneralThemes.Controls.Add(Me.cbGeneralMovieTheme)
        Me.gbGeneralThemes.Controls.Add(Me.lblGeneralMovieTheme)
        Me.gbGeneralThemes.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.gbGeneralThemes.Location = New System.Drawing.Point(8, 61)
        Me.gbGeneralThemes.Name = "gbGeneralThemes"
        Me.gbGeneralThemes.Size = New System.Drawing.Size(179, 166)
        Me.gbGeneralThemes.TabIndex = 2
        Me.gbGeneralThemes.TabStop = false
        Me.gbGeneralThemes.Text = "Themes"
        '
        'cbGeneralTVEpisodeTheme
        '
        Me.cbGeneralTVEpisodeTheme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbGeneralTVEpisodeTheme.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.cbGeneralTVEpisodeTheme.FormattingEnabled = true
        Me.cbGeneralTVEpisodeTheme.Location = New System.Drawing.Point(9, 129)
        Me.cbGeneralTVEpisodeTheme.Name = "cbGeneralTVEpisodeTheme"
        Me.cbGeneralTVEpisodeTheme.Size = New System.Drawing.Size(162, 21)
        Me.cbGeneralTVEpisodeTheme.TabIndex = 5
        '
        'lblGeneralTVEpisodeTheme
        '
        Me.lblGeneralTVEpisodeTheme.AutoSize = true
        Me.lblGeneralTVEpisodeTheme.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblGeneralTVEpisodeTheme.Location = New System.Drawing.Point(7, 114)
        Me.lblGeneralTVEpisodeTheme.Name = "lblGeneralTVEpisodeTheme"
        Me.lblGeneralTVEpisodeTheme.Size = New System.Drawing.Size(87, 13)
        Me.lblGeneralTVEpisodeTheme.TabIndex = 4
        Me.lblGeneralTVEpisodeTheme.Text = "Episode Theme:"
        '
        'cbGeneralTVShowTheme
        '
        Me.cbGeneralTVShowTheme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbGeneralTVShowTheme.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.cbGeneralTVShowTheme.FormattingEnabled = true
        Me.cbGeneralTVShowTheme.Location = New System.Drawing.Point(9, 83)
        Me.cbGeneralTVShowTheme.Name = "cbGeneralTVShowTheme"
        Me.cbGeneralTVShowTheme.Size = New System.Drawing.Size(162, 21)
        Me.cbGeneralTVShowTheme.TabIndex = 3
        '
        'lblGeneralTVShowTheme
        '
        Me.lblGeneralTVShowTheme.AutoSize = true
        Me.lblGeneralTVShowTheme.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblGeneralTVShowTheme.Location = New System.Drawing.Point(7, 68)
        Me.lblGeneralTVShowTheme.Name = "lblGeneralTVShowTheme"
        Me.lblGeneralTVShowTheme.Size = New System.Drawing.Size(90, 13)
        Me.lblGeneralTVShowTheme.TabIndex = 2
        Me.lblGeneralTVShowTheme.Text = "TV Show Theme:"
        '
        'cbGeneralMovieTheme
        '
        Me.cbGeneralMovieTheme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbGeneralMovieTheme.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.cbGeneralMovieTheme.FormattingEnabled = true
        Me.cbGeneralMovieTheme.Location = New System.Drawing.Point(9, 38)
        Me.cbGeneralMovieTheme.Name = "cbGeneralMovieTheme"
        Me.cbGeneralMovieTheme.Size = New System.Drawing.Size(162, 21)
        Me.cbGeneralMovieTheme.TabIndex = 1
        '
        'lblGeneralMovieTheme
        '
        Me.lblGeneralMovieTheme.AutoSize = true
        Me.lblGeneralMovieTheme.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblGeneralMovieTheme.Location = New System.Drawing.Point(7, 23)
        Me.lblGeneralMovieTheme.Name = "lblGeneralMovieTheme"
        Me.lblGeneralMovieTheme.Size = New System.Drawing.Size(77, 13)
        Me.lblGeneralMovieTheme.TabIndex = 0
        Me.lblGeneralMovieTheme.Text = "Movie Theme:"
        '
        'lblGeneralntLang
        '
        Me.lblGeneralntLang.AutoSize = true
        Me.lblGeneralntLang.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblGeneralntLang.Location = New System.Drawing.Point(6, 18)
        Me.lblGeneralntLang.Name = "lblGeneralntLang"
        Me.lblGeneralntLang.Size = New System.Drawing.Size(109, 13)
        Me.lblGeneralntLang.TabIndex = 0
        Me.lblGeneralntLang.Text = "Interface Language:"
        '
        'cbGeneralLanguage
        '
        Me.cbGeneralLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbGeneralLanguage.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.cbGeneralLanguage.FormattingEnabled = true
        Me.cbGeneralLanguage.Location = New System.Drawing.Point(9, 34)
        Me.cbGeneralLanguage.Name = "cbGeneralLanguage"
        Me.cbGeneralLanguage.Size = New System.Drawing.Size(137, 21)
        Me.cbGeneralLanguage.TabIndex = 1
        '
        'gbFileSystemCleanFiles
        '
        Me.gbFileSystemCleanFiles.Controls.Add(Me.tcFileSystemCleaner)
        Me.gbFileSystemCleanFiles.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.gbFileSystemCleanFiles.Location = New System.Drawing.Point(401, 6)
        Me.gbFileSystemCleanFiles.Name = "gbFileSystemCleanFiles"
        Me.gbFileSystemCleanFiles.Size = New System.Drawing.Size(208, 385)
        Me.gbFileSystemCleanFiles.TabIndex = 2
        Me.gbFileSystemCleanFiles.TabStop = false
        Me.gbFileSystemCleanFiles.Text = "Clean Files"
        '
        'tcFileSystemCleaner
        '
        Me.tcFileSystemCleaner.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.tcFileSystemCleaner.Controls.Add(Me.tpFileSystemCleanerStandard)
        Me.tcFileSystemCleaner.Controls.Add(Me.tpFileSystemCleanerExpert)
        Me.tcFileSystemCleaner.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.tcFileSystemCleaner.Location = New System.Drawing.Point(6, 19)
        Me.tcFileSystemCleaner.Name = "tcFileSystemCleaner"
        Me.tcFileSystemCleaner.SelectedIndex = 0
        Me.tcFileSystemCleaner.Size = New System.Drawing.Size(196, 363)
        Me.tcFileSystemCleaner.TabIndex = 0
        '
        'tpFileSystemCleanerStandard
        '
        Me.tpFileSystemCleanerStandard.BackColor = System.Drawing.Color.White
        Me.tpFileSystemCleanerStandard.Controls.Add(Me.chkCleanFolderJPG)
        Me.tpFileSystemCleanerStandard.Controls.Add(Me.chkCleanExtrathumbs)
        Me.tpFileSystemCleanerStandard.Controls.Add(Me.chkCleanMovieTBN)
        Me.tpFileSystemCleanerStandard.Controls.Add(Me.chkCleanMovieNameJPG)
        Me.tpFileSystemCleanerStandard.Controls.Add(Me.chkCleanMovieTBNb)
        Me.tpFileSystemCleanerStandard.Controls.Add(Me.chkCleanMovieJPG)
        Me.tpFileSystemCleanerStandard.Controls.Add(Me.chkCleanFanartJPG)
        Me.tpFileSystemCleanerStandard.Controls.Add(Me.chkCleanPosterJPG)
        Me.tpFileSystemCleanerStandard.Controls.Add(Me.chkCleanMovieFanartJPG)
        Me.tpFileSystemCleanerStandard.Controls.Add(Me.chkCleanPosterTBN)
        Me.tpFileSystemCleanerStandard.Controls.Add(Me.chkCleanMovieNFO)
        Me.tpFileSystemCleanerStandard.Controls.Add(Me.chkCleanDotFanartJPG)
        Me.tpFileSystemCleanerStandard.Controls.Add(Me.chkCleanMovieNFOb)
        Me.tpFileSystemCleanerStandard.Location = New System.Drawing.Point(4, 25)
        Me.tpFileSystemCleanerStandard.Name = "tpFileSystemCleanerStandard"
        Me.tpFileSystemCleanerStandard.Padding = New System.Windows.Forms.Padding(3)
        Me.tpFileSystemCleanerStandard.Size = New System.Drawing.Size(188, 334)
        Me.tpFileSystemCleanerStandard.TabIndex = 0
        Me.tpFileSystemCleanerStandard.Text = "Standard"
        Me.tpFileSystemCleanerStandard.UseVisualStyleBackColor = true
>>>>>>> upstream/master
        '
        'chkCleanFolderJPG
        '
        Me.chkCleanFolderJPG.AutoSize = true
        Me.chkCleanFolderJPG.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkCleanFolderJPG.Location = New System.Drawing.Point(7, 10)
        Me.chkCleanFolderJPG.Name = "chkCleanFolderJPG"
        Me.chkCleanFolderJPG.Size = New System.Drawing.Size(81, 17)
        Me.chkCleanFolderJPG.TabIndex = 0
        Me.chkCleanFolderJPG.Text = "/folder.jpg"
        Me.chkCleanFolderJPG.UseVisualStyleBackColor = true
        '
        'chkCleanExtrathumbs
        '
        Me.chkCleanExtrathumbs.AutoSize = true
        Me.chkCleanExtrathumbs.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkCleanExtrathumbs.Location = New System.Drawing.Point(7, 238)
        Me.chkCleanExtrathumbs.Name = "chkCleanExtrathumbs"
        Me.chkCleanExtrathumbs.Size = New System.Drawing.Size(98, 17)
        Me.chkCleanExtrathumbs.TabIndex = 12
        Me.chkCleanExtrathumbs.Text = "/extrathumbs/"
        Me.chkCleanExtrathumbs.UseVisualStyleBackColor = true
        '
        'chkCleanMovieTBN
        '
        Me.chkCleanMovieTBN.AutoSize = true
        Me.chkCleanMovieTBN.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkCleanMovieTBN.Location = New System.Drawing.Point(7, 29)
        Me.chkCleanMovieTBN.Name = "chkCleanMovieTBN"
        Me.chkCleanMovieTBN.Size = New System.Drawing.Size(81, 17)
        Me.chkCleanMovieTBN.TabIndex = 1
        Me.chkCleanMovieTBN.Text = "/movie.tbn"
        Me.chkCleanMovieTBN.UseVisualStyleBackColor = true
        '
        'chkCleanMovieNameJPG
        '
        Me.chkCleanMovieNameJPG.AutoSize = true
        Me.chkCleanMovieNameJPG.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkCleanMovieNameJPG.Location = New System.Drawing.Point(7, 124)
        Me.chkCleanMovieNameJPG.Name = "chkCleanMovieNameJPG"
        Me.chkCleanMovieNameJPG.Size = New System.Drawing.Size(96, 17)
        Me.chkCleanMovieNameJPG.TabIndex = 6
        Me.chkCleanMovieNameJPG.Text = "/<movie>.jpg"
        Me.chkCleanMovieNameJPG.UseVisualStyleBackColor = true
        '
        'chkCleanMovieTBNb
        '
        Me.chkCleanMovieTBNb.AutoSize = true
        Me.chkCleanMovieTBNb.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkCleanMovieTBNb.Location = New System.Drawing.Point(7, 48)
        Me.chkCleanMovieTBNb.Name = "chkCleanMovieTBNb"
        Me.chkCleanMovieTBNb.Size = New System.Drawing.Size(97, 17)
        Me.chkCleanMovieTBNb.TabIndex = 2
        Me.chkCleanMovieTBNb.Text = "/<movie>.tbn"
        Me.chkCleanMovieTBNb.UseVisualStyleBackColor = true
        '
        'chkCleanMovieJPG
        '
        Me.chkCleanMovieJPG.AutoSize = true
        Me.chkCleanMovieJPG.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkCleanMovieJPG.Location = New System.Drawing.Point(7, 105)
        Me.chkCleanMovieJPG.Name = "chkCleanMovieJPG"
        Me.chkCleanMovieJPG.Size = New System.Drawing.Size(80, 17)
        Me.chkCleanMovieJPG.TabIndex = 5
        Me.chkCleanMovieJPG.Text = "/movie.jpg"
        Me.chkCleanMovieJPG.UseVisualStyleBackColor = true
        '
        'chkCleanFanartJPG
        '
        Me.chkCleanFanartJPG.AutoSize = true
        Me.chkCleanFanartJPG.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkCleanFanartJPG.Location = New System.Drawing.Point(7, 143)
        Me.chkCleanFanartJPG.Name = "chkCleanFanartJPG"
        Me.chkCleanFanartJPG.Size = New System.Drawing.Size(81, 17)
        Me.chkCleanFanartJPG.TabIndex = 7
        Me.chkCleanFanartJPG.Text = "/fanart.jpg"
        Me.chkCleanFanartJPG.UseVisualStyleBackColor = true
        '
        'chkCleanPosterJPG
        '
        Me.chkCleanPosterJPG.AutoSize = true
        Me.chkCleanPosterJPG.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkCleanPosterJPG.Location = New System.Drawing.Point(7, 86)
        Me.chkCleanPosterJPG.Name = "chkCleanPosterJPG"
        Me.chkCleanPosterJPG.Size = New System.Drawing.Size(83, 17)
        Me.chkCleanPosterJPG.TabIndex = 4
        Me.chkCleanPosterJPG.Text = "/poster.jpg"
        Me.chkCleanPosterJPG.UseVisualStyleBackColor = true
        '
        'chkCleanMovieFanartJPG
        '
        Me.chkCleanMovieFanartJPG.AutoSize = true
        Me.chkCleanMovieFanartJPG.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkCleanMovieFanartJPG.Location = New System.Drawing.Point(7, 162)
        Me.chkCleanMovieFanartJPG.Name = "chkCleanMovieFanartJPG"
        Me.chkCleanMovieFanartJPG.Size = New System.Drawing.Size(131, 17)
        Me.chkCleanMovieFanartJPG.TabIndex = 8
        Me.chkCleanMovieFanartJPG.Text = "/<movie>-fanart.jpg"
        Me.chkCleanMovieFanartJPG.UseVisualStyleBackColor = true
        '
        'chkCleanPosterTBN
        '
        Me.chkCleanPosterTBN.AutoSize = true
        Me.chkCleanPosterTBN.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkCleanPosterTBN.Location = New System.Drawing.Point(7, 67)
        Me.chkCleanPosterTBN.Name = "chkCleanPosterTBN"
        Me.chkCleanPosterTBN.Size = New System.Drawing.Size(84, 17)
        Me.chkCleanPosterTBN.TabIndex = 3
        Me.chkCleanPosterTBN.Text = "/poster.tbn"
        Me.chkCleanPosterTBN.UseVisualStyleBackColor = true
        '
        'chkCleanMovieNFO
        '
        Me.chkCleanMovieNFO.AutoSize = true
        Me.chkCleanMovieNFO.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkCleanMovieNFO.Location = New System.Drawing.Point(7, 200)
        Me.chkCleanMovieNFO.Name = "chkCleanMovieNFO"
        Me.chkCleanMovieNFO.Size = New System.Drawing.Size(81, 17)
        Me.chkCleanMovieNFO.TabIndex = 10
        Me.chkCleanMovieNFO.Text = "/movie.nfo"
        Me.chkCleanMovieNFO.UseVisualStyleBackColor = true
        '
        'chkCleanDotFanartJPG
        '
        Me.chkCleanDotFanartJPG.AutoSize = true
        Me.chkCleanDotFanartJPG.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkCleanDotFanartJPG.Location = New System.Drawing.Point(7, 181)
        Me.chkCleanDotFanartJPG.Name = "chkCleanDotFanartJPG"
        Me.chkCleanDotFanartJPG.Size = New System.Drawing.Size(130, 17)
        Me.chkCleanDotFanartJPG.TabIndex = 9
        Me.chkCleanDotFanartJPG.Text = "/<movie>.fanart.jpg"
        Me.chkCleanDotFanartJPG.UseVisualStyleBackColor = true
        '
        'chkCleanMovieNFOb
        '
        Me.chkCleanMovieNFOb.AutoSize = true
        Me.chkCleanMovieNFOb.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkCleanMovieNFOb.Location = New System.Drawing.Point(7, 219)
        Me.chkCleanMovieNFOb.Name = "chkCleanMovieNFOb"
        Me.chkCleanMovieNFOb.Size = New System.Drawing.Size(97, 17)
        Me.chkCleanMovieNFOb.TabIndex = 11
        Me.chkCleanMovieNFOb.Text = "/<movie>.nfo"
        Me.chkCleanMovieNFOb.UseVisualStyleBackColor = true
        '
<<<<<<< HEAD
        'tpExpert
        '
        Me.tpExpert.BackColor = System.Drawing.Color.White
        Me.tpExpert.Controls.Add(Me.chkWhitelistVideo)
        Me.tpExpert.Controls.Add(Me.Label27)
        Me.tpExpert.Controls.Add(Me.btnRemoveWhitelist)
        Me.tpExpert.Controls.Add(Me.btnAddWhitelist)
        Me.tpExpert.Controls.Add(Me.txtWhitelist)
        Me.tpExpert.Controls.Add(Me.lstWhitelist)
        Me.tpExpert.Controls.Add(Me.Label25)
        Me.tpExpert.Location = New System.Drawing.Point(4, 25)
        Me.tpExpert.Name = "tpExpert"
        Me.tpExpert.Padding = New System.Windows.Forms.Padding(3)
        Me.tpExpert.Size = New System.Drawing.Size(188, 334)
        Me.tpExpert.TabIndex = 1
        Me.tpExpert.Text = "Expert"
        Me.tpExpert.UseVisualStyleBackColor = true
        '
        'chkWhitelistVideo
        '
        Me.chkWhitelistVideo.AutoSize = true
        Me.chkWhitelistVideo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkWhitelistVideo.Location = New System.Drawing.Point(4, 85)
        Me.chkWhitelistVideo.Name = "chkWhitelistVideo"
        Me.chkWhitelistVideo.Size = New System.Drawing.Size(163, 17)
        Me.chkWhitelistVideo.TabIndex = 1
        Me.chkWhitelistVideo.Text = "Whitelist Video Extensions"
        Me.chkWhitelistVideo.UseVisualStyleBackColor = true
        '
        'Label27
        '
        Me.Label27.AutoSize = true
        Me.Label27.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label27.Location = New System.Drawing.Point(19, 107)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(127, 13)
        Me.Label27.TabIndex = 2
        Me.Label27.Text = "Whitelisted Extensions:"
        '
        'btnRemoveWhitelist
        '
        Me.btnRemoveWhitelist.Image = CType(resources.GetObject("btnRemoveWhitelist.Image"),System.Drawing.Image)
        Me.btnRemoveWhitelist.Location = New System.Drawing.Point(134, 251)
        Me.btnRemoveWhitelist.Name = "btnRemoveWhitelist"
        Me.btnRemoveWhitelist.Size = New System.Drawing.Size(23, 23)
        Me.btnRemoveWhitelist.TabIndex = 6
        Me.btnRemoveWhitelist.UseVisualStyleBackColor = true
        '
        'btnAddWhitelist
        '
        Me.btnAddWhitelist.Image = CType(resources.GetObject("btnAddWhitelist.Image"),System.Drawing.Image)
        Me.btnAddWhitelist.Location = New System.Drawing.Point(82, 251)
        Me.btnAddWhitelist.Name = "btnAddWhitelist"
        Me.btnAddWhitelist.Size = New System.Drawing.Size(23, 23)
        Me.btnAddWhitelist.TabIndex = 5
        Me.btnAddWhitelist.UseVisualStyleBackColor = true
        '
        'txtWhitelist
        '
        Me.txtWhitelist.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtWhitelist.Location = New System.Drawing.Point(20, 252)
        Me.txtWhitelist.Name = "txtWhitelist"
        Me.txtWhitelist.Size = New System.Drawing.Size(61, 22)
        Me.txtWhitelist.TabIndex = 4
        '
        'lstWhitelist
        '
        Me.lstWhitelist.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.lstWhitelist.FormattingEnabled = true
        Me.lstWhitelist.Location = New System.Drawing.Point(19, 126)
        Me.lstWhitelist.Name = "lstWhitelist"
        Me.lstWhitelist.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lstWhitelist.Size = New System.Drawing.Size(138, 108)
        Me.lstWhitelist.TabIndex = 3
        '
        'Label25
        '
        Me.Label25.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Red
        Me.Label25.Location = New System.Drawing.Point(12, 10)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(155, 68)
        Me.Label25.TabIndex = 0
        Me.Label25.Text = "WARNING: Using the Expert Mode Cleaner could potentially delete wanted files. Tak"& _ 
    "e care when using this tool."
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox12
        '
        Me.GroupBox12.Controls.Add(Me.chkClickScrape)
        Me.GroupBox12.Controls.Add(Me.chkAskCheckboxScrape)
        Me.GroupBox12.Controls.Add(Me.chkMarkNew)
        Me.GroupBox12.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.GroupBox12.Location = New System.Drawing.Point(6, 7)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Size = New System.Drawing.Size(219, 93)
        Me.GroupBox12.TabIndex = 1
        Me.GroupBox12.TabStop = false
        Me.GroupBox12.Text = "Miscellaneous"
        '
        'chkClickScrape
        '
        Me.chkClickScrape.AutoSize = true
        Me.chkClickScrape.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.chkClickScrape.Location = New System.Drawing.Point(12, 36)
        Me.chkClickScrape.Name = "chkClickScrape"
        Me.chkClickScrape.Size = New System.Drawing.Size(125, 17)
        Me.chkClickScrape.TabIndex = 65
        Me.chkClickScrape.Text = "Enable Click Scrape"
        Me.chkClickScrape.UseVisualStyleBackColor = true
        '
        'chkAskCheckboxScrape
        '
        Me.chkAskCheckboxScrape.AutoSize = true
        Me.chkAskCheckboxScrape.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.chkAskCheckboxScrape.Location = New System.Drawing.Point(25, 56)
        Me.chkAskCheckboxScrape.Name = "chkAskCheckboxScrape"
        Me.chkAskCheckboxScrape.Size = New System.Drawing.Size(127, 17)
        Me.chkAskCheckboxScrape.TabIndex = 64
        Me.chkAskCheckboxScrape.Text = "Ask On Click Scrape"
        Me.chkAskCheckboxScrape.UseVisualStyleBackColor = true
        '
        'chkMarkNew
        '
        Me.chkMarkNew.AutoSize = true
        Me.chkMarkNew.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkMarkNew.Location = New System.Drawing.Point(12, 14)
        Me.chkMarkNew.Name = "chkMarkNew"
        Me.chkMarkNew.Size = New System.Drawing.Size(117, 17)
        Me.chkMarkNew.TabIndex = 0
        Me.chkMarkNew.Text = "Mark New Movies"
        Me.chkMarkNew.UseVisualStyleBackColor = true
=======
        'tpFileSystemCleanerExpert
        '
        Me.tpFileSystemCleanerExpert.BackColor = System.Drawing.Color.White
        Me.tpFileSystemCleanerExpert.Controls.Add(Me.chkFileSystemCleanerWhitelist)
        Me.tpFileSystemCleanerExpert.Controls.Add(Me.lblFileSystemCleanerWhitelist)
        Me.tpFileSystemCleanerExpert.Controls.Add(Me.btnFileSystemCleanerWhitelistRemove)
        Me.tpFileSystemCleanerExpert.Controls.Add(Me.btnFileSystemCleanerWhitelistAdd)
        Me.tpFileSystemCleanerExpert.Controls.Add(Me.txtFileSystemCleanerWhitelist)
        Me.tpFileSystemCleanerExpert.Controls.Add(Me.lstFileSystemCleanerWhitelist)
        Me.tpFileSystemCleanerExpert.Controls.Add(Me.lblFileSystemCleanerWarning)
        Me.tpFileSystemCleanerExpert.Location = New System.Drawing.Point(4, 25)
        Me.tpFileSystemCleanerExpert.Name = "tpFileSystemCleanerExpert"
        Me.tpFileSystemCleanerExpert.Padding = New System.Windows.Forms.Padding(3)
        Me.tpFileSystemCleanerExpert.Size = New System.Drawing.Size(188, 334)
        Me.tpFileSystemCleanerExpert.TabIndex = 1
        Me.tpFileSystemCleanerExpert.Text = "Expert"
        Me.tpFileSystemCleanerExpert.UseVisualStyleBackColor = true
        '
        'chkFileSystemCleanerWhitelist
        '
        Me.chkFileSystemCleanerWhitelist.AutoSize = true
        Me.chkFileSystemCleanerWhitelist.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkFileSystemCleanerWhitelist.Location = New System.Drawing.Point(4, 85)
        Me.chkFileSystemCleanerWhitelist.Name = "chkFileSystemCleanerWhitelist"
        Me.chkFileSystemCleanerWhitelist.Size = New System.Drawing.Size(163, 17)
        Me.chkFileSystemCleanerWhitelist.TabIndex = 1
        Me.chkFileSystemCleanerWhitelist.Text = "Whitelist Video Extensions"
        Me.chkFileSystemCleanerWhitelist.UseVisualStyleBackColor = true
        '
        'lblFileSystemCleanerWhitelist
        '
        Me.lblFileSystemCleanerWhitelist.AutoSize = true
        Me.lblFileSystemCleanerWhitelist.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblFileSystemCleanerWhitelist.Location = New System.Drawing.Point(19, 107)
        Me.lblFileSystemCleanerWhitelist.Name = "lblFileSystemCleanerWhitelist"
        Me.lblFileSystemCleanerWhitelist.Size = New System.Drawing.Size(127, 13)
        Me.lblFileSystemCleanerWhitelist.TabIndex = 2
        Me.lblFileSystemCleanerWhitelist.Text = "Whitelisted Extensions:"
        '
        'btnFileSystemCleanerWhitelistRemove
        '
        Me.btnFileSystemCleanerWhitelistRemove.Image = CType(resources.GetObject("btnFileSystemCleanerWhitelistRemove.Image"),System.Drawing.Image)
        Me.btnFileSystemCleanerWhitelistRemove.Location = New System.Drawing.Point(134, 251)
        Me.btnFileSystemCleanerWhitelistRemove.Name = "btnFileSystemCleanerWhitelistRemove"
        Me.btnFileSystemCleanerWhitelistRemove.Size = New System.Drawing.Size(23, 23)
        Me.btnFileSystemCleanerWhitelistRemove.TabIndex = 6
        Me.btnFileSystemCleanerWhitelistRemove.UseVisualStyleBackColor = true
        '
        'btnFileSystemCleanerWhitelistAdd
        '
        Me.btnFileSystemCleanerWhitelistAdd.Image = CType(resources.GetObject("btnFileSystemCleanerWhitelistAdd.Image"),System.Drawing.Image)
        Me.btnFileSystemCleanerWhitelistAdd.Location = New System.Drawing.Point(82, 251)
        Me.btnFileSystemCleanerWhitelistAdd.Name = "btnFileSystemCleanerWhitelistAdd"
        Me.btnFileSystemCleanerWhitelistAdd.Size = New System.Drawing.Size(23, 23)
        Me.btnFileSystemCleanerWhitelistAdd.TabIndex = 5
        Me.btnFileSystemCleanerWhitelistAdd.UseVisualStyleBackColor = true
        '
        'txtFileSystemCleanerWhitelist
        '
        Me.txtFileSystemCleanerWhitelist.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtFileSystemCleanerWhitelist.Location = New System.Drawing.Point(20, 252)
        Me.txtFileSystemCleanerWhitelist.Name = "txtFileSystemCleanerWhitelist"
        Me.txtFileSystemCleanerWhitelist.Size = New System.Drawing.Size(61, 22)
        Me.txtFileSystemCleanerWhitelist.TabIndex = 4
        '
        'lstFileSystemCleanerWhitelist
        '
        Me.lstFileSystemCleanerWhitelist.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.lstFileSystemCleanerWhitelist.FormattingEnabled = true
        Me.lstFileSystemCleanerWhitelist.Location = New System.Drawing.Point(19, 126)
        Me.lstFileSystemCleanerWhitelist.Name = "lstFileSystemCleanerWhitelist"
        Me.lstFileSystemCleanerWhitelist.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lstFileSystemCleanerWhitelist.Size = New System.Drawing.Size(138, 108)
        Me.lstFileSystemCleanerWhitelist.TabIndex = 3
        '
        'lblFileSystemCleanerWarning
        '
        Me.lblFileSystemCleanerWarning.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.lblFileSystemCleanerWarning.ForeColor = System.Drawing.Color.Red
        Me.lblFileSystemCleanerWarning.Location = New System.Drawing.Point(12, 10)
        Me.lblFileSystemCleanerWarning.Name = "lblFileSystemCleanerWarning"
        Me.lblFileSystemCleanerWarning.Size = New System.Drawing.Size(155, 68)
        Me.lblFileSystemCleanerWarning.TabIndex = 0
        Me.lblFileSystemCleanerWarning.Text = "WARNING: Using the Expert Mode Cleaner could potentially delete wanted files. Tak"& _ 
    "e care when using this tool."
        Me.lblFileSystemCleanerWarning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gbMovieGeneralMiscOpts
        '
        Me.gbMovieGeneralMiscOpts.Controls.Add(Me.chkMovieClickScrape)
        Me.gbMovieGeneralMiscOpts.Controls.Add(Me.chkMovieClickScrapeAsk)
        Me.gbMovieGeneralMiscOpts.Controls.Add(Me.chkMovieGeneralMarkNew)
        Me.gbMovieGeneralMiscOpts.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.gbMovieGeneralMiscOpts.Location = New System.Drawing.Point(3, 3)
        Me.gbMovieGeneralMiscOpts.Name = "gbMovieGeneralMiscOpts"
        Me.gbMovieGeneralMiscOpts.Size = New System.Drawing.Size(219, 93)
        Me.gbMovieGeneralMiscOpts.TabIndex = 1
        Me.gbMovieGeneralMiscOpts.TabStop = false
        Me.gbMovieGeneralMiscOpts.Text = "Miscellaneous"
        '
        'chkMovieClickScrape
        '
        Me.chkMovieClickScrape.AutoSize = true
        Me.chkMovieClickScrape.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.chkMovieClickScrape.Location = New System.Drawing.Point(12, 36)
        Me.chkMovieClickScrape.Name = "chkMovieClickScrape"
        Me.chkMovieClickScrape.Size = New System.Drawing.Size(125, 17)
        Me.chkMovieClickScrape.TabIndex = 65
        Me.chkMovieClickScrape.Text = "Enable Click Scrape"
        Me.chkMovieClickScrape.UseVisualStyleBackColor = true
        '
        'chkMovieClickScrapeAsk
        '
        Me.chkMovieClickScrapeAsk.AutoSize = true
        Me.chkMovieClickScrapeAsk.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.chkMovieClickScrapeAsk.Location = New System.Drawing.Point(25, 56)
        Me.chkMovieClickScrapeAsk.Name = "chkMovieClickScrapeAsk"
        Me.chkMovieClickScrapeAsk.Size = New System.Drawing.Size(127, 17)
        Me.chkMovieClickScrapeAsk.TabIndex = 64
        Me.chkMovieClickScrapeAsk.Text = "Ask On Click Scrape"
        Me.chkMovieClickScrapeAsk.UseVisualStyleBackColor = true
        '
        'chkMovieGeneralMarkNew
        '
        Me.chkMovieGeneralMarkNew.AutoSize = true
        Me.chkMovieGeneralMarkNew.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkMovieGeneralMarkNew.Location = New System.Drawing.Point(12, 14)
        Me.chkMovieGeneralMarkNew.Name = "chkMovieGeneralMarkNew"
        Me.chkMovieGeneralMarkNew.Size = New System.Drawing.Size(117, 17)
        Me.chkMovieGeneralMarkNew.TabIndex = 0
        Me.chkMovieGeneralMarkNew.Text = "Mark New Movies"
        Me.chkMovieGeneralMarkNew.UseVisualStyleBackColor = true
>>>>>>> upstream/master
        '
        'pnlMovieImages
        '
        Me.pnlMovieImages.BackColor = System.Drawing.Color.White
<<<<<<< HEAD
        Me.pnlMovieImages.Controls.Add(Me.gbMovieImagesEFanarts)
        Me.pnlMovieImages.Controls.Add(Me.gbMovieImagesEThumbs)
        Me.pnlMovieImages.Controls.Add(Me.GroupBox9)
        Me.pnlMovieImages.Controls.Add(Me.gbMovieImagesFanart)
        Me.pnlMovieImages.Controls.Add(Me.gbMovieImagesPoster)
        Me.pnlMovieImages.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.pnlMovieImages.Location = New System.Drawing.Point(1250, 470)
=======
        Me.pnlMovieImages.Controls.Add(Me.gbMovieActorThumbsOpts)
        Me.pnlMovieImages.Controls.Add(Me.gbMovieClearArtOpts)
        Me.pnlMovieImages.Controls.Add(Me.gbMovieClearLogoOpts)
        Me.pnlMovieImages.Controls.Add(Me.gbMovieDiscArtOpts)
        Me.pnlMovieImages.Controls.Add(Me.gbMovieBannerOpts)
        Me.pnlMovieImages.Controls.Add(Me.gbMovieLandscapeOpts)
        Me.pnlMovieImages.Controls.Add(Me.gbMovieEFanartsOpts)
        Me.pnlMovieImages.Controls.Add(Me.gbMovieEThumbsOpts)
        Me.pnlMovieImages.Controls.Add(Me.gbMovieImagesOpts)
        Me.pnlMovieImages.Controls.Add(Me.gbMovieFanartOpts)
        Me.pnlMovieImages.Controls.Add(Me.gbMoviePosterOpts)
        Me.pnlMovieImages.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.pnlMovieImages.Location = New System.Drawing.Point(900, 900)
>>>>>>> upstream/master
        Me.pnlMovieImages.Name = "pnlMovieImages"
        Me.pnlMovieImages.Size = New System.Drawing.Size(750, 500)
        Me.pnlMovieImages.TabIndex = 12
        Me.pnlMovieImages.Visible = false
        '
<<<<<<< HEAD
        'gbMovieImagesEFanarts
        '
        Me.gbMovieImagesEFanarts.Controls.Add(Me.chkMovieEFanartsOnly)
        Me.gbMovieImagesEFanarts.Controls.Add(Me.txtMovieEFanartsWidth)
        Me.gbMovieImagesEFanarts.Controls.Add(Me.txtMovieEFanartsHeight)
        Me.gbMovieImagesEFanarts.Controls.Add(Me.lblMovieEFanartsQual)
        Me.gbMovieImagesEFanarts.Controls.Add(Me.tbMovieEFanartsQual)
        Me.gbMovieImagesEFanarts.Controls.Add(Me.Label22)
        Me.gbMovieImagesEFanarts.Controls.Add(Me.Label23)
        Me.gbMovieImagesEFanarts.Controls.Add(Me.Label28)
        Me.gbMovieImagesEFanarts.Controls.Add(Me.chkMovieResizeEFanarts)
        Me.gbMovieImagesEFanarts.Controls.Add(Me.Label29)
        Me.gbMovieImagesEFanarts.Controls.Add(Me.cbMovieEFanartsSize)
        Me.gbMovieImagesEFanarts.Controls.Add(Me.chkMovieOverwriteEFanarts)
        Me.gbMovieImagesEFanarts.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.gbMovieImagesEFanarts.Location = New System.Drawing.Point(229, 259)
        Me.gbMovieImagesEFanarts.Name = "gbMovieImagesEFanarts"
        Me.gbMovieImagesEFanarts.Size = New System.Drawing.Size(218, 170)
        Me.gbMovieImagesEFanarts.TabIndex = 13
        Me.gbMovieImagesEFanarts.TabStop = false
        Me.gbMovieImagesEFanarts.Text = "Extrafanarts"
        '
        'chkMovieEFanartsOnly
        '
        Me.chkMovieEFanartsOnly.AutoSize = true
        Me.chkMovieEFanartsOnly.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkMovieEFanartsOnly.Location = New System.Drawing.Point(163, 38)
        Me.chkMovieEFanartsOnly.Name = "chkMovieEFanartsOnly"
        Me.chkMovieEFanartsOnly.Size = New System.Drawing.Size(50, 17)
        Me.chkMovieEFanartsOnly.TabIndex = 2
        Me.chkMovieEFanartsOnly.Text = "Only"
        Me.chkMovieEFanartsOnly.UseVisualStyleBackColor = true
=======
        'gbMovieActorThumbsOpts
        '
        Me.gbMovieActorThumbsOpts.Controls.Add(Me.chkMovieActorThumbsOverwrite)
        Me.gbMovieActorThumbsOpts.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.gbMovieActorThumbsOpts.Location = New System.Drawing.Point(451, 260)
        Me.gbMovieActorThumbsOpts.Name = "gbMovieActorThumbsOpts"
        Me.gbMovieActorThumbsOpts.Size = New System.Drawing.Size(218, 44)
        Me.gbMovieActorThumbsOpts.TabIndex = 16
        Me.gbMovieActorThumbsOpts.TabStop = false
        Me.gbMovieActorThumbsOpts.Text = "Actor Thumbs"
        '
        'chkMovieActorThumbsOverwrite
        '
        Me.chkMovieActorThumbsOverwrite.AutoSize = true
        Me.chkMovieActorThumbsOverwrite.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkMovieActorThumbsOverwrite.Location = New System.Drawing.Point(6, 21)
        Me.chkMovieActorThumbsOverwrite.Name = "chkMovieActorThumbsOverwrite"
        Me.chkMovieActorThumbsOverwrite.Size = New System.Drawing.Size(119, 17)
        Me.chkMovieActorThumbsOverwrite.TabIndex = 4
        Me.chkMovieActorThumbsOverwrite.Text = "Overwrite Existing"
        Me.chkMovieActorThumbsOverwrite.UseVisualStyleBackColor = true
        '
        'gbMovieClearArtOpts
        '
        Me.gbMovieClearArtOpts.Controls.Add(Me.chkMovieClearArtOverwrite)
        Me.gbMovieClearArtOpts.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.gbMovieClearArtOpts.Location = New System.Drawing.Point(3, 436)
        Me.gbMovieClearArtOpts.Name = "gbMovieClearArtOpts"
        Me.gbMovieClearArtOpts.Size = New System.Drawing.Size(218, 44)
        Me.gbMovieClearArtOpts.TabIndex = 15
        Me.gbMovieClearArtOpts.TabStop = false
        Me.gbMovieClearArtOpts.Text = "ClearArt"
        '
        'chkMovieClearArtOverwrite
        '
        Me.chkMovieClearArtOverwrite.AutoSize = true
        Me.chkMovieClearArtOverwrite.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkMovieClearArtOverwrite.Location = New System.Drawing.Point(6, 21)
        Me.chkMovieClearArtOverwrite.Name = "chkMovieClearArtOverwrite"
        Me.chkMovieClearArtOverwrite.Size = New System.Drawing.Size(119, 17)
        Me.chkMovieClearArtOverwrite.TabIndex = 4
        Me.chkMovieClearArtOverwrite.Text = "Overwrite Existing"
        Me.chkMovieClearArtOverwrite.UseVisualStyleBackColor = true
        '
        'gbMovieClearLogoOpts
        '
        Me.gbMovieClearLogoOpts.Controls.Add(Me.chkMovieClearLogoOverwrite)
        Me.gbMovieClearLogoOpts.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.gbMovieClearLogoOpts.Location = New System.Drawing.Point(227, 436)
        Me.gbMovieClearLogoOpts.Name = "gbMovieClearLogoOpts"
        Me.gbMovieClearLogoOpts.Size = New System.Drawing.Size(218, 44)
        Me.gbMovieClearLogoOpts.TabIndex = 15
        Me.gbMovieClearLogoOpts.TabStop = false
        Me.gbMovieClearLogoOpts.Text = "ClearLogo"
        '
        'chkMovieClearLogoOverwrite
        '
        Me.chkMovieClearLogoOverwrite.AutoSize = true
        Me.chkMovieClearLogoOverwrite.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkMovieClearLogoOverwrite.Location = New System.Drawing.Point(6, 21)
        Me.chkMovieClearLogoOverwrite.Name = "chkMovieClearLogoOverwrite"
        Me.chkMovieClearLogoOverwrite.Size = New System.Drawing.Size(119, 17)
        Me.chkMovieClearLogoOverwrite.TabIndex = 4
        Me.chkMovieClearLogoOverwrite.Text = "Overwrite Existing"
        Me.chkMovieClearLogoOverwrite.UseVisualStyleBackColor = true
        '
        'gbMovieDiscArtOpts
        '
        Me.gbMovieDiscArtOpts.Controls.Add(Me.chkMovieDiscArtOverwrite)
        Me.gbMovieDiscArtOpts.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.gbMovieDiscArtOpts.Location = New System.Drawing.Point(451, 436)
        Me.gbMovieDiscArtOpts.Name = "gbMovieDiscArtOpts"
        Me.gbMovieDiscArtOpts.Size = New System.Drawing.Size(218, 44)
        Me.gbMovieDiscArtOpts.TabIndex = 15
        Me.gbMovieDiscArtOpts.TabStop = false
        Me.gbMovieDiscArtOpts.Text = "DiscArt"
        '
        'chkMovieDiscArtOverwrite
        '
        Me.chkMovieDiscArtOverwrite.AutoSize = true
        Me.chkMovieDiscArtOverwrite.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkMovieDiscArtOverwrite.Location = New System.Drawing.Point(6, 21)
        Me.chkMovieDiscArtOverwrite.Name = "chkMovieDiscArtOverwrite"
        Me.chkMovieDiscArtOverwrite.Size = New System.Drawing.Size(119, 17)
        Me.chkMovieDiscArtOverwrite.TabIndex = 4
        Me.chkMovieDiscArtOverwrite.Text = "Overwrite Existing"
        Me.chkMovieDiscArtOverwrite.UseVisualStyleBackColor = true
        '
        'gbMovieBannerOpts
        '
        Me.gbMovieBannerOpts.Controls.Add(Me.chkMovieBannerPrefOnly)
        Me.gbMovieBannerOpts.Controls.Add(Me.txtMovieBannerWidth)
        Me.gbMovieBannerOpts.Controls.Add(Me.txtMovieBannerHeight)
        Me.gbMovieBannerOpts.Controls.Add(Me.lblMovieBannerQual)
        Me.gbMovieBannerOpts.Controls.Add(Me.tbMovieBannerQual)
        Me.gbMovieBannerOpts.Controls.Add(Me.lblMovieBannerQ)
        Me.gbMovieBannerOpts.Controls.Add(Me.lblMovieBannerWidth)
        Me.gbMovieBannerOpts.Controls.Add(Me.lblMovieBannerHeight)
        Me.gbMovieBannerOpts.Controls.Add(Me.chkMovieBannerResize)
        Me.gbMovieBannerOpts.Controls.Add(Me.lblMovieBannerType)
        Me.gbMovieBannerOpts.Controls.Add(Me.cbMovieBannerPrefType)
        Me.gbMovieBannerOpts.Controls.Add(Me.chkMovieBannerOverwrite)
        Me.gbMovieBannerOpts.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.gbMovieBannerOpts.Location = New System.Drawing.Point(227, 84)
        Me.gbMovieBannerOpts.Name = "gbMovieBannerOpts"
        Me.gbMovieBannerOpts.Size = New System.Drawing.Size(218, 170)
        Me.gbMovieBannerOpts.TabIndex = 12
        Me.gbMovieBannerOpts.TabStop = false
        Me.gbMovieBannerOpts.Text = "Banner"
        '
        'chkMovieBannerPrefOnly
        '
        Me.chkMovieBannerPrefOnly.AutoSize = true
        Me.chkMovieBannerPrefOnly.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkMovieBannerPrefOnly.Location = New System.Drawing.Point(163, 38)
        Me.chkMovieBannerPrefOnly.Name = "chkMovieBannerPrefOnly"
        Me.chkMovieBannerPrefOnly.Size = New System.Drawing.Size(50, 17)
        Me.chkMovieBannerPrefOnly.TabIndex = 2
        Me.chkMovieBannerPrefOnly.Text = "Only"
        Me.chkMovieBannerPrefOnly.UseVisualStyleBackColor = true
        '
        'txtMovieBannerWidth
        '
        Me.txtMovieBannerWidth.Enabled = false
        Me.txtMovieBannerWidth.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtMovieBannerWidth.Location = New System.Drawing.Point(68, 100)
        Me.txtMovieBannerWidth.Name = "txtMovieBannerWidth"
        Me.txtMovieBannerWidth.Size = New System.Drawing.Size(40, 22)
        Me.txtMovieBannerWidth.TabIndex = 6
        '
        'txtMovieBannerHeight
        '
        Me.txtMovieBannerHeight.Enabled = false
        Me.txtMovieBannerHeight.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtMovieBannerHeight.Location = New System.Drawing.Point(175, 100)
        Me.txtMovieBannerHeight.Name = "txtMovieBannerHeight"
        Me.txtMovieBannerHeight.Size = New System.Drawing.Size(40, 22)
        Me.txtMovieBannerHeight.TabIndex = 8
        '
        'lblMovieBannerQual
        '
        Me.lblMovieBannerQual.AutoSize = true
        Me.lblMovieBannerQual.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.lblMovieBannerQual.Location = New System.Drawing.Point(183, 147)
        Me.lblMovieBannerQual.Name = "lblMovieBannerQual"
        Me.lblMovieBannerQual.Size = New System.Drawing.Size(29, 17)
        Me.lblMovieBannerQual.TabIndex = 11
        Me.lblMovieBannerQual.Text = "100"
        '
        'tbMovieBannerQual
        '
        Me.tbMovieBannerQual.AutoSize = false
        Me.tbMovieBannerQual.LargeChange = 10
        Me.tbMovieBannerQual.Location = New System.Drawing.Point(7, 139)
        Me.tbMovieBannerQual.Maximum = 100
        Me.tbMovieBannerQual.Name = "tbMovieBannerQual"
        Me.tbMovieBannerQual.Size = New System.Drawing.Size(179, 27)
        Me.tbMovieBannerQual.TabIndex = 10
        Me.tbMovieBannerQual.TickFrequency = 10
        Me.tbMovieBannerQual.Value = 100
        '
        'lblMovieBannerQ
        '
        Me.lblMovieBannerQ.AutoSize = true
        Me.lblMovieBannerQ.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblMovieBannerQ.Location = New System.Drawing.Point(3, 127)
        Me.lblMovieBannerQ.Name = "lblMovieBannerQ"
        Me.lblMovieBannerQ.Size = New System.Drawing.Size(46, 13)
        Me.lblMovieBannerQ.TabIndex = 9
        Me.lblMovieBannerQ.Text = "Quality:"
        '
        'lblMovieBannerWidth
        '
        Me.lblMovieBannerWidth.AutoSize = true
        Me.lblMovieBannerWidth.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblMovieBannerWidth.Location = New System.Drawing.Point(3, 104)
        Me.lblMovieBannerWidth.Name = "lblMovieBannerWidth"
        Me.lblMovieBannerWidth.Size = New System.Drawing.Size(66, 13)
        Me.lblMovieBannerWidth.TabIndex = 5
        Me.lblMovieBannerWidth.Text = "Max Width:"
        '
        'lblMovieBannerHeight
        '
        Me.lblMovieBannerHeight.AutoSize = true
        Me.lblMovieBannerHeight.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblMovieBannerHeight.Location = New System.Drawing.Point(106, 104)
        Me.lblMovieBannerHeight.Name = "lblMovieBannerHeight"
        Me.lblMovieBannerHeight.Size = New System.Drawing.Size(69, 13)
        Me.lblMovieBannerHeight.TabIndex = 7
        Me.lblMovieBannerHeight.Text = "Max Height:"
        '
        'chkMovieBannerResize
        '
        Me.chkMovieBannerResize.AutoSize = true
        Me.chkMovieBannerResize.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkMovieBannerResize.Location = New System.Drawing.Point(6, 82)
        Me.chkMovieBannerResize.Name = "chkMovieBannerResize"
        Me.chkMovieBannerResize.Size = New System.Drawing.Size(133, 17)
        Me.chkMovieBannerResize.TabIndex = 4
        Me.chkMovieBannerResize.Text = "Automatically Resize:"
        Me.chkMovieBannerResize.UseVisualStyleBackColor = true
        '
        'lblMovieBannerType
        '
        Me.lblMovieBannerType.AutoSize = true
        Me.lblMovieBannerType.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblMovieBannerType.Location = New System.Drawing.Point(4, 18)
        Me.lblMovieBannerType.Name = "lblMovieBannerType"
        Me.lblMovieBannerType.Size = New System.Drawing.Size(83, 13)
        Me.lblMovieBannerType.TabIndex = 0
        Me.lblMovieBannerType.Text = "Preferred Type:"
        '
        'cbMovieBannerPrefType
        '
        Me.cbMovieBannerPrefType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMovieBannerPrefType.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.cbMovieBannerPrefType.FormattingEnabled = true
        Me.cbMovieBannerPrefType.Location = New System.Drawing.Point(6, 34)
        Me.cbMovieBannerPrefType.Name = "cbMovieBannerPrefType"
        Me.cbMovieBannerPrefType.Size = New System.Drawing.Size(148, 21)
        Me.cbMovieBannerPrefType.TabIndex = 1
        '
        'chkMovieBannerOverwrite
        '
        Me.chkMovieBannerOverwrite.AutoSize = true
        Me.chkMovieBannerOverwrite.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkMovieBannerOverwrite.Location = New System.Drawing.Point(6, 62)
        Me.chkMovieBannerOverwrite.Name = "chkMovieBannerOverwrite"
        Me.chkMovieBannerOverwrite.Size = New System.Drawing.Size(119, 17)
        Me.chkMovieBannerOverwrite.TabIndex = 3
        Me.chkMovieBannerOverwrite.Text = "Overwrite Existing"
        Me.chkMovieBannerOverwrite.UseVisualStyleBackColor = true
        '
        'gbMovieLandscapeOpts
        '
        Me.gbMovieLandscapeOpts.Controls.Add(Me.chkMovieLandscapeOverwrite)
        Me.gbMovieLandscapeOpts.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.gbMovieLandscapeOpts.Location = New System.Drawing.Point(451, 310)
        Me.gbMovieLandscapeOpts.Name = "gbMovieLandscapeOpts"
        Me.gbMovieLandscapeOpts.Size = New System.Drawing.Size(218, 44)
        Me.gbMovieLandscapeOpts.TabIndex = 14
        Me.gbMovieLandscapeOpts.TabStop = false
        Me.gbMovieLandscapeOpts.Text = "Landscape"
        '
        'chkMovieLandscapeOverwrite
        '
        Me.chkMovieLandscapeOverwrite.AutoSize = true
        Me.chkMovieLandscapeOverwrite.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkMovieLandscapeOverwrite.Location = New System.Drawing.Point(6, 21)
        Me.chkMovieLandscapeOverwrite.Name = "chkMovieLandscapeOverwrite"
        Me.chkMovieLandscapeOverwrite.Size = New System.Drawing.Size(119, 17)
        Me.chkMovieLandscapeOverwrite.TabIndex = 4
        Me.chkMovieLandscapeOverwrite.Text = "Overwrite Existing"
        Me.chkMovieLandscapeOverwrite.UseVisualStyleBackColor = true
        '
        'gbMovieEFanartsOpts
        '
        Me.gbMovieEFanartsOpts.Controls.Add(Me.lblMovieEFanartsLimit)
        Me.gbMovieEFanartsOpts.Controls.Add(Me.txtMovieEFanartsLimit)
        Me.gbMovieEFanartsOpts.Controls.Add(Me.chkMovieEFanartsPrefOnly)
        Me.gbMovieEFanartsOpts.Controls.Add(Me.txtMovieEFanartsWidth)
        Me.gbMovieEFanartsOpts.Controls.Add(Me.txtMovieEFanartsHeight)
        Me.gbMovieEFanartsOpts.Controls.Add(Me.lblMovieEFanartsQual)
        Me.gbMovieEFanartsOpts.Controls.Add(Me.tbMovieEFanartsQual)
        Me.gbMovieEFanartsOpts.Controls.Add(Me.lblMovieEFanartsQ)
        Me.gbMovieEFanartsOpts.Controls.Add(Me.lblMovieEFanartsWidth)
        Me.gbMovieEFanartsOpts.Controls.Add(Me.lblMovieEFanartsHeight)
        Me.gbMovieEFanartsOpts.Controls.Add(Me.chkMovieEFanartsResize)
        Me.gbMovieEFanartsOpts.Controls.Add(Me.Label29)
        Me.gbMovieEFanartsOpts.Controls.Add(Me.cbMovieEFanartsPrefSize)
        Me.gbMovieEFanartsOpts.Controls.Add(Me.chkMovieEFanartsOverwrite)
        Me.gbMovieEFanartsOpts.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.gbMovieEFanartsOpts.Location = New System.Drawing.Point(227, 260)
        Me.gbMovieEFanartsOpts.Name = "gbMovieEFanartsOpts"
        Me.gbMovieEFanartsOpts.Size = New System.Drawing.Size(218, 170)
        Me.gbMovieEFanartsOpts.TabIndex = 13
        Me.gbMovieEFanartsOpts.TabStop = false
        Me.gbMovieEFanartsOpts.Text = "Extrafanarts"
        '
        'lblMovieEFanartsLimit
        '
        Me.lblMovieEFanartsLimit.AutoSize = true
        Me.lblMovieEFanartsLimit.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.lblMovieEFanartsLimit.Location = New System.Drawing.Point(135, 75)
        Me.lblMovieEFanartsLimit.Name = "lblMovieEFanartsLimit"
        Me.lblMovieEFanartsLimit.Size = New System.Drawing.Size(34, 13)
        Me.lblMovieEFanartsLimit.TabIndex = 13
        Me.lblMovieEFanartsLimit.Text = "Limit:"
        '
        'txtMovieEFanartsLimit
        '
        Me.txtMovieEFanartsLimit.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtMovieEFanartsLimit.Location = New System.Drawing.Point(175, 72)
        Me.txtMovieEFanartsLimit.Name = "txtMovieEFanartsLimit"
        Me.txtMovieEFanartsLimit.Size = New System.Drawing.Size(40, 22)
        Me.txtMovieEFanartsLimit.TabIndex = 12
        '
        'chkMovieEFanartsPrefOnly
        '
        Me.chkMovieEFanartsPrefOnly.AutoSize = true
        Me.chkMovieEFanartsPrefOnly.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkMovieEFanartsPrefOnly.Location = New System.Drawing.Point(163, 38)
        Me.chkMovieEFanartsPrefOnly.Name = "chkMovieEFanartsPrefOnly"
        Me.chkMovieEFanartsPrefOnly.Size = New System.Drawing.Size(50, 17)
        Me.chkMovieEFanartsPrefOnly.TabIndex = 2
        Me.chkMovieEFanartsPrefOnly.Text = "Only"
        Me.chkMovieEFanartsPrefOnly.UseVisualStyleBackColor = true
>>>>>>> upstream/master
        '
        'txtMovieEFanartsWidth
        '
        Me.txtMovieEFanartsWidth.Enabled = false
        Me.txtMovieEFanartsWidth.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtMovieEFanartsWidth.Location = New System.Drawing.Point(68, 100)
        Me.txtMovieEFanartsWidth.Name = "txtMovieEFanartsWidth"
        Me.txtMovieEFanartsWidth.Size = New System.Drawing.Size(40, 22)
        Me.txtMovieEFanartsWidth.TabIndex = 6
        '
        'txtMovieEFanartsHeight
        '
        Me.txtMovieEFanartsHeight.Enabled = false
        Me.txtMovieEFanartsHeight.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtMovieEFanartsHeight.Location = New System.Drawing.Point(175, 100)
        Me.txtMovieEFanartsHeight.Name = "txtMovieEFanartsHeight"
        Me.txtMovieEFanartsHeight.Size = New System.Drawing.Size(40, 22)
        Me.txtMovieEFanartsHeight.TabIndex = 8
        '
        'lblMovieEFanartsQual
        '
        Me.lblMovieEFanartsQual.AutoSize = true
        Me.lblMovieEFanartsQual.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.lblMovieEFanartsQual.Location = New System.Drawing.Point(183, 147)
        Me.lblMovieEFanartsQual.Name = "lblMovieEFanartsQual"
        Me.lblMovieEFanartsQual.Size = New System.Drawing.Size(29, 17)
        Me.lblMovieEFanartsQual.TabIndex = 11
        Me.lblMovieEFanartsQual.Text = "100"
        '
        'tbMovieEFanartsQual
        '
        Me.tbMovieEFanartsQual.AutoSize = false
        Me.tbMovieEFanartsQual.LargeChange = 10
        Me.tbMovieEFanartsQual.Location = New System.Drawing.Point(7, 139)
        Me.tbMovieEFanartsQual.Maximum = 100
        Me.tbMovieEFanartsQual.Name = "tbMovieEFanartsQual"
        Me.tbMovieEFanartsQual.Size = New System.Drawing.Size(179, 27)
        Me.tbMovieEFanartsQual.TabIndex = 10
        Me.tbMovieEFanartsQual.TickFrequency = 10
        Me.tbMovieEFanartsQual.Value = 100
        '
<<<<<<< HEAD
        'Label22
        '
        Me.Label22.AutoSize = true
        Me.Label22.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label22.Location = New System.Drawing.Point(3, 127)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(46, 13)
        Me.Label22.TabIndex = 9
        Me.Label22.Text = "Quality:"
        '
        'Label23
        '
        Me.Label23.AutoSize = true
        Me.Label23.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label23.Location = New System.Drawing.Point(3, 104)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(66, 13)
        Me.Label23.TabIndex = 5
        Me.Label23.Text = "Max Width:"
        '
        'Label28
        '
        Me.Label28.AutoSize = true
        Me.Label28.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label28.Location = New System.Drawing.Point(106, 104)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(69, 13)
        Me.Label28.TabIndex = 7
        Me.Label28.Text = "Max Height:"
        '
        'chkMovieResizeEFanarts
        '
        Me.chkMovieResizeEFanarts.AutoSize = true
        Me.chkMovieResizeEFanarts.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkMovieResizeEFanarts.Location = New System.Drawing.Point(6, 82)
        Me.chkMovieResizeEFanarts.Name = "chkMovieResizeEFanarts"
        Me.chkMovieResizeEFanarts.Size = New System.Drawing.Size(133, 17)
        Me.chkMovieResizeEFanarts.TabIndex = 4
        Me.chkMovieResizeEFanarts.Text = "Automatically Resize:"
        Me.chkMovieResizeEFanarts.UseVisualStyleBackColor = true
=======
        'lblMovieEFanartsQ
        '
        Me.lblMovieEFanartsQ.AutoSize = true
        Me.lblMovieEFanartsQ.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblMovieEFanartsQ.Location = New System.Drawing.Point(3, 127)
        Me.lblMovieEFanartsQ.Name = "lblMovieEFanartsQ"
        Me.lblMovieEFanartsQ.Size = New System.Drawing.Size(46, 13)
        Me.lblMovieEFanartsQ.TabIndex = 9
        Me.lblMovieEFanartsQ.Text = "Quality:"
        '
        'lblMovieEFanartsWidth
        '
        Me.lblMovieEFanartsWidth.AutoSize = true
        Me.lblMovieEFanartsWidth.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblMovieEFanartsWidth.Location = New System.Drawing.Point(3, 104)
        Me.lblMovieEFanartsWidth.Name = "lblMovieEFanartsWidth"
        Me.lblMovieEFanartsWidth.Size = New System.Drawing.Size(66, 13)
        Me.lblMovieEFanartsWidth.TabIndex = 5
        Me.lblMovieEFanartsWidth.Text = "Max Width:"
        '
        'lblMovieEFanartsHeight
        '
        Me.lblMovieEFanartsHeight.AutoSize = true
        Me.lblMovieEFanartsHeight.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblMovieEFanartsHeight.Location = New System.Drawing.Point(106, 104)
        Me.lblMovieEFanartsHeight.Name = "lblMovieEFanartsHeight"
        Me.lblMovieEFanartsHeight.Size = New System.Drawing.Size(69, 13)
        Me.lblMovieEFanartsHeight.TabIndex = 7
        Me.lblMovieEFanartsHeight.Text = "Max Height:"
        '
        'chkMovieEFanartsResize
        '
        Me.chkMovieEFanartsResize.AutoSize = true
        Me.chkMovieEFanartsResize.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkMovieEFanartsResize.Location = New System.Drawing.Point(6, 82)
        Me.chkMovieEFanartsResize.Name = "chkMovieEFanartsResize"
        Me.chkMovieEFanartsResize.Size = New System.Drawing.Size(133, 17)
        Me.chkMovieEFanartsResize.TabIndex = 4
        Me.chkMovieEFanartsResize.Text = "Automatically Resize:"
        Me.chkMovieEFanartsResize.UseVisualStyleBackColor = true
>>>>>>> upstream/master
        '
        'Label29
        '
        Me.Label29.AutoSize = true
        Me.Label29.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label29.Location = New System.Drawing.Point(4, 18)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(80, 13)
        Me.Label29.TabIndex = 0
        Me.Label29.Text = "Preferred Size:"
        '
<<<<<<< HEAD
        'cbMovieEFanartsSize
        '
        Me.cbMovieEFanartsSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMovieEFanartsSize.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.cbMovieEFanartsSize.FormattingEnabled = true
        Me.cbMovieEFanartsSize.Location = New System.Drawing.Point(6, 34)
        Me.cbMovieEFanartsSize.Name = "cbMovieEFanartsSize"
        Me.cbMovieEFanartsSize.Size = New System.Drawing.Size(148, 21)
        Me.cbMovieEFanartsSize.TabIndex = 1
        '
        'chkMovieOverwriteEFanarts
        '
        Me.chkMovieOverwriteEFanarts.AutoSize = true
        Me.chkMovieOverwriteEFanarts.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkMovieOverwriteEFanarts.Location = New System.Drawing.Point(6, 62)
        Me.chkMovieOverwriteEFanarts.Name = "chkMovieOverwriteEFanarts"
        Me.chkMovieOverwriteEFanarts.Size = New System.Drawing.Size(119, 17)
        Me.chkMovieOverwriteEFanarts.TabIndex = 3
        Me.chkMovieOverwriteEFanarts.Text = "Overwrite Existing"
        Me.chkMovieOverwriteEFanarts.UseVisualStyleBackColor = true
        '
        'gbMovieImagesEThumbs
        '
        Me.gbMovieImagesEThumbs.Controls.Add(Me.chkMovieEThumbsOnly)
        Me.gbMovieImagesEThumbs.Controls.Add(Me.txtMovieEThumbsWidth)
        Me.gbMovieImagesEThumbs.Controls.Add(Me.txtMovieEThumbsHeight)
        Me.gbMovieImagesEThumbs.Controls.Add(Me.lblMovieEThumbsQual)
        Me.gbMovieImagesEThumbs.Controls.Add(Me.tbMovieEThumbsQual)
        Me.gbMovieImagesEThumbs.Controls.Add(Me.Label14)
        Me.gbMovieImagesEThumbs.Controls.Add(Me.Label15)
        Me.gbMovieImagesEThumbs.Controls.Add(Me.Label16)
        Me.gbMovieImagesEThumbs.Controls.Add(Me.chkMovieResizeEThumbs)
        Me.gbMovieImagesEThumbs.Controls.Add(Me.Label17)
        Me.gbMovieImagesEThumbs.Controls.Add(Me.cbMovieEThumbsSize)
        Me.gbMovieImagesEThumbs.Controls.Add(Me.chkMovieOverwriteEThumbs)
        Me.gbMovieImagesEThumbs.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.gbMovieImagesEThumbs.Location = New System.Drawing.Point(3, 259)
        Me.gbMovieImagesEThumbs.Name = "gbMovieImagesEThumbs"
        Me.gbMovieImagesEThumbs.Size = New System.Drawing.Size(218, 170)
        Me.gbMovieImagesEThumbs.TabIndex = 12
        Me.gbMovieImagesEThumbs.TabStop = false
        Me.gbMovieImagesEThumbs.Text = "Extrathumbs"
        '
        'chkMovieEThumbsOnly
        '
        Me.chkMovieEThumbsOnly.AutoSize = true
        Me.chkMovieEThumbsOnly.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkMovieEThumbsOnly.Location = New System.Drawing.Point(163, 38)
        Me.chkMovieEThumbsOnly.Name = "chkMovieEThumbsOnly"
        Me.chkMovieEThumbsOnly.Size = New System.Drawing.Size(50, 17)
        Me.chkMovieEThumbsOnly.TabIndex = 2
        Me.chkMovieEThumbsOnly.Text = "Only"
        Me.chkMovieEThumbsOnly.UseVisualStyleBackColor = true
=======
        'cbMovieEFanartsPrefSize
        '
        Me.cbMovieEFanartsPrefSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMovieEFanartsPrefSize.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.cbMovieEFanartsPrefSize.FormattingEnabled = true
        Me.cbMovieEFanartsPrefSize.Location = New System.Drawing.Point(6, 34)
        Me.cbMovieEFanartsPrefSize.Name = "cbMovieEFanartsPrefSize"
        Me.cbMovieEFanartsPrefSize.Size = New System.Drawing.Size(148, 21)
        Me.cbMovieEFanartsPrefSize.TabIndex = 1
        '
        'chkMovieEFanartsOverwrite
        '
        Me.chkMovieEFanartsOverwrite.AutoSize = true
        Me.chkMovieEFanartsOverwrite.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkMovieEFanartsOverwrite.Location = New System.Drawing.Point(6, 62)
        Me.chkMovieEFanartsOverwrite.Name = "chkMovieEFanartsOverwrite"
        Me.chkMovieEFanartsOverwrite.Size = New System.Drawing.Size(119, 17)
        Me.chkMovieEFanartsOverwrite.TabIndex = 3
        Me.chkMovieEFanartsOverwrite.Text = "Overwrite Existing"
        Me.chkMovieEFanartsOverwrite.UseVisualStyleBackColor = true
        '
        'gbMovieEThumbsOpts
        '
        Me.gbMovieEThumbsOpts.Controls.Add(Me.lblMovieEThumbsLimit)
        Me.gbMovieEThumbsOpts.Controls.Add(Me.txtMovieEThumbsLimit)
        Me.gbMovieEThumbsOpts.Controls.Add(Me.chkMovieEThumbsPrefOnly)
        Me.gbMovieEThumbsOpts.Controls.Add(Me.txtMovieEThumbsWidth)
        Me.gbMovieEThumbsOpts.Controls.Add(Me.txtMovieEThumbsHeight)
        Me.gbMovieEThumbsOpts.Controls.Add(Me.lblMovieEThumbsQual)
        Me.gbMovieEThumbsOpts.Controls.Add(Me.tbMovieEThumbsQual)
        Me.gbMovieEThumbsOpts.Controls.Add(Me.lblMovieEThumbsQ)
        Me.gbMovieEThumbsOpts.Controls.Add(Me.lblMovieEThumbsWidth)
        Me.gbMovieEThumbsOpts.Controls.Add(Me.lblMovieEThumbsHeight)
        Me.gbMovieEThumbsOpts.Controls.Add(Me.chkMovieEThumbsResize)
        Me.gbMovieEThumbsOpts.Controls.Add(Me.Label17)
        Me.gbMovieEThumbsOpts.Controls.Add(Me.cbMovieEThumbsPrefSize)
        Me.gbMovieEThumbsOpts.Controls.Add(Me.chkMovieEThumbsOverwrite)
        Me.gbMovieEThumbsOpts.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.gbMovieEThumbsOpts.Location = New System.Drawing.Point(3, 260)
        Me.gbMovieEThumbsOpts.Name = "gbMovieEThumbsOpts"
        Me.gbMovieEThumbsOpts.Size = New System.Drawing.Size(218, 170)
        Me.gbMovieEThumbsOpts.TabIndex = 12
        Me.gbMovieEThumbsOpts.TabStop = false
        Me.gbMovieEThumbsOpts.Text = "Extrathumbs"
        '
        'lblMovieEThumbsLimit
        '
        Me.lblMovieEThumbsLimit.AutoSize = true
        Me.lblMovieEThumbsLimit.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.lblMovieEThumbsLimit.Location = New System.Drawing.Point(135, 75)
        Me.lblMovieEThumbsLimit.Name = "lblMovieEThumbsLimit"
        Me.lblMovieEThumbsLimit.Size = New System.Drawing.Size(34, 13)
        Me.lblMovieEThumbsLimit.TabIndex = 14
        Me.lblMovieEThumbsLimit.Text = "Limit:"
        '
        'txtMovieEThumbsLimit
        '
        Me.txtMovieEThumbsLimit.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtMovieEThumbsLimit.Location = New System.Drawing.Point(175, 72)
        Me.txtMovieEThumbsLimit.Name = "txtMovieEThumbsLimit"
        Me.txtMovieEThumbsLimit.Size = New System.Drawing.Size(40, 22)
        Me.txtMovieEThumbsLimit.TabIndex = 12
        '
        'chkMovieEThumbsPrefOnly
        '
        Me.chkMovieEThumbsPrefOnly.AutoSize = true
        Me.chkMovieEThumbsPrefOnly.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkMovieEThumbsPrefOnly.Location = New System.Drawing.Point(163, 38)
        Me.chkMovieEThumbsPrefOnly.Name = "chkMovieEThumbsPrefOnly"
        Me.chkMovieEThumbsPrefOnly.Size = New System.Drawing.Size(50, 17)
        Me.chkMovieEThumbsPrefOnly.TabIndex = 2
        Me.chkMovieEThumbsPrefOnly.Text = "Only"
        Me.chkMovieEThumbsPrefOnly.UseVisualStyleBackColor = true
>>>>>>> upstream/master
        '
        'txtMovieEThumbsWidth
        '
        Me.txtMovieEThumbsWidth.Enabled = false
        Me.txtMovieEThumbsWidth.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtMovieEThumbsWidth.Location = New System.Drawing.Point(68, 100)
        Me.txtMovieEThumbsWidth.Name = "txtMovieEThumbsWidth"
        Me.txtMovieEThumbsWidth.Size = New System.Drawing.Size(40, 22)
        Me.txtMovieEThumbsWidth.TabIndex = 6
        '
        'txtMovieEThumbsHeight
        '
        Me.txtMovieEThumbsHeight.Enabled = false
        Me.txtMovieEThumbsHeight.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtMovieEThumbsHeight.Location = New System.Drawing.Point(175, 100)
        Me.txtMovieEThumbsHeight.Name = "txtMovieEThumbsHeight"
        Me.txtMovieEThumbsHeight.Size = New System.Drawing.Size(40, 22)
        Me.txtMovieEThumbsHeight.TabIndex = 8
        '
        'lblMovieEThumbsQual
        '
        Me.lblMovieEThumbsQual.AutoSize = true
        Me.lblMovieEThumbsQual.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.lblMovieEThumbsQual.Location = New System.Drawing.Point(183, 147)
        Me.lblMovieEThumbsQual.Name = "lblMovieEThumbsQual"
        Me.lblMovieEThumbsQual.Size = New System.Drawing.Size(29, 17)
        Me.lblMovieEThumbsQual.TabIndex = 11
        Me.lblMovieEThumbsQual.Text = "100"
        '
        'tbMovieEThumbsQual
        '
        Me.tbMovieEThumbsQual.AutoSize = false
        Me.tbMovieEThumbsQual.LargeChange = 10
        Me.tbMovieEThumbsQual.Location = New System.Drawing.Point(7, 139)
        Me.tbMovieEThumbsQual.Maximum = 100
        Me.tbMovieEThumbsQual.Name = "tbMovieEThumbsQual"
        Me.tbMovieEThumbsQual.Size = New System.Drawing.Size(179, 27)
        Me.tbMovieEThumbsQual.TabIndex = 10
        Me.tbMovieEThumbsQual.TickFrequency = 10
        Me.tbMovieEThumbsQual.Value = 100
        '
<<<<<<< HEAD
        'Label14
        '
        Me.Label14.AutoSize = true
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label14.Location = New System.Drawing.Point(3, 127)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(46, 13)
        Me.Label14.TabIndex = 9
        Me.Label14.Text = "Quality:"
        '
        'Label15
        '
        Me.Label15.AutoSize = true
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label15.Location = New System.Drawing.Point(3, 104)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(66, 13)
        Me.Label15.TabIndex = 5
        Me.Label15.Text = "Max Width:"
        '
        'Label16
        '
        Me.Label16.AutoSize = true
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label16.Location = New System.Drawing.Point(106, 104)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(69, 13)
        Me.Label16.TabIndex = 7
        Me.Label16.Text = "Max Height:"
        '
        'chkMovieResizeEThumbs
        '
        Me.chkMovieResizeEThumbs.AutoSize = true
        Me.chkMovieResizeEThumbs.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkMovieResizeEThumbs.Location = New System.Drawing.Point(6, 82)
        Me.chkMovieResizeEThumbs.Name = "chkMovieResizeEThumbs"
        Me.chkMovieResizeEThumbs.Size = New System.Drawing.Size(133, 17)
        Me.chkMovieResizeEThumbs.TabIndex = 4
        Me.chkMovieResizeEThumbs.Text = "Automatically Resize:"
        Me.chkMovieResizeEThumbs.UseVisualStyleBackColor = true
=======
        'lblMovieEThumbsQ
        '
        Me.lblMovieEThumbsQ.AutoSize = true
        Me.lblMovieEThumbsQ.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblMovieEThumbsQ.Location = New System.Drawing.Point(3, 127)
        Me.lblMovieEThumbsQ.Name = "lblMovieEThumbsQ"
        Me.lblMovieEThumbsQ.Size = New System.Drawing.Size(46, 13)
        Me.lblMovieEThumbsQ.TabIndex = 9
        Me.lblMovieEThumbsQ.Text = "Quality:"
        '
        'lblMovieEThumbsWidth
        '
        Me.lblMovieEThumbsWidth.AutoSize = true
        Me.lblMovieEThumbsWidth.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblMovieEThumbsWidth.Location = New System.Drawing.Point(3, 104)
        Me.lblMovieEThumbsWidth.Name = "lblMovieEThumbsWidth"
        Me.lblMovieEThumbsWidth.Size = New System.Drawing.Size(66, 13)
        Me.lblMovieEThumbsWidth.TabIndex = 5
        Me.lblMovieEThumbsWidth.Text = "Max Width:"
        '
        'lblMovieEThumbsHeight
        '
        Me.lblMovieEThumbsHeight.AutoSize = true
        Me.lblMovieEThumbsHeight.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblMovieEThumbsHeight.Location = New System.Drawing.Point(106, 104)
        Me.lblMovieEThumbsHeight.Name = "lblMovieEThumbsHeight"
        Me.lblMovieEThumbsHeight.Size = New System.Drawing.Size(69, 13)
        Me.lblMovieEThumbsHeight.TabIndex = 7
        Me.lblMovieEThumbsHeight.Text = "Max Height:"
        '
        'chkMovieEThumbsResize
        '
        Me.chkMovieEThumbsResize.AutoSize = true
        Me.chkMovieEThumbsResize.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkMovieEThumbsResize.Location = New System.Drawing.Point(6, 82)
        Me.chkMovieEThumbsResize.Name = "chkMovieEThumbsResize"
        Me.chkMovieEThumbsResize.Size = New System.Drawing.Size(133, 17)
        Me.chkMovieEThumbsResize.TabIndex = 4
        Me.chkMovieEThumbsResize.Text = "Automatically Resize:"
        Me.chkMovieEThumbsResize.UseVisualStyleBackColor = true
>>>>>>> upstream/master
        '
        'Label17
        '
        Me.Label17.AutoSize = true
        Me.Label17.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label17.Location = New System.Drawing.Point(4, 18)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(80, 13)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "Preferred Size:"
        '
<<<<<<< HEAD
        'cbMovieEThumbsSize
        '
        Me.cbMovieEThumbsSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMovieEThumbsSize.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.cbMovieEThumbsSize.FormattingEnabled = true
        Me.cbMovieEThumbsSize.Location = New System.Drawing.Point(6, 34)
        Me.cbMovieEThumbsSize.Name = "cbMovieEThumbsSize"
        Me.cbMovieEThumbsSize.Size = New System.Drawing.Size(148, 21)
        Me.cbMovieEThumbsSize.TabIndex = 1
        '
        'chkMovieOverwriteEThumbs
        '
        Me.chkMovieOverwriteEThumbs.AutoSize = true
        Me.chkMovieOverwriteEThumbs.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkMovieOverwriteEThumbs.Location = New System.Drawing.Point(6, 62)
        Me.chkMovieOverwriteEThumbs.Name = "chkMovieOverwriteEThumbs"
        Me.chkMovieOverwriteEThumbs.Size = New System.Drawing.Size(119, 17)
        Me.chkMovieOverwriteEThumbs.TabIndex = 3
        Me.chkMovieOverwriteEThumbs.Text = "Overwrite Existing"
        Me.chkMovieOverwriteEThumbs.UseVisualStyleBackColor = true
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.chkMovieScraperActorThumbs)
        Me.GroupBox9.Controls.Add(Me.chkMovieNoSaveImagesToNfo)
        Me.GroupBox9.Controls.Add(Me.chkMovieSingleScrapeImages)
        Me.GroupBox9.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.GroupBox9.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(200, 74)
        Me.GroupBox9.TabIndex = 0
        Me.GroupBox9.TabStop = false
        Me.GroupBox9.Text = "Images"
=======
        'cbMovieEThumbsPrefSize
        '
        Me.cbMovieEThumbsPrefSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMovieEThumbsPrefSize.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.cbMovieEThumbsPrefSize.FormattingEnabled = true
        Me.cbMovieEThumbsPrefSize.Location = New System.Drawing.Point(6, 34)
        Me.cbMovieEThumbsPrefSize.Name = "cbMovieEThumbsPrefSize"
        Me.cbMovieEThumbsPrefSize.Size = New System.Drawing.Size(148, 21)
        Me.cbMovieEThumbsPrefSize.TabIndex = 1
        '
        'chkMovieEThumbsOverwrite
        '
        Me.chkMovieEThumbsOverwrite.AutoSize = true
        Me.chkMovieEThumbsOverwrite.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkMovieEThumbsOverwrite.Location = New System.Drawing.Point(6, 62)
        Me.chkMovieEThumbsOverwrite.Name = "chkMovieEThumbsOverwrite"
        Me.chkMovieEThumbsOverwrite.Size = New System.Drawing.Size(119, 17)
        Me.chkMovieEThumbsOverwrite.TabIndex = 3
        Me.chkMovieEThumbsOverwrite.Text = "Overwrite Existing"
        Me.chkMovieEThumbsOverwrite.UseVisualStyleBackColor = true
        '
        'gbMovieImagesOpts
        '
        Me.gbMovieImagesOpts.Controls.Add(Me.chkMovieScraperActorThumbs)
        Me.gbMovieImagesOpts.Controls.Add(Me.chkMovieNoSaveImagesToNfo)
        Me.gbMovieImagesOpts.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.gbMovieImagesOpts.Location = New System.Drawing.Point(4, 4)
        Me.gbMovieImagesOpts.Name = "gbMovieImagesOpts"
        Me.gbMovieImagesOpts.Size = New System.Drawing.Size(217, 74)
        Me.gbMovieImagesOpts.TabIndex = 0
        Me.gbMovieImagesOpts.TabStop = false
        Me.gbMovieImagesOpts.Text = "Images"
>>>>>>> upstream/master
        '
        'chkMovieScraperActorThumbs
        '
        Me.chkMovieScraperActorThumbs.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkMovieScraperActorThumbs.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
<<<<<<< HEAD
        Me.chkMovieScraperActorThumbs.Location = New System.Drawing.Point(6, 35)
=======
        Me.chkMovieScraperActorThumbs.Location = New System.Drawing.Point(6, 21)
>>>>>>> upstream/master
        Me.chkMovieScraperActorThumbs.Name = "chkMovieScraperActorThumbs"
        Me.chkMovieScraperActorThumbs.Size = New System.Drawing.Size(173, 19)
        Me.chkMovieScraperActorThumbs.TabIndex = 1
        Me.chkMovieScraperActorThumbs.Text = "Enable Actor Thumbs"
        Me.chkMovieScraperActorThumbs.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkMovieScraperActorThumbs.UseVisualStyleBackColor = true
        '
        'chkMovieNoSaveImagesToNfo
        '
        Me.chkMovieNoSaveImagesToNfo.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkMovieNoSaveImagesToNfo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
<<<<<<< HEAD
        Me.chkMovieNoSaveImagesToNfo.Location = New System.Drawing.Point(6, 53)
=======
        Me.chkMovieNoSaveImagesToNfo.Location = New System.Drawing.Point(6, 46)
>>>>>>> upstream/master
        Me.chkMovieNoSaveImagesToNfo.Name = "chkMovieNoSaveImagesToNfo"
        Me.chkMovieNoSaveImagesToNfo.Size = New System.Drawing.Size(188, 18)
        Me.chkMovieNoSaveImagesToNfo.TabIndex = 2
        Me.chkMovieNoSaveImagesToNfo.Text = "Do Not Save Image URLs to Nfo"
        Me.chkMovieNoSaveImagesToNfo.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkMovieNoSaveImagesToNfo.UseVisualStyleBackColor = true
        '
<<<<<<< HEAD
        'chkMovieSingleScrapeImages
        '
        Me.chkMovieSingleScrapeImages.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkMovieSingleScrapeImages.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkMovieSingleScrapeImages.Location = New System.Drawing.Point(6, 16)
        Me.chkMovieSingleScrapeImages.Name = "chkMovieSingleScrapeImages"
        Me.chkMovieSingleScrapeImages.Size = New System.Drawing.Size(173, 19)
        Me.chkMovieSingleScrapeImages.TabIndex = 0
        Me.chkMovieSingleScrapeImages.Text = "Get on Single Scrape"
        Me.chkMovieSingleScrapeImages.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkMovieSingleScrapeImages.UseVisualStyleBackColor = true
        '
        'gbMovieImagesFanart
        '
        Me.gbMovieImagesFanart.Controls.Add(Me.txtMovieFanartWidth)
        Me.gbMovieImagesFanart.Controls.Add(Me.txtMovieFanartHeight)
        Me.gbMovieImagesFanart.Controls.Add(Me.chkMovieFanartOnly)
        Me.gbMovieImagesFanart.Controls.Add(Me.lblMovieFanartQual)
        Me.gbMovieImagesFanart.Controls.Add(Me.tbMovieFanartQual)
        Me.gbMovieImagesFanart.Controls.Add(Me.Label26)
        Me.gbMovieImagesFanart.Controls.Add(Me.Label9)
        Me.gbMovieImagesFanart.Controls.Add(Me.Label10)
        Me.gbMovieImagesFanart.Controls.Add(Me.chkMovieResizeFanart)
        Me.gbMovieImagesFanart.Controls.Add(Me.cbMovieFanartSize)
        Me.gbMovieImagesFanart.Controls.Add(Me.lblFanartSize)
        Me.gbMovieImagesFanart.Controls.Add(Me.chkMovieOverwriteFanart)
        Me.gbMovieImagesFanart.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.gbMovieImagesFanart.Location = New System.Drawing.Point(228, 83)
        Me.gbMovieImagesFanart.Name = "gbMovieImagesFanart"
        Me.gbMovieImagesFanart.Size = New System.Drawing.Size(218, 170)
        Me.gbMovieImagesFanart.TabIndex = 3
        Me.gbMovieImagesFanart.TabStop = false
        Me.gbMovieImagesFanart.Text = "Fanart"
=======
        'gbMovieFanartOpts
        '
        Me.gbMovieFanartOpts.Controls.Add(Me.txtMovieFanartWidth)
        Me.gbMovieFanartOpts.Controls.Add(Me.txtMovieFanartHeight)
        Me.gbMovieFanartOpts.Controls.Add(Me.chkMovieFanartPrefOnly)
        Me.gbMovieFanartOpts.Controls.Add(Me.lblMovieFanartQual)
        Me.gbMovieFanartOpts.Controls.Add(Me.tbMovieFanartQual)
        Me.gbMovieFanartOpts.Controls.Add(Me.lblMovieFanartQ)
        Me.gbMovieFanartOpts.Controls.Add(Me.lblMovieFanartWidth)
        Me.gbMovieFanartOpts.Controls.Add(Me.lblMovieFanartHeight)
        Me.gbMovieFanartOpts.Controls.Add(Me.chkMovieFanartResize)
        Me.gbMovieFanartOpts.Controls.Add(Me.cbMovieFanartPrefSize)
        Me.gbMovieFanartOpts.Controls.Add(Me.lblFanartSize)
        Me.gbMovieFanartOpts.Controls.Add(Me.chkMovieFanartOverwrite)
        Me.gbMovieFanartOpts.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.gbMovieFanartOpts.Location = New System.Drawing.Point(451, 84)
        Me.gbMovieFanartOpts.Name = "gbMovieFanartOpts"
        Me.gbMovieFanartOpts.Size = New System.Drawing.Size(218, 170)
        Me.gbMovieFanartOpts.TabIndex = 3
        Me.gbMovieFanartOpts.TabStop = false
        Me.gbMovieFanartOpts.Text = "Fanart"
>>>>>>> upstream/master
        '
        'txtMovieFanartWidth
        '
        Me.txtMovieFanartWidth.Enabled = false
        Me.txtMovieFanartWidth.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtMovieFanartWidth.Location = New System.Drawing.Point(69, 100)
        Me.txtMovieFanartWidth.Name = "txtMovieFanartWidth"
        Me.txtMovieFanartWidth.Size = New System.Drawing.Size(40, 22)
        Me.txtMovieFanartWidth.TabIndex = 6
        '
        'txtMovieFanartHeight
        '
        Me.txtMovieFanartHeight.Enabled = false
        Me.txtMovieFanartHeight.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtMovieFanartHeight.Location = New System.Drawing.Point(175, 100)
        Me.txtMovieFanartHeight.Name = "txtMovieFanartHeight"
        Me.txtMovieFanartHeight.Size = New System.Drawing.Size(40, 22)
        Me.txtMovieFanartHeight.TabIndex = 8
        '
        'chkMovieFanartPrefOnly
        '
<<<<<<< HEAD
        Me.chkMovieFanartOnly.AutoSize = true
        Me.chkMovieFanartOnly.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkMovieFanartOnly.Location = New System.Drawing.Point(163, 38)
        Me.chkMovieFanartOnly.Name = "chkMovieFanartOnly"
        Me.chkMovieFanartOnly.Size = New System.Drawing.Size(50, 17)
        Me.chkMovieFanartOnly.TabIndex = 2
        Me.chkMovieFanartOnly.Text = "Only"
        Me.chkMovieFanartOnly.UseVisualStyleBackColor = true
=======
        Me.chkMovieFanartPrefOnly.AutoSize = true
        Me.chkMovieFanartPrefOnly.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkMovieFanartPrefOnly.Location = New System.Drawing.Point(163, 38)
        Me.chkMovieFanartPrefOnly.Name = "chkMovieFanartPrefOnly"
        Me.chkMovieFanartPrefOnly.Size = New System.Drawing.Size(50, 17)
        Me.chkMovieFanartPrefOnly.TabIndex = 2
        Me.chkMovieFanartPrefOnly.Text = "Only"
        Me.chkMovieFanartPrefOnly.UseVisualStyleBackColor = true
>>>>>>> upstream/master
        '
        'lblMovieFanartQual
        '
        Me.lblMovieFanartQual.AutoSize = true
        Me.lblMovieFanartQual.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.lblMovieFanartQual.Location = New System.Drawing.Point(183, 151)
        Me.lblMovieFanartQual.Name = "lblMovieFanartQual"
        Me.lblMovieFanartQual.Size = New System.Drawing.Size(29, 17)
        Me.lblMovieFanartQual.TabIndex = 11
        Me.lblMovieFanartQual.Text = "100"
        '
        'tbMovieFanartQual
        '
        Me.tbMovieFanartQual.AutoSize = false
        Me.tbMovieFanartQual.LargeChange = 10
        Me.tbMovieFanartQual.Location = New System.Drawing.Point(6, 139)
        Me.tbMovieFanartQual.Maximum = 100
        Me.tbMovieFanartQual.Name = "tbMovieFanartQual"
        Me.tbMovieFanartQual.Size = New System.Drawing.Size(180, 27)
        Me.tbMovieFanartQual.TabIndex = 10
        Me.tbMovieFanartQual.TickFrequency = 10
        Me.tbMovieFanartQual.Value = 100
        '
<<<<<<< HEAD
        'Label26
        '
        Me.Label26.AutoSize = true
        Me.Label26.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label26.Location = New System.Drawing.Point(3, 127)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(46, 13)
        Me.Label26.TabIndex = 9
        Me.Label26.Text = "Quality:"
        '
        'Label9
        '
        Me.Label9.AutoSize = true
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label9.Location = New System.Drawing.Point(3, 104)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 13)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Max Width:"
        '
        'Label10
        '
        Me.Label10.AutoSize = true
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label10.Location = New System.Drawing.Point(107, 104)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(69, 13)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "Max Height:"
        '
        'chkMovieResizeFanart
        '
        Me.chkMovieResizeFanart.AutoSize = true
        Me.chkMovieResizeFanart.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkMovieResizeFanart.Location = New System.Drawing.Point(6, 82)
        Me.chkMovieResizeFanart.Name = "chkMovieResizeFanart"
        Me.chkMovieResizeFanart.Size = New System.Drawing.Size(133, 17)
        Me.chkMovieResizeFanart.TabIndex = 4
        Me.chkMovieResizeFanart.Text = "Automatically Resize:"
        Me.chkMovieResizeFanart.UseVisualStyleBackColor = true
        '
        'cbMovieFanartSize
        '
        Me.cbMovieFanartSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMovieFanartSize.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.cbMovieFanartSize.FormattingEnabled = true
        Me.cbMovieFanartSize.Location = New System.Drawing.Point(6, 34)
        Me.cbMovieFanartSize.Name = "cbMovieFanartSize"
        Me.cbMovieFanartSize.Size = New System.Drawing.Size(148, 21)
        Me.cbMovieFanartSize.TabIndex = 1
=======
        'lblMovieFanartQ
        '
        Me.lblMovieFanartQ.AutoSize = true
        Me.lblMovieFanartQ.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblMovieFanartQ.Location = New System.Drawing.Point(3, 127)
        Me.lblMovieFanartQ.Name = "lblMovieFanartQ"
        Me.lblMovieFanartQ.Size = New System.Drawing.Size(46, 13)
        Me.lblMovieFanartQ.TabIndex = 9
        Me.lblMovieFanartQ.Text = "Quality:"
        '
        'lblMovieFanartWidth
        '
        Me.lblMovieFanartWidth.AutoSize = true
        Me.lblMovieFanartWidth.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblMovieFanartWidth.Location = New System.Drawing.Point(3, 104)
        Me.lblMovieFanartWidth.Name = "lblMovieFanartWidth"
        Me.lblMovieFanartWidth.Size = New System.Drawing.Size(66, 13)
        Me.lblMovieFanartWidth.TabIndex = 5
        Me.lblMovieFanartWidth.Text = "Max Width:"
        '
        'lblMovieFanartHeight
        '
        Me.lblMovieFanartHeight.AutoSize = true
        Me.lblMovieFanartHeight.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblMovieFanartHeight.Location = New System.Drawing.Point(107, 104)
        Me.lblMovieFanartHeight.Name = "lblMovieFanartHeight"
        Me.lblMovieFanartHeight.Size = New System.Drawing.Size(69, 13)
        Me.lblMovieFanartHeight.TabIndex = 7
        Me.lblMovieFanartHeight.Text = "Max Height:"
        '
        'chkMovieFanartResize
        '
        Me.chkMovieFanartResize.AutoSize = true
        Me.chkMovieFanartResize.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkMovieFanartResize.Location = New System.Drawing.Point(6, 82)
        Me.chkMovieFanartResize.Name = "chkMovieFanartResize"
        Me.chkMovieFanartResize.Size = New System.Drawing.Size(133, 17)
        Me.chkMovieFanartResize.TabIndex = 4
        Me.chkMovieFanartResize.Text = "Automatically Resize:"
        Me.chkMovieFanartResize.UseVisualStyleBackColor = true
        '
        'cbMovieFanartPrefSize
        '
        Me.cbMovieFanartPrefSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMovieFanartPrefSize.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.cbMovieFanartPrefSize.FormattingEnabled = true
        Me.cbMovieFanartPrefSize.Location = New System.Drawing.Point(6, 34)
        Me.cbMovieFanartPrefSize.Name = "cbMovieFanartPrefSize"
        Me.cbMovieFanartPrefSize.Size = New System.Drawing.Size(148, 21)
        Me.cbMovieFanartPrefSize.TabIndex = 1
>>>>>>> upstream/master
        '
        'lblFanartSize
        '
        Me.lblFanartSize.AutoSize = true
        Me.lblFanartSize.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblFanartSize.Location = New System.Drawing.Point(4, 18)
        Me.lblFanartSize.Name = "lblFanartSize"
        Me.lblFanartSize.Size = New System.Drawing.Size(80, 13)
        Me.lblFanartSize.TabIndex = 0
        Me.lblFanartSize.Text = "Preferred Size:"
        '
<<<<<<< HEAD
        'chkMovieOverwriteFanart
        '
        Me.chkMovieOverwriteFanart.AutoSize = true
        Me.chkMovieOverwriteFanart.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkMovieOverwriteFanart.Location = New System.Drawing.Point(6, 62)
        Me.chkMovieOverwriteFanart.Name = "chkMovieOverwriteFanart"
        Me.chkMovieOverwriteFanart.Size = New System.Drawing.Size(119, 17)
        Me.chkMovieOverwriteFanart.TabIndex = 3
        Me.chkMovieOverwriteFanart.Text = "Overwrite Existing"
        Me.chkMovieOverwriteFanart.UseVisualStyleBackColor = true
        '
        'gbMovieImagesPoster
        '
        Me.gbMovieImagesPoster.Controls.Add(Me.chkMoviePosterOnly)
        Me.gbMovieImagesPoster.Controls.Add(Me.txtMoviePosterWidth)
        Me.gbMovieImagesPoster.Controls.Add(Me.txtMoviePosterHeight)
        Me.gbMovieImagesPoster.Controls.Add(Me.lblMoviePosterQual)
        Me.gbMovieImagesPoster.Controls.Add(Me.tbMoviePosterQual)
        Me.gbMovieImagesPoster.Controls.Add(Me.Label24)
        Me.gbMovieImagesPoster.Controls.Add(Me.Label11)
        Me.gbMovieImagesPoster.Controls.Add(Me.Label12)
        Me.gbMovieImagesPoster.Controls.Add(Me.chkMovieResizePoster)
        Me.gbMovieImagesPoster.Controls.Add(Me.lblPosterSize)
        Me.gbMovieImagesPoster.Controls.Add(Me.cbMoviePosterSize)
        Me.gbMovieImagesPoster.Controls.Add(Me.chkMovieOverwritePoster)
        Me.gbMovieImagesPoster.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.gbMovieImagesPoster.Location = New System.Drawing.Point(3, 83)
        Me.gbMovieImagesPoster.Name = "gbMovieImagesPoster"
        Me.gbMovieImagesPoster.Size = New System.Drawing.Size(218, 170)
        Me.gbMovieImagesPoster.TabIndex = 2
        Me.gbMovieImagesPoster.TabStop = false
        Me.gbMovieImagesPoster.Text = "Poster"
        '
        'chkMoviePosterOnly
        '
        Me.chkMoviePosterOnly.AutoSize = true
        Me.chkMoviePosterOnly.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkMoviePosterOnly.Location = New System.Drawing.Point(163, 38)
        Me.chkMoviePosterOnly.Name = "chkMoviePosterOnly"
        Me.chkMoviePosterOnly.Size = New System.Drawing.Size(50, 17)
        Me.chkMoviePosterOnly.TabIndex = 2
        Me.chkMoviePosterOnly.Text = "Only"
        Me.chkMoviePosterOnly.UseVisualStyleBackColor = true
=======
        'chkMovieFanartOverwrite
        '
        Me.chkMovieFanartOverwrite.AutoSize = true
        Me.chkMovieFanartOverwrite.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkMovieFanartOverwrite.Location = New System.Drawing.Point(6, 62)
        Me.chkMovieFanartOverwrite.Name = "chkMovieFanartOverwrite"
        Me.chkMovieFanartOverwrite.Size = New System.Drawing.Size(119, 17)
        Me.chkMovieFanartOverwrite.TabIndex = 3
        Me.chkMovieFanartOverwrite.Text = "Overwrite Existing"
        Me.chkMovieFanartOverwrite.UseVisualStyleBackColor = true
        '
        'gbMoviePosterOpts
        '
        Me.gbMoviePosterOpts.Controls.Add(Me.chkMoviePosterPrefOnly)
        Me.gbMoviePosterOpts.Controls.Add(Me.txtMoviePosterWidth)
        Me.gbMoviePosterOpts.Controls.Add(Me.txtMoviePosterHeight)
        Me.gbMoviePosterOpts.Controls.Add(Me.lblMoviePosterQual)
        Me.gbMoviePosterOpts.Controls.Add(Me.tbMoviePosterQual)
        Me.gbMoviePosterOpts.Controls.Add(Me.lblMoviePosterQ)
        Me.gbMoviePosterOpts.Controls.Add(Me.lblMoviePosterWidth)
        Me.gbMoviePosterOpts.Controls.Add(Me.lblMoviePosterHeight)
        Me.gbMoviePosterOpts.Controls.Add(Me.chkMoviePosterResize)
        Me.gbMoviePosterOpts.Controls.Add(Me.lblMoviePosterSize)
        Me.gbMoviePosterOpts.Controls.Add(Me.cbMoviePosterPrefSize)
        Me.gbMoviePosterOpts.Controls.Add(Me.chkMoviePosterOverwrite)
        Me.gbMoviePosterOpts.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.gbMoviePosterOpts.Location = New System.Drawing.Point(3, 84)
        Me.gbMoviePosterOpts.Name = "gbMoviePosterOpts"
        Me.gbMoviePosterOpts.Size = New System.Drawing.Size(218, 170)
        Me.gbMoviePosterOpts.TabIndex = 2
        Me.gbMoviePosterOpts.TabStop = false
        Me.gbMoviePosterOpts.Text = "Poster"
        '
        'chkMoviePosterPrefOnly
        '
        Me.chkMoviePosterPrefOnly.AutoSize = true
        Me.chkMoviePosterPrefOnly.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkMoviePosterPrefOnly.Location = New System.Drawing.Point(163, 38)
        Me.chkMoviePosterPrefOnly.Name = "chkMoviePosterPrefOnly"
        Me.chkMoviePosterPrefOnly.Size = New System.Drawing.Size(50, 17)
        Me.chkMoviePosterPrefOnly.TabIndex = 2
        Me.chkMoviePosterPrefOnly.Text = "Only"
        Me.chkMoviePosterPrefOnly.UseVisualStyleBackColor = true
>>>>>>> upstream/master
        '
        'txtMoviePosterWidth
        '
        Me.txtMoviePosterWidth.Enabled = false
        Me.txtMoviePosterWidth.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtMoviePosterWidth.Location = New System.Drawing.Point(68, 100)
        Me.txtMoviePosterWidth.Name = "txtMoviePosterWidth"
        Me.txtMoviePosterWidth.Size = New System.Drawing.Size(40, 22)
        Me.txtMoviePosterWidth.TabIndex = 6
        '
        'txtMoviePosterHeight
        '
        Me.txtMoviePosterHeight.Enabled = false
        Me.txtMoviePosterHeight.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtMoviePosterHeight.Location = New System.Drawing.Point(175, 100)
        Me.txtMoviePosterHeight.Name = "txtMoviePosterHeight"
        Me.txtMoviePosterHeight.Size = New System.Drawing.Size(40, 22)
        Me.txtMoviePosterHeight.TabIndex = 8
        '
        'lblMoviePosterQual
        '
        Me.lblMoviePosterQual.AutoSize = true
        Me.lblMoviePosterQual.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.lblMoviePosterQual.Location = New System.Drawing.Point(183, 147)
        Me.lblMoviePosterQual.Name = "lblMoviePosterQual"
        Me.lblMoviePosterQual.Size = New System.Drawing.Size(29, 17)
        Me.lblMoviePosterQual.TabIndex = 11
        Me.lblMoviePosterQual.Text = "100"
        '
        'tbMoviePosterQual
        '
        Me.tbMoviePosterQual.AutoSize = false
        Me.tbMoviePosterQual.LargeChange = 10
        Me.tbMoviePosterQual.Location = New System.Drawing.Point(7, 139)
        Me.tbMoviePosterQual.Maximum = 100
        Me.tbMoviePosterQual.Name = "tbMoviePosterQual"
        Me.tbMoviePosterQual.Size = New System.Drawing.Size(179, 27)
        Me.tbMoviePosterQual.TabIndex = 10
        Me.tbMoviePosterQual.TickFrequency = 10
        Me.tbMoviePosterQual.Value = 100
        '
<<<<<<< HEAD
        'Label24
        '
        Me.Label24.AutoSize = true
        Me.Label24.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label24.Location = New System.Drawing.Point(3, 127)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(46, 13)
        Me.Label24.TabIndex = 9
        Me.Label24.Text = "Quality:"
        '
        'Label11
        '
        Me.Label11.AutoSize = true
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label11.Location = New System.Drawing.Point(3, 104)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(66, 13)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "Max Width:"
        '
        'Label12
        '
        Me.Label12.AutoSize = true
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label12.Location = New System.Drawing.Point(106, 104)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(69, 13)
        Me.Label12.TabIndex = 7
        Me.Label12.Text = "Max Height:"
        '
        'chkMovieResizePoster
        '
        Me.chkMovieResizePoster.AutoSize = true
        Me.chkMovieResizePoster.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkMovieResizePoster.Location = New System.Drawing.Point(6, 82)
        Me.chkMovieResizePoster.Name = "chkMovieResizePoster"
        Me.chkMovieResizePoster.Size = New System.Drawing.Size(133, 17)
        Me.chkMovieResizePoster.TabIndex = 4
        Me.chkMovieResizePoster.Text = "Automatically Resize:"
        Me.chkMovieResizePoster.UseVisualStyleBackColor = true
        '
        'lblPosterSize
        '
        Me.lblPosterSize.AutoSize = true
        Me.lblPosterSize.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblPosterSize.Location = New System.Drawing.Point(4, 18)
        Me.lblPosterSize.Name = "lblPosterSize"
        Me.lblPosterSize.Size = New System.Drawing.Size(80, 13)
        Me.lblPosterSize.TabIndex = 0
        Me.lblPosterSize.Text = "Preferred Size:"
        '
        'cbMoviePosterSize
        '
        Me.cbMoviePosterSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMoviePosterSize.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.cbMoviePosterSize.FormattingEnabled = true
        Me.cbMoviePosterSize.Location = New System.Drawing.Point(6, 34)
        Me.cbMoviePosterSize.Name = "cbMoviePosterSize"
        Me.cbMoviePosterSize.Size = New System.Drawing.Size(148, 21)
        Me.cbMoviePosterSize.TabIndex = 1
        '
        'chkMovieOverwritePoster
        '
        Me.chkMovieOverwritePoster.AutoSize = true
        Me.chkMovieOverwritePoster.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkMovieOverwritePoster.Location = New System.Drawing.Point(6, 62)
        Me.chkMovieOverwritePoster.Name = "chkMovieOverwritePoster"
        Me.chkMovieOverwritePoster.Size = New System.Drawing.Size(119, 17)
        Me.chkMovieOverwritePoster.TabIndex = 3
        Me.chkMovieOverwritePoster.Text = "Overwrite Existing"
        Me.chkMovieOverwritePoster.UseVisualStyleBackColor = true
        '
        'lbGenre
        '
        Me.lbGenre.CheckOnClick = true
        Me.lbGenre.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.lbGenre.FormattingEnabled = true
        Me.lbGenre.IntegralHeight = false
        Me.lbGenre.Location = New System.Drawing.Point(10, 18)
        Me.lbGenre.Name = "lbGenre"
        Me.lbGenre.Size = New System.Drawing.Size(157, 97)
        Me.lbGenre.Sorted = true
        Me.lbGenre.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkMovieWatchedCol)
        Me.GroupBox2.Controls.Add(Me.chkMovieEFanartsCol)
        Me.GroupBox2.Controls.Add(Me.txtCheckTitleTol)
        Me.GroupBox2.Controls.Add(Me.Label30)
        Me.GroupBox2.Controls.Add(Me.chkCheckTitles)
        Me.GroupBox2.Controls.Add(Me.GroupBox25)
        Me.GroupBox2.Controls.Add(Me.chkDisplayYear)
        Me.GroupBox2.Controls.Add(Me.chkMovieEThumbsCol)
        Me.GroupBox2.Controls.Add(Me.chkMovieSubCol)
        Me.GroupBox2.Controls.Add(Me.chkMovieTrailerCol)
        Me.GroupBox2.Controls.Add(Me.chkMovieInfoCol)
        Me.GroupBox2.Controls.Add(Me.chkMovieFanartCol)
        Me.GroupBox2.Controls.Add(Me.chkMoviePosterCol)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(7, 106)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(218, 306)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = false
        Me.GroupBox2.Text = "Media List Options"
=======
        'lblMoviePosterQ
        '
        Me.lblMoviePosterQ.AutoSize = true
        Me.lblMoviePosterQ.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblMoviePosterQ.Location = New System.Drawing.Point(3, 127)
        Me.lblMoviePosterQ.Name = "lblMoviePosterQ"
        Me.lblMoviePosterQ.Size = New System.Drawing.Size(46, 13)
        Me.lblMoviePosterQ.TabIndex = 9
        Me.lblMoviePosterQ.Text = "Quality:"
        '
        'lblMoviePosterWidth
        '
        Me.lblMoviePosterWidth.AutoSize = true
        Me.lblMoviePosterWidth.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblMoviePosterWidth.Location = New System.Drawing.Point(3, 104)
        Me.lblMoviePosterWidth.Name = "lblMoviePosterWidth"
        Me.lblMoviePosterWidth.Size = New System.Drawing.Size(66, 13)
        Me.lblMoviePosterWidth.TabIndex = 5
        Me.lblMoviePosterWidth.Text = "Max Width:"
        '
        'lblMoviePosterHeight
        '
        Me.lblMoviePosterHeight.AutoSize = true
        Me.lblMoviePosterHeight.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblMoviePosterHeight.Location = New System.Drawing.Point(106, 104)
        Me.lblMoviePosterHeight.Name = "lblMoviePosterHeight"
        Me.lblMoviePosterHeight.Size = New System.Drawing.Size(69, 13)
        Me.lblMoviePosterHeight.TabIndex = 7
        Me.lblMoviePosterHeight.Text = "Max Height:"
        '
        'chkMoviePosterResize
        '
        Me.chkMoviePosterResize.AutoSize = true
        Me.chkMoviePosterResize.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkMoviePosterResize.Location = New System.Drawing.Point(6, 82)
        Me.chkMoviePosterResize.Name = "chkMoviePosterResize"
        Me.chkMoviePosterResize.Size = New System.Drawing.Size(133, 17)
        Me.chkMoviePosterResize.TabIndex = 4
        Me.chkMoviePosterResize.Text = "Automatically Resize:"
        Me.chkMoviePosterResize.UseVisualStyleBackColor = true
        '
        'lblMoviePosterSize
        '
        Me.lblMoviePosterSize.AutoSize = true
        Me.lblMoviePosterSize.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblMoviePosterSize.Location = New System.Drawing.Point(4, 18)
        Me.lblMoviePosterSize.Name = "lblMoviePosterSize"
        Me.lblMoviePosterSize.Size = New System.Drawing.Size(80, 13)
        Me.lblMoviePosterSize.TabIndex = 0
        Me.lblMoviePosterSize.Text = "Preferred Size:"
        '
        'cbMoviePosterPrefSize
        '
        Me.cbMoviePosterPrefSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMoviePosterPrefSize.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.cbMoviePosterPrefSize.FormattingEnabled = true
        Me.cbMoviePosterPrefSize.Location = New System.Drawing.Point(6, 34)
        Me.cbMoviePosterPrefSize.Name = "cbMoviePosterPrefSize"
        Me.cbMoviePosterPrefSize.Size = New System.Drawing.Size(148, 21)
        Me.cbMoviePosterPrefSize.TabIndex = 1
        '
        'chkMoviePosterOverwrite
        '
        Me.chkMoviePosterOverwrite.AutoSize = true
        Me.chkMoviePosterOverwrite.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkMoviePosterOverwrite.Location = New System.Drawing.Point(6, 62)
        Me.chkMoviePosterOverwrite.Name = "chkMoviePosterOverwrite"
        Me.chkMoviePosterOverwrite.Size = New System.Drawing.Size(119, 17)
        Me.chkMoviePosterOverwrite.TabIndex = 3
        Me.chkMoviePosterOverwrite.Text = "Overwrite Existing"
        Me.chkMoviePosterOverwrite.UseVisualStyleBackColor = true
        '
        'clbMovieGenre
        '
        Me.clbMovieGenre.CheckOnClick = true
        Me.clbMovieGenre.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.clbMovieGenre.FormattingEnabled = true
        Me.clbMovieGenre.IntegralHeight = false
        Me.clbMovieGenre.Location = New System.Drawing.Point(10, 18)
        Me.clbMovieGenre.Name = "clbMovieGenre"
        Me.clbMovieGenre.Size = New System.Drawing.Size(157, 97)
        Me.clbMovieGenre.Sorted = true
        Me.clbMovieGenre.TabIndex = 0
        '
        'gbMovieGeneralMediaListOpts
        '
        Me.gbMovieGeneralMediaListOpts.Controls.Add(Me.chkMovieWatchedCol)
        Me.gbMovieGeneralMediaListOpts.Controls.Add(Me.chkMovieEFanartsCol)
        Me.gbMovieGeneralMediaListOpts.Controls.Add(Me.txtMovieLevTolerance)
        Me.gbMovieGeneralMediaListOpts.Controls.Add(Me.lblMovieLevTolerance)
        Me.gbMovieGeneralMediaListOpts.Controls.Add(Me.chkMovieLevTolerance)
        Me.gbMovieGeneralMediaListOpts.Controls.Add(Me.gbMovieSortTokensOpts)
        Me.gbMovieGeneralMediaListOpts.Controls.Add(Me.chkMovieDisplayYear)
        Me.gbMovieGeneralMediaListOpts.Controls.Add(Me.chkMovieEThumbsCol)
        Me.gbMovieGeneralMediaListOpts.Controls.Add(Me.chkMovieSubCol)
        Me.gbMovieGeneralMediaListOpts.Controls.Add(Me.chkMovieTrailerCol)
        Me.gbMovieGeneralMediaListOpts.Controls.Add(Me.chkMovieInfoCol)
        Me.gbMovieGeneralMediaListOpts.Controls.Add(Me.chkMovieFanartCol)
        Me.gbMovieGeneralMediaListOpts.Controls.Add(Me.chkMoviePosterCol)
        Me.gbMovieGeneralMediaListOpts.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.gbMovieGeneralMediaListOpts.Location = New System.Drawing.Point(3, 102)
        Me.gbMovieGeneralMediaListOpts.Name = "gbMovieGeneralMediaListOpts"
        Me.gbMovieGeneralMediaListOpts.Size = New System.Drawing.Size(219, 395)
        Me.gbMovieGeneralMediaListOpts.TabIndex = 4
        Me.gbMovieGeneralMediaListOpts.TabStop = false
        Me.gbMovieGeneralMediaListOpts.Text = "Media List Options"
>>>>>>> upstream/master
        '
        'chkMovieWatchedCol
        '
        Me.chkMovieWatchedCol.AutoSize = true
        Me.chkMovieWatchedCol.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
<<<<<<< HEAD
        Me.chkMovieWatchedCol.Location = New System.Drawing.Point(9, 290)
=======
        Me.chkMovieWatchedCol.Location = New System.Drawing.Point(6, 372)
>>>>>>> upstream/master
        Me.chkMovieWatchedCol.Name = "chkMovieWatchedCol"
        Me.chkMovieWatchedCol.Size = New System.Drawing.Size(142, 17)
        Me.chkMovieWatchedCol.TabIndex = 76
        Me.chkMovieWatchedCol.Text = "Hide Watched Column"
        Me.chkMovieWatchedCol.UseVisualStyleBackColor = true
        '
        'chkMovieEFanartsCol
        '
        Me.chkMovieEFanartsCol.AutoSize = true
        Me.chkMovieEFanartsCol.Enabled = false
        Me.chkMovieEFanartsCol.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
<<<<<<< HEAD
        Me.chkMovieEFanartsCol.Location = New System.Drawing.Point(9, 274)
=======
        Me.chkMovieEFanartsCol.Location = New System.Drawing.Point(6, 349)
>>>>>>> upstream/master
        Me.chkMovieEFanartsCol.Name = "chkMovieEFanartsCol"
        Me.chkMovieEFanartsCol.Size = New System.Drawing.Size(152, 17)
        Me.chkMovieEFanartsCol.TabIndex = 75
        Me.chkMovieEFanartsCol.Text = "Hide Extrafanart Column"
        Me.chkMovieEFanartsCol.UseVisualStyleBackColor = true
        '
<<<<<<< HEAD
        'txtCheckTitleTol
        '
        Me.txtCheckTitleTol.Enabled = false
        Me.txtCheckTitleTol.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtCheckTitleTol.Location = New System.Drawing.Point(142, 50)
        Me.txtCheckTitleTol.Name = "txtCheckTitleTol"
        Me.txtCheckTitleTol.Size = New System.Drawing.Size(61, 22)
        Me.txtCheckTitleTol.TabIndex = 74
        '
        'Label30
        '
        Me.Label30.AutoSize = true
        Me.Label30.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label30.Location = New System.Drawing.Point(27, 54)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(111, 13)
        Me.Label30.TabIndex = 73
        Me.Label30.Text = "Mismatch Tolerance:"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'chkCheckTitles
        '
        Me.chkCheckTitles.AutoSize = true
        Me.chkCheckTitles.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkCheckTitles.Location = New System.Drawing.Point(8, 35)
        Me.chkCheckTitles.Name = "chkCheckTitles"
        Me.chkCheckTitles.Size = New System.Drawing.Size(178, 17)
        Me.chkCheckTitles.TabIndex = 72
        Me.chkCheckTitles.Text = "Check Title Match Confidence"
        Me.chkCheckTitles.UseVisualStyleBackColor = true
        '
        'GroupBox25
        '
        Me.GroupBox25.Controls.Add(Me.btnRemoveToken)
        Me.GroupBox25.Controls.Add(Me.btnAddToken)
        Me.GroupBox25.Controls.Add(Me.txtSortToken)
        Me.GroupBox25.Controls.Add(Me.lstSortTokens)
        Me.GroupBox25.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.GroupBox25.Location = New System.Drawing.Point(9, 73)
        Me.GroupBox25.Name = "GroupBox25"
        Me.GroupBox25.Size = New System.Drawing.Size(200, 102)
        Me.GroupBox25.TabIndex = 71
        Me.GroupBox25.TabStop = false
        Me.GroupBox25.Text = "Sort Tokens to Ignore"
        '
        'btnRemoveToken
        '
        Me.btnRemoveToken.Image = CType(resources.GetObject("btnRemoveToken.Image"),System.Drawing.Image)
        Me.btnRemoveToken.Location = New System.Drawing.Point(168, 72)
        Me.btnRemoveToken.Name = "btnRemoveToken"
        Me.btnRemoveToken.Size = New System.Drawing.Size(23, 23)
        Me.btnRemoveToken.TabIndex = 3
        Me.btnRemoveToken.UseVisualStyleBackColor = true
        '
        'btnAddToken
        '
        Me.btnAddToken.Image = CType(resources.GetObject("btnAddToken.Image"),System.Drawing.Image)
        Me.btnAddToken.Location = New System.Drawing.Point(72, 72)
        Me.btnAddToken.Name = "btnAddToken"
        Me.btnAddToken.Size = New System.Drawing.Size(23, 23)
        Me.btnAddToken.TabIndex = 2
        Me.btnAddToken.UseVisualStyleBackColor = true
        '
        'txtSortToken
        '
        Me.txtSortToken.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtSortToken.Location = New System.Drawing.Point(10, 73)
        Me.txtSortToken.Name = "txtSortToken"
        Me.txtSortToken.Size = New System.Drawing.Size(61, 22)
        Me.txtSortToken.TabIndex = 1
        '
        'lstSortTokens
        '
        Me.lstSortTokens.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.lstSortTokens.FormattingEnabled = true
        Me.lstSortTokens.Location = New System.Drawing.Point(10, 15)
        Me.lstSortTokens.Name = "lstSortTokens"
        Me.lstSortTokens.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lstSortTokens.Size = New System.Drawing.Size(180, 43)
        Me.lstSortTokens.Sorted = true
        Me.lstSortTokens.TabIndex = 0
        '
        'chkDisplayYear
        '
        Me.chkDisplayYear.AutoSize = true
        Me.chkDisplayYear.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkDisplayYear.Location = New System.Drawing.Point(8, 19)
        Me.chkDisplayYear.Name = "chkDisplayYear"
        Me.chkDisplayYear.Size = New System.Drawing.Size(144, 17)
        Me.chkDisplayYear.TabIndex = 70
        Me.chkDisplayYear.Text = "Display Year in List Title"
        Me.chkDisplayYear.UseVisualStyleBackColor = true
=======
        'txtMovieLevTolerance
        '
        Me.txtMovieLevTolerance.Enabled = false
        Me.txtMovieLevTolerance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtMovieLevTolerance.Location = New System.Drawing.Point(144, 58)
        Me.txtMovieLevTolerance.Name = "txtMovieLevTolerance"
        Me.txtMovieLevTolerance.Size = New System.Drawing.Size(61, 22)
        Me.txtMovieLevTolerance.TabIndex = 74
        '
        'lblMovieLevTolerance
        '
        Me.lblMovieLevTolerance.AutoSize = true
        Me.lblMovieLevTolerance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblMovieLevTolerance.Location = New System.Drawing.Point(27, 61)
        Me.lblMovieLevTolerance.Name = "lblMovieLevTolerance"
        Me.lblMovieLevTolerance.Size = New System.Drawing.Size(111, 13)
        Me.lblMovieLevTolerance.TabIndex = 73
        Me.lblMovieLevTolerance.Text = "Mismatch Tolerance:"
        Me.lblMovieLevTolerance.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'chkMovieLevTolerance
        '
        Me.chkMovieLevTolerance.AutoSize = true
        Me.chkMovieLevTolerance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkMovieLevTolerance.Location = New System.Drawing.Point(8, 35)
        Me.chkMovieLevTolerance.Name = "chkMovieLevTolerance"
        Me.chkMovieLevTolerance.Size = New System.Drawing.Size(178, 17)
        Me.chkMovieLevTolerance.TabIndex = 72
        Me.chkMovieLevTolerance.Text = "Check Title Match Confidence"
        Me.chkMovieLevTolerance.UseVisualStyleBackColor = true
        '
        'gbMovieSortTokensOpts
        '
        Me.gbMovieSortTokensOpts.Controls.Add(Me.btnMovieSortTokenRemove)
        Me.gbMovieSortTokensOpts.Controls.Add(Me.btnMovieSortTokenAdd)
        Me.gbMovieSortTokensOpts.Controls.Add(Me.txtMovieSortToken)
        Me.gbMovieSortTokensOpts.Controls.Add(Me.lstMovieSortTokens)
        Me.gbMovieSortTokensOpts.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.gbMovieSortTokensOpts.Location = New System.Drawing.Point(8, 89)
        Me.gbMovieSortTokensOpts.Name = "gbMovieSortTokensOpts"
        Me.gbMovieSortTokensOpts.Size = New System.Drawing.Size(200, 102)
        Me.gbMovieSortTokensOpts.TabIndex = 71
        Me.gbMovieSortTokensOpts.TabStop = false
        Me.gbMovieSortTokensOpts.Text = "Sort Tokens to Ignore"
        '
        'btnMovieSortTokenRemove
        '
        Me.btnMovieSortTokenRemove.Image = CType(resources.GetObject("btnMovieSortTokenRemove.Image"),System.Drawing.Image)
        Me.btnMovieSortTokenRemove.Location = New System.Drawing.Point(168, 72)
        Me.btnMovieSortTokenRemove.Name = "btnMovieSortTokenRemove"
        Me.btnMovieSortTokenRemove.Size = New System.Drawing.Size(23, 23)
        Me.btnMovieSortTokenRemove.TabIndex = 3
        Me.btnMovieSortTokenRemove.UseVisualStyleBackColor = true
        '
        'btnMovieSortTokenAdd
        '
        Me.btnMovieSortTokenAdd.Image = CType(resources.GetObject("btnMovieSortTokenAdd.Image"),System.Drawing.Image)
        Me.btnMovieSortTokenAdd.Location = New System.Drawing.Point(72, 72)
        Me.btnMovieSortTokenAdd.Name = "btnMovieSortTokenAdd"
        Me.btnMovieSortTokenAdd.Size = New System.Drawing.Size(23, 23)
        Me.btnMovieSortTokenAdd.TabIndex = 2
        Me.btnMovieSortTokenAdd.UseVisualStyleBackColor = true
        '
        'txtMovieSortToken
        '
        Me.txtMovieSortToken.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtMovieSortToken.Location = New System.Drawing.Point(10, 73)
        Me.txtMovieSortToken.Name = "txtMovieSortToken"
        Me.txtMovieSortToken.Size = New System.Drawing.Size(61, 22)
        Me.txtMovieSortToken.TabIndex = 1
        '
        'lstMovieSortTokens
        '
        Me.lstMovieSortTokens.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.lstMovieSortTokens.FormattingEnabled = true
        Me.lstMovieSortTokens.Location = New System.Drawing.Point(10, 15)
        Me.lstMovieSortTokens.Name = "lstMovieSortTokens"
        Me.lstMovieSortTokens.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lstMovieSortTokens.Size = New System.Drawing.Size(180, 43)
        Me.lstMovieSortTokens.Sorted = true
        Me.lstMovieSortTokens.TabIndex = 0
        '
        'chkMovieDisplayYear
        '
        Me.chkMovieDisplayYear.AutoSize = true
        Me.chkMovieDisplayYear.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkMovieDisplayYear.Location = New System.Drawing.Point(8, 19)
        Me.chkMovieDisplayYear.Name = "chkMovieDisplayYear"
        Me.chkMovieDisplayYear.Size = New System.Drawing.Size(144, 17)
        Me.chkMovieDisplayYear.TabIndex = 70
        Me.chkMovieDisplayYear.Text = "Display Year in List Title"
        Me.chkMovieDisplayYear.UseVisualStyleBackColor = true
>>>>>>> upstream/master
        '
        'chkMovieEThumbsCol
        '
        Me.chkMovieEThumbsCol.AutoSize = true
        Me.chkMovieEThumbsCol.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
<<<<<<< HEAD
        Me.chkMovieEThumbsCol.Location = New System.Drawing.Point(9, 258)
=======
        Me.chkMovieEThumbsCol.Location = New System.Drawing.Point(6, 326)
>>>>>>> upstream/master
        Me.chkMovieEThumbsCol.Name = "chkMovieEThumbsCol"
        Me.chkMovieEThumbsCol.Size = New System.Drawing.Size(155, 17)
        Me.chkMovieEThumbsCol.TabIndex = 5
        Me.chkMovieEThumbsCol.Text = "Hide Extrathumb Column"
        Me.chkMovieEThumbsCol.UseVisualStyleBackColor = true
        '
        'chkMovieSubCol
        '
        Me.chkMovieSubCol.AutoSize = true
        Me.chkMovieSubCol.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
<<<<<<< HEAD
        Me.chkMovieSubCol.Location = New System.Drawing.Point(9, 242)
=======
        Me.chkMovieSubCol.Location = New System.Drawing.Point(6, 303)
>>>>>>> upstream/master
        Me.chkMovieSubCol.Name = "chkMovieSubCol"
        Me.chkMovieSubCol.Size = New System.Drawing.Size(116, 17)
        Me.chkMovieSubCol.TabIndex = 4
        Me.chkMovieSubCol.Text = "Hide Sub Column"
        Me.chkMovieSubCol.UseVisualStyleBackColor = true
        '
        'chkMovieTrailerCol
        '
        Me.chkMovieTrailerCol.AutoSize = true
        Me.chkMovieTrailerCol.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
<<<<<<< HEAD
        Me.chkMovieTrailerCol.Location = New System.Drawing.Point(9, 226)
=======
        Me.chkMovieTrailerCol.Location = New System.Drawing.Point(6, 280)
>>>>>>> upstream/master
        Me.chkMovieTrailerCol.Name = "chkMovieTrailerCol"
        Me.chkMovieTrailerCol.Size = New System.Drawing.Size(127, 17)
        Me.chkMovieTrailerCol.TabIndex = 3
        Me.chkMovieTrailerCol.Text = "Hide Trailer Column"
        Me.chkMovieTrailerCol.UseVisualStyleBackColor = true
        '
        'chkMovieInfoCol
        '
        Me.chkMovieInfoCol.AutoSize = true
        Me.chkMovieInfoCol.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
<<<<<<< HEAD
        Me.chkMovieInfoCol.Location = New System.Drawing.Point(9, 210)
=======
        Me.chkMovieInfoCol.Location = New System.Drawing.Point(6, 257)
>>>>>>> upstream/master
        Me.chkMovieInfoCol.Name = "chkMovieInfoCol"
        Me.chkMovieInfoCol.Size = New System.Drawing.Size(117, 17)
        Me.chkMovieInfoCol.TabIndex = 2
        Me.chkMovieInfoCol.Text = "Hide Info Column"
        Me.chkMovieInfoCol.UseVisualStyleBackColor = true
        '
        'chkMovieFanartCol
        '
        Me.chkMovieFanartCol.AutoSize = true
        Me.chkMovieFanartCol.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
<<<<<<< HEAD
        Me.chkMovieFanartCol.Location = New System.Drawing.Point(9, 194)
=======
        Me.chkMovieFanartCol.Location = New System.Drawing.Point(6, 234)
>>>>>>> upstream/master
        Me.chkMovieFanartCol.Name = "chkMovieFanartCol"
        Me.chkMovieFanartCol.Size = New System.Drawing.Size(129, 17)
        Me.chkMovieFanartCol.TabIndex = 1
        Me.chkMovieFanartCol.Text = "Hide Fanart Column"
        Me.chkMovieFanartCol.UseVisualStyleBackColor = true
        '
        'chkMoviePosterCol
        '
        Me.chkMoviePosterCol.AutoSize = true
        Me.chkMoviePosterCol.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
<<<<<<< HEAD
        Me.chkMoviePosterCol.Location = New System.Drawing.Point(9, 178)
=======
        Me.chkMoviePosterCol.Location = New System.Drawing.Point(6, 211)
>>>>>>> upstream/master
        Me.chkMoviePosterCol.Name = "chkMoviePosterCol"
        Me.chkMoviePosterCol.Size = New System.Drawing.Size(128, 17)
        Me.chkMoviePosterCol.TabIndex = 0
        Me.chkMoviePosterCol.Text = "Hide Poster Column"
        Me.chkMoviePosterCol.UseVisualStyleBackColor = true
        '
<<<<<<< HEAD
        'lvMovies
        '
        Me.lvMovies.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colID, Me.colName, Me.colPath, Me.colRecur, Me.colFolder, Me.colSingle})
        Me.lvMovies.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.lvMovies.FullRowSelect = true
        Me.lvMovies.HideSelection = false
        Me.lvMovies.Location = New System.Drawing.Point(5, 6)
        Me.lvMovies.Name = "lvMovies"
        Me.lvMovies.Size = New System.Drawing.Size(627, 105)
        Me.lvMovies.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.lvMovies.TabIndex = 0
        Me.lvMovies.UseCompatibleStateImageBehavior = false
        Me.lvMovies.View = System.Windows.Forms.View.Details
=======
        'lvMovieSources
        '
        Me.lvMovieSources.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colID, Me.colName, Me.colPath, Me.colRecur, Me.colFolder, Me.colSingle})
        Me.lvMovieSources.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.lvMovieSources.FullRowSelect = true
        Me.lvMovieSources.HideSelection = false
        Me.lvMovieSources.Location = New System.Drawing.Point(5, 6)
        Me.lvMovieSources.Name = "lvMovieSources"
        Me.lvMovieSources.Size = New System.Drawing.Size(627, 105)
        Me.lvMovieSources.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.lvMovieSources.TabIndex = 0
        Me.lvMovieSources.UseCompatibleStateImageBehavior = false
        Me.lvMovieSources.View = System.Windows.Forms.View.Details
>>>>>>> upstream/master
        '
        'colID
        '
        Me.colID.Width = 0
        '
        'colName
        '
        Me.colName.Text = "Name"
        Me.colName.Width = 100
        '
        'colPath
        '
        Me.colPath.Text = "Path"
        Me.colPath.Width = 235
        '
        'colRecur
        '
        Me.colRecur.Text = "Recursive"
        Me.colRecur.Width = 78
        '
        'colFolder
        '
        Me.colFolder.Text = "Use Folder Name"
        Me.colFolder.Width = 116
        '
        'colSingle
        '
        Me.colSingle.Text = "Single Video"
        Me.colSingle.Width = 90
        '
<<<<<<< HEAD
        'btnMovieRem
        '
        Me.btnMovieRem.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnMovieRem.Image = CType(resources.GetObject("btnMovieRem.Image"),System.Drawing.Image)
        Me.btnMovieRem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMovieRem.Location = New System.Drawing.Point(638, 88)
        Me.btnMovieRem.Name = "btnMovieRem"
        Me.btnMovieRem.Size = New System.Drawing.Size(104, 23)
        Me.btnMovieRem.TabIndex = 3
        Me.btnMovieRem.Text = "Remove"
        Me.btnMovieRem.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnMovieRem.UseVisualStyleBackColor = true
        '
        'btnMovieAddFolder
        '
        Me.btnMovieAddFolder.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnMovieAddFolder.Image = CType(resources.GetObject("btnMovieAddFolder.Image"),System.Drawing.Image)
        Me.btnMovieAddFolder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMovieAddFolder.Location = New System.Drawing.Point(638, 6)
        Me.btnMovieAddFolder.Name = "btnMovieAddFolder"
        Me.btnMovieAddFolder.Size = New System.Drawing.Size(104, 23)
        Me.btnMovieAddFolder.TabIndex = 1
        Me.btnMovieAddFolder.Text = "Add Source"
        Me.btnMovieAddFolder.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnMovieAddFolder.UseVisualStyleBackColor = true
=======
        'btnMovieSourceRemove
        '
        Me.btnMovieSourceRemove.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnMovieSourceRemove.Image = CType(resources.GetObject("btnMovieSourceRemove.Image"),System.Drawing.Image)
        Me.btnMovieSourceRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMovieSourceRemove.Location = New System.Drawing.Point(638, 88)
        Me.btnMovieSourceRemove.Name = "btnMovieSourceRemove"
        Me.btnMovieSourceRemove.Size = New System.Drawing.Size(104, 23)
        Me.btnMovieSourceRemove.TabIndex = 3
        Me.btnMovieSourceRemove.Text = "Remove"
        Me.btnMovieSourceRemove.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnMovieSourceRemove.UseVisualStyleBackColor = true
        '
        'btnMovieSourceAdd
        '
        Me.btnMovieSourceAdd.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnMovieSourceAdd.Image = CType(resources.GetObject("btnMovieSourceAdd.Image"),System.Drawing.Image)
        Me.btnMovieSourceAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMovieSourceAdd.Location = New System.Drawing.Point(638, 6)
        Me.btnMovieSourceAdd.Name = "btnMovieSourceAdd"
        Me.btnMovieSourceAdd.Size = New System.Drawing.Size(104, 23)
        Me.btnMovieSourceAdd.TabIndex = 1
        Me.btnMovieSourceAdd.Text = "Add Source"
        Me.btnMovieSourceAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnMovieSourceAdd.UseVisualStyleBackColor = true
>>>>>>> upstream/master
        '
        'btnOK
        '
        Me.btnOK.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.btnOK.Location = New System.Drawing.Point(929, 703)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 0
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = true
        '
        'btnApply
        '
        Me.btnApply.Enabled = false
        Me.btnApply.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.btnApply.Location = New System.Drawing.Point(766, 703)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(75, 23)
        Me.btnApply.TabIndex = 2
        Me.btnApply.Text = "Apply"
        Me.btnApply.UseVisualStyleBackColor = true
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.btnCancel.Location = New System.Drawing.Point(848, 703)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = true
        '
<<<<<<< HEAD
        'pnlTop
        '
        Me.pnlTop.BackColor = System.Drawing.Color.SteelBlue
        Me.pnlTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlTop.Controls.Add(Me.lblTopDetails)
        Me.pnlTop.Controls.Add(Me.lblTopTitle)
        Me.pnlTop.Controls.Add(Me.pbTopLogo)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(1008, 64)
        Me.pnlTop.TabIndex = 3
        '
        'lblTopDetails
        '
        Me.lblTopDetails.AutoSize = True
        Me.lblTopDetails.BackColor = System.Drawing.Color.Transparent
        Me.lblTopDetails.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblTopDetails.ForeColor = System.Drawing.Color.White
        Me.lblTopDetails.Location = New System.Drawing.Point(61, 38)
        Me.lblTopDetails.Name = "lblTopDetails"
        Me.lblTopDetails.Size = New System.Drawing.Size(245, 13)
        Me.lblTopDetails.TabIndex = 1
        Me.lblTopDetails.Text = "Configure Ember's appearance and operation."
        '
        'lblTopTitle
        '
        Me.lblTopTitle.AutoSize = True
        Me.lblTopTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTopTitle.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblTopTitle.ForeColor = System.Drawing.Color.White
        Me.lblTopTitle.Location = New System.Drawing.Point(58, 3)
        Me.lblTopTitle.Name = "lblTopTitle"
        Me.lblTopTitle.Size = New System.Drawing.Size(107, 32)
        Me.lblTopTitle.TabIndex = 0
        Me.lblTopTitle.Text = "Settings"
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
=======
        'pnlSettingsTop
        '
        Me.pnlSettingsTop.BackColor = System.Drawing.Color.SteelBlue
        Me.pnlSettingsTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlSettingsTop.Controls.Add(Me.lblSettingsTopDetails)
        Me.pnlSettingsTop.Controls.Add(Me.lblSettingsTopTitle)
        Me.pnlSettingsTop.Controls.Add(Me.pbSettingsTopLogo)
        Me.pnlSettingsTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlSettingsTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlSettingsTop.Name = "pnlSettingsTop"
        Me.pnlSettingsTop.Size = New System.Drawing.Size(1008, 64)
        Me.pnlSettingsTop.TabIndex = 3
        '
        'lblSettingsTopDetails
        '
        Me.lblSettingsTopDetails.AutoSize = true
        Me.lblSettingsTopDetails.BackColor = System.Drawing.Color.Transparent
        Me.lblSettingsTopDetails.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.lblSettingsTopDetails.ForeColor = System.Drawing.Color.White
        Me.lblSettingsTopDetails.Location = New System.Drawing.Point(61, 38)
        Me.lblSettingsTopDetails.Name = "lblSettingsTopDetails"
        Me.lblSettingsTopDetails.Size = New System.Drawing.Size(245, 13)
        Me.lblSettingsTopDetails.TabIndex = 1
        Me.lblSettingsTopDetails.Text = "Configure Ember's appearance and operation."
        '
        'lblSettingsTopTitle
        '
        Me.lblSettingsTopTitle.AutoSize = true
        Me.lblSettingsTopTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblSettingsTopTitle.Font = New System.Drawing.Font("Segoe UI", 18!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.lblSettingsTopTitle.ForeColor = System.Drawing.Color.White
        Me.lblSettingsTopTitle.Location = New System.Drawing.Point(58, 3)
        Me.lblSettingsTopTitle.Name = "lblSettingsTopTitle"
        Me.lblSettingsTopTitle.Size = New System.Drawing.Size(107, 32)
        Me.lblSettingsTopTitle.TabIndex = 0
        Me.lblSettingsTopTitle.Text = "Settings"
        '
        'pbSettingsTopLogo
        '
        Me.pbSettingsTopLogo.BackColor = System.Drawing.Color.Transparent
        Me.pbSettingsTopLogo.Image = CType(resources.GetObject("pbSettingsTopLogo.Image"),System.Drawing.Image)
        Me.pbSettingsTopLogo.Location = New System.Drawing.Point(7, 8)
        Me.pbSettingsTopLogo.Name = "pbSettingsTopLogo"
        Me.pbSettingsTopLogo.Size = New System.Drawing.Size(48, 48)
        Me.pbSettingsTopLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pbSettingsTopLogo.TabIndex = 0
        Me.pbSettingsTopLogo.TabStop = false
>>>>>>> upstream/master
        '
        'ilSettings
        '
        Me.ilSettings.ImageStream = CType(resources.GetObject("ilSettings.ImageStream"),System.Windows.Forms.ImageListStreamer)
        Me.ilSettings.TransparentColor = System.Drawing.Color.Transparent
        Me.ilSettings.Images.SetKeyName(0, "process.png")
        Me.ilSettings.Images.SetKeyName(1, "comments.png")
        Me.ilSettings.Images.SetKeyName(2, "film.png")
        Me.ilSettings.Images.SetKeyName(3, "copy_paste.png")
        Me.ilSettings.Images.SetKeyName(4, "attachment.png")
        Me.ilSettings.Images.SetKeyName(5, "folder_full.png")
        Me.ilSettings.Images.SetKeyName(6, "image.png")
        Me.ilSettings.Images.SetKeyName(7, "television.ico")
        Me.ilSettings.Images.SetKeyName(8, "favorite_film.png")
        Me.ilSettings.Images.SetKeyName(9, "settingscheck.png")
        Me.ilSettings.Images.SetKeyName(10, "settingsx.png")
        '
        'tvSettingsList
        '
        Me.tvSettingsList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tvSettingsList.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.tvSettingsList.FullRowSelect = true
        Me.tvSettingsList.HideSelection = false
        Me.tvSettingsList.ImageIndex = 0
        Me.tvSettingsList.ImageList = Me.ilSettings
        Me.tvSettingsList.Location = New System.Drawing.Point(5, 147)
        Me.tvSettingsList.Name = "tvSettingsList"
        Me.tvSettingsList.SelectedImageIndex = 0
        Me.tvSettingsList.ShowLines = false
        Me.tvSettingsList.ShowPlusMinus = false
        Me.tvSettingsList.Size = New System.Drawing.Size(242, 502)
        Me.tvSettingsList.TabIndex = 7
        '
        'pnlGeneral
        '
        Me.pnlGeneral.BackColor = System.Drawing.Color.White
<<<<<<< HEAD
        Me.pnlGeneral.Controls.Add(Me.gbInterface)
        Me.pnlGeneral.Controls.Add(Me.GroupBox4)
        Me.pnlGeneral.Location = New System.Drawing.Point(1175, 560)
=======
        Me.pnlGeneral.Controls.Add(Me.gbGeneralInterface)
        Me.pnlGeneral.Controls.Add(Me.gbGeneralMisc)
        Me.pnlGeneral.Location = New System.Drawing.Point(900, 900)
>>>>>>> upstream/master
        Me.pnlGeneral.Name = "pnlGeneral"
        Me.pnlGeneral.Size = New System.Drawing.Size(750, 500)
        Me.pnlGeneral.TabIndex = 10
        Me.pnlGeneral.Visible = false
        '
        'gbGeneralInterface
        '
        Me.gbGeneralInterface.Controls.Add(Me.gbGeneralThemes)
        Me.gbGeneralInterface.Controls.Add(Me.lblGeneralntLang)
        Me.gbGeneralInterface.Controls.Add(Me.cbGeneralLanguage)
        Me.gbGeneralInterface.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.gbGeneralInterface.Location = New System.Drawing.Point(7, 3)
        Me.gbGeneralInterface.Name = "gbGeneralInterface"
        Me.gbGeneralInterface.Size = New System.Drawing.Size(196, 344)
        Me.gbGeneralInterface.TabIndex = 0
        Me.gbGeneralInterface.TabStop = false
        Me.gbGeneralInterface.Text = "Interface"
        '
        'pnlMovieGeneral
        '
        Me.pnlMovieGeneral.BackColor = System.Drawing.Color.White
<<<<<<< HEAD
        Me.pnlMovieGeneral.Controls.Add(Me.GroupBox30)
        Me.pnlMovieGeneral.Controls.Add(Me.gbGenreFilter)
        Me.pnlMovieGeneral.Controls.Add(Me.gbFilters)
        Me.pnlMovieGeneral.Controls.Add(Me.GroupBox27)
        Me.pnlMovieGeneral.Controls.Add(Me.GroupBox12)
        Me.pnlMovieGeneral.Controls.Add(Me.GroupBox2)
        Me.pnlMovieGeneral.Location = New System.Drawing.Point(1275, 440)
        Me.pnlMovieGeneral.Name = "pnlMovieGeneral"
        Me.pnlMovieGeneral.Size = New System.Drawing.Size(750, 500)
        Me.pnlMovieGeneral.TabIndex = 15
        Me.pnlMovieGeneral.Visible = False
        '
        'GroupBox30
        '
        Me.GroupBox30.Controls.Add(Me.Label18)
        Me.GroupBox30.Controls.Add(Me.txtIMDBURL)
        Me.GroupBox30.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.GroupBox30.Location = New System.Drawing.Point(235, 344)
        Me.GroupBox30.Name = "GroupBox30"
        Me.GroupBox30.Size = New System.Drawing.Size(376, 41)
        Me.GroupBox30.TabIndex = 8
        Me.GroupBox30.TabStop = False
        Me.GroupBox30.Text = "IMDB"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(6, 18)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(73, 13)
        Me.Label18.TabIndex = 0
        Me.Label18.Text = "IMDB Mirror:"
        '
        'txtIMDBURL
        '
        Me.txtIMDBURL.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIMDBURL.Location = New System.Drawing.Point(79, 15)
        Me.txtIMDBURL.Name = "txtIMDBURL"
        Me.txtIMDBURL.Size = New System.Drawing.Size(291, 22)
        Me.txtIMDBURL.TabIndex = 1
        '
        'gbGenreFilter
        '
        Me.gbGenreFilter.Controls.Add(Me.lbGenre)
        Me.gbGenreFilter.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.gbGenreFilter.Location = New System.Drawing.Point(428, 209)
        Me.gbGenreFilter.Name = "gbGenreFilter"
        Me.gbGenreFilter.Size = New System.Drawing.Size(183, 123)
        Me.gbGenreFilter.TabIndex = 7
        Me.gbGenreFilter.TabStop = False
        Me.gbGenreFilter.Text = "Genre Language Filter"
        '
        'gbFilters
        '
        Me.gbFilters.Controls.Add(Me.btnResetMovieFilters)
        Me.gbFilters.Controls.Add(Me.btnDown)
        Me.gbFilters.Controls.Add(Me.btnUp)
        Me.gbFilters.Controls.Add(Me.chkProperCase)
        Me.gbFilters.Controls.Add(Me.btnRemoveFilter)
        Me.gbFilters.Controls.Add(Me.btnAddFilter)
        Me.gbFilters.Controls.Add(Me.txtFilter)
        Me.gbFilters.Controls.Add(Me.lstFilters)
        Me.gbFilters.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.gbFilters.Location = New System.Drawing.Point(229, 7)
        Me.gbFilters.Name = "gbFilters"
        Me.gbFilters.Size = New System.Drawing.Size(382, 200)
        Me.gbFilters.TabIndex = 6
        Me.gbFilters.TabStop = False
        Me.gbFilters.Text = "Folder/File Name Filters"
        '
        'btnResetMovieFilters
        '
        Me.btnResetMovieFilters.Image = CType(resources.GetObject("btnResetMovieFilters.Image"), System.Drawing.Image)
        Me.btnResetMovieFilters.Location = New System.Drawing.Point(355, 11)
        Me.btnResetMovieFilters.Name = "btnResetMovieFilters"
        Me.btnResetMovieFilters.Size = New System.Drawing.Size(23, 23)
        Me.btnResetMovieFilters.TabIndex = 8
        Me.btnResetMovieFilters.UseVisualStyleBackColor = True
        '
        'btnDown
        '
        Me.btnDown.Image = CType(resources.GetObject("btnDown.Image"), System.Drawing.Image)
        Me.btnDown.Location = New System.Drawing.Point(313, 172)
        Me.btnDown.Name = "btnDown"
        Me.btnDown.Size = New System.Drawing.Size(23, 23)
        Me.btnDown.TabIndex = 5
        Me.btnDown.UseVisualStyleBackColor = True
        '
        'btnUp
        '
        Me.btnUp.Image = CType(resources.GetObject("btnUp.Image"), System.Drawing.Image)
        Me.btnUp.Location = New System.Drawing.Point(289, 172)
        Me.btnUp.Name = "btnUp"
        Me.btnUp.Size = New System.Drawing.Size(23, 23)
        Me.btnUp.TabIndex = 4
        Me.btnUp.UseVisualStyleBackColor = True
        '
        'chkProperCase
        '
        Me.chkProperCase.AutoSize = True
        Me.chkProperCase.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkProperCase.Location = New System.Drawing.Point(6, 16)
        Me.chkProperCase.Name = "chkProperCase"
        Me.chkProperCase.Size = New System.Drawing.Size(181, 17)
        Me.chkProperCase.TabIndex = 0
        Me.chkProperCase.Text = "Convert Names to Proper Case"
        Me.chkProperCase.UseVisualStyleBackColor = True
        '
        'btnRemoveFilter
        '
        Me.btnRemoveFilter.Image = CType(resources.GetObject("btnRemoveFilter.Image"), System.Drawing.Image)
        Me.btnRemoveFilter.Location = New System.Drawing.Point(354, 172)
        Me.btnRemoveFilter.Name = "btnRemoveFilter"
        Me.btnRemoveFilter.Size = New System.Drawing.Size(23, 23)
        Me.btnRemoveFilter.TabIndex = 6
        Me.btnRemoveFilter.UseVisualStyleBackColor = True
        '
        'btnAddFilter
        '
        Me.btnAddFilter.Image = CType(resources.GetObject("btnAddFilter.Image"), System.Drawing.Image)
        Me.btnAddFilter.Location = New System.Drawing.Point(247, 172)
        Me.btnAddFilter.Name = "btnAddFilter"
        Me.btnAddFilter.Size = New System.Drawing.Size(23, 23)
        Me.btnAddFilter.TabIndex = 3
        Me.btnAddFilter.UseVisualStyleBackColor = True
        '
        'txtFilter
        '
        Me.txtFilter.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFilter.Location = New System.Drawing.Point(6, 173)
        Me.txtFilter.Name = "txtFilter"
        Me.txtFilter.Size = New System.Drawing.Size(239, 22)
        Me.txtFilter.TabIndex = 2
        '
        'lstFilters
        '
        Me.lstFilters.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lstFilters.FormattingEnabled = True
        Me.lstFilters.Location = New System.Drawing.Point(6, 36)
        Me.lstFilters.Name = "lstFilters"
        Me.lstFilters.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lstFilters.Size = New System.Drawing.Size(371, 121)
        Me.lstFilters.TabIndex = 1
        '
        'GroupBox27
        '
        Me.GroupBox27.Controls.Add(Me.chkMissingEFanarts)
        Me.GroupBox27.Controls.Add(Me.chkMissingEThumbs)
        Me.GroupBox27.Controls.Add(Me.chkMissingSubs)
        Me.GroupBox27.Controls.Add(Me.chkMissingTrailer)
        Me.GroupBox27.Controls.Add(Me.chkMissingNFO)
        Me.GroupBox27.Controls.Add(Me.chkMissingFanart)
        Me.GroupBox27.Controls.Add(Me.chkMissingPoster)
        Me.GroupBox27.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.GroupBox27.Location = New System.Drawing.Point(229, 209)
        Me.GroupBox27.Name = "GroupBox27"
        Me.GroupBox27.Size = New System.Drawing.Size(185, 133)
        Me.GroupBox27.TabIndex = 5
        Me.GroupBox27.TabStop = False
        Me.GroupBox27.Text = "Missing Items Filter"
        '
        'chkMissingEFanarts
        '
        Me.chkMissingEFanarts.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMissingEFanarts.Location = New System.Drawing.Point(8, 113)
        Me.chkMissingEFanarts.Name = "chkMissingEFanarts"
        Me.chkMissingEFanarts.Size = New System.Drawing.Size(174, 17)
        Me.chkMissingEFanarts.TabIndex = 12
        Me.chkMissingEFanarts.Text = "Check for Extrafanarts"
        Me.chkMissingEFanarts.UseVisualStyleBackColor = True
        '
        'chkMissingEThumbs
        '
        Me.chkMissingEThumbs.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMissingEThumbs.Location = New System.Drawing.Point(8, 98)
        Me.chkMissingEThumbs.Name = "chkMissingEThumbs"
        Me.chkMissingEThumbs.Size = New System.Drawing.Size(174, 17)
        Me.chkMissingEThumbs.TabIndex = 11
        Me.chkMissingEThumbs.Text = "Check for Extrathumbs"
        Me.chkMissingEThumbs.UseVisualStyleBackColor = True
        '
        'chkMissingSubs
        '
        Me.chkMissingSubs.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMissingSubs.Location = New System.Drawing.Point(8, 82)
        Me.chkMissingSubs.Name = "chkMissingSubs"
        Me.chkMissingSubs.Size = New System.Drawing.Size(174, 17)
        Me.chkMissingSubs.TabIndex = 10
        Me.chkMissingSubs.Text = "Check for Subs"
        Me.chkMissingSubs.UseVisualStyleBackColor = True
        '
        'chkMissingTrailer
        '
        Me.chkMissingTrailer.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMissingTrailer.Location = New System.Drawing.Point(8, 66)
        Me.chkMissingTrailer.Name = "chkMissingTrailer"
        Me.chkMissingTrailer.Size = New System.Drawing.Size(174, 17)
        Me.chkMissingTrailer.TabIndex = 9
        Me.chkMissingTrailer.Text = "Check for Trailer"
        Me.chkMissingTrailer.UseVisualStyleBackColor = True
        '
        'chkMissingNFO
        '
        Me.chkMissingNFO.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMissingNFO.Location = New System.Drawing.Point(8, 50)
        Me.chkMissingNFO.Name = "chkMissingNFO"
        Me.chkMissingNFO.Size = New System.Drawing.Size(174, 17)
        Me.chkMissingNFO.TabIndex = 8
        Me.chkMissingNFO.Text = "Check for NFO"
        Me.chkMissingNFO.UseVisualStyleBackColor = True
        '
        'chkMissingFanart
        '
        Me.chkMissingFanart.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMissingFanart.Location = New System.Drawing.Point(8, 34)
        Me.chkMissingFanart.Name = "chkMissingFanart"
        Me.chkMissingFanart.Size = New System.Drawing.Size(174, 17)
        Me.chkMissingFanart.TabIndex = 7
        Me.chkMissingFanart.Text = "Check for Fanart"
        Me.chkMissingFanart.UseVisualStyleBackColor = True
        '
        'chkMissingPoster
        '
        Me.chkMissingPoster.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMissingPoster.Location = New System.Drawing.Point(8, 18)
        Me.chkMissingPoster.Name = "chkMissingPoster"
        Me.chkMissingPoster.Size = New System.Drawing.Size(174, 17)
        Me.chkMissingPoster.TabIndex = 6
        Me.chkMissingPoster.Text = "Check for Poster"
        Me.chkMissingPoster.UseVisualStyleBackColor = True
        '
        'pnlExtensions
        '
        Me.pnlExtensions.BackColor = System.Drawing.Color.White
        Me.pnlExtensions.Controls.Add(Me.GroupBox22)
        Me.pnlExtensions.Controls.Add(Me.GroupBox3)
        Me.pnlExtensions.Controls.Add(Me.GroupBox18)
        Me.pnlExtensions.Location = New System.Drawing.Point(1225, 500)
        Me.pnlExtensions.Name = "pnlExtensions"
        Me.pnlExtensions.Size = New System.Drawing.Size(750, 500)
        Me.pnlExtensions.TabIndex = 17
        Me.pnlExtensions.Visible = False
        '
        'GroupBox22
        '
        Me.GroupBox22.Controls.Add(Me.btnRemoveNoStack)
        Me.GroupBox22.Controls.Add(Me.btnAddNoStack)
        Me.GroupBox22.Controls.Add(Me.txtNoStack)
        Me.GroupBox22.Controls.Add(Me.lstNoStack)
        Me.GroupBox22.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.GroupBox22.Location = New System.Drawing.Point(202, 6)
        Me.GroupBox22.Name = "GroupBox22"
        Me.GroupBox22.Size = New System.Drawing.Size(194, 199)
        Me.GroupBox22.TabIndex = 1
        Me.GroupBox22.TabStop = False
        Me.GroupBox22.Text = "No Stack Extensions"
        '
        'btnRemoveNoStack
        '
        Me.btnRemoveNoStack.Image = CType(resources.GetObject("btnRemoveNoStack.Image"), System.Drawing.Image)
        Me.btnRemoveNoStack.Location = New System.Drawing.Point(160, 167)
        Me.btnRemoveNoStack.Name = "btnRemoveNoStack"
        Me.btnRemoveNoStack.Size = New System.Drawing.Size(23, 23)
        Me.btnRemoveNoStack.TabIndex = 3
        Me.btnRemoveNoStack.UseVisualStyleBackColor = True
        '
        'btnAddNoStack
        '
        Me.btnAddNoStack.Image = CType(resources.GetObject("btnAddNoStack.Image"), System.Drawing.Image)
        Me.btnAddNoStack.Location = New System.Drawing.Point(73, 167)
        Me.btnAddNoStack.Name = "btnAddNoStack"
        Me.btnAddNoStack.Size = New System.Drawing.Size(23, 23)
        Me.btnAddNoStack.TabIndex = 2
        Me.btnAddNoStack.UseVisualStyleBackColor = True
        '
        'txtNoStack
        '
        Me.txtNoStack.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoStack.Location = New System.Drawing.Point(11, 168)
        Me.txtNoStack.Name = "txtNoStack"
        Me.txtNoStack.Size = New System.Drawing.Size(61, 22)
        Me.txtNoStack.TabIndex = 1
        '
        'lstNoStack
        '
        Me.lstNoStack.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lstNoStack.FormattingEnabled = True
        Me.lstNoStack.Location = New System.Drawing.Point(11, 15)
        Me.lstNoStack.Name = "lstNoStack"
        Me.lstNoStack.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lstNoStack.Size = New System.Drawing.Size(171, 134)
        Me.lstNoStack.Sorted = True
        Me.lstNoStack.TabIndex = 0
        '
        'GroupBox18
        '
        Me.GroupBox18.Controls.Add(Me.btnResetValidExts)
        Me.GroupBox18.Controls.Add(Me.btnRemMovieExt)
        Me.GroupBox18.Controls.Add(Me.btnAddMovieExt)
        Me.GroupBox18.Controls.Add(Me.txtMovieExt)
        Me.GroupBox18.Controls.Add(Me.lstMovieExts)
        Me.GroupBox18.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.GroupBox18.Location = New System.Drawing.Point(3, 6)
        Me.GroupBox18.Name = "GroupBox18"
        Me.GroupBox18.Size = New System.Drawing.Size(192, 385)
        Me.GroupBox18.TabIndex = 0
        Me.GroupBox18.TabStop = False
        Me.GroupBox18.Text = "Valid Video Extensions"
        '
        'btnResetValidExts
        '
        Me.btnResetValidExts.Image = CType(resources.GetObject("btnResetValidExts.Image"), System.Drawing.Image)
        Me.btnResetValidExts.Location = New System.Drawing.Point(164, 12)
        Me.btnResetValidExts.Name = "btnResetValidExts"
        Me.btnResetValidExts.Size = New System.Drawing.Size(23, 23)
        Me.btnResetValidExts.TabIndex = 4
        Me.btnResetValidExts.UseVisualStyleBackColor = True
        '
        'btnRemMovieExt
        '
        Me.btnRemMovieExt.Image = CType(resources.GetObject("btnRemMovieExt.Image"), System.Drawing.Image)
        Me.btnRemMovieExt.Location = New System.Drawing.Point(163, 356)
        Me.btnRemMovieExt.Name = "btnRemMovieExt"
        Me.btnRemMovieExt.Size = New System.Drawing.Size(23, 23)
        Me.btnRemMovieExt.TabIndex = 3
        Me.btnRemMovieExt.UseVisualStyleBackColor = True
        '
        'btnAddMovieExt
        '
        Me.btnAddMovieExt.Image = CType(resources.GetObject("btnAddMovieExt.Image"), System.Drawing.Image)
        Me.btnAddMovieExt.Location = New System.Drawing.Point(68, 356)
        Me.btnAddMovieExt.Name = "btnAddMovieExt"
        Me.btnAddMovieExt.Size = New System.Drawing.Size(23, 23)
        Me.btnAddMovieExt.TabIndex = 2
        Me.btnAddMovieExt.UseVisualStyleBackColor = True
        '
        'txtMovieExt
        '
        Me.txtMovieExt.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMovieExt.Location = New System.Drawing.Point(6, 357)
        Me.txtMovieExt.Name = "txtMovieExt"
        Me.txtMovieExt.Size = New System.Drawing.Size(61, 22)
        Me.txtMovieExt.TabIndex = 1
        '
        'lstMovieExts
        '
        Me.lstMovieExts.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lstMovieExts.FormattingEnabled = True
        Me.lstMovieExts.Location = New System.Drawing.Point(6, 37)
        Me.lstMovieExts.Name = "lstMovieExts"
        Me.lstMovieExts.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lstMovieExts.Size = New System.Drawing.Size(180, 303)
        Me.lstMovieExts.Sorted = True
        Me.lstMovieExts.TabIndex = 0
=======
        Me.pnlMovieGeneral.Controls.Add(Me.gbMovieGenrealIMDBMirrorOpts)
        Me.pnlMovieGeneral.Controls.Add(Me.gbMovieGeneralGenreFilterOpts)
        Me.pnlMovieGeneral.Controls.Add(Me.gbMovieGeneralFiltersOpts)
        Me.pnlMovieGeneral.Controls.Add(Me.gbMovieGeneralMissingItemsOpts)
        Me.pnlMovieGeneral.Controls.Add(Me.gbMovieGeneralMiscOpts)
        Me.pnlMovieGeneral.Controls.Add(Me.gbMovieGeneralMediaListOpts)
        Me.pnlMovieGeneral.Location = New System.Drawing.Point(900, 900)
        Me.pnlMovieGeneral.Name = "pnlMovieGeneral"
        Me.pnlMovieGeneral.Size = New System.Drawing.Size(750, 500)
        Me.pnlMovieGeneral.TabIndex = 15
        Me.pnlMovieGeneral.Visible = false
        '
        'gbMovieGenrealIMDBMirrorOpts
        '
        Me.gbMovieGenrealIMDBMirrorOpts.Controls.Add(Me.lblMovieIMDBMirror)
        Me.gbMovieGenrealIMDBMirrorOpts.Controls.Add(Me.txtMovieIMDBURL)
        Me.gbMovieGenrealIMDBMirrorOpts.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.gbMovieGenrealIMDBMirrorOpts.Location = New System.Drawing.Point(228, 429)
        Me.gbMovieGenrealIMDBMirrorOpts.Name = "gbMovieGenrealIMDBMirrorOpts"
        Me.gbMovieGenrealIMDBMirrorOpts.Size = New System.Drawing.Size(382, 41)
        Me.gbMovieGenrealIMDBMirrorOpts.TabIndex = 8
        Me.gbMovieGenrealIMDBMirrorOpts.TabStop = false
        Me.gbMovieGenrealIMDBMirrorOpts.Text = "IMDB"
        '
        'lblMovieIMDBMirror
        '
        Me.lblMovieIMDBMirror.AutoSize = true
        Me.lblMovieIMDBMirror.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblMovieIMDBMirror.Location = New System.Drawing.Point(6, 18)
        Me.lblMovieIMDBMirror.Name = "lblMovieIMDBMirror"
        Me.lblMovieIMDBMirror.Size = New System.Drawing.Size(73, 13)
        Me.lblMovieIMDBMirror.TabIndex = 0
        Me.lblMovieIMDBMirror.Text = "IMDB Mirror:"
        '
        'txtMovieIMDBURL
        '
        Me.txtMovieIMDBURL.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtMovieIMDBURL.Location = New System.Drawing.Point(79, 15)
        Me.txtMovieIMDBURL.Name = "txtMovieIMDBURL"
        Me.txtMovieIMDBURL.Size = New System.Drawing.Size(291, 22)
        Me.txtMovieIMDBURL.TabIndex = 1
        '
        'gbMovieGeneralGenreFilterOpts
        '
        Me.gbMovieGeneralGenreFilterOpts.Controls.Add(Me.clbMovieGenre)
        Me.gbMovieGeneralGenreFilterOpts.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.gbMovieGeneralGenreFilterOpts.Location = New System.Drawing.Point(427, 209)
        Me.gbMovieGeneralGenreFilterOpts.Name = "gbMovieGeneralGenreFilterOpts"
        Me.gbMovieGeneralGenreFilterOpts.Size = New System.Drawing.Size(183, 123)
        Me.gbMovieGeneralGenreFilterOpts.TabIndex = 7
        Me.gbMovieGeneralGenreFilterOpts.TabStop = false
        Me.gbMovieGeneralGenreFilterOpts.Text = "Genre Language Filter"
        '
        'gbMovieGeneralFiltersOpts
        '
        Me.gbMovieGeneralFiltersOpts.Controls.Add(Me.btnMovieFilterReset)
        Me.gbMovieGeneralFiltersOpts.Controls.Add(Me.btnMovieFilterDown)
        Me.gbMovieGeneralFiltersOpts.Controls.Add(Me.btnMovieFilterUp)
        Me.gbMovieGeneralFiltersOpts.Controls.Add(Me.chkMovieProperCase)
        Me.gbMovieGeneralFiltersOpts.Controls.Add(Me.btnMovieFilterRemove)
        Me.gbMovieGeneralFiltersOpts.Controls.Add(Me.btnMovieFilterAdd)
        Me.gbMovieGeneralFiltersOpts.Controls.Add(Me.txtMovieFilter)
        Me.gbMovieGeneralFiltersOpts.Controls.Add(Me.lstMovieFilters)
        Me.gbMovieGeneralFiltersOpts.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.gbMovieGeneralFiltersOpts.Location = New System.Drawing.Point(228, 3)
        Me.gbMovieGeneralFiltersOpts.Name = "gbMovieGeneralFiltersOpts"
        Me.gbMovieGeneralFiltersOpts.Size = New System.Drawing.Size(382, 200)
        Me.gbMovieGeneralFiltersOpts.TabIndex = 6
        Me.gbMovieGeneralFiltersOpts.TabStop = false
        Me.gbMovieGeneralFiltersOpts.Text = "Folder/File Name Filters"
        '
        'btnMovieFilterReset
        '
        Me.btnMovieFilterReset.Image = CType(resources.GetObject("btnMovieFilterReset.Image"),System.Drawing.Image)
        Me.btnMovieFilterReset.Location = New System.Drawing.Point(355, 11)
        Me.btnMovieFilterReset.Name = "btnMovieFilterReset"
        Me.btnMovieFilterReset.Size = New System.Drawing.Size(23, 23)
        Me.btnMovieFilterReset.TabIndex = 8
        Me.btnMovieFilterReset.UseVisualStyleBackColor = true
        '
        'btnMovieFilterDown
        '
        Me.btnMovieFilterDown.Image = CType(resources.GetObject("btnMovieFilterDown.Image"),System.Drawing.Image)
        Me.btnMovieFilterDown.Location = New System.Drawing.Point(313, 172)
        Me.btnMovieFilterDown.Name = "btnMovieFilterDown"
        Me.btnMovieFilterDown.Size = New System.Drawing.Size(23, 23)
        Me.btnMovieFilterDown.TabIndex = 5
        Me.btnMovieFilterDown.UseVisualStyleBackColor = true
        '
        'btnMovieFilterUp
        '
        Me.btnMovieFilterUp.Image = CType(resources.GetObject("btnMovieFilterUp.Image"),System.Drawing.Image)
        Me.btnMovieFilterUp.Location = New System.Drawing.Point(289, 172)
        Me.btnMovieFilterUp.Name = "btnMovieFilterUp"
        Me.btnMovieFilterUp.Size = New System.Drawing.Size(23, 23)
        Me.btnMovieFilterUp.TabIndex = 4
        Me.btnMovieFilterUp.UseVisualStyleBackColor = true
        '
        'chkMovieProperCase
        '
        Me.chkMovieProperCase.AutoSize = true
        Me.chkMovieProperCase.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkMovieProperCase.Location = New System.Drawing.Point(6, 16)
        Me.chkMovieProperCase.Name = "chkMovieProperCase"
        Me.chkMovieProperCase.Size = New System.Drawing.Size(181, 17)
        Me.chkMovieProperCase.TabIndex = 0
        Me.chkMovieProperCase.Text = "Convert Names to Proper Case"
        Me.chkMovieProperCase.UseVisualStyleBackColor = true
        '
        'btnMovieFilterRemove
        '
        Me.btnMovieFilterRemove.Image = CType(resources.GetObject("btnMovieFilterRemove.Image"),System.Drawing.Image)
        Me.btnMovieFilterRemove.Location = New System.Drawing.Point(354, 172)
        Me.btnMovieFilterRemove.Name = "btnMovieFilterRemove"
        Me.btnMovieFilterRemove.Size = New System.Drawing.Size(23, 23)
        Me.btnMovieFilterRemove.TabIndex = 6
        Me.btnMovieFilterRemove.UseVisualStyleBackColor = true
        '
        'btnMovieFilterAdd
        '
        Me.btnMovieFilterAdd.Image = CType(resources.GetObject("btnMovieFilterAdd.Image"),System.Drawing.Image)
        Me.btnMovieFilterAdd.Location = New System.Drawing.Point(247, 172)
        Me.btnMovieFilterAdd.Name = "btnMovieFilterAdd"
        Me.btnMovieFilterAdd.Size = New System.Drawing.Size(23, 23)
        Me.btnMovieFilterAdd.TabIndex = 3
        Me.btnMovieFilterAdd.UseVisualStyleBackColor = true
        '
        'txtMovieFilter
        '
        Me.txtMovieFilter.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtMovieFilter.Location = New System.Drawing.Point(6, 173)
        Me.txtMovieFilter.Name = "txtMovieFilter"
        Me.txtMovieFilter.Size = New System.Drawing.Size(239, 22)
        Me.txtMovieFilter.TabIndex = 2
        '
        'lstMovieFilters
        '
        Me.lstMovieFilters.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.lstMovieFilters.FormattingEnabled = true
        Me.lstMovieFilters.Location = New System.Drawing.Point(6, 36)
        Me.lstMovieFilters.Name = "lstMovieFilters"
        Me.lstMovieFilters.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lstMovieFilters.Size = New System.Drawing.Size(371, 121)
        Me.lstMovieFilters.TabIndex = 1
        '
        'gbMovieGeneralMissingItemsOpts
        '
        Me.gbMovieGeneralMissingItemsOpts.Controls.Add(Me.chkMovieMissingEFanarts)
        Me.gbMovieGeneralMissingItemsOpts.Controls.Add(Me.chkMovieMissingEThumbs)
        Me.gbMovieGeneralMissingItemsOpts.Controls.Add(Me.chkMovieMissingSubs)
        Me.gbMovieGeneralMissingItemsOpts.Controls.Add(Me.chkMovieMissingTrailer)
        Me.gbMovieGeneralMissingItemsOpts.Controls.Add(Me.chkMovieMissingNFO)
        Me.gbMovieGeneralMissingItemsOpts.Controls.Add(Me.chkMovieMissingFanart)
        Me.gbMovieGeneralMissingItemsOpts.Controls.Add(Me.chkMovieMissingPoster)
        Me.gbMovieGeneralMissingItemsOpts.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.gbMovieGeneralMissingItemsOpts.Location = New System.Drawing.Point(228, 209)
        Me.gbMovieGeneralMissingItemsOpts.Name = "gbMovieGeneralMissingItemsOpts"
        Me.gbMovieGeneralMissingItemsOpts.Size = New System.Drawing.Size(185, 186)
        Me.gbMovieGeneralMissingItemsOpts.TabIndex = 5
        Me.gbMovieGeneralMissingItemsOpts.TabStop = false
        Me.gbMovieGeneralMissingItemsOpts.Text = "Missing Items Filter"
        '
        'chkMovieMissingEFanarts
        '
        Me.chkMovieMissingEFanarts.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkMovieMissingEFanarts.Location = New System.Drawing.Point(5, 158)
        Me.chkMovieMissingEFanarts.Name = "chkMovieMissingEFanarts"
        Me.chkMovieMissingEFanarts.Size = New System.Drawing.Size(174, 17)
        Me.chkMovieMissingEFanarts.TabIndex = 12
        Me.chkMovieMissingEFanarts.Text = "Check for Extrafanarts"
        Me.chkMovieMissingEFanarts.UseVisualStyleBackColor = true
        '
        'chkMovieMissingEThumbs
        '
        Me.chkMovieMissingEThumbs.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkMovieMissingEThumbs.Location = New System.Drawing.Point(6, 135)
        Me.chkMovieMissingEThumbs.Name = "chkMovieMissingEThumbs"
        Me.chkMovieMissingEThumbs.Size = New System.Drawing.Size(174, 17)
        Me.chkMovieMissingEThumbs.TabIndex = 11
        Me.chkMovieMissingEThumbs.Text = "Check for Extrathumbs"
        Me.chkMovieMissingEThumbs.UseVisualStyleBackColor = true
        '
        'chkMovieMissingSubs
        '
        Me.chkMovieMissingSubs.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkMovieMissingSubs.Location = New System.Drawing.Point(6, 112)
        Me.chkMovieMissingSubs.Name = "chkMovieMissingSubs"
        Me.chkMovieMissingSubs.Size = New System.Drawing.Size(174, 17)
        Me.chkMovieMissingSubs.TabIndex = 10
        Me.chkMovieMissingSubs.Text = "Check for Subs"
        Me.chkMovieMissingSubs.UseVisualStyleBackColor = true
        '
        'chkMovieMissingTrailer
        '
        Me.chkMovieMissingTrailer.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkMovieMissingTrailer.Location = New System.Drawing.Point(6, 89)
        Me.chkMovieMissingTrailer.Name = "chkMovieMissingTrailer"
        Me.chkMovieMissingTrailer.Size = New System.Drawing.Size(174, 17)
        Me.chkMovieMissingTrailer.TabIndex = 9
        Me.chkMovieMissingTrailer.Text = "Check for Trailer"
        Me.chkMovieMissingTrailer.UseVisualStyleBackColor = true
        '
        'chkMovieMissingNFO
        '
        Me.chkMovieMissingNFO.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkMovieMissingNFO.Location = New System.Drawing.Point(6, 67)
        Me.chkMovieMissingNFO.Name = "chkMovieMissingNFO"
        Me.chkMovieMissingNFO.Size = New System.Drawing.Size(174, 17)
        Me.chkMovieMissingNFO.TabIndex = 8
        Me.chkMovieMissingNFO.Text = "Check for NFO"
        Me.chkMovieMissingNFO.UseVisualStyleBackColor = true
        '
        'chkMovieMissingFanart
        '
        Me.chkMovieMissingFanart.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkMovieMissingFanart.Location = New System.Drawing.Point(6, 44)
        Me.chkMovieMissingFanart.Name = "chkMovieMissingFanart"
        Me.chkMovieMissingFanart.Size = New System.Drawing.Size(174, 17)
        Me.chkMovieMissingFanart.TabIndex = 7
        Me.chkMovieMissingFanart.Text = "Check for Fanart"
        Me.chkMovieMissingFanart.UseVisualStyleBackColor = true
        '
        'chkMovieMissingPoster
        '
        Me.chkMovieMissingPoster.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkMovieMissingPoster.Location = New System.Drawing.Point(6, 21)
        Me.chkMovieMissingPoster.Name = "chkMovieMissingPoster"
        Me.chkMovieMissingPoster.Size = New System.Drawing.Size(174, 17)
        Me.chkMovieMissingPoster.TabIndex = 6
        Me.chkMovieMissingPoster.Text = "Check for Poster"
        Me.chkMovieMissingPoster.UseVisualStyleBackColor = true
        '
        'pnlFileSystem
        '
        Me.pnlFileSystem.BackColor = System.Drawing.Color.White
        Me.pnlFileSystem.Controls.Add(Me.gbFileSystemNoStackExts)
        Me.pnlFileSystem.Controls.Add(Me.gbFileSystemCleanFiles)
        Me.pnlFileSystem.Controls.Add(Me.gbFileSystemValidExts)
        Me.pnlFileSystem.Location = New System.Drawing.Point(900, 900)
        Me.pnlFileSystem.Name = "pnlFileSystem"
        Me.pnlFileSystem.Size = New System.Drawing.Size(750, 500)
        Me.pnlFileSystem.TabIndex = 17
        Me.pnlFileSystem.Visible = false
        '
        'gbFileSystemNoStackExts
        '
        Me.gbFileSystemNoStackExts.Controls.Add(Me.btnFileSystemNoStackExtsRemove)
        Me.gbFileSystemNoStackExts.Controls.Add(Me.btnFileSystemNoStackExtsAdd)
        Me.gbFileSystemNoStackExts.Controls.Add(Me.txtFileSystemNoStackExts)
        Me.gbFileSystemNoStackExts.Controls.Add(Me.lstFileSystemNoStackExts)
        Me.gbFileSystemNoStackExts.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.gbFileSystemNoStackExts.Location = New System.Drawing.Point(202, 6)
        Me.gbFileSystemNoStackExts.Name = "gbFileSystemNoStackExts"
        Me.gbFileSystemNoStackExts.Size = New System.Drawing.Size(194, 199)
        Me.gbFileSystemNoStackExts.TabIndex = 1
        Me.gbFileSystemNoStackExts.TabStop = false
        Me.gbFileSystemNoStackExts.Text = "No Stack Extensions"
        '
        'btnFileSystemNoStackExtsRemove
        '
        Me.btnFileSystemNoStackExtsRemove.Image = CType(resources.GetObject("btnFileSystemNoStackExtsRemove.Image"),System.Drawing.Image)
        Me.btnFileSystemNoStackExtsRemove.Location = New System.Drawing.Point(160, 167)
        Me.btnFileSystemNoStackExtsRemove.Name = "btnFileSystemNoStackExtsRemove"
        Me.btnFileSystemNoStackExtsRemove.Size = New System.Drawing.Size(23, 23)
        Me.btnFileSystemNoStackExtsRemove.TabIndex = 3
        Me.btnFileSystemNoStackExtsRemove.UseVisualStyleBackColor = true
        '
        'btnFileSystemNoStackExtsAdd
        '
        Me.btnFileSystemNoStackExtsAdd.Image = CType(resources.GetObject("btnFileSystemNoStackExtsAdd.Image"),System.Drawing.Image)
        Me.btnFileSystemNoStackExtsAdd.Location = New System.Drawing.Point(73, 167)
        Me.btnFileSystemNoStackExtsAdd.Name = "btnFileSystemNoStackExtsAdd"
        Me.btnFileSystemNoStackExtsAdd.Size = New System.Drawing.Size(23, 23)
        Me.btnFileSystemNoStackExtsAdd.TabIndex = 2
        Me.btnFileSystemNoStackExtsAdd.UseVisualStyleBackColor = true
        '
        'txtFileSystemNoStackExts
        '
        Me.txtFileSystemNoStackExts.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtFileSystemNoStackExts.Location = New System.Drawing.Point(11, 168)
        Me.txtFileSystemNoStackExts.Name = "txtFileSystemNoStackExts"
        Me.txtFileSystemNoStackExts.Size = New System.Drawing.Size(61, 22)
        Me.txtFileSystemNoStackExts.TabIndex = 1
        '
        'lstFileSystemNoStackExts
        '
        Me.lstFileSystemNoStackExts.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.lstFileSystemNoStackExts.FormattingEnabled = true
        Me.lstFileSystemNoStackExts.Location = New System.Drawing.Point(11, 15)
        Me.lstFileSystemNoStackExts.Name = "lstFileSystemNoStackExts"
        Me.lstFileSystemNoStackExts.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lstFileSystemNoStackExts.Size = New System.Drawing.Size(171, 134)
        Me.lstFileSystemNoStackExts.Sorted = true
        Me.lstFileSystemNoStackExts.TabIndex = 0
        '
        'gbFileSystemValidExts
        '
        Me.gbFileSystemValidExts.Controls.Add(Me.btnFileSystemValidExtsReset)
        Me.gbFileSystemValidExts.Controls.Add(Me.btnFileSystemValidExtsRemove)
        Me.gbFileSystemValidExts.Controls.Add(Me.btnFileSystemValidExtsAdd)
        Me.gbFileSystemValidExts.Controls.Add(Me.txtFileSystemValidExts)
        Me.gbFileSystemValidExts.Controls.Add(Me.lstFileSystemValidExts)
        Me.gbFileSystemValidExts.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.gbFileSystemValidExts.Location = New System.Drawing.Point(3, 6)
        Me.gbFileSystemValidExts.Name = "gbFileSystemValidExts"
        Me.gbFileSystemValidExts.Size = New System.Drawing.Size(192, 385)
        Me.gbFileSystemValidExts.TabIndex = 0
        Me.gbFileSystemValidExts.TabStop = false
        Me.gbFileSystemValidExts.Text = "Valid Video Extensions"
        '
        'btnFileSystemValidExtsReset
        '
        Me.btnFileSystemValidExtsReset.Image = CType(resources.GetObject("btnFileSystemValidExtsReset.Image"),System.Drawing.Image)
        Me.btnFileSystemValidExtsReset.Location = New System.Drawing.Point(164, 12)
        Me.btnFileSystemValidExtsReset.Name = "btnFileSystemValidExtsReset"
        Me.btnFileSystemValidExtsReset.Size = New System.Drawing.Size(23, 23)
        Me.btnFileSystemValidExtsReset.TabIndex = 4
        Me.btnFileSystemValidExtsReset.UseVisualStyleBackColor = true
        '
        'btnFileSystemValidExtsRemove
        '
        Me.btnFileSystemValidExtsRemove.Image = CType(resources.GetObject("btnFileSystemValidExtsRemove.Image"),System.Drawing.Image)
        Me.btnFileSystemValidExtsRemove.Location = New System.Drawing.Point(163, 356)
        Me.btnFileSystemValidExtsRemove.Name = "btnFileSystemValidExtsRemove"
        Me.btnFileSystemValidExtsRemove.Size = New System.Drawing.Size(23, 23)
        Me.btnFileSystemValidExtsRemove.TabIndex = 3
        Me.btnFileSystemValidExtsRemove.UseVisualStyleBackColor = true
        '
        'btnFileSystemValidExtsAdd
        '
        Me.btnFileSystemValidExtsAdd.Image = CType(resources.GetObject("btnFileSystemValidExtsAdd.Image"),System.Drawing.Image)
        Me.btnFileSystemValidExtsAdd.Location = New System.Drawing.Point(68, 356)
        Me.btnFileSystemValidExtsAdd.Name = "btnFileSystemValidExtsAdd"
        Me.btnFileSystemValidExtsAdd.Size = New System.Drawing.Size(23, 23)
        Me.btnFileSystemValidExtsAdd.TabIndex = 2
        Me.btnFileSystemValidExtsAdd.UseVisualStyleBackColor = true
        '
        'txtFileSystemValidExts
        '
        Me.txtFileSystemValidExts.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtFileSystemValidExts.Location = New System.Drawing.Point(6, 357)
        Me.txtFileSystemValidExts.Name = "txtFileSystemValidExts"
        Me.txtFileSystemValidExts.Size = New System.Drawing.Size(61, 22)
        Me.txtFileSystemValidExts.TabIndex = 1
        '
        'lstFileSystemValidExts
        '
        Me.lstFileSystemValidExts.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.lstFileSystemValidExts.FormattingEnabled = true
        Me.lstFileSystemValidExts.Location = New System.Drawing.Point(6, 37)
        Me.lstFileSystemValidExts.Name = "lstFileSystemValidExts"
        Me.lstFileSystemValidExts.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lstFileSystemValidExts.Size = New System.Drawing.Size(180, 303)
        Me.lstFileSystemValidExts.Sorted = true
        Me.lstFileSystemValidExts.TabIndex = 0
>>>>>>> upstream/master
        '
        'pnlProxy
        '
        Me.pnlProxy.BackColor = System.Drawing.Color.White
<<<<<<< HEAD
        Me.pnlProxy.Controls.Add(Me.gbProxy)
        Me.pnlProxy.Location = New System.Drawing.Point(1075, 680)
=======
        Me.pnlProxy.Controls.Add(Me.gbProxyOpts)
        Me.pnlProxy.Location = New System.Drawing.Point(900, 900)
>>>>>>> upstream/master
        Me.pnlProxy.Name = "pnlProxy"
        Me.pnlProxy.Size = New System.Drawing.Size(750, 500)
        Me.pnlProxy.TabIndex = 18
        Me.pnlProxy.Visible = false
        '
        'gbProxyOpts
        '
        Me.gbProxyOpts.Controls.Add(Me.gbProxyCredsOpts)
        Me.gbProxyOpts.Controls.Add(Me.lblProxyPort)
        Me.gbProxyOpts.Controls.Add(Me.lblProxyURI)
        Me.gbProxyOpts.Controls.Add(Me.txtProxyPort)
        Me.gbProxyOpts.Controls.Add(Me.txtProxyURI)
        Me.gbProxyOpts.Controls.Add(Me.chkProxyEnable)
        Me.gbProxyOpts.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.gbProxyOpts.Location = New System.Drawing.Point(3, 6)
        Me.gbProxyOpts.Name = "gbProxyOpts"
        Me.gbProxyOpts.Size = New System.Drawing.Size(290, 230)
        Me.gbProxyOpts.TabIndex = 0
        Me.gbProxyOpts.TabStop = false
        Me.gbProxyOpts.Text = "Proxy"
        '
        'gbProxyCredsOpts
        '
        Me.gbProxyCredsOpts.Controls.Add(Me.txtProxyDomain)
        Me.gbProxyCredsOpts.Controls.Add(Me.lblProxyDomain)
        Me.gbProxyCredsOpts.Controls.Add(Me.txtProxyPassword)
        Me.gbProxyCredsOpts.Controls.Add(Me.txtProxyUsername)
        Me.gbProxyCredsOpts.Controls.Add(Me.lblProxyUsername)
        Me.gbProxyCredsOpts.Controls.Add(Me.lblProxyPassword)
        Me.gbProxyCredsOpts.Controls.Add(Me.chkProxyCredsEnable)
        Me.gbProxyCredsOpts.Enabled = false
        Me.gbProxyCredsOpts.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.gbProxyCredsOpts.Location = New System.Drawing.Point(5, 115)
        Me.gbProxyCredsOpts.Name = "gbProxyCredsOpts"
        Me.gbProxyCredsOpts.Size = New System.Drawing.Size(279, 103)
        Me.gbProxyCredsOpts.TabIndex = 5
        Me.gbProxyCredsOpts.TabStop = false
        Me.gbProxyCredsOpts.Text = "Credentials"
        '
        'txtProxyDomain
        '
        Me.txtProxyDomain.Enabled = false
        Me.txtProxyDomain.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtProxyDomain.Location = New System.Drawing.Point(64, 69)
        Me.txtProxyDomain.Name = "txtProxyDomain"
        Me.txtProxyDomain.Size = New System.Drawing.Size(209, 22)
        Me.txtProxyDomain.TabIndex = 6
        '
        'lblProxyDomain
        '
        Me.lblProxyDomain.AutoSize = true
        Me.lblProxyDomain.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblProxyDomain.Location = New System.Drawing.Point(14, 72)
        Me.lblProxyDomain.Name = "lblProxyDomain"
        Me.lblProxyDomain.Size = New System.Drawing.Size(50, 13)
        Me.lblProxyDomain.TabIndex = 5
        Me.lblProxyDomain.Text = "Domain:"
        '
        'txtProxyPassword
        '
        Me.txtProxyPassword.Enabled = false
        Me.txtProxyPassword.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtProxyPassword.Location = New System.Drawing.Point(201, 39)
        Me.txtProxyPassword.Name = "txtProxyPassword"
        Me.txtProxyPassword.Size = New System.Drawing.Size(72, 22)
        Me.txtProxyPassword.TabIndex = 4
        Me.txtProxyPassword.UseSystemPasswordChar = true
        '
        'txtProxyUsername
        '
        Me.txtProxyUsername.Enabled = false
        Me.txtProxyUsername.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtProxyUsername.Location = New System.Drawing.Point(64, 39)
        Me.txtProxyUsername.Name = "txtProxyUsername"
        Me.txtProxyUsername.Size = New System.Drawing.Size(72, 22)
        Me.txtProxyUsername.TabIndex = 2
        '
        'lblProxyUsername
        '
        Me.lblProxyUsername.AutoSize = true
        Me.lblProxyUsername.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblProxyUsername.Location = New System.Drawing.Point(3, 42)
        Me.lblProxyUsername.Name = "lblProxyUsername"
        Me.lblProxyUsername.Size = New System.Drawing.Size(61, 13)
        Me.lblProxyUsername.TabIndex = 1
        Me.lblProxyUsername.Text = "Username:"
        '
        'lblProxyPassword
        '
        Me.lblProxyPassword.AutoSize = true
        Me.lblProxyPassword.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblProxyPassword.Location = New System.Drawing.Point(143, 42)
        Me.lblProxyPassword.Name = "lblProxyPassword"
        Me.lblProxyPassword.Size = New System.Drawing.Size(59, 13)
        Me.lblProxyPassword.TabIndex = 3
        Me.lblProxyPassword.Text = "Password:"
        '
        'chkProxyCredsEnable
        '
        Me.chkProxyCredsEnable.AutoSize = true
        Me.chkProxyCredsEnable.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkProxyCredsEnable.Location = New System.Drawing.Point(8, 17)
        Me.chkProxyCredsEnable.Name = "chkProxyCredsEnable"
        Me.chkProxyCredsEnable.Size = New System.Drawing.Size(122, 17)
        Me.chkProxyCredsEnable.TabIndex = 0
        Me.chkProxyCredsEnable.Text = "Enable Credentials"
        Me.chkProxyCredsEnable.UseVisualStyleBackColor = true
        '
        'lblProxyPort
        '
        Me.lblProxyPort.AutoSize = true
        Me.lblProxyPort.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblProxyPort.Location = New System.Drawing.Point(9, 88)
        Me.lblProxyPort.Name = "lblProxyPort"
        Me.lblProxyPort.Size = New System.Drawing.Size(61, 13)
        Me.lblProxyPort.TabIndex = 3
        Me.lblProxyPort.Text = "Proxy Port:"
        '
        'lblProxyURI
        '
        Me.lblProxyURI.AutoSize = true
        Me.lblProxyURI.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblProxyURI.Location = New System.Drawing.Point(9, 39)
        Me.lblProxyURI.Name = "lblProxyURI"
        Me.lblProxyURI.Size = New System.Drawing.Size(58, 13)
        Me.lblProxyURI.TabIndex = 1
        Me.lblProxyURI.Text = "Proxy URI:"
        '
        'txtProxyPort
        '
        Me.txtProxyPort.Enabled = false
        Me.txtProxyPort.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtProxyPort.Location = New System.Drawing.Point(72, 84)
        Me.txtProxyPort.Name = "txtProxyPort"
        Me.txtProxyPort.Size = New System.Drawing.Size(51, 22)
        Me.txtProxyPort.TabIndex = 4
        '
        'txtProxyURI
        '
        Me.txtProxyURI.Enabled = false
        Me.txtProxyURI.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtProxyURI.Location = New System.Drawing.Point(11, 54)
        Me.txtProxyURI.Name = "txtProxyURI"
        Me.txtProxyURI.Size = New System.Drawing.Size(267, 22)
        Me.txtProxyURI.TabIndex = 2
        '
        'chkProxyEnable
        '
        Me.chkProxyEnable.AutoSize = true
        Me.chkProxyEnable.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkProxyEnable.Location = New System.Drawing.Point(11, 17)
        Me.chkProxyEnable.Name = "chkProxyEnable"
        Me.chkProxyEnable.Size = New System.Drawing.Size(91, 17)
        Me.chkProxyEnable.TabIndex = 0
        Me.chkProxyEnable.Text = "Enable Proxy"
        Me.chkProxyEnable.UseVisualStyleBackColor = true
        '
        'gbMovieBackdropsFolder
        '
        Me.gbMovieBackdropsFolder.Controls.Add(Me.chkMovieBackdropsAuto)
        Me.gbMovieBackdropsFolder.Controls.Add(Me.btnMovieBackdropsBrowse)
        Me.gbMovieBackdropsFolder.Controls.Add(Me.txtMovieBackdropsPath)
        Me.gbMovieBackdropsFolder.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.gbMovieBackdropsFolder.Location = New System.Drawing.Point(5, 412)
        Me.gbMovieBackdropsFolder.Name = "gbMovieBackdropsFolder"
        Me.gbMovieBackdropsFolder.Size = New System.Drawing.Size(212, 85)
        Me.gbMovieBackdropsFolder.TabIndex = 6
        Me.gbMovieBackdropsFolder.TabStop = false
        Me.gbMovieBackdropsFolder.Text = "Backdrops Folder"
        '
        'chkMovieBackdropsAuto
        '
        Me.chkMovieBackdropsAuto.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkMovieBackdropsAuto.Location = New System.Drawing.Point(6, 49)
        Me.chkMovieBackdropsAuto.Name = "chkMovieBackdropsAuto"
        Me.chkMovieBackdropsAuto.Size = New System.Drawing.Size(200, 33)
        Me.chkMovieBackdropsAuto.TabIndex = 2
        Me.chkMovieBackdropsAuto.Text = "Automatically Save Fanart To Backdrops Folder"
        Me.chkMovieBackdropsAuto.UseVisualStyleBackColor = true
        '
        'btnMovieBackdropsBrowse
        '
        Me.btnMovieBackdropsBrowse.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.btnMovieBackdropsBrowse.Location = New System.Drawing.Point(181, 21)
        Me.btnMovieBackdropsBrowse.Name = "btnMovieBackdropsBrowse"
        Me.btnMovieBackdropsBrowse.Size = New System.Drawing.Size(25, 22)
        Me.btnMovieBackdropsBrowse.TabIndex = 1
        Me.btnMovieBackdropsBrowse.Text = "..."
        Me.btnMovieBackdropsBrowse.UseVisualStyleBackColor = true
        '
        'txtMovieBackdropsPath
        '
        Me.txtMovieBackdropsPath.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtMovieBackdropsPath.Location = New System.Drawing.Point(6, 21)
        Me.txtMovieBackdropsPath.Name = "txtMovieBackdropsPath"
        Me.txtMovieBackdropsPath.Size = New System.Drawing.Size(169, 22)
        Me.txtMovieBackdropsPath.TabIndex = 0
        '
        'lblSettingsCurrent
        '
        Me.lblSettingsCurrent.BackColor = System.Drawing.Color.SteelBlue
        Me.lblSettingsCurrent.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblSettingsCurrent.ForeColor = System.Drawing.Color.White
        Me.lblSettingsCurrent.Location = New System.Drawing.Point(26, -1)
        Me.lblSettingsCurrent.Name = "lblSettingsCurrent"
        Me.lblSettingsCurrent.Size = New System.Drawing.Size(489, 25)
        Me.lblSettingsCurrent.TabIndex = 0
        Me.lblSettingsCurrent.Text = "General"
        '
        'pnlSettingsCurrentBGGradient
        '
        Me.pnlSettingsCurrentBGGradient.BackColor = System.Drawing.Color.SteelBlue
        Me.pnlSettingsCurrentBGGradient.Location = New System.Drawing.Point(516, 119)
        Me.pnlSettingsCurrentBGGradient.Name = "pnlSettingsCurrentBGGradient"
        Me.pnlSettingsCurrentBGGradient.Size = New System.Drawing.Size(487, 25)
        Me.pnlSettingsCurrentBGGradient.TabIndex = 6
        '
        'pnlCurrent
        '
        Me.pnlCurrent.BackColor = System.Drawing.Color.SteelBlue
        Me.pnlCurrent.Controls.Add(Me.pbSettingsCurrent)
        Me.pnlCurrent.Controls.Add(Me.lblSettingsCurrent)
        Me.pnlCurrent.Location = New System.Drawing.Point(5, 119)
        Me.pnlCurrent.Name = "pnlCurrent"
        Me.pnlCurrent.Size = New System.Drawing.Size(515, 25)
        Me.pnlCurrent.TabIndex = 5
        '
        'pbSettingsCurrent
        '
        Me.pbSettingsCurrent.Location = New System.Drawing.Point(2, 0)
        Me.pbSettingsCurrent.Name = "pbSettingsCurrent"
        Me.pbSettingsCurrent.Size = New System.Drawing.Size(24, 24)
        Me.pbSettingsCurrent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbSettingsCurrent.TabIndex = 2
        Me.pbSettingsCurrent.TabStop = false
        '
        'pnlMovieSources
        '
        Me.pnlMovieSources.BackColor = System.Drawing.Color.White
        Me.pnlMovieSources.Controls.Add(Me.gbMovieSetsFolder)
        Me.pnlMovieSources.Controls.Add(Me.gbMovieFileNaming)
        Me.pnlMovieSources.Controls.Add(Me.gbMovieBackdropsFolder)
<<<<<<< HEAD
        Me.pnlMovieSources.Controls.Add(Me.btnEditSource)
        Me.pnlMovieSources.Controls.Add(Me.gbMovieMiscOptions)
        Me.pnlMovieSources.Controls.Add(Me.lvMovies)
        Me.pnlMovieSources.Controls.Add(Me.btnMovieRem)
        Me.pnlMovieSources.Controls.Add(Me.btnMovieAddFolder)
        Me.pnlMovieSources.Location = New System.Drawing.Point(1300, 410)
=======
        Me.pnlMovieSources.Controls.Add(Me.btnMovieSourceEdit)
        Me.pnlMovieSources.Controls.Add(Me.gbMovieMiscOpts)
        Me.pnlMovieSources.Controls.Add(Me.lvMovieSources)
        Me.pnlMovieSources.Controls.Add(Me.btnMovieSourceRemove)
        Me.pnlMovieSources.Controls.Add(Me.btnMovieSourceAdd)
        Me.pnlMovieSources.Location = New System.Drawing.Point(900, 900)
>>>>>>> upstream/master
        Me.pnlMovieSources.Name = "pnlMovieSources"
        Me.pnlMovieSources.Size = New System.Drawing.Size(750, 500)
        Me.pnlMovieSources.TabIndex = 13
        Me.pnlMovieSources.Visible = false
        '
        'gbMovieSetsFolder
        '
        Me.gbMovieSetsFolder.Controls.Add(Me.btnMovieMoviesetsBrowse)
        Me.gbMovieSetsFolder.Controls.Add(Me.txtMovieMoviesetsPath)
        Me.gbMovieSetsFolder.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.gbMovieSetsFolder.Location = New System.Drawing.Point(5, 348)
        Me.gbMovieSetsFolder.Name = "gbMovieSetsFolder"
        Me.gbMovieSetsFolder.Size = New System.Drawing.Size(212, 58)
        Me.gbMovieSetsFolder.TabIndex = 7
        Me.gbMovieSetsFolder.TabStop = false
        Me.gbMovieSetsFolder.Text = "MovieSets Folder"
        '
        'btnMovieMoviesetsBrowse
        '
        Me.btnMovieMoviesetsBrowse.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.btnMovieMoviesetsBrowse.Location = New System.Drawing.Point(181, 21)
        Me.btnMovieMoviesetsBrowse.Name = "btnMovieMoviesetsBrowse"
        Me.btnMovieMoviesetsBrowse.Size = New System.Drawing.Size(25, 22)
        Me.btnMovieMoviesetsBrowse.TabIndex = 1
        Me.btnMovieMoviesetsBrowse.Text = "..."
        Me.btnMovieMoviesetsBrowse.UseVisualStyleBackColor = true
        '
        'txtMovieMoviesetsPath
        '
        Me.txtMovieMoviesetsPath.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtMovieMoviesetsPath.Location = New System.Drawing.Point(6, 21)
        Me.txtMovieMoviesetsPath.Name = "txtMovieMoviesetsPath"
        Me.txtMovieMoviesetsPath.Size = New System.Drawing.Size(169, 22)
        Me.txtMovieMoviesetsPath.TabIndex = 0
        '
        'gbMovieFileNaming
        '
        Me.gbMovieFileNaming.Controls.Add(Me.tcMovieFileNaming)
        Me.gbMovieFileNaming.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.gbMovieFileNaming.Location = New System.Drawing.Point(223, 113)
        Me.gbMovieFileNaming.Name = "gbMovieFileNaming"
        Me.gbMovieFileNaming.Size = New System.Drawing.Size(521, 384)
        Me.gbMovieFileNaming.TabIndex = 8
        Me.gbMovieFileNaming.TabStop = false
        Me.gbMovieFileNaming.Text = "File Naming"
        '
        'tcMovieFileNaming
        '
        Me.tcMovieFileNaming.Controls.Add(Me.tpMovieFileNamingXBMC)
        Me.tcMovieFileNaming.Controls.Add(Me.tpMovieFileNamingNMT)
        Me.tcMovieFileNaming.Controls.Add(Me.tpMovieFileNamingExpert)
        Me.tcMovieFileNaming.Location = New System.Drawing.Point(6, 18)
        Me.tcMovieFileNaming.Name = "tcMovieFileNaming"
        Me.tcMovieFileNaming.SelectedIndex = 0
        Me.tcMovieFileNaming.Size = New System.Drawing.Size(513, 362)
        Me.tcMovieFileNaming.TabIndex = 7
        '
        'tpMovieFileNamingXBMC
        '
        Me.tpMovieFileNamingXBMC.Controls.Add(Me.gbMovieXBMCOptional)
        Me.tpMovieFileNamingXBMC.Controls.Add(Me.gbMovieEden)
        Me.tpMovieFileNamingXBMC.Controls.Add(Me.gbMovieFrodo)
        Me.tpMovieFileNamingXBMC.Location = New System.Drawing.Point(4, 22)
        Me.tpMovieFileNamingXBMC.Name = "tpMovieFileNamingXBMC"
        Me.tpMovieFileNamingXBMC.Padding = New System.Windows.Forms.Padding(3)
        Me.tpMovieFileNamingXBMC.Size = New System.Drawing.Size(505, 336)
        Me.tpMovieFileNamingXBMC.TabIndex = 1
        Me.tpMovieFileNamingXBMC.Text = "XBMC"
        Me.tpMovieFileNamingXBMC.UseVisualStyleBackColor = true
        '
        'gbMovieXBMCOptional
        '
        Me.gbMovieXBMCOptional.Controls.Add(Me.chkMovieXBMCProtectVTSBDMV)
        Me.gbMovieXBMCOptional.Controls.Add(Me.chkMovieXBMCTrailerFormat)
        Me.gbMovieXBMCOptional.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.gbMovieXBMCOptional.Location = New System.Drawing.Point(238, 6)
        Me.gbMovieXBMCOptional.Name = "gbMovieXBMCOptional"
        Me.gbMovieXBMCOptional.Size = New System.Drawing.Size(261, 66)
        Me.gbMovieXBMCOptional.TabIndex = 2
        Me.gbMovieXBMCOptional.TabStop = false
        Me.gbMovieXBMCOptional.Text = "Optional Settings"
        '
        'chkMovieXBMCProtectVTSBDMV
        '
        Me.chkMovieXBMCProtectVTSBDMV.AutoSize = true
        Me.chkMovieXBMCProtectVTSBDMV.Enabled = false
        Me.chkMovieXBMCProtectVTSBDMV.Location = New System.Drawing.Point(6, 44)
        Me.chkMovieXBMCProtectVTSBDMV.Name = "chkMovieXBMCProtectVTSBDMV"
        Me.chkMovieXBMCProtectVTSBDMV.Size = New System.Drawing.Size(222, 17)
        Me.chkMovieXBMCProtectVTSBDMV.TabIndex = 1
        Me.chkMovieXBMCProtectVTSBDMV.Text = "Protect VIDEO_TS and BDMV Structure"
        Me.chkMovieXBMCProtectVTSBDMV.UseVisualStyleBackColor = true
        '
        'chkMovieXBMCTrailerFormat
        '
        Me.chkMovieXBMCTrailerFormat.AutoSize = true
        Me.chkMovieXBMCTrailerFormat.Location = New System.Drawing.Point(6, 21)
        Me.chkMovieXBMCTrailerFormat.Name = "chkMovieXBMCTrailerFormat"
        Me.chkMovieXBMCTrailerFormat.Size = New System.Drawing.Size(179, 17)
        Me.chkMovieXBMCTrailerFormat.TabIndex = 0
        Me.chkMovieXBMCTrailerFormat.Text = "YouTube Plugin Trailer Format"
        Me.chkMovieXBMCTrailerFormat.UseVisualStyleBackColor = true
        '
        'gbMovieEden
        '
        Me.gbMovieEden.Controls.Add(Me.chkMovieExtrafanartsEden)
        Me.gbMovieEden.Controls.Add(Me.chkMovieExtrathumbsEden)
        Me.gbMovieEden.Controls.Add(Me.chkMovieUseEden)
        Me.gbMovieEden.Controls.Add(Me.chkMovieActorThumbsEden)
        Me.gbMovieEden.Controls.Add(Me.chkMovieTrailerEden)
        Me.gbMovieEden.Controls.Add(Me.chkMovieFanartEden)
        Me.gbMovieEden.Controls.Add(Me.chkMoviePosterEden)
        Me.gbMovieEden.Controls.Add(Me.chkMovieNFOEden)
        Me.gbMovieEden.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.gbMovieEden.Location = New System.Drawing.Point(122, 6)
        Me.gbMovieEden.Name = "gbMovieEden"
        Me.gbMovieEden.Size = New System.Drawing.Size(110, 324)
        Me.gbMovieEden.TabIndex = 1
        Me.gbMovieEden.TabStop = false
        Me.gbMovieEden.Text = "Eden"
        '
        'chkMovieExtrafanartsEden
        '
        Me.chkMovieExtrafanartsEden.AutoSize = true
        Me.chkMovieExtrafanartsEden.Enabled = false
        Me.chkMovieExtrafanartsEden.Location = New System.Drawing.Point(6, 159)
        Me.chkMovieExtrafanartsEden.Name = "chkMovieExtrafanartsEden"
        Me.chkMovieExtrafanartsEden.Size = New System.Drawing.Size(87, 17)
        Me.chkMovieExtrafanartsEden.TabIndex = 20
        Me.chkMovieExtrafanartsEden.Text = "Extrafanarts"
        Me.chkMovieExtrafanartsEden.UseVisualStyleBackColor = true
        '
        'chkMovieExtrathumbsEden
        '
        Me.chkMovieExtrathumbsEden.AutoSize = true
        Me.chkMovieExtrathumbsEden.Enabled = false
        Me.chkMovieExtrathumbsEden.Location = New System.Drawing.Point(6, 136)
        Me.chkMovieExtrathumbsEden.Name = "chkMovieExtrathumbsEden"
        Me.chkMovieExtrathumbsEden.Size = New System.Drawing.Size(90, 17)
        Me.chkMovieExtrathumbsEden.TabIndex = 19
        Me.chkMovieExtrathumbsEden.Text = "Extrathumbs"
        Me.chkMovieExtrathumbsEden.UseVisualStyleBackColor = true
        '
        'chkMovieUseEden
        '
        Me.chkMovieUseEden.AutoSize = true
        Me.chkMovieUseEden.Location = New System.Drawing.Point(6, 21)
        Me.chkMovieUseEden.Name = "chkMovieUseEden"
        Me.chkMovieUseEden.Size = New System.Drawing.Size(45, 17)
        Me.chkMovieUseEden.TabIndex = 18
        Me.chkMovieUseEden.Text = "Use"
        Me.chkMovieUseEden.UseVisualStyleBackColor = true
        '
        'chkMovieActorThumbsEden
        '
        Me.chkMovieActorThumbsEden.AutoSize = true
        Me.chkMovieActorThumbsEden.Enabled = false
        Me.chkMovieActorThumbsEden.Location = New System.Drawing.Point(6, 113)
        Me.chkMovieActorThumbsEden.Name = "chkMovieActorThumbsEden"
        Me.chkMovieActorThumbsEden.Size = New System.Drawing.Size(96, 17)
        Me.chkMovieActorThumbsEden.TabIndex = 17
        Me.chkMovieActorThumbsEden.Text = "Actor Thumbs"
        Me.chkMovieActorThumbsEden.UseVisualStyleBackColor = true
        '
        'chkMovieTrailerEden
        '
        Me.chkMovieTrailerEden.AutoSize = true
        Me.chkMovieTrailerEden.Enabled = false
        Me.chkMovieTrailerEden.Location = New System.Drawing.Point(6, 182)
        Me.chkMovieTrailerEden.Name = "chkMovieTrailerEden"
        Me.chkMovieTrailerEden.Size = New System.Drawing.Size(57, 17)
        Me.chkMovieTrailerEden.TabIndex = 16
        Me.chkMovieTrailerEden.Text = "Trailer"
        Me.chkMovieTrailerEden.UseVisualStyleBackColor = true
        '
        'chkMovieFanartEden
        '
        Me.chkMovieFanartEden.AutoSize = true
        Me.chkMovieFanartEden.Enabled = false
        Me.chkMovieFanartEden.Location = New System.Drawing.Point(6, 90)
        Me.chkMovieFanartEden.Name = "chkMovieFanartEden"
        Me.chkMovieFanartEden.Size = New System.Drawing.Size(59, 17)
        Me.chkMovieFanartEden.TabIndex = 15
        Me.chkMovieFanartEden.Text = "Fanart"
        Me.chkMovieFanartEden.UseVisualStyleBackColor = true
        '
        'chkMoviePosterEden
        '
        Me.chkMoviePosterEden.AutoSize = true
        Me.chkMoviePosterEden.Enabled = false
        Me.chkMoviePosterEden.Location = New System.Drawing.Point(6, 67)
        Me.chkMoviePosterEden.Name = "chkMoviePosterEden"
        Me.chkMoviePosterEden.Size = New System.Drawing.Size(58, 17)
        Me.chkMoviePosterEden.TabIndex = 14
        Me.chkMoviePosterEden.Text = "Poster"
        Me.chkMoviePosterEden.UseVisualStyleBackColor = true
        '
        'chkMovieNFOEden
        '
        Me.chkMovieNFOEden.AutoSize = true
        Me.chkMovieNFOEden.Enabled = false
        Me.chkMovieNFOEden.Location = New System.Drawing.Point(6, 44)
        Me.chkMovieNFOEden.Name = "chkMovieNFOEden"
        Me.chkMovieNFOEden.Size = New System.Drawing.Size(49, 17)
        Me.chkMovieNFOEden.TabIndex = 13
        Me.chkMovieNFOEden.Text = "NFO"
        Me.chkMovieNFOEden.UseVisualStyleBackColor = true
        '
        'gbMovieFrodo
        '
        Me.gbMovieFrodo.Controls.Add(Me.chkMovieExtrafanartsFrodo)
        Me.gbMovieFrodo.Controls.Add(Me.chkMovieExtrathumbsFrodo)
        Me.gbMovieFrodo.Controls.Add(Me.chkMovieUseFrodo)
        Me.gbMovieFrodo.Controls.Add(Me.chkMovieLandscapeFrodo)
        Me.gbMovieFrodo.Controls.Add(Me.chkMovieBannerFrodo)
        Me.gbMovieFrodo.Controls.Add(Me.chkMovieDiscArtFrodo)
        Me.gbMovieFrodo.Controls.Add(Me.chkMovieClearArtFrodo)
        Me.gbMovieFrodo.Controls.Add(Me.chkMovieClearLogoFrodo)
        Me.gbMovieFrodo.Controls.Add(Me.chkMovieActorThumbsFrodo)
        Me.gbMovieFrodo.Controls.Add(Me.chkMovieTrailerFrodo)
        Me.gbMovieFrodo.Controls.Add(Me.chkMovieFanartFrodo)
        Me.gbMovieFrodo.Controls.Add(Me.chkMoviePosterFrodo)
        Me.gbMovieFrodo.Controls.Add(Me.chkMovieNFOFrodo)
        Me.gbMovieFrodo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.gbMovieFrodo.Location = New System.Drawing.Point(6, 6)
        Me.gbMovieFrodo.Name = "gbMovieFrodo"
        Me.gbMovieFrodo.Size = New System.Drawing.Size(110, 324)
        Me.gbMovieFrodo.TabIndex = 0
        Me.gbMovieFrodo.TabStop = false
        Me.gbMovieFrodo.Text = "Frodo"
        '
        'chkMovieExtrafanartsFrodo
        '
        Me.chkMovieExtrafanartsFrodo.AutoSize = true
        Me.chkMovieExtrafanartsFrodo.Enabled = false
        Me.chkMovieExtrafanartsFrodo.Location = New System.Drawing.Point(6, 159)
        Me.chkMovieExtrafanartsFrodo.Name = "chkMovieExtrafanartsFrodo"
        Me.chkMovieExtrafanartsFrodo.Size = New System.Drawing.Size(87, 17)
        Me.chkMovieExtrafanartsFrodo.TabIndex = 12
        Me.chkMovieExtrafanartsFrodo.Text = "Extrafanarts"
        Me.chkMovieExtrafanartsFrodo.UseVisualStyleBackColor = true
        '
        'chkMovieExtrathumbsFrodo
        '
        Me.chkMovieExtrathumbsFrodo.AutoSize = true
        Me.chkMovieExtrathumbsFrodo.Enabled = false
        Me.chkMovieExtrathumbsFrodo.Location = New System.Drawing.Point(6, 136)
        Me.chkMovieExtrathumbsFrodo.Name = "chkMovieExtrathumbsFrodo"
        Me.chkMovieExtrathumbsFrodo.Size = New System.Drawing.Size(90, 17)
        Me.chkMovieExtrathumbsFrodo.TabIndex = 11
        Me.chkMovieExtrathumbsFrodo.Text = "Extrathumbs"
        Me.chkMovieExtrathumbsFrodo.UseVisualStyleBackColor = true
        '
        'chkMovieUseFrodo
        '
        Me.chkMovieUseFrodo.AutoSize = true
        Me.chkMovieUseFrodo.Location = New System.Drawing.Point(6, 21)
        Me.chkMovieUseFrodo.Name = "chkMovieUseFrodo"
        Me.chkMovieUseFrodo.Size = New System.Drawing.Size(45, 17)
        Me.chkMovieUseFrodo.TabIndex = 10
        Me.chkMovieUseFrodo.Text = "Use"
        Me.chkMovieUseFrodo.UseVisualStyleBackColor = true
        '
        'chkMovieLandscapeFrodo
        '
        Me.chkMovieLandscapeFrodo.AutoSize = true
        Me.chkMovieLandscapeFrodo.Enabled = false
        Me.chkMovieLandscapeFrodo.Location = New System.Drawing.Point(6, 297)
        Me.chkMovieLandscapeFrodo.Name = "chkMovieLandscapeFrodo"
        Me.chkMovieLandscapeFrodo.Size = New System.Drawing.Size(80, 17)
        Me.chkMovieLandscapeFrodo.TabIndex = 9
        Me.chkMovieLandscapeFrodo.Text = "Landscape"
        Me.chkMovieLandscapeFrodo.UseVisualStyleBackColor = true
        '
        'chkMovieBannerFrodo
        '
        Me.chkMovieBannerFrodo.AutoSize = true
        Me.chkMovieBannerFrodo.Enabled = false
        Me.chkMovieBannerFrodo.Location = New System.Drawing.Point(6, 205)
        Me.chkMovieBannerFrodo.Name = "chkMovieBannerFrodo"
        Me.chkMovieBannerFrodo.Size = New System.Drawing.Size(63, 17)
        Me.chkMovieBannerFrodo.TabIndex = 8
        Me.chkMovieBannerFrodo.Text = "Banner"
        Me.chkMovieBannerFrodo.UseVisualStyleBackColor = true
        '
        'chkMovieDiscArtFrodo
        '
        Me.chkMovieDiscArtFrodo.AutoSize = true
        Me.chkMovieDiscArtFrodo.Enabled = false
        Me.chkMovieDiscArtFrodo.Location = New System.Drawing.Point(6, 274)
        Me.chkMovieDiscArtFrodo.Name = "chkMovieDiscArtFrodo"
        Me.chkMovieDiscArtFrodo.Size = New System.Drawing.Size(62, 17)
        Me.chkMovieDiscArtFrodo.TabIndex = 7
        Me.chkMovieDiscArtFrodo.Text = "DiscArt"
        Me.chkMovieDiscArtFrodo.UseVisualStyleBackColor = true
        '
        'chkMovieClearArtFrodo
        '
        Me.chkMovieClearArtFrodo.AutoSize = true
        Me.chkMovieClearArtFrodo.Enabled = false
        Me.chkMovieClearArtFrodo.Location = New System.Drawing.Point(6, 251)
        Me.chkMovieClearArtFrodo.Name = "chkMovieClearArtFrodo"
        Me.chkMovieClearArtFrodo.Size = New System.Drawing.Size(67, 17)
        Me.chkMovieClearArtFrodo.TabIndex = 6
        Me.chkMovieClearArtFrodo.Text = "ClearArt"
        Me.chkMovieClearArtFrodo.UseVisualStyleBackColor = true
        '
        'chkMovieClearLogoFrodo
        '
        Me.chkMovieClearLogoFrodo.AutoSize = true
        Me.chkMovieClearLogoFrodo.Enabled = false
        Me.chkMovieClearLogoFrodo.Location = New System.Drawing.Point(6, 228)
        Me.chkMovieClearLogoFrodo.Name = "chkMovieClearLogoFrodo"
        Me.chkMovieClearLogoFrodo.Size = New System.Drawing.Size(78, 17)
        Me.chkMovieClearLogoFrodo.TabIndex = 5
        Me.chkMovieClearLogoFrodo.Text = "ClearLogo"
        Me.chkMovieClearLogoFrodo.UseVisualStyleBackColor = true
        '
        'chkMovieActorThumbsFrodo
        '
        Me.chkMovieActorThumbsFrodo.AutoSize = true
        Me.chkMovieActorThumbsFrodo.Enabled = false
        Me.chkMovieActorThumbsFrodo.Location = New System.Drawing.Point(6, 113)
        Me.chkMovieActorThumbsFrodo.Name = "chkMovieActorThumbsFrodo"
        Me.chkMovieActorThumbsFrodo.Size = New System.Drawing.Size(96, 17)
        Me.chkMovieActorThumbsFrodo.TabIndex = 4
        Me.chkMovieActorThumbsFrodo.Text = "Actor Thumbs"
        Me.chkMovieActorThumbsFrodo.UseVisualStyleBackColor = true
        '
        'chkMovieTrailerFrodo
        '
        Me.chkMovieTrailerFrodo.AutoSize = true
        Me.chkMovieTrailerFrodo.Enabled = false
        Me.chkMovieTrailerFrodo.Location = New System.Drawing.Point(6, 182)
        Me.chkMovieTrailerFrodo.Name = "chkMovieTrailerFrodo"
        Me.chkMovieTrailerFrodo.Size = New System.Drawing.Size(57, 17)
        Me.chkMovieTrailerFrodo.TabIndex = 3
        Me.chkMovieTrailerFrodo.Text = "Trailer"
        Me.chkMovieTrailerFrodo.UseVisualStyleBackColor = true
        '
        'chkMovieFanartFrodo
        '
        Me.chkMovieFanartFrodo.AutoSize = true
        Me.chkMovieFanartFrodo.Enabled = false
        Me.chkMovieFanartFrodo.Location = New System.Drawing.Point(6, 90)
        Me.chkMovieFanartFrodo.Name = "chkMovieFanartFrodo"
        Me.chkMovieFanartFrodo.Size = New System.Drawing.Size(59, 17)
        Me.chkMovieFanartFrodo.TabIndex = 2
        Me.chkMovieFanartFrodo.Text = "Fanart"
        Me.chkMovieFanartFrodo.UseVisualStyleBackColor = true
        '
        'chkMoviePosterFrodo
        '
        Me.chkMoviePosterFrodo.AutoSize = true
        Me.chkMoviePosterFrodo.Enabled = false
        Me.chkMoviePosterFrodo.Location = New System.Drawing.Point(6, 67)
        Me.chkMoviePosterFrodo.Name = "chkMoviePosterFrodo"
        Me.chkMoviePosterFrodo.Size = New System.Drawing.Size(58, 17)
        Me.chkMoviePosterFrodo.TabIndex = 1
        Me.chkMoviePosterFrodo.Text = "Poster"
        Me.chkMoviePosterFrodo.UseVisualStyleBackColor = true
        '
        'chkMovieNFOFrodo
        '
        Me.chkMovieNFOFrodo.AutoSize = true
        Me.chkMovieNFOFrodo.Enabled = false
        Me.chkMovieNFOFrodo.Location = New System.Drawing.Point(6, 44)
        Me.chkMovieNFOFrodo.Name = "chkMovieNFOFrodo"
        Me.chkMovieNFOFrodo.Size = New System.Drawing.Size(49, 17)
        Me.chkMovieNFOFrodo.TabIndex = 0
        Me.chkMovieNFOFrodo.Text = "NFO"
        Me.chkMovieNFOFrodo.UseVisualStyleBackColor = true
        '
        'tpMovieFileNamingNMT
        '
        Me.tpMovieFileNamingNMT.Controls.Add(Me.gbMovieNMTOptional)
        Me.tpMovieFileNamingNMT.Controls.Add(Me.gbMovieNMJ)
        Me.tpMovieFileNamingNMT.Controls.Add(Me.gbMovieYAMJ)
        Me.tpMovieFileNamingNMT.Location = New System.Drawing.Point(4, 22)
        Me.tpMovieFileNamingNMT.Name = "tpMovieFileNamingNMT"
        Me.tpMovieFileNamingNMT.Padding = New System.Windows.Forms.Padding(3)
        Me.tpMovieFileNamingNMT.Size = New System.Drawing.Size(505, 336)
        Me.tpMovieFileNamingNMT.TabIndex = 3
        Me.tpMovieFileNamingNMT.Text = "NMT"
        Me.tpMovieFileNamingNMT.UseVisualStyleBackColor = true
        '
        'gbMovieNMTOptional
        '
        Me.gbMovieNMTOptional.Controls.Add(Me.chkMovieYAMJCompatibleSets)
        Me.gbMovieNMTOptional.Controls.Add(Me.btnMovieYAMJWatchedFilesBrowse)
        Me.gbMovieNMTOptional.Controls.Add(Me.txtMovieYAMJWatchedFolder)
        Me.gbMovieNMTOptional.Controls.Add(Me.chkMovieYAMJWatchedFile)
        Me.gbMovieNMTOptional.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.gbMovieNMTOptional.Location = New System.Drawing.Point(238, 6)
        Me.gbMovieNMTOptional.Name = "gbMovieNMTOptional"
        Me.gbMovieNMTOptional.Size = New System.Drawing.Size(261, 107)
        Me.gbMovieNMTOptional.TabIndex = 18
        Me.gbMovieNMTOptional.TabStop = false
        Me.gbMovieNMTOptional.Text = "Optional Settings"
        '
        'chkMovieYAMJCompatibleSets
        '
        Me.chkMovieYAMJCompatibleSets.AutoSize = true
        Me.chkMovieYAMJCompatibleSets.Location = New System.Drawing.Point(6, 21)
        Me.chkMovieYAMJCompatibleSets.Name = "chkMovieYAMJCompatibleSets"
        Me.chkMovieYAMJCompatibleSets.Size = New System.Drawing.Size(138, 17)
        Me.chkMovieYAMJCompatibleSets.TabIndex = 3
        Me.chkMovieYAMJCompatibleSets.Text = "YAMJ Compatible Sets"
        Me.chkMovieYAMJCompatibleSets.UseVisualStyleBackColor = true
        '
        'btnMovieYAMJWatchedFilesBrowse
        '
        Me.btnMovieYAMJWatchedFilesBrowse.Enabled = false
        Me.btnMovieYAMJWatchedFilesBrowse.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.btnMovieYAMJWatchedFilesBrowse.Location = New System.Drawing.Point(230, 67)
        Me.btnMovieYAMJWatchedFilesBrowse.Name = "btnMovieYAMJWatchedFilesBrowse"
        Me.btnMovieYAMJWatchedFilesBrowse.Size = New System.Drawing.Size(25, 22)
        Me.btnMovieYAMJWatchedFilesBrowse.TabIndex = 2
        Me.btnMovieYAMJWatchedFilesBrowse.Text = "..."
        Me.btnMovieYAMJWatchedFilesBrowse.UseVisualStyleBackColor = true
        '
        'txtMovieYAMJWatchedFolder
        '
        Me.txtMovieYAMJWatchedFolder.Enabled = false
        Me.txtMovieYAMJWatchedFolder.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtMovieYAMJWatchedFolder.Location = New System.Drawing.Point(6, 67)
        Me.txtMovieYAMJWatchedFolder.Name = "txtMovieYAMJWatchedFolder"
        Me.txtMovieYAMJWatchedFolder.Size = New System.Drawing.Size(218, 22)
        Me.txtMovieYAMJWatchedFolder.TabIndex = 1
        '
        'chkMovieYAMJWatchedFile
        '
        Me.chkMovieYAMJWatchedFile.AutoSize = true
        Me.chkMovieYAMJWatchedFile.Enabled = false
        Me.chkMovieYAMJWatchedFile.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.chkMovieYAMJWatchedFile.Location = New System.Drawing.Point(6, 44)
        Me.chkMovieYAMJWatchedFile.Name = "chkMovieYAMJWatchedFile"
        Me.chkMovieYAMJWatchedFile.Size = New System.Drawing.Size(121, 17)
        Me.chkMovieYAMJWatchedFile.TabIndex = 0
        Me.chkMovieYAMJWatchedFile.Text = "Use .watched Files"
        Me.chkMovieYAMJWatchedFile.UseVisualStyleBackColor = true
        '
        'gbMovieNMJ
        '
        Me.gbMovieNMJ.Controls.Add(Me.chkMovieUseNMJ)
        Me.gbMovieNMJ.Controls.Add(Me.chkMovieBannerNMJ)
        Me.gbMovieNMJ.Controls.Add(Me.chkMovieTrailerNMJ)
        Me.gbMovieNMJ.Controls.Add(Me.chkMovieFanartNMJ)
        Me.gbMovieNMJ.Controls.Add(Me.chkMoviePosterNMJ)
        Me.gbMovieNMJ.Controls.Add(Me.chkMovieNFONMJ)
        Me.gbMovieNMJ.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.gbMovieNMJ.Location = New System.Drawing.Point(122, 6)
        Me.gbMovieNMJ.Name = "gbMovieNMJ"
        Me.gbMovieNMJ.Size = New System.Drawing.Size(110, 324)
        Me.gbMovieNMJ.TabIndex = 17
        Me.gbMovieNMJ.TabStop = false
        Me.gbMovieNMJ.Text = "NMJ"
        '
        'chkMovieUseNMJ
        '
        Me.chkMovieUseNMJ.AutoSize = true
        Me.chkMovieUseNMJ.Location = New System.Drawing.Point(6, 21)
        Me.chkMovieUseNMJ.Name = "chkMovieUseNMJ"
        Me.chkMovieUseNMJ.Size = New System.Drawing.Size(45, 17)
        Me.chkMovieUseNMJ.TabIndex = 16
        Me.chkMovieUseNMJ.Text = "Use"
        Me.chkMovieUseNMJ.UseVisualStyleBackColor = true
        '
        'chkMovieBannerNMJ
        '
        Me.chkMovieBannerNMJ.AutoSize = true
        Me.chkMovieBannerNMJ.Enabled = false
        Me.chkMovieBannerNMJ.Location = New System.Drawing.Point(6, 113)
        Me.chkMovieBannerNMJ.Name = "chkMovieBannerNMJ"
        Me.chkMovieBannerNMJ.Size = New System.Drawing.Size(63, 17)
        Me.chkMovieBannerNMJ.TabIndex = 15
        Me.chkMovieBannerNMJ.Text = "Banner"
        Me.chkMovieBannerNMJ.UseVisualStyleBackColor = true
        '
        'chkMovieTrailerNMJ
        '
        Me.chkMovieTrailerNMJ.AutoSize = true
        Me.chkMovieTrailerNMJ.Enabled = false
        Me.chkMovieTrailerNMJ.Location = New System.Drawing.Point(6, 136)
        Me.chkMovieTrailerNMJ.Name = "chkMovieTrailerNMJ"
        Me.chkMovieTrailerNMJ.Size = New System.Drawing.Size(57, 17)
        Me.chkMovieTrailerNMJ.TabIndex = 14
        Me.chkMovieTrailerNMJ.Text = "Trailer"
        Me.chkMovieTrailerNMJ.UseVisualStyleBackColor = true
        '
        'chkMovieFanartNMJ
        '
        Me.chkMovieFanartNMJ.AutoSize = true
        Me.chkMovieFanartNMJ.Enabled = false
        Me.chkMovieFanartNMJ.Location = New System.Drawing.Point(6, 90)
        Me.chkMovieFanartNMJ.Name = "chkMovieFanartNMJ"
        Me.chkMovieFanartNMJ.Size = New System.Drawing.Size(59, 17)
        Me.chkMovieFanartNMJ.TabIndex = 13
        Me.chkMovieFanartNMJ.Text = "Fanart"
        Me.chkMovieFanartNMJ.UseVisualStyleBackColor = true
        '
        'chkMoviePosterNMJ
        '
        Me.chkMoviePosterNMJ.AutoSize = true
        Me.chkMoviePosterNMJ.Enabled = false
        Me.chkMoviePosterNMJ.Location = New System.Drawing.Point(6, 67)
        Me.chkMoviePosterNMJ.Name = "chkMoviePosterNMJ"
        Me.chkMoviePosterNMJ.Size = New System.Drawing.Size(58, 17)
        Me.chkMoviePosterNMJ.TabIndex = 12
        Me.chkMoviePosterNMJ.Text = "Poster"
        Me.chkMoviePosterNMJ.UseVisualStyleBackColor = true
        '
        'chkMovieNFONMJ
        '
        Me.chkMovieNFONMJ.AutoSize = true
        Me.chkMovieNFONMJ.Enabled = false
        Me.chkMovieNFONMJ.Location = New System.Drawing.Point(6, 44)
        Me.chkMovieNFONMJ.Name = "chkMovieNFONMJ"
        Me.chkMovieNFONMJ.Size = New System.Drawing.Size(49, 17)
        Me.chkMovieNFONMJ.TabIndex = 11
        Me.chkMovieNFONMJ.Text = "NFO"
        Me.chkMovieNFONMJ.UseVisualStyleBackColor = true
        '
        'gbMovieYAMJ
        '
        Me.gbMovieYAMJ.Controls.Add(Me.chkMovieUseYAMJ)
        Me.gbMovieYAMJ.Controls.Add(Me.chkMovieBannerYAMJ)
        Me.gbMovieYAMJ.Controls.Add(Me.chkMovieTrailerYAMJ)
        Me.gbMovieYAMJ.Controls.Add(Me.chkMovieFanartYAMJ)
        Me.gbMovieYAMJ.Controls.Add(Me.chkMoviePosterYAMJ)
        Me.gbMovieYAMJ.Controls.Add(Me.chkMovieNFOYAMJ)
        Me.gbMovieYAMJ.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.gbMovieYAMJ.Location = New System.Drawing.Point(6, 6)
        Me.gbMovieYAMJ.Name = "gbMovieYAMJ"
        Me.gbMovieYAMJ.Size = New System.Drawing.Size(110, 324)
        Me.gbMovieYAMJ.TabIndex = 3
        Me.gbMovieYAMJ.TabStop = false
        Me.gbMovieYAMJ.Text = "YAMJ"
        '
        'chkMovieUseYAMJ
        '
        Me.chkMovieUseYAMJ.AutoSize = true
        Me.chkMovieUseYAMJ.Location = New System.Drawing.Point(6, 21)
        Me.chkMovieUseYAMJ.Name = "chkMovieUseYAMJ"
        Me.chkMovieUseYAMJ.Size = New System.Drawing.Size(45, 17)
        Me.chkMovieUseYAMJ.TabIndex = 16
        Me.chkMovieUseYAMJ.Text = "Use"
        Me.chkMovieUseYAMJ.UseVisualStyleBackColor = true
        '
        'chkMovieBannerYAMJ
        '
        Me.chkMovieBannerYAMJ.AutoSize = true
        Me.chkMovieBannerYAMJ.Enabled = false
        Me.chkMovieBannerYAMJ.Location = New System.Drawing.Point(6, 113)
        Me.chkMovieBannerYAMJ.Name = "chkMovieBannerYAMJ"
        Me.chkMovieBannerYAMJ.Size = New System.Drawing.Size(63, 17)
        Me.chkMovieBannerYAMJ.TabIndex = 15
        Me.chkMovieBannerYAMJ.Text = "Banner"
        Me.chkMovieBannerYAMJ.UseVisualStyleBackColor = true
        '
        'chkMovieTrailerYAMJ
        '
        Me.chkMovieTrailerYAMJ.AutoSize = true
        Me.chkMovieTrailerYAMJ.Enabled = false
        Me.chkMovieTrailerYAMJ.Location = New System.Drawing.Point(6, 136)
        Me.chkMovieTrailerYAMJ.Name = "chkMovieTrailerYAMJ"
        Me.chkMovieTrailerYAMJ.Size = New System.Drawing.Size(57, 17)
        Me.chkMovieTrailerYAMJ.TabIndex = 14
        Me.chkMovieTrailerYAMJ.Text = "Trailer"
        Me.chkMovieTrailerYAMJ.UseVisualStyleBackColor = true
        '
        'chkMovieFanartYAMJ
        '
        Me.chkMovieFanartYAMJ.AutoSize = true
        Me.chkMovieFanartYAMJ.Enabled = false
        Me.chkMovieFanartYAMJ.Location = New System.Drawing.Point(6, 90)
        Me.chkMovieFanartYAMJ.Name = "chkMovieFanartYAMJ"
        Me.chkMovieFanartYAMJ.Size = New System.Drawing.Size(59, 17)
        Me.chkMovieFanartYAMJ.TabIndex = 13
        Me.chkMovieFanartYAMJ.Text = "Fanart"
        Me.chkMovieFanartYAMJ.UseVisualStyleBackColor = true
        '
        'chkMoviePosterYAMJ
        '
        Me.chkMoviePosterYAMJ.AutoSize = true
        Me.chkMoviePosterYAMJ.Enabled = false
        Me.chkMoviePosterYAMJ.Location = New System.Drawing.Point(6, 67)
        Me.chkMoviePosterYAMJ.Name = "chkMoviePosterYAMJ"
        Me.chkMoviePosterYAMJ.Size = New System.Drawing.Size(58, 17)
        Me.chkMoviePosterYAMJ.TabIndex = 12
        Me.chkMoviePosterYAMJ.Text = "Poster"
        Me.chkMoviePosterYAMJ.UseVisualStyleBackColor = true
        '
        'chkMovieNFOYAMJ
        '
        Me.chkMovieNFOYAMJ.AutoSize = true
        Me.chkMovieNFOYAMJ.Enabled = false
        Me.chkMovieNFOYAMJ.Location = New System.Drawing.Point(6, 44)
        Me.chkMovieNFOYAMJ.Name = "chkMovieNFOYAMJ"
        Me.chkMovieNFOYAMJ.Size = New System.Drawing.Size(49, 17)
        Me.chkMovieNFOYAMJ.TabIndex = 11
        Me.chkMovieNFOYAMJ.Text = "NFO"
        Me.chkMovieNFOYAMJ.UseVisualStyleBackColor = true
        '
        'tpMovieFileNamingExpert
        '
        Me.tpMovieFileNamingExpert.Controls.Add(Me.gbMovieExpert)
        Me.tpMovieFileNamingExpert.Location = New System.Drawing.Point(4, 22)
        Me.tpMovieFileNamingExpert.Name = "tpMovieFileNamingExpert"
        Me.tpMovieFileNamingExpert.Padding = New System.Windows.Forms.Padding(3)
        Me.tpMovieFileNamingExpert.Size = New System.Drawing.Size(505, 336)
        Me.tpMovieFileNamingExpert.TabIndex = 2
        Me.tpMovieFileNamingExpert.Text = "Expert"
        Me.tpMovieFileNamingExpert.UseVisualStyleBackColor = true
        '
        'gbMovieExpert
        '
        Me.gbMovieExpert.Controls.Add(Me.tcMovieFileNamingExpert)
        Me.gbMovieExpert.Controls.Add(Me.chkMovieUseExpert)
        Me.gbMovieExpert.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.gbMovieExpert.Location = New System.Drawing.Point(6, 6)
        Me.gbMovieExpert.Name = "gbMovieExpert"
        Me.gbMovieExpert.Size = New System.Drawing.Size(493, 324)
        Me.gbMovieExpert.TabIndex = 7
        Me.gbMovieExpert.TabStop = false
        Me.gbMovieExpert.Text = "Expert Settings"
        '
        'tcMovieFileNamingExpert
        '
        Me.tcMovieFileNamingExpert.Controls.Add(Me.tpMovieFileNamingExpertSingle)
        Me.tcMovieFileNamingExpert.Controls.Add(Me.tpMovieFileNamingExpertMulti)
        Me.tcMovieFileNamingExpert.Controls.Add(Me.tpMovieFileNamingExpertVTS)
        Me.tcMovieFileNamingExpert.Controls.Add(Me.tpMovieFileNamingExpertBDMV)
        Me.tcMovieFileNamingExpert.Location = New System.Drawing.Point(6, 44)
        Me.tcMovieFileNamingExpert.Name = "tcMovieFileNamingExpert"
        Me.tcMovieFileNamingExpert.SelectedIndex = 0
        Me.tcMovieFileNamingExpert.Size = New System.Drawing.Size(481, 280)
        Me.tcMovieFileNamingExpert.TabIndex = 2
        '
        'tpMovieFileNamingExpertSingle
        '
        Me.tpMovieFileNamingExpertSingle.Controls.Add(Me.gbMovieExpertSingleOptionalSettings)
        Me.tpMovieFileNamingExpertSingle.Controls.Add(Me.gbMovieExpertSingleOptionalImages)
        Me.tpMovieFileNamingExpertSingle.Controls.Add(Me.lblMovieClearArtExpertSingle)
        Me.tpMovieFileNamingExpertSingle.Controls.Add(Me.txtMoviePosterExpertSingle)
        Me.tpMovieFileNamingExpertSingle.Controls.Add(Me.txtMovieFanartExpertSingle)
        Me.tpMovieFileNamingExpertSingle.Controls.Add(Me.txtMovieTrailerExpertSingle)
        Me.tpMovieFileNamingExpertSingle.Controls.Add(Me.txtMovieBannerExpertSingle)
        Me.tpMovieFileNamingExpertSingle.Controls.Add(Me.txtMovieClearLogoExpertSingle)
        Me.tpMovieFileNamingExpertSingle.Controls.Add(Me.txtMovieClearArtExpertSingle)
        Me.tpMovieFileNamingExpertSingle.Controls.Add(Me.txtMovieLandscapeExpertSingle)
        Me.tpMovieFileNamingExpertSingle.Controls.Add(Me.txtMovieDiscArtExpertSingle)
        Me.tpMovieFileNamingExpertSingle.Controls.Add(Me.lblMovieLandscapeExpertSingle)
        Me.tpMovieFileNamingExpertSingle.Controls.Add(Me.lblMovieDiscArtExpertSingle)
        Me.tpMovieFileNamingExpertSingle.Controls.Add(Me.lblMovieBannerExpertSingle)
        Me.tpMovieFileNamingExpertSingle.Controls.Add(Me.lblMovieTrailerExpertSingle)
        Me.tpMovieFileNamingExpertSingle.Controls.Add(Me.lblMovieClearLogoExpertSingle)
        Me.tpMovieFileNamingExpertSingle.Controls.Add(Me.lblMovieFanartExpertSingle)
        Me.tpMovieFileNamingExpertSingle.Controls.Add(Me.lblMoviePosterExpertSingle)
        Me.tpMovieFileNamingExpertSingle.Controls.Add(Me.txtMovieNFOExpertSingle)
        Me.tpMovieFileNamingExpertSingle.Controls.Add(Me.lblMovieNFOExpertSingle)
        Me.tpMovieFileNamingExpertSingle.Location = New System.Drawing.Point(4, 22)
        Me.tpMovieFileNamingExpertSingle.Name = "tpMovieFileNamingExpertSingle"
        Me.tpMovieFileNamingExpertSingle.Padding = New System.Windows.Forms.Padding(3)
        Me.tpMovieFileNamingExpertSingle.Size = New System.Drawing.Size(473, 254)
        Me.tpMovieFileNamingExpertSingle.TabIndex = 0
        Me.tpMovieFileNamingExpertSingle.Text = "Single"
        Me.tpMovieFileNamingExpertSingle.UseVisualStyleBackColor = true
        '
        'gbMovieExpertSingleOptionalSettings
        '
        Me.gbMovieExpertSingleOptionalSettings.Controls.Add(Me.chkMovieUnstackExpertSingle)
        Me.gbMovieExpertSingleOptionalSettings.Controls.Add(Me.chkMovieStackExpertSingle)
        Me.gbMovieExpertSingleOptionalSettings.Controls.Add(Me.chkMovieXBMCTrailerFormatExpertSingle)
        Me.gbMovieExpertSingleOptionalSettings.Location = New System.Drawing.Point(307, 6)
        Me.gbMovieExpertSingleOptionalSettings.Name = "gbMovieExpertSingleOptionalSettings"
        Me.gbMovieExpertSingleOptionalSettings.Size = New System.Drawing.Size(160, 93)
        Me.gbMovieExpertSingleOptionalSettings.TabIndex = 12
        Me.gbMovieExpertSingleOptionalSettings.TabStop = false
        Me.gbMovieExpertSingleOptionalSettings.Text = "Optional Settings"
        '
        'chkMovieUnstackExpertSingle
        '
        Me.chkMovieUnstackExpertSingle.AutoSize = true
        Me.chkMovieUnstackExpertSingle.Enabled = false
        Me.chkMovieUnstackExpertSingle.Location = New System.Drawing.Point(6, 67)
        Me.chkMovieUnstackExpertSingle.Name = "chkMovieUnstackExpertSingle"
        Me.chkMovieUnstackExpertSingle.Size = New System.Drawing.Size(128, 17)
        Me.chkMovieUnstackExpertSingle.TabIndex = 3
        Me.chkMovieUnstackExpertSingle.Text = "also save unstacked"
        Me.chkMovieUnstackExpertSingle.UseVisualStyleBackColor = true
        '
        'chkMovieStackExpertSingle
        '
        Me.chkMovieStackExpertSingle.AutoSize = true
        Me.chkMovieStackExpertSingle.Enabled = false
        Me.chkMovieStackExpertSingle.Location = New System.Drawing.Point(6, 44)
        Me.chkMovieStackExpertSingle.Name = "chkMovieStackExpertSingle"
        Me.chkMovieStackExpertSingle.Size = New System.Drawing.Size(116, 17)
        Me.chkMovieStackExpertSingle.TabIndex = 2
        Me.chkMovieStackExpertSingle.Text = "Stack <filename>"
        Me.chkMovieStackExpertSingle.UseVisualStyleBackColor = true
        '
        'chkMovieXBMCTrailerFormatExpertSingle
        '
        Me.chkMovieXBMCTrailerFormatExpertSingle.AutoSize = true
        Me.chkMovieXBMCTrailerFormatExpertSingle.Enabled = false
        Me.chkMovieXBMCTrailerFormatExpertSingle.Location = New System.Drawing.Point(6, 21)
        Me.chkMovieXBMCTrailerFormatExpertSingle.Name = "chkMovieXBMCTrailerFormatExpertSingle"
        Me.chkMovieXBMCTrailerFormatExpertSingle.Size = New System.Drawing.Size(129, 17)
        Me.chkMovieXBMCTrailerFormatExpertSingle.TabIndex = 1
        Me.chkMovieXBMCTrailerFormatExpertSingle.Text = "XBMC Trailer Format"
        Me.chkMovieXBMCTrailerFormatExpertSingle.UseVisualStyleBackColor = true
        '
        'gbMovieExpertSingleOptionalImages
        '
        Me.gbMovieExpertSingleOptionalImages.Controls.Add(Me.txtMovieActorThumbsExtExpertSingle)
        Me.gbMovieExpertSingleOptionalImages.Controls.Add(Me.chkMovieActorThumbsExpertSingle)
        Me.gbMovieExpertSingleOptionalImages.Controls.Add(Me.chkMovieExtrafanartsExpertSingle)
        Me.gbMovieExpertSingleOptionalImages.Controls.Add(Me.chkMovieExtrathumbsExpertSingle)
        Me.gbMovieExpertSingleOptionalImages.Location = New System.Drawing.Point(307, 105)
        Me.gbMovieExpertSingleOptionalImages.Name = "gbMovieExpertSingleOptionalImages"
        Me.gbMovieExpertSingleOptionalImages.Size = New System.Drawing.Size(160, 93)
        Me.gbMovieExpertSingleOptionalImages.TabIndex = 13
        Me.gbMovieExpertSingleOptionalImages.TabStop = false
        Me.gbMovieExpertSingleOptionalImages.Text = "Optional Images"
        '
        'txtMovieActorThumbsExtExpertSingle
        '
        Me.txtMovieActorThumbsExtExpertSingle.Enabled = false
        Me.txtMovieActorThumbsExtExpertSingle.Location = New System.Drawing.Point(108, 19)
        Me.txtMovieActorThumbsExtExpertSingle.Name = "txtMovieActorThumbsExtExpertSingle"
        Me.txtMovieActorThumbsExtExpertSingle.Size = New System.Drawing.Size(46, 22)
        Me.txtMovieActorThumbsExtExpertSingle.TabIndex = 2
        '
        'chkMovieActorThumbsExpertSingle
        '
        Me.chkMovieActorThumbsExpertSingle.AutoSize = true
        Me.chkMovieActorThumbsExpertSingle.Enabled = false
        Me.chkMovieActorThumbsExpertSingle.Location = New System.Drawing.Point(6, 21)
        Me.chkMovieActorThumbsExpertSingle.Name = "chkMovieActorThumbsExpertSingle"
        Me.chkMovieActorThumbsExpertSingle.Size = New System.Drawing.Size(96, 17)
        Me.chkMovieActorThumbsExpertSingle.TabIndex = 1
        Me.chkMovieActorThumbsExpertSingle.Text = "Actor Thumbs"
        Me.chkMovieActorThumbsExpertSingle.UseVisualStyleBackColor = true
        '
        'chkMovieExtrafanartsExpertSingle
        '
        Me.chkMovieExtrafanartsExpertSingle.AutoSize = true
        Me.chkMovieExtrafanartsExpertSingle.Enabled = false
        Me.chkMovieExtrafanartsExpertSingle.Location = New System.Drawing.Point(6, 67)
        Me.chkMovieExtrafanartsExpertSingle.Name = "chkMovieExtrafanartsExpertSingle"
        Me.chkMovieExtrafanartsExpertSingle.Size = New System.Drawing.Size(87, 17)
        Me.chkMovieExtrafanartsExpertSingle.TabIndex = 4
        Me.chkMovieExtrafanartsExpertSingle.Text = "Extrafanarts"
        Me.chkMovieExtrafanartsExpertSingle.UseVisualStyleBackColor = true
        '
        'chkMovieExtrathumbsExpertSingle
        '
        Me.chkMovieExtrathumbsExpertSingle.AutoSize = true
        Me.chkMovieExtrathumbsExpertSingle.Enabled = false
        Me.chkMovieExtrathumbsExpertSingle.Location = New System.Drawing.Point(6, 44)
        Me.chkMovieExtrathumbsExpertSingle.Name = "chkMovieExtrathumbsExpertSingle"
        Me.chkMovieExtrathumbsExpertSingle.Size = New System.Drawing.Size(90, 17)
        Me.chkMovieExtrathumbsExpertSingle.TabIndex = 3
        Me.chkMovieExtrathumbsExpertSingle.Text = "Extrathumbs"
        Me.chkMovieExtrathumbsExpertSingle.UseVisualStyleBackColor = true
        '
        'lblMovieClearArtExpertSingle
        '
        Me.lblMovieClearArtExpertSingle.AutoSize = true
        Me.lblMovieClearArtExpertSingle.Location = New System.Drawing.Point(6, 171)
        Me.lblMovieClearArtExpertSingle.Name = "lblMovieClearArtExpertSingle"
        Me.lblMovieClearArtExpertSingle.Size = New System.Drawing.Size(48, 13)
        Me.lblMovieClearArtExpertSingle.TabIndex = 28
        Me.lblMovieClearArtExpertSingle.Text = "ClearArt"
        '
        'txtMoviePosterExpertSingle
        '
        Me.txtMoviePosterExpertSingle.Enabled = false
        Me.txtMoviePosterExpertSingle.Location = New System.Drawing.Point(71, 33)
        Me.txtMoviePosterExpertSingle.Name = "txtMoviePosterExpertSingle"
        Me.txtMoviePosterExpertSingle.Size = New System.Drawing.Size(220, 22)
        Me.txtMoviePosterExpertSingle.TabIndex = 4
        '
        'txtMovieFanartExpertSingle
        '
        Me.txtMovieFanartExpertSingle.Enabled = false
        Me.txtMovieFanartExpertSingle.Location = New System.Drawing.Point(71, 60)
        Me.txtMovieFanartExpertSingle.Name = "txtMovieFanartExpertSingle"
        Me.txtMovieFanartExpertSingle.Size = New System.Drawing.Size(220, 22)
        Me.txtMovieFanartExpertSingle.TabIndex = 5
        '
        'txtMovieTrailerExpertSingle
        '
        Me.txtMovieTrailerExpertSingle.Enabled = false
        Me.txtMovieTrailerExpertSingle.Location = New System.Drawing.Point(71, 87)
        Me.txtMovieTrailerExpertSingle.Name = "txtMovieTrailerExpertSingle"
        Me.txtMovieTrailerExpertSingle.Size = New System.Drawing.Size(220, 22)
        Me.txtMovieTrailerExpertSingle.TabIndex = 6
        '
        'txtMovieBannerExpertSingle
        '
        Me.txtMovieBannerExpertSingle.Enabled = false
        Me.txtMovieBannerExpertSingle.Location = New System.Drawing.Point(71, 114)
        Me.txtMovieBannerExpertSingle.Name = "txtMovieBannerExpertSingle"
        Me.txtMovieBannerExpertSingle.Size = New System.Drawing.Size(220, 22)
        Me.txtMovieBannerExpertSingle.TabIndex = 7
        '
        'txtMovieClearLogoExpertSingle
        '
        Me.txtMovieClearLogoExpertSingle.Enabled = false
        Me.txtMovieClearLogoExpertSingle.Location = New System.Drawing.Point(71, 141)
        Me.txtMovieClearLogoExpertSingle.Name = "txtMovieClearLogoExpertSingle"
        Me.txtMovieClearLogoExpertSingle.Size = New System.Drawing.Size(220, 22)
        Me.txtMovieClearLogoExpertSingle.TabIndex = 8
        '
        'txtMovieClearArtExpertSingle
        '
        Me.txtMovieClearArtExpertSingle.Enabled = false
        Me.txtMovieClearArtExpertSingle.Location = New System.Drawing.Point(71, 168)
        Me.txtMovieClearArtExpertSingle.Name = "txtMovieClearArtExpertSingle"
        Me.txtMovieClearArtExpertSingle.Size = New System.Drawing.Size(220, 22)
        Me.txtMovieClearArtExpertSingle.TabIndex = 9
        '
        'txtMovieLandscapeExpertSingle
        '
        Me.txtMovieLandscapeExpertSingle.Enabled = false
        Me.txtMovieLandscapeExpertSingle.Location = New System.Drawing.Point(71, 222)
        Me.txtMovieLandscapeExpertSingle.Name = "txtMovieLandscapeExpertSingle"
        Me.txtMovieLandscapeExpertSingle.Size = New System.Drawing.Size(220, 22)
        Me.txtMovieLandscapeExpertSingle.TabIndex = 11
        '
        'txtMovieDiscArtExpertSingle
        '
        Me.txtMovieDiscArtExpertSingle.Enabled = false
        Me.txtMovieDiscArtExpertSingle.Location = New System.Drawing.Point(71, 195)
        Me.txtMovieDiscArtExpertSingle.Name = "txtMovieDiscArtExpertSingle"
        Me.txtMovieDiscArtExpertSingle.Size = New System.Drawing.Size(220, 22)
        Me.txtMovieDiscArtExpertSingle.TabIndex = 10
        '
        'lblMovieLandscapeExpertSingle
        '
        Me.lblMovieLandscapeExpertSingle.AutoSize = true
        Me.lblMovieLandscapeExpertSingle.Location = New System.Drawing.Point(6, 225)
        Me.lblMovieLandscapeExpertSingle.Name = "lblMovieLandscapeExpertSingle"
        Me.lblMovieLandscapeExpertSingle.Size = New System.Drawing.Size(61, 13)
        Me.lblMovieLandscapeExpertSingle.TabIndex = 19
        Me.lblMovieLandscapeExpertSingle.Text = "Landscape"
        '
        'lblMovieDiscArtExpertSingle
        '
        Me.lblMovieDiscArtExpertSingle.AutoSize = true
        Me.lblMovieDiscArtExpertSingle.Location = New System.Drawing.Point(6, 198)
        Me.lblMovieDiscArtExpertSingle.Name = "lblMovieDiscArtExpertSingle"
        Me.lblMovieDiscArtExpertSingle.Size = New System.Drawing.Size(43, 13)
        Me.lblMovieDiscArtExpertSingle.TabIndex = 18
        Me.lblMovieDiscArtExpertSingle.Text = "DiscArt"
        '
        'lblMovieBannerExpertSingle
        '
        Me.lblMovieBannerExpertSingle.AutoSize = true
        Me.lblMovieBannerExpertSingle.Location = New System.Drawing.Point(6, 117)
        Me.lblMovieBannerExpertSingle.Name = "lblMovieBannerExpertSingle"
        Me.lblMovieBannerExpertSingle.Size = New System.Drawing.Size(44, 13)
        Me.lblMovieBannerExpertSingle.TabIndex = 17
        Me.lblMovieBannerExpertSingle.Text = "Banner"
        '
        'lblMovieTrailerExpertSingle
        '
        Me.lblMovieTrailerExpertSingle.AutoSize = true
        Me.lblMovieTrailerExpertSingle.Location = New System.Drawing.Point(6, 90)
        Me.lblMovieTrailerExpertSingle.Name = "lblMovieTrailerExpertSingle"
        Me.lblMovieTrailerExpertSingle.Size = New System.Drawing.Size(38, 13)
        Me.lblMovieTrailerExpertSingle.TabIndex = 13
        Me.lblMovieTrailerExpertSingle.Text = "Trailer"
        '
        'lblMovieClearLogoExpertSingle
        '
        Me.lblMovieClearLogoExpertSingle.AutoSize = true
        Me.lblMovieClearLogoExpertSingle.Location = New System.Drawing.Point(6, 144)
        Me.lblMovieClearLogoExpertSingle.Name = "lblMovieClearLogoExpertSingle"
        Me.lblMovieClearLogoExpertSingle.Size = New System.Drawing.Size(59, 13)
        Me.lblMovieClearLogoExpertSingle.TabIndex = 12
        Me.lblMovieClearLogoExpertSingle.Text = "ClearLogo"
        '
        'lblMovieFanartExpertSingle
        '
        Me.lblMovieFanartExpertSingle.AutoSize = true
        Me.lblMovieFanartExpertSingle.Location = New System.Drawing.Point(6, 64)
        Me.lblMovieFanartExpertSingle.Name = "lblMovieFanartExpertSingle"
        Me.lblMovieFanartExpertSingle.Size = New System.Drawing.Size(40, 13)
        Me.lblMovieFanartExpertSingle.TabIndex = 11
        Me.lblMovieFanartExpertSingle.Text = "Fanart"
        '
        'lblMoviePosterExpertSingle
        '
        Me.lblMoviePosterExpertSingle.AutoSize = true
        Me.lblMoviePosterExpertSingle.Location = New System.Drawing.Point(6, 36)
        Me.lblMoviePosterExpertSingle.Name = "lblMoviePosterExpertSingle"
        Me.lblMoviePosterExpertSingle.Size = New System.Drawing.Size(39, 13)
        Me.lblMoviePosterExpertSingle.TabIndex = 10
        Me.lblMoviePosterExpertSingle.Text = "Poster"
        '
        'txtMovieNFOExpertSingle
        '
        Me.txtMovieNFOExpertSingle.Enabled = false
        Me.txtMovieNFOExpertSingle.Location = New System.Drawing.Point(71, 6)
        Me.txtMovieNFOExpertSingle.Name = "txtMovieNFOExpertSingle"
        Me.txtMovieNFOExpertSingle.Size = New System.Drawing.Size(220, 22)
        Me.txtMovieNFOExpertSingle.TabIndex = 3
        '
        'lblMovieNFOExpertSingle
        '
        Me.lblMovieNFOExpertSingle.AutoSize = true
        Me.lblMovieNFOExpertSingle.Location = New System.Drawing.Point(6, 9)
        Me.lblMovieNFOExpertSingle.Name = "lblMovieNFOExpertSingle"
        Me.lblMovieNFOExpertSingle.Size = New System.Drawing.Size(30, 13)
        Me.lblMovieNFOExpertSingle.TabIndex = 9
        Me.lblMovieNFOExpertSingle.Text = "NFO"
        '
        'tpMovieFileNamingExpertMulti
        '
        Me.tpMovieFileNamingExpertMulti.Controls.Add(Me.gbMovieExpertMultiOptionalImages)
        Me.tpMovieFileNamingExpertMulti.Controls.Add(Me.gbMovieExpertMultiOptionalSettings)
        Me.tpMovieFileNamingExpertMulti.Controls.Add(Me.txtMoviePosterExpertMulti)
        Me.tpMovieFileNamingExpertMulti.Controls.Add(Me.txtMovieFanartExpertMulti)
        Me.tpMovieFileNamingExpertMulti.Controls.Add(Me.lblMovieClearArtExpertMulti)
        Me.tpMovieFileNamingExpertMulti.Controls.Add(Me.txtMovieTrailerExpertMulti)
        Me.tpMovieFileNamingExpertMulti.Controls.Add(Me.txtMovieBannerExpertMulti)
        Me.tpMovieFileNamingExpertMulti.Controls.Add(Me.txtMovieClearLogoExpertMulti)
        Me.tpMovieFileNamingExpertMulti.Controls.Add(Me.txtMovieClearArtExpertMulti)
        Me.tpMovieFileNamingExpertMulti.Controls.Add(Me.txtMovieLandscapeExpertMulti)
        Me.tpMovieFileNamingExpertMulti.Controls.Add(Me.txtMovieDiscArtExpertMulti)
        Me.tpMovieFileNamingExpertMulti.Controls.Add(Me.lblMovieLandscapeExpertMulti)
        Me.tpMovieFileNamingExpertMulti.Controls.Add(Me.lblMovieDiscArtExpertMulti)
        Me.tpMovieFileNamingExpertMulti.Controls.Add(Me.lblMovieBannerExpertMulti)
        Me.tpMovieFileNamingExpertMulti.Controls.Add(Me.lblMovieTrailerExpertMulti)
        Me.tpMovieFileNamingExpertMulti.Controls.Add(Me.lblMovieClearLogoExpertMulti)
        Me.tpMovieFileNamingExpertMulti.Controls.Add(Me.lblMovieFanartExpertMulti)
        Me.tpMovieFileNamingExpertMulti.Controls.Add(Me.lblMoviePosterExpertMulti)
        Me.tpMovieFileNamingExpertMulti.Controls.Add(Me.txtMovieNFOExpertMulti)
        Me.tpMovieFileNamingExpertMulti.Controls.Add(Me.lblMovieNFOExpertMulti)
        Me.tpMovieFileNamingExpertMulti.Location = New System.Drawing.Point(4, 22)
        Me.tpMovieFileNamingExpertMulti.Name = "tpMovieFileNamingExpertMulti"
        Me.tpMovieFileNamingExpertMulti.Padding = New System.Windows.Forms.Padding(3)
        Me.tpMovieFileNamingExpertMulti.Size = New System.Drawing.Size(473, 254)
        Me.tpMovieFileNamingExpertMulti.TabIndex = 1
        Me.tpMovieFileNamingExpertMulti.Text = "Multi"
        Me.tpMovieFileNamingExpertMulti.UseVisualStyleBackColor = true
        '
        'gbMovieExpertMultiOptionalImages
        '
        Me.gbMovieExpertMultiOptionalImages.Controls.Add(Me.txtMovieActorThumbsExtExpertMulti)
        Me.gbMovieExpertMultiOptionalImages.Controls.Add(Me.chkMovieActorThumbsExpertMulti)
        Me.gbMovieExpertMultiOptionalImages.Location = New System.Drawing.Point(307, 105)
        Me.gbMovieExpertMultiOptionalImages.Name = "gbMovieExpertMultiOptionalImages"
        Me.gbMovieExpertMultiOptionalImages.Size = New System.Drawing.Size(160, 52)
        Me.gbMovieExpertMultiOptionalImages.TabIndex = 11
        Me.gbMovieExpertMultiOptionalImages.TabStop = false
        Me.gbMovieExpertMultiOptionalImages.Text = "Optional Images"
        '
        'txtMovieActorThumbsExtExpertMulti
        '
        Me.txtMovieActorThumbsExtExpertMulti.Enabled = false
        Me.txtMovieActorThumbsExtExpertMulti.Location = New System.Drawing.Point(108, 19)
        Me.txtMovieActorThumbsExtExpertMulti.Name = "txtMovieActorThumbsExtExpertMulti"
        Me.txtMovieActorThumbsExtExpertMulti.Size = New System.Drawing.Size(46, 22)
        Me.txtMovieActorThumbsExtExpertMulti.TabIndex = 2
        '
        'chkMovieActorThumbsExpertMulti
        '
        Me.chkMovieActorThumbsExpertMulti.AutoSize = true
        Me.chkMovieActorThumbsExpertMulti.Enabled = false
        Me.chkMovieActorThumbsExpertMulti.Location = New System.Drawing.Point(6, 21)
        Me.chkMovieActorThumbsExpertMulti.Name = "chkMovieActorThumbsExpertMulti"
        Me.chkMovieActorThumbsExpertMulti.Size = New System.Drawing.Size(96, 17)
        Me.chkMovieActorThumbsExpertMulti.TabIndex = 1
        Me.chkMovieActorThumbsExpertMulti.Text = "Actor Thumbs"
        Me.chkMovieActorThumbsExpertMulti.UseVisualStyleBackColor = true
        '
        'gbMovieExpertMultiOptionalSettings
        '
        Me.gbMovieExpertMultiOptionalSettings.Controls.Add(Me.chkMovieUnstackExpertMulti)
        Me.gbMovieExpertMultiOptionalSettings.Controls.Add(Me.chkMovieStackExpertMulti)
        Me.gbMovieExpertMultiOptionalSettings.Controls.Add(Me.chkMovieXBMCTrailerFormatExpertMulti)
        Me.gbMovieExpertMultiOptionalSettings.Location = New System.Drawing.Point(307, 6)
        Me.gbMovieExpertMultiOptionalSettings.Name = "gbMovieExpertMultiOptionalSettings"
        Me.gbMovieExpertMultiOptionalSettings.Size = New System.Drawing.Size(160, 93)
        Me.gbMovieExpertMultiOptionalSettings.TabIndex = 10
        Me.gbMovieExpertMultiOptionalSettings.TabStop = false
        Me.gbMovieExpertMultiOptionalSettings.Text = "Optional Settings"
        '
        'chkMovieUnstackExpertMulti
        '
        Me.chkMovieUnstackExpertMulti.AutoSize = true
        Me.chkMovieUnstackExpertMulti.Enabled = false
        Me.chkMovieUnstackExpertMulti.Location = New System.Drawing.Point(6, 67)
        Me.chkMovieUnstackExpertMulti.Name = "chkMovieUnstackExpertMulti"
        Me.chkMovieUnstackExpertMulti.Size = New System.Drawing.Size(128, 17)
        Me.chkMovieUnstackExpertMulti.TabIndex = 3
        Me.chkMovieUnstackExpertMulti.Text = "also save unstacked"
        Me.chkMovieUnstackExpertMulti.UseVisualStyleBackColor = true
        '
        'chkMovieStackExpertMulti
        '
        Me.chkMovieStackExpertMulti.AutoSize = true
        Me.chkMovieStackExpertMulti.Enabled = false
        Me.chkMovieStackExpertMulti.Location = New System.Drawing.Point(6, 44)
        Me.chkMovieStackExpertMulti.Name = "chkMovieStackExpertMulti"
        Me.chkMovieStackExpertMulti.Size = New System.Drawing.Size(116, 17)
        Me.chkMovieStackExpertMulti.TabIndex = 2
        Me.chkMovieStackExpertMulti.Text = "Stack <filename>"
        Me.chkMovieStackExpertMulti.UseVisualStyleBackColor = true
        '
        'chkMovieXBMCTrailerFormatExpertMulti
        '
        Me.chkMovieXBMCTrailerFormatExpertMulti.AutoSize = true
        Me.chkMovieXBMCTrailerFormatExpertMulti.Enabled = false
        Me.chkMovieXBMCTrailerFormatExpertMulti.Location = New System.Drawing.Point(6, 21)
        Me.chkMovieXBMCTrailerFormatExpertMulti.Name = "chkMovieXBMCTrailerFormatExpertMulti"
        Me.chkMovieXBMCTrailerFormatExpertMulti.Size = New System.Drawing.Size(129, 17)
        Me.chkMovieXBMCTrailerFormatExpertMulti.TabIndex = 1
        Me.chkMovieXBMCTrailerFormatExpertMulti.Text = "XBMC Trailer Format"
        Me.chkMovieXBMCTrailerFormatExpertMulti.UseVisualStyleBackColor = true
        '
        'txtMoviePosterExpertMulti
        '
        Me.txtMoviePosterExpertMulti.Enabled = false
        Me.txtMoviePosterExpertMulti.Location = New System.Drawing.Point(71, 33)
        Me.txtMoviePosterExpertMulti.Name = "txtMoviePosterExpertMulti"
        Me.txtMoviePosterExpertMulti.Size = New System.Drawing.Size(220, 22)
        Me.txtMoviePosterExpertMulti.TabIndex = 2
        '
        'txtMovieFanartExpertMulti
        '
        Me.txtMovieFanartExpertMulti.Enabled = false
        Me.txtMovieFanartExpertMulti.Location = New System.Drawing.Point(71, 60)
        Me.txtMovieFanartExpertMulti.Name = "txtMovieFanartExpertMulti"
        Me.txtMovieFanartExpertMulti.Size = New System.Drawing.Size(220, 22)
        Me.txtMovieFanartExpertMulti.TabIndex = 3
        '
        'lblMovieClearArtExpertMulti
        '
        Me.lblMovieClearArtExpertMulti.AutoSize = true
        Me.lblMovieClearArtExpertMulti.Location = New System.Drawing.Point(6, 171)
        Me.lblMovieClearArtExpertMulti.Name = "lblMovieClearArtExpertMulti"
        Me.lblMovieClearArtExpertMulti.Size = New System.Drawing.Size(48, 13)
        Me.lblMovieClearArtExpertMulti.TabIndex = 51
        Me.lblMovieClearArtExpertMulti.Text = "ClearArt"
        '
        'txtMovieTrailerExpertMulti
        '
        Me.txtMovieTrailerExpertMulti.Enabled = false
        Me.txtMovieTrailerExpertMulti.Location = New System.Drawing.Point(71, 87)
        Me.txtMovieTrailerExpertMulti.Name = "txtMovieTrailerExpertMulti"
        Me.txtMovieTrailerExpertMulti.Size = New System.Drawing.Size(220, 22)
        Me.txtMovieTrailerExpertMulti.TabIndex = 4
        '
        'txtMovieBannerExpertMulti
        '
        Me.txtMovieBannerExpertMulti.Enabled = false
        Me.txtMovieBannerExpertMulti.Location = New System.Drawing.Point(71, 114)
        Me.txtMovieBannerExpertMulti.Name = "txtMovieBannerExpertMulti"
        Me.txtMovieBannerExpertMulti.Size = New System.Drawing.Size(220, 22)
        Me.txtMovieBannerExpertMulti.TabIndex = 5
        '
        'txtMovieClearLogoExpertMulti
        '
        Me.txtMovieClearLogoExpertMulti.Enabled = false
        Me.txtMovieClearLogoExpertMulti.Location = New System.Drawing.Point(71, 141)
        Me.txtMovieClearLogoExpertMulti.Name = "txtMovieClearLogoExpertMulti"
        Me.txtMovieClearLogoExpertMulti.Size = New System.Drawing.Size(220, 22)
        Me.txtMovieClearLogoExpertMulti.TabIndex = 6
        '
        'txtMovieClearArtExpertMulti
        '
        Me.txtMovieClearArtExpertMulti.Enabled = false
        Me.txtMovieClearArtExpertMulti.Location = New System.Drawing.Point(71, 168)
        Me.txtMovieClearArtExpertMulti.Name = "txtMovieClearArtExpertMulti"
        Me.txtMovieClearArtExpertMulti.Size = New System.Drawing.Size(220, 22)
        Me.txtMovieClearArtExpertMulti.TabIndex = 7
        '
        'txtMovieLandscapeExpertMulti
        '
        Me.txtMovieLandscapeExpertMulti.Enabled = false
        Me.txtMovieLandscapeExpertMulti.Location = New System.Drawing.Point(71, 222)
        Me.txtMovieLandscapeExpertMulti.Name = "txtMovieLandscapeExpertMulti"
        Me.txtMovieLandscapeExpertMulti.Size = New System.Drawing.Size(220, 22)
        Me.txtMovieLandscapeExpertMulti.TabIndex = 9
        '
        'txtMovieDiscArtExpertMulti
        '
        Me.txtMovieDiscArtExpertMulti.Enabled = false
        Me.txtMovieDiscArtExpertMulti.Location = New System.Drawing.Point(71, 195)
        Me.txtMovieDiscArtExpertMulti.Name = "txtMovieDiscArtExpertMulti"
        Me.txtMovieDiscArtExpertMulti.Size = New System.Drawing.Size(220, 22)
        Me.txtMovieDiscArtExpertMulti.TabIndex = 8
        '
        'lblMovieLandscapeExpertMulti
        '
        Me.lblMovieLandscapeExpertMulti.AutoSize = true
        Me.lblMovieLandscapeExpertMulti.Location = New System.Drawing.Point(6, 225)
        Me.lblMovieLandscapeExpertMulti.Name = "lblMovieLandscapeExpertMulti"
        Me.lblMovieLandscapeExpertMulti.Size = New System.Drawing.Size(61, 13)
        Me.lblMovieLandscapeExpertMulti.TabIndex = 42
        Me.lblMovieLandscapeExpertMulti.Text = "Landscape"
        '
        'lblMovieDiscArtExpertMulti
        '
        Me.lblMovieDiscArtExpertMulti.AutoSize = true
        Me.lblMovieDiscArtExpertMulti.Location = New System.Drawing.Point(6, 198)
        Me.lblMovieDiscArtExpertMulti.Name = "lblMovieDiscArtExpertMulti"
        Me.lblMovieDiscArtExpertMulti.Size = New System.Drawing.Size(43, 13)
        Me.lblMovieDiscArtExpertMulti.TabIndex = 41
        Me.lblMovieDiscArtExpertMulti.Text = "DiscArt"
        '
        'lblMovieBannerExpertMulti
        '
        Me.lblMovieBannerExpertMulti.AutoSize = true
        Me.lblMovieBannerExpertMulti.Location = New System.Drawing.Point(6, 117)
        Me.lblMovieBannerExpertMulti.Name = "lblMovieBannerExpertMulti"
        Me.lblMovieBannerExpertMulti.Size = New System.Drawing.Size(44, 13)
        Me.lblMovieBannerExpertMulti.TabIndex = 40
        Me.lblMovieBannerExpertMulti.Text = "Banner"
        '
        'lblMovieTrailerExpertMulti
        '
        Me.lblMovieTrailerExpertMulti.AutoSize = true
        Me.lblMovieTrailerExpertMulti.Location = New System.Drawing.Point(6, 90)
        Me.lblMovieTrailerExpertMulti.Name = "lblMovieTrailerExpertMulti"
        Me.lblMovieTrailerExpertMulti.Size = New System.Drawing.Size(38, 13)
        Me.lblMovieTrailerExpertMulti.TabIndex = 39
        Me.lblMovieTrailerExpertMulti.Text = "Trailer"
        '
        'lblMovieClearLogoExpertMulti
        '
        Me.lblMovieClearLogoExpertMulti.AutoSize = true
        Me.lblMovieClearLogoExpertMulti.Location = New System.Drawing.Point(6, 144)
        Me.lblMovieClearLogoExpertMulti.Name = "lblMovieClearLogoExpertMulti"
        Me.lblMovieClearLogoExpertMulti.Size = New System.Drawing.Size(59, 13)
        Me.lblMovieClearLogoExpertMulti.TabIndex = 38
        Me.lblMovieClearLogoExpertMulti.Text = "ClearLogo"
        '
        'lblMovieFanartExpertMulti
        '
        Me.lblMovieFanartExpertMulti.AutoSize = true
        Me.lblMovieFanartExpertMulti.Location = New System.Drawing.Point(6, 64)
        Me.lblMovieFanartExpertMulti.Name = "lblMovieFanartExpertMulti"
        Me.lblMovieFanartExpertMulti.Size = New System.Drawing.Size(40, 13)
        Me.lblMovieFanartExpertMulti.TabIndex = 37
        Me.lblMovieFanartExpertMulti.Text = "Fanart"
        '
        'lblMoviePosterExpertMulti
        '
        Me.lblMoviePosterExpertMulti.AutoSize = true
        Me.lblMoviePosterExpertMulti.Location = New System.Drawing.Point(6, 36)
        Me.lblMoviePosterExpertMulti.Name = "lblMoviePosterExpertMulti"
        Me.lblMoviePosterExpertMulti.Size = New System.Drawing.Size(39, 13)
        Me.lblMoviePosterExpertMulti.TabIndex = 36
        Me.lblMoviePosterExpertMulti.Text = "Poster"
        '
        'txtMovieNFOExpertMulti
        '
        Me.txtMovieNFOExpertMulti.Enabled = false
        Me.txtMovieNFOExpertMulti.Location = New System.Drawing.Point(71, 6)
        Me.txtMovieNFOExpertMulti.Name = "txtMovieNFOExpertMulti"
        Me.txtMovieNFOExpertMulti.Size = New System.Drawing.Size(220, 22)
        Me.txtMovieNFOExpertMulti.TabIndex = 1
        '
        'lblMovieNFOExpertMulti
        '
        Me.lblMovieNFOExpertMulti.AutoSize = true
        Me.lblMovieNFOExpertMulti.Location = New System.Drawing.Point(6, 9)
        Me.lblMovieNFOExpertMulti.Name = "lblMovieNFOExpertMulti"
        Me.lblMovieNFOExpertMulti.Size = New System.Drawing.Size(30, 13)
        Me.lblMovieNFOExpertMulti.TabIndex = 35
        Me.lblMovieNFOExpertMulti.Text = "NFO"
        '
        'tpMovieFileNamingExpertVTS
        '
        Me.tpMovieFileNamingExpertVTS.Controls.Add(Me.gbMovieExpertVTSOptionalSettings)
        Me.tpMovieFileNamingExpertVTS.Controls.Add(Me.gbMovieExpertVTSOptionalImages)
        Me.tpMovieFileNamingExpertVTS.Controls.Add(Me.lblMovieClearArtExpertVTS)
        Me.tpMovieFileNamingExpertVTS.Controls.Add(Me.txtMoviePosterExpertVTS)
        Me.tpMovieFileNamingExpertVTS.Controls.Add(Me.txtMovieFanartExpertVTS)
        Me.tpMovieFileNamingExpertVTS.Controls.Add(Me.txtMovieTrailerExpertVTS)
        Me.tpMovieFileNamingExpertVTS.Controls.Add(Me.txtMovieBannerExpertVTS)
        Me.tpMovieFileNamingExpertVTS.Controls.Add(Me.txtMovieClearLogoExpertVTS)
        Me.tpMovieFileNamingExpertVTS.Controls.Add(Me.txtMovieClearArtExpertVTS)
        Me.tpMovieFileNamingExpertVTS.Controls.Add(Me.txtMovieLandscapeExpertVTS)
        Me.tpMovieFileNamingExpertVTS.Controls.Add(Me.txtMovieDiscArtExpertVTS)
        Me.tpMovieFileNamingExpertVTS.Controls.Add(Me.lblMovieLandscapeExpertVTS)
        Me.tpMovieFileNamingExpertVTS.Controls.Add(Me.lblMovieDiscArtExpertVTS)
        Me.tpMovieFileNamingExpertVTS.Controls.Add(Me.lblMovieBannerExpertVTS)
        Me.tpMovieFileNamingExpertVTS.Controls.Add(Me.lblMovieTrailerExpertVTS)
        Me.tpMovieFileNamingExpertVTS.Controls.Add(Me.lblMovieClearLogoExpertVTS)
        Me.tpMovieFileNamingExpertVTS.Controls.Add(Me.lblMovieFanartExpertVTS)
        Me.tpMovieFileNamingExpertVTS.Controls.Add(Me.lblMoviePosterExpertVTS)
        Me.tpMovieFileNamingExpertVTS.Controls.Add(Me.txtMovieNFOExpertVTS)
        Me.tpMovieFileNamingExpertVTS.Controls.Add(Me.lblMovieNFOExpertVTS)
        Me.tpMovieFileNamingExpertVTS.Location = New System.Drawing.Point(4, 22)
        Me.tpMovieFileNamingExpertVTS.Name = "tpMovieFileNamingExpertVTS"
        Me.tpMovieFileNamingExpertVTS.Size = New System.Drawing.Size(473, 254)
        Me.tpMovieFileNamingExpertVTS.TabIndex = 2
        Me.tpMovieFileNamingExpertVTS.Text = "VIDEO_TS"
        Me.tpMovieFileNamingExpertVTS.UseVisualStyleBackColor = true
        '
        'gbMovieExpertVTSOptionalSettings
        '
        Me.gbMovieExpertVTSOptionalSettings.Controls.Add(Me.chkMovieRecognizeVTSExpertVTS)
        Me.gbMovieExpertVTSOptionalSettings.Controls.Add(Me.chkMovieUseBaseDirectoryExpertVTS)
        Me.gbMovieExpertVTSOptionalSettings.Controls.Add(Me.chkMovieXBMCTrailerFormatExpertVTS)
        Me.gbMovieExpertVTSOptionalSettings.Location = New System.Drawing.Point(307, 6)
        Me.gbMovieExpertVTSOptionalSettings.Name = "gbMovieExpertVTSOptionalSettings"
        Me.gbMovieExpertVTSOptionalSettings.Size = New System.Drawing.Size(160, 93)
        Me.gbMovieExpertVTSOptionalSettings.TabIndex = 10
        Me.gbMovieExpertVTSOptionalSettings.TabStop = false
        Me.gbMovieExpertVTSOptionalSettings.Text = "Optional Settings"
        '
        'chkMovieRecognizeVTSExpertVTS
        '
        Me.chkMovieRecognizeVTSExpertVTS.AutoSize = true
        Me.chkMovieRecognizeVTSExpertVTS.Enabled = false
        Me.chkMovieRecognizeVTSExpertVTS.Location = New System.Drawing.Point(6, 67)
        Me.chkMovieRecognizeVTSExpertVTS.Name = "chkMovieRecognizeVTSExpertVTS"
        Me.chkMovieRecognizeVTSExpertVTS.Size = New System.Drawing.Size(131, 17)
        Me.chkMovieRecognizeVTSExpertVTS.TabIndex = 3
        Me.chkMovieRecognizeVTSExpertVTS.Text = "Recognize VIDEO_TS"
        Me.chkMovieRecognizeVTSExpertVTS.UseVisualStyleBackColor = true
        '
        'chkMovieUseBaseDirectoryExpertVTS
        '
        Me.chkMovieUseBaseDirectoryExpertVTS.AutoSize = true
        Me.chkMovieUseBaseDirectoryExpertVTS.Enabled = false
        Me.chkMovieUseBaseDirectoryExpertVTS.Location = New System.Drawing.Point(6, 44)
        Me.chkMovieUseBaseDirectoryExpertVTS.Name = "chkMovieUseBaseDirectoryExpertVTS"
        Me.chkMovieUseBaseDirectoryExpertVTS.Size = New System.Drawing.Size(121, 17)
        Me.chkMovieUseBaseDirectoryExpertVTS.TabIndex = 2
        Me.chkMovieUseBaseDirectoryExpertVTS.Text = "Use Base Directory"
        Me.chkMovieUseBaseDirectoryExpertVTS.UseVisualStyleBackColor = true
        '
        'chkMovieXBMCTrailerFormatExpertVTS
        '
        Me.chkMovieXBMCTrailerFormatExpertVTS.AutoSize = true
        Me.chkMovieXBMCTrailerFormatExpertVTS.Enabled = false
        Me.chkMovieXBMCTrailerFormatExpertVTS.Location = New System.Drawing.Point(6, 21)
        Me.chkMovieXBMCTrailerFormatExpertVTS.Name = "chkMovieXBMCTrailerFormatExpertVTS"
        Me.chkMovieXBMCTrailerFormatExpertVTS.Size = New System.Drawing.Size(129, 17)
        Me.chkMovieXBMCTrailerFormatExpertVTS.TabIndex = 1
        Me.chkMovieXBMCTrailerFormatExpertVTS.Text = "XBMC Trailer Format"
        Me.chkMovieXBMCTrailerFormatExpertVTS.UseVisualStyleBackColor = true
        '
        'gbMovieExpertVTSOptionalImages
        '
        Me.gbMovieExpertVTSOptionalImages.Controls.Add(Me.txtMovieActorThumbsExtExpertVTS)
        Me.gbMovieExpertVTSOptionalImages.Controls.Add(Me.chkMovieActorThumbsExpertVTS)
        Me.gbMovieExpertVTSOptionalImages.Controls.Add(Me.chkMovieExtrafanartsExpertVTS)
        Me.gbMovieExpertVTSOptionalImages.Controls.Add(Me.chkMovieExtrathumbsExpertVTS)
        Me.gbMovieExpertVTSOptionalImages.Location = New System.Drawing.Point(307, 105)
        Me.gbMovieExpertVTSOptionalImages.Name = "gbMovieExpertVTSOptionalImages"
        Me.gbMovieExpertVTSOptionalImages.Size = New System.Drawing.Size(160, 93)
        Me.gbMovieExpertVTSOptionalImages.TabIndex = 11
        Me.gbMovieExpertVTSOptionalImages.TabStop = false
        Me.gbMovieExpertVTSOptionalImages.Text = "Optional Images"
        '
        'txtMovieActorThumbsExtExpertVTS
        '
        Me.txtMovieActorThumbsExtExpertVTS.Enabled = false
        Me.txtMovieActorThumbsExtExpertVTS.Location = New System.Drawing.Point(108, 19)
        Me.txtMovieActorThumbsExtExpertVTS.Name = "txtMovieActorThumbsExtExpertVTS"
        Me.txtMovieActorThumbsExtExpertVTS.Size = New System.Drawing.Size(46, 22)
        Me.txtMovieActorThumbsExtExpertVTS.TabIndex = 2
        '
        'chkMovieActorThumbsExpertVTS
        '
        Me.chkMovieActorThumbsExpertVTS.AutoSize = true
        Me.chkMovieActorThumbsExpertVTS.Enabled = false
        Me.chkMovieActorThumbsExpertVTS.Location = New System.Drawing.Point(6, 21)
        Me.chkMovieActorThumbsExpertVTS.Name = "chkMovieActorThumbsExpertVTS"
        Me.chkMovieActorThumbsExpertVTS.Size = New System.Drawing.Size(96, 17)
        Me.chkMovieActorThumbsExpertVTS.TabIndex = 1
        Me.chkMovieActorThumbsExpertVTS.Text = "Actor Thumbs"
        Me.chkMovieActorThumbsExpertVTS.UseVisualStyleBackColor = true
        '
        'chkMovieExtrafanartsExpertVTS
        '
        Me.chkMovieExtrafanartsExpertVTS.AutoSize = true
        Me.chkMovieExtrafanartsExpertVTS.Enabled = false
        Me.chkMovieExtrafanartsExpertVTS.Location = New System.Drawing.Point(6, 67)
        Me.chkMovieExtrafanartsExpertVTS.Name = "chkMovieExtrafanartsExpertVTS"
        Me.chkMovieExtrafanartsExpertVTS.Size = New System.Drawing.Size(87, 17)
        Me.chkMovieExtrafanartsExpertVTS.TabIndex = 4
        Me.chkMovieExtrafanartsExpertVTS.Text = "Extrafanarts"
        Me.chkMovieExtrafanartsExpertVTS.UseVisualStyleBackColor = true
        '
        'chkMovieExtrathumbsExpertVTS
        '
        Me.chkMovieExtrathumbsExpertVTS.AutoSize = true
        Me.chkMovieExtrathumbsExpertVTS.Enabled = false
        Me.chkMovieExtrathumbsExpertVTS.Location = New System.Drawing.Point(6, 44)
        Me.chkMovieExtrathumbsExpertVTS.Name = "chkMovieExtrathumbsExpertVTS"
        Me.chkMovieExtrathumbsExpertVTS.Size = New System.Drawing.Size(90, 17)
        Me.chkMovieExtrathumbsExpertVTS.TabIndex = 3
        Me.chkMovieExtrathumbsExpertVTS.Text = "Extrathumbs"
        Me.chkMovieExtrathumbsExpertVTS.UseVisualStyleBackColor = true
        '
        'lblMovieClearArtExpertVTS
        '
        Me.lblMovieClearArtExpertVTS.AutoSize = true
        Me.lblMovieClearArtExpertVTS.Location = New System.Drawing.Point(6, 171)
        Me.lblMovieClearArtExpertVTS.Name = "lblMovieClearArtExpertVTS"
        Me.lblMovieClearArtExpertVTS.Size = New System.Drawing.Size(48, 13)
        Me.lblMovieClearArtExpertVTS.TabIndex = 51
        Me.lblMovieClearArtExpertVTS.Text = "ClearArt"
        '
        'txtMoviePosterExpertVTS
        '
        Me.txtMoviePosterExpertVTS.Enabled = false
        Me.txtMoviePosterExpertVTS.Location = New System.Drawing.Point(71, 33)
        Me.txtMoviePosterExpertVTS.Name = "txtMoviePosterExpertVTS"
        Me.txtMoviePosterExpertVTS.Size = New System.Drawing.Size(220, 22)
        Me.txtMoviePosterExpertVTS.TabIndex = 2
        '
        'txtMovieFanartExpertVTS
        '
        Me.txtMovieFanartExpertVTS.Enabled = false
        Me.txtMovieFanartExpertVTS.Location = New System.Drawing.Point(71, 60)
        Me.txtMovieFanartExpertVTS.Name = "txtMovieFanartExpertVTS"
        Me.txtMovieFanartExpertVTS.Size = New System.Drawing.Size(220, 22)
        Me.txtMovieFanartExpertVTS.TabIndex = 3
        '
        'txtMovieTrailerExpertVTS
        '
        Me.txtMovieTrailerExpertVTS.Enabled = false
        Me.txtMovieTrailerExpertVTS.Location = New System.Drawing.Point(71, 87)
        Me.txtMovieTrailerExpertVTS.Name = "txtMovieTrailerExpertVTS"
        Me.txtMovieTrailerExpertVTS.Size = New System.Drawing.Size(220, 22)
        Me.txtMovieTrailerExpertVTS.TabIndex = 4
        '
        'txtMovieBannerExpertVTS
        '
        Me.txtMovieBannerExpertVTS.Enabled = false
        Me.txtMovieBannerExpertVTS.Location = New System.Drawing.Point(71, 114)
        Me.txtMovieBannerExpertVTS.Name = "txtMovieBannerExpertVTS"
        Me.txtMovieBannerExpertVTS.Size = New System.Drawing.Size(220, 22)
        Me.txtMovieBannerExpertVTS.TabIndex = 5
        '
        'txtMovieClearLogoExpertVTS
        '
        Me.txtMovieClearLogoExpertVTS.Enabled = false
        Me.txtMovieClearLogoExpertVTS.Location = New System.Drawing.Point(71, 141)
        Me.txtMovieClearLogoExpertVTS.Name = "txtMovieClearLogoExpertVTS"
        Me.txtMovieClearLogoExpertVTS.Size = New System.Drawing.Size(220, 22)
        Me.txtMovieClearLogoExpertVTS.TabIndex = 6
        '
        'txtMovieClearArtExpertVTS
        '
        Me.txtMovieClearArtExpertVTS.Enabled = false
        Me.txtMovieClearArtExpertVTS.Location = New System.Drawing.Point(71, 168)
        Me.txtMovieClearArtExpertVTS.Name = "txtMovieClearArtExpertVTS"
        Me.txtMovieClearArtExpertVTS.Size = New System.Drawing.Size(220, 22)
        Me.txtMovieClearArtExpertVTS.TabIndex = 7
        '
        'txtMovieLandscapeExpertVTS
        '
        Me.txtMovieLandscapeExpertVTS.Enabled = false
        Me.txtMovieLandscapeExpertVTS.Location = New System.Drawing.Point(71, 222)
        Me.txtMovieLandscapeExpertVTS.Name = "txtMovieLandscapeExpertVTS"
        Me.txtMovieLandscapeExpertVTS.Size = New System.Drawing.Size(220, 22)
        Me.txtMovieLandscapeExpertVTS.TabIndex = 9
        '
        'txtMovieDiscArtExpertVTS
        '
        Me.txtMovieDiscArtExpertVTS.Enabled = false
        Me.txtMovieDiscArtExpertVTS.Location = New System.Drawing.Point(71, 195)
        Me.txtMovieDiscArtExpertVTS.Name = "txtMovieDiscArtExpertVTS"
        Me.txtMovieDiscArtExpertVTS.Size = New System.Drawing.Size(220, 22)
        Me.txtMovieDiscArtExpertVTS.TabIndex = 8
        '
        'lblMovieLandscapeExpertVTS
        '
        Me.lblMovieLandscapeExpertVTS.AutoSize = true
        Me.lblMovieLandscapeExpertVTS.Location = New System.Drawing.Point(6, 225)
        Me.lblMovieLandscapeExpertVTS.Name = "lblMovieLandscapeExpertVTS"
        Me.lblMovieLandscapeExpertVTS.Size = New System.Drawing.Size(61, 13)
        Me.lblMovieLandscapeExpertVTS.TabIndex = 42
        Me.lblMovieLandscapeExpertVTS.Text = "Landscape"
        '
        'lblMovieDiscArtExpertVTS
        '
        Me.lblMovieDiscArtExpertVTS.AutoSize = true
        Me.lblMovieDiscArtExpertVTS.Location = New System.Drawing.Point(6, 198)
        Me.lblMovieDiscArtExpertVTS.Name = "lblMovieDiscArtExpertVTS"
        Me.lblMovieDiscArtExpertVTS.Size = New System.Drawing.Size(43, 13)
        Me.lblMovieDiscArtExpertVTS.TabIndex = 41
        Me.lblMovieDiscArtExpertVTS.Text = "DiscArt"
        '
        'lblMovieBannerExpertVTS
        '
        Me.lblMovieBannerExpertVTS.AutoSize = true
        Me.lblMovieBannerExpertVTS.Location = New System.Drawing.Point(6, 117)
        Me.lblMovieBannerExpertVTS.Name = "lblMovieBannerExpertVTS"
        Me.lblMovieBannerExpertVTS.Size = New System.Drawing.Size(44, 13)
        Me.lblMovieBannerExpertVTS.TabIndex = 40
        Me.lblMovieBannerExpertVTS.Text = "Banner"
        '
        'lblMovieTrailerExpertVTS
        '
        Me.lblMovieTrailerExpertVTS.AutoSize = true
        Me.lblMovieTrailerExpertVTS.Location = New System.Drawing.Point(6, 90)
        Me.lblMovieTrailerExpertVTS.Name = "lblMovieTrailerExpertVTS"
        Me.lblMovieTrailerExpertVTS.Size = New System.Drawing.Size(38, 13)
        Me.lblMovieTrailerExpertVTS.TabIndex = 39
        Me.lblMovieTrailerExpertVTS.Text = "Trailer"
        '
        'lblMovieClearLogoExpertVTS
        '
        Me.lblMovieClearLogoExpertVTS.AutoSize = true
        Me.lblMovieClearLogoExpertVTS.Location = New System.Drawing.Point(6, 144)
        Me.lblMovieClearLogoExpertVTS.Name = "lblMovieClearLogoExpertVTS"
        Me.lblMovieClearLogoExpertVTS.Size = New System.Drawing.Size(59, 13)
        Me.lblMovieClearLogoExpertVTS.TabIndex = 38
        Me.lblMovieClearLogoExpertVTS.Text = "ClearLogo"
        '
        'lblMovieFanartExpertVTS
        '
        Me.lblMovieFanartExpertVTS.AutoSize = true
        Me.lblMovieFanartExpertVTS.Location = New System.Drawing.Point(6, 64)
        Me.lblMovieFanartExpertVTS.Name = "lblMovieFanartExpertVTS"
        Me.lblMovieFanartExpertVTS.Size = New System.Drawing.Size(40, 13)
        Me.lblMovieFanartExpertVTS.TabIndex = 37
        Me.lblMovieFanartExpertVTS.Text = "Fanart"
        '
        'lblMoviePosterExpertVTS
        '
        Me.lblMoviePosterExpertVTS.AutoSize = true
        Me.lblMoviePosterExpertVTS.Location = New System.Drawing.Point(6, 36)
        Me.lblMoviePosterExpertVTS.Name = "lblMoviePosterExpertVTS"
        Me.lblMoviePosterExpertVTS.Size = New System.Drawing.Size(39, 13)
        Me.lblMoviePosterExpertVTS.TabIndex = 36
        Me.lblMoviePosterExpertVTS.Text = "Poster"
        '
        'txtMovieNFOExpertVTS
        '
        Me.txtMovieNFOExpertVTS.Enabled = false
        Me.txtMovieNFOExpertVTS.Location = New System.Drawing.Point(71, 6)
        Me.txtMovieNFOExpertVTS.Name = "txtMovieNFOExpertVTS"
        Me.txtMovieNFOExpertVTS.Size = New System.Drawing.Size(220, 22)
        Me.txtMovieNFOExpertVTS.TabIndex = 1
        '
        'lblMovieNFOExpertVTS
        '
        Me.lblMovieNFOExpertVTS.AutoSize = true
        Me.lblMovieNFOExpertVTS.Location = New System.Drawing.Point(6, 9)
        Me.lblMovieNFOExpertVTS.Name = "lblMovieNFOExpertVTS"
        Me.lblMovieNFOExpertVTS.Size = New System.Drawing.Size(30, 13)
        Me.lblMovieNFOExpertVTS.TabIndex = 35
        Me.lblMovieNFOExpertVTS.Text = "NFO"
        '
        'tpMovieFileNamingExpertBDMV
        '
        Me.tpMovieFileNamingExpertBDMV.Controls.Add(Me.gbMovieExpertBDMVOptionalSettings)
        Me.tpMovieFileNamingExpertBDMV.Controls.Add(Me.gbMovieExpertBDMVOptionalImages)
        Me.tpMovieFileNamingExpertBDMV.Controls.Add(Me.lblMovieClearArtExpertBDMV)
        Me.tpMovieFileNamingExpertBDMV.Controls.Add(Me.txtMoviePosterExpertBDMV)
        Me.tpMovieFileNamingExpertBDMV.Controls.Add(Me.txtMovieFanartExpertBDMV)
        Me.tpMovieFileNamingExpertBDMV.Controls.Add(Me.txtMovieTrailerExpertBDMV)
        Me.tpMovieFileNamingExpertBDMV.Controls.Add(Me.txtMovieBannerExpertBDMV)
        Me.tpMovieFileNamingExpertBDMV.Controls.Add(Me.txtMovieClearLogoExpertBDMV)
        Me.tpMovieFileNamingExpertBDMV.Controls.Add(Me.txtMovieClearArtExpertBDMV)
        Me.tpMovieFileNamingExpertBDMV.Controls.Add(Me.txtMovieLandscapeExpertBDMV)
        Me.tpMovieFileNamingExpertBDMV.Controls.Add(Me.txtMovieDiscArtExpertBDMV)
        Me.tpMovieFileNamingExpertBDMV.Controls.Add(Me.lblMovieLandscapeExpertBDMV)
        Me.tpMovieFileNamingExpertBDMV.Controls.Add(Me.lblMovieDiscArtExpertBDMV)
        Me.tpMovieFileNamingExpertBDMV.Controls.Add(Me.lblMovieBannerExpertBDMV)
        Me.tpMovieFileNamingExpertBDMV.Controls.Add(Me.lblMovieTrailerExpertBDMV)
        Me.tpMovieFileNamingExpertBDMV.Controls.Add(Me.lblMovieClearLogoExpertBDMV)
        Me.tpMovieFileNamingExpertBDMV.Controls.Add(Me.lblMovieFanartExpertBDMV)
        Me.tpMovieFileNamingExpertBDMV.Controls.Add(Me.lblMoviePosterExpertBDMV)
        Me.tpMovieFileNamingExpertBDMV.Controls.Add(Me.txtMovieNFOExpertBDMV)
        Me.tpMovieFileNamingExpertBDMV.Controls.Add(Me.lblMovieNFOExpertBDMV)
        Me.tpMovieFileNamingExpertBDMV.Location = New System.Drawing.Point(4, 22)
        Me.tpMovieFileNamingExpertBDMV.Name = "tpMovieFileNamingExpertBDMV"
        Me.tpMovieFileNamingExpertBDMV.Size = New System.Drawing.Size(473, 254)
        Me.tpMovieFileNamingExpertBDMV.TabIndex = 3
        Me.tpMovieFileNamingExpertBDMV.Text = "BDMV"
        Me.tpMovieFileNamingExpertBDMV.UseVisualStyleBackColor = true
        '
        'gbMovieExpertBDMVOptionalSettings
        '
        Me.gbMovieExpertBDMVOptionalSettings.Controls.Add(Me.chkMovieUseBaseDirectoryExpertBDMV)
        Me.gbMovieExpertBDMVOptionalSettings.Controls.Add(Me.chkMovieXBMCTrailerFormatExpertBDMV)
        Me.gbMovieExpertBDMVOptionalSettings.Location = New System.Drawing.Point(307, 6)
        Me.gbMovieExpertBDMVOptionalSettings.Name = "gbMovieExpertBDMVOptionalSettings"
        Me.gbMovieExpertBDMVOptionalSettings.Size = New System.Drawing.Size(160, 71)
        Me.gbMovieExpertBDMVOptionalSettings.TabIndex = 10
        Me.gbMovieExpertBDMVOptionalSettings.TabStop = false
        Me.gbMovieExpertBDMVOptionalSettings.Text = "Optional Settings"
        '
        'chkMovieUseBaseDirectoryExpertBDMV
        '
        Me.chkMovieUseBaseDirectoryExpertBDMV.AutoSize = true
        Me.chkMovieUseBaseDirectoryExpertBDMV.Enabled = false
        Me.chkMovieUseBaseDirectoryExpertBDMV.Location = New System.Drawing.Point(6, 44)
        Me.chkMovieUseBaseDirectoryExpertBDMV.Name = "chkMovieUseBaseDirectoryExpertBDMV"
        Me.chkMovieUseBaseDirectoryExpertBDMV.Size = New System.Drawing.Size(121, 17)
        Me.chkMovieUseBaseDirectoryExpertBDMV.TabIndex = 2
        Me.chkMovieUseBaseDirectoryExpertBDMV.Text = "Use Base Directory"
        Me.chkMovieUseBaseDirectoryExpertBDMV.UseVisualStyleBackColor = true
        '
        'chkMovieXBMCTrailerFormatExpertBDMV
        '
        Me.chkMovieXBMCTrailerFormatExpertBDMV.AutoSize = true
        Me.chkMovieXBMCTrailerFormatExpertBDMV.Enabled = false
        Me.chkMovieXBMCTrailerFormatExpertBDMV.Location = New System.Drawing.Point(6, 21)
        Me.chkMovieXBMCTrailerFormatExpertBDMV.Name = "chkMovieXBMCTrailerFormatExpertBDMV"
        Me.chkMovieXBMCTrailerFormatExpertBDMV.Size = New System.Drawing.Size(129, 17)
        Me.chkMovieXBMCTrailerFormatExpertBDMV.TabIndex = 1
        Me.chkMovieXBMCTrailerFormatExpertBDMV.Text = "XBMC Trailer Format"
        Me.chkMovieXBMCTrailerFormatExpertBDMV.UseVisualStyleBackColor = true
        '
        'gbMovieExpertBDMVOptionalImages
        '
        Me.gbMovieExpertBDMVOptionalImages.Controls.Add(Me.txtMovieActorThumbsExtExpertBDMV)
        Me.gbMovieExpertBDMVOptionalImages.Controls.Add(Me.chkMovieActorThumbsExpertBDMV)
        Me.gbMovieExpertBDMVOptionalImages.Controls.Add(Me.chkMovieExtrafanartsExpertBDMV)
        Me.gbMovieExpertBDMVOptionalImages.Controls.Add(Me.chkMovieExtrathumbsExpertBDMV)
        Me.gbMovieExpertBDMVOptionalImages.Location = New System.Drawing.Point(307, 105)
        Me.gbMovieExpertBDMVOptionalImages.Name = "gbMovieExpertBDMVOptionalImages"
        Me.gbMovieExpertBDMVOptionalImages.Size = New System.Drawing.Size(160, 93)
        Me.gbMovieExpertBDMVOptionalImages.TabIndex = 1
        Me.gbMovieExpertBDMVOptionalImages.TabStop = false
        Me.gbMovieExpertBDMVOptionalImages.Text = "Optional Images"
        '
        'txtMovieActorThumbsExtExpertBDMV
        '
        Me.txtMovieActorThumbsExtExpertBDMV.Enabled = false
        Me.txtMovieActorThumbsExtExpertBDMV.Location = New System.Drawing.Point(108, 19)
        Me.txtMovieActorThumbsExtExpertBDMV.Name = "txtMovieActorThumbsExtExpertBDMV"
        Me.txtMovieActorThumbsExtExpertBDMV.Size = New System.Drawing.Size(46, 22)
        Me.txtMovieActorThumbsExtExpertBDMV.TabIndex = 2
        '
        'chkMovieActorThumbsExpertBDMV
        '
        Me.chkMovieActorThumbsExpertBDMV.AutoSize = true
        Me.chkMovieActorThumbsExpertBDMV.Enabled = false
        Me.chkMovieActorThumbsExpertBDMV.Location = New System.Drawing.Point(6, 21)
        Me.chkMovieActorThumbsExpertBDMV.Name = "chkMovieActorThumbsExpertBDMV"
        Me.chkMovieActorThumbsExpertBDMV.Size = New System.Drawing.Size(96, 17)
        Me.chkMovieActorThumbsExpertBDMV.TabIndex = 1
        Me.chkMovieActorThumbsExpertBDMV.Text = "Actor Thumbs"
        Me.chkMovieActorThumbsExpertBDMV.UseVisualStyleBackColor = true
        '
        'chkMovieExtrafanartsExpertBDMV
        '
        Me.chkMovieExtrafanartsExpertBDMV.AutoSize = true
        Me.chkMovieExtrafanartsExpertBDMV.Enabled = false
        Me.chkMovieExtrafanartsExpertBDMV.Location = New System.Drawing.Point(6, 67)
        Me.chkMovieExtrafanartsExpertBDMV.Name = "chkMovieExtrafanartsExpertBDMV"
        Me.chkMovieExtrafanartsExpertBDMV.Size = New System.Drawing.Size(87, 17)
        Me.chkMovieExtrafanartsExpertBDMV.TabIndex = 4
        Me.chkMovieExtrafanartsExpertBDMV.Text = "Extrafanarts"
        Me.chkMovieExtrafanartsExpertBDMV.UseVisualStyleBackColor = true
        '
        'chkMovieExtrathumbsExpertBDMV
        '
        Me.chkMovieExtrathumbsExpertBDMV.AutoSize = true
        Me.chkMovieExtrathumbsExpertBDMV.Enabled = false
        Me.chkMovieExtrathumbsExpertBDMV.Location = New System.Drawing.Point(6, 44)
        Me.chkMovieExtrathumbsExpertBDMV.Name = "chkMovieExtrathumbsExpertBDMV"
        Me.chkMovieExtrathumbsExpertBDMV.Size = New System.Drawing.Size(90, 17)
        Me.chkMovieExtrathumbsExpertBDMV.TabIndex = 3
        Me.chkMovieExtrathumbsExpertBDMV.Text = "Extrathumbs"
        Me.chkMovieExtrathumbsExpertBDMV.UseVisualStyleBackColor = true
        '
        'lblMovieClearArtExpertBDMV
        '
        Me.lblMovieClearArtExpertBDMV.AutoSize = true
        Me.lblMovieClearArtExpertBDMV.Location = New System.Drawing.Point(6, 171)
        Me.lblMovieClearArtExpertBDMV.Name = "lblMovieClearArtExpertBDMV"
        Me.lblMovieClearArtExpertBDMV.Size = New System.Drawing.Size(48, 13)
        Me.lblMovieClearArtExpertBDMV.TabIndex = 51
        Me.lblMovieClearArtExpertBDMV.Text = "ClearArt"
        '
        'txtMoviePosterExpertBDMV
        '
        Me.txtMoviePosterExpertBDMV.Enabled = false
        Me.txtMoviePosterExpertBDMV.Location = New System.Drawing.Point(71, 33)
        Me.txtMoviePosterExpertBDMV.Name = "txtMoviePosterExpertBDMV"
        Me.txtMoviePosterExpertBDMV.Size = New System.Drawing.Size(220, 22)
        Me.txtMoviePosterExpertBDMV.TabIndex = 2
        '
        'txtMovieFanartExpertBDMV
        '
        Me.txtMovieFanartExpertBDMV.Enabled = false
        Me.txtMovieFanartExpertBDMV.Location = New System.Drawing.Point(71, 60)
        Me.txtMovieFanartExpertBDMV.Name = "txtMovieFanartExpertBDMV"
        Me.txtMovieFanartExpertBDMV.Size = New System.Drawing.Size(220, 22)
        Me.txtMovieFanartExpertBDMV.TabIndex = 3
        '
        'txtMovieTrailerExpertBDMV
        '
        Me.txtMovieTrailerExpertBDMV.Enabled = false
        Me.txtMovieTrailerExpertBDMV.Location = New System.Drawing.Point(71, 87)
        Me.txtMovieTrailerExpertBDMV.Name = "txtMovieTrailerExpertBDMV"
        Me.txtMovieTrailerExpertBDMV.Size = New System.Drawing.Size(220, 22)
        Me.txtMovieTrailerExpertBDMV.TabIndex = 4
        '
        'txtMovieBannerExpertBDMV
        '
        Me.txtMovieBannerExpertBDMV.Enabled = false
        Me.txtMovieBannerExpertBDMV.Location = New System.Drawing.Point(71, 114)
        Me.txtMovieBannerExpertBDMV.Name = "txtMovieBannerExpertBDMV"
        Me.txtMovieBannerExpertBDMV.Size = New System.Drawing.Size(220, 22)
        Me.txtMovieBannerExpertBDMV.TabIndex = 5
        '
        'txtMovieClearLogoExpertBDMV
        '
        Me.txtMovieClearLogoExpertBDMV.Enabled = false
        Me.txtMovieClearLogoExpertBDMV.Location = New System.Drawing.Point(71, 141)
        Me.txtMovieClearLogoExpertBDMV.Name = "txtMovieClearLogoExpertBDMV"
        Me.txtMovieClearLogoExpertBDMV.Size = New System.Drawing.Size(220, 22)
        Me.txtMovieClearLogoExpertBDMV.TabIndex = 6
        '
        'txtMovieClearArtExpertBDMV
        '
        Me.txtMovieClearArtExpertBDMV.Enabled = false
        Me.txtMovieClearArtExpertBDMV.Location = New System.Drawing.Point(71, 168)
        Me.txtMovieClearArtExpertBDMV.Name = "txtMovieClearArtExpertBDMV"
        Me.txtMovieClearArtExpertBDMV.Size = New System.Drawing.Size(220, 22)
        Me.txtMovieClearArtExpertBDMV.TabIndex = 7
        '
        'txtMovieLandscapeExpertBDMV
        '
        Me.txtMovieLandscapeExpertBDMV.Enabled = false
        Me.txtMovieLandscapeExpertBDMV.Location = New System.Drawing.Point(71, 222)
        Me.txtMovieLandscapeExpertBDMV.Name = "txtMovieLandscapeExpertBDMV"
        Me.txtMovieLandscapeExpertBDMV.Size = New System.Drawing.Size(220, 22)
        Me.txtMovieLandscapeExpertBDMV.TabIndex = 9
        '
        'txtMovieDiscArtExpertBDMV
        '
        Me.txtMovieDiscArtExpertBDMV.Enabled = false
        Me.txtMovieDiscArtExpertBDMV.Location = New System.Drawing.Point(71, 195)
        Me.txtMovieDiscArtExpertBDMV.Name = "txtMovieDiscArtExpertBDMV"
        Me.txtMovieDiscArtExpertBDMV.Size = New System.Drawing.Size(220, 22)
        Me.txtMovieDiscArtExpertBDMV.TabIndex = 8
        '
        'lblMovieLandscapeExpertBDMV
        '
        Me.lblMovieLandscapeExpertBDMV.AutoSize = true
        Me.lblMovieLandscapeExpertBDMV.Location = New System.Drawing.Point(6, 225)
        Me.lblMovieLandscapeExpertBDMV.Name = "lblMovieLandscapeExpertBDMV"
        Me.lblMovieLandscapeExpertBDMV.Size = New System.Drawing.Size(61, 13)
        Me.lblMovieLandscapeExpertBDMV.TabIndex = 42
        Me.lblMovieLandscapeExpertBDMV.Text = "Landscape"
        '
        'lblMovieDiscArtExpertBDMV
        '
        Me.lblMovieDiscArtExpertBDMV.AutoSize = true
        Me.lblMovieDiscArtExpertBDMV.Location = New System.Drawing.Point(6, 198)
        Me.lblMovieDiscArtExpertBDMV.Name = "lblMovieDiscArtExpertBDMV"
        Me.lblMovieDiscArtExpertBDMV.Size = New System.Drawing.Size(43, 13)
        Me.lblMovieDiscArtExpertBDMV.TabIndex = 41
        Me.lblMovieDiscArtExpertBDMV.Text = "DiscArt"
        '
        'lblMovieBannerExpertBDMV
        '
        Me.lblMovieBannerExpertBDMV.AutoSize = true
        Me.lblMovieBannerExpertBDMV.Location = New System.Drawing.Point(6, 117)
        Me.lblMovieBannerExpertBDMV.Name = "lblMovieBannerExpertBDMV"
        Me.lblMovieBannerExpertBDMV.Size = New System.Drawing.Size(44, 13)
        Me.lblMovieBannerExpertBDMV.TabIndex = 40
        Me.lblMovieBannerExpertBDMV.Text = "Banner"
        '
        'lblMovieTrailerExpertBDMV
        '
        Me.lblMovieTrailerExpertBDMV.AutoSize = true
        Me.lblMovieTrailerExpertBDMV.Location = New System.Drawing.Point(6, 90)
        Me.lblMovieTrailerExpertBDMV.Name = "lblMovieTrailerExpertBDMV"
        Me.lblMovieTrailerExpertBDMV.Size = New System.Drawing.Size(38, 13)
        Me.lblMovieTrailerExpertBDMV.TabIndex = 39
        Me.lblMovieTrailerExpertBDMV.Text = "Trailer"
        '
        'lblMovieClearLogoExpertBDMV
        '
        Me.lblMovieClearLogoExpertBDMV.AutoSize = true
        Me.lblMovieClearLogoExpertBDMV.Location = New System.Drawing.Point(6, 144)
        Me.lblMovieClearLogoExpertBDMV.Name = "lblMovieClearLogoExpertBDMV"
        Me.lblMovieClearLogoExpertBDMV.Size = New System.Drawing.Size(59, 13)
        Me.lblMovieClearLogoExpertBDMV.TabIndex = 38
        Me.lblMovieClearLogoExpertBDMV.Text = "ClearLogo"
        '
        'lblMovieFanartExpertBDMV
        '
        Me.lblMovieFanartExpertBDMV.AutoSize = true
        Me.lblMovieFanartExpertBDMV.Location = New System.Drawing.Point(6, 64)
        Me.lblMovieFanartExpertBDMV.Name = "lblMovieFanartExpertBDMV"
        Me.lblMovieFanartExpertBDMV.Size = New System.Drawing.Size(40, 13)
        Me.lblMovieFanartExpertBDMV.TabIndex = 37
        Me.lblMovieFanartExpertBDMV.Text = "Fanart"
        '
        'lblMoviePosterExpertBDMV
        '
        Me.lblMoviePosterExpertBDMV.AutoSize = true
        Me.lblMoviePosterExpertBDMV.Location = New System.Drawing.Point(6, 36)
        Me.lblMoviePosterExpertBDMV.Name = "lblMoviePosterExpertBDMV"
        Me.lblMoviePosterExpertBDMV.Size = New System.Drawing.Size(39, 13)
        Me.lblMoviePosterExpertBDMV.TabIndex = 36
        Me.lblMoviePosterExpertBDMV.Text = "Poster"
        '
        'txtMovieNFOExpertBDMV
        '
        Me.txtMovieNFOExpertBDMV.Enabled = false
        Me.txtMovieNFOExpertBDMV.Location = New System.Drawing.Point(71, 6)
        Me.txtMovieNFOExpertBDMV.Name = "txtMovieNFOExpertBDMV"
        Me.txtMovieNFOExpertBDMV.Size = New System.Drawing.Size(220, 22)
        Me.txtMovieNFOExpertBDMV.TabIndex = 1
        '
        'lblMovieNFOExpertBDMV
        '
        Me.lblMovieNFOExpertBDMV.AutoSize = true
        Me.lblMovieNFOExpertBDMV.Location = New System.Drawing.Point(6, 9)
        Me.lblMovieNFOExpertBDMV.Name = "lblMovieNFOExpertBDMV"
        Me.lblMovieNFOExpertBDMV.Size = New System.Drawing.Size(30, 13)
        Me.lblMovieNFOExpertBDMV.TabIndex = 35
        Me.lblMovieNFOExpertBDMV.Text = "NFO"
        '
        'chkMovieUseExpert
        '
        Me.chkMovieUseExpert.AutoSize = true
        Me.chkMovieUseExpert.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkMovieUseExpert.Location = New System.Drawing.Point(6, 21)
        Me.chkMovieUseExpert.Name = "chkMovieUseExpert"
        Me.chkMovieUseExpert.Size = New System.Drawing.Size(45, 17)
        Me.chkMovieUseExpert.TabIndex = 1
        Me.chkMovieUseExpert.Text = "Use"
        Me.chkMovieUseExpert.UseVisualStyleBackColor = true
        '
        'btnMovieSourceEdit
        '
        Me.btnMovieSourceEdit.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnMovieSourceEdit.Image = CType(resources.GetObject("btnMovieSourceEdit.Image"),System.Drawing.Image)
        Me.btnMovieSourceEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMovieSourceEdit.Location = New System.Drawing.Point(638, 35)
        Me.btnMovieSourceEdit.Name = "btnMovieSourceEdit"
        Me.btnMovieSourceEdit.Size = New System.Drawing.Size(104, 23)
        Me.btnMovieSourceEdit.TabIndex = 2
        Me.btnMovieSourceEdit.Text = "Edit Source"
        Me.btnMovieSourceEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnMovieSourceEdit.UseVisualStyleBackColor = true
        '
        'gbMovieMiscOpts
        '
        Me.gbMovieMiscOpts.Controls.Add(Me.chkMovieScanOrderModify)
        Me.gbMovieMiscOpts.Controls.Add(Me.chkMovieSortBeforeScan)
        Me.gbMovieMiscOpts.Controls.Add(Me.chkMovieGeneralIgnoreLastScan)
        Me.gbMovieMiscOpts.Controls.Add(Me.chkMovieCleanDB)
        Me.gbMovieMiscOpts.Controls.Add(Me.chkMovieSkipStackedSizeCheck)
        Me.gbMovieMiscOpts.Controls.Add(Me.lblMovieSkipLessThanMB)
        Me.gbMovieMiscOpts.Controls.Add(Me.txtMovieSkipLessThan)
        Me.gbMovieMiscOpts.Controls.Add(Me.lblMovieSkipLessThan)
        Me.gbMovieMiscOpts.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.gbMovieMiscOpts.Location = New System.Drawing.Point(5, 113)
        Me.gbMovieMiscOpts.Name = "gbMovieMiscOpts"
        Me.gbMovieMiscOpts.Size = New System.Drawing.Size(212, 229)
        Me.gbMovieMiscOpts.TabIndex = 4
        Me.gbMovieMiscOpts.TabStop = false
        Me.gbMovieMiscOpts.Text = "Miscellaneous Options"
        '
        'chkMovieScanOrderModify
        '
        Me.chkMovieScanOrderModify.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkMovieScanOrderModify.Location = New System.Drawing.Point(6, 148)
        Me.chkMovieScanOrderModify.Name = "chkMovieScanOrderModify"
        Me.chkMovieScanOrderModify.Size = New System.Drawing.Size(200, 33)
        Me.chkMovieScanOrderModify.TabIndex = 8
        Me.chkMovieScanOrderModify.Text = "Scan in order of last write time."
        Me.chkMovieScanOrderModify.UseVisualStyleBackColor = true
        '
        'chkMovieSortBeforeScan
        '
        Me.chkMovieSortBeforeScan.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkMovieSortBeforeScan.Location = New System.Drawing.Point(6, 72)
        Me.chkMovieSortBeforeScan.Name = "chkMovieSortBeforeScan"
        Me.chkMovieSortBeforeScan.Size = New System.Drawing.Size(200, 31)
        Me.chkMovieSortBeforeScan.TabIndex = 6
        Me.chkMovieSortBeforeScan.Text = "Sort files into folders before each library update"
        Me.chkMovieSortBeforeScan.UseVisualStyleBackColor = true
        '
        'chkMovieGeneralIgnoreLastScan
        '
        Me.chkMovieGeneralIgnoreLastScan.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkMovieGeneralIgnoreLastScan.Location = New System.Drawing.Point(6, 109)
        Me.chkMovieGeneralIgnoreLastScan.Name = "chkMovieGeneralIgnoreLastScan"
        Me.chkMovieGeneralIgnoreLastScan.Size = New System.Drawing.Size(200, 33)
        Me.chkMovieGeneralIgnoreLastScan.TabIndex = 7
        Me.chkMovieGeneralIgnoreLastScan.Text = "Always scan all media when updating library"
        Me.chkMovieGeneralIgnoreLastScan.UseVisualStyleBackColor = true
        '
        'chkMovieCleanDB
        '
        Me.chkMovieCleanDB.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkMovieCleanDB.Location = New System.Drawing.Point(6, 187)
        Me.chkMovieCleanDB.Name = "chkMovieCleanDB"
        Me.chkMovieCleanDB.Size = New System.Drawing.Size(200, 33)
        Me.chkMovieCleanDB.TabIndex = 9
        Me.chkMovieCleanDB.Text = "Clean database after updating library"
        Me.chkMovieCleanDB.UseVisualStyleBackColor = true
        '
        'chkMovieSkipStackedSizeCheck
        '
        Me.chkMovieSkipStackedSizeCheck.AutoSize = true
        Me.chkMovieSkipStackedSizeCheck.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkMovieSkipStackedSizeCheck.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkMovieSkipStackedSizeCheck.Location = New System.Drawing.Point(21, 49)
        Me.chkMovieSkipStackedSizeCheck.Name = "chkMovieSkipStackedSizeCheck"
        Me.chkMovieSkipStackedSizeCheck.Size = New System.Drawing.Size(188, 17)
        Me.chkMovieSkipStackedSizeCheck.TabIndex = 3
        Me.chkMovieSkipStackedSizeCheck.Text = "Skip Size Check of Stacked Files"
        Me.chkMovieSkipStackedSizeCheck.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.chkMovieSkipStackedSizeCheck.UseVisualStyleBackColor = true
        '
        'lblMovieSkipLessThanMB
        '
        Me.lblMovieSkipLessThanMB.AutoSize = true
        Me.lblMovieSkipLessThanMB.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblMovieSkipLessThanMB.Location = New System.Drawing.Point(185, 26)
        Me.lblMovieSkipLessThanMB.Name = "lblMovieSkipLessThanMB"
        Me.lblMovieSkipLessThanMB.Size = New System.Drawing.Size(24, 13)
        Me.lblMovieSkipLessThanMB.TabIndex = 2
        Me.lblMovieSkipLessThanMB.Text = "MB"
        '
        'txtMovieSkipLessThan
        '
        Me.txtMovieSkipLessThan.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtMovieSkipLessThan.Location = New System.Drawing.Point(130, 21)
        Me.txtMovieSkipLessThan.Name = "txtMovieSkipLessThan"
        Me.txtMovieSkipLessThan.Size = New System.Drawing.Size(51, 22)
        Me.txtMovieSkipLessThan.TabIndex = 1
        '
        'lblMovieSkipLessThan
        '
        Me.lblMovieSkipLessThan.AutoSize = true
        Me.lblMovieSkipLessThan.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblMovieSkipLessThan.Location = New System.Drawing.Point(4, 26)
        Me.lblMovieSkipLessThan.Name = "lblMovieSkipLessThan"
        Me.lblMovieSkipLessThan.Size = New System.Drawing.Size(122, 13)
        Me.lblMovieSkipLessThan.TabIndex = 0
        Me.lblMovieSkipLessThan.Text = "Skip files smaller than:"
        '
        'pnlTVGeneral
        '
        Me.pnlTVGeneral.BackColor = System.Drawing.Color.White
<<<<<<< HEAD
        Me.pnlTVGeneral.Controls.Add(Me.gbTVListOptions)
        Me.pnlTVGeneral.Controls.Add(Me.gbEpFilter)
        Me.pnlTVGeneral.Controls.Add(Me.gbTVMisc)
        Me.pnlTVGeneral.Controls.Add(Me.gbShowFilter)
        Me.pnlTVGeneral.Location = New System.Drawing.Point(1200, 530)
=======
        Me.pnlTVGeneral.Controls.Add(Me.gbTVGeneralMediaListOpts)
        Me.pnlTVGeneral.Controls.Add(Me.gbTVEpisodeFilterOpts)
        Me.pnlTVGeneral.Controls.Add(Me.gbTVGeneralMiscOpts)
        Me.pnlTVGeneral.Controls.Add(Me.gbTVShowFilterOpts)
        Me.pnlTVGeneral.Location = New System.Drawing.Point(900, 900)
>>>>>>> upstream/master
        Me.pnlTVGeneral.Name = "pnlTVGeneral"
        Me.pnlTVGeneral.Size = New System.Drawing.Size(750, 500)
        Me.pnlTVGeneral.TabIndex = 20
        Me.pnlTVGeneral.Visible = false
        '
        'gbTVGeneralMediaListOpts
        '
        Me.gbTVGeneralMediaListOpts.Controls.Add(Me.chkTVDisplayMissingEpisodes)
        Me.gbTVGeneralMediaListOpts.Controls.Add(Me.gbTVGeneralListEpisodeOpts)
        Me.gbTVGeneralMediaListOpts.Controls.Add(Me.gbTVGeneralListSeasonOpts)
        Me.gbTVGeneralMediaListOpts.Controls.Add(Me.gbTVGeneralListShowOpts)
        Me.gbTVGeneralMediaListOpts.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.gbTVGeneralMediaListOpts.Location = New System.Drawing.Point(6, 150)
        Me.gbTVGeneralMediaListOpts.Name = "gbTVGeneralMediaListOpts"
        Me.gbTVGeneralMediaListOpts.Size = New System.Drawing.Size(219, 245)
        Me.gbTVGeneralMediaListOpts.TabIndex = 1
        Me.gbTVGeneralMediaListOpts.TabStop = false
        Me.gbTVGeneralMediaListOpts.Text = "Media List Options"
        '
        'chkTVDisplayMissingEpisodes
        '
        Me.chkTVDisplayMissingEpisodes.AutoSize = true
        Me.chkTVDisplayMissingEpisodes.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkTVDisplayMissingEpisodes.Location = New System.Drawing.Point(10, 224)
        Me.chkTVDisplayMissingEpisodes.Name = "chkTVDisplayMissingEpisodes"
        Me.chkTVDisplayMissingEpisodes.Size = New System.Drawing.Size(155, 17)
        Me.chkTVDisplayMissingEpisodes.TabIndex = 3
        Me.chkTVDisplayMissingEpisodes.Text = "Display Missing Episodes"
        Me.chkTVDisplayMissingEpisodes.UseVisualStyleBackColor = true
        '
        'gbTVGeneralListEpisodeOpts
        '
        Me.gbTVGeneralListEpisodeOpts.Controls.Add(Me.chkTVEpisodeNfoCol)
        Me.gbTVGeneralListEpisodeOpts.Controls.Add(Me.chkTVEpisodeFanartCol)
        Me.gbTVGeneralListEpisodeOpts.Controls.Add(Me.chkTVEpisodePosterCol)
        Me.gbTVGeneralListEpisodeOpts.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.gbTVGeneralListEpisodeOpts.Location = New System.Drawing.Point(10, 143)
        Me.gbTVGeneralListEpisodeOpts.Name = "gbTVGeneralListEpisodeOpts"
        Me.gbTVGeneralListEpisodeOpts.Size = New System.Drawing.Size(199, 68)
        Me.gbTVGeneralListEpisodeOpts.TabIndex = 2
        Me.gbTVGeneralListEpisodeOpts.TabStop = false
        Me.gbTVGeneralListEpisodeOpts.Text = "Episodes"
        '
        'chkTVEpisodeNfoCol
        '
        Me.chkTVEpisodeNfoCol.AutoSize = true
        Me.chkTVEpisodeNfoCol.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkTVEpisodeNfoCol.Location = New System.Drawing.Point(7, 48)
        Me.chkTVEpisodeNfoCol.Name = "chkTVEpisodeNfoCol"
        Me.chkTVEpisodeNfoCol.Size = New System.Drawing.Size(117, 17)
        Me.chkTVEpisodeNfoCol.TabIndex = 2
        Me.chkTVEpisodeNfoCol.Text = "Hide Info Column"
        Me.chkTVEpisodeNfoCol.UseVisualStyleBackColor = true
        '
        'chkTVEpisodeFanartCol
        '
        Me.chkTVEpisodeFanartCol.AutoSize = true
        Me.chkTVEpisodeFanartCol.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkTVEpisodeFanartCol.Location = New System.Drawing.Point(7, 32)
        Me.chkTVEpisodeFanartCol.Name = "chkTVEpisodeFanartCol"
        Me.chkTVEpisodeFanartCol.Size = New System.Drawing.Size(129, 17)
        Me.chkTVEpisodeFanartCol.TabIndex = 1
        Me.chkTVEpisodeFanartCol.Text = "Hide Fanart Column"
        Me.chkTVEpisodeFanartCol.UseVisualStyleBackColor = true
        '
        'chkTVEpisodePosterCol
        '
        Me.chkTVEpisodePosterCol.AutoSize = true
        Me.chkTVEpisodePosterCol.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkTVEpisodePosterCol.Location = New System.Drawing.Point(7, 16)
        Me.chkTVEpisodePosterCol.Name = "chkTVEpisodePosterCol"
        Me.chkTVEpisodePosterCol.Size = New System.Drawing.Size(128, 17)
        Me.chkTVEpisodePosterCol.TabIndex = 0
        Me.chkTVEpisodePosterCol.Text = "Hide Poster Column"
        Me.chkTVEpisodePosterCol.UseVisualStyleBackColor = true
        '
        'gbTVGeneralListSeasonOpts
        '
        Me.gbTVGeneralListSeasonOpts.Controls.Add(Me.chkTVSeasonFanartCol)
        Me.gbTVGeneralListSeasonOpts.Controls.Add(Me.chkTVSeasonPosterCol)
        Me.gbTVGeneralListSeasonOpts.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.gbTVGeneralListSeasonOpts.Location = New System.Drawing.Point(10, 87)
        Me.gbTVGeneralListSeasonOpts.Name = "gbTVGeneralListSeasonOpts"
        Me.gbTVGeneralListSeasonOpts.Size = New System.Drawing.Size(199, 52)
        Me.gbTVGeneralListSeasonOpts.TabIndex = 1
        Me.gbTVGeneralListSeasonOpts.TabStop = false
        Me.gbTVGeneralListSeasonOpts.Text = "Seasons"
        '
        'chkTVSeasonFanartCol
        '
        Me.chkTVSeasonFanartCol.AutoSize = true
        Me.chkTVSeasonFanartCol.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkTVSeasonFanartCol.Location = New System.Drawing.Point(7, 32)
        Me.chkTVSeasonFanartCol.Name = "chkTVSeasonFanartCol"
        Me.chkTVSeasonFanartCol.Size = New System.Drawing.Size(129, 17)
        Me.chkTVSeasonFanartCol.TabIndex = 1
        Me.chkTVSeasonFanartCol.Text = "Hide Fanart Column"
        Me.chkTVSeasonFanartCol.UseVisualStyleBackColor = true
        '
        'chkTVSeasonPosterCol
        '
        Me.chkTVSeasonPosterCol.AutoSize = true
        Me.chkTVSeasonPosterCol.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkTVSeasonPosterCol.Location = New System.Drawing.Point(7, 16)
        Me.chkTVSeasonPosterCol.Name = "chkTVSeasonPosterCol"
        Me.chkTVSeasonPosterCol.Size = New System.Drawing.Size(128, 17)
        Me.chkTVSeasonPosterCol.TabIndex = 0
        Me.chkTVSeasonPosterCol.Text = "Hide Poster Column"
        Me.chkTVSeasonPosterCol.UseVisualStyleBackColor = true
        '
        'gbTVGeneralListShowOpts
        '
        Me.gbTVGeneralListShowOpts.Controls.Add(Me.chkTVShowNfoCol)
        Me.gbTVGeneralListShowOpts.Controls.Add(Me.chkTVShowFanartCol)
        Me.gbTVGeneralListShowOpts.Controls.Add(Me.chkTVShowPosterCol)
        Me.gbTVGeneralListShowOpts.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.gbTVGeneralListShowOpts.Location = New System.Drawing.Point(9, 16)
        Me.gbTVGeneralListShowOpts.Name = "gbTVGeneralListShowOpts"
        Me.gbTVGeneralListShowOpts.Size = New System.Drawing.Size(199, 68)
        Me.gbTVGeneralListShowOpts.TabIndex = 0
        Me.gbTVGeneralListShowOpts.TabStop = false
        Me.gbTVGeneralListShowOpts.Text = "Shows"
        '
        'chkTVShowNfoCol
        '
        Me.chkTVShowNfoCol.AutoSize = true
        Me.chkTVShowNfoCol.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkTVShowNfoCol.Location = New System.Drawing.Point(7, 48)
        Me.chkTVShowNfoCol.Name = "chkTVShowNfoCol"
        Me.chkTVShowNfoCol.Size = New System.Drawing.Size(117, 17)
        Me.chkTVShowNfoCol.TabIndex = 2
        Me.chkTVShowNfoCol.Text = "Hide Info Column"
        Me.chkTVShowNfoCol.UseVisualStyleBackColor = true
        '
        'chkTVShowFanartCol
        '
        Me.chkTVShowFanartCol.AutoSize = true
        Me.chkTVShowFanartCol.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkTVShowFanartCol.Location = New System.Drawing.Point(7, 32)
        Me.chkTVShowFanartCol.Name = "chkTVShowFanartCol"
        Me.chkTVShowFanartCol.Size = New System.Drawing.Size(129, 17)
        Me.chkTVShowFanartCol.TabIndex = 1
        Me.chkTVShowFanartCol.Text = "Hide Fanart Column"
        Me.chkTVShowFanartCol.UseVisualStyleBackColor = true
        '
        'chkTVShowPosterCol
        '
        Me.chkTVShowPosterCol.AutoSize = true
        Me.chkTVShowPosterCol.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkTVShowPosterCol.Location = New System.Drawing.Point(7, 16)
        Me.chkTVShowPosterCol.Name = "chkTVShowPosterCol"
        Me.chkTVShowPosterCol.Size = New System.Drawing.Size(128, 17)
        Me.chkTVShowPosterCol.TabIndex = 0
        Me.chkTVShowPosterCol.Text = "Hide Poster Column"
        Me.chkTVShowPosterCol.UseVisualStyleBackColor = true
        '
        'gbTVEpisodeFilterOpts
        '
        Me.gbTVEpisodeFilterOpts.Controls.Add(Me.btnTVEpisodeFilterReset)
        Me.gbTVEpisodeFilterOpts.Controls.Add(Me.chkTVEpisodeNoFilter)
        Me.gbTVEpisodeFilterOpts.Controls.Add(Me.btnTVEpisodeFilterDown)
        Me.gbTVEpisodeFilterOpts.Controls.Add(Me.btnTVEpisodeFilterUp)
        Me.gbTVEpisodeFilterOpts.Controls.Add(Me.chkTVEpisodeProperCase)
        Me.gbTVEpisodeFilterOpts.Controls.Add(Me.btnTVEpisodeFilterRemove)
        Me.gbTVEpisodeFilterOpts.Controls.Add(Me.btnTVEpisodeFilterAdd)
        Me.gbTVEpisodeFilterOpts.Controls.Add(Me.txtTVEpisodeFilter)
        Me.gbTVEpisodeFilterOpts.Controls.Add(Me.lstTVEpisodeFilter)
        Me.gbTVEpisodeFilterOpts.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.gbTVEpisodeFilterOpts.Location = New System.Drawing.Point(229, 185)
        Me.gbTVEpisodeFilterOpts.Name = "gbTVEpisodeFilterOpts"
        Me.gbTVEpisodeFilterOpts.Size = New System.Drawing.Size(382, 205)
        Me.gbTVEpisodeFilterOpts.TabIndex = 3
        Me.gbTVEpisodeFilterOpts.TabStop = false
        Me.gbTVEpisodeFilterOpts.Text = "Episode Folder/File Name Filters"
        '
        'btnTVEpisodeFilterReset
        '
        Me.btnTVEpisodeFilterReset.Image = CType(resources.GetObject("btnTVEpisodeFilterReset.Image"),System.Drawing.Image)
        Me.btnTVEpisodeFilterReset.Location = New System.Drawing.Point(354, 38)
        Me.btnTVEpisodeFilterReset.Name = "btnTVEpisodeFilterReset"
        Me.btnTVEpisodeFilterReset.Size = New System.Drawing.Size(23, 23)
        Me.btnTVEpisodeFilterReset.TabIndex = 3
        Me.btnTVEpisodeFilterReset.UseVisualStyleBackColor = true
        '
        'chkTVEpisodeNoFilter
        '
        Me.chkTVEpisodeNoFilter.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkTVEpisodeNoFilter.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.chkTVEpisodeNoFilter.Location = New System.Drawing.Point(6, 15)
        Me.chkTVEpisodeNoFilter.Name = "chkTVEpisodeNoFilter"
        Me.chkTVEpisodeNoFilter.Size = New System.Drawing.Size(371, 21)
        Me.chkTVEpisodeNoFilter.TabIndex = 0
        Me.chkTVEpisodeNoFilter.Text = "Build Episode Title Instead of Filtering"
        Me.chkTVEpisodeNoFilter.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkTVEpisodeNoFilter.UseVisualStyleBackColor = true
        '
        'btnTVEpisodeFilterDown
        '
        Me.btnTVEpisodeFilterDown.Image = CType(resources.GetObject("btnTVEpisodeFilterDown.Image"),System.Drawing.Image)
        Me.btnTVEpisodeFilterDown.Location = New System.Drawing.Point(320, 176)
        Me.btnTVEpisodeFilterDown.Name = "btnTVEpisodeFilterDown"
        Me.btnTVEpisodeFilterDown.Size = New System.Drawing.Size(23, 23)
        Me.btnTVEpisodeFilterDown.TabIndex = 7
        Me.btnTVEpisodeFilterDown.UseVisualStyleBackColor = true
        '
        'btnTVEpisodeFilterUp
        '
        Me.btnTVEpisodeFilterUp.Image = CType(resources.GetObject("btnTVEpisodeFilterUp.Image"),System.Drawing.Image)
        Me.btnTVEpisodeFilterUp.Location = New System.Drawing.Point(296, 176)
        Me.btnTVEpisodeFilterUp.Name = "btnTVEpisodeFilterUp"
        Me.btnTVEpisodeFilterUp.Size = New System.Drawing.Size(23, 23)
        Me.btnTVEpisodeFilterUp.TabIndex = 6
        Me.btnTVEpisodeFilterUp.UseVisualStyleBackColor = true
        '
        'chkTVEpisodeProperCase
        '
        Me.chkTVEpisodeProperCase.AutoSize = true
        Me.chkTVEpisodeProperCase.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkTVEpisodeProperCase.Location = New System.Drawing.Point(6, 47)
        Me.chkTVEpisodeProperCase.Name = "chkTVEpisodeProperCase"
        Me.chkTVEpisodeProperCase.Size = New System.Drawing.Size(181, 17)
        Me.chkTVEpisodeProperCase.TabIndex = 1
        Me.chkTVEpisodeProperCase.Text = "Convert Names to Proper Case"
        Me.chkTVEpisodeProperCase.UseVisualStyleBackColor = true
        '
        'btnTVEpisodeFilterRemove
        '
        Me.btnTVEpisodeFilterRemove.Image = CType(resources.GetObject("btnTVEpisodeFilterRemove.Image"),System.Drawing.Image)
        Me.btnTVEpisodeFilterRemove.Location = New System.Drawing.Point(354, 176)
        Me.btnTVEpisodeFilterRemove.Name = "btnTVEpisodeFilterRemove"
        Me.btnTVEpisodeFilterRemove.Size = New System.Drawing.Size(23, 23)
        Me.btnTVEpisodeFilterRemove.TabIndex = 8
        Me.btnTVEpisodeFilterRemove.UseVisualStyleBackColor = true
        '
        'btnTVEpisodeFilterAdd
        '
        Me.btnTVEpisodeFilterAdd.Image = CType(resources.GetObject("btnTVEpisodeFilterAdd.Image"),System.Drawing.Image)
        Me.btnTVEpisodeFilterAdd.Location = New System.Drawing.Point(260, 176)
        Me.btnTVEpisodeFilterAdd.Name = "btnTVEpisodeFilterAdd"
        Me.btnTVEpisodeFilterAdd.Size = New System.Drawing.Size(23, 23)
        Me.btnTVEpisodeFilterAdd.TabIndex = 5
        Me.btnTVEpisodeFilterAdd.UseVisualStyleBackColor = true
        '
        'txtTVEpisodeFilter
        '
        Me.txtTVEpisodeFilter.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtTVEpisodeFilter.Location = New System.Drawing.Point(6, 177)
        Me.txtTVEpisodeFilter.Name = "txtTVEpisodeFilter"
        Me.txtTVEpisodeFilter.Size = New System.Drawing.Size(252, 22)
        Me.txtTVEpisodeFilter.TabIndex = 4
        '
        'lstTVEpisodeFilter
        '
        Me.lstTVEpisodeFilter.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.lstTVEpisodeFilter.FormattingEnabled = true
        Me.lstTVEpisodeFilter.Location = New System.Drawing.Point(6, 64)
        Me.lstTVEpisodeFilter.Name = "lstTVEpisodeFilter"
        Me.lstTVEpisodeFilter.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lstTVEpisodeFilter.Size = New System.Drawing.Size(371, 95)
        Me.lstTVEpisodeFilter.TabIndex = 2
        '
        'gbTVGeneralMiscOpts
        '
        Me.gbTVGeneralMiscOpts.Controls.Add(Me.chkTVGeneralMarkNewShows)
        Me.gbTVGeneralMiscOpts.Controls.Add(Me.chkTVGeneralMarkNewEpisodes)
        Me.gbTVGeneralMiscOpts.Controls.Add(Me.chkTVGeneralDisplayASPoster)
        Me.gbTVGeneralMiscOpts.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.gbTVGeneralMiscOpts.Location = New System.Drawing.Point(6, 7)
        Me.gbTVGeneralMiscOpts.Name = "gbTVGeneralMiscOpts"
        Me.gbTVGeneralMiscOpts.Size = New System.Drawing.Size(219, 142)
        Me.gbTVGeneralMiscOpts.TabIndex = 0
        Me.gbTVGeneralMiscOpts.TabStop = false
        Me.gbTVGeneralMiscOpts.Text = "Miscellaneous"
        '
        'chkTVGeneralMarkNewShows
        '
        Me.chkTVGeneralMarkNewShows.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkTVGeneralMarkNewShows.Location = New System.Drawing.Point(8, 90)
        Me.chkTVGeneralMarkNewShows.Name = "chkTVGeneralMarkNewShows"
        Me.chkTVGeneralMarkNewShows.Size = New System.Drawing.Size(204, 17)
        Me.chkTVGeneralMarkNewShows.TabIndex = 3
        Me.chkTVGeneralMarkNewShows.Text = "Mark New Shows"
        Me.chkTVGeneralMarkNewShows.UseVisualStyleBackColor = true
        '
        'chkTVGeneralMarkNewEpisodes
        '
        Me.chkTVGeneralMarkNewEpisodes.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkTVGeneralMarkNewEpisodes.Location = New System.Drawing.Point(8, 113)
        Me.chkTVGeneralMarkNewEpisodes.Name = "chkTVGeneralMarkNewEpisodes"
        Me.chkTVGeneralMarkNewEpisodes.Size = New System.Drawing.Size(204, 17)
        Me.chkTVGeneralMarkNewEpisodes.TabIndex = 4
        Me.chkTVGeneralMarkNewEpisodes.Text = "Mark New Episodes"
        Me.chkTVGeneralMarkNewEpisodes.UseVisualStyleBackColor = true
        '
        'chkTVGeneralDisplayASPoster
        '
        Me.chkTVGeneralDisplayASPoster.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkTVGeneralDisplayASPoster.Location = New System.Drawing.Point(8, 67)
        Me.chkTVGeneralDisplayASPoster.Name = "chkTVGeneralDisplayASPoster"
        Me.chkTVGeneralDisplayASPoster.Size = New System.Drawing.Size(204, 17)
        Me.chkTVGeneralDisplayASPoster.TabIndex = 2
        Me.chkTVGeneralDisplayASPoster.Text = "Display All Season Poster"
        Me.chkTVGeneralDisplayASPoster.UseVisualStyleBackColor = true
        '
        'gbTVShowFilterOpts
        '
        Me.gbTVShowFilterOpts.Controls.Add(Me.btnTVShowFilterReset)
        Me.gbTVShowFilterOpts.Controls.Add(Me.btnTVShowFilterDown)
        Me.gbTVShowFilterOpts.Controls.Add(Me.btnTVShowFilterUp)
        Me.gbTVShowFilterOpts.Controls.Add(Me.chkTVShowProperCase)
        Me.gbTVShowFilterOpts.Controls.Add(Me.btnTVShowFilterRemove)
        Me.gbTVShowFilterOpts.Controls.Add(Me.btnTVShowFilterAdd)
        Me.gbTVShowFilterOpts.Controls.Add(Me.txtTVShowFilter)
        Me.gbTVShowFilterOpts.Controls.Add(Me.lstTVShowFilter)
        Me.gbTVShowFilterOpts.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.gbTVShowFilterOpts.Location = New System.Drawing.Point(229, 7)
        Me.gbTVShowFilterOpts.Name = "gbTVShowFilterOpts"
        Me.gbTVShowFilterOpts.Size = New System.Drawing.Size(382, 175)
        Me.gbTVShowFilterOpts.TabIndex = 2
        Me.gbTVShowFilterOpts.TabStop = false
        Me.gbTVShowFilterOpts.Text = "Show Folder/File Name Filters"
        '
        'btnTVShowFilterReset
        '
        Me.btnTVShowFilterReset.Image = CType(resources.GetObject("btnTVShowFilterReset.Image"),System.Drawing.Image)
        Me.btnTVShowFilterReset.Location = New System.Drawing.Point(354, 9)
        Me.btnTVShowFilterReset.Name = "btnTVShowFilterReset"
        Me.btnTVShowFilterReset.Size = New System.Drawing.Size(23, 23)
        Me.btnTVShowFilterReset.TabIndex = 2
        Me.btnTVShowFilterReset.UseVisualStyleBackColor = true
        '
        'btnTVShowFilterDown
        '
        Me.btnTVShowFilterDown.Image = CType(resources.GetObject("btnTVShowFilterDown.Image"),System.Drawing.Image)
        Me.btnTVShowFilterDown.Location = New System.Drawing.Point(320, 146)
        Me.btnTVShowFilterDown.Name = "btnTVShowFilterDown"
        Me.btnTVShowFilterDown.Size = New System.Drawing.Size(23, 23)
        Me.btnTVShowFilterDown.TabIndex = 6
        Me.btnTVShowFilterDown.UseVisualStyleBackColor = true
        '
        'btnTVShowFilterUp
        '
        Me.btnTVShowFilterUp.Image = CType(resources.GetObject("btnTVShowFilterUp.Image"),System.Drawing.Image)
        Me.btnTVShowFilterUp.Location = New System.Drawing.Point(296, 146)
        Me.btnTVShowFilterUp.Name = "btnTVShowFilterUp"
        Me.btnTVShowFilterUp.Size = New System.Drawing.Size(23, 23)
        Me.btnTVShowFilterUp.TabIndex = 5
        Me.btnTVShowFilterUp.UseVisualStyleBackColor = true
        '
        'chkTVShowProperCase
        '
        Me.chkTVShowProperCase.AutoSize = true
        Me.chkTVShowProperCase.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkTVShowProperCase.Location = New System.Drawing.Point(6, 17)
        Me.chkTVShowProperCase.Name = "chkTVShowProperCase"
        Me.chkTVShowProperCase.Size = New System.Drawing.Size(181, 17)
        Me.chkTVShowProperCase.TabIndex = 0
        Me.chkTVShowProperCase.Text = "Convert Names to Proper Case"
        Me.chkTVShowProperCase.UseVisualStyleBackColor = true
        '
        'btnTVShowFilterRemove
        '
        Me.btnTVShowFilterRemove.Image = CType(resources.GetObject("btnTVShowFilterRemove.Image"),System.Drawing.Image)
        Me.btnTVShowFilterRemove.Location = New System.Drawing.Point(354, 146)
        Me.btnTVShowFilterRemove.Name = "btnTVShowFilterRemove"
        Me.btnTVShowFilterRemove.Size = New System.Drawing.Size(23, 23)
        Me.btnTVShowFilterRemove.TabIndex = 7
        Me.btnTVShowFilterRemove.UseVisualStyleBackColor = true
        '
        'btnTVShowFilterAdd
        '
        Me.btnTVShowFilterAdd.Image = CType(resources.GetObject("btnTVShowFilterAdd.Image"),System.Drawing.Image)
        Me.btnTVShowFilterAdd.Location = New System.Drawing.Point(260, 146)
        Me.btnTVShowFilterAdd.Name = "btnTVShowFilterAdd"
        Me.btnTVShowFilterAdd.Size = New System.Drawing.Size(23, 23)
        Me.btnTVShowFilterAdd.TabIndex = 4
        Me.btnTVShowFilterAdd.UseVisualStyleBackColor = true
        '
        'txtTVShowFilter
        '
        Me.txtTVShowFilter.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtTVShowFilter.Location = New System.Drawing.Point(6, 147)
        Me.txtTVShowFilter.Name = "txtTVShowFilter"
        Me.txtTVShowFilter.Size = New System.Drawing.Size(252, 22)
        Me.txtTVShowFilter.TabIndex = 3
        '
        'lstTVShowFilter
        '
        Me.lstTVShowFilter.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.lstTVShowFilter.FormattingEnabled = true
        Me.lstTVShowFilter.Location = New System.Drawing.Point(6, 35)
        Me.lstTVShowFilter.Name = "lstTVShowFilter"
        Me.lstTVShowFilter.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lstTVShowFilter.Size = New System.Drawing.Size(371, 95)
        Me.lstTVShowFilter.TabIndex = 1
        '
        'pnlTVSources
        '
        Me.pnlTVSources.BackColor = System.Drawing.Color.White
<<<<<<< HEAD
        Me.pnlTVSources.Controls.Add(Me.TabControl2)
        Me.pnlTVSources.Location = New System.Drawing.Point(1350, 350)
=======
        Me.pnlTVSources.Controls.Add(Me.tcTVSources)
        Me.pnlTVSources.Location = New System.Drawing.Point(900, 900)
>>>>>>> upstream/master
        Me.pnlTVSources.Name = "pnlTVSources"
        Me.pnlTVSources.Size = New System.Drawing.Size(750, 500)
        Me.pnlTVSources.TabIndex = 11
        Me.pnlTVSources.Visible = false
        '
        'tcTVSources
        '
        Me.tcTVSources.Controls.Add(Me.tpTVSourcesGeneral)
        Me.tcTVSources.Controls.Add(Me.tpTVSourcesRegex)
        Me.tcTVSources.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.tcTVSources.Location = New System.Drawing.Point(3, 4)
        Me.tcTVSources.Name = "tcTVSources"
        Me.tcTVSources.SelectedIndex = 0
        Me.tcTVSources.Size = New System.Drawing.Size(744, 493)
        Me.tcTVSources.TabIndex = 0
        '
        'tpTVSourcesGeneral
        '
        Me.tpTVSourcesGeneral.Controls.Add(Me.gbTVFileNaming)
        Me.tpTVSourcesGeneral.Controls.Add(Me.lvTVSources)
        Me.tpTVSourcesGeneral.Controls.Add(Me.gbTVSourcesMiscOpts)
        Me.tpTVSourcesGeneral.Controls.Add(Me.btnTVSourceAdd)
        Me.tpTVSourcesGeneral.Controls.Add(Me.btnTVSourceEdit)
        Me.tpTVSourcesGeneral.Controls.Add(Me.btnRemTVSource)
        Me.tpTVSourcesGeneral.Location = New System.Drawing.Point(4, 22)
        Me.tpTVSourcesGeneral.Name = "tpTVSourcesGeneral"
        Me.tpTVSourcesGeneral.Padding = New System.Windows.Forms.Padding(3)
        Me.tpTVSourcesGeneral.Size = New System.Drawing.Size(736, 467)
        Me.tpTVSourcesGeneral.TabIndex = 0
        Me.tpTVSourcesGeneral.Text = "General"
        Me.tpTVSourcesGeneral.UseVisualStyleBackColor = true
        '
        'gbTVFileNaming
        '
        Me.gbTVFileNaming.Controls.Add(Me.tcTVFileNaming)
        Me.gbTVFileNaming.Location = New System.Drawing.Point(163, 110)
        Me.gbTVFileNaming.Name = "gbTVFileNaming"
        Me.gbTVFileNaming.Size = New System.Drawing.Size(567, 351)
        Me.gbTVFileNaming.TabIndex = 6
        Me.gbTVFileNaming.TabStop = false
        Me.gbTVFileNaming.Text = "File Naming"
        '
        'tcTVFileNaming
        '
        Me.tcTVFileNaming.Controls.Add(Me.tpTVFileNamingXBMC)
        Me.tcTVFileNaming.Controls.Add(Me.tpTVFileNamingNMT)
        Me.tcTVFileNaming.Controls.Add(Me.tpTVFileNamingExpert)
        Me.tcTVFileNaming.Location = New System.Drawing.Point(6, 18)
        Me.tcTVFileNaming.Name = "tcTVFileNaming"
        Me.tcTVFileNaming.SelectedIndex = 0
        Me.tcTVFileNaming.Size = New System.Drawing.Size(555, 327)
        Me.tcTVFileNaming.TabIndex = 0
        '
        'tpTVFileNamingXBMC
        '
        Me.tpTVFileNamingXBMC.Controls.Add(Me.gbTVXBMCAdditional)
        Me.tpTVFileNamingXBMC.Controls.Add(Me.gbTVFrodo)
        Me.tpTVFileNamingXBMC.Location = New System.Drawing.Point(4, 22)
        Me.tpTVFileNamingXBMC.Name = "tpTVFileNamingXBMC"
        Me.tpTVFileNamingXBMC.Padding = New System.Windows.Forms.Padding(3)
        Me.tpTVFileNamingXBMC.Size = New System.Drawing.Size(547, 301)
        Me.tpTVFileNamingXBMC.TabIndex = 0
        Me.tpTVFileNamingXBMC.Text = "XBMC"
        Me.tpTVFileNamingXBMC.UseVisualStyleBackColor = true
        '
        'gbTVXBMCAdditional
        '
        Me.gbTVXBMCAdditional.Controls.Add(Me.btnTVShowTVThemeBrowse)
        Me.gbTVXBMCAdditional.Controls.Add(Me.txtTVShowTVThemeFolderXBMC)
        Me.gbTVXBMCAdditional.Controls.Add(Me.chkTVShowTVThemeXBMC)
        Me.gbTVXBMCAdditional.Controls.Add(Me.chkTVSeasonLandscapeXBMC)
        Me.gbTVXBMCAdditional.Controls.Add(Me.chkTVShowLandscapeXBMC)
        Me.gbTVXBMCAdditional.Controls.Add(Me.chkTVShowCharacterArtXBMC)
        Me.gbTVXBMCAdditional.Controls.Add(Me.chkTVShowClearArtXBMC)
        Me.gbTVXBMCAdditional.Controls.Add(Me.chkTVShowClearLogoXBMC)
        Me.gbTVXBMCAdditional.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.gbTVXBMCAdditional.Location = New System.Drawing.Point(341, 6)
        Me.gbTVXBMCAdditional.Name = "gbTVXBMCAdditional"
        Me.gbTVXBMCAdditional.Size = New System.Drawing.Size(200, 199)
        Me.gbTVXBMCAdditional.TabIndex = 2
        Me.gbTVXBMCAdditional.TabStop = false
        Me.gbTVXBMCAdditional.Text = "Additional Stuff"
        '
<<<<<<< HEAD
        'btnTVBrowseTVTheme
        '
        Me.btnTVBrowseTVTheme.Enabled = False
        Me.btnTVBrowseTVTheme.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnTVBrowseTVTheme.Location = New System.Drawing.Point(169, 166)
        Me.btnTVBrowseTVTheme.Name = "btnTVBrowseTVTheme"
        Me.btnTVBrowseTVTheme.Size = New System.Drawing.Size(25, 22)
        Me.btnTVBrowseTVTheme.TabIndex = 7
        Me.btnTVBrowseTVTheme.Text = "..."
        Me.btnTVBrowseTVTheme.UseVisualStyleBackColor = True
=======
        'btnTVShowTVThemeBrowse
        '
        Me.btnTVShowTVThemeBrowse.Enabled = false
        Me.btnTVShowTVThemeBrowse.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.btnTVShowTVThemeBrowse.Location = New System.Drawing.Point(169, 166)
        Me.btnTVShowTVThemeBrowse.Name = "btnTVShowTVThemeBrowse"
        Me.btnTVShowTVThemeBrowse.Size = New System.Drawing.Size(25, 22)
        Me.btnTVShowTVThemeBrowse.TabIndex = 7
        Me.btnTVShowTVThemeBrowse.Text = "..."
        Me.btnTVShowTVThemeBrowse.UseVisualStyleBackColor = true
>>>>>>> upstream/master
        '
        'txtTVShowTVThemeFolderXBMC
        '
        Me.txtTVShowTVThemeFolderXBMC.Enabled = false
        Me.txtTVShowTVThemeFolderXBMC.Location = New System.Drawing.Point(7, 166)
        Me.txtTVShowTVThemeFolderXBMC.Name = "txtTVShowTVThemeFolderXBMC"
        Me.txtTVShowTVThemeFolderXBMC.Size = New System.Drawing.Size(156, 22)
        Me.txtTVShowTVThemeFolderXBMC.TabIndex = 6
        '
        'chkTVShowTVThemeXBMC
        '
        Me.chkTVShowTVThemeXBMC.AutoSize = true
        Me.chkTVShowTVThemeXBMC.Enabled = false
        Me.chkTVShowTVThemeXBMC.Location = New System.Drawing.Point(7, 142)
        Me.chkTVShowTVThemeXBMC.Name = "chkTVShowTVThemeXBMC"
        Me.chkTVShowTVThemeXBMC.Size = New System.Drawing.Size(74, 17)
        Me.chkTVShowTVThemeXBMC.TabIndex = 5
        Me.chkTVShowTVThemeXBMC.Text = "TV Theme"
        Me.chkTVShowTVThemeXBMC.UseVisualStyleBackColor = true
        '
        'chkTVSeasonLandscapeXBMC
        '
        Me.chkTVSeasonLandscapeXBMC.AutoSize = true
        Me.chkTVSeasonLandscapeXBMC.Enabled = false
        Me.chkTVSeasonLandscapeXBMC.Location = New System.Drawing.Point(7, 118)
        Me.chkTVSeasonLandscapeXBMC.Name = "chkTVSeasonLandscapeXBMC"
        Me.chkTVSeasonLandscapeXBMC.Size = New System.Drawing.Size(120, 17)
        Me.chkTVSeasonLandscapeXBMC.TabIndex = 4
        Me.chkTVSeasonLandscapeXBMC.Text = "Season Landscape"
        Me.chkTVSeasonLandscapeXBMC.UseVisualStyleBackColor = true
        '
        'chkTVShowLandscapeXBMC
        '
        Me.chkTVShowLandscapeXBMC.AutoSize = true
        Me.chkTVShowLandscapeXBMC.Enabled = false
        Me.chkTVShowLandscapeXBMC.Location = New System.Drawing.Point(7, 94)
        Me.chkTVShowLandscapeXBMC.Name = "chkTVShowLandscapeXBMC"
        Me.chkTVShowLandscapeXBMC.Size = New System.Drawing.Size(112, 17)
        Me.chkTVShowLandscapeXBMC.TabIndex = 3
        Me.chkTVShowLandscapeXBMC.Text = "Show Landscape"
        Me.chkTVShowLandscapeXBMC.UseVisualStyleBackColor = true
        '
        'chkTVShowCharacterArtXBMC
        '
        Me.chkTVShowCharacterArtXBMC.AutoSize = true
        Me.chkTVShowCharacterArtXBMC.Enabled = false
        Me.chkTVShowCharacterArtXBMC.Location = New System.Drawing.Point(7, 70)
        Me.chkTVShowCharacterArtXBMC.Name = "chkTVShowCharacterArtXBMC"
        Me.chkTVShowCharacterArtXBMC.Size = New System.Drawing.Size(90, 17)
        Me.chkTVShowCharacterArtXBMC.TabIndex = 2
        Me.chkTVShowCharacterArtXBMC.Text = "CharacterArt"
        Me.chkTVShowCharacterArtXBMC.UseVisualStyleBackColor = true
        '
        'chkTVShowClearArtXBMC
        '
        Me.chkTVShowClearArtXBMC.AutoSize = true
        Me.chkTVShowClearArtXBMC.Enabled = false
        Me.chkTVShowClearArtXBMC.Location = New System.Drawing.Point(7, 46)
        Me.chkTVShowClearArtXBMC.Name = "chkTVShowClearArtXBMC"
        Me.chkTVShowClearArtXBMC.Size = New System.Drawing.Size(67, 17)
        Me.chkTVShowClearArtXBMC.TabIndex = 1
        Me.chkTVShowClearArtXBMC.Text = "ClearArt"
        Me.chkTVShowClearArtXBMC.UseVisualStyleBackColor = true
        '
        'chkTVShowClearLogoXBMC
        '
        Me.chkTVShowClearLogoXBMC.AutoSize = true
        Me.chkTVShowClearLogoXBMC.Enabled = false
        Me.chkTVShowClearLogoXBMC.Location = New System.Drawing.Point(7, 22)
        Me.chkTVShowClearLogoXBMC.Name = "chkTVShowClearLogoXBMC"
        Me.chkTVShowClearLogoXBMC.Size = New System.Drawing.Size(78, 17)
        Me.chkTVShowClearLogoXBMC.TabIndex = 0
        Me.chkTVShowClearLogoXBMC.Text = "ClearLogo"
        Me.chkTVShowClearLogoXBMC.UseVisualStyleBackColor = true
        '
        'gbTVFrodo
        '
        Me.gbTVFrodo.Controls.Add(Me.chkTVSeasonPosterFrodo)
        Me.gbTVFrodo.Controls.Add(Me.chkTVShowBannerFrodo)
        Me.gbTVFrodo.Controls.Add(Me.chkTVUseFrodo)
        Me.gbTVFrodo.Controls.Add(Me.chkTVEpisodeActorThumbsFrodo)
        Me.gbTVFrodo.Controls.Add(Me.chkTVSeasonBannerFrodo)
        Me.gbTVFrodo.Controls.Add(Me.chkTVEpisodePosterFrodo)
        Me.gbTVFrodo.Controls.Add(Me.chkTVShowActorThumbsFrodo)
        Me.gbTVFrodo.Controls.Add(Me.chkTVSeasonFanartFrodo)
        Me.gbTVFrodo.Controls.Add(Me.chkTVShowFanartFrodo)
        Me.gbTVFrodo.Controls.Add(Me.chkTVShowPosterFrodo)
        Me.gbTVFrodo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.gbTVFrodo.Location = New System.Drawing.Point(6, 6)
        Me.gbTVFrodo.Name = "gbTVFrodo"
        Me.gbTVFrodo.Size = New System.Drawing.Size(152, 289)
        Me.gbTVFrodo.TabIndex = 1
        Me.gbTVFrodo.TabStop = false
        Me.gbTVFrodo.Text = "Frodo"
        '
        'chkTVSeasonPosterFrodo
        '
        Me.chkTVSeasonPosterFrodo.AutoSize = true
        Me.chkTVSeasonPosterFrodo.Enabled = false
        Me.chkTVSeasonPosterFrodo.Location = New System.Drawing.Point(6, 136)
        Me.chkTVSeasonPosterFrodo.Name = "chkTVSeasonPosterFrodo"
        Me.chkTVSeasonPosterFrodo.Size = New System.Drawing.Size(98, 17)
        Me.chkTVSeasonPosterFrodo.TabIndex = 12
        Me.chkTVSeasonPosterFrodo.Text = "Season Poster"
        Me.chkTVSeasonPosterFrodo.UseVisualStyleBackColor = true
        '
        'chkTVShowBannerFrodo
        '
        Me.chkTVShowBannerFrodo.AutoSize = true
        Me.chkTVShowBannerFrodo.Enabled = false
        Me.chkTVShowBannerFrodo.Location = New System.Drawing.Point(6, 113)
        Me.chkTVShowBannerFrodo.Name = "chkTVShowBannerFrodo"
        Me.chkTVShowBannerFrodo.Size = New System.Drawing.Size(95, 17)
        Me.chkTVShowBannerFrodo.TabIndex = 11
        Me.chkTVShowBannerFrodo.Text = "Show Banner"
        Me.chkTVShowBannerFrodo.UseVisualStyleBackColor = true
        '
        'chkTVUseFrodo
        '
        Me.chkTVUseFrodo.AutoSize = true
        Me.chkTVUseFrodo.Location = New System.Drawing.Point(6, 21)
        Me.chkTVUseFrodo.Name = "chkTVUseFrodo"
        Me.chkTVUseFrodo.Size = New System.Drawing.Size(45, 17)
        Me.chkTVUseFrodo.TabIndex = 10
        Me.chkTVUseFrodo.Text = "Use"
        Me.chkTVUseFrodo.UseVisualStyleBackColor = true
        '
        'chkTVEpisodeActorThumbsFrodo
        '
        Me.chkTVEpisodeActorThumbsFrodo.AutoSize = true
        Me.chkTVEpisodeActorThumbsFrodo.Enabled = false
        Me.chkTVEpisodeActorThumbsFrodo.Location = New System.Drawing.Point(6, 251)
        Me.chkTVEpisodeActorThumbsFrodo.Name = "chkTVEpisodeActorThumbsFrodo"
        Me.chkTVEpisodeActorThumbsFrodo.Size = New System.Drawing.Size(140, 17)
        Me.chkTVEpisodeActorThumbsFrodo.TabIndex = 9
        Me.chkTVEpisodeActorThumbsFrodo.Text = "Epsiode Actor Thumbs"
        Me.chkTVEpisodeActorThumbsFrodo.UseVisualStyleBackColor = true
        '
        'chkTVSeasonBannerFrodo
        '
        Me.chkTVSeasonBannerFrodo.AutoSize = true
        Me.chkTVSeasonBannerFrodo.Enabled = false
        Me.chkTVSeasonBannerFrodo.Location = New System.Drawing.Point(6, 182)
        Me.chkTVSeasonBannerFrodo.Name = "chkTVSeasonBannerFrodo"
        Me.chkTVSeasonBannerFrodo.Size = New System.Drawing.Size(103, 17)
        Me.chkTVSeasonBannerFrodo.TabIndex = 8
        Me.chkTVSeasonBannerFrodo.Text = "Season Banner"
        Me.chkTVSeasonBannerFrodo.UseVisualStyleBackColor = true
        '
        'chkTVEpisodePosterFrodo
        '
        Me.chkTVEpisodePosterFrodo.AutoSize = true
        Me.chkTVEpisodePosterFrodo.Enabled = false
        Me.chkTVEpisodePosterFrodo.Location = New System.Drawing.Point(6, 205)
        Me.chkTVEpisodePosterFrodo.Name = "chkTVEpisodePosterFrodo"
        Me.chkTVEpisodePosterFrodo.Size = New System.Drawing.Size(102, 17)
        Me.chkTVEpisodePosterFrodo.TabIndex = 5
        Me.chkTVEpisodePosterFrodo.Text = "Episode Poster"
        Me.chkTVEpisodePosterFrodo.UseVisualStyleBackColor = true
        '
        'chkTVShowActorThumbsFrodo
        '
        Me.chkTVShowActorThumbsFrodo.AutoSize = true
        Me.chkTVShowActorThumbsFrodo.Enabled = false
        Me.chkTVShowActorThumbsFrodo.Location = New System.Drawing.Point(6, 90)
        Me.chkTVShowActorThumbsFrodo.Name = "chkTVShowActorThumbsFrodo"
        Me.chkTVShowActorThumbsFrodo.Size = New System.Drawing.Size(128, 17)
        Me.chkTVShowActorThumbsFrodo.TabIndex = 4
        Me.chkTVShowActorThumbsFrodo.Text = "Show Actor Thumbs"
        Me.chkTVShowActorThumbsFrodo.UseVisualStyleBackColor = true
        '
        'chkTVSeasonFanartFrodo
        '
        Me.chkTVSeasonFanartFrodo.AutoSize = true
        Me.chkTVSeasonFanartFrodo.Enabled = false
        Me.chkTVSeasonFanartFrodo.Location = New System.Drawing.Point(6, 159)
        Me.chkTVSeasonFanartFrodo.Name = "chkTVSeasonFanartFrodo"
        Me.chkTVSeasonFanartFrodo.Size = New System.Drawing.Size(99, 17)
        Me.chkTVSeasonFanartFrodo.TabIndex = 3
        Me.chkTVSeasonFanartFrodo.Text = "Season Fanart"
        Me.chkTVSeasonFanartFrodo.UseVisualStyleBackColor = true
        '
        'chkTVShowFanartFrodo
        '
        Me.chkTVShowFanartFrodo.AutoSize = true
        Me.chkTVShowFanartFrodo.Enabled = false
        Me.chkTVShowFanartFrodo.Location = New System.Drawing.Point(6, 67)
        Me.chkTVShowFanartFrodo.Name = "chkTVShowFanartFrodo"
        Me.chkTVShowFanartFrodo.Size = New System.Drawing.Size(91, 17)
        Me.chkTVShowFanartFrodo.TabIndex = 2
        Me.chkTVShowFanartFrodo.Text = "Show Fanart"
        Me.chkTVShowFanartFrodo.UseVisualStyleBackColor = true
        '
        'chkTVShowPosterFrodo
        '
        Me.chkTVShowPosterFrodo.AutoSize = true
        Me.chkTVShowPosterFrodo.Enabled = false
        Me.chkTVShowPosterFrodo.Location = New System.Drawing.Point(6, 44)
        Me.chkTVShowPosterFrodo.Name = "chkTVShowPosterFrodo"
        Me.chkTVShowPosterFrodo.Size = New System.Drawing.Size(90, 17)
        Me.chkTVShowPosterFrodo.TabIndex = 1
        Me.chkTVShowPosterFrodo.Text = "Show Poster"
        Me.chkTVShowPosterFrodo.UseVisualStyleBackColor = true
        '
        'tpTVFileNamingNMT
        '
        Me.tpTVFileNamingNMT.Controls.Add(Me.gbTVNMT)
        Me.tpTVFileNamingNMT.Controls.Add(Me.gbTVYAMJ)
        Me.tpTVFileNamingNMT.Location = New System.Drawing.Point(4, 22)
        Me.tpTVFileNamingNMT.Name = "tpTVFileNamingNMT"
        Me.tpTVFileNamingNMT.Padding = New System.Windows.Forms.Padding(3)
        Me.tpTVFileNamingNMT.Size = New System.Drawing.Size(547, 301)
        Me.tpTVFileNamingNMT.TabIndex = 1
        Me.tpTVFileNamingNMT.Text = "NMT"
        Me.tpTVFileNamingNMT.UseVisualStyleBackColor = true
        '
        'gbTVNMT
        '
        Me.gbTVNMT.Controls.Add(Me.chkTVSeasonPosterNMJ)
        Me.gbTVNMT.Controls.Add(Me.chkTVShowBannerNMJ)
        Me.gbTVNMT.Controls.Add(Me.chkTVSeasonBannerNMJ)
        Me.gbTVNMT.Controls.Add(Me.chkTVEpisodePosterNMJ)
        Me.gbTVNMT.Controls.Add(Me.chkTVSeasonFanartNMJ)
        Me.gbTVNMT.Controls.Add(Me.chkTVShowFanartNMJ)
        Me.gbTVNMT.Controls.Add(Me.chkTVShowPosterNMJ)
        Me.gbTVNMT.Controls.Add(Me.chkTVUseNMJ)
        Me.gbTVNMT.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.gbTVNMT.Location = New System.Drawing.Point(164, 9)
        Me.gbTVNMT.Name = "gbTVNMT"
        Me.gbTVNMT.Size = New System.Drawing.Size(152, 289)
        Me.gbTVNMT.TabIndex = 19
        Me.gbTVNMT.TabStop = false
        Me.gbTVNMT.Text = "NMJ"
        '
        'chkTVSeasonPosterNMJ
        '
        Me.chkTVSeasonPosterNMJ.AutoSize = true
        Me.chkTVSeasonPosterNMJ.Enabled = false
        Me.chkTVSeasonPosterNMJ.Location = New System.Drawing.Point(6, 136)
        Me.chkTVSeasonPosterNMJ.Name = "chkTVSeasonPosterNMJ"
        Me.chkTVSeasonPosterNMJ.Size = New System.Drawing.Size(98, 17)
        Me.chkTVSeasonPosterNMJ.TabIndex = 26
        Me.chkTVSeasonPosterNMJ.Text = "Season Poster"
        Me.chkTVSeasonPosterNMJ.UseVisualStyleBackColor = true
        '
        'chkTVShowBannerNMJ
        '
        Me.chkTVShowBannerNMJ.AutoSize = true
        Me.chkTVShowBannerNMJ.Enabled = false
        Me.chkTVShowBannerNMJ.Location = New System.Drawing.Point(6, 113)
        Me.chkTVShowBannerNMJ.Name = "chkTVShowBannerNMJ"
        Me.chkTVShowBannerNMJ.Size = New System.Drawing.Size(95, 17)
        Me.chkTVShowBannerNMJ.TabIndex = 25
        Me.chkTVShowBannerNMJ.Text = "Show Banner"
        Me.chkTVShowBannerNMJ.UseVisualStyleBackColor = true
        '
        'chkTVSeasonBannerNMJ
        '
        Me.chkTVSeasonBannerNMJ.AutoSize = true
        Me.chkTVSeasonBannerNMJ.Enabled = false
        Me.chkTVSeasonBannerNMJ.Location = New System.Drawing.Point(6, 182)
        Me.chkTVSeasonBannerNMJ.Name = "chkTVSeasonBannerNMJ"
        Me.chkTVSeasonBannerNMJ.Size = New System.Drawing.Size(103, 17)
        Me.chkTVSeasonBannerNMJ.TabIndex = 23
        Me.chkTVSeasonBannerNMJ.Text = "Season Banner"
        Me.chkTVSeasonBannerNMJ.UseVisualStyleBackColor = true
        '
        'chkTVEpisodePosterNMJ
        '
        Me.chkTVEpisodePosterNMJ.AutoSize = true
        Me.chkTVEpisodePosterNMJ.Enabled = false
        Me.chkTVEpisodePosterNMJ.Location = New System.Drawing.Point(6, 205)
        Me.chkTVEpisodePosterNMJ.Name = "chkTVEpisodePosterNMJ"
        Me.chkTVEpisodePosterNMJ.Size = New System.Drawing.Size(102, 17)
        Me.chkTVEpisodePosterNMJ.TabIndex = 21
        Me.chkTVEpisodePosterNMJ.Text = "Episode Poster"
        Me.chkTVEpisodePosterNMJ.UseVisualStyleBackColor = true
        '
        'chkTVSeasonFanartNMJ
        '
        Me.chkTVSeasonFanartNMJ.AutoSize = true
        Me.chkTVSeasonFanartNMJ.Enabled = false
        Me.chkTVSeasonFanartNMJ.Location = New System.Drawing.Point(6, 159)
        Me.chkTVSeasonFanartNMJ.Name = "chkTVSeasonFanartNMJ"
        Me.chkTVSeasonFanartNMJ.Size = New System.Drawing.Size(99, 17)
        Me.chkTVSeasonFanartNMJ.TabIndex = 19
        Me.chkTVSeasonFanartNMJ.Text = "Season Fanart"
        Me.chkTVSeasonFanartNMJ.UseVisualStyleBackColor = true
        '
        'chkTVShowFanartNMJ
        '
        Me.chkTVShowFanartNMJ.AutoSize = true
        Me.chkTVShowFanartNMJ.Enabled = false
        Me.chkTVShowFanartNMJ.Location = New System.Drawing.Point(6, 67)
        Me.chkTVShowFanartNMJ.Name = "chkTVShowFanartNMJ"
        Me.chkTVShowFanartNMJ.Size = New System.Drawing.Size(91, 17)
        Me.chkTVShowFanartNMJ.TabIndex = 18
        Me.chkTVShowFanartNMJ.Text = "Show Fanart"
        Me.chkTVShowFanartNMJ.UseVisualStyleBackColor = true
        '
        'chkTVShowPosterNMJ
        '
        Me.chkTVShowPosterNMJ.AutoSize = true
        Me.chkTVShowPosterNMJ.Enabled = false
        Me.chkTVShowPosterNMJ.Location = New System.Drawing.Point(6, 44)
        Me.chkTVShowPosterNMJ.Name = "chkTVShowPosterNMJ"
        Me.chkTVShowPosterNMJ.Size = New System.Drawing.Size(90, 17)
        Me.chkTVShowPosterNMJ.TabIndex = 17
        Me.chkTVShowPosterNMJ.Text = "Show Poster"
        Me.chkTVShowPosterNMJ.UseVisualStyleBackColor = true
        '
        'chkTVUseNMJ
        '
        Me.chkTVUseNMJ.AutoSize = true
        Me.chkTVUseNMJ.Location = New System.Drawing.Point(6, 21)
        Me.chkTVUseNMJ.Name = "chkTVUseNMJ"
        Me.chkTVUseNMJ.Size = New System.Drawing.Size(45, 17)
        Me.chkTVUseNMJ.TabIndex = 16
        Me.chkTVUseNMJ.Text = "Use"
        Me.chkTVUseNMJ.UseVisualStyleBackColor = true
        '
        'gbTVYAMJ
        '
        Me.gbTVYAMJ.Controls.Add(Me.chkTVSeasonPosterYAMJ)
        Me.gbTVYAMJ.Controls.Add(Me.chkTVShowBannerYAMJ)
        Me.gbTVYAMJ.Controls.Add(Me.chkTVSeasonBannerYAMJ)
        Me.gbTVYAMJ.Controls.Add(Me.chkTVEpisodePosterYAMJ)
        Me.gbTVYAMJ.Controls.Add(Me.chkTVSeasonFanartYAMJ)
        Me.gbTVYAMJ.Controls.Add(Me.chkTVShowFanartYAMJ)
        Me.gbTVYAMJ.Controls.Add(Me.chkTVShowPosterYAMJ)
        Me.gbTVYAMJ.Controls.Add(Me.chkTVUseYAMJ)
        Me.gbTVYAMJ.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.gbTVYAMJ.Location = New System.Drawing.Point(6, 6)
        Me.gbTVYAMJ.Name = "gbTVYAMJ"
        Me.gbTVYAMJ.Size = New System.Drawing.Size(152, 289)
        Me.gbTVYAMJ.TabIndex = 18
        Me.gbTVYAMJ.TabStop = false
        Me.gbTVYAMJ.Text = "YAMJ"
        '
        'chkTVSeasonPosterYAMJ
        '
        Me.chkTVSeasonPosterYAMJ.AutoSize = true
        Me.chkTVSeasonPosterYAMJ.Enabled = false
        Me.chkTVSeasonPosterYAMJ.Location = New System.Drawing.Point(6, 136)
        Me.chkTVSeasonPosterYAMJ.Name = "chkTVSeasonPosterYAMJ"
        Me.chkTVSeasonPosterYAMJ.Size = New System.Drawing.Size(98, 17)
        Me.chkTVSeasonPosterYAMJ.TabIndex = 26
        Me.chkTVSeasonPosterYAMJ.Text = "Season Poster"
        Me.chkTVSeasonPosterYAMJ.UseVisualStyleBackColor = true
        '
        'chkTVShowBannerYAMJ
        '
        Me.chkTVShowBannerYAMJ.AutoSize = true
        Me.chkTVShowBannerYAMJ.Enabled = false
        Me.chkTVShowBannerYAMJ.Location = New System.Drawing.Point(6, 113)
        Me.chkTVShowBannerYAMJ.Name = "chkTVShowBannerYAMJ"
        Me.chkTVShowBannerYAMJ.Size = New System.Drawing.Size(95, 17)
        Me.chkTVShowBannerYAMJ.TabIndex = 25
        Me.chkTVShowBannerYAMJ.Text = "Show Banner"
        Me.chkTVShowBannerYAMJ.UseVisualStyleBackColor = true
        '
        'chkTVSeasonBannerYAMJ
        '
        Me.chkTVSeasonBannerYAMJ.AutoSize = true
        Me.chkTVSeasonBannerYAMJ.Enabled = false
        Me.chkTVSeasonBannerYAMJ.Location = New System.Drawing.Point(6, 182)
        Me.chkTVSeasonBannerYAMJ.Name = "chkTVSeasonBannerYAMJ"
        Me.chkTVSeasonBannerYAMJ.Size = New System.Drawing.Size(103, 17)
        Me.chkTVSeasonBannerYAMJ.TabIndex = 23
        Me.chkTVSeasonBannerYAMJ.Text = "Season Banner"
        Me.chkTVSeasonBannerYAMJ.UseVisualStyleBackColor = true
        '
        'chkTVEpisodePosterYAMJ
        '
        Me.chkTVEpisodePosterYAMJ.AutoSize = true
        Me.chkTVEpisodePosterYAMJ.Enabled = false
        Me.chkTVEpisodePosterYAMJ.Location = New System.Drawing.Point(6, 205)
        Me.chkTVEpisodePosterYAMJ.Name = "chkTVEpisodePosterYAMJ"
        Me.chkTVEpisodePosterYAMJ.Size = New System.Drawing.Size(102, 17)
        Me.chkTVEpisodePosterYAMJ.TabIndex = 21
        Me.chkTVEpisodePosterYAMJ.Text = "Episode Poster"
        Me.chkTVEpisodePosterYAMJ.UseVisualStyleBackColor = true
        '
        'chkTVSeasonFanartYAMJ
        '
        Me.chkTVSeasonFanartYAMJ.AutoSize = true
        Me.chkTVSeasonFanartYAMJ.Enabled = false
        Me.chkTVSeasonFanartYAMJ.Location = New System.Drawing.Point(6, 159)
        Me.chkTVSeasonFanartYAMJ.Name = "chkTVSeasonFanartYAMJ"
        Me.chkTVSeasonFanartYAMJ.Size = New System.Drawing.Size(99, 17)
        Me.chkTVSeasonFanartYAMJ.TabIndex = 19
        Me.chkTVSeasonFanartYAMJ.Text = "Season Fanart"
        Me.chkTVSeasonFanartYAMJ.UseVisualStyleBackColor = true
        '
        'chkTVShowFanartYAMJ
        '
        Me.chkTVShowFanartYAMJ.AutoSize = true
        Me.chkTVShowFanartYAMJ.Enabled = false
        Me.chkTVShowFanartYAMJ.Location = New System.Drawing.Point(6, 67)
        Me.chkTVShowFanartYAMJ.Name = "chkTVShowFanartYAMJ"
        Me.chkTVShowFanartYAMJ.Size = New System.Drawing.Size(91, 17)
        Me.chkTVShowFanartYAMJ.TabIndex = 18
        Me.chkTVShowFanartYAMJ.Text = "Show Fanart"
        Me.chkTVShowFanartYAMJ.UseVisualStyleBackColor = true
        '
        'chkTVShowPosterYAMJ
        '
        Me.chkTVShowPosterYAMJ.AutoSize = true
        Me.chkTVShowPosterYAMJ.Enabled = false
        Me.chkTVShowPosterYAMJ.Location = New System.Drawing.Point(6, 44)
        Me.chkTVShowPosterYAMJ.Name = "chkTVShowPosterYAMJ"
        Me.chkTVShowPosterYAMJ.Size = New System.Drawing.Size(90, 17)
        Me.chkTVShowPosterYAMJ.TabIndex = 17
        Me.chkTVShowPosterYAMJ.Text = "Show Poster"
        Me.chkTVShowPosterYAMJ.UseVisualStyleBackColor = true
        '
        'chkTVUseYAMJ
        '
        Me.chkTVUseYAMJ.AutoSize = true
        Me.chkTVUseYAMJ.Location = New System.Drawing.Point(6, 21)
        Me.chkTVUseYAMJ.Name = "chkTVUseYAMJ"
        Me.chkTVUseYAMJ.Size = New System.Drawing.Size(45, 17)
        Me.chkTVUseYAMJ.TabIndex = 16
        Me.chkTVUseYAMJ.Text = "Use"
        Me.chkTVUseYAMJ.UseVisualStyleBackColor = true
        '
        'tpTVFileNamingExpert
        '
        Me.tpTVFileNamingExpert.Location = New System.Drawing.Point(4, 22)
        Me.tpTVFileNamingExpert.Name = "tpTVFileNamingExpert"
        Me.tpTVFileNamingExpert.Size = New System.Drawing.Size(547, 301)
        Me.tpTVFileNamingExpert.TabIndex = 2
        Me.tpTVFileNamingExpert.Text = "Expert"
        Me.tpTVFileNamingExpert.UseVisualStyleBackColor = true
        '
        'lvTVSources
        '
        Me.lvTVSources.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.lvTVSources.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.lvTVSources.FullRowSelect = true
        Me.lvTVSources.HideSelection = false
        Me.lvTVSources.Location = New System.Drawing.Point(6, 4)
        Me.lvTVSources.Name = "lvTVSources"
        Me.lvTVSources.Size = New System.Drawing.Size(614, 105)
        Me.lvTVSources.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.lvTVSources.TabIndex = 0
        Me.lvTVSources.UseCompatibleStateImageBehavior = false
        Me.lvTVSources.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Width = 0
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Name"
        Me.ColumnHeader2.Width = 94
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Path"
        Me.ColumnHeader3.Width = 368
        '
        'gbTVSourcesMiscOpts
        '
        Me.gbTVSourcesMiscOpts.Controls.Add(Me.TVSkipLessThanMB)
        Me.gbTVSourcesMiscOpts.Controls.Add(Me.txtTVSkipLessThan)
        Me.gbTVSourcesMiscOpts.Controls.Add(Me.lblTVSkipLessThan)
        Me.gbTVSourcesMiscOpts.Controls.Add(Me.chkTVScanOrderModify)
        Me.gbTVSourcesMiscOpts.Controls.Add(Me.chkTVGeneralIgnoreLastScan)
        Me.gbTVSourcesMiscOpts.Controls.Add(Me.chkTVCleanDB)
        Me.gbTVSourcesMiscOpts.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.gbTVSourcesMiscOpts.Location = New System.Drawing.Point(6, 110)
        Me.gbTVSourcesMiscOpts.Name = "gbTVSourcesMiscOpts"
        Me.gbTVSourcesMiscOpts.Size = New System.Drawing.Size(151, 188)
        Me.gbTVSourcesMiscOpts.TabIndex = 4
        Me.gbTVSourcesMiscOpts.TabStop = false
        Me.gbTVSourcesMiscOpts.Text = "Miscellaneous Options"
        '
        'TVSkipLessThanMB
        '
        Me.TVSkipLessThanMB.AutoSize = true
        Me.TVSkipLessThanMB.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.TVSkipLessThanMB.Location = New System.Drawing.Point(114, 39)
        Me.TVSkipLessThanMB.Name = "TVSkipLessThanMB"
        Me.TVSkipLessThanMB.Size = New System.Drawing.Size(24, 13)
        Me.TVSkipLessThanMB.TabIndex = 2
        Me.TVSkipLessThanMB.Text = "MB"
        '
        'txtTVSkipLessThan
        '
        Me.txtTVSkipLessThan.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtTVSkipLessThan.Location = New System.Drawing.Point(11, 34)
        Me.txtTVSkipLessThan.Name = "txtTVSkipLessThan"
        Me.txtTVSkipLessThan.Size = New System.Drawing.Size(100, 22)
        Me.txtTVSkipLessThan.TabIndex = 0
        '
        'lblTVSkipLessThan
        '
        Me.lblTVSkipLessThan.AutoSize = true
        Me.lblTVSkipLessThan.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblTVSkipLessThan.Location = New System.Drawing.Point(6, 18)
        Me.lblTVSkipLessThan.Name = "lblTVSkipLessThan"
        Me.lblTVSkipLessThan.Size = New System.Drawing.Size(122, 13)
        Me.lblTVSkipLessThan.TabIndex = 1
        Me.lblTVSkipLessThan.Text = "Skip files smaller than:"
        '
        'chkTVScanOrderModify
        '
        Me.chkTVScanOrderModify.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkTVScanOrderModify.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkTVScanOrderModify.Location = New System.Drawing.Point(4, 110)
        Me.chkTVScanOrderModify.Name = "chkTVScanOrderModify"
        Me.chkTVScanOrderModify.Size = New System.Drawing.Size(142, 43)
        Me.chkTVScanOrderModify.TabIndex = 4
        Me.chkTVScanOrderModify.Text = "Scan in order of last write time"
        Me.chkTVScanOrderModify.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkTVScanOrderModify.UseVisualStyleBackColor = true
        '
        'chkTVGeneralIgnoreLastScan
        '
        Me.chkTVGeneralIgnoreLastScan.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkTVGeneralIgnoreLastScan.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkTVGeneralIgnoreLastScan.Location = New System.Drawing.Point(4, 68)
        Me.chkTVGeneralIgnoreLastScan.Name = "chkTVGeneralIgnoreLastScan"
        Me.chkTVGeneralIgnoreLastScan.Size = New System.Drawing.Size(142, 43)
        Me.chkTVGeneralIgnoreLastScan.TabIndex = 3
        Me.chkTVGeneralIgnoreLastScan.Text = "Ignore last scan time when updating library"
        Me.chkTVGeneralIgnoreLastScan.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkTVGeneralIgnoreLastScan.UseVisualStyleBackColor = true
        '
        'chkTVCleanDB
        '
        Me.chkTVCleanDB.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkTVCleanDB.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkTVCleanDB.Location = New System.Drawing.Point(4, 152)
        Me.chkTVCleanDB.Name = "chkTVCleanDB"
        Me.chkTVCleanDB.Size = New System.Drawing.Size(142, 43)
        Me.chkTVCleanDB.TabIndex = 5
        Me.chkTVCleanDB.Text = "Clean database after updating library"
        Me.chkTVCleanDB.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkTVCleanDB.UseVisualStyleBackColor = true
        '
        'btnTVSourceAdd
        '
        Me.btnTVSourceAdd.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.btnTVSourceAdd.Image = CType(resources.GetObject("btnTVSourceAdd.Image"),System.Drawing.Image)
        Me.btnTVSourceAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTVSourceAdd.Location = New System.Drawing.Point(626, 4)
        Me.btnTVSourceAdd.Name = "btnTVSourceAdd"
        Me.btnTVSourceAdd.Size = New System.Drawing.Size(104, 23)
        Me.btnTVSourceAdd.TabIndex = 1
        Me.btnTVSourceAdd.Text = "Add Source"
        Me.btnTVSourceAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnTVSourceAdd.UseVisualStyleBackColor = true
        '
        'btnTVSourceEdit
        '
        Me.btnTVSourceEdit.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.btnTVSourceEdit.Image = CType(resources.GetObject("btnTVSourceEdit.Image"),System.Drawing.Image)
        Me.btnTVSourceEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTVSourceEdit.Location = New System.Drawing.Point(626, 34)
        Me.btnTVSourceEdit.Name = "btnTVSourceEdit"
        Me.btnTVSourceEdit.Size = New System.Drawing.Size(104, 23)
        Me.btnTVSourceEdit.TabIndex = 2
        Me.btnTVSourceEdit.Text = "Edit Source"
        Me.btnTVSourceEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnTVSourceEdit.UseVisualStyleBackColor = true
        '
        'btnRemTVSource
        '
        Me.btnRemTVSource.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.btnRemTVSource.Image = CType(resources.GetObject("btnRemTVSource.Image"),System.Drawing.Image)
        Me.btnRemTVSource.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRemTVSource.Location = New System.Drawing.Point(626, 86)
        Me.btnRemTVSource.Name = "btnRemTVSource"
        Me.btnRemTVSource.Size = New System.Drawing.Size(104, 23)
        Me.btnRemTVSource.TabIndex = 3
        Me.btnRemTVSource.Text = "Remove"
        Me.btnRemTVSource.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRemTVSource.UseVisualStyleBackColor = true
        '
        'tpTVSourcesRegex
        '
        Me.tpTVSourcesRegex.Controls.Add(Me.btnTVShowRegexGet)
        Me.tpTVSourcesRegex.Controls.Add(Me.btnTVShowRegexDown)
        Me.tpTVSourcesRegex.Controls.Add(Me.btnTVShowRegexUp)
        Me.tpTVSourcesRegex.Controls.Add(Me.btnTVShowRegexReset)
        Me.tpTVSourcesRegex.Controls.Add(Me.gbTVShowRegex)
        Me.tpTVSourcesRegex.Controls.Add(Me.btnTVShowRegexEdit)
        Me.tpTVSourcesRegex.Controls.Add(Me.btnTVShowRegexRemove)
        Me.tpTVSourcesRegex.Controls.Add(Me.lvTVShowRegex)
        Me.tpTVSourcesRegex.Location = New System.Drawing.Point(4, 22)
        Me.tpTVSourcesRegex.Name = "tpTVSourcesRegex"
        Me.tpTVSourcesRegex.Padding = New System.Windows.Forms.Padding(3)
        Me.tpTVSourcesRegex.Size = New System.Drawing.Size(736, 467)
        Me.tpTVSourcesRegex.TabIndex = 1
        Me.tpTVSourcesRegex.Text = "Regex"
        Me.tpTVSourcesRegex.UseVisualStyleBackColor = true
        '
        'btnTVShowRegexGet
        '
        Me.btnTVShowRegexGet.Image = CType(resources.GetObject("btnTVShowRegexGet.Image"),System.Drawing.Image)
        Me.btnTVShowRegexGet.Location = New System.Drawing.Point(550, 3)
        Me.btnTVShowRegexGet.Name = "btnTVShowRegexGet"
        Me.btnTVShowRegexGet.Size = New System.Drawing.Size(23, 23)
        Me.btnTVShowRegexGet.TabIndex = 1
        Me.btnTVShowRegexGet.UseVisualStyleBackColor = true
        '
        'btnTVShowRegexDown
        '
        Me.btnTVShowRegexDown.Image = CType(resources.GetObject("btnTVShowRegexDown.Image"),System.Drawing.Image)
        Me.btnTVShowRegexDown.Location = New System.Drawing.Point(304, 167)
        Me.btnTVShowRegexDown.Name = "btnTVShowRegexDown"
        Me.btnTVShowRegexDown.Size = New System.Drawing.Size(23, 23)
        Me.btnTVShowRegexDown.TabIndex = 5
        Me.btnTVShowRegexDown.UseVisualStyleBackColor = true
        '
        'btnTVShowRegexUp
        '
        Me.btnTVShowRegexUp.Image = CType(resources.GetObject("btnTVShowRegexUp.Image"),System.Drawing.Image)
        Me.btnTVShowRegexUp.Location = New System.Drawing.Point(280, 167)
        Me.btnTVShowRegexUp.Name = "btnTVShowRegexUp"
        Me.btnTVShowRegexUp.Size = New System.Drawing.Size(23, 23)
        Me.btnTVShowRegexUp.TabIndex = 4
        Me.btnTVShowRegexUp.UseVisualStyleBackColor = true
        '
        'btnTVShowRegexReset
        '
        Me.btnTVShowRegexReset.Image = CType(resources.GetObject("btnTVShowRegexReset.Image"),System.Drawing.Image)
        Me.btnTVShowRegexReset.Location = New System.Drawing.Point(576, 3)
        Me.btnTVShowRegexReset.Name = "btnTVShowRegexReset"
        Me.btnTVShowRegexReset.Size = New System.Drawing.Size(23, 23)
        Me.btnTVShowRegexReset.TabIndex = 2
        Me.btnTVShowRegexReset.UseVisualStyleBackColor = true
        '
        'gbTVShowRegex
        '
        Me.gbTVShowRegex.Controls.Add(Me.btnTVShowRegexClear)
        Me.gbTVShowRegex.Controls.Add(Me.lblTVSeasonMatch)
        Me.gbTVShowRegex.Controls.Add(Me.btnTVShowRegexAdd)
        Me.gbTVShowRegex.Controls.Add(Me.txtTVSeasonRegex)
        Me.gbTVShowRegex.Controls.Add(Me.lblTVEpisodeRetrieve)
        Me.gbTVShowRegex.Controls.Add(Me.cbTVSeasonRetrieve)
        Me.gbTVShowRegex.Controls.Add(Me.lblTVSeasonRetrieve)
        Me.gbTVShowRegex.Controls.Add(Me.txtTVEpisodeRegex)
        Me.gbTVShowRegex.Controls.Add(Me.lblTVEpisodeMatch)
        Me.gbTVShowRegex.Controls.Add(Me.cbTVEpisodeRetrieve)
        Me.gbTVShowRegex.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.gbTVShowRegex.Location = New System.Drawing.Point(6, 196)
        Me.gbTVShowRegex.Name = "gbTVShowRegex"
        Me.gbTVShowRegex.Size = New System.Drawing.Size(592, 148)
        Me.gbTVShowRegex.TabIndex = 7
        Me.gbTVShowRegex.TabStop = false
        Me.gbTVShowRegex.Text = "Show Match Regex"
        '
        'btnTVShowRegexClear
        '
        Me.btnTVShowRegexClear.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.btnTVShowRegexClear.Image = CType(resources.GetObject("btnTVShowRegexClear.Image"),System.Drawing.Image)
        Me.btnTVShowRegexClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTVShowRegexClear.Location = New System.Drawing.Point(10, 116)
        Me.btnTVShowRegexClear.Name = "btnTVShowRegexClear"
        Me.btnTVShowRegexClear.Size = New System.Drawing.Size(104, 23)
        Me.btnTVShowRegexClear.TabIndex = 8
        Me.btnTVShowRegexClear.Text = "Clear"
        Me.btnTVShowRegexClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnTVShowRegexClear.UseVisualStyleBackColor = true
        '
        'lblTVSeasonMatch
        '
        Me.lblTVSeasonMatch.AutoSize = true
        Me.lblTVSeasonMatch.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblTVSeasonMatch.Location = New System.Drawing.Point(8, 25)
        Me.lblTVSeasonMatch.Name = "lblTVSeasonMatch"
        Me.lblTVSeasonMatch.Size = New System.Drawing.Size(116, 13)
        Me.lblTVSeasonMatch.TabIndex = 0
        Me.lblTVSeasonMatch.Text = "Season Match Regex:"
        '
        'btnTVShowRegexAdd
        '
        Me.btnTVShowRegexAdd.Enabled = false
        Me.btnTVShowRegexAdd.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.btnTVShowRegexAdd.Image = CType(resources.GetObject("btnTVShowRegexAdd.Image"),System.Drawing.Image)
        Me.btnTVShowRegexAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTVShowRegexAdd.Location = New System.Drawing.Point(482, 117)
        Me.btnTVShowRegexAdd.Name = "btnTVShowRegexAdd"
        Me.btnTVShowRegexAdd.Size = New System.Drawing.Size(104, 23)
        Me.btnTVShowRegexAdd.TabIndex = 9
        Me.btnTVShowRegexAdd.Text = "Add Regex"
        Me.btnTVShowRegexAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnTVShowRegexAdd.UseVisualStyleBackColor = true
        '
        'txtTVSeasonRegex
        '
        Me.txtTVSeasonRegex.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtTVSeasonRegex.Location = New System.Drawing.Point(10, 40)
        Me.txtTVSeasonRegex.Name = "txtTVSeasonRegex"
        Me.txtTVSeasonRegex.Size = New System.Drawing.Size(417, 22)
        Me.txtTVSeasonRegex.TabIndex = 1
        '
        'lblTVEpisodeRetrieve
        '
        Me.lblTVEpisodeRetrieve.AutoSize = true
        Me.lblTVEpisodeRetrieve.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblTVEpisodeRetrieve.Location = New System.Drawing.Point(441, 69)
        Me.lblTVEpisodeRetrieve.Name = "lblTVEpisodeRetrieve"
        Me.lblTVEpisodeRetrieve.Size = New System.Drawing.Size(54, 13)
        Me.lblTVEpisodeRetrieve.TabIndex = 6
        Me.lblTVEpisodeRetrieve.Text = "Apply To:"
        '
        'cbTVSeasonRetrieve
        '
        Me.cbTVSeasonRetrieve.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTVSeasonRetrieve.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.cbTVSeasonRetrieve.FormattingEnabled = true
        Me.cbTVSeasonRetrieve.Items.AddRange(New Object() {"Folder Name", "File Name"})
        Me.cbTVSeasonRetrieve.Location = New System.Drawing.Point(443, 40)
        Me.cbTVSeasonRetrieve.Name = "cbTVSeasonRetrieve"
        Me.cbTVSeasonRetrieve.Size = New System.Drawing.Size(135, 21)
        Me.cbTVSeasonRetrieve.TabIndex = 3
        '
        'lblTVSeasonRetrieve
        '
        Me.lblTVSeasonRetrieve.AutoSize = true
        Me.lblTVSeasonRetrieve.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblTVSeasonRetrieve.Location = New System.Drawing.Point(441, 25)
        Me.lblTVSeasonRetrieve.Name = "lblTVSeasonRetrieve"
        Me.lblTVSeasonRetrieve.Size = New System.Drawing.Size(54, 13)
        Me.lblTVSeasonRetrieve.TabIndex = 2
        Me.lblTVSeasonRetrieve.Text = "Apply To:"
        '
        'txtTVEpisodeRegex
        '
        Me.txtTVEpisodeRegex.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtTVEpisodeRegex.Location = New System.Drawing.Point(10, 84)
        Me.txtTVEpisodeRegex.Name = "txtTVEpisodeRegex"
        Me.txtTVEpisodeRegex.Size = New System.Drawing.Size(417, 22)
        Me.txtTVEpisodeRegex.TabIndex = 5
        '
        'lblTVEpisodeMatch
        '
        Me.lblTVEpisodeMatch.AutoSize = true
        Me.lblTVEpisodeMatch.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblTVEpisodeMatch.Location = New System.Drawing.Point(8, 69)
        Me.lblTVEpisodeMatch.Name = "lblTVEpisodeMatch"
        Me.lblTVEpisodeMatch.Size = New System.Drawing.Size(120, 13)
        Me.lblTVEpisodeMatch.TabIndex = 4
        Me.lblTVEpisodeMatch.Text = "Episode Match Regex:"
        '
        'cbTVEpisodeRetrieve
        '
        Me.cbTVEpisodeRetrieve.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTVEpisodeRetrieve.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.cbTVEpisodeRetrieve.FormattingEnabled = true
        Me.cbTVEpisodeRetrieve.Items.AddRange(New Object() {"Folder Name", "File Name", "Season Result"})
        Me.cbTVEpisodeRetrieve.Location = New System.Drawing.Point(443, 84)
        Me.cbTVEpisodeRetrieve.Name = "cbTVEpisodeRetrieve"
        Me.cbTVEpisodeRetrieve.Size = New System.Drawing.Size(135, 21)
        Me.cbTVEpisodeRetrieve.TabIndex = 7
        '
        'btnTVShowRegexEdit
        '
        Me.btnTVShowRegexEdit.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.btnTVShowRegexEdit.Image = CType(resources.GetObject("btnTVShowRegexEdit.Image"),System.Drawing.Image)
        Me.btnTVShowRegexEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTVShowRegexEdit.Location = New System.Drawing.Point(1, 167)
        Me.btnTVShowRegexEdit.Name = "btnTVShowRegexEdit"
        Me.btnTVShowRegexEdit.Size = New System.Drawing.Size(104, 23)
        Me.btnTVShowRegexEdit.TabIndex = 3
        Me.btnTVShowRegexEdit.Text = "Edit Regex"
        Me.btnTVShowRegexEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnTVShowRegexEdit.UseVisualStyleBackColor = true
        '
        'btnTVShowRegexRemove
        '
        Me.btnTVShowRegexRemove.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.btnTVShowRegexRemove.Image = CType(resources.GetObject("btnTVShowRegexRemove.Image"),System.Drawing.Image)
        Me.btnTVShowRegexRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTVShowRegexRemove.Location = New System.Drawing.Point(494, 167)
        Me.btnTVShowRegexRemove.Name = "btnTVShowRegexRemove"
        Me.btnTVShowRegexRemove.Size = New System.Drawing.Size(104, 23)
        Me.btnTVShowRegexRemove.TabIndex = 6
        Me.btnTVShowRegexRemove.Text = "Remove"
        Me.btnTVShowRegexRemove.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnTVShowRegexRemove.UseVisualStyleBackColor = true
        '
        'lvTVShowRegex
        '
        Me.lvTVShowRegex.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colTVShowRegexID, Me.colTVShowRegexSeason, Me.colTVShowRegexSeasonApply, Me.colTVShowRegexEpisode, Me.colTVShowRegexEpisodeApply})
        Me.lvTVShowRegex.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.lvTVShowRegex.FullRowSelect = true
        Me.lvTVShowRegex.HideSelection = false
        Me.lvTVShowRegex.Location = New System.Drawing.Point(0, 28)
        Me.lvTVShowRegex.Name = "lvTVShowRegex"
        Me.lvTVShowRegex.Size = New System.Drawing.Size(598, 135)
        Me.lvTVShowRegex.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.lvTVShowRegex.TabIndex = 0
        Me.lvTVShowRegex.UseCompatibleStateImageBehavior = false
        Me.lvTVShowRegex.View = System.Windows.Forms.View.Details
        '
        'colTVShowRegexID
        '
        Me.colTVShowRegexID.DisplayIndex = 4
        Me.colTVShowRegexID.Width = 0
        '
        'colTVShowRegexSeason
        '
        Me.colTVShowRegexSeason.DisplayIndex = 0
        Me.colTVShowRegexSeason.Text = "Season Regex"
        Me.colTVShowRegexSeason.Width = 224
        '
        'colTVShowRegexSeasonApply
        '
        Me.colTVShowRegexSeasonApply.DisplayIndex = 1
        Me.colTVShowRegexSeasonApply.Text = "Apply To"
        Me.colTVShowRegexSeasonApply.Width = 70
        '
        'colTVShowRegexEpisode
        '
        Me.colTVShowRegexEpisode.DisplayIndex = 2
        Me.colTVShowRegexEpisode.Text = "Episode Regex"
        Me.colTVShowRegexEpisode.Width = 219
        '
        'colTVShowRegexEpisodeApply
        '
        Me.colTVShowRegexEpisodeApply.DisplayIndex = 3
        Me.colTVShowRegexEpisodeApply.Text = "Apply To"
        Me.colTVShowRegexEpisodeApply.Width = 70
        '
        'pnlTVImages
        '
        Me.pnlTVImages.BackColor = System.Drawing.Color.White
<<<<<<< HEAD
        Me.pnlTVImages.Controls.Add(Me.TabControl3)
        Me.pnlTVImages.Location = New System.Drawing.Point(1100, 650)
=======
        Me.pnlTVImages.Controls.Add(Me.tcTVImages)
        Me.pnlTVImages.Location = New System.Drawing.Point(900, 900)
>>>>>>> upstream/master
        Me.pnlTVImages.Name = "pnlTVImages"
        Me.pnlTVImages.Size = New System.Drawing.Size(750, 500)
        Me.pnlTVImages.TabIndex = 16
        Me.pnlTVImages.Visible = false
        '
        'tcTVImages
        '
        Me.tcTVImages.Controls.Add(Me.tpTVShow)
        Me.tcTVImages.Controls.Add(Me.tpTVAllSeasons)
        Me.tcTVImages.Controls.Add(Me.tpTVSeason)
        Me.tcTVImages.Controls.Add(Me.tpTVEpisode)
        Me.tcTVImages.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.tcTVImages.Location = New System.Drawing.Point(5, 6)
        Me.tcTVImages.Name = "tcTVImages"
        Me.tcTVImages.SelectedIndex = 0
        Me.tcTVImages.Size = New System.Drawing.Size(742, 491)
        Me.tcTVImages.TabIndex = 0
        '
        'tpTVShow
        '
        Me.tpTVShow.Controls.Add(Me.gbTVShowCharacterArtOpts)
        Me.tpTVShow.Controls.Add(Me.gbTVShowClearArtOpts)
        Me.tpTVShow.Controls.Add(Me.gbTVShowClearLogoOpts)
        Me.tpTVShow.Controls.Add(Me.gbTVShowLandscapeOpts)
        Me.tpTVShow.Controls.Add(Me.gbTVShowBannerOpts)
        Me.tpTVShow.Controls.Add(Me.gbTVShowPosterOpts)
        Me.tpTVShow.Controls.Add(Me.gbTVShowFanartOpts)
        Me.tpTVShow.Location = New System.Drawing.Point(4, 22)
        Me.tpTVShow.Name = "tpTVShow"
        Me.tpTVShow.Padding = New System.Windows.Forms.Padding(3)
        Me.tpTVShow.Size = New System.Drawing.Size(734, 465)
        Me.tpTVShow.TabIndex = 0
        Me.tpTVShow.Text = "TV Show"
        Me.tpTVShow.UseVisualStyleBackColor = true
        '
        'gbTVShowCharacterArtOpts
        '
        Me.gbTVShowCharacterArtOpts.Controls.Add(Me.chkTVShowCharacterArtOverwrite)
        Me.gbTVShowCharacterArtOpts.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.gbTVShowCharacterArtOpts.Location = New System.Drawing.Point(240, 179)
        Me.gbTVShowCharacterArtOpts.Name = "gbTVShowCharacterArtOpts"
        Me.gbTVShowCharacterArtOpts.Size = New System.Drawing.Size(228, 44)
        Me.gbTVShowCharacterArtOpts.TabIndex = 6
        Me.gbTVShowCharacterArtOpts.TabStop = false
        Me.gbTVShowCharacterArtOpts.Text = "CharacterArt"
        '
        'chkTVShowCharacterArtOverwrite
        '
        Me.chkTVShowCharacterArtOverwrite.AutoSize = true
        Me.chkTVShowCharacterArtOverwrite.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkTVShowCharacterArtOverwrite.Location = New System.Drawing.Point(6, 21)
        Me.chkTVShowCharacterArtOverwrite.Name = "chkTVShowCharacterArtOverwrite"
        Me.chkTVShowCharacterArtOverwrite.Size = New System.Drawing.Size(119, 17)
        Me.chkTVShowCharacterArtOverwrite.TabIndex = 4
        Me.chkTVShowCharacterArtOverwrite.Text = "Overwrite Existing"
        Me.chkTVShowCharacterArtOverwrite.UseVisualStyleBackColor = true
        '
        'gbTVShowClearArtOpts
        '
        Me.gbTVShowClearArtOpts.Controls.Add(Me.chkTVShowClearArtOverwrite)
        Me.gbTVShowClearArtOpts.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.gbTVShowClearArtOpts.Location = New System.Drawing.Point(6, 229)
        Me.gbTVShowClearArtOpts.Name = "gbTVShowClearArtOpts"
        Me.gbTVShowClearArtOpts.Size = New System.Drawing.Size(228, 44)
        Me.gbTVShowClearArtOpts.TabIndex = 5
        Me.gbTVShowClearArtOpts.TabStop = false
        Me.gbTVShowClearArtOpts.Text = "ClearArt"
        '
        'chkTVShowClearArtOverwrite
        '
        Me.chkTVShowClearArtOverwrite.AutoSize = true
        Me.chkTVShowClearArtOverwrite.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkTVShowClearArtOverwrite.Location = New System.Drawing.Point(6, 21)
        Me.chkTVShowClearArtOverwrite.Name = "chkTVShowClearArtOverwrite"
        Me.chkTVShowClearArtOverwrite.Size = New System.Drawing.Size(119, 17)
        Me.chkTVShowClearArtOverwrite.TabIndex = 4
        Me.chkTVShowClearArtOverwrite.Text = "Overwrite Existing"
        Me.chkTVShowClearArtOverwrite.UseVisualStyleBackColor = true
        '
        'gbTVShowClearLogoOpts
        '
        Me.gbTVShowClearLogoOpts.Controls.Add(Me.chkTVShowClearLogoOverwrite)
        Me.gbTVShowClearLogoOpts.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.gbTVShowClearLogoOpts.Location = New System.Drawing.Point(240, 229)
        Me.gbTVShowClearLogoOpts.Name = "gbTVShowClearLogoOpts"
        Me.gbTVShowClearLogoOpts.Size = New System.Drawing.Size(228, 44)
        Me.gbTVShowClearLogoOpts.TabIndex = 4
        Me.gbTVShowClearLogoOpts.TabStop = false
        Me.gbTVShowClearLogoOpts.Text = "ClearLogo"
        '
        'chkTVShowClearLogoOverwrite
        '
        Me.chkTVShowClearLogoOverwrite.AutoSize = true
        Me.chkTVShowClearLogoOverwrite.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkTVShowClearLogoOverwrite.Location = New System.Drawing.Point(6, 21)
        Me.chkTVShowClearLogoOverwrite.Name = "chkTVShowClearLogoOverwrite"
        Me.chkTVShowClearLogoOverwrite.Size = New System.Drawing.Size(119, 17)
        Me.chkTVShowClearLogoOverwrite.TabIndex = 4
        Me.chkTVShowClearLogoOverwrite.Text = "Overwrite Existing"
        Me.chkTVShowClearLogoOverwrite.UseVisualStyleBackColor = true
        '
        'gbTVShowLandscapeOpts
        '
        Me.gbTVShowLandscapeOpts.Controls.Add(Me.chkTVShowLandscapeOverwrite)
        Me.gbTVShowLandscapeOpts.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.gbTVShowLandscapeOpts.Location = New System.Drawing.Point(6, 179)
        Me.gbTVShowLandscapeOpts.Name = "gbTVShowLandscapeOpts"
        Me.gbTVShowLandscapeOpts.Size = New System.Drawing.Size(228, 44)
        Me.gbTVShowLandscapeOpts.TabIndex = 3
        Me.gbTVShowLandscapeOpts.TabStop = false
        Me.gbTVShowLandscapeOpts.Text = "Landscape"
        '
        'chkTVShowLandscapeOverwrite
        '
        Me.chkTVShowLandscapeOverwrite.AutoSize = true
        Me.chkTVShowLandscapeOverwrite.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkTVShowLandscapeOverwrite.Location = New System.Drawing.Point(6, 21)
        Me.chkTVShowLandscapeOverwrite.Name = "chkTVShowLandscapeOverwrite"
        Me.chkTVShowLandscapeOverwrite.Size = New System.Drawing.Size(119, 17)
        Me.chkTVShowLandscapeOverwrite.TabIndex = 4
        Me.chkTVShowLandscapeOverwrite.Text = "Overwrite Existing"
        Me.chkTVShowLandscapeOverwrite.UseVisualStyleBackColor = true
        '
        'gbTVShowBannerOpts
        '
        Me.gbTVShowBannerOpts.Controls.Add(Me.txtTVShowBannerWidth)
        Me.gbTVShowBannerOpts.Controls.Add(Me.txtTVShowBannerHeight)
        Me.gbTVShowBannerOpts.Controls.Add(Me.lblTVShowBannerQual)
        Me.gbTVShowBannerOpts.Controls.Add(Me.tbTVShowBannerQual)
        Me.gbTVShowBannerOpts.Controls.Add(Me.lblTVShowBannerQ)
        Me.gbTVShowBannerOpts.Controls.Add(Me.lblTVShowBannerWidth)
        Me.gbTVShowBannerOpts.Controls.Add(Me.lblTVShowBannerHeight)
        Me.gbTVShowBannerOpts.Controls.Add(Me.chkTVShowBannerResize)
        Me.gbTVShowBannerOpts.Controls.Add(Me.lblTVShowBannerType)
        Me.gbTVShowBannerOpts.Controls.Add(Me.cbTVShowBannerPrefType)
        Me.gbTVShowBannerOpts.Controls.Add(Me.chkTVShowBannerOverwrite)
        Me.gbTVShowBannerOpts.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.gbTVShowBannerOpts.Location = New System.Drawing.Point(240, 6)
        Me.gbTVShowBannerOpts.Name = "gbTVShowBannerOpts"
        Me.gbTVShowBannerOpts.Size = New System.Drawing.Size(228, 167)
        Me.gbTVShowBannerOpts.TabIndex = 2
        Me.gbTVShowBannerOpts.TabStop = false
        Me.gbTVShowBannerOpts.Text = "Banner"
        '
        'txtTVShowBannerWidth
        '
        Me.txtTVShowBannerWidth.Enabled = false
        Me.txtTVShowBannerWidth.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtTVShowBannerWidth.Location = New System.Drawing.Point(71, 90)
        Me.txtTVShowBannerWidth.Name = "txtTVShowBannerWidth"
        Me.txtTVShowBannerWidth.Size = New System.Drawing.Size(40, 22)
        Me.txtTVShowBannerWidth.TabIndex = 7
        '
        'txtTVShowBannerHeight
        '
        Me.txtTVShowBannerHeight.Enabled = false
        Me.txtTVShowBannerHeight.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtTVShowBannerHeight.Location = New System.Drawing.Point(182, 90)
        Me.txtTVShowBannerHeight.Name = "txtTVShowBannerHeight"
        Me.txtTVShowBannerHeight.Size = New System.Drawing.Size(40, 22)
        Me.txtTVShowBannerHeight.TabIndex = 9
        '
        'lblTVShowBannerQual
        '
        Me.lblTVShowBannerQual.AutoSize = true
        Me.lblTVShowBannerQual.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.lblTVShowBannerQual.Location = New System.Drawing.Point(183, 138)
        Me.lblTVShowBannerQual.Name = "lblTVShowBannerQual"
        Me.lblTVShowBannerQual.Size = New System.Drawing.Size(29, 17)
        Me.lblTVShowBannerQual.TabIndex = 12
        Me.lblTVShowBannerQual.Text = "100"
        '
        'tbTVShowBannerQual
        '
        Me.tbTVShowBannerQual.AutoSize = false
        Me.tbTVShowBannerQual.BackColor = System.Drawing.Color.White
        Me.tbTVShowBannerQual.LargeChange = 10
        Me.tbTVShowBannerQual.Location = New System.Drawing.Point(7, 131)
        Me.tbTVShowBannerQual.Maximum = 100
        Me.tbTVShowBannerQual.Name = "tbTVShowBannerQual"
        Me.tbTVShowBannerQual.Size = New System.Drawing.Size(179, 27)
        Me.tbTVShowBannerQual.TabIndex = 11
        Me.tbTVShowBannerQual.TickFrequency = 10
        Me.tbTVShowBannerQual.Value = 100
        '
        'lblTVShowBannerQ
        '
        Me.lblTVShowBannerQ.AutoSize = true
        Me.lblTVShowBannerQ.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblTVShowBannerQ.Location = New System.Drawing.Point(3, 118)
        Me.lblTVShowBannerQ.Name = "lblTVShowBannerQ"
        Me.lblTVShowBannerQ.Size = New System.Drawing.Size(46, 13)
        Me.lblTVShowBannerQ.TabIndex = 10
        Me.lblTVShowBannerQ.Text = "Quality:"
        '
        'lblTVShowBannerWidth
        '
        Me.lblTVShowBannerWidth.AutoSize = true
        Me.lblTVShowBannerWidth.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblTVShowBannerWidth.Location = New System.Drawing.Point(3, 94)
        Me.lblTVShowBannerWidth.Name = "lblTVShowBannerWidth"
        Me.lblTVShowBannerWidth.Size = New System.Drawing.Size(66, 13)
        Me.lblTVShowBannerWidth.TabIndex = 6
        Me.lblTVShowBannerWidth.Text = "Max Width:"
        '
        'lblTVShowBannerHeight
        '
        Me.lblTVShowBannerHeight.AutoSize = true
        Me.lblTVShowBannerHeight.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblTVShowBannerHeight.Location = New System.Drawing.Point(112, 94)
        Me.lblTVShowBannerHeight.Name = "lblTVShowBannerHeight"
        Me.lblTVShowBannerHeight.Size = New System.Drawing.Size(69, 13)
        Me.lblTVShowBannerHeight.TabIndex = 8
        Me.lblTVShowBannerHeight.Text = "Max Height:"
        '
        'chkTVShowBannerResize
        '
        Me.chkTVShowBannerResize.AutoSize = true
        Me.chkTVShowBannerResize.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkTVShowBannerResize.Location = New System.Drawing.Point(6, 69)
        Me.chkTVShowBannerResize.Name = "chkTVShowBannerResize"
        Me.chkTVShowBannerResize.Size = New System.Drawing.Size(133, 17)
        Me.chkTVShowBannerResize.TabIndex = 5
        Me.chkTVShowBannerResize.Text = "Automatically Resize:"
        Me.chkTVShowBannerResize.UseVisualStyleBackColor = true
        '
        'lblTVShowBannerType
        '
        Me.lblTVShowBannerType.AutoSize = true
        Me.lblTVShowBannerType.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblTVShowBannerType.Location = New System.Drawing.Point(3, 14)
        Me.lblTVShowBannerType.Name = "lblTVShowBannerType"
        Me.lblTVShowBannerType.Size = New System.Drawing.Size(83, 13)
        Me.lblTVShowBannerType.TabIndex = 0
        Me.lblTVShowBannerType.Text = "Preferred Type:"
        '
        'cbTVShowBannerPrefType
        '
        Me.cbTVShowBannerPrefType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTVShowBannerPrefType.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.cbTVShowBannerPrefType.FormattingEnabled = true
        Me.cbTVShowBannerPrefType.Location = New System.Drawing.Point(6, 29)
        Me.cbTVShowBannerPrefType.Name = "cbTVShowBannerPrefType"
        Me.cbTVShowBannerPrefType.Size = New System.Drawing.Size(148, 21)
        Me.cbTVShowBannerPrefType.TabIndex = 3
        '
        'chkTVShowBannerOverwrite
        '
        Me.chkTVShowBannerOverwrite.AutoSize = true
        Me.chkTVShowBannerOverwrite.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkTVShowBannerOverwrite.Location = New System.Drawing.Point(6, 53)
        Me.chkTVShowBannerOverwrite.Name = "chkTVShowBannerOverwrite"
        Me.chkTVShowBannerOverwrite.Size = New System.Drawing.Size(119, 17)
        Me.chkTVShowBannerOverwrite.TabIndex = 4
        Me.chkTVShowBannerOverwrite.Text = "Overwrite Existing"
        Me.chkTVShowBannerOverwrite.UseVisualStyleBackColor = true
        '
        'gbTVShowPosterOpts
        '
        Me.gbTVShowPosterOpts.Controls.Add(Me.txtTVShowPosterWidth)
        Me.gbTVShowPosterOpts.Controls.Add(Me.txtTVShowPosterHeight)
        Me.gbTVShowPosterOpts.Controls.Add(Me.lblTVShowPosterQual)
        Me.gbTVShowPosterOpts.Controls.Add(Me.tbTVShowPosterQual)
        Me.gbTVShowPosterOpts.Controls.Add(Me.lblTVShowPosterQ)
        Me.gbTVShowPosterOpts.Controls.Add(Me.lblTVShowPosterWidth)
        Me.gbTVShowPosterOpts.Controls.Add(Me.lblTVShowPosterHeight)
        Me.gbTVShowPosterOpts.Controls.Add(Me.chkTVShowPosterResize)
        Me.gbTVShowPosterOpts.Controls.Add(Me.lblTVShowPosterSize)
        Me.gbTVShowPosterOpts.Controls.Add(Me.cbTVShowPosterPrefSize)
        Me.gbTVShowPosterOpts.Controls.Add(Me.chkTVShowPosterOverwrite)
        Me.gbTVShowPosterOpts.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.gbTVShowPosterOpts.Location = New System.Drawing.Point(6, 6)
        Me.gbTVShowPosterOpts.Name = "gbTVShowPosterOpts"
        Me.gbTVShowPosterOpts.Size = New System.Drawing.Size(228, 167)
        Me.gbTVShowPosterOpts.TabIndex = 0
        Me.gbTVShowPosterOpts.TabStop = false
        Me.gbTVShowPosterOpts.Text = "Poster"
        '
        'txtTVShowPosterWidth
        '
        Me.txtTVShowPosterWidth.Enabled = false
        Me.txtTVShowPosterWidth.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtTVShowPosterWidth.Location = New System.Drawing.Point(71, 90)
        Me.txtTVShowPosterWidth.Name = "txtTVShowPosterWidth"
        Me.txtTVShowPosterWidth.Size = New System.Drawing.Size(40, 22)
        Me.txtTVShowPosterWidth.TabIndex = 7
        '
        'txtTVShowPosterHeight
        '
        Me.txtTVShowPosterHeight.Enabled = false
        Me.txtTVShowPosterHeight.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtTVShowPosterHeight.Location = New System.Drawing.Point(182, 90)
        Me.txtTVShowPosterHeight.Name = "txtTVShowPosterHeight"
        Me.txtTVShowPosterHeight.Size = New System.Drawing.Size(40, 22)
        Me.txtTVShowPosterHeight.TabIndex = 9
        '
        'lblTVShowPosterQual
        '
        Me.lblTVShowPosterQual.AutoSize = true
        Me.lblTVShowPosterQual.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.lblTVShowPosterQual.Location = New System.Drawing.Point(183, 138)
        Me.lblTVShowPosterQual.Name = "lblTVShowPosterQual"
        Me.lblTVShowPosterQual.Size = New System.Drawing.Size(29, 17)
        Me.lblTVShowPosterQual.TabIndex = 12
        Me.lblTVShowPosterQual.Text = "100"
        '
        'tbTVShowPosterQual
        '
        Me.tbTVShowPosterQual.AutoSize = false
        Me.tbTVShowPosterQual.BackColor = System.Drawing.Color.White
        Me.tbTVShowPosterQual.LargeChange = 10
        Me.tbTVShowPosterQual.Location = New System.Drawing.Point(7, 131)
        Me.tbTVShowPosterQual.Maximum = 100
        Me.tbTVShowPosterQual.Name = "tbTVShowPosterQual"
        Me.tbTVShowPosterQual.Size = New System.Drawing.Size(179, 27)
        Me.tbTVShowPosterQual.TabIndex = 11
        Me.tbTVShowPosterQual.TickFrequency = 10
        Me.tbTVShowPosterQual.Value = 100
        '
        'lblTVShowPosterQ
        '
        Me.lblTVShowPosterQ.AutoSize = true
        Me.lblTVShowPosterQ.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblTVShowPosterQ.Location = New System.Drawing.Point(3, 118)
        Me.lblTVShowPosterQ.Name = "lblTVShowPosterQ"
        Me.lblTVShowPosterQ.Size = New System.Drawing.Size(46, 13)
        Me.lblTVShowPosterQ.TabIndex = 10
        Me.lblTVShowPosterQ.Text = "Quality:"
        '
        'lblTVShowPosterWidth
        '
        Me.lblTVShowPosterWidth.AutoSize = true
        Me.lblTVShowPosterWidth.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblTVShowPosterWidth.Location = New System.Drawing.Point(3, 94)
        Me.lblTVShowPosterWidth.Name = "lblTVShowPosterWidth"
        Me.lblTVShowPosterWidth.Size = New System.Drawing.Size(66, 13)
        Me.lblTVShowPosterWidth.TabIndex = 6
        Me.lblTVShowPosterWidth.Text = "Max Width:"
        '
        'lblTVShowPosterHeight
        '
        Me.lblTVShowPosterHeight.AutoSize = true
        Me.lblTVShowPosterHeight.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblTVShowPosterHeight.Location = New System.Drawing.Point(112, 94)
        Me.lblTVShowPosterHeight.Name = "lblTVShowPosterHeight"
        Me.lblTVShowPosterHeight.Size = New System.Drawing.Size(69, 13)
        Me.lblTVShowPosterHeight.TabIndex = 8
        Me.lblTVShowPosterHeight.Text = "Max Height:"
        '
        'chkTVShowPosterResize
        '
        Me.chkTVShowPosterResize.AutoSize = true
        Me.chkTVShowPosterResize.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkTVShowPosterResize.Location = New System.Drawing.Point(6, 69)
        Me.chkTVShowPosterResize.Name = "chkTVShowPosterResize"
        Me.chkTVShowPosterResize.Size = New System.Drawing.Size(133, 17)
        Me.chkTVShowPosterResize.TabIndex = 5
        Me.chkTVShowPosterResize.Text = "Automatically Resize:"
        Me.chkTVShowPosterResize.UseVisualStyleBackColor = true
        '
        'lblTVShowPosterSize
        '
        Me.lblTVShowPosterSize.AutoSize = true
        Me.lblTVShowPosterSize.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblTVShowPosterSize.Location = New System.Drawing.Point(3, 14)
        Me.lblTVShowPosterSize.Name = "lblTVShowPosterSize"
        Me.lblTVShowPosterSize.Size = New System.Drawing.Size(80, 13)
        Me.lblTVShowPosterSize.TabIndex = 0
        Me.lblTVShowPosterSize.Text = "Preferred Size:"
        '
        'cbTVShowPosterPrefSize
        '
        Me.cbTVShowPosterPrefSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTVShowPosterPrefSize.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.cbTVShowPosterPrefSize.FormattingEnabled = true
        Me.cbTVShowPosterPrefSize.Location = New System.Drawing.Point(6, 29)
        Me.cbTVShowPosterPrefSize.Name = "cbTVShowPosterPrefSize"
        Me.cbTVShowPosterPrefSize.Size = New System.Drawing.Size(148, 21)
        Me.cbTVShowPosterPrefSize.TabIndex = 3
        '
        'chkTVShowPosterOverwrite
        '
        Me.chkTVShowPosterOverwrite.AutoSize = true
        Me.chkTVShowPosterOverwrite.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkTVShowPosterOverwrite.Location = New System.Drawing.Point(6, 53)
        Me.chkTVShowPosterOverwrite.Name = "chkTVShowPosterOverwrite"
        Me.chkTVShowPosterOverwrite.Size = New System.Drawing.Size(119, 17)
        Me.chkTVShowPosterOverwrite.TabIndex = 4
        Me.chkTVShowPosterOverwrite.Text = "Overwrite Existing"
        Me.chkTVShowPosterOverwrite.UseVisualStyleBackColor = true
        '
        'gbTVShowFanartOpts
        '
        Me.gbTVShowFanartOpts.Controls.Add(Me.txtTVShowFanartWidth)
        Me.gbTVShowFanartOpts.Controls.Add(Me.txtTVShowFanartHeight)
        Me.gbTVShowFanartOpts.Controls.Add(Me.lblTVShowFanartQual)
        Me.gbTVShowFanartOpts.Controls.Add(Me.tbTVShowFanartQual)
        Me.gbTVShowFanartOpts.Controls.Add(Me.lblTVShowFanartQ)
        Me.gbTVShowFanartOpts.Controls.Add(Me.lblTVShowFanartWidth)
        Me.gbTVShowFanartOpts.Controls.Add(Me.lblTVShowFanartHeight)
        Me.gbTVShowFanartOpts.Controls.Add(Me.chkTVShowFanartResize)
        Me.gbTVShowFanartOpts.Controls.Add(Me.cbTVShowFanartPrefSize)
        Me.gbTVShowFanartOpts.Controls.Add(Me.lblTVShowFanartSize)
        Me.gbTVShowFanartOpts.Controls.Add(Me.chkTVShowFanartOverwrite)
        Me.gbTVShowFanartOpts.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.gbTVShowFanartOpts.Location = New System.Drawing.Point(474, 6)
        Me.gbTVShowFanartOpts.Name = "gbTVShowFanartOpts"
        Me.gbTVShowFanartOpts.Size = New System.Drawing.Size(228, 167)
        Me.gbTVShowFanartOpts.TabIndex = 1
        Me.gbTVShowFanartOpts.TabStop = false
        Me.gbTVShowFanartOpts.Text = "Fanart"
        '
        'txtTVShowFanartWidth
        '
        Me.txtTVShowFanartWidth.Enabled = false
        Me.txtTVShowFanartWidth.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtTVShowFanartWidth.Location = New System.Drawing.Point(71, 90)
        Me.txtTVShowFanartWidth.Name = "txtTVShowFanartWidth"
        Me.txtTVShowFanartWidth.Size = New System.Drawing.Size(40, 22)
        Me.txtTVShowFanartWidth.TabIndex = 5
        '
        'txtTVShowFanartHeight
        '
        Me.txtTVShowFanartHeight.Enabled = false
        Me.txtTVShowFanartHeight.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtTVShowFanartHeight.Location = New System.Drawing.Point(182, 90)
        Me.txtTVShowFanartHeight.Name = "txtTVShowFanartHeight"
        Me.txtTVShowFanartHeight.Size = New System.Drawing.Size(40, 22)
        Me.txtTVShowFanartHeight.TabIndex = 7
        '
        'lblTVShowFanartQual
        '
        Me.lblTVShowFanartQual.AutoSize = true
        Me.lblTVShowFanartQual.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.lblTVShowFanartQual.Location = New System.Drawing.Point(183, 138)
        Me.lblTVShowFanartQual.Name = "lblTVShowFanartQual"
        Me.lblTVShowFanartQual.Size = New System.Drawing.Size(29, 17)
        Me.lblTVShowFanartQual.TabIndex = 10
        Me.lblTVShowFanartQual.Text = "100"
        '
        'tbTVShowFanartQual
        '
        Me.tbTVShowFanartQual.AutoSize = false
        Me.tbTVShowFanartQual.BackColor = System.Drawing.Color.White
        Me.tbTVShowFanartQual.LargeChange = 10
        Me.tbTVShowFanartQual.Location = New System.Drawing.Point(7, 131)
        Me.tbTVShowFanartQual.Maximum = 100
        Me.tbTVShowFanartQual.Name = "tbTVShowFanartQual"
        Me.tbTVShowFanartQual.Size = New System.Drawing.Size(180, 27)
        Me.tbTVShowFanartQual.TabIndex = 9
        Me.tbTVShowFanartQual.TickFrequency = 10
        Me.tbTVShowFanartQual.Value = 100
        '
        'lblTVShowFanartQ
        '
        Me.lblTVShowFanartQ.AutoSize = true
        Me.lblTVShowFanartQ.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblTVShowFanartQ.Location = New System.Drawing.Point(3, 118)
        Me.lblTVShowFanartQ.Name = "lblTVShowFanartQ"
        Me.lblTVShowFanartQ.Size = New System.Drawing.Size(46, 13)
        Me.lblTVShowFanartQ.TabIndex = 8
        Me.lblTVShowFanartQ.Text = "Quality:"
        '
        'lblTVShowFanartWidth
        '
        Me.lblTVShowFanartWidth.AutoSize = true
        Me.lblTVShowFanartWidth.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblTVShowFanartWidth.Location = New System.Drawing.Point(3, 94)
        Me.lblTVShowFanartWidth.Name = "lblTVShowFanartWidth"
        Me.lblTVShowFanartWidth.Size = New System.Drawing.Size(66, 13)
        Me.lblTVShowFanartWidth.TabIndex = 4
        Me.lblTVShowFanartWidth.Text = "Max Width:"
        '
        'lblTVShowFanartHeight
        '
        Me.lblTVShowFanartHeight.AutoSize = true
        Me.lblTVShowFanartHeight.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblTVShowFanartHeight.Location = New System.Drawing.Point(112, 94)
        Me.lblTVShowFanartHeight.Name = "lblTVShowFanartHeight"
        Me.lblTVShowFanartHeight.Size = New System.Drawing.Size(69, 13)
        Me.lblTVShowFanartHeight.TabIndex = 6
        Me.lblTVShowFanartHeight.Text = "Max Height:"
        '
        'chkTVShowFanartResize
        '
        Me.chkTVShowFanartResize.AutoSize = true
        Me.chkTVShowFanartResize.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkTVShowFanartResize.Location = New System.Drawing.Point(6, 69)
        Me.chkTVShowFanartResize.Name = "chkTVShowFanartResize"
        Me.chkTVShowFanartResize.Size = New System.Drawing.Size(133, 17)
        Me.chkTVShowFanartResize.TabIndex = 3
        Me.chkTVShowFanartResize.Text = "Automatically Resize:"
        Me.chkTVShowFanartResize.UseVisualStyleBackColor = true
        '
        'cbTVShowFanartPrefSize
        '
        Me.cbTVShowFanartPrefSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTVShowFanartPrefSize.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.cbTVShowFanartPrefSize.FormattingEnabled = true
        Me.cbTVShowFanartPrefSize.Location = New System.Drawing.Point(6, 29)
        Me.cbTVShowFanartPrefSize.Name = "cbTVShowFanartPrefSize"
        Me.cbTVShowFanartPrefSize.Size = New System.Drawing.Size(148, 21)
        Me.cbTVShowFanartPrefSize.TabIndex = 1
        '
        'lblTVShowFanartSize
        '
        Me.lblTVShowFanartSize.AutoSize = true
        Me.lblTVShowFanartSize.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblTVShowFanartSize.Location = New System.Drawing.Point(3, 14)
        Me.lblTVShowFanartSize.Name = "lblTVShowFanartSize"
        Me.lblTVShowFanartSize.Size = New System.Drawing.Size(80, 13)
        Me.lblTVShowFanartSize.TabIndex = 0
        Me.lblTVShowFanartSize.Text = "Preferred Size:"
        '
        'chkTVShowFanartOverwrite
        '
        Me.chkTVShowFanartOverwrite.AutoSize = true
        Me.chkTVShowFanartOverwrite.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkTVShowFanartOverwrite.Location = New System.Drawing.Point(6, 53)
        Me.chkTVShowFanartOverwrite.Name = "chkTVShowFanartOverwrite"
        Me.chkTVShowFanartOverwrite.Size = New System.Drawing.Size(119, 17)
        Me.chkTVShowFanartOverwrite.TabIndex = 2
        Me.chkTVShowFanartOverwrite.Text = "Overwrite Existing"
        Me.chkTVShowFanartOverwrite.UseVisualStyleBackColor = true
        '
        'tpTVAllSeasons
        '
        Me.tpTVAllSeasons.Controls.Add(Me.gbTVASLandscapeOpts)
        Me.tpTVAllSeasons.Controls.Add(Me.gbTVASFanartOpts)
        Me.tpTVAllSeasons.Controls.Add(Me.gbTVASBannerOpts)
        Me.tpTVAllSeasons.Controls.Add(Me.gbTVASPosterOpts)
        Me.tpTVAllSeasons.Location = New System.Drawing.Point(4, 22)
        Me.tpTVAllSeasons.Name = "tpTVAllSeasons"
        Me.tpTVAllSeasons.Padding = New System.Windows.Forms.Padding(3)
        Me.tpTVAllSeasons.Size = New System.Drawing.Size(734, 465)
        Me.tpTVAllSeasons.TabIndex = 3
        Me.tpTVAllSeasons.Text = "TV All Seasons"
        Me.tpTVAllSeasons.UseVisualStyleBackColor = true
        '
        'gbTVASLandscapeOpts
        '
        Me.gbTVASLandscapeOpts.Controls.Add(Me.chkTVASLandscapeOverwrite)
        Me.gbTVASLandscapeOpts.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.gbTVASLandscapeOpts.Location = New System.Drawing.Point(6, 179)
        Me.gbTVASLandscapeOpts.Name = "gbTVASLandscapeOpts"
        Me.gbTVASLandscapeOpts.Size = New System.Drawing.Size(228, 44)
        Me.gbTVASLandscapeOpts.TabIndex = 8
        Me.gbTVASLandscapeOpts.TabStop = false
        Me.gbTVASLandscapeOpts.Text = "Landscape"
        '
        'chkTVASLandscapeOverwrite
        '
        Me.chkTVASLandscapeOverwrite.AutoSize = true
        Me.chkTVASLandscapeOverwrite.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkTVASLandscapeOverwrite.Location = New System.Drawing.Point(6, 21)
        Me.chkTVASLandscapeOverwrite.Name = "chkTVASLandscapeOverwrite"
        Me.chkTVASLandscapeOverwrite.Size = New System.Drawing.Size(119, 17)
        Me.chkTVASLandscapeOverwrite.TabIndex = 4
        Me.chkTVASLandscapeOverwrite.Text = "Overwrite Existing"
        Me.chkTVASLandscapeOverwrite.UseVisualStyleBackColor = true
        '
        'gbTVASFanartOpts
        '
        Me.gbTVASFanartOpts.Controls.Add(Me.txtTVASFanartWidth)
        Me.gbTVASFanartOpts.Controls.Add(Me.txtTVASFanartHeight)
        Me.gbTVASFanartOpts.Controls.Add(Me.lblTVASFanartQual)
        Me.gbTVASFanartOpts.Controls.Add(Me.tbTVASFanartQual)
        Me.gbTVASFanartOpts.Controls.Add(Me.lblTVASFanartQ)
        Me.gbTVASFanartOpts.Controls.Add(Me.lblTVASFanartWidth)
        Me.gbTVASFanartOpts.Controls.Add(Me.lblTVASFanartHeight)
        Me.gbTVASFanartOpts.Controls.Add(Me.chkTVASFanartResize)
        Me.gbTVASFanartOpts.Controls.Add(Me.cbTVASFanartPrefSize)
        Me.gbTVASFanartOpts.Controls.Add(Me.lblTVASFanartSize)
        Me.gbTVASFanartOpts.Controls.Add(Me.chkTVASFanartOverwrite)
        Me.gbTVASFanartOpts.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.gbTVASFanartOpts.Location = New System.Drawing.Point(474, 6)
        Me.gbTVASFanartOpts.Name = "gbTVASFanartOpts"
        Me.gbTVASFanartOpts.Size = New System.Drawing.Size(228, 167)
        Me.gbTVASFanartOpts.TabIndex = 7
        Me.gbTVASFanartOpts.TabStop = false
        Me.gbTVASFanartOpts.Text = "Fanart"
        '
        'txtTVASFanartWidth
        '
        Me.txtTVASFanartWidth.Enabled = false
        Me.txtTVASFanartWidth.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtTVASFanartWidth.Location = New System.Drawing.Point(71, 90)
        Me.txtTVASFanartWidth.Name = "txtTVASFanartWidth"
        Me.txtTVASFanartWidth.Size = New System.Drawing.Size(40, 22)
        Me.txtTVASFanartWidth.TabIndex = 5
        '
        'txtTVASFanartHeight
        '
        Me.txtTVASFanartHeight.Enabled = false
        Me.txtTVASFanartHeight.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtTVASFanartHeight.Location = New System.Drawing.Point(182, 90)
        Me.txtTVASFanartHeight.Name = "txtTVASFanartHeight"
        Me.txtTVASFanartHeight.Size = New System.Drawing.Size(40, 22)
        Me.txtTVASFanartHeight.TabIndex = 7
        '
        'lblTVASFanartQual
        '
        Me.lblTVASFanartQual.AutoSize = true
        Me.lblTVASFanartQual.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.lblTVASFanartQual.Location = New System.Drawing.Point(183, 138)
        Me.lblTVASFanartQual.Name = "lblTVASFanartQual"
        Me.lblTVASFanartQual.Size = New System.Drawing.Size(29, 17)
        Me.lblTVASFanartQual.TabIndex = 10
        Me.lblTVASFanartQual.Text = "100"
        '
        'tbTVASFanartQual
        '
        Me.tbTVASFanartQual.AutoSize = false
        Me.tbTVASFanartQual.BackColor = System.Drawing.Color.White
        Me.tbTVASFanartQual.LargeChange = 10
        Me.tbTVASFanartQual.Location = New System.Drawing.Point(7, 131)
        Me.tbTVASFanartQual.Maximum = 100
        Me.tbTVASFanartQual.Name = "tbTVASFanartQual"
        Me.tbTVASFanartQual.Size = New System.Drawing.Size(180, 27)
        Me.tbTVASFanartQual.TabIndex = 9
        Me.tbTVASFanartQual.TickFrequency = 10
        Me.tbTVASFanartQual.Value = 100
        '
        'lblTVASFanartQ
        '
        Me.lblTVASFanartQ.AutoSize = true
        Me.lblTVASFanartQ.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblTVASFanartQ.Location = New System.Drawing.Point(3, 118)
        Me.lblTVASFanartQ.Name = "lblTVASFanartQ"
        Me.lblTVASFanartQ.Size = New System.Drawing.Size(46, 13)
        Me.lblTVASFanartQ.TabIndex = 8
        Me.lblTVASFanartQ.Text = "Quality:"
        '
        'lblTVASFanartWidth
        '
        Me.lblTVASFanartWidth.AutoSize = true
        Me.lblTVASFanartWidth.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblTVASFanartWidth.Location = New System.Drawing.Point(3, 94)
        Me.lblTVASFanartWidth.Name = "lblTVASFanartWidth"
        Me.lblTVASFanartWidth.Size = New System.Drawing.Size(66, 13)
        Me.lblTVASFanartWidth.TabIndex = 4
        Me.lblTVASFanartWidth.Text = "Max Width:"
        '
        'lblTVASFanartHeight
        '
        Me.lblTVASFanartHeight.AutoSize = true
        Me.lblTVASFanartHeight.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblTVASFanartHeight.Location = New System.Drawing.Point(112, 94)
        Me.lblTVASFanartHeight.Name = "lblTVASFanartHeight"
        Me.lblTVASFanartHeight.Size = New System.Drawing.Size(69, 13)
        Me.lblTVASFanartHeight.TabIndex = 6
        Me.lblTVASFanartHeight.Text = "Max Height:"
        '
        'chkTVASFanartResize
        '
        Me.chkTVASFanartResize.AutoSize = true
        Me.chkTVASFanartResize.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkTVASFanartResize.Location = New System.Drawing.Point(6, 69)
        Me.chkTVASFanartResize.Name = "chkTVASFanartResize"
        Me.chkTVASFanartResize.Size = New System.Drawing.Size(133, 17)
        Me.chkTVASFanartResize.TabIndex = 3
        Me.chkTVASFanartResize.Text = "Automatically Resize:"
        Me.chkTVASFanartResize.UseVisualStyleBackColor = true
        '
        'cbTVASFanartPrefSize
        '
        Me.cbTVASFanartPrefSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTVASFanartPrefSize.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.cbTVASFanartPrefSize.FormattingEnabled = true
        Me.cbTVASFanartPrefSize.Location = New System.Drawing.Point(6, 29)
        Me.cbTVASFanartPrefSize.Name = "cbTVASFanartPrefSize"
        Me.cbTVASFanartPrefSize.Size = New System.Drawing.Size(148, 21)
        Me.cbTVASFanartPrefSize.TabIndex = 1
        '
        'lblTVASFanartSize
        '
        Me.lblTVASFanartSize.AutoSize = true
        Me.lblTVASFanartSize.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblTVASFanartSize.Location = New System.Drawing.Point(3, 14)
        Me.lblTVASFanartSize.Name = "lblTVASFanartSize"
        Me.lblTVASFanartSize.Size = New System.Drawing.Size(80, 13)
        Me.lblTVASFanartSize.TabIndex = 0
        Me.lblTVASFanartSize.Text = "Preferred Size:"
        '
        'chkTVASFanartOverwrite
        '
        Me.chkTVASFanartOverwrite.AutoSize = true
        Me.chkTVASFanartOverwrite.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkTVASFanartOverwrite.Location = New System.Drawing.Point(6, 53)
        Me.chkTVASFanartOverwrite.Name = "chkTVASFanartOverwrite"
        Me.chkTVASFanartOverwrite.Size = New System.Drawing.Size(119, 17)
        Me.chkTVASFanartOverwrite.TabIndex = 2
        Me.chkTVASFanartOverwrite.Text = "Overwrite Existing"
        Me.chkTVASFanartOverwrite.UseVisualStyleBackColor = true
        '
        'gbTVASBannerOpts
        '
        Me.gbTVASBannerOpts.Controls.Add(Me.txtTVASBannerWidth)
        Me.gbTVASBannerOpts.Controls.Add(Me.txtTVASBannerHeight)
        Me.gbTVASBannerOpts.Controls.Add(Me.lblTVASBannerQual)
        Me.gbTVASBannerOpts.Controls.Add(Me.tbTVASBannerQual)
        Me.gbTVASBannerOpts.Controls.Add(Me.lblTVASBannerQ)
        Me.gbTVASBannerOpts.Controls.Add(Me.lblTVASBannerWidth)
        Me.gbTVASBannerOpts.Controls.Add(Me.lblTVASBannerHeight)
        Me.gbTVASBannerOpts.Controls.Add(Me.chkTVASBannerResize)
        Me.gbTVASBannerOpts.Controls.Add(Me.lblTVASBannerType)
        Me.gbTVASBannerOpts.Controls.Add(Me.cbTVASBannerPrefType)
        Me.gbTVASBannerOpts.Controls.Add(Me.chkTVASBannerOverwrite)
        Me.gbTVASBannerOpts.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.gbTVASBannerOpts.Location = New System.Drawing.Point(240, 6)
        Me.gbTVASBannerOpts.Name = "gbTVASBannerOpts"
        Me.gbTVASBannerOpts.Size = New System.Drawing.Size(228, 167)
        Me.gbTVASBannerOpts.TabIndex = 6
        Me.gbTVASBannerOpts.TabStop = false
        Me.gbTVASBannerOpts.Text = "Banner"
        '
        'txtTVASBannerWidth
        '
        Me.txtTVASBannerWidth.Enabled = false
        Me.txtTVASBannerWidth.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtTVASBannerWidth.Location = New System.Drawing.Point(71, 90)
        Me.txtTVASBannerWidth.Name = "txtTVASBannerWidth"
        Me.txtTVASBannerWidth.Size = New System.Drawing.Size(40, 22)
        Me.txtTVASBannerWidth.TabIndex = 7
        '
        'txtTVASBannerHeight
        '
        Me.txtTVASBannerHeight.Enabled = false
        Me.txtTVASBannerHeight.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtTVASBannerHeight.Location = New System.Drawing.Point(182, 90)
        Me.txtTVASBannerHeight.Name = "txtTVASBannerHeight"
        Me.txtTVASBannerHeight.Size = New System.Drawing.Size(40, 22)
        Me.txtTVASBannerHeight.TabIndex = 9
        '
        'lblTVASBannerQual
        '
        Me.lblTVASBannerQual.AutoSize = true
        Me.lblTVASBannerQual.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.lblTVASBannerQual.Location = New System.Drawing.Point(183, 138)
        Me.lblTVASBannerQual.Name = "lblTVASBannerQual"
        Me.lblTVASBannerQual.Size = New System.Drawing.Size(29, 17)
        Me.lblTVASBannerQual.TabIndex = 12
        Me.lblTVASBannerQual.Text = "100"
        '
        'tbTVASBannerQual
        '
        Me.tbTVASBannerQual.AutoSize = false
        Me.tbTVASBannerQual.BackColor = System.Drawing.Color.White
        Me.tbTVASBannerQual.LargeChange = 10
        Me.tbTVASBannerQual.Location = New System.Drawing.Point(7, 131)
        Me.tbTVASBannerQual.Maximum = 100
        Me.tbTVASBannerQual.Name = "tbTVASBannerQual"
        Me.tbTVASBannerQual.Size = New System.Drawing.Size(179, 27)
        Me.tbTVASBannerQual.TabIndex = 11
        Me.tbTVASBannerQual.TickFrequency = 10
        Me.tbTVASBannerQual.Value = 100
        '
        'lblTVASBannerQ
        '
        Me.lblTVASBannerQ.AutoSize = true
        Me.lblTVASBannerQ.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblTVASBannerQ.Location = New System.Drawing.Point(3, 118)
        Me.lblTVASBannerQ.Name = "lblTVASBannerQ"
        Me.lblTVASBannerQ.Size = New System.Drawing.Size(46, 13)
        Me.lblTVASBannerQ.TabIndex = 10
        Me.lblTVASBannerQ.Text = "Quality:"
        '
        'lblTVASBannerWidth
        '
        Me.lblTVASBannerWidth.AutoSize = true
        Me.lblTVASBannerWidth.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblTVASBannerWidth.Location = New System.Drawing.Point(3, 94)
        Me.lblTVASBannerWidth.Name = "lblTVASBannerWidth"
        Me.lblTVASBannerWidth.Size = New System.Drawing.Size(66, 13)
        Me.lblTVASBannerWidth.TabIndex = 6
        Me.lblTVASBannerWidth.Text = "Max Width:"
        '
        'lblTVASBannerHeight
        '
        Me.lblTVASBannerHeight.AutoSize = true
        Me.lblTVASBannerHeight.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblTVASBannerHeight.Location = New System.Drawing.Point(112, 94)
        Me.lblTVASBannerHeight.Name = "lblTVASBannerHeight"
        Me.lblTVASBannerHeight.Size = New System.Drawing.Size(69, 13)
        Me.lblTVASBannerHeight.TabIndex = 8
        Me.lblTVASBannerHeight.Text = "Max Height:"
        '
        'chkTVASBannerResize
        '
        Me.chkTVASBannerResize.AutoSize = true
        Me.chkTVASBannerResize.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkTVASBannerResize.Location = New System.Drawing.Point(6, 69)
        Me.chkTVASBannerResize.Name = "chkTVASBannerResize"
        Me.chkTVASBannerResize.Size = New System.Drawing.Size(133, 17)
        Me.chkTVASBannerResize.TabIndex = 5
        Me.chkTVASBannerResize.Text = "Automatically Resize:"
        Me.chkTVASBannerResize.UseVisualStyleBackColor = true
        '
        'lblTVASBannerType
        '
        Me.lblTVASBannerType.AutoSize = true
        Me.lblTVASBannerType.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblTVASBannerType.Location = New System.Drawing.Point(3, 14)
        Me.lblTVASBannerType.Name = "lblTVASBannerType"
        Me.lblTVASBannerType.Size = New System.Drawing.Size(83, 13)
        Me.lblTVASBannerType.TabIndex = 0
        Me.lblTVASBannerType.Text = "Preferred Type:"
        '
        'cbTVASBannerPrefType
        '
        Me.cbTVASBannerPrefType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTVASBannerPrefType.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.cbTVASBannerPrefType.FormattingEnabled = true
        Me.cbTVASBannerPrefType.Location = New System.Drawing.Point(6, 29)
        Me.cbTVASBannerPrefType.Name = "cbTVASBannerPrefType"
        Me.cbTVASBannerPrefType.Size = New System.Drawing.Size(148, 21)
        Me.cbTVASBannerPrefType.TabIndex = 3
        '
        'chkTVASBannerOverwrite
        '
        Me.chkTVASBannerOverwrite.AutoSize = true
        Me.chkTVASBannerOverwrite.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkTVASBannerOverwrite.Location = New System.Drawing.Point(6, 53)
        Me.chkTVASBannerOverwrite.Name = "chkTVASBannerOverwrite"
        Me.chkTVASBannerOverwrite.Size = New System.Drawing.Size(119, 17)
        Me.chkTVASBannerOverwrite.TabIndex = 4
        Me.chkTVASBannerOverwrite.Text = "Overwrite Existing"
        Me.chkTVASBannerOverwrite.UseVisualStyleBackColor = true
        '
        'gbTVASPosterOpts
        '
        Me.gbTVASPosterOpts.Controls.Add(Me.txtTVASPosterWidth)
        Me.gbTVASPosterOpts.Controls.Add(Me.txtTVASPosterHeight)
        Me.gbTVASPosterOpts.Controls.Add(Me.lblTVASPosterQual)
        Me.gbTVASPosterOpts.Controls.Add(Me.tbTVASPosterQual)
        Me.gbTVASPosterOpts.Controls.Add(Me.lblTVASPosterQ)
        Me.gbTVASPosterOpts.Controls.Add(Me.lblTVASPosterWidth)
        Me.gbTVASPosterOpts.Controls.Add(Me.lblTVASPosterHeight)
        Me.gbTVASPosterOpts.Controls.Add(Me.chkTVASPosterResize)
        Me.gbTVASPosterOpts.Controls.Add(Me.lblTVASPosterSize)
        Me.gbTVASPosterOpts.Controls.Add(Me.cbTVASPosterPrefSize)
        Me.gbTVASPosterOpts.Controls.Add(Me.chkTVASPosterOverwrite)
        Me.gbTVASPosterOpts.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.gbTVASPosterOpts.Location = New System.Drawing.Point(6, 6)
        Me.gbTVASPosterOpts.Name = "gbTVASPosterOpts"
        Me.gbTVASPosterOpts.Size = New System.Drawing.Size(228, 167)
        Me.gbTVASPosterOpts.TabIndex = 5
        Me.gbTVASPosterOpts.TabStop = false
        Me.gbTVASPosterOpts.Text = "Poster"
        '
        'txtTVASPosterWidth
        '
        Me.txtTVASPosterWidth.Enabled = false
        Me.txtTVASPosterWidth.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtTVASPosterWidth.Location = New System.Drawing.Point(71, 90)
        Me.txtTVASPosterWidth.Name = "txtTVASPosterWidth"
        Me.txtTVASPosterWidth.Size = New System.Drawing.Size(40, 22)
        Me.txtTVASPosterWidth.TabIndex = 7
        '
        'txtTVASPosterHeight
        '
        Me.txtTVASPosterHeight.Enabled = false
        Me.txtTVASPosterHeight.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtTVASPosterHeight.Location = New System.Drawing.Point(182, 90)
        Me.txtTVASPosterHeight.Name = "txtTVASPosterHeight"
        Me.txtTVASPosterHeight.Size = New System.Drawing.Size(40, 22)
        Me.txtTVASPosterHeight.TabIndex = 9
        '
        'lblTVASPosterQual
        '
        Me.lblTVASPosterQual.AutoSize = true
        Me.lblTVASPosterQual.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.lblTVASPosterQual.Location = New System.Drawing.Point(183, 138)
        Me.lblTVASPosterQual.Name = "lblTVASPosterQual"
        Me.lblTVASPosterQual.Size = New System.Drawing.Size(29, 17)
        Me.lblTVASPosterQual.TabIndex = 12
        Me.lblTVASPosterQual.Text = "100"
        '
        'tbTVASPosterQual
        '
        Me.tbTVASPosterQual.AutoSize = false
        Me.tbTVASPosterQual.BackColor = System.Drawing.Color.White
        Me.tbTVASPosterQual.LargeChange = 10
        Me.tbTVASPosterQual.Location = New System.Drawing.Point(7, 131)
        Me.tbTVASPosterQual.Maximum = 100
        Me.tbTVASPosterQual.Name = "tbTVASPosterQual"
        Me.tbTVASPosterQual.Size = New System.Drawing.Size(179, 27)
        Me.tbTVASPosterQual.TabIndex = 11
        Me.tbTVASPosterQual.TickFrequency = 10
        Me.tbTVASPosterQual.Value = 100
        '
        'lblTVASPosterQ
        '
        Me.lblTVASPosterQ.AutoSize = true
        Me.lblTVASPosterQ.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblTVASPosterQ.Location = New System.Drawing.Point(3, 118)
        Me.lblTVASPosterQ.Name = "lblTVASPosterQ"
        Me.lblTVASPosterQ.Size = New System.Drawing.Size(46, 13)
        Me.lblTVASPosterQ.TabIndex = 10
        Me.lblTVASPosterQ.Text = "Quality:"
        '
        'lblTVASPosterWidth
        '
        Me.lblTVASPosterWidth.AutoSize = true
        Me.lblTVASPosterWidth.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblTVASPosterWidth.Location = New System.Drawing.Point(3, 94)
        Me.lblTVASPosterWidth.Name = "lblTVASPosterWidth"
        Me.lblTVASPosterWidth.Size = New System.Drawing.Size(66, 13)
        Me.lblTVASPosterWidth.TabIndex = 6
        Me.lblTVASPosterWidth.Text = "Max Width:"
        '
        'lblTVASPosterHeight
        '
        Me.lblTVASPosterHeight.AutoSize = true
        Me.lblTVASPosterHeight.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblTVASPosterHeight.Location = New System.Drawing.Point(112, 94)
        Me.lblTVASPosterHeight.Name = "lblTVASPosterHeight"
        Me.lblTVASPosterHeight.Size = New System.Drawing.Size(69, 13)
        Me.lblTVASPosterHeight.TabIndex = 8
        Me.lblTVASPosterHeight.Text = "Max Height:"
        '
        'chkTVASPosterResize
        '
        Me.chkTVASPosterResize.AutoSize = true
        Me.chkTVASPosterResize.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkTVASPosterResize.Location = New System.Drawing.Point(6, 69)
        Me.chkTVASPosterResize.Name = "chkTVASPosterResize"
        Me.chkTVASPosterResize.Size = New System.Drawing.Size(133, 17)
        Me.chkTVASPosterResize.TabIndex = 5
        Me.chkTVASPosterResize.Text = "Automatically Resize:"
        Me.chkTVASPosterResize.UseVisualStyleBackColor = true
        '
        'lblTVASPosterSize
        '
        Me.lblTVASPosterSize.AutoSize = true
        Me.lblTVASPosterSize.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblTVASPosterSize.Location = New System.Drawing.Point(3, 14)
        Me.lblTVASPosterSize.Name = "lblTVASPosterSize"
        Me.lblTVASPosterSize.Size = New System.Drawing.Size(80, 13)
        Me.lblTVASPosterSize.TabIndex = 0
        Me.lblTVASPosterSize.Text = "Preferred Size:"
        '
        'cbTVASPosterPrefSize
        '
        Me.cbTVASPosterPrefSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTVASPosterPrefSize.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.cbTVASPosterPrefSize.FormattingEnabled = true
        Me.cbTVASPosterPrefSize.Location = New System.Drawing.Point(6, 29)
        Me.cbTVASPosterPrefSize.Name = "cbTVASPosterPrefSize"
        Me.cbTVASPosterPrefSize.Size = New System.Drawing.Size(148, 21)
        Me.cbTVASPosterPrefSize.TabIndex = 3
        '
        'chkTVASPosterOverwrite
        '
        Me.chkTVASPosterOverwrite.AutoSize = true
        Me.chkTVASPosterOverwrite.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkTVASPosterOverwrite.Location = New System.Drawing.Point(6, 53)
        Me.chkTVASPosterOverwrite.Name = "chkTVASPosterOverwrite"
        Me.chkTVASPosterOverwrite.Size = New System.Drawing.Size(119, 17)
        Me.chkTVASPosterOverwrite.TabIndex = 4
        Me.chkTVASPosterOverwrite.Text = "Overwrite Existing"
        Me.chkTVASPosterOverwrite.UseVisualStyleBackColor = true
        '
        'tpTVSeason
        '
        Me.tpTVSeason.Controls.Add(Me.gbTVSeasonLandscapeOpts)
        Me.tpTVSeason.Controls.Add(Me.gbTVSeasonBannerOpts)
        Me.tpTVSeason.Controls.Add(Me.gbTVSeasonPosterOpts)
        Me.tpTVSeason.Controls.Add(Me.gbTVSeasonFanartOpts)
        Me.tpTVSeason.Location = New System.Drawing.Point(4, 22)
        Me.tpTVSeason.Name = "tpTVSeason"
        Me.tpTVSeason.Size = New System.Drawing.Size(734, 465)
        Me.tpTVSeason.TabIndex = 2
        Me.tpTVSeason.Text = "TV Season"
        Me.tpTVSeason.UseVisualStyleBackColor = true
        '
        'gbTVSeasonLandscapeOpts
        '
        Me.gbTVSeasonLandscapeOpts.Controls.Add(Me.chkTVSeasonLandscapeOverwrite)
        Me.gbTVSeasonLandscapeOpts.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.gbTVSeasonLandscapeOpts.Location = New System.Drawing.Point(6, 179)
        Me.gbTVSeasonLandscapeOpts.Name = "gbTVSeasonLandscapeOpts"
        Me.gbTVSeasonLandscapeOpts.Size = New System.Drawing.Size(228, 44)
        Me.gbTVSeasonLandscapeOpts.TabIndex = 12
        Me.gbTVSeasonLandscapeOpts.TabStop = false
        Me.gbTVSeasonLandscapeOpts.Text = "Landscape"
        '
        'chkTVSeasonLandscapeOverwrite
        '
        Me.chkTVSeasonLandscapeOverwrite.AutoSize = true
        Me.chkTVSeasonLandscapeOverwrite.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkTVSeasonLandscapeOverwrite.Location = New System.Drawing.Point(6, 21)
        Me.chkTVSeasonLandscapeOverwrite.Name = "chkTVSeasonLandscapeOverwrite"
        Me.chkTVSeasonLandscapeOverwrite.Size = New System.Drawing.Size(119, 17)
        Me.chkTVSeasonLandscapeOverwrite.TabIndex = 2
        Me.chkTVSeasonLandscapeOverwrite.Text = "Overwrite Existing"
        Me.chkTVSeasonLandscapeOverwrite.UseVisualStyleBackColor = true
        '
        'gbTVSeasonBannerOpts
        '
        Me.gbTVSeasonBannerOpts.Controls.Add(Me.txtTVSeasonBannerWidth)
        Me.gbTVSeasonBannerOpts.Controls.Add(Me.txtTVSeasonBannerHeight)
        Me.gbTVSeasonBannerOpts.Controls.Add(Me.lblTVSeasonBannerQual)
        Me.gbTVSeasonBannerOpts.Controls.Add(Me.tbTVSeasonBannerQual)
        Me.gbTVSeasonBannerOpts.Controls.Add(Me.lblTVSeasonBannerQ)
        Me.gbTVSeasonBannerOpts.Controls.Add(Me.lblTVSeasonBannerWidth)
        Me.gbTVSeasonBannerOpts.Controls.Add(Me.lblTVSeasonBannerHeight)
        Me.gbTVSeasonBannerOpts.Controls.Add(Me.chkTVSeasonBannerResize)
        Me.gbTVSeasonBannerOpts.Controls.Add(Me.lblTVSeasonBannerType)
        Me.gbTVSeasonBannerOpts.Controls.Add(Me.cbTVSeasonBannerPrefType)
        Me.gbTVSeasonBannerOpts.Controls.Add(Me.chkTVSeasonBannerOverwrite)
        Me.gbTVSeasonBannerOpts.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.gbTVSeasonBannerOpts.Location = New System.Drawing.Point(240, 6)
        Me.gbTVSeasonBannerOpts.Name = "gbTVSeasonBannerOpts"
        Me.gbTVSeasonBannerOpts.Size = New System.Drawing.Size(228, 167)
        Me.gbTVSeasonBannerOpts.TabIndex = 11
        Me.gbTVSeasonBannerOpts.TabStop = false
        Me.gbTVSeasonBannerOpts.Text = "Banner"
        '
        'txtTVSeasonBannerWidth
        '
        Me.txtTVSeasonBannerWidth.Enabled = false
        Me.txtTVSeasonBannerWidth.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtTVSeasonBannerWidth.Location = New System.Drawing.Point(71, 90)
        Me.txtTVSeasonBannerWidth.Name = "txtTVSeasonBannerWidth"
        Me.txtTVSeasonBannerWidth.Size = New System.Drawing.Size(40, 22)
        Me.txtTVSeasonBannerWidth.TabIndex = 5
        '
        'txtTVSeasonBannerHeight
        '
        Me.txtTVSeasonBannerHeight.Enabled = false
        Me.txtTVSeasonBannerHeight.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtTVSeasonBannerHeight.Location = New System.Drawing.Point(182, 90)
        Me.txtTVSeasonBannerHeight.Name = "txtTVSeasonBannerHeight"
        Me.txtTVSeasonBannerHeight.Size = New System.Drawing.Size(40, 22)
        Me.txtTVSeasonBannerHeight.TabIndex = 7
        '
        'lblTVSeasonBannerQual
        '
        Me.lblTVSeasonBannerQual.AutoSize = true
        Me.lblTVSeasonBannerQual.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblTVSeasonBannerQual.Location = New System.Drawing.Point(183, 138)
        Me.lblTVSeasonBannerQual.Name = "lblTVSeasonBannerQual"
        Me.lblTVSeasonBannerQual.Size = New System.Drawing.Size(29, 17)
        Me.lblTVSeasonBannerQual.TabIndex = 10
        Me.lblTVSeasonBannerQual.Text = "100"
        '
        'tbTVSeasonBannerQual
        '
        Me.tbTVSeasonBannerQual.AutoSize = false
        Me.tbTVSeasonBannerQual.BackColor = System.Drawing.Color.White
        Me.tbTVSeasonBannerQual.LargeChange = 10
        Me.tbTVSeasonBannerQual.Location = New System.Drawing.Point(7, 131)
        Me.tbTVSeasonBannerQual.Maximum = 100
        Me.tbTVSeasonBannerQual.Name = "tbTVSeasonBannerQual"
        Me.tbTVSeasonBannerQual.Size = New System.Drawing.Size(179, 27)
        Me.tbTVSeasonBannerQual.TabIndex = 9
        Me.tbTVSeasonBannerQual.TickFrequency = 10
        Me.tbTVSeasonBannerQual.Value = 100
        '
        'lblTVSeasonBannerQ
        '
        Me.lblTVSeasonBannerQ.AutoSize = true
        Me.lblTVSeasonBannerQ.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblTVSeasonBannerQ.Location = New System.Drawing.Point(3, 118)
        Me.lblTVSeasonBannerQ.Name = "lblTVSeasonBannerQ"
        Me.lblTVSeasonBannerQ.Size = New System.Drawing.Size(46, 13)
        Me.lblTVSeasonBannerQ.TabIndex = 8
        Me.lblTVSeasonBannerQ.Text = "Quality:"
        '
        'lblTVSeasonBannerWidth
        '
        Me.lblTVSeasonBannerWidth.AutoSize = true
        Me.lblTVSeasonBannerWidth.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblTVSeasonBannerWidth.Location = New System.Drawing.Point(3, 94)
        Me.lblTVSeasonBannerWidth.Name = "lblTVSeasonBannerWidth"
        Me.lblTVSeasonBannerWidth.Size = New System.Drawing.Size(66, 13)
        Me.lblTVSeasonBannerWidth.TabIndex = 4
        Me.lblTVSeasonBannerWidth.Text = "Max Width:"
        '
        'lblTVSeasonBannerHeight
        '
        Me.lblTVSeasonBannerHeight.AutoSize = true
        Me.lblTVSeasonBannerHeight.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblTVSeasonBannerHeight.Location = New System.Drawing.Point(112, 94)
        Me.lblTVSeasonBannerHeight.Name = "lblTVSeasonBannerHeight"
        Me.lblTVSeasonBannerHeight.Size = New System.Drawing.Size(69, 13)
        Me.lblTVSeasonBannerHeight.TabIndex = 6
        Me.lblTVSeasonBannerHeight.Text = "Max Height:"
        '
        'chkTVSeasonBannerResize
        '
        Me.chkTVSeasonBannerResize.AutoSize = true
        Me.chkTVSeasonBannerResize.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkTVSeasonBannerResize.Location = New System.Drawing.Point(6, 69)
        Me.chkTVSeasonBannerResize.Name = "chkTVSeasonBannerResize"
        Me.chkTVSeasonBannerResize.Size = New System.Drawing.Size(133, 17)
        Me.chkTVSeasonBannerResize.TabIndex = 3
        Me.chkTVSeasonBannerResize.Text = "Automatically Resize:"
        Me.chkTVSeasonBannerResize.UseVisualStyleBackColor = true
        '
        'lblTVSeasonBannerType
        '
        Me.lblTVSeasonBannerType.AutoSize = true
        Me.lblTVSeasonBannerType.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblTVSeasonBannerType.Location = New System.Drawing.Point(3, 14)
        Me.lblTVSeasonBannerType.Name = "lblTVSeasonBannerType"
        Me.lblTVSeasonBannerType.Size = New System.Drawing.Size(83, 13)
        Me.lblTVSeasonBannerType.TabIndex = 0
        Me.lblTVSeasonBannerType.Text = "Preferred Type:"
        '
        'cbTVSeasonBannerPrefType
        '
        Me.cbTVSeasonBannerPrefType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTVSeasonBannerPrefType.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.cbTVSeasonBannerPrefType.FormattingEnabled = true
        Me.cbTVSeasonBannerPrefType.Location = New System.Drawing.Point(6, 29)
        Me.cbTVSeasonBannerPrefType.Name = "cbTVSeasonBannerPrefType"
        Me.cbTVSeasonBannerPrefType.Size = New System.Drawing.Size(148, 21)
        Me.cbTVSeasonBannerPrefType.TabIndex = 1
        '
        'chkTVSeasonBannerOverwrite
        '
        Me.chkTVSeasonBannerOverwrite.AutoSize = true
        Me.chkTVSeasonBannerOverwrite.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkTVSeasonBannerOverwrite.Location = New System.Drawing.Point(6, 53)
        Me.chkTVSeasonBannerOverwrite.Name = "chkTVSeasonBannerOverwrite"
        Me.chkTVSeasonBannerOverwrite.Size = New System.Drawing.Size(119, 17)
        Me.chkTVSeasonBannerOverwrite.TabIndex = 2
        Me.chkTVSeasonBannerOverwrite.Text = "Overwrite Existing"
        Me.chkTVSeasonBannerOverwrite.UseVisualStyleBackColor = true
        '
        'gbTVSeasonPosterOpts
        '
        Me.gbTVSeasonPosterOpts.Controls.Add(Me.txtTVSeasonPosterWidth)
        Me.gbTVSeasonPosterOpts.Controls.Add(Me.txtTVSeasonPosterHeight)
        Me.gbTVSeasonPosterOpts.Controls.Add(Me.lblTVSeasonPosterQual)
        Me.gbTVSeasonPosterOpts.Controls.Add(Me.tbTVSeasonPosterQual)
        Me.gbTVSeasonPosterOpts.Controls.Add(Me.lblTVSeasonPosterQ)
        Me.gbTVSeasonPosterOpts.Controls.Add(Me.lblTVSeasonPosterWidth)
        Me.gbTVSeasonPosterOpts.Controls.Add(Me.lblTVSeasonPosterHeight)
        Me.gbTVSeasonPosterOpts.Controls.Add(Me.chkTVSeasonPosterResize)
        Me.gbTVSeasonPosterOpts.Controls.Add(Me.lblTVSeasonPosterSize)
        Me.gbTVSeasonPosterOpts.Controls.Add(Me.cbTVSeasonPosterPrefSize)
        Me.gbTVSeasonPosterOpts.Controls.Add(Me.chkTVSeasonPosterOverwrite)
        Me.gbTVSeasonPosterOpts.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.gbTVSeasonPosterOpts.Location = New System.Drawing.Point(6, 6)
        Me.gbTVSeasonPosterOpts.Name = "gbTVSeasonPosterOpts"
        Me.gbTVSeasonPosterOpts.Size = New System.Drawing.Size(228, 167)
        Me.gbTVSeasonPosterOpts.TabIndex = 0
        Me.gbTVSeasonPosterOpts.TabStop = false
        Me.gbTVSeasonPosterOpts.Text = "Poster"
        '
        'txtTVSeasonPosterWidth
        '
        Me.txtTVSeasonPosterWidth.Enabled = false
        Me.txtTVSeasonPosterWidth.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtTVSeasonPosterWidth.Location = New System.Drawing.Point(71, 90)
        Me.txtTVSeasonPosterWidth.Name = "txtTVSeasonPosterWidth"
        Me.txtTVSeasonPosterWidth.Size = New System.Drawing.Size(40, 22)
        Me.txtTVSeasonPosterWidth.TabIndex = 5
        '
        'txtTVSeasonPosterHeight
        '
        Me.txtTVSeasonPosterHeight.Enabled = false
        Me.txtTVSeasonPosterHeight.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtTVSeasonPosterHeight.Location = New System.Drawing.Point(182, 90)
        Me.txtTVSeasonPosterHeight.Name = "txtTVSeasonPosterHeight"
        Me.txtTVSeasonPosterHeight.Size = New System.Drawing.Size(40, 22)
        Me.txtTVSeasonPosterHeight.TabIndex = 7
        '
        'lblTVSeasonPosterQual
        '
        Me.lblTVSeasonPosterQual.AutoSize = true
        Me.lblTVSeasonPosterQual.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblTVSeasonPosterQual.Location = New System.Drawing.Point(183, 138)
        Me.lblTVSeasonPosterQual.Name = "lblTVSeasonPosterQual"
        Me.lblTVSeasonPosterQual.Size = New System.Drawing.Size(29, 17)
        Me.lblTVSeasonPosterQual.TabIndex = 10
        Me.lblTVSeasonPosterQual.Text = "100"
        '
        'tbTVSeasonPosterQual
        '
        Me.tbTVSeasonPosterQual.AutoSize = false
        Me.tbTVSeasonPosterQual.BackColor = System.Drawing.Color.White
        Me.tbTVSeasonPosterQual.LargeChange = 10
        Me.tbTVSeasonPosterQual.Location = New System.Drawing.Point(7, 131)
        Me.tbTVSeasonPosterQual.Maximum = 100
        Me.tbTVSeasonPosterQual.Name = "tbTVSeasonPosterQual"
        Me.tbTVSeasonPosterQual.Size = New System.Drawing.Size(179, 27)
        Me.tbTVSeasonPosterQual.TabIndex = 9
        Me.tbTVSeasonPosterQual.TickFrequency = 10
        Me.tbTVSeasonPosterQual.Value = 100
        '
        'lblTVSeasonPosterQ
        '
        Me.lblTVSeasonPosterQ.AutoSize = true
        Me.lblTVSeasonPosterQ.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblTVSeasonPosterQ.Location = New System.Drawing.Point(3, 118)
        Me.lblTVSeasonPosterQ.Name = "lblTVSeasonPosterQ"
        Me.lblTVSeasonPosterQ.Size = New System.Drawing.Size(46, 13)
        Me.lblTVSeasonPosterQ.TabIndex = 8
        Me.lblTVSeasonPosterQ.Text = "Quality:"
        '
        'lblTVSeasonPosterWidth
        '
        Me.lblTVSeasonPosterWidth.AutoSize = true
        Me.lblTVSeasonPosterWidth.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblTVSeasonPosterWidth.Location = New System.Drawing.Point(3, 94)
        Me.lblTVSeasonPosterWidth.Name = "lblTVSeasonPosterWidth"
        Me.lblTVSeasonPosterWidth.Size = New System.Drawing.Size(66, 13)
        Me.lblTVSeasonPosterWidth.TabIndex = 4
        Me.lblTVSeasonPosterWidth.Text = "Max Width:"
        '
        'lblTVSeasonPosterHeight
        '
        Me.lblTVSeasonPosterHeight.AutoSize = true
        Me.lblTVSeasonPosterHeight.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblTVSeasonPosterHeight.Location = New System.Drawing.Point(112, 94)
        Me.lblTVSeasonPosterHeight.Name = "lblTVSeasonPosterHeight"
        Me.lblTVSeasonPosterHeight.Size = New System.Drawing.Size(69, 13)
        Me.lblTVSeasonPosterHeight.TabIndex = 6
        Me.lblTVSeasonPosterHeight.Text = "Max Height:"
        '
        'chkTVSeasonPosterResize
        '
        Me.chkTVSeasonPosterResize.AutoSize = true
        Me.chkTVSeasonPosterResize.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkTVSeasonPosterResize.Location = New System.Drawing.Point(6, 69)
        Me.chkTVSeasonPosterResize.Name = "chkTVSeasonPosterResize"
        Me.chkTVSeasonPosterResize.Size = New System.Drawing.Size(133, 17)
        Me.chkTVSeasonPosterResize.TabIndex = 3
        Me.chkTVSeasonPosterResize.Text = "Automatically Resize:"
        Me.chkTVSeasonPosterResize.UseVisualStyleBackColor = true
        '
        'lblTVSeasonPosterSize
        '
        Me.lblTVSeasonPosterSize.AutoSize = true
        Me.lblTVSeasonPosterSize.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblTVSeasonPosterSize.Location = New System.Drawing.Point(3, 14)
        Me.lblTVSeasonPosterSize.Name = "lblTVSeasonPosterSize"
        Me.lblTVSeasonPosterSize.Size = New System.Drawing.Size(80, 13)
        Me.lblTVSeasonPosterSize.TabIndex = 0
        Me.lblTVSeasonPosterSize.Text = "Preferred Size:"
        '
        'cbTVSeasonPosterPrefSize
        '
        Me.cbTVSeasonPosterPrefSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTVSeasonPosterPrefSize.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.cbTVSeasonPosterPrefSize.FormattingEnabled = true
        Me.cbTVSeasonPosterPrefSize.Location = New System.Drawing.Point(6, 29)
        Me.cbTVSeasonPosterPrefSize.Name = "cbTVSeasonPosterPrefSize"
        Me.cbTVSeasonPosterPrefSize.Size = New System.Drawing.Size(148, 21)
        Me.cbTVSeasonPosterPrefSize.TabIndex = 1
        '
        'chkTVSeasonPosterOverwrite
        '
        Me.chkTVSeasonPosterOverwrite.AutoSize = true
        Me.chkTVSeasonPosterOverwrite.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkTVSeasonPosterOverwrite.Location = New System.Drawing.Point(6, 53)
        Me.chkTVSeasonPosterOverwrite.Name = "chkTVSeasonPosterOverwrite"
        Me.chkTVSeasonPosterOverwrite.Size = New System.Drawing.Size(119, 17)
        Me.chkTVSeasonPosterOverwrite.TabIndex = 2
        Me.chkTVSeasonPosterOverwrite.Text = "Overwrite Existing"
        Me.chkTVSeasonPosterOverwrite.UseVisualStyleBackColor = true
        '
        'gbTVSeasonFanartOpts
        '
        Me.gbTVSeasonFanartOpts.Controls.Add(Me.txtTVSeasonFanartWidth)
        Me.gbTVSeasonFanartOpts.Controls.Add(Me.txtTVSeasonFanartHeight)
        Me.gbTVSeasonFanartOpts.Controls.Add(Me.lblTVSeasonFanartQual)
        Me.gbTVSeasonFanartOpts.Controls.Add(Me.tbTVSeasonFanartQual)
        Me.gbTVSeasonFanartOpts.Controls.Add(Me.lblTVSeasonFanartQ)
        Me.gbTVSeasonFanartOpts.Controls.Add(Me.lblTVSeasonFanartWidth)
        Me.gbTVSeasonFanartOpts.Controls.Add(Me.lblTVSeasonFanartHeight)
        Me.gbTVSeasonFanartOpts.Controls.Add(Me.chkTVSeasonFanartResize)
        Me.gbTVSeasonFanartOpts.Controls.Add(Me.cbTVSeasonFanartPrefSize)
        Me.gbTVSeasonFanartOpts.Controls.Add(Me.lblTVSeasonFanartSize)
        Me.gbTVSeasonFanartOpts.Controls.Add(Me.chkTVSeasonFanartOverwrite)
        Me.gbTVSeasonFanartOpts.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.gbTVSeasonFanartOpts.Location = New System.Drawing.Point(474, 6)
        Me.gbTVSeasonFanartOpts.Name = "gbTVSeasonFanartOpts"
        Me.gbTVSeasonFanartOpts.Size = New System.Drawing.Size(228, 167)
        Me.gbTVSeasonFanartOpts.TabIndex = 1
        Me.gbTVSeasonFanartOpts.TabStop = false
        Me.gbTVSeasonFanartOpts.Text = "Fanart"
        '
        'txtTVSeasonFanartWidth
        '
        Me.txtTVSeasonFanartWidth.Enabled = false
        Me.txtTVSeasonFanartWidth.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtTVSeasonFanartWidth.Location = New System.Drawing.Point(71, 90)
        Me.txtTVSeasonFanartWidth.Name = "txtTVSeasonFanartWidth"
        Me.txtTVSeasonFanartWidth.Size = New System.Drawing.Size(40, 22)
        Me.txtTVSeasonFanartWidth.TabIndex = 5
        '
        'txtTVSeasonFanartHeight
        '
        Me.txtTVSeasonFanartHeight.Enabled = false
        Me.txtTVSeasonFanartHeight.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtTVSeasonFanartHeight.Location = New System.Drawing.Point(182, 90)
        Me.txtTVSeasonFanartHeight.Name = "txtTVSeasonFanartHeight"
        Me.txtTVSeasonFanartHeight.Size = New System.Drawing.Size(40, 22)
        Me.txtTVSeasonFanartHeight.TabIndex = 7
        '
        'lblTVSeasonFanartQual
        '
        Me.lblTVSeasonFanartQual.AutoSize = true
        Me.lblTVSeasonFanartQual.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblTVSeasonFanartQual.Location = New System.Drawing.Point(183, 138)
        Me.lblTVSeasonFanartQual.Name = "lblTVSeasonFanartQual"
        Me.lblTVSeasonFanartQual.Size = New System.Drawing.Size(29, 17)
        Me.lblTVSeasonFanartQual.TabIndex = 10
        Me.lblTVSeasonFanartQual.Text = "100"
        '
        'tbTVSeasonFanartQual
        '
        Me.tbTVSeasonFanartQual.AutoSize = false
        Me.tbTVSeasonFanartQual.BackColor = System.Drawing.Color.White
        Me.tbTVSeasonFanartQual.LargeChange = 10
        Me.tbTVSeasonFanartQual.Location = New System.Drawing.Point(7, 131)
        Me.tbTVSeasonFanartQual.Maximum = 100
        Me.tbTVSeasonFanartQual.Name = "tbTVSeasonFanartQual"
        Me.tbTVSeasonFanartQual.Size = New System.Drawing.Size(180, 27)
        Me.tbTVSeasonFanartQual.TabIndex = 9
        Me.tbTVSeasonFanartQual.TickFrequency = 10
        Me.tbTVSeasonFanartQual.Value = 100
        '
        'lblTVSeasonFanartQ
        '
        Me.lblTVSeasonFanartQ.AutoSize = true
        Me.lblTVSeasonFanartQ.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblTVSeasonFanartQ.Location = New System.Drawing.Point(3, 118)
        Me.lblTVSeasonFanartQ.Name = "lblTVSeasonFanartQ"
        Me.lblTVSeasonFanartQ.Size = New System.Drawing.Size(46, 13)
        Me.lblTVSeasonFanartQ.TabIndex = 8
        Me.lblTVSeasonFanartQ.Text = "Quality:"
        '
        'lblTVSeasonFanartWidth
        '
        Me.lblTVSeasonFanartWidth.AutoSize = true
        Me.lblTVSeasonFanartWidth.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblTVSeasonFanartWidth.Location = New System.Drawing.Point(3, 94)
        Me.lblTVSeasonFanartWidth.Name = "lblTVSeasonFanartWidth"
        Me.lblTVSeasonFanartWidth.Size = New System.Drawing.Size(66, 13)
        Me.lblTVSeasonFanartWidth.TabIndex = 4
        Me.lblTVSeasonFanartWidth.Text = "Max Width:"
        '
        'lblTVSeasonFanartHeight
        '
        Me.lblTVSeasonFanartHeight.AutoSize = true
        Me.lblTVSeasonFanartHeight.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblTVSeasonFanartHeight.Location = New System.Drawing.Point(112, 94)
        Me.lblTVSeasonFanartHeight.Name = "lblTVSeasonFanartHeight"
        Me.lblTVSeasonFanartHeight.Size = New System.Drawing.Size(69, 13)
        Me.lblTVSeasonFanartHeight.TabIndex = 6
        Me.lblTVSeasonFanartHeight.Text = "Max Height:"
        '
        'chkTVSeasonFanartResize
        '
        Me.chkTVSeasonFanartResize.AutoSize = true
        Me.chkTVSeasonFanartResize.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkTVSeasonFanartResize.Location = New System.Drawing.Point(6, 69)
        Me.chkTVSeasonFanartResize.Name = "chkTVSeasonFanartResize"
        Me.chkTVSeasonFanartResize.Size = New System.Drawing.Size(133, 17)
        Me.chkTVSeasonFanartResize.TabIndex = 3
        Me.chkTVSeasonFanartResize.Text = "Automatically Resize:"
        Me.chkTVSeasonFanartResize.UseVisualStyleBackColor = true
        '
        'cbTVSeasonFanartPrefSize
        '
        Me.cbTVSeasonFanartPrefSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTVSeasonFanartPrefSize.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.cbTVSeasonFanartPrefSize.FormattingEnabled = true
        Me.cbTVSeasonFanartPrefSize.Location = New System.Drawing.Point(6, 29)
        Me.cbTVSeasonFanartPrefSize.Name = "cbTVSeasonFanartPrefSize"
        Me.cbTVSeasonFanartPrefSize.Size = New System.Drawing.Size(148, 21)
        Me.cbTVSeasonFanartPrefSize.TabIndex = 1
        '
        'lblTVSeasonFanartSize
        '
        Me.lblTVSeasonFanartSize.AutoSize = true
        Me.lblTVSeasonFanartSize.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblTVSeasonFanartSize.Location = New System.Drawing.Point(3, 14)
        Me.lblTVSeasonFanartSize.Name = "lblTVSeasonFanartSize"
        Me.lblTVSeasonFanartSize.Size = New System.Drawing.Size(80, 13)
        Me.lblTVSeasonFanartSize.TabIndex = 0
        Me.lblTVSeasonFanartSize.Text = "Preferred Size:"
        '
        'chkTVSeasonFanartOverwrite
        '
        Me.chkTVSeasonFanartOverwrite.AutoSize = true
        Me.chkTVSeasonFanartOverwrite.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkTVSeasonFanartOverwrite.Location = New System.Drawing.Point(6, 53)
        Me.chkTVSeasonFanartOverwrite.Name = "chkTVSeasonFanartOverwrite"
        Me.chkTVSeasonFanartOverwrite.Size = New System.Drawing.Size(119, 17)
        Me.chkTVSeasonFanartOverwrite.TabIndex = 2
        Me.chkTVSeasonFanartOverwrite.Text = "Overwrite Existing"
        Me.chkTVSeasonFanartOverwrite.UseVisualStyleBackColor = true
        '
        'tpTVEpisode
        '
        Me.tpTVEpisode.Controls.Add(Me.gbTVEpisodePosterOpts)
        Me.tpTVEpisode.Controls.Add(Me.gbTVEpisodeFanartOpts)
        Me.tpTVEpisode.Location = New System.Drawing.Point(4, 22)
        Me.tpTVEpisode.Name = "tpTVEpisode"
        Me.tpTVEpisode.Padding = New System.Windows.Forms.Padding(3)
        Me.tpTVEpisode.Size = New System.Drawing.Size(734, 465)
        Me.tpTVEpisode.TabIndex = 1
        Me.tpTVEpisode.Text = "TV Episode"
        Me.tpTVEpisode.UseVisualStyleBackColor = true
        '
        'gbTVEpisodePosterOpts
        '
        Me.gbTVEpisodePosterOpts.Controls.Add(Me.txtTVEpisodePosterWidth)
        Me.gbTVEpisodePosterOpts.Controls.Add(Me.txtTVEpisodePosterHeight)
        Me.gbTVEpisodePosterOpts.Controls.Add(Me.lblTVEpisodePosterQual)
        Me.gbTVEpisodePosterOpts.Controls.Add(Me.tbTVEpisodePosterQual)
        Me.gbTVEpisodePosterOpts.Controls.Add(Me.lblTVEpisodePosterQ)
        Me.gbTVEpisodePosterOpts.Controls.Add(Me.lblTVEpisodePosterWidth)
        Me.gbTVEpisodePosterOpts.Controls.Add(Me.lblTVEpisodePosterHeight)
        Me.gbTVEpisodePosterOpts.Controls.Add(Me.chkTVEpisodePosterResize)
        Me.gbTVEpisodePosterOpts.Controls.Add(Me.chkTVEpisodePosterOverwrite)
        Me.gbTVEpisodePosterOpts.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.gbTVEpisodePosterOpts.Location = New System.Drawing.Point(6, 6)
        Me.gbTVEpisodePosterOpts.Name = "gbTVEpisodePosterOpts"
        Me.gbTVEpisodePosterOpts.Size = New System.Drawing.Size(228, 167)
        Me.gbTVEpisodePosterOpts.TabIndex = 0
        Me.gbTVEpisodePosterOpts.TabStop = false
        Me.gbTVEpisodePosterOpts.Text = "Poster"
        '
        'txtTVEpisodePosterWidth
        '
        Me.txtTVEpisodePosterWidth.Enabled = false
        Me.txtTVEpisodePosterWidth.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtTVEpisodePosterWidth.Location = New System.Drawing.Point(71, 90)
        Me.txtTVEpisodePosterWidth.Name = "txtTVEpisodePosterWidth"
        Me.txtTVEpisodePosterWidth.Size = New System.Drawing.Size(40, 22)
        Me.txtTVEpisodePosterWidth.TabIndex = 3
        '
        'txtTVEpisodePosterHeight
        '
        Me.txtTVEpisodePosterHeight.Enabled = false
        Me.txtTVEpisodePosterHeight.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtTVEpisodePosterHeight.Location = New System.Drawing.Point(182, 90)
        Me.txtTVEpisodePosterHeight.Name = "txtTVEpisodePosterHeight"
        Me.txtTVEpisodePosterHeight.Size = New System.Drawing.Size(40, 22)
        Me.txtTVEpisodePosterHeight.TabIndex = 5
        '
        'lblTVEpisodePosterQual
        '
        Me.lblTVEpisodePosterQual.AutoSize = true
        Me.lblTVEpisodePosterQual.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.lblTVEpisodePosterQual.Location = New System.Drawing.Point(183, 138)
        Me.lblTVEpisodePosterQual.Name = "lblTVEpisodePosterQual"
        Me.lblTVEpisodePosterQual.Size = New System.Drawing.Size(29, 17)
        Me.lblTVEpisodePosterQual.TabIndex = 8
        Me.lblTVEpisodePosterQual.Text = "100"
        '
        'tbTVEpisodePosterQual
        '
        Me.tbTVEpisodePosterQual.AutoSize = false
        Me.tbTVEpisodePosterQual.BackColor = System.Drawing.Color.White
        Me.tbTVEpisodePosterQual.LargeChange = 10
        Me.tbTVEpisodePosterQual.Location = New System.Drawing.Point(7, 131)
        Me.tbTVEpisodePosterQual.Maximum = 100
        Me.tbTVEpisodePosterQual.Name = "tbTVEpisodePosterQual"
        Me.tbTVEpisodePosterQual.Size = New System.Drawing.Size(179, 27)
        Me.tbTVEpisodePosterQual.TabIndex = 7
        Me.tbTVEpisodePosterQual.TickFrequency = 10
        Me.tbTVEpisodePosterQual.Value = 100
        '
        'lblTVEpisodePosterQ
        '
        Me.lblTVEpisodePosterQ.AutoSize = true
        Me.lblTVEpisodePosterQ.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblTVEpisodePosterQ.Location = New System.Drawing.Point(3, 118)
        Me.lblTVEpisodePosterQ.Name = "lblTVEpisodePosterQ"
        Me.lblTVEpisodePosterQ.Size = New System.Drawing.Size(46, 13)
        Me.lblTVEpisodePosterQ.TabIndex = 6
        Me.lblTVEpisodePosterQ.Text = "Quality:"
        '
        'lblTVEpisodePosterWidth
        '
        Me.lblTVEpisodePosterWidth.AutoSize = true
        Me.lblTVEpisodePosterWidth.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblTVEpisodePosterWidth.Location = New System.Drawing.Point(3, 94)
        Me.lblTVEpisodePosterWidth.Name = "lblTVEpisodePosterWidth"
        Me.lblTVEpisodePosterWidth.Size = New System.Drawing.Size(66, 13)
        Me.lblTVEpisodePosterWidth.TabIndex = 2
        Me.lblTVEpisodePosterWidth.Text = "Max Width:"
        '
        'lblTVEpisodePosterHeight
        '
        Me.lblTVEpisodePosterHeight.AutoSize = true
        Me.lblTVEpisodePosterHeight.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblTVEpisodePosterHeight.Location = New System.Drawing.Point(112, 94)
        Me.lblTVEpisodePosterHeight.Name = "lblTVEpisodePosterHeight"
        Me.lblTVEpisodePosterHeight.Size = New System.Drawing.Size(69, 13)
        Me.lblTVEpisodePosterHeight.TabIndex = 4
        Me.lblTVEpisodePosterHeight.Text = "Max Height:"
        '
        'chkTVEpisodePosterResize
        '
        Me.chkTVEpisodePosterResize.AutoSize = true
        Me.chkTVEpisodePosterResize.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkTVEpisodePosterResize.Location = New System.Drawing.Point(6, 69)
        Me.chkTVEpisodePosterResize.Name = "chkTVEpisodePosterResize"
        Me.chkTVEpisodePosterResize.Size = New System.Drawing.Size(133, 17)
        Me.chkTVEpisodePosterResize.TabIndex = 1
        Me.chkTVEpisodePosterResize.Text = "Automatically Resize:"
        Me.chkTVEpisodePosterResize.UseVisualStyleBackColor = true
        '
        'chkTVEpisodePosterOverwrite
        '
        Me.chkTVEpisodePosterOverwrite.AutoSize = true
        Me.chkTVEpisodePosterOverwrite.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkTVEpisodePosterOverwrite.Location = New System.Drawing.Point(6, 53)
        Me.chkTVEpisodePosterOverwrite.Name = "chkTVEpisodePosterOverwrite"
        Me.chkTVEpisodePosterOverwrite.Size = New System.Drawing.Size(119, 17)
        Me.chkTVEpisodePosterOverwrite.TabIndex = 0
        Me.chkTVEpisodePosterOverwrite.Text = "Overwrite Existing"
        Me.chkTVEpisodePosterOverwrite.UseVisualStyleBackColor = true
        '
        'gbTVEpisodeFanartOpts
        '
        Me.gbTVEpisodeFanartOpts.Controls.Add(Me.txtTVEpisodeFanartWidth)
        Me.gbTVEpisodeFanartOpts.Controls.Add(Me.txtTVEpisodeFanartHeight)
        Me.gbTVEpisodeFanartOpts.Controls.Add(Me.lblTVEpisodeFanartQual)
        Me.gbTVEpisodeFanartOpts.Controls.Add(Me.tbTVEpisodeFanartQual)
        Me.gbTVEpisodeFanartOpts.Controls.Add(Me.lblTVEpisodeFanartQ)
        Me.gbTVEpisodeFanartOpts.Controls.Add(Me.lblTVEpisodeFanartWidth)
        Me.gbTVEpisodeFanartOpts.Controls.Add(Me.lblTVEpisodeFanartHeight)
        Me.gbTVEpisodeFanartOpts.Controls.Add(Me.chkTVEpisodeFanartResize)
        Me.gbTVEpisodeFanartOpts.Controls.Add(Me.cbTVEpisodeFanartPrefSize)
        Me.gbTVEpisodeFanartOpts.Controls.Add(Me.lblTVEpisodeFanartSize)
        Me.gbTVEpisodeFanartOpts.Controls.Add(Me.chkTVEpisodeFanartOverwrite)
        Me.gbTVEpisodeFanartOpts.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.gbTVEpisodeFanartOpts.Location = New System.Drawing.Point(240, 6)
        Me.gbTVEpisodeFanartOpts.Name = "gbTVEpisodeFanartOpts"
        Me.gbTVEpisodeFanartOpts.Size = New System.Drawing.Size(228, 167)
        Me.gbTVEpisodeFanartOpts.TabIndex = 1
        Me.gbTVEpisodeFanartOpts.TabStop = false
        Me.gbTVEpisodeFanartOpts.Text = "Fanart"
        '
        'txtTVEpisodeFanartWidth
        '
        Me.txtTVEpisodeFanartWidth.Enabled = false
        Me.txtTVEpisodeFanartWidth.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtTVEpisodeFanartWidth.Location = New System.Drawing.Point(71, 90)
        Me.txtTVEpisodeFanartWidth.Name = "txtTVEpisodeFanartWidth"
        Me.txtTVEpisodeFanartWidth.Size = New System.Drawing.Size(40, 22)
        Me.txtTVEpisodeFanartWidth.TabIndex = 5
        '
        'txtTVEpisodeFanartHeight
        '
        Me.txtTVEpisodeFanartHeight.Enabled = false
        Me.txtTVEpisodeFanartHeight.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtTVEpisodeFanartHeight.Location = New System.Drawing.Point(182, 90)
        Me.txtTVEpisodeFanartHeight.Name = "txtTVEpisodeFanartHeight"
        Me.txtTVEpisodeFanartHeight.Size = New System.Drawing.Size(40, 22)
        Me.txtTVEpisodeFanartHeight.TabIndex = 7
        '
        'lblTVEpisodeFanartQual
        '
        Me.lblTVEpisodeFanartQual.AutoSize = true
        Me.lblTVEpisodeFanartQual.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.lblTVEpisodeFanartQual.Location = New System.Drawing.Point(183, 138)
        Me.lblTVEpisodeFanartQual.Name = "lblTVEpisodeFanartQual"
        Me.lblTVEpisodeFanartQual.Size = New System.Drawing.Size(29, 17)
        Me.lblTVEpisodeFanartQual.TabIndex = 10
        Me.lblTVEpisodeFanartQual.Text = "100"
        '
        'tbTVEpisodeFanartQual
        '
        Me.tbTVEpisodeFanartQual.AutoSize = false
        Me.tbTVEpisodeFanartQual.BackColor = System.Drawing.Color.White
        Me.tbTVEpisodeFanartQual.LargeChange = 10
        Me.tbTVEpisodeFanartQual.Location = New System.Drawing.Point(7, 131)
        Me.tbTVEpisodeFanartQual.Maximum = 100
        Me.tbTVEpisodeFanartQual.Name = "tbTVEpisodeFanartQual"
        Me.tbTVEpisodeFanartQual.Size = New System.Drawing.Size(180, 27)
        Me.tbTVEpisodeFanartQual.TabIndex = 9
        Me.tbTVEpisodeFanartQual.TickFrequency = 10
        Me.tbTVEpisodeFanartQual.Value = 100
        '
        'lblTVEpisodeFanartQ
        '
        Me.lblTVEpisodeFanartQ.AutoSize = true
        Me.lblTVEpisodeFanartQ.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblTVEpisodeFanartQ.Location = New System.Drawing.Point(3, 118)
        Me.lblTVEpisodeFanartQ.Name = "lblTVEpisodeFanartQ"
        Me.lblTVEpisodeFanartQ.Size = New System.Drawing.Size(46, 13)
        Me.lblTVEpisodeFanartQ.TabIndex = 8
        Me.lblTVEpisodeFanartQ.Text = "Quality:"
        '
        'lblTVEpisodeFanartWidth
        '
        Me.lblTVEpisodeFanartWidth.AutoSize = true
        Me.lblTVEpisodeFanartWidth.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblTVEpisodeFanartWidth.Location = New System.Drawing.Point(3, 94)
        Me.lblTVEpisodeFanartWidth.Name = "lblTVEpisodeFanartWidth"
        Me.lblTVEpisodeFanartWidth.Size = New System.Drawing.Size(66, 13)
        Me.lblTVEpisodeFanartWidth.TabIndex = 4
        Me.lblTVEpisodeFanartWidth.Text = "Max Width:"
        '
        'lblTVEpisodeFanartHeight
        '
        Me.lblTVEpisodeFanartHeight.AutoSize = true
        Me.lblTVEpisodeFanartHeight.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblTVEpisodeFanartHeight.Location = New System.Drawing.Point(112, 94)
        Me.lblTVEpisodeFanartHeight.Name = "lblTVEpisodeFanartHeight"
        Me.lblTVEpisodeFanartHeight.Size = New System.Drawing.Size(69, 13)
        Me.lblTVEpisodeFanartHeight.TabIndex = 6
        Me.lblTVEpisodeFanartHeight.Text = "Max Height:"
        '
        'chkTVEpisodeFanartResize
        '
        Me.chkTVEpisodeFanartResize.AutoSize = true
        Me.chkTVEpisodeFanartResize.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkTVEpisodeFanartResize.Location = New System.Drawing.Point(6, 69)
        Me.chkTVEpisodeFanartResize.Name = "chkTVEpisodeFanartResize"
        Me.chkTVEpisodeFanartResize.Size = New System.Drawing.Size(133, 17)
        Me.chkTVEpisodeFanartResize.TabIndex = 3
        Me.chkTVEpisodeFanartResize.Text = "Automatically Resize:"
        Me.chkTVEpisodeFanartResize.UseVisualStyleBackColor = true
        '
        'cbTVEpisodeFanartPrefSize
        '
        Me.cbTVEpisodeFanartPrefSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTVEpisodeFanartPrefSize.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.cbTVEpisodeFanartPrefSize.FormattingEnabled = true
        Me.cbTVEpisodeFanartPrefSize.Location = New System.Drawing.Point(6, 29)
        Me.cbTVEpisodeFanartPrefSize.Name = "cbTVEpisodeFanartPrefSize"
        Me.cbTVEpisodeFanartPrefSize.Size = New System.Drawing.Size(148, 21)
        Me.cbTVEpisodeFanartPrefSize.TabIndex = 1
        '
        'lblTVEpisodeFanartSize
        '
        Me.lblTVEpisodeFanartSize.AutoSize = true
        Me.lblTVEpisodeFanartSize.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblTVEpisodeFanartSize.Location = New System.Drawing.Point(3, 14)
        Me.lblTVEpisodeFanartSize.Name = "lblTVEpisodeFanartSize"
        Me.lblTVEpisodeFanartSize.Size = New System.Drawing.Size(80, 13)
        Me.lblTVEpisodeFanartSize.TabIndex = 0
        Me.lblTVEpisodeFanartSize.Text = "Preferred Size:"
        '
        'chkTVEpisodeFanartOverwrite
        '
        Me.chkTVEpisodeFanartOverwrite.AutoSize = true
        Me.chkTVEpisodeFanartOverwrite.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkTVEpisodeFanartOverwrite.Location = New System.Drawing.Point(6, 53)
        Me.chkTVEpisodeFanartOverwrite.Name = "chkTVEpisodeFanartOverwrite"
        Me.chkTVEpisodeFanartOverwrite.Size = New System.Drawing.Size(119, 17)
        Me.chkTVEpisodeFanartOverwrite.TabIndex = 2
        Me.chkTVEpisodeFanartOverwrite.Text = "Overwrite Existing"
        Me.chkTVEpisodeFanartOverwrite.UseVisualStyleBackColor = true
        '
        'pnlTVScraper
        '
        Me.pnlTVScraper.BackColor = System.Drawing.Color.White
<<<<<<< HEAD
        Me.pnlTVScraper.Controls.Add(Me.gbTVScraperDuration)
        Me.pnlTVScraper.Controls.Add(Me.GroupBox32)
        Me.pnlTVScraper.Controls.Add(Me.GroupBox33)
        Me.pnlTVScraper.Controls.Add(Me.GroupBox31)
        Me.pnlTVScraper.Controls.Add(Me.gbTVScraperOptions)
        Me.pnlTVScraper.Location = New System.Drawing.Point(1150, 590)
=======
        Me.pnlTVScraper.Controls.Add(Me.gbTVScraperDurationOpts)
        Me.pnlTVScraper.Controls.Add(Me.gbTVScraperFieldsOpts)
        Me.pnlTVScraper.Controls.Add(Me.gbTVScraperGlobalLocksOpts)
        Me.pnlTVScraper.Controls.Add(Me.gbTVScraperMetaDataOpts)
        Me.pnlTVScraper.Controls.Add(Me.gbTVScraperOptionsOpts)
        Me.pnlTVScraper.Location = New System.Drawing.Point(900, 900)
>>>>>>> upstream/master
        Me.pnlTVScraper.Name = "pnlTVScraper"
        Me.pnlTVScraper.Size = New System.Drawing.Size(750, 500)
        Me.pnlTVScraper.TabIndex = 19
        Me.pnlTVScraper.Visible = false
        '
        'gbTVScraperDurationOpts
        '
        Me.gbTVScraperDurationOpts.Controls.Add(Me.lblTVScraperDurationRuntimeFormat)
        Me.gbTVScraperDurationOpts.Controls.Add(Me.chkTVScraperUseMDDuration)
        Me.gbTVScraperDurationOpts.Controls.Add(Me.txtTVScraperDurationRuntimeFormat)
        Me.gbTVScraperDurationOpts.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.gbTVScraperDurationOpts.Location = New System.Drawing.Point(412, 255)
        Me.gbTVScraperDurationOpts.Name = "gbTVScraperDurationOpts"
        Me.gbTVScraperDurationOpts.Size = New System.Drawing.Size(335, 114)
        Me.gbTVScraperDurationOpts.TabIndex = 4
        Me.gbTVScraperDurationOpts.TabStop = false
        Me.gbTVScraperDurationOpts.Text = "Duration Format"
        '
        'lblTVScraperDurationRuntimeFormat
        '
        Me.lblTVScraperDurationRuntimeFormat.Font = New System.Drawing.Font("Segoe UI", 7!)
        Me.lblTVScraperDurationRuntimeFormat.Location = New System.Drawing.Point(234, 21)
        Me.lblTVScraperDurationRuntimeFormat.Name = "lblTVScraperDurationRuntimeFormat"
        Me.lblTVScraperDurationRuntimeFormat.Size = New System.Drawing.Size(72, 50)
        Me.lblTVScraperDurationRuntimeFormat.TabIndex = 24
        Me.lblTVScraperDurationRuntimeFormat.Text = "<h>=Hours"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"<m>=Minutes"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"<s>=Seconds"
        Me.lblTVScraperDurationRuntimeFormat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chkTVScraperUseMDDuration
        '
        Me.chkTVScraperUseMDDuration.AutoSize = true
        Me.chkTVScraperUseMDDuration.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkTVScraperUseMDDuration.Location = New System.Drawing.Point(9, 21)
        Me.chkTVScraperUseMDDuration.Name = "chkTVScraperUseMDDuration"
        Me.chkTVScraperUseMDDuration.Size = New System.Drawing.Size(158, 17)
        Me.chkTVScraperUseMDDuration.TabIndex = 1
        Me.chkTVScraperUseMDDuration.Text = "Use Duration for Runtime"
        Me.chkTVScraperUseMDDuration.UseVisualStyleBackColor = true
        '
        'txtTVScraperDurationRuntimeFormat
        '
        Me.txtTVScraperDurationRuntimeFormat.Location = New System.Drawing.Point(9, 44)
        Me.txtTVScraperDurationRuntimeFormat.Name = "txtTVScraperDurationRuntimeFormat"
        Me.txtTVScraperDurationRuntimeFormat.Size = New System.Drawing.Size(188, 22)
        Me.txtTVScraperDurationRuntimeFormat.TabIndex = 0
        '
        'gbTVScraperFieldsOpts
        '
        Me.gbTVScraperFieldsOpts.Controls.Add(Me.gbTVScraperFieldsShowOpts)
        Me.gbTVScraperFieldsOpts.Controls.Add(Me.gbTVScraperFieldsEpisodeOpts)
        Me.gbTVScraperFieldsOpts.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.gbTVScraperFieldsOpts.Location = New System.Drawing.Point(3, 255)
        Me.gbTVScraperFieldsOpts.Name = "gbTVScraperFieldsOpts"
        Me.gbTVScraperFieldsOpts.Size = New System.Drawing.Size(403, 114)
        Me.gbTVScraperFieldsOpts.TabIndex = 3
        Me.gbTVScraperFieldsOpts.TabStop = false
        Me.gbTVScraperFieldsOpts.Text = "Scraper Fields"
        '
        'gbTVScraperFieldsShowOpts
        '
        Me.gbTVScraperFieldsShowOpts.Controls.Add(Me.chkTVScraperShowStatus)
        Me.gbTVScraperFieldsShowOpts.Controls.Add(Me.chkTVScraperShowRating)
        Me.gbTVScraperFieldsShowOpts.Controls.Add(Me.chkTVScraperShowActors)
        Me.gbTVScraperFieldsShowOpts.Controls.Add(Me.chkTVScraperShowStudio)
        Me.gbTVScraperFieldsShowOpts.Controls.Add(Me.chkTVScraperShowPremiered)
        Me.gbTVScraperFieldsShowOpts.Controls.Add(Me.chkTVScraperShowEpiGuideURL)
        Me.gbTVScraperFieldsShowOpts.Controls.Add(Me.chkTVScraperShowMPAA)
        Me.gbTVScraperFieldsShowOpts.Controls.Add(Me.chkTVScraperShowPlot)
        Me.gbTVScraperFieldsShowOpts.Controls.Add(Me.chkTVScraperShowGenre)
        Me.gbTVScraperFieldsShowOpts.Controls.Add(Me.chkTVScraperShowTitle)
        Me.gbTVScraperFieldsShowOpts.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.gbTVScraperFieldsShowOpts.Location = New System.Drawing.Point(3, 14)
        Me.gbTVScraperFieldsShowOpts.Name = "gbTVScraperFieldsShowOpts"
        Me.gbTVScraperFieldsShowOpts.Size = New System.Drawing.Size(213, 96)
        Me.gbTVScraperFieldsShowOpts.TabIndex = 0
        Me.gbTVScraperFieldsShowOpts.TabStop = false
        Me.gbTVScraperFieldsShowOpts.Text = "Show"
        '
        'chkTVScraperShowStatus
        '
        Me.chkTVScraperShowStatus.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkTVScraperShowStatus.Location = New System.Drawing.Point(130, 77)
        Me.chkTVScraperShowStatus.Name = "chkTVScraperShowStatus"
        Me.chkTVScraperShowStatus.Size = New System.Drawing.Size(78, 17)
        Me.chkTVScraperShowStatus.TabIndex = 9
        Me.chkTVScraperShowStatus.Text = "Status"
        Me.chkTVScraperShowStatus.UseVisualStyleBackColor = true
        '
        'chkTVScraperShowRating
        '
        Me.chkTVScraperShowRating.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkTVScraperShowRating.Location = New System.Drawing.Point(130, 29)
        Me.chkTVScraperShowRating.Name = "chkTVScraperShowRating"
        Me.chkTVScraperShowRating.Size = New System.Drawing.Size(78, 17)
        Me.chkTVScraperShowRating.TabIndex = 6
        Me.chkTVScraperShowRating.Text = "Rating"
        Me.chkTVScraperShowRating.UseVisualStyleBackColor = true
        '
        'chkTVScraperShowActors
        '
        Me.chkTVScraperShowActors.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkTVScraperShowActors.Location = New System.Drawing.Point(130, 61)
        Me.chkTVScraperShowActors.Name = "chkTVScraperShowActors"
        Me.chkTVScraperShowActors.Size = New System.Drawing.Size(78, 17)
        Me.chkTVScraperShowActors.TabIndex = 8
        Me.chkTVScraperShowActors.Text = "Actors"
        Me.chkTVScraperShowActors.UseVisualStyleBackColor = true
        '
        'chkTVScraperShowStudio
        '
        Me.chkTVScraperShowStudio.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkTVScraperShowStudio.Location = New System.Drawing.Point(130, 45)
        Me.chkTVScraperShowStudio.Name = "chkTVScraperShowStudio"
        Me.chkTVScraperShowStudio.Size = New System.Drawing.Size(78, 17)
        Me.chkTVScraperShowStudio.TabIndex = 7
        Me.chkTVScraperShowStudio.Text = "Studio"
        Me.chkTVScraperShowStudio.UseVisualStyleBackColor = true
        '
        'chkTVScraperShowPremiered
        '
        Me.chkTVScraperShowPremiered.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkTVScraperShowPremiered.Location = New System.Drawing.Point(130, 13)
        Me.chkTVScraperShowPremiered.Name = "chkTVScraperShowPremiered"
        Me.chkTVScraperShowPremiered.Size = New System.Drawing.Size(78, 17)
        Me.chkTVScraperShowPremiered.TabIndex = 5
        Me.chkTVScraperShowPremiered.Text = "Premiered"
        Me.chkTVScraperShowPremiered.UseVisualStyleBackColor = true
        '
        'chkTVScraperShowEpiGuideURL
        '
        Me.chkTVScraperShowEpiGuideURL.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkTVScraperShowEpiGuideURL.Location = New System.Drawing.Point(6, 29)
        Me.chkTVScraperShowEpiGuideURL.Name = "chkTVScraperShowEpiGuideURL"
        Me.chkTVScraperShowEpiGuideURL.Size = New System.Drawing.Size(118, 17)
        Me.chkTVScraperShowEpiGuideURL.TabIndex = 1
        Me.chkTVScraperShowEpiGuideURL.Text = "EpisodeGuideURL"
        Me.chkTVScraperShowEpiGuideURL.UseVisualStyleBackColor = true
        '
        'chkTVScraperShowMPAA
        '
        Me.chkTVScraperShowMPAA.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkTVScraperShowMPAA.Location = New System.Drawing.Point(6, 61)
        Me.chkTVScraperShowMPAA.Name = "chkTVScraperShowMPAA"
        Me.chkTVScraperShowMPAA.Size = New System.Drawing.Size(119, 17)
        Me.chkTVScraperShowMPAA.TabIndex = 3
        Me.chkTVScraperShowMPAA.Text = "MPAA"
        Me.chkTVScraperShowMPAA.UseVisualStyleBackColor = true
        '
        'chkTVScraperShowPlot
        '
        Me.chkTVScraperShowPlot.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkTVScraperShowPlot.Location = New System.Drawing.Point(6, 77)
        Me.chkTVScraperShowPlot.Name = "chkTVScraperShowPlot"
        Me.chkTVScraperShowPlot.Size = New System.Drawing.Size(119, 17)
        Me.chkTVScraperShowPlot.TabIndex = 4
        Me.chkTVScraperShowPlot.Text = "Plot"
        Me.chkTVScraperShowPlot.UseVisualStyleBackColor = true
        '
        'chkTVScraperShowGenre
        '
        Me.chkTVScraperShowGenre.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkTVScraperShowGenre.Location = New System.Drawing.Point(6, 45)
        Me.chkTVScraperShowGenre.Name = "chkTVScraperShowGenre"
        Me.chkTVScraperShowGenre.Size = New System.Drawing.Size(118, 17)
        Me.chkTVScraperShowGenre.TabIndex = 2
        Me.chkTVScraperShowGenre.Text = "Genre"
        Me.chkTVScraperShowGenre.UseVisualStyleBackColor = true
        '
        'chkTVScraperShowTitle
        '
        Me.chkTVScraperShowTitle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkTVScraperShowTitle.Location = New System.Drawing.Point(6, 13)
        Me.chkTVScraperShowTitle.Name = "chkTVScraperShowTitle"
        Me.chkTVScraperShowTitle.Size = New System.Drawing.Size(118, 17)
        Me.chkTVScraperShowTitle.TabIndex = 0
        Me.chkTVScraperShowTitle.Text = "Title"
        Me.chkTVScraperShowTitle.UseVisualStyleBackColor = true
        '
        'gbTVScraperFieldsEpisodeOpts
        '
        Me.gbTVScraperFieldsEpisodeOpts.Controls.Add(Me.chkTVScraperEpisodeActors)
        Me.gbTVScraperFieldsEpisodeOpts.Controls.Add(Me.chkTVScraperEpisodeCredits)
        Me.gbTVScraperFieldsEpisodeOpts.Controls.Add(Me.chkTVScraperEpisodeDirector)
        Me.gbTVScraperFieldsEpisodeOpts.Controls.Add(Me.chkTVScraperEpisodePlot)
        Me.gbTVScraperFieldsEpisodeOpts.Controls.Add(Me.chkTVScraperEpisodeRating)
        Me.gbTVScraperFieldsEpisodeOpts.Controls.Add(Me.chkTVScraperEpisodeAired)
        Me.gbTVScraperFieldsEpisodeOpts.Controls.Add(Me.chkTVScraperEpisodeTitle)
        Me.gbTVScraperFieldsEpisodeOpts.Controls.Add(Me.chkTVScraperEpisodeEpisode)
        Me.gbTVScraperFieldsEpisodeOpts.Controls.Add(Me.chkTVScraperEpisodeSeason)
        Me.gbTVScraperFieldsEpisodeOpts.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.gbTVScraperFieldsEpisodeOpts.Location = New System.Drawing.Point(219, 14)
        Me.gbTVScraperFieldsEpisodeOpts.Name = "gbTVScraperFieldsEpisodeOpts"
        Me.gbTVScraperFieldsEpisodeOpts.Size = New System.Drawing.Size(181, 96)
        Me.gbTVScraperFieldsEpisodeOpts.TabIndex = 1
        Me.gbTVScraperFieldsEpisodeOpts.TabStop = false
        Me.gbTVScraperFieldsEpisodeOpts.Text = "Episode"
        '
        'chkTVScraperEpisodeActors
        '
        Me.chkTVScraperEpisodeActors.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkTVScraperEpisodeActors.Location = New System.Drawing.Point(94, 60)
        Me.chkTVScraperEpisodeActors.Name = "chkTVScraperEpisodeActors"
        Me.chkTVScraperEpisodeActors.Size = New System.Drawing.Size(67, 17)
        Me.chkTVScraperEpisodeActors.TabIndex = 0
        Me.chkTVScraperEpisodeActors.Text = "Actors"
        Me.chkTVScraperEpisodeActors.UseVisualStyleBackColor = true
        '
        'chkTVScraperEpisodeCredits
        '
        Me.chkTVScraperEpisodeCredits.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkTVScraperEpisodeCredits.Location = New System.Drawing.Point(94, 44)
        Me.chkTVScraperEpisodeCredits.Name = "chkTVScraperEpisodeCredits"
        Me.chkTVScraperEpisodeCredits.Size = New System.Drawing.Size(67, 17)
        Me.chkTVScraperEpisodeCredits.TabIndex = 8
        Me.chkTVScraperEpisodeCredits.Text = "Credits"
        Me.chkTVScraperEpisodeCredits.UseVisualStyleBackColor = true
        '
        'chkTVScraperEpisodeDirector
        '
        Me.chkTVScraperEpisodeDirector.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkTVScraperEpisodeDirector.Location = New System.Drawing.Point(94, 28)
        Me.chkTVScraperEpisodeDirector.Name = "chkTVScraperEpisodeDirector"
        Me.chkTVScraperEpisodeDirector.Size = New System.Drawing.Size(67, 17)
        Me.chkTVScraperEpisodeDirector.TabIndex = 7
        Me.chkTVScraperEpisodeDirector.Text = "Director"
        Me.chkTVScraperEpisodeDirector.UseVisualStyleBackColor = true
        '
        'chkTVScraperEpisodePlot
        '
        Me.chkTVScraperEpisodePlot.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkTVScraperEpisodePlot.Location = New System.Drawing.Point(94, 12)
        Me.chkTVScraperEpisodePlot.Name = "chkTVScraperEpisodePlot"
        Me.chkTVScraperEpisodePlot.Size = New System.Drawing.Size(67, 17)
        Me.chkTVScraperEpisodePlot.TabIndex = 6
        Me.chkTVScraperEpisodePlot.Text = "Plot"
        Me.chkTVScraperEpisodePlot.UseVisualStyleBackColor = true
        '
        'chkTVScraperEpisodeRating
        '
        Me.chkTVScraperEpisodeRating.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkTVScraperEpisodeRating.Location = New System.Drawing.Point(6, 77)
        Me.chkTVScraperEpisodeRating.Name = "chkTVScraperEpisodeRating"
        Me.chkTVScraperEpisodeRating.Size = New System.Drawing.Size(67, 17)
        Me.chkTVScraperEpisodeRating.TabIndex = 5
        Me.chkTVScraperEpisodeRating.Text = "Rating"
        Me.chkTVScraperEpisodeRating.UseVisualStyleBackColor = true
        '
        'chkTVScraperEpisodeAired
        '
        Me.chkTVScraperEpisodeAired.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkTVScraperEpisodeAired.Location = New System.Drawing.Point(6, 61)
        Me.chkTVScraperEpisodeAired.Name = "chkTVScraperEpisodeAired"
        Me.chkTVScraperEpisodeAired.Size = New System.Drawing.Size(67, 17)
        Me.chkTVScraperEpisodeAired.TabIndex = 4
        Me.chkTVScraperEpisodeAired.Text = "Aired"
        Me.chkTVScraperEpisodeAired.UseVisualStyleBackColor = true
        '
        'chkTVScraperEpisodeTitle
        '
        Me.chkTVScraperEpisodeTitle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkTVScraperEpisodeTitle.Location = New System.Drawing.Point(6, 13)
        Me.chkTVScraperEpisodeTitle.Name = "chkTVScraperEpisodeTitle"
        Me.chkTVScraperEpisodeTitle.Size = New System.Drawing.Size(67, 17)
        Me.chkTVScraperEpisodeTitle.TabIndex = 0
        Me.chkTVScraperEpisodeTitle.Text = "Title"
        Me.chkTVScraperEpisodeTitle.UseVisualStyleBackColor = true
        '
        'chkTVScraperEpisodeEpisode
        '
        Me.chkTVScraperEpisodeEpisode.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkTVScraperEpisodeEpisode.Location = New System.Drawing.Point(6, 45)
        Me.chkTVScraperEpisodeEpisode.Name = "chkTVScraperEpisodeEpisode"
        Me.chkTVScraperEpisodeEpisode.Size = New System.Drawing.Size(67, 17)
        Me.chkTVScraperEpisodeEpisode.TabIndex = 3
        Me.chkTVScraperEpisodeEpisode.Text = "Episode"
        Me.chkTVScraperEpisodeEpisode.UseVisualStyleBackColor = true
        '
        'chkTVScraperEpisodeSeason
        '
        Me.chkTVScraperEpisodeSeason.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkTVScraperEpisodeSeason.Location = New System.Drawing.Point(6, 29)
        Me.chkTVScraperEpisodeSeason.Name = "chkTVScraperEpisodeSeason"
        Me.chkTVScraperEpisodeSeason.Size = New System.Drawing.Size(67, 17)
        Me.chkTVScraperEpisodeSeason.TabIndex = 2
        Me.chkTVScraperEpisodeSeason.Text = "Season"
        Me.chkTVScraperEpisodeSeason.UseVisualStyleBackColor = true
        '
        'gbTVScraperGlobalLocksOpts
        '
        Me.gbTVScraperGlobalLocksOpts.Controls.Add(Me.gbTVScraperGlobalLocksEpisodeOpts)
        Me.gbTVScraperGlobalLocksOpts.Controls.Add(Me.gbTVScraperGlobalLocksShowOpts)
        Me.gbTVScraperGlobalLocksOpts.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.gbTVScraperGlobalLocksOpts.Location = New System.Drawing.Point(208, 6)
        Me.gbTVScraperGlobalLocksOpts.Name = "gbTVScraperGlobalLocksOpts"
        Me.gbTVScraperGlobalLocksOpts.Size = New System.Drawing.Size(191, 243)
        Me.gbTVScraperGlobalLocksOpts.TabIndex = 1
        Me.gbTVScraperGlobalLocksOpts.TabStop = false
        Me.gbTVScraperGlobalLocksOpts.Text = "Global Locks"
        '
        'gbTVScraperGlobalLocksEpisodeOpts
        '
        Me.gbTVScraperGlobalLocksEpisodeOpts.Controls.Add(Me.chkTVLockEpisodeTitle)
        Me.gbTVScraperGlobalLocksEpisodeOpts.Controls.Add(Me.chkTVLockEpisodeRating)
        Me.gbTVScraperGlobalLocksEpisodeOpts.Controls.Add(Me.chkTVLockEpisodePlot)
        Me.gbTVScraperGlobalLocksEpisodeOpts.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.gbTVScraperGlobalLocksEpisodeOpts.Location = New System.Drawing.Point(5, 129)
        Me.gbTVScraperGlobalLocksEpisodeOpts.Name = "gbTVScraperGlobalLocksEpisodeOpts"
        Me.gbTVScraperGlobalLocksEpisodeOpts.Size = New System.Drawing.Size(181, 66)
        Me.gbTVScraperGlobalLocksEpisodeOpts.TabIndex = 1
        Me.gbTVScraperGlobalLocksEpisodeOpts.TabStop = false
        Me.gbTVScraperGlobalLocksEpisodeOpts.Text = "Episode"
        '
        'chkTVLockEpisodeTitle
        '
        Me.chkTVLockEpisodeTitle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkTVLockEpisodeTitle.Location = New System.Drawing.Point(6, 15)
        Me.chkTVLockEpisodeTitle.Name = "chkTVLockEpisodeTitle"
        Me.chkTVLockEpisodeTitle.Size = New System.Drawing.Size(166, 17)
        Me.chkTVLockEpisodeTitle.TabIndex = 0
        Me.chkTVLockEpisodeTitle.Text = "Lock Title"
        Me.chkTVLockEpisodeTitle.UseVisualStyleBackColor = true
        '
        'chkTVLockEpisodeRating
        '
        Me.chkTVLockEpisodeRating.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkTVLockEpisodeRating.Location = New System.Drawing.Point(6, 47)
        Me.chkTVLockEpisodeRating.Name = "chkTVLockEpisodeRating"
        Me.chkTVLockEpisodeRating.Size = New System.Drawing.Size(168, 17)
        Me.chkTVLockEpisodeRating.TabIndex = 2
        Me.chkTVLockEpisodeRating.Text = "Lock Rating"
        Me.chkTVLockEpisodeRating.UseVisualStyleBackColor = true
        '
        'chkTVLockEpisodePlot
        '
        Me.chkTVLockEpisodePlot.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkTVLockEpisodePlot.Location = New System.Drawing.Point(6, 31)
        Me.chkTVLockEpisodePlot.Name = "chkTVLockEpisodePlot"
        Me.chkTVLockEpisodePlot.Size = New System.Drawing.Size(166, 17)
        Me.chkTVLockEpisodePlot.TabIndex = 1
        Me.chkTVLockEpisodePlot.Text = "Lock Plot"
        Me.chkTVLockEpisodePlot.UseVisualStyleBackColor = true
        '
        'gbTVScraperGlobalLocksShowOpts
        '
        Me.gbTVScraperGlobalLocksShowOpts.Controls.Add(Me.chkTVLockShowStatus)
        Me.gbTVScraperGlobalLocksShowOpts.Controls.Add(Me.chkTVLockShowPlot)
        Me.gbTVScraperGlobalLocksShowOpts.Controls.Add(Me.chkTVLockShowGenre)
        Me.gbTVScraperGlobalLocksShowOpts.Controls.Add(Me.chkTVLockShowStudio)
        Me.gbTVScraperGlobalLocksShowOpts.Controls.Add(Me.chkTVLockShowRating)
        Me.gbTVScraperGlobalLocksShowOpts.Controls.Add(Me.chkTVLockShowTitle)
        Me.gbTVScraperGlobalLocksShowOpts.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.gbTVScraperGlobalLocksShowOpts.Location = New System.Drawing.Point(5, 13)
        Me.gbTVScraperGlobalLocksShowOpts.Name = "gbTVScraperGlobalLocksShowOpts"
        Me.gbTVScraperGlobalLocksShowOpts.Size = New System.Drawing.Size(181, 111)
        Me.gbTVScraperGlobalLocksShowOpts.TabIndex = 0
        Me.gbTVScraperGlobalLocksShowOpts.TabStop = false
        Me.gbTVScraperGlobalLocksShowOpts.Text = "Show"
        '
        'chkTVLockShowStatus
        '
        Me.chkTVLockShowStatus.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkTVLockShowStatus.Location = New System.Drawing.Point(6, 77)
        Me.chkTVLockShowStatus.Name = "chkTVLockShowStatus"
        Me.chkTVLockShowStatus.Size = New System.Drawing.Size(168, 17)
        Me.chkTVLockShowStatus.TabIndex = 5
        Me.chkTVLockShowStatus.Text = "Lock Status"
        Me.chkTVLockShowStatus.UseVisualStyleBackColor = true
        '
        'chkTVLockShowPlot
        '
        Me.chkTVLockShowPlot.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkTVLockShowPlot.Location = New System.Drawing.Point(6, 29)
        Me.chkTVLockShowPlot.Name = "chkTVLockShowPlot"
        Me.chkTVLockShowPlot.Size = New System.Drawing.Size(168, 17)
        Me.chkTVLockShowPlot.TabIndex = 1
        Me.chkTVLockShowPlot.Text = "Lock Plot"
        Me.chkTVLockShowPlot.UseVisualStyleBackColor = true
        '
        'chkTVLockShowGenre
        '
        Me.chkTVLockShowGenre.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkTVLockShowGenre.Location = New System.Drawing.Point(6, 61)
        Me.chkTVLockShowGenre.Name = "chkTVLockShowGenre"
        Me.chkTVLockShowGenre.Size = New System.Drawing.Size(168, 17)
        Me.chkTVLockShowGenre.TabIndex = 3
        Me.chkTVLockShowGenre.Text = "Lock Genre"
        Me.chkTVLockShowGenre.UseVisualStyleBackColor = true
        '
        'chkTVLockShowStudio
        '
        Me.chkTVLockShowStudio.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkTVLockShowStudio.Location = New System.Drawing.Point(6, 93)
        Me.chkTVLockShowStudio.Name = "chkTVLockShowStudio"
        Me.chkTVLockShowStudio.Size = New System.Drawing.Size(168, 17)
        Me.chkTVLockShowStudio.TabIndex = 4
        Me.chkTVLockShowStudio.Text = "Lock Studio"
        Me.chkTVLockShowStudio.UseVisualStyleBackColor = true
        '
        'chkTVLockShowRating
        '
        Me.chkTVLockShowRating.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkTVLockShowRating.Location = New System.Drawing.Point(6, 45)
        Me.chkTVLockShowRating.Name = "chkTVLockShowRating"
        Me.chkTVLockShowRating.Size = New System.Drawing.Size(168, 17)
        Me.chkTVLockShowRating.TabIndex = 2
        Me.chkTVLockShowRating.Text = "Lock Rating"
        Me.chkTVLockShowRating.UseVisualStyleBackColor = true
        '
        'chkTVLockShowTitle
        '
        Me.chkTVLockShowTitle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkTVLockShowTitle.Location = New System.Drawing.Point(6, 13)
        Me.chkTVLockShowTitle.Name = "chkTVLockShowTitle"
        Me.chkTVLockShowTitle.Size = New System.Drawing.Size(168, 17)
        Me.chkTVLockShowTitle.TabIndex = 0
        Me.chkTVLockShowTitle.Text = "Lock Title"
        Me.chkTVLockShowTitle.UseVisualStyleBackColor = true
        '
        'gbTVScraperMetaDataOpts
        '
        Me.gbTVScraperMetaDataOpts.Controls.Add(Me.gbTVScraperDefFIExtOpts)
        Me.gbTVScraperMetaDataOpts.Controls.Add(Me.cbTVLanguageOverlay)
        Me.gbTVScraperMetaDataOpts.Controls.Add(Me.lblTVLanguageOverlay)
        Me.gbTVScraperMetaDataOpts.Controls.Add(Me.chkTVScraperMetaDataScan)
        Me.gbTVScraperMetaDataOpts.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.gbTVScraperMetaDataOpts.Location = New System.Drawing.Point(403, 6)
        Me.gbTVScraperMetaDataOpts.Name = "gbTVScraperMetaDataOpts"
        Me.gbTVScraperMetaDataOpts.Size = New System.Drawing.Size(208, 243)
        Me.gbTVScraperMetaDataOpts.TabIndex = 2
        Me.gbTVScraperMetaDataOpts.TabStop = false
        Me.gbTVScraperMetaDataOpts.Text = "Meta Data"
        '
        'gbTVScraperDefFIExtOpts
        '
        Me.gbTVScraperDefFIExtOpts.Controls.Add(Me.lstTVScraperDefFIExt)
        Me.gbTVScraperDefFIExtOpts.Controls.Add(Me.txtTVScraperDefFIExt)
        Me.gbTVScraperDefFIExtOpts.Controls.Add(Me.lblTVScraperDefFIExt)
        Me.gbTVScraperDefFIExtOpts.Controls.Add(Me.btnTVScraperDefFIExtRemove)
        Me.gbTVScraperDefFIExtOpts.Controls.Add(Me.btnTVScraperDefFIExtEdit)
        Me.gbTVScraperDefFIExtOpts.Controls.Add(Me.btnTVScraperDefFIExtAdd)
        Me.gbTVScraperDefFIExtOpts.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.gbTVScraperDefFIExtOpts.Location = New System.Drawing.Point(12, 93)
        Me.gbTVScraperDefFIExtOpts.Name = "gbTVScraperDefFIExtOpts"
        Me.gbTVScraperDefFIExtOpts.Size = New System.Drawing.Size(183, 144)
        Me.gbTVScraperDefFIExtOpts.TabIndex = 3
        Me.gbTVScraperDefFIExtOpts.TabStop = false
        Me.gbTVScraperDefFIExtOpts.Text = "Defaults by File Type"
        '
        'lstTVScraperDefFIExt
        '
        Me.lstTVScraperDefFIExt.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.lstTVScraperDefFIExt.FormattingEnabled = true
        Me.lstTVScraperDefFIExt.Location = New System.Drawing.Point(10, 16)
        Me.lstTVScraperDefFIExt.Name = "lstTVScraperDefFIExt"
        Me.lstTVScraperDefFIExt.Size = New System.Drawing.Size(165, 95)
        Me.lstTVScraperDefFIExt.TabIndex = 0
        '
        'txtTVScraperDefFIExt
        '
        Me.txtTVScraperDefFIExt.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtTVScraperDefFIExt.Location = New System.Drawing.Point(73, 116)
        Me.txtTVScraperDefFIExt.Name = "txtTVScraperDefFIExt"
        Me.txtTVScraperDefFIExt.Size = New System.Drawing.Size(35, 22)
        Me.txtTVScraperDefFIExt.TabIndex = 2
        '
        'lblTVScraperDefFIExt
        '
        Me.lblTVScraperDefFIExt.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblTVScraperDefFIExt.Location = New System.Drawing.Point(8, 116)
        Me.lblTVScraperDefFIExt.Name = "lblTVScraperDefFIExt"
        Me.lblTVScraperDefFIExt.Size = New System.Drawing.Size(66, 19)
        Me.lblTVScraperDefFIExt.TabIndex = 1
        Me.lblTVScraperDefFIExt.Text = "File Type"
        Me.lblTVScraperDefFIExt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnTVScraperDefFIExtRemove
        '
        Me.btnTVScraperDefFIExtRemove.Enabled = false
        Me.btnTVScraperDefFIExtRemove.Image = CType(resources.GetObject("btnTVScraperDefFIExtRemove.Image"),System.Drawing.Image)
        Me.btnTVScraperDefFIExtRemove.Location = New System.Drawing.Point(153, 115)
        Me.btnTVScraperDefFIExtRemove.Name = "btnTVScraperDefFIExtRemove"
        Me.btnTVScraperDefFIExtRemove.Size = New System.Drawing.Size(23, 23)
        Me.btnTVScraperDefFIExtRemove.TabIndex = 4
        Me.btnTVScraperDefFIExtRemove.UseVisualStyleBackColor = true
        '
        'btnTVScraperDefFIExtEdit
        '
        Me.btnTVScraperDefFIExtEdit.Enabled = false
        Me.btnTVScraperDefFIExtEdit.Image = CType(resources.GetObject("btnTVScraperDefFIExtEdit.Image"),System.Drawing.Image)
        Me.btnTVScraperDefFIExtEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTVScraperDefFIExtEdit.Location = New System.Drawing.Point(130, 115)
        Me.btnTVScraperDefFIExtEdit.Name = "btnTVScraperDefFIExtEdit"
        Me.btnTVScraperDefFIExtEdit.Size = New System.Drawing.Size(23, 23)
        Me.btnTVScraperDefFIExtEdit.TabIndex = 3
        Me.btnTVScraperDefFIExtEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnTVScraperDefFIExtEdit.UseVisualStyleBackColor = true
        '
        'btnTVScraperDefFIExtAdd
        '
        Me.btnTVScraperDefFIExtAdd.Enabled = false
        Me.btnTVScraperDefFIExtAdd.Image = CType(resources.GetObject("btnTVScraperDefFIExtAdd.Image"),System.Drawing.Image)
        Me.btnTVScraperDefFIExtAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTVScraperDefFIExtAdd.Location = New System.Drawing.Point(108, 115)
        Me.btnTVScraperDefFIExtAdd.Name = "btnTVScraperDefFIExtAdd"
        Me.btnTVScraperDefFIExtAdd.Size = New System.Drawing.Size(23, 23)
        Me.btnTVScraperDefFIExtAdd.TabIndex = 29
        Me.btnTVScraperDefFIExtAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnTVScraperDefFIExtAdd.UseVisualStyleBackColor = true
        '
        'cbTVLanguageOverlay
        '
        Me.cbTVLanguageOverlay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTVLanguageOverlay.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.cbTVLanguageOverlay.FormattingEnabled = true
        Me.cbTVLanguageOverlay.Location = New System.Drawing.Point(13, 62)
        Me.cbTVLanguageOverlay.Name = "cbTVLanguageOverlay"
        Me.cbTVLanguageOverlay.Size = New System.Drawing.Size(182, 21)
        Me.cbTVLanguageOverlay.Sorted = true
        Me.cbTVLanguageOverlay.TabIndex = 2
        '
        'lblTVLanguageOverlay
        '
        Me.lblTVLanguageOverlay.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblTVLanguageOverlay.Location = New System.Drawing.Point(4, 35)
        Me.lblTVLanguageOverlay.Name = "lblTVLanguageOverlay"
        Me.lblTVLanguageOverlay.Size = New System.Drawing.Size(202, 29)
        Me.lblTVLanguageOverlay.TabIndex = 1
        Me.lblTVLanguageOverlay.Text = "Display Overlay if Video Contains an Audio Stream With the Following Language:"
        Me.lblTVLanguageOverlay.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'chkTVScraperMetaDataScan
        '
        Me.chkTVScraperMetaDataScan.AutoSize = true
        Me.chkTVScraperMetaDataScan.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkTVScraperMetaDataScan.Location = New System.Drawing.Point(5, 16)
        Me.chkTVScraperMetaDataScan.Name = "chkTVScraperMetaDataScan"
        Me.chkTVScraperMetaDataScan.Size = New System.Drawing.Size(106, 17)
        Me.chkTVScraperMetaDataScan.TabIndex = 0
        Me.chkTVScraperMetaDataScan.Text = "Scan Meta Data"
        Me.chkTVScraperMetaDataScan.UseVisualStyleBackColor = true
        '
        'gbTVScraperOptionsOpts
        '
        Me.gbTVScraperOptionsOpts.Controls.Add(Me.lblTVScraperRatingRegion)
        Me.gbTVScraperOptionsOpts.Controls.Add(Me.cbTVScraperRatingRegion)
        Me.gbTVScraperOptionsOpts.Controls.Add(Me.lblTVScraperOptionsOrdering)
        Me.gbTVScraperOptionsOpts.Controls.Add(Me.cbTVScraperOptionsOrdering)
        Me.gbTVScraperOptionsOpts.Controls.Add(Me.lblTVScraperUpdateTime)
        Me.gbTVScraperOptionsOpts.Controls.Add(Me.cbTVScraperUpdateTime)
        Me.gbTVScraperOptionsOpts.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.gbTVScraperOptionsOpts.Location = New System.Drawing.Point(5, 6)
        Me.gbTVScraperOptionsOpts.Name = "gbTVScraperOptionsOpts"
        Me.gbTVScraperOptionsOpts.Size = New System.Drawing.Size(200, 243)
        Me.gbTVScraperOptionsOpts.TabIndex = 0
        Me.gbTVScraperOptionsOpts.TabStop = false
        Me.gbTVScraperOptionsOpts.Text = "Options"
        '
        'lblTVScraperRatingRegion
        '
        Me.lblTVScraperRatingRegion.AutoSize = true
        Me.lblTVScraperRatingRegion.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblTVScraperRatingRegion.Location = New System.Drawing.Point(12, 163)
        Me.lblTVScraperRatingRegion.Name = "lblTVScraperRatingRegion"
        Me.lblTVScraperRatingRegion.Size = New System.Drawing.Size(99, 13)
        Me.lblTVScraperRatingRegion.TabIndex = 5
        Me.lblTVScraperRatingRegion.Text = "TV Rating Region:"
        '
        'cbTVScraperRatingRegion
        '
        Me.cbTVScraperRatingRegion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTVScraperRatingRegion.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.cbTVScraperRatingRegion.FormattingEnabled = true
        Me.cbTVScraperRatingRegion.Location = New System.Drawing.Point(12, 178)
        Me.cbTVScraperRatingRegion.Name = "cbTVScraperRatingRegion"
        Me.cbTVScraperRatingRegion.Size = New System.Drawing.Size(163, 21)
        Me.cbTVScraperRatingRegion.TabIndex = 6
        '
        'lblTVScraperOptionsOrdering
        '
        Me.lblTVScraperOptionsOrdering.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.lblTVScraperOptionsOrdering.Location = New System.Drawing.Point(10, 73)
        Me.lblTVScraperOptionsOrdering.Name = "lblTVScraperOptionsOrdering"
        Me.lblTVScraperOptionsOrdering.Size = New System.Drawing.Size(177, 13)
        Me.lblTVScraperOptionsOrdering.TabIndex = 7
        Me.lblTVScraperOptionsOrdering.Text = "Default Episode Ordering:"
        Me.lblTVScraperOptionsOrdering.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'cbTVScraperOptionsOrdering
        '
        Me.cbTVScraperOptionsOrdering.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTVScraperOptionsOrdering.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.cbTVScraperOptionsOrdering.FormattingEnabled = true
        Me.cbTVScraperOptionsOrdering.Location = New System.Drawing.Point(15, 89)
        Me.cbTVScraperOptionsOrdering.Name = "cbTVScraperOptionsOrdering"
        Me.cbTVScraperOptionsOrdering.Size = New System.Drawing.Size(166, 21)
        Me.cbTVScraperOptionsOrdering.TabIndex = 8
        '
        'lblTVScraperUpdateTime
        '
        Me.lblTVScraperUpdateTime.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblTVScraperUpdateTime.Location = New System.Drawing.Point(3, 18)
        Me.lblTVScraperUpdateTime.Name = "lblTVScraperUpdateTime"
        Me.lblTVScraperUpdateTime.Size = New System.Drawing.Size(190, 31)
        Me.lblTVScraperUpdateTime.TabIndex = 5
        Me.lblTVScraperUpdateTime.Text = "Re-download Show Information Every:"
        Me.lblTVScraperUpdateTime.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'cbTVScraperUpdateTime
        '
        Me.cbTVScraperUpdateTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTVScraperUpdateTime.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.cbTVScraperUpdateTime.FormattingEnabled = true
        Me.cbTVScraperUpdateTime.Location = New System.Drawing.Point(15, 49)
        Me.cbTVScraperUpdateTime.Name = "cbTVScraperUpdateTime"
        Me.cbTVScraperUpdateTime.Size = New System.Drawing.Size(166, 21)
        Me.cbTVScraperUpdateTime.TabIndex = 6
        '
        'gbMovieScraperFieldsOpts
        '
        Me.gbMovieScraperFieldsOpts.Controls.Add(Me.chkMovieScraperCertification)
        Me.gbMovieScraperFieldsOpts.Controls.Add(Me.chkMovieScraperTop250)
        Me.gbMovieScraperFieldsOpts.Controls.Add(Me.chkMovieScraperCountry)
        Me.gbMovieScraperFieldsOpts.Controls.Add(Me.txtMovieScraperGenreLimit)
        Me.gbMovieScraperFieldsOpts.Controls.Add(Me.lblMovieScraperGenreLimit)
        Me.gbMovieScraperFieldsOpts.Controls.Add(Me.txtMovieScraperCastLimit)
        Me.gbMovieScraperFieldsOpts.Controls.Add(Me.lblMovieScraperCastLimit)
        Me.gbMovieScraperFieldsOpts.Controls.Add(Me.chkMovieScraperCrew)
        Me.gbMovieScraperFieldsOpts.Controls.Add(Me.chkMovieScraperMusicBy)
        Me.gbMovieScraperFieldsOpts.Controls.Add(Me.chkMovieScraperProducers)
        Me.gbMovieScraperFieldsOpts.Controls.Add(Me.chkMovieScraperWriters)
        Me.gbMovieScraperFieldsOpts.Controls.Add(Me.chkMovieScraperStudio)
        Me.gbMovieScraperFieldsOpts.Controls.Add(Me.chkMovieScraperRuntime)
        Me.gbMovieScraperFieldsOpts.Controls.Add(Me.chkMovieScraperPlot)
        Me.gbMovieScraperFieldsOpts.Controls.Add(Me.chkMovieScraperOutline)
        Me.gbMovieScraperFieldsOpts.Controls.Add(Me.chkMovieScraperGenre)
        Me.gbMovieScraperFieldsOpts.Controls.Add(Me.chkMovieScraperDirector)
        Me.gbMovieScraperFieldsOpts.Controls.Add(Me.chkMovieScraperTagline)
        Me.gbMovieScraperFieldsOpts.Controls.Add(Me.chkMovieScraperCast)
        Me.gbMovieScraperFieldsOpts.Controls.Add(Me.chkMovieScraperVotes)
        Me.gbMovieScraperFieldsOpts.Controls.Add(Me.chkMovieScraperTrailer)
        Me.gbMovieScraperFieldsOpts.Controls.Add(Me.chkMovieScraperRating)
        Me.gbMovieScraperFieldsOpts.Controls.Add(Me.chkMovieScraperRelease)
        Me.gbMovieScraperFieldsOpts.Controls.Add(Me.chkMovieScraperMPAA)
        Me.gbMovieScraperFieldsOpts.Controls.Add(Me.chkMovieScraperYear)
        Me.gbMovieScraperFieldsOpts.Controls.Add(Me.chkMovieScraperTitle)
        Me.gbMovieScraperFieldsOpts.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.gbMovieScraperFieldsOpts.Location = New System.Drawing.Point(3, 218)
        Me.gbMovieScraperFieldsOpts.Name = "gbMovieScraperFieldsOpts"
        Me.gbMovieScraperFieldsOpts.Size = New System.Drawing.Size(302, 179)
        Me.gbMovieScraperFieldsOpts.TabIndex = 67
        Me.gbMovieScraperFieldsOpts.TabStop = false
        Me.gbMovieScraperFieldsOpts.Text = "Scraper Fields - Global"
        '
        'chkMovieScraperCertification
        '
        Me.chkMovieScraperCertification.AutoSize = true
        Me.chkMovieScraperCertification.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkMovieScraperCertification.Location = New System.Drawing.Point(6, 76)
        Me.chkMovieScraperCertification.Name = "chkMovieScraperCertification"
        Me.chkMovieScraperCertification.Size = New System.Drawing.Size(89, 17)
        Me.chkMovieScraperCertification.TabIndex = 24
        Me.chkMovieScraperCertification.Text = "Certification"
        Me.chkMovieScraperCertification.UseVisualStyleBackColor = true
        '
        'chkMovieScraperTop250
        '
        Me.chkMovieScraperTop250.AutoSize = true
        Me.chkMovieScraperTop250.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkMovieScraperTop250.Location = New System.Drawing.Point(205, 133)
        Me.chkMovieScraperTop250.Name = "chkMovieScraperTop250"
        Me.chkMovieScraperTop250.Size = New System.Drawing.Size(66, 17)
        Me.chkMovieScraperTop250.TabIndex = 23
        Me.chkMovieScraperTop250.Text = "Top 250"
        Me.chkMovieScraperTop250.UseVisualStyleBackColor = true
        '
        'chkMovieScraperCountry
        '
        Me.chkMovieScraperCountry.AutoSize = true
        Me.chkMovieScraperCountry.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkMovieScraperCountry.Location = New System.Drawing.Point(205, 152)
        Me.chkMovieScraperCountry.Name = "chkMovieScraperCountry"
        Me.chkMovieScraperCountry.Size = New System.Drawing.Size(67, 17)
        Me.chkMovieScraperCountry.TabIndex = 25
        Me.chkMovieScraperCountry.Text = "Country"
        Me.chkMovieScraperCountry.UseVisualStyleBackColor = true
        '
        'txtMovieScraperGenreLimit
        '
        Me.txtMovieScraperGenreLimit.Enabled = false
        Me.txtMovieScraperGenreLimit.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtMovieScraperGenreLimit.Location = New System.Drawing.Point(255, 55)
        Me.txtMovieScraperGenreLimit.Name = "txtMovieScraperGenreLimit"
        Me.txtMovieScraperGenreLimit.Size = New System.Drawing.Size(39, 22)
        Me.txtMovieScraperGenreLimit.TabIndex = 21
        '
        'lblMovieScraperGenreLimit
        '
        Me.lblMovieScraperGenreLimit.AutoSize = true
        Me.lblMovieScraperGenreLimit.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblMovieScraperGenreLimit.Location = New System.Drawing.Point(223, 58)
        Me.lblMovieScraperGenreLimit.Name = "lblMovieScraperGenreLimit"
        Me.lblMovieScraperGenreLimit.Size = New System.Drawing.Size(34, 13)
        Me.lblMovieScraperGenreLimit.TabIndex = 22
        Me.lblMovieScraperGenreLimit.Text = "Limit:"
        Me.lblMovieScraperGenreLimit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMovieScraperCastLimit
        '
        Me.txtMovieScraperCastLimit.Enabled = false
        Me.txtMovieScraperCastLimit.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtMovieScraperCastLimit.Location = New System.Drawing.Point(151, 112)
        Me.txtMovieScraperCastLimit.Name = "txtMovieScraperCastLimit"
        Me.txtMovieScraperCastLimit.Size = New System.Drawing.Size(39, 22)
        Me.txtMovieScraperCastLimit.TabIndex = 19
        '
        'lblMovieScraperCastLimit
        '
        Me.lblMovieScraperCastLimit.AutoSize = true
        Me.lblMovieScraperCastLimit.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblMovieScraperCastLimit.Location = New System.Drawing.Point(118, 115)
        Me.lblMovieScraperCastLimit.Name = "lblMovieScraperCastLimit"
        Me.lblMovieScraperCastLimit.Size = New System.Drawing.Size(34, 13)
        Me.lblMovieScraperCastLimit.TabIndex = 20
        Me.lblMovieScraperCastLimit.Text = "Limit:"
        Me.lblMovieScraperCastLimit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkMovieScraperCrew
        '
        Me.chkMovieScraperCrew.AutoSize = true
        Me.chkMovieScraperCrew.Enabled = false
        Me.chkMovieScraperCrew.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkMovieScraperCrew.Location = New System.Drawing.Point(205, 114)
        Me.chkMovieScraperCrew.Name = "chkMovieScraperCrew"
        Me.chkMovieScraperCrew.Size = New System.Drawing.Size(85, 17)
        Me.chkMovieScraperCrew.TabIndex = 18
        Me.chkMovieScraperCrew.Text = "Other Crew"
        Me.chkMovieScraperCrew.UseVisualStyleBackColor = true
        '
        'chkMovieScraperMusicBy
        '
        Me.chkMovieScraperMusicBy.AutoSize = true
        Me.chkMovieScraperMusicBy.Enabled = false
        Me.chkMovieScraperMusicBy.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkMovieScraperMusicBy.Location = New System.Drawing.Point(205, 95)
        Me.chkMovieScraperMusicBy.Name = "chkMovieScraperMusicBy"
        Me.chkMovieScraperMusicBy.Size = New System.Drawing.Size(71, 17)
        Me.chkMovieScraperMusicBy.TabIndex = 17
        Me.chkMovieScraperMusicBy.Text = "Music By"
        Me.chkMovieScraperMusicBy.UseVisualStyleBackColor = true
        '
        'chkMovieScraperProducers
        '
        Me.chkMovieScraperProducers.AutoSize = true
        Me.chkMovieScraperProducers.Enabled = false
        Me.chkMovieScraperProducers.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkMovieScraperProducers.Location = New System.Drawing.Point(205, 19)
        Me.chkMovieScraperProducers.Name = "chkMovieScraperProducers"
        Me.chkMovieScraperProducers.Size = New System.Drawing.Size(77, 17)
        Me.chkMovieScraperProducers.TabIndex = 16
        Me.chkMovieScraperProducers.Text = "Producers"
        Me.chkMovieScraperProducers.UseVisualStyleBackColor = true
        '
        'chkMovieScraperWriters
        '
        Me.chkMovieScraperWriters.AutoSize = true
        Me.chkMovieScraperWriters.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkMovieScraperWriters.Location = New System.Drawing.Point(101, 152)
        Me.chkMovieScraperWriters.Name = "chkMovieScraperWriters"
        Me.chkMovieScraperWriters.Size = New System.Drawing.Size(63, 17)
        Me.chkMovieScraperWriters.TabIndex = 15
        Me.chkMovieScraperWriters.Text = "Writers"
        Me.chkMovieScraperWriters.UseVisualStyleBackColor = true
        '
        'chkMovieScraperStudio
        '
        Me.chkMovieScraperStudio.AutoSize = true
        Me.chkMovieScraperStudio.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkMovieScraperStudio.Location = New System.Drawing.Point(101, 19)
        Me.chkMovieScraperStudio.Name = "chkMovieScraperStudio"
        Me.chkMovieScraperStudio.Size = New System.Drawing.Size(60, 17)
        Me.chkMovieScraperStudio.TabIndex = 14
        Me.chkMovieScraperStudio.Text = "Studio"
        Me.chkMovieScraperStudio.UseVisualStyleBackColor = true
        '
        'chkMovieScraperRuntime
        '
        Me.chkMovieScraperRuntime.AutoSize = true
        Me.chkMovieScraperRuntime.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkMovieScraperRuntime.Location = New System.Drawing.Point(6, 114)
        Me.chkMovieScraperRuntime.Name = "chkMovieScraperRuntime"
        Me.chkMovieScraperRuntime.Size = New System.Drawing.Size(69, 17)
        Me.chkMovieScraperRuntime.TabIndex = 13
        Me.chkMovieScraperRuntime.Text = "Runtime"
        Me.chkMovieScraperRuntime.UseVisualStyleBackColor = true
        '
        'chkMovieScraperPlot
        '
        Me.chkMovieScraperPlot.AutoSize = true
        Me.chkMovieScraperPlot.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkMovieScraperPlot.Location = New System.Drawing.Point(101, 75)
        Me.chkMovieScraperPlot.Name = "chkMovieScraperPlot"
        Me.chkMovieScraperPlot.Size = New System.Drawing.Size(46, 17)
        Me.chkMovieScraperPlot.TabIndex = 12
        Me.chkMovieScraperPlot.Text = "Plot"
        Me.chkMovieScraperPlot.UseVisualStyleBackColor = true
        '
        'chkMovieScraperOutline
        '
        Me.chkMovieScraperOutline.AutoSize = true
        Me.chkMovieScraperOutline.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkMovieScraperOutline.Location = New System.Drawing.Point(101, 57)
        Me.chkMovieScraperOutline.Name = "chkMovieScraperOutline"
        Me.chkMovieScraperOutline.Size = New System.Drawing.Size(65, 17)
        Me.chkMovieScraperOutline.TabIndex = 11
        Me.chkMovieScraperOutline.Text = "Outline"
        Me.chkMovieScraperOutline.UseVisualStyleBackColor = true
        '
        'chkMovieScraperGenre
        '
        Me.chkMovieScraperGenre.AutoSize = true
        Me.chkMovieScraperGenre.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkMovieScraperGenre.Location = New System.Drawing.Point(205, 38)
        Me.chkMovieScraperGenre.Name = "chkMovieScraperGenre"
        Me.chkMovieScraperGenre.Size = New System.Drawing.Size(57, 17)
        Me.chkMovieScraperGenre.TabIndex = 10
        Me.chkMovieScraperGenre.Text = "Genre"
        Me.chkMovieScraperGenre.UseVisualStyleBackColor = true
        '
        'chkMovieScraperDirector
        '
        Me.chkMovieScraperDirector.AutoSize = true
        Me.chkMovieScraperDirector.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkMovieScraperDirector.Location = New System.Drawing.Point(101, 133)
        Me.chkMovieScraperDirector.Name = "chkMovieScraperDirector"
        Me.chkMovieScraperDirector.Size = New System.Drawing.Size(67, 17)
        Me.chkMovieScraperDirector.TabIndex = 9
        Me.chkMovieScraperDirector.Text = "Director"
        Me.chkMovieScraperDirector.UseVisualStyleBackColor = true
        '
        'chkMovieScraperTagline
        '
        Me.chkMovieScraperTagline.AutoSize = true
        Me.chkMovieScraperTagline.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkMovieScraperTagline.Location = New System.Drawing.Point(101, 38)
        Me.chkMovieScraperTagline.Name = "chkMovieScraperTagline"
        Me.chkMovieScraperTagline.Size = New System.Drawing.Size(63, 17)
        Me.chkMovieScraperTagline.TabIndex = 8
        Me.chkMovieScraperTagline.Text = "Tagline"
        Me.chkMovieScraperTagline.UseVisualStyleBackColor = true
        '
        'chkMovieScraperCast
        '
        Me.chkMovieScraperCast.AutoSize = true
        Me.chkMovieScraperCast.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkMovieScraperCast.Location = New System.Drawing.Point(101, 95)
        Me.chkMovieScraperCast.Name = "chkMovieScraperCast"
        Me.chkMovieScraperCast.Size = New System.Drawing.Size(48, 17)
        Me.chkMovieScraperCast.TabIndex = 7
        Me.chkMovieScraperCast.Text = "Cast"
        Me.chkMovieScraperCast.UseVisualStyleBackColor = true
        '
        'chkMovieScraperVotes
        '
        Me.chkMovieScraperVotes.AutoSize = true
        Me.chkMovieScraperVotes.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkMovieScraperVotes.Location = New System.Drawing.Point(6, 152)
        Me.chkMovieScraperVotes.Name = "chkMovieScraperVotes"
        Me.chkMovieScraperVotes.Size = New System.Drawing.Size(55, 17)
        Me.chkMovieScraperVotes.TabIndex = 6
        Me.chkMovieScraperVotes.Text = "Votes"
        Me.chkMovieScraperVotes.UseVisualStyleBackColor = true
        '
        'chkMovieScraperTrailer
        '
        Me.chkMovieScraperTrailer.AutoSize = true
        Me.chkMovieScraperTrailer.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkMovieScraperTrailer.Location = New System.Drawing.Point(205, 76)
        Me.chkMovieScraperTrailer.Name = "chkMovieScraperTrailer"
        Me.chkMovieScraperTrailer.Size = New System.Drawing.Size(57, 17)
        Me.chkMovieScraperTrailer.TabIndex = 5
        Me.chkMovieScraperTrailer.Text = "Trailer"
        Me.chkMovieScraperTrailer.UseVisualStyleBackColor = true
        '
        'chkMovieScraperRating
        '
        Me.chkMovieScraperRating.AutoSize = true
        Me.chkMovieScraperRating.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkMovieScraperRating.Location = New System.Drawing.Point(6, 133)
        Me.chkMovieScraperRating.Name = "chkMovieScraperRating"
        Me.chkMovieScraperRating.Size = New System.Drawing.Size(60, 17)
        Me.chkMovieScraperRating.TabIndex = 4
        Me.chkMovieScraperRating.Text = "Rating"
        Me.chkMovieScraperRating.UseVisualStyleBackColor = true
        '
        'chkMovieScraperRelease
        '
        Me.chkMovieScraperRelease.AutoSize = true
        Me.chkMovieScraperRelease.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkMovieScraperRelease.Location = New System.Drawing.Point(6, 95)
        Me.chkMovieScraperRelease.Name = "chkMovieScraperRelease"
        Me.chkMovieScraperRelease.Size = New System.Drawing.Size(92, 17)
        Me.chkMovieScraperRelease.TabIndex = 3
        Me.chkMovieScraperRelease.Text = "Release Date"
        Me.chkMovieScraperRelease.UseVisualStyleBackColor = true
        '
        'chkMovieScraperMPAA
        '
        Me.chkMovieScraperMPAA.AutoSize = true
        Me.chkMovieScraperMPAA.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkMovieScraperMPAA.Location = New System.Drawing.Point(6, 57)
        Me.chkMovieScraperMPAA.Name = "chkMovieScraperMPAA"
        Me.chkMovieScraperMPAA.Size = New System.Drawing.Size(56, 17)
        Me.chkMovieScraperMPAA.TabIndex = 2
        Me.chkMovieScraperMPAA.Text = "MPAA"
        Me.chkMovieScraperMPAA.UseVisualStyleBackColor = true
        '
        'chkMovieScraperYear
        '
        Me.chkMovieScraperYear.AutoSize = true
        Me.chkMovieScraperYear.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkMovieScraperYear.Location = New System.Drawing.Point(6, 38)
        Me.chkMovieScraperYear.Name = "chkMovieScraperYear"
        Me.chkMovieScraperYear.Size = New System.Drawing.Size(47, 17)
        Me.chkMovieScraperYear.TabIndex = 1
        Me.chkMovieScraperYear.Text = "Year"
        Me.chkMovieScraperYear.UseVisualStyleBackColor = true
        '
        'chkMovieScraperTitle
        '
        Me.chkMovieScraperTitle.AutoSize = true
        Me.chkMovieScraperTitle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkMovieScraperTitle.Location = New System.Drawing.Point(6, 19)
        Me.chkMovieScraperTitle.Name = "chkMovieScraperTitle"
        Me.chkMovieScraperTitle.Size = New System.Drawing.Size(47, 17)
        Me.chkMovieScraperTitle.TabIndex = 0
        Me.chkMovieScraperTitle.Text = "Title"
        Me.chkMovieScraperTitle.UseVisualStyleBackColor = true
        '
        'lblMovieScraperOutlineLimit
        '
        Me.lblMovieScraperOutlineLimit.AutoSize = true
        Me.lblMovieScraperOutlineLimit.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblMovieScraperOutlineLimit.Location = New System.Drawing.Point(201, 133)
        Me.lblMovieScraperOutlineLimit.Name = "lblMovieScraperOutlineLimit"
        Me.lblMovieScraperOutlineLimit.Size = New System.Drawing.Size(34, 13)
        Me.lblMovieScraperOutlineLimit.TabIndex = 70
        Me.lblMovieScraperOutlineLimit.Text = "Limit:"
        Me.lblMovieScraperOutlineLimit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMovieScraperOutlineLimit
        '
        Me.txtMovieScraperOutlineLimit.Enabled = false
        Me.txtMovieScraperOutlineLimit.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtMovieScraperOutlineLimit.Location = New System.Drawing.Point(244, 128)
        Me.txtMovieScraperOutlineLimit.Name = "txtMovieScraperOutlineLimit"
        Me.txtMovieScraperOutlineLimit.Size = New System.Drawing.Size(39, 22)
        Me.txtMovieScraperOutlineLimit.TabIndex = 69
        '
        'gbMovieScraperMetaDataOpts
        '
        Me.gbMovieScraperMetaDataOpts.Controls.Add(Me.gbMovieScraperDefFIExtOpts)
        Me.gbMovieScraperMetaDataOpts.Controls.Add(Me.chkMovieScraperMetaDataIFOScan)
        Me.gbMovieScraperMetaDataOpts.Controls.Add(Me.cbMovieLanguageOverlay)
        Me.gbMovieScraperMetaDataOpts.Controls.Add(Me.lblMovieLanguageOverlay)
        Me.gbMovieScraperMetaDataOpts.Controls.Add(Me.gbMovieScraperDurationFormatOpts)
        Me.gbMovieScraperMetaDataOpts.Controls.Add(Me.chkMovieScraperMetaDataScan)
        Me.gbMovieScraperMetaDataOpts.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.gbMovieScraperMetaDataOpts.Location = New System.Drawing.Point(168, 6)
        Me.gbMovieScraperMetaDataOpts.Name = "gbMovieScraperMetaDataOpts"
        Me.gbMovieScraperMetaDataOpts.Size = New System.Drawing.Size(572, 206)
        Me.gbMovieScraperMetaDataOpts.TabIndex = 63
        Me.gbMovieScraperMetaDataOpts.TabStop = false
        Me.gbMovieScraperMetaDataOpts.Text = "Meta Data"
        '
        'gbMovieScraperDefFIExtOpts
        '
        Me.gbMovieScraperDefFIExtOpts.Controls.Add(Me.lstMovieScraperDefFIExt)
        Me.gbMovieScraperDefFIExtOpts.Controls.Add(Me.txtMovieScraperDefFIExt)
        Me.gbMovieScraperDefFIExtOpts.Controls.Add(Me.lblMovieScraperDefFIExt)
        Me.gbMovieScraperDefFIExtOpts.Controls.Add(Me.btnMovieScraperDefFIExtRemove)
        Me.gbMovieScraperDefFIExtOpts.Controls.Add(Me.btnMovieScraperDefFIExtEdit)
        Me.gbMovieScraperDefFIExtOpts.Controls.Add(Me.btnMovieScraperDefFIExtAdd)
        Me.gbMovieScraperDefFIExtOpts.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.gbMovieScraperDefFIExtOpts.Location = New System.Drawing.Point(278, 21)
        Me.gbMovieScraperDefFIExtOpts.Name = "gbMovieScraperDefFIExtOpts"
        Me.gbMovieScraperDefFIExtOpts.Size = New System.Drawing.Size(288, 179)
        Me.gbMovieScraperDefFIExtOpts.TabIndex = 8
        Me.gbMovieScraperDefFIExtOpts.TabStop = false
        Me.gbMovieScraperDefFIExtOpts.Text = "Defaults by File Type"
        '
        'lstMovieScraperDefFIExt
        '
        Me.lstMovieScraperDefFIExt.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.lstMovieScraperDefFIExt.FormattingEnabled = true
        Me.lstMovieScraperDefFIExt.Location = New System.Drawing.Point(9, 15)
        Me.lstMovieScraperDefFIExt.Name = "lstMovieScraperDefFIExt"
        Me.lstMovieScraperDefFIExt.Size = New System.Drawing.Size(273, 95)
        Me.lstMovieScraperDefFIExt.TabIndex = 34
        '
        'txtMovieScraperDefFIExt
        '
        Me.txtMovieScraperDefFIExt.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtMovieScraperDefFIExt.Location = New System.Drawing.Point(127, 116)
        Me.txtMovieScraperDefFIExt.Name = "txtMovieScraperDefFIExt"
        Me.txtMovieScraperDefFIExt.Size = New System.Drawing.Size(81, 22)
        Me.txtMovieScraperDefFIExt.TabIndex = 33
        '
        'lblMovieScraperDefFIExt
        '
        Me.lblMovieScraperDefFIExt.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblMovieScraperDefFIExt.Location = New System.Drawing.Point(58, 118)
        Me.lblMovieScraperDefFIExt.Name = "lblMovieScraperDefFIExt"
        Me.lblMovieScraperDefFIExt.Size = New System.Drawing.Size(63, 19)
        Me.lblMovieScraperDefFIExt.TabIndex = 32
        Me.lblMovieScraperDefFIExt.Text = "File Type:"
        Me.lblMovieScraperDefFIExt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnMovieScraperDefFIExtRemove
        '
        Me.btnMovieScraperDefFIExtRemove.Enabled = false
        Me.btnMovieScraperDefFIExtRemove.Image = CType(resources.GetObject("btnMovieScraperDefFIExtRemove.Image"),System.Drawing.Image)
        Me.btnMovieScraperDefFIExtRemove.Location = New System.Drawing.Point(259, 116)
        Me.btnMovieScraperDefFIExtRemove.Name = "btnMovieScraperDefFIExtRemove"
        Me.btnMovieScraperDefFIExtRemove.Size = New System.Drawing.Size(23, 23)
        Me.btnMovieScraperDefFIExtRemove.TabIndex = 31
        Me.btnMovieScraperDefFIExtRemove.UseVisualStyleBackColor = true
        '
        'btnMovieScraperDefFIExtEdit
        '
        Me.btnMovieScraperDefFIExtEdit.Enabled = false
        Me.btnMovieScraperDefFIExtEdit.Image = CType(resources.GetObject("btnMovieScraperDefFIExtEdit.Image"),System.Drawing.Image)
        Me.btnMovieScraperDefFIExtEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMovieScraperDefFIExtEdit.Location = New System.Drawing.Point(236, 116)
        Me.btnMovieScraperDefFIExtEdit.Name = "btnMovieScraperDefFIExtEdit"
        Me.btnMovieScraperDefFIExtEdit.Size = New System.Drawing.Size(23, 23)
        Me.btnMovieScraperDefFIExtEdit.TabIndex = 30
        Me.btnMovieScraperDefFIExtEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnMovieScraperDefFIExtEdit.UseVisualStyleBackColor = true
        '
        'btnMovieScraperDefFIExtAdd
        '
        Me.btnMovieScraperDefFIExtAdd.Enabled = false
        Me.btnMovieScraperDefFIExtAdd.Image = CType(resources.GetObject("btnMovieScraperDefFIExtAdd.Image"),System.Drawing.Image)
        Me.btnMovieScraperDefFIExtAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMovieScraperDefFIExtAdd.Location = New System.Drawing.Point(214, 116)
        Me.btnMovieScraperDefFIExtAdd.Name = "btnMovieScraperDefFIExtAdd"
        Me.btnMovieScraperDefFIExtAdd.Size = New System.Drawing.Size(23, 23)
        Me.btnMovieScraperDefFIExtAdd.TabIndex = 29
        Me.btnMovieScraperDefFIExtAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnMovieScraperDefFIExtAdd.UseVisualStyleBackColor = true
        '
        'chkMovieScraperMetaDataIFOScan
        '
        Me.chkMovieScraperMetaDataIFOScan.AutoSize = true
        Me.chkMovieScraperMetaDataIFOScan.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkMovieScraperMetaDataIFOScan.Location = New System.Drawing.Point(6, 33)
        Me.chkMovieScraperMetaDataIFOScan.Name = "chkMovieScraperMetaDataIFOScan"
        Me.chkMovieScraperMetaDataIFOScan.Size = New System.Drawing.Size(123, 17)
        Me.chkMovieScraperMetaDataIFOScan.TabIndex = 18
        Me.chkMovieScraperMetaDataIFOScan.Text = "Enable IFO Parsing"
        Me.chkMovieScraperMetaDataIFOScan.UseVisualStyleBackColor = true
        '
        'cbMovieLanguageOverlay
        '
        Me.cbMovieLanguageOverlay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMovieLanguageOverlay.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.cbMovieLanguageOverlay.FormattingEnabled = true
        Me.cbMovieLanguageOverlay.Location = New System.Drawing.Point(38, 155)
        Me.cbMovieLanguageOverlay.Name = "cbMovieLanguageOverlay"
        Me.cbMovieLanguageOverlay.Size = New System.Drawing.Size(174, 21)
        Me.cbMovieLanguageOverlay.Sorted = true
        Me.cbMovieLanguageOverlay.TabIndex = 17
        '
        'lblMovieLanguageOverlay
        '
        Me.lblMovieLanguageOverlay.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblMovieLanguageOverlay.Location = New System.Drawing.Point(6, 123)
        Me.lblMovieLanguageOverlay.Name = "lblMovieLanguageOverlay"
        Me.lblMovieLanguageOverlay.Size = New System.Drawing.Size(245, 29)
        Me.lblMovieLanguageOverlay.TabIndex = 16
        Me.lblMovieLanguageOverlay.Text = "Display Overlay if Video Contains an Audio Stream With the Following Language:"
        Me.lblMovieLanguageOverlay.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'gbMovieScraperDurationFormatOpts
        '
        Me.gbMovieScraperDurationFormatOpts.Controls.Add(Me.lblMovieScraperDurationRuntimeFormat)
        Me.gbMovieScraperDurationFormatOpts.Controls.Add(Me.txtMovieScraperDurationRuntimeFormat)
        Me.gbMovieScraperDurationFormatOpts.Controls.Add(Me.chkMovieScraperUseMDDuration)
        Me.gbMovieScraperDurationFormatOpts.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.gbMovieScraperDurationFormatOpts.Location = New System.Drawing.Point(6, 50)
        Me.gbMovieScraperDurationFormatOpts.Name = "gbMovieScraperDurationFormatOpts"
        Me.gbMovieScraperDurationFormatOpts.Size = New System.Drawing.Size(234, 64)
        Me.gbMovieScraperDurationFormatOpts.TabIndex = 9
        Me.gbMovieScraperDurationFormatOpts.TabStop = false
        Me.gbMovieScraperDurationFormatOpts.Text = "Duration Format"
        '
        'lblMovieScraperDurationRuntimeFormat
        '
        Me.lblMovieScraperDurationRuntimeFormat.Font = New System.Drawing.Font("Segoe UI", 7!)
        Me.lblMovieScraperDurationRuntimeFormat.Location = New System.Drawing.Point(160, 10)
        Me.lblMovieScraperDurationRuntimeFormat.Name = "lblMovieScraperDurationRuntimeFormat"
        Me.lblMovieScraperDurationRuntimeFormat.Size = New System.Drawing.Size(72, 50)
        Me.lblMovieScraperDurationRuntimeFormat.TabIndex = 23
        Me.lblMovieScraperDurationRuntimeFormat.Text = "<h>=Hours"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"<m>=Minutes"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"<s>=Seconds"
        Me.lblMovieScraperDurationRuntimeFormat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtMovieScraperDurationRuntimeFormat
        '
        Me.txtMovieScraperDurationRuntimeFormat.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtMovieScraperDurationRuntimeFormat.Location = New System.Drawing.Point(5, 34)
        Me.txtMovieScraperDurationRuntimeFormat.Name = "txtMovieScraperDurationRuntimeFormat"
        Me.txtMovieScraperDurationRuntimeFormat.Size = New System.Drawing.Size(145, 22)
        Me.txtMovieScraperDurationRuntimeFormat.TabIndex = 22
        '
        'chkMovieScraperUseMDDuration
        '
        Me.chkMovieScraperUseMDDuration.AutoSize = true
        Me.chkMovieScraperUseMDDuration.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkMovieScraperUseMDDuration.Location = New System.Drawing.Point(5, 15)
        Me.chkMovieScraperUseMDDuration.Name = "chkMovieScraperUseMDDuration"
        Me.chkMovieScraperUseMDDuration.Size = New System.Drawing.Size(158, 17)
        Me.chkMovieScraperUseMDDuration.TabIndex = 8
        Me.chkMovieScraperUseMDDuration.Text = "Use Duration for Runtime"
        Me.chkMovieScraperUseMDDuration.UseVisualStyleBackColor = true
        '
        'chkMovieScraperMetaDataScan
        '
        Me.chkMovieScraperMetaDataScan.AutoSize = true
        Me.chkMovieScraperMetaDataScan.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkMovieScraperMetaDataScan.Location = New System.Drawing.Point(6, 16)
        Me.chkMovieScraperMetaDataScan.Name = "chkMovieScraperMetaDataScan"
        Me.chkMovieScraperMetaDataScan.Size = New System.Drawing.Size(106, 17)
        Me.chkMovieScraperMetaDataScan.TabIndex = 7
        Me.chkMovieScraperMetaDataScan.Text = "Scan Meta Data"
        Me.chkMovieScraperMetaDataScan.UseVisualStyleBackColor = true
        '
        'gbMovieScraperGlobalLocksOpts
        '
        Me.gbMovieScraperGlobalLocksOpts.Controls.Add(Me.chkMovieLockMPAA)
        Me.gbMovieScraperGlobalLocksOpts.Controls.Add(Me.chkMovieLockLanguageA)
        Me.gbMovieScraperGlobalLocksOpts.Controls.Add(Me.chkMovieLockLanguageV)
        Me.gbMovieScraperGlobalLocksOpts.Controls.Add(Me.chkMovieLockOutline)
        Me.gbMovieScraperGlobalLocksOpts.Controls.Add(Me.chkMovieLockPlot)
        Me.gbMovieScraperGlobalLocksOpts.Controls.Add(Me.chkMovieLockTrailer)
        Me.gbMovieScraperGlobalLocksOpts.Controls.Add(Me.chkMovieLockGenre)
        Me.gbMovieScraperGlobalLocksOpts.Controls.Add(Me.chkMovieLockStudio)
        Me.gbMovieScraperGlobalLocksOpts.Controls.Add(Me.chkMovieLockRating)
        Me.gbMovieScraperGlobalLocksOpts.Controls.Add(Me.chkMovieLockTagline)
        Me.gbMovieScraperGlobalLocksOpts.Controls.Add(Me.chkMovieLockTitle)
        Me.gbMovieScraperGlobalLocksOpts.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.gbMovieScraperGlobalLocksOpts.Location = New System.Drawing.Point(6, 6)
        Me.gbMovieScraperGlobalLocksOpts.Name = "gbMovieScraperGlobalLocksOpts"
        Me.gbMovieScraperGlobalLocksOpts.Size = New System.Drawing.Size(156, 206)
        Me.gbMovieScraperGlobalLocksOpts.TabIndex = 1
        Me.gbMovieScraperGlobalLocksOpts.TabStop = false
        Me.gbMovieScraperGlobalLocksOpts.Text = "Global Locks"
        '
        'chkMovieLockMPAA
        '
        Me.chkMovieLockMPAA.AutoSize = true
        Me.chkMovieLockMPAA.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkMovieLockMPAA.Location = New System.Drawing.Point(6, 186)
        Me.chkMovieLockMPAA.Name = "chkMovieLockMPAA"
        Me.chkMovieLockMPAA.Size = New System.Drawing.Size(149, 17)
        Me.chkMovieLockMPAA.TabIndex = 49
        Me.chkMovieLockMPAA.Text = "Lock MPAA/Certification"
        Me.chkMovieLockMPAA.UseVisualStyleBackColor = true
        '
        'chkMovieLockLanguageA
        '
        Me.chkMovieLockLanguageA.AutoSize = true
        Me.chkMovieLockLanguageA.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkMovieLockLanguageA.Location = New System.Drawing.Point(6, 169)
        Me.chkMovieLockLanguageA.Name = "chkMovieLockLanguageA"
        Me.chkMovieLockLanguageA.Size = New System.Drawing.Size(142, 17)
        Me.chkMovieLockLanguageA.TabIndex = 48
        Me.chkMovieLockLanguageA.Text = "Lock Language (audio)"
        Me.chkMovieLockLanguageA.UseVisualStyleBackColor = true
        '
        'chkMovieLockLanguageV
        '
        Me.chkMovieLockLanguageV.AutoSize = true
        Me.chkMovieLockLanguageV.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkMovieLockLanguageV.Location = New System.Drawing.Point(6, 152)
        Me.chkMovieLockLanguageV.Name = "chkMovieLockLanguageV"
        Me.chkMovieLockLanguageV.Size = New System.Drawing.Size(140, 17)
        Me.chkMovieLockLanguageV.TabIndex = 47
        Me.chkMovieLockLanguageV.Text = "Lock Language (video)"
        Me.chkMovieLockLanguageV.UseVisualStyleBackColor = true
        '
        'chkMovieLockOutline
        '
        Me.chkMovieLockOutline.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkMovieLockOutline.Location = New System.Drawing.Point(6, 50)
        Me.chkMovieLockOutline.Name = "chkMovieLockOutline"
        Me.chkMovieLockOutline.Size = New System.Drawing.Size(129, 17)
        Me.chkMovieLockOutline.TabIndex = 1
        Me.chkMovieLockOutline.Text = "Lock Outline"
        Me.chkMovieLockOutline.UseVisualStyleBackColor = true
        '
        'chkMovieLockPlot
        '
        Me.chkMovieLockPlot.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkMovieLockPlot.Location = New System.Drawing.Point(6, 33)
        Me.chkMovieLockPlot.Name = "chkMovieLockPlot"
        Me.chkMovieLockPlot.Size = New System.Drawing.Size(129, 17)
        Me.chkMovieLockPlot.TabIndex = 0
        Me.chkMovieLockPlot.Text = "Lock Plot"
        Me.chkMovieLockPlot.UseVisualStyleBackColor = true
        '
        'chkMovieLockTrailer
        '
        Me.chkMovieLockTrailer.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkMovieLockTrailer.Location = New System.Drawing.Point(6, 135)
        Me.chkMovieLockTrailer.Name = "chkMovieLockTrailer"
        Me.chkMovieLockTrailer.Size = New System.Drawing.Size(129, 17)
        Me.chkMovieLockTrailer.TabIndex = 46
        Me.chkMovieLockTrailer.Text = "Lock Trailer"
        Me.chkMovieLockTrailer.UseVisualStyleBackColor = true
        '
        'chkMovieLockGenre
        '
        Me.chkMovieLockGenre.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkMovieLockGenre.Location = New System.Drawing.Point(6, 118)
        Me.chkMovieLockGenre.Name = "chkMovieLockGenre"
        Me.chkMovieLockGenre.Size = New System.Drawing.Size(129, 17)
        Me.chkMovieLockGenre.TabIndex = 7
        Me.chkMovieLockGenre.Text = "Lock Genre"
        Me.chkMovieLockGenre.UseVisualStyleBackColor = true
        '
        'chkMovieLockStudio
        '
        Me.chkMovieLockStudio.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkMovieLockStudio.Location = New System.Drawing.Point(6, 101)
        Me.chkMovieLockStudio.Name = "chkMovieLockStudio"
        Me.chkMovieLockStudio.Size = New System.Drawing.Size(129, 17)
        Me.chkMovieLockStudio.TabIndex = 5
        Me.chkMovieLockStudio.Text = "Lock Studio"
        Me.chkMovieLockStudio.UseVisualStyleBackColor = true
        '
        'chkMovieLockRating
        '
        Me.chkMovieLockRating.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkMovieLockRating.Location = New System.Drawing.Point(6, 84)
        Me.chkMovieLockRating.Name = "chkMovieLockRating"
        Me.chkMovieLockRating.Size = New System.Drawing.Size(129, 17)
        Me.chkMovieLockRating.TabIndex = 4
        Me.chkMovieLockRating.Text = "Lock Rating"
        Me.chkMovieLockRating.UseVisualStyleBackColor = true
        '
        'chkMovieLockTagline
        '
        Me.chkMovieLockTagline.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkMovieLockTagline.Location = New System.Drawing.Point(6, 67)
        Me.chkMovieLockTagline.Name = "chkMovieLockTagline"
        Me.chkMovieLockTagline.Size = New System.Drawing.Size(129, 17)
        Me.chkMovieLockTagline.TabIndex = 3
        Me.chkMovieLockTagline.Text = "Lock Tagline"
        Me.chkMovieLockTagline.UseVisualStyleBackColor = true
        '
        'chkMovieLockTitle
        '
        Me.chkMovieLockTitle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkMovieLockTitle.Location = New System.Drawing.Point(6, 16)
        Me.chkMovieLockTitle.Name = "chkMovieLockTitle"
        Me.chkMovieLockTitle.Size = New System.Drawing.Size(129, 17)
        Me.chkMovieLockTitle.TabIndex = 2
        Me.chkMovieLockTitle.Text = "Lock Title"
        Me.chkMovieLockTitle.UseVisualStyleBackColor = true
        '
        'gbMovieScraperMiscOpts
        '
        Me.gbMovieScraperMiscOpts.Controls.Add(Me.chkMovieScraperOutlinePlotEnglishOverwrite)
        Me.gbMovieScraperMiscOpts.Controls.Add(Me.chkMovieScraperTitleFallback)
        Me.gbMovieScraperMiscOpts.Controls.Add(Me.lblMovieScraperOutlineLimit)
        Me.gbMovieScraperMiscOpts.Controls.Add(Me.chkMovieScraperPlotForOutline)
        Me.gbMovieScraperMiscOpts.Controls.Add(Me.txtMovieScraperOutlineLimit)
        Me.gbMovieScraperMiscOpts.Controls.Add(Me.chkMovieScraperUseMPAAFSK)
        Me.gbMovieScraperMiscOpts.Controls.Add(Me.chkMovieScraperFullCast)
        Me.gbMovieScraperMiscOpts.Controls.Add(Me.chkMovieScraperForceTitle)
        Me.gbMovieScraperMiscOpts.Controls.Add(Me.cbMovieScraperForceTitle)
        Me.gbMovieScraperMiscOpts.Controls.Add(Me.chkMovieScraperOnlyValueForMPAA)
        Me.gbMovieScraperMiscOpts.Controls.Add(Me.chkMovieScraperOutlineForPlot)
        Me.gbMovieScraperMiscOpts.Controls.Add(Me.chkMovieScraperCastWithImg)
        Me.gbMovieScraperMiscOpts.Controls.Add(Me.chkMovieScraperCertForMPAA)
        Me.gbMovieScraperMiscOpts.Controls.Add(Me.chkMovieScraperFullCrew)
        Me.gbMovieScraperMiscOpts.Controls.Add(Me.cbMovieScraperCertLang)
        Me.gbMovieScraperMiscOpts.Controls.Add(Me.chkMovieScraperCertLang)
        Me.gbMovieScraperMiscOpts.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.gbMovieScraperMiscOpts.Location = New System.Drawing.Point(311, 218)
        Me.gbMovieScraperMiscOpts.Name = "gbMovieScraperMiscOpts"
        Me.gbMovieScraperMiscOpts.Size = New System.Drawing.Size(289, 279)
        Me.gbMovieScraperMiscOpts.TabIndex = 0
        Me.gbMovieScraperMiscOpts.TabStop = false
        Me.gbMovieScraperMiscOpts.Text = "Miscellaneous"
        '
        'chkMovieScraperOutlinePlotEnglishOverwrite
        '
        Me.chkMovieScraperOutlinePlotEnglishOverwrite.AutoSize = true
        Me.chkMovieScraperOutlinePlotEnglishOverwrite.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkMovieScraperOutlinePlotEnglishOverwrite.Location = New System.Drawing.Point(6, 172)
        Me.chkMovieScraperOutlinePlotEnglishOverwrite.Name = "chkMovieScraperOutlinePlotEnglishOverwrite"
        Me.chkMovieScraperOutlinePlotEnglishOverwrite.Size = New System.Drawing.Size(207, 17)
        Me.chkMovieScraperOutlinePlotEnglishOverwrite.TabIndex = 72
        Me.chkMovieScraperOutlinePlotEnglishOverwrite.Text = "Only overwrite english plot/outline"
        Me.chkMovieScraperOutlinePlotEnglishOverwrite.UseVisualStyleBackColor = true
        '
        'chkMovieScraperTitleFallback
        '
        Me.chkMovieScraperTitleFallback.AutoSize = true
        Me.chkMovieScraperTitleFallback.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkMovieScraperTitleFallback.Location = New System.Drawing.Point(6, 44)
        Me.chkMovieScraperTitleFallback.Name = "chkMovieScraperTitleFallback"
        Me.chkMovieScraperTitleFallback.Size = New System.Drawing.Size(153, 17)
        Me.chkMovieScraperTitleFallback.TabIndex = 71
        Me.chkMovieScraperTitleFallback.Text = "Worldwide-Title Fallback"
        Me.chkMovieScraperTitleFallback.UseVisualStyleBackColor = true
        '
        'chkMovieScraperPlotForOutline
        '
        Me.chkMovieScraperPlotForOutline.AutoSize = true
        Me.chkMovieScraperPlotForOutline.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkMovieScraperPlotForOutline.Location = New System.Drawing.Point(6, 113)
        Me.chkMovieScraperPlotForOutline.Name = "chkMovieScraperPlotForOutline"
        Me.chkMovieScraperPlotForOutline.Size = New System.Drawing.Size(228, 17)
        Me.chkMovieScraperPlotForOutline.TabIndex = 68
        Me.chkMovieScraperPlotForOutline.Text = "Use Plot  for Outline if Outline is Empty"
        Me.chkMovieScraperPlotForOutline.UseVisualStyleBackColor = true
        '
        'chkMovieScraperUseMPAAFSK
        '
        Me.chkMovieScraperUseMPAAFSK.AutoSize = true
        Me.chkMovieScraperUseMPAAFSK.Enabled = false
        Me.chkMovieScraperUseMPAAFSK.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkMovieScraperUseMPAAFSK.Location = New System.Drawing.Point(22, 257)
        Me.chkMovieScraperUseMPAAFSK.Name = "chkMovieScraperUseMPAAFSK"
        Me.chkMovieScraperUseMPAAFSK.Size = New System.Drawing.Size(213, 17)
        Me.chkMovieScraperUseMPAAFSK.TabIndex = 67
        Me.chkMovieScraperUseMPAAFSK.Text = "Use MPAA as Fallback for FSK Rating"
        Me.chkMovieScraperUseMPAAFSK.UseVisualStyleBackColor = true
        '
        'chkMovieScraperFullCast
        '
        Me.chkMovieScraperFullCast.AutoSize = true
        Me.chkMovieScraperFullCast.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkMovieScraperFullCast.Location = New System.Drawing.Point(6, 67)
        Me.chkMovieScraperFullCast.Name = "chkMovieScraperFullCast"
        Me.chkMovieScraperFullCast.Size = New System.Drawing.Size(107, 17)
        Me.chkMovieScraperFullCast.TabIndex = 0
        Me.chkMovieScraperFullCast.Text = "Scrape Full Cast"
        Me.chkMovieScraperFullCast.UseVisualStyleBackColor = true
        '
        'chkMovieScraperForceTitle
        '
        Me.chkMovieScraperForceTitle.AutoSize = true
        Me.chkMovieScraperForceTitle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkMovieScraperForceTitle.Location = New System.Drawing.Point(6, 21)
        Me.chkMovieScraperForceTitle.Name = "chkMovieScraperForceTitle"
        Me.chkMovieScraperForceTitle.Size = New System.Drawing.Size(135, 17)
        Me.chkMovieScraperForceTitle.TabIndex = 64
        Me.chkMovieScraperForceTitle.Text = "Force Title Language:"
        Me.chkMovieScraperForceTitle.UseVisualStyleBackColor = true
        '
        'cbMovieScraperForceTitle
        '
        Me.cbMovieScraperForceTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMovieScraperForceTitle.Enabled = false
        Me.cbMovieScraperForceTitle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.cbMovieScraperForceTitle.FormattingEnabled = true
        Me.cbMovieScraperForceTitle.Location = New System.Drawing.Point(168, 17)
        Me.cbMovieScraperForceTitle.Name = "cbMovieScraperForceTitle"
        Me.cbMovieScraperForceTitle.Size = New System.Drawing.Size(115, 21)
        Me.cbMovieScraperForceTitle.Sorted = true
        Me.cbMovieScraperForceTitle.TabIndex = 65
        '
        'chkMovieScraperOnlyValueForMPAA
        '
        Me.chkMovieScraperOnlyValueForMPAA.AutoSize = true
        Me.chkMovieScraperOnlyValueForMPAA.Enabled = false
        Me.chkMovieScraperOnlyValueForMPAA.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkMovieScraperOnlyValueForMPAA.Location = New System.Drawing.Point(22, 241)
        Me.chkMovieScraperOnlyValueForMPAA.Name = "chkMovieScraperOnlyValueForMPAA"
        Me.chkMovieScraperOnlyValueForMPAA.Size = New System.Drawing.Size(168, 17)
        Me.chkMovieScraperOnlyValueForMPAA.TabIndex = 66
        Me.chkMovieScraperOnlyValueForMPAA.Text = "Only Save the Value to NFO"
        Me.chkMovieScraperOnlyValueForMPAA.UseVisualStyleBackColor = true
        '
        'chkMovieScraperOutlineForPlot
        '
        Me.chkMovieScraperOutlineForPlot.AutoSize = true
        Me.chkMovieScraperOutlineForPlot.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkMovieScraperOutlineForPlot.Location = New System.Drawing.Point(6, 149)
        Me.chkMovieScraperOutlineForPlot.Name = "chkMovieScraperOutlineForPlot"
        Me.chkMovieScraperOutlineForPlot.Size = New System.Drawing.Size(206, 17)
        Me.chkMovieScraperOutlineForPlot.TabIndex = 3
        Me.chkMovieScraperOutlineForPlot.Text = "Use Outline for Plot if Plot is Empty"
        Me.chkMovieScraperOutlineForPlot.UseVisualStyleBackColor = true
        '
        'chkMovieScraperCastWithImg
        '
        Me.chkMovieScraperCastWithImg.AutoSize = true
        Me.chkMovieScraperCastWithImg.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkMovieScraperCastWithImg.Location = New System.Drawing.Point(6, 90)
        Me.chkMovieScraperCastWithImg.Name = "chkMovieScraperCastWithImg"
        Me.chkMovieScraperCastWithImg.Size = New System.Drawing.Size(189, 17)
        Me.chkMovieScraperCastWithImg.TabIndex = 1
        Me.chkMovieScraperCastWithImg.Text = "Scrape Only Actors With Images"
        Me.chkMovieScraperCastWithImg.UseVisualStyleBackColor = true
        '
        'chkMovieScraperCertForMPAA
        '
        Me.chkMovieScraperCertForMPAA.AutoSize = true
        Me.chkMovieScraperCertForMPAA.Enabled = false
        Me.chkMovieScraperCertForMPAA.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkMovieScraperCertForMPAA.Location = New System.Drawing.Point(6, 218)
        Me.chkMovieScraperCertForMPAA.Name = "chkMovieScraperCertForMPAA"
        Me.chkMovieScraperCertForMPAA.Size = New System.Drawing.Size(162, 17)
        Me.chkMovieScraperCertForMPAA.TabIndex = 6
        Me.chkMovieScraperCertForMPAA.Text = "Use Certification for MPAA"
        Me.chkMovieScraperCertForMPAA.UseVisualStyleBackColor = true
        '
        'chkMovieScraperFullCrew
        '
        Me.chkMovieScraperFullCrew.AutoSize = true
        Me.chkMovieScraperFullCrew.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkMovieScraperFullCrew.Location = New System.Drawing.Point(145, 67)
        Me.chkMovieScraperFullCrew.Name = "chkMovieScraperFullCrew"
        Me.chkMovieScraperFullCrew.Size = New System.Drawing.Size(111, 17)
        Me.chkMovieScraperFullCrew.TabIndex = 2
        Me.chkMovieScraperFullCrew.Text = "Scrape Full Crew"
        Me.chkMovieScraperFullCrew.UseVisualStyleBackColor = true
        '
        'cbMovieScraperCertLang
        '
        Me.cbMovieScraperCertLang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMovieScraperCertLang.Enabled = false
        Me.cbMovieScraperCertLang.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.cbMovieScraperCertLang.FormattingEnabled = true
        Me.cbMovieScraperCertLang.Items.AddRange(New Object() {"Argentina", "Australia", "Belgium", "Brazil", "Canada", "Finland", "France", "Germany", "Hong Kong", "Hungary", "Iceland", "Ireland", "Netherlands", "New Zealand", "Peru", "Poland", "Portugal", "Serbia", "Singapore", "South Korea", "Spain", "Sweden", "Switzerland", "Turkey", "UK", "USA"})
        Me.cbMovieScraperCertLang.Location = New System.Drawing.Point(175, 191)
        Me.cbMovieScraperCertLang.Name = "cbMovieScraperCertLang"
        Me.cbMovieScraperCertLang.Size = New System.Drawing.Size(108, 21)
        Me.cbMovieScraperCertLang.Sorted = true
        Me.cbMovieScraperCertLang.TabIndex = 5
        '
        'chkMovieScraperCertLang
        '
        Me.chkMovieScraperCertLang.AutoSize = true
        Me.chkMovieScraperCertLang.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkMovieScraperCertLang.Location = New System.Drawing.Point(6, 195)
        Me.chkMovieScraperCertLang.Name = "chkMovieScraperCertLang"
        Me.chkMovieScraperCertLang.Size = New System.Drawing.Size(168, 17)
        Me.chkMovieScraperCertLang.TabIndex = 4
        Me.chkMovieScraperCertLang.Text = "Use Certification Language:"
        Me.chkMovieScraperCertLang.UseVisualStyleBackColor = true
        '
        'pnlMovieScraper
        '
        Me.pnlMovieScraper.BackColor = System.Drawing.Color.White
<<<<<<< HEAD
        Me.pnlMovieScraper.Controls.Add(Me.GroupBox10)
        Me.pnlMovieScraper.Controls.Add(Me.gbOptions)
        Me.pnlMovieScraper.Controls.Add(Me.GroupBox1)
        Me.pnlMovieScraper.Controls.Add(Me.GroupBox26)
        Me.pnlMovieScraper.Location = New System.Drawing.Point(1325, 380)
=======
        Me.pnlMovieScraper.Controls.Add(Me.gbMovieScraperGlobalLocksOpts)
        Me.pnlMovieScraper.Controls.Add(Me.gbMovieScraperFieldsOpts)
        Me.pnlMovieScraper.Controls.Add(Me.gbMovieScraperMiscOpts)
        Me.pnlMovieScraper.Controls.Add(Me.gbMovieScraperMetaDataOpts)
        Me.pnlMovieScraper.Location = New System.Drawing.Point(900, 900)
>>>>>>> upstream/master
        Me.pnlMovieScraper.Name = "pnlMovieScraper"
        Me.pnlMovieScraper.Size = New System.Drawing.Size(750, 500)
        Me.pnlMovieScraper.TabIndex = 14
        Me.pnlMovieScraper.Visible = false
        '
        'tsSettingsTopMenu
        '
        Me.tsSettingsTopMenu.AllowMerge = false
        Me.tsSettingsTopMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsSettingsTopMenu.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.tsSettingsTopMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.tsSettingsTopMenu.Location = New System.Drawing.Point(0, 64)
        Me.tsSettingsTopMenu.Name = "tsSettingsTopMenu"
        Me.tsSettingsTopMenu.Size = New System.Drawing.Size(1008, 25)
        Me.tsSettingsTopMenu.Stretch = true
        Me.tsSettingsTopMenu.TabIndex = 4
        Me.tsSettingsTopMenu.Text = "ToolStrip1"
        '
        'pnlSettingsMain
        '
        Me.pnlSettingsMain.AutoScroll = true
        Me.pnlSettingsMain.BackColor = System.Drawing.Color.White
        Me.pnlSettingsMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlSettingsMain.Location = New System.Drawing.Point(251, 147)
        Me.pnlSettingsMain.Name = "pnlSettingsMain"
        Me.pnlSettingsMain.Size = New System.Drawing.Size(752, 502)
        Me.pnlSettingsMain.TabIndex = 9
        '
        'gbSettingsHelp
        '
        Me.gbSettingsHelp.BackColor = System.Drawing.Color.White
        Me.gbSettingsHelp.Controls.Add(Me.pbSettingsHelpLogo)
        Me.gbSettingsHelp.Controls.Add(Me.lblHelp)
        Me.gbSettingsHelp.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.gbSettingsHelp.Location = New System.Drawing.Point(3, 3)
        Me.gbSettingsHelp.Name = "gbSettingsHelp"
        Me.gbSettingsHelp.Size = New System.Drawing.Size(628, 62)
        Me.gbSettingsHelp.TabIndex = 0
        Me.gbSettingsHelp.TabStop = false
        Me.gbSettingsHelp.Text = "     Help"
        '
        'pbSettingsHelpLogo
        '
        Me.pbSettingsHelpLogo.Image = CType(resources.GetObject("pbSettingsHelpLogo.Image"),System.Drawing.Image)
        Me.pbSettingsHelpLogo.Location = New System.Drawing.Point(6, -2)
        Me.pbSettingsHelpLogo.Name = "pbSettingsHelpLogo"
        Me.pbSettingsHelpLogo.Size = New System.Drawing.Size(16, 16)
        Me.pbSettingsHelpLogo.TabIndex = 1
        Me.pbSettingsHelpLogo.TabStop = false
        '
        'lblHelp
        '
        Me.lblHelp.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblHelp.Location = New System.Drawing.Point(3, 14)
        Me.lblHelp.Name = "lblHelp"
        Me.lblHelp.Size = New System.Drawing.Size(738, 43)
        Me.lblHelp.TabIndex = 0
        '
        'pnlSettingsHelp
        '
        Me.pnlSettingsHelp.BackColor = System.Drawing.Color.White
        Me.pnlSettingsHelp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlSettingsHelp.Controls.Add(Me.gbSettingsHelp)
        Me.pnlSettingsHelp.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.pnlSettingsHelp.Location = New System.Drawing.Point(5, 657)
        Me.pnlSettingsHelp.Name = "pnlSettingsHelp"
        Me.pnlSettingsHelp.Size = New System.Drawing.Size(752, 69)
        Me.pnlSettingsHelp.TabIndex = 8
        '
        'pnlMovieTrailers
        '
        Me.pnlMovieTrailers.BackColor = System.Drawing.Color.White
<<<<<<< HEAD
        Me.pnlMovieTrailers.Controls.Add(Me.GroupBox15)
        Me.pnlMovieTrailers.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlMovieTrailers.Location = New System.Drawing.Point(1125, 620)
        Me.pnlMovieTrailers.Name = "pnlMovieTrailers"
        Me.pnlMovieTrailers.Size = New System.Drawing.Size(750, 500)
        Me.pnlMovieTrailers.TabIndex = 21
        Me.pnlMovieTrailers.Visible = False
        '
        'GroupBox15
        '
        Me.GroupBox15.Controls.Add(Me.cbTrailerQuality)
        Me.GroupBox15.Controls.Add(Me.lblPreferredQuality)
        Me.GroupBox15.Controls.Add(Me.chkDeleteAllTrailers)
        Me.GroupBox15.Controls.Add(Me.chkOverwriteTrailer)
        Me.GroupBox15.Controls.Add(Me.chkDownloadTrailer)
        Me.GroupBox15.Location = New System.Drawing.Point(12, 11)
        Me.GroupBox15.Name = "GroupBox15"
        Me.GroupBox15.Size = New System.Drawing.Size(183, 230)
        Me.GroupBox15.TabIndex = 1
        Me.GroupBox15.TabStop = False
        Me.GroupBox15.Text = "Trailers"
        '
        'cbTrailerQuality
        '
        Me.cbTrailerQuality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTrailerQuality.Enabled = False
        Me.cbTrailerQuality.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.cbTrailerQuality.FormattingEnabled = True
        Me.cbTrailerQuality.Location = New System.Drawing.Point(25, 94)
        Me.cbTrailerQuality.Name = "cbTrailerQuality"
        Me.cbTrailerQuality.Size = New System.Drawing.Size(125, 21)
        Me.cbTrailerQuality.TabIndex = 7
        '
        'lblPreferredQuality
        '
        Me.lblPreferredQuality.AutoSize = True
        Me.lblPreferredQuality.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPreferredQuality.Location = New System.Drawing.Point(24, 78)
        Me.lblPreferredQuality.Name = "lblPreferredQuality"
        Me.lblPreferredQuality.Size = New System.Drawing.Size(96, 13)
        Me.lblPreferredQuality.TabIndex = 6
        Me.lblPreferredQuality.Text = "Preferred Quality:"
        '
        'chkDeleteAllTrailers
        '
        Me.chkDeleteAllTrailers.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkDeleteAllTrailers.Enabled = False
        Me.chkDeleteAllTrailers.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDeleteAllTrailers.Location = New System.Drawing.Point(25, 57)
        Me.chkDeleteAllTrailers.Name = "chkDeleteAllTrailers"
        Me.chkDeleteAllTrailers.Size = New System.Drawing.Size(152, 27)
        Me.chkDeleteAllTrailers.TabIndex = 5
        Me.chkDeleteAllTrailers.Text = "Delete All Existing"
        Me.chkDeleteAllTrailers.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkDeleteAllTrailers.UseVisualStyleBackColor = True
        '
        'chkOverwriteTrailer
        '
        Me.chkOverwriteTrailer.AutoSize = True
        Me.chkOverwriteTrailer.Enabled = False
        Me.chkOverwriteTrailer.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkOverwriteTrailer.Location = New System.Drawing.Point(25, 39)
        Me.chkOverwriteTrailer.Name = "chkOverwriteTrailer"
        Me.chkOverwriteTrailer.Size = New System.Drawing.Size(119, 17)
        Me.chkOverwriteTrailer.TabIndex = 4
        Me.chkOverwriteTrailer.Text = "Overwrite Existing"
        Me.chkOverwriteTrailer.UseVisualStyleBackColor = True
        '
        'chkDownloadTrailer
        '
        Me.chkDownloadTrailer.AutoSize = True
        Me.chkDownloadTrailer.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDownloadTrailer.Location = New System.Drawing.Point(12, 16)
        Me.chkDownloadTrailer.Name = "chkDownloadTrailer"
        Me.chkDownloadTrailer.Size = New System.Drawing.Size(140, 17)
        Me.chkDownloadTrailer.TabIndex = 0
        Me.chkDownloadTrailer.Text = "Enable Trailer Support"
        Me.chkDownloadTrailer.UseVisualStyleBackColor = True
=======
        Me.pnlMovieTrailers.Controls.Add(Me.gbMovieTrailerOpts)
        Me.pnlMovieTrailers.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.pnlMovieTrailers.Location = New System.Drawing.Point(900, 900)
        Me.pnlMovieTrailers.Name = "pnlMovieTrailers"
        Me.pnlMovieTrailers.Size = New System.Drawing.Size(750, 500)
        Me.pnlMovieTrailers.TabIndex = 21
        Me.pnlMovieTrailers.Visible = false
        '
        'gbMovieTrailerOpts
        '
        Me.gbMovieTrailerOpts.Controls.Add(Me.cbMovieTrailerMinQual)
        Me.gbMovieTrailerOpts.Controls.Add(Me.lblMovieTrailerMinQual)
        Me.gbMovieTrailerOpts.Controls.Add(Me.cbMovieTrailerPrefQual)
        Me.gbMovieTrailerOpts.Controls.Add(Me.lblMovieTrailerPrefQual)
        Me.gbMovieTrailerOpts.Controls.Add(Me.chkMovieTrailerDeleteExisting)
        Me.gbMovieTrailerOpts.Controls.Add(Me.chkMovieTrailerOverwrite)
        Me.gbMovieTrailerOpts.Controls.Add(Me.chkMovieTrailerEnable)
        Me.gbMovieTrailerOpts.Location = New System.Drawing.Point(12, 11)
        Me.gbMovieTrailerOpts.Name = "gbMovieTrailerOpts"
        Me.gbMovieTrailerOpts.Size = New System.Drawing.Size(183, 230)
        Me.gbMovieTrailerOpts.TabIndex = 1
        Me.gbMovieTrailerOpts.TabStop = false
        Me.gbMovieTrailerOpts.Text = "Trailers"
        '
        'cbMovieTrailerMinQual
        '
        Me.cbMovieTrailerMinQual.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMovieTrailerMinQual.Enabled = false
        Me.cbMovieTrailerMinQual.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.cbMovieTrailerMinQual.FormattingEnabled = true
        Me.cbMovieTrailerMinQual.Location = New System.Drawing.Point(25, 148)
        Me.cbMovieTrailerMinQual.Name = "cbMovieTrailerMinQual"
        Me.cbMovieTrailerMinQual.Size = New System.Drawing.Size(125, 21)
        Me.cbMovieTrailerMinQual.TabIndex = 9
        '
        'lblMovieTrailerMinQual
        '
        Me.lblMovieTrailerMinQual.AutoSize = true
        Me.lblMovieTrailerMinQual.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblMovieTrailerMinQual.Location = New System.Drawing.Point(24, 132)
        Me.lblMovieTrailerMinQual.Name = "lblMovieTrailerMinQual"
        Me.lblMovieTrailerMinQual.Size = New System.Drawing.Size(97, 13)
        Me.lblMovieTrailerMinQual.TabIndex = 8
        Me.lblMovieTrailerMinQual.Text = "Minimum Quality:"
        '
        'cbMovieTrailerPrefQual
        '
        Me.cbMovieTrailerPrefQual.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMovieTrailerPrefQual.Enabled = false
        Me.cbMovieTrailerPrefQual.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238,Byte))
        Me.cbMovieTrailerPrefQual.FormattingEnabled = true
        Me.cbMovieTrailerPrefQual.Location = New System.Drawing.Point(25, 94)
        Me.cbMovieTrailerPrefQual.Name = "cbMovieTrailerPrefQual"
        Me.cbMovieTrailerPrefQual.Size = New System.Drawing.Size(125, 21)
        Me.cbMovieTrailerPrefQual.TabIndex = 7
        '
        'lblMovieTrailerPrefQual
        '
        Me.lblMovieTrailerPrefQual.AutoSize = true
        Me.lblMovieTrailerPrefQual.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblMovieTrailerPrefQual.Location = New System.Drawing.Point(24, 78)
        Me.lblMovieTrailerPrefQual.Name = "lblMovieTrailerPrefQual"
        Me.lblMovieTrailerPrefQual.Size = New System.Drawing.Size(96, 13)
        Me.lblMovieTrailerPrefQual.TabIndex = 6
        Me.lblMovieTrailerPrefQual.Text = "Preferred Quality:"
        '
        'chkMovieTrailerDeleteExisting
        '
        Me.chkMovieTrailerDeleteExisting.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkMovieTrailerDeleteExisting.Enabled = false
        Me.chkMovieTrailerDeleteExisting.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkMovieTrailerDeleteExisting.Location = New System.Drawing.Point(25, 57)
        Me.chkMovieTrailerDeleteExisting.Name = "chkMovieTrailerDeleteExisting"
        Me.chkMovieTrailerDeleteExisting.Size = New System.Drawing.Size(152, 27)
        Me.chkMovieTrailerDeleteExisting.TabIndex = 5
        Me.chkMovieTrailerDeleteExisting.Text = "Delete All Existing"
        Me.chkMovieTrailerDeleteExisting.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkMovieTrailerDeleteExisting.UseVisualStyleBackColor = true
        '
        'chkMovieTrailerOverwrite
        '
        Me.chkMovieTrailerOverwrite.AutoSize = true
        Me.chkMovieTrailerOverwrite.Enabled = false
        Me.chkMovieTrailerOverwrite.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkMovieTrailerOverwrite.Location = New System.Drawing.Point(25, 39)
        Me.chkMovieTrailerOverwrite.Name = "chkMovieTrailerOverwrite"
        Me.chkMovieTrailerOverwrite.Size = New System.Drawing.Size(119, 17)
        Me.chkMovieTrailerOverwrite.TabIndex = 4
        Me.chkMovieTrailerOverwrite.Text = "Overwrite Existing"
        Me.chkMovieTrailerOverwrite.UseVisualStyleBackColor = true
        '
        'chkMovieTrailerEnable
        '
        Me.chkMovieTrailerEnable.AutoSize = true
        Me.chkMovieTrailerEnable.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkMovieTrailerEnable.Location = New System.Drawing.Point(12, 16)
        Me.chkMovieTrailerEnable.Name = "chkMovieTrailerEnable"
        Me.chkMovieTrailerEnable.Size = New System.Drawing.Size(140, 17)
        Me.chkMovieTrailerEnable.TabIndex = 0
        Me.chkMovieTrailerEnable.Text = "Enable Trailer Support"
        Me.chkMovieTrailerEnable.UseVisualStyleBackColor = true
>>>>>>> upstream/master
        '
        'dlgSettings
        '
        Me.AcceptButton = Me.btnOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(1008, 729)
<<<<<<< HEAD
=======
        Me.Controls.Add(Me.pnlProxy)
        Me.Controls.Add(Me.pnlMovieScraper)
        Me.Controls.Add(Me.pnlTVScraper)
        Me.Controls.Add(Me.pnlMovieTrailers)
        Me.Controls.Add(Me.pnlTVImages)
>>>>>>> upstream/master
        Me.Controls.Add(Me.pnlTVSources)
        Me.Controls.Add(Me.pnlMovieScraper)
        Me.Controls.Add(Me.pnlMovieSources)
        Me.Controls.Add(Me.pnlMovieGeneral)
        Me.Controls.Add(Me.pnlMovieImages)
        Me.Controls.Add(Me.pnlFileSystem)
        Me.Controls.Add(Me.pnlTVGeneral)
        Me.Controls.Add(Me.pnlGeneral)
        Me.Controls.Add(Me.pnlSettingsMain)
        Me.Controls.Add(Me.pnlSettingsHelp)
        Me.Controls.Add(Me.tsSettingsTopMenu)
        Me.Controls.Add(Me.pnlCurrent)
        Me.Controls.Add(Me.pnlSettingsCurrentBGGradient)
        Me.Controls.Add(Me.tvSettingsList)
        Me.Controls.Add(Me.pnlSettingsTop)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnApply)
        Me.Controls.Add(Me.btnOK)
        Me.DoubleBuffered = true
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "dlgSettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Settings"
        Me.gbGeneralMisc.ResumeLayout(false)
        Me.gbGeneralMisc.PerformLayout
        Me.gbGeneralDaemon.ResumeLayout(false)
        Me.gbGeneralDaemon.PerformLayout
        Me.gbGeneralThemes.ResumeLayout(false)
        Me.gbGeneralThemes.PerformLayout
        Me.gbFileSystemCleanFiles.ResumeLayout(false)
        Me.tcFileSystemCleaner.ResumeLayout(false)
        Me.tpFileSystemCleanerStandard.ResumeLayout(false)
        Me.tpFileSystemCleanerStandard.PerformLayout
        Me.tpFileSystemCleanerExpert.ResumeLayout(false)
        Me.tpFileSystemCleanerExpert.PerformLayout
        Me.gbMovieGeneralMiscOpts.ResumeLayout(false)
        Me.gbMovieGeneralMiscOpts.PerformLayout
        Me.pnlMovieImages.ResumeLayout(false)
        Me.gbMovieActorThumbsOpts.ResumeLayout(false)
        Me.gbMovieActorThumbsOpts.PerformLayout
        Me.gbMovieClearArtOpts.ResumeLayout(false)
        Me.gbMovieClearArtOpts.PerformLayout
        Me.gbMovieClearLogoOpts.ResumeLayout(false)
        Me.gbMovieClearLogoOpts.PerformLayout
        Me.gbMovieDiscArtOpts.ResumeLayout(false)
        Me.gbMovieDiscArtOpts.PerformLayout
        Me.gbMovieBannerOpts.ResumeLayout(false)
        Me.gbMovieBannerOpts.PerformLayout
        CType(Me.tbMovieBannerQual,System.ComponentModel.ISupportInitialize).EndInit
        Me.gbMovieLandscapeOpts.ResumeLayout(false)
        Me.gbMovieLandscapeOpts.PerformLayout
        Me.gbMovieEFanartsOpts.ResumeLayout(false)
        Me.gbMovieEFanartsOpts.PerformLayout
        CType(Me.tbMovieEFanartsQual,System.ComponentModel.ISupportInitialize).EndInit
        Me.gbMovieEThumbsOpts.ResumeLayout(false)
        Me.gbMovieEThumbsOpts.PerformLayout
        CType(Me.tbMovieEThumbsQual,System.ComponentModel.ISupportInitialize).EndInit
        Me.gbMovieImagesOpts.ResumeLayout(false)
        Me.gbMovieFanartOpts.ResumeLayout(false)
        Me.gbMovieFanartOpts.PerformLayout
        CType(Me.tbMovieFanartQual,System.ComponentModel.ISupportInitialize).EndInit
        Me.gbMoviePosterOpts.ResumeLayout(false)
        Me.gbMoviePosterOpts.PerformLayout
        CType(Me.tbMoviePosterQual,System.ComponentModel.ISupportInitialize).EndInit
        Me.gbMovieGeneralMediaListOpts.ResumeLayout(false)
        Me.gbMovieGeneralMediaListOpts.PerformLayout
        Me.gbMovieSortTokensOpts.ResumeLayout(false)
        Me.gbMovieSortTokensOpts.PerformLayout
        Me.pnlSettingsTop.ResumeLayout(false)
        Me.pnlSettingsTop.PerformLayout
        CType(Me.pbSettingsTopLogo,System.ComponentModel.ISupportInitialize).EndInit
        Me.pnlGeneral.ResumeLayout(false)
        Me.gbGeneralInterface.ResumeLayout(false)
        Me.gbGeneralInterface.PerformLayout
        Me.pnlMovieGeneral.ResumeLayout(false)
        Me.gbMovieGenrealIMDBMirrorOpts.ResumeLayout(false)
        Me.gbMovieGenrealIMDBMirrorOpts.PerformLayout
        Me.gbMovieGeneralGenreFilterOpts.ResumeLayout(false)
        Me.gbMovieGeneralFiltersOpts.ResumeLayout(false)
        Me.gbMovieGeneralFiltersOpts.PerformLayout
        Me.gbMovieGeneralMissingItemsOpts.ResumeLayout(false)
        Me.pnlFileSystem.ResumeLayout(false)
        Me.gbFileSystemNoStackExts.ResumeLayout(false)
        Me.gbFileSystemNoStackExts.PerformLayout
        Me.gbFileSystemValidExts.ResumeLayout(false)
        Me.gbFileSystemValidExts.PerformLayout
        Me.pnlProxy.ResumeLayout(false)
        Me.gbProxyOpts.ResumeLayout(false)
        Me.gbProxyOpts.PerformLayout
        Me.gbProxyCredsOpts.ResumeLayout(false)
        Me.gbProxyCredsOpts.PerformLayout
        Me.gbMovieBackdropsFolder.ResumeLayout(false)
        Me.gbMovieBackdropsFolder.PerformLayout
        Me.pnlCurrent.ResumeLayout(false)
        CType(Me.pbSettingsCurrent,System.ComponentModel.ISupportInitialize).EndInit
        Me.pnlMovieSources.ResumeLayout(false)
        Me.gbMovieSetsFolder.ResumeLayout(false)
        Me.gbMovieSetsFolder.PerformLayout
        Me.gbMovieFileNaming.ResumeLayout(false)
        Me.tcMovieFileNaming.ResumeLayout(false)
        Me.tpMovieFileNamingXBMC.ResumeLayout(false)
        Me.gbMovieXBMCOptional.ResumeLayout(false)
        Me.gbMovieXBMCOptional.PerformLayout
        Me.gbMovieEden.ResumeLayout(false)
        Me.gbMovieEden.PerformLayout
        Me.gbMovieFrodo.ResumeLayout(false)
        Me.gbMovieFrodo.PerformLayout
        Me.tpMovieFileNamingNMT.ResumeLayout(false)
        Me.gbMovieNMTOptional.ResumeLayout(false)
        Me.gbMovieNMTOptional.PerformLayout
        Me.gbMovieNMJ.ResumeLayout(false)
        Me.gbMovieNMJ.PerformLayout
        Me.gbMovieYAMJ.ResumeLayout(false)
        Me.gbMovieYAMJ.PerformLayout
        Me.tpMovieFileNamingExpert.ResumeLayout(false)
        Me.gbMovieExpert.ResumeLayout(false)
        Me.gbMovieExpert.PerformLayout
        Me.tcMovieFileNamingExpert.ResumeLayout(false)
        Me.tpMovieFileNamingExpertSingle.ResumeLayout(false)
        Me.tpMovieFileNamingExpertSingle.PerformLayout
        Me.gbMovieExpertSingleOptionalSettings.ResumeLayout(false)
        Me.gbMovieExpertSingleOptionalSettings.PerformLayout
        Me.gbMovieExpertSingleOptionalImages.ResumeLayout(false)
        Me.gbMovieExpertSingleOptionalImages.PerformLayout
        Me.tpMovieFileNamingExpertMulti.ResumeLayout(false)
        Me.tpMovieFileNamingExpertMulti.PerformLayout
        Me.gbMovieExpertMultiOptionalImages.ResumeLayout(false)
        Me.gbMovieExpertMultiOptionalImages.PerformLayout
        Me.gbMovieExpertMultiOptionalSettings.ResumeLayout(false)
        Me.gbMovieExpertMultiOptionalSettings.PerformLayout
        Me.tpMovieFileNamingExpertVTS.ResumeLayout(false)
        Me.tpMovieFileNamingExpertVTS.PerformLayout
        Me.gbMovieExpertVTSOptionalSettings.ResumeLayout(false)
        Me.gbMovieExpertVTSOptionalSettings.PerformLayout
        Me.gbMovieExpertVTSOptionalImages.ResumeLayout(false)
        Me.gbMovieExpertVTSOptionalImages.PerformLayout
        Me.tpMovieFileNamingExpertBDMV.ResumeLayout(false)
        Me.tpMovieFileNamingExpertBDMV.PerformLayout
        Me.gbMovieExpertBDMVOptionalSettings.ResumeLayout(false)
        Me.gbMovieExpertBDMVOptionalSettings.PerformLayout
        Me.gbMovieExpertBDMVOptionalImages.ResumeLayout(false)
        Me.gbMovieExpertBDMVOptionalImages.PerformLayout
        Me.gbMovieMiscOpts.ResumeLayout(false)
        Me.gbMovieMiscOpts.PerformLayout
        Me.pnlTVGeneral.ResumeLayout(false)
        Me.gbTVGeneralMediaListOpts.ResumeLayout(false)
        Me.gbTVGeneralMediaListOpts.PerformLayout
        Me.gbTVGeneralListEpisodeOpts.ResumeLayout(false)
        Me.gbTVGeneralListEpisodeOpts.PerformLayout
        Me.gbTVGeneralListSeasonOpts.ResumeLayout(false)
        Me.gbTVGeneralListSeasonOpts.PerformLayout
        Me.gbTVGeneralListShowOpts.ResumeLayout(false)
        Me.gbTVGeneralListShowOpts.PerformLayout
        Me.gbTVEpisodeFilterOpts.ResumeLayout(false)
        Me.gbTVEpisodeFilterOpts.PerformLayout
        Me.gbTVGeneralMiscOpts.ResumeLayout(false)
        Me.gbTVShowFilterOpts.ResumeLayout(false)
        Me.gbTVShowFilterOpts.PerformLayout
        Me.pnlTVSources.ResumeLayout(false)
        Me.tcTVSources.ResumeLayout(false)
        Me.tpTVSourcesGeneral.ResumeLayout(false)
        Me.gbTVFileNaming.ResumeLayout(false)
        Me.tcTVFileNaming.ResumeLayout(false)
        Me.tpTVFileNamingXBMC.ResumeLayout(false)
        Me.gbTVXBMCAdditional.ResumeLayout(false)
        Me.gbTVXBMCAdditional.PerformLayout
        Me.gbTVFrodo.ResumeLayout(false)
        Me.gbTVFrodo.PerformLayout
        Me.tpTVFileNamingNMT.ResumeLayout(false)
        Me.gbTVNMT.ResumeLayout(false)
        Me.gbTVNMT.PerformLayout
        Me.gbTVYAMJ.ResumeLayout(false)
        Me.gbTVYAMJ.PerformLayout
        Me.gbTVSourcesMiscOpts.ResumeLayout(false)
        Me.gbTVSourcesMiscOpts.PerformLayout
        Me.tpTVSourcesRegex.ResumeLayout(false)
        Me.gbTVShowRegex.ResumeLayout(false)
        Me.gbTVShowRegex.PerformLayout
        Me.pnlTVImages.ResumeLayout(false)
        Me.tcTVImages.ResumeLayout(false)
        Me.tpTVShow.ResumeLayout(false)
        Me.gbTVShowCharacterArtOpts.ResumeLayout(false)
        Me.gbTVShowCharacterArtOpts.PerformLayout
        Me.gbTVShowClearArtOpts.ResumeLayout(false)
        Me.gbTVShowClearArtOpts.PerformLayout
        Me.gbTVShowClearLogoOpts.ResumeLayout(false)
        Me.gbTVShowClearLogoOpts.PerformLayout
        Me.gbTVShowLandscapeOpts.ResumeLayout(false)
        Me.gbTVShowLandscapeOpts.PerformLayout
        Me.gbTVShowBannerOpts.ResumeLayout(false)
        Me.gbTVShowBannerOpts.PerformLayout
        CType(Me.tbTVShowBannerQual,System.ComponentModel.ISupportInitialize).EndInit
        Me.gbTVShowPosterOpts.ResumeLayout(false)
        Me.gbTVShowPosterOpts.PerformLayout
        CType(Me.tbTVShowPosterQual,System.ComponentModel.ISupportInitialize).EndInit
        Me.gbTVShowFanartOpts.ResumeLayout(false)
        Me.gbTVShowFanartOpts.PerformLayout
        CType(Me.tbTVShowFanartQual,System.ComponentModel.ISupportInitialize).EndInit
        Me.tpTVAllSeasons.ResumeLayout(false)
        Me.gbTVASLandscapeOpts.ResumeLayout(false)
        Me.gbTVASLandscapeOpts.PerformLayout
        Me.gbTVASFanartOpts.ResumeLayout(false)
        Me.gbTVASFanartOpts.PerformLayout
        CType(Me.tbTVASFanartQual,System.ComponentModel.ISupportInitialize).EndInit
        Me.gbTVASBannerOpts.ResumeLayout(false)
        Me.gbTVASBannerOpts.PerformLayout
        CType(Me.tbTVASBannerQual,System.ComponentModel.ISupportInitialize).EndInit
        Me.gbTVASPosterOpts.ResumeLayout(false)
        Me.gbTVASPosterOpts.PerformLayout
        CType(Me.tbTVASPosterQual,System.ComponentModel.ISupportInitialize).EndInit
        Me.tpTVSeason.ResumeLayout(false)
        Me.gbTVSeasonLandscapeOpts.ResumeLayout(false)
        Me.gbTVSeasonLandscapeOpts.PerformLayout
        Me.gbTVSeasonBannerOpts.ResumeLayout(false)
        Me.gbTVSeasonBannerOpts.PerformLayout
        CType(Me.tbTVSeasonBannerQual,System.ComponentModel.ISupportInitialize).EndInit
        Me.gbTVSeasonPosterOpts.ResumeLayout(false)
        Me.gbTVSeasonPosterOpts.PerformLayout
        CType(Me.tbTVSeasonPosterQual,System.ComponentModel.ISupportInitialize).EndInit
        Me.gbTVSeasonFanartOpts.ResumeLayout(false)
        Me.gbTVSeasonFanartOpts.PerformLayout
        CType(Me.tbTVSeasonFanartQual,System.ComponentModel.ISupportInitialize).EndInit
        Me.tpTVEpisode.ResumeLayout(false)
        Me.gbTVEpisodePosterOpts.ResumeLayout(false)
        Me.gbTVEpisodePosterOpts.PerformLayout
        CType(Me.tbTVEpisodePosterQual,System.ComponentModel.ISupportInitialize).EndInit
        Me.gbTVEpisodeFanartOpts.ResumeLayout(false)
        Me.gbTVEpisodeFanartOpts.PerformLayout
        CType(Me.tbTVEpisodeFanartQual,System.ComponentModel.ISupportInitialize).EndInit
        Me.pnlTVScraper.ResumeLayout(false)
        Me.gbTVScraperDurationOpts.ResumeLayout(false)
        Me.gbTVScraperDurationOpts.PerformLayout
        Me.gbTVScraperFieldsOpts.ResumeLayout(false)
        Me.gbTVScraperFieldsShowOpts.ResumeLayout(false)
        Me.gbTVScraperFieldsEpisodeOpts.ResumeLayout(false)
        Me.gbTVScraperGlobalLocksOpts.ResumeLayout(false)
        Me.gbTVScraperGlobalLocksEpisodeOpts.ResumeLayout(false)
        Me.gbTVScraperGlobalLocksShowOpts.ResumeLayout(false)
        Me.gbTVScraperMetaDataOpts.ResumeLayout(false)
        Me.gbTVScraperMetaDataOpts.PerformLayout
        Me.gbTVScraperDefFIExtOpts.ResumeLayout(false)
        Me.gbTVScraperDefFIExtOpts.PerformLayout
        Me.gbTVScraperOptionsOpts.ResumeLayout(false)
        Me.gbTVScraperOptionsOpts.PerformLayout
        Me.gbMovieScraperFieldsOpts.ResumeLayout(false)
        Me.gbMovieScraperFieldsOpts.PerformLayout
        Me.gbMovieScraperMetaDataOpts.ResumeLayout(false)
        Me.gbMovieScraperMetaDataOpts.PerformLayout
        Me.gbMovieScraperDefFIExtOpts.ResumeLayout(false)
        Me.gbMovieScraperDefFIExtOpts.PerformLayout
        Me.gbMovieScraperDurationFormatOpts.ResumeLayout(false)
        Me.gbMovieScraperDurationFormatOpts.PerformLayout
        Me.gbMovieScraperGlobalLocksOpts.ResumeLayout(false)
        Me.gbMovieScraperGlobalLocksOpts.PerformLayout
        Me.gbMovieScraperMiscOpts.ResumeLayout(false)
        Me.gbMovieScraperMiscOpts.PerformLayout
        Me.pnlMovieScraper.ResumeLayout(false)
        Me.gbSettingsHelp.ResumeLayout(false)
        CType(Me.pbSettingsHelpLogo,System.ComponentModel.ISupportInitialize).EndInit
        Me.pnlSettingsHelp.ResumeLayout(false)
        Me.pnlMovieTrailers.ResumeLayout(false)
        Me.gbMovieTrailerOpts.ResumeLayout(false)
        Me.gbMovieTrailerOpts.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnApply As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents pnlSettingsTop As System.Windows.Forms.Panel
    Friend WithEvents lblSettingsTopDetails As System.Windows.Forms.Label
    Friend WithEvents lblSettingsTopTitle As System.Windows.Forms.Label
    Friend WithEvents pbSettingsTopLogo As System.Windows.Forms.PictureBox
    Friend WithEvents gbFileSystemCleanFiles As System.Windows.Forms.GroupBox
    Friend WithEvents chkCleanFolderJPG As System.Windows.Forms.CheckBox
    Friend WithEvents chkCleanFanartJPG As System.Windows.Forms.CheckBox
    Friend WithEvents chkCleanMovieTBNb As System.Windows.Forms.CheckBox
    Friend WithEvents chkCleanMovieTBN As System.Windows.Forms.CheckBox
    Friend WithEvents chkCleanMovieNFOb As System.Windows.Forms.CheckBox
    Friend WithEvents chkCleanMovieNFO As System.Windows.Forms.CheckBox
    Friend WithEvents chkCleanMovieFanartJPG As System.Windows.Forms.CheckBox
    Friend WithEvents gbGeneralMisc As System.Windows.Forms.GroupBox
    Friend WithEvents lblGeneralOverwriteNfo As System.Windows.Forms.Label
    Friend WithEvents chkGeneralOverwriteNfo As System.Windows.Forms.CheckBox
    Friend WithEvents lvMovieSources As System.Windows.Forms.ListView
    Friend WithEvents colPath As System.Windows.Forms.ColumnHeader
    Friend WithEvents colRecur As System.Windows.Forms.ColumnHeader
    Friend WithEvents chkMovieFanartOverwrite As System.Windows.Forms.CheckBox
    Friend WithEvents chkMoviePosterOverwrite As System.Windows.Forms.CheckBox
    Friend WithEvents cbMovieFanartPrefSize As System.Windows.Forms.ComboBox
    Friend WithEvents lblFanartSize As System.Windows.Forms.Label
    Friend WithEvents lblMoviePosterSize As System.Windows.Forms.Label
    Friend WithEvents cbMoviePosterPrefSize As System.Windows.Forms.ComboBox
    Friend WithEvents gbMovieGeneralMediaListOpts As System.Windows.Forms.GroupBox
    Friend WithEvents chkMovieTrailerCol As System.Windows.Forms.CheckBox
    Friend WithEvents chkMovieInfoCol As System.Windows.Forms.CheckBox
    Friend WithEvents chkMovieFanartCol As System.Windows.Forms.CheckBox
    Friend WithEvents chkMoviePosterCol As System.Windows.Forms.CheckBox
    Friend WithEvents btnMovieSourceRemove As System.Windows.Forms.Button
    Friend WithEvents btnMovieSourceAdd As System.Windows.Forms.Button
    Friend WithEvents gbMovieImagesOpts As System.Windows.Forms.GroupBox
    Friend WithEvents chkCleanMovieNameJPG As System.Windows.Forms.CheckBox
    Friend WithEvents chkCleanMovieJPG As System.Windows.Forms.CheckBox
    Friend WithEvents chkCleanPosterJPG As System.Windows.Forms.CheckBox
    Friend WithEvents chkCleanPosterTBN As System.Windows.Forms.CheckBox
    Friend WithEvents chkCleanDotFanartJPG As System.Windows.Forms.CheckBox
    Friend WithEvents gbMovieGeneralMiscOpts As System.Windows.Forms.GroupBox
    Friend WithEvents chkMovieGeneralMarkNew As System.Windows.Forms.CheckBox
    Friend WithEvents gbMovieFanartOpts As System.Windows.Forms.GroupBox
    Friend WithEvents lblMovieFanartWidth As System.Windows.Forms.Label
    Friend WithEvents lblMovieFanartHeight As System.Windows.Forms.Label
    Friend WithEvents chkMovieFanartResize As System.Windows.Forms.CheckBox
    Friend WithEvents txtMovieFanartWidth As System.Windows.Forms.TextBox
    Friend WithEvents txtMovieFanartHeight As System.Windows.Forms.TextBox
    Friend WithEvents gbMoviePosterOpts As System.Windows.Forms.GroupBox
    Friend WithEvents lblMoviePosterWidth As System.Windows.Forms.Label
    Friend WithEvents lblMoviePosterHeight As System.Windows.Forms.Label
    Friend WithEvents chkMoviePosterResize As System.Windows.Forms.CheckBox
    Friend WithEvents txtMoviePosterWidth As System.Windows.Forms.TextBox
    Friend WithEvents txtMoviePosterHeight As System.Windows.Forms.TextBox
    Friend WithEvents ilSettings As System.Windows.Forms.ImageList
    Friend WithEvents tvSettingsList As System.Windows.Forms.TreeView
    Friend WithEvents pnlGeneral As System.Windows.Forms.Panel
    Friend WithEvents pnlProxy As System.Windows.Forms.Panel
    Friend WithEvents pnlMovieGeneral As System.Windows.Forms.Panel
    Friend WithEvents lblSettingsCurrent As System.Windows.Forms.Label
    Friend WithEvents pnlSettingsCurrentBGGradient As System.Windows.Forms.Panel
    Friend WithEvents pnlCurrent As System.Windows.Forms.Panel
    Friend WithEvents chkCleanExtrathumbs As System.Windows.Forms.CheckBox
    Friend WithEvents pnlFileSystem As System.Windows.Forms.Panel
    Friend WithEvents gbFileSystemValidExts As System.Windows.Forms.GroupBox
    Friend WithEvents btnFileSystemValidExtsRemove As System.Windows.Forms.Button
    Friend WithEvents btnFileSystemValidExtsAdd As System.Windows.Forms.Button
    Friend WithEvents txtFileSystemValidExts As System.Windows.Forms.TextBox
    Friend WithEvents lstFileSystemValidExts As System.Windows.Forms.ListBox
    Friend WithEvents chkGeneralCheckUpdates As System.Windows.Forms.CheckBox
    Friend WithEvents gbMovieBackdropsFolder As System.Windows.Forms.GroupBox
    Friend WithEvents txtMovieBackdropsPath As System.Windows.Forms.TextBox
    Friend WithEvents btnMovieBackdropsBrowse As System.Windows.Forms.Button
    Friend WithEvents chkMovieBackdropsAuto As System.Windows.Forms.CheckBox
    Friend WithEvents chkMovieEThumbsCol As System.Windows.Forms.CheckBox
    Friend WithEvents chkMovieSubCol As System.Windows.Forms.CheckBox
    Friend WithEvents pnlMovieSources As System.Windows.Forms.Panel
    Friend WithEvents clbMovieGenre As System.Windows.Forms.CheckedListBox
    Friend WithEvents pnlMovieImages As System.Windows.Forms.Panel
    Friend WithEvents gbMovieMiscOpts As System.Windows.Forms.GroupBox
    Friend WithEvents lblMovieSkipLessThanMB As System.Windows.Forms.Label
    Friend WithEvents txtMovieSkipLessThan As System.Windows.Forms.TextBox
    Friend WithEvents lblMovieSkipLessThan As System.Windows.Forms.Label
    Friend WithEvents chkMovieSkipStackedSizeCheck As System.Windows.Forms.CheckBox
    Friend WithEvents lblMoviePosterQual As System.Windows.Forms.Label
    Friend WithEvents tbMoviePosterQual As System.Windows.Forms.TrackBar
    Friend WithEvents lblMoviePosterQ As System.Windows.Forms.Label
    Friend WithEvents lblMovieFanartQual As System.Windows.Forms.Label
    Friend WithEvents tbMovieFanartQual As System.Windows.Forms.TrackBar
    Friend WithEvents lblMovieFanartQ As System.Windows.Forms.Label
    Friend WithEvents chkMovieFanartPrefOnly As System.Windows.Forms.CheckBox
    Friend WithEvents chkMovieNoSaveImagesToNfo As System.Windows.Forms.CheckBox
    Friend WithEvents tcFileSystemCleaner As System.Windows.Forms.TabControl
    Friend WithEvents tpFileSystemCleanerStandard As System.Windows.Forms.TabPage
    Friend WithEvents tpFileSystemCleanerExpert As System.Windows.Forms.TabPage
    Friend WithEvents lblFileSystemCleanerWarning As System.Windows.Forms.Label
    Friend WithEvents btnFileSystemCleanerWhitelistRemove As System.Windows.Forms.Button
    Friend WithEvents btnFileSystemCleanerWhitelistAdd As System.Windows.Forms.Button
    Friend WithEvents txtFileSystemCleanerWhitelist As System.Windows.Forms.TextBox
    Friend WithEvents lstFileSystemCleanerWhitelist As System.Windows.Forms.ListBox
    Friend WithEvents lblFileSystemCleanerWhitelist As System.Windows.Forms.Label
    Friend WithEvents chkFileSystemCleanerWhitelist As System.Windows.Forms.CheckBox
    Friend WithEvents chkGeneralInfoPanelAnim As System.Windows.Forms.CheckBox
    Friend WithEvents chkGeneralShowImgDims As System.Windows.Forms.CheckBox
    Friend WithEvents chkGeneralHideFanart As System.Windows.Forms.CheckBox
    Friend WithEvents chkGeneralHidePoster As System.Windows.Forms.CheckBox
    Friend WithEvents gbFileSystemNoStackExts As System.Windows.Forms.GroupBox
    Friend WithEvents btnFileSystemNoStackExtsRemove As System.Windows.Forms.Button
    Friend WithEvents btnFileSystemNoStackExtsAdd As System.Windows.Forms.Button
    Friend WithEvents txtFileSystemNoStackExts As System.Windows.Forms.TextBox
    Friend WithEvents lstFileSystemNoStackExts As System.Windows.Forms.ListBox
    Friend WithEvents colName As System.Windows.Forms.ColumnHeader
    Friend WithEvents colFolder As System.Windows.Forms.ColumnHeader
    Friend WithEvents colSingle As System.Windows.Forms.ColumnHeader
    Friend WithEvents colID As System.Windows.Forms.ColumnHeader
    Friend WithEvents fbdBrowse As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents btnMovieSourceEdit As System.Windows.Forms.Button
    Friend WithEvents chkGeneralShowGenresText As System.Windows.Forms.CheckBox
    Friend WithEvents chkMovieDisplayYear As System.Windows.Forms.CheckBox
    Friend WithEvents gbMovieSortTokensOpts As System.Windows.Forms.GroupBox
    Friend WithEvents btnMovieSortTokenRemove As System.Windows.Forms.Button
    Friend WithEvents btnMovieSortTokenAdd As System.Windows.Forms.Button
    Friend WithEvents txtMovieSortToken As System.Windows.Forms.TextBox
    Friend WithEvents lstMovieSortTokens As System.Windows.Forms.ListBox
    Friend WithEvents txtMovieLevTolerance As System.Windows.Forms.TextBox
    Friend WithEvents lblMovieLevTolerance As System.Windows.Forms.Label
    Friend WithEvents chkMovieLevTolerance As System.Windows.Forms.CheckBox
    Friend WithEvents lblGeneralntLang As System.Windows.Forms.Label
    Friend WithEvents cbGeneralLanguage As System.Windows.Forms.ComboBox
    Friend WithEvents gbMovieGeneralMissingItemsOpts As System.Windows.Forms.GroupBox
    Friend WithEvents chkMovieMissingEThumbs As System.Windows.Forms.CheckBox
    Friend WithEvents chkMovieMissingSubs As System.Windows.Forms.CheckBox
    Friend WithEvents chkMovieMissingTrailer As System.Windows.Forms.CheckBox
    Friend WithEvents chkMovieMissingNFO As System.Windows.Forms.CheckBox
    Friend WithEvents chkMovieMissingFanart As System.Windows.Forms.CheckBox
    Friend WithEvents chkMovieMissingPoster As System.Windows.Forms.CheckBox
    Friend WithEvents lblGeneralMovieTheme As System.Windows.Forms.Label
    Friend WithEvents cbGeneralMovieTheme As System.Windows.Forms.ComboBox
    Friend WithEvents gbGeneralThemes As System.Windows.Forms.GroupBox
    Friend WithEvents ToolTips As System.Windows.Forms.ToolTip
    Friend WithEvents pnlTVSources As System.Windows.Forms.Panel
    Friend WithEvents btnTVSourceEdit As System.Windows.Forms.Button
    Friend WithEvents lvTVSources As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnRemTVSource As System.Windows.Forms.Button
    Friend WithEvents btnTVSourceAdd As System.Windows.Forms.Button
    Friend WithEvents chkMovieCleanDB As System.Windows.Forms.CheckBox
    Friend WithEvents chkMovieGeneralIgnoreLastScan As System.Windows.Forms.CheckBox
    Friend WithEvents pnlTVGeneral As System.Windows.Forms.Panel
    Friend WithEvents gbTVEpisodeFilterOpts As System.Windows.Forms.GroupBox
    Friend WithEvents btnTVEpisodeFilterDown As System.Windows.Forms.Button
    Friend WithEvents btnTVEpisodeFilterUp As System.Windows.Forms.Button
    Friend WithEvents chkTVEpisodeProperCase As System.Windows.Forms.CheckBox
    Friend WithEvents btnTVEpisodeFilterRemove As System.Windows.Forms.Button
    Friend WithEvents btnTVEpisodeFilterAdd As System.Windows.Forms.Button
    Friend WithEvents txtTVEpisodeFilter As System.Windows.Forms.TextBox
    Friend WithEvents lstTVEpisodeFilter As System.Windows.Forms.ListBox
    Friend WithEvents gbTVShowFilterOpts As System.Windows.Forms.GroupBox
    Friend WithEvents btnTVShowFilterDown As System.Windows.Forms.Button
    Friend WithEvents btnTVShowFilterUp As System.Windows.Forms.Button
    Friend WithEvents chkTVShowProperCase As System.Windows.Forms.CheckBox
    Friend WithEvents btnTVShowFilterRemove As System.Windows.Forms.Button
    Friend WithEvents btnTVShowFilterAdd As System.Windows.Forms.Button
    Friend WithEvents txtTVShowFilter As System.Windows.Forms.TextBox
    Friend WithEvents lstTVShowFilter As System.Windows.Forms.ListBox
    Friend WithEvents gbMovieGeneralFiltersOpts As System.Windows.Forms.GroupBox
    Friend WithEvents btnMovieFilterDown As System.Windows.Forms.Button
    Friend WithEvents btnMovieFilterUp As System.Windows.Forms.Button
    Friend WithEvents chkMovieProperCase As System.Windows.Forms.CheckBox
    Friend WithEvents btnMovieFilterRemove As System.Windows.Forms.Button
    Friend WithEvents btnMovieFilterAdd As System.Windows.Forms.Button
    Friend WithEvents txtMovieFilter As System.Windows.Forms.TextBox
    Friend WithEvents lstMovieFilters As System.Windows.Forms.ListBox
    Friend WithEvents gbMovieGeneralGenreFilterOpts As System.Windows.Forms.GroupBox
    Friend WithEvents gbTVSourcesMiscOpts As System.Windows.Forms.GroupBox
    Friend WithEvents chkTVGeneralIgnoreLastScan As System.Windows.Forms.CheckBox
    Friend WithEvents chkTVCleanDB As System.Windows.Forms.CheckBox
    Friend WithEvents gbGeneralInterface As System.Windows.Forms.GroupBox
    Friend WithEvents cbGeneralTVEpisodeTheme As System.Windows.Forms.ComboBox
    Friend WithEvents lblGeneralTVEpisodeTheme As System.Windows.Forms.Label
    Friend WithEvents cbGeneralTVShowTheme As System.Windows.Forms.ComboBox
    Friend WithEvents lblGeneralTVShowTheme As System.Windows.Forms.Label
    Friend WithEvents tcTVSources As System.Windows.Forms.TabControl
    Friend WithEvents tpTVSourcesGeneral As System.Windows.Forms.TabPage
    Friend WithEvents tpTVSourcesRegex As System.Windows.Forms.TabPage
    Friend WithEvents lvTVShowRegex As System.Windows.Forms.ListView
    Friend WithEvents colTVShowRegexSeason As System.Windows.Forms.ColumnHeader
    Friend WithEvents colTVShowRegexSeasonApply As System.Windows.Forms.ColumnHeader
    Friend WithEvents colTVShowRegexEpisode As System.Windows.Forms.ColumnHeader
    Friend WithEvents colTVShowRegexEpisodeApply As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnTVShowRegexAdd As System.Windows.Forms.Button
    Friend WithEvents btnTVShowRegexEdit As System.Windows.Forms.Button
    Friend WithEvents btnTVShowRegexRemove As System.Windows.Forms.Button
    Friend WithEvents txtTVSeasonRegex As System.Windows.Forms.TextBox
    Friend WithEvents cbTVEpisodeRetrieve As System.Windows.Forms.ComboBox
    Friend WithEvents txtTVEpisodeRegex As System.Windows.Forms.TextBox
    Friend WithEvents cbTVSeasonRetrieve As System.Windows.Forms.ComboBox
    Friend WithEvents lblTVSeasonMatch As System.Windows.Forms.Label
    Friend WithEvents gbTVShowRegex As System.Windows.Forms.GroupBox
    Friend WithEvents lblTVEpisodeRetrieve As System.Windows.Forms.Label
    Friend WithEvents lblTVSeasonRetrieve As System.Windows.Forms.Label
    Friend WithEvents lblTVEpisodeMatch As System.Windows.Forms.Label
    Friend WithEvents colTVShowRegexID As System.Windows.Forms.ColumnHeader
    Friend WithEvents pnlTVImages As System.Windows.Forms.Panel
    Friend WithEvents gbTVShowFanartOpts As System.Windows.Forms.GroupBox
    Friend WithEvents txtTVShowFanartWidth As System.Windows.Forms.TextBox
    Friend WithEvents txtTVShowFanartHeight As System.Windows.Forms.TextBox
    Friend WithEvents lblTVShowFanartQual As System.Windows.Forms.Label
    Friend WithEvents tbTVShowFanartQual As System.Windows.Forms.TrackBar
    Friend WithEvents lblTVShowFanartQ As System.Windows.Forms.Label
    Friend WithEvents lblTVShowFanartWidth As System.Windows.Forms.Label
    Friend WithEvents lblTVShowFanartHeight As System.Windows.Forms.Label
    Friend WithEvents chkTVShowFanartResize As System.Windows.Forms.CheckBox
    Friend WithEvents cbTVShowFanartPrefSize As System.Windows.Forms.ComboBox
    Friend WithEvents lblTVShowFanartSize As System.Windows.Forms.Label
    Friend WithEvents chkTVShowFanartOverwrite As System.Windows.Forms.CheckBox
    Friend WithEvents gbTVShowPosterOpts As System.Windows.Forms.GroupBox
    Friend WithEvents txtTVShowPosterWidth As System.Windows.Forms.TextBox
    Friend WithEvents txtTVShowPosterHeight As System.Windows.Forms.TextBox
    Friend WithEvents lblTVShowPosterQual As System.Windows.Forms.Label
    Friend WithEvents tbTVShowPosterQual As System.Windows.Forms.TrackBar
    Friend WithEvents lblTVShowPosterQ As System.Windows.Forms.Label
    Friend WithEvents lblTVShowPosterWidth As System.Windows.Forms.Label
    Friend WithEvents lblTVShowPosterHeight As System.Windows.Forms.Label
    Friend WithEvents chkTVShowPosterResize As System.Windows.Forms.CheckBox
    Friend WithEvents lblTVShowPosterSize As System.Windows.Forms.Label
    Friend WithEvents cbTVShowPosterPrefSize As System.Windows.Forms.ComboBox
    Friend WithEvents chkTVShowPosterOverwrite As System.Windows.Forms.CheckBox
    Friend WithEvents tcTVImages As System.Windows.Forms.TabControl
    Friend WithEvents tpTVShow As System.Windows.Forms.TabPage
    Friend WithEvents tpTVEpisode As System.Windows.Forms.TabPage
    Friend WithEvents pnlTVScraper As System.Windows.Forms.Panel
    Friend WithEvents gbTVGeneralMiscOpts As System.Windows.Forms.GroupBox
    Friend WithEvents gbTVGeneralMediaListOpts As System.Windows.Forms.GroupBox
    Friend WithEvents gbTVGeneralListEpisodeOpts As System.Windows.Forms.GroupBox
    Friend WithEvents chkTVEpisodeNfoCol As System.Windows.Forms.CheckBox
    Friend WithEvents chkTVEpisodeFanartCol As System.Windows.Forms.CheckBox
    Friend WithEvents chkTVEpisodePosterCol As System.Windows.Forms.CheckBox
    Friend WithEvents gbTVGeneralListSeasonOpts As System.Windows.Forms.GroupBox
    Friend WithEvents chkTVSeasonFanartCol As System.Windows.Forms.CheckBox
    Friend WithEvents chkTVSeasonPosterCol As System.Windows.Forms.CheckBox
    Friend WithEvents gbTVGeneralListShowOpts As System.Windows.Forms.GroupBox
    Friend WithEvents chkTVShowNfoCol As System.Windows.Forms.CheckBox
    Friend WithEvents chkTVShowFanartCol As System.Windows.Forms.CheckBox
    Friend WithEvents chkTVShowPosterCol As System.Windows.Forms.CheckBox
    Friend WithEvents gbTVEpisodePosterOpts As System.Windows.Forms.GroupBox
    Friend WithEvents txtTVEpisodePosterWidth As System.Windows.Forms.TextBox
    Friend WithEvents txtTVEpisodePosterHeight As System.Windows.Forms.TextBox
    Friend WithEvents lblTVEpisodePosterQual As System.Windows.Forms.Label
    Friend WithEvents tbTVEpisodePosterQual As System.Windows.Forms.TrackBar
    Friend WithEvents lblTVEpisodePosterQ As System.Windows.Forms.Label
    Friend WithEvents lblTVEpisodePosterWidth As System.Windows.Forms.Label
    Friend WithEvents lblTVEpisodePosterHeight As System.Windows.Forms.Label
    Friend WithEvents chkTVEpisodePosterResize As System.Windows.Forms.CheckBox
    Friend WithEvents chkTVEpisodePosterOverwrite As System.Windows.Forms.CheckBox
    Friend WithEvents gbTVEpisodeFanartOpts As System.Windows.Forms.GroupBox
    Friend WithEvents txtTVEpisodeFanartWidth As System.Windows.Forms.TextBox
    Friend WithEvents txtTVEpisodeFanartHeight As System.Windows.Forms.TextBox
    Friend WithEvents lblTVEpisodeFanartQual As System.Windows.Forms.Label
    Friend WithEvents tbTVEpisodeFanartQual As System.Windows.Forms.TrackBar
    Friend WithEvents lblTVEpisodeFanartQ As System.Windows.Forms.Label
    Friend WithEvents lblTVEpisodeFanartWidth As System.Windows.Forms.Label
    Friend WithEvents lblTVEpisodeFanartHeight As System.Windows.Forms.Label
    Friend WithEvents chkTVEpisodeFanartResize As System.Windows.Forms.CheckBox
    Friend WithEvents cbTVEpisodeFanartPrefSize As System.Windows.Forms.ComboBox
    Friend WithEvents lblTVEpisodeFanartSize As System.Windows.Forms.Label
    Friend WithEvents chkTVEpisodeFanartOverwrite As System.Windows.Forms.CheckBox
    Friend WithEvents gbProxyOpts As System.Windows.Forms.GroupBox
    Friend WithEvents gbProxyCredsOpts As System.Windows.Forms.GroupBox
    Friend WithEvents chkProxyCredsEnable As System.Windows.Forms.CheckBox
    Friend WithEvents lblProxyPort As System.Windows.Forms.Label
    Friend WithEvents lblProxyURI As System.Windows.Forms.Label
    Friend WithEvents txtProxyPort As System.Windows.Forms.TextBox
    Friend WithEvents txtProxyURI As System.Windows.Forms.TextBox
    Friend WithEvents chkProxyEnable As System.Windows.Forms.CheckBox
    Friend WithEvents txtProxyDomain As System.Windows.Forms.TextBox
    Friend WithEvents lblProxyDomain As System.Windows.Forms.Label
    Friend WithEvents txtProxyPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtProxyUsername As System.Windows.Forms.TextBox
    Friend WithEvents lblProxyUsername As System.Windows.Forms.Label
    Friend WithEvents lblProxyPassword As System.Windows.Forms.Label
    Friend WithEvents chkGeneralSourceFromFolder As System.Windows.Forms.CheckBox
    Friend WithEvents chkMovieSortBeforeScan As System.Windows.Forms.CheckBox
    Friend WithEvents gbTVScraperOptionsOpts As System.Windows.Forms.GroupBox
    Friend WithEvents gbMovieScraperMetaDataOpts As System.Windows.Forms.GroupBox
    Friend WithEvents gbMovieScraperDefFIExtOpts As System.Windows.Forms.GroupBox
    Friend WithEvents lstMovieScraperDefFIExt As System.Windows.Forms.ListBox
    Friend WithEvents txtMovieScraperDefFIExt As System.Windows.Forms.TextBox
    Friend WithEvents lblMovieScraperDefFIExt As System.Windows.Forms.Label
    Friend WithEvents btnMovieScraperDefFIExtRemove As System.Windows.Forms.Button
    Friend WithEvents btnMovieScraperDefFIExtEdit As System.Windows.Forms.Button
    Friend WithEvents btnMovieScraperDefFIExtAdd As System.Windows.Forms.Button
    Friend WithEvents chkMovieScraperMetaDataIFOScan As System.Windows.Forms.CheckBox
    Friend WithEvents cbMovieLanguageOverlay As System.Windows.Forms.ComboBox
    Friend WithEvents lblMovieLanguageOverlay As System.Windows.Forms.Label
    Friend WithEvents gbMovieScraperDurationFormatOpts As System.Windows.Forms.GroupBox
    Friend WithEvents chkMovieScraperMetaDataScan As System.Windows.Forms.CheckBox
    Friend WithEvents chkMovieScraperUseMDDuration As System.Windows.Forms.CheckBox
    Friend WithEvents gbMovieScraperGlobalLocksOpts As System.Windows.Forms.GroupBox
    Friend WithEvents chkMovieLockOutline As System.Windows.Forms.CheckBox
    Friend WithEvents chkMovieLockPlot As System.Windows.Forms.CheckBox
    Friend WithEvents chkMovieLockTrailer As System.Windows.Forms.CheckBox
    Friend WithEvents chkMovieLockGenre As System.Windows.Forms.CheckBox
    Friend WithEvents chkMovieLockStudio As System.Windows.Forms.CheckBox
    Friend WithEvents chkMovieLockRating As System.Windows.Forms.CheckBox
    Friend WithEvents chkMovieLockTagline As System.Windows.Forms.CheckBox
    Friend WithEvents chkMovieLockTitle As System.Windows.Forms.CheckBox
    Friend WithEvents gbMovieScraperFieldsOpts As System.Windows.Forms.GroupBox
    Friend WithEvents chkMovieScraperTop250 As System.Windows.Forms.CheckBox
    Friend WithEvents chkMovieScraperCountry As System.Windows.Forms.CheckBox
    Friend WithEvents txtMovieScraperGenreLimit As System.Windows.Forms.TextBox
    Friend WithEvents lblMovieScraperGenreLimit As System.Windows.Forms.Label
    Friend WithEvents txtMovieScraperCastLimit As System.Windows.Forms.TextBox
    Friend WithEvents lblMovieScraperCastLimit As System.Windows.Forms.Label
    Friend WithEvents chkMovieScraperCrew As System.Windows.Forms.CheckBox
    Friend WithEvents chkMovieScraperMusicBy As System.Windows.Forms.CheckBox
    Friend WithEvents chkMovieScraperProducers As System.Windows.Forms.CheckBox
    Friend WithEvents chkMovieScraperWriters As System.Windows.Forms.CheckBox
    Friend WithEvents chkMovieScraperStudio As System.Windows.Forms.CheckBox
    Friend WithEvents chkMovieScraperRuntime As System.Windows.Forms.CheckBox
    Friend WithEvents chkMovieScraperPlot As System.Windows.Forms.CheckBox
    Friend WithEvents chkMovieScraperOutline As System.Windows.Forms.CheckBox
    Friend WithEvents chkMovieScraperGenre As System.Windows.Forms.CheckBox
    Friend WithEvents chkMovieScraperDirector As System.Windows.Forms.CheckBox
    Friend WithEvents chkMovieScraperTagline As System.Windows.Forms.CheckBox
    Friend WithEvents chkMovieScraperCast As System.Windows.Forms.CheckBox
    Friend WithEvents chkMovieScraperVotes As System.Windows.Forms.CheckBox
    Friend WithEvents chkMovieScraperTrailer As System.Windows.Forms.CheckBox
    Friend WithEvents chkMovieScraperRating As System.Windows.Forms.CheckBox
    Friend WithEvents chkMovieScraperRelease As System.Windows.Forms.CheckBox
    Friend WithEvents chkMovieScraperMPAA As System.Windows.Forms.CheckBox
    Friend WithEvents chkMovieScraperYear As System.Windows.Forms.CheckBox
    Friend WithEvents chkMovieScraperTitle As System.Windows.Forms.CheckBox
    Friend WithEvents gbMovieScraperMiscOpts As System.Windows.Forms.GroupBox
    Friend WithEvents cbMovieScraperForceTitle As System.Windows.Forms.ComboBox
    Friend WithEvents chkMovieScraperForceTitle As System.Windows.Forms.CheckBox
    Friend WithEvents chkMovieScraperOutlineForPlot As System.Windows.Forms.CheckBox
    Friend WithEvents chkMovieScraperCastWithImg As System.Windows.Forms.CheckBox
    Friend WithEvents chkMovieScraperCertForMPAA As System.Windows.Forms.CheckBox
    Friend WithEvents chkMovieScraperFullCast As System.Windows.Forms.CheckBox
    Friend WithEvents chkMovieScraperFullCrew As System.Windows.Forms.CheckBox
    Friend WithEvents cbMovieScraperCertLang As System.Windows.Forms.ComboBox
    Friend WithEvents chkMovieScraperCertLang As System.Windows.Forms.CheckBox
    Friend WithEvents pnlMovieScraper As System.Windows.Forms.Panel
    Friend WithEvents tpTVSeason As System.Windows.Forms.TabPage
    Friend WithEvents gbTVSeasonPosterOpts As System.Windows.Forms.GroupBox
    Friend WithEvents txtTVSeasonPosterWidth As System.Windows.Forms.TextBox
    Friend WithEvents txtTVSeasonPosterHeight As System.Windows.Forms.TextBox
    Friend WithEvents lblTVSeasonPosterQual As System.Windows.Forms.Label
    Friend WithEvents tbTVSeasonPosterQual As System.Windows.Forms.TrackBar
    Friend WithEvents lblTVSeasonPosterQ As System.Windows.Forms.Label
    Friend WithEvents lblTVSeasonPosterWidth As System.Windows.Forms.Label
    Friend WithEvents lblTVSeasonPosterHeight As System.Windows.Forms.Label
    Friend WithEvents chkTVSeasonPosterResize As System.Windows.Forms.CheckBox
    Friend WithEvents lblTVSeasonPosterSize As System.Windows.Forms.Label
    Friend WithEvents cbTVSeasonPosterPrefSize As System.Windows.Forms.ComboBox
    Friend WithEvents chkTVSeasonPosterOverwrite As System.Windows.Forms.CheckBox
    Friend WithEvents gbTVSeasonFanartOpts As System.Windows.Forms.GroupBox
    Friend WithEvents txtTVSeasonFanartWidth As System.Windows.Forms.TextBox
    Friend WithEvents txtTVSeasonFanartHeight As System.Windows.Forms.TextBox
    Friend WithEvents lblTVSeasonFanartQual As System.Windows.Forms.Label
    Friend WithEvents tbTVSeasonFanartQual As System.Windows.Forms.TrackBar
    Friend WithEvents lblTVSeasonFanartQ As System.Windows.Forms.Label
    Friend WithEvents lblTVSeasonFanartWidth As System.Windows.Forms.Label
    Friend WithEvents lblTVSeasonFanartHeight As System.Windows.Forms.Label
    Friend WithEvents chkTVSeasonFanartResize As System.Windows.Forms.CheckBox
    Friend WithEvents cbTVSeasonFanartPrefSize As System.Windows.Forms.ComboBox
    Friend WithEvents lblTVSeasonFanartSize As System.Windows.Forms.Label
    Friend WithEvents chkTVSeasonFanartOverwrite As System.Windows.Forms.CheckBox
    Friend WithEvents chkTVScanOrderModify As System.Windows.Forms.CheckBox
    Friend WithEvents chkMovieScanOrderModify As System.Windows.Forms.CheckBox
    Friend WithEvents lblTVScraperUpdateTime As System.Windows.Forms.Label
    Friend WithEvents cbTVScraperUpdateTime As System.Windows.Forms.ComboBox
    Friend WithEvents chkTVEpisodeNoFilter As System.Windows.Forms.CheckBox
    Friend WithEvents chkTVDisplayMissingEpisodes As System.Windows.Forms.CheckBox
    Friend WithEvents gbTVScraperMetaDataOpts As System.Windows.Forms.GroupBox
    Friend WithEvents gbTVScraperDefFIExtOpts As System.Windows.Forms.GroupBox
    Friend WithEvents lstTVScraperDefFIExt As System.Windows.Forms.ListBox
    Friend WithEvents txtTVScraperDefFIExt As System.Windows.Forms.TextBox
    Friend WithEvents lblTVScraperDefFIExt As System.Windows.Forms.Label
    Friend WithEvents btnTVScraperDefFIExtRemove As System.Windows.Forms.Button
    Friend WithEvents btnTVScraperDefFIExtEdit As System.Windows.Forms.Button
    Friend WithEvents btnTVScraperDefFIExtAdd As System.Windows.Forms.Button
    Friend WithEvents cbTVLanguageOverlay As System.Windows.Forms.ComboBox
    Friend WithEvents lblTVLanguageOverlay As System.Windows.Forms.Label
    Friend WithEvents chkTVScraperMetaDataScan As System.Windows.Forms.CheckBox
    Friend WithEvents gbTVScraperFieldsOpts As System.Windows.Forms.GroupBox
    Friend WithEvents gbTVScraperGlobalLocksOpts As System.Windows.Forms.GroupBox
    Friend WithEvents chkTVLockEpisodePlot As System.Windows.Forms.CheckBox
    Friend WithEvents chkTVLockShowStudio As System.Windows.Forms.CheckBox
    Friend WithEvents chkTVLockEpisodeRating As System.Windows.Forms.CheckBox
    Friend WithEvents chkTVLockEpisodeTitle As System.Windows.Forms.CheckBox
    Friend WithEvents gbTVScraperGlobalLocksEpisodeOpts As System.Windows.Forms.GroupBox
    Friend WithEvents gbTVScraperGlobalLocksShowOpts As System.Windows.Forms.GroupBox
    Friend WithEvents chkTVLockShowPlot As System.Windows.Forms.CheckBox
    Friend WithEvents chkTVLockShowGenre As System.Windows.Forms.CheckBox
    Friend WithEvents chkTVLockShowRating As System.Windows.Forms.CheckBox
    Friend WithEvents chkTVLockShowTitle As System.Windows.Forms.CheckBox
    Friend WithEvents gbTVScraperFieldsShowOpts As System.Windows.Forms.GroupBox
    Friend WithEvents chkTVScraperShowEpiGuideURL As System.Windows.Forms.CheckBox
    Friend WithEvents chkTVScraperShowMPAA As System.Windows.Forms.CheckBox
    Friend WithEvents chkTVScraperShowPlot As System.Windows.Forms.CheckBox
    Friend WithEvents chkTVScraperShowGenre As System.Windows.Forms.CheckBox
    Friend WithEvents chkTVScraperShowTitle As System.Windows.Forms.CheckBox
    Friend WithEvents gbTVScraperFieldsEpisodeOpts As System.Windows.Forms.GroupBox
    Friend WithEvents chkTVScraperEpisodeTitle As System.Windows.Forms.CheckBox
    Friend WithEvents chkTVScraperEpisodeEpisode As System.Windows.Forms.CheckBox
    Friend WithEvents chkTVScraperEpisodeSeason As System.Windows.Forms.CheckBox
    Friend WithEvents chkTVScraperShowRating As System.Windows.Forms.CheckBox
    Friend WithEvents chkTVScraperShowActors As System.Windows.Forms.CheckBox
    Friend WithEvents chkTVScraperShowStudio As System.Windows.Forms.CheckBox
    Friend WithEvents chkTVScraperShowPremiered As System.Windows.Forms.CheckBox
    Friend WithEvents chkTVScraperEpisodeActors As System.Windows.Forms.CheckBox
    Friend WithEvents chkTVScraperEpisodeCredits As System.Windows.Forms.CheckBox
    Friend WithEvents chkTVScraperEpisodeDirector As System.Windows.Forms.CheckBox
    Friend WithEvents chkTVScraperEpisodePlot As System.Windows.Forms.CheckBox
    Friend WithEvents chkTVScraperEpisodeRating As System.Windows.Forms.CheckBox
    Friend WithEvents chkTVScraperEpisodeAired As System.Windows.Forms.CheckBox
    Friend WithEvents lblMovieScraperDurationRuntimeFormat As System.Windows.Forms.Label
    Friend WithEvents txtMovieScraperDurationRuntimeFormat As System.Windows.Forms.TextBox
    Friend WithEvents chkMovieScraperCertification As System.Windows.Forms.CheckBox
    Friend WithEvents tsSettingsTopMenu As System.Windows.Forms.ToolStrip
    Friend WithEvents pnlSettingsMain As System.Windows.Forms.Panel
    Friend WithEvents pbSettingsCurrent As System.Windows.Forms.PictureBox
    Friend WithEvents chkTVGeneralDisplayASPoster As System.Windows.Forms.CheckBox
    Friend WithEvents gbSettingsHelp As System.Windows.Forms.GroupBox
    Friend WithEvents lblHelp As System.Windows.Forms.Label
    Friend WithEvents pnlSettingsHelp As System.Windows.Forms.Panel
    Friend WithEvents pbSettingsHelpLogo As System.Windows.Forms.PictureBox
    Friend WithEvents chkTVGeneralMarkNewShows As System.Windows.Forms.CheckBox
    Friend WithEvents chkTVGeneralMarkNewEpisodes As System.Windows.Forms.CheckBox
    Friend WithEvents chkMovieScraperOnlyValueForMPAA As System.Windows.Forms.CheckBox
    Friend WithEvents cbTVScraperOptionsOrdering As System.Windows.Forms.ComboBox
    Friend WithEvents lblTVScraperOptionsOrdering As System.Windows.Forms.Label
    Friend WithEvents btnTVShowFilterReset As System.Windows.Forms.Button
    Friend WithEvents btnTVEpisodeFilterReset As System.Windows.Forms.Button
    Friend WithEvents btnMovieFilterReset As System.Windows.Forms.Button
    Friend WithEvents btnFileSystemValidExtsReset As System.Windows.Forms.Button
    Friend WithEvents btnTVShowRegexReset As System.Windows.Forms.Button
    Friend WithEvents btnTVShowRegexDown As System.Windows.Forms.Button
    Friend WithEvents btnTVShowRegexUp As System.Windows.Forms.Button
    Friend WithEvents TVSkipLessThanMB As System.Windows.Forms.Label
    Friend WithEvents txtTVSkipLessThan As System.Windows.Forms.TextBox
    Friend WithEvents lblTVSkipLessThan As System.Windows.Forms.Label
    Friend WithEvents btnTVShowRegexClear As System.Windows.Forms.Button
    Friend WithEvents btnTVShowRegexGet As System.Windows.Forms.Button
    Friend WithEvents chkMovieClickScrapeAsk As System.Windows.Forms.CheckBox
    Friend WithEvents chkMovieClickScrape As System.Windows.Forms.CheckBox
    Friend WithEvents chkMovieScraperActorThumbs As System.Windows.Forms.CheckBox
    Friend WithEvents chkMoviePosterPrefOnly As System.Windows.Forms.CheckBox
    Friend WithEvents chkGeneralCreationDate As System.Windows.Forms.CheckBox
    Friend WithEvents chkMovieLockLanguageV As System.Windows.Forms.CheckBox
    Friend WithEvents chkMovieLockLanguageA As System.Windows.Forms.CheckBox
    Friend WithEvents chkMovieLockMPAA As System.Windows.Forms.CheckBox
    Friend WithEvents chkMovieScraperUseMPAAFSK As System.Windows.Forms.CheckBox
    Friend WithEvents gbMovieGenrealIMDBMirrorOpts As System.Windows.Forms.GroupBox
    Friend WithEvents lblMovieIMDBMirror As System.Windows.Forms.Label
    Friend WithEvents txtMovieIMDBURL As System.Windows.Forms.TextBox
    Friend WithEvents pnlMovieTrailers As System.Windows.Forms.Panel
    Friend WithEvents gbMovieTrailerOpts As System.Windows.Forms.GroupBox
    Friend WithEvents cbMovieTrailerPrefQual As System.Windows.Forms.ComboBox
    Friend WithEvents lblMovieTrailerPrefQual As System.Windows.Forms.Label
    Friend WithEvents chkMovieTrailerDeleteExisting As System.Windows.Forms.CheckBox
    Friend WithEvents chkMovieTrailerOverwrite As System.Windows.Forms.CheckBox
    Friend WithEvents chkMovieTrailerEnable As System.Windows.Forms.CheckBox
    Friend WithEvents txtMovieScraperOutlineLimit As System.Windows.Forms.TextBox
    Friend WithEvents chkMovieScraperPlotForOutline As System.Windows.Forms.CheckBox
    Friend WithEvents lblMovieScraperOutlineLimit As System.Windows.Forms.Label
    Friend WithEvents chkGeneralHideFanartSmall As System.Windows.Forms.CheckBox
    Friend WithEvents chkGeneralImagesGlassOverlay As System.Windows.Forms.CheckBox
    Friend WithEvents gbMovieFileNaming As System.Windows.Forms.GroupBox
    Friend WithEvents tcMovieFileNaming As System.Windows.Forms.TabControl
    Friend WithEvents tpMovieFileNamingXBMC As System.Windows.Forms.TabPage
    Friend WithEvents tpMovieFileNamingExpert As System.Windows.Forms.TabPage
    Friend WithEvents gbMovieEden As System.Windows.Forms.GroupBox
    Friend WithEvents gbMovieFrodo As System.Windows.Forms.GroupBox
    Friend WithEvents chkMovieActorThumbsFrodo As System.Windows.Forms.CheckBox
    Friend WithEvents chkMovieTrailerFrodo As System.Windows.Forms.CheckBox
    Friend WithEvents chkMovieFanartFrodo As System.Windows.Forms.CheckBox
    Friend WithEvents chkMoviePosterFrodo As System.Windows.Forms.CheckBox
    Friend WithEvents chkMovieNFOFrodo As System.Windows.Forms.CheckBox
    Friend WithEvents chkMovieClearLogoFrodo As System.Windows.Forms.CheckBox
    Friend WithEvents chkMovieDiscArtFrodo As System.Windows.Forms.CheckBox
    Friend WithEvents chkMovieClearArtFrodo As System.Windows.Forms.CheckBox
    Friend WithEvents chkMovieBannerFrodo As System.Windows.Forms.CheckBox
    Friend WithEvents chkMovieLandscapeFrodo As System.Windows.Forms.CheckBox
    Friend WithEvents chkMovieUseFrodo As System.Windows.Forms.CheckBox
    Friend WithEvents chkMovieExtrafanartsFrodo As System.Windows.Forms.CheckBox
    Friend WithEvents chkMovieExtrathumbsFrodo As System.Windows.Forms.CheckBox
    Friend WithEvents chkMovieExtrafanartsEden As System.Windows.Forms.CheckBox
    Friend WithEvents chkMovieExtrathumbsEden As System.Windows.Forms.CheckBox
    Friend WithEvents chkMovieUseEden As System.Windows.Forms.CheckBox
    Friend WithEvents chkMovieActorThumbsEden As System.Windows.Forms.CheckBox
    Friend WithEvents chkMovieTrailerEden As System.Windows.Forms.CheckBox
    Friend WithEvents chkMovieFanartEden As System.Windows.Forms.CheckBox
    Friend WithEvents chkMoviePosterEden As System.Windows.Forms.CheckBox
    Friend WithEvents chkMovieNFOEden As System.Windows.Forms.CheckBox
    Friend WithEvents gbTVScraperDurationOpts As System.Windows.Forms.GroupBox
    Friend WithEvents chkTVScraperUseMDDuration As System.Windows.Forms.CheckBox
    Friend WithEvents txtTVScraperDurationRuntimeFormat As System.Windows.Forms.TextBox
    Friend WithEvents chkMovieMissingEFanarts As System.Windows.Forms.CheckBox
    Friend WithEvents tpMovieFileNamingNMT As System.Windows.Forms.TabPage
    Friend WithEvents gbMovieNMJ As System.Windows.Forms.GroupBox
    Friend WithEvents chkMovieUseNMJ As System.Windows.Forms.CheckBox
    Friend WithEvents chkMovieBannerNMJ As System.Windows.Forms.CheckBox
    Friend WithEvents chkMovieTrailerNMJ As System.Windows.Forms.CheckBox
    Friend WithEvents chkMovieFanartNMJ As System.Windows.Forms.CheckBox
    Friend WithEvents chkMoviePosterNMJ As System.Windows.Forms.CheckBox
    Friend WithEvents chkMovieNFONMJ As System.Windows.Forms.CheckBox
    Friend WithEvents gbMovieYAMJ As System.Windows.Forms.GroupBox
    Friend WithEvents chkMovieUseYAMJ As System.Windows.Forms.CheckBox
    Friend WithEvents chkMovieBannerYAMJ As System.Windows.Forms.CheckBox
    Friend WithEvents chkMovieTrailerYAMJ As System.Windows.Forms.CheckBox
    Friend WithEvents chkMovieFanartYAMJ As System.Windows.Forms.CheckBox
    Friend WithEvents chkMoviePosterYAMJ As System.Windows.Forms.CheckBox
    Friend WithEvents chkMovieNFOYAMJ As System.Windows.Forms.CheckBox
    Friend WithEvents gbMovieEFanartsOpts As System.Windows.Forms.GroupBox
    Friend WithEvents chkMovieEFanartsPrefOnly As System.Windows.Forms.CheckBox
    Friend WithEvents txtMovieEFanartsWidth As System.Windows.Forms.TextBox
    Friend WithEvents txtMovieEFanartsHeight As System.Windows.Forms.TextBox
    Friend WithEvents lblMovieEFanartsQual As System.Windows.Forms.Label
    Friend WithEvents tbMovieEFanartsQual As System.Windows.Forms.TrackBar
    Friend WithEvents lblMovieEFanartsQ As System.Windows.Forms.Label
    Friend WithEvents lblMovieEFanartsWidth As System.Windows.Forms.Label
    Friend WithEvents lblMovieEFanartsHeight As System.Windows.Forms.Label
    Friend WithEvents chkMovieEFanartsResize As System.Windows.Forms.CheckBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents cbMovieEFanartsPrefSize As System.Windows.Forms.ComboBox
    Friend WithEvents chkMovieEFanartsOverwrite As System.Windows.Forms.CheckBox
    Friend WithEvents gbMovieEThumbsOpts As System.Windows.Forms.GroupBox
    Friend WithEvents chkMovieEThumbsPrefOnly As System.Windows.Forms.CheckBox
    Friend WithEvents txtMovieEThumbsWidth As System.Windows.Forms.TextBox
    Friend WithEvents txtMovieEThumbsHeight As System.Windows.Forms.TextBox
    Friend WithEvents lblMovieEThumbsQual As System.Windows.Forms.Label
    Friend WithEvents tbMovieEThumbsQual As System.Windows.Forms.TrackBar
    Friend WithEvents lblMovieEThumbsQ As System.Windows.Forms.Label
    Friend WithEvents lblMovieEThumbsWidth As System.Windows.Forms.Label
    Friend WithEvents lblMovieEThumbsHeight As System.Windows.Forms.Label
    Friend WithEvents chkMovieEThumbsResize As System.Windows.Forms.CheckBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents cbMovieEThumbsPrefSize As System.Windows.Forms.ComboBox
    Friend WithEvents chkMovieEThumbsOverwrite As System.Windows.Forms.CheckBox
    Friend WithEvents gbMovieXBMCOptional As System.Windows.Forms.GroupBox
    Friend WithEvents chkMovieXBMCTrailerFormat As System.Windows.Forms.CheckBox
    Friend WithEvents chkMovieWatchedCol As System.Windows.Forms.CheckBox
    Friend WithEvents chkMovieEFanartsCol As System.Windows.Forms.CheckBox
    Friend WithEvents chkMovieScraperTitleFallback As System.Windows.Forms.CheckBox
    Friend WithEvents gbMovieSetsFolder As System.Windows.Forms.GroupBox
    Friend WithEvents btnMovieMoviesetsBrowse As System.Windows.Forms.Button
    Friend WithEvents txtMovieMoviesetsPath As System.Windows.Forms.TextBox
    Friend WithEvents gbGeneralDaemon As System.Windows.Forms.GroupBox
    Friend WithEvents btnGeneralDaemonPathBrowse As System.Windows.Forms.Button
    Friend WithEvents txtGeneralDaemonPath As System.Windows.Forms.TextBox
    Friend WithEvents lblGeneralDaemonPath As System.Windows.Forms.Label
    Friend WithEvents lblGeneralDaemonDrive As System.Windows.Forms.Label
    Friend WithEvents cbGeneralDaemonDrive As System.Windows.Forms.ComboBox
    Friend WithEvents fileBrowse As System.Windows.Forms.OpenFileDialog
    Friend WithEvents chkMovieUseExpert As System.Windows.Forms.CheckBox
    Friend WithEvents gbMovieExpert As System.Windows.Forms.GroupBox
    Friend WithEvents tcMovieFileNamingExpert As System.Windows.Forms.TabControl
    Friend WithEvents tpMovieFileNamingExpertSingle As System.Windows.Forms.TabPage
    Friend WithEvents txtMoviePosterExpertSingle As System.Windows.Forms.TextBox
    Friend WithEvents txtMovieFanartExpertSingle As System.Windows.Forms.TextBox
    Friend WithEvents txtMovieTrailerExpertSingle As System.Windows.Forms.TextBox
    Friend WithEvents txtMovieBannerExpertSingle As System.Windows.Forms.TextBox
    Friend WithEvents txtMovieClearLogoExpertSingle As System.Windows.Forms.TextBox
    Friend WithEvents txtMovieClearArtExpertSingle As System.Windows.Forms.TextBox
    Friend WithEvents txtMovieLandscapeExpertSingle As System.Windows.Forms.TextBox
    Friend WithEvents txtMovieDiscArtExpertSingle As System.Windows.Forms.TextBox
    Friend WithEvents lblMovieLandscapeExpertSingle As System.Windows.Forms.Label
    Friend WithEvents lblMovieDiscArtExpertSingle As System.Windows.Forms.Label
    Friend WithEvents lblMovieBannerExpertSingle As System.Windows.Forms.Label
    Friend WithEvents lblMovieTrailerExpertSingle As System.Windows.Forms.Label
    Friend WithEvents lblMovieClearLogoExpertSingle As System.Windows.Forms.Label
    Friend WithEvents lblMovieFanartExpertSingle As System.Windows.Forms.Label
    Friend WithEvents lblMoviePosterExpertSingle As System.Windows.Forms.Label
    Friend WithEvents txtMovieNFOExpertSingle As System.Windows.Forms.TextBox
    Friend WithEvents lblMovieNFOExpertSingle As System.Windows.Forms.Label
    Friend WithEvents tpMovieFileNamingExpertMulti As System.Windows.Forms.TabPage
    Friend WithEvents tpMovieFileNamingExpertVTS As System.Windows.Forms.TabPage
    Friend WithEvents tpMovieFileNamingExpertBDMV As System.Windows.Forms.TabPage
    Friend WithEvents lblMovieClearArtExpertSingle As System.Windows.Forms.Label
    Friend WithEvents gbMovieExpertSingleOptionalImages As System.Windows.Forms.GroupBox
    Friend WithEvents chkMovieActorThumbsExpertSingle As System.Windows.Forms.CheckBox
    Friend WithEvents chkMovieExtrafanartsExpertSingle As System.Windows.Forms.CheckBox
    Friend WithEvents chkMovieExtrathumbsExpertSingle As System.Windows.Forms.CheckBox
    Friend WithEvents gbMovieExpertSingleOptionalSettings As System.Windows.Forms.GroupBox
    Friend WithEvents chkMovieXBMCTrailerFormatExpertSingle As System.Windows.Forms.CheckBox
    Friend WithEvents txtMoviePosterExpertMulti As System.Windows.Forms.TextBox
    Friend WithEvents txtMovieFanartExpertMulti As System.Windows.Forms.TextBox
    Friend WithEvents lblMovieClearArtExpertMulti As System.Windows.Forms.Label
    Friend WithEvents txtMovieTrailerExpertMulti As System.Windows.Forms.TextBox
    Friend WithEvents txtMovieBannerExpertMulti As System.Windows.Forms.TextBox
    Friend WithEvents txtMovieClearLogoExpertMulti As System.Windows.Forms.TextBox
    Friend WithEvents txtMovieClearArtExpertMulti As System.Windows.Forms.TextBox
    Friend WithEvents txtMovieLandscapeExpertMulti As System.Windows.Forms.TextBox
    Friend WithEvents txtMovieDiscArtExpertMulti As System.Windows.Forms.TextBox
    Friend WithEvents lblMovieLandscapeExpertMulti As System.Windows.Forms.Label
    Friend WithEvents lblMovieDiscArtExpertMulti As System.Windows.Forms.Label
    Friend WithEvents lblMovieBannerExpertMulti As System.Windows.Forms.Label
    Friend WithEvents lblMovieTrailerExpertMulti As System.Windows.Forms.Label
    Friend WithEvents lblMovieClearLogoExpertMulti As System.Windows.Forms.Label
    Friend WithEvents lblMovieFanartExpertMulti As System.Windows.Forms.Label
    Friend WithEvents lblMoviePosterExpertMulti As System.Windows.Forms.Label
    Friend WithEvents txtMovieNFOExpertMulti As System.Windows.Forms.TextBox
    Friend WithEvents lblMovieNFOExpertMulti As System.Windows.Forms.Label
    Friend WithEvents chkMovieStackExpertSingle As System.Windows.Forms.CheckBox
    Friend WithEvents chkMovieUnstackExpertSingle As System.Windows.Forms.CheckBox
    Friend WithEvents txtMovieActorThumbsExtExpertSingle As System.Windows.Forms.TextBox
    Friend WithEvents gbMovieExpertMultiOptionalImages As System.Windows.Forms.GroupBox
    Friend WithEvents txtMovieActorThumbsExtExpertMulti As System.Windows.Forms.TextBox
    Friend WithEvents chkMovieActorThumbsExpertMulti As System.Windows.Forms.CheckBox
    Friend WithEvents gbMovieExpertMultiOptionalSettings As System.Windows.Forms.GroupBox
    Friend WithEvents chkMovieUnstackExpertMulti As System.Windows.Forms.CheckBox
    Friend WithEvents chkMovieStackExpertMulti As System.Windows.Forms.CheckBox
    Friend WithEvents chkMovieXBMCTrailerFormatExpertMulti As System.Windows.Forms.CheckBox
    Friend WithEvents gbMovieExpertVTSOptionalSettings As System.Windows.Forms.GroupBox
    Friend WithEvents chkMovieXBMCTrailerFormatExpertVTS As System.Windows.Forms.CheckBox
    Friend WithEvents gbMovieExpertVTSOptionalImages As System.Windows.Forms.GroupBox
    Friend WithEvents txtMovieActorThumbsExtExpertVTS As System.Windows.Forms.TextBox
    Friend WithEvents chkMovieActorThumbsExpertVTS As System.Windows.Forms.CheckBox
    Friend WithEvents chkMovieExtrafanartsExpertVTS As System.Windows.Forms.CheckBox
    Friend WithEvents chkMovieExtrathumbsExpertVTS As System.Windows.Forms.CheckBox
    Friend WithEvents lblMovieClearArtExpertVTS As System.Windows.Forms.Label
    Friend WithEvents txtMoviePosterExpertVTS As System.Windows.Forms.TextBox
    Friend WithEvents txtMovieFanartExpertVTS As System.Windows.Forms.TextBox
    Friend WithEvents txtMovieTrailerExpertVTS As System.Windows.Forms.TextBox
    Friend WithEvents txtMovieBannerExpertVTS As System.Windows.Forms.TextBox
    Friend WithEvents txtMovieClearLogoExpertVTS As System.Windows.Forms.TextBox
    Friend WithEvents txtMovieClearArtExpertVTS As System.Windows.Forms.TextBox
    Friend WithEvents txtMovieLandscapeExpertVTS As System.Windows.Forms.TextBox
    Friend WithEvents txtMovieDiscArtExpertVTS As System.Windows.Forms.TextBox
    Friend WithEvents lblMovieLandscapeExpertVTS As System.Windows.Forms.Label
    Friend WithEvents lblMovieDiscArtExpertVTS As System.Windows.Forms.Label
    Friend WithEvents lblMovieBannerExpertVTS As System.Windows.Forms.Label
    Friend WithEvents lblMovieTrailerExpertVTS As System.Windows.Forms.Label
    Friend WithEvents lblMovieClearLogoExpertVTS As System.Windows.Forms.Label
    Friend WithEvents lblMovieFanartExpertVTS As System.Windows.Forms.Label
    Friend WithEvents lblMoviePosterExpertVTS As System.Windows.Forms.Label
    Friend WithEvents txtMovieNFOExpertVTS As System.Windows.Forms.TextBox
    Friend WithEvents lblMovieNFOExpertVTS As System.Windows.Forms.Label
    Friend WithEvents gbMovieExpertBDMVOptionalSettings As System.Windows.Forms.GroupBox
    Friend WithEvents chkMovieXBMCTrailerFormatExpertBDMV As System.Windows.Forms.CheckBox
    Friend WithEvents gbMovieExpertBDMVOptionalImages As System.Windows.Forms.GroupBox
    Friend WithEvents txtMovieActorThumbsExtExpertBDMV As System.Windows.Forms.TextBox
    Friend WithEvents chkMovieActorThumbsExpertBDMV As System.Windows.Forms.CheckBox
    Friend WithEvents chkMovieExtrafanartsExpertBDMV As System.Windows.Forms.CheckBox
    Friend WithEvents chkMovieExtrathumbsExpertBDMV As System.Windows.Forms.CheckBox
    Friend WithEvents lblMovieClearArtExpertBDMV As System.Windows.Forms.Label
    Friend WithEvents txtMoviePosterExpertBDMV As System.Windows.Forms.TextBox
    Friend WithEvents txtMovieFanartExpertBDMV As System.Windows.Forms.TextBox
    Friend WithEvents txtMovieTrailerExpertBDMV As System.Windows.Forms.TextBox
    Friend WithEvents txtMovieBannerExpertBDMV As System.Windows.Forms.TextBox
    Friend WithEvents txtMovieClearLogoExpertBDMV As System.Windows.Forms.TextBox
    Friend WithEvents txtMovieClearArtExpertBDMV As System.Windows.Forms.TextBox
    Friend WithEvents txtMovieLandscapeExpertBDMV As System.Windows.Forms.TextBox
    Friend WithEvents txtMovieDiscArtExpertBDMV As System.Windows.Forms.TextBox
    Friend WithEvents lblMovieLandscapeExpertBDMV As System.Windows.Forms.Label
    Friend WithEvents lblMovieDiscArtExpertBDMV As System.Windows.Forms.Label
    Friend WithEvents lblMovieBannerExpertBDMV As System.Windows.Forms.Label
    Friend WithEvents lblMovieTrailerExpertBDMV As System.Windows.Forms.Label
    Friend WithEvents lblMovieClearLogoExpertBDMV As System.Windows.Forms.Label
    Friend WithEvents lblMovieFanartExpertBDMV As System.Windows.Forms.Label
    Friend WithEvents lblMoviePosterExpertBDMV As System.Windows.Forms.Label
    Friend WithEvents txtMovieNFOExpertBDMV As System.Windows.Forms.TextBox
    Friend WithEvents lblMovieNFOExpertBDMV As System.Windows.Forms.Label
    Friend WithEvents chkMovieUseBaseDirectoryExpertVTS As System.Windows.Forms.CheckBox
    Friend WithEvents chkMovieUseBaseDirectoryExpertBDMV As System.Windows.Forms.CheckBox
    Friend WithEvents chkMovieRecognizeVTSExpertVTS As System.Windows.Forms.CheckBox
    Friend WithEvents chkMovieXBMCProtectVTSBDMV As System.Windows.Forms.CheckBox
    Friend WithEvents gbMovieNMTOptional As System.Windows.Forms.GroupBox
    Friend WithEvents btnMovieYAMJWatchedFilesBrowse As System.Windows.Forms.Button
    Friend WithEvents txtMovieYAMJWatchedFolder As System.Windows.Forms.TextBox
    Friend WithEvents chkMovieYAMJWatchedFile As System.Windows.Forms.CheckBox
    Friend WithEvents chkMovieScraperOutlinePlotEnglishOverwrite As System.Windows.Forms.CheckBox
    Friend WithEvents gbTVFileNaming As System.Windows.Forms.GroupBox
    Friend WithEvents tcTVFileNaming As System.Windows.Forms.TabControl
    Friend WithEvents tpTVFileNamingXBMC As System.Windows.Forms.TabPage
    Friend WithEvents tpTVFileNamingNMT As System.Windows.Forms.TabPage
    Friend WithEvents tpTVFileNamingExpert As System.Windows.Forms.TabPage
    Friend WithEvents gbTVFrodo As System.Windows.Forms.GroupBox
    Friend WithEvents chkTVSeasonPosterFrodo As System.Windows.Forms.CheckBox
    Friend WithEvents chkTVShowBannerFrodo As System.Windows.Forms.CheckBox
    Friend WithEvents chkTVUseFrodo As System.Windows.Forms.CheckBox
    Friend WithEvents chkTVEpisodeActorThumbsFrodo As System.Windows.Forms.CheckBox
    Friend WithEvents chkTVSeasonBannerFrodo As System.Windows.Forms.CheckBox
    Friend WithEvents chkTVEpisodePosterFrodo As System.Windows.Forms.CheckBox
    Friend WithEvents chkTVShowActorThumbsFrodo As System.Windows.Forms.CheckBox
    Friend WithEvents chkTVSeasonFanartFrodo As System.Windows.Forms.CheckBox
    Friend WithEvents chkTVShowFanartFrodo As System.Windows.Forms.CheckBox
    Friend WithEvents chkTVShowPosterFrodo As System.Windows.Forms.CheckBox
    Friend WithEvents gbTVXBMCAdditional As System.Windows.Forms.GroupBox
    Friend WithEvents chkTVShowTVThemeXBMC As System.Windows.Forms.CheckBox
    Friend WithEvents chkTVSeasonLandscapeXBMC As System.Windows.Forms.CheckBox
    Friend WithEvents chkTVShowLandscapeXBMC As System.Windows.Forms.CheckBox
    Friend WithEvents chkTVShowCharacterArtXBMC As System.Windows.Forms.CheckBox
    Friend WithEvents chkTVShowClearArtXBMC As System.Windows.Forms.CheckBox
    Friend WithEvents chkTVShowClearLogoXBMC As System.Windows.Forms.CheckBox
    Friend WithEvents txtTVShowTVThemeFolderXBMC As System.Windows.Forms.TextBox
    Friend WithEvents btnTVShowTVThemeBrowse As System.Windows.Forms.Button
    Friend WithEvents gbTVShowBannerOpts As System.Windows.Forms.GroupBox
    Friend WithEvents txtTVShowBannerWidth As System.Windows.Forms.TextBox
    Friend WithEvents txtTVShowBannerHeight As System.Windows.Forms.TextBox
    Friend WithEvents lblTVShowBannerQual As System.Windows.Forms.Label
    Friend WithEvents tbTVShowBannerQual As System.Windows.Forms.TrackBar
    Friend WithEvents lblTVShowBannerQ As System.Windows.Forms.Label
    Friend WithEvents lblTVShowBannerWidth As System.Windows.Forms.Label
    Friend WithEvents lblTVShowBannerHeight As System.Windows.Forms.Label
    Friend WithEvents chkTVShowBannerResize As System.Windows.Forms.CheckBox
    Friend WithEvents lblTVShowBannerType As System.Windows.Forms.Label
    Friend WithEvents cbTVShowBannerPrefType As System.Windows.Forms.ComboBox
    Friend WithEvents chkTVShowBannerOverwrite As System.Windows.Forms.CheckBox
    Friend WithEvents gbTVSeasonBannerOpts As System.Windows.Forms.GroupBox
    Friend WithEvents txtTVSeasonBannerWidth As System.Windows.Forms.TextBox
    Friend WithEvents txtTVSeasonBannerHeight As System.Windows.Forms.TextBox
    Friend WithEvents lblTVSeasonBannerQual As System.Windows.Forms.Label
    Friend WithEvents tbTVSeasonBannerQual As System.Windows.Forms.TrackBar
    Friend WithEvents lblTVSeasonBannerQ As System.Windows.Forms.Label
    Friend WithEvents lblTVSeasonBannerWidth As System.Windows.Forms.Label
    Friend WithEvents lblTVSeasonBannerHeight As System.Windows.Forms.Label
    Friend WithEvents chkTVSeasonBannerResize As System.Windows.Forms.CheckBox
    Friend WithEvents lblTVSeasonBannerType As System.Windows.Forms.Label
    Friend WithEvents cbTVSeasonBannerPrefType As System.Windows.Forms.ComboBox
    Friend WithEvents chkTVSeasonBannerOverwrite As System.Windows.Forms.CheckBox
    Friend WithEvents gbTVSeasonLandscapeOpts As System.Windows.Forms.GroupBox
    Friend WithEvents chkTVSeasonLandscapeOverwrite As System.Windows.Forms.CheckBox
    Friend WithEvents tpTVAllSeasons As System.Windows.Forms.TabPage
    Friend WithEvents gbTVASFanartOpts As System.Windows.Forms.GroupBox
    Friend WithEvents txtTVASFanartWidth As System.Windows.Forms.TextBox
    Friend WithEvents txtTVASFanartHeight As System.Windows.Forms.TextBox
    Friend WithEvents lblTVASFanartQual As System.Windows.Forms.Label
    Friend WithEvents tbTVASFanartQual As System.Windows.Forms.TrackBar
    Friend WithEvents lblTVASFanartQ As System.Windows.Forms.Label
    Friend WithEvents lblTVASFanartWidth As System.Windows.Forms.Label
    Friend WithEvents lblTVASFanartHeight As System.Windows.Forms.Label
    Friend WithEvents chkTVASFanartResize As System.Windows.Forms.CheckBox
    Friend WithEvents cbTVASFanartPrefSize As System.Windows.Forms.ComboBox
    Friend WithEvents lblTVASFanartSize As System.Windows.Forms.Label
    Friend WithEvents chkTVASFanartOverwrite As System.Windows.Forms.CheckBox
    Friend WithEvents gbTVASBannerOpts As System.Windows.Forms.GroupBox
    Friend WithEvents txtTVASBannerWidth As System.Windows.Forms.TextBox
    Friend WithEvents txtTVASBannerHeight As System.Windows.Forms.TextBox
    Friend WithEvents lblTVASBannerQual As System.Windows.Forms.Label
    Friend WithEvents tbTVASBannerQual As System.Windows.Forms.TrackBar
    Friend WithEvents lblTVASBannerQ As System.Windows.Forms.Label
    Friend WithEvents lblTVASBannerWidth As System.Windows.Forms.Label
    Friend WithEvents lblTVASBannerHeight As System.Windows.Forms.Label
    Friend WithEvents chkTVASBannerResize As System.Windows.Forms.CheckBox
    Friend WithEvents lblTVASBannerType As System.Windows.Forms.Label
    Friend WithEvents cbTVASBannerPrefType As System.Windows.Forms.ComboBox
    Friend WithEvents chkTVASBannerOverwrite As System.Windows.Forms.CheckBox
    Friend WithEvents gbTVASPosterOpts As System.Windows.Forms.GroupBox
    Friend WithEvents txtTVASPosterWidth As System.Windows.Forms.TextBox
    Friend WithEvents txtTVASPosterHeight As System.Windows.Forms.TextBox
    Friend WithEvents lblTVASPosterQual As System.Windows.Forms.Label
    Friend WithEvents tbTVASPosterQual As System.Windows.Forms.TrackBar
    Friend WithEvents lblTVASPosterQ As System.Windows.Forms.Label
    Friend WithEvents lblTVASPosterWidth As System.Windows.Forms.Label
    Friend WithEvents lblTVASPosterHeight As System.Windows.Forms.Label
    Friend WithEvents chkTVASPosterResize As System.Windows.Forms.CheckBox
    Friend WithEvents lblTVASPosterSize As System.Windows.Forms.Label
    Friend WithEvents cbTVASPosterPrefSize As System.Windows.Forms.ComboBox
    Friend WithEvents chkTVASPosterOverwrite As System.Windows.Forms.CheckBox
    Friend WithEvents gbTVShowLandscapeOpts As System.Windows.Forms.GroupBox
    Friend WithEvents chkTVShowLandscapeOverwrite As System.Windows.Forms.CheckBox
    Friend WithEvents gbTVShowClearArtOpts As System.Windows.Forms.GroupBox
    Friend WithEvents chkTVShowClearArtOverwrite As System.Windows.Forms.CheckBox
    Friend WithEvents gbTVShowClearLogoOpts As System.Windows.Forms.GroupBox
    Friend WithEvents chkTVShowClearLogoOverwrite As System.Windows.Forms.CheckBox
    Friend WithEvents gbTVShowCharacterArtOpts As System.Windows.Forms.GroupBox
    Friend WithEvents chkTVShowCharacterArtOverwrite As System.Windows.Forms.CheckBox
    Friend WithEvents gbMovieBannerOpts As System.Windows.Forms.GroupBox
    Friend WithEvents chkMovieBannerPrefOnly As System.Windows.Forms.CheckBox
    Friend WithEvents txtMovieBannerWidth As System.Windows.Forms.TextBox
    Friend WithEvents txtMovieBannerHeight As System.Windows.Forms.TextBox
    Friend WithEvents lblMovieBannerQual As System.Windows.Forms.Label
    Friend WithEvents tbMovieBannerQual As System.Windows.Forms.TrackBar
    Friend WithEvents lblMovieBannerQ As System.Windows.Forms.Label
    Friend WithEvents lblMovieBannerWidth As System.Windows.Forms.Label
    Friend WithEvents lblMovieBannerHeight As System.Windows.Forms.Label
    Friend WithEvents chkMovieBannerResize As System.Windows.Forms.CheckBox
    Friend WithEvents lblMovieBannerType As System.Windows.Forms.Label
    Friend WithEvents cbMovieBannerPrefType As System.Windows.Forms.ComboBox
    Friend WithEvents chkMovieBannerOverwrite As System.Windows.Forms.CheckBox
    Friend WithEvents gbMovieLandscapeOpts As System.Windows.Forms.GroupBox
    Friend WithEvents chkMovieLandscapeOverwrite As System.Windows.Forms.CheckBox
    Friend WithEvents gbMovieClearArtOpts As System.Windows.Forms.GroupBox
    Friend WithEvents chkMovieClearArtOverwrite As System.Windows.Forms.CheckBox
    Friend WithEvents gbMovieClearLogoOpts As System.Windows.Forms.GroupBox
    Friend WithEvents chkMovieClearLogoOverwrite As System.Windows.Forms.CheckBox
    Friend WithEvents gbMovieDiscArtOpts As System.Windows.Forms.GroupBox
    Friend WithEvents chkMovieDiscArtOverwrite As System.Windows.Forms.CheckBox
    Friend WithEvents gbMovieActorThumbsOpts As System.Windows.Forms.GroupBox
    Friend WithEvents chkMovieActorThumbsOverwrite As System.Windows.Forms.CheckBox
    Friend WithEvents cbMovieTrailerMinQual As System.Windows.Forms.ComboBox
    Friend WithEvents lblMovieTrailerMinQual As System.Windows.Forms.Label
    Friend WithEvents lblTVScraperDurationRuntimeFormat As System.Windows.Forms.Label
    Friend WithEvents lblTVScraperRatingRegion As System.Windows.Forms.Label
    Friend WithEvents cbTVScraperRatingRegion As System.Windows.Forms.ComboBox
    Friend WithEvents txtMovieEFanartsLimit As System.Windows.Forms.TextBox
    Friend WithEvents txtMovieEThumbsLimit As System.Windows.Forms.TextBox
    Friend WithEvents chkMovieYAMJCompatibleSets As System.Windows.Forms.CheckBox
    Friend WithEvents lblMovieEFanartsLimit As System.Windows.Forms.Label
    Friend WithEvents lblMovieEThumbsLimit As System.Windows.Forms.Label
    Friend WithEvents gbTVASLandscapeOpts As System.Windows.Forms.GroupBox
    Friend WithEvents chkTVASLandscapeOverwrite As System.Windows.Forms.CheckBox
    Friend WithEvents gbTVNMT As System.Windows.Forms.GroupBox
    Friend WithEvents chkTVSeasonPosterNMJ As System.Windows.Forms.CheckBox
    Friend WithEvents chkTVShowBannerNMJ As System.Windows.Forms.CheckBox
    Friend WithEvents chkTVSeasonBannerNMJ As System.Windows.Forms.CheckBox
    Friend WithEvents chkTVEpisodePosterNMJ As System.Windows.Forms.CheckBox
    Friend WithEvents chkTVSeasonFanartNMJ As System.Windows.Forms.CheckBox
    Friend WithEvents chkTVShowFanartNMJ As System.Windows.Forms.CheckBox
    Friend WithEvents chkTVShowPosterNMJ As System.Windows.Forms.CheckBox
    Friend WithEvents chkTVUseNMJ As System.Windows.Forms.CheckBox
    Friend WithEvents gbTVYAMJ As System.Windows.Forms.GroupBox
    Friend WithEvents chkTVSeasonPosterYAMJ As System.Windows.Forms.CheckBox
    Friend WithEvents chkTVShowBannerYAMJ As System.Windows.Forms.CheckBox
    Friend WithEvents chkTVSeasonBannerYAMJ As System.Windows.Forms.CheckBox
    Friend WithEvents chkTVEpisodePosterYAMJ As System.Windows.Forms.CheckBox
    Friend WithEvents chkTVSeasonFanartYAMJ As System.Windows.Forms.CheckBox
    Friend WithEvents chkTVShowFanartYAMJ As System.Windows.Forms.CheckBox
    Friend WithEvents chkTVShowPosterYAMJ As System.Windows.Forms.CheckBox
    Friend WithEvents chkTVUseYAMJ As System.Windows.Forms.CheckBox
    Friend WithEvents chkTVLockShowStatus As System.Windows.Forms.CheckBox
    Friend WithEvents chkTVScraperShowStatus As System.Windows.Forms.CheckBox
End Class