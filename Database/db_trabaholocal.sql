-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jun 24, 2026 at 05:40 PM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_trabaholocal`
--

-- --------------------------------------------------------

--
-- Table structure for table `tblapplications`
--

CREATE TABLE `tblapplications` (
  `ApplicationID` int(11) NOT NULL,
  `JobID` int(11) NOT NULL,
  `WorkerID` int(11) NOT NULL,
  `ApplicationDate` datetime DEFAULT current_timestamp(),
  `Status` varchar(50) DEFAULT 'Pending',
  `CompletionDate` datetime DEFAULT NULL,
  `IsPaid` tinyint(1) DEFAULT 0,
  `CoverLetter` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tblapplications`
--

INSERT INTO `tblapplications` (`ApplicationID`, `JobID`, `WorkerID`, `ApplicationDate`, `Status`, `CompletionDate`, `IsPaid`, `CoverLetter`) VALUES
(1, 6, 4, '2026-05-02 21:52:32', 'Pending', NULL, 0, NULL),
(2, 5, 4, '2026-05-02 21:57:22', 'Completed', '2026-05-02 21:58:07', 0, NULL),
(3, 7, 4, '2026-05-02 22:40:43', 'Accepted', '2026-05-03 12:47:50', 1, NULL),
(4, 12, 5, '2026-05-03 13:16:47', 'Completed', NULL, 0, NULL),
(5, 11, 4, '2026-05-03 13:17:54', 'Completed', NULL, 0, NULL),
(6, 13, 5, '2026-05-04 11:57:02', 'Completed', NULL, 0, NULL),
(7, 13, 4, '2026-05-09 17:10:49', 'Accepted', NULL, 0, NULL),
(8, 13, 4, '2026-05-09 18:33:27', 'Accepted', NULL, 0, 'Hi! I am a professional video editor specialized in turning raw footage into high-converting Reels and TikToks. While I am an expert in short-form pacing and storytelling, I focus on retention-driven editing—structuring hooks to grab attention instantly and using precise cuts to keep viewers engaged.\n\nI am highly proficient in Premiere Pro and CapCut, and I can easily deliver the 6 videos per week you require with a fast turnaround. I prioritize clean visuals, impactful sound design, and modern trends to ensure every video feels professional and upload-ready.\n\nI am happy to do a paid or sample test edit to show you exactly what I can do—just provide the raw footage.\r\n\r\nTechnical Pacing Sample: https://youtu.be/wjA2yY_al20\n\nVisual \r\nStorytelling Sample: https://youtu.be/veIVjKdiB0U'),
(9, 13, 4, '2026-05-09 18:58:44', 'Pending', NULL, 0, 'test'),
(10, 13, 4, '2026-05-09 18:58:51', 'Pending', NULL, 0, 'test'),
(11, 17, 4, '2026-05-09 20:29:10', 'Rejected', NULL, 0, 'I\'m experience interior design.'),
(12, 19, 4, '2026-05-09 20:46:48', 'Rejected', NULL, 0, 'Interested!'),
(13, 29, 4, '2026-05-11 02:08:26', 'Rejected', NULL, 0, 'Interested!'),
(14, 28, 4, '2026-05-11 03:34:56', 'Rejected', NULL, 0, 'Interested!'),
(15, 27, 4, '2026-05-11 03:42:11', 'Rejected', NULL, 0, 'interested'),
(16, 26, 4, '2026-05-11 20:17:21', 'Rejected', NULL, 0, 'Interested!'),
(17, 25, 4, '2026-05-11 20:24:38', 'Rejected', NULL, 0, 'Interested!'),
(18, 24, 5, '2026-05-11 20:52:22', 'Closed', NULL, 0, 'Yes!'),
(19, 23, 4, '2026-05-11 21:01:06', 'Closed', NULL, 0, 'Yes I!'),
(20, 30, 5, '2026-05-11 21:19:05', 'Closed', NULL, 0, 'Apply ko bi'),
(21, 31, 5, '2026-05-11 21:19:26', 'Closed', NULL, 0, 'oo kamao ko'),
(22, 22, 4, '2026-05-12 13:44:26', 'Closed', NULL, 0, 'Interested!');

-- --------------------------------------------------------

--
-- Table structure for table `tblemployeers`
--

CREATE TABLE `tblemployeers` (
  `EmployeerID` int(11) NOT NULL,
  `UserID` int(11) NOT NULL,
  `FullName` varchar(100) NOT NULL,
  `Location` varchar(100) DEFAULT NULL,
  `ContactNumber` varchar(100) DEFAULT NULL,
  `CompanyDetails` text DEFAULT NULL,
  `ProfilePicPath` varchar(500) DEFAULT NULL,
  `IDImagePath` varchar(500) DEFAULT NULL,
  `IsVerified` tinyint(1) DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tblemployeers`
--

INSERT INTO `tblemployeers` (`EmployeerID`, `UserID`, `FullName`, `Location`, `ContactNumber`, `CompanyDetails`, `ProfilePicPath`, `IDImagePath`, `IsVerified`) VALUES
(3, 1, 'Julio Tare', NULL, NULL, NULL, NULL, NULL, 0),
(7, 11, 'Hans Tare', 'San Fernando, Cebu', '+63 917 123 4567', '', 'C:\\00_JULIO_FILES\\02_SCHOOL FILES\\2ND_YEAR_FILES\\vb_coding\\Final_System\\TrabahoLocal\\TrabahoLocal\\bin\\Debug\\ProfilePics\\Pic_Employer_11_639139367650545060.jpg', 'C:\\00_JULIO_FILES\\02_SCHOOL FILES\\2ND_YEAR_FILES\\vb_coding\\Final_System\\TrabahoLocal\\TrabahoLocal\\bin\\Debug\\ID_Uploads\\ID_Employer_11.png', 1),
(9, 11, 'Hans Tare', 'San Fernando, Cebu', '+63 917 123 4567', '', 'C:\\00_JULIO_FILES\\02_SCHOOL FILES\\2ND_YEAR_FILES\\vb_coding\\Final_System\\TrabahoLocal\\TrabahoLocal\\bin\\Debug\\ProfilePics\\Pic_Employer_11_639139367650545060.jpg', 'C:\\00_JULIO_FILES\\02_SCHOOL FILES\\2ND_YEAR_FILES\\vb_coding\\Final_System\\TrabahoLocal\\TrabahoLocal\\bin\\Debug\\ID_Uploads\\ID_Employer_11.png', 1),
(11, 19, 'Franz Pegarido', NULL, NULL, NULL, NULL, NULL, 0);

-- --------------------------------------------------------

--
-- Table structure for table `tbljobs`
--

CREATE TABLE `tbljobs` (
  `JobID` int(11) NOT NULL,
  `EmployeerID` int(11) NOT NULL,
  `JobTitle` varchar(100) NOT NULL,
  `Category` varchar(100) DEFAULT NULL,
  `JobType` varchar(50) DEFAULT NULL,
  `Location` varchar(100) NOT NULL,
  `Salary` varchar(50) DEFAULT NULL,
  `Description` text DEFAULT NULL,
  `DatePosted` timestamp NOT NULL DEFAULT current_timestamp(),
  `PayType` varchar(50) DEFAULT 'Fixed',
  `PayRate` decimal(10,2) DEFAULT 0.00,
  `Status` varchar(20) DEFAULT 'Open'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbljobs`
--

INSERT INTO `tbljobs` (`JobID`, `EmployeerID`, `JobTitle`, `Category`, `JobType`, `Location`, `Salary`, `Description`, `DatePosted`, `PayType`, `PayRate`, `Status`) VALUES
(17, 7, 'House Painter (Interior & Exterior)', NULL, NULL, 'South Poblacion, San Fernando', '800 / day', 'Need an experienced house painter for a 2-story residential home. We will provide the paint and brushes. Estimated work is 3 to 4 days.', '2026-05-09 12:00:59', 'Fixed', 0.00, 'Filled'),
(18, 7, 'Skilled Carpenter', NULL, NULL, 'Inoburan, City of Naga', '1000 / day', 'Looking for a skilled carpenter to build custom wooden cabinets and repair a broken roof frame. Please bring your own basic hand tools.', '2026-05-09 12:00:59', 'Fixed', 0.00, 'Open'),
(19, 7, 'Emergency Plumber', NULL, NULL, 'Tunghaan, Minglanilla', '1500', 'Need a reliable plumber to fix a severely leaking pipe in the bathroom and install a new sink. Negotiable rate depending on how fast you can fix it.', '2026-05-09 12:00:59', 'Fixed', 0.00, 'Filled'),
(20, 7, 'Freelance Video Editor', NULL, NULL, 'Remote', '0', 'Looking for an editor familiar with Adobe Premiere Pro and CapCut for weekly vlogs. Need clean audio mixing and text overlays.', '2026-05-10 18:05:38', 'Hourly', 250.00, 'Open'),
(21, 7, 'IT Support Specialist', NULL, NULL, 'Cebu City', '1500.00', 'Need help troubleshooting a BSOD error on an HP Victus 15 laptop and configuring a custom 50%-80% battery charging threshold for hardware longevity.', '2026-05-10 18:05:38', 'Fixed', 0.00, 'Open'),
(22, 7, 'Dance Choreographer', NULL, NULL, 'Dumanjug', '3000.00', 'Need a choreographer for a school sports mimetic routine. Must know trending Pinoy hip-hop (Hev Abi, Flow G, SB19).', '2026-05-10 18:05:38', 'Fixed', 0.00, 'Filled'),
(23, 7, 'Database Programmer', NULL, NULL, 'Remote', '5000.00', 'Need an IT student to help build a database-connected login form using VB.NET and MySQL for a school project.', '2026-05-10 18:05:38', 'Fixed', 0.00, 'Filled'),
(24, 7, 'Emergency Plumber', NULL, NULL, 'Mabuhay', '800.00', 'Under-sink pipe is leaking rapidly. Need immediate repair. Parts will be reimbursed upon presentation of receipt.', '2026-05-10 18:05:38', 'Fixed', 0.00, 'Filled'),
(25, 7, 'House Painter (Interior)', NULL, NULL, 'Dumanjug', '2500.00', 'Looking for a painter to repaint two bedrooms. Paint will be provided, but please bring your own brushes and rollers.', '2026-05-10 18:05:38', 'Fixed', 0.00, 'Filled'),
(26, 7, 'Aircon Cleaning', NULL, NULL, 'Moalboal', '1200.00', 'General cleaning needed for two split-type air conditioning units to prepare for the summer heat.', '2026-05-10 18:05:38', 'Fixed', 0.00, 'Filled'),
(27, 7, 'Data Entry Assistant', NULL, NULL, 'Remote', '0', 'Need someone to encode inventory records into an ERP system database quickly and accurately.', '2026-05-10 18:05:38', 'Hourly', 100.00, 'Filled'),
(28, 7, 'Motorcycle Mechanic', NULL, NULL, 'Barili', '600.00', 'Change oil and tune-up for a scooter. Please come to my garage, tools are available here.', '2026-05-10 18:05:38', 'Fixed', 0.00, 'Filled'),
(29, 7, 'Graphic Designer', NULL, NULL, 'Remote', '500.00', 'Need a digital poster designed for a social media promo. Must ensure all out-of-date service offers are removed from the layout.', '2026-05-10 18:05:38', 'Fixed', 0.00, 'Filled'),
(30, 7, 'Office Assistant', NULL, NULL, 'Calidngan, Carcar City', 'Hourly at ₱100', 'Basta', '2026-05-11 13:14:42', 'Fixed', 0.00, 'Filled'),
(31, 7, 'Construction Helper', NULL, NULL, 'Cabadiangan, Compostela', 'Daily at ₱600', 'Basta', '2026-05-11 13:18:04', 'Fixed', 0.00, 'Filled');

-- --------------------------------------------------------

--
-- Table structure for table `tblmessages`
--

CREATE TABLE `tblmessages` (
  `MessageID` int(11) NOT NULL,
  `ApplicationID` int(11) NOT NULL,
  `SenderID` int(11) NOT NULL,
  `MessageText` text NOT NULL,
  `SentDate` datetime DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tblmessages`
--

INSERT INTO `tblmessages` (`MessageID`, `ApplicationID`, `SenderID`, `MessageText`, `SentDate`) VALUES
(1, 4, 16, 'hello, sir', '2026-05-03 13:56:00'),
(2, 4, 11, 'Hello Dong', '2026-05-04 11:23:14'),
(3, 7, 11, 'Hey', '2026-05-09 17:11:20'),
(4, 21, 11, 'hey', '2026-05-11 22:22:10'),
(5, 21, 11, 'Hey', '2026-05-11 22:29:31'),
(6, 21, 11, 'Hi Chester, please bring your own ladder tomorrow. Thanks!', '2026-05-11 22:48:05'),
(7, 21, 16, 'Copy that, boss! I\'ll be there at 8 AM', '2026-05-11 22:49:15'),
(8, 22, 11, 'idol', '2026-05-12 13:45:20'),
(9, 22, 7, 'oo mana dol dali ra kaayu', '2026-05-12 13:46:32');

-- --------------------------------------------------------

--
-- Table structure for table `tblnotifications`
--

CREATE TABLE `tblnotifications` (
  `NotificationID` int(11) NOT NULL,
  `UserID` int(11) NOT NULL,
  `Message` varchar(255) NOT NULL,
  `IsRead` tinyint(1) DEFAULT 0,
  `DateCreated` datetime DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tblnotifications`
--

INSERT INTO `tblnotifications` (`NotificationID`, `UserID`, `Message`, `IsRead`, `DateCreated`) VALUES
(1, 7, 'Great news! Your application was accepted. You are officially hired for the job!', 1, '2026-05-11 03:43:11'),
(2, 7, 'You have been paid ₱2,500.00 for your recent job! A digital receipt is now available in your History.', 1, '2026-05-11 20:25:48'),
(3, 7, 'Update: The employer has reviewed your cover letter and decided to move forward with other candidates.', 1, '2026-05-11 20:47:23'),
(4, 7, 'Update: The employer has reviewed your cover letter and decided to move forward with other candidates.', 1, '2026-05-11 20:47:33'),
(5, 7, 'Update: The employer has reviewed your cover letter and decided to move forward with other candidates.', 1, '2026-05-11 20:47:44'),
(6, 16, 'Great news! Your application was accepted after review. You are officially hired!', 1, '2026-05-11 20:53:11'),
(7, 16, 'You have been paid ₱800.00 for your recent job! A digital receipt is now available in your History.', 1, '2026-05-11 20:53:25'),
(8, 7, 'Great news! Your application was accepted. You are officially hired for the job!', 1, '2026-05-11 21:01:26'),
(9, 16, 'Great news! Your application was accepted after review. You are officially hired!', 1, '2026-05-11 21:20:00'),
(10, 16, 'Great news! Your application was accepted after review. You are officially hired!', 1, '2026-05-11 21:20:04'),
(11, 16, 'You have been paid ₱1,800.00 for your recent job! A digital receipt is now available in your History.', 1, '2026-05-11 21:40:45'),
(12, 16, 'You have been paid ₱500.00 for your recent job! A digital receipt is now available in your History.', 1, '2026-05-11 21:41:42'),
(13, 7, 'You have been paid ₱5,000.00 for your recent job! A digital receipt is now available in your History.', 1, '2026-05-11 22:05:45'),
(14, 18, 'Your account has been verified by the Admin. You can now use all features!', 1, '2026-05-12 01:40:29'),
(15, 7, 'Great news! Your application was accepted after review. You are officially hired!', 1, '2026-05-12 13:45:04'),
(16, 7, 'You have been paid ₱3,000.00 for your recent job! A digital receipt is now available in your History.', 1, '2026-05-12 13:45:59');

-- --------------------------------------------------------

--
-- Table structure for table `tblreviews`
--

CREATE TABLE `tblreviews` (
  `ReviewID` int(11) NOT NULL,
  `ApplicationID` int(11) DEFAULT NULL,
  `Rating` int(11) DEFAULT NULL CHECK (`Rating` between 1 and 5),
  `Feedback` text DEFAULT NULL,
  `ReviewDate` datetime DEFAULT current_timestamp(),
  `Comments` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tblreviews`
--

INSERT INTO `tblreviews` (`ReviewID`, `ApplicationID`, `Rating`, `Feedback`, `ReviewDate`, `Comments`) VALUES
(1, 3, 3, 'ambot', '2026-05-02 22:42:05', NULL),
(2, 12, 5, NULL, '2026-05-09 20:52:40', 'Good Job!!'),
(3, 13, 5, NULL, '2026-05-11 02:10:44', 'Job Well Done!'),
(4, 16, 5, NULL, '2026-05-11 20:19:31', 'good job!');

-- --------------------------------------------------------

--
-- Table structure for table `tbltimelogs`
--
-- Error reading structure for table db_trabaholocal.tbltimelogs: #1932 - Table &#039;db_trabaholocal.tbltimelogs&#039; doesn&#039;t exist in engine
-- Error reading data for table db_trabaholocal.tbltimelogs: #1064 - You have an error in your SQL syntax; check the manual that corresponds to your MariaDB server version for the right syntax to use near &#039;FROM `db_trabaholocal`.`tbltimelogs`&#039; at line 1

-- --------------------------------------------------------

--
-- Table structure for table `tbltransactions`
--

CREATE TABLE `tbltransactions` (
  `TransactionID` int(11) NOT NULL,
  `ApplicationID` int(11) NOT NULL,
  `EmployerID` int(11) NOT NULL,
  `WorkerID` int(11) NOT NULL,
  `AmountPaid` decimal(10,2) NOT NULL,
  `PaymentMethod` varchar(20) DEFAULT 'Cash/Manual',
  `TransactionDate` datetime DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbltransactions`
--

INSERT INTO `tbltransactions` (`TransactionID`, `ApplicationID`, `EmployerID`, `WorkerID`, `AmountPaid`, `PaymentMethod`, `TransactionDate`) VALUES
(1, 13, 7, 4, 500.00, 'Cash/Manual', '2026-05-11 02:10:44'),
(2, 16, 7, 4, 1200.00, 'Cash/Manual', '2026-05-11 20:19:31'),
(3, 17, 7, 4, 2500.00, 'Cash/Manual', '2026-05-11 20:25:48'),
(4, 18, 7, 5, 800.00, 'Cash/Manual', '2026-05-11 20:53:25'),
(5, 21, 7, 5, 1800.00, 'Cash/Manual', '2026-05-11 21:40:45'),
(6, 20, 7, 5, 500.00, 'Cash/Manual', '2026-05-11 21:41:42'),
(7, 19, 7, 4, 5000.00, 'Cash/Manual', '2026-05-11 22:05:45'),
(8, 22, 7, 4, 3000.00, 'Cash/Manual', '2026-05-12 13:45:59');

-- --------------------------------------------------------

--
-- Table structure for table `tblusers`
--

CREATE TABLE `tblusers` (
  `UserID` int(11) NOT NULL,
  `FullName` varchar(100) DEFAULT NULL,
  `Username` varchar(50) NOT NULL,
  `Password` varchar(255) NOT NULL,
  `AccountType` varchar(20) NOT NULL,
  `Email` varchar(100) DEFAULT NULL,
  `City` varchar(100) DEFAULT NULL,
  `Barangay` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tblusers`
--

INSERT INTO `tblusers` (`UserID`, `FullName`, `Username`, `Password`, `AccountType`, `Email`, `City`, `Barangay`) VALUES
(7, 'Julio Tare', 'worker1!', 'worker1!', 'Worker', 'juliosofiotare@gmail.com', 'San Fernando', 'Greenhills'),
(11, 'Hans Tare', 'employer1!', 'employer1!', 'Employer', 'jstech404@gmail.com', 'Dumanjug', 'Mabuhay'),
(15, 'System Administrator', 'admin', 'admin123', 'Admin', NULL, NULL, NULL),
(16, 'Chester Villareal', 'worker2!', 'worker2!', 'Worker', 'tarejulio404@gmail.com', 'Consolacion', 'Tayud'),
(19, 'Franz Pegarido', 'employer2!', 'employer2!', 'Employer', 'loystorage02@gmail.com', 'Consolacion', 'Tolotolo'),
(20, 'Gwapo Ko', 'gwapoko768', 'gwapoko768', 'Worker', 'juliotare.mcgi@gmail.com', 'Dalaguete', 'Obong');

-- --------------------------------------------------------

--
-- Table structure for table `tblworkers`
--

CREATE TABLE `tblworkers` (
  `WorkerID` int(11) NOT NULL,
  `UserID` int(11) NOT NULL,
  `FullName` varchar(100) NOT NULL,
  `Location` varchar(100) DEFAULT NULL,
  `ContactNumber` varchar(100) DEFAULT NULL,
  `Skills` text DEFAULT NULL,
  `Experience` text DEFAULT NULL,
  `ResumePath` varchar(255) DEFAULT NULL,
  `ProfilePicPath` varchar(255) DEFAULT NULL,
  `IDImagePath` varchar(500) DEFAULT NULL,
  `IsVerified` tinyint(1) DEFAULT 0,
  `Headline` varchar(255) DEFAULT NULL,
  `ExpectedSalary` varchar(255) DEFAULT NULL,
  `Education` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tblworkers`
--

INSERT INTO `tblworkers` (`WorkerID`, `UserID`, `FullName`, `Location`, `ContactNumber`, `Skills`, `Experience`, `ResumePath`, `ProfilePicPath`, `IDImagePath`, `IsVerified`, `Headline`, `ExpectedSalary`, `Education`) VALUES
(4, 7, 'Julio Tare', NULL, NULL, 'Video Editor, Photographer, Videographer, Adobe Premiere Pro, CapCut, Motion Graphics', 'Freelance video editor and content creator specializing in high-retention short-form content for social media (TikToks, Instagram Reels) and YouTube automation. Proficient in optimizing workspaces, applying text animations, and utilizing tools like Premiere Composer for fast turnarounds. Experienced in handling end-to-end post-production for local clients and businesses.', 'C:\\00_JULIO_FILES\\02_SCHOOL FILES\\2ND_YEAR_FILES\\vb_coding\\Final_System\\TrabahoLocal\\TrabahoLocal\\bin\\Debug\\Resumes\\Resume_User_7.pdf', 'C:\\00_JULIO_FILES\\02_SCHOOL FILES\\2ND_YEAR_FILES\\vb_coding\\Final_System\\TrabahoLocal\\TrabahoLocal\\bin\\Debug\\ProfilePics\\Pic_User_7_639133934496540718.jpg', 'C:\\00_JULIO_FILES\\02_SCHOOL FILES\\2ND_YEAR_FILES\\vb_coding\\Final_System\\TrabahoLocal\\TrabahoLocal\\bin\\Debug\\ID_Uploads\\ID_Worker_7.png', 1, 'Freelance Photographer, Videographer, and Video Editor with Graphic Design Skills | IT Student', 'Looking for Part-time work (4 hours/day) at Php 400.00/hour (Php 35,200.00/month)', 'Bachelor\'s degree'),
(5, 16, 'Chester Villareal', NULL, NULL, 'VB.NET, Python, PHP, SQL, Database Management, PC Troubleshooting', 'Active programmer and system developer with experience building database-driven applications for local businesses. Developed a LAMP/WAMP-based Fuel Inventory Management System for gas stations to monitor stock and detect variance. Proficient in creating modern, secure UI applications (WinForms, CustomTkinter) and handling hardware-level troubleshooting for Windows environments.', 'C:\\00_JULIO_FILES\\02_SCHOOL FILES\\2ND_YEAR_FILES\\vb_coding\\Final_System\\TrabahoLocal\\TrabahoLocal\\bin\\Debug\\Resumes\\Resume_User_16.pdf', 'C:\\00_JULIO_FILES\\02_SCHOOL FILES\\2ND_YEAR_FILES\\vb_coding\\Final_System\\TrabahoLocal\\TrabahoLocal\\bin\\Debug\\ProfilePics\\Pic_User_16_639134101981730687.jpg', 'C:\\00_JULIO_FILES\\02_SCHOOL FILES\\2ND_YEAR_FILES\\vb_coding\\Final_System\\TrabahoLocal\\TrabahoLocal\\bin\\Debug\\ID_Uploads\\ID_Worker_16.png', 1, 'IT | Backend Developer', 'Negotiable', 'Bachelors Degree'),
(8, 20, 'Gwapo Ko', NULL, NULL, NULL, NULL, NULL, NULL, 'C:\\00_JULIO_FILES\\02_SCHOOL FILES\\2ND_YEAR_FILES\\vb_coding\\Final_System\\TrabahoLocal\\TrabahoLocal\\bin\\Debug\\ID_Uploads\\ID_Worker_20.png', 0, NULL, NULL, NULL);

-- --------------------------------------------------------

--
-- Table structure for table `tbl_dtr`
--

CREATE TABLE `tbl_dtr` (
  `LogID` int(11) NOT NULL,
  `ApplicationID` int(11) NOT NULL,
  `TimeIn` datetime NOT NULL,
  `TimeOut` datetime DEFAULT NULL,
  `TotalHours` decimal(5,2) DEFAULT 0.00,
  `LogDate` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_dtr`
--

INSERT INTO `tbl_dtr` (`LogID`, `ApplicationID`, `TimeIn`, `TimeOut`, `TotalHours`, `LogDate`) VALUES
(1, 4, '2026-05-05 12:41:05', '2026-05-05 12:41:11', 0.00, '2026-05-05'),
(2, 5, '2026-05-05 15:14:54', '2026-05-05 15:14:57', 0.00, '2026-05-05'),
(3, 5, '2026-05-09 14:12:06', '2026-05-09 14:12:09', 0.00, '2026-05-09');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tblapplications`
--
ALTER TABLE `tblapplications`
  ADD PRIMARY KEY (`ApplicationID`);

--
-- Indexes for table `tblemployeers`
--
ALTER TABLE `tblemployeers`
  ADD PRIMARY KEY (`EmployeerID`),
  ADD KEY `UserID` (`UserID`);

--
-- Indexes for table `tbljobs`
--
ALTER TABLE `tbljobs`
  ADD PRIMARY KEY (`JobID`),
  ADD KEY `EmployeerID` (`EmployeerID`);

--
-- Indexes for table `tblmessages`
--
ALTER TABLE `tblmessages`
  ADD PRIMARY KEY (`MessageID`),
  ADD KEY `ApplicationID` (`ApplicationID`),
  ADD KEY `SenderID` (`SenderID`);

--
-- Indexes for table `tblnotifications`
--
ALTER TABLE `tblnotifications`
  ADD PRIMARY KEY (`NotificationID`);

--
-- Indexes for table `tblreviews`
--
ALTER TABLE `tblreviews`
  ADD PRIMARY KEY (`ReviewID`),
  ADD KEY `ApplicationID` (`ApplicationID`);

--
-- Indexes for table `tbltransactions`
--
ALTER TABLE `tbltransactions`
  ADD PRIMARY KEY (`TransactionID`);

--
-- Indexes for table `tblusers`
--
ALTER TABLE `tblusers`
  ADD PRIMARY KEY (`UserID`),
  ADD UNIQUE KEY `Username` (`Username`);

--
-- Indexes for table `tblworkers`
--
ALTER TABLE `tblworkers`
  ADD PRIMARY KEY (`WorkerID`),
  ADD KEY `UserID` (`UserID`);

--
-- Indexes for table `tbl_dtr`
--
ALTER TABLE `tbl_dtr`
  ADD PRIMARY KEY (`LogID`),
  ADD KEY `ApplicationID` (`ApplicationID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tblapplications`
--
ALTER TABLE `tblapplications`
  MODIFY `ApplicationID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=23;

--
-- AUTO_INCREMENT for table `tblemployeers`
--
ALTER TABLE `tblemployeers`
  MODIFY `EmployeerID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT for table `tbljobs`
--
ALTER TABLE `tbljobs`
  MODIFY `JobID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=32;

--
-- AUTO_INCREMENT for table `tblmessages`
--
ALTER TABLE `tblmessages`
  MODIFY `MessageID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT for table `tblnotifications`
--
ALTER TABLE `tblnotifications`
  MODIFY `NotificationID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=17;

--
-- AUTO_INCREMENT for table `tblreviews`
--
ALTER TABLE `tblreviews`
  MODIFY `ReviewID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `tbltransactions`
--
ALTER TABLE `tbltransactions`
  MODIFY `TransactionID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `tblusers`
--
ALTER TABLE `tblusers`
  MODIFY `UserID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;

--
-- AUTO_INCREMENT for table `tblworkers`
--
ALTER TABLE `tblworkers`
  MODIFY `WorkerID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `tbl_dtr`
--
ALTER TABLE `tbl_dtr`
  MODIFY `LogID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `tblemployeers`
--
ALTER TABLE `tblemployeers`
  ADD CONSTRAINT `tblemployeers_ibfk_1` FOREIGN KEY (`UserID`) REFERENCES `tblusers` (`UserID`) ON DELETE CASCADE;

--
-- Constraints for table `tbljobs`
--
ALTER TABLE `tbljobs`
  ADD CONSTRAINT `tbljobs_ibfk_1` FOREIGN KEY (`EmployeerID`) REFERENCES `tblemployeers` (`EmployeerID`) ON DELETE CASCADE;

--
-- Constraints for table `tblmessages`
--
ALTER TABLE `tblmessages`
  ADD CONSTRAINT `tblmessages_ibfk_1` FOREIGN KEY (`ApplicationID`) REFERENCES `tblapplications` (`ApplicationID`) ON DELETE CASCADE,
  ADD CONSTRAINT `tblmessages_ibfk_2` FOREIGN KEY (`SenderID`) REFERENCES `tblusers` (`UserID`) ON DELETE CASCADE;

--
-- Constraints for table `tblreviews`
--
ALTER TABLE `tblreviews`
  ADD CONSTRAINT `tblreviews_ibfk_1` FOREIGN KEY (`ApplicationID`) REFERENCES `tblapplications` (`ApplicationID`);

--
-- Constraints for table `tblworkers`
--
ALTER TABLE `tblworkers`
  ADD CONSTRAINT `tblworkers_ibfk_1` FOREIGN KEY (`UserID`) REFERENCES `tblusers` (`UserID`) ON DELETE CASCADE;

--
-- Constraints for table `tbl_dtr`
--
ALTER TABLE `tbl_dtr`
  ADD CONSTRAINT `tbl_dtr_ibfk_1` FOREIGN KEY (`ApplicationID`) REFERENCES `tblapplications` (`ApplicationID`) ON DELETE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
