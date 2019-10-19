Imports System.Data.SqlClient
Public Class FromPencarianMaster

    Private Sub FromPencarianMaster_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Rbbarang_CheckedChanged(sender As Object, e As EventArgs) Handles Rbbarang.CheckedChanged
        Call koneksi()
        DA = New SqlDataAdapter("select * from Tbl_Barang", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "Tbl_Barang")
        DGV.DataSource = (DS.Tables("Tbl_Barang"))
        DGV.ReadOnly = True

        DGV.Columns(0).HeaderText = "Kode Barang"
        DGV.Columns(1).HeaderText = "Nama Barang"
        DGV.Columns(2).HeaderText = "Stok"
        DGV.Columns(3).HeaderText = "Satuan"
        DGV.Columns(4).HeaderText = "Jenis"
        DGV.Columns(5).HeaderText = "Tempat"

        DGV.Columns(0).Width = 130
        DGV.Columns(1).Width = 170
        DGV.Columns(2).Width = 50
        DGV.Columns(3).Width = 70
        DGV.Columns(4).Width = 80
        DGV.Columns(5).Width = 90



    End Sub

    Private Sub Rbsupplier_CheckedChanged(sender As Object, e As EventArgs) Handles Rbsupplier.CheckedChanged
        Call koneksi()
        DA = New SqlDataAdapter("select * from Tbl_Supplier", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "Tbl_Supplier")
        DGV.DataSource = (DS.Tables("Tbl_Supplier"))
        DGV.ReadOnly = True

        DGV.Columns(0).HeaderText = "Kode Supplier"
        DGV.Columns(1).HeaderText = "Nama Supplier"
        DGV.Columns(2).HeaderText = "Alamat"
        DGV.Columns(3).HeaderText = "Telepon"
        DGV.Columns(4).HeaderText = "Email"

        DGV.Columns(0).Width = 130
        DGV.Columns(1).Width = 140
        DGV.Columns(2).Width = 120
        DGV.Columns(3).Width = 70
        DGV.Columns(3).Width = 70

    End Sub

    Private Sub Rbbagian_CheckedChanged(sender As Object, e As EventArgs) Handles Rbbagian.CheckedChanged
        Call koneksi()
        DA = New SqlDataAdapter("select * from Tbl_Bagian", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "Tbl_Bagian")
        DGV.DataSource = (DS.Tables("Tbl_Bagian"))
        DGV.ReadOnly = True

        DGV.Columns(0).HeaderText = "Kode Bagian"
        DGV.Columns(1).HeaderText = "Nama Bagian"
        DGV.Columns(2).HeaderText = "Telepon"

        DGV.Columns(0).Width = 130
        DGV.Columns(1).Width = 130
        DGV.Columns(2).Width = 80
    End Sub

    Private Sub Rbbarangmasuk_CheckedChanged(sender As Object, e As EventArgs) Handles Rbbarangmasuk.CheckedChanged
        Call koneksi()
        DA = New SqlDataAdapter("Select  a.no_masuk,a.tgl_Masuk, b.nama_barang, a.Stok_Masuk,  a.kode_admin,  a.kode_supplier from tbl_DetailMasuk a join tbl_barang b on a.kode_barang = b.kode_barang", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "tbl_DetailMasuk")
        DGV.DataSource = (DS.Tables("tbl_DetailMasuk"))
        DGV.ReadOnly = True
        Call headertextMasuk()
        Call aturkolomMasuk()
    End Sub

    Sub headertextMasuk()
        DGV.Columns(0).HeaderText = "No Masuk"
        DGV.Columns(1).HeaderText = "Tanggal Masuk"
        DGV.Columns(2).HeaderText = "Nama Barang"
        DGV.Columns(3).HeaderText = "Jumlah Masuk"
        DGV.Columns(4).HeaderText = "Kode Admin"
        DGV.Columns(5).HeaderText = "Kode Supplier"

    End Sub

    Sub aturkolomMasuk()
        DGV.Columns(0).Width = 130
        DGV.Columns(1).Width = 130
        DGV.Columns(2).Width = 170
        DGV.Columns(3).Width = 130
        DGV.Columns(4).Width = 130
        DGV.Columns(5).Width = 130
    End Sub

    Private Sub rbbarangkeluar_CheckedChanged(sender As Object, e As EventArgs) Handles rbbarangkeluar.CheckedChanged
        Call koneksi()
        DA = New SqlDataAdapter("Select  a.no_Keluar,a.tgl_Keluar, b.nama_barang, a.Total_Minta , a.Kode_admin , a.kode_Bagian  from tbl_DetailKeluar a join tbl_barang b on a.kode_barang = b.kode_barang", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "tbl_DetailMasuk")
        DGV.DataSource = (DS.Tables("tbl_DetailMasuk"))
        DGV.ReadOnly = True

        DGV.Columns(0).HeaderText = "No Keluar"
        DGV.Columns(1).HeaderText = "Tanggal Keluar"
        DGV.Columns(2).HeaderText = "Nama Barang"
        DGV.Columns(3).HeaderText = "Jumlah Keluar"
        DGV.Columns(4).HeaderText = "Kode Admin"
        DGV.Columns(5).HeaderText = "Kode Bagian"

        DGV.Columns(0).Width = 130
        DGV.Columns(1).Width = 130
        DGV.Columns(2).Width = 170
        DGV.Columns(3).Width = 130
        DGV.Columns(4).Width = 130
        DGV.Columns(5).Width = 130

    End Sub

    Private Sub tpencarian_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tpencarian.KeyPress
        If e.KeyChar = Chr(13) Then
            If Rbbarang.Checked = True Then
                Call koneksi()
                DA = New SqlDataAdapter("select * from tbl_Barang where Kode_Barang like '%" & tpencarian.Text & "%' or Nama_Barang like '%" & tpencarian.Text & "%'", CONN)
                DS = New DataSet
                DA.Fill(DS)
                DGV.DataSource = DS.Tables(0)
            ElseIf Rbsupplier.Checked = True Then
                Call koneksi()
                DA = New SqlDataAdapter("select * from tbl_supplier where Kode_Supplier like '%" & tpencarian.Text & "%' or Nama_Supplier like '%" & tpencarian.Text & "%'", CONN)
                DS = New DataSet
                DA.Fill(DS)
                DGV.DataSource = DS.Tables(0)
            ElseIf Rbbagian.Checked = True Then
                Call koneksi()
                DA = New SqlDataAdapter("select * from tbl_bagian where Kode_tbl_bagian like '%" & tpencarian.Text & "%' or Nama_tbl_bagian like '%" & tpencarian.Text & "%'", CONN)
                DS = New DataSet
                DA.Fill(DS)
                DGV.DataSource = DS.Tables(0)
            ElseIf Rbbarangmasuk.Checked = True Then
                Call koneksi()
                DA = New SqlDataAdapter("Select  a.no_masuk,a.tgl_Masuk, b.nama_barang, a.Stok_Masuk,  a.kode_admin,  a.kode_supplier from tbl_DetailMasuk a join tbl_barang b on a.kode_barang = b.kode_barang where No_masuk like '%" & tpencarian.Text & "%' or Stok_Masuk like '%" & tpencarian.Text & "%' or kode_admin like '%" & tpencarian.Text & "%' or kode_supplier like '%" & tpencarian.Text & "%'", CONN)
                DS = New DataSet
                DA.Fill(DS)
                DGV.DataSource = DS.Tables(0)
            ElseIf rbbarangkeluar.Checked = True Then
                Call koneksi()
                DA = New SqlDataAdapter("Select  a.no_Keluar,a.tgl_Keluar, b.nama_barang, a.Total_Minta , a.Kode_admin , a.kode_Bagian  from tbl_DetailKeluar a join tbl_barang b on a.kode_barang = b.kode_barang where No_keluar like '%" & tpencarian.Text & "%' or Stok_keluar like '%" & tpencarian.Text & "%' or Kode_Admin like '%" & tpencarian.Text & "%' or Kode_bagian like '%" & tpencarian.Text & "%'", CONN)
                DS = New DataSet
                DA.Fill(DS)
                DGV.DataSource = DS.Tables(0)
            ElseIf RBRetur.Checked = True Then
                Call koneksi()
                DA = New SqlDataAdapter("select * from Retur_Barang where Kode_Barang like '%" & tpencarian.Text & "%' or Tgl_Faktur like '%" & tpencarian.Text & "%'", CONN)
                DS = New DataSet
                DA.Fill(DS)
                DGV.DataSource = DS.Tables(0)
            End If
        End If
    End Sub

    Private Sub RBRetur_CheckedChanged(sender As Object, e As EventArgs) Handles RBRetur.CheckedChanged
        Call koneksi()
        DA = New SqlDataAdapter("select * from Retur_Barang", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "Retur_Barang")
        DGV.DataSource = (DS.Tables("Retur_Barang"))
        DGV.ReadOnly = True

        DGV.Columns(0).HeaderText = "Kode Retur"
        DGV.Columns(1).HeaderText = "No Masuk"
        DGV.Columns(2).HeaderText = "Id Detail"
        DGV.Columns(3).HeaderText = "Kode Barang"
        DGV.Columns(4).HeaderText = "Stok Masuk"
        DGV.Columns(5).HeaderText = "Tanggal Masuk"
        DGV.Columns(6).HeaderText = "Jumlah Rusak"
        DGV.Columns(7).HeaderText = "Keterangan Rusak"

        DGV.Columns(0).Width = 130
        DGV.Columns(1).Width = 170
        DGV.Columns(2).Width = 120
        DGV.Columns(3).Width = 120
        DGV.Columns(4).Width = 120
        DGV.Columns(5).Width = 120
        DGV.Columns(6).Width = 120
        DGV.Columns(7).Width = 170

    End Sub
End Class