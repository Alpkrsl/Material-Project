USE [STOK3]
GO

/****** Object:  StoredProcedure [dbo].[SilmeProsedürü]    Script Date: 9.09.2024 11:45:11 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SilmeProsedürü]
@P1 INT
AS
BEGIN 
SELECT*FROM SilinenMalzemeler2
WHERE @P1=ID
END
GO


