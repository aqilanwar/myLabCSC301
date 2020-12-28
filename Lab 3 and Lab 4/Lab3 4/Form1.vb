Public Class Form1
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If (ComboBox1.SelectedItem Is "Razer Book 13") Then
            Label5.Text = "RM 1000.00"
        ElseIf (ComboBox1.SelectedItem Is "Razer Blade Base") Then
            ComboBox1.SelectedValue = 2.0
            Label5.Text = "RM 2000.00"
        ElseIf (ComboBox1.SelectedItem Is "Razer Blade Stealth 13") Then
            Label5.Text = "RM 3000.00"
        ElseIf (ComboBox1.SelectedItem Is "Razer Blade 15") Then
            Label5.Text = "RM 4000.00"
        Else
            MsgBox("Please select a valid product !!!")
        End If

    End Sub
    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        If (ComboBox2.SelectedItem Is "Razer BlackWidow V3 Pro") Then
            Label6.Text = "RM 100.00"
        ElseIf (ComboBox2.SelectedItem Is "Razer Huntsman Mini") Then
            Label6.Text = "RM 200.00"
        ElseIf (ComboBox2.SelectedItem Is "Razer Cynosa V2") Then
            Label6.Text = "RM 300.00"
        Else
            MsgBox("Please select a valid product !!!")
        End If

    End Sub
    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        If (ComboBox3.SelectedItem Is "Razer Naga") Then
            Label7.Text = "RM 100.00"
        ElseIf (ComboBox3.SelectedItem Is "Razer Ornata") Then
            ComboBox1.SelectedValue = 2.0
            Label7.Text = "RM 200.00"
        ElseIf (ComboBox3.SelectedItem Is "Razer Abyssus") Then
            Label7.Text = "RM 300.00"
        ElseIf (ComboBox3.SelectedItem Is "Razer Tartarus") Then
            Label7.Text = "RM 400.00"
        Else
            MsgBox("Please select a valid product !!!")
        End If

    End Sub

    Private Sub ComboBox3_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged

    End Sub

    Private Sub PAY_Click(sender As Object, e As EventArgs) Handles PAY.Click

        Dim price1 As Double
        Dim price2 As Double
        Dim price3 As Double
        Dim total As Double
        Dim finaltotal As Double
        Dim yes As Integer


        If (ComboBox1.SelectedItem Is "Razer Book 13") Then
            price1 = 1000.0
            yes = 1
        ElseIf (ComboBox1.SelectedItem Is "Razer Blade Base") Then
            price1 = 2000.0
            yes = 1
        ElseIf (ComboBox1.SelectedItem Is "Razer Blade Stealth 13") Then
            price1 = 3000.0
            yes = 1
        ElseIf (ComboBox1.SelectedItem Is "Razer Blade 15") Then
            price1 = 4000.0
            yes = 1
        ElseIf (ComboBox1.SelectedItem Is "") Then
            price1 = 0.0
            yes = 1
        Else
            MsgBox("Please select a valid product !!!")
            yes = 0
        End If

        If (ComboBox2.SelectedItem Is "Razer BlackWidow V3 Pro") Then
            price2 = 100.0
            yes = 1
        ElseIf (ComboBox2.SelectedItem Is "Razer Huntsman Mini") Then
            price2 = 200.0
            yes = 1
        ElseIf (ComboBox2.SelectedItem Is "Razer Cynosa V2") Then
            price2 = 300.0
            yes = 1
        ElseIf (ComboBox2.SelectedItem Is "") Then
            price2 = 0.0
            yes = 1
        Else
            MsgBox("Please select a valid product !!!")
            yes = 0
        End If

        If (ComboBox3.SelectedItem Is "Razer Naga") Then
            price3 = 100.0
            yes = 1
        ElseIf (ComboBox3.SelectedItem Is "Razer Ornata") Then
            price3 = 200.0
            yes = 1
        ElseIf (ComboBox3.SelectedItem Is "Razer Abyssus") Then
            price3 = 300.0
            yes = 1
        ElseIf (ComboBox3.SelectedItem Is "Razer Tartarus") Then
            price3 = 400.0
            yes = 1
        ElseIf (ComboBox3.SelectedItem Is " ") Then
            price3 = 0.0
            yes = 1
        Else
            MsgBox("Please select a valid product !!!")
            yes = 0
        End If

        total = price1 + price2 + price3
        If yes > 0 Then
            If price1 And price2 And price3 > 0 Then
                finaltotal = total * 0.7
                MsgBox("Total Before Discount = RM" + total.ToString + vbNewLine + "Total After Discount : RM " + finaltotal.ToString)
            Else
                MsgBox("Total Price : RM" + total.ToString)

            End If
        End If

    End Sub


End Class
