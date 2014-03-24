/*
Navicat MySQL Data Transfer

Source Server         : LocalHost
Source Server Version : 50132
Source Host           : localhost:3306
Source Database       : financeiro

Target Server Type    : MYSQL
Target Server Version : 50132
File Encoding         : 65001

Date: 2014-03-24 11:29:29
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for `cliente`
-- ----------------------------
DROP TABLE IF EXISTS `cliente`;
CREATE TABLE `cliente` (
  `ID_CLI` int(11) NOT NULL AUTO_INCREMENT,
  `NomeCliente` varchar(100) NOT NULL,
  `Documento` varchar(20) DEFAULT NULL,
  `Endereco` varchar(100) DEFAULT NULL,
  `Cidade` varchar(100) DEFAULT NULL,
  `UF` varchar(2) DEFAULT NULL,
  `CEP` varchar(9) DEFAULT NULL,
  `Numero` varchar(10) DEFAULT NULL,
  `Complemento` varchar(50) DEFAULT NULL,
  `Foto` longblob,
  `Observacao` varchar(255) DEFAULT NULL,
  `Email` varchar(100) DEFAULT NULL,
  `Telefone` varchar(20) DEFAULT NULL,
  `TelefoneCel` varchar(20) DEFAULT NULL,
  `DataNascimento` date DEFAULT NULL,
  PRIMARY KEY (`ID_CLI`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of cliente
-- ----------------------------

-- ----------------------------
-- Table structure for `lancamentos`
-- ----------------------------
DROP TABLE IF EXISTS `lancamentos`;
CREATE TABLE `lancamentos` (
  `ID_LAN` int(11) NOT NULL AUTO_INCREMENT,
  `DataLancamento` datetime DEFAULT NULL,
  `Operador` int(11) DEFAULT NULL,
  `Operacao` int(11) DEFAULT NULL,
  `Valor` double DEFAULT NULL,
  `Tipo` varchar(1) DEFAULT NULL,
  `TipoValor` varchar(1) DEFAULT NULL,
  `TipoPagamento` varchar(1) DEFAULT NULL,
  `Quantidade` int(11) DEFAULT NULL,
  `Juros` double DEFAULT NULL,
  `Descontos` double DEFAULT NULL,
  PRIMARY KEY (`ID_LAN`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of lancamentos
-- ----------------------------

-- ----------------------------
-- Table structure for `operacao`
-- ----------------------------
DROP TABLE IF EXISTS `operacao`;
CREATE TABLE `operacao` (
  `ID_OPE` int(11) NOT NULL AUTO_INCREMENT,
  `Descricao` varchar(50) NOT NULL,
  `Tipo` varchar(1) DEFAULT NULL,
  `TipoValor` varchar(1) DEFAULT NULL,
  `Valor` double DEFAULT NULL,
  PRIMARY KEY (`ID_OPE`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of operacao
-- ----------------------------

-- ----------------------------
-- Table structure for `usuario`
-- ----------------------------
DROP TABLE IF EXISTS `usuario`;
CREATE TABLE `usuario` (
  `ID_USR` int(11) NOT NULL AUTO_INCREMENT,
  `NomeUsuario` varchar(100) NOT NULL,
  `Documento` varchar(20) DEFAULT NULL,
  `Endereco` varchar(100) DEFAULT NULL,
  `Cidade` varchar(100) DEFAULT NULL,
  `UF` varchar(2) DEFAULT NULL,
  `CEP` varchar(9) DEFAULT NULL,
  `Numero` varchar(10) DEFAULT NULL,
  `Complemento` varchar(50) DEFAULT NULL,
  `Foto` longblob,
  `Observacao` varchar(255) DEFAULT NULL,
  `Email` varchar(100) DEFAULT NULL,
  `Telefone` varchar(20) DEFAULT NULL,
  `TelefoneCel` varchar(20) DEFAULT NULL,
  `DataNascimento` date DEFAULT NULL,
  `Porcentagem` double DEFAULT NULL,
  `Senha` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`ID_USR`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of usuario
-- ----------------------------
INSERT INTO `usuario` VALUES ('1', 'THIAGO', '482325355', 'RUA DAS PRIMAVERAS', 'CAIEIRAS', 'SP', '07716295', '125', 'CASA 01', null, 'NENHUMA', 'TROMANINI125@GMAIL.COM', '46056500', '971123496', '1992-05-17', '50', null);
