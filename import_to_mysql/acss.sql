-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Oct 26, 2023 at 03:02 PM
-- Server version: 10.4.28-MariaDB
-- PHP Version: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `acss`
--

-- --------------------------------------------------------

--
-- Table structure for table `college`
--

CREATE TABLE `college` (
  `id` varchar(5) NOT NULL,
  `description` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `college`
--

INSERT INTO `college` (`id`, `description`) VALUES
('CAS', 'College of Arts & Science'),
('CME', 'College of Management & Entrepreneurship'),
('COE', 'College of Education');

-- --------------------------------------------------------

--
-- Table structure for table `days`
--

CREATE TABLE `days` (
  `day_id` int(11) NOT NULL,
  `day_name` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `days`
--

INSERT INTO `days` (`day_id`, `day_name`) VALUES
(1, 'Monday'),
(2, 'Tuesday'),
(3, 'Wednesday'),
(4, 'Thursday'),
(5, 'Friday'),
(6, 'Saturday'),
(7, 'Sunday');

-- --------------------------------------------------------

--
-- Table structure for table `faculty`
--

CREATE TABLE `faculty` (
  `id` int(11) NOT NULL,
  `name` varchar(30) NOT NULL,
  `department` varchar(30) NOT NULL,
  `employment` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `faculty`
--

INSERT INTO `faculty` (`id`, `name`, `department`, `employment`) VALUES
(2, 'ALIDO, KRESNA A.', 'IT Department', 'Part-Time');

-- --------------------------------------------------------

--
-- Table structure for table `faculty_availability`
--

CREATE TABLE `faculty_availability` (
  `faculty_id` varchar(255) NOT NULL,
  `day_id` int(11) NOT NULL,
  `time_id` int(11) NOT NULL,
  `available` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `faculty_availability`
--

INSERT INTO `faculty_availability` (`faculty_id`, `day_id`, `time_id`, `available`) VALUES
('ALIDO, KRESNA A.', 1, 1, 0),
('ALIDO, KRESNA A.', 1, 2, 0),
('ALIDO, KRESNA A.', 1, 3, 0),
('ALIDO, KRESNA A.', 1, 4, 1),
('ALIDO, KRESNA A.', 1, 5, 0),
('ALIDO, KRESNA A.', 1, 6, 0),
('ALIDO, KRESNA A.', 1, 7, 0),
('ALIDO, KRESNA A.', 2, 1, 1),
('ALIDO, KRESNA A.', 2, 2, 0),
('ALIDO, KRESNA A.', 2, 3, 1),
('ALIDO, KRESNA A.', 2, 4, 1),
('ALIDO, KRESNA A.', 2, 5, 1),
('ALIDO, KRESNA A.', 2, 6, 1),
('ALIDO, KRESNA A.', 2, 7, 1),
('ALIDO, KRESNA A.', 3, 1, 1),
('ALIDO, KRESNA A.', 3, 2, 1),
('ALIDO, KRESNA A.', 3, 3, 0),
('ALIDO, KRESNA A.', 3, 4, 1),
('ALIDO, KRESNA A.', 3, 5, 0),
('ALIDO, KRESNA A.', 3, 6, 1),
('ALIDO, KRESNA A.', 3, 7, 1),
('ALIDO, KRESNA A.', 4, 1, 0),
('ALIDO, KRESNA A.', 4, 2, 0),
('ALIDO, KRESNA A.', 4, 3, 0),
('ALIDO, KRESNA A.', 4, 4, 1),
('ALIDO, KRESNA A.', 4, 5, 0),
('ALIDO, KRESNA A.', 4, 6, 0),
('ALIDO, KRESNA A.', 4, 7, 0),
('ALIDO, KRESNA A.', 5, 1, 1),
('ALIDO, KRESNA A.', 5, 2, 0),
('ALIDO, KRESNA A.', 5, 3, 1),
('ALIDO, KRESNA A.', 5, 4, 1),
('ALIDO, KRESNA A.', 5, 5, 1),
('ALIDO, KRESNA A.', 5, 6, 1),
('ALIDO, KRESNA A.', 5, 7, 1),
('ALIDO, KRESNA A.', 6, 1, 1),
('ALIDO, KRESNA A.', 6, 2, 1),
('ALIDO, KRESNA A.', 6, 3, 1),
('ALIDO, KRESNA A.', 6, 4, 1),
('ALIDO, KRESNA A.', 6, 5, 1),
('ALIDO, KRESNA A.', 6, 6, 1),
('ALIDO, KRESNA A.', 6, 7, 0);

-- --------------------------------------------------------

--
-- Table structure for table `program`
--

CREATE TABLE `program` (
  `id` varchar(10) NOT NULL,
  `description` varchar(255) NOT NULL,
  `college` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `program`
--

INSERT INTO `program` (`id`, `description`, `college`) VALUES
('BSED', 'Bachelor in Secondary Education', 'COE'),
('BSHM', 'Bachelor of Science in Hospitality Management', 'CME'),
('BSIT', 'BACHELOR OF SCIENCE IN INFORMATION TECHNOLOGY', 'CAS');

-- --------------------------------------------------------

--
-- Table structure for table `rooms`
--

CREATE TABLE `rooms` (
  `room_id` varchar(10) NOT NULL,
  `room_type` varchar(20) NOT NULL,
  `capacity` int(5) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `rooms`
--

INSERT INTO `rooms` (`room_id`, `room_type`, `capacity`) VALUES
('CON101', 'GE-LEC', 50);

-- --------------------------------------------------------

--
-- Table structure for table `room_availability`
--

CREATE TABLE `room_availability` (
  `room_id` varchar(10) NOT NULL,
  `day_id` int(11) NOT NULL,
  `slot_id` int(11) NOT NULL,
  `available` int(11) NOT NULL DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `room_availability`
--

INSERT INTO `room_availability` (`room_id`, `day_id`, `slot_id`, `available`) VALUES
('CON101', 1, 1, 0),
('CON101', 1, 2, 0),
('CON101', 1, 3, 0),
('CON101', 1, 4, 1),
('CON101', 1, 5, 0),
('CON101', 1, 6, 0),
('CON101', 1, 7, 0),
('CON101', 2, 1, 1),
('CON101', 2, 2, 0),
('CON101', 2, 3, 1),
('CON101', 2, 4, 1),
('CON101', 2, 5, 1),
('CON101', 2, 6, 1),
('CON101', 2, 7, 1),
('CON101', 3, 1, 1),
('CON101', 3, 2, 1),
('CON101', 3, 3, 0),
('CON101', 3, 4, 1),
('CON101', 3, 5, 0),
('CON101', 3, 6, 1),
('CON101', 3, 7, 1),
('CON101', 4, 1, 0),
('CON101', 4, 2, 0),
('CON101', 4, 3, 0),
('CON101', 4, 4, 1),
('CON101', 4, 5, 0),
('CON101', 4, 6, 0),
('CON101', 4, 7, 0),
('CON101', 5, 1, 1),
('CON101', 5, 2, 0),
('CON101', 5, 3, 1),
('CON101', 5, 4, 1),
('CON101', 5, 5, 1),
('CON101', 5, 6, 1),
('CON101', 5, 7, 1),
('CON101', 6, 1, 1),
('CON101', 6, 2, 1),
('CON101', 6, 3, 1),
('CON101', 6, 4, 1),
('CON101', 6, 5, 1),
('CON101', 6, 6, 1),
('CON101', 6, 7, 0);

-- --------------------------------------------------------

--
-- Table structure for table `schedule`
--

CREATE TABLE `schedule` (
  `id` varchar(255) NOT NULL,
  `subject` varchar(255) NOT NULL,
  `instructor` varchar(255) NOT NULL,
  `day` varchar(255) NOT NULL,
  `time` int(11) NOT NULL,
  `room` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `schedule`
--

INSERT INTO `schedule` (`id`, `subject`, `instructor`, `day`, `time`, `room`) VALUES
('202311stAI13', 'GE101', '', 'W', 3, 'CON101'),
('202311stAI13', 'GE102', '', 'MTh', 1, 'CON101'),
('202311stAI13', 'GE122', '', 'MTh', 5, 'CON101'),
('202311stAI13', 'IT101', '', 'TF', 2, 'CON101'),
('202311stAI13', 'IT101L', '', 'MTh', 3, 'CON101'),
('202311stAI13', 'IT102', '', 'W', 5, 'CON101'),
('202311stAI13', 'IT103', 'ALIDO, KRESNA A.', 'S', 7, 'CON101'),
('202311stAI13', 'IT103L', '', '0', 0, ''),
('202311stAI13', 'IT104', '', '0', 0, ''),
('202311stAI13', 'NSTP101', '', '0', 0, ''),
('202311stAI13', 'PE101', '', '0', 0, '');

-- --------------------------------------------------------

--
-- Table structure for table `section`
--

CREATE TABLE `section` (
  `id` varchar(255) NOT NULL,
  `program` varchar(25) NOT NULL,
  `year_level` varchar(25) NOT NULL,
  `semester` varchar(25) NOT NULL,
  `school_year` year(4) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `section`
--

INSERT INTO `section` (`id`, `program`, `year_level`, `semester`, `school_year`) VALUES
('202311stAI13', 'BSIT', '1', '1st', '2023');

-- --------------------------------------------------------

--
-- Table structure for table `section_availability`
--

CREATE TABLE `section_availability` (
  `section` varchar(255) NOT NULL,
  `day_id` int(10) NOT NULL,
  `slot_id` int(10) NOT NULL,
  `available` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `section_availability`
--

INSERT INTO `section_availability` (`section`, `day_id`, `slot_id`, `available`) VALUES
('202311stAI13', 1, 1, 0),
('202311stAI13', 1, 2, 0),
('202311stAI13', 1, 3, 0),
('202311stAI13', 1, 4, 1),
('202311stAI13', 1, 5, 0),
('202311stAI13', 1, 6, 0),
('202311stAI13', 1, 7, 0),
('202311stAI13', 2, 1, 1),
('202311stAI13', 2, 2, 0),
('202311stAI13', 2, 3, 1),
('202311stAI13', 2, 4, 1),
('202311stAI13', 2, 5, 1),
('202311stAI13', 2, 6, 1),
('202311stAI13', 2, 7, 1),
('202311stAI13', 3, 1, 1),
('202311stAI13', 3, 2, 1),
('202311stAI13', 3, 3, 0),
('202311stAI13', 3, 4, 1),
('202311stAI13', 3, 5, 0),
('202311stAI13', 3, 6, 1),
('202311stAI13', 3, 7, 1),
('202311stAI13', 4, 1, 0),
('202311stAI13', 4, 2, 0),
('202311stAI13', 4, 3, 0),
('202311stAI13', 4, 4, 1),
('202311stAI13', 4, 5, 0),
('202311stAI13', 4, 6, 0),
('202311stAI13', 4, 7, 0),
('202311stAI13', 5, 1, 1),
('202311stAI13', 5, 2, 0),
('202311stAI13', 5, 3, 1),
('202311stAI13', 5, 4, 1),
('202311stAI13', 5, 5, 1),
('202311stAI13', 5, 6, 1),
('202311stAI13', 5, 7, 1),
('202311stAI13', 6, 1, 1),
('202311stAI13', 6, 2, 1),
('202311stAI13', 6, 3, 1),
('202311stAI13', 6, 4, 1),
('202311stAI13', 6, 5, 1),
('202311stAI13', 6, 6, 1),
('202311stAI13', 6, 7, 0);

-- --------------------------------------------------------

--
-- Table structure for table `subjects`
--

CREATE TABLE `subjects` (
  `id` varchar(25) NOT NULL,
  `description` varchar(255) NOT NULL,
  `units` int(5) NOT NULL,
  `program` varchar(25) NOT NULL,
  `year_level` int(2) NOT NULL,
  `semester` varchar(5) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `subjects`
--

INSERT INTO `subjects` (`id`, `description`, `units`, `program`, `year_level`, `semester`) VALUES
('GE101', 'Understanding the Self', 3, 'BSIT', 1, '1st'),
('GE102', 'Readings in Philippine History', 3, 'BSIT', 1, '1st'),
('GE122', 'Kontekstwalisadong Komunikasyon sa Filipino', 3, 'BSIT', 1, '1st'),
('IT101', 'Information Technology Fundamentals with Software Applications', 2, 'BSIT', 1, '1st'),
('IT101L', 'Information Technology Fundamentals with Software Applications (Laboratory)', 1, 'BSIT', 1, '1st'),
('IT102', 'Accounting Principle', 3, 'BSIT', 1, '1st'),
('IT103', 'Computer Programming I - Java', 2, 'BSIT', 1, '1st'),
('IT103L', 'Computer Programming I - Java (Laboratory)', 1, 'BSIT', 1, '1st'),
('IT104', 'Discrete Mathematics', 3, 'BSIT', 1, '1st'),
('NSTP101', 'National Service Training Program I', 3, 'BSIT', 1, '1st'),
('PE101', 'Movement Enhancement', 2, 'BSIT', 1, '1st');

-- --------------------------------------------------------

--
-- Table structure for table `time_slots`
--

CREATE TABLE `time_slots` (
  `slot_id` int(11) NOT NULL,
  `start_time` time NOT NULL,
  `end_time` time NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `time_slots`
--

INSERT INTO `time_slots` (`slot_id`, `start_time`, `end_time`) VALUES
(1, '07:30:00', '09:00:00'),
(2, '09:00:00', '10:30:00'),
(3, '10:30:00', '12:00:00'),
(4, '01:00:00', '02:30:00'),
(5, '02:30:00', '04:00:00'),
(6, '04:00:00', '05:30:00'),
(7, '05:30:00', '07:00:00');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `college`
--
ALTER TABLE `college`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `days`
--
ALTER TABLE `days`
  ADD PRIMARY KEY (`day_id`);

--
-- Indexes for table `faculty`
--
ALTER TABLE `faculty`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `name` (`name`);

--
-- Indexes for table `faculty_availability`
--
ALTER TABLE `faculty_availability`
  ADD KEY `day_id` (`day_id`),
  ADD KEY `time_id` (`time_id`),
  ADD KEY `faculty_availability_ibfk_1` (`faculty_id`);

--
-- Indexes for table `program`
--
ALTER TABLE `program`
  ADD PRIMARY KEY (`id`),
  ADD KEY `college` (`college`);

--
-- Indexes for table `rooms`
--
ALTER TABLE `rooms`
  ADD PRIMARY KEY (`room_id`);

--
-- Indexes for table `room_availability`
--
ALTER TABLE `room_availability`
  ADD KEY `room_id` (`room_id`),
  ADD KEY `day_id` (`day_id`),
  ADD KEY `slot_id` (`slot_id`);

--
-- Indexes for table `section`
--
ALTER TABLE `section`
  ADD PRIMARY KEY (`id`),
  ADD KEY `program` (`program`);

--
-- Indexes for table `section_availability`
--
ALTER TABLE `section_availability`
  ADD KEY `day_id` (`day_id`),
  ADD KEY `slot_id` (`slot_id`),
  ADD KEY `section` (`section`);

--
-- Indexes for table `subjects`
--
ALTER TABLE `subjects`
  ADD PRIMARY KEY (`id`),
  ADD KEY `program` (`program`);

--
-- Indexes for table `time_slots`
--
ALTER TABLE `time_slots`
  ADD PRIMARY KEY (`slot_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `days`
--
ALTER TABLE `days`
  MODIFY `day_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT for table `faculty`
--
ALTER TABLE `faculty`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `time_slots`
--
ALTER TABLE `time_slots`
  MODIFY `slot_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `faculty_availability`
--
ALTER TABLE `faculty_availability`
  ADD CONSTRAINT `faculty_availability_ibfk_1` FOREIGN KEY (`faculty_id`) REFERENCES `faculty` (`name`) ON DELETE CASCADE,
  ADD CONSTRAINT `faculty_availability_ibfk_2` FOREIGN KEY (`day_id`) REFERENCES `days` (`day_id`),
  ADD CONSTRAINT `faculty_availability_ibfk_3` FOREIGN KEY (`time_id`) REFERENCES `time_slots` (`slot_id`);

--
-- Constraints for table `program`
--
ALTER TABLE `program`
  ADD CONSTRAINT `program_ibfk_1` FOREIGN KEY (`college`) REFERENCES `college` (`id`);

--
-- Constraints for table `room_availability`
--
ALTER TABLE `room_availability`
  ADD CONSTRAINT `room_availability_ibfk_1` FOREIGN KEY (`room_id`) REFERENCES `rooms` (`room_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `room_availability_ibfk_2` FOREIGN KEY (`day_id`) REFERENCES `days` (`day_id`),
  ADD CONSTRAINT `room_availability_ibfk_3` FOREIGN KEY (`slot_id`) REFERENCES `time_slots` (`slot_id`);

--
-- Constraints for table `section`
--
ALTER TABLE `section`
  ADD CONSTRAINT `section_ibfk_1` FOREIGN KEY (`program`) REFERENCES `program` (`id`);

--
-- Constraints for table `section_availability`
--
ALTER TABLE `section_availability`
  ADD CONSTRAINT `section_availability_ibfk_1` FOREIGN KEY (`day_id`) REFERENCES `days` (`day_id`),
  ADD CONSTRAINT `section_availability_ibfk_2` FOREIGN KEY (`slot_id`) REFERENCES `time_slots` (`slot_id`);

--
-- Constraints for table `subjects`
--
ALTER TABLE `subjects`
  ADD CONSTRAINT `subjects_ibfk_1` FOREIGN KEY (`program`) REFERENCES `program` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
