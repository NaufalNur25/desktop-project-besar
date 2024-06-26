<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
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
        v = New Label()
        Label2 = New Label()
        TxtEmail = New TextBox()
        TxtPassword = New TextBox()
        Label1 = New Label()
        register = New Label()
        BtLogin = New Button()
        SuspendLayout()
        ' 
        ' v
        ' 
        v.AutoSize = True
        v.Location = New Point(62, 41)
        v.Name = "v"
        v.Size = New Size(46, 20)
        v.TabIndex = 0
        v.Text = "Email"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(62, 107)
        Label2.Name = "Label2"
        Label2.Size = New Size(70, 20)
        Label2.TabIndex = 1
        Label2.Text = "Password"
        ' 
        ' TxtEmail
        ' 
        TxtEmail.Location = New Point(62, 65)
        TxtEmail.Margin = New Padding(3, 4, 3, 4)
        TxtEmail.MaxLength = 255
        TxtEmail.Name = "TxtEmail"
        TxtEmail.Size = New Size(302, 27)
        TxtEmail.TabIndex = 2
        ' 
        ' TxtPassword
        ' 
        TxtPassword.Location = New Point(62, 131)
        TxtPassword.Margin = New Padding(3, 4, 3, 4)
        TxtPassword.Name = "TxtPassword"
        TxtPassword.PasswordChar = "*"c
        TxtPassword.Size = New Size(302, 27)
        TxtPassword.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(62, 212)
        Label1.Name = "Label1"
        Label1.Size = New Size(144, 20)
        Label1.TabIndex = 4
        Label1.Text = "Dont have account ?"
        ' 
        ' register
        ' 
        register.AutoSize = True
        register.ForeColor = SystemColors.HotTrack
        register.Location = New Point(200, 212)
        register.Name = "register"
        register.Size = New Size(63, 20)
        register.TabIndex = 6
        register.Text = "Register"
        ' 
        ' BtLogin
        ' 
        BtLogin.Location = New Point(62, 236)
        BtLogin.Margin = New Padding(3, 4, 3, 4)
        BtLogin.Name = "BtLogin"
        BtLogin.Size = New Size(302, 31)
        BtLogin.TabIndex = 7
        BtLogin.Text = "Login"
        BtLogin.UseVisualStyleBackColor = True
        ' 
        ' LoginForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(435, 308)
        Controls.Add(BtLogin)
        Controls.Add(register)
        Controls.Add(Label1)
        Controls.Add(TxtPassword)
        Controls.Add(TxtEmail)
        Controls.Add(Label2)
        Controls.Add(v)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Margin = New Padding(3, 4, 3, 4)
        MaximizeBox = False
        MinimizeBox = False
        Name = "LoginForm"
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents v As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtEmail As TextBox
    Friend WithEvents TxtPassword As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents register As Label
    Friend WithEvents BtLogin As Button
End Class
