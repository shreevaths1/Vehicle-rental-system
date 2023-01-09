<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Booking
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.userBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.vehicleBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.fromDateField = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.toDateField = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.costBox = New System.Windows.Forms.TextBox()
        Me.rateLabel = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.durationBox = New System.Windows.Forms.NumericUpDown()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.durationBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(253, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Booking"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(54, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 24)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "User"
        '
        'userBox
        '
        Me.userBox.Location = New System.Drawing.Point(371, 78)
        Me.userBox.Name = "userBox"
        Me.userBox.ReadOnly = True
        Me.userBox.Size = New System.Drawing.Size(215, 20)
        Me.userBox.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(54, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 24)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Vehicle"
        '
        'vehicleBox
        '
        Me.vehicleBox.Location = New System.Drawing.Point(371, 126)
        Me.vehicleBox.Name = "vehicleBox"
        Me.vehicleBox.ReadOnly = True
        Me.vehicleBox.Size = New System.Drawing.Size(298, 20)
        Me.vehicleBox.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(54, 174)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 24)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "From Date"
        '
        'fromDateField
        '
        Me.fromDateField.Location = New System.Drawing.Point(371, 178)
        Me.fromDateField.MinDate = New Date(2022, 5, 18, 0, 0, 0, 0)
        Me.fromDateField.Name = "fromDateField"
        Me.fromDateField.Size = New System.Drawing.Size(199, 20)
        Me.fromDateField.TabIndex = 1
        Me.fromDateField.Value = New Date(2022, 5, 18, 0, 0, 0, 0)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(54, 272)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 24)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Return Date"
        '
        'toDateField
        '
        Me.toDateField.Enabled = False
        Me.toDateField.Location = New System.Drawing.Point(370, 274)
        Me.toDateField.MinDate = New Date(2022, 5, 18, 0, 0, 0, 0)
        Me.toDateField.Name = "toDateField"
        Me.toDateField.Size = New System.Drawing.Size(200, 20)
        Me.toDateField.TabIndex = 3
        Me.toDateField.Value = New Date(2022, 5, 18, 0, 0, 0, 0)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(54, 227)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 24)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Duration"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(54, 327)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 24)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Cost"
        '
        'costBox
        '
        Me.costBox.Location = New System.Drawing.Point(370, 323)
        Me.costBox.Name = "costBox"
        Me.costBox.ReadOnly = True
        Me.costBox.Size = New System.Drawing.Size(118, 20)
        Me.costBox.TabIndex = 0
        '
        'rateLabel
        '
        Me.rateLabel.AutoSize = True
        Me.rateLabel.Location = New System.Drawing.Point(526, 327)
        Me.rateLabel.Name = "rateLabel"
        Me.rateLabel.Size = New System.Drawing.Size(39, 13)
        Me.rateLabel.TabIndex = 0
        Me.rateLabel.Text = "Label8"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(337, 392)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(130, 35)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Book and Pay"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'durationBox
        '
        Me.durationBox.Location = New System.Drawing.Point(374, 228)
        Me.durationBox.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.durationBox.Name = "durationBox"
        Me.durationBox.Size = New System.Drawing.Size(70, 20)
        Me.durationBox.TabIndex = 2
        Me.durationBox.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(149, 392)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(130, 35)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Back"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Booking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(693, 450)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.durationBox)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.rateLabel)
        Me.Controls.Add(Me.costBox)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.toDateField)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.fromDateField)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.vehicleBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.userBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Booking"
        Me.Text = " "
        CType(Me.durationBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents userBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents vehicleBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents fromDateField As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents toDateField As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents costBox As TextBox
    Friend WithEvents rateLabel As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents durationBox As NumericUpDown
    Friend WithEvents Button2 As Button
End Class
