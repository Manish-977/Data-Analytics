Public Class Form1
    Dim clearDisplay As Boolean
    Dim Operand1 As Double
    Dim Operand2 As Double
    Dim MathOperator As String
    Private Sub DigitClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click, Button2.Click, Button3.Click, Button4.Click, Button5.Click, Button6.Click, Button7.Click, Button8.Click, Button9.Click, Button11.Click
        If clearDisplay Then
            Label1.Text = ""
            clearDisplay = False
        End If
        Label1.Text = Label1.Text + sender.text
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Label1.Text = ""
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        If Label1.Text.IndexOf(".") >= 0 Then
            Exit Sub
        Else
            Label1.Text = Label1.Text & "."
        End If
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        Operand1 = Convert.ToDouble(Label1.Text)
        MathOperator = "+"
        clearDisplay = True
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        Operand1 = Convert.ToDouble(Label1.Text)
        MathOperator = "-"
        clearDisplay = True
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        Operand1 = Convert.ToDouble(Label1.Text)
        MathOperator = "*"
        clearDisplay = True
    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        Operand1 = Convert.ToDouble(Label1.Text)
        MathOperator = "/"
        clearDisplay = True
    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        Operand1 = Convert.ToDouble(Label1.Text)
        MathOperator = "%"
        clearDisplay = True
    End Sub

    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        Operand1 = Convert.ToDouble(Label1.Text)
        MathOperator = "^"
        clearDisplay = True
    End Sub

    Private Sub Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button19.Click
        Dim result As Double
        Operand2 = Convert.ToDouble(Label1.Text)
        Select Case MathOperator
            Case "+"
                result = Operand1 + Operand2
            Case "-"
                result = Operand1 - Operand2
            Case "*"
                result = Operand1 * Operand2
            Case "/"
                If Operand2 <> "0" Then
                    result = Operand1 / Operand2
                End If
            Case "%"
                result = Operand1 Mod Operand2
            Case "^"
                result = Operand1 ^ Operand2
        End Select
        Label1.Text = result.ToString
        clearDisplay = True
    End Sub
End Class
