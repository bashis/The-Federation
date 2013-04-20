Imports Databases
Imports System.Xml.Serialization
Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
Imports csharp_test

Public Class MTCForm
    Dim haschanged As Boolean = False
    Dim demo As Boolean = False
    Private Sub MTCForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If haschanged Then
            Dim s As MsgBoxResult = MsgBox("Do you want to save changes?", MsgBoxStyle.YesNoCancel)
            If s = MsgBoxResult.Yes Then
                Save()
            ElseIf s = MsgBoxResult.No Then
            Else
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub MTCForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If demo Then
            Button8.Enabled = False
            Button6.Enabled = False
        End If

        LoadTable()
    End Sub
    Private Sub LoadTable()
        Dim fs As New FileStream(
        Path.Combine(DefaultConstants.pth, "Scenario\Match\MSC.tf1"), FileMode.Open)
        Dim newList As List(Of TreeNode) = Nothing
        Dim formatter As New BinaryFormatter()
        newList = DirectCast(
            formatter.Deserialize(fs), 
            List(Of TreeNode))
        fs.Close()
        TreeView1.Nodes.Clear()
        Dim newElement As TreeNode
        For i = 0 To newList.Count - 1
            newElement = newList(i).Clone
            TreeView1.Nodes.Add(newElement)
        Next
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim str As New TreeNode
        Dim teamsStr() As String
        Dim teamsInt() As Integer
        Dim tn As TreeNode = TreeView1.SelectedNode



        Do Until tn.Level = 0
            tn = tn.Parent
        Loop
        teamsStr = tn.Text.Split("x")
        ReDim teamsInt(teamsStr.Length - 1)
        For i = 0 To teamsStr.Length - 1
            teamsInt(i) = Val(teamsStr(i)) - 1
        Next



        Dim s As String = BranchAddDialog.Show("Add Spot", "Enter the spot here:", "", teamsInt, True)
        'InputBox("Input the value:")
        If s <> "" Then
            TreeView1.SelectedNode.Nodes.Add(s)
            TreeView1.SelectedNode = TreeView1.SelectedNode.Nodes(TreeView1.SelectedNode.Nodes.Count - 1)

            If TreeView1.SelectedNode.Level = 1 Then
                TreeView1.SelectedNode.Nodes.Add("Intro")
                TreeView1.SelectedNode.Nodes.Add("Middle")
                TreeView1.SelectedNode.Nodes.Add("Finish")
            End If

            haschanged = True
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If TreeView1.SelectedNode.Level <> 0 Then
            Dim m As MsgBoxResult = MsgBox("Are you sure you want to remove this branch?", MsgBoxStyle.YesNoCancel)
            If m = MsgBoxResult.Yes Then
                haschanged = True
                TreeView1.Nodes.Remove(TreeView1.SelectedNode)
            End If
        Else
            MsgBox("Cannot remove the root")
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If TreeView1.SelectedNode.Level <> 0 Then
            Dim str As String = InputBox("Input the new value:", "Edit", TreeView1.SelectedNode.Text)
            If str <> "" Then
                haschanged = True
                TreeView1.SelectedNode.Text = str
            End If
        End If
    End Sub
    Dim res As String
    Public Function RandomNode(ByVal n As TreeNode) As String
        Dim r As String

        If n.Nodes.Count = 0 Then
            Return n.FullPath
        End If

        Dim ind As Integer = RosterViewerForm.random(0, n.Nodes.Count - 1)
        r = RandomNode(n.Nodes(ind))
        Return r
    End Function
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim mtype As Integer = RosterViewerForm.random(0, TreeView1.Nodes.Count - 1)
        Dim atype As Integer = RosterViewerForm.random(0, TreeView1.Nodes(mtype).Nodes.Count - 1)
        Dim s(2) As String

        Try
            s(0) = RandomNode(TreeView1.Nodes(mtype).Nodes(atype).Nodes(0))
            s(1) = RandomNode(TreeView1.Nodes(mtype).Nodes(atype).Nodes(1))
            s(2) = RandomNode(TreeView1.Nodes(mtype).Nodes(atype).Nodes(2))
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

        Dim result As String = ""
        Dim isfirst As Boolean = True
        For i = 0 To 2
            Dim sp() As String = s(i).Split("/")

            If isfirst Then
                result = "Match Type: " & sp(0) & vbCrLf
                result += "Conditions: " & sp(1) & vbCrLf
                result += vbCrLf
                isfirst = False
            End If

            For j = 3 To sp.Length - 1
                result += sp(j) & " "
            Next
        Next

        '  result = result.Replace("[/]", vbCrLf)


        For j = 1 To 50
            result = result.Replace("[" & j.ToString & "]", "Wrestler " & j.ToString)
            result = result.Replace("[f_" & j.ToString & "]", "Finisher " & j.ToString)
            result = result.Replace("[F_" & j.ToString & "]", "Finisher " & j.ToString)
        Next

        MsgBox(result)
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim msg As MsgBoxResult = MsgBox("Do you really want to save the data?" & vbCrLf & "All previous data will be overwrited!", MsgBoxStyle.YesNoCancel)
        If msg = MsgBoxResult.Yes Then
            Save()
            haschanged = False
            MsgBox("Saved!")
        End If
    End Sub
    Private Sub Save()
        Dim fs As New FileStream(Path.Combine(DefaultConstants.pth, "Scenario\Match\MSC.tf1"), FileMode.Create)
        Dim formatter As New BinaryFormatter()
        Dim nodeList As New List(Of TreeNode)()
        For i = 0 To TreeView1.Nodes.Count - 1
            nodeList.Add(TreeView1.Nodes(i))
        Next
        formatter.Serialize(fs, nodeList)
        fs.Close()

    End Sub
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim newpth As String
        Dim fd As OpenFileDialog = New OpenFileDialog
        fd.Filter = "TF files (*.tf1)|*.tf1"
        fd.ShowDialog()
        If fd.FileName <> "" Then
            newpth = fd.FileName

            Dim fs As New FileStream(newpth, FileMode.Open)
            Dim newList As List(Of TreeNode) = Nothing
            Dim formatter As New BinaryFormatter()
            newList = DirectCast(
                formatter.Deserialize(fs), 
                List(Of TreeNode))
            fs.Close()

            Dim newElement As TreeNode
            'Dim SourceNodes As List(Of TreeNode) = New List(Of TreeNode)(TreeView1.Nodes)
            ' TreeView1.Nodes.Clear()
            '   MsgBox(SourceNodes.Count)

            For i = 0 To newList.Count - 1
                Dim TMP(0) As TreeNode
                newElement = newList(i).Clone
                TMP(0) = newElement
                Dim ar() As TreeNode = MergerKing.SimpleMerge(TreeView1.Nodes(i), TMP).ToArray
                TreeView1.Nodes(i) = ar(0)
            Next

            haschanged = True
            MsgBox("Tree added!")

        End If
    End Sub

    Private Function Array2Node(ByVal Nodes() As TreeNode) As TreeNodeCollection
        Dim a As TreeNodeCollection
        a = Nothing
        a.Clear()
        For i = 0 To Nodes.Length - 1
            a.Add(Nodes(i))
        Next
        Return a
    End Function
    Private Sub TreeToTree(ByVal Node As TreeNode, ByRef ToNode As System.Windows.Forms.TreeNodeCollection) 'TreeNode)

        '   For i = 0 To ToNode.Nodes.Count - 1
        ' If ToNode.Nodes(i).Text = Node.Text Then
        '
        '        End If
        '        Next

        'For Each childNode As TreeNode In Node.Nodes
        '    If Not ToNode.ContainsKey(childNode.Name) Then
        '        Dim newNode As TreeNode = ToNode.Add(childNode.Name)
        '        newNode.Name = childNode.Name
        '        TreeToTree(childNode, newNode.Nodes)
        '    Else
        '        TreeToTree(childNode, ToNode(ToNode.IndexOfKey(childNode.Name)).Nodes)
        '    End If
        'Next
        '  For Each childNode As TreeNode In Node.Nodes
        '       Dim newnode As TreeNode = If(ToNode(childNode.Name), ToNode.Add(childNode.Name, childNode.Name))
        '        TreeToTree(childNode, newnode.Nodes)
        '     Next

    End Sub

    Private Sub addTreeNodes(ByVal parentNodes As TreeNodeCollection, ByVal xmlNode As TreeNode)
        For i = 0 To parentNodes.Count - 1
            If parentNodes.ContainsKey(xmlNode.Name) Then

            End If
        Next


        '   For Each childNode As TreeNode In xmlNode.Nodes
        'If Not parentNodes.ContainsKey(childNode.Name) Then
        ' parentNodes.Add(childNode.Text)
        ' Dim newnode As TreeNode = parentNodes.Add(childNode.Name)
        'newnode.Name = childNode.Name
        'addTreeNodes(newnode.Nodes, childNode)
        ' Else
        ' addTreeNodes(parentNodes(parentNodes.IndexOfKey(childNode.Name)).Nodes, childNode)
        ' End If
        ' Next
        'For Each childNode As TreeNode In xmlNode.Nodes
        'Dim node As TreeNode = If(parentNodes(childNode.Name), parentNodes.Add(childNode.Name, childNode.Name))
        'addTreeNodes(node.Nodes, childNode)
        'Next
    End Sub
    Dim ison As Boolean = True
    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        If ison Then
            StatusStrip1.Visible = False
            Button7.Text = "Show tips"
            TreeView1.Height += StatusStrip1.Height
            Button1.Top += StatusStrip1.Height
            Button2.Top += StatusStrip1.Height
            Button3.Top += StatusStrip1.Height
            Button4.Top += StatusStrip1.Height
            Button5.Top += StatusStrip1.Height
            Button6.Top += StatusStrip1.Height
            Button7.Top += StatusStrip1.Height
            Button8.Top += StatusStrip1.Height
            ison = False
        Else
            StatusStrip1.Visible = True
            Button7.Text = "Hide tips"
            TreeView1.Height -= StatusStrip1.Height
            Button1.Top -= StatusStrip1.Height
            Button2.Top -= StatusStrip1.Height
            Button3.Top -= StatusStrip1.Height
            Button4.Top -= StatusStrip1.Height
            Button5.Top -= StatusStrip1.Height
            Button6.Top -= StatusStrip1.Height
            Button7.Top -= StatusStrip1.Height
            Button8.Top -= StatusStrip1.Height
            ison = True


        End If
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click

        TreeView1.SelectedNode.Nodes.Add("Intro")
        TreeView1.SelectedNode.Nodes.Add("Middle")
        TreeView1.SelectedNode.Nodes.Add("Finish")

        haschanged = True
    End Sub

    Private Sub TreeView1_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView1.AfterSelect

    End Sub

    Private Sub TreeView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles TreeView1.DoubleClick
        Button3.PerformClick()
    End Sub
    Dim temp As TreeNode
    Private Sub TreeView1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TreeView1.KeyUp
        If e.KeyCode = Keys.Delete Then
            Button2.PerformClick()
        ElseIf e.Control = True AndAlso e.KeyCode = Keys.C Then
            temp = TreeView1.SelectedNode.Clone
        ElseIf e.Control = True AndAlso e.KeyCode = Keys.V Then
            If Not temp Is Nothing Then
                TreeView1.SelectedNode.Nodes.Add(temp)
            End If

        End If
    End Sub

    Private Sub ToolStripStatusLabel2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripStatusLabel2.Click

    End Sub

    Private Sub ToolStripStatusLabel3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripStatusLabel3.Click

    End Sub

    Private Sub ToolStripStatusLabel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripStatusLabel1.Click

    End Sub

    Private Sub StatusStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles StatusStrip1.ItemClicked

    End Sub
End Class