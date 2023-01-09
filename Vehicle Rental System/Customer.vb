Imports System.Data.SqlClient
Public Class Customer
    Dim con = New SqlConnection(connection_str)
    Dim str As String
    Dim com As SqlCommand

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Admin.Show()
        Me.Close()
    End Sub

    Private Sub Customer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'VehicleRentDataSet.user' table. You can move, or remove it, as needed.
        Me.UserTableAdapter.Fill(Me.VehicleRentDataSet.user)

    End Sub



    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Using con = New SqlConnection(connection_str)
            Dim Str = "select * from [dbo].[user] where User_Id like '%" + TextBox1.Text + "%'"
            Dim com = New SqlCommand(Str, con)
            Dim da = New SqlDataAdapter(com)
            Dim dt = New DataTable()
            Dim dv = New DataView()
            Dim user As Object
            da.Fill(dt)
            DataGridView1.DataSource = New BindingSource(dt, user)
        End Using
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If DataGridView1.SelectedRows.Count = 1 Then

            Dim index = DataGridView1.SelectedRows(0).Index
            Dim dataGridViewRow = DataGridView1.Rows.Item(index)
            Dim dataGridViewCell As String = dataGridViewRow.Cells.Item(0).Value
            Dim rowdeleted = False
            'MessageBox.Show(String.Format("{0}", dataGridViewCell))
            If MessageBox.Show(String.Format("Do you want to delete User Id: {0}", dataGridViewCell), "Confirmation", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                con.Open()
                Try
                    str = "DELETE FROM [dbo].[user] WHERE User_Id = " + dataGridViewCell
                    com = New SqlCommand(str, con)
                    com.ExecuteNonQuery()
                    MsgBox("Customer Details Deleted Successfully..")
                    con.Close()
                    rowdeleted = True
                Catch ex As Exception
                    MsgBox("The selected User can't be Deleted")
                End Try

            Else

            End If

            If rowdeleted = True Then
                DataGridView1.Rows.Remove(DataGridView1.SelectedRows(0))
            End If
        Else
            MsgBox("Select Entire Row to Delete", MsgBoxStyle.Information)
        End If



    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Registration.Show()
        Me.Close()
    End Sub
End Class
