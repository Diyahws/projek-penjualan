<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormTransaksi
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox_Kembali = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBox_Dibayar = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DGV_Transaksi = New System.Windows.Forms.DataGridView()
        Me.Button_Clear = New System.Windows.Forms.Button()
        Me.Button_Hapus = New System.Windows.Forms.Button()
        Me.Button_Simpan = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox_KdTrnsksi = New System.Windows.Forms.TextBox()
        Me.ComboBox_Plnggn = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.TextBox_Jam = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TextBox_Nama = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.TextBox_NoHP = New System.Windows.Forms.TextBox()
        Me.TextBox_Alamat = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Button_Input = New System.Windows.Forms.Button()
        Me.Button_Pelanggan = New System.Windows.Forms.Button()
        Me.Label_Total = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox_JmlJual = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TextBox_Harga = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TextBox_NmBrg = New System.Windows.Forms.TextBox()
        Me.ComboBox_Brg = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnCariBrg = New System.Windows.Forms.Button()
        Me.TextBox_JmlItem = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TextBox_User = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGV_Transaksi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(325, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 25)
        Me.Label1.TabIndex = 69
        Me.Label1.Text = "TRANSAKSI"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox_Kembali)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.TextBox_Dibayar)
        Me.GroupBox1.Location = New System.Drawing.Point(576, 443)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(256, 85)
        Me.GroupBox1.TabIndex = 70
        Me.GroupBox1.TabStop = False
        '
        'TextBox_Kembali
        '
        Me.TextBox_Kembali.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.TextBox_Kembali.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox_Kembali.Enabled = False
        Me.TextBox_Kembali.HideSelection = False
        Me.TextBox_Kembali.Location = New System.Drawing.Point(66, 48)
        Me.TextBox_Kembali.Name = "TextBox_Kembali"
        Me.TextBox_Kembali.Size = New System.Drawing.Size(169, 20)
        Me.TextBox_Kembali.TabIndex = 99
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(7, 25)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(54, 13)
        Me.Label9.TabIndex = 89
        Me.Label9.Text = "DIBAYAR"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(7, 50)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 13)
        Me.Label10.TabIndex = 90
        Me.Label10.Text = "KEMBALI"
        '
        'TextBox_Dibayar
        '
        Me.TextBox_Dibayar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox_Dibayar.Location = New System.Drawing.Point(66, 22)
        Me.TextBox_Dibayar.Name = "TextBox_Dibayar"
        Me.TextBox_Dibayar.Size = New System.Drawing.Size(169, 20)
        Me.TextBox_Dibayar.TabIndex = 96
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(353, 494)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(87, 27)
        Me.Label8.TabIndex = 88
        Me.Label8.Text = "TOTAL"
        '
        'DGV_Transaksi
        '
        Me.DGV_Transaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Transaksi.Location = New System.Drawing.Point(2, 245)
        Me.DGV_Transaksi.Name = "DGV_Transaksi"
        Me.DGV_Transaksi.Size = New System.Drawing.Size(819, 192)
        Me.DGV_Transaksi.TabIndex = 71
        '
        'Button_Clear
        '
        Me.Button_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Clear.Location = New System.Drawing.Point(174, 445)
        Me.Button_Clear.Name = "Button_Clear"
        Me.Button_Clear.Size = New System.Drawing.Size(75, 23)
        Me.Button_Clear.TabIndex = 81
        Me.Button_Clear.Text = "Clear"
        Me.Button_Clear.UseVisualStyleBackColor = True
        '
        'Button_Hapus
        '
        Me.Button_Hapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Hapus.Location = New System.Drawing.Point(93, 445)
        Me.Button_Hapus.Name = "Button_Hapus"
        Me.Button_Hapus.Size = New System.Drawing.Size(75, 23)
        Me.Button_Hapus.TabIndex = 79
        Me.Button_Hapus.Text = "Hapus"
        Me.Button_Hapus.UseVisualStyleBackColor = True
        '
        'Button_Simpan
        '
        Me.Button_Simpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Simpan.Location = New System.Drawing.Point(12, 445)
        Me.Button_Simpan.Name = "Button_Simpan"
        Me.Button_Simpan.Size = New System.Drawing.Size(75, 23)
        Me.Button_Simpan.TabIndex = 78
        Me.Button_Simpan.Text = "Simpan"
        Me.Button_Simpan.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 82
        Me.Label2.Text = "Kode Transaksi"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 164)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 83
        Me.Label3.Text = "Tgl Transaksi"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 189)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 13)
        Me.Label4.TabIndex = 84
        Me.Label4.Text = "Jam Transaksi"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 47)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 85
        Me.Label5.Text = "Nama"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 136)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 13)
        Me.Label6.TabIndex = 86
        Me.Label6.Text = "User"
        '
        'TextBox_KdTrnsksi
        '
        Me.TextBox_KdTrnsksi.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.TextBox_KdTrnsksi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox_KdTrnsksi.Enabled = False
        Me.TextBox_KdTrnsksi.Location = New System.Drawing.Point(112, 107)
        Me.TextBox_KdTrnsksi.Name = "TextBox_KdTrnsksi"
        Me.TextBox_KdTrnsksi.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_KdTrnsksi.TabIndex = 91
        '
        'ComboBox_Plnggn
        '
        Me.ComboBox_Plnggn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox_Plnggn.FormattingEnabled = True
        Me.ComboBox_Plnggn.Location = New System.Drawing.Point(98, 18)
        Me.ComboBox_Plnggn.Name = "ComboBox_Plnggn"
        Me.ComboBox_Plnggn.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox_Plnggn.TabIndex = 97
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.GradientInactiveCaption
        Me.DateTimePicker1.CalendarTitleBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker1.Location = New System.Drawing.Point(112, 160)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(121, 20)
        Me.DateTimePicker1.TabIndex = 100
        '
        'TextBox_Jam
        '
        Me.TextBox_Jam.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.TextBox_Jam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox_Jam.Enabled = False
        Me.TextBox_Jam.Location = New System.Drawing.Point(112, 186)
        Me.TextBox_Jam.Name = "TextBox_Jam"
        Me.TextBox_Jam.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_Jam.TabIndex = 101
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(6, 24)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(86, 13)
        Me.Label15.TabIndex = 99
        Me.Label15.Text = "Kode Pelanggan"
        '
        'TextBox_Nama
        '
        Me.TextBox_Nama.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.TextBox_Nama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox_Nama.Enabled = False
        Me.TextBox_Nama.HideSelection = False
        Me.TextBox_Nama.Location = New System.Drawing.Point(98, 45)
        Me.TextBox_Nama.Name = "TextBox_Nama"
        Me.TextBox_Nama.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_Nama.TabIndex = 100
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.TextBox_NoHP)
        Me.GroupBox5.Controls.Add(Me.TextBox_Alamat)
        Me.GroupBox5.Controls.Add(Me.Label17)
        Me.GroupBox5.Controls.Add(Me.Label16)
        Me.GroupBox5.Controls.Add(Me.TextBox_Nama)
        Me.GroupBox5.Controls.Add(Me.Label15)
        Me.GroupBox5.Controls.Add(Me.Label5)
        Me.GroupBox5.Controls.Add(Me.ComboBox_Plnggn)
        Me.GroupBox5.Location = New System.Drawing.Point(255, 71)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(273, 135)
        Me.GroupBox5.TabIndex = 104
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Pelanggan"
        '
        'TextBox_NoHP
        '
        Me.TextBox_NoHP.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.TextBox_NoHP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox_NoHP.Enabled = False
        Me.TextBox_NoHP.HideSelection = False
        Me.TextBox_NoHP.Location = New System.Drawing.Point(98, 97)
        Me.TextBox_NoHP.Name = "TextBox_NoHP"
        Me.TextBox_NoHP.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_NoHP.TabIndex = 104
        '
        'TextBox_Alamat
        '
        Me.TextBox_Alamat.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.TextBox_Alamat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox_Alamat.Enabled = False
        Me.TextBox_Alamat.HideSelection = False
        Me.TextBox_Alamat.Location = New System.Drawing.Point(98, 71)
        Me.TextBox_Alamat.Name = "TextBox_Alamat"
        Me.TextBox_Alamat.Size = New System.Drawing.Size(157, 20)
        Me.TextBox_Alamat.TabIndex = 103
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(6, 72)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(39, 13)
        Me.Label17.TabIndex = 102
        Me.Label17.Text = "Alamat"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(6, 99)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(42, 13)
        Me.Label16.TabIndex = 101
        Me.Label16.Text = "No. HP"
        '
        'Button_Input
        '
        Me.Button_Input.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Input.Location = New System.Drawing.Point(75, 147)
        Me.Button_Input.Name = "Button_Input"
        Me.Button_Input.Size = New System.Drawing.Size(75, 23)
        Me.Button_Input.TabIndex = 105
        Me.Button_Input.Text = "Input"
        Me.Button_Input.UseVisualStyleBackColor = True
        '
        'Button_Pelanggan
        '
        Me.Button_Pelanggan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Pelanggan.Location = New System.Drawing.Point(320, 216)
        Me.Button_Pelanggan.Name = "Button_Pelanggan"
        Me.Button_Pelanggan.Size = New System.Drawing.Size(154, 23)
        Me.Button_Pelanggan.TabIndex = 106
        Me.Button_Pelanggan.Text = "Tambah Pelanggan"
        Me.Button_Pelanggan.UseVisualStyleBackColor = True
        '
        'Label_Total
        '
        Me.Label_Total.AutoSize = True
        Me.Label_Total.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label_Total.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label_Total.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Total.Location = New System.Drawing.Point(440, 494)
        Me.Label_Total.Name = "Label_Total"
        Me.Label_Total.Size = New System.Drawing.Size(22, 27)
        Me.Label_Total.TabIndex = 107
        Me.Label_Total.Text = "-"
        Me.Label_Total.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(8, 111)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 13)
        Me.Label7.TabIndex = 87
        Me.Label7.Text = "Jumlah Terjual"
        '
        'TextBox_JmlJual
        '
        Me.TextBox_JmlJual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox_JmlJual.Location = New System.Drawing.Point(97, 109)
        Me.TextBox_JmlJual.Name = "TextBox_JmlJual"
        Me.TextBox_JmlJual.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_JmlJual.TabIndex = 94
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(8, 85)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(36, 13)
        Me.Label12.TabIndex = 95
        Me.Label12.Text = "Harga"
        '
        'TextBox_Harga
        '
        Me.TextBox_Harga.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.TextBox_Harga.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox_Harga.Enabled = False
        Me.TextBox_Harga.HideSelection = False
        Me.TextBox_Harga.Location = New System.Drawing.Point(97, 83)
        Me.TextBox_Harga.Name = "TextBox_Harga"
        Me.TextBox_Harga.Size = New System.Drawing.Size(122, 20)
        Me.TextBox_Harga.TabIndex = 96
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(8, 33)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(69, 13)
        Me.Label13.TabIndex = 97
        Me.Label13.Text = "Kode Barang"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(8, 58)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(72, 13)
        Me.Label14.TabIndex = 98
        Me.Label14.Text = "Nama Barang"
        '
        'TextBox_NmBrg
        '
        Me.TextBox_NmBrg.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.TextBox_NmBrg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox_NmBrg.Enabled = False
        Me.TextBox_NmBrg.HideSelection = False
        Me.TextBox_NmBrg.Location = New System.Drawing.Point(97, 57)
        Me.TextBox_NmBrg.Name = "TextBox_NmBrg"
        Me.TextBox_NmBrg.Size = New System.Drawing.Size(151, 20)
        Me.TextBox_NmBrg.TabIndex = 99
        '
        'ComboBox_Brg
        '
        Me.ComboBox_Brg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox_Brg.FormattingEnabled = True
        Me.ComboBox_Brg.Location = New System.Drawing.Point(97, 30)
        Me.ComboBox_Brg.Name = "ComboBox_Brg"
        Me.ComboBox_Brg.Size = New System.Drawing.Size(84, 21)
        Me.ComboBox_Brg.TabIndex = 100
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnCariBrg)
        Me.GroupBox2.Controls.Add(Me.ComboBox_Brg)
        Me.GroupBox2.Controls.Add(Me.TextBox_NmBrg)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.TextBox_Harga)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.TextBox_JmlJual)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Button_Input)
        Me.GroupBox2.Location = New System.Drawing.Point(567, 56)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(254, 183)
        Me.GroupBox2.TabIndex = 101
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Barang"
        '
        'btnCariBrg
        '
        Me.btnCariBrg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCariBrg.Location = New System.Drawing.Point(187, 28)
        Me.btnCariBrg.Name = "btnCariBrg"
        Me.btnCariBrg.Size = New System.Drawing.Size(61, 23)
        Me.btnCariBrg.TabIndex = 106
        Me.btnCariBrg.Text = "Cari"
        Me.btnCariBrg.UseVisualStyleBackColor = True
        '
        'TextBox_JmlItem
        '
        Me.TextBox_JmlItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox_JmlItem.Location = New System.Drawing.Point(428, 460)
        Me.TextBox_JmlItem.Name = "TextBox_JmlItem"
        Me.TextBox_JmlItem.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_JmlItem.TabIndex = 111
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(357, 463)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(63, 13)
        Me.Label18.TabIndex = 110
        Me.Label18.Text = "Jumlah Item"
        '
        'TextBox_User
        '
        Me.TextBox_User.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.TextBox_User.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox_User.Enabled = False
        Me.TextBox_User.HideSelection = False
        Me.TextBox_User.Location = New System.Drawing.Point(112, 133)
        Me.TextBox_User.Name = "TextBox_User"
        Me.TextBox_User.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_User.TabIndex = 112
        '
        'FormTransaksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SandyBrown
        Me.ClientSize = New System.Drawing.Size(833, 530)
        Me.Controls.Add(Me.TextBox_User)
        Me.Controls.Add(Me.TextBox_JmlItem)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.TextBox_Jam)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label_Total)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button_Pelanggan)
        Me.Controls.Add(Me.TextBox_KdTrnsksi)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.DGV_Transaksi)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button_Clear)
        Me.Controls.Add(Me.Button_Simpan)
        Me.Controls.Add(Me.Button_Hapus)
        Me.Name = "FormTransaksi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormTransaksi"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGV_Transaksi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DGV_Transaksi As DataGridView
    Friend WithEvents Button_Clear As Button
    Friend WithEvents Button_Hapus As Button
    Friend WithEvents Button_Simpan As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents TextBox_Kembali As TextBox
    Friend WithEvents ComboBox_Plnggn As ComboBox
    Friend WithEvents TextBox_Dibayar As TextBox
    Friend WithEvents TextBox_KdTrnsksi As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents TextBox_Nama As TextBox
    Friend WithEvents TextBox_Jam As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents TextBox_NoHP As TextBox
    Friend WithEvents TextBox_Alamat As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Button_Input As Button
    Friend WithEvents Button_Pelanggan As Button
    Friend WithEvents Label_Total As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox_JmlJual As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TextBox_Harga As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents TextBox_NmBrg As TextBox
    Friend WithEvents ComboBox_Brg As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TextBox_JmlItem As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents TextBox_User As TextBox
    Friend WithEvents btnCariBrg As Button
End Class
