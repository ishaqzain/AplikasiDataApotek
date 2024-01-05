Public Class FrmJenisObat
    Dim SQL As String
    Dim Proses As New ClsKoneksi
    Dim tblJenisObat As DataTable

    Sub Data_Record()
        tblJenisObat = Proses.ExecuteQuery("Select * From TblJenisObat order by no asc")
        DGJenisObat.DataSource = tblJenisObat
        DGJenisObat.Columns(1).Width = 130
    End Sub
    Sub Kode_Otomatis()
        tblJenisObat = Proses.ExecuteQuery("Select * From TblJenisObat order by No desc")
        If tblJenisObat.Rows.Count = 0 Then
            txtKodeJenis.Text = "1"
        Else
            With tblJenisObat.Rows(0)
                txtKodeJenis.Text = .Item("No")
            End With
            txtKodeJenis.Text = Val(txtKodeJenis.Text) + 1
        End If
    End Sub

    Sub Bersih()
        Call Kode_Otomatis()
        Call Data_Record()
        BtnSimpan.Enabled = True
        BtnUbah.Enabled = False
        BtnHapus.Enabled = False
        txtKodeJenis.Enabled = False
        txtJenisObat.Text = ""
        txtJenisObat.Focus()
    End Sub

    Private Sub FrmJenisObat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Bersih()
    End Sub

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        If txtJenisObat.Text = "" Then
            txtJenisObat.Focus()
            Exit Sub
        End If
        SQL = "Insert Into TblJenisObat values ('" & txtKodeJenis.Text & "','" & txtJenisObat.Text & "')"
        Proses.ExecuteNonQuery(SQL)
        MessageBox.Show("Data Baru telah disimpan..!!", "Penyimpanan Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Call Bersih()
    End Sub

    Private Sub BtnUbah_Click(sender As Object, e As EventArgs) Handles BtnUbah.Click
        If txtJenisObat.Text = "" Then
            txtJenisObat.Focus()
            Exit Sub
        End If
        SQL = "Update TblJenisObat set Jenis = '" & txtJenisObat.Text & "' Where No = '" & txtKodeJenis.Text & "'"
        Proses.ExecuteNonQuery(SQL)
        MessageBox.Show("Data berhasil diubah..!!", "Perubahan Data Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Call Bersih()
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        SQL = "Delete from TblJenisObat Where No = '" & txtKodeJenis.Text & "'"
        Proses.ExecuteNonQuery(SQL)
        MessageBox.Show("Data berhasil dihapus..!!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Call Bersih()
    End Sub

    Private Sub DGJenisObat_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGJenisObat.CellClick, DGJenisObat.CellClick
        Dim i As Integer
        With DGJenisObat
            If e.RowIndex >= 0 Then
                i = .CurrentRow.Index
                txtKodeJenis.Text = .Rows(i).Cells("No").Value.ToString
                txtJenisObat.Text = .Rows(i).Cells("Jenis").Value.ToString
                BtnUbah.Enabled = True
                BtnHapus.Enabled = True
                BtnSimpan.Enabled = False
            End If
        End With
    End Sub

    Private Sub BtnBatal_Click(sender As Object, e As EventArgs) Handles BtnBatal.Click
        Call Bersih()
        txtJenisObat.Focus()
    End Sub

    Private Sub BtnTutup_Click(sender As Object, e As EventArgs) Handles BtnTutup.Click
        Me.Close()
    End Sub

End Class