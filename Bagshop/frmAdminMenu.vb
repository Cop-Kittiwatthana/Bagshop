Imports System.Data
Imports System.Data.SqlClient
Public Class frmAdminMenu

    Private Sub btnUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUser.Click
        frmUser.Show()
        Ed = 0
    End Sub

    Private Sub btncartgory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncartgory.Click
        frmCategory.Show()

    End Sub

    Private Sub btnProduct_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmProduct.Show()
    End Sub

    Private Sub btnMember_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmMember.Show()
    End Sub

    Private Sub btnSale_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmSale.Show()
    End Sub

    Private Sub BtnReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnReport.Click
        Report.Show()

    End Sub

    Private Sub btnProperty_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmPropertyy.Show()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Application.Exit()

    End Sub

    Private Sub frmAdminMenu_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If MessageBox.Show("คุณต้องการออกจากโปรแกรมหรือไม่?", "Exit Program", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.OK Then
            e.Cancel = False
            Application.Exit()
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub รายงานToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub frmAdminMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lbl1.Text = U_Name
    End Sub

    Private Sub lbl1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl1.Click

    End Sub
End Class