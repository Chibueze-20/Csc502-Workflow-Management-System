-- phpMyAdmin SQL Dump
-- version 4.8.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 05, 2019 at 11:20 AM
-- Server version: 10.1.34-MariaDB
-- PHP Version: 7.2.7

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `workflow_app`
--

-- --------------------------------------------------------

--
-- Table structure for table `admin`
--

CREATE TABLE `admin` (
  `UserID` varchar(16) NOT NULL,
  `Type of Admin` varchar(16) NOT NULL,
  `Email Address` varchar(255) NOT NULL,
  `Password` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `course`
--

CREATE TABLE `course` (
  `Course Code` varchar(16) NOT NULL,
  `Course Title` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `course_assignments`
--

CREATE TABLE `course_assignments` (
  `UserID` varchar(16) NOT NULL,
  `Course Code` varchar(16) NOT NULL,
  `Date Assigned` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `course_registration`
--

CREATE TABLE `course_registration` (
  `Course Code` varchar(16) NOT NULL,
  `UserID` varchar(16) NOT NULL,
  `Date Registered` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `student`
--

CREATE TABLE `student` (
  `UserID` varchar(16) NOT NULL,
  `Email Address` varchar(255) NOT NULL,
  `Password` varchar(255) NOT NULL,
  `Level` int(16) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `web_admin`
--

CREATE TABLE `web_admin` (
  `UserID` varchar(16) NOT NULL,
  `Email Address` varchar(255) DEFAULT NULL,
  `Password` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `workflow`
--

CREATE TABLE `workflow` (
  `WorkflowID` varchar(16) NOT NULL,
  `WorkflowTypeID` varchar(16) NOT NULL,
  `Value` longtext NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `workflow_type`
--

CREATE TABLE `workflow_type` (
  `WorkflowTypeID` varchar(16) NOT NULL,
  `Name` varchar(255) NOT NULL,
  `Requirements` longtext NOT NULL,
  `Parties Involved` longtext NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `admin`
--
ALTER TABLE `admin`
  ADD PRIMARY KEY (`UserID`);

--
-- Indexes for table `course`
--
ALTER TABLE `course`
  ADD PRIMARY KEY (`Course Code`);

--
-- Indexes for table `course_assignments`
--
ALTER TABLE `course_assignments`
  ADD UNIQUE KEY `CourseAssignmentIndex` (`UserID`,`Course Code`);

--
-- Indexes for table `course_registration`
--
ALTER TABLE `course_registration`
  ADD UNIQUE KEY `CourseRegistrationID` (`Course Code`,`UserID`);

--
-- Indexes for table `student`
--
ALTER TABLE `student`
  ADD PRIMARY KEY (`UserID`);

--
-- Indexes for table `web_admin`
--
ALTER TABLE `web_admin`
  ADD PRIMARY KEY (`UserID`);

--
-- Indexes for table `workflow`
--
ALTER TABLE `workflow`
  ADD PRIMARY KEY (`WorkflowID`),
  ADD UNIQUE KEY `WorkflowTypeID` (`WorkflowTypeID`);

--
-- Indexes for table `workflow_type`
--
ALTER TABLE `workflow_type`
  ADD PRIMARY KEY (`WorkflowTypeID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
