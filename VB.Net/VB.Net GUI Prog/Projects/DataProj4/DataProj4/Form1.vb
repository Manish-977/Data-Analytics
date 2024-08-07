Public Class Form1
    Dim con As New OleDb.OleDbConnection
    Dim ds As New DataSet
    Dim da As OleDb.OleDbDataAdapter
    Dim sql As String
    Dim maxRows As Integer
    Dim inc As Integer
    Sub getdata()
        TextBox1.Text = ds.Tables("Emp1").Rows(inc).Item(0)
        TextBox2.Text = ds.Tables("Emp1").Rows(inc).Item(1)
        TextBox3.Text = ds.Tables("Emp1").Rows(inc).Item(2)
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\Users\anant\OneDrive\Documents\Employee.accdb; Persist Security Info=False;"
        con.Open()
        sql = "SELECT * FROM Emp"
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "Emp1")
        con.Close()
        maxRows = ds.Tables("Emp1").Rows.Count
        inc = 0
        getdata()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Next Record
        If inc <> maxRows - 1 Then
            inc = inc + 1
            getdata()
        Else
            MsgBox("No More Rows")
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'Previous Record
        If inc > 0 Then
            inc = inc - 1
            getdata()
        Else
            MsgBox("First Record")
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        'Last Record
        inc = maxRows - 1
        getdata()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        'First Record
        inc = 0
        getdata()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        'Add New Record
        Button6.Enabled = False
        Button7.Enabled = True
        Button8.Enabled = False
        Button9.Enabled = False
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox1.Focus()
        inc = maxRows
        maxRows = maxRows + 1

    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        'Goto First Record and lock save button
        Button7.Enabled = False
        Button6.Enabled = True
        Button8.Enabled = True
        Button9.Enabled = True
        If maxRows > inc Then
            maxRows = inc
        End If
        inc = 0
        getdata()


    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        'Delete Record
        If MessageBox.Show("Are you sure?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then
            MsgBox("Operation Cancelled")
            Exit Sub
        Else
            Dim cb As New OleDb.OleDbCommandBuilder(da)
            ds.Tables("Emp1").Rows(inc).Delete()
            maxRows = maxRows - 1
            inc = 0
            'getdata()
            da.Update(ds, "Emp1")
            getdata()
        End If
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        'Save Record
        If inc <> -1 Then
            Dim cb As New OleDb.OleDbCommandBuilder(da)
            Dim dsNewRow As DataRow
            dsNewRow = ds.Tables("Emp1").NewRow()
            dsNewRow.Item(0) = Val(TextBox1.Text)
            dsNewRow.Item(1) = TextBox2.Text
            dsNewRow.Item(2) = Val(TextBox3.Text)
            ds.Tables("Emp1").Rows.Add(dsNewRow)
            da.Update(ds, "Emp1")
            MsgBox("New Record added to the database")
            Button7.Enabled = False
            Button6.Enabled = True
            Button8.Enabled = True
            Button9.Enabled = True
        End If
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        'Update Record
        Dim cb As New OleDb.OleDbCommandBuilder(da)
        ds.Tables("Emp1").Rows(inc).Item(0) = Val(TextBox1.Text)
        ds.Tables("Emp1").Rows(inc).Item(1) = TextBox2.Text
        ds.Tables("Emp1").Rows(inc).Item(2) = Val(TextBox3.Text)
        da.Update(ds, "Emp1")
        MsgBox("Record updated")
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        End
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Dim SearchId As Integer
        SearchId = TextBox4.Text
        Dim j As Integer
        j = ds.Tables("Emp1").Rows.Count - 1
        inc = 0
        While inc <> j + 1
            If SearchId = ds.Tables("Emp1").Rows(inc).Item(0) Then
                getdata()
                Exit While
            ElseIf inc = j Then
                MsgBox("Record Not Found!!!")
                inc = 0
                TextBox4.Text = ""
                TextBox4.Focus()
                Exit While
            End If
            inc += 1
        End While
        'CurrentRow = inc
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click

    End Sub
End Class
