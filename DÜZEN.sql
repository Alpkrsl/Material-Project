USE [STOK3]
GO

/****** Object:  StoredProcedure [dbo].[D�ZEN]    Script Date: 9.09.2024 11:31:55 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[D�ZEN]
@P2 VARCHAR(50),
@P3 VARCHAR(50),
@P4 VARCHAR(50),
@P5 VARCHAR(50),
@P6 VARCHAR(50),
@P7 VARCHAR(50)
AS
BEGIN
SELECT M.Malzemeadi, M.MalzemeKodu, M.MinStok, M.TS�resi, M.Yilliksati�, 
M.BirimFiyat
FROM Y�ksek_G M
    WHERE  -- Parametreye g�re filtreleme
    M.Malzemeadi = @P7
    AND M.MalzemeKodu = @P2
    AND M.MinStok = @P3
    AND M.TS�resi = @P4
    AND M.Yilliksati� = @P5
    AND M.BirimFiyat = @P6;
END
GO


