Public Class WModel
    Public Invincibility As Double

    Public id As Integer
    Public id_string As String
    Public name As String
    Public AlternativeNames As List(Of String)
    Public description As String
    Public Finisher As String

    Public Promotion As Integer
    Public ContractExpires As Date

    Public Appearance As WAppearance

    Public FeudAllies() As WModel
    Public FeudEnemies() As WModel

    Public Tired As Double
    Public Relationship As Double

    Public Gimmick As Gimmick



    Public height As String
    Public weight As String

    Public Titles(DefaultConstants.n_of_titles) As Integer

    '=================
    Dim number_of_perks_on As Integer = DefaultConstants.n_of_perks_at_once
    Public perks(number_of_perks_on) As Integer
    Public s_perk As Integer 'superperk's id
    '=================
    Dim number_of_stats As Integer = DefaultConstants.n_of_stats
    Public stats(number_of_stats) As Integer
    '=================
    Public style As Integer
    '=================
    Public picture As Image

    Public WinningSeries As Integer
    Public LosingSeries As Integer

    '=================Appearance

    Public ActiveContract As Boolean
    '=================/Appearance

    Public Shared Function bring_id_to_string_form(ByVal i As Object) As String
        Dim t As String = i.ToString
        If t.Length < 4 Then
            While t.Length < 4
                t = "0" & t
            End While
            Return t
        ElseIf t.Length > 4 Then
            Return (t.Substring(0, 4))
        Else
            Return t
        End If
    End Function

    '=========MATCH STUFF=================================
#Region "MatchStuff"
    Public Enum Position
        Standing = 0
        Running = 1
        Lying = 2
        Corner = 3
        TopCorner = 4
    End Enum

    Public RingState As NewMatchGenerator.appearState
    Public MyPosition As Position
    Public IsBleeding As Boolean = False

    <Xml.Serialization.XmlIgnore>
    Public Health As Health = New Health(Me)

    Public FinisherPoints As Integer = 0
    Public Finishers As List(Of String)
    ' Public MyFinisher As FinisherStr
    ' Public style As Integer
    Public Structure FinisherStr
        Dim Name As String
        Dim Position As Position
        Dim IsSubmission As Boolean
        Dim Description As String
        Dim IsPin As Boolean
    End Structure
    '/==========MATCH STUFF=======================================
#End Region


End Class
