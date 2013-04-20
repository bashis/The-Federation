Public Class Schedule
    Private Sub UpdateDate()
        Label1.Text = "Today: " & Basic.CurrentDate.Date & " " & Basic.CurrentDate.Date.DayOfWeek.ToString
    End Sub


    Private Sub DayForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        UpdateDate()


        Calendar1.firstdate = New Date(Basic.CurrentDate.Year, Basic.CurrentDate.Month, 1)
        Calendar1.Today = Basic.CurrentDate.Day
        Calendar1.build()

    End Sub

    Private Sub Calendar1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Calendar1.Load

    End Sub
End Class