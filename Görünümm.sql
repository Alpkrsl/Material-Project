USE [STOK3]
GO

/****** Object:  View [dbo].[G�r�n�mm]    Script Date: 9.09.2024 11:24:03 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE VIEW [dbo].[G�r�n�mm]
as
SELECT        MalzemeAdi, MalzemeKodu, YillikSati�, BirimFiyat, MinStok, TS�resi, ID
FROM            dbo.YeniKay�t
GO


