USE [STOK3]
GO

/****** Object:  View [dbo].[Yüksek_G]    Script Date: 9.09.2024 11:29:08 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE VIEW [dbo].[Yüksek_G]
as
SELECT MalzemeAdi, MalzemeKodu, YillikSatiþ, BirimFiyat, MinStok, TSüresi, ID FROM YeniKayýt
GO


