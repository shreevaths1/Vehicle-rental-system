<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Vehicle_Entry
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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Fuel_Type = New System.Windows.Forms.ComboBox()
        Me.Vehicle_Type = New System.Windows.Forms.ComboBox()
        Me.Model = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Model_Year = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Rate = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Status = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Capacity = New System.Windows.Forms.TextBox()
        Me.Color = New System.Windows.Forms.TextBox()
        Me.Brand = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.License_No = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(301, 523)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(128, 39)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Back"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(131, 523)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(128, 39)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(131, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(233, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter Vehicles "
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(660, 581)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(128, 39)
        Me.Button4.TabIndex = 34
        Me.Button4.Text = "Submit"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(660, 617)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(128, 39)
        Me.Button5.TabIndex = 37
        Me.Button5.Text = "Submit"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Fuel_Type
        '
        Me.Fuel_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Fuel_Type.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fuel_Type.FormattingEnabled = True
        Me.Fuel_Type.Items.AddRange(New Object() {"Petrol", "Diesel"})
        Me.Fuel_Type.Location = New System.Drawing.Point(225, 343)
        Me.Fuel_Type.Name = "Fuel_Type"
        Me.Fuel_Type.Size = New System.Drawing.Size(265, 32)
        Me.Fuel_Type.TabIndex = 7
        '
        'Vehicle_Type
        '
        Me.Vehicle_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Vehicle_Type.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Vehicle_Type.FormattingEnabled = True
        Me.Vehicle_Type.Items.AddRange(New Object() {"Car", "Bike"})
        Me.Vehicle_Type.Location = New System.Drawing.Point(226, 106)
        Me.Vehicle_Type.Name = "Vehicle_Type"
        Me.Vehicle_Type.Size = New System.Drawing.Size(265, 32)
        Me.Vehicle_Type.TabIndex = 2
        '
        'Model
        '
        Me.Model.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Model.Location = New System.Drawing.Point(226, 156)
        Me.Model.Name = "Model"
        Me.Model.Size = New System.Drawing.Size(266, 31)
        Me.Model.TabIndex = 3
        Me.Model.UseWaitCursor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(35, 153)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(87, 31)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Model"
        '
        'Model_Year
        '
        Me.Model_Year.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Model_Year.Location = New System.Drawing.Point(225, 193)
        Me.Model_Year.Name = "Model_Year"
        Me.Model_Year.Size = New System.Drawing.Size(266, 31)
        Me.Model_Year.TabIndex = 4
        Me.Model_Year.UseWaitCursor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(34, 190)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(159, 31)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Model_Year"
        '
        'Rate
        '
        Me.Rate.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rate.Location = New System.Drawing.Point(226, 420)
        Me.Rate.Name = "Rate"
        Me.Rate.Size = New System.Drawing.Size(266, 31)
        Me.Rate.TabIndex = 8
        Me.Rate.UseWaitCursor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(34, 420)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 31)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Rate"
        '
        'Status
        '
        Me.Status.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Status.Location = New System.Drawing.Point(225, 383)
        Me.Status.Name = "Status"
        Me.Status.ReadOnly = True
        Me.Status.Size = New System.Drawing.Size(266, 31)
        Me.Status.TabIndex = 0
        Me.Status.UseWaitCursor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(34, 379)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(92, 31)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Status"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(34, 343)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(135, 31)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Fuel Type"
        '
        'Capacity
        '
        Me.Capacity.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Capacity.Location = New System.Drawing.Point(226, 294)
        Me.Capacity.MaxLength = 10
        Me.Capacity.Name = "Capacity"
        Me.Capacity.Size = New System.Drawing.Size(266, 31)
        Me.Capacity.TabIndex = 6
        Me.Capacity.UseWaitCursor = True
        '
        'Color
        '
        Me.Color.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Color.Location = New System.Drawing.Point(226, 241)
        Me.Color.Name = "Color"
        Me.Color.Size = New System.Drawing.Size(266, 31)
        Me.Color.TabIndex = 5
        Me.Color.UseWaitCursor = True
        '
        'Brand
        '
        Me.Brand.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Brand.Location = New System.Drawing.Point(226, 62)
        Me.Brand.Name = "Brand"
        Me.Brand.Size = New System.Drawing.Size(266, 31)
        Me.Brand.TabIndex = 1
        Me.Brand.UseWaitCursor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(35, 294)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(121, 31)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Capacity"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(35, 241)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 31)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Color"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(35, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 31)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Brand"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(35, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(171, 31)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Vehicle Type"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = Global.Vehicle_Rental_System.My.Resources.Resources.R
        Me.PictureBox1.Location = New System.Drawing.Point(531, 156)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(253, 209)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 86
        Me.PictureBox1.TabStop = False
        '
        'License_No
        '
        Me.License_No.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.License_No.Location = New System.Drawing.Point(226, 472)
        Me.License_No.Name = "License_No"
        Me.License_No.Size = New System.Drawing.Size(266, 31)
        Me.License_No.TabIndex = 9
        Me.License_No.UseWaitCursor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(35, 472)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(158, 31)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "License No."
        '
        'Vehicle_Entry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(850, 574)
        Me.Controls.Add(Me.License_No)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Fuel_Type)
        Me.Controls.Add(Me.Vehicle_Type)
        Me.Controls.Add(Me.Model)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Model_Year)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Rate)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Status)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Capacity)
        Me.Controls.Add(Me.Color)
        Me.Controls.Add(Me.Brand)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Vehicle_Entry"
        Me.Text = "Vehicle Entry"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Fuel_Type As ComboBox
    Friend WithEvents Vehicle_Type As ComboBox
    Friend WithEvents Model As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Model_Year As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Rate As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Status As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Capacity As TextBox
    Friend WithEvents Color As TextBox
    Friend WithEvents Brand As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents License_No As TextBox
    Friend WithEvents Label6 As Label
End Class
