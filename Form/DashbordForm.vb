
Imports MySql.Data.MySqlClient

Public Class DashbordForm
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        AddHandler MyBase.Load, AddressOf ToolStripMenuDatabaseCheck

        ' Database & Connetion
        AddHandler closeDatabaseMenuItem.Click, AddressOf ToolStripMenuCloseConnection

        ' Form
        AddHandler ConnectDatabaseToolStripMenuItem.Click, AddressOf OpenConnectDatabaseForm
    End Sub

    Private Sub ToolStripMenuDatabaseCheck()
        openConnection(False)

        If IsConnectionOpen() Then
            closeDatabaseMenuItem.Enabled = True
            generateMenuItem.Enabled = True
        End If
    End Sub

    Private Sub ToolStripMenuCloseConnection()
        closeConnection()
        deleteConfig()
    End Sub

    Private Sub OpenConnectDatabaseForm()
        Dim databaseConfigForm As New DatabaseConfigForm()

        databaseConfigForm.ShowDialog()
    End Sub
End Class
