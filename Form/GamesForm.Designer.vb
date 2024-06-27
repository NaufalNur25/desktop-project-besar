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
        dgvGames = New DataGridView()
        HapusButton = New Button()
        RefreshButton = New Button()
        CType(dgvGames, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvGames
        ' 
        dgvGames.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvGames.Location = New Point(30, 58)
        dgvGames.Name = "dgvGames"
        dgvGames.Size = New Size(732, 150)
        dgvGames.TabIndex = 0
        ' 
        ' HapusButton
        ' 
        HapusButton.Location = New Point(30, 248)
        HapusButton.Name = "HapusButton"
        HapusButton.Size = New Size(75, 23)
        HapusButton.TabIndex = 1
        HapusButton.Text = "Hapus"
        HapusButton.UseVisualStyleBackColor = True
        ' 
        ' RefreshButton
        ' 
        RefreshButton.Location = New Point(124, 248)
        RefreshButton.Name = "RefreshButton"
        RefreshButton.Size = New Size(75, 23)
        RefreshButton.TabIndex = 2
        RefreshButton.Text = "Refresh"
        RefreshButton.UseVisualStyleBackColor = True
        ' 
        ' GamesForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(RefreshButton)
        Controls.Add(HapusButton)
        Controls.Add(dgvGames)
        Name = "GamesForm"
        Text = "GamesForm"
        CType(dgvGames, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents dgvGames As DataGridView
    Friend WithEvents HapusButton As Button
    Friend WithEvents RefreshButton As Button
End Class
