Imports CrystalDecisions.CrystalReports.Engine
Public Class FromLaporanAdmin
    Private Sub FromLaporanAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cryRpt As New ReportDocument
        cryRpt.Load("LaporanAdmin.rpt")
        cryRpt.SetDatabaseLogon("Faisalachmaddwicahyono", "29maret97")
        CRV.ReportSource = cryRpt
        CRV.RefreshReport()

    End Sub
End Class