
Imports MySql.Data.MySqlClient

Public Class DashbordForm
    Dim isConnect As Boolean = False

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        AddHandler MyBase.Load, AddressOf dashbordForm

        ' Database & Connetion
        AddHandler closeDatabaseMenuItem.Click, AddressOf ToolStripMenuCloseConnection
        AddHandler generateMenuItem.Click, AddressOf ToolStripMenuGenerateDatabase
        AddHandler FileToolStripMenuItem.Click, AddressOf databaseCheck

        ' Form
        AddHandler ConnectDatabaseToolStripMenuItem.Click, AddressOf OpenConnectDatabaseForm
        AddHandler ExitToolStripMenuItem.Click, AddressOf ExitApp
    End Sub

    Private Sub dashbordForm()
        ' todo
    End Sub

    Private Sub databaseCheck()
        openConnection(False)

        If IsConnectionOpen() Then
            ToolStripMenuDatabaseRule()
            Return
        End If

        ToolStripMenuDatabaseRule(False)
    End Sub

    Private Sub ToolStripMenuCloseConnection()
        closeConnection()
        deleteConfig()

        Call databaseCheck()
    End Sub

    Private Sub ToolStripMenuGenerateDatabase()
        openConnection()
        CreateTables()
    End Sub

    Private Sub ToolStripMenuDatabaseRule(Optional isEnable As Boolean = True)
        closeDatabaseMenuItem.Enabled = isEnable
        generateMenuItem.Enabled = isEnable
    End Sub

    Private Sub OpenConnectDatabaseForm()
        Dim databaseConfigForm As New DatabaseConfigForm()

        databaseConfigForm.ShowDialog()
    End Sub

    Private Sub ExitApp()
        Me.Close()
    End Sub
End Class
