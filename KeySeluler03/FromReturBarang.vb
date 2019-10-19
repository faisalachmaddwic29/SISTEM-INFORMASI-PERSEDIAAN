Imports System.Data.SqlClient
Public Class FromReturBarang

    Sub kosongkan()
        labelretur.Text = ""
        labelnomasuk.Text = ""
        Cdetail.Text = ""
        labeltanggal.Text = ""
        labelkode.Text = ""
        LabelnamaB.Text = ""
        trusak.Text = ""
        labelstokmasuk.Text = ""
        Cdetail.Enabled = False
    End Sub

    Sub datafaktur()
        Call koneksi()
        CMD = New SqlCommand("Select * from tbl_DetailMasuk", CONN)
        RD = CMD.ExecuteReader
        Cdetail.Items.Clear()
        Do While RD.Read
            Cdetail.Items.Add(RD.Item("Id_detail"))
        Loop
    End Sub

    Sub otomatis()
        Call koneksi()
        CMD = New SqlCommand("Select Kode_retur from Retur_Barang where kode_retur in (Select max(Kode_retur) from Retur_Barang)", CONN)
        Dim Urutan As String
        Dim Hitung As Long
        RD = CMD.ExecuteReader
        RD.Read()
        If Not RD.HasRows Then
            Urutan = "001"
        Else
            Hitung = Microsoft.VisualBasic.Right(RD.GetString(0), 3) + 1
            Urutan = Microsoft.VisualBasic.Right("000" & Hitung, 3)
        End If
        labelretur.Text = Urutan
    End Sub

    Sub tampilkan()
        Call koneksi()
        DA = New SqlDataAdapter("select * from Retur_Barang", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "Retur_Barang")
        DGV.DataSource = (DS.Tables("Retur_Barang"))
        DGV.ReadOnly = True
        Call headertext()
        Call aturkolom()
    End Sub

    Sub headertext()
        DGV.Columns(0).HeaderText = "Kode Retur"
        DGV.Columns(1).HeaderText = "No Masuk"
        DGV.Columns(2).HeaderText = "Id Detail"
        DGV.Columns(3).HeaderText = "Kode Barang"
        DGV.Columns(4).HeaderText = "Stok Masuk"
        DGV.Columns(5).HeaderText = "Tanggal Masuk"
        DGV.Columns(6).HeaderText = "Jumlah Rusak"
        DGV.Columns(7).HeaderText = "Keterangan Rusak"

    End Sub

    Sub aturkolom()
        DGV.Columns(0).Width = 130
        DGV.Columns(1).Width = 170
        DGV.Columns(2).Width = 120
        DGV.Columns(3).Width = 120
        DGV.Columns(4).Width = 120
        DGV.Columns(5).Width = 120
        DGV.Columns(6).Width = 120
        DGV.Columns(7).Width = 170

    End Sub

    Private Sub FromReturBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call kosongkan()
        Call datafaktur()
        Call tampilkan()
        tket.MaxLength = 50

    End Sub

    Private Sub CdetailK_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cdetail.SelectedIndexChanged
        Call koneksi()
        CMD = New SqlCommand("Select * from Tbl_DetailMasuk where Id_detail = '" & Cdetail.Text & "'", CONN)
        RD = CMD.ExecuteReader
        RD.Read()
        If RD.HasRows Then
            labeltanggal.Text = RD.Item("tgl_Masuk")
            labelnomasuk.Text = RD.Item("No_Masuk")
            labelkode.Text = RD.Item("Kode_Barang")
            labelstokmasuk.Text = RD.Item("Stok_Masuk")
        End If
    End Sub

    Private Sub LabelnamaB_Click(sender As Object, e As EventArgs) Handles LabelnamaB.Click
        Call koneksi()
        CMD = New SqlCommand("Select * from Tbl_Barang where Kode_Barang = '" & labelkode.Text & "'", CONN)
        RD = CMD.ExecuteReader
        RD.Read()
        If RD.HasRows Then
            LabelnamaB.Text = RD.Item("Nama_Barang")
        End If
    End Sub

    Private Sub trusak_KeyPress(sender As Object, e As KeyPressEventArgs) Handles trusak.KeyPress
        If e.KeyChar = Chr(13) Then tket.Focus()
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled() = True
    End Sub

    Private Sub btnInput_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInput.Click
        Call koneksi()
        BtnEdit.Enabled = False
        btnKeluar.Enabled = False
        btnHapus.Enabled = False
        Cdetail.Enabled = True
        CMD = New SqlCommand("Select * from Retur_Barang Where Kode_retur = '" & labelretur.Text & "'", CONN)
        RD = CMD.ExecuteReader
        RD.Read()


        Try
            If Cdetail.Text = "" Or trusak.Text = "" Or tket.Text = "" Then

                btnInput.Text = "Simpan"
                Call otomatis()
                Exit Sub

            Else
                Call koneksi()
                btnInput.Text = "Input"

                Dim SqlTambah As String = "Insert into Retur_Barang Values ('" & labelretur.Text & "','" & labelnomasuk.Text & "', '" & Cdetail.Text & "' , '" & labelkode.Text & "', '" & labelstokmasuk.Text & "', '" & labeltanggal.Text & "', '" & trusak.Text & "', '" & tket.Text & "' )"
                CMD = New SqlCommand(SqlTambah, CONN)
                CMD.ExecuteNonQuery()

                MsgBox("Data berhasil di Input", MsgBoxStyle.Information, "Information")
                Call kosongkan()
                Call tampilkan()

            End If
        Catch ex As Exception
            MsgBox("Data  '" & labelretur.Text & "' Sudah ada")
        End Try

        btnInput.Text = "Input"
        BtnEdit.Enabled = True
        btnKeluar.Enabled = True
        btnHapus.Enabled = True
        Call kosongkan()

    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEdit.Click
        btnInput.Enabled = False
        btnKeluar.Enabled = False
        btnHapus.Enabled = False

        If Cdetail.Text = "" Or trusak.Text = "" Or tket.Text = "" Then
            BtnEdit.Text = "Update"
            Exit Sub
        Else
            Call koneksi()
            Dim sqledit As String = "update Retur_Barang set Id_Detail='" & Cdetail.Text & "',No_Masuk='" & labelnomasuk.Text & "', Kode_barang = '" & labelkode.Text & "', Stok_Masuk = '" & labelstokmasuk.Text & "',Tgl_Faktur='" & labeltanggal.Text & "',Jumlah_rusak='" & trusak.Text & "',Ket_Faktur='" & tket.Text & "' where Kode_Retur = '" & labelretur.Text & "'"
            CMD = New SqlCommand(sqledit, CONN)
            CMD.ExecuteNonQuery()
            If MessageBox.Show("Anda yakin ingin Mengganti?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                Call kosongkan()
                Call tampilkan()
            End If
        End If
        BtnEdit.Text = "Edit"
        btnInput.Enabled = True
        btnKeluar.Enabled = True
        btnHapus.Enabled = True


    End Sub

    Private Sub btnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHapus.Click
        If labelretur.Text = "" Then
            MsgBox("Isi kode barang terlebih dahulu")
            labelretur.Focus()
            Exit Sub
        Else

            If MessageBox.Show("Yakin ingin menghapus ? ", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                Call koneksi()
                Dim hapus As String = "delete  from Retur_Barang where Kode_Retur='" & labelretur.Text & "'"
                CMD = New SqlCommand(hapus, CONN)
                CMD.ExecuteNonQuery()
                Call kosongkan()
                Call tampilkan()

            Else
                Call kosongkan()
                btnInput.Text = "Input"
                BtnEdit.Text = "Edit"
            End If
        End If
    End Sub

    Private Sub btnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBatal.Click
        Call kosongkan()
        btnInput.Text = "Input"
        BtnEdit.Text = "Edit"
        btnInput.Enabled = True
        BtnEdit.Enabled = True
        btnKeluar.Enabled = True
        btnHapus.Enabled = True

    End Sub

    Private Sub btnKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeluar.Click
        Me.Close()
    End Sub

    Private Sub DGV_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DGV.CellMouseClick
        On Error Resume Next
        labelretur.Text = DGV.Rows(e.RowIndex).Cells(0).Value
        labelnomasuk.Text = DGV.Rows(e.RowIndex).Cells(1).Value
        Cdetail.Text = DGV.Rows(e.RowIndex).Cells(2).Value
        labelkode.Text = DGV.Rows(e.RowIndex).Cells(3).Value
        labelstokmasuk.Text = DGV.Rows(e.RowIndex).Cells(4).Value
        labeltanggal.Text = DGV.Rows(e.RowIndex).Cells(5).Value
        trusak.Text = DGV.Rows(e.RowIndex).Cells(6).Value
        tket.Text = DGV.Rows(e.RowIndex).Cells(7).Value


    End Sub

End Class