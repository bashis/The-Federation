Imports System.Windows.Forms

Public Class BranchAddDialog

    Protected m_BlankValid As Boolean = True
    Protected m_ReturnText As String = ""

    Public Overloads Function ShowDialog( _
     ByVal TitleText As String, _
      ByVal PromptText As String, _
      ByVal DefaultText As String, _
      ByVal teams() As Integer, _
      ByVal BlankValid As Boolean) As String
        Dim EnteredText As String
        steams = teams
        m_BlankValid = BlankValid
        Me.Lbl_Prompt.Text = PromptText
        Me.Text = TitleText
        Me.Txt_TextEntry.Text = DefaultText
        Me.ShowDialog()
        EnteredText = m_ReturnText
        Return EnteredText
    End Function

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Me.Txt_TextEntry.Text = "" Then
            Me.But_OK.Enabled = m_BlankValid
        Else
            Me.But_OK.Enabled = True
        End If
    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles But_OK.Click, But_OK.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        m_ReturnText = Me.Txt_TextEntry.Text
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles But_Cancel.Click, But_Cancel.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        m_ReturnText = ""
        Me.Close()
    End Sub
    Dim steams() As Integer
    Public Overloads Shared Function Show(ByVal TitleText As String, ByVal promptText As String, ByRef TextInputted As String, ByVal Teams() As Integer, Optional ByVal IsEmptyValid As Boolean = True) As String
        Dim tmp As New BranchAddDialog
        Return tmp.ShowDialog(TitleText, promptText, TextInputted, Teams, IsEmptyValid)
    End Function

    Private Sub BranchAddDialog_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FillCombobox()
    End Sub

    Public Sub FillCombobox()
        ClearCombobox()
        Dim cnt As Integer = 1
        For i = 0 To steams.Length - 1
            ComboBox1.Items.Add("========= Team " & i + 1 & ": =========")
            For j = 0 To steams(i)
                ComboBox1.Items.Add("Wrestler " & cnt.ToString)
                ComboBox1.Items.Add("Finisher " & cnt.ToString)
                cnt += 1
            Next
        Next
        ComboBox1.Items.Add("========= Other: ==========")
        ComboBox1.Items.Add("Referee")
    End Sub
    Public Sub ClearCombobox()
        Me.ComboBox1.Items.Clear()
        Me.ComboBox1.Items.Add("None")
        Me.ComboBox1.SelectedIndex = 0
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

        If Not ComboBox1.SelectedIndex = 0 Then


            Dim s() = ComboBox1.Text.Split(" ")
            Dim k As Integer
            If s.Length > 1 Then
                k = Val(s(1))
            End If
            Dim out As String = ""
            If Not k = 0 Then
                Select Case s(0)
                    Case "Referee"
                        out = "[R]"
                    Case "Wrestler"
                        out = "[" & k & "]"
                    Case "Finisher"
                        out = "[F_" & k & "]"
                    Case Else
                        out = ""
                End Select
            Else
                If s(0) = "Referee" Then
                    out = "[R]"
                End If
            End If

            If Not Txt_TextEntry.SelectionStart = Nothing Then
                Txt_TextEntry.Text = Txt_TextEntry.Text.Substring(0, Txt_TextEntry.SelectionStart) & out & Txt_TextEntry.Text.Substring(Txt_TextEntry.SelectionStart)
            Else
                Txt_TextEntry.Text = out

            End If

            ComboBox1.SelectedIndex = 0

            Txt_TextEntry.Focus()
            Txt_TextEntry.DeselectAll()
            Txt_TextEntry.SelectionStart = Txt_TextEntry.Text.Length
        End If
    End Sub

End Class
