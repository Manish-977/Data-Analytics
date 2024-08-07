Imports System.Data.Odbc
Public Class Form3
    Private Function CreateDataSet() As DataSet
        'creating a DataSet object for tables
        Dim dataset As DataSet = New DataSet()
        ' creating the student table
        Dim Students As DataTable = CreateStudentTable()
        dataset.Tables.Add(Students)
        Return dataset
    End Function
    Private Function CreateStudentTable() As DataTable
        Dim Students As DataTable
        Students = New DataTable("Student")
        ' adding columns
        AddNewColumn(Students, "System.Int32", "StudentID")
        AddNewColumn(Students, "System.String", "StudentName")
        AddNewColumn(Students, "System.String", "StudentCity")
        ' adding rows
        AddNewRow(Students, 1, "Amit", "Kolkata")
        AddNewRow(Students, 2, "Rajesh", "Delhi")
        AddNewRow(Students, 3, "Vikas", "Hyderabad")
        AddNewRow(Students, 4, "Sunil", "Bikaner")
        AddNewRow(Students, 5, "Rajat", "Patna")
        Return Students
    End Function
    Private Sub AddNewColumn(ByRef table As DataTable, _
    ByVal columnType As String, ByVal columnName As String)
        Dim column As DataColumn = _
        table.Columns.Add(columnName, Type.GetType(columnType))
    End Sub
    'adding data into the table
    Private Sub AddNewRow(ByRef table As DataTable, ByRef id As Integer, ByRef name As String, ByRef city As String)
        Dim newrow As DataRow = table.NewRow()
        newrow("StudentID") = id
        newrow("StudentName") = Name
        newrow("StudentCity") = city
        table.Rows.Add(newrow)
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim ds As New DataSet
        ds = CreateDataSet()
        DataGridView1.DataSource = ds.Tables("Student")
    End Sub
End Class