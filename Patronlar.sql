USE [STOK3]
GO

/****** Object:  Table [dbo].[Patronlar]    Script Date: 9.09.2024 11:20:08 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Patronlar](
	[KullanıcıID] [int] IDENTITY(1,1) NOT NULL,
	[KullanıcıAd] [varchar](15) NULL,
	[KullanıcıSoyad] [varchar](20) NULL,
	[KullanıcıDepartman] [varchar](20) NULL,
	[KullanıcıTC] [char](11) NULL,
	[KullanıcıŞifre] [char](11) NULL,
PRIMARY KEY CLUSTERED 
(
	[KullanıcıID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


