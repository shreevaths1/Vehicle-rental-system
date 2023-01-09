Public Class User
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Login.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        UserViewVehicles.Show()
        Me.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Feedback_Form.Show()
        Me.Close()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Transact_History.Show()
        Me.Close()
    End Sub
End Class