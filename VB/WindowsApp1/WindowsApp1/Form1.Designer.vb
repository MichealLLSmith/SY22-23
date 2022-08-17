<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PandaForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PandaForm))
        Me.PandaButton = New System.Windows.Forms.Button()
        Me.displayPictureBox = New System.Windows.Forms.PictureBox()
        Me.PandaPictureBox = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.FurColorLabel = New System.Windows.Forms.Label()
        Me.SpeciesLabel = New System.Windows.Forms.Label()
        Me.DogPictureBox = New System.Windows.Forms.PictureBox()
        Me.DogButton = New System.Windows.Forms.Button()
        Me.BearPictureBox = New System.Windows.Forms.PictureBox()
        Me.BearButton = New System.Windows.Forms.Button()
        Me.LionPictureBox = New System.Windows.Forms.PictureBox()
        Me.LionButton = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.FootTypeLabel = New System.Windows.Forms.Label()
        Me.HuntingSkillsLabel = New System.Windows.Forms.Label()
        Me.CrocodilePictureBox = New System.Windows.Forms.PictureBox()
        Me.CrocodileButton = New System.Windows.Forms.Button()
        CType(Me.displayPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PandaPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DogPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BearPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LionPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CrocodilePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PandaButton
        '
        Me.PandaButton.Location = New System.Drawing.Point(12, 365)
        Me.PandaButton.Name = "PandaButton"
        Me.PandaButton.Size = New System.Drawing.Size(75, 23)
        Me.PandaButton.TabIndex = 0
        Me.PandaButton.Text = "Panda"
        Me.PandaButton.UseVisualStyleBackColor = True
        '
        'displayPictureBox
        '
        Me.displayPictureBox.Location = New System.Drawing.Point(-6, -2)
        Me.displayPictureBox.Name = "displayPictureBox"
        Me.displayPictureBox.Size = New System.Drawing.Size(340, 277)
        Me.displayPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.displayPictureBox.TabIndex = 1
        Me.displayPictureBox.TabStop = False
        '
        'PandaPictureBox
        '
        Me.PandaPictureBox.Image = CType(resources.GetObject("PandaPictureBox.Image"), System.Drawing.Image)
        Me.PandaPictureBox.Location = New System.Drawing.Point(10, 394)
        Me.PandaPictureBox.Name = "PandaPictureBox"
        Me.PandaPictureBox.Size = New System.Drawing.Size(102, 56)
        Me.PandaPictureBox.TabIndex = 2
        Me.PandaPictureBox.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(347, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(347, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Fur Color:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(347, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Species:"
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Location = New System.Drawing.Point(434, 12)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(0, 16)
        Me.NameLabel.TabIndex = 6
        '
        'FurColorLabel
        '
        Me.FurColorLabel.AutoSize = True
        Me.FurColorLabel.Location = New System.Drawing.Point(434, 42)
        Me.FurColorLabel.Name = "FurColorLabel"
        Me.FurColorLabel.Size = New System.Drawing.Size(0, 16)
        Me.FurColorLabel.TabIndex = 7
        '
        'SpeciesLabel
        '
        Me.SpeciesLabel.AutoSize = True
        Me.SpeciesLabel.Location = New System.Drawing.Point(434, 73)
        Me.SpeciesLabel.Name = "SpeciesLabel"
        Me.SpeciesLabel.Size = New System.Drawing.Size(0, 16)
        Me.SpeciesLabel.TabIndex = 8
        '
        'DogPictureBox
        '
        Me.DogPictureBox.Image = CType(resources.GetObject("DogPictureBox.Image"), System.Drawing.Image)
        Me.DogPictureBox.Location = New System.Drawing.Point(132, 394)
        Me.DogPictureBox.Name = "DogPictureBox"
        Me.DogPictureBox.Size = New System.Drawing.Size(102, 56)
        Me.DogPictureBox.TabIndex = 10
        Me.DogPictureBox.TabStop = False
        '
        'DogButton
        '
        Me.DogButton.Location = New System.Drawing.Point(134, 365)
        Me.DogButton.Name = "DogButton"
        Me.DogButton.Size = New System.Drawing.Size(75, 23)
        Me.DogButton.TabIndex = 9
        Me.DogButton.Text = "Dog"
        Me.DogButton.UseVisualStyleBackColor = True
        '
        'BearPictureBox
        '
        Me.BearPictureBox.Image = CType(resources.GetObject("BearPictureBox.Image"), System.Drawing.Image)
        Me.BearPictureBox.Location = New System.Drawing.Point(259, 394)
        Me.BearPictureBox.Name = "BearPictureBox"
        Me.BearPictureBox.Size = New System.Drawing.Size(102, 56)
        Me.BearPictureBox.TabIndex = 12
        Me.BearPictureBox.TabStop = False
        '
        'BearButton
        '
        Me.BearButton.Location = New System.Drawing.Point(259, 365)
        Me.BearButton.Name = "BearButton"
        Me.BearButton.Size = New System.Drawing.Size(75, 23)
        Me.BearButton.TabIndex = 11
        Me.BearButton.Text = "Bear"
        Me.BearButton.UseVisualStyleBackColor = True
        '
        'LionPictureBox
        '
        Me.LionPictureBox.Image = CType(resources.GetObject("LionPictureBox.Image"), System.Drawing.Image)
        Me.LionPictureBox.Location = New System.Drawing.Point(378, 394)
        Me.LionPictureBox.Name = "LionPictureBox"
        Me.LionPictureBox.Size = New System.Drawing.Size(102, 56)
        Me.LionPictureBox.TabIndex = 14
        Me.LionPictureBox.TabStop = False
        '
        'LionButton
        '
        Me.LionButton.Location = New System.Drawing.Point(380, 365)
        Me.LionButton.Name = "LionButton"
        Me.LionButton.Size = New System.Drawing.Size(75, 23)
        Me.LionButton.TabIndex = 13
        Me.LionButton.Text = "Lion"
        Me.LionButton.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(348, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 16)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Foot type"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(348, 135)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 16)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Hunting Skills"
        '
        'FootTypeLabel
        '
        Me.FootTypeLabel.AutoSize = True
        Me.FootTypeLabel.Location = New System.Drawing.Point(431, 104)
        Me.FootTypeLabel.Name = "FootTypeLabel"
        Me.FootTypeLabel.Size = New System.Drawing.Size(0, 16)
        Me.FootTypeLabel.TabIndex = 17
        '
        'HuntingSkillsLabel
        '
        Me.HuntingSkillsLabel.AutoSize = True
        Me.HuntingSkillsLabel.Location = New System.Drawing.Point(442, 134)
        Me.HuntingSkillsLabel.Name = "HuntingSkillsLabel"
        Me.HuntingSkillsLabel.Size = New System.Drawing.Size(0, 16)
        Me.HuntingSkillsLabel.TabIndex = 18
        '
        'CrocodilePictureBox
        '
        Me.CrocodilePictureBox.Image = CType(resources.GetObject("CrocodilePictureBox.Image"), System.Drawing.Image)
        Me.CrocodilePictureBox.Location = New System.Drawing.Point(504, 394)
        Me.CrocodilePictureBox.Name = "CrocodilePictureBox"
        Me.CrocodilePictureBox.Size = New System.Drawing.Size(102, 56)
        Me.CrocodilePictureBox.TabIndex = 20
        Me.CrocodilePictureBox.TabStop = False
        '
        'CrocodileButton
        '
        Me.CrocodileButton.Location = New System.Drawing.Point(506, 365)
        Me.CrocodileButton.Name = "CrocodileButton"
        Me.CrocodileButton.Size = New System.Drawing.Size(75, 23)
        Me.CrocodileButton.TabIndex = 19
        Me.CrocodileButton.Text = "Crocodile"
        Me.CrocodileButton.UseVisualStyleBackColor = True
        '
        'PandaForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Cornsilk
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.CrocodilePictureBox)
        Me.Controls.Add(Me.CrocodileButton)
        Me.Controls.Add(Me.HuntingSkillsLabel)
        Me.Controls.Add(Me.FootTypeLabel)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.LionPictureBox)
        Me.Controls.Add(Me.LionButton)
        Me.Controls.Add(Me.BearPictureBox)
        Me.Controls.Add(Me.BearButton)
        Me.Controls.Add(Me.DogPictureBox)
        Me.Controls.Add(Me.DogButton)
        Me.Controls.Add(Me.SpeciesLabel)
        Me.Controls.Add(Me.FurColorLabel)
        Me.Controls.Add(Me.NameLabel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PandaPictureBox)
        Me.Controls.Add(Me.displayPictureBox)
        Me.Controls.Add(Me.PandaButton)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "PandaForm"
        Me.Text = "Animal Dex"
        CType(Me.displayPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PandaPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DogPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BearPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LionPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CrocodilePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PandaButton As Button
    Friend WithEvents displayPictureBox As PictureBox
    Friend WithEvents PandaPictureBox As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents NameLabel As Label
    Friend WithEvents FurColorLabel As Label
    Friend WithEvents SpeciesLabel As Label
    Friend WithEvents DogPictureBox As PictureBox
    Friend WithEvents DogButton As Button
    Friend WithEvents BearPictureBox As PictureBox
    Friend WithEvents BearButton As Button
    Friend WithEvents LionPictureBox As PictureBox
    Friend WithEvents LionButton As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents FootTypeLabel As Label
    Friend WithEvents HuntingSkillsLabel As Label
    Friend WithEvents CrocodilePictureBox As PictureBox
    Friend WithEvents CrocodileButton As Button
End Class
