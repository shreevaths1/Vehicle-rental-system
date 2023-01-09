<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Transact_History
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.UserIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsernameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookingIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VehicleIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VehicleTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VehicleBrandDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VehicleModelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LicensenumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RateperdayDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RentalDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReturnDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RentDurationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RentAmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaymentIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaymentDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TestDataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TestDataSet1 = New Vehicle_Rental_System.TestDataSet1()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataTable1TableAdapter = New Vehicle_Rental_System.TestDataSet1TableAdapters.DataTable1TableAdapter()
        Me.Reset = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TestDataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TestDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(296, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(198, 25)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Transaction History"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UserIdDataGridViewTextBoxColumn, Me.UsernameDataGridViewTextBoxColumn, Me.BookingIdDataGridViewTextBoxColumn, Me.VehicleIdDataGridViewTextBoxColumn, Me.VehicleTypeDataGridViewTextBoxColumn, Me.VehicleBrandDataGridViewTextBoxColumn, Me.VehicleModelDataGridViewTextBoxColumn, Me.ColorDataGridViewTextBoxColumn, Me.LicensenumberDataGridViewTextBoxColumn, Me.RateperdayDataGridViewTextBoxColumn, Me.RentalDateDataGridViewTextBoxColumn, Me.ReturnDateDataGridViewTextBoxColumn, Me.RentDurationDataGridViewTextBoxColumn, Me.RentAmountDataGridViewTextBoxColumn, Me.PaymentIdDataGridViewTextBoxColumn, Me.PaymentDateDataGridViewTextBoxColumn, Me.DataGridViewTextBoxColumn1})
        Me.DataGridView1.DataSource = Me.TestDataSet1BindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 191)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(720, 150)
        Me.DataGridView1.TabIndex = 15
        '
        'UserIdDataGridViewTextBoxColumn
        '
        Me.UserIdDataGridViewTextBoxColumn.DataPropertyName = "User_Id"
        Me.UserIdDataGridViewTextBoxColumn.HeaderText = "User_Id"
        Me.UserIdDataGridViewTextBoxColumn.Name = "UserIdDataGridViewTextBoxColumn"
        Me.UserIdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UsernameDataGridViewTextBoxColumn
        '
        Me.UsernameDataGridViewTextBoxColumn.DataPropertyName = "Username"
        Me.UsernameDataGridViewTextBoxColumn.HeaderText = "Username"
        Me.UsernameDataGridViewTextBoxColumn.Name = "UsernameDataGridViewTextBoxColumn"
        '
        'BookingIdDataGridViewTextBoxColumn
        '
        Me.BookingIdDataGridViewTextBoxColumn.DataPropertyName = "Booking_Id"
        Me.BookingIdDataGridViewTextBoxColumn.HeaderText = "Booking_Id"
        Me.BookingIdDataGridViewTextBoxColumn.Name = "BookingIdDataGridViewTextBoxColumn"
        Me.BookingIdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'VehicleIdDataGridViewTextBoxColumn
        '
        Me.VehicleIdDataGridViewTextBoxColumn.DataPropertyName = "Vehicle_Id"
        Me.VehicleIdDataGridViewTextBoxColumn.HeaderText = "Vehicle_Id"
        Me.VehicleIdDataGridViewTextBoxColumn.Name = "VehicleIdDataGridViewTextBoxColumn"
        Me.VehicleIdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'VehicleTypeDataGridViewTextBoxColumn
        '
        Me.VehicleTypeDataGridViewTextBoxColumn.DataPropertyName = "Vehicle_Type"
        Me.VehicleTypeDataGridViewTextBoxColumn.HeaderText = "Vehicle_Type"
        Me.VehicleTypeDataGridViewTextBoxColumn.Name = "VehicleTypeDataGridViewTextBoxColumn"
        '
        'VehicleBrandDataGridViewTextBoxColumn
        '
        Me.VehicleBrandDataGridViewTextBoxColumn.DataPropertyName = "Vehicle_Brand"
        Me.VehicleBrandDataGridViewTextBoxColumn.HeaderText = "Vehicle_Brand"
        Me.VehicleBrandDataGridViewTextBoxColumn.Name = "VehicleBrandDataGridViewTextBoxColumn"
        '
        'VehicleModelDataGridViewTextBoxColumn
        '
        Me.VehicleModelDataGridViewTextBoxColumn.DataPropertyName = "Vehicle_Model"
        Me.VehicleModelDataGridViewTextBoxColumn.HeaderText = "Vehicle_Model"
        Me.VehicleModelDataGridViewTextBoxColumn.Name = "VehicleModelDataGridViewTextBoxColumn"
        '
        'ColorDataGridViewTextBoxColumn
        '
        Me.ColorDataGridViewTextBoxColumn.DataPropertyName = "Color"
        Me.ColorDataGridViewTextBoxColumn.HeaderText = "Color"
        Me.ColorDataGridViewTextBoxColumn.Name = "ColorDataGridViewTextBoxColumn"
        '
        'LicensenumberDataGridViewTextBoxColumn
        '
        Me.LicensenumberDataGridViewTextBoxColumn.DataPropertyName = "License_number"
        Me.LicensenumberDataGridViewTextBoxColumn.HeaderText = "License_number"
        Me.LicensenumberDataGridViewTextBoxColumn.Name = "LicensenumberDataGridViewTextBoxColumn"
        '
        'RateperdayDataGridViewTextBoxColumn
        '
        Me.RateperdayDataGridViewTextBoxColumn.DataPropertyName = "rate_per_day"
        Me.RateperdayDataGridViewTextBoxColumn.HeaderText = "rate_per_day"
        Me.RateperdayDataGridViewTextBoxColumn.Name = "RateperdayDataGridViewTextBoxColumn"
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
        'PaymentIdDataGridViewTextBoxColumn
        '
        Me.PaymentIdDataGridViewTextBoxColumn.DataPropertyName = "Payment_Id"
        Me.PaymentIdDataGridViewTextBoxColumn.HeaderText = "Payment_Id"
        Me.PaymentIdDataGridViewTextBoxColumn.Name = "PaymentIdDataGridViewTextBoxColumn"
        Me.PaymentIdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PaymentDateDataGridViewTextBoxColumn
        '
        Me.PaymentDateDataGridViewTextBoxColumn.DataPropertyName = "Payment_Date"
        Me.PaymentDateDataGridViewTextBoxColumn.HeaderText = "Payment_Date"
        Me.PaymentDateDataGridViewTextBoxColumn.Name = "PaymentDateDataGridViewTextBoxColumn"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Card_Type"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Card_Type"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'TestDataSet1BindingSource
        '
        Me.TestDataSet1BindingSource.DataMember = "DataTable1"
        Me.TestDataSet1BindingSource.DataSource = Me.TestDataSet1
        '
        'TestDataSet1
        '
        Me.TestDataSet1.DataSetName = "TestDataSet1"
        Me.TestDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(358, 349)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(84, 37)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox5
        '
        Me.TextBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(592, 98)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(146, 26)
        Me.TextBox5.TabIndex = 31
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(397, 98)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(160, 20)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Search By Vehicle Id "
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(592, 56)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(146, 26)
        Me.TextBox4.TabIndex = 29
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(397, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(166, 20)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Search By Booking Id "
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(208, 56)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(146, 26)
        Me.TextBox1.TabIndex = 25
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(170, 20)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Search By Payment Id "
        '
        'DataTable1TableAdapter
        '
        Me.DataTable1TableAdapter.ClearBeforeFill = True
        '
        'Reset
        '
        Me.Reset.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Reset.Location = New System.Drawing.Point(354, 136)
        Me.Reset.Name = "Reset"
        Me.Reset.Size = New System.Drawing.Size(88, 40)
        Me.Reset.TabIndex = 32
        Me.Reset.Text = "Reset"
        Me.Reset.UseVisualStyleBackColor = True
        '
        'Transact_History
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(749, 398)
        Me.Controls.Add(Me.Reset)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Transact_History"
        Me.Text = "Transact_History"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TestDataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TestDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents CardTypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CardNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CardHolderDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ExpiringDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CVVDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents UserIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UsernameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BookingIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VehicleIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VehicleTypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VehicleBrandDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VehicleModelDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ColorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LicensenumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RateperdayDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RentalDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ReturnDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RentDurationDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RentAmountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PaymentIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PaymentDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents TestDataSet1BindingSource As BindingSource
    Friend WithEvents TestDataSet1 As TestDataSet1
    Friend WithEvents DataTable1TableAdapter As TestDataSet1TableAdapters.DataTable1TableAdapter
    Friend WithEvents Reset As Button
End Class
