Public Class Report

    Private Sub Report_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'If Ed = 0 Then
        cmbreport.Items.Add("รายงานข้อมูลผู้ใช้")
        cmbreport.Items.Add("รายงานข้อมูลลูกค้า")
        cmbreport.Items.Add("รายงานข้อมูลการขาย")
        cmbreport.Items.Add("รายงานข้อมูลสินค้าทั้งหมด")
        cmbreport.Items.Add("รายงานข้อมูลสินค้าแบ่งตามประเภท")
        'ElseIf Ed = 1 Then

        'End If
    End Sub

    Private Sub cmbreport_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbreport.SelectedIndexChanged
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        cmbreport.SelectedValue = 0
        frmReportUser.Show()
    End Sub
End Class