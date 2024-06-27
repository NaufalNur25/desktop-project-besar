Imports System.IO
Imports System.Collections.Generic

Public Class SessionConfig
    Private sessionData As Dictionary(Of String, String)
    Private ReadOnly configPath As String

    Public Sub New()
        configPath = Path.Combine(Application.StartupPath, "session_config.ini")
        sessionData = New Dictionary(Of String, String)()
        LoadConfig()
    End Sub

    Public Function getSession(key As String) As String
        If sessionData.ContainsKey(key) Then
            Return sessionData(key)
        Else
            Return Nothing
        End If
    End Function

    Public Sub setSession(key As String, value As String)
        If sessionData.ContainsKey(key) Then
            sessionData(key) = value
        Else
            sessionData.Add(key, value)
        End If
    End Sub

    Public Sub removeSession(key As String)
        If sessionData.ContainsKey(key) Then
            sessionData.Remove(key)
        End If
    End Sub

    Public Sub SaveConfig()
        Using writer As New StreamWriter(configPath)
            For Each kvp As KeyValuePair(Of String, String) In sessionData
                writer.WriteLine($"{kvp.Key}={kvp.Value}")
            Next
        End Using
    End Sub

    Public Sub ClearSession()
        sessionData.Clear()
        SaveConfig()
    End Sub

    Private Sub LoadConfig()
        If File.Exists(configPath) Then
            Using reader As New StreamReader(configPath)
                While Not reader.EndOfStream
                    Dim line As String = reader.ReadLine()
                    If Not String.IsNullOrWhiteSpace(line) AndAlso line.Contains("=") Then
                        Dim parts() As String = line.Split("="c)
                        If parts.Length = 2 Then
                            sessionData(parts(0)) = parts(1)
                        End If
                    End If
                End While
            End Using
        End If
    End Sub
End Class
