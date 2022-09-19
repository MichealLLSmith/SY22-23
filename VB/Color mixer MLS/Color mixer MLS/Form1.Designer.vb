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
        Me.components = New System.ComponentModel.Container()
        Me.VeiwButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.RedLabel = New System.Windows.Forms.Label()
        Me.GreenLabel = New System.Windows.Forms.Label()
        Me.BlueLabel = New System.Windows.Forms.Label()
        Me.BlueTextBox = New System.Windows.Forms.TextBox()
        Me.RedTextBox = New System.Windows.Forms.TextBox()
        Me.GreenTextBox = New System.Windows.Forms.TextBox()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ColorLabel = New System.Windows.Forms.Label()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'VeiwButton
        '
        Me.VeiwButton.Location = New System.Drawing.Point(45, 271)
        Me.VeiwButton.Name = "VeiwButton"
        Me.VeiwButton.Size = New System.Drawing.Size(117, 45)
        Me.VeiwButton.TabIndex = 0
        Me.VeiwButton.Text = "View Color"
        Me.VeiwButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(224, 271)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(116, 45)
        Me.ExitButton.TabIndex = 1
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'RedLabel
        '
        Me.RedLabel.AutoSize = True
        Me.RedLabel.Location = New System.Drawing.Point(72, 69)
        Me.RedLabel.Name = "RedLabel"
        Me.RedLabel.Size = New System.Drawing.Size(89, 16)
        Me.RedLabel.TabIndex = 2
        Me.RedLabel.Text = "Red (0 to 255)"
        '
        'GreenLabel
        '
        Me.GreenLabel.AutoSize = True
        Me.GreenLabel.Location = New System.Drawing.Point(72, 190)
        Me.GreenLabel.Name = "GreenLabel"
        Me.GreenLabel.Size = New System.Drawing.Size(100, 16)
        Me.GreenLabel.TabIndex = 3
        Me.GreenLabel.Text = "Green (0 to 255)"
        '
        'BlueLabel
        '
        Me.BlueLabel.AutoSize = True
        Me.BlueLabel.Location = New System.Drawing.Point(72, 132)
        Me.BlueLabel.Name = "BlueLabel"
        Me.BlueLabel.Size = New System.Drawing.Size(90, 16)
        Me.BlueLabel.TabIndex = 4
        Me.BlueLabel.Text = "Blue (0 to 255)"
        '
        'BlueTextBox
        '
        Me.BlueTextBox.Location = New System.Drawing.Point(201, 126)
        Me.BlueTextBox.Name = "BlueTextBox"
        Me.BlueTextBox.Size = New System.Drawing.Size(100, 22)
        Me.BlueTextBox.TabIndex = 5
        '
        'RedTextBox
        '
        Me.RedTextBox.Location = New System.Drawing.Point(201, 66)
        Me.RedTextBox.Name = "RedTextBox"
        Me.RedTextBox.Size = New System.Drawing.Size(100, 22)
        Me.RedTextBox.TabIndex = 6
        '
        'GreenTextBox
        '
        Me.GreenTextBox.Location = New System.Drawing.Point(201, 184)
        Me.GreenTextBox.Name = "GreenTextBox"
        Me.GreenTextBox.Size = New System.Drawing.Size(100, 22)
        Me.GreenTextBox.TabIndex = 7
        '
        'ColorLabel
        '
        Me.ColorLabel.AutoSize = True
        Me.ColorLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorLabel.Location = New System.Drawing.Point(443, 149)
        Me.ColorLabel.Name = "ColorLabel"
        Me.ColorLabel.Size = New System.Drawing.Size(196, 42)
        Me.ColorLabel.TabIndex = 8
        Me.ColorLabel.Text = "Your Color"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ColorLabel)
        Me.Controls.Add(Me.GreenTextBox)
        Me.Controls.Add(Me.RedTextBox)
        Me.Controls.Add(Me.BlueTextBox)
        Me.Controls.Add(Me.BlueLabel)
        Me.Controls.Add(Me.GreenLabel)
        Me.Controls.Add(Me.RedLabel)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.VeiwButton)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents VeiwButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents RedLabel As Label
    Friend WithEvents GreenLabel As Label
    Friend WithEvents BlueLabel As Label
    Friend WithEvents BlueTextBox As TextBox
    Friend WithEvents RedTextBox As TextBox
    Friend WithEvents GreenTextBox As TextBox
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents ColorLabel As Label
End Class
