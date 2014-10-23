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
        Me.ButtonContactsNew = New System.Windows.Forms.Button()
        Me.ButtonContactsClose = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ButtonContactSelect = New System.Windows.Forms.Button()
        Me.ButtonContactsSerach = New System.Windows.Forms.Button()
        Me.TextConSearch = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboConSearch = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DataGridViewContacts = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridViewContacts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonContactsNew
        '
        Me.ButtonContactsNew.Location = New System.Drawing.Point(616, 18)
        Me.ButtonContactsNew.Name = "ButtonContactsNew"
        Me.ButtonContactsNew.Size = New System.Drawing.Size(75, 23)
        Me.ButtonContactsNew.TabIndex = 1
        Me.ButtonContactsNew.Text = "&New"
        Me.ButtonContactsNew.UseVisualStyleBackColor = True
        '
        'ButtonContactsClose
        '
        Me.ButtonContactsClose.Location = New System.Drawing.Point(695, 18)
        Me.ButtonContactsClose.Name = "ButtonContactsClose"
        Me.ButtonContactsClose.Size = New System.Drawing.Size(75, 23)
        Me.ButtonContactsClose.TabIndex = 2
        Me.ButtonContactsClose.Text = "&Close"
        Me.ButtonContactsClose.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ButtonContactSelect)
        Me.GroupBox1.Controls.Add(Me.ButtonContactsSerach)
        Me.GroupBox1.Controls.Add(Me.TextConSearch)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ComboConSearch)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(770, 40)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'ButtonContactSelect
        '
        Me.ButtonContactSelect.Location = New System.Drawing.Point(528, 12)
        Me.ButtonContactSelect.Name = "ButtonContactSelect"
        Me.ButtonContactSelect.Size = New System.Drawing.Size(75, 23)
        Me.ButtonContactSelect.TabIndex = 5
        Me.ButtonContactSelect.Text = "&Select"
        Me.ButtonContactSelect.UseVisualStyleBackColor = True
        Me.ButtonContactSelect.Visible = False
        '
        'ButtonContactsSerach
        '
        Me.ButtonContactsSerach.Location = New System.Drawing.Point(362, 14)
        Me.ButtonContactsSerach.Name = "ButtonContactsSerach"
        Me.ButtonContactsSerach.Size = New System.Drawing.Size(75, 23)
        Me.ButtonContactsSerach.TabIndex = 3
        Me.ButtonContactsSerach.Text = "&Search"
        Me.ButtonContactsSerach.UseVisualStyleBackColor = True
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
        Me.DataGridViewContacts.Location = New System.Drawing.Point(9, 19)
        Me.DataGridViewContacts.Name = "DataGridViewContacts"
        Me.DataGridViewContacts.Size = New System.Drawing.Size(754, 272)
        Me.DataGridViewContacts.TabIndex = 1
        '
        'FormContact
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 361)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.ButtonContactsClose)
        Me.Controls.Add(Me.ButtonContactsNew)
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
    Friend WithEvents ButtonContactsNew As System.Windows.Forms.Button
    Friend WithEvents ButtonContactsClose As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ComboConSearch As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextConSearch As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridViewContacts As System.Windows.Forms.DataGridView
    Friend WithEvents ButtonContactsSerach As System.Windows.Forms.Button
    Friend WithEvents ButtonContactSelect As System.Windows.Forms.Button
End Class
