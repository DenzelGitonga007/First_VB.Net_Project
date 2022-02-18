<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class advance_tax_system_form
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
        Me.Title_lbl = New System.Windows.Forms.Label()
        Me.employee_number_lbl = New System.Windows.Forms.Label()
        Me.employee_name_lbl = New System.Windows.Forms.Label()
        Me.gross_pay_lbl = New System.Windows.Forms.Label()
        Me.paye_lbl = New System.Windows.Forms.Label()
        Me.employee_number_tbx = New System.Windows.Forms.TextBox()
        Me.employee_name_tbx = New System.Windows.Forms.TextBox()
        Me.gross_pay_tbx = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.other_deductions_lbl = New System.Windows.Forms.Label()
        Me.helb_loan_lbl = New System.Windows.Forms.Label()
        Me.helb_loan_tbx = New System.Windows.Forms.TextBox()
        Me.sacco_lbl = New System.Windows.Forms.Label()
        Me.sacco_tbx = New System.Windows.Forms.TextBox()
        Me.net_pay_lbl = New System.Windows.Forms.Label()
        Me.net_pay_tbx = New System.Windows.Forms.TextBox()
        Me.female_rdbtn = New System.Windows.Forms.RadioButton()
        Me.male_rdbtn = New System.Windows.Forms.RadioButton()
        Me.gender_grbx = New System.Windows.Forms.GroupBox()
        Me.next_btn = New System.Windows.Forms.Button()
        Me.quit_btn = New System.Windows.Forms.Button()
        Me.calculate_btn = New System.Windows.Forms.Button()
        Me.gender_grbx.SuspendLayout()
        Me.SuspendLayout()
        '
        'Title_lbl
        '
        Me.Title_lbl.AutoSize = True
        Me.Title_lbl.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title_lbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Title_lbl.Location = New System.Drawing.Point(154, 28)
        Me.Title_lbl.Name = "Title_lbl"
        Me.Title_lbl.Size = New System.Drawing.Size(185, 23)
        Me.Title_lbl.TabIndex = 1
        Me.Title_lbl.Text = "Vumilia TAX System"
        Me.Title_lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'employee_number_lbl
        '
        Me.employee_number_lbl.AutoSize = True
        Me.employee_number_lbl.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.employee_number_lbl.Location = New System.Drawing.Point(32, 66)
        Me.employee_number_lbl.Name = "employee_number_lbl"
        Me.employee_number_lbl.Size = New System.Drawing.Size(105, 15)
        Me.employee_number_lbl.TabIndex = 3
        Me.employee_number_lbl.Text = "Employee Number"
        '
        'employee_name_lbl
        '
        Me.employee_name_lbl.AutoSize = True
        Me.employee_name_lbl.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.employee_name_lbl.Location = New System.Drawing.Point(32, 105)
        Me.employee_name_lbl.Name = "employee_name_lbl"
        Me.employee_name_lbl.Size = New System.Drawing.Size(92, 15)
        Me.employee_name_lbl.TabIndex = 4
        Me.employee_name_lbl.Text = "Employee Name"
        '
        'gross_pay_lbl
        '
        Me.gross_pay_lbl.AutoSize = True
        Me.gross_pay_lbl.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gross_pay_lbl.Location = New System.Drawing.Point(32, 142)
        Me.gross_pay_lbl.Name = "gross_pay_lbl"
        Me.gross_pay_lbl.Size = New System.Drawing.Size(63, 15)
        Me.gross_pay_lbl.TabIndex = 5
        Me.gross_pay_lbl.Text = "Gross Pay"
        '
        'paye_lbl
        '
        Me.paye_lbl.AutoSize = True
        Me.paye_lbl.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.paye_lbl.Location = New System.Drawing.Point(32, 177)
        Me.paye_lbl.Name = "paye_lbl"
        Me.paye_lbl.Size = New System.Drawing.Size(46, 15)
        Me.paye_lbl.TabIndex = 6
        Me.paye_lbl.Text = "P.A.Y.E"
        '
        'employee_number_tbx
        '
        Me.employee_number_tbx.Location = New System.Drawing.Point(291, 66)
        Me.employee_number_tbx.Name = "employee_number_tbx"
        Me.employee_number_tbx.Size = New System.Drawing.Size(117, 20)
        Me.employee_number_tbx.TabIndex = 7
        '
        'employee_name_tbx
        '
        Me.employee_name_tbx.Location = New System.Drawing.Point(291, 98)
        Me.employee_name_tbx.Name = "employee_name_tbx"
        Me.employee_name_tbx.Size = New System.Drawing.Size(117, 20)
        Me.employee_name_tbx.TabIndex = 8
        '
        'gross_pay_tbx
        '
        Me.gross_pay_tbx.Location = New System.Drawing.Point(291, 135)
        Me.gross_pay_tbx.Name = "gross_pay_tbx"
        Me.gross_pay_tbx.Size = New System.Drawing.Size(117, 20)
        Me.gross_pay_tbx.TabIndex = 9
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(291, 170)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(117, 20)
        Me.TextBox4.TabIndex = 10
        '
        'other_deductions_lbl
        '
        Me.other_deductions_lbl.AutoSize = True
        Me.other_deductions_lbl.Font = New System.Drawing.Font("Times New Roman", 13.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.other_deductions_lbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.other_deductions_lbl.Location = New System.Drawing.Point(154, 217)
        Me.other_deductions_lbl.Name = "other_deductions_lbl"
        Me.other_deductions_lbl.Size = New System.Drawing.Size(142, 21)
        Me.other_deductions_lbl.TabIndex = 11
        Me.other_deductions_lbl.Text = "Other Deductions"
        Me.other_deductions_lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'helb_loan_lbl
        '
        Me.helb_loan_lbl.AutoSize = True
        Me.helb_loan_lbl.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.helb_loan_lbl.Location = New System.Drawing.Point(32, 255)
        Me.helb_loan_lbl.Name = "helb_loan_lbl"
        Me.helb_loan_lbl.Size = New System.Drawing.Size(70, 15)
        Me.helb_loan_lbl.TabIndex = 12
        Me.helb_loan_lbl.Text = "HELB Loan"
        '
        'helb_loan_tbx
        '
        Me.helb_loan_tbx.Location = New System.Drawing.Point(291, 255)
        Me.helb_loan_tbx.Name = "helb_loan_tbx"
        Me.helb_loan_tbx.Size = New System.Drawing.Size(117, 20)
        Me.helb_loan_tbx.TabIndex = 13
        '
        'sacco_lbl
        '
        Me.sacco_lbl.AutoSize = True
        Me.sacco_lbl.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sacco_lbl.Location = New System.Drawing.Point(32, 305)
        Me.sacco_lbl.Name = "sacco_lbl"
        Me.sacco_lbl.Size = New System.Drawing.Size(52, 15)
        Me.sacco_lbl.TabIndex = 14
        Me.sacco_lbl.Text = "SACCO"
        '
        'sacco_tbx
        '
        Me.sacco_tbx.Location = New System.Drawing.Point(291, 305)
        Me.sacco_tbx.Name = "sacco_tbx"
        Me.sacco_tbx.Size = New System.Drawing.Size(117, 20)
        Me.sacco_tbx.TabIndex = 15
        '
        'net_pay_lbl
        '
        Me.net_pay_lbl.AutoSize = True
        Me.net_pay_lbl.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.net_pay_lbl.Location = New System.Drawing.Point(155, 357)
        Me.net_pay_lbl.Name = "net_pay_lbl"
        Me.net_pay_lbl.Size = New System.Drawing.Size(47, 13)
        Me.net_pay_lbl.TabIndex = 16
        Me.net_pay_lbl.Text = "Net Pay"
        '
        'net_pay_tbx
        '
        Me.net_pay_tbx.BackColor = System.Drawing.SystemColors.MenuBar
        Me.net_pay_tbx.Location = New System.Drawing.Point(291, 350)
        Me.net_pay_tbx.Name = "net_pay_tbx"
        Me.net_pay_tbx.Size = New System.Drawing.Size(117, 20)
        Me.net_pay_tbx.TabIndex = 17
        '
        'female_rdbtn
        '
        Me.female_rdbtn.AutoSize = True
        Me.female_rdbtn.Location = New System.Drawing.Point(20, 31)
        Me.female_rdbtn.Name = "female_rdbtn"
        Me.female_rdbtn.Size = New System.Drawing.Size(63, 17)
        Me.female_rdbtn.TabIndex = 18
        Me.female_rdbtn.TabStop = True
        Me.female_rdbtn.Text = "Female"
        Me.female_rdbtn.UseVisualStyleBackColor = True
        '
        'male_rdbtn
        '
        Me.male_rdbtn.AutoSize = True
        Me.male_rdbtn.Location = New System.Drawing.Point(96, 31)
        Me.male_rdbtn.Name = "male_rdbtn"
        Me.male_rdbtn.Size = New System.Drawing.Size(51, 17)
        Me.male_rdbtn.TabIndex = 19
        Me.male_rdbtn.TabStop = True
        Me.male_rdbtn.Text = "Male"
        Me.male_rdbtn.UseVisualStyleBackColor = True
        '
        'gender_grbx
        '
        Me.gender_grbx.Controls.Add(Me.female_rdbtn)
        Me.gender_grbx.Controls.Add(Me.male_rdbtn)
        Me.gender_grbx.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gender_grbx.Location = New System.Drawing.Point(158, 391)
        Me.gender_grbx.Name = "gender_grbx"
        Me.gender_grbx.Size = New System.Drawing.Size(179, 76)
        Me.gender_grbx.TabIndex = 20
        Me.gender_grbx.TabStop = False
        Me.gender_grbx.Text = "Gender"
        '
        'next_btn
        '
        Me.next_btn.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.next_btn.Location = New System.Drawing.Point(209, 473)
        Me.next_btn.Name = "next_btn"
        Me.next_btn.Size = New System.Drawing.Size(75, 23)
        Me.next_btn.TabIndex = 22
        Me.next_btn.Text = "Next"
        Me.next_btn.UseVisualStyleBackColor = True
        '
        'quit_btn
        '
        Me.quit_btn.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.quit_btn.Location = New System.Drawing.Point(291, 473)
        Me.quit_btn.Name = "quit_btn"
        Me.quit_btn.Size = New System.Drawing.Size(75, 23)
        Me.quit_btn.TabIndex = 23
        Me.quit_btn.Text = "Quit"
        Me.quit_btn.UseVisualStyleBackColor = True
        '
        'calculate_btn
        '
        Me.calculate_btn.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calculate_btn.Location = New System.Drawing.Point(128, 473)
        Me.calculate_btn.Name = "calculate_btn"
        Me.calculate_btn.Size = New System.Drawing.Size(75, 23)
        Me.calculate_btn.TabIndex = 24
        Me.calculate_btn.Text = "Calculate"
        Me.calculate_btn.UseVisualStyleBackColor = True
        '
        'advance_tax_system_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(469, 521)
        Me.Controls.Add(Me.calculate_btn)
        Me.Controls.Add(Me.quit_btn)
        Me.Controls.Add(Me.next_btn)
        Me.Controls.Add(Me.gender_grbx)
        Me.Controls.Add(Me.net_pay_tbx)
        Me.Controls.Add(Me.net_pay_lbl)
        Me.Controls.Add(Me.sacco_tbx)
        Me.Controls.Add(Me.sacco_lbl)
        Me.Controls.Add(Me.helb_loan_tbx)
        Me.Controls.Add(Me.helb_loan_lbl)
        Me.Controls.Add(Me.other_deductions_lbl)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.gross_pay_tbx)
        Me.Controls.Add(Me.employee_name_tbx)
        Me.Controls.Add(Me.employee_number_tbx)
        Me.Controls.Add(Me.paye_lbl)
        Me.Controls.Add(Me.gross_pay_lbl)
        Me.Controls.Add(Me.employee_name_lbl)
        Me.Controls.Add(Me.employee_number_lbl)
        Me.Controls.Add(Me.Title_lbl)
        Me.Name = "advance_tax_system_form"
        Me.Text = "Advanced Tax System"
        Me.gender_grbx.ResumeLayout(False)
        Me.gender_grbx.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Title_lbl As Label
    Friend WithEvents employee_number_lbl As Label
    Friend WithEvents employee_name_lbl As Label
    Friend WithEvents gross_pay_lbl As Label
    Friend WithEvents paye_lbl As Label
    Friend WithEvents employee_number_tbx As TextBox
    Friend WithEvents employee_name_tbx As TextBox
    Friend WithEvents gross_pay_tbx As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents other_deductions_lbl As Label
    Friend WithEvents helb_loan_lbl As Label
    Friend WithEvents helb_loan_tbx As TextBox
    Friend WithEvents sacco_lbl As Label
    Friend WithEvents sacco_tbx As TextBox
    Friend WithEvents net_pay_lbl As Label
    Friend WithEvents net_pay_tbx As TextBox
    Friend WithEvents female_rdbtn As RadioButton
    Friend WithEvents male_rdbtn As RadioButton
    Friend WithEvents gender_grbx As GroupBox
    Friend WithEvents next_btn As Button
    Friend WithEvents quit_btn As Button
    Friend WithEvents calculate_btn As Button
End Class
