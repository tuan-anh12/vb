CREATE DATABASE QLSinhVien;
GO


USE QLSinhVien;
GO

CREATE TABLE DangNhap (
    TenDangNhap varchar(50) PRIMARY KEY,
    MatKhau varchar(50)
);
GO

CREATE TABLE Lop (
    MaLop NVARCHAR(10) PRIMARY KEY,     
    TenLop NVARCHAR(100),               
    GiangVien NVARCHAR(100)             
);
GO


CREATE TABLE MonHoc (
    MaMonHoc NVARCHAR(10) PRIMARY KEY,  
    TenMonHoc NVARCHAR(100)             
);
GO


CREATE TABLE SinhVien (
    MaSV NVARCHAR(10) PRIMARY KEY,      
    HoTen NVARCHAR(100),                
    NgaySinh DATE,                     
    GioiTinh NVARCHAR(10),             
    DiaChi NVARCHAR(200),             
    MaLop NVARCHAR(10),               
    CONSTRAINT FK_SinhVien_Lop FOREIGN KEY (MaLop) REFERENCES Lop(MaLop)  
);
GO

CREATE TABLE DiemThi (
    MaSV NVARCHAR(10),                
    MaMonHoc NVARCHAR(10),             
    DiemThi FLOAT,                     
    PRIMARY KEY (MaSV, MaMonHoc),      
    CONSTRAINT FK_DiemThi_SinhVien FOREIGN KEY (MaSV) REFERENCES SinhVien(MaSV),  
    CONSTRAINT FK_DiemThi_MonHoc FOREIGN KEY (MaMonHoc) REFERENCES MonHoc(MaMonHoc) 
);

Insert into Lop values
    ('TH','TH29.15',N'Giảng Viên A'),
    ('DL','DL29.15',N'Giảng Viên B'),
    ('KT','KT29.15',N'Giảng Viên E');
GO

Insert into MonHoc values
    ('CSDL',N'Cơ Sở Dữ Liệu'),
    ('HDDL',N'Hướng Dẫn Du Lịch'),
    ('HDKD',N'Hướng Dẫn Kinh Doanh');
GO

Insert into SinhVien values
    ('001',N'Bùi Viết Tuấn Anh','2006-01-01','Nam',N'Hà Nội','TH'),
    ('002',N'Trần Như Quỳnh','2006-02-02',N'NỮ',N'Hà Nội','DL'),
    ('003',N'Lê Hữu Thắng','2006-03-03','Nam',N'Hà Nôi','KT'),
    ('004',N'Lý Duy Anh','2006-04-04','Nam',N'Hà Nội','TH');
GO

Insert into DiemThi values
    ('001','CSDL',10),
    ('002','HDDL',9),
    ('003','HDKD',8.5),
    ('004','CSDL',7);

