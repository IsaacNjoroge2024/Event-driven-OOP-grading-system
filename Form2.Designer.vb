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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblMarkHeader = New System.Windows.Forms.Label()
        Me.lblGradeHeader = New System.Windows.Forms.Label()
        Me.txtMark = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblGrade = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(561, 100)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(214, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Grading System"
        '
        'lblMarkHeader
        '
        Me.lblMarkHeader.AutoSize = True
        Me.lblMarkHeader.Location = New System.Drawing.Point(12, 174)
        Me.lblMarkHeader.Name = "lblMarkHeader"
        Me.lblMarkHeader.Size = New System.Drawing.Size(75, 20)
        Me.lblMarkHeader.TabIndex = 3
        Me.lblMarkHeader.Text = "Mark/100"
        '
        'lblGradeHeader
        '
        Me.lblGradeHeader.AutoSize = True
        Me.lblGradeHeader.Location = New System.Drawing.Point(12, 251)
        Me.lblGradeHeader.Name = "lblGradeHeader"
        Me.lblGradeHeader.Size = New System.Drawing.Size(54, 20)
        Me.lblGradeHeader.TabIndex = 4
        Me.lblGradeHeader.Text = "Grade"
        '
        'txtMark
        '
        Me.txtMark.Location = New System.Drawing.Point(188, 168)
        Me.txtMark.Name = "txtMark"
        Me.txtMark.Size = New System.Drawing.Size(228, 26)
        Me.txtMark.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(31, 315)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(178, 66)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Grade"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblGrade
        '
        Me.lblGrade.AutoSize = True
        Me.lblGrade.Location = New System.Drawing.Point(184, 251)
        Me.lblGrade.Name = "lblGrade"
        Me.lblGrade.Size = New System.Drawing.Size(25, 20)
        Me.lblGrade.TabIndex = 10
        Me.lblGrade.Text = "...."
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(290, 315)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(177, 66)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Exit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(585, 393)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.lblGrade)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtMark)
        Me.Controls.Add(Me.lblGradeHeader)
        Me.Controls.Add(Me.lblMarkHeader)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents lblMarkHeader As Label
    Friend WithEvents lblGradeHeader As Label
    Friend WithEvents txtMark As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents lblGrade As Label
    Friend WithEvents Button2 As Button
End Class
