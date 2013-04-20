Public Class Gimmick
    Public isFace As Boolean
    Public BasicIdea As Double
    Public LastUpdated As Date
    
    Public Function UpdateLength() As Integer
        Return (Date.Compare(Basic.CurrentDate, LastUpdated))
    End Function

    Public Function Overall() As Double
        Return Math.Max(BasicIdea - UpdateLength() / 6, 0)
    End Function

    Public Shared Function Generate(ByVal modifier As Double) As Gimmick
        Dim result As Gimmick = New Gimmick
        result.LastUpdated = Basic.CurrentDate
        result.BasicIdea = Math.Min(100, RosterViewerForm.random(10, 100) * modifier)

        Dim res As Integer = RosterViewerForm.random(0, 1)

        If res = 0 Then
            result.isFace = False
        Else
            result.isFace = True
        End If

        Return result
    End Function

    Public Function Rate() As String

        Select Case Overall()
            Case Is < 10
                Return "Horrible"
            Case Is < 30
                Return "Poor"
            Case Is < 50
                Return "Average"
            Case Is < 65
                Return "Nice"
            Case Is < 90
                Return "Awesome"
            Case Is >= 90
                Return "Perfect"
            Case Else
                Return ""
        End Select
    End Function
    Public Function IsFaceToString() As String
        If isFace Then
            Return "Face"
        Else
            Return "Heel"
        End If
    End Function
End Class
