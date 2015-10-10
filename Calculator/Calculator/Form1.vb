Public Class Form1
    Dim fungsi As Integer
    Dim angka1 As Integer
    Dim angka2 As Integer
    Dim operasi As Integer

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        TextBox1.Text = "0"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = "1"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = "2"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = "3"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox1.Text = "4"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.Text = "5"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TextBox1.Text = "6"
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        TextBox1.Text = "7"
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        TextBox1.Text = "8"
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        TextBox1.Text = "9"
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        operasi = 1
        angka1 = TextBox1.Text
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        operasi = 2
        angka1 = TextBox1.Text
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        
        angka2 = TextBox1.Text
        Select Case operasi
            Case Is = 1
                fungsi = angka1 + angka2
            Case Is = 2
                fungsi = angka1 - angka2
        End Select
        TextBox1.Text = fungsi.ToString()
    End Sub


    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        TextBox1.Text = "0"
    End Sub
End Class
