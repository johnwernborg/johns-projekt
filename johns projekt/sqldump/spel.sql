-- --------------------------------------------------------
-- Värd:                         127.0.0.1
-- Serverversion:                10.5.8-MariaDB - mariadb.org binary distribution
-- Server-OS:                    Win64
-- HeidiSQL Version:             11.2.0.6213
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

-- Dumpar struktur för tabell spelbutik.spel
CREATE TABLE IF NOT EXISTS `spel` (
  `ProduktID` int(11) NOT NULL AUTO_INCREMENT,
  `ProduktNamn` varchar(100) NOT NULL,
  `ProduktGenre` varchar(50) NOT NULL DEFAULT '',
  `Aldersgrans` tinyint(4) NOT NULL,
  `Plattform` char(50) NOT NULL,
  `Nedladdningsbart` char(5) NOT NULL DEFAULT 'false',
  `EnhetPris` smallint(6) NOT NULL DEFAULT 0,
  `UtgivningsAr` year(4) NOT NULL,
  `EnheterILager` int(11) DEFAULT NULL,
  `Nedladdningar` int(11) DEFAULT NULL,
  KEY `KEY` (`ProduktID`) USING BTREE
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;

-- Dumpar data för tabell spelbutik.spel: ~5 rows (ungefär)
/*!40000 ALTER TABLE `spel` DISABLE KEYS */;
INSERT INTO `spel` (`ProduktID`, `ProduktNamn`, `ProduktGenre`, `Aldersgrans`, `Plattform`, `Nedladdningsbart`, `EnhetPris`, `UtgivningsAr`, `EnheterILager`, `Nedladdningar`) VALUES
	(1, 'Super Mario 64', 'Plattform', 3, 'Nintendo 64', 'false', 399, '1996', 700, 0),
	(2, 'Fortnite', 'Skjutning', 12, 'PC', 'true', 0, '2018', NULL, 50),
	(3, 'The Legend of Zelda: Twilight Princess', 'Äventyr', 7, 'Nintendo Wii', 'false', 299, '2006', 1500, NULL),
	(4, 'Red Dead Redemption', 'Action', 18, 'Playstation 3', 'False', 249, '2010', 500, 0),
	(5, 'Test', 'Inget', 3, 'PC', 'True', 0, '2021', 0, 10);
/*!40000 ALTER TABLE `spel` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
