Public Class GamesForm

    Public Sub New()
        ' Pemanggilan ini diperlukan oleh desainer.
        InitializeComponent()

        ' Tambahkan inisialisasi setelah pemanggilan InitializeComponent.
        AddHandler Me.Load, AddressOf LoadGames
        AddHandler PublishButton.Click, AddressOf AddGame
        AddHandler HapusButton.Click, AddressOf DeleteGame
        AddHandler RefreshButton.Click, AddressOf LoadGames
        AddHandler dgvGames.Click, AddressOf selectedList
        AddHandler EditButton.Click, AddressOf UpdateGame

    End Sub

    Private Sub AddGame()
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
            Call LoadGames()
        Else
            MessageBox.Show("Error creating game!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub DeleteGame()
        ' Ambil ID game dari baris yang dipilih
        If dgvGames.SelectedRows.Count > 0 Then
            Dim gameId As Integer = Convert.ToInt32(dgvGames.SelectedRows(0).Cells("id").Value)

            ' Konfirmasi penghapusan
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this game?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                ' Hapus game dari database
                Dim games As New Games()
                games.DeleteGame(gameId)
                LoadGames()
            End If
        Else
            MessageBox.Show("Please select a game to delete.", "No Game Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub UpdateGame()
        If dgvGames.SelectedRows.Count > 0 Then
            Dim gameId As Integer = Convert.ToInt32(dgvGames.SelectedRows(0).Cells("id").Value)
            Dim gameName As String = TxtGameName.Text
            Dim devName As String = TxtDevName.Text
            Dim desc As String = TxtDesc.Text
            Dim pubName As String = TxtPubName.Text
            Dim releaseDate As String = RelaeseDateTimePicker.Value.Date.ToString("yyyy-MM-dd")
            Dim price As String = TxtPriceList.Text
            Dim genre As String = TxtGenre.Text
            Dim platform As String = TxtPlatform.Text
            Dim isMultiplayerGame As Boolean = CbMultiplayerGame.Checked

            Dim games As New Games
            Dim success As Boolean = games.UpdateGame(gameId, gameName, devName, desc, pubName, releaseDate, price, genre, platform, isMultiplayerGame)

            If success Then
                MessageBox.Show("Game updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Call LoadGames()
            Else
                MessageBox.Show("Error updating game!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
                MessageBox.Show("Please select a game to update.", "No Game Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub LoadGames()
        Dim games As New Games()
        Dim usersTable As DataTable = games.LoadGames()

        Call clearInputForm()
        dgvGames.DataSource = usersTable

        ' Sembunyikan kolom ID
        If dgvGames.Columns.Contains("id") Then
            dgvGames.Columns("id").Visible = False
        End If
    End Sub

    Private Sub clearInputForm()
        TxtGameName.Text = String.Empty
        TxtDevName.Text = String.Empty
        TxtDesc.Text = String.Empty
        TxtPubName.Text = String.Empty
        RelaeseDateTimePicker.Value = Date.Today
        TxtPriceList.Text = String.Empty
        TxtGenre.Text = String.Empty
        TxtPlatform.Text = String.Empty
        CbMultiplayerGame.Checked = False
    End Sub

    Private Sub setInputForm(gameName As String,
                               devName As String,
                               desc As String,
                               pubName As String,
                               releaseDate As Date,
                               price As String,
                               genre As String,
                               platform As String,
                               isMultiplayerGame As Boolean)
        TxtGameName.Text = gameName
        TxtDevName.Text = devName
        TxtDesc.Text = desc
        TxtPubName.Text = pubName
        RelaeseDateTimePicker.Value = releaseDate
        TxtPriceList.Text = price
        TxtGenre.Text = genre
        TxtPlatform.Text = platform
        CbMultiplayerGame.Checked = isMultiplayerGame
    End Sub

    Private Sub selectedList(sender As Object, e As EventArgs)
        If dgvGames.SelectedRows.Count > 0 Then
            Dim row As DataGridViewRow = dgvGames.SelectedRows(0)
            Dim gameName As String = row.Cells("name").Value.ToString()
            Dim devName As String = row.Cells("dev_game").Value.ToString()
            Dim desc As String = row.Cells("description").Value.ToString()
            Dim pubName As String = row.Cells("pub_game").Value.ToString()
            Dim releaseDate As Date = Convert.ToDateTime(row.Cells("release_date").Value)
            Dim price As String = row.Cells("price_list").Value.ToString()
            Dim genre As String = row.Cells("genre").Value.ToString()
            Dim platform As String = row.Cells("platform").Value.ToString()
            Dim isMultiplayerGame As Boolean = Convert.ToBoolean(row.Cells("is_multiplayer").Value)

            setInputForm(gameName, devName, desc, pubName, releaseDate, price, genre, platform, isMultiplayerGame)
        End If
    End Sub


End Class
