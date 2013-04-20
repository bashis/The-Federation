Imports System.Globalization
Imports System.Threading
Public Class Calendar

    Public Structure DayPicker
        Dim PB As PictureBox
        Dim ContainsDate As Date
        Dim LB As Label
        Dim isIncluded As Boolean
        Dim isPPV As Boolean
        Dim SName As String
    End Structure
    Dim empty_image As Image = My.Resources.Empty
    Dim DP(42) As DayPicker
    Public firstdate As Date = "1/1/2012"
    Public Today As Integer = 1
    Dim Labels(7) As Label
    Dim isfirst As Boolean = True
    Private Sub Calendar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("En-US")
        For i = 1 To (Basic.Promotions).Count - 1
            prom_chooser.Items.Add(Basic.Promotions(i).Name)
        Next
        prom_chooser.SelectedIndex = Basic.Promotion - 1
        isfirst = False
        'Build()
    End Sub
    Public Sub Build()
        ' Me.AutoSize = True
        todaydate = New Date(firstdate.Year, firstdate.Month, Math.Min(Today, Date.DaysInMonth(firstdate.Year, firstdate.Month)))
        Dim weekdaynamecolor As Color = Color.NavajoWhite

        template.Visible = False

        For i = 0 To 5
            For j = 1 To 7

                DP(i * 7 + j) = New DayPicker
                DP(i * 7 + j).PB = New PictureBox
                DP(i * 7 + j).LB = New Label

                With DP(i * 7 + j).PB
                    .Height = template.Height
                    .Width = template.Width
                    .BorderStyle = BorderStyle.FixedSingle
                    .Left = template.Left + (template.Width + 1) * (j - 1) 'template.Left + (template.Width + 1) * (j - 1)
                    .Top = template.Top + (template.Height + 1) * i ' template.Top + (template.Height + 1) * i
                    .SizeMode = PictureBoxSizeMode.StretchImage
                End With

                With DP(i * 7 + j).LB
                    .AutoSize = True
                    .Text = "00"
                    '  .Height = Math.Max(1, template.Height - 5)
                    ' .Width = Math.Max(1, template.Width - 5)
                    .Left = template.Left + (template.Width + 1) * (j - 1) + template.Width ' - .Width ' template.Left + (template.Width + 1) * (j - 1) + template.Width
                    .Top = template.Top + (template.Height + 1) * i + template.Height ' - .Height ' template.Top + (template.Height + 1) * i + template.Height
                    .TextAlign = ContentAlignment.TopRight
                    .ForeColor = Color.AliceBlue
                    .BackColor = Color.Black
                End With
                AddHandler DP(i * 7 + j).PB.Click, AddressOf DP_Click

                Me.Controls.Add(DP(i * 7 + j).PB)
                Me.Controls.Add(DP(i * 7 + j).LB)
                DP(i * 7 + j).PB.BringToFront()
                DP(i * 7 + j).LB.BringToFront()
            Next
        Next

        Label1.Visible = False
        For i = 1 To 7
            Labels(i) = New Label
            With Labels(i)
                .Font = Label1.Font
                .BackColor = weekdaynamecolor
                .AutoSize = False
                .TextAlign = ContentAlignment.MiddleCenter
                .Left = DP(i).PB.Left
                .Width = DP(i).PB.Width
                .Top = DP(i).PB.Top - 1 - .Height
                Dim n As Integer = i + 1
                If n = 8 Then
                    n = 1
                End If
                .Text = WeekdayName(n)
            End With
            Me.Controls.Add(Labels(i))
        Next

        prom_chooser.Left = DP(1).PB.Left
        prom_chooser.Top = DP(40).PB.Bottom + 2

        newsh.Left = prom_chooser.Right + 5
        newsh.Top = prom_chooser.Top


        Button1.Left = DP(7).PB.Right - Button1.Width
        Label2.Width = Button1.Left - Button2.Right - 5
        back.Top = DP(1).PB.Top
        back.Left = DP(1).PB.Left
        back.SendToBack()
        back.Height = DP(1).PB.Height * 6 + 5
        back.Width = DP(1).PB.Width * 7 + 6
        Clear()
        Fill()
    End Sub
    Public Sub Clear()
        For i = 1 To DP.Length - 1
            DP(i).PB.Cursor = Cursors.Arrow
            DP(i).LB.Visible = False
            DP(i).PB.Image = Nothing
            DP(i).PB.BackColor = Color.Transparent
            DP(i).isIncluded = False
            DP(i).PB.BorderStyle = Windows.Forms.BorderStyle.None
            DP(i).SName = ""
        Next
    End Sub
    Dim todaydate As Date

    Public Sub Fill()
        Dim InActiveColor As Color = Color.LightGray
        Dim InActiveFontColor As Color = Color.LightGray
        Dim InActiveBackColor As Color = Color.Gray


        Label2.Text = MonthName(firstdate.Month.ToString) & " " & firstdate.Year.ToString

        Dim n As Integer = firstdate.DayOfWeek - 1
        If n = -1 Then n = 6

        For i = 1 To Date.DaysInMonth(firstdate.Year, firstdate.Month)
            DP(n + i).PB.BackColor = Color.WhiteSmoke
            DP(n + i).LB.ForeColor = Color.AliceBlue
            DP(n + i).LB.BackColor = Color.Black



            DP(n + i).LB.Text = i.ToString
            DP(n + i).ContainsDate = New Date(firstdate.Year, firstdate.Month, i)
            DP(n + i).LB.Visible = True
            DP(n + i).isIncluded = True
            DP(n + i).LB.BringToFront()
            DP(n + i).LB.Left = DP(n + i).PB.Right - DP(n + i).LB.Width - 1
            DP(n + i).LB.Top = DP(n + i).PB.Bottom - DP(n + i).LB.Height - 1
            If DP(n + i).ContainsDate.Day = todaydate.Day And DP(n + i).ContainsDate.Month = todaydate.Month And DP(n + i).ContainsDate.Year = todaydate.Year Then
                DP(n + i).LB.ForeColor = Color.Red
            End If
        Next



        If n > 0 Then
            Dim d As Date = firstdate.AddMonths(-1)
            DP(n).LB.Text = Date.DaysInMonth(d.Year, d.Month)
            DP(n).LB.Visible = True
            DP(n).LB.Left = DP(n).PB.Right - DP(n).LB.Width - 1
            DP(n).LB.Top = DP(n).PB.Bottom - DP(n).LB.Height - 1
            DP(n).LB.BringToFront()
            DP(n).PB.BackColor = InActiveColor
            DP(n).LB.BackColor = InActiveBackColor
            DP(n).LB.ForeColor = InActiveFontColor
            If n > 1 Then
                For i = n - 1 To 1 Step -1
                    DP(i).LB.Visible = True
                    DP(i).LB.Text = Val(DP(i + 1).LB.Text) - 1
                    DP(i).LB.Left = DP(i).PB.Right - DP(i).LB.Width - 1
                    DP(i).LB.Top = DP(i).PB.Bottom - DP(i).LB.Height - 1
                    DP(i).LB.BringToFront()

                    DP(i).PB.BackColor = InActiveColor
                    DP(i).LB.BackColor = InActiveBackColor
                    DP(i).LB.ForeColor = InActiveFontColor
                Next
            End If
        End If

        Dim c As Integer = 0
        For i = n + Date.DaysInMonth(firstdate.Year, firstdate.Month) + 1 To 42
            c += 1
            DP(i).LB.Text = c
            DP(i).LB.Visible = True
            DP(i).LB.Left = DP(i).PB.Right - DP(i).LB.Width - 1
            DP(i).LB.Top = DP(i).PB.Bottom - DP(i).LB.Height - 1
            DP(i).LB.BringToFront()
            DP(i).PB.BackColor = Color.LightGray

            DP(i).PB.BackColor = InActiveColor
            DP(i).LB.BackColor = InActiveBackColor
            DP(i).LB.ForeColor = InActiveFontColor
        Next

        MarkDayOfWeek(1)

    End Sub
    Private Function dayToNormal(ByVal day As Integer) As Integer
        If day = 0 Then Return 6
        Return day
    End Function
    Private Sub MarkDayOfWeek(ByVal day As Integer)
        Dim d As Integer
        For i = 1 To DP.Length - 1
            For d = 0 To 6
                If DP(i).ContainsDate.DayOfWeek = d And DP(i).isIncluded = True Then
                    If Not Basic.Promotions(prom_chooser.SelectedIndex + 1).ShowPics(d) Is Nothing Then
                        DP(i).PB.Image = Basic.Promotions(prom_chooser.SelectedIndex + 1).ShowPics(d)
                        DP(i).SName = Basic.Promotions(prom_chooser.SelectedIndex + 1).ShowNames(d)
                        DP(i).PB.Cursor = Cursors.Hand
                    Else
                        DP(i).PB.Image = empty_image
                    End If
                End If
            Next
        Next

        'Search for PPVs:
        For i = 1 To DP.Length - 1
            If DP(i).isIncluded Then
                For j = 0 To DefaultConstants.PPVsPerYear
                    If DP(i).ContainsDate.Day = Basic.Promotions(prom_chooser.SelectedIndex + 1).PPVs(j).PDate.Day And
                        DP(i).ContainsDate.Month = Basic.Promotions(prom_chooser.SelectedIndex + 1).PPVs(j).PDate.Month And
                         DP(i).ContainsDate.Year = Basic.Promotions(prom_chooser.SelectedIndex + 1).PPVs(j).PDate.Year Then
                        DP(i).isPPV = True
                        DP(i).PB.Image = Basic.Promotions(prom_chooser.SelectedIndex + 1).PPVs(j).PImage
                        DP(i).SName = Basic.Promotions(prom_chooser.SelectedIndex + 1).PPVs(j).PName
                        DP(i).PB.Cursor = Cursors.Hand
                    End If
                Next
            End If
        Next





    End Sub
    Dim SelectedIndex As Integer
    Private Sub DP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim index As Integer = GetID(sender)

        If DP(index).isIncluded Then
            For i = 1 To DP.Length - 1
                If i = index Then
                    DP(index).PB.BorderStyle = Windows.Forms.BorderStyle.Fixed3D
                Else
                    DP(i).PB.BorderStyle = Windows.Forms.BorderStyle.None
                End If
            Next
            SelectedIndex = index

            If DP(index).SName <> "" Then
                'If Basic.ShowNames(prom_chooser.SelectedIndex + 1, (DP(GetID(sender)).ContainsDate.DayOfWeek)) <> "" And DP(GetID(sender)).isIncluded Then
                Dim dw As DayWatcher = New DayWatcher
                dw.SName = DP(index).SName
                dw.TheDate = DP(index).ContainsDate
                dw.isPPV = DP(index).isPPV
                dw.Promotion = prom_chooser.SelectedIndex + 1
                dw.DayOfWeek = DP(index).ContainsDate.DayOfWeek
                dw.Recount()
                dw.Show() 'MsgBox(Basic.ShowNames(i, k))
            End If
        End If
    End Sub

    Private Function GetID(ByVal Pic As PictureBox) As Integer
        For i = 1 To DP.Length - 1
            If DP(i).PB Is Pic Then
                Return i
            End If
        Next
        Return -1
    End Function

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        firstdate = DateTimePicker1.Value
        Clear()
        Fill()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        firstdate = firstdate.AddMonths(1)
        Clear()
        Fill()
        '     MarkDayOfWeek(1)
    End Sub

    Private Sub NumericUpDown1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        firstdate = firstdate.AddMonths(-1)
        Clear()
        Fill()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        firstdate = New Date(todaydate.Year, todaydate.Month, 1)
        Clear()
        Fill()

    End Sub

    Private Sub prom_chooser_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles prom_chooser.SelectedIndexChanged
        If Not isfirst Then
            Clear()
            Fill()
        End If
    End Sub

    Private Sub newsh_Click(sender As System.Object, e As System.EventArgs) Handles newsh.Click
        Dim ap As AddPPV = New AddPPV
        If Not SelectedIndex = 0 Then
            ap.ThisPPV.PDate = DP(SelectedIndex).ContainsDate
            ap.Promotion = Basic.Promotion


            ap.Show()
            Clear()
            Fill()
        Else
            MsgBox("Please, select the day first.")
        End If
    End Sub
End Class