Imports System.Data
Imports System.Data.SqlClient
Public Class frmReportProduct

    Private Sub frmReportProduct_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ctrv1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ctrv1.Load
        Dim sql As String
        Dim sqlDr As SqlDataReader
        Dim sqlCmd As SqlCommand
        Dim tbCra As DataTable
        Dim currentReport As New ctrProduct
        Module1.Connect()
        sql = "select p.P_ID,p.P_Name,pr.Pr_Color,p.P_Detail,p.P_Amount,p.P_Price From Product p, Property pr Where p.P_ID = pr.P_ID"
        sqlCmd = New SqlCommand(sql, Conn)
        sqlDr = sqlCmd.ExecuteReader
        tbCra = New DataTable
        tbCra.Load(sqlDr)
        currentReport.SetDataSource(tbCra)
        'currentReport.SetParameterValue("E_Name", E_Name)
        ctrv1.ReportSource = currentReport ' ctrv1 คือ ชื่อของ CrystalReportViewer ที่อยู่ในฟอร์มนี้
    End Sub
End Class