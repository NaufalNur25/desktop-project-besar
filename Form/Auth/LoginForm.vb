﻿Imports System.Text
Imports System.Security.Cryptography

Public Class LoginForm
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ' AddHandler MyBase.Load

        ' Event
        AddHandler BtLogin.Click, AddressOf Login
    End Sub

    Private Sub Login()
        Dim email = TxtEmail.Text
        Dim password = TxtPassword.Text
        Dim hashedPassword = GetHashedPassword(password)

        Dim auth As New Auth()
        Dim loginSuccessful = auth.Login(email, hashedPassword)

        If loginSuccessful Then
            MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else
            MessageBox.Show("Invalid email or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub Register_Click(sender As Object, e As EventArgs) Handles register.Click
        Dim registerForm As New RegisterForm()
        registerForm.Show()
        Me.Close()
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