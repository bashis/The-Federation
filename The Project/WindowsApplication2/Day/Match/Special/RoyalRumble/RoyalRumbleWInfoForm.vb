Public Class RoyalRumbleWInfoForm

    Private Sub RoyalRumbleWInfoForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Sub New(ByVal myParticipant As RoyalRumbleForm.RRParticipant)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        With myParticipant
            Me.Text = .Wrestler.name
            NameLabel.Text = "Name: " & .Wrestler.name & vbCrLf &
                "Entrance Number: " & .EntranceNumber & vbCrLf &
                "Opponents Eliminated: " & .OpponentsEliminated
            PictureBox1.Image = MData.imcontainer(MData.find_actual_id(.Wrestler, MData.SearchType.All)).smallimage
            ProgressBar1.Value = .Wrestler.stats(5)
            ToolTip1.SetToolTip(ProgressBar1, "Push = " & .Wrestler.stats(5))
        End With
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class