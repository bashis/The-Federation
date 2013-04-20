<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PersonnelForm
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.HQTab = New System.Windows.Forms.TabPage()
        Me.TrainersTab = New System.Windows.Forms.TabPage()
        Me.RefTab = New System.Windows.Forms.TabPage()
        Me.OtherTab = New System.Windows.Forms.TabPage()
        Me.CreativeTab = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TabControl1.SuspendLayout()
        Me.HQTab.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.TabControl1.Controls.Add(Me.HQTab)
        Me.TabControl1.Controls.Add(Me.CreativeTab)
        Me.TabControl1.Controls.Add(Me.TrainersTab)
        Me.TabControl1.Controls.Add(Me.RefTab)
        Me.TabControl1.Controls.Add(Me.OtherTab)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(535, 509)
        Me.TabControl1.TabIndex = 0
        '
        'HQTab
        '
        Me.HQTab.Controls.Add(Me.Label3)
        Me.HQTab.Controls.Add(Me.Label4)
        Me.HQTab.Controls.Add(Me.PictureBox2)
        Me.HQTab.Controls.Add(Me.Label2)
        Me.HQTab.Controls.Add(Me.Label1)
        Me.HQTab.Controls.Add(Me.PictureBox1)
        Me.HQTab.Location = New System.Drawing.Point(23, 4)
        Me.HQTab.Name = "HQTab"
        Me.HQTab.Padding = New System.Windows.Forms.Padding(3)
        Me.HQTab.Size = New System.Drawing.Size(508, 501)
        Me.HQTab.TabIndex = 0
        Me.HQTab.Text = "Corporatives"
        Me.HQTab.UseVisualStyleBackColor = True
        '
        'TrainersTab
        '
        Me.TrainersTab.Location = New System.Drawing.Point(23, 4)
        Me.TrainersTab.Name = "TrainersTab"
        Me.TrainersTab.Padding = New System.Windows.Forms.Padding(3)
        Me.TrainersTab.Size = New System.Drawing.Size(696, 501)
        Me.TrainersTab.TabIndex = 1
        Me.TrainersTab.Text = "Trainers"
        Me.TrainersTab.UseVisualStyleBackColor = True
        '
        'RefTab
        '
        Me.RefTab.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.RefTab.Location = New System.Drawing.Point(23, 4)
        Me.RefTab.Name = "RefTab"
        Me.RefTab.Size = New System.Drawing.Size(696, 501)
        Me.RefTab.TabIndex = 2
        Me.RefTab.Text = "Referee"
        Me.RefTab.UseVisualStyleBackColor = True
        '
        'OtherTab
        '
        Me.OtherTab.Location = New System.Drawing.Point(23, 4)
        Me.OtherTab.Name = "OtherTab"
        Me.OtherTab.Size = New System.Drawing.Size(696, 501)
        Me.OtherTab.TabIndex = 3
        Me.OtherTab.Text = "Other"
        Me.OtherTab.UseVisualStyleBackColor = True
        '
        'CreativeTab
        '
        Me.CreativeTab.Location = New System.Drawing.Point(23, 4)
        Me.CreativeTab.Name = "CreativeTab"
        Me.CreativeTab.Padding = New System.Windows.Forms.Padding(3)
        Me.CreativeTab.Size = New System.Drawing.Size(696, 501)
        Me.CreativeTab.TabIndex = 4
        Me.CreativeTab.Text = "Creative Team"
        Me.CreativeTab.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Location = New System.Drawing.Point(6, 116)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(496, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Chief Executive Officer"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(496, 22)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Vince McMahon"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 303)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(137, 22)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Paul Levesque"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.Location = New System.Drawing.Point(7, 284)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(146, 19)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Executive Vice President"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBox2.Location = New System.Drawing.Point(28, 176)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(98, 105)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBox1.Location = New System.Drawing.Point(206, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(98, 105)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PersonnelForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(535, 509)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "PersonnelForm"
        Me.Text = "PersonnelForm"
        Me.TabControl1.ResumeLayout(False)
        Me.HQTab.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents HQTab As System.Windows.Forms.TabPage
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents CreativeTab As System.Windows.Forms.TabPage
    Friend WithEvents TrainersTab As System.Windows.Forms.TabPage
    Friend WithEvents RefTab As System.Windows.Forms.TabPage
    Friend WithEvents OtherTab As System.Windows.Forms.TabPage
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
End Class
