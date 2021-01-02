Public Class Form
    Dim A, I, sum, n As Integer
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        A = TextBox1.Text
        I = 1
        Dim Item As ListViewItem
        While (I <= A)
            n = TextBox3.Text
            sum = sum + I ^ n
            Item = ListView1.Items.Add(I ^ n & "+")
            I = I + 1
        End While
        TextBox2.Text = sum
    End Sub
    Dim Item As ListViewItem
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        ListView1.Items.Clear()
    End Sub
End Class
