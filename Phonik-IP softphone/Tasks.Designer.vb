<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tasks
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
        Me.components = New System.ComponentModel.Container()
        Me.ComboBoxNewcontactTaskassignedto = New System.Windows.Forms.ComboBox()
        Me.LabelNewcontactTaskassignto = New System.Windows.Forms.Label()
        Me.ComboBoxNewcontactTaskstatus = New System.Windows.Forms.ComboBox()
        Me.LabelNewcontactTaskstatus = New System.Windows.Forms.Label()
        Me.RichTextBoxNewcontactTask = New System.Windows.Forms.RichTextBox()
        Me.LabelNewcontactTaskdesc = New System.Windows.Forms.Label()
        Me.DateTimePickerNewcontactTaskend = New System.Windows.Forms.DateTimePicker()
        Me.LabelNewcontactTaskend = New System.Windows.Forms.Label()
        Me.DateTimePickerNewcontactstart = New System.Windows.Forms.DateTimePicker()
        Me.LabelNewcontactTaskstart = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.LabelNewcontactTasksubject = New System.Windows.Forms.Label()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'ComboBoxNewcontactTaskassignedto
        '
        Me.ComboBoxNewcontactTaskassignedto.FormattingEnabled = True
        Me.ComboBoxNewcontactTaskassignedto.Items.AddRange(New Object() {"Started", "Ongoing", "Completed", "Differed"})
        Me.ComboBoxNewcontactTaskassignedto.Location = New System.Drawing.Point(269, 191)
        Me.ComboBoxNewcontactTaskassignedto.Name = "ComboBoxNewcontactTaskassignedto"
        Me.ComboBoxNewcontactTaskassignedto.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxNewcontactTaskassignedto.TabIndex = 27
        '
        'LabelNewcontactTaskassignto
        '
        Me.LabelNewcontactTaskassignto.AutoSize = True
        Me.LabelNewcontactTaskassignto.Location = New System.Drawing.Point(197, 191)
        Me.LabelNewcontactTaskassignto.Name = "LabelNewcontactTaskassignto"
        Me.LabelNewcontactTaskassignto.Size = New System.Drawing.Size(66, 13)
        Me.LabelNewcontactTaskassignto.TabIndex = 26
        Me.LabelNewcontactTaskassignto.Text = "Assigned To"
        '
        'ComboBoxNewcontactTaskstatus
        '
        Me.ComboBoxNewcontactTaskstatus.FormattingEnabled = True
        Me.ComboBoxNewcontactTaskstatus.Items.AddRange(New Object() {"Started", "Ongoing", "Completed", "Differed"})
        Me.ComboBoxNewcontactTaskstatus.Location = New System.Drawing.Point(78, 191)
        Me.ComboBoxNewcontactTaskstatus.Name = "ComboBoxNewcontactTaskstatus"
        Me.ComboBoxNewcontactTaskstatus.Size = New System.Drawing.Size(104, 21)
        Me.ComboBoxNewcontactTaskstatus.TabIndex = 23
        '
        'LabelNewcontactTaskstatus
        '
        Me.LabelNewcontactTaskstatus.AutoSize = True
        Me.LabelNewcontactTaskstatus.Location = New System.Drawing.Point(12, 194)
        Me.LabelNewcontactTaskstatus.Name = "LabelNewcontactTaskstatus"
        Me.LabelNewcontactTaskstatus.Size = New System.Drawing.Size(37, 13)
        Me.LabelNewcontactTaskstatus.TabIndex = 22
        Me.LabelNewcontactTaskstatus.Text = "Status"
        '
        'RichTextBoxNewcontactTask
        '
        Me.RichTextBoxNewcontactTask.Location = New System.Drawing.Point(78, 109)
        Me.RichTextBoxNewcontactTask.Name = "RichTextBoxNewcontactTask"
        Me.RichTextBoxNewcontactTask.Size = New System.Drawing.Size(312, 72)
        Me.RichTextBoxNewcontactTask.TabIndex = 21
        Me.RichTextBoxNewcontactTask.Text = ""
        '
        'LabelNewcontactTaskdesc
        '
        Me.LabelNewcontactTaskdesc.AutoSize = True
        Me.LabelNewcontactTaskdesc.Location = New System.Drawing.Point(12, 112)
        Me.LabelNewcontactTaskdesc.Name = "LabelNewcontactTaskdesc"
        Me.LabelNewcontactTaskdesc.Size = New System.Drawing.Size(60, 13)
        Me.LabelNewcontactTaskdesc.TabIndex = 20
        Me.LabelNewcontactTaskdesc.Text = "Description"
        '
        'DateTimePickerNewcontactTaskend
        '
        Me.DateTimePickerNewcontactTaskend.Location = New System.Drawing.Point(269, 62)
        Me.DateTimePickerNewcontactTaskend.Name = "DateTimePickerNewcontactTaskend"
        Me.DateTimePickerNewcontactTaskend.Size = New System.Drawing.Size(119, 20)
        Me.DateTimePickerNewcontactTaskend.TabIndex = 19
        Me.DateTimePickerNewcontactTaskend.Value = New Date(2014, 9, 25, 0, 0, 0, 0)
        '
        'LabelNewcontactTaskend
        '
        Me.LabelNewcontactTaskend.AutoSize = True
        Me.LabelNewcontactTaskend.Location = New System.Drawing.Point(211, 62)
        Me.LabelNewcontactTaskend.Name = "LabelNewcontactTaskend"
        Me.LabelNewcontactTaskend.Size = New System.Drawing.Size(52, 13)
        Me.LabelNewcontactTaskend.TabIndex = 18
        Me.LabelNewcontactTaskend.Text = "End Date"
        '
        'DateTimePickerNewcontactstart
        '
        Me.DateTimePickerNewcontactstart.Location = New System.Drawing.Point(73, 62)
        Me.DateTimePickerNewcontactstart.Name = "DateTimePickerNewcontactstart"
        Me.DateTimePickerNewcontactstart.Size = New System.Drawing.Size(119, 20)
        Me.DateTimePickerNewcontactstart.TabIndex = 17
        '
        'LabelNewcontactTaskstart
        '
        Me.LabelNewcontactTaskstart.AutoSize = True
        Me.LabelNewcontactTaskstart.Location = New System.Drawing.Point(12, 62)
        Me.LabelNewcontactTaskstart.Name = "LabelNewcontactTaskstart"
        Me.LabelNewcontactTaskstart.Size = New System.Drawing.Size(55, 13)
        Me.LabelNewcontactTaskstart.TabIndex = 16
        Me.LabelNewcontactTaskstart.Text = "Start Date"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(78, 18)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(312, 20)
        Me.TextBox3.TabIndex = 15
        '
        'LabelNewcontactTasksubject
        '
        Me.LabelNewcontactTasksubject.AutoSize = True
        Me.LabelNewcontactTasksubject.Location = New System.Drawing.Point(12, 21)
        Me.LabelNewcontactTasksubject.Name = "LabelNewcontactTasksubject"
        Me.LabelNewcontactTasksubject.Size = New System.Drawing.Size(43, 13)
        Me.LabelNewcontactTasksubject.TabIndex = 14
        Me.LabelNewcontactTasksubject.Text = "Subject"
        '
        'ButtonSave
        '
        Me.ButtonSave.Location = New System.Drawing.Point(315, 226)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSave.TabIndex = 28
        Me.ButtonSave.Text = "&Save"
        Me.ButtonSave.UseVisualStyleBackColor = True
        '
        'ButtonCancel
        '
        Me.ButtonCancel.Location = New System.Drawing.Point(234, 226)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCancel.TabIndex = 29
        Me.ButtonCancel.Text = "&Cancel"
        Me.ButtonCancel.UseVisualStyleBackColor = True
        '
        'Tasks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(431, 261)
        Me.Controls.Add(Me.ButtonCancel)
        Me.Controls.Add(Me.ButtonSave)
        Me.Controls.Add(Me.ComboBoxNewcontactTaskassignedto)
        Me.Controls.Add(Me.LabelNewcontactTaskassignto)
        Me.Controls.Add(Me.ComboBoxNewcontactTaskstatus)
        Me.Controls.Add(Me.LabelNewcontactTaskstatus)
        Me.Controls.Add(Me.RichTextBoxNewcontactTask)
        Me.Controls.Add(Me.LabelNewcontactTaskdesc)
        Me.Controls.Add(Me.DateTimePickerNewcontactTaskend)
        Me.Controls.Add(Me.LabelNewcontactTaskend)
        Me.Controls.Add(Me.DateTimePickerNewcontactstart)
        Me.Controls.Add(Me.LabelNewcontactTaskstart)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.LabelNewcontactTasksubject)
        Me.Name = "Tasks"
        Me.Text = "Tasks"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboBoxNewcontactTaskassignedto As System.Windows.Forms.ComboBox
    Friend WithEvents LabelNewcontactTaskassignto As System.Windows.Forms.Label
    Friend WithEvents ComboBoxNewcontactTaskstatus As System.Windows.Forms.ComboBox
    Friend WithEvents LabelNewcontactTaskstatus As System.Windows.Forms.Label
    Friend WithEvents RichTextBoxNewcontactTask As System.Windows.Forms.RichTextBox
    Friend WithEvents LabelNewcontactTaskdesc As System.Windows.Forms.Label
    Friend WithEvents DateTimePickerNewcontactTaskend As System.Windows.Forms.DateTimePicker
    Friend WithEvents LabelNewcontactTaskend As System.Windows.Forms.Label
    Friend WithEvents DateTimePickerNewcontactstart As System.Windows.Forms.DateTimePicker
    Friend WithEvents LabelNewcontactTaskstart As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents LabelNewcontactTasksubject As System.Windows.Forms.Label
    Friend WithEvents ButtonSave As System.Windows.Forms.Button
    Friend WithEvents ButtonCancel As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
