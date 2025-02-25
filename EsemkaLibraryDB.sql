USE [EsemkaLibrary]
GO
/****** Object:  Table [dbo].[Books]    Script Date: 02/03/2025 13:31:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Books](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](255) NOT NULL,
	[Categories_Id] [int] NOT NULL,
	[Writer] [varchar](100) NOT NULL,
	[Publication_Year] [int] NOT NULL,
	[Synopsis] [varchar](max) NOT NULL,
	[Rating] [int] NOT NULL,
	[Likes] [int] NOT NULL,
	[Image] [image] NULL,
	[Stock] [int] NULL,
 CONSTRAINT [PK__Books__3214EC070221BB3A] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Borrow_Books]    Script Date: 02/03/2025 13:31:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Borrow_Books](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[member_Id] [int] NOT NULL,
	[book_Id] [int] NOT NULL,
	[borrow_category_Id] [int] NOT NULL,
	[borrow_date] [datetime] NOT NULL,
	[book_return_date] [datetime] NOT NULL,
	[is_return] [varchar](5) NOT NULL,
 CONSTRAINT [PK_Borrow_Books] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Borrow_Category]    Script Date: 02/03/2025 13:31:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Borrow_Category](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Category] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Borrow_Category] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 02/03/2025 13:31:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](100) NOT NULL,
	[Image] [image] NOT NULL,
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Member]    Script Date: 02/03/2025 13:31:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Member](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](100) NOT NULL,
	[Password] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Member] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Non-Member]    Script Date: 02/03/2025 13:31:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Non-Member](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](100) NOT NULL,
	[Password] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Non-Member] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Saved_Books]    Script Date: 02/03/2025 13:31:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Saved_Books](
	[Book_Id] [int] NOT NULL,
	[Member_Id] [int] NULL,
	[Non_Member_Id] [int] NULL,
	[id] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_Saved_Books_1] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Books] ADD  CONSTRAINT [DF__Books__Likes__3A81B327]  DEFAULT ((0)) FOR [Likes]
GO
ALTER TABLE [dbo].[Books]  WITH CHECK ADD  CONSTRAINT [FK__Books__Categorie__3C69FB99] FOREIGN KEY([Categories_Id])
REFERENCES [dbo].[Categories] ([Id])
GO
ALTER TABLE [dbo].[Books] CHECK CONSTRAINT [FK__Books__Categorie__3C69FB99]
GO
ALTER TABLE [dbo].[Borrow_Books]  WITH CHECK ADD  CONSTRAINT [FK_Borrow_Books_Books] FOREIGN KEY([book_Id])
REFERENCES [dbo].[Books] ([Id])
GO
ALTER TABLE [dbo].[Borrow_Books] CHECK CONSTRAINT [FK_Borrow_Books_Books]
GO
ALTER TABLE [dbo].[Borrow_Books]  WITH CHECK ADD  CONSTRAINT [FK_Borrow_Books_Borrow_Category] FOREIGN KEY([borrow_category_Id])
REFERENCES [dbo].[Borrow_Category] ([Id])
GO
ALTER TABLE [dbo].[Borrow_Books] CHECK CONSTRAINT [FK_Borrow_Books_Borrow_Category]
GO
ALTER TABLE [dbo].[Borrow_Books]  WITH CHECK ADD  CONSTRAINT [FK_Borrow_Books_Member] FOREIGN KEY([member_Id])
REFERENCES [dbo].[Member] ([Id])
GO
ALTER TABLE [dbo].[Borrow_Books] CHECK CONSTRAINT [FK_Borrow_Books_Member]
GO
ALTER TABLE [dbo].[Saved_Books]  WITH CHECK ADD  CONSTRAINT [FK_Saved_Books_Books] FOREIGN KEY([Book_Id])
REFERENCES [dbo].[Books] ([Id])
GO
ALTER TABLE [dbo].[Saved_Books] CHECK CONSTRAINT [FK_Saved_Books_Books]
GO
ALTER TABLE [dbo].[Saved_Books]  WITH CHECK ADD  CONSTRAINT [FK_Saved_Books_Member] FOREIGN KEY([Member_Id])
REFERENCES [dbo].[Member] ([Id])
GO
ALTER TABLE [dbo].[Saved_Books] CHECK CONSTRAINT [FK_Saved_Books_Member]
GO
ALTER TABLE [dbo].[Saved_Books]  WITH CHECK ADD  CONSTRAINT [FK_Saved_Books_Non-Member] FOREIGN KEY([Non_Member_Id])
REFERENCES [dbo].[Non-Member] ([Id])
GO
ALTER TABLE [dbo].[Saved_Books] CHECK CONSTRAINT [FK_Saved_Books_Non-Member]
GO
ALTER TABLE [dbo].[Books]  WITH CHECK ADD  CONSTRAINT [CK__Books__Likes__3B75D760] CHECK  (([likes]>=(0)))
GO
ALTER TABLE [dbo].[Books] CHECK CONSTRAINT [CK__Books__Likes__3B75D760]
GO
