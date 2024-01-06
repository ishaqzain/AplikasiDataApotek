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

    Private Sub TransaksiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransaksiToolStripMenuItem.Click
        FrmPenjualan.MdiParent = Me
        FrmPenjualan.Show()
    End Sub
End Class