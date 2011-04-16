CREATE DATABASE  IF NOT EXISTS `knoodou_estudo` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `knoodou_estudo`;
-- MySQL dump 10.13  Distrib 5.1.40, for Win32 (ia32)
--
-- Host: localhost    Database: knoodou_estudo
-- ------------------------------------------------------
-- Server version	5.1.51-community

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `locacao`
--

DROP TABLE IF EXISTS `locacao`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `locacao` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `CLIENTE_ID` int(11) NOT NULL,
  `USUARIO_ID` int(11) NOT NULL,
  `DT_LOCACAO` datetime NOT NULL,
  `VALOR_FINAL` float NOT NULL,
  `DT_ENTREGA` date NOT NULL,
  `ENTREGUE` tinyint(1) NOT NULL DEFAULT '0',
  `PAGO` tinyint(1) DEFAULT '0',
  `dt_entregue` date DEFAULT NULL,
  PRIMARY KEY (`ID`),
  KEY `Locacao_FKIndex1` (`USUARIO_ID`),
  KEY `Locacao_FKIndex2` (`CLIENTE_ID`),
  CONSTRAINT `fk_aa8a416c-ceef-11df-88b7-00085434b5ba` FOREIGN KEY (`USUARIO_ID`) REFERENCES `usuario` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_aa8aa634-ceef-11df-88b7-00085434b5ba` FOREIGN KEY (`CLIENTE_ID`) REFERENCES `cliente` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=38 DEFAULT CHARSET=utf8 PACK_KEYS=0;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `locacao`
--

LOCK TABLES `locacao` WRITE;
/*!40000 ALTER TABLE `locacao` DISABLE KEYS */;
INSERT INTO `locacao` VALUES (32,10,2,'2010-11-11 11:40:18',8,'2010-11-13',1,1,'2010-11-11'),(33,1,2,'2010-11-11 11:42:57',3,'2010-11-13',1,1,'2010-11-11'),(34,1,2,'2010-11-11 11:45:50',2.5,'2010-11-13',0,1,NULL),(35,11,2,'2010-11-11 11:53:02',8,'2010-11-13',0,1,NULL),(36,8,2,'2010-11-11 11:53:59',3,'2010-11-13',0,1,NULL),(37,12,2,'2010-11-11 11:58:42',3,'2010-11-13',0,0,NULL);
/*!40000 ALTER TABLE `locacao` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `configuracoes`
--

DROP TABLE IF EXISTS `configuracoes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `configuracoes` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `VALOR` varchar(200) DEFAULT NULL,
  `CHAVE` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8 PACK_KEYS=0;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `configuracoes`
--

LOCK TABLES `configuracoes` WRITE;
/*!40000 ALTER TABLE `configuracoes` DISABLE KEYS */;
INSERT INTO `configuracoes` VALUES (1,'50','tempo_lancamento'),(2,'Locadora popular','nome_locadora'),(3,"","twitter_accesstoken"),(4,"","twitter_accesssecret"),(5,"","email_config"),(6,"","facebook_accesstoken"),(7,"","facebook_limit");
/*!40000 ALTER TABLE `configuracoes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `genero`
--

DROP TABLE IF EXISTS `genero`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `genero` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `TIPO` varchar(20) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=18 DEFAULT CHARSET=utf8 PACK_KEYS=0;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `genero`
--

LOCK TABLES `genero` WRITE;
/*!40000 ALTER TABLE `genero` DISABLE KEYS */;
INSERT INTO `genero` VALUES (1,'Drama'),(2,'Terror'),(3,'Romance'),(4,'Suspense'),(5,'Policial'),(6,'Musical'),(7,'Comédia'),(8,'Animação'),(9,'Ficção'),(10,'Fantasia'),(11,'Ação'),(12,'Desenho'),(13,'Documentário'),(14,'Faroeste'),(15,'Guerra'),(17,'Cult');
/*!40000 ALTER TABLE `genero` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuario`
--

DROP TABLE IF EXISTS `usuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `usuario` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `NOME` varchar(60) NOT NULL,
  `SENHA` varchar(12) NOT NULL,
  `TIPO` varchar(15) NOT NULL,
  `LOGIN` varchar(12) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8 PACK_KEYS=0;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuario`
--

LOCK TABLES `usuario` WRITE;
/*!40000 ALTER TABLE `usuario` DISABLE KEYS */;
INSERT INTO `usuario` VALUES (2,'Admin','123456','Administrador','admin'),(3,'Gustavo','123456','Normal','gustavo'),(4,'Luiz Felipe','123456789','Normal','saldanha');
/*!40000 ALTER TABLE `usuario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `formato`
--

DROP TABLE IF EXISTS `formato`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `formato` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `MIDIA` varchar(30) NOT NULL,
  `PRECO_LANCAMENTO` float NOT NULL,
  `PRECO_NORMAL` float NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8 PACK_KEYS=0;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `formato`
--

LOCK TABLES `formato` WRITE;
/*!40000 ALTER TABLE `formato` DISABLE KEYS */;
INSERT INTO `formato` VALUES (1,'DVD',3,2.5),(2,'Bluray',8,6.8),(3,'VHS',1.5,1);
/*!40000 ALTER TABLE `formato` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `dependente`
--

DROP TABLE IF EXISTS `dependente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `dependente` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `NOME` varchar(45) NOT NULL,
  `DT_NASC` date NOT NULL,
  `PARENTESCO` varchar(45) NOT NULL COMMENT '\n',
  `RG` varchar(45) DEFAULT NULL,
  `CPF` varchar(45) DEFAULT NULL,
  `SEXO` char(1) NOT NULL,
  `EMAIL` varchar(100) DEFAULT NULL,
  `MSN` varchar(45) DEFAULT NULL,
  `BLOQUEADO` tinyint(1) DEFAULT NULL,
  `CLIENTE_ID` int(11) NOT NULL,
  PRIMARY KEY (`ID`),
  KEY `fk_DEPENDENTE_CLIENTE1` (`CLIENTE_ID`),
  CONSTRAINT `fk_DEPENDENTE_CLIENTE1` FOREIGN KEY (`CLIENTE_ID`) REFERENCES `cliente` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `dependente`
--

LOCK TABLES `dependente` WRITE;
/*!40000 ALTER TABLE `dependente` DISABLE KEYS */;
/*!40000 ALTER TABLE `dependente` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `filme`
--

DROP TABLE IF EXISTS `filme`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `filme` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `FORMATO_ID` int(11) NOT NULL,
  `ANO` int(11) NOT NULL,
  `DT_CADASTRO` datetime NOT NULL,
  `TITULO` varchar(60) NOT NULL,
  `CLASSIFICACAO` varchar(20) NOT NULL,
  `QUANTIDADE` int(11) NOT NULL,
  `IMDB` varchar(45) DEFAULT NULL,
  `SITE` varchar(45) DEFAULT NULL,
  `DURACAO` int(11) NOT NULL,
  `CARACTERISTICA` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`ID`),
  KEY `FILME_FKIndex2` (`FORMATO_ID`),
  CONSTRAINT `fk_aa8dc224-ceef-11df-88b7-00085434b5ba` FOREIGN KEY (`FORMATO_ID`) REFERENCES `formato` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=utf8 PACK_KEYS=0;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `filme`
--

LOCK TABLES `filme` WRITE;
/*!40000 ALTER TABLE `filme` DISABLE KEYS */;
INSERT INTO `filme` VALUES (1,2,2003,'2010-11-07 22:53:53','O amor não tira férias','12 anos',2,'AMD32','',250,''),(2,1,2000,'2010-11-07 22:56:13','Por toda minha vida','Livre',1,'','',180,'S/N'),(3,1,2001,'2010-11-07 22:56:54','O chamado','16 anos',3,'','',200,'Violência'),(4,1,2003,'2010-11-07 22:57:50','Antes só do que mal casado','12 anos',2,'','',205,'S/N'),(5,1,1986,'2010-05-07 22:58:37','Monty Phyton: Em busca do cálice sagrado','10 anos',1,'','',235,''),(6,1,2005,'2010-11-07 22:59:23','Colheita maldita','16 anos',2,'','',238,'Violência'),(7,2,2010,'2010-11-07 22:59:50','Avatar','Livre',5,'','',300,'S/N'),(8,1,2010,'2010-11-07 23:00:13','Toy Story 3','Livre',3,'','',267,'S/N'),(9,2,2010,'2010-11-07 23:00:45','Toy Story 3','Livre',2,'','',241,'S/N'),(10,1,2003,'2010-11-07 23:01:37','Swat','14 anos',1,'','',85,'S/N'),(11,1,2009,'2010-11-07 23:26:28','Drilbt Taylor','Livre',1,'','',189,'S/N'),(12,1,2010,'2010-11-09 08:02:27','Piranha 3D','16 anos',2,'','',96,'Sexo'),(13,1,2010,'2010-11-10 23:09:31','Os vampiros que se mordam','14 anos',2,'','',96,'Sangue'),(14,1,2010,'2010-11-10 23:13:35','O ultimo Mestre do ar','10 anos',2,'','',105,''),(15,2,2010,'2010-11-10 23:14:58','Como treinar seu dragão','Livre',3,'','',125,'S/N'),(16,1,1998,'2010-11-11 07:36:32','Descendo a serra','Livre',1,'','',230,'S/N'),(17,2,2010,'2010-11-11 11:26:56','RED','16 anos',4,'','',112,'Violência'),(18,1,2003,'2010-11-11 11:30:52','Um show de vizinha','18 anos',2,'','',187,'Sexo'),(19,2,2010,'2010-11-11 11:51:57','Jackass 3D','14 anos',4,'','',112,'S/N'),(20,1,2007,'2010-11-11 11:55:42','Fernandinha do 103','18 anos',2,'','',127,'Sexo');
/*!40000 ALTER TABLE `filme` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `genero_r_filme`
--

DROP TABLE IF EXISTS `genero_r_filme`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `genero_r_filme` (
  `GENERO_ID` int(11) NOT NULL,
  `FILME_ID` int(11) NOT NULL,
  PRIMARY KEY (`GENERO_ID`,`FILME_ID`),
  KEY `GENERO_has_FILME_FKIndex1` (`GENERO_ID`),
  KEY `GENERO_has_FILME_FKIndex2` (`FILME_ID`),
  CONSTRAINT `fk_aa8c58e4-ceef-11df-88b7-00085434b5ba` FOREIGN KEY (`GENERO_ID`) REFERENCES `genero` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_aa8cbaf0-ceef-11df-88b7-00085434b5ba` FOREIGN KEY (`FILME_ID`) REFERENCES `filme` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8 PACK_KEYS=0;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `genero_r_filme`
--

LOCK TABLES `genero_r_filme` WRITE;
/*!40000 ALTER TABLE `genero_r_filme` DISABLE KEYS */;
INSERT INTO `genero_r_filme` VALUES (1,2),(2,3),(2,6),(2,12),(3,1),(3,2),(3,4),(4,6),(4,10),(4,17),(5,10),(5,17),(7,1),(7,4),(7,5),(7,11),(7,13),(7,16),(7,18),(7,19),(8,7),(8,8),(8,9),(9,14),(10,14),(10,20),(11,14),(11,17),(12,15),(13,19);
/*!40000 ALTER TABLE `genero_r_filme` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `filme_r_locacao`
--

DROP TABLE IF EXISTS `filme_r_locacao`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `filme_r_locacao` (
  `FILME_ID` int(11) NOT NULL,
  `LOCACAO_ID` int(11) NOT NULL,
  PRIMARY KEY (`FILME_ID`,`LOCACAO_ID`),
  KEY `FILME_has_Locacao_FKIndex1` (`FILME_ID`),
  KEY `FILME_has_Locacao_FKIndex2` (`LOCACAO_ID`),
  CONSTRAINT `fk_aa8ee4e2-ceef-11df-88b7-00085434b5ba` FOREIGN KEY (`FILME_ID`) REFERENCES `filme` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_aa8f581e-ceef-11df-88b7-00085434b5ba` FOREIGN KEY (`LOCACAO_ID`) REFERENCES `locacao` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8 PACK_KEYS=0;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `filme_r_locacao`
--

LOCK TABLES `filme_r_locacao` WRITE;
/*!40000 ALTER TABLE `filme_r_locacao` DISABLE KEYS */;
INSERT INTO `filme_r_locacao` VALUES (5,34),(13,33),(14,36),(14,37),(15,32),(19,35);
/*!40000 ALTER TABLE `filme_r_locacao` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cliente`
--

DROP TABLE IF EXISTS `cliente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `cliente` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `CPF` varchar(15) NOT NULL,
  `TELEFONE` varchar(20) NOT NULL,
  `DT_NASC` date NOT NULL,
  `RG` varchar(18) NOT NULL,
  `ENDERECO` varchar(100) DEFAULT NULL,
  `NOME` varchar(60) NOT NULL,
  `DT_CADASTRO` datetime NOT NULL,
  `SEXO` char(1) NOT NULL,
  `CELULAR` varchar(45) DEFAULT NULL,
  `EMAIL` varchar(45) DEFAULT NULL,
  `MSN` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8 PACK_KEYS=0;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cliente`
--

LOCK TABLES `cliente` WRITE;
/*!40000 ALTER TABLE `cliente` DISABLE KEYS */;
INSERT INTO `cliente` VALUES (1,'11326532323','(31) 2712-525','1993-09-17','MG15056193','','Bruno Lara Tavares','2010-11-07 22:49:48','m','(  )     -','',''),(2,'32653265326','(11) 1111-1111','1972-02-13','326532653','','Carina Soares Silva','2010-11-07 22:50:34','f','(  )     -','',''),(3,'32653265','(38) 6555-5555','1980-09-18','3265326532','','André Guimarães','2010-11-07 22:51:52','m','(89) 7987-687','',''),(5,'36475434587','(31) 3335-6543','1996-11-27','123456789','','Arthur Araujo','2010-11-10 23:21:17','m','(  )     -','',''),(6,'53758689432','(31) 3647-8643','1990-03-26','376487567','','Maria Elizete','2010-11-10 23:23:14','f','(  )     -','',''),(8,'48593829567','(31) 2654-7896','1989-09-06','472847594','','José Domingos','2010-11-10 23:25:16','m','(  )     -','',''),(9,'12345678','(12) 3434-5677','1994-01-11','12345678','','Camila Saraiva','2010-11-11 08:33:15','f','(  )     -','',''),(10,'12345698123','(31) 3336-9582','1994-09-15','MG12068988','','Sthefane','2010-11-11 11:24:27','f','(  )     -','',''),(11,'23456543222','(31) 3912-0809','1993-04-24','mg23143567','','Gustavo de Araújo','2010-11-11 11:50:39','m','(  )     -','',''),(12,'114347356','(31) 1341-2145','1993-11-14','MG16548188','','Luiz Felipe Saldanha','2010-11-11 11:56:50','m','(  )     -','','');
/*!40000 ALTER TABLE `cliente` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2010-11-11 12:00:25
