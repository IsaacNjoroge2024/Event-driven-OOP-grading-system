Public Class Form1
    Dim tbl As New DataTable("tbl")
    Dim index As New Integer
    Private Sub btncompute_Click(sender As Object, e As EventArgs) Handles btncompute.Click
        Dim cp As Double
        Dim quizzes As Double
        Dim majorexam As Double
        Dim termgrade As Double

        cp = txtcp.Text
        quizzes = txtquizzes.Text
        majorexam = txtmajorexam.Text

        termgrade = (cp * 0.2) + (quizzes * 0.3) + (majorexam * 0.5)
        txttermgrade.Text = termgrade

    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        txtcp.Clear()
        txtquizzes.Clear()
        txtmajorexam.Clear()
        txttermgrade.Clear()
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Dim msg As String
        msg = MessageBox.Show("Do you want to save this grade?", "GRADING SYSTEM", MessageBoxButtons.YesNo)
        If msg = DialogResult.Yes Then
            If cboterm.Text = "Midterm" Then
                txtmidtermgrade.Text = txttermgrade.Text
            ElseIf cboterm.Text = "Finals" Then
                txtfinalgrade.Text = txttermgrade.Text
            Else
                MsgBox("Please select term!", MessageBoxIcon.Warning)
            End If
        End If
    End Sub

    Private Sub btnaverage_Click(sender As Object, e As EventArgs) Handles btnaverage.Click
        Dim mtgrade As Double
        Dim fgrade As Double
        Dim finalavg As Double

        mtgrade = txtmidtermgrade.Text
        fgrade = txtfinalgrade.Text

        finalavg = (mtgrade * 0.5) + (fgrade * 0.5)
        txtfinalavg.Text = finalavg

        If txtfinalavg.Text >= 96 And txtfinalavg.Text <= 100 Then
            txtlettergrade.Text = "A+"
        ElseIf txtfinalavg.Text >= 91 And txtfinalavg.Text <= 95 Then
            txtlettergrade.Text = "A"
        ElseIf txtfinalavg.Text >= 86 And txtfinalavg.Text <= 90 Then
            txtlettergrade.Text = "A-"
        ElseIf txtfinalavg.Text >= 81 And txtfinalavg.Text <= 85 Then
            txtlettergrade.Text = "B+"
        ElseIf txtfinalavg.Text >= 76 And txtfinalavg.Text <= 80 Then
            txtlettergrade.Text = "B"
        ElseIf txtfinalavg.Text >= 71 And txtfinalavg.Text <= 75 Then
            txtlettergrade.Text = "B-"
        ElseIf txtfinalavg.Text >= 66 And txtfinalavg.Text <= 70 Then
            txtlettergrade.Text = "C+"
        ElseIf txtfinalavg.Text >= 61 And txtfinalavg.Text <= 65 Then
            txtlettergrade.Text = "C"
        ElseIf txtfinalavg.Text >= 50 And txtfinalavg.Text <= 60 Then
            txtlettergrade.Text = "C-"
        ElseIf txtfinalavg.Text <= 49 Then
            txtlettergrade.Text = "F"
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbl.Columns.Add("StudentNumber", Type.GetType("System.Int32"))
        tbl.Columns.Add("LastName", Type.GetType("System.String"))
        tbl.Columns.Add("FirstName", Type.GetType("System.String"))
        tbl.Columns.Add("Subject", Type.GetType("System.String"))
        tbl.Columns.Add("Grade", Type.GetType("System.Double"))
        tbl.Columns.Add("Equivalent", Type.GetType("System.String"))
        dgvstudents.DataSource = tbl

    End Sub

    Private Sub btnaddData_Click(sender As Object, e As EventArgs) Handles btnaddData.Click
        tbl.Rows.Add(txtstudnum.Text, txtlastname.Text, txtfirstname.Text, txtsubject.Text, txtfinalavg.Text, txtlettergrade.Text)
        dgvstudents.DataSource = tbl
    End Sub

    Private Sub btnclr_Click(sender As Object, e As EventArgs) Handles btnclr.Click
        txtstudnum.Clear()
        txtlastname.Clear()
        txtfirstname.Clear()
        txtsubject.Clear()
        txtcp.Clear()
        txtquizzes.Clear()
        txtmajorexam.Clear()
        txttermgrade.Clear()
        txtmidtermgrade.Clear()
        txtfinalgrade.Clear()
        txtlettergrade.Clear()

    End Sub

    'Private Sub dgvstudents_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvstudents.CellContentClick

    'End Sub

    Private Sub dgvstudents_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvstudents.CellClick
        index = e.RowIndex
        Dim selected As DataGridViewRow
        selected = dgvstudents.Rows(index)

        txtstudnum.Text = selected.Cells(0).Value.ToString
        txtlastname.Text = selected.Cells(1).Value.ToString
        txtfirstname.Text = selected.Cells(2).Value.ToString
        txtsubject.Text = selected.Cells(3).Value.ToString
        txtfinalavg.Text = selected.Cells(4).Value.ToString
        txtlettergrade.Text = selected.Cells(5).Value.ToString
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        Dim newdata As DataGridViewRow
        newdata = dgvstudents.Rows(index)
        newdata.Cells(0).Value = txtstudnum.Text
        newdata.Cells(1).Value = txtlastname.Text
        newdata.Cells(2).Value = txtfirstname.Text
        newdata.Cells(3).Value = txtsubject.Text
        newdata.Cells(4).Value = txtfinalavg.Text
        newdata.Cells(5).Value = txtlettergrade.Text
    End Sub

    Private Sub btndel_Click(sender As Object, e As EventArgs) Handles btndel.Click
        dgvstudents.Rows.RemoveAt(index)
    End Sub

    Private Sub VScrollBar1_Scroll(sender As Object, e As ScrollEventArgs)

    End Sub
End Class
