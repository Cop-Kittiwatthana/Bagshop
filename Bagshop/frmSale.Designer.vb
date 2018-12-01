<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSale
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbUser = New System.Windows.Forms.ComboBox()
        Me.dtsale = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtMID = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtPID = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtsale = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtMNa = New System.Windows.Forms.TextBox()
        Me.txtPNa = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.btAdd = New System.Windows.Forms.Button()
        Me.btRemove = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgvProduct = New System.Windows.Forms.DataGridView()
        Me.dgvSale = New System.Windows.Forms.DataGridView()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblSum = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Gid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Gname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Gprice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Gamount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Gnum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvSale, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ชื่อพนักงาน"
        '
        'cmbUser
        '
        Me.cmbUser.FormattingEnabled = True
        Me.cmbUser.Location = New System.Drawing.Point(123, 43)
        Me.cmbUser.Name = "cmbUser"
        Me.cmbUser.Size = New System.Drawing.Size(153, 32)
        Me.cmbUser.TabIndex = 1
        '
        'dtsale
        '
        Me.dtsale.Location = New System.Drawing.Point(123, 101)
        Me.dtsale.Name = "dtsale"
        Me.dtsale.Size = New System.Drawing.Size(213, 29)
        Me.dtsale.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 24)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "วันที่ขาย"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 187)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 24)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "รหัสลูกค้า"
        '
        'txtMID
        '
        Me.txtMID.Location = New System.Drawing.Point(123, 187)
        Me.txtMID.Name = "txtMID"
        Me.txtMID.Size = New System.Drawing.Size(171, 29)
        Me.txtMID.TabIndex = 5
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(320, 188)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(39, 29)
        Me.btnSearch.TabIndex = 6
        Me.btnSearch.Text = "..."
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtPID
        '
        Me.txtPID.Location = New System.Drawing.Point(123, 254)
        Me.txtPID.Name = "txtPID"
        Me.txtPID.Size = New System.Drawing.Size(171, 29)
        Me.txtPID.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 254)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 24)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "รหัสกระเป๋า"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(23, 316)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 24)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "ราคาขาย"
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(123, 313)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(128, 29)
        Me.txtPrice.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(5, 374)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 24)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "จำนวนที่ขาย"
        '
        'txtsale
        '
        Me.txtsale.Location = New System.Drawing.Point(123, 374)
        Me.txtsale.Name = "txtsale"
        Me.txtsale.Size = New System.Drawing.Size(128, 29)
        Me.txtsale.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(402, 191)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 24)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "ชื่อสกุล"
        '
        'txtMNa
        '
        Me.txtMNa.Location = New System.Drawing.Point(469, 188)
        Me.txtMNa.Name = "txtMNa"
        Me.txtMNa.Size = New System.Drawing.Size(171, 29)
        Me.txtMNa.TabIndex = 14
        '
        'txtPNa
        '
        Me.txtPNa.Location = New System.Drawing.Point(469, 249)
        Me.txtPNa.Name = "txtPNa"
        Me.txtPNa.Size = New System.Drawing.Size(171, 29)
        Me.txtPNa.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(380, 254)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 24)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "ชื่อกระเป๋า"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(347, 316)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(114, 24)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "จำนวนคงเหลือ"
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(469, 313)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(171, 29)
        Me.txtAmount.TabIndex = 18
        '
        'btAdd
        '
        Me.btAdd.Location = New System.Drawing.Point(320, 374)
        Me.btAdd.Name = "btAdd"
        Me.btAdd.Size = New System.Drawing.Size(132, 38)
        Me.btAdd.TabIndex = 19
        Me.btAdd.Text = "เพิ่มรายการ"
        Me.btAdd.UseVisualStyleBackColor = True
        '
        'btRemove
        '
        Me.btRemove.Location = New System.Drawing.Point(508, 370)
        Me.btRemove.Name = "btRemove"
        Me.btRemove.Size = New System.Drawing.Size(132, 38)
        Me.btRemove.TabIndex = 20
        Me.btRemove.Text = "ลบรายการ"
        Me.btRemove.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btRemove)
        Me.GroupBox1.Controls.Add(Me.btAdd)
        Me.GroupBox1.Controls.Add(Me.txtAmount)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtPNa)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtMNa)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtsale)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtPrice)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtPID)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.btnSearch)
        Me.GroupBox1.Controls.Add(Me.txtMID)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.dtsale)
        Me.GroupBox1.Controls.Add(Me.cmbUser)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(20, 17)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(681, 461)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ข้อมูลการขาย"
        '
        'dgvProduct
        '
        Me.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProduct.Location = New System.Drawing.Point(726, 30)
        Me.dgvProduct.Name = "dgvProduct"
        Me.dgvProduct.Size = New System.Drawing.Size(326, 438)
        Me.dgvProduct.TabIndex = 22
        '
        'dgvSale
        '
        Me.dgvSale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSale.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Gid, Me.Gname, Me.Gprice, Me.Gamount, Me.Gnum})
        Me.dgvSale.Location = New System.Drawing.Point(20, 497)
        Me.dgvSale.Name = "dgvSale"
        Me.dgvSale.Size = New System.Drawing.Size(1032, 216)
        Me.dgvSale.TabIndex = 23
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(22, 730)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(92, 29)
        Me.txtID.TabIndex = 24
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(382, 780)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(73, 33)
        Me.btnExit.TabIndex = 34
        Me.btnExit.Text = "ออก"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btncancel
        '
        Me.btncancel.Location = New System.Drawing.Point(253, 780)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(73, 33)
        Me.btncancel.TabIndex = 33
        Me.btncancel.Text = "ยกเลิก"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(143, 780)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(73, 33)
        Me.btnSave.TabIndex = 32
        Me.btnSave.Text = "บันทึก"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(20, 780)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(73, 33)
        Me.btnAdd.TabIndex = 31
        Me.btnAdd.Text = "เพิ่ม"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(528, 780)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(132, 33)
        Me.btnPrint.TabIndex = 35
        Me.btnPrint.Text = "พิมพ์ใบเสร็จ"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(756, 780)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(67, 24)
        Me.Label10.TabIndex = 36
        Me.Label10.Text = "รวมยอด"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(971, 780)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(41, 24)
        Me.Label11.TabIndex = 37
        Me.Label11.Text = "บาท"
        '
        'lblSum
        '
        Me.lblSum.AutoSize = True
        Me.lblSum.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblSum.Location = New System.Drawing.Point(870, 780)
        Me.lblSum.Name = "lblSum"
        Me.lblSum.Size = New System.Drawing.Size(71, 31)
        Me.lblSum.TabIndex = 38
        Me.lblSum.Text = "0.00"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(124, 730)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(39, 29)
        Me.Button5.TabIndex = 21
        Me.Button5.Text = "..."
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Gid
        '
        Me.Gid.HeaderText = "รหัสสินค้า"
        Me.Gid.Name = "Gid"
        Me.Gid.Width = 150
        '
        'Gname
        '
        Me.Gname.HeaderText = "ชื่อสินค้า"
        Me.Gname.Name = "Gname"
        Me.Gname.Width = 200
        '
        'Gprice
        '
        Me.Gprice.HeaderText = "ราคา"
        Me.Gprice.Name = "Gprice"
        Me.Gprice.Width = 120
        '
        'Gamount
        '
        Me.Gamount.HeaderText = "จำนวนที่ขาย"
        Me.Gamount.Name = "Gamount"
        Me.Gamount.Width = 150
        '
        'Gnum
        '
        Me.Gnum.HeaderText = "รวม"
        Me.Gnum.Name = "Gnum"
        Me.Gnum.Width = 150
        '
        'frmSale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1085, 835)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.lblSum)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.dgvSale)
        Me.Controls.Add(Me.dgvProduct)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "frmSale"
        Me.Text = "จัดการข้อมูลการขาย"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvProduct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvSale, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbUser As System.Windows.Forms.ComboBox
    Friend WithEvents dtsale As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtMID As System.Windows.Forms.TextBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents txtPID As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtsale As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtMNa As System.Windows.Forms.TextBox
    Friend WithEvents txtPNa As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents btAdd As System.Windows.Forms.Button
    Friend WithEvents btRemove As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvProduct As System.Windows.Forms.DataGridView
    Friend WithEvents dgvSale As System.Windows.Forms.DataGridView
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lblSum As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Gid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Gname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Gprice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Gamount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Gnum As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
