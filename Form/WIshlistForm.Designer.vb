<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WishlistForm
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
        FlowLayoutPanel1 = New FlowLayoutPanel()
        GameWidget5 = New GameWidget()
        GameWidget1 = New GameWidget()
        WishlistLabel = New Label()
        GameWidget2 = New GameWidget()
        GameWidget3 = New GameWidget()
        GameWidget4 = New GameWidget()
        FlowLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.AutoScroll = True
        FlowLayoutPanel1.Controls.Add(GameWidget5)
        FlowLayoutPanel1.Controls.Add(GameWidget1)
        FlowLayoutPanel1.Controls.Add(GameWidget2)
        FlowLayoutPanel1.Controls.Add(GameWidget3)
        FlowLayoutPanel1.Controls.Add(GameWidget4)
        FlowLayoutPanel1.Location = New Point(12, 55)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(651, 383)
        FlowLayoutPanel1.TabIndex = 1
        ' 
        ' GameWidget5
        ' 
        GameWidget5.BackColor = Color.Transparent
        GameWidget5.Location = New Point(3, 3)
        GameWidget5.Name = "GameWidget5"
        GameWidget5.Size = New Size(627, 238)
        GameWidget5.TabIndex = 4
        ' 
        ' GameWidget1
        ' 
        GameWidget1.BackColor = Color.Transparent
        GameWidget1.Location = New Point(3, 247)
        GameWidget1.Name = "GameWidget1"
        GameWidget1.Size = New Size(627, 238)
        GameWidget1.TabIndex = 5
        ' 
        ' WishlistLabel
        ' 
        WishlistLabel.AutoSize = True
        WishlistLabel.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        WishlistLabel.ForeColor = SystemColors.ControlDarkDark
        WishlistLabel.Location = New Point(9, 9)
        WishlistLabel.Margin = New Padding(0)
        WishlistLabel.Name = "WishlistLabel"
        WishlistLabel.Size = New Size(194, 30)
        WishlistLabel.TabIndex = 0
        WishlistLabel.Text = "Username Wishlist"
        WishlistLabel.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' GameWidget2
        ' 
        GameWidget2.BackColor = Color.Transparent
        GameWidget2.Location = New Point(3, 491)
        GameWidget2.Name = "GameWidget2"
        GameWidget2.Size = New Size(627, 238)
        GameWidget2.TabIndex = 6
        ' 
        ' GameWidget3
        ' 
        GameWidget3.BackColor = Color.Transparent
        GameWidget3.Location = New Point(3, 735)
        GameWidget3.Name = "GameWidget3"
        GameWidget3.Size = New Size(627, 238)
        GameWidget3.TabIndex = 7
        ' 
        ' GameWidget4
        ' 
        GameWidget4.BackColor = Color.Transparent
        GameWidget4.Location = New Point(3, 979)
        GameWidget4.Name = "GameWidget4"
        GameWidget4.Size = New Size(627, 238)
        GameWidget4.TabIndex = 8
        ' 
        ' WishlistForm
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(674, 450)
        Controls.Add(FlowLayoutPanel1)
        Controls.Add(WishlistLabel)
        Name = "WishlistForm"
        Text = "WishlistForm"
        FlowLayoutPanel1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents WishlistLabel As Label
    Friend WithEvents GameWidget5 As GameWidget
    Friend WithEvents GameWidget1 As GameWidget
    Friend WithEvents GameWidget2 As GameWidget
    Friend WithEvents GameWidget3 As GameWidget
    Friend WithEvents GameWidget4 As GameWidget
End Class
