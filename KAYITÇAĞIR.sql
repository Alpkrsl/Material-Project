USE [STOK3]
GO

/****** Object:  StoredProcedure [dbo].[KAYITÇAÐIR]    Script Date: 9.09.2024 11:42:01 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[KAYITÇAÐIR]
@P1 INT
AS
BEGIN
SELECT*FROM YeniKayýt
WHERE ID=@P1
END
GO


