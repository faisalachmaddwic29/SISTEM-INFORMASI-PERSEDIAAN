Imports System.Data.SqlClient
Public Class FromSupplier

    Sub kosongkan()
        LabelSupplier.Text = ""
        Tnama.Text = ""
        Talamat.Text = ""
        Ttelepon.Text = ""
        Temail.Text = ""
        txtPencarian.Text = ""
        Tnama.Focus()
    End Sub

    Sub nonaktif()
        Tnama.ReadOnly = True
        Talamat.ReadOnly = True
        Ttelepon.ReadOnly = True
        Temail.ReadOnly = True
    End Sub

    Sub aktif()
        Tnama.ReadOnly = False
        Talamat.ReadOnly = False
        Ttelepon.ReadOnly = False
        Temail.ReadOnly = False
    End Sub

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
        DGV.Columns(0).HeaderText = "Kode Supplier"
        DGV.Columns(1).HeaderText = "Nama Supplier"
        DGV.Columns(2).HeaderText = "Alamat"
        DGV.Columns(3).HeaderText = "Telepon"
        DGV.Columns(4).HeaderText = "Email"
    End Sub

    Sub aturkolom()
        DGV.Columns(0).Width = 130
        DGV.Columns(1).Width = 140
        DGV.Columns(2).Width = 120
        DGV.Columns(3).Width = 130
        DGV.Columns(3).Width = 130
    End Sub

    Sub Ketemu()
        LabelSupplier.Text = RD.Item("Kode_Supplier")
        Tnama.Text = RD.Item("Nama_Supplier")
        Talamat.Text = RD.Item("Alamat")
        Ttelepon.Text = RD.Item("Telepon_HP")
        Temail.Text = RD.Item("Email")
    End Sub


    Sub otomatis()
        Call koneksi()
        CMD = New SqlCommand("Select Kode_Supplier from tbl_Supplier where kode_Supplier in (Select max(Kode_Supplier) from tbl_Supplier)", CONN)
        Dim Urutan As String
        Dim Hitung As Long
        RD = CMD.ExecuteReader
        RD.Read()
        If Not RD.HasRows Then
            Urutan = "KS" + "001"
        Else
            Hitung = Microsoft.VisualBasic.Right(RD.GetString(0), 3) + 1
            Urutan = "KS" + Microsoft.VisualBasic.Right("000" & Hitung, 3)
        End If
        LabelSupplier.Text = Urutan
    End Sub

    Private Sub tnama_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Tnama.KeyPress
        If e.KeyChar = Chr(13) Then Talamat.Focus()
    End Sub

    Private Sub tAlamat_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Talamat.KeyPress
        If e.KeyChar = Chr(13) Then Ttelepon.Focus()
    End Sub

    Private Sub ttelepon_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Ttelepon.KeyPress
        If e.KeyChar = Chr(13) Then Temail.Focus()
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled() = True
    End Sub

    Private Sub temail_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Temail.KeyPress
        If e.KeyChar = Chr(13) Then btnInput.Focus()
    End Sub



    Private Sub btnInput_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInput.Click
        Call aktif()
        Call koneksi()
        BtnEdit.Enabled = False
        btnKeluar.Enabled = False
        btnHapus.Enabled = False
        CMD = New SqlCommand("Select * from Tbl_Supplier Where Kode_Supplier = '" & LabelSupplier.Text & "'", CONN)
        RD = CMD.ExecuteReader
        RD.Read()
        Try
            If Tnama.Text = "" Or Talamat.Text = "" Or Ttelepon.Text = "" Or Temail.Text = "" Then

                btnInput.Text = "Simpan"
                Call otomatis()
                Exit Sub
            Else
                Call koneksi()
                btnInput.Text = "Input"

                Dim SqlTambah As String = "Insert into Tbl_Supplier Values ('" & LabelSupplier.Text & "', '" & Tnama.Text & "', '" & Talamat.Text & "' , '" & Ttelepon.Text & "', '" & Temail.Text & "' )"
                CMD = New SqlCommand(SqlTambah, CONN)
                CMD.ExecuteNonQuery()

                MsgBox("Data berhasil di Input", MsgBoxStyle.Information, "Information")
                Call kosongkan()
                Call tampilkan()
            End If
            Call nonaktif()
        Catch ex As Exception
            MsgBox("Data  '" & LabelSupplier.Text & "' Sudah ada")
            Call Ketemu()
        End Try

        Tnama.Focus()
        btnInput.Text = "Input"
        BtnEdit.Enabled = True
        btnKeluar.Enabled = True
        btnHapus.Enabled = True

    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEdit.Click
        Call aktif()
        btnInput.Enabled = False
        btnKeluar.Enabled = False
        btnHapus.Enabled = False

        If LabelSupplier.Text = "" Or Tnama.Text = "" Or Talamat.Text = "" Or Ttelepon.Text = "" Or Temail.Text = "" Then
            BtnEdit.Text = "Update"
            Exit Sub
        Else
            Call koneksi()
            Dim sqledit As String = "update tbl_Supplier set nama_Supplier='" & Tnama.Text & "',Alamat ='" & Talamat.Text & "',Telepon_HP='" & Ttelepon.Text & "', Email =  '" & Temail.Text & "' where Kode_Supplier = '" & LabelSupplier.Text & "'"
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
        If LabelSupplier.Text = "" Then
            MsgBox("Isi kode barang terlebih dahulu")
            LabelSupplier.Focus()
            Exit Sub
        Else
            Call koneksi()

            If MessageBox.Show("Yakin ingin menghapus ? ", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                Dim hapus As String = "delete  from tbl_Supplier where kode_Supplier='" & LabelSupplier.Text & "'"
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
        If ComboPencarian.Text = "Kode_Supplier" Then
            Call koneksi()
            DA = New SqlDataAdapter("select * from tbl_Supplier where Kode_Supplier like '%" & txtPencarian.Text & "%'", CONN)
            DS = New DataSet
            DA.Fill(DS)
            DGV.DataSource = DS.Tables(0)
        ElseIf ComboPencarian.Text = "Nama_Supplier" Then
            Call koneksi()
            DA = New SqlDataAdapter("select * from tbl_Supplier where Nama_Supplier like '%" & txtPencarian.Text & "%'", CONN)
            DS = New DataSet
            DA.Fill(DS)
            DGV.DataSource = DS.Tables(0)
        Else
            MsgBox("Pilih Kategori Dulu!", MsgBoxStyle.Exclamation + vbOKOnly, "Perhatian")
            txtPencarian.Text = ""
            ComboPencarian.Focus()
        End If
    End Sub


    Private Sub FromSupplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen
        Call tampilkan()
        Call kosongkan()
        Call nonaktif()
        Labeltanggal.Text = DateString
        Labeljam.Text = TimeOfDay
        Ttelepon.MaxLength = 15
        btnInput.Text = "Input"
        BtnEdit.Text = "Edit"
        btnInput.Enabled = True
        BtnEdit.Enabled = True
        btnKeluar.Enabled = True
        btnHapus.Enabled = True
        ComboPencarian.Text = ""


    End Sub

    Private Sub DGV_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DGV.CellMouseClick
        On Error Resume Next
        LabelSupplier.Text = DGV.Rows(e.RowIndex).Cells(0).Value
        Tnama.Text = DGV.Rows(e.RowIndex).Cells(1).Value
        Talamat.Text = DGV.Rows(e.RowIndex).Cells(2).Value
        Ttelepon.Text = DGV.Rows(e.RowIndex).Cells(3).Value
        Temail.Text = DGV.Rows(e.RowIndex).Cells(4).Value

    End Sub
End Class
