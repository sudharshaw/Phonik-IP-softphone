<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Schedule
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
        Me.GroupBoxSearch = New System.Windows.Forms.GroupBox()
        Me.Buttonnew = New System.Windows.Forms.Button()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Labeltimeto = New System.Windows.Forms.Label()
        Me.Labeltimefrom = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePickerTo = New System.Windows.Forms.DateTimePicker()
        Me.LabelTo = New System.Windows.Forms.Label()
        Me.DateTimePickerFrom = New System.Windows.Forms.DateTimePicker()
        Me.LabelFrom = New System.Windows.Forms.Label()
        Me.ButtonClear = New System.Windows.Forms.Button()
        Me.ButtonSearch = New System.Windows.Forms.Button()
        Me.TextBoxSearch = New System.Windows.Forms.TextBox()
        Me.ComboBoxSearch = New System.Windows.Forms.ComboBox()
        Me.LabelSearch = New System.Windows.Forms.Label()
        Me.DataGridViewCallhst = New System.Windows.Forms.DataGridView()
        Me.No = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Caller = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Direction = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.time = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Duration = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContextMenuStripShedule = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.RescheduleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.DeleteToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.GroupBoxSearch.SuspendLayout()
        CType(Me.DataGridViewCallhst, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStripShedule.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBoxSearch
        '
        Me.GroupBoxSearch.Controls.Add(Me.Buttonnew)
        Me.GroupBoxSearch.Controls.Add(Me.DateTimePicker2)
        Me.GroupBoxSearch.Controls.Add(Me.Labeltimeto)
        Me.GroupBoxSearch.Controls.Add(Me.Labeltimefrom)
        Me.GroupBoxSearch.Controls.Add(Me.DateTimePicker1)
        Me.GroupBoxSearch.Controls.Add(Me.DateTimePickerTo)
        Me.GroupBoxSearch.Controls.Add(Me.LabelTo)
        Me.GroupBoxSearch.Controls.Add(Me.DateTimePickerFrom)
        Me.GroupBoxSearch.Controls.Add(Me.LabelFrom)
        Me.GroupBoxSearch.Controls.Add(Me.ButtonClear)
        Me.GroupBoxSearch.Controls.Add(Me.ButtonSearch)
        Me.GroupBoxSearch.Controls.Add(Me.TextBoxSearch)
        Me.GroupBoxSearch.Controls.Add(Me.ComboBoxSearch)
        Me.GroupBoxSearch.Controls.Add(Me.LabelSearch)
        Me.GroupBoxSearch.Location = New System.Drawing.Point(12, 12)
        Me.GroupBoxSearch.Name = "GroupBoxSearch"
        Me.GroupBoxSearch.Size = New System.Drawing.Size(760, 84)
        Me.GroupBoxSearch.TabIndex = 1
        Me.GroupBoxSearch.TabStop = False
        '
        'Buttonnew
        '
        Me.Buttonnew.Location = New System.Drawing.Point(544, 46)
        Me.Buttonnew.Name = "Buttonnew"
        Me.Buttonnew.Size = New System.Drawing.Size(75, 23)
        Me.Buttonnew.TabIndex = 13
        Me.Buttonnew.Text = "&New"
        Me.Buttonnew.UseVisualStyleBackColor = True
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DateTimePicker2.Location = New System.Drawing.Point(660, 17)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(80, 20)
        Me.DateTimePicker2.TabIndex = 12
        '
        'Labeltimeto
        '
        Me.Labeltimeto.AutoSize = True
        Me.Labeltimeto.Location = New System.Drawing.Point(636, 19)
        Me.Labeltimeto.Name = "Labeltimeto"
        Me.Labeltimeto.Size = New System.Drawing.Size(20, 13)
        Me.Labeltimeto.TabIndex = 11
        Me.Labeltimeto.Text = "To"
        '
        'Labeltimefrom
        '
        Me.Labeltimefrom.AutoSize = True
        Me.Labeltimefrom.Location = New System.Drawing.Point(513, 19)
        Me.Labeltimefrom.Name = "Labeltimefrom"
        Me.Labeltimefrom.Size = New System.Drawing.Size(30, 13)
        Me.Labeltimefrom.TabIndex = 10
        Me.Labeltimefrom.Text = "From"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DateTimePicker1.Location = New System.Drawing.Point(544, 17)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(80, 20)
        Me.DateTimePicker1.TabIndex = 9
        '
        'DateTimePickerTo
        '
        Me.DateTimePickerTo.Location = New System.Drawing.Point(289, 49)
        Me.DateTimePickerTo.Name = "DateTimePickerTo"
        Me.DateTimePickerTo.Size = New System.Drawing.Size(204, 20)
        Me.DateTimePickerTo.TabIndex = 8
        '
        'LabelTo
        '
        Me.LabelTo.AutoSize = True
        Me.LabelTo.Location = New System.Drawing.Point(263, 52)
        Me.LabelTo.Name = "LabelTo"
        Me.LabelTo.Size = New System.Drawing.Size(20, 13)
        Me.LabelTo.TabIndex = 7
        Me.LabelTo.Text = "To"
        '
        'DateTimePickerFrom
        '
        Me.DateTimePickerFrom.Location = New System.Drawing.Point(53, 49)
        Me.DateTimePickerFrom.Name = "DateTimePickerFrom"
        Me.DateTimePickerFrom.Size = New System.Drawing.Size(204, 20)
        Me.DateTimePickerFrom.TabIndex = 6
        '
        'LabelFrom
        '
        Me.LabelFrom.AutoSize = True
        Me.LabelFrom.Location = New System.Drawing.Point(6, 52)
        Me.LabelFrom.Name = "LabelFrom"
        Me.LabelFrom.Size = New System.Drawing.Size(30, 13)
        Me.LabelFrom.TabIndex = 5
        Me.LabelFrom.Text = "From"
        '
        'ButtonClear
        '
        Me.ButtonClear.Location = New System.Drawing.Point(418, 14)
        Me.ButtonClear.Name = "ButtonClear"
        Me.ButtonClear.Size = New System.Drawing.Size(75, 23)
        Me.ButtonClear.TabIndex = 4
        Me.ButtonClear.Text = "&Clear"
        Me.ButtonClear.UseVisualStyleBackColor = True
        '
        'ButtonSearch
        '
        Me.ButtonSearch.Location = New System.Drawing.Point(337, 14)
        Me.ButtonSearch.Name = "ButtonSearch"
        Me.ButtonSearch.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSearch.TabIndex = 3
        Me.ButtonSearch.Text = "&Search"
        Me.ButtonSearch.UseVisualStyleBackColor = True
        '
        'TextBoxSearch
        '
        Me.TextBoxSearch.Location = New System.Drawing.Point(180, 14)
        Me.TextBoxSearch.Name = "TextBoxSearch"
        Me.TextBoxSearch.Size = New System.Drawing.Size(126, 20)
        Me.TextBoxSearch.TabIndex = 2
        '
        'ComboBoxSearch
        '
        Me.ComboBoxSearch.FormattingEnabled = True
        Me.ComboBoxSearch.Items.AddRange(New Object() {"Number", "Name"})
        Me.ComboBoxSearch.Location = New System.Drawing.Point(53, 13)
        Me.ComboBoxSearch.Name = "ComboBoxSearch"
        Me.ComboBoxSearch.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxSearch.TabIndex = 1
        '
        'LabelSearch
        '
        Me.LabelSearch.AutoSize = True
        Me.LabelSearch.Location = New System.Drawing.Point(6, 16)
        Me.LabelSearch.Name = "LabelSearch"
        Me.LabelSearch.Size = New System.Drawing.Size(41, 13)
        Me.LabelSearch.TabIndex = 0
        Me.LabelSearch.Text = "Search"
        '
        'DataGridViewCallhst
        '
        Me.DataGridViewCallhst.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewCallhst.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.No, Me.Caller, Me.Direction, Me.codate, Me.time, Me.Duration})
        Me.DataGridViewCallhst.ContextMenuStrip = Me.ContextMenuStripShedule
        Me.DataGridViewCallhst.Location = New System.Drawing.Point(12, 105)
        Me.DataGridViewCallhst.Name = "DataGridViewCallhst"
        Me.DataGridViewCallhst.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataGridViewCallhst.Size = New System.Drawing.Size(759, 267)
        Me.DataGridViewCallhst.TabIndex = 2
        '
        'No
        '
        Me.No.HeaderText = "No"
        Me.No.Name = "No"
        Me.No.Width = 50
        '
        'Caller
        '
        Me.Caller.HeaderText = "Recepient"
        Me.Caller.Name = "Caller"
        Me.Caller.Width = 195
        '
        'Direction
        '
        Me.Direction.HeaderText = "Agent"
        Me.Direction.Name = "Direction"
        Me.Direction.Width = 150
        '
        'codate
        '
        Me.codate.HeaderText = "Date"
        Me.codate.Name = "codate"
        '
        'time
        '
        Me.time.HeaderText = "Called Time"
        Me.time.Name = "time"
        Me.time.Width = 110
        '
        'Duration
        '
        Me.Duration.HeaderText = "Sheduled Time"
        Me.Duration.Name = "Duration"
        Me.Duration.Width = 110
        '
        'ContextMenuStripShedule
        '
        Me.ContextMenuStripShedule.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.DeleteToolStripMenuItem, Me.ToolStripSeparator2, Me.RescheduleToolStripMenuItem, Me.ToolStripSeparator3, Me.DeleteToolStripMenuItem1, Me.ToolStripSeparator4})
        Me.ContextMenuStripShedule.Name = "ContextMenuStripShedule"
        Me.ContextMenuStripShedule.Size = New System.Drawing.Size(139, 94)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(135, 6)
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.DeleteToolStripMenuItem.Text = "Call"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(135, 6)
        '
        'RescheduleToolStripMenuItem
        '
        Me.RescheduleToolStripMenuItem.Name = "RescheduleToolStripMenuItem"
        Me.RescheduleToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.RescheduleToolStripMenuItem.Text = "Re Schedule"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(135, 6)
        '
        'DeleteToolStripMenuItem1
        '
        Me.DeleteToolStripMenuItem1.Name = "DeleteToolStripMenuItem1"
        Me.DeleteToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.DeleteToolStripMenuItem1.Text = "Delete"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(149, 6)
        '
        'Schedule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 411)
        Me.Controls.Add(Me.DataGridViewCallhst)
        Me.Controls.Add(Me.GroupBoxSearch)
        Me.Name = "Schedule"
        Me.ShowIcon = False
        Me.Text = "Schedule"
        Me.GroupBoxSearch.ResumeLayout(False)
        Me.GroupBoxSearch.PerformLayout()
        CType(Me.DataGridViewCallhst, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStripShedule.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBoxSearch As System.Windows.Forms.GroupBox
    Friend WithEvents DateTimePickerTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents LabelTo As System.Windows.Forms.Label
    Friend WithEvents DateTimePickerFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents LabelFrom As System.Windows.Forms.Label
    Friend WithEvents ButtonClear As System.Windows.Forms.Button
    Friend WithEvents ButtonSearch As System.Windows.Forms.Button
    Friend WithEvents TextBoxSearch As System.Windows.Forms.TextBox
    Friend WithEvents ComboBoxSearch As System.Windows.Forms.ComboBox
    Friend WithEvents LabelSearch As System.Windows.Forms.Label
    Friend WithEvents DataGridViewCallhst As System.Windows.Forms.DataGridView
    Friend WithEvents No As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Caller As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Direction As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents codate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents time As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Duration As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Buttonnew As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Labeltimeto As System.Windows.Forms.Label
    Friend WithEvents Labeltimefrom As System.Windows.Forms.Label
    Friend WithEvents ContextMenuStripShedule As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RescheduleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DeleteToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
End Class
