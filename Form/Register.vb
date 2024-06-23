Imports System.Text
Imports MySql.Data.MySqlClient

Public Class Register
    ' Ganti dengan string koneksi Anda
    Private connectionString As String = "server=localhost;userid=root;password= ;database=project_desktop"

    ' Event handler untuk tombol register
    Private Sub RegisterButton_Click(sender As Object, e As EventArgs) Handles RegisterButton.Click
        Dim username As String = UsernameLabel.Text
        Dim Email As String = EmailLabel.Text
        Dim password As String = PasswordLabel.Text

        ' Hash password sebelum menyimpannya ke database (opsional)
        Dim hashedPassword As String = GetHashedPassword(password)

        ' Buat koneksi ke database
        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()
                ' Query untuk memasukkan pengguna baru
                Dim query As String = "INSERT INTO users (username, email, password) VALUES (@username, @email, @password)"
                Using cmd As New MySqlCommand(query, connection)
                    ' Tambahkan parameter ke query untuk mencegah SQL Injection
                    cmd.Parameters.AddWithValue("@username", username)
                    cmd.Parameters.AddWithValue("@email", Email)
                    cmd.Parameters.AddWithValue("@password", hashedPassword)

                    Dim result As Integer = cmd.ExecuteNonQuery()
                    If result > 0 Then
                        ' Registrasi berhasil, tampilkan pesan sukses
                        MessageBox.Show("Registrasi berhasil! Anda sekarang dapat login.", "Registrasi Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        FormLogin.Show()
                        Me.Close()  ' Tutup form registrasi
                    Else
                        ' Registrasi gagal, tampilkan pesan kesalahan
                        MessageBox.Show("Registrasi gagal, coba lagi.", "Registrasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            Catch ex As MySqlException
                ' Tampilkan pesan error yang lebih detail
                MessageBox.Show("Error: " & ex.Message & vbCrLf & "Details: " & ex.ToString(), "Database Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    ' Fungsi untuk hashing password
    Private Function GetHashedPassword(password As String) As String
        Using hasher As New System.Security.Cryptography.SHA256Managed()
            Dim byteValue As Byte() = System.Text.Encoding.UTF8.GetBytes(password)
            Dim byteHash As Byte() = hasher.ComputeHash(byteValue)
            Return Convert.ToBase64String(byteHash)
        End Using
    End Function

    Private Sub Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class