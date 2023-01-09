Imports System.Data.SqlClient
Public Class View_Feedbacks
    Dim con = New SqlConnection(connection_str)

    Dim com As SqlCommand
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Admin.Show()
        Me.Close()
    End Sub

    Private Sub View_Feedbacks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'FeedbackDataSet.DataTable2' table. You can move, or remove it, as needed.
        'Me.DataTable2TableAdapter.Fill(Me.FeedbackDataSet.DataTable2)
        con.Open()

        Dim Str1 = "select 
                    [user].User_Id,[user].Username,
                    feedback.Subject, feedback.Feedback
            from [user] 
            inner join feedback on [user].User_Id = feedback.User_Id"
        com = New SqlCommand(Str1, con)
        Dim da = New SqlDataAdapter(com)
        Dim dt = New DataTable()
        Dim dv = New DataView()
        Dim feedback As Object
        da.Fill(dt)
        DataGridView1.DataSource = New BindingSource(dt, feedback)
        con.Close()


    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        con.Open()

        Dim str2 = "select 
                    [user].User_Id,[user].Username,
                    feedback.Subject, feedback.Feedback
            from [user] 
            inner join feedback on [user].User_Id = feedback.User_Id
            where [user].User_Id like '%" + TextBox2.Text + "%'"
        com = New SqlCommand(str2, con)
        Dim da = New SqlDataAdapter(com)
        Dim dt = New DataTable()
        Dim dv = New DataView()
        Dim feedback As Object
        da.Fill(dt)
        DataGridView1.DataSource = New BindingSource(dt, feedback)
        con.Close()
    End Sub
End Class