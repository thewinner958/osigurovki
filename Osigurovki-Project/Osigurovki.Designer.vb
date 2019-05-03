<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Osigurovki
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
        Me.txtZaplata = New System.Windows.Forms.TextBox()
        Me.DOO = New System.Windows.Forms.Label()
        Me.DZPO = New System.Windows.Forms.Label()
        Me.Zdravni = New System.Windows.Forms.Label()
        Me.Sum = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.optAfter1960 = New System.Windows.Forms.RadioButton()
        Me.optBefore1960 = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtZaplata
        '
        Me.txtZaplata.Location = New System.Drawing.Point(69, 94)
        Me.txtZaplata.Name = "txtZaplata"
        Me.txtZaplata.Size = New System.Drawing.Size(100, 20)
        Me.txtZaplata.TabIndex = 0
        '
        'DOO
        '
        Me.DOO.AutoSize = True
        Me.DOO.Location = New System.Drawing.Point(339, 94)
        Me.DOO.Name = "DOO"
        Me.DOO.Size = New System.Drawing.Size(0, 13)
        Me.DOO.TabIndex = 1
        '
        'DZPO
        '
        Me.DZPO.AutoSize = True
        Me.DZPO.Location = New System.Drawing.Point(339, 136)
        Me.DZPO.Name = "DZPO"
        Me.DZPO.Size = New System.Drawing.Size(0, 13)
        Me.DZPO.TabIndex = 2
        '
        'Zdravni
        '
        Me.Zdravni.AutoSize = True
        Me.Zdravni.Location = New System.Drawing.Point(339, 172)
        Me.Zdravni.Name = "Zdravni"
        Me.Zdravni.Size = New System.Drawing.Size(0, 13)
        Me.Zdravni.TabIndex = 3
        '
        'Sum
        '
        Me.Sum.AutoSize = True
        Me.Sum.Location = New System.Drawing.Point(339, 264)
        Me.Sum.Name = "Sum"
        Me.Sum.Size = New System.Drawing.Size(0, 13)
        Me.Sum.TabIndex = 4
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.optAfter1960)
        Me.GroupBox1.Controls.Add(Me.optBefore1960)
        Me.GroupBox1.Location = New System.Drawing.Point(39, 183)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(104, 94)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Година на раждане"
        '
        'optAfter1960
        '
        Me.optAfter1960.AutoSize = True
        Me.optAfter1960.Location = New System.Drawing.Point(6, 54)
        Me.optAfter1960.Name = "optAfter1960"
        Me.optAfter1960.Size = New System.Drawing.Size(77, 17)
        Me.optAfter1960.TabIndex = 1
        Me.optAfter1960.TabStop = True
        Me.optAfter1960.Text = "След 1960"
        Me.optAfter1960.UseVisualStyleBackColor = True
        '
        'optBefore1960
        '
        Me.optBefore1960.AutoSize = True
        Me.optBefore1960.Location = New System.Drawing.Point(6, 31)
        Me.optBefore1960.Name = "optBefore1960"
        Me.optBefore1960.Size = New System.Drawing.Size(84, 17)
        Me.optBefore1960.TabIndex = 0
        Me.optBefore1960.TabStop = True
        Me.optBefore1960.Text = "Преди 1960"
        Me.optBefore1960.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(301, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "ДОО"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(294, 136)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "ДЗПО"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(283, 172)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Здравно"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(297, 264)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Общо"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 97)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Заплата"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(39, 354)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 11
        Me.btnCalculate.Text = "Изчисли"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'Osigurovki
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(454, 409)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Sum)
        Me.Controls.Add(Me.Zdravni)
        Me.Controls.Add(Me.DZPO)
        Me.Controls.Add(Me.DOO)
        Me.Controls.Add(Me.txtZaplata)
        Me.Name = "Osigurovki"
        Me.Text = "Осигуровки"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtZaplata As System.Windows.Forms.TextBox
    Friend WithEvents DOO As System.Windows.Forms.Label
    Friend WithEvents DZPO As System.Windows.Forms.Label
    Friend WithEvents Zdravni As System.Windows.Forms.Label
    Friend WithEvents Sum As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents optAfter1960 As System.Windows.Forms.RadioButton
    Friend WithEvents optBefore1960 As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnCalculate As System.Windows.Forms.Button

End Class
