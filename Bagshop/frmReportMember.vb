Imports System.Data
Imports System.Data.SqlClient
Public Class frmReportMember

    Private Sub frmReportMember_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Sql As String
        Dim sqlDr As SqlDataReader
        Dim sqlCmd As SqlCommand
        Dim TbCtr As DataTable
        Dim currentReport As New ctrMember

        Module1.Connect()
        Sql = "SELECT M_ID,M_Name,M_Add,M_Tel FROM Member ORDER BY M_ID "
        sqlCmd = New SqlCommand(Sql, Conn)
        sqlDr = sqlCmd.ExecuteReader
        TbCtr = New DataTable
        TbCtr.Load(sqlDr)
        currentReport.SetDataSource(TbCtr)
        'currentReport.SetParameterValue("E_Name", E_Name)
        ctrv1.ReportSource = currentReport
    End Sub

    Private Sub ctrv1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ctrv1.Load

    End Sub
End Class