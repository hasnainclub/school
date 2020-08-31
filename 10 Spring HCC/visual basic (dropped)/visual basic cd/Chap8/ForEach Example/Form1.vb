Public Class Form1

    Private intArray() As Integer = {10, 20, 90, -20, 30, 75, 40, 50, 60}

    Private Sub btnPrint_Click(ByVal sender As System.Object, _
            ByVal e As System.EventArgs) Handles btnPrint.Click

        For Each intVal As Integer In intArray
            lstShow.Items.Add(intVal)
        Next

    End Sub

    Private Sub btnSum_Click(ByVal sender As Object, _
        ByVal e As System.EventArgs) Handles btnSum.Click

        Dim intSum As Integer = 0

        For Each intVal As Integer In intArray
            intSum += intVal
        Next

    End Sub

    Private Sub btnLargest_Click(ByVal sender As System.Object, _
        ByVal e As System.EventArgs) Handles btnLargest.Click

        Dim intLargest As Integer = intArray(0)

        For Each intVal As Integer In intArray
            If intVal > intLargest Then
                intLargest = intVal
            End If
        Next

    End Sub

End Class
