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
        Me.mainContainerGrpBox = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.titleLabel = New System.Windows.Forms.Label()
        Me.mismatchedLbl = New System.Windows.Forms.Label()
        Me.mismatchedCountLbl = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.restartBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.SuspendLayout()
        '
        'mainContainerGrpBox
        '
        Me.mainContainerGrpBox.BorderRadius = 20
        Me.mainContainerGrpBox.BorderThickness = 2
        Me.mainContainerGrpBox.CustomBorderThickness = New System.Windows.Forms.Padding(0)
        Me.mainContainerGrpBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.mainContainerGrpBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.mainContainerGrpBox.Location = New System.Drawing.Point(17, 53)
        Me.mainContainerGrpBox.Name = "mainContainerGrpBox"
        Me.mainContainerGrpBox.Size = New System.Drawing.Size(348, 391)
        Me.mainContainerGrpBox.TabIndex = 0
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Poppins Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(106, 481)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(22, 28)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "0"
        '
        'restartBtn
        '
        Me.restartBtn.BorderRadius = 20
        Me.restartBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.restartBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.restartBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.restartBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.restartBtn.Font = New System.Drawing.Font("Poppins Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.restartBtn.ForeColor = System.Drawing.Color.White
        Me.restartBtn.Location = New System.Drawing.Point(126, 519)
        Me.restartBtn.Name = "restartBtn"
        Me.restartBtn.Size = New System.Drawing.Size(116, 42)
        Me.restartBtn.TabIndex = 5
        Me.restartBtn.Text = "RESTART"
        '
        'memoryGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(385, 585)
        Me.Controls.Add(Me.restartBtn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.mismatchedCountLbl)
        Me.Controls.Add(Me.mismatchedLbl)
        Me.Controls.Add(Me.titleLabel)
        Me.Controls.Add(Me.mainContainerGrpBox)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "memoryGame"
        Me.Text = "Memory Matching Game"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mainContainerGrpBox As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents titleLabel As Label
    Friend WithEvents mismatchedLbl As Label
    Friend WithEvents mismatchedCountLbl As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents restartBtn As Guna.UI2.WinForms.Guna2Button
End Class
