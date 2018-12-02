Imports System.Data.SqlClient
Public Class login
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Private Sub btnlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogin.Click
        Dim sql As String
        Dim sqlCmd As SqlCommand
        Dim sqlDr As SqlDataReader
        Module1.Connect()
        sql = "SELECT U_User, U_Status ,U_Name,U_ID FROM Userr WHERE U_User = '" & txtUser.Text & "' AND U_Pass = '" & txtPass.Text & "'"
        sqlCmd = New SqlCommand(sql, Conn)
        sqlDr = sqlCmd.ExecuteReader
        If sqlDr.Read() Then
            User_Na = sqlDr.Item(0)
            User_Status = sqlDr.Item(1)
            U_Name = sqlDr.Item(2)
            U_ID = sqlDr.Item(3)

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
            frmUserMenu.Show()
        End If
        'MessageBox.Show("            ยินดีต้อนรับ " & U_Name)
    End Sub

    Private Sub Panel1_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseDown
        drag = True
        mousex = Cursor.Position.X - Me.Left
        mousey = Cursor.Position.Y - Me.Top
    End Sub

    Private Sub Panel1_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseMove
        If drag Then
            Me.Top = Cursor.Position.Y - mousey
            Me.Left = Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub Panel1_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseUp
        drag = False
    End Sub


    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Application.Exit()

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub


    Private Sub txtPass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUser.Click

    End Sub

    Private Sub txtUser_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtUser.MouseClick
        txtUser.Text = Nothing
    End Sub

    Private Sub txtPass_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtPass.MouseClick
        txtPass.Text = Nothing
        txtPass.PasswordChar = "*"
    End Sub

    Private Sub login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnClean_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClean.Click
        txtUser.Text = ""
        txtPass.Text = ""

    End Sub


End Class
