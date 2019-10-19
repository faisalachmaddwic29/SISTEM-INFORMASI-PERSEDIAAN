Imports System.Data.SqlClient
Public Class FromTransaksiBarangKeluar

    Sub kosongkan()
        LabelKeluar.Text = ""
        DTP1.Text = ""
        labeluser.Text = ""
        CdetailK.Text = ""
        Tstok.Text = ""
        Tkode.Text = ""
        Tbagian.Text = ""
        CdetailK.Focus()
    End Sub

    Sub kosongkanKeluar()
        Tstok.Text = ""
        Tkode.Text = ""
        Tbagian.Text = ""
        CdetailK.Text = ""
        CdetailK.Focus()
    End Sub

    Sub nonaktif()
        CdetailK.Enabled = False
        Tstok.ReadOnly = True
        Tkode.ReadOnly = True
        Tbagian.ReadOnly = True
        DTP1.Enabled = False
    End Sub

    Sub aktif()
        CdetailK.Enabled = True
        Tstok.ReadOnly = False
        Tkode.ReadOnly = False
        Tbagian.ReadOnly = False
        DTP1.Enabled = True
    End Sub


    Sub datafaktur()
        Call koneksi()
        CMD = New SqlCommand("Select * from tbl_DetailKeluar", CONN)
        RD = CMD.ExecuteReader
        CdetailK.Items.Clear()
        Do While RD.Read
            CdetailK.Items.Add(RD.Item("Id_detailK"))
        Loop
    End Sub


    Private Sub Otomatis()
        Call koneksi()
        CMD = New SqlCommand("Select * from Tbl_BarangKeluar where No_Keluar in (select max(No_Keluar) from Tbl_BarangKeluar) order by No_Keluar desc", CONN)
        Dim urutan As String
        Dim hitung As Long
        RD = CMD.ExecuteReader
        RD.Read()
        If Not RD.HasRows Then
            urutan = "BK" + Format(Now, "yyMMdd") + "01"
        Else
            If Microsoft.VisualBasic.Mid(RD.GetString(0), 3, 6) <> Format(Now, "yyMMdd") Then
                urutan = "BK" + Format(Now, "yyMMdd") + "01"
            Else
                hitung = Microsoft.VisualBasic.Right(RD.GetString(0), 2) + 1
                urutan = "BK" + Format(Now, "yyMMdd") + Microsoft.VisualBasic.Right("00" & hitung, 2)
            End If
        End If
        LabelKeluar.Text = urutan
    End Sub


    Private Sub FromTransaksiBarangMasuk_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Call nonaktif()
        Call nonaktifbutton()
        Call kosongkan()
        Label5.Text = DateString
        Labeljam.Text = TimeOfDay
        CdetailK.Focus()

    End Sub

    Private Sub Tkode_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Tkode.KeyPress
        ListBarangKeluar.Show()
        If e.KeyChar = Chr(13) Then
            If Tkode.Text = "" Then
                ListBarangKeluar.Show()
            End If
        End If
    End Sub

    Private Sub Tbagian_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Tbagian.KeyPress
        ListBagianKeluar.Show()
        If e.KeyChar = Chr(13) Then
            If Tbagian.Text = "" Then
                ListBagianKeluar.Show()
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
        btnStokawal.Enabled = False
        BtnEdit.Enabled = True
        btnbaru.Enabled = True
        BtnEdit.Text = "Edit"

    End Sub

    Private Sub btnbaru_Click(sender As Object, e As EventArgs) Handles btnbaru.Click
        Call aktif()
        btnKeluar.Enabled = False
        If LabelKeluar.Text = "" Then
            Call Otomatis()
            labeluser.Text = FromMenuUtama.Panel11.Text
            Call koneksi()
            Dim SqlTambah As String = "Insert into Tbl_BarangKeluar Values ('" & LabelKeluar.Text & "')"
            CMD = New SqlCommand(SqlTambah, CONN)
            CMD.ExecuteNonQuery()

            btnbaru.Enabled = False
            btntambah.Enabled = True
            btnBatal.Enabled = True
            btnhapus.Enabled = False
            BtnEdit.Enabled = False
        Else
            btntambah.Focus()
        End If
    End Sub

    Private Sub btntambah_Click(sender As Object, e As EventArgs) Handles btntambah.Click

        If CdetailK.Text = "" Or Tstok.Text = "" Or Tkode.Text = "" Or Tbagian.Text = "" Then
            MsgBox("Data Belom Lengkap")
            Exit Sub
        End If
        Try
            DA = New SqlDataAdapter("Select * from tbl_BarangKeluar", CONN)
            DS = New DataSet
            DA.Fill(DS)

            Call koneksi()
            Dim SqlKeluar As String = "Insert into Tbl_DetailKeluar Values ('" & CdetailK.Text & "','" & LabelKeluar.Text & "', '" & Tkode.Text & "', '" & Tstok.Text & "' , '" & DTP1.Text & "', '" & Tbagian.Text & "', '" & labeluser.Text & "' )"
            CMD = New SqlCommand(SqlKeluar, CONN)
            CMD.ExecuteNonQuery()
            MsgBox("Data berhasil di Input", MsgBoxStyle.Information, "Information")

            Call koneksi()
            CMD = New SqlCommand("select * from Tbl_Barang where Kode_Barang='" & Tkode.Text & "'", CONN)
            RD = CMD.ExecuteReader
            RD.Read()
            If RD.HasRows Then
                Call koneksi()
                Dim TambahStok As String = "update Tbl_barang set Stok_barang = Stok_barang -'" & Tstok.Text & "' where Kode_barang='" & Tkode.Text & "'"
                CMD = New SqlCommand(TambahStok, CONN)
                CMD.ExecuteNonQuery()
                Call kosongkanKeluar()
            End If
        Catch ex As Exception
            MsgBox("No Faktur Masuk '" & CdetailK.Text & "' Sudah ada")

        End Try

    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        If LabelKeluar.Text = "" Then
            Call kosongkan()
            Call nonaktif()
            Call nonaktifbutton()
            BtnEdit.Text = "Edit"
            btnKeluar.Enabled = True
        Else
            If CdetailK.Text <> "" Or Tstok.Text <> "" Then
                Call kosongkan()
                Call nonaktif()
                Call nonaktifbutton()
                BtnEdit.Text = "Edit"
                btnKeluar.Enabled = True
            Else
                Call koneksi()
                Dim hapustransaksi As String = "Delete from Tbl_BarangKeluar where No_keluar = '" & LabelKeluar.Text & "'"
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
        CdetailK.Enabled = True
        btnBatal.Enabled = True
        BtnEdit.Enabled = False
        btnStokawal.Enabled = False
        btnbaru.Enabled = False
        If CdetailK.Text = "" Then
            MsgBox("Pilih No Faktur Dulu")
            Exit Sub
        Else
            Call koneksi()
            If MessageBox.Show("Yakin ingin menghapus ? ", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                Call koneksi()
                Dim hapus As String = "delete from Tbl_DetailKeluar where id_detailK='" & CdetailK.Text & "'"
                CMD = New SqlCommand(hapus, CONN)
                CMD.ExecuteNonQuery()
                Call kosongkan()

                Call koneksi()
                Dim hapustransaksi As String = "Delete from Tbl_BarangKeluar where No_keluar = '" & LabelKeluar.Text & "'"
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
        btnStokawal.Enabled = True
        btnbaru.Enabled = False
        btnhapus.Enabled = False

        If CdetailK.Text = "" Or Tstok.Text = "" Or Tkode.Text = "" Or Tbagian.Text = "" Then
            MsgBox("Pilih No Faktur Dulu")
            BtnEdit.Text = "Update"
            Exit Sub
        Else
            Call koneksi()
            Dim sqledit As String = "update tbl_DetailKeluar set Kode_barang='" & Tkode.Text & "',Total_minta='" & Tstok.Text & "', Kode_bagian = '" & Tbagian.Text & "' where id_detailk = '" & CdetailK.Text & "'"
            CMD = New SqlCommand(sqledit, CONN)
            CMD.ExecuteNonQuery()

            Call koneksi()
            CMD = New SqlCommand("select * from Tbl_Barang where Kode_Barang='" & Tkode.Text & "'", CONN)
            RD = CMD.ExecuteReader
            RD.Read()
            If RD.HasRows Then
                Call koneksi()
                Dim TambahStok As String = "update Tbl_barang set Stok_barang = Stok_barang -'" & Tstok.Text & "' where Kode_barang='" & Tkode.Text & "'"
                CMD = New SqlCommand(TambahStok, CONN)
                CMD.ExecuteNonQuery()
                Call kosongkanKeluar()
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

    Private Sub TdetailK_KeyPress(sender As Object, e As KeyPressEventArgs)
        If e.KeyChar = Chr(13) Then
            Call koneksi()
            CMD = New SqlCommand("Select * from Tbl_DetailKeluar where id_detail = '" & CdetailK.Text & "' ", CONN)
            RD = CMD.ExecuteReader
            RD.Read()
            If RD.HasRows Then
                MsgBox("Maaf, No Faktur Sudah ada")
            End If

        End If
    End Sub

    Private Sub CdetailK_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CdetailK.SelectedIndexChanged
        Call koneksi()
        CMD = New SqlCommand("Select * from Tbl_DetailKeluar where Id_detailK = '" & CdetailK.Text & "'", CONN)
        RD = CMD.ExecuteReader
        RD.Read()
        If RD.HasRows Then
            LabelKeluar.Text = RD.Item("No_keluar")
            DTP1.Text = RD.Item("tgl_keluar")
            Tstok.Text = RD.Item("Total_minta")
            Tkode.Text = RD.Item("Kode_Barang")
            Tbagian.Text = RD.Item("Kode_bagian")
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
            Dim TambahStok As String = "update Tbl_barang set Stok_barang = Stok_barang +'" & Tstok.Text & "' where Kode_barang='" & Tkode.Text & "'"
            CMD = New SqlCommand(TambahStok, CONN)
            CMD.ExecuteNonQuery()
            Call kosongkanKeluar()
        End If
    End Sub

End Class