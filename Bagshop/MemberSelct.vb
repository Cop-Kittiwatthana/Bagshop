Imports System.Data.SqlClient
Public Class frmMerber1

    Sub showData()
        Dim sql As String
        Dim da As SqlDataAdapter
        Module1.Connect()
        sql = "SELECT M_ID, M_Name, M_Add, M_Tel FROM Member ORDER BY M_Name"
        Dim ds As New DataSet
        da = New SqlDataAdapter(sql, Conn)
        da.Fill(ds, "Member")
        dgvMem.ReadOnly = True
        dgvMem.DataSource = ds.Tables("Member")
        With dgvMem
            .Columns(0).HeaderText = "รหัสลูกค้า"
            .Columns(0).Width = 100
            .Columns(1).HeaderText = "ชื่อ-นามสกุล"
            .Columns(1).Width = 150
            .Columns(2).HeaderText = "ที่อยู่"
            .Columns(2).Width = 200
            .Columns(3).HeaderText = "เบอร์โทรศัพท์"
            .Columns(3).Width = 120
        End With
    End Sub
    Private Sub MemberSelct_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        showData()
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        Dim sql As String
        Dim da As SqlDataAdapter
        Dim ds As New DataSet
        Module1.Connect()
        sql = "SELECT M_ID, M_Name, M_Add, M_Tel From Member WHERE M_Name LIKE '" & txtSearch.Text & "%'"
        da = New SqlDataAdapter(sql, Conn)
        da.Fill(ds, "Member")
        dgvMem.ReadOnly = True
        dgvMem.DataSource = ds.Tables("Member")
        With dgvMem
            .Columns(0).HeaderText = "รหัสลูกค้า"
            .Columns(0).Width = 100
            .Columns(1).HeaderText = "ชื่อ-นามสกุล"
            .Columns(1).Width = 100
            .Columns(2).HeaderText = "ที่อยู่"
            .Columns(2).Width = 100
            .Columns(3).HeaderText = "เบอร์โทรศัพท์"
            .Columns(3).Width = 120
        End With
    End Sub

    Private Sub dgvMem_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvMem.CellContentClick

    End Sub

    Private Sub dgvMem_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvMem.CellContentDoubleClick
        frmSale.txtMID.Text = dgvMem.Rows(e.RowIndex).Cells(0).Value
        frmSale.txtMNa.Text = dgvMem.Rows(e.RowIndex).Cells(1).Value
        Me.Close()
    End Sub
End Class