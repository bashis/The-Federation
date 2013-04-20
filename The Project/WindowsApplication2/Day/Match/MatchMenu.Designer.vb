<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MatchMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MatchMenu))
        Me.tLabel3 = New System.Windows.Forms.Label()
        Me.ItemsTypeLabel = New System.Windows.Forms.Label()
        Me.R_info = New System.Windows.Forms.Label()
        Me.tLabel4 = New System.Windows.Forms.Label()
        Me.result_stats = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.winner_label = New System.Windows.Forms.Label()
        Me.NamesLabel = New System.Windows.Forms.Label()
        Me.ImageButton1 = New RosterViewer.ImageButton()
        Me.MatchStars1 = New RosterViewer.MatchStars()
        Me.Header = New RosterViewer.PreviewScreen()
        Me.Panel1.SuspendLayout()
        CType(Me.ImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tLabel3
        '
        Me.tLabel3.AutoSize = True
        Me.tLabel3.Location = New System.Drawing.Point(0, 68)
        Me.tLabel3.Name = "tLabel3"
        Me.tLabel3.Size = New System.Drawing.Size(35, 13)
        Me.tLabel3.TabIndex = 4
        Me.tLabel3.Text = "Items:"
        '
        'ItemsTypeLabel
        '
        Me.ItemsTypeLabel.AutoSize = True
        Me.ItemsTypeLabel.Location = New System.Drawing.Point(12, 81)
        Me.ItemsTypeLabel.Name = "ItemsTypeLabel"
        Me.ItemsTypeLabel.Size = New System.Drawing.Size(39, 13)
        Me.ItemsTypeLabel.TabIndex = 5
        Me.ItemsTypeLabel.Text = "Label2"
        '
        'R_info
        '
        Me.R_info.AutoSize = True
        Me.R_info.Location = New System.Drawing.Point(12, 37)
        Me.R_info.Name = "R_info"
        Me.R_info.Size = New System.Drawing.Size(39, 13)
        Me.R_info.TabIndex = 8
        Me.R_info.Text = "Label1"
        '
        'tLabel4
        '
        Me.tLabel4.AutoSize = True
        Me.tLabel4.Location = New System.Drawing.Point(4, 24)
        Me.tLabel4.Name = "tLabel4"
        Me.tLabel4.Size = New System.Drawing.Size(32, 13)
        Me.tLabel4.TabIndex = 9
        Me.tLabel4.Text = "Ring:"
        '
        'result_stats
        '
        Me.result_stats.AutoSize = True
        Me.result_stats.Location = New System.Drawing.Point(687, 37)
        Me.result_stats.Name = "result_stats"
        Me.result_stats.Size = New System.Drawing.Size(37, 13)
        Me.result_stats.TabIndex = 10
        Me.result_stats.Text = "Result"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.NamesLabel)
        Me.Panel1.Controls.Add(Me.Header)
        Me.Panel1.Location = New System.Drawing.Point(108, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(557, 322)
        Me.Panel1.TabIndex = 11
        '
        'winner_label
        '
        Me.winner_label.BackColor = System.Drawing.Color.Transparent
        Me.winner_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.winner_label.ForeColor = System.Drawing.SystemColors.Control
        Me.winner_label.Location = New System.Drawing.Point(130, 424)
        Me.winner_label.Name = "winner_label"
        Me.winner_label.Size = New System.Drawing.Size(515, 60)
        Me.winner_label.TabIndex = 13
        Me.winner_label.Text = "winner"
        Me.winner_label.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'NamesLabel
        '
        Me.NamesLabel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.NamesLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.NamesLabel.Location = New System.Drawing.Point(3, 281)
        Me.NamesLabel.Name = "NamesLabel"
        Me.NamesLabel.Size = New System.Drawing.Size(549, 39)
        Me.NamesLabel.TabIndex = 10
        Me.NamesLabel.Text = "Label1"
        Me.NamesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ImageButton1
        '
        Me.ImageButton1.BackColor = System.Drawing.Color.Transparent
        Me.ImageButton1.Image = CType(resources.GetObject("ImageButton1.Image"), System.Drawing.Image)
        Me.ImageButton1.Location = New System.Drawing.Point(308, 514)
        Me.ImageButton1.Name = "ImageButton1"
        Me.ImageButton1.PressImage = CType(resources.GetObject("ImageButton1.PressImage"), System.Drawing.Image)
        Me.ImageButton1.Size = New System.Drawing.Size(179, 180)
        Me.ImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ImageButton1.StaticImage = CType(resources.GetObject("ImageButton1.StaticImage"), System.Drawing.Image)
        Me.ImageButton1.TabIndex = 18
        Me.ImageButton1.TabStop = False
        '
        'MatchStars1
        '
        Me.MatchStars1.BackColor = System.Drawing.Color.Transparent
        Me.MatchStars1.Location = New System.Drawing.Point(247, 340)
        Me.MatchStars1.Name = "MatchStars1"
        Me.MatchStars1.Size = New System.Drawing.Size(325, 93)
        Me.MatchStars1.TabIndex = 17
        '
        'Header
        '
        Me.Header.AutoSize = True
        Me.Header.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Header.Location = New System.Drawing.Point(-2, 11)
        Me.Header.Name = "Header"
        Me.Header.Size = New System.Drawing.Size(559, 267)
        Me.Header.TabIndex = 9
        '
        'MatchMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(788, 692)
        Me.Controls.Add(Me.ImageButton1)
        Me.Controls.Add(Me.MatchStars1)
        Me.Controls.Add(Me.winner_label)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.result_stats)
        Me.Controls.Add(Me.tLabel4)
        Me.Controls.Add(Me.R_info)
        Me.Controls.Add(Me.ItemsTypeLabel)
        Me.Controls.Add(Me.tLabel3)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "MatchMenu"
        Me.Text = "MatchMenu"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tLabel3 As System.Windows.Forms.Label
    Friend WithEvents ItemsTypeLabel As System.Windows.Forms.Label
    Friend WithEvents R_info As System.Windows.Forms.Label
    Friend WithEvents tLabel4 As System.Windows.Forms.Label
    Friend WithEvents result_stats As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents winner_label As System.Windows.Forms.Label
    Friend WithEvents MatchStars1 As RosterViewer.MatchStars
    Friend WithEvents ImageButton1 As RosterViewer.ImageButton
    Friend WithEvents NamesLabel As System.Windows.Forms.Label
    Friend WithEvents Header As RosterViewer.PreviewScreen
End Class
