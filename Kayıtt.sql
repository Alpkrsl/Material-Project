USE [STOK3]
GO

/****** Object:  Table [dbo].[Kayıt]    Script Date: 9.09.2024 11:18:54 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Kayıt](
	[KayıtId] [int] IDENTITY(1,1) NOT NULL,
	[EklendiğiTarih] [date] NULL,
	[SilindiğiTarih] [date] NULL,
	[GüncellendiğiTarih] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[KayıtId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


