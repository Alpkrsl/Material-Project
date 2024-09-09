USE [STOK3]
GO

/****** Object:  View [dbo].[DÜÞÜK_G]    Script Date: 9.09.2024 11:23:37 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[DÜÞÜK_G]
as
SELECT MalzemeAdi, MalzemeKodu, YillikSatiþ, BirimFiyat, MinStok, TSüresi FROM YeniKayýt
GO


