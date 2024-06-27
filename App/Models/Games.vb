Imports MySql.Data.MySqlClient
Imports System.Text
Imports System.Security.Cryptography

Public Class Games
    Public Function Publish(ByVal gameName As String, ByVal devName As String, ByVal desc As String, ByVal pubName As String,
                          ByVal releaseDate As String, ByVal price As String, ByVal genre As String, ByVal platform As String,
                          ByVal isMultiplayerGame As Boolean) As Boolean
        Dim success As Boolean = False

        Try
            Connection.OpenConnection()

            ' Build the INSERT query with parameters to prevent SQL injection
            Dim query As String = String.Format("INSERT INTO Games (name, dev_game, description, pub_game, release_date, price_list, genre, platform, is_multiplayer) VALUES (@gameName, @devName, @desc, @pubName, @releaseDate, @price, @genre, @platform, @isMultiplayer)")

            Using cmd As New MySqlCommand(query, Connection.Connect)
                ' Add parameters to the query
                cmd.Parameters.AddWithValue("@gameName", gameName)
                cmd.Parameters.AddWithValue("@devName", devName)
                cmd.Parameters.AddWithValue("@desc", desc)
                cmd.Parameters.AddWithValue("@pubName", pubName)
                cmd.Parameters.AddWithValue("@releaseDate", releaseDate)
                cmd.Parameters.AddWithValue("@price", price)
                cmd.Parameters.AddWithValue("@genre", genre)
                cmd.Parameters.AddWithValue("@platform", platform)
                cmd.Parameters.AddWithValue("@isMultiplayer", isMultiplayerGame)

                ' Execute the query and check for successful insertion
                If cmd.ExecuteNonQuery() > 0 Then
                    success = True
                End If
            End Using
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Error Creating Game", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Connection.CloseConnection()
        End Try

        Return success
    End Function

    Public Function LoadGames() As DataTable
        Dim usersTable As New DataTable()
        Try
            Connection.OpenConnection()
            Dim query As String = "SELECT * FROM games"
            Using cmd As New MySqlCommand(query, Connection.Connect)
                Using adapter As New MySqlDataAdapter(cmd)
                    adapter.Fill(usersTable)
                End Using
            End Using
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Error Reading Users", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Connection.CloseConnection()
        End Try
        Return usersTable
    End Function

    Public Function DeleteGame(gameId As Integer) As Boolean
        Try
            ' Buka koneksi ke database
            Connection.OpenConnection()

            ' Query untuk menghapus game dari tabel games
            Dim query As String = "DELETE FROM games WHERE id=@GameId"
            Using cmd As New MySqlCommand(query, Connection.Connect)
                cmd.Parameters.AddWithValue("@GameId", gameId)
                cmd.ExecuteNonQuery()
            End Using

            ' Tampilkan pesan berhasil
            MessageBox.Show("Game deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Muat ulang data dari tabel games
            LoadGames()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Error Deleting Game", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Tutup koneksi ke database
            Connection.CloseConnection()
        End Try
    End Function
End Class
