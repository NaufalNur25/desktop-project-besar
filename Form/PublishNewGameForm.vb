Public Class PublishNewGameForm
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ' AddHandler MyBase.Load, AddressOf DashbordForm

        AddHandler BtPublish.Click, AddressOf publish
    End Sub

    Sub publish()
        Dim games As New Games

        Dim gameName As String = TxtGameName.Text
        Dim devName As String = TxtDevName.Text
        Dim desc As String = TxtDesc.Text
        Dim pubName As String = TxtPubName.Text
        Dim releaseDate As String = RelaeseDateTimePicker.Value.Date.ToString("yyyy-MM-dd")
        Dim price As String = TxtPriceList.Text
        Dim genre As String = TxtGenre.Text
        Dim platform As String = TxtPlatform.Text
        Dim isMultiplayerGame As Boolean = CbMultiplayerGame.Checked

        Dim success As Boolean = games.Publish(gameName, devName, desc, pubName, releaseDate, price, genre, platform, isMultiplayerGame)

        If success Then
            MessageBox.Show("Game created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Error creating game!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class