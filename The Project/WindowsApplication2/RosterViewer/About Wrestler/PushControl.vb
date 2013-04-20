Public Class PushControl
    Public description As String = "Push"
    Public cur_wr As Object
    Dim _value As Integer
    Public Property value As Integer
        Get
            Return _value
        End Get
        Set(value As Integer)
            _value = value
            stringvalue.Text = value
            ChangePBValue(value)
        End Set
    End Property
    Public Sub rebuild() 'Handles Slider.Scroll

    End Sub
    Public desc_object As Object
    Dim TimerAim As Integer
    Private Sub change_desc_object() Handles pic.MouseEnter, pic.MouseHover, bar.MouseEnter, bar.MouseHover, stringvalue.MouseEnter, stringvalue.MouseHover
        desc_object.text = description
    End Sub
    Private Sub null_desc_object() Handles pic.MouseLeave, bar.MouseLeave, stringvalue.MouseLeave
        desc_object.text = ""
    End Sub

    Private Sub Slider_Scroll(sender As Object, e As System.EventArgs)
        stringvalue.Text = bar.Value.ToString
    End Sub
    Private Sub stringvalue_Click_1(sender As System.Object, e As System.EventArgs) Handles stringvalue.Click
        Dim res As String = InputBox("Input the new value", "Push", bar.Value)
        If res <> "" Then
            Dim n As Integer
            Try
                n = CInt(res)
                If (n >= 0) And (n <= 100) Then
                    cur_wr.stats(5) = n
                    value = n
                Else
                    MsgBox("The value should be between 0 and 100")
                End If
            Catch ex As Exception
                MsgBox("""" & res & """" & "is not a number")
            End Try
        End If
    End Sub

    Sub ChangePBValue(ByVal NewValue As Integer)
        Timer1.Stop()
        TimerAim = NewValue
        ' Dim Addition As Integer = -1
        If TimerAim >= bar.Value Then
            Do Until bar.Value = TimerAim
                ' Addition = Math.Sign(TimerAim - bar.Value)
                bar.Value += 1
            Loop
        Else
            Timer1.Start()
        End If
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If TimerAim - bar.Value >= 0 Then
            Timer1.Stop()
        Else
            bar.Value -= 1
        End If
    End Sub

    Private Sub bar_Click(sender As Object, e As EventArgs) Handles bar.Click

    End Sub
End Class
