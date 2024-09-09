USE [STOK3]
GO

/****** Object:  Table [dbo].[SİLİNENLER]    Script Date: 9.09.2024 11:20:39 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[SİLİNENLER](
	[Silinenıd] [int] IDENTITY(1,1) NOT NULL,
	[SilindiğiTarih] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[Silinenıd] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


