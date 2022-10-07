Public Class FormUser
    Sub panggildata_user()
        koneksi()
        da = New MySql.Data.MySqlClient.MySqlDataAdapter("SELECT * FROM user", connct)
        dt = New DataTable
        data = da.Fill(dt)

        If data > 0 Then
            DGV_User.DataSource = dt
            DGV_User.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            DGV_User.Columns(0).HeaderText = "Kode"
            DGV_User.Columns(1).HeaderText = "Nama"
            DGV_User.Columns(2).HeaderText = "Password"
            DGV_User.Columns(3).HeaderText = "Level"
        Else
            DGV_User.DataSource = Nothing
        End If
    End Sub

    Private Sub FormUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        panggildata_user()

        TextBox_KdAdmin.Select()
        TextBox_KdAdmin.MaxLength = 6
        TextBox_Nama.MaxLength = 6
        TextBox_Pass.MaxLength = 6
    End Sub

    Private Sub Button_Simpan_Click(sender As Object, e As EventArgs) Handles Button_Simpan.Click
        koneksi()

        cmd = New MySql.Data.MySqlClient.MySqlCommand("INSERT INTO user VALUES ('" & TextBox_KdAdmin.Text & "',
                                                                                    '" & TextBox_Nama.Text & "',
                                                                                    '" & TextBox_Pass.Text & "',
                                                                                    '" & ComboBox_Lvl.Text & "')", connct)

        cmd.ExecuteNonQuery()
        panggildata_user()

        TextBox_KdAdmin.Text = ""
        TextBox_Nama.Text = ""
        TextBox_Pass.Text = ""
        ComboBox_Lvl.Text = ""
    End Sub

    Private Sub Button_Edit_Click(sender As Object, e As EventArgs) Handles Button_Edit.Click
        koneksi()

        cmd = New MySql.Data.MySqlClient.MySqlCommand("UPDATE user SET kodeadmin = '" & TextBox_KdAdmin.Text & "',
                                                                       nama = '" & TextBox_Nama.Text & "',
                                                                       password = '" & TextBox_Pass.Text & "',
                                                                       level = '" & ComboBox_Lvl.Text & "'
                                                                 WHERE kodeadmin = '" & TextBox_KdAdmin.Text & "'", connct)

        cmd.ExecuteNonQuery()
        panggildata_user()

        TextBox_KdAdmin.Text = ""
        TextBox_Nama.Text = ""
        TextBox_Pass.Text = ""
        ComboBox_Lvl.Text = ""
    End Sub

    Private Sub Button_Hapus_Click(sender As Object, e As EventArgs) Handles Button_Hapus.Click
        koneksi()

        If MessageBox.Show("Yakin Hapus Data?", "Peringatan!", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            cmd = New MySql.Data.MySqlClient.MySqlCommand("DELETE FROM user WHERE kodeadmin = '" & TextBox_KdAdmin.Text & "'", connct)

            cmd.ExecuteNonQuery()
            panggildata_user()
        End If

        TextBox_KdAdmin.Text = ""
        TextBox_Nama.Text = ""
        TextBox_Pass.Text = ""
        ComboBox_Lvl.Text = ""
    End Sub

    Private Sub Button_Clear_Click(sender As Object, e As EventArgs) Handles Button_Clear.Click
        TextBox_KdAdmin.Text = ""
        TextBox_Nama.Text = ""
        TextBox_Pass.Text = ""
        ComboBox_Lvl.Text = ""
    End Sub

    Private Sub DGV_User_Click(sender As Object, e As EventArgs) Handles DGV_User.Click
        i = DGV_User.CurrentRow.Index
        With DGV_User.Rows.Item(i)
            TextBox_KdAdmin.Text = .Cells(0).Value
            TextBox_Nama.Text = .Cells(1).Value
            TextBox_Pass.Text = .Cells(2).Value
            ComboBox_Lvl.Text = .Cells(3).Value
        End With
    End Sub

    Private Sub TextBox_Cari_TextChanged(sender As Object, e As EventArgs) Handles TextBox_Cari.TextChanged
        koneksi()
        da = New MySql.Data.MySqlClient.MySqlDataAdapter("SELECT * FROM user WHERE kodeadmin LIKE '%" & TextBox_Cari.Text & "%' OR
                                                                                   nama LIKE '%" & TextBox_Cari.Text & "%' OR
                                                                                   password LIKE '%" & TextBox_Cari.Text & "%' OR
                                                                                   level LIKE '%" & TextBox_Cari.Text & "%'", connct)

        dt = New DataTable
        data = da.Fill(dt)

        If data > 0 Then
            DGV_User.DataSource = dt
            DGV_User.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            DGV_User.Columns(0).HeaderText = "Kode"
            DGV_User.Columns(1).HeaderText = "Nama"
            DGV_User.Columns(2).HeaderText = "Password"
            DGV_User.Columns(3).HeaderText = "Level"
        Else
            DGV_User.DataSource = Nothing
        End If
    End Sub
End Class