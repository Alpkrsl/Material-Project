USE [STOK3]
GO

/****** Object:  StoredProcedure [dbo].[Patron_Güncelleme]    Script Date: 9.09.2024 11:43:46 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Patron_Güncelleme]
@P1 varchar(15),
@P2 varchar(20),
@P3 varchar(20),
@P4 char(11),
@P5 char(11),
@P6 INT
AS
BEGIN
UPDATE Patronlar
SET 
KullanıcıAd=@P1,
KullanıcıSoyad=@P2,
KullanıcıDepartman=@P3,
KullanıcıTC=@P4,
KullanıcıŞifre=@P5

WHERE KullanıcıID=@P6

END
GO


