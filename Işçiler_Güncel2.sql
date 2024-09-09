USE [STOK3]
GO

/****** Object:  StoredProcedure [dbo].[Iþçiler_Güncel2]    Script Date: 9.09.2024 11:39:26 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Iþçiler_Güncel2]
@R1 VARCHAR(20),
@R2 VARCHAR(10),
@R3 CHAR(6),
@R4 INT
AS
BEGIN
UPDATE Iþçiler
SET Rütbe=@R1,
SattýðýMalzemeAdedi=@R2,
Maaþ=@R3

WHERE KullanýcýID=@R4
END
GO


