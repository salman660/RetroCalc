Public Class Settings
    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CuteCalc_Click(sender As Object, e As EventArgs) Handles CuteCalc.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub OpenSourceCode_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Dim githubUrl As String = "https://github.com" ' Replace with your GitHub URL
        Process.Start(githubUrl)
    End Sub

    Private Sub OpenSourceCode_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles OpenSourceCode.LinkClicked
        Dim githubUrl As String = "https://github.com" ' Replace with your GitHub URL
        Process.Start(githubUrl)
    End Sub

    Private Sub ReadMore_Click(sender As Object, e As EventArgs) Handles ReadMore.Click
        Dim aboutbox As New AboutBox1()
        aboutbox.Show()
    End Sub

End Class