Option Explicit On
Public Class RoyalRumbleForm
    Structure RRParticipant
        Public Wrestler As WModel
        Public EntranceNumber As UShort
        Public TimeInTheRing As UShort
        Public EliminatedNumber As UShort
        Public OpponentsEliminated As UShort
    End Structure
    Public ReservedRRParticipants As List(Of RRParticipant) = New List(Of RRParticipant)
    Public WrestlersToCompete As List(Of WModel) = New List(Of WModel)
    Dim Participants As List(Of RRParticipant) = New List(Of RRParticipant)
    Dim ParticipantsInTheRing As List(Of RRParticipant) = New List(Of RRParticipant)
    Dim resultStr As String = ""
    Dim wButtons(WrestlersToCompete.Count - 1) As Button
    Sub LoadButtons()
        For i = 0 To wButtons.Count - 1
            wButtons(i) = New Button
            With wButtons(i)

                .Text = ""
                .Height = OnTheRingBtnTmp.Height
                .Width = OnTheRingBtnTmp.Width
                .Font = OnTheRingBtnTmp.Font
                If i = 0 Then
                    .Left = OnTheRingBtnTmp.Left
                    .Top = OnTheRingBtnTmp.Top
                Else
                    .Left = OnTheRingBtnTmp.Left
                    .Top = wButtons(i - 1).Bottom + 2
                End If
                .Visible = False
                Panel1.Controls.Add(wButtons(i))
                AddHandler wButtons(i).Click, AddressOf ShowWInfo
            End With
        Next
    End Sub
    Sub UpdateNames()
        For Each b As Button In Panel1.Controls
            Dim index As Integer = Array.IndexOf(wButtons, b)
            If index > ParticipantsInTheRing.Count - 1 Then
                b.Visible = False
            Else
                If Not index = -1 Then
                    b.Text = ParticipantsInTheRing(index).Wrestler.name
                    b.Visible = True
                Else
                    b.Visible = False
                End If
            End If
        Next
        'Label4.Text = resultStr
    End Sub
    Dim entrIndex As Integer = 0
    Sub Generate()
        Timer1.Start()
    End Sub
    Sub CreateParticipantsList()
        For Each w As WModel In WrestlersToCompete
            For Each r As RRParticipant In ReservedRRParticipants
                If w.id_string = r.Wrestler.id_string Then
                    WrestlersToCompete.Remove(w)
                    Exit For
                End If
            Next
        Next

        Dim NumberOfParticipants As UShort = WrestlersToCompete.Count + ReservedRRParticipants.Count
        If NumberOfParticipants = 0 Then
            Throw New ArgumentException("Nobody competes in this match!")
            Exit Sub
        End If

        Dim isAdded As Boolean
        For i = 1 To NumberOfParticipants
            isAdded = False
            For Each w As RRParticipant In ReservedRRParticipants
                If w.EntranceNumber = i Then
                    Participants.Add(w)
                    ReservedRRParticipants.Remove(w)
                    isAdded = True
                    Exit For
                End If
            Next

            If Not isAdded Then
                If Not WrestlersToCompete.Count = 0 Then
                    Dim w As WModel = WrestlersToCompete(RosterViewerForm.random(0, WrestlersToCompete.Count - 1))
                    Dim newParticipant As RRParticipant
                    newParticipant.Wrestler = w
                    newParticipant.EntranceNumber = i
                    Participants.Add(newParticipant)
                    WrestlersToCompete.Remove(w)
                Else
                    Participants.Add(ReservedRRParticipants(MinNumberAt(ReservedRRParticipants)))
                    ReservedRRParticipants.RemoveAt(MinNumberAt(ReservedRRParticipants))
                End If
            End If

        Next



    End Sub
    Function MinNumberAt(ByVal Rlist As List(Of RRParticipant))
        If Rlist.Count = 0 Then Return -1
        Dim Min As UShort = Rlist(0).EntranceNumber
        Dim MinIndex As UShort = 0
        For i = 1 To Rlist.Count - 1
            If Rlist(i).EntranceNumber < Min Then
                Min = Rlist(i).EntranceNumber
                MinIndex = i
            End If
        Next
        Return MinIndex
    End Function
    Sub NewEntrant(ByVal index As Integer)
        resultStr += Participants(index).Wrestler.name & " enters the ring! " & vbCrLf
        ParticipantsInTheRing.Add(Participants(index))
        Participants.Remove(Participants(index))
        UpdateNames()
    End Sub
    Dim EliminationCounter As UShort = 1
    Sub Eliminate(ByRef Attacker As RRParticipant, ByRef Seller As RRParticipant)
        Attacker.OpponentsEliminated = 1
        resultStr += Attacker.Wrestler.name & " eliminates " & Seller.Wrestler.name & "! " & vbCrLf
        ParticipantsInTheRing.Remove(Seller)

        UpdateNames()

        Seller.EliminatedNumber = EliminationCounter
        Label2.Text += EliminationCounter & ") " & Seller.Wrestler.name & " (by " & Attacker.Wrestler.name & ") " & vbCrLf

        EliminationCounter += 1
    End Sub
    Private Sub RoyalRumbleForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Sub Initialize()
        For i = 1 To 40
            WrestlersToCompete.Add(MData.mywrestlers(NewMatchGenerator.random(0, MData.mywrestlers.Count - 1)))
        Next

        Label2.Text = ""
        ReDim wButtons(WrestlersToCompete.Count - 1)
        CreateParticipantsList()
        LoadButtons()

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Initialize()
        Generate()
    End Sub
    Dim finished As Boolean
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Dim chanceOfEntrant As Double = IIf(ParticipantsInTheRing.Count <= 1, 1, 0.5)

        If (NewMatchGenerator.ChanceDrops(chanceOfEntrant) And Participants.Count > 0) Then
            NewEntrant(entrIndex)
        Else
            Dim Attacker As RRParticipant = ParticipantsInTheRing(NewMatchGenerator.random(0, ParticipantsInTheRing.Count - 1))
            Dim PotentialSellers As List(Of RRParticipant) = New List(Of RRParticipant)
            For Each w As RRParticipant In ParticipantsInTheRing
                If Not Attacker.Equals(w) Then
                    PotentialSellers.Add(w)
                End If
            Next
            Dim Seller As RRParticipant = PotentialSellers(NewMatchGenerator.random(0, PotentialSellers.Count - 1))
            Eliminate(Attacker, Seller)
        End If

        If ((ParticipantsInTheRing.Count = 1) And (Participants.Count = 0)) Then finished = True

        If finished Then
            resultStr += ParticipantsInTheRing(0).Wrestler.name & " wins the Royal Rumble! "
            Timer1.Stop()
        End If

        Label4.Text = resultStr

        Panel2.AutoScrollPosition = New Point(0, 100000)
        Panel3.AutoScrollPosition = New Point(0, 100000)
    End Sub
    Sub ShowWInfo(sender As Object, e As EventArgs)
        Try

            Dim index As Integer = Array.IndexOf(wButtons, sender)
            Dim InfoForm As New RoyalRumbleWInfoForm(ParticipantsInTheRing(index))
            InfoForm.Show()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub OnTheRingBtnTmp_Click(sender As Object, e As EventArgs) Handles OnTheRingBtnTmp.Click

    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        If TrackBar1.Value = 0 Then
            Timer1.Stop()
        Else
            Dim TInterval As Integer = (TrackBar1.Maximum + 1 - TrackBar1.Value) * 1135 - 1115
            Timer1.Interval = TInterval
            If Not finished Then
                Timer1.Stop()
                Timer1.Start()
            End If
        End If

    End Sub
End Class