Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
Public Class MovesEditor

    ' Public Buttons As List(Of Button) = New List(Of Button)
    Private Sub MovesEditor_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Current length of the database: " & MData.Moves.Count
        'TODO: This line of code loads data into the 'MovesDataSet.Moves' table. You can move, or remove it, as needed.
        Me.MovesTableAdapter.Fill(Me.MovesDataSet.Moves)
        'TODO: This line of code loads data into the 'MovesDataSet.Moves' table. You can move, or remove it, as needed.

        '  Delete.Items.Add("Delete")
        'Dim m As Move = New Move
        'm.Name = "Move 1"
        'NewMatchGenerator.Moves.Add(m)
        'm = New Move
        'm.Name = "Move 2"
        'NewMatchGenerator.Moves.Add(m)
        '  AddMoveButton.Top = TemplateButton.Top

        For i = 0 To MData.Moves.Count - 1
            'Dim b As Button = New Button
            'Buttons.Add(b)
            'b.Height = TemplateButton.Height
            'b.Width = TemplateButton.Width
            'b.FlatStyle = TemplateButton.FlatStyle
            'b.Parent = Panel1
            'b.Left = TemplateButton.Left
            'b.Top = TemplateButton.Top + i * (TemplateButton.Height + 2)
            'b.Text = NewMatchGenerator.Moves(i).Name
            ListBox1.Items.Add(MData.Moves(i).Name)
            '  AddMoveButton.Top = b.Bottom + 2
            '   AddHandler b.Click, AddressOf ButtonClicked
        Next

        ' ListBox1.DataSource = NewMatchGenerator.Moves
        '  AddMoveButton.Left = TemplateButton.Left

    End Sub

    'Private Sub ButtonClicked(sender As Object, e As MouseEventArgs)
    '    If e.Button = Windows.Forms.MouseButtons.Right Then
    '        Delete.Show(CType(sender, Control), e.Location)
    '    Else
    '        Dim index As Integer = Buttons.IndexOf(sender)
    '        Dim EditBox As MoveEditForm = New MoveEditForm
    '        EditBox.NewMoveBox1.MyMove = NewMatchGenerator.Moves(index)
    '        EditBox.Show()
    '    End If
    'End Sub
    Public Sub Sort()
        If CheckBox2.Checked Then
            For i = 0 To MData.Moves.Count - 1
                For j = i To MData.Moves.Count - 1
                    If MData.Moves(i).Name > MData.Moves(j).Name Then
                        Dim tempNMG As Move
                        tempNMG = MData.Moves(i)

                        MData.Moves(i) = MData.Moves(j)
                        MData.Moves(j) = tempNMG
                    End If
                Next
            Next
        End If
    End Sub
    Public Sub RefreshButtons()
        'For Each b As Button In Buttons
        '    b.Dispose()
        'Next
        'Buttons.Clear()
        '' AddMoveButton.Top = TemplateButton.Top

        'For i = 0 To NewMatchGenerator.Moves.Count - 1
        '    Dim b As Button = New Button
        '    Buttons.Add(b)
        '    b.Height = TemplateButton.Height
        '    b.Width = TemplateButton.Width
        '    b.FlatStyle = TemplateButton.FlatStyle
        '    b.Parent = Panel1
        '    b.Left = TemplateButton.Left
        '    b.Top = TemplateButton.Top + i * (TemplateButton.Height + 2)
        '    b.Text = NewMatchGenerator.Moves(i).Name
        '    b.ContextMenuStrip = Delete
        '    b.Anchor = TemplateButton.Anchor
        '    '  AddMoveButton.Top = b.Bottom + 2
        '    AddHandler b.Click, AddressOf ButtonClicked
        'Next
        '' AddMoveButton.Left = TemplateButton.Left
        If CheckBox1.Checked Then
            ListBox1.Items.Clear()

            For index = 0 To MData.Moves.Count - 1
                ListBox1.Items.Add(MData.Moves(index).Name)
            Next
            Me.Text = "Current length of the database: " & MData.Moves.Count
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs)
        RefreshButtons()
    End Sub

    Private Sub AddMoveButton_Click() Handles AddMoveButton.Click

        Delete.Location = MousePosition
        Dim M As Move = New Move
        M.Name = "New Move"
        MData.Moves.Add(M)

        RefreshButtons()
    End Sub
    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Save()
        ' CheckForIllegalCrossThreadCalls = False
        ' Dim SaveThread As New Threading.Thread(New Threading.ThreadStart(AddressOf Save))
        ' SaveThread.Start()
    End Sub
    Sub Save()
        Using fs As FileStream = New FileStream(BasicStats.MovesDBPath & "2", FileMode.Create)
            Dim ser As Xml.Serialization.XmlSerializer = New Xml.Serialization.XmlSerializer(GetType(List(Of Move)))
            ser.Serialize(fs, MData.Moves)
            '  Moves = DirectCast(ser.Deserialize(fs), List(Of Move))
        End Using

        Try
            Sort()
            Dim fs As New FileStream(BasicStats.MovesDBPath, FileMode.Create)
            Dim formatter As New BinaryFormatter()
            formatter.Serialize(fs, MData.Moves)
            fs.Close()
            MsgBox("Saved successfully")
            RefreshButtons()
        Catch ex As Exception
            MsgBox("Error while saving:" & vbCrLf & ex.Message)
        End Try
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Edit()
    End Sub
    Private Sub Edit()
        If Not ListBox1.SelectedIndex = -1 Then
            Dim EditBox As MoveEditForm = New MoveEditForm
            EditBox.NewMoveBox1.MyMove = MData.Moves(ListBox1.SelectedIndex)
            EditBox.Show()
        End If
    End Sub

    Private Sub ListBox1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.DoubleClick
        Edit()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        'MsgBox(NewMatchGenerator.Moves.Count)
        ' For i = 113 To 324
        ' Try
        ' NewMatchGenerator.Moves.RemoveAt(113)
        ''Catch ex As Exception
        'End Try
        ' Next
        ' RefreshButtons()
        ' MsgBox(ListBox1.SelectedIndex)
        If Not ListBox1.SelectedIndex = -1 Then
            MData.Moves.RemoveAt(ListBox1.SelectedIndex)
            RefreshButtons()
        End If
    End Sub
    Private Sub LoadAccessDataBase()

        For i = 0 To MovesDataSet.Moves.Count - 1
            If Not IsUsed(MovesDataSet.Moves(i).MoveName) Then
                '  MData.Moves.Add(MovesDataSet.Moves(i)
                Dim NewM As Move = New Move
                With MovesDataSet.Moves(i)
                    NewM.Name = .MoveName
                    NewM.Description = .MoveCom2
                    NewM.SellerPositionBefore = WModel.Position.Standing
                    NewM.SellerPositionAfter = WModel.Position.Lying
                    NewM.AttackerPositionAfter = WModel.Position.Standing
                    NewM.AttackerPositionBefore = WModel.Position.Standing
                    NewM.AllowedStyles = {True, True, True, True, True, True, True}
                End With
                MData.Moves.Add(NewM)
            End If
        Next
        RefreshButtons()
        MsgBox("Done")
        ' MsgBox(MovesDataSet.Moves(1).MoveName)

    End Sub
    Function IsUsed(ByVal S As String) As Boolean
        For i = 0 To MData.Moves.Count - 1
            If MData.Moves(i).Name = S Then
                Return True
            End If
        Next
        Return False
    End Function

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        For i = 0 To MData.Moves.Count - 1
            MData.Moves(i).IsPin = True
        Next
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs)
        LoadAccessDataBase()
    End Sub

    Private Sub ListBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ListBox1.KeyPress

    End Sub

    Private Sub ListBox1_KeyUp(sender As Object, e As KeyEventArgs) Handles ListBox1.KeyUp
        If e.KeyData = Keys.Enter Then
            Edit()
        End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub Button4_Click_2(sender As Object, e As EventArgs)
        MovesetHelper.Show()
    End Sub

    Private Sub SetIds(sender As Object, e As EventArgs) Handles Button4.Click
        For i = 0 To MData.Moves.Count - 1
            MData.Moves(i).id_string = i
        Next
        MsgBox("Done")
    End Sub
End Class