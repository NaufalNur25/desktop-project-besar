<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PublishNewGameForm
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
        Label1 = New Label()
        TxtGameName = New TextBox()
        TxtDesc = New TextBox()
        TxtDevName = New TextBox()
        TxtPubName = New TextBox()
        TxtPriceList = New TextBox()
        RelaeseDate = New DateTimePicker()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Button1 = New Button()
        CheckBox16 = New CheckBox()
        TxtGenre = New TextBox()
        TxtPlatform = New TextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(30, 32)
        Label1.Name = "Label1"
        Label1.Size = New Size(92, 20)
        Label1.TabIndex = 0
        Label1.Text = "Game Name"
        ' 
        ' TxtGameName
        ' 
        TxtGameName.Location = New Point(30, 55)
        TxtGameName.Name = "TxtGameName"
        TxtGameName.Size = New Size(368, 27)
        TxtGameName.TabIndex = 1
        ' 
        ' TxtDesc
        ' 
        TxtDesc.Location = New Point(30, 116)
        TxtDesc.Multiline = True
        TxtDesc.Name = "TxtDesc"
        TxtDesc.Size = New Size(368, 90)
        TxtDesc.TabIndex = 2
        ' 
        ' TxtDevName
        ' 
        TxtDevName.Location = New Point(422, 55)
        TxtDevName.Name = "TxtDevName"
        TxtDevName.Size = New Size(385, 27)
        TxtDevName.TabIndex = 3
        ' 
        ' TxtPubName
        ' 
        TxtPubName.Location = New Point(422, 116)
        TxtPubName.Name = "TxtPubName"
        TxtPubName.Size = New Size(385, 27)
        TxtPubName.TabIndex = 4
        ' 
        ' TxtPriceList
        ' 
        TxtPriceList.Location = New Point(33, 242)
        TxtPriceList.Name = "TxtPriceList"
        TxtPriceList.Size = New Size(365, 27)
        TxtPriceList.TabIndex = 5
        ' 
        ' RelaeseDate
        ' 
        RelaeseDate.Location = New Point(422, 179)
        RelaeseDate.Name = "RelaeseDate"
        RelaeseDate.Size = New Size(385, 27)
        RelaeseDate.TabIndex = 6
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(30, 93)
        Label2.Name = "Label2"
        Label2.Size = New Size(128, 20)
        Label2.TabIndex = 10
        Label2.Text = "Game Description"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(422, 32)
        Label3.Name = "Label3"
        Label3.Size = New Size(122, 20)
        Label3.TabIndex = 11
        Label3.Text = "Developer Name"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(422, 93)
        Label4.Name = "Label4"
        Label4.Size = New Size(113, 20)
        Label4.TabIndex = 12
        Label4.Text = "Publisher Name"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(422, 156)
        Label5.Name = "Label5"
        Label5.Size = New Size(96, 20)
        Label5.TabIndex = 13
        Label5.Text = "Release Date"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(30, 219)
        Label6.Name = "Label6"
        Label6.Size = New Size(64, 20)
        Label6.TabIndex = 14
        Label6.Text = "Price list"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(33, 289)
        Label7.Name = "Label7"
        Label7.Size = New Size(66, 20)
        Label7.TabIndex = 15
        Label7.Text = "Platform"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(422, 219)
        Label8.Name = "Label8"
        Label8.Size = New Size(48, 20)
        Label8.TabIndex = 18
        Label8.Text = "Genre"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(33, 412)
        Button1.Name = "Button1"
        Button1.Size = New Size(774, 43)
        Button1.TabIndex = 32
        Button1.Text = "Publish new game"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' CheckBox16
        ' 
        CheckBox16.AutoSize = True
        CheckBox16.Location = New Point(33, 382)
        CheckBox16.Name = "CheckBox16"
        CheckBox16.Size = New Size(154, 24)
        CheckBox16.TabIndex = 33
        CheckBox16.Text = "Multiplayer games"
        CheckBox16.UseVisualStyleBackColor = True
        ' 
        ' TxtGenre
        ' 
        TxtGenre.Location = New Point(422, 242)
        TxtGenre.Name = "TxtGenre"
        TxtGenre.Size = New Size(385, 27)
        TxtGenre.TabIndex = 34
        ' 
        ' TxtPlatform
        ' 
        TxtPlatform.Location = New Point(33, 312)
        TxtPlatform.Name = "TxtPlatform"
        TxtPlatform.Size = New Size(365, 27)
        TxtPlatform.TabIndex = 35
        ' 
        ' MasterGameForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(840, 469)
        Controls.Add(TxtPlatform)
        Controls.Add(TxtGenre)
        Controls.Add(CheckBox16)
        Controls.Add(Button1)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(RelaeseDate)
        Controls.Add(TxtPriceList)
        Controls.Add(TxtPubName)
        Controls.Add(TxtDevName)
        Controls.Add(TxtDesc)
        Controls.Add(TxtGameName)
        Controls.Add(Label1)
        Name = "MasterGameForm"
        Text = "MasterGameForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TxtGameName As TextBox
    Friend WithEvents TxtDesc As TextBox
    Friend WithEvents TxtDevName As TextBox
    Friend WithEvents TxtPubName As TextBox
    Friend WithEvents TxtPriceList As TextBox
    Friend WithEvents RelaeseDate As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents CheckBox16 As CheckBox
    Friend WithEvents TxtGenre As TextBox
    Friend WithEvents TxtPlatform As TextBox
End Class
