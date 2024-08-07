Imports System.Data.Odbc
Public Class Form2

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim connection As OdbcConnection = New OdbcConnection()
        connection.ConnectionString = "Dsn=Orcconnect;uid=anant;pwd=a001"
        connection.Open()
        Dim adp As OdbcDataAdapter = New OdbcDataAdapter("select * from dept", connection)
        Dim ds As DataSet = New DataSet()
        adp.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
    End Sub
End Class