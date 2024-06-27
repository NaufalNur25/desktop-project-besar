Public Class GamesForm

    Public Sub New()
        ' Pemanggilan ini diperlukan oleh desainer.
        InitializeComponent()

        ' Tambahkan inisialisasi setelah pemanggilan InitializeComponent.
        AddHandler Me.Load, AddressOf LoadGames
        AddHandler HapusButton.Click, AddressOf DeleteGame
        AddHandler RefreshButton.Click, AddressOf LoadGames




    End Sub

    Private Sub DeleteGame()
        ' Ambil ID game dari baris yang dipilih
        Dim gameId As Integer = Convert.ToInt32(dgvGames.SelectedRows(0).Cells("id").Value)
        If dgvGames.SelectedRows.Count > 0 Then


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

    Private Sub LoadGames()
        Dim games As New Games()
        Dim usersTable As DataTable = games.LoadGames()
        dgvGames.DataSource = usersTable

        ' Sembunyikan kolom ID
        If dgvGames.Columns.Contains("id") Then
            dgvGames.Columns("id").Visible = False
        End If
    End Sub

End Class