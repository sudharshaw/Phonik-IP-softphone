Imports MySql.Data.MySqlClient

Public Class FormContact
    Dim sqlcon As New MySqlConnection
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonContactsNew.Click

        FormNewcontact.Visible = True

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ButtonContactsClose.Click
        Me.Close()

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewContacts.CellContentClick


    End Sub

    Private Sub DataGridViewContacts_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewContacts.CellClick



    End Sub

    Private Sub DataGridViewContacts_MouseDown(sender As Object, e As MouseEventArgs) Handles DataGridViewContacts.MouseDown

    End Sub

    Private Sub FormContact_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sqlcon.ConnectionString = "server=127.0.0.1; userid=root; password=passw0rd; database=phonikip"

        Dim sql As String
        'Dim reader As MySqlDataReader
        Dim com As MySqlCommand
        Dim DAP As New MySqlDataAdapter
        Dim BS As New BindingSource
        Dim DSET As New DataTable
        sql = "SELECT id as 'ID',contact_firstname as 'First Name',contact_lastname as 'Last Name',contact_no as 'Contact No',contact_email1 as 'Contact Email',contact_organization as 'Company',contact_owner as 'Assigned To' FROM phonikip.contacts "

        Try
            sqlcon.Open() ' connecting to the MySqL server
            com = New MySqlCommand(sql, sqlcon)
            DAP.SelectCommand = com
            DAP.Fill(DSET)
            BS.DataSource = DSET
            Me.DataGridViewContacts.DataSource = BS
            DAP.Update(DSET)
            'reader = com.ExecuteReader
            'MessageBox.Show("Contact successfully created !")
            sqlcon.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message) ' Showing the MySql exception on message box
            sqlcon.Dispose()
            Me.Close()

        End Try
    End Sub

    Private Sub DataGridViewContacts_CellLeave(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewContacts.CellLeave
        Me.ButtonContactsNew.Text = "&New"
        Me.ButtonContactSelect.Visible = False
    End Sub

    Private Sub DataGridViewContacts_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridViewContacts.CellMouseClick
        Me.ButtonContactsNew.Text = "&Edit"
        Me.ButtonContactSelect.Visible = True
    End Sub

    Private Sub ButtonContactSelect_Click(sender As Object, e As EventArgs) Handles ButtonContactSelect.Click

    End Sub
End Class