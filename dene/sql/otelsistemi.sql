-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Anamakine: 127.0.0.1
-- Üretim Zamanı: 22 Nis 2023, 23:19:21
-- Sunucu sürümü: 10.4.28-MariaDB
-- PHP Sürümü: 8.0.28

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Veritabanı: `otelsistemi`
--

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `kullanicitablosu`
--

CREATE TABLE `kullanicitablosu` (
  `kullanici_id` int(11) NOT NULL,
  `kullanici_adi` varchar(40) NOT NULL,
  `kullanici_sifre` varchar(40) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Tablo döküm verisi `kullanicitablosu`
--

INSERT INTO `kullanicitablosu` (`kullanici_id`, `kullanici_adi`, `kullanici_sifre`) VALUES
(1, 'Mertcan', '123'),
(2, 'Tuna', '123'),
(5, 'Halil', '123');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `musteri_tablo`
--

CREATE TABLE `musteri_tablo` (
  `musteri_id` int(11) NOT NULL,
  `Musteri_adi` varchar(30) NOT NULL,
  `musteri_adresi` varchar(300) NOT NULL,
  `musteri_tc_kimlik` int(12) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Tablo döküm verisi `musteri_tablo`
--

INSERT INTO `musteri_tablo` (`musteri_id`, `Musteri_adi`, `musteri_adresi`, `musteri_tc_kimlik`) VALUES
(1, 'Muratcan Kara', 'Izmir/Turkey', 9090090),
(2, 'Yakup Tas', 'Istnbul/Turkey', 999111999),
(4, 'Tiber Karahan', 'Bolu/Turkey', 9999999);

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `odalar`
--

CREATE TABLE `odalar` (
  `oda_id` int(10) NOT NULL,
  `oda_no` varchar(10) NOT NULL,
  `oda_tipi` varchar(30) NOT NULL,
  `oda_durum` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Tablo döküm verisi `odalar`
--

INSERT INTO `odalar` (`oda_id`, `oda_no`, `oda_tipi`, `oda_durum`) VALUES
(1, '101', 'Cift Kisi', 'Bos'),
(2, '102', 'Tek Kisi', 'Bos'),
(3, '103', 'Kral Dairesi', 'Bos'),
(4, '104', 'Cift Kisi', 'Bos');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `reservasyon`
--

CREATE TABLE `reservasyon` (
  `Reservation_id` int(5) NOT NULL,
  `Reservation_type` varchar(20) NOT NULL,
  `Reservation_room_number` varchar(5) NOT NULL,
  `Reservation_client_id` varchar(5) NOT NULL,
  `Reservation_in` varchar(30) NOT NULL,
  `Reservation_out` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dökümü yapılmış tablolar için indeksler
--

--
-- Tablo için indeksler `kullanicitablosu`
--
ALTER TABLE `kullanicitablosu`
  ADD PRIMARY KEY (`kullanici_id`);

--
-- Tablo için indeksler `musteri_tablo`
--
ALTER TABLE `musteri_tablo`
  ADD PRIMARY KEY (`musteri_id`);

--
-- Tablo için indeksler `odalar`
--
ALTER TABLE `odalar`
  ADD PRIMARY KEY (`oda_id`);

--
-- Tablo için indeksler `reservasyon`
--
ALTER TABLE `reservasyon`
  ADD PRIMARY KEY (`Reservation_id`);

--
-- Dökümü yapılmış tablolar için AUTO_INCREMENT değeri
--

--
-- Tablo için AUTO_INCREMENT değeri `kullanicitablosu`
--
ALTER TABLE `kullanicitablosu`
  MODIFY `kullanici_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- Tablo için AUTO_INCREMENT değeri `musteri_tablo`
--
ALTER TABLE `musteri_tablo`
  MODIFY `musteri_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- Tablo için AUTO_INCREMENT değeri `odalar`
--
ALTER TABLE `odalar`
  MODIFY `oda_id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

--
-- Tablo için AUTO_INCREMENT değeri `reservasyon`
--
ALTER TABLE `reservasyon`
  MODIFY `Reservation_id` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
