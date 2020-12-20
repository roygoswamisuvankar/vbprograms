Public Class Form1
    Dim A, B As Double
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        A = TextBox1.Text
        B = TextBox2.Text
        If RadioButton1.Checked = True Then
            TextBox3.Text = A + B
        ElseIf RadioButton2.Checked = True Then
            TextBox3.Text = A - B
        ElseIf RadioButton3.Checked = True Then
            TextBox3.Text = A * B
        ElseIf RadioButton4.Checked = True Then
            TextBox3.Text = A / B

        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""

    End Sub
End Class
