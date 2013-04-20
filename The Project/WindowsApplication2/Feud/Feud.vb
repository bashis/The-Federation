<Serializable()>
Public Class Feud
    Public Teams() As List(Of WModel)
    Dim _Overall As Double
    Public StartDate As Date
    Public Storyline As Storyline

    Public ReadOnly Property Length As Integer
        Get
            Return DateDiff(DateInterval.Day, StartDate, Basic.CurrentDate)
        End Get
    End Property

    Public Property Overall As Double
        Get
            Return _Overall
        End Get
        Set(value As Double)
            _Overall = value
        End Set
    End Property

    Public Sub New(ByVal NumberOfTeams As Integer)
        ReDim Teams(NumberOfTeams - 1)
        Overall = 0
        StartDate = Basic.CurrentDate

    End Sub
End Class
