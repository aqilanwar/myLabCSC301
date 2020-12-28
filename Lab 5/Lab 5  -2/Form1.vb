Imports QRCoder
Public Class Form1

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim gate As Integer

        If gate = 0 Then
            If String.IsNullOrEmpty(TextBox1.Text) Then
                MsgBox("Please enter your email!")
            End If

            If String.IsNullOrEmpty(TextBox2.Text) Then
                MsgBox("Please enter your product!")
            End If

            If String.IsNullOrEmpty(TextBox3.Text) Then
                MsgBox("Please enter your product id!")
            End If
        End If

        Dim gen As New QRCodeGenerator
        Dim data = gen.CreateQrCode(TextBox1.Text, QRCodeGenerator.ECCLevel.Q)
        Dim code As New QRCode(data)
        PictureBox2.Image = code.GetGraphic(6)
    End Sub

    Private Sub OpenFiletxtToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenFiletxtToolStripMenuItem.Click
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub SaveFiletxtToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveFiletxtToolStripMenuItem.Click
        SaveFileDialog1.ShowDialog()
    End Sub

    Private Sub SaveFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk
        Dim writer As New IO.StreamWriter(SaveFileDialog1.FileName)
        Dim sb As New System.Text.StringBuilder
        writer.WriteLine(TextBox1.Text)
        writer.WriteLine(TextBox2.Text)
        writer.WriteLine(TextBox3.Text)
        writer.Close()
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        Dim reader As New IO.StreamReader(OpenFileDialog1.FileName)
        TextBox1.Text = reader.ReadLine
        TextBox2.Text = reader.ReadLine
        TextBox3.Text = reader.ReadLine
        reader.Close()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        About.Show()
    End Sub

    Private Sub ChangeFontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangeFontToolStripMenuItem.Click
        FontDialog1.ShowDialog()

        TextBox1.ForeColor = FontDialog1.Color
        TextBox1.Font = FontDialog1.Font
        TextBox2.Font = FontDialog1.Font
        TextBox3.Font = FontDialog1.Font

    End Sub

    Private Sub FontDialog1_Apply(sender As Object, e As EventArgs) Handles FontDialog1.Apply


    End Sub

    Private Sub ChangeColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangeColorToolStripMenuItem.Click
        ColorDialog1.ShowDialog()

        TextBox1.ForeColor = ColorDialog1.Color
        TextBox2.ForeColor = ColorDialog1.Color
        TextBox3.ForeColor = ColorDialog1.Color

    End Sub

    Private Sub PrintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintToolStripMenuItem.Click
        PrintDialog1.ShowDialog()
    End Sub
End Class
