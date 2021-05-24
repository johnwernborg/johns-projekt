-- --------------------------------------------------------
-- Värd:                         127.0.0.1
-- Serverversion:                10.5.8-MariaDB - mariadb.org binary distribution
-- Server-OS:                    Win64
-- HeidiSQL Version:             11.0.0.5919
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;

-- Dumpar struktur för tabell spelbutik.fakturor
CREATE TABLE IF NOT EXISTS `fakturor` (
  `FakturaID` int(11) NOT NULL AUTO_INCREMENT,
  `ProduktID` int(11) DEFAULT NULL,
  `KundID` int(11) DEFAULT NULL,
  `Pris` int(11) NOT NULL,
  `Datum` datetime NOT NULL,
  PRIMARY KEY (`FakturaID`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;

-- Dumpar data för tabell spelbutik.fakturor: ~3 rows (ungefär)
/*!40000 ALTER TABLE `fakturor` DISABLE KEYS */;
INSERT INTO `fakturor` (`FakturaID`, `ProduktID`, `KundID`, `Pris`, `Datum`) VALUES
	(3, 4, 3, 249, '2021-06-22 09:43:57'),
	(4, 4, 3, 249, '2021-06-22 09:50:58'),
	(5, 4, 3, 249, '2021-06-22 09:59:20');
/*!40000 ALTER TABLE `fakturor` ENABLE KEYS */;

-- Dumpar struktur för tabell spelbutik.konton
CREATE TABLE IF NOT EXISTS `konton` (
  `KontoID` int(11) NOT NULL AUTO_INCREMENT,
  `Fornamn` varchar(30) DEFAULT NULL,
  `Efternamn` varchar(30) DEFAULT NULL,
  `Epost` varchar(50) DEFAULT NULL,
  `Losenord` varchar(50) DEFAULT NULL,
  `Roll` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`KontoID`) USING BTREE
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;

-- Dumpar data för tabell spelbutik.konton: ~2 rows (ungefär)
/*!40000 ALTER TABLE `konton` DISABLE KEYS */;
INSERT INTO `konton` (`KontoID`, `Fornamn`, `Efternamn`, `Epost`, `Losenord`, `Roll`) VALUES
	(2, 'John', 'Wernborg', 'john.wernborg@yahoo.se', 'jllya_W0123', 'Personal'),
	(3, 'John', 'Wernborg', 'umestenis@hotmail.se', 'jllya_W0123', 'Kund'),
	(4, 'Anton', 'Wernborg', 'anton.wernborg@yahoo.com', 'ScouteR!5', 'Kund');
/*!40000 ALTER TABLE `konton` ENABLE KEYS */;

-- Dumpar struktur för tabell spelbutik.orders
CREATE TABLE IF NOT EXISTS `orders` (
  `OrderID` int(11) NOT NULL AUTO_INCREMENT,
  `ProduktID` int(11) NOT NULL,
  `KundID` int(11) NOT NULL,
  `Address` varchar(50) DEFAULT NULL,
  `OrderPris` int(11) NOT NULL,
  `Datum` date NOT NULL,
  PRIMARY KEY (`OrderID`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=latin1;

-- Dumpar data för tabell spelbutik.orders: ~6 rows (ungefär)
/*!40000 ALTER TABLE `orders` DISABLE KEYS */;
INSERT INTO `orders` (`OrderID`, `ProduktID`, `KundID`, `Address`, `OrderPris`, `Datum`) VALUES
	(2, 4, 3, 'Linnégatan 29', 249, '2021-05-26'),
	(3, 3, 3, 'Linnégatan 29', 200, '2021-05-26'),
	(5, 3, 3, 'Linnégatan 29', 200, '2021-05-27'),
	(6, 4, 3, 'Linnégatan 29', 249, '2021-05-27'),
	(7, 4, 3, 'Linnégatan 29', 249, '2021-05-27'),
	(8, 4, 3, 'Linnégatan 29', 249, '2021-05-27');
/*!40000 ALTER TABLE `orders` ENABLE KEYS */;

-- Dumpar struktur för tabell spelbutik.spel
CREATE TABLE IF NOT EXISTS `spel` (
  `ProduktID` int(11) NOT NULL AUTO_INCREMENT,
  `ProduktNamn` varchar(100) NOT NULL,
  `ProduktGenre` varchar(50) NOT NULL DEFAULT '',
  `Aldersgrans` tinyint(4) NOT NULL,
  `Plattform` char(50) NOT NULL,
  `EnhetPris` smallint(6) NOT NULL DEFAULT 0,
  `UtgivningsAr` year(4) NOT NULL,
  `EnheterILager` int(11) DEFAULT NULL,
  `Nedladdningar` int(11) DEFAULT NULL,
  PRIMARY KEY (`ProduktID`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=latin1;

-- Dumpar data för tabell spelbutik.spel: ~9 rows (ungefär)
/*!40000 ALTER TABLE `spel` DISABLE KEYS */;
INSERT INTO `spel` (`ProduktID`, `ProduktNamn`, `ProduktGenre`, `Aldersgrans`, `Plattform`, `EnhetPris`, `UtgivningsAr`, `EnheterILager`, `Nedladdningar`) VALUES
	(1, 'Fortnite', 'Skjutning', 12, 'PC', 50, '2018', 0, 50),
	(2, 'The Legend of Zelda: Twilight Princess', 'Äventyr', 7, 'Nintendo Wii', 199, '2006', 1497, 0),
	(3, 'Red Dead Redemption', 'Action', 18, 'Playstation 3', 200, '2010', 499, 0),
	(4, 'Adventure Time', 'Äventyr', 7, 'Playstation 4', 249, '2019', 492, 0),
	(5, 'Minecraft', 'Sandlåda', 3, 'PC', 249, '2009', 0, 3001),
	(6, 'test', 'Test', 3, 'PC', 10, '2009', 0, 11),
	(7, 'NyttSpel', 'Action', 7, 'Xbox', 139, '2002', 300, 0),
	(8, 'Eva Funkar', 'Skola', 7, 'PC', 89, '2008', 149, 0),
	(9, 'Goat Simulator', 'Simulator', 7, 'PC', 129, '2016', 100, 100);
/*!40000 ALTER TABLE `spel` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
