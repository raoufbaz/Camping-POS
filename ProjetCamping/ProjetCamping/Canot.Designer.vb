<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class canot
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(canot))
        Me.radioScanot = New System.Windows.Forms.RadioButton()
        Me.Numericcanot = New System.Windows.Forms.NumericUpDown()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.radioFDScanot = New System.Windows.Forms.RadioButton()
        CType(Me.Numericcanot, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'radioScanot
        '
        Me.radioScanot.AutoSize = True
        Me.radioScanot.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radioScanot.Location = New System.Drawing.Point(453, 274)
        Me.radioScanot.Name = "radioScanot"
        Me.radioScanot.Size = New System.Drawing.Size(169, 24)
        Me.radioScanot.TabIndex = 22
        Me.radioScanot.TabStop = True
        Me.radioScanot.Text = "Jour de semaine"
        Me.radioScanot.UseVisualStyleBackColor = True
        '
        'Numericcanot
        '
        Me.Numericcanot.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Numericcanot.Location = New System.Drawing.Point(311, 242)
        Me.Numericcanot.Name = "Numericcanot"
        Me.Numericcanot.Size = New System.Drawing.Size(62, 27)
        Me.Numericcanot.TabIndex = 20
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(311, 377)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(168, 59)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "retour"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(81, 244)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(205, 20)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "nombre d'embarcations"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(100, 209)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 20)
        Me.Label1.TabIndex = 16
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.Color.LightGreen
        Me.RichTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.15!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(270, 22)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(452, 147)
        Me.RichTextBox1.TabIndex = 15
        Me.RichTextBox1.Text = "" & Global.Microsoft.VisualBasic.ChrW(10) & "Par embarcation et pour des blocs de deux heures" & Global.Microsoft.VisualBasic.ChrW(10) & "        " & Global.Microsoft.VisualBasic.ChrW(10) & "               semaine" &
    "            Fin de semaine" & Global.Microsoft.VisualBasic.ChrW(10) & "                 $22,35                  $29,55"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(44, 44)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(168, 25)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Tarif pour le canot"
        '
        'radioFDScanot
        '
        Me.radioFDScanot.AutoSize = True
        Me.radioFDScanot.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radioFDScanot.Location = New System.Drawing.Point(453, 224)
        Me.radioFDScanot.Name = "radioFDScanot"
        Me.radioFDScanot.Size = New System.Drawing.Size(304, 24)
        Me.radioFDScanot.TabIndex = 21
        Me.radioFDScanot.TabStop = True
        Me.radioFDScanot.Text = "Fin de semaine ou jour de conge"
        Me.radioFDScanot.UseVisualStyleBackColor = True
        '
        'canot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGreen
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(800, 544)
        Me.Controls.Add(Me.radioScanot)
        Me.Controls.Add(Me.radioFDScanot)
        Me.Controls.Add(Me.Numericcanot)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.Label4)
        Me.Name = "canot"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "canot"
        CType(Me.Numericcanot, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents radioScanot As RadioButton
    Friend WithEvents Numericcanot As NumericUpDown
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents radioFDScanot As RadioButton
End Class
