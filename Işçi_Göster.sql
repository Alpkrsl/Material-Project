USE [STOK3]
GO

/****** Object:  StoredProcedure [dbo].[Iþçi_Göster]    Script Date: 9.09.2024 11:38:50 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Iþçi_Göster]
@P1 VARCHAR(11)
AS
BEGIN
SELECT*FROM Iþçiler
WHERE KullanýcýID=@P1
END
GO


