<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FromLaporanBarang
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
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.CRVBarang = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.LaporanBarang1 = New KeySeluler03.LaporanBarang()
        Me.SuspendLayout()
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(883, 484)
        Me.CrystalReportViewer1.TabIndex = 0
        '
        'CRVBarang
        '
        Me.CRVBarang.ActiveViewIndex = -1
        Me.CRVBarang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRVBarang.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRVBarang.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRVBarang.Location = New System.Drawing.Point(0, 0)
        Me.CRVBarang.Name = "CRVBarang"
        Me.CRVBarang.Size = New System.Drawing.Size(883, 484)
        Me.CRVBarang.TabIndex = 1
        Me.CRVBarang.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'FromLaporanBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(883, 484)
        Me.Controls.Add(Me.CRVBarang)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "FromLaporanBarang"
        Me.Text = "Form Laporan Data Barang"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents CRVBarang As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents LaporanBarang1 As LaporanBarang
End Class
