-- MariaDB dump 10.19  Distrib 10.4.28-MariaDB, for Win64 (AMD64)
--
-- Host: localhost    Database: zoo
-- ------------------------------------------------------
-- Server version	10.4.28-MariaDB

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
Drop database if Exists zoo;
create database zoo;
use zoo;


--
-- Table structure for table `futter`
--

DROP TABLE IF EXISTS `futter`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `futter` (
  `f_id` int(11) NOT NULL AUTO_INCREMENT,
  `bezeichnung` varchar(50) DEFAULT NULL,
  `Verpackung` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`f_id`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `futter`
--

LOCK TABLES `futter` WRITE;
/*!40000 ALTER TABLE `futter` DISABLE KEYS */;
INSERT INTO `futter` VALUES (1,'Möhre','Sack'),(7,'Fleisch','Box');
/*!40000 ALTER TABLE `futter` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `gehege`
--

DROP TABLE IF EXISTS `gehege`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `gehege` (
  `gh_id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(50) DEFAULT NULL,
  `groesse` double DEFAULT NULL,
  `k_id` int(11) DEFAULT NULL,
  PRIMARY KEY (`gh_id`),
  KEY `k_id` (`k_id`),
  CONSTRAINT `gehege_ibfk_1` FOREIGN KEY (`k_id`) REFERENCES `kontinente` (`k_id`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `gehege`
--

LOCK TABLES `gehege` WRITE;
/*!40000 ALTER TABLE `gehege` DISABLE KEYS */;
INSERT INTO `gehege` VALUES (3,'Affen Rummel',500,4),(4,'Vogel Paradies',1000,2),(5,'Nager Spielplatz',250,3),(6,'Kratzbaum',1000,4),(7,'Eispalast',500,1),(8,'Pferdelauf',5000,5);
/*!40000 ALTER TABLE `gehege` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `herkunft`
--

DROP TABLE IF EXISTS `herkunft`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `herkunft` (
  `h_id` int(11) NOT NULL AUTO_INCREMENT,
  `woher` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`h_id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `herkunft`
--

LOCK TABLES `herkunft` WRITE;
/*!40000 ALTER TABLE `herkunft` DISABLE KEYS */;
INSERT INTO `herkunft` VALUES (1,'Eigenzucht'),(2,'anderer Zoo'),(3,'Wildnis');
/*!40000 ALTER TABLE `herkunft` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `kontinente`
--

DROP TABLE IF EXISTS `kontinente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `kontinente` (
  `k_id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`k_id`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `kontinente`
--

LOCK TABLES `kontinente` WRITE;
/*!40000 ALTER TABLE `kontinente` DISABLE KEYS */;
INSERT INTO `kontinente` VALUES (1,'Nordamerika'),(2,'Südamerika'),(3,'Europa'),(4,'Afrika'),(5,'Asien'),(6,'Ozeanien');
/*!40000 ALTER TABLE `kontinente` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pfleger`
--

DROP TABLE IF EXISTS `pfleger`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `pfleger` (
  `P_ID` int(11) NOT NULL AUTO_INCREMENT,
  `Nachname` varchar(50) DEFAULT NULL,
  `Vorname` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`P_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pfleger`
--

LOCK TABLES `pfleger` WRITE;
/*!40000 ALTER TABLE `pfleger` DISABLE KEYS */;
INSERT INTO `pfleger` VALUES (1,'Hungriger','Hugo'),(2,'Trauriger','Thorsten'),(3,'Müde','Mürte');
/*!40000 ALTER TABLE `pfleger` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `schichtplan`
--

DROP TABLE IF EXISTS `schichtplan`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `schichtplan` (
  `p_id` int(11) NOT NULL,
  `gh_id` int(11) NOT NULL,
  `Rolle` tinyint(1) DEFAULT NULL,
  `Schicht` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`p_id`,`gh_id`),
  KEY `gh_id` (`gh_id`),
  CONSTRAINT `schichtplan_ibfk_1` FOREIGN KEY (`p_id`) REFERENCES `pfleger` (`P_ID`),
  CONSTRAINT `schichtplan_ibfk_2` FOREIGN KEY (`gh_id`) REFERENCES `gehege` (`gh_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `schichtplan`
--

LOCK TABLES `schichtplan` WRITE;
/*!40000 ALTER TABLE `schichtplan` DISABLE KEYS */;
INSERT INTO `schichtplan` VALUES (1,5,1,0),(2,3,1,0),(3,3,0,1);
/*!40000 ALTER TABLE `schichtplan` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tierart`
--

DROP TABLE IF EXISTS `tierart`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tierart` (
  `ta_id` int(11) NOT NULL AUTO_INCREMENT,
  `bezeichnung` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`ta_id`)
) ENGINE=InnoDB AUTO_INCREMENT=51 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tierart`
--

LOCK TABLES `tierart` WRITE;
/*!40000 ALTER TABLE `tierart` DISABLE KEYS */;
INSERT INTO `tierart` VALUES (1,'Chimpanse'),(2,'Vogel'),(3,'Bär'),(4,'Wildkatze'),(5,'Nager');
/*!40000 ALTER TABLE `tierart` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tiere`
--

DROP TABLE IF EXISTS `tiere`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tiere` (
  `t_id` int(11) NOT NULL AUTO_INCREMENT,
  `gebdat` date DEFAULT NULL,
  `ta_id` int(11) DEFAULT NULL,
  `gh_id` int(11) DEFAULT NULL,
  `h_id` int(11) DEFAULT NULL,
  `name` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`t_id`),
  KEY `ta_id` (`ta_id`),
  KEY `gh_id` (`gh_id`),
  KEY `h_id` (`h_id`),
  CONSTRAINT `tiere_ibfk_1` FOREIGN KEY (`ta_id`) REFERENCES `tierart` (`ta_id`),
  CONSTRAINT `tiere_ibfk_2` FOREIGN KEY (`gh_id`) REFERENCES `gehege` (`gh_id`),
  CONSTRAINT `tiere_ibfk_3` FOREIGN KEY (`h_id`) REFERENCES `herkunft` (`h_id`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tiere`
--

LOCK TABLES `tiere` WRITE;
/*!40000 ALTER TABLE `tiere` DISABLE KEYS */;
INSERT INTO `tiere` VALUES (2,'2017-03-08',1,3,1,'Hugo'),(3,'2023-06-07',2,4,1,'Hildegard'),(4,'2022-07-15',3,7,3,'Egon'),(5,'2023-05-15',4,6,3,'Fred'),(6,'2023-03-17',5,5,1,'Gunibert');
/*!40000 ALTER TABLE `tiere` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tierfutter`
--

DROP TABLE IF EXISTS `tierfutter`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tierfutter` (
  `t_id` int(11) NOT NULL,
  `f_id` int(11) NOT NULL,
  `menge` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`t_id`,`f_id`),
  KEY `f_id` (`f_id`),
  CONSTRAINT `tierfutter_ibfk_1` FOREIGN KEY (`t_id`) REFERENCES `tiere` (`t_id`),
  CONSTRAINT `tierfutter_ibfk_2` FOREIGN KEY (`f_id`) REFERENCES `futter` (`f_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tierfutter`
--

LOCK TABLES `tierfutter` WRITE;
/*!40000 ALTER TABLE `tierfutter` DISABLE KEYS */;
INSERT INTO `tierfutter` VALUES (3,1,'1 kleine Portion'),(5,7,'1 Box'),(6,1,'2 Stück');
/*!40000 ALTER TABLE `tierfutter` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary table structure for view `vfuergrid`
--

DROP TABLE IF EXISTS `vfuergrid`;
/*!50001 DROP VIEW IF EXISTS `vfuergrid`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE VIEW `vfuergrid` AS SELECT
 1 AS `gname`,
  1 AS `kname`,
  1 AS `tname` */;
SET character_set_client = @saved_cs_client;

--
-- Temporary table structure for view `vfugehtier`
--

DROP TABLE IF EXISTS `vfugehtier`;
/*!50001 DROP VIEW IF EXISTS `vfugehtier`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE VIEW `vfugehtier` AS SELECT
 1 AS `bezeichnung`,
  1 AS `menge`,
  1 AS `tname`,
  1 AS `gname` */;
SET character_set_client = @saved_cs_client;

--
-- Temporary table structure for view `vgehtier`
--

DROP TABLE IF EXISTS `vgehtier`;
/*!50001 DROP VIEW IF EXISTS `vgehtier`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE VIEW `vgehtier` AS SELECT
 1 AS `tname`,
  1 AS `name` */;
SET character_set_client = @saved_cs_client;

--
-- Temporary table structure for view `vkonge`
--

DROP TABLE IF EXISTS `vkonge`;
/*!50001 DROP VIEW IF EXISTS `vkonge`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE VIEW `vkonge` AS SELECT
 1 AS `gname`,
  1 AS `name` */;
SET character_set_client = @saved_cs_client;

--
-- Final view structure for view `vfuergrid`
--

/*!50001 DROP VIEW IF EXISTS `vfuergrid`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = cp850 */;
/*!50001 SET character_set_results     = cp850 */;
/*!50001 SET collation_connection      = cp850_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `vfuergrid` AS select `gehege`.`name` AS `gname`,`kontinente`.`name` AS `kname`,`tiere`.`name` AS `tname` from ((`gehege` join `kontinente`) join `tiere`) where `kontinente`.`k_id` = `gehege`.`k_id` and `tiere`.`gh_id` = `gehege`.`gh_id` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `vfugehtier`
--

/*!50001 DROP VIEW IF EXISTS `vfugehtier`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = cp850 */;
/*!50001 SET character_set_results     = cp850 */;
/*!50001 SET collation_connection      = cp850_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `vfugehtier` AS select `futter`.`bezeichnung` AS `bezeichnung`,`tierfutter`.`menge` AS `menge`,`tiere`.`name` AS `tname`,`gehege`.`name` AS `gname` from (((`tierfutter` join `tiere`) join `gehege`) join `futter`) where `tiere`.`gh_id` = `gehege`.`gh_id` and `tierfutter`.`t_id` = `tiere`.`t_id` and `tierfutter`.`f_id` = `futter`.`f_id` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `vgehtier`
--

/*!50001 DROP VIEW IF EXISTS `vgehtier`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = cp850 */;
/*!50001 SET character_set_results     = cp850 */;
/*!50001 SET collation_connection      = cp850_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `vgehtier` AS select `tiere`.`name` AS `tname`,`gehege`.`name` AS `name` from (`tiere` join `gehege`) where `tiere`.`gh_id` = `gehege`.`gh_id` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `vkonge`
--

/*!50001 DROP VIEW IF EXISTS `vkonge`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = cp850 */;
/*!50001 SET character_set_results     = cp850 */;
/*!50001 SET collation_connection      = cp850_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `vkonge` AS select `gehege`.`name` AS `gname`,`kontinente`.`name` AS `name` from (`kontinente` join `gehege`) where `kontinente`.`k_id` = `gehege`.`k_id` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-06-09 11:24:43
