USE [STOK3]
GO

/****** Object:  StoredProcedure [dbo].[Patron_G�ncelleme]    Script Date: 9.09.2024 11:43:46 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Patron_G�ncelleme]
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
Kullan�c�Ad=@P1,
Kullan�c�Soyad=@P2,
Kullan�c�Departman=@P3,
Kullan�c�TC=@P4,
Kullan�c��ifre=@P5

WHERE Kullan�c�ID=@P6

END
GO


