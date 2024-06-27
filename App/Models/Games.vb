Imports MySql.Data.MySqlClient
Imports System.Text
Imports System.Security.Cryptography

Public Class Games
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
