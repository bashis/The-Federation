Public Class ShowViewer
    Dim number_of_events As Integer
    Dim someshow As Show = New Show 'TODO: Delete this, replace with actual show
    Public current_show As Show = New Show
    Private Sub fillDesign()

        '   newEventButton.Parent = Header
        newEventButton.Left = Header.Left + 5
        newEventButton.Width = Header.Width - 10
        newEventButton.Visible = False
        '  RandomButton.Parent = Header
        RandomButton.Left = Header.Left + 5
        RandomButton.Width = newEventButton.Width
        RandomButton.Visible = False
        Label1.Text = "Today: " & Basic.CurrentDate.Date
        Me.Text = current_show.Name


    End Sub

    Private Sub ShowViewer_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load


        fillDesign()
        '  ShowFill()

        ' current_show = someshow
        fillButtons()
    End Sub

    Public Sub ShowFill()
        someshow.RandomModel()
        someshow.BGPic = Basic.Promotions(Basic.Promotion).BGImage
        someshow.rebuild()
    End Sub
    Dim EventButtons() As Button
    Public Sub fillButtons()
        ReDim EventButtons(current_show.model.Length - 1)
        For i = 0 To current_show.model.Length - 1
            EventButtons(i) = New Button
            With EventButtons(i)
                .Parent = Panel1

                If current_show.Events(i) = 1 Then

                    If current_show.Matches(i).wrestlers Is Nothing Then
                        .Text = "Match"
                    Else
                        .Text = current_show.Matches(i).Name
                    End If

                ElseIf current_show.Events(i) = 2 Then
                    .Text = "Promo"
                End If
                    'Dim maxSize As Size
                    .AutoSizeMode = Windows.Forms.AutoSizeMode.GrowOnly
                    .AutoSize = True
                    '.MaximumSize = maxSize
                .Top = templateButton.Top
                If i = 0 Then
                    .Left = templateButton.Left
                Else
                    .Left = EventButtons(i - 1).Right + 5
                End If
                ' .Left = templateButton.Left + templateButton.Width * i + 5 * i
                    .Height = templateButton.Height
                    .Width = templateButton.Width
                    AddHandler EventButtons(i).Click, AddressOf EventClicked
                    Panel1.Controls.Add(EventButtons(i))
            End With
        Next

        Header.bg.BorderStyle = BorderStyle.None
        Header.bg.Image = current_show.BGPic
    End Sub
    Public index As Integer
    Public Sub EventClicked(ByVal sender As System.Object, ByVal e As System.EventArgs)
        index = Array.IndexOf(EventButtons, sender)
        If current_show.Events(index) = 1 Then
            NewEventType = 1
            If current_show.Matches(index).wrestlers Is Nothing Then
                newEventButton.Text = "New Match"
                RandomButton.Text = "Random Match"
                newEventButton.Visible = True
                RandomButton.Visible = True
                'MatchMenu.ThisMatch = RandomMatch()
                'MatchMenu.Show()
            Else
                newEventButton.Visible = False
                RandomButton.Visible = False
                MatchMenu.ThisMatch = current_show.Matches(index)
                MatchMenu.ShallGenerate = False
                Header.Draw(current_show.BGPic, current_show.Matches(index).wrestlers.ToList, current_show.Matches(index).Name)

                'MatchMenu.Show()
            End If
        ElseIf current_show.Events(index) = 2 Then
            NewEventType = 2
            PromoForm.Show()
        End If
    End Sub
    Public Enum MatchRang
        LowCard = 0
        MidCard = 1
        TopCard = 2
    End Enum
    Public Function NewRandomMatch(ByVal Promotion As Integer, ByVal isPPV As Boolean) As Match
        Dim Rang As Integer = RosterViewerForm.random(0, [Enum].GetValues(GetType(MatchRang)).Length - 1)
        Return NewRandomMatch(Promotion, isPPV, CType(Rang, MatchRang))
    End Function
    Public Function SetWrestlersByRang(ByVal AllWrestlers As List(Of WModel), ByVal WrestlerRang As MatchRang) As List(Of WModel)
        Dim Result As List(Of WModel) = New List(Of WModel)
        Dim Copied As List(Of WModel) = New List(Of WModel)

        For Each Element As WModel In AllWrestlers
            Copied.Add(Element)
        Next

        For i = 0 To Copied.Count - 1
            For j = i To Copied.Count - 1
                If Copied(i).stats(5) > Copied(j).stats(5) Then
                    Dim Temp As WModel = Copied(i)
                    Copied(i) = Copied(j)
                    Copied(j) = Temp
                End If
            Next
        Next
        ' 

        Dim Quarter As Integer = CInt(Math.Ceiling(AllWrestlers.Count / 4))
        Dim Half As Integer = CInt(Math.Ceiling(AllWrestlers.Count / 2))
        Dim Min As Integer
        Dim Max As Integer
        Select Case WrestlerRang
            Case MatchRang.LowCard
                Min = 1
                Max = Math.Min(Math.Max(Quarter, 6), AllWrestlers.Count)
            Case MatchRang.TopCard
                Min = Math.Max(0, Math.Min(AllWrestlers.Count - 6, Quarter * 3))
                Max = AllWrestlers.Count
            Case Else
                Min = Math.Min(Half - 3, Quarter)
                Max = Math.Max(Half + 3, Quarter * 3)
        End Select
        For i = Min - 1 To Max - 1
            Result.Add(Copied(i))
        Next
        Return Result
    End Function
    Private Function OnlyHeels(ByRef W As List(Of WModel))
        Dim result As List(Of WModel) = New List(Of WModel)
        For Each model As WModel In W
            If Not model.Gimmick.isFace Then
                result.Add(model)
                '    W.Remove(model)
            End If
        Next
        Return result
    End Function
    Private Function OnlyFaces(ByRef W As List(Of WModel))
        Dim result As List(Of WModel) = New List(Of WModel)
        For Each model As WModel In W
            If model.Gimmick.isFace Then
                result.Add(model)
                '    W.Remove(model)
            End If
        Next
        Return result
    End Function

    Public Function NewRandomMatch(ByVal Promotion As Integer, ByVal isPPV As Boolean, ByVal Rang As MatchRang) As Match
        Dim result As Match = New Match

        'Dim UsedWrestlers As List(Of WModel) = New List(Of WModel)
        '  Dim LowCarders As List(Of WModel) = New List(Of WModel)
        '  Dim MidCarders As List(Of WModel) = New List(Of WModel)
        '  Dim TopCarders As List(Of WModel) = New List(Of WModel)
        Dim AvailableWrestlers As List(Of WModel) = SetWrestlersByRang(MData.mywrestlers.ToList, Rang)
        Dim Faces As List(Of WModel) = OnlyFaces(AvailableWrestlers)
        Dim Heels As List(Of WModel) = OnlyHeels(AvailableWrestlers)

        With result
            .MatchType = New MatchType
            .MatchType.id = 0
            .number_of_wrestlers = 2
            ReDim .wrestlers(.number_of_wrestlers - 1)
            .rebuild()
            .wrestlers(0) = Faces(RosterViewerForm.random(0, Faces.Count - 1))
            .wrestlers(1) = Heels(RosterViewerForm.random(0, Heels.Count - 1))
            .isForcedWin = False
            For i = 0 To DefaultConstants.n_of_items_in_a_match
                If .items(i) Is Nothing Then
                    .items(i) = New Items
                End If
                .items(i).Id = 0
                .items(i).recount()
            Next
        End With
        Return result

    End Function


    Public Function RandomMatch(ByVal Promotion As Integer) As Match
        Dim match As Match = New Match
        With match
            .MatchType = New MatchType
            .MatchType.id = RosterViewerForm.random(-10, MatchType.descriptions.Length - 1)
            If .MatchType.id < 0 Then
                .MatchType.id = 0
            End If
            .MatchType.recount()

            .number_of_wrestlers = RosterViewerForm.random(-5, 6)

            If .number_of_wrestlers < 2 Then
                .number_of_wrestlers = 2
            End If
            ReDim Preserve .wrestlers(.number_of_wrestlers - 1)
            .rebuild()

            For i = 0 To .number_of_wrestlers - 1
                .wrestlers(i) = New WModel
                Dim IsValid As Boolean = True
10:
                While True
                    IsValid = True
                    Dim wrnum As Integer = RosterViewerForm.random(0, MData.mywrestlers.Length - 1)

                    'If MData.wrestlers(wrnum).id_string = "9999" Then
                    ' IsValid = False
                    ' End If

                    '  If MData.wrestlers(wrnum).Promotion <> Promotion Then
                    ' IsValid = False
                    ' End If

                    For j = 0 To i - 1
                        If .wrestlers(j).id_string = MData.mywrestlers(wrnum).id_string Then
                            IsValid = False
                        End If
                    Next

                    If IsValid Then
                        .wrestlers(i) = MData.mywrestlers(wrnum)
                        Exit While
                    End If

                End While

                '                If MData.wrestlers(wrnum).id_string <> "9999" Then
                '.wrestlers(i) = MData.wrestlers(wrnum)
                'Else : GoTo 10

                'End If
            Next

            .isTeamMatch = False

            .isForcedWin = False
            For i = 0 To DefaultConstants.n_of_items_in_a_match
                If .items(i) Is Nothing Then
                    .items(i) = New Items
                End If
                .items(i).Id = 0
                .items(i).recount()
            Next

            Dim str As String = .wrestlers(0).name
            '   For i = 1 To .number_of_wrestlers - 1
            'str = str & " vs. " & .wrestlers(i).name
            'Next
            'MsgBox(str)
            'MatchMenu.ThisMatch = match

            'MatchMenu.Show()


        End With
        Return match
    End Function

    Dim NewEventType As Integer
    Private Sub newEventButton_Click(sender As System.Object, e As System.EventArgs) Handles newEventButton.Click
        If NewEventType = 1 Then
            MatchSetup.Show()
        ElseIf NewEventType = 2 Then
            PromoForm.Show()
        End If
    End Sub

    Private Sub RandomButton_Click(sender As System.Object, e As System.EventArgs) Handles RandomButton.Click
        If NewEventType = 1 Then
            current_show.Matches(index) = RandomMatch(Basic.Promotion)
            MatchMenu.ThisMatch = current_show.Matches(index)
            MatchMenu.ShallGenerate = True
            MatchMenu.Show()
            EventButtons(index).Text = current_show.Matches(index).Name
            fixButtonsLocation()

            current_show.Matches(index) = MatchMenu.ThisMatch

            newEventButton.Visible = False
            RandomButton.Visible = False
        ElseIf NewEventType = 2 Then
            PromoForm.Show()
        End If
    End Sub
    Private Function SetRangRule(ByVal MatchOrder As Integer) As MatchRang
        Select Case MatchOrder
            Case 0
                Return MatchRang.MidCard
            Case 1
                Return MatchRang.MidCard
            Case 2
                Return MatchRang.LowCard
            Case 3
                Return MatchRang.MidCard
            Case 4
                Return MatchRang.TopCard
            Case 5
                Return MatchRang.TopCard
            Case 6
                Return MatchRang.TopCard
            Case Else
                Return MatchRang.TopCard
        End Select
    End Function

    Private Sub fixButtonsLocation()
        EventButtons(0).Left = templateButton.Left
        For i = 1 To current_show.model.Length - 1
            With EventButtons(i)
                .Left = EventButtons(i - 1).Right + 5
            End With
        Next
    End Sub


    Private Sub RandomShow_Click(sender As System.Object, e As System.EventArgs) Handles RandomShow.Click
        For i = 0 To current_show.Events.Length - 1

            If current_show.Events(i) = 1 Then
                If current_show.Matches(i).wrestlers Is Nothing Then
                    '  current_show.Matches(i) = New Match
                    current_show.Matches(i) = NewRandomMatch(Basic.Promotion, False, SetRangRule(i)) ' CType(CInt(Math.Floor(3 / (i + 1))), MatchRang)) ' RandomMatch(Basic.Promotion)
                    MatchMenu.ThisMatch = current_show.Matches(i)
                    MatchMenu.ShallGenerate = True
                    MatchMenu.Simulate()
                    'MatchMenu.Visible = False
                    'MatchMenu.Hide()
                    'MatchMenu.Show()
                    'MatchMenu.Hide()

                    EventButtons(i).Text = current_show.Matches(i).Name
                    fixButtonsLocation()

                    current_show.Matches(i) = MatchMenu.ThisMatch
                    ' MatchMenu.Close()
                    newEventButton.Visible = False
                    RandomButton.Visible = False
                End If
            End If
        Next
        RandomShow.Enabled = False
    End Sub

    Private Sub Header_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub templateButton_Click(sender As Object, e As EventArgs) Handles templateButton.Click

    End Sub

    Private Sub WatchButton_Click(sender As Object, e As EventArgs) Handles WatchButton.Click
        If current_show.Events(index) = 1 Then
            MatchMenu.ThisMatch = current_show.Matches(index)
            MatchMenu.Show()
        Else
            StartPromo.MyPromo = current_show.Promos(index)
            StartPromo.Show()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim mh As NewMatchGenerator = New NewMatchGenerator
        mh.MyShowMode = NewMatchGenerator.ShowMode.FullShow
        mh.MyShow = current_show
        '  mh.GenerateShow(current_show)
        mh.Show()
    End Sub

    Private Sub Header_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub PreviewScreen2_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub Header_Load_1(sender As Object, e As EventArgs) Handles Header.Load

    End Sub
End Class