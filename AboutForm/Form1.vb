Public Class Form1

    Private Sub BtnShow_Click(sender As Object, e As EventArgs) Handles BtnShow.Click
        MainForm.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        formBox.Show()
    End Sub

    Private Sub Btnversion_Click(sender As Object, e As EventArgs) Handles Btnversion.Click
        formBox.Show()
    End Sub

    Private Sub Btnexit_Click(sender As Object, e As EventArgs) Handles Btnexit.Click
        Application.Exit()
    End Sub
End Class
