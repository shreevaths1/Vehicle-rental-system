<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Booked_Vehicles
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BookingIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VehicleIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RentalDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReturnDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RentDurationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RentAmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookingDataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BookingDataSet1 = New Vehicle_Rental_System.BookingDataSet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.BookingDataSet = New Vehicle_Rental_System.BookingDataSet()
        Me.BookingTableAdapter = New Vehicle_Rental_System.BookingDataSetTableAdapters.bookingTableAdapter()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookingDataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookingDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookingDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BookingIdDataGridViewTextBoxColumn, Me.UserIdDataGridViewTextBoxColumn, Me.VehicleIdDataGridViewTextBoxColumn, Me.RentalDateDataGridViewTextBoxColumn, Me.ReturnDateDataGridViewTextBoxColumn, Me.RentDurationDataGridViewTextBoxColumn, Me.RentAmountDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.BookingDataSet1BindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(33, 205)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(715, 150)
        Me.DataGridView1.TabIndex = 0
        '
        'BookingIdDataGridViewTextBoxColumn
        '
        Me.BookingIdDataGridViewTextBoxColumn.DataPropertyName = "Booking_Id"
        Me.BookingIdDataGridViewTextBoxColumn.HeaderText = "Booking_Id"
        Me.BookingIdDataGridViewTextBoxColumn.Name = "BookingIdDataGridViewTextBoxColumn"
        Me.BookingIdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UserIdDataGridViewTextBoxColumn
        '
        Me.UserIdDataGridViewTextBoxColumn.DataPropertyName = "User_Id"
        Me.UserIdDataGridViewTextBoxColumn.HeaderText = "User_Id"
        Me.UserIdDataGridViewTextBoxColumn.Name = "UserIdDataGridViewTextBoxColumn"
        '
        'VehicleIdDataGridViewTextBoxColumn
        '
        Me.VehicleIdDataGridViewTextBoxColumn.DataPropertyName = "Vehicle_Id"
        Me.VehicleIdDataGridViewTextBoxColumn.HeaderText = "Vehicle_Id"
        Me.VehicleIdDataGridViewTextBoxColumn.Name = "VehicleIdDataGridViewTextBoxColumn"
        '
        'RentalDateDataGridViewTextBoxColumn
        '
        Me.RentalDateDataGridViewTextBoxColumn.DataPropertyName = "Rental_Date"
        Me.RentalDateDataGridViewTextBoxColumn.HeaderText = "Rental_Date"
        Me.RentalDateDataGridViewTextBoxColumn.Name = "RentalDateDataGridViewTextBoxColumn"
        '
        'ReturnDateDataGridViewTextBoxColumn
        '
        Me.ReturnDateDataGridViewTextBoxColumn.DataPropertyName = "Return_Date"
        Me.ReturnDateDataGridViewTextBoxColumn.HeaderText = "Return_Date"
        Me.ReturnDateDataGridViewTextBoxColumn.Name = "ReturnDateDataGridViewTextBoxColumn"
        '
        'RentDurationDataGridViewTextBoxColumn
        '
        Me.RentDurationDataGridViewTextBoxColumn.DataPropertyName = "Rent_Duration"
        Me.RentDurationDataGridViewTextBoxColumn.HeaderText = "Rent_Duration"
        Me.RentDurationDataGridViewTextBoxColumn.Name = "RentDurationDataGridViewTextBoxColumn"
        '
        'RentAmountDataGridViewTextBoxColumn
        '
        Me.RentAmountDataGridViewTextBoxColumn.DataPropertyName = "Rent_Amount"
        Me.RentAmountDataGridViewTextBoxColumn.HeaderText = "Rent_Amount"
        Me.RentAmountDataGridViewTextBoxColumn.Name = "RentAmountDataGridViewTextBoxColumn"
        '
        'BookingDataSet1BindingSource
        '
        Me.BookingDataSet1BindingSource.DataMember = "booking"
        Me.BookingDataSet1BindingSource.DataSource = Me.BookingDataSet1
        '
        'BookingDataSet1
        '
        Me.BookingDataSet1.DataSetName = "BookingDataSet"
        Me.BookingDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(287, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(253, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Search Booked Vehicles "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(33, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(166, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Search By Booking Id "
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(228, 67)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(146, 26)
        Me.TextBox1.TabIndex = 3
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(228, 108)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(146, 26)
        Me.TextBox2.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(33, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(142, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Search By User Id "
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(602, 73)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(146, 26)
        Me.TextBox3.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(407, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(160, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Search By Vehicle Id "
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(290, 370)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(84, 37)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(456, 370)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(84, 37)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Delete"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'BookingDataSet
        '
        Me.BookingDataSet.DataSetName = "BookingDataSet"
        Me.BookingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BookingTableAdapter
        '
        Me.BookingTableAdapter.ClearBeforeFill = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(359, 151)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(84, 37)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "Reset"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Booked_Vehicles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(776, 419)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Booked_Vehicles"
        Me.Text = "Booked_Vehicles"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookingDataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookingDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookingDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BookingDataSet As BookingDataSet
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents BookingIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UserIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VehicleIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RentalDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ReturnDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RentDurationDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RentAmountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BookingDataSet1BindingSource As BindingSource
    Friend WithEvents BookingDataSet1 As BookingDataSet
    Friend WithEvents BookingTableAdapter As BookingDataSetTableAdapters.bookingTableAdapter
    Friend WithEvents Button3 As Button
End Class
