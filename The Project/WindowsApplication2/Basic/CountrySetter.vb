Public Class CountrySetter
    Dim FilePath As String = System.IO.Path.Combine({DefaultConstants.pth, "Countries", "CountryList.xml"})
    Dim MyCountries As List(Of Country) = New List(Of Country)
    Dim _currentIndex As Integer
    Public Property CurrentIndex As Integer
        Get
            Return _currentIndex
        End Get
        Set(value As Integer)
            If value < 0 Then value = 0
            If value > MyCountries.Count - 1 Then value = MyCountries.Count - 1
            _currentIndex = value
            With MyCountries(value)
                TrackBar1.Value = .WrestlingAddiction
                TextBox2.Text = .Name
                NumericUpDown1.Value = .NameFile
            End With
        End Set
    End Property
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Enabled = False
        Dim s() As String = TextBox1.Text.Split(vbCrLf.ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
        For i = 0 To s.Length - 1
            Dim c As Country = New Country
            With c
                .Name = s(i).Replace(vbTab, "")
            End With
            MyCountries.Add(c)
        Next
        Me.Text = "Countries added: " & MyCountries.Count
        currentIndex = 0

    End Sub


    Private Sub CountrySetter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If System.IO.File.Exists(FilePath) Then
            MyCountries = MData.Deserealize(Of List(Of Country))(FilePath)
            CurrentIndex = 0
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CurrentIndex += 1
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        CurrentIndex -= 1
    End Sub

    Private Sub TrackBar1_ValueChanged(sender As Object, e As EventArgs) Handles TrackBar1.ValueChanged
        If Not MyCountries.Count = 0 Then MyCountries(CurrentIndex).WrestlingAddiction = TrackBar1.Value
    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        If Not MyCountries.Count = 0 Then MyCountries(CurrentIndex).NameFile = NumericUpDown1.Value
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            MData.Serialize(Of List(Of Country))(MyCountries, FilePath)
            MsgBox("Success!")
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        If Not MyCountries.Count = 0 Then MyCountries(CurrentIndex).Name = TextBox2.Text
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        MyCountries.RemoveAt(CurrentIndex)
        CurrentIndex += 1
    End Sub
End Class