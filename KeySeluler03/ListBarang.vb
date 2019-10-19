Imports System.Data.SqlClient
Public Class ListBarang

    Sub tampilkan()
        Call koneksi()
        DA = New SqlDataAdapter("select Kode_Barang, Nama_Barang from Tbl_Barang", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "Tbl_Barang")
        DGV.DataSource = (DS.Tables("Tbl_Barang"))
        DGV.ReadOnly = True
        Call aturkolom()
        Call header()
    End Sub

    Sub header()
        DGV.Columns(0).HeaderText = "Kode"
        DGV.Columns(1).HeaderText = "Nama Barang"
    End Sub

    Sub aturkolom()
        DGV.Columns(0).Width = 70
        DGV.Columns(1).Width = 190
    End Sub

    Private Sub ListBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call tampilkan()
    End Sub

    Private Sub txtCari_Keypress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCari.KeyPress
        If e.KeyChar = Chr(13) Then
            DA = New SqlDataAdapter("select * from Tbl_Barang where Kode_Barang like '%" & txtCari.Text & "%' Or Nama_Barang like '%" & txtCari.Text & "%'", CONN)
            DS = New DataSet
            DA.Fill(DS)
            DGV.DataSource = DS.Tables(0)
        End If
    End Sub

    Private Sub DGV_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DGV.MouseClick
        Dim baris As Integer = DGV.RowCount - 1
        With DGV
            baris = .CurrentRow.Index
            FromTransaksiBarangMasuk.Tkode.Text = .Item(0, baris).Value
            Me.Hide()
            FromTransaksiBarangMasuk.Show()
        End With
    End Sub

End Class