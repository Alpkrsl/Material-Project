USE [STOK3]
GO

/****** Object:  Table [dbo].[Eski_G�ncel]    Script Date: 9.09.2024 11:15:53 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Eski_G�ncel](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[MalzemeAdi] [varchar](50) NULL,
	[MalzemeKodu] [varchar](50) NULL,
	[Yilliksati�] [varchar](50) NULL,
	[BirimFiyat] [varchar](50) NULL,
	[MinStok] [varchar](50) NULL,
	[TS�resi] [varchar](50) NULL,
	[G�ncellenme_Tarihi] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


