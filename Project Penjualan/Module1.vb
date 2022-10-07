Imports MySql.Data.MySqlClient
Module Module1
    Public connct As MySqlConnection
    Public cmd As MySqlCommand
    Public dr As MySqlDataReader
    Public da As MySqlDataAdapter
    Public dt As DataTable
    Public str As String
    Public data As Integer
    Public i As Integer
    Public Total As Double
    Public Kembali As Double
    Public lng As Long
    Public jumlah As Double

    Sub koneksi()

        str = "server=localhost;userid=root;password=;database=db_penjualan;convert zero datetime=true"
        connct = New MySqlConnection(str)

        If connct.State = ConnectionState.Closed Then
            connct.Open()
        End If
    End Sub
End Module

' tabel transaksi munculkan transaksi saat itu saja
' tabel detail transaksi buat laporan dimunculkan semua dan bisa cetak nota
