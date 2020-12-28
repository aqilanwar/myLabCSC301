Public Class Form1
    Dim oil, lube, radiator, transmission, inspection, muffler, tire, part, grandtotal As Double
    Dim labor As Integer
    Private Sub ClearOilLub()
        oilChangeBox.Checked = False
        lubeJobBox.Checked = False
    End Sub
    Private Sub ClearFlushes()
        radiatorBox.Checked = False
        transmissionBox.Checked = False
    End Sub
    Private Sub ClearMisc()
        inspectionBox.Checked = False
        mufflerBox.Checked = False
        tireBox.Checked = False
    End Sub

    Private Sub ClearOther()
        partBox.Clear()
        laborBox.Clear()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles clearButton.Click
        ClearOilLub()
        ClearFlushes()
        ClearMisc()
        ClearOther()
        ClearFees()
    End Sub
    Private Sub ClearFees()
        part_summary.Clear()
        serviceLabor_summary.Clear()
        totalfees_summary.Clear()
        tax_summary.Clear()
    End Sub

    Private Sub BlackAndYellowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BlackAndYellowToolStripMenuItem.Click
        part_summary.ForeColor = Color.Black
        part_summary.BackColor = Color.Yellow
        serviceLabor_summary.ForeColor = Color.Black
        serviceLabor_summary.BackColor = Color.Yellow
        tax_summary.ForeColor = Color.Black
        tax_summary.BackColor = Color.Yellow
        totalfees_summary.ForeColor = Color.Black
        totalfees_summary.BackColor = Color.Yellow
    End Sub

    Private Sub BlackAndGreenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BlackAndGreenToolStripMenuItem.Click
        part_summary.ForeColor = Color.LightGreen
        part_summary.BackColor = Color.Black
        serviceLabor_summary.ForeColor = Color.LightGreen
        serviceLabor_summary.BackColor = Color.Black
        tax_summary.ForeColor = Color.LightGreen
        tax_summary.BackColor = Color.Black
        totalfees_summary.ForeColor = Color.LightGreen
        totalfees_summary.BackColor = Color.Black
    End Sub

    Private Sub NormalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NormalToolStripMenuItem.Click
        part_summary.ForeColor = Color.LightPink
        part_summary.BackColor = Color.DarkRed
        serviceLabor_summary.ForeColor = Color.LightPink
        serviceLabor_summary.BackColor = Color.DarkRed
        tax_summary.ForeColor = Color.LightPink
        tax_summary.BackColor = Color.DarkRed
        totalfees_summary.ForeColor = Color.LightPink
        totalfees_summary.BackColor = Color.DarkRed
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Function OilLubeCharges(ByVal oil As Double, ByVal lube As Double)
        Dim totaloil As Double

        If oilChangeBox.Checked = True Then
            oil = 91
        Else
            oil = 0
        End If

        If lubeJobBox.Checked = True Then
            lube = 63
        Else
            lube = 0
        End If

        totaloil = oil + lube

        Return totaloil
    End Function

    Private Function FlushCharges(ByVal radiator As Double, ByVal transmission As Double)
        Dim totalflush As Double
        If radiatorBox.Checked = True Then
            radiator = 105
        Else
            radiator = 0
        End If

        If transmissionBox.Checked = True Then
            transmission = 280
        Else
            transmission = 0
        End If

        totalflush = radiator + transmission

        Return totalflush
    End Function


    Private Function MiscCharges(ByVal inspection As Double, ByVal muffler As Double, ByVal tire As Double)

        Dim totalMisc As Double

        If inspectionBox.Checked = True Then
            inspection = 52
        Else
            inspection = 0
        End If

        If mufflerBox.Checked = True Then
            muffler = 350
        Else
            muffler = 0
        End If

        If tireBox.Checked = True Then
            tire = 70
        Else
            tire = 0
        End If

        totalMisc = inspection + muffler + tire

        Return totalMisc
    End Function

    Private Function OtherCharges(ByVal part As Double, ByVal labor As Integer)
        Dim totalother

        part = Val(partBox.Text)
        labor = Val(laborBox.Text)
        totalother = part + (labor * 70)

        Return totalother
    End Function

    Friend WithEvents LinkLabel1 As LinkLabel

    Private Function TaxCharges(ByVal part)
        Dim tax As Double

        part = Val(partBox.Text)
        tax = part * 0.06

        Return tax
    End Function

    Private Function TotalCharges(ByVal grandtotal As Double)
        Dim Gtotaloil, Gtotalflush, Gtotalmisc, Gtotalother, Gtotaltax As Double

        Gtotaloil = OilLubeCharges(oil, lube)
        Gtotalflush = FlushCharges(radiator, transmission)
        Gtotalmisc = MiscCharges(inspection, muffler, tire)
        Gtotalother = OtherCharges(part, labor)
        Gtotaltax = TaxCharges(part)

        grandtotal = Gtotaloil + Gtotalflush + Gtotalmisc + Gtotalother + Gtotaltax
        Return grandtotal

    End Function
    Private Sub calculateButton_Click(sender As Object, e As EventArgs) Handles calculateButton.Click

        Dim proceed As Boolean

        If laborBox.Text = "" AndAlso partBox.Text IsNot "" Then
            MsgBox("Error! Enter labor !")
            proceed = False
            partBox.Focus()
        ElseIf laborBox.Text IsNot "" AndAlso partBox.Text = "" Then
            MsgBox("Error! Enter part !")
            proceed = False
            laborBox.Focus()
        End If

        If Val(partBox.Text) < 0 Then
            MsgBox("Error! Enter positive number in part box !")
            proceed = False
        End If

        If Val(laborBox.Text) < 0 Then
            MsgBox("Error! Enter positive number in labor box !")
            proceed = False
        End If

        If laborBox.Text = "" AndAlso partBox.Text = "" Then
            proceed = True
        End If

        If Val(partBox.Text) > 0 And Val(laborBox.Text) > 0 Then
            proceed = True
        End If


        If proceed = True Then
            Dim finalTotal, finalTax, finalPart, finalService As Double
            finalTotal = TotalCharges(grandtotal)
            finalTax = TaxCharges(part)

            finalPart = Val(part_summary.Text)
            finalService = 70 * Val(laborBox.Text)
            serviceLabor_summary.Text = finalService
            tax_summary.Text = finalTax
            totalfees_summary.Text = finalTotal
            part_summary.Text = Val(partBox.Text)

        End If
    End Sub
End Class
