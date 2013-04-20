Public Class Weapon
 
    Public Name As String
    Public Appears As NewMatchGenerator.appearState
    Public AttackAction() As String '= {"...", "..."}
    Public TakeAction() As String '= {"", ""}
    Public TakeAwayAction() As String ' = {"", ""}
    Public ThrowAwayAction() As String ' = {"", ""}

    Public Sub New(ByVal Name As String, ByVal Appears As NewMatchGenerator.appearState, ByVal TakeAction() As String, ByVal AttackAction() As String, ByVal TakeAwayAction() As String, ByVal ThrowAwayAction() As String)
        Me.Name = Name
        Me.Appears = Appears
        Me.TakeAction = TakeAction
        Me.AttackAction = AttackAction
        Me.ThrowAwayAction = ThrowAwayAction
        Me.TakeAwayAction = TakeAwayAction
    End Sub

    Public Function Random(ByVal arr As Object) As String
        If arr Is Nothing Then
            Return ""
        End If

        If arr.Length = 0 Then
            Return ""
        Else
            Return arr(randomNumber(0, arr.Length - 1))
        End If

    End Function
    Private Function randomNumber(ByVal lowerbound As Integer, ByVal upperbound As Integer)
        Randomize()
        Dim randomvalue As Integer
        randomvalue = CInt(Math.Floor((upperbound - lowerbound + 1) * Rnd())) + lowerbound
        Return randomvalue
    End Function
End Class
