Public Class DayWatcher
    Public Promotion As Integer
    Public SName As String
    Public TheDate As Date
    Public ppvMode As Integer
    Public DayOfWeek As Integer
    Public Sub Recount()


        If ppvMode = 0 Then
            If Not Basic.ShowPics(Promotion, DayOfWeek) Is Nothing Then
                template.Image = Basic.ShowPics(Promotion, DayOfWeek)
            Else
                template.Image = My.Resources.bg_free
            End If
        Else
            Dim met As Boolean = False
            For i = 0 To DefaultConstants.PPVsPerYear
                If Not met Then
                    If Basic.PPVs(Promotion, i).PDate.Day = TheDate.Day And
                        Basic.PPVs(Promotion, i).PDate.Month = TheDate.Month And
                        Basic.PPVs(Promotion, i).PDate.Year = TheDate.Year Then
                        If Not Basic.PPVs(Promotion, i).PImage Is Nothing Then
                            template.Image = Basic.PPVs(Promotion, i).PImage
                        Else
                            template.Image = My.Resources.bg_free
                        End If
                        met = True
                    End If
                End If
            Next
        End If
        ListBox1.Items.Add("Promotion: " & Basic.P_Names(Promotion))

        ListBox1.Items.Add("Show Name: " & SName)

        Select Case ppvMode
            Case 0
                ListBox1.Items.Add("Show Type: Regular Show")
            Case 1

                ListBox1.Items.Add("Show Type: Pay-Per-View")
            Case 2
                ListBox1.Items.Add("Show Type: Special Show")
        End Select
      
        ListBox1.Items.Add("Date: " & TheDate.Date)


    End Sub
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub DayWatcher_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ListBox1.Items.Clear()
        Recount()
    End Sub
End Class