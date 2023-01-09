﻿Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Public Class View_Reports
    Dim con = New SqlConnection(connection_str)
    Dim com As SqlCommand
    Private Sub View_Reports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TestDataSet1.DataTable1' table. You can move, or remove it, as needed.
        'Me.DataTable1TableAdapter.Fill(Me.TestDataSet1.DataTable1)




        con.Open()

        Dim Str1 = "SELECT        [user].User_Id, [user].Username, booking.Booking_Id, vehicle.Vehicle_Id, vehicle.Vehicle_Type, vehicle.Vehicle_Brand, vehicle.Vehicle_Model, vehicle.Color, vehicle.License_number, vehicle.rate_per_day, 
                                             booking.Rental_Date, booking.Return_Date, booking.Rent_Duration, booking.Rent_Amount, payment.Payment_Id, payment.Payment_Date, payment.Card_Type
                    FROM            [user] 
                    INNER JOIN  booking ON [user].User_Id = booking.User_Id 
                    INNER JOIN  payment ON [user].User_Id = payment.User_Id and [booking].Booking_Id = payment.Booking_Id
                    INNER JOIN  vehicle ON vehicle.Vehicle_Id = booking.Vehicle_Id"
        com = New SqlCommand(Str1, con)
        Dim da = New SqlDataAdapter(com)
        Dim dt = New DataTable()
        Dim dv = New DataView()
        Dim report As Object
        da.Fill(dt)
        DataGridView1.DataSource = New BindingSource(dt, report)
        con.Close()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Admin.Show()
        Me.Close()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        con.Open()

        Dim Str1 = "SELECT        [user].User_Id, [user].Username, booking.Booking_Id, vehicle.Vehicle_Id, vehicle.Vehicle_Type, vehicle.Vehicle_Brand, vehicle.Vehicle_Model, vehicle.Color, vehicle.License_number, vehicle.rate_per_day, 
                                             booking.Rental_Date, booking.Return_Date, booking.Rent_Duration, booking.Rent_Amount, payment.Payment_Id, payment.Payment_Date, payment.Card_Type
                    FROM            [user] 
                    INNER JOIN booking ON [user].User_Id = booking.User_Id 
                    INNER JOIN payment ON [user].User_Id = payment.User_Id and [booking].Booking_Id = payment.Booking_Id
                    INNER JOIN vehicle ON vehicle.Vehicle_Id = booking.Vehicle_Id
                    where payment_id like '%" + TextBox1.Text + "%'"

        com = New SqlCommand(Str1, con)
        Dim da = New SqlDataAdapter(com)
        Dim dt = New DataTable()
        Dim dv = New DataView()
        Dim report As Object
        da.Fill(dt)
        DataGridView1.DataSource = New BindingSource(dt, report)
        con.Close()
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        con.Open()

        Dim Str1 = "SELECT        [user].User_Id, [user].Username, booking.Booking_Id, vehicle.Vehicle_Id, vehicle.Vehicle_Type, vehicle.Vehicle_Brand, vehicle.Vehicle_Model, vehicle.Color, vehicle.License_number, vehicle.rate_per_day, 
                                             booking.Rental_Date, booking.Return_Date, booking.Rent_Duration, booking.Rent_Amount, payment.Payment_Id, payment.Payment_Date, payment.Card_Type
                    FROM            [user] 
                    INNER JOIN booking ON [user].User_Id = booking.User_Id 
                    INNER JOIN payment ON [user].User_Id = payment.User_Id and [booking].Booking_Id = payment.Booking_Id
                    INNER JOIN vehicle ON vehicle.Vehicle_Id = booking.Vehicle_Id
                    where [dbo].[user].user_id like '%" + TextBox3.Text + "%'"

        com = New SqlCommand(Str1, con)
        Dim da = New SqlDataAdapter(com)
        Dim dt = New DataTable()
        Dim dv = New DataView()
        Dim report As Object
        da.Fill(dt)
        DataGridView1.DataSource = New BindingSource(dt, report)
        con.Close()
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        con.Open()

        Dim Str1 = "SELECT        [user].User_Id, [user].Username, booking.Booking_Id, vehicle.Vehicle_Id, vehicle.Vehicle_Type, vehicle.Vehicle_Brand, vehicle.Vehicle_Model, vehicle.Color, vehicle.License_number, vehicle.rate_per_day, 
                                             booking.Rental_Date, booking.Return_Date, booking.Rent_Duration, booking.Rent_Amount, payment.Payment_Id, payment.Payment_Date, payment.Card_Type
                    FROM            [user] 
                    INNER JOIN booking ON [user].User_Id = booking.User_Id 
                    INNER JOIN payment ON [user].User_Id = payment.User_Id and [booking].Booking_Id = payment.Booking_Id
                    INNER JOIN vehicle ON vehicle.Vehicle_Id = booking.Vehicle_Id
                    where booking.booking_id like '%" + TextBox4.Text + "%'"

        com = New SqlCommand(Str1, con)
        Dim da = New SqlDataAdapter(com)
        Dim dt = New DataTable()
        Dim dv = New DataView()
        Dim report As Object
        da.Fill(dt)
        DataGridView1.DataSource = New BindingSource(dt, report)
        con.Close()
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        con.Open()

        Dim Str1 = "SELECT        [user].User_Id, [user].Username, booking.Booking_Id, vehicle.Vehicle_Id, vehicle.Vehicle_Type, vehicle.Vehicle_Brand, vehicle.Vehicle_Model, vehicle.Color, vehicle.License_number, vehicle.rate_per_day, 
                                             booking.Rental_Date, booking.Return_Date, booking.Rent_Duration, booking.Rent_Amount, payment.Payment_Id, payment.Payment_Date, payment.Card_Type
                    FROM            [user] 
                    INNER JOIN booking ON [user].User_Id = booking.User_Id 
                    INNER JOIN payment ON [user].User_Id = payment.User_Id and [booking].Booking_Id = payment.Booking_Id
                    INNER JOIN vehicle ON vehicle.Vehicle_Id = booking.Vehicle_Id
                    where vehicle.vehicle_id like '%" + TextBox5.Text + "%'"

        com = New SqlCommand(Str1, con)
        Dim da = New SqlDataAdapter(com)
        Dim dt = New DataTable()
        Dim dv = New DataView()
        Dim report As Object
        da.Fill(dt)
        DataGridView1.DataSource = New BindingSource(dt, report)
        con.Close()
    End Sub

    Private Sub Reset_Click(sender As Object, e As EventArgs) Handles Reset.Click
        TextBox1.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
    End Sub
End Class