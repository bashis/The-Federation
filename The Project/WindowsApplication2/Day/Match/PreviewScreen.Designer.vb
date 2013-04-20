<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PreviewScreen
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
        Me.bg = New System.Windows.Forms.PictureBox()
        CType(Me.bg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bg
        '
        Me.bg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.bg.Location = New System.Drawing.Point(3, 3)
        Me.bg.Name = "bg"
        Me.bg.Size = New System.Drawing.Size(553, 261)
        Me.bg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.bg.TabIndex = 0
        Me.bg.TabStop = False
        '
        'PreviewScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Controls.Add(Me.bg)
        Me.Name = "PreviewScreen"
        Me.Size = New System.Drawing.Size(559, 267)
        CType(Me.bg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bg As System.Windows.Forms.PictureBox

End Class
