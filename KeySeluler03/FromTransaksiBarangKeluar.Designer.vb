<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FromTransaksiBarangKeluar
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FromTransaksiBarangKeluar))
        Me.LabelKeluar = New System.Windows.Forms.Label()
        Me.labeluser = New System.Windows.Forms.Label()
        Me.Tstok = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnhapus = New System.Windows.Forms.Button()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.btnStokawal = New System.Windows.Forms.Button()
        Me.btnKeluar = New System.Windows.Forms.Button()
        Me.btntambah = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnbaru = New System.Windows.Forms.Button()
        Me.Tbagian = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Tkode = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DTP1 = New System.Windows.Forms.DateTimePicker()
        Me.CdetailK = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Labeljam = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelKeluar
        '
        Me.LabelKeluar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabelKeluar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelKeluar.Location = New System.Drawing.Point(143, 48)
        Me.LabelKeluar.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelKeluar.Name = "LabelKeluar"
        Me.LabelKeluar.Size = New System.Drawing.Size(126, 20)
        Me.LabelKeluar.TabIndex = 33
        '
        'labeluser
        '
        Me.labeluser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.labeluser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labeluser.Location = New System.Drawing.Point(143, 16)
        Me.labeluser.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labeluser.Name = "labeluser"
        Me.labeluser.Size = New System.Drawing.Size(82, 20)
        Me.labeluser.TabIndex = 32
        '
        'Tstok
        '
        Me.Tstok.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tstok.Location = New System.Drawing.Point(143, 147)
        Me.Tstok.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Tstok.Name = "Tstok"
        Me.Tstok.Size = New System.Drawing.Size(46, 22)
        Me.Tstok.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 147)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 23)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Jumlah Barang"
        '
        'Label8
        '
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(9, 16)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(126, 20)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "Kode User"
        '
        'Label6
        '
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(9, 82)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(126, 23)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Tanggal"
        '
        'Label7
        '
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(9, 215)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(126, 23)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Kode Bagian"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnhapus)
        Me.GroupBox4.Controls.Add(Me.BtnEdit)
        Me.GroupBox4.Controls.Add(Me.btnStokawal)
        Me.GroupBox4.Controls.Add(Me.btnKeluar)
        Me.GroupBox4.Controls.Add(Me.btntambah)
        Me.GroupBox4.Controls.Add(Me.btnBatal)
        Me.GroupBox4.Controls.Add(Me.btnbaru)
        Me.GroupBox4.Location = New System.Drawing.Point(6, 322)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox4.Size = New System.Drawing.Size(383, 211)
        Me.GroupBox4.TabIndex = 92
        Me.GroupBox4.TabStop = False
        '
        'btnhapus
        '
        Me.btnhapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnhapus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnhapus.Image = CType(resources.GetObject("btnhapus.Image"), System.Drawing.Image)
        Me.btnhapus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnhapus.Location = New System.Drawing.Point(7, 66)
        Me.btnhapus.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnhapus.Name = "btnhapus"
        Me.btnhapus.Size = New System.Drawing.Size(179, 42)
        Me.btnhapus.TabIndex = 7
        Me.btnhapus.Text = "&Hapus"
        Me.btnhapus.UseVisualStyleBackColor = True
        '
        'BtnEdit
        '
        Me.BtnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEdit.Image = CType(resources.GetObject("BtnEdit.Image"), System.Drawing.Image)
        Me.BtnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEdit.Location = New System.Drawing.Point(7, 116)
        Me.BtnEdit.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(179, 41)
        Me.BtnEdit.TabIndex = 9
        Me.BtnEdit.Text = "&Edit"
        Me.BtnEdit.UseVisualStyleBackColor = True
        '
        'btnStokawal
        '
        Me.btnStokawal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStokawal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStokawal.Image = CType(resources.GetObject("btnStokawal.Image"), System.Drawing.Image)
        Me.btnStokawal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStokawal.Location = New System.Drawing.Point(194, 114)
        Me.btnStokawal.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnStokawal.Name = "btnStokawal"
        Me.btnStokawal.Size = New System.Drawing.Size(179, 41)
        Me.btnStokawal.TabIndex = 10
        Me.btnStokawal.Text = "&Stok Awal"
        Me.btnStokawal.UseVisualStyleBackColor = True
        '
        'btnKeluar
        '
        Me.btnKeluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKeluar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKeluar.Image = CType(resources.GetObject("btnKeluar.Image"), System.Drawing.Image)
        Me.btnKeluar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnKeluar.Location = New System.Drawing.Point(7, 163)
        Me.btnKeluar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(366, 42)
        Me.btnKeluar.TabIndex = 11
        Me.btnKeluar.Text = "&Keluar"
        Me.btnKeluar.UseVisualStyleBackColor = True
        '
        'btntambah
        '
        Me.btntambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btntambah.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btntambah.Image = CType(resources.GetObject("btntambah.Image"), System.Drawing.Image)
        Me.btntambah.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btntambah.Location = New System.Drawing.Point(194, 19)
        Me.btntambah.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btntambah.Name = "btntambah"
        Me.btntambah.Size = New System.Drawing.Size(179, 41)
        Me.btntambah.TabIndex = 6
        Me.btntambah.Text = "&Tambah Item"
        Me.btntambah.UseVisualStyleBackColor = True
        '
        'btnBatal
        '
        Me.btnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBatal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBatal.Image = CType(resources.GetObject("btnBatal.Image"), System.Drawing.Image)
        Me.btnBatal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBatal.Location = New System.Drawing.Point(194, 66)
        Me.btnBatal.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(179, 42)
        Me.btnBatal.TabIndex = 8
        Me.btnBatal.Text = "&Batal"
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'btnbaru
        '
        Me.btnbaru.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnbaru.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbaru.Image = CType(resources.GetObject("btnbaru.Image"), System.Drawing.Image)
        Me.btnbaru.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnbaru.Location = New System.Drawing.Point(7, 19)
        Me.btnbaru.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnbaru.Name = "btnbaru"
        Me.btnbaru.Size = New System.Drawing.Size(179, 41)
        Me.btnbaru.TabIndex = 5
        Me.btnbaru.Text = "&Transaksi Baru"
        Me.btnbaru.UseVisualStyleBackColor = True
        '
        'Tbagian
        '
        Me.Tbagian.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tbagian.Location = New System.Drawing.Point(143, 215)
        Me.Tbagian.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Tbagian.Name = "Tbagian"
        Me.Tbagian.Size = New System.Drawing.Size(80, 22)
        Me.Tbagian.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 183)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 22)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Kode Barang"
        '
        'Tkode
        '
        Me.Tkode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tkode.Location = New System.Drawing.Point(143, 179)
        Me.Tkode.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Tkode.Name = "Tkode"
        Me.Tkode.Size = New System.Drawing.Size(80, 22)
        Me.Tkode.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(13, 9)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(272, 25)
        Me.Label9.TabIndex = 93
        Me.Label9.Text = "Transaksi Barang Keluar"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DTP1)
        Me.GroupBox1.Controls.Add(Me.CdetailK)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.LabelKeluar)
        Me.GroupBox1.Controls.Add(Me.labeluser)
        Me.GroupBox1.Controls.Add(Me.Tstok)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Tbagian)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Tkode)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 61)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(383, 261)
        Me.GroupBox1.TabIndex = 91
        Me.GroupBox1.TabStop = False
        '
        'DTP1
        '
        Me.DTP1.CustomFormat = "yyyy/MM/dd"
        Me.DTP1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTP1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP1.Location = New System.Drawing.Point(143, 81)
        Me.DTP1.Name = "DTP1"
        Me.DTP1.Size = New System.Drawing.Size(98, 22)
        Me.DTP1.TabIndex = 36
        '
        'CdetailK
        '
        Me.CdetailK.FormattingEnabled = True
        Me.CdetailK.Location = New System.Drawing.Point(143, 115)
        Me.CdetailK.Name = "CdetailK"
        Me.CdetailK.Size = New System.Drawing.Size(46, 21)
        Me.CdetailK.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 116)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 20)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "No Faktur"
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(9, 48)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(126, 20)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "No Keluar"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(19, 37)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(267, 20)
        Me.Label11.TabIndex = 94
        Me.Label11.Text = "Program Aplikasi Persediaan Barang"
        '
        'Labeljam
        '
        Me.Labeljam.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labeljam.Location = New System.Drawing.Point(546, 29)
        Me.Labeljam.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Labeljam.Name = "Labeljam"
        Me.Labeljam.Size = New System.Drawing.Size(91, 20)
        Me.Labeljam.TabIndex = 108
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(546, 9)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 20)
        Me.Label5.TabIndex = 107
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(397, 179)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(240, 354)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 109
        Me.PictureBox1.TabStop = False
        '
        'FromTransaksiBarangKeluar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(652, 548)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Labeljam)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label11)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FromTransaksiBarangKeluar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Transaksi Barang Keluar"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btntambah As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents LabelKeluar As Label
    Friend WithEvents labeluser As Label
    Friend WithEvents Tstok As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnKeluar As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents btnbaru As Button
    Friend WithEvents Tbagian As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Tkode As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents CdetailK As ComboBox
    Friend WithEvents btnStokawal As Button
    Friend WithEvents btnhapus As Button
    Friend WithEvents BtnEdit As Button
    Friend WithEvents Labeljam As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DTP1 As DateTimePicker
End Class
