Public Class FormDialpad

    Private Sub ButtonDialClose_Click(sender As Object, e As EventArgs) Handles ButtonDialClose.Click
        Me.Close()

    End Sub

    Private Sub ButtonDialcontact_Click(sender As Object, e As EventArgs) Handles ButtonDialcontact.Click
        FormContact.Visible = True

    End Sub
End Class