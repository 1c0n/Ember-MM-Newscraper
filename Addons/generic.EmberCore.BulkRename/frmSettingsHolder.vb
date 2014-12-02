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

    Public Event ModuleEnabledChanged(ByVal State As Boolean, ByVal difforder As Integer)

    Public Event ModuleSettingsChanged()

#End Region 'Events

#Region "Methods"

    Private Sub chkBulRenamer_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkBulkRenamer.CheckedChanged
        RaiseEvent ModuleSettingsChanged()
    End Sub

    Private Sub chkEnabled_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkEnabled.CheckedChanged
        RaiseEvent ModuleEnabledChanged(chkEnabled.Checked, 0)
    End Sub

    Private Sub chkGenericModule_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkGenericModule.CheckedChanged
        RaiseEvent ModuleSettingsChanged()
    End Sub

    Private Sub chkOnError_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        RaiseEvent ModuleSettingsChanged()
    End Sub

    Private Sub chkRenameEditMovies_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkRenameEditMovies.CheckedChanged
        RaiseEvent ModuleSettingsChanged()
    End Sub

    Private Sub chkRenameEditEpisodes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkRenameEditEpisodes.CheckedChanged
        RaiseEvent ModuleSettingsChanged()
    End Sub

    Private Sub chkRenameMulti_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkRenameMultiMovies.CheckedChanged
        RaiseEvent ModuleSettingsChanged()
    End Sub

    Private Sub chkRenameMultiShows_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkRenameMultiShows.CheckedChanged
        RaiseEvent ModuleSettingsChanged()
    End Sub

    Private Sub chkRenameSingleMovies_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkRenameSingleMovies.CheckedChanged
        RaiseEvent ModuleSettingsChanged()
    End Sub

    Private Sub chkRenameSingleShows_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkRenameSingleShows.CheckedChanged
        RaiseEvent ModuleSettingsChanged()
    End Sub

    Private Sub chkRenameUpdateEpisodes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkRenameUpdateEpisodes.CheckedChanged
        RaiseEvent ModuleSettingsChanged()
    End Sub

    Sub SetUp()
        Me.chkRenameEditMovies.Text = Master.eLang.GetString(466, "Automatically Rename Files After Edit")
        Me.chkRenameEditEpisodes.Text = Master.eLang.GetString(467, "Automatically Rename Files After Edit Episodes")
        Me.chkRenameMultiMovies.Text = Master.eLang.GetString(281, "Automatically Rename Files During Multi-Scraper")
        Me.chkRenameSingleMovies.Text = Master.eLang.GetString(282, "Automatically Rename Files During Single-Scraper")
        Me.chkRenameUpdateEpisodes.Text = Master.eLang.GetString(468, "Automatically Rename Files During DB Update")
        Me.gbRenamerPatternsMovies.Text = Master.eLang.GetString(285, "Default Renaming Patterns")
        Me.lblFilePatternEpisodes.Text = Master.eLang.GetString(469, "Episode Files Pattern")
        Me.lblFilePatternMovies.Text = Master.eLang.GetString(286, "Files Pattern")
        Me.lblFolderPatternMovies.Text = Master.eLang.GetString(287, "Folders Pattern")
        Me.chkEnabled.Text = Master.eLang.GetString(774, "Enabled")
        Me.chkGenericModule.Text = Master.eLang.GetString(288, "Enable Generic Rename Module")
        Me.chkBulkRenamer.Text = Master.eLang.GetString(290, "Enable Bulk Renamer Tool")
        Me.lblTips.Text = String.Format(Master.eLang.GetString(262, "$1 = First Letter of the Title{0}$A = Audio Channels{0}$B = Base Path{0}$C = Director{0}$D = Directory{0}$E = Sort Title{0}$F = File Name{0}$G = Genre (Follow with a space, dot or hyphen to change separator){0}$H = Video Codec{0}$I = IMDB ID{0}$J = Audio Codec{0}$L = List Title{0}$M = MPAA{0}$N = Collection Name{0}$O = OriginalTitle{0}$P = Rating{0}$Q.E? = Episode Separator (. or _ or x), Episode Prefix{0}$R = Resolution{0}$S = Video Source{0}$T = Title{0}$V = 3D (If Multiview > 1){0}$W.S?.E? = Seasons Separator (. or _), Season Prefix, Episode Separator (. or _ or x), Episode Prefix{0}$Y = Year{0}$X. (Replace Space with .){0}$Z = Show Title{0}{{}} = Optional{0}$?aaa?bbb? = Replace aaa with bbb{0}$- = Remove previous char if next pattern does not have a value{0}$+ = Remove next char if previous pattern does not have a value{0}$^ = Remove previous and next char if next pattern does not have a value"), vbNewLine)
    End Sub

    Private Sub txtFilePattern_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFilePatternMovies.TextChanged
        RaiseEvent ModuleSettingsChanged()
    End Sub

    Private Sub txtFolderPattern_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFolderPatternMovies.TextChanged
        RaiseEvent ModuleSettingsChanged()
    End Sub

    Public Sub New()
        InitializeComponent()
        Me.SetUp()
    End Sub

#End Region 'Methods

End Class