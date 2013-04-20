Public Class SelectPPVEvent
    '  Public MyMatch As Match
    Public IsUsed As Boolean
    Public MyMatch As Match
    Public Property OrderText As String
        Get
            Return MatchOrderLabel.Text
        End Get
        Set(value As String)
            MatchOrderLabel.Text = value
        End Set
    End Property
    Private Sub EditButton_Click(sender As Object, e As EventArgs) Handles EditButton.Click

    End Sub

    Private Sub MatchOrderLabel_Click(sender As Object, e As EventArgs) Handles MatchOrderLabel.Click

    End Sub
    Public Sub ShowMatch(ByVal MyMatch As Match)
        Me.MyMatch = MyMatch
        Label1.Text = MyMatch.Name
        Label2.Text = MatchType.descriptions(MyMatch.MatchType.id)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
