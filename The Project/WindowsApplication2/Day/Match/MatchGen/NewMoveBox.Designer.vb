<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewMoveBox
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NameBox = New System.Windows.Forms.TextBox()
        Me.DescBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.SellerBeforeBox = New System.Windows.Forms.ComboBox()
        Me.AttackerBeforeBox = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.SellerAfterBox = New System.Windows.Forms.ComboBox()
        Me.AttackerAfterBox = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.MoveAppearStateBox = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TemplateCheckbox = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ChanceCB = New System.Windows.Forms.CheckBox()
        Me.NoneBox = New System.Windows.Forms.RadioButton()
        Me.SubmissionBox = New System.Windows.Forms.RadioButton()
        Me.PinBox = New System.Windows.Forms.RadioButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name:"
        '
        'NameBox
        '
        Me.NameBox.Location = New System.Drawing.Point(3, 16)
        Me.NameBox.Name = "NameBox"
        Me.NameBox.Size = New System.Drawing.Size(100, 20)
        Me.NameBox.TabIndex = 1
        '
        'DescBox
        '
        Me.DescBox.Location = New System.Drawing.Point(3, 55)
        Me.DescBox.Multiline = True
        Me.DescBox.Name = "DescBox"
        Me.DescBox.Size = New System.Drawing.Size(293, 119)
        Me.DescBox.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Description:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.SellerBeforeBox)
        Me.GroupBox1.Controls.Add(Me.AttackerBeforeBox)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 180)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(290, 61)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Before the move"
        '
        'SellerBeforeBox
        '
        Me.SellerBeforeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SellerBeforeBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.SellerBeforeBox.Items.AddRange(New Object() {"Standing", "Running", "Lying", "Corner", "Top Corner"})
        Me.SellerBeforeBox.Location = New System.Drawing.Point(163, 32)
        Me.SellerBeforeBox.Name = "SellerBeforeBox"
        Me.SellerBeforeBox.Size = New System.Drawing.Size(121, 21)
        Me.SellerBeforeBox.TabIndex = 3
        '
        'AttackerBeforeBox
        '
        Me.AttackerBeforeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.AttackerBeforeBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.AttackerBeforeBox.Items.AddRange(New Object() {"Standing", "Running", "Lying", "Corner", "Top Corner"})
        Me.AttackerBeforeBox.Location = New System.Drawing.Point(6, 32)
        Me.AttackerBeforeBox.Name = "AttackerBeforeBox"
        Me.AttackerBeforeBox.Size = New System.Drawing.Size(121, 21)
        Me.AttackerBeforeBox.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(163, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Seller"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Attacker"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.SellerAfterBox)
        Me.GroupBox3.Controls.Add(Me.AttackerAfterBox)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 247)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(290, 61)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "After the move"
        '
        'SellerAfterBox
        '
        Me.SellerAfterBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SellerAfterBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.SellerAfterBox.Items.AddRange(New Object() {"Standing", "Running", "Lying", "Corner", "Top Corner"})
        Me.SellerAfterBox.Location = New System.Drawing.Point(163, 32)
        Me.SellerAfterBox.Name = "SellerAfterBox"
        Me.SellerAfterBox.Size = New System.Drawing.Size(121, 21)
        Me.SellerAfterBox.TabIndex = 3
        '
        'AttackerAfterBox
        '
        Me.AttackerAfterBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.AttackerAfterBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.AttackerAfterBox.Items.AddRange(New Object() {"Standing", "Running", "Lying", "Corner", "Top Corner"})
        Me.AttackerAfterBox.Location = New System.Drawing.Point(6, 32)
        Me.AttackerAfterBox.Name = "AttackerAfterBox"
        Me.AttackerAfterBox.Size = New System.Drawing.Size(121, 21)
        Me.AttackerAfterBox.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(163, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Seller"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Attacker"
        '
        'MoveAppearStateBox
        '
        Me.MoveAppearStateBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.MoveAppearStateBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.MoveAppearStateBox.Items.AddRange(New Object() {"Same", "Ring to outside", "Both in the ring", "Both outside"})
        Me.MoveAppearStateBox.Location = New System.Drawing.Point(12, 327)
        Me.MoveAppearStateBox.Name = "MoveAppearStateBox"
        Me.MoveAppearStateBox.Size = New System.Drawing.Size(278, 21)
        Me.MoveAppearStateBox.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 311)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(102, 13)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Move Appear State:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.TemplateCheckbox)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 354)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(290, 116)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Styles"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(78, 87)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(77, 23)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Select none"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(5, 87)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(67, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Select all"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TemplateCheckbox
        '
        Me.TemplateCheckbox.AutoSize = True
        Me.TemplateCheckbox.Location = New System.Drawing.Point(5, 19)
        Me.TemplateCheckbox.Name = "TemplateCheckbox"
        Me.TemplateCheckbox.Size = New System.Drawing.Size(52, 17)
        Me.TemplateCheckbox.TabIndex = 2
        Me.TemplateCheckbox.Text = "Basic"
        Me.TemplateCheckbox.UseVisualStyleBackColor = True
        Me.TemplateCheckbox.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 473)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Chance"
        '
        'ChanceCB
        '
        Me.ChanceCB.Appearance = System.Windows.Forms.Appearance.Button
        Me.ChanceCB.AutoSize = True
        Me.ChanceCB.Location = New System.Drawing.Point(6, 489)
        Me.ChanceCB.Name = "ChanceCB"
        Me.ChanceCB.Size = New System.Drawing.Size(72, 23)
        Me.ChanceCB.TabIndex = 12
        Me.ChanceCB.Text = "CheckBox1"
        Me.ChanceCB.UseVisualStyleBackColor = True
        Me.ChanceCB.Visible = False
        '
        'NoneBox
        '
        Me.NoneBox.AutoSize = True
        Me.NoneBox.Checked = True
        Me.NoneBox.Location = New System.Drawing.Point(6, 3)
        Me.NoneBox.Name = "NoneBox"
        Me.NoneBox.Size = New System.Drawing.Size(51, 17)
        Me.NoneBox.TabIndex = 14
        Me.NoneBox.TabStop = True
        Me.NoneBox.Text = "None"
        Me.NoneBox.UseVisualStyleBackColor = True
        '
        'SubmissionBox
        '
        Me.SubmissionBox.AutoSize = True
        Me.SubmissionBox.Location = New System.Drawing.Point(63, 3)
        Me.SubmissionBox.Name = "SubmissionBox"
        Me.SubmissionBox.Size = New System.Drawing.Size(78, 17)
        Me.SubmissionBox.TabIndex = 15
        Me.SubmissionBox.Text = "Submission"
        Me.SubmissionBox.UseVisualStyleBackColor = True
        '
        'PinBox
        '
        Me.PinBox.AutoSize = True
        Me.PinBox.Location = New System.Drawing.Point(147, 3)
        Me.PinBox.Name = "PinBox"
        Me.PinBox.Size = New System.Drawing.Size(40, 17)
        Me.PinBox.TabIndex = 16
        Me.PinBox.Text = "Pin"
        Me.PinBox.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PinBox)
        Me.Panel1.Controls.Add(Me.NoneBox)
        Me.Panel1.Controls.Add(Me.SubmissionBox)
        Me.Panel1.Location = New System.Drawing.Point(109, 14)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(187, 22)
        Me.Panel1.TabIndex = 17
        '
        'NewMoveBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ChanceCB)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.MoveAppearStateBox)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DescBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.NameBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "NewMoveBox"
        Me.Size = New System.Drawing.Size(304, 543)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents NameBox As System.Windows.Forms.TextBox
    Friend WithEvents DescBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents SellerBeforeBox As System.Windows.Forms.ComboBox
    Friend WithEvents AttackerBeforeBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents SellerAfterBox As System.Windows.Forms.ComboBox
    Friend WithEvents AttackerAfterBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents MoveAppearStateBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TemplateCheckbox As System.Windows.Forms.CheckBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ChanceCB As System.Windows.Forms.CheckBox
    Friend WithEvents NoneBox As System.Windows.Forms.RadioButton
    Friend WithEvents SubmissionBox As System.Windows.Forms.RadioButton
    Friend WithEvents PinBox As System.Windows.Forms.RadioButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel

End Class
