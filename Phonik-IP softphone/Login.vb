Imports MySql.Data.MySqlClient
Public Class Login

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Dim sqlcon As New MySqlConnection

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim sql As String
        Dim reader As MySqlDataReader
        Dim com As MySqlCommand
        Dim count As Integer
        count = 0

        sql = "SELECT * FROM user where user_name ='" & TextBoxUsername.Text & "' and user_password= '" & TextBoxPassword.Text & "'"
        'sql query to query the database
        sqlcon.ConnectionString = "server=127.0.0.1; userid=root; password=passw0rd; database=phonikip"
        Try
            sqlcon.Open() ' connecting to the MySqL server
            com = New MySqlCommand(sql, sqlcon)
            reader = com.ExecuteReader
            While reader.Read
                count = count + 1
            End While
            If count = 1 Then
                Sphone.Visible = True
                Me.Visible = False
            Else
                MessageBox.Show("Invalid Username or Password")
            End If

            sqlcon.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message) ' Showing the MySql exception on message box
            sqlcon.Dispose()

        End Try
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub UsernameLabel_Click(sender As Object, e As EventArgs) Handles UsernameLabel.Click

    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

       


    End Sub
End Class
