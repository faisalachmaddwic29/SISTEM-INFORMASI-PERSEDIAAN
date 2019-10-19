<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FromLaporanBarangMasuk
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
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.CRV = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.BtnGarfik = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.btnviewperiode = New System.Windows.Forms.Button()
        Me.DTP1 = New System.Windows.Forms.DateTimePicker()
        Me.DTP2 = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DTP3 = New System.Windows.Forms.DateTimePicker()
        Me.btnviewtanggal = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.btnSemua = New System.Windows.Forms.Button()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.CRV)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox4.Location = New System.Drawing.Point(0, 130)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(1370, 614)
        Me.GroupBox4.TabIndex = 10
        Me.GroupBox4.TabStop = False
        '
        'CRV
        '
        Me.CRV.ActiveViewIndex = -1
        Me.CRV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRV.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRV.Location = New System.Drawing.Point(3, 16)
        Me.CRV.Name = "CRV"
        Me.CRV.Size = New System.Drawing.Size(1364, 595)
        Me.CRV.TabIndex = 0
        Me.CRV.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.GroupBox6)
        Me.GroupBox3.Controls.Add(Me.GroupBox2)
        Me.GroupBox3.Controls.Add(Me.GroupBox1)
        Me.GroupBox3.Controls.Add(Me.GroupBox5)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox3.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1370, 130)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.BtnGarfik)
        Me.GroupBox6.Dock = System.Windows.Forms.DockStyle.Right
        Me.GroupBox6.Location = New System.Drawing.Point(1163, 16)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(204, 111)
        Me.GroupBox6.TabIndex = 12
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Grafik Penerimaan"
        '
        'BtnGarfik
        '
        Me.BtnGarfik.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BtnGarfik.Location = New System.Drawing.Point(3, 19)
        Me.BtnGarfik.Name = "BtnGarfik"
        Me.BtnGarfik.Size = New System.Drawing.Size(198, 89)
        Me.BtnGarfik.TabIndex = 6
        Me.BtnGarfik.Text = "&Tampilkan"
        Me.BtnGarfik.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.label1)
        Me.GroupBox2.Controls.Add(Me.btnviewperiode)
        Me.GroupBox2.Controls.Add(Me.DTP1)
        Me.GroupBox2.Controls.Add(Me.DTP2)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox2.Location = New System.Drawing.Point(411, 16)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(245, 111)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Per Periode"
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(4, 48)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 20)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Sampai Tanggal  :"
        '
        'label1
        '
        Me.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(4, 21)
        Me.label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(120, 20)
        Me.label1.TabIndex = 10
        Me.label1.Text = "Dari Tanggal         :"
        '
        'btnviewperiode
        '
        Me.btnviewperiode.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnviewperiode.Location = New System.Drawing.Point(3, 76)
        Me.btnviewperiode.Name = "btnviewperiode"
        Me.btnviewperiode.Size = New System.Drawing.Size(239, 32)
        Me.btnviewperiode.TabIndex = 5
        Me.btnviewperiode.Text = "&Tampilkan"
        Me.btnviewperiode.UseVisualStyleBackColor = True
        '
        'DTP1
        '
        Me.DTP1.CustomFormat = "yyyy/MM/dd"
        Me.DTP1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP1.Location = New System.Drawing.Point(123, 21)
        Me.DTP1.Name = "DTP1"
        Me.DTP1.Size = New System.Drawing.Size(121, 20)
        Me.DTP1.TabIndex = 8
        '
        'DTP2
        '
        Me.DTP2.CustomFormat = "yyyy/MM/dd"
        Me.DTP2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP2.Location = New System.Drawing.Point(123, 48)
        Me.DTP2.Name = "DTP2"
        Me.DTP2.Size = New System.Drawing.Size(121, 20)
        Me.DTP2.TabIndex = 9
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DTP3)
        Me.GroupBox1.Controls.Add(Me.btnviewtanggal)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox1.Location = New System.Drawing.Point(207, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(204, 111)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "PerTanggal"
        '
        'DTP3
        '
        Me.DTP3.CustomFormat = "yyyy/MM/dd"
        Me.DTP3.Dock = System.Windows.Forms.DockStyle.Top
        Me.DTP3.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP3.Location = New System.Drawing.Point(3, 16)
        Me.DTP3.Name = "DTP3"
        Me.DTP3.Size = New System.Drawing.Size(198, 20)
        Me.DTP3.TabIndex = 12
        '
        'btnviewtanggal
        '
        Me.btnviewtanggal.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnviewtanggal.Location = New System.Drawing.Point(3, 76)
        Me.btnviewtanggal.Name = "btnviewtanggal"
        Me.btnviewtanggal.Size = New System.Drawing.Size(198, 32)
        Me.btnviewtanggal.TabIndex = 6
        Me.btnviewtanggal.Text = "&Tampilkan"
        Me.btnviewtanggal.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.btnSemua)
        Me.GroupBox5.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox5.Location = New System.Drawing.Point(3, 16)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(204, 111)
        Me.GroupBox5.TabIndex = 8
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Semua Transaksi"
        '
        'btnSemua
        '
        Me.btnSemua.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnSemua.Location = New System.Drawing.Point(3, 19)
        Me.btnSemua.Name = "btnSemua"
        Me.btnSemua.Size = New System.Drawing.Size(198, 89)
        Me.btnSemua.TabIndex = 6
        Me.btnSemua.Text = "&Tampilkan"
        Me.btnSemua.UseVisualStyleBackColor = True
        '
        'FromLaporanBarangMasuk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Name = "FromLaporanBarangMasuk"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormLaporanBarangMasuk"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents CRV As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents label1 As Label
    Friend WithEvents btnviewperiode As Button
    Friend WithEvents DTP1 As DateTimePicker
    Friend WithEvents DTP2 As DateTimePicker
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DTP3 As DateTimePicker
    Friend WithEvents btnviewtanggal As Button
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents btnSemua As Button
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents BtnGarfik As Button
End Class
