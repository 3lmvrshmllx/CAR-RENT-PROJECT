USE [master]
GO
/****** Object:  Database [CarRent]    Script Date: 27.05.2020 10:45:03 ******/
CREATE DATABASE [CarRent]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CarRent', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\CarRent.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'CarRent_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\CarRent_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [CarRent] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CarRent].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CarRent] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [CarRent] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [CarRent] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [CarRent] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [CarRent] SET ARITHABORT OFF 
GO
ALTER DATABASE [CarRent] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [CarRent] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [CarRent] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [CarRent] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [CarRent] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [CarRent] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [CarRent] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [CarRent] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [CarRent] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [CarRent] SET  ENABLE_BROKER 
GO
ALTER DATABASE [CarRent] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [CarRent] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [CarRent] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [CarRent] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [CarRent] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [CarRent] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [CarRent] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [CarRent] SET RECOVERY FULL 
GO
ALTER DATABASE [CarRent] SET  MULTI_USER 
GO
ALTER DATABASE [CarRent] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [CarRent] SET DB_CHAINING OFF 
GO
ALTER DATABASE [CarRent] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [CarRent] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [CarRent] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'CarRent', N'ON'
GO
ALTER DATABASE [CarRent] SET QUERY_STORE = OFF
GO
USE [CarRent]
GO
/****** Object:  Table [dbo].[CarModels]    Script Date: 27.05.2020 10:45:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CarModels](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[MakeId] [int] NULL,
	[Name] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cars]    Script Date: 27.05.2020 10:45:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cars](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[MakeId] [int] NULL,
	[CarModelId] [int] NULL,
	[ColorId] [int] NULL,
	[CityId] [int] NULL,
	[Year] [int] NULL,
	[EngineCapacity] [money] NULL,
	[Price] [int] NULL,
	[AddedDate] [datetime] NULL,
	[IsInGarage] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cities]    Script Date: 27.05.2020 10:45:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cities](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Clients]    Script Date: 27.05.2020 10:45:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clients](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](30) NULL,
	[LastName] [nvarchar](30) NULL,
	[BirthDate] [datetime] NULL,
	[CardId] [nvarchar](30) NULL,
	[PhoneNumber] [nvarchar](30) NULL,
	[AddedDate] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Colors]    Script Date: 27.05.2020 10:45:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Colors](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Makes]    Script Date: 27.05.2020 10:45:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Makes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 27.05.2020 10:45:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ClientId] [int] NULL,
	[CarId] [int] NULL,
	[PickUpDate] [datetime] NULL,
	[DropOffDate] [datetime] NULL,
	[CarPrice] [int] NULL,
	[PenaltyPrice] [int] NULL,
	[TotalPrice] [int] NULL,
	[DeliveryDate] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Workers]    Script Date: 27.05.2020 10:45:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Workers](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](30) NULL,
	[LastName] [nvarchar](30) NULL,
	[BirthDate] [datetime] NULL,
	[CardId] [nvarchar](30) NULL,
	[PhoneNumber] [nvarchar](30) NULL,
	[Email] [nvarchar](50) NULL,
	[Username] [nvarchar](50) NULL,
	[PassWord] [nvarchar](50) NULL,
	[AddedDate] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[CarModels] ON 

INSERT [dbo].[CarModels] ([Id], [MakeId], [Name]) VALUES (1, 1, N'E 500')
INSERT [dbo].[CarModels] ([Id], [MakeId], [Name]) VALUES (2, 1, N'S 500')
INSERT [dbo].[CarModels] ([Id], [MakeId], [Name]) VALUES (3, 1, N'ML 350')
INSERT [dbo].[CarModels] ([Id], [MakeId], [Name]) VALUES (4, 1, N'GL 550')
INSERT [dbo].[CarModels] ([Id], [MakeId], [Name]) VALUES (5, 1, N'CLS 400')
INSERT [dbo].[CarModels] ([Id], [MakeId], [Name]) VALUES (6, 2, N'M5')
INSERT [dbo].[CarModels] ([Id], [MakeId], [Name]) VALUES (7, 2, N'530')
INSERT [dbo].[CarModels] ([Id], [MakeId], [Name]) VALUES (8, 2, N'X6')
INSERT [dbo].[CarModels] ([Id], [MakeId], [Name]) VALUES (9, 3, N'GrandCherokee')
INSERT [dbo].[CarModels] ([Id], [MakeId], [Name]) VALUES (10, 3, N'Wrangler')
INSERT [dbo].[CarModels] ([Id], [MakeId], [Name]) VALUES (11, 4, N'Camry')
INSERT [dbo].[CarModels] ([Id], [MakeId], [Name]) VALUES (12, 4, N'Corolla')
INSERT [dbo].[CarModels] ([Id], [MakeId], [Name]) VALUES (13, 4, N'Yaris')
INSERT [dbo].[CarModels] ([Id], [MakeId], [Name]) VALUES (14, 4, N'Prius')
INSERT [dbo].[CarModels] ([Id], [MakeId], [Name]) VALUES (15, 4, N'Prado')
INSERT [dbo].[CarModels] ([Id], [MakeId], [Name]) VALUES (16, 5, N'Juke')
INSERT [dbo].[CarModels] ([Id], [MakeId], [Name]) VALUES (17, 5, N'Qashqai')
INSERT [dbo].[CarModels] ([Id], [MakeId], [Name]) VALUES (18, 5, N'Sunny')
INSERT [dbo].[CarModels] ([Id], [MakeId], [Name]) VALUES (19, 5, N'X-Trail')
INSERT [dbo].[CarModels] ([Id], [MakeId], [Name]) VALUES (20, 6, N'Q7')
INSERT [dbo].[CarModels] ([Id], [MakeId], [Name]) VALUES (21, 6, N'A5')
INSERT [dbo].[CarModels] ([Id], [MakeId], [Name]) VALUES (22, 6, N'Q5')
INSERT [dbo].[CarModels] ([Id], [MakeId], [Name]) VALUES (23, 6, N'RS7')
INSERT [dbo].[CarModels] ([Id], [MakeId], [Name]) VALUES (24, 7, N'Panamera')
INSERT [dbo].[CarModels] ([Id], [MakeId], [Name]) VALUES (25, 7, N'Macan')
INSERT [dbo].[CarModels] ([Id], [MakeId], [Name]) VALUES (26, 7, N'Cayenne')
INSERT [dbo].[CarModels] ([Id], [MakeId], [Name]) VALUES (27, 8, N'Grandeur')
INSERT [dbo].[CarModels] ([Id], [MakeId], [Name]) VALUES (28, 8, N'Azera')
INSERT [dbo].[CarModels] ([Id], [MakeId], [Name]) VALUES (29, 8, N'Sonata')
INSERT [dbo].[CarModels] ([Id], [MakeId], [Name]) VALUES (30, 8, N'SantaFe')
INSERT [dbo].[CarModels] ([Id], [MakeId], [Name]) VALUES (31, 9, N'Rio')
INSERT [dbo].[CarModels] ([Id], [MakeId], [Name]) VALUES (32, 9, N'Cerato')
INSERT [dbo].[CarModels] ([Id], [MakeId], [Name]) VALUES (33, 9, N'Cadenza')
INSERT [dbo].[CarModels] ([Id], [MakeId], [Name]) VALUES (34, 9, N'Sorento')
INSERT [dbo].[CarModels] ([Id], [MakeId], [Name]) VALUES (35, 10, N'6')
INSERT [dbo].[CarModels] ([Id], [MakeId], [Name]) VALUES (36, 10, N'CX-3')
INSERT [dbo].[CarModels] ([Id], [MakeId], [Name]) VALUES (37, 10, N'CX-5')
INSERT [dbo].[CarModels] ([Id], [MakeId], [Name]) VALUES (38, 11, N'Accord')
INSERT [dbo].[CarModels] ([Id], [MakeId], [Name]) VALUES (39, 11, N'Civic')
INSERT [dbo].[CarModels] ([Id], [MakeId], [Name]) VALUES (40, 11, N'Pilot')
INSERT [dbo].[CarModels] ([Id], [MakeId], [Name]) VALUES (41, 12, N'FX45')
INSERT [dbo].[CarModels] ([Id], [MakeId], [Name]) VALUES (42, 12, N'FX50')
INSERT [dbo].[CarModels] ([Id], [MakeId], [Name]) VALUES (43, 12, N'FX35')
INSERT [dbo].[CarModels] ([Id], [MakeId], [Name]) VALUES (44, 13, N'DB11')
INSERT [dbo].[CarModels] ([Id], [MakeId], [Name]) VALUES (45, 13, N'DB9')
INSERT [dbo].[CarModels] ([Id], [MakeId], [Name]) VALUES (46, 13, N'Rapide')
INSERT [dbo].[CarModels] ([Id], [MakeId], [Name]) VALUES (47, 14, N'Escalade')
INSERT [dbo].[CarModels] ([Id], [MakeId], [Name]) VALUES (48, 14, N'SRX')
INSERT [dbo].[CarModels] ([Id], [MakeId], [Name]) VALUES (49, 14, N'STS')
INSERT [dbo].[CarModels] ([Id], [MakeId], [Name]) VALUES (50, 15, N'GranTurismo')
INSERT [dbo].[CarModels] ([Id], [MakeId], [Name]) VALUES (51, 15, N'Ghibli')
INSERT [dbo].[CarModels] ([Id], [MakeId], [Name]) VALUES (52, 15, N'Levante S')
SET IDENTITY_INSERT [dbo].[CarModels] OFF
SET IDENTITY_INSERT [dbo].[Cars] ON 

INSERT [dbo].[Cars] ([Id], [MakeId], [CarModelId], [ColorId], [CityId], [Year], [EngineCapacity], [Price], [AddedDate], [IsInGarage]) VALUES (1, 1, 2, 1, 1, 2017, 5.0000, 300, CAST(N'2020-05-09T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Cars] ([Id], [MakeId], [CarModelId], [ColorId], [CityId], [Year], [EngineCapacity], [Price], [AddedDate], [IsInGarage]) VALUES (3, 1, 3, 1, 1, 2016, 3.5000, 150, CAST(N'2020-05-10T12:43:47.137' AS DateTime), 1)
INSERT [dbo].[Cars] ([Id], [MakeId], [CarModelId], [ColorId], [CityId], [Year], [EngineCapacity], [Price], [AddedDate], [IsInGarage]) VALUES (4, 4, 15, 3, 2, 2018, 2.7000, 120, CAST(N'2020-05-10T12:53:35.183' AS DateTime), 1)
INSERT [dbo].[Cars] ([Id], [MakeId], [CarModelId], [ColorId], [CityId], [Year], [EngineCapacity], [Price], [AddedDate], [IsInGarage]) VALUES (5, 6, 20, 4, 3, 2020, 4.2000, 130, CAST(N'2020-05-10T12:59:31.007' AS DateTime), 1)
INSERT [dbo].[Cars] ([Id], [MakeId], [CarModelId], [ColorId], [CityId], [Year], [EngineCapacity], [Price], [AddedDate], [IsInGarage]) VALUES (6, 7, 26, 2, 1, 2015, 4.8000, 200, CAST(N'2020-05-11T21:44:21.300' AS DateTime), 0)
INSERT [dbo].[Cars] ([Id], [MakeId], [CarModelId], [ColorId], [CityId], [Year], [EngineCapacity], [Price], [AddedDate], [IsInGarage]) VALUES (7, 2, 7, 3, 2, 2019, 3.5000, 140, CAST(N'2020-05-10T14:54:51.753' AS DateTime), 0)
INSERT [dbo].[Cars] ([Id], [MakeId], [CarModelId], [ColorId], [CityId], [Year], [EngineCapacity], [Price], [AddedDate], [IsInGarage]) VALUES (8, 9, 31, 2, 3, 2015, 1.4000, 90, CAST(N'2020-05-10T15:49:35.457' AS DateTime), 1)
INSERT [dbo].[Cars] ([Id], [MakeId], [CarModelId], [ColorId], [CityId], [Year], [EngineCapacity], [Price], [AddedDate], [IsInGarage]) VALUES (9, 2, 6, 4, 1, 2019, 5.0000, 160, CAST(N'2020-05-10T18:37:14.557' AS DateTime), 1)
INSERT [dbo].[Cars] ([Id], [MakeId], [CarModelId], [ColorId], [CityId], [Year], [EngineCapacity], [Price], [AddedDate], [IsInGarage]) VALUES (10, 10, 36, 1, 1, 2015, 2.0000, 100, CAST(N'2020-05-11T13:34:50.940' AS DateTime), 1)
INSERT [dbo].[Cars] ([Id], [MakeId], [CarModelId], [ColorId], [CityId], [Year], [EngineCapacity], [Price], [AddedDate], [IsInGarage]) VALUES (11, 8, 27, 3, 1, 2018, 3.0000, 120, CAST(N'2020-05-11T21:46:06.740' AS DateTime), 0)
INSERT [dbo].[Cars] ([Id], [MakeId], [CarModelId], [ColorId], [CityId], [Year], [EngineCapacity], [Price], [AddedDate], [IsInGarage]) VALUES (12, 7, 24, 1, 2, 2019, 6.3000, 300, CAST(N'2020-05-11T21:57:00.197' AS DateTime), 0)
INSERT [dbo].[Cars] ([Id], [MakeId], [CarModelId], [ColorId], [CityId], [Year], [EngineCapacity], [Price], [AddedDate], [IsInGarage]) VALUES (13, 7, 25, 2, 3, 2018, 5.0000, 270, CAST(N'2020-05-11T22:02:03.607' AS DateTime), 0)
SET IDENTITY_INSERT [dbo].[Cars] OFF
SET IDENTITY_INSERT [dbo].[Cities] ON 

INSERT [dbo].[Cities] ([Id], [Name]) VALUES (1, N'Baku')
INSERT [dbo].[Cities] ([Id], [Name]) VALUES (2, N'Sumqayit')
INSERT [dbo].[Cities] ([Id], [Name]) VALUES (3, N'Ganja')
SET IDENTITY_INSERT [dbo].[Cities] OFF
SET IDENTITY_INSERT [dbo].[Clients] ON 

INSERT [dbo].[Clients] ([Id], [FirstName], [LastName], [BirthDate], [CardId], [PhoneNumber], [AddedDate]) VALUES (1, N'Anar', N'Ismayilov', CAST(N'1995-02-21T00:00:00.000' AS DateTime), N'AZE32567612', N'+994505504563', CAST(N'2020-05-11T13:35:53.643' AS DateTime))
INSERT [dbo].[Clients] ([Id], [FirstName], [LastName], [BirthDate], [CardId], [PhoneNumber], [AddedDate]) VALUES (2, N'Murad', N'Agalarov', CAST(N'1994-07-14T00:00:00.000' AS DateTime), N'AZE34215687', N'+994705552555', CAST(N'2020-05-09T00:00:00.000' AS DateTime))
INSERT [dbo].[Clients] ([Id], [FirstName], [LastName], [BirthDate], [CardId], [PhoneNumber], [AddedDate]) VALUES (3, N'Ibrahim', N'Gadirov', CAST(N'1999-01-30T00:00:00.000' AS DateTime), N'AZE12345678', N'+994552523434', CAST(N'2020-05-09T00:00:00.000' AS DateTime))
INSERT [dbo].[Clients] ([Id], [FirstName], [LastName], [BirthDate], [CardId], [PhoneNumber], [AddedDate]) VALUES (4, N'Ahmad', N'Ahmadov', CAST(N'1999-12-20T21:13:01.000' AS DateTime), N'AZE12649035', N'+994553845246', CAST(N'2020-05-10T21:58:14.130' AS DateTime))
INSERT [dbo].[Clients] ([Id], [FirstName], [LastName], [BirthDate], [CardId], [PhoneNumber], [AddedDate]) VALUES (6, N'Ali', N'Agazade', CAST(N'1998-07-11T20:59:07.000' AS DateTime), N'AZE46279823', N'+994505367292', CAST(N'2020-05-11T21:00:28.150' AS DateTime))
INSERT [dbo].[Clients] ([Id], [FirstName], [LastName], [BirthDate], [CardId], [PhoneNumber], [AddedDate]) VALUES (7, N'Hemid', N'Huseynov', CAST(N'1999-11-18T21:03:02.000' AS DateTime), N'AZE57463435', N'+994504395490', CAST(N'2020-05-11T21:05:07.730' AS DateTime))
INSERT [dbo].[Clients] ([Id], [FirstName], [LastName], [BirthDate], [CardId], [PhoneNumber], [AddedDate]) VALUES (8, N'Seid', N'Memmedov', CAST(N'1995-02-08T21:06:52.000' AS DateTime), N'AZE27457025', N'+994704527025', CAST(N'2020-05-11T21:09:40.393' AS DateTime))
INSERT [dbo].[Clients] ([Id], [FirstName], [LastName], [BirthDate], [CardId], [PhoneNumber], [AddedDate]) VALUES (9, N'Nail', N'Shahbazov', CAST(N'1997-08-30T21:35:56.000' AS DateTime), N'AZE75463522', N'+994559865643', CAST(N'2020-05-11T21:38:18.033' AS DateTime))
INSERT [dbo].[Clients] ([Id], [FirstName], [LastName], [BirthDate], [CardId], [PhoneNumber], [AddedDate]) VALUES (10, N'Murad', N'Alizade', CAST(N'1988-11-09T21:46:40.000' AS DateTime), N'AZE34378953', N'+994556328444', CAST(N'2020-05-11T21:48:34.823' AS DateTime))
INSERT [dbo].[Clients] ([Id], [FirstName], [LastName], [BirthDate], [CardId], [PhoneNumber], [AddedDate]) VALUES (11, N'Amin', N'Ahmadov', CAST(N'1994-07-16T21:52:24.000' AS DateTime), N'AZE12134354', N'+994707702260', CAST(N'2020-05-11T21:56:05.423' AS DateTime))
SET IDENTITY_INSERT [dbo].[Clients] OFF
SET IDENTITY_INSERT [dbo].[Colors] ON 

INSERT [dbo].[Colors] ([Id], [Name]) VALUES (1, N'Black')
INSERT [dbo].[Colors] ([Id], [Name]) VALUES (2, N'Red')
INSERT [dbo].[Colors] ([Id], [Name]) VALUES (3, N'Gray')
INSERT [dbo].[Colors] ([Id], [Name]) VALUES (4, N'White')
SET IDENTITY_INSERT [dbo].[Colors] OFF
SET IDENTITY_INSERT [dbo].[Makes] ON 

INSERT [dbo].[Makes] ([Id], [Name]) VALUES (1, N'Mercedes')
INSERT [dbo].[Makes] ([Id], [Name]) VALUES (2, N'BMW')
INSERT [dbo].[Makes] ([Id], [Name]) VALUES (3, N'Jeep')
INSERT [dbo].[Makes] ([Id], [Name]) VALUES (4, N'Toyota')
INSERT [dbo].[Makes] ([Id], [Name]) VALUES (5, N'Nissan')
INSERT [dbo].[Makes] ([Id], [Name]) VALUES (6, N'Audi')
INSERT [dbo].[Makes] ([Id], [Name]) VALUES (7, N'Porcshe')
INSERT [dbo].[Makes] ([Id], [Name]) VALUES (8, N'Hyundai')
INSERT [dbo].[Makes] ([Id], [Name]) VALUES (9, N'KIA')
INSERT [dbo].[Makes] ([Id], [Name]) VALUES (10, N'Mazda')
INSERT [dbo].[Makes] ([Id], [Name]) VALUES (11, N'Honda')
INSERT [dbo].[Makes] ([Id], [Name]) VALUES (12, N'Infiniti')
INSERT [dbo].[Makes] ([Id], [Name]) VALUES (13, N'Aston Martin')
INSERT [dbo].[Makes] ([Id], [Name]) VALUES (14, N'Cadillac')
INSERT [dbo].[Makes] ([Id], [Name]) VALUES (15, N'Maserati')
SET IDENTITY_INSERT [dbo].[Makes] OFF
SET IDENTITY_INSERT [dbo].[Orders] ON 

INSERT [dbo].[Orders] ([Id], [ClientId], [CarId], [PickUpDate], [DropOffDate], [CarPrice], [PenaltyPrice], [TotalPrice], [DeliveryDate]) VALUES (1, 3, 3, CAST(N'2020-05-11T19:54:27.113' AS DateTime), CAST(N'2020-05-12T19:54:27.000' AS DateTime), 150, 270, 420, CAST(N'2020-05-21T15:48:08.000' AS DateTime))
INSERT [dbo].[Orders] ([Id], [ClientId], [CarId], [PickUpDate], [DropOffDate], [CarPrice], [PenaltyPrice], [TotalPrice], [DeliveryDate]) VALUES (2, 4, 4, CAST(N'2020-05-11T20:10:01.993' AS DateTime), CAST(N'2020-05-14T20:10:01.000' AS DateTime), 360, 0, 360, CAST(N'2020-05-15T02:26:23.000' AS DateTime))
INSERT [dbo].[Orders] ([Id], [ClientId], [CarId], [PickUpDate], [DropOffDate], [CarPrice], [PenaltyPrice], [TotalPrice], [DeliveryDate]) VALUES (6, 1, 10, CAST(N'2020-05-11T20:58:52.503' AS DateTime), CAST(N'2020-05-14T20:58:52.000' AS DateTime), 300, 40, 340, CAST(N'2020-05-17T03:01:11.000' AS DateTime))
INSERT [dbo].[Orders] ([Id], [ClientId], [CarId], [PickUpDate], [DropOffDate], [CarPrice], [PenaltyPrice], [TotalPrice], [DeliveryDate]) VALUES (7, 6, 1, CAST(N'2020-05-11T21:01:24.403' AS DateTime), CAST(N'2020-05-16T21:01:24.000' AS DateTime), 1500, 3960, 5460, CAST(N'2020-05-27T17:16:32.000' AS DateTime))
INSERT [dbo].[Orders] ([Id], [ClientId], [CarId], [PickUpDate], [DropOffDate], [CarPrice], [PenaltyPrice], [TotalPrice], [DeliveryDate]) VALUES (8, 2, 6, CAST(N'2020-05-11T21:02:15.067' AS DateTime), CAST(N'2020-05-18T21:02:15.000' AS DateTime), 160, NULL, NULL, NULL)
INSERT [dbo].[Orders] ([Id], [ClientId], [CarId], [PickUpDate], [DropOffDate], [CarPrice], [PenaltyPrice], [TotalPrice], [DeliveryDate]) VALUES (9, 7, 8, CAST(N'2020-05-11T21:05:13.070' AS DateTime), CAST(N'2020-05-19T21:05:13.000' AS DateTime), 720, 324, 1044, CAST(N'2020-05-22T15:59:47.000' AS DateTime))
INSERT [dbo].[Orders] ([Id], [ClientId], [CarId], [PickUpDate], [DropOffDate], [CarPrice], [PenaltyPrice], [TotalPrice], [DeliveryDate]) VALUES (10, 8, 5, CAST(N'2020-05-11T21:20:15.537' AS DateTime), CAST(N'2020-05-16T21:20:15.000' AS DateTime), 650, 156, 806, CAST(N'2020-05-17T16:03:01.000' AS DateTime))
INSERT [dbo].[Orders] ([Id], [ClientId], [CarId], [PickUpDate], [DropOffDate], [CarPrice], [PenaltyPrice], [TotalPrice], [DeliveryDate]) VALUES (11, 9, 7, CAST(N'2020-05-11T21:41:51.973' AS DateTime), CAST(N'2020-05-20T21:41:51.000' AS DateTime), 140, NULL, NULL, NULL)
INSERT [dbo].[Orders] ([Id], [ClientId], [CarId], [PickUpDate], [DropOffDate], [CarPrice], [PenaltyPrice], [TotalPrice], [DeliveryDate]) VALUES (12, 10, 11, CAST(N'2020-05-11T21:48:40.517' AS DateTime), CAST(N'2020-05-15T21:48:40.000' AS DateTime), 120, NULL, NULL, NULL)
INSERT [dbo].[Orders] ([Id], [ClientId], [CarId], [PickUpDate], [DropOffDate], [CarPrice], [PenaltyPrice], [TotalPrice], [DeliveryDate]) VALUES (13, 1, 12, CAST(N'2020-05-11T21:57:05.923' AS DateTime), CAST(N'2020-05-21T21:57:05.000' AS DateTime), 300, NULL, NULL, NULL)
INSERT [dbo].[Orders] ([Id], [ClientId], [CarId], [PickUpDate], [DropOffDate], [CarPrice], [PenaltyPrice], [TotalPrice], [DeliveryDate]) VALUES (14, 11, 13, CAST(N'2020-05-11T22:02:10.983' AS DateTime), CAST(N'2020-05-11T22:02:10.980' AS DateTime), 270, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Orders] OFF
SET IDENTITY_INSERT [dbo].[Workers] ON 

INSERT [dbo].[Workers] ([Id], [FirstName], [LastName], [BirthDate], [CardId], [PhoneNumber], [Email], [Username], [PassWord], [AddedDate]) VALUES (1, N'Kanan', N'Katibli', CAST(N'1999-01-09T00:00:00.000' AS DateTime), N'AZE13456743', N'+994557328025', N'kananktb@gmail.com', N'katibliknn', N'kanan1234', CAST(N'2020-05-09T00:00:00.000' AS DateTime))
INSERT [dbo].[Workers] ([Id], [FirstName], [LastName], [BirthDate], [CardId], [PhoneNumber], [Email], [Username], [PassWord], [AddedDate]) VALUES (2, N'Elvin', N'Kazimov', CAST(N'1998-03-10T00:00:00.000' AS DateTime), N'AZE16437570', N'+994509264563', N'elvinkazim@gmail.com', N'lvnkzmv', N'elvin4321', CAST(N'2020-05-09T00:00:00.000' AS DateTime))
INSERT [dbo].[Workers] ([Id], [FirstName], [LastName], [BirthDate], [CardId], [PhoneNumber], [Email], [Username], [PassWord], [AddedDate]) VALUES (3, N'Ruslan', N'Ceferov', CAST(N'1996-06-22T00:00:00.000' AS DateTime), N'AZE17562634', N'+994552207292', N'ruslan11@gmail.com', N'ruslan11', N'ruslan1996', CAST(N'2020-05-10T22:42:18.033' AS DateTime))
SET IDENTITY_INSERT [dbo].[Workers] OFF
ALTER TABLE [dbo].[CarModels]  WITH CHECK ADD FOREIGN KEY([MakeId])
REFERENCES [dbo].[Makes] ([Id])
GO
ALTER TABLE [dbo].[Cars]  WITH CHECK ADD FOREIGN KEY([CarModelId])
REFERENCES [dbo].[CarModels] ([Id])
GO
ALTER TABLE [dbo].[Cars]  WITH CHECK ADD FOREIGN KEY([CityId])
REFERENCES [dbo].[Cities] ([Id])
GO
ALTER TABLE [dbo].[Cars]  WITH CHECK ADD FOREIGN KEY([ColorId])
REFERENCES [dbo].[Colors] ([Id])
GO
ALTER TABLE [dbo].[Cars]  WITH CHECK ADD FOREIGN KEY([MakeId])
REFERENCES [dbo].[Makes] ([Id])
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD FOREIGN KEY([CarId])
REFERENCES [dbo].[Cars] ([Id])
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD FOREIGN KEY([ClientId])
REFERENCES [dbo].[Clients] ([Id])
GO
USE [master]
GO
ALTER DATABASE [CarRent] SET  READ_WRITE 
GO
