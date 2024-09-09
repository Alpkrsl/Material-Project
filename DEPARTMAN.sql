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
SELECT KullanýcýDepartman=@P2 FROM Iþçiler_Yedek
WHERE KullanýcýTC=@R1
END
GO


