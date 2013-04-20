<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MoveEditForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MoveEditForm))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.NewMoveBox1 = New Global.RosterViewer.NewMoveBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 554)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(290, 59)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "OK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'NewMoveBox1
        '
        Me.NewMoveBox1.Location = New System.Drawing.Point(12, 7)
        Me.NewMoveBox1.MyMove = CType(resources.GetObject("NewMoveBox1.MyMove"), Global.RosterViewer.Move)
        Me.NewMoveBox1.Name = "NewMoveBox1"
        Me.NewMoveBox1.Size = New System.Drawing.Size(290, 552)
        Me.NewMoveBox1.TabIndex = 0
        '
        'MoveEditForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(310, 624)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.NewMoveBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "MoveEditForm"
        Me.Text = "MoveEditForm"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents NewMoveBox1 As Global.RosterViewer.NewMoveBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
