Imports System.Data.SqlClient
Public Class Vehicle_Entry
    Dim con = New SqlConnection(connection_str)
    Dim str As String
    Dim com As SqlCommand
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Vehicle_Record.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim emptyTextBoxes =
        From txt In Me.Controls.OfType(Of TextBox)()
        Where txt.Text.Length = 0
        Select txt.Name



        If emptyTextBoxes.Any Then
            MessageBox.Show(String.Format("Please fill following fields: {0}",
                    String.Join(",", emptyTextBoxes)))
            Return
        End If

        If Not IsNumeric(Capacity.Text) Then
            MsgBox("Invalid Capacity")
            Return
        End If

        If Not IsNumeric(Model_Year.Text) Then
            MsgBox("Invalid Model Year")
            Return
        End If

        If Not IsNumeric(Rate.Text) Then
            MsgBox("Invalid Rate per day")
            Return
        End If

        If License_No.Text.Length <> 10 Then
            MsgBox("Invalid License Number")
            Return
        End If


        If Vehicle_Type.SelectedIndex = -1 Then
            MsgBox("Choose a Vehicle Type")
            Return
        End If

        If Fuel_Type.SelectedIndex = -1 Then
            MsgBox("Choose a Fuel Type")
            Return
        End If

        If Not (emptyTextBoxes.Any) Then
            con.Open()
            Dim str1 = "select * from [dbo].[vehicle] where License_number = '" + License_No.Text + "'"

            com = New SqlCommand(str1, con)
            Dim da1 = New SqlDataAdapter(com)
            Dim dt1 = New DataTable()
            Dim dv1 = New DataView()

            da1.Fill(dt1)
            con.Close()
            'MsgBox(dt1.Rows.Count)

            'MsgBox(str1.ToString)

            If dt1.Rows.Count <> 0 Then
                'Code for update statement
                con.Open()
                str = "update [dbo].[vehicle] 
                       set Vehicle_Type = '" + Vehicle_Type.SelectedItem + "', Model_Year = '" + Model_Year.Text + "', Vehicle_Brand = '" + Brand.Text + "' , Vehicle_Model = '" + Model.Text + "', Color = '" + Color.Text + "', Capacity =" + Capacity.Text + ", Engine= '" + Fuel_Type.SelectedItem + "' , Status = '" + Status.Text + "' , rate_per_day = '" + Rate.Text + "', License_number = '" + License_No.Text + "'
                       where License_number = '" + License_No.Text + "'"

                com = New SqlCommand(str, con)
                com.ExecuteNonQuery()
                MsgBox("Vehicle Details Updated Successfully..")

                con.Close()

                Vehicle_Record.Show()
                con.Open()
                Dim str2 = "select * from [dbo].[vehicle]"
                com = New SqlCommand(str2, con)
                Dim da = New SqlDataAdapter(com)
                Dim dt = New DataTable()
                Dim dv = New DataView()
                Dim vehicle As Object
                da.Fill(dt)
                Vehicle_Record.DataGridView1.DataSource = New BindingSource(dt, vehicle)
                con.Close()
                Me.Close()
            Else
                con.Open()
                'Insert into cust(Username, Password, Email, Contact, City) values('john','john123','john@gmail.com',7574637847,'Bangalore')
                str = "insert into [dbo].[vehicle](Vehicle_Type,Model_Year,Vehicle_Brand,Vehicle_Model,Color,Capacity,Engine,Status,Rate_Per_day,License_number) values('" + Vehicle_Type.SelectedItem + "','" + Model_Year.Text + "','" + Brand.Text + "','" + Model.Text + "','" + Color.Text + "'," + Capacity.Text + ",'" + Fuel_Type.SelectedItem + "','" + Status.Text + "'," + Rate.Text + ",'" + License_No.Text + "')"
                com = New SqlCommand(str, con)
                com.ExecuteNonQuery()
                MsgBox("Vehicle Details Inserted Successfully..")

                con.Close()

                Vehicle_Record.Show()
                con.Open()
                Dim str2 = "select * from [dbo].[vehicle]"
                com = New SqlCommand(str2, con)
                Dim da = New SqlDataAdapter(com)
                Dim dt = New DataTable()
                Dim dv = New DataView()
                Dim vehicle As Object
                da.Fill(dt)
                Vehicle_Record.DataGridView1.DataSource = New BindingSource(dt, vehicle)
                con.Close()
                'Vehicle_Record.DataGridView1.DataSource = New BindingSource(dt, vehicle)

                Me.Close()
            End If
        End If
    End Sub

    Private Sub Vehicle_Entry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Status.Text = "Available"
    End Sub
End Class