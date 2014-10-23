Imports MySql.Data.MySqlClient


Public Class CallLog
    Dim sqlcon As New MySqlConnection
    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub ButtonCalllogclose_Click(sender As Object, e As EventArgs) Handles ButtonCalllogclose.Click
        Me.Close()

    End Sub

    Private Sub ButtonCalllogcontacts_Click(sender As Object, e As EventArgs) Handles ButtonCalllogcontacts.Click
        FormContact.Visible = True

    End Sub

    Private Sub ComboBoxCalllogstatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxCallLogStatus.SelectedIndexChanged

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs)



    End Sub

    Private Sub CallLog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        

    End Sub

    Private Sub ButtonCalllogSave_Click(sender As Object, e As EventArgs) Handles ButtonCalllogSave.Click
        Dim sql, sql1, sql2 As String
        Dim CONTACT_ID As Int32
        Dim CONTACT_YES As Boolean
        Dim reader, reader1 As MySqlDataReader
        Dim com, com1, com2 As MySqlCommand

        'check weather the Contact Number exists in contacts
        sql = "SELECT id FROM phonikip.contacts where contact_no= '" & Me.TextBoxCallLogTelNo.Text & "' "
        sqlcon.ConnectionString = "server=127.0.0.1; userid=root; password=passw0rd; database=phonikip"

        Try
            sqlcon.Open() ' connecting to the MySqL server
            com = New MySqlCommand(sql, sqlcon)
            reader = com.ExecuteReader
            While reader.Read
                If reader.HasRows = False Then ' If there is no exisiting contacts
                    CONTACT_YES = False
                Else
                    CONTACT_YES = True

                End If
            End While
            sqlcon.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message) ' Showing the MySql exception on message box
            sqlcon.Dispose()
            Me.Close()
        End Try
        ' IF THERE IS NO CONTACT CREATE CONTACT
        If CONTACT_YES = False Then

            sql1 = "insert into contacts (contact_title, contact_firstname,contact_lastname,contact_gender,contact_email1,contact_email2,contact_no,contact_mobile2,contact_work_phone1,contact_work_fax,contact_res_phone,contact_skype,contact_google,contact_address_number,contact_address_street,contact_address_city,contact_address_district,contact_address_province,contact_address_country,contact_shipping_address_number,contact_shipping_address_street,contact_shipping_address_city,contact_shipping_address_district,contact_shipping__address_province,contact_shipping_address_country,contact_organization,contact_designation,contact_company_address,contact_company_email, contact_company_department,contact_company_web,contact_nationality,contact_nic,contact_dlno, contact_maritial_status, contact_blood_group, contact_type,contact_birthday) values ('" & Me.ComboBoxCallLogTitle.Text & "','" & Me.TextBoxCallLogFirstname.Text & "','" & Me.TextBoxCallLogLastname.Text & "','" & Me.ComboBoxGender.Text & "',' " & Me.TextBoxCallLogEmail.Text & "','" & Me.TextBoxContactEmail2.Text & "','" & Me.TextBoxCallLogTelNo.Text & "','" & Me.TextBoxContactMobile2.Text & "','" & Me.TextBoxWorkTel1.Text & "','" & Me.TextBoxWorkFax.Text & "','" & Me.TextBoxContactResPhone.Text & "','" & Me.TextBoxSkype.Text & "','" & Me.TextBoxGtalk.Text & "','" & Me.TextBoxAddrNo.Text & "', '" & Me.TextBoxAddrStreet.Text & "','" & Me.TextBoxAddrCity.Text & "','" & Me.ComboBoxAddrDist.Text & "','" & Me.ComboBoxAddrPro.Text & "','" & Me.ComboBoxAddrCoun.Text & "','" & Me.TextBoxShipAddrNo.Text & "','" & Me.TextBoxShipAddrStreet.Text & "','" & Me.TextBoxShipAddrCity.Text & "','" & Me.ComboBoxShipAddrDst.Text & "',' " & Me.ComboBoxShipAddrPro.Text & " ', ' " & Me.ComboBoxShipAddrCoun.Text & " ', ' " & Me.TextBoxCompany.Text & " ','" & Me.TextBoxContactDesig.Text & "',' " & Me.RichTextBoxCompanyAddr.Text & " ', ' " & Me.TextBoxCompanyEmail.Text & " ' ,  '" & Me.TextBoxContactDepart.Text & "','" & Me.TextBoxCompanyWeb.Text & "','" & Me.TextBoxContactNationality.Text & "','" & Me.TextBoxContactNic.Text & "','" & Me.TextBoxContactDlno.Text & "','" & Me.ComboBoxContactMaritialStatus.Text & "','" & Me.TextBoxContactBloodGroup.Text & "','" & Me.ComboBoxContactType.Text & "',' " & Me.TextBoxContactBirthday.Text & " ' )"
            sql2 = "SELECT MAX(id) from phonikip.contacts"
            sqlcon.ConnectionString = "server=127.0.0.1; userid=root; password=passw0rd; database=phonikip"
            Try
                sqlcon.Open() ' connecting to the MySqL server
                com = New MySqlCommand(sql1, sqlcon)
                reader = com.ExecuteReader
               
                sqlcon.Close()
                sqlcon.Open()
                com1 = New MySqlCommand(sql2, sqlcon)
                reader1 = com1.ExecuteReader
                While reader1.Read
                    CONTACT_ID = reader1.GetInt32("MAX(id)") ' Get the newly created contact id
                End While
                sqlcon.Close()

            Catch ex As MySqlException
                MessageBox.Show(ex.Message) ' Showing the MySql exception on message box
                sqlcon.Dispose()
                Me.Close()
            End Try

            'CREATE CALL LOG ENTRY USING THE CREATED CONTACT

            sql1 = "insert into phonikip.call (call_description,call_status,contact_id) values ('" & Me.RichTextBoxCalLogDesc.Text & "', '" & Me.ComboBoxCallLogStatus.Text & "', 'CONTACT_ID'  )"
            sqlcon.ConnectionString = "server=127.0.0.1; userid=root; password=passw0rd; database=phonikip"

            Try

                sqlcon.Open() ' connecting to the MySqL server
                com2 = New MySqlCommand(sql1, sqlcon)
                reader = com2.ExecuteReader
                sqlcon.Close()
                MessageBox.Show("Call successfully Logged & Contact Created!")
                sqlcon.Close()
            Catch ex As MySqlException
                MessageBox.Show(ex.Message) ' Showing the MySql exception on message box
                sqlcon.Dispose()
                Me.Close()
            End Try

        Else ' If the contact does exist 
            ' CREATE CALL LOG
            sql1 = "insert into phonikip.call (call_description,call_status,contact_id) values ('" & Me.RichTextBoxCalLogDesc.Text & "', '" & Me.ComboBoxCallLogStatus.Text & "',  CONTACT_ID   )"

            sqlcon.ConnectionString = "server=127.0.0.1; userid=root; password=passw0rd; database=phonikip"

            Try
                sqlcon.Open()
                com1 = New MySqlCommand(sql, sqlcon) ' select the existing contact id
                reader = com1.ExecuteReader
                While reader.Read
                    CONTACT_ID = reader.GetInt32("id") ' Get the existing contact id
                End While
                sqlcon.Close()


                sqlcon.Open() ' connecting to the MySqL server
                com = New MySqlCommand(sql1, sqlcon)
                reader = com.ExecuteReader

                MessageBox.Show("Call Logged!!!!")
                sqlcon.Close()

            Catch ex As MySqlException
                MessageBox.Show(ex.Message) ' Showing the MySql exception on message box
                sqlcon.Dispose()
                Me.Close()

            End Try




        End If


    End Sub

    Private Sub TextBoxMobile2_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click_3(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBoxCallLogTelNo_TextChanged(sender As Object, e As EventArgs) Handles TextBoxCallLogTelNo.TextChanged

    End Sub

    Private Sub GroupBoxNewcontact_Enter(sender As Object, e As EventArgs) Handles GroupBoxNewcontact.Enter

    End Sub
End Class