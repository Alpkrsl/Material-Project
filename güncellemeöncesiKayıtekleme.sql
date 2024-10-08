USE [STOK3]
GO

/****** Object:  Table [dbo].[güncellemeöncesiKayıtekleme]    Script Date: 9.09.2024 11:17:08 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[güncellemeöncesiKayıtekleme](
	[KayıtId] [int] IDENTITY(1,1) NOT NULL,
	[EklendiğiTarih] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[KayıtId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[güncellemeöncesiKayıtekleme] ADD  DEFAULT (getdate()) FOR [EklendiğiTarih]
GO


