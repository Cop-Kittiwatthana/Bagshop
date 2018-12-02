Imports System.Data.SqlClient
Public Class frmPropertyy

    Private Sub frmPropertyy_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        showData()
    End Sub

    Sub showData()
        Dim sql As String
        Dim da As SqlDataAdapter
        Dim ds As New DataSet
        Module1.Connect()
        sql = "select Pr_Color as สี,SUM (CONVERT(int,Pr_Amount)) as จำนวน from Property group by Pr_Color"

        da = New SqlDataAdapter(sql, Conn)
        da.Fill(ds, "Property")
        dgvPropertyy.ReadOnly = True
        dgvPropertyy.DataSource = ds.Tables("Property")

        dgvPropertyy.Columns(0).Width = 220
        dgvPropertyy.Columns(1).Width = 220
    End Sub


    Private Sub frmPropertyy_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If MessageBox.Show("คุณต้องการออกจากโปรแกรมหรือไม่?", "Exit Program", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.OK Then
            e.Cancel = False
        Else
            e.Cancel = True
        End If
    End Sub
End Class