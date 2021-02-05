Public Class Form1


    Dim subject(5) As Label
    Dim subjectscore1(5, 2) As TextBox


    Private Sub testscore_Load() Handles MyBase.Load
        subject(0) = Label1
        subject(1) = Label2
        subject(2) = Label3
        subject(3) = Label4
        subject(4) = Label5

        subjectscore1(0, 0) = TextBox1
        subjectscore1(1, 0) = TextBox2
        subjectscore1(2, 0) = TextBox3
        subjectscore1(3, 0) = TextBox4
        subjectscore1(4, 0) = TextBox5
        subjectscore1(0, 1) = TextBox8
        subjectscore1(1, 1) = TextBox9
        subjectscore1(2, 1) = TextBox10
        subjectscore1(3, 1) = TextBox11
        subjectscore1(4, 1) = TextBox12






    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim totalScore1 As Double = 0

        Dim average As Double = 0

        TextBox13.Text = (Convert.ToInt32(TextBox1.Text)) + (Convert.ToInt32(TextBox8.Text))
        TextBox14.Text = (Convert.ToInt32(TextBox2.Text)) + (Convert.ToInt32(TextBox9.Text))
        TextBox15.Text = (Convert.ToInt32(TextBox3.Text)) + (Convert.ToInt32(TextBox10.Text))
        TextBox16.Text = (Convert.ToInt32(TextBox4.Text)) + (Convert.ToInt32(TextBox11.Text))
        TextBox17.Text = (Convert.ToInt32(TextBox5.Text)) + (Convert.ToInt32(TextBox12.Text))




        For i As Integer = 1 To 5
            For j As Integer = 1 To 2
                totalScore1 += CDbl(subjectscore1(i - 1, j - 1).Text)
            Next
        Next







        TextBox6.Text = totalScore1

        average = totalScore1 / 5

        TextBox7.Text = (average)

    End Sub


End Class
