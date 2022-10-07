<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPelanggan
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
        Me.TextBox_NoHP = New System.Windows.Forms.TextBox()
        Me.Button_Clear = New System.Windows.Forms.Button()
        Me.Button_Edit = New System.Windows.Forms.Button()
        Me.Button_Hapus = New System.Windows.Forms.Button()
        Me.Button_Simpan = New System.Windows.Forms.Button()
        Me.TextBox_Alamat = New System.Windows.Forms.TextBox()
        Me.TextBox_NmPelanggan = New System.Windows.Forms.TextBox()
        Me.TextBox_KdPelanggan = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DGV_Pelanggan = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox_Cari = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGV_Pelanggan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox_NoHP)
        Me.GroupBox1.Controls.Add(Me.Button_Clear)
        Me.GroupBox1.Controls.Add(Me.Button_Edit)
        Me.GroupBox1.Controls.Add(Me.Button_Hapus)
        Me.GroupBox1.Controls.Add(Me.Button_Simpan)
        Me.GroupBox1.Controls.Add(Me.TextBox_Alamat)
        Me.GroupBox1.Controls.Add(Me.TextBox_NmPelanggan)
        Me.GroupBox1.Controls.Add(Me.TextBox_KdPelanggan)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 155)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(352, 218)
        Me.GroupBox1.TabIndex = 70
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Input Pelanggan"
        '
        'TextBox_NoHP
        '
        Me.TextBox_NoHP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox_NoHP.Location = New System.Drawing.Point(154, 112)
        Me.TextBox_NoHP.Name = "TextBox_NoHP"
        Me.TextBox_NoHP.Size = New System.Drawing.Size(121, 20)
        Me.TextBox_NoHP.TabIndex = 78
        '
        'Button_Clear
        '
        Me.Button_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Clear.Location = New System.Drawing.Point(260, 161)
        Me.Button_Clear.Name = "Button_Clear"
        Me.Button_Clear.Size = New System.Drawing.Size(75, 23)
        Me.Button_Clear.TabIndex = 77
        Me.Button_Clear.Text = "Clear"
        Me.Button_Clear.UseVisualStyleBackColor = True
        '
        'Button_Edit
        '
        Me.Button_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Edit.Location = New System.Drawing.Point(98, 161)
        Me.Button_Edit.Name = "Button_Edit"
        Me.Button_Edit.Size = New System.Drawing.Size(75, 23)
        Me.Button_Edit.TabIndex = 76
        Me.Button_Edit.Text = "Edit"
        Me.Button_Edit.UseVisualStyleBackColor = True
        '
        'Button_Hapus
        '
        Me.Button_Hapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Hapus.Location = New System.Drawing.Point(179, 161)
        Me.Button_Hapus.Name = "Button_Hapus"
        Me.Button_Hapus.Size = New System.Drawing.Size(75, 23)
        Me.Button_Hapus.TabIndex = 75
        Me.Button_Hapus.Text = "Hapus"
        Me.Button_Hapus.UseVisualStyleBackColor = True
        '
        'Button_Simpan
        '
        Me.Button_Simpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Simpan.Location = New System.Drawing.Point(17, 161)
        Me.Button_Simpan.Name = "Button_Simpan"
        Me.Button_Simpan.Size = New System.Drawing.Size(75, 23)
        Me.Button_Simpan.TabIndex = 74
        Me.Button_Simpan.Text = "Simpan"
        Me.Button_Simpan.UseVisualStyleBackColor = True
        '
        'TextBox_Alamat
        '
        Me.TextBox_Alamat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox_Alamat.Location = New System.Drawing.Point(154, 86)
        Me.TextBox_Alamat.Name = "TextBox_Alamat"
        Me.TextBox_Alamat.Size = New System.Drawing.Size(121, 20)
        Me.TextBox_Alamat.TabIndex = 72
        '
        'TextBox_NmPelanggan
        '
        Me.TextBox_NmPelanggan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox_NmPelanggan.Location = New System.Drawing.Point(154, 60)
        Me.TextBox_NmPelanggan.Name = "TextBox_NmPelanggan"
        Me.TextBox_NmPelanggan.Size = New System.Drawing.Size(121, 20)
        Me.TextBox_NmPelanggan.TabIndex = 71
        '
        'TextBox_KdPelanggan
        '
        Me.TextBox_KdPelanggan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox_KdPelanggan.Location = New System.Drawing.Point(154, 34)
        Me.TextBox_KdPelanggan.Name = "TextBox_KdPelanggan"
        Me.TextBox_KdPelanggan.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_KdPelanggan.TabIndex = 70
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(35, 113)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 15)
        Me.Label5.TabIndex = 69
        Me.Label5.Text = "No.HP"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(35, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 15)
        Me.Label4.TabIndex = 68
        Me.Label4.Text = "Alamat"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(35, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 15)
        Me.Label3.TabIndex = 67
        Me.Label3.Text = "Nama Pelanggan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(35, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 15)
        Me.Label2.TabIndex = 66
        Me.Label2.Text = "Kode Pelanggan"
        '
        'DGV_Pelanggan
        '
        Me.DGV_Pelanggan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Pelanggan.Location = New System.Drawing.Point(399, 120)
        Me.DGV_Pelanggan.Name = "DGV_Pelanggan"
        Me.DGV_Pelanggan.Size = New System.Drawing.Size(389, 311)
        Me.DGV_Pelanggan.TabIndex = 69
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(332, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 25)
        Me.Label1.TabIndex = 68
        Me.Label1.Text = "PELANGGAN"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(122, 121)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 15)
        Me.Label6.TabIndex = 82
        Me.Label6.Text = "Cari"
        '
        'TextBox_Cari
        '
        Me.TextBox_Cari.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox_Cari.Location = New System.Drawing.Point(166, 120)
        Me.TextBox_Cari.Name = "TextBox_Cari"
        Me.TextBox_Cari.Size = New System.Drawing.Size(198, 20)
        Me.TextBox_Cari.TabIndex = 81
        '
        'FormPelanggan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SandyBrown
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBox_Cari)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DGV_Pelanggan)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormPelanggan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormPelanggan"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGV_Pelanggan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBox_NoHP As TextBox
    Friend WithEvents Button_Clear As Button
    Friend WithEvents Button_Edit As Button
    Friend WithEvents Button_Hapus As Button
    Friend WithEvents Button_Simpan As Button
    Friend WithEvents TextBox_Alamat As TextBox
    Friend WithEvents TextBox_NmPelanggan As TextBox
    Friend WithEvents TextBox_KdPelanggan As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DGV_Pelanggan As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox_Cari As TextBox
End Class
