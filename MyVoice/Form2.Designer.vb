<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.cancelBtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.vgInputField = New System.Windows.Forms.TextBox()
        Me.okBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cancelBtn
        '
        Me.cancelBtn.BackColor = System.Drawing.Color.MistyRose
        Me.cancelBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancelBtn.Location = New System.Drawing.Point(311, 161)
        Me.cancelBtn.Name = "cancelBtn"
        Me.cancelBtn.Size = New System.Drawing.Size(97, 52)
        Me.cancelBtn.TabIndex = 0
        Me.cancelBtn.Text = "Cancel"
        Me.cancelBtn.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Font = New System.Drawing.Font("Georgia", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(53, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(381, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Enter a name for your VoiceGroup" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'vgInputField
        '
        Me.vgInputField.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vgInputField.Location = New System.Drawing.Point(79, 87)
        Me.vgInputField.MaxLength = 200
        Me.vgInputField.Name = "vgInputField"
        Me.vgInputField.Size = New System.Drawing.Size(329, 38)
        Me.vgInputField.TabIndex = 2
        '
        'okBtn
        '
        Me.okBtn.BackColor = System.Drawing.Color.MistyRose
        Me.okBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.okBtn.Location = New System.Drawing.Point(79, 161)
        Me.okBtn.Name = "okBtn"
        Me.okBtn.Size = New System.Drawing.Size(97, 52)
        Me.okBtn.TabIndex = 3
        Me.okBtn.Text = "OK"
        Me.okBtn.UseVisualStyleBackColor = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.IndianRed
        Me.ClientSize = New System.Drawing.Size(484, 237)
        Me.Controls.Add(Me.okBtn)
        Me.Controls.Add(Me.vgInputField)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cancelBtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cancelBtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents vgInputField As TextBox
    Friend WithEvents okBtn As Button
End Class
