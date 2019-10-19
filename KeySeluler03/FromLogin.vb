Imports System.Data.SqlClient
Public Class FromLogin

    Private Sub FromLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Tpass.PasswordChar = "*"
        Call KondisiAwal()
    End Sub

    Sub Terbuka()
        FromMenuUtama.DataToolStripMenuItem.Enabled = True
        FromMenuUtama.TransaksiToolStripMenuItem.Enabled = True
    End Sub

    Sub KondisiAwal()
        Tkode.Text = ""
        Tpass.Text = ""
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If Tkode.Text = "" Or Tpass.Text = "" Then
            MsgBox("Data Login Belum Lengkap")
            Exit Sub
        Else
            Call koneksi()
            CMD = New SqlCommand("Select * From Tbl_Admin where Nama_Admin = '" & Tkode.Text & "' And Password_Admin = '" & Tpass.Text & "'", CONN)
            RD = CMD.ExecuteReader
            RD.Read()
            If RD.HasRows Then
                Me.Visible = False
                FromMenuUtama.Show()
                FromMenuUtama.Panel11.Text = RD.GetString(0)
                FromMenuUtama.Panel12.Text = RD.GetString(1)
                FromMenuUtama.Panel13.Text = RD.GetString(3)
                If FromMenuUtama.Panel13.Text = "ADMIN" Then
                    Call Terbuka()
                ElseIf FromMenuUtama.Panel13.Text = "KARYAWAN" Then
                    FromMenuUtama.TransaksiToolStripMenuItem.Enabled = True
                    FromMenuUtama.DataToolStripMenuItem.Enabled = True
                    FromMenuUtama.DataBagianToolStripMenuItem.Enabled = False
                    FromMenuUtama.DataAdminToolStripMenuItem.Enabled = False
                    FromMenuUtama.DataSupplierToolStripMenuItem.Enabled = False
                    FromMenuUtama.LaporanDataAdminToolStripMenuItem.Enabled = False
                    FromMenuUtama.LaporanDataBagianToolStripMenuItem.Enabled = False
                    FromMenuUtama.LaporanDataSupplierToolStripMenuItem.Enabled = False
                    FromMenuUtama.btnAdmin.Enabled = False
                    FromMenuUtama.btnSupplier.Enabled = False
                    FromMenuUtama.btnBagian.Enabled = False
                    FromMenuUtama.btnMaster.Enabled = False

                End If
                MsgBox(" Selamat datang '" & Tkode.Text & "'")
            Else
                MsgBox("Nama User atau Password salah")
                Tkode.Focus()
                Call KondisiAwal()
            End If
        End If
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Me.Close()
    End Sub
    Private Sub Tkode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Tkode.KeyPress
        If e.KeyChar = Chr(13) Then Tpass.Focus()
    End Sub
    Private Sub Tpass_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Tpass.KeyPress
        If e.KeyChar = Chr(13) Then
            Call koneksi()
            CMD = New SqlCommand("Select * from Tbl_Admin where Password_Admin = '" & Tpass.Text & "' and nama_admin = '" & Tkode.Text & "'", CONN)
            RD = CMD.ExecuteReader
            RD.Read()
            If RD.HasRows Then
                Me.Visible = False
                FromMenuUtama.Show()
                FromMenuUtama.Panel11.Text = RD.GetString(0)
                FromMenuUtama.Panel12.Text = RD.GetString(1)
                FromMenuUtama.Panel13.Text = RD.GetString(3)
                If FromMenuUtama.Panel13.Text = "ADMIN" Then
                    Call Terbuka()
                ElseIf FromMenuUtama.Panel13.Text = "KARYAWAN" Then
                    FromMenuUtama.TransaksiToolStripMenuItem.Enabled = True
                    FromMenuUtama.DataToolStripMenuItem.Enabled = True
                    FromMenuUtama.DataBagianToolStripMenuItem.Enabled = False
                    FromMenuUtama.DataAdminToolStripMenuItem.Enabled = False
                    FromMenuUtama.DataSupplierToolStripMenuItem.Enabled = False
                    FromMenuUtama.LaporanDataAdminToolStripMenuItem.Enabled = False
                    FromMenuUtama.LaporanDataBagianToolStripMenuItem.Enabled = False
                    FromMenuUtama.LaporanDataSupplierToolStripMenuItem.Enabled = False
                    FromMenuUtama.btnAdmin.Enabled = False
                    FromMenuUtama.btnSupplier.Enabled = False
                    FromMenuUtama.btnBagian.Enabled = False
                    FromMenuUtama.btnMaster.Enabled = False

                End If
                MsgBox(" Selamat datang '" & Tkode.Text & "'")

            Else
                MsgBox("Nama User atau Password salah")
                Tkode.Focus()
                Call KondisiAwal()
            End If
        End If
    End Sub

End Class