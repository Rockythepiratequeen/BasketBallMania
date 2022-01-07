Public Class Form5
    Dim a As Integer = 0
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        SignUpUsername.Visible = False
        SignUpPassword.Visible = False
        LogInUsername.Visible = False
        LogInPassword.Visible = False
        SignUpConfirm.Visible = False
        LogInConfirm.Visible = False
    End Sub

    Private Sub LogInbtn_Click(sender As Object, e As EventArgs) Handles LogInbtn.Click
        SignUpUsername.Visible = False
        SignUpPassword.Visible = False
        LogInUsername.Visible = True
        LogInPassword.Visible = True
        SignUpConfirm.Visible = False
        LogInConfirm.Visible = True
    End Sub

    Private Sub SignUpbtn_Click(sender As Object, e As EventArgs) Handles SignUpbtn.Click
        SignUpUsername.Visible = True
        SignUpPassword.Visible = True
        LogInUsername.Visible = False
        LogInPassword.Visible = False
        SignUpConfirm.Visible = True
        LogInConfirm.Visible = False
    End Sub

    Private Sub LogInConfirm_Click(sender As Object, e As EventArgs) Handles LogInConfirm.Click
        If LogInUsername.Text = My.Settings.Username Then
            a += 1
        End If
        If LogInPassword.Text = My.Settings.Password Then
            a = +1
        End If
        If a = 2 Then
            Dim HighScorePage As New Form6

            HighScorePage.Show()
            Me.Close()
        End If
    End Sub

    Private Sub SignUpConfirm_Click(sender As Object, e As EventArgs) Handles SignUpConfirm.Click

        If Not SignUpUsername.Text = "" Then
            a += 1
        End If
        If Not SignUpPassword.Text = "" Then
            a += 1
        End If
        If a = 2 Then
            My.Settings.Username = SignUpUsername.Text
            My.Settings.Password = SignUpPassword.Text
            My.Settings.Save()
        End If
    End Sub
End Class