Imports System.Data.SqlClient
Public Class ListSupplierMasuk

    Sub tampilkan()
        Call koneksi()
        DA = New SqlDataAdapter("select * from Tbl_Supplier", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "Tbl_Supplier")
        DGV.DataSource = (DS.Tables("Tbl_Supplier"))
        DGV.ReadOnly = True
        Call aturkolom()
        Call header()
    End Sub

    Sub header()
        DGV.Columns(0).HeaderText = "Kode"
        DGV.Columns(1).HeaderText = "Nama Supplier"
        DGV.Columns(2).HeaderText = "Alamat"
        DGV.Columns(3).HeaderText = "Telepon"
        DGV.Columns(4).HeaderText = "Email"
    End Sub

    Sub aturkolom()
        DGV.Columns(0).Width = 70
        DGV.Columns(1).Width = 120
        DGV.Columns(2).Width = 60
        DGV.Columns(3).Width = 70
        DGV.Columns(3).Width = 70
    End Sub

    Private Sub DaftarSupplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call tampilkan()
    End Sub

    Private Sub txtCari_Keypress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCari.KeyPress
        If e.KeyChar = Chr(13) Then
            DA = New SqlDataAdapter("select * from tbl_Supplier where Kode_Supplier like '%" & txtCari.Text & "%' Or Nama_Supplier like '%" & txtCari.Text & "%'", CONN)
            DS = New DataSet
            DA.Fill(DS)
            DGV.DataSource = DS.Tables(0)
        End If
    End Sub

    Private Sub DGV_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DGV.MouseClick
        Dim baris As Integer = DGV.RowCount - 1
        With DGV
            baris = .CurrentRow.Index
            FromTransaksiBarangMasuk.Tsupp.Text = .Item(0, baris).Value
            Me.Hide()
            FromTransaksiBarangMasuk.Show()
        End With
    End Sub

End Class