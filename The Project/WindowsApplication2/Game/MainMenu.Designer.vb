<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainMenu))
        Me.NewsScreen1 = New RosterViewer.NewsScreen()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateLabel = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.ShowRoster = New System.Windows.Forms.Button()
        Me.ShowButton = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DaysLeftLabel = New System.Windows.Forms.Label()
        Me.NextShowLabel = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NewsScreen1
        '
        Me.NewsScreen1.AutoSize = True
        Me.NewsScreen1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.NewsScreen1.Location = New System.Drawing.Point(129, 12)
        Me.NewsScreen1.Name = "NewsScreen1"
        Me.NewsScreen1.Size = New System.Drawing.Size(559, 368)
        Me.NewsScreen1.TabIndex = 14
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(594, 462)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(170, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.Location = New System.Drawing.Point(133, 383)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(288, 78)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Today:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "       days before   "
        '
        'DateLabel
        '
        Me.DateLabel.AutoSize = True
        Me.DateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.DateLabel.Location = New System.Drawing.Point(252, 393)
        Me.DateLabel.Name = "DateLabel"
        Me.DateLabel.Size = New System.Drawing.Size(77, 25)
        Me.DateLabel.TabIndex = 17
        Me.DateLabel.Text = "Label2"
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(12, 114)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(85, 28)
        Me.Button6.TabIndex = 21
        Me.Button6.Text = "Pay-Per-View"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'ShowRoster
        '
        Me.ShowRoster.Location = New System.Drawing.Point(12, 12)
        Me.ShowRoster.Name = "ShowRoster"
        Me.ShowRoster.Size = New System.Drawing.Size(85, 28)
        Me.ShowRoster.TabIndex = 20
        Me.ShowRoster.Text = "Roster"
        Me.ShowRoster.UseVisualStyleBackColor = True
        '
        'ShowButton
        '
        Me.ShowButton.Location = New System.Drawing.Point(12, 46)
        Me.ShowButton.Name = "ShowButton"
        Me.ShowButton.Size = New System.Drawing.Size(85, 28)
        Me.ShowButton.TabIndex = 19
        Me.ShowButton.Text = "Show"
        Me.ShowButton.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 80)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(85, 28)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Schedule"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DaysLeftLabel
        '
        Me.DaysLeftLabel.AutoSize = True
        Me.DaysLeftLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.DaysLeftLabel.Location = New System.Drawing.Point(148, 416)
        Me.DaysLeftLabel.Name = "DaysLeftLabel"
        Me.DaysLeftLabel.Size = New System.Drawing.Size(51, 55)
        Me.DaysLeftLabel.TabIndex = 22
        Me.DaysLeftLabel.Text = "0"
        Me.DaysLeftLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'NextShowLabel
        '
        Me.NextShowLabel.AutoSize = True
        Me.NextShowLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.NextShowLabel.Location = New System.Drawing.Point(325, 461)
        Me.NextShowLabel.Name = "NextShowLabel"
        Me.NextShowLabel.Size = New System.Drawing.Size(86, 29)
        Me.NextShowLabel.TabIndex = 23
        Me.NextShowLabel.Text = "Label3"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(12, 148)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(85, 28)
        Me.Button2.TabIndex = 24
        Me.Button2.Text = "Financial"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(799, 543)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.NextShowLabel)
        Me.Controls.Add(Me.DaysLeftLabel)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.ShowRoster)
        Me.Controls.Add(Me.ShowButton)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DateLabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.NewsScreen1)
        Me.Name = "MainMenu"
        Me.Text = "0"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NewsScreen1 As RosterViewer.NewsScreen
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DateLabel As System.Windows.Forms.Label
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents ShowRoster As System.Windows.Forms.Button
    Friend WithEvents ShowButton As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DaysLeftLabel As System.Windows.Forms.Label
    Friend WithEvents NextShowLabel As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
