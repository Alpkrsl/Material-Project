USE [STOK3]
GO

/****** Object:  StoredProcedure [dbo].[DEPARTMAN]    Script Date: 9.09.2024 11:30:33 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[DEPARTMAN]
@R1 CHAR(11),
@P2 VARCHAR(20)
AS
BEGIN
SELECT Kullan�c�Departman=@P2 FROM I��iler_Yedek
WHERE Kullan�c�TC=@R1
END
GO


