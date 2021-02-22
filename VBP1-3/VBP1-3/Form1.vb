Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ColorButton1.Click
        Label1.ForeColor = ColorButton1.ForeColor
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ColorButton2.Click
        Label1.ForeColor = ColorButton2.ForeColor
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles ColorButton3.Click
        Label1.ForeColor = ColorButton3.ForeColor
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles ColorButton4.Click
        Label1.ForeColor = ColorButton4.ForeColor
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles ColorButton5.Click
        Label1.ForeColor = ColorButton5.ForeColor
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ColorButton1.Text = ColorButton1.ForeColor.Name
        ColorButton2.Text = ColorButton2.ForeColor.Name
        ColorButton3.Text = ColorButton3.ForeColor.Name
        ColorButton4.Text = ColorButton4.ForeColor.Name
        ColorButton5.Text = ColorButton5.ForeColor.Name
    End Sub

    Private Sub StyleButton1_Click(sender As Object, e As EventArgs) Handles StyleButton1.Click
        Label1.Font = New Font(Label1.Font.Name, Label1.Font.Size, FontStyle.Bold)
    End Sub

    Private Sub StyleButton2_Click(sender As Object, e As EventArgs) Handles StyleButton2.Click
        Label1.Font = New Font(Label1.Font.Name, Label1.Font.Size, FontStyle.Italic)
    End Sub

    Private Sub StyleButton3_Click(sender As Object, e As EventArgs) Handles StyleButton3.Click
        Label1.Font = New Font(Label1.Font.Name, Label1.Font.Size, FontStyle.Strikeout)
    End Sub

    Private Sub StyleButton4_Click(sender As Object, e As EventArgs) Handles StyleButton4.Click
        Label1.Font = New Font(Label1.Font.Name, Label1.Font.Size, FontStyle.Underline)
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Label1.ForeColor = Color.Black
        Label1.Font = New Font(Label1.Font.Name, Label1.Font.Size, FontStyle.Regular)
    End Sub
End Class
