Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.EMP' table. You can move, or remove it, as needed.
        Me.EMPTableAdapter.Fill(Me.DataSet1.EMP)

    End Sub
End Class
