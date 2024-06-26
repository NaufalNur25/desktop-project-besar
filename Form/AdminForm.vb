Imports System.Text
Imports System.Security.Cryptography
Imports MySql.Data.MySqlClient
Imports System.Threading

Public Class AdminForm
    Public Sub New()
        ' Pemanggilan ini diperlukan oleh desainer.
        InitializeComponent()

        ' Tambahkan inisialisasi setelah pemanggilan InitializeComponent.
        AddHandler btnAdd.Click, AddressOf CreateUser
        AddHandler btnRefresh.Click, AddressOf ReadUsers
        AddHandler btnEdit.Click, AddressOf UpdateUser
        AddHandler btnDelete.Click, AddressOf DeleteUser
        AddHandler dgvUsers.CellClick, AddressOf DataGridViewUsers_CellClick
    End Sub

    Private Sub CreateUser()
        Dim username = txtUsername.Text
        Dim email = txtEmail.Text
        Dim password = txtPassword.Text

        Dim admin As New Admin()
        Dim userCreated = admin.CreateUser(username, email, password)

        If userCreated Then
            MessageBox.Show("Pengguna berhasil dibuat!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ReadUsers() ' Refresh data pengguna setelah create
        Else
            MessageBox.Show("Gagal membuat pengguna.", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub ReadUsers()
        Dim admin As New Admin()
        Dim usersTable As DataTable = admin.ReadUsers()
        dgvUsers.DataSource = usersTable
    End Sub

    Private Sub UpdateUser()
        Dim userId As Integer
        If Not Integer.TryParse(txtId.Text, userId) Then
            MessageBox.Show("ID pengguna tidak valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim username = txtUsername.Text
        Dim email = txtEmail.Text
        Dim password = txtPassword.Text
        Dim role = txtRole.Text

        Dim admin As New Admin()
        Dim userUpdated = admin.UpdateUser(userId, username, email, password, role)

        If userUpdated Then
            MessageBox.Show("Pengguna berhasil diperbarui!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ReadUsers() ' Refresh data pengguna setelah update
        Else
            MessageBox.Show("Gagal memperbarui pengguna.", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub DeleteUser()
        Dim userId As Integer
        If Not Integer.TryParse(txtId.Text, userId) Then
            MessageBox.Show("ID pengguna tidak valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim admin As New Admin()
        Dim userDeleted = admin.DeleteUser(userId)

        If userDeleted Then
            MessageBox.Show("Pengguna berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ReadUsers() ' Refresh data pengguna setelah delete
        Else
            MessageBox.Show("Gagal menghapus pengguna.", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub DataGridViewUsers_CellClick(sender As Object, e As DataGridViewCellEventArgs)
        ' Pastikan klik tidak pada header row
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvUsers.Rows(e.RowIndex)
            txtId.Text = row.Cells("id").Value.ToString()
            txtUsername.Text = row.Cells("username").Value.ToString()
            txtEmail.Text = row.Cells("email").Value.ToString()
            txtPassword.Text = ""
        End If
    End Sub

    Private Function GetHashedPassword(password As String) As String
        Using hasher As New SHA256Managed()
            Dim byteValue As Byte() = Encoding.UTF8.GetBytes(password)
            Dim byteHash As Byte() = hasher.ComputeHash(byteValue)
            Return Convert.ToBase64String(byteHash)
        End Using
    End Function
End Class
