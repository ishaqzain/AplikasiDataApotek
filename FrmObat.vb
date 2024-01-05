Public Class FrmObat

    Dim SQL As String
    Dim Proses As New ClsKoneksi
    Dim tblObat As DataTable

    Sub Data_Record()
        tblObat = Proses.ExecuteQuery("Select * From vw_obat order by kode_obat asc")
        DGObat.DataSource = tblObat
        DGObat.Columns(0).Width = 80
        DGObat.Columns(1).Width = 150
        DGObat.Columns(2).Width = 80
        DGObat.Columns(3).Width = 80
        DGObat.Columns(4).Width = 100
    End Sub

    Sub Jenis_Obat()
        tblObat = Proses.ExecuteQuery("Select * From TblJenisObat order by no asc")
        If tblObat.Rows.Count = 0 Then
        Else
            cmbJenisObat.Items.Clear()
            With tblObat.Columns(1)
                For a = 0 To tblObat.Rows.Count - 1
                    cmbJenisObat.Items.Add("" & .Table.Rows(a).Item(0) & " - " & .Table.Rows(a).Item(1) & "")
                Next a
            End With
        End If
    End Sub

    Sub Kode_Otomatis()
        tblObat = Proses.ExecuteQuery("Select * From tblObat order by Kode_Obat desc")
        If tblObat.Rows.Count = 0 Then
            txtKodeObat.Text = "KO-001"
        Else
            With tblObat.Rows(0)
                txtKodeObat.Text = .Item("Kode_Obat")
                txtKodeObat.Focus()
            End With
            txtKodeObat.Text = Val(Microsoft.VisualBasic.Mid(txtKodeObat.Text, 4, 3)) + 1
            If Len(txtKodeObat.Text) = 1 Then
                txtKodeObat.Text = "KO-00" & txtKodeObat.Text & ""
            ElseIf Len(txtKodeObat.Text) = 2 Then
                txtKodeObat.Text = "KO-0" & txtKodeObat.Text & ""
            ElseIf Len(txtKodeObat.Text) = 3 Then
                txtKodeObat.Text = "KO-" & txtKodeObat.Text & ""
            End If
        End If
    End Sub

    Sub Bersih()
        txtKodeObat.Enabled = False
        txtNamaObat.Text = ""
        cmbJenisObat.Text = ""
        txtHarga.Text = ""
        txtStock.Text = ""
        txtNamaObat.Focus()
        Call Kode_Otomatis()
        Call Data_Record()
        Call Jenis_Obat()
        BtnSimpan.Enabled = True
        BtnUbah.Enabled = False
        BtnHapus.Enabled = False
    End Sub

    Private Sub FrmObat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Top = 0
        Me.Left = 0
        Call Bersih()
    End Sub

    Private Sub txtHarga_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHarga.KeyPress
        Select Case e.KeyChar
            Case Chr(47) To Chr(57)
                txtHarga.Focus()
            Case Chr(8)
                e.KeyChar = Chr(8)
            Case Else
                e.KeyChar = Chr(0)
        End Select
    End Sub

    Private Sub txtCariData_TextChanged(sender As Object, e As EventArgs) Handles txtCariData.TextChanged
        If CariKdObat.Checked = True Then
            tblObat = Proses.ExecuteQuery("Select * From vw_obat where Kode_Obat Like '%" & txtCariData.Text & "%'")
            If tblObat.Rows.Count = 0 Then
                DGObat.DataSource = tblObat
                txtCariData.Focus()
            Else
                DGObat.DataSource = tblObat
            End If
        ElseIf CariNmObat.Checked = True Then
            tblObat = Proses.ExecuteQuery("Select * From vw_obat where Nama_Obat Like '%" & txtCariData.Text & "%'")
            If tblObat.Rows.Count = 0 Then
                DGObat.DataSource = tblObat
                txtCariData.Focus()
            Else
                DGObat.DataSource = tblObat
            End If
        End If
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        If txtNamaObat.Text = "" Then
            txtNamaObat.Focus()
            Exit Sub
        End If
        If cmbJenisObat.Text = "" Then
            cmbJenisObat.Focus()
            Exit Sub
        End If
        If txtHarga.Text = "" Then
            txtHarga.Focus()
            Exit Sub
        End If
        SQL = "Insert Into tblObat values ('" & txtKodeObat.Text & "','" & txtNamaObat.Text & "','" & Val(cmbJenisObat.Text) & "','" & txtStock.Text & "','" & txtHarga.Text & "')"
        Proses.ExecuteNonQuery(SQL)
        MessageBox.Show("Data Baru telah disimpan..!!", "Penyimpanan Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Call Bersih()
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles BtnUbah.Click
        If txtNamaObat.Text = "" Then
            txtNamaObat.Focus()
            Exit Sub
        End If
        If txtStock.Text = "" Then
            txtStock.Focus()
            Exit Sub
        End If
        If txtHarga.Text = "" Then
            txtHarga.Focus()
            Exit Sub
        End If
        SQL = "Update tblObat set nama_obat = '" & txtNamaObat.Text & "',Stock = '" & txtStock.Text & "',Harga = '" & txtHarga.Text & "' Where Kode_Obat = '" & txtKodeObat.Text & "'"
        Proses.ExecuteNonQuery(SQL)
        MessageBox.Show("Data Berhasil dirubah..!!", "Perubahan Data Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Call Bersih()
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles BtnBatal.Click
        Call Bersih()
        txtKodeObat.Focus()
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        SQL = "Delete From tblObat Where Kode_Obat = '" & txtKodeObat.Text & "'"
        Proses.ExecuteNonQuery(SQL)
        MessageBox.Show("Data telah dihapus..!!", "Penghapusan Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Call Bersih()
    End Sub

    Private Sub btnTutup_Click(sender As Object, e As EventArgs) Handles BtnTutup.Click
        Me.Close()
    End Sub

    Private Sub DGObat_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGObat.CellClick
        Dim i As Integer
        With DGObat
            If e.RowIndex >= 0 Then
                i = .CurrentRow.Index
                txtKodeObat.Text = .Rows(i).Cells("Kode_Obat").Value.ToString
                txtNamaObat.Text = .Rows(i).Cells("Nama_Obat").Value.ToString
                cmbJenisObat.Text = .Rows(i).Cells("Jenis").Value.ToString
                txtStock.Text = .Rows(i).Cells("Stock").Value.ToString
                txtHarga.Text = .Rows(i).Cells("Harga").Value.ToString
                BtnUbah.Enabled = True
                BtnHapus.Enabled = True
                BtnSimpan.Enabled = False
            End If
        End With
    End Sub
End Class
