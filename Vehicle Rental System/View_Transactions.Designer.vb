<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class View_Transactions
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.RentAmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RentDurationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReturnDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RentalDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VehicleIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookingIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.UserIdDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsernameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookingIdDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaymentIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaymentDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaymentAmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaymentDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PaymentDataSet = New Vehicle_Rental_System.PaymentDataSet()
        Me.DataTable3TableAdapter = New Vehicle_Rental_System.PaymentDataSetTableAdapters.DataTable3TableAdapter()
        Me.Reset = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PaymentDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PaymentDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(376, 383)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(84, 37)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(612, 81)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(146, 26)
        Me.TextBox3.TabIndex = 16
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(238, 116)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(146, 26)
        Me.TextBox2.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(43, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(142, 20)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Search By User Id "
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(238, 75)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(146, 26)
        Me.TextBox1.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(43, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(170, 20)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Search By Payment Id "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(298, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(251, 25)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Search Payment Record "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(417, 81)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(166, 20)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Search By Booking Id "
        '
        'RentAmountDataGridViewTextBoxColumn
        '
        Me.RentAmountDataGridViewTextBoxColumn.DataPropertyName = "Rent_Amount"
        Me.RentAmountDataGridViewTextBoxColumn.HeaderText = "Rent_Amount"
        Me.RentAmountDataGridViewTextBoxColumn.Name = "RentAmountDataGridViewTextBoxColumn"
        '
        'RentDurationDataGridViewTextBoxColumn
        '
        Me.RentDurationDataGridViewTextBoxColumn.DataPropertyName = "Rent_Duration"
        Me.RentDurationDataGridViewTextBoxColumn.HeaderText = "Rent_Duration"
        Me.RentDurationDataGridViewTextBoxColumn.Name = "RentDurationDataGridViewTextBoxColumn"
        '
        'ReturnDateDataGridViewTextBoxColumn
        '
        Me.ReturnDateDataGridViewTextBoxColumn.DataPropertyName = "Return_Date"
        Me.ReturnDateDataGridViewTextBoxColumn.HeaderText = "Return_Date"
        Me.ReturnDateDataGridViewTextBoxColumn.Name = "ReturnDateDataGridViewTextBoxColumn"
        '
        'RentalDateDataGridViewTextBoxColumn
        '
        Me.RentalDateDataGridViewTextBoxColumn.DataPropertyName = "Rental_Date"
        Me.RentalDateDataGridViewTextBoxColumn.HeaderText = "Rental_Date"
        Me.RentalDateDataGridViewTextBoxColumn.Name = "RentalDateDataGridViewTextBoxColumn"
        '
        'VehicleIdDataGridViewTextBoxColumn
        '
        Me.VehicleIdDataGridViewTextBoxColumn.DataPropertyName = "Vehicle_Id"
        Me.VehicleIdDataGridViewTextBoxColumn.HeaderText = "Vehicle_Id"
        Me.VehicleIdDataGridViewTextBoxColumn.Name = "VehicleIdDataGridViewTextBoxColumn"
        '
        'UserIdDataGridViewTextBoxColumn
        '
        Me.UserIdDataGridViewTextBoxColumn.DataPropertyName = "User_Id"
        Me.UserIdDataGridViewTextBoxColumn.HeaderText = "User_Id"
        Me.UserIdDataGridViewTextBoxColumn.Name = "UserIdDataGridViewTextBoxColumn"
        '
        'BookingIdDataGridViewTextBoxColumn
        '
        Me.BookingIdDataGridViewTextBoxColumn.DataPropertyName = "Booking_Id"
        Me.BookingIdDataGridViewTextBoxColumn.HeaderText = "Booking_Id"
        Me.BookingIdDataGridViewTextBoxColumn.Name = "BookingIdDataGridViewTextBoxColumn"
        Me.BookingIdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UserIdDataGridViewTextBoxColumn1, Me.UsernameDataGridViewTextBoxColumn, Me.BookingIdDataGridViewTextBoxColumn1, Me.PaymentIdDataGridViewTextBoxColumn, Me.PaymentDateDataGridViewTextBoxColumn, Me.PaymentAmountDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.PaymentDataSetBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(104, 218)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(640, 150)
        Me.DataGridView1.TabIndex = 19
        '
        'UserIdDataGridViewTextBoxColumn1
        '
        Me.UserIdDataGridViewTextBoxColumn1.DataPropertyName = "User_Id"
        Me.UserIdDataGridViewTextBoxColumn1.HeaderText = "User_Id"
        Me.UserIdDataGridViewTextBoxColumn1.Name = "UserIdDataGridViewTextBoxColumn1"
        Me.UserIdDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'UsernameDataGridViewTextBoxColumn
        '
        Me.UsernameDataGridViewTextBoxColumn.DataPropertyName = "Username"
        Me.UsernameDataGridViewTextBoxColumn.HeaderText = "Username"
        Me.UsernameDataGridViewTextBoxColumn.Name = "UsernameDataGridViewTextBoxColumn"
        '
        'BookingIdDataGridViewTextBoxColumn1
        '
        Me.BookingIdDataGridViewTextBoxColumn1.DataPropertyName = "Booking_Id"
        Me.BookingIdDataGridViewTextBoxColumn1.HeaderText = "Booking_Id"
        Me.BookingIdDataGridViewTextBoxColumn1.Name = "BookingIdDataGridViewTextBoxColumn1"
        Me.BookingIdDataGridViewTextBoxColumn1.ReadOnly = True
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
        'PaymentAmountDataGridViewTextBoxColumn
        '
        Me.PaymentAmountDataGridViewTextBoxColumn.DataPropertyName = "Payment_Amount"
        Me.PaymentAmountDataGridViewTextBoxColumn.HeaderText = "Payment_Amount"
        Me.PaymentAmountDataGridViewTextBoxColumn.Name = "PaymentAmountDataGridViewTextBoxColumn"
        '
        'PaymentDataSetBindingSource
        '
        Me.PaymentDataSetBindingSource.DataMember = "DataTable3"
        Me.PaymentDataSetBindingSource.DataSource = Me.PaymentDataSet
        '
        'PaymentDataSet
        '
        Me.PaymentDataSet.DataSetName = "PaymentDataSet"
        Me.PaymentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataTable3TableAdapter
        '
        Me.DataTable3TableAdapter.ClearBeforeFill = True
        '
        'Reset
        '
        Me.Reset.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Reset.Location = New System.Drawing.Point(376, 161)
        Me.Reset.Name = "Reset"
        Me.Reset.Size = New System.Drawing.Size(88, 40)
        Me.Reset.TabIndex = 33
        Me.Reset.Text = "Reset"
        Me.Reset.UseVisualStyleBackColor = True
        '
        'View_Transactions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Reset)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Name = "View_Transactions"
        Me.Text = " "
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PaymentDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PaymentDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents RentAmountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RentDurationDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ReturnDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RentalDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VehicleIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UserIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BookingIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents CardTypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CardNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CardHolderDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ExpiringDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CVVDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UserIdDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents UsernameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BookingIdDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents PaymentIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PaymentDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PaymentAmountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PaymentDataSetBindingSource As BindingSource
    Friend WithEvents PaymentDataSet As PaymentDataSet
    Friend WithEvents DataTable3TableAdapter As PaymentDataSetTableAdapters.DataTable3TableAdapter
    Friend WithEvents Reset As Button
End Class
