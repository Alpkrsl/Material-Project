USE [STOK3]
GO

/****** Object:  StoredProcedure [dbo].[DÜZEN]    Script Date: 9.09.2024 11:31:55 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[DÜZEN]
@P2 VARCHAR(50),
@P3 VARCHAR(50),
@P4 VARCHAR(50),
@P5 VARCHAR(50),
@P6 VARCHAR(50),
@P7 VARCHAR(50)
AS
BEGIN
SELECT M.Malzemeadi, M.MalzemeKodu, M.MinStok, M.TSüresi, M.Yilliksatiþ, 
M.BirimFiyat
FROM Yüksek_G M
    WHERE  -- Parametreye göre filtreleme
    M.Malzemeadi = @P7
    AND M.MalzemeKodu = @P2
    AND M.MinStok = @P3
    AND M.TSüresi = @P4
    AND M.Yilliksatiþ = @P5
    AND M.BirimFiyat = @P6;
END
GO


