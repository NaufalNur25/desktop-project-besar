
Imports MySql.Data.MySqlClient

Public Class DashbordForm
    Dim isConnect As Boolean = False


    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        AddHandler MyBase.Load, AddressOf dashbordForm

        ' Database & Connetion
        AddHandler generateMenuItem.Click, AddressOf ToolStripMenuGenerateDatabase
        AddHandler RefreshToolStripMenuItem.Click, AddressOf RefreshMenu

        ' Form
        AddHandler ConnectDatabaseToolStripMenuItem.Click, AddressOf OpenConnectDatabaseForm
        AddHandler ExitToolStripMenuItem.Click, AddressOf ExitApp
    End Sub

    Private Sub dashbordForm()
        Call databaseCheck()
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
        generateMenuItem.Enabled = isEnable
    End Sub

    Private Sub OpenConnectDatabaseForm()
        Dim databaseConfigForm As New DatabaseConfigForm()

        databaseConfigForm.ShowDialog()
    End Sub

    Private Sub ExitApp()
        Me.Close()
    End Sub

    Private Sub RefreshMenu()
        Call databaseCheck()
    End Sub
End Class
