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
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmTestCalc))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.cmdLog = New System.Windows.Forms.Button
		Me.cmdTest = New System.Windows.Forms.Button
		Me.Label2 = New System.Windows.Forms.Label
		Me.lblTime = New System.Windows.Forms.Label
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		Me.BackColor = System.Drawing.Color.FromARGB(192, 192, 255)
		Me.Text = "Calculator Testing"
		Me.ClientSize = New System.Drawing.Size(312, 212)
		Me.Location = New System.Drawing.Point(4, 24)
		Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation
		Me.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable
		Me.ControlBox = True
		Me.Enabled = True
		Me.KeyPreview = False
		Me.MaximizeBox = True
		Me.MinimizeBox = True
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ShowInTaskbar = True
		Me.HelpButton = False
		Me.WindowState = System.Windows.Forms.FormWindowState.Normal
		Me.Name = "frmTestCalc"
		Me.cmdLog.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdLog.Text = "View Log"
		Me.cmdLog.Size = New System.Drawing.Size(81, 33)
		Me.cmdLog.Location = New System.Drawing.Point(120, 80)
		Me.cmdLog.TabIndex = 1
		Me.cmdLog.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdLog.BackColor = System.Drawing.SystemColors.Control
		Me.cmdLog.CausesValidation = True
		Me.cmdLog.Enabled = True
		Me.cmdLog.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdLog.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdLog.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdLog.TabStop = True
		Me.cmdLog.Name = "cmdLog"
		Me.cmdTest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdTest.Text = "Test Calc"
		Me.cmdTest.Size = New System.Drawing.Size(81, 33)
		Me.cmdTest.Location = New System.Drawing.Point(120, 32)
		Me.cmdTest.TabIndex = 0
		Me.cmdTest.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdTest.BackColor = System.Drawing.SystemColors.Control
		Me.cmdTest.CausesValidation = True
		Me.cmdTest.Enabled = True
		Me.cmdTest.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdTest.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdTest.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdTest.TabStop = True
		Me.cmdTest.Name = "cmdTest"
		Me.Label2.Text = "Elapsed Time:"
		Me.Label2.Size = New System.Drawing.Size(81, 17)
		Me.Label2.Location = New System.Drawing.Point(72, 192)
		Me.Label2.TabIndex = 3
		Me.Label2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label2.BackColor = System.Drawing.SystemColors.Control
		Me.Label2.Enabled = True
		Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label2.UseMnemonic = True
		Me.Label2.Visible = True
		Me.Label2.AutoSize = False
		Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label2.Name = "Label2"
		Me.lblTime.Size = New System.Drawing.Size(137, 17)
		Me.lblTime.Location = New System.Drawing.Point(168, 192)
		Me.lblTime.TabIndex = 2
		Me.lblTime.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblTime.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblTime.BackColor = System.Drawing.SystemColors.Control
		Me.lblTime.Enabled = True
		Me.lblTime.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblTime.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblTime.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblTime.UseMnemonic = True
		Me.lblTime.Visible = True
		Me.lblTime.AutoSize = False
		Me.lblTime.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblTime.Name = "lblTime"
		Me.Controls.Add(cmdLog)
		Me.Controls.Add(cmdTest)
		Me.Controls.Add(Label2)
		Me.Controls.Add(lblTime)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class