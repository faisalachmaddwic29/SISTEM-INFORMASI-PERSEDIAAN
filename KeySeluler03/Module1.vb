Imports System.Data.SqlClient
Module Module1
    Public CONN As SqlConnection
    Public CMD As SqlCommand
    Public DS As New DataSet
    Public DA As SqlDataAdapter
    Public RD As SqlDataReader
    Public LokasiData As String


    Public Sub koneksi()
        LokasiData = "Data Source=DESKTOP-JKJK7T7\SQLEXPRESS;Initial Catalog=DBPersediaan03;Persist Security Info=True;User ID=faisalachmaddwicahyono;Password=29maret97"
        CONN = New SqlConnection(LokasiData)
        If CONN.State = ConnectionState.Closed Then
            CONN.Open()
        End If
    End Sub
End Module
