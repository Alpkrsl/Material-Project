USE [STOK3]
GO

/****** Object:  StoredProcedure [dbo].[KAYITÇAĞIR]    Script Date: 9.09.2024 11:42:01 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[KAYITÇAĞIR]
@P1 INT
AS
BEGIN
SELECT*FROM YeniKayıt
WHERE ID=@P1
END
GO


