Public Class FormDetailTransaksi
    Sub panggildata_detaitransaksi()
        koneksi()

        da = New MySql.Data.MySqlClient.MySqlDataAdapter("SELECT detail_transaksi.id_detail, detail_transaksi.transaksi_id, transaksi.tgl_transaksi, transaksi.jam_transaksi, 
                                                          transaksi.pelanggan_kode, transaksi.user_kode, detail_transaksi.barang_kode, barang.nama_barang,
                                                          detail_transaksi.harga_jual, detail_transaksi.jumlah_jual, detail_transaksi.sub_total, transaksi.dibayar, transaksi.kembali 
                                                          FROM detail_transaksi 
                                                          INNER JOIN transaksi
                                                          ON transaksi.kode_transaksi = detail_transaksi.transaksi_id
                                                          INNER JOIN barang
                                                          ON barang.kode_barang = detail_transaksi.barang_kode", connct)
        dt = New DataTable
        data = da.Fill(dt)

        If data > 0 Then
            DGV_DetailTransaksi.DataSource = dt
            DGV_DetailTransaksi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
            DGV_DetailTransaksi.Columns(0).HeaderText = "Id"
            DGV_DetailTransaksi.Columns(1).HeaderText = "Kode transaksi"
            DGV_DetailTransaksi.Columns(2).HeaderText = "Tgl Transaksi"
            DGV_DetailTransaksi.Columns(3).HeaderText = "Jam Transaksi"
            DGV_DetailTransaksi.Columns(4).HeaderText = "Kode Pelanggan"
            DGV_DetailTransaksi.Columns(5).HeaderText = "Kode User"
            DGV_DetailTransaksi.Columns(6).HeaderText = "Kode Barang"
            DGV_DetailTransaksi.Columns(7).HeaderText = "Nama Barang"
            DGV_DetailTransaksi.Columns(8).HeaderText = "Harga"
            DGV_DetailTransaksi.Columns(9).HeaderText = "Jumlah Item"
            DGV_DetailTransaksi.Columns(10).HeaderText = "Total"
            DGV_DetailTransaksi.Columns(11).HeaderText = "Dibayar"
            DGV_DetailTransaksi.Columns(12).HeaderText = "Kembali"
        End If
    End Sub

    'Sub data_cb_transaksi()
    '    koneksi()
    '    cmd = New MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM transaksi", connct)
    '    dr = cmd.ExecuteReader

    '    Do While dr.Read
    '        ComboBox_Trnsksi.Items.Add(dr.Item(0))
    '    Loop

    '    ComboBox_Trnsksi.Text = ""
    'End Sub

    'Sub data_cb_barang()
    '    koneksi()
    '    cmd = New MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM barang", connct)
    '    dr = cmd.ExecuteReader

    '    Do While dr.Read
    '        ComboBox_Barang.Items.Add(dr.Item(0))
    '    Loop

    '    ComboBox_Barang.Text = ""
    'End Sub

    Private Sub FormDetailTransaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        panggildata_detaitransaksi()
        'data_cb_transaksi()
        'data_cb_barang()
    End Sub

    Private Sub Button_Clear_Click(sender As Object, e As EventArgs) Handles Button_Clear.Click
        TextBox_Id.Text = ""
        TextBox_KdTransaksi.Text = ""
        TextBox_KdBarang.Text = ""
        TextBox_Harga.Text = ""
        TextBox_JmlBrg.Text = ""
        TextBox_Total.Text = ""
    End Sub

    Private Sub TextBox_Cari_TextChanged(sender As Object, e As EventArgs) Handles TextBox_Cari.TextChanged
        koneksi()

        da = New MySql.Data.MySqlClient.MySqlDataAdapter("SELECT detail_transaksi.id_detail, detail_transaksi.transaksi_id, transaksi.tgl_transaksi, transaksi.jam_transaksi, 
                                                          transaksi.pelanggan_kode, transaksi.user_kode, detail_transaksi.barang_kode, barang.nama_barang,
                                                          detail_transaksi.harga_jual, detail_transaksi.jumlah_jual, detail_transaksi.sub_total, transaksi.dibayar, transaksi.kembali 
                                                          FROM detail_transaksi 
                                                          INNER JOIN transaksi
                                                          ON transaksi.kode_transaksi = detail_transaksi.transaksi_id
                                                          INNER JOIN barang
                                                          ON barang.kode_barang = detail_transaksi.barang_kode
                                                          WHERE detail_transaksi.id_detail LIKE '%" & TextBox_Cari.Text & "%' OR
                                                          detail_transaksi.transaksi_id LIKE '%" & TextBox_Cari.Text & "%' OR
                                                          transaksi.tgl_transaksi LIKE '%" & TextBox_Cari.Text & "%' OR
                                                          transaksi.jam_transaksi LIKE '%" & TextBox_Cari.Text & "%' OR
                                                          transaksi.pelanggan_kode LIKE '%" & TextBox_Cari.Text & "%' OR
                                                          transaksi.user_kode LIKE '%" & TextBox_Cari.Text & "%' OR
                                                          detail_transaksi.barang_kode LIKE '%" & TextBox_Cari.Text & "%' OR
                                                          barang.nama_barang LIKE '%" & TextBox_Cari.Text & "%' OR
                                                          detail_transaksi.harga_jual LIKE '%" & TextBox_Cari.Text & "%' OR
                                                          detail_transaksi.jumlah_jual LIKE '%" & TextBox_Cari.Text & "%' OR
                                                          detail_transaksi.sub_total LIKE '%" & TextBox_Cari.Text & "%' OR
                                                          transaksi.dibayar LIKE '%" & TextBox_Cari.Text & "%' OR
                                                          transaksi.kembali LIKE '%" & TextBox_Cari.Text & "%'", connct)
        dt = New DataTable
        data = da.Fill(dt)

        If data > 0 Then
            DGV_DetailTransaksi.DataSource = dt
            DGV_DetailTransaksi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
            DGV_DetailTransaksi.Columns(0).HeaderText = "Id"
            DGV_DetailTransaksi.Columns(1).HeaderText = "Kode transaksi"
            DGV_DetailTransaksi.Columns(2).HeaderText = "Tgl Transaksi"
            DGV_DetailTransaksi.Columns(3).HeaderText = "Jam Transaksi"
            DGV_DetailTransaksi.Columns(4).HeaderText = "Kode Pelanggan"
            DGV_DetailTransaksi.Columns(5).HeaderText = "Kode User"
            DGV_DetailTransaksi.Columns(6).HeaderText = "Kode Barang"
            DGV_DetailTransaksi.Columns(7).HeaderText = "Nama Barang"
            DGV_DetailTransaksi.Columns(8).HeaderText = "Harga"
            DGV_DetailTransaksi.Columns(9).HeaderText = "Jumlah Item"
            DGV_DetailTransaksi.Columns(10).HeaderText = "Total"
            DGV_DetailTransaksi.Columns(11).HeaderText = "Dibayar"
            DGV_DetailTransaksi.Columns(12).HeaderText = "Kembali"
        End If
    End Sub

    Private Sub DGV_DetailTransaksi_Click(sender As Object, e As EventArgs) Handles DGV_DetailTransaksi.Click
        i = DGV_DetailTransaksi.CurrentRow.Index
        With DGV_DetailTransaksi.Rows.Item(i)
            TextBox_Id.Text = .Cells(0).Value
            TextBox_KdTransaksi.Text = .Cells(1).Value
            TextBox_KdBarang.Text = .Cells(6).Value
            TextBox_Harga.Text = .Cells(8).Value
            TextBox_JmlBrg.Text = .Cells(9).Value
            TextBox_Total.Text = .Cells(10).Value
        End With
    End Sub

    Private Sub TextBox_JmlBrg_TextChanged(sender As Object, e As EventArgs) Handles TextBox_JmlBrg.TextChanged
        Total = Val(TextBox_Harga.Text) * Val(TextBox_JmlBrg.Text)
        TextBox_Total.Text = Total
    End Sub

    Private Sub ComboBox_Barang_SelectedIndexChanged(sender As Object, e As EventArgs)
        koneksi()
        cmd = New MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM barang WHERE kode_barang = '" & TextBox_KdBarang.Text & "'", connct)
        dr = cmd.ExecuteReader
        dr.Read()

        If dr.HasRows Then
            TextBox_Harga.Text = dr!harga
        End If
    End Sub
End Class
' di tabel detail transaksi perlu button simpan, edit, hapus, clear?
' kalau perlu fungsi dibawah belum
' masih belum benar dibagian simpan dan edit
' kalau dihapus yg ditabel transaksi belum ikut kerubah tp di tabel detail transaksi sudah kehapus
' belum berhasil nyimpan format Rp ke database