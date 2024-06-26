<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegisterForm
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
        Label1 = New Label()
        UsernameLabel = New TextBox()
        EmailLabel = New TextBox()
        Label2 = New Label()
        PasswordLabel = New TextBox()
        Label3 = New Label()
        RegisterButton = New Button()
        TextBox1 = New TextBox()
        Label4 = New Label()
        login = New Label()
        Label5 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(71, 53)
        Label1.Name = "Label1"
        Label1.Size = New Size(69, 20)
        Label1.TabIndex = 0
        Label1.Text = "Fullname"
        ' 
        ' UsernameLabel
        ' 
        UsernameLabel.Location = New Point(71, 77)
        UsernameLabel.Margin = New Padding(3, 4, 3, 4)
        UsernameLabel.Name = "UsernameLabel"
        UsernameLabel.Size = New Size(364, 27)
        UsernameLabel.TabIndex = 1
        ' 
        ' EmailLabel
        ' 
        EmailLabel.Location = New Point(71, 136)
        EmailLabel.Margin = New Padding(3, 4, 3, 4)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New Size(364, 27)
        EmailLabel.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(71, 113)
        Label2.Name = "Label2"
        Label2.Size = New Size(46, 20)
        Label2.TabIndex = 2
        Label2.Text = "Email"
        ' 
        ' PasswordLabel
        ' 
        PasswordLabel.Location = New Point(71, 196)
        PasswordLabel.Margin = New Padding(3, 4, 3, 4)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.PasswordChar = "*"c
        PasswordLabel.Size = New Size(364, 27)
        PasswordLabel.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(71, 172)
        Label3.Name = "Label3"
        Label3.Size = New Size(70, 20)
        Label3.TabIndex = 4
        Label3.Text = "Password"
        ' 
        ' RegisterButton
        ' 
        RegisterButton.Location = New Point(71, 336)
        RegisterButton.Margin = New Padding(3, 4, 3, 4)
        RegisterButton.Name = "RegisterButton"
        RegisterButton.Size = New Size(364, 31)
        RegisterButton.TabIndex = 6
        RegisterButton.Text = "Register"
        RegisterButton.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(71, 256)
        TextBox1.Margin = New Padding(3, 4, 3, 4)
        TextBox1.Name = "TextBox1"
        TextBox1.PasswordChar = "*"c
        TextBox1.Size = New Size(364, 27)
        TextBox1.TabIndex = 8
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(71, 232)
        Label4.Name = "Label4"
        Label4.Size = New Size(145, 20)
        Label4.TabIndex = 7
        Label4.Text = "Konfirmasi Password"
        ' 
        ' login
        ' 
        login.AutoSize = True
        login.ForeColor = SystemColors.HotTrack
        login.Location = New Point(251, 312)
        login.Name = "login"
        login.Size = New Size(46, 20)
        login.TabIndex = 10
        login.Text = "Login"
        login.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(73, 312)
        Label5.Name = "Label5"
        Label5.Size = New Size(182, 20)
        Label5.TabIndex = 9
        Label5.Text = "Already have an account ?"
        ' 
        ' RegisterForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        ClientSize = New Size(507, 421)
        Controls.Add(login)
        Controls.Add(Label5)
        Controls.Add(TextBox1)
        Controls.Add(Label4)
        Controls.Add(RegisterButton)
        Controls.Add(PasswordLabel)
        Controls.Add(Label3)
        Controls.Add(EmailLabel)
        Controls.Add(Label2)
        Controls.Add(UsernameLabel)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Margin = New Padding(3, 4, 3, 4)
        MaximizeBox = False
        MinimizeBox = False
        Name = "RegisterForm"
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "Register"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents UsernameLabel As TextBox
    Friend WithEvents EmailLabel As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PasswordLabel As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents RegisterButton As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents login As Label
    Friend WithEvents Label5 As Label
End Class
