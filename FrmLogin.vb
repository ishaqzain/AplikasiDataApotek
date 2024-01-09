Public Class FrmLogin

    Dim SQL As String
    Dim Proses As New ClsKoneksi
    Dim tblUser As DataTable

    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles BtnOk.Click
        Dim enteredUsername As String = TxtUsername.Text
        Dim enteredPassword As String = TxtPassword.Text

        If ValidateUser(enteredUsername, enteredPassword) Then
            ' Successful login
            MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Hide the login form and show the main menu form
            Me.Hide()
            FrmMainMenu.TsUser.Text = TxtUsername.Text
            FrmMainMenu.Show()

        Else
            ' Failed login
            MessageBox.Show("Invalid username, password, or role. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Function ValidateUser(username As String, password As String) As Boolean
        SQL = "SELECT * FROM TblUser WHERE Username = '" & username & "' AND Password = '" & password & "'"
        tblUser = Proses.ExecuteQuery(SQL)

        If tblUser.Rows.Count > 0 Then
            ' User is valid
            FrmMainMenu.TsRole.Text = tblUser.Rows(0).Item("Role")
            Return True

        Else
            ' User is invalid
            Return False
        End If
    End Function

    Private Sub TxtRole_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub BtnBatal_Click(sender As Object, e As EventArgs) Handles BtnBatal.Click
        Me.Close()
    End Sub

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
