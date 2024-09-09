USE [STOK3]
GO

/****** Object:  View [dbo].[Orta_G]    Script Date: 9.09.2024 11:28:41 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE VIEW [dbo].[Orta_G]
as
SELECT MalzemeAdi, MalzemeKodu, YillikSatiþ, BirimFiyat, MinStok, TSüresi, ID FROM YeniKayýt
GO


