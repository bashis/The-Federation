Public Class StorylinePic
    Dim _MyWmodel As WModel
    Public Property MyWmodel As WModel
        Get
            Return _MyWmodel
        End Get
        Set(value As WModel)
            _MyWmodel = value

            If Not MyWmodel Is Nothing Then
                Label1.Text = MyWmodel.name
                Center(Label1)
                If MyWmodel.Gimmick.isFace = True Then
                    Label2.Text = "Face"
                Else
                    Label2.Text = "Heel"
                End If
                Center(Label2)
                PictureBox1.BorderStyle = Windows.Forms.BorderStyle.Fixed3D
                PictureBox1.Image = getpicfromidstring(MyWmodel)

                PictureBox1.BorderStyle = Windows.Forms.BorderStyle.None
                Center(PictureBox1)
            Else
                PictureBox1.Image = Nothing
                PictureBox1.BorderStyle = Windows.Forms.BorderStyle.FixedSingle
                Label1.Text = "Not Selected"
                Label2.Text = ""
                Center(PictureBox1)
                Center(Label1)
            End If

        End Set
    End Property
    Public Sub Center(ByRef Obj As Object)
        Dim left As Integer = CInt((Me.Width - Obj.width) / 2)
        Obj.left = left
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        MyWmodel = MData.SelectWrestler
    End Sub

    Private Sub StorylinePic_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        PictureBox1.Image = Nothing
        PictureBox1.BorderStyle = Windows.Forms.BorderStyle.FixedSingle
        Label1.Text = "Not Selected"
        Label2.Text = ""
        Center(PictureBox1)
        Center(Label1)
    End Sub
    Public Shared Function getpicfromidstring(ByVal w As WModel)
        Dim pic As Image = My.Resources._99991
        For i = 0 To MData.myimcontainer.Length - 1
            If MData.myimcontainer(i).idstring = w.id_string Then
                Try
                    pic = MData.myimcontainer(i).smallimage 'Image.FromFile(Path.Combine(Form1.pth, "renamed", w.id_string & ".jpg"))
                Catch ex As Exception
                    Try
                        pic = My.Resources._99991
                    Catch ex2 As Exception
                    End Try
                End Try
            End If
        Next
        Return pic
    End Function
End Class
