USE [STOK3]
GO

/****** Object:  StoredProcedure [dbo].[KAYIT�A�IR]    Script Date: 9.09.2024 11:42:01 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[KAYIT�A�IR]
@P1 INT
AS
BEGIN
SELECT*FROM YeniKay�t
WHERE ID=@P1
END
GO


