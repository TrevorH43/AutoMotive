Public Class Form1
    Const dblTaxRate As Decimal = 0.06
    Const dblOil As Double = 36
    Const dblLubeJob As Double = 28
    Const dblRadiatorFlush As Double = 50
    Const dblTransFlush As Double = 120
    Const dblMuffler As Double = 200
    Const dblInspection As Double = 15
    Const dblTireRotation As Double = 20





    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim taxes As Decimal
        Dim subTotal
        Dim totalFees As Decimal

        subTotal = dblOil + dblLubeJob + dblRadiatorFlush + dblTransFlush + dblInspection + dblTireRotation + dblMuffler
        taxes = CalcTax()
        totalFees = subTotal + taxes
        taxOnPartsLabel.Text = taxes.ToString("c")
        totalFeesLabel.Text = totalFees.ToString("c")



    End Sub

    Function OilandLube() As Decimal
        Dim decOil As Decimal
        If oilChange.Checked = True Then
            dblOil += oilChange()
        Else
            dblLubeJob = lubeJob()
        End If
    End Function

    Function RadiatorandTrans() As Decimal
        If radiatorFlush.Checked = True Then
            dblRadiatorFlush += radiatorFlush()
        Else
            dblTransFlush = transFlush()
        End If
    End Function

    Function Miscallenous()
        If inspection.Checked = True Then
            inspection += dblInspection()
        ElseIf mufflerReplace.Checked = True Then
            mufflerReplace += dblMuffler()
        Else
            tireRotation.Checked = True
            tireRotation += dblTireRotation
        End If
    End Function

    Function CalcTax(ByVal decAmount As Decimal) As Decimal
        Return decAmount * dblTaxRate
    End Function



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        oilChange.Checked = False
        lubeJob.Checked = False
        radiatorFlush.Checked = False
        transFlush.Checked = False
        inspection.Checked = False
        mufflerReplace.Checked = False
        tireRotation.Checked = False
        partsTextBox.Text = ""
        laborTextBox.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class
