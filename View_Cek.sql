USE [STOK3]
GO

/****** Object:  StoredProcedure [dbo].[View_Cek]    Script Date: 9.09.2024 11:47:18 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[View_Cek]
@P1 INT
AS
BEGIN
SELECT*FROM BirleþmiþVeri
WHERE KullanýcýID=@P1
END
GO


