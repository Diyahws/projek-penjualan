<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDetailTransaksi
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DGV_DetailTransaksi = New System.Windows.Forms.DataGridView()
        Me.Button_Clear = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox_Id = New System.Windows.Forms.TextBox()
        Me.TextBox_Harga = New System.Windows.Forms.TextBox()
        Me.TextBox_Total = New System.Windows.Forms.TextBox()
        Me.TextBox_JmlBrg = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox_Cari = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox_KdTransaksi = New System.Windows.Forms.TextBox()
        Me.TextBox_KdBarang = New System.Windows.Forms.TextBox()
        CType(Me.DGV_DetailTransaksi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(347, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(225, 25)
        Me.Label1.TabIndex = 70
        Me.Label1.Text = "DETAIL TRANSAKSI"
        '
        'DGV_DetailTransaksi
        '
        Me.DGV_DetailTransaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_DetailTransaksi.Location = New System.Drawing.Point(12, 290)
        Me.DGV_DetailTransaksi.Name = "DGV_DetailTransaksi"
        Me.DGV_DetailTransaksi.Size = New System.Drawing.Size(885, 225)
        Me.DGV_DetailTransaksi.TabIndex = 71
        '
        'Button_Clear
        '
        Me.Button_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Clear.Location = New System.Drawing.Point(167, 259)
        Me.Button_Clear.Name = "Button_Clear"
        Me.Button_Clear.Size = New System.Drawing.Size(75, 23)
        Me.Button_Clear.TabIndex = 81
        Me.Button_Clear.Text = "Clear"
        Me.Button_Clear.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(16, 13)
        Me.Label2.TabIndex = 82
        Me.Label2.Text = "Id"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 13)
        Me.Label3.TabIndex = 83
        Me.Label3.Text = "Kode Transaksi"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 78)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 13)
        Me.Label4.TabIndex = 84
        Me.Label4.Text = "Kode Barang"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 105)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 13)
        Me.Label5.TabIndex = 85
        Me.Label5.Text = "Harga"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(20, 131)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 13)
        Me.Label6.TabIndex = 86
        Me.Label6.Text = "Jumlah Item"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(20, 157)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 13)
        Me.Label7.TabIndex = 87
        Me.Label7.Text = "Total"
        '
        'TextBox_Id
        '
        Me.TextBox_Id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox_Id.Location = New System.Drawing.Point(130, 22)
        Me.TextBox_Id.Name = "TextBox_Id"
        Me.TextBox_Id.Size = New System.Drawing.Size(78, 20)
        Me.TextBox_Id.TabIndex = 88
        '
        'TextBox_Harga
        '
        Me.TextBox_Harga.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.TextBox_Harga.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox_Harga.Enabled = False
        Me.TextBox_Harga.HideSelection = False
        Me.TextBox_Harga.Location = New System.Drawing.Point(130, 102)
        Me.TextBox_Harga.Name = "TextBox_Harga"
        Me.TextBox_Harga.Size = New System.Drawing.Size(167, 20)
        Me.TextBox_Harga.TabIndex = 89
        '
        'TextBox_Total
        '
        Me.TextBox_Total.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.TextBox_Total.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox_Total.Enabled = False
        Me.TextBox_Total.HideSelection = False
        Me.TextBox_Total.Location = New System.Drawing.Point(130, 154)
        Me.TextBox_Total.Name = "TextBox_Total"
        Me.TextBox_Total.Size = New System.Drawing.Size(167, 20)
        Me.TextBox_Total.TabIndex = 90
        '
        'TextBox_JmlBrg
        '
        Me.TextBox_JmlBrg.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.TextBox_JmlBrg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox_JmlBrg.Enabled = False
        Me.TextBox_JmlBrg.Location = New System.Drawing.Point(130, 128)
        Me.TextBox_JmlBrg.Name = "TextBox_JmlBrg"
        Me.TextBox_JmlBrg.Size = New System.Drawing.Size(167, 20)
        Me.TextBox_JmlBrg.TabIndex = 91
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(655, 262)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(29, 15)
        Me.Label8.TabIndex = 95
        Me.Label8.Text = "Cari"
        '
        'TextBox_Cari
        '
        Me.TextBox_Cari.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox_Cari.Location = New System.Drawing.Point(699, 261)
        Me.TextBox_Cari.Name = "TextBox_Cari"
        Me.TextBox_Cari.Size = New System.Drawing.Size(198, 20)
        Me.TextBox_Cari.TabIndex = 94
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox_KdBarang)
        Me.GroupBox1.Controls.Add(Me.TextBox_KdTransaksi)
        Me.GroupBox1.Controls.Add(Me.TextBox_Total)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TextBox_JmlBrg)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.TextBox_Harga)
        Me.GroupBox1.Controls.Add(Me.TextBox_Id)
        Me.GroupBox1.Location = New System.Drawing.Point(37, 60)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(382, 193)
        Me.GroupBox1.TabIndex = 96
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Edit Detail"
        '
        'TextBox_KdTransaksi
        '
        Me.TextBox_KdTransaksi.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.TextBox_KdTransaksi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox_KdTransaksi.Enabled = False
        Me.TextBox_KdTransaksi.HideSelection = False
        Me.TextBox_KdTransaksi.Location = New System.Drawing.Point(130, 48)
        Me.TextBox_KdTransaksi.Name = "TextBox_KdTransaksi"
        Me.TextBox_KdTransaksi.Size = New System.Drawing.Size(167, 20)
        Me.TextBox_KdTransaksi.TabIndex = 94
        '
        'TextBox_KdBarang
        '
        Me.TextBox_KdBarang.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.TextBox_KdBarang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox_KdBarang.Enabled = False
        Me.TextBox_KdBarang.HideSelection = False
        Me.TextBox_KdBarang.Location = New System.Drawing.Point(130, 74)
        Me.TextBox_KdBarang.Name = "TextBox_KdBarang"
        Me.TextBox_KdBarang.Size = New System.Drawing.Size(167, 20)
        Me.TextBox_KdBarang.TabIndex = 95
        '
        'FormDetailTransaksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SandyBrown
        Me.ClientSize = New System.Drawing.Size(909, 527)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TextBox_Cari)
        Me.Controls.Add(Me.Button_Clear)
        Me.Controls.Add(Me.DGV_DetailTransaksi)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormDetailTransaksi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormDetailTransaksi"
        CType(Me.DGV_DetailTransaksi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DGV_DetailTransaksi As DataGridView
    Friend WithEvents Button_Clear As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox_Id As TextBox
    Friend WithEvents TextBox_Harga As TextBox
    Friend WithEvents TextBox_Total As TextBox
    Friend WithEvents TextBox_JmlBrg As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox_Cari As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBox_KdBarang As TextBox
    Friend WithEvents TextBox_KdTransaksi As TextBox
End Class
