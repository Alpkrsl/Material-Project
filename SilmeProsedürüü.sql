USE [STOK3]
GO

/****** Object:  StoredProcedure [dbo].[SilmeProsed�r��]    Script Date: 9.09.2024 11:46:22 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SilmeProsed�r��]
@P3 INT
AS
BEGIN 
SELECT*FROM SilinenMalzemeler2
WHERE @P3=ID
END
GO


