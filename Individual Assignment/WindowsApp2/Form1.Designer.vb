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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SettingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BlackAndYellowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BlackAndGreenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NormalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lubeJobBox = New System.Windows.Forms.CheckBox()
        Me.oilChangeBox = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.tireBox = New System.Windows.Forms.CheckBox()
        Me.inspectionBox = New System.Windows.Forms.CheckBox()
        Me.mufflerBox = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.radiatorBox = New System.Windows.Forms.CheckBox()
        Me.transmissionBox = New System.Windows.Forms.CheckBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.laborBox = New System.Windows.Forms.TextBox()
        Me.partBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.totalfees_summary = New System.Windows.Forms.TextBox()
        Me.tax_summary = New System.Windows.Forms.TextBox()
        Me.part_summary = New System.Windows.Forms.TextBox()
        Me.serviceLabor_summary = New System.Windows.Forms.TextBox()
        Me.calculateButton = New System.Windows.Forms.Button()
        Me.clearButton = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SettingToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(911, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SettingToolStripMenuItem
        '
        Me.SettingToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BlackAndYellowToolStripMenuItem, Me.BlackAndGreenToolStripMenuItem, Me.NormalToolStripMenuItem})
        Me.SettingToolStripMenuItem.Name = "SettingToolStripMenuItem"
        Me.SettingToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.SettingToolStripMenuItem.Text = "Setting"
        '
        'BlackAndYellowToolStripMenuItem
        '
        Me.BlackAndYellowToolStripMenuItem.Name = "BlackAndYellowToolStripMenuItem"
        Me.BlackAndYellowToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.BlackAndYellowToolStripMenuItem.Text = "Black And Yellow"
        '
        'BlackAndGreenToolStripMenuItem
        '
        Me.BlackAndGreenToolStripMenuItem.Name = "BlackAndGreenToolStripMenuItem"
        Me.BlackAndGreenToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.BlackAndGreenToolStripMenuItem.Text = "Black And Green"
        '
        'NormalToolStripMenuItem
        '
        Me.NormalToolStripMenuItem.Name = "NormalToolStripMenuItem"
        Me.NormalToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.NormalToolStripMenuItem.Text = "Pink and Red"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(85, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(759, 73)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "AZWAN'S AUTOMOTIVE"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lubeJobBox)
        Me.GroupBox1.Controls.Add(Me.oilChangeBox)
        Me.GroupBox1.Location = New System.Drawing.Point(92, 129)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(336, 100)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Oil and Lube"
        '
        'lubeJobBox
        '
        Me.lubeJobBox.AutoSize = True
        Me.lubeJobBox.Location = New System.Drawing.Point(6, 56)
        Me.lubeJobBox.Name = "lubeJobBox"
        Me.lubeJobBox.Size = New System.Drawing.Size(108, 17)
        Me.lubeJobBox.TabIndex = 1
        Me.lubeJobBox.Text = "Lube Job - RM63"
        Me.lubeJobBox.UseVisualStyleBackColor = True
        '
        'oilChangeBox
        '
        Me.oilChangeBox.AutoSize = True
        Me.oilChangeBox.Location = New System.Drawing.Point(6, 33)
        Me.oilChangeBox.Name = "oilChangeBox"
        Me.oilChangeBox.Size = New System.Drawing.Size(124, 17)
        Me.oilChangeBox.TabIndex = 0
        Me.oilChangeBox.Text = "Oil and Lube - RM91"
        Me.oilChangeBox.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.tireBox)
        Me.GroupBox2.Controls.Add(Me.inspectionBox)
        Me.GroupBox2.Controls.Add(Me.mufflerBox)
        Me.GroupBox2.Location = New System.Drawing.Point(92, 266)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(336, 100)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Misc"
        '
        'tireBox
        '
        Me.tireBox.AutoSize = True
        Me.tireBox.Location = New System.Drawing.Point(6, 75)
        Me.tireBox.Name = "tireBox"
        Me.tireBox.Size = New System.Drawing.Size(125, 17)
        Me.tireBox.TabIndex = 6
        Me.tireBox.Text = "Tire Rotation - RM70"
        Me.tireBox.UseVisualStyleBackColor = True
        '
        'inspectionBox
        '
        Me.inspectionBox.AutoSize = True
        Me.inspectionBox.Location = New System.Drawing.Point(6, 29)
        Me.inspectionBox.Name = "inspectionBox"
        Me.inspectionBox.Size = New System.Drawing.Size(113, 17)
        Me.inspectionBox.TabIndex = 5
        Me.inspectionBox.Text = "Inspection - RM52"
        Me.inspectionBox.UseVisualStyleBackColor = True
        '
        'mufflerBox
        '
        Me.mufflerBox.AutoSize = True
        Me.mufflerBox.Location = New System.Drawing.Point(6, 52)
        Me.mufflerBox.Name = "mufflerBox"
        Me.mufflerBox.Size = New System.Drawing.Size(168, 17)
        Me.mufflerBox.TabIndex = 4
        Me.mufflerBox.Text = "Muffler Replacement - RM350"
        Me.mufflerBox.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.radiatorBox)
        Me.GroupBox3.Controls.Add(Me.transmissionBox)
        Me.GroupBox3.Location = New System.Drawing.Point(465, 129)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(345, 100)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Flushes"
        '
        'radiatorBox
        '
        Me.radiatorBox.AutoSize = True
        Me.radiatorBox.Location = New System.Drawing.Point(6, 33)
        Me.radiatorBox.Name = "radiatorBox"
        Me.radiatorBox.Size = New System.Drawing.Size(132, 17)
        Me.radiatorBox.TabIndex = 3
        Me.radiatorBox.Text = "Radiator Flus - RM105"
        Me.radiatorBox.UseVisualStyleBackColor = True
        '
        'transmissionBox
        '
        Me.transmissionBox.AutoSize = True
        Me.transmissionBox.Location = New System.Drawing.Point(6, 56)
        Me.transmissionBox.Name = "transmissionBox"
        Me.transmissionBox.Size = New System.Drawing.Size(159, 17)
        Me.transmissionBox.TabIndex = 2
        Me.transmissionBox.Text = "Transmission Flush - RM280"
        Me.transmissionBox.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.laborBox)
        Me.GroupBox4.Controls.Add(Me.partBox)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Location = New System.Drawing.Point(465, 266)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(345, 100)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Parts and Labor"
        '
        'laborBox
        '
        Me.laborBox.Location = New System.Drawing.Point(79, 53)
        Me.laborBox.Name = "laborBox"
        Me.laborBox.Size = New System.Drawing.Size(100, 20)
        Me.laborBox.TabIndex = 7
        '
        'partBox
        '
        Me.partBox.Location = New System.Drawing.Point(79, 30)
        Me.partBox.Name = "partBox"
        Me.partBox.Size = New System.Drawing.Size(100, 20)
        Me.partBox.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Labor"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Part"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label6)
        Me.GroupBox5.Controls.Add(Me.Label7)
        Me.GroupBox5.Controls.Add(Me.Label4)
        Me.GroupBox5.Controls.Add(Me.Label5)
        Me.GroupBox5.Controls.Add(Me.totalfees_summary)
        Me.GroupBox5.Controls.Add(Me.tax_summary)
        Me.GroupBox5.Controls.Add(Me.part_summary)
        Me.GroupBox5.Controls.Add(Me.serviceLabor_summary)
        Me.GroupBox5.Location = New System.Drawing.Point(197, 394)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(495, 177)
        Me.GroupBox5.TabIndex = 4
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Summary"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(144, 116)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Total Fees  : RM"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(133, 93)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Tax (on parts) : RM"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(178, 71)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Part : RM"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(132, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Service Labor : RM"
        '
        'totalfees_summary
        '
        Me.totalfees_summary.Location = New System.Drawing.Point(245, 113)
        Me.totalfees_summary.Name = "totalfees_summary"
        Me.totalfees_summary.Size = New System.Drawing.Size(100, 20)
        Me.totalfees_summary.TabIndex = 11
        '
        'tax_summary
        '
        Me.tax_summary.Location = New System.Drawing.Point(245, 90)
        Me.tax_summary.Name = "tax_summary"
        Me.tax_summary.Size = New System.Drawing.Size(100, 20)
        Me.tax_summary.TabIndex = 10
        '
        'part_summary
        '
        Me.part_summary.Location = New System.Drawing.Point(245, 68)
        Me.part_summary.Name = "part_summary"
        Me.part_summary.Size = New System.Drawing.Size(100, 20)
        Me.part_summary.TabIndex = 9
        '
        'serviceLabor_summary
        '
        Me.serviceLabor_summary.Location = New System.Drawing.Point(245, 45)
        Me.serviceLabor_summary.Name = "serviceLabor_summary"
        Me.serviceLabor_summary.Size = New System.Drawing.Size(100, 20)
        Me.serviceLabor_summary.TabIndex = 8
        '
        'calculateButton
        '
        Me.calculateButton.Location = New System.Drawing.Point(223, 598)
        Me.calculateButton.Name = "calculateButton"
        Me.calculateButton.Size = New System.Drawing.Size(75, 23)
        Me.calculateButton.TabIndex = 5
        Me.calculateButton.Text = "Calculate Total"
        Me.calculateButton.UseVisualStyleBackColor = True
        '
        'clearButton
        '
        Me.clearButton.Location = New System.Drawing.Point(394, 598)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(75, 23)
        Me.clearButton.TabIndex = 6
        Me.clearButton.Text = "Clear"
        Me.clearButton.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(569, 598)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "Exit"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(185, 56)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(87, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "(RM 70 per hour)"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(911, 677)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.clearButton)
        Me.Controls.Add(Me.calculateButton)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SettingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BlackAndYellowToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BlackAndGreenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NormalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lubeJobBox As CheckBox
    Friend WithEvents oilChangeBox As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents tireBox As CheckBox
    Friend WithEvents inspectionBox As CheckBox
    Friend WithEvents mufflerBox As CheckBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents radiatorBox As CheckBox
    Friend WithEvents transmissionBox As CheckBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents laborBox As TextBox
    Friend WithEvents partBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents totalfees_summary As TextBox
    Friend WithEvents tax_summary As TextBox
    Friend WithEvents part_summary As TextBox
    Friend WithEvents serviceLabor_summary As TextBox
    Friend WithEvents calculateButton As Button
    Friend WithEvents clearButton As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label8 As Label
End Class
