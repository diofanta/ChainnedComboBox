<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.cboProvinsi = New System.Windows.Forms.ComboBox()
        Me.cboKabupaten = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboKecamatan = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboDesa = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Provinsi"
        '
        'cboProvinsi
        '
        Me.cboProvinsi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboProvinsi.FormattingEnabled = True
        Me.cboProvinsi.Location = New System.Drawing.Point(98, 44)
        Me.cboProvinsi.Name = "cboProvinsi"
        Me.cboProvinsi.Size = New System.Drawing.Size(174, 21)
        Me.cboProvinsi.TabIndex = 1
        '
        'cboKabupaten
        '
        Me.cboKabupaten.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboKabupaten.FormattingEnabled = True
        Me.cboKabupaten.Location = New System.Drawing.Point(98, 71)
        Me.cboKabupaten.Name = "cboKabupaten"
        Me.cboKabupaten.Size = New System.Drawing.Size(174, 21)
        Me.cboKabupaten.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Kabupaten"
        '
        'cboKecamatan
        '
        Me.cboKecamatan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboKecamatan.FormattingEnabled = True
        Me.cboKecamatan.Location = New System.Drawing.Point(98, 98)
        Me.cboKecamatan.Name = "cboKecamatan"
        Me.cboKecamatan.Size = New System.Drawing.Size(174, 21)
        Me.cboKecamatan.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Kecamatan"
        '
        'cboDesa
        '
        Me.cboDesa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDesa.FormattingEnabled = True
        Me.cboDesa.Location = New System.Drawing.Point(98, 125)
        Me.cboDesa.Name = "cboDesa"
        Me.cboDesa.Size = New System.Drawing.Size(174, 21)
        Me.cboDesa.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 128)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Desa"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 240)
        Me.Controls.Add(Me.cboDesa)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cboKecamatan)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cboKabupaten)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboProvinsi)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Chainned ComboBox"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cboProvinsi As ComboBox
    Friend WithEvents cboKabupaten As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cboKecamatan As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cboDesa As ComboBox
    Friend WithEvents Label4 As Label
End Class
