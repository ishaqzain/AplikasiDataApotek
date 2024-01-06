Public Class FrmUser
    Dim SQL As String
    Dim Proses As New ClsKoneksi
    Dim tblUser As DataTable

    Sub Data_Record()
        tblUser = Proses.ExecuteQuery("Select * From TblUser")
        DgPengguna.DataSource = tblUser
        DgPengguna.Columns(1).Width = 200
        DgPengguna.Columns(2).Visible = False
    End Sub

    Sub Kode_Otomatis()
        tblUser = Proses.ExecuteQuery("Select * From TblUser order by User_Id desc")
        If tblUser.Rows.Count = 0 Then
            TxtKdPengguna.Text = "USR-001"
        Else
            With tblUser.Rows(0)
                TxtKdPengguna.Text = .Item("User_Id")
                TxtKdPengguna.Focus()
            End With
            TxtKdPengguna.Text = Val(Microsoft.VisualBasic.Mid(TxtKdPengguna.Text, 5, 3)) + 1
            If Len(TxtKdPengguna.Text) = 1 Then
                TxtKdPengguna.Text = "USR-00" & TxtKdPengguna.Text & ""

            ElseIf Len(TxtKdPengguna.Text) = 2 Then
                TxtKdPengguna.Text = "USR-0" & TxtKdPengguna.Text & ""
            ElseIf Len(TxtKdPengguna.Text) = 3 Then
                TxtKdPengguna.Text = "USR-" & TxtKdPengguna.Text & ""
            End If
        End If
    End Sub

    Sub Bersih()
        TxtKdPengguna.Enabled = True
        TxtKdPengguna.Text = ""
        TxtNmPengguna.Text = ""
        Call Kode_Otomatis()
        Call Data_Record()
        BtnSimpan.Enabled = True
        BtnUbah.Enabled = False
        BtnHapus.Enabled = False
        BtnBatal.Enabled = False
        BtnTutup.Enabled = True
        TxtKdPengguna.Enabled = False
        TxtPassword.Enabled = True
        TxtUlangPassword.Enabled = True
        TxtPassword.Text = ""
        TxtUlangPassword.Text = ""
    End Sub

    Private Sub FrmUser_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Call Data_Record()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        If TxtNmPengguna.Text = "" Then
            TxtNmPengguna.Focus()
            Exit Sub
        End If
        If TxtPassword.Text = "" Then
            TxtPassword.Focus()
            Exit Sub
        End If
        If TxtUlangPassword.Text = "" Then
            TxtUlangPassword.Focus()
            Exit Sub
        End If
        If CboLevel.Text = "" Then
            CboLevel.Focus()
            Exit Sub
        End If
        If TxtPassword.Text <> TxtUlangPassword.Text Then
            MsgBox("Ulangi, password keliru!!!", MsgBoxStyle.Critical, "Password")
            TxtUlangPassword.Focus()
            Exit Sub
        Else
            SQL = "Insert Into TblUser values ('" & TxtKdPengguna.Text & "','" & TxtNmPengguna.Text & "','" & TxtPassword.Text & "','" & CboLevel.Text & "')"
            Proses.ExecuteNonQuery(SQL)
            MessageBox.Show("Data Baru telah disimpan..!!", "Penyimpanan Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call Bersih()
        End If
    End Sub

    Private Sub BtnUbah_Click(sender As Object, e As EventArgs) Handles BtnUbah.Click
        If TxtNmPengguna.Text = "" Then
            TxtNmPengguna.Focus()
            Exit Sub
        End If
        If CboLevel.Text = "" Then
            CboLevel.Focus()
            Exit Sub
        Else
            SQL = "Update TblUser Set Username = '" & TxtNmPengguna.Text & "',Role =  '" & CboLevel.Text & "' Where User_Id = '" & TxtKdPengguna.Text & "'"
            Proses.ExecuteNonQuery(SQL)
            MessageBox.Show("Data telah diubah..!!", "Perubahan Data Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call Bersih()
        End If

    End Sub

    Private Sub BtnBatal_Click(sender As Object, e As EventArgs) Handles BtnBatal.Click
        Call Bersih()
        TxtKdPengguna.Focus()
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        SQL = "Delete From TblUser Where User_Id = '" & TxtKdPengguna.Text & "'"
        Proses.ExecuteNonQuery(SQL)
        MessageBox.Show("Data telah dihapus..!!", "Penghapusan Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Call Bersih()
    End Sub

    Private Sub BtnTutup_Click(sender As Object, e As EventArgs) Handles BtnTutup.Click
        Me.Close()
    End Sub

    Private Sub BtnCari_Click(sender As Object, e As EventArgs) Handles BtnCari.Click
        TxtKdPengguna.Text = InputBox("Masukkan User Id !!!")
        If TxtKdPengguna.Text = "" Then
            Call Kode_Otomatis()
            TxtNmPengguna.Focus()
            Exit Sub
        End If

        tblUser = Proses.ExecuteQuery("Select * From TblUser Where User_Id = '" & TxtKdPengguna.Text & "'")
        If tblUser.Rows.Count = 0 Then
            MessageBox.Show("Data Pengguna Tidak Ditemukan..!!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TxtNmPengguna.Focus()
            Call Kode_Otomatis()
        Else
            With tblUser.Rows(0)
                TxtKdPengguna.Text = .Item("User_Id")
                TxtNmPengguna.Text = .Item("Username")
                TxtPassword.Text = .Item("Password")
                TxtPassword.Enabled = False
                TxtUlangPassword.Enabled = False
                CboLevel.Text = .Item("Role")
            End With
            BtnSimpan.Enabled = False
            BtnUbah.Enabled = True
            BtnHapus.Enabled = True
            BtnBatal.Enabled = True
        End If
    End Sub

    Private Sub DGPengguna_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgPengguna.CellClick
        Dim i As Integer

        With DgPengguna
            If e.RowIndex >= 0 Then
                i = .CurrentRow.Index

                TxtKdPengguna.Text = .Rows(i).Cells("User_Id").Value.ToString
                TxtNmPengguna.Text = .Rows(i).Cells("Username").Value.ToString

                BtnUbah.Enabled = True
                BtnHapus.Enabled = True
                BtnBatal.Enabled = True
                BtnSimpan.Enabled = False
            End If
        End With
    End Sub
    Private Sub FrmUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Left = 0
        Top = 0
        Call Bersih()
        CboLevel.Items.Add("ADMIN")
        CboLevel.Items.Add("OPERATOR")
    End Sub
End Class