Public Class FullNews
    Public FullMessage As NewsItem.Message
    Public Sub Recount()
        Me.Text = FullMessage.Header
        Content.Text = FullMessage.Text
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Panel1_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class