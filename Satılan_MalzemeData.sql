USE [STOK3]
GO

/****** Object:  Table [dbo].[Sat�lan_MalzemeData]    Script Date: 9.09.2024 11:20:22 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Sat�lan_MalzemeData](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[I��iID] [int] NULL,
	[PatronID] [int] NULL,
	[MalzemeID] [int] NULL,
	[SilinenID] [int] NULL,
	[Yeni_G�ncelID] [int] NULL,
	[Eski_G�ncelID] [int] NULL,
	[EklenenlerID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


