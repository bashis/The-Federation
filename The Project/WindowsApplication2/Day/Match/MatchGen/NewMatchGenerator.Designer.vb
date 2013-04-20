<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewMatchGenerator
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
        Me.components = New System.ComponentModel.Container()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.StyleBox1 = New System.Windows.Forms.ComboBox()
        Me.StyleBox2 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextTimer = New System.Windows.Forms.Timer(Me.components)
        Me.InterferenceCB = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.EnableTimer = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.TimeLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.PBar = New System.Windows.Forms.ToolStripProgressBar()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 33)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = "John Cena"
        Me.TextBox1.Visible = False
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(12, 76)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 1
        Me.TextBox2.Text = "The Rock"
        Me.TextBox2.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Wrestler 1:"
        Me.Label1.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Wrestler 2:"
        Me.Label2.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(397, 13)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 57)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Generate"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox3
        '
        Me.TextBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox3.Location = New System.Drawing.Point(12, 76)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox3.Size = New System.Drawing.Size(570, 531)
        Me.TextBox3.TabIndex = 5
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(492, 13)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(89, 57)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Moves Editor"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'StyleBox1
        '
        Me.StyleBox1.FormattingEnabled = True
        Me.StyleBox1.Location = New System.Drawing.Point(118, 32)
        Me.StyleBox1.Name = "StyleBox1"
        Me.StyleBox1.Size = New System.Drawing.Size(121, 21)
        Me.StyleBox1.TabIndex = 7
        Me.StyleBox1.Visible = False
        '
        'StyleBox2
        '
        Me.StyleBox2.FormattingEnabled = True
        Me.StyleBox2.Location = New System.Drawing.Point(118, 76)
        Me.StyleBox2.Name = "StyleBox2"
        Me.StyleBox2.Size = New System.Drawing.Size(121, 21)
        Me.StyleBox2.TabIndex = 8
        Me.StyleBox2.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(118, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Style:"
        Me.Label3.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(118, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Style:"
        Me.Label4.Visible = False
        '
        'TextTimer
        '
        Me.TextTimer.Interval = 1000
        '
        'InterferenceCB
        '
        Me.InterferenceCB.AutoSize = True
        Me.InterferenceCB.Location = New System.Drawing.Point(244, 36)
        Me.InterferenceCB.Name = "InterferenceCB"
        Me.InterferenceCB.Size = New System.Drawing.Size(130, 17)
        Me.InterferenceCB.TabIndex = 15
        Me.InterferenceCB.Text = "Interference (The Miz)"
        Me.InterferenceCB.UseVisualStyleBackColor = True
        Me.InterferenceCB.Visible = False
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(241, 627)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Speed:"
        '
        'TrackBar1
        '
        Me.TrackBar1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.TrackBar1.LargeChange = 1
        Me.TrackBar1.Location = New System.Drawing.Point(155, 643)
        Me.TrackBar1.Minimum = 1
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(219, 45)
        Me.TrackBar1.TabIndex = 17
        Me.TrackBar1.Value = 2
        '
        'EnableTimer
        '
        Me.EnableTimer.AutoSize = True
        Me.EnableTimer.Checked = True
        Me.EnableTimer.CheckState = System.Windows.Forms.CheckState.Checked
        Me.EnableTimer.Location = New System.Drawing.Point(244, 59)
        Me.EnableTimer.Name = "EnableTimer"
        Me.EnableTimer.Size = New System.Drawing.Size(52, 17)
        Me.EnableTimer.TabIndex = 16
        Me.EnableTimer.Text = "Timer"
        Me.EnableTimer.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.CheckBox1.Appearance = System.Windows.Forms.Appearance.Button
        Me.CheckBox1.Location = New System.Drawing.Point(380, 613)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(49, 41)
        Me.CheckBox1.TabIndex = 19
        Me.CheckBox1.Text = "Pause"
        Me.CheckBox1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.Location = New System.Drawing.Point(506, 613)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 41)
        Me.Button3.TabIndex = 20
        Me.Button3.Text = "Save"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TimeLabel, Me.PBar})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 681)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(594, 22)
        Me.StatusStrip1.TabIndex = 21
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'TimeLabel
        '
        Me.TimeLabel.Name = "TimeLabel"
        Me.TimeLabel.Size = New System.Drawing.Size(22, 17)
        Me.TimeLabel.Text = "0:0"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(12, 10)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(94, 64)
        Me.Button4.TabIndex = 22
        Me.Button4.Text = "Generate New"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'PBar
        '
        Me.PBar.Name = "PBar"
        Me.PBar.Size = New System.Drawing.Size(500, 16)
        '
        'NewMatchGenerator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(594, 703)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TrackBar1)
        Me.Controls.Add(Me.EnableTimer)
        Me.Controls.Add(Me.InterferenceCB)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.StyleBox2)
        Me.Controls.Add(Me.StyleBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "NewMatchGenerator"
        Me.Text = "Form1"
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents StyleBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents StyleBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextTimer As System.Windows.Forms.Timer
    Friend WithEvents InterferenceCB As System.Windows.Forms.CheckBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TrackBar1 As System.Windows.Forms.TrackBar
    Friend WithEvents EnableTimer As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents TimeLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents PBar As System.Windows.Forms.ToolStripProgressBar

End Class
