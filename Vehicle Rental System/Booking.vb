Imports System.Data.SqlClient
Public Class Booking
    Public Shared vehicleId As Long
    Public Shared brand As String
    Public Shared model As String
    Public Shared regNo As String
    Public Shared ratePerDay As Long
    Public Shared bookingId As Long

    Dim con = New SqlConnection(connection_str)
    Dim str As String
    Dim cmd As SqlCommand

    Private Sub Booking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ratePerDay = 0
        If UserViewVehicles.DataGridView1.SelectedRows.Count = 1 Then
            Dim index = UserViewVehicles.DataGridView1.SelectedRows(0).Index
            Dim dataGridViewRow = UserViewVehicles.DataGridView1.Rows.Item(index)
            vehicleId = dataGridViewRow.Cells.Item(0).Value

            userBox.Text = Login.LoggedInUserName
            brand = dataGridViewRow.Cells.Item(3).Value
            model = dataGridViewRow.Cells.Item(4).Value
            regNo = dataGridViewRow.Cells.Item(7).Value
            vehicleBox.Text = brand + " " + model + " [" + regNo + "]"

            Dim days As Long = durationBox.Value
            toDateField.Value = fromDateField.Value.AddDays(days)

            ratePerDay = dataGridViewRow.Cells.Item(10).Value
            Dim cost As Decimal = ratePerDay * days
            costBox.Text = cost
            rateLabel.Text = ratePerDay.ToString + "/day"
        Else
            MsgBox("Select a record to book", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub durationBox_ValueChanged(sender As Object, e As EventArgs) Handles durationBox.ValueChanged
        Dim days As Long = durationBox.Value
        toDateField.Value = fromDateField.Value.AddDays(days)

        Dim cost As Decimal = ratePerDay * days
        costBox.Text = cost
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim paymentPending = False
        'If Not bookingId = 0 Then
        'MsgBox(String.Format("Your previous booking {0} is pending payment. Please proceed to payment", bookingId))
        'paymentPending = True
        'End If
        If MessageBox.Show("Do you want to proceed with booking?", "Confirmation", MessageBoxButtons.YesNo) = DialogResult.Yes Then


            str = "insert into [dbo].[booking] (user_id, vehicle_id, rental_date, return_date, rent_duration, rent_amount, booked_status) values (" &
                   Login.LoggedInUserId + ", " &
                   vehicleId.ToString + ", " &
                   "'" + fromDateField.Value + "', " &
                   "'" + toDateField.Value + "', " &
                   durationBox.Value.ToString + ", " &
                   costBox.Text + ",'Active') select SCOPE_IDENTITY()"
            'MsgBox(str)
            con.Open()
            cmd = New SqlCommand(str, con)
            bookingId = CInt(cmd.ExecuteScalar())
            con.Close()


            If MessageBox.Show(String.Format("Your booking is successful. Your booking reference number is {0}. Please proceed with payment.", bookingId), "Message", MessageBoxButtons.OK) = DialogResult.OK Then
                paymentPending = True
            End If
        End If
        If paymentPending = True Then
            Payment.Show()
            Me.Close()

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        User.Show()
        Me.Close()
    End Sub
End Class