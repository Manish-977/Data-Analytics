﻿Public Class Form2
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ComboBox1.Items.Add(TextBox1.Text)
        'TextBox1.Text =""
        'TextBox1.Text = vbEmpty ' add 0
        TextBox1.Clear()
        TextBox1.Focus()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ComboBox1.Items.RemoveAt(ComboBox1.SelectedIndex)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        ComboBox1.Items.Clear()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        End
    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = 13 Then
            ComboBox1.Items.Add(TextBox1.Text)
            TextBox1.Focus()
            TextBox1.SelectionStart = 0
            TextBox1.SelectionLength = Len(TextBox1.Text)
        End If
    End Sub
End Class