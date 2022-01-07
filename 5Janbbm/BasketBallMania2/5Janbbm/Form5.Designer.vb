<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SignUpbtn = New System.Windows.Forms.Button()
        Me.LogInbtn = New System.Windows.Forms.Button()
        Me.SignUpUsername = New System.Windows.Forms.TextBox()
        Me.LogInUsername = New System.Windows.Forms.TextBox()
        Me.SignUpPassword = New System.Windows.Forms.TextBox()
        Me.LogInPassword = New System.Windows.Forms.TextBox()
        Me.SignUpConfirm = New System.Windows.Forms.Button()
        Me.LogInConfirm = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(368, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Game over"
        '
        'SignUpbtn
        '
        Me.SignUpbtn.Location = New System.Drawing.Point(173, 78)
        Me.SignUpbtn.Name = "SignUpbtn"
        Me.SignUpbtn.Size = New System.Drawing.Size(75, 23)
        Me.SignUpbtn.TabIndex = 1
        Me.SignUpbtn.Text = "Sign Up"
        Me.SignUpbtn.UseVisualStyleBackColor = True
        '
        'LogInbtn
        '
        Me.LogInbtn.Location = New System.Drawing.Point(500, 78)
        Me.LogInbtn.Name = "LogInbtn"
        Me.LogInbtn.Size = New System.Drawing.Size(75, 23)
        Me.LogInbtn.TabIndex = 2
        Me.LogInbtn.Text = "Log in"
        Me.LogInbtn.UseVisualStyleBackColor = True
        '
        'SignUpUsername
        '
        Me.SignUpUsername.Location = New System.Drawing.Point(155, 135)
        Me.SignUpUsername.Name = "SignUpUsername"
        Me.SignUpUsername.Size = New System.Drawing.Size(129, 23)
        Me.SignUpUsername.TabIndex = 3
        Me.SignUpUsername.Text = "Username"
        '
        'LogInUsername
        '
        Me.LogInUsername.Location = New System.Drawing.Point(475, 135)
        Me.LogInUsername.Name = "LogInUsername"
        Me.LogInUsername.Size = New System.Drawing.Size(129, 23)
        Me.LogInUsername.TabIndex = 4
        Me.LogInUsername.Text = "Username"
        '
        'SignUpPassword
        '
        Me.SignUpPassword.Location = New System.Drawing.Point(155, 198)
        Me.SignUpPassword.Name = "SignUpPassword"
        Me.SignUpPassword.Size = New System.Drawing.Size(129, 23)
        Me.SignUpPassword.TabIndex = 5
        Me.SignUpPassword.Text = "Password"
        '
        'LogInPassword
        '
        Me.LogInPassword.Location = New System.Drawing.Point(475, 198)
        Me.LogInPassword.Name = "LogInPassword"
        Me.LogInPassword.Size = New System.Drawing.Size(129, 23)
        Me.LogInPassword.TabIndex = 6
        Me.LogInPassword.Text = "Password"
        '
        'SignUpConfirm
        '
        Me.SignUpConfirm.Location = New System.Drawing.Point(156, 249)
        Me.SignUpConfirm.Name = "SignUpConfirm"
        Me.SignUpConfirm.Size = New System.Drawing.Size(128, 23)
        Me.SignUpConfirm.TabIndex = 7
        Me.SignUpConfirm.Text = "Click to Sign Up"
        Me.SignUpConfirm.UseVisualStyleBackColor = True
        '
        'LogInConfirm
        '
        Me.LogInConfirm.Location = New System.Drawing.Point(475, 249)
        Me.LogInConfirm.Name = "LogInConfirm"
        Me.LogInConfirm.Size = New System.Drawing.Size(128, 23)
        Me.LogInConfirm.TabIndex = 8
        Me.LogInConfirm.Text = "Click to Log In"
        Me.LogInConfirm.UseVisualStyleBackColor = True
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global._5Janbbm.My.Resources.Resources.Basketball_background_gameover
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LogInConfirm)
        Me.Controls.Add(Me.SignUpConfirm)
        Me.Controls.Add(Me.LogInPassword)
        Me.Controls.Add(Me.SignUpPassword)
        Me.Controls.Add(Me.LogInUsername)
        Me.Controls.Add(Me.SignUpUsername)
        Me.Controls.Add(Me.LogInbtn)
        Me.Controls.Add(Me.SignUpbtn)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form5"
        Me.Text = "Form5"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents SignUpbtn As Button
    Friend WithEvents LogInbtn As Button
    Friend WithEvents SignUpUsername As TextBox
    Friend WithEvents LogInUsername As TextBox
    Friend WithEvents SignUpPassword As TextBox
    Friend WithEvents LogInPassword As TextBox
    Friend WithEvents SignUpConfirm As Button
    Friend WithEvents LogInConfirm As Button
End Class
