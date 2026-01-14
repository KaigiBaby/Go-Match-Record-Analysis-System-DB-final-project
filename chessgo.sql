-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- 主機： 127.0.0.1
-- 產生時間： 2024-06-12 13:05:20
-- 伺服器版本： 10.4.32-MariaDB
-- PHP 版本： 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- 資料庫： `chessgo`
--

-- --------------------------------------------------------

--
-- 資料表結構 `學生`
--

CREATE TABLE `學生` (
  `sid` int(11) NOT NULL,
  `saccount` varchar(20) NOT NULL,
  `spassword` char(11) NOT NULL,
  `sname` char(11) NOT NULL,
  `slevel` char(11) DEFAULT NULL,
  `sphone` varchar(11) NOT NULL,
  `school` varchar(11) NOT NULL,
  `grade` varchar(11) NOT NULL,
  `teacher` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- 傾印資料表的資料 `學生`
--

INSERT INTO `學生` (`sid`, `saccount`, `spassword`, `sname`, `slevel`, `sphone`, `school`, `grade`, `teacher`) VALUES
(1, 's123', '123', 'XiangXiangB', '1級', '0912345678', '嘉義大學', '', 1),
(2, 'a111111', '987654321', '王小美', '10級', '0922222222', '光明國中', '', 1),
(3, 'a222222', '45632483', '王大美', '7級', '0933333333', '光明國中', '', 1);

-- --------------------------------------------------------

--
-- 資料表結構 `對弈`
--

CREATE TABLE `對弈` (
  `Rid` int(11) NOT NULL,
  `board` int(11) DEFAULT NULL,
  `first` int(11) NOT NULL,
  `after` int(11) NOT NULL,
  `pkdate` date DEFAULT NULL,
  `winner` int(11) NOT NULL,
  `judge` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- 傾印資料表的資料 `對弈`
--

INSERT INTO `對弈` (`Rid`, `board`, `first`, `after`, `pkdate`, `winner`, `judge`) VALUES
(1, 13, 2, 1, '2024-06-08', 1, 1),
(2, 13, 2, 1, '2024-06-05', 1, 1),
(3, 13, 2, 1, '2024-06-12', 1, 2),
(4, 19, 3, 2, '2024-06-12', 3, 3);

-- --------------------------------------------------------

--
-- 資料表結構 `老師`
--

CREATE TABLE `老師` (
  `Tid` int(11) NOT NULL,
  `Taccount` varchar(20) NOT NULL,
  `Tpassword` char(11) NOT NULL,
  `Tname` char(11) NOT NULL,
  `Tlevel` char(11) DEFAULT NULL,
  `Tphone` varchar(11) NOT NULL,
  `workdate` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- 傾印資料表的資料 `老師`
--

INSERT INTO `老師` (`Tid`, `Taccount`, `Tpassword`, `Tname`, `Tlevel`, `Tphone`, `workdate`) VALUES
(1, 't001', '123', 'GigiBaby', '四段', '0987654321', '2018-06-09'),
(2, 't002', 'secure456', '李四', '7級', '0922333444', '2019-06-10'),
(3, 't003', 'mypassword7', '王五', '6級', '0933444555', '2020-11-20');

--
-- 已傾印資料表的索引
--

--
-- 資料表索引 `學生`
--
ALTER TABLE `學生`
  ADD PRIMARY KEY (`sid`),
  ADD KEY `teacher` (`teacher`);

--
-- 資料表索引 `對弈`
--
ALTER TABLE `對弈`
  ADD PRIMARY KEY (`Rid`),
  ADD KEY `first` (`first`),
  ADD KEY `after` (`after`),
  ADD KEY `winner` (`winner`),
  ADD KEY `judge` (`judge`);

--
-- 資料表索引 `老師`
--
ALTER TABLE `老師`
  ADD PRIMARY KEY (`Tid`);

--
-- 在傾印的資料表使用自動遞增(AUTO_INCREMENT)
--

--
-- 使用資料表自動遞增(AUTO_INCREMENT) `學生`
--
ALTER TABLE `學生`
  MODIFY `sid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- 使用資料表自動遞增(AUTO_INCREMENT) `對弈`
--
ALTER TABLE `對弈`
  MODIFY `Rid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- 使用資料表自動遞增(AUTO_INCREMENT) `老師`
--
ALTER TABLE `老師`
  MODIFY `Tid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- 已傾印資料表的限制式
--

--
-- 資料表的限制式 `學生`
--
ALTER TABLE `學生`
  ADD CONSTRAINT `學生_ibfk_1` FOREIGN KEY (`teacher`) REFERENCES `老師` (`Tid`);

--
-- 資料表的限制式 `對弈`
--
ALTER TABLE `對弈`
  ADD CONSTRAINT `對弈_ibfk_1` FOREIGN KEY (`first`) REFERENCES `學生` (`sid`),
  ADD CONSTRAINT `對弈_ibfk_2` FOREIGN KEY (`after`) REFERENCES `學生` (`sid`),
  ADD CONSTRAINT `對弈_ibfk_3` FOREIGN KEY (`winner`) REFERENCES `學生` (`sid`),
  ADD CONSTRAINT `對弈_ibfk_4` FOREIGN KEY (`judge`) REFERENCES `老師` (`Tid`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
