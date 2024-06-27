<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GamesForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        TxtPlatform = New TextBox()
        TxtGenre = New TextBox()
        CbMultiplayerGame = New CheckBox()
        PublishButton = New Button()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        RelaeseDateTimePicker = New DateTimePicker()
        TxtPriceList = New TextBox()
        TxtPubName = New TextBox()
        TxtDevName = New TextBox()
        TxtDesc = New TextBox()
        TxtGameName = New TextBox()
        Label1 = New Label()
        GroupBox1 = New GroupBox()
        RefreshButton = New Button()
        HapusButton = New Button()
        dgvGames = New DataGridView()
        GroupBox1.SuspendLayout()
        CType(dgvGames, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TxtPlatform
        ' 
        TxtPlatform.Location = New Point(52, 312)
        TxtPlatform.Name = "TxtPlatform"
        TxtPlatform.Size = New Size(457, 27)
        TxtPlatform.TabIndex = 53
        ' 
        ' TxtGenre
        ' 
        TxtGenre.Location = New Point(540, 242)
        TxtGenre.Name = "TxtGenre"
        TxtGenre.Size = New Size(479, 27)
        TxtGenre.TabIndex = 52
        ' 
        ' CbMultiplayerGame
        ' 
        CbMultiplayerGame.AutoSize = True
        CbMultiplayerGame.Location = New Point(540, 314)
        CbMultiplayerGame.Name = "CbMultiplayerGame"
        CbMultiplayerGame.Size = New Size(154, 24)
        CbMultiplayerGame.TabIndex = 51
        CbMultiplayerGame.Text = "Multiplayer games"
        CbMultiplayerGame.UseVisualStyleBackColor = True
        ' 
        ' PublishButton
        ' 
        PublishButton.Location = New Point(52, 355)
        PublishButton.Name = "PublishButton"
        PublishButton.Size = New Size(967, 43)
        PublishButton.TabIndex = 50
        PublishButton.Text = "Publish"
        PublishButton.UseVisualStyleBackColor = True
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(540, 219)
        Label8.Name = "Label8"
        Label8.Size = New Size(48, 20)
        Label8.TabIndex = 49
        Label8.Text = "Genre"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(52, 289)
        Label7.Name = "Label7"
        Label7.Size = New Size(66, 20)
        Label7.TabIndex = 48
        Label7.Text = "Platform"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(49, 219)
        Label6.Name = "Label6"
        Label6.Size = New Size(64, 20)
        Label6.TabIndex = 47
        Label6.Text = "Price list"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(540, 156)
        Label5.Name = "Label5"
        Label5.Size = New Size(96, 20)
        Label5.TabIndex = 46
        Label5.Text = "Release Date"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(540, 93)
        Label4.Name = "Label4"
        Label4.Size = New Size(113, 20)
        Label4.TabIndex = 45
        Label4.Text = "Publisher Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(540, 32)
        Label3.Name = "Label3"
        Label3.Size = New Size(122, 20)
        Label3.TabIndex = 44
        Label3.Text = "Developer Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(49, 93)
        Label2.Name = "Label2"
        Label2.Size = New Size(128, 20)
        Label2.TabIndex = 43
        Label2.Text = "Game Description"
        ' 
        ' RelaeseDateTimePicker
        ' 
        RelaeseDateTimePicker.Location = New Point(540, 179)
        RelaeseDateTimePicker.Name = "RelaeseDateTimePicker"
        RelaeseDateTimePicker.Size = New Size(479, 27)
        RelaeseDateTimePicker.TabIndex = 42
        ' 
        ' TxtPriceList
        ' 
        TxtPriceList.Location = New Point(52, 242)
        TxtPriceList.Name = "TxtPriceList"
        TxtPriceList.Size = New Size(457, 27)
        TxtPriceList.TabIndex = 41
        ' 
        ' TxtPubName
        ' 
        TxtPubName.Location = New Point(540, 116)
        TxtPubName.Name = "TxtPubName"
        TxtPubName.Size = New Size(479, 27)
        TxtPubName.TabIndex = 40
        ' 
        ' TxtDevName
        ' 
        TxtDevName.Location = New Point(540, 55)
        TxtDevName.Name = "TxtDevName"
        TxtDevName.Size = New Size(479, 27)
        TxtDevName.TabIndex = 39
        ' 
        ' TxtDesc
        ' 
        TxtDesc.Location = New Point(49, 116)
        TxtDesc.Multiline = True
        TxtDesc.Name = "TxtDesc"
        TxtDesc.Size = New Size(460, 90)
        TxtDesc.TabIndex = 38
        ' 
        ' TxtGameName
        ' 
        TxtGameName.Location = New Point(49, 55)
        TxtGameName.Name = "TxtGameName"
        TxtGameName.Size = New Size(460, 27)
        TxtGameName.TabIndex = 37
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(49, 32)
        Label1.Name = "Label1"
        Label1.Size = New Size(92, 20)
        Label1.TabIndex = 36
        Label1.Text = "Game Name"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(RefreshButton)
        GroupBox1.Controls.Add(HapusButton)
        GroupBox1.Controls.Add(dgvGames)
        GroupBox1.Location = New Point(12, 420)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(1049, 313)
        GroupBox1.TabIndex = 54
        GroupBox1.TabStop = False
        GroupBox1.Text = "Game List"
        ' 
        ' RefreshButton
        ' 
        RefreshButton.Location = New Point(98, 275)
        RefreshButton.Margin = New Padding(3, 4, 3, 4)
        RefreshButton.Name = "RefreshButton"
        RefreshButton.Size = New Size(86, 31)
        RefreshButton.TabIndex = 5
        RefreshButton.Text = "Refresh"
        RefreshButton.UseVisualStyleBackColor = True
        ' 
        ' HapusButton
        ' 
        HapusButton.Location = New Point(6, 275)
        HapusButton.Margin = New Padding(3, 4, 3, 4)
        HapusButton.Name = "HapusButton"
        HapusButton.Size = New Size(86, 31)
        HapusButton.TabIndex = 4
        HapusButton.Text = "Hapus"
        HapusButton.UseVisualStyleBackColor = True
        ' 
        ' dgvGames
        ' 
        dgvGames.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvGames.Location = New Point(6, 27)
        dgvGames.Margin = New Padding(3, 4, 3, 4)
        dgvGames.Name = "dgvGames"
        dgvGames.RowHeadersWidth = 51
        dgvGames.Size = New Size(1037, 240)
        dgvGames.TabIndex = 3
        ' 
        ' GamesForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1073, 745)
        Controls.Add(GroupBox1)
        Controls.Add(TxtPlatform)
        Controls.Add(TxtGenre)
        Controls.Add(CbMultiplayerGame)
        Controls.Add(PublishButton)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(RelaeseDateTimePicker)
        Controls.Add(TxtPriceList)
        Controls.Add(TxtPubName)
        Controls.Add(TxtDevName)
        Controls.Add(TxtDesc)
        Controls.Add(TxtGameName)
        Controls.Add(Label1)
        Margin = New Padding(3, 4, 3, 4)
        Name = "GamesForm"
        Text = "GamesForm"
        GroupBox1.ResumeLayout(False)
        CType(dgvGames, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TxtPlatform As TextBox
    Friend WithEvents TxtGenre As TextBox
    Friend WithEvents CbMultiplayerGame As CheckBox
    Friend WithEvents PublishButton As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents RelaeseDateTimePicker As DateTimePicker
    Friend WithEvents TxtPriceList As TextBox
    Friend WithEvents TxtPubName As TextBox
    Friend WithEvents TxtDevName As TextBox
    Friend WithEvents TxtDesc As TextBox
    Friend WithEvents TxtGameName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RefreshButton As Button
    Friend WithEvents HapusButton As Button
    Friend WithEvents dgvGames As DataGridView
End Class
