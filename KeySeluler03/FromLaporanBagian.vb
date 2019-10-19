Imports CrystalDecisions.CrystalReports.Engine
Public Class FromLaporanBagian
    Private Sub FromLaporanBagian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cryRpt As New ReportDocument
        cryRpt.Load("LaporanBagian.rpt")
        cryRpt.SetDatabaseLogon("Faisalachmaddwicahyono", "29maret97")
        CRV.ReportSource = cryRpt
        CRV.RefreshReport()
    End Sub

    Private Sub CRV_Load(sender As Object, e As EventArgs) Handles CRV.Load

    End Sub
End Class