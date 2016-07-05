Imports System.Data.SqlClient
Imports System.Data
Public Class Class1
    Public Function Loadkhachang() As DataSet
        Dim chuoiketnoi As String = "workstation id=PS02875.mssql.somee.com;packet size=4096;user id=tuyetngan2496_SQLLogin_4;pwd=qeqjqoqm11;data source=PS02875.mssql.somee.com;persist security info=False;initial catalog=PS02875"
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim LoadKH As New SqlDataAdapter("select MAKH as 'Mã KH' ,TENKH as 'Tên Khách Hàng', DIACHI as 'Địa chỉ', SDT as 'SĐT', EMAIL from KHACHANG", conn)
        Dim db As New DataSet
        conn.Open()
        LoadKH.Fill(db)
        conn.Close()
        Return db
    End Function
    Public Function Loadsanpham() As DataSet
        Dim chuoiketnoi As String = "workstation id=PS02875.mssql.somee.com;packet size=4096;user id=tuyetngan2496_SQLLogin_4;pwd=qeqjqoqm11;data source=PS02875.mssql.somee.com;persist security info=False;initial catalog=PS02875"
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim LoadSP As New SqlDataAdapter("select MaSP as 'Mã sản phẩm', TenSP as 'Tên sản phẩm', Soluong as 'Số lượng', Dongia as 'Đơn Giá',Soluong * Dongia as 'Thành tiền' from SANPHAM1", conn)
        Dim db As New DataSet
        conn.Open()
        LoadSP.Fill(db)
        conn.Close()
        Return db
    End Function
End Class
