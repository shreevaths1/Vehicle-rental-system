Imports System.Text.RegularExpressions
Imports System.Data.SqlClient
Public Class Registration
    Dim con = New SqlConnection(connection_str)
    Dim str As String
    Dim com As SqlCommand
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim regex As Regex = New Regex("^[^@\s]+@[^@\s]+\.[^@\s]+$")
        Dim isvalid As Boolean = regex.IsMatch(Email.Text.Trim)

        Dim emptyTextBoxes =
        From txt In Me.Controls.OfType(Of TextBox)()
        Where txt.Text.Length = 0
        Select txt.Name
        If emptyTextBoxes.Any Then
            MessageBox.Show(String.Format("Please fill following textboxes: {0}",
                    String.Join(",", emptyTextBoxes)))
            Return
        End If

        If Not IsNumeric(Contact.Text) Then
            MsgBox("Invalid Phone number")
            Return
        End If

        If Contact.Text.Length <> 10 Then
            MsgBox("Invalid Phone number")
            Return
        End If

        If Not isvalid Then
            MsgBox("Invalid Email Address")
            Return
        End If


        If Not (emptyTextBoxes.Any) Then
            con.Open()
            'Insert into cust(Username, Password, Email, Contact, City) values('john','john123','john@gmail.com',7574637847,'Bangalore')
            str = "insert into [dbo].[user](Username,Password,Email,Contact,City) values('" + Username.Text + "','" + Password.Text + "','" + Email.Text + "'," + Contact.Text + ",'" + City.Text + "')"
            com = New SqlCommand(str, con)
            com.ExecuteNonQuery()
            MsgBox("Customer Details Inserted Successfully..")
            con.Close()
            Login.Show()
            Me.Close()
        End If



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Login.LoggedInUserName = "admin" Then
            Admin.Show()
            Me.Close()
        Else
            Login.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Registration_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class