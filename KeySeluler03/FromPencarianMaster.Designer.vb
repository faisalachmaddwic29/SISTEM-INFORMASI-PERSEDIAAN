<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FromPencarianMaster
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RBRetur = New System.Windows.Forms.RadioButton()
        Me.rbbarangkeluar = New System.Windows.Forms.RadioButton()
        Me.Rbbarangmasuk = New System.Windows.Forms.RadioButton()
        Me.Rbbagian = New System.Windows.Forms.RadioButton()
        Me.Rbsupplier = New System.Windows.Forms.RadioButton()
        Me.Rbbarang = New System.Windows.Forms.RadioButton()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.tpencarian = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RBRetur)
        Me.GroupBox1.Controls.Add(Me.rbbarangkeluar)
        Me.GroupBox1.Controls.Add(Me.Rbbarangmasuk)
        Me.GroupBox1.Controls.Add(Me.Rbbagian)
        Me.GroupBox1.Controls.Add(Me.Rbsupplier)
        Me.GroupBox1.Controls.Add(Me.Rbbarang)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(824, 100)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Jenis Pencarian"
        '
        'RBRetur
        '
        Me.RBRetur.AutoSize = True
        Me.RBRetur.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBRetur.Location = New System.Drawing.Point(378, 37)
        Me.RBRetur.Name = "RBRetur"
        Me.RBRetur.Size = New System.Drawing.Size(123, 24)
        Me.RBRetur.TabIndex = 5
        Me.RBRetur.TabStop = True
        Me.RBRetur.Text = "Retur Barang"
        Me.RBRetur.UseVisualStyleBackColor = True
        '
        'rbbarangkeluar
        '
        Me.rbbarangkeluar.AutoSize = True
        Me.rbbarangkeluar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbbarangkeluar.Location = New System.Drawing.Point(691, 37)
        Me.rbbarangkeluar.Name = "rbbarangkeluar"
        Me.rbbarangkeluar.Size = New System.Drawing.Size(128, 24)
        Me.rbbarangkeluar.TabIndex = 4
        Me.rbbarangkeluar.TabStop = True
        Me.rbbarangkeluar.Text = "Barang Keluar"
        Me.rbbarangkeluar.UseVisualStyleBackColor = True
        '
        'Rbbarangmasuk
        '
        Me.Rbbarangmasuk.AutoSize = True
        Me.Rbbarangmasuk.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rbbarangmasuk.Location = New System.Drawing.Point(541, 37)
        Me.Rbbarangmasuk.Name = "Rbbarangmasuk"
        Me.Rbbarangmasuk.Size = New System.Drawing.Size(130, 24)
        Me.Rbbarangmasuk.TabIndex = 3
        Me.Rbbarangmasuk.TabStop = True
        Me.Rbbarangmasuk.Text = "Barang Masuk"
        Me.Rbbarangmasuk.UseVisualStyleBackColor = True
        '
        'Rbbagian
        '
        Me.Rbbagian.AutoSize = True
        Me.Rbbagian.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rbbagian.Location = New System.Drawing.Point(258, 37)
        Me.Rbbagian.Name = "Rbbagian"
        Me.Rbbagian.Size = New System.Drawing.Size(77, 24)
        Me.Rbbagian.TabIndex = 2
        Me.Rbbagian.TabStop = True
        Me.Rbbagian.Text = "Bagian"
        Me.Rbbagian.UseVisualStyleBackColor = True
        '
        'Rbsupplier
        '
        Me.Rbsupplier.AutoSize = True
        Me.Rbsupplier.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rbsupplier.Location = New System.Drawing.Point(125, 37)
        Me.Rbsupplier.Name = "Rbsupplier"
        Me.Rbsupplier.Size = New System.Drawing.Size(85, 24)
        Me.Rbsupplier.TabIndex = 1
        Me.Rbsupplier.TabStop = True
        Me.Rbsupplier.Text = "Supplier"
        Me.Rbsupplier.UseVisualStyleBackColor = True
        '
        'Rbbarang
        '
        Me.Rbbarang.AutoSize = True
        Me.Rbbarang.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rbbarang.Location = New System.Drawing.Point(12, 37)
        Me.Rbbarang.Name = "Rbbarang"
        Me.Rbbarang.Size = New System.Drawing.Size(79, 24)
        Me.Rbbarang.TabIndex = 0
        Me.Rbbarang.TabStop = True
        Me.Rbbarang.Text = "Barang"
        Me.Rbbarang.UseVisualStyleBackColor = True
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
        Me.DGV.Location = New System.Drawing.Point(0, 136)
        Me.DGV.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.DGV.Name = "DGV"
        Me.DGV.Size = New System.Drawing.Size(819, 320)
        Me.DGV.TabIndex = 82
        '
        'tpencarian
        '
        Me.tpencarian.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tpencarian.Location = New System.Drawing.Point(0, 107)
        Me.tpencarian.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.tpencarian.Name = "tpencarian"
        Me.tpencarian.Size = New System.Drawing.Size(819, 26)
        Me.tpencarian.TabIndex = 84
        '
        'FromPencarianMaster
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(824, 456)
        Me.Controls.Add(Me.tpencarian)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FromPencarianMaster"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Pencarian Master"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbbarangkeluar As RadioButton
    Friend WithEvents Rbbarangmasuk As RadioButton
    Friend WithEvents Rbbagian As RadioButton
    Friend WithEvents Rbsupplier As RadioButton
    Friend WithEvents Rbbarang As RadioButton
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents DGV As DataGridView
    Friend WithEvents tpencarian As TextBox
    Friend WithEvents RBRetur As RadioButton
End Class
