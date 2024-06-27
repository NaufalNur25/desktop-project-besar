Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class DashbordForm
    Dim isConnect As Boolean = False


    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        AddHandler MyBase.Load, AddressOf dashbordForm
        AddHandler BtLogout.Click, AddressOf Logout
        AddHandler RefreshForm.Click, AddressOf RefreshDashboard

        ' Database & Connetion
        AddHandler generateMenuItem.Click, AddressOf ToolStripMenuGenerateDatabase
        AddHandler RefreshToolStripMenuItem.Click, AddressOf RefreshMenu

        ' Form
        AddHandler ConnectDatabaseToolStripMenuItem.Click, AddressOf OpenConnectDatabaseForm
        AddHandler LoginToolStripMenu.Click, AddressOf LoginDialog
        AddHandler RegisterToolStripMenu.Click, AddressOf RegisterDialog
        AddHandler ExitToolStripMenuItem.Click, AddressOf ExitApp
        AddHandler EditToolStripMenuItem.Click, AddressOf AdminFormDialog
    End Sub

    Public Sub dashbordForm()
        Call databaseCheck()

        ' Dashboard Rule
        Call databaseCheck()
        Call usernameCheck()
    End Sub

    Private Sub databaseCheck()
        OpenConnection(False)

        If IsConnectionOpen() Then
            ToolStripMenuDatabaseRule()
            Return
        End If

        ToolStripMenuDatabaseRule(False)
    End Sub

    Public Sub usernameCheck()
        Dim sessionConfig As New SessionConfig()
        Dim username As String = sessionConfig.getSession("username")

        If username IsNot Nothing Then
            LabelUsername.Text = username
            BtLogout.Enabled = True
            LoginToolStripMenuItem.Visible = False
        Else
            LabelUsername.Text = ""
            BtLogout.Enabled = False
            LoginToolStripMenuItem.Visible = True
        End If
    End Sub

    Private Sub ToolStripMenuCloseConnection()
        CloseConnection()
        DeleteConfig()

        Call databaseCheck()
    End Sub

    Private Sub ToolStripMenuGenerateDatabase()
        OpenConnection()
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

    Private Sub LoginDialog()
        Dim loginForm As New LoginForm()
        Me.Hide()
        loginForm.ShowDialog()
    End Sub

    Private Sub RegisterDialog()
        Dim registerForm As New RegisterForm()

        registerForm.ShowDialog()
    End Sub
    Private Sub Logout()
        Dim sessionConfig As New SessionConfig()
        sessionConfig.removeSession("username")
        sessionConfig.SaveConfig()

        MessageBox.Show("Successfully logged out", "Logout", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.dashbordForm()
    End Sub

    Private Sub RefreshMenu()
        Call databaseCheck()
    End Sub

    Private Sub RefreshDashboard()
        Call dashbordForm()
    End Sub

    Sub childform(ByVal panel As Form)
        PanelDashboard.Controls.Clear()
        panel.TopLevel = False
        panel.FormBorderStyle = FormBorderStyle.None
        panel.Dock = DockStyle.Fill
        PanelDashboard.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub AdminFormDialog()
        Dim adminForm As New AdminForm
        adminForm.ShowDialog()


    End Sub

    Private Sub ListGameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListGameToolStripMenuItem.Click
        childform(GamesForm)
    End Sub

    Private Sub PublishNewGameToolStripMenuItem_Click(sender As Object, e As EventArgs)
        childform(PublishNewGameForm)
    End Sub

    Private Sub WishlistToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WishlistToolStripMenuItem.Click
        childform(WishlistForm)
    End Sub
End Class
