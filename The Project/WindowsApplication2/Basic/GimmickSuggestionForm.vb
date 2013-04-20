Public Class GimmickSuggestionForm

    Public MyGimmickSuggestion As GimmickSuggestion
    Private Sub GimmickSuggestionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SuggestionText As String = "Hello, boss!" & vbCrLf & vbCrLf & "I 've come up with a nice new gimmick for me!" & vbCrLf & "What do you think?" & vbCrLf & ""
        TextLabel.Text = SuggestionText
        SRandomize() 'TODO: DELETE THIS
        NameLabel.Text = MyGimmickSuggestion.MyAutor.name

        If Not MyGimmickSuggestion.MyGimmick Is Nothing Then
            Me.Text = MyGimmickSuggestion.MyAutor.name
            ' RatingBox_Old.Text = MyGimmickSuggestion.MyGimmick.Rate & " (" & MyGimmickSuggestion.MyGimmick.BasicIdea & ")"
            RatingBox_Old.Text = "Old Gimmick stats:" & vbCrLf & "Overall: " & MyGimmickSuggestion.MyAutor.Gimmick.Overall & _
                 vbCrLf & "Rating: " & MyGimmickSuggestion.MyAutor.Gimmick.Rate & vbCrLf & "Role: " & MyGimmickSuggestion.MyAutor.Gimmick.IsFaceToString & _
                 vbCrLf & "Last Updated: " & MyGimmickSuggestion.MyAutor.Gimmick.LastUpdated.ToShortDateString
            RatingBox_New.Text = "New Gimmick stats:" & vbCrLf & "Overall: " & MyGimmickSuggestion.MyGimmick.Overall & " (" & PositivePlusString(CInt(MyGimmickSuggestion.MyGimmick.Overall - MyGimmickSuggestion.MyAutor.Gimmick.Overall)) & ")" & _
             vbCrLf & "Rating: " & MyGimmickSuggestion.MyGimmick.Rate & vbCrLf & "Role: " & MyGimmickSuggestion.MyGimmick.IsFaceToString & _
            vbCrLf & "Last Updated: " & MyGimmickSuggestion.MyGimmick.LastUpdated.ToShortDateString

            FaceBox.Image = MData.imcontainer(MData.find_actual_id(MyGimmickSuggestion.MyAutor, MData.SearchType.All)).smallimage
        Else
            Throw New ArgumentException("No gimmick loaded")
        End If

    End Sub
    Function PositivePlusString(ByVal Number As Integer) As String
        If Number > 0 Then
            Return "+" & Number
        End If
        Return Number
    End Function
    Sub SRandomize()
        MyGimmickSuggestion = New GimmickSuggestion
        With MyGimmickSuggestion
            .AutorId_String = MData.mywrestlers(RosterViewerForm.random(0, MData.mywrestlers.Length - 1)).id_string
            .MyGimmick = New Gimmick
            .MyGimmick = Gimmick.Generate(1)
        End With
    End Sub
    Private Sub Panel1_SizeChanged(sender As Object, e As EventArgs) Handles Panel1.SizeChanged
        Panel2.Top = Panel1.Bottom + 5
    End Sub
    Private Sub SAcceptButton_Click(sender As Object, e As EventArgs) Handles SAcceptButton.Click
        MyGimmickSuggestion.SetGimmick(MyGimmickSuggestion.MyGimmick)
        MsgBox(MyGimmickSuggestion.MyAutor.Gimmick.Overall & vbCrLf & MyGimmickSuggestion.MyAutor.id_string & vbCrLf & MyGimmickSuggestion.MyAutor.id)
        Me.Close()
    End Sub

    Private Sub SRefuseButton_Click(sender As Object, e As EventArgs) Handles SRefuseButton.Click
        Me.Close()
    End Sub

    Private Sub SStoreButton_Click(sender As Object, e As EventArgs) Handles SStoreButton.Click
        If MsgBox("Setting the gimmick to another wrestler will decrease " & WStats.description(2).ToLower & " of " & MyGimmickSuggestion.MyAutor.name & vbCrLf & "Are you sure?", MsgBoxStyle.YesNo, "Storing gimmick") = MsgBoxResult.Yes Then
            MyGimmickSuggestion.MyAutor.stats(2) = Math.Max(0, MyGimmickSuggestion.MyAutor.stats(2) - CInt(MyGimmickSuggestion.MyGimmick.BasicIdea / 5))
            Basic.StoredGimmicks.Add(MyGimmickSuggestion)
            MsgBox("Gimmick is now stored")
            Me.Close()
        End If
    End Sub

    Private Sub RatingBox_New_Click(sender As Object, e As EventArgs) Handles RatingBox_New.Click

    End Sub
End Class