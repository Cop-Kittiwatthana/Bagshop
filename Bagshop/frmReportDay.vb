Imports System.Data.SqlClient
Public Class frmReportDay
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer

    Sub Orderload()
        Module1.Connect()
        Dim sql As String = "select O_ID from Orderr"
        Dim da As New SqlDataAdapter(sql, Conn)
        Dim ds As New DataSet
        da.Fill(ds, "Orderr")
        cmbSale.DataSource = ds.Tables("Orderr")
        cmbSale.DisplayMember = "O_ID"
        cmbSale.ValueMember = "O_ID"
        cmbSale.SelectedIndex = -1
        Conn.Close()
    End Sub
    Sub dayctr()
        'Dim sql As String = "select O_ID,O_date,Net,Userr.U_Name,(select distinct SUM(Net) from Orderr where O_Date = '" & cmbSale.SelectedValue & "' ) as Oderr_Product.Total from Ordrr , Userr ,Oderr_Product  where O_Date = '" & cmbSale.SelectedValue & "' and Orderr.U_User = Userr.U_User"
        Dim sql As String = "select  r.O_ID,u.U_Name,r.Net,rr.Total  from Orderr r , Userr u ,Order_Product rr  where r.O_Date = '" & cmbSale.SelectedValue & "' and r.U_User = u.U_User and r.O_ID = rr.O_ID "
        Dim sqlCmd As SqlCommand
        Dim sqlDr As SqlDataReader
        Dim TbCtr As DataTable
        Dim currentReport As New ctrSaleDay
        Module1.Connect()
        sqlCmd = New SqlCommand(sql, Conn)
        sqlDr = sqlCmd.ExecuteReader
        TbCtr = New DataTable
        TbCtr.Load(sqlDr)
        currentReport.SetDataSource(TbCtr)
        ctrv1.ReportSource = currentReport
        currentReport.SetParameterValue("Date1", cmbSale.Text)
        Me.WindowState = FormWindowState.Maximized
    End Sub
    Sub monthctr()
        Dim sql As String = "select day(r.O_Date) as O_Date,sum(r.Net ) as Total, sum(r.Net ) as Net   from Orderr r  where (cast(month(O_Date) as varchar) +'/'+ cast(year(O_Date) as varchar)) = '" & cmbSale.SelectedValue & "' group by day(r.O_Date)"
        Dim sqlCmd As SqlCommand
        Dim sqlDr As SqlDataReader
        Dim TbCtr As DataTable
        Dim currentReport As New ctrSaleMonth
        Module1.Connect()
        sqlCmd = New SqlCommand(sql, Conn)
        sqlDr = sqlCmd.ExecuteReader
        TbCtr = New DataTable
        TbCtr.Load(sqlDr)
        currentReport.SetDataSource(TbCtr)
        ctrv1.ReportSource = currentReport
        currentReport.SetParameterValue("Date1", CStr(cmbSale.Text))
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Sub yearctr()
        Module1.Connect()
        Dim sql As String = "select convert(int,month(O_Date)) as Month,SUM(Net) as Total ,(select SUM(Net)from Orderr where YEAR(O_Date) = '" & cmbSale.SelectedValue & "') as Net from Orderr where YEAR(O_Date) = '" & cmbSale.SelectedValue & "' group by MONTH(O_Date)"
        Dim sqCmd As New SqlCommand(sql, Conn)
        Dim sqlDr As SqlDataReader = sqCmd.ExecuteReader
        Dim TbCtr As New DataTable
        Conn.Close()
        Dim ds As New DataSet
        Dim da As New SqlDataAdapter(sql, Conn)
        da.Fill(ds, "emp")
        For i As Integer = 0 To ds.Tables("emp").Rows.Count - 1
            ds.Tables("emp").Rows(i).Item(0) = MonthName(ds.Tables("emp").Rows(i).Item(0))
        Next
        Dim currentreport As New ctrSaleYear
        TbCtr.Load(sqlDr)
        currentreport.SetDataSource(ds.Tables("emp"))
        ctrv1.ReportSource = currentreport '
        currentreport.SetParameterValue("Date1", CStr(cmbSale.Text))
        Me.WindowState = FormWindowState.Maximized
    End Sub
    Sub dateload()
        Module1.Connect()
        Dim sql As String = "select distinct O_Date,cast(month(O_Date) as varchar)+'/'+ (cast(day(O_Date) as varchar)+'/'+ cast(year(O_Date) as varchar)) as Date1 from Orderr"
        Dim da As New SqlDataAdapter(sql, Conn)
        Dim ds As New DataSet
        da.Fill(ds, "Date")
        cmbSale.DataSource = ds.Tables("Date")
        cmbSale.DisplayMember = "O_Date"
        cmbSale.ValueMember = "Date1"
        cmbSale.SelectedIndex = -1
        Conn.Close()
    End Sub

    Sub yearload()
        Module1.Connect()
        Dim sql As String = "select distinct convert(int,year(O_Date)) as Date from Orderr"
        Dim da As New SqlDataAdapter(sql, Conn)
        Dim ds As New DataSet
        da.Fill(ds, "Date")
        cmbSale.DataSource = ds.Tables("Date")
        cmbSale.DisplayMember = "O_Date"
        cmbSale.ValueMember = "Date"
        cmbSale.SelectedIndex = -1
        Conn.Close()
    End Sub

    Sub monthload()
        Module1.Connect()
        Dim sql As String = "  select distinct (cast(month(O_Date) as varchar) +'/'+ cast(year(O_Date) as varchar)) as Month from Orderr "
        Dim da As New SqlDataAdapter(sql, Conn)
        Dim ds As New DataSet
        da.Fill(ds, "Date")
        cmbSale.DataSource = ds.Tables("Date")
        cmbSale.DisplayMember = "Month"
        cmbSale.ValueMember = "Month"
        cmbSale.SelectedIndex = -1
        Conn.Close()
    End Sub
    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbDay.CheckedChanged
        dateload()
        cmbSale.Enabled = True
        Dim a As String = "  select month(r.Date),r.Net as Total_Price,(select sum(Net) from [Order]) as Net from [Order] r where (cast(month(Date) as varchar) +'/'+ cast(year(Date) as varchar)) = '12/2018'"
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbMonth.CheckedChanged
        monthload()
        cmbSale.Enabled = True
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbYear.CheckedChanged
        yearload()
        cmbSale.Enabled = True
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If rdbMonth.Checked = True Then
            monthctr()
        ElseIf rdbDay.Checked = True Then
            dayctr()
        ElseIf rdbYear.Checked = True Then
            yearctr()
        End If
    End Sub

    Private Sub frmReportDay_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class