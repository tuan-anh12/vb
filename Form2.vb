Imports Microsoft.Data.SqlClient
Public Class FrmMain
    Dim connectionString As String = "Data Source=DESKTOP-15BDHIF\SQLEXPRESS;Initial Catalog=QLSinhVien;Integrated Security=True;Encrypt=True;Trust Server Certificate=True"
    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSinhVien()
    End Sub

    Private Sub LoadSinhVien()
        Using conn As New SqlConnection(connectionString)
            Dim sql As String = "SELECT SV.MaSV, SV.HoTen, SV.NgaySinh, SV.GioiTinh, SV.DiaChi, 
                                        L.MaLop, L.TenLop, L.GiangVien, 
                                        MH.MaMonHoc, MH.TenMonHoc, 
                                        DT.DiemThi
                                 FROM SinhVien SV
                                 LEFT JOIN Lop L ON SV.MaLop = L.MaLop
                                 LEFT JOIN DiemThi DT ON SV.MaSV = DT.MaSV
                                 LEFT JOIN MonHoc MH ON DT.MaMonHoc = MH.MaMonHoc"
            cboGioiTinh.Items.Clear()
            cboGioiTinh.Items.Add("Nam")
            cboGioiTinh.Items.Add("Nữ")
            cboGioiTinh.SelectedIndex = -1
            Dim da As New SqlDataAdapter(sql, conn)
            Dim dt As New DataTable()
            da.Fill(dt)
            dgvSinhVien.DataSource = dt
        End Using
    End Sub
    Private Sub ClearForm()
        txtMasv.Clear()
        txtHoten.Clear()
        txtMalop.Clear()
        txtTenlop.Clear()
        txtMaMH.Clear()
        txtTenMH.Clear()
        txtGiangvien.Clear()
        txtDiemthi.Clear()
        txtDiachi.Clear()

        cboGioiTinh.SelectedIndex = -1
        dtpNgaysinh.Value = DateTime.Now
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Using conn As New SqlConnection(connectionString)
            conn.Open()
            Dim sql As String = "INSERT INTO SinhVien(MaSV, HoTen, NgaySinh, GioiTinh, DiaChi, MaLop) 
                                 VALUES(@MaSV, @HoTen, @NgaySinh, @GioiTinh, @DiaChi, @MaLop)"
            Dim cmd As New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@MaSV", txtMasv.Text)
            cmd.Parameters.AddWithValue("@HoTen", txtHoten.Text)
            cmd.Parameters.AddWithValue("@NgaySinh", dtpNgaysinh.Value)
            cmd.Parameters.AddWithValue("@GioiTinh", cboGioiTinh.Text)
            cmd.Parameters.AddWithValue("@DiaChi", txtDiachi.Text)
            cmd.Parameters.AddWithValue("@MaLop", txtMalop.Text)
            cmd.ExecuteNonQuery()
            If txtMaMH.Text <> "" AndAlso txtDiemthi.Text <> "" Then
                Dim sql2 As String = "INSERT INTO DiemThi(MaSV, MaMonHoc, DiemThi) VALUES(@MaSV, @MaMonHoc, @DiemThi)"
                Dim cmd2 As New SqlCommand(sql2, conn)
                cmd2.Parameters.AddWithValue("@MaSV", txtMasv.Text)
                cmd2.Parameters.AddWithValue("@MaMonHoc", txtMaMH.Text)
                cmd2.Parameters.AddWithValue("@DiemThi", Convert.ToDouble(txtDiemthi.Text))
                cmd2.ExecuteNonQuery()
            End If

            MessageBox.Show("Thêm sinh viên thành công!")
            LoadSinhVien()
            ClearForm()
        End Using
    End Sub

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        Using conn As New SqlConnection(connectionString)
            conn.Open()
            Dim sql As String = "UPDATE SinhVien 
                                 SET HoTen=@HoTen, NgaySinh=@NgaySinh, GioiTinh=@GioiTinh, DiaChi=@DiaChi, MaLop=@MaLop
                                 WHERE MaSV=@MaSV"
            Dim cmd As New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@MaSV", txtMasv.Text)
            cmd.Parameters.AddWithValue("@HoTen", txtHoten.Text)
            cmd.Parameters.AddWithValue("@NgaySinh", dtpNgaysinh.Value)
            cmd.Parameters.AddWithValue("@GioiTinh", cboGioiTinh.Text)
            cmd.Parameters.AddWithValue("@DiaChi", txtDiachi.Text)
            cmd.Parameters.AddWithValue("@MaLop", txtMalop.Text)
            cmd.ExecuteNonQuery()
            If txtMaMH.Text <> "" AndAlso txtDiemthi.Text <> "" Then
                Dim sql2 As String = "IF EXISTS (SELECT * FROM DiemThi WHERE MaSV=@MaSV AND MaMonHoc=@MaMonHoc)
                                      UPDATE DiemThi SET DiemThi=@DiemThi WHERE MaSV=@MaSV AND MaMonHoc=@MaMonHoc
                                      ELSE
                                      INSERT INTO DiemThi(MaSV, MaMonHoc, DiemThi) VALUES(@MaSV, @MaMonHoc, @DiemThi)"
                Dim cmd2 As New SqlCommand(sql2, conn)
                cmd2.Parameters.AddWithValue("@MaSV", txtMasv.Text)
                cmd2.Parameters.AddWithValue("@MaMonHoc", txtMaMH.Text)
                cmd2.Parameters.AddWithValue("@DiemThi", Convert.ToDouble(txtDiemthi.Text))
                cmd2.ExecuteNonQuery()
            End If

            MessageBox.Show("Sửa sinh viên thành công!")
            LoadSinhVien()
        End Using
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        Using conn As New SqlConnection(connectionString)
            conn.Open()

            Dim sql1 As String = "DELETE FROM DiemThi WHERE MaSV=@MaSV"
            Dim cmd1 As New SqlCommand(sql1, conn)
            cmd1.Parameters.AddWithValue("@MaSV", txtMasv.Text)
            cmd1.ExecuteNonQuery()

            Dim sql2 As String = "DELETE FROM SinhVien WHERE MaSV=@MaSV"
            Dim cmd2 As New SqlCommand(sql2, conn)
            cmd2.Parameters.AddWithValue("@MaSV", txtMasv.Text)
            cmd2.ExecuteNonQuery()

            MessageBox.Show("Xóa sinh viên thành công!")
            LoadSinhVien()
            ClearForm()

        End Using
    End Sub

    Private Sub dgvSinhVien_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSinhVien.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvSinhVien.Rows(e.RowIndex)

            txtMasv.Text = row.Cells("MaSV").Value.ToString()
            txtHoten.Text = row.Cells("HoTen").Value.ToString()
            dtpNgaysinh.Value = CDate(row.Cells("NgaySinh").Value)
            cboGioiTinh.Text = row.Cells("GioiTinh").Value.ToString()
            txtDiachi.Text = row.Cells("DiaChi").Value.ToString()

            txtMalop.Text = row.Cells("MaLop").Value.ToString()
            txtTenlop.Text = row.Cells("TenLop").Value.ToString()
            txtGiangvien.Text = row.Cells("GiangVien").Value.ToString()

            txtMaMH.Text = row.Cells("MaMonHoc").Value.ToString()
            txtTenMH.Text = row.Cells("TenMonHoc").Value.ToString()
            txtDiemthi.Text = row.Cells("DiemThi").Value.ToString()
        End If
    End Sub
End Class