Public Class Form1

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        TextBox1.Text = DateTimePicker1.Value
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim d1, d2 As Date
        Dim dd As TimeSpan
        Dim r As Integer
        d1 = DateTimePicker1.Value
        d2 = DateTimePicker2.Value
        dd = d1.Subtract(d2)
        r = dd.TotalDays
        dd.t()
        Label1.Text = r
    End Sub
End Class
