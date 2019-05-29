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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radOneTimePurchase = New System.Windows.Forms.RadioButton()
        Me.radYearlyLicense = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkTech = New System.Windows.Forms.CheckBox()
        Me.chkTraining = New System.Windows.Forms.CheckBox()
        Me.chkBackup = New System.Windows.Forms.CheckBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblLicensingDescriptor = New System.Windows.Forms.Label()
        Me.lblFeaturesDescriptor = New System.Windows.Forms.Label()
        Me.lblLicensing = New System.Windows.Forms.Label()
        Me.lblFeatures = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radOneTimePurchase)
        Me.GroupBox1.Controls.Add(Me.radYearlyLicense)
        Me.GroupBox1.Location = New System.Drawing.Point(36, 38)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(189, 140)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Licensing Options"
        '
        'radOneTimePurchase
        '
        Me.radOneTimePurchase.AutoSize = True
        Me.radOneTimePurchase.Location = New System.Drawing.Point(23, 90)
        Me.radOneTimePurchase.Name = "radOneTimePurchase"
        Me.radOneTimePurchase.Size = New System.Drawing.Size(119, 17)
        Me.radOneTimePurchase.TabIndex = 3
        Me.radOneTimePurchase.TabStop = True
        Me.radOneTimePurchase.Text = "One-Time Purchase"
        Me.radOneTimePurchase.UseVisualStyleBackColor = True
        '
        'radYearlyLicense
        '
        Me.radYearlyLicense.AutoSize = True
        Me.radYearlyLicense.Location = New System.Drawing.Point(23, 44)
        Me.radYearlyLicense.Name = "radYearlyLicense"
        Me.radYearlyLicense.Size = New System.Drawing.Size(90, 17)
        Me.radYearlyLicense.TabIndex = 2
        Me.radYearlyLicense.TabStop = True
        Me.radYearlyLicense.Text = "Yearly license"
        Me.radYearlyLicense.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkBackup)
        Me.GroupBox2.Controls.Add(Me.chkTraining)
        Me.GroupBox2.Controls.Add(Me.chkTech)
        Me.GroupBox2.Location = New System.Drawing.Point(245, 38)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(248, 140)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Optional Features (yearly)"
        '
        'chkTech
        '
        Me.chkTech.AutoSize = True
        Me.chkTech.Location = New System.Drawing.Point(36, 35)
        Me.chkTech.Name = "chkTech"
        Me.chkTech.Size = New System.Drawing.Size(151, 17)
        Me.chkTech.TabIndex = 2
        Me.chkTech.Text = "Level-3 Technical Support"
        Me.chkTech.UseVisualStyleBackColor = True
        '
        'chkTraining
        '
        Me.chkTraining.AutoSize = True
        Me.chkTraining.Location = New System.Drawing.Point(36, 71)
        Me.chkTraining.Name = "chkTraining"
        Me.chkTraining.Size = New System.Drawing.Size(100, 17)
        Me.chkTraining.TabIndex = 3
        Me.chkTraining.Text = "On-site Training"
        Me.chkTraining.UseVisualStyleBackColor = True
        '
        'chkBackup
        '
        Me.chkBackup.AutoSize = True
        Me.chkBackup.Location = New System.Drawing.Point(36, 107)
        Me.chkBackup.Name = "chkBackup"
        Me.chkBackup.Size = New System.Drawing.Size(93, 17)
        Me.chkBackup.TabIndex = 4
        Me.chkBackup.Text = "Cloud Backup"
        Me.chkBackup.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lblFeatures)
        Me.Panel1.Controls.Add(Me.lblLicensing)
        Me.Panel1.Controls.Add(Me.lblFeaturesDescriptor)
        Me.Panel1.Controls.Add(Me.lblLicensingDescriptor)
        Me.Panel1.Location = New System.Drawing.Point(70, 215)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(362, 131)
        Me.Panel1.TabIndex = 2
        '
        'lblLicensingDescriptor
        '
        Me.lblLicensingDescriptor.AutoSize = True
        Me.lblLicensingDescriptor.Location = New System.Drawing.Point(44, 29)
        Me.lblLicensingDescriptor.Name = "lblLicensingDescriptor"
        Me.lblLicensingDescriptor.Size = New System.Drawing.Size(130, 13)
        Me.lblLicensingDescriptor.TabIndex = 3
        Me.lblLicensingDescriptor.Text = "Cost of software licensing:"
        '
        'lblFeaturesDescriptor
        '
        Me.lblFeaturesDescriptor.AutoSize = True
        Me.lblFeaturesDescriptor.Location = New System.Drawing.Point(44, 75)
        Me.lblFeaturesDescriptor.Name = "lblFeaturesDescriptor"
        Me.lblFeaturesDescriptor.Size = New System.Drawing.Size(124, 13)
        Me.lblFeaturesDescriptor.TabIndex = 4
        Me.lblFeaturesDescriptor.Text = "Cost of optional features:"
        '
        'lblLicensing
        '
        Me.lblLicensing.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLicensing.Location = New System.Drawing.Point(223, 26)
        Me.lblLicensing.Name = "lblLicensing"
        Me.lblLicensing.Size = New System.Drawing.Size(98, 28)
        Me.lblLicensing.TabIndex = 5
        Me.lblLicensing.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFeatures
        '
        Me.lblFeatures.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFeatures.Location = New System.Drawing.Point(223, 72)
        Me.lblFeatures.Name = "lblFeatures"
        Me.lblFeatures.Size = New System.Drawing.Size(98, 27)
        Me.lblFeatures.TabIndex = 6
        Me.lblFeatures.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(70, 385)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(99, 29)
        Me.btnCalculate.TabIndex = 3
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(204, 385)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(99, 29)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(350, 385)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(99, 29)
        Me.btnClose.TabIndex = 5
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(538, 450)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Software Sales"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radOneTimePurchase As RadioButton
    Friend WithEvents radYearlyLicense As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents chkTech As CheckBox
    Friend WithEvents chkBackup As CheckBox
    Friend WithEvents chkTraining As CheckBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblFeatures As Label
    Friend WithEvents lblLicensing As Label
    Friend WithEvents lblFeaturesDescriptor As Label
    Friend WithEvents lblLicensingDescriptor As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnClose As Button
End Class
