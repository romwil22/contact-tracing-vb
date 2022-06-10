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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.title = New System.Windows.Forms.Label()
        Me.nameBox = New System.Windows.Forms.TextBox()
        Me.nameLabel = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.miBox = New System.Windows.Forms.TextBox()
        Me.middleNameLabel = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lastNameBox = New System.Windows.Forms.TextBox()
        Me.lastNameLabel = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.studentNumberBox = New System.Windows.Forms.TextBox()
        Me.studentNumberLabel = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.yrSecBox = New System.Windows.Forms.TextBox()
        Me.yrSecLabel = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.courseBox = New System.Windows.Forms.TextBox()
        Me.courseLabel = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.birthdateBox = New System.Windows.Forms.TextBox()
        Me.birthdateLabel = New System.Windows.Forms.Label()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.genderBox = New System.Windows.Forms.TextBox()
        Me.genderLabel = New System.Windows.Forms.Label()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.mobileNumberBox = New System.Windows.Forms.TextBox()
        Me.mobileNumberLabel = New System.Windows.Forms.Label()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.addressLabel = New System.Windows.Forms.Label()
        Me.addressRichBox = New System.Windows.Forms.RichTextBox()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.saveButton = New System.Windows.Forms.Button()
        Me.clearButton = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.HighlightText
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.title)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(488, 59)
        Me.Panel1.TabIndex = 0
        '
        'title
        '
        Me.title.AutoSize = True
        Me.title.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.title.Location = New System.Drawing.Point(70, 7)
        Me.title.Name = "title"
        Me.title.Size = New System.Drawing.Size(349, 39)
        Me.title.TabIndex = 1
        Me.title.Text = "Student Information:"
        '
        'nameBox
        '
        Me.nameBox.BackColor = System.Drawing.Color.White
        Me.nameBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nameBox.Location = New System.Drawing.Point(61, 4)
        Me.nameBox.Name = "nameBox"
        Me.nameBox.Size = New System.Drawing.Size(123, 23)
        Me.nameBox.TabIndex = 1
        '
        'nameLabel
        '
        Me.nameLabel.AutoSize = True
        Me.nameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nameLabel.ForeColor = System.Drawing.Color.Black
        Me.nameLabel.Location = New System.Drawing.Point(3, 5)
        Me.nameLabel.Name = "nameLabel"
        Me.nameLabel.Size = New System.Drawing.Size(60, 20)
        Me.nameLabel.TabIndex = 2
        Me.nameLabel.Text = "Name:"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.nameBox)
        Me.Panel2.Controls.Add(Me.nameLabel)
        Me.Panel2.Location = New System.Drawing.Point(12, 77)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(195, 34)
        Me.Panel2.TabIndex = 3
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.Control
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.miBox)
        Me.Panel3.Controls.Add(Me.middleNameLabel)
        Me.Panel3.Location = New System.Drawing.Point(213, 77)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(80, 34)
        Me.Panel3.TabIndex = 3
        '
        'miBox
        '
        Me.miBox.BackColor = System.Drawing.Color.White
        Me.miBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.miBox.Location = New System.Drawing.Point(39, 4)
        Me.miBox.Name = "miBox"
        Me.miBox.Size = New System.Drawing.Size(31, 23)
        Me.miBox.TabIndex = 1
        '
        'middleNameLabel
        '
        Me.middleNameLabel.AutoSize = True
        Me.middleNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.middleNameLabel.ForeColor = System.Drawing.Color.Black
        Me.middleNameLabel.Location = New System.Drawing.Point(3, 6)
        Me.middleNameLabel.Name = "middleNameLabel"
        Me.middleNameLabel.Size = New System.Drawing.Size(39, 20)
        Me.middleNameLabel.TabIndex = 2
        Me.middleNameLabel.Text = "M.I:"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.Control
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.lastNameBox)
        Me.Panel4.Controls.Add(Me.lastNameLabel)
        Me.Panel4.Location = New System.Drawing.Point(299, 77)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(201, 34)
        Me.Panel4.TabIndex = 3
        '
        'lastNameBox
        '
        Me.lastNameBox.BackColor = System.Drawing.Color.White
        Me.lastNameBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lastNameBox.Location = New System.Drawing.Point(97, 4)
        Me.lastNameBox.Name = "lastNameBox"
        Me.lastNameBox.Size = New System.Drawing.Size(93, 23)
        Me.lastNameBox.TabIndex = 1
        '
        'lastNameLabel
        '
        Me.lastNameLabel.AutoSize = True
        Me.lastNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lastNameLabel.ForeColor = System.Drawing.Color.Black
        Me.lastNameLabel.Location = New System.Drawing.Point(3, 5)
        Me.lastNameLabel.Name = "lastNameLabel"
        Me.lastNameLabel.Size = New System.Drawing.Size(95, 20)
        Me.lastNameLabel.TabIndex = 2
        Me.lastNameLabel.Text = "LastName:"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.Control
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.studentNumberBox)
        Me.Panel5.Controls.Add(Me.studentNumberLabel)
        Me.Panel5.Location = New System.Drawing.Point(12, 117)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(281, 34)
        Me.Panel5.TabIndex = 3
        '
        'studentNumberBox
        '
        Me.studentNumberBox.BackColor = System.Drawing.Color.White
        Me.studentNumberBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studentNumberBox.Location = New System.Drawing.Point(148, 4)
        Me.studentNumberBox.Name = "studentNumberBox"
        Me.studentNumberBox.Size = New System.Drawing.Size(123, 23)
        Me.studentNumberBox.TabIndex = 1
        '
        'studentNumberLabel
        '
        Me.studentNumberLabel.AutoSize = True
        Me.studentNumberLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studentNumberLabel.ForeColor = System.Drawing.Color.Black
        Me.studentNumberLabel.Location = New System.Drawing.Point(3, 4)
        Me.studentNumberLabel.Name = "studentNumberLabel"
        Me.studentNumberLabel.Size = New System.Drawing.Size(145, 20)
        Me.studentNumberLabel.TabIndex = 2
        Me.studentNumberLabel.Text = "Student Number:"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.SystemColors.Control
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.yrSecBox)
        Me.Panel6.Controls.Add(Me.yrSecLabel)
        Me.Panel6.Location = New System.Drawing.Point(299, 117)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(201, 34)
        Me.Panel6.TabIndex = 3
        '
        'yrSecBox
        '
        Me.yrSecBox.BackColor = System.Drawing.Color.White
        Me.yrSecBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.yrSecBox.Location = New System.Drawing.Point(119, 4)
        Me.yrSecBox.Name = "yrSecBox"
        Me.yrSecBox.Size = New System.Drawing.Size(71, 23)
        Me.yrSecBox.TabIndex = 1
        '
        'yrSecLabel
        '
        Me.yrSecLabel.AutoSize = True
        Me.yrSecLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.yrSecLabel.ForeColor = System.Drawing.Color.Black
        Me.yrSecLabel.Location = New System.Drawing.Point(3, 4)
        Me.yrSecLabel.Name = "yrSecLabel"
        Me.yrSecLabel.Size = New System.Drawing.Size(118, 20)
        Me.yrSecLabel.TabIndex = 2
        Me.yrSecLabel.Text = "Year/Section:"
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.SystemColors.Control
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel7.Controls.Add(Me.courseBox)
        Me.Panel7.Controls.Add(Me.courseLabel)
        Me.Panel7.Location = New System.Drawing.Point(290, 157)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(145, 34)
        Me.Panel7.TabIndex = 3
        '
        'courseBox
        '
        Me.courseBox.BackColor = System.Drawing.Color.White
        Me.courseBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.courseBox.Location = New System.Drawing.Point(72, 4)
        Me.courseBox.Name = "courseBox"
        Me.courseBox.Size = New System.Drawing.Size(62, 23)
        Me.courseBox.TabIndex = 1
        '
        'courseLabel
        '
        Me.courseLabel.AutoSize = True
        Me.courseLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.courseLabel.ForeColor = System.Drawing.Color.Black
        Me.courseLabel.Location = New System.Drawing.Point(3, 5)
        Me.courseLabel.Name = "courseLabel"
        Me.courseLabel.Size = New System.Drawing.Size(71, 20)
        Me.courseLabel.TabIndex = 2
        Me.courseLabel.Text = "Course:"
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.SystemColors.Control
        Me.Panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel8.Controls.Add(Me.birthdateBox)
        Me.Panel8.Controls.Add(Me.birthdateLabel)
        Me.Panel8.Location = New System.Drawing.Point(12, 197)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(178, 34)
        Me.Panel8.TabIndex = 3
        '
        'birthdateBox
        '
        Me.birthdateBox.BackColor = System.Drawing.Color.White
        Me.birthdateBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.birthdateBox.Location = New System.Drawing.Point(89, 4)
        Me.birthdateBox.Name = "birthdateBox"
        Me.birthdateBox.Size = New System.Drawing.Size(78, 23)
        Me.birthdateBox.TabIndex = 1
        '
        'birthdateLabel
        '
        Me.birthdateLabel.AutoSize = True
        Me.birthdateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.birthdateLabel.ForeColor = System.Drawing.Color.Black
        Me.birthdateLabel.Location = New System.Drawing.Point(3, 4)
        Me.birthdateLabel.Name = "birthdateLabel"
        Me.birthdateLabel.Size = New System.Drawing.Size(88, 20)
        Me.birthdateLabel.TabIndex = 2
        Me.birthdateLabel.Text = "Birthdate:"
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.SystemColors.Control
        Me.Panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel9.Controls.Add(Me.genderBox)
        Me.Panel9.Controls.Add(Me.genderLabel)
        Me.Panel9.Location = New System.Drawing.Point(196, 197)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(160, 34)
        Me.Panel9.TabIndex = 3
        '
        'genderBox
        '
        Me.genderBox.BackColor = System.Drawing.Color.White
        Me.genderBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.genderBox.Location = New System.Drawing.Point(121, 5)
        Me.genderBox.Name = "genderBox"
        Me.genderBox.Size = New System.Drawing.Size(28, 23)
        Me.genderBox.TabIndex = 1
        Me.genderBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'genderLabel
        '
        Me.genderLabel.AutoSize = True
        Me.genderLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.genderLabel.ForeColor = System.Drawing.Color.Black
        Me.genderLabel.Location = New System.Drawing.Point(3, 5)
        Me.genderLabel.Name = "genderLabel"
        Me.genderLabel.Size = New System.Drawing.Size(121, 20)
        Me.genderLabel.TabIndex = 2
        Me.genderLabel.Text = "Gender (M/F):"
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.SystemColors.Control
        Me.Panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel10.Controls.Add(Me.mobileNumberBox)
        Me.Panel10.Controls.Add(Me.mobileNumberLabel)
        Me.Panel10.Location = New System.Drawing.Point(12, 157)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(272, 34)
        Me.Panel10.TabIndex = 3
        '
        'mobileNumberBox
        '
        Me.mobileNumberBox.BackColor = System.Drawing.Color.White
        Me.mobileNumberBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mobileNumberBox.Location = New System.Drawing.Point(135, 4)
        Me.mobileNumberBox.Name = "mobileNumberBox"
        Me.mobileNumberBox.Size = New System.Drawing.Size(123, 23)
        Me.mobileNumberBox.TabIndex = 1
        '
        'mobileNumberLabel
        '
        Me.mobileNumberLabel.AutoSize = True
        Me.mobileNumberLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mobileNumberLabel.ForeColor = System.Drawing.Color.Black
        Me.mobileNumberLabel.Location = New System.Drawing.Point(3, 4)
        Me.mobileNumberLabel.Name = "mobileNumberLabel"
        Me.mobileNumberLabel.Size = New System.Drawing.Size(133, 20)
        Me.mobileNumberLabel.TabIndex = 2
        Me.mobileNumberLabel.Text = "Mobile Number:"
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.SystemColors.Control
        Me.Panel11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel11.Controls.Add(Me.addressRichBox)
        Me.Panel11.Controls.Add(Me.addressLabel)
        Me.Panel11.Location = New System.Drawing.Point(12, 237)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(344, 130)
        Me.Panel11.TabIndex = 3
        '
        'addressLabel
        '
        Me.addressLabel.AutoSize = True
        Me.addressLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addressLabel.ForeColor = System.Drawing.Color.Black
        Me.addressLabel.Location = New System.Drawing.Point(3, 4)
        Me.addressLabel.Name = "addressLabel"
        Me.addressLabel.Size = New System.Drawing.Size(80, 20)
        Me.addressLabel.TabIndex = 2
        Me.addressLabel.Text = "Address:"
        '
        'addressRichBox
        '
        Me.addressRichBox.Location = New System.Drawing.Point(84, 6)
        Me.addressRichBox.Name = "addressRichBox"
        Me.addressRichBox.Size = New System.Drawing.Size(249, 114)
        Me.addressRichBox.TabIndex = 3
        Me.addressRichBox.Text = ""
        '
        'exitButton
        '
        Me.exitButton.BackColor = System.Drawing.Color.Red
        Me.exitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exitButton.Location = New System.Drawing.Point(406, 387)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(84, 51)
        Me.exitButton.TabIndex = 4
        Me.exitButton.Text = "Exit"
        Me.exitButton.UseVisualStyleBackColor = False
        '
        'saveButton
        '
        Me.saveButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.saveButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saveButton.Location = New System.Drawing.Point(314, 387)
        Me.saveButton.Name = "saveButton"
        Me.saveButton.Size = New System.Drawing.Size(84, 51)
        Me.saveButton.TabIndex = 4
        Me.saveButton.Text = "Save"
        Me.saveButton.UseVisualStyleBackColor = False
        '
        'clearButton
        '
        Me.clearButton.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.clearButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearButton.Location = New System.Drawing.Point(224, 387)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(84, 51)
        Me.clearButton.TabIndex = 4
        Me.clearButton.Text = "Clear"
        Me.clearButton.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ClientSize = New System.Drawing.Size(511, 450)
        Me.Controls.Add(Me.clearButton)
        Me.Controls.Add(Me.saveButton)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel9)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel10)
        Me.Controls.Add(Me.Panel11)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Contact Tracing"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        Me.Panel11.ResumeLayout(False)
        Me.Panel11.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents title As Label
    Friend WithEvents nameBox As TextBox
    Friend WithEvents nameLabel As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents miBox As TextBox
    Friend WithEvents middleNameLabel As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lastNameBox As TextBox
    Friend WithEvents lastNameLabel As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents studentNumberBox As TextBox
    Friend WithEvents studentNumberLabel As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents yrSecBox As TextBox
    Friend WithEvents yrSecLabel As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents courseBox As TextBox
    Friend WithEvents courseLabel As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents birthdateBox As TextBox
    Friend WithEvents birthdateLabel As Label
    Friend WithEvents Panel9 As Panel
    Friend WithEvents genderBox As TextBox
    Friend WithEvents genderLabel As Label
    Friend WithEvents Panel10 As Panel
    Friend WithEvents mobileNumberBox As TextBox
    Friend WithEvents mobileNumberLabel As Label
    Friend WithEvents Panel11 As Panel
    Friend WithEvents addressRichBox As RichTextBox
    Friend WithEvents addressLabel As Label
    Friend WithEvents exitButton As Button
    Friend WithEvents saveButton As Button
    Friend WithEvents clearButton As Button
End Class
