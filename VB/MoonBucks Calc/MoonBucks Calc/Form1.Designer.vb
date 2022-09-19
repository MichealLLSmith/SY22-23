<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.AdressTextBox = New System.Windows.Forms.TextBox()
        Me.CityTextBox = New System.Windows.Forms.TextBox()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.AdressLabel = New System.Windows.Forms.Label()
        Me.CityLabel = New System.Windows.Forms.Label()
        Me.StateLabel = New System.Windows.Forms.Label()
        Me.ZipLabel = New System.Windows.Forms.Label()
        Me.RegLabel = New System.Windows.Forms.Label()
        Me.DecafeLabel = New System.Windows.Forms.Label()
        Me.StateTextBox = New System.Windows.Forms.TextBox()
        Me.ZipTextBox = New System.Windows.Forms.TextBox()
        Me.RegularTextBox = New System.Windows.Forms.TextBox()
        Me.DecTextBox = New System.Windows.Forms.TextBox()
        Me.OrderButton = New System.Windows.Forms.Button()
        Me.PrintButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PoundsTextBox = New System.Windows.Forms.TextBox()
        Me.TotTextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(237, 27)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(263, 61)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = "Order form"
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(40, 127)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(404, 22)
        Me.NameTextBox.TabIndex = 1
        '
        'AdressTextBox
        '
        Me.AdressTextBox.Location = New System.Drawing.Point(40, 196)
        Me.AdressTextBox.Name = "AdressTextBox"
        Me.AdressTextBox.Size = New System.Drawing.Size(404, 22)
        Me.AdressTextBox.TabIndex = 2
        '
        'CityTextBox
        '
        Me.CityTextBox.Location = New System.Drawing.Point(40, 265)
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.Size = New System.Drawing.Size(404, 22)
        Me.CityTextBox.TabIndex = 3
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameLabel.Location = New System.Drawing.Point(36, 104)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(53, 20)
        Me.NameLabel.TabIndex = 4
        Me.NameLabel.Text = "Name"
        '
        'AdressLabel
        '
        Me.AdressLabel.AutoSize = True
        Me.AdressLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdressLabel.Location = New System.Drawing.Point(36, 173)
        Me.AdressLabel.Name = "AdressLabel"
        Me.AdressLabel.Size = New System.Drawing.Size(62, 20)
        Me.AdressLabel.TabIndex = 5
        Me.AdressLabel.Text = "Adress"
        '
        'CityLabel
        '
        Me.CityLabel.AutoSize = True
        Me.CityLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CityLabel.Location = New System.Drawing.Point(36, 242)
        Me.CityLabel.Name = "CityLabel"
        Me.CityLabel.Size = New System.Drawing.Size(38, 20)
        Me.CityLabel.TabIndex = 6
        Me.CityLabel.Text = "City"
        '
        'StateLabel
        '
        Me.StateLabel.AutoSize = True
        Me.StateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StateLabel.Location = New System.Drawing.Point(36, 341)
        Me.StateLabel.Name = "StateLabel"
        Me.StateLabel.Size = New System.Drawing.Size(48, 20)
        Me.StateLabel.TabIndex = 7
        Me.StateLabel.Text = "State"
        '
        'ZipLabel
        '
        Me.ZipLabel.AutoSize = True
        Me.ZipLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ZipLabel.Location = New System.Drawing.Point(100, 341)
        Me.ZipLabel.Name = "ZipLabel"
        Me.ZipLabel.Size = New System.Drawing.Size(31, 20)
        Me.ZipLabel.TabIndex = 8
        Me.ZipLabel.Text = "Zip"
        '
        'RegLabel
        '
        Me.RegLabel.AutoSize = True
        Me.RegLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RegLabel.Location = New System.Drawing.Point(252, 341)
        Me.RegLabel.Name = "RegLabel"
        Me.RegLabel.Size = New System.Drawing.Size(67, 20)
        Me.RegLabel.TabIndex = 9
        Me.RegLabel.Text = "Regular"
        '
        'DecafeLabel
        '
        Me.DecafeLabel.AutoSize = True
        Me.DecafeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DecafeLabel.Location = New System.Drawing.Point(360, 341)
        Me.DecafeLabel.Name = "DecafeLabel"
        Me.DecafeLabel.Size = New System.Drawing.Size(63, 20)
        Me.DecafeLabel.TabIndex = 10
        Me.DecafeLabel.Text = "Decafe"
        '
        'StateTextBox
        '
        Me.StateTextBox.Location = New System.Drawing.Point(40, 364)
        Me.StateTextBox.Name = "StateTextBox"
        Me.StateTextBox.Size = New System.Drawing.Size(58, 22)
        Me.StateTextBox.TabIndex = 11
        '
        'ZipTextBox
        '
        Me.ZipTextBox.Location = New System.Drawing.Point(104, 364)
        Me.ZipTextBox.Name = "ZipTextBox"
        Me.ZipTextBox.Size = New System.Drawing.Size(100, 22)
        Me.ZipTextBox.TabIndex = 12
        '
        'RegularTextBox
        '
        Me.RegularTextBox.Location = New System.Drawing.Point(256, 364)
        Me.RegularTextBox.Name = "RegularTextBox"
        Me.RegularTextBox.Size = New System.Drawing.Size(63, 22)
        Me.RegularTextBox.TabIndex = 13
        '
        'DecTextBox
        '
        Me.DecTextBox.Location = New System.Drawing.Point(364, 364)
        Me.DecTextBox.Name = "DecTextBox"
        Me.DecTextBox.Size = New System.Drawing.Size(80, 22)
        Me.DecTextBox.TabIndex = 14
        '
        'OrderButton
        '
        Me.OrderButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrderButton.Location = New System.Drawing.Point(577, 232)
        Me.OrderButton.Name = "OrderButton"
        Me.OrderButton.Size = New System.Drawing.Size(176, 41)
        Me.OrderButton.TabIndex = 15
        Me.OrderButton.Text = "Calculate Order"
        Me.OrderButton.UseVisualStyleBackColor = True
        '
        'PrintButton
        '
        Me.PrintButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrintButton.Location = New System.Drawing.Point(577, 279)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(176, 41)
        Me.PrintButton.TabIndex = 16
        Me.PrintButton.Text = "Print Order"
        Me.PrintButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearButton.Location = New System.Drawing.Point(577, 326)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(176, 41)
        Me.ClearButton.TabIndex = 17
        Me.ClearButton.Text = "Clear Order"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitButton.Location = New System.Drawing.Point(577, 373)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(176, 41)
        Me.ExitButton.TabIndex = 18
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(573, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 20)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Pounds Ordered:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(573, 144)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 20)
        Me.Label2.TabIndex = 20
        Me.Label2.Tag = ""
        Me.Label2.Text = "Total Price:"
        '
        'PoundsTextBox
        '
        Me.PoundsTextBox.Location = New System.Drawing.Point(577, 91)
        Me.PoundsTextBox.Name = "PoundsTextBox"
        Me.PoundsTextBox.Size = New System.Drawing.Size(127, 22)
        Me.PoundsTextBox.TabIndex = 21
        '
        'TotTextBox
        '
        Me.TotTextBox.Location = New System.Drawing.Point(577, 167)
        Me.TotTextBox.Name = "TotTextBox"
        Me.TotTextBox.Size = New System.Drawing.Size(128, 22)
        Me.TotTextBox.TabIndex = 22
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TotTextBox)
        Me.Controls.Add(Me.PoundsTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.PrintButton)
        Me.Controls.Add(Me.OrderButton)
        Me.Controls.Add(Me.DecTextBox)
        Me.Controls.Add(Me.RegularTextBox)
        Me.Controls.Add(Me.ZipTextBox)
        Me.Controls.Add(Me.StateTextBox)
        Me.Controls.Add(Me.DecafeLabel)
        Me.Controls.Add(Me.RegLabel)
        Me.Controls.Add(Me.ZipLabel)
        Me.Controls.Add(Me.StateLabel)
        Me.Controls.Add(Me.CityLabel)
        Me.Controls.Add(Me.AdressLabel)
        Me.Controls.Add(Me.NameLabel)
        Me.Controls.Add(Me.CityTextBox)
        Me.Controls.Add(Me.AdressTextBox)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "Form1"
        Me.Text = "Moonbucks coffee"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents AdressTextBox As TextBox
    Friend WithEvents CityTextBox As TextBox
    Friend WithEvents NameLabel As Label
    Friend WithEvents AdressLabel As Label
    Friend WithEvents CityLabel As Label
    Friend WithEvents StateLabel As Label
    Friend WithEvents ZipLabel As Label
    Friend WithEvents RegLabel As Label
    Friend WithEvents DecafeLabel As Label
    Friend WithEvents StateTextBox As TextBox
    Friend WithEvents ZipTextBox As TextBox
    Friend WithEvents RegularTextBox As TextBox
    Friend WithEvents DecTextBox As TextBox
    Friend WithEvents OrderButton As Button
    Friend WithEvents PrintButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PoundsTextBox As TextBox
    Friend WithEvents TotTextBox As TextBox
End Class
