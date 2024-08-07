Public Class Form2

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            Label2.Text = Label2.Text + "Hindustan "
        Else
            If CheckBox2.Checked Then
                Label2.Text = Label2.Text + "TOI "
            End If
            If CheckBox3.Checked Then
                Label2.Text = Label2.Text + "Daink Jagran "
            End If
        End If

    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            Label2.Text = Label2.Text + "TOI "
        Else
            Label2.Text = ""
        End If

    End Sub

    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then
            Label2.Text = Label2.Text + "Dinik Jagran "
        Else
            Label2.Text = ""
        End If
    End Sub
End Class