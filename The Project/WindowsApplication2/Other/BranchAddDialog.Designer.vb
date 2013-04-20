<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BranchAddDialog
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.But_Cancel = New System.Windows.Forms.Button()
        Me.But_OK = New System.Windows.Forms.Button()
        Me.Lbl_Prompt = New System.Windows.Forms.Label()
        Me.Txt_TextEntry = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.But_Cancel, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.But_OK, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(221, 138)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'But_Cancel
        '
        Me.But_Cancel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.But_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.But_Cancel.Location = New System.Drawing.Point(76, 3)
        Me.But_Cancel.Name = "But_Cancel"
        Me.But_Cancel.Size = New System.Drawing.Size(67, 23)
        Me.But_Cancel.TabIndex = 1
        Me.But_Cancel.Text = "Cancel"
        '
        'But_OK
        '
        Me.But_OK.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.But_OK.Location = New System.Drawing.Point(3, 3)
        Me.But_OK.Name = "But_OK"
        Me.But_OK.Size = New System.Drawing.Size(67, 23)
        Me.But_OK.TabIndex = 0
        Me.But_OK.Text = "OK"
        '
        'Lbl_Prompt
        '
        Me.Lbl_Prompt.AutoSize = True
        Me.Lbl_Prompt.Location = New System.Drawing.Point(12, 10)
        Me.Lbl_Prompt.Name = "Lbl_Prompt"
        Me.Lbl_Prompt.Size = New System.Drawing.Size(33, 13)
        Me.Lbl_Prompt.TabIndex = 1
        Me.Lbl_Prompt.Text = "Label"
        '
        'Txt_TextEntry
        '
        Me.Txt_TextEntry.Location = New System.Drawing.Point(12, 26)
        Me.Txt_TextEntry.Multiline = True
        Me.Txt_TextEntry.Name = "Txt_TextEntry"
        Me.Txt_TextEntry.Size = New System.Drawing.Size(355, 101)
        Me.Txt_TextEntry.TabIndex = 2
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"None"})
        Me.ComboBox1.Location = New System.Drawing.Point(15, 146)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(200, 21)
        Me.ComboBox1.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 130)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Special:"
        '
        'BranchAddDialog
        '
        Me.AcceptButton = Me.But_OK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.But_Cancel
        Me.ClientSize = New System.Drawing.Size(375, 175)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Txt_TextEntry)
        Me.Controls.Add(Me.Lbl_Prompt)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "BranchAddDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Add Spot"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents But_OK As System.Windows.Forms.Button
    Friend WithEvents But_Cancel As System.Windows.Forms.Button
    Friend WithEvents Lbl_Prompt As System.Windows.Forms.Label
    Friend WithEvents Txt_TextEntry As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
