<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditPPVCardForm
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ReleasePanelTemplate = New System.Windows.Forms.Panel()
        Me.TemplatePPVEvent = New RosterViewer.SelectPPVEvent()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.TemplatePPVEvent)
        Me.Panel1.Controls.Add(Me.ReleasePanelTemplate)
        Me.Panel1.Location = New System.Drawing.Point(12, 25)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(607, 639)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Currently booked matches:"
        '
        'ReleasePanelTemplate
        '
        Me.ReleasePanelTemplate.Location = New System.Drawing.Point(3, 3)
        Me.ReleasePanelTemplate.Name = "ReleasePanelTemplate"
        Me.ReleasePanelTemplate.Size = New System.Drawing.Size(575, 80)
        Me.ReleasePanelTemplate.TabIndex = 1
        Me.ReleasePanelTemplate.Visible = False
        '
        'TemplatePPVEvent
        '
        Me.TemplatePPVEvent.AutoSize = True
        Me.TemplatePPVEvent.BackColor = System.Drawing.SystemColors.Control
        Me.TemplatePPVEvent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TemplatePPVEvent.Location = New System.Drawing.Point(3, 3)
        Me.TemplatePPVEvent.Name = "TemplatePPVEvent"
        Me.TemplatePPVEvent.OrderText = "1st Match"
        Me.TemplatePPVEvent.Size = New System.Drawing.Size(575, 78)
        Me.TemplatePPVEvent.TabIndex = 0
        Me.TemplatePPVEvent.Visible = False
        '
        'EditPPVCardForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(650, 676)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "EditPPVCardForm"
        Me.Text = "EditPPVCardForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TemplatePPVEvent As RosterViewer.SelectPPVEvent
    Friend WithEvents ReleasePanelTemplate As System.Windows.Forms.Panel
End Class
