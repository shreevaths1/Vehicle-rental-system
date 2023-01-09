Imports System.Data.SqlClient

Public Class Feedback_Form
    Dim con = New SqlConnection(connection_str)

    Dim com As SqlCommand

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        User.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim emptyTextBoxes =
        From txt In Me.Controls.OfType(Of TextBox)()
        Where txt.Text.Length = 0
        Select txt.Name

        If emptyTextBoxes.Any Then
            MessageBox.Show(String.Format("Please fill following fields: {0}",
                    String.Join(",", emptyTextBoxes)))

        End If

        If Not (emptyTextBoxes.Any) Then
            If Feedback.Text.Length <= 100 Then

                con.Open()
                'Insert into cust(Username, Password, Email, Contact, City) values('john','john123','john@gmail.com',7574637847,'Bangalore')
                Dim Str = "insert into [dbo].[feedback](User_Id,Subject,Feedback) values(" + Login.LoggedInUserId + ",'" + Subject.Text + "','" + Feedback.Text + "')"
                com = New SqlCommand(Str, con)
                com.ExecuteNonQuery()
                MsgBox("Your Feedback Has Been Submitted Successfully..")

                con.Close()

                User.Show()
                Me.Close()

            Else
                MsgBox("Enter Feedback in not more than 100 words")
            End If
        End If
    End Sub

    Private Sub Feedback_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UserBox.Text = Login.LoggedInUserId
        TextBox1.Text = Login.LoggedInUserName
    End Sub
End Class