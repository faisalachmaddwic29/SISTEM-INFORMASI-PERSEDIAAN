<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FromLaporanMaster
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FromLaporanMaster))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnRetur = New System.Windows.Forms.Button()
        Me.btbag = New System.Windows.Forms.Button()
        Me.btnsupp = New System.Windows.Forms.Button()
        Me.btnbarang = New System.Windows.Forms.Button()
        Me.btnadmin = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnRetur)
        Me.GroupBox1.Controls.Add(Me.btbag)
        Me.GroupBox1.Controls.Add(Me.btnsupp)
        Me.GroupBox1.Controls.Add(Me.btnbarang)
        Me.GroupBox1.Controls.Add(Me.btnadmin)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(520, 172)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Laporan Master"
        '
        'btnRetur
        '
        Me.btnRetur.Image = CType(resources.GetObject("btnRetur.Image"), System.Drawing.Image)
        Me.btnRetur.Location = New System.Drawing.Point(416, 22)
        Me.btnRetur.Name = "btnRetur"
        Me.btnRetur.Size = New System.Drawing.Size(105, 150)
        Me.btnRetur.TabIndex = 5
        Me.btnRetur.Text = "Retur"
        Me.btnRetur.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnRetur.UseVisualStyleBackColor = True
        '
        'btbag
        '
        Me.btbag.Image = CType(resources.GetObject("btbag.Image"), System.Drawing.Image)
        Me.btbag.Location = New System.Drawing.Point(312, 22)
        Me.btbag.Name = "btbag"
        Me.btbag.Size = New System.Drawing.Size(105, 150)
        Me.btbag.TabIndex = 4
        Me.btbag.Text = "Bagian"
        Me.btbag.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btbag.UseVisualStyleBackColor = True
        '
        'btnsupp
        '
        Me.btnsupp.Image = CType(resources.GetObject("btnsupp.Image"), System.Drawing.Image)
        Me.btnsupp.Location = New System.Drawing.Point(208, 22)
        Me.btnsupp.Name = "btnsupp"
        Me.btnsupp.Size = New System.Drawing.Size(105, 150)
        Me.btnsupp.TabIndex = 3
        Me.btnsupp.Text = "Supplier"
        Me.btnsupp.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnsupp.UseVisualStyleBackColor = True
        '
        'btnbarang
        '
        Me.btnbarang.Image = CType(resources.GetObject("btnbarang.Image"), System.Drawing.Image)
        Me.btnbarang.Location = New System.Drawing.Point(104, 22)
        Me.btnbarang.Name = "btnbarang"
        Me.btnbarang.Size = New System.Drawing.Size(105, 150)
        Me.btnbarang.TabIndex = 2
        Me.btnbarang.Text = "Barang"
        Me.btnbarang.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnbarang.UseVisualStyleBackColor = True
        '
        'btnadmin
        '
        Me.btnadmin.Image = CType(resources.GetObject("btnadmin.Image"), System.Drawing.Image)
        Me.btnadmin.Location = New System.Drawing.Point(0, 22)
        Me.btnadmin.Name = "btnadmin"
        Me.btnadmin.Size = New System.Drawing.Size(105, 150)
        Me.btnadmin.TabIndex = 1
        Me.btnadmin.Text = "Admin"
        Me.btnadmin.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnadmin.UseVisualStyleBackColor = True
        '
        'FromLaporanMaster
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(521, 172)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FromLaporanMaster"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Laporan Master"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnbarang As Button
    Friend WithEvents btnadmin As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents btbag As Button
    Friend WithEvents btnsupp As Button
    Friend WithEvents btnRetur As Button
End Class
