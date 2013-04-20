<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Twitter
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
        Me.TemplateTwitMsg = New RosterViewer.TwitMsg()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.AutoScroll = True
        Me.Panel1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.TemplateTwitMsg)
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(195, 378)
        Me.Panel1.TabIndex = 0
        '
        'TemplateTwitMsg
        '
        Me.TemplateTwitMsg.AutoSize = True
        Me.TemplateTwitMsg.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TemplateTwitMsg.BackColor = System.Drawing.Color.Transparent
        Me.TemplateTwitMsg.Location = New System.Drawing.Point(3, 3)
        Me.TemplateTwitMsg.Name = "TemplateTwitMsg"
        Me.TemplateTwitMsg.Size = New System.Drawing.Size(186, 29)
        Me.TemplateTwitMsg.TabIndex = 0
        Me.TemplateTwitMsg.Visible = False
        '
        'Twitter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Twitter"
        Me.Size = New System.Drawing.Size(201, 384)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TemplateTwitMsg As RosterViewer.TwitMsg

End Class
