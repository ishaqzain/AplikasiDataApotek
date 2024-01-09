<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmHakAkses
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
        Me.btnOk = New System.Windows.Forms.Button()
        Me.ChkAkses = New System.Windows.Forms.CheckBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.ChkLprJual = New System.Windows.Forms.CheckBox()
        Me.ChkLprObat = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ChkPenjualan = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ChkObt = New System.Windows.Forms.CheckBox()
        Me.ChkJenis = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ChkUser = New System.Windows.Forms.CheckBox()
        Me.CmbLevel = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(747, 490)
        Me.btnOk.Margin = New System.Windows.Forms.Padding(6)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(150, 44)
        Me.btnOk.TabIndex = 23
        Me.btnOk.Text = "SAVE"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'ChkAkses
        '
        Me.ChkAkses.AutoSize = True
        Me.ChkAkses.Location = New System.Drawing.Point(17, 79)
        Me.ChkAkses.Margin = New System.Windows.Forms.Padding(6)
        Me.ChkAkses.Name = "ChkAkses"
        Me.ChkAkses.Size = New System.Drawing.Size(147, 29)
        Me.ChkAkses.TabIndex = 22
        Me.ChkAkses.Text = "Hak Akses"
        Me.ChkAkses.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.ChkLprJual)
        Me.GroupBox4.Controls.Add(Me.ChkLprObat)
        Me.GroupBox4.Location = New System.Drawing.Point(497, 315)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(6)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(6)
        Me.GroupBox4.Size = New System.Drawing.Size(400, 133)
        Me.GroupBox4.TabIndex = 21
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Laporan"
        '
        'ChkLprJual
        '
        Me.ChkLprJual.AutoSize = True
        Me.ChkLprJual.Location = New System.Drawing.Point(16, 77)
        Me.ChkLprJual.Margin = New System.Windows.Forms.Padding(6)
        Me.ChkLprJual.Name = "ChkLprJual"
        Me.ChkLprJual.Size = New System.Drawing.Size(225, 29)
        Me.ChkLprJual.TabIndex = 1
        Me.ChkLprJual.Text = "Laporan Penjualan"
        Me.ChkLprJual.UseVisualStyleBackColor = True
        '
        'ChkLprObat
        '
        Me.ChkLprObat.AutoSize = True
        Me.ChkLprObat.Location = New System.Drawing.Point(16, 38)
        Me.ChkLprObat.Margin = New System.Windows.Forms.Padding(6)
        Me.ChkLprObat.Name = "ChkLprObat"
        Me.ChkLprObat.Size = New System.Drawing.Size(226, 29)
        Me.ChkLprObat.TabIndex = 0
        Me.ChkLprObat.Text = "Laporan Data Obat"
        Me.ChkLprObat.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ChkPenjualan)
        Me.GroupBox3.Location = New System.Drawing.Point(497, 111)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(6)
        Me.GroupBox3.Size = New System.Drawing.Size(400, 136)
        Me.GroupBox3.TabIndex = 20
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Transaksi"
        '
        'ChkPenjualan
        '
        Me.ChkPenjualan.AutoSize = True
        Me.ChkPenjualan.Location = New System.Drawing.Point(12, 38)
        Me.ChkPenjualan.Margin = New System.Windows.Forms.Padding(6)
        Me.ChkPenjualan.Name = "ChkPenjualan"
        Me.ChkPenjualan.Size = New System.Drawing.Size(140, 29)
        Me.ChkPenjualan.TabIndex = 1
        Me.ChkPenjualan.Text = "Penjualan"
        Me.ChkPenjualan.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ChkObt)
        Me.GroupBox2.Controls.Add(Me.ChkJenis)
        Me.GroupBox2.Location = New System.Drawing.Point(41, 315)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(6)
        Me.GroupBox2.Size = New System.Drawing.Size(400, 133)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Master Data"
        '
        'ChkObt
        '
        Me.ChkObt.AutoSize = True
        Me.ChkObt.Location = New System.Drawing.Point(14, 77)
        Me.ChkObt.Margin = New System.Windows.Forms.Padding(6)
        Me.ChkObt.Name = "ChkObt"
        Me.ChkObt.Size = New System.Drawing.Size(141, 29)
        Me.ChkObt.TabIndex = 1
        Me.ChkObt.Text = "Data Obat"
        Me.ChkObt.UseVisualStyleBackColor = True
        '
        'ChkJenis
        '
        Me.ChkJenis.AutoSize = True
        Me.ChkJenis.Location = New System.Drawing.Point(14, 38)
        Me.ChkJenis.Margin = New System.Windows.Forms.Padding(6)
        Me.ChkJenis.Name = "ChkJenis"
        Me.ChkJenis.Size = New System.Drawing.Size(147, 29)
        Me.ChkJenis.TabIndex = 0
        Me.ChkJenis.Text = "Jenis Obat"
        Me.ChkJenis.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ChkUser)
        Me.GroupBox1.Controls.Add(Me.ChkAkses)
        Me.GroupBox1.Location = New System.Drawing.Point(43, 111)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(6)
        Me.GroupBox1.Size = New System.Drawing.Size(400, 136)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sistem"
        '
        'ChkUser
        '
        Me.ChkUser.AutoSize = True
        Me.ChkUser.Location = New System.Drawing.Point(17, 38)
        Me.ChkUser.Margin = New System.Windows.Forms.Padding(6)
        Me.ChkUser.Name = "ChkUser"
        Me.ChkUser.Size = New System.Drawing.Size(100, 29)
        Me.ChkUser.TabIndex = 0
        Me.ChkUser.Text = "Users"
        Me.ChkUser.UseVisualStyleBackColor = True
        '
        'CmbLevel
        '
        Me.CmbLevel.FormattingEnabled = True
        Me.CmbLevel.Location = New System.Drawing.Point(173, 29)
        Me.CmbLevel.Margin = New System.Windows.Forms.Padding(6)
        Me.CmbLevel.Name = "CmbLevel"
        Me.CmbLevel.Size = New System.Drawing.Size(238, 33)
        Me.CmbLevel.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 34)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 25)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Level :"
        '
        'FrmHakAkses
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(928, 571)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.CmbLevel)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmHakAkses"
        Me.Text = "Hak Akses"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnOk As Button
    Friend WithEvents ChkAkses As CheckBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents ChkLprJual As CheckBox
    Friend WithEvents ChkLprObat As CheckBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents ChkPenjualan As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ChkObt As CheckBox
    Friend WithEvents ChkJenis As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ChkUser As CheckBox
    Friend WithEvents CmbLevel As ComboBox
    Friend WithEvents Label1 As Label
End Class
