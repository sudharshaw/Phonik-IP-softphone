Public Class CallLog

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub ButtonCalllogclose_Click(sender As Object, e As EventArgs) Handles ButtonCalllogclose.Click
        Me.Close()

    End Sub

    Private Sub ButtonCalllogcontacts_Click(sender As Object, e As EventArgs) Handles ButtonCalllogcontacts.Click
        FormContact.Visible = True

    End Sub

    Private Sub ComboBoxCalllogstatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxCalllogstatus.SelectedIndexChanged
      
    End Sub
End Class