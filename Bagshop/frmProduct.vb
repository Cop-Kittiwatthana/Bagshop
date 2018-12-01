Imports System.Data.SqlClient
Imports System.IO
Public Class frmProduct
    Dim save_status As String
    Public pk, patch As String
    Dim row As Integer
    Dim picdata() As Byte
    Sub clear()
        ptb1.Image = Nothing
        txtID.Text = ""
        txtName.Text = ""
        txtPrice.Text = ""
        txtAmount.Text = ""
        txtDetail.Text = ""
        cmbCate.SelectedIndex = -1
        cmbCate.Text = "กรุณาเลือก"
        txtColor.Text = ""
    End Sub
    Private Sub frmProduct_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim sql As String
        Dim da As SqlDataAdapter
        Dim ds As New DataSet

        Module1.Connect()

        sql = "SELECT C_ID,C_Name FROM Category ORDER BY C_ID"

        da = New SqlDataAdapter(sql, Conn)
        da.Fill(ds, "Category")
        If ds.Tables("Category").Rows.Count <> 0 Then
            cmbCate.DataSource = ds.Tables("Category")
            cmbCate.ValueMember = "C_ID"
            cmbCate.DisplayMember = "C_Name"
        End If

        clear()
        txtID.Enabled = False
        txtName.Enabled = False
        txtPrice.Enabled = False
        txtAmount.Enabled = False
        txtDetail.Enabled = False
        cmbCate.Enabled = False
        txtColor.Enabled = False
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
        sql = "Select distinct P.P_ID,P.P_Name,Pr.Pr_Color,P.P_Price,P.P_Amount,C.C_Name,P.P_Detail From Product P,Category C , Property Pr WHERE P.C_ID = C.C_ID and P.P_ID = Pr.P_ID "
        da = New SqlDataAdapter(sql, Conn)
        da.Fill(ds, "Product")
        dgvProduct.ReadOnly = True
        dgvProduct.DataSource = ds.Tables("Product")


        dgvProduct.Columns(0).HeaderText = "รหัสสินค้า"
        dgvProduct.Columns(0).Width = 80
        dgvProduct.Columns(1).HeaderText = "ชื่อสินค้า"
        dgvProduct.Columns(1).Width = 100
        dgvProduct.Columns(2).HeaderText = "สี"
        dgvProduct.Columns(2).Width = 50
        dgvProduct.Columns(3).HeaderText = "ราคา"
        dgvProduct.Columns(3).Width = 80
        dgvProduct.Columns(4).HeaderText = "จำนวน"
        dgvProduct.Columns(4).Width = 80
        dgvProduct.Columns(5).HeaderText = "ประเภท"
        dgvProduct.Columns(5).Width = 100
        dgvProduct.Columns(6).Visible = True
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim Sql As String
        Dim key_Gen As String = ""
        Dim sqlDr As SqlDataReader
        Dim sqlCmd As SqlCommand

        Module1.Connect()
        Sql = "SELECT MAX(P_ID)From Property"
        sqlCmd = New SqlCommand(Sql, Conn)                          'สร้าง sqlCmd โดยให้เก็บคำสั้่งที่อยู่ใน sql 
        sqlDr = sqlCmd.ExecuteReader                                'ประมวลผลคำสั้ง และ นำผลลัพธ์เก็บไว้ใน sqlDr
        If sqlDr.Read() Then                                        'ตรวจสอบว่าอ่านข้อมูลได้ จะเข้าไปทำในเงื่อนไข
            If sqlDr.IsDBNull(0) Then                               'ตรวจสอบว่าได้ค่าว่าง จะเข้าไปทำ
                key_Gen = "P001"                                    'กำหนดให้ key_Gen เริ่มที่E001
            Else                                                    'ในกรณีที่อ่านแล้วได้ข้อมูล จะมาทำตรงนี้
                key_Gen = sqlDr.Item(0)                             'กำหนดให้key_Genเม่ากับค่าที่อ่นขึ้นมาได้ เช่น E001                           
                key_Gen = Trim(key_Gen)                             'ตัดช่องว่างในkey_Gen ทั้งหมด
                key_Gen = Strings.Right(key_Gen, 3)                 'ตัดข้อมูลจากทางขวามา3 หลัก จะได้ 001
                key_Gen = CInt(key_Gen) + 1                         'นำข้อมูลมาแปลเป็น int แล้วบวกเพิ่มอีก1 จะได้2
                key_Gen = Strings.Right(("00" & key_Gen), 3)        'นำข้อมูลที่บวกแล้วมาเติม0ด้านหน้าให้ครบ3 
                key_Gen = "P" & key_Gen                             'นำข้อมูลเติม 0 แล้วมาใว่ E ด้านหน้า จะกลายเป็น E002
            End If
        End If
        sqlDr.Close()       'ใช่เสร็จแล้วต้องปิด   
        clear()
        txtID.Text = key_Gen
        txtID.Enabled = True
        txtName.Enabled = True
        txtPrice.Enabled = True
        txtAmount.Enabled = True
        txtDetail.Enabled = True
        cmbCate.Enabled = True
        txtColor.Enabled = True
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
        txtName.Enabled = True
        txtPrice.Enabled = True
        txtAmount.Enabled = True
        txtDetail.Enabled = True
        cmbCate.Enabled = True
        txtColor.Enabled = True
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
        Dim img As Byte() = Nothing
        Dim Fr As FileStream
        Dim Br As BinaryReader

        If patch <> Nothing Then
            Fr = New FileStream(patch, FileMode.Open, FileAccess.Read)
            Br = New BinaryReader(Fr)
            img = Br.ReadBytes(CInt(Fr.Length))
        End If


        If txtID.TextLength = 0 Or txtName.TextLength = 0 Or txtPrice.TextLength = 0 Or txtAmount.TextLength = 0 Or txtDetail.TextLength = 0 Or cmbCate.SelectedIndex = -1 Or txtColor.TextLength = 0 Then
            MessageBox.Show("กรุณาป้อนข้อมูล", "ตรวจสอบ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtName.Focus()
            Exit Sub
        End If

        If save_status = "Add" Then
            sql = "SELECT P_ID FROM Product WHERE P_ID = '" & txtID.Text & "'"
            sqlCmd = New SqlCommand(sql, Conn)
            sqlDr = sqlCmd.ExecuteReader
            If sqlDr.Read() Then
                MessageBox.Show("รหัสสินค้า ซ้ำ กรุณากรอกใหม่", "ตรวจสอบ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtID.Focus()
                sqlDr.Close()
                Exit Sub
            End If
            sqlDr.Close()
            If save_status = "Add" Then
                If patch = Nothing Then
                    sql = "INSERT INTO Product(P_ID,P_Name,P_Price,P_Amount,P_Detail,C_ID) VALUES ('" & txtID.Text & "','" & txtName.Text & "','" & txtPrice.Text & "','" & txtAmount.Text & "','" & txtDetail.Text & "','" & cmbCate.SelectedValue & "')"
                End If
                sql = "INSERT INTO Product(P_ID,P_Name,P_Price,P_Amount,P_Detail,C_ID,P_IMG) VALUES ('" & txtID.Text & "','" & txtName.Text & "','" & txtPrice.Text & "','" & txtAmount.Text & "','" & txtDetail.Text & "','" & cmbCate.SelectedValue & "',@IMG)"
            End If
            sqlCmd = New SqlCommand(sql, Conn)
            sqlCmd.Parameters.Add(New SqlParameter("@IMG", img))
            sqlCmd.ExecuteNonQuery() 'ประมวลผลคำสั่ง SQL

            sql = "Select MAX(P_ID)from Product"
            sqlCmd = New SqlCommand(sql, Conn)
            sqlDr = sqlCmd.ExecuteReader
            sqlDr.Read()
            Dim PID As String = sqlDr.Item(0)
            sqlDr.Close()
            sql = "INSERT INTO Property(P_ID,Pr_Color,Pr_Amount)Values ('" & PID & "','" & txtColor.Text & "','" & txtAmount.Text & "')"
            sqlCmd = New SqlCommand(sql, Conn)
            sqlCmd.ExecuteNonQuery()
            Conn.Close()
            MessageBox.Show("บันทึกข้อมูลเรียบร้อยแล้ว", "ยืนยันการบันทึก", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            clear()
            txtID.Enabled = False
            txtName.Enabled = False
            txtPrice.Enabled = False
            txtAmount.Enabled = False
            txtDetail.Enabled = False
            cmbCate.Enabled = False
            txtColor.Enabled = False
            btnAdd.Enabled = True
            btnEdit.Enabled = False
            btnDelete.Enabled = False
            btnSave.Enabled = False
            btncancel.Enabled = True
            btnExit.Enabled = True
            showData()
        End If

        If save_status = "Edit" Then
            If txtColor.Text <> pk Then
                sql = "UPDATE Product set P_Name = '" & txtName.Text & "',P_Price = '" & txtPrice.Text & "',P_Amount = '" & txtAmount.Text & "',P_Detail = '" & txtDetail.Text & "',C_ID ='" & cmbCate.SelectedValue & "'"
                sql &= "WHERE P_ID = '" & txtID.Text & "'"
                sqlCmd = New SqlCommand(sql, Conn)
                sqlCmd.ExecuteNonQuery() 'ประมวลผลคำสั่ง SQL
                'Dim PID As String = sqlDr.Item(0)
                sql = "UPDATE Property set  Pr_Color = '" & txtColor.Text & "',Pr_Amount = '" & txtAmount.Text & "'"
                sql &= "WHERE   P_ID = '" & txtID.Text & "'"
                sqlCmd = New SqlCommand(sql, Conn)
                sqlCmd.ExecuteNonQuery()
                Conn.Close()
            End If
            MessageBox.Show("บันทึกข้อมูลเรียบร้อยแล้ว", "ยืนยันการบันทึก", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            clear()
            txtID.Enabled = False
            txtName.Enabled = False
            txtPrice.Enabled = False
            txtAmount.Enabled = False
            txtDetail.Enabled = False
            cmbCate.Enabled = False
            txtColor.Enabled = False
            btnAdd.Enabled = True
            btnEdit.Enabled = False
            btnDelete.Enabled = False
            btnSave.Enabled = False
            btncancel.Enabled = True
            btnExit.Enabled = True
            showData()
        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim sql As String
        Dim sqlCmd As SqlCommand
        If (MessageBox.Show("คุณต้องการลบข้อมูลนี้ใช่หรือไม่", "ยืนยันการลบข้อมูล", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)) = Windows.Forms.DialogResult.OK Then
            sql = "DELETE FROM Property WHERE P_ID = '" & txtID.Text & "'"
            sqlCmd = New SqlCommand(sql, Conn)
            sqlCmd.ExecuteNonQuery()
            sql = "DELETE FROM Product WHERE P_ID = '" & txtID.Text & "'"
            sqlCmd = New SqlCommand(sql, Conn)
            sqlCmd.ExecuteNonQuery()
            MessageBox.Show("ลบข้อมูลเรียบร้อย", "ผลการลบข้อมูล", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        clear()
        txtID.Enabled = False
        txtName.Enabled = False
        txtPrice.Enabled = False
        txtAmount.Enabled = False
        txtDetail.Enabled = False
        cmbCate.Enabled = False
        txtColor.Enabled = False
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
        txtID.Enabled = False
        txtName.Enabled = False
        txtPrice.Enabled = False
        txtAmount.Enabled = False
        txtDetail.Enabled = False
        cmbCate.Enabled = False
        txtColor.Enabled = False
        btnAdd.Enabled = True
        btnEdit.Enabled = False
        btnDelete.Enabled = False
        btnSave.Enabled = False
        btncancel.Enabled = True
        btnExit.Enabled = True
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub dgvProduct_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvProduct.CellContentClick

    End Sub

    Sub pic()
        Dim sql As String
        Dim da As SqlDataAdapter
        sql = "SELECT P_IMG from Product where P_ID = '" & dgvProduct.Rows(row).Cells(0).Value & "'"
        Module1.Connect()
        Dim tb As New DataTable
        da = New SqlDataAdapter(sql, Conn)
        da.Fill(tb)
        Dim img() As Byte
        If tb.Rows(0)(0) Is DBNull.Value Then
            ptb1.Image = Nothing
            Exit Sub
        End If
        img = tb.Rows(0)(0)
        picdata = img
        Dim ms As New MemoryStream(img)
        ptb1.Image = Image.FromStream(ms)
        ms.Close()
    End Sub

    Private Sub dgvProduct_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvProduct.CellContentDoubleClick
        row = e.RowIndex
        txtID.Text = dgvProduct.Rows(e.RowIndex).Cells(0).Value
        txtName.Text = dgvProduct.Rows(e.RowIndex).Cells(1).Value
        txtColor.Text = dgvProduct.Rows(e.RowIndex).Cells(2).Value
        txtPrice.Text = dgvProduct.Rows(e.RowIndex).Cells(3).Value
        txtAmount.Text = dgvProduct.Rows(e.RowIndex).Cells(4).Value
        cmbCate.Text = dgvProduct.Rows(e.RowIndex).Cells(5).Value
        txtDetail.Text = dgvProduct.Rows(e.RowIndex).Cells(6).Value
        pic()
        txtID.Enabled = False
        txtName.Enabled = False
        txtPrice.Enabled = False
        txtAmount.Enabled = False
        txtDetail.Enabled = False
        cmbCate.Enabled = False
        txtColor.Enabled = False
        btnAdd.Enabled = False
        btnEdit.Enabled = True
        btnDelete.Enabled = True
        btnSave.Enabled = False
        btncancel.Enabled = True
        btnExit.Enabled = True
    End Sub

    Private Sub ptb1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ptb1.Click

    End Sub

    Private Sub ptb1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ptb1.DoubleClick
        Dim opf As New OpenFileDialog
        opf.Filter = "Choose Image(*.jpg)|*.jpg"
        If opf.ShowDialog = DialogResult.OK Then
            patch = opf.FileName
            ptb1.ImageLocation = patch
        Else
            ptb1.Image = Nothing
        End If
    End Sub

End Class