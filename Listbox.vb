Public Class Form1
    Dim A, I As Integer
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        A = TextBox1.Text
        I = 1
        Dim item As ListViewItem
        While (I <= A)
            item = ListView1.Items.Add(I)
            I = I + 1
        End While
    End Sub
End Class
