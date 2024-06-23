Imports Microsoft.VisualBasic.ApplicationServices
Imports MySql.Data.MySqlClient

Public Class AdminForm
    ' Ganti dengan string koneksi Anda
    Private connectionString As String = "server=localhost;userid=root;password= ;database=project_desktop"

    Private Sub AdminForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtRole.Items.Add("admin")
        txtRole.Items.Add("user")
        LoadData()
    End Sub

    Private Sub LoadData()
        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()
                Dim query As String = "SELECT id, username, email, password, role FROM users"
                Using cmd As New MySqlCommand(query, connection)
                    Using adapter As New MySqlDataAdapter(cmd)
                        Dim table As New DataTable()
                        adapter.Fill(table)
                        dgvUsers.DataSource = table
                    End Using
                End Using
            Catch ex As MySqlException
                MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadData()
    End Sub




    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If dgvUsers.SelectedRows.Count > 0 Then
            Dim id As Integer = Convert.ToInt32(dgvUsers.SelectedRows(0).Cells("id").Value)
            Dim result As DialogResult = MessageBox.Show("Apakah Anda yakin ingin menghapus pengguna ini?", "Hapus Pengguna", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If result = DialogResult.Yes Then
                Using connection As New MySqlConnection(connectionString)
                    Try
                        connection.Open()
                        Dim query As String = "DELETE FROM users WHERE id=@id"
                        Using cmd As New MySqlCommand(query, connection)
                            cmd.Parameters.AddWithValue("@id", id)
                            cmd.ExecuteNonQuery()
                            MessageBox.Show("Pengguna berhasil dihapus.", "Hapus Pengguna", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            LoadData()
                        End Using
                    Catch ex As MySqlException
                        MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Using
            End If
        Else
            MessageBox.Show("Pilih pengguna yang ingin dihapus.", "Hapus Pengguna", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub isiCombo()


    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim username As String = txtUsername.Text
        Dim email As String = txtEmail.Text
        Dim password As String = txtPassword.Text
        Dim role As String = txtRole.Text
        Dim id As String = txtId.Text

        ' Hash password sebelum menyimpannya ke database (opsional)
        Dim hashedPassword As String = GetHashedPassword(password)

        ' Buat koneksi ke database
        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()
                ' Query untuk memasukkan pengguna baru
                Dim query As String = "INSERT INTO users (username, email, password, role) VALUES (@username, @email, @password, @role)"
                Using cmd As New MySqlCommand(query, connection)
                    ' Tambahkan parameter ke query untuk mencegah SQL Injection
                    cmd.Parameters.AddWithValue("@username", username)
                    cmd.Parameters.AddWithValue("@email", email)
                    cmd.Parameters.AddWithValue("@password", hashedPassword)
                    cmd.Parameters.AddWithValue("@role", role)

                    Dim result As Integer = cmd.ExecuteNonQuery()
                    If result > 0 Then
                        ' Registrasi berhasil, tampilkan pesan sukses
                        MessageBox.Show("Data berhasil ditambahkan.", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        ' Registrasi gagal, tampilkan pesan kesalahan
                        MessageBox.Show("Data gagal ditambahkan", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            Catch ex As MySqlException
                ' Tampilkan pesan error yang lebih detail
                MessageBox.Show("Error: " & ex.Message & vbCrLf & "Details: " & ex.ToString(), "Database Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Function GetHashedPassword(password As String) As String
        Using hasher As New System.Security.Cryptography.SHA256Managed()
            Dim byteValue As Byte() = System.Text.Encoding.UTF8.GetBytes(password)
            Dim byteHash As Byte() = hasher.ComputeHash(byteValue)
            Return Convert.ToBase64String(byteHash)
        End Using
    End Function

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim username As String = txtUsername.Text
        Dim email As String = txtEmail.Text
        Dim password As String = txtPassword.Text
        Dim role As String = txtRole.Text
        Dim id As String = txtId.Text


        ' Hash password sebelum menyimpannya ke database (opsional)
        Dim hashedPassword As String = GetHashedPassword(password)

        ' Buat koneksi ke database
        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()
                ' Query untuk memasukkan pengguna baru
                Dim query As String = "UPDATE users SET username=@username, email=@email, password=@password, role=@role WHERE id=@id"
                Using cmd As New MySqlCommand(query, connection)
                    ' Tambahkan parameter ke query untuk mencegah SQL Injection
                    cmd.Parameters.AddWithValue("@id", id)
                    cmd.Parameters.AddWithValue("@username", username)
                    cmd.Parameters.AddWithValue("@email", email)
                    cmd.Parameters.AddWithValue("@password", hashedPassword)
                    cmd.Parameters.AddWithValue("@role", role)

                    Dim result As Integer = cmd.ExecuteNonQuery()
                    If result > 0 Then
                        ' Registrasi berhasil, tampilkan pesan sukses
                        MessageBox.Show("Data berhasil ditambahkan.", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        ' Registrasi gagal, tampilkan pesan kesalahan
                        MessageBox.Show("Data gagal ditambahkan", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            Catch ex As MySqlException
                ' Tampilkan pesan error yang lebih detail
                MessageBox.Show("Error: " & ex.Message & vbCrLf & "Details: " & ex.ToString(), "Database Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub Id_Click(sender As Object, e As EventArgs) Handles Id.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class
