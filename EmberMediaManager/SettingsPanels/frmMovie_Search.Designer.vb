﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMovie_Search
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.pnlMovieSearch = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.pnlMovieSearch.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlMovieSearch
        '
        Me.pnlMovieSearch.Controls.Add(Me.Button1)
        Me.pnlMovieSearch.Controls.Add(Me.Label1)
        Me.pnlMovieSearch.Location = New System.Drawing.Point(58, 69)
        Me.pnlMovieSearch.Name = "pnlMovieSearch"
        Me.pnlMovieSearch.Size = New System.Drawing.Size(200, 100)
        Me.pnlMovieSearch.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(69, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(57, 65)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmMovieSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.pnlMovieSearch)
        Me.Name = "frmMovieSearch"
        Me.Text = "pnlMovieData"
        Me.pnlMovieSearch.ResumeLayout(False)
        Me.pnlMovieSearch.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlMovieSearch As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
End Class
