Public Class NewGimmickSelector
    Public MyGimmick As Gimmick

    Private Sub NewGimmickSelector_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
    Public Sub ShowContent()
        Dim role As String
        If MyGimmick.isFace Then
            role = "Face"
        Else
            role = "Heel"
        End If
        description.Text = "Idea: " & CInt(MyGimmick.BasicIdea) & vbCrLf & "Role: " & role
    End Sub
End Class
