Imports System.Text.RegularExpressions
Imports System.Data.SqlClient
Public Class Payment
    Public Shared paymentId As Long
    Dim con = New SqlConnection(connection_str)

    Dim cmd As SqlCommand
    Private Sub Payment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bookingBox.Text = Booking.bookingId
        userBox.Text = Login.LoggedInUserName
        cardTypeBox.SelectedIndex = 0
    End Sub

    Private Sub submitButton_Click(sender As Object, e As EventArgs) Handles submitButton.Click
        Dim regex As Regex = New Regex("(0[1-9]|10|11|12)/20[2-9][2-9]$")
        Dim isvalid As Boolean = regex.IsMatch(cardExpiryBox.Text.Trim)
        'Dim expiryDate As Date

        If cardTypeBox.SelectedIndex = -1 Then
            MsgBox("Choose a valid card type")
        ElseIf cardNumberBox.Text = "" Then
            MsgBox("Card number is required")
        ElseIf Not cardNumberBox.Text.Length = 16 Then
            MsgBox("Invalid card number")
        ElseIf cardHolderNameBox.Text = "" Then
            MsgBox("Card holder name is required")
        ElseIf Not isvalid Then
            MsgBox("Invalid Card Expiry Details")
        ElseIf cardExpiryBox.Text = "" Then
            MsgBox("Card Expiry Details is required")
        ElseIf cvvBox.Text = "" Then
            MsgBox("CVV is required")
        ElseIf Not cvvBox.Text.Length = 3 Then
            MsgBox("Invalid CVV")
            'ElseIf 
        Else
            ' MsgBox(cardExpiryBox.Text)
            'Dim tmpExpiry = "01/" + cardExpiryBox.Text
            'expiryDate = DateTime.ParseExact(tmpExpiry, "dd/MM/yyyy", Nothing)
            'Dim compareValue As String = expiryDate.Month.ToString + "/" + expiryDate.Year.ToString
            'MsgBox(compareValue)
            'If Not compareValue = cardExpiryBox.Text Then
            'MsgBox("Invalid card expiry details.")
            'End If

            Dim choice = MessageBox.Show("Do you want to proceed with payment?", "Confirmation", MessageBoxButtons.YesNo)
            If choice = DialogResult.Yes Then
                Dim str As String
                Dim str1 As String

                con.Open()
                str = "insert into [dbo].[payment](Booking_Id,User_Id,Payment_Date,Card_Type,Card_No,Card_Holder,Expiring_Date,CVV) values(" + Booking.bookingId.ToString + "," + Login.LoggedInUserId + ",'" + paymentDateBox.Value + "','" + cardTypeBox.Text + "','" + cardNumberBox.Text + "','" + cardHolderNameBox.Text + "','" + cardExpiryBox.Text + "','" + cvvBox.Text + "') select SCOPE_IDENTITY()"
                cmd = New SqlCommand(str, con)
                paymentId = CInt(cmd.ExecuteScalar())
                MsgBox(String.Format("Payment success. Your payment reference number is {0}. Please quote with all future communications regarding your payment.", paymentId))

                str1 = "insert into [dbo].[report](User_Id,Booking_Id,Vehicle_Id,Payment_Id) values(" + Login.LoggedInUserId + "," + Booking.bookingId.ToString + "," + Booking.vehicleId.ToString + "," + paymentId.ToString + ")"
                cmd = New SqlCommand(str1, con)
                cmd.ExecuteNonQuery()

                str = "update dbo.vehicle set status='Booked' where vehicle_id=" + Booking.vehicleId.ToString
                cmd = New SqlCommand(str, con)
                cmd.ExecuteNonQuery()
                con.Close()
                User.Show()
                Me.Close()

            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MessageBox.Show("Do you want to cancel payment? This action would cancel booking as well.", "Confirmation", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Dim str2 = "delete from [dbo].[booking] where booking_id=" + Booking.bookingId.ToString
            con.Open()
            cmd = New SqlCommand(str2, con)
            cmd.ExecuteNonQuery()
            con.Close()
            User.Show()
            Me.Close()
        End If

    End Sub

End Class