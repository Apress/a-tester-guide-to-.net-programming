<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class Form1
    Inherits System.Windows.Forms.Form

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
        Me.btnStartApp = New System.Windows.Forms.Button
        Me.txtAppname = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'btnStartApp
        '
        Me.btnStartApp.Location = New System.Drawing.Point(80, 52)
        Me.btnStartApp.Name = "btnStartApp"
        Me.btnStartApp.Size = New System.Drawing.Size(100, 23)
        Me.btnStartApp.TabIndex = 0
        Me.btnStartApp.Text = "&Start Application"
        '
        'txtAppname
        '
        Me.txtAppname.Location = New System.Drawing.Point(80, 26)
        Me.txtAppname.Name = "txtAppname"
        Me.txtAppname.Size = New System.Drawing.Size(100, 20)
        Me.txtAppname.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(269, 103)
        Me.Controls.Add(Me.txtAppname)
        Me.Controls.Add(Me.btnStartApp)
        Me.Name = "Form1"
        Me.Text = "AutoTester"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnStartApp As System.Windows.Forms.Button
    Friend WithEvents txtAppname As System.Windows.Forms.TextBox

End Class
