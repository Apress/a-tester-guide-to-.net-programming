Partial Class frmSendKeys
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
	Public WithEvents cmdSendKeys As System.Windows.Forms.Button
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough(), System.Diagnostics.DebuggerNonUserCode()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmSendKeys))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.cmdSendKeys = New System.Windows.Forms.Button
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		Me.BackColor = System.Drawing.Color.FromARGB(192, 255, 192)
		Me.Text = "Send Keys example"
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
		Me.Name = "frmSendKeys"
		Me.cmdSendKeys.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdSendKeys.Text = "Run Demo"
		Me.cmdSendKeys.Size = New System.Drawing.Size(81, 33)
		Me.cmdSendKeys.Location = New System.Drawing.Point(120, 88)
		Me.cmdSendKeys.TabIndex = 0
		Me.cmdSendKeys.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdSendKeys.BackColor = System.Drawing.SystemColors.Control
		Me.cmdSendKeys.CausesValidation = True
		Me.cmdSendKeys.Enabled = True
		Me.cmdSendKeys.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdSendKeys.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdSendKeys.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdSendKeys.TabStop = True
		Me.cmdSendKeys.Name = "cmdSendKeys"
		Me.Controls.Add(cmdSendKeys)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class