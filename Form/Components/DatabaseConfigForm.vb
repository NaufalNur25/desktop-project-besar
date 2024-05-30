Imports MySql.Data.MySqlClient

Public Class DatabaseConfigForm
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        AddHandler MyBase.Load, AddressOf loadForm

        ' Database & Connetion
        AddHandler btFinish.MouseClick, AddressOf btFinishExecute
        AddHandler btTestConnection.MouseClick, AddressOf btTestConnectionExecute

        ' Form
        AddHandler btCancel.MouseClick, AddressOf btCancelExecute
    End Sub

    Private Sub loadForm()
        Dim config As Dictionary(Of String, String) = LoadConfig()
        Dim server As String = If(config.ContainsKey("server"), config("server"), "localhost")
        Dim uid As String = If(config.ContainsKey("uid"), config("uid"), String.Empty)
        Dim pwd As String = If(config.ContainsKey("pwd"), config("pwd"), String.Empty)
        Dim database As String = If(config.ContainsKey("database"), config("database"), String.Empty)

        setComponent(server, "3306", database, uid, pwd)
    End Sub

    Private Sub btCancelExecute()
        Me.Close()
    End Sub
    Private Sub btFinishExecute()
        Dim server As String = txtServerHost.Text
        Dim uid As String = txtUsername.Text
        Dim pwd As String = txtPassword.Text
        Dim database As String = txtDatabase.Text
        Dim port As String = If(Not String.IsNullOrEmpty(txtPort.Text), txtPort.Text, "3306")

        SaveConfig(server, port, uid, pwd, database)

        Me.Close()
    End Sub

    Private Sub btTestConnectionExecute()
        Dim server As String = txtServerHost.Text
        Dim database As String = txtDatabase.Text
        Dim uid As String = txtUsername.Text
        Dim pwd As String = txtPassword.Text
        Dim port As String = If(Not String.IsNullOrEmpty(txtPort.Text), txtPort.Text, "3306")

        TestConnection(server, port, uid, pwd, database)
    End Sub

    Private Sub SaveConfig(server As String, port As String, uid As String, pwd As String, database As String)
        Dim config As New System.Text.StringBuilder()
        config.AppendLine("server=" & server)
        config.AppendLine("port=" & port)
        config.AppendLine("uid=" & uid)
        config.AppendLine("pwd=" & pwd)
        config.AppendLine("database=" & database)

        Dim configPath As String = System.IO.Path.Combine(Application.StartupPath, "db_config.ini")

        System.IO.File.WriteAllText(configPath, config.ToString())
        MessageBox.Show("Configuration Saved!")
    End Sub

    Private Sub TestConnection(server As String, port As String, uid As String, pwd As String, database As String)
        Dim myConnectionString As String = $"server={server};port={port};uid={uid};pwd={pwd};database={database}"
        Dim stopwatch As Stopwatch = Stopwatch.StartNew()

        Try
            Using testConnection As New MySqlConnection(myConnectionString)
                testConnection.Open()
                stopwatch.Stop()

                MessageBox.Show($"Connection Successful!{Environment.NewLine}Connected ({stopwatch.ElapsedMilliseconds} ms)", "Database found", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Using
        Catch ex As MySqlException
            MessageBox.Show($"Connection Failed: {ex.Message}")
        End Try
    End Sub

    Private Sub setComponent(
        Optional server As String = Nothing,
        Optional port As String = Nothing,
        Optional database As String = Nothing,
        Optional username As String = Nothing,
        Optional password As String = Nothing)
        txtServerHost.Text = server
        txtPort.Text = port
        txtDatabase.Text = database
        txtUsername.Text = username
        txtPassword.Text = password
    End Sub
End Class