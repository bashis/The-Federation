Public Class MoveEditForm

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Try
            NewMoveBox1.Save()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        MovesEditor.Sort()
        MovesEditor.RefreshButtons()
        Me.Close()
    End Sub

    Private Sub MoveEditForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class