Imports MySql.Data.MySqlClient


Public Class FormNewcontact
    Dim sqlcon As New MySqlConnection
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles LabelNewcontactTitle.Click

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles LabelNewcontactAddr1no.Click

    End Sub

    Private Sub Label1_Click_2(sender As Object, e As EventArgs) Handles LabelNewcontactAddr1pro.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxNewcontactAddr1dist.SelectedIndexChanged

    End Sub

    Private Sub GroupBoxNewcontactAddress2_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub ButtonNewcontactclose_Click(sender As Object, e As EventArgs) Handles ButtonContactClose.Click
        Me.Close()

    End Sub

    Private Sub Label1_Click_3(sender As Object, e As EventArgs) Handles LabelLabelNewcontactcompanyadd.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBoxNewcontactcompany_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupBoxNewcontctbuttons_Enter(sender As Object, e As EventArgs) Handles GroupBoxNewcontctbuttons.Enter

    End Sub

    Private Sub FormNewcontact_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        




    End Sub

    Private Sub ButtonNewcontactSave_Click(sender As Object, e As EventArgs) Handles ButtonContactSave.Click
        Dim sql As String
        Dim reader As MySqlDataReader
        Dim com As MySqlCommand
        sql = "insert into phonikip.contacts (contact_title, contact_firstname,contact_lastname,contact_gender,contact_email1,contact_email2,contact_no,contact_mobile2,contact_work_phone1,contact_work_fax,contact_res_phone,contact_skype,contact_google,contact_address_number,contact_address_street,contact_address_city,contact_address_district,contact_address_province,contact_address_country,contact_shipping_address_number,contact_shipping_address_street,contact_shipping_address_city,contact_shipping_address_district,contact_shipping__address_province,contact_shipping_address_country,contact_organization,contact_designation,contact_company_address,contact_company_email, contact_company_department,contact_company_web,contact_nationality,contact_nic,contact_dlno, contact_maritial_status, contact_blood_group, contact_type,contact_birthday) values ('" & Me.ComboBoxTitle.Text & "','" & Me.TextBoxFirstname.Text & "','" & Me.TextBoxLastname.Text & "','" & Me.ComboBoxGender.Text & "','" & Me.TextBoxContactEmail1.Text & "','" & Me.TextBoxContactEmail2.Text & "','" & Me.TextBoxContactNo.Text & "','" & Me.TextBoxContactMobile2.Text & "','" & Me.TextBoxWorkTel1.Text & "','" & Me.TextBoxWorkFax.Text & "','" & Me.TextBoxContactResPhone.Text & "','" & Me.TextBoxSkype.Text & "','" & Me.TextBoxGtalk.Text & "','" & Me.TextBoxAddrNo.Text & "', '" & Me.TextBoxAddrStreet.Text & "','" & Me.TextBoxAddrCity.Text & "','" & Me.ComboBoxAddrDist.Text & "','" & Me.ComboBoxAddrPro.Text & "','" & Me.ComboBoxAddrCoun.Text & "','" & Me.TextBoxShipAddrNo.Text & "','" & Me.TextBoxShipAddrStreet.Text & "','" & Me.TextBoxShipAddrCity.Text & "','" & Me.ComboBoxShipAddrDst.Text & "',' " & Me.ComboBoxShipAddrPro.Text & " ', ' " & Me.ComboBoxShipAddrCoun.Text & " ', ' " & Me.TextBoxCompany.Text & " ','" & Me.TextBoxContactDesig.Text & "',' " & Me.RichTextBoxCompanyAddr.Text & " ', ' " & Me.TextBoxCompanyEmail.Text & " ' ,  '" & Me.TextBoxContactDepart.Text & "','" & Me.TextBoxCompanyWeb.Text & "','" & Me.TextBoxContactNationality.Text & "','" & Me.TextBoxContactNic.Text & "','" & Me.TextBoxContactDlno.Text & "','" & Me.ComboBoxContactMaritialStatus.Text & "','" & Me.TextBoxContactBloodGroup.Text & "','" & Me.ComboBoxContactType.Text & "',' " & Me.TextBoxContactBirthday.Text & " ' )"
        sqlcon.ConnectionString = "server=127.0.0.1; userid=root; password=passw0rd; database=phonikip"
        Try
            sqlcon.Open() ' connecting to the MySqL server
            com = New MySqlCommand(sql, sqlcon)
            reader = com.ExecuteReader
            MessageBox.Show("Contact successfully created !")
            sqlcon.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message) ' Showing the MySql exception on message box
            sqlcon.Dispose()
            Me.Close()

        End Try
    End Sub

    Private Sub TextBoxMobile2_TextChanged(sender As Object, e As EventArgs) Handles TextBoxContactMobile2.TextChanged

    End Sub

    Private Sub ButtonContactNext_Click(sender As Object, e As EventArgs) Handles ButtonContactNext.Click

    End Sub
End Class