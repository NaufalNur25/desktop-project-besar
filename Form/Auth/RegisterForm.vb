Imports System.Text
Imports System.Security.Cryptography

Public Class RegisterForm
    Public Sub New()
        ' Pemanggilan ini diperlukan oleh desainer.
        InitializeComponent()

        ' Tambahkan inisialisasi setelah pemanggilan InitializeComponent.
        AddHandler RegisterButton.Click, AddressOf Register
    End Sub

    Private Sub Register()
        Dim username = UsernameLabel.Text
        Dim email = EmailLabel.Text
        Dim password = PasswordLabel.Text
        Dim hashedPassword = GetHashedPassword(password)

        Dim auth As New Auth()
        Dim registrationSuccessful = auth.Register(username, email, hashedPassword)

        If registrationSuccessful Then
            MessageBox.Show("Registrasi berhasil!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ' Buka form login setelah registrasi berhasil
            Dim loginForm As New LoginForm()
            loginForm.Show()
            Me.Close()
        Else
            MessageBox.Show("Registrasi gagal. Coba lagi.", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    ' Fungsi untuk hashing password
    Private Function GetHashedPassword(password As String) As String
        Using hasher As New SHA256Managed()
            Dim byteValue As Byte() = Encoding.UTF8.GetBytes(password)
            Dim byteHash As Byte() = hasher.ComputeHash(byteValue)
            Return Convert.ToBase64String(byteHash)
        End Using
    End Function
End Class
