Imports System.Data.SqlClient
Public Class FromGantiPassword

    Private Sub FromGantiPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Tlama.PasswordChar = "*"
        tbaru.PasswordChar = "*"
        Tulang.PasswordChar = "*"
        tuser.Text = FromMenuUtama.Panel12.Text
        Tlama.Enabled = True
        tbaru.Enabled = False
        Tulang.Enabled = False

    End Sub

    Private Sub Tlama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Tlama.KeyPress
        If e.KeyChar = Chr(13) Then
            Call koneksi()
            CMD = New SqlCommand("Select * from Tbl_Admin where Password_Admin = '" & Tlama.Text & "' and nama_admin = '" & FromMenuUtama.Panel12.Text & "'", CONN)
            RD = CMD.ExecuteReader
            RD.Read()
            If RD.HasRows Then
                tbaru.Enabled = True
                tbaru.Focus()
            Else
                MsgBox("Password Lama Salah")
                Tlama.Focus()
            End If
        End If
    End Sub

    Private Sub tbaru_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbaru.KeyPress
        If e.KeyChar = Chr(13) Then
            If tbaru.Text = "" Then
                MsgBox("Password Wajib diisi")
                tbaru.Focus()
            Else
                Tulang.Enabled = True
                Tulang.Focus()
            End If
        End If
    End Sub

    Private Sub Tulang_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Tulang.KeyPress
        If e.KeyChar = Chr(13) Then
            If Tulang.Text <> tbaru.Text Then
                MsgBox("Password Ulang salah")
                Tulang.Focus()
            Else
                'ganti password petugas
                Call koneksi()
                If MessageBox.Show("Yakin Akan ganti Password ?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                    Dim ganti As String = "Update tbl_admin set password_admin = '" & Tulang.Text & "' where Kode_admin = '" & FromMenuUtama.Panel11.Text & "'"
                    CMD = New SqlCommand(ganti, CONN)
                    CMD.ExecuteNonQuery()
                    Tlama.Clear()
                    tbaru.Clear()
                    Tulang.Clear()
                    Me.Close()
                    MsgBox("Password Berhasil diganti")
                Else
                    Tlama.Clear()
                    tbaru.Clear()
                    Tulang.Clear()
                    Me.Close()
                End If
            End If
        End If
    End Sub

    Private Sub btnsimpan_Click(sender As Object, e As EventArgs) Handles btnsimpan.Click
        If Tlama.Text = "" Or tbaru.Text = "" Or Tulang.Text = "" Then
            MsgBox("Password masih kosong", vbExclamation + vbOKOnly, "Pesan")
            Exit Sub
        End If
        If Tulang.Text <> tbaru.Text Then
            MsgBox("Password Ulang salah")
            Tulang.Focus()
        Else
            'ganti password'
            Call koneksi()
            If MessageBox.Show("Yakin Akan ganti Password ?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                Dim ganti As String = "Update tbl_admin set password_admin = '" & tbaru.Text & "' where Kode_admin = '" & FromMenuUtama.Panel11.Text & "'"
                CMD = New SqlCommand(ganti, CONN)
                CMD.ExecuteNonQuery()
                Tlama.Clear()
                tbaru.Clear()
                Tulang.Clear()
                Me.Close()
            Else
                Tlama.Clear()
                tbaru.Clear()
                Tulang.Clear()
                Me.Close()
            End If
        End If
        MsgBox("Password Berhasil diganti")
    End Sub

End Class