Public Class Form1

    Dim a, b As Integer
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        a = TextBox1.Text
        b = TextBox2.Text
        TextBox3.Text = a + b

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        a = TextBox1.Text
        b = TextBox2.Text
        TextBox3.Text = a - b
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        a = TextBox1.Text
        b = TextBox2.Text
        TextBox3.Text = a * b
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        a = TextBox1.Text
        b = TextBox2.Text
        If b = 0 Then
            TextBox3.Text = "Can not div by Zero"
        Else
            TextBox3.Text = a / b
        End If

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        End
    End Sub
End Class
