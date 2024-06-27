<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminForm
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
        dgvUsers = New DataGridView()
        btnRefresh = New Button()
        btnAdd = New Button()
        btnEdit = New Button()
        btnDelete = New Button()
        txtRole = New ComboBox()
        txtEmail = New TextBox()
        txtUsername = New TextBox()
        Id = New Label()
        txtId = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        txtPassword = New TextBox()
        Label2 = New Label()
        CType(dgvUsers, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvUsers
        ' 
        dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvUsers.Location = New Point(35, 173)
        dgvUsers.Name = "dgvUsers"
        dgvUsers.RowHeadersWidth = 51
        dgvUsers.Size = New Size(486, 150)
        dgvUsers.TabIndex = 1
        ' 
        ' btnRefresh
        ' 
        btnRefresh.Location = New Point(35, 347)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(75, 23)
        btnRefresh.TabIndex = 2
        btnRefresh.Text = "refresh"
        btnRefresh.UseVisualStyleBackColor = True
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(175, 347)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(75, 23)
        btnAdd.TabIndex = 3
        btnAdd.Text = "add"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btnEdit
        ' 
        btnEdit.Location = New Point(316, 347)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(75, 23)
        btnEdit.TabIndex = 4
        btnEdit.Text = "edit"
        btnEdit.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(446, 347)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(75, 23)
        btnDelete.TabIndex = 5
        btnDelete.Text = "hapus"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' txtRole
        ' 
        txtRole.FormattingEnabled = True
        txtRole.Items.AddRange(New Object() {"USER", "ADMIN"})
        txtRole.Location = New Point(150, 139)
        txtRole.Name = "txtRole"
        txtRole.Size = New Size(146, 23)
        txtRole.TabIndex = 8
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(150, 81)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(146, 23)
        txtEmail.TabIndex = 7
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(150, 52)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(146, 23)
        txtUsername.TabIndex = 6
        ' 
        ' Id
        ' 
        Id.BorderStyle = BorderStyle.Fixed3D
        Id.Font = New Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Id.Location = New Point(38, 26)
        Id.Name = "Id"
        Id.Size = New Size(96, 21)
        Id.TabIndex = 15
        Id.Text = "ID"
        ' 
        ' txtId
        ' 
        txtId.Location = New Point(150, 24)
        txtId.Name = "txtId"
        txtId.Size = New Size(25, 23)
        txtId.TabIndex = 16
        ' 
        ' Label3
        ' 
        Label3.BorderStyle = BorderStyle.Fixed3D
        Label3.Font = New Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(38, 83)
        Label3.Name = "Label3"
        Label3.Size = New Size(96, 21)
        Label3.TabIndex = 19
        Label3.Text = "Email"
        ' 
        ' Label4
        ' 
        Label4.BorderStyle = BorderStyle.Fixed3D
        Label4.Font = New Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(38, 54)
        Label4.Name = "Label4"
        Label4.Size = New Size(96, 21)
        Label4.TabIndex = 20
        Label4.Text = "Username"
        ' 
        ' Label5
        ' 
        Label5.BorderStyle = BorderStyle.Fixed3D
        Label5.Font = New Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(38, 141)
        Label5.Name = "Label5"
        Label5.Size = New Size(96, 21)
        Label5.TabIndex = 21
        Label5.Text = "Role"
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(150, 110)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.Size = New Size(146, 23)
        txtPassword.TabIndex = 10
        ' 
        ' Label2
        ' 
        Label2.BorderStyle = BorderStyle.Fixed3D
        Label2.Font = New Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(38, 112)
        Label2.Name = "Label2"
        Label2.Size = New Size(96, 21)
        Label2.TabIndex = 18
        Label2.Text = "Password"
        ' 
        ' AdminForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(548, 450)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(txtId)
        Controls.Add(Id)
        Controls.Add(txtPassword)
        Controls.Add(txtRole)
        Controls.Add(txtEmail)
        Controls.Add(txtUsername)
        Controls.Add(btnDelete)
        Controls.Add(btnEdit)
        Controls.Add(btnAdd)
        Controls.Add(btnRefresh)
        Controls.Add(dgvUsers)
        Name = "AdminForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "AdminForm"
        CType(dgvUsers, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents dgvUsers As DataGridView
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents txtRole As ComboBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Id As Label
    Friend WithEvents txtId As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label2 As Label
End Class
