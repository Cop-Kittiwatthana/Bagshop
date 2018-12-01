<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUser
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNa = New System.Windows.Forms.TextBox()
        Me.txtAdd = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbSex = New System.Windows.Forms.ComboBox()
        Me.txtTel = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.rbtStatus0 = New System.Windows.Forms.RadioButton()
        Me.rbtStatus1 = New System.Windows.Forms.RadioButton()
        Me.dgvUserr = New System.Windows.Forms.DataGridView()
        CType(Me.dgvUserr, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(58, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(58, 124)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password"
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(189, 59)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(223, 29)
        Me.txtUser.TabIndex = 2
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(189, 121)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(223, 29)
        Me.txtPass.TabIndex = 3
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(521, 59)
        Me.txtID.Name = "txtID"
        Me.txtID.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(100, 29)
        Me.txtID.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(81, 260)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 24)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "ที่อยู่"
        '
        'txtNa
        '
        Me.txtNa.Location = New System.Drawing.Point(189, 196)
        Me.txtNa.Name = "txtNa"
        Me.txtNa.Size = New System.Drawing.Size(223, 29)
        Me.txtNa.TabIndex = 7
        '
        'txtAdd
        '
        Me.txtAdd.Location = New System.Drawing.Point(189, 260)
        Me.txtAdd.Multiline = True
        Me.txtAdd.Name = "txtAdd"
        Me.txtAdd.Size = New System.Drawing.Size(223, 111)
        Me.txtAdd.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(58, 196)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 24)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "ชื่อ-สกุล"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(479, 201)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 24)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "เพศ"
        '
        'cmbSex
        '
        Me.cmbSex.FormattingEnabled = True
        Me.cmbSex.Location = New System.Drawing.Point(533, 201)
        Me.cmbSex.Name = "cmbSex"
        Me.cmbSex.Size = New System.Drawing.Size(88, 32)
        Me.cmbSex.TabIndex = 11
        '
        'txtTel
        '
        Me.txtTel.Location = New System.Drawing.Point(189, 411)
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(223, 29)
        Me.txtTel.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(58, 411)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 24)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "เบอร์โทร"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(38, 546)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(80, 34)
        Me.btnAdd.TabIndex = 14
        Me.btnAdd.Text = "เพิ่ม"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(338, 546)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(80, 34)
        Me.btnDelete.TabIndex = 15
        Me.btnDelete.Text = "ลบ"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(140, 546)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(80, 34)
        Me.btnEdit.TabIndex = 15
        Me.btnEdit.Text = "แก้ไข"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(239, 546)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(80, 34)
        Me.btnSave.TabIndex = 16
        Me.btnSave.Text = "บันทึก"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btncancel
        '
        Me.btncancel.Location = New System.Drawing.Point(440, 546)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(80, 34)
        Me.btncancel.TabIndex = 17
        Me.btncancel.Text = "ยกเลิก"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(537, 546)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(80, 34)
        Me.btnExit.TabIndex = 18
        Me.btnExit.Text = "ออก"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(58, 478)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 24)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "ระดับ"
        '
        'rbtStatus0
        '
        Me.rbtStatus0.AutoSize = True
        Me.rbtStatus0.Location = New System.Drawing.Point(179, 478)
        Me.rbtStatus0.Name = "rbtStatus0"
        Me.rbtStatus0.Size = New System.Drawing.Size(108, 28)
        Me.rbtStatus0.TabIndex = 20
        Me.rbtStatus0.TabStop = True
        Me.rbtStatus0.Text = "ผู้ดูแลระบบ"
        Me.rbtStatus0.UseVisualStyleBackColor = True
        '
        'rbtStatus1
        '
        Me.rbtStatus1.AutoSize = True
        Me.rbtStatus1.Location = New System.Drawing.Point(324, 478)
        Me.rbtStatus1.Name = "rbtStatus1"
        Me.rbtStatus1.Size = New System.Drawing.Size(91, 28)
        Me.rbtStatus1.TabIndex = 21
        Me.rbtStatus1.TabStop = True
        Me.rbtStatus1.Text = "พนักงาน"
        Me.rbtStatus1.UseVisualStyleBackColor = True
        '
        'dgvUserr
        '
        Me.dgvUserr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUserr.Location = New System.Drawing.Point(37, 611)
        Me.dgvUserr.Name = "dgvUserr"
        Me.dgvUserr.Size = New System.Drawing.Size(580, 165)
        Me.dgvUserr.TabIndex = 22
        '
        'frmUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(666, 801)
        Me.Controls.Add(Me.dgvUserr)
        Me.Controls.Add(Me.rbtStatus1)
        Me.Controls.Add(Me.rbtStatus0)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtTel)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmbSex)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtAdd)
        Me.Controls.Add(Me.txtNa)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "frmUser"
        Me.Text = "ข้อมูลผู้ใช้ระบบ"
        CType(Me.dgvUserr, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtUser As System.Windows.Forms.TextBox
    Friend WithEvents txtPass As System.Windows.Forms.TextBox
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtNa As System.Windows.Forms.TextBox
    Friend WithEvents txtAdd As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbSex As System.Windows.Forms.ComboBox
    Friend WithEvents txtTel As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents rbtStatus0 As System.Windows.Forms.RadioButton
    Friend WithEvents rbtStatus1 As System.Windows.Forms.RadioButton
    Friend WithEvents dgvUserr As System.Windows.Forms.DataGridView
End Class
