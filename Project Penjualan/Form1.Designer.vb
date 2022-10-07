<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.UserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PelangganToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransaksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DetailTransaksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel_Login = New System.Windows.Forms.Panel()
        Me.Panel_Welcome = New System.Windows.Forms.Panel()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.STLabel_Kode = New System.Windows.Forms.ToolStripStatusLabel()
        Me.STLabel_Kode0 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.STLabel_Nama = New System.Windows.Forms.ToolStripStatusLabel()
        Me.STLabel_Nama0 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.STLabel_Level = New System.Windows.Forms.ToolStripStatusLabel()
        Me.STLabel_Level0 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.STLabel_Tanggal = New System.Windows.Forms.ToolStripStatusLabel()
        Me.STLabel_Tanggal0 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.STLabel_Tanggal9 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.STLabel_Jam0 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBox_Lvl = New System.Windows.Forms.ComboBox()
        Me.Button_Masuk = New System.Windows.Forms.Button()
        Me.TextBox_Pass = New System.Windows.Forms.TextBox()
        Me.TextBox_Uname = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.Panel_Login.SuspendLayout()
        Me.Panel_Welcome.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.SandyBrown
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.MenuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UserToolStripMenuItem, Me.BarangToolStripMenuItem, Me.PelangganToolStripMenuItem, Me.TransaksiToolStripMenuItem, Me.DetailTransaksiToolStripMenuItem, Me.KeluarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.MenuStrip1.Size = New System.Drawing.Size(145, 450)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'UserToolStripMenuItem
        '
        Me.UserToolStripMenuItem.ForeColor = System.Drawing.Color.Firebrick
        Me.UserToolStripMenuItem.Name = "UserToolStripMenuItem"
        Me.UserToolStripMenuItem.Size = New System.Drawing.Size(138, 25)
        Me.UserToolStripMenuItem.Text = "User"
        '
        'BarangToolStripMenuItem
        '
        Me.BarangToolStripMenuItem.ForeColor = System.Drawing.Color.Firebrick
        Me.BarangToolStripMenuItem.Name = "BarangToolStripMenuItem"
        Me.BarangToolStripMenuItem.Size = New System.Drawing.Size(138, 25)
        Me.BarangToolStripMenuItem.Text = "Barang"
        '
        'PelangganToolStripMenuItem
        '
        Me.PelangganToolStripMenuItem.ForeColor = System.Drawing.Color.Firebrick
        Me.PelangganToolStripMenuItem.Name = "PelangganToolStripMenuItem"
        Me.PelangganToolStripMenuItem.Size = New System.Drawing.Size(138, 25)
        Me.PelangganToolStripMenuItem.Text = "Pelanggan"
        '
        'TransaksiToolStripMenuItem
        '
        Me.TransaksiToolStripMenuItem.ForeColor = System.Drawing.Color.Firebrick
        Me.TransaksiToolStripMenuItem.Name = "TransaksiToolStripMenuItem"
        Me.TransaksiToolStripMenuItem.Size = New System.Drawing.Size(138, 25)
        Me.TransaksiToolStripMenuItem.Text = "Transaksi"
        '
        'DetailTransaksiToolStripMenuItem
        '
        Me.DetailTransaksiToolStripMenuItem.ForeColor = System.Drawing.Color.Firebrick
        Me.DetailTransaksiToolStripMenuItem.Name = "DetailTransaksiToolStripMenuItem"
        Me.DetailTransaksiToolStripMenuItem.Size = New System.Drawing.Size(138, 25)
        Me.DetailTransaksiToolStripMenuItem.Text = "Detail Transaksi"
        '
        'KeluarToolStripMenuItem
        '
        Me.KeluarToolStripMenuItem.ForeColor = System.Drawing.Color.Firebrick
        Me.KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        Me.KeluarToolStripMenuItem.Size = New System.Drawing.Size(138, 25)
        Me.KeluarToolStripMenuItem.Text = "Keluar"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Firebrick
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(145, 420)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(822, 30)
        Me.Panel1.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Firebrick
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(145, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(822, 30)
        Me.Panel2.TabIndex = 2
        '
        'Panel_Login
        '
        Me.Panel_Login.BackColor = System.Drawing.Color.SandyBrown
        Me.Panel_Login.Controls.Add(Me.Panel_Welcome)
        Me.Panel_Login.Controls.Add(Me.Label4)
        Me.Panel_Login.Controls.Add(Me.ComboBox_Lvl)
        Me.Panel_Login.Controls.Add(Me.Button_Masuk)
        Me.Panel_Login.Controls.Add(Me.TextBox_Pass)
        Me.Panel_Login.Controls.Add(Me.TextBox_Uname)
        Me.Panel_Login.Controls.Add(Me.Label3)
        Me.Panel_Login.Controls.Add(Me.Label2)
        Me.Panel_Login.Controls.Add(Me.Label1)
        Me.Panel_Login.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_Login.Location = New System.Drawing.Point(145, 30)
        Me.Panel_Login.Name = "Panel_Login"
        Me.Panel_Login.Size = New System.Drawing.Size(822, 390)
        Me.Panel_Login.TabIndex = 3
        '
        'Panel_Welcome
        '
        Me.Panel_Welcome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel_Welcome.Controls.Add(Me.StatusStrip1)
        Me.Panel_Welcome.Controls.Add(Me.PictureBox1)
        Me.Panel_Welcome.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_Welcome.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Welcome.Name = "Panel_Welcome"
        Me.Panel_Welcome.Size = New System.Drawing.Size(822, 390)
        Me.Panel_Welcome.TabIndex = 24
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.STLabel_Kode, Me.STLabel_Kode0, Me.STLabel_Nama, Me.STLabel_Nama0, Me.STLabel_Level, Me.STLabel_Level0, Me.STLabel_Tanggal, Me.STLabel_Tanggal0, Me.STLabel_Tanggal9, Me.STLabel_Jam0})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 368)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(822, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'STLabel_Kode
        '
        Me.STLabel_Kode.Name = "STLabel_Kode"
        Me.STLabel_Kode.Size = New System.Drawing.Size(37, 17)
        Me.STLabel_Kode.Text = "Kode:"
        '
        'STLabel_Kode0
        '
        Me.STLabel_Kode0.ForeColor = System.Drawing.Color.Firebrick
        Me.STLabel_Kode0.Name = "STLabel_Kode0"
        Me.STLabel_Kode0.Size = New System.Drawing.Size(0, 17)
        '
        'STLabel_Nama
        '
        Me.STLabel_Nama.Name = "STLabel_Nama"
        Me.STLabel_Nama.Size = New System.Drawing.Size(42, 17)
        Me.STLabel_Nama.Text = "Nama:"
        '
        'STLabel_Nama0
        '
        Me.STLabel_Nama0.ForeColor = System.Drawing.Color.Firebrick
        Me.STLabel_Nama0.Name = "STLabel_Nama0"
        Me.STLabel_Nama0.Size = New System.Drawing.Size(0, 17)
        '
        'STLabel_Level
        '
        Me.STLabel_Level.Name = "STLabel_Level"
        Me.STLabel_Level.Size = New System.Drawing.Size(37, 17)
        Me.STLabel_Level.Text = "Level:"
        '
        'STLabel_Level0
        '
        Me.STLabel_Level0.ForeColor = System.Drawing.Color.Firebrick
        Me.STLabel_Level0.Name = "STLabel_Level0"
        Me.STLabel_Level0.Size = New System.Drawing.Size(0, 17)
        '
        'STLabel_Tanggal
        '
        Me.STLabel_Tanggal.Name = "STLabel_Tanggal"
        Me.STLabel_Tanggal.Size = New System.Drawing.Size(51, 17)
        Me.STLabel_Tanggal.Text = "Tanggal:"
        '
        'STLabel_Tanggal0
        '
        Me.STLabel_Tanggal0.ForeColor = System.Drawing.Color.Firebrick
        Me.STLabel_Tanggal0.Name = "STLabel_Tanggal0"
        Me.STLabel_Tanggal0.Size = New System.Drawing.Size(0, 17)
        '
        'STLabel_Tanggal9
        '
        Me.STLabel_Tanggal9.Name = "STLabel_Tanggal9"
        Me.STLabel_Tanggal9.Size = New System.Drawing.Size(31, 17)
        Me.STLabel_Tanggal9.Text = "Jam:"
        '
        'STLabel_Jam0
        '
        Me.STLabel_Jam0.ForeColor = System.Drawing.Color.Firebrick
        Me.STLabel_Jam0.Name = "STLabel_Jam0"
        Me.STLabel_Jam0.Size = New System.Drawing.Size(0, 17)
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Project_Penjualan.My.Resources.Resources.kindpng_346212
        Me.PictureBox1.Location = New System.Drawing.Point(83, 90)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(651, 211)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Location = New System.Drawing.Point(214, 211)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 13)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Level"
        '
        'ComboBox_Lvl
        '
        Me.ComboBox_Lvl.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox_Lvl.FormattingEnabled = True
        Me.ComboBox_Lvl.Items.AddRange(New Object() {"Admin", "Operator"})
        Me.ComboBox_Lvl.Location = New System.Drawing.Point(296, 208)
        Me.ComboBox_Lvl.Name = "ComboBox_Lvl"
        Me.ComboBox_Lvl.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox_Lvl.TabIndex = 22
        '
        'Button_Masuk
        '
        Me.Button_Masuk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Masuk.Location = New System.Drawing.Point(296, 278)
        Me.Button_Masuk.Name = "Button_Masuk"
        Me.Button_Masuk.Size = New System.Drawing.Size(75, 23)
        Me.Button_Masuk.TabIndex = 21
        Me.Button_Masuk.Text = "Masuk"
        Me.Button_Masuk.UseVisualStyleBackColor = True
        '
        'TextBox_Pass
        '
        Me.TextBox_Pass.Location = New System.Drawing.Point(296, 175)
        Me.TextBox_Pass.Name = "TextBox_Pass"
        Me.TextBox_Pass.Size = New System.Drawing.Size(147, 20)
        Me.TextBox_Pass.TabIndex = 20
        Me.TextBox_Pass.UseSystemPasswordChar = True
        '
        'TextBox_Uname
        '
        Me.TextBox_Uname.Location = New System.Drawing.Point(296, 143)
        Me.TextBox_Uname.Name = "TextBox_Uname"
        Me.TextBox_Uname.Size = New System.Drawing.Size(147, 20)
        Me.TextBox_Uname.TabIndex = 19
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Location = New System.Drawing.Point(214, 178)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Location = New System.Drawing.Point(214, 146)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Username"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.SandyBrown
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(291, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 25)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "LOGIN"
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(967, 450)
        Me.Controls.Add(Me.Panel_Login)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel_Login.ResumeLayout(False)
        Me.Panel_Login.PerformLayout()
        Me.Panel_Welcome.ResumeLayout(False)
        Me.Panel_Welcome.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents UserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BarangToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PelangganToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransaksiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DetailTransaksiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel_Login As Panel
    Friend WithEvents Panel_Welcome As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents ComboBox_Lvl As ComboBox
    Friend WithEvents Button_Masuk As Button
    Friend WithEvents TextBox_Pass As TextBox
    Friend WithEvents TextBox_Uname As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents STLabel_Kode As ToolStripStatusLabel
    Friend WithEvents STLabel_Kode0 As ToolStripStatusLabel
    Friend WithEvents STLabel_Nama As ToolStripStatusLabel
    Friend WithEvents STLabel_Nama0 As ToolStripStatusLabel
    Friend WithEvents STLabel_Level As ToolStripStatusLabel
    Friend WithEvents STLabel_Level0 As ToolStripStatusLabel
    Friend WithEvents STLabel_Tanggal As ToolStripStatusLabel
    Friend WithEvents STLabel_Tanggal0 As ToolStripStatusLabel
    Friend WithEvents STLabel_Tanggal9 As ToolStripStatusLabel
    Friend WithEvents STLabel_Jam0 As ToolStripStatusLabel
    Friend WithEvents Timer2 As Timer
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
End Class
