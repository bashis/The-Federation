Public Class MatchStars
    Public value As Double
    Dim one As Integer = 53

    Private Sub MatchStars_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
     
    End Sub

    Dim pbxs(4) As PictureBox
    Dim BackgroundPBXs(4) As PictureBox
    Dim separator As Integer = 0
    Public Sub rebuild(ByVal value As Double)

        Dim covering As Bitmap = My.Resources.star

        DrawBackground()
        Dim ResultImg As Bitmap = New Bitmap(covering.Width * 5 + separator * 4, covering.Height)

        If value > 0 Then
            Using g = Graphics.FromImage(PictureBox1.Image) 'ResultImg)

                For i = 1 To Math.Floor(value)
                    g.DrawImage(covering, New Rectangle((i - 1) * (covering.Width + separator), 0, covering.Width, covering.Height))
                Next
                If value - Math.Floor(value) <> 0 Then

                    Dim b As Bitmap = New Bitmap(NewWidth(covering, value - Math.Floor(value)), covering.Height)
                    Using grp = Graphics.FromImage(b)
                        grp.DrawImage(covering, New Rectangle(0, 0, b.Width, b.Height), New Rectangle(0, 0, b.Width, b.Height), GraphicsUnit.Pixel)
                    End Using
                    g.DrawImage(b, New Rectangle(Math.Floor(value) * (covering.Width + separator), 0, b.Width, b.Height))
                End If
            End Using
        End If

        vlabel.Text = value.ToString.Substring(0, Math.Min(4, value.ToString.Length)) & " stars"
        If value = 5.0 Then
            vlabel.Text += "!!!"
        End If
        vlabel.Left = CInt((PictureBox1.Width - vlabel.Width) / 2)
    End Sub
    Private Function NewWidth(ByVal Img As Bitmap, ByVal stars As Double)
        Return Math.Floor(Img.Width * stars)
    End Function
    Private Sub DrawBackground()
        Dim background As Bitmap = My.Resources.starbg
        Dim ResultImg As Bitmap = New Bitmap(background.Width * 5 + separator * 4, background.Height)
        Using g = Graphics.FromImage(ResultImg)
            For i = 0 To 4
                g.DrawImage(background, New Rectangle(i * (background.Width + separator), 0, background.Width, background.Height))
            Next
            PictureBox1.Image = ResultImg
        End Using
    End Sub
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        DrawBackground()
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class
