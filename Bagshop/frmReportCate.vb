Imports System.Data
Imports System.Data.SqlClient
Public Class frmReportCate

    Private Sub frmReportCate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim sql As String
        Dim da As SqlDataAdapter
        Dim ds As New DataSet
        Module1.Connect()
        sql = "SELECT C_ID,C_Name FROM Category ORDER BY C_ID"
        da = New SqlDataAdapter(sql, Conn)
        da.Fill(ds, "Category")
        If ds.Tables("Category").Rows.Count <> 0 Then
            cmbSearch.DataSource = ds.Tables("Category")
            cmbSearch.ValueMember = "C_ID"
            cmbSearch.DisplayMember = "C_Name"
        End If
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Dim sql As String
        Dim sqlDr As SqlDataReader
        Dim sqlCmd As SqlCommand
        Dim tbCra As DataTable
        Dim currentReport As New ctrCategory
        Module1.Connect()
        sql = "select p.P_ID,p.P_Name,pr.Pr_Color,p.P_Detail,p.P_Amount,p.P_Price,c.C_Name From Product p , Property pr ,Category c Where p.C_ID = c.C_ID AND pr.P_ID = p.P_ID and p.C_ID = '" & cmbSearch.SelectedValue & " ' "
        sqlCmd = New SqlCommand(sql, Conn)
        sqlDr = sqlCmd.ExecuteReader
        tbCra = New DataTable
        tbCra.Load(sqlDr)
        currentReport.SetDataSource(tbCra)
        ' currentReport.SetParameterValue("E_Name", E_Name)
        ctrv1.ReportSource = currentReport ' ctrv1 คือ ชื่อของ CrystalReportViewer ที่อยู่ในฟอร์มนี้
    End Sub

    Private Sub cmbSearch_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSearch.SelectedIndexChanged

    End Sub
End Class