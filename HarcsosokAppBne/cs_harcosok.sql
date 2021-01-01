-- phpMyAdmin SQL Dump
-- version 4.7.4
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2020. Dec 29. 00:46
-- Kiszolgáló verziója: 10.1.29-MariaDB
-- PHP verzió: 7.1.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Adatbázis: `cs_harcosok`
--

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `harcosok`
--

CREATE TABLE `harcosok` (
  `id` int(11) NOT NULL,
  `nev` varchar(255) COLLATE utf8_hungarian_ci NOT NULL,
  `letrehozas` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `harcosok`
--

INSERT INTO `harcosok` (`id`, `nev`, `letrehozas`) VALUES
(1, ' Xena', '2020-12-28 19:58:40');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `kepessegek`
--

CREATE TABLE `kepessegek` (
  `id` int(10) UNSIGNED NOT NULL,
  `nev` varchar(255) COLLATE utf8_hungarian_ci NOT NULL,
  `leiras` varchar(1000) COLLATE utf8_hungarian_ci NOT NULL,
  `harcos_id` int(10) UNSIGNED NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `kepessegek`
--

INSERT INTO `kepessegek` (`id`, `nev`, `leiras`, `harcos_id`) VALUES
(3, 'erő', 'bivalyerős csipa', 1),
(4, 'acélkard', 'kardélre hány mindenkit', 1);

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `harcosok`
--
ALTER TABLE `harcosok`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `nev` (`nev`);

--
-- A tábla indexei `kepessegek`
--
ALTER TABLE `kepessegek`
  ADD PRIMARY KEY (`id`);

--
-- A kiírt táblák AUTO_INCREMENT értéke
--

--
-- AUTO_INCREMENT a táblához `harcosok`
--
ALTER TABLE `harcosok`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT a táblához `kepessegek`
--
ALTER TABLE `kepessegek`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
