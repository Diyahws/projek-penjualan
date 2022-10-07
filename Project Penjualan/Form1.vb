Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()

        TextBox_Uname.MaxLength = 6
        TextBox_Pass.MaxLength = 6

        Panel_Welcome.Visible = False
        MenuStrip1.Visible = False

        STLabel_Tanggal0.Text = Today
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        STLabel_Jam0.Text = TimeOfDay
    End Sub

    Private Sub Button_Masuk_Click(sender As Object, e As EventArgs) Handles Button_Masuk.Click
        cmd = New MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM user WHERE
                                                        nama = '" & TextBox_Uname.Text & "' AND
                                                        password = '" & TextBox_Pass.Text & "' AND
                                                        level = '" & ComboBox_Lvl.Text & "'", connct)

        dr = cmd.ExecuteReader
        dr.Read()

        If dr.HasRows Then
            If dr("level").ToString = "operator" Then
                Panel_Welcome.Visible = True
                MenuStrip1.Visible = True

                UserToolStripMenuItem.Enabled = False
                BarangToolStripMenuItem.Enabled = False
                PelangganToolStripMenuItem.Enabled = True
                TransaksiToolStripMenuItem.Enabled = True
                DetailTransaksiToolStripMenuItem.Enabled = True

                STLabel_Kode0.Text = dr!kodeadmin
                STLabel_Nama0.Text = dr!nama
                STLabel_Level0.Text = dr!level
            ElseIf dr("level").ToString = "admin" Then
                Panel_Welcome.Visible = True
                MenuStrip1.Visible = True

                UserToolStripMenuItem.Enabled = True
                BarangToolStripMenuItem.Enabled = True
                PelangganToolStripMenuItem.Enabled = True
                TransaksiToolStripMenuItem.Enabled = False
                DetailTransaksiToolStripMenuItem.Enabled = False

                STLabel_Kode0.Text = dr!kodeadmin
                STLabel_Nama0.Text = dr!nama
                STLabel_Level0.Text = dr!level
            End If
        ElseIf Not dr.HasRows Then
            MessageBox.Show("Periksa Kembali Username dan Password Anda", "Peringatan!", MessageBoxButtons.OK)
            TextBox_Uname.Text = ""
            TextBox_Pass.Text = ""
            ComboBox_Lvl.Text = ""
        End If
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub UserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UserToolStripMenuItem.Click
        FormUser.Show()
    End Sub

    Private Sub BarangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BarangToolStripMenuItem.Click
        FormBarang.Show()
    End Sub

    Private Sub PelangganToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PelangganToolStripMenuItem.Click
        FormPelanggan.Show()
    End Sub

    Private Sub TransaksiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransaksiToolStripMenuItem.Click
        FormTransaksi.Show()
    End Sub

    Private Sub DetailTransaksiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DetailTransaksiToolStripMenuItem.Click
        FormDetailTransaksi.Show()
    End Sub
End Class
