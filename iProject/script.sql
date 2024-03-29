USE [master]
GO
/****** Object:  Database [SchoolManagementSystem]    Script Date: 10/5/2018 10:06:53 AM ******/
CREATE DATABASE [SchoolManagementSystem]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SchoolManagementSystem', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\SchoolManagementSystem.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'SchoolManagementSystem_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\SchoolManagementSystem_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [SchoolManagementSystem] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SchoolManagementSystem].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SchoolManagementSystem] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SchoolManagementSystem] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SchoolManagementSystem] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SchoolManagementSystem] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SchoolManagementSystem] SET ARITHABORT OFF 
GO
ALTER DATABASE [SchoolManagementSystem] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SchoolManagementSystem] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SchoolManagementSystem] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SchoolManagementSystem] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SchoolManagementSystem] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SchoolManagementSystem] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SchoolManagementSystem] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SchoolManagementSystem] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SchoolManagementSystem] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SchoolManagementSystem] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SchoolManagementSystem] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SchoolManagementSystem] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SchoolManagementSystem] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SchoolManagementSystem] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SchoolManagementSystem] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SchoolManagementSystem] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SchoolManagementSystem] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SchoolManagementSystem] SET RECOVERY FULL 
GO
ALTER DATABASE [SchoolManagementSystem] SET  MULTI_USER 
GO
ALTER DATABASE [SchoolManagementSystem] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SchoolManagementSystem] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SchoolManagementSystem] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SchoolManagementSystem] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [SchoolManagementSystem] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'SchoolManagementSystem', N'ON'
GO
USE [SchoolManagementSystem]
GO
/****** Object:  Table [dbo].[tblClass]    Script Date: 10/5/2018 10:06:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblClass](
	[ClassID] [int] IDENTITY(1,1) NOT NULL,
	[ClassName] [nvarchar](50) NOT NULL,
	[ClassSubject] [nvarchar](50) NOT NULL,
	[ClassTime] [nvarchar](50) NOT NULL,
	[ClassTeacherID] [int] NOT NULL,
 CONSTRAINT [PK_tblClass] PRIMARY KEY CLUSTERED 
(
	[ClassID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblEmployee]    Script Date: 10/5/2018 10:06:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblEmployee](
	[EmployeeID] [int] NOT NULL,
	[EmployeeName] [nvarchar](50) NOT NULL,
	[EmployeeFatherName] [nvarchar](50) NOT NULL,
	[DepartmentName] [nvarchar](50) NOT NULL,
	[Month] [nvarchar](50) NOT NULL,
	[BasicSalary] [nvarchar](50) NOT NULL,
	[GrossSalary] [nvarchar](50) NOT NULL,
	[MedicalAllowances] [nvarchar](50) NOT NULL,
	[Tax] [nvarchar](50) NOT NULL,
	[NetSalary] [nvarchar](50) NOT NULL,
	[Status] [nvarchar](50) NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblEmployeeAttendance]    Script Date: 10/5/2018 10:06:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblEmployeeAttendance](
	[EmployeeID] [int] NOT NULL,
	[Date] [nvarchar](50) NOT NULL,
	[Status] [nvarchar](50) NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblFee]    Script Date: 10/5/2018 10:06:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblFee](
	[InvoiceNumber] [nvarchar](50) NOT NULL,
	[GrNumber] [int] NOT NULL,
	[Class] [nvarchar](50) NOT NULL,
	[StudentName] [nvarchar](50) NOT NULL,
	[StudentFatherName] [nvarchar](50) NOT NULL,
	[TotalFee] [nvarchar](50) NOT NULL,
	[DateOfIssue] [nvarchar](50) NOT NULL,
	[DueDate] [nvarchar](50) NOT NULL,
	[Status] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tblFee] PRIMARY KEY CLUSTERED 
(
	[InvoiceNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblLogin]    Script Date: 10/5/2018 10:06:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblLogin](
	[EmployeeID] [int] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[FatherName] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[PhoneNumber] [nvarchar](50) NOT NULL,
	[Qualification] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[Degree] [nvarchar](50) NOT NULL,
	[Nationality] [nvarchar](50) NOT NULL,
	[Address] [nvarchar](50) NOT NULL,
	[MaritalStatus] [nvarchar](50) NOT NULL,
	[Gender] [nvarchar](50) NOT NULL,
	[Religion] [nvarchar](50) NOT NULL,
	[JoiningDate] [nvarchar](50) NOT NULL,
	[City] [nvarchar](50) NOT NULL,
	[DateOfBirth] [nvarchar](50) NOT NULL,
	[Department] [nvarchar](50) NOT NULL,
	[LastSchoolName] [nvarchar](50) NOT NULL,
	[Status] [nvarchar](50) NOT NULL,
	[Salary] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tblLogin] PRIMARY KEY CLUSTERED 
(
	[EmployeeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblMonthlyProfitLoss]    Script Date: 10/5/2018 10:06:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblMonthlyProfitLoss](
	[Date] [nvarchar](50) NOT NULL,
	[Profit] [nvarchar](50) NOT NULL,
	[Loss] [nvarchar](50) NOT NULL,
	[Month] [nvarchar](50) NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblOtherExpense]    Script Date: 10/5/2018 10:06:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblOtherExpense](
	[ExpenseID] [int] NOT NULL,
	[ExpenseType] [nvarchar](50) NOT NULL,
	[ExpenseName] [nvarchar](50) NOT NULL,
	[Budget] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tblOtherExpense] PRIMARY KEY CLUSTERED 
(
	[ExpenseID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblProfitLoss]    Script Date: 10/5/2018 10:06:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblProfitLoss](
	[Income] [nvarchar](50) NOT NULL,
	[IncomeType] [nvarchar](50) NOT NULL,
	[Expense] [nvarchar](50) NOT NULL,
	[ExpenseType] [nvarchar](50) NOT NULL,
	[Date] [nvarchar](50) NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblStudent]    Script Date: 10/5/2018 10:06:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblStudent](
	[StudentID] [int] IDENTITY(1,1) NOT NULL,
	[StudentName] [nvarchar](50) NOT NULL,
	[FatherName] [nvarchar](50) NOT NULL,
	[ContectNumber] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[Gender] [nvarchar](50) NOT NULL,
	[Religion] [nvarchar](50) NOT NULL,
	[DateOfAdmission] [nvarchar](50) NOT NULL,
	[ClassID] [int] NOT NULL,
	[Section] [nvarchar](50) NOT NULL,
	[LastSchool] [nvarchar](50) NOT NULL,
	[Nationality] [nvarchar](50) NOT NULL,
	[City] [nvarchar](50) NOT NULL,
	[DateOfBirth] [nvarchar](50) NOT NULL,
	[Address] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tblStudent] PRIMARY KEY CLUSTERED 
(
	[StudentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblStudentAttendance]    Script Date: 10/5/2018 10:06:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblStudentAttendance](
	[StudentID] [int] NOT NULL,
	[StudentAttendance] [nvarchar](50) NOT NULL,
	[Date] [nvarchar](50) NOT NULL,
	[ClassID] [nvarchar](50) NOT NULL,
	[Section] [nvarchar](50) NOT NULL
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[tblStudent]  WITH CHECK ADD  CONSTRAINT [FK_tblStudent_tblClass] FOREIGN KEY([ClassID])
REFERENCES [dbo].[tblClass] ([ClassID])
GO
ALTER TABLE [dbo].[tblStudent] CHECK CONSTRAINT [FK_tblStudent_tblClass]
GO
USE [master]
GO
ALTER DATABASE [SchoolManagementSystem] SET  READ_WRITE 
GO
