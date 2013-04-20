Public Class WStats

    Public Shared description() As String = {"Wrestling", "Microphone",
                                     "Loyality", "Insanity", "Fan-Base", "Push"}
    Public ids As Integer = description.Length - 1

    Public Function descr(ByVal id As Integer)
        'useless
        Return (description(id))
    End Function


    Public Overall As Double
    Public Sub CreatePromo(ByVal Wrestlers() As WModel, ByVal Modifier As Double, ByVal Topic As String)

    End Sub
End Class
