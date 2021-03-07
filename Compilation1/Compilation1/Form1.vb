Public Class Form1
    Dim img As Bitmap = New Bitmap(My.Resources.Rilakkuma)
    Dim editImg As Bitmap = New Bitmap(img)
    Dim colors(,,) = {{{168, 120, 68}, {169, 136, 78}, {139, 94, 59}, {0, 0, 0}, {255, 255, 255}}, {{245, 177, 42}, {255, 255, 255}, {199, 198, 198}, {172, 172, 172}, {34, 29, 25}}, {{237, 205, 67}, {247, 148, 29}, {0, 0, 0}, {241, 89, 42}, {239, 64, 54}}, {{195, 214, 53}, {237, 46, 79}, {248, 177, 189}, {254, 254, 254}, {38, 35, 33}}}
    Dim col As Integer = 1
    Dim character As Integer = 4
    Dim Accesorie As Integer = 4
    Dim first As Boolean = True
    Dim characterName() = {"Rilakkuma", "Gutedama", "Kiiroitori", "Keroppi", ""}
    Dim accespriesName() = {"Pirate ", "Covid ", "Mature ", "Fancy ", ""}
    Dim displayNameTemp As String = "1234Name"
    Dim displayName As String = ""

    Dim _eyePatch As Boolean
    Dim _Mask As Boolean
    Dim _Moustache As Boolean
    Dim _Monacle As Boolean

    Public Sub ChangeColor(ByRef color, ByRef part)

        Dim x As Integer
        Dim y As Integer
        Dim red As Byte
        Dim green As Byte
        Dim blue As Byte
        Dim alpha As Byte

        col = part

        For x = 0 To img.Width - 1
            For y = 0 To img.Height - 1
                red = img.GetPixel(x, y).R
                green = img.GetPixel(x, y).G
                blue = img.GetPixel(x, y).B
                alpha = img.GetPixel(x, y).A

                If red = colors(character, col, 0) And green = colors(character, col, 1) And blue = colors(character, col, 2) And alpha <> 0 Then
                    editImg.SetPixel(x, y, color)
                End If

            Next
        Next

        PictureBox1.Image = editImg
    End Sub

    Public Sub setButtonColor()

        SetLabel()

        For i As Integer = 1 To 5
            Dim btns() = Controls.Find("Button" & i, True)
            Dim btn As Button
            If btns IsNot Nothing Then
                btn = btns(0)
                btn.Visible = True
                btn.BackColor = Color.FromArgb(colors(character, i - 1, 0), colors(character, i - 1, 1), colors(character, i - 1, 2))
            End If
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ColorDialog1.ShowDialog()
        ChangeColor(ColorDialog1.Color, 1)
        Button2.BackColor = ColorDialog1.Color
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ColorDialog1.ShowDialog()
        ChangeColor(ColorDialog1.Color, 0)
        Button1.BackColor = ColorDialog1.Color
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ColorDialog1.ShowDialog()
        ChangeColor(ColorDialog1.Color, 2)
        Button3.BackColor = ColorDialog1.Color
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ColorDialog1.ShowDialog()
        ChangeColor(ColorDialog1.Color, 3)
        Button4.BackColor = ColorDialog1.Color
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ColorDialog1.ShowDialog()
        ChangeColor(ColorDialog1.Color, 4)
        Button5.BackColor = ColorDialog1.Color
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        img = New Bitmap(My.Resources.Rilakkuma)
        editImg = New Bitmap(img)
        PictureBox1.Image = img
        character = 0
        EyePatch()
        MediaclMask()
        Moustache()
        Monacle()
        setButtonColor()

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        img = New Bitmap(My.Resources.Gutedama)
        editImg = New Bitmap(img)
        PictureBox1.Image = img
        character = 1
        EyePatch()
        MediaclMask()
        Moustache()
        Monacle()
        setButtonColor()

    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        img = New Bitmap(My.Resources.Kiiroitori)
        editImg = New Bitmap(img)
        PictureBox1.Image = img
        character = 2
        EyePatch()
        MediaclMask()
        Moustache()
        Monacle()
        setButtonColor()

    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        img = New Bitmap(My.Resources.Keroppi)
        editImg = New Bitmap(img)
        PictureBox1.Image = img
        character = 3
        EyePatch()
        MediaclMask()
        Moustache()
        Monacle()


        setButtonColor()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        End
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

        Label2.Text = ""

        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        CheckBox4.Checked = False
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False
        RadioButton4.Checked = False
        PictureBox1.Image = Nothing
        For i As Integer = 1 To 5
            Dim btns() = Controls.Find("Button" & i, True)
            Dim btn As Button
            If btns IsNot Nothing Then
                btn = btns(0)
                btn.Visible = False
            End If
        Next

        SetLabel()

    End Sub

    Private Sub Form1_Activated(sender As Object, e As EventArgs) Handles Me.Activated

        If first = True Then

            Label2.Text = ""
            character = 4
            PictureBox9.Parent = PictureBox1
            PictureBox9.Location = PictureBox9.Location - PictureBox1.Location
            PictureBox9.Visible = False

            PictureBox7.Parent = PictureBox1
            PictureBox7.Location = PictureBox7.Location - PictureBox1.Location
            PictureBox7.Visible = False

            PictureBox6.Parent = PictureBox1
            PictureBox6.Location = PictureBox6.Location - PictureBox1.Location
            PictureBox6.Visible = False

            PictureBox8.Parent = PictureBox1
            PictureBox8.Location = PictureBox8.Location - PictureBox1.Location
            PictureBox8.Visible = False

            RadioButton1.Checked = False
            PictureBox1.Image = Nothing
            For i As Integer = 1 To 5
                Dim btns() = Controls.Find("Button" & i, True)
                Dim btn As Button
                If btns IsNot Nothing Then
                    btn = btns(0)
                    btn.Visible = False
                End If
            Next

            SetLabel()

            first = False
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

        EyePatch()
        If CheckBox1.Checked = False Then
            Accesorie = 3
        End If

    End Sub

    Public Sub EyePatch()

        If PictureBox1.Image IsNot Nothing Then
            Accesorie = 0
            Dim pnts() = {New Point(220, 129), New Point(308, 137), New Point(294, 111), New Point(306, 102), New Point}
            Dim sze() = {New Size(263, 142), New Size(110, 91), New Size(147, 105), New Size(160, 105), New Size}

            _eyePatch = CheckBox1.Checked
            SetLabel()

            PictureBox6.Visible = CheckBox1.Checked
            PictureBox6.Size = New Size(sze(character))
            PictureBox6.Location = New Point(pnts(character)) - PictureBox1.Location
        End If


    End Sub

    Public Sub MediaclMask()

        If PictureBox1.Image IsNot Nothing Then
            Accesorie = 1
            Dim pnts() = {New Point(270, 194), New Point(336, 169), New Point(299, 150), New Point(307, 147), New Point}
            Dim sze() = {New Size(222, 162), New Size(95, 83), New Size(161, 129), New Size(161, 120), New Size}

            _Mask = CheckBox2.Checked
            SetLabel()

            PictureBox7.Visible = CheckBox2.Checked
            PictureBox7.Size = New Size(sze(character))
            PictureBox7.Location = New Point(pnts(character)) - PictureBox1.Location
        End If


    End Sub

    Public Sub Moustache()

        If PictureBox1.Image IsNot Nothing Then
            Accesorie = 2
            Dim pnts() = {New Point(323, 202), New Point(331, 159), New Point(327, 166), New Point(325, 168), New Point}
            Dim sze() = {New Size(117, 101), New Size(106, 76), New Size(106, 76), New Size(123, 92), New Size}

            _Moustache = CheckBox3.Checked
            SetLabel()

            PictureBox8.Visible = CheckBox3.Checked
            PictureBox8.Size = New Size(sze(character))
            PictureBox8.Location = New Point(pnts(character)) - PictureBox1.Location
        End If


    End Sub

    Public Sub Monacle()
        If PictureBox1.Image IsNot Nothing Then
            Accesorie = 3
            Dim pnts() = {New Point(230, 180), New Point(309, 169), New Point(298, 147), New Point(295, 92), New Point}
            Dim sze() = {New Size(100, 120), New Size(68, 52), New Size(58, 77), New Size(92, 131), New Size}

            _Monacle = CheckBox4.Checked
            SetLabel()

            PictureBox9.Visible = CheckBox4.Checked
            PictureBox9.Size = New Size(sze(character))
            PictureBox9.Location = New Point(pnts(character)) - PictureBox1.Location
        End If


    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        MediaclMask()
        'Accesorie = 1
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        Moustache()
        'Accesorie = 2
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        Monacle()
        'Accesorie = 3
    End Sub

    Public Sub SetLabel()

        displayName = displayNameTemp.Replace("Name", characterName(character))
        Dim one As String = displayName
        If _eyePatch = True Then
            displayName = one.Replace("1", accespriesName(0))
        Else
            displayName = one.Replace("1", accespriesName(4))
        End If
        Dim two As String = displayName
        If _Mask = True Then
            displayName = two.Replace("2", accespriesName(1))
        Else
            displayName = two.Replace("2", accespriesName(4))
        End If
        Dim three As String = displayName
        If _Moustache = True Then
            displayName = three.Replace("3", accespriesName(2))
        Else
            displayName = three.Replace("3", accespriesName(4))
        End If
        Dim four As String = displayName
        If _Monacle = True Then
            displayName = four.Replace("4", accespriesName(3))
        Else
            displayName = four.Replace("4", accespriesName(4))
        End If

        If PictureBox1.Image IsNot Nothing Then
            Label2.Text = displayName
        Else
            Label2.Text = New String("")
        End If



    End Sub
End Class
