Imports MySql.Data.MySqlClient
Imports System.Text
Imports System.Security.Cryptography

Public Class Admin
    ' Fungsi untuk menambahkan pengguna baru
    Public Function CreateUser(username As String, email As String, password As String) As Boolean
        Dim hashedPassword = GetHashedPassword(password)
        Dim userCreated As Boolean = False
        Try
            Connection.OpenConnection()
            Dim query As String = "INSERT INTO users (username, email, password) VALUES (@Username, @Email, @Password)"
            Using cmd As New MySqlCommand(query, Connection.Connect)
                cmd.Parameters.AddWithValue("@Username", username)
                cmd.Parameters.AddWithValue("@Email", email)
                cmd.Parameters.AddWithValue("@Password", hashedPassword)
                Dim rowsAffected = cmd.ExecuteNonQuery()
                userCreated = (rowsAffected > 0)
            End Using
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Error Creating User", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Connection.CloseConnection()
        End Try
        Return userCreated
    End Function

    ' Fungsi untuk membaca data semua pengguna
    Public Function ReadUsers() As DataTable
        Dim usersTable As New DataTable()
        Try
            Connection.OpenConnection()
            Dim query As String = "SELECT * FROM users"
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

    ' Fungsi untuk memperbarui data pengguna
    Public Function UpdateUser(userId As Integer, username As String, email As String, password As String, role As String) As Boolean
        Dim hashedPassword = GetHashedPassword(password)
        Dim userUpdated As Boolean = False
        Try
            Connection.OpenConnection()
            Dim query As String = "UPDATE users SET username=@Username, email=@Email, role=@role WHERE id=@UserId"
            Using cmd As New MySqlCommand(query, Connection.Connect)
                cmd.Parameters.AddWithValue("@UserId", userId)
                cmd.Parameters.AddWithValue("@Username", username)
                cmd.Parameters.AddWithValue("@Email", email)
                cmd.Parameters.AddWithValue("@Password", hashedPassword)
                cmd.Parameters.AddWithValue("@Role", role)
                Dim rowsAffected = cmd.ExecuteNonQuery()
                userUpdated = (rowsAffected > 0)
            End Using
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Error Updating User", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Connection.CloseConnection()
        End Try
        Return userUpdated
    End Function

    ' Fungsi untuk menghapus pengguna
    Public Function DeleteUser(userId As Integer) As Boolean
        Dim userDeleted As Boolean = False
        Try
            Connection.OpenConnection()
            Dim query As String = "DELETE FROM users WHERE id=@UserId"
            Using cmd As New MySqlCommand(query, Connection.Connect)
                cmd.Parameters.AddWithValue("@UserId", userId)
                Dim rowsAffected = cmd.ExecuteNonQuery()
                userDeleted = (rowsAffected > 0)
            End Using
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Error Deleting User", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Connection.CloseConnection()
        End Try
        Return userDeleted
    End Function

    ' Fungsi untuk hashing password
    Private Function GetHashedPassword(password As String) As String
        Using hasher As New SHA256Managed()
            Dim byteValue As Byte() = Encoding.UTF8.GetBytes(password)
            Dim byteHash As Byte() = hasher.ComputeHash(byteValue)
            Return Convert.ToBase64String(byteHash)
        End Using
    End Function
End Class
