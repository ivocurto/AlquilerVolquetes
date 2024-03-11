-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 11-03-2024 a las 02:10:19
-- Versión del servidor: 10.4.32-MariaDB
-- Versión de PHP: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `alquiler_volquete`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `admins`
--

CREATE TABLE `admins` (
  `id` int(11) NOT NULL,
  `mail` varchar(55) NOT NULL,
  `nombre_admin` varchar(55) NOT NULL,
  `clave` varchar(55) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish2_ci;

--
-- Volcado de datos para la tabla `admins`
--

INSERT INTO `admins` (`id`, `mail`, `nombre_admin`, `clave`) VALUES
(12, 'franco@gmail.com', 'f', 'f');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `pedidos_cliente`
--

CREATE TABLE `pedidos_cliente` (
  `hash_code` int(11) NOT NULL,
  `id_usuario` int(11) NOT NULL,
  `volquetes_chicos` int(11) DEFAULT NULL,
  `volquetes_medianos` int(11) DEFAULT NULL,
  `volquetes_grandes` int(11) DEFAULT NULL,
  `fecha_ingreso` date NOT NULL,
  `fecha_regreso` date NOT NULL,
  `direccion` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish2_ci;

--
-- Volcado de datos para la tabla `pedidos_cliente`
--

INSERT INTO `pedidos_cliente` (`hash_code`, `id_usuario`, `volquetes_chicos`, `volquetes_medianos`, `volquetes_grandes`, `fecha_ingreso`, `fecha_regreso`, `direccion`) VALUES
(53955, 23, 0, 2, 3, '2024-03-10', '2024-03-20', 'Av Santa Fe 5437'),
(72416, 23, 4, 0, 1, '2024-03-12', '2024-03-21', 'Av Directorio 3082');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `stock`
--

CREATE TABLE `stock` (
  `id` int(11) NOT NULL,
  `producto` varchar(55) NOT NULL,
  `cantidad_disponible` int(11) NOT NULL,
  `cantidad_alquilados` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish2_ci;

--
-- Volcado de datos para la tabla `stock`
--

INSERT INTO `stock` (`id`, `producto`, `cantidad_disponible`, `cantidad_alquilados`) VALUES
(1, 'Volquete Chico', 6, 4),
(2, 'Volquete Mediano', 8, 2),
(3, 'Volquete Grande', 6, 4);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuarios`
--

CREATE TABLE `usuarios` (
  `id` int(11) NOT NULL,
  `nombre` varchar(55) NOT NULL,
  `apellido` varchar(55) NOT NULL,
  `mail` varchar(55) NOT NULL,
  `telefono` int(11) DEFAULT NULL,
  `nombre_usuario` varchar(55) NOT NULL,
  `clave` varchar(55) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish2_ci;

--
-- Volcado de datos para la tabla `usuarios`
--

INSERT INTO `usuarios` (`id`, `nombre`, `apellido`, `mail`, `telefono`, `nombre_usuario`, `clave`) VALUES
(20, 'franco', 'ferrari', 'ferrari@gmail.com', 0, 'fran', 'a'),
(21, 'Guido', 'Roust', 'guidocalixto@gmail.com', 1123244323, 'xeras', 'a'),
(23, 'Franco', 'Ferrari', 'francoferrari226@gmail.com', 1139385502, 'Franco', 'fran123');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `admins`
--
ALTER TABLE `admins`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `pedidos_cliente`
--
ALTER TABLE `pedidos_cliente`
  ADD KEY `id_usuario` (`id_usuario`);

--
-- Indices de la tabla `stock`
--
ALTER TABLE `stock`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `usuarios`
--
ALTER TABLE `usuarios`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `admins`
--
ALTER TABLE `admins`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT de la tabla `stock`
--
ALTER TABLE `stock`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT de la tabla `usuarios`
--
ALTER TABLE `usuarios`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=24;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `pedidos_cliente`
--
ALTER TABLE `pedidos_cliente`
  ADD CONSTRAINT `pedidos_cliente_ibfk_1` FOREIGN KEY (`id_usuario`) REFERENCES `usuarios` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
