<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmUser))
        Me.BtnTutup = New System.Windows.Forms.Button()
        Me.BtnBatal = New System.Windows.Forms.Button()
        Me.BtnHapus = New System.Windows.Forms.Button()
        Me.BtnUbah = New System.Windows.Forms.Button()
        Me.BtnSimpan = New System.Windows.Forms.Button()
        Me.BtnCari = New System.Windows.Forms.Button()
        Me.DgPengguna = New System.Windows.Forms.DataGridView()
        Me.CboLevel = New System.Windows.Forms.ComboBox()
        Me.TxtUlangPassword = New System.Windows.Forms.TextBox()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.TxtNmPengguna = New System.Windows.Forms.TextBox()
        Me.TxtKdPengguna = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DgPengguna, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnTutup
        '
        Me.BtnTutup.Image = CType(resources.GetObject("BtnTutup.Image"), System.Drawing.Image)
        Me.BtnTutup.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnTutup.Location = New System.Drawing.Point(1024, 164)
        Me.BtnTutup.Margin = New System.Windows.Forms.Padding(6)
        Me.BtnTutup.Name = "BtnTutup"
        Me.BtnTutup.Size = New System.Drawing.Size(112, 104)
        Me.BtnTutup.TabIndex = 69
        Me.BtnTutup.Text = "Tutup"
        Me.BtnTutup.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnTutup.UseVisualStyleBackColor = True
        '
        'BtnBatal
        '
        Me.BtnBatal.Image = CType(resources.GetObject("BtnBatal.Image"), System.Drawing.Image)
        Me.BtnBatal.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnBatal.Location = New System.Drawing.Point(900, 164)
        Me.BtnBatal.Margin = New System.Windows.Forms.Padding(6)
        Me.BtnBatal.Name = "BtnBatal"
        Me.BtnBatal.Size = New System.Drawing.Size(112, 104)
        Me.BtnBatal.TabIndex = 68
        Me.BtnBatal.Text = "Batal"
        Me.BtnBatal.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnBatal.UseVisualStyleBackColor = True
        '
        'BtnHapus
        '
        Me.BtnHapus.Image = CType(resources.GetObject("BtnHapus.Image"), System.Drawing.Image)
        Me.BtnHapus.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnHapus.Location = New System.Drawing.Point(776, 164)
        Me.BtnHapus.Margin = New System.Windows.Forms.Padding(6)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(112, 104)
        Me.BtnHapus.TabIndex = 67
        Me.BtnHapus.Text = "Hapus"
        Me.BtnHapus.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnHapus.UseVisualStyleBackColor = True
        '
        'BtnUbah
        '
        Me.BtnUbah.Image = CType(resources.GetObject("BtnUbah.Image"), System.Drawing.Image)
        Me.BtnUbah.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnUbah.Location = New System.Drawing.Point(652, 164)
        Me.BtnUbah.Margin = New System.Windows.Forms.Padding(6)
        Me.BtnUbah.Name = "BtnUbah"
        Me.BtnUbah.Size = New System.Drawing.Size(112, 104)
        Me.BtnUbah.TabIndex = 66
        Me.BtnUbah.Text = "Ubah"
        Me.BtnUbah.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnUbah.UseVisualStyleBackColor = True
        '
        'BtnSimpan
        '
        Me.BtnSimpan.Image = CType(resources.GetObject("BtnSimpan.Image"), System.Drawing.Image)
        Me.BtnSimpan.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnSimpan.Location = New System.Drawing.Point(528, 164)
        Me.BtnSimpan.Margin = New System.Windows.Forms.Padding(6)
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Size = New System.Drawing.Size(112, 104)
        Me.BtnSimpan.TabIndex = 65
        Me.BtnSimpan.Text = "Simpan"
        Me.BtnSimpan.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnSimpan.UseVisualStyleBackColor = True
        '
        'BtnCari
        '
        Me.BtnCari.Location = New System.Drawing.Point(529, 27)
        Me.BtnCari.Name = "BtnCari"
        Me.BtnCari.Size = New System.Drawing.Size(108, 79)
        Me.BtnCari.TabIndex = 64
        Me.BtnCari.Text = "Cari"
        Me.BtnCari.UseVisualStyleBackColor = True
        '
        'DgPengguna
        '
        Me.DgPengguna.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgPengguna.Location = New System.Drawing.Point(33, 324)
        Me.DgPengguna.Name = "DgPengguna"
        Me.DgPengguna.RowHeadersWidth = 82
        Me.DgPengguna.RowTemplate.Height = 33
        Me.DgPengguna.Size = New System.Drawing.Size(1103, 310)
        Me.DgPengguna.TabIndex = 63
        '
        'CboLevel
        '
        Me.CboLevel.FormattingEnabled = True
        Me.CboLevel.Location = New System.Drawing.Point(211, 231)
        Me.CboLevel.Name = "CboLevel"
        Me.CboLevel.Size = New System.Drawing.Size(261, 33)
        Me.CboLevel.TabIndex = 62
        '
        'TxtUlangPassword
        '
        Me.TxtUlangPassword.Location = New System.Drawing.Point(211, 180)
        Me.TxtUlangPassword.Name = "TxtUlangPassword"
        Me.TxtUlangPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtUlangPassword.Size = New System.Drawing.Size(261, 31)
        Me.TxtUlangPassword.TabIndex = 61
        '
        'TxtPassword
        '
        Me.TxtPassword.Location = New System.Drawing.Point(211, 129)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPassword.Size = New System.Drawing.Size(261, 31)
        Me.TxtPassword.TabIndex = 60
        '
        'TxtNmPengguna
        '
        Me.TxtNmPengguna.Location = New System.Drawing.Point(211, 78)
        Me.TxtNmPengguna.Name = "TxtNmPengguna"
        Me.TxtNmPengguna.Size = New System.Drawing.Size(261, 31)
        Me.TxtNmPengguna.TabIndex = 59
        '
        'TxtKdPengguna
        '
        Me.TxtKdPengguna.Location = New System.Drawing.Point(211, 27)
        Me.TxtKdPengguna.Name = "TxtKdPengguna"
        Me.TxtKdPengguna.Size = New System.Drawing.Size(261, 31)
        Me.TxtKdPengguna.TabIndex = 58
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(28, 234)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 25)
        Me.Label5.TabIndex = 57
        Me.Label5.Text = "Role"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 183)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(168, 25)
        Me.Label4.TabIndex = 56
        Me.Label4.Text = "Ulang Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 25)
        Me.Label3.TabIndex = 55
        Me.Label3.Text = "Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 25)
        Me.Label2.TabIndex = 54
        Me.Label2.Text = "Username"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 25)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "User ID"
        '
        'FrmUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1172, 666)
        Me.Controls.Add(Me.BtnTutup)
        Me.Controls.Add(Me.BtnBatal)
        Me.Controls.Add(Me.BtnHapus)
        Me.Controls.Add(Me.BtnUbah)
        Me.Controls.Add(Me.BtnSimpan)
        Me.Controls.Add(Me.BtnCari)
        Me.Controls.Add(Me.DgPengguna)
        Me.Controls.Add(Me.CboLevel)
        Me.Controls.Add(Me.TxtUlangPassword)
        Me.Controls.Add(Me.TxtPassword)
        Me.Controls.Add(Me.TxtNmPengguna)
        Me.Controls.Add(Me.TxtKdPengguna)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Form User"
        CType(Me.DgPengguna, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnTutup As Button
    Friend WithEvents BtnBatal As Button
    Friend WithEvents BtnHapus As Button
    Friend WithEvents BtnUbah As Button
    Friend WithEvents BtnSimpan As Button
    Friend WithEvents BtnCari As Button
    Friend WithEvents DgPengguna As DataGridView
    Friend WithEvents CboLevel As ComboBox
    Friend WithEvents TxtUlangPassword As TextBox
    Friend WithEvents TxtPassword As TextBox
    Friend WithEvents TxtNmPengguna As TextBox
    Friend WithEvents TxtKdPengguna As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
