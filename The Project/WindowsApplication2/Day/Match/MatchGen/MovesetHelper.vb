Public Class MovesetHelper
    Dim MyCollection As List(Of Move) = New List(Of Move)
    Dim _currentIndex As Integer
    Property CurrentIndex As Integer
        Get
            Return _currentIndex
        End Get
        Set(value As Integer)
            _currentIndex = value
            If value < 0 Then _currentIndex = 0
            If value > MyCollection.Count - 1 Then _currentIndex = MyCollection.Count - 1
            TextBox1.Text = MyCollection(_currentIndex).Description
            Label1.Text = _currentIndex + 1 & "/" & MyCollection.Count


            Dim t As String = "Currently: "
            If MyCollection(_currentIndex).IsPin Then t += "Pin "
            If MyCollection(_currentIndex).IsSubmission Then t += "Submission"
            If t = "Currently: " Then t += "None"
            Label2.Text = t

            Label3.Text = "Met: "
            If TextBox1.Text.ToLower.Contains("pin") Then Label3.Text += "Pin "
            If TextBox1.Text.ToLower.Contains("submission") Then Label3.Text += "Submission "

        End Set
    End Property
    Private Sub MovesetHelper_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each m As Move In MData.Moves
            If m.Description.ToLower.Contains("pinn") Or m.Description.ToLower.Contains("pinf") Or m.Description.ToLower.Contains("pin ") _
             Or m.Description.ToLower.Contains(" pin") Or m.Description.ToLower.Contains("submission") Or m.Description.ToLower.Contains("cover") Then
                MyCollection.Add(m)
            End If
        Next

        If MyCollection.Count = 0 Then
            MsgBox("There are no moves available")
            Me.Close()
        Else
            CurrentIndex = 0
        End If
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        CurrentIndex -= 1
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        CurrentIndex += 1
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MyCollection(CurrentIndex).IsPin = False
        MyCollection(CurrentIndex).IsSubmission = False
        CurrentIndex += 1
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MyCollection(CurrentIndex).IsPin = True
        MyCollection(CurrentIndex).IsSubmission = False
        CurrentIndex += 1
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MyCollection(CurrentIndex).IsPin = False
        MyCollection(CurrentIndex).IsSubmission = True
        CurrentIndex += 1
    End Sub
End Class