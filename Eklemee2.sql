USE [STOK3]
GO

/****** Object:  StoredProcedure [dbo].[Eklemee2]    Script Date: 9.09.2024 11:33:18 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Eklemee2]
@P1 INT
AS
BEGIN
SELECT*FROM MALZEMELER M
FULL JOIN KAY�T K ON K.Kayit�d=m.ID
WHERE M.ID=@P1
END
GO


