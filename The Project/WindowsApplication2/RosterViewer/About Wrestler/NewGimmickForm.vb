Public Class NewGimmickForm
    Public Wrestler As WModel

    Private Sub NewGimmickForm_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

    End Sub
    Private Sub NewGimmickForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        modifier = (Wrestler.stats(2) + Wrestler.stats(5)) / 200
        Generate(3)
       End Sub
    Dim modifier As Double = 1.12
    Dim GimmickControls() As NewGimmickSelector
    Private Sub Generate(ByVal number As Integer)
        If Not GimmickControls Is Nothing Then
            For i = 0 To GimmickControls.Length - 1
                If Not GimmickControls(i) Is Nothing Then
                    If Me.Controls.Contains(GimmickControls(i)) Then
                        Me.Controls.Remove(GimmickControls(i))
                    End If
                End If
            Next
        End If
        lob.Clear()
        ReDim GimmickControls(number - 1)
        If Cost < 1000000 Then
            Cost = CInt(costmultiplyer * Cost)
        End If
        costmultiplyer *= 2
        Fantasy *= 0.9
        modifier *= Fantasy

        Label1.Text = "Cost: " & MData.ToDotView(Cost)

        For i = 0 To number - 1
            GimmickControls(i) = New NewGimmickSelector
            GimmickControls(i).MyGimmick = New Gimmick
            GimmickControls(i).MyGimmick = Gimmick.Generate(modifier)
            If i = 0 Then
                GimmickControls(i).Location = template.Location
            Else
                GimmickControls(i).Top = template.Top
                GimmickControls(i).Left = GimmickControls(i - 1).Right + 5
            End If
            GimmickControls(i).ShowContent()
            Me.Controls.Add(GimmickControls(i))
            AddHandler GimmickControls(i).Button1.Click, AddressOf Selected
            lob.Add(GimmickControls(i).Button1)
        Next
    End Sub
    Public lob As List(Of Button) = New List(Of Button)
    Dim Cost As Integer = 1000
    Dim costmultiplyer As Double = 1.5
    Dim Fantasy As Double = 1
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Generate(3)
    End Sub
    Private Sub Selected(sender As System.Object, e As System.EventArgs)
        Wrestler.Gimmick = GimmickControls(lob.IndexOf(sender)).MyGimmick
        Me.Close()
    End Sub
End Class