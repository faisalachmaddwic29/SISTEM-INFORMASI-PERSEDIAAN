Imports System.Data.SqlClient
Public Class FromLaporanMaster
    Private Sub btnadmin_Click(sender As Object, e As EventArgs) Handles btnadmin.Click
        FromLaporanAdmin.ShowDialog()
    End Sub

    Private Sub btnbarang_Click(sender As Object, e As EventArgs) Handles btnbarang.Click
        FromLaporanBarang.ShowDialog()
    End Sub

    Private Sub btnsupp_Click(sender As Object, e As EventArgs) Handles btnsupp.Click
        FromLaporanSupplier.ShowDialog()
    End Sub

    Private Sub btbag_Click(sender As Object, e As EventArgs) Handles btbag.Click
        FromLaporanBagian.ShowDialog()
    End Sub

    Private Sub btnRetur_Click(sender As Object, e As EventArgs) Handles btnRetur.Click
        FromLaporanRetur.ShowDialog()
    End Sub

End Class