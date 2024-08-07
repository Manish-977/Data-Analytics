Public Class Form2

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Static Start As Integer = -1
        Dim Index As Integer

        Index = Form1.RichTextBox1.Text.IndexOf(txtSearchWord.Text, Start + 1)

        If Not Index = -1 Then
            Form1.RichTextBox1.Focus()
            Form1.RichTextBox1.SelectionStart = Index
            Form1.RichTextBox1.SelectionLength = txtSearchWord.Text.Length
            Form1.RichTextBox1.ScrollToCaret()
            Start = Index
        Else
            MessageBox.Show("Found all the instances of [" & txtSearchWord.Text & "]", "End Search")
            Start = -1
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Not txtSearchWord.Text = "" Then
            If Form1.RichTextBox1.Text.Contains(txtSearchWord.Text) Then
                Form1.RichTextBox1.Text = Replace(Form1.RichTextBox1.Text, txtSearchWord.Text, txtReplaceWord.Text)
                Exit Sub
            Else
                MessageBox.Show("The specified text [" & txtSearchWord.Text & "] was not found.", "Failed Search", _
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtSearchWord.Text = ""
                txtSearchWord.Focus()
                Exit Sub
            End If
        End If
        MessageBox.Show("No search text specified.", "Invalid Search", _
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Form1.RichTextBox1.SelectedText = txtReplaceWord.Text
    End Sub

    Private Sub Form2_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        txtSearchWord.Focus()
    End Sub

   
    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class