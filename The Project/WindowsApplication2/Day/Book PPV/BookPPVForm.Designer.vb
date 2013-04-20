<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BookPPVForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BookPPVForm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.DateLabel = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PpvBookedMatchControl2 = New RosterViewer.PPVBookedMatchControl()
        Me.PpvBookedMatchControl1 = New RosterViewer.PPVBookedMatchControl()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Costlabel = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Interest = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.InterestBar = New RosterViewer.MTech010VerticalProgessBar()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.Location = New System.Drawing.Point(-1, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(697, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "The upcoming Pay-Per-View:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'NameLabel
        '
        Me.NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.NameLabel.Location = New System.Drawing.Point(-1, 40)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(697, 50)
        Me.NameLabel.TabIndex = 1
        Me.NameLabel.Text = "[PPVNAME]"
        Me.NameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'DateLabel
        '
        Me.DateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.DateLabel.Location = New System.Drawing.Point(-1, 80)
        Me.DateLabel.Name = "DateLabel"
        Me.DateLabel.Size = New System.Drawing.Size(697, 31)
        Me.DateLabel.TabIndex = 2
        Me.DateLabel.Text = "[PPVDATE]"
        Me.DateLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Current booking:"
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.PpvBookedMatchControl2)
        Me.Panel1.Controls.Add(Me.PpvBookedMatchControl1)
        Me.Panel1.Location = New System.Drawing.Point(6, 137)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(423, 407)
        Me.Panel1.TabIndex = 4
        '
        'PpvBookedMatchControl2
        '
        Me.PpvBookedMatchControl2.AutoSize = True
        Me.PpvBookedMatchControl2.Location = New System.Drawing.Point(-1, 83)
        Me.PpvBookedMatchControl2.Name = "PpvBookedMatchControl2"
        Me.PpvBookedMatchControl2.Size = New System.Drawing.Size(449, 72)
        Me.PpvBookedMatchControl2.TabIndex = 1
        '
        'PpvBookedMatchControl1
        '
        Me.PpvBookedMatchControl1.AutoSize = True
        Me.PpvBookedMatchControl1.Location = New System.Drawing.Point(-1, 3)
        Me.PpvBookedMatchControl1.Name = "PpvBookedMatchControl1"
        Me.PpvBookedMatchControl1.Size = New System.Drawing.Size(449, 72)
        Me.PpvBookedMatchControl1.TabIndex = 0
        '
        'RadioButton2
        '
        Me.RadioButton2.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(70, 29)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(57, 23)
        Me.RadioButton2.TabIndex = 8
        Me.RadioButton2.Text = "Standart"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(144, 29)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(63, 23)
        Me.RadioButton3.TabIndex = 9
        Me.RadioButton3.Text = "Extensive"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(4, 29)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(43, 23)
        Me.RadioButton1.TabIndex = 10
        Me.RadioButton1.Text = "Minor"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.RadioButton1)
        Me.Panel2.Controls.Add(Me.RadioButton3)
        Me.Panel2.Controls.Add(Me.RadioButton2)
        Me.Panel2.Controls.Add(Me.Costlabel)
        Me.Panel2.Location = New System.Drawing.Point(434, 137)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(212, 60)
        Me.Panel2.TabIndex = 11
        '
        'Costlabel
        '
        Me.Costlabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Costlabel.Location = New System.Drawing.Point(3, 3)
        Me.Costlabel.Name = "Costlabel"
        Me.Costlabel.Size = New System.Drawing.Size(192, 23)
        Me.Costlabel.TabIndex = 11
        Me.Costlabel.Text = "Cost"
        Me.Costlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(435, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Promotion:"
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Interest)
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Controls.Add(Me.InterestBar)
        Me.Panel3.Location = New System.Drawing.Point(434, 227)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(212, 350)
        Me.Panel3.TabIndex = 13
        '
        'Interest
        '
        Me.Interest.AutoSize = True
        Me.Interest.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Interest.Location = New System.Drawing.Point(52, 244)
        Me.Interest.Name = "Interest"
        Me.Interest.Size = New System.Drawing.Size(151, 108)
        Me.Interest.TabIndex = 1
        Me.Interest.Text = "50"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(53, 97)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(128, 137)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'InterestBar
        '
        Me.InterestBar.Location = New System.Drawing.Point(4, 3)
        Me.InterestBar.Name = "InterestBar"
        Me.InterestBar.Size = New System.Drawing.Size(43, 342)
        Me.InterestBar.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(435, 211)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Interest rating:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(6, 550)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(423, 23)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Set Matches"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BookPPVForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(650, 589)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DateLabel)
        Me.Controls.Add(Me.NameLabel)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "BookPPVForm"
        Me.Text = "BookPPVForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents NameLabel As System.Windows.Forms.Label
    Friend WithEvents DateLabel As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Costlabel As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Interest As System.Windows.Forms.Label
    Friend WithEvents InterestBar As RosterViewer.MTech010VerticalProgessBar
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PpvBookedMatchControl2 As RosterViewer.PPVBookedMatchControl
    Friend WithEvents PpvBookedMatchControl1 As RosterViewer.PPVBookedMatchControl
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
