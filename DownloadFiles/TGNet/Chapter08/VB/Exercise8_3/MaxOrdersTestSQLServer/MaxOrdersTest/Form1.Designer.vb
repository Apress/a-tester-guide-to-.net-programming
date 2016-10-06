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
        Me.cmdADO = New System.Windows.Forms.Button
        Me.lstResults = New System.Windows.Forms.ListBox
        Me.SuspendLayout()
        '
        'cmdADO
        '
        Me.cmdADO.Location = New System.Drawing.Point(82, 225)
        Me.cmdADO.Name = "cmdADO"
        Me.cmdADO.Size = New System.Drawing.Size(135, 23)
        Me.cmdADO.TabIndex = 0
        Me.cmdADO.Text = "Start Test"
        '
        'lstResults
        '
        Me.lstResults.FormattingEnabled = True
        Me.lstResults.ItemHeight = 16
        Me.lstResults.Location = New System.Drawing.Point(13, 2)
        Me.lstResults.Name = "lstResults"
        Me.lstResults.ScrollAlwaysVisible = True
        Me.lstResults.Size = New System.Drawing.Size(267, 212)
        Me.lstResults.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 260)
        Me.Controls.Add(Me.lstResults)
        Me.Controls.Add(Me.cmdADO)
        Me.Name = "Form1"
        Me.Text = "Max Orders Test"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdADO As System.Windows.Forms.Button
    Friend WithEvents lstResults As System.Windows.Forms.ListBox

End Class
