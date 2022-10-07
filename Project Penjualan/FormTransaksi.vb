Public Class FormTransaksi
    Sub kolom_barang()
        DGV_Transaksi.Columns.Clear()
        DGV_Transaksi.Columns.Add("kode_barang", "Kode Barang")
        DGV_Transaksi.Columns.Add("nama_barang", "Nama Barang")
        DGV_Transaksi.Columns.Add("harga", "Harga")
        DGV_Transaksi.Columns.Add("item_terjual", "Jumlah")
        DGV_Transaksi.Columns.Add("total_jual", "SubTotal")
    End Sub

    Sub autokode_transaksi()
        koneksi()

        cmd = New MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM transaksi WHERE kode_transaksi IN (SELECT max(kode_transaksi) FROM transaksi) ORDER BY kode_transaksi desc", connct)

        dr = cmd.ExecuteReader
        dr.Read()

        If Not dr.HasRows Then
            str = "T" + "00001"
        Else
            lng = Microsoft.VisualBasic.Right(dr.GetString(0), 5) + 1
            str = "T" + Microsoft.VisualBasic.Right("00000" & lng, 5)
        End If
        TextBox_KdTrnsksi.Text = str
    End Sub

    Sub datacombobox_pelanggan()
        koneksi()
        cmd = New MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM pelanggan", connct)
        dr = cmd.ExecuteReader

        Do While dr.Read
            ComboBox_Plnggn.Items.Add(dr.Item(0))
        Loop

        ComboBox_Plnggn.Text = ""
    End Sub

    Sub datacombobox_barang()
        koneksi()
        cmd = New MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM barang", connct)
        dr = cmd.ExecuteReader

        Do While dr.Read
            ComboBox_Brg.Items.Add(dr.Item(0))
        Loop

        ComboBox_Brg.Text = ""
    End Sub

    Sub rumus_total()
        Total = 0
        For i = 0 To DGV_Transaksi.Rows.Count - 1
            Total = Total + DGV_Transaksi.Rows(i).Cells(4).Value
            Label_Total.Text = Total
        Next
    End Sub

    Sub rumus_jmlitem()
        jumlah = 0
        For i = 0 To DGV_Transaksi.Rows.Count - 1
            jumlah = jumlah + DGV_Transaksi.Rows(i).Cells(3).Value
            TextBox_JmlItem.Text = jumlah
        Next
    End Sub

    Sub rumus_kembali()
        Kembali = Val(TextBox_Dibayar.Text) - Val(Label_Total.Text)
        TextBox_Kembali.Text = Kembali
    End Sub

    Private Sub FormTransaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        kolom_barang()
        autokode_transaksi()
        datacombobox_pelanggan()
        datacombobox_barang()

        TextBox_User.Text = Form1.STLabel_Kode0.Text
        TextBox_KdTrnsksi.Select()
    End Sub

    Private Sub ComboBox_Plnggn_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_Plnggn.SelectedIndexChanged
        koneksi()
        cmd = New MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM pelanggan WHERE kode_pelanggan = '" & ComboBox_Plnggn.Text & "'", connct)
        dr = cmd.ExecuteReader
        dr.Read()

        If dr.HasRows Then
            TextBox_Nama.Text = dr!nama_pelanggan
            TextBox_Alamat.Text = dr!alamat
            TextBox_NoHP.Text = dr!no_hp
        End If
    End Sub

    Private Sub ComboBox_Brg_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_Brg.SelectedIndexChanged
        koneksi()
        cmd = New MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM barang WHERE kode_barang = '" & ComboBox_Brg.Text & "'", connct)
        dr = cmd.ExecuteReader
        dr.Read()

        If dr.HasRows Then
            TextBox_NmBrg.Text = dr!nama_barang
            TextBox_Harga.Text = dr!harga
        End If

        ' gimana caraya supaya comboboxnya bisa dicari dgn ketikan dri database
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        TextBox_Jam.Text = TimeOfDay
    End Sub

    Private Sub TextBox_Dibayar_TextChanged(sender As Object, e As EventArgs) Handles TextBox_Dibayar.TextChanged
        rumus_kembali()
    End Sub

    Private Sub Button_Pelanggan_Click(sender As Object, e As EventArgs) Handles Button_Pelanggan.Click
        FormPelanggan.Show()
    End Sub

    Private Sub Button_Input_Click(sender As Object, e As EventArgs) Handles Button_Input.Click
        DGV_Transaksi.Rows.Add(New String() {ComboBox_Brg.Text, TextBox_NmBrg.Text, TextBox_Harga.Text, TextBox_JmlJual.Text, Val(TextBox_JmlJual.Text) * Val(TextBox_Harga.Text)})
        rumus_total()
        rumus_jmlitem()

        ComboBox_Brg.Text = ""
        TextBox_NmBrg.Text = ""
        TextBox_Harga.Text = ""
        TextBox_JmlJual.Text = ""
    End Sub

    Private Sub Button_Simpan_Click(sender As Object, e As EventArgs) Handles Button_Simpan.Click
        koneksi()

        If TextBox_Dibayar.Text < Label_Total.Text Then
            MessageBox.Show("Pembayaran Kurang!", "Peringatan!", MessageBoxButtons.OK)
        Else
            cmd = New MySql.Data.MySqlClient.MySqlCommand("INSERT INTO transaksi VALUES('" & TextBox_KdTrnsksi.Text & "',
                                                                                    '" & DateTimePicker1.Value.ToString("yyyy-MM-dd") & "',
                                                                                    '" & TextBox_Jam.Text & "',
                                                                                    '" & ComboBox_Plnggn.Text & "',
                                                                                    '" & TextBox_User.Text & "',
                                                                                    '" & TextBox_JmlItem.Text & "',
                                                                                    '" & Label_Total.Text & "',
                                                                                    '" & TextBox_Dibayar.Text & "',
                                                                                    '" & TextBox_Kembali.Text & "')", connct)
            cmd.ExecuteNonQuery()

            For baris As Integer = 0 To DGV_Transaksi.Rows.Count - 2
                cmd = New MySql.Data.MySqlClient.MySqlCommand("INSERT INTO detail_transaksi (transaksi_id, barang_kode, harga_jual, jumlah_jual, sub_total)
                                                                                        VALUES('" & TextBox_KdTrnsksi.Text & "',
                                                                                               '" & DGV_Transaksi.Rows(baris).Cells(0).Value & "',
                                                                                               '" & DGV_Transaksi.Rows(baris).Cells(2).Value & "',
                                                                                               '" & DGV_Transaksi.Rows(baris).Cells(3).Value & "',
                                                                                               '" & DGV_Transaksi.Rows(baris).Cells(4).Value & "')", connct)
                dr.Close()
                cmd.ExecuteNonQuery()

                cmd = New MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM barang WHERE kode_barang = '" & DGV_Transaksi.Rows(baris).Cells(0).Value & "'", connct)
                dr.Close()
                dr = cmd.ExecuteReader
                dr.Read()

                cmd = New MySql.Data.MySqlClient.MySqlCommand("UPDATE barang SET jumlah = '" & dr.Item("jumlah") - DGV_Transaksi.Rows(baris).Cells(3).Value & "'
                                                           WHERE kode_barang = '" & DGV_Transaksi.Rows(baris).Cells(0).Value & "'", connct)
                dr.Close()
                cmd.ExecuteNonQuery()
            Next

            MsgBox("Berhasil Disimpan")

            DGV_Transaksi.Rows.Clear()
            TextBox_KdTrnsksi.Text = ""
            ComboBox_Plnggn.Text = ""
            TextBox_Nama.Text = ""
            TextBox_Alamat.Text = ""
            TextBox_NoHP.Text = ""
            TextBox_JmlItem.Text = ""
            TextBox_Dibayar.Text = ""
            TextBox_Kembali.Text = ""
            Label_Total.Text = ""

            autokode_transaksi()
        End If
    End Sub

    Private Sub Button_Hapus_Click(sender As Object, e As EventArgs) Handles Button_Hapus.Click
        If MessageBox.Show("Yakin Hapus Data?", "Peringatan!", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            i = DGV_Transaksi.CurrentCell.RowIndex
            DGV_Transaksi.Rows.RemoveAt(i)
            rumus_total()
            rumus_jmlitem()
        End If
    End Sub

    Private Sub Button_Clear_Click(sender As Object, e As EventArgs) Handles Button_Clear.Click
        DGV_Transaksi.Rows.Clear()
        ComboBox_Plnggn.Text = ""
        TextBox_Nama.Text = ""
        TextBox_Alamat.Text = ""
        TextBox_NoHP.Text = ""
        ComboBox_Brg.Text = ""
        TextBox_NmBrg.Text = ""
        TextBox_Harga.Text = ""
        TextBox_JmlJual.Text = ""
        TextBox_JmlItem.Text = ""
        TextBox_Dibayar.Text = ""
        TextBox_Kembali.Text = ""
        Label_Total.Text = ""

        autokode_transaksi()
    End Sub

    Private Sub btnCariBrg_Click(sender As Object, e As EventArgs) Handles btnCariBrg.Click
        FormBarang.Show()
        FormBarang.TextBox_KdBarang.Enabled = False
        FormBarang.TextBox_NmBarang.Enabled = False
        FormBarang.TextBox_Jumlah.Enabled = False
        FormBarang.TextBox_Satuan.Enabled = False
        FormBarang.TextBox_Harga.Enabled = False

        FormBarang.Button_Simpan.Enabled = False
        FormBarang.Button_Edit.Enabled = False
        FormBarang.Button_Hapus.Enabled = False
        FormBarang.Button_Clear.Enabled = False
        FormBarang.Button_Input.Enabled = True

        ComboBox_Brg.Show()
    End Sub
End Class