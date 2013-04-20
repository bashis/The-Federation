<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Calendar
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
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.prom_chooser = New System.Windows.Forms.ComboBox()
        Me.newsh = New System.Windows.Forms.Button()
        Me.template = New System.Windows.Forms.PictureBox()
        Me.back = New System.Windows.Forms.PictureBox()
        CType(Me.template, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.back, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(3, 3)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 1
        Me.DateTimePicker1.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.Location = New System.Drawing.Point(-3, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Label1"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(409, 31)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = ">"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(0, 31)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "<"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(81, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(319, 23)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "January 2012"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(81, 31)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "Today"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'prom_chooser
        '
        Me.prom_chooser.FormattingEnabled = True
        Me.prom_chooser.Location = New System.Drawing.Point(3, 171)
        Me.prom_chooser.Name = "prom_chooser"
        Me.prom_chooser.Size = New System.Drawing.Size(134, 21)
        Me.prom_chooser.TabIndex = 7
        '
        'newsh
        '
        Me.newsh.Location = New System.Drawing.Point(143, 169)
        Me.newsh.Name = "newsh"
        Me.newsh.Size = New System.Drawing.Size(136, 23)
        Me.newsh.TabIndex = 8
        Me.newsh.Text = "New Show"
        Me.newsh.UseVisualStyleBackColor = True
        '
        'template
        '
        Me.template.Location = New System.Drawing.Point(0, 85)
        Me.template.Name = "template"
        Me.template.Size = New System.Drawing.Size(122, 80)
        Me.template.TabIndex = 0
        Me.template.TabStop = False
        '
        'back
        '
        Me.back.BackColor = System.Drawing.Color.Gray
        Me.back.Location = New System.Drawing.Point(298, 13)
        Me.back.Name = "back"
        Me.back.Size = New System.Drawing.Size(38, 50)
        Me.back.TabIndex = 9
        Me.back.TabStop = False
        '
        'Calendar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.Controls.Add(Me.newsh)
        Me.Controls.Add(Me.prom_chooser)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.template)
        Me.Controls.Add(Me.back)
        Me.Name = "Calendar"
        Me.Size = New System.Drawing.Size(487, 195)
        CType(Me.template, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.back, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents template As System.Windows.Forms.PictureBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents prom_chooser As System.Windows.Forms.ComboBox
    Friend WithEvents newsh As System.Windows.Forms.Button
    Friend WithEvents back As System.Windows.Forms.PictureBox

End Class
