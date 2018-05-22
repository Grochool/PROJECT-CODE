-- phpMyAdmin SQL Dump
-- version 4.8.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Czas generowania: 22 Maj 2018, 22:50
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
('AS Monaco', 38, 23, 11, 4, 85, 80, 'Ligue 1'),
('Bayern Monachium', 34, 25, 9, 0, 92, 84, 'Bundesliga'),
('Chelsea', 38, 24, 11, 4, 60, 83, 'Premier League'),
('FC Barcelona', 38, 30, 3, 5, 99, 93, 'La Liga'),
('Juventus Turyn', 38, 30, 5, 3, 86, 95, 'Serie A'),
('Liverpool FC', 38, 20, 15, 13, 84, 75, 'Premier League'),
('Manchester City', 38, 32, 4, 2, 106, 100, 'Premier League'),
('Napoli', 38, 27, 10, 1, 77, 91, 'Serie A'),
('Paris Saint Germain', 38, 30, 3, 5, 108, 93, 'Ligue 1'),
('Real Madryt', 38, 20, 16, 2, 94, 76, 'La Liga'),
('Schalke Gelsenkirchen', 34, 20, 3, 11, 53, 63, 'Bundesliga'),
('Stoke City', 38, 7, 12, 19, 35, 33, 'Premier League'),
('Swansea City', 38, 8, 9, 21, 28, 33, 'Premier League'),
('West Bromwich Albion', 38, 6, 13, 19, 31, 31, 'Premier League');

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
