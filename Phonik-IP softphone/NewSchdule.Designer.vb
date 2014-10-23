<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewSchdule
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
        Me.GroupBoxCallSchedule = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.LabelCaller = New System.Windows.Forms.Label()
        Me.LabelDate = New System.Windows.Forms.Label()
        Me.DateTimePickerNewSchedule = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePickerTime = New System.Windows.Forms.DateTimePicker()
        Me.LabelTime = New System.Windows.Forms.Label()
        Me.LabelAssignedTo = New System.Windows.Forms.Label()
        Me.ComboBoxAssignedTo = New System.Windows.Forms.ComboBox()
        Me.GroupBoxButtons = New System.Windows.Forms.GroupBox()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.ButtonClose = New System.Windows.Forms.Button()
        Me.GroupBoxCallSchedule.SuspendLayout()
        Me.GroupBoxButtons.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBoxCallSchedule
        '
        Me.GroupBoxCallSchedule.Controls.Add(Me.ComboBoxAssignedTo)
        Me.GroupBoxCallSchedule.Controls.Add(Me.LabelAssignedTo)
        Me.GroupBoxCallSchedule.Controls.Add(Me.LabelTime)
        Me.GroupBoxCallSchedule.Controls.Add(Me.DateTimePickerTime)
        Me.GroupBoxCallSchedule.Controls.Add(Me.DateTimePickerNewSchedule)
        Me.GroupBoxCallSchedule.Controls.Add(Me.LabelDate)
        Me.GroupBoxCallSchedule.Controls.Add(Me.LabelCaller)
        Me.GroupBoxCallSchedule.Controls.Add(Me.TextBox1)
        Me.GroupBoxCallSchedule.Location = New System.Drawing.Point(12, 11)
        Me.GroupBoxCallSchedule.Name = "GroupBoxCallSchedule"
        Me.GroupBoxCallSchedule.Size = New System.Drawing.Size(260, 177)
        Me.GroupBoxCallSchedule.TabIndex = 0
        Me.GroupBoxCallSchedule.TabStop = False
        Me.GroupBoxCallSchedule.Text = "Call Shedule"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(45, 22)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(200, 20)
        Me.TextBox1.TabIndex = 1
        '
        'LabelCaller
        '
        Me.LabelCaller.AutoSize = True
        Me.LabelCaller.Location = New System.Drawing.Point(6, 22)
        Me.LabelCaller.Name = "LabelCaller"
        Me.LabelCaller.Size = New System.Drawing.Size(33, 13)
        Me.LabelCaller.TabIndex = 1
        Me.LabelCaller.Text = "Caller"
        '
        'LabelDate
        '
        Me.LabelDate.AutoSize = True
        Me.LabelDate.Location = New System.Drawing.Point(6, 59)
        Me.LabelDate.Name = "LabelDate"
        Me.LabelDate.Size = New System.Drawing.Size(30, 13)
        Me.LabelDate.TabIndex = 1
        Me.LabelDate.Text = "Date"
        '
        'DateTimePickerNewSchedule
        '
        Me.DateTimePickerNewSchedule.Location = New System.Drawing.Point(45, 59)
        Me.DateTimePickerNewSchedule.Name = "DateTimePickerNewSchedule"
        Me.DateTimePickerNewSchedule.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePickerNewSchedule.TabIndex = 1
        '
        'DateTimePickerTime
        '
        Me.DateTimePickerTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DateTimePickerTime.Location = New System.Drawing.Point(45, 98)
        Me.DateTimePickerTime.Name = "DateTimePickerTime"
        Me.DateTimePickerTime.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePickerTime.TabIndex = 1
        '
        'LabelTime
        '
        Me.LabelTime.AutoSize = True
        Me.LabelTime.Location = New System.Drawing.Point(6, 98)
        Me.LabelTime.Name = "LabelTime"
        Me.LabelTime.Size = New System.Drawing.Size(30, 13)
        Me.LabelTime.TabIndex = 2
        Me.LabelTime.Text = "Time"
        '
        'LabelAssignedTo
        '
        Me.LabelAssignedTo.AutoSize = True
        Me.LabelAssignedTo.Location = New System.Drawing.Point(6, 140)
        Me.LabelAssignedTo.Name = "LabelAssignedTo"
        Me.LabelAssignedTo.Size = New System.Drawing.Size(66, 13)
        Me.LabelAssignedTo.TabIndex = 1
        Me.LabelAssignedTo.Text = "Assigned To"
        '
        'ComboBoxAssignedTo
        '
        Me.ComboBoxAssignedTo.FormattingEnabled = True
        Me.ComboBoxAssignedTo.Location = New System.Drawing.Point(78, 137)
        Me.ComboBoxAssignedTo.Name = "ComboBoxAssignedTo"
        Me.ComboBoxAssignedTo.Size = New System.Drawing.Size(167, 21)
        Me.ComboBoxAssignedTo.TabIndex = 1
        '
        'GroupBoxButtons
        '
        Me.GroupBoxButtons.Controls.Add(Me.ButtonClose)
        Me.GroupBoxButtons.Controls.Add(Me.ButtonSave)
        Me.GroupBoxButtons.Location = New System.Drawing.Point(12, 194)
        Me.GroupBoxButtons.Name = "GroupBoxButtons"
        Me.GroupBoxButtons.Size = New System.Drawing.Size(260, 55)
        Me.GroupBoxButtons.TabIndex = 1
        Me.GroupBoxButtons.TabStop = False
        '
        'ButtonSave
        '
        Me.ButtonSave.Location = New System.Drawing.Point(78, 19)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSave.TabIndex = 2
        Me.ButtonSave.Text = "&Save"
        Me.ButtonSave.UseVisualStyleBackColor = True
        '
        'ButtonClose
        '
        Me.ButtonClose.Location = New System.Drawing.Point(170, 19)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(75, 23)
        Me.ButtonClose.TabIndex = 3
        Me.ButtonClose.Text = "&Close"
        Me.ButtonClose.UseVisualStyleBackColor = True
        '
        'NewSchdule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.GroupBoxButtons)
        Me.Controls.Add(Me.GroupBoxCallSchedule)
        Me.Name = "NewSchdule"
        Me.Text = "New Schdule"
        Me.GroupBoxCallSchedule.ResumeLayout(False)
        Me.GroupBoxCallSchedule.PerformLayout()
        Me.GroupBoxButtons.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBoxCallSchedule As System.Windows.Forms.GroupBox
    Friend WithEvents ComboBoxAssignedTo As System.Windows.Forms.ComboBox
    Friend WithEvents LabelAssignedTo As System.Windows.Forms.Label
    Friend WithEvents LabelTime As System.Windows.Forms.Label
    Friend WithEvents DateTimePickerTime As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePickerNewSchedule As System.Windows.Forms.DateTimePicker
    Friend WithEvents LabelDate As System.Windows.Forms.Label
    Friend WithEvents LabelCaller As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBoxButtons As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonClose As System.Windows.Forms.Button
    Friend WithEvents ButtonSave As System.Windows.Forms.Button
End Class
