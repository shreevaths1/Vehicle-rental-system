<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class User
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(User))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Location = New System.Drawing.Point(302, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(175, 37)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Dashboard"
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(561, 251)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(128, 39)
        Me.Button6.TabIndex = 17
        Me.Button6.Text = "Log Out"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(483, 102)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(225, 109)
        Me.Button5.TabIndex = 16
        Me.Button5.Text = "Give Feedback"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(241, 102)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(236, 109)
        Me.Button7.TabIndex = 17
        Me.Button7.Text = "Transaction History"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(10, 102)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(225, 109)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "View Vehicles"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'User
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(719, 324)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button6)
        Me.Name = "User"
        Me.Text = "UserPage"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button1 As Button
End Class
