Imports System.Data.SqlClient
Public Class FromRiwayatPengeluaran
    Sub tampilkanbarangkeluar()
        Call koneksi()
        DA = New SqlDataAdapter("Select  a.no_Keluar,a.tgl_Keluar, b.nama_barang, a.Total_Minta  from tbl_DetailKeluar a join tbl_barang b on a.kode_barang = b.kode_barang", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "tbl_DetailMasuk")
        DGVMasuk.DataSource = (DS.Tables("tbl_DetailMasuk"))
        DGVMasuk.ReadOnly = True
        Call headertextMasuk()
        Call aturkolomMasuk()
    End Sub

    Sub headertextMasuk()
        DGVMasuk.Columns(0).HeaderText = "No Keluar"
        DGVMasuk.Columns(1).HeaderText = "Tanggal Keluar"
        DGVMasuk.Columns(2).HeaderText = "Nama Barang"
        DGVMasuk.Columns(3).HeaderText = "Jumlah Keluar"

    End Sub

    Sub aturkolomMasuk()
        DGVMasuk.Columns(0).Width = 130
        DGVMasuk.Columns(1).Width = 130
        DGVMasuk.Columns(2).Width = 170
        DGVMasuk.Columns(3).Width = 130

    End Sub

    Private Sub FromRiwayatPengeluaran_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call tampilkanbarangkeluar()
    End Sub
End Class