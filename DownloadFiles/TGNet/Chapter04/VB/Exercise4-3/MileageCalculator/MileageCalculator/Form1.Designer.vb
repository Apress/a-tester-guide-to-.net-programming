Partial Public Class Form1
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
    Me.txtDistance = New System.Windows.Forms.TextBox
    Me.btnGetMileage = New System.Windows.Forms.Button
    Me.txtGallons = New System.Windows.Forms.TextBox
    Me.lblDistance = New System.Windows.Forms.Label
    Me.lblGallons = New System.Windows.Forms.Label
    Me.SuspendLayout()
    '
    'txtDistance
    '
    Me.txtDistance.Location = New System.Drawing.Point(119, 11)
    Me.txtDistance.Margin = New System.Windows.Forms.Padding(1, 3, 3, 3)
    Me.txtDistance.Name = "txtDistance"
    Me.txtDistance.Size = New System.Drawing.Size(140, 26)
    Me.txtDistance.TabIndex = 0
    Me.txtDistance.Text = "100"
    '
    'btnGetMileage
    '
    Me.btnGetMileage.Location = New System.Drawing.Point(154, 119)
    Me.btnGetMileage.Name = "btnGetMileage"
    Me.btnGetMileage.Size = New System.Drawing.Size(105, 34)
    Me.btnGetMileage.TabIndex = 2
    Me.btnGetMileage.Text = "Get Mileage"
    '
    'txtGallons
    '
    Me.txtGallons.Location = New System.Drawing.Point(119, 60)
    Me.txtGallons.Name = "txtGallons"
    Me.txtGallons.Size = New System.Drawing.Size(140, 26)
    Me.txtGallons.TabIndex = 1
    Me.txtGallons.Text = "10"
    '
    'lblDistance
    '
    Me.lblDistance.AutoSize = True
    Me.lblDistance.Location = New System.Drawing.Point(48, 20)
    Me.lblDistance.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
    Me.lblDistance.Name = "lblDistance"
    Me.lblDistance.Size = New System.Drawing.Size(70, 21)
    Me.lblDistance.TabIndex = 3
    Me.lblDistance.Text = "Distance"
    '
    'lblGallons
    '
    Me.lblGallons.AutoSize = True
    Me.lblGallons.Location = New System.Drawing.Point(58, 69)
    Me.lblGallons.Name = "lblGallons"
    Me.lblGallons.Size = New System.Drawing.Size(62, 21)
    Me.lblGallons.TabIndex = 4
    Me.lblGallons.Text = "Gallons"
    '
    'Form1
    '
    Me.AutoScaleBaseSize = New System.Drawing.Size(7, 19)
    Me.ClientSize = New System.Drawing.Size(355, 159)
    Me.Controls.Add(Me.lblGallons)
    Me.Controls.Add(Me.lblDistance)
    Me.Controls.Add(Me.txtGallons)
    Me.Controls.Add(Me.btnGetMileage)
    Me.Controls.Add(Me.txtDistance)
    Me.Name = "Form1"
    Me.Text = "Mileage Calculator"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents txtDistance As System.Windows.Forms.TextBox
  Friend WithEvents btnGetMileage As System.Windows.Forms.Button
  Friend WithEvents txtGallons As System.Windows.Forms.TextBox
  Friend WithEvents lblDistance As System.Windows.Forms.Label
  Friend WithEvents lblGallons As System.Windows.Forms.Label

End Class
