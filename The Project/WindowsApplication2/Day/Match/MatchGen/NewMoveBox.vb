Public Class NewMoveBox
    Private _myMove As Move

    Public Property MyMove As Move
        Get
            Return _myMove
        End Get
        Set(value As Move)
            If Not value Is Nothing Then
                NoneBox.Checked = True
                _myMove = value
                NameBox.Text = value.Name
                DescBox.Text = value.Description
                If value.IsSubmission Then SubmissionBox.Checked = True
                If value.Name.Contains("[Pin]") Then value.IsPin = True
                If value.IsPin Then PinBox.Checked = True

                SetPositionBox(AttackerBeforeBox, value.AttackerPositionBefore)
                SetPositionBox(AttackerAfterBox, value.AttackerPositionAfter)
                SetPositionBox(SellerBeforeBox, value.SellerPositionBefore)
                SetPositionBox(SellerAfterBox, value.SellerPositionAfter)

                If Not value.AppearState = Nothing Then
                    MoveAppearStateBox.SelectedIndex = Convert.ToInt32(value.AppearState)
                Else
                    MoveAppearStateBox.SelectedIndex = 0
                End If





                '  If Not value.Rang = Nothing Then
                ' MoveRangBox.SelectedIndex = Convert.ToInt32(value.Rang)
                'Else
                '    MoveRangBox.SelectedIndex = 0
                'End If
            End If
        End Set
    End Property

    Public Sub SetPositionBox(ByVal box As ComboBox, ByVal prop As WModel.Position)
        If Not prop = Nothing Then
            box.SelectedIndex = Convert.ToInt32(prop)
        Else
            box.SelectedIndex = 0
        End If
    End Sub

    Dim ChanceValues() As String = {"Very low", "Low", "Normal", "High", "Very high"}
    Dim StyleCBxs(Global.RosterViewer.Move.StyleNames.Length - 1) As CheckBox
    Dim ChanceRBs(ChanceValues.Length - 1) As RadioButton
    Private Sub NewMoveBox_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        Dim cnt As Integer = 0
        Dim curTop As Integer = TemplateCheckbox.Top
        Dim curLeft As Integer = TemplateCheckbox.Left
        For i = 0 To Global.RosterViewer.Move.StyleNames.Length - 1
            StyleCBxs(i) = New CheckBox


            With StyleCBxs(i)
                .AutoSize = True
                .Parent = GroupBox2
                .Text = Global.RosterViewer.Move.StyleNames(i)
                .Left = curLeft
                .Top = curTop
            End With
            cnt += 1
            If cnt = 3 Then
                cnt = 0
            End If
            If cnt = 0 Then
                curTop = TemplateCheckbox.Top
                curLeft += 80
            Else
                curTop += 20
            End If
        Next

        For i = 0 To ChanceValues.Length - 1
            ChanceRBs(i) = New RadioButton
            With ChanceRBs(i)
                .Appearance = Appearance.Button
                .Text = ChanceValues(i)
                .Top = ChanceCB.Top
                .AutoSize = True
                .Checked = False
                If i = 0 Then
                    .Left = ChanceCB.Left
                Else
                    .Left = ChanceRBs(i - 1).Right + 2
                End If
                .Visible = True
            End With
            Me.Controls.Add(ChanceRBs(i))
        Next
        '   ChanceRBs(2).Checked = True


        If MyMove Is Nothing Then
            MyMove = New Move
        End If
        If MyMove.AllowedStyles Is Nothing Then
            MyMove.AllowedStyles = {True, True, True, True, True, True, True}
        End If
        For i = 0 To StyleCBxs.Length - 1
            If MyMove.AllowedStyles(i) = True Then
                StyleCBxs(i).Checked = True
            Else
                StyleCBxs(i).Checked = False
            End If
        Next
        'If MyMove.Chance = Nothing Then
        ' MyMove.Chance = 2
        ' End If
        ChanceRBs(MyMove.Chance).Checked = True
    End Sub

    Public Sub Save()
        With _myMove
            .Name = NameBox.Text
            .Description = DescBox.Text
            If SubmissionBox.Checked Then
                .IsSubmission = True
            Else
                .IsSubmission = False
            End If
            If PinBox.Checked Then
                .IsPin = True
            Else
                .IsPin = False
            End If

            ' .Rang = CType(MoveRangBox.SelectedIndex, Move.Rangs)
            .AppearState = CType(MoveAppearStateBox.SelectedIndex, Move.MoveAppearState)

            .SellerPositionBefore = CType(SellerBeforeBox.SelectedIndex, MyWrestler.Position)
            .AttackerPositionBefore = CType(AttackerBeforeBox.SelectedIndex, MyWrestler.Position)
            .SellerPositionAfter = CType(SellerAfterBox.SelectedIndex, MyWrestler.Position)
            .AttackerPositionAfter = CType(AttackerAfterBox.SelectedIndex, MyWrestler.Position)

            For i = 0 To StyleCBxs.Length - 1
                If StyleCBxs(i).Checked Then
                    .AllowedStyles(i) = True
                Else
                    .AllowedStyles(i) = False
                End If
            Next

            For i = 0 To ChanceRBs.Length - 1
                If ChanceRBs(i).Checked Then
                    .Chance = i
                End If
            Next


        End With
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        For i = 0 To StyleCBxs.Length - 1
            StyleCBxs(i).Checked = True
        Next
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        For i = 0 To StyleCBxs.Length - 1
            StyleCBxs(i).Checked = False
        Next
    End Sub
    'Private Sub TrackBar1_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Label9.Text = Values(TrackBar1.Value)
    'End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub
End Class
