Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Public Class frmPropertyy
    Dim save_status, B As String
    Public A As String
    Dim row As Integer
    Dim picdata() As Byte
    Private Sub frmPropertyy_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim sql As String
        Dim da As SqlDataAdapter
        Dim ds As New DataSet

        Module1.Connect()
        'sql "SELECT E_Usename, E_Name From Employee WHERE E_Usename = '" & User_Na & "'"
        sql = "SELECT P_ID, P_Name From Product"

        
        sql = "SELECT P_ID From Product ORDER BY P_ID "
        da = New SqlDataAdapter(sql, Conn)
        da.Fill(ds, "Product")
        'MessageBox.Show(sql)
        'ptb1.Image = Nothing
        txtPID.Enabled = False
        txtPNa.Enabled = False
        txtNum.Enabled = False
        txtColor.Enabled = False
        txtAmount.Enabled = False
        btnAdd.Enabled = True
        btnEdit.Enabled = False
        btnDelete.Enabled = False
        btnSave.Enabled = True
        'dgvProperty.Enabled = False
        showData()
        showData2()
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

    Sub showData()
        Dim sql As String
        Dim da As SqlDataAdapter
        Dim ds As New DataSet
        Module1.Connect()
        sql = "SELECT P_ID , P_Name  FROM Product "
        da = New SqlClient.SqlDataAdapter(sql, Conn)
        da.Fill(ds, "Product")
        dgvProduct.ReadOnly = True
        dgvProduct.DataSource = ds.Tables("Product")
        dgvProduct.Columns(0).HeaderText = "รหัสสินค้า"
        dgvProduct.Columns(0).Width = 100
        dgvProduct.Columns(1).HeaderText = "ชื่อสินค้า"
        dgvProduct.Columns(1).Width = 200
    End Sub
    
    Sub showData2()
        Dim sql As String
        Dim da As SqlDataAdapter
        Dim ds As New DataSet

        sql = "SELECT p.P_ID ,p.P_Name , pr.Pr_Color , pr.Pr_Amount ,Pr_Num  FROM Product p,Property pr where p.P_ID = pr.P_ID order by P_ID "
        da = New SqlDataAdapter(sql, Conn)
        da.Fill(ds, "Product")
        dgvProperty.ReadOnly = True
        dgvProperty.DataSource = ds.Tables("Product")
        With dgvProperty
            .Columns(0).HeaderText = "รหัสสินค้า"
            .Columns(0).Width = 100
            .Columns(1).HeaderText = "ชื่อสินค้า"
            .Columns(1).Width = 105
            .Columns(2).HeaderText = "สี"
            .Columns(2).Width = 100
            .Columns(3).HeaderText = "จำนวน"
            .Columns(3).Width = 100
            .Columns(4).Visible = False
        End With
    End Sub
    

    Private Sub frmPropertyy_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If MessageBox.Show("คุณต้องการออกจากโปรแกรมหรือไม่?", "Exit Program", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.OK Then
            e.Cancel = False
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub dgvProduct_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvProduct.CellContentDoubleClick
        row = e.RowIndex
        txtPID.Text = dgvProduct.Rows(e.RowIndex).Cells(0).Value
        txtPNa.Text = dgvProduct.Rows(e.RowIndex).Cells(1).Value
        pic()
        btnAdd.Enabled = True
        btnEdit.Enabled = False
        btnDelete.Enabled = False
        txtColor.Enabled = False
        txtAmount.Enabled = False
        txtAmount.Text = ""
        txtColor.Text = ""
        txtPID.Enabled = False
        txtPNa.Enabled = False
        'txtsale.Enabled = True
    End Sub


    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        txtPID.Enabled = False
        txtPNa.Enabled = False
        txtNum.Enabled = False
        txtColor.Enabled = True
        txtAmount.Enabled = True
        btnAdd.Enabled = False
        btnEdit.Enabled = False
        btnDelete.Enabled = False
        btnSave.Enabled = True
        btncancel.Enabled = True
        btnExit.Enabled = True
        save_status = "Add"
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim sql As String
        Dim sqlcmd As SqlCommand
        Dim sqldr As SqlDataReader

        If txtColor.Text = "" Or txtAmount.Text = "" Then
            MessageBox.Show("กรุณาป้อนข้อมูล", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            Exit Sub
        End If
       
        If save_status = "Add" Then
            sql = " SELECT Pr_Color FROM Property , Product WHERE Property.Pr_Color  ='" & txtColor.Text & "' AND Property.P_ID = '" & txtPID.Text & "' "
            sqlcmd = New SqlCommand(sql, Conn)
            sqldr = sqlcmd.ExecuteReader
            If sqldr.Read() Then
                MessageBox.Show("สีซ้ำ", "ตรวจสอบ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                txtColor.Focus()
                sqldr.Close()
                Exit Sub
            End If
            sqldr.Close()
            If save_status = "Add" Then
                sql = " INSERT INTO Property(Pr_Color,Pr_Amount,P_ID) VALUES ('" & txtColor.Text & "','" & txtAmount.Text & "','" & txtPID.Text & "') "
            End If
        End If

        If save_status = "Edit" Then
            If txtColor.Text <> A Then
                sql = "SELECT Pr_Color,Pr_Num FROM Property , Product WHERE Property.Pr_Color  ='" & txtColor.Text & "' AND Property.P_ID = '" & txtPID.Text & "' and Pr_Num = '" & txtNum.Text & "'  "
                sqlcmd = New SqlCommand(sql, Conn)
                sqldr = sqlcmd.ExecuteReader
                If sqldr.Read() Then
                    MessageBox.Show("สีซ้ำ", "ตรวจสอบ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                    txtColor.Focus()
                    sqldr.Close()
                    Exit Sub
                End If
                sqldr.Close()
            End If
            If save_status = "Edit" Then
                sql = "UPDATE Property set Pr_Color ='" & txtColor.Text & "' , Pr_Amount = '" & txtAmount.Text & "'"
                sql &= "WHERE P_ID ='" & txtPID.Text & "'and Pr_Num = '" & txtNum.Text & "'"
            End If
        End If
        sqlcmd = New SqlCommand(sql, Conn)
        sqlcmd.ExecuteNonQuery()
        Conn.Close()
        MessageBox.Show("บันทึกข้อมูลเรียบร้อย", "ยืนยันการบันทึก", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ptb1.Image = Nothing
        txtPID.Enabled = False
        txtPNa.Enabled = False
        txtNum.Enabled = False
        txtColor.Enabled = False
        txtAmount.Enabled = False
        btnAdd.Enabled = True
        btnEdit.Enabled = False
        btnDelete.Enabled = False
        btnSave.Enabled = False
        btncancel.Enabled = True
        btnExit.Enabled = True
        showData()
        showData2()
    End Sub

    Private Sub dgvProperty_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvProperty.CellContentDoubleClick
        txtColor.Text = dgvProperty.Rows(e.RowIndex).Cells(2).Value.ToString
        txtPNa.Text = dgvProperty.Rows(e.RowIndex).Cells(1).Value.ToString
        txtAmount.Text = dgvProperty.Rows(e.RowIndex).Cells(3).Value.ToString
        txtPID.Text = dgvProperty.Rows(e.RowIndex).Cells(0).Value.ToString
        A = dgvProperty.Rows(e.RowIndex).Cells(2).Value.ToString
        pic()
        txtNum.Text = dgvProperty.Rows(e.RowIndex).Cells(4).Value.ToString
        txtColor.Enabled = False
        txtAmount.Enabled = False
        btnAdd.Enabled = False
        btnDelete.Enabled = True
        btnSave.Enabled = False
        btncancel.Enabled = True
        btnExit.Enabled = True
        btnEdit.Enabled = True
        txtNum.Enabled = False
        txtPID.Enabled = False
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        txtColor.Enabled = True
        txtAmount.Enabled = True
        btnAdd.Enabled = False
        btnEdit.Enabled = False
        btnDelete.Enabled = False
        btnSave.Enabled = True
        btncancel.Enabled = True
        btnExit.Enabled = True
        save_status = "Edit"
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim sql As String
        Dim sqlCmd As SqlCommand
        If (MessageBox.Show("คุณต้องการลบข้อมูลนี้ใช่หรือไม่", "ยืนยันการลบข้อมูล", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)) = Windows.Forms.DialogResult.OK Then
            sql = "DELETE Property WHERE Pr_Num = '" & txtNum.Text & "'"
            sqlCmd = New SqlCommand(sql, Conn)
            sqlCmd.ExecuteNonQuery()
            MessageBox.Show("ลบข้อมูลเรียบร้อย", "ผลการลบข้อมูล", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
        txtPID.Text = ""
        txtPNa.Text = ""
        ptb1.Image = Nothing
        txtColor.Text = ""
        txtAmount.Text = ""
        txtPID.Enabled = False
        txtPNa.Enabled = False
        txtNum.Enabled = False
        txtColor.Enabled = False
        txtAmount.Enabled = False
        btnAdd.Enabled = True
        btnEdit.Enabled = False
        btnDelete.Enabled = False
        btnSave.Enabled = True
        btncancel.Enabled = True
        btnExit.Enabled = True
        showData2()
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        txtPID.Text = ""
        txtPNa.Text = ""
        txtColor.Text = ""
        txtAmount.Text = ""
        ptb1.Image = Nothing
        txtPID.Enabled = False
        txtPNa.Enabled = False
        txtNum.Enabled = False
        txtColor.Enabled = False
        txtAmount.Enabled = False
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

    Private Sub dgvProperty_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvProperty.CellContentClick

    End Sub
End Class