Partial Public Class BugReporterForm
  Inherits System.Windows.Forms.Form

  <System.Diagnostics.DebuggerNonUserCode()> _
  Public Sub New()
    MyBase.New()

    'This call is required by the Windows Form Designer.
    InitializeComponent()

  End Sub

  'Form overrides dispose to clean up the component list.
  <System.Diagnostics.DebuggerNonUserCode()> _
  Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
    If disposing AndAlso components IsNot Nothing Then
      components.Dispose()
    End If
    MyBase.Dispose(disposing)
  End Sub

  'Required by the Windows Form Designer
  Private components As System.ComponentModel.IContainer

  'NOTE: The following procedure is required by the Windows Form Designer
  'It can be modified using the Windows Form Designer.  
  'Do not modify it using the code editor.
  <System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
    Me.txtTester = New System.Windows.Forms.TextBox
    Me.txtAppName = New System.Windows.Forms.TextBox
    Me.txtBuildNumber = New System.Windows.Forms.TextBox
    Me.txtDateReported = New System.Windows.Forms.TextBox
    Me.btnSubmitBug = New System.Windows.Forms.Button
    Me.lblTester = New System.Windows.Forms.Label
    Me.lblAppName = New System.Windows.Forms.Label
    Me.lblBuildNumber = New System.Windows.Forms.Label
    Me.lblDateReported = New System.Windows.Forms.Label
    Me.lblDescription = New System.Windows.Forms.Label
    Me.txtDescription = New System.Windows.Forms.TextBox
    Me.txtFileName = New System.Windows.Forms.TextBox
    Me.lblFileName = New System.Windows.Forms.Label
    Me.SuspendLayout()
    '
    'txtTester
    '
    Me.txtTester.Location = New System.Drawing.Point(19, 15)
    Me.txtTester.Name = "txtTester"
    Me.txtTester.Size = New System.Drawing.Size(244, 26)
    Me.txtTester.TabIndex = 0
    '
    'txtAppName
    '
    Me.txtAppName.Location = New System.Drawing.Point(19, 51)
    Me.txtAppName.Name = "txtAppName"
    Me.txtAppName.Size = New System.Drawing.Size(244, 26)
    Me.txtAppName.TabIndex = 1
    '
    'txtBuildNumber
    '
    Me.txtBuildNumber.Location = New System.Drawing.Point(19, 88)
    Me.txtBuildNumber.Name = "txtBuildNumber"
    Me.txtBuildNumber.Size = New System.Drawing.Size(244, 26)
    Me.txtBuildNumber.TabIndex = 2
    '
    'txtDateReported
    '
    Me.txtDateReported.Location = New System.Drawing.Point(19, 124)
    Me.txtDateReported.Name = "txtDateReported"
    Me.txtDateReported.Size = New System.Drawing.Size(244, 26)
    Me.txtDateReported.TabIndex = 3
    '
    'btnSubmitBug
    '
    Me.btnSubmitBug.Location = New System.Drawing.Point(418, 393)
    Me.btnSubmitBug.Margin = New System.Windows.Forms.Padding(3, 3, 1, 3)
    Me.btnSubmitBug.Name = "btnSubmitBug"
    Me.btnSubmitBug.Size = New System.Drawing.Size(120, 33)
    Me.btnSubmitBug.TabIndex = 5
    Me.btnSubmitBug.Text = "Submit Bug"
    '
    'lblTester
    '
    Me.lblTester.AutoSize = True
    Me.lblTester.Location = New System.Drawing.Point(273, 15)
    Me.lblTester.Margin = New System.Windows.Forms.Padding(3, 3, 3, 1)
    Me.lblTester.Name = "lblTester"
    Me.lblTester.Size = New System.Drawing.Size(108, 20)
    Me.lblTester.TabIndex = 6
    Me.lblTester.Text = "Testers Name"
    '
    'lblAppName
    '
    Me.lblAppName.AutoSize = True
    Me.lblAppName.Location = New System.Drawing.Point(273, 51)
    Me.lblAppName.Margin = New System.Windows.Forms.Padding(3, 3, 3, 1)
    Me.lblAppName.Name = "lblAppName"
    Me.lblAppName.Size = New System.Drawing.Size(141, 20)
    Me.lblAppName.TabIndex = 7
    Me.lblAppName.Text = "Applications Name"
    '
    'lblBuildNumber
    '
    Me.lblBuildNumber.AutoSize = True
    Me.lblBuildNumber.Location = New System.Drawing.Point(273, 88)
    Me.lblBuildNumber.Margin = New System.Windows.Forms.Padding(3, 1, 3, 3)
    Me.lblBuildNumber.Name = "lblBuildNumber"
    Me.lblBuildNumber.Size = New System.Drawing.Size(104, 20)
    Me.lblBuildNumber.TabIndex = 8
    Me.lblBuildNumber.Text = "Build Number"
    '
    'lblDateReported
    '
    Me.lblDateReported.AutoSize = True
    Me.lblDateReported.Location = New System.Drawing.Point(273, 124)
    Me.lblDateReported.Margin = New System.Windows.Forms.Padding(3, 1, 3, 3)
    Me.lblDateReported.Name = "lblDateReported"
    Me.lblDateReported.Size = New System.Drawing.Size(94, 20)
    Me.lblDateReported.TabIndex = 9
    Me.lblDateReported.Text = "Date Found"
    '
    'lblDescription
    '
    Me.lblDescription.AutoSize = True
    Me.lblDescription.Location = New System.Drawing.Point(19, 164)
    Me.lblDescription.Name = "lblDescription"
    Me.lblDescription.Size = New System.Drawing.Size(140, 20)
    Me.lblDescription.TabIndex = 10
    Me.lblDescription.Text = "Description of Bug"
    '
    'txtDescription
    '
    Me.txtDescription.Location = New System.Drawing.Point(19, 190)
    Me.txtDescription.Multiline = True
    Me.txtDescription.Name = "txtDescription"
    Me.txtDescription.Size = New System.Drawing.Size(516, 189)
    Me.txtDescription.TabIndex = 4
    '
    'txtFileName
    '
    Me.txtFileName.Location = New System.Drawing.Point(173, 396)
    Me.txtFileName.Margin = New System.Windows.Forms.Padding(1, 3, 3, 3)
    Me.txtFileName.Multiline = True
    Me.txtFileName.Name = "txtFileName"
    Me.txtFileName.Size = New System.Drawing.Size(221, 29)
    Me.txtFileName.TabIndex = 11
    Me.txtFileName.Text = "BugReport.csv"
    '
    'lblFileName
    '
    Me.lblFileName.AutoSize = True
    Me.lblFileName.Location = New System.Drawing.Point(18, 396)
    Me.lblFileName.Margin = New System.Windows.Forms.Padding(3, 3, 1, 3)
    Me.lblFileName.Name = "lblFileName"
    Me.lblFileName.Size = New System.Drawing.Size(120, 20)
    Me.lblFileName.TabIndex = 12
    Me.lblFileName.Text = "Save to this file:"
    '
    'BugReporterForm
    '
    Me.AutoScaleBaseSize = New System.Drawing.Size(8, 19)
    Me.ClientSize = New System.Drawing.Size(563, 442)
    Me.Controls.Add(Me.lblFileName)
    Me.Controls.Add(Me.txtFileName)
    Me.Controls.Add(Me.txtDescription)
    Me.Controls.Add(Me.lblDescription)
    Me.Controls.Add(Me.lblDateReported)
    Me.Controls.Add(Me.lblBuildNumber)
    Me.Controls.Add(Me.lblAppName)
    Me.Controls.Add(Me.lblTester)
    Me.Controls.Add(Me.btnSubmitBug)
    Me.Controls.Add(Me.txtDateReported)
    Me.Controls.Add(Me.txtBuildNumber)
    Me.Controls.Add(Me.txtAppName)
    Me.Controls.Add(Me.txtTester)
    Me.Name = "BugReporterForm"
    Me.Text = "Bug Reporter"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents txtTester As System.Windows.Forms.TextBox
  Friend WithEvents txtAppName As System.Windows.Forms.TextBox
  Friend WithEvents txtBuildNumber As System.Windows.Forms.TextBox
  Friend WithEvents txtDateReported As System.Windows.Forms.TextBox
  Friend WithEvents btnSubmitBug As System.Windows.Forms.Button
  Friend WithEvents lblTester As System.Windows.Forms.Label
  Friend WithEvents lblAppName As System.Windows.Forms.Label
  Friend WithEvents lblBuildNumber As System.Windows.Forms.Label
  Friend WithEvents lblDateReported As System.Windows.Forms.Label
  Friend WithEvents lblDescription As System.Windows.Forms.Label
  Friend WithEvents txtDescription As System.Windows.Forms.TextBox
  Friend WithEvents txtFileName As System.Windows.Forms.TextBox
  Friend WithEvents lblFileName As System.Windows.Forms.Label

End Class
