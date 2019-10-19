Imports CrystalDecisions.CrystalReports.Engine
Public Class FromLaporanBarang
    Private Sub FromLaporanBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cryRpt As New ReportDocument
        cryRpt.Load("LaporanBarang.rpt")
        cryRpt.SetDatabaseLogon("Faisalachmaddwicahyono", "29maret97")
        CRVBarang.ReportSource = cryRpt
        CRVBarang.RefreshReport()
    End Sub
End Class