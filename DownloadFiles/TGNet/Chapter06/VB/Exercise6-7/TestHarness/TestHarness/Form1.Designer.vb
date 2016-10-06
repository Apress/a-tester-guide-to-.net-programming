<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
    Me.txtFileName = New System.Windows.Forms.TextBox
    Me.btnTest = New System.Windows.Forms.Button
    Me.lblFileName = New System.Windows.Forms.Label
    Me.SuspendLayout()
    '
    'txtFileName
    '
    Me.txtFileName.Location = New System.Drawing.Point(12, 28)
    Me.txtFileName.Name = "txtFileName"
    Me.txtFileName.Size = New System.Drawing.Size(266, 26)
    Me.txtFileName.TabIndex = 0
    '
    'btnTest
    '
    Me.btnTest.Location = New System.Drawing.Point(12, 73)
    Me.btnTest.Name = "btnTest"
    Me.btnTest.Size = New System.Drawing.Size(266, 33)
    Me.btnTest.TabIndex = 1
    Me.btnTest.Text = "Test"
    Me.btnTest.UseVisualStyleBackColor = True
    '
    'lblFileName
    '
    Me.lblFileName.AutoSize = True
    Me.lblFileName.Location = New System.Drawing.Point(12, 4)
    Me.lblFileName.Name = "lblFileName"
    Me.lblFileName.Size = New System.Drawing.Size(80, 20)
    Me.lblFileName.TabIndex = 2
    Me.lblFileName.Text = "File Name"
    '
    'Form1
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(290, 126)
    Me.Controls.Add(Me.lblFileName)
    Me.Controls.Add(Me.btnTest)
    Me.Controls.Add(Me.txtFileName)
    Me.Name = "Form1"
    Me.Text = "Form1"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents txtFileName As System.Windows.Forms.TextBox
  Friend WithEvents btnTest As System.Windows.Forms.Button
  Friend WithEvents lblFileName As System.Windows.Forms.Label

End Class
