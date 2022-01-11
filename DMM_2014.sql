USE [master]
GO
/****** Object:  Database [DBDMM]    Script Date: 11/01/2022 16:20:02 ******/
CREATE DATABASE [DBDMM]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DBDMM', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\DBDMM.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'DBDMM_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\DBDMM_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DBDMM].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DBDMM] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DBDMM] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DBDMM] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DBDMM] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DBDMM] SET ARITHABORT OFF 
GO
ALTER DATABASE [DBDMM] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DBDMM] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DBDMM] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DBDMM] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DBDMM] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DBDMM] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DBDMM] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DBDMM] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DBDMM] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DBDMM] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DBDMM] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DBDMM] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DBDMM] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DBDMM] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DBDMM] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DBDMM] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DBDMM] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DBDMM] SET RECOVERY FULL 
GO
ALTER DATABASE [DBDMM] SET  MULTI_USER 
GO
ALTER DATABASE [DBDMM] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DBDMM] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DBDMM] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DBDMM] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [DBDMM] SET DELAYED_DURABILITY = DISABLED 
GO
USE [DBDMM]
GO
/****** Object:  Table [dbo].[Debit_Customers]    Script Date: 11/01/2022 16:20:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Debit_Customers](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ID_Supplier] [int] NULL,
	[SupplierName] [nvarchar](max) NULL,
	[FullName] [nvarchar](max) NULL,
	[Debit] [float] NULL,
	[DateT] [datetime] NULL,
 CONSTRAINT [PK_Debit_Customers] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Debit_Suppliers]    Script Date: 11/01/2022 16:20:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Debit_Suppliers](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ID_Supplier] [int] NULL,
	[SupplierName] [nvarchar](max) NULL,
	[FullName] [nvarchar](max) NULL,
	[Debit] [float] NULL,
	[DateT] [datetime] NULL,
 CONSTRAINT [PK_Debit_Suppliers] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PaymentCustomers]    Script Date: 11/01/2022 16:20:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PaymentCustomers](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ID_Supplier] [int] NULL,
	[SupplierName] [nvarchar](max) NULL,
	[Payment] [float] NULL,
	[DateT] [datetime] NULL,
 CONSTRAINT [PK_PaymentCustomers] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PaymentSuppliers]    Script Date: 11/01/2022 16:20:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PaymentSuppliers](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ID_Supplier] [int] NULL,
	[SupplierName] [nvarchar](max) NULL,
	[Payment] [float] NULL,
	[DateT] [datetime] NULL,
 CONSTRAINT [PK_PaymentSuppliers] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TB_Customers]    Script Date: 11/01/2022 16:20:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_Customers](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[FullName] [nvarchar](max) NULL,
	[Phone] [nvarchar](50) NULL,
	[Address] [nvarchar](max) NULL,
	[Debit] [float] NULL,
	[DateT] [datetime] NULL,
 CONSTRAINT [PK_TB_Customers] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TB_Suppliers]    Script Date: 11/01/2022 16:20:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_Suppliers](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[FullName] [nvarchar](max) NULL,
	[Phone] [nvarchar](50) NULL,
	[Address] [nvarchar](max) NULL,
	[Debit] [float] NULL,
	[DateT] [datetime] NULL,
 CONSTRAINT [PK_TB_Suppliers] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[Debit_Customers]  WITH CHECK ADD  CONSTRAINT [FK_Debit_Customers_TB_Customers] FOREIGN KEY([ID_Supplier])
REFERENCES [dbo].[TB_Customers] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Debit_Customers] CHECK CONSTRAINT [FK_Debit_Customers_TB_Customers]
GO
ALTER TABLE [dbo].[Debit_Suppliers]  WITH CHECK ADD  CONSTRAINT [FK_Debit_Suppliers_TB_Suppliers] FOREIGN KEY([ID_Supplier])
REFERENCES [dbo].[TB_Suppliers] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Debit_Suppliers] CHECK CONSTRAINT [FK_Debit_Suppliers_TB_Suppliers]
GO
ALTER TABLE [dbo].[PaymentCustomers]  WITH CHECK ADD  CONSTRAINT [FK_PaymentCustomers_TB_Customers] FOREIGN KEY([ID_Supplier])
REFERENCES [dbo].[TB_Customers] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PaymentCustomers] CHECK CONSTRAINT [FK_PaymentCustomers_TB_Customers]
GO
ALTER TABLE [dbo].[PaymentSuppliers]  WITH CHECK ADD  CONSTRAINT [FK_PaymentSuppliers_TB_Suppliers] FOREIGN KEY([ID_Supplier])
REFERENCES [dbo].[TB_Suppliers] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PaymentSuppliers] CHECK CONSTRAINT [FK_PaymentSuppliers_TB_Suppliers]
GO
USE [master]
GO
ALTER DATABASE [DBDMM] SET  READ_WRITE 
GO
