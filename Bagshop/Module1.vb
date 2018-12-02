Imports System.Data
Imports System.Data.SqlClient
Module Module1

    Public strConn As String = "user id=sa; password=1234; data source=LAPTOP-ND6I7A0Q; initial catalog=ASSS" 'Bagshop;"
    'Public strConn As String = "user id=sa; password=1234; data source=LAPTOP-ND6I7A0Q; initial catalog=db_bookshop5;"
    Public Conn As New SqlConnection
    Public User_Na As String
    Public U_Name As String
    Public U_ID As String
    Public User_Status As String
    Public Ed As String

    Public Sub Connect()
        If Conn.State = ConnectionState.Open Then Conn.Close()
        Conn.ConnectionString = strConn
        Conn.Open()

    End Sub
End Module
