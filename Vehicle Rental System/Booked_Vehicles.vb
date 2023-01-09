Imports System.Data.SqlClient

Public Class Booked_Vehicles
    Dim con = New SqlConnection(connection_str)

    Dim com As SqlCommand
    Private Sub Booked_Vehicles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BookingDataSet1.booking' table. You can move, or remove it, as needed.
        Me.BookingTableAdapter.Fill(Me.BookingDataSet1.booking)


        Dim Str1 = "SELECT User_Id, Booking_Id, Rental_Date, Return_Date, Vehicle_Id, Rent_Duration, Rent_Amount from [dbo].[booking] where booked_status = 'Active' "
        com = New SqlCommand(Str1, con)
        Dim da = New SqlDataAdapter(com)
        Dim dt = New DataTable()
        Dim bs As BindingSource = New BindingSource
        Dim booking As Object
        da.Fill(dt)
        'bs.DataSource = dt
        DataGridView1.DataSource = New BindingSource(dt, booking)
        'DataGridView1.DataSource = bs
        con.Close()

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        con.Open()

        Dim Str1 = "select * from [dbo].[booking] where Booking_Id like '%" + TextBox1.Text + "%'"
        com = New SqlCommand(Str1, con)
        Dim da = New SqlDataAdapter(com)
        Dim dt = New DataTable()
        Dim dv = New DataView()
        Dim vehicle As Object
        da.Fill(dt)
        DataGridView1.DataSource = New BindingSource(dt, vehicle)
        con.Close()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        con.Open()

        Dim Str2 = "select * from [dbo].[booking] where User_Id like '%" + TextBox2.Text + "%'"
        com = New SqlCommand(Str2, con)
        Dim da = New SqlDataAdapter(com)
        Dim dt = New DataTable()
        Dim dv = New DataView()
        Dim vehicle As Object
        da.Fill(dt)
        DataGridView1.DataSource = New BindingSource(dt, vehicle)
        con.Close()
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        con.Open()

        Dim Str3 = "select * from [dbo].[booking] where Vehicle_Id like '%" + TextBox3.Text + "%'"
        com = New SqlCommand(Str3, con)
        Dim da = New SqlDataAdapter(com)
        Dim dt = New DataTable()
        Dim dv = New DataView()
        Dim vehicle As Object
        da.Fill(dt)
        DataGridView1.DataSource = New BindingSource(dt, vehicle)
        con.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Admin.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If DataGridView1.SelectedRows.Count = 1 Then

            Dim index = DataGridView1.SelectedRows(0).Index
            Dim dataGridViewRow = DataGridView1.Rows.Item(index)
            Dim dataGridViewCell As String = dataGridViewRow.Cells.Item(0).Value
            Dim dataGridViewCell1 As String = dataGridViewRow.Cells.Item(2).Value
            Dim rowdeleted = False
            If MessageBox.Show(String.Format("Do you want to delete Booking Id: {0}", dataGridViewCell), "Confirmation", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                con.Open()
                Dim Str = "update [dbo].[vehicle] 
                SET status = 'Available'
                WHERE Vehicle_Id = " + dataGridViewCell1
                com = New SqlCommand(Str, con)
                com.ExecuteNonQuery()
                MsgBox("Booking Details Deleted Successfully..")
                con.Close()
                'MsgBox(dataGridViewCell1)

                con.Open()
                Dim str2 = "update [dbo].[booking]  set booked_status='Archived' where booking_id=" + dataGridViewCell
                com = New SqlCommand(str2, con)
                com.ExecuteNonQuery()
                con.Close()
                rowdeleted = True

            Else

            End If

            If rowdeleted = True Then
                DataGridView1.Rows.Remove(DataGridView1.SelectedRows(0))
            End If
        Else
            MsgBox("Select a record to Delete", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
    End Sub
End Class