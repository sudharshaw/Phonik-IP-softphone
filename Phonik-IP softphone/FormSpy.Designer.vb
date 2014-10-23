<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSpy
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
        Me.GroupBoxSpyBarge = New System.Windows.Forms.GroupBox()
        Me.LabelSelectAgent = New System.Windows.Forms.Label()
        Me.ComboBoxSelectAgent = New System.Windows.Forms.ComboBox()
        Me.ButtonBarge = New System.Windows.Forms.Button()
        Me.ButtonSpy = New System.Windows.Forms.Button()
        Me.GroupBoxSpyBarge.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBoxSpyBarge
        '
        Me.GroupBoxSpyBarge.Controls.Add(Me.ButtonSpy)
        Me.GroupBoxSpyBarge.Controls.Add(Me.ButtonBarge)
        Me.GroupBoxSpyBarge.Controls.Add(Me.ComboBoxSelectAgent)
        Me.GroupBoxSpyBarge.Controls.Add(Me.LabelSelectAgent)
        Me.GroupBoxSpyBarge.Location = New System.Drawing.Point(12, 12)
        Me.GroupBoxSpyBarge.Name = "GroupBoxSpyBarge"
        Me.GroupBoxSpyBarge.Size = New System.Drawing.Size(316, 154)
        Me.GroupBoxSpyBarge.TabIndex = 0
        Me.GroupBoxSpyBarge.TabStop = False
        Me.GroupBoxSpyBarge.Text = "Barge / Spy Call"
        '
        'LabelSelectAgent
        '
        Me.LabelSelectAgent.AutoSize = True
        Me.LabelSelectAgent.Location = New System.Drawing.Point(6, 29)
        Me.LabelSelectAgent.Name = "LabelSelectAgent"
        Me.LabelSelectAgent.Size = New System.Drawing.Size(71, 13)
        Me.LabelSelectAgent.TabIndex = 0
        Me.LabelSelectAgent.Text = "Select Agent "
        '
        'ComboBoxSelectAgent
        '
        Me.ComboBoxSelectAgent.FormattingEnabled = True
        Me.ComboBoxSelectAgent.Location = New System.Drawing.Point(83, 26)
        Me.ComboBoxSelectAgent.Name = "ComboBoxSelectAgent"
        Me.ComboBoxSelectAgent.Size = New System.Drawing.Size(182, 21)
        Me.ComboBoxSelectAgent.TabIndex = 1
        '
        'ButtonBarge
        '
        Me.ButtonBarge.Location = New System.Drawing.Point(90, 75)
        Me.ButtonBarge.Name = "ButtonBarge"
        Me.ButtonBarge.Size = New System.Drawing.Size(75, 23)
        Me.ButtonBarge.TabIndex = 2
        Me.ButtonBarge.Text = "Barge"
        Me.ButtonBarge.UseVisualStyleBackColor = True
        '
        'ButtonSpy
        '
        Me.ButtonSpy.Location = New System.Drawing.Point(185, 75)
        Me.ButtonSpy.Name = "ButtonSpy"
        Me.ButtonSpy.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSpy.TabIndex = 3
        Me.ButtonSpy.Text = "Spy"
        Me.ButtonSpy.UseVisualStyleBackColor = True
        '
        'FormSpy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(340, 178)
        Me.Controls.Add(Me.GroupBoxSpyBarge)
        Me.Name = "FormSpy"
        Me.Text = "Call Barge / Spy"
        Me.GroupBoxSpyBarge.ResumeLayout(False)
        Me.GroupBoxSpyBarge.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBoxSpyBarge As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonSpy As System.Windows.Forms.Button
    Friend WithEvents ButtonBarge As System.Windows.Forms.Button
    Friend WithEvents ComboBoxSelectAgent As System.Windows.Forms.ComboBox
    Friend WithEvents LabelSelectAgent As System.Windows.Forms.Label
End Class
