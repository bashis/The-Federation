Public Class StoredGimmicksForm

    Dim GimmickControls() As StoredGimmickControl
    Dim _SelectedGimmickControl As StoredGimmickControl = Nothing
    Private Property SelectedGimmickControl As StoredGimmickControl
        Get
            Return _SelectedGimmickControl
        End Get
        Set(value As StoredGimmickControl)
            _SelectedGimmickControl = value
            If value Is Nothing Then
                Button1.Enabled = False
                For Each G As StoredGimmickControl In GimmickControls
                    G.DeselectPaint()
                Next
            Else
                Button1.Enabled = True
            End If
        End Set
    End Property
    Private Sub StoredGimmicksForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i = 0 To Basic.StoredGimmicks.Count - 1
            GimmickControls(i) = New StoredGimmickControl(Basic.StoredGimmicks(i))
            With GimmickControls(i)
                .Left = StoredGimmickControl1.Left + (i Mod 2) * (StoredGimmickControl1.Width + 2)
                If (i = 0) Or (i = 1) Then
                    .Top = StoredGimmickControl1.Top
                Else
                    .Top = GimmickControls(i - 2).Bottom + 2
                End If
            End With
            Panel1.Controls.Add(GimmickControls(i))
            AddHandler GimmickControls(i).Click, AddressOf Selected
            For Each cntrl As Control In GimmickControls(i).Controls
                AddHandler cntrl.Click, AddressOf ControlSelected
            Next
        Next
    End Sub
    Public Sub New()
        If Basic.StoredGimmicks.Count > 0 Then
            ReDim GimmickControls(Basic.StoredGimmicks.Count - 1)
            InitializeComponent()
        Else
            MsgBox("There are no stored gimmicks available")
            Me.Close()
        End If
       

    End Sub
    Sub Selected(ByVal sender As Object, e As EventArgs)
        For Each G As StoredGimmickControl In GimmickControls
            G.DeselectPaint()
        Next
        SelectedGimmickControl = sender
        SelectedGimmickControl.SelectPaint()
    End Sub

    Sub ControlSelected(ByVal sender As Object, e As EventArgs)
        For Each G As StoredGimmickControl In GimmickControls
            If G.Contains(sender) Then
                SelectedGimmickControl = G
                G.SelectPaint()
            Else
                G.DeselectPaint()
            End If
        Next
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim NewOwner As WModel = MData.SelectWrestler()
        If Not NewOwner Is Nothing Then
            NewOwner.Gimmick = SelectedGimmickControl.Suggestion.MyGimmick
            MsgBox("Gimmick set successfully")
        End If


    End Sub

    Private Sub StoredGimmickControl1_Load(sender As Object, e As EventArgs) Handles StoredGimmickControl1.Load

    End Sub

    Private Sub Panel1_Click(sender As Object, e As EventArgs) Handles Panel1.Click
        SelectedGimmickControl = Nothing
    End Sub

End Class