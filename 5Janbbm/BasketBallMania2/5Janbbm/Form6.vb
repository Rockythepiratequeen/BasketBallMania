Public Class Form6


    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim UsersName As String
        Dim score As String
        UsersName = My.Settings.Username
        UsersScorelbl.Text = ("Hello, " + UsersName + " your score is: " + Score)
    End Sub
    Private Sub HighScorelbl_Click(sender As Object, e As EventArgs) Handles HighScorelbl.Click

    End Sub

End Class