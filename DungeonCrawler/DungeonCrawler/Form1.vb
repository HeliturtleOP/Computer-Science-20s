Public Class Form1

    Dim x = 0, y = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        x = 5
        y = 8
        Label1.Text = x & y
    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        Select Case e.KeyCode
            Case Keys.W
                y -= 1
            Case Keys.A
                x -= 1
            Case Keys.S
                y += 1
            Case Keys.D
                x += 1
        End Select
        PictureBox1.Location = New Point(x * 50, y * 50)
    End Sub
End Class
