Public Class MatchType
    Public id As Integer
    Public Shared descriptions() As String = {"Normal Match", "No DQ Match", "Over The Top Rope", "Normal Tag Team Match"}
    Enum PresetMatches
        Normal_1x1 = 0
        Normal_2x2 = 1
        Normal_TripleThreat = 2
        Normal_Fatal4Way = 3
        BattleRoyal_6Men = 4
    End Enum
    Public Shared Length As Integer = descriptions.Length
    Shared isExtremearray() As Boolean = {False, True, False}
    Shared isBattleRoyalarray() As Boolean = {False, False, True}
    Public value = descriptions(id)
    Public isBattleRoyal As Boolean = isBattleRoyalarray(id)
    Public isExtreme As Boolean = isExtremearray(id)
    Public Sub recount()
        value = descriptions(id)
        isExtreme = isExtremearray(id)
        isBattleRoyal = isBattleRoyalarray(id)
    End Sub

    Public Shared Function PresetMatch(ByVal Template As PresetMatches) As Match
        Dim M As Match = New Match
        'Dim MT As MatchType = New MatchType
        M.MatchType = New MatchType
        With M
            Select Case Template
                Case PresetMatches.Normal_1x1
                    .isTeamMatch = False
                    .number_of_wrestlers = 2
                    .MatchType.id = 0
                    .MatchType.isBattleRoyal = False
                    .MatchType.isExtreme = False
                Case PresetMatches.Normal_2x2
                    .isTeamMatch = True
                    .number_of_wrestlers = 4
                    .number_of_teams = 2
                    .MatchType.id = 4
                    .MatchType.isBattleRoyal = False
                    .MatchType.isExtreme = False
                    .BelongsToTeam(0) = 0
                    .BelongsToTeam(1) = 0
                    .BelongsToTeam(2) = 1
                    .BelongsToTeam(3) = 1
                Case PresetMatches.Normal_TripleThreat

            End Select
            .MatchType.recount()
            .rebuild()
        End With
        Return M
    End Function
End Class
