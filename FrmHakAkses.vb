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
    Private Sub FrmHakAkses_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class