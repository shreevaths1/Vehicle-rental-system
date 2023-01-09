Imports System.Data.SqlClient
Public Class Login
    Dim con = New SqlConnection(connection_str)
    Dim com As SqlCommand
    Dim da As SqlDataAdapter
    Dim str As String
    Dim x As Integer
    Dim dt As DataTable
    Dim dr As SqlDataReader
    Public Shared LoggedInUserId As String
    Public Shared LoggedInUserName As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Username, Password As String

        Dim emptyTextBoxes =
        From txt In Me.Controls.OfType(Of TextBox)()
        Where txt.Text.Length = 0
        Select txt.Name
        If emptyTextBoxes.Any Then
            MessageBox.Show(String.Format("Please fill following textboxes: {0}",
                    String.Join(",", emptyTextBoxes)))

        ElseIf ComboBox1.SelectedIndex = -1 Then
            MsgBox("Choose Role", MsgBoxStyle.Information)
        End If

        If ComboBox1.SelectedItem = "User" Then
            'Dim role As String = "User"
            con.Open()
            str = "select * from [dbo].[user] where Username = '" + Me.Username.Text + "' and Password = '" + Me.Password.Text + "' "
            com = New SqlCommand(str, con)
            com.ExecuteNonQuery()
            da = New SqlDataAdapter
            dt = New DataTable
            da.SelectCommand = com
            da.Fill(dt)
            con.Close()
            da.Dispose()
            If dt.Rows.Count > 0 Then
                LoggedInUserId = dt.Rows(0).Item("User_id")
                Username = dt.Rows(0).Item("Username")
                LoggedInUserName = Username
                Password = dt.Rows(0).Item("Password")
                If Me.Username.Text = Username And Me.Password.Text = Password Then
                    MsgBox("Welcome " & Me.Username.Text)
                    User.Show()
                    Me.Close()
                End If
            Else
                MsgBox("Username or Password is Invalid!", MsgBoxStyle.Exclamation)
                Me.Username.Text = ""
                Me.Password.Text = ""
            End If

        ElseIf ComboBox1.SelectedItem = "Admin" Then
            'Dim role As String = "Admin"
            con.Open()
            '   "select * from dbo.admin where Ad_Username = 'sri' and Ad_Password = '12345' "
            str = "select * from dbo.admin where Ad_Username = '" + Me.Username.Text + "' and Ad_Password = '" + Me.Password.Text + "'  "
            com = New SqlCommand(str, con)
            com.ExecuteNonQuery()
            da = New SqlDataAdapter
            dt = New DataTable
            da.SelectCommand = com
            da.Fill(dt)
            con.Close()
            da.Dispose()
            If dt.Rows.Count > 0 Then
                LoggedInUserId = dt.Rows(0).Item("Admin_Id")
                Username = dt.Rows(0).Item("Ad_Username")
                LoggedInUserName = Username
                Password = dt.Rows(0).Item("Ad_Password")
                If Me.Username.Text = Username And Me.Password.Text = Password Then
                    MsgBox("Welcome " & Me.Username.Text)
                    Admin.Show()
                    Me.Close()
                End If
            Else
                MsgBox("Username or Password is Invalid!", MsgBoxStyle.Exclamation)
                Me.Username.Text = ""
                Me.Password.Text = ""
            End If

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Username.Text = ""
        Password.Text = ""
        LoggedInUserId = vbNull
        LoggedInUserName = vbNull
        ComboBox1.SelectedIndex = -1
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Registration.Show()
        Me.Close()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class