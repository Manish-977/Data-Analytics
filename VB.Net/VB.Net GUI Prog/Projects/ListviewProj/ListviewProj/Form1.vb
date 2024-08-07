Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ListView1.Columns.Add("Roll", 50, HorizontalAlignment.Left)
        ListView1.Columns.Add("Name", 150, HorizontalAlignment.Left)
        ListView1.Columns.Add("Course", 100, HorizontalAlignment.Left)
        ListView1.Columns.Add("Email", 100, HorizontalAlignment.Left)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim stu(3) As String
        Dim sitem As ListViewItem
        stu(0) = TextBox1.Text
        stu(1) = TextBox2.Text
        stu(2) = TextBox3.Text
        stu(3) = TextBox4.Text
        sitem = New ListViewItem(stu)
        ListView1.Items.Add(sitem)
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox1.Focus()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        End
    End Sub
End Class
