﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVLCVideo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVLCVideo))
        Me.AxVLCPlayer = New AxAXVLC.AxVLCPlugin2()
        Me.pnlVLC = New System.Windows.Forms.Panel()
        CType(Me.AxVLCPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlVLC.SuspendLayout()
        Me.SuspendLayout()
        '
        'AxVLCPlayer
        '
        Me.AxVLCPlayer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AxVLCPlayer.Enabled = True
        Me.AxVLCPlayer.Location = New System.Drawing.Point(0, 0)
        Me.AxVLCPlayer.Name = "AxVLCPlayer"
        Me.AxVLCPlayer.OcxState = CType(resources.GetObject("AxVLCPlayer.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxVLCPlayer.Size = New System.Drawing.Size(837, 471)
        Me.AxVLCPlayer.TabIndex = 0
        '
        'pnlVLC
        '
        Me.pnlVLC.Controls.Add(Me.AxVLCPlayer)
        Me.pnlVLC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlVLC.Location = New System.Drawing.Point(0, 0)
        Me.pnlVLC.Name = "pnlVLC"
        Me.pnlVLC.Size = New System.Drawing.Size(837, 471)
        Me.pnlVLC.TabIndex = 1
        '
        'frmVLCVideo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(837, 471)
        Me.Controls.Add(Me.pnlVLC)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmVLCVideo"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmExtrator"
        CType(Me.AxVLCPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlVLC.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AxVLCPlayer As AxAXVLC.AxVLCPlugin2
    Friend WithEvents pnlVLC As System.Windows.Forms.Panel

End Class
