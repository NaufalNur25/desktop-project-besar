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
        ListGameToolStripMenuItem = New ToolStripMenuItem()
        WishlistToolStripMenuItem = New ToolStripMenuItem()
        AdminToolStripMenuItem = New ToolStripMenuItem()
        EditToolStripMenuItem = New ToolStripMenuItem()
        navBackground = New Label()
        LabelDashboard = New Label()
        LabelUsername = New Label()
        BtLogout = New Button()
        PanelDashboard = New Panel()
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
        MenuStrip1.Size = New Size(956, 24)
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
        LibraryToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {GamesToolStripMenuItem, WishlistToolStripMenuItem})
        LibraryToolStripMenuItem.Name = "LibraryToolStripMenuItem"
        LibraryToolStripMenuItem.Size = New Size(55, 20)
        LibraryToolStripMenuItem.Text = "Library"
        ' 
        ' GamesToolStripMenuItem
        ' 
        GamesToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ListGameToolStripMenuItem})
        GamesToolStripMenuItem.Name = "GamesToolStripMenuItem"
        GamesToolStripMenuItem.Size = New Size(115, 22)
        GamesToolStripMenuItem.Text = "Games"
        ' 
        ' ListGameToolStripMenuItem
        ' 
        ListGameToolStripMenuItem.Name = "ListGameToolStripMenuItem"
        ListGameToolStripMenuItem.Size = New Size(131, 22)
        ListGameToolStripMenuItem.Text = "Game Lists"
        ' 
        ' WishlistToolStripMenuItem
        ' 
        WishlistToolStripMenuItem.Name = "WishlistToolStripMenuItem"
        WishlistToolStripMenuItem.Size = New Size(115, 22)
        WishlistToolStripMenuItem.Text = "Wishlist"
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
        EditToolStripMenuItem.Size = New Size(94, 22)
        EditToolStripMenuItem.Text = "Edit"
        ' 
        ' navBackground
        ' 
        navBackground.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        navBackground.BackColor = SystemColors.ControlLight
        navBackground.BorderStyle = BorderStyle.Fixed3D
        navBackground.ForeColor = SystemColors.ActiveCaptionText
        navBackground.Location = New Point(0, 21)
        navBackground.Name = "navBackground"
        navBackground.Size = New Size(956, 54)
        navBackground.TabIndex = 1
        ' 
        ' LabelDashboard
        ' 
        LabelDashboard.AutoSize = True
        LabelDashboard.BackColor = SystemColors.ControlLight
        LabelDashboard.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelDashboard.ForeColor = SystemColors.AppWorkspace
        LabelDashboard.Location = New Point(12, 32)
        LabelDashboard.Name = "LabelDashboard"
        LabelDashboard.Size = New Size(151, 30)
        LabelDashboard.TabIndex = 2
        LabelDashboard.Text = "Library Games"
        ' 
        ' LabelUsername
        ' 
        LabelUsername.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        LabelUsername.BackColor = SystemColors.ControlLight
        LabelUsername.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabelUsername.ImageAlign = ContentAlignment.TopLeft
        LabelUsername.Location = New Point(704, 32)
        LabelUsername.Name = "LabelUsername"
        LabelUsername.Size = New Size(134, 25)
        LabelUsername.TabIndex = 3
        LabelUsername.Text = "username"
        LabelUsername.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' BtLogout
        ' 
        BtLogout.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        BtLogout.AutoSize = True
        BtLogout.BackColor = SystemColors.Control
        BtLogout.Location = New Point(844, 32)
        BtLogout.Margin = New Padding(3, 2, 3, 2)
        BtLogout.Name = "BtLogout"
        BtLogout.Size = New Size(100, 29)
        BtLogout.TabIndex = 4
        BtLogout.Text = "Logout"
        BtLogout.UseVisualStyleBackColor = False
        ' 
        ' PanelDashboard
        ' 
        PanelDashboard.Location = New Point(1, 77)
        PanelDashboard.Margin = New Padding(3, 2, 3, 2)
        PanelDashboard.Name = "PanelDashboard"
        PanelDashboard.Size = New Size(955, 589)
        PanelDashboard.TabIndex = 5
        ' 
        ' DashbordForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(956, 665)
        Controls.Add(PanelDashboard)
        Controls.Add(BtLogout)
        Controls.Add(LabelUsername)
        Controls.Add(LabelDashboard)
        Controls.Add(navBackground)
        Controls.Add(MenuStrip1)
        FormBorderStyle = FormBorderStyle.FixedSingle
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
    Friend WithEvents ListGameToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdminToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WishlistToolStripMenuItem As ToolStripMenuItem

End Class
