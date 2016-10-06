Partial Public Class frmTextRead
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
        Me.txtFile = New System.Windows.Forms.TextBox
        Me.txtFindString = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblResult = New System.Windows.Forms.Label
        Me.btnRead = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'txtFile
        '
        Me.txtFile.Location = New System.Drawing.Point(97, 77)
        Me.txtFile.Name = "txtFile"
        Me.txtFile.Size = New System.Drawing.Size(163, 22)
        Me.txtFile.TabIndex = 0
        Me.txtFile.Text = "c:\FiletoRead.txt"
        '
        'txtFindString
        '
        Me.txtFindString.Location = New System.Drawing.Point(97, 136)
        Me.txtFindString.Name = "txtFindString"
        Me.txtFindString.Size = New System.Drawing.Size(163, 22)
        Me.txtFindString.TabIndex = 1
        Me.txtFindString.Text = "error"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(97, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "&Enter file to search:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(97, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Enter string to &find:"
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Location = New System.Drawing.Point(97, 183)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(0, 17)
        Me.lblResult.TabIndex = 4
        '
        'btnRead
        '
        Me.btnRead.Location = New System.Drawing.Point(97, 224)
        Me.btnRead.Name = "btnRead"
        Me.btnRead.Size = New System.Drawing.Size(163, 34)
        Me.btnRead.TabIndex = 5
        Me.btnRead.Text = "&Search"
        '
        'frmTextRead
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(342, 309)
        Me.Controls.Add(Me.btnRead)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtFindString)
        Me.Controls.Add(Me.txtFile)
        Me.Name = "frmTextRead"
        Me.Text = "Text Read Utility"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtFile As System.Windows.Forms.TextBox
    Friend WithEvents txtFindString As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblResult As System.Windows.Forms.Label
    Friend WithEvents btnRead As System.Windows.Forms.Button

End Class
