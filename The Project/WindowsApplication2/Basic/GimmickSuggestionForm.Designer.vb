<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GimmickSuggestionForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GimmickSuggestionForm))
        Me.FaceBox = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TextLabel = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.RatingBox_Old = New System.Windows.Forms.Label()
        Me.SAcceptButton = New System.Windows.Forms.Button()
        Me.SRefuseButton = New System.Windows.Forms.Button()
        Me.SStoreButton = New System.Windows.Forms.Button()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.RatingBox_New = New System.Windows.Forms.Label()
        CType(Me.FaceBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'FaceBox
        '
        Me.FaceBox.BackColor = System.Drawing.Color.Black
        Me.FaceBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FaceBox.Image = CType(resources.GetObject("FaceBox.Image"), System.Drawing.Image)
        Me.FaceBox.Location = New System.Drawing.Point(12, 12)
        Me.FaceBox.Name = "FaceBox"
        Me.FaceBox.Size = New System.Drawing.Size(100, 107)
        Me.FaceBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.FaceBox.TabIndex = 2
        Me.FaceBox.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.AutoSize = True
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.TextLabel)
        Me.Panel1.Location = New System.Drawing.Point(118, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(321, 53)
        Me.Panel1.TabIndex = 3
        '
        'TextLabel
        '
        Me.TextLabel.AutoSize = True
        Me.TextLabel.Location = New System.Drawing.Point(4, 7)
        Me.TextLabel.MaximumSize = New System.Drawing.Size(300, 0)
        Me.TextLabel.Name = "TextLabel"
        Me.TextLabel.Size = New System.Drawing.Size(44, 13)
        Me.TextLabel.TabIndex = 0
        Me.TextLabel.Text = "%Text%"
        '
        'Panel2
        '
        Me.Panel2.AutoSize = True
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.RatingBox_New)
        Me.Panel2.Controls.Add(Me.RatingBox_Old)
        Me.Panel2.Location = New System.Drawing.Point(118, 82)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(321, 80)
        Me.Panel2.TabIndex = 4
        '
        'RatingBox_Old
        '
        Me.RatingBox_Old.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.RatingBox_Old.Location = New System.Drawing.Point(3, 0)
        Me.RatingBox_Old.Name = "RatingBox_Old"
        Me.RatingBox_Old.Size = New System.Drawing.Size(145, 64)
        Me.RatingBox_Old.TabIndex = 5
        Me.RatingBox_Old.Text = "%"
        '
        'SAcceptButton
        '
        Me.SAcceptButton.Location = New System.Drawing.Point(12, 209)
        Me.SAcceptButton.Name = "SAcceptButton"
        Me.SAcceptButton.Size = New System.Drawing.Size(427, 31)
        Me.SAcceptButton.TabIndex = 5
        Me.SAcceptButton.Text = "OK, this gimmick is all yours!"
        Me.SAcceptButton.UseVisualStyleBackColor = True
        '
        'SRefuseButton
        '
        Me.SRefuseButton.Location = New System.Drawing.Point(12, 246)
        Me.SRefuseButton.Name = "SRefuseButton"
        Me.SRefuseButton.Size = New System.Drawing.Size(427, 31)
        Me.SRefuseButton.TabIndex = 6
        Me.SRefuseButton.Text = "I don't think this is a good idea..."
        Me.SRefuseButton.UseVisualStyleBackColor = True
        '
        'SStoreButton
        '
        Me.SStoreButton.Location = New System.Drawing.Point(12, 283)
        Me.SStoreButton.Name = "SStoreButton"
        Me.SStoreButton.Size = New System.Drawing.Size(427, 31)
        Me.SStoreButton.TabIndex = 7
        Me.SStoreButton.Text = "The gimmick is nice, but it will suit another wrestler better"
        Me.SStoreButton.UseVisualStyleBackColor = True
        '
        'NameLabel
        '
        Me.NameLabel.Location = New System.Drawing.Point(12, 122)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(100, 23)
        Me.NameLabel.TabIndex = 8
        Me.NameLabel.Text = "%NAME%"
        Me.NameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'RatingBox_New
        '
        Me.RatingBox_New.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.RatingBox_New.Location = New System.Drawing.Point(171, 0)
        Me.RatingBox_New.Name = "RatingBox_New"
        Me.RatingBox_New.Size = New System.Drawing.Size(145, 64)
        Me.RatingBox_New.TabIndex = 7
        Me.RatingBox_New.Text = "%"
        '
        'GimmickSuggestionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(451, 324)
        Me.Controls.Add(Me.NameLabel)
        Me.Controls.Add(Me.SStoreButton)
        Me.Controls.Add(Me.SRefuseButton)
        Me.Controls.Add(Me.SAcceptButton)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.FaceBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "GimmickSuggestionForm"
        Me.Text = "GimmickSuggestionForm"
        CType(Me.FaceBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FaceBox As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TextLabel As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents RatingBox_Old As System.Windows.Forms.Label
    Friend WithEvents SAcceptButton As System.Windows.Forms.Button
    Friend WithEvents SRefuseButton As System.Windows.Forms.Button
    Friend WithEvents SStoreButton As System.Windows.Forms.Button
    Friend WithEvents NameLabel As System.Windows.Forms.Label
    Friend WithEvents RatingBox_New As System.Windows.Forms.Label
End Class
