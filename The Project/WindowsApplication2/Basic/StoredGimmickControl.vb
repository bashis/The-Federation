Public Class StoredGimmickControl
    Public Suggestion As GimmickSuggestion
    Private Sub StoredGimmickControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DeselectPaint()
    End Sub

    Public Sub SelectPaint()
        Me.BackColor = Color.AliceBlue
    End Sub
    Public Sub DeselectPaint()
        Me.BackColor = Color.LightYellow
    End Sub
    Public Sub New(ByVal Suggestion As GimmickSuggestion)
        Me.Suggestion = Suggestion
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        FillInfo()
    End Sub
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Sub FillInfo()
        InfoBox.Text = "Overall: " & Suggestion.MyGimmick.Overall & _
             vbCrLf & "Rating: " & Suggestion.MyGimmick.Rate & vbCrLf & "Role: " & Suggestion.MyGimmick.IsFaceToString & vbCrLf & _
             vbCrLf & "Author: " & Suggestion.MyAutor.name

    End Sub

    Private Sub InfoBox_Click(sender As Object, e As EventArgs) Handles InfoBox.Click

    End Sub
End Class
