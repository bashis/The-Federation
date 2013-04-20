Public Class BookPPVForm
    Public MyPPV As Promotion.PayPerView


    Private Sub BookPPVForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RadioButton2.Checked = True
        NameLabel.Text = MyPPV.PName
        DateLabel.Text = MyPPV.PDate & " (" & MyPPV.PDate.Subtract(Basic.CurrentDate).Days & " days left)"
        Interest.Text = MyPPV.Interest
        InterestBar.Value = Math.Min(MyPPV.Interest, 100)
    End Sub
    Private Sub CostSelected(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged, RadioButton3.CheckedChanged, RadioButton1.CheckedChanged
        If RadioButton1.Checked Then
            Costlabel.Text = "$" & DefaultConstants.PPVPromotionCosts(0, 1)
        ElseIf RadioButton2.Checked Then
            Costlabel.Text = "$" & DefaultConstants.PPVPromotionCosts(1, 1)
        Else
            Costlabel.Text = "$" & DefaultConstants.PPVPromotionCosts(2, 1)
        End If
    End Sub

    Private Sub DateLabel_Click(sender As Object, e As EventArgs) Handles DateLabel.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        EditPPVCardForm.Show() 'CreatePPVForm.Show()
    End Sub
End Class