Imports CrystalDecisions.CrystalReports.Engine
Public Class Form2

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim cryRpt As New ReportDocument
        cryRpt.Load("C:\Users\anant\OneDrive\Documents\Visual Studio 2010\Projects\DataProj4\DataProj4\CrystalReport4.rpt")
        Me.CrystalReportViewer1.ReportSource = cryRpt
    End Sub
End Class