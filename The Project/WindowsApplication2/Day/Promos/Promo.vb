Public Class Promo
    Public Enum PromoResult
        None = 0
        Push = 1
        ChangeGimmick = 2
    End Enum

    Public Offence As Integer
    Public Text As String
    Public Shared BasicIntros() As String = {"[1] is in the middle of the ring. He takes the mic. "}
    Public Shared Beginnings() As String
    'Public Shared Responses("[2] replies that ") As String
    Public NewGimmick As Gimmick 'OPTIONAL
    Public Animosity As Integer
    Public Result As PromoResult
    Public Response As Boolean
    Public Attacker As WModel
    Public Seller As WModel
    'Public Sub MakeResult()
    '    Select Case Result
    '        Case PromoResult.ChangeGimmick
    '            Attacker.Gimmick = NewGimmick
    '        Case Else
    '    End Select
    'End Sub
End Class
