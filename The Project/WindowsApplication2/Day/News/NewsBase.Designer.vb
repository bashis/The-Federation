<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewsBase
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
        Me.NewsItem1 = New RosterViewer.NewsItem()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.AutoScroll = True
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.NewsItem1)
        Me.Panel1.Location = New System.Drawing.Point(0, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(226, 439)
        Me.Panel1.TabIndex = 0
        '
        'NewsItem1
        '
        Me.NewsItem1.AutoSize = True
        Me.NewsItem1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.NewsItem1.BackColor = System.Drawing.Color.Transparent
        Me.NewsItem1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NewsItem1.Location = New System.Drawing.Point(4, 4)
        Me.NewsItem1.Name = "NewsItem1"
        Me.NewsItem1.Size = New System.Drawing.Size(217, 20)
        Me.NewsItem1.TabIndex = 0
        '
        'NewsBase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Name = "NewsBase"
        Me.Size = New System.Drawing.Size(229, 445)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents NewsItem1 As RosterViewer.NewsItem

End Class
