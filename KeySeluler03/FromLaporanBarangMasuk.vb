Imports CrystalDecisions.CrystalReports.Engine
Public Class FromLaporanBarangMasuk

    Private Sub btnviewperiode_Click(sender As Object, e As EventArgs) Handles btnviewperiode.Click
        Dim cryRpt As New ReportDocument
        cryRpt.Load("laporanmastermasuk.rpt")
        cryRpt.SetDatabaseLogon("Faisalachmaddwicahyono", "29maret97")
        CRV.ReportSource = cryRpt
        cryRpt.SetParameterValue("Awal", DTP1.Text)
        cryRpt.SetParameterValue("Akhir", DTP2.Text)
    End Sub

    Private Sub btnviewtanggal_Click(sender As Object, e As EventArgs) Handles btnviewtanggal.Click
        Dim cryRpt As New ReportDocument
        cryRpt.Load("laporantanggalmasuk.rpt")
        cryRpt.SetDatabaseLogon("Faisalachmaddwicahyono", "29maret97")
        CRV.ReportSource = cryRpt
        cryRpt.SetParameterValue("akhir", DTP3.Text)
    End Sub

    Private Sub btnSemua_Click(sender As Object, e As EventArgs) Handles btnSemua.Click
        Dim cryRpt As New ReportDocument
        cryRpt.Load("laporansemuamasuk.rpt")
        cryRpt.SetDatabaseLogon("Faisalachmaddwicahyono", "29maret97")
        CRV.ReportSource = cryRpt
        CRV.RefreshReport()
    End Sub

    Private Sub BtnGarfik_Click(sender As Object, e As EventArgs) Handles BtnGarfik.Click
        Dim cryRpt As New ReportDocument
        cryRpt.Load("GrafikBarangMasuk.rpt")
        cryRpt.SetDatabaseLogon("Faisalachmaddwicahyono", "29maret97")
        CRV.ReportSource = cryRpt
        CRV.RefreshReport()
    End Sub

    Private Sub FromLaporanBarangMasuk_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class