USE [STOK3]
GO

/****** Object:  StoredProcedure [dbo].[I��i_G�ster]    Script Date: 9.09.2024 11:38:50 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[I��i_G�ster]
@P1 VARCHAR(11)
AS
BEGIN
SELECT*FROM I��iler
WHERE Kullan�c�ID=@P1
END
GO


