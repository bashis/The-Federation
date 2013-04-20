Public Class FinanceForm


#Region "Trackbar dependencies handling"
    Dim lastTbValue1, lastTbValue2, lastTbValue3 As Integer
    Private Sub TrackBar3_Scroll(sender As Object, e As EventArgs) Handles TrackBar3.Scroll
        SetTrackBarValue(TrackBar1, TrackBar1.Value + Math.Sign(lastTbValue3 - TrackBar3.Value))
        SetTrackBarValue(TrackBar2, 10 - TrackBar1.Value - TrackBar3.Value)
        setLastTbValues()
    End Sub

    Private Sub TrackBar2_Scroll(sender As Object, e As EventArgs) Handles TrackBar2.Scroll
        SetTrackBarValue(TrackBar3, TrackBar3.Value + Math.Sign(lastTbValue2 - TrackBar2.Value))
        SetTrackBarValue(TrackBar1, 10 - TrackBar2.Value - TrackBar3.Value)
        setLastTbValues()
    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        SetTrackBarValue(TrackBar2, TrackBar2.Value + Math.Sign(lastTbValue1 - TrackBar1.Value))
        SetTrackBarValue(TrackBar3, 10 - TrackBar1.Value - TrackBar2.Value)
        setLastTbValues()
    End Sub
    Sub SetTrackBarValue(ByRef TB As TrackBar, ByVal value As Integer)
        TB.Value = Math.Max(TB.Minimum, Math.Min(TB.Maximum, value))
    End Sub
    Sub setLastTbValues()
        lastTbValue1 = TrackBar1.Value
        lastTbValue2 = TrackBar2.Value
        lastTbValue3 = TrackBar3.Value
    End Sub
#End Region


    Private Sub FinanceForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '    Basic.Promotions(Basic.Promotion).Financial.TopCardFinance.AverageSalary = 100

        TrackBar5.Maximum = Finance.TravelModes.Length - 1
        TrackBar7.Maximum = Finance.AccomodationModes.Length - 1
        '   TrackBar5.Value = Basic.Promotions(Basic.Promotion).Financial.MidCardFinance.TravelMode
        '  TrackBar7.Value = Basic.Promotions(Basic.Promotion).Financial.MidCardFinance.AccomodationMode
        TrackBar9.Maximum = Finance.MedicalCosts.Length - 1

        setLastTbValues()

        DisplayFinance(Basic.Promotions(Basic.Promotion).Financial.MidCardFinance)
    End Sub
    Dim CurrentlySelectedWrestlerCathegory As Finance.WrestlersCathegory
    Private Sub TrackBar6_Scroll(sender As Object, e As EventArgs) Handles TrackBar6.Scroll
        Select Case TrackBar6.Value

            Case 1
                Label6.Text = "Increase Popularity"
            Case 2
                Label6.Text = "Balance"
            Case 3
                Label6.Text = "Increase Money"

        End Select
    End Sub

    Sub UpdateTrackbarsText()
        Label10.Text = Finance.TravelModes(TrackBar5.Value)
        Label14.Text = Finance.AccomodationModes(TrackBar7.Value)
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged, RadioButton3.CheckedChanged, RadioButton1.CheckedChanged

        CurrentlySelectedWrestlerCathegory = New Finance.WrestlersCathegory()

        If RadioButton1.Checked Then
            CurrentlySelectedWrestlerCathegory = Basic.Promotions(Basic.Promotion).Financial.TopCardFinance
        ElseIf RadioButton2.Checked Then
            CurrentlySelectedWrestlerCathegory = Basic.Promotions(Basic.Promotion).Financial.MidCardFinance
        ElseIf RadioButton3.Checked Then
            CurrentlySelectedWrestlerCathegory = Basic.Promotions(Basic.Promotion).Financial.LowCardFinance
        End If

        DisplayFinance(CurrentlySelectedWrestlerCathegory)
    End Sub

    Sub DisplayFinance(ByRef wrestlerCathegory As Finance.WrestlersCathegory)
        NumericUpDown3.Value = wrestlerCathegory.AverageSalary
        TrackBar5.Value = wrestlerCathegory.TravelMode
        TrackBar7.Value = wrestlerCathegory.AccomodationMode
        UpdateTrackbarsText()
    End Sub
    Sub SetFinance()
        With Basic.Promotions(Basic.Promotion).Financial
            .ticketCost = NumericUpDown1.Value
            .AdvertisingCost = NumericUpDown2.Value
            .TimeShow = TrackBar1.Value
            .TimePPVPromos = TrackBar2.Value
            .TimeAdverts = TrackBar3.Value
            .MerchMode = TrackBar6.Value

            Dim wSetter As Finance.WrestlersCathegory = New Finance.WrestlersCathegory()
            With wSetter
                .AverageSalary = NumericUpDown3.Value
                .TravelMode = TrackBar5.Value
                .AccomodationMode = TrackBar7.Value
            End With

            If RadioButton1.Checked Then
                .TopCardFinance = wSetter
            ElseIf RadioButton2.Checked Then
                .MidCardFinance = wSetter
            ElseIf RadioButton3.Checked Then
                .LowCardFinance = wSetter
            End If

            .MedicalInsurance = TrackBar9.Value
        End With
        Label18.Text = Finance.MedicalInsuranceMode(TrackBar9.Value)

        ReportLabel.Text = "Outcome: $" & Outcome() & " per month" & vbCrLf

        Dim maxNumOfViewers As UInteger = 20000
        Dim requiredViewers As UInteger
        Try


            If Outcome() / IncomePerViewer() > maxNumOfViewers Then
                '   MsgBox(maxNumOfViewers & " + (" & Outcome() & "-" & maxNumOfViewers & "*" & IncomePerViewer() & ")/" & IncomePerTVViewer())
                Try
                    requiredViewers = maxNumOfViewers + (Outcome() - maxNumOfViewers * IncomePerViewer()) / IncomePerTVViewer()
                Catch ex As Exception
                    requiredViewers = 0
                End Try
            Else
                Try
                    requiredViewers = Math.Ceiling(Outcome() / IncomePerViewer())
                Catch ex As Exception
                    requiredViewers = 0
                End Try

            End If

            ReportLabel.Text += "We will need ~" & requiredViewers & " viewers for each show to afford it" & vbCrLf &
                "(Assuming there are " & Math.Min(requiredViewers, maxNumOfViewers) & " show visitors and " & Math.Max(0, requiredViewers - maxNumOfViewers) & " TV viewers"
            ''ReportLabel.Text+="It t
        Catch ex As Exception

        End Try
    End Sub
    Function IncomePerTVViewer() As Double
        Return Basic.Promotions(Basic.Promotion).Financial.AdvertisingCost * numberOfShows() * Basic.Promotions(Basic.Promotion).Financial.TimeAdverts / 100
    End Function

    Function IncomePerViewer() As Double

        Dim result As Integer = (numberOfShows() * Basic.Promotions(Basic.Promotion).Financial.ticketCost) * Basic.Promotions(Basic.Promotion).Financial.MerchMode / 2

        '       If Finance.MerchMode = 3 Then
        Return result
    End Function

    Function numberOfShows()
        Dim result As Integer = 0

        For i = 0 To Basic.Promotions(Basic.Promotion).ShowNames.Length - 1
            If Basic.Promotions(Basic.Promotion).ShowNames(i) <> "" Then
                result += 1
            End If
        Next
        Return result
    End Function
    Private Sub NumericUpDown3_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown3.ValueChanged
        SetFinance()
    End Sub
    Private Sub TrackBar5_ValueChanged(sender As Object, e As EventArgs) Handles TrackBar5.ValueChanged
        UpdateTrackbarsText()
        SetFinance()
    End Sub

    Private Sub TrackBar7_ValueChanged(sender As Object, e As EventArgs) Handles TrackBar7.ValueChanged
        UpdateTrackbarsText()
        SetFinance()
    End Sub
    Private Sub TrackBar9_ValueChanged(sender As Object, e As EventArgs) Handles TrackBar9.ValueChanged
        SetFinance()
    End Sub
    Function Outcome() As Integer
        Dim result As Integer = 0
        With Basic.Promotions(Basic.Promotion).Financial
            result += (Finance.AccomodationCosts(.LowCardFinance.AccomodationMode) + .LowCardFinance.AverageSalary + Finance.TravelCosts(.LowCardFinance.TravelMode)) * MData.myLowcarders.Count
            result += (Finance.AccomodationCosts(.MidCardFinance.AccomodationMode) + .MidCardFinance.AverageSalary + Finance.TravelCosts(.MidCardFinance.TravelMode)) * MData.myMidCarders.Count
            result += (Finance.AccomodationCosts(.TopCardFinance.AccomodationMode) + .TopCardFinance.AverageSalary + Finance.TravelCosts(.TopCardFinance.TravelMode)) * MData.myTopCarders.Count
            result += Finance.MedicalCosts(.MedicalInsurance) * MData.mywrestlers.Count
        End With
        Return result
    End Function

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged, NumericUpDown2.ValueChanged
        SetFinance()
    End Sub


    Private Sub TrackBar6_ValueChanged(sender As Object, e As EventArgs) Handles TrackBar6.ValueChanged, TrackBar1.ValueChanged, TrackBar2.ValueChanged, TrackBar3.ValueChanged
        SetFinance()
    End Sub

    Private Sub ReportLabel_Click(sender As Object, e As EventArgs) Handles ReportLabel.Click

    End Sub

    Private Sub GroupBox7_Enter(sender As Object, e As EventArgs) Handles GroupBox7.Enter

    End Sub

    Private Sub TrackBar5_Scroll(sender As Object, e As EventArgs) Handles TrackBar5.Scroll

    End Sub
End Class