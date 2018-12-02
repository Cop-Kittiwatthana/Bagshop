Public Class Report

    Private Sub Report_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Ed = 1 Then
            cmbreport.Items.Add("รายงานข้อมูลลูกค้า")
            cmbreport.Items.Add("รายงานข้อมูลการขาย")
            cmbreport.Items.Add("รายงานข้อมูลสินค้าทั้งหมด")
            cmbreport.Items.Add("รายงานข้อมูลสินค้าแบ่งตามประเภท")
        Else
            cmbreport.Items.Add("รายงานข้อมูลผู้ใช้")
            cmbreport.Items.Add("รายงานข้อมูลลูกค้า")
            cmbreport.Items.Add("รายงานข้อมูลการขาย")
            cmbreport.Items.Add("รายงานข้อมูลสินค้าทั้งหมด")
            cmbreport.Items.Add("รายงานข้อมูลสินค้าแบ่งตามประเภท")
        End If
    End Sub

    Private Sub cmbreport_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbreport.SelectedIndexChanged
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Ed = 1 Then
            If cmbreport.SelectedIndex = 0 Then
                frmReportMember.Show()
            End If
            If cmbreport.SelectedIndex = 1 Then
                frmReportSale.Show()
            End If
            If cmbreport.SelectedIndex = 2 Then
                frmReportProduct.Show()
            End If
            If cmbreport.SelectedIndex = 3 Then
                frmReportCate.Show()
            End If
        Else
            If cmbreport.SelectedIndex = 0 Then
                frmReportUser.Show()
            End If
            If cmbreport.SelectedIndex = 1 Then
                frmReportMember.Show()
            End If
            If cmbreport.SelectedIndex = 2 Then
                frmReportSale.Show()
            End If
            If cmbreport.SelectedIndex = 3 Then
                frmReportProduct.Show()
            End If
            If cmbreport.SelectedIndex = 4 Then
                frmReportCate.Show()
            End If
        End If





    End Sub
End Class