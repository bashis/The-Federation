Option Explicit On
Public Class Statviewer
    
    ' Dim value As Integer
    Public description As String = "description"

    Public Sub rebuild() Handles stringvalue.TextChanged
        Dim x As Integer = CInt(stringvalue.Text)
        If (x >= 0) And (x <= 100) Then
            ChangePBValue(x)
            '    MTech010VerticalProgessBar1.Value = x
        End If
    End Sub
    Private Sub stringvalue_Click(sender As System.Object, e As System.EventArgs) Handles stringvalue.Click

    End Sub
    Public desc_object As Object
    Private Sub change_desc_object() Handles pic.MouseEnter, pic.MouseHover, MTech010VerticalProgessBar1.MouseEnter, MTech010VerticalProgessBar1.MouseHover, stringvalue.MouseEnter, stringvalue.MouseHover
        desc_object.text = description
    End Sub
    Private Sub null_desc_object() Handles pic.MouseLeave, MTech010VerticalProgessBar1.MouseLeave, stringvalue.MouseLeave
        desc_object.text = ""
    End Sub
    Dim TimerAim As Integer
    Sub ChangePBValue(ByVal NewValue As Integer)
        Timer1.Stop()
        TimerAim = NewValue
        Dim Addition As Integer = -1
        If TimerAim >= MTech010VerticalProgessBar1.Value Then
            Do Until MTech010VerticalProgessBar1.Value = TimerAim
                Addition = Math.Sign(TimerAim - MTech010VerticalProgessBar1.Value)
                MTech010VerticalProgessBar1.Value += Addition
            Loop
        Else
            Timer1.Start()
        End If
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If TimerAim - MTech010VerticalProgessBar1.Value >= 0 Then
            Timer1.Stop()
        Else
            MTech010VerticalProgessBar1.Value -= 1
        End If
    End Sub

    Private Sub MTech010VerticalProgessBar1_Click(sender As Object, e As EventArgs) Handles MTech010VerticalProgessBar1.Click

    End Sub
End Class
