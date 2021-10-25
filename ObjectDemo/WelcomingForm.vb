Public Class WelcomingForm

    Private Sub WelcomingForm_load(sender As Object, e As EventArgs) Handles Me.Load
        CenterToScreen()
    End Sub

    Private Sub loadObjectDemoButton_Click(sender As Object, e As EventArgs) Handles LoadObjectDemoButton.Click
        Hide()
        ObjectDemonstration.Show()
    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Close()
    End Sub

    Private Sub WelcomingForm_Click(sender As Object, e As EventArgs) Handles Me.Click
        WindowState = FormWindowState.Maximized
        BackColor = Color.Red
    End Sub

End Class
