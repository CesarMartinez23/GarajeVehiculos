-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1:3306
-- Tiempo de generación: 17-10-2021 a las 22:26:38
-- Versión del servidor: 5.7.31
-- Versión de PHP: 7.4.9

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `vehiculos`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `vehiculo`
--

DROP TABLE IF EXISTS `vehiculo`;
CREATE TABLE IF NOT EXISTS `vehiculo` (
  `idCar` int(11) NOT NULL AUTO_INCREMENT,
  `brandCar` varchar(15) NOT NULL,
  `modelCar` varchar(25) NOT NULL,
  `yearCar` varchar(12) NOT NULL,
  `colorCar` varchar(25) NOT NULL,
  `typeCar` varchar(25) NOT NULL,
  PRIMARY KEY (`idCar`)
) ENGINE=MyISAM AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `vehiculo`
--

INSERT INTO `vehiculo` (`idCar`, `brandCar`, `modelCar`, `yearCar`, `colorCar`, `typeCar`) VALUES
(1, 'Nissan', 'GTR-35 Nismo', '2021', 'Blanco Perla', 'Deportivo'),
(2, 'Toyota', 'Hilux SRV', '2021', 'Gris', '4x4'),
(3, 'Ferrari', 'F-12 Turbo', '2021', 'Rojo', 'Deportivo, Carreras');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
