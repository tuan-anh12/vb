<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        txtTenMH = New TextBox()
        txtMaMH = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        Label12 = New Label()
        txtHoten = New TextBox()
        txtMasv = New TextBox()
        txtMalop = New TextBox()
        txtTenlop = New TextBox()
        txtDiachi = New TextBox()
        dtpNgaysinh = New DateTimePicker()
        txtGiangvien = New TextBox()
        txtDiemthi = New TextBox()
        SqlCommand1 = New Microsoft.Data.SqlClient.SqlCommand()
        cboGioiTinh = New ComboBox()
        dgvSinhVien = New DataGridView()
        Label13 = New Label()
        btnThem = New Button()
        btnXoa = New Button()
        btnSua = New Button()
        CType(dgvSinhVien, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(3, 217)
        Label1.Name = "Label1"
        Label1.Size = New Size(102, 20)
        Label1.TabIndex = 0
        Label1.Text = "Mã  Môn Học:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(5, 251)
        Label2.Name = "Label2"
        Label2.Size = New Size(100, 20)
        Label2.TabIndex = 1
        Label2.Text = "Tên Môn Học:"
        ' 
        ' txtTenMH
        ' 
        txtTenMH.Location = New Point(111, 248)
        txtTenMH.Name = "txtTenMH"
        txtTenMH.Size = New Size(233, 27)
        txtTenMH.TabIndex = 2
        ' 
        ' txtMaMH
        ' 
        txtMaMH.Location = New Point(111, 210)
        txtMaMH.Name = "txtMaMH"
        txtMaMH.Size = New Size(117, 27)
        txtMaMH.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.ForeColor = SystemColors.HotTrack
        Label3.Location = New Point(12, 9)
        Label3.Name = "Label3"
        Label3.Size = New Size(136, 20)
        Label3.TabIndex = 4
        Label3.Text = "Thông tin sinh viên:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(5, 44)
        Label4.Name = "Label4"
        Label4.Size = New Size(59, 20)
        Label4.TabIndex = 5
        Label4.Text = "Họ Tên:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(10, 79)
        Label5.Name = "Label5"
        Label5.Size = New Size(54, 20)
        Label5.TabIndex = 6
        Label5.Text = "Mã SV:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(5, 111)
        Label6.Name = "Label6"
        Label6.Size = New Size(59, 20)
        Label6.TabIndex = 7
        Label6.Text = "Mã lớp:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(359, 44)
        Label7.Name = "Label7"
        Label7.Size = New Size(77, 20)
        Label7.TabIndex = 8
        Label7.Text = "Ngày sinh:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(368, 79)
        Label8.Name = "Label8"
        Label8.Size = New Size(68, 20)
        Label8.TabIndex = 9
        Label8.Text = "Giới tính:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(378, 111)
        Label9.Name = "Label9"
        Label9.Size = New Size(58, 20)
        Label9.TabIndex = 10
        Label9.Text = "Địa chỉ:"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(5, 147)
        Label10.Name = "Label10"
        Label10.Size = New Size(61, 20)
        Label10.TabIndex = 11
        Label10.Text = "Tên lớp:"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(354, 206)
        Label11.Name = "Label11"
        Label11.Size = New Size(82, 20)
        Label11.TabIndex = 12
        Label11.Text = "Giảng viên:"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(367, 248)
        Label12.Name = "Label12"
        Label12.Size = New Size(69, 20)
        Label12.TabIndex = 13
        Label12.Text = "Điểm thi:"
        ' 
        ' txtHoten
        ' 
        txtHoten.Location = New Point(77, 37)
        txtHoten.Name = "txtHoten"
        txtHoten.Size = New Size(233, 27)
        txtHoten.TabIndex = 14
        ' 
        ' txtMasv
        ' 
        txtMasv.Location = New Point(77, 72)
        txtMasv.Name = "txtMasv"
        txtMasv.Size = New Size(174, 27)
        txtMasv.TabIndex = 15
        ' 
        ' txtMalop
        ' 
        txtMalop.Location = New Point(77, 104)
        txtMalop.Name = "txtMalop"
        txtMalop.Size = New Size(174, 27)
        txtMalop.TabIndex = 16
        ' 
        ' txtTenlop
        ' 
        txtTenlop.Location = New Point(77, 140)
        txtTenlop.Name = "txtTenlop"
        txtTenlop.Size = New Size(174, 27)
        txtTenlop.TabIndex = 17
        ' 
        ' txtDiachi
        ' 
        txtDiachi.Location = New Point(442, 105)
        txtDiachi.Name = "txtDiachi"
        txtDiachi.Size = New Size(233, 27)
        txtDiachi.TabIndex = 18
        ' 
        ' dtpNgaysinh
        ' 
        dtpNgaysinh.Location = New Point(442, 39)
        dtpNgaysinh.Name = "dtpNgaysinh"
        dtpNgaysinh.Size = New Size(233, 27)
        dtpNgaysinh.TabIndex = 20
        ' 
        ' txtGiangvien
        ' 
        txtGiangvien.Location = New Point(442, 203)
        txtGiangvien.Name = "txtGiangvien"
        txtGiangvien.Size = New Size(233, 27)
        txtGiangvien.TabIndex = 21
        ' 
        ' txtDiemthi
        ' 
        txtDiemthi.Location = New Point(442, 244)
        txtDiemthi.Name = "txtDiemthi"
        txtDiemthi.Size = New Size(130, 27)
        txtDiemthi.TabIndex = 22
        ' 
        ' SqlCommand1
        ' 
        SqlCommand1.CommandTimeout = 30
        SqlCommand1.EnableOptimizedParameterBinding = False
        ' 
        ' cboGioiTinh
        ' 
        cboGioiTinh.FormattingEnabled = True
        cboGioiTinh.Location = New Point(442, 71)
        cboGioiTinh.Name = "cboGioiTinh"
        cboGioiTinh.Size = New Size(96, 28)
        cboGioiTinh.TabIndex = 23
        ' 
        ' dgvSinhVien
        ' 
        dgvSinhVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvSinhVien.Location = New Point(5, 341)
        dgvSinhVien.Name = "dgvSinhVien"
        dgvSinhVien.RowHeadersWidth = 51
        dgvSinhVien.Size = New Size(937, 200)
        dgvSinhVien.TabIndex = 24
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(5, 307)
        Label13.Name = "Label13"
        Label13.Size = New Size(147, 20)
        Label13.TabIndex = 25
        Label13.Text = "Danh Sách Sinh Viên:"
        ' 
        ' btnThem
        ' 
        btnThem.Location = New Point(12, 559)
        btnThem.Name = "btnThem"
        btnThem.Size = New Size(94, 29)
        btnThem.TabIndex = 26
        btnThem.Text = "Thêm"
        btnThem.UseVisualStyleBackColor = True
        ' 
        ' btnXoa
        ' 
        btnXoa.Location = New Point(237, 559)
        btnXoa.Name = "btnXoa"
        btnXoa.Size = New Size(94, 29)
        btnXoa.TabIndex = 27
        btnXoa.Text = "Xóa"
        btnXoa.UseVisualStyleBackColor = True
        ' 
        ' btnSua
        ' 
        btnSua.Location = New Point(125, 559)
        btnSua.Name = "btnSua"
        btnSua.Size = New Size(94, 29)
        btnSua.TabIndex = 28
        btnSua.Text = "Sửa"
        btnSua.UseVisualStyleBackColor = True
        ' 
        ' FrmMain
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1342, 625)
        Controls.Add(btnSua)
        Controls.Add(btnXoa)
        Controls.Add(btnThem)
        Controls.Add(Label13)
        Controls.Add(dgvSinhVien)
        Controls.Add(cboGioiTinh)
        Controls.Add(txtDiemthi)
        Controls.Add(txtGiangvien)
        Controls.Add(dtpNgaysinh)
        Controls.Add(txtDiachi)
        Controls.Add(txtTenlop)
        Controls.Add(txtMalop)
        Controls.Add(txtMasv)
        Controls.Add(txtHoten)
        Controls.Add(Label12)
        Controls.Add(Label11)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(txtMaMH)
        Controls.Add(txtTenMH)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "FrmMain"
        Text = "MainFrom"
        CType(dgvSinhVien, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTenMH As TextBox
    Friend WithEvents txtMaMH As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtHoten As TextBox
    Friend WithEvents txtMasv As TextBox
    Friend WithEvents txtMalop As TextBox
    Friend WithEvents txtTenlop As TextBox
    Friend WithEvents txtDiachi As TextBox
    Friend WithEvents dtpNgaysinh As DateTimePicker
    Friend WithEvents txtGiangvien As TextBox
    Friend WithEvents txtDiemthi As TextBox
    Friend WithEvents SqlCommand1 As Microsoft.Data.SqlClient.SqlCommand
    Friend WithEvents cboGioiTinh As ComboBox
    Friend WithEvents dgvSinhVien As DataGridView
    Friend WithEvents Label13 As Label
    Friend WithEvents btnThem As Button
    Friend WithEvents btnXoa As Button
    Friend WithEvents btnSua As Button
End Class
