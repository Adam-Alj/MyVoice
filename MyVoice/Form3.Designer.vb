<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.exitBtn = New System.Windows.Forms.Button()
        Me.addBtn = New System.Windows.Forms.Button()
        Me.tlp = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.deleteBtn = New System.Windows.Forms.Button()
        Me.deltLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'exitBtn
        '
        Me.exitBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exitBtn.Location = New System.Drawing.Point(404, 671)
        Me.exitBtn.Name = "exitBtn"
        Me.exitBtn.Size = New System.Drawing.Size(115, 40)
        Me.exitBtn.TabIndex = 0
        Me.exitBtn.Text = "Close"
        Me.exitBtn.UseVisualStyleBackColor = True
        '
        'addBtn
        '
        Me.addBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addBtn.Location = New System.Drawing.Point(12, 671)
        Me.addBtn.Name = "addBtn"
        Me.addBtn.Size = New System.Drawing.Size(41, 40)
        Me.addBtn.TabIndex = 1
        Me.addBtn.Text = "+"
        Me.addBtn.UseVisualStyleBackColor = True
        '
        'tlp
        '
        Me.tlp.ColumnCount = 1
        Me.tlp.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlp.Location = New System.Drawing.Point(12, 39)
        Me.tlp.Name = "tlp"
        Me.tlp.RowCount = 2
        Me.tlp.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlp.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlp.Size = New System.Drawing.Size(504, 626)
        Me.tlp.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 25)
        Me.Label1.TabIndex = 3
        '
        'deleteBtn
        '
        Me.deleteBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deleteBtn.Location = New System.Drawing.Point(59, 671)
        Me.deleteBtn.Name = "deleteBtn"
        Me.deleteBtn.Size = New System.Drawing.Size(41, 40)
        Me.deleteBtn.TabIndex = 4
        Me.deleteBtn.Text = "-"
        Me.deleteBtn.UseVisualStyleBackColor = True
        '
        'deltLabel
        '
        Me.deltLabel.AutoSize = True
        Me.deltLabel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.deltLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deltLabel.Location = New System.Drawing.Point(106, 679)
        Me.deltLabel.Name = "deltLabel"
        Me.deltLabel.Size = New System.Drawing.Size(294, 24)
        Me.deltLabel.TabIndex = 5
        Me.deltLabel.Text = "Select the VoiceNote to delete"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.IndianRed
        Me.ClientSize = New System.Drawing.Size(530, 716)
        Me.Controls.Add(Me.deltLabel)
        Me.Controls.Add(Me.deleteBtn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tlp)
        Me.Controls.Add(Me.addBtn)
        Me.Controls.Add(Me.exitBtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents exitBtn As Button
    Friend WithEvents addBtn As Button
    Friend WithEvents tlp As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents deleteBtn As Button
    Friend WithEvents deltLabel As Label
End Class
