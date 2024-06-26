Imports System.Text
Imports System.Security.Cryptography
Imports MySql.Data.MySqlClient

Public Class FormLogin
    ' Ganti dengan string koneksi Anda
    Private connectionString As String = "server=localhost;userid=root;password= ;database=project_desktop"

    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        Dim username = UsernameLabel.Text
        Dim password = PasswordLabel.Text
        ' Hash password sebelum memverifikasi dengan database
        Dim hashedPassword As String = GetHashedPassword(password)

        ' Buat koneksi ke database
        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()
                ' Query untuk memeriksa username dan password
                Dim query = "SELECT role FROM users WHERE username=@username AND password=@password"
                Using cmd As New MySqlCommand(query, connection)
                    ' Tambahkan parameter ke query untuk mencegah SQL Injection
                    cmd.Parameters.AddWithValue("@username", username)
                    cmd.Parameters.AddWithValue("@password", hashedPassword)
                    Dim role As String = Convert.ToString(cmd.ExecuteScalar())
                    If Not String.IsNullOrEmpty(role) Then
                        ' Login berhasil, cek peran pengguna
                        If role = "admin" Then
                            ' Buka form admin dan tutup form login
                            MessageBox.Show(role & "anda admin")
                            Dim adminForm As New AdminForm()
                            Me.Hide()  ' Sembunyikan form login
                            adminForm.ShowDialog()  ' Tampilkan form admin sebagai modal
                        Else
                            ' Buka form utama dan tutup form login
                            Dim mainForm As New DashbordForm()
                            Me.Hide()  ' Sembunyikan form login
                            mainForm.ShowDialog()  ' Tampilkan form utama sebagai modal
                        End If
                        Me.Close()  ' Tutup form login setelah form utama/admin ditutup
                    Else
                        ' Login gagal, tampilkan pesan kesalahan
                        MessageBox.Show("Username atau Password salah", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            Catch ex As MySqlException
                ' Tampilkan pesan error yang lebih detail
                MessageBox.Show("Error: " & ex.Message & vbCrLf & "Details: " & ex.ToString(), "Database Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()
                MessageBox.Show("Koneksi ke database berhasil!", "Test Koneksi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As MySqlException
                MessageBox.Show("Gagal terhubung ke database: " & ex.Message, "Test Koneksi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub Register_Click(sender As Object, e As EventArgs) Handles register.Click
        Dim registerForm As New Register()
        registerForm.Show()  ' Tampilkan form registrasi sebagai modal
        Me.Hide()
    End Sub

    ' Fungsi untuk hashing password
    Private Function GetHashedPassword(password As String) As String
        Using hasher As New SHA256Managed()
            Dim byteValue As Byte() = Encoding.UTF8.GetBytes(password)
            Dim byteHash As Byte() = hasher.ComputeHash(byteValue)
            Return Convert.ToBase64String(byteHash)
        End Using
    End Function

    Private Sub UsernameLabel_TextChanged(sender As Object, e As EventArgs) Handles UsernameLabel.TextChanged

    End Sub

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
