Imports System.IO
Imports System.Xml.Serialization
Imports System.Threading
'Imports MPlayer
Imports Microsoft.Xna.Framework.Media

Public Class MData

    ' Public MusicPlayer As MPlayer.Player = New MPlayer.Player

    Public wrestlers() As WModel
    Public myLowcarders As List(Of WModel) = New List(Of WModel)
    Public myMidCarders As List(Of WModel) = New List(Of WModel)
    Public myTopCarders As List(Of WModel) = New List(Of WModel)


    Public Moves As List(Of Move) = New List(Of Move)
    Public mywrestlers() As WModel

    Public Titles(DefaultConstants.n_of_titles - 1) As Title
    Public Currency As Currency = New Currency
    Public pth As String = DefaultConstants.pth
    Public status As Object = st
    Public Guests() As WGuest

    Public Sub fillWSD(ByVal Dialog As Object)
        Dim stclass As WStats = New WStats
        Dim defclass As DefaultConstants = New DefaultConstants
        Dialog.statclass = stclass
        Dialog.defclass = defclass
        Dialog.autofill(wrestlers)
    End Sub
    Public Sub FillMoney() 'To Be Deleted
        Currency.Money = 1000000
        UpdateMoney()
    End Sub
    Public Sub UpdateMoney()
        ToolStripStatusLabel1.Text = "Money: $" & ToDotView(Currency.Money)
    End Sub
    Public Structure image_Container
        Dim idstring As String
        Dim bigimage As Image
        Dim smallimage As Image
    End Structure
    Public imcontainer() As image_Container
    Public myimcontainer() As image_Container
    Public Sub load_wimages()
        ReDim imcontainer(wrestlers.Length - 1)
        Dim picpath As String
        For i = 0 To wrestlers.Length - 1
            imcontainer(i).idstring = wrestlers(i).id_string
            Dim path1 As String = DefaultConstants.pth & "renamed"
            picpath = path1 & "\" & wrestlers(i).id_string & ".jpg"

            If File.Exists(picpath) Then
                Try
                    imcontainer(i).smallimage = Image.FromFile(picpath)
                Catch ex As Exception
                    imcontainer(i).smallimage = My.Resources._99991
                End Try
            Else
                imcontainer(i).smallimage = My.Resources._99991
            End If

            Dim path2 As String = DefaultConstants.pth & "fullsize"
            picpath = path2 & "\" & wrestlers(i).id_string & ".png"


            If File.Exists(picpath) Then
                Try
                    imcontainer(i).bigimage = Image.FromFile(picpath)
                Catch ex As Exception
                    imcontainer(i).bigimage = My.Resources._9999
                End Try

            Else
                imcontainer(i).bigimage = My.Resources._9999
            End If
            imcontainer(i).idstring = wrestlers(i).id_string

        Next
    End Sub
    Public Sub FillBrands()
        For i = 0 To Basic.Promotions.Count - 1
            ComboBox1.Items.Add(Basic.Promotions(i).Name.ToString)
        Next
        ComboBox1.SelectedIndex = 1
        Basic.Promotion = 1
        Basic.recount()
        ' fillmywrestlers()
    End Sub

    Public Sub change_TitleHolder(ByVal TitleID As Integer, ByVal NewOwner As WModel)

        Titles(TitleID).Holder_ID_String = NewOwner.id_string

    End Sub
    Public Sub fillmywrestlers()
        If Not mywrestlers Is Nothing Then
            Array.Clear(mywrestlers, 0, mywrestlers.Length)
        End If

        If Not myimcontainer Is Nothing Then
            Array.Clear(myimcontainer, 0, myimcontainer.Length)
        End If

        Dim cnt As Integer = 0
        For i = 0 To wrestlers.Length - 1
            If wrestlers(i).Promotion = Basic.Promotion Then
                ReDim Preserve mywrestlers(cnt)
                ReDim Preserve myimcontainer(cnt)
                mywrestlers(cnt) = wrestlers(i)
                myimcontainer(cnt) = imcontainer(i)
                cnt += 1
            End If
        Next

    End Sub
    Public Sub LoadMoves()

        Try
            Using fs As FileStream = New FileStream(BasicStats.MovesDBPath & "2", FileMode.Open)
                Dim ser As XmlSerializer = New XmlSerializer(GetType(List(Of Move)))
                Moves = DirectCast(ser.Deserialize(fs), List(Of Move))
            End Using
        Catch ex As Exception
            MsgBox("Error while loading:" & ex.Message & vbCrLf & ex.ToString())

        End Try



        For i = 0 To Moves.Count - 1
            If Moves(i).Name.Contains("[Pin]") Then Moves(i).IsPin = True

        Next
    End Sub
    Enum SearchType
        All = 0
        OnlyMy = 1
    End Enum
    Public Function find_actual_id(ByVal W As WModel, ByVal Options As SearchType) As Integer
        Dim result As Integer = 0
        Dim arr() As WModel
        Select Case Options
            Case SearchType.OnlyMy
                arr = mywrestlers
            Case Else
                arr = wrestlers
        End Select
        For i = 0 To arr.Length - 1
            If arr(i).id_string = W.id_string Then
                result = i
            End If
        Next
        Return result
    End Function

    Public Function FindMove(ByVal id_String As String) As Move
        For Each eMove As Move In Moves
            If eMove.id_string = id_String Then
                Return eMove
            End If
        Next
        Return Nothing
    End Function
    Dim loaded As Integer
    Dim LoadDataThread As New Thread(New ThreadStart(AddressOf LoadData))
    Dim UpdateLoadingFormThread As New Thread(New ThreadStart(AddressOf UpdateLoadingForm))
    Private Sub MData_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Me.Visible = False


        FillBrands() 'TODO: Delete this sub
        '   WrestlerSelectionDialog1.autofill(wrestlers)
        FillMoney() ' TODO: Delete this sub
        ' Windows.Forms.Control.CheckForIllegalCrossThreadCalls = False
        '  LoadDataThread.Start()
        'UpdateLoadingFormThread.Start()
    End Sub
    Dim showUpdateForm As Boolean
    Sub LoadData()

        'LoadingForm.Show()
        'LoadingForm.Focus()
        'LoadingForm.Maximum = 100


        LoadingForm.MyText = "Loading wrestlers..."
        st.Text = LoadingForm.MyText
        Try
            Dim wrestlersdb As Databases.SimpleDatabase(Of WModel) = New Databases.SimpleDatabase(Of WModel)("renamed\ids\Wrestlers_table.xml")
            wrestlersdb.Load()
            wrestlers = wrestlersdb.Data.ToArray
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
        loaded += 20

        LoadingForm.MyText = "Checking wrestlers..."
        CheckDB()

        '   st.Text = "Idle"
        LoadingForm.MyText = "Loading faces..."
        load_wimages()
        loaded += 20

        LoadingForm.MyText = "Loading moves..."
        LoadMoves()
        loaded += 20

        LoadingForm.MyText = "Preparing for the fight..."
        Sort_WModel_By_Name(wrestlers)
        loaded += 20

        LoadingForm.MyText = "Inspiring wrestlers..."
        fillmywrestlers()
        loaded += 20


        showUpdateForm = False
        st.Text = "Idle"
        Me.Visible = True
        Me.Focus()
    End Sub
    Sub UpdateLoadingForm()


        While showUpdateForm
            LoadingForm.Loaded = loaded
            st.Text = LoadingForm.MyText
            Thread.Sleep(10)
        End While
        LoadingForm.Close()

    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        st.Text = "Opening RosterViewer..."
        RosterViewerForm.Show()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        st.Text = "Opening MatchSetup..."
        MatchSetup.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        st.Text = "Opening DataBase Editor..."
        DBEdit.Show()
    End Sub
    Public Sub ok()
        st.Text = "Idle"
    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click

        'For Each w As WModel In wrestlers
        '    w.Appearance = New WAppearance
        'Next

        st.Text = "Saving wrestlers DataBase..."
        SaveWrestlers()
        MsgBox("Done")
        st.Text = "Idle"
    End Sub
    Public Sub SaveWrestlers()
        Dim objStreamWriter As New StreamWriter(Path.Combine({pth, "renamed", "ids", "Wrestlers_table.xml"}))
        Dim ser As New XmlSerializer(Me.wrestlers.GetType)
        ser.Serialize(objStreamWriter, Me.wrestlers)
        objStreamWriter.Close() 'сериализация массива
    End Sub

    Private Sub AutosaveTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AutosaveTimer.Tick
        st.Text = "Autosaving..."
        SaveWrestlers()
        notifycnt1 = 0
        Notify1.Start()
    End Sub
    Dim notifycnt1 As Integer
    Private Sub Notify1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Notify1.Tick
        If notifycnt1 > 5 Then
            st.Text = "Idle"
            Notify1.Stop()
        Else
            st.Text = "Autosaved"
            notifycnt1 += 1
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged

        If CheckBox1.Checked Then
            If Not AutosaveTimer.Enabled Then
                AutosaveTimer.Start() '
            End If
        ElseIf Not CheckBox1.Checked Then
            If AutosaveTimer.Enabled Then
                AutosaveTimer.Stop()
            End If
        End If
    End Sub

    Private Sub Button1_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.MouseEnter, Button2.MouseEnter, Button3.MouseEnter, Button4.MouseEnter, Button5.MouseEnter
        Dim x As System.Media.SoundPlayer = New System.Media.SoundPlayer
        '   x.SoundLocation = "C:\1.wav"
        '  x.Play()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        PromoForm.Show()

    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox(WSelect.ShowDialog)
    End Sub

    Private Sub Button7_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        ShowViewer.Show()
    End Sub

    Private Sub Button8_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        WrestlerGenerator.Show()
    End Sub

    Public Sub CheckDB()
        Dim noerr As Boolean = True
        For i = 0 To wrestlers.Length - 1
            For j = 0 To wrestlers.Length - 1
                If (i <> j) And noerr Then
                    If wrestlers(i).id_string = wrestlers(j).id_string Then
                        noerr = False
                        MsgBox("Wrestlers with the same ids found! The program may work incorrectly! Please, check your database!")
                    End If
                End If
            Next
        Next
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        TrainingForm.Show()
    End Sub
    Public Function HowMuchTitlesDoesHeOwn(ByVal Wrestler As WModel) As Integer
        Dim cnt As Integer = 0
        For i = 0 To DefaultConstants.n_of_titles - 1
            If Wrestler.Titles(i) <> 0 Then
                cnt += 1
            End If
        Next
        Return cnt
    End Function

    Private Sub WrestlerSelectionDialog1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '    Dim s As WModel = 'WSelect.WrestlerSelectionDialog1.'ShowDialog()
        Dim seldial As WSelect = New WSelect
        Dim res As DialogResult = seldial.ShowDialog()
        If res = Windows.Forms.DialogResult.OK Then
            MsgBox(seldial.WrestlerSelectionDialog1.current_selection.name)
        End If
    End Sub
    Public Function SelectWrestler()
        Dim wsd As WSelect = New WSelect
        wsd.ShowDialog()
        If wsd.DialogResult = Windows.Forms.DialogResult.OK Then
            Return wsd.WrestlerSelectionDialog1.current_selection
        Else
            Return Nothing
        End If

    End Function

    Public Function FindWrestler(ByVal id_string As String) As WModel
        'TODO: MAKE THIS FASTER
        For i = 0 To Me.wrestlers.Length - 1
            If Me.wrestlers(i).id_string = id_string Then
                Return Me.wrestlers(i)
            End If
        Next
        Return Nothing
        '  Array.BinarySearch(MData.wrestlers, id_string, AddressOf ComparerByName)
    End Function
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Basic.Promotion = ComboBox1.SelectedIndex
        Basic.recount()
        '   fillmywrestlers()
    End Sub

    Function ComparerByName(ByVal A As WModel, ByVal B As WModel)
        '  Return Double.Epsilon
        Return A.name.CompareTo(B.name)
    End Function
    Public Sub Sort_WModel_By_Name(ByRef Arr() As WModel)
        'Array.Sort(Arr, AddressOf ComparerByName)

        Dim temp As WModel
        Dim temp2 As image_Container
        For i = 0 To Arr.Length - 1
            For j = i To Arr.Length - 1
                If Arr(i).name > Arr(j).name Then
                    temp = Arr(i)
                    Arr(i) = Arr(j)
                    Arr(j) = temp
                    temp2 = imcontainer(i)
                    imcontainer(i) = imcontainer(j)
                    imcontainer(j) = temp2
                End If
            Next
        Next
    End Sub
    Public Function ToDotView(ByVal num As Integer) As String

        Dim res As String = ""

        Dim ost As Integer = num.ToString.Length Mod 3
        Dim str As String = num.ToString
        ' MsgBox(ost)
        'For i = 0 To num.ToString.Length - 1
        If ost <> 0 Then
            For j = 0 To ost - 1
                res += str(j)
            Next
            res += "."
        End If
        ' MsgBox(res)
        For i = ost To num.ToString.Length - 1 Step 3
            res += str(i) & str(i + 1) & str(i + 2) & "."

        Next
        'Next
        res = res.Substring(0, res.Length - 1)

        Return res
    End Function

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        MTCForm.Show()
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        DayForm.Show()
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        End
    End Sub

    Private Sub Button13_Click(sender As System.Object, e As System.EventArgs) Handles Button13.Click

        TitleSetup.Show()
    End Sub

    Private Sub StatusStrip1_ItemClicked(sender As System.Object, e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles StatusStrip1.ItemClicked

    End Sub

    Private Sub Button14_Click(sender As System.Object, e As System.EventArgs) Handles Button14.Click
        CreateFeud.Show()
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        WatchAllFeuds.Show()
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        MainMenu.Show()
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Dim nmg As NewMatchGenerator = New NewMatchGenerator
        Dim m As Match = New Match
        m.forcedWinnerIndex = 0
        m.isForcedWin = True
        ReDim m.wrestlers(1)
        m.wrestlers(0) = wrestlers(0)
        m.wrestlers(1) = wrestlers(1)
        nmg.MyMatch = m
        nmg.MyShowMode = NewMatchGenerator.ShowMode.Match
        nmg.Show()
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        GimmickSuggestionForm.Show()
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        Try
            StoredGimmicksForm.Show()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button10_Click_1(sender As Object, e As EventArgs) Handles Button10.Click
        RoyalRumbleForm.Show()
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        'For i = 0 To Basic.P_Names.Count - 1
        '    Dim p As New Promotion(Basic.P_Names(i), DArrayToS(Of String)(Basic.ShowNames, i), Basic.Colors(i),
        '                       Basic.Colors2(i), Basic.P_Images1(i), Basic.P_ImagesBG(i),
        '                          DArrayToS(Of String)(Basic.ShowPics, i), DArrayToS(Of String)(Basic.ShowBGPics, i), 1000000, 100)
        '    Basic.Promotions.Add(p)
        'Next
        SerializePromotions()
        MsgBox("Completed!")
    End Sub
    Sub SerializePromotions()
        Dim objStreamWriter As New StreamWriter(Path.Combine({DefaultConstants.pth, "Promotions", "Promotions.xml"}))
        Dim ser As New XmlSerializer(Basic.Promotions.GetType)
        ser.Serialize(objStreamWriter, Basic.Promotions)
        objStreamWriter.Close()
    End Sub
    Public Shared Sub Serialize(Of T)(ByVal obj As T, ByVal Path As String)
        Using objStreamWriter As New StreamWriter(Path)
            Dim ser As New XmlSerializer(obj.GetType)
            ser.Serialize(objStreamWriter, obj)
        End Using
    End Sub
    Public Shared Function Deserealize(Of T)(ByVal Path As String) As T
        Using fs As FileStream = New FileStream(Path, FileMode.Open)
            Dim ser As XmlSerializer = New XmlSerializer(GetType(T))
            Return DirectCast(ser.Deserialize(fs), T)
        End Using
    End Function
    Function DArrayToS(Of T)(ByVal Arr(,) As T, ByVal index As Integer)

        Dim result(Arr.GetLength(1) - 1) As T
        For i = 0 To Arr.GetLength(1) - 1
            result(i) = Arr(index, i)
        Next
        Return result
    End Function

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        For i = 0 To Basic.Promotions.Count - 1
            Basic.Promotions(i).Financial = New Finance
        Next

    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        CountrySetter.Show()
    End Sub
End Class