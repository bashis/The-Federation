Public Class MyWrestler
    Public Enum Position
        Standing = 0
        Running = 1
        Lying = 2
        Corner = 3
        TopCorner = 4
    End Enum
    Public Name As String
    Public RingState As NewMatchGenerator.appearState
    Public MyPosition As Position
    Public IsBleeding As Boolean = False
    ' Public Health As Health = New Health(Me)
    Public FinisherPoints As Integer = 0
    Public MyFinisher As Finisher
    Public style As Integer
    Public Structure Finisher
        Dim Name As String
        Dim Position As Position
        Dim IsSubmission As Boolean
        Dim Description As String
        Dim IsPin As Boolean
    End Structure

    'Public Sub DealDamage(ByVal organ As Health.Organ, ByVal Ammount As Integer)
    '    Select Case organ
    '        Case Global.RosterViewer.Health.Organ.Head
    '            Me.Health.Head -= Ammount
    '        Case Global.RosterViewer.Health.Organ.Body
    '            Me.Health.Body -= Ammount
    '        Case Global.RosterViewer.Health.Organ.Arms
    '            Me.Health.Arms -= Ammount
    '        Case Global.RosterViewer.Health.Organ.Legs
    '            Me.Health.Legs -= Ammount
    '    End Select
    ' End Sub

End Class