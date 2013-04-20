Imports System.Threading
Imports FormExtensions
Imports System.IO
Imports System.Xml.Serialization
Imports System.Runtime.Serialization.Formatters.Binary

Public Class LoadingForm
    Dim _isLoaded As Integer
    Public Property Loaded As Integer
        Get
            Return _isLoaded
        End Get
        Set(value As Integer)
            _isLoaded = value
            ProgressBar1.Value = Math.Max(ProgressBar1.Minimum, Math.Min(ProgressBar1.Maximum, value))
        End Set
    End Property
    Dim _maximum As Integer
    Public Property Maximum
        Get
            Return ProgressBar1.Maximum
        End Get
        Set(value)
            ProgressBar1.Maximum = Math.Max(1, value)
        End Set
    End Property
    Public Property MyText As String
        Get
            Return Label1.Text
        End Get
        Set(value As String)
            Label1.Text = value
        End Set
    End Property
    Private Sub LoadingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '  Await Tasks.Task.Run(AddressOf LoadData)
        Basic.Promotion = 1
        Basic.recount()

        LoadData()
        MData.Show()
        Me.Close()

    End Sub
    Sub LoadData()

        ' LoadingForm.Show()
        'LoadingForm.Focus()
        Maximum = 100


        MyText = "Loading wrestlers..."
        MData.st.Text = MyText

        Try
            Dim wrestlersdb As Databases.SimpleDatabase(Of WModel) = New Databases.SimpleDatabase(Of WModel)("renamed\ids\Wrestlers_table.xml")
            wrestlersdb.Load()
            MData.wrestlers = wrestlersdb.Data.ToArray
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try

        Me.ThreadSafe(Sub(x) ProgressBar1.Value += 20)

        Me.ThreadSafe(Sub(x) x.MyText = "Checking wrestlers...")

        MData.CheckDB()

        '   st.Text = "Idle"
        Me.ThreadSafe(Sub(x) x.MyText = "Loading faces...")
        MData.load_wimages()
        Me.ThreadSafe(Sub(x) ProgressBar1.Value += 20)

        Me.ThreadSafe(Sub(x) x.MyText = "Loading promotions...")
        DeserializePromotions()
        LoadTitles()

        Me.ThreadSafe(Sub(x) x.MyText = "Loading moves...")
        MData.LoadMoves()
        Me.ThreadSafe(Sub(x) ProgressBar1.Value += 20)


        Me.ThreadSafe(Sub(x) x.MyText = "Preparing for the fight...")

        MData.Sort_WModel_By_Name(MData.wrestlers)
        Me.ThreadSafe(Sub(x) ProgressBar1.Value += 20)


        Me.ThreadSafe(Sub(x) x.MyText = "Inspiring wrestlers...")
        MData.fillmywrestlers()

        Me.ThreadSafe(Sub(x) ProgressBar1.Value += 20)



        ' showUpdateForm = False
        MData.st.Text = "Idle"

        SetPositions()
        'MData.Show()
        MData.Visible = True
        '   MData.Focus()


    End Sub

    Sub DeserializePromotions()

        Using fs As FileStream = New FileStream(Path.Combine(DefaultConstants.pth, "Promotions", "Promotions.xml"), FileMode.Open)
            Dim ser As XmlSerializer = New XmlSerializer(Basic.Promotions.GetType)
            Basic.Promotions = DirectCast(ser.Deserialize(fs), List(Of Promotion))
        End Using

        For i = 0 To Basic.Promotions.Count - 1
            Basic.Promotions(i).GetImagesFromPaths()
        Next
    End Sub
    Public Sub SetPositions()

        Dim myWList = From p As WModel In MData.mywrestlers.ToList() Select p Order By p.stats(5)


        Dim Quarter As Integer = CInt(Math.Ceiling(MData.mywrestlers.Count / 4))
        Dim Half As Integer = CInt(Math.Ceiling(MData.mywrestlers.Count / 2))
        Dim counter As Integer = 0
        For Each el In myWList
            If counter < Math.Min(Math.Max(Quarter, 6), MData.mywrestlers.Count) Then
                MData.myLowcarders.Add(el)
            ElseIf counter > Math.Max(0, Math.Min(MData.mywrestlers.Count - 6, Quarter * 3)) - 1 Then 'not sure about it
                MData.myTopCarders.Add(el)
            Else
                MData.myMidCarders.Add(el)
            End If

            counter += 1
        Next

        'Dim temp1 As List(Of WModel) = MData.myLowcarders
        'MsgBox(temp1(0).name & vbCrLf & temp1.Count, , MData.mywrestlers.Count)
        'Dim temp2 As List(Of WModel) = MData.myMidCarders
        'MsgBox(temp2(0).name & vbCrLf & temp2.Count, , MData.mywrestlers.Count)
        'Dim temp3 As List(Of WModel) = MData.myTopCarders
        'MsgBox(temp3(0).name & vbCrLf & temp3.Count, , MData.mywrestlers.Count)
    End Sub

    Sub LoadTitles()

        Using fs As FileStream = New FileStream(Path.Combine(DefaultConstants.pth, "renamed", "ids", "Titles.xml"), FileMode.Open)
            Dim ser As XmlSerializer = New XmlSerializer(GetType(List(Of Title)))
            Basic.Titles = DirectCast(ser.Deserialize(fs), List(Of Title))
        End Using

        '        Dim fs As New FileStream(
        'Path.Combine(DefaultConstants.pth, "renamed", "ids", "Titles.TF2"), FileMode.Open)
        '        Dim newList As List(Of Title) = Nothing
        '        Dim formatter As New BinaryFormatter()
        '        Basic.Titles = New List(Of Title)
        '        Basic.Titles = DirectCast(
        '            formatter.Deserialize(fs), 
        '            List(Of Title))
        '        fs.Close()
    End Sub
#Region " Global Variables "
    Dim Point As New System.Drawing.Point()
    Dim X, Y As Integer
#End Region

#Region " GUI "
    Private Sub Form_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove, PictureBox1.MouseMove
        If e.Button = MouseButtons.Left Then
            Point = Control.MousePosition
            Point.X = Point.X - (X)
            Point.Y = Point.Y - (Y)
            Me.Location = Point
        End If
    End Sub

    Private Sub Form_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseDown, PictureBox1.MouseDown
        X = Control.MousePosition.X - Me.Location.X
        Y = Control.MousePosition.Y - Me.Location.Y
    End Sub
#End Region

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        End
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class