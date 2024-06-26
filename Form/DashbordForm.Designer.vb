<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DashbordForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        MenuStrip1 = New MenuStrip()
        FileToolStripMenuItem = New ToolStripMenuItem()
        ConnectionToolStripMenuItem = New ToolStripMenuItem()
        ConnectDatabaseToolStripMenuItem = New ToolStripMenuItem()
        generateMenuItem = New ToolStripMenuItem()
        RefreshToolStripMenuItem = New ToolStripMenuItem()
        LoginToolStripMenuItem = New ToolStripMenuItem()
        LoginToolStripMenu = New ToolStripMenuItem()
        RegisterToolStripMenu = New ToolStripMenuItem()
        RefreshForm = New ToolStripMenuItem()
        ExitToolStripMenuItem = New ToolStripMenuItem()
        LibraryToolStripMenuItem = New ToolStripMenuItem()
        GamesToolStripMenuItem = New ToolStripMenuItem()
        PublishNewGameToolStripMenuItem = New ToolStripMenuItem()
        ListGameToolStripMenuItem = New ToolStripMenuItem()
        navBackground = New Label()
        LabelDashboard = New Label()
        LabelUsername = New Label()
        BtLogout = New Button()
        PanelDashboard = New Panel()
        AdminToolStripMenuItem = New ToolStripMenuItem()
        EditToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem, LibraryToolStripMenuItem, AdminToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Padding = New Padding(5, 2, 0, 2)
        MenuStrip1.Size = New Size(748, 24)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ConnectionToolStripMenuItem, LoginToolStripMenuItem, RefreshForm, ExitToolStripMenuItem})
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(37, 20)
        FileToolStripMenuItem.Text = "File"
        ' 
        ' ConnectionToolStripMenuItem
        ' 
        ConnectionToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ConnectDatabaseToolStripMenuItem, generateMenuItem, RefreshToolStripMenuItem})
        ConnectionToolStripMenuItem.Name = "ConnectionToolStripMenuItem"
        ConnectionToolStripMenuItem.Size = New Size(136, 22)
        ConnectionToolStripMenuItem.Text = "Connection"
        ' 
        ' ConnectDatabaseToolStripMenuItem
        ' 
        ConnectDatabaseToolStripMenuItem.Name = "ConnectDatabaseToolStripMenuItem"
        ConnectDatabaseToolStripMenuItem.Size = New Size(172, 22)
        ConnectDatabaseToolStripMenuItem.Text = "Connect Database"
        ' 
        ' generateMenuItem
        ' 
        generateMenuItem.Enabled = False
        generateMenuItem.Name = "generateMenuItem"
        generateMenuItem.Size = New Size(172, 22)
        generateMenuItem.Text = "Generate Database"
        ' 
        ' RefreshToolStripMenuItem
        ' 
        RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        RefreshToolStripMenuItem.Size = New Size(172, 22)
        RefreshToolStripMenuItem.Text = "Refresh"
        ' 
        ' LoginToolStripMenuItem
        ' 
        LoginToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {LoginToolStripMenu, RegisterToolStripMenu})
        LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        LoginToolStripMenuItem.Size = New Size(136, 22)
        LoginToolStripMenuItem.Text = "Login"
        ' 
        ' LoginToolStripMenu
        ' 
        LoginToolStripMenu.Name = "LoginToolStripMenu"
        LoginToolStripMenu.Size = New Size(116, 22)
        LoginToolStripMenu.Text = "Login"
        ' 
        ' RegisterToolStripMenu
        ' 
        RegisterToolStripMenu.Name = "RegisterToolStripMenu"
        RegisterToolStripMenu.Size = New Size(116, 22)
        RegisterToolStripMenu.Text = "Register"
        ' 
        ' RefreshForm
        ' 
        RefreshForm.Name = "RefreshForm"
        RefreshForm.Size = New Size(136, 22)
        RefreshForm.Text = "Refresh"
        ' 
        ' ExitToolStripMenuItem
        ' 
        ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        ExitToolStripMenuItem.Size = New Size(136, 22)
        ExitToolStripMenuItem.Text = "Exit"
        ' 
        ' LibraryToolStripMenuItem
        ' 
        LibraryToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {GamesToolStripMenuItem})
        LibraryToolStripMenuItem.Name = "LibraryToolStripMenuItem"
        LibraryToolStripMenuItem.Size = New Size(55, 20)
        LibraryToolStripMenuItem.Text = "Master"
        ' 
        ' GamesToolStripMenuItem
        ' 
        GamesToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {PublishNewGameToolStripMenuItem, ListGameToolStripMenuItem})
        GamesToolStripMenuItem.Name = "GamesToolStripMenuItem"
        GamesToolStripMenuItem.Size = New Size(180, 22)
        GamesToolStripMenuItem.Text = "Games"
        ' 
        ' PublishNewGameToolStripMenuItem
        ' 
        PublishNewGameToolStripMenuItem.Name = "PublishNewGameToolStripMenuItem"
        PublishNewGameToolStripMenuItem.Size = New Size(171, 22)
        PublishNewGameToolStripMenuItem.Text = "Publish new game"
        ' 
        ' ListGameToolStripMenuItem
        ' 
        ListGameToolStripMenuItem.Name = "ListGameToolStripMenuItem"
        ListGameToolStripMenuItem.Size = New Size(171, 22)
        ListGameToolStripMenuItem.Text = "Game Lists"
        ' 
        ' navBackground
        ' 
        navBackground.BackColor = SystemColors.ControlLight
        navBackground.BorderStyle = BorderStyle.Fixed3D
        navBackground.ForeColor = SystemColors.ActiveCaptionText
        navBackground.Location = New Point(0, 21)
        navBackground.Name = "navBackground"
        navBackground.Size = New Size(751, 40)
        navBackground.TabIndex = 1
        ' 
        ' LabelDashboard
        ' 
        LabelDashboard.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        LabelDashboard.AutoSize = True
        LabelDashboard.BackColor = SystemColors.ControlLight
        LabelDashboard.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabelDashboard.Location = New Point(4, 29)
        LabelDashboard.Name = "LabelDashboard"
        LabelDashboard.Size = New Size(86, 21)
        LabelDashboard.TabIndex = 2
        LabelDashboard.Text = "Dashboard"
        ' 
        ' LabelUsername
        ' 
        LabelUsername.BackColor = SystemColors.ControlLight
        LabelUsername.ImageAlign = ContentAlignment.MiddleRight
        LabelUsername.Location = New Point(492, 32)
        LabelUsername.Name = "LabelUsername"
        LabelUsername.Size = New Size(134, 15)
        LabelUsername.TabIndex = 3
        LabelUsername.Text = "username"
        LabelUsername.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' BtLogout
        ' 
        BtLogout.BackColor = SystemColors.Control
        BtLogout.Location = New Point(631, 28)
        BtLogout.Margin = New Padding(3, 2, 3, 2)
        BtLogout.Name = "BtLogout"
        BtLogout.Size = New Size(100, 22)
        BtLogout.TabIndex = 4
        BtLogout.Text = "Logout"
        BtLogout.UseVisualStyleBackColor = False
        ' 
        ' PanelDashboard
        ' 
        PanelDashboard.Location = New Point(0, 57)
        PanelDashboard.Margin = New Padding(3, 2, 3, 2)
        PanelDashboard.Name = "PanelDashboard"
        PanelDashboard.Size = New Size(751, 365)
        PanelDashboard.TabIndex = 5
        ' 
        ' AdminToolStripMenuItem
        ' 
        AdminToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {EditToolStripMenuItem})
        AdminToolStripMenuItem.Name = "AdminToolStripMenuItem"
        AdminToolStripMenuItem.Size = New Size(55, 20)
        AdminToolStripMenuItem.Text = "Admin"
        ' 
        ' EditToolStripMenuItem
        ' 
        EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        EditToolStripMenuItem.Size = New Size(180, 22)
        EditToolStripMenuItem.Text = "Edit"
        ' 
        ' DashbordForm
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(748, 422)
        Controls.Add(PanelDashboard)
        Controls.Add(BtLogout)
        Controls.Add(LabelUsername)
        Controls.Add(LabelDashboard)
        Controls.Add(navBackground)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Margin = New Padding(3, 2, 3, 2)
        Name = "DashbordForm"
        Text = "Games Library"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConnectionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConnectDatabaseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents generateMenuItem As ToolStripMenuItem
    Friend WithEvents RefreshToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoginToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoginToolStripMenu As ToolStripMenuItem
    Friend WithEvents RegisterToolStripMenu As ToolStripMenuItem
    Friend WithEvents navBackground As Label
    Friend WithEvents LabelDashboard As Label
    Friend WithEvents LabelUsername As Label
    Friend WithEvents BtLogout As Button
    Friend WithEvents RefreshForm As ToolStripMenuItem
    Friend WithEvents LibraryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PanelDashboard As Panel
    Friend WithEvents GamesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PublishNewGameToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListGameToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdminToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem

End Class
