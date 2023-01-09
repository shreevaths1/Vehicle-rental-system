<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Location = New System.Drawing.Point(325, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(175, 37)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Dashboard"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(60, 72)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(225, 109)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Add/Manage  Users"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(291, 72)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(226, 109)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Add/Manage Vehicles"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(523, 72)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(225, 109)
        Me.Button3.TabIndex = 14
        Me.Button3.Text = "View Vehicle Bookings"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(59, 187)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(226, 109)
        Me.Button4.TabIndex = 15
        Me.Button4.Text = " View Transactions"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(291, 187)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(225, 109)
        Me.Button7.TabIndex = 17
        Me.Button7.Text = "View Reports"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(522, 187)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(225, 109)
        Me.Button5.TabIndex = 16
        Me.Button5.Text = "View Feedbacks"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(643, 323)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(128, 39)
        Me.Button6.TabIndex = 14
        Me.Button6.Text = "Log Out"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Vehicle_Rental_System.My.Resources.Resources._1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 396)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button5)
        Me.Name = "Admin"
        Me.Text = "Admin Page"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
End Class
