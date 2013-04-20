Public Class NewsBase
    Public MyNews As List(Of NewsItem.Message)
    Private Sub Panel1_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
    Public NewsItems() As NewsItem
    Public Sub Recount()
        NewsItem1.Visible = False
        If Not MyNews Is Nothing Then
            Clear()
            ReDim NewsItems(MyNews.Count - 1)
            For i = 0 To MyNews.Count - 1
                NewsItems(i) = New NewsItem
                Panel1.Controls.Add(NewsItems(i))
                NewsItems(i).MyMessage = MyNews.Item(i)
                If i = 0 Then
                    NewsItems(i).Location = NewsItem1.Location
                Else
                    NewsItems(i).Left = NewsItem1.Left
                    NewsItems(i).Top = NewsItems(i - 1).Bottom + 2
                End If
                NewsItems(i).Recount()
            Next
        End If
    End Sub
    Public Sub Clear()
        ' MyNews.Clear()
        Panel1.Controls.Clear()
    End Sub
End Class
