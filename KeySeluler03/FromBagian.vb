Imports System.Data.SqlClient
Public Class FromBagian

    Sub kosongkan()
        Tkode.Text = ""
        Tnama.Text = ""
        Ttelepon.Text = ""
        txtPencarian.Text = ""
        Tkode.Focus()
    End Sub

    Sub nonaktif()
        Tkode.ReadOnly = True
        Tnama.ReadOnly = True
        Ttelepon.ReadOnly = True
    End Sub

    Sub aktif()
        Tkode.ReadOnly = False
        Tnama.ReadOnly = False
        Ttelepon.ReadOnly = False
    End Sub

    Sub tampilkan()
        Call koneksi()
        DA = New SqlDataAdapter("select * from Tbl_Bagian", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "Tbl_Bagian")
        DGV.DataSource = (DS.Tables("Tbl_Bagian"))
        DGV.ReadOnly = True
        Call aturkolom()
        Call header()
    End Sub

    Sub header()
        DGV.Columns(0).HeaderText = "Kode Bagian"
        DGV.Columns(1).HeaderText = "Nama Bagian"
        DGV.Columns(2).HeaderText = "Telepon"
    End Sub

    Sub aturkolom()
        DGV.Columns(0).Width = 130
        DGV.Columns(1).Width = 130
        DGV.Columns(2).Width = 80
    End Sub

    Sub Ketemu()
        Tkode.Text = RD.Item("Kode_Bagian")
        Tnama.Text = RD.Item("Nama_Bagian")
        Ttelepon.Text = RD.Item("Telepon_HP")
    End Sub


    Private Sub tkode_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Tkode.KeyPress
        Tkode.MaxLength = 5
        If e.KeyChar = Chr(13) Then
            Call koneksi()
            CMD = New SqlCommand("select * from tbl_Bagian where kode_Bagian = '" & Tkode.Text & "' ", CONN)
            RD = CMD.ExecuteReader()
            RD.Read()
            If Not RD.HasRows Then
                MsgBox("Maaf Kode Bagian tersebut sudah ada ", vbCritical)
            Else
                Call Ketemu()
            End If
        End If
    End Sub

    Private Sub tnama_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Tnama.KeyPress
        If e.KeyChar = Chr(13) Then Ttelepon.Focus()
    End Sub

    Private Sub ttelepon_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Ttelepon.KeyPress
        If e.KeyChar = Chr(13) Then btnInput.Focus()
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled() = True
    End Sub


    Private Sub btnInput_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInput.Click
        Call aktif()
        Call koneksi()
        BtnEdit.Enabled = False
        btnKeluar.Enabled = False
        btnHapus.Enabled = False
        CMD = New SqlCommand("Select * from Tbl_Bagian Where Kode_Bagian = '" & Tkode.Text & "'", CONN)
        RD = CMD.ExecuteReader
        RD.Read()
        Try
            If Tkode.Text = "" Or Tnama.Text = "" Or Ttelepon.Text = "" Then

                btnInput.Text = "Simpan"

                Exit Sub
            Else
                Call koneksi()
                btnInput.Text = "Input"

                Dim SqlTambah As String = "Insert into Tbl_Bagian Values ('" & Tkode.Text & "', '" & Tnama.Text & "', '" & Ttelepon.Text & "' )"
                CMD = New SqlCommand(SqlTambah, CONN)
                CMD.ExecuteNonQuery()

                MsgBox("Data berhasil di Input", MsgBoxStyle.Information, "Information")
                Call kosongkan()
                Call tampilkan()
            End If
            Call nonaktif()
        Catch ex As Exception
            MsgBox("Data  '" & Tkode.Text & "' Sudah ada")
            Call Ketemu()
        End Try

        Tkode.Focus()
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
        Tkode.Enabled = False

        If Tkode.Text = "" Or Tnama.Text = "" Or Ttelepon.Text = "" Then
            BtnEdit.Text = "Update"
            Exit Sub
        Else
            Call koneksi()
            Dim sqledit As String = "update tbl_Bagian set nama_Bagian='" & Tnama.Text & "', Telepon_HP='" & Ttelepon.Text & "' where Kode_Bagian = '" & Tkode.Text & "'"
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
        Tkode.Enabled = True
    End Sub

    Private Sub btnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHapus.Click
        If Tkode.Text = "" Then
            MsgBox("Isi kode barang terlebih dahulu")
            Tkode.Focus()
            Exit Sub
        Else
            Call koneksi()

            If MessageBox.Show("Yakin ingin menghapus ? ", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                Dim hapus As String = "delete  from tbl_Bagian where kode_Bagian='" & Tkode.Text & "'"
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
        Tkode.Enabled = True
    End Sub

    Private Sub btnKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeluar.Click
        Me.Close()
    End Sub

    Private Sub txtPencarian_TextChanged(sender As Object, e As EventArgs) Handles txtPencarian.TextChanged
        If ComboPencarian.Text = "Kode_Bagian" Then
            Call koneksi()
            DA = New SqlDataAdapter("select * from tbl_Bagian where Kode_Bagian like '%" & txtPencarian.Text & "%'", CONN)
            DS = New DataSet
            DA.Fill(DS)
            DGV.DataSource = DS.Tables(0)
        ElseIf ComboPencarian.Text = "Nama_Bagian" Then
            Call koneksi()
            DA = New SqlDataAdapter("select * from tbl_Bagian where  Nama_Bagian like '%" & txtPencarian.Text & "%'", CONN)
            DS = New DataSet
            DA.Fill(DS)
            DGV.DataSource = DS.Tables(0)
        Else
            MsgBox("Pilih Kategori Dulu!", MsgBoxStyle.Exclamation + vbOKOnly, "Perhatian")
            txtPencarian.Text = ""
            ComboPencarian.Focus()
        End If
    End Sub

    Private Sub FromBagian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        Tkode.Enabled = True
        ComboPencarian.Text = ""
    End Sub

    Private Sub DGV_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DGV.CellMouseClick
        On Error Resume Next
        Tkode.Text = DGV.Rows(e.RowIndex).Cells(0).Value
        Tnama.Text = DGV.Rows(e.RowIndex).Cells(1).Value
        Ttelepon.Text = DGV.Rows(e.RowIndex).Cells(2).Value
    End Sub

End Class
