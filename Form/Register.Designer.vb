<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Register
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
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(77, 57)
        Label1.Name = "Label1"
        Label1.Size = New Size(60, 15)
        Label1.TabIndex = 0
        Label1.Text = "Username"
        ' 
        ' UsernameLabel
        ' 
        UsernameLabel.Location = New Point(157, 54)
        UsernameLabel.Name = "UsernameLabel"
        UsernameLabel.Size = New Size(129, 23)
        UsernameLabel.TabIndex = 1
        ' 
        ' EmailLabel
        ' 
        EmailLabel.Location = New Point(157, 83)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New Size(129, 23)
        EmailLabel.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(77, 86)
        Label2.Name = "Label2"
        Label2.Size = New Size(36, 15)
        Label2.TabIndex = 2
        Label2.Text = "Email"
        ' 
        ' PasswordLabel
        ' 
        PasswordLabel.Location = New Point(157, 112)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.PasswordChar = "*"c
        PasswordLabel.Size = New Size(129, 23)
        PasswordLabel.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(77, 115)
        Label3.Name = "Label3"
        Label3.Size = New Size(57, 15)
        Label3.TabIndex = 4
        Label3.Text = "Password"
        ' 
        ' RegisterButton
        ' 
        RegisterButton.Location = New Point(157, 188)
        RegisterButton.Name = "RegisterButton"
        RegisterButton.Size = New Size(75, 23)
        RegisterButton.TabIndex = 6
        RegisterButton.Text = "Register"
        RegisterButton.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(157, 141)
        TextBox1.Name = "TextBox1"
        TextBox1.PasswordChar = "*"c
        TextBox1.Size = New Size(129, 23)
        TextBox1.TabIndex = 8
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(77, 144)
        Label4.Name = "Label4"
        Label4.Size = New Size(57, 15)
        Label4.TabIndex = 7
        Label4.Text = "Password"
        ' 
        ' Register
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(347, 244)
        Controls.Add(TextBox1)
        Controls.Add(Label4)
        Controls.Add(RegisterButton)
        Controls.Add(PasswordLabel)
        Controls.Add(Label3)
        Controls.Add(EmailLabel)
        Controls.Add(Label2)
        Controls.Add(UsernameLabel)
        Controls.Add(Label1)
        Name = "Register"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FormRegister"
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
End Class
