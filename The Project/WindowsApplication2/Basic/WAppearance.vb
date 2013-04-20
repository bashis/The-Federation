Imports Microsoft.VisualBasic

<Serializable()>
Public Class WAppearance
    Enum hairState
        Growing
        FullyGrown
        Shaved
    End Enum



    Public HasMask As Boolean
    Public HasMaskSince As Date

    Public WearsHair As hairState
    Public WearsHairSince As Date

    Public Shared Function RandomAppearance() As WAppearance
        Dim result As WAppearance = New WAppearance
        Dim MaskChance As Double = 0.05
        Dim HairChance As Double = 0.8
        If NewMatchGenerator.ChanceDrops(MaskChance) Then
            result.HasMask = True
        Else
            result.HasMask = False
        End If

        If NewMatchGenerator.ChanceDrops(HairChance) Then
            result.WearsHair = hairState.FullyGrown
        Else
            result.WearsHair = hairState.Shaved
        End If

        result.HasMaskSince = Basic.CurrentDate
        result.WearsHairSince = Basic.CurrentDate
        Return result
    End Function
End Class
