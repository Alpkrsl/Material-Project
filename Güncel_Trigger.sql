USE [STOK3]
GO

/****** Object:  StoredProcedure [dbo].[G�ncel_Trigger]    Script Date: 9.09.2024 11:37:58 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[G�ncel_Trigger]
@R2 INT
AS
BEGIN
SELECT*FROM Eski_G�ncel
WHERE ID=@R2
END
GO


