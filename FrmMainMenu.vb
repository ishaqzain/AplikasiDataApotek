Public Class FrmMainMenu
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
        FrmLprDataObat.MdiParent = Me
        FrmLprDataObat.Show()
    End Sub

    Private Sub PenjualanToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PenjualanToolStripMenuItem1.Click
        FrmLprPenjualan.MdiParent = Me
        FrmLprPenjualan.Show()
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        Me.Hide()
        FrmLogin.Show()
    End Sub

    Private Sub PenjualanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PenjualanToolStripMenuItem.Click
        FrmPenjualan.MdiParent = Me
        FrmPenjualan.Show()
    End Sub
End Class