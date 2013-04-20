<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ShowViewer
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
        Me.templateButton = New System.Windows.Forms.Button()
        Me.newEventButton = New System.Windows.Forms.Button()
        Me.RandomButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RandomShow = New System.Windows.Forms.Button()
        Me.WatchButton = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Header = New RosterViewer.PreviewScreen()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.templateButton)
        Me.Panel1.Location = New System.Drawing.Point(12, 279)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(553, 59)
        Me.Panel1.TabIndex = 3
        '
        'templateButton
        '
        Me.templateButton.Location = New System.Drawing.Point(3, 3)
        Me.templateButton.Name = "templateButton"
        Me.templateButton.Size = New System.Drawing.Size(75, 32)
        Me.templateButton.TabIndex = 0
        Me.templateButton.Text = "Event"
        Me.templateButton.UseVisualStyleBackColor = True
        Me.templateButton.Visible = False
        '
        'newEventButton
        '
        Me.newEventButton.BackColor = System.Drawing.Color.Transparent
        Me.newEventButton.Location = New System.Drawing.Point(10, 210)
        Me.newEventButton.Name = "newEventButton"
        Me.newEventButton.Size = New System.Drawing.Size(550, 23)
        Me.newEventButton.TabIndex = 4
        Me.newEventButton.Text = "newEventButton"
        Me.newEventButton.UseVisualStyleBackColor = False
        '
        'RandomButton
        '
        Me.RandomButton.BackColor = System.Drawing.Color.Transparent
        Me.RandomButton.Location = New System.Drawing.Point(10, 239)
        Me.RandomButton.Name = "RandomButton"
        Me.RandomButton.Size = New System.Drawing.Size(550, 23)
        Me.RandomButton.TabIndex = 5
        Me.RandomButton.Text = "RandomButton"
        Me.RandomButton.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 341)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Today:"
        '
        'RandomShow
        '
        Me.RandomShow.Location = New System.Drawing.Point(447, 344)
        Me.RandomShow.Name = "RandomShow"
        Me.RandomShow.Size = New System.Drawing.Size(118, 41)
        Me.RandomShow.TabIndex = 7
        Me.RandomShow.Text = "Random Show"
        Me.RandomShow.UseVisualStyleBackColor = True
        '
        'WatchButton
        '
        Me.WatchButton.Location = New System.Drawing.Point(485, 14)
        Me.WatchButton.Name = "WatchButton"
        Me.WatchButton.Size = New System.Drawing.Size(75, 23)
        Me.WatchButton.TabIndex = 9
        Me.WatchButton.Text = "Watch"
        Me.WatchButton.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(211, 350)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Header
        '
        Me.Header.AutoSize = True
        Me.Header.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Header.Location = New System.Drawing.Point(6, 9)
        Me.Header.Name = "Header"
        Me.Header.Size = New System.Drawing.Size(559, 267)
        Me.Header.TabIndex = 8
        '
        'ShowViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(571, 393)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.WatchButton)
        Me.Controls.Add(Me.RandomShow)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RandomButton)
        Me.Controls.Add(Me.newEventButton)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Header)
        Me.Name = "ShowViewer"
        Me.Text = "ShowViewer"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents templateButton As System.Windows.Forms.Button
    Friend WithEvents newEventButton As System.Windows.Forms.Button
    Friend WithEvents RandomButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents RandomShow As System.Windows.Forms.Button
    Friend WithEvents Header As RosterViewer.PreviewScreen
    Friend WithEvents WatchButton As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
