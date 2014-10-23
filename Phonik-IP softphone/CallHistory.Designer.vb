<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CallHistory
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
        Me.GroupBoxSearch = New System.Windows.Forms.GroupBox()
        Me.DateTimePickerTo = New System.Windows.Forms.DateTimePicker()
        Me.LabelTo = New System.Windows.Forms.Label()
        Me.DateTimePickerFrom = New System.Windows.Forms.DateTimePicker()
        Me.LabelFrom = New System.Windows.Forms.Label()
        Me.ButtonClear = New System.Windows.Forms.Button()
        Me.ButtonSearch = New System.Windows.Forms.Button()
        Me.TextBoxSearch = New System.Windows.Forms.TextBox()
        Me.ComboBoxSearch = New System.Windows.Forms.ComboBox()
        Me.LabelSearch = New System.Windows.Forms.Label()
        Me.GroupBoxCallhst = New System.Windows.Forms.GroupBox()
        Me.DataGridViewCallhst = New System.Windows.Forms.DataGridView()
        Me.No = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Caller = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Direction = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.time = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Duration = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Agent = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBoxSearch.SuspendLayout()
        Me.GroupBoxCallhst.SuspendLayout()
        CType(Me.DataGridViewCallhst, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBoxSearch
        '
        Me.GroupBoxSearch.Controls.Add(Me.DateTimePickerTo)
        Me.GroupBoxSearch.Controls.Add(Me.LabelTo)
        Me.GroupBoxSearch.Controls.Add(Me.DateTimePickerFrom)
        Me.GroupBoxSearch.Controls.Add(Me.LabelFrom)
        Me.GroupBoxSearch.Controls.Add(Me.ButtonClear)
        Me.GroupBoxSearch.Controls.Add(Me.ButtonSearch)
        Me.GroupBoxSearch.Controls.Add(Me.TextBoxSearch)
        Me.GroupBoxSearch.Controls.Add(Me.ComboBoxSearch)
        Me.GroupBoxSearch.Controls.Add(Me.LabelSearch)
        Me.GroupBoxSearch.Location = New System.Drawing.Point(12, 6)
        Me.GroupBoxSearch.Name = "GroupBoxSearch"
        Me.GroupBoxSearch.Size = New System.Drawing.Size(760, 84)
        Me.GroupBoxSearch.TabIndex = 0
        Me.GroupBoxSearch.TabStop = False
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
        'GroupBoxCallhst
        '
        Me.GroupBoxCallhst.Controls.Add(Me.DataGridViewCallhst)
        Me.GroupBoxCallhst.Location = New System.Drawing.Point(12, 95)
        Me.GroupBoxCallhst.Name = "GroupBoxCallhst"
        Me.GroupBoxCallhst.Size = New System.Drawing.Size(760, 292)
        Me.GroupBoxCallhst.TabIndex = 1
        Me.GroupBoxCallhst.TabStop = False
        '
        'DataGridViewCallhst
        '
        Me.DataGridViewCallhst.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewCallhst.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.No, Me.Caller, Me.Direction, Me.codate, Me.time, Me.Duration, Me.Agent})
        Me.DataGridViewCallhst.Location = New System.Drawing.Point(7, 16)
        Me.DataGridViewCallhst.Name = "DataGridViewCallhst"
        Me.DataGridViewCallhst.Size = New System.Drawing.Size(745, 267)
        Me.DataGridViewCallhst.TabIndex = 0
        '
        'No
        '
        Me.No.HeaderText = "No"
        Me.No.Name = "No"
        Me.No.Width = 50
        '
        'Caller
        '
        Me.Caller.HeaderText = "Caller"
        Me.Caller.Name = "Caller"
        Me.Caller.Width = 195
        '
        'Direction
        '
        Me.Direction.HeaderText = "Direction"
        Me.Direction.Name = "Direction"
        Me.Direction.Width = 50
        '
        'codate
        '
        Me.codate.HeaderText = "Date"
        Me.codate.Name = "codate"
        '
        'time
        '
        Me.time.HeaderText = "Time"
        Me.time.Name = "time"
        '
        'Duration
        '
        Me.Duration.HeaderText = "Duration"
        Me.Duration.Name = "Duration"
        '
        'Agent
        '
        Me.Agent.HeaderText = "Agent"
        Me.Agent.Name = "Agent"
        Me.Agent.Width = 150
        '
        'CallHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 411)
        Me.Controls.Add(Me.GroupBoxCallhst)
        Me.Controls.Add(Me.GroupBoxSearch)
        Me.Name = "CallHistory"
        Me.Text = "Call History"
        Me.GroupBoxSearch.ResumeLayout(False)
        Me.GroupBoxSearch.PerformLayout()
        Me.GroupBoxCallhst.ResumeLayout(False)
        CType(Me.DataGridViewCallhst, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBoxSearch As System.Windows.Forms.GroupBox
    Friend WithEvents ComboBoxSearch As System.Windows.Forms.ComboBox
    Friend WithEvents LabelSearch As System.Windows.Forms.Label
    Friend WithEvents ButtonClear As System.Windows.Forms.Button
    Friend WithEvents ButtonSearch As System.Windows.Forms.Button
    Friend WithEvents TextBoxSearch As System.Windows.Forms.TextBox
    Friend WithEvents LabelFrom As System.Windows.Forms.Label
    Friend WithEvents DateTimePickerTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents LabelTo As System.Windows.Forms.Label
    Friend WithEvents DateTimePickerFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBoxCallhst As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridViewCallhst As System.Windows.Forms.DataGridView
    Friend WithEvents No As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Caller As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Direction As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents codate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents time As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Duration As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Agent As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
