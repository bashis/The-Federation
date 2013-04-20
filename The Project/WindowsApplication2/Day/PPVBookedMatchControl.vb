Public Class PPVBookedMatchControl
    Dim MyMatch As Match
    Dim Order As String
    Private Sub PPVBookedMatchControl_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not MyMatch Is Nothing Then
            Label1.Text = Order
            Label1.Text = MyMatch.Name
            Label2.Text = MatchType.descriptions(MyMatch.MatchType.id)
        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub MatchOrderLabel_Click(sender As Object, e As EventArgs) Handles MatchOrderLabel.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
