Public Class Form2
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub
    Dim grade As Decimal
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        grade = Val(txtMark.Text)

        If (grade >= 90) Then lblGrade.Text = "A"
        If (grade <= 89) Then lblGrade.Text = "B"
        If (grade <= 79) Then lblGrade.Text = "C"
        If (grade <= 69) Then lblGrade.Text = "D"
        If (grade <= 59) Then lblGrade.Text = "E"
        If (grade <= 49) Then lblGrade.Text = "F"

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles lblGrade.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub
End Class