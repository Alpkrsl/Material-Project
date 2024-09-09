USE [STOK3]
GO

/****** Object:  Table [dbo].[I��iler]    Script Date: 9.09.2024 11:17:34 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[I��iler](
	[Kullan�c�ID] [int] IDENTITY(1,1) NOT NULL,
	[Kullan�c�Ad] [varchar](15) NULL,
	[Kullan�c�Soyad] [varchar](20) NULL,
	[Kullan�c�Departman] [varchar](20) NULL,
	[Kullan�c�TC] [char](11) NULL,
	[Kullan�c��ifre] [char](11) NULL,
	[Satt���MalzemeAdedi] [varchar](10) NULL,
	[R�tbe] [varchar](20) NULL,
	[Maa�] [char](6) NULL,
PRIMARY KEY CLUSTERED 
(
	[Kullan�c�ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


