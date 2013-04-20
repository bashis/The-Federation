Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Xml.Serialization
Public Class NewMatchGenerator
    Public Enum ShowMode
        Match = 0
        Promo = 1
        FullShow = 2
    End Enum
    Public MyShowMode As ShowMode
    Public MyMatch As Match
    Public MyPromo As Promo
    Public MyShow As Show
    ' Public Moves As List(Of Move) = New List(Of Move)
    Public Wrestlers As List(Of WModel) = New List(Of WModel)
    Public Winner As Integer
    Dim SeparatedText() As String
    Dim CurrentSeparatedIndex As Integer = 0

    Public MinTime As Integer = 180 'IN SECONDS
    Public MaxTime As Integer = 360 'IN SECONDS

    Public Enum appearState
        Inside
        Outside
    End Enum
    Public Enum Position
        InRing = 0
        OutRing = 1
    End Enum
    ' Public WeaponsInRing() As Boolean
    ' Public WeaponsOutRing() As Boolean
    Dim GeneratedText As String = ""
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        TextTimer.Stop()
        TextBox3.Text = ""
        Generate()
    End Sub
    Private Sub Generate()
        Me.Wrestlers = New List(Of WModel)
        Select Case MyShowMode
            Case ShowMode.Match
                Me.Wrestlers.AddRange(MyMatch.wrestlers)
                If MyMatch.Text = "" Then
                    MyMatch.Text = GenerateMatch(MyMatch, Winner)
                End If
                SeparatedText = MakeSeparatedText(MyMatch.Text)
            Case ShowMode.Promo
                Me.Wrestlers.Add(MyPromo.Attacker)
                Me.Wrestlers.Add(MyPromo.Seller)
                If MyPromo.Text = "" Then
                    GeneratePromo()
                    MyPromo.Text = GeneratedText
                End If
            Case Else
                If MyShow.Text = "" Then
                    MyShow.Text = GenerateShow(MyShow)
                End If
                SeparatedText = MakeSeparatedText(MyShow.Text)
        End Select
        ShowText()
    End Sub
    Public Function GenerateShow(ByVal MyShow As Show) As String
        Dim result As String = RndStr(ShowIntros).Replace("[SHOW]", Basic.Promotions(Basic.Promotion).ShowNames(Basic.CurrentDate.DayOfWeek)).Replace("[PPV_DISTANCE]", (Basic.Promotions(Basic.Promotion).PPVs(0).PDate.Subtract(Basic.CurrentDate).Days) & " days away from " & Basic.Promotions(Basic.Promotion).PPVs(0).PName).Replace("...", "_[Split]").Replace(".", ".[Split]").Replace("_", "...").Replace("!!!", "_[Split]").Replace("!", "![Split]").Replace("_", "!!!")


        result += vbCrLf
        result += vbCrLf
        For i = 0 To MyShow.Events.Length - 1
            If MyShow.Events(i) = 1 Then

                If i = 0 Then
                    result += RndStr(FirstMatchIntros).Replace("[MN]", MyShow.Matches(i).Name).Replace("vs.", "[VS]").Replace("...", "_[Split]").Replace(".", ".[Split]").Replace("_", "...").Replace("!!!", "_[Split]").Replace("!", "![Split]").Replace("_", "!!!").Replace("[VS]", "vs.")
                ElseIf i = MyShow.Events.Length - 1 Then
                    result += RndStr(MainEventIntros).Replace("[MN]", MyShow.Matches(i).Name).Replace("vs.", "[VS]").Replace("...", "_[Split]").Replace(".", ".[Split]").Replace("_", "...").Replace("!!!", "_[Split]").Replace("!", "![Split]").Replace("_", "!!!").Replace("[VS]", "vs.")
                Else
                    result += RndStr(MatchIntros).Replace("[MN]", MyShow.Matches(i).Name).Replace("vs.", "[VS]").Replace("...", "_[Split]").Replace(".", ".[Split]").Replace("_", "...").Replace("!!!", "_[Split]").Replace("!", "![Split]").Replace("_", "!!!").Replace("[VS]", "vs.")
                End If
                result += vbCrLf
                result += vbCrLf
                result += GenerateMatch(MyShow.Matches(i), random(0, 1)) 'TODO: FIX RANDOM!!!!!!
                result += vbCrLf
                result += vbCrLf
            ElseIf MyShow.Events(i) = 2 Then
                result += GeneratePromo()
                result += vbCrLf
                result += vbCrLf
            End If
            '    MsgBox(MyShow.Events(i))
        Next
        Return result
    End Function
    Private ShowIntros() As String = {"Welcome to [SHOW], ladies and gentlemen! We are just [PPV_DISTANCE] and the show's got to be awesome!",
                                     "Ladies and Gentlemen, welcome to [SHOW]!!! We are just [PPV_DISTANCE] and the show has to be awesome!"}
    Private MatchIntros() As String = {"Coming to the following match, which is [MN]!"}
    Private FirstMatchIntros() As String = {"Coming to the first match, which is [MN]!"}
    Private MainEventIntros() As String = {"Coming to the Main Event of the evening, which is [MN]!"}

    Public Weapons As List(Of Weapon) = New List(Of Weapon)
    Public Sub InitializeWeapons()
        Dim w As Weapon = New Weapon("baseball bat", NewMatchGenerator.appearState.Outside, {"[1] goes under the ring and comes out with the baseball bat!"}, _
                                     {"[1] Smashes the head of [2] with the baseball bat!!!"}, _
                                     {"[2] tries to attack [1] with the baseball bat, but [1] counters and takes it away!"}, _
                                     {"[1] throws the baseball bat away"})
        Weapons.Add(w)

    End Sub


    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        MovesEditor.Show()
    End Sub
    Public SavedBasicStats As BasicStats
    Private Sub NewMatchGenerator_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        TextBox3.ReadOnly = True
        TextBox3.BackColor = System.Drawing.SystemColors.Window
        StyleBox1.Items.AddRange(Global.RosterViewer.Move.StyleNames)
        StyleBox2.Items.AddRange(Global.RosterViewer.Move.StyleNames)
        StyleBox1.SelectedIndex = 0
        StyleBox2.SelectedIndex = 0
        '    LoadMoves()
        Generate()
    End Sub
    'Public Sub InitializeFinisher(ByRef W As WModel, ByVal Name As String, ByVal Description As String, ByVal Position As WModel.Position, ByVal IsSubmission As Boolean, ByVal IsPin As Boolean)
    '    W.MyFinisher = New WModel.FinisherStr
    '    W.MyFinisher.Description = Description
    '    W.MyFinisher.Name = Name
    '    W.MyFinisher.IsSubmission = IsSubmission
    '    W.MyFinisher.IsPin = IsPin
    'End Sub

    Public Function GenerateMatch(ByRef thisMatch As Match, ByVal WinnerIndex As Integer) As String
        Dim result As String = ""
        If InterferenceCB.Checked Then
            BasicStats.isInterferrence = True
        Else
            BasicStats.isInterferrence = False
        End If

        Wrestlers = thisMatch.wrestlers.ToList

        If TextTimer.Enabled Then
            TextTimer.Stop()
        End If

        Dim EndOfMatch As Boolean = False
        '  If MyShowMode = ShowMode.Match Then

        Dim MyW1 As WModel = thisMatch.wrestlers(0)
        'MyW1.Name = TextBox1.Text
        'MyW1.style = StyleBox1.SelectedIndex
        '  InitializeFinisher(MyW1, "STF", "He gets his head between his arms... STF is locked!  ", MyWrestler.Position.Standing, True, False)
        MyW1.RingState = appearState.Inside
        Dim MyW2 As WModel = thisMatch.wrestlers(1)
        '  InitializeFinisher(MyW2, "Rockbottom", "The Rock catches the opponent's shoulder and smashes the Rockbottom!", MyWrestler.Position.Standing, False, False)

        ' MyW2.Name = TextBox2.Text
        ' MyW2.style = StyleBox2.SelectedIndex
        MyW2.RingState = appearState.Inside

        Dim PerformPinChance As Double = 0.5
        Dim MoveChance As Double = 0.2
        'Dim Move1 As String = "[1] moves to "


        If ChanceDrops(0.5) Then
            Dim r() As String = RndStr(MatchBeginnings).Split(".")
            For i = 0 To r.Length - 1
                r(i) = r(i).Replace("[1]", RndStr(MyW1.AlternativeNames.ToArray)).Replace("[2]", RndStr(MyW2.AlternativeNames.ToArray))
                result += r(i) & "."
            Next
        Else
            Dim r() As String = RndStr(MatchBeginnings).Split(".")
            For i = 0 To r.Length - 1
                r(i) = r(i).Replace("[1]", RndStr(MyW2.AlternativeNames.ToArray)).Replace("[2]", RndStr(MyW1.AlternativeNames.ToArray))
                result += r(i) & "."
            Next
        End If

        '=======Interference Shit
        If BasicStats.isInterferrence Then
            BasicStats.MakeImpossibleWin()
        Else
            BasicStats.Restore()
        End If
        '=======/Interference Shit
        Dim MinMet As Boolean = False 'Can't win
        Dim MaxMet As Boolean = False 'Time to RAGE
        ' Dim isfirst As Boolean = True
        While Not EndOfMatch

            '=====Time Shit
            Dim currentLength As Integer = DateToSeconds(LengthToDate(MakeSeparatedText(result.Replace("...", "_[Split]").Replace(".", ".[Split]").Replace("_", "...").Replace("!!!", "_[Split]").Replace("!", "![Split]").Replace("_", "!!!")).Length))
            If currentLength > MinTime Then
                MinMet = True
            Else
                MinMet = False
            End If
            If currentLength > MaxTime Then
                MaxMet = True
            Else
                MaxMet = False
            End If

            If Not MinMet Then
                BasicStats.MakeImpossibleWin()
            Else
                BasicStats.Restore()
            End If

            '=====/Time Shit

            '======RAGE Shit


            If MaxMet Then
                'If isfirst Then
                '    isfirst = False
                '    result += vbCrLf & vbCrLf & "ENTERING RAGE: Current Length = " & currentLength & vbCrLf
                'End If
                If MyW1.id_string = Wrestlers(WinnerIndex).id_string Then
                    result += RAGE_MODE_ON(MyW1, MyW2, EndOfMatch, WinnerIndex)
                Else
                    result += RAGE_MODE_ON(MyW2, MyW1, EndOfMatch, WinnerIndex)
                End If
                If EndOfMatch Then Exit While
            End If
            '=====/RAGE Shit



            If ChanceDrops(0.5) Then
                If ChanceDrops(MoveChance) Then
                    result += PerformMove(MyW1)
                Else
                    If MyW1.FinisherPoints >= 100 And CanPerformFinisherFromThisPosition(MyW1, MyW2) Then
                        result += PerformFinisher(EndOfMatch, MyW1, MyW2, WinnerIndex)
                    Else
                        result += PerformAttack(MyW1, MyW2, EndOfMatch, WinnerIndex)
                        If ChanceDrops(PerformPinChance) And MyW2.MyPosition = MyWrestler.Position.Lying And _
         MyW1.RingState = MyW2.RingState And (MyW2.RingState = appearState.Inside Or BasicStats.FallsCountAnywhere = True) And (Not EndOfMatch) Then
                            result += PerformPin(EndOfMatch, MyW1, MyW2, True, WinnerIndex)
                        End If
                    End If

                End If


            Else

                If ChanceDrops(MoveChance) Then
                    result += PerformMove(MyW2)
                Else

                    If MyW2.FinisherPoints >= 100 And CanPerformFinisherFromThisPosition(MyW2, MyW1) Then
                        result += PerformFinisher(EndOfMatch, MyW2, MyW1, WinnerIndex)
                    Else
                        result += PerformAttack(MyW2, MyW1, EndOfMatch, WinnerIndex)
                        If ChanceDrops(PerformPinChance) And MyW1.MyPosition = MyWrestler.Position.Lying And _
         MyW1.RingState = MyW2.RingState And (MyW1.RingState = appearState.Inside Or BasicStats.FallsCountAnywhere = True) And (Not EndOfMatch) Then
                            result += PerformPin(EndOfMatch, MyW2, MyW1, True, WinnerIndex)
                        End If
                    End If

                End If

                'Interference Shit
                If BasicStats.isInterferrence And ChanceDrops(BasicStats.InterfereChance) And (MyW1.MyPosition = MyWrestler.Position.Standing) And (MyW2.MyPosition = MyWrestler.Position.Standing) And
                    (MyW1.RingState = appearState.Inside) And (MyW2.RingState = appearState.Inside) Then
                    result += Interference.ReturnInterfere(Interference.OneInterference, MyW1, MyW2)
                    EndOfMatch = True
                End If
                '/Interference Shit
            End If

        End While
        '   ElseIf MyShowMode = ShowMode.Promo Then

        '   End If
        'If ChanceDrops(BasicStats.AfterMatchMomentChance) Then 'HERE!!!
        '    If MData.wrestlers(WinnerIndex).Gimmick.isFace Then
        '        result += " " & RndStr(MatchEndingsFace)
        '    Else
        '        result += " " & RndStr(MatchEndingsHeel)
        '    End If
        'End If

        TextBox3.Text = ""
        result = result.Replace("...", "_[Split]").Replace(".", ".[Split]").Replace("_", "...").Replace("!!!", "_[Split]").Replace("!", "![Split]").Replace("_", "!!!")

        Return result
        '   MyText = MatchText

        '        TextBox3.Text = PerformPin(True, MyW1, MyW2)
    End Function
    Function RAGE_MODE_ON(ByRef Attacker As WModel, ByRef Seller As WModel, ByRef EndOfMatch As Boolean, ByVal WinnerIndex As Integer) As String
        Dim result As String = ""
        Dim MovesCollection As List(Of Move) = New List(Of Move)
        Do Until EndOfMatch

            If Not BasicStats.isInterferrence Then
                BasicStats.PinChance = 1
                BasicStats.IncreasedPinChance = 1
                BasicStats.FinisherSubmissionChance = 1
                BasicStats.SubmissionChance = 1
            End If

            If CanPerformFinisherFromThisPosition(Attacker, Seller) Then

                result += PerformFinisher(EndOfMatch, Attacker, Seller, WinnerIndex)

                If EndOfMatch Then
                    Exit Do
                Else
                    result += PerformPin(EndOfMatch, Attacker, Seller, True, WinnerIndex)
                End If
            Else


                result += PerformAttack(Attacker, Seller, EndOfMatch, WinnerIndex, MData.FindMove(Attacker.Finishers(random(0, Attacker.Finishers.Count - 1))).AttackerPositionBefore)
                'While MovesCollection.Count = 0
                '    MovesCollection.Clear()

                '    For Each m As Move In MData.Moves
                '        If m.AttackerPositionBefore = Attacker.MyPosition And _
                '          m.AttackerPositionAfter = Attacker.MyFinisher.Position Then
                '            If m.AllowedStyles(Attacker.style) = True Then
                '                MovesCollection.Add(m)
                '            End If
                '        End If
                '    Next
                '    If MovesCollection.Count <> 0 Then Exit While

                '    If MovesCollection.Count = 0 Then
                '        For Each m As Move In MData.Moves
                '            If m.AllowedStyles(Attacker.style) And m.AttackerPositionBefore = Attacker.MyPosition Then
                '                MovesCollection.Add(m)
                '            End If
                '        Next
                '    End If

                '    If MovesCollection.Count = 0 Then
                '        result += PerformMove(Attacker)
                '    Else
                '        Exit While
                '    End If

                'End While

                'Dim MyMove As Move = MovesCollection(random(0, MovesCollection.Count - 1))
                'result += MyMove.Description.Replace("[1]", RndStr(Attacker.AlternativeNames.ToArray)).Replace("[2]", RndStr(Seller.AlternativeNames.ToArray))
                'If MyMove.IsPin Then
                '    result += PerformPin(EndOfMatch, Attacker, Seller, False, WinnerIndex)
                'End If
            End If

            If ChanceDrops(BasicStats.KickOutOfRAGEMODEChance) Then
                Exit Do
            End If

        Loop
        BasicStats.Restore()
        Return result
    End Function
    Function CanPerformFinisherFromThisPosition(ByVal Attacker As WModel, ByVal Seller As WModel) As Boolean
        For Each s As String In Attacker.Finishers
            Dim m As Move = MData.FindMove(s)
            If m.AttackerPositionBefore = Attacker.MyPosition And m.SellerPositionBefore = Seller.MyPosition Then
                Return True
            End If
        Next
        Return False
    End Function
    Private Function MakeSeparatedText(ByVal Text As String) As String()
        Dim result() As String
        result = Text.Split({"[Split]"}, StringSplitOptions.RemoveEmptyEntries)
        Dim d As Date = LengthToDate(result.Length)
        '  Me.Text = "Match Length = " & d.Hour * 60 + d.Minute & ":" & d.Second
        For i = 0 To result.Length - 2
            If (result(i)(Math.Max(result(i).Length - 1, 0)) <> " ") And (result(i + 1)(0) <> " ") Then
                result(i) += " "
            End If
        Next
        Return result
    End Function
    Private Function LengthToDate(ByVal len As Integer) As Date
        Dim SecondsInAMove As Integer = 5
        Dim d As Date = New Date(2012, 1, 1, 0, 0, 0)
        d = d.AddSeconds(len * SecondsInAMove)
        Return d
    End Function
    Private Function DateToSeconds(ByVal d As Date) As Integer
        Dim result As Integer = d.Hour * 3600 + d.Minute * 60 + d.Second
        Return result
    End Function
    Private Sub ShowText()
        If EnableTimer.Checked Then
            TextTimer.Start()
        Else
            TextBox3.Text = String.Join("", SeparatedText)
            Dim d As Date = LengthToDate(SeparatedText.Length)
            '      Me.Text = "Match Length = " & d.Hour * 60 + d.Minute & ":" & d.Second
        End If
    End Sub
    Public Function ChanceDrops(ByVal Variable As Double) As Boolean
        Dim n As Integer = random(1, 100)
        If n <= Variable * 100 Then
            Return True
        Else
            Return False
        End If
    End Function

    Function PerformMove(ByRef Attacker As WModel) As String
        Dim r As Integer = random(1, 3)
        Select Case r
            Case 1
                If Not Attacker.MyPosition = MyWrestler.Position.Running Then
                    Attacker.MyPosition = MyWrestler.Position.Running
                    Return (RndStr(Attacker.AlternativeNames.ToArray) & " speeds up from the ropes...")
                End If
            Case 2
                If Not Attacker.MyPosition = MyWrestler.Position.TopCorner Then
                    Attacker.MyPosition = MyWrestler.Position.TopCorner
                    Return (RndStr(Attacker.AlternativeNames.ToArray) & " goes to the top rope...")
                End If
            Case 3
                If Not Attacker.MyPosition = MyWrestler.Position.Standing Then
                    Attacker.MyPosition = WModel.Position.Standing
                    If Attacker.MyPosition = WModel.Position.Lying Then
                        Return (RndStr(Attacker.AlternativeNames.ToArray) & " gets to his feet...")
                    ElseIf Attacker.MyPosition = WModel.Position.TopCorner Then
                        Return (RndStr(Attacker.AlternativeNames.ToArray) & " gets down on the ring...")
                    ElseIf Attacker.MyPosition = WModel.Position.Corner Then
                        Return (RndStr(Attacker.AlternativeNames.ToArray) & " gets to the middle of the ring...")
                    ElseIf Attacker.MyPosition = WModel.Position.Running Then
                        Return (RndStr(Attacker.AlternativeNames.ToArray) & " suddenly stops near the ropes...")
                    Else
                        Return (RndStr(Attacker.AlternativeNames.ToArray) & " gets to the middle of the ring...")
                    End If
                End If
        End Select

        Return ""

    End Function
    Function GetMoveChancer(ByVal w As WModel) As Integer
        If ChanceDrops(0.5) Then
            Return Inverse(Math.Floor(w.stats(0) / 20))
        Else
            If ChanceDrops(0.5) Then
                Return Inverse(Math.Max(1, Math.Floor(w.stats(0) / 20) - 1))
            Else
                Return Inverse(Math.Max(1, Math.Floor(w.stats(0) / 20) - 2))
            End If
        End If
    End Function
    Function Inverse(ByVal value As Integer) As Integer
        Dim res As Integer = 4 - value
        res = Math.Min(Math.Max(0, res), 4)
        Return res
    End Function
    Function PerformAttack(ByRef Attacker As WModel, ByRef Seller As WModel, ByRef EndOfMatch As Boolean, ByVal WinnerIndex As Integer) As String

        '  Dim s As String = ""



        Dim NewList As List(Of Move) = New List(Of Move)
        Dim FinalCollection As List(Of Move) = New List(Of Move)
        Dim ChancesApplied As Boolean = False

        If ChancesApplied Then
            Dim Moves(4) As List(Of Move)
            For Each m As Move In MData.Moves
                Moves(m.Chance).Add(m)
            Next
            If ChanceDrops(BasicStats.BasicMoveChance) Then
                FinalCollection = Moves(4)
            Else
                FinalCollection = Moves(GetMoveChancer(Attacker))
            End If
        Else
            FinalCollection = MData.Moves
        End If
        ' For i = 0 To Moves.Count - 1
        For Each m As Move In FinalCollection
            '  If m.IsPin Then
            ' MsgBox(m.Name)
            ' End If
            ' Dim m As Move = Moves(i)
            '   If m.IsPin Then
            ' MsgBox(m.Name)
            ' End If
            If (Attacker.RingState = appearState.Inside And Seller.RingState = appearState.Inside And m.AppearState = Global.RosterViewer.Move.MoveAppearState.BothRing) Or
                (Attacker.RingState = appearState.Outside And Seller.RingState = appearState.Outside And m.AppearState = Global.RosterViewer.Move.MoveAppearState.BothOutside) Or
                (Attacker.RingState = Seller.RingState And m.AppearState = Global.RosterViewer.Move.MoveAppearState.Same) Or
                (Attacker.RingState = appearState.Inside And Seller.RingState = appearState.Outside And m.AppearState = Global.RosterViewer.Move.MoveAppearState.RingToOutside) Then
                If Attacker.MyPosition = m.AttackerPositionBefore And Seller.MyPosition = m.SellerPositionBefore Then
                    NewList.Add(m)
                End If
            End If
        Next

        If NewList.Count = 0 Then
            '  Attacker.RingState = Seller.RingState 'TODO:FIX
            Attacker.RingState = Seller.RingState
            Attacker.MyPosition = MyWrestler.Position.Standing
            Seller.MyPosition = MyWrestler.Position.Standing
            Return (RndStr(Attacker.AlternativeNames.ToArray) & " approaches " & RndStr(Seller.AlternativeNames.ToArray) & "... ")
        End If

        Dim MyMove As Move = NewList(random(0, NewList.Count - 1))
        '  If MyMove.IsPin Then
        ' MsgBox(MyMove.Description)
        ' End If
        ' Seller.DealDamage(Health.Organ.Body, )

        If MyMove.AppearState = Global.RosterViewer.Move.MoveAppearState.RingToOutside Then
            Attacker.RingState = appearState.Outside
        End If

        Attacker.MyPosition = MyMove.AttackerPositionAfter
        Seller.MyPosition = MyMove.SellerPositionAfter

        Attacker.FinisherPoints += 10

        Dim result As String
        If MyMove.IsPin Then
            result = MyMove.Description.Replace("[1]", RndStr(Attacker.AlternativeNames.ToArray)).Replace("[2]", RndStr(Seller.AlternativeNames.ToArray)) & PerformPin(EndOfMatch, Attacker, Seller, False, WinnerIndex)
        ElseIf MyMove.IsSubmission Then
            result = MyMove.Description.Replace("[1]", RndStr(Attacker.AlternativeNames.ToArray)).Replace("[2]", RndStr(Seller.AlternativeNames.ToArray)) & PerformSubmission(EndOfMatch, Attacker, Seller, False, WinnerIndex)
        Else
            result = MyMove.Description.Replace("[1]", RndStr(Attacker.AlternativeNames.ToArray)).Replace("[2]", RndStr(Seller.AlternativeNames.ToArray))
        End If
        Return result
        '        Return MyMove.Description.Replace("[1]", Attacker.Name).Replace("[2]", Seller.Name)

    End Function
    Function PerformAttack(ByRef Attacker As WModel, ByRef Seller As WModel, ByRef EndOfMatch As Boolean, ByVal WinnerIndex As Integer, ByVal AttackerPositionAfter As WModel.Position) As String

        Dim NewList As List(Of Move) = New List(Of Move)
        Dim FinalCollection As List(Of Move) = New List(Of Move)
        Dim ChancesApplied As Boolean = False

        If ChancesApplied Then
            Dim Moves(4) As List(Of Move)
            For Each m As Move In MData.Moves
                Moves(m.Chance).Add(m)
            Next
            If ChanceDrops(BasicStats.BasicMoveChance) Then
                FinalCollection = Moves(4)
            Else
                FinalCollection = Moves(GetMoveChancer(Attacker))
            End If
        Else
            FinalCollection = MData.Moves
        End If

        For Each m As Move In FinalCollection
            If (Attacker.RingState = appearState.Inside And Seller.RingState = appearState.Inside And m.AppearState = Global.RosterViewer.Move.MoveAppearState.BothRing) Or
                (Attacker.RingState = appearState.Outside And Seller.RingState = appearState.Outside And m.AppearState = Global.RosterViewer.Move.MoveAppearState.BothOutside) Or
                (Attacker.RingState = Seller.RingState And m.AppearState = Global.RosterViewer.Move.MoveAppearState.Same) Or
                (Attacker.RingState = appearState.Inside And Seller.RingState = appearState.Outside And m.AppearState = Global.RosterViewer.Move.MoveAppearState.RingToOutside) Then
                If Attacker.MyPosition = m.AttackerPositionBefore And Seller.MyPosition = m.SellerPositionBefore Then
                    If m.AttackerPositionAfter = AttackerPositionAfter Then
                        NewList.Add(m)
                    End If
                End If
            End If
        Next

        If NewList.Count = 0 Then
            Return PerformMove(Attacker)
        End If

        Dim MyMove As Move = NewList(random(0, NewList.Count - 1))

        If MyMove.AppearState = Global.RosterViewer.Move.MoveAppearState.RingToOutside Then
            Attacker.RingState = appearState.Outside
        End If

        Attacker.MyPosition = MyMove.AttackerPositionAfter
        Seller.MyPosition = MyMove.SellerPositionAfter

        Attacker.FinisherPoints += 10

        Dim result As String
        If MyMove.IsPin Then
            result = MyMove.Description.Replace("[1]", RndStr(Attacker.AlternativeNames.ToArray)).Replace("[2]", RndStr(Seller.AlternativeNames.ToArray)) & PerformPin(EndOfMatch, Attacker, Seller, False, WinnerIndex)
        ElseIf MyMove.IsSubmission Then
            result = MyMove.Description.Replace("[1]", RndStr(Attacker.AlternativeNames.ToArray)).Replace("[2]", RndStr(Seller.AlternativeNames.ToArray)) & PerformSubmission(EndOfMatch, Attacker, Seller, False, WinnerIndex)
        Else
            result = MyMove.Description.Replace("[1]", RndStr(Attacker.AlternativeNames.ToArray)).Replace("[2]", RndStr(Seller.AlternativeNames.ToArray))
        End If
        Return result

    End Function
    Function PerformPin(ByRef EndOfMatch As Boolean, ByVal Attacker As WModel, ByVal Seller As WModel, ByVal ShowPretext As Boolean, ByVal WinnerIndex As Integer) As String
        Dim Text As String = ""
        If ShowPretext = True Then
            Text = RndStr(Attacker.AlternativeNames.ToArray) & " goes for the pin! "
        Else
            Text = ""
        End If
        Dim chance As Integer = random(1, 100)

        Select Case chance
            Case Is < BasicStats.PinChance * 100
                If Attacker.id_string = Wrestlers(WinnerIndex).id_string Then
                    EndOfMatch = True
                    Return Text & "1...2...3!!! The Match is over! " & Attacker.name & " has won!"
                Else
                    Return Text & " And " & RndStr(Seller.AlternativeNames.ToArray) & " kicks out! "
                End If
            Case Is < BasicStats.PinChance * 200
                Return Text & "1...2..." & " And " & RndStr(Seller.AlternativeNames.ToArray) & " kicks out! "
            Case Is < BasicStats.PinChance * 300
                Return Text & "1..." & " And " & RndStr(Seller.AlternativeNames.ToArray) & " kicks out! "
            Case Else
                Return Text & " And " & RndStr(Seller.AlternativeNames.ToArray) & " kicks out! "
        End Select
    End Function


    Dim SuccessfulFinisherChance As Double = 0.75
    Dim SuddenFinisherChance As Double = 0.5
    Function PerformFinisher(ByRef EndOfMatch As Boolean, ByRef Attacker As WModel, ByRef Seller As WModel, ByVal WinnerIndex As Integer) As String
        Dim MyFinisherCollection As List(Of Move) = New List(Of Move)
        For Each s As String In Attacker.Finishers
            Dim TMove As Move = MData.FindMove(s)
            If TMove.AttackerPositionBefore = Attacker.MyPosition And TMove.SellerPositionBefore = Seller.MyPosition Then
                MyFinisherCollection.Add(TMove)
            End If
        Next
        Dim MyFinisher As Move
        Dim MyTxt As String = ""


        If MyFinisherCollection.Count = 0 Then
            If Attacker.Finishers.Count = 0 Then
                Return RndStr(Attacker.AlternativeNames.ToArray) & " suddenly rolls " & RndStr(Seller.AlternativeNames.ToArray) & " into the cover! " & PerformPin(EndOfMatch, Attacker, Seller, False, WinnerIndex)
            Else
                MyTxt += RndStr(Attacker.AlternativeNames.ToArray) & " puts " & RndStr(Seller.AlternativeNames.ToArray) & " in position... "
                MyFinisher = MData.FindMove(Attacker.Finishers(random(0, Attacker.Finishers.Count - 1)))
            End If
        Else
            MyFinisher = MyFinisherCollection(random(0, MyFinisherCollection.Count - 1))
        End If


        Dim isSudden As Boolean = ChanceDrops(SuddenFinisherChance)

        If Not isSudden Then
            MyTxt += RndStr(Attacker.AlternativeNames.ToArray) & " prepares for the " & MyFinisher.Name & "... "
        End If

        If ChanceDrops(SuccessfulFinisherChance) Or isSudden Then
            MyTxt += MyFinisher.Description.Replace("[1]", RndStr(Attacker.AlternativeNames.ToArray)).Replace("[2]", RndStr(Seller.AlternativeNames.ToArray))
            If Not MyFinisher.IsSubmission Then
                If MyFinisher.IsPin Then
                    MyTxt += PerformPin(EndOfMatch, Attacker, Seller, False, WinnerIndex)
                Else
                    If ChanceDrops(BasicStats.PinChance) Then
                        MyTxt += PerformPin(EndOfMatch, Attacker, Seller, True, WinnerIndex)
                    End If
                End If
            Else
                MyTxt += PerformSubmission(EndOfMatch, Attacker, Seller, True, WinnerIndex)
            End If

            Attacker.FinisherPoints = 0
            Return MyTxt

        Else

            MyTxt += "And " & RndStr(Seller.AlternativeNames.ToArray) & " counters! "
            If CanPerformFinisherFromThisPosition(Seller, Attacker) Then
                Return MyTxt & PerformFinisher(EndOfMatch, Seller, Attacker, WinnerIndex)
            Else
                MyTxt += RndStr(Seller.AlternativeNames.ToArray) & " rolls " & RndStr(Attacker.AlternativeNames.ToArray) & " into the pin..."
                Return MyTxt & PerformPin(EndOfMatch, Seller, Attacker, False, WinnerIndex)
            End If

        End If

    End Function

    Private MatchBeginnings() As String = {"[1] and [2] meet up in the center of the ring and lock up in a collar-and-elbow tie up. [1] eventually gets the upper hand as he transitions to a headlock on [2]. [2] breaks free from the hold by shoving [1] forward and towards the ropes. As [1] comes back off of the ropes, [2] attempts a clothesline, but [1] ducks and then hits the ropes on the opposite side of the ring. [1] then comes back and takes [2] down with a shoulder block. [1] reaches down for his opponent, but [2] quickly rolls to the corner and cautiously pulls himself back up to his feet, using the ropes.",
                                          "[1] and [2] get face-to-face in the center of the ring and begin to exchange words. [2] strikes first, shoving [1] away and [1] responds by shoving back. The two then exchange punches before [1] gets the upper hand, knocking [2] off of his feet. [1] attempts to continue the assault, but the referee steps in, allowing [2] the time to get back to his feet.",
                                           "[1] and [2] get face-to-face in the center of the ring. [2] raises a hand, calling for a test of strength but just as [1] reaches out, [2] kicks him in the gut. [2] then wastes no time as he backs [1] into the corner and grabs him by the arm, sending him across the ring with an Irish whip. [1] counters the Irish whip by grabbing hold of [2]’s arm and sending him into the corner instead. [2] hits the corner back-first and then stumbles out of the corner, where [1] then takes him down with a clothesline. [1] then measures [2] up as he waits for him to get back to his feet.",
                                            "[1] and [2] lock up in the center of the ring with [1] quickly getting the advantage by getting [2] on the mat with a headlock takedown. [1] then transitions to a grounded sleeper hold as [2] attempts to fight out of it. After a few elbows to the gut, [2] finally gets to his feet and breaks free from the hold. With [1] hunched over, [2] hits the ropes and comes back, only to be taken down with a clothesline. [2] slowly gets back to his feet as [1] measures him up.",
                                            "[1] locks up with [2] in the center of the ring and quickly takes him down on his back by tripping his leg. [1] quickly drops down and goes for a side headlock, but [2] squeezes out and flips over onto his stomach, getting [1] in a headlock instead. [2] continues to apply pressure with the hold as [1] slowly gets back to his feet and then breaks out of the hold by lifting [2] up into the air and slamming him down on the mat with a back suplex. [2] crawls to the corner and pleads to the referee who then steps between the two, allowing [2] the time to get back to a vertical base."
}
    Private MatchEndingsFace() As String = {"meF:1", "meF:2"}
    Private MatchEndingsHeel() As String = {"meH:1", "meH:2"}

    Private SubmissionSelling() As String = {"[S] tries to escape... ", "[S] tries to reach the ropes... ", "[S] tries to counter... ", "[S] does his best not to tap out... "}
    Private SubmissionStarts() As String = {"[A] starts the submission hold... [S]'s not going to give up that easily... "}
    Private SubmissionContinues() As String = {"[A] increases the pressure... ", "[A] holds him even stonger... "}
    Private SubmissionTapOut() As String = {"And [S] can't stand it anymore! He taps out! [A] has won!"}
    Private SubmissionEscape() As String = {"And somehow [S] escapes! "}
    Private Function RndStr(ByVal ArrayName As String()) As String
        If Not ArrayName.Length = 0 Then
            Return ArrayName(random(0, ArrayName.Length - 1))
        Else
            Return ""
        End If
    End Function
    Function PerformSubmission(ByRef EndOfMatch As Boolean, ByRef Attacker As WModel, ByRef Seller As WModel, ByVal IsFinisher As Boolean, ByVal WinnerIndex As Integer) As String
        Dim SubmissionChance As Double
        If IsFinisher Then
            SubmissionChance = BasicStats.FinisherSubmissionChance
        Else
            SubmissionChance = BasicStats.SubmissionChance
        End If

        Dim result As String = RndStr(SubmissionStarts).Replace("[A]", RndStr(Attacker.AlternativeNames.ToArray)).Replace("[S]", RndStr(Seller.AlternativeNames.ToArray))

        Dim kickOut As Boolean = False
        Dim cnt As Integer = 0

        While Not kickOut And Not EndOfMatch
            If ChanceDrops(SubmissionChance) Then
                cnt += 1
                SubmissionChance += 0.1
                result += RndStr(SubmissionContinues).Replace("[A]", RndStr(Attacker.AlternativeNames.ToArray)).Replace("[S]", RndStr(Seller.AlternativeNames.ToArray))
                If cnt = 3 Then
                    If Attacker.id_string = Wrestlers(WinnerIndex).id_string Then
                        result += RndStr(SubmissionTapOut).Replace("[A]", RndStr(Attacker.AlternativeNames.ToArray)).Replace("[S]", RndStr(Seller.AlternativeNames.ToArray))
                        EndOfMatch = True
                    Else
                        result += RndStr(SubmissionEscape).Replace("[A]", RndStr(Attacker.AlternativeNames.ToArray)).Replace("[S]", RndStr(Seller.AlternativeNames.ToArray))
                        kickOut = True
                    End If
                Else
                    result += RndStr(SubmissionSelling).Replace("[A]", RndStr(Attacker.AlternativeNames.ToArray)).Replace("[S]", RndStr(Seller.AlternativeNames.ToArray))
                End If
            Else
                result += RndStr(SubmissionEscape).Replace("[A]", RndStr(Attacker.AlternativeNames.ToArray)).Replace("[S]", RndStr(Seller.AlternativeNames.ToArray))
                kickOut = True
            End If
        End While

        Return result

    End Function
    Public Function random(ByVal lowerbound As Integer, ByVal upperbound As Integer)
        Randomize()
        Dim randomvalue As Integer
        randomvalue = CInt(Math.Floor((upperbound - lowerbound + 1) * Rnd())) + lowerbound
        Return randomvalue
    End Function
    Private Sub TextTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextTimer.Tick
        TextBox3.Text += SeparatedText(CurrentSeparatedIndex)
        TextBox3.Select(TextBox3.TextLength, TextBox3.TextLength)
        TextBox3.ScrollToCaret()
        TextTimer.Interval = Math.Max(SeparatedText(CurrentSeparatedIndex).Length * CInt(100 / TrackBar1.Value), 200)
        CurrentSeparatedIndex += 1
        If CurrentSeparatedIndex > SeparatedText.Length - 1 Then
            CurrentSeparatedIndex = 0
            TextTimer.Stop()
        End If
    End Sub
    Private Sub EnableTimer_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnableTimer.CheckedChanged
        If EnableTimer.Checked Then
            TrackBar1.Enabled = True
        Else
            TrackBar1.Enabled = False
        End If
    End Sub
    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            Try
                TextTimer.Stop()
            Catch ex As Exception
            End Try
        Else
            Try
                TextTimer.Start()
            Catch ex As Exception
            End Try
        End If
    End Sub
    Public Function GeneratePromo() As String
        Return "***********" & vbCrLf & vbCrLf & "Promo Text" & vbCrLf & vbCrLf & "***********"
    End Function
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim sfd As SaveFileDialog = New SaveFileDialog
        sfd.Filter = "*.txt (Text files)|*.txt"
        If sfd.ShowDialog = Windows.Forms.DialogResult.OK Then
            Try
                File.WriteAllText(sfd.FileName, String.Join("", SeparatedText))
                MsgBox("Match saved")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

    End Sub

    Dim currentTemp As Integer = 0
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Dim sfd As SaveFileDialog = New SaveFileDialog
        sfd.Filter = "*.txt (Text files)|*.txt"
        If sfd.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim difference As Integer = 300
            Dim timestep As Integer = 300
            Dim timestart As Integer = 0
            Dim timefinish As Integer = 3600
            Dim result As String = "Every step took " & Number & " calculations" & vbCrLf
            PBar.Maximum = Number
            For time = timestart To timefinish Step timestep
                Dim success As Boolean = False

                TimeLabel.Text = time & "/" & timefinish
                MinTime = time
                MaxTime = time + difference


                'GenerateThread.Start()

                'If GenerateThread.ThreadState = Threading.ThreadState.Stopped Then
                '    PBarThread = New Threading.Thread(AddressOf PBarUpdate)
                '    GenerateThread = New Threading.Thread(AddressOf PlentyGeneration)
                'End If
                PlentyGeneration()
                ' Threading.Thread.Sleep(100)
                PBarUpdate()
                result += vbCrLf & vbCrLf & "===================================" & vbCrLf
                result += "Originally: from " & CDbl(MinTime) / 60 & " to " & CDbl(MaxTime) / 60 & " minutes" & vbCrLf
                result += "Actually: " & ThreadMinutes & " minutes" & vbCrLf
                result += "Difference with maximum: " & ThreadMinutes - MaxTime / 60 & " minutes"
                result += vbCrLf & "==================================="
                success = True

            Next
            result += vbCrLf & "The Federation " & Date.Today.Date

            Try
                File.WriteAllText(sfd.FileName, result)
                MsgBox("Report saved")
            Catch ex As Exception
                MsgBox("Failed to save the report: " & vbCrLf & ex.Message)
                MsgBox("The back-uped data:" & vbCrLf & result)
            End Try

        End If

    End Sub
    Dim ThreadMinutes As Double
    Dim Number As Integer = 150
    Dim shallshow As Boolean = True
    Sub PlentyGeneration()
        '   Windows.Forms.Control.CheckForIllegalCrossThreadCalls = False
        '    shallshow = True
        '  PBarThread.Start()
        Dim seconds As Double = 0
        For i = 1 To Number
            currentTemp = i
            Dim m As Match = New Match
            m.forcedWinnerIndex = random(0, 1)
            m.isForcedWin = True
            m.wrestlers = MyMatch.wrestlers
            MyMatch = m
            MyShowMode = NewMatchGenerator.ShowMode.Match
            SeparatedText = MakeSeparatedText(GenerateMatch(MyMatch, Winner))
            Dim d As Date = LengthToDate(SeparatedText.Length)
            seconds += d.Hour * 3600 + d.Minute * 60 + d.Second
            seconds -= 60 'TODO: Probably fix 
        Next
        Dim Average As Double = seconds / Number
        ' MsgBox(Average)
        ThreadMinutes = Average / 60
        '    shallshow = False
        '    Threading.Thread.CurrentThread.Abort()
        '  MsgBox("Average Match Length: " & Average / 60 & "Minutes")

        ' PBarThread.Abort()
        ' MsgBox(GenerateThread.IsAlive)
        ' GenerateThread.s()
        ' MsgBox(GenerateThread.IsAlive)
    End Sub
    Sub PBarUpdate()

        'While shallshow
        PBar.Value = Math.Min(currentTemp, PBar.Maximum)
        Threading.Thread.Sleep(100)
        'End While
    End Sub
    Dim PBarThread As Threading.Thread = New Threading.Thread(AddressOf PBarUpdate)
    Dim GenerateThread As Threading.Thread = New Threading.Thread(AddressOf PlentyGeneration)

End Class
