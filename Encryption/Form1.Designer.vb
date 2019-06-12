<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnEncrypt = New System.Windows.Forms.Button()
        Me.btnDecrypt = New System.Windows.Forms.Button()
        Me.clrButton = New System.Windows.Forms.Button()
        Me.dupButton = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.dlgSave = New System.Windows.Forms.SaveFileDialog()
        Me.dlgOpen = New System.Windows.Forms.OpenFileDialog()
        Me.btnOpen = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(256, 71)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(256, 117)
        Me.TextBox1.TabIndex = 0
        '
        'btnEncrypt
        '
        Me.btnEncrypt.Location = New System.Drawing.Point(201, 247)
        Me.btnEncrypt.Name = "btnEncrypt"
        Me.btnEncrypt.Size = New System.Drawing.Size(91, 40)
        Me.btnEncrypt.TabIndex = 1
        Me.btnEncrypt.Text = "Encrypt"
        Me.btnEncrypt.UseVisualStyleBackColor = True
        '
        'btnDecrypt
        '
        Me.btnDecrypt.Location = New System.Drawing.Point(493, 247)
        Me.btnDecrypt.Name = "btnDecrypt"
        Me.btnDecrypt.Size = New System.Drawing.Size(91, 40)
        Me.btnDecrypt.TabIndex = 2
        Me.btnDecrypt.Text = "Decrypt"
        Me.btnDecrypt.UseVisualStyleBackColor = True
        '
        'clrButton
        '
        Me.clrButton.Location = New System.Drawing.Point(624, 329)
        Me.clrButton.Name = "clrButton"
        Me.clrButton.Size = New System.Drawing.Size(89, 42)
        Me.clrButton.TabIndex = 3
        Me.clrButton.Text = "Clear"
        Me.clrButton.UseVisualStyleBackColor = True
        '
        'dupButton
        '
        Me.dupButton.Location = New System.Drawing.Point(61, 87)
        Me.dupButton.Name = "dupButton"
        Me.dupButton.Size = New System.Drawing.Size(116, 55)
        Me.dupButton.TabIndex = 4
        Me.dupButton.Text = "Duplicate"
        Me.dupButton.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(624, 134)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(110, 64)
        Me.btnSave.TabIndex = 5
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'dlgOpen
        '
        Me.dlgOpen.FileName = "dlgOpen"
        '
        'btnOpen
        '
        Me.btnOpen.Location = New System.Drawing.Point(624, 46)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(110, 57)
        Me.btnOpen.TabIndex = 6
        Me.btnOpen.Text = "Open"
        Me.btnOpen.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnOpen)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.dupButton)
        Me.Controls.Add(Me.clrButton)
        Me.Controls.Add(Me.btnDecrypt)
        Me.Controls.Add(Me.btnEncrypt)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "Form1"
        Me.Text = "Encryption"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnEncrypt As Button
    Friend WithEvents btnDecrypt As Button
    Friend WithEvents clrButton As Button
    Friend WithEvents dupButton As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents dlgSave As SaveFileDialog
    Friend WithEvents dlgOpen As OpenFileDialog
    Friend WithEvents btnOpen As Button
End Class
