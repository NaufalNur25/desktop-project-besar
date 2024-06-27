<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GameWidget
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        container = New Label()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' container
        ' 
        container.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        container.BackColor = Color.White
        container.Location = New Point(17, 16)
        container.Margin = New Padding(0)
        container.Name = "container"
        container.Size = New Size(588, 204)
        container.TabIndex = 0
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        Label8.BackColor = Color.White
        Label8.Location = New Point(365, 55)
        Label8.Name = "Label8"
        Label8.RightToLeft = RightToLeft.Yes
        Label8.Size = New Size(224, 68)
        Label8.TabIndex = 15
        Label8.Text = "Lorem ipsum dolor, sit amet consectetur adipisicing elit. At harum itaque assumenda autem iste dolorem alias, minus possimus." & vbCrLf
        Label8.UseCompatibleTextRendering = True
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label7.AutoSize = True
        Label7.BackColor = Color.White
        Label7.Location = New Point(522, 39)
        Label7.Name = "Label7"
        Label7.RightToLeft = RightToLeft.Yes
        Label7.Size = New Size(67, 15)
        Label7.TabIndex = 14
        Label7.Text = "Description"
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Label6.AutoSize = True
        Label6.BackColor = Color.White
        Label6.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(522, 182)
        Label6.Name = "Label6"
        Label6.Size = New Size(67, 21)
        Label6.TabIndex = 13
        Label6.Text = "Pricelist"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.White
        Label5.Location = New Point(47, 83)
        Label5.Name = "Label5"
        Label5.Size = New Size(38, 15)
        Label5.TabIndex = 12
        Label5.Text = "Genre"
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        Label4.AutoSize = True
        Label4.BackColor = Color.White
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(34, 182)
        Label4.Name = "Label4"
        Label4.Size = New Size(70, 21)
        Label4.TabIndex = 11
        Label4.Text = "Platform"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.White
        Label3.Location = New Point(47, 68)
        Label3.Name = "Label3"
        Label3.Size = New Size(73, 15)
        Label3.TabIndex = 10
        Label3.Text = "Release Date"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.White
        Label2.Location = New Point(47, 53)
        Label2.Name = "Label2"
        Label2.Size = New Size(91, 15)
        Label2.TabIndex = 9
        Label2.Text = "Publisher Name"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.White
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(34, 32)
        Label1.Name = "Label1"
        Label1.Size = New Size(104, 21)
        Label1.TabIndex = 8
        Label1.Text = "Game Name"
        ' 
        ' GameWidget
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Transparent
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(container)
        Name = "GameWidget"
        Size = New Size(627, 238)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents container As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label

End Class
