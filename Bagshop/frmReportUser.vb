Imports System.Data
Imports System.Data.SqlClient
Public Class frmReportUser

    Private Sub frmReportUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Module1.Connect()
        Dim sql As String = "select U_ID,U_User,U_Name,U_Tel,U_Status from Userr"
        Dim sqCmd As New SqlCommand(sql, Conn)
        Dim sqlDr As SqlDataReader = sqCmd.ExecuteReader
        Conn.Close()
        Dim ds As New DataSet
        Dim da As New SqlDataAdapter(sql, Conn)
        da.Fill(ds, "Userr")
        For i As Integer = 0 To ds.Tables("Userr").Rows.Count - 1
            If ds.Tables("Userr").Rows(i).Item(4) = "0" Then
                ds.Tables("Userr").Rows(i).Item(4) = "ผู้ดูแลระบบ"
            Else
                ds.Tables("Userr").Rows(i).Item(4) = "ผู้ใช้"
            End If
        Next
        Dim currentreport As New ctrUser
        currentreport.SetDataSource(ds.Tables("Userr"))
        ctrv1.ReportSource = currentreport
    End Sub

    Private Sub frmReportUser_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If MessageBox.Show("คุณต้องการออกจากโปรแกรมหรือไม่?", "Exit Program", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.OK Then
            e.Cancel = False
        Else
            e.Cancel = True
        End If
    End Sub
End Class