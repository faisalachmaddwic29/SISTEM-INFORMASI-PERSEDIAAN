Imports System.Data.SqlClient

Public Class FromBarang
    Sub kosongkan()
        LabelBarang.Text = ""
        Tnama.Text = ""
        TStok.Text = ""
        CTempat.Text = ""
        ComboJenis.Text = ""
        ComboSatuan.Text = ""
        txtPencarian.Text = ""
        Tnama.Focus()
    End Sub

    Sub nonaktif()
        Tnama.ReadOnly = True
        TStok.ReadOnly = True
        CTempat.Enabled = False
        ComboSatuan.Enabled = False
        ComboJenis.Enabled = False
    End Sub

    Sub aktif()
        Tnama.ReadOnly = False
        TStok.ReadOnly = False
        CTempat.Enabled = True
        ComboSatuan.Enabled = True
        ComboJenis.Enabled = True
    End Sub

    Sub tampilkan()
        Call koneksi()
        DA = New SqlDataAdapter("select * from Tbl_Barang", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "Tbl_Barang")
        DGV.DataSource = (DS.Tables("Tbl_Barang"))
        DGV.ReadOnly = True
        Call headertext()
        Call aturkolom()
    End Sub

    Sub headertext()
        DGV.Columns(0).HeaderText = "Kode Barang"
        DGV.Columns(1).HeaderText = "Nama Barang"
        DGV.Columns(2).HeaderText = "Stok"
        DGV.Columns(3).HeaderText = "Satuan"
        DGV.Columns(4).HeaderText = "Jenis"
        DGV.Columns(5).HeaderText = "Tempat"


    End Sub

    Sub aturkolom()
        DGV.Columns(0).Width = 130
        DGV.Columns(1).Width = 200
        DGV.Columns(2).Width = 50
        DGV.Columns(3).Width = 80
        DGV.Columns(4).Width = 80
        DGV.Columns(5).Width = 90

    End Sub

    Sub Ketemu()
        LabelBarang.Text = RD.Item("Kode_barang")
        Tnama.Text = RD.Item("Nama_barang")
        TStok.Text = RD.Item("Stok_Barang")
        CTempat.Text = RD.Item("Tempat_barang")
        ComboJenis.Text = RD.Item("Jenis_Barang")
        ComboSatuan.Text = RD.Item("Satuan_Barang")
    End Sub


    Sub otomatis()
        Call koneksi()
        CMD = New SqlCommand("Select Kode_barang from tbl_barang where kode_Barang in (Select max(Kode_Barang) from tbl_barang)", CONN)
        Dim Urutan As String
        Dim Hitung As Long
        RD = CMD.ExecuteReader
        RD.Read()
        If Not RD.HasRows Then
            Urutan = "KB" + "001"
        Else
            Hitung = Microsoft.VisualBasic.Right(RD.GetString(0), 3) + 1
            Urutan = "KB" + Microsoft.VisualBasic.Right("000" & Hitung, 3)
        End If
        LabelBarang.Text = Urutan
    End Sub


    Private Sub tnama_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Tnama.KeyPress
        If e.KeyChar = Chr(13) Then TStok.Focus()
    End Sub

    Private Sub Tstok_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TStok.KeyPress
        If e.KeyChar = Chr(13) Then ComboSatuan.Focus()
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled() = True
    End Sub
    Private Sub ComboSatuan_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboSatuan.KeyPress
        If e.KeyChar = Chr(13) Then ComboJenis.Focus()
    End Sub
    Private Sub ComboJenis_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboJenis.KeyPress
        If e.KeyChar = Chr(13) Then CTempat.Focus()
    End Sub


    Private Sub Ctempat_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CTempat.KeyPress
        If e.KeyChar = Chr(13) Then btnInput.Focus()
    End Sub



    Private Sub btnInput_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInput.Click
        Call aktif()
        Call koneksi()
        BtnEdit.Enabled = False
        btnKeluar.Enabled = False
        btnHapus.Enabled = False
        CMD = New SqlCommand("Select * from Tbl_Barang Where Kode_Barang = '" & LabelBarang.Text & "'", CONN)
        RD = CMD.ExecuteReader
        RD.Read()


        Try
            If Tnama.Text = "" Or TStok.Text = "" Or CTempat.Text = "" Or ComboJenis.Text = "" Or ComboSatuan.Text = "" Then

                btnInput.Text = "Simpan"
                Call otomatis()
                Exit Sub

            Else
                Call koneksi()
                btnInput.Text = "Input"

                Dim SqlTambah As String = "Insert into Tbl_Barang Values ('" & LabelBarang.Text & "', '" & Tnama.Text & "' , '" & TStok.Text & "', '" & ComboSatuan.Text & "', '" & ComboJenis.Text & "', '" & CTempat.Text & "' )"
                CMD = New SqlCommand(SqlTambah, CONN)
                CMD.ExecuteNonQuery()

                MsgBox("Data berhasil di Input", MsgBoxStyle.Information, "Information")
                Call kosongkan()
                Call tampilkan()

            End If
            Call nonaktif()
        Catch ex As Exception
            MsgBox("Data  '" & LabelBarang.Text & "' Sudah ada")
            Call Ketemu()
        End Try


        Tnama.Focus()
        btnInput.Text = "Input"
        BtnEdit.Enabled = True
        btnKeluar.Enabled = True
        btnHapus.Enabled = True
        Call kosongkan()

    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEdit.Click
        Call aktif()
        btnInput.Enabled = False
        btnKeluar.Enabled = False
        btnHapus.Enabled = False

        If LabelBarang.Text = "" Or Tnama.Text = "" Or TStok.Text = "" Or ComboSatuan.Text = "" Or ComboJenis.Text = "" Or CTempat.Text = "" Then
            BtnEdit.Text = "Update"
            Exit Sub
        Else
            Call koneksi()
            Dim sqledit As String = "update tbl_Barang set nama_Barang='" & Tnama.Text & "',Stok_Barang='" & TStok.Text & "', Satuan_Barang = '" & ComboSatuan.Text & "', Jenis_Barang = '" & ComboJenis.Text & "',Tempat_Barang='" & CTempat.Text & "' where Kode_Barang = '" & LabelBarang.Text & "'"
            CMD = New SqlCommand(sqledit, CONN)
            CMD.ExecuteNonQuery()
            If MessageBox.Show("Anda yakin ingin Mengganti?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                Call kosongkan()
                Call tampilkan()
            End If
        End If
        Call nonaktif()
        BtnEdit.Text = "Edit"
        btnInput.Enabled = True
        btnKeluar.Enabled = True
        btnHapus.Enabled = True


    End Sub

    Private Sub btnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHapus.Click
        If LabelBarang.Text = "" Then
            MsgBox("Isi kode barang terlebih dahulu")
            LabelBarang.Focus()
            Exit Sub
        Else

            If MessageBox.Show("Yakin ingin menghapus ? ", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                Call koneksi()
                Dim hapus As String = "delete  from Tbl_Barang where Kode_Barang='" & LabelBarang.Text & "'"
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
        Call nonaktif()
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


    Private Sub txtPencarian_TextChanged(sender As Object, e As EventArgs) Handles txtPencarian.TextChanged
        If ComboPencarian.Text = "Kode_Barang" Then
            Call koneksi()
            DA = New SqlDataAdapter("select * from tbl_Barang where Kode_Barang like '%" & txtPencarian.Text & "%'", CONN)
            DS = New DataSet
            DA.Fill(DS)
            DGV.DataSource = DS.Tables(0)
        ElseIf ComboPencarian.Text = "Nama_Barang" Then
            Call koneksi()
            DA = New SqlDataAdapter("select * from tbl_Barang where Nama_Barang like '%" & txtPencarian.Text & "%'", CONN)
            DS = New DataSet
            DA.Fill(DS)
            DGV.DataSource = DS.Tables(0)
        Else
            MsgBox("Pilih Kategori Dulu!", MsgBoxStyle.Exclamation + vbOKOnly, "Perhatian")
            txtPencarian.Text = ""
            ComboPencarian.Focus()
        End If
    End Sub

    Private Sub FromBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen
        Call tampilkan()
        Call kosongkan()
        Call nonaktif()
        Labeltanggal.Text = DateString
        Labeljam.Text = TimeOfDay
        btnInput.Text = "Input"
        BtnEdit.Text = "Edit"
        btnInput.Enabled = True
        BtnEdit.Enabled = True
        btnKeluar.Enabled = True
        btnHapus.Enabled = True
    End Sub

    Private Sub DGV_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DGV.CellMouseClick
        On Error Resume Next
        LabelBarang.Text = DGV.Rows(e.RowIndex).Cells(0).Value
        Tnama.Text = DGV.Rows(e.RowIndex).Cells(1).Value
        TStok.Text = DGV.Rows(e.RowIndex).Cells(2).Value
        ComboSatuan.Text = DGV.Rows(e.RowIndex).Cells(3).Value
        ComboJenis.Text = DGV.Rows(e.RowIndex).Cells(4).Value
        CTempat.Text = DGV.Rows(e.RowIndex).Cells(5).Value


    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class