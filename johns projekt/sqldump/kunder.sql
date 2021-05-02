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

-- Dumpar struktur för tabell spelbutik.kunder
CREATE TABLE IF NOT EXISTS `kunder` (
  `KundID` int(11) NOT NULL AUTO_INCREMENT,
  `KontaktNamn` varchar(30) DEFAULT NULL,
  `Telefon` varchar(24) DEFAULT NULL,
  `Address` varchar(60) NOT NULL DEFAULT '',
  KEY `KEY` (`KundID`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

-- Dumpar data för tabell spelbutik.kunder: ~1 rows (ungefär)
/*!40000 ALTER TABLE `kunder` DISABLE KEYS */;
INSERT INTO `kunder` (`KundID`, `KontaktNamn`, `Telefon`, `Address`) VALUES
	(1, 'Test Testsson', '0761234567', 'Testgatan 1');
/*!40000 ALTER TABLE `kunder` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
