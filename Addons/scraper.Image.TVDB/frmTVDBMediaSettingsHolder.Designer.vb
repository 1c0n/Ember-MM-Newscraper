﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTVDBMediaSettingsHolder
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTVDBMediaSettingsHolder))
        Me.pnlSettings = New System.Windows.Forms.Panel()
        Me.pnlSettingsMain = New System.Windows.Forms.Panel()
        Me.tblSettingsMain = New System.Windows.Forms.TableLayoutPanel()
        Me.gbScraperImagesOpts = New System.Windows.Forms.GroupBox()
        Me.tblScraperImagesOpts = New System.Windows.Forms.TableLayoutPanel()
        Me.gbScraperImagesSeason = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.chkScrapeSeasonBanner = New System.Windows.Forms.CheckBox()
        Me.chkScrapeSeasonFanart = New System.Windows.Forms.CheckBox()
        Me.chkScrapeSeasonPoster = New System.Windows.Forms.CheckBox()
        Me.gbScraperImagesTVShow = New System.Windows.Forms.GroupBox()
        Me.tblScraperImagesShow = New System.Windows.Forms.TableLayoutPanel()
        Me.chkScrapeShowFanart = New System.Windows.Forms.CheckBox()
        Me.chkScrapeShowBanner = New System.Windows.Forms.CheckBox()
        Me.chkScrapeShowPoster = New System.Windows.Forms.CheckBox()
        Me.gbScraperOpts = New System.Windows.Forms.GroupBox()
        Me.tblScraperOpts = New System.Windows.Forms.TableLayoutPanel()
        Me.lblAPIKey = New System.Windows.Forms.Label()
        Me.pbApiKeyInfo = New System.Windows.Forms.PictureBox()
        Me.txtApiKey = New System.Windows.Forms.TextBox()
        Me.btnUnlockAPI = New System.Windows.Forms.Button()
        Me.lblEMMAPI = New System.Windows.Forms.Label()
        Me.chkGetBlankImages = New System.Windows.Forms.CheckBox()
        Me.chkGetEnglishImages = New System.Windows.Forms.CheckBox()
        Me.chkPrefLanguageOnly = New System.Windows.Forms.CheckBox()
        Me.cbPrefLanguage = New System.Windows.Forms.ComboBox()
        Me.lblPrefLanguage = New System.Windows.Forms.Label()
        Me.pnlSettingsBottom = New System.Windows.Forms.Panel()
        Me.tblSettingsBottom = New System.Windows.Forms.TableLayoutPanel()
        Me.pbIconBottom = New System.Windows.Forms.PictureBox()
        Me.lblInfoBottom = New System.Windows.Forms.Label()
        Me.pnlSettingsTop = New System.Windows.Forms.Panel()
        Me.tblSettingsTop = New System.Windows.Forms.TableLayoutPanel()
        Me.btnDown = New System.Windows.Forms.Button()
        Me.lblScraperOrder = New System.Windows.Forms.Label()
        Me.btnUp = New System.Windows.Forms.Button()
        Me.chkEnabled = New System.Windows.Forms.CheckBox()
        Me.pnlSettings.SuspendLayout()
        Me.pnlSettingsMain.SuspendLayout()
        Me.tblSettingsMain.SuspendLayout()
        Me.gbScraperImagesOpts.SuspendLayout()
        Me.tblScraperImagesOpts.SuspendLayout()
        Me.gbScraperImagesSeason.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.gbScraperImagesTVShow.SuspendLayout()
        Me.tblScraperImagesShow.SuspendLayout()
        Me.gbScraperOpts.SuspendLayout()
        Me.tblScraperOpts.SuspendLayout()
        CType(Me.pbApiKeyInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlSettingsBottom.SuspendLayout()
        Me.tblSettingsBottom.SuspendLayout()
        CType(Me.pbIconBottom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlSettingsTop.SuspendLayout()
        Me.tblSettingsTop.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlSettings
        '
        Me.pnlSettings.AutoSize = True
        Me.pnlSettings.Controls.Add(Me.pnlSettingsMain)
        Me.pnlSettings.Controls.Add(Me.pnlSettingsBottom)
        Me.pnlSettings.Controls.Add(Me.pnlSettingsTop)
        Me.pnlSettings.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlSettings.Location = New System.Drawing.Point(0, 0)
        Me.pnlSettings.Name = "pnlSettings"
        Me.pnlSettings.Size = New System.Drawing.Size(453, 359)
        Me.pnlSettings.TabIndex = 0
        '
        'pnlSettingsMain
        '
        Me.pnlSettingsMain.AutoSize = True
        Me.pnlSettingsMain.Controls.Add(Me.tblSettingsMain)
        Me.pnlSettingsMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlSettingsMain.Location = New System.Drawing.Point(0, 29)
        Me.pnlSettingsMain.Name = "pnlSettingsMain"
        Me.pnlSettingsMain.Size = New System.Drawing.Size(453, 293)
        Me.pnlSettingsMain.TabIndex = 98
        '
        'tblSettingsMain
        '
        Me.tblSettingsMain.AutoScroll = True
        Me.tblSettingsMain.AutoSize = True
        Me.tblSettingsMain.ColumnCount = 2
        Me.tblSettingsMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tblSettingsMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tblSettingsMain.Controls.Add(Me.gbScraperImagesOpts, 0, 0)
        Me.tblSettingsMain.Controls.Add(Me.gbScraperOpts, 0, 1)
        Me.tblSettingsMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblSettingsMain.Location = New System.Drawing.Point(0, 0)
        Me.tblSettingsMain.Name = "tblSettingsMain"
        Me.tblSettingsMain.RowCount = 3
        Me.tblSettingsMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblSettingsMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblSettingsMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblSettingsMain.Size = New System.Drawing.Size(453, 293)
        Me.tblSettingsMain.TabIndex = 0
        '
        'gbScraperImagesOpts
        '
        Me.gbScraperImagesOpts.AutoSize = True
        Me.gbScraperImagesOpts.Controls.Add(Me.tblScraperImagesOpts)
        Me.gbScraperImagesOpts.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbScraperImagesOpts.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbScraperImagesOpts.Location = New System.Drawing.Point(3, 3)
        Me.gbScraperImagesOpts.Name = "gbScraperImagesOpts"
        Me.gbScraperImagesOpts.Size = New System.Drawing.Size(432, 117)
        Me.gbScraperImagesOpts.TabIndex = 96
        Me.gbScraperImagesOpts.TabStop = False
        Me.gbScraperImagesOpts.Text = "Images - Scraper specific"
        '
        'tblScraperImagesOpts
        '
        Me.tblScraperImagesOpts.AutoSize = True
        Me.tblScraperImagesOpts.ColumnCount = 3
        Me.tblScraperImagesOpts.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tblScraperImagesOpts.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tblScraperImagesOpts.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tblScraperImagesOpts.Controls.Add(Me.gbScraperImagesSeason, 1, 0)
        Me.tblScraperImagesOpts.Controls.Add(Me.gbScraperImagesTVShow, 0, 0)
        Me.tblScraperImagesOpts.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblScraperImagesOpts.Location = New System.Drawing.Point(3, 18)
        Me.tblScraperImagesOpts.Name = "tblScraperImagesOpts"
        Me.tblScraperImagesOpts.RowCount = 2
        Me.tblScraperImagesOpts.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblScraperImagesOpts.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblScraperImagesOpts.Size = New System.Drawing.Size(426, 96)
        Me.tblScraperImagesOpts.TabIndex = 11
        '
        'gbScraperImagesSeason
        '
        Me.gbScraperImagesSeason.AutoSize = True
        Me.gbScraperImagesSeason.Controls.Add(Me.TableLayoutPanel1)
        Me.gbScraperImagesSeason.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbScraperImagesSeason.Location = New System.Drawing.Point(105, 3)
        Me.gbScraperImagesSeason.Name = "gbScraperImagesSeason"
        Me.gbScraperImagesSeason.Size = New System.Drawing.Size(96, 90)
        Me.gbScraperImagesSeason.TabIndex = 11
        Me.gbScraperImagesSeason.TabStop = False
        Me.gbScraperImagesSeason.Text = "Season"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.chkScrapeSeasonBanner, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.chkScrapeSeasonFanart, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.chkScrapeSeasonPoster, 0, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 18)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(90, 69)
        Me.TableLayoutPanel1.TabIndex = 98
        '
        'chkScrapeSeasonBanner
        '
        Me.chkScrapeSeasonBanner.AutoSize = True
        Me.chkScrapeSeasonBanner.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkScrapeSeasonBanner.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkScrapeSeasonBanner.Location = New System.Drawing.Point(3, 3)
        Me.chkScrapeSeasonBanner.Name = "chkScrapeSeasonBanner"
        Me.chkScrapeSeasonBanner.Size = New System.Drawing.Size(84, 17)
        Me.chkScrapeSeasonBanner.TabIndex = 2
        Me.chkScrapeSeasonBanner.Text = "Get Banner"
        Me.chkScrapeSeasonBanner.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkScrapeSeasonBanner.UseVisualStyleBackColor = True
        '
        'chkScrapeSeasonFanart
        '
        Me.chkScrapeSeasonFanart.AutoSize = True
        Me.chkScrapeSeasonFanart.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkScrapeSeasonFanart.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkScrapeSeasonFanart.Location = New System.Drawing.Point(3, 26)
        Me.chkScrapeSeasonFanart.Name = "chkScrapeSeasonFanart"
        Me.chkScrapeSeasonFanart.Size = New System.Drawing.Size(80, 17)
        Me.chkScrapeSeasonFanart.TabIndex = 1
        Me.chkScrapeSeasonFanart.Text = "Get Fanart"
        Me.chkScrapeSeasonFanart.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkScrapeSeasonFanart.UseVisualStyleBackColor = True
        '
        'chkScrapeSeasonPoster
        '
        Me.chkScrapeSeasonPoster.AutoSize = True
        Me.chkScrapeSeasonPoster.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkScrapeSeasonPoster.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkScrapeSeasonPoster.Location = New System.Drawing.Point(3, 49)
        Me.chkScrapeSeasonPoster.Name = "chkScrapeSeasonPoster"
        Me.chkScrapeSeasonPoster.Size = New System.Drawing.Size(79, 17)
        Me.chkScrapeSeasonPoster.TabIndex = 0
        Me.chkScrapeSeasonPoster.Text = "Get Poster"
        Me.chkScrapeSeasonPoster.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkScrapeSeasonPoster.UseVisualStyleBackColor = True
        '
        'gbScraperImagesTVShow
        '
        Me.gbScraperImagesTVShow.AutoSize = True
        Me.gbScraperImagesTVShow.Controls.Add(Me.tblScraperImagesShow)
        Me.gbScraperImagesTVShow.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbScraperImagesTVShow.Location = New System.Drawing.Point(3, 3)
        Me.gbScraperImagesTVShow.Name = "gbScraperImagesTVShow"
        Me.gbScraperImagesTVShow.Size = New System.Drawing.Size(96, 90)
        Me.gbScraperImagesTVShow.TabIndex = 10
        Me.gbScraperImagesTVShow.TabStop = False
        Me.gbScraperImagesTVShow.Text = "TV Show"
        '
        'tblScraperImagesShow
        '
        Me.tblScraperImagesShow.AutoSize = True
        Me.tblScraperImagesShow.ColumnCount = 3
        Me.tblScraperImagesShow.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tblScraperImagesShow.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tblScraperImagesShow.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tblScraperImagesShow.Controls.Add(Me.chkScrapeShowBanner, 0, 0)
        Me.tblScraperImagesShow.Controls.Add(Me.chkScrapeShowFanart, 0, 1)
        Me.tblScraperImagesShow.Controls.Add(Me.chkScrapeShowPoster, 0, 2)
        Me.tblScraperImagesShow.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblScraperImagesShow.Location = New System.Drawing.Point(3, 18)
        Me.tblScraperImagesShow.Name = "tblScraperImagesShow"
        Me.tblScraperImagesShow.RowCount = 4
        Me.tblScraperImagesShow.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblScraperImagesShow.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblScraperImagesShow.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblScraperImagesShow.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblScraperImagesShow.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblScraperImagesShow.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblScraperImagesShow.Size = New System.Drawing.Size(90, 69)
        Me.tblScraperImagesShow.TabIndex = 98
        '
        'chkScrapeShowFanart
        '
        Me.chkScrapeShowFanart.AutoSize = True
        Me.chkScrapeShowFanart.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkScrapeShowFanart.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkScrapeShowFanart.Location = New System.Drawing.Point(3, 26)
        Me.chkScrapeShowFanart.Name = "chkScrapeShowFanart"
        Me.chkScrapeShowFanart.Size = New System.Drawing.Size(80, 17)
        Me.chkScrapeShowFanart.TabIndex = 1
        Me.chkScrapeShowFanart.Text = "Get Fanart"
        Me.chkScrapeShowFanart.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkScrapeShowFanart.UseVisualStyleBackColor = True
        '
        'chkScrapeShowBanner
        '
        Me.chkScrapeShowBanner.AutoSize = True
        Me.chkScrapeShowBanner.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkScrapeShowBanner.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkScrapeShowBanner.Location = New System.Drawing.Point(3, 3)
        Me.chkScrapeShowBanner.Name = "chkScrapeShowBanner"
        Me.chkScrapeShowBanner.Size = New System.Drawing.Size(84, 17)
        Me.chkScrapeShowBanner.TabIndex = 2
        Me.chkScrapeShowBanner.Text = "Get Banner"
        Me.chkScrapeShowBanner.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkScrapeShowBanner.UseVisualStyleBackColor = True
        '
        'chkScrapeShowPoster
        '
        Me.chkScrapeShowPoster.AutoSize = True
        Me.chkScrapeShowPoster.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkScrapeShowPoster.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkScrapeShowPoster.Location = New System.Drawing.Point(3, 49)
        Me.chkScrapeShowPoster.Name = "chkScrapeShowPoster"
        Me.chkScrapeShowPoster.Size = New System.Drawing.Size(79, 17)
        Me.chkScrapeShowPoster.TabIndex = 0
        Me.chkScrapeShowPoster.Text = "Get Poster"
        Me.chkScrapeShowPoster.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkScrapeShowPoster.UseVisualStyleBackColor = True
        '
        'gbScraperOpts
        '
        Me.gbScraperOpts.AutoSize = True
        Me.gbScraperOpts.Controls.Add(Me.tblScraperOpts)
        Me.gbScraperOpts.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbScraperOpts.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.gbScraperOpts.Location = New System.Drawing.Point(3, 126)
        Me.gbScraperOpts.Name = "gbScraperOpts"
        Me.gbScraperOpts.Size = New System.Drawing.Size(432, 143)
        Me.gbScraperOpts.TabIndex = 95
        Me.gbScraperOpts.TabStop = False
        Me.gbScraperOpts.Text = "Scraper Options"
        '
        'tblScraperOpts
        '
        Me.tblScraperOpts.AutoSize = True
        Me.tblScraperOpts.ColumnCount = 5
        Me.tblScraperOpts.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tblScraperOpts.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tblScraperOpts.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tblScraperOpts.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tblScraperOpts.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tblScraperOpts.Controls.Add(Me.lblAPIKey, 0, 0)
        Me.tblScraperOpts.Controls.Add(Me.pbApiKeyInfo, 3, 1)
        Me.tblScraperOpts.Controls.Add(Me.txtApiKey, 2, 1)
        Me.tblScraperOpts.Controls.Add(Me.btnUnlockAPI, 0, 1)
        Me.tblScraperOpts.Controls.Add(Me.lblEMMAPI, 2, 0)
        Me.tblScraperOpts.Controls.Add(Me.chkGetBlankImages, 2, 4)
        Me.tblScraperOpts.Controls.Add(Me.chkGetEnglishImages, 2, 3)
        Me.tblScraperOpts.Controls.Add(Me.chkPrefLanguageOnly, 2, 2)
        Me.tblScraperOpts.Controls.Add(Me.cbPrefLanguage, 1, 2)
        Me.tblScraperOpts.Controls.Add(Me.lblPrefLanguage, 0, 2)
        Me.tblScraperOpts.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblScraperOpts.Location = New System.Drawing.Point(3, 18)
        Me.tblScraperOpts.Name = "tblScraperOpts"
        Me.tblScraperOpts.RowCount = 6
        Me.tblScraperOpts.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblScraperOpts.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblScraperOpts.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblScraperOpts.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblScraperOpts.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblScraperOpts.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblScraperOpts.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblScraperOpts.Size = New System.Drawing.Size(426, 122)
        Me.tblScraperOpts.TabIndex = 98
        '
        'lblAPIKey
        '
        Me.lblAPIKey.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblAPIKey.AutoSize = True
        Me.tblScraperOpts.SetColumnSpan(Me.lblAPIKey, 2)
        Me.lblAPIKey.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAPIKey.Location = New System.Drawing.Point(3, 3)
        Me.lblAPIKey.Name = "lblAPIKey"
        Me.lblAPIKey.Size = New System.Drawing.Size(76, 13)
        Me.lblAPIKey.TabIndex = 0
        Me.lblAPIKey.Text = "TVDB API Key:"
        '
        'pbApiKeyInfo
        '
        Me.pbApiKeyInfo.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.pbApiKeyInfo.Image = CType(resources.GetObject("pbApiKeyInfo.Image"), System.Drawing.Image)
        Me.pbApiKeyInfo.Location = New System.Drawing.Point(407, 26)
        Me.pbApiKeyInfo.Name = "pbApiKeyInfo"
        Me.pbApiKeyInfo.Size = New System.Drawing.Size(16, 16)
        Me.pbApiKeyInfo.TabIndex = 6
        Me.pbApiKeyInfo.TabStop = False
        '
        'txtApiKey
        '
        Me.txtApiKey.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtApiKey.Enabled = False
        Me.txtApiKey.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApiKey.Location = New System.Drawing.Point(171, 23)
        Me.txtApiKey.Name = "txtApiKey"
        Me.txtApiKey.Size = New System.Drawing.Size(230, 22)
        Me.txtApiKey.TabIndex = 1
        '
        'btnUnlockAPI
        '
        Me.btnUnlockAPI.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.tblScraperOpts.SetColumnSpan(Me.btnUnlockAPI, 2)
        Me.btnUnlockAPI.Location = New System.Drawing.Point(3, 23)
        Me.btnUnlockAPI.Name = "btnUnlockAPI"
        Me.btnUnlockAPI.Size = New System.Drawing.Size(162, 23)
        Me.btnUnlockAPI.TabIndex = 11
        Me.btnUnlockAPI.Text = "Use my own API key"
        Me.btnUnlockAPI.UseVisualStyleBackColor = True
        '
        'lblEMMAPI
        '
        Me.lblEMMAPI.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblEMMAPI.AutoSize = True
        Me.tblScraperOpts.SetColumnSpan(Me.lblEMMAPI, 2)
        Me.lblEMMAPI.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.lblEMMAPI.Location = New System.Drawing.Point(171, 3)
        Me.lblEMMAPI.Name = "lblEMMAPI"
        Me.lblEMMAPI.Size = New System.Drawing.Size(220, 13)
        Me.lblEMMAPI.TabIndex = 12
        Me.lblEMMAPI.Text = "Ember Media Manager Embedded API Key"
        '
        'chkGetBlankImages
        '
        Me.chkGetBlankImages.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.chkGetBlankImages.AutoSize = True
        Me.tblScraperOpts.SetColumnSpan(Me.chkGetBlankImages, 2)
        Me.chkGetBlankImages.Enabled = False
        Me.chkGetBlankImages.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkGetBlankImages.Location = New System.Drawing.Point(171, 102)
        Me.chkGetBlankImages.Name = "chkGetBlankImages"
        Me.chkGetBlankImages.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.chkGetBlankImages.Size = New System.Drawing.Size(160, 17)
        Me.chkGetBlankImages.TabIndex = 19
        Me.chkGetBlankImages.Text = "Also Get Blank Images"
        Me.chkGetBlankImages.UseVisualStyleBackColor = True
        '
        'chkGetEnglishImages
        '
        Me.chkGetEnglishImages.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.chkGetEnglishImages.AutoSize = True
        Me.tblScraperOpts.SetColumnSpan(Me.chkGetEnglishImages, 2)
        Me.chkGetEnglishImages.Enabled = False
        Me.chkGetEnglishImages.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkGetEnglishImages.Location = New System.Drawing.Point(171, 79)
        Me.chkGetEnglishImages.Name = "chkGetEnglishImages"
        Me.chkGetEnglishImages.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.chkGetEnglishImages.Size = New System.Drawing.Size(169, 17)
        Me.chkGetEnglishImages.TabIndex = 17
        Me.chkGetEnglishImages.Text = "Also Get English Images"
        Me.chkGetEnglishImages.UseVisualStyleBackColor = True
        '
        'chkPrefLanguageOnly
        '
        Me.chkPrefLanguageOnly.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.chkPrefLanguageOnly.AutoSize = True
        Me.tblScraperOpts.SetColumnSpan(Me.chkPrefLanguageOnly, 2)
        Me.chkPrefLanguageOnly.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPrefLanguageOnly.Location = New System.Drawing.Point(171, 54)
        Me.chkPrefLanguageOnly.Name = "chkPrefLanguageOnly"
        Me.chkPrefLanguageOnly.Size = New System.Drawing.Size(248, 17)
        Me.chkPrefLanguageOnly.TabIndex = 18
        Me.chkPrefLanguageOnly.Text = "Only Get Images for the Selected Language"
        Me.chkPrefLanguageOnly.UseVisualStyleBackColor = True
        '
        'cbPrefLanguage
        '
        Me.cbPrefLanguage.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cbPrefLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPrefLanguage.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.cbPrefLanguage.FormattingEnabled = True
        Me.cbPrefLanguage.Items.AddRange(New Object() {"bg", "cs", "da", "de", "el", "en", "es", "fi", "fr", "he", "hu", "it", "nb", "nl", "no", "pl", "pt", "ru", "sk", "sv", "ta", "tr", "uk", "vi", "xx", "zh"})
        Me.cbPrefLanguage.Location = New System.Drawing.Point(120, 52)
        Me.cbPrefLanguage.Name = "cbPrefLanguage"
        Me.cbPrefLanguage.Size = New System.Drawing.Size(45, 21)
        Me.cbPrefLanguage.TabIndex = 8
        '
        'lblPrefLanguage
        '
        Me.lblPrefLanguage.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblPrefLanguage.AutoSize = True
        Me.lblPrefLanguage.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.lblPrefLanguage.Location = New System.Drawing.Point(3, 56)
        Me.lblPrefLanguage.Name = "lblPrefLanguage"
        Me.lblPrefLanguage.Size = New System.Drawing.Size(111, 13)
        Me.lblPrefLanguage.TabIndex = 7
        Me.lblPrefLanguage.Text = "Preferred Language:"
        '
        'pnlSettingsBottom
        '
        Me.pnlSettingsBottom.AutoSize = True
        Me.pnlSettingsBottom.Controls.Add(Me.tblSettingsBottom)
        Me.pnlSettingsBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlSettingsBottom.Location = New System.Drawing.Point(0, 322)
        Me.pnlSettingsBottom.Name = "pnlSettingsBottom"
        Me.pnlSettingsBottom.Size = New System.Drawing.Size(453, 37)
        Me.pnlSettingsBottom.TabIndex = 97
        '
        'tblSettingsBottom
        '
        Me.tblSettingsBottom.AutoSize = True
        Me.tblSettingsBottom.ColumnCount = 3
        Me.tblSettingsBottom.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tblSettingsBottom.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tblSettingsBottom.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tblSettingsBottom.Controls.Add(Me.pbIconBottom, 0, 0)
        Me.tblSettingsBottom.Controls.Add(Me.lblInfoBottom, 1, 0)
        Me.tblSettingsBottom.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblSettingsBottom.Location = New System.Drawing.Point(0, 0)
        Me.tblSettingsBottom.Name = "tblSettingsBottom"
        Me.tblSettingsBottom.RowCount = 2
        Me.tblSettingsBottom.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblSettingsBottom.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblSettingsBottom.Size = New System.Drawing.Size(453, 37)
        Me.tblSettingsBottom.TabIndex = 98
        '
        'pbIconBottom
        '
        Me.pbIconBottom.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pbIconBottom.Image = CType(resources.GetObject("pbIconBottom.Image"), System.Drawing.Image)
        Me.pbIconBottom.Location = New System.Drawing.Point(3, 3)
        Me.pbIconBottom.Name = "pbIconBottom"
        Me.pbIconBottom.Size = New System.Drawing.Size(30, 31)
        Me.pbIconBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbIconBottom.TabIndex = 94
        Me.pbIconBottom.TabStop = False
        '
        'lblInfoBottom
        '
        Me.lblInfoBottom.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblInfoBottom.AutoSize = True
        Me.lblInfoBottom.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblInfoBottom.ForeColor = System.Drawing.Color.Blue
        Me.lblInfoBottom.Location = New System.Drawing.Point(39, 6)
        Me.lblInfoBottom.Name = "lblInfoBottom"
        Me.lblInfoBottom.Size = New System.Drawing.Size(205, 24)
        Me.lblInfoBottom.TabIndex = 3
        Me.lblInfoBottom.Text = "These settings are specific to this module." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Please refer to the global settings " & _
    "for more options."
        Me.lblInfoBottom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnlSettingsTop
        '
        Me.pnlSettingsTop.AutoSize = True
        Me.pnlSettingsTop.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnlSettingsTop.Controls.Add(Me.tblSettingsTop)
        Me.pnlSettingsTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlSettingsTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlSettingsTop.Name = "pnlSettingsTop"
        Me.pnlSettingsTop.Size = New System.Drawing.Size(453, 29)
        Me.pnlSettingsTop.TabIndex = 0
        '
        'tblSettingsTop
        '
        Me.tblSettingsTop.AutoSize = True
        Me.tblSettingsTop.ColumnCount = 5
        Me.tblSettingsTop.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tblSettingsTop.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblSettingsTop.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tblSettingsTop.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tblSettingsTop.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tblSettingsTop.Controls.Add(Me.btnDown, 4, 0)
        Me.tblSettingsTop.Controls.Add(Me.lblScraperOrder, 2, 0)
        Me.tblSettingsTop.Controls.Add(Me.btnUp, 3, 0)
        Me.tblSettingsTop.Controls.Add(Me.chkEnabled, 0, 0)
        Me.tblSettingsTop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblSettingsTop.Location = New System.Drawing.Point(0, 0)
        Me.tblSettingsTop.Name = "tblSettingsTop"
        Me.tblSettingsTop.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.tblSettingsTop.RowCount = 2
        Me.tblSettingsTop.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblSettingsTop.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblSettingsTop.Size = New System.Drawing.Size(453, 29)
        Me.tblSettingsTop.TabIndex = 99
        '
        'btnDown
        '
        Me.btnDown.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnDown.Image = CType(resources.GetObject("btnDown.Image"), System.Drawing.Image)
        Me.btnDown.Location = New System.Drawing.Point(427, 3)
        Me.btnDown.Name = "btnDown"
        Me.btnDown.Size = New System.Drawing.Size(23, 23)
        Me.btnDown.TabIndex = 3
        Me.btnDown.UseVisualStyleBackColor = True
        '
        'lblScraperOrder
        '
        Me.lblScraperOrder.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblScraperOrder.AutoSize = True
        Me.lblScraperOrder.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScraperOrder.Location = New System.Drawing.Point(334, 8)
        Me.lblScraperOrder.Name = "lblScraperOrder"
        Me.lblScraperOrder.Size = New System.Drawing.Size(58, 12)
        Me.lblScraperOrder.TabIndex = 1
        Me.lblScraperOrder.Text = "Scraper order"
        '
        'btnUp
        '
        Me.btnUp.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnUp.Image = CType(resources.GetObject("btnUp.Image"), System.Drawing.Image)
        Me.btnUp.Location = New System.Drawing.Point(398, 3)
        Me.btnUp.Name = "btnUp"
        Me.btnUp.Size = New System.Drawing.Size(23, 23)
        Me.btnUp.TabIndex = 2
        Me.btnUp.UseVisualStyleBackColor = True
        '
        'chkEnabled
        '
        Me.chkEnabled.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.chkEnabled.AutoSize = True
        Me.chkEnabled.Location = New System.Drawing.Point(8, 6)
        Me.chkEnabled.Name = "chkEnabled"
        Me.chkEnabled.Size = New System.Drawing.Size(68, 17)
        Me.chkEnabled.TabIndex = 0
        Me.chkEnabled.Text = "Enabled"
        Me.chkEnabled.UseVisualStyleBackColor = True
        '
        'frmTVDBMediaSettingsHolder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(453, 359)
        Me.Controls.Add(Me.pnlSettings)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmTVDBMediaSettingsHolder"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Scraper Setup"
        Me.pnlSettings.ResumeLayout(False)
        Me.pnlSettings.PerformLayout()
        Me.pnlSettingsMain.ResumeLayout(False)
        Me.pnlSettingsMain.PerformLayout()
        Me.tblSettingsMain.ResumeLayout(False)
        Me.tblSettingsMain.PerformLayout()
        Me.gbScraperImagesOpts.ResumeLayout(False)
        Me.gbScraperImagesOpts.PerformLayout()
        Me.tblScraperImagesOpts.ResumeLayout(False)
        Me.tblScraperImagesOpts.PerformLayout()
        Me.gbScraperImagesSeason.ResumeLayout(False)
        Me.gbScraperImagesSeason.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.gbScraperImagesTVShow.ResumeLayout(False)
        Me.gbScraperImagesTVShow.PerformLayout()
        Me.tblScraperImagesShow.ResumeLayout(False)
        Me.tblScraperImagesShow.PerformLayout()
        Me.gbScraperOpts.ResumeLayout(False)
        Me.gbScraperOpts.PerformLayout()
        Me.tblScraperOpts.ResumeLayout(False)
        Me.tblScraperOpts.PerformLayout()
        CType(Me.pbApiKeyInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlSettingsBottom.ResumeLayout(False)
        Me.pnlSettingsBottom.PerformLayout()
        Me.tblSettingsBottom.ResumeLayout(False)
        Me.tblSettingsBottom.PerformLayout()
        CType(Me.pbIconBottom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlSettingsTop.ResumeLayout(False)
        Me.pnlSettingsTop.PerformLayout()
        Me.tblSettingsTop.ResumeLayout(False)
        Me.tblSettingsTop.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnlSettings As System.Windows.Forms.Panel
    Friend WithEvents pnlSettingsTop As System.Windows.Forms.Panel
    Friend WithEvents chkEnabled As System.Windows.Forms.CheckBox
    Friend WithEvents lblScraperOrder As System.Windows.Forms.Label
    Friend WithEvents btnDown As System.Windows.Forms.Button
    Friend WithEvents btnUp As System.Windows.Forms.Button
    Friend WithEvents lblInfoBottom As System.Windows.Forms.Label
    Friend WithEvents pbIconBottom As System.Windows.Forms.PictureBox
    Friend WithEvents gbScraperOpts As System.Windows.Forms.GroupBox
    Friend WithEvents pbApiKeyInfo As System.Windows.Forms.PictureBox
    Friend WithEvents lblAPIKey As System.Windows.Forms.Label
    Friend WithEvents txtApiKey As System.Windows.Forms.TextBox
    Friend WithEvents gbScraperImagesOpts As System.Windows.Forms.GroupBox
    Friend WithEvents chkScrapeShowPoster As System.Windows.Forms.CheckBox
    Friend WithEvents chkScrapeShowFanart As System.Windows.Forms.CheckBox
    Friend WithEvents cbPrefLanguage As System.Windows.Forms.ComboBox
    Friend WithEvents lblPrefLanguage As System.Windows.Forms.Label
    Friend WithEvents chkScrapeShowBanner As System.Windows.Forms.CheckBox
    Friend WithEvents chkGetBlankImages As System.Windows.Forms.CheckBox
    Friend WithEvents chkPrefLanguageOnly As System.Windows.Forms.CheckBox
    Friend WithEvents chkGetEnglishImages As System.Windows.Forms.CheckBox
    Friend WithEvents tblSettingsBottom As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents pnlSettingsBottom As System.Windows.Forms.Panel
    Friend WithEvents tblScraperImagesShow As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblEMMAPI As System.Windows.Forms.Label
    Friend WithEvents btnUnlockAPI As System.Windows.Forms.Button
    Friend WithEvents tblScraperOpts As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents pnlSettingsMain As System.Windows.Forms.Panel
    Friend WithEvents tblSettingsMain As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents tblSettingsTop As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents tblScraperImagesOpts As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents gbScraperImagesTVShow As System.Windows.Forms.GroupBox
    Friend WithEvents gbScraperImagesSeason As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents chkScrapeSeasonFanart As System.Windows.Forms.CheckBox
    Friend WithEvents chkScrapeSeasonBanner As System.Windows.Forms.CheckBox
    Friend WithEvents chkScrapeSeasonPoster As System.Windows.Forms.CheckBox

End Class