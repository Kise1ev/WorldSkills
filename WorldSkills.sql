USE [master]
GO
/****** Object:  Database [WorldSkillsAcademy]    Script Date: 20.01.2024 7:31:23 ******/
CREATE DATABASE [WorldSkillsAcademy]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'WorldSkillsAcademy', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\WorldSkillsAcademy.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'WorldSkillsAcademy_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\WorldSkillsAcademy_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [WorldSkillsAcademy] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [WorldSkillsAcademy].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [WorldSkillsAcademy] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [WorldSkillsAcademy] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [WorldSkillsAcademy] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [WorldSkillsAcademy] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [WorldSkillsAcademy] SET ARITHABORT OFF 
GO
ALTER DATABASE [WorldSkillsAcademy] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [WorldSkillsAcademy] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [WorldSkillsAcademy] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [WorldSkillsAcademy] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [WorldSkillsAcademy] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [WorldSkillsAcademy] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [WorldSkillsAcademy] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [WorldSkillsAcademy] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [WorldSkillsAcademy] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [WorldSkillsAcademy] SET  DISABLE_BROKER 
GO
ALTER DATABASE [WorldSkillsAcademy] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [WorldSkillsAcademy] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [WorldSkillsAcademy] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [WorldSkillsAcademy] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [WorldSkillsAcademy] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [WorldSkillsAcademy] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [WorldSkillsAcademy] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [WorldSkillsAcademy] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [WorldSkillsAcademy] SET  MULTI_USER 
GO
ALTER DATABASE [WorldSkillsAcademy] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [WorldSkillsAcademy] SET DB_CHAINING OFF 
GO
ALTER DATABASE [WorldSkillsAcademy] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [WorldSkillsAcademy] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [WorldSkillsAcademy] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [WorldSkillsAcademy] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [WorldSkillsAcademy] SET QUERY_STORE = OFF
GO
USE [WorldSkillsAcademy]
GO
/****** Object:  Table [dbo].[Discipline]    Script Date: 20.01.2024 7:31:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Discipline](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Discipline] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FormTime]    Script Date: 20.01.2024 7:31:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FormTime](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_FormTime] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GroupName]    Script Date: 20.01.2024 7:31:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GroupName](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Group] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[History]    Script Date: 20.01.2024 7:31:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[History](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [int] NOT NULL,
	[StudentID] [int] NOT NULL,
	[StatusID] [int] NOT NULL,
	[DateEvent] [date] NOT NULL,
 CONSTRAINT [PK_History] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Journal]    Script Date: 20.01.2024 7:31:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Journal](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[StudentID] [int] NOT NULL,
	[DisciplineID] [int] NOT NULL,
	[Evaluation] [int] NOT NULL,
	[GroupID] [int] NOT NULL,
 CONSTRAINT [PK_Journal] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Role]    Script Date: 20.01.2024 7:31:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Role] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Special]    Script Date: 20.01.2024 7:31:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Special](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Special] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Status]    Script Date: 20.01.2024 7:31:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Status](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Status] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Student]    Script Date: 20.01.2024 7:31:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[GroupID] [int] NOT NULL,
	[SpecialID] [int] NOT NULL,
	[YearAddID] [int] NOT NULL,
	[FormTimeID] [int] NOT NULL,
 CONSTRAINT [PK_Student] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Teacher]    Script Date: 20.01.2024 7:31:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Teacher](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[DisciplineID] [int] NOT NULL,
 CONSTRAINT [PK_Teacher] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 20.01.2024 7:31:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Login] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[RoleID] [int] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[DateIn] [date] NOT NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[YearAdd]    Script Date: 20.01.2024 7:31:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[YearAdd](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Year] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_YearAdd] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Discipline] ON 

INSERT [dbo].[Discipline] ([ID], [Name]) VALUES (1, N'Инструменты и средства разработки ПО')
INSERT [dbo].[Discipline] ([ID], [Name]) VALUES (2, N'Проектирование ИС')
INSERT [dbo].[Discipline] ([ID], [Name]) VALUES (3, N'Разработка кода ИС')
SET IDENTITY_INSERT [dbo].[Discipline] OFF
GO
SET IDENTITY_INSERT [dbo].[FormTime] ON 

INSERT [dbo].[FormTime] ([ID], [Name]) VALUES (1, N'Очная')
INSERT [dbo].[FormTime] ([ID], [Name]) VALUES (2, N'Заочная')
INSERT [dbo].[FormTime] ([ID], [Name]) VALUES (3, N'Дистанционная')
SET IDENTITY_INSERT [dbo].[FormTime] OFF
GO
SET IDENTITY_INSERT [dbo].[GroupName] ON 

INSERT [dbo].[GroupName] ([ID], [Name]) VALUES (1, N'AM2020')
INSERT [dbo].[GroupName] ([ID], [Name]) VALUES (2, N'AM2019')
SET IDENTITY_INSERT [dbo].[GroupName] OFF
GO
SET IDENTITY_INSERT [dbo].[Role] ON 

INSERT [dbo].[Role] ([ID], [Name]) VALUES (1, N'Преподаватель')
INSERT [dbo].[Role] ([ID], [Name]) VALUES (2, N'Студент')
INSERT [dbo].[Role] ([ID], [Name]) VALUES (3, N'Администратор')
SET IDENTITY_INSERT [dbo].[Role] OFF
GO
SET IDENTITY_INSERT [dbo].[Special] ON 

INSERT [dbo].[Special] ([ID], [Name]) VALUES (1, N'09.02.07')
INSERT [dbo].[Special] ([ID], [Name]) VALUES (2, N'09.02.05')
SET IDENTITY_INSERT [dbo].[Special] OFF
GO
SET IDENTITY_INSERT [dbo].[Status] ON 

INSERT [dbo].[Status] ([ID], [Name]) VALUES (1, N'Редактирование оценки')
INSERT [dbo].[Status] ([ID], [Name]) VALUES (2, N'Добавление студента')
INSERT [dbo].[Status] ([ID], [Name]) VALUES (3, N'Редактирование студента')
INSERT [dbo].[Status] ([ID], [Name]) VALUES (4, N'Удаление студента')
SET IDENTITY_INSERT [dbo].[Status] OFF
GO
SET IDENTITY_INSERT [dbo].[Student] ON 

INSERT [dbo].[Student] ([ID], [Name], [GroupID], [SpecialID], [YearAddID], [FormTimeID]) VALUES (6, N'Лавринов Иван Сергеевич', 2, 1, 1, 1)
INSERT [dbo].[Student] ([ID], [Name], [GroupID], [SpecialID], [YearAddID], [FormTimeID]) VALUES (7, N'Лагуткин Никита Антонович', 2, 1, 1, 1)
INSERT [dbo].[Student] ([ID], [Name], [GroupID], [SpecialID], [YearAddID], [FormTimeID]) VALUES (8, N'Стародубцев Андрей Васильевич', 1, 1, 2, 1)
SET IDENTITY_INSERT [dbo].[Student] OFF
GO
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([ID], [Login], [Password], [RoleID], [Name], [DateIn]) VALUES (1, N'teacher', N'12345', 1, N'Наталья', CAST(N'2024-01-20' AS Date))
INSERT [dbo].[User] ([ID], [Login], [Password], [RoleID], [Name], [DateIn]) VALUES (2, N'student', N'54321', 2, N'Андрей', CAST(N'2024-01-20' AS Date))
INSERT [dbo].[User] ([ID], [Login], [Password], [RoleID], [Name], [DateIn]) VALUES (3, N'admin', N'qwerty', 3, N'Василий', CAST(N'2024-01-20' AS Date))
SET IDENTITY_INSERT [dbo].[User] OFF
GO
SET IDENTITY_INSERT [dbo].[YearAdd] ON 

INSERT [dbo].[YearAdd] ([ID], [Year]) VALUES (1, N'2019')
INSERT [dbo].[YearAdd] ([ID], [Year]) VALUES (2, N'2020')
SET IDENTITY_INSERT [dbo].[YearAdd] OFF
GO
ALTER TABLE [dbo].[History] ADD  CONSTRAINT [DF_History_DateEvent]  DEFAULT (getdate()) FOR [DateEvent]
GO
ALTER TABLE [dbo].[User] ADD  CONSTRAINT [DF_User_Role]  DEFAULT ((2)) FOR [RoleID]
GO
ALTER TABLE [dbo].[User] ADD  CONSTRAINT [DF_User_DateIn]  DEFAULT (getdate()) FOR [DateIn]
GO
ALTER TABLE [dbo].[History]  WITH CHECK ADD  CONSTRAINT [FK_History_Status] FOREIGN KEY([StatusID])
REFERENCES [dbo].[Status] ([ID])
GO
ALTER TABLE [dbo].[History] CHECK CONSTRAINT [FK_History_Status]
GO
ALTER TABLE [dbo].[History]  WITH CHECK ADD  CONSTRAINT [FK_History_Student] FOREIGN KEY([StudentID])
REFERENCES [dbo].[Student] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[History] CHECK CONSTRAINT [FK_History_Student]
GO
ALTER TABLE [dbo].[History]  WITH CHECK ADD  CONSTRAINT [FK_History_User] FOREIGN KEY([UserID])
REFERENCES [dbo].[User] ([ID])
GO
ALTER TABLE [dbo].[History] CHECK CONSTRAINT [FK_History_User]
GO
ALTER TABLE [dbo].[Journal]  WITH CHECK ADD  CONSTRAINT [FK_Journal_Discipline] FOREIGN KEY([DisciplineID])
REFERENCES [dbo].[Discipline] ([ID])
GO
ALTER TABLE [dbo].[Journal] CHECK CONSTRAINT [FK_Journal_Discipline]
GO
ALTER TABLE [dbo].[Journal]  WITH CHECK ADD  CONSTRAINT [FK_Journal_Group] FOREIGN KEY([GroupID])
REFERENCES [dbo].[GroupName] ([ID])
GO
ALTER TABLE [dbo].[Journal] CHECK CONSTRAINT [FK_Journal_Group]
GO
ALTER TABLE [dbo].[Journal]  WITH CHECK ADD  CONSTRAINT [FK_Journal_Student] FOREIGN KEY([StudentID])
REFERENCES [dbo].[Student] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Journal] CHECK CONSTRAINT [FK_Journal_Student]
GO
ALTER TABLE [dbo].[Student]  WITH CHECK ADD  CONSTRAINT [FK_Student_FormTime] FOREIGN KEY([FormTimeID])
REFERENCES [dbo].[FormTime] ([ID])
GO
ALTER TABLE [dbo].[Student] CHECK CONSTRAINT [FK_Student_FormTime]
GO
ALTER TABLE [dbo].[Student]  WITH CHECK ADD  CONSTRAINT [FK_Student_Group] FOREIGN KEY([GroupID])
REFERENCES [dbo].[GroupName] ([ID])
GO
ALTER TABLE [dbo].[Student] CHECK CONSTRAINT [FK_Student_Group]
GO
ALTER TABLE [dbo].[Student]  WITH CHECK ADD  CONSTRAINT [FK_Student_Special] FOREIGN KEY([SpecialID])
REFERENCES [dbo].[Special] ([ID])
GO
ALTER TABLE [dbo].[Student] CHECK CONSTRAINT [FK_Student_Special]
GO
ALTER TABLE [dbo].[Student]  WITH CHECK ADD  CONSTRAINT [FK_Student_YearAdd] FOREIGN KEY([YearAddID])
REFERENCES [dbo].[YearAdd] ([ID])
GO
ALTER TABLE [dbo].[Student] CHECK CONSTRAINT [FK_Student_YearAdd]
GO
ALTER TABLE [dbo].[Teacher]  WITH CHECK ADD  CONSTRAINT [FK_Teacher_Discipline] FOREIGN KEY([DisciplineID])
REFERENCES [dbo].[Discipline] ([ID])
GO
ALTER TABLE [dbo].[Teacher] CHECK CONSTRAINT [FK_Teacher_Discipline]
GO
ALTER TABLE [dbo].[User]  WITH CHECK ADD  CONSTRAINT [FK_User_Role] FOREIGN KEY([RoleID])
REFERENCES [dbo].[Role] ([ID])
GO
ALTER TABLE [dbo].[User] CHECK CONSTRAINT [FK_User_Role]
GO
USE [master]
GO
ALTER DATABASE [WorldSkillsAcademy] SET  READ_WRITE 
GO
