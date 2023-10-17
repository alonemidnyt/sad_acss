-- MariaDB dump 10.19  Distrib 10.4.28-MariaDB, for Win64 (AMD64)
--
-- Host: localhost    Database: acss
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

--
-- Table structure for table `days`
--

DROP TABLE IF EXISTS `days`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `days` (
  `day_id` int(11) NOT NULL AUTO_INCREMENT,
  `day_name` varchar(10) NOT NULL,
  PRIMARY KEY (`day_id`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `days`
--

LOCK TABLES `days` WRITE;
/*!40000 ALTER TABLE `days` DISABLE KEYS */;
INSERT INTO `days` VALUES (1,'Monday'),(2,'Tuesday'),(3,'Wednesday'),(4,'Thursday'),(5,'Friday'),(6,'Saturday'),(7,'Sunday');
/*!40000 ALTER TABLE `days` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `room_availability`
--

DROP TABLE IF EXISTS `room_availability`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `room_availability` (
  `room_id` varchar(10) NOT NULL,
  `day_id` int(11) NOT NULL,
  `slot_id` int(11) NOT NULL,
  `available` int(11) NOT NULL DEFAULT 1,
  KEY `room_id` (`room_id`),
  KEY `day_id` (`day_id`),
  KEY `slot_id` (`slot_id`),
  CONSTRAINT `room_availability_ibfk_1` FOREIGN KEY (`room_id`) REFERENCES `rooms` (`room_id`),
  CONSTRAINT `room_availability_ibfk_2` FOREIGN KEY (`day_id`) REFERENCES `days` (`day_id`),
  CONSTRAINT `room_availability_ibfk_3` FOREIGN KEY (`slot_id`) REFERENCES `time_slots` (`slot_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `room_availability`
--

LOCK TABLES `room_availability` WRITE;
/*!40000 ALTER TABLE `room_availability` DISABLE KEYS */;
INSERT INTO `room_availability` VALUES ('CON105',1,1,1),('CON105',1,2,1),('CON105',1,3,1),('CON105',1,4,1),('CON105',1,5,1),('CON105',1,6,1),('CON105',1,7,1),('CON105',2,1,1),('CON105',2,2,1),('CON105',2,3,1),('CON105',2,4,1),('CON105',2,5,1),('CON105',2,6,1),('CON105',2,7,1),('CON105',3,1,1),('CON105',3,2,1),('CON105',3,3,1),('CON105',3,4,1),('CON105',3,5,1),('CON105',3,6,1),('CON105',3,7,1),('CON105',4,1,1),('CON105',4,2,1),('CON105',4,3,1),('CON105',4,4,1),('CON105',4,5,1),('CON105',4,6,1),('CON105',4,7,1),('CON105',5,1,1),('CON105',5,2,1),('CON105',5,3,1),('CON105',5,4,1),('CON105',5,5,1),('CON105',5,6,1),('CON105',5,7,1),('CON105',6,1,1),('CON105',6,2,1),('CON105',6,3,1),('CON105',6,4,1),('CON105',6,5,1),('CON105',6,6,1),('CON105',6,7,1),('CON104',1,1,1),('CON104',1,2,1),('CON104',1,3,1),('CON104',1,4,1),('CON104',1,5,1),('CON104',1,6,1),('CON104',1,7,1),('CON104',2,1,1),('CON104',2,2,1),('CON104',2,3,1),('CON104',2,4,1),('CON104',2,5,1),('CON104',2,6,1),('CON104',2,7,1),('CON104',3,1,1),('CON104',3,2,1),('CON104',3,3,1),('CON104',3,4,1),('CON104',3,5,1),('CON104',3,6,1),('CON104',3,7,1),('CON104',4,1,1),('CON104',4,2,1),('CON104',4,3,1),('CON104',4,4,1),('CON104',4,5,1),('CON104',4,6,1),('CON104',4,7,1),('CON104',5,1,1),('CON104',5,2,1),('CON104',5,3,1),('CON104',5,4,1),('CON104',5,5,1),('CON104',5,6,1),('CON104',5,7,1),('CON104',6,1,1),('CON104',6,2,1),('CON104',6,3,1),('CON104',6,4,1),('CON104',6,5,1),('CON104',6,6,1),('CON104',6,7,1);
/*!40000 ALTER TABLE `room_availability` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `rooms`
--

DROP TABLE IF EXISTS `rooms`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `rooms` (
  `room_id` varchar(10) NOT NULL,
  `room_type` varchar(20) NOT NULL,
  `capacity` int(5) NOT NULL,
  PRIMARY KEY (`room_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `rooms`
--

LOCK TABLES `rooms` WRITE;
/*!40000 ALTER TABLE `rooms` DISABLE KEYS */;
INSERT INTO `rooms` VALUES ('CON104','LEC',50),('CON105','LEC',40);
/*!40000 ALTER TABLE `rooms` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `time_slots`
--

DROP TABLE IF EXISTS `time_slots`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `time_slots` (
  `slot_id` int(11) NOT NULL AUTO_INCREMENT,
  `start_time` time NOT NULL,
  `end_time` time NOT NULL,
  PRIMARY KEY (`slot_id`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `time_slots`
--

LOCK TABLES `time_slots` WRITE;
/*!40000 ALTER TABLE `time_slots` DISABLE KEYS */;
INSERT INTO `time_slots` VALUES (1,'07:30:00','09:00:00'),(2,'09:00:00','10:30:00'),(3,'10:30:00','12:00:00'),(4,'01:00:00','02:30:00'),(5,'02:30:00','04:00:00'),(6,'04:00:00','05:30:00'),(7,'05:30:00','07:00:00');
/*!40000 ALTER TABLE `time_slots` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-10-17 15:49:14
