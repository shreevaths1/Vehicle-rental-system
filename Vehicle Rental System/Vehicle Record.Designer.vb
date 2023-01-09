<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Vehicle_Record
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
        Me.UserBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VehicleRentDataSet = New Vehicle_Rental_System.VehicleRentDataSet()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.UserTableAdapter = New Vehicle_Rental_System.VehicleRentDataSetTableAdapters.userTableAdapter()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.VehicleRentDataSet1 = New Vehicle_Rental_System.VehicleRentDataSet1()
        Me.VehicleTableAdapter = New Vehicle_Rental_System.VehicleRentDataSet1TableAdapters.vehicleTableAdapter()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.VehicleIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VehicleTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ModelYearDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VehicleBrandDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VehicleModelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CapacityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EngineDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LicensenumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RatePerDayDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VehicleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.UserBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VehicleRentDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VehicleRentDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VehicleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UserBindingSource
        '
        Me.UserBindingSource.DataMember = "user"
        Me.UserBindingSource.DataSource = Me.VehicleRentDataSet
        '
        'VehicleRentDataSet
        '
        Me.VehicleRentDataSet.DataSetName = "VehicleRentDataSet"
        Me.VehicleRentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(247, 315)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(128, 39)
        Me.Button2.TabIndex = 26
        Me.Button2.Text = "Delete"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(225, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(344, 39)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Search Vehicle Record"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(176, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 31)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Vehicle Id"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(303, 85)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(266, 31)
        Me.TextBox1.TabIndex = 23
        Me.TextBox1.UseWaitCursor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(563, 315)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(128, 39)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'UserTableAdapter
        '
        Me.UserTableAdapter.ClearBeforeFill = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(90, 315)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(128, 39)
        Me.Button3.TabIndex = 27
        Me.Button3.Text = "Add"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(404, 315)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(128, 39)
        Me.Button4.TabIndex = 28
        Me.Button4.Text = "Update"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'VehicleRentDataSet1
        '
        Me.VehicleRentDataSet1.DataSetName = "VehicleRentDataSet1"
        Me.VehicleRentDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VehicleTableAdapter
        '
        Me.VehicleTableAdapter.ClearBeforeFill = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.VehicleIdDataGridViewTextBoxColumn, Me.VehicleTypeDataGridViewTextBoxColumn, Me.ModelYearDataGridViewTextBoxColumn, Me.VehicleBrandDataGridViewTextBoxColumn, Me.VehicleModelDataGridViewTextBoxColumn, Me.ColorDataGridViewTextBoxColumn, Me.CapacityDataGridViewTextBoxColumn, Me.EngineDataGridViewTextBoxColumn, Me.StatusDataGridViewTextBoxColumn, Me.LicensenumberDataGridViewTextBoxColumn, Me.RatePerDayDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.VehicleBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(25, 133)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(763, 150)
        Me.DataGridView1.TabIndex = 29
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
        'LicensenumberDataGridViewTextBoxColumn
        '
        Me.LicensenumberDataGridViewTextBoxColumn.DataPropertyName = "License_number"
        Me.LicensenumberDataGridViewTextBoxColumn.HeaderText = "License_number"
        Me.LicensenumberDataGridViewTextBoxColumn.Name = "LicensenumberDataGridViewTextBoxColumn"
        '
        'RatePerDayDataGridViewTextBoxColumn
        '
        Me.RatePerDayDataGridViewTextBoxColumn.DataPropertyName = "Rate_Per_Day"
        Me.RatePerDayDataGridViewTextBoxColumn.HeaderText = "Rate_Per_Day"
        Me.RatePerDayDataGridViewTextBoxColumn.Name = "RatePerDayDataGridViewTextBoxColumn"
        '
        'VehicleBindingSource
        '
        Me.VehicleBindingSource.DataMember = "vehicle"
        Me.VehicleBindingSource.DataSource = Me.VehicleRentDataSet1
        '
        'Vehicle_Record
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 397)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Vehicle_Record"
        Me.Text = "Vehicle Record"
        CType(Me.UserBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VehicleRentDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VehicleRentDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VehicleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UserBindingSource As BindingSource
    Friend WithEvents VehicleRentDataSet As VehicleRentDataSet
    Friend WithEvents Button2 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents UserTableAdapter As VehicleRentDataSetTableAdapters.userTableAdapter
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents VehicleRentDataSet1 As VehicleRentDataSet1
    Friend WithEvents VehicleTableAdapter As VehicleRentDataSet1TableAdapters.vehicleTableAdapter
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents VehicleIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VehicleTypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ModelYearDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VehicleBrandDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VehicleModelDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ColorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CapacityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EngineDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LicensenumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RatePerDayDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VehicleBindingSource As BindingSource
End Class
