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
        dgvUsers.Location = New Point(40, 231)
        dgvUsers.Margin = New Padding(3, 4, 3, 4)
        dgvUsers.Name = "dgvUsers"
        dgvUsers.RowHeadersWidth = 51
        dgvUsers.Size = New Size(555, 200)
        dgvUsers.TabIndex = 1
        ' 
        ' btnRefresh
        ' 
        btnRefresh.Location = New Point(40, 463)
        btnRefresh.Margin = New Padding(3, 4, 3, 4)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(86, 31)
        btnRefresh.TabIndex = 2
        btnRefresh.Text = "refresh"
        btnRefresh.UseVisualStyleBackColor = True
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(200, 463)
        btnAdd.Margin = New Padding(3, 4, 3, 4)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(86, 31)
        btnAdd.TabIndex = 3
        btnAdd.Text = "add"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btnEdit
        ' 
        btnEdit.Location = New Point(361, 463)
        btnEdit.Margin = New Padding(3, 4, 3, 4)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(86, 31)
        btnEdit.TabIndex = 4
        btnEdit.Text = "edit"
        btnEdit.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(510, 463)
        btnDelete.Margin = New Padding(3, 4, 3, 4)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(86, 31)
        btnDelete.TabIndex = 5
        btnDelete.Text = "hapus"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' txtRole
        ' 
        txtRole.FormattingEnabled = True
        txtRole.Location = New Point(171, 185)
        txtRole.Margin = New Padding(3, 4, 3, 4)
        txtRole.Name = "txtRole"
        txtRole.Size = New Size(166, 28)
        txtRole.TabIndex = 8
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(171, 108)
        txtEmail.Margin = New Padding(3, 4, 3, 4)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(166, 27)
        txtEmail.TabIndex = 7
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(171, 69)
        txtUsername.Margin = New Padding(3, 4, 3, 4)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(166, 27)
        txtUsername.TabIndex = 6
        ' 
        ' Id
        ' 
        Id.BorderStyle = BorderStyle.Fixed3D
        Id.Font = New Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Id.Location = New Point(43, 35)
        Id.Name = "Id"
        Id.Size = New Size(110, 28)
        Id.TabIndex = 15
        Id.Text = "ID"
        ' 
        ' txtId
        ' 
        txtId.Location = New Point(171, 32)
        txtId.Margin = New Padding(3, 4, 3, 4)
        txtId.Name = "txtId"
        txtId.Size = New Size(28, 27)
        txtId.TabIndex = 16
        ' 
        ' Label3
        ' 
        Label3.BorderStyle = BorderStyle.Fixed3D
        Label3.Font = New Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(43, 111)
        Label3.Name = "Label3"
        Label3.Size = New Size(110, 28)
        Label3.TabIndex = 19
        Label3.Text = "Email"
        ' 
        ' Label4
        ' 
        Label4.BorderStyle = BorderStyle.Fixed3D
        Label4.Font = New Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(43, 72)
        Label4.Name = "Label4"
        Label4.Size = New Size(110, 28)
        Label4.TabIndex = 20
        Label4.Text = "Username"
        ' 
        ' Label5
        ' 
        Label5.BorderStyle = BorderStyle.Fixed3D
        Label5.Font = New Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(43, 188)
        Label5.Name = "Label5"
        Label5.Size = New Size(110, 28)
        Label5.TabIndex = 21
        Label5.Text = "Role"
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(171, 147)
        txtPassword.Margin = New Padding(3, 4, 3, 4)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(166, 27)
        txtPassword.TabIndex = 10
        ' 
        ' Label2
        ' 
        Label2.BorderStyle = BorderStyle.Fixed3D
        Label2.Font = New Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(43, 149)
        Label2.Name = "Label2"
        Label2.Size = New Size(110, 28)
        Label2.TabIndex = 18
        Label2.Text = "Password"
        ' 
        ' AdminForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(626, 600)
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
        Margin = New Padding(3, 4, 3, 4)
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
