Public Class Form1

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lstSpeeds.Items.Clear()
        txtAvgSpeed.Clear()
        btnSpeed.Enabled = True
    End Sub

    Private Sub btnSpeed_Click(sender As Object, e As EventArgs) Handles btnSpeed.Click
        Dim strSpeed As String
        Dim decSpeed As Decimal
        Dim decSumofSpeeds As Decimal
        Dim decAverage As Decimal = 0D

        Dim strIBoxMsg As String = " Enter the number of Mbps of your home Internet speed #"
        Dim strIBoxTitle As String = "Internet Speed"
        Dim strNotNumericErrMsg As String = "Error - Enter the speed of your home Internet connection in Mbps"
        Dim strNegErrMsg As String = "Error - Enter a valid speed"

        Dim intMaxEntries As Integer = 10
        Dim intEntries As Integer = 1

        strSpeed = InputBox(strIBoxMsg & intEntries, strIBoxTitle)

        Do Until intEntries > intMaxEntries Or strSpeed = ""
            If IsNumeric(strSpeed) Then
                decSpeed = Convert.ToDecimal(strSpeed)
                If decSpeed > 0 Then
                    lstSpeeds.Items.Add(decSpeed)
                    decSumofSpeeds += decSpeed
                    intEntries += 1
                    strIBoxMsg = strIBoxMsg
                Else
                    strIBoxMsg = strNegErrMsg
                End If
            Else
                strIBoxMsg = strNotNumericErrMsg
            End If

            If intEntries <= intMaxEntries Then
                strSpeed = InputBox(strIBoxMsg & intEntries, strIBoxTitle)
            End If
        Loop

        lblAvgSpeed.Visible = True

        If intEntries > 1 Then
            decAverage = decSumofSpeeds / (intEntries - 1)
            txtAvgSpeed.Text = decAverage.ToString("F2") & "Mbps"
        Else
            txtAvgSpeed.Text = "No Speed Value Entered"
        End If

        btnSpeed.Enabled = False
    End Sub
End Class
