Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class AuthSession
    Public Sub Auth(users As Dictionary(Of String, String))
        Dim sessionConfig As New SessionConfig()
        sessionConfig.setSession("sub", users("sub"))
        sessionConfig.setSession("username", users("username"))
        sessionConfig.setSession("email", users("email"))
        sessionConfig.setSession("role", users("role"))
        sessionConfig.SaveConfig()
    End Sub
End Class
