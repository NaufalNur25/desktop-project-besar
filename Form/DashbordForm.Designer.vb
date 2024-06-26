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
        ExitToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 28)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ConnectionToolStripMenuItem, LoginToolStripMenuItem, ExitToolStripMenuItem})
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(46, 24)
        FileToolStripMenuItem.Text = "File"
        ' 
        ' ConnectionToolStripMenuItem
        ' 
        ConnectionToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ConnectDatabaseToolStripMenuItem, generateMenuItem, RefreshToolStripMenuItem})
        ConnectionToolStripMenuItem.Name = "ConnectionToolStripMenuItem"
        ConnectionToolStripMenuItem.Size = New Size(224, 26)
        ConnectionToolStripMenuItem.Text = "Connection"
        ' 
        ' ConnectDatabaseToolStripMenuItem
        ' 
        ConnectDatabaseToolStripMenuItem.Name = "ConnectDatabaseToolStripMenuItem"
        ConnectDatabaseToolStripMenuItem.Size = New Size(219, 26)
        ConnectDatabaseToolStripMenuItem.Text = "Connect Database"
        ' 
        ' generateMenuItem
        ' 
        generateMenuItem.Enabled = False
        generateMenuItem.Name = "generateMenuItem"
        generateMenuItem.Size = New Size(219, 26)
        generateMenuItem.Text = "Generate Database"
        ' 
        ' RefreshToolStripMenuItem
        ' 
        RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        RefreshToolStripMenuItem.Size = New Size(219, 26)
        RefreshToolStripMenuItem.Text = "Refresh"
        ' 
        ' LoginToolStripMenuItem
        ' 
        LoginToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {LoginToolStripMenu, RegisterToolStripMenu})
        LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        LoginToolStripMenuItem.Size = New Size(224, 26)
        LoginToolStripMenuItem.Text = "Login"
        ' 
        ' LoginToolStripMenu
        ' 
        LoginToolStripMenu.Name = "LoginToolStripMenu"
        LoginToolStripMenu.Size = New Size(224, 26)
        LoginToolStripMenu.Text = "Login"
        ' 
        ' RegisterToolStripMenu
        ' 
        RegisterToolStripMenu.Name = "RegisterToolStripMenu"
        RegisterToolStripMenu.Size = New Size(224, 26)
        RegisterToolStripMenu.Text = "Register"
        ' 
        ' ExitToolStripMenuItem
        ' 
        ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        ExitToolStripMenuItem.Size = New Size(224, 26)
        ExitToolStripMenuItem.Text = "Exit"
        ' 
        ' DashbordForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
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

End Class
