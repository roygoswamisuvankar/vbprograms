Public Class Form1

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "Black" Then
            Me.BackColor = Color.Black
        ElseIf ComboBox1.Text = "Blue" Then
            Me.BackColor = Color.Blue
        ElseIf ComboBox1.Text = "Red" Then
            Me.BackColor = Color.Red
        ElseIf ComboBox1.Text = "Green" Then
            Me.BackColor = Color.Green
        ElseIf ComboBox1.Text = "Yellow" Then
            Me.BackColor = Color.Yellow
        ElseIf ComboBox1.Text = "Cyan" Then
            Me.BackColor = Color.Cyan
        ElseIf ComboBox1.Text = "White" Then
            Me.BackColor = Color.White
        End If
    End Sub
End Class
