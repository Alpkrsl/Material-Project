USE [STOK3]
GO

/****** Object:  Table [dbo].[Satýlan_MalzemeData]    Script Date: 9.09.2024 11:20:22 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Satýlan_MalzemeData](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[IþçiID] [int] NULL,
	[PatronID] [int] NULL,
	[MalzemeID] [int] NULL,
	[SilinenID] [int] NULL,
	[Yeni_GüncelID] [int] NULL,
	[Eski_GüncelID] [int] NULL,
	[EklenenlerID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


