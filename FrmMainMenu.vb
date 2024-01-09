Public Class FrmMainMenu
    Dim SQL As String
    Dim Proses As New ClsKoneksi
    Dim tblHakAkses As DataTable

    Sub Hak_Akses()
        tblHakAkses = Proses.ExecuteQuery("SELECT * FROM TblHakAkses WHERE role = '" & TsRole.Text & "'")
        If tblHakAkses.Rows.Count = 0 Then
            UserToolStripMenuItem.Enabled = False
            HakAksesToolStripMenuItem.Enabled = False
            JenisObatToolStripMenuItem.Enabled = False
            DataObatToolStripMenuItem.Enabled = False
            PenjualanToolStripMenuItem.Enabled = False
            LprObatToolStripMenuItem1.Enabled = False
            LprPenjualanToolStripMenuItem1.Enabled = False
        Else
            With tblHakAkses.Rows(0)
                UserToolStripMenuItem.Enabled = .Item("User")
                HakAksesToolStripMenuItem.Enabled = .Item("HakAkses")
                JenisObatToolStripMenuItem.Enabled = .Item("JenisObat")
                DataObatToolStripMenuItem.Enabled = .Item("DataObat")
                PenjualanToolStripMenuItem.Enabled = .Item("Transaksi")
                LprObatToolStripMenuItem1.Enabled = .Item("LaporanObat")
                LprPenjualanToolStripMenuItem1.Enabled = .Item("LaporanPenjualan")
            End With
        End If
    End Sub
    Private Sub UserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UserToolStripMenuItem.Click
        FrmUser.MdiParent = Me
        FrmUser.Show()
    End Sub

    Private Sub JenisObatToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JenisObatToolStripMenuItem.Click
        FrmJenisObat.MdiParent = Me
        FrmJenisObat.Show()
    End Sub

    Private Sub DataObatToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataObatToolStripMenuItem.Click
        FrmObat.MdiParent = Me
        FrmObat.Show()
    End Sub

    Private Sub LprObatToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LprObatToolStripMenuItem1.Click
        FrmLprDataObat.CrystalReportViewer1.Refresh()
        FrmLprDataObat.Show()
    End Sub

    Private Sub PenjualanToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LprPenjualanToolStripMenuItem1.Click
        FrmLprPenjualan.CrystalReportViewer1.Refresh()
        FrmLprPenjualan.Show()
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        Me.Close()
        FrmLogin.Show()
    End Sub

    Private Sub PenjualanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PenjualanToolStripMenuItem.Click
        FrmPenjualan.MdiParent = Me
        FrmPenjualan.Show()
    End Sub

    Private Sub HakAksesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HakAksesToolStripMenuItem.Click
        FrmHakAkses.Show()
    End Sub

    Private Sub FrmMainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Hak_Akses()
        TsTanggal.Text = Format(Now, "dddd, dd/MM/yyyy")
    End Sub
End Class