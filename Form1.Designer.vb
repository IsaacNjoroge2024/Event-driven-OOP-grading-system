<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtsubject = New System.Windows.Forms.TextBox()
        Me.txtfirstname = New System.Windows.Forms.TextBox()
        Me.txtlastname = New System.Windows.Forms.TextBox()
        Me.txtstudnum = New System.Windows.Forms.TextBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.txttermgrade = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.btncompute = New System.Windows.Forms.Button()
        Me.txtmajorexam = New System.Windows.Forms.TextBox()
        Me.txtquizzes = New System.Windows.Forms.TextBox()
        Me.txtcp = New System.Windows.Forms.TextBox()
        Me.cboterm = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtlettergrade = New System.Windows.Forms.TextBox()
        Me.txtfinalavg = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnaverage = New System.Windows.Forms.Button()
        Me.txtfinalgrade = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtmidtermgrade = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnaddData = New System.Windows.Forms.Button()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.btndel = New System.Windows.Forms.Button()
        Me.btnclr = New System.Windows.Forms.Button()
        Me.dgvstudents = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dgvstudents, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Panel1.Controls.Add(Me.txtsubject)
        Me.Panel1.Controls.Add(Me.txtfirstname)
        Me.Panel1.Controls.Add(Me.txtlastname)
        Me.Panel1.Controls.Add(Me.txtstudnum)
        Me.Panel1.Controls.Add(Me.label4)
        Me.Panel1.Controls.Add(Me.label3)
        Me.Panel1.Controls.Add(Me.label2)
        Me.Panel1.Controls.Add(Me.label1)
        Me.Panel1.Location = New System.Drawing.Point(13, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1135, 208)
        Me.Panel1.TabIndex = 0
        '
        'txtsubject
        '
        Me.txtsubject.Location = New System.Drawing.Point(166, 161)
        Me.txtsubject.Name = "txtsubject"
        Me.txtsubject.Size = New System.Drawing.Size(209, 26)
        Me.txtsubject.TabIndex = 7
        '
        'txtfirstname
        '
        Me.txtfirstname.Location = New System.Drawing.Point(166, 116)
        Me.txtfirstname.Name = "txtfirstname"
        Me.txtfirstname.Size = New System.Drawing.Size(209, 26)
        Me.txtfirstname.TabIndex = 6
        '
        'txtlastname
        '
        Me.txtlastname.Location = New System.Drawing.Point(166, 66)
        Me.txtlastname.Name = "txtlastname"
        Me.txtlastname.Size = New System.Drawing.Size(209, 26)
        Me.txtlastname.TabIndex = 5
        '
        'txtstudnum
        '
        Me.txtstudnum.Location = New System.Drawing.Point(166, 17)
        Me.txtstudnum.Name = "txtstudnum"
        Me.txtstudnum.Size = New System.Drawing.Size(209, 26)
        Me.txtstudnum.TabIndex = 4
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(37, 168)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(67, 20)
        Me.label4.TabIndex = 3
        Me.label4.Text = "Subject:"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(37, 122)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(90, 20)
        Me.label3.TabIndex = 2
        Me.label3.Text = "First Name:"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(37, 73)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(90, 20)
        Me.label2.TabIndex = 1
        Me.label2.Text = "Last Name:"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(37, 24)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(130, 20)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Student Number:"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Panel2.Controls.Add(Me.btnsave)
        Me.Panel2.Controls.Add(Me.txttermgrade)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.btnclear)
        Me.Panel2.Controls.Add(Me.btncompute)
        Me.Panel2.Controls.Add(Me.txtmajorexam)
        Me.Panel2.Controls.Add(Me.txtquizzes)
        Me.Panel2.Controls.Add(Me.txtcp)
        Me.Panel2.Controls.Add(Me.cboterm)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Location = New System.Drawing.Point(13, 239)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(573, 484)
        Me.Panel2.TabIndex = 1
        '
        'btnsave
        '
        Me.btnsave.Location = New System.Drawing.Point(65, 414)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(349, 45)
        Me.btnsave.TabIndex = 12
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'txttermgrade
        '
        Me.txttermgrade.Location = New System.Drawing.Point(166, 348)
        Me.txttermgrade.Name = "txttermgrade"
        Me.txttermgrade.Size = New System.Drawing.Size(209, 26)
        Me.txttermgrade.TabIndex = 11
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(37, 355)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(98, 20)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Term Grade:"
        '
        'btnclear
        '
        Me.btnclear.Location = New System.Drawing.Point(281, 264)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(133, 44)
        Me.btnclear.TabIndex = 9
        Me.btnclear.Text = "Clear"
        Me.btnclear.UseVisualStyleBackColor = True
        '
        'btncompute
        '
        Me.btncompute.Location = New System.Drawing.Point(65, 264)
        Me.btncompute.Name = "btncompute"
        Me.btncompute.Size = New System.Drawing.Size(131, 44)
        Me.btncompute.TabIndex = 8
        Me.btncompute.Text = "Compute"
        Me.btncompute.UseVisualStyleBackColor = True
        '
        'txtmajorexam
        '
        Me.txtmajorexam.Location = New System.Drawing.Point(166, 186)
        Me.txtmajorexam.Name = "txtmajorexam"
        Me.txtmajorexam.Size = New System.Drawing.Size(209, 26)
        Me.txtmajorexam.TabIndex = 7
        '
        'txtquizzes
        '
        Me.txtquizzes.Location = New System.Drawing.Point(166, 133)
        Me.txtquizzes.Name = "txtquizzes"
        Me.txtquizzes.Size = New System.Drawing.Size(209, 26)
        Me.txtquizzes.TabIndex = 6
        '
        'txtcp
        '
        Me.txtcp.Location = New System.Drawing.Point(166, 84)
        Me.txtcp.Name = "txtcp"
        Me.txtcp.Size = New System.Drawing.Size(209, 26)
        Me.txtcp.TabIndex = 5
        '
        'cboterm
        '
        Me.cboterm.FormattingEnabled = True
        Me.cboterm.Items.AddRange(New Object() {"Midterm", "Finals"})
        Me.cboterm.Location = New System.Drawing.Point(166, 32)
        Me.cboterm.Name = "cboterm"
        Me.cboterm.Size = New System.Drawing.Size(209, 28)
        Me.cboterm.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(37, 192)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 20)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Major Exam:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(37, 140)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 20)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Quizzes:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(37, 90)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 20)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "CP:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(37, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 20)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Term:"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Panel3.Controls.Add(Me.txtlettergrade)
        Me.Panel3.Controls.Add(Me.txtfinalavg)
        Me.Panel3.Controls.Add(Me.Label13)
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Controls.Add(Me.btnaverage)
        Me.Panel3.Controls.Add(Me.txtfinalgrade)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.txtmidtermgrade)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Location = New System.Drawing.Point(616, 239)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(531, 484)
        Me.Panel3.TabIndex = 2
        '
        'txtlettergrade
        '
        Me.txtlettergrade.Location = New System.Drawing.Point(208, 348)
        Me.txtlettergrade.Name = "txtlettergrade"
        Me.txtlettergrade.Size = New System.Drawing.Size(241, 26)
        Me.txtlettergrade.TabIndex = 8
        '
        'txtfinalavg
        '
        Me.txtfinalavg.Location = New System.Drawing.Point(208, 264)
        Me.txtfinalavg.Name = "txtfinalavg"
        Me.txtfinalavg.Size = New System.Drawing.Size(241, 26)
        Me.txtfinalavg.TabIndex = 7
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(26, 355)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(104, 20)
        Me.Label13.TabIndex = 6
        Me.Label13.Text = "Letter Grade:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(22, 270)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(110, 20)
        Me.Label12.TabIndex = 5
        Me.Label12.Text = "Final Average:"
        '
        'btnaverage
        '
        Me.btnaverage.Location = New System.Drawing.Point(98, 171)
        Me.btnaverage.Name = "btnaverage"
        Me.btnaverage.Size = New System.Drawing.Size(351, 41)
        Me.btnaverage.TabIndex = 4
        Me.btnaverage.Text = "Average"
        Me.btnaverage.UseVisualStyleBackColor = True
        '
        'txtfinalgrade
        '
        Me.txtfinalgrade.Location = New System.Drawing.Point(208, 87)
        Me.txtfinalgrade.Name = "txtfinalgrade"
        Me.txtfinalgrade.Size = New System.Drawing.Size(241, 26)
        Me.txtfinalgrade.TabIndex = 3
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(22, 90)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(104, 20)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Finals Grade:"
        '
        'txtmidtermgrade
        '
        Me.txtmidtermgrade.Location = New System.Drawing.Point(208, 26)
        Me.txtmidtermgrade.Name = "txtmidtermgrade"
        Me.txtmidtermgrade.Size = New System.Drawing.Size(241, 26)
        Me.txtmidtermgrade.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(22, 32)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(119, 20)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Midterm Grade:"
        '
        'btnaddData
        '
        Me.btnaddData.Location = New System.Drawing.Point(78, 743)
        Me.btnaddData.Name = "btnaddData"
        Me.btnaddData.Size = New System.Drawing.Size(141, 68)
        Me.btnaddData.TabIndex = 3
        Me.btnaddData.Text = "Add Data"
        Me.btnaddData.UseVisualStyleBackColor = True
        '
        'btnupdate
        '
        Me.btnupdate.Location = New System.Drawing.Point(352, 743)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(133, 68)
        Me.btnupdate.TabIndex = 4
        Me.btnupdate.Text = "Update"
        Me.btnupdate.UseVisualStyleBackColor = True
        '
        'btndel
        '
        Me.btndel.Location = New System.Drawing.Point(631, 743)
        Me.btndel.Name = "btndel"
        Me.btndel.Size = New System.Drawing.Size(146, 68)
        Me.btndel.TabIndex = 5
        Me.btndel.Text = "Delete "
        Me.btndel.UseVisualStyleBackColor = True
        '
        'btnclr
        '
        Me.btnclr.Location = New System.Drawing.Point(926, 743)
        Me.btnclr.Name = "btnclr"
        Me.btnclr.Size = New System.Drawing.Size(153, 68)
        Me.btnclr.TabIndex = 6
        Me.btnclr.Text = "Clear"
        Me.btnclr.UseVisualStyleBackColor = True
        '
        'dgvstudents
        '
        Me.dgvstudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvstudents.Location = New System.Drawing.Point(13, 832)
        Me.dgvstudents.Name = "dgvstudents"
        Me.dgvstudents.RowHeadersWidth = 62
        Me.dgvstudents.RowTemplate.Height = 28
        Me.dgvstudents.Size = New System.Drawing.Size(1136, 193)
        Me.dgvstudents.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(1171, 1050)
        Me.Controls.Add(Me.dgvstudents)
        Me.Controls.Add(Me.btnclr)
        Me.Controls.Add(Me.btndel)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.btnaddData)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.dgvstudents, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtsubject As TextBox
    Friend WithEvents txtfirstname As TextBox
    Friend WithEvents txtlastname As TextBox
    Friend WithEvents txtstudnum As TextBox
    Friend WithEvents label4 As Label
    Friend WithEvents label3 As Label
    Friend WithEvents label2 As Label
    Friend WithEvents label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnsave As Button
    Friend WithEvents txttermgrade As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents btnclear As Button
    Friend WithEvents btncompute As Button
    Friend WithEvents txtmajorexam As TextBox
    Friend WithEvents txtquizzes As TextBox
    Friend WithEvents txtcp As TextBox
    Friend WithEvents cboterm As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtlettergrade As TextBox
    Friend WithEvents txtfinalavg As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents btnaverage As Button
    Friend WithEvents txtfinalgrade As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtmidtermgrade As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents btnaddData As Button
    Friend WithEvents btnupdate As Button
    Friend WithEvents btndel As Button
    Friend WithEvents btnclr As Button
    Friend WithEvents dgvstudents As DataGridView
End Class
