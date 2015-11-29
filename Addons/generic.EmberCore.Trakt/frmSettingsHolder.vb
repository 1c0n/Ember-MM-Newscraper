﻿Imports EmberAPI

' ################################################################################
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

Public Class frmSettingsHolder

#Region "Events"

    Public Event ModuleEnabledChanged(ByVal State As Boolean)

    Public Event ModuleSettingsChanged()

#End Region 'Events

#Region "Methods"

    Private Sub chkTraktEnabled_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkEnabled.CheckedChanged
        RaiseEvent ModuleEnabledChanged(chkEnabled.Checked)
    End Sub

    Public Sub New()
        InitializeComponent()
        Me.SetUp()
    End Sub

    Private Sub SetUp()
        Me.chkEnabled.Text = Master.eLang.GetString(774, "Enabled")
        Me.chkGetShowProgress.Text = Master.eLang.GetString(1388, "Display watched progress for shows (Time consuming!)")
        Me.gbSettingsGeneral.Text = Master.eLang.GetString(38, "General Settings")
        Me.lblPassword.Text = Master.eLang.GetString(426, "Password")
        Me.lblUsername.Text = Master.eLang.GetString(425, "Username")
        Me.txtPassword.PasswordChar = "*"c
        Me.gbSettingsLastPlayed.Text = Master.eLang.GetString(1369, "Last watched")
        Me.gbSettingsPlaycount.Text = Master.eLang.GetString(1452, "Playcount")

    End Sub


    Private Sub txtUsername_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUsername.TextChanged
        RaiseEvent ModuleSettingsChanged()
    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged
        RaiseEvent ModuleSettingsChanged()
    End Sub
    Private Sub chkGetShowProgress_CheckedChanged(sender As Object, e As EventArgs) Handles chkGetShowProgress.CheckedChanged
        RaiseEvent ModuleSettingsChanged()
    End Sub

#End Region 'Methods

    Private Sub tblSettingsGeneral_Paint(sender As Object, e As Windows.Forms.PaintEventArgs) Handles tblSettingsGeneral.Paint

    End Sub

    Private Sub chkSyncPlaycountEditEpisodes_CheckedChanged(sender As Object, e As EventArgs) Handles chkSyncPlaycountEditEpisodes.CheckedChanged

    End Sub
End Class