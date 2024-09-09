USE [STOK3]
GO

/****** Object:  Table [dbo].[YeniKayýt]    Script Date: 9.09.2024 11:22:00 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[YeniKayýt](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[MalzemeKodu] [varchar](50) NULL,
	[MalzemeAdi] [varchar](50) NULL,
	[YillikSatiþ] [varchar](50) NULL,
	[BirimFiyat] [varchar](50) NULL,
	[MinStok] [varchar](50) NULL,
	[TSüresi] [varchar](50) NULL,
	[EklenmeTarihi] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


