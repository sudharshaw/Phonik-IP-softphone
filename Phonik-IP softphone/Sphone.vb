Imports MySql.Data.MySqlClient
Public Class Sphone
    Dim sqlcon As New MySqlConnection
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonAnswer.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles ButtonHold.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged


    End Sub


    Private Sub Button1_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub ButtonAbout_Click(sender As Object, e As EventArgs) Handles ButtonLogout.Click
        Me.Close()
        Login.Close()





    End Sub

    Private Sub ButtonLogout_Click(sender As Object, e As EventArgs) Handles ButtonIM.Click
        Me.Close()




    End Sub

    Private Sub ButtonContacts_Click(sender As Object, e As EventArgs) Handles ButtonCalllog.Click
        CallLog.Show()


    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItemBreak.Click

    End Sub

    Private Sub ToolStripMenuItem9_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem9.Click

    End Sub

    Private Sub ToolStripMenuItem7_Click(sender As Object, e As EventArgs)
        FormContact.Visible = True


    End Sub

    Private Sub TASKToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripMenuItem6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DASHBOARDToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub CALLBARGEToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TASKToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles TASKToolStripMenuItem.Click
        Tasks.Visible = True
    End Sub

    Private Sub Sphone_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sql As String
        Dim reader As MySqlDataReader
        Dim com As MySqlCommand

        sql = "SELECT * FROM user" ' sql query to query the database
        sqlcon.ConnectionString = "server=127.0.0.1; userid=root; password=passw0rd; database=phonikip"
        Try
            sqlcon.Open() ' connecting to the MySqL server
            com = New MySqlCommand(sql, sqlcon)
            reader = com.ExecuteReader
            While reader.Read
                TextBox1.Text = reader.GetString("user_name")
            End While
            sqlcon.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message) ' Showing the MySql exception on message box
            sqlcon.Dispose()

        End Try
        

    End Sub

    Private Sub IMToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IMToolStripMenuItem.Click

    End Sub

    Private Sub ToolStripTextBox1_Click(sender As Object, e As EventArgs) Handles ToolStripTextBox1.Click
        AboutBox.Visible = True
    End Sub

    Private Sub DIALPADToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DIALPADToolStripMenuItem.Click
        FormDialpad.Visible = True

    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ButtonExit_Click(sender As Object, e As EventArgs) Handles ButtonExit.Click
        Me.Close()
        Login.Close()


    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles ButtonContact.Click
        FormNewcontact.Show()

    End Sub

    Private Sub ButtonACW_Click(sender As Object, e As EventArgs) Handles ButtonACW.Click
        CallHistory.Show()

    End Sub

    Private Sub Sphone_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Login.Close()

    End Sub

    Private Sub BREAKToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BREAKToolStripMenuItem.Click
        If Me.Text = "ONLINE" Then
            Me.Text = "TEA BREAK"
            BREAKToolStripMenuItem.Text = "ONLINE"
        ElseIf Me.Text = "TEA BREAK" Then
            Me.Text = "ONLINE"
            BREAKToolStripMenuItem.Text = "TEA BREAK"
        End If
        
    End Sub

    Private Sub ButtonDnd_Click(sender As Object, e As EventArgs) Handles ButtonDnd.Click
        If Me.Text = "ACW" Then
            Me.Text = "ONLINE"
        Else
            Me.Text = "ACW"
        End If


    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Schedule.Show()

    End Sub
End Class
