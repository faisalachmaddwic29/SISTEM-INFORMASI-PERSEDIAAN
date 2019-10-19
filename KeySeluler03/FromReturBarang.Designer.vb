<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FromReturBarang
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FromReturBarang))
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.labelretur = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tket = New System.Windows.Forms.RichTextBox()
        Me.trusak = New System.Windows.Forms.TextBox()
        Me.labelstokmasuk = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LabelnamaB = New System.Windows.Forms.Label()
        Me.labelkode = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.labeltanggal = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.labelnomasuk = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Cdetail = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnKeluar = New System.Windows.Forms.Button()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnInput = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DGV)
        Me.GroupBox3.Location = New System.Drawing.Point(13, 185)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox3.Size = New System.Drawing.Size(842, 237)
        Me.GroupBox3.TabIndex = 87
        Me.GroupBox3.TabStop = False
        '
        'DGV
        '
        Me.DGV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV.DefaultCellStyle = DataGridViewCellStyle2
        Me.DGV.Location = New System.Drawing.Point(6, 15)
        Me.DGV.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.DGV.Name = "DGV"
        Me.DGV.Size = New System.Drawing.Size(828, 212)
        Me.DGV.TabIndex = 81
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.labelretur)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.tket)
        Me.GroupBox1.Controls.Add(Me.trusak)
        Me.GroupBox1.Controls.Add(Me.labelstokmasuk)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.LabelnamaB)
        Me.GroupBox1.Controls.Add(Me.labelkode)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.labeltanggal)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.labelnomasuk)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Cdetail)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(860, 167)
        Me.GroupBox1.TabIndex = 93
        Me.GroupBox1.TabStop = False
        '
        'labelretur
        '
        Me.labelretur.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.labelretur.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelretur.Location = New System.Drawing.Point(145, 56)
        Me.labelretur.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelretur.Name = "labelretur"
        Me.labelretur.Size = New System.Drawing.Size(82, 20)
        Me.labelretur.TabIndex = 117
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 20)
        Me.Label1.TabIndex = 116
        Me.Label1.Text = "Kode Retur"
        '
        'tket
        '
        Me.tket.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tket.Location = New System.Drawing.Point(674, 50)
        Me.tket.Name = "tket"
        Me.tket.Size = New System.Drawing.Size(169, 96)
        Me.tket.TabIndex = 115
        Me.tket.Text = ""
        '
        'trusak
        '
        Me.trusak.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.trusak.Location = New System.Drawing.Point(456, 115)
        Me.trusak.Name = "trusak"
        Me.trusak.Size = New System.Drawing.Size(47, 26)
        Me.trusak.TabIndex = 114
        '
        'labelstokmasuk
        '
        Me.labelstokmasuk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.labelstokmasuk.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelstokmasuk.Location = New System.Drawing.Point(455, 90)
        Me.labelstokmasuk.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelstokmasuk.Name = "labelstokmasuk"
        Me.labelstokmasuk.Size = New System.Drawing.Size(82, 20)
        Me.labelstokmasuk.TabIndex = 113
        '
        'Label9
        '
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(314, 117)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(135, 20)
        Me.Label9.TabIndex = 112
        Me.Label9.Text = "Jumlah Rusak"
        '
        'Label7
        '
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(314, 87)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(135, 20)
        Me.Label7.TabIndex = 111
        Me.Label7.Text = "Stok Masuk"
        '
        'LabelnamaB
        '
        Me.LabelnamaB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabelnamaB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelnamaB.Location = New System.Drawing.Point(145, 118)
        Me.LabelnamaB.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelnamaB.Name = "LabelnamaB"
        Me.LabelnamaB.Size = New System.Drawing.Size(139, 20)
        Me.LabelnamaB.TabIndex = 110
        '
        'labelkode
        '
        Me.labelkode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.labelkode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelkode.Location = New System.Drawing.Point(145, 87)
        Me.labelkode.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelkode.Name = "labelkode"
        Me.labelkode.Size = New System.Drawing.Size(82, 20)
        Me.labelkode.TabIndex = 109
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(674, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(145, 30)
        Me.Label5.TabIndex = 107
        Me.Label5.Text = "Keterangan Rusak"
        '
        'labeltanggal
        '
        Me.labeltanggal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.labeltanggal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labeltanggal.Location = New System.Drawing.Point(455, 56)
        Me.labeltanggal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labeltanggal.Name = "labeltanggal"
        Me.labeltanggal.Size = New System.Drawing.Size(131, 20)
        Me.labeltanggal.TabIndex = 106
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(314, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(135, 22)
        Me.Label4.TabIndex = 105
        Me.Label4.Text = "Tanggal Pembelian"
        '
        'labelnomasuk
        '
        Me.labelnomasuk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.labelnomasuk.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelnomasuk.Location = New System.Drawing.Point(455, 26)
        Me.labelnomasuk.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelnomasuk.Name = "labelnomasuk"
        Me.labelnomasuk.Size = New System.Drawing.Size(131, 20)
        Me.labelnomasuk.TabIndex = 104
        '
        'Label8
        '
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 118)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(126, 22)
        Me.Label8.TabIndex = 94
        Me.Label8.Text = "Nama Barang"
        '
        'Label6
        '
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 85)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(126, 22)
        Me.Label6.TabIndex = 90
        Me.Label6.Text = "Kode Barang"
        '
        'Cdetail
        '
        Me.Cdetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cdetail.FormattingEnabled = True
        Me.Cdetail.Location = New System.Drawing.Point(145, 26)
        Me.Cdetail.Name = "Cdetail"
        Me.Cdetail.Size = New System.Drawing.Size(62, 23)
        Me.Cdetail.TabIndex = 85
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(314, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "No Masuk"
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "No Faktur"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(509, 495)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(8, 8)
        Me.Button1.TabIndex = 94
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnKeluar)
        Me.GroupBox4.Controls.Add(Me.BtnEdit)
        Me.GroupBox4.Controls.Add(Me.btnBatal)
        Me.GroupBox4.Controls.Add(Me.btnInput)
        Me.GroupBox4.Controls.Add(Me.btnHapus)
        Me.GroupBox4.Location = New System.Drawing.Point(13, 428)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox4.Size = New System.Drawing.Size(566, 93)
        Me.GroupBox4.TabIndex = 95
        Me.GroupBox4.TabStop = False
        '
        'btnKeluar
        '
        Me.btnKeluar.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnKeluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKeluar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKeluar.Image = CType(resources.GetObject("btnKeluar.Image"), System.Drawing.Image)
        Me.btnKeluar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnKeluar.Location = New System.Drawing.Point(448, 16)
        Me.btnKeluar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(112, 74)
        Me.btnKeluar.TabIndex = 11
        Me.btnKeluar.Text = "&Keluar"
        Me.btnKeluar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnKeluar.UseVisualStyleBackColor = True
        '
        'BtnEdit
        '
        Me.BtnEdit.Dock = System.Windows.Forms.DockStyle.Left
        Me.BtnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEdit.Image = CType(resources.GetObject("BtnEdit.Image"), System.Drawing.Image)
        Me.BtnEdit.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnEdit.Location = New System.Drawing.Point(336, 16)
        Me.BtnEdit.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(112, 74)
        Me.BtnEdit.TabIndex = 12
        Me.BtnEdit.Text = "&Edit"
        Me.BtnEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnEdit.UseVisualStyleBackColor = True
        '
        'btnBatal
        '
        Me.btnBatal.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBatal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBatal.Image = CType(resources.GetObject("btnBatal.Image"), System.Drawing.Image)
        Me.btnBatal.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnBatal.Location = New System.Drawing.Point(224, 16)
        Me.btnBatal.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(112, 74)
        Me.btnBatal.TabIndex = 10
        Me.btnBatal.Text = "&Batal"
        Me.btnBatal.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'btnInput
        '
        Me.btnInput.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInput.Image = CType(resources.GetObject("btnInput.Image"), System.Drawing.Image)
        Me.btnInput.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnInput.Location = New System.Drawing.Point(116, 16)
        Me.btnInput.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnInput.Name = "btnInput"
        Me.btnInput.Size = New System.Drawing.Size(108, 74)
        Me.btnInput.TabIndex = 7
        Me.btnInput.Text = "&Input"
        Me.btnInput.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnInput.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHapus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHapus.Image = CType(resources.GetObject("btnHapus.Image"), System.Drawing.Image)
        Me.btnHapus.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnHapus.Location = New System.Drawing.Point(4, 16)
        Me.btnHapus.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(112, 74)
        Me.btnHapus.TabIndex = 9
        Me.btnHapus.Text = "&Hapus"
        Me.btnHapus.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'FromReturBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 533)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FromReturBarang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Data Retur"
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents DGV As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Cdetail As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents btnKeluar As Button
    Friend WithEvents BtnEdit As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents btnInput As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents labelnomasuk As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents labeltanggal As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents labelstokmasuk As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents LabelnamaB As Label
    Friend WithEvents labelkode As Label
    Friend WithEvents trusak As TextBox
    Friend WithEvents tket As RichTextBox
    Friend WithEvents labelretur As Label
    Friend WithEvents Label1 As Label
End Class
