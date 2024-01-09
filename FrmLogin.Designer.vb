<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BtnBatal = New System.Windows.Forms.Button()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.TxtRole = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnOk = New System.Windows.Forms.Button()
        Me.TxtUsername = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnBatal
        '
        Me.BtnBatal.Location = New System.Drawing.Point(220, 185)
        Me.BtnBatal.Name = "BtnBatal"
        Me.BtnBatal.Size = New System.Drawing.Size(111, 34)
        Me.BtnBatal.TabIndex = 15
        Me.BtnBatal.Text = "Batal"
        Me.BtnBatal.UseVisualStyleBackColor = True
        '
        'TxtPassword
        '
        Me.TxtPassword.Location = New System.Drawing.Point(196, 80)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPassword.Size = New System.Drawing.Size(252, 31)
        Me.TxtPassword.TabIndex = 14
        '
        'TxtRole
        '
        Me.TxtRole.Location = New System.Drawing.Point(196, 123)
        Me.TxtRole.Name = "TxtRole"
        Me.TxtRole.Size = New System.Drawing.Size(252, 31)
        Me.TxtRole.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 25)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Role"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 25)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Password"
        '
        'BtnOk
        '
        Me.BtnOk.Location = New System.Drawing.Point(337, 185)
        Me.BtnOk.Name = "BtnOk"
        Me.BtnOk.Size = New System.Drawing.Size(111, 34)
        Me.BtnOk.TabIndex = 10
        Me.BtnOk.Text = "OK"
        Me.BtnOk.UseVisualStyleBackColor = True
        '
        'TxtUsername
        '
        Me.TxtUsername.Location = New System.Drawing.Point(196, 37)
        Me.TxtUsername.Name = "TxtUsername"
        Me.TxtUsername.Size = New System.Drawing.Size(252, 31)
        Me.TxtUsername.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 25)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Username"
        '
        'FrmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(490, 259)
        Me.Controls.Add(Me.BtnBatal)
        Me.Controls.Add(Me.TxtPassword)
        Me.Controls.Add(Me.TxtRole)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnOk)
        Me.Controls.Add(Me.TxtUsername)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmLogin"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnBatal As Button
    Friend WithEvents TxtPassword As TextBox
    Friend WithEvents TxtRole As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnOk As Button
    Friend WithEvents TxtUsername As TextBox
    Friend WithEvents Label1 As Label
End Class
