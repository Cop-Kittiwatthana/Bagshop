<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.txtColor = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPNa = New System.Windows.Forms.TextBox()
        Me.dgvProduct = New System.Windows.Forms.DataGridView()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtNum = New System.Windows.Forms.TextBox()
        Me.dgvProperty = New System.Windows.Forms.DataGridView()
        Me.txtPID = New System.Windows.Forms.TextBox()
        Me.ptb1 = New System.Windows.Forms.PictureBox()
        CType(Me.dgvProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvProperty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptb1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtColor
        '
        Me.txtColor.Location = New System.Drawing.Point(146, 206)
        Me.txtColor.Name = "txtColor"
        Me.txtColor.Size = New System.Drawing.Size(100, 30)
        Me.txtColor.TabIndex = 40
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(105, 204)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 32)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "สี"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(306, 199)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 32)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "จำนวน"
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(387, 201)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(100, 30)
        Me.txtAmount.TabIndex = 43
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 32)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "รหัสสินค้า"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 118)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 32)
        Me.Label4.TabIndex = 47
        Me.Label4.Text = "ชื่อสินค้า"
        '
        'txtPNa
        '
        Me.txtPNa.Location = New System.Drawing.Point(135, 120)
        Me.txtPNa.Name = "txtPNa"
        Me.txtPNa.Size = New System.Drawing.Size(298, 30)
        Me.txtPNa.TabIndex = 46
        '
        'dgvProduct
        '
        Me.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProduct.Location = New System.Drawing.Point(747, 12)
        Me.dgvProduct.Name = "dgvProduct"
        Me.dgvProduct.Size = New System.Drawing.Size(347, 518)
        Me.dgvProduct.TabIndex = 50
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(565, 282)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(73, 44)
        Me.btnExit.TabIndex = 56
        Me.btnExit.Text = "ออก"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btncancel
        '
        Me.btncancel.Location = New System.Drawing.Point(446, 282)
        Me.btncancel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(86, 44)
        Me.btncancel.TabIndex = 55
        Me.btncancel.Text = "ยกเลิก"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(226, 282)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(84, 44)
        Me.btnSave.TabIndex = 54
        Me.btnSave.Text = "บันทึก"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(122, 282)
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(73, 44)
        Me.btnEdit.TabIndex = 52
        Me.btnEdit.Text = "แก้ไข"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(336, 282)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(73, 44)
        Me.btnDelete.TabIndex = 53
        Me.btnDelete.Text = "ลบ"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(22, 282)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(73, 44)
        Me.btnAdd.TabIndex = 51
        Me.btnAdd.Text = "เพิ่ม"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'txtNum
        '
        Me.txtNum.Location = New System.Drawing.Point(401, 66)
        Me.txtNum.Name = "txtNum"
        Me.txtNum.Size = New System.Drawing.Size(100, 30)
        Me.txtNum.TabIndex = 57
        '
        'dgvProperty
        '
        Me.dgvProperty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProperty.Location = New System.Drawing.Point(19, 354)
        Me.dgvProperty.Name = "dgvProperty"
        Me.dgvProperty.Size = New System.Drawing.Size(721, 176)
        Me.dgvProperty.TabIndex = 58
        '
        'txtPID
        '
        Me.txtPID.Location = New System.Drawing.Point(135, 66)
        Me.txtPID.Name = "txtPID"
        Me.txtPID.Size = New System.Drawing.Size(205, 30)
        Me.txtPID.TabIndex = 59
        '
        'ptb1
        '
        Me.ptb1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ptb1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ptb1.Location = New System.Drawing.Point(525, 12)
        Me.ptb1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ptb1.Name = "ptb1"
        Me.ptb1.Size = New System.Drawing.Size(215, 253)
        Me.ptb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptb1.TabIndex = 60
        Me.ptb1.TabStop = False
        '
        'frmPropertyy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1121, 556)
        Me.Controls.Add(Me.ptb1)
        Me.Controls.Add(Me.txtPID)
        Me.Controls.Add(Me.dgvProperty)
        Me.Controls.Add(Me.txtNum)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.dgvProduct)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtPNa)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtColor)
        Me.Font = New System.Drawing.Font("Ekkamai Standard", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.Name = "frmPropertyy"
        Me.Text = "จัดการข้อมูลสีและจำนวน"
        CType(Me.dgvProduct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvProperty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptb1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtColor As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtPNa As System.Windows.Forms.TextBox
    Friend WithEvents dgvProduct As System.Windows.Forms.DataGridView
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents txtNum As System.Windows.Forms.TextBox
    Friend WithEvents dgvProperty As System.Windows.Forms.DataGridView
    Friend WithEvents txtPID As System.Windows.Forms.TextBox
    Friend WithEvents ptb1 As System.Windows.Forms.PictureBox
End Class
