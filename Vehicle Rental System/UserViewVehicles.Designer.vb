<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserViewVehicles
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.VehicleRentDataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VehicleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VehicleTableAdapter = New Vehicle_Rental_System.VehicleRentDataSet1TableAdapters.vehicleTableAdapter()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.VehicleIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VehicleTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ModelYearDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VehicleBrandDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VehicleModelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CapacityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.License_number = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EngineDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Rate_Per_Day = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VehicleBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.VehicleRentDataSet1 = New Vehicle_Rental_System.VehicleRentDataSet1()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.VehicleBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.VehicleRentDataSet1BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboBox5 = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        CType(Me.VehicleRentDataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VehicleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VehicleBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VehicleRentDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VehicleBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VehicleRentDataSet1BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(377, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Vehicles"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(172, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 24)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Type"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(566, 73)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 1
        '
        'VehicleBindingSource
        '
        Me.VehicleBindingSource.DataSource = Me.VehicleRentDataSet1BindingSource
        '
        'VehicleTableAdapter
        '
        Me.VehicleTableAdapter.ClearBeforeFill = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(172, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 24)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Brand"
        '
        'ComboBox2
        '
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(566, 111)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox2.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(172, 147)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 24)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Model"
        '
        'ComboBox3
        '
        Me.ComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(566, 147)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox3.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(307, 285)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(93, 40)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Search"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.VehicleIdDataGridViewTextBoxColumn, Me.VehicleTypeDataGridViewTextBoxColumn, Me.ModelYearDataGridViewTextBoxColumn, Me.VehicleBrandDataGridViewTextBoxColumn, Me.VehicleModelDataGridViewTextBoxColumn, Me.ColorDataGridViewTextBoxColumn, Me.CapacityDataGridViewTextBoxColumn, Me.License_number, Me.EngineDataGridViewTextBoxColumn, Me.StatusDataGridViewTextBoxColumn, Me.Rate_Per_Day})
        Me.DataGridView1.DataSource = Me.VehicleBindingSource1
        Me.DataGridView1.Location = New System.Drawing.Point(58, 341)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(786, 158)
        Me.DataGridView1.TabIndex = 8
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
        'ModelYearDataGridViewTextBoxColumn
        '
        Me.ModelYearDataGridViewTextBoxColumn.DataPropertyName = "Model_Year"
        Me.ModelYearDataGridViewTextBoxColumn.HeaderText = "Model_Year"
        Me.ModelYearDataGridViewTextBoxColumn.Name = "ModelYearDataGridViewTextBoxColumn"
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
        'CapacityDataGridViewTextBoxColumn
        '
        Me.CapacityDataGridViewTextBoxColumn.DataPropertyName = "Capacity"
        Me.CapacityDataGridViewTextBoxColumn.HeaderText = "Capacity"
        Me.CapacityDataGridViewTextBoxColumn.Name = "CapacityDataGridViewTextBoxColumn"
        '
        'License_number
        '
        Me.License_number.DataPropertyName = "License_number"
        Me.License_number.HeaderText = "License_number"
        Me.License_number.Name = "License_number"
        '
        'EngineDataGridViewTextBoxColumn
        '
        Me.EngineDataGridViewTextBoxColumn.DataPropertyName = "Engine"
        Me.EngineDataGridViewTextBoxColumn.HeaderText = "Engine"
        Me.EngineDataGridViewTextBoxColumn.Name = "EngineDataGridViewTextBoxColumn"
        '
        'StatusDataGridViewTextBoxColumn
        '
        Me.StatusDataGridViewTextBoxColumn.DataPropertyName = "Status"
        Me.StatusDataGridViewTextBoxColumn.HeaderText = "Status"
        Me.StatusDataGridViewTextBoxColumn.Name = "StatusDataGridViewTextBoxColumn"
        '
        'Rate_Per_Day
        '
        Me.Rate_Per_Day.DataPropertyName = "Rate_Per_Day"
        Me.Rate_Per_Day.HeaderText = "Rate_Per_Day"
        Me.Rate_Per_Day.Name = "Rate_Per_Day"
        '
        'VehicleBindingSource1
        '
        Me.VehicleBindingSource1.DataMember = "vehicle"
        Me.VehicleBindingSource1.DataSource = Me.VehicleRentDataSet1
        '
        'VehicleRentDataSet1
        '
        Me.VehicleRentDataSet1.DataSetName = "VehicleRentDataSet1"
        Me.VehicleRentDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(428, 523)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(95, 40)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Book"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'VehicleBindingSource2
        '
        Me.VehicleBindingSource2.DataSource = Me.VehicleRentDataSet1BindingSource
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(307, 523)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(93, 40)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "Back"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'ComboBox4
        '
        Me.ComboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Location = New System.Drawing.Point(566, 190)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox4.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(172, 190)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 24)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Color"
        '
        'ComboBox5
        '
        Me.ComboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox5.FormattingEnabled = True
        Me.ComboBox5.Items.AddRange(New Object() {"Petrol", "Diesel"})
        Me.ComboBox5.Location = New System.Drawing.Point(566, 233)
        Me.ComboBox5.Name = "ComboBox5"
        Me.ComboBox5.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox5.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(172, 233)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(105, 24)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Fuel Type"
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(428, 285)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(95, 40)
        Me.Button4.TabIndex = 11
        Me.Button4.Text = "Reset"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'UserViewVehicles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(889, 582)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.ComboBox5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ComboBox4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "UserViewVehicles"
        Me.Text = "UserViewVehicles"
        CType(Me.VehicleRentDataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VehicleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VehicleBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VehicleRentDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VehicleBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VehicleRentDataSet1BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents VehicleRentDataSet1BindingSource As BindingSource
    Friend WithEvents VehicleBindingSource As BindingSource
    Friend WithEvents VehicleTableAdapter As VehicleRentDataSet1TableAdapters.vehicleTableAdapter
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents RateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Button2 As Button
    Friend WithEvents VehicleBindingSource2 As BindingSource
    Friend WithEvents VehicleRentDataSet1 As VehicleRentDataSet1
    Friend WithEvents VehicleRentDataSet1BindingSource1 As BindingSource
    Friend WithEvents VehicleBindingSource1 As BindingSource
    Friend WithEvents VehicleIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VehicleTypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ModelYearDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VehicleBrandDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VehicleModelDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ColorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CapacityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents License_number As DataGridViewTextBoxColumn
    Friend WithEvents EngineDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Rate_Per_Day As DataGridViewTextBoxColumn
    Friend WithEvents Button3 As Button
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboBox5 As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Button4 As Button
End Class
