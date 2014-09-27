<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormContact
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextConSearch = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboConSearch = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DataGridViewContacts = New System.Windows.Forms.DataGridView()
        Me.No = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Mobile = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Account = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Assignto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ButtonSerach = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridViewContacts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(616, 18)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "&New"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(695, 18)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "&Close"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ButtonSerach)
        Me.GroupBox1.Controls.Add(Me.TextConSearch)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ComboConSearch)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(770, 40)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'TextConSearch
        '
        Me.TextConSearch.Location = New System.Drawing.Point(179, 14)
        Me.TextConSearch.Name = "TextConSearch"
        Me.TextConSearch.Size = New System.Drawing.Size(167, 20)
        Me.TextConSearch.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Search"
        '
        'ComboConSearch
        '
        Me.ComboConSearch.FormattingEnabled = True
        Me.ComboConSearch.Items.AddRange(New Object() {"Name", "Number", "Email", "Address"})
        Me.ComboConSearch.Location = New System.Drawing.Point(53, 13)
        Me.ComboConSearch.Name = "ComboConSearch"
        Me.ComboConSearch.Size = New System.Drawing.Size(121, 21)
        Me.ComboConSearch.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGridViewContacts)
        Me.GroupBox2.Location = New System.Drawing.Point(7, 52)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(770, 297)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Contacts"
        '
        'DataGridViewContacts
        '
        Me.DataGridViewContacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewContacts.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.No, Me.FirstName, Me.LastName, Me.Mobile, Me.Email, Me.Account, Me.Assignto})
        Me.DataGridViewContacts.Location = New System.Drawing.Point(9, 19)
        Me.DataGridViewContacts.Name = "DataGridViewContacts"
        Me.DataGridViewContacts.Size = New System.Drawing.Size(754, 272)
        Me.DataGridViewContacts.TabIndex = 1
        '
        'No
        '
        Me.No.HeaderText = "No"
        Me.No.Name = "No"
        Me.No.Width = 50
        '
        'FirstName
        '
        Me.FirstName.HeaderText = "First Name"
        Me.FirstName.Name = "FirstName"
        '
        'LastName
        '
        Me.LastName.HeaderText = "Last Name"
        Me.LastName.Name = "LastName"
        '
        'Mobile
        '
        Me.Mobile.HeaderText = "Mobile"
        Me.Mobile.Name = "Mobile"
        '
        'Email
        '
        Me.Email.HeaderText = "Email"
        Me.Email.Name = "Email"
        Me.Email.Width = 135
        '
        'Account
        '
        Me.Account.HeaderText = "Account"
        Me.Account.Name = "Account"
        Me.Account.Width = 125
        '
        'Assignto
        '
        Me.Assignto.HeaderText = "Assign to"
        Me.Assignto.Name = "Assignto"
        '
        'ButtonSerach
        '
        Me.ButtonSerach.Location = New System.Drawing.Point(362, 14)
        Me.ButtonSerach.Name = "ButtonSerach"
        Me.ButtonSerach.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSerach.TabIndex = 3
        Me.ButtonSerach.Text = "&Search"
        Me.ButtonSerach.UseVisualStyleBackColor = True
        '
        'FormContact
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 361)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FormContact"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Contacts"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridViewContacts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ComboConSearch As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextConSearch As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridViewContacts As System.Windows.Forms.DataGridView
    Friend WithEvents No As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FirstName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LastName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Mobile As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Email As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Account As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Assignto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ButtonSerach As System.Windows.Forms.Button
End Class
