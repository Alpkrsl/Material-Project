USE [STOK3]
GO

/****** Object:  Table [dbo].[Yeni_Güncel]    Script Date: 9.09.2024 11:21:35 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Yeni_Güncel](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[MalzemeAdi] [varchar](50) NULL,
	[MalzemeKodu] [varchar](50) NULL,
	[Yilliksatiþ] [varchar](50) NULL,
	[BirimFiyat] [varchar](50) NULL,
	[MinStok] [varchar](50) NULL,
	[TSüresi] [varchar](50) NULL,
	[Güncellenme_Tarihi] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


