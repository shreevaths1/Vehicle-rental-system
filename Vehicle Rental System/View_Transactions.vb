Imports System.Data.SqlClient
Public Class View_Transactions
    Dim con = New SqlConnection(connection_str)

    Dim com As SqlCommand
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        con.Open()

        Dim Str1 = "SELECT        [user].User_Id, [user].Username, booking.Booking_Id,payment.Payment_Id, payment.Payment_Date,booking.Rent_Amount As Payment_Amount
                    FROM            [user] 
                    INNER JOIN booking ON [user].User_Id = booking.User_Id 
                    INNER JOIN payment ON [user].User_Id = payment.User_Id and Booking.Booking_Id = payment.Booking_Id
                    where payment.payment_id like '%" + TextBox1.Text + "%'"
        com = New SqlCommand(Str1, con)
        Dim da = New SqlDataAdapter(com)
        Dim dt = New DataTable()
        Dim dv = New DataView()
        Dim payment As Object
        da.Fill(dt)
        DataGridView1.DataSource = New BindingSource(dt, payment)
        con.Close()
    End Sub

    Private Sub View_Transactions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PaymentDataSet.DataTable3' table. You can move, or remove it, as needed.
        'Me.DataTable3TableAdapter.Fill(Me.PaymentDataSet.DataTable3)


        con.Open()

        Dim Str1 = "SELECT        [user].User_Id, [user].Username, booking.Booking_Id,payment.Payment_Id, payment.Payment_Date,booking.Rent_Amount As Payment_Amount
                    FROM            [user] 
                    INNER JOIN booking ON [user].User_Id = booking.User_Id 
                    INNER JOIN payment ON [user].User_Id = payment.User_Id and Booking.Booking_Id = payment.Booking_Id"
        com = New SqlCommand(Str1, con)
        Dim da = New SqlDataAdapter(com)
        Dim dt = New DataTable()
        Dim dv = New DataView()
        Dim payment As Object
        da.Fill(dt)
        DataGridView1.DataSource = New BindingSource(dt, payment)
        con.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Admin.Show()
        Me.Close()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        con.Open()

        Dim Str2 = "SELECT        [user].User_Id, [user].Username, booking.Booking_Id,payment.Payment_Id, payment.Payment_Date,booking.Rent_Amount As Payment_Amount
                    FROM            [user] 
                    INNER JOIN booking ON [user].User_Id = booking.User_Id 
                    INNER JOIN payment ON [user].User_Id = payment.User_Id and Booking.Booking_Id = payment.Booking_Id
                    where [user].User_id like '%" + TextBox2.Text + "%'"
        com = New SqlCommand(Str2, con)
        Dim da = New SqlDataAdapter(com)
        Dim dt = New DataTable()
        Dim dv = New DataView()
        Dim payment As Object
        da.Fill(dt)
        DataGridView1.DataSource = New BindingSource(dt, payment)
        con.Close()
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        con.Open()

        Dim Str3 = "SELECT        [user].User_Id, [user].Username, booking.Booking_Id,payment.Payment_Id, payment.Payment_Date,booking.Rent_Amount As Payment_Amount
                    FROM            [user] 
                    INNER JOIN booking ON [user].User_Id = booking.User_Id 
                    INNER JOIN payment ON [user].User_Id = payment.User_Id and Booking.Booking_Id = payment.Booking_Id
                    where booking.booking_id like '%" + TextBox3.Text + "%'"
        com = New SqlCommand(Str3, con)
        Dim da = New SqlDataAdapter(com)
        Dim dt = New DataTable()
        Dim dv = New DataView()
        Dim payment As Object
        da.Fill(dt)
        DataGridView1.DataSource = New BindingSource(dt, payment)
        con.Close()
    End Sub

    Private Sub Reset_Click(sender As Object, e As EventArgs) Handles Reset.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
    End Sub
End Class