Imports System.Data.SqlClient
Public Class frmPropertyy
    Public pk As String
    Dim save_status As String
    Private Sub frmPropertyy_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
    End Sub

    Sub showData()
        Dim sql As String
        Dim da As SqlDataAdapter
        Dim ds As New DataSet
        Module1.Connect()
        sql = "Select Pr_Num,Pr_Color,Pr_Amount From Property "

        da = New SqlDataAdapter(sql, Conn)
        da.Fill(ds, "Property")
        dgvPropertyy.ReadOnly = True
        dgvPropertyy.DataSource = ds.Tables("Property")

        dgvPropertyy.Columns(0).HeaderText = "ลำดับ"
        dgvPropertyy.Columns(0).Width = 150
        dgvPropertyy.Columns(1).HeaderText = "สี"
        dgvPropertyy.Columns(1).Width = 150
        dgvPropertyy.Columns(2).HeaderText = "จำนวน"
        dgvPropertyy.Columns(2).Width = 140

    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
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

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        txtNum.Enabled = False
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

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim sql As String
        Dim sqlCmd As SqlCommand
        Dim sqlDr As SqlDataReader

        If txtColor.Text = "" Or txtAmount.Text = "" Then
            MessageBox.Show("กรุณาป้อนข้อมูล", "ตรวจสอบ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtColor.Focus()
            txtAmount.Focus()
            Exit Sub
        End If

        If save_status = "Add" Or save_status = "Edit" Then
            If txtColor.Text <> pk Then
                sql = "SELECT Pr_Color FROM Property WHERE Pr_Num =(Select Pr_Num where Pr_Color = '" & txtColor.Text & "')"
                sqlCmd = New SqlCommand(sql, Conn)
                sqlDr = sqlCmd.ExecuteReader
                If sqlDr.Read() Then
                    MessageBox.Show("สี ซ้ำ กรุณากรอกใหม่", "ตรวจสอบ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtColor.Focus()
                    txtAmount.Focus()
                    sqlDr.Close()
                    Exit Sub
                End If
                sqlDr.Close()
            End If
        End If
        If save_status = "Add" Then
            sql = "INSERT INTO Property(Pr_Color,Pr_Amount) VALUES ('" & txtColor.Text & "','" & txtAmount.Text & "')"
        End If

        If save_status = "Edit" Then
            sql = "UPDATE Property set Pr_Color = '" & txtColor.Text & "', Pr_Amount = '" & txtAmount.Text & "' "
            sql &= "WHERE Pr_Num = '" & txtNum.Text & "'"
        End If
        sqlCmd = New SqlCommand(sql, Conn)
        sqlCmd.ExecuteNonQuery() 'ประมวลผลคำสั่ง
        Conn.Close()

        MessageBox.Show("บันทึกข้อมูลเรีบยร้อยแล้ว", "ยืนยันการบันทึก", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        txtNum.Text = ""
        txtColor.Text = ""
        txtAmount.Text = ""
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
        txtNum.Text = ""
        txtColor.Text = ""
        txtAmount.Text = ""
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
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        txtNum.Text = ""
        txtColor.Text = ""
        txtAmount.Text = ""
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
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub dgvPropertyy_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvPropertyy.CellContentClick

    End Sub

    Private Sub dgvPropertyy_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvPropertyy.CellContentDoubleClick
        txtNum.Text = dgvPropertyy.Rows(e.RowIndex).Cells(0).Value.ToString
        txtColor.Text = dgvPropertyy.Rows(e.RowIndex).Cells(1).Value.ToString
        pk = dgvPropertyy.Rows(e.RowIndex).Cells(1).Value
        txtAmount.Text = dgvPropertyy.Rows(e.RowIndex).Cells(2).Value.ToString
        txtNum.Enabled = False
        txtColor.Enabled = False
        txtAmount.Enabled = False
        btnAdd.Enabled = False
        btnEdit.Enabled = True
        btnDelete.Enabled = True
        btnSave.Enabled = False
        btncancel.Enabled = True
        btnExit.Enabled = True
    End Sub
End Class