Imports System.Data.SqlClient
Public Class FromMenuUtama

    Sub terkunci()
        TransaksiToolStripMenuItem.Enabled = False
    End Sub

    Private Sub DataBarangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataBarangToolStripMenuItem.Click
        FromBarang.ShowDialog()
    End Sub

    Private Sub DataSupplierToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataSupplierToolStripMenuItem.Click
        FromSupplier.ShowDialog()
    End Sub

    Private Sub DataBagianToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataBagianToolStripMenuItem.Click
        FromBagian.ShowDialog()
    End Sub

    Private Sub DataAdminToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataAdminToolStripMenuItem.Click
        FromAdmin.ShowDialog()
    End Sub

    Private Sub BarangMasukToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BarangMasukToolStripMenuItem.Click
        FromTransaksiBarangMasuk.ShowDialog()
    End Sub

    Private Sub FromMentuUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call terkunci()
    End Sub

    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) 
        FromLogin.ShowDialog()
    End Sub

    Private Sub BarangKeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BarangKeluarToolStripMenuItem.Click
        FromTransaksiBarangKeluar.ShowDialog()
    End Sub

    Private Sub FromMentuUtama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Chr(27) Then
            If MessageBox.Show("Tutup aplikasi..?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                End
            End If
        End If
    End Sub


    Private Sub LaporanDataBarangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanDataBarangToolStripMenuItem.Click
        FromLaporanBarang.ShowDialog()
    End Sub

    Private Sub LaporanDataSupplierToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanDataSupplierToolStripMenuItem.Click
        FromLaporanSupplier.ShowDialog()
    End Sub

    Private Sub LaporanDataAdminToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanDataAdminToolStripMenuItem.Click
        FromLaporanAdmin.ShowDialog()
    End Sub

    Private Sub LaporanDataBagianToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanDataBagianToolStripMenuItem.Click
        FromLaporanBagian.ShowDialog()
    End Sub

    Private Sub LaporanBarangMasukToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanBarangMasukToolStripMenuItem.Click
        FromLaporanBarangMasuk.ShowDialog()
    End Sub


    Private Sub btnAdmin_Click(sender As Object, e As EventArgs) Handles btnAdmin.Click
        FromAdmin.ShowDialog()
    End Sub

    Private Sub btnBagian_Click(sender As Object, e As EventArgs) Handles btnBagian.Click
        FromBagian.ShowDialog()
    End Sub

    Private Sub btnBarang_Click(sender As Object, e As EventArgs) Handles btnBarang.Click
        FromBarang.ShowDialog()
    End Sub

    Private Sub btnSupplier_Click(sender As Object, e As EventArgs) Handles btnSupplier.Click
        FromSupplier.ShowDialog()
    End Sub

    Private Sub btnTerima_Click(sender As Object, e As EventArgs) Handles btnTerima.Click
        FromTransaksiBarangMasuk.ShowDialog()
    End Sub

    Private Sub BtnKeluar_Click(sender As Object, e As EventArgs) Handles BtnKeluar.Click
        FromTransaksiBarangKeluar.ShowDialog()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub TransaksiPenerimaanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransaksiPenerimaanToolStripMenuItem.Click
        FromRiwayatPenerimaan.ShowDialog()
    End Sub

    Private Sub TransaksiPengeluaranToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransaksiPengeluaranToolStripMenuItem.Click
        FromRiwayatPengeluaran.ShowDialog()
    End Sub

    Private Sub btnMaster_Click(sender As Object, e As EventArgs) Handles btnMaster.Click
        FromLaporanMaster.ShowDialog()
    End Sub

    Private Sub GantiPasswordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GantiPasswordToolStripMenuItem.Click
        FromGantiPassword.ShowDialog()
    End Sub

    Private Sub PencarianMasterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PencarianMasterToolStripMenuItem.Click
        FromPencarianMaster.ShowDialog()
    End Sub

    Private Sub DataReturToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataReturToolStripMenuItem.Click
        FromReturBarang.ShowDialog()
    End Sub

    Private Sub btnRetur_Click(sender As Object, e As EventArgs) Handles btnRetur.Click
        FromReturBarang.ShowDialog()
    End Sub

    Private Sub btnPencarian_Click(sender As Object, e As EventArgs) Handles btnPencarian.Click
        FromPencarianMaster.ShowDialog()
    End Sub

    Private Sub btngantipass_Click(sender As Object, e As EventArgs) Handles btngantipass.Click
        FromGantiPassword.ShowDialog()
    End Sub

    Private Sub btnriwjual_Click(sender As Object, e As EventArgs) Handles btnriwjual.Click
        FromRiwayatPenerimaan.ShowDialog()
    End Sub

    Private Sub btnriwpeng_Click(sender As Object, e As EventArgs) Handles btnriwpeng.Click
        FromRiwayatPengeluaran.ShowDialog()
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        If MessageBox.Show("Benarkah Anda Ingin Keluar dari aplikasi ini ???", "Konfirmasi",
MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            End
        End If
    End Sub

    Private Sub TransaksiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransaksiToolStripMenuItem.Click

    End Sub

    Private Sub LogoutToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Call terkunci()
        MsgBox("Anda Berhasil Logout")
        Application.Restart()

    End Sub

    Private Sub LaporanBarangKeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanBarangKeluarToolStripMenuItem.Click
        FromLaporanBarangKeluar.ShowDialog()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        FromAbout.ShowDialog()
    End Sub

    Private Sub btnlaporanpenerimaan_Click(sender As Object, e As EventArgs) Handles btnlaporanpenerimaan.Click
        FromLaporanBarangMasuk.ShowDialog()
    End Sub

    Private Sub btnlaporanpengeluaran_Click(sender As Object, e As EventArgs) Handles btnlaporanpengeluaran.Click
        FromLaporanBarangKeluar.ShowDialog()
    End Sub

    Private Sub LaporanDataReturToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanDataReturToolStripMenuItem.Click
        FromLaporanRetur.ShowDialog()
    End Sub
End Class
