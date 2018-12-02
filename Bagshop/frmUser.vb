Imports System.Data.SqlClient
Public Class frmUser
    Public pk, PKK As String
    Dim save_status As String
    Sub clear()
        txtID.Text = ""
        txtAdd.Text = ""
        txtNa.Text = ""
        txtPass.Text = ""
        txtTel.Text = ""
        txtUser.Text = ""
        cmbSex.Text = ""
        rbtStatus0.Checked = False
        rbtStatus1.Checked = False
        rbtStatus0.Enabled = False
        rbtStatus1.Enabled = False
    End Sub
    Private Sub frmUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtAdd.Enabled = False
        txtNa.Enabled = False
        txtPass.Enabled = False
        txtTel.Enabled = False
        txtAdd.Enabled = False
        txtUser.Enabled = False
        If Ed = "1" Then
            btnAdd.Enabled = False
        Else
            btnAdd.Enabled = True
        End If
        btnEdit.Enabled = False
        btnDelete.Enabled = False
        btnSave.Enabled = False
        btncancel.Enabled = True
        btnExit.Enabled = True
        rbtStatus0.Enabled = False
        rbtStatus1.Enabled = False
        cmbSex.Enabled = False
        cmbSex.Items.Add("ชาย")
        cmbSex.Items.Add("หญิง")
        showData()
    End Sub

    Sub showData()
        Dim sql As String
        Dim da As SqlDataAdapter
        ' If Ed = "1" Then
        'sql = "SELECT U_ID,U_User,U_Name,U_status FROM Userr where U_User = '" & txtUser.Text & "'"
        'Else
        sql = "SELECT U_ID,U_User,U_Name,U_status,U_User FROM Userr"
        'End If
        Module1.Connect()
        Dim ds As New DataSet
        da = New SqlDataAdapter(sql, Conn)
        da.Fill(ds, "Userr")
        dgvUserr.ReadOnly = True
        dgvUserr.DataSource = ds.Tables("Userr")
        For r As Integer = 0 To dgvUserr.Rows.Count - 2
            If dgvUserr.Rows(r).Cells(3).Value.ToString = "0" Then
                dgvUserr.Rows(r).Cells(3).Value = "ผู้ดูเเลระบบ"
            Else
                dgvUserr.Rows(r).Cells(3).Value = "พนักงาน"
            End If
        Next
        dgvUserr.Columns(0).HeaderText = "รหัสพนักงาน"
        dgvUserr.Columns(0).Width = 100
        dgvUserr.Columns(1).HeaderText = "Usename"
        dgvUserr.Columns(1).Width = 130
        dgvUserr.Columns(2).HeaderText = "ชื่อ-นามสกุล"
        dgvUserr.Columns(2).Width = 180
        dgvUserr.Columns(3).HeaderText = "ระดับ"
        dgvUserr.Columns(3).Width = 100
        dgvUserr.Columns(4).Width = 100

    End Sub
    
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim Sql As String
        Dim key_Gen As String = ""
        Dim sqlDr As SqlDataReader
        Dim sqlCmd As SqlCommand

        Module1.Connect()
        Sql = "SELECT MAX(U_ID)From Userr"
        sqlCmd = New SqlCommand(Sql, Conn)                          'สร้าง sqlCmd โดยให้เก็บคำสั้่งที่อยู่ใน sql 
        sqlDr = sqlCmd.ExecuteReader                                'ประมวลผลคำสั้ง และ นำผลลัพธ์เก็บไว้ใน sqlDr
        If sqlDr.Read() Then                                        'ตรวจสอบว่าอ่านข้อมูลได้ จะเข้าไปทำในเงื่อนไข
            If sqlDr.IsDBNull(0) Then                               'ตรวจสอบว่าได้ค่าว่าง จะเข้าไปทำ
                key_Gen = "U001"                                    'กำหนดให้ key_Gen เริ่มที่E001
            Else                                                    'ในกรณีที่อ่านแล้วได้ข้อมูล จะมาทำตรงนี้
                key_Gen = sqlDr.Item(0)                             'กำหนดให้key_Genเม่ากับค่าที่อ่นขึ้นมาได้ เช่น E001                           
                key_Gen = Trim(key_Gen)                             'ตัดช่องว่างในkey_Gen ทั้งหมด
                key_Gen = Strings.Right(key_Gen, 3)                 'ตัดข้อมูลจากทางขวามา3 หลัก จะได้ 001
                key_Gen = CInt(key_Gen) + 1                         'นำข้อมูลมาแปลเป็น int แล้วบวกเพิ่มอีก1 จะได้2
                key_Gen = Strings.Right(("00" & key_Gen), 3)        'นำข้อมูลที่บวกแล้วมาเติม0ด้านหน้าให้ครบ3 
                key_Gen = "U" & key_Gen                             'นำข้อมูลเติม 0 แล้วมาใว่ E ด้านหน้า จะกลายเป็น E002
            End If
        End If
        sqlDr.Close()       'ใช่เสร็จแล้วต้องปิด   
        clear()
        txtID.Text = key_Gen
        txtID.Enabled = False
        txtUser.Enabled = True
        txtPass.Enabled = True
        txtNa.Enabled = True
        txtAdd.Enabled = True
        txtTel.Enabled = True
        btnAdd.Enabled = False
        btnEdit.Enabled = False
        btnDelete.Enabled = False
        btnSave.Enabled = True
        btncancel.Enabled = True
        btnExit.Enabled = True
        rbtStatus0.Enabled = True
        rbtStatus1.Enabled = True
        cmbSex.Enabled = True
        save_status = "Add"
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        txtUser.Enabled = True
        txtPass.Enabled = True
        txtNa.Enabled = True
        txtAdd.Enabled = True
        txtTel.Enabled = True
        btnAdd.Enabled = False
        btnEdit.Enabled = False
        btnDelete.Enabled = False
        btnSave.Enabled = True
        btncancel.Enabled = True
        btnExit.Enabled = True
        rbtStatus0.Enabled = True
        rbtStatus1.Enabled = True
        If Ed = "1" Then
            rbtStatus0.Enabled = False
            rbtStatus1.Enabled = False
        Else
            rbtStatus0.Enabled = True
            rbtStatus1.Enabled = True
        End If
        cmbSex.Enabled = True
        save_status = "Edit"
    End Sub

    Private Sub btnSeve_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim sql As String
        Dim sqlCmd As SqlCommand
        Dim level As String
        Dim Sex As String
        Dim sqlDr As SqlDataReader
        If txtAdd.TextLength = 0 Or txtNa.TextLength = 0 Or txtPass.TextLength = 0 Or txtTel.TextLength = 0 Or rbtStatus0.Checked = False And rbtStatus1.Checked = False Then
            MessageBox.Show("กรุณากรอกข้อมูลให้ครบ", "ผิดผลาด", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        If save_status = "Add" Or save_status = "Edit" Then
            If txtNa.Text <> pk Then
                sql = "SELECT U_Name FROM Userr WHERE U_Name ='" & txtNa.Text & "'"
                sqlCmd = New SqlCommand(sql, Conn)
                sqlDr = sqlCmd.ExecuteReader
                If sqlDr.Read() Then
                    MessageBox.Show("ชื่อพนักงานซ้ำ", "ตรวจสอบ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtNa.Focus()
                    sqlDr.Close()
                    Exit Sub
                End If
                sqlDr.Close()
            End If
            If txtUser.Text <> PKK Then
                sql = "SELECT U_User FROM Userr WHERE U_User ='" & txtUser.Text & "'"
                sqlCmd = New SqlCommand(sql, Conn)
                sqlDr = sqlCmd.ExecuteReader
                If sqlDr.Read() Then
                    MessageBox.Show("ชื่อผู้ใช้ซ้ำ", "ตรวจสอบ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtNa.Focus()
                    sqlDr.Close()
                    Exit Sub
                End If
                sqlDr.Close()
            End If
        End If
        If cmbSex.SelectedIndex = 0 Then
            Sex = "ช"
        ElseIf cmbSex.SelectedIndex = 1 Then
            Sex = "ญ"
        Else
            MessageBox.Show("กรุณาเลือกเพศ")
        End If
        If rbtStatus0.Checked = True Then
            level = "0"
        End If
        If rbtStatus1.Checked = True Then
            level = "1"
        End If
        If save_status = "Add" Then
            sql = "INSERT INTO Userr(U_ID,U_User, U_Pass, U_Name, U_Add, U_Tel,U_Sex, U_Status)"
            sql &= "VALUES ('" & txtID.Text & "','" & txtUser.Text & "','" & txtPass.Text & "','" & txtNa.Text & "','" & txtAdd.Text & "','" & txtTel.Text & "','" & Sex & "','" & level & "')"
        End If
        If save_status = "Edit" Then
            sql = "UPDATE Userr set U_User= '" & txtUser.Text & "',U_ID= '" & txtID.Text & "', U_Pass = '" & txtPass.Text & "', U_Name = '" & txtNa.Text & "', U_Add = '" & txtAdd.Text & "', U_Tel = '" & txtTel.Text & "', U_Sex = '" & Sex & "' , U_Status = '" & level & "'"
            sql &= "WHERE U_ID = '" & txtID.Text & "'"
        End If
        sqlCmd = New SqlCommand(sql, Conn)
        sqlCmd.ExecuteNonQuery()
        Conn.Close()
        MessageBox.Show("บันทึกข้อมูลเรียบร้อยแล้ว", "ยืนยันการบันทึก", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        clear()
        txtAdd.Enabled = False
        txtNa.Enabled = False
        txtPass.Enabled = False
        txtTel.Enabled = False
        txtAdd.Enabled = False
        btnAdd.Enabled = True
        btnEdit.Enabled = False
        btnDelete.Enabled = False
        btnSave.Enabled = False
        btncancel.Enabled = False
        btnExit.Enabled = True
        cmbSex.Enabled = False
        showData()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim sql As String
        Dim sqlCmd As SqlCommand
        If (MessageBox.Show("คุณต้องการลบข้อมูลนี้ใช่หรือไม่", "ยืนยันการลบข้อมูล", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)) = Windows.Forms.DialogResult.OK Then
            sql = "DELETE FROM Userr WHERE U_ID = '" & txtID.Text & "'   "
            sqlCmd = New SqlCommand(sql, Conn)
            sqlCmd.ExecuteNonQuery()
            MessageBox.Show("ลบข้อมูลเรียบร้อย", "ผลการลบข้อมูล", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        clear()
        txtUser.Enabled = False
        txtPass.Enabled = False
        txtNa.Enabled = False
        txtAdd.Enabled = False
        txtTel.Enabled = False
        btnAdd.Enabled = True
        btnEdit.Enabled = False
        btnDelete.Enabled = False
        btnSave.Enabled = False
        btncancel.Enabled = True
        btnExit.Enabled = True
        showData()
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        clear()
        txtAdd.Enabled = False
        txtNa.Enabled = False
        txtPass.Enabled = False
        txtTel.Enabled = False
        txtAdd.Enabled = False
        txtUser.Enabled = False
        If Ed = "1" Then
            btnAdd.Enabled = False
        Else
            btnAdd.Enabled = True
        End If
        btnEdit.Enabled = False
        btnDelete.Enabled = False
        btnSave.Enabled = False
        btncancel.Enabled = True
        btnExit.Enabled = True
        cmbSex.Enabled = False
        showData()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub dgvUserr_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvUserr.CellContentClick

    End Sub

    Private Sub dgvUserr_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvUserr.CellContentDoubleClick
        Dim sql As String
        Dim sqlDr As SqlDataReader
        Dim sqlCmd As SqlCommand
        txtUser.Text = dgvUserr.Rows(e.RowIndex).Cells(1).Value
        PKK = dgvUserr.Rows(e.RowIndex).Cells(1).Value
        pk = dgvUserr.Rows(e.RowIndex).Cells(2).Value
        txtNa.Text = dgvUserr.Rows(e.RowIndex).Cells(2).Value
        If dgvUserr.Rows(e.RowIndex).Cells(3).Value = "ผู้ดูเเลระบบ" Then
            rbtStatus0.Checked = True
        Else
            rbtStatus1.Checked = True
        End If
        sql = "Select U_ID,U_Pass,U_Add,U_Tel,U_Sex,U_User FROM Userr WHERE U_User = '" & txtUser.Text & "'"
        sqlCmd = New SqlCommand(sql, Conn)
        sqlDr = sqlCmd.ExecuteReader
        If sqlDr.Read() Then
            txtID.Text = sqlDr.Item(0)
            txtPass.Text = sqlDr.Item(1)
            txtAdd.Text = sqlDr.Item(2)
            txtTel.Text = sqlDr.Item(3)
            If sqlDr.Item(4) = "ช" Then
                cmbSex.SelectedIndex = 0
            Else
                cmbSex.SelectedIndex = 1
            End If
            txtUser.Text = sqlDr.Item(5)
        End If
        sqlDr.Close()
        txtAdd.Enabled = False
        txtNa.Enabled = False
        txtPass.Enabled = False
        txtTel.Enabled = False
        txtAdd.Enabled = False
        btnAdd.Enabled = False
        btnEdit.Enabled = True
        btnDelete.Enabled = True
        If Ed = "1" Then
            btnDelete.Enabled = False
        Else
            btnDelete.Enabled = True
        End If
        btnSave.Enabled = False
        btncancel.Enabled = True
        btnExit.Enabled = True
        showData()
    End Sub

    Private Sub txtNa_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNa.KeyPress
        Select Case Asc(e.KeyChar)
            Case 58 To 122 ' โค๊ดภาษาอังกฤษ์ตามจริงจะอยู่ที่ 58ถึง122 
                e.Handled = False
            Case 8, 13, 32
                e.Handled = False
            Case 161 To 240 ' แล้วมาใส่ตรงนี้เป็นคีย์โค๊ดภาษาไทยรวมทั้งตัวสระ+วรรณยุกต์ด้วยน่ะครับ
                e.Handled = False
            Case Else
                e.Handled = True
                MessageBox.Show("กรุณาระบุข้อมูลเป็นภาษาอังกฤษหรือภาษาไทย")
        End Select
    End Sub

    Private Sub txtTel_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTel.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57
                e.Handled = False
            Case 8, 13, 45
                e.Handled = False
            Case Else
                e.Handled = True
                MessageBox.Show("กรุณาระบุข้อมูลเป็นตัวเลข")
        End Select
    End Sub

    Private Sub frmUser_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If MessageBox.Show("คุณต้องการออกจากโปรแกรมหรือไม่?", "Exit Program", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.OK Then
            e.Cancel = False
        Else
            e.Cancel = True
        End If
    End Sub


End Class