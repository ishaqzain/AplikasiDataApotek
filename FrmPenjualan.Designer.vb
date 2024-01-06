<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPenjualan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPenjualan))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DGPenjualan = New System.Windows.Forms.DataGridView()
        Me.txtJumlah = New System.Windows.Forms.TextBox()
        Me.DateTimePenjualan = New System.Windows.Forms.DateTimePicker()
        Me.CBObat = New System.Windows.Forms.ComboBox()
        Me.LblFaktur = New System.Windows.Forms.Label()
        Me.LblTotalHarga = New System.Windows.Forms.Label()
        Me.lblHarga = New System.Windows.Forms.Label()
        Me.BtnTutup = New System.Windows.Forms.Button()
        Me.BtnHapus = New System.Windows.Forms.Button()
        Me.BtnBatal = New System.Windows.Forms.Button()
        CType(Me.DGPenjualan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(422, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(175, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Faktur Penjualan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tanggal"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nama Obat"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(38, 128)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 25)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Jumlah"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(264, 127)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(191, 25)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Harga Satuan (Rp)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(709, 127)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(107, 25)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Total (Rp)"
        '
        'DGPenjualan
        '
        Me.DGPenjualan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGPenjualan.Location = New System.Drawing.Point(31, 199)
        Me.DGPenjualan.Name = "DGPenjualan"
        Me.DGPenjualan.RowHeadersWidth = 82
        Me.DGPenjualan.RowTemplate.Height = 33
        Me.DGPenjualan.Size = New System.Drawing.Size(1443, 558)
        Me.DGPenjualan.TabIndex = 6
        '
        'txtJumlah
        '
        Me.txtJumlah.Location = New System.Drawing.Point(160, 125)
        Me.txtJumlah.Name = "txtJumlah"
        Me.txtJumlah.Size = New System.Drawing.Size(70, 31)
        Me.txtJumlah.TabIndex = 10
        '
        'DateTimePenjualan
        '
        Me.DateTimePenjualan.Location = New System.Drawing.Point(160, 22)
        Me.DateTimePenjualan.Name = "DateTimePenjualan"
        Me.DateTimePenjualan.Size = New System.Drawing.Size(230, 31)
        Me.DateTimePenjualan.TabIndex = 11
        '
        'CBObat
        '
        Me.CBObat.FormattingEnabled = True
        Me.CBObat.Location = New System.Drawing.Point(160, 71)
        Me.CBObat.Name = "CBObat"
        Me.CBObat.Size = New System.Drawing.Size(230, 33)
        Me.CBObat.TabIndex = 12
        '
        'LblFaktur
        '
        Me.LblFaktur.BackColor = System.Drawing.Color.Yellow
        Me.LblFaktur.Location = New System.Drawing.Point(615, 22)
        Me.LblFaktur.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.LblFaktur.Name = "LblFaktur"
        Me.LblFaktur.Size = New System.Drawing.Size(136, 31)
        Me.LblFaktur.TabIndex = 55
        Me.LblFaktur.Text = "{No Faktur}"
        Me.LblFaktur.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblTotalHarga
        '
        Me.LblTotalHarga.BackColor = System.Drawing.Color.ForestGreen
        Me.LblTotalHarga.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalHarga.ForeColor = System.Drawing.Color.White
        Me.LblTotalHarga.Location = New System.Drawing.Point(825, 124)
        Me.LblTotalHarga.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.LblTotalHarga.Name = "LblTotalHarga"
        Me.LblTotalHarga.Size = New System.Drawing.Size(203, 31)
        Me.LblTotalHarga.TabIndex = 56
        Me.LblTotalHarga.Text = "{Total Harga}"
        Me.LblTotalHarga.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblHarga
        '
        Me.lblHarga.BackColor = System.Drawing.Color.OldLace
        Me.lblHarga.Location = New System.Drawing.Point(477, 124)
        Me.lblHarga.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblHarga.Name = "lblHarga"
        Me.lblHarga.Size = New System.Drawing.Size(192, 31)
        Me.lblHarga.TabIndex = 57
        Me.lblHarga.Text = "{Harga}"
        Me.lblHarga.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BtnTutup
        '
        Me.BtnTutup.Image = CType(resources.GetObject("BtnTutup.Image"), System.Drawing.Image)
        Me.BtnTutup.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnTutup.Location = New System.Drawing.Point(1362, 53)
        Me.BtnTutup.Margin = New System.Windows.Forms.Padding(6)
        Me.BtnTutup.Name = "BtnTutup"
        Me.BtnTutup.Size = New System.Drawing.Size(112, 104)
        Me.BtnTutup.TabIndex = 74
        Me.BtnTutup.Text = "Tutup"
        Me.BtnTutup.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnTutup.UseVisualStyleBackColor = True
        '
        'BtnHapus
        '
        Me.BtnHapus.Image = CType(resources.GetObject("BtnHapus.Image"), System.Drawing.Image)
        Me.BtnHapus.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnHapus.Location = New System.Drawing.Point(1090, 53)
        Me.BtnHapus.Margin = New System.Windows.Forms.Padding(6)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(112, 104)
        Me.BtnHapus.TabIndex = 72
        Me.BtnHapus.Text = "Hapus"
        Me.BtnHapus.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnHapus.UseVisualStyleBackColor = True
        '
        'BtnBatal
        '
        Me.BtnBatal.Image = CType(resources.GetObject("BtnBatal.Image"), System.Drawing.Image)
        Me.BtnBatal.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnBatal.Location = New System.Drawing.Point(1228, 53)
        Me.BtnBatal.Margin = New System.Windows.Forms.Padding(6)
        Me.BtnBatal.Name = "BtnBatal"
        Me.BtnBatal.Size = New System.Drawing.Size(112, 104)
        Me.BtnBatal.TabIndex = 75
        Me.BtnBatal.Text = "Batal"
        Me.BtnBatal.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnBatal.UseVisualStyleBackColor = True
        '
        'FrmPenjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1506, 786)
        Me.Controls.Add(Me.BtnBatal)
        Me.Controls.Add(Me.BtnTutup)
        Me.Controls.Add(Me.BtnHapus)
        Me.Controls.Add(Me.lblHarga)
        Me.Controls.Add(Me.LblTotalHarga)
        Me.Controls.Add(Me.LblFaktur)
        Me.Controls.Add(Me.CBObat)
        Me.Controls.Add(Me.DateTimePenjualan)
        Me.Controls.Add(Me.txtJumlah)
        Me.Controls.Add(Me.DGPenjualan)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmPenjualan"
        Me.Text = "Form Penjualan"
        CType(Me.DGPenjualan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents DGPenjualan As DataGridView
    Friend WithEvents txtJumlah As TextBox
    Friend WithEvents DateTimePenjualan As DateTimePicker
    Friend WithEvents CBObat As ComboBox
    Friend WithEvents LblFaktur As Label
    Friend WithEvents LblTotalHarga As Label
    Friend WithEvents lblHarga As Label
    Friend WithEvents BtnTutup As Button
    Friend WithEvents BtnHapus As Button
    Friend WithEvents BtnBatal As Button
End Class
