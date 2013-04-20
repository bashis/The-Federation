Public Class BasicStats
    Public Shared MovesDBPath As String = Application.StartupPath & "\moves.tfm"
    Public Shared BloodEnabled As Boolean = True
    Public Shared FallsCountAnywhere As Boolean = False
    Public Shared MaxHealth As Integer
    Public Shared PinChance As Double '= 0.2
    Public Shared IncreasedPinChance As Double ' = 0.5
    Public Shared SubmissionChance As Double ' = 0.4
    Public Shared FinisherSubmissionChance As Double ' = 0.7
    Public Shared BasicMoveChance As Double = 0.3
    Public Shared KickOutOfRAGEMODEChance As Double = 0.0
    Public Shared AfterMatchMomentChance As Double = 0.4

    Public Shared Sub Restore()
        If Not isInterferrence Then
            PinChance = 0.2
            IncreasedPinChance = 0.5
            SubmissionChance = 0.4
            FinisherSubmissionChance = 0.7
        End If
    End Sub

    Public Shared Sub MakeImpossibleWin()
        BasicStats.PinChance = 0
        BasicStats.SubmissionChance = 0
        BasicStats.IncreasedPinChance = 0
        BasicStats.FinisherSubmissionChance = 0
    End Sub
    Public Shared isInterferrence As Boolean = False
    ''' <summary>
    '''
    ''' How soon the interfere happens.
    ''' </summary>
    ''' 
    Public Shared InterfereChance As Double = 0.7




End Class
