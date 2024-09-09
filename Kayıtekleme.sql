USE [STOK3]
GO

/****** Object:  Table [dbo].[Kay�tekleme]    Script Date: 9.09.2024 11:18:27 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Kay�tekleme](
	[Kay�tId] [int] IDENTITY(1,1) NOT NULL,
	[Eklendi�iTarih] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[Kay�tId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Kay�tekleme] ADD  DEFAULT (getdate()) FOR [Eklendi�iTarih]
GO


