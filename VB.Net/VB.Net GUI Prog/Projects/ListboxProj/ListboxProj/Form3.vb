Public Class Form3

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("Day")
        ComboBox1.Items.Add("Month")
        ComboBox1.Items.Add("Year")
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedIndex = 0 Then
            ComboBox2.Items.Clear()
            ComboBox2.Items.Add("Sun")
            ComboBox2.Items.Add("Mon")
            ComboBox2.Items.Add("Tue")
            ComboBox2.Items.Add("Wed")
            ComboBox2.Items.Add("Thu")
            ComboBox2.Items.Add("Fri")
            ComboBox2.Items.Add("Sat")
        ElseIf ComboBox1.SelectedIndex = 1 Then
            ComboBox2.Items.Clear()
            ComboBox2.Items.Add("Jan")
            ComboBox2.Items.Add("Feb")
            ComboBox2.Items.Add("Mar")
            ComboBox2.Items.Add("Apr")
        ElseIf ComboBox1.SelectedIndex = 2 Then
            ComboBox2.Items.Clear()
            ComboBox2.Items.Add("2021")
            ComboBox2.Items.Add("2022")
            ComboBox2.Items.Add("2023")

        End If
    End Sub

End Class