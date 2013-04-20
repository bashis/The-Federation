<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DayWatcher
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
        Me.template = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ul1 = New System.Windows.Forms.Label()
        Me.ul2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ul3 = New System.Windows.Forms.Label()
        CType(Me.template, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'template
        '
        Me.template.Location = New System.Drawing.Point(12, 12)
        Me.template.Name = "template"
        Me.template.Size = New System.Drawing.Size(122, 80)
        Me.template.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.template.TabIndex = 1
        Me.template.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(140, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Show:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(140, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Promotion:"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(187, 115)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "OK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ul1
        '
        Me.ul1.AutoSize = True
        Me.ul1.Location = New System.Drawing.Point(194, 12)
        Me.ul1.Name = "ul1"
        Me.ul1.Size = New System.Drawing.Size(15, 13)
        Me.ul1.TabIndex = 5
        Me.ul1.Text = "%"
        '
        'ul2
        '
        Me.ul2.AutoSize = True
        Me.ul2.Location = New System.Drawing.Point(174, 34)
        Me.ul2.Name = "ul2"
        Me.ul2.Size = New System.Drawing.Size(15, 13)
        Me.ul2.TabIndex = 6
        Me.ul2.Text = "%"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(140, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Date:"
        '
        'ul3
        '
        Me.ul3.AutoSize = True
        Me.ul3.Location = New System.Drawing.Point(170, 69)
        Me.ul3.Name = "ul3"
        Me.ul3.Size = New System.Drawing.Size(15, 13)
        Me.ul3.TabIndex = 8
        Me.ul3.Text = "%"
        '
        'DayWatcher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(268, 143)
        Me.Controls.Add(Me.ul3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ul2)
        Me.Controls.Add(Me.ul1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.template)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "DayWatcher"
        Me.Text = "Information"
        CType(Me.template, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents template As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ul1 As System.Windows.Forms.Label
    Friend WithEvents ul2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ul3 As System.Windows.Forms.Label
End Class
