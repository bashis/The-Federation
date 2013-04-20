Public Class Twitter
    Public Messages As List(Of Message)
    Public Structure Message
        Dim Sender As String
        Dim Text As String
    End Structure
    Dim Twitts() As TwitMsg
    Public Sub Recount()

        If Not Messages Is Nothing Then
            TemplateTwitMsg.Visible = False
            ReDim Twitts(Messages.Count - 1)
            Panel1.Controls.Clear()
            For i = 0 To Messages.Count - 1
                Twitts(i) = New TwitMsg
                Twitts(i)._Text = Messages(i).Text
                Twitts(i)._Sender = NameToTwit(Messages(i).Sender)
                Twitts(i).Recount()
                Panel1.Controls.Add(Twitts(i))
                If i = 0 Then
                    Twitts(i).Location = TemplateTwitMsg.Location
                Else
                    Twitts(i).Left = TemplateTwitMsg.Left
                    Twitts(i).Top = Twitts(i - 1).Bottom + 2
                End If
            Next
        End If
    End Sub
 
    Public Shared Function NameToTwit(ByVal Name As String) As String
        Dim res As String = Name.Replace(" ", "")
        res = "@" & res
        Return res
    End Function

    'Collections:



    Private Sub TemplateTwitMsg_Load(sender As System.Object, e As System.EventArgs) Handles TemplateTwitMsg.Load

    End Sub
End Class
