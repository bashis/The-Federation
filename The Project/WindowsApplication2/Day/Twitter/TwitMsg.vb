Public Class TwitMsg
    Public _Sender As String
    Public _Text As String
    Public Sub Recount()
        Label1.Text = _Sender
        Label2.Text = _Text
    End Sub

    Private Sub TwitMsg_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
