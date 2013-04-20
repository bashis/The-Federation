Public Class wPushComparer : Implements IComparer(Of Integer)


    Public Function Compare(x As Integer, y As Integer) As Integer Implements IComparer(Of Integer).Compare
        If x > y Then
            Return 1
        ElseIf x < y Then
            Return -1
        Else
            Return 0
        End If
    End Function
End Class
