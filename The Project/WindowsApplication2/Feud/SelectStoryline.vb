Public Class SelectStoryline
    Public selectedStoryline As Storyline
    Private Sub SelectStoryline_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load


        ListView1.Items.Clear()
        ListView1.Columns.Add("Name")
        ListView1.Columns.Add("Description")
        ListView1.Columns.Add("Model")
        ListView1.Columns.Add("Level")



        For i = 0 To Pre_made_Storylines.MyStoryLines.Count - 1
            Dim lbi As ListViewItem = New ListViewItem
            With Pre_made_Storylines.MyStoryLines(i)
                lbi.Text = .Name
                lbi.SubItems.Add(.Description)
                lbi.SubItems.Add(.Model)
                lbi.SubItems.Add(.level)
            End With
            ListView1.Items.Add(lbi)
        Next



    End Sub




    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Try
            selectedStoryline = Pre_made_Storylines.MyStoryLines(ListView1.SelectedItems(0).Index)
            If Not Me.selectedStoryline Is Nothing Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
                MsgBox(selectedStoryline.Name)
                Me.Close()
            Else
                MsgBox("You have not selected the storyline!")
            End If
        Catch ex As Exception
            MsgBox("You have not selected the storyline!")
        End Try
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListView1.SelectedIndexChanged
        '        If Not Pre_made_Storylines.MyStoryLines Is Nothing Then
        'selectedStoryline = Pre_made_Storylines.MyStoryLines(ListView1.SelectedItems(0).Index)
        'End If

    End Sub
End Class