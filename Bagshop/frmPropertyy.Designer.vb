﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPropertyy
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
        Me.dgvPropertyy = New System.Windows.Forms.DataGridView()
        CType(Me.dgvPropertyy, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvPropertyy
        '
        Me.dgvPropertyy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPropertyy.Location = New System.Drawing.Point(38, 33)
        Me.dgvPropertyy.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgvPropertyy.Name = "dgvPropertyy"
        Me.dgvPropertyy.Size = New System.Drawing.Size(445, 662)
        Me.dgvPropertyy.TabIndex = 39
        '
        'frmPropertyy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(546, 730)
        Me.Controls.Add(Me.dgvPropertyy)
        Me.Font = New System.Drawing.Font("Ekkamai Standard", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.Name = "frmPropertyy"
        Me.Text = "จัดการข้อมูลสีและจำนวน"
        CType(Me.dgvPropertyy, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvPropertyy As System.Windows.Forms.DataGridView
End Class
