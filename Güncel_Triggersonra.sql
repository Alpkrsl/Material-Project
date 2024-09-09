USE [STOK3]
GO

/****** Object:  StoredProcedure [dbo].[Güncel_Triggersonra]    Script Date: 9.09.2024 11:38:18 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Güncel_Triggersonra]
@R3 INT
AS
BEGIN
SELECT*FROM Yeni_Güncel 
WHERE ID=@R3
END
GO


