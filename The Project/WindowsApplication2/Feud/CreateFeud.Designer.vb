<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateFeud
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.StorylinePic1 = New RosterViewer.StorylinePic()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(121, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Select the storyline"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'StorylinePic1
        '
        Me.StorylinePic1.AutoSize = True
        Me.StorylinePic1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.StorylinePic1.Location = New System.Drawing.Point(12, 41)
        Me.StorylinePic1.MyWmodel = Nothing
        Me.StorylinePic1.Name = "StorylinePic1"
        Me.StorylinePic1.Size = New System.Drawing.Size(111, 164)
        Me.StorylinePic1.TabIndex = 1
        Me.StorylinePic1.Visible = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(139, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(121, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "OK"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'CreateFeud
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(734, 420)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.StorylinePic1)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "CreateFeud"
        Me.Text = "CreateFeud"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents StorylinePic1 As RosterViewer.StorylinePic
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
