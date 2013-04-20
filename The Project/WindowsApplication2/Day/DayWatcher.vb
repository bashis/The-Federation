Public Class DayWatcher
    Public Promotion As Integer
    Public SName As String
    Public TheDate As Date
    Public isPPV As Boolean
    Public DayOfWeek As Integer
    Public Sub Recount()


        If Not isPPV Then
            If Not Basic.Promotions(Promotion).ShowPics(DayOfWeek) Is Nothing Then
                template.Image = Basic.Promotions(Promotion).ShowPics(DayOfWeek)
            Else
                '  template.Image = My.Resources.bg_free
            End If
        Else
            Dim met As Boolean = False
            For i = 0 To DefaultConstants.PPVsPerYear
                If Not met Then
                    If Basic.Promotions(Promotion).PPVs(i).PDate.Day = TheDate.Day And
                        Basic.Promotions(Promotion).PPVs(i).PDate.Month = TheDate.Month And
                        Basic.Promotions(Promotion).PPVs(i).PDate.Year = TheDate.Year Then
                        If Not Basic.Promotions(Promotion).PPVs(i).PImage Is Nothing Then
                            template.Image = Basic.Promotions(Promotion).PPVs(i).PImage
                        Else
                            '   template.Image = My.Resources.bg_free
                        End If
                        met = True
                    End If
                End If
            Next
        End If

        ul1.Text = Basic.Promotions(Promotion).Name

        ul2.Text = SName & vbCrLf

        If isPPV Then
            ul2.Text += "(Pay-Per-View)"
        Else
            ul2.Text += "(Regular Show)"
        End If

        ul3.Text = TheDate.Date




    End Sub
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub DayWatcher_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class