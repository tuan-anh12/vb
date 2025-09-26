
Imports Microsoft.Data.SqlClient
Public Class FrmDangNhap

    Private Sub FrmDangNhap_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conn As New SqlConnection("Data Source=DESKTOP-15BDHIF\SQLEXPRESS;Initial Catalog=QLSinhVien;Integrated Security=True;Trust Server Certificate=True")

    End Sub

    Private Sub BtnDangNhap_Click(sender As Object, e As EventArgs) Handles BtnDangNhap.Click
        Dim tenDangNhap As String = txtTenDangNhap.Text.Trim()
        Dim matKhau As String = txtMatKhau.Text.Trim()
        If tenDangNhap = "TuanAnh" And matKhau = "123456" Then
            MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dim frm As New FrmMain()
            frm.Show()
            Me.Hide()
        Else
            MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub BtnThoat_Click(sender As Object, e As EventArgs) Handles BtnThoat.Click
        Application.Exit()
    End Sub
End Class
