﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgTrakttvManager
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgTrakttvManager))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.lblTopDetails = New System.Windows.Forms.Label()
        Me.lblTopTitle = New System.Windows.Forms.Label()
        Me.pnlCancel = New System.Windows.Forms.Panel()
        Me.pnlSaving = New System.Windows.Forms.Panel()
        Me.lblSaving = New System.Windows.Forms.Label()
        Me.prbSaving = New System.Windows.Forms.ProgressBar()
        Me.prbCompile = New System.Windows.Forms.ProgressBar()
        Me.lblCompiling = New System.Windows.Forms.Label()
        Me.lblFile = New System.Windows.Forms.Label()
        Me.lblCanceling = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.pbTopLogo = New System.Windows.Forms.PictureBox()
        Me.pnlTrakt = New System.Windows.Forms.Panel()
        Me.tbTrakt = New System.Windows.Forms.TabControl()
        Me.tbptraktPlaycount = New System.Windows.Forms.TabPage()
        Me.pnltraktPlaycount = New System.Windows.Forms.Panel()
        Me.gbtraktPlaycount = New System.Windows.Forms.GroupBox()
        Me.btntraktPlaycountGetMovies = New System.Windows.Forms.Button()
        Me.dgvtraktPlaycount = New System.Windows.Forms.DataGridView()
        Me.coltraktPlaycountTitle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coltraktPlaycountPlayed = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lbltraktPlaycountstate = New System.Windows.Forms.Label()
        Me.prgtraktPlaycount = New System.Windows.Forms.ProgressBar()
        Me.lbltraktPlaycounthelp = New System.Windows.Forms.Label()
        Me.btntraktPlaycountSyncLibrary = New System.Windows.Forms.Button()
        Me.btntraktPlaycountGetSeries = New System.Windows.Forms.Button()
        Me.tbptraktListsSync = New System.Windows.Forms.TabPage()
        Me.pnltraktLists = New System.Windows.Forms.Panel()
        Me.gbtraktListsSYNC = New System.Windows.Forms.GroupBox()
        Me.btntraktListsSyncLibrary = New System.Windows.Forms.Button()
        Me.btntraktListsSyncTrakt = New System.Windows.Forms.Button()
        Me.gbtraktListsGET = New System.Windows.Forms.GroupBox()
        Me.btntraktListsGetPersonal = New System.Windows.Forms.Button()
        Me.lbltraktListsstate = New System.Windows.Forms.Label()
        Me.gbtraktLists = New System.Windows.Forms.GroupBox()
        Me.gbtraktListsDetails = New System.Windows.Forms.GroupBox()
        Me.btntraktListsDetailsUpdate = New System.Windows.Forms.Button()
        Me.chktraktListsDetailsNumbers = New System.Windows.Forms.CheckBox()
        Me.chkltraktListsDetailsComments = New System.Windows.Forms.CheckBox()
        Me.lbltraktListsDetailsDescription = New System.Windows.Forms.Label()
        Me.lbltraktListsDetailsName = New System.Windows.Forms.Label()
        Me.lbltraktListsDetailsPrivacy = New System.Windows.Forms.Label()
        Me.cbotraktListsDetailsPrivacy = New System.Windows.Forms.ComboBox()
        Me.txttraktListsDetailsName = New System.Windows.Forms.TextBox()
        Me.txttraktListsDetailsDescription = New System.Windows.Forms.TextBox()
        Me.btntraktListsGetDatabase = New System.Windows.Forms.Button()
        Me.lbDBLists = New System.Windows.Forms.ListBox()
        Me.txttraktListsEditList = New System.Windows.Forms.TextBox()
        Me.btntraktListsRemoveList = New System.Windows.Forms.Button()
        Me.btntraktListsEditList = New System.Windows.Forms.Button()
        Me.btntraktListsNewList = New System.Windows.Forms.Button()
        Me.lbtraktLists = New System.Windows.Forms.ListBox()
        Me.prgtraktLists = New System.Windows.Forms.ProgressBar()
        Me.gbtraktListsMovies = New System.Windows.Forms.GroupBox()
        Me.dgvMovies = New System.Windows.Forms.DataGridView()
        Me.btntraktListsAddMovie = New System.Windows.Forms.Button()
        Me.gbtraktListsMoviesInLists = New System.Windows.Forms.GroupBox()
        Me.lbltraktListsCurrentList = New System.Windows.Forms.Label()
        Me.btntraktListsRemove = New System.Windows.Forms.Button()
        Me.lbtraktListsMoviesinLists = New System.Windows.Forms.ListBox()
        Me.tbptraktListViewer = New System.Windows.Forms.TabPage()
        Me.pnltraktListsComparer = New System.Windows.Forms.Panel()
        Me.gbtraktListsViewer = New System.Windows.Forms.GroupBox()
        Me.lbltraktListsdescription = New System.Windows.Forms.Label()
        Me.lbltraktListsdescriptionloaded = New System.Windows.Forms.Label()
        Me.btntraktListsfetch = New System.Windows.Forms.Button()
        Me.cbotraktListsfetch = New System.Windows.Forms.ComboBox()
        Me.lbltraktListsCount = New System.Windows.Forms.Label()
        Me.chktraktListsCompare = New System.Windows.Forms.CheckBox()
        Me.lbltraktListsurlhelp = New System.Windows.Forms.Label()
        Me.btntraktListsSaveList = New System.Windows.Forms.Button()
        Me.btntraktListsSaveListCompare = New System.Windows.Forms.Button()
        Me.dgvtraktList = New System.Windows.Forms.DataGridView()
        Me.coltraktListTitle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coltraktListYear = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coltraktListRating = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coltraktListGenres = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coltraktListIMDB = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.coltraktListTrailer = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.btntraktListsload = New System.Windows.Forms.Button()
        Me.lbltraktListsurl = New System.Windows.Forms.Label()
        Me.txttraktListsurl = New System.Windows.Forms.TextBox()
        Me.pnlTop.SuspendLayout()
        Me.pnlCancel.SuspendLayout()
        Me.pnlSaving.SuspendLayout()
        CType(Me.pbTopLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTrakt.SuspendLayout()
        Me.tbTrakt.SuspendLayout()
        Me.tbptraktPlaycount.SuspendLayout()
        Me.pnltraktPlaycount.SuspendLayout()
        Me.gbtraktPlaycount.SuspendLayout()
        CType(Me.dgvtraktPlaycount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbptraktListsSync.SuspendLayout()
        Me.pnltraktLists.SuspendLayout()
        Me.gbtraktListsSYNC.SuspendLayout()
        Me.gbtraktListsGET.SuspendLayout()
        Me.gbtraktLists.SuspendLayout()
        Me.gbtraktListsDetails.SuspendLayout()
        Me.gbtraktListsMovies.SuspendLayout()
        CType(Me.dgvMovies, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbtraktListsMoviesInLists.SuspendLayout()
        Me.tbptraktListViewer.SuspendLayout()
        Me.pnltraktListsComparer.SuspendLayout()
        Me.gbtraktListsViewer.SuspendLayout()
        CType(Me.dgvtraktList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OK_Button
        '
        Me.OK_Button.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.OK_Button.Location = New System.Drawing.Point(5, 542)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(84, 32)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "Close"
        '
        'pnlTop
        '
        Me.pnlTop.BackColor = System.Drawing.Color.SteelBlue
        Me.pnlTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlTop.Controls.Add(Me.lblTopDetails)
        Me.pnlTop.Controls.Add(Me.lblTopTitle)
        Me.pnlTop.Controls.Add(Me.pnlCancel)
        Me.pnlTop.Controls.Add(Me.pbTopLogo)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(1104, 64)
        Me.pnlTop.TabIndex = 1
        '
        'lblTopDetails
        '
        Me.lblTopDetails.AutoSize = True
        Me.lblTopDetails.BackColor = System.Drawing.Color.Transparent
        Me.lblTopDetails.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblTopDetails.ForeColor = System.Drawing.Color.White
        Me.lblTopDetails.Location = New System.Drawing.Point(61, 38)
        Me.lblTopDetails.Name = "lblTopDetails"
        Me.lblTopDetails.Size = New System.Drawing.Size(272, 13)
        Me.lblTopDetails.TabIndex = 1
        Me.lblTopDetails.Text = "Sync lists and playcount with your trakt.tv account."
        '
        'lblTopTitle
        '
        Me.lblTopTitle.AutoSize = True
        Me.lblTopTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTopTitle.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblTopTitle.ForeColor = System.Drawing.Color.White
        Me.lblTopTitle.Location = New System.Drawing.Point(58, 3)
        Me.lblTopTitle.Name = "lblTopTitle"
        Me.lblTopTitle.Size = New System.Drawing.Size(210, 32)
        Me.lblTopTitle.TabIndex = 0
        Me.lblTopTitle.Text = "Trakt.tv Manager"
        '
        'pnlCancel
        '
        Me.pnlCancel.BackColor = System.Drawing.Color.White
        Me.pnlCancel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlCancel.Controls.Add(Me.pnlSaving)
        Me.pnlCancel.Controls.Add(Me.prbCompile)
        Me.pnlCancel.Controls.Add(Me.lblCompiling)
        Me.pnlCancel.Controls.Add(Me.lblFile)
        Me.pnlCancel.Controls.Add(Me.lblCanceling)
        Me.pnlCancel.Controls.Add(Me.btnCancel)
        Me.pnlCancel.Location = New System.Drawing.Point(365, 3)
        Me.pnlCancel.Name = "pnlCancel"
        Me.pnlCancel.Size = New System.Drawing.Size(403, 76)
        Me.pnlCancel.TabIndex = 40
        Me.pnlCancel.Visible = False
        '
        'pnlSaving
        '
        Me.pnlSaving.BackColor = System.Drawing.Color.White
        Me.pnlSaving.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlSaving.Controls.Add(Me.lblSaving)
        Me.pnlSaving.Controls.Add(Me.prbSaving)
        Me.pnlSaving.Location = New System.Drawing.Point(77, 12)
        Me.pnlSaving.Name = "pnlSaving"
        Me.pnlSaving.Size = New System.Drawing.Size(252, 51)
        Me.pnlSaving.TabIndex = 5
        Me.pnlSaving.Visible = False
        '
        'lblSaving
        '
        Me.lblSaving.AutoSize = True
        Me.lblSaving.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblSaving.Location = New System.Drawing.Point(2, 7)
        Me.lblSaving.Name = "lblSaving"
        Me.lblSaving.Size = New System.Drawing.Size(51, 13)
        Me.lblSaving.TabIndex = 0
        Me.lblSaving.Text = "Saving..."
        '
        'prbSaving
        '
        Me.prbSaving.Location = New System.Drawing.Point(4, 26)
        Me.prbSaving.MarqueeAnimationSpeed = 25
        Me.prbSaving.Name = "prbSaving"
        Me.prbSaving.Size = New System.Drawing.Size(242, 16)
        Me.prbSaving.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.prbSaving.TabIndex = 1
        '
        'prbCompile
        '
        Me.prbCompile.Location = New System.Drawing.Point(8, 36)
        Me.prbCompile.Name = "prbCompile"
        Me.prbCompile.Size = New System.Drawing.Size(388, 18)
        Me.prbCompile.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.prbCompile.TabIndex = 3
        '
        'lblCompiling
        '
        Me.lblCompiling.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblCompiling.Location = New System.Drawing.Point(3, 11)
        Me.lblCompiling.Name = "lblCompiling"
        Me.lblCompiling.Size = New System.Drawing.Size(203, 20)
        Me.lblCompiling.TabIndex = 0
        Me.lblCompiling.Text = "Loading Movies..."
        Me.lblCompiling.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblCompiling.Visible = False
        '
        'lblFile
        '
        Me.lblFile.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblFile.Location = New System.Drawing.Point(3, 57)
        Me.lblFile.Name = "lblFile"
        Me.lblFile.Size = New System.Drawing.Size(395, 13)
        Me.lblFile.TabIndex = 4
        Me.lblFile.Text = "File ..."
        '
        'lblCanceling
        '
        Me.lblCanceling.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCanceling.Location = New System.Drawing.Point(110, 12)
        Me.lblCanceling.Name = "lblCanceling"
        Me.lblCanceling.Size = New System.Drawing.Size(186, 20)
        Me.lblCanceling.TabIndex = 1
        Me.lblCanceling.Text = "Canceling Load..."
        Me.lblCanceling.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblCanceling.Visible = False
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancel.Location = New System.Drawing.Point(298, 3)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(100, 30)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'pbTopLogo
        '
        Me.pbTopLogo.BackColor = System.Drawing.Color.Transparent
        Me.pbTopLogo.Image = Global.generic.EmberCore.Trakt.My.Resources.Resources.icon
        Me.pbTopLogo.Location = New System.Drawing.Point(12, 7)
        Me.pbTopLogo.Name = "pbTopLogo"
        Me.pbTopLogo.Size = New System.Drawing.Size(48, 48)
        Me.pbTopLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pbTopLogo.TabIndex = 0
        Me.pbTopLogo.TabStop = False
        '
        'pnlTrakt
        '
        Me.pnlTrakt.Controls.Add(Me.tbTrakt)
        Me.pnlTrakt.Location = New System.Drawing.Point(0, 64)
        Me.pnlTrakt.Name = "pnlTrakt"
        Me.pnlTrakt.Size = New System.Drawing.Size(1104, 472)
        Me.pnlTrakt.TabIndex = 16
        '
        'tbTrakt
        '
        Me.tbTrakt.Controls.Add(Me.tbptraktPlaycount)
        Me.tbTrakt.Controls.Add(Me.tbptraktListsSync)
        Me.tbTrakt.Controls.Add(Me.tbptraktListViewer)
        Me.tbTrakt.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tbTrakt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTrakt.Location = New System.Drawing.Point(0, 6)
        Me.tbTrakt.Name = "tbTrakt"
        Me.tbTrakt.SelectedIndex = 0
        Me.tbTrakt.Size = New System.Drawing.Size(1104, 466)
        Me.tbTrakt.TabIndex = 1
        '
        'tbptraktPlaycount
        '
        Me.tbptraktPlaycount.Controls.Add(Me.pnltraktPlaycount)
        Me.tbptraktPlaycount.Location = New System.Drawing.Point(4, 27)
        Me.tbptraktPlaycount.Name = "tbptraktPlaycount"
        Me.tbptraktPlaycount.Padding = New System.Windows.Forms.Padding(3)
        Me.tbptraktPlaycount.Size = New System.Drawing.Size(1096, 435)
        Me.tbptraktPlaycount.TabIndex = 0
        Me.tbptraktPlaycount.Text = "Sync Playcount"
        Me.tbptraktPlaycount.UseVisualStyleBackColor = True
        '
        'pnltraktPlaycount
        '
        Me.pnltraktPlaycount.Controls.Add(Me.gbtraktPlaycount)
        Me.pnltraktPlaycount.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnltraktPlaycount.Location = New System.Drawing.Point(3, 3)
        Me.pnltraktPlaycount.Name = "pnltraktPlaycount"
        Me.pnltraktPlaycount.Size = New System.Drawing.Size(1090, 429)
        Me.pnltraktPlaycount.TabIndex = 41
        '
        'gbtraktPlaycount
        '
        Me.gbtraktPlaycount.Controls.Add(Me.btntraktPlaycountGetMovies)
        Me.gbtraktPlaycount.Controls.Add(Me.dgvtraktPlaycount)
        Me.gbtraktPlaycount.Controls.Add(Me.lbltraktPlaycountstate)
        Me.gbtraktPlaycount.Controls.Add(Me.prgtraktPlaycount)
        Me.gbtraktPlaycount.Controls.Add(Me.lbltraktPlaycounthelp)
        Me.gbtraktPlaycount.Controls.Add(Me.btntraktPlaycountSyncLibrary)
        Me.gbtraktPlaycount.Controls.Add(Me.btntraktPlaycountGetSeries)
        Me.gbtraktPlaycount.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbtraktPlaycount.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gbtraktPlaycount.Location = New System.Drawing.Point(0, 0)
        Me.gbtraktPlaycount.Name = "gbtraktPlaycount"
        Me.gbtraktPlaycount.Size = New System.Drawing.Size(1090, 429)
        Me.gbtraktPlaycount.TabIndex = 41
        Me.gbtraktPlaycount.TabStop = False
        Me.gbtraktPlaycount.Text = "Sync Playcount"
        '
        'btntraktPlaycountGetMovies
        '
        Me.btntraktPlaycountGetMovies.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btntraktPlaycountGetMovies.Location = New System.Drawing.Point(6, 23)
        Me.btntraktPlaycountGetMovies.Name = "btntraktPlaycountGetMovies"
        Me.btntraktPlaycountGetMovies.Size = New System.Drawing.Size(105, 66)
        Me.btntraktPlaycountGetMovies.TabIndex = 4
        Me.btntraktPlaycountGetMovies.Text = "Get watched movies"
        Me.btntraktPlaycountGetMovies.UseVisualStyleBackColor = True
        '
        'dgvtraktPlaycount
        '
        Me.dgvtraktPlaycount.AllowUserToAddRows = False
        Me.dgvtraktPlaycount.AllowUserToDeleteRows = False
        Me.dgvtraktPlaycount.AllowUserToResizeColumns = False
        Me.dgvtraktPlaycount.AllowUserToResizeRows = False
        Me.dgvtraktPlaycount.BackgroundColor = System.Drawing.Color.White
        Me.dgvtraktPlaycount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvtraktPlaycount.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.coltraktPlaycountTitle, Me.coltraktPlaycountPlayed})
        Me.dgvtraktPlaycount.Location = New System.Drawing.Point(258, 23)
        Me.dgvtraktPlaycount.MultiSelect = False
        Me.dgvtraktPlaycount.Name = "dgvtraktPlaycount"
        Me.dgvtraktPlaycount.RowHeadersVisible = False
        Me.dgvtraktPlaycount.RowHeadersWidth = 175
        Me.dgvtraktPlaycount.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvtraktPlaycount.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvtraktPlaycount.ShowCellErrors = False
        Me.dgvtraktPlaycount.ShowCellToolTips = False
        Me.dgvtraktPlaycount.ShowRowErrors = False
        Me.dgvtraktPlaycount.Size = New System.Drawing.Size(318, 400)
        Me.dgvtraktPlaycount.TabIndex = 32
        '
        'coltraktPlaycountTitle
        '
        Me.coltraktPlaycountTitle.Frozen = True
        Me.coltraktPlaycountTitle.HeaderText = "Title"
        Me.coltraktPlaycountTitle.Name = "coltraktPlaycountTitle"
        Me.coltraktPlaycountTitle.Width = 250
        '
        'coltraktPlaycountPlayed
        '
        Me.coltraktPlaycountPlayed.Frozen = True
        Me.coltraktPlaycountPlayed.HeaderText = "Played"
        Me.coltraktPlaycountPlayed.Name = "coltraktPlaycountPlayed"
        Me.coltraktPlaycountPlayed.Width = 64
        '
        'lbltraktPlaycountstate
        '
        Me.lbltraktPlaycountstate.AutoSize = True
        Me.lbltraktPlaycountstate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltraktPlaycountstate.ForeColor = System.Drawing.Color.SteelBlue
        Me.lbltraktPlaycountstate.Location = New System.Drawing.Point(184, 171)
        Me.lbltraktPlaycountstate.Name = "lbltraktPlaycountstate"
        Me.lbltraktPlaycountstate.Size = New System.Drawing.Size(45, 15)
        Me.lbltraktPlaycountstate.TabIndex = 35
        Me.lbltraktPlaycountstate.Text = "Done!"
        Me.lbltraktPlaycountstate.Visible = False
        '
        'prgtraktPlaycount
        '
        Me.prgtraktPlaycount.Location = New System.Drawing.Point(6, 145)
        Me.prgtraktPlaycount.Name = "prgtraktPlaycount"
        Me.prgtraktPlaycount.Size = New System.Drawing.Size(223, 23)
        Me.prgtraktPlaycount.TabIndex = 34
        '
        'lbltraktPlaycounthelp
        '
        Me.lbltraktPlaycounthelp.AutoSize = True
        Me.lbltraktPlaycounthelp.Location = New System.Drawing.Point(8, 171)
        Me.lbltraktPlaycounthelp.Name = "lbltraktPlaycounthelp"
        Me.lbltraktPlaycounthelp.Size = New System.Drawing.Size(11, 13)
        Me.lbltraktPlaycounthelp.TabIndex = 40
        Me.lbltraktPlaycounthelp.Text = "-"
        '
        'btntraktPlaycountSyncLibrary
        '
        Me.btntraktPlaycountSyncLibrary.Enabled = False
        Me.btntraktPlaycountSyncLibrary.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btntraktPlaycountSyncLibrary.Location = New System.Drawing.Point(6, 95)
        Me.btntraktPlaycountSyncLibrary.Name = "btntraktPlaycountSyncLibrary"
        Me.btntraktPlaycountSyncLibrary.Size = New System.Drawing.Size(223, 44)
        Me.btntraktPlaycountSyncLibrary.TabIndex = 33
        Me.btntraktPlaycountSyncLibrary.Text = "Save playcount to database/Nfo"
        Me.btntraktPlaycountSyncLibrary.UseVisualStyleBackColor = True
        '
        'btntraktPlaycountGetSeries
        '
        Me.btntraktPlaycountGetSeries.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btntraktPlaycountGetSeries.Location = New System.Drawing.Point(124, 23)
        Me.btntraktPlaycountGetSeries.Name = "btntraktPlaycountGetSeries"
        Me.btntraktPlaycountGetSeries.Size = New System.Drawing.Size(105, 66)
        Me.btntraktPlaycountGetSeries.TabIndex = 39
        Me.btntraktPlaycountGetSeries.Text = "Get watched episodes"
        Me.btntraktPlaycountGetSeries.UseVisualStyleBackColor = True
        '
        'tbptraktListsSync
        '
        Me.tbptraktListsSync.Controls.Add(Me.pnltraktLists)
        Me.tbptraktListsSync.Location = New System.Drawing.Point(4, 27)
        Me.tbptraktListsSync.Name = "tbptraktListsSync"
        Me.tbptraktListsSync.Padding = New System.Windows.Forms.Padding(3)
        Me.tbptraktListsSync.Size = New System.Drawing.Size(1096, 435)
        Me.tbptraktListsSync.TabIndex = 1
        Me.tbptraktListsSync.Text = "Sync Lists/Tags"
        Me.tbptraktListsSync.UseVisualStyleBackColor = True
        '
        'pnltraktLists
        '
        Me.pnltraktLists.Controls.Add(Me.gbtraktListsSYNC)
        Me.pnltraktLists.Controls.Add(Me.gbtraktListsGET)
        Me.pnltraktLists.Controls.Add(Me.lbltraktListsstate)
        Me.pnltraktLists.Controls.Add(Me.gbtraktLists)
        Me.pnltraktLists.Controls.Add(Me.prgtraktLists)
        Me.pnltraktLists.Controls.Add(Me.gbtraktListsMovies)
        Me.pnltraktLists.Controls.Add(Me.gbtraktListsMoviesInLists)
        Me.pnltraktLists.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnltraktLists.Location = New System.Drawing.Point(3, 3)
        Me.pnltraktLists.Name = "pnltraktLists"
        Me.pnltraktLists.Size = New System.Drawing.Size(1090, 429)
        Me.pnltraktLists.TabIndex = 1
        '
        'gbtraktListsSYNC
        '
        Me.gbtraktListsSYNC.Controls.Add(Me.btntraktListsSyncLibrary)
        Me.gbtraktListsSYNC.Controls.Add(Me.btntraktListsSyncTrakt)
        Me.gbtraktListsSYNC.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gbtraktListsSYNC.Location = New System.Drawing.Point(17, 102)
        Me.gbtraktListsSYNC.Name = "gbtraktListsSYNC"
        Me.gbtraktListsSYNC.Size = New System.Drawing.Size(148, 124)
        Me.gbtraktListsSYNC.TabIndex = 43
        Me.gbtraktListsSYNC.TabStop = False
        Me.gbtraktListsSYNC.Text = "Save personal lists"
        '
        'btntraktListsSyncLibrary
        '
        Me.btntraktListsSyncLibrary.Enabled = False
        Me.btntraktListsSyncLibrary.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btntraktListsSyncLibrary.Location = New System.Drawing.Point(6, 71)
        Me.btntraktListsSyncLibrary.Name = "btntraktListsSyncLibrary"
        Me.btntraktListsSyncLibrary.Size = New System.Drawing.Size(133, 46)
        Me.btntraktListsSyncLibrary.TabIndex = 41
        Me.btntraktListsSyncLibrary.Text = "Save tags to database/Nfo"
        Me.btntraktListsSyncLibrary.UseVisualStyleBackColor = True
        '
        'btntraktListsSyncTrakt
        '
        Me.btntraktListsSyncTrakt.Enabled = False
        Me.btntraktListsSyncTrakt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btntraktListsSyncTrakt.Location = New System.Drawing.Point(6, 19)
        Me.btntraktListsSyncTrakt.Name = "btntraktListsSyncTrakt"
        Me.btntraktListsSyncTrakt.Size = New System.Drawing.Size(133, 46)
        Me.btntraktListsSyncTrakt.TabIndex = 37
        Me.btntraktListsSyncTrakt.Text = "Sync to trakt.tv"
        Me.btntraktListsSyncTrakt.UseVisualStyleBackColor = True
        '
        'gbtraktListsGET
        '
        Me.gbtraktListsGET.Controls.Add(Me.btntraktListsGetPersonal)
        Me.gbtraktListsGET.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gbtraktListsGET.Location = New System.Drawing.Point(17, 12)
        Me.gbtraktListsGET.Name = "gbtraktListsGET"
        Me.gbtraktListsGET.Size = New System.Drawing.Size(148, 84)
        Me.gbtraktListsGET.TabIndex = 42
        Me.gbtraktListsGET.TabStop = False
        Me.gbtraktListsGET.Text = "Load personal lists"
        '
        'btntraktListsGetPersonal
        '
        Me.btntraktListsGetPersonal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btntraktListsGetPersonal.Location = New System.Drawing.Point(6, 23)
        Me.btntraktListsGetPersonal.Name = "btntraktListsGetPersonal"
        Me.btntraktListsGetPersonal.Size = New System.Drawing.Size(133, 46)
        Me.btntraktListsGetPersonal.TabIndex = 36
        Me.btntraktListsGetPersonal.Text = "Load trakt.tv lists"
        Me.btntraktListsGetPersonal.UseVisualStyleBackColor = True
        '
        'lbltraktListsstate
        '
        Me.lbltraktListsstate.AutoSize = True
        Me.lbltraktListsstate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltraktListsstate.ForeColor = System.Drawing.Color.SteelBlue
        Me.lbltraktListsstate.Location = New System.Drawing.Point(120, 268)
        Me.lbltraktListsstate.Name = "lbltraktListsstate"
        Me.lbltraktListsstate.Size = New System.Drawing.Size(45, 15)
        Me.lbltraktListsstate.TabIndex = 39
        Me.lbltraktListsstate.Text = "Done!"
        Me.lbltraktListsstate.Visible = False
        '
        'gbtraktLists
        '
        Me.gbtraktLists.Controls.Add(Me.gbtraktListsDetails)
        Me.gbtraktLists.Controls.Add(Me.btntraktListsGetDatabase)
        Me.gbtraktLists.Controls.Add(Me.lbDBLists)
        Me.gbtraktLists.Controls.Add(Me.txttraktListsEditList)
        Me.gbtraktLists.Controls.Add(Me.btntraktListsRemoveList)
        Me.gbtraktLists.Controls.Add(Me.btntraktListsEditList)
        Me.gbtraktLists.Controls.Add(Me.btntraktListsNewList)
        Me.gbtraktLists.Controls.Add(Me.lbtraktLists)
        Me.gbtraktLists.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.gbtraktLists.Location = New System.Drawing.Point(171, 12)
        Me.gbtraktLists.Name = "gbtraktLists"
        Me.gbtraktLists.Size = New System.Drawing.Size(404, 411)
        Me.gbtraktLists.TabIndex = 5
        Me.gbtraktLists.TabStop = False
        Me.gbtraktLists.Text = "Personal trakt.tv Lists"
        '
        'gbtraktListsDetails
        '
        Me.gbtraktListsDetails.Controls.Add(Me.btntraktListsDetailsUpdate)
        Me.gbtraktListsDetails.Controls.Add(Me.chktraktListsDetailsNumbers)
        Me.gbtraktListsDetails.Controls.Add(Me.chkltraktListsDetailsComments)
        Me.gbtraktListsDetails.Controls.Add(Me.lbltraktListsDetailsDescription)
        Me.gbtraktListsDetails.Controls.Add(Me.lbltraktListsDetailsName)
        Me.gbtraktListsDetails.Controls.Add(Me.lbltraktListsDetailsPrivacy)
        Me.gbtraktListsDetails.Controls.Add(Me.cbotraktListsDetailsPrivacy)
        Me.gbtraktListsDetails.Controls.Add(Me.txttraktListsDetailsName)
        Me.gbtraktListsDetails.Controls.Add(Me.txttraktListsDetailsDescription)
        Me.gbtraktListsDetails.Location = New System.Drawing.Point(217, 20)
        Me.gbtraktListsDetails.Name = "gbtraktListsDetails"
        Me.gbtraktListsDetails.Size = New System.Drawing.Size(181, 385)
        Me.gbtraktListsDetails.TabIndex = 48
        Me.gbtraktListsDetails.TabStop = False
        Me.gbtraktListsDetails.Text = "trakt.tv ListDetails"
        '
        'btntraktListsDetailsUpdate
        '
        Me.btntraktListsDetailsUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btntraktListsDetailsUpdate.Location = New System.Drawing.Point(6, 354)
        Me.btntraktListsDetailsUpdate.Name = "btntraktListsDetailsUpdate"
        Me.btntraktListsDetailsUpdate.Size = New System.Drawing.Size(172, 25)
        Me.btntraktListsDetailsUpdate.TabIndex = 49
        Me.btntraktListsDetailsUpdate.Text = "Update list"
        Me.btntraktListsDetailsUpdate.UseVisualStyleBackColor = True
        '
        'chktraktListsDetailsNumbers
        '
        Me.chktraktListsDetailsNumbers.AutoSize = True
        Me.chktraktListsDetailsNumbers.Location = New System.Drawing.Point(9, 331)
        Me.chktraktListsDetailsNumbers.Name = "chktraktListsDetailsNumbers"
        Me.chktraktListsDetailsNumbers.Size = New System.Drawing.Size(106, 17)
        Me.chktraktListsDetailsNumbers.TabIndex = 53
        Me.chktraktListsDetailsNumbers.Text = "Show Numbers"
        Me.chktraktListsDetailsNumbers.UseVisualStyleBackColor = True
        '
        'chkltraktListsDetailsComments
        '
        Me.chkltraktListsDetailsComments.AutoSize = True
        Me.chkltraktListsDetailsComments.Location = New System.Drawing.Point(9, 308)
        Me.chkltraktListsDetailsComments.Name = "chkltraktListsDetailsComments"
        Me.chkltraktListsDetailsComments.Size = New System.Drawing.Size(115, 17)
        Me.chkltraktListsDetailsComments.TabIndex = 52
        Me.chkltraktListsDetailsComments.Text = "Allow Comments"
        Me.chkltraktListsDetailsComments.UseVisualStyleBackColor = True
        '
        'lbltraktListsDetailsDescription
        '
        Me.lbltraktListsDetailsDescription.AutoSize = True
        Me.lbltraktListsDetailsDescription.Location = New System.Drawing.Point(6, 60)
        Me.lbltraktListsDetailsDescription.Name = "lbltraktListsDetailsDescription"
        Me.lbltraktListsDetailsDescription.Size = New System.Drawing.Size(66, 13)
        Me.lbltraktListsDetailsDescription.TabIndex = 48
        Me.lbltraktListsDetailsDescription.Text = "Description"
        '
        'lbltraktListsDetailsName
        '
        Me.lbltraktListsDetailsName.AutoSize = True
        Me.lbltraktListsDetailsName.Location = New System.Drawing.Point(6, 19)
        Me.lbltraktListsDetailsName.Name = "lbltraktListsDetailsName"
        Me.lbltraktListsDetailsName.Size = New System.Drawing.Size(38, 13)
        Me.lbltraktListsDetailsName.TabIndex = 44
        Me.lbltraktListsDetailsName.Text = "Name"
        '
        'lbltraktListsDetailsPrivacy
        '
        Me.lbltraktListsDetailsPrivacy.AutoSize = True
        Me.lbltraktListsDetailsPrivacy.Location = New System.Drawing.Point(6, 265)
        Me.lbltraktListsDetailsPrivacy.Name = "lbltraktListsDetailsPrivacy"
        Me.lbltraktListsDetailsPrivacy.Size = New System.Drawing.Size(74, 13)
        Me.lbltraktListsDetailsPrivacy.TabIndex = 45
        Me.lbltraktListsDetailsPrivacy.Text = "Privacy Level"
        '
        'cbotraktListsDetailsPrivacy
        '
        Me.cbotraktListsDetailsPrivacy.FormattingEnabled = True
        Me.cbotraktListsDetailsPrivacy.Location = New System.Drawing.Point(9, 281)
        Me.cbotraktListsDetailsPrivacy.Name = "cbotraktListsDetailsPrivacy"
        Me.cbotraktListsDetailsPrivacy.Size = New System.Drawing.Size(169, 21)
        Me.cbotraktListsDetailsPrivacy.TabIndex = 46
        '
        'txttraktListsDetailsName
        '
        Me.txttraktListsDetailsName.Location = New System.Drawing.Point(3, 35)
        Me.txttraktListsDetailsName.Multiline = True
        Me.txttraktListsDetailsName.Name = "txttraktListsDetailsName"
        Me.txttraktListsDetailsName.ReadOnly = True
        Me.txttraktListsDetailsName.Size = New System.Drawing.Size(172, 22)
        Me.txttraktListsDetailsName.TabIndex = 47
        '
        'txttraktListsDetailsDescription
        '
        Me.txttraktListsDetailsDescription.Location = New System.Drawing.Point(3, 76)
        Me.txttraktListsDetailsDescription.Multiline = True
        Me.txttraktListsDetailsDescription.Name = "txttraktListsDetailsDescription"
        Me.txttraktListsDetailsDescription.Size = New System.Drawing.Size(175, 175)
        Me.txttraktListsDetailsDescription.TabIndex = 43
        '
        'btntraktListsGetDatabase
        '
        Me.btntraktListsGetDatabase.Enabled = False
        Me.btntraktListsGetDatabase.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btntraktListsGetDatabase.Location = New System.Drawing.Point(6, 374)
        Me.btntraktListsGetDatabase.Name = "btntraktListsGetDatabase"
        Me.btntraktListsGetDatabase.Size = New System.Drawing.Size(205, 25)
        Me.btntraktListsGetDatabase.TabIndex = 42
        Me.btntraktListsGetDatabase.Text = "Add list to trakt.tv"
        Me.btntraktListsGetDatabase.UseVisualStyleBackColor = True
        '
        'lbDBLists
        '
        Me.lbDBLists.Enabled = False
        Me.lbDBLists.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lbDBLists.FormattingEnabled = True
        Me.lbDBLists.Location = New System.Drawing.Point(6, 230)
        Me.lbDBLists.Name = "lbDBLists"
        Me.lbDBLists.Size = New System.Drawing.Size(205, 134)
        Me.lbDBLists.Sorted = True
        Me.lbDBLists.TabIndex = 41
        '
        'txttraktListsEditList
        '
        Me.txttraktListsEditList.Enabled = False
        Me.txttraktListsEditList.Location = New System.Drawing.Point(6, 160)
        Me.txttraktListsEditList.Name = "txttraktListsEditList"
        Me.txttraktListsEditList.Size = New System.Drawing.Size(178, 22)
        Me.txttraktListsEditList.TabIndex = 39
        '
        'btntraktListsRemoveList
        '
        Me.btntraktListsRemoveList.Enabled = False
        Me.btntraktListsRemoveList.Image = CType(resources.GetObject("btntraktListsRemoveList.Image"), System.Drawing.Image)
        Me.btntraktListsRemoveList.Location = New System.Drawing.Point(188, 187)
        Me.btntraktListsRemoveList.Name = "btntraktListsRemoveList"
        Me.btntraktListsRemoveList.Size = New System.Drawing.Size(23, 23)
        Me.btntraktListsRemoveList.TabIndex = 3
        Me.btntraktListsRemoveList.UseVisualStyleBackColor = True
        '
        'btntraktListsEditList
        '
        Me.btntraktListsEditList.Enabled = False
        Me.btntraktListsEditList.Image = CType(resources.GetObject("btntraktListsEditList.Image"), System.Drawing.Image)
        Me.btntraktListsEditList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btntraktListsEditList.Location = New System.Drawing.Point(188, 160)
        Me.btntraktListsEditList.Name = "btntraktListsEditList"
        Me.btntraktListsEditList.Size = New System.Drawing.Size(23, 23)
        Me.btntraktListsEditList.TabIndex = 2
        Me.btntraktListsEditList.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btntraktListsEditList.UseVisualStyleBackColor = True
        '
        'btntraktListsNewList
        '
        Me.btntraktListsNewList.Enabled = False
        Me.btntraktListsNewList.Image = CType(resources.GetObject("btntraktListsNewList.Image"), System.Drawing.Image)
        Me.btntraktListsNewList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btntraktListsNewList.Location = New System.Drawing.Point(6, 187)
        Me.btntraktListsNewList.Name = "btntraktListsNewList"
        Me.btntraktListsNewList.Size = New System.Drawing.Size(23, 23)
        Me.btntraktListsNewList.TabIndex = 1
        Me.btntraktListsNewList.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btntraktListsNewList.UseVisualStyleBackColor = True
        '
        'lbtraktLists
        '
        Me.lbtraktLists.Enabled = False
        Me.lbtraktLists.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lbtraktLists.FormattingEnabled = True
        Me.lbtraktLists.Location = New System.Drawing.Point(6, 20)
        Me.lbtraktLists.Name = "lbtraktLists"
        Me.lbtraktLists.Size = New System.Drawing.Size(205, 134)
        Me.lbtraktLists.Sorted = True
        Me.lbtraktLists.TabIndex = 0
        '
        'prgtraktLists
        '
        Me.prgtraktLists.Location = New System.Drawing.Point(17, 242)
        Me.prgtraktLists.Name = "prgtraktLists"
        Me.prgtraktLists.Size = New System.Drawing.Size(148, 23)
        Me.prgtraktLists.TabIndex = 38
        '
        'gbtraktListsMovies
        '
        Me.gbtraktListsMovies.Controls.Add(Me.dgvMovies)
        Me.gbtraktListsMovies.Controls.Add(Me.btntraktListsAddMovie)
        Me.gbtraktListsMovies.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.gbtraktListsMovies.Location = New System.Drawing.Point(821, 12)
        Me.gbtraktListsMovies.Name = "gbtraktListsMovies"
        Me.gbtraktListsMovies.Size = New System.Drawing.Size(259, 411)
        Me.gbtraktListsMovies.TabIndex = 7
        Me.gbtraktListsMovies.TabStop = False
        Me.gbtraktListsMovies.Text = "Avalaible Movies"
        '
        'dgvMovies
        '
        Me.dgvMovies.AllowUserToAddRows = False
        Me.dgvMovies.AllowUserToDeleteRows = False
        Me.dgvMovies.AllowUserToResizeColumns = False
        Me.dgvMovies.AllowUserToResizeRows = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.dgvMovies.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvMovies.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvMovies.BackgroundColor = System.Drawing.Color.White
        Me.dgvMovies.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvMovies.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvMovies.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.dgvMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMovies.Enabled = False
        Me.dgvMovies.GridColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.dgvMovies.Location = New System.Drawing.Point(8, 21)
        Me.dgvMovies.Name = "dgvMovies"
        Me.dgvMovies.ReadOnly = True
        Me.dgvMovies.RowHeadersVisible = False
        Me.dgvMovies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMovies.ShowCellErrors = False
        Me.dgvMovies.ShowRowErrors = False
        Me.dgvMovies.Size = New System.Drawing.Size(243, 352)
        Me.dgvMovies.StandardTab = True
        Me.dgvMovies.TabIndex = 51
        '
        'btntraktListsAddMovie
        '
        Me.btntraktListsAddMovie.Enabled = False
        Me.btntraktListsAddMovie.Image = CType(resources.GetObject("btntraktListsAddMovie.Image"), System.Drawing.Image)
        Me.btntraktListsAddMovie.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btntraktListsAddMovie.Location = New System.Drawing.Point(8, 382)
        Me.btntraktListsAddMovie.Name = "btntraktListsAddMovie"
        Me.btntraktListsAddMovie.Size = New System.Drawing.Size(23, 23)
        Me.btntraktListsAddMovie.TabIndex = 1
        Me.btntraktListsAddMovie.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btntraktListsAddMovie.UseVisualStyleBackColor = True
        '
        'gbtraktListsMoviesInLists
        '
        Me.gbtraktListsMoviesInLists.Controls.Add(Me.lbltraktListsCurrentList)
        Me.gbtraktListsMoviesInLists.Controls.Add(Me.btntraktListsRemove)
        Me.gbtraktListsMoviesInLists.Controls.Add(Me.lbtraktListsMoviesinLists)
        Me.gbtraktListsMoviesInLists.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.gbtraktListsMoviesInLists.Location = New System.Drawing.Point(581, 12)
        Me.gbtraktListsMoviesInLists.Name = "gbtraktListsMoviesInLists"
        Me.gbtraktListsMoviesInLists.Size = New System.Drawing.Size(234, 411)
        Me.gbtraktListsMoviesInLists.TabIndex = 6
        Me.gbtraktListsMoviesInLists.TabStop = False
        Me.gbtraktListsMoviesInLists.Text = "Movies In List"
        '
        'lbltraktListsCurrentList
        '
        Me.lbltraktListsCurrentList.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lbltraktListsCurrentList.Location = New System.Drawing.Point(6, 20)
        Me.lbltraktListsCurrentList.Name = "lbltraktListsCurrentList"
        Me.lbltraktListsCurrentList.Size = New System.Drawing.Size(102, 23)
        Me.lbltraktListsCurrentList.TabIndex = 0
        Me.lbltraktListsCurrentList.Text = "None Selected"
        Me.lbltraktListsCurrentList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btntraktListsRemove
        '
        Me.btntraktListsRemove.Enabled = False
        Me.btntraktListsRemove.Image = CType(resources.GetObject("btntraktListsRemove.Image"), System.Drawing.Image)
        Me.btntraktListsRemove.Location = New System.Drawing.Point(205, 382)
        Me.btntraktListsRemove.Name = "btntraktListsRemove"
        Me.btntraktListsRemove.Size = New System.Drawing.Size(23, 23)
        Me.btntraktListsRemove.TabIndex = 4
        Me.btntraktListsRemove.UseVisualStyleBackColor = True
        '
        'lbtraktListsMoviesinLists
        '
        Me.lbtraktListsMoviesinLists.Enabled = False
        Me.lbtraktListsMoviesinLists.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lbtraktListsMoviesinLists.FormattingEnabled = True
        Me.lbtraktListsMoviesinLists.HorizontalScrollbar = True
        Me.lbtraktListsMoviesinLists.Location = New System.Drawing.Point(6, 46)
        Me.lbtraktListsMoviesinLists.Name = "lbtraktListsMoviesinLists"
        Me.lbtraktListsMoviesinLists.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lbtraktListsMoviesinLists.Size = New System.Drawing.Size(222, 329)
        Me.lbtraktListsMoviesinLists.TabIndex = 1
        '
        'tbptraktListViewer
        '
        Me.tbptraktListViewer.Controls.Add(Me.pnltraktListsComparer)
        Me.tbptraktListViewer.Location = New System.Drawing.Point(4, 27)
        Me.tbptraktListViewer.Name = "tbptraktListViewer"
        Me.tbptraktListViewer.Padding = New System.Windows.Forms.Padding(3)
        Me.tbptraktListViewer.Size = New System.Drawing.Size(1096, 435)
        Me.tbptraktListViewer.TabIndex = 2
        Me.tbptraktListViewer.Text = "List viewer"
        Me.tbptraktListViewer.UseVisualStyleBackColor = True
        '
        'pnltraktListsComparer
        '
        Me.pnltraktListsComparer.Controls.Add(Me.gbtraktListsViewer)
        Me.pnltraktListsComparer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnltraktListsComparer.Location = New System.Drawing.Point(3, 3)
        Me.pnltraktListsComparer.Name = "pnltraktListsComparer"
        Me.pnltraktListsComparer.Size = New System.Drawing.Size(1090, 429)
        Me.pnltraktListsComparer.TabIndex = 0
        '
        'gbtraktListsViewer
        '
        Me.gbtraktListsViewer.Controls.Add(Me.lbltraktListsdescription)
        Me.gbtraktListsViewer.Controls.Add(Me.lbltraktListsdescriptionloaded)
        Me.gbtraktListsViewer.Controls.Add(Me.btntraktListsfetch)
        Me.gbtraktListsViewer.Controls.Add(Me.cbotraktListsfetch)
        Me.gbtraktListsViewer.Controls.Add(Me.lbltraktListsCount)
        Me.gbtraktListsViewer.Controls.Add(Me.chktraktListsCompare)
        Me.gbtraktListsViewer.Controls.Add(Me.lbltraktListsurlhelp)
        Me.gbtraktListsViewer.Controls.Add(Me.btntraktListsSaveList)
        Me.gbtraktListsViewer.Controls.Add(Me.btntraktListsSaveListCompare)
        Me.gbtraktListsViewer.Controls.Add(Me.dgvtraktList)
        Me.gbtraktListsViewer.Controls.Add(Me.btntraktListsload)
        Me.gbtraktListsViewer.Controls.Add(Me.lbltraktListsurl)
        Me.gbtraktListsViewer.Controls.Add(Me.txttraktListsurl)
        Me.gbtraktListsViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbtraktListsViewer.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.gbtraktListsViewer.Location = New System.Drawing.Point(0, 0)
        Me.gbtraktListsViewer.Name = "gbtraktListsViewer"
        Me.gbtraktListsViewer.Size = New System.Drawing.Size(1090, 429)
        Me.gbtraktListsViewer.TabIndex = 43
        Me.gbtraktListsViewer.TabStop = False
        Me.gbtraktListsViewer.Text = "List viewer"
        '
        'lbltraktListsdescription
        '
        Me.lbltraktListsdescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltraktListsdescription.Location = New System.Drawing.Point(656, 100)
        Me.lbltraktListsdescription.Name = "lbltraktListsdescription"
        Me.lbltraktListsdescription.Size = New System.Drawing.Size(91, 20)
        Me.lbltraktListsdescription.TabIndex = 56
        Me.lbltraktListsdescription.Text = "Description"
        Me.lbltraktListsdescription.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'lbltraktListsdescriptionloaded
        '
        Me.lbltraktListsdescriptionloaded.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltraktListsdescriptionloaded.Location = New System.Drawing.Point(659, 128)
        Me.lbltraktListsdescriptionloaded.Name = "lbltraktListsdescriptionloaded"
        Me.lbltraktListsdescriptionloaded.Size = New System.Drawing.Size(422, 58)
        Me.lbltraktListsdescriptionloaded.TabIndex = 55
        Me.lbltraktListsdescriptionloaded.Text = "-"
        '
        'btntraktListsfetch
        '
        Me.btntraktListsfetch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btntraktListsfetch.Location = New System.Drawing.Point(986, 46)
        Me.btntraktListsfetch.Name = "btntraktListsfetch"
        Me.btntraktListsfetch.Size = New System.Drawing.Size(95, 21)
        Me.btntraktListsfetch.TabIndex = 54
        Me.btntraktListsfetch.Text = "Fetch lists"
        Me.btntraktListsfetch.UseVisualStyleBackColor = True
        '
        'cbotraktListsfetch
        '
        Me.cbotraktListsfetch.Enabled = False
        Me.cbotraktListsfetch.FormattingEnabled = True
        Me.cbotraktListsfetch.Location = New System.Drawing.Point(686, 46)
        Me.cbotraktListsfetch.Name = "cbotraktListsfetch"
        Me.cbotraktListsfetch.Size = New System.Drawing.Size(294, 21)
        Me.cbotraktListsfetch.TabIndex = 53
        '
        'lbltraktListsCount
        '
        Me.lbltraktListsCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltraktListsCount.Location = New System.Drawing.Point(650, 405)
        Me.lbltraktListsCount.Name = "lbltraktListsCount"
        Me.lbltraktListsCount.Size = New System.Drawing.Size(130, 20)
        Me.lbltraktListsCount.TabIndex = 52
        Me.lbltraktListsCount.Text = "Search results"
        Me.lbltraktListsCount.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.lbltraktListsCount.Visible = False
        '
        'chktraktListsCompare
        '
        Me.chktraktListsCompare.Enabled = False
        Me.chktraktListsCompare.Location = New System.Drawing.Point(653, 262)
        Me.chktraktListsCompare.Name = "chktraktListsCompare"
        Me.chktraktListsCompare.Size = New System.Drawing.Size(130, 36)
        Me.chktraktListsCompare.TabIndex = 51
        Me.chktraktListsCompare.Text = "only show unknown movies"
        Me.chktraktListsCompare.UseVisualStyleBackColor = True
        '
        'lbltraktListsurlhelp
        '
        Me.lbltraktListsurlhelp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltraktListsurlhelp.Location = New System.Drawing.Point(638, 38)
        Me.lbltraktListsurlhelp.Name = "lbltraktListsurlhelp"
        Me.lbltraktListsurlhelp.Size = New System.Drawing.Size(46, 29)
        Me.lbltraktListsurlhelp.TabIndex = 50
        Me.lbltraktListsurlhelp.Text = "trakt.tv list:"
        Me.lbltraktListsurlhelp.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'btntraktListsSaveList
        '
        Me.btntraktListsSaveList.Enabled = False
        Me.btntraktListsSaveList.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btntraktListsSaveList.Location = New System.Drawing.Point(653, 304)
        Me.btntraktListsSaveList.Name = "btntraktListsSaveList"
        Me.btntraktListsSaveList.Size = New System.Drawing.Size(133, 46)
        Me.btntraktListsSaveList.TabIndex = 48
        Me.btntraktListsSaveList.Text = "Export complete list"
        Me.btntraktListsSaveList.UseVisualStyleBackColor = True
        '
        'btntraktListsSaveListCompare
        '
        Me.btntraktListsSaveListCompare.Enabled = False
        Me.btntraktListsSaveListCompare.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btntraktListsSaveListCompare.Location = New System.Drawing.Point(653, 356)
        Me.btntraktListsSaveListCompare.Name = "btntraktListsSaveListCompare"
        Me.btntraktListsSaveListCompare.Size = New System.Drawing.Size(133, 46)
        Me.btntraktListsSaveListCompare.TabIndex = 47
        Me.btntraktListsSaveListCompare.Text = "Export unknown movies"
        Me.btntraktListsSaveListCompare.UseVisualStyleBackColor = True
        '
        'dgvtraktList
        '
        Me.dgvtraktList.AllowUserToAddRows = False
        Me.dgvtraktList.AllowUserToDeleteRows = False
        Me.dgvtraktList.AllowUserToResizeColumns = False
        Me.dgvtraktList.AllowUserToResizeRows = False
        Me.dgvtraktList.BackgroundColor = System.Drawing.Color.White
        Me.dgvtraktList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvtraktList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.coltraktListTitle, Me.coltraktListYear, Me.coltraktListRating, Me.coltraktListGenres, Me.coltraktListIMDB, Me.coltraktListTrailer})
        Me.dgvtraktList.Location = New System.Drawing.Point(6, 16)
        Me.dgvtraktList.MultiSelect = False
        Me.dgvtraktList.Name = "dgvtraktList"
        Me.dgvtraktList.RowHeadersVisible = False
        Me.dgvtraktList.RowHeadersWidth = 175
        Me.dgvtraktList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvtraktList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvtraktList.ShowCellErrors = False
        Me.dgvtraktList.ShowCellToolTips = False
        Me.dgvtraktList.ShowRowErrors = False
        Me.dgvtraktList.Size = New System.Drawing.Size(626, 407)
        Me.dgvtraktList.TabIndex = 46
        '
        'coltraktListTitle
        '
        Me.coltraktListTitle.Frozen = True
        Me.coltraktListTitle.HeaderText = "Title"
        Me.coltraktListTitle.Name = "coltraktListTitle"
        Me.coltraktListTitle.Width = 160
        '
        'coltraktListYear
        '
        Me.coltraktListYear.Frozen = True
        Me.coltraktListYear.HeaderText = "Year"
        Me.coltraktListYear.Name = "coltraktListYear"
        Me.coltraktListYear.Width = 45
        '
        'coltraktListRating
        '
        Me.coltraktListRating.HeaderText = "Rating"
        Me.coltraktListRating.Name = "coltraktListRating"
        Me.coltraktListRating.Width = 45
        '
        'coltraktListGenres
        '
        Me.coltraktListGenres.HeaderText = "Genres"
        Me.coltraktListGenres.Name = "coltraktListGenres"
        Me.coltraktListGenres.Width = 200
        '
        'coltraktListIMDB
        '
        Me.coltraktListIMDB.HeaderText = "IMDB"
        Me.coltraktListIMDB.Name = "coltraktListIMDB"
        Me.coltraktListIMDB.Text = "IMDB Link"
        '
        'coltraktListTrailer
        '
        Me.coltraktListTrailer.HeaderText = "Trailer"
        Me.coltraktListTrailer.Name = "coltraktListTrailer"
        Me.coltraktListTrailer.Text = "Link"
        '
        'btntraktListsload
        '
        Me.btntraktListsload.Enabled = False
        Me.btntraktListsload.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btntraktListsload.Location = New System.Drawing.Point(986, 73)
        Me.btntraktListsload.Name = "btntraktListsload"
        Me.btntraktListsload.Size = New System.Drawing.Size(95, 22)
        Me.btntraktListsload.TabIndex = 36
        Me.btntraktListsload.Text = "Load list"
        Me.btntraktListsload.UseVisualStyleBackColor = True
        '
        'lbltraktListsurl
        '
        Me.lbltraktListsurl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltraktListsurl.Location = New System.Drawing.Point(638, 75)
        Me.lbltraktListsurl.Name = "lbltraktListsurl"
        Me.lbltraktListsurl.Size = New System.Drawing.Size(46, 17)
        Me.lbltraktListsurl.TabIndex = 45
        Me.lbltraktListsurl.Text = "Url:"
        Me.lbltraktListsurl.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'txttraktListsurl
        '
        Me.txttraktListsurl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttraktListsurl.Location = New System.Drawing.Point(686, 73)
        Me.txttraktListsurl.Name = "txttraktListsurl"
        Me.txttraktListsurl.Size = New System.Drawing.Size(294, 20)
        Me.txttraktListsurl.TabIndex = 44
        '
        'dlgTrakttvManager
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(1104, 579)
        Me.ControlBox = False
        Me.Controls.Add(Me.pnlTrakt)
        Me.Controls.Add(Me.pnlTop)
        Me.Controls.Add(Me.OK_Button)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgTrakttvManager"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Trakt.tv Manager"
        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()
        Me.pnlCancel.ResumeLayout(False)
        Me.pnlSaving.ResumeLayout(False)
        Me.pnlSaving.PerformLayout()
        CType(Me.pbTopLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTrakt.ResumeLayout(False)
        Me.tbTrakt.ResumeLayout(False)
        Me.tbptraktPlaycount.ResumeLayout(False)
        Me.pnltraktPlaycount.ResumeLayout(False)
        Me.gbtraktPlaycount.ResumeLayout(False)
        Me.gbtraktPlaycount.PerformLayout()
        CType(Me.dgvtraktPlaycount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbptraktListsSync.ResumeLayout(False)
        Me.pnltraktLists.ResumeLayout(False)
        Me.pnltraktLists.PerformLayout()
        Me.gbtraktListsSYNC.ResumeLayout(False)
        Me.gbtraktListsGET.ResumeLayout(False)
        Me.gbtraktLists.ResumeLayout(False)
        Me.gbtraktLists.PerformLayout()
        Me.gbtraktListsDetails.ResumeLayout(False)
        Me.gbtraktListsDetails.PerformLayout()
        Me.gbtraktListsMovies.ResumeLayout(False)
        CType(Me.dgvMovies, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbtraktListsMoviesInLists.ResumeLayout(False)
        Me.tbptraktListViewer.ResumeLayout(False)
        Me.pnltraktListsComparer.ResumeLayout(False)
        Me.gbtraktListsViewer.ResumeLayout(False)
        Me.gbtraktListsViewer.PerformLayout()
        CType(Me.dgvtraktList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents pnlTop As System.Windows.Forms.Panel
    Friend WithEvents lblTopDetails As System.Windows.Forms.Label
    Friend WithEvents lblTopTitle As System.Windows.Forms.Label
    Friend WithEvents pbTopLogo As System.Windows.Forms.PictureBox
    Friend WithEvents pnlTrakt As System.Windows.Forms.Panel
    Friend WithEvents tbTrakt As System.Windows.Forms.TabControl
    Friend WithEvents tbptraktPlaycount As System.Windows.Forms.TabPage
    Friend WithEvents pnltraktPlaycount As System.Windows.Forms.Panel
    Friend WithEvents btntraktPlaycountGetMovies As System.Windows.Forms.Button
    Friend WithEvents dgvtraktPlaycount As System.Windows.Forms.DataGridView
    Friend WithEvents coltraktPlaycountTitle As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coltraktPlaycountPlayed As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lbltraktPlaycounthelp As System.Windows.Forms.Label
    Friend WithEvents btntraktPlaycountGetSeries As System.Windows.Forms.Button
    Friend WithEvents btntraktPlaycountSyncLibrary As System.Windows.Forms.Button
    Friend WithEvents prgtraktPlaycount As System.Windows.Forms.ProgressBar
    Friend WithEvents lbltraktPlaycountstate As System.Windows.Forms.Label
    Friend WithEvents tbptraktListsSync As System.Windows.Forms.TabPage
    Friend WithEvents pnltraktLists As System.Windows.Forms.Panel
    Friend WithEvents gbtraktListsSYNC As System.Windows.Forms.GroupBox
    Friend WithEvents btntraktListsSyncLibrary As System.Windows.Forms.Button
    Friend WithEvents btntraktListsSyncTrakt As System.Windows.Forms.Button
    Friend WithEvents gbtraktListsGET As System.Windows.Forms.GroupBox
    Friend WithEvents btntraktListsGetPersonal As System.Windows.Forms.Button
    Friend WithEvents lbltraktListsstate As System.Windows.Forms.Label
    Friend WithEvents gbtraktLists As System.Windows.Forms.GroupBox
    Friend WithEvents btntraktListsGetDatabase As System.Windows.Forms.Button
    Friend WithEvents lbDBLists As System.Windows.Forms.ListBox
    Friend WithEvents txttraktListsEditList As System.Windows.Forms.TextBox
    Friend WithEvents btntraktListsRemoveList As System.Windows.Forms.Button
    Friend WithEvents btntraktListsEditList As System.Windows.Forms.Button
    Friend WithEvents btntraktListsNewList As System.Windows.Forms.Button
    Friend WithEvents lbtraktLists As System.Windows.Forms.ListBox
    Friend WithEvents prgtraktLists As System.Windows.Forms.ProgressBar
    Friend WithEvents gbtraktListsMovies As System.Windows.Forms.GroupBox
    Friend WithEvents dgvMovies As System.Windows.Forms.DataGridView
    Friend WithEvents btntraktListsAddMovie As System.Windows.Forms.Button
    Friend WithEvents gbtraktListsMoviesInLists As System.Windows.Forms.GroupBox
    Friend WithEvents lbltraktListsCurrentList As System.Windows.Forms.Label
    Friend WithEvents btntraktListsRemove As System.Windows.Forms.Button
    Friend WithEvents lbtraktListsMoviesinLists As System.Windows.Forms.ListBox
    Friend WithEvents tbptraktListViewer As System.Windows.Forms.TabPage
    Friend WithEvents pnltraktListsComparer As System.Windows.Forms.Panel
    Friend WithEvents gbtraktListsViewer As System.Windows.Forms.GroupBox
    Friend WithEvents lbltraktListsdescription As System.Windows.Forms.Label
    Friend WithEvents lbltraktListsdescriptionloaded As System.Windows.Forms.Label
    Friend WithEvents btntraktListsfetch As System.Windows.Forms.Button
    Friend WithEvents cbotraktListsfetch As System.Windows.Forms.ComboBox
    Friend WithEvents lbltraktListsCount As System.Windows.Forms.Label
    Friend WithEvents chktraktListsCompare As System.Windows.Forms.CheckBox
    Friend WithEvents lbltraktListsurlhelp As System.Windows.Forms.Label
    Friend WithEvents btntraktListsSaveList As System.Windows.Forms.Button
    Friend WithEvents btntraktListsSaveListCompare As System.Windows.Forms.Button
    Friend WithEvents dgvtraktList As System.Windows.Forms.DataGridView
    Friend WithEvents btntraktListsload As System.Windows.Forms.Button
    Friend WithEvents lbltraktListsurl As System.Windows.Forms.Label
    Friend WithEvents txttraktListsurl As System.Windows.Forms.TextBox
    Friend WithEvents pnlCancel As System.Windows.Forms.Panel
    Friend WithEvents pnlSaving As System.Windows.Forms.Panel
    Friend WithEvents lblSaving As System.Windows.Forms.Label
    Friend WithEvents prbSaving As System.Windows.Forms.ProgressBar
    Friend WithEvents prbCompile As System.Windows.Forms.ProgressBar
    Friend WithEvents lblCompiling As System.Windows.Forms.Label
    Friend WithEvents lblFile As System.Windows.Forms.Label
    Friend WithEvents lblCanceling As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents gbtraktPlaycount As System.Windows.Forms.GroupBox
    Friend WithEvents coltraktListTitle As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coltraktListYear As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coltraktListRating As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coltraktListGenres As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coltraktListIMDB As System.Windows.Forms.DataGridViewLinkColumn
    Friend WithEvents coltraktListTrailer As System.Windows.Forms.DataGridViewLinkColumn
    Friend WithEvents gbtraktListsDetails As System.Windows.Forms.GroupBox
    Friend WithEvents txttraktListsDetailsName As System.Windows.Forms.TextBox
    Friend WithEvents lbltraktListsDetailsPrivacy As System.Windows.Forms.Label
    Friend WithEvents lbltraktListsDetailsName As System.Windows.Forms.Label
    Friend WithEvents txttraktListsDetailsDescription As System.Windows.Forms.TextBox
    Friend WithEvents lbltraktListsDetailsDescription As System.Windows.Forms.Label
    Friend WithEvents chktraktListsDetailsNumbers As System.Windows.Forms.CheckBox
    Friend WithEvents chkltraktListsDetailsComments As System.Windows.Forms.CheckBox
    Friend WithEvents cbotraktListsDetailsPrivacy As System.Windows.Forms.ComboBox
    Friend WithEvents btntraktListsDetailsUpdate As System.Windows.Forms.Button

End Class
