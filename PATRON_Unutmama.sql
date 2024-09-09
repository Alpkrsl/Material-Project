USE [STOK3]
GO

/****** Object:  StoredProcedure [dbo].[PATRON_Unutmama]    Script Date: 9.09.2024 11:44:21 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[PATRON_Unutmama]
@P1 VARCHAR(11)
AS
BEGIN
SELECT*FROM Patronlar
WHERE KullanýcýTC=@P1
END
GO


