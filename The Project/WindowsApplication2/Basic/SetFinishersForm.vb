Public Class SetFinishersForm
    Dim MyWrestler As WModel
    Dim TempMoveList As List(Of Move) = New List(Of Move)
    Public Overloads Sub Show(ByRef Wrestler As WModel)
        MyWrestler = Wrestler
        MyBase.Show()
    End Sub
    Private Sub SetFinishersForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDB()
        LoadWrestlerInfo()
        Label1.BackColor = Basic.Promotions(Basic.Promotion).Color1
    End Sub
    Private Sub LoadDB()
        ListView1.Columns.Add("Name")
        ListView1.Columns.Add("Seller")
        ListView1.Columns.Add("Attacker")
        For i = 0 To MData.Moves.Count - 1
            Dim m As ListViewItem = New ListViewItem
            m.Text = MData.Moves(i).Name
            m.SubItems.Add([Enum].GetName(GetType(WModel.Position), MData.Moves(i).SellerPositionBefore))
            m.SubItems.Add([Enum].GetName(GetType(WModel.Position), MData.Moves(i).AttackerPositionBefore))

            If MData.Moves(i).Description = "" Then
                m.BackColor = Color.LightPink
            End If
            ListView1.Items.Add(m)
            '  ListBox2.Items.Add(MData.Moves(i).Name)
        Next

        TempMoveList.Clear()
        For Each eFinisher As String In MyWrestler.Finishers
            TempMoveList.Add(MData.FindMove(eFinisher))
        Next
        'TempMoveList.AddRange(MyWrestler.Finishers)
        UpdateListbox()

        For Each column As ColumnHeader In Me.ListView1.Columns
            column.Width = -2
        Next
        ' ListBox2.Items.AddRange(MData.Moves.ToArray)
        'ListBox1.Items.AddRange(MyWrestler.Finishers.ToArray)
    End Sub
    Private Sub LoadWrestlerInfo()
        Label1.Text = MyWrestler.name
        PictureBox1.Image = MData.imcontainer(MData.find_actual_id(MyWrestler, MData.SearchType.All)).smallimage
    End Sub
    Private Function FindFinisher(ByVal Id_String As String) As Move
        For Each m As Move In MData.Moves
            If m.id_string = Id_String Then
                Return m
            End If
        Next
        Return Nothing
    End Function

    Private Sub ListView1_DoubleClick(sender As Object, e As EventArgs) Handles ListView1.DoubleClick
        Button1.PerformClick()
    End Sub
    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        Try

            If Not ListView1.SelectedIndices(0) = -1 Then
                TabControl1.SelectedTab = TabPage2
                TextBox3.Text = MData.Moves(ListView1.SelectedIndices(0)).Description
            End If

        Catch ex As Exception
            '    MsgBox(ex)
        End Try
    End Sub
    Sub UpdateListbox()
        ListBox1.Items.Clear()
        For i = 0 To TempMoveList.Count - 1
            ListBox1.Items.Add(TempMoveList(i).Name)
        Next
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TempMoveList.Add(MData.Moves(ListView1.SelectedIndices(0)))
        UpdateListbox()
        ListBox1.SelectedIndex = ListBox1.Items.Count - 1
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Select Case TabControl1.SelectedIndex
            Case 0
                If Not ListBox1.SelectedIndex = -1 Then
                    TempMoveList(ListBox1.SelectedIndex).Description = TextBox2.Text
                    If CheckBox1.Checked Then
                        TempMoveList(ListBox1.SelectedIndex).AttachedTo = MyWrestler.id_string
                    Else
                        TempMoveList(ListBox1.SelectedIndex).AttachedTo = ""
                    End If
                End If
            Case 1
                MData.Moves(ListView1.SelectedIndices(0)).Description = TextBox3.Text
        End Select
        UpdateListbox()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Not ListBox1.SelectedIndex = -1 Then
            TempMoveList.RemoveAt(ListBox1.SelectedIndex)
        End If
        UpdateListbox()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MyWrestler.Finishers.Clear()
        ' MyWrestler.Finishers.AddRange(TempMoveList)
        For Each TMove As Move In TempMoveList
            MyWrestler.Finishers.Add(TMove.id_string)
        Next
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        If Not ListBox1.SelectedIndex = -1 Then
            TabControl1.SelectedTab = TabPage1
            TextBox2.Text = TempMoveList(ListBox1.SelectedIndex).Description
            CheckBox1.Checked = (TempMoveList(ListBox1.SelectedIndex).AttachedTo = MyWrestler.id_string)
        End If
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim s As String = InputBox("Enter the new name:", , ListBox1.Items(ListBox1.SelectedIndex))
        If Not s = "" Then
            TempMoveList(ListBox1.SelectedIndex).Name = s
        Else
            MsgBox("Name can't be empty")
        End If
    End Sub

    Private Sub TabControl1_TabIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.TabIndexChanged

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If Not ListBox1.SelectedIndex = -1 Then
            If tempMoveList(ListBox1.SelectedIndex).AttachedTo <> "" Then
                If CheckBox1.Checked And MyWrestler.id_string <> TempMoveList(ListBox1.SelectedIndex).AttachedTo Then

                    Try
                        If MsgBox("This move is already attached to " & MData.FindWrestler(TempMoveList(ListBox1.SelectedIndex).AttachedTo).name & "." & vbCrLf & _
                               "Do you really want to attach it to " & MyWrestler.name & " instead?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                            CheckBox1.Checked = False
                        End If
                    Catch ex As Exception
                    End Try
                End If
            End If
        End If
    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedIndex = 1 Then
            CheckBox1.Checked = False
            CheckBox1.Enabled = False
        Else
            CheckBox1.Enabled = True
            If Not ListBox1.SelectedIndex = -1 Then
                CheckBox1.Checked = (TempMoveList(ListBox1.SelectedIndex).AttachedTo = MyWrestler.id_string)
            End If
        End If
    End Sub
End Class