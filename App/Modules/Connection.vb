Imports MySql.Data.MySqlClient
Imports System.IO

Module Connection
    Public Connect As MySqlConnection

    Public Sub OpenConnection(Optional is_debug As Boolean = True)
        Dim config As New DatabaseConfig(LoadConfig)
        Dim myConnectionString As String = config.ToString()

        Try
            Connect = New MySqlConnection(myConnectionString)
            Connect.Open()
        Catch ex As MySqlException
            If is_debug Then
                MessageBox.Show(ex.Message)
            End If
        Catch ex As FileNotFoundException
            If is_debug Then
                MessageBox.Show(ex.Message)
            End If
        End Try
    End Sub

    Public Sub CloseConnection()
        If Connect IsNot Nothing Then
            Try
                Connect.Close()
            Catch ex As MySqlException
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Public Function IsConnectionOpen() As Boolean
        Return Connect IsNot Nothing AndAlso Connect.State = ConnectionState.Open
    End Function

    Public Sub DeleteConfig()
        Dim configPath As String = Path.Combine(Application.StartupPath, "db_config.ini")

        If File.Exists(configPath) Then
            Try
                File.Delete(configPath)
                MessageBox.Show("Configuration File Deleted!")
            Catch ex As IOException
                MessageBox.Show($"Error Deleting Configuration File: {ex.Message}")
            End Try
        End If
    End Sub

    Public Function LoadConfig() As Dictionary(Of String, String)
        Dim config As New Dictionary(Of String, String)
        Dim configPath As String = Path.Combine(Application.StartupPath, "db_config.ini")

        If File.Exists(configPath) Then
            For Each line As String In File.ReadAllLines(configPath)
                Dim parts As String() = line.Split("="c)
                If parts.Length = 2 Then
                    config(parts(0).Trim()) = parts(1).Trim()
                End If
            Next
        End If

        Return config
    End Function
End Module
