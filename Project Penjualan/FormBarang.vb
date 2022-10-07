Public Class FormBarang
    Sub panggildata_barang()
        koneksi()

        da = New MySql.Data.MySqlClient.MySqlDataAdapter("SELECT * FROM barang", connct)
        dt = New DataTable
        data = da.Fill(dt)

        If data > 0 Then
            DGV_Barang.DataSource = dt
            DGV_Barang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
            DGV_Barang.Columns(0).HeaderText = "Kode Barang"
            DGV_Barang.Columns(1).HeaderText = "Nama Barang"
            DGV_Barang.Columns(2).HeaderText = "Harga"
            DGV_Barang.Columns(3).HeaderText = "Jumlah"
            DGV_Barang.Columns(4).HeaderText = "Satuan"
        Else
            DGV_Barang.DataSource = Nothing
        End If
    End Sub

    Sub autokode_barang()
        koneksi()

        cmd = New MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM barang WHERE kode_barang IN (SELECT max(kode_barang) FROM barang) ORDER BY kode_barang desc", connct)

        dr = cmd.ExecuteReader
        dr.Read()

        If Not dr.HasRows Then
            str = "B" + "00001"
        Else
            lng = Microsoft.VisualBasic.Right(dr.GetString(0), 5) + 1
            str = "B" + Microsoft.VisualBasic.Right("00000" & lng, 5)
        End If
        TextBox_KdBarang.Text = str
    End Sub

    Private Sub FormBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        panggildata_barang()
        autokode_barang()

        TextBox_NmBarang.Select()
        Button_Input.Enabled = False
    End Sub

    Private Sub Button_Simpan_Click(sender As Object, e As EventArgs) Handles Button_Simpan.Click
        koneksi()

        cmd = New MySql.Data.MySqlClient.MySqlCommand("INSERT INTO barang VALUES ('" & TextBox_KdBarang.Text & "',
                                                                                  '" & TextBox_NmBarang.Text & "',
                                                                                  '" & TextBox_Harga.Text & "',
                                                                                  '" & TextBox_Jumlah.Text & "',
                                                                                  '" & TextBox_Satuan.Text & "')", connct)

        cmd.ExecuteNonQuery()
        panggildata_barang()

        TextBox_KdBarang.Text = ""
        TextBox_NmBarang.Text = ""
        TextBox_Harga.Text = ""
        TextBox_Jumlah.Text = ""
        TextBox_Satuan.Text = ""
    End Sub

    Private Sub Button_Edit_Click(sender As Object, e As EventArgs) Handles Button_Edit.Click
        koneksi()

        cmd = New MySql.Data.MySqlClient.MySqlCommand("UPDATE barang SET kode_barang = '" & TextBox_KdBarang.Text & "',
                                                                         nama_barang = '" & TextBox_NmBarang.Text & "',
                                                                         harga = '" & TextBox_Harga.Text & "',
                                                                         jumlah = '" & TextBox_Jumlah.Text & "',
                                                                         satuan = '" & TextBox_Satuan.Text & "'
                                                                   WHERE kode_barang = '" & TextBox_KdBarang.Text & "'", connct)

        cmd.ExecuteNonQuery()
        panggildata_barang()

        TextBox_KdBarang.Text = ""
        TextBox_NmBarang.Text = ""
        TextBox_Harga.Text = ""
        TextBox_Jumlah.Text = ""
        TextBox_Satuan.Text = ""
    End Sub

    Private Sub Button_Hapus_Click(sender As Object, e As EventArgs) Handles Button_Hapus.Click
        koneksi()

        If MessageBox.Show("Yakin Hapus Data?", "Peringatan!", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            cmd = New MySql.Data.MySqlClient.MySqlCommand("DELETE FROM barang WHERE kode_barang = '" & TextBox_KdBarang.Text & "'", connct)

            cmd.ExecuteNonQuery()
            panggildata_barang()
        End If

        TextBox_KdBarang.Text = ""
        TextBox_NmBarang.Text = ""
        TextBox_Harga.Text = ""
        TextBox_Jumlah.Text = ""
        TextBox_Satuan.Text = ""
    End Sub

    Private Sub Button_Clear_Click(sender As Object, e As EventArgs) Handles Button_Clear.Click
        TextBox_KdBarang.Text = ""
        TextBox_NmBarang.Text = ""
        TextBox_Harga.Text = ""
        TextBox_Jumlah.Text = ""
        TextBox_Satuan.Text = ""
    End Sub

    Private Sub DGV_Barang_Click(sender As Object, e As EventArgs) Handles DGV_Barang.Click
        i = DGV_Barang.CurrentRow.Index
        With DGV_Barang.Rows.Item(i)
            TextBox_KdBarang.Text = .Cells(0).Value
            TextBox_NmBarang.Text = .Cells(1).Value
            TextBox_Harga.Text = .Cells(2).Value
            TextBox_Jumlah.Text = .Cells(3).Value
            TextBox_Satuan.Text = .Cells(4).Value
        End With
    End Sub

    Private Sub TextBox_Cari_TextChanged(sender As Object, e As EventArgs) Handles TextBox_Cari.TextChanged
        koneksi()

        da = New MySql.Data.MySqlClient.MySqlDataAdapter("SELECT * FROM barang 
                                                          WHERE kode_barang LIKE '%" & TextBox_Cari.Text & "%' OR
                                                                nama_barang LIKE '%" & TextBox_Cari.Text & "%' OR
                                                                harga LIKE '%" & TextBox_Cari.Text & "%' OR
                                                                jumlah LIKE '%" & TextBox_Cari.Text & "%' OR
                                                                satuan LIKE '%" & TextBox_Cari.Text & "%'", connct)
        dt = New DataTable
        data = da.Fill(dt)

        If data > 0 Then
            DGV_Barang.DataSource = dt
            DGV_Barang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
            DGV_Barang.Columns(0).HeaderText = "Kode Barang"
            DGV_Barang.Columns(1).HeaderText = "Nama Barang"
            DGV_Barang.Columns(2).HeaderText = "Harga"
            DGV_Barang.Columns(3).HeaderText = "Jumlah"
            DGV_Barang.Columns(4).HeaderText = "Satuan"
        Else
            DGV_Barang.DataSource = Nothing
        End If
    End Sub

    Private Sub TextBox_Harga_Leave(sender As Object, e As EventArgs) Handles TextBox_Harga.Leave
        'Total = Val(TextBox_Harga.Text)
        'TextBox_Harga.Text = FormatCurrency(Total)
    End Sub

    Private Sub Button_Input_Click(sender As Object, e As EventArgs) Handles Button_Input.Click
        FormTransaksi.ComboBox_Brg.Text = TextBox_KdBarang.Text
        Me.Close()
    End Sub
End Class