<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Payment
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
        Me.bookingBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.userBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.paymentDateBox = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cardTypeBox = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cardNumberBox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cardHolderNameBox = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cvvBox = New System.Windows.Forms.TextBox()
        Me.submitButton = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cardExpiryBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(279, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Payment"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(84, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(182, 24)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Booking reference"
        '
        'bookingBox
        '
        Me.bookingBox.Location = New System.Drawing.Point(400, 88)
        Me.bookingBox.Name = "bookingBox"
        Me.bookingBox.ReadOnly = True
        Me.bookingBox.Size = New System.Drawing.Size(152, 20)
        Me.bookingBox.TabIndex = 0
        Me.bookingBox.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(84, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 24)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Username"
        '
        'userBox
        '
        Me.userBox.Location = New System.Drawing.Point(398, 136)
        Me.userBox.Name = "userBox"
        Me.userBox.ReadOnly = True
        Me.userBox.Size = New System.Drawing.Size(153, 20)
        Me.userBox.TabIndex = 0
        Me.userBox.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(84, 188)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(138, 24)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Payment Date"
        '
        'paymentDateBox
        '
        Me.paymentDateBox.Enabled = False
        Me.paymentDateBox.Location = New System.Drawing.Point(398, 192)
        Me.paymentDateBox.Name = "paymentDateBox"
        Me.paymentDateBox.Size = New System.Drawing.Size(200, 20)
        Me.paymentDateBox.TabIndex = 0
        Me.paymentDateBox.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(82, 239)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(107, 24)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Card Type"
        '
        'cardTypeBox
        '
        Me.cardTypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cardTypeBox.FormattingEnabled = True
        Me.cardTypeBox.Items.AddRange(New Object() {"Debit", "Credit"})
        Me.cardTypeBox.Location = New System.Drawing.Point(399, 239)
        Me.cardTypeBox.Name = "cardTypeBox"
        Me.cardTypeBox.Size = New System.Drawing.Size(121, 21)
        Me.cardTypeBox.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(82, 291)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(135, 24)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Card Number"
        '
        'cardNumberBox
        '
        Me.cardNumberBox.Location = New System.Drawing.Point(399, 291)
        Me.cardNumberBox.Name = "cardNumberBox"
        Me.cardNumberBox.Size = New System.Drawing.Size(214, 20)
        Me.cardNumberBox.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(82, 343)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(169, 24)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Name as on card"
        '
        'cardHolderNameBox
        '
        Me.cardHolderNameBox.Location = New System.Drawing.Point(398, 347)
        Me.cardHolderNameBox.Name = "cardHolderNameBox"
        Me.cardHolderNameBox.Size = New System.Drawing.Size(214, 20)
        Me.cardHolderNameBox.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(82, 396)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(231, 24)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Card Expiry (MM/YYYY)"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(576, 392)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 24)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "CVV"
        '
        'cvvBox
        '
        Me.cvvBox.Location = New System.Drawing.Point(660, 396)
        Me.cvvBox.Name = "cvvBox"
        Me.cvvBox.Size = New System.Drawing.Size(68, 20)
        Me.cvvBox.TabIndex = 5
        '
        'submitButton
        '
        Me.submitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.submitButton.Location = New System.Drawing.Point(420, 474)
        Me.submitButton.Name = "submitButton"
        Me.submitButton.Size = New System.Drawing.Size(130, 40)
        Me.submitButton.TabIndex = 6
        Me.submitButton.Text = "Submit"
        Me.submitButton.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(164, 474)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(210, 40)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Cancel Payment"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cardExpiryBox
        '
        Me.cardExpiryBox.Location = New System.Drawing.Point(399, 396)
        Me.cardExpiryBox.Name = "cardExpiryBox"
        Me.cardExpiryBox.Size = New System.Drawing.Size(99, 20)
        Me.cardExpiryBox.TabIndex = 8
        '
        'Payment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(765, 526)
        Me.Controls.Add(Me.cardExpiryBox)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.submitButton)
        Me.Controls.Add(Me.cvvBox)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cardHolderNameBox)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cardNumberBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cardTypeBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.paymentDateBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.userBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.bookingBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Payment"
        Me.Text = "Payment"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents bookingBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents userBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents paymentDateBox As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents cardTypeBox As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cardNumberBox As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cardHolderNameBox As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents cvvBox As TextBox
    Friend WithEvents submitButton As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents cardExpiryBox As TextBox
End Class
