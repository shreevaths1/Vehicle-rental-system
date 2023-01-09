Imports System.Data.SqlClient

Public Class UserViewVehicles
    Dim con = New SqlConnection(connection_str)
    Dim cmd As SqlCommand
    Dim da As SqlDataAdapter
    Dim str As String
    Dim x As Integer
    Dim dt As DataTable
    Dim dr As SqlDataReader

    Private Sub UserViewVehicles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.Open()
        str = "select 'Select' as vehicle_type UNION ALL select distinct vehicle_type from [dbo].[vehicle]"
        cmd = New SqlCommand(str, con)
        cmd.ExecuteNonQuery()
        da = New SqlDataAdapter
        dt = New DataTable
        da.SelectCommand = cmd
        da.Fill(dt)
        con.Close()
        da.Dispose()
        If dt.Rows.Count > 0 Then
            Me.ComboBox1.DataSource = dt
            Me.ComboBox1.DisplayMember = "vehicle_type"
            Me.ComboBox1.ValueMember = "vehicle_type"
        Else
            MsgBox("No vehicle data found. Contact administrator!", MsgBoxStyle.Exclamation)
        End If
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim rowView As DataRowView = Me.ComboBox1.SelectedItem
        Me.ComboBox2.DataSource = Nothing
        Me.ComboBox2.Items.Clear()

        If Not rowView.Row.Item(0).ToString = "Select" Then

            con.Open()
            str = "select 'Select' as vehicle_brand UNION ALL select distinct vehicle_brand from [dbo].[vehicle] where vehicle_type = '" + rowView.Row.Item(0) + "' and status = 'Available'"
            'MsgBox(str)
            cmd = New SqlCommand(str, con)
            cmd.ExecuteNonQuery()
            da = New SqlDataAdapter
            dt = New DataTable
            da.SelectCommand = cmd
            da.Fill(dt)
            con.Close()
            da.Dispose()
            If dt.Rows.Count > 0 Then

                Me.ComboBox2.DataSource = dt
                Me.ComboBox2.DisplayMember = "vehicle_brand"
                Me.ComboBox2.ValueMember = "vehicle_brand"
            Else
                MsgBox("No vehicle data found. Contact administrator!", MsgBoxStyle.Exclamation)
            End If
        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        Me.ComboBox3.DataSource = Nothing
        Me.ComboBox3.Items.Clear()
        If Me.ComboBox2.DataSource Is Nothing Then
            Return
        End If
        Dim rowView As DataRowView = Me.ComboBox2.SelectedItem

        If Not rowView.Row.Item(0).ToString = "Select" Then
            con.Open()
            str = "select 'Select' as vehicle_model UNION ALL select distinct vehicle_model from [dbo].[vehicle] where vehicle_brand = '" + rowView.Row.Item(0) + "' and status = 'Available'"
            cmd = New SqlCommand(str, con)
            cmd.ExecuteNonQuery()
            da = New SqlDataAdapter
            dt = New DataTable
            da.SelectCommand = cmd
            da.Fill(dt)
            con.Close()
            da.Dispose()
            If dt.Rows.Count > 0 Then
                Me.ComboBox3.DataSource = dt
                Me.ComboBox3.DisplayMember = "vehicle_model"
                Me.ComboBox3.ValueMember = "vehicle_model"
            Else
                MsgBox("No vehicle data found. Contact administrator!", MsgBoxStyle.Exclamation)
            End If
        End If
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        Me.ComboBox4.DataSource = Nothing
        Me.ComboBox4.Items.Clear()
        If Me.ComboBox3.DataSource Is Nothing Then
            Return
        End If
        Dim rowView As DataRowView = Me.ComboBox3.SelectedItem
        If Not rowView.Row.Item(0).ToString = "Select" Then
            con.Open()
            str = "select 'Select' as color UNION ALL select distinct color from [dbo].[vehicle] where vehicle_model = '" + rowView.Row.Item(0) + "' and status = 'Available'"
            cmd = New SqlCommand(str, con)
            cmd.ExecuteNonQuery()
            da = New SqlDataAdapter
            dt = New DataTable
            da.SelectCommand = cmd
            da.Fill(dt)
            con.Close()
            da.Dispose()
            If dt.Rows.Count > 0 Then
                Me.ComboBox4.DataSource = dt
                Me.ComboBox4.DisplayMember = "color"
                Me.ComboBox4.ValueMember = "color"
            Else
                MsgBox("No vehicle data found. Contact administrator!", MsgBoxStyle.Exclamation)
            End If
        End If
    End Sub

    'Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox4.SelectedIndexChanged
    'Dim rowView As DataRowView = Me.ComboBox4.SelectedItem
    'If Not rowView.Row.Item(0).ToString = "Select" Then
    '       con.Open()
    '      str = "select 'Select' as engine UNION ALL select distinct engine from [dbo].[vehicle] where color = '" + rowView.Row.Item(0) + "' and status = 'Available'"
    '     cmd = New SqlCommand(str, con)
    '    cmd.ExecuteNonQuery()
    '   da = New SqlDataAdapter
    '  dt = New DataTable
    ' da.SelectCommand = cmd

    'da.Fill(dt)
    'con.Close()
    'da.Dispose()
    'If dt.Rows.Count > 0 Then
    'Me.ComboBox5.DataSource = dt
    'Me.ComboBox5.DisplayMember = "engine"
    'Me.ComboBox5.ValueMember = "engine"
    'Else
    '           MsgBox("No vehicle data found. Contact administrator!", MsgBoxStyle.Exclamation)
    'End If
    'End If
    'End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim type As DataRowView = Me.ComboBox1.SelectedItem
        Dim brand As DataRowView = Me.ComboBox2.SelectedItem
        Dim model As DataRowView = Me.ComboBox3.SelectedItem
        Dim color As DataRowView = Me.ComboBox4.SelectedItem
        Dim engine As String = Me.ComboBox5.SelectedItem
        'Dim engine As DataRowView = Me.ComboBox5.SelectedItem

        Dim typeClause As String = "vehicle_type = vehicle_type"
        If Not type Is Nothing And Not type.Row.Item(0) = "Select" Then
            typeClause = "vehicle_type = '" + type.Row.Item(0) + "'"
        End If

        Dim brandClause As String = "vehicle_brand = vehicle_brand"
        If Not IsNothing(brand) Then
            If Not brand.Row.Item(0) = "Select" Then
                brandClause = "vehicle_brand = '" + brand.Row.Item(0) + "'"
            End If
        End If

        Dim modelClause As String = "vehicle_model = vehicle_model"
        If Not model Is Nothing Then
            If Not model.Row.Item(0) = "Select" Then
                modelClause = "vehicle_model = '" + model.Row.Item(0) + "'"
            End If
        End If

        Dim colorClause As String = "color = color"
        If Not color Is Nothing Then
            If Not color.Row.Item(0) = "Select" Then
                colorClause = "color = '" + color.Row.Item(0) + "'"
            End If
        End If

        Dim engineClause As String = "engine = engine"
        If Not engine Is Nothing Then
            'If Not engine.Row.Item(0) = "Select" Then
            'engineClause = "engine = '" + engine.Row.Item(0) + "'"
            engineClause = "engine = '" + engine + "'"

            ' End If
        End If

        str = "select * from vehicle where " + typeClause + " AND " + brandClause + " AND " + modelClause + " AND " + colorClause + " AND " + engineClause + " AND status = 'available'"


        con.Open()
        cmd = New SqlCommand(str, con)
        cmd.ExecuteNonQuery()
        da = New SqlDataAdapter()
        dt = New DataTable()
        da.SelectCommand = cmd
        da.Fill(dt)
        Dim vehicle As Object
        DataGridView1.DataSource = New BindingSource(dt, vehicle)
        con.Close()
        da.Dispose()
        'MsgBox(DataGridView1.Rows.Count)

        If DataGridView1.Rows.Count = 1 Then
            MsgBox("No vehicles of selected type found!", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim index = Me.DataGridView1.SelectedRows(0).Index
        Dim dataGridViewRow = Me.DataGridView1.Rows.Item(index)
        Dim cell As String = dataGridViewRow.Cells.Item(0).Value
        If DataGridView1.SelectedRows.Count = 1 And cell <> "" Then
            Booking.Show()
            Me.Close()
        Else
            MsgBox("Select a record to book", MsgBoxStyle.Information)
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        User.Show()
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ComboBox1.SelectedIndex = 0
        DataGridView1.DataSource = Nothing
        DataGridView1.Rows.Clear()
        ComboBox5.SelectedIndex = -1
    End Sub
End Class