Public Class MainMenu
    Private _MyDate As Date = Basic.CurrentDate
    Dim TodayShow As Show = New Show
    Property MyDate As Date
        Get
            Return _MyDate
        End Get
        Set(ByVal value As Date)
            Basic.CurrentDate = value
            _MyDate = value
            DateLabel.Text = value.Date & " " & value.DayOfWeek.ToString

            Dim DRem As Integer
            Dim s As String
            Dim cdow As Integer = value.DayOfWeek

            s = Basic.Promotions(Basic.Promotion).ShowNames(cdow)
            While s = ""
                cdow += 1
                If cdow = 7 Then
                    cdow = 0
                End If
                DRem += 1
                s = Basic.Promotions(Basic.Promotion).ShowNames(cdow)
            End While

            If DRem <= 3 Then
                DaysLeftLabel.ForeColor = Color.Red
            Else
                DaysLeftLabel.ForeColor = Color.Black
            End If
            If DRem = 0 Then
                Label1.Text = Label1.Text.Replace("days before", "Tonight:")
                DaysLeftLabel.Visible = False
            Else

                Label1.Text = Label1.Text.Replace("Tonight:", "days before")
                DaysLeftLabel.Visible = True
            End If

            NextShowLabel.Text = s
            DaysLeftLabel.Text = DRem

            If Basic.Promotions(Basic.Promotion).ShowNames(value.DayOfWeek) <> "" Then
                ShowButton.Enabled = True
                TodayShow = New Show
                TodayShow.RandomModel()
                TodayShow.BGPic = Basic.Promotions(Basic.Promotion).ShowBGPics(value.DayOfWeek)
                TodayShow.Name = Basic.Promotions(Basic.Promotion).ShowNames(value.DayOfWeek)
                TodayShow.rebuild()
            Else
                ShowButton.Enabled = False
                TodayShow = Nothing
            End If
        End Set
    End Property
    Dim myImage As Image
    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MyDate = MyDate
        myImage = PictureBox1.Image.Clone()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        MyDate = MyDate.AddDays(1)
    End Sub
    Private Sub PictureBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown
        PictureBox1.Image = Nothing
    End Sub

    Private Sub PictureBox1_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox1.MouseLeave
        PictureBox1.Image = myImage
    End Sub

    Private Sub PictureBox1_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseUp
        PictureBox1.Image = myImage
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Schedule.Show()
    End Sub

    Private Sub ShowButton_Click(sender As Object, e As EventArgs) Handles ShowButton.Click
        ShowViewer.current_show = TodayShow
        ShowViewer.Show()
    End Sub

    Private Sub ShowRoster_Click(sender As Object, e As EventArgs) Handles ShowRoster.Click
        RosterViewerForm.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        ' If Not Basic.PPVs
        BookPPVForm.MyPPV = Basic.Promotions(Basic.Promotion).PPVs(0)
        BookPPVForm.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FinanceForm.Show()
    End Sub
End Class