<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmObat
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmObat))
        Me.DGObat = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtCariData = New System.Windows.Forms.TextBox()
        Me.CariNmObat = New System.Windows.Forms.RadioButton()
        Me.CariKdObat = New System.Windows.Forms.RadioButton()
        Me.BtnTutup = New System.Windows.Forms.Button()
        Me.BtnBatal = New System.Windows.Forms.Button()
        Me.BtnHapus = New System.Windows.Forms.Button()
        Me.BtnUbah = New System.Windows.Forms.Button()
        Me.BtnSimpan = New System.Windows.Forms.Button()
        Me.cmbJenisObat = New System.Windows.Forms.ComboBox()
        Me.txtStock = New System.Windows.Forms.TextBox()
        Me.txtHarga = New System.Windows.Forms.TextBox()
        Me.txtNamaObat = New System.Windows.Forms.TextBox()
        Me.txtKodeObat = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        CType(Me.DGObat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGObat
        '
        Me.DGObat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGObat.Location = New System.Drawing.Point(48, 526)
        Me.DGObat.Margin = New System.Windows.Forms.Padding(6)
        Me.DGObat.Name = "DGObat"
        Me.DGObat.RowHeadersWidth = 82
        Me.DGObat.Size = New System.Drawing.Size(1086, 357)
        Me.DGObat.TabIndex = 46
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtCariData)
        Me.GroupBox1.Controls.Add(Me.CariNmObat)
        Me.GroupBox1.Controls.Add(Me.CariKdObat)
        Me.GroupBox1.Location = New System.Drawing.Point(48, 355)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(6)
        Me.GroupBox1.Size = New System.Drawing.Size(1086, 129)
        Me.GroupBox1.TabIndex = 45
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cari Berdasarkan"
        '
        'txtCariData
        '
        Me.txtCariData.Location = New System.Drawing.Point(536, 52)
        Me.txtCariData.Margin = New System.Windows.Forms.Padding(6)
        Me.txtCariData.Name = "txtCariData"
        Me.txtCariData.Size = New System.Drawing.Size(490, 31)
        Me.txtCariData.TabIndex = 3
        '
        'CariNmObat
        '
        Me.CariNmObat.AutoSize = True
        Me.CariNmObat.Location = New System.Drawing.Point(206, 54)
        Me.CariNmObat.Margin = New System.Windows.Forms.Padding(6)
        Me.CariNmObat.Name = "CariNmObat"
        Me.CariNmObat.Size = New System.Drawing.Size(151, 29)
        Me.CariNmObat.TabIndex = 1
        Me.CariNmObat.TabStop = True
        Me.CariNmObat.Text = "Nama Obat"
        Me.CariNmObat.UseVisualStyleBackColor = True
        '
        'CariKdObat
        '
        Me.CariKdObat.AutoSize = True
        Me.CariKdObat.Location = New System.Drawing.Point(20, 54)
        Me.CariKdObat.Margin = New System.Windows.Forms.Padding(6)
        Me.CariKdObat.Name = "CariKdObat"
        Me.CariKdObat.Size = New System.Drawing.Size(145, 29)
        Me.CariKdObat.TabIndex = 0
        Me.CariKdObat.TabStop = True
        Me.CariKdObat.Text = "Kode Obat"
        Me.CariKdObat.UseVisualStyleBackColor = True
        '
        'BtnTutup
        '
        Me.BtnTutup.Image = CType(resources.GetObject("BtnTutup.Image"), System.Drawing.Image)
        Me.BtnTutup.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnTutup.Location = New System.Drawing.Point(1022, 201)
        Me.BtnTutup.Margin = New System.Windows.Forms.Padding(6)
        Me.BtnTutup.Name = "BtnTutup"
        Me.BtnTutup.Size = New System.Drawing.Size(112, 104)
        Me.BtnTutup.TabIndex = 44
        Me.BtnTutup.Text = "Tutup"
        Me.BtnTutup.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnTutup.UseVisualStyleBackColor = True
        '
        'BtnBatal
        '
        Me.BtnBatal.Image = CType(resources.GetObject("BtnBatal.Image"), System.Drawing.Image)
        Me.BtnBatal.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnBatal.Location = New System.Drawing.Point(898, 201)
        Me.BtnBatal.Margin = New System.Windows.Forms.Padding(6)
        Me.BtnBatal.Name = "BtnBatal"
        Me.BtnBatal.Size = New System.Drawing.Size(112, 104)
        Me.BtnBatal.TabIndex = 43
        Me.BtnBatal.Text = "Batal"
        Me.BtnBatal.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnBatal.UseVisualStyleBackColor = True
        '
        'BtnHapus
        '
        Me.BtnHapus.Image = CType(resources.GetObject("BtnHapus.Image"), System.Drawing.Image)
        Me.BtnHapus.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnHapus.Location = New System.Drawing.Point(774, 201)
        Me.BtnHapus.Margin = New System.Windows.Forms.Padding(6)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(112, 104)
        Me.BtnHapus.TabIndex = 42
        Me.BtnHapus.Text = "Hapus"
        Me.BtnHapus.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnHapus.UseVisualStyleBackColor = True
        '
        'BtnUbah
        '
        Me.BtnUbah.Image = CType(resources.GetObject("BtnUbah.Image"), System.Drawing.Image)
        Me.BtnUbah.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnUbah.Location = New System.Drawing.Point(650, 201)
        Me.BtnUbah.Margin = New System.Windows.Forms.Padding(6)
        Me.BtnUbah.Name = "BtnUbah"
        Me.BtnUbah.Size = New System.Drawing.Size(112, 104)
        Me.BtnUbah.TabIndex = 41
        Me.BtnUbah.Text = "Ubah"
        Me.BtnUbah.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnUbah.UseVisualStyleBackColor = True
        '
        'BtnSimpan
        '
        Me.BtnSimpan.Image = CType(resources.GetObject("BtnSimpan.Image"), System.Drawing.Image)
        Me.BtnSimpan.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnSimpan.Location = New System.Drawing.Point(526, 201)
        Me.BtnSimpan.Margin = New System.Windows.Forms.Padding(6)
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Size = New System.Drawing.Size(112, 104)
        Me.BtnSimpan.TabIndex = 40
        Me.BtnSimpan.Text = "Simpan"
        Me.BtnSimpan.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnSimpan.UseVisualStyleBackColor = True
        '
        'cmbJenisObat
        '
        Me.cmbJenisObat.FormattingEnabled = True
        Me.cmbJenisObat.Location = New System.Drawing.Point(193, 160)
        Me.cmbJenisObat.Margin = New System.Windows.Forms.Padding(6)
        Me.cmbJenisObat.Name = "cmbJenisObat"
        Me.cmbJenisObat.Size = New System.Drawing.Size(196, 33)
        Me.cmbJenisObat.TabIndex = 37
        '
        'txtStock
        '
        Me.txtStock.Location = New System.Drawing.Point(193, 217)
        Me.txtStock.Margin = New System.Windows.Forms.Padding(6)
        Me.txtStock.Name = "txtStock"
        Me.txtStock.Size = New System.Drawing.Size(196, 31)
        Me.txtStock.TabIndex = 36
        '
        'txtHarga
        '
        Me.txtHarga.Location = New System.Drawing.Point(193, 271)
        Me.txtHarga.Margin = New System.Windows.Forms.Padding(6)
        Me.txtHarga.Name = "txtHarga"
        Me.txtHarga.Size = New System.Drawing.Size(196, 31)
        Me.txtHarga.TabIndex = 35
        '
        'txtNamaObat
        '
        Me.txtNamaObat.Location = New System.Drawing.Point(193, 98)
        Me.txtNamaObat.Margin = New System.Windows.Forms.Padding(6)
        Me.txtNamaObat.Name = "txtNamaObat"
        Me.txtNamaObat.Size = New System.Drawing.Size(196, 31)
        Me.txtNamaObat.TabIndex = 34
        '
        'txtKodeObat
        '
        Me.txtKodeObat.Location = New System.Drawing.Point(193, 37)
        Me.txtKodeObat.Margin = New System.Windows.Forms.Padding(6)
        Me.txtKodeObat.Name = "txtKodeObat"
        Me.txtKodeObat.Size = New System.Drawing.Size(196, 31)
        Me.txtKodeObat.TabIndex = 33
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(42, 223)
        Me.Label7.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 25)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Stock"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(43, 276)
        Me.Label5.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 25)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Harga"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(37, 165)
        Me.Label3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 25)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Jenis Obat"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 104)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 25)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Nama Obat"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 42)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 25)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Kode Obat"
        '
        'FrmObat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1177, 922)
        Me.Controls.Add(Me.DGObat)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BtnTutup)
        Me.Controls.Add(Me.BtnBatal)
        Me.Controls.Add(Me.BtnHapus)
        Me.Controls.Add(Me.BtnUbah)
        Me.Controls.Add(Me.BtnSimpan)
        Me.Controls.Add(Me.cmbJenisObat)
        Me.Controls.Add(Me.txtStock)
        Me.Controls.Add(Me.txtHarga)
        Me.Controls.Add(Me.txtNamaObat)
        Me.Controls.Add(Me.txtKodeObat)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmObat"
        Me.Text = "Form Obat"
        CType(Me.DGObat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGObat As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtCariData As TextBox
    Friend WithEvents CariNmObat As RadioButton
    Friend WithEvents CariKdObat As RadioButton
    Friend WithEvents BtnTutup As Button
    Friend WithEvents BtnBatal As Button
    Friend WithEvents BtnHapus As Button
    Friend WithEvents BtnUbah As Button
    Friend WithEvents BtnSimpan As Button
    Friend WithEvents cmbJenisObat As ComboBox
    Friend WithEvents txtStock As TextBox
    Friend WithEvents txtHarga As TextBox
    Friend WithEvents txtNamaObat As TextBox
    Friend WithEvents txtKodeObat As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
End Class
