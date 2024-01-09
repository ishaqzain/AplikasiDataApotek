<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMainMenu
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SistemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.HakAksesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.KeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MasterDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JenisObatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataObatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransaksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PenjualanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LprObatToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LprPenjualanToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.TsUser = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TsRole = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TsTanggal = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TsJam = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TsInfo = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SistemToolStripMenuItem, Me.MasterDataToolStripMenuItem, Me.TransaksiToolStripMenuItem, Me.LaporanToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1544, 40)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SistemToolStripMenuItem
        '
        Me.SistemToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UserToolStripMenuItem, Me.ToolStripMenuItem1, Me.HakAksesToolStripMenuItem, Me.ToolStripMenuItem2, Me.KeluarToolStripMenuItem})
        Me.SistemToolStripMenuItem.Name = "SistemToolStripMenuItem"
        Me.SistemToolStripMenuItem.Size = New System.Drawing.Size(105, 36)
        Me.SistemToolStripMenuItem.Text = "Sistem"
        '
        'UserToolStripMenuItem
        '
        Me.UserToolStripMenuItem.Name = "UserToolStripMenuItem"
        Me.UserToolStripMenuItem.Size = New System.Drawing.Size(359, 44)
        Me.UserToolStripMenuItem.Text = "Users"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(356, 6)
        '
        'HakAksesToolStripMenuItem
        '
        Me.HakAksesToolStripMenuItem.Name = "HakAksesToolStripMenuItem"
        Me.HakAksesToolStripMenuItem.Size = New System.Drawing.Size(359, 44)
        Me.HakAksesToolStripMenuItem.Text = "Hak Akses"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(356, 6)
        '
        'KeluarToolStripMenuItem
        '
        Me.KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        Me.KeluarToolStripMenuItem.Size = New System.Drawing.Size(359, 44)
        Me.KeluarToolStripMenuItem.Text = "K&eluar"
        '
        'MasterDataToolStripMenuItem
        '
        Me.MasterDataToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.JenisObatToolStripMenuItem, Me.DataObatToolStripMenuItem})
        Me.MasterDataToolStripMenuItem.Name = "MasterDataToolStripMenuItem"
        Me.MasterDataToolStripMenuItem.Size = New System.Drawing.Size(163, 36)
        Me.MasterDataToolStripMenuItem.Text = "Master Data"
        '
        'JenisObatToolStripMenuItem
        '
        Me.JenisObatToolStripMenuItem.Name = "JenisObatToolStripMenuItem"
        Me.JenisObatToolStripMenuItem.Size = New System.Drawing.Size(359, 44)
        Me.JenisObatToolStripMenuItem.Text = "Jenis Obat"
        '
        'DataObatToolStripMenuItem
        '
        Me.DataObatToolStripMenuItem.Name = "DataObatToolStripMenuItem"
        Me.DataObatToolStripMenuItem.Size = New System.Drawing.Size(359, 44)
        Me.DataObatToolStripMenuItem.Text = "Data Obat"
        '
        'TransaksiToolStripMenuItem
        '
        Me.TransaksiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PenjualanToolStripMenuItem})
        Me.TransaksiToolStripMenuItem.Name = "TransaksiToolStripMenuItem"
        Me.TransaksiToolStripMenuItem.Size = New System.Drawing.Size(129, 36)
        Me.TransaksiToolStripMenuItem.Text = "Transaksi"
        '
        'PenjualanToolStripMenuItem
        '
        Me.PenjualanToolStripMenuItem.Name = "PenjualanToolStripMenuItem"
        Me.PenjualanToolStripMenuItem.Size = New System.Drawing.Size(359, 44)
        Me.PenjualanToolStripMenuItem.Text = "Penjualan"
        '
        'LaporanToolStripMenuItem
        '
        Me.LaporanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LprObatToolStripMenuItem1, Me.LprPenjualanToolStripMenuItem1})
        Me.LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        Me.LaporanToolStripMenuItem.Size = New System.Drawing.Size(119, 36)
        Me.LaporanToolStripMenuItem.Text = "Laporan"
        '
        'LprObatToolStripMenuItem1
        '
        Me.LprObatToolStripMenuItem1.Name = "LprObatToolStripMenuItem1"
        Me.LprObatToolStripMenuItem1.Size = New System.Drawing.Size(359, 44)
        Me.LprObatToolStripMenuItem1.Text = "Data Obat"
        '
        'LprPenjualanToolStripMenuItem1
        '
        Me.LprPenjualanToolStripMenuItem1.Name = "LprPenjualanToolStripMenuItem1"
        Me.LprPenjualanToolStripMenuItem1.Size = New System.Drawing.Size(359, 44)
        Me.LprPenjualanToolStripMenuItem1.Text = "Penjualan"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TsUser, Me.TsRole, Me.TsTanggal, Me.TsJam, Me.TsInfo})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 826)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(2, 0, 28, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(1544, 42)
        Me.StatusStrip1.TabIndex = 3
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'TsUser
        '
        Me.TsUser.Name = "TsUser"
        Me.TsUser.Size = New System.Drawing.Size(121, 32)
        Me.TsUser.Text = "Pengguna"
        '
        'TsRole
        '
        Me.TsRole.Name = "TsRole"
        Me.TsRole.Size = New System.Drawing.Size(60, 32)
        Me.TsRole.Text = "Role"
        '
        'TsTanggal
        '
        Me.TsTanggal.Name = "TsTanggal"
        Me.TsTanggal.Size = New System.Drawing.Size(96, 32)
        Me.TsTanggal.Text = "Tanggal"
        '
        'TsJam
        '
        Me.TsJam.Name = "TsJam"
        Me.TsJam.Size = New System.Drawing.Size(56, 32)
        Me.TsJam.Text = "Jam"
        '
        'TsInfo
        '
        Me.TsInfo.Name = "TsInfo"
        Me.TsInfo.Size = New System.Drawing.Size(254, 32)
        Me.TsInfo.Text = "- by Kelompok Candra"
        Me.TsInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FrmMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1544, 868)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.Name = "FrmMainMenu"
        Me.Text = "Aplikasi Apotek"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SistemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents KeluarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
    Friend WithEvents HakAksesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MasterDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents JenisObatToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataObatToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransaksiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LprObatToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents LprPenjualanToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents TsUser As ToolStripStatusLabel
    Friend WithEvents TsRole As ToolStripStatusLabel
    Friend WithEvents TsTanggal As ToolStripStatusLabel
    Friend WithEvents TsJam As ToolStripStatusLabel
    Friend WithEvents TsInfo As ToolStripStatusLabel
    Friend WithEvents PenjualanToolStripMenuItem As ToolStripMenuItem
End Class
