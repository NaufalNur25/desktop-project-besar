<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLogin
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
        v = New Label()
        Label2 = New Label()
        UsernameLabel = New TextBox()
        PasswordLabel = New TextBox()
        Label1 = New Label()
        LoginButton = New Button()
        register = New Label()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' v
        ' 
        v.AutoSize = True
        v.Location = New Point(52, 55)
        v.Name = "v"
        v.Size = New Size(39, 15)
        v.TabIndex = 0
        v.Text = "Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(52, 98)
        Label2.Name = "Label2"
        Label2.Size = New Size(57, 15)
        Label2.TabIndex = 1
        Label2.Text = "Password"
        ' 
        ' UsernameLabel
        ' 
        UsernameLabel.Location = New Point(145, 55)
        UsernameLabel.Name = "UsernameLabel"
        UsernameLabel.Size = New Size(137, 23)
        UsernameLabel.TabIndex = 2
        ' 
        ' PasswordLabel
        ' 
        PasswordLabel.Location = New Point(145, 90)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.PasswordChar = "*"c
        PasswordLabel.Size = New Size(137, 23)
        PasswordLabel.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(52, 138)
        Label1.Name = "Label1"
        Label1.Size = New Size(115, 15)
        Label1.TabIndex = 4
        Label1.Text = "Dont have account ?"
        ' 
        ' LoginButton
        ' 
        LoginButton.Location = New Point(157, 175)
        LoginButton.Name = "LoginButton"
        LoginButton.Size = New Size(75, 23)
        LoginButton.TabIndex = 5
        LoginButton.Text = "Login"
        LoginButton.UseVisualStyleBackColor = True
        ' 
        ' register
        ' 
        register.AutoSize = True
        register.ForeColor = SystemColors.HotTrack
        register.Location = New Point(173, 138)
        register.Name = "register"
        register.Size = New Size(49, 15)
        register.TabIndex = 6
        register.Text = "Register"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(65, 175)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 7
        Button1.Text = "Login"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' FormLogin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(324, 272)
        Controls.Add(Button1)
        Controls.Add(register)
        Controls.Add(LoginButton)
        Controls.Add(Label1)
        Controls.Add(PasswordLabel)
        Controls.Add(UsernameLabel)
        Controls.Add(Label2)
        Controls.Add(v)
        Name = "FormLogin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents v As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents UsernameLabel As TextBox
    Friend WithEvents PasswordLabel As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LoginButton As Button
    Friend WithEvents register As Label
    Friend WithEvents Button1 As Button
End Class
