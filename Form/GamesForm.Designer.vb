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
        EditButton = New Button()
        GroupBox1.SuspendLayout()
        CType(dgvGames, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TxtPlatform
        ' 
        TxtPlatform.Location = New Point(46, 234)
        TxtPlatform.Margin = New Padding(3, 2, 3, 2)
        TxtPlatform.Name = "TxtPlatform"
        TxtPlatform.Size = New Size(400, 23)
        TxtPlatform.TabIndex = 53
        ' 
        ' TxtGenre
        ' 
        TxtGenre.Location = New Point(472, 182)
        TxtGenre.Margin = New Padding(3, 2, 3, 2)
        TxtGenre.Name = "TxtGenre"
        TxtGenre.Size = New Size(420, 23)
        TxtGenre.TabIndex = 52
        ' 
        ' CbMultiplayerGame
        ' 
        CbMultiplayerGame.AutoSize = True
        CbMultiplayerGame.Location = New Point(472, 236)
        CbMultiplayerGame.Margin = New Padding(3, 2, 3, 2)
        CbMultiplayerGame.Name = "CbMultiplayerGame"
        CbMultiplayerGame.Size = New Size(124, 19)
        CbMultiplayerGame.TabIndex = 51
        CbMultiplayerGame.Text = "Multiplayer games"
        CbMultiplayerGame.UseVisualStyleBackColor = True
        ' 
        ' PublishButton
        ' 
        PublishButton.Location = New Point(46, 266)
        PublishButton.Margin = New Padding(3, 2, 3, 2)
        PublishButton.Name = "PublishButton"
        PublishButton.Size = New Size(846, 32)
        PublishButton.TabIndex = 50
        PublishButton.Text = "Publish"
        PublishButton.UseVisualStyleBackColor = True
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(472, 164)
        Label8.Name = "Label8"
        Label8.Size = New Size(38, 15)
        Label8.TabIndex = 49
        Label8.Text = "Genre"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(46, 217)
        Label7.Name = "Label7"
        Label7.Size = New Size(53, 15)
        Label7.TabIndex = 48
        Label7.Text = "Platform"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(43, 164)
        Label6.Name = "Label6"
        Label6.Size = New Size(51, 15)
        Label6.TabIndex = 47
        Label6.Text = "Price list"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(472, 117)
        Label5.Name = "Label5"
        Label5.Size = New Size(73, 15)
        Label5.TabIndex = 46
        Label5.Text = "Release Date"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(472, 70)
        Label4.Name = "Label4"
        Label4.Size = New Size(91, 15)
        Label4.TabIndex = 45
        Label4.Text = "Publisher Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(472, 24)
        Label3.Name = "Label3"
        Label3.Size = New Size(95, 15)
        Label3.TabIndex = 44
        Label3.Text = "Developer Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(43, 70)
        Label2.Name = "Label2"
        Label2.Size = New Size(101, 15)
        Label2.TabIndex = 43
        Label2.Text = "Game Description"
        ' 
        ' RelaeseDateTimePicker
        ' 
        RelaeseDateTimePicker.Location = New Point(472, 134)
        RelaeseDateTimePicker.Margin = New Padding(3, 2, 3, 2)
        RelaeseDateTimePicker.Name = "RelaeseDateTimePicker"
        RelaeseDateTimePicker.Size = New Size(420, 23)
        RelaeseDateTimePicker.TabIndex = 42
        ' 
        ' TxtPriceList
        ' 
        TxtPriceList.Location = New Point(46, 182)
        TxtPriceList.Margin = New Padding(3, 2, 3, 2)
        TxtPriceList.Name = "TxtPriceList"
        TxtPriceList.Size = New Size(400, 23)
        TxtPriceList.TabIndex = 41
        ' 
        ' TxtPubName
        ' 
        TxtPubName.Location = New Point(472, 87)
        TxtPubName.Margin = New Padding(3, 2, 3, 2)
        TxtPubName.Name = "TxtPubName"
        TxtPubName.Size = New Size(420, 23)
        TxtPubName.TabIndex = 40
        ' 
        ' TxtDevName
        ' 
        TxtDevName.Location = New Point(472, 41)
        TxtDevName.Margin = New Padding(3, 2, 3, 2)
        TxtDevName.Name = "TxtDevName"
        TxtDevName.Size = New Size(420, 23)
        TxtDevName.TabIndex = 39
        ' 
        ' TxtDesc
        ' 
        TxtDesc.Location = New Point(43, 87)
        TxtDesc.Margin = New Padding(3, 2, 3, 2)
        TxtDesc.Multiline = True
        TxtDesc.Name = "TxtDesc"
        TxtDesc.Size = New Size(403, 68)
        TxtDesc.TabIndex = 38
        ' 
        ' TxtGameName
        ' 
        TxtGameName.Location = New Point(43, 41)
        TxtGameName.Margin = New Padding(3, 2, 3, 2)
        TxtGameName.Name = "TxtGameName"
        TxtGameName.Size = New Size(403, 23)
        TxtGameName.TabIndex = 37
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(43, 24)
        Label1.Name = "Label1"
        Label1.Size = New Size(73, 15)
        Label1.TabIndex = 36
        Label1.Text = "Game Name"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(EditButton)
        GroupBox1.Controls.Add(RefreshButton)
        GroupBox1.Controls.Add(HapusButton)
        GroupBox1.Controls.Add(dgvGames)
        GroupBox1.Location = New Point(10, 315)
        GroupBox1.Margin = New Padding(3, 2, 3, 2)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(3, 2, 3, 2)
        GroupBox1.Size = New Size(918, 235)
        GroupBox1.TabIndex = 54
        GroupBox1.TabStop = False
        GroupBox1.Text = "Game List"
        ' 
        ' RefreshButton
        ' 
        RefreshButton.Location = New Point(86, 206)
        RefreshButton.Name = "RefreshButton"
        RefreshButton.Size = New Size(75, 23)
        RefreshButton.TabIndex = 5
        RefreshButton.Text = "Refresh"
        RefreshButton.UseVisualStyleBackColor = True
        ' 
        ' HapusButton
        ' 
        HapusButton.Location = New Point(5, 206)
        HapusButton.Name = "HapusButton"
        HapusButton.Size = New Size(75, 23)
        HapusButton.TabIndex = 4
        HapusButton.Text = "Hapus"
        HapusButton.UseVisualStyleBackColor = True
        ' 
        ' dgvGames
        ' 
        dgvGames.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvGames.Location = New Point(5, 20)
        dgvGames.Name = "dgvGames"
        dgvGames.RowHeadersWidth = 51
        dgvGames.Size = New Size(907, 180)
        dgvGames.TabIndex = 3
        ' 
        ' EditButton
        ' 
        EditButton.Location = New Point(167, 206)
        EditButton.Name = "EditButton"
        EditButton.Size = New Size(75, 23)
        EditButton.TabIndex = 6
        EditButton.Text = "Edit"
        EditButton.UseVisualStyleBackColor = True
        ' 
        ' GamesForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(939, 559)
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
    Friend WithEvents EditButton As Button
End Class
