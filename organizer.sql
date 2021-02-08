-- phpMyAdmin SQL Dump
-- version 5.0.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Czas generowania: 08 Lut 2021, 16:51
-- Wersja serwera: 10.4.17-MariaDB
-- Wersja PHP: 8.0.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Baza danych: `organizer`
--

DELIMITER $$
--
-- Procedury
--
CREATE DEFINER=`root`@`localhost` PROCEDURE `DodajUczestnika` (`_ID_wspoluczestnika` INT(11), `_imie` VARCHAR(255), `_relacja` VARCHAR(255), `_data_urodzenia` DATE, `_nr_telefonu` VARCHAR(255))  BEGIN
	IF _ID_wspoluczestnika = 0 THEN
		INSERT INTO wspoluczestnik (nazwa, relacja, data_urodzenia, nr_telefonu)
        VALUES (_imie, _relacja, _data_urodzenia, _nr_telefonu);
	ELSE
		UPDATE wspoluczestnik
        SET 
			nazwa = _imie, 
            relacja = _relacja, 
            data_urodzenia = _data_urodzenia, 
            nr_telefonu = _nr_telefonu
		WHERE ID_wspoluczestnika = _ID_wspoluczestnika;
	END IF;

END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `DodajWydarzenie` (`_ID_wydarzenia` INT, `_godzina_rozpoczecia_planowana` DATETIME, `_godzina_zakonczenia_planowana` DATETIME, `_opis` TEXT, `_ID_miejsca` INT(11), `_ID_kategorii` INT(11))  BEGIN
	INSERT INTO zdarzenie_standardowe (ID_wydarzenia, godzina_rozpoczecia_planowana, godzina_zakonczenia_planowana, 
	opis, ID_miejsca, ID_kategorii)
	VALUES (_ID_wydarzenia, _godzina_rozpoczecia_planowana, _godzina_zakonczenia_planowana, 
	_opis, _ID_miejsca, _ID_kategorii);
	
        
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `DodajZadanie` (`_data` DATE, `_ID_zdarzenia` INT(11))  BEGIN
	INSERT INTO zdarzenie_odznaczane (data, ID_wydarzenia)
	VALUES (_data, _ID_zdarzenia);

END$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `czas_przypomnienia`
--

CREATE TABLE `czas_przypomnienia` (
  `ID_czasu` int(11) NOT NULL,
  `nazwa_czasu` varchar(255) NOT NULL,
  `czas_wyprzedzania` time NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Zrzut danych tabeli `czas_przypomnienia`
--

INSERT INTO `czas_przypomnienia` (`ID_czasu`, `nazwa_czasu`, `czas_wyprzedzania`) VALUES
(1, 'Godzinę przed rozpoczęciem', '01:00:00'),
(2, 'Trzy godziny przed rozpoczęciem', '03:00:00'),
(3, 'Dzień przed rozpoczęciem', '24:00:00');

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `drzemka`
--

CREATE TABLE `drzemka` (
  `ID_drzemki` int(11) NOT NULL,
  `nazwa_drzemki` varchar(255) NOT NULL,
  `czas_drzemki` time NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `kategoria`
--

CREATE TABLE `kategoria` (
  `ID_kategorii` int(11) NOT NULL,
  `nazwa_kategorii` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Zrzut danych tabeli `kategoria`
--

INSERT INTO `kategoria` (`ID_kategorii`, `nazwa_kategorii`) VALUES
(6, 'Czas wolny'),
(3, 'Dom'),
(7, 'Inne'),
(1, 'Nauka'),
(9, 'Podróż'),
(2, 'Praca'),
(4, 'Uczelnia'),
(10, 'Uroda'),
(11, 'Ważne wydarzenia'),
(5, 'Zakupy'),
(8, 'Zdrowie');

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `miejsce`
--

CREATE TABLE `miejsce` (
  `ID_miejsca` int(11) NOT NULL,
  `miejscowosc` varchar(255) NOT NULL,
  `nazwa_miejsca` varchar(255) NOT NULL,
  `ulica` varchar(255) DEFAULT NULL,
  `numer_domu` varchar(255) DEFAULT NULL,
  `numer_mieszkania` varchar(255) DEFAULT NULL,
  `kod_pocztowy` char(6) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Zrzut danych tabeli `miejsce`
--

INSERT INTO `miejsce` (`ID_miejsca`, `miejscowosc`, `nazwa_miejsca`, `ulica`, `numer_domu`, `numer_mieszkania`, `kod_pocztowy`) VALUES
(1, 'Wrocław', 'Dom', 'Skarbowców', '35', '', ''),
(2, 'Wrocław', 'Politechnika Wrocławska', 'Stanisława Wyspiańskiego', '27', '', '50-370'),
(4, 'Wrocław', 'Praca', 'Strzegomska ', '36', '', '53-611'),
(5, 'Wrocław', 'Wolontariat ', 'Makowa', '41', '', '53-225'),
(6, 'Wrocław\r\nWrocław', 'Siłownia CityFit', 'Szewska', '3A', '', '50-053'),
(7, 'Wrocław', 'Yoga - sala', 'pl. Św. Macieja', '11', '7', '50-244'),
(8, 'Wrocław', 'Mieszkanie Psiapsi', 'Grabiszyńska', '11c', '6', '53-437'),
(9, 'Wrocław', 'Mieszkanie Kolegi', 'Bzowa', '76a', '3', '53-437');

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `powtarzalnosc`
--

CREATE TABLE `powtarzalnosc` (
  `ID_powtarzalnosci` int(11) NOT NULL,
  `nazwa_powtarzalnosci` varchar(255) NOT NULL,
  `okres_powtarzalnosci` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Zrzut danych tabeli `powtarzalnosc`
--

INSERT INTO `powtarzalnosc` (`ID_powtarzalnosci`, `nazwa_powtarzalnosci`, `okres_powtarzalnosci`) VALUES
(1, 'Co tydzień', '2021-01-07'),
(2, 'Co dwa tygodnie', '2021-01-27');

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `przypomnienie`
--

CREATE TABLE `przypomnienie` (
  `ID_przypomnienia` int(11) NOT NULL,
  `czas_przypomnienia` time NOT NULL,
  `ID_czasu` int(11) NOT NULL,
  `ID_drzemki` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `uzytkownik`
--

CREATE TABLE `uzytkownik` (
  `ID_uzytkownika` int(11) NOT NULL,
  `imie` varchar(255) NOT NULL,
  `nazwisko` varchar(255) NOT NULL,
  `data_urodzenia` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Zrzut danych tabeli `uzytkownik`
--

INSERT INTO `uzytkownik` (`ID_uzytkownika`, `imie`, `nazwisko`, `data_urodzenia`) VALUES
(1, 'Klaudia', 'Bonke', '1998-01-13');

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `wspoluczestnik`
--

CREATE TABLE `wspoluczestnik` (
  `ID_wspoluczestnika` int(11) NOT NULL,
  `nazwa` varchar(255) NOT NULL,
  `relacja` varchar(255) NOT NULL,
  `data_urodzenia` date DEFAULT NULL,
  `nr_telefonu` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Zrzut danych tabeli `wspoluczestnik`
--

INSERT INTO `wspoluczestnik` (`ID_wspoluczestnika`, `nazwa`, `relacja`, `data_urodzenia`, `nr_telefonu`) VALUES
(1, 'Alicja Kowalska', 'Koleżanka', '1998-01-16', '553124561'),
(2, 'Anna Kopiec', 'Koleżanka', '2000-02-20', '552331413'),
(3, 'Tomek Wolny', 'Kolega', '1998-06-02', '634881425'),
(4, 'Maja Miłka', 'Praca', '2021-01-31', '663425662'),
(8, 'Piotr Tarnowski', 'kolega', '1998-05-18', '663606520'),
(9, 'Weronika Sztos', 'siostra', '2000-02-02', '525033111'),
(10, 'Wera Mycek', 'przyjaciółka', '1999-06-22', '667441002'),
(11, 'Grzegorz Mycek', 'znajomy', '2000-11-30', '');

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `zdarzenie`
--

CREATE TABLE `zdarzenie` (
  `ID_wydarzenia` int(11) NOT NULL,
  `nazwa_zdarzenia` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Zrzut danych tabeli `zdarzenie`
--

INSERT INTO `zdarzenie` (`ID_wydarzenia`, `nazwa_zdarzenia`) VALUES
(27, 'Poranna gimnastyka'),
(28, 'Wynieść śmieci'),
(29, 'Wyjść na spacer z psem'),
(30, 'Poszukać prezentu dla Klaudii'),
(31, 'Wysłać sprawozdanie'),
(32, 'Zrobić sprawozdanie'),
(33, 'Wyprasować rzeczy'),
(34, 'Napisać wiadomość do ZUSu'),
(35, 'Impreza u Huberta'),
(36, 'Zakupy spożywcze'),
(37, 'Odebrać paczkę'),
(38, 'Umyć okno'),
(39, 'Laboratorium sieci'),
(40, 'Wyjść z psem'),
(41, 'Umyć podłogę'),
(42, 'Prezentacja'),
(43, 'wysłanie dokumentacji');

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `zdarzenie_odznaczane`
--

CREATE TABLE `zdarzenie_odznaczane` (
  `czy_wykonane` tinyint(1) NOT NULL DEFAULT 0,
  `data` date NOT NULL,
  `ID_wydarzenia` int(11) NOT NULL,
  `ID_uzytkownika` int(11) NOT NULL DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Zrzut danych tabeli `zdarzenie_odznaczane`
--

INSERT INTO `zdarzenie_odznaczane` (`czy_wykonane`, `data`, `ID_wydarzenia`, `ID_uzytkownika`) VALUES
(0, '2021-02-02', 28, 1),
(0, '2021-02-02', 29, 1),
(0, '2021-02-03', 30, 1),
(0, '2021-02-03', 31, 1),
(0, '2021-02-04', 33, 1),
(0, '2021-02-04', 34, 1),
(0, '2021-02-03', 37, 1),
(0, '2021-02-04', 38, 1),
(0, '2021-02-05', 40, 1),
(0, '2021-02-05', 41, 1),
(0, '2021-02-03', 43, 1);

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `zdarzenie_standardowe`
--

CREATE TABLE `zdarzenie_standardowe` (
  `ID_wydarzenia` int(11) NOT NULL,
  `godzina_rozpoczecia_planowana` datetime NOT NULL,
  `godzina_zakonczenia_planowana` datetime NOT NULL,
  `godzina_rozpoczecia_rzeczywista` datetime DEFAULT NULL,
  `godzina_zakonczenia_rzeczywista` datetime DEFAULT NULL,
  `opis` text DEFAULT NULL,
  `ID_powtarzalnosci` int(11) DEFAULT NULL,
  `ID_miejsca` int(11) DEFAULT NULL,
  `ID_kategorii` int(11) NOT NULL,
  `ID_przypomnienia` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Zrzut danych tabeli `zdarzenie_standardowe`
--

INSERT INTO `zdarzenie_standardowe` (`ID_wydarzenia`, `godzina_rozpoczecia_planowana`, `godzina_zakonczenia_planowana`, `godzina_rozpoczecia_rzeczywista`, `godzina_zakonczenia_rzeczywista`, `opis`, `ID_powtarzalnosci`, `ID_miejsca`, `ID_kategorii`, `ID_przypomnienia`) VALUES
(27, '2021-02-02 20:30:18', '2021-02-02 21:30:18', NULL, NULL, 'ćwiczenia z nowym viedo Pani Chodakowskiej', NULL, 1, 8, NULL),
(32, '2021-02-02 15:00:01', '2021-02-02 17:00:01', '2021-02-02 17:15:03', '2021-02-02 17:15:03', 'Dokończyć sprawozdanie z sieci bezprzewodowych', NULL, 1, 1, NULL),
(35, '2021-02-04 19:00:51', '2021-02-04 23:55:51', '2021-02-02 17:13:19', '2021-02-02 17:13:19', '', NULL, 7, 6, NULL),
(36, '2021-02-03 11:00:13', '2021-02-03 13:00:13', '2021-02-02 17:03:35', '2021-02-02 17:03:35', 'Nie zapomnić o napoju owsianym i krokietach ', NULL, 1, 11, NULL),
(39, '2021-02-05 19:34:44', '2021-02-05 23:34:44', NULL, NULL, 'Przygotować materiał', NULL, 2, 1, NULL),
(42, '2021-02-02 20:25:04', '2021-02-02 20:25:04', NULL, NULL, 'Przygotować prezkę', NULL, 2, 1, NULL);

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `zdarzenie_standardowe_has_wspoluczestnik`
--

CREATE TABLE `zdarzenie_standardowe_has_wspoluczestnik` (
  `ID_wydarzenia` int(11) DEFAULT NULL,
  `ID_wspoluczestnika` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Zrzut danych tabeli `zdarzenie_standardowe_has_wspoluczestnik`
--

INSERT INTO `zdarzenie_standardowe_has_wspoluczestnik` (`ID_wydarzenia`, `ID_wspoluczestnika`) VALUES
(35, 1),
(35, 2),
(35, 3),
(35, 4),
(35, 8),
(32, 5),
(36, 1),
(36, 3),
(39, 3),
(42, 1),
(42, 2);

--
-- Indeksy dla zrzutów tabel
--

--
-- Indeksy dla tabeli `czas_przypomnienia`
--
ALTER TABLE `czas_przypomnienia`
  ADD PRIMARY KEY (`ID_czasu`),
  ADD UNIQUE KEY `nazwa_czasu_UNIQUE` (`nazwa_czasu`),
  ADD UNIQUE KEY `czas_wyprzedzania_UNIQUE` (`czas_wyprzedzania`),
  ADD UNIQUE KEY `ID_czasu_UNIQUE` (`ID_czasu`);

--
-- Indeksy dla tabeli `drzemka`
--
ALTER TABLE `drzemka`
  ADD PRIMARY KEY (`ID_drzemki`),
  ADD UNIQUE KEY `idDrzemka_UNIQUE` (`nazwa_drzemki`),
  ADD UNIQUE KEY `czas_drzemki_UNIQUE` (`czas_drzemki`),
  ADD UNIQUE KEY `ID_drzemki_UNIQUE` (`ID_drzemki`);

--
-- Indeksy dla tabeli `kategoria`
--
ALTER TABLE `kategoria`
  ADD PRIMARY KEY (`ID_kategorii`),
  ADD UNIQUE KEY `ID_kategorii_UNIQUE` (`ID_kategorii`),
  ADD UNIQUE KEY `nazwa_kategorii_UNIQUE` (`nazwa_kategorii`);

--
-- Indeksy dla tabeli `miejsce`
--
ALTER TABLE `miejsce`
  ADD PRIMARY KEY (`ID_miejsca`),
  ADD UNIQUE KEY `nazwa_miejsca_UNIQUE` (`nazwa_miejsca`),
  ADD UNIQUE KEY `ID_miejsca_UNIQUE` (`ID_miejsca`);

--
-- Indeksy dla tabeli `powtarzalnosc`
--
ALTER TABLE `powtarzalnosc`
  ADD PRIMARY KEY (`ID_powtarzalnosci`),
  ADD UNIQUE KEY `nazwa_powtarzalnosci_UNIQUE` (`nazwa_powtarzalnosci`),
  ADD UNIQUE KEY `okres_powtarzalnosci_UNIQUE` (`okres_powtarzalnosci`),
  ADD UNIQUE KEY `ID_powtarzalnosci_UNIQUE` (`ID_powtarzalnosci`);

--
-- Indeksy dla tabeli `przypomnienie`
--
ALTER TABLE `przypomnienie`
  ADD PRIMARY KEY (`ID_przypomnienia`),
  ADD UNIQUE KEY `ID_przypomnienia_UNIQUE` (`ID_przypomnienia`),
  ADD KEY `fk_Przypomnienie_Czas przypomnienia1_idx` (`ID_czasu`),
  ADD KEY `fk_Przypomnienie_Drzemka1_idx` (`ID_drzemki`);

--
-- Indeksy dla tabeli `uzytkownik`
--
ALTER TABLE `uzytkownik`
  ADD PRIMARY KEY (`ID_uzytkownika`),
  ADD UNIQUE KEY `imie_UNIQUE` (`imie`),
  ADD UNIQUE KEY `nazwisko_UNIQUE` (`nazwisko`),
  ADD UNIQUE KEY `data_urodzenia_UNIQUE` (`data_urodzenia`);

--
-- Indeksy dla tabeli `wspoluczestnik`
--
ALTER TABLE `wspoluczestnik`
  ADD PRIMARY KEY (`ID_wspoluczestnika`),
  ADD UNIQUE KEY `ID_wspoluczestnika_UNIQUE` (`ID_wspoluczestnika`),
  ADD UNIQUE KEY `nr_telefonu_UNIQUE` (`nr_telefonu`);

--
-- Indeksy dla tabeli `zdarzenie`
--
ALTER TABLE `zdarzenie`
  ADD PRIMARY KEY (`ID_wydarzenia`),
  ADD UNIQUE KEY `ID_wydarzenia_UNIQUE` (`ID_wydarzenia`);

--
-- Indeksy dla tabeli `zdarzenie_odznaczane`
--
ALTER TABLE `zdarzenie_odznaczane`
  ADD PRIMARY KEY (`ID_wydarzenia`,`ID_uzytkownika`),
  ADD UNIQUE KEY `ID_wydarzenia_UNIQUE` (`ID_wydarzenia`),
  ADD KEY `fk_Zdarzenie odznaczane_Uzytkownik1_idx` (`ID_uzytkownika`);

--
-- Indeksy dla tabeli `zdarzenie_standardowe`
--
ALTER TABLE `zdarzenie_standardowe`
  ADD PRIMARY KEY (`ID_wydarzenia`),
  ADD UNIQUE KEY `godzina_rozpoczecia_planowana_UNIQUE` (`godzina_rozpoczecia_planowana`),
  ADD UNIQUE KEY `godzina_zakonczenia_planowana_UNIQUE` (`godzina_zakonczenia_planowana`),
  ADD UNIQUE KEY `ID_wydarzenia_UNIQUE` (`ID_wydarzenia`),
  ADD UNIQUE KEY `godzina_rozpoczecia_rzeczywista_UNIQUE` (`godzina_rozpoczecia_rzeczywista`),
  ADD UNIQUE KEY `godzina_zakonczenia_rzeczywista_UNIQUE` (`godzina_zakonczenia_rzeczywista`),
  ADD KEY `FK1_idx` (`ID_miejsca`),
  ADD KEY `fk_Zdarzenie standardowe_Powtarzalnosc1_idx` (`ID_powtarzalnosci`),
  ADD KEY `fk_Zdarzenie standardowe_Kategoria1_idx` (`ID_kategorii`),
  ADD KEY `fk_Zdarzenie standardowe_Przypomnienie1_idx` (`ID_przypomnienia`);

--
-- Indeksy dla tabeli `zdarzenie_standardowe_has_wspoluczestnik`
--
ALTER TABLE `zdarzenie_standardowe_has_wspoluczestnik`
  ADD KEY `fk_Zdarzenie standardowe_has_Wspoluczestnik_Wspoluczestnik1_idx` (`ID_wspoluczestnika`),
  ADD KEY `fk_Zdarzenie_standardowe_has_Wspoluczestnik_Zdarzenie standar1` (`ID_wydarzenia`);

--
-- AUTO_INCREMENT dla zrzuconych tabel
--

--
-- AUTO_INCREMENT dla tabeli `czas_przypomnienia`
--
ALTER TABLE `czas_przypomnienia`
  MODIFY `ID_czasu` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT dla tabeli `drzemka`
--
ALTER TABLE `drzemka`
  MODIFY `ID_drzemki` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT dla tabeli `kategoria`
--
ALTER TABLE `kategoria`
  MODIFY `ID_kategorii` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT dla tabeli `miejsce`
--
ALTER TABLE `miejsce`
  MODIFY `ID_miejsca` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT dla tabeli `przypomnienie`
--
ALTER TABLE `przypomnienie`
  MODIFY `ID_przypomnienia` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT dla tabeli `uzytkownik`
--
ALTER TABLE `uzytkownik`
  MODIFY `ID_uzytkownika` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT dla tabeli `wspoluczestnik`
--
ALTER TABLE `wspoluczestnik`
  MODIFY `ID_wspoluczestnika` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT dla tabeli `zdarzenie`
--
ALTER TABLE `zdarzenie`
  MODIFY `ID_wydarzenia` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=44;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
