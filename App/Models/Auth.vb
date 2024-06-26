Imports MySql.Data.MySqlClient

Public Class Auth
    Public Function Login(email As String, hashedPassword As String) As Boolean
        Dim userExists As Boolean = False
        Try
            Connection.OpenConnection()
            Dim query As String = "SELECT COUNT(*) FROM users WHERE email=@Email AND password=@Password"
            Using cmd As New MySqlCommand(query, Connection.Connect)
                cmd.Parameters.AddWithValue("@Email", email)
                cmd.Parameters.AddWithValue("@Password", hashedPassword)
                Dim result = cmd.ExecuteScalar()
                userExists = (Convert.ToInt32(result) > 0)
            End Using
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Error Logging In", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Connection.CloseConnection()
        End Try
        Return userExists
    End Function
End Class
