Public Class Form1
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        SetText("A Short Hike is a tiny open world adventure game. It was created by one person, Robinson-Yu. He made the game with his limited art skills and used stylesed graphics to give thegame some visual apeal. The game is about a young bird named clair, she is staying on an island with her aunt and wants to call her mom. The only place on the island with cell service is the top of the mountain, so clair has to take a short hike to the top. On her way she meets plenty of cool people and ends up learning to enjoy the little things.")
    End Sub

    Private Sub SetText(ByVal inputText As String)
        RichTextBox1.Text = inputText
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        SetText("Hollow Knight is a vast open world platformer set in a kingdom of bugs. It was made by a team of three people from austrailia. I boasts a striking hand drawn art style and a beautifull orchestral soundtrack. The game is about a little kinght who is on a quest to defeat the hollow knight, You have to travel to different areas and defeat bosses to gain abilities that help you reach new areas and get more powerfull.")
    End Sub
End Class
