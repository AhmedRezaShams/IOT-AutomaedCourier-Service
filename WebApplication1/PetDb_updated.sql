USE [PetDb]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 4/27/2023 4:14:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pets]    Script Date: 4/27/2023 4:14:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pets](
	[PetId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[Age] [int] NULL,
	[Color] [varchar](50) NULL,
	[Gender] [varchar](50) NULL,
	[OwnerName] [varchar](50) NULL,
	[Address] [varchar](50) NULL,
	[ImageName] [varchar](300) NULL,
	[Price] [int] NULL,
 CONSTRAINT [PK_Pets] PRIMARY KEY CLUSTERED 
(
	[PetId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Pets] ON 

INSERT [dbo].[Pets] ([PetId], [Name], [Age], [Color], [Gender], [OwnerName], [Address], [ImageName], [Price]) VALUES (1, N'abc Pet', 10, N'Red', N'Male', N'Cita', N'test Address', N'331527083_980364746280337_334082201418479572_n231042140.jpg', 1000)
SET IDENTITY_INSERT [dbo].[Pets] OFF
