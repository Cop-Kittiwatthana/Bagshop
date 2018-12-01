Imports System.Data.SqlClient
Public Class frmCategory
    Dim save_status As String
    Private Sub frmCategory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtID.Enabled = False
        txtNa.Enabled = False
        btnAdd.Enabled = True
        btnEdit.Enabled = False
        btnDelete.Enabled = False
        btnSave.Enabled = False
        btncancel.Enabled = True
        btnExit.Enabled = True
        showData()
    End Sub


    Sub showData()
        Dim sql As String
        Dim da As SqlDataAdapter
        Dim ds As New DataSet
        Module1.Connect()
        sql = "Select * From Category "

        da = New SqlDataAdapter(sql, Conn)
        da.Fill(ds, "Cate")
        dgvCate.ReadOnly = True
        dgvCate.DataSource = ds.Tables("Cate")

        dgvCate.Columns(0).HeaderText = "รหัสหมวดหมู่"
        dgvCate.Columns(0).Width = 200
        dgvCate.Columns(1).HeaderText = "ชื่อหมวดหมู่"
        dgvCate.Columns(1).Width = 200
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim Sql As String
        Dim key_Gen As String = ""
        Dim sqlDr As SqlDataReader
        Dim sqlCmd As SqlCommand

        Module1.Connect()
        Sql = "SELECT MAX(C_ID)From Category"
        sqlCmd = New SqlCommand(Sql, Conn)                          'สร้าง sqlCmd โดยให้เก็บคำสั้่งที่อยู่ใน sql 
        sqlDr = sqlCmd.ExecuteReader                                'ประมวลผลคำสั้ง และ นำผลลัพธ์เก็บไว้ใน sqlDr
        If sqlDr.Read() Then                                        'ตรวจสอบว่าอ่านข้อมูลได้ จะเข้าไปทำในเงื่อนไข
            If sqlDr.IsDBNull(0) Then                               'ตรวจสอบว่าได้ค่าว่าง จะเข้าไปทำ
                key_Gen = "C001"                                    'กำหนดให้ key_Gen เริ่มที่E001
            Else                                                    'ในกรณีที่อ่านแล้วได้ข้อมูล จะมาทำตรงนี้
                key_Gen = sqlDr.Item(0)                             'กำหนดให้key_Genเม่ากับค่าที่อ่นขึ้นมาได้ เช่น E001                           
                key_Gen = Trim(key_Gen)                             'ตัดช่องว่างในkey_Gen ทั้งหมด
                key_Gen = Strings.Right(key_Gen, 3)                 'ตัดข้อมูลจากทางขวามา3 หลัก จะได้ 001
                key_Gen = CInt(key_Gen) + 1                         'นำข้อมูลมาแปลเป็น int แล้วบวกเพิ่มอีก1 จะได้2
                key_Gen = Strings.Right(("00" & key_Gen), 3)        'นำข้อมูลที่บวกแล้วมาเติม0ด้านหน้าให้ครบ3 
                key_Gen = "C" & key_Gen                             'นำข้อมูลเติม 0 แล้วมาใว่ E ด้านหน้า จะกลายเป็น E002
            End If
        End If
        sqlDr.Close()       'ใช่เสร็จแล้วต้องปิด   
        txtID.Text = key_Gen
        txtID.Enabled = False
        txtNa.Enabled = True
        btnAdd.Enabled = False
        btnEdit.Enabled = False
        btnDelete.Enabled = False
        btnSave.Enabled = True
        btncancel.Enabled = True
        btnExit.Enabled = True
        save_status = "Add"
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        txtID.Enabled = False
        txtNa.Enabled = True
        btnAdd.Enabled = False
        btnEdit.Enabled = False
        btnDelete.Enabled = False
        btnSave.Enabled = True
        btncancel.Enabled = True
        btnExit.Enabled = True
        save_status = "Edit"
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim sql As String
        Dim sqlCmd As SqlCommand
        Dim sqlDr As SqlDataReader

        If txtNa.Text = "" Then
            MessageBox.Show("กรุณาป้อนข้อมูล", "ตรวจสอบ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtNa.Focus()
            Exit Sub
        End If
        If save_status = "Add" Or save_status = "Edit" Then
            sql = "SELECT C_Name FROM Category WHERE C_Name ='" & txtNa.Text & "'"
            sqlCmd = New SqlCommand(sql, Conn)
            sqlDr = sqlCmd.ExecuteReader
            If sqlDr.Read() Then
                MessageBox.Show("ชื่อหมวดหมู่ ซ้ำ กรุณากรอกใหม่", "ตรวจสอบ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtNa.Focus()
                sqlDr.Close()
                Exit Sub
            End If
            sqlDr.Close()
        End If
        If save_status = "Add" Then
            sql = "INSERT INTO Category(C_ID ,C_Name) VALUES ('" & txtID.Text & "','" & txtNa.Text & "')"
        End If

        If save_status = "Edit" Then
            sql = "UPDATE Category set C_Name = '" & txtNa.Text & "'"
            sql &= "WHERE C_ID = '" & txtID.Text & "'"
        End If
        sqlCmd = New SqlCommand(sql, Conn)
        sqlCmd.ExecuteNonQuery() 'ประมวลผลคำสั่ง
        Conn.Close()

        MessageBox.Show("บันทึกข้อมูลเรีบยร้อยแล้ว", "ยืนยันการบันทึก", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        txtID.Text = ""
        txtNa.Text = ""
        txtNa.Enabled = False
        btnAdd.Enabled = True
        btnEdit.Enabled = False
        btnDelete.Enabled = False
        btnSave.Enabled = False
        btncancel.Enabled = True
        btnExit.Enabled = True
        showData()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim sql As String
        Dim sqlCmd As SqlCommand

        If (MessageBox.Show("คุณต้องการลบข้อมูลนี้ใช่หรือไม่", "ยืนยันการลบข้อมูล", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)) = Windows.Forms.DialogResult.OK Then
            sql = "DELETE Category WHERE C_ID = '" & txtID.Text & "'"
            sqlCmd = New SqlCommand(sql, Conn)
            sqlCmd.ExecuteNonQuery()
            MessageBox.Show("ลบข้อมูลเรียบร้อย", "ผลการลบข้อมูล", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        txtID.Text = ""
        txtNa.Text = ""
        txtNa.Enabled = False
        btnAdd.Enabled = True
        btnEdit.Enabled = False
        btnDelete.Enabled = False
        btnSave.Enabled = False
        btncancel.Enabled = True
        btnExit.Enabled = True
        showData()
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        txtID.Text = ""
        txtNa.Text = ""
        txtID.Enabled = False
        txtNa.Enabled = False
        btnAdd.Enabled = True
        btnEdit.Enabled = False
        btnDelete.Enabled = False
        btnSave.Enabled = False
        btncancel.Enabled = True
        btnExit.Enabled = True
        showData()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub dgvCate_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvCate.CellContentClick

    End Sub

    Private Sub dgvCate_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvCate.CellContentDoubleClick
        txtID.Text = dgvCate.Rows(e.RowIndex).Cells(0).Value.ToString
        txtNa.Text = dgvCate.Rows(e.RowIndex).Cells(1).Value.ToString
        txtID.Enabled = False
        txtNa.Enabled = False
        btnAdd.Enabled = False
        btnEdit.Enabled = True
        btnDelete.Enabled = True
        btnSave.Enabled = False
        btncancel.Enabled = True
        btnExit.Enabled = True
    End Sub

    Private Sub frmCategory_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If MessageBox.Show("คุณต้องการออกจากโปรแกรมหรือไม่?", "Exit Program", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.OK Then
            e.Cancel = False
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub txtNa_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNa.KeyPress
        Select Case Asc(e.KeyChar)
            Case 58 To 122 ' โค๊ดภาษาอังกฤษ์ตามจริงจะอยู่ที่ 58ถึง122 
                e.Handled = False
            Case 8, 13, 32
                e.Handled = False
            Case 161 To 240  ' แล้วมาใส่ตรงนี้เป็นคีย์โค๊ดภาษาไทยรวมทั้งตัวสระ'
                e.Handled = False
            Case Else
                e.Handled = True
                MessageBox.Show("กรุณาระบุข้อมูลเป็นภาษาอังกฤษหรือภาษาไทย")
        End Select
    End Sub
End Class