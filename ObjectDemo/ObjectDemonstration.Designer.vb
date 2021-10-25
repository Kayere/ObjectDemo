<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ObjectDemonstration
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
        Me.DisplayGroupBox = New System.Windows.Forms.GroupBox()
        Me.DisplayTextBox = New System.Windows.Forms.TextBox()
        Me.FontGroup = New System.Windows.Forms.GroupBox()
        Me.TahomaRadioButton = New System.Windows.Forms.RadioButton()
        Me.MagnetoRadioButton = New System.Windows.Forms.RadioButton()
        Me.GaramondRadioButton = New System.Windows.Forms.RadioButton()
        Me.FontColorGroupBox = New System.Windows.Forms.GroupBox()
        Me.RedRadioButton = New System.Windows.Forms.RadioButton()
        Me.BlueRadioButton = New System.Windows.Forms.RadioButton()
        Me.GreenRadioButton = New System.Windows.Forms.RadioButton()
        Me.FontStyleGroupBox = New System.Windows.Forms.GroupBox()
        Me.BoldItalicCheckBox = New System.Windows.Forms.CheckBox()
        Me.BoldCheckBox = New System.Windows.Forms.CheckBox()
        Me.ItalicCheckBox = New System.Windows.Forms.CheckBox()
        Me.PictureBox = New System.Windows.Forms.PictureBox()
        Me.LoadPictureButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.DisplayGroupBox.SuspendLayout()
        Me.FontGroup.SuspendLayout()
        Me.FontColorGroupBox.SuspendLayout()
        Me.FontStyleGroupBox.SuspendLayout()
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DisplayGroupBox
        '
        Me.DisplayGroupBox.Controls.Add(Me.DisplayTextBox)
        Me.DisplayGroupBox.Font = New System.Drawing.Font("Sitka Banner", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DisplayGroupBox.Location = New System.Drawing.Point(21, 31)
        Me.DisplayGroupBox.Name = "DisplayGroupBox"
        Me.DisplayGroupBox.Size = New System.Drawing.Size(285, 84)
        Me.DisplayGroupBox.TabIndex = 0
        Me.DisplayGroupBox.TabStop = False
        Me.DisplayGroupBox.Text = "Display Text"
        '
        'DisplayTextBox
        '
        Me.DisplayTextBox.Location = New System.Drawing.Point(21, 36)
        Me.DisplayTextBox.Name = "DisplayTextBox"
        Me.DisplayTextBox.Size = New System.Drawing.Size(243, 30)
        Me.DisplayTextBox.TabIndex = 0
        '
        'FontGroup
        '
        Me.FontGroup.Controls.Add(Me.TahomaRadioButton)
        Me.FontGroup.Controls.Add(Me.MagnetoRadioButton)
        Me.FontGroup.Controls.Add(Me.GaramondRadioButton)
        Me.FontGroup.Font = New System.Drawing.Font("Sitka Banner", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FontGroup.Location = New System.Drawing.Point(333, 31)
        Me.FontGroup.Name = "FontGroup"
        Me.FontGroup.Size = New System.Drawing.Size(445, 84)
        Me.FontGroup.TabIndex = 1
        Me.FontGroup.TabStop = False
        Me.FontGroup.Text = "Font"
        '
        'TahomaRadioButton
        '
        Me.TahomaRadioButton.AutoSize = True
        Me.TahomaRadioButton.Location = New System.Drawing.Point(336, 26)
        Me.TahomaRadioButton.Name = "TahomaRadioButton"
        Me.TahomaRadioButton.Size = New System.Drawing.Size(89, 30)
        Me.TahomaRadioButton.TabIndex = 2
        Me.TahomaRadioButton.TabStop = True
        Me.TahomaRadioButton.Text = "Tahoma"
        Me.TahomaRadioButton.UseVisualStyleBackColor = True
        '
        'MagnetoRadioButton
        '
        Me.MagnetoRadioButton.AutoSize = True
        Me.MagnetoRadioButton.Location = New System.Drawing.Point(186, 26)
        Me.MagnetoRadioButton.Name = "MagnetoRadioButton"
        Me.MagnetoRadioButton.Size = New System.Drawing.Size(92, 30)
        Me.MagnetoRadioButton.TabIndex = 1
        Me.MagnetoRadioButton.TabStop = True
        Me.MagnetoRadioButton.Text = "Magneto"
        Me.MagnetoRadioButton.UseVisualStyleBackColor = True
        '
        'GaramondRadioButton
        '
        Me.GaramondRadioButton.AutoSize = True
        Me.GaramondRadioButton.Location = New System.Drawing.Point(30, 26)
        Me.GaramondRadioButton.Name = "GaramondRadioButton"
        Me.GaramondRadioButton.Size = New System.Drawing.Size(107, 30)
        Me.GaramondRadioButton.TabIndex = 0
        Me.GaramondRadioButton.TabStop = True
        Me.GaramondRadioButton.Text = "Garamond"
        Me.GaramondRadioButton.UseVisualStyleBackColor = True
        '
        'FontColorGroupBox
        '
        Me.FontColorGroupBox.Controls.Add(Me.RedRadioButton)
        Me.FontColorGroupBox.Controls.Add(Me.BlueRadioButton)
        Me.FontColorGroupBox.Controls.Add(Me.GreenRadioButton)
        Me.FontColorGroupBox.Font = New System.Drawing.Font("Sitka Banner", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FontColorGroupBox.Location = New System.Drawing.Point(642, 151)
        Me.FontColorGroupBox.Name = "FontColorGroupBox"
        Me.FontColorGroupBox.Size = New System.Drawing.Size(136, 196)
        Me.FontColorGroupBox.TabIndex = 2
        Me.FontColorGroupBox.TabStop = False
        Me.FontColorGroupBox.Text = "Font Color"
        '
        'RedRadioButton
        '
        Me.RedRadioButton.AutoSize = True
        Me.RedRadioButton.Location = New System.Drawing.Point(37, 146)
        Me.RedRadioButton.Name = "RedRadioButton"
        Me.RedRadioButton.Size = New System.Drawing.Size(59, 30)
        Me.RedRadioButton.TabIndex = 2
        Me.RedRadioButton.TabStop = True
        Me.RedRadioButton.Text = "Red"
        Me.RedRadioButton.UseVisualStyleBackColor = True
        '
        'BlueRadioButton
        '
        Me.BlueRadioButton.AutoSize = True
        Me.BlueRadioButton.Location = New System.Drawing.Point(37, 92)
        Me.BlueRadioButton.Name = "BlueRadioButton"
        Me.BlueRadioButton.Size = New System.Drawing.Size(63, 30)
        Me.BlueRadioButton.TabIndex = 1
        Me.BlueRadioButton.TabStop = True
        Me.BlueRadioButton.Text = "Blue"
        Me.BlueRadioButton.UseVisualStyleBackColor = True
        '
        'GreenRadioButton
        '
        Me.GreenRadioButton.AutoSize = True
        Me.GreenRadioButton.Location = New System.Drawing.Point(37, 40)
        Me.GreenRadioButton.Name = "GreenRadioButton"
        Me.GreenRadioButton.Size = New System.Drawing.Size(74, 30)
        Me.GreenRadioButton.TabIndex = 0
        Me.GreenRadioButton.TabStop = True
        Me.GreenRadioButton.Text = "Green"
        Me.GreenRadioButton.UseVisualStyleBackColor = True
        '
        'FontStyleGroupBox
        '
        Me.FontStyleGroupBox.Controls.Add(Me.BoldItalicCheckBox)
        Me.FontStyleGroupBox.Controls.Add(Me.BoldCheckBox)
        Me.FontStyleGroupBox.Controls.Add(Me.ItalicCheckBox)
        Me.FontStyleGroupBox.Font = New System.Drawing.Font("Sitka Banner", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FontStyleGroupBox.Location = New System.Drawing.Point(423, 151)
        Me.FontStyleGroupBox.Name = "FontStyleGroupBox"
        Me.FontStyleGroupBox.Size = New System.Drawing.Size(188, 196)
        Me.FontStyleGroupBox.TabIndex = 3
        Me.FontStyleGroupBox.TabStop = False
        Me.FontStyleGroupBox.Text = "Font Style"
        '
        'BoldItalicCheckBox
        '
        Me.BoldItalicCheckBox.AutoSize = True
        Me.BoldItalicCheckBox.Font = New System.Drawing.Font("Sitka Text", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.BoldItalicCheckBox.Location = New System.Drawing.Point(42, 146)
        Me.BoldItalicCheckBox.Name = "BoldItalicCheckBox"
        Me.BoldItalicCheckBox.Size = New System.Drawing.Size(124, 30)
        Me.BoldItalicCheckBox.TabIndex = 2
        Me.BoldItalicCheckBox.Text = "Bold Italic"
        Me.BoldItalicCheckBox.UseVisualStyleBackColor = True
        '
        'BoldCheckBox
        '
        Me.BoldCheckBox.AutoSize = True
        Me.BoldCheckBox.Font = New System.Drawing.Font("Sitka Text", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BoldCheckBox.Location = New System.Drawing.Point(42, 92)
        Me.BoldCheckBox.Name = "BoldCheckBox"
        Me.BoldCheckBox.Size = New System.Drawing.Size(74, 30)
        Me.BoldCheckBox.TabIndex = 1
        Me.BoldCheckBox.Text = "Bold"
        Me.BoldCheckBox.UseVisualStyleBackColor = True
        '
        'ItalicCheckBox
        '
        Me.ItalicCheckBox.AutoSize = True
        Me.ItalicCheckBox.Font = New System.Drawing.Font("Sitka Text", 10.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.ItalicCheckBox.Location = New System.Drawing.Point(42, 40)
        Me.ItalicCheckBox.Name = "ItalicCheckBox"
        Me.ItalicCheckBox.Size = New System.Drawing.Size(78, 30)
        Me.ItalicCheckBox.TabIndex = 0
        Me.ItalicCheckBox.Text = "Italic"
        Me.ItalicCheckBox.UseVisualStyleBackColor = True
        '
        'PictureBox
        '
        Me.PictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox.Location = New System.Drawing.Point(21, 151)
        Me.PictureBox.Name = "PictureBox"
        Me.PictureBox.Size = New System.Drawing.Size(285, 196)
        Me.PictureBox.TabIndex = 4
        Me.PictureBox.TabStop = False
        '
        'LoadPictureButton
        '
        Me.LoadPictureButton.Font = New System.Drawing.Font("Sitka Banner", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LoadPictureButton.Location = New System.Drawing.Point(104, 373)
        Me.LoadPictureButton.Name = "LoadPictureButton"
        Me.LoadPictureButton.Size = New System.Drawing.Size(134, 43)
        Me.LoadPictureButton.TabIndex = 5
        Me.LoadPictureButton.Text = "Load Picture"
        Me.LoadPictureButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Font = New System.Drawing.Font("Sitka Banner", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ExitButton.Location = New System.Drawing.Point(564, 373)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(134, 43)
        Me.ExitButton.TabIndex = 7
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'ObjectDemonstration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Thistle
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.LoadPictureButton)
        Me.Controls.Add(Me.PictureBox)
        Me.Controls.Add(Me.FontStyleGroupBox)
        Me.Controls.Add(Me.FontColorGroupBox)
        Me.Controls.Add(Me.FontGroup)
        Me.Controls.Add(Me.DisplayGroupBox)
        Me.Name = "ObjectDemonstration"
        Me.Text = "Object Demonstration"
        Me.DisplayGroupBox.ResumeLayout(False)
        Me.DisplayGroupBox.PerformLayout()
        Me.FontGroup.ResumeLayout(False)
        Me.FontGroup.PerformLayout()
        Me.FontColorGroupBox.ResumeLayout(False)
        Me.FontColorGroupBox.PerformLayout()
        Me.FontStyleGroupBox.ResumeLayout(False)
        Me.FontStyleGroupBox.PerformLayout()
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DisplayGroupBox As GroupBox
    Friend WithEvents DisplayTextBox As TextBox
    Friend WithEvents FontGroup As GroupBox
    Friend WithEvents TahomaRadioButton As RadioButton
    Friend WithEvents MagnetoRadioButton As RadioButton
    Friend WithEvents GaramondRadioButton As RadioButton
    Friend WithEvents FontColorGroupBox As GroupBox
    Friend WithEvents RedRadioButton As RadioButton
    Friend WithEvents BlueRadioButton As RadioButton
    Friend WithEvents GreenRadioButton As RadioButton
    Friend WithEvents FontStyleGroupBox As GroupBox
    Friend WithEvents BoldItalicCheckBox As CheckBox
    Friend WithEvents BoldCheckBox As CheckBox
    Friend WithEvents ItalicCheckBox As CheckBox
    Friend WithEvents PictureBox As PictureBox
    Friend WithEvents LoadPictureButton As Button
    Friend WithEvents ExitButton As Button
End Class
