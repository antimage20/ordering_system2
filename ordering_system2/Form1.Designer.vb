<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.btn_login = New System.Windows.Forms.Button()
        Me.txt_password = New System.Windows.Forms.TextBox()
        Me.txt_username = New System.Windows.Forms.TextBox()
        Me.lbl_password = New System.Windows.Forms.Label()
        Me.lbl_username = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbx_showpassword = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'btn_exit
        '
        Me.btn_exit.Location = New System.Drawing.Point(159, 261)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(92, 30)
        Me.btn_exit.TabIndex = 20
        Me.btn_exit.Text = "Exit"
        Me.btn_exit.UseVisualStyleBackColor = True
        '
        'btn_login
        '
        Me.btn_login.Location = New System.Drawing.Point(59, 261)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(94, 30)
        Me.btn_login.TabIndex = 19
        Me.btn_login.Text = "Login"
        Me.btn_login.UseVisualStyleBackColor = True
        '
        'txt_password
        '
        Me.txt_password.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_password.Location = New System.Drawing.Point(59, 189)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.Size = New System.Drawing.Size(192, 22)
        Me.txt_password.TabIndex = 18
        Me.txt_password.UseSystemPasswordChar = True
        '
        'txt_username
        '
        Me.txt_username.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_username.Location = New System.Drawing.Point(59, 135)
        Me.txt_username.Name = "txt_username"
        Me.txt_username.Size = New System.Drawing.Size(192, 22)
        Me.txt_username.TabIndex = 17
        '
        'lbl_password
        '
        Me.lbl_password.AutoSize = True
        Me.lbl_password.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_password.Location = New System.Drawing.Point(77, 170)
        Me.lbl_password.Name = "lbl_password"
        Me.lbl_password.Size = New System.Drawing.Size(72, 16)
        Me.lbl_password.TabIndex = 16
        Me.lbl_password.Text = "Password:"
        '
        'lbl_username
        '
        Me.lbl_username.AutoSize = True
        Me.lbl_username.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_username.Location = New System.Drawing.Point(77, 116)
        Me.lbl_username.Name = "lbl_username"
        Me.lbl_username.Size = New System.Drawing.Size(76, 16)
        Me.lbl_username.TabIndex = 15
        Me.lbl_username.Text = "Username:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(122, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 25)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Login"
        '
        'cbx_showpassword
        '
        Me.cbx_showpassword.AutoSize = True
        Me.cbx_showpassword.Location = New System.Drawing.Point(150, 217)
        Me.cbx_showpassword.Name = "cbx_showpassword"
        Me.cbx_showpassword.Size = New System.Drawing.Size(101, 17)
        Me.cbx_showpassword.TabIndex = 21
        Me.cbx_showpassword.Text = "Show password"
        Me.cbx_showpassword.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(311, 362)
        Me.Controls.Add(Me.cbx_showpassword)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.btn_login)
        Me.Controls.Add(Me.txt_password)
        Me.Controls.Add(Me.txt_username)
        Me.Controls.Add(Me.lbl_password)
        Me.Controls.Add(Me.lbl_username)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_exit As System.Windows.Forms.Button
    Friend WithEvents btn_login As System.Windows.Forms.Button
    Friend WithEvents txt_password As System.Windows.Forms.TextBox
    Friend WithEvents txt_username As System.Windows.Forms.TextBox
    Friend WithEvents lbl_password As System.Windows.Forms.Label
    Friend WithEvents lbl_username As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbx_showpassword As System.Windows.Forms.CheckBox

End Class
