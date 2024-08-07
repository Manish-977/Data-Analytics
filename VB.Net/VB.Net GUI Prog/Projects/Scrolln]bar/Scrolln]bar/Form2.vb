Public Class Form2

    Private Sub Form2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Click
        GroupBox3.Visible = False
    End Sub

    Private Sub Form2_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.DoubleClick
        GroupBox3.Visible = True
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class