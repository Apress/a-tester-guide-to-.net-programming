Partial Class frmTestCalc
#Region "Windows Form Designer generated code "
	<System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
		MyBase.New()
		'This call is required by the Windows Form Designer.
		InitializeComponent()
	End Sub
	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
		If Disposing Then
			If Not components Is Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(Disposing)
	End Sub
	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer
	Public ToolTip1 As System.Windows.Forms.ToolTip
	Public WithEvents cmdLog As System.Windows.Forms.Button
	Public WithEvents cmdTest As System.Windows.Forms.Button
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents lblTime As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough(), System.Diagnostics.DebuggerNonUserCode()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmdLog = New System.Windows.Forms.Button
        Me.cmdTest = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblTime = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'cmdLog
        '
        Me.cmdLog.BackColor = System.Drawing.SystemColors.Control
        Me.cmdLog.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdLog.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLog.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdLog.Location = New System.Drawing.Point(120, 80)
        Me.cmdLog.Name = "cmdLog"
        Me.cmdLog.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdLog.Size = New System.Drawing.Size(81, 33)
        Me.cmdLog.TabIndex = 1
        Me.cmdLog.Text = "View Log"
        Me.cmdLog.UseVisualStyleBackColor = False
        '
        'cmdTest
        '
        Me.cmdTest.BackColor = System.Drawing.SystemColors.Control
        Me.cmdTest.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdTest.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdTest.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdTest.Location = New System.Drawing.Point(120, 32)
        Me.cmdTest.Name = "cmdTest"
        Me.cmdTest.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdTest.Size = New System.Drawing.Size(81, 33)
        Me.cmdTest.TabIndex = 0
        Me.cmdTest.Text = "Test Calc"
        Me.cmdTest.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(72, 192)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(81, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Elapsed Time:"
        '
        'lblTime
        '
        Me.lblTime.BackColor = System.Drawing.SystemColors.Control
        Me.lblTime.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTime.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTime.Location = New System.Drawing.Point(168, 192)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTime.Size = New System.Drawing.Size(137, 17)
        Me.lblTime.TabIndex = 2
        '
        'frmTestCalc
        '
        Me.AcceptButton = Me.cmdTest
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(312, 212)
        Me.Controls.Add(Me.cmdLog)
        Me.Controls.Add(Me.cmdTest)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblTime)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Location = New System.Drawing.Point(4, 24)
        Me.Name = "frmTestCalc"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "Calculator Testing"
        Me.ResumeLayout(False)

    End Sub
#End Region 
End Class