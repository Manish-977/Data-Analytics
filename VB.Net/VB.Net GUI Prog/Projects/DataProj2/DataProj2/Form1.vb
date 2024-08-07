Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.DEPT' table. You can move, or remove it, as needed.
        Me.DEPTTableAdapter.Fill(Me.DataSet1.DEPT)

    End Sub
End Class
