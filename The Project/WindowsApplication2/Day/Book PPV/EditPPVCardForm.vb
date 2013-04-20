Public Class EditPPVCardForm
    Public BookedMatches As List(Of Match)
    Dim EditControls() As SelectPPVEvent
    Dim MaximumMatchesPPV As Integer = 8 '1-based
    Dim ReleasePanels(MaximumMatchesPPV - 1) As Panel
    Private Sub EditPPVCardForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim m As Match = New Match
        ReDim m.wrestlers(1)
        m.wrestlers(0) = New WModel
        m.wrestlers(1) = New WModel
        m.wrestlers(0) = MData.SelectWrestler
        m.wrestlers(1) = MData.SelectWrestler
        m.number_of_teams = 2
        m.number_of_wrestlers = 2
        m.isPPV = False
        Dim mt As MatchType = New MatchType
        mt.id = 0
        m.MatchType = mt
        BookedMatches = New List(Of Match)
        BookedMatches.Add(m)

        DrawReleasePanels()
        UpdateForm()
    End Sub
    Public Sub UpdateForm()

        ReDim EditControls(MaximumMatchesPPV - 1)
        For i = 0 To MaximumMatchesPPV - 1
            EditControls(i) = New SelectPPVEvent
            With EditControls(i)
                .Parent = ReleasePanels(i)
                ' If i = 0 Then
                '.Top = TemplatePPVEvent.Top
                'Else
                '.Top = EditControls(i - 1).Bottom + 2
                'End If
                .Top = 0
                .Left = 0
                ' .Left = TemplatePPVEvent.Left
                '.Parent = Panel1
                .Size = TemplatePPVEvent.Size
                '   If i = BookedMatches.Count - 1 Then
                ' .OrderText = "Main Event"
                ' Else
                ' .OrderText = "Match " & i
                'End If
                .Visible = False
                .IsUsed = False
            End With

        Next
        For i = 0 To BookedMatches.Count - 1
            With ReleasePanels(i)
                .Visible = True
                .BackColor = Color.Transparent
            End With
            With EditControls(i)
                .IsUsed = True
                .Visible = True
                .ShowMatch(BookedMatches(i))
            End With
            AddHandler EditControls(i).MouseDown, AddressOf MatchMouseDown
        Next


    End Sub
    Private Sub MatchMouseDown(ByVal sender As Object, ByVal e As MouseEventArgs)

        For i = 0 To MaximumMatchesPPV - 1
            If Not EditControls(i).IsUsed Then
                ReleasePanels(i).BackColor = Color.AliceBlue
                ReleasePanels(i).Visible = True
                ReleasePanels(i).AllowDrop = True
                EditControls(i).Visible = False
            Else
                ReleasePanels(i).BackColor = Color.Transparent
                ReleasePanels(i).AllowDrop = False
            End If
        Next
        Me.DoDragDrop(sender.MyMatch, DragDropEffects.Move)
        ' this.DoDragDrop(MyCapital, DragDropEffects.Copy |
        '  DragDropEffects.Move);
    End Sub
    Private Sub PanelDragEnter(ByVal sender As Object, ByVal e As DragEventArgs)
        ' If e.Data.GetDataPresent("Match") Then
        '     'If (TypeOf e.Data.GetData() Is Match) Then
        e.Effect = DragDropEffects.Move
        ' Else
        '     e.Effect = DragDropEffects.None
        ' End If
    End Sub
    Private Sub DropEventHandler(ByVal sender As Object, ByVal e As DragEventArgs)
        '       private void Country_DragDrop(object sender, DragEventArgs e)
        '     {
        '         MyCapital = e.Data.GetData(DataFormats.Text).ToString();
        '     }
        Dim index As Integer = Array.IndexOf(ReleasePanels, sender)
        EditControls(index).Visible = True
        EditControls(index).ShowMatch(e.Data.GetData("Match"))


    End Sub
    Public Sub DrawReleasePanels()
        For i = 0 To MaximumMatchesPPV - 1
            ReleasePanels(i) = New Panel
            With ReleasePanels(i)
                .Left = ReleasePanelTemplate.Left
                If i = 0 Then
                    .Top = ReleasePanelTemplate.Top
                Else
                    .Top = ReleasePanels(i - 1).Bottom + 2
                End If
                .Size = ReleasePanelTemplate.Size
                .Parent = Panel1
                .Visible = False
                .AllowDrop = True
                .BackColor = Color.AliceBlue
            End With
            AddHandler ReleasePanels(i).DragEnter, AddressOf PanelDragEnter
            AddHandler ReleasePanels(i).DragDrop, AddressOf DropEventHandler
        Next
    End Sub
    Public Sub HidePanels()
        For i = 0 To ReleasePanels.Length - 1
            ReleasePanels(i).Visible = False
        Next
    End Sub
    Public Sub ShowPanels()
        For i = 0 To ReleasePanels.Length - 1
            ReleasePanels(i).Visible = True
        Next
    End Sub
End Class