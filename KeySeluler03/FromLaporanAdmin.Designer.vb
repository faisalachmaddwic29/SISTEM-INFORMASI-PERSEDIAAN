﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FromLaporanAdmin
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
        Me.LaporanAdmin1 = New KeySeluler03.LaporanAdmin()
        Me.CRV = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'CRV
        '
        Me.CRV.ActiveViewIndex = -1
        Me.CRV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRV.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRV.Location = New System.Drawing.Point(0, 0)
        Me.CRV.Name = "CRV"
        Me.CRV.Size = New System.Drawing.Size(627, 385)
        Me.CRV.TabIndex = 2
        Me.CRV.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'FromLaporanAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(627, 385)
        Me.Controls.Add(Me.CRV)
        Me.Name = "FromLaporanAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Laporan Data Admin"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LaporanAdmin1 As LaporanAdmin
    Friend WithEvents CRV As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
