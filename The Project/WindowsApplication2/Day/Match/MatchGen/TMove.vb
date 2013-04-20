<System.Xml.Serialization.XmlRoot("Move")>
<Serializable()>
Public Class Move
    '<Xml.Serialization.XmlArray("ArrayOfMove")>
    Public Shared StyleNames() As String = {"Basic", "Technical", "Highflyer", "Brawler", "Giant", "Powerhouse", "Hardcore"}
    Public id_string As String
    Public AllowedStyles() As Boolean = {True, True, True, True, True, True, True}
    Public Chance As Integer = 2
    Public Enum MoveAppearState
        RingToOutside = 1
        BothRing = 2
        BothOutside = 3
        Same = 0
    End Enum

    Public Name As String = ""
    Public AttachedTo As String

    Public IsPin As Boolean
    Public IsSubmission As Boolean
    Public AppearState As MoveAppearState

    Public AttackerPositionBefore As WModel.Position
    Public SellerPositionBefore As WModel.Position

    Public Description As String = ""

    Public AttackerPositionAfter As WModel.Position
    Public SellerPositionAfter As WModel.Position

    'Public Function Damage() As Integer
    '    Select Case Me.Rang
    '        Case Rangs.Basic
    '            Return 2
    '        Case Rangs.Special
    '            Return 5
    '        Case Rangs.Dangerous
    '            Return 10
    '        Case Rangs.Finisher
    '            Return 40
    '        Case Else
    '            Return 0
    '    End Select
    'End Function

End Class
