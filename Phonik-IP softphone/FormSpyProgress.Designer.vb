<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSpyProgress
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
        Me.LabelDuration = New System.Windows.Forms.Label()
        Me.LabelBargingAgent = New System.Windows.Forms.Label()
        Me.LabelAgentName = New System.Windows.Forms.Label()
        Me.ButtonStop = New System.Windows.Forms.Button()
        Me.ButtonSpy = New System.Windows.Forms.Button()
        Me.GroupBoxSpyBarge.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBoxSpyBarge
        '
        Me.GroupBoxSpyBarge.Controls.Add(Me.ButtonSpy)
        Me.GroupBoxSpyBarge.Controls.Add(Me.ButtonStop)
        Me.GroupBoxSpyBarge.Controls.Add(Me.LabelAgentName)
        Me.GroupBoxSpyBarge.Controls.Add(Me.LabelBargingAgent)
        Me.GroupBoxSpyBarge.Controls.Add(Me.LabelDuration)
        Me.GroupBoxSpyBarge.Location = New System.Drawing.Point(12, 12)
        Me.GroupBoxSpyBarge.Name = "GroupBoxSpyBarge"
        Me.GroupBoxSpyBarge.Size = New System.Drawing.Size(260, 143)
        Me.GroupBoxSpyBarge.TabIndex = 0
        Me.GroupBoxSpyBarge.TabStop = False
        Me.GroupBoxSpyBarge.Text = "Barge / Spy Call"
        '
        'LabelDuration
        '
        Me.LabelDuration.AutoSize = True
        Me.LabelDuration.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDuration.ForeColor = System.Drawing.Color.Red
        Me.LabelDuration.Location = New System.Drawing.Point(88, 70)
        Me.LabelDuration.Name = "LabelDuration"
        Me.LabelDuration.Size = New System.Drawing.Size(51, 20)
        Me.LabelDuration.TabIndex = 1
        Me.LabelDuration.Text = "TIME"
        '
        'LabelBargingAgent
        '
        Me.LabelBargingAgent.AutoSize = True
        Me.LabelBargingAgent.Location = New System.Drawing.Point(6, 44)
        Me.LabelBargingAgent.Name = "LabelBargingAgent"
        Me.LabelBargingAgent.Size = New System.Drawing.Size(83, 13)
        Me.LabelBargingAgent.TabIndex = 1
        Me.LabelBargingAgent.Text = "Barging Agent : "
        '
        'LabelAgentName
        '
        Me.LabelAgentName.AutoSize = True
        Me.LabelAgentName.Location = New System.Drawing.Point(89, 44)
        Me.LabelAgentName.Name = "LabelAgentName"
        Me.LabelAgentName.Size = New System.Drawing.Size(66, 13)
        Me.LabelAgentName.TabIndex = 2
        Me.LabelAgentName.Text = "Agnet Name"
        '
        'ButtonStop
        '
        Me.ButtonStop.Location = New System.Drawing.Point(92, 104)
        Me.ButtonStop.Name = "ButtonStop"
        Me.ButtonStop.Size = New System.Drawing.Size(75, 23)
        Me.ButtonStop.TabIndex = 1
        Me.ButtonStop.Text = "STOP"
        Me.ButtonStop.UseVisualStyleBackColor = True
        '
        'ButtonSpy
        '
        Me.ButtonSpy.Location = New System.Drawing.Point(173, 104)
        Me.ButtonSpy.Name = "ButtonSpy"
        Me.ButtonSpy.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSpy.TabIndex = 3
        Me.ButtonSpy.Text = "SPY"
        Me.ButtonSpy.UseVisualStyleBackColor = True
        '
        'FormSpyProgress
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 167)
        Me.Controls.Add(Me.GroupBoxSpyBarge)
        Me.Name = "FormSpyProgress"
        Me.Text = "FormSpyProgress"
        Me.GroupBoxSpyBarge.ResumeLayout(False)
        Me.GroupBoxSpyBarge.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBoxSpyBarge As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonSpy As System.Windows.Forms.Button
    Friend WithEvents ButtonStop As System.Windows.Forms.Button
    Friend WithEvents LabelAgentName As System.Windows.Forms.Label
    Friend WithEvents LabelBargingAgent As System.Windows.Forms.Label
    Friend WithEvents LabelDuration As System.Windows.Forms.Label
End Class
