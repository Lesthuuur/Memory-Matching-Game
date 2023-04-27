Imports System.Threading
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button

Public Class memoryGame

    Dim numbers As List(Of Integer) = New List(Of Integer)
    Dim pictures() As Bitmap = {My.Resources.img1, My.Resources.img2, My.Resources.img3,
        My.Resources.img4, My.Resources.img5, My.Resources.img6}
    Dim random As New Random()
    Dim index As Integer

    Dim isBtnClicked As Boolean = False
    Dim countDown As Integer = 30
    Dim timeLimit As Integer = 0
    Dim tries = 0


    Dim largerViewForm As New Form
    Private Sub memoryGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        largerViewForm.AutoSize = True

        timeLeftContainer.Text = ""
        start_restart_btn.Text = "Start"




    End Sub

    Private Sub start_restart_btn_Click(sender As Object, e As EventArgs) Handles start_restart_btn.Click
        isBtnClicked = True

        timeLeftContainer.Text = countDown
        gameTimer.Start()

        If isBtnClicked = True Then
            start_restart_btn.Text = "Restart"
            isBtnClicked = False
            countDown = 30

            'call the function for the game that randomizes the pictures
            For i As Integer = pictures.Length - 1 To 0 Step -1
                index = random.Next(i + 1)
                Dim temp As Bitmap = pictures(index)
                pictures(index) = pictures(i)
                pictures(i) = temp
            Next

            ' assign the shuffled pictures to the picture boxes
            Dim pictureboxindex As Integer = 0
            For Each pb As PictureBox In mainContainerGrpBox.Controls.OfType(Of PictureBox)()
                pb.Image = My.Resources.cover
                pb.SizeMode = PictureBoxSizeMode.CenterImage
                pb.Tag = pictureboxindex Mod 6 ' set the tag to the picture index
                pictureboxindex += 1

                AddHandler pb.Click, AddressOf PictureBox_Click

            Next
        End If

    End Sub

    Private Sub gameTimer_Tick(sender As Object, e As EventArgs) Handles gameTimer.Tick
        gameTimer.Interval = 1000
        countDown -= 1
        timeLeftContainer.Text = countDown
        If countDown = 0 Then
            MessageBox.Show("Time's up!")
            gameTimer.Stop()
        End If
    End Sub

    Private Sub PictureBox_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Get the image associated with the clicked PictureBox
        Dim clickedPictureBox As PictureBox = DirectCast(sender, PictureBox)
        Dim imageIndex As Integer = CInt(clickedPictureBox.Tag)
        Dim clickedImage As Image = pictures(imageIndex)

        ' Display the clicked image in the PictureBox control
        clickedPictureBox.Image = clickedImage
    End Sub


    Private Sub gameStarts()
        While tries <> 12


            tries += 1
        End While
    End Sub


End Class
