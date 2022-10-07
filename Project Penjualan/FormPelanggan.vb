Public Class FormPelanggan
    Sub panggildata_pelanggan()
        koneksi()

        da = New MySql.Data.MySqlClient.MySqlDataAdapter("SELECT * FROM pelanggan", connct)
        dt = New DataTable
        data = da.Fill(dt)

        If data > 0 Then
            DGV_Pelanggan.DataSource = dt
            DGV_Pelanggan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
            DGV_Pelanggan.Columns(0).HeaderText = "Kode Pelanggan"
            DGV_Pelanggan.Columns(1).HeaderText = "Nama Pelanggan"
            DGV_Pelanggan.Columns(2).HeaderText = "Alamat"
            DGV_Pelanggan.Columns(3).HeaderText = "No. HP"
        Else
            DGV_Pelanggan.DataSource = Nothing
        End If
    End Sub

    Sub autokode_pelanggan()
        koneksi()

        cmd = New MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM pelanggan WHERE kode_pelanggan IN (SELECT max(kode_pelanggan) FROM pelanggan) ORDER BY kode_pelanggan desc", connct)

        dr = cmd.ExecuteReader
        dr.Read()

        If Not dr.HasRows Then
            str = "P" + "00001"
        Else
            lng = Microsoft.VisualBasic.Right(dr.GetString(0), 5) + 1
            str = "P" + Microsoft.VisualBasic.Right("00000" & lng, 5)
        End If
        TextBox_KdPelanggan.Text = str
    End Sub
    Private Sub FormPelanggan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        panggildata_pelanggan()
        autokode_pelanggan()

        TextBox_NmPelanggan.Select()
        TextBox_NoHP.MaxLength = 12
    End Sub

    Private Sub Button_Simpan_Click(sender As Object, e As EventArgs) Handles Button_Simpan.Click
        koneksi()

        cmd = New MySql.Data.MySqlClient.MySqlCommand("INSERT INTO pelanggan VALUES ('" & TextBox_KdPelanggan.Text & "',
                                                                                     '" & TextBox_NmPelanggan.Text & "',
                                                                                     '" & TextBox_Alamat.Text & "',
                                                                                     '" & TextBox_NoHP.Text & "')", connct)
        cmd.ExecuteNonQuery()
        panggildata_pelanggan()

        TextBox_KdPelanggan.Text = ""
        TextBox_NmPelanggan.Text = ""
        TextBox_Alamat.Text = ""
        TextBox_NoHP.Text = ""
    End Sub

    Private Sub Button_Edit_Click(sender As Object, e As EventArgs) Handles Button_Edit.Click
        koneksi()

        cmd = New MySql.Data.MySqlClient.MySqlCommand("UPDATE pelanggan SET kode_pelanggan = '" & TextBox_KdPelanggan.Text & "',
                                                                            nama_pelanggan = '" & TextBox_NmPelanggan.Text & "',
                                                                            alamat = '" & TextBox_Alamat.Text & "',
                                                                            no_hp = '" & TextBox_NoHP.Text & "'
                                                                      WHERE kode_pelanggan = '" & TextBox_KdPelanggan.Text & "'", connct)
        cmd.ExecuteNonQuery()
        panggildata_pelanggan()

        TextBox_KdPelanggan.Text = ""
        TextBox_NmPelanggan.Text = ""
        TextBox_Alamat.Text = ""
        TextBox_NoHP.Text = ""
    End Sub

    Private Sub Button_Hapus_Click(sender As Object, e As EventArgs) Handles Button_Hapus.Click
        koneksi()

        If MessageBox.Show("Yakin Hapus Data?", "Peringatan!", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            cmd = New MySql.Data.MySqlClient.MySqlCommand("DELETE FROM pelanggan WHERE kode_pelanggan = '" & TextBox_KdPelanggan.Text & "'", connct)
            cmd.ExecuteNonQuery()
            panggildata_pelanggan()
        End If

        TextBox_KdPelanggan.Text = ""
        TextBox_NmPelanggan.Text = ""
        TextBox_Alamat.Text = ""
        TextBox_NoHP.Text = ""
    End Sub

    Private Sub Button_Clear_Click(sender As Object, e As EventArgs) Handles Button_Clear.Click
        TextBox_KdPelanggan.Text = ""
        TextBox_NmPelanggan.Text = ""
        TextBox_Alamat.Text = ""
        TextBox_NoHP.Text = ""
    End Sub

    Private Sub DGV_Pelanggan_Click(sender As Object, e As EventArgs) Handles DGV_Pelanggan.Click
        i = DGV_Pelanggan.CurrentRow.Index
        With DGV_Pelanggan.Rows.Item(i)
            TextBox_KdPelanggan.Text = .Cells(0).Value
            TextBox_NmPelanggan.Text = .Cells(1).Value
            TextBox_Alamat.Text = .Cells(2).Value
            TextBox_NoHP.Text = .Cells(3).Value
        End With
    End Sub

    Private Sub TextBox_Cari_TextChanged(sender As Object, e As EventArgs) Handles TextBox_Cari.TextChanged
        koneksi()

        da = New MySql.Data.MySqlClient.MySqlDataAdapter("SELECT * FROM pelanggan WHERE kode_pelanggan LIKE '%" & TextBox_Cari.Text & "%' OR
                                                                                        nama_pelanggan LIKE '%" & TextBox_Cari.Text & "%' OR
                                                                                        alamat LIKE '%" & TextBox_Cari.Text & "%' OR
                                                                                        no_hp LIKE '%" & TextBox_Cari.Text & "%'", connct)
        dt = New DataTable
        data = da.Fill(dt)

        If data > 0 Then
            DGV_Pelanggan.DataSource = dt
            DGV_Pelanggan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
            DGV_Pelanggan.Columns(0).HeaderText = "Kode Pelanggan"
            DGV_Pelanggan.Columns(1).HeaderText = "Nama Pelanggan"
            DGV_Pelanggan.Columns(2).HeaderText = "Alamat"
            DGV_Pelanggan.Columns(3).HeaderText = "No. HP"
        Else
            DGV_Pelanggan.DataSource = Nothing
        End If
    End Sub
End Class