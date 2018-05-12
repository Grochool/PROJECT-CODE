-- phpMyAdmin SQL Dump
-- version 4.8.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Czas generowania: 12 Maj 2018, 23:03
-- Wersja serwera: 10.1.31-MariaDB
-- Wersja PHP: 7.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Baza danych: `test`
--

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `drużyny`
--

CREATE TABLE `drużyny` (
  `Nazwa_druzyny` varchar(50) NOT NULL,
  `Rozegrane_mecze` int(11) NOT NULL,
  `zwyciestwa` int(11) NOT NULL,
  `remisy` int(11) NOT NULL,
  `porazki` int(11) NOT NULL,
  `bramki` int(11) NOT NULL,
  `punkty` int(11) NOT NULL,
  `liga` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Zrzut danych tabeli `drużyny`
--

INSERT INTO `drużyny` (`Nazwa_druzyny`, `Rozegrane_mecze`, `zwyciestwa`, `remisy`, `porazki`, `bramki`, `punkty`, `liga`) VALUES
('Manchester United', 20, 15, 4, 1, 30, 49, 'Premier League');

--
-- Indeksy dla zrzutów tabel
--

--
-- Indeksy dla tabeli `drużyny`
--
ALTER TABLE `drużyny`
  ADD PRIMARY KEY (`Nazwa_druzyny`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
