USE [STOK3]
GO

/****** Object:  Table [dbo].[Patronlar]    Script Date: 9.09.2024 11:20:08 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Patronlar](
	[Kullan�c�ID] [int] IDENTITY(1,1) NOT NULL,
	[Kullan�c�Ad] [varchar](15) NULL,
	[Kullan�c�Soyad] [varchar](20) NULL,
	[Kullan�c�Departman] [varchar](20) NULL,
	[Kullan�c�TC] [char](11) NULL,
	[Kullan�c��ifre] [char](11) NULL,
PRIMARY KEY CLUSTERED 
(
	[Kullan�c�ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


