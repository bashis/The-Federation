Imports System.Xml.Serialization
Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
Public Class TitleSetup

    Private Sub TitleSetup_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Reload()
    End Sub
    Dim Ctrls() As TSControl
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Basic.Titles.Add(New Title)
        Save()
        Reload()
    End Sub
    Public Sub Reload()
        If Not Basic.Titles Is Nothing Then
            ReDim Ctrls(Basic.Titles.Count - 1)

            For i = 0 To Basic.Titles.Count - 1
                Ctrls(i) = New TSControl
                With Ctrls(i)
                    If i = 0 Then
                        .Location = TsControl1.Location
                    Else
                        .Top = Ctrls(i - 1).Bottom + 2
                        .Left = TsControl1.Left
                    End If
                    .MyTitle = Basic.Titles(i)
                    .Reload()
                End With
                Panel1.Controls.Add(Ctrls(i))
                ToolStripStatusLabel1.Text = Basic.Titles.Count
            Next

        Else
            Basic.Titles = New List(Of Title)
        End If
    End Sub
    Public Sub Save()

        If Not Ctrls Is Nothing Then
            For i = 0 To Ctrls.Length - 1
                If Not Ctrls(i) Is Nothing Then
                    Ctrls(i).Save()
                    'Basic.Titles(i) = New Title
                    Basic.Titles(i) = Ctrls(i).MyTitle
                End If
            Next
        End If
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Save()
        Using objStreamWriter As New StreamWriter(Path.Combine({DefaultConstants.pth, "renamed", "ids", "Titles.xml"}))
            Dim ser As New XmlSerializer(Basic.Titles.GetType)
            ser.Serialize(objStreamWriter, Basic.Titles)
        End Using

        'Dim fs As New FileStream(Path.Combine(DefaultConstants.pth, "renamed", "ids", "Titles.TF2"), FileMode.Create)
        'Dim formatter As New BinaryFormatter()
        'formatter.Serialize(fs, Basic.Titles)
        'fs.Close()
        MsgBox("Saved!")
    End Sub
End Class