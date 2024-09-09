USE [STOK3]
GO

/****** Object:  Table [dbo].[güncellemeöncesiKayýtekleme]    Script Date: 9.09.2024 11:17:08 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[güncellemeöncesiKayýtekleme](
	[KayýtId] [int] IDENTITY(1,1) NOT NULL,
	[EklendiðiTarih] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[KayýtId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[güncellemeöncesiKayýtekleme] ADD  DEFAULT (getdate()) FOR [EklendiðiTarih]
GO


