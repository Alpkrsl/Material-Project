USE [STOK3]
GO

/****** Object:  View [dbo].[Görünümm]    Script Date: 9.09.2024 11:24:03 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE VIEW [dbo].[Görünümm]
as
SELECT        MalzemeAdi, MalzemeKodu, YillikSatiþ, BirimFiyat, MinStok, TSüresi, ID
FROM            dbo.YeniKayýt
GO


