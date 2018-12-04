Imports System.Data
Imports System.Data.SqlClient
Public Class frmSlipSale

    Private Sub ctrv1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ctrv1.Load
        Dim sql As String
        Dim sqlCmd As SqlCommand
        Dim sqlDr As SqlDataReader
        Dim TbCtr As DataTable
        Dim currentreport As New ctrSale
        Module1.Connect()
        sql = "select r.O_ID,r.O_Date,m.M_Name,m.M_Add,m.M_Tel,u.U_Name,p.P_ID,p.P_Name,p.P_Price,op.Num,op.Total,r.Net from Userr u, Member m, Product p, Order_Product op, Orderr r where r.O_ID = '" & frmSale.txtID.Text & "' and r.O_ID = op.O_ID and op.P_ID = p.P_ID and r.M_ID = m.M_ID and  u.U_User = r.U_User"
        sqlCmd = New SqlCommand(sql, Conn)
        sqlDr = sqlCmd.ExecuteReader
        TbCtr = New DataTable
        TbCtr.Load(sqlDr)
        currentreport.SetDataSource(TbCtr)
        'currentreport.SetParameterValue("E_Name", E_Name)
        ctrv1.ReportSource = currentreport
    End Sub
End Class