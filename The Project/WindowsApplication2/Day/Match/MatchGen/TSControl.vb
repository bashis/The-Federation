Public Class TSControl
    Public MyTitle As Title
    Private Sub TSControl_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
    Public Sub Reload()

        Dim id As Integer
        ComboBox1.Items.Clear()
        For i = 0 To MData.wrestlers.Length - 1
            ComboBox1.Items.Add(MData.wrestlers(i).name)
            If MData.wrestlers(i).id_string = MyTitle.Holder_ID_String Then
                id = i
            End If
        Next

        ComboBox2.Items.Clear()
        For i = 0 To Basic.Promotions.Count - 1
            ComboBox2.Items.Add(Basic.Promotions(i).Name)
        Next
        ' ComboBox2.Items.AddRange(Basic.P_Names)
 


        If Not MyTitle Is Nothing Then
            With MyTitle
                TextBox1.Text = .id
                TextBox2.Text = .Name
                ComboBox1.SelectedIndex = id
                'TextBox3.Text = .Holder_ID_String
                ' TextBox4.Text = .Prestige
                NumericUpDown1.Value = .Prestige
                'TextBox5.Text = .Promotion
                ComboBox2.SelectedIndex = .Promotion
            End With
        End If
    End Sub
    Public Sub Save()
        MyTitle = New Title
        With MyTitle
            .id = Val(TextBox1.Text)
            .Name = TextBox2.Text
            .Holder_ID_String = MData.wrestlers(ComboBox1.SelectedIndex).id_string
            .Prestige = NumericUpDown1.Value
            .Promotion = ComboBox2.SelectedIndex


        End With
    End Sub
End Class
