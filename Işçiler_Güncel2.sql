USE [STOK3]
GO

/****** Object:  StoredProcedure [dbo].[I��iler_G�ncel2]    Script Date: 9.09.2024 11:39:26 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[I��iler_G�ncel2]
@R1 VARCHAR(20),
@R2 VARCHAR(10),
@R3 CHAR(6),
@R4 INT
AS
BEGIN
UPDATE I��iler
SET R�tbe=@R1,
Satt���MalzemeAdedi=@R2,
Maa�=@R3

WHERE Kullan�c�ID=@R4
END
GO


