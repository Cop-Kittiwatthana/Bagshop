<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Report
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
        Me.cmbreport = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmbreport
        '
        Me.cmbreport.Font = New System.Drawing.Font("Ekkamai Standard", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmbreport.FormattingEnabled = True
        Me.cmbreport.Location = New System.Drawing.Point(34, 36)
        Me.cmbreport.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.cmbreport.Name = "cmbreport"
        Me.cmbreport.Size = New System.Drawing.Size(302, 32)
        Me.cmbreport.TabIndex = 17
        Me.cmbreport.Text = "รายงาน"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(124, 107)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(117, 39)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "รายงาน"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(370, 184)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cmbreport)
        Me.Font = New System.Drawing.Font("Ekkamai Standard", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Name = "Report"
        Me.Text = "Report"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmbreport As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
