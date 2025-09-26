<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmDangNhap
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblTenDangNhap = New Label()
        Label2 = New Label()
        txtTenDangNhap = New TextBox()
        txtMatKhau = New TextBox()
        BtnDangNhap = New Button()
        BtnThoat = New Button()
        SuspendLayout()
        ' 
        ' lblTenDangNhap
        ' 
        lblTenDangNhap.AutoSize = True
        lblTenDangNhap.Location = New Point(121, 108)
        lblTenDangNhap.Name = "lblTenDangNhap"
        lblTenDangNhap.Size = New Size(115, 20)
        lblTenDangNhap.TabIndex = 0
        lblTenDangNhap.Text = "Tên Đăng Nhập:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(161, 175)
        Label2.Name = "Label2"
        Label2.Size = New Size(75, 20)
        Label2.TabIndex = 1
        Label2.Text = "Mật Khẩu:"
        ' 
        ' txtTenDangNhap
        ' 
        txtTenDangNhap.Location = New Point(265, 101)
        txtTenDangNhap.Name = "txtTenDangNhap"
        txtTenDangNhap.Size = New Size(277, 27)
        txtTenDangNhap.TabIndex = 2
        ' 
        ' txtMatKhau
        ' 
        txtMatKhau.Location = New Point(265, 172)
        txtMatKhau.Name = "txtMatKhau"
        txtMatKhau.Size = New Size(277, 27)
        txtMatKhau.TabIndex = 3
        ' 
        ' BtnDangNhap
        ' 
        BtnDangNhap.Location = New Point(274, 244)
        BtnDangNhap.Name = "BtnDangNhap"
        BtnDangNhap.Size = New Size(99, 43)
        BtnDangNhap.TabIndex = 4
        BtnDangNhap.Text = "Đăng Nhập"
        BtnDangNhap.UseVisualStyleBackColor = True
        ' 
        ' BtnThoat
        ' 
        BtnThoat.Location = New Point(416, 244)
        BtnThoat.Name = "BtnThoat"
        BtnThoat.Size = New Size(99, 43)
        BtnThoat.TabIndex = 5
        BtnThoat.Text = "Thoát"
        BtnThoat.UseVisualStyleBackColor = True
        ' 
        ' FrmDangNhap
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(811, 389)
        Controls.Add(BtnThoat)
        Controls.Add(BtnDangNhap)
        Controls.Add(txtMatKhau)
        Controls.Add(txtTenDangNhap)
        Controls.Add(Label2)
        Controls.Add(lblTenDangNhap)
        Name = "FrmDangNhap"
        Text = "Đăng Nhập"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTenDangNhap As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTenDangNhap As TextBox
    Friend WithEvents txtMatKhau As TextBox
    Friend WithEvents BtnDangNhap As Button
    Friend WithEvents BtnThoat As Button

End Class
