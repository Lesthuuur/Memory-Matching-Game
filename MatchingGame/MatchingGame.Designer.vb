<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class memoryGame
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
        Me.components = New System.ComponentModel.Container()
        Me.titleLabel = New System.Windows.Forms.Label()
        Me.mismatchedLbl = New System.Windows.Forms.Label()
        Me.mismatchedCountLbl = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.timeLeftContainer = New System.Windows.Forms.Label()
        Me.start_restart_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.mainContainerGrpBox = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.PictureBox12 = New System.Windows.Forms.PictureBox()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox11 = New System.Windows.Forms.PictureBox()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.gameTimer = New System.Windows.Forms.Timer(Me.components)
        Me.mainContainerGrpBox.SuspendLayout()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'titleLabel
        '
        Me.titleLabel.AutoSize = True
        Me.titleLabel.Font = New System.Drawing.Font("Schibsted Grotesk ExtraBold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titleLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.titleLabel.Location = New System.Drawing.Point(37, 13)
        Me.titleLabel.Name = "titleLabel"
        Me.titleLabel.Size = New System.Drawing.Size(304, 32)
        Me.titleLabel.TabIndex = 0
        Me.titleLabel.Text = "MEMORY MATCHING GAME"
        '
        'mismatchedLbl
        '
        Me.mismatchedLbl.AutoSize = True
        Me.mismatchedLbl.Font = New System.Drawing.Font("Poppins Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mismatchedLbl.ForeColor = System.Drawing.Color.Black
        Me.mismatchedLbl.Location = New System.Drawing.Point(21, 456)
        Me.mismatchedLbl.Name = "mismatchedLbl"
        Me.mismatchedLbl.Size = New System.Drawing.Size(118, 28)
        Me.mismatchedLbl.TabIndex = 1
        Me.mismatchedLbl.Text = "Mismatched: "
        '
        'mismatchedCountLbl
        '
        Me.mismatchedCountLbl.AutoSize = True
        Me.mismatchedCountLbl.Font = New System.Drawing.Font("Poppins Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mismatchedCountLbl.ForeColor = System.Drawing.Color.Black
        Me.mismatchedCountLbl.Location = New System.Drawing.Point(131, 457)
        Me.mismatchedCountLbl.Name = "mismatchedCountLbl"
        Me.mismatchedCountLbl.Size = New System.Drawing.Size(22, 28)
        Me.mismatchedCountLbl.TabIndex = 2
        Me.mismatchedCountLbl.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Poppins Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(21, 480)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 28)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Time Left: "
        '
        'timeLeftContainer
        '
        Me.timeLeftContainer.AutoSize = True
        Me.timeLeftContainer.Font = New System.Drawing.Font("Poppins Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timeLeftContainer.ForeColor = System.Drawing.Color.Black
        Me.timeLeftContainer.Location = New System.Drawing.Point(106, 481)
        Me.timeLeftContainer.Name = "timeLeftContainer"
        Me.timeLeftContainer.Size = New System.Drawing.Size(22, 28)
        Me.timeLeftContainer.TabIndex = 4
        Me.timeLeftContainer.Text = "0"
        '
        'start_restart_btn
        '
        Me.start_restart_btn.BorderRadius = 20
        Me.start_restart_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.start_restart_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.start_restart_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.start_restart_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.start_restart_btn.Font = New System.Drawing.Font("Poppins Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.start_restart_btn.ForeColor = System.Drawing.Color.White
        Me.start_restart_btn.Location = New System.Drawing.Point(131, 536)
        Me.start_restart_btn.Name = "start_restart_btn"
        Me.start_restart_btn.Size = New System.Drawing.Size(116, 42)
        Me.start_restart_btn.TabIndex = 5
        '
        'mainContainerGrpBox
        '
        Me.mainContainerGrpBox.BorderRadius = 20
        Me.mainContainerGrpBox.BorderThickness = 2
        Me.mainContainerGrpBox.Controls.Add(Me.PictureBox12)
        Me.mainContainerGrpBox.Controls.Add(Me.PictureBox9)
        Me.mainContainerGrpBox.Controls.Add(Me.PictureBox6)
        Me.mainContainerGrpBox.Controls.Add(Me.PictureBox3)
        Me.mainContainerGrpBox.Controls.Add(Me.PictureBox11)
        Me.mainContainerGrpBox.Controls.Add(Me.PictureBox10)
        Me.mainContainerGrpBox.Controls.Add(Me.PictureBox8)
        Me.mainContainerGrpBox.Controls.Add(Me.PictureBox7)
        Me.mainContainerGrpBox.Controls.Add(Me.PictureBox5)
        Me.mainContainerGrpBox.Controls.Add(Me.PictureBox4)
        Me.mainContainerGrpBox.Controls.Add(Me.PictureBox2)
        Me.mainContainerGrpBox.Controls.Add(Me.PictureBox1)
        Me.mainContainerGrpBox.CustomBorderThickness = New System.Windows.Forms.Padding(0)
        Me.mainContainerGrpBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.mainContainerGrpBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.mainContainerGrpBox.Location = New System.Drawing.Point(17, 53)
        Me.mainContainerGrpBox.Name = "mainContainerGrpBox"
        Me.mainContainerGrpBox.Size = New System.Drawing.Size(346, 391)
        Me.mainContainerGrpBox.TabIndex = 0
        '
        'PictureBox12
        '
        Me.PictureBox12.Location = New System.Drawing.Point(232, 292)
        Me.PictureBox12.Name = "PictureBox12"
        Me.PictureBox12.Size = New System.Drawing.Size(100, 86)
        Me.PictureBox12.TabIndex = 1
        Me.PictureBox12.TabStop = False
        '
        'PictureBox9
        '
        Me.PictureBox9.Location = New System.Drawing.Point(233, 199)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(100, 86)
        Me.PictureBox9.TabIndex = 1
        Me.PictureBox9.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.Location = New System.Drawing.Point(231, 107)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(100, 86)
        Me.PictureBox6.TabIndex = 1
        Me.PictureBox6.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Location = New System.Drawing.Point(231, 15)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(100, 86)
        Me.PictureBox3.TabIndex = 1
        Me.PictureBox3.TabStop = False
        '
        'PictureBox11
        '
        Me.PictureBox11.Location = New System.Drawing.Point(124, 293)
        Me.PictureBox11.Name = "PictureBox11"
        Me.PictureBox11.Size = New System.Drawing.Size(100, 86)
        Me.PictureBox11.TabIndex = 1
        Me.PictureBox11.TabStop = False
        '
        'PictureBox10
        '
        Me.PictureBox10.Location = New System.Drawing.Point(15, 292)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(100, 86)
        Me.PictureBox10.TabIndex = 0
        Me.PictureBox10.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.Location = New System.Drawing.Point(125, 200)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(100, 86)
        Me.PictureBox8.TabIndex = 1
        Me.PictureBox8.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.Location = New System.Drawing.Point(16, 199)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(100, 86)
        Me.PictureBox7.TabIndex = 0
        Me.PictureBox7.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Location = New System.Drawing.Point(123, 108)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(100, 86)
        Me.PictureBox5.TabIndex = 1
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Location = New System.Drawing.Point(14, 107)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(100, 86)
        Me.PictureBox4.TabIndex = 0
        Me.PictureBox4.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(123, 16)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 86)
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(14, 15)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 86)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'gameTimer
        '
        Me.gameTimer.Interval = 1000
        '
        'memoryGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(385, 585)
        Me.Controls.Add(Me.start_restart_btn)
        Me.Controls.Add(Me.timeLeftContainer)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.mismatchedCountLbl)
        Me.Controls.Add(Me.mismatchedLbl)
        Me.Controls.Add(Me.titleLabel)
        Me.Controls.Add(Me.mainContainerGrpBox)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "memoryGame"
        Me.Text = "Memory Matching Game"
        Me.mainContainerGrpBox.ResumeLayout(False)
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents titleLabel As Label
    Friend WithEvents mismatchedLbl As Label
    Friend WithEvents mismatchedCountLbl As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents timeLeftContainer As Label
    Friend WithEvents start_restart_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents mainContainerGrpBox As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents PictureBox12 As PictureBox
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox11 As PictureBox
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents gameTimer As Timer
End Class
