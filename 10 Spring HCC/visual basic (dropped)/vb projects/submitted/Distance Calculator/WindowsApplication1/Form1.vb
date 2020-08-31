Public Class Form1

    '  Attarwala_lab5
    '  homework Distance Calculator
    '  March 16, 2010

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click

        '  To declare variables

        Dim intSpeed As Integer
        Dim intDistance As Integer
        Dim intLoopCount As Integer      ' for looping 
        Dim intTime As Integer






        '  to check time is higer than one and it should be in a numeric form
        Try
            intTime = CDec(InputBox("Enter the time in hours"))
            If intTime < 1 Then
                MessageBox.Show("Enter a Value higher than 1", "Input Error")
            End If
        Catch ex As Exception
            MessageBox.Show("Enter a numeric value", "Input Error")
        End Try






        Try
            intSpeed = CInt(InputBox("Enter speed in miles per hour"))

        Catch ex As Exception
            MessageBox.Show("Enter a numeric value", "Input Error")
        End Try

        If intSpeed < 1 Then
            MessageBox.Show("Enter a value greater than 1", "Input Error")
        End If






        '  display the itess which would be added in time
        strOutput.Items.Add("Speed: " & intSpeed.ToString() & "MPH")
        strOutput.Items.Add("Time " & intTime.ToString() & "Hours")
        strOutput.Items.Add("Total Distance traveled")
        strOutput.Items.Add("------------")


        '  make sure loop starts at one, to give it a index of one and not of 0 when it starts...
        intLoopCount = 1
        '  to make sure distance is 0 
        intDistance = 0

        '  loop
        Do While intLoopCount <= intTime
            intDistance = intDistance + intSpeed
            strOutput.Items.Add(intLoopCount.ToString() & "     " & intDistance.ToString)
            intLoopCount = intLoopCount + 1
        Loop

        '  distance finale
        strOutput.Items.Add("Total distance: " & intDistance.ToString())
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        ' to close the app by clicking exit btn
        Me.Close()
    End Sub
End Class
