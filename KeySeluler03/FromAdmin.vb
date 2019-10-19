Imports System.Data.SqlClient
Public Class FromAdmin

    Sub kosongkan()
        Tkode.Text = ""
        Tnama.Text = ""
        Tpass.Text = ""
        Combolevel.Text = ""
        txtPencarian.Text = ""
        Tkode.Focus()
    End Sub

    Sub nonaktif()
        Tkode.ReadOnly = True
        Tnama.ReadOnly = True
        Tpass.ReadOnly = True
        Combolevel.Enabled = False
    End Sub

    Sub aktif()
        Tkode.ReadOnly = False
        Tnama.ReadOnly = False
        Tpass.ReadOnly = False
        Combolevel.Enabled = True
    End Sub

    Sub tampilkan()
        Call koneksi()
        DA = New SqlDataAdapter("select * from Tbl_Admin", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "Tbl_Admin")
        DGV.DataSource = (DS.Tables("Tbl_Admin"))
        DGV.ReadOnly = True
        Call aturkolom()
        Call header()
    End Sub

    Sub header()
        DGV.Columns(0).HeaderText = "Kode Admin"
        DGV.Columns(1).HeaderText = "Nama Admin"
        DGV.Columns(2).HeaderText = "Password"
        DGV.Columns(3).HeaderText = "Level"
    End Sub

    Sub aturkolom()
        DGV.Columns(0).Width = 130
        DGV.Columns(1).Width = 130
        DGV.Columns(2).Width = 100
        DGV.Columns(3).Width = 120

    End Sub

    Sub Ketemu()
        Tkode.Text = RD.Item("Kode_Admin")
        Tnama.Text = RD.Item("Nama_Admin")
        Tpass.Text = RD.Item("Password_Admin")
        Combolevel.Text = RD.Item("Level_Admin")
    End Sub



    Private Sub tkode_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Tkode.KeyPress
        Tkode.MaxLength = 5
        If e.KeyChar = Chr(13) Then
            Call koneksi()
            CMD = New SqlCommand("select * from tbl_Admin where kode_Admin = '" & Tkode.Text & "' ", CONN)
            RD = CMD.ExecuteReader()
            RD.Read()
            If Not RD.HasRows Then
                MsgBox("Maaf Kode Admin tersebut sudah ada ", vbCritical)
            Else
                Call Ketemu()
            End If
        End If
    End Sub

    Private Sub tnama_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Tnama.KeyPress
        If e.KeyChar = Chr(13) Then Tpass.Focus()
    End Sub




    Private Sub btnInput_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInput.Click
        Call aktif()
        Call koneksi()
        BtnEdit.Enabled = False
        btnKeluar.Enabled = False
        btnHapus.Enabled = False
        CMD = New SqlCommand("Select * from Tbl_Admin Where Kode_Admin = '" & Tkode.Text & "'", CONN)
        RD = CMD.ExecuteReader
        RD.Read()
        Try
            If Tkode.Text = "" Or Tnama.Text = "" Or Tpass.Text = "" Or Combolevel.Text = "" Then

                btnInput.Text = "Simpan"

                Exit Sub
            Else
                Call koneksi()
                btnInput.Text = "Input"

                Dim SqlTambah As String = "Insert into Tbl_Admin Values ('" & Tkode.Text & "', '" & Tnama.Text & "', '" & Tpass.Text & "' , '" & Combolevel.Text & "')"
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

        If Tkode.Text = "" Or Tnama.Text = "" Or Tpass.Text = "" Or Combolevel.Text = "" Then
            BtnEdit.Text = "Update"
            Exit Sub
        Else
            Call koneksi()
            Dim sqledit As String = "update tbl_Admin set nama_Admin='" & Tnama.Text & "', Password_Admin='" & Tpass.Text & "', Level_Admin = '" & Combolevel.Text & "' where Kode_Admin = '" & Tkode.Text & "'"
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
                Dim hapus As String = "delete  from tbl_Admin where kode_Admin='" & Tkode.Text & "'"
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
        If ComboPencarian.Text = "Kode_Admin" Then
            Call koneksi()
            DA = New SqlDataAdapter("select * from tbl_Admin where Kode_Admin like '%" & txtPencarian.Text & "%'", CONN)
            DS = New DataSet
            DA.Fill(DS)
            DGV.DataSource = DS.Tables(0)
        ElseIf ComboPencarian.Text = "Nama_Bagian" Then
            Call koneksi()
            DA = New SqlDataAdapter("select * from tbl_Admin where Nama_Admin like '%" & txtPencarian.Text & "%'", CONN)
            DS = New DataSet
            DA.Fill(DS)
            DGV.DataSource = DS.Tables(0)
        Else
            MsgBox("Pilih Kategori Dulu!", MsgBoxStyle.Exclamation + vbOKOnly, "Perhatian")
            txtPencarian.Text = ""
            ComboPencarian.Focus()
        End If
    End Sub


    Private Sub FromAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen
        Call tampilkan()
        Call kosongkan()
        Call nonaktif()
        Labeltanggal.Text = DateString
        Labeljam.Text = TimeOfDay
        Tpass.MaxLength = 15
        btnInput.Text = "Input"
        BtnEdit.Text = "Edit"
        btnInput.Enabled = True
        BtnEdit.Enabled = True
        btnKeluar.Enabled = True
        btnHapus.Enabled = True
        Tkode.Enabled = True
    End Sub

    Private Sub DGV_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DGV.CellMouseClick
        On Error Resume Next
        Tkode.Text = DGV.Rows(e.RowIndex).Cells(0).Value
        Tnama.Text = DGV.Rows(e.RowIndex).Cells(1).Value
        Tpass.Text = DGV.Rows(e.RowIndex).Cells(2).Value
        Combolevel.Text = DGV.Rows(e.RowIndex).Cells(3).Value
    End Sub
End Class
