-- phpMyAdmin SQL Dump
-- version 5.1.3
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 26-Nov-2022 às 23:13
-- Versão do servidor: 10.4.24-MariaDB
-- versão do PHP: 7.4.29

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `bdprovas`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `eventos`
--

CREATE TABLE `eventos` (
  `id` int(11) NOT NULL,
  `data` varchar(10) NOT NULL,
  `hora` varchar(5) NOT NULL,
  `evento` varchar(30) NOT NULL,
  `disciplina` varchar(50) NOT NULL,
  `periodo` varchar(10) NOT NULL,
  `curso` varchar(5) NOT NULL,
  `sala` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `eventos`
--

INSERT INTO `eventos` (`id`, `data`, `hora`, `evento`, `disciplina`, `periodo`, `curso`, `sala`) VALUES
(4, '29/11/2022', '10:35', 'Prova de engenharia de softwar', 'Engenharia de software', '3° Semestr', 'ADS', 'L4'),
(6, '30/11/2022', '08:15', 'Apresentação', 'Sistemas Operacionais', '3° Semestr', 'GPI', 'L3'),
(7, '30/11/2022', '07:00', 'Apresentação', 'Sistemas Operacionais', '3° Semestr', 'GPI', 'L3'),
(9, '09/12/2022', '07:00', 'ttttt', 'Estrutura de dados', '3° Semestr', 'ADS', 'L3');

-- --------------------------------------------------------

--
-- Estrutura da tabela `usuarios`
--

CREATE TABLE `usuarios` (
  `id` int(11) NOT NULL,
  `nome` varchar(100) NOT NULL,
  `email` varchar(200) NOT NULL,
  `senha` varchar(10) NOT NULL,
  `matricula` int(14) NOT NULL,
  `tipo` varchar(50) NOT NULL,
  `periodo` varchar(10) NOT NULL,
  `curso` varchar(5) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `usuarios`
--

INSERT INTO `usuarios` (`id`, `nome`, `email`, `senha`, `matricula`, `tipo`, `periodo`, `curso`) VALUES
(1, 'Diego Jonatan de Miranda da silva ramos', 'teste@teste.com', '123', 15161318, 'Aluno', '3° semestr', 'ADS'),
(2, 'Rafaela', 'rafael@teste.com', '1234', 65478914, 'Professor', '', 'GPI'),
(3, 'Admin', 'admin', 'admin', 0, 'admin', '', ''),
(4, 'Gabriel', 'gabriel@gabriel.com', '123', 14253663, 'aluno', '3° Semestr', 'ads'),
(7, 'Diego da silva\r\n', '321231', '321231', 1231231, 'Professor', '1° Semestr', 'GPI'),
(9, 'Diego silva Junior', 'hhhhhhhhh', 'hhhhhhhhh', 21564564, 'Aluno', '2° Semestr', 'EVENT');

--
-- Índices para tabelas despejadas
--

--
-- Índices para tabela `eventos`
--
ALTER TABLE `eventos`
  ADD PRIMARY KEY (`id`);

--
-- Índices para tabela `usuarios`
--
ALTER TABLE `usuarios`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `matricula` (`matricula`);

--
-- AUTO_INCREMENT de tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `eventos`
--
ALTER TABLE `eventos`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT de tabela `usuarios`
--
ALTER TABLE `usuarios`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
