Public Class AddPPV

    Public ThisPPV As Basic.PayPerView
    Public Promotion As Integer
    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        template.Image = My.Resources.bg_free
    End Sub

    Private Sub AddPPV_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ListView1.View = View.Details
        ListView1.Items.Clear()
        ListView1.Columns.Add("Name")
        ListView1.Columns.Add("Seats")
        ListView1.Columns.Add("Cost")
        ListView1.FullRowSelect = True
        For i = 0 To Basic.Arenas.Length - 1
            If Basic.Arenas(i).Name <> "" Then

                Dim lv As ListViewItem = New ListViewItem
                lv.Text = Basic.Arenas(i).Name
                lv.SubItems.Add(MData.ToDotView(Basic.Arenas(i).Places))
                lv.SubItems.Add(MData.ToDotView(Basic.Arenas(i).Cost))
                ListView1.Items.Add(lv)
            End If
        Next
        If ListView1.Items.Count > 1 Then
            ListView1.Items(0).Selected = True
        End If
        For Each column As ColumnHeader In Me.ListView1.Columns
            column.Width = -2
        Next

        Me.Text = "Add Show: " & ThisPPV.PDate
        ' If 
        Obj(0) = WeekdayName(Weekday(ThisPPV.PDate))
        Obj(1) = MonthName(ThisPPV.PDate.Month)

        loadRandom()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        If Not TextBox1.Text = "" Then
            If ListView1.SelectedItems.Count > 0 Then
                ThisPPV.PName = TextBox1.Text
                If Not template.Image Is Nothing Then
                    ThisPPV.PImage = template.Image
                Else
                    ThisPPV.PImage = My.Resources.bg_free
                End If

                Dim mode As Integer = 0
                If RadioButton1.Checked Then
                    mode = 1
                ElseIf RadioButton2.Checked Then
                    mode = 2
                End If
                Basic.AddPPV(Promotion, ThisPPV.PName, ThisPPV.PDate, Basic.Arenas(ListView1.SelectedItems(0).Index), ThisPPV.PImage, mode)

                DayForm.Calendar1.Clear()
                DayForm.Calendar1.Fill()
                Me.Close()

            Else
                MsgBox("You have to select the arena!")
            End If
        Else
            MsgBox("The Show should have a name!")
        End If

    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Dim s As Image = Nothing

        s = open_image()

        If s Is Nothing Then
            template.Image = My.Resources.bg_free
        Else
            template.Image = s
        End If
    End Sub
    Public Function open_image() As Image
        Dim s As OpenFileDialog = New OpenFileDialog
        s.InitialDirectory = Application.StartupPath
        s.Multiselect = False

        '  s.Filter = "Image Files (*" & format & ") | *" & format
        s.ShowDialog()

        If s.FileName = "" Then
            Return Nothing
        End If

        Dim result As Image
        Try
            result = Image.FromFile(s.FileName)
        Catch ex As Exception
            MsgBox("Couldn't open the selected image." & vbCrLf & "Error description:" & vbCrLf & ex.ToString)
            result = Nothing
        End Try
        Return result
    End Function
    Dim Adj() As String = {""}
    Dim Obj() As String = {"", ""}
    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        Dim i1, i2 As Integer
        i1 = Form1.random(0, Adj.Length - 1)
        i2 = Form1.random(0, Obj.Length - 1)

        TextBox1.Text = Adj(i1) & " " & Obj(i2)


    End Sub


    Public Sub loadRandom()
        Dim AdjPath As String = DefaultConstants.pth & "\wrestlergen\adj.txt"
        Dim ObjPath As String = DefaultConstants.pth & "\wrestlergen\obj.txt"

        FileOpen(1, AdjPath, OpenMode.Input)

        Dim cnt As Integer = 0
        Do While Not EOF(1)
            ReDim Preserve Adj(cnt)
            Adj(cnt) = LineInput(1)
            cnt += 1
        Loop

        FileClose(1)

        FileOpen(2, ObjPath, OpenMode.Input)

        cnt = 0
        Do While Not EOF(2)
            ReDim Preserve Obj(cnt + 2)
            Obj(cnt + 2) = LineInput(2)
            cnt += 1
        Loop
        FileClose(2)
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class