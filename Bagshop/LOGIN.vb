Imports System.Data.SqlClient
Public Class login

    Private Sub btnlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogin.Click
        Dim sql As String
        Dim sqlCmd As SqlCommand
        Dim sqlDr As SqlDataReader
        Module1.Connect()
        sql = "SELECT U_User, U_Status ,U_Name FROM Userr WHERE U_User = '" & txtUser.Text & "' AND U_Pass = '" & txtPass.Text & "'"
        sqlCmd = New SqlCommand(sql, Conn)
        sqlDr = sqlCmd.ExecuteReader
        If sqlDr.Read() Then
            User_Na = sqlDr.Item(0)
            User_Status = sqlDr.Item(1)
            U_Name = sqlDr.Item(2)
        Else
            MessageBox.Show("Username หรือ Password ไม่ถูกต้อง", "ตรวจสอบ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            sqlDr.Close()
            Exit Sub
        End If
        sqlDr.Close()
        Conn.Close()
        If User_Status = "0" Then
            Me.Hide()
            frmAdminMenu.Show()
        End If
        If User_Status = "1" Then
            Me.Hide()
            ' frmUserMenu.Show()
        End If
        MessageBox.Show("ยินดีต้อนรับ  " & U_Name)
    End Sub

End Class
