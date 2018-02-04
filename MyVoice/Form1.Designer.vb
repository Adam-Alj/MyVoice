<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form))
        Me.exitBtn = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.helpBtn = New System.Windows.Forms.Button()
        Me.addVGBtn = New System.Windows.Forms.Button()
        Me.vgGrid = New System.Windows.Forms.FlowLayoutPanel()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.deleteVGBTN = New System.Windows.Forms.Button()
        Me.deleteInstruction = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'exitBtn
        '
        Me.exitBtn.BackColor = System.Drawing.Color.MistyRose
        Me.exitBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exitBtn.Location = New System.Drawing.Point(1084, 0)
        Me.exitBtn.Name = "exitBtn"
        Me.exitBtn.Size = New System.Drawing.Size(39, 34)
        Me.exitBtn.TabIndex = 0
        Me.exitBtn.Text = "X"
        Me.exitBtn.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(340, 84)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'helpBtn
        '
        Me.helpBtn.BackColor = System.Drawing.Color.MistyRose
        Me.helpBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.helpBtn.Location = New System.Drawing.Point(1027, 57)
        Me.helpBtn.Name = "helpBtn"
        Me.helpBtn.Size = New System.Drawing.Size(84, 39)
        Me.helpBtn.TabIndex = 2
        Me.helpBtn.Text = "HELP"
        Me.helpBtn.UseVisualStyleBackColor = False
        '
        'addVGBtn
        '
        Me.addVGBtn.BackColor = System.Drawing.Color.MistyRose
        Me.addVGBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addVGBtn.Location = New System.Drawing.Point(391, 12)
        Me.addVGBtn.Name = "addVGBtn"
        Me.addVGBtn.Size = New System.Drawing.Size(360, 40)
        Me.addVGBtn.TabIndex = 3
        Me.addVGBtn.Text = "Add Group"
        Me.addVGBtn.UseVisualStyleBackColor = False
        '
        'vgGrid
        '
        Me.vgGrid.Location = New System.Drawing.Point(21, 136)
        Me.vgGrid.Name = "vgGrid"
        Me.vgGrid.Size = New System.Drawing.Size(1089, 561)
        Me.vgGrid.TabIndex = 4
        '
        'deleteVGBTN
        '
        Me.deleteVGBTN.BackColor = System.Drawing.Color.MistyRose
        Me.deleteVGBTN.Cursor = System.Windows.Forms.Cursors.Default
        Me.deleteVGBTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deleteVGBTN.Location = New System.Drawing.Point(391, 58)
        Me.deleteVGBTN.Name = "deleteVGBTN"
        Me.deleteVGBTN.Size = New System.Drawing.Size(360, 40)
        Me.deleteVGBTN.TabIndex = 5
        Me.deleteVGBTN.Text = "Delete Group"
        Me.deleteVGBTN.UseVisualStyleBackColor = False
        '
        'deleteInstruction
        '
        Me.deleteInstruction.AutoSize = True
        Me.deleteInstruction.BackColor = System.Drawing.Color.WhiteSmoke
        Me.deleteInstruction.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deleteInstruction.Location = New System.Drawing.Point(762, 20)
        Me.deleteInstruction.Name = "deleteInstruction"
        Me.deleteInstruction.Size = New System.Drawing.Size(259, 100)
        Me.deleteInstruction.TabIndex = 6
        Me.deleteInstruction.Text = "Click on the Group that" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "you want to remove." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Click 'Delete Group' again" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "to canc" &
    "el deletion." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightCoral
        Me.ClientSize = New System.Drawing.Size(1123, 716)
        Me.ControlBox = False
        Me.Controls.Add(Me.deleteInstruction)
        Me.Controls.Add(Me.deleteVGBTN)
        Me.Controls.Add(Me.vgGrid)
        Me.Controls.Add(Me.addVGBtn)
        Me.Controls.Add(Me.helpBtn)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.exitBtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents exitBtn As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents helpBtn As Button
    Friend WithEvents addVGBtn As Button
    Friend WithEvents vgGrid As FlowLayoutPanel
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents deleteVGBTN As Button
    Friend WithEvents deleteInstruction As Label
End Class
