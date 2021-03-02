Public Class Form1

    Public first As Boolean = True

    Private Sub RadioButton18_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton18.CheckedChanged
        Label3.Text = RadioButton18.Text
        PictureBox2.Image = My.Resources.Artificer
    End Sub

    Private Sub RadioButton8_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton8.CheckedChanged
        Label2.Text = RadioButton8.Text
        PictureBox1.Image = My.Resources.Human
    End Sub

    Private Sub RadioButton7_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton7.CheckedChanged
        Label2.Text = RadioButton7.Text
        PictureBox1.Image = My.Resources.Half_Orc
    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged
        Label2.Text = RadioButton6.Text
        PictureBox1.Image = My.Resources.Halfling
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        Label2.Text = RadioButton5.Text
        PictureBox1.Image = My.Resources.Half_Elf
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        Label2.Text = RadioButton4.Text
        PictureBox1.Image = My.Resources.Gnome

    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        Label2.Text = RadioButton3.Text
        PictureBox1.Image = My.Resources.Elf
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        Label2.Text = RadioButton2.Text
        PictureBox1.Image = My.Resources.Dwarf
    End Sub

    Private Sub RadioButton22_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton22.CheckedChanged
        Label3.Text = RadioButton22.Text
        PictureBox2.Image = My.Resources.Wizard
    End Sub

    Private Sub RadioButton21_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton21.CheckedChanged
        Label3.Text = RadioButton21.Text
        PictureBox2.Image = My.Resources.Warlock
    End Sub

    Private Sub RadioButton20_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton20.CheckedChanged
        Label3.Text = RadioButton20.Text
        PictureBox2.Image = My.Resources.Sorcerer
    End Sub

    Private Sub RadioButton19_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton19.CheckedChanged
        Label3.Text = RadioButton19.Text
        PictureBox2.Image = My.Resources.Rogue
    End Sub

    Private Sub RadioButton10_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton10.CheckedChanged
        Label3.Text = RadioButton10.Text
        PictureBox2.Image = My.Resources.Ranger
    End Sub

    Private Sub RadioButton11_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton11.CheckedChanged
        Label3.Text = RadioButton11.Text
        PictureBox2.Image = My.Resources.Paladin
    End Sub

    Private Sub RadioButton12_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton12.CheckedChanged
        Label3.Text = RadioButton12.Text
        PictureBox2.Image = My.Resources.Monk
    End Sub

    Private Sub RadioButton13_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton13.CheckedChanged
        Label3.Text = RadioButton13.Text
        PictureBox2.Image = My.Resources.Fighter
    End Sub

    Private Sub RadioButton14_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton14.CheckedChanged
        Label3.Text = RadioButton14.Text
        PictureBox2.Image = My.Resources.Druid
    End Sub

    Private Sub RadioButton15_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton15.CheckedChanged
        Label3.Text = RadioButton15.Text
        PictureBox2.Image = My.Resources.Cleric
    End Sub

    Private Sub RadioButton16_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton16.CheckedChanged
        Label3.Text = RadioButton16.Text
        PictureBox2.Image = My.Resources.Bard
    End Sub

    Private Sub RadioButton17_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton17.CheckedChanged
        Label3.Text = RadioButton17.Text
        PictureBox2.Image = My.Resources.Barbarian
    End Sub

    Private Sub RadioButton9_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton9.CheckedChanged
        Label2.Text = RadioButton9.Text
        PictureBox1.Image = My.Resources.Teifling
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        Label2.Text = RadioButton1.Text
        PictureBox1.Image = My.Resources.DrangonBorn
    End Sub

    Private Sub RadioButton24_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton24.CheckedChanged
        Label5.Text = RadioButton24.Text
    End Sub

    Private Sub RadioButton25_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton25.CheckedChanged
        Label5.Text = RadioButton25.Text
    End Sub

    Private Sub RadioButton26_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton26.CheckedChanged
        Label5.Text = RadioButton26.Text
    End Sub

    Private Sub RadioButton27_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton27.CheckedChanged
        Label5.Text = RadioButton27.Text
    End Sub

    Private Sub RadioButton28_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton28.CheckedChanged
        Label5.Text = RadioButton28.Text
    End Sub

    Private Sub RadioButton32_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton32.CheckedChanged
        Label5.Text = RadioButton32.Text
    End Sub

    Private Sub RadioButton33_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton33.CheckedChanged
        Label5.Text = RadioButton33.Text
    End Sub

    Private Sub RadioButton34_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton34.CheckedChanged
        Label5.Text = RadioButton34.Text
    End Sub

    Private Sub RadioButton23_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton23.CheckedChanged
        Label5.Text = RadioButton23.Text
    End Sub

    Private Sub RadioButton29_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton29.CheckedChanged
        Label7.Text = RadioButton29.Text
    End Sub

    Private Sub RadioButton30_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton30.CheckedChanged
        Label7.Text = RadioButton30.Text
    End Sub

    Private Sub RadioButton31_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton31.CheckedChanged
        Label7.Text = RadioButton31.Text
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Label9.BackColor = Button6.BackColor
        Dim Inverse As Long
        Inverse = RGB(255 - Button6.BackColor.R, 255 - Button6.BackColor.G, 255 - Button6.BackColor.B)
        Label9.ForeColor = Color.FromArgb(Inverse)
        Label9.Text = Button6.BackColor.Name
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Label9.BackColor = Button5.BackColor
        Dim Inverse As Long
        Inverse = RGB(255 - Button5.BackColor.R, 255 - Button5.BackColor.G, 255 - Button5.BackColor.B)
        Label9.ForeColor = Color.FromArgb(Inverse)
        Label9.Text = Button5.BackColor.Name
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Label9.BackColor = Button4.BackColor
        Dim Inverse As Long
        Inverse = RGB(255 - Button4.BackColor.R, 255 - Button4.BackColor.G, 255 - Button4.BackColor.B)
        Label9.ForeColor = Color.FromArgb(Inverse)
        Label9.Text = Button4.BackColor.Name
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Label9.BackColor = Button3.BackColor
        Dim Inverse As Long
        Inverse = RGB(255 - Button3.BackColor.R, 255 - Button3.BackColor.G, 255 - Button3.BackColor.B)
        Label9.ForeColor = Color.FromArgb(Inverse)
        Label9.Text = Button3.BackColor.Name
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label9.BackColor = Button2.BackColor
        Dim Inverse As Long
        Inverse = RGB(255 - Button2.BackColor.R, 255 - Button2.BackColor.G, 255 - Button2.BackColor.B)
        Label9.ForeColor = Color.FromArgb(Inverse)
        Label9.Text = Button2.BackColor.Name
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label9.BackColor = Button1.BackColor
        Dim Inverse As Long
        Inverse = RGB(255 - Button1.BackColor.R, 255 - Button1.BackColor.G, 255 - Button1.BackColor.B)
        Label9.ForeColor = Color.FromArgb(Inverse)
        Label9.Text = Button1.BackColor.Name
    End Sub

    Private Sub Form1_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        If (first = True) Then
            RadioButton1.Checked = False
            Label2.Text = ""
            PictureBox1.Image = Nothing
            PictureBox2.Image = Nothing
            first = False
        End If
    End Sub
End Class
