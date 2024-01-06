Public Class FrmPenjualan
    Dim SQL As String
    Dim Proses As New ClsKoneksi
    Dim tblJual As DataTable

    Sub Data_Record()
        tblJual = Proses.ExecuteQuery("Select * From vw_penjualan order by Faktur_Penjualan asc")
        DGPenjualan.DataSource = tblJual
        DGPenjualan.Columns(1).Width = 250
        DGPenjualan.Columns(2).Width = 200
    End Sub

    Sub Obat()
        tblJual = Proses.ExecuteQuery("Select * From TblObat order by Kode_Obat asc")
        If tblJual.Rows.Count = 0 Then
        Else
            CBObat.Items.Clear()
            With tblJual.Columns(1)
                For a = 0 To tblJual.Rows.Count - 1
                    CBObat.Items.Add("" & .Table.Rows(a).Item(0) & " - " & .Table.Rows(a).Item(1) & "")
                Next a
            End With
        End If
    End Sub

    Sub Faktur_Otomatis()
        tblJual = Proses.ExecuteQuery("Select * From TblPenjualan order by faktur_Penjualan desc")
        If tblJual.Rows.Count = 0 Then
            LblFaktur.Text = "0001"
        Else
            With tblJual.Rows(0)
                LblFaktur.Text = .Item("faktur_Penjualan")
            End With
            LblFaktur.Text = Val(LblFaktur.Text) + 1
            If Len(LblFaktur.Text) = 1 Then
                LblFaktur.Text = "000" & LblFaktur.Text & ""

            ElseIf Len(LblFaktur.Text) = 2 Then
                LblFaktur.Text = "00" & LblFaktur.Text & ""
            ElseIf Len(LblFaktur.Text) = 3 Then
                LblFaktur.Text = "0" & LblFaktur.Text & ""
            ElseIf Len(LblFaktur.Text) = 4 Then
                LblFaktur.Text = "" & LblFaktur.Text & ""
            End If
        End If
    End Sub

    Sub Bersih()
        CBObat.Text = ""
        lblHarga.Text = ""
        txtJumlah.Text = ""
        txtJumlah.Text = ""
        LblTotalHarga.Text = ""
        CBObat.Enabled = True
        BtnHapus.Enabled = False
        CBObat.Focus()
        Call Obat()
        Call Faktur_Otomatis()
        Call Data_Record()

        On Error Resume Next
        Dim Total_Seluruh As Single
        Dim i As Integer
        If DGPenjualan.RowCount > 1 Then
            i = DGPenjualan.CurrentRow.Index
            For i = 0 To DGPenjualan.Rows.Count - 1
                Total_Seluruh = Val(Total_Seluruh) + Val(DGPenjualan.Item(5, i).Value)
            Next
            LblTotalHarga.Text = Total_Seluruh.ToString("#,#")
        End If
    End Sub
    Private Sub FrmPenjualan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Bersih()
    End Sub

    Private Sub CBObat_TextChanged(sender As Object, e As EventArgs) Handles CBObat.TextChanged
        tblJual = Proses.ExecuteQuery("Select * From TblObat where Kode_Obat ='" & Mid(CBObat.Text, 1, 6) & "'")
        If tblJual.Rows.Count = 0 Then
        Else
            lblHarga.Text = tblJual.Rows(0).Item("Harga")
            txtJumlah.Focus()
            txtJumlah.Text = 1
            LblTotalHarga.Text = Val(lblHarga.Text) * Val(txtJumlah.Text)
        End If
    End Sub

    Private Sub TxtJumlah_TextChanged(sender As Object, e As EventArgs) Handles txtJumlah.TextChanged
        ' Your code here
        ' For example, if you want to update LblTotalHarga based on the content of txtJumlah and lblHarga
        If IsNumeric(txtJumlah.Text) And IsNumeric(lblHarga.Text) Then
            LblTotalHarga.Text = Val(lblHarga.Text) * Val(txtJumlah.Text)
        Else
            ' Handle the case where the input is not numeric
            LblTotalHarga.Text = "Invalid input"
        End If
    End Sub

    Private Sub TxtJumlah_KeyDown(sender As Object, e As KeyEventArgs) Handles txtJumlah.KeyDown
        If e.KeyCode = Keys.Enter Then
            ' Your code here
            SQL = "Insert Into TblPenjualan values ('" & LblFaktur.Text & "','" & DateTimePenjualan.Text & "','" & Mid(CBObat.Text, 1, 6) & "','" & txtJumlah.Text & "','" & LblTotalHarga.Text & "')"
            Proses.ExecuteNonQuery(SQL)
            MessageBox.Show("Data Baru telah disimpan..!!", "Penyimpanan Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call Bersih()
            CBObat.Text = ""
            txtJumlah.Text = ""
            CBObat.Focus()
        End If
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        SQL = "Delete From TblPenjualan Where Faktur_Penjualan = '" & LblFaktur.Text & "'"
        Proses.ExecuteNonQuery(SQL)
        MessageBox.Show("Data telah dihapus..!!", "Penghapusan Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Call Bersih()
    End Sub

    Private Sub BtnTutup_Click(sender As Object, e As EventArgs) Handles BtnTutup.Click
        Me.Close()
    End Sub

    Private Sub DGPenjualan_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGPenjualan.CellClick
        Dim i As Integer
        With DGPenjualan
            If e.RowIndex >= 0 Then
                i = .CurrentRow.Index
                LblFaktur.Text = .Rows(i).Cells("Faktur_Penjualan").Value.ToString
                BtnHapus.Enabled = True
            End If
        End With
    End Sub

    Private Sub BtnBatal_Click(sender As Object, e As EventArgs) Handles BtnBatal.Click
        Call Bersih()
        CBObat.Focus()
    End Sub
End Class