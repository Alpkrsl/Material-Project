USE [STOK3]
GO

/****** Object:  View [dbo].[Y�ksek_G]    Script Date: 9.09.2024 11:29:08 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE VIEW [dbo].[Y�ksek_G]
as
SELECT MalzemeAdi, MalzemeKodu, YillikSati�, BirimFiyat, MinStok, TS�resi, ID FROM YeniKay�t
GO


