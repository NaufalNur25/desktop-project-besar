Imports MySql.Data.MySqlClient

Public Class Auth
    Public Function Login(email As String, hashedPassword As String) As (Boolean, String)
        Dim loginSuccessful As Boolean = False
        Dim username As String = String.Empty

        Try
            Connection.OpenConnection()
            Dim query As String = "SELECT username FROM users WHERE email=@Email AND password=@Password"
            Using cmd As New MySqlCommand(query, Connection.Connect)
                cmd.Parameters.AddWithValue("@Email", email)
                cmd.Parameters.AddWithValue("@Password", hashedPassword)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        loginSuccessful = True
                        username = reader("username").ToString()
                    End If
                End Using
            End Using
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Error Logging In", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Connection.CloseConnection()
        End Try

        Return (loginSuccessful, username)
    End Function

    Public Function Register(username As String, email As String, hashedPassword As String) As Boolean
        Dim userRegistered As Boolean = False
        Try
            Connection.OpenConnection()
            ' Periksa apakah email sudah terdaftar
            Dim checkQuery As String = "SELECT COUNT(*) FROM users WHERE email=@Email"
            Using checkCmd As New MySqlCommand(checkQuery, Connection.Connect)
                checkCmd.Parameters.AddWithValue("@Email", email)
                Dim result = Convert.ToInt32(checkCmd.ExecuteScalar())
                If result > 0 Then
                    MessageBox.Show("Email sudah terdaftar.", "Registrasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return False
                End If
            End Using

            ' Insert pengguna baru
            Dim query As String = "INSERT INTO users (username, email, password) VALUES (@Username, @Email, @Password)"
            Using cmd As New MySqlCommand(query, Connection.Connect)
                cmd.Parameters.AddWithValue("@Username", username)
                cmd.Parameters.AddWithValue("@Email", email)
                cmd.Parameters.AddWithValue("@Password", hashedPassword)
                Dim rowsAffected = cmd.ExecuteNonQuery()
                userRegistered = (rowsAffected > 0)
            End Using
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Error Registering", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Connection.CloseConnection()
        End Try
        If userRegistered Then
            MessageBox.Show("Registrasi berhasil!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Return userRegistered
    End Function
End Class
