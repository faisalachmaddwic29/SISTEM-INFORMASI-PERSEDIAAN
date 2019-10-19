Imports CrystalDecisions.CrystalReports.Engine
Public Class FromLaporanSupplier
    Private Sub FromLaporanSupplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cryRpt As New ReportDocument
        cryRpt.Load("LaporanSupplier.rpt")
        cryRpt.SetDatabaseLogon("Faisalachmaddwicahyono", "29maret97")
        CRV.ReportSource = cryRpt
        CRV.RefreshReport()
    End Sub

End Class