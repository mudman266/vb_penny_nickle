Public Class Form1
    Private Sub radPenny_CheckedChanged(sender As Object, e As EventArgs) Handles radPenny.CheckedChanged, radNickle.CheckedChanged
        ' Verify input
        If Not IsNumeric(txtNumDays.Text) Then
            MsgBox("Working days was invalid. Try again.")
            Exit Sub
        End If
        If txtNumDays.Text < 10 Or txtNumDays.Text > 22 Then
            MsgBox("Working days was invalid. Must be between 10 and 22. Try again.")
            Exit Sub
        End If

        Dim decStartingValue As Decimal
        Dim decCurrentValue As Decimal
        Dim decTotalPay As Decimal
        Dim intWorkDays As Decimal = txtNumDays.Text
        Dim i As Integer
        If radPenny.Checked Then
            decStartingValue = 0.01
            decCurrentValue = decStartingValue
            decTotalPay = decCurrentValue
        Else
            decStartingValue = 0.05
            decCurrentValue = decStartingValue
            decTotalPay = decCurrentValue
        End If

        For i = 2 To intWorkDays
            decCurrentValue = decCurrentValue * 2
            decTotalPay += decCurrentValue
        Next
        lblTotalPay.Text = "Total Pay: " & decTotalPay.ToString("C2")

    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        radNickle.Checked = False
        radPenny.Checked = False
        lblTotalPay.Text = "Total Pay: "
        txtNumDays.Text = ""
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub
End Class
