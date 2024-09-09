USE [STOK3]
GO

/****** Object:  StoredProcedure [dbo].[Eklemee3]    Script Date: 9.09.2024 11:37:46 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO




CREATE PROCEDURE [dbo].[Eklemee3]
@P1 INT
AS
BEGIN
SELECT*FROM MALZEMELER M
FULL JOIN KAYÝT K ON K.Kayitýd=M.ID
WHERE M.ID=@P1
END
GO


