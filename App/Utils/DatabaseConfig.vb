Public Class DatabaseConfig
    Private Property Server As String
    Private Property Port As String
    Private Property Username As String
    Private Property Password As String
    Public Property SavePassword As Boolean
    Private Property Database As String

    Public Sub New(config As Dictionary(Of String, String))
        Server = If(config.ContainsKey("server"), config("server"), "127.0.0.1")
        Port = If(config.ContainsKey("port"), config("port"), "3306")
        Username = If(config.ContainsKey("username"), config("username"), "root")
        Password = If(config.ContainsKey("password"), config("password"), String.Empty)
        SavePassword = If(config.ContainsKey("save_password"), config("save_password"), False)
        Database = If(config.ContainsKey("database"), config("database"), String.Empty)
    End Sub

    Public Overrides Function ToString() As String
        Return $"server={Server};port={Port};uid={Username};pwd={Password};database={Database}"
    End Function

    Public Function GetAttributes() As Dictionary(Of String, String)
        Dim attributes As New Dictionary(Of String, String) From {
            {"server", Server},
            {"port", Port},
            {"username", Username},
            {"password", Password},
            {"save_password", SavePassword.ToString()},
            {"database", Database}
        }
        Return attributes
    End Function


    Public Sub SetAttributes(attributes As Dictionary(Of String, String))
        If attributes.ContainsKey("server") Then Server = attributes("server")
        If attributes.ContainsKey("port") Then Port = attributes("port")
        If attributes.ContainsKey("username") Then Username = attributes("username")
        If attributes.ContainsKey("password") Then Password = attributes("password")
        If attributes.ContainsKey("save_password") Then SavePassword = attributes("save_password")
        If attributes.ContainsKey("database") Then Database = attributes("database")
    End Sub

    Public Sub SaveConfig(configPath As String)
        Dim config As New System.Text.StringBuilder()
        config.AppendLine("server=" & Server)
        config.AppendLine("port=" & Port)
        config.AppendLine("uid=" & Username)
        config.AppendLine("pwd=" & Password)
        config.AppendLine("save_password=" & SavePassword)
        config.AppendLine("database=" & Database)

        System.IO.File.WriteAllText(configPath, config.ToString())
    End Sub
End Class
