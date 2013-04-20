<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DayForm
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
        Me.ShowButton = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateText = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ShowRoster = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.NewsScreen1 = New RosterViewer.NewsScreen()
        Me.NewsBase1 = New RosterViewer.NewsBase()
        Me.Twitter1 = New RosterViewer.Twitter()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 80)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(85, 28)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Schedule"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ShowButton
        '
        Me.ShowButton.Location = New System.Drawing.Point(12, 46)
        Me.ShowButton.Name = "ShowButton"
        Me.ShowButton.Size = New System.Drawing.Size(85, 28)
        Me.ShowButton.TabIndex = 1
        Me.ShowButton.Text = "Show"
        Me.ShowButton.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button3.Location = New System.Drawing.Point(691, 376)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(201, 23)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Update"
        Me.Button3.UseVisualStyleBackColor = True
        Me.Button3.Visible = False
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(688, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(201, 23)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "@Twitter"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button4.Location = New System.Drawing.Point(452, 376)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(230, 23)
        Me.Button4.TabIndex = 6
        Me.Button4.Text = "Update"
        Me.Button4.UseVisualStyleBackColor = True
        Me.Button4.Visible = False
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(455, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(230, 23)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "News"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'DateText
        '
        Me.DateText.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DateText.AutoSize = True
        Me.DateText.Location = New System.Drawing.Point(9, 386)
        Me.DateText.Name = "DateText"
        Me.DateText.Size = New System.Drawing.Size(50, 13)
        Me.DateText.TabIndex = 8
        Me.DateText.Text = "Date text"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(668, 316)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(85, 63)
        Me.Button5.TabIndex = 9
        Me.Button5.Text = "Next Day ->"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(354, 57)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ShowRoster
        '
        Me.ShowRoster.Location = New System.Drawing.Point(12, 12)
        Me.ShowRoster.Name = "ShowRoster"
        Me.ShowRoster.Size = New System.Drawing.Size(85, 28)
        Me.ShowRoster.TabIndex = 11
        Me.ShowRoster.Text = "Roster"
        Me.ShowRoster.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(12, 114)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(85, 28)
        Me.Button6.TabIndex = 12
        Me.Button6.Text = "Pay-Per-View"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'NewsScreen1
        '
        Me.NewsScreen1.AutoSize = True
        Me.NewsScreen1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.NewsScreen1.Location = New System.Drawing.Point(103, 12)
        Me.NewsScreen1.Name = "NewsScreen1"
        Me.NewsScreen1.Size = New System.Drawing.Size(559, 368)
        Me.NewsScreen1.TabIndex = 13
        '
        'NewsBase1
        '
        Me.NewsBase1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.NewsBase1.Location = New System.Drawing.Point(455, 30)
        Me.NewsBase1.Name = "NewsBase1"
        Me.NewsBase1.Size = New System.Drawing.Size(230, 349)
        Me.NewsBase1.TabIndex = 5
        Me.NewsBase1.Visible = False
        '
        'Twitter1
        '
        Me.Twitter1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Twitter1.AutoScroll = True
        Me.Twitter1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Twitter1.Location = New System.Drawing.Point(691, 30)
        Me.Twitter1.Name = "Twitter1"
        Me.Twitter1.Size = New System.Drawing.Size(201, 349)
        Me.Twitter1.TabIndex = 2
        Me.Twitter1.Visible = False
        '
        'DayForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(757, 403)
        Me.Controls.Add(Me.NewsScreen1)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.ShowRoster)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.DateText)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.NewsBase1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Twitter1)
        Me.Controls.Add(Me.ShowButton)
        Me.Controls.Add(Me.Button1)
        Me.Name = "DayForm"
        Me.Text = "DayForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ShowButton As System.Windows.Forms.Button
    Friend WithEvents Twitter1 As RosterViewer.Twitter
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents NewsBase1 As RosterViewer.NewsBase
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DateText As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ShowRoster As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents NewsScreen1 As RosterViewer.NewsScreen
End Class
