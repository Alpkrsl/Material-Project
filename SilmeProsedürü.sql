USE [STOK3]
GO

/****** Object:  StoredProcedure [dbo].[SilmeProsed�r�]    Script Date: 9.09.2024 11:45:11 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SilmeProsed�r�]
@P1 INT
AS
BEGIN 
SELECT*FROM SilinenMalzemeler2
WHERE @P1=ID
END
GO


