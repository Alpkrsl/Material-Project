USE [STOK3]
GO

/****** Object:  StoredProcedure [dbo].[Iþçiler_Güncelleme]    Script Date: 9.09.2024 11:40:00 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Iþçiler_Güncelleme]
@P1 varchar(15),
@P2 varchar(20),
@P3 varchar(20),
@P4 char(11),
@P5 char(11),
@P6 INT
AS
BEGIN
UPDATE Iþçiler_Yedek
SET 
KullanýcýAd=@P1,
KullanýcýSoyad=@P2,
KullanýcýDepartman=@P3,
KullanýcýTC=@P4,
KullanýcýÞifre=@P5

WHERE KullanýcýID=@P6

END
GO


