<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewsScreen
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ShortTemplate = New System.Windows.Forms.Panel()
        Me.TemplateLabel = New System.Windows.Forms.Label()
        Me.WTemplate = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TextPanel = New System.Windows.Forms.Panel()
        Me.BodyLabel = New System.Windows.Forms.Label()
        Me.HeadLabel = New System.Windows.Forms.Label()
        Me.wrestler_image = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.ShortTemplate.SuspendLayout()
        CType(Me.WTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TextPanel.SuspendLayout()
        CType(Me.wrestler_image, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.BackColor = System.Drawing.Color.DarkBlue
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.ShortTemplate)
        Me.Panel1.Location = New System.Drawing.Point(3, 265)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(553, 100)
        Me.Panel1.TabIndex = 1
        '
        'ShortTemplate
        '
        Me.ShortTemplate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ShortTemplate.Controls.Add(Me.TemplateLabel)
        Me.ShortTemplate.Controls.Add(Me.WTemplate)
        Me.ShortTemplate.Location = New System.Drawing.Point(3, 2)
        Me.ShortTemplate.Name = "ShortTemplate"
        Me.ShortTemplate.Size = New System.Drawing.Size(158, 75)
        Me.ShortTemplate.TabIndex = 2
        Me.ShortTemplate.Visible = False
        '
        'TemplateLabel
        '
        Me.TemplateLabel.BackColor = System.Drawing.Color.Black
        Me.TemplateLabel.ForeColor = System.Drawing.Color.White
        Me.TemplateLabel.Location = New System.Drawing.Point(-1, 58)
        Me.TemplateLabel.Name = "TemplateLabel"
        Me.TemplateLabel.Size = New System.Drawing.Size(157, 18)
        Me.TemplateLabel.TabIndex = 1
        Me.TemplateLabel.Text = "Label1"
        Me.TemplateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.TemplateLabel.Visible = False
        '
        'WTemplate
        '
        Me.WTemplate.Location = New System.Drawing.Point(43, 4)
        Me.WTemplate.Name = "WTemplate"
        Me.WTemplate.Size = New System.Drawing.Size(60, 71)
        Me.WTemplate.TabIndex = 0
        Me.WTemplate.TabStop = False
        Me.WTemplate.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        'Me.PictureBox1.Image = Global.RosterViewer.My.Resources.Resources.bg_nxt
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(553, 261)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'TextPanel
        '
        Me.TextPanel.BackColor = System.Drawing.Color.Black
        Me.TextPanel.Controls.Add(Me.BodyLabel)
        Me.TextPanel.Controls.Add(Me.HeadLabel)
        Me.TextPanel.Location = New System.Drawing.Point(3, 3)
        Me.TextPanel.Name = "TextPanel"
        Me.TextPanel.Size = New System.Drawing.Size(200, 261)
        Me.TextPanel.TabIndex = 3
        '
        'BodyLabel
        '
        Me.BodyLabel.AutoSize = True
        Me.BodyLabel.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.BodyLabel.ForeColor = System.Drawing.Color.White
        Me.BodyLabel.Location = New System.Drawing.Point(4, 38)
        Me.BodyLabel.MaximumSize = New System.Drawing.Size(180, 0)
        Me.BodyLabel.Name = "BodyLabel"
        Me.BodyLabel.Size = New System.Drawing.Size(41, 20)
        Me.BodyLabel.TabIndex = 1
        Me.BodyLabel.Text = "Body"
        '
        'HeadLabel
        '
        Me.HeadLabel.AutoSize = True
        Me.HeadLabel.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.HeadLabel.ForeColor = System.Drawing.Color.White
        Me.HeadLabel.Location = New System.Drawing.Point(3, 11)
        Me.HeadLabel.MaximumSize = New System.Drawing.Size(180, 0)
        Me.HeadLabel.Name = "HeadLabel"
        Me.HeadLabel.Size = New System.Drawing.Size(84, 33)
        Me.HeadLabel.TabIndex = 0
        Me.HeadLabel.Text = "Head"
        '
        'wrestler_image
        '
        Me.wrestler_image.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.wrestler_image.BackColor = System.Drawing.Color.Transparent
        Me.wrestler_image.Location = New System.Drawing.Point(270, 6)
        Me.wrestler_image.Name = "wrestler_image"
        Me.wrestler_image.Size = New System.Drawing.Size(221, 261)
        Me.wrestler_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.wrestler_image.TabIndex = 4
        Me.wrestler_image.TabStop = False
        '
        'NewsScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Controls.Add(Me.wrestler_image)
        Me.Controls.Add(Me.TextPanel)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "NewsScreen"
        Me.Size = New System.Drawing.Size(559, 368)
        Me.Panel1.ResumeLayout(False)
        Me.ShortTemplate.ResumeLayout(False)
        CType(Me.WTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TextPanel.ResumeLayout(False)
        Me.TextPanel.PerformLayout()
        CType(Me.wrestler_image, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ShortTemplate As System.Windows.Forms.Panel
    Friend WithEvents TextPanel As System.Windows.Forms.Panel
    Friend WithEvents HeadLabel As System.Windows.Forms.Label
    Friend WithEvents BodyLabel As System.Windows.Forms.Label
    Friend WithEvents wrestler_image As System.Windows.Forms.PictureBox
    Friend WithEvents WTemplate As System.Windows.Forms.PictureBox
    Friend WithEvents TemplateLabel As System.Windows.Forms.Label

End Class
