﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportSale
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
        Me.ctrv1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'ctrv1
        '
        Me.ctrv1.ActiveViewIndex = -1
        Me.ctrv1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ctrv1.Cursor = System.Windows.Forms.Cursors.Default
        Me.ctrv1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ctrv1.Location = New System.Drawing.Point(0, 0)
        Me.ctrv1.Name = "ctrv1"
        Me.ctrv1.Size = New System.Drawing.Size(671, 674)
        Me.ctrv1.TabIndex = 0
        '
        'frmReportSale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(671, 674)
        Me.Controls.Add(Me.ctrv1)
        Me.Font = New System.Drawing.Font("Ekkamai Standard", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.Name = "frmReportSale"
        Me.Text = "frmReportSale"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ctrv1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
