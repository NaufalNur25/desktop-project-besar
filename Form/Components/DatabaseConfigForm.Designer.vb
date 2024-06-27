<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DatabaseConfigForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DatabaseConfigForm))
        Label1 = New Label()
        Label2 = New Label()
        Label4 = New Label()
        GroupBox1 = New GroupBox()
        txtPort = New TextBox()
        txtDatabase = New TextBox()
        txtServerHost = New TextBox()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        GroupBox2 = New GroupBox()
        cbSavePassword = New CheckBox()
        txtPassword = New TextBox()
        txtUsername = New TextBox()
        Label9 = New Label()
        Label8 = New Label()
        Label3 = New Label()
        Label10 = New Label()
        btTestConnection = New Button()
        btFinish = New Button()
        btCancel = New Button()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(196, 28)
        Label1.TabIndex = 0
        Label1.Text = "Connection Settings"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(37, 44)
        Label2.Name = "Label2"
        Label2.Size = New Size(187, 20)
        Label2.TabIndex = 1
        Label2.Text = "MySQL connection settings"
        ' 
        ' Label4
        ' 
        Label4.Image = CType(resources.GetObject("Label4.Image"), Image)
        Label4.Location = New Point(900, 9)
        Label4.Name = "Label4"
        Label4.Size = New Size(70, 70)
        Label4.TabIndex = 3
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(txtPort)
        GroupBox1.Controls.Add(txtDatabase)
        GroupBox1.Controls.Add(txtServerHost)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Location = New Point(12, 107)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(958, 124)
        GroupBox1.TabIndex = 4
        GroupBox1.TabStop = False
        GroupBox1.Text = "Server"
        ' 
        ' txtPort
        ' 
        txtPort.Location = New Point(857, 77)
        txtPort.MaxLength = 6
        txtPort.Name = "txtPort"
        txtPort.Size = New Size(87, 27)
        txtPort.TabIndex = 11
        txtPort.Text = "3306"
        ' 
        ' txtDatabase
        ' 
        txtDatabase.Location = New Point(100, 77)
        txtDatabase.Name = "txtDatabase"
        txtDatabase.Size = New Size(707, 27)
        txtDatabase.TabIndex = 10
        ' 
        ' txtServerHost
        ' 
        txtServerHost.Location = New Point(100, 34)
        txtServerHost.Name = "txtServerHost"
        txtServerHost.Size = New Size(844, 27)
        txtServerHost.TabIndex = 9
        txtServerHost.Text = "localhost"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(813, 80)
        Label7.Name = "Label7"
        Label7.Size = New Size(38, 20)
        Label7.TabIndex = 8
        Label7.Text = "Port:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(6, 80)
        Label6.Name = "Label6"
        Label6.Size = New Size(75, 20)
        Label6.TabIndex = 7
        Label6.Text = "Database:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(6, 37)
        Label5.Name = "Label5"
        Label5.Size = New Size(88, 20)
        Label5.TabIndex = 6
        Label5.Text = "Server Host:"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(cbSavePassword)
        GroupBox2.Controls.Add(txtPassword)
        GroupBox2.Controls.Add(txtUsername)
        GroupBox2.Controls.Add(Label9)
        GroupBox2.Controls.Add(Label8)
        GroupBox2.Location = New Point(12, 237)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(958, 119)
        GroupBox2.TabIndex = 5
        GroupBox2.TabStop = False
        GroupBox2.Text = "Authentication (Database Native)"
        ' 
        ' cbSavePassword
        ' 
        cbSavePassword.AutoSize = True
        cbSavePassword.Location = New Point(330, 76)
        cbSavePassword.Name = "cbSavePassword"
        cbSavePassword.Size = New Size(129, 24)
        cbSavePassword.TabIndex = 4
        cbSavePassword.Text = "Save password"
        cbSavePassword.UseVisualStyleBackColor = True
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(100, 74)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.Size = New Size(224, 27)
        txtPassword.TabIndex = 3
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(100, 31)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(224, 27)
        txtUsername.TabIndex = 2
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(6, 77)
        Label9.Name = "Label9"
        Label9.Size = New Size(73, 20)
        Label9.TabIndex = 1
        Label9.Text = "Password:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(6, 34)
        Label8.Name = "Label8"
        Label8.Size = New Size(78, 20)
        Label8.TabIndex = 0
        Label8.Text = "Username:"
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        Label3.BackColor = SystemColors.ButtonShadow
        Label3.ForeColor = Color.Transparent
        Label3.Location = New Point(0, 90)
        Label3.Name = "Label3"
        Label3.Size = New Size(982, 2)
        Label3.TabIndex = 6
        ' 
        ' Label10
        ' 
        Label10.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        Label10.BackColor = SystemColors.ButtonShadow
        Label10.ForeColor = Color.Transparent
        Label10.Location = New Point(0, 432)
        Label10.Name = "Label10"
        Label10.Size = New Size(982, 2)
        Label10.TabIndex = 7
        ' 
        ' btTestConnection
        ' 
        btTestConnection.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        btTestConnection.Location = New Point(12, 454)
        btTestConnection.Name = "btTestConnection"
        btTestConnection.Size = New Size(152, 35)
        btTestConnection.TabIndex = 8
        btTestConnection.Text = "Test Connection ..."
        btTestConnection.UseVisualStyleBackColor = True
        ' 
        ' btFinish
        ' 
        btFinish.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        btFinish.Location = New Point(762, 454)
        btFinish.Name = "btFinish"
        btFinish.Size = New Size(101, 35)
        btFinish.TabIndex = 9
        btFinish.Text = "Finish"
        btFinish.UseVisualStyleBackColor = True
        ' 
        ' btCancel
        ' 
        btCancel.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        btCancel.Location = New Point(869, 454)
        btCancel.Name = "btCancel"
        btCancel.Size = New Size(101, 35)
        btCancel.TabIndex = 10
        btCancel.Text = "Cancel"
        btCancel.UseVisualStyleBackColor = True
        ' 
        ' DatabaseConfigForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        AutoValidate = AutoValidate.Disable
        BackColor = SystemColors.Window
        BackgroundImageLayout = ImageLayout.None
        ClientSize = New Size(982, 501)
        Controls.Add(btCancel)
        Controls.Add(btFinish)
        Controls.Add(btTestConnection)
        Controls.Add(Label10)
        Controls.Add(Label3)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(Label4)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        MinimizeBox = False
        Name = "DatabaseConfigForm"
        ShowIcon = False
        Text = "Connect to a database"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtPort As TextBox
    Friend WithEvents txtDatabase As TextBox
    Friend WithEvents txtServerHost As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cbSavePassword As CheckBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents btTestConnection As Button
    Friend WithEvents btFinish As Button
    Friend WithEvents btCancel As Button
End Class
