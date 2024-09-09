USE [STOK3]
GO

/****** Object:  Table [dbo].[Patronlar]    Script Date: 9.09.2024 11:20:08 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Patronlar](
	[KullanýcýID] [int] IDENTITY(1,1) NOT NULL,
	[KullanýcýAd] [varchar](15) NULL,
	[KullanýcýSoyad] [varchar](20) NULL,
	[KullanýcýDepartman] [varchar](20) NULL,
	[KullanýcýTC] [char](11) NULL,
	[KullanýcýÞifre] [char](11) NULL,
PRIMARY KEY CLUSTERED 
(
	[KullanýcýID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


