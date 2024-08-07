Public Class Form1

    Private Sub TreeView1_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView1.AfterSelect

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim nd As String
        nd = InputBox("Enter Node name")  ' takes input from the user  
        If TreeView1.SelectedNode Is Nothing Then  ' insert a new node.  
            TreeView1.Nodes.Add(nd, nd)
        Else
            TreeView1.SelectedNode.Nodes.Add(nd, nd)   ' insert into the sub node or child node  
        End If

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        

        

    End Sub
End Class
