<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StoredGimmicksForm
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.StoredGimmickControl1 = New RosterViewer.StoredGimmickControl()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.StoredGimmickControl1)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(480, 450)
        Me.Panel1.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Location = New System.Drawing.Point(15, 468)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Attach"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'StoredGimmickControl1
        '
        Me.StoredGimmickControl1.BackColor = System.Drawing.Color.LightYellow
        Me.StoredGimmickControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.StoredGimmickControl1.Location = New System.Drawing.Point(2, 3)
        Me.StoredGimmickControl1.Name = "StoredGimmickControl1"
        Me.StoredGimmickControl1.Size = New System.Drawing.Size(237, 120)
        Me.StoredGimmickControl1.TabIndex = 0
        Me.StoredGimmickControl1.Visible = False
        '
        'StoredGimmicksForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(504, 513)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "StoredGimmicksForm"
        Me.Text = "StoredGimmicksForm"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents StoredGimmickControl1 As RosterViewer.StoredGimmickControl
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
