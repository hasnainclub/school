Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '  Get today's date from the system and display it
        lblDateToday.Text = Now.ToString("D")
        '  Get the current time from the system and display it
        lblTimeToday.Text = Now.ToString("T")
    End Sub

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        '  Declare variables for calculations
        Dim decRoomCharges As Decimal  ' Room charges total
        Dim decAddCharges As Decimal   ' Additional Charges
        Dim decsubtotal As Decimal     ' Subtotal
        Dim decTax As Decimal          ' tax
        Dim decTotal As Decimal        ' Total of all charges
        Const decTAX_RATE As Decimal = 0.08D   ' Tax Rate

        Try
            '   Calculate and display the room charges.  Handle
            '  Error if the fields are blank
            decRoomCharges = CDec(txtNights.Text) * CDec(txtNightlyCharge.Text)
            lblRoomCharges.Text = decRoomCharges.ToString("c")
        Catch
            MessageBox.Show("nights and Nightly Charge must be numbers", "Error")

        End Try
        Try
            '  Calculate and display additional charges.  Handle
            '  Error if fields are blank
            decAddCharges = CDec(txtRoomService.Text) + CDec(txtTelephone.Text) + CDec(txtMisc.Text)
            lblAddCharges.Text = decAddCharges.ToString("c")
        Catch
            MessageBox.Show(" Room Service, Telephone, and misc must be numbers", "Error")
        End Try
        '  Calculate and display the subtotal
        decsubtotal = decRoomCharges + decAddCharges
        lblSubtotal.Text = decsubtotal.ToString("c")
        '  Calculate and display the tax
        decTax = decsubtotal * decTAX_RATE
        lblTax.Text = decTax.ToString("c")

        '  Calculate and display the total charges
        decTotal = decsubtotal + decTax
        lblTotal.Text = decTotal.ToString("c")
        '  Change the background and foreground colors
        '  for the total charges
        lblTotal.BackColor = Color.Red
        lblTotal.ForeColor = Color.White



    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        '  Clear all the texts inputs
        txtNights.Clear()
        txtNightlyCharge.Clear()
        txtRoomService.Clear()
        txtTelephone.Clear()
        txtMisc.Clear()

        '  Clear the total fields
        lblRoomCharges.Text = String.Empty
        lblAddCharges.Text = String.Empty
        lblSubtotal.Text = String.Empty
        lblTax.Text = String.Empty
        lblTotal.Text = String.Empty

        '  Get todays date from the OS and display it
        lblDateToday.Text = Now.ToString("D")

        '  Get the current time from the OS and display it
        lblTimeToday.Text = Now.ToString("T")
        '  Reset the focus to use the first field 
        txtNights.Focus()
        '  Reset the lbl total control's colors
        lblTotal.BackColor = SystemColors.Control
        lblTotal.ForeColor = SystemColors.ControlText

        '  Rese the focus to the first field
        txtNights.Focus()


    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        '  Close the application
        Me.Close()

    End Sub
End Class
