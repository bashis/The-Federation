Public Class NewsItem
    Public Structure Message
        Dim Header As String
        Dim Text As String
    End Structure
    Public MyMessage As Message
    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs) Handles Label1.Click
        Dim MyFullNews As FullNews = New FullNews
        MyFullNews.FullMessage = MyMessage
        MyFullNews.Recount()
        MyFullNews.Show()
    End Sub
    Public Sub Recount()
        Label1.Text = MyMessage.Header
    End Sub
End Class
