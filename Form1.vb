'Name: Sean Fox
'Course: CIT-161-Z03B
'Date: 5-28-19
'Program Name: Software Sales
'Description: Chapter 4, Programming Challenge 5 - Create an application that calculates software sales options using radio buttons and check boxes


Public Class Form1

    Const decLEASE As Decimal = 5000
    Const decPURCHASE As Decimal = 20000
    Const decSUPPORT As Decimal = 3500
    Const decTRAINING As Decimal = 2000
    Const decBACKUP As Decimal = 300
    Private Sub BtnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim decSoftware As Decimal
        Dim decFeatures As Decimal = 0

        If radYearlyLicense.Checked Then
            decSoftware = decLEASE
        Else
            decSoftware = decPURCHASE
        End If

        If chkTech.Checked Then
            decFeatures += decSUPPORT
        End If

        If chkTraining.Checked Then
            decFeatures += decTRAINING
        End If

        If chkBackup.Checked Then
            decFeatures += decBACKUP
        End If

        lblLicensing.Text = decSoftware.ToString("c")
        lblFeatures.Text = decFeatures.ToString("c")
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        radYearlyLicense.Checked = True
        chkBackup.Checked = False
        chkTech.Checked = False
        chkTraining.Checked = False
        lblFeatures.Text = String.Empty
        lblLicensing.Text = String.Empty

    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class
