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
End Class
