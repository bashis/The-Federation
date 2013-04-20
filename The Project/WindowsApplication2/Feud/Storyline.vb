<Serializable()>
Public Class Storyline
    Public Shared Models() As String = {"1x1", "1x2", "2x2", "1x3", "2x3", "3x3", "1x1x1x2"}

    '======================================

    Public Description As String
    Public Name As String
    Public Overall As Double
    Public level As Integer
    Public Model As String
End Class
