-- =============================================
-- TẠO DATABASE
-- =============================================
CREATE DATABASE YY_Module01;
GO

USE YY_Module01;
GO

-- =============================================
-- 3.1. BẢNG USERS
-- =============================================
CREATE TABLE Users (
    UserID INT IDENTITY(1,1) PRIMARY KEY,
    Username VARCHAR(50) NOT NULL UNIQUE,
    PasswordHash VARCHAR(255) NOT NULL,
    Phone VARCHAR(15) NULL,
    Role NVARCHAR(50) NOT NULL
);
GO

-- Tài khoản quản trị mặc định
INSERT INTO Users (Username, PasswordHash, Phone, Role)
VALUES 
('admin', '8c6976e5b5410415bde908bd4dee15dfb167a9c873fc4bb8a81f6f2ab448a918', '0901234567', N'Giảng viên');
GO

-- =============================================
-- 3.2. BẢNG CLASSES
-- =============================================
CREATE TABLE Classes (
    ClassID VARCHAR(20) PRIMARY KEY,
    ClassName NVARCHAR(100) NOT NULL,
    Department NVARCHAR(100)
);
GO

INSERT INTO Classes (ClassID, ClassName, Department)
VALUES
('CNTT01', N'Công nghệ thông tin 01', N'Công nghệ thông tin'),
('CNTT02', N'Công nghệ thông tin 02', N'Công nghệ thông tin'),
('QTKD01', N'Quản trị kinh doanh 01', N'Kinh tế');
GO

-- =============================================
-- 3.3. BẢNG SUBJECTS
-- =============================================
CREATE TABLE Subjects (
    SubjectID VARCHAR(20) PRIMARY KEY,
    SubjectName NVARCHAR(100) NOT NULL,
    SubjectType NVARCHAR(50) NOT NULL,
    Credits INT CHECK (Credits > 0)
);
GO

INSERT INTO Subjects (SubjectID, SubjectName, SubjectType, Credits)
VALUES
('SQL01', N'Cơ sở dữ liệu SQL Server', N'Lý thuyết', 3),
('WEB01', N'Lập trình Web', N'Thực hành', 4),
('JAVA01', N'Lập trình Java', N'Tích hợp', 3),
('NET01', N'Lập trình .NET', N'Thực hành', 3);
GO

-- =============================================
-- 3.4. BẢNG STUDENTS
-- =============================================
CREATE TABLE Students (
    StudentID VARCHAR(20) PRIMARY KEY,
    FullName NVARCHAR(100) NOT NULL,
    DateOfBirth DATE,
    Gender BIT,
    AvatarPath VARCHAR(255),
    ClassID VARCHAR(20),

    CONSTRAINT FK_Students_Classes
        FOREIGN KEY (ClassID)
        REFERENCES Classes(ClassID)
);
GO

INSERT INTO Students 
(StudentID, FullName, DateOfBirth, Gender, AvatarPath, ClassID)
VALUES
('SV001', N'Nguyễn Văn An', '2004-05-12', 1, 'avatars/sv001.jpg', 'CNTT01'),
('SV002', N'Trần Thị Bình', '2004-08-20', 0, 'avatars/sv002.jpg', 'CNTT01'),
('SV003', N'Lê Hoàng Cường', '2003-11-15', 1, 'avatars/sv003.jpg', 'CNTT02'),
('SV004', N'Phạm Thị Dung', '2004-01-10', 0, 'avatars/sv004.jpg', 'QTKD01');
GO

-- =============================================
-- 3.5. BẢNG COURSEREGISTRATIONS
-- =============================================
CREATE TABLE CourseRegistrations (
    StudentID VARCHAR(20),
    SubjectID VARCHAR(20),
    RegistrationDate DATE DEFAULT GETDATE(),

    CONSTRAINT PK_CourseRegistrations
        PRIMARY KEY (StudentID, SubjectID),

    CONSTRAINT FK_CR_Students
        FOREIGN KEY (StudentID)
        REFERENCES Students(StudentID),

    CONSTRAINT FK_CR_Subjects
        FOREIGN KEY (SubjectID)
        REFERENCES Subjects(SubjectID)
);
GO

INSERT INTO CourseRegistrations 
(StudentID, SubjectID, RegistrationDate)
VALUES
('SV001', 'SQL01', GETDATE()),
('SV001', 'WEB01', GETDATE()),
('SV002', 'JAVA01', GETDATE()),
('SV003', 'NET01', GETDATE()),
('SV004', 'SQL01', GETDATE());
GO

-- =============================================
-- KIỂM TRA DỮ LIỆU
-- =============================================
SELECT * FROM Users;
SELECT * FROM Classes;
SELECT * FROM Subjects;
SELECT * FROM Students;
SELECT * FROM CourseRegistrations;
GO