USE [STOK3]
GO

/****** Object:  Table [dbo].[SilinenMalzemeler2]    Script Date: 9.09.2024 11:20:51 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[SilinenMalzemeler2](
	[ID] [int] NULL,
	[MalzemeKodu] [varchar](50) NULL,
	[MalzemeAdi] [varchar](50) NULL,
	[YillikSatis] [varchar](50) NULL,
	[BirimFiyat] [varchar](50) NULL,
	[MinStok] [varchar](50) NULL,
	[TSuresi] [varchar](50) NULL,
	[SilinmeTarihi] [datetime] NULL
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[SilinenMalzemeler2] ADD  DEFAULT (getdate()) FOR [SilinmeTarihi]
GO


