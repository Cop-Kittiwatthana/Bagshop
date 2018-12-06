Imports System.Data
Imports System.Data.SqlClient
Public Class frmReportSale

    Private Sub ctrv1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub frmReportSale_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim sql As String
        Dim da As SqlDataAdapter
        Dim ds As New DataSet
        Module1.Connect()
        sql = "SELECT O_ID FROM Orderr ORDER BY O_ID"
        da = New SqlDataAdapter(sql, Conn)
        da.Fill(ds, "Orderr")
        If ds.Tables("Orderr").Rows.Count <> 0 Then
            cmbOID.DataSource = ds.Tables("Orderr")
            cmbOID.ValueMember = "O_ID"
            cmbOID.DisplayMember = "O_ID"
        End If
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Dim sql As String
        Dim sqlCmd As SqlCommand
        Dim sqlDr As SqlDataReader
        Dim TbCtr As DataTable
        Dim currentreport As New ctrSale
        Module1.Connect()
        sql = "select r.O_ID,U_Name,m.M_Name,p.P_ID,p.P_Name,p.P_Price,op.Num,op.Total,r.Net,r.Pr_Color from Userr u, Member m, Product p, Order_Product op, Orderr r where r.O_ID = '" & cmbOID.SelectedValue & " ' and r.O_ID = op.O_ID and op.P_ID = p.P_ID and r.M_ID = m.M_ID and  u.U_User = r.U_User order by O_ID"
        sqlCmd = New SqlCommand(sql, Conn)
        sqlDr = sqlCmd.ExecuteReader
        TbCtr = New DataTable
        TbCtr.Load(sqlDr)
        currentreport.SetDataSource(TbCtr)
        'currentreport.SetParameterValue("E_Name", E_Name)
        ctrv1.ReportSource = currentreport
    End Sub

    Private Sub ctrv1_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ctrv1.Load

    End Sub
End Class