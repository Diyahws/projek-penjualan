<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBarang
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox_Satuan = New System.Windows.Forms.TextBox()
        Me.TextBox_Jumlah = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button_Clear = New System.Windows.Forms.Button()
        Me.Button_Edit = New System.Windows.Forms.Button()
        Me.Button_Hapus = New System.Windows.Forms.Button()
        Me.Button_Simpan = New System.Windows.Forms.Button()
        Me.TextBox_Harga = New System.Windows.Forms.TextBox()
        Me.TextBox_NmBarang = New System.Windows.Forms.TextBox()
        Me.TextBox_KdBarang = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DGV_Barang = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox_Cari = New System.Windows.Forms.TextBox()
        Me.Button_Input = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGV_Barang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox_Satuan)
        Me.GroupBox1.Controls.Add(Me.TextBox_Jumlah)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Button_Clear)
        Me.GroupBox1.Controls.Add(Me.Button_Edit)
        Me.GroupBox1.Controls.Add(Me.Button_Hapus)
        Me.GroupBox1.Controls.Add(Me.Button_Simpan)
        Me.GroupBox1.Controls.Add(Me.TextBox_Harga)
        Me.GroupBox1.Controls.Add(Me.TextBox_NmBarang)
        Me.GroupBox1.Controls.Add(Me.TextBox_KdBarang)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 187)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(352, 244)
        Me.GroupBox1.TabIndex = 70
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Input Barang"
        '
        'TextBox_Satuan
        '
        Me.TextBox_Satuan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox_Satuan.Location = New System.Drawing.Point(154, 138)
        Me.TextBox_Satuan.Name = "TextBox_Satuan"
        Me.TextBox_Satuan.Size = New System.Drawing.Size(121, 20)
        Me.TextBox_Satuan.TabIndex = 80
        '
        'TextBox_Jumlah
        '
        Me.TextBox_Jumlah.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox_Jumlah.Location = New System.Drawing.Point(154, 112)
        Me.TextBox_Jumlah.Name = "TextBox_Jumlah"
        Me.TextBox_Jumlah.Size = New System.Drawing.Size(121, 20)
        Me.TextBox_Jumlah.TabIndex = 79
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(51, 139)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 15)
        Me.Label6.TabIndex = 78
        Me.Label6.Text = "Satuan"
        '
        'Button_Clear
        '
        Me.Button_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Clear.Location = New System.Drawing.Point(257, 190)
        Me.Button_Clear.Name = "Button_Clear"
        Me.Button_Clear.Size = New System.Drawing.Size(75, 23)
        Me.Button_Clear.TabIndex = 77
        Me.Button_Clear.Text = "Clear"
        Me.Button_Clear.UseVisualStyleBackColor = True
        '
        'Button_Edit
        '
        Me.Button_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Edit.Location = New System.Drawing.Point(95, 190)
        Me.Button_Edit.Name = "Button_Edit"
        Me.Button_Edit.Size = New System.Drawing.Size(75, 23)
        Me.Button_Edit.TabIndex = 76
        Me.Button_Edit.Text = "Edit"
        Me.Button_Edit.UseVisualStyleBackColor = True
        '
        'Button_Hapus
        '
        Me.Button_Hapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Hapus.Location = New System.Drawing.Point(176, 190)
        Me.Button_Hapus.Name = "Button_Hapus"
        Me.Button_Hapus.Size = New System.Drawing.Size(75, 23)
        Me.Button_Hapus.TabIndex = 75
        Me.Button_Hapus.Text = "Hapus"
        Me.Button_Hapus.UseVisualStyleBackColor = True
        '
        'Button_Simpan
        '
        Me.Button_Simpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Simpan.Location = New System.Drawing.Point(14, 190)
        Me.Button_Simpan.Name = "Button_Simpan"
        Me.Button_Simpan.Size = New System.Drawing.Size(75, 23)
        Me.Button_Simpan.TabIndex = 74
        Me.Button_Simpan.Text = "Simpan"
        Me.Button_Simpan.UseVisualStyleBackColor = True
        '
        'TextBox_Harga
        '
        Me.TextBox_Harga.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox_Harga.Location = New System.Drawing.Point(154, 86)
        Me.TextBox_Harga.Name = "TextBox_Harga"
        Me.TextBox_Harga.Size = New System.Drawing.Size(121, 20)
        Me.TextBox_Harga.TabIndex = 72
        '
        'TextBox_NmBarang
        '
        Me.TextBox_NmBarang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox_NmBarang.Location = New System.Drawing.Point(154, 60)
        Me.TextBox_NmBarang.Name = "TextBox_NmBarang"
        Me.TextBox_NmBarang.Size = New System.Drawing.Size(121, 20)
        Me.TextBox_NmBarang.TabIndex = 71
        '
        'TextBox_KdBarang
        '
        Me.TextBox_KdBarang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox_KdBarang.Location = New System.Drawing.Point(154, 34)
        Me.TextBox_KdBarang.Name = "TextBox_KdBarang"
        Me.TextBox_KdBarang.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_KdBarang.TabIndex = 70
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(51, 113)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 15)
        Me.Label5.TabIndex = 69
        Me.Label5.Text = "Jumlah"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(51, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 15)
        Me.Label4.TabIndex = 68
        Me.Label4.Text = "Harga"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(51, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 15)
        Me.Label3.TabIndex = 67
        Me.Label3.Text = "Nama Barang"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(51, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 15)
        Me.Label2.TabIndex = 66
        Me.Label2.Text = "Kode Barang"
        '
        'DGV_Barang
        '
        Me.DGV_Barang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Barang.Location = New System.Drawing.Point(399, 120)
        Me.DGV_Barang.Name = "DGV_Barang"
        Me.DGV_Barang.Size = New System.Drawing.Size(389, 311)
        Me.DGV_Barang.TabIndex = 69
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(370, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 25)
        Me.Label1.TabIndex = 68
        Me.Label1.Text = "BARANG"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(122, 121)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(29, 15)
        Me.Label7.TabIndex = 84
        Me.Label7.Text = "Cari"
        '
        'TextBox_Cari
        '
        Me.TextBox_Cari.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox_Cari.Location = New System.Drawing.Point(166, 120)
        Me.TextBox_Cari.Name = "TextBox_Cari"
        Me.TextBox_Cari.Size = New System.Drawing.Size(198, 20)
        Me.TextBox_Cari.TabIndex = 83
        '
        'Button_Input
        '
        Me.Button_Input.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Input.Location = New System.Drawing.Point(289, 146)
        Me.Button_Input.Name = "Button_Input"
        Me.Button_Input.Size = New System.Drawing.Size(75, 23)
        Me.Button_Input.TabIndex = 81
        Me.Button_Input.Text = "Input"
        Me.Button_Input.UseVisualStyleBackColor = True
        '
        'FormBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SandyBrown
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button_Input)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextBox_Cari)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DGV_Barang)
        Me.Controls.Add(Me.Label1)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Name = "FormBarang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormBarang"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGV_Barang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBox_Satuan As TextBox
    Friend WithEvents TextBox_Jumlah As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Button_Clear As Button
    Friend WithEvents Button_Edit As Button
    Friend WithEvents Button_Hapus As Button
    Friend WithEvents Button_Simpan As Button
    Friend WithEvents TextBox_Harga As TextBox
    Friend WithEvents TextBox_NmBarang As TextBox
    Friend WithEvents TextBox_KdBarang As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DGV_Barang As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox_Cari As TextBox
    Friend WithEvents Button_Input As Button
End Class
