Imports CrystalDecisions.CrystalReports.Engine
Public Class FromLaporanBarangKeluar
    Private Sub FromLaporanBarangKeluar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub btnviewperiode_Click(sender As Object, e As EventArgs) Handles btnviewperiode.Click
        Dim cryRpt As New ReportDocument
        cryRpt.Load("LaporanBarangKeluarMaster.rpt")
        cryRpt.SetDatabaseLogon("Faisalachmaddwicahyono", "29maret97")
        CRV.ReportSource = cryRpt
        cryRpt.SetParameterValue("Awal", DTP1.Text)
        cryRpt.SetParameterValue("Akhir", DTP2.Text)
    End Sub

    Private Sub btnviewtanggal_Click(sender As Object, e As EventArgs) Handles btnviewtanggal.Click
        Dim cryRpt As New ReportDocument
        cryRpt.Load("LaporanBarangKeluarTanggal.rpt")
        cryRpt.SetDatabaseLogon("Faisalachmaddwicahyono", "29maret97")
        CRV.ReportSource = cryRpt
        cryRpt.SetParameterValue("awal", DTP3.Text)
    End Sub

    Private Sub btnSemua_Click(sender As Object, e As EventArgs) Handles btnSemua.Click
        Dim cryRpt As New ReportDocument
        cryRpt.Load("LaporanBarangKeluarsemua.rpt")
        cryRpt.SetDatabaseLogon("Faisalachmaddwicahyono", "29maret97")
        CRV.ReportSource = cryRpt
        CRV.RefreshReport()
    End Sub

    Private Sub btngrafik_Click(sender As Object, e As EventArgs) Handles btngrafik.Click
        Dim cryRpt As New ReportDocument
        cryRpt.Load("GrafikBarangKeluar.rpt")
        cryRpt.SetDatabaseLogon("Faisalachmaddwicahyono", "29maret97")
        CRV.ReportSource = cryRpt
        CRV.RefreshReport()
    End Sub
End Class