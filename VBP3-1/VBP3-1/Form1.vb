Public Class Form1

    Private Sub SetText(ByVal titleText As String, ByVal inputText As String)
        RichTextBox1.Text = inputText
        Label1.Text = titleText
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        SetText("A Short Hike", "A Short Hike is a tiny open-world adventure game. It was created by one person, Robinson-Yu. He made the game with his limited art skills and used stylized graphics to give the game some visual appeal. The game is about a young bird named Clair, she is staying on an island with her aunt and wants to call her mom. The only place on the island with cell service is the top of the mountain, so Clair has to take a short hike to the top. On her way, she meets plenty of cool people and ends up learning to enjoy the little things.")
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        SetText("Hollow Knight", "Hollow Knight is a vast open-world platformer set in a kingdom of bugs. It was made by a team of three people from Australia. It boasts a striking hand-drawn art style and a beautiful orchestral soundtrack. The game is about a little knight who is on a quest to defeat the hollow knight, You have to travel to different areas and defeat bosses to gain abilities that help you reach new areas and get more powerful.")
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        SetText("Ape Out", "Ape Out is a top-down action game where you play as an ape and have to escape from a facility. The gameplay is fun and engaging, the controls are simple and intuitive and you can get a lot of meaningful interactions out of the mechanics. The highlight for me is the soundtrack, it is procedurally generated as you play. So if you were to attack someone, a cymbal might crash and the music reflects your choices. It’s basically a long drum solo that breaks out into the song You've Got to Have Freedom by Pharaoh Sanders at the end of the game.")
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        SetText("The White Door", "The White Door is a top-down point-and-click adventure game, you play as a man in a mental institution as you interact with your surroundings to discover your past. The game is part of a series of roughly a dozen games that all have connections to each other and all take place in the same universe and center around Rusty Lake. I love games as a storytelling medium and this game uses the format in a wonderful way to tell its story.")
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        SetText("GRIS", "GRIS is a game about a girl who loses her voice in a very literal way. She travels across a vast land and faces challenges in order to gain powers that help her progress. The word is in french means gray, and the game starts out with very little colour, it is mostly black and white except for the main character who had blue hair. Throughout the game, as you unlock powers you restore colours to the world. it's a beautiful game and also has a professional orchestral soundtrack.")
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        SetText("Nidhogg", "Nidhogg is a very simple game, you are a person with a sword and you have to fight other people with swords, you have a fairly limited number of options in any given situation and your enemy has just as many ways to counter you. The game uses simplicity to its advantage and has a very fun gameplay loop. It's probably better with friends but the single player was fun and managed to entertain me for a few days.")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SetText("Indie Games", "")
    End Sub
End Class
