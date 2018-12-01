Imports System.Data
Imports System.Data.SqlClient
Public Class frmSale
    Public j, h, amount As Integer
    Dim sum As Double
    Private Sub frmSale_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim sql As String
        Dim da As SqlDataAdapter
        Dim ds As New DataSet

        Module1.Connect()
        'sql "SELECT E_Usename, E_Name From Employee WHERE E_Usename = '" & User_Na & "'"
        sql = "SELECT U_User, U_Name From Userr"

        da = New SqlDataAdapter(sql, Conn)
        da.Fill(ds, "Userr")
        If ds.Tables("Userr").Rows.Count <> 0 Then
            cmbUser.DataSource = ds.Tables("Userr")
            cmbUser.ValueMember = "U_User"
            cmbUser.DisplayMember = "U_Name"
        End If
        sql = "SELECT P_ID,P_Name,P_Price,P_Amount FROM Product ORDER BY P_Name"
        da = New SqlDataAdapter(sql, Conn)
        da.Fill(ds, "Product")
        dgvProduct.ReadOnly = True
        dgvProduct.DataSource = ds.Tables("Product")
        dgvProduct.Columns(0).HeaderText = "รหัสสินค้า"
        dgvProduct.Columns(0).Width = 100
        dgvProduct.Columns(1).HeaderText = "ชื่อสินค้า"
        dgvProduct.Columns(1).Width = 100
        dgvProduct.Columns(2).HeaderText = "ราคา"
        dgvProduct.Columns(2).Width = 100
        dgvProduct.Columns(3).HeaderText = "จำนวนคงเหลือ"
        dgvProduct.Columns(3).Width = 100
        cmbUser.Enabled = False
        dtSale.Enabled = False
        txtMID.Enabled = False
        txtMNa.Enabled = False
        btnSearch.Enabled = False
        txtPID.Enabled = False
        txtPNa.Enabled = False
        txtPrice.Enabled = False
        txtAmount.Enabled = False
        txtsale.Enabled = False
        btAdd.Enabled = False
        btRemove.Enabled = False
        dgvProduct.Enabled = False
        dgvSale.Enabled = False
        btnAdd.Enabled = True
        btnSave.Enabled = False
        btncancel.Enabled = True
        btnExit.Enabled = True
        btnPrint.Enabled = False
    End Sub

    Sub clear()
        'lblSum.Text = ""
        'txtMemNa.Text = ""
        'txtMemID.Text = ""
        txtAmount.Text = ""
        txtPID.Text = ""
        txtPNa.Text = ""
        txtID.Text = ""
        txtsale.Text = ""
        txtPrice.Text = ""
    End Sub

    Private Sub btAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAdd.Click
        Dim Gid, Gname As String
        Dim Gnum, Gamount As Integer
        Dim Gprice, Gtotal As Double
        If txtsale.Text = "" Then
            MessageBox.Show("กรุณาใส่จำนวนที่สั่งซื้อ", "คำเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        If CInt(txtsale.Text) = 0 Then
            MessageBox.Show("กรุณาใส่จำนวนที่สั่งซื้อ", "คำเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        If CInt(amount) < CInt(txtsale.Text) Then
            MessageBox.Show("จำนวนที่ซื้อมากกว่าจำนวนคงเหลือ", "คำเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If txtMID.Text = "" Then
            MessageBox.Show("กรุณาเลือกลูกค้า", "คำเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Gamount = CInt(txtAmount.Text)
        Gid = txtPID.Text
        Gname = txtPNa.Text
        Gprice = CDbl(txtPrice.Text)
        Gnum = CInt(txtsale.Text)
        h = Gamount - Gnum
        Gtotal = Gnum * Gprice
        dgvSale.Rows.Add(Gid, Gname, Gprice, Gnum, Gtotal)
        sum = sum + Gtotal
        lblSum.Text = sum.ToString("#,##.00")
        dgvProduct.Rows(j).Cells(3).Value = h
        clear()
        txtPID.Text = ""
        txtPNa.Text = ""
        txtAmount.Text = ""
        txtPrice.Text = ""
        txtsale.Text = ""
        txtPID.Enabled = False
        txtPNa.Enabled = False
        cmbUser.Enabled = True
        txtAmount.Enabled = False
        txtPrice.Enabled = False
        txtsale.Enabled = False
        dgvProduct.Enabled = True
        dgvSale.Enabled = True
        btnAdd.Enabled = False
        btnSave.Enabled = True
        btncancel.Enabled = True
        btnExit.Enabled = True
        btnPrint.Enabled = False
        If dgvSale.Rows.Count > 1 Then
            btnSearch.Enabled = False
        Else
            btnSearch.Enabled = True
        End If
        btAdd.Enabled = True
        btRemove.Enabled = False
    End Sub

    Private Sub btRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btRemove.Click
        If dgvSale.Rows.Count <= 1 Then Exit Sub
        sum = sum - Val(dgvSale.CurrentRow.Cells(4).Value)
        lblSum.Text = sum.ToString("#,##.00")
        dgvSale.Rows.Remove(dgvSale.CurrentRow)
        If dgvSale.Rows.Count <= 1 Then
            btRemove.Enabled = False
            btnSave.Enabled = False
        End If
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        sum = 0
        cmbUser.Enabled = True
        dtsale.Enabled = True
        txtMID.Enabled = False
        btnSearch.Enabled = True
        txtMNa.Enabled = False
        txtPID.Enabled = False
        txtPNa.Enabled = False
        txtPrice.Enabled = False
        txtAmount.Enabled = False
        txtsale.Enabled = False
        btAdd.Enabled = True
        btRemove.Enabled = True
        dgvProduct.Enabled = True
        dgvSale.Enabled = False
        btnAdd.Enabled = False
        btnSave.Enabled = True
        btncancel.Enabled = True
        btnExit.Enabled = True
        btnPrint.Enabled = False
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim sql As String
        Dim sqlCmd As SqlCommand
        Dim sqlDr As SqlDataReader
        Dim M_ID, saleID, Num, Price, ISBN, orderDate, Total As String
        Dim i, k, orderID As Integer
        k = dgvSale.RowCount - 2
        If k < 0 Then
            MessageBox.Show("กรุณาทำรายการสั่งซื้อ", "คำเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        orderDate = Today.Date.ToString("s")
        sql = "insert into Orderr (O_Date,Net,M_ID,U_User)"
        sql &= "values('" & orderDate & "','" & CDbl(lblSum.Text) & "','" & CStr(txtMID.Text) & "','" & cmbUser.SelectedValue & "')"
        sqlCmd = New SqlCommand(sql, Conn)
        sqlCmd.ExecuteNonQuery()
        sql = "select max (O_ID)from Orderr"
        sqlCmd = New SqlCommand(sql, Conn)
        sqlDr = sqlCmd.ExecuteReader
        sqlDr.Read()
        saleID = sqlDr.Item(0)
        sqlDr.Close()
        For i = 0 To k
            ISBN = dgvSale.Rows(i).Cells(0).Value
            Num = dgvSale.Rows(i).Cells(3).Value
            Price = dgvSale.Rows(i).Cells(2).Value
            Total = dgvSale.Rows(i).Cells(4).Value
            sql = "insert into Order_Product (O_ID,P_ID,Num,S_Total)"
            sql &= "values ('" & saleID & "','" & ISBN & "','" & Num & "','" & Total & "')"
            sqlCmd = New SqlCommand(sql, Conn)
            sqlCmd.ExecuteNonQuery()
        Next
        k = dgvProduct.RowCount - 2
        For i = 0 To k
            sql = "update Product set P_Amount = '" & dgvProduct.Rows(i).Cells(3).Value & "' where P_ID = '" & dgvProduct.Rows(i).Cells(0).Value & "'"
            sqlCmd = New SqlCommand(sql, Conn)
            sqlCmd.ExecuteNonQuery()
        Next
        MessageBox.Show("บันทึกข้อมูลเรียบร้อย", "ยืนยันการบันทึก", MessageBoxButtons.OK, MessageBoxIcon.Information)
        txtID.Text = saleID
        txtPID.Enabled = False
        txtPNa.Enabled = False
        cmbUser.Enabled = False
        txtAmount.Enabled = False
        txtPrice.Enabled = False
        txtsale.Enabled = False
        dgvProduct.Enabled = False
        dgvSale.Enabled = False
        btnAdd.Enabled = True
        btnSave.Enabled = False
        btncancel.Enabled = True
        btnExit.Enabled = True
        btnPrint.Enabled = True
        btAdd.Enabled = False
        btRemove.Enabled = False
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Dim sql As String
        Dim sqlCmd As SqlCommand
        Dim bookID, num As String
        Dim i, k As Integer
        txtPID.Text = ""
        txtPNa.Text = ""
        txtAmount.Text = ""
        txtPrice.Text = ""
        txtsale.Text = ""
        lblSum.Text = "0.00"
        txtPID.Enabled = False
        txtPNa.Enabled = False
        cmbUser.Enabled = False
        txtAmount.Enabled = False
        txtPrice.Enabled = False
        txtsale.Enabled = False
        dgvProduct.Enabled = False
        dgvSale.Enabled = False
        btnAdd.Enabled = True
        btnSave.Enabled = False
        btncancel.Enabled = False
        btnExit.Enabled = True
        btnPrint.Enabled = False
        btAdd.Enabled = False
        btRemove.Enabled = False
        dtsale.Enabled = False
        txtID.Text = ""
        txtMID.Text = ""
        txtMNa.Text = ""
        dgvSale.Rows.Clear()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        If txtID.Text = "" Then
            MessageBox.Show("กรูณาทำรายการก่อน", "คำเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        'frmReportSale.Show()
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        frmMerber1.Show()
    End Sub

    Private Sub dgvProduct_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvProduct.CellContentClick

    End Sub

    Private Sub dgvProduct_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvProduct.CellContentDoubleClick
        Dim sql As String
        Dim sqlDr As SqlDataReader
        Dim sqlCmd As SqlCommand
        j = e.RowIndex
        txtPID.Text = dgvProduct.Rows(e.RowIndex).Cells(0).Value
        txtPNa.Text = dgvProduct.Rows(e.RowIndex).Cells(1).Value
        txtPrice.Text = dgvProduct.Rows(e.RowIndex).Cells(2).Value
        txtAmount.Text = dgvProduct.Rows(e.RowIndex).Cells(3).Value
        amount = dgvProduct.Rows(e.RowIndex).Cells(3).Value
        sql = "Select P_Price FROM Product WHERE P_ID = '" & txtPID.Text & "'"
        sqlCmd = New SqlCommand(sql, Conn)
        sqlDr = sqlCmd.ExecuteReader
        If sqlDr.Read() Then
            txtPrice.Text = sqlDr.Item(0)
        End If
        sqlDr.Close()
        txtsale.Enabled = True
    End Sub
End Class