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

Imports System
Imports System.Windows.Forms
Imports System.IO
Imports System.Xml.Serialization
Imports System.Data.SQLite
Imports System.Xml.Linq
Imports NLog
Imports System.Text.RegularExpressions

''' <summary>
''' Class defining and implementing the interface to the database
''' </summary>
''' <remarks></remarks>
Public Class Database

#Region "Fields"
    Shared logger As Logger = NLog.LogManager.GetCurrentClassLogger()

    Friend WithEvents bwPatchDB As New System.ComponentModel.BackgroundWorker

    ReadOnly _connStringTemplate As String = "Data Source=""{0}"";Version=3;Compress=True"
    Protected _myvideosDBConn As SQLiteConnection
    ' NOTE: This will use another DB because: can grow alot, Don't want to stress Media DB with this stuff
    'Protected _jobsDBConn As SQLiteConnection

#End Region 'Fields

#Region "Properties"

    Public ReadOnly Property MyVideosDBConn() As SQLiteConnection
        Get
            Return _myvideosDBConn
        End Get
    End Property

    'Public ReadOnly Property JobsDBConn() As SQLiteConnection
    '    Get
    '        Return _jobsDBConn
    '    End Get
    'End Property

#End Region

#Region "Methods"
    ''' <summary>
    ''' add or update actor
    ''' </summary>
    ''' <param name="strActor">actor name</param>
    ''' <param name="thumbURLs">thumb URL</param>
    ''' <param name="thumb">local thumb path</param>
    ''' <returns><c>ID</c> of actor in actors table</returns>
    ''' <remarks></remarks>
    Private Function AddActor(ByVal strActor As String, ByVal thumbURLs As String, ByVal thumb As String) As Long
        Dim doesExist As Boolean = False
        Dim ID As Long = -1

        Using SQLcommand_select_actors As SQLite.SQLiteCommand = _myvideosDBConn.CreateCommand()
            SQLcommand_select_actors.CommandText = String.Format("SELECT idActor FROM actors WHERE strActor LIKE ?", strActor)
            Dim par_select_actors_strActor As SQLite.SQLiteParameter = SQLcommand_select_actors.Parameters.Add("par_select_actors_strActor", DbType.String, 0, "strActor")
            par_select_actors_strActor.Value = strActor
            Using SQLreader As SQLite.SQLiteDataReader = SQLcommand_select_actors.ExecuteReader()
                While SQLreader.Read
                    doesExist = True
                    ID = CInt(SQLreader("idActor"))
                    Exit While
                End While
            End Using
        End Using

        If Not doesExist Then
            Using SQLcommand_insert_actors As SQLite.SQLiteCommand = _myvideosDBConn.CreateCommand()
                SQLcommand_insert_actors.CommandText = "INSERT INTO actors (idActor, strActor, strThumb) VALUES (NULL,?,?); SELECT LAST_INSERT_ROWID() FROM actors;"
                Dim par_insert_actors_strActor As SQLite.SQLiteParameter = SQLcommand_insert_actors.Parameters.Add("par_actors_strActor", DbType.String, 0, "strActor")
                Dim par_insert_actors_strThumb As SQLite.SQLiteParameter = SQLcommand_insert_actors.Parameters.Add("par_actors_strThumb", DbType.String, 0, "strThumb")
                par_insert_actors_strActor.Value = strActor
                par_insert_actors_strThumb.Value = thumbURLs
                ID = CInt(SQLcommand_insert_actors.ExecuteScalar())
            End Using
        Else
            Using SQLcommand_update_actors As SQLite.SQLiteCommand = _myvideosDBConn.CreateCommand()
                SQLcommand_update_actors.CommandText = String.Format("UPDATE actors SET strThumb=? WHERE idActor={0}", ID)
                Dim par_update_actors_strThumb As SQLite.SQLiteParameter = SQLcommand_update_actors.Parameters.Add("par_actors_strThumb", DbType.String, 0, "strThumb")
                par_update_actors_strThumb.Value = thumbURLs
                SQLcommand_update_actors.ExecuteNonQuery()
            End Using
        End If

        If Not ID = -1 Then
            If Not String.IsNullOrEmpty(thumb) Then
                SetArtForItem(ID, "actor", "thumb", thumb)
            End If
        End If

        Return ID
    End Function

    Private Sub AddArtistToMusicVideo(ByVal idMVideo As Long, ByVal idArtist As Long)
        AddToLinkTable("artistlinkmusicvideo", "idArtist", idArtist, "idMVideo", idMVideo)
    End Sub

    Private Sub AddCast(ByVal idMedia As Long, ByVal table As String, ByVal field As String, ByVal cast As List(Of MediaContainers.Person))
        If cast Is Nothing Then Return

        Dim iOrder As Integer = 0
        For Each actor As MediaContainers.Person In cast
            Dim idActor = AddActor(actor.Name, actor.ThumbURL, actor.ThumbPath)
            AddLinkToActor(table, idActor, field, idMedia, actor.Role, iOrder)
            iOrder += 1
        Next
    End Sub

    Private Function AddCountry(ByVal strCountry As String) As Long
        If String.IsNullOrEmpty(strCountry) Then Return -1
        Return AddToTable("country", "idCountry", "strCountry", strCountry)
    End Function

    Private Sub AddCountryToMovie(ByVal idMovie As Long, ByVal idCountry As Long)
        AddToLinkTable("countrylinkmovie", "idCountry", idCountry, "idMovie", idMovie)
    End Sub

    Private Sub AddDirectorToEpisode(ByVal idEpisode As Long, ByVal idDirector As Long)
        AddToLinkTable("directorlinkepisode", "idDirector", idDirector, "idEpisode", idEpisode)
    End Sub

    Private Sub AddDirectorToMovie(ByVal idMovie As Long, ByVal idDirector As Long)
        AddToLinkTable("directorlinkmovie", "idDirector", idDirector, "idMovie", idMovie)
    End Sub

    Private Sub AddDirectorToMusicVideo(ByVal idMVideo As Long, ByVal idDirector As Long)
        AddToLinkTable("directorlinkmusicvideo", "idDirector", idDirector, "idMVideo", idMVideo)
    End Sub

    Private Sub AddDirectorToTvShow(ByVal idShow As Long, ByVal idDirector As Long)
        AddToLinkTable("directorlinktvshow", "idDirector", idDirector, "idShow", idShow)
    End Sub

    Private Function AddGenre(ByVal strGenre As String) As Long
        If String.IsNullOrEmpty(strGenre) Then Return -1
        Return AddToTable("genre", "idGenre", "strGenre", strGenre)
    End Function

    Private Sub AddGenreToMovie(ByVal idMovie As Long, ByVal idGenre As Long)
        AddToLinkTable("genrelinkmovie", "idGenre", idGenre, "idMovie", idMovie)
    End Sub

    Private Sub AddGenreToMusicVideo(ByVal idMVideo As Long, ByVal idGenre As Long)
        AddToLinkTable("genrelinkmusicvideo", "idGenre", idGenre, "idMVideo", idMVideo)
    End Sub

    Private Sub AddGenreToTvShow(ByVal idShow As Long, ByVal idGenre As Long)
        AddToLinkTable("genrelinktvshow", "idGenre", idGenre, "idShow", idShow)
    End Sub
    ''' <summary>
    ''' add an actor to an actorlink* table
    ''' </summary>
    ''' <param name="table">link table name without "actorlink" prefix("episode", "movie" or "tvshow")</param>
    ''' <param name="actorID">ID of actor in table actors</param>
    ''' <param name="field">field name in <c>table</c> without "id" prefix("Episode", "Movie" or "Show")</param>
    ''' <param name="secondID">ID of <c>field</c> </param>
    ''' <param name="role">actors role</param>
    ''' <param name="order">actors order</param>
    ''' <returns><c>True</c> if the actor link has been created, <c>False</c> otherwise</returns>
    ''' <remarks></remarks>
    Private Function AddLinkToActor(ByVal table As String, ByVal actorID As Long, ByVal field As String, _
                                    ByVal secondID As Long, ByVal role As String, _
                                    ByVal order As Long) As Boolean
        Dim doesExist As Boolean = False

        Using SQLcommand_select_actorlink As SQLite.SQLiteCommand = _myvideosDBConn.CreateCommand()
            SQLcommand_select_actorlink.CommandText = String.Format("SELECT * FROM actorlink{0} WHERE idActor={1} AND id{2}={3};", table, actorID, field, secondID)
            Using SQLreader As SQLite.SQLiteDataReader = SQLcommand_select_actorlink.ExecuteReader()
                While SQLreader.Read
                    doesExist = True
                    Exit While
                End While
            End Using
        End Using

        If Not doesExist Then
            Using SQLcommand_insert_actorlink As SQLite.SQLiteCommand = _myvideosDBConn.CreateCommand()
                SQLcommand_insert_actorlink.CommandText = String.Format("INSERT INTO actorlink{0} (idActor, id{1}, strRole, iOrder) VALUES ({2},{3},?,{4})", table, field, actorID, secondID, order)
                Dim par_insert_actors_strRole As SQLite.SQLiteParameter = SQLcommand_insert_actorlink.Parameters.Add("par_insert_actors_strRole", DbType.String, 0, "strRole")
                par_insert_actors_strRole.Value = role
                SQLcommand_insert_actorlink.ExecuteNonQuery()
            End Using
            Return True
        Else
            Return False
        End If
    End Function

    Private Function AddSet(ByVal strSet As String) As Long
        If String.IsNullOrEmpty(strSet) Then Return -1
        Return AddToTable("sets", "idSet", "strSet", strSet)
    End Function

    Private Function AddStudio(ByVal strStudio As String) As Long
        If String.IsNullOrEmpty(strStudio) Then Return -1
        Return AddToTable("studio", "idStudio", "strStudio", strStudio)
    End Function

    Private Sub AddStudioToMovie(ByVal idMovie As Long, ByVal idStudio As Long)
        AddToLinkTable("studiolinkmovie", "idStudio", idStudio, "idMovie", idMovie)
    End Sub

    Private Sub AddStudioToTvShow(ByVal idShow As Long, ByVal idStudio As Long)
        AddToLinkTable("studiolinktvshow", "idStudio", idStudio, "idShow", idShow)
    End Sub

    Private Function AddTag(ByVal strTag As String) As Long
        If String.IsNullOrEmpty(strTag) Then Return -1
        Return AddToTable("tag", "idTag", "strTag", strTag)
    End Function

    Private Function AddToLinkTable(ByVal table As String, ByVal firstField As String, ByVal firstID As Long, ByVal secondField As String, ByVal secondID As Long, _
                               Optional ByVal typeField As String = "", Optional ByVal type As String = "") As Boolean
        Dim doesExist As Boolean = False

        Using SQLcommand_select As SQLite.SQLiteCommand = _myvideosDBConn.CreateCommand()
            SQLcommand_select.CommandText = String.Format("SELECT * FROM {0} WHERE {1}={2} AND {3}={4}", table, firstField, firstID, secondField, secondID)
            If Not String.IsNullOrEmpty(typeField) AndAlso Not String.IsNullOrEmpty(type) Then
                SQLcommand_select.CommandText = String.Concat(SQLcommand_select.CommandText, String.Format(" AND {0}='{1}'", typeField, type))
            End If
            Using SQLreader As SQLite.SQLiteDataReader = SQLcommand_select.ExecuteReader()
                While SQLreader.Read
                    doesExist = True
                    Exit While
                End While
            End Using
        End Using

        If Not doesExist Then
            Using SQLcommand_insert As SQLite.SQLiteCommand = _myvideosDBConn.CreateCommand()
                If String.IsNullOrEmpty(typeField) AndAlso String.IsNullOrEmpty(type) Then
                    SQLcommand_insert.CommandText = String.Format("INSERT INTO {0} ({1},{2}) VALUES ({3},{4})", table, firstField, secondField, firstID, secondID)
                Else
                    SQLcommand_insert.CommandText = String.Format("INSERT INTO {0} ({1},{2},{3}) VALUES ({4},{5},'{6}')", table, firstField, secondField, typeField, firstID, secondID, type)
                End If
                SQLcommand_insert.ExecuteNonQuery()
                Return True
            End Using
        Else
            Return False
        End If
    End Function

    Private Function AddToTable(ByVal table As String, ByVal firstField As String, ByVal secondField As String, ByVal value As String) As Long
        Dim doesExist As Boolean = False
        Dim ID As Long = -1

        Using SQLcommand_select As SQLite.SQLiteCommand = _myvideosDBConn.CreateCommand()
            SQLcommand_select.CommandText = String.Format("SELECT {0} FROM {1} WHERE {2} LIKE ?", firstField, table, secondField)
            Dim par_select_secondField As SQLite.SQLiteParameter = SQLcommand_select.Parameters.Add("par_select_secondField", DbType.String, 0, secondField)
            par_select_secondField.Value = value
            Using SQLreader As SQLite.SQLiteDataReader = SQLcommand_select.ExecuteReader()
                While SQLreader.Read
                    doesExist = True
                    ID = CInt(SQLreader(firstField))
                    Exit While
                End While
            End Using
        End Using

        If Not doesExist Then
            Using SQLcommand_insert As SQLite.SQLiteCommand = _myvideosDBConn.CreateCommand()
                SQLcommand_insert.CommandText = String.Format("INSERT INTO {0} ({1}, {2}) VALUES (NULL, ?); SELECT LAST_INSERT_ROWID() FROM {0};", table, firstField, secondField)
                Dim par_insert_secondField As SQLite.SQLiteParameter = SQLcommand_insert.Parameters.Add("par_insert_secondField", DbType.String, 0, secondField)
                par_insert_secondField.Value = value
                ID = CInt(SQLcommand_insert.ExecuteScalar())
            End Using
        End If

        Return ID
    End Function

    Private Sub AddTagToItem(ByVal idMedia As Long, ByVal idTag As Long, ByVal type As String)
        If String.IsNullOrEmpty(type) Then Return
        AddToLinkTable("taglinks", "idTag", idTag, "idMedia", idMedia, "media_type", type)
    End Sub

    Private Sub AddWriterToEpisode(ByVal idEpisode As Long, ByVal idWriter As Long)
        AddToLinkTable("writerlinkepisode", "idWriter", idWriter, "idEpisode", idEpisode)
    End Sub

    Private Sub AddWriterToMovie(ByVal idMovie As Long, ByVal idWriter As Long)
        AddToLinkTable("writerlinkmovie", "idWriter", idWriter, "idMovie", idMovie)
    End Sub

    Private Sub SetArtForItem(ByVal mediaId As Long, ByVal MediaType As String, ByVal artType As String, ByVal url As String)
        Dim doesExist As Boolean = False
        Dim ID As Long = -1
        Dim oldURL As String = String.Empty

        Using SQLcommand_select_art As SQLite.SQLiteCommand = _myvideosDBConn.CreateCommand()
            SQLcommand_select_art.CommandText = String.Format("SELECT art_id, url FROM art WHERE media_id={0} AND media_type='{1}' AND type='{2}'", mediaId, MediaType, artType)
            Using SQLreader As SQLite.SQLiteDataReader = SQLcommand_select_art.ExecuteReader()
                While SQLreader.Read
                    doesExist = True
                    ID = CInt(SQLreader("art_id"))
                    oldURL = SQLreader("url").ToString
                    Exit While
                End While
            End Using
        End Using

        If Not doesExist Then
            Using SQLcommand_insert_art As SQLite.SQLiteCommand = _myvideosDBConn.CreateCommand()
                SQLcommand_insert_art.CommandText = String.Format("INSERT INTO art(media_id, media_type, type, url) VALUES ({0}, '{1}', '{2}', ?)", mediaId, MediaType, artType)
                Dim par_insert_art_url As SQLite.SQLiteParameter = SQLcommand_insert_art.Parameters.Add("par_insert_art_url", DbType.String, 0, "url")
                par_insert_art_url.Value = url
                SQLcommand_insert_art.ExecuteNonQuery()
            End Using
        Else
            If Not url = oldURL Then
                Using SQLcommand_update_art As SQLite.SQLiteCommand = _myvideosDBConn.CreateCommand()
                    SQLcommand_update_art.CommandText = String.Format("UPDATE art SET url=(?) WHERE art_id={0}", ID)
                    Dim par_update_art_url As SQLite.SQLiteParameter = SQLcommand_update_art.Parameters.Add("par_update_art_url", DbType.String, 0, "url")
                    par_update_art_url.Value = url
                    SQLcommand_update_art.ExecuteNonQuery()
                End Using
            End If
        End If
    End Sub

    Private Function GetArtForItem(ByVal mediaId As Long, ByVal MediaType As String, ByVal artType As String) As String
        Using SQLcommand As SQLite.SQLiteCommand = _myvideosDBConn.CreateCommand()
            SQLcommand.CommandText = String.Format("SELECT url FROM art WHERE media_id={0} AND media_type='{1}' AND type='{2}'", mediaId, MediaType, artType)
            Using SQLreader As SQLite.SQLiteDataReader = SQLcommand.ExecuteReader()
                While SQLreader.Read
                    Return SQLreader("url").ToString
                    Exit While
                End While
            End Using
        End Using
        Return String.Empty
    End Function

    ''' <summary>
    ''' Iterates db entries to check if the paths to the movie or TV files are valid. 
    ''' If not, remove all entries pertaining to the movie.
    ''' </summary>
    ''' <param name="CleanMovies">If <c>True</c>, process the movie files</param>
    ''' <param name="CleanTV">If <c>True</c>, process the TV files</param>
    ''' <param name="source">Optional. If provided, only process entries from that named source.</param>
    ''' <remarks></remarks>
    Public Sub Clean(ByVal CleanMovies As Boolean, ByVal CleanMovieSets As Boolean, ByVal CleanTV As Boolean, Optional ByVal source As String = "")
        Dim fInfo As FileInfo
        Dim tPath As String = String.Empty
        Dim sPath As String = String.Empty

        Using SQLtransaction As SQLite.SQLiteTransaction = _myvideosDBConn.BeginTransaction()
            If CleanMovies Then
                logger.Info("Cleaning movies started")
                Dim MoviePaths As List(Of String) = GetMoviePaths()
                MoviePaths.Sort()

                'get a listing of sources and their recursive properties
                Dim SourceList As New List(Of SourceHolder)
                Dim tSource As SourceHolder

                Using SQLcommand As SQLite.SQLiteCommand = _myvideosDBConn.CreateCommand()
                    If source = String.Empty Then
                        SQLcommand.CommandText = "SELECT Path, Name, Recursive, Single FROM sources;"
                    Else
                        SQLcommand.CommandText = String.Format("SELECT Path, Name, Recursive, Single FROM sources WHERE Name=""{0}""", source)
                    End If
                    Using SQLreader As SQLite.SQLiteDataReader = SQLcommand.ExecuteReader()
                        While SQLreader.Read
                            SourceList.Add(New SourceHolder With {.Name = SQLreader("Name").ToString, .Path = SQLreader("Path").ToString, .Recursive = Convert.ToBoolean(SQLreader("Recursive")), .isSingle = Convert.ToBoolean(SQLreader("Single"))})
                        End While
                    End Using
                End Using

                Using SQLcommand As SQLite.SQLiteCommand = _myvideosDBConn.CreateCommand()
                    If source = String.Empty Then
                        SQLcommand.CommandText = "SELECT MoviePath, idMovie, Source, Type FROM movie ORDER BY MoviePath DESC;"
                    Else
                        SQLcommand.CommandText = String.Format("SELECT MoviePath, idMovie, Source, Type FROM movie WHERE Source = ""{0}"" ORDER BY MoviePath DESC;", source)
                    End If
                    Using SQLReader As SQLite.SQLiteDataReader = SQLcommand.ExecuteReader()
                        While SQLReader.Read
                            If Not File.Exists(SQLReader("MoviePath").ToString) OrElse Not Master.eSettings.FileSystemValidExts.Contains(Path.GetExtension(SQLReader("MoviePath").ToString).ToLower) OrElse _
                                Master.ExcludeDirs.Exists(Function(s) SQLReader("MoviePath").ToString.ToLower.StartsWith(s.ToLower)) Then
                                MoviePaths.Remove(SQLReader("MoviePath").ToString)
                                Master.DB.DeleteMovieFromDB(Convert.ToInt64(SQLReader("idMovie")), True)
                            ElseIf Master.eSettings.MovieSkipLessThan > 0 Then
                                fInfo = New FileInfo(SQLReader("MoviePath").ToString)
                                If ((Not Master.eSettings.MovieSkipStackedSizeCheck OrElse Not StringUtils.IsStacked(fInfo.Name)) AndAlso fInfo.Length < Master.eSettings.MovieSkipLessThan * 1048576) Then
                                    MoviePaths.Remove(SQLReader("MoviePath").ToString)
                                    Master.DB.DeleteMovieFromDB(Convert.ToInt64(SQLReader("idMovie")), True)
                                End If
                            Else
                                tSource = SourceList.OrderByDescending(Function(s) s.Path).FirstOrDefault(Function(s) s.Name = SQLReader("Source").ToString)
                                If tSource IsNot Nothing Then
                                    If Directory.GetParent(Directory.GetParent(SQLReader("MoviePath").ToString).FullName).Name.ToLower = "bdmv" Then
                                        tPath = Directory.GetParent(Directory.GetParent(SQLReader("MoviePath").ToString).FullName).FullName
                                    Else
                                        tPath = Directory.GetParent(SQLReader("MoviePath").ToString).FullName
                                    End If
                                    sPath = FileUtils.Common.GetDirectory(tPath).ToLower
                                    If tSource.Recursive = False AndAlso tPath.Length > tSource.Path.Length AndAlso If(sPath = "video_ts" OrElse sPath = "bdmv", tPath.Substring(tSource.Path.Length).Trim(Path.DirectorySeparatorChar).Split(Path.DirectorySeparatorChar).Count > 2, tPath.Substring(tSource.Path.Length).Trim(Path.DirectorySeparatorChar).Split(Path.DirectorySeparatorChar).Count > 1) Then
                                        MoviePaths.Remove(SQLReader("MoviePath").ToString)
                                        Master.DB.DeleteMovieFromDB(Convert.ToInt64(SQLReader("idMovie")), True)
                                    ElseIf Not Convert.ToBoolean(SQLReader("Type")) AndAlso tSource.isSingle AndAlso Not MoviePaths.Where(Function(s) SQLReader("MoviePath").ToString.ToLower.StartsWith(tSource.Path.ToLower)).Count = 1 Then
                                        MoviePaths.Remove(SQLReader("MoviePath").ToString)
                                        Master.DB.DeleteMovieFromDB(Convert.ToInt64(SQLReader("idMovie")), True)
                                    End If
                                Else
                                    'orphaned
                                    MoviePaths.Remove(SQLReader("MoviePath").ToString)
                                    Master.DB.DeleteMovieFromDB(Convert.ToInt64(SQLReader("idMovie")), True)
                                End If
                            End If
                        End While
                    End Using
                End Using
                logger.Info("Cleaning movies done")
            End If

            If CleanMovieSets Then
                logger.Info("Cleaning moviesets started")
                Using SQLcommand As SQLite.SQLiteCommand = _myvideosDBConn.CreateCommand()
                    SQLcommand.CommandText = "SELECT sets.idSet, COUNT(MoviesSets.MovieID) AS 'Count' FROM sets LEFT OUTER JOIN MoviesSets ON sets.idSet = MoviesSets.SetID GROUP BY sets.idSet ORDER BY sets.idSet COLLATE NOCASE;"
                    Using SQLreader As SQLite.SQLiteDataReader = SQLcommand.ExecuteReader()
                        While SQLreader.Read
                            If Convert.ToInt64(SQLreader("Count")) = 0 Then
                                Master.DB.DeleteMovieSetFromDB(Convert.ToInt64(SQLreader("idSet")), True)
                            End If
                        End While
                    End Using
                End Using
                logger.Info("Cleaning moviesets done")
            End If

            If CleanTV Then
                logger.Info("Cleaning tv shows started")
                Using SQLcommand As SQLite.SQLiteCommand = _myvideosDBConn.CreateCommand()
                    If String.IsNullOrEmpty(source) Then
                        SQLcommand.CommandText = "SELECT TVEpPath FROM TVEpPaths;"
                    Else
                        SQLcommand.CommandText = String.Format("SELECT TVEpPath FROM TVEpPaths INNER JOIN episode ON TVEpPaths.ID = episode.TVEpPathID WHERE episode.Source =""{0}"";", source)
                    End If

                    Using SQLReader As SQLite.SQLiteDataReader = SQLcommand.ExecuteReader()
                        While SQLReader.Read
                            If Not File.Exists(SQLReader("TVEpPath").ToString) OrElse Not Master.eSettings.FileSystemValidExts.Contains(Path.GetExtension(SQLReader("TVEpPath").ToString).ToLower) OrElse _
                                Master.ExcludeDirs.Exists(Function(s) SQLReader("TVEpPath").ToString.ToLower.StartsWith(s.ToLower)) Then
                                Master.DB.DeleteTVEpFromDBByPath(SQLReader("TVEpPath").ToString, False, True)
                            End If
                        End While
                    End Using

                    logger.Info("Removing tvshows with no more existing local episodes")
                    SQLcommand.CommandText = "DELETE FROM tvshow WHERE NOT EXISTS (SELECT episode.idShow FROM episode WHERE episode.idShow = tvshow.idShow AND episode.Missing = 0);"
                    SQLcommand.ExecuteNonQuery()
                    logger.Info("Removing episodes with no more existing tvshows")
                    SQLcommand.CommandText = "DELETE FROM episode WHERE idShow NOT IN (SELECT idShow FROM tvshow);"
                    SQLcommand.ExecuteNonQuery()
                    logger.Info("Removing orphaned episode paths")
                    SQLcommand.CommandText = "DELETE FROM TVEpPaths WHERE NOT EXISTS (SELECT episode.TVEpPathID FROM episode WHERE episode.TVEpPathID = TVEpPaths.ID AND episode.Missing = 0)"
                    SQLcommand.ExecuteNonQuery()
                End Using

                logger.Info("Removing seasons with no more existing episodes")
                CleanSeasons(True)
                logger.Info("Cleaning tv shows done")
            End If

            'global cleaning
            logger.Info("Cleaning global tables started")
            Using SQLcommand As SQLite.SQLiteCommand = _myvideosDBConn.CreateCommand()
                'clean all link tables
                logger.Info("Cleaning actorlinkepisode table")
                SQLcommand.CommandText = "DELETE FROM actorlinkepisode WHERE NOT EXISTS (SELECT 1 FROM episode WHERE episode.idEpisode = actorlinkepisode.idEpisode)"
                SQLcommand.ExecuteNonQuery()
                logger.Info("Cleaning actorlinkmovie table")
                SQLcommand.CommandText = "DELETE FROM actorlinkmovie WHERE NOT EXISTS (SELECT 1 FROM movie WHERE movie.idMovie = actorlinkmovie.idMovie)"
                SQLcommand.ExecuteNonQuery()
                logger.Info("Cleaning actorlinktvshow table")
                SQLcommand.CommandText = "DELETE FROM actorlinktvshow WHERE NOT EXISTS (SELECT 1 FROM tvshow WHERE tvshow.idShow = actorlinktvshow.idShow)"
                SQLcommand.ExecuteNonQuery()
                logger.Info("Cleaning countrylinkmovie table")
                SQLcommand.CommandText = "DELETE FROM countrylinkmovie WHERE idMovie NOT IN (SELECT idMovie FROM movie);"
                SQLcommand.ExecuteNonQuery()
                logger.Info("Cleaning directorlinkepisode table")
                SQLcommand.CommandText = "DELETE FROM directorlinkepisode WHERE idEpisode NOT IN (SELECT idEpisode FROM episode);"
                SQLcommand.ExecuteNonQuery()
                logger.Info("Cleaning directorlinkmovie table")
                SQLcommand.CommandText = "DELETE FROM directorlinkmovie WHERE idMovie NOT IN (SELECT idMovie FROM movie);"
                SQLcommand.ExecuteNonQuery()
                logger.Info("Cleaning directorlinktvshow table")
                SQLcommand.CommandText = "DELETE FROM directorlinktvshow WHERE idShow NOT IN (SELECT idShow FROM tvshow);"
                SQLcommand.ExecuteNonQuery()
                logger.Info("Cleaning genrelinkmovie table")
                SQLcommand.CommandText = "DELETE FROM genrelinkmovie WHERE idMovie NOT IN (SELECT idMovie FROM movie);"
                SQLcommand.ExecuteNonQuery()
                logger.Info("Cleaning genrelinktvshow table")
                SQLcommand.CommandText = "DELETE FROM genrelinktvshow WHERE idShow NOT IN (SELECT idShow FROM tvshow);"
                SQLcommand.ExecuteNonQuery()
                logger.Info("Cleaning MoviesSets table")
                SQLcommand.CommandText = "DELETE FROM MoviesSets WHERE MovieID NOT IN (SELECT idMovie FROM movie);"
                SQLcommand.ExecuteNonQuery()
                logger.Info("Cleaning studiolinkmovie table")
                SQLcommand.CommandText = "DELETE FROM studiolinkmovie WHERE idMovie NOT IN (SELECT idMovie FROM movie);"
                SQLcommand.ExecuteNonQuery()
                logger.Info("Cleaning studiolinktvshow table")
                SQLcommand.CommandText = "DELETE FROM studiolinktvshow WHERE idShow NOT IN (SELECT idShow FROM tvshow);"
                SQLcommand.ExecuteNonQuery()
                logger.Info("Cleaning writerlinkepisode table")
                SQLcommand.CommandText = "DELETE FROM writerlinkepisode WHERE idEpisode NOT IN (SELECT idEpisode FROM episode);"
                SQLcommand.ExecuteNonQuery()
                logger.Info("Cleaning writerlinkmovie table")
                SQLcommand.CommandText = "DELETE FROM writerlinkmovie WHERE idMovie NOT IN (SELECT idMovie FROM movie);"
                SQLcommand.ExecuteNonQuery()
                'clean all main tables
                logger.Info("Cleaning genre table")
                SQLcommand.CommandText = String.Concat("DELETE FROM genre ", _
                                                       "WHERE NOT EXISTS (SELECT 1 FROM genrelinkmovie WHERE genrelinkmovie.idGenre = genre.idGenre) ", _
                                                         "AND NOT EXISTS (SELECT 1 FROM genrelinktvshow WHERE genrelinktvshow.idGenre = genre.idGenre)")
                SQLcommand.ExecuteNonQuery()
                logger.Info("Cleaning actor table of actors, directors and writers")
                SQLcommand.CommandText = String.Concat("DELETE FROM actors ", _
                                                       "WHERE NOT EXISTS (SELECT 1 FROM actorlinkmovie WHERE actorlinkmovie.idActor = actors.idActor) ", _
                                                         "AND NOT EXISTS (SELECT 1 FROM directorlinkmovie WHERE directorlinkmovie.idDirector = actors.idActor) ", _
                                                         "AND NOT EXISTS (SELECT 1 FROM writerlinkmovie WHERE writerlinkmovie.idWriter = actors.idActor) ", _
                                                         "AND NOT EXISTS (SELECT 1 FROM actorlinktvshow WHERE actorlinktvshow.idActor = actors.idActor) ", _
                                                         "AND NOT EXISTS (SELECT 1 FROM actorlinkepisode WHERE actorlinkepisode.idActor = actors.idActor) ", _
                                                         "AND NOT EXISTS (SELECT 1 FROM directorlinktvshow WHERE directorlinktvshow.idDirector = actors.idActor) ", _
                                                         "AND NOT EXISTS (SELECT 1 FROM directorlinkepisode WHERE directorlinkepisode.idDirector = actors.idActor) ", _
                                                         "AND NOT EXISTS (SELECT 1 FROM writerlinkepisode WHERE writerlinkepisode.idWriter = actors.idActor)")
                SQLcommand.ExecuteNonQuery()
                logger.Info("Cleaning country table")
                SQLcommand.CommandText = "DELETE FROM country WHERE NOT EXISTS (SELECT 1 FROM countrylinkmovie WHERE countrylinkmovie.idCountry = country.idCountry)"
                SQLcommand.ExecuteNonQuery()
                logger.Info("Cleaning genre table")
                SQLcommand.CommandText = String.Concat("DELETE FROM genre ", _
                                                       "WHERE NOT EXISTS (SELECT 1 FROM genrelinkmovie WHERE genrelinkmovie.idGenre = genre.idGenre) ", _
                                                         "AND NOT EXISTS (SELECT 1 FROM genrelinktvshow WHERE genrelinktvshow.idGenre = genre.idGenre)")
                SQLcommand.ExecuteNonQuery()
                logger.Info("Cleaning studio table")
                SQLcommand.CommandText = String.Concat("DELETE FROM studio ", _
                                                       "WHERE NOT EXISTS (SELECT 1 FROM studiolinkmovie WHERE studiolinkmovie.idStudio = studio.idStudio) ", _
                                                         "AND NOT EXISTS (SELECT 1 FROM studiolinktvshow WHERE studiolinktvshow.idStudio = studio.idStudio)")
                SQLcommand.ExecuteNonQuery()
            End Using
            logger.Info("Cleaning global tables done")

            SQLtransaction.Commit()
            logger.Info("Cleaning videodatabase done")
        End Using

        ' Housekeeping - consolidate and pack database using vacuum command http://www.sqlite.org/lang_vacuum.html
        Using SQLcommand As SQLite.SQLiteCommand = _myvideosDBConn.CreateCommand()
            SQLcommand.CommandText = "VACUUM;"
            SQLcommand.ExecuteNonQuery()
        End Using
    End Sub
    ''' <summary>
    ''' Remove from the database the TV seasons for which there are no episodes defined
    ''' </summary>
    ''' <param name="BatchMode">If <c>False</c>, the action is wrapped in a transaction</param>
    ''' <remarks></remarks>
    Public Sub CleanSeasons(Optional ByVal BatchMode As Boolean = False)
        Dim SQLTrans As SQLite.SQLiteTransaction = Nothing

        If Not BatchMode Then SQLTrans = Master.DB.MyVideosDBConn.BeginTransaction()
        Using SQLCommand As SQLite.SQLiteCommand = _myvideosDBConn.CreateCommand()
            SQLCommand.CommandText = "DELETE FROM seasons WHERE NOT EXISTS (SELECT episode.Season FROM episode WHERE episode.Season = seasons.Season AND episode.idShow = seasons.idShow) AND seasons.Season <> 999"
            SQLCommand.ExecuteNonQuery()
        End Using
        If Not BatchMode Then SQLTrans.Commit()
        SQLTrans = Nothing

        If SQLTrans IsNot Nothing Then SQLTrans.Dispose()
    End Sub
    ''' <summary>
    ''' Remove the New flag from database entries (movies, tvshow, seasons, episode)
    ''' </summary>
    ''' <remarks>
    ''' 2013/12/13 Dekker500 - Check that MediaDBConn IsNot Nothing before continuing, 
    '''                        otherwise shutdown after a failed startup (before DB initialized) 
    '''                        will trow exception
    ''' </remarks>
    Public Sub ClearNew()
        If (Master.DB.MyVideosDBConn IsNot Nothing) Then
            Using SQLtransaction As SQLite.SQLiteTransaction = Master.DB.MyVideosDBConn.BeginTransaction()
                Using SQLcommand As SQLite.SQLiteCommand = _myvideosDBConn.CreateCommand()
                    SQLcommand.CommandText = "UPDATE movie SET New = (?);"
                    Dim parNew As SQLite.SQLiteParameter = SQLcommand.Parameters.Add("parNew", DbType.Boolean, 0, "New")
                    parNew.Value = False
                    SQLcommand.ExecuteNonQuery()
                End Using
                Using SQLcommand As SQLite.SQLiteCommand = _myvideosDBConn.CreateCommand()
                    SQLcommand.CommandText = "UPDATE sets SET New = (?);"
                    Dim parNew As SQLite.SQLiteParameter = SQLcommand.Parameters.Add("parNew", DbType.Boolean, 0, "New")
                    parNew.Value = False
                    SQLcommand.ExecuteNonQuery()
                End Using
                Using SQLShowcommand As SQLite.SQLiteCommand = _myvideosDBConn.CreateCommand()
                    SQLShowcommand.CommandText = "UPDATE tvshow SET New = (?);"
                    Dim parShowNew As SQLite.SQLiteParameter = SQLShowcommand.Parameters.Add("parShowNew", DbType.Boolean, 0, "New")
                    parShowNew.Value = False
                    SQLShowcommand.ExecuteNonQuery()
                End Using
                Using SQLSeasoncommand As SQLite.SQLiteCommand = _myvideosDBConn.CreateCommand()
                    SQLSeasoncommand.CommandText = "UPDATE seasons SET New = (?);"
                    Dim parSeasonNew As SQLite.SQLiteParameter = SQLSeasoncommand.Parameters.Add("parSeasonNew", DbType.Boolean, 0, "New")
                    parSeasonNew.Value = False
                    SQLSeasoncommand.ExecuteNonQuery()
                End Using
                Using SQLEpcommand As SQLite.SQLiteCommand = _myvideosDBConn.CreateCommand()
                    SQLEpcommand.CommandText = "UPDATE episode SET New = (?);"
                    Dim parEpNew As SQLite.SQLiteParameter = SQLEpcommand.Parameters.Add("parEpNew", DbType.Boolean, 0, "New")
                    parEpNew.Value = False
                    SQLEpcommand.ExecuteNonQuery()
                End Using
                SQLtransaction.Commit()
            End Using
        End If
    End Sub
    ''' <summary>
    ''' Close the databases
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub CloseMyVideosDB()
        CloseDatabase(_myvideosDBConn)
        'CloseDatabase(_jobsDBConn)

        If _myvideosDBConn IsNot Nothing Then
            _myvideosDBConn = Nothing
        End If
        'If _jobsDBConn IsNot Nothing Then
        '    _jobsDBConn = Nothing
        'End If
    End Sub
    ''' <summary>
    ''' Perform the actual closing of the given database connection
    ''' </summary>
    ''' <param name="connection">Database connection on which to perform closing activities</param>
    ''' <remarks></remarks>
    Protected Sub CloseDatabase(ByRef connection As SQLiteConnection)
        If connection Is Nothing Then
            Return
        End If

        Try
            ' Housekeeping - consolidate and pack database using vacuum command http://www.sqlite.org/lang_vacuum.html
            Using command As SQLiteCommand = connection.CreateCommand()
                command.CommandText = "VACUUM;"
                command.ExecuteNonQuery()
            End Using

            connection.Close()
        Catch ex As Exception
            logger.Error(New StackFrame().GetMethod().Name & Convert.ToChar(Windows.Forms.Keys.Tab) & "There was a problem closing the media database.", ex)
        Finally
            connection.Dispose()
        End Try
    End Sub
    ''' <summary>
    ''' Creates the connection to the MediaDB database
    ''' </summary>
    ''' <returns><c>True</c> if the database needed to be created (is new), <c>False</c> otherwise</returns>
    ''' <remarks></remarks>
    Public Function ConnectMyVideosDB() As Boolean

        'set database version
        Dim MyVideosDBVersion As Integer = 18

        'set database filename
        Dim MyVideosDB As String = String.Format("MyVideos{0}.emm", MyVideosDBVersion)

        'TODO Warning - This method should be marked as Protected and references re-directed to Connect() above
        If _myvideosDBConn IsNot Nothing Then
            Return False
            'Throw New InvalidOperationException("A database connection is already open, can't open another.")
        End If

        Dim MyVideosDBFile As String = FileUtils.Common.ReturnSettingsFile("Settings", MyVideosDB)

        'check if an older DB version still exist
        If Not File.Exists(MyVideosDBFile) Then
            For i As Integer = MyVideosDBVersion - 1 To 2 Step -1
                Dim oldMyVideosDB As String = String.Format("MyVideos{0}.emm", i)
                Dim oldMyVideosDBFile As String = FileUtils.Common.ReturnSettingsFile("Settings", oldMyVideosDB)
                If File.Exists(oldMyVideosDBFile) Then
                    Master.fLoading.SetLoadingMesg(Master.eLang.GetString(1356, "Upgrading database..."))
                    PatchDatabase_MyVideos(oldMyVideosDBFile, MyVideosDBFile, i, MyVideosDBVersion)
                    Exit For
                End If
            Next
        End If

        Dim isNew As Boolean = Not File.Exists(MyVideosDBFile)

        Try
            _myvideosDBConn = New SQLiteConnection(String.Format(_connStringTemplate, MyVideosDBFile))
            _myvideosDBConn.Open()
        Catch ex As Exception
            logger.Error(New StackFrame().GetMethod().Name & Convert.ToChar(Windows.Forms.Keys.Tab) & "Unable to open media database connection.", ex)
        End Try

        Try
            If isNew Then
                Dim sqlCommand As String = File.ReadAllText(FileUtils.Common.ReturnSettingsFile("DB", String.Format("MyVideosDBSQL_v{0}.txt", MyVideosDBVersion)))

                Using transaction As SQLite.SQLiteTransaction = _myvideosDBConn.BeginTransaction()
                    Using command As SQLite.SQLiteCommand = _myvideosDBConn.CreateCommand()
                        command.CommandText = sqlCommand
                        command.ExecuteNonQuery()
                    End Using
                    transaction.Commit()
                End Using
            End If
        Catch ex As Exception
            logger.Error(New StackFrame().GetMethod().Name & Convert.ToChar(Windows.Forms.Keys.Tab) & "Error creating database", ex)
            File.Delete(MyVideosDBFile)
        End Try
        Return isNew
    End Function

    ''' <summary>
    ''' Remove all information related to a movie from the database.
    ''' </summary>
    ''' <param name="ID">ID of the movie to remove, as stored in the database.</param>
    ''' <param name="BatchMode">Is this function already part of a transaction?</param>
    ''' <returns>True if successful, false if deletion failed.</returns>
    Public Function DeleteMovieFromDB(ByVal ID As Long, Optional ByVal BatchMode As Boolean = False) As Boolean
        Try
            Dim SQLtransaction As SQLite.SQLiteTransaction = Nothing
            If Not BatchMode Then SQLtransaction = _myvideosDBConn.BeginTransaction()
            Using SQLcommand As SQLite.SQLiteCommand = _myvideosDBConn.CreateCommand()
                SQLcommand.CommandText = String.Concat("DELETE FROM movie WHERE idMovie = ", ID, ";")
                SQLcommand.ExecuteNonQuery()
            End Using
            If Not BatchMode Then SQLtransaction.Commit()
        Catch ex As Exception
            logger.Error(New StackFrame().GetMethod().Name, ex)
            Return False
        End Try
        Return True
    End Function
    ''' <summary>
    ''' Remove all information related to a movieset from the database.
    ''' </summary>
    ''' <param name="ID">ID of the movieset to remove, as stored in the database.</param>
    ''' <param name="BatchMode">Is this function already part of a transaction?</param>
    ''' <returns>True if successful, false if deletion failed.</returns>
    Public Function DeleteMovieSetFromDB(ByVal ID As Long, Optional ByVal BatchMode As Boolean = False) As Boolean
        Try
            'first get a list of all movies in the movieset to remove the movieset information from NFO
            Dim moviesToSave As New List(Of Structures.DBMovie)

            Dim SQLtransaction As SQLite.SQLiteTransaction = Nothing
            If Not BatchMode Then SQLtransaction = _myvideosDBConn.BeginTransaction()
            Using SQLcommand As SQLite.SQLiteCommand = _myvideosDBConn.CreateCommand()
                SQLcommand.CommandText = String.Concat("SELECT MovieID FROM MoviesSets ", _
                                                       "WHERE SetID = ", ID, ";")
                Using SQLreader As SQLite.SQLiteDataReader = SQLcommand.ExecuteReader()
                    While SQLreader.Read
                        Dim movie As New Structures.DBMovie
                        If Not DBNull.Value.Equals(SQLreader("MovieID")) Then movie = LoadMovieFromDB(Convert.ToInt64(SQLreader("MovieID")))
                        moviesToSave.Add(movie)
                    End While
                End Using
            End Using

            'remove the movieset from movie and write new movie NFOs
            If moviesToSave.Count > 0 Then
                For Each movie In moviesToSave
                    movie.Movie.RemoveSet(ID)
                    SaveMovieToDB(movie, False, BatchMode, True)
                Next
            End If

            'delete all movieset images and if this setting is enabled
            If Master.eSettings.MovieSetCleanFiles Then
                Dim tmpImage As New Images
                Dim MovieSet As Structures.DBMovieSet = Master.DB.LoadMovieSetFromDB(ID)
                tmpImage.DeleteMovieSetBanner(MovieSet)
                tmpImage.DeleteMovieSetClearArt(MovieSet)
                tmpImage.DeleteMovieSetClearLogo(MovieSet)
                tmpImage.DeleteMovieSetDiscArt(MovieSet)
                tmpImage.DeleteMovieSetFanart(MovieSet)
                tmpImage.DeleteMovieSetLandscape(MovieSet)
                tmpImage.DeleteMovieSetPoster(MovieSet)
            End If

            Using SQLcommand As SQLite.SQLiteCommand = _myvideosDBConn.CreateCommand()
                SQLcommand.CommandText = String.Concat("SELECT MovieID FROM MoviesSets ", _
                                                       "WHERE SetID = ", ID, ";")
                Using SQLreader As SQLite.SQLiteDataReader = SQLcommand.ExecuteReader()
                    While SQLreader.Read
                        Dim movie As New Structures.DBMovie
                        If Not DBNull.Value.Equals(SQLreader("MovieID")) Then movie = LoadMovieFromDB(Convert.ToInt64(SQLreader("MovieID")))
                        moviesToSave.Add(movie)
                    End While
                End Using
            End Using

            'remove the movieset and still existing moviessets entries
            Using SQLcommand As SQLite.SQLiteCommand = _myvideosDBConn.CreateCommand()
                SQLcommand.CommandText = String.Concat("DELETE FROM sets WHERE idSet = ", ID, ";")
                SQLcommand.ExecuteNonQuery()
            End Using
            If Not BatchMode Then SQLtransaction.Commit()
        Catch ex As Exception
            logger.Error(New StackFrame().GetMethod().Name, ex)
            Return False
        End Try
        Return True
    End Function

    ''' <summary>
    ''' Remove all information related to a tag from the database.
    ''' </summary>
    ''' <param name="ID">Internal TagID of the tag to remove, as stored in the database.</param>
    ''' <param name="Mode">1=tag of a movie, 2=tag of a show</param>
    ''' <param name="BatchMode">Is this function already part of a transaction?</param>
    ''' <returns>True if successful, false if deletion failed.</returns>
    Public Function DeleteTagFromDB(ByVal ID As Long, ByVal Mode As Integer, Optional ByVal BatchMode As Boolean = False) As Boolean
        Try
            'first get a list of all movies in the tag to remove the tag information from NFO
            Dim moviesToSave As New List(Of Structures.DBMovie)
            Dim SQLtransaction As SQLite.SQLiteTransaction = Nothing
            Dim tagName As String = ""
            If Not BatchMode Then SQLtransaction = _myvideosDBConn.BeginTransaction()

            Using SQLcommand As SQLite.SQLiteCommand = _myvideosDBConn.CreateCommand()
                SQLcommand.CommandText = String.Concat("SELECT strTag FROM tag ", _
                                                       "WHERE idTag = ", ID, ";")
                Using SQLreader As SQLite.SQLiteDataReader = SQLcommand.ExecuteReader()
                    While SQLreader.Read
                        If Not DBNull.Value.Equals(SQLreader("strTag")) Then tagName = CStr(SQLreader("strTag"))
                    End While
                End Using
            End Using

            Using SQLcommand As SQLite.SQLiteCommand = _myvideosDBConn.CreateCommand()
                SQLcommand.CommandText = String.Concat("SELECT idMedia FROM taglinks ", _
                                                       "WHERE idTag = ", ID, ";")
                Using SQLreader As SQLite.SQLiteDataReader = SQLcommand.ExecuteReader()
                    While SQLreader.Read
                        If Mode = 1 Then
                            'tag is for movie
                            Dim movie As New Structures.DBMovie
                            If Not DBNull.Value.Equals(SQLreader("idMedia")) Then movie = LoadMovieFromDB(Convert.ToInt64(SQLreader("idMedia")))
                            moviesToSave.Add(movie)
                        End If
                    End While
                End Using
            End Using

            'remove the tag from movie and write new movie NFOs
            If moviesToSave.Count > 0 Then
                For Each movie In moviesToSave
                    movie.Movie.Tags.Remove(tagName)
                    SaveMovieToDB(movie, False, BatchMode, True)
                Next
            End If

            'remove the tag entry
            Using SQLcommand As SQLite.SQLiteCommand = _myvideosDBConn.CreateCommand()
                SQLcommand.CommandText = String.Concat("DELETE FROM tag WHERE idTag = ", ID, ";")
                SQLcommand.ExecuteNonQuery()
            End Using
            Using SQLcommand As SQLite.SQLiteCommand = _myvideosDBConn.CreateCommand()
                SQLcommand.CommandText = String.Concat("DELETE FROM taglinks WHERE idTag = ", ID, ";")
                SQLcommand.ExecuteNonQuery()
            End Using
            If Not BatchMode Then SQLtransaction.Commit()
        Catch ex As Exception
            logger.Error(New StackFrame().GetMethod().Name, ex)
            Return False
        End Try
        Return True
    End Function

    ''' <summary>
    ''' Remove all information related to a TV episode from the database.
    ''' </summary>
    ''' <param name="ID">ID of the episode to remove, as stored in the database.</param>
    ''' <param name="BatchMode">Is this function already part of a transaction?</param>
    ''' <returns>True if successful, false if deletion failed.</returns>
    Public Function DeleteTVEpFromDB(ByVal ID As Long, ByVal Force As Boolean, ByVal DoCleanSeasons As Boolean, Optional ByVal BatchMode As Boolean = False) As Boolean
        Dim SQLtransaction As SQLite.SQLiteTransaction = Nothing
        Dim doesExist As Boolean = False

        If Not BatchMode Then SQLtransaction = _myvideosDBConn.BeginTransaction()
        Using SQLcommand As SQLite.SQLiteCommand = _myvideosDBConn.CreateCommand()
            SQLcommand.CommandText = String.Concat("SELECT TVEpPathID, Missing, Episode, Season, idShow FROM episode WHERE idEpisode = ", ID, ";")
            Using SQLReader As SQLite.SQLiteDataReader = SQLcommand.ExecuteReader
                While SQLReader.Read
                    Using SQLECommand As SQLite.SQLiteCommand = _myvideosDBConn.CreateCommand()

                        If Not Force Then
                            'check if there is another episode with same season and episode number (in this case we don't need a another "Missing" episode)
                            Using SQLcommand_select As SQLite.SQLiteCommand = _myvideosDBConn.CreateCommand
                                SQLcommand_select.CommandText = String.Format("SELECT COUNT(episode.idEpisode) AS Count FROM episode WHERE NOT idEpisode = {0} AND Season = {1} AND Episode = {2} AND idShow = {3}", ID, SQLReader("Season"), SQLReader("Episode"), SQLReader("idShow"))
                                Using SQLReader_select As SQLite.SQLiteDataReader = SQLcommand_select.ExecuteReader
                                    While SQLReader_select.Read
                                        If CInt(SQLReader_select("Count")) > 0 Then doesExist = True
                                    End While
                                End Using
                            End Using
                        End If

                        If Force OrElse doesExist Then
                            SQLECommand.CommandText = String.Concat("DELETE FROM episode WHERE idEpisode = ", ID, ";")
                            SQLECommand.ExecuteNonQuery()

                            If DoCleanSeasons Then Master.DB.CleanSeasons(True)
                        ElseIf Not Convert.ToBoolean(SQLReader("Missing")) Then 'already marked as missing, no need for another query
                            SQLECommand.CommandText = String.Concat("DELETE FROM TVEpPaths WHERE ID = ", Convert.ToInt32(SQLReader("TVEpPathID")), ";")
                            SQLECommand.ExecuteNonQuery()
                            SQLECommand.CommandText = String.Concat("DELETE FROM TVVStreams WHERE TVEpID = ", ID, ";")
                            SQLECommand.ExecuteNonQuery()
                            SQLECommand.CommandText = String.Concat("DELETE FROM TVAStreams WHERE TVEpID = ", ID, ";")
                            SQLECommand.ExecuteNonQuery()
                            SQLECommand.CommandText = String.Concat("DELETE FROM TVSubs WHERE TVEpID = ", ID, ";")
                            SQLECommand.ExecuteNonQuery()
                            SQLECommand.CommandText = String.Concat("DELETE FROM art WHERE media_id = ", ID, " AND media_type = 'episode';")
                            SQLECommand.ExecuteNonQuery()
                            SQLECommand.CommandText = String.Concat("UPDATE episode SET New = 0, ", _
                                                                    "TVEpPathID = -1, NfoPath = '', ", _
                                                                    "Missing = 1, VideoSource = '' WHERE idEpisode = ", ID, ";")
                            SQLECommand.ExecuteNonQuery()
                        End If
                    End Using
                End While
            End Using
        End Using
        If Not BatchMode Then
            SQLtransaction.Commit()
            Master.DB.CleanSeasons()
        End If

        Return True
    End Function

    Public Function DeleteTVEpFromDBByPath(ByVal sPath As String, ByVal Force As Boolean, Optional ByVal BatchMode As Boolean = False) As Boolean
        Dim SQLtransaction As SQLite.SQLiteTransaction = Nothing
        If Not BatchMode Then SQLtransaction = _myvideosDBConn.BeginTransaction()
        Using SQLPCommand As SQLite.SQLiteCommand = _myvideosDBConn.CreateCommand()
            SQLPCommand.CommandText = String.Concat("SELECT ID FROM TVEpPaths WHERE TVEpPath = """, sPath, """;")
            Using SQLPReader As SQLite.SQLiteDataReader = SQLPCommand.ExecuteReader
                While SQLPReader.Read
                    Using SQLCommand As SQLite.SQLiteCommand = _myvideosDBConn.CreateCommand()
                        SQLCommand.CommandText = String.Concat("SELECT idEpisode FROM episode WHERE TVEpPathID = ", SQLPReader("ID"), ";")
                        Using SQLReader As SQLite.SQLiteDataReader = SQLCommand.ExecuteReader
                            While SQLReader.Read
                                DeleteTVEpFromDB(CInt(SQLReader("idEpisode")), Force, False, BatchMode)
                            End While
                        End Using
                    End Using
                End While
            End Using
        End Using
        If Not BatchMode Then SQLtransaction.Commit()

        Return True
    End Function

    ''' <summary>
    ''' Remove all information related to a TV season from the database.
    ''' </summary>
    ''' <param name="ShowID">ID of the tvshow to remove, as stored in the database.</param>
    ''' <param name="BatchMode">Is this function already part of a transaction?</param>
    ''' <returns>True if successful, false if deletion failed.</returns>
    Public Function DeleteTVSeasonFromDB(ByVal ShowID As Long, ByVal iSeason As Integer, Optional ByVal BatchMode As Boolean = False) As Boolean
        If ShowID < 0 Then Throw New ArgumentOutOfRangeException("ShowID", "Value must be >= 0, was given: " & ShowID)
        If iSeason < 0 Then Throw New ArgumentOutOfRangeException("iSeason", "Value must be >= 0, was given: " & iSeason)

        Try
            Dim SQLtransaction As SQLite.SQLiteTransaction = Nothing
            If Not BatchMode Then SQLtransaction = _myvideosDBConn.BeginTransaction()
            Using SQLcommand As SQLite.SQLiteCommand = _myvideosDBConn.CreateCommand()
                SQLcommand.CommandText = String.Concat("SELECT idEpisode FROM episode WHERE idShow = ", ShowID, " AND Season = ", iSeason, ";")
                Using SQLReader As SQLite.SQLiteDataReader = SQLcommand.ExecuteReader()
                    While SQLReader.Read
                        DeleteTVEpFromDB(Convert.ToInt64(SQLReader("idEpisode")), True, False, True)
                    End While
                End Using
                SQLcommand.CommandText = String.Concat("DELETE FROM seasons WHERE idShow = ", ShowID, " AND Season = ", iSeason, ";")
                SQLcommand.ExecuteNonQuery()
            End Using

            CleanSeasons(True)

            If Not BatchMode Then SQLtransaction.Commit()
        Catch ex As Exception
            logger.Error(New StackFrame().GetMethod().Name, ex)
            Return False
        End Try
        Return True
    End Function

    ''' <summary>
    ''' Remove all information related to a TV show from the database.
    ''' </summary>
    ''' <param name="ID">ID of the tvshow to remove, as stored in the database.</param>
    ''' <param name="BatchMode">Is this function already part of a transaction?</param>
    ''' <returns>True if successful, false if deletion failed.</returns>
    Public Function DeleteTVShowFromDB(ByVal ID As Long, Optional ByVal BatchMode As Boolean = False) As Boolean
        Try
            Dim SQLtransaction As SQLite.SQLiteTransaction = Nothing
            If Not BatchMode Then SQLtransaction = _myvideosDBConn.BeginTransaction()
            Using SQLcommand As SQLite.SQLiteCommand = _myvideosDBConn.CreateCommand()
                SQLcommand.CommandText = String.Concat("SELECT idEpisode FROM episode WHERE idShow = ", ID, ";")
                Using SQLReader As SQLite.SQLiteDataReader = SQLcommand.ExecuteReader()
                    While SQLReader.Read
                        DeleteTVEpFromDB(Convert.ToInt64(SQLReader("idEpisode")), True, False, True)
                    End While
                End Using
                SQLcommand.CommandText = String.Concat("DELETE FROM tvshow WHERE idShow = ", ID, ";")
                SQLcommand.ExecuteNonQuery()
            End Using

            If Not BatchMode Then SQLtransaction.Commit()
        Catch ex As Exception
            logger.Error(New StackFrame().GetMethod().Name, ex)
            Return False
        End Try
        Return True
    End Function

    ''' <summary>
    ''' Fill DataTable with data returned from the provided command
    ''' </summary>
    ''' <param name="dTable">DataTable to fill</param>
    ''' <param name="Command">SQL Command to process</param>
    Public Sub FillDataTable(ByRef dTable As DataTable, ByVal Command As String)
        dTable.Clear()
        Dim sqlDA As New SQLite.SQLiteDataAdapter(Command, _myvideosDBConn)
        Dim sqlCB As New SQLite.SQLiteCommandBuilder(sqlDA)
        sqlDA.Fill(dTable)
    End Sub
    ''' <summary>
    ''' Retrieve a TV Show's information for a particular season.
    ''' </summary>
    ''' <param name="_TVDB">Structure in which to return the information. NOTE: _TVDB.ShowID must be valid.</param>
    ''' <param name="iSeason"></param>
    ''' <remarks></remarks>
    Public Sub FillTVSeasonFromDB(ByRef _TVDB As Structures.DBTV, ByVal iSeason As Integer)
        Dim _tmpTVDB As New Structures.DBTV
        _tmpTVDB = LoadTVSeasonFromDB(_TVDB.ShowID, iSeason, False)

        _TVDB.IsLockSeason = _tmpTVDB.IsLockSeason
        _TVDB.IsMarkSeason = _tmpTVDB.IsMarkSeason
        _TVDB.SeasonBannerPath = _tmpTVDB.SeasonBannerPath
        _TVDB.SeasonFanartPath = _tmpTVDB.SeasonFanartPath
        _TVDB.SeasonID = _tmpTVDB.SeasonID
        _TVDB.SeasonLandscapePath = _tmpTVDB.SeasonLandscapePath
        _TVDB.SeasonPosterPath = _tmpTVDB.SeasonPosterPath
    End Sub

    ''' <summary>
    ''' Load all the information for a TV Show.
    ''' </summary>
    ''' <param name="_TVDB">Structures.DBTV container to fill</param>
    Public Sub FillTVShowFromDB(ByRef _TVDB As Structures.DBTV)
        Dim _tmpTVDB As New Structures.DBTV
        _tmpTVDB = LoadTVShowFromDB(_TVDB.ShowID)

        _TVDB.EpisodeSorting = _tmpTVDB.EpisodeSorting
        _TVDB.IsLockShow = _tmpTVDB.IsLockShow
        _TVDB.IsMarkShow = _tmpTVDB.IsMarkShow
        _TVDB.isOnlineShow = _tmpTVDB.isOnlineShow
        _TVDB.ListTitle = _tmpTVDB.ListTitle
        _TVDB.Ordering = _tmpTVDB.Ordering
        _TVDB.ShowBannerPath = _tmpTVDB.ShowBannerPath
        _TVDB.ShowCharacterArtPath = _tmpTVDB.ShowCharacterArtPath
        _TVDB.ShowClearArtPath = _tmpTVDB.ShowClearArtPath
        _TVDB.ShowClearLogoPath = _tmpTVDB.ShowClearLogoPath
        _TVDB.ShowEFanartsPath = _tmpTVDB.ShowEFanartsPath
        _TVDB.ShowFanartPath = _tmpTVDB.ShowFanartPath
        _TVDB.ShowLandscapePath = _tmpTVDB.ShowLandscapePath
        _TVDB.ShowLanguage = _tmpTVDB.ShowLanguage
        _TVDB.ShowNeedsSave = _tmpTVDB.ShowNeedsSave
        _TVDB.ShowNfoPath = _tmpTVDB.ShowNfoPath
        _TVDB.ShowPath = _tmpTVDB.ShowPath
        _TVDB.ShowPosterPath = _tmpTVDB.ShowPosterPath
        _TVDB.ShowThemePath = _tmpTVDB.ShowThemePath
        _TVDB.Source = _tmpTVDB.Source
        _TVDB.TVShow = _tmpTVDB.TVShow
    End Sub

    Public Function GetTVShowEpisodeSorting(ByVal ShowID As Long) As Enums.EpisodeSorting
        Dim sEpisodeSorting As Enums.EpisodeSorting = Enums.EpisodeSorting.Episode

        Using SQLcommand As SQLite.SQLiteCommand = _myvideosDBConn.CreateCommand()
            SQLcommand.CommandText = String.Concat("SELECT EpisodeSorting FROM tvshow WHERE idShow = ", ShowID, ";")
            Using SQLreader As SQLite.SQLiteDataReader = SQLcommand.ExecuteReader()
                While SQLreader.Read
                    sEpisodeSorting = DirectCast(Convert.ToInt32(SQLreader("EpisodeSorting")), Enums.EpisodeSorting)
                End While
            End Using
        End Using

        Return sEpisodeSorting
    End Function

    Public Function GetMovieCountries() As String()
        Dim cList As New List(Of String)
        Dim mCountry As String

        Using SQLcommand As SQLite.SQLiteCommand = _myvideosDBConn.CreateCommand()
            SQLcommand.CommandText = "SELECT Country FROM movie;"
            Using SQLreader As SQLite.SQLiteDataReader = SQLcommand.ExecuteReader()
                While SQLreader.Read
                    mCountry = SQLreader("Country").ToString
                    If mCountry.Contains("/") Then
                        Dim values As String() = mCountry.Split(New [Char]() {"/"c})
                        For Each country As String In values
                            country = country.Trim
                            If Not cList.Contains(country) Then
                                cList.Add(country)
                            End If
                        Next
                    Else
                        If Not String.IsNullOrEmpty(mCountry) Then
                            If Not cList.Contains(mCountry) Then
                                cList.Add(mCountry.Trim)
                            End If
                        End If
                    End If
                End While
            End Using
        End Using

        cList.Sort()
        Return cList.ToArray
    End Function

    Public Function GetMoviePaths() As List(Of String)
        Dim tList As New List(Of String)
        Dim mPath As String = String.Empty

        Using SQLcommand As SQLite.SQLiteCommand = _myvideosDBConn.CreateCommand()
            SQLcommand.CommandText = "SELECT MoviePath FROM movie;"
            Using SQLreader As SQLite.SQLiteDataReader = SQLcommand.ExecuteReader()
                While SQLreader.Read
                    mPath = SQLreader("MoviePath").ToString.ToLower
                    If Master.eSettings.FileSystemNoStackExts.Contains(Path.GetExtension(mPath)) Then
                        tList.Add(mPath)
                    Else
                        tList.Add(StringUtils.CleanStackingMarkers(mPath))
                    End If
                End While
            End Using
        End Using

        Return tList
    End Function

    Public Function GetTVSourceLanguage(ByVal sName As String) As String
        Dim sLang As String = String.Empty

        Try
            Using SQLcommand As SQLite.SQLiteCommand = _myvideosDBConn.CreateCommand()
                SQLcommand.CommandText = String.Concat("SELECT Language FROM TVSources WHERE Name = """, sName, """;")
                Using SQLreader As SQLite.SQLiteDataReader = SQLcommand.ExecuteReader()
                    If SQLreader.HasRows Then
                        SQLreader.Read()
                        sLang = SQLreader("Language").ToString
                    End If
                End Using
            End Using
        Catch ex As Exception
            logger.Error(New StackFrame().GetMethod().Name, ex)
        End Try

        Return sLang
    End Function
    ''' <summary>
    ''' Load all the information for a movie.
    ''' </summary>
    ''' <param name="MovieID">ID of the movie to load, as stored in the database</param>
    ''' <returns>Structures.DBMovie object</returns>
    Public Function LoadMovieFromDB(ByVal MovieID As Long) As Structures.DBMovie
        Dim _movieDB As New Structures.DBMovie

        _movieDB.ID = MovieID
        Using SQLcommand As SQLite.SQLiteCommand = _myvideosDBConn.CreateCommand()
            SQLcommand.CommandText = String.Concat("SELECT idMovie, MoviePath, Type, ListTitle, HasSub, ", _
                                                   "New, Mark, Source, Imdb, Lock, Title, OriginalTitle, Year, Rating, Votes, MPAA, ", _
                                                   "Top250, Country, Outline, Plot, Tagline, Certification, Genre, Studio, Runtime, ReleaseDate, ", _
                                                   "Director, Credits, Playcount, Trailer, EThumbsPath, NfoPath, ", _
                                                   "TrailerPath, SubPath, FanartURL, UseFolder, OutOfTolerance, VideoSource, NeedsSave, SortTitle, ", _
                                                   "DateAdded, EFanartsPath, ", _
                                                   "ThemePath, TMDB, ", _
                                                   "TMDBColID, DateModified, MarkCustom1, MarkCustom2, MarkCustom3, MarkCustom4, HasSet FROM movie WHERE idMovie = ", _movieDB.ID, ";")
            Using SQLreader As SQLite.SQLiteDataReader = SQLcommand.ExecuteReader()
                If SQLreader.HasRows Then
                    SQLreader.Read()
                    If Not DBNull.Value.Equals(SQLreader("DateAdded")) Then _movieDB.DateAdded = Convert.ToInt64(SQLreader("DateAdded"))
                    If Not DBNull.Value.Equals(SQLreader("DateModified")) Then _movieDB.DateModified = Convert.ToInt64(SQLreader("DateModified"))
                    If Not DBNull.Value.Equals(SQLreader("ListTitle")) Then _movieDB.ListTitle = SQLreader("ListTitle").ToString
                    If Not DBNull.Value.Equals(SQLreader("MoviePath")) Then _movieDB.Filename = SQLreader("MoviePath").ToString
                    _movieDB.IsSingle = Convert.ToBoolean(SQLreader("type"))
                    If Not DBNull.Value.Equals(SQLreader("TrailerPath")) Then _movieDB.TrailerPath = SQLreader("TrailerPath").ToString
                    If Not DBNull.Value.Equals(SQLreader("NfoPath")) Then _movieDB.NfoPath = SQLreader("NfoPath").ToString
                    If Not DBNull.Value.Equals(SQLreader("SubPath")) Then _movieDB.SubPath = SQLreader("SubPath").ToString
                    If Not DBNull.Value.Equals(SQLreader("EThumbsPath")) Then _movieDB.EThumbsPath = SQLreader("EThumbsPath").ToString
                    If Not DBNull.Value.Equals(SQLreader("EFanartsPath")) Then _movieDB.EFanartsPath = SQLreader("EFanartsPath").ToString
                    If Not DBNull.Value.Equals(SQLreader("ThemePath")) Then _movieDB.ThemePath = SQLreader("ThemePath").ToString
                    If Not DBNull.Value.Equals(SQLreader("Source")) Then _movieDB.Source = SQLreader("Source").ToString

                    _movieDB.BannerPath = GetArtForItem(_movieDB.ID, "movie", "banner")
                    _movieDB.ClearArtPath = GetArtForItem(_movieDB.ID, "movie", "clearart")
                    _movieDB.ClearLogoPath = GetArtForItem(_movieDB.ID, "movie", "clearlogo")
                    _movieDB.DiscArtPath = GetArtForItem(_movieDB.ID, "movie", "discart")
                    _movieDB.FanartPath = GetArtForItem(_movieDB.ID, "movie", "fanart")
                    _movieDB.LandscapePath = GetArtForItem(_movieDB.ID, "movie", "landscape")
                    _movieDB.PosterPath = GetArtForItem(_movieDB.ID, "movie", "poster")

                    _movieDB.IsMark = Convert.ToBoolean(SQLreader("Mark"))
                    _movieDB.IsLock = Convert.ToBoolean(SQLreader("Lock"))
                    _movieDB.UseFolder = Convert.ToBoolean(SQLreader("UseFolder"))
                    _movieDB.OutOfTolerance = Convert.ToBoolean(SQLreader("OutOfTolerance"))
                    _movieDB.NeedsSave = Convert.ToBoolean(SQLreader("NeedsSave"))
                    _movieDB.IsMarkCustom1 = Convert.ToBoolean(SQLreader("MarkCustom1"))
                    _movieDB.IsMarkCustom2 = Convert.ToBoolean(SQLreader("MarkCustom2"))
                    _movieDB.IsMarkCustom3 = Convert.ToBoolean(SQLreader("MarkCustom3"))
                    _movieDB.IsMarkCustom4 = Convert.ToBoolean(SQLreader("MarkCustom4"))
                    If Not DBNull.Value.Equals(SQLreader("VideoSource")) Then _movieDB.VideoSource = SQLreader("VideoSource").ToString
                    _movieDB.Movie = New MediaContainers.Movie
                    With _movieDB.Movie
                        If Not DBNull.Value.Equals(SQLreader("DateAdded")) Then .DateAdded = Functions.ConvertFromUnixTimestamp(Convert.ToInt64(SQLreader("DateAdded"))).ToString("yyyy-MM-dd HH:mm:ss")
                        If Not DBNull.Value.Equals(SQLreader("DateModified")) Then .DateModified = Functions.ConvertFromUnixTimestamp(Convert.ToInt64(SQLreader("DateModified"))).ToString("yyyy-MM-dd HH:mm:ss")
                        If Not DBNull.Value.Equals(SQLreader("IMDB")) Then .ID = SQLreader("IMDB").ToString
                        If Not DBNull.Value.Equals(SQLreader("Title")) Then .Title = SQLreader("Title").ToString
                        If Not DBNull.Value.Equals(SQLreader("OriginalTitle")) Then .OriginalTitle = SQLreader("OriginalTitle").ToString
                        If Not DBNull.Value.Equals(SQLreader("SortTitle")) Then .SortTitle = SQLreader("SortTitle").ToString
                        If Not DBNull.Value.Equals(SQLreader("Year")) Then .Year = SQLreader("Year").ToString
                        If Not DBNull.Value.Equals(SQLreader("Rating")) Then .Rating = SQLreader("Rating").ToString
                        If Not DBNull.Value.Equals(SQLreader("Votes")) Then .Votes = SQLreader("Votes").ToString
                        If Not DBNull.Value.Equals(SQLreader("MPAA")) Then .MPAA = SQLreader("MPAA").ToString
                        If Not DBNull.Value.Equals(SQLreader("Top250")) Then .Top250 = SQLreader("Top250").ToString
                        If Not DBNull.Value.Equals(SQLreader("Country")) Then .Country = SQLreader("Country").ToString
                        If Not DBNull.Value.Equals(SQLreader("Outline")) Then .Outline = SQLreader("Outline").ToString
                        If Not DBNull.Value.Equals(SQLreader("Plot")) Then .Plot = SQLreader("Plot").ToString
                        If Not DBNull.Value.Equals(SQLreader("Tagline")) Then .Tagline = SQLreader("Tagline").ToString
                        If Not DBNull.Value.Equals(SQLreader("Trailer")) Then .Trailer = SQLreader("Trailer").ToString
                        If Not DBNull.Value.Equals(SQLreader("Certification")) Then .Certification = SQLreader("Certification").ToString
                        If Not DBNull.Value.Equals(SQLreader("Genre")) Then .Genre = SQLreader("Genre").ToString
                        If Not DBNull.Value.Equals(SQLreader("Runtime")) Then .Runtime = SQLreader("Runtime").ToString
                        If Not DBNull.Value.Equals(SQLreader("ReleaseDate")) Then .ReleaseDate = SQLreader("ReleaseDate").ToString
                        If Not DBNull.Value.Equals(SQLreader("Studio")) Then .Studio = SQLreader("Studio").ToString
                        If Not DBNull.Value.Equals(SQLreader("Director")) Then .Director = SQLreader("Director").ToString
                        If Not DBNull.Value.Equals(SQLreader("Credits")) Then .OldCredits = SQLreader("Credits").ToString
                        If Not DBNull.Value.Equals(SQLreader("PlayCount")) Then .PlayCount = SQLreader("PlayCount").ToString
                        If Not DBNull.Value.Equals(SQLreader("FanartURL")) AndAlso Not Master.eSettings.MovieNoSaveImagesToNfo Then .Fanart.URL = SQLreader("FanartURL").ToString
                        If Not DBNull.Value.Equals(SQLreader("VideoSource")) Then .VideoSource = SQLreader("VideoSource").ToString
                        If Not DBNull.Value.Equals(SQLreader("TMDB")) Then .TMDBID = SQLreader("TMDB").ToString
                        If Not DBNull.Value.Equals(SQLreader("TMDBColID")) Then .TMDBColID = SQLreader("TMDBColID").ToString
                    End With
                End If
            End Using
        End Using

        'Actors
        Using SQLcommand As SQLite.SQLiteCommand = _myvideosDBConn.CreateCommand()
            SQLcommand.CommandText = String.Concat("SELECT A.strRole, B.idActor, B.strActor, B.strThumb, C.url FROM actorlinkmovie AS A ", _
                        "INNER JOIN actors AS B ON (A.idActor = B.idActor) ", _
                        "LEFT OUTER JOIN art AS C ON (B.idActor = C.media_id AND C.media_type = 'actor' AND C.type = 'thumb') ", _
                        "WHERE A.idMovie = ", _movieDB.ID, " ", _
                        "ORDER BY A.iOrder;")
            Using SQLreader As SQLite.SQLiteDataReader = SQLcommand.ExecuteReader()
                Dim person As MediaContainers.Person
                While SQLreader.Read
                    person = New MediaContainers.Person
                    person.ID = Convert.ToInt64(SQLreader("idActor"))
                    person.Name = SQLreader("strActor").ToString
                    person.Role = SQLreader("strRole").ToString
                    person.ThumbPath = SQLreader("url").ToString
                    person.ThumbURL = SQLreader("strThumb").ToString
                    _movieDB.Movie.Actors.Add(person)
                End While
            End Using
        End Using

        'Video streams
        Using SQLcommand As SQLite.SQLiteCommand = _myvideosDBConn.CreateCommand()
            SQLcommand.CommandText = String.Concat("SELECT MovieID, StreamID, Video_Width, Video_Height, Video_Codec, Video_Duration, Video_ScanType, ", _
                                                   "Video_AspectDisplayRatio, Video_Language, Video_LongLanguage, Video_Bitrate, Video_MultiViewCount, ", _
                                                   "Video_EncodedSettings, Video_MultiViewLayout, Video_StereoMode FROM MoviesVStreams WHERE MovieID = ", _movieDB.ID, ";")
            Using SQLreader As SQLite.SQLiteDataReader = SQLcommand.ExecuteReader()
                Dim video As MediaInfo.Video
                While SQLreader.Read
                    video = New MediaInfo.Video
                    If Not DBNull.Value.Equals(SQLreader("Video_Width")) Then video.Width = SQLreader("Video_Width").ToString
                    If Not DBNull.Value.Equals(SQLreader("Video_Height")) Then video.Height = SQLreader("Video_Height").ToString
                    If Not DBNull.Value.Equals(SQLreader("Video_Codec")) Then video.Codec = SQLreader("Video_Codec").ToString
                    If Not DBNull.Value.Equals(SQLreader("Video_Duration")) Then video.Duration = SQLreader("Video_Duration").ToString
                    If Not DBNull.Value.Equals(SQLreader("Video_ScanType")) Then video.Scantype = SQLreader("Video_ScanType").ToString
                    If Not DBNull.Value.Equals(SQLreader("Video_AspectDisplayRatio")) Then video.Aspect = SQLreader("Video_AspectDisplayRatio").ToString
                    If Not DBNull.Value.Equals(SQLreader("Video_Language")) Then video.Language = SQLreader("Video_Language").ToString
                    If Not DBNull.Value.Equals(SQLreader("Video_LongLanguage")) Then video.LongLanguage = SQLreader("Video_LongLanguage").ToString
                    If Not DBNull.Value.Equals(SQLreader("Video_Bitrate")) Then video.Bitrate = SQLreader("Video_Bitrate").ToString
                    If Not DBNull.Value.Equals(SQLreader("Video_MultiViewCount")) Then video.MultiViewCount = SQLreader("Video_MultiViewCount").ToString
                    If Not DBNull.Value.Equals(SQLreader("Video_EncodedSettings")) Then video.EncodedSettings = SQLreader("Video_EncodedSettings").ToString
                    If Not DBNull.Value.Equals(SQLreader("Video_MultiViewLayout")) Then video.MultiViewLayout = SQLreader("Video_MultiViewLayout").ToString
                    If Not DBNull.Value.Equals(SQLreader("Video_StereoMode")) Then video.StereoMode = SQLreader("Video_StereoMode").ToString
                    _movieDB.Movie.FileInfo.StreamDetails.Video.Add(video)
                End While
            End Using
        End Using

        'Audio streams
        Using SQLcommand As SQLite.SQLiteCommand = _myvideosDBConn.CreateCommand()
            SQLcommand.CommandText = String.Concat("SELECT MovieID, StreamID, Audio_Language, Audio_LongLanguage, Audio_Codec, Audio_Channel, Audio_Bitrate FROM MoviesAStreams WHERE MovieID = ", _movieDB.ID, ";")
            Using SQLreader As SQLite.SQLiteDataReader = SQLcommand.ExecuteReader()
                Dim audio As MediaInfo.Audio
                While SQLreader.Read
                    audio = New MediaInfo.Audio
                    If Not DBNull.Value.Equals(SQLreader("Audio_Language")) Then audio.Language = SQLreader("Audio_Language").ToString
                    If Not DBNull.Value.Equals(SQLreader("Audio_LongLanguage")) Then audio.LongLanguage = SQLreader("Audio_LongLanguage").ToString
                    If Not DBNull.Value.Equals(SQLreader("Audio_Codec")) Then audio.Codec = SQLreader("Audio_Codec").ToString
                    If Not DBNull.Value.Equals(SQLreader("Audio_Channel")) Then audio.Channels = SQLreader("Audio_Channel").ToString
                    If Not DBNull.Value.Equals(SQLreader("Audio_Bitrate")) Then audio.Bitrate = SQLreader("Audio_Bitrate").ToString
                    _movieDB.Movie.FileInfo.StreamDetails.Audio.Add(audio)
                End While
            End Using
        End Using

        'embedded subtitles
        _movieDB.Subtitles = New List(Of MediaInfo.Subtitle)
        Using SQLcommand As SQLite.SQLiteCommand = _myvideosDBConn.CreateCommand()
            SQLcommand.CommandText = String.Concat("SELECT MovieID, StreamID, Subs_Language, Subs_LongLanguage, Subs_Type, Subs_Path, Subs_Forced FROM MoviesSubs WHERE MovieID = ", _movieDB.ID, " AND NOT Subs_Type = 'External';")
            Using SQLreader As SQLite.SQLiteDataReader = SQLcommand.ExecuteReader()
                Dim subtitle As MediaInfo.Subtitle
                While SQLreader.Read
                    subtitle = New MediaInfo.Subtitle
                    If Not DBNull.Value.Equals(SQLreader("Subs_Language")) Then subtitle.Language = SQLreader("Subs_Language").ToString
                    If Not DBNull.Value.Equals(SQLreader("Subs_LongLanguage")) Then subtitle.LongLanguage = SQLreader("Subs_LongLanguage").ToString
                    If Not DBNull.Value.Equals(SQLreader("Subs_Type")) Then subtitle.SubsType = SQLreader("Subs_Type").ToString
                    If Not DBNull.Value.Equals(SQLreader("Subs_Path")) Then subtitle.SubsPath = SQLreader("Subs_Path").ToString
                    subtitle.SubsForced = Convert.ToBoolean(SQLreader("Subs_Forced"))
                    _movieDB.Movie.FileInfo.StreamDetails.Subtitle.Add(subtitle)
                End While
            End Using
        End Using

        'external subtitles
        Using SQLcommand As SQLite.SQLiteCommand = _myvideosDBConn.CreateCommand()
            SQLcommand.CommandText = String.Concat("SELECT MovieID, StreamID, Subs_Language, Subs_LongLanguage, Subs_Type, Subs_Path, Subs_Forced FROM MoviesSubs WHERE MovieID = ", _movieDB.ID, " AND Subs_Type = 'External';")
            Using SQLreader As SQLite.SQLiteDataReader = SQLcommand.ExecuteReader()
                Dim subtitle As MediaInfo.Subtitle
                While SQLreader.Read
                    subtitle = New MediaInfo.Subtitle
                    If Not DBNull.Value.Equals(SQLreader("Subs_Language")) Then subtitle.Language = SQLreader("Subs_Language").ToString
                    If Not DBNull.Value.Equals(SQLreader("Subs_LongLanguage")) Then subtitle.LongLanguage = SQLreader("Subs_LongLanguage").ToString
                    If Not DBNull.Value.Equals(SQLreader("Subs_Type")) Then subtitle.SubsType = SQLreader("Subs_Type").ToString
                    If Not DBNull.Value.Equals(SQLreader("Subs_Path")) Then subtitle.SubsPath = SQLreader("Subs_Path").ToString
                    subtitle.SubsForced = Convert.ToBoolean(SQLreader("Subs_Forced"))
                    _movieDB.Subtitles.Add(subtitle)
                End While
            End Using
        End Using

        'MovieSets
        Using SQLcommand As SQLite.SQLiteCommand = _myvideosDBConn.CreateCommand()
            SQLcommand.CommandText = String.Concat("SELECT A.MovieID, A.SetID, A.SetOrder, B.idSet, B.SetName FROM MoviesSets ", _
                                                   "AS A INNER JOIN sets AS B ON (A.SetID = B.idSet) WHERE A.MovieID = ", _movieDB.ID, ";")
            Using SQLreader As SQLite.SQLiteDataReader = SQLcommand.ExecuteReader()
                Dim sets As MediaContainers.Set
                While SQLreader.Read
                    sets = New MediaContainers.Set
                    If Not DBNull.Value.Equals(SQLreader("SetID")) Then sets.ID = Convert.ToInt64(SQLreader("SetID"))
                    If Not DBNull.Value.Equals(SQLreader("SetOrder")) Then sets.Order = SQLreader("SetOrder").ToString
                    If Not DBNull.Value.Equals(SQLreader("SetName")) Then sets.Title = SQLreader("SetName").ToString
                    _movieDB.Movie.Sets.Add(sets)
                End While
            End Using
        End Using

        'Tags
        Using SQLcommand As SQLite.SQLiteCommand = _myvideosDBConn.CreateCommand()
            SQLcommand.CommandText = String.Concat("SELECT B.strTag FROM taglinks ", _
                                                   "AS A INNER JOIN tag AS B ON (A.idTag = B.idTag) WHERE A.idMedia = ", _movieDB.ID, " AND A.media_type = 'movie';")
            Using SQLreader As SQLite.SQLiteDataReader = SQLcommand.ExecuteReader()
                Dim tag As String
                While SQLreader.Read
                    tag = String.Empty
                    If Not DBNull.Value.Equals(SQLreader("strTag")) Then tag = SQLreader("strTag").ToString
                    _movieDB.Movie.Tags.Add(tag)
                End While
            End Using
        End Using

        'Check if the file is available and ready to edit
        If File.Exists(_movieDB.Filename) Then _movieDB.IsOnline = True

        Return _movieDB
    End Function

    ''' <summary>
    ''' Load all the information for a movie (by movie path)
    ''' </summary>
    ''' <param name="sPath">Full path to the movie file</param>
    ''' <returns>Structures.DBMovie object</returns>
    Public Function LoadMovieFromDB(ByVal sPath As String) As Structures.DBMovie
        Using SQLcommand As SQLite.SQLiteCommand = _myvideosDBConn.CreateCommand()
            ' One more Query Better then re-write all function again
            SQLcommand.CommandText = String.Concat("SELECT idMovie FROM movie WHERE MoviePath = ", sPath, ";")
            Using SQLreader As SQLite.SQLiteDataReader = SQLcommand.ExecuteReader()
                If SQLreader.Read Then
                    Return LoadMovieFromDB(Convert.ToInt64(SQLreader("idMovie")))
                Else
                    Return New Structures.DBMovie With {.Id = -1} ' No Movie Found
                End If
            End Using
        End Using

        Return New Structures.DBMovie With {.Id = -1}
    End Function

    ''' <summary>
    ''' Load all the information for a movieset.
    ''' </summary>
    ''' <param name="MovieSetID">ID of the movieset to load, as stored in the database</param>
    ''' <returns>Structures.DBMovie object</returns>
    Public Function LoadMovieSetFromDB(ByVal MovieSetID As Long) As Structures.DBMovieSet
        Dim _moviesetDB As New Structures.DBMovieSet

        Try
            _moviesetDB.ID = MovieSetID
            Using SQLcommand As SQLite.SQLiteCommand = _myvideosDBConn.CreateCommand()
                SQLcommand.CommandText = String.Concat("SELECT idSet, ListTitle, NfoPath, ", _
                                                       "TMDBColID, Plot, SetName, New, Mark, Lock FROM sets WHERE idSet = ", MovieSetID, ";")
                Using SQLreader As SQLite.SQLiteDataReader = SQLcommand.ExecuteReader()
                    If SQLreader.HasRows Then
                        SQLreader.Read()
                        If Not DBNull.Value.Equals(SQLreader("ListTitle")) Then _moviesetDB.ListTitle = SQLreader("ListTitle").ToString
                        If Not DBNull.Value.Equals(SQLreader("NfoPath")) Then _moviesetDB.NfoPath = SQLreader("NfoPath").ToString

                        _moviesetDB.BannerPath = GetArtForItem(_moviesetDB.ID, "set", "banner")
                        _moviesetDB.ClearArtPath = GetArtForItem(_moviesetDB.ID, "set", "clearart")
                        _moviesetDB.ClearLogoPath = GetArtForItem(_moviesetDB.ID, "set", "clearlogo")
                        _moviesetDB.DiscArtPath = GetArtForItem(_moviesetDB.ID, "set", "discart")
                        _moviesetDB.FanartPath = GetArtForItem(_moviesetDB.ID, "set", "fanart")
                        _moviesetDB.LandscapePath = GetArtForItem(_moviesetDB.ID, "set", "landscape")
                        _moviesetDB.PosterPath = GetArtForItem(_moviesetDB.ID, "set", "poster")

                        _moviesetDB.IsMark = Convert.ToBoolean(SQLreader("Mark"))
                        _moviesetDB.IsLock = Convert.ToBoolean(SQLreader("Lock"))
                        _moviesetDB.MovieSet = New MediaContainers.MovieSet
                        With _moviesetDB.MovieSet
                            If Not DBNull.Value.Equals(SQLreader("TMDBColID")) Then .ID = SQLreader("TMDBColID").ToString
                            If Not DBNull.Value.Equals(SQLreader("Plot")) Then .Plot = SQLreader("Plot").ToString
                            If Not DBNull.Value.Equals(SQLreader("SetName")) Then .Title = SQLreader("SetName").ToString
                        End With
                    End If
                End Using
            End Using

            _moviesetDB.Movies = New List(Of Structures.DBMovie)
            Using SQLcommand As SQLite.SQLiteCommand = _myvideosDBConn.CreateCommand()
                SQLcommand.CommandText = String.Concat("SELECT MovieID, SetID , SetOrder FROM MoviesSets ", _
                            "WHERE SetID = ", _moviesetDB.ID, " ORDER BY SetOrder;")
                Using SQLreader As SQLite.SQLiteDataReader = SQLcommand.ExecuteReader()
                    Dim movie As Structures.DBMovie
                    While SQLreader.Read
                        movie = New Structures.DBMovie
                        movie = LoadMovieFromDB(Convert.ToInt64(SQLreader("MovieID")))
                        _moviesetDB.Movies.Add(movie)
                    End While
                End Using
            End Using

        Catch ex As Exception
            logger.Error(New StackFrame().GetMethod().Name, ex)
        End Try
        Return _moviesetDB
    End Function

    ''' <summary>
    ''' Load all the information for a movietag.
    ''' </summary>
    ''' <param name="TagID">ID of the movietag to load, as stored in the database</param>
    ''' <returns>Structures.DBMovieTag object</returns>
    Public Function LoadMovieTagFromDB(ByVal TagID As Integer) As Structures.DBMovieTag
        Dim _tagDB As New Structures.DBMovieTag
        _tagDB.ID = TagID
        Using SQLcommand As SQLite.SQLiteCommand = _myvideosDBConn.CreateCommand()
            SQLcommand.CommandText = String.Concat("SELECT idTag, strTag FROM tag WHERE idTag = ", TagID, ";")
            Using SQLreader As SQLite.SQLiteDataReader = SQLcommand.ExecuteReader()
                If SQLreader.HasRows Then
                    SQLreader.Read()
                    If Not DBNull.Value.Equals(SQLreader("strTag")) Then _tagDB.Title = SQLreader("strTag").ToString
                    If Not DBNull.Value.Equals(SQLreader("idTag")) Then _tagDB.ID = CInt(SQLreader("idTag"))
                End If
            End Using
        End Using

        _tagDB.Movies = New List(Of Structures.DBMovie)
        Using SQLcommand As SQLite.SQLiteCommand = _myvideosDBConn.CreateCommand()
            SQLcommand.CommandText = String.Concat("SELECT idMedia, idTag FROM taglinks ", _
                        "WHERE idTag = ", _tagDB.ID, " AND media_type = 'movie';")
            Using SQLreader As SQLite.SQLiteDataReader = SQLcommand.ExecuteReader()
                Dim movie As Structures.DBMovie
                While SQLreader.Read
                    movie = New Structures.DBMovie
                    movie = LoadMovieFromDB(Convert.ToInt64(SQLreader("idMedia")))
                    _tagDB.Movies.Add(movie)
                End While
            End Using
        End Using
        Return _tagDB
    End Function

    ''' <summary>
    ''' Get the posterpath for the all seasons entry.
    ''' </summary>
    ''' <param name="ShowID">ID of the show to load, as stored in the database</param>
    ''' <param name="WithShow">If <c>True</c>, also retrieve base show information</param>
    ''' <returns>Structures.DBTV object</returns>
    Public Function LoadTVAllSeasonsFromDB(ByVal ShowID As Long, Optional ByVal WithShow As Boolean = False) As Structures.DBTV
        'TODO This method seems mis-named, and may not be performing its intended role
        'DanCooper: Works correctly. AllSeasonsPosters don't have existing episodes, so it needs to be fetched manually from DB.

        If ShowID < 0 Then Throw New ArgumentOutOfRangeException("ShowID", "Value must be >= 0, was given: " & ShowID)

        Dim _TVDB As New Structures.DBTV
        _TVDB.ShowID = ShowID
        _TVDB.TVEp = New MediaContainers.EpisodeDetails With {.Season = 999}

        Using SQLcommandTVSeason As SQLite.SQLiteCommand = _myvideosDBConn.CreateCommand()
            SQLcommandTVSeason.CommandText = String.Concat("SELECT idSeason FROM seasons WHERE idShow = ", ShowID, " AND Season = 999;")
            Using SQLReader As SQLite.SQLiteDataReader = SQLcommandTVSeason.ExecuteReader
                If SQLReader.HasRows Then
                    SQLReader.Read()
                    If Not DBNull.Value.Equals(SQLReader("idSeason")) Then _TVDB.SeasonID = Convert.ToInt64(SQLReader("idSeason"))

                    _TVDB.SeasonBannerPath = GetArtForItem(_TVDB.SeasonID, "season", "banner")
                    _TVDB.SeasonFanartPath = GetArtForItem(_TVDB.SeasonID, "season", "fanart")
                    _TVDB.SeasonLandscapePath = GetArtForItem(_TVDB.SeasonID, "season", "landscape")
                    _TVDB.SeasonPosterPath = GetArtForItem(_TVDB.SeasonID, "season", "poster")
                End If
            End Using
        End Using

        If WithShow Then Master.DB.FillTVShowFromDB(_TVDB)

        Return _TVDB
    End Function

    ''' <summary>
    ''' Load all the information for a TV Episode.
    ''' </summary>
    ''' <param name="EpID">ID of the episode to load, as stored in the database</param>
    ''' <returns>Structures.DBTV object</returns>
    Public Function LoadTVEpFromDB(ByVal EpID As Long, ByVal WithShow As Boolean) As Structures.DBTV
        Dim _TVDB As New Structures.DBTV
        Dim PathID As Long = -1

        _TVDB.EpID = EpID
        Using SQLcommand As SQLite.SQLiteCommand = _myvideosDBConn.CreateCommand()
            SQLcommand.CommandText = String.Concat("SELECT idEpisode, idShow, Episode, Title, New, Mark, TVEpPathID, Source, Lock, ", _
                                                   "Season, Rating, Plot, Aired, Director, Credits, NfoPath, NeedsSave, Missing, Playcount, ", _
                                                   "DisplaySeason, DisplayEpisode, DateAdded, Runtime, Votes, VideoSource, HasSub FROM episode WHERE idEpisode = ", EpID, ";")
            Using SQLreader As SQLite.SQLiteDataReader = SQLcommand.ExecuteReader()
                If SQLreader.HasRows Then
                    SQLreader.Read()
                    If Not DBNull.Value.Equals(SQLreader("NfoPath")) Then _TVDB.EpNfoPath = SQLreader("NfoPath").ToString
                    If Not DBNull.Value.Equals(SQLreader("Source")) Then _TVDB.Source = SQLreader("Source").ToString
                    If Not DBNull.Value.Equals(SQLreader("idShow")) Then _TVDB.ShowID = Convert.ToInt64(SQLreader("idShow"))
                    If Not DBNull.Value.Equals(SQLreader("DateAdded")) Then _TVDB.DateAdded = Convert.ToInt64(SQLreader("DateAdded"))
                    If Not DBNull.Value.Equals(SQLreader("VideoSource")) Then _TVDB.VideoSource = SQLreader("VideoSource").ToString
                    PathID = Convert.ToInt64(SQLreader("TVEpPathid"))

                    _TVDB.EpFanartPath = GetArtForItem(_TVDB.EpID, "episode", "fanart")
                    _TVDB.EpPosterPath = GetArtForItem(_TVDB.EpID, "episode", "thumb")

                    _TVDB.FilenameID = PathID
                    _TVDB.IsMarkEp = Convert.ToBoolean(SQLreader("Mark"))
                    _TVDB.IsLockEp = Convert.ToBoolean(SQLreader("Lock"))
                    _TVDB.EpNeedsSave = Convert.ToBoolean(SQLreader("NeedsSave"))
                    _TVDB.TVEp = New MediaContainers.EpisodeDetails
                    With _TVDB.TVEp
                        ' add display season and episode - mh
                        If Not DBNull.Value.Equals(SQLreader("DisplaySeason")) Then
                            .DisplaySeason = Convert.ToInt32(SQLreader("Season"))
                            .displaySEset = True
                        End If
                        If Not DBNull.Value.Equals(SQLreader("DisplayEpisode")) Then
                            .DisplayEpisode = Convert.ToInt32(SQLreader("Episode"))
                            .displaySEset = True
                        End If
                        If Not DBNull.Value.Equals(SQLreader("Title")) Then .Title = SQLreader("Title").ToString
                        If Not DBNull.Value.Equals(SQLreader("Season")) Then .Season = Convert.ToInt32(SQLreader("Season"))
                        If Not DBNull.Value.Equals(SQLreader("Episode")) Then .Episode = Convert.ToInt32(SQLreader("Episode"))
                        If Not DBNull.Value.Equals(SQLreader("Aired")) Then .Aired = SQLreader("Aired").ToString
                        If Not DBNull.Value.Equals(SQLreader("Rating")) Then .Rating = SQLreader("Rating").ToString
                        If Not DBNull.Value.Equals(SQLreader("Plot")) Then .Plot = SQLreader("Plot").ToString
                        If Not DBNull.Value.Equals(SQLreader("Director")) Then .Director = SQLreader("Director").ToString
                        If Not DBNull.Value.Equals(SQLreader("Credits")) Then .OldCredits = SQLreader("Credits").ToString
                        If Not DBNull.Value.Equals(SQLreader("Playcount")) Then .Playcount = SQLreader("Playcount").ToString
                        If Not DBNull.Value.Equals(SQLreader("DateAdded")) Then .DateAdded = Functions.ConvertFromUnixTimestamp(Convert.ToInt64(SQLreader("DateAdded"))).ToString("yyyy-MM-dd HH:mm:ss")
                        If Not DBNull.Value.Equals(SQLreader("Runtime")) Then .Runtime = SQLreader("Runtime").ToString
                        If Not DBNull.Value.Equals(SQLreader("Votes")) Then .Votes = SQLreader("Votes").ToString
                        If Not DBNull.Value.Equals(SQLreader("VideoSource")) Then .VideoSource = SQLreader("VideoSource").ToString
                    End With
                End If
            End Using
        End Using

        Using SQLcommand As SQLite.SQLiteCommand = _myvideosDBConn.CreateCommand()
            SQLcommand.CommandText = String.Concat("SELECT TVEpPath FROM TVEpPaths WHERE ID = ", PathID, ";")
            Using SQLreader As SQLite.SQLiteDataReader = SQLcommand.ExecuteReader
                If SQLreader.HasRows Then
                    SQLreader.Read()
                    If Not DBNull.Value.Equals(SQLreader("TVEpPath")) Then _TVDB.Filename = SQLreader("TVEpPath").ToString
                End If
            End Using
        End Using

        'Actors
        Using SQLcommand As SQLite.SQLiteCommand = _myvideosDBConn.CreateCommand()
            SQLcommand.CommandText = String.Concat("SELECT A.strRole, B.idActor, B.strActor, B.strThumb, C.url FROM actorlinkepisode AS A ", _
                                                   "INNER JOIN actors AS B ON (A.idActor = B.idActor) ", _
                                                   "LEFT OUTER JOIN art AS C ON (B.idActor = C.media_id AND C.media_type = 'actor' AND C.type = 'thumb') ", _
                                                   "WHERE A.idEpisode = ", _TVDB.EpID, " ", _
                                                   "ORDER BY A.iOrder;")
            Using SQLreader As SQLite.SQLiteDataReader = SQLcommand.ExecuteReader()
                Dim person As MediaContainers.Person
                While SQLreader.Read
                    person = New MediaContainers.Person
                    person.ID = Convert.ToInt64(SQLreader("idActor"))
                    person.Name = SQLreader("strActor").ToString
                    person.Role = SQLreader("strRole").ToString
                    person.ThumbPath = SQLreader("url").ToString
                    person.ThumbURL = SQLreader("strThumb").ToString
                    _TVDB.TVEp.Actors.Add(person)
                End While
            End Using
        End Using

        Using SQLcommand As SQLite.SQLiteCommand = _myvideosDBConn.CreateCommand()
            SQLcommand.CommandText = String.Concat("SELECT TVEpID, StreamID, Video_Width, Video_Height, Video_Codec, Video_Duration, Video_ScanType, ", _
                                                   "Video_AspectDisplayRatio, Video_Language, Video_LongLanguage, Video_Bitrate, Video_MultiViewCount, ", _
                                                   "Video_EncodedSettings, Video_MultiViewLayout, Video_StereoMode FROM TVVStreams WHERE TVEpID = ", _TVDB.EpID, ";")
            Using SQLreader As SQLite.SQLiteDataReader = SQLcommand.ExecuteReader()
                Dim video As MediaInfo.Video
                While SQLreader.Read
                    video = New MediaInfo.Video
                    If Not DBNull.Value.Equals(SQLreader("Video_Width")) Then video.Width = SQLreader("Video_Width").ToString
                    If Not DBNull.Value.Equals(SQLreader("Video_Height")) Then video.Height = SQLreader("Video_Height").ToString
                    If Not DBNull.Value.Equals(SQLreader("Video_Codec")) Then video.Codec = SQLreader("Video_Codec").ToString
                    If Not DBNull.Value.Equals(SQLreader("Video_Duration")) Then video.Duration = SQLreader("Video_Duration").ToString
                    If Not DBNull.Value.Equals(SQLreader("Video_ScanType")) Then video.Scantype = SQLreader("Video_ScanType").ToString
                    If Not DBNull.Value.Equals(SQLreader("Video_AspectDisplayRatio")) Then video.Aspect = SQLreader("Video_AspectDisplayRatio").ToString
                    If Not DBNull.Value.Equals(SQLreader("Video_Language")) Then video.Language = SQLreader("Video_Language").ToString
                    If Not DBNull.Value.Equals(SQLreader("Video_LongLanguage")) Then video.LongLanguage = SQLreader("Video_LongLanguage").ToString
                    If Not DBNull.Value.Equals(SQLreader("Video_Bitrate")) Then video.Bitrate = SQLreader("Video_Bitrate").ToString
                    If Not DBNull.Value.Equals(SQLreader("Video_MultiViewCount")) Then video.MultiViewCount = SQLreader("Video_MultiViewCount").ToString
                    If Not DBNull.Value.Equals(SQLreader("Video_EncodedSettings")) Then video.EncodedSettings = SQLreader("Video_EncodedSettings").ToString
                    If Not DBNull.Value.Equals(SQLreader("Video_MultiViewLayout")) Then video.MultiViewLayout = SQLreader("Video_MultiViewLayout").ToString
                    If Not DBNull.Value.Equals(SQLreader("Video_StereoMode")) Then video.StereoMode = SQLreader("Video_StereoMode").ToString
                    _TVDB.TVEp.FileInfo.StreamDetails.Video.Add(video)
                End While
            End Using
        End Using

        Using SQLcommand As SQLite.SQLiteCommand = _myvideosDBConn.CreateCommand()
            SQLcommand.CommandText = String.Concat("SELECT TVEpID, StreamID, Audio_Language, Audio_LongLanguage, Audio_Codec, Audio_Channel, Audio_Bitrate FROM TVAStreams WHERE TVEpID = ", _TVDB.EpID, ";")
            Using SQLreader As SQLite.SQLiteDataReader = SQLcommand.ExecuteReader()
                Dim audio As MediaInfo.Audio
                While SQLreader.Read
                    audio = New MediaInfo.Audio
                    If Not DBNull.Value.Equals(SQLreader("Audio_Language")) Then audio.Language = SQLreader("Audio_Language").ToString
                    If Not DBNull.Value.Equals(SQLreader("Audio_LongLanguage")) Then audio.LongLanguage = SQLreader("Audio_LongLanguage").ToString
                    If Not DBNull.Value.Equals(SQLreader("Audio_Codec")) Then audio.Codec = SQLreader("Audio_Codec").ToString
                    If Not DBNull.Value.Equals(SQLreader("Audio_Channel")) Then audio.Channels = SQLreader("Audio_Channel").ToString
                    If Not DBNull.Value.Equals(SQLreader("Audio_Bitrate")) Then audio.Bitrate = SQLreader("Audio_Bitrate").ToString
                    _TVDB.TVEp.FileInfo.StreamDetails.Audio.Add(audio)
                End While
            End Using
        End Using

        'embedded subtitles
        _TVDB.EpSubtitles = New List(Of MediaInfo.Subtitle)
        Using SQLcommand As SQLite.SQLiteCommand = _myvideosDBConn.CreateCommand()
            SQLcommand.CommandText = String.Concat("SELECT TVEpID, StreamID, Subs_Language, Subs_LongLanguage, Subs_Type, Subs_Path, Subs_Forced FROM TVSubs WHERE TVEpID = ", _TVDB.EpID, " AND NOT Subs_Type = 'External';")
            Using SQLreader As SQLite.SQLiteDataReader = SQLcommand.ExecuteReader()
                Dim subtitle As MediaInfo.Subtitle
                While SQLreader.Read
                    subtitle = New MediaInfo.Subtitle
                    If Not DBNull.Value.Equals(SQLreader("Subs_Language")) Then subtitle.Language = SQLreader("Subs_Language").ToString
                    If Not DBNull.Value.Equals(SQLreader("Subs_LongLanguage")) Then subtitle.LongLanguage = SQLreader("Subs_LongLanguage").ToString
                    If Not DBNull.Value.Equals(SQLreader("Subs_Type")) Then subtitle.SubsType = SQLreader("Subs_Type").ToString
                    If Not DBNull.Value.Equals(SQLreader("Subs_Path")) Then subtitle.SubsPath = SQLreader("Subs_Path").ToString
                    subtitle.SubsForced = Convert.ToBoolean(SQLreader("Subs_Forced"))
                    _TVDB.TVEp.FileInfo.StreamDetails.Subtitle.Add(subtitle)
                End While
            End Using
        End Using

        'external subtitles
        Using SQLcommand As SQLite.SQLiteCommand = _myvideosDBConn.CreateCommand()
            SQLcommand.CommandText = String.Concat("SELECT TVEpID, StreamID, Subs_Language, Subs_LongLanguage, Subs_Type, Subs_Path, Subs_Forced FROM TVSubs WHERE TVEpID = ", _TVDB.EpID, " AND Subs_Type = 'External';")
            Using SQLreader As SQLite.SQLiteDataReader = SQLcommand.ExecuteReader()
                Dim subtitle As MediaInfo.Subtitle
                While SQLreader.Read
                    subtitle = New MediaInfo.Subtitle
                    If Not DBNull.Value.Equals(SQLreader("Subs_Language")) Then subtitle.Language = SQLreader("Subs_Language").ToString
                    If Not DBNull.Value.Equals(SQLreader("Subs_LongLanguage")) Then subtitle.LongLanguage = SQLreader("Subs_LongLanguage").ToString
                    If Not DBNull.Value.Equals(SQLreader("Subs_Type")) Then subtitle.SubsType = SQLreader("Subs_Type").ToString
                    If Not DBNull.Value.Equals(SQLreader("Subs_Path")) Then subtitle.SubsPath = SQLreader("Subs_Path").ToString
                    subtitle.SubsForced = Convert.ToBoolean(SQLreader("Subs_Forced"))
                    _TVDB.EpSubtitles.Add(subtitle)
                End While
            End Using
        End Using

        If _TVDB.ShowID > -1 AndAlso WithShow Then
            FillTVShowFromDB(_TVDB)
            FillTVSeasonFromDB(_TVDB, _TVDB.TVEp.Season)
        End If

        'Check if the file is available and ready to edit
        If File.Exists(_TVDB.Filename) Then _TVDB.IsOnlineEp = True

        Return _TVDB
    End Function
    ''' <summary>
    ''' Load all the information for a TV Episode (by episode path)
    ''' </summary>
    ''' <param name="sPath">Full path to the episode file</param>
    ''' <returns>Structures.DBTV object</returns>
    Public Function LoadTVEpFromDB(ByVal sPath As String, ByVal WithShow As Boolean) As Structures.DBTV
        Using SQLcommand As SQLite.SQLiteCommand = _myvideosDBConn.CreateCommand()
            ' One more Query Better then re-write all function again
            SQLcommand.CommandText = String.Concat("SELECT ID FROM TVEpPaths WHERE TVEpPath = ", sPath, ";")
            Using SQLreader As SQLite.SQLiteDataReader = SQLcommand.ExecuteReader()
                If SQLreader.Read Then
                    Return LoadTVEpFromDB(Convert.ToInt64(SQLreader("ID")), WithShow)
                Else
                    Return New Structures.DBTV With {.EpID = -1} ' No Movie Found
                End If
            End Using
        End Using

        Return New Structures.DBTV With {.EpID = -1}
    End Function
    ''' <summary>
    ''' Retrieve details for the given ShowID. If AllSeasonPosterEnabled is <c>True</c>, also retrieve the AllSeasonsPoster
    ''' </summary>
    ''' <param name="ShowID">Show ID to retrieve</param>
    ''' <returns>Structures.DBDV filled with show information.</returns>
    ''' <remarks></remarks>
    Public Function LoadTVFullShowFromDB(ByVal ShowID As Long) As Structures.DBTV
        If ShowID < 0 Then Throw New ArgumentOutOfRangeException("ShowID", "Value must be >= 0, was given: " & ShowID)

        If Master.eSettings.TVASPosterAnyEnabled Then
            Return Master.DB.LoadTVAllSeasonsFromDB(ShowID, True)
        Else
            Return Master.DB.LoadTVShowFromDB(ShowID)
        End If
    End Function
    ''' <summary>
    ''' Load all the information for a TV Season by ShowID and Season #.
    ''' </summary>
    ''' <param name="ShowID">ID of the show to load, as stored in the database</param>
    ''' <param name="iSeason">Number of the season to load, as stored in the database</param>
    ''' <param name="WithShow">If <c>True</c>, also retrieve the TV Show information</param>
    ''' <returns>Structures.DBTV object</returns>
    ''' <remarks></remarks>
    Public Function LoadTVSeasonFromDB(ByVal ShowID As Long, ByVal iSeason As Integer, ByVal WithShow As Boolean) As Structures.DBTV
        Dim _TVDB As New Structures.DBTV

        If ShowID < 0 Then Throw New ArgumentOutOfRangeException("ShowID", "Value must be >= 0, was given: " & ShowID)

        _TVDB.ShowID = ShowID
        If WithShow Then FillTVShowFromDB(_TVDB)
        _TVDB.TVEp = New MediaContainers.EpisodeDetails
        _TVDB.TVEp.Season = iSeason

        Using SQLcommandTVSeason As SQLite.SQLiteCommand = _myvideosDBConn.CreateCommand()
            SQLcommandTVSeason.CommandText = String.Concat("SELECT idSeason FROM seasons WHERE idShow = ", ShowID, " AND Season = ", iSeason, ";")
            Using SQLReader As SQLite.SQLiteDataReader = SQLcommandTVSeason.ExecuteReader
                If SQLReader.HasRows Then
                    SQLReader.Read()
                    _TVDB = LoadTVSeasonFromDB(CInt(SQLReader("idSeason")), WithShow)
                End If
            End Using
        End Using

        Return _TVDB
    End Function
    ''' <summary>
    ''' Load all the information for a TV Season by SeasonID.
    ''' </summary>
    ''' <param name="SeasonID">ID of the season to load, as stored in the database</param>
    ''' <param name="WithShow">If <c>True</c>, also retrieve the TV Show information</param>
    ''' <returns>Structures.DBTV object</returns>
    ''' <remarks></remarks>
    Public Function LoadTVSeasonFromDB(ByVal SeasonID As Long, ByVal WithShow As Boolean) As Structures.DBTV
        Dim _TVDB As New Structures.DBTV

        _TVDB.SeasonID = SeasonID
        _TVDB.TVEp = New MediaContainers.EpisodeDetails

        Using SQLcommandTVSeason As SQLite.SQLiteCommand = _myvideosDBConn.CreateCommand()
            SQLcommandTVSeason.CommandText = String.Concat("SELECT idShow, Season, Lock , Mark FROM seasons WHERE idSeason = ", _TVDB.SeasonID, ";")
            Using SQLReader As SQLite.SQLiteDataReader = SQLcommandTVSeason.ExecuteReader
                If SQLReader.HasRows Then
                    SQLReader.Read()
                    _TVDB.TVEp.Season = CInt(SQLReader("Season"))
                    _TVDB.ShowID = CInt(SQLReader("idShow"))
                    _TVDB.IsLockSeason = CBool(SQLReader("Lock"))
                    _TVDB.IsMarkSeason = CBool(SQLReader("Mark"))

                    _TVDB.SeasonBannerPath = GetArtForItem(_TVDB.SeasonID, "season", "banner")
                    _TVDB.SeasonFanartPath = GetArtForItem(_TVDB.SeasonID, "season", "fanart")
                    _TVDB.SeasonLandscapePath = GetArtForItem(_TVDB.SeasonID, "season", "landscape")
                    _TVDB.SeasonPosterPath = GetArtForItem(_TVDB.SeasonID, "season", "poster")
                End If
            End Using
        End Using

        If WithShow Then FillTVShowFromDB(_TVDB)

        Return _TVDB
    End Function
    ''' <summary>
    ''' Load all the information for a TV Show.
    ''' </summary>
    ''' <param name="ShowID">ID of the show to load, as stored in the database</param>
    ''' <returns>Structures.DBTV object</returns>
    Public Function LoadTVShowFromDB(ByVal ShowID As Long) As Structures.DBTV
        Dim _TVDB As New Structures.DBTV

        If ShowID < 0 Then Throw New ArgumentOutOfRangeException("ShowID", "Value must be >= 0, was given: " & ShowID)

        Try
            _TVDB.ShowID = ShowID
            Using SQLcommand As SQLite.SQLiteCommand = _myvideosDBConn.CreateCommand()
                SQLcommand.CommandText = String.Concat("SELECT idShow, ListTitle, New, Mark, TVShowPath, Source, TVDB, Lock, EpisodeGuide, ", _
                                                       "Plot, Genre, Premiered, Studio, MPAA, Rating, NfoPath, NeedsSave, Language, Ordering, ", _
                                                       "Status, ThemePath, ", _
                                                       "EFanartsPath, Runtime, Title, Votes, EpisodeSorting ", _
                                                       "FROM tvshow WHERE idShow = ", ShowID, ";")
                Using SQLreader As SQLite.SQLiteDataReader = SQLcommand.ExecuteReader()
                    If SQLreader.HasRows Then
                        SQLreader.Read()
                        If Not DBNull.Value.Equals(SQLreader("ListTitle")) Then _TVDB.ListTitle = SQLreader("ListTitle").ToString
                        If Not DBNull.Value.Equals(SQLreader("EFanartsPath")) Then _TVDB.ShowEFanartsPath = SQLreader("EFanartsPath").ToString
                        If Not DBNull.Value.Equals(SQLreader("Language")) Then _TVDB.ShowLanguage = SQLreader("Language").ToString
                        If Not DBNull.Value.Equals(SQLreader("NfoPath")) Then _TVDB.ShowNfoPath = SQLreader("NfoPath").ToString
                        If Not DBNull.Value.Equals(SQLreader("Source")) Then _TVDB.Source = SQLreader("Source").ToString
                        If Not DBNull.Value.Equals(SQLreader("TVShowPath")) Then _TVDB.ShowPath = SQLreader("TVShowPath").ToString
                        If Not DBNull.Value.Equals(SQLreader("ThemePath")) Then _TVDB.ShowThemePath = SQLreader("ThemePath").ToString

                        _TVDB.ShowBannerPath = GetArtForItem(_TVDB.ShowID, "tvshow", "banner")
                        _TVDB.ShowCharacterArtPath = GetArtForItem(_TVDB.ShowID, "tvshow", "characterart")
                        _TVDB.ShowClearArtPath = GetArtForItem(_TVDB.ShowID, "tvshow", "clearart")
                        _TVDB.ShowClearLogoPath = GetArtForItem(_TVDB.ShowID, "tvshow", "clearlogo")
                        _TVDB.ShowFanartPath = GetArtForItem(_TVDB.ShowID, "tvshow", "fanart")
                        _TVDB.ShowLandscapePath = GetArtForItem(_TVDB.ShowID, "tvshow", "landscape")
                        _TVDB.ShowPosterPath = GetArtForItem(_TVDB.ShowID, "tvshow", "poster")

                        _TVDB.IsMarkShow = Convert.ToBoolean(SQLreader("Mark"))
                        _TVDB.IsLockShow = Convert.ToBoolean(SQLreader("Lock"))
                        _TVDB.ShowNeedsSave = Convert.ToBoolean(SQLreader("NeedsSave"))
                        _TVDB.Ordering = DirectCast(Convert.ToInt32(SQLreader("Ordering")), Enums.Ordering)
                        _TVDB.EpisodeSorting = DirectCast(Convert.ToInt32(SQLreader("EpisodeSorting")), Enums.EpisodeSorting)
                        _TVDB.TVShow = New MediaContainers.TVShow
                        With _TVDB.TVShow
                            If Not DBNull.Value.Equals(SQLreader("Title")) Then .Title = SQLreader("Title").ToString
                            If Not DBNull.Value.Equals(SQLreader("TVDB")) Then .ID = SQLreader("TVDB").ToString
                            If Not DBNull.Value.Equals(SQLreader("EpisodeGuide")) Then .EpisodeGuide.URL = SQLreader("EpisodeGuide").ToString
                            If Not DBNull.Value.Equals(SQLreader("Plot")) Then .Plot = SQLreader("Plot").ToString
                            If Not DBNull.Value.Equals(SQLreader("Genre")) Then .Genre = SQLreader("Genre").ToString
                            If Not DBNull.Value.Equals(SQLreader("Premiered")) Then .Premiered = SQLreader("Premiered").ToString
                            If Not DBNull.Value.Equals(SQLreader("Studio")) Then .Studio = SQLreader("Studio").ToString
                            If Not DBNull.Value.Equals(SQLreader("MPAA")) Then .MPAA = SQLreader("MPAA").ToString
                            If Not DBNull.Value.Equals(SQLreader("Rating")) Then .Rating = SQLreader("Rating").ToString
                            If Not DBNull.Value.Equals(SQLreader("Status")) Then .Status = SQLreader("Status").ToString
                            If Not DBNull.Value.Equals(SQLreader("Runtime")) Then .Runtime = SQLreader("Runtime").ToString
                            If Not DBNull.Value.Equals(SQLreader("Votes")) Then .Votes = SQLreader("Votes").ToString
                        End With
                    End If
                End Using
            End Using

            'Actors
            Using SQLcommand As SQLite.SQLiteCommand = _myvideosDBConn.CreateCommand()
                SQLcommand.CommandText = String.Concat("SELECT A.strRole, B.idActor, B.strActor, B.strThumb, C.url FROM actorlinktvshow AS A ", _
                                                       "INNER JOIN actors AS B ON (A.idActor = B.idActor) ", _
                                                       "LEFT OUTER JOIN art AS C ON (B.idActor = C.media_id AND C.media_type = 'actor' AND C.type = 'thumb') ", _
                                                       "WHERE A.idShow = ", _TVDB.ShowID, " ", _
                                                       "ORDER BY A.iOrder;")
                Using SQLreader As SQLite.SQLiteDataReader = SQLcommand.ExecuteReader()
                    Dim person As MediaContainers.Person
                    While SQLreader.Read
                        person = New MediaContainers.Person
                        person.ID = Convert.ToInt64(SQLreader("idActor"))
                        person.Name = SQLreader("strActor").ToString
                        person.Role = SQLreader("strRole").ToString
                        person.ThumbPath = SQLreader("url").ToString
                        person.ThumbURL = SQLreader("strThumb").ToString
                        _TVDB.TVShow.Actors.Add(person)
                    End While
                End Using
            End Using

            'Tags
            Using SQLcommand As SQLite.SQLiteCommand = _myvideosDBConn.CreateCommand()
                SQLcommand.CommandText = String.Concat("SELECT B.strTag FROM taglinks ", _
                                                       "AS A INNER JOIN tag AS B ON (A.idTag = B.idTag) WHERE A.idMedia = ", _TVDB.ShowID, " AND A.media_type = 'tvshow';")
                Using SQLreader As SQLite.SQLiteDataReader = SQLcommand.ExecuteReader()
                    Dim tag As String
                    While SQLreader.Read
                        tag = String.Empty
                        If Not DBNull.Value.Equals(SQLreader("strTag")) Then tag = SQLreader("strTag").ToString
                        _TVDB.TVShow.Tags.Add(tag)
                    End While
                End Using
            End Using

        Catch ex As Exception
            logger.Error(New StackFrame().GetMethod().Name, ex)
            _TVDB.ShowID = -1
        End Try

        'Check if the path is available and ready to edit
        If Directory.Exists(_TVDB.ShowPath) Then _TVDB.isOnlineShow = True

        Return _TVDB
    End Function

    Private Sub bwPatchDB_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bwPatchDB.DoWork
        Dim Args As Arguments = DirectCast(e.Argument, Arguments)

        Dim xmlSer As XmlSerializer
        Dim _cmds As New Containers.InstallCommands
        Dim TransOk As Boolean
        Dim tempName As String = String.Empty

        tempName = String.Concat(Args.newDBPath, "_tmp")
        If File.Exists(tempName) Then
            File.Delete(tempName)
        End If
        File.Copy(Args.currDBPath, tempName)

        Try
            _myvideosDBConn = New SQLiteConnection(String.Format(_connStringTemplate, tempName))
            _myvideosDBConn.Open()

            For i As Integer = Args.currVersion To Args.newVersion - 1

                Dim patchpath As String = FileUtils.Common.ReturnSettingsFile("DB", String.Format("MyVideosDBSQL_v{0}_Patch.xml", i))

                xmlSer = New XmlSerializer(GetType(Containers.InstallCommands))
                Using xmlSW As New StreamReader(Path.Combine(Functions.AppPath, patchpath))
                    _cmds = DirectCast(xmlSer.Deserialize(xmlSW), Containers.InstallCommands)
                End Using

                For Each Trans In _cmds.transaction
                    TransOk = True
                    Using SQLtransaction As SQLite.SQLiteTransaction = _myvideosDBConn.BeginTransaction()
                        For Each _cmd As Containers.CommandsTransactionCommand In Trans.command
                            If _cmd.type = "DB" Then
                                Using SQLcommand As SQLite.SQLiteCommand = _myvideosDBConn.CreateCommand()
                                    SQLcommand.CommandText = _cmd.execute
                                    Try
                                        SQLcommand.ExecuteNonQuery()
                                        logger.Info(String.Concat(Trans.name, ": ", _cmd.description))
                                    Catch ex As Exception
                                        logger.Info(New StackFrame().GetMethod().Name, ex, Trans.name, _cmd.description)
                                        TransOk = False
                                        Exit For
                                    End Try
                                End Using
                            End If
                        Next
                        If TransOk Then
                            logger.Trace(New StackFrame().GetMethod().Name, String.Format("Transaction {0} Commit", Trans.name))
                            SQLtransaction.Commit()
                            ' Housekeeping - consolidate and pack database using vacuum command http://www.sqlite.org/lang_vacuum.html
                            Using SQLcommand As SQLite.SQLiteCommand = _myvideosDBConn.CreateCommand()
                                SQLcommand.CommandText = "VACUUM;"
                                SQLcommand.ExecuteNonQuery()
                            End Using
                        Else
                            logger.Trace(New StackFrame().GetMethod().Name, String.Format("Transaction {0} RollBack", Trans.name))
                            SQLtransaction.Rollback()
                        End If
                    End Using
                Next
                For Each _cmd As Containers.CommandsNoTransactionCommand In _cmds.noTransaction
                    If _cmd.type = "DB" Then
                        Using SQLnotransaction As SQLite.SQLiteCommand = _myvideosDBConn.CreateCommand()
                            SQLnotransaction.CommandText = _cmd.execute
                            Try
                                SQLnotransaction.ExecuteNonQuery()
                                ' Housekeeping - consolidate and pack database using vacuum command http://www.sqlite.org/lang_vacuum.html
                                Using SQLcommand As SQLite.SQLiteCommand = _myvideosDBConn.CreateCommand()
                                    SQLcommand.CommandText = "VACUUM;"
                                    SQLcommand.ExecuteNonQuery()
                                End Using
                            Catch ex As Exception
                                logger.Info(New StackFrame().GetMethod().Name, ex, SQLnotransaction, _cmd.description, _cmd.execute)
                            End Try
                        End Using
                    End If
                Next

            Next

            Using SQLtransaction As SQLite.SQLiteTransaction = _myvideosDBConn.BeginTransaction()
                Select Case Args.currVersion
                    Case Is < 14
                        PrepareTable_country("idMovie", "movie", True)
                        PrepareTable_director("idEpisode", "episode", True)
                        PrepareTable_director("idMovie", "movie", True)
                        PrepareTable_genre("idMovie", "movie", True)
                        PrepareTable_genre("idShow", "tvshow", True)
                        PrepareTable_studio("idMovie", "movie", True)
                        PrepareTable_studio("idShow", "tvshow", True)
                        PrepareTable_writer("idEpisode", "episode", True)
                        PrepareTable_writer("idMovie", "movie", True)
                        PreparePlaycounts("episode", True)
                        PreparePlaycounts("movie", True)
                End Select

                SQLtransaction.Commit()
            End Using

            Using SQLtransaction As SQLite.SQLiteTransaction = _myvideosDBConn.BeginTransaction()
                Select Case Args.currVersion
                    Case Is < 18
                        CleanVotesCount("idEpisode", "episode", True)
                        CleanVotesCount("idMovie", "movie", True)
                        CleanVotesCount("idShow", "tvshow", True)
                End Select

                SQLtransaction.Commit()
            End Using

            _myvideosDBConn.Close()
            File.Move(tempName, Args.newDBPath)
        Catch ex As Exception
            logger.Error(New StackFrame().GetMethod().Name & Convert.ToChar(Windows.Forms.Keys.Tab) & "Unable to open media database connection.", ex)
            _myvideosDBConn.Close()
        End Try
    End Sub

    Private Sub bwPatchDB_ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles bwPatchDB.ProgressChanged
        If e.ProgressPercentage = -1 Then
            Master.fLoading.SetLoadingMesg(e.UserState.ToString)
        End If
    End Sub

    Private Sub bwPatchDB_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bwPatchDB.RunWorkerCompleted
        Return
    End Sub
    ''' <summary>
    ''' Execute arbitrary SQL commands against the database. Commands are retrieved from fname. 
    ''' Commands are serialized Containers.InstallCommands. Only commands marked as CommandType DB are executed.
    ''' </summary>
    ''' <param name="cPath">path to current DB</param>
    ''' <param name="nPath">path for new DB</param>
    ''' <param name="cVersion">current version of DB to patch</param>
    ''' <param name="nVersion">lastest version of DB</param>
    ''' <remarks></remarks>
    Public Sub PatchDatabase_MyVideos(ByVal cPath As String, ByVal nPath As String, ByVal cVersion As Integer, ByVal nVersion As Integer)

        Master.fLoading.SetProgressBarStyle(ProgressBarStyle.Marquee)

        Me.bwPatchDB = New System.ComponentModel.BackgroundWorker
        Me.bwPatchDB.WorkerReportsProgress = True
        Me.bwPatchDB.WorkerSupportsCancellation = False
        Me.bwPatchDB.RunWorkerAsync(New Arguments With {.currDBPath = cPath, .currVersion = cVersion, .newDBPath = nPath, .newVersion = nVersion})

        While bwPatchDB.IsBusy
            Application.DoEvents()
            Threading.Thread.Sleep(50)
        End While
    End Sub

    Private Sub CleanVotesCount(ByVal idField As String, ByVal table As String, ByVal BatchMode As Boolean)
        bwPatchDB.ReportProgress(-1, "Clean Votes count...")

        Dim SQLtransaction As SQLite.SQLiteTransaction = Nothing
        If Not BatchMode Then SQLtransaction = _myvideosDBConn.BeginTransaction()

        Using SQLcommand As SQLite.SQLiteCommand = _myvideosDBConn.CreateCommand()
            SQLcommand.CommandText = String.Format("SELECT {0}, Votes FROM {1};", idField, table)
            Using SQLreader As SQLite.SQLiteDataReader = SQLcommand.ExecuteReader()
                While SQLreader.Read
                    If Not DBNull.Value.Equals(SQLreader("Votes")) AndAlso Not String.IsNullOrEmpty(SQLreader("Votes").ToString) AndAlso Not Integer.TryParse(SQLreader("Votes").ToString, 0) Then
                        Using SQLcommand_update_votes As SQLite.SQLiteCommand = _myvideosDBConn.CreateCommand()
                            SQLcommand_update_votes.CommandText = String.Format("UPDATE {0} SET Votes=? WHERE {1}={2}", table, idField, SQLreader(idField))
                            Dim par_update_Votes As SQLite.SQLiteParameter = SQLcommand_update_votes.Parameters.Add("par_update_Votes", DbType.String, 0, "Vote")
                            par_update_Votes.Value = NumUtils.CleanVotes(SQLreader("Votes").ToString)
                            SQLcommand_update_votes.ExecuteNonQuery()
                        End Using
                    End If
                End While
            End Using
        End Using

        If Not BatchMode Then SQLtransaction.Commit()
    End Sub

    Private Sub PrepareTable_country(ByVal idField As String, ByVal table As String, ByVal BatchMode As Boolean)
        bwPatchDB.ReportProgress(-1, "Get countries...")

        Dim SQLtransaction As SQLite.SQLiteTransaction = Nothing
        If Not BatchMode Then SQLtransaction = _myvideosDBConn.BeginTransaction()

        Using SQLcommand As SQLite.SQLiteCommand = _myvideosDBConn.CreateCommand()
            SQLcommand.CommandText = String.Format("SELECT {0}, country FROM {1};", idField, table)
            Using SQLreader As SQLite.SQLiteDataReader = SQLcommand.ExecuteReader()
                While SQLreader.Read
                    If Not DBNull.Value.Equals(SQLreader("country")) AndAlso Not String.IsNullOrEmpty(SQLreader("country").ToString) Then
                        Dim valuelist As New List(Of String)
                        Dim strValue As String = SQLreader("country").ToString
                        Dim idMedia As Long = Convert.ToInt64(SQLreader(idField))

                        If strValue.Contains("/") Then
                            Dim values As String() = strValue.Split(New [Char]() {"/"c})
                            For Each value As String In values
                                value = value.Trim
                                If Not valuelist.Contains(value) Then
                                    valuelist.Add(value)
                                End If
                            Next
                        Else
                            strValue = strValue.Trim
                            If Not valuelist.Contains(strValue) Then
                                valuelist.Add(strValue.Trim)
                            End If
                        End If

                        For Each value As String In valuelist
                            Select Case table
                                Case "movie"
                                    AddCountryToMovie(idMedia, AddCountry(value))
                            End Select
                        Next
                    End If
                End While
            End Using
        End Using

        If Not BatchMode Then SQLtransaction.Commit()
    End Sub

    Private Sub PrepareTable_director(ByVal idField As String, ByVal table As String, ByVal BatchMode As Boolean)
        bwPatchDB.ReportProgress(-1, "Get directors...")

        Dim SQLtransaction As SQLite.SQLiteTransaction = Nothing
        If Not BatchMode Then SQLtransaction = _myvideosDBConn.BeginTransaction()

        Using SQLcommand As SQLite.SQLiteCommand = _myvideosDBConn.CreateCommand()
            SQLcommand.CommandText = String.Format("SELECT {0}, director FROM {1};", idField, table)
            Using SQLreader As SQLite.SQLiteDataReader = SQLcommand.ExecuteReader()
                While SQLreader.Read
                    If Not DBNull.Value.Equals(SQLreader("director")) AndAlso Not String.IsNullOrEmpty(SQLreader("director").ToString) Then
                        Dim valuelist As New List(Of String)
                        Dim strValue As String = SQLreader("director").ToString
                        Dim idMedia As Long = Convert.ToInt64(SQLreader(idField))

                        If strValue.Contains("/") Then
                            Dim values As String() = strValue.Split(New [Char]() {"/"c})
                            For Each value As String In values
                                value = value.Trim
                                If Not valuelist.Contains(value) Then
                                    valuelist.Add(value)
                                End If
                            Next
                        Else
                            strValue = strValue.Trim
                            If Not valuelist.Contains(strValue) Then
                                valuelist.Add(strValue.Trim)
                            End If
                        End If

                        For Each value As String In valuelist
                            Select Case table
                                Case "episode"
                                    AddDirectorToEpisode(idMedia, AddActor(value, "", ""))
                                Case "movie"
                                    AddDirectorToMovie(idMedia, AddActor(value, "", ""))
                                Case "tvshow"
                                    AddDirectorToTvShow(idMedia, AddActor(value, "", ""))
                            End Select
                        Next
                    End If
                End While
            End Using
        End Using

        If Not BatchMode Then SQLtransaction.Commit()
    End Sub

    Private Sub PrepareTable_genre(ByVal idField As String, ByVal table As String, ByVal BatchMode As Boolean)
        bwPatchDB.ReportProgress(-1, "Get genres...")

        Dim SQLtransaction As SQLite.SQLiteTransaction = Nothing
        If Not BatchMode Then SQLtransaction = _myvideosDBConn.BeginTransaction()

        Using SQLcommand As SQLite.SQLiteCommand = _myvideosDBConn.CreateCommand()
            SQLcommand.CommandText = String.Format("SELECT {0}, genre FROM {1};", idField, table)
            Using SQLreader As SQLite.SQLiteDataReader = SQLcommand.ExecuteReader()
                While SQLreader.Read
                    If Not DBNull.Value.Equals(SQLreader("genre")) AndAlso Not String.IsNullOrEmpty(SQLreader("genre").ToString) Then
                        Dim valuelist As New List(Of String)
                        Dim strValue As String = SQLreader("genre").ToString
                        Dim idMedia As Long = Convert.ToInt64(SQLreader(idField))

                        If strValue.Contains("/") Then
                            Dim values As String() = strValue.Split(New [Char]() {"/"c})
                            For Each value As String In values
                                value = value.Trim
                                If Not valuelist.Contains(value) Then
                                    valuelist.Add(value)
                                End If
                            Next
                        Else
                            strValue = strValue.Trim
                            If Not valuelist.Contains(strValue) Then
                                valuelist.Add(strValue.Trim)
                            End If
                        End If

                        For Each value As String In valuelist
                            Select Case table
                                Case "movie"
                                    AddGenreToMovie(idMedia, AddGenre(value))
                                Case "tvshow"
                                    AddGenreToTvShow(idMedia, AddGenre(value))
                            End Select
                        Next
                    End If
                End While
            End Using
        End Using

        If Not BatchMode Then SQLtransaction.Commit()
    End Sub

    Private Sub PrepareTable_studio(ByVal idField As String, ByVal table As String, ByVal BatchMode As Boolean)
        bwPatchDB.ReportProgress(-1, "Get studios...")

        Dim SQLtransaction As SQLite.SQLiteTransaction = Nothing
        If Not BatchMode Then SQLtransaction = _myvideosDBConn.BeginTransaction()

        Using SQLcommand As SQLite.SQLiteCommand = _myvideosDBConn.CreateCommand()
            SQLcommand.CommandText = String.Format("SELECT {0}, studio FROM {1};", idField, table)
            Using SQLreader As SQLite.SQLiteDataReader = SQLcommand.ExecuteReader()
                While SQLreader.Read
                    If Not DBNull.Value.Equals(SQLreader("studio")) AndAlso Not String.IsNullOrEmpty(SQLreader("studio").ToString) Then
                        Dim valuelist As New List(Of String)
                        Dim strValue As String = SQLreader("studio").ToString
                        Dim idMedia As Long = Convert.ToInt64(SQLreader(idField))

                        If strValue.Contains("/") Then
                            Dim values As String() = strValue.Split(New [Char]() {"/"c})
                            For Each value As String In values
                                value = value.Trim
                                If Not valuelist.Contains(value) Then
                                    valuelist.Add(value)
                                End If
                            Next
                        Else
                            strValue = strValue.Trim
                            If Not valuelist.Contains(strValue) Then
                                valuelist.Add(strValue.Trim)
                            End If
                        End If

                        For Each value As String In valuelist
                            Select Case table
                                Case "movie"
                                    AddStudioToMovie(idMedia, AddStudio(value))
                                Case "tvshow"
                                    AddStudioToTvShow(idMedia, AddStudio(value))
                            End Select
                        Next
                    End If
                End While
            End Using
        End Using

        If Not BatchMode Then SQLtransaction.Commit()
    End Sub

    Private Sub PrepareTable_writer(ByVal idField As String, ByVal table As String, ByVal BatchMode As Boolean)
        bwPatchDB.ReportProgress(-1, "Get writers...")

        Dim SQLtransaction As SQLite.SQLiteTransaction = Nothing
        If Not BatchMode Then SQLtransaction = _myvideosDBConn.BeginTransaction()

        Using SQLcommand As SQLite.SQLiteCommand = _myvideosDBConn.CreateCommand()
            SQLcommand.CommandText = String.Format("SELECT {0}, credits FROM {1};", idField, table)
            Using SQLreader As SQLite.SQLiteDataReader = SQLcommand.ExecuteReader()
                While SQLreader.Read
                    If Not DBNull.Value.Equals(SQLreader("credits")) AndAlso Not String.IsNullOrEmpty(SQLreader("credits").ToString) Then
                        Dim valuelist As New List(Of String)
                        Dim strValue As String = SQLreader("credits").ToString
                        Dim idMedia As Long = Convert.ToInt64(SQLreader(idField))

                        If strValue.Contains("/") Then
                            Dim values As String() = strValue.Split(New [Char]() {"/"c})
                            For Each value As String In values
                                value = value.Trim
                                If Not valuelist.Contains(value) Then
                                    valuelist.Add(value)
                                End If
                            Next
                        Else
                            strValue = strValue.Trim
                            If Not valuelist.Contains(strValue) Then
                                valuelist.Add(strValue.Trim)
                            End If
                        End If

                        For Each value As String In valuelist
                            Select Case table
                                Case "episode"
                                    AddWriterToEpisode(idMedia, AddActor(value, "", ""))
                                Case "movie"
                                    AddWriterToMovie(idMedia, AddActor(value, "", ""))
                            End Select
                        Next
                    End If
                End While
            End Using
        End Using

        If Not BatchMode Then SQLtransaction.Commit()
    End Sub

    Private Sub PreparePlaycounts(ByVal table As String, ByVal BatchMode As Boolean)
        bwPatchDB.ReportProgress(-1, "Fixing Playcounts...")

        Dim SQLtransaction As SQLite.SQLiteTransaction = Nothing
        If Not BatchMode Then SQLtransaction = _myvideosDBConn.BeginTransaction()

        Using SQLcommand As SQLite.SQLiteCommand = _myvideosDBConn.CreateCommand()
            SQLcommand.CommandText = String.Format("UPDATE {0} SET Playcount = NULL WHERE Playcount = 0 OR Playcount = """";", table)
            SQLcommand.ExecuteNonQuery()
        End Using

        If Not BatchMode Then SQLtransaction.Commit()
    End Sub

    '  Public Function CheckEssentials() As Boolean
    'Dim needUpdate As Boolean = False
    'Dim lhttp As New HTTP
    'If Not File.Exists(Path.Combine(Functions.AppPath, "Media.emm")) Then
    '	System.IO.File.Copy(Path.Combine(Path.Combine(Functions.AppPath, "Resources"), "commands_base.xml"), Path.Combine(Functions.AppPath, "InstallTasks.xml"))
    '	'lhttp.DownloadFile(String.Format("http://pcjco.dommel.be/emm-r/{0}/commands_base.xml", If(Functions.IsBetaEnabled(), "updatesbeta", "updates")), Path.Combine(Functions.AppPath, "InstallTasks.xml"), False, "other")
    'End If
    'If File.Exists(Path.Combine(Functions.AppPath, "InstallTasks.xml")) Then
    '	Master.DB.PatchDatabase("InstallTasks.xml")
    '	File.Delete(Path.Combine(Functions.AppPath, "InstallTasks.xml"))
    '	needUpdate = True
    'End If
    'If File.Exists(Path.Combine(Functions.AppPath, "UpdateTasks.xml")) Then
    '	Master.DB.PatchDatabase("UpdateTasks.xml")
    '	File.Delete(Path.Combine(Functions.AppPath, "UpdateTasks.xml"))
    '	needUpdate = True
    'End If
    'Return needUpdate
    '  End Function

    ''' <summary>
    ''' Saves all information from a Structures.DBMovie object to the database
    ''' </summary>
    ''' <param name="_movieDB">Media.Movie object to save to the database</param>
    ''' <param name="IsNew">Is this a new movie (not already present in database)?</param>
    ''' <param name="BatchMode">Is the function already part of a transaction?</param>
    ''' <param name="ToNfo">Save the information to an nfo file?</param>
    ''' <returns>Structures.DBMovie object</returns>
    Public Function SaveMovieToDB(ByVal _movieDB As Structures.DBMovie, ByVal IsNew As Boolean, Optional ByVal BatchMode As Boolean = False, Optional ByVal ToNfo As Boolean = False) As Structures.DBMovie
        'TODO Must add parameter checking. Needs thought to ensure calling routines are not broken if exception thrown. 
        'TODO Break this method into smaller chunks. Too important to be this complex

        Dim SQLtransaction As SQLite.SQLiteTransaction = Nothing
        If Not BatchMode Then SQLtransaction = _myvideosDBConn.BeginTransaction()
        Using SQLcommand_movie As SQLite.SQLiteCommand = _myvideosDBConn.CreateCommand()
            If IsNew Then
                SQLcommand_movie.CommandText = String.Concat("INSERT OR REPLACE INTO movie (", _
                 "MoviePath, Type, ListTitle, HasSub, New, Mark, Source, Imdb, Lock, ", _
                 "Title, OriginalTitle, SortTitle, Year, Rating, Votes, MPAA, Top250, Country, Outline, Plot, Tagline, Certification, Genre, ", _
                 "Studio, Runtime, ReleaseDate, Director, Credits, Playcount, Trailer, ", _
                 "NfoPath, TrailerPath, SubPath, EThumbsPath, FanartURL, UseFolder, OutOfTolerance, VideoSource, NeedsSave, ", _
                 "DateAdded, EFanartsPath, ThemePath, ", _
                 "TMDB, TMDBColID, DateModified, MarkCustom1, MarkCustom2, MarkCustom3, MarkCustom4, HasSet", _
                 ") VALUES (?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?); SELECT LAST_INSERT_ROWID() FROM movie;")
            Else
                SQLcommand_movie.CommandText = String.Concat("INSERT OR REPLACE INTO movie (", _
                 "idMovie, MoviePath, Type, ListTitle, HasSub, New, Mark, Source, Imdb, Lock, ", _
                 "Title, OriginalTitle, SortTitle, Year, Rating, Votes, MPAA, Top250, Country, Outline, Plot, Tagline, Certification, Genre, ", _
                 "Studio, Runtime, ReleaseDate, Director, Credits, Playcount, Trailer, ", _
                 "NfoPath, TrailerPath, SubPath, EThumbsPath, FanartURL, UseFolder, OutOfTolerance, VideoSource, NeedsSave, ", _
                 "DateAdded, EFanartsPath, ThemePath, ", _
                 "TMDB, TMDBColID, DateModified, MarkCustom1, MarkCustom2, MarkCustom3, MarkCustom4, HasSet", _
                 ") VALUES (?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?); SELECT LAST_INSERT_ROWID() FROM movie;")
                Dim parMovieID As SQLite.SQLiteParameter = SQLcommand_movie.Parameters.Add("paridMovie", DbType.Int32, 0, "idMovie")
                parMovieID.Value = _movieDB.ID
            End If
            Dim par_movie_MoviePath As SQLite.SQLiteParameter = SQLcommand_movie.Parameters.Add("par_movie_MoviePath", DbType.String, 0, "MoviePath")
            Dim par_movie_Type As SQLite.SQLiteParameter = SQLcommand_movie.Parameters.Add("par_movie_Type", DbType.Boolean, 0, "Type")
            Dim par_movie_ListTitle As SQLite.SQLiteParameter = SQLcommand_movie.Parameters.Add("par_movie_ListTitle", DbType.String, 0, "ListTitle")
            Dim par_movie_HasSub As SQLite.SQLiteParameter = SQLcommand_movie.Parameters.Add("par_movie_HasSub", DbType.Boolean, 0, "HasSub")
            Dim par_movie_New As SQLite.SQLiteParameter = SQLcommand_movie.Parameters.Add("par_movie_New", DbType.Boolean, 0, "New")
            Dim par_movie_Mark As SQLite.SQLiteParameter = SQLcommand_movie.Parameters.Add("par_movie_Mark", DbType.Boolean, 0, "Mark")
            Dim par_movie_Source As SQLite.SQLiteParameter = SQLcommand_movie.Parameters.Add("par_movie_Source", DbType.String, 0, "Source")
            Dim par_movie_Imdb As SQLite.SQLiteParameter = SQLcommand_movie.Parameters.Add("par_movie_Imdb", DbType.String, 0, "Imdb")
            Dim par_movie_Lock As SQLite.SQLiteParameter = SQLcommand_movie.Parameters.Add("par_movie_Lock", DbType.Boolean, 0, "Lock")
            Dim par_movie_Title As SQLite.SQLiteParameter = SQLcommand_movie.Parameters.Add("par_movie_Title", DbType.String, 0, "Title")
            Dim par_movie_OriginalTitle As SQLite.SQLiteParameter = SQLcommand_movie.Parameters.Add("par_movie_OriginalTitle", DbType.String, 0, "OriginalTitle")
            Dim par_movie_SortTitle As SQLite.SQLiteParameter = SQLcommand_movie.Parameters.Add("par_movie_SortTitle", DbType.String, 0, "SortTitle")
            Dim par_movie_Year As SQLite.SQLiteParameter = SQLcommand_movie.Parameters.Add("par_movie_Year", DbType.String, 0, "Year")
            Dim par_movie_Rating As SQLite.SQLiteParameter = SQLcommand_movie.Parameters.Add("par_movie_Rating", DbType.String, 0, "Rating")
            Dim par_movie_Votes As SQLite.SQLiteParameter = SQLcommand_movie.Parameters.Add("par_movie_Votes", DbType.String, 0, "Votes")
            Dim par_movie_MPAA As SQLite.SQLiteParameter = SQLcommand_movie.Parameters.Add("par_movie_MPAA", DbType.String, 0, "MPAA")
            Dim par_movie_Top250 As SQLite.SQLiteParameter = SQLcommand_movie.Parameters.Add("par_movie_Top250", DbType.String, 0, "Top250")
            Dim par_movie_Country As SQLite.SQLiteParameter = SQLcommand_movie.Parameters.Add("par_movie_Country", DbType.String, 0, "Country")
            Dim par_movie_Outline As SQLite.SQLiteParameter = SQLcommand_movie.Parameters.Add("par_movie_Outline", DbType.String, 0, "Outline")
            Dim par_movie_Plot As SQLite.SQLiteParameter = SQLcommand_movie.Parameters.Add("par_movie_Plot", DbType.String, 0, "Plot")
            Dim par_movie_Tagline As SQLite.SQLiteParameter = SQLcommand_movie.Parameters.Add("par_movie_Tagline", DbType.String, 0, "Tagline")
            Dim par_movie_Certification As SQLite.SQLiteParameter = SQLcommand_movie.Parameters.Add("par_movie_Certification", DbType.String, 0, "Certification")
            Dim par_movie_Genre As SQLite.SQLiteParameter = SQLcommand_movie.Parameters.Add("par_movie_Genre", DbType.String, 0, "Genre")
            Dim par_movie_Studio As SQLite.SQLiteParameter = SQLcommand_movie.Parameters.Add("par_movie_Studio", DbType.String, 0, "Studio")
            Dim par_movie_Runtime As SQLite.SQLiteParameter = SQLcommand_movie.Parameters.Add("par_movie_Runtime", DbType.String, 0, "Runtime")
            Dim par_movie_ReleaseDate As SQLite.SQLiteParameter = SQLcommand_movie.Parameters.Add("par_movie_ReleaseDate", DbType.String, 0, "ReleaseDate")
            Dim par_movie_Director As SQLite.SQLiteParameter = SQLcommand_movie.Parameters.Add("par_movie_Director", DbType.String, 0, "Director")
            Dim par_movie_Credits As SQLite.SQLiteParameter = SQLcommand_movie.Parameters.Add("par_movie_Credits", DbType.String, 0, "Credits")
            Dim par_movie_Playcount As SQLite.SQLiteParameter = SQLcommand_movie.Parameters.Add("par_movie_Playcount", DbType.String, 0, "Playcount")
            Dim par_movie_Trailer As SQLite.SQLiteParameter = SQLcommand_movie.Parameters.Add("par_movie_Trailer", DbType.String, 0, "Trailer")
            Dim par_movie_NfoPath As SQLite.SQLiteParameter = SQLcommand_movie.Parameters.Add("par_movie_NfoPath", DbType.String, 0, "NfoPath")
            Dim par_movie_TrailerPath As SQLite.SQLiteParameter = SQLcommand_movie.Parameters.Add("par_movie_TrailerPath", DbType.String, 0, "TrailerPath")
            Dim par_movie_SubPath As SQLite.SQLiteParameter = SQLcommand_movie.Parameters.Add("par_movie_SubPath", DbType.String, 0, "SubPath")
            Dim par_movie_EThumbsPath As SQLite.SQLiteParameter = SQLcommand_movie.Parameters.Add("par_movie_EThumbsPath", DbType.String, 0, "EThumbsPath")
            Dim par_movie_FanartURL As SQLite.SQLiteParameter = SQLcommand_movie.Parameters.Add("par_movie_FanartURL", DbType.String, 0, "FanartURL")
            Dim par_movie_UseFolder As SQLite.SQLiteParameter = SQLcommand_movie.Parameters.Add("par_movie_UseFolder", DbType.Boolean, 0, "UseFolder")
            Dim par_movie_OutOfTolerance As SQLite.SQLiteParameter = SQLcommand_movie.Parameters.Add("par_movie_OutOfTolerance", DbType.Boolean, 0, "OutOfTolerance")
            Dim par_movie_VideoSource As SQLite.SQLiteParameter = SQLcommand_movie.Parameters.Add("par_movie_VideoSource", DbType.String, 0, "VideoSource")
            Dim par_movie_NeedsSave As SQLite.SQLiteParameter = SQLcommand_movie.Parameters.Add("par_movie_NeedsSave", DbType.Boolean, 0, "NeedsSave")
            Dim par_movie_DateAdded As SQLite.SQLiteParameter = SQLcommand_movie.Parameters.Add("par_movie_DateAdded", DbType.Int32, 0, "DateAdded")
            Dim par_movie_EFanartsPath As SQLite.SQLiteParameter = SQLcommand_movie.Parameters.Add("par_movie_EFanartsPath", DbType.String, 0, "EFanartsPath")
            Dim par_movie_ThemePath As SQLite.SQLiteParameter = SQLcommand_movie.Parameters.Add("par_movie_ThemePath", DbType.String, 0, "ThemePath")
            Dim par_movie_TMDB As SQLite.SQLiteParameter = SQLcommand_movie.Parameters.Add("par_movie_TMDB", DbType.String, 0, "TMDB")
            Dim par_movie_TMDBColID As SQLite.SQLiteParameter = SQLcommand_movie.Parameters.Add("par_movie_TMDBColID", DbType.String, 0, "TMDBColID")
            Dim par_movie_DateModified As SQLite.SQLiteParameter = SQLcommand_movie.Parameters.Add("par_movie_DateModified", DbType.Int32, 0, "DateModified")
            Dim par_movie_MarkCustom1 As SQLite.SQLiteParameter = SQLcommand_movie.Parameters.Add("par_movie_MarkCustom1", DbType.Boolean, 0, "MarkCustom1")
            Dim par_movie_MarkCustom2 As SQLite.SQLiteParameter = SQLcommand_movie.Parameters.Add("par_movie_MarkCustom2", DbType.Boolean, 0, "MarkCustom2")
            Dim par_movie_MarkCustom3 As SQLite.SQLiteParameter = SQLcommand_movie.Parameters.Add("par_movie_MarkCustom3", DbType.Boolean, 0, "MarkCustom3")
            Dim par_movie_MarkCustom4 As SQLite.SQLiteParameter = SQLcommand_movie.Parameters.Add("par_movie_MarkCustom4", DbType.Boolean, 0, "MarkCustom4")
            Dim par_movie_HasSet As SQLite.SQLiteParameter = SQLcommand_movie.Parameters.Add("par_movie_HasSet", DbType.Boolean, 0, "HasSet")

            Try
                If Not Master.eSettings.GeneralDateAddedIgnoreNFO AndAlso Not String.IsNullOrEmpty(_movieDB.Movie.DateAdded) Then
                    Dim DateTimeAdded As DateTime = DateTime.ParseExact(_movieDB.Movie.DateAdded, "yyyy-MM-dd HH:mm:ss", Globalization.CultureInfo.InvariantCulture)
                    par_movie_DateAdded.Value = Functions.ConvertToUnixTimestamp(DateTimeAdded)
                Else
                    Select Case Master.eSettings.GeneralDateTime
                        Case Enums.DateTime.Now
                            par_movie_DateAdded.Value = If(IsNew, Functions.ConvertToUnixTimestamp(DateTime.Now), _movieDB.DateAdded)
                        Case Enums.DateTime.mtime
                            Dim mtime As Date = System.IO.File.GetLastWriteTime(_movieDB.Filename)
                            If mtime.Year > 1601 Then
                                par_movie_DateAdded.Value = Functions.ConvertToUnixTimestamp(mtime)
                            Else
                                Dim ctime As Date = System.IO.File.GetCreationTime(_movieDB.Filename)
                                par_movie_DateAdded.Value = Functions.ConvertToUnixTimestamp(ctime)
                            End If
                        Case Enums.DateTime.Newer
                            Dim mtime As Date = System.IO.File.GetLastWriteTime(_movieDB.Filename)
                            Dim ctime As Date = System.IO.File.GetCreationTime(_movieDB.Filename)
                            If mtime > ctime Then
                                par_movie_DateAdded.Value = Functions.ConvertToUnixTimestamp(mtime)
                            Else
                                par_movie_DateAdded.Value = Functions.ConvertToUnixTimestamp(ctime)
                            End If
                    End Select
                End If
                _movieDB.Movie.DateAdded = Functions.ConvertFromUnixTimestamp(Convert.ToInt64(par_movie_DateAdded.Value)).ToString("yyyy-MM-dd HH:mm:ss")
            Catch
                par_movie_DateAdded.Value = If(IsNew, Functions.ConvertToUnixTimestamp(DateTime.Now), _movieDB.DateAdded)
                _movieDB.Movie.DateAdded = Functions.ConvertFromUnixTimestamp(Convert.ToInt64(par_movie_DateAdded.Value)).ToString("yyyy-MM-dd HH:mm:ss")
            End Try

            Try
                If IsNew AndAlso Not String.IsNullOrEmpty(_movieDB.Movie.DateModified) Then
                    Dim DateTimeDateModified As DateTime = DateTime.ParseExact(_movieDB.Movie.DateModified, "yyyy-MM-dd HH:mm:ss", Globalization.CultureInfo.InvariantCulture)
                    par_movie_DateModified.Value = Functions.ConvertToUnixTimestamp(DateTimeDateModified)
                ElseIf Not IsNew Then
                    par_movie_DateModified.Value = Functions.ConvertToUnixTimestamp(DateTime.Now)
                End If
                If par_movie_DateModified.Value IsNot Nothing Then
                    _movieDB.Movie.DateModified = Functions.ConvertFromUnixTimestamp(Convert.ToInt64(par_movie_DateModified.Value)).ToString("yyyy-MM-dd HH:mm:ss")
                Else
                    _movieDB.Movie.DateModified = String.Empty
                End If
            Catch
                par_movie_DateModified.Value = If(IsNew, Functions.ConvertToUnixTimestamp(DateTime.Now), _movieDB.DateModified)
                _movieDB.Movie.DateModified = Functions.ConvertFromUnixTimestamp(Convert.ToInt64(par_movie_DateAdded.Value)).ToString("yyyy-MM-dd HH:mm:ss")
            End Try

            ' First let's save it to NFO, even because we will need the NFO path
            If ToNfo Then NFO.SaveMovieToNFO(_movieDB)

            par_movie_MoviePath.Value = _movieDB.Filename
            par_movie_Type.Value = _movieDB.IsSingle
            par_movie_ListTitle.Value = _movieDB.ListTitle

            par_movie_EFanartsPath.Value = _movieDB.EFanartsPath
            par_movie_EThumbsPath.Value = _movieDB.EThumbsPath
            par_movie_NfoPath.Value = _movieDB.NfoPath
            par_movie_SubPath.Value = _movieDB.SubPath
            par_movie_ThemePath.Value = _movieDB.ThemePath
            par_movie_TrailerPath.Value = _movieDB.TrailerPath

            If Not Master.eSettings.MovieNoSaveImagesToNfo Then
                par_movie_FanartURL.Value = _movieDB.Movie.Fanart.URL
            Else
                par_movie_FanartURL.Value = String.Empty
            End If

            par_movie_HasSet.Value = _movieDB.Movie.Sets.Count > 0
            If _movieDB.Subtitles Is Nothing = False Then
                par_movie_HasSub.Value = _movieDB.Subtitles.Count > 0 OrElse _movieDB.Movie.FileInfo.StreamDetails.Subtitle.Count > 0
            Else
                par_movie_HasSub.Value = Nothing
            End If

            par_movie_Lock.Value = _movieDB.IsLock
            par_movie_Mark.Value = _movieDB.IsMark
            par_movie_MarkCustom1.Value = _movieDB.IsMarkCustom1
            par_movie_MarkCustom2.Value = _movieDB.IsMarkCustom2
            par_movie_MarkCustom3.Value = _movieDB.IsMarkCustom3
            par_movie_MarkCustom4.Value = _movieDB.IsMarkCustom4
            par_movie_New.Value = IsNew

            With _movieDB.Movie
                par_movie_Certification.Value = .Certification
                par_movie_Country.Value = .Country
                par_movie_Credits.Value = .OldCredits
                par_movie_Director.Value = .Director
                par_movie_Genre.Value = .Genre
                par_movie_Imdb.Value = .IMDBID
                par_movie_MPAA.Value = .MPAA
                par_movie_OriginalTitle.Value = .OriginalTitle
                par_movie_Outline.Value = .Outline
                par_movie_Playcount.Value = If(Not String.IsNullOrEmpty(.PlayCount) AndAlso CInt(.PlayCount) > 0, .PlayCount, Nothing) 'need to be NOTHING instead of "0"
                par_movie_Plot.Value = .Plot
                par_movie_Rating.Value = .Rating
                par_movie_ReleaseDate.Value = .ReleaseDate
                par_movie_Runtime.Value = .Runtime
                par_movie_SortTitle.Value = .SortTitle
                par_movie_Studio.Value = .Studio
                par_movie_TMDB.Value = .TMDBID
                par_movie_TMDBColID.Value = .TMDBColID
                par_movie_Tagline.Value = .Tagline
                par_movie_Title.Value = .Title
                par_movie_Top250.Value = .Top250
                par_movie_Trailer.Value = .Trailer
                par_movie_Votes.Value = NumUtils.CleanVotes(.Votes)
                par_movie_Year.Value = .Year
            End With

            par_movie_NeedsSave.Value = _movieDB.NeedsSave
            par_movie_OutOfTolerance.Value = _movieDB.OutOfTolerance
            par_movie_UseFolder.Value = _movieDB.UseFolder
            par_movie_VideoSource.Value = _movieDB.VideoSource

            par_movie_Source.Value = _movieDB.Source

            If IsNew Then
                If Master.eSettings.MovieGeneralMarkNew Then
                    par_movie_Mark.Value = True
                Else
                    par_movie_Mark.Value = False
                End If
                Using rdrMovie As SQLite.SQLiteDataReader = SQLcommand_movie.ExecuteReader()
                    If rdrMovie.Read Then
                        _movieDB.ID = Convert.ToInt64(rdrMovie(0))
                    Else
                        logger.Error("Something very wrong here: SaveMovieToDB", _movieDB.ToString)
                        _movieDB.ID = -1
                        Return _movieDB
                    End If
                End Using
            Else
                SQLcommand_movie.ExecuteNonQuery()
            End If

            If Not _movieDB.ID = -1 Then

                'Actors
                Using SQLcommand_actorlinkmovie As SQLite.SQLiteCommand = _myvideosDBConn.CreateCommand()
                    SQLcommand_actorlinkmovie.CommandText = String.Format("DELETE FROM actorlinkmovie WHERE idMovie = {0};", _movieDB.ID)
                    SQLcommand_actorlinkmovie.ExecuteNonQuery()
                End Using
                AddCast(_movieDB.ID, "movie", "movie", _movieDB.Movie.Actors)

                'Countries
                Using SQLcommand_countrylinkmovie As SQLite.SQLiteCommand = _myvideosDBConn.CreateCommand()
                    SQLcommand_countrylinkmovie.CommandText = String.Format("DELETE FROM countrylinkmovie WHERE idMovie = {0};", _movieDB.ID)
                    SQLcommand_countrylinkmovie.ExecuteNonQuery()
                End Using
                For Each country As String In _movieDB.Movie.Countries
                    AddCountryToMovie(_movieDB.ID, AddCountry(country))
                Next

                'Directors
                Using SQLcommand_directorlinkmovie As SQLite.SQLiteCommand = _myvideosDBConn.CreateCommand()
                    SQLcommand_directorlinkmovie.CommandText = String.Format("DELETE FROM directorlinkmovie WHERE idMovie = {0};", _movieDB.ID)
                    SQLcommand_directorlinkmovie.ExecuteNonQuery()
                End Using
                For Each director As String In _movieDB.Movie.Directors
                    AddDirectorToMovie(_movieDB.ID, AddActor(director, "", ""))
                Next

                'Genres
                Using SQLcommand_genrelinkmovie As SQLite.SQLiteCommand = _myvideosDBConn.CreateCommand()
                    SQLcommand_genrelinkmovie.CommandText = String.Format("DELETE FROM genrelinkmovie WHERE idMovie = {0};", _movieDB.ID)
                    SQLcommand_genrelinkmovie.ExecuteNonQuery()
                End Using
                For Each genre As String In _movieDB.Movie.Genres
                    AddGenreToMovie(_movieDB.ID, AddGenre(genre))
                Next

                'Images
                Using SQLcommand_art As SQLite.SQLiteCommand = _myvideosDBConn.CreateCommand()
                    SQLcommand_art.CommandText = String.Format("DELETE FROM art WHERE media_id = {0} AND media_type = 'movie';", _movieDB.ID)
                    SQLcommand_art.ExecuteNonQuery()
                End Using
                If Not String.IsNullOrEmpty(_movieDB.BannerPath) Then SetArtForItem(_movieDB.ID, "movie", "banner", _movieDB.BannerPath)
                If Not String.IsNullOrEmpty(_movieDB.ClearArtPath) Then SetArtForItem(_movieDB.ID, "movie", "clearart", _movieDB.ClearArtPath)
                If Not String.IsNullOrEmpty(_movieDB.ClearLogoPath) Then SetArtForItem(_movieDB.ID, "movie", "clearlogo", _movieDB.ClearLogoPath)
                If Not String.IsNullOrEmpty(_movieDB.DiscArtPath) Then SetArtForItem(_movieDB.ID, "movie", "discart", _movieDB.DiscArtPath)
                If Not String.IsNullOrEmpty(_movieDB.FanartPath) Then SetArtForItem(_movieDB.ID, "movie", "fanart", _movieDB.FanartPath)
                If Not String.IsNullOrEmpty(_movieDB.LandscapePath) Then SetArtForItem(_movieDB.ID, "movie", "landscape", _movieDB.LandscapePath)
                If Not String.IsNullOrEmpty(_movieDB.PosterPath) Then SetArtForItem(_movieDB.ID, "movie", "poster", _movieDB.PosterPath)

                'Studios
                Using SQLcommand_studiolinkmovie As SQLite.SQLiteCommand = _myvideosDBConn.CreateCommand()
                    SQLcommand_studiolinkmovie.CommandText = String.Format("DELETE FROM studiolinkmovie WHERE idMovie = {0};", _movieDB.ID)
                    SQLcommand_studiolinkmovie.ExecuteNonQuery()
                End Using
                For Each studio As String In _movieDB.Movie.Studios
                    AddStudioToMovie(_movieDB.ID, AddStudio(studio))
                Next

                'Tags
                Using SQLcommand_taglinks As SQLite.SQLiteCommand = _myvideosDBConn.CreateCommand()
                    SQLcommand_taglinks.CommandText = String.Format("DELETE FROM taglinks WHERE idMedia = {0} AND media_type = 'movie';", _movieDB.ID)
                    SQLcommand_taglinks.ExecuteNonQuery()
                End Using
                For Each tag As String In _movieDB.Movie.Tags
                    AddTagToItem(_movieDB.ID, AddTag(tag), "movie")
                Next

                'Writers
                Using SQLcommand_writerlinkmovie As SQLite.SQLiteCommand = _myvideosDBConn.CreateCommand()
                    SQLcommand_writerlinkmovie.CommandText = String.Format("DELETE FROM writerlinkmovie WHERE idMovie = {0};", _movieDB.ID)
                    SQLcommand_writerlinkmovie.ExecuteNonQuery()
                End Using
                For Each writer As String In _movieDB.Movie.Credits
                    AddWriterToMovie(_movieDB.ID, AddActor(writer, "", ""))
                Next

                'Video Streams
                Using SQLcommandMoviesVStreams As SQLite.SQLiteCommand = _myvideosDBConn.CreateCommand()
                    SQLcommandMoviesVStreams.CommandText = String.Format("DELETE FROM MoviesVStreams WHERE MovieID = {0};", _movieDB.ID)
                    SQLcommandMoviesVStreams.ExecuteNonQuery()

                    'Expanded SQL Statement to INSERT/replace new fields
                    SQLcommandMoviesVStreams.CommandText = String.Concat("INSERT OR REPLACE INTO MoviesVStreams (", _
                       "MovieID, StreamID, Video_Width,Video_Height,Video_Codec,Video_Duration, Video_ScanType, Video_AspectDisplayRatio, ", _
                       "Video_Language, Video_LongLanguage, Video_Bitrate, Video_MultiViewCount, Video_EncodedSettings, Video_MultiViewLayout, ", _
                       "Video_StereoMode) VALUES (?,?,?,?,?,?,?,?,?,?,?,?,?,?,?);")

                    Dim parVideo_MovieID As SQLite.SQLiteParameter = SQLcommandMoviesVStreams.Parameters.Add("parVideo_MovieID", DbType.UInt64, 0, "MovieID")
                    Dim parVideo_StreamID As SQLite.SQLiteParameter = SQLcommandMoviesVStreams.Parameters.Add("parVideo_StreamID", DbType.UInt64, 0, "StreamID")
                    Dim parVideo_Width As SQLite.SQLiteParameter = SQLcommandMoviesVStreams.Parameters.Add("parVideo_Width", DbType.String, 0, "Video_Width")
                    Dim parVideo_Height As SQLite.SQLiteParameter = SQLcommandMoviesVStreams.Parameters.Add("parVideo_Height", DbType.String, 0, "Video_Height")
                    Dim parVideo_Codec As SQLite.SQLiteParameter = SQLcommandMoviesVStreams.Parameters.Add("parVideo_Codec", DbType.String, 0, "Video_Codec")
                    Dim parVideo_Duration As SQLite.SQLiteParameter = SQLcommandMoviesVStreams.Parameters.Add("parVideo_Duration", DbType.String, 0, "Video_Duration")
                    Dim parVideo_ScanType As SQLite.SQLiteParameter = SQLcommandMoviesVStreams.Parameters.Add("parVideo_ScanType", DbType.String, 0, "Video_ScanType")
                    Dim parVideo_AspectDisplayRatio As SQLite.SQLiteParameter = SQLcommandMoviesVStreams.Parameters.Add("parVideo_AspectDisplayRatio", DbType.String, 0, "Video_AspectDisplayRatio")
                    Dim parVideo_Language As SQLite.SQLiteParameter = SQLcommandMoviesVStreams.Parameters.Add("parVideo_Language", DbType.String, 0, "Video_Language")
                    Dim parVideo_LongLanguage As SQLite.SQLiteParameter = SQLcommandMoviesVStreams.Parameters.Add("parVideo_LongLanguage", DbType.String, 0, "Video_LongLanguage")
                    Dim parVideo_Bitrate As SQLite.SQLiteParameter = SQLcommandMoviesVStreams.Parameters.Add("parVideo_Bitrate", DbType.String, 0, "Video_Bitrate")
                    Dim parVideo_MultiViewCount As SQLite.SQLiteParameter = SQLcommandMoviesVStreams.Parameters.Add("parVideo_MultiViewCount", DbType.String, 0, "Video_MultiViewCount")
                    Dim parVideo_EncodedSettings As SQLite.SQLiteParameter = SQLcommandMoviesVStreams.Parameters.Add("parVideo_EncodedSettings", DbType.String, 0, "Video_EncodedSettings")
                    Dim parVideo_MultiViewLayout As SQLite.SQLiteParameter = SQLcommandMoviesVStreams.Parameters.Add("parVideo_MultiViewLayout", DbType.String, 0, "Video_MultiViewLayout")
                    Dim parVideo_StereoMode As SQLite.SQLiteParameter = SQLcommandMoviesVStreams.Parameters.Add("parVideo_StereoMode", DbType.String, 0, "Video_StereoMode")

                    For i As Integer = 0 To _movieDB.Movie.FileInfo.StreamDetails.Video.Count - 1
                        parVideo_MovieID.Value = _movieDB.ID
                        parVideo_StreamID.Value = i
                        parVideo_Width.Value = _movieDB.Movie.FileInfo.StreamDetails.Video(i).Width
                        parVideo_Height.Value = _movieDB.Movie.FileInfo.StreamDetails.Video(i).Height
                        parVideo_Codec.Value = _movieDB.Movie.FileInfo.StreamDetails.Video(i).Codec
                        parVideo_Duration.Value = _movieDB.Movie.FileInfo.StreamDetails.Video(i).Duration
                        parVideo_ScanType.Value = _movieDB.Movie.FileInfo.StreamDetails.Video(i).Scantype
                        parVideo_AspectDisplayRatio.Value = _movieDB.Movie.FileInfo.StreamDetails.Video(i).Aspect
                        parVideo_Language.Value = _movieDB.Movie.FileInfo.StreamDetails.Video(i).Language
                        parVideo_LongLanguage.Value = _movieDB.Movie.FileInfo.StreamDetails.Video(i).LongLanguage
                        parVideo_Bitrate.Value = _movieDB.Movie.FileInfo.StreamDetails.Video(i).Bitrate
                        parVideo_MultiViewCount.Value = _movieDB.Movie.FileInfo.StreamDetails.Video(i).MultiViewCount
                        parVideo_MultiViewLayout.Value = _movieDB.Movie.FileInfo.StreamDetails.Video(i).MultiViewLayout
                        parVideo_EncodedSettings.Value = _movieDB.Movie.FileInfo.StreamDetails.Video(i).EncodedSettings
                        parVideo_StereoMode.Value = _movieDB.Movie.FileInfo.StreamDetails.Video(i).StereoMode

                        SQLcommandMoviesVStreams.ExecuteNonQuery()
                    Next
                End Using
                Using SQLcommandMoviesAStreams As SQLite.SQLiteCommand = _myvideosDBConn.CreateCommand()
                    SQLcommandMoviesAStreams.CommandText = String.Concat("DELETE FROM MoviesAStreams WHERE MovieID = ", _movieDB.ID, ";")
                    SQLcommandMoviesAStreams.ExecuteNonQuery()

                    'Expanded SQL Statement to INSERT/replace new fields
                    SQLcommandMoviesAStreams.CommandText = String.Concat("INSERT OR REPLACE INTO MoviesAStreams (", _
                      "MovieID, StreamID, Audio_Language, Audio_LongLanguage, Audio_Codec, Audio_Channel, Audio_Bitrate", _
                      ") VALUES (?,?,?,?,?,?,?);")

                    Dim parAudio_MovieID As SQLite.SQLiteParameter = SQLcommandMoviesAStreams.Parameters.Add("parAudio_MovieID", DbType.UInt64, 0, "MovieID")
                    Dim parAudio_StreamID As SQLite.SQLiteParameter = SQLcommandMoviesAStreams.Parameters.Add("parAudio_StreamID", DbType.UInt64, 0, "StreamID")
                    Dim parAudio_Language As SQLite.SQLiteParameter = SQLcommandMoviesAStreams.Parameters.Add("parAudio_Language", DbType.String, 0, "Audio_Language")
                    Dim parAudio_LongLanguage As SQLite.SQLiteParameter = SQLcommandMoviesAStreams.Parameters.Add("parAudio_LongLanguage", DbType.String, 0, "Audio_LongLanguage")
                    Dim parAudio_Codec As SQLite.SQLiteParameter = SQLcommandMoviesAStreams.Parameters.Add("parAudio_Codec", DbType.String, 0, "Audio_Codec")
                    Dim parAudio_Channel As SQLite.SQLiteParameter = SQLcommandMoviesAStreams.Parameters.Add("parAudio_Channel", DbType.String, 0, "Audio_Channel")
                    Dim parAudio_Bitrate As SQLite.SQLiteParameter = SQLcommandMoviesAStreams.Parameters.Add("parAudio_Bitrate", DbType.String, 0, "Audio_Bitrate")

                    For i As Integer = 0 To _movieDB.Movie.FileInfo.StreamDetails.Audio.Count - 1
                        parAudio_MovieID.Value = _movieDB.ID
                        parAudio_StreamID.Value = i
                        parAudio_Language.Value = _movieDB.Movie.FileInfo.StreamDetails.Audio(i).Language
                        parAudio_LongLanguage.Value = _movieDB.Movie.FileInfo.StreamDetails.Audio(i).LongLanguage
                        parAudio_Codec.Value = _movieDB.Movie.FileInfo.StreamDetails.Audio(i).Codec
                        parAudio_Channel.Value = _movieDB.Movie.FileInfo.StreamDetails.Audio(i).Channels
                        parAudio_Bitrate.Value = _movieDB.Movie.FileInfo.StreamDetails.Audio(i).Bitrate

                        SQLcommandMoviesAStreams.ExecuteNonQuery()
                    Next
                End Using

                'subtitles
                Using SQLcommandMoviesSubs As SQLite.SQLiteCommand = _myvideosDBConn.CreateCommand()
                    SQLcommandMoviesSubs.CommandText = String.Concat("DELETE FROM MoviesSubs WHERE MovieID = ", _movieDB.ID, ";")
                    SQLcommandMoviesSubs.ExecuteNonQuery()

                    SQLcommandMoviesSubs.CommandText = String.Concat("INSERT OR REPLACE INTO MoviesSubs (", _
                       "MovieID, StreamID, Subs_Language, Subs_LongLanguage,Subs_Type, Subs_Path, Subs_Forced", _
                       ") VALUES (?,?,?,?,?,?,?);")
                    Dim parSubs_MovieID As SQLite.SQLiteParameter = SQLcommandMoviesSubs.Parameters.Add("parSubs_MovieID", DbType.UInt64, 0, "MovieID")
                    Dim parSubs_StreamID As SQLite.SQLiteParameter = SQLcommandMoviesSubs.Parameters.Add("parSubs_StreamID", DbType.UInt64, 0, "StreamID")
                    Dim parSubs_Language As SQLite.SQLiteParameter = SQLcommandMoviesSubs.Parameters.Add("parSubs_Language", DbType.String, 0, "Subs_Language")
                    Dim parSubs_LongLanguage As SQLite.SQLiteParameter = SQLcommandMoviesSubs.Parameters.Add("parSubs_LongLanguage", DbType.String, 0, "Subs_LongLanguage")
                    Dim parSubs_Type As SQLite.SQLiteParameter = SQLcommandMoviesSubs.Parameters.Add("parSubs_Type", DbType.String, 0, "Subs_Type")
                    Dim parSubs_Path As SQLite.SQLiteParameter = SQLcommandMoviesSubs.Parameters.Add("parSubs_Path", DbType.String, 0, "Subs_Path")
                    Dim parSubs_Forced As SQLite.SQLiteParameter = SQLcommandMoviesSubs.Parameters.Add("parSubs_Forced", DbType.Boolean, 0, "Subs_Forced")
                    Dim iID As Integer = 0
                    'embedded subtitles
                    For i As Integer = 0 To _movieDB.Movie.FileInfo.StreamDetails.Subtitle.Count - 1
                        parSubs_MovieID.Value = _movieDB.ID
                        parSubs_StreamID.Value = iID
                        parSubs_Language.Value = _movieDB.Movie.FileInfo.StreamDetails.Subtitle(i).Language
                        parSubs_LongLanguage.Value = _movieDB.Movie.FileInfo.StreamDetails.Subtitle(i).LongLanguage
                        parSubs_Type.Value = _movieDB.Movie.FileInfo.StreamDetails.Subtitle(i).SubsType
                        parSubs_Path.Value = _movieDB.Movie.FileInfo.StreamDetails.Subtitle(i).SubsPath
                        parSubs_Forced.Value = _movieDB.Movie.FileInfo.StreamDetails.Subtitle(i).SubsForced
                        SQLcommandMoviesSubs.ExecuteNonQuery()
                        iID += 1
                    Next
                    'external subtitles
                    For i As Integer = 0 To _movieDB.Subtitles.Count - 1
                        parSubs_MovieID.Value = _movieDB.ID
                        parSubs_StreamID.Value = iID
                        parSubs_Language.Value = _movieDB.Subtitles(i).Language
                        parSubs_LongLanguage.Value = _movieDB.Subtitles(i).LongLanguage
                        parSubs_Type.Value = _movieDB.Subtitles(i).SubsType
                        parSubs_Path.Value = _movieDB.Subtitles(i).SubsPath
                        parSubs_Forced.Value = _movieDB.Subtitles(i).SubsForced
                        SQLcommandMoviesSubs.ExecuteNonQuery()
                        iID += 1
                    Next
                End Using

                'MovieSets part
                Using SQLcommandMovieSets As SQLite.SQLiteCommand = _myvideosDBConn.CreateCommand()
                    SQLcommandMovieSets.CommandText = String.Concat("DELETE FROM MoviesSets WHERE MovieID = ", _movieDB.ID, ";")
                    SQLcommandMovieSets.ExecuteNonQuery()
                End Using

                Dim IsNewSet As Boolean
                For Each s As MediaContainers.Set In _movieDB.Movie.Sets
                    If s.TitleSpecified Then
                        IsNewSet = Not s.ID > 0
                        If Not IsNewSet Then
                            Using SQLcommandMoviesSets As SQLite.SQLiteCommand = _myvideosDBConn.CreateCommand()
                                SQLcommandMoviesSets.CommandText = String.Concat("INSERT OR REPLACE INTO MoviesSets (", _
                             "MovieID, SetID, SetOrder", _
                             ") VALUES (?,?,?);")
                                Dim parMoviesSets_MovieID As SQLite.SQLiteParameter = SQLcommandMoviesSets.Parameters.Add("parSets_MovieID", DbType.Int64, 0, "MovieID")
                                Dim parMoviesSets_SetID As SQLite.SQLiteParameter = SQLcommandMoviesSets.Parameters.Add("parSets_SetID", DbType.Int64, 0, "SetID")
                                Dim parMoviesSets_SetOrder As SQLite.SQLiteParameter = SQLcommandMoviesSets.Parameters.Add("parSets_SetOrder", DbType.String, 0, "SetOrder")

                                parMoviesSets_MovieID.Value = _movieDB.ID
                                parMoviesSets_SetID.Value = s.ID
                                parMoviesSets_SetOrder.Value = s.Order
                                SQLcommandMoviesSets.ExecuteNonQuery()
                            End Using
                        Else
                            'first check if a Set with same TMDBColID is already existing
                            If Not String.IsNullOrEmpty(s.TMDBColID) Then
                                Using SQLcommandSets As SQLite.SQLiteCommand = _myvideosDBConn.CreateCommand()
                                    SQLcommandSets.CommandText = String.Concat("SELECT idSet, SetName ", _
                                                                               "FROM sets WHERE TMDBColID LIKE """, s.TMDBColID, """;")
                                    Using SQLreader As SQLite.SQLiteDataReader = SQLcommandSets.ExecuteReader()
                                        If SQLreader.HasRows Then
                                            SQLreader.Read()
                                            If Not DBNull.Value.Equals(SQLreader("idSet")) Then s.ID = CInt(SQLreader("idSet"))
                                            If Not DBNull.Value.Equals(SQLreader("SetName")) Then s.Title = CStr(SQLreader("SetName"))
                                            IsNewSet = False
                                            NFO.SaveMovieToNFO(_movieDB) 'to save the "new" SetName
                                        Else
                                            IsNewSet = True
                                        End If
                                    End Using
                                End Using
                            End If

                            If IsNewSet Then
                                'secondly check if a Set with same name is already existing
                                Using SQLcommandSets As SQLite.SQLiteCommand = _myvideosDBConn.CreateCommand()
                                    SQLcommandSets.CommandText = String.Concat("SELECT idSet ", _
                                                                               "FROM sets WHERE SetName LIKE """, s.Title, """;")
                                    Using SQLreader As SQLite.SQLiteDataReader = SQLcommandSets.ExecuteReader()
                                        If SQLreader.HasRows Then
                                            SQLreader.Read()
                                            If Not DBNull.Value.Equals(SQLreader("idSet")) Then s.ID = CInt(SQLreader("idSet"))
                                            IsNewSet = False
                                        Else
                                            IsNewSet = True
                                        End If
                                    End Using
                                End Using
                            End If

                            If Not IsNewSet Then
                                'create new MoviesSets with existing SetID
                                Using SQLcommandMoviesSets As SQLite.SQLiteCommand = _myvideosDBConn.CreateCommand()
                                    SQLcommandMoviesSets.CommandText = String.Concat("INSERT OR REPLACE INTO MoviesSets (", _
                                                                                     "MovieID, SetID, SetOrder", _
                                                                                     ") VALUES (?,?,?);")
                                    Dim parMoviesSets_MovieID As SQLite.SQLiteParameter = SQLcommandMoviesSets.Parameters.Add("parSets_MovieID", DbType.Int64, 0, "MovieID")
                                    Dim parMoviesSets_SetID As SQLite.SQLiteParameter = SQLcommandMoviesSets.Parameters.Add("parSets_SetID", DbType.Int64, 0, "SetID")
                                    Dim parMoviesSets_SetOrder As SQLite.SQLiteParameter = SQLcommandMoviesSets.Parameters.Add("parSets_SetOrder", DbType.String, 0, "SetOrder")

                                    parMoviesSets_MovieID.Value = _movieDB.ID
                                    parMoviesSets_SetID.Value = s.ID
                                    parMoviesSets_SetOrder.Value = s.Order
                                    SQLcommandMoviesSets.ExecuteNonQuery()
                                End Using
                            Else
                                'create new Set
                                Using SQLcommandSets As SQLite.SQLiteCommand = _myvideosDBConn.CreateCommand()
                                    SQLcommandSets.CommandText = String.Concat("INSERT OR REPLACE INTO sets (", _
                                                                                     "ListTitle, NfoPath, ", _
                                                                                     "TMDBColID, Plot, SetName, New, Mark, Lock", _
                                                                                     ") VALUES (?,?,?,?,?,?,?,?);")
                                    Dim parSets_ListTitle As SQLite.SQLiteParameter = SQLcommandSets.Parameters.Add("parSets_ListTitle", DbType.String, 0, "ListTitle")
                                    Dim parSets_NfoPath As SQLite.SQLiteParameter = SQLcommandSets.Parameters.Add("parSets_NfoPath", DbType.String, 0, "NfoPath")
                                    Dim parSets_TMDBColID As SQLite.SQLiteParameter = SQLcommandSets.Parameters.Add("parSets_TMDBColID", DbType.String, 0, "TMDBColID")
                                    Dim parSets_Plot As SQLite.SQLiteParameter = SQLcommandSets.Parameters.Add("parSets_Plot", DbType.String, 0, "Plot")
                                    Dim parSets_SetName As SQLite.SQLiteParameter = SQLcommandSets.Parameters.Add("parSets_SetName", DbType.String, 0, "SetName")
                                    Dim parSets_New As SQLite.SQLiteParameter = SQLcommandSets.Parameters.Add("parSets_New", DbType.Boolean, 0, "New")
                                    Dim parSets_Mark As SQLite.SQLiteParameter = SQLcommandSets.Parameters.Add("parSets_Mark", DbType.Boolean, 0, "Mark")
                                    Dim parSets_Lock As SQLite.SQLiteParameter = SQLcommandSets.Parameters.Add("parSets_Lock", DbType.Boolean, 0, "Lock")

                                    parSets_SetName.Value = s.Title
                                    parSets_ListTitle.Value = StringUtils.SortTokens_MovieSet(s.Title)
                                    parSets_TMDBColID.Value = s.TMDBColID
                                    parSets_Plot.Value = String.Empty
                                    parSets_NfoPath.Value = String.Empty
                                    parSets_New.Value = True
                                    parSets_Lock.Value = False

                                    If Master.eSettings.MovieSetGeneralMarkNew Then
                                        parSets_Mark.Value = True
                                    Else
                                        parSets_Mark.Value = False
                                    End If
                                    SQLcommandSets.ExecuteNonQuery()
                                End Using

                                Using SQLcommandSets As SQLite.SQLiteCommand = _myvideosDBConn.CreateCommand()
                                    SQLcommandSets.CommandText = String.Concat("SELECT idSet, SetName FROM sets WHERE SetName LIKE """, s.Title, """;")
                                    Using rdrSets As SQLite.SQLiteDataReader = SQLcommandSets.ExecuteReader()
                                        If rdrSets.Read Then
                                            s.ID = Convert.ToInt64(rdrSets(0))
                                        End If
                                    End Using
                                End Using

                                'create new MoviesSets with new SetID
                                If s.ID > 0 Then
                                    Using SQLcommandMoviesSets As SQLite.SQLiteCommand = _myvideosDBConn.CreateCommand()
                                        SQLcommandMoviesSets.CommandText = String.Concat("INSERT OR REPLACE INTO MoviesSets (", _
                                                                                         "MovieID, SetID, SetOrder", _
                                                                                         ") VALUES (?,?,?);")
                                        Dim parMoviesSets_MovieID As SQLite.SQLiteParameter = SQLcommandMoviesSets.Parameters.Add("parSets_MovieID", DbType.Int64, 0, "MovieID")
                                        Dim parMoviesSets_SetID As SQLite.SQLiteParameter = SQLcommandMoviesSets.Parameters.Add("parSets_SetID", DbType.Int64, 0, "SetID")
                                        Dim parMoviesSets_SetOrder As SQLite.SQLiteParameter = SQLcommandMoviesSets.Parameters.Add("parSets_SetOrder", DbType.String, 0, "SetOrder")

                                        parMoviesSets_MovieID.Value = _movieDB.ID
                                        parMoviesSets_SetID.Value = s.ID
                                        parMoviesSets_SetOrder.Value = s.Order
                                        SQLcommandMoviesSets.ExecuteNonQuery()
                                    End Using
                                End If
                            End If
                        End If
                    End If
                Next
            End If
        End Using
        If Not BatchMode Then SQLtransaction.Commit()

        Return _movieDB
    End Function
    ''' <summary>
    ''' Saves all information from a Structures.DBMovieSet object to the database
    ''' </summary>
    ''' <param name="_moviesetDB">Media.Movie object to save to the database</param>
    ''' <param name="IsNew">Is this a new movieset (not already present in database)?</param>
    ''' <param name="BatchMode">Is the function already part of a transaction?</param>
    ''' <param name="ToNfo">Save the information to an nfo file?</param>
    ''' <param name="withMovies">Save the information also to all linked movies?</param>
    ''' <returns>Structures.DBMovieSet object</returns>
    Public Function SaveMovieSetToDB(ByVal _moviesetDB As Structures.DBMovieSet, ByVal IsNew As Boolean, Optional ByVal BatchMode As Boolean = False, Optional ByVal ToNfo As Boolean = False, Optional ByVal withMovies As Boolean = False) As Structures.DBMovieSet
        'TODO Must add parameter checking. Needs thought to ensure calling routines are not broken if exception thrown. 
        'TODO Break this method into smaller chunks. Too important to be this complex
        Try
            If _moviesetDB.ID = -1 Then IsNew = True

            Dim SQLtransaction As SQLite.SQLiteTransaction = Nothing
            If Not BatchMode Then SQLtransaction = _myvideosDBConn.BeginTransaction()
            Using SQLcommand As SQLite.SQLiteCommand = _myvideosDBConn.CreateCommand()
                If IsNew Then
                    SQLcommand.CommandText = String.Concat("INSERT OR REPLACE INTO sets (", _
                     "ListTitle, NfoPath, ", _
                     "TMDBColID, Plot, SetName, New, Mark, Lock", _
                     ") VALUES (?,?,?,?,?,?,?,?); SELECT LAST_INSERT_ROWID() FROM sets;")
                Else
                    SQLcommand.CommandText = String.Concat("INSERT OR REPLACE INTO sets (", _
                     "idSet, ListTitle, NfoPath, ", _
                     "TMDBColID, Plot, SetName, New, Mark, Lock", _
                     ") VALUES (?,?,?,?,?,?,?,?,?); SELECT LAST_INSERT_ROWID() FROM sets;")
                    Dim parMovieSetID As SQLite.SQLiteParameter = SQLcommand.Parameters.Add("parMovieSetID", DbType.Int32, 0, "idSet")
                    parMovieSetID.Value = _moviesetDB.ID
                End If
                Dim parListTitle As SQLite.SQLiteParameter = SQLcommand.Parameters.Add("parListTitle", DbType.String, 0, "ListTitle")
                Dim parNfoPath As SQLite.SQLiteParameter = SQLcommand.Parameters.Add("parNfoPath", DbType.String, 0, "NfoPath")
                Dim parTMDBColID As SQLite.SQLiteParameter = SQLcommand.Parameters.Add("parTMDBColID", DbType.String, 0, "TMDBColID")
                Dim parPlot As SQLite.SQLiteParameter = SQLcommand.Parameters.Add("parPlot", DbType.String, 0, "Plot")
                Dim parSetName As SQLite.SQLiteParameter = SQLcommand.Parameters.Add("parSetName", DbType.String, 0, "SetName")
                Dim parNew As SQLite.SQLiteParameter = SQLcommand.Parameters.Add("parNew", DbType.Boolean, 0, "New")
                Dim parMark As SQLite.SQLiteParameter = SQLcommand.Parameters.Add("parMark", DbType.Boolean, 0, "Mark")
                Dim parLock As SQLite.SQLiteParameter = SQLcommand.Parameters.Add("parLock", DbType.Boolean, 0, "Lock")

                ' First let's save it to NFO, even because we will need the NFO path
                'If ToNfo AndAlso Not String.IsNullOrEmpty(_movieDB.Movie.IMDBID) Then NFO.SaveMovieToNFO(_movieDB)
                'Why do we need IMDB to save to NFO?
                If ToNfo Then NFO.SaveMovieSetToNFO(_moviesetDB)

                parNfoPath.Value = _moviesetDB.NfoPath

                parNew.Value = IsNew
                parMark.Value = _moviesetDB.IsMark
                parLock.Value = _moviesetDB.IsLock

                parListTitle.Value = _moviesetDB.ListTitle
                parSetName.Value = _moviesetDB.MovieSet.Title
                parTMDBColID.Value = _moviesetDB.MovieSet.ID
                parPlot.Value = _moviesetDB.MovieSet.Plot

                If IsNew Then
                    Using rdrMovieSet As SQLite.SQLiteDataReader = SQLcommand.ExecuteReader()
                        If rdrMovieSet.Read Then
                            _moviesetDB.ID = Convert.ToInt64(rdrMovieSet(0))
                        Else
                            logger.Error("Something very wrong here: SaveMovieSetToDB", _moviesetDB.ToString, "Error")
                            _moviesetDB.ListTitle = "SETERROR"
                            Return _moviesetDB
                        End If
                    End Using
                Else
                    SQLcommand.ExecuteNonQuery()
                End If
            End Using

            'Images
            Using SQLcommand_art As SQLite.SQLiteCommand = _myvideosDBConn.CreateCommand()
                SQLcommand_art.CommandText = String.Concat("DELETE FROM art WHERE media_id = ", _moviesetDB.ID, " AND media_type = 'set';")
                SQLcommand_art.ExecuteNonQuery()
            End Using
            If Not String.IsNullOrEmpty(_moviesetDB.BannerPath) Then SetArtForItem(_moviesetDB.ID, "set", "banner", _moviesetDB.BannerPath)
            If Not String.IsNullOrEmpty(_moviesetDB.ClearArtPath) Then SetArtForItem(_moviesetDB.ID, "set", "clearart", _moviesetDB.ClearArtPath)
            If Not String.IsNullOrEmpty(_moviesetDB.ClearLogoPath) Then SetArtForItem(_moviesetDB.ID, "set", "clearlogo", _moviesetDB.ClearLogoPath)
            If Not String.IsNullOrEmpty(_moviesetDB.DiscArtPath) Then SetArtForItem(_moviesetDB.ID, "set", "discart", _moviesetDB.DiscArtPath)
            If Not String.IsNullOrEmpty(_moviesetDB.FanartPath) Then SetArtForItem(_moviesetDB.ID, "set", "fanart", _moviesetDB.FanartPath)
            If Not String.IsNullOrEmpty(_moviesetDB.LandscapePath) Then SetArtForItem(_moviesetDB.ID, "set", "landscape", _moviesetDB.LandscapePath)
            If Not String.IsNullOrEmpty(_moviesetDB.PosterPath) Then SetArtForItem(_moviesetDB.ID, "set", "poster", _moviesetDB.PosterPath)

            If withMovies Then
                Dim MoviesInSet As New List(Of MovieInSet)

                'get all movies linked to this MovieSet
                Using SQLcommand As SQLite.SQLiteCommand = _myvideosDBConn.CreateCommand()
                    SQLcommand.CommandText = String.Concat("SELECT MovieID, SetID, SetOrder FROM MoviesSets ", _
                                                           "WHERE SetID = ", _moviesetDB.ID, ";")
                    Using SQLreader As SQLite.SQLiteDataReader = SQLcommand.ExecuteReader()
                        While SQLreader.Read
                            Dim movie As New Structures.DBMovie
                            Dim movieToSave As New MovieInSet
                            If Not DBNull.Value.Equals(SQLreader("MovieID")) Then movie = LoadMovieFromDB(Convert.ToInt64(SQLreader("MovieID")))
                            movieToSave.DBMovie = movie
                            If Not DBNull.Value.Equals(SQLreader("SetOrder")) Then movieToSave.Order = If(Not String.IsNullOrEmpty(SQLreader("SetOrder").ToString), CInt(SQLreader("SetOrder").ToString), 0)
                            MoviesInSet.Add(movieToSave)
                        End While
                    End Using
                End Using

                'write new movie NFOs
                If MoviesInSet.Count > 0 Then
                    For Each tMovie In MoviesInSet
                        tMovie.DBMovie.Movie.AddSet(_moviesetDB.ID, _moviesetDB.MovieSet.Title, tMovie.Order, _moviesetDB.MovieSet.ID)
                        Master.DB.SaveMovieToDB(tMovie.DBMovie, False, BatchMode, True)
                    Next
                End If
            End If

            If Not BatchMode Then SQLtransaction.Commit()

        Catch ex As Exception
            logger.Error(New StackFrame().GetMethod().Name, ex)
        End Try
        Return _moviesetDB
    End Function

    ''' <summary>
    ''' Saves all information from a Structures.DBMovieSet object to the database
    ''' </summary>
    ''' <param name="_tagDB">Media.Movie object to save to the database</param>
    ''' <param name="IsNew">Is this a new movieset (not already present in database)?</param>
    ''' <param name="BatchMode">Is the function already part of a transaction?</param>
    ''' <param name="ToNfo">Save the information to an nfo file?</param>
    ''' <param name="withMovies">Save the information also to all linked movies?</param>
    ''' <returns>Structures.DBMovieSet object</returns>
    Public Function SaveMovieTagToDB(ByVal _tagDB As Structures.DBMovieTag, ByVal IsNew As Boolean, Optional ByVal BatchMode As Boolean = False, Optional ByVal ToNfo As Boolean = False, Optional ByVal withMovies As Boolean = False) As Structures.DBMovieTag
        'TODO Must add parameter checking. Needs thought to ensure calling routines are not broken if exception thrown. 
        'TODO Break this method into smaller chunks. Too important to be this complex

        If _tagDB.ID = -1 Then IsNew = True

        Dim SQLtransaction As SQLite.SQLiteTransaction = Nothing
        If Not BatchMode Then SQLtransaction = _myvideosDBConn.BeginTransaction()
        Using SQLcommand As SQLite.SQLiteCommand = _myvideosDBConn.CreateCommand()
            If IsNew Then
                SQLcommand.CommandText = String.Concat("INSERT OR REPLACE INTO tag (strTag) VALUES (?); SELECT LAST_INSERT_ROWID() FROM tag;")
            Else
                SQLcommand.CommandText = String.Concat("INSERT OR REPLACE INTO tag (", _
                          "idTag, strTag) VALUES (?,?); SELECT LAST_INSERT_ROWID() FROM tag;")
                Dim parTagID As SQLite.SQLiteParameter = SQLcommand.Parameters.Add("parTagID", DbType.Int32, 0, "idTag")
                parTagID.Value = _tagDB.ID
            End If
            Dim parTitle As SQLite.SQLiteParameter = SQLcommand.Parameters.Add("parTitle", DbType.String, 0, "strTag")

            parTitle.Value = _tagDB.Title

            If IsNew Then
                Using rdrMovieTag As SQLite.SQLiteDataReader = SQLcommand.ExecuteReader()
                    If rdrMovieTag.Read Then
                        _tagDB.ID = CInt(Convert.ToInt64(rdrMovieTag(0)))
                    Else
                        logger.Error("Something very wrong here: SaveMovieSetToDB", _tagDB.ToString, "Error")
                        _tagDB.Title = "SETERROR"
                        Return _tagDB
                    End If
                End Using
            Else
                SQLcommand.ExecuteNonQuery()
            End If
        End Using


        If withMovies Then
            'Update all movies for this tag: if there are movies in linktag-table which aren't in current tag.movies object then remove movie-tag link from linktable and nfo for those movies

            'old state of tag in database
            Dim MoviesInTagOld As New List(Of Structures.DBMovie)
            'new/updatend state of tag
            Dim MoviesInTagNew As New List(Of Structures.DBMovie)
            MoviesInTagNew.AddRange(_tagDB.Movies.ToArray)





            'get all movies linked to this tag from database (old state)
            Using SQLcommand As SQLite.SQLiteCommand = _myvideosDBConn.CreateCommand()
                SQLcommand.CommandText = String.Concat("SELECT idMedia, idTag FROM taglinks ", _
                   "WHERE idTag = ", _tagDB.ID, " AND media_type = 'movie';")

                Using SQLreader As SQLite.SQLiteDataReader = SQLcommand.ExecuteReader()
                    While SQLreader.Read
                        Dim movie As New Structures.DBMovie
                        If Not DBNull.Value.Equals(SQLreader("idMedia")) Then movie = LoadMovieFromDB(Convert.ToInt64(SQLreader("idMedia")))
                        MoviesInTagOld.Add(movie)
                    End While
                End Using
            End Using

            'check if there are movies in linktable which aren't in current tag - those are old entries which meed to be removed from linktag table and nfo of movies
            For i = MoviesInTagOld.Count - 1 To 0 Step -1
                For Each movienew In MoviesInTagNew
                    If MoviesInTagOld(i).Movie.IMDBID = movienew.Movie.IMDBID Then
                        MoviesInTagOld.RemoveAt(i)
                        Exit For
                    End If
                Next
            Next

            'write tag information into nfo (add tag)
            If MoviesInTagNew.Count > 0 Then
                For Each tMovie In MoviesInTagNew
                    Dim mMovie As New Structures.DBMovie
                    mMovie = LoadMovieFromDB(tMovie.ID)
                    tMovie = mMovie
                    mMovie.Movie.AddTag(_tagDB.Title)
                    Master.DB.SaveMovieToDB(mMovie, False, BatchMode, True)
                Next
            End If
            'clean nfo of movies who aren't part of tag anymore (remove tag)
            If MoviesInTagOld.Count > 0 Then
                For Each tMovie In MoviesInTagOld
                    Dim mMovie As New Structures.DBMovie
                    mMovie = LoadMovieFromDB(tMovie.ID)
                    tMovie = mMovie
                    mMovie.Movie.Tags.Remove(_tagDB.Title)
                    Master.DB.SaveMovieToDB(mMovie, False, BatchMode, True)
                Next
            End If
        End If

        If Not BatchMode Then SQLtransaction.Commit()

        Return _tagDB
    End Function

    ''' <summary>
    ''' Saves all episode information from a Structures.DBTV object to the database
    ''' </summary>
    ''' <param name="_TVEpDB">Structures.DBTV object to save to the database</param>
    ''' <param name="IsNew">Is this a new episode (not already present in database)?</param>
    ''' <param name="WithSeason">If <c>True</c>, also save season information</param>
    ''' <param name="BatchMode">Is the function already part of a transaction?</param>
    ''' <param name="ToNfo">Save the information to an nfo file?</param>
    Public Sub SaveTVEpToDB(ByVal _TVEpDB As Structures.DBTV, ByVal IsNew As Boolean, ByVal WithSeason As Boolean, Optional ByVal BatchMode As Boolean = False, Optional ByVal ToNfo As Boolean = False)
        'TODO Must add parameter checking. Needs thought to ensure calling routines are not broken if exception thrown. 
        'TODO Break this method into smaller chunks. Too important to be this complex

        Dim SQLtransaction As SQLite.SQLiteTransaction = Nothing
        Dim PathID As Long = -1
        If Not BatchMode Then SQLtransaction = _myvideosDBConn.BeginTransaction()

        'Copy fileinfo duration over to runtime var for xbmc to pick up episode runtime.
        NFO.LoadTVEpDuration(_TVEpDB)

        'delete so it will remove if there is a "missing" episode entry already. Only "missing" episodes must be deleted.
        Using SQLCommand As SQLite.SQLiteCommand = _myvideosDBConn.CreateCommand()
            SQLCommand.CommandText = String.Concat("DELETE FROM episode WHERE idShow = ", _TVEpDB.ShowID, " AND Episode = ", _TVEpDB.TVEp.Episode, " AND Season = ", _TVEpDB.TVEp.Season, " AND Missing = 1;")
            SQLCommand.ExecuteNonQuery()
        End Using

        If Not String.IsNullOrEmpty(_TVEpDB.Filename) Then
            If _TVEpDB.FilenameID > -1 Then
                Using SQLpathcommand As SQLite.SQLiteCommand = _myvideosDBConn.CreateCommand()
                    SQLpathcommand.CommandText = String.Concat("INSERT OR REPLACE INTO TVEpPaths (ID, TVEpPath) VALUES (?,?);")

                    Dim parID As SQLite.SQLiteParameter = SQLpathcommand.Parameters.Add("parID", DbType.UInt64, 0, "ID")
                    Dim parTVEpPath As SQLite.SQLiteParameter = SQLpathcommand.Parameters.Add("parTVEpPath", DbType.String, 0, "TVEpPath")
                    parID.Value = _TVEpDB.FilenameID
                    parTVEpPath.Value = _TVEpDB.Filename
                    PathID = _TVEpDB.FilenameID
                    SQLpathcommand.ExecuteNonQuery()
                End Using
            Else
                Using SQLpathcommand As SQLite.SQLiteCommand = _myvideosDBConn.CreateCommand()
                    SQLpathcommand.CommandText = "SELECT ID FROM TVEpPaths WHERE TVEpPath = (?);"

                    Dim parPath As SQLite.SQLiteParameter = SQLpathcommand.Parameters.Add("parPath", DbType.String, 0, "TVEpPath")
                    parPath.Value = _TVEpDB.Filename

                    Using SQLreader As SQLite.SQLiteDataReader = SQLpathcommand.ExecuteReader
                        If SQLreader.HasRows Then
                            SQLreader.Read()
                            PathID = Convert.ToInt64(SQLreader("ID"))
                        Else
                            Using SQLpcommand As SQLite.SQLiteCommand = _myvideosDBConn.CreateCommand()
                                SQLpcommand.CommandText = String.Concat("INSERT INTO TVEpPaths (", _
                                     "TVEpPath) VALUES (?); SELECT LAST_INSERT_ROWID() FROM TVEpPaths;")
                                Dim parEpPath As SQLite.SQLiteParameter = SQLpcommand.Parameters.Add("parEpPath", DbType.String, 0, "TVEpPath")
                                parEpPath.Value = _TVEpDB.Filename

                                PathID = Convert.ToInt64(SQLpcommand.ExecuteScalar)
                            End Using
                        End If
                    End Using
                End Using
            End If
        End If

        Using SQLcommand As SQLite.SQLiteCommand = _myvideosDBConn.CreateCommand()
            If IsNew Then
                SQLcommand.CommandText = String.Concat("INSERT OR REPLACE INTO episode (", _
                 "idShow, New, Mark, TVEpPathID, Source, Lock, Title, Season, Episode,", _
                 "Rating, Plot, Aired, Director, Credits, NfoPath, NeedsSave, Missing, Playcount,", _
                 "DisplaySeason, DisplayEpisode, DateAdded, Runtime, Votes, VideoSource, HasSub", _
                 ") VALUES (?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?); SELECT LAST_INSERT_ROWID() FROM episode;")

            Else
                SQLcommand.CommandText = String.Concat("INSERT OR REPLACE INTO episode (", _
                 "idEpisode, idShow, New, Mark, TVEpPathID, Source, Lock, Title, Season, Episode,", _
                 "Rating, Plot, Aired, Director, Credits, NfoPath, NeedsSave, Missing, Playcount,", _
                 "DisplaySeason, DisplayEpisode, DateAdded, Runtime, Votes, VideoSource, HasSub", _
                 ") VALUES (?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?); SELECT LAST_INSERT_ROWID() FROM episode;")

                Dim parTVEpID As SQLite.SQLiteParameter = SQLcommand.Parameters.Add("parTVEpID", DbType.UInt64, 0, "idEpisode")
                parTVEpID.Value = _TVEpDB.EpID
            End If

            Dim parTVShowID As SQLite.SQLiteParameter = SQLcommand.Parameters.Add("parTVShowID", DbType.UInt64, 0, "idShow")
            Dim parNew As SQLite.SQLiteParameter = SQLcommand.Parameters.Add("parNew", DbType.Boolean, 0, "new")
            Dim parMark As SQLite.SQLiteParameter = SQLcommand.Parameters.Add("parMark", DbType.Boolean, 0, "mark")
            Dim parTVEpPathID As SQLite.SQLiteParameter = SQLcommand.Parameters.Add("parTVEpPathID", DbType.Int64, 0, "TVEpPathID")
            Dim parSource As SQLite.SQLiteParameter = SQLcommand.Parameters.Add("parSource", DbType.String, 0, "source")
            Dim parLock As SQLite.SQLiteParameter = SQLcommand.Parameters.Add("parLock", DbType.Boolean, 0, "lock")
            Dim parTitle As SQLite.SQLiteParameter = SQLcommand.Parameters.Add("parTitle", DbType.String, 0, "Title")
            Dim parSeason As SQLite.SQLiteParameter = SQLcommand.Parameters.Add("parSeason", DbType.String, 0, "Season")
            Dim parEpisode As SQLite.SQLiteParameter = SQLcommand.Parameters.Add("parEpisode", DbType.String, 0, "Episode")
            Dim parRating As SQLite.SQLiteParameter = SQLcommand.Parameters.Add("parRating", DbType.String, 0, "Rating")
            Dim parPlot As SQLite.SQLiteParameter = SQLcommand.Parameters.Add("parPlot", DbType.String, 0, "Plot")
            Dim parAired As SQLite.SQLiteParameter = SQLcommand.Parameters.Add("parAired", DbType.String, 0, "Aired")
            Dim parDirector As SQLite.SQLiteParameter = SQLcommand.Parameters.Add("parDirector", DbType.String, 0, "Director")
            Dim parCredits As SQLite.SQLiteParameter = SQLcommand.Parameters.Add("parCredits", DbType.String, 0, "Credits")
            Dim parNfoPath As SQLite.SQLiteParameter = SQLcommand.Parameters.Add("parNfoPath", DbType.String, 0, "NfoPath")
            Dim parNeedsSave As SQLite.SQLiteParameter = SQLcommand.Parameters.Add("parNeedsSave", DbType.Boolean, 0, "NeedsSave")
            Dim parTVEpMissing As SQLite.SQLiteParameter = SQLcommand.Parameters.Add("parTVEpMissing", DbType.Boolean, 0, "Missing")
            Dim parPlaycount As SQLite.SQLiteParameter = SQLcommand.Parameters.Add("parPlaycount", DbType.String, 0, "Playcount")
            Dim parDisplaySeason As SQLite.SQLiteParameter = SQLcommand.Parameters.Add("parDisplaySeason", DbType.String, 0, "DisplaySeason")
            Dim parDisplayEpisode As SQLite.SQLiteParameter = SQLcommand.Parameters.Add("parDisplayEpisode", DbType.String, 0, "DisplayEpisode")
            Dim parDateAdded As SQLite.SQLiteParameter = SQLcommand.Parameters.Add("parDateAdded", DbType.Int32, 0, "DateAdded")
            Dim parRuntime As SQLite.SQLiteParameter = SQLcommand.Parameters.Add("parRuntime", DbType.String, 0, "Runtime")
            Dim parVotes As SQLite.SQLiteParameter = SQLcommand.Parameters.Add("parVotes", DbType.String, 0, "Votes")
            Dim parVideoSource As SQLite.SQLiteParameter = SQLcommand.Parameters.Add("parVideoSource", DbType.String, 0, "VideoSource")
            Dim parHasSub As SQLite.SQLiteParameter = SQLcommand.Parameters.Add("parHasSub", DbType.Boolean, 0, "HasSub")

            Try
                If Not Master.eSettings.GeneralDateAddedIgnoreNFO AndAlso Not String.IsNullOrEmpty(_TVEpDB.TVEp.DateAdded) Then
                    Dim DateTimeAdded As DateTime = DateTime.ParseExact(_TVEpDB.TVEp.DateAdded, "yyyy-MM-dd HH:mm:ss", Globalization.CultureInfo.InvariantCulture)
                    parDateAdded.Value = Functions.ConvertToUnixTimestamp(DateTimeAdded)
                Else
                    Select Case Master.eSettings.GeneralDateTime
                        Case Enums.DateTime.Now
                            parDateAdded.Value = If(IsNew, Functions.ConvertToUnixTimestamp(DateTime.Now), _TVEpDB.DateAdded)
                        Case Enums.DateTime.mtime
                            Dim mtime As Date = System.IO.File.GetLastWriteTime(_TVEpDB.Filename)
                            If mtime.Year > 1601 Then
                                parDateAdded.Value = Functions.ConvertToUnixTimestamp(mtime)
                            Else
                                Dim ctime As Date = System.IO.File.GetCreationTime(_TVEpDB.Filename)
                                parDateAdded.Value = Functions.ConvertToUnixTimestamp(ctime)
                            End If
                        Case Enums.DateTime.Newer
                            Dim mtime As Date = System.IO.File.GetLastWriteTime(_TVEpDB.Filename)
                            Dim ctime As Date = System.IO.File.GetCreationTime(_TVEpDB.Filename)
                            If mtime > ctime Then
                                parDateAdded.Value = Functions.ConvertToUnixTimestamp(mtime)
                            Else
                                parDateAdded.Value = Functions.ConvertToUnixTimestamp(ctime)
                            End If
                    End Select
                End If
                _TVEpDB.TVEp.DateAdded = Functions.ConvertFromUnixTimestamp(Convert.ToInt64(parDateAdded.Value)).ToString("yyyy-MM-dd HH:mm:ss")
            Catch ex As Exception
                parDateAdded.Value = If(IsNew, Functions.ConvertToUnixTimestamp(DateTime.Now), _TVEpDB.DateAdded)
                _TVEpDB.TVEp.DateAdded = Functions.ConvertFromUnixTimestamp(Convert.ToInt64(parDateAdded.Value)).ToString("yyyy-MM-dd HH:mm:ss")
            End Try

            ' First let's save it to NFO, even because we will need the NFO path
            If ToNfo Then NFO.SaveTVEpToNFO(_TVEpDB)

            parTVShowID.Value = _TVEpDB.ShowID
            parNfoPath.Value = _TVEpDB.EpNfoPath
            parHasSub.Value = (_TVEpDB.EpSubtitles IsNot Nothing AndAlso _TVEpDB.EpSubtitles.Count > 0) OrElse _TVEpDB.TVEp.FileInfo.StreamDetails.Subtitle.Count > 0
            parNew.Value = IsNew
            parMark.Value = _TVEpDB.IsMarkEp
            parTVEpPathID.Value = PathID
            parLock.Value = _TVEpDB.IsLockEp
            parSource.Value = _TVEpDB.Source
            parNeedsSave.Value = _TVEpDB.EpNeedsSave
            parTVEpMissing.Value = PathID < 0
            parVideoSource.Value = _TVEpDB.VideoSource

            With _TVEpDB.TVEp
                parTitle.Value = .Title
                parSeason.Value = .Season
                parEpisode.Value = .Episode
                parRating.Value = .Rating
                parPlot.Value = .Plot
                parAired.Value = .Aired
                parDirector.Value = .Director
                parCredits.Value = .OldCredits
                parPlaycount.Value = If(Not String.IsNullOrEmpty(.Playcount) AndAlso CInt(.Playcount) > 0, .Playcount, Nothing) 'need to be NOTHING instead of "0"
                parRuntime.Value = .Runtime
                parVotes.Value = NumUtils.CleanVotes(.Votes)
                If .displaySEset Then
                    parDisplaySeason.Value = .DisplaySeason
                    parDisplayEpisode.Value = .DisplayEpisode
                End If
            End With

            If IsNew Then
                If Master.eSettings.TVGeneralMarkNewEpisodes Then
                    parMark.Value = True
                Else
                    parMark.Value = False
                End If
                Using rdrTVEp As SQLite.SQLiteDataReader = SQLcommand.ExecuteReader()
                    If rdrTVEp.Read Then
                        _TVEpDB.EpID = Convert.ToInt64(rdrTVEp(0))
                    Else
                        logger.Error("Something very wrong here: SaveTVEpToDB", _TVEpDB.ToString, "Error")
                        _TVEpDB.EpID = -1
                        Exit Sub
                    End If
                End Using
            Else
                SQLcommand.ExecuteNonQuery()
            End If

            If Not _TVEpDB.EpID = -1 Then

                'Actors
                Using SQLcommand_actorlinkepisode As SQLite.SQLiteCommand = _myvideosDBConn.CreateCommand()
                    SQLcommand_actorlinkepisode.CommandText = String.Concat("DELETE FROM actorlinkepisode WHERE idEpisode = ", _TVEpDB.EpID, ";")
                    SQLcommand_actorlinkepisode.ExecuteNonQuery()
                End Using
                AddCast(_TVEpDB.EpID, "episode", "episode", _TVEpDB.TVEp.Actors)

                'Images
                Using SQLcommand_art As SQLite.SQLiteCommand = _myvideosDBConn.CreateCommand()
                    SQLcommand_art.CommandText = String.Concat("DELETE FROM art WHERE media_id = ", _TVEpDB.EpID, " AND media_type = 'episode';")
                    SQLcommand_art.ExecuteNonQuery()
                End Using
                If Not String.IsNullOrEmpty(_TVEpDB.EpFanartPath) Then SetArtForItem(_TVEpDB.EpID, "episode", "fanart", _TVEpDB.EpFanartPath)
                If Not String.IsNullOrEmpty(_TVEpDB.EpPosterPath) Then SetArtForItem(_TVEpDB.EpID, "episode", "thumb", _TVEpDB.EpPosterPath)

                'Writers
                Using SQLcommand_writerlinkepisode As SQLite.SQLiteCommand = _myvideosDBConn.CreateCommand()
                    SQLcommand_writerlinkepisode.CommandText = String.Concat("DELETE FROM writerlinkepisode WHERE idEpisode = ", _TVEpDB.EpID, ";")
                    SQLcommand_writerlinkepisode.ExecuteNonQuery()
                End Using
                For Each writer As String In _TVEpDB.TVEp.Credits
                    AddWriterToEpisode(_TVEpDB.EpID, AddActor(writer, "", ""))
                Next

                Using SQLcommandTVVStreams As SQLite.SQLiteCommand = _myvideosDBConn.CreateCommand()
                    SQLcommandTVVStreams.CommandText = String.Concat("DELETE FROM TVVStreams WHERE TVEpID = ", _TVEpDB.EpID, ";")
                    SQLcommandTVVStreams.ExecuteNonQuery()
                    SQLcommandTVVStreams.CommandText = String.Concat("INSERT OR REPLACE INTO TVVStreams (", _
                       "TVEpID, StreamID, Video_Width, Video_Height, Video_Codec, Video_Duration, Video_ScanType, Video_AspectDisplayRatio,", _
                       "Video_Language, Video_LongLanguage, Video_Bitrate, Video_MultiViewCount, Video_EncodedSettings, Video_MultiViewLayout, ", _
                       "Video_StereoMode) VALUES (?,?,?,?,?,?,?,?,?,?,?,?,?,?,?);")

                    Dim parVideo_EpID As SQLite.SQLiteParameter = SQLcommandTVVStreams.Parameters.Add("parVideo_EpID", DbType.UInt64, 0, "TVEpID")
                    Dim parVideo_StreamID As SQLite.SQLiteParameter = SQLcommandTVVStreams.Parameters.Add("parVideo_StreamID", DbType.UInt64, 0, "StreamID")
                    Dim parVideo_Width As SQLite.SQLiteParameter = SQLcommandTVVStreams.Parameters.Add("parVideo_Width", DbType.String, 0, "Video_Width")
                    Dim parVideo_Height As SQLite.SQLiteParameter = SQLcommandTVVStreams.Parameters.Add("parVideo_Height", DbType.String, 0, "Video_Height")
                    Dim parVideo_Codec As SQLite.SQLiteParameter = SQLcommandTVVStreams.Parameters.Add("parVideo_Codec", DbType.String, 0, "Video_Codec")
                    Dim parVideo_Duration As SQLite.SQLiteParameter = SQLcommandTVVStreams.Parameters.Add("parVideo_Duration", DbType.String, 0, "Video_Duration")
                    Dim parVideo_ScanType As SQLite.SQLiteParameter = SQLcommandTVVStreams.Parameters.Add("parVideo_ScanType", DbType.String, 0, "Video_ScanType")
                    Dim parVideo_AspectDisplayRatio As SQLite.SQLiteParameter = SQLcommandTVVStreams.Parameters.Add("parVideo_AspectDisplayRatio", DbType.String, 0, "Video_AspectDisplayRatio")
                    Dim parVideo_Language As SQLite.SQLiteParameter = SQLcommandTVVStreams.Parameters.Add("parVideo_Language", DbType.String, 0, "Video_Language")
                    Dim parVideo_LongLanguage As SQLite.SQLiteParameter = SQLcommandTVVStreams.Parameters.Add("parVideo_LongLanguage", DbType.String, 0, "Video_LongLanguage")
                    Dim parVideo_Bitrate As SQLite.SQLiteParameter = SQLcommandTVVStreams.Parameters.Add("parVideo_Bitrate", DbType.String, 0, "Video_Bitrate")
                    Dim parVideo_MultiViewCount As SQLite.SQLiteParameter = SQLcommandTVVStreams.Parameters.Add("parVideo_MultiViewCount", DbType.String, 0, "Video_MultiViewCount")
                    Dim parVideo_EncodedSettings As SQLite.SQLiteParameter = SQLcommandTVVStreams.Parameters.Add("parVideo_EncodedSettings", DbType.String, 0, "Video_EncodedSettings")
                    Dim parVideo_MultiViewLayout As SQLite.SQLiteParameter = SQLcommandTVVStreams.Parameters.Add("parVideo_MultiViewLayout", DbType.String, 0, "Video_MultiViewLayout")
                    Dim parVideo_StereoMode As SQLite.SQLiteParameter = SQLcommandTVVStreams.Parameters.Add("parVideo_StereoMode", DbType.String, 0, "Video_StereoMode")

                    For i As Integer = 0 To _TVEpDB.TVEp.FileInfo.StreamDetails.Video.Count - 1
                        parVideo_EpID.Value = _TVEpDB.EpID
                        parVideo_StreamID.Value = i
                        parVideo_Width.Value = _TVEpDB.TVEp.FileInfo.StreamDetails.Video(i).Width
                        parVideo_Height.Value = _TVEpDB.TVEp.FileInfo.StreamDetails.Video(i).Height
                        parVideo_Codec.Value = _TVEpDB.TVEp.FileInfo.StreamDetails.Video(i).Codec
                        parVideo_Duration.Value = _TVEpDB.TVEp.FileInfo.StreamDetails.Video(i).Duration
                        parVideo_ScanType.Value = _TVEpDB.TVEp.FileInfo.StreamDetails.Video(i).Scantype
                        parVideo_AspectDisplayRatio.Value = _TVEpDB.TVEp.FileInfo.StreamDetails.Video(i).Aspect
                        parVideo_Language.Value = _TVEpDB.TVEp.FileInfo.StreamDetails.Video(i).Language
                        parVideo_LongLanguage.Value = _TVEpDB.TVEp.FileInfo.StreamDetails.Video(i).LongLanguage
                        parVideo_Bitrate.Value = _TVEpDB.TVEp.FileInfo.StreamDetails.Video(i).Bitrate
                        parVideo_MultiViewCount.Value = _TVEpDB.TVEp.FileInfo.StreamDetails.Video(i).MultiViewCount
                        parVideo_MultiViewLayout.Value = _TVEpDB.TVEp.FileInfo.StreamDetails.Video(i).MultiViewLayout
                        parVideo_EncodedSettings.Value = _TVEpDB.TVEp.FileInfo.StreamDetails.Video(i).EncodedSettings
                        parVideo_StereoMode.Value = _TVEpDB.TVEp.FileInfo.StreamDetails.Video(i).StereoMode

                        SQLcommandTVVStreams.ExecuteNonQuery()
                    Next
                End Using
                Using SQLcommandTVAStreams As SQLite.SQLiteCommand = _myvideosDBConn.CreateCommand()
                    SQLcommandTVAStreams.CommandText = String.Concat("DELETE FROM TVAStreams WHERE TVEpID = ", _TVEpDB.EpID, ";")
                    SQLcommandTVAStreams.ExecuteNonQuery()
                    SQLcommandTVAStreams.CommandText = String.Concat("INSERT OR REPLACE INTO TVAStreams (", _
                       "TVEpID, StreamID, Audio_Language, Audio_LongLanguage, Audio_Codec, Audio_Channel, Audio_Bitrate", _
                       ") VALUES (?,?,?,?,?,?,?);")

                    Dim parAudio_EpID As SQLite.SQLiteParameter = SQLcommandTVAStreams.Parameters.Add("parAudio_EpID", DbType.UInt64, 0, "TVEpID")
                    Dim parAudio_StreamID As SQLite.SQLiteParameter = SQLcommandTVAStreams.Parameters.Add("parAudio_StreamID", DbType.UInt64, 0, "StreamID")
                    Dim parAudio_Language As SQLite.SQLiteParameter = SQLcommandTVAStreams.Parameters.Add("parAudio_Language", DbType.String, 0, "Audio_Language")
                    Dim parAudio_LongLanguage As SQLite.SQLiteParameter = SQLcommandTVAStreams.Parameters.Add("parAudio_LongLanguage", DbType.String, 0, "Audio_LongLanguage")
                    Dim parAudio_Codec As SQLite.SQLiteParameter = SQLcommandTVAStreams.Parameters.Add("parAudio_Codec", DbType.String, 0, "Audio_Codec")
                    Dim parAudio_Channel As SQLite.SQLiteParameter = SQLcommandTVAStreams.Parameters.Add("parAudio_Channel", DbType.String, 0, "Audio_Channel")
                    Dim parAudio_Bitrate As SQLite.SQLiteParameter = SQLcommandTVAStreams.Parameters.Add("parAudio_Bitrate", DbType.String, 0, "Audio_Bitrate")

                    For i As Integer = 0 To _TVEpDB.TVEp.FileInfo.StreamDetails.Audio.Count - 1
                        parAudio_EpID.Value = _TVEpDB.EpID
                        parAudio_StreamID.Value = i
                        parAudio_Language.Value = _TVEpDB.TVEp.FileInfo.StreamDetails.Audio(i).Language
                        parAudio_LongLanguage.Value = _TVEpDB.TVEp.FileInfo.StreamDetails.Audio(i).LongLanguage
                        parAudio_Codec.Value = _TVEpDB.TVEp.FileInfo.StreamDetails.Audio(i).Codec
                        parAudio_Channel.Value = _TVEpDB.TVEp.FileInfo.StreamDetails.Audio(i).Channels
                        parAudio_Bitrate.Value = _TVEpDB.TVEp.FileInfo.StreamDetails.Audio(i).Bitrate

                        SQLcommandTVAStreams.ExecuteNonQuery()
                    Next
                End Using

                'subtitles
                Using SQLcommandTVSubs As SQLite.SQLiteCommand = _myvideosDBConn.CreateCommand()
                    SQLcommandTVSubs.CommandText = String.Concat("DELETE FROM TVSubs WHERE TVEpID = ", _TVEpDB.EpID, ";")
                    SQLcommandTVSubs.ExecuteNonQuery()

                    SQLcommandTVSubs.CommandText = String.Concat("INSERT OR REPLACE INTO TVSubs (", _
                       "TVEpID, StreamID, Subs_Language, Subs_LongLanguage, Subs_Type, Subs_Path, Subs_Forced", _
                       ") VALUES (?,?,?,?,?,?,?);")
                    Dim parSubs_EpID As SQLite.SQLiteParameter = SQLcommandTVSubs.Parameters.Add("parSubs_EpID", DbType.UInt64, 0, "TVEpID")
                    Dim parSubs_StreamID As SQLite.SQLiteParameter = SQLcommandTVSubs.Parameters.Add("parSubs_StreamID", DbType.UInt64, 0, "StreamID")
                    Dim parSubs_Language As SQLite.SQLiteParameter = SQLcommandTVSubs.Parameters.Add("parSubs_Language", DbType.String, 0, "Subs_Language")
                    Dim parSubs_LongLanguage As SQLite.SQLiteParameter = SQLcommandTVSubs.Parameters.Add("parSubs_LongLanguage", DbType.String, 0, "Subs_LongLanguage")
                    Dim parSubs_Type As SQLite.SQLiteParameter = SQLcommandTVSubs.Parameters.Add("parSubs_Type", DbType.String, 0, "Subs_Type")
                    Dim parSubs_Path As SQLite.SQLiteParameter = SQLcommandTVSubs.Parameters.Add("parSubs_Path", DbType.String, 0, "Subs_Path")
                    Dim parSubs_Forced As SQLite.SQLiteParameter = SQLcommandTVSubs.Parameters.Add("parSubs_Forced", DbType.Boolean, 0, "Subs_Forced")
                    Dim iID As Integer = 0
                    'embedded subtitles
                    For i As Integer = 0 To _TVEpDB.TVEp.FileInfo.StreamDetails.Subtitle.Count - 1
                        parSubs_EpID.Value = _TVEpDB.EpID
                        parSubs_StreamID.Value = iID
                        parSubs_Language.Value = _TVEpDB.TVEp.FileInfo.StreamDetails.Subtitle(i).Language
                        parSubs_LongLanguage.Value = _TVEpDB.TVEp.FileInfo.StreamDetails.Subtitle(i).LongLanguage
                        parSubs_Type.Value = _TVEpDB.TVEp.FileInfo.StreamDetails.Subtitle(i).SubsType
                        parSubs_Path.Value = _TVEpDB.TVEp.FileInfo.StreamDetails.Subtitle(i).SubsPath
                        parSubs_Forced.Value = _TVEpDB.TVEp.FileInfo.StreamDetails.Subtitle(i).SubsForced
                        SQLcommandTVSubs.ExecuteNonQuery()
                        iID += 1
                    Next
                    'external subtitles
                    For i As Integer = 0 To _TVEpDB.EpSubtitles.Count - 1
                        parSubs_EpID.Value = _TVEpDB.EpID
                        parSubs_StreamID.Value = iID
                        parSubs_Language.Value = _TVEpDB.EpSubtitles(i).Language
                        parSubs_LongLanguage.Value = _TVEpDB.EpSubtitles(i).LongLanguage
                        parSubs_Type.Value = _TVEpDB.EpSubtitles(i).SubsType
                        parSubs_Path.Value = _TVEpDB.EpSubtitles(i).SubsPath
                        parSubs_Forced.Value = _TVEpDB.EpSubtitles(i).SubsForced
                        SQLcommandTVSubs.ExecuteNonQuery()
                        iID += 1
                    Next
                End Using

                If WithSeason Then SaveTVSeasonToDB(_TVEpDB, True)
            End If
        End Using
        If Not BatchMode Then SQLtransaction.Commit()
    End Sub
    ''' <summary>
    ''' Stores information for a single season to the database
    ''' </summary>
    ''' <param name="_TVSeasonDB">Structures.DBTV representing the season to be stored.</param>
    ''' <param name="BatchMode"></param>
    ''' <remarks>Note that this stores the season information, not the individual episodes within that season</remarks>
    Public Sub SaveTVSeasonToDB(ByRef _TVSeasonDB As Structures.DBTV, Optional ByVal BatchMode As Boolean = False)
        Dim doesExist As Boolean = False
        Dim ID As Long = -1

        Using SQLcommand_select_seasons As SQLite.SQLiteCommand = _myvideosDBConn.CreateCommand()
            SQLcommand_select_seasons.CommandText = String.Format("SELECT idSeason FROM seasons WHERE idShow = {0} AND Season = {1}", _TVSeasonDB.ShowID, _TVSeasonDB.TVEp.Season)
            Using SQLreader As SQLite.SQLiteDataReader = SQLcommand_select_seasons.ExecuteReader()
                While SQLreader.Read
                    doesExist = True
                    ID = CInt(SQLreader("idSeason"))
                    Exit While
                End While
            End Using
        End Using

        Dim SQLtransaction As SQLite.SQLiteTransaction = Nothing
        If Not BatchMode Then SQLtransaction = _myvideosDBConn.BeginTransaction()

        If Not doesExist Then
            Using SQLcommand_insert_seasons As SQLite.SQLiteCommand = _myvideosDBConn.CreateCommand()
                SQLcommand_insert_seasons.CommandText = "INSERT INTO seasons (idSeason, idShow, Season, SeasonText, Lock, Mark, New) VALUES (NULL,?,?,?,?,?,?); SELECT LAST_INSERT_ROWID() FROM seasons;"
                Dim par_seasons_idShow As SQLite.SQLiteParameter = SQLcommand_insert_seasons.Parameters.Add("par_seasons_idShow", DbType.UInt64, 0, "idShow")
                Dim par_seasons_Season As SQLite.SQLiteParameter = SQLcommand_insert_seasons.Parameters.Add("par_seasons_Season", DbType.Int32, 0, "Season")
                Dim par_seasons_SeasonText As SQLite.SQLiteParameter = SQLcommand_insert_seasons.Parameters.Add("par_seasons_SeasonText", DbType.String, 0, "SeasonText")
                Dim par_seasons_Lock As SQLite.SQLiteParameter = SQLcommand_insert_seasons.Parameters.Add("par_seasons_Lock", DbType.Boolean, 0, "Lock")
                Dim par_seasons_Mark As SQLite.SQLiteParameter = SQLcommand_insert_seasons.Parameters.Add("par_seasons_Mark", DbType.Boolean, 0, "Mark")
                Dim par_seasons_New As SQLite.SQLiteParameter = SQLcommand_insert_seasons.Parameters.Add("par_seasons_New", DbType.Boolean, 0, "New")
                par_seasons_idShow.Value = _TVSeasonDB.ShowID
                par_seasons_Season.Value = _TVSeasonDB.TVEp.Season
                par_seasons_SeasonText.Value = StringUtils.FormatSeasonText(_TVSeasonDB.TVEp.Season)
                par_seasons_Lock.Value = _TVSeasonDB.IsLockSeason
                par_seasons_Mark.Value = _TVSeasonDB.IsMarkSeason
                par_seasons_New.Value = True
                ID = CInt(SQLcommand_insert_seasons.ExecuteScalar())
            End Using
        Else
            Using SQLcommand_update_seasons As SQLite.SQLiteCommand = _myvideosDBConn.CreateCommand()
                SQLcommand_update_seasons.CommandText = String.Format("UPDATE seasons SET SeasonText=?, Lock=?, Mark=?, New=? WHERE idSeason={0}", ID)
                Dim par_seasons_SeasonText As SQLite.SQLiteParameter = SQLcommand_update_seasons.Parameters.Add("par_seasons_SeasonText", DbType.String, 0, "SeasonText")
                Dim par_seasons_Lock As SQLite.SQLiteParameter = SQLcommand_update_seasons.Parameters.Add("par_seasons_Lock", DbType.Boolean, 0, "Lock")
                Dim par_seasons_Mark As SQLite.SQLiteParameter = SQLcommand_update_seasons.Parameters.Add("par_seasons_Mark", DbType.Boolean, 0, "Mark")
                Dim par_seasons_New As SQLite.SQLiteParameter = SQLcommand_update_seasons.Parameters.Add("par_seasons_New", DbType.Boolean, 0, "New")
                par_seasons_SeasonText.Value = StringUtils.FormatSeasonText(_TVSeasonDB.TVEp.Season)
                par_seasons_Lock.Value = _TVSeasonDB.IsLockSeason
                par_seasons_Mark.Value = _TVSeasonDB.IsMarkSeason
                par_seasons_New.Value = False
                SQLcommand_update_seasons.ExecuteNonQuery()
            End Using
        End If

        'Images
        Using SQLcommand_art As SQLite.SQLiteCommand = _myvideosDBConn.CreateCommand()
            SQLcommand_art.CommandText = String.Concat("DELETE FROM art WHERE media_id = ", _TVSeasonDB.SeasonID, " AND media_type = 'season';")
            SQLcommand_art.ExecuteNonQuery()
        End Using
        If Not String.IsNullOrEmpty(_TVSeasonDB.SeasonBannerPath) Then SetArtForItem(_TVSeasonDB.SeasonID, "season", "banner", _TVSeasonDB.SeasonBannerPath)
        If Not String.IsNullOrEmpty(_TVSeasonDB.SeasonFanartPath) Then SetArtForItem(_TVSeasonDB.SeasonID, "season", "fanart", _TVSeasonDB.SeasonFanartPath)
        If Not String.IsNullOrEmpty(_TVSeasonDB.SeasonLandscapePath) Then SetArtForItem(_TVSeasonDB.SeasonID, "season", "landscape", _TVSeasonDB.SeasonLandscapePath)
        If Not String.IsNullOrEmpty(_TVSeasonDB.SeasonPosterPath) Then SetArtForItem(_TVSeasonDB.SeasonID, "season", "poster", _TVSeasonDB.SeasonPosterPath)

        If Not BatchMode Then SQLtransaction.Commit()
    End Sub
    ''' <summary>
    ''' Saves all show information from a Structures.DBTV object to the database
    ''' </summary>
    ''' <param name="_TVShowDB">Structures.DBTV object to save to the database</param>
    ''' <param name="IsNew">Is this a new show (not already present in database)?</param>
    ''' <param name="BatchMode">Is the function already part of a transaction?</param>
    ''' <param name="ToNfo">Save the information to an nfo file?</param>
    Public Sub SaveTVShowToDB(ByRef _TVShowDB As Structures.DBTV, ByVal IsNew As Boolean, Optional ByVal BatchMode As Boolean = False, Optional ByVal ToNfo As Boolean = False)
        Dim SQLtransaction As SQLite.SQLiteTransaction = Nothing

        If Not BatchMode Then SQLtransaction = _myvideosDBConn.BeginTransaction()
        Using SQLcommand As SQLite.SQLiteCommand = _myvideosDBConn.CreateCommand()
            If IsNew Then
                SQLcommand.CommandText = String.Concat("INSERT OR REPLACE INTO tvshow (", _
                 "TVShowPath, New, Mark, Source, TVDB, Lock, ListTitle, EpisodeGuide, ", _
                 "Plot, Genre, Premiered, Studio, MPAA, Rating, NfoPath, NeedsSave, Language, Ordering, ", _
                 "Status, ThemePath, ", _
                 "EFanartsPath, Runtime, Title, Votes, EpisodeSorting", _
                 ") VALUES (?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?); SELECT LAST_INSERT_ROWID() FROM tvshow;")
            Else
                SQLcommand.CommandText = String.Concat("INSERT OR REPLACE INTO tvshow (", _
                 "idShow, TVShowPath, New, Mark, Source, TVDB, Lock, ListTitle, EpisodeGuide, ", _
                 "Plot, Genre, Premiered, Studio, MPAA, Rating, NfoPath, NeedsSave, Language, Ordering, ", _
                 "Status, ThemePath, ", _
                 "EFanartsPath, Runtime, Title, Votes, EpisodeSorting", _
                 ") VALUES (?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?); SELECT LAST_INSERT_ROWID() FROM tvshow;")
                Dim parTVShowID As SQLite.SQLiteParameter = SQLcommand.Parameters.Add("parTVShowID", DbType.UInt64, 0, "idShow")
                parTVShowID.Value = _TVShowDB.ShowID
            End If

            Dim parTVShowPath As SQLite.SQLiteParameter = SQLcommand.Parameters.Add("parTVShowPath", DbType.String, 0, "TVShowPath")
            Dim parNew As SQLite.SQLiteParameter = SQLcommand.Parameters.Add("parNew", DbType.Boolean, 0, "new")
            Dim parMark As SQLite.SQLiteParameter = SQLcommand.Parameters.Add("parMark", DbType.Boolean, 0, "mark")
            Dim parSource As SQLite.SQLiteParameter = SQLcommand.Parameters.Add("parSource", DbType.String, 0, "source")
            Dim parTVDB As SQLite.SQLiteParameter = SQLcommand.Parameters.Add("parTVDB", DbType.String, 0, "TVDB")
            Dim parLock As SQLite.SQLiteParameter = SQLcommand.Parameters.Add("parLock", DbType.Boolean, 0, "lock")
            Dim parListTitle As SQLite.SQLiteParameter = SQLcommand.Parameters.Add("parListTitle", DbType.String, 0, "ListTitle")
            Dim parEpisodeGuide As SQLite.SQLiteParameter = SQLcommand.Parameters.Add("parEpisodeGuide", DbType.String, 0, "EpisodeGuide")
            Dim parPlot As SQLite.SQLiteParameter = SQLcommand.Parameters.Add("parPlot", DbType.String, 0, "Plot")
            Dim parGenre As SQLite.SQLiteParameter = SQLcommand.Parameters.Add("parGenre", DbType.String, 0, "Genre")
            Dim parPremiered As SQLite.SQLiteParameter = SQLcommand.Parameters.Add("parPremiered", DbType.String, 0, "Premiered")
            Dim parStudio As SQLite.SQLiteParameter = SQLcommand.Parameters.Add("parStudio", DbType.String, 0, "Studio")
            Dim parMPAA As SQLite.SQLiteParameter = SQLcommand.Parameters.Add("parMPAA", DbType.String, 0, "MPAA")
            Dim parRating As SQLite.SQLiteParameter = SQLcommand.Parameters.Add("parRating", DbType.String, 0, "Rating")
            Dim parNfoPath As SQLite.SQLiteParameter = SQLcommand.Parameters.Add("parNfoPath", DbType.String, 0, "NfoPath")
            Dim parNeedsSave As SQLite.SQLiteParameter = SQLcommand.Parameters.Add("parNeedsSave", DbType.Boolean, 0, "NeedsSave")
            Dim parLanguage As SQLite.SQLiteParameter = SQLcommand.Parameters.Add("parLanguage", DbType.String, 0, "Language")
            Dim parOrdering As SQLite.SQLiteParameter = SQLcommand.Parameters.Add("parOrdering", DbType.Int16, 0, "Ordering")
            Dim parStatus As SQLite.SQLiteParameter = SQLcommand.Parameters.Add("parStatus", DbType.String, 0, "Status")
            Dim parThemePath As SQLite.SQLiteParameter = SQLcommand.Parameters.Add("parThemePath", DbType.String, 0, "ThemePath")
            Dim parEFanartsPath As SQLite.SQLiteParameter = SQLcommand.Parameters.Add("parEFanartsPath", DbType.String, 0, "EFanartsPath")
            Dim parRuntime As SQLite.SQLiteParameter = SQLcommand.Parameters.Add("parRuntime", DbType.String, 0, "Runtime")
            Dim parTitle As SQLite.SQLiteParameter = SQLcommand.Parameters.Add("parTitle", DbType.String, 0, "Title")
            Dim parVotes As SQLite.SQLiteParameter = SQLcommand.Parameters.Add("parVotes", DbType.String, 0, "Votes")
            Dim parEpisodeSorting As SQLite.SQLiteParameter = SQLcommand.Parameters.Add("parEpisodeSorting", DbType.Int16, 0, "EpisodeSorting")

            With _TVShowDB.TVShow
                parTVDB.Value = .ID
                parTitle.Value = .Title
                parEpisodeGuide.Value = .EpisodeGuide.URL
                parPlot.Value = .Plot
                parGenre.Value = .Genre
                parPremiered.Value = .Premiered
                parStudio.Value = .Studio
                parMPAA.Value = .MPAA
                parRating.Value = .Rating
                parStatus.Value = .Status
                parRuntime.Value = .Runtime
                parVotes.Value = NumUtils.CleanVotes(.Votes)
            End With

            ' First let's save it to NFO, even because we will need the NFO path
            If ToNfo Then NFO.SaveTVShowToNFO(_TVShowDB)

            parEFanartsPath.Value = _TVShowDB.ShowEFanartsPath
            parNfoPath.Value = _TVShowDB.ShowNfoPath
            parTVShowPath.Value = _TVShowDB.ShowPath
            parThemePath.Value = _TVShowDB.ShowThemePath

            parNew.Value = IsNew
            parListTitle.Value = _TVShowDB.ListTitle
            parMark.Value = _TVShowDB.IsMarkShow
            parLock.Value = _TVShowDB.IsLockShow
            parSource.Value = _TVShowDB.Source
            parNeedsSave.Value = _TVShowDB.ShowNeedsSave
            parLanguage.Value = If(String.IsNullOrEmpty(_TVShowDB.ShowLanguage), Master.DB.GetTVSourceLanguage(_TVShowDB.Source), _TVShowDB.ShowLanguage)
            parOrdering.Value = _TVShowDB.Ordering
            parEpisodeSorting.Value = _TVShowDB.EpisodeSorting



            If IsNew Then
                If Master.eSettings.TVGeneralMarkNewShows Then
                    parMark.Value = True
                Else
                    parMark.Value = False
                End If
                Using rdrTVShow As SQLite.SQLiteDataReader = SQLcommand.ExecuteReader()
                    If rdrTVShow.Read Then
                        _TVShowDB.ShowID = Convert.ToInt64(rdrTVShow(0))
                    Else
                        logger.Error("Something very wrong here: SaveTVShowToDB", _TVShowDB.ToString, "Error")
                        _TVShowDB.ShowID = -1
                        Exit Sub
                    End If
                End Using
            Else
                SQLcommand.ExecuteNonQuery()
            End If

            If Not _TVShowDB.ShowID = -1 Then

                'Actors
                Using SQLcommand_actorlinktvshow As SQLite.SQLiteCommand = _myvideosDBConn.CreateCommand()
                    SQLcommand_actorlinktvshow.CommandText = String.Format("DELETE FROM actorlinktvshow WHERE idShow = {0};", _TVShowDB.ShowID)
                    SQLcommand_actorlinktvshow.ExecuteNonQuery()
                End Using
                AddCast(_TVShowDB.ShowID, "tvshow", "show", _TVShowDB.TVShow.Actors)

                'Directors
                Using SQLcommand_directorlinktvshow As SQLite.SQLiteCommand = _myvideosDBConn.CreateCommand()
                    SQLcommand_directorlinktvshow.CommandText = String.Format("DELETE FROM directorlinktvshow WHERE idShow = {0};", _TVShowDB.ShowID)
                    SQLcommand_directorlinktvshow.ExecuteNonQuery()
                End Using
                For Each director As String In _TVShowDB.TVShow.Directors
                    AddDirectorToTvShow(_TVShowDB.ShowID, AddActor(director, "", ""))
                Next

                'Genres
                Using SQLcommand_genrelinktvshow As SQLite.SQLiteCommand = _myvideosDBConn.CreateCommand()
                    SQLcommand_genrelinktvshow.CommandText = String.Format("DELETE FROM genrelinktvshow WHERE idShow = {0};", _TVShowDB.ShowID)
                    SQLcommand_genrelinktvshow.ExecuteNonQuery()
                End Using
                For Each genre As String In _TVShowDB.TVShow.Genres
                    AddGenreToTvShow(_TVShowDB.ShowID, AddGenre(genre))
                Next

                'Images
                Using SQLcommand_art As SQLite.SQLiteCommand = _myvideosDBConn.CreateCommand()
                    SQLcommand_art.CommandText = String.Format("DELETE FROM art WHERE media_id = {0} AND media_type = 'tvshow';", _TVShowDB.ShowID)
                    SQLcommand_art.ExecuteNonQuery()
                End Using
                If Not String.IsNullOrEmpty(_TVShowDB.ShowBannerPath) Then SetArtForItem(_TVShowDB.ShowID, "tvshow", "banner", _TVShowDB.ShowBannerPath)
                If Not String.IsNullOrEmpty(_TVShowDB.ShowCharacterArtPath) Then SetArtForItem(_TVShowDB.ShowID, "tvshow", "characterart", _TVShowDB.ShowCharacterArtPath)
                If Not String.IsNullOrEmpty(_TVShowDB.ShowClearArtPath) Then SetArtForItem(_TVShowDB.ShowID, "tvshow", "clearart", _TVShowDB.ShowClearArtPath)
                If Not String.IsNullOrEmpty(_TVShowDB.ShowClearLogoPath) Then SetArtForItem(_TVShowDB.ShowID, "tvshow", "clearlogo", _TVShowDB.ShowClearLogoPath)
                If Not String.IsNullOrEmpty(_TVShowDB.ShowFanartPath) Then SetArtForItem(_TVShowDB.ShowID, "tvshow", "fanart", _TVShowDB.ShowFanartPath)
                If Not String.IsNullOrEmpty(_TVShowDB.ShowLandscapePath) Then SetArtForItem(_TVShowDB.ShowID, "tvshow", "landscape", _TVShowDB.ShowLandscapePath)
                If Not String.IsNullOrEmpty(_TVShowDB.ShowPosterPath) Then SetArtForItem(_TVShowDB.ShowID, "tvshow", "poster", _TVShowDB.ShowPosterPath)

                'Studios
                Using SQLcommand_studiolinktvshow As SQLite.SQLiteCommand = _myvideosDBConn.CreateCommand()
                    SQLcommand_studiolinktvshow.CommandText = String.Format("DELETE FROM studiolinktvshow WHERE idShow = {0};", _TVShowDB.ShowID)
                    SQLcommand_studiolinktvshow.ExecuteNonQuery()
                End Using
                For Each studio As String In _TVShowDB.TVShow.Studios
                    AddStudioToTvShow(_TVShowDB.ShowID, AddStudio(studio))
                Next

                'Tags
                Using SQLcommand_taglinks As SQLite.SQLiteCommand = _myvideosDBConn.CreateCommand()
                    SQLcommand_taglinks.CommandText = String.Format("DELETE FROM taglinks WHERE idMedia = {0} AND media_type = 'tvshow';", _TVShowDB.ShowID)
                    SQLcommand_taglinks.ExecuteNonQuery()
                End Using
                For Each tag As String In _TVShowDB.TVShow.Tags
                    AddTagToItem(_TVShowDB.ShowID, AddTag(tag), "tvshow")
                Next

            End If
        End Using

        If Not BatchMode Then SQLtransaction.Commit()
    End Sub
    ''' <summary>
    ''' Load TV Sources from the DB. This populates the Master.TVSources list of TV Sources
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub LoadTVSourcesFromDB()
        Master.TVSources.Clear()
        Using SQLcommand As SQLite.SQLiteCommand = _myvideosDBConn.CreateCommand()
            SQLcommand.CommandText = "SELECT ID, Name, path, LastScan, Language, Ordering, Exclude, EpisodeSorting FROM TVSources;"
            Using SQLreader As SQLite.SQLiteDataReader = SQLcommand.ExecuteReader()
                While SQLreader.Read
                    Try ' Parsing database entry may fail. If it does, log the error and ignore the entry but continue processing
                        Dim tvsource As New Structures.TVSource
                        tvsource.id = SQLreader("ID").ToString
                        tvsource.Name = SQLreader("Name").ToString
                        tvsource.Path = SQLreader("Path").ToString
                        tvsource.Language = SQLreader("Language").ToString
                        tvsource.Ordering = DirectCast(Convert.ToInt32(SQLreader("Ordering")), Enums.Ordering)
                        tvsource.Exclude = Convert.ToBoolean(SQLreader("Exclude"))
                        tvsource.EpisodeSorting = DirectCast(Convert.ToInt32(SQLreader("EpisodeSorting")), Enums.EpisodeSorting)
                        Master.TVSources.Add(tvsource)
                    Catch ex As Exception
                        logger.Error(New StackFrame().GetMethod().Name, ex)
                    End Try
                End While
            End Using
        End Using
    End Sub
    ''' <summary>
    ''' Load Movie Sources from the DB. This populates the Master.MovieSources list of movie Sources
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub LoadMovieSourcesFromDB()
        Master.MovieSources.Clear()
        Using SQLcommand As SQLite.SQLiteCommand = _myvideosDBConn.CreateCommand()
            SQLcommand.CommandText = "SELECT ID, Name, Path, Recursive, Foldername, Single, LastScan, Exclude, GetYear FROM Sources;"
            Using SQLreader As SQLite.SQLiteDataReader = SQLcommand.ExecuteReader()
                While SQLreader.Read
                    Try ' Parsing database entry may fail. If it does, log the error and ignore the entry but continue processing
                        Dim msource As New Structures.MovieSource
                        msource.id = SQLreader("ID").ToString
                        msource.Name = SQLreader("Name").ToString
                        msource.Path = SQLreader("Path").ToString
                        msource.Recursive = Convert.ToBoolean(SQLreader("Recursive"))
                        msource.UseFolderName = Convert.ToBoolean(SQLreader("Foldername"))
                        msource.IsSingle = Convert.ToBoolean(SQLreader("Single"))
                        msource.Exclude = Convert.ToBoolean(SQLreader("Exclude"))
                        msource.GetYear = Convert.ToBoolean(SQLreader("GetYear"))
                        Master.MovieSources.Add(msource)
                    Catch ex As Exception
                        logger.Error(New StackFrame().GetMethod().Name, ex)
                    End Try
                End While
            End Using
        End Using
    End Sub
    ''' <summary>
    ''' Load excluded directories from the DB. This populates the Master.ExcludeDirs list
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub LoadExcludeDirsFromDB()
        Master.ExcludeDirs.Clear()
        Try
            Using SQLcommand As SQLite.SQLiteCommand = _myvideosDBConn.CreateCommand()
                SQLcommand.CommandText = "SELECT Dirname FROM ExcludeDir;"
                Using SQLreader As SQLite.SQLiteDataReader = SQLcommand.ExecuteReader()
                    While SQLreader.Read
                        Try ' Parsing database entry may fail. If it does, log the error and ignore the entry but continue processing
                            Dim eDir As String = String.Empty
                            eDir = SQLreader("Dirname").ToString
                            Master.ExcludeDirs.Add(eDir)
                        Catch ex As Exception
                            logger.Error(New StackFrame().GetMethod().Name, ex)
                        End Try
                    End While
                End Using
            End Using
        Catch ex As Exception
            logger.Error(New StackFrame().GetMethod().Name, ex)
        End Try
    End Sub
    ''' <summary>
    ''' Retrieve movie paths.
    ''' </summary>
    ''' <param name="source">If supplied, paths returned will be restricted to the given source. No validation is done
    ''' on this source to ensure it is valid. If it is not valid, expect the returned paths to be empty.</param>
    ''' <returns>List of String movie paths</returns>
    ''' <remarks></remarks>
    Public Function GetMoviePathsBySource(Optional ByVal source As String = "") As List(Of String)
        Dim Paths As New List(Of String)
        Try
            Using SQLcommand As SQLite.SQLiteCommand = _myvideosDBConn.CreateCommand()
                SQLcommand.CommandText = String.Format("SELECT MoviePath, Source FROM movie {0};", If(source = String.Empty, String.Empty, String.Format("INNER JOIN Sources ON movie.Source=Sources.Name Where Sources.Path=""{0}""", source)))
                Using SQLreader As SQLite.SQLiteDataReader = SQLcommand.ExecuteReader()
                    While SQLreader.Read
                        Try ' Parsing database entry may fail. If it does, log the error and ignore the entry but continue processing
                            Paths.Add(SQLreader("MoviePath").ToString)
                        Catch ex As Exception
                            logger.Error(New StackFrame().GetMethod().Name, ex)
                        End Try
                    End While
                End Using
            End Using
        Catch ex As Exception
            logger.Error(New StackFrame().GetMethod().Name, ex)
        End Try

        Return Paths
    End Function


    '''''''''''''''''''''''''''''''''''''''''''
    'Protected Sub ConnectJobsDB()
    '    If _myvideosDBConn IsNot Nothing Then
    '        Return
    '        'Throw New InvalidOperationException("A database connection is already open, can't open another.")
    '    End If

    '    Dim jobsDBFile As String = Path.Combine(Functions.AppPath, "JobLogs.emm")
    '    Dim isNew As Boolean = (Not File.Exists(jobsDBFile))

    '    Try
    '        _jobsDBConn = New SQLiteConnection(String.Format(_connStringTemplate, jobsDBFile))
    '        _jobsDBConn.Open()
    '    Catch ex As Exception
    '        logger.Error(GetType(Database),ex.ToString, _
    '                                    ex.StackTrace, _
    '                                    "Unable to open media database connection.")
    '    End Try

    '    If isNew Then
    '        Dim sqlCommand As String = My.Resources.JobsDatabaseSQL_v1
    '        Using transaction As SQLite.SQLiteTransaction = _jobsDBConn.BeginTransaction()
    '            Using command As SQLite.SQLiteCommand = _jobsDBConn.CreateCommand()
    '                command.CommandText = sqlCommand
    '                command.ExecuteNonQuery()
    '            End Using
    '            transaction.Commit()
    '        End Using
    '    End If
    'End Sub

    ''' <summary>
    ''' Verify whether the given Addon is installed
    ''' </summary>
    ''' <param name="AddonID">The AddonID to be verified.</param>
    ''' <returns>Version of the addon, if it is installed, or zero (0) otherwise</returns>
    ''' <remarks></remarks>
    Public Function IsAddonInstalled(ByVal AddonID As Integer) As Single
        If AddonID < 0 Then
            logger.Error(New StackFrame().GetMethod().Name, Environment.StackTrace, "Invalid AddonID: {0}" & AddonID)
            'Throw New ArgumentOutOfRangeException("AddonID", "Must be a positive integer")
        End If

        Try
            Using SQLCommand As SQLite.SQLiteCommand = _myvideosDBConn.CreateCommand()
                SQLCommand.CommandText = String.Concat("SELECT Version FROM Addons WHERE AddonID = ", AddonID, ";")
                Dim tES As Object = SQLCommand.ExecuteScalar
                If tES IsNot Nothing Then
                    Dim tSing As Single = 0
                    If Single.TryParse(tES.ToString, tSing) Then
                        Return tSing
                    End If
                End If
            End Using
        Catch ex As Exception
            logger.Error(New StackFrame().GetMethod().Name, ex)
        End Try
        Return 0
    End Function
    ''' <summary>
    ''' Removes the referenced Addon from the list of installed Addons
    ''' </summary>
    ''' <param name="AddonID"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function UninstallAddon(ByVal AddonID As Integer) As Boolean
        If AddonID < 0 Then
            logger.Error(New StackFrame().GetMethod().Name, Environment.StackTrace, "Invalid AddonID: {0}" & AddonID)
            'Throw New ArgumentOutOfRangeException("AddonID", "Must be a positive integer")
        End If

        Dim needRestart As Boolean = False
        Try
            Dim _cmds As Containers.InstallCommands = Containers.InstallCommands.Load(Path.Combine(Functions.AppPath, "InstallTasks.xml"))
            Using SQLtransaction As SQLite.SQLiteTransaction = _myvideosDBConn.BeginTransaction()
                Using SQLCommand As SQLite.SQLiteCommand = _myvideosDBConn.CreateCommand()
                    SQLCommand.CommandText = String.Concat("SELECT FilePath FROM AddonFiles WHERE AddonID = ", AddonID, ";")
                    Using SQLReader As SQLite.SQLiteDataReader = SQLCommand.ExecuteReader
                        While SQLReader.Read
                            Try
                                File.Delete(SQLReader("FilePath").ToString)
                            Catch
                                _cmds.noTransaction.Add(New Containers.CommandsNoTransactionCommand With {.type = "FILE.Delete", .execute = SQLReader("FilePath").ToString})
                                needRestart = True
                            End Try
                        End While
                        If needRestart Then _cmds.Save(Path.Combine(Functions.AppPath, "InstallTasks.xml"))
                    End Using
                    SQLCommand.CommandText = String.Concat("DELETE FROM Addons WHERE AddonID = ", AddonID, ";")
                    SQLCommand.ExecuteNonQuery()
                    SQLCommand.CommandText = String.Concat("DELETE FROM AddonFiles WHERE AddonID = ", AddonID, ";")
                    SQLCommand.ExecuteNonQuery()
                End Using
                SQLtransaction.Commit()
            End Using
        Catch ex As Exception
            logger.Error(New StackFrame().GetMethod().Name, ex)
        End Try
        Return Not needRestart
    End Function

    ''' <summary>
    ''' Saves/installs the supplied Addon to the database
    ''' </summary>
    ''' <param name="Addon">Addon to be saved</param>
    ''' <remarks></remarks>
    Public Sub SaveAddonToDB(ByVal Addon As Containers.Addon)
        'TODO Need to add validation on Addon.ID, especially if it is passed in the parameter
        If Addon Is Nothing Then
            logger.Error(New StackFrame().GetMethod().Name, Environment.StackTrace, "Invalid AddonID: empty")
        End If
        Try
            Using SQLtransaction As SQLite.SQLiteTransaction = _myvideosDBConn.BeginTransaction()
                Using SQLCommand As SQLite.SQLiteCommand = _myvideosDBConn.CreateCommand()
                    SQLCommand.CommandText = String.Concat("INSERT OR REPLACE INTO Addons (", _
                      "AddonID, Version) VALUES (?,?);")
                    Dim parAddonID As SQLite.SQLiteParameter = SQLCommand.Parameters.Add("parAddonID", DbType.Int32, 0, "AddonID")
                    Dim parVersion As SQLite.SQLiteParameter = SQLCommand.Parameters.Add("parVersion", DbType.String, 0, "Version")

                    parAddonID.Value = Addon.ID
                    parVersion.Value = Addon.Version.ToString

                    SQLCommand.ExecuteNonQuery()

                    SQLCommand.CommandText = String.Concat("DELETE FROM AddonFiles WHERE AddonID = ", Addon.ID, ";")
                    SQLCommand.ExecuteNonQuery()

                    Using SQLFileCommand As SQLite.SQLiteCommand = _myvideosDBConn.CreateCommand()
                        SQLFileCommand.CommandText = String.Concat("INSERT INTO AddonFiles (AddonID, FilePath) VALUES (?,?);")
                        Dim parFileAddonID As SQLite.SQLiteParameter = SQLFileCommand.Parameters.Add("parFileAddonID", DbType.Int32, 0, "AddonID")
                        Dim parFilePath As SQLite.SQLiteParameter = SQLFileCommand.Parameters.Add("parFilePath", DbType.String, 0, "FilePath")
                        parFileAddonID.Value = Addon.ID
                        For Each fFile As KeyValuePair(Of String, String) In Addon.Files
                            parFilePath.Value = Path.Combine(Functions.AppPath, fFile.Key.Replace("/", Path.DirectorySeparatorChar))
                            SQLFileCommand.ExecuteNonQuery()
                        Next
                    End Using
                End Using
                SQLtransaction.Commit()
            End Using
        Catch ex As Exception
            logger.Error(New StackFrame().GetMethod().Name, ex)
        End Try
    End Sub
    ''' <summary>
    ''' Save the PlayCount Tag for watched movie  into Ember database /NFO if not already set
    ''' </summary>
    ''' <param name="WatchedMovieData">The watched movie as Keypair</param>
    ''' <remarks>    
    ''' cocotus 2013/02 Trakt.tv syncing - Movies
    ''' not using loop here, only do one movie a time (call function repeatedly!)! -> only deliver keypair instead of whole dictionary
    ''' Old-> Public Sub SaveMoviePlayCountInDatabase(ByVal myWatchedMovies As Dictionary(Of String, KeyValuePair(Of String, String)))
    ''' </remarks>
    Public Sub SaveMoviePlayCountInDatabase(ByVal WatchedMovieData As KeyValuePair(Of String, KeyValuePair(Of String, Integer)), ByVal BatchMode As Boolean)
        Using SQLcommand As SQLite.SQLiteCommand = _myvideosDBConn.CreateCommand()
            SQLcommand.CommandText = String.Format("SELECT idMovie, Playcount FROM movie WHERE Imdb = '{0}';", WatchedMovieData.Value.Key)
            Using SQLreader As SQLite.SQLiteDataReader = SQLcommand.ExecuteReader()
                If SQLreader.HasRows Then
                    While SQLreader.Read
                        Dim currPlaycount As String = If(Not DBNull.Value.Equals(SQLreader("Playcount")), SQLreader("Playcount").ToString, Nothing) 'Playcount is always Nothing or > 0
                        If currPlaycount Is Nothing OrElse Not CInt(currPlaycount) = WatchedMovieData.Value.Value Then
                            Dim _movieSavetoNFO = Master.DB.LoadMovieFromDB(CInt(SQLreader("idMovie")))
                            _movieSavetoNFO.Movie.PlayCount = WatchedMovieData.Value.Value.ToString
                            Master.DB.SaveMovieToDB(_movieSavetoNFO, False, BatchMode, True)

                            'create .watched files
                            If Master.eSettings.MovieUseYAMJ AndAlso Master.eSettings.MovieYAMJWatchedFile Then
                                For Each a In FileUtils.GetFilenameList.Movie(_movieSavetoNFO.Filename, False, Enums.ModType_Movie.WatchedFile)
                                    If Not File.Exists(a) Then
                                        Dim fs As FileStream = File.Create(a)
                                        fs.Close()
                                    End If
                                Next
                            End If
                        End If
                    End While
                End If
            End Using
        End Using
    End Sub
    ''' <summary>
    ''' Save the PlayCount Tag for watched episode into Ember database /NFO if not already set
    ''' </summary>
    ''' <param name="strTVDBID">TVDBID for TV Show identification</param>
    ''' <param name="strSeason">Season Number</param>
    ''' <param name="strEpisode">Episode Number</param>
    ''' <remarks>
    ''' cocotus 2013/03 Trakt.tv syncing - Episodes
    ''' not using loop here, only do one episode a time (call function repeatedly!)!
    '''</remarks>
    Public Sub SaveEpisodePlayCountInDatabase(ByVal strTVDBID As String, ByVal strSeason As String, ByVal strEpisode As String, ByVal BatchMode As Boolean)
        Dim tempTVDBID As String = String.Empty

        'First get the internal ID of TVShow using the TVDBID info
        Using SQLcommand As SQLite.SQLiteCommand = _myvideosDBConn.CreateCommand()
            SQLcommand.CommandText = String.Format("SELECT idShow FROM tvshow WHERE tvdb = '{0}';", strTVDBID)
            Using SQLreader As SQLite.SQLiteDataReader = SQLcommand.ExecuteReader()
                If SQLreader.HasRows Then
                    While SQLreader.Read
                        If Not DBNull.Value.Equals(SQLreader("idShow")) Then
                            tempTVDBID = SQLreader("idShow").ToString
                            Exit While
                        End If
                    End While
                Else
                    'No ID --> TV Show doesn't Exist in Ember --> Exit no updates!
                    Exit Sub
                End If
            End Using
        End Using

        'Now we search episodes of the found TV Show
        Using SQLcommand As SQLite.SQLiteCommand = _myvideosDBConn.CreateCommand()
            SQLcommand.CommandText = String.Format("SELECT idEpisode, Playcount FROM episode WHERE idShow = {0} AND Season = {1} AND Episode = {2} AND Missing = 0;", tempTVDBID, strSeason, strEpisode)
            Using SQLreader As SQLite.SQLiteDataReader = SQLcommand.ExecuteReader()
                If SQLreader.HasRows Then
                    While SQLreader.Read
                        Dim currPlaycount As String = If(Not DBNull.Value.Equals(SQLreader("Playcount")), SQLreader("Playcount").ToString, Nothing) 'Playcount is always Nothing or > 0
                        If currPlaycount Is Nothing Then
                            Dim _episodeSavetoNFO = Master.DB.LoadTVEpFromDB(CInt(SQLreader("idEpisode")), True)
                            _episodeSavetoNFO.TVEp.Playcount = "1"
                            Master.DB.SaveTVEpToDB(_episodeSavetoNFO, False, False, BatchMode, True)
                        End If
                    End While
                End If
            End Using
        End Using
    End Sub

    ''' <summary>
    ''' Check if provided querystring is valid SQL
    ''' </summary>
    ''' <param name="Query">The SQL query to check</param>
    ''' <returns>true: valid query, false: invalid sql (check log!)</returns>
    ''' <remarks>    
    ''' cocotus 2015/03/07 Check for valid sql syntax, used for custom filter module
    ''' </remarks>
    Public Function IsValid_SQL(ByVal Query As String) As Boolean
        Try
            Using SQLcommand As SQLite.SQLiteCommand = Master.DB.MyVideosDBConn.CreateCommand()
                SQLcommand.CommandText = Query
                Using SQLreader As SQLite.SQLiteDataReader = SQLcommand.ExecuteReader()
                End Using
            End Using
            Return True
        Catch ex As Exception
            Dim response As String = ""
            response = Master.eLang.GetString(1386, "Invalid SQL!") & Environment.NewLine & ex.Message
            MessageBox.Show(ex.Message, Master.eLang.GetString(356, "Warning"), MessageBoxButtons.OK)
            Return False
        End Try
    End Function

#End Region 'Methods

#Region "Nested Types"

    Private Structure Arguments

#Region "Fields"

        Dim currDBPath As String
        Dim currVersion As Integer
        Dim newDBPath As String
        Dim newVersion As Integer

#End Region 'Fields

    End Structure
    ''' <summary>
    ''' Class representing a media Source
    ''' </summary>
    ''' <remarks></remarks>
    Private Class SourceHolder

#Region "Fields"

        Private _name As String
        Private _path As String
        Private _recursive As Boolean   ' Scanned recursively? I.e. should sub-directories be scanned as well?
        Private _single As Boolean      ' Does this path contains a single video/media?

#End Region 'Fields

#Region "Constructors"

        Public Sub New()
            Me.Clear()
        End Sub

#End Region 'Constructors

#Region "Properties"
        ''' <summary>
        ''' Does this path contains a single video/media?
        ''' </summary>
        ''' <value>Whether this folder contains a single video</value>
        Public Property isSingle() As Boolean
            Get
                Return Me._single
            End Get
            Set(ByVal value As Boolean)
                Me._single = value
            End Set
        End Property
        ''' <summary>
        ''' Name given to this source by the user
        ''' </summary>
        ''' <value>Name given to this source by the user</value>
        Public Property Name() As String
            Get
                Return Me._name
            End Get
            Set(ByVal value As String)
                Me._name = value
            End Set
        End Property
        Public Property Path() As String
            Get
                Return Me._path
            End Get
            Set(ByVal value As String)
                Me._path = value
            End Set
        End Property
        ''' <summary>
        ''' Scanned recursively? I.e. should sub-directories be scanned as well?
        ''' </summary>
        ''' <value>Whether sub-directories should be scanned</value>
        Public Property Recursive() As Boolean
            Get
                Return Me._recursive
            End Get
            Set(ByVal value As Boolean)
                Me._recursive = value
            End Set
        End Property

#End Region 'Properties

#Region "Methods"

        Public Sub Clear()
            Me._name = String.Empty
            Me._path = String.Empty
            Me._recursive = False
            Me._single = False
        End Sub

#End Region 'Methods

    End Class

    Friend Class MovieInSet
        Implements IComparable(Of MovieInSet)

#Region "Fields"

        Private _dbmovie As Structures.DBMovie
        Private _id As Long
        Private _listtitle As String
        Private _order As Integer

#End Region 'Fields

#Region "Constructors"

        Public Sub New()
            Me.Clear()
        End Sub

#End Region 'Constructors

#Region "Properties"

        Public Property DBMovie() As Structures.DBMovie
            Get
                Return Me._dbmovie
            End Get
            Set(ByVal value As Structures.DBMovie)
                Me._dbmovie = value
            End Set
        End Property

        Public Property ID() As Long
            Get
                Return Me._id
            End Get
            Set(ByVal value As Long)
                Me._id = value
            End Set
        End Property

        Public Property ListTitle() As String
            Get
                Return Me._listtitle
            End Get
            Set(ByVal value As String)
                Me._listtitle = value
            End Set
        End Property

        Public Property Order() As Integer
            Get
                Return Me._order
            End Get
            Set(ByVal value As Integer)
                Me._order = value
            End Set
        End Property

#End Region 'Properties

#Region "Methods"

        Public Sub Clear()
            Me._dbmovie = New Structures.DBMovie
            Me._id = -1
            Me._order = 0
            Me._listtitle = String.Empty
        End Sub

        Public Function CompareTo(ByVal other As MovieInSet) As Integer Implements IComparable(Of MovieInSet).CompareTo
            Return (Me.Order).CompareTo(other.Order)
        End Function

#End Region 'Methods

    End Class


#End Region 'Nested Types

End Class