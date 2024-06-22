Imports MySql.Data.MySqlClient
Imports System.Diagnostics

Public Class DatabaseConfigForm
    Private _Successful = False
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        AddHandler MyBase.Load, AddressOf LoadForm

        ' Database & Connetion
        AddHandler btFinish.MouseClick, AddressOf BtFinishExecute
        AddHandler btTestConnection.MouseClick, AddressOf btTestConnectionExecute

        ' Form
        AddHandler btCancel.MouseClick, AddressOf btCancelExecute
    End Sub

    Private Sub LoadForm()
        Dim config As New DatabaseConfig(Connection.LoadConfig())
        LogConfigData(config)
        setComponent(config.GetAttributes())
    End Sub

    Private Sub LogConfigData(config As DatabaseConfig)
        Dim attributes As Dictionary(Of String, String) = config.GetAttributes()

        For Each attribute In attributes
            Debug.WriteLine($"{attribute.Key}: {attribute.Value}")
        Next
    End Sub

    Private Sub btCancelExecute()
        Me.Close()
    End Sub

    Private Sub BtFinishExecute()
        Dim config As New DatabaseConfig(New Dictionary(Of String, String) From {
            {"server", txtServerHost.Text},
            {"port", If(Not String.IsNullOrEmpty(txtPort.Text), txtPort.Text, "3306")},
            {"username", txtUsername.Text},
            {"password", txtPassword.Text},
            {"save_password", cbSavePassword.Checked},
            {"database", txtDatabase.Text}
        })

        Dim configPath As String = System.IO.Path.Combine(Application.StartupPath, "db_config.ini")
        config.SaveConfig(configPath)
        MessageBox.Show("Configuration Saved!")
        Me.Close()
    End Sub

    Private Sub btTestConnectionExecute()
        Dim server As String = txtServerHost.Text
        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text
        Dim port As String = If(Not String.IsNullOrEmpty(txtPort.Text), txtPort.Text, "3306")
        Dim database As String = txtDatabase.Text

        TestConnection(server, port, username, password, database)
    End Sub

    Private Sub TestConnection(server As String, port As String, username As String, password As String, database As String)
        Dim myConnectionString As String
        myConnectionString = $"server={server};port={port};uid={username};pwd={password};database={database}"

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

    Private Sub setComponent(attributes As Dictionary(Of String, String))
        txtServerHost.Text = attributes("server")
        txtPort.Text = attributes("port")
        txtDatabase.Text = attributes("database")
        txtUsername.Text = attributes("username")
        txtPassword.Text = attributes("password")
        cbSavePassword.Checked = Boolean.Parse(attributes("save_password"))
    End Sub

End Class