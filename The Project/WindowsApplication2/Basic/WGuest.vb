Public Class WGuest

    Public Enum Guest
        Legend = 1
        Star = 2
    End Enum

    Public type As Guest  '1 - Legend, 2 - Guest Star
    Public Name As String
    Public Description As String

    Public Charisma As Integer '1 to 100
    Public Wrestling As Integer '1 to 100

    Public Loyality(Basic.Promotions.Count - 1) As Integer
    Public CostModifier As Integer

    Public Pic As Image

End Class
