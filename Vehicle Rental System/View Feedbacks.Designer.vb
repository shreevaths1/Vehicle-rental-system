<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class View_Feedbacks
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
        Me.ExpiringDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CardHolderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CardNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CardTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaymentDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserIdDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookingIdDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaymentIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaymentDataSet = New Vehicle_Rental_System.PaymentDataSet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BookingIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VehicleIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RentalDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReturnDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RentDurationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RentAmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CVVDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.UserIdDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsernameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubjectDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FeedbackDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FeedbackDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FeedbackDataSet = New Vehicle_Rental_System.FeedbackDataSet()
        Me.DataTable2TableAdapter = New Vehicle_Rental_System.FeedbackDataSetTableAdapters.DataTable2TableAdapter()
        CType(Me.PaymentDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FeedbackDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FeedbackDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ExpiringDateDataGridViewTextBoxColumn
        '
        Me.ExpiringDateDataGridViewTextBoxColumn.DataPropertyName = "Expiring_Date"
        Me.ExpiringDateDataGridViewTextBoxColumn.HeaderText = "Expiring_Date"
        Me.ExpiringDateDataGridViewTextBoxColumn.Name = "ExpiringDateDataGridViewTextBoxColumn"
        '
        'CardHolderDataGridViewTextBoxColumn
        '
        Me.CardHolderDataGridViewTextBoxColumn.DataPropertyName = "Card_Holder"
        Me.CardHolderDataGridViewTextBoxColumn.HeaderText = "Card_Holder"
        Me.CardHolderDataGridViewTextBoxColumn.Name = "CardHolderDataGridViewTextBoxColumn"
        '
        'CardNoDataGridViewTextBoxColumn
        '
        Me.CardNoDataGridViewTextBoxColumn.DataPropertyName = "Card_No"
        Me.CardNoDataGridViewTextBoxColumn.HeaderText = "Card_No"
        Me.CardNoDataGridViewTextBoxColumn.Name = "CardNoDataGridViewTextBoxColumn"
        '
        'CardTypeDataGridViewTextBoxColumn
        '
        Me.CardTypeDataGridViewTextBoxColumn.DataPropertyName = "Card_Type"
        Me.CardTypeDataGridViewTextBoxColumn.HeaderText = "Card_Type"
        Me.CardTypeDataGridViewTextBoxColumn.Name = "CardTypeDataGridViewTextBoxColumn"
        '
        'PaymentDateDataGridViewTextBoxColumn
        '
        Me.PaymentDateDataGridViewTextBoxColumn.DataPropertyName = "Payment_Date"
        Me.PaymentDateDataGridViewTextBoxColumn.HeaderText = "Payment_Date"
        Me.PaymentDateDataGridViewTextBoxColumn.Name = "PaymentDateDataGridViewTextBoxColumn"
        '
        'UserIdDataGridViewTextBoxColumn1
        '
        Me.UserIdDataGridViewTextBoxColumn1.DataPropertyName = "User_Id"
        Me.UserIdDataGridViewTextBoxColumn1.HeaderText = "User_Id"
        Me.UserIdDataGridViewTextBoxColumn1.Name = "UserIdDataGridViewTextBoxColumn1"
        '
        'BookingIdDataGridViewTextBoxColumn1
        '
        Me.BookingIdDataGridViewTextBoxColumn1.DataPropertyName = "Booking_Id"
        Me.BookingIdDataGridViewTextBoxColumn1.HeaderText = "Booking_Id"
        Me.BookingIdDataGridViewTextBoxColumn1.Name = "BookingIdDataGridViewTextBoxColumn1"
        '
        'PaymentIdDataGridViewTextBoxColumn
        '
        Me.PaymentIdDataGridViewTextBoxColumn.DataPropertyName = "Payment_Id"
        Me.PaymentIdDataGridViewTextBoxColumn.HeaderText = "Payment_Id"
        Me.PaymentIdDataGridViewTextBoxColumn.Name = "PaymentIdDataGridViewTextBoxColumn"
        Me.PaymentIdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PaymentDataSet
        '
        Me.PaymentDataSet.DataSetName = "PaymentDataSet"
        Me.PaymentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(103, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(268, 25)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "View Customer Feedbacks"
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
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(239, 84)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(146, 26)
        Me.TextBox2.TabIndex = 22
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(44, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(142, 20)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Search By User Id "
        '
        'CVVDataGridViewTextBoxColumn
        '
        Me.CVVDataGridViewTextBoxColumn.DataPropertyName = "CVV"
        Me.CVVDataGridViewTextBoxColumn.HeaderText = "CVV"
        Me.CVVDataGridViewTextBoxColumn.Name = "CVVDataGridViewTextBoxColumn"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(203, 309)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(84, 37)
        Me.Button1.TabIndex = 25
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UserIdDataGridViewTextBoxColumn2, Me.UsernameDataGridViewTextBoxColumn, Me.SubjectDataGridViewTextBoxColumn, Me.FeedbackDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.FeedbackDataSetBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(31, 141)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(443, 150)
        Me.DataGridView1.TabIndex = 26
        '
        'UserIdDataGridViewTextBoxColumn2
        '
        Me.UserIdDataGridViewTextBoxColumn2.DataPropertyName = "User_Id"
        Me.UserIdDataGridViewTextBoxColumn2.HeaderText = "User_Id"
        Me.UserIdDataGridViewTextBoxColumn2.Name = "UserIdDataGridViewTextBoxColumn2"
        Me.UserIdDataGridViewTextBoxColumn2.ReadOnly = True
        '
        'UsernameDataGridViewTextBoxColumn
        '
        Me.UsernameDataGridViewTextBoxColumn.DataPropertyName = "Username"
        Me.UsernameDataGridViewTextBoxColumn.HeaderText = "Username"
        Me.UsernameDataGridViewTextBoxColumn.Name = "UsernameDataGridViewTextBoxColumn"
        '
        'SubjectDataGridViewTextBoxColumn
        '
        Me.SubjectDataGridViewTextBoxColumn.DataPropertyName = "Subject"
        Me.SubjectDataGridViewTextBoxColumn.HeaderText = "Subject"
        Me.SubjectDataGridViewTextBoxColumn.Name = "SubjectDataGridViewTextBoxColumn"
        '
        'FeedbackDataGridViewTextBoxColumn
        '
        Me.FeedbackDataGridViewTextBoxColumn.DataPropertyName = "Feedback"
        Me.FeedbackDataGridViewTextBoxColumn.HeaderText = "Feedback"
        Me.FeedbackDataGridViewTextBoxColumn.Name = "FeedbackDataGridViewTextBoxColumn"
        '
        'FeedbackDataSetBindingSource
        '
        Me.FeedbackDataSetBindingSource.DataMember = "DataTable2"
        Me.FeedbackDataSetBindingSource.DataSource = Me.FeedbackDataSet
        '
        'FeedbackDataSet
        '
        Me.FeedbackDataSet.DataSetName = "FeedbackDataSet"
        Me.FeedbackDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataTable2TableAdapter
        '
        Me.DataTable2TableAdapter.ClearBeforeFill = True
        '
        'View_Feedbacks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(497, 373)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Name = "View_Feedbacks"
        Me.Text = "View_Feedbacks"
        CType(Me.PaymentDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FeedbackDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FeedbackDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ExpiringDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CardHolderDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CardNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CardTypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PaymentDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UserIdDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents BookingIdDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents PaymentIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PaymentDataSet As PaymentDataSet
    Friend WithEvents Label1 As Label
    Friend WithEvents BookingIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UserIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VehicleIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RentalDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ReturnDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RentDurationDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RentAmountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents CVVDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents UserIdDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents UsernameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SubjectDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FeedbackDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FeedbackDataSetBindingSource As BindingSource
    Friend WithEvents FeedbackDataSet As FeedbackDataSet
    Friend WithEvents DataTable2TableAdapter As FeedbackDataSetTableAdapters.DataTable2TableAdapter
End Class
