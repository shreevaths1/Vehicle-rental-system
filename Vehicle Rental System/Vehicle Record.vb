Imports System.Data.SqlClient
Public Class Vehicle_Record
    Dim con = New SqlConnection(connection_str)
    Dim str As String
    Dim com As SqlCommand

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Admin.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Vehicle_Entry.Show()
        Me.Close()
    End Sub

    Private Sub Vehicle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'VehicleRentDataSet1.vehicle' table. You can move, or remove it, as needed.
        Me.VehicleTableAdapter.Fill(Me.VehicleRentDataSet1.vehicle)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        con.Open()
        str = "select * from [dbo].[vehicle] where Vehicle_Id like '%" + TextBox1.Text + "%'"
        com = New SqlCommand(Str, con)
        Dim da = New SqlDataAdapter(com)
        Dim dt = New DataTable()
        Dim dv = New DataView()
        Dim vehicle As Object
        da.Fill(dt)
        DataGridView1.DataSource = New BindingSource(dt, vehicle)
        con.Close()
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If DataGridView1.SelectedRows.Count = 1 Then

            Dim index = DataGridView1.SelectedRows(0).Index
            Dim dataGridViewRow = DataGridView1.Rows.Item(index)
            Dim dataGridViewCell As String = dataGridViewRow.Cells.Item(0).Value
            Dim rowdeleted = False
            'MessageBox.Show(String.Format("{0}", dataGridViewCell))
            If MessageBox.Show(String.Format("Do you want to delete Vehicle Id: {0}", dataGridViewCell), "Confirmation", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                con.Open()
                Try
                    str = "DELETE FROM [dbo].[vehicle] WHERE Vehicle_Id = " + dataGridViewCell
                    com = New SqlCommand(str, con)
                    com.ExecuteNonQuery()
                    MsgBox("Vehicle Details Deleted Successfully..")
                    con.Close()
                    rowdeleted = True
                Catch ex As Exception
                    MsgBox("The selected Vehicle can't be deleted")
                End Try
            Else

            End If

            If rowdeleted = True Then
                DataGridView1.Rows.Remove(DataGridView1.SelectedRows(0))
            End If
        Else
            MsgBox("Select a record to Delete", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If DataGridView1.SelectedRows.Count = 1 Then

            Dim index2 = DataGridView1.SelectedRows(0).Index
            Dim dataGridViewRow2 = DataGridView1.Rows.Item(index2)
            Dim dataGridViewCell2 As String = dataGridViewRow2.Cells.Item(0).Value
            'let dataGridViewCell2 contain the value 301 

            Vehicle_Entry.Show()
            con.Open()
            str = "select * from [dbo].[vehicle] where Vehicle_Id = " + dataGridViewCell2
            com = New SqlCommand(str, con)
            Dim da = New SqlDataAdapter(com)
            Dim dt = New DataTable()
            Dim dv = New DataView()

            da.Fill(dt)
            con.Close()



            Dim row As DataRow = dt.Rows(0)


            Vehicle_Entry.Brand.Text = row(3).ToString
            Vehicle_Entry.Vehicle_Type.Text = row(1).ToString
            Vehicle_Entry.Model.Text = row(4).ToString
            Vehicle_Entry.Model_Year.Text = row(2).ToString
            Vehicle_Entry.Color.Text = row(5).ToString
            Vehicle_Entry.Capacity.Text = row(6).ToString
            Vehicle_Entry.Fuel_Type.Text = row(8).ToString
            Vehicle_Entry.Status.Text = row(9).ToString
            Vehicle_Entry.Rate.Text = row(10).ToString
            Vehicle_Entry.License_No.Text = row(7).ToString

            'Dim rowupdated = False
            'MessageBox.Show(String.Format("{0}", dataGridViewCell))
            'If MessageBox.Show(String.Format("Do you want to update Vehicle Id: {0}", dataGridViewCell2), "Confirmation", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            'con.Open()
            'str = "UPDATE [dbo].[vehicle] WHERE Vehicle_Id = " + dataGridViewCell2
            'com = New SqlCommand(str, con)
            'com.ExecuteNonQuery()
            'MsgBox("Vehicle Details Updated Successfully..")
            'con.Close()
            'rowupdated = True

            'Else

            'End If

            'If rowupdated = True Then
            'DataGridView1.Refresh()
            'End If
        Else
            MsgBox("Select a record to Update", MsgBoxStyle.Information)
        End If
    End Sub


End Class