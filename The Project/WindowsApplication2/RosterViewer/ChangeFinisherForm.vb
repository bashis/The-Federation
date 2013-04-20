Public Class ChangeFinisherForm

    Private Sub ChangeFinisherForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i = 0 To MData.Moves.Count - 1
            ListBox1.Items.Add(MData.Moves(i).Name)
        Next
    End Sub
    Public Overloads Function Show() As Move
        MyBase.Show()

        Return Nothing
    End Function

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        If Not (ListBox1.SelectedIndex = -1 And ListBox1.Items.Count = 0) Then
            TextBox1.Text = MData.Moves(ListBox1.SelectedIndex).Description
        End If
    End Sub
End Class