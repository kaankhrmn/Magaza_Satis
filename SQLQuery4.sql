USE [DbHareket]
GO
/****** Object:  StoredProcedure [dbo].[Hareket]    Script Date: 8.02.2024 21:08:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[Hareket]
as
Select URUNLER.AD as 'Ürün Ad',ADSOYAD as 'Müşteri',PERSONELLER.AD as 'Personel',FIYAT as 'Fiyat' from HAREKETLER 
inner join URUNLER on HAREKETLER.URUN=URUNLER.ID
inner join MUSTERILER on HAREKETLER.MUSTERI=MUSTERILER.ID
inner join PERSONELLER on HAREKETLER.PERSONEL=PERSONELLER.ID
