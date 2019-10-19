Imports System.Data.SqlClient
Public Class FromTransaksiBarangMasuk

    Sub kosongkan()
        Tstok.Text = ""
        Tkode.Text = ""
        Tsupp.Text = ""
        Cdetail.Text = ""
        LabelMasuk.Text = ""
        labeluser.Text = ""
        DTP1.Text = ""
        Cdetail.Focus()
    End Sub
    Sub kosongkantambah()
        Cdetail.Text = ""
        Tstok.Text = ""
        Tkode.Text = ""
        Tsupp.Text = ""
        Cdetail.Focus()
    End Sub

    Sub nonaktif()
        Tstok.ReadOnly = True
        Tkode.ReadOnly = True
        Tsupp.ReadOnly = True
        Cdetail.Enabled = False
        DTP1.Enabled = False
    End Sub

    Sub aktif()
        Tstok.ReadOnly = False
        Tkode.ReadOnly = False
        Tsupp.ReadOnly = False
        Cdetail.Enabled = True
        DTP1.Enabled = True
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


    Private Sub Otomatis()
        Call koneksi()
        CMD = New SqlCommand("Select * from Tbl_BarangMasuk where No_Masuk in (select max(No_Masuk) from Tbl_BarangMasuk) order by No_Masuk desc", CONN)
        Dim urutan As String
        Dim hitung As Long
        RD = CMD.ExecuteReader
        RD.Read()
        If Not RD.HasRows Then
            urutan = "BM" + Format(Now, "yyMMdd") + "01"
        Else
            If Microsoft.VisualBasic.Mid(RD.GetString(0), 3, 6) <> Format(Now, "yyMMdd") Then
                urutan = "BM" + Format(Now, "yyMMdd") + "01"
            Else
                hitung = Microsoft.VisualBasic.Right(RD.GetString(0), 2) + 1
                urutan = "BM" + Format(Now, "yyMMdd") + Microsoft.VisualBasic.Right("00" & hitung, 2)
            End If
        End If
        LabelMasuk.Text = urutan
    End Sub

    Private Sub FromTransaksiBarangMasuk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call nonaktif()
        Call nonaktifbutton()
        Call kosongkan()
        Label5.Text = DateString
        Labeljam.Text = TimeOfDay
    End Sub

    Private Sub Tkode_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Tkode.KeyPress
        ListBarang.Show()
        If e.KeyChar = Chr(13) Then
            If Tkode.Text = "" Then
                ListBarang.Show()
            End If
        End If
    End Sub

    Private Sub Tsupp_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Tsupp.KeyPress
        ListSupplierMasuk.Show()
        If e.KeyChar = Chr(13) Then
            If Tsupp.Text = "" Then
                ListSupplierMasuk.Show()
            End If
        End If
    End Sub

    Private Sub Tstok_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Tstok.KeyPress
        If e.KeyChar = Chr(13) Then Tkode.Focus()
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled() = True
    End Sub

    Sub nonaktifbutton()
        btntambah.Enabled = False
        btnhapus.Enabled = True
        btnBatal.Enabled = False
        BtnEdit.Enabled = True
        btnbaru.Enabled = True
        btnKeluar.Enabled = True
        btnstokawal.Enabled = False
        BtnEdit.Text = "Edit"
    End Sub

    Private Sub btnbaru_Click(sender As Object, e As EventArgs) Handles btnbaru.Click
        Call aktif()
        Call datafaktur()

        If LabelMasuk.Text = "" Then
            Call Otomatis()
            labeluser.Text = FromMenuUtama.Panel11.Text
            Call koneksi()
            Dim SqlTambah As String = "Insert into Tbl_BarangMasuk Values ('" & LabelMasuk.Text & "')"
            CMD = New SqlCommand(SqlTambah, CONN)
            CMD.ExecuteNonQuery()

            BtnEdit.Enabled = False
            btnbaru.Enabled = False
            btntambah.Enabled = True
            btnBatal.Enabled = True
            btnhapus.Enabled = False
            btnKeluar.Enabled = False
        Else
            btntambah.Focus()

        End If
    End Sub

    Private Sub btntambah_Click(sender As Object, e As EventArgs) Handles btntambah.Click

        If Cdetail.Text = "" Or Tstok.Text = "" Or Tkode.Text = "" Or Tsupp.Text = "" Then
            MsgBox("Data Belom Lengkap")
            Exit Sub
        End If
        Try
            DA = New SqlDataAdapter("Select * from tbl_Barangmasuk", CONN)
            DS = New DataSet
            DA.Fill(DS)

            Call koneksi()
            Dim Sqldetail As String = "Insert into Tbl_DetailMasuk Values ('" & Cdetail.Text & "','" & LabelMasuk.Text & "','" & Tkode.Text & "', '" & DTP1.Text & "','" & labeluser.Text & "', '" & Tsupp.Text & "', '" & Tstok.Text & "' )"
            CMD = New SqlCommand(Sqldetail, CONN)
            CMD.ExecuteNonQuery()
            MsgBox("Data berhasil di Input", MsgBoxStyle.Information, "Information")

            Call koneksi()
            CMD = New SqlCommand("select * from Tbl_Barang where Kode_Barang='" & Tkode.Text & "'", CONN)
            RD = CMD.ExecuteReader
            RD.Read()
            If RD.HasRows Then
                Call koneksi()
                Dim TambahStok As String = "update Tbl_barang set Stok_barang = Stok_barang +'" & Tstok.Text & "' where Kode_barang='" & Tkode.Text & "'"
                CMD = New SqlCommand(TambahStok, CONN)
                CMD.ExecuteNonQuery()
                Call kosongkantambah()
            End If
        Catch ex As Exception
            MsgBox("No Faktur Masuk '" & Cdetail.Text & "' Sudah ada")

        End Try
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click

        If LabelMasuk.Text = "" Then
            Call kosongkan()
            Call nonaktif()
            Call nonaktifbutton()
            BtnEdit.Text = "Edit"
            btnKeluar.Enabled = True
        Else
            If Cdetail.Text <> "" Then
                Call kosongkan()
                Call nonaktif()
                Call nonaktifbutton()
                BtnEdit.Text = "Edit"
                btnKeluar.Enabled = True
            Else
                Call koneksi()
                Dim hapustransaksi As String = "Delete from Tbl_BarangMasuk where No_Masuk = '" & LabelMasuk.Text & "'"
                CMD = New SqlCommand(hapustransaksi, CONN)
                CMD.ExecuteNonQuery()
                Call kosongkan()
                Call nonaktif()
                Call nonaktifbutton()
                BtnEdit.Text = "Edit"
                btnKeluar.Enabled = True
            End If
        End If
    End Sub

    Private Sub btnhapus_Click(sender As Object, e As EventArgs) Handles btnhapus.Click
        Call datafaktur()
        Cdetail.Enabled = True
        btnBatal.Enabled = True
        BtnEdit.Enabled = False
        btnstokawal.Enabled = False
        btnbaru.Enabled = False
        If Cdetail.Text = "" Then
            MsgBox("Pilih No Faktur Dulu")
            Exit Sub
        Else
            Call koneksi()
            If MessageBox.Show("Yakin ingin menghapus ? ", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                Call koneksi()
                Dim hapus As String = "delete from Tbl_DetailMasuk where id_detail ='" & Cdetail.Text & "'"
                CMD = New SqlCommand(hapus, CONN)
                CMD.ExecuteNonQuery()
                Call kosongkan()

                Call koneksi()
                Dim hapustransaksi As String = "Delete from Tbl_BarangMasuk where No_Masuk = '" & LabelMasuk.Text & "'"
                CMD = New SqlCommand(hapustransaksi, CONN)
                CMD.ExecuteNonQuery()
                Call kosongkan()
                Call nonaktifbutton()

            End If
        End If
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        Call datafaktur()
        Call aktif()
        btnBatal.Enabled = True
        btnstokawal.Enabled = True
        btnbaru.Enabled = False
        btnhapus.Enabled = False

        If Cdetail.Text = "" Or Tstok.Text = "" Or Tkode.Text = "" Or Tsupp.Text = "" Then
            MsgBox("Pilih No Faktur Dulu")
            BtnEdit.Text = "Update"
            Exit Sub
        Else
            Call koneksi()
            Dim sqledit As String = "update tbl_DetailMasuk set Kode_barang='" & Tkode.Text & "',Stok_masuk='" & Tstok.Text & "', Kode_Supplier = '" & Tsupp.Text & "' where id_detail = '" & Cdetail.Text & "'"
            CMD = New SqlCommand(sqledit, CONN)
            CMD.ExecuteNonQuery()

            Call koneksi()
            CMD = New SqlCommand("select * from Tbl_Barang where Kode_Barang='" & Tkode.Text & "'", CONN)
            RD = CMD.ExecuteReader
            RD.Read()
            If RD.HasRows Then
                Call koneksi()
                Dim TambahStok As String = "update Tbl_barang set Stok_barang = Stok_barang +'" & Tstok.Text & "' where Kode_barang='" & Tkode.Text & "'"
                CMD = New SqlCommand(TambahStok, CONN)
                CMD.ExecuteNonQuery()
                Call kosongkantambah()
            End If
            If MessageBox.Show("Anda yakin ingin Mengganti?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                Call kosongkan()
                Call nonaktifbutton()
                Call nonaktif()
            End If
        End If
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Me.Close()
    End Sub

    Private Sub Cdetail_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cdetail.SelectedIndexChanged
        Call koneksi()
        CMD = New SqlCommand("Select * from Tbl_DetailMasuk where Id_detail = '" & Cdetail.Text & "'", CONN)
        RD = CMD.ExecuteReader
        RD.Read()
        If RD.HasRows Then
            LabelMasuk.Text = RD.Item("No_Masuk")
            DTP1.Text = RD.Item("tgl_masuk")
            Tstok.Text = RD.Item("Stok_masuk")
            Tkode.Text = RD.Item("Kode_Barang")
            Tsupp.Text = RD.Item("Kode_Supplier")
            labeluser.Text = RD.Item("Kode_Admin")

        End If
    End Sub

    Private Sub btnStokawal_Click(sender As Object, e As EventArgs) Handles btnStokawal.Click
        Call koneksi()
        CMD = New SqlCommand("select * from Tbl_Barang where Kode_Barang='" & Tkode.Text & "'", CONN)
        RD = CMD.ExecuteReader
        RD.Read()
        If RD.HasRows Then
            Call koneksi()
            Dim TambahStok As String = "update Tbl_barang set Stok_barang = Stok_barang -'" & Tstok.Text & "' where Kode_barang='" & Tkode.Text & "'"
            CMD = New SqlCommand(TambahStok, CONN)
            CMD.ExecuteNonQuery()
            Call kosongkantambah()
        End If
    End Sub

End Class
