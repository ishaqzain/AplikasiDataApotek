Public Class FrmHakAkses
    Dim SQL As String
    Dim Proses As New ClsKoneksi
    Dim tblHakAkses As DataTable

    Sub kosong()
        ChkUser.Checked = False
        ChkAkses.Checked = False
        ChkJenis.Checked = False
        ChkObt.Checked = False
        ChkPenjualan.Checked = False
        ChkLprObat.Checked = False
        ChkLprJual.Checked = False
    End Sub

    Sub Hak_Akses()
        tblHakAkses = Proses.ExecuteQuery("Select * From TblHakAkses Where Role ='" & CmbRole.Text & "'")
        If tblHakAkses.Rows.Count = 0 Then
            Call kosong()
        Else
            With tblHakAkses.Rows(0)
                ChkUser.Checked = Convert.ToBoolean(.Item("User"))
                ChkAkses.Checked = Convert.ToBoolean(.Item("HakAkses"))
                ChkJenis.Checked = Convert.ToBoolean(.Item("JenisObat"))
                ChkObt.Checked = Convert.ToBoolean(.Item("DataObat"))
                ChkPenjualan.Checked = Convert.ToBoolean(.Item("Transaksi"))
                ChkLprObat.Checked = Convert.ToBoolean(.Item("LaporanObat"))
                ChkLprJual.Checked = Convert.ToBoolean(.Item("LaporanPenjualan"))
            End With
        End If
    End Sub

    Private Sub FrmHakAkses_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Call Hak_Akses()
    End Sub

    Private Sub FrmHakAkses_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CmbRole.Items.Add("ADMIN")
        CmbRole.Items.Add("OPERATOR")
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If CmbRole.Text = "" Then Exit Sub

        tblHakAkses = Proses.ExecuteQuery("Select * From TblHakAkses Where Role ='" & CmbRole.Text & "'")
        If tblHakAkses.Rows.Count = 0 Then
            SQL = "Insert Into TblHakAkses Values ('" & CmbRole.Text & "','" &
            Convert.ToInt32(ChkUser.Checked) & "','" &
            Convert.ToInt32(ChkJenis.Checked) & "','" &
            Convert.ToInt32(ChkAkses.Checked) & "','" &
            Convert.ToInt32(ChkObt.Checked) & "','" &
            Convert.ToInt32(ChkPenjualan.Checked) & "','" &
            Convert.ToInt32(ChkLprObat.Checked) & "','" &
            Convert.ToInt32(ChkLprJual.Checked) & "')"
            Proses.ExecuteNonQuery(SQL)
            MessageBox.Show("Data Baru telah disimpan..!!", "Penyimpanan Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            SQL = "Update TblHakAkses Set [User] = '" & Convert.ToInt32(ChkUser.Checked) & "',HakAkses = '" &
            Convert.ToInt32(ChkAkses.Checked) & "',JenisObat = '" &
            Convert.ToInt32(ChkJenis.Checked) & "',DataObat = '" &
            Convert.ToInt32(ChkObt.Checked) & "', Transaksi = '" &
            Convert.ToInt32(ChkPenjualan.Checked) & "',LaporanObat= '" &
            Convert.ToInt32(ChkLprObat.Checked) & "',LaporanPenjualan = '" &
            Convert.ToInt32(ChkLprJual.Checked) & "' where Role = '" & CmbRole.Text & "' "
            Proses.ExecuteNonQuery(SQL)
            MessageBox.Show("Data telah diubah..!!", "Penyimpanan Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub CmbRole_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbRole.TextChanged
        Call Hak_Akses()
    End Sub
End Class
