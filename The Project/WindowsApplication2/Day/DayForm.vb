Imports System.IO
Public Class DayForm
    Private _MyDate As Date = Basic.CurrentDate
    Property MyDate As Date
        Get
            Return _MyDate
        End Get
        Set(ByVal value As Date)
            Basic.CurrentDate = value
            _MyDate = value
            DateText.Text = value.Date & " " & value.DayOfWeek.ToString
            If Basic.Promotions(Basic.Promotion).ShowNames(value.DayOfWeek) <> "" Then
                ShowButton.Enabled = True
                TodayShow = New Show
                TodayShow.RandomModel()
                TodayShow.BGPic = Basic.Promotions(Basic.Promotion).ShowBGPics(value.DayOfWeek)
                TodayShow.Name = Basic.Promotions(Basic.Promotion).ShowNames(value.DayOfWeek)
                TodayShow.rebuild()
            Else
                ShowButton.Enabled = False
                TodayShow = Nothing
            End If
        End Set
    End Property
    Dim TodayShow As Show
    Private Sub DayForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        MyDate = MyDate
        Dim MyNews As List(Of NewsScreen.News) = New List(Of NewsScreen.News)
        Dim n As NewsScreen.News = New NewsScreen.News
        'With n
        '    .BgPic = My.Resources.bg_raw
        '    .Head = "New Champion!"
        '    .Body = "CM Punk has won the WWE Championship at WrestleMania XXIX! "
        '    .Wrestler = Nothing
        'End With

        'MyNews.Add(n)
        'n = New NewsScreen.News
        'With n
        '    .BgPic = My.Resources.bg_sd
        '    .Head = "New Champion!"
        '    .Body = "Brock Lesnar has won the World HeavyWeight Championship at WrestleMania XXIX! "
        '    .Wrestler = Nothing
        'End With
        'MyNews.Add(n)
        'n = New NewsScreen.News
        'With n
        '    .BgPic = My.Resources.bg_sd
        '    .Head = "New Champion!"
        '    .Body = "Brock Lesnar has won the World HeavyWeight Championship at WrestleMania XXIX! "
        '    .Wrestler = Nothing
        'End With
        'MyNews.Add(n)
        'n = New NewsScreen.News
        'With n
        '    .BgPic = My.Resources.bg_sd
        '    .Head = "New Champion!"
        '    .Body = "Brock Lesnar has won the World HeavyWeight Championship at WrestleMania XXIX! "
        '    .Wrestler = Nothing
        'End With
        'MyNews.Add(n)
        'n = New NewsScreen.News
        'With n
        '    .BgPic = My.Resources.bg_sd
        '    .Head = "New Champion!"
        '    .Body = "Brock Lesnar has won the World HeavyWeight Championship at WrestleMania XXIX! "
        '    .Wrestler = Nothing
        'End With
        'MyNews.Add(n)
        'n = New NewsScreen.News
        'With n
        '    .BgPic = My.Resources.bg_sd
        '    .Head = "New Champion!"
        '    .Body = "Brock Lesnar has won the World HeavyWeight Championship at WrestleMania XXIX! "
        '    .Wrestler = Nothing
        'End With
        'MyNews.Add(n)
        'n = New NewsScreen.News
        'With n
        '    .BgPic = My.Resources.bg_sd
        '    .Head = "New Champion!"
        '    .Body = "Brock Lesnar has won the World HeavyWeight Championship at WrestleMania XXIX! "
        '    .Wrestler = Nothing
        'End With
        MyNews.Add(n)

        NewsScreen1.MyNews = MyNews
        NewsScreen1.LoadNews()

    End Sub

    Dim TwitterMessageCollection As List(Of Twitter.Message) = New List(Of Twitter.Message)
    ''' <summary>
    ''' Twitter Slogan Generator
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Handles Button3.Click
        TwitterMessageCollection.Clear()
        Dim Twit As Twitter.Message
        For i = 0 To RosterViewerForm.random(2, 10)
            Dim RandWr As WModel = MData.wrestlers(RosterViewerForm.random(0, MData.wrestlers.Length - 1))
            If Not RandWr.id_string = "9999" Then
                Twit = New Twitter.Message
                Twit.Sender = RandWr.name
                Twit.Text = TwitsTemplates.RandomTwitAbout(TwitsTemplates.RandomArray, RandWr.name)
                TwitterMessageCollection.Add(Twit)
            End If
        Next
        Twitter1.Messages = TwitterMessageCollection
        Twitter1.Recount()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Schedule.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowButton.Click
        ShowViewer.current_show = TodayShow

        ShowViewer.Show()
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs)

    End Sub
    Public NewsCollection As List(Of NewsItem.Message) = New List(Of NewsItem.Message)
    Private Sub Button4_Click_1(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        For i = 0 To 10
            Dim NI As NewsItem.Message = New NewsItem.Message
            NI.Header = "IMPORTANT MESSAGE #" & i.ToString
            NI.Text = "IMPORTANT MESSAGE #" & i.ToString & " TEXT!" & "IMPORTANT MESSAGE #" & i.ToString & " TEXT!" & "IMPORTANT MESSAGE #" & i.ToString & " TEXT!" & "IMPORTANT MESSAGE #" & i.ToString & " TEXT!" & "IMPORTANT MESSAGE #" & i.ToString & " TEXT!" & "IMPORTANT MESSAGE #" & i.ToString & " TEXT!" & "IMPORTANT MESSAGE #" & i.ToString & " TEXT!" & "IMPORTANT MESSAGE #" & i.ToString & " TEXT!" & "IMPORTANT MESSAGE #" & i.ToString & " TEXT!" & "IMPORTANT MESSAGE #" & i.ToString & " TEXT!" & "IMPORTANT MESSAGE #" & i.ToString & " TEXT!"

            NewsCollection.Add(NI)
        Next
        NewsBase1.MyNews = NewsCollection
        NewsBase1.Recount()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        MyDate = MyDate.AddDays(1)
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowRoster.Click
        RosterViewerForm.Show()
    End Sub

    Private Sub Button6_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        BookPPVForm.MyPPV = Basic.Promotions(Basic.Promotion).PPVs(0)
        BookPPVForm.Show()
    End Sub

    Private Sub NewsScreen1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewsScreen1.Load

    End Sub

    Private Sub DateText_Click(sender As Object, e As EventArgs) Handles DateText.Click

    End Sub
End Class