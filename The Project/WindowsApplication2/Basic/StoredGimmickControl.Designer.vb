<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StoredGimmickControl
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
        Me.InfoBox = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'InfoBox
        '
        Me.InfoBox.Location = New System.Drawing.Point(3, 9)
        Me.InfoBox.Name = "InfoBox"
        Me.InfoBox.Size = New System.Drawing.Size(231, 97)
        Me.InfoBox.TabIndex = 0
        Me.InfoBox.Text = "%"
        Me.InfoBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'StoredGimmickControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.InfoBox)
        Me.Name = "StoredGimmickControl"
        Me.Size = New System.Drawing.Size(237, 120)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents InfoBox As System.Windows.Forms.Label

End Class
