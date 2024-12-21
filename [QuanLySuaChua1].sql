-- MySQL dump 10.13  Distrib 9.1.0, for Win64 (x86_64)
--
-- Host: localhost    Database: QuanLySuaChua1
-- ------------------------------------------------------
-- Server version	9.1.0

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `chitietsuachua`
--

DROP TABLE IF EXISTS `chitietsuachua`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `chitietsuachua` (
  `ID_chi_tiet_sua_chua` int NOT NULL AUTO_INCREMENT,
  `ID_phieu_sua_chua` int DEFAULT NULL,
  `ID_dich_vu` int DEFAULT NULL,
  `ID_linh_kien` int DEFAULT NULL,
  `So_luong_linh_kien_su_dung` int DEFAULT NULL,
  `Tong_chi_phi` float DEFAULT NULL,
  PRIMARY KEY (`ID_chi_tiet_sua_chua`),
  KEY `ID_phieu_sua_chua` (`ID_phieu_sua_chua`),
  KEY `ID_dich_vu` (`ID_dich_vu`),
  KEY `ID_linh_kien` (`ID_linh_kien`),
  CONSTRAINT `chitietsuachua_ibfk_1` FOREIGN KEY (`ID_phieu_sua_chua`) REFERENCES `phieusuachua` (`ID_phieu_sua_chua`),
  CONSTRAINT `chitietsuachua_ibfk_2` FOREIGN KEY (`ID_dich_vu`) REFERENCES `dichvu` (`ID_dich_vu`),
  CONSTRAINT `chitietsuachua_ibfk_3` FOREIGN KEY (`ID_linh_kien`) REFERENCES `linhkien` (`ID_linh_kien`)
) ENGINE=InnoDB AUTO_INCREMENT=51 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `chitietsuachua`
--

LOCK TABLES `chitietsuachua` WRITE;
/*!40000 ALTER TABLE `chitietsuachua` DISABLE KEYS */;
INSERT INTO `chitietsuachua` VALUES (1,1,1,1,2,1000000),(2,1,2,2,1,800000),(3,2,3,3,3,1500000),(4,2,4,4,2,1200000),(5,3,5,5,1,500000),(6,3,6,6,1,900000),(7,4,7,7,1,400000),(8,4,8,8,2,1200000),(9,5,9,9,3,1600000),(10,5,10,10,1,700000),(11,6,11,11,2,1300000),(12,6,12,12,1,800000),(13,7,13,13,1,600000),(14,7,14,14,2,1400000),(15,8,15,15,1,300000),(16,8,16,16,2,1100000),(17,9,17,17,1,250000),(18,9,18,18,3,1350000),(19,10,19,19,2,900000),(20,10,20,20,1,650000),(21,11,21,21,1,450000),(22,11,22,22,3,1700000),(23,12,23,23,2,1000000),(24,12,24,24,1,600000),(25,13,25,25,2,1200000),(26,13,26,26,1,500000),(27,14,27,27,3,1500000),(28,14,28,28,1,750000),(29,15,29,29,1,300000),(30,15,30,30,2,1100000),(31,16,31,31,1,200000),(32,16,32,32,1,950000),(33,17,33,33,2,1050000),(34,17,34,34,1,600000),(35,18,35,35,1,550000),(36,18,36,36,2,1400000),(37,19,37,37,3,1600000),(38,19,38,38,2,1200000),(39,20,39,39,1,700000),(40,20,40,40,3,1800000),(41,21,41,41,1,300000),(42,21,42,42,2,1000000),(43,22,43,43,1,550000),(44,22,44,44,2,1400000),(45,23,45,45,1,650000),(46,23,46,46,3,1900000),(47,24,47,47,1,400000),(48,24,48,48,2,1200000),(49,25,49,49,3,1600000),(50,25,50,50,1,550000);
/*!40000 ALTER TABLE `chitietsuachua` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `danhmucloi`
--

DROP TABLE IF EXISTS `danhmucloi`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `danhmucloi` (
  `ID_loi` int NOT NULL AUTO_INCREMENT,
  `Mo_ta_loi` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`ID_loi`)
) ENGINE=InnoDB AUTO_INCREMENT=51 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `danhmucloi`
--

LOCK TABLES `danhmucloi` WRITE;
/*!40000 ALTER TABLE `danhmucloi` DISABLE KEYS */;
INSERT INTO `danhmucloi` VALUES (1,'Màn hình b? h?ng'),(2,'Không lên ngu?n'),(3,'Loa không ho?t ??ng'),(4,'Camera b? m?'),(5,'Không k?t n?i ???c Wi-Fi'),(6,'Pin b? chai'),(7,'Bàn phím không nh?n phím'),(8,'Máy b? treo khi kh?i ??ng'),(9,'Máy t? ??ng kh?i ??ng l?i'),(10,'? c?ng không nh?n di?n'),(11,'C?ng USB b? h?ng'),(12,'S?c không vào ?i?n'),(13,'Màn hình xu?t hi?n ???ng k?'),(14,'Loa b? rè'),(15,'Nút ngu?n b? h?ng'),(16,'Thi?t b? quá nóng khi s? d?ng'),(17,'Không nh?n ???c tín hi?u m?ng'),(18,'H? ?i?u hành không kh?i ??ng ???c'),(19,'?ng d?ng b? d?ng ??t ng?t'),(20,'?èn LED không ho?t ??ng'),(21,'Th?i gian s?c lâu h?n bình th??ng'),(22,'Màn hình b? v?'),(23,'C?m ?ng không ho?t ??ng'),(24,'Không k?t n?i ???c Bluetooth'),(25,'Âm thanh b? méo'),(26,'L?i cài ??t ph?n m?m'),(27,'???ng truy?n m?ng ch?m'),(28,'Pin không s?c ???c ??y'),(29,'Màn hình nh?p nháy'),(30,'Máy b? ??ng khi s? d?ng'),(31,'Không nh?n di?n ???c th? nh?'),(32,'K?t n?i HDMI không ho?t ??ng'),(33,'Micro không thu âm ???c'),(34,'Th?i gian s? d?ng pin quá ng?n'),(35,'Màn hình có ?i?m ch?t'),(36,'H? th?ng qu?t không ho?t ??ng'),(37,'Ch?t l??ng hình ?nh kém'),(38,'M?t tín hi?u GPS'),(39,'Thi?t b? không nh?n di?n ???c sim'),(40,'L?i driver ph?n c?ng'),(41,'L?i giao di?n ng??i dùng'),(42,'Màn hình b? ng? màu'),(43,'Không nh?n di?n ???c thi?t b? ngo?i vi'),(44,'L?i c?m bi?n vân tay'),(45,'?ng d?ng không t??ng thích'),(46,'L?i update h? ?i?u hành'),(47,'C?ng m?ng LAN không ho?t ??ng'),(48,'C?m bi?n ánh sáng không ho?t ??ng'),(49,'T?c ?? x? lý ch?m'),(50,'L?i ph?n c?ng không xác ??nh');
/*!40000 ALTER TABLE `danhmucloi` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `dichvu`
--

DROP TABLE IF EXISTS `dichvu`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `dichvu` (
  `ID_dich_vu` int NOT NULL AUTO_INCREMENT,
  `Ten_dich_vu` varchar(255) DEFAULT NULL,
  `Gia` float DEFAULT NULL,
  PRIMARY KEY (`ID_dich_vu`)
) ENGINE=InnoDB AUTO_INCREMENT=51 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `dichvu`
--

LOCK TABLES `dichvu` WRITE;
/*!40000 ALTER TABLE `dichvu` DISABLE KEYS */;
INSERT INTO `dichvu` VALUES (1,'S?a ch?a ph?n c?ng',500000),(2,'Cài ??t h? ?i?u hành',300000),(3,'Nâng c?p RAM',400000),(4,'L?p ráp máy tính',600000),(5,'Cài ??t ph?n m?m di?t virus',200000),(6,'Thay th? ? c?ng',800000),(7,'D?n d?p máy tính',150000),(8,'Cài ??t ph?n m?m v?n phòng',100000),(9,'S?a ch?a ngu?n máy tính',450000),(10,'Thay pin laptop',300000),(11,'Nâng c?p card ?? h?a',1500000),(12,'S?a ch?a bo m?ch ch?',1200000),(13,'L?p ráp h? th?ng m?ng',700000),(14,'Cài ??t ?ng d?ng ?? h?a',500000),(15,'S?a ch?a màn hình',900000),(16,'Cài ??t driver máy in',250000),(17,'Ki?m tra và b?o trì máy tính',350000),(18,'Cài ??t máy ch?',1500000),(19,'S?a ch?a máy in',400000),(20,'Thay màn hình LCD',1200000),(21,'Khôi ph?c d? li?u',1000000),(22,'Cài ??t ph?n m?m k? toán',800000),(23,'S?a ch?a bàn phím',200000),(24,'S?a ch?a chu?t',100000),(25,'Cài ??t h? th?ng an ninh',1200000),(26,'Thay th? qu?t t?n nhi?t',300000),(27,'Cài ??t ph?n m?m ?? h?a',600000),(28,'Ch?m sóc máy tính ??nh k?',250000),(29,'Thay th? RAM laptop',600000),(30,'L?p ráp máy tính gaming',1000000),(31,'Cài ??t ph?n m?m antivirus',250000),(32,'S?a ch?a ngu?n PSU',550000),(33,'Thay ? c?ng SSD',700000),(34,'Thay pin CMOS',100000),(35,'Cài ??t Windows Server',1500000),(36,'T? v?n mua linh ki?n',300000),(37,'Cài ??t ph?n m?m CAD',800000),(38,'S?a ch?a VGA',1200000),(39,'Cài ??t ph?n m?m qu?n lý',600000),(40,'B?o trì máy tính v?n phòng',400000),(41,'S?a ch?a laptop',1000000),(42,'Cài ??t ph?n m?m di?t malware',250000),(43,'Thay dây ngu?n máy tính',150000),(44,'Khôi ph?c h? ?i?u hành',500000),(45,'Thay th? bàn phím laptop',350000),(46,'S?a ch?a webcam',200000),(47,'Cài ??t ph?n m?m game',150000),(48,'Cài ??t h? th?ng m?ng không dây',800000),(49,'Nâng c?p ? c?ng',500000),(50,'S?a ch?a màn hình laptop',900000);
/*!40000 ALTER TABLE `dichvu` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `hoadon`
--

DROP TABLE IF EXISTS `hoadon`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `hoadon` (
  `ID_hoa_don` int NOT NULL AUTO_INCREMENT,
  `ID_phieu_sua_chua` int DEFAULT NULL,
  `Ngay_lap` date DEFAULT NULL,
  `Tong_tien` float DEFAULT NULL,
  `Phuong_thuc_thanh_toan` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`ID_hoa_don`),
  KEY `ID_phieu_sua_chua` (`ID_phieu_sua_chua`),
  CONSTRAINT `hoadon_ibfk_1` FOREIGN KEY (`ID_phieu_sua_chua`) REFERENCES `phieusuachua` (`ID_phieu_sua_chua`)
) ENGINE=InnoDB AUTO_INCREMENT=51 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `hoadon`
--

LOCK TABLES `hoadon` WRITE;
/*!40000 ALTER TABLE `hoadon` DISABLE KEYS */;
INSERT INTO `hoadon` VALUES (1,1,'2024-01-02',1500000,'Ti?n m?t'),(2,2,'2024-01-03',2500000,'Chuy?n kho?n'),(3,3,'2024-01-04',1200000,'Ti?n m?t'),(4,4,'2024-01-05',2000000,'Chuy?n kho?n'),(5,5,'2024-01-06',1800000,'Ti?n m?t'),(6,6,'2024-01-07',3000000,'Chuy?n kho?n'),(7,7,'2024-01-08',500000,'Ti?n m?t'),(8,8,'2024-01-09',1500000,'Chuy?n kho?n'),(9,9,'2024-01-10',2500000,'Ti?n m?t'),(10,10,'2024-01-11',1000000,'Chuy?n kho?n'),(11,11,'2024-01-12',2200000,'Ti?n m?t'),(12,12,'2024-01-13',2700000,'Chuy?n kho?n'),(13,13,'2024-01-14',3300000,'Ti?n m?t'),(14,14,'2024-01-15',400000,'Chuy?n kho?n'),(15,15,'2024-01-16',1600000,'Ti?n m?t'),(16,16,'2024-01-17',2800000,'Chuy?n kho?n'),(17,17,'2024-01-18',4500000,'Ti?n m?t'),(18,18,'2024-01-19',700000,'Chuy?n kho?n'),(19,19,'2024-01-20',900000,'Ti?n m?t'),(20,20,'2024-01-21',1000000,'Chuy?n kho?n'),(21,21,'2024-01-22',1500000,'Ti?n m?t'),(22,22,'2024-01-23',1100000,'Chuy?n kho?n'),(23,23,'2024-01-24',2600000,'Ti?n m?t'),(24,24,'2024-01-25',3200000,'Chuy?n kho?n'),(25,25,'2024-01-26',1800000,'Ti?n m?t'),(26,26,'2024-01-27',1400000,'Chuy?n kho?n'),(27,27,'2024-01-28',4200000,'Ti?n m?t'),(28,28,'2024-01-29',3500000,'Chuy?n kho?n'),(29,29,'2024-01-30',2300000,'Ti?n m?t'),(30,30,'2024-01-31',250000,'Chuy?n kho?n'),(31,31,'2024-02-01',600000,'Ti?n m?t'),(32,32,'2024-02-02',4000000,'Chuy?n kho?n'),(33,33,'2024-02-03',1300000,'Ti?n m?t'),(34,34,'2024-02-04',1900000,'Chuy?n kho?n'),(35,35,'2024-02-05',2900000,'Ti?n m?t'),(36,36,'2024-02-06',800000,'Chuy?n kho?n'),(37,37,'2024-02-07',1200000,'Ti?n m?t'),(38,38,'2024-02-08',2500000,'Chuy?n kho?n'),(39,39,'2024-02-09',300000,'Ti?n m?t'),(40,40,'2024-02-10',2400000,'Chuy?n kho?n'),(41,41,'2024-02-11',2100000,'Ti?n m?t'),(42,42,'2024-02-12',900000,'Chuy?n kho?n'),(43,43,'2024-02-13',1000000,'Ti?n m?t'),(44,44,'2024-02-14',500000,'Chuy?n kho?n'),(45,45,'2024-02-15',4500000,'Ti?n m?t'),(46,46,'2024-02-16',1100000,'Chuy?n kho?n'),(47,47,'2024-02-17',900000,'Ti?n m?t'),(48,48,'2024-02-18',1300000,'Chuy?n kho?n'),(49,49,'2024-02-19',1700000,'Ti?n m?t'),(50,50,'2024-02-20',2800000,'Chuy?n kho?n');
/*!40000 ALTER TABLE `hoadon` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `khachhang`
--

DROP TABLE IF EXISTS `khachhang`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `khachhang` (
  `ID_khach_hang` int NOT NULL AUTO_INCREMENT,
  `Ho_ten` varchar(255) DEFAULT NULL,
  `So_dien_thoai` varchar(20) DEFAULT NULL,
  `Email` varchar(255) DEFAULT NULL,
  `Dia_chi` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`ID_khach_hang`)
) ENGINE=InnoDB AUTO_INCREMENT=51 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `khachhang`
--

LOCK TABLES `khachhang` WRITE;
/*!40000 ALTER TABLE `khachhang` DISABLE KEYS */;
INSERT INTO `khachhang` VALUES (1,'Nguy?n V?n An','0987654321','an.nguyen@example.com','123 ???ng A, Hà N?i'),(2,'Tr?n Th? Bích','0912345678','bich.tran@example.com','456 ???ng B, TP HCM'),(3,'Lê V?n C??ng','0901234567','cuong.le@example.com','789 ???ng C, ?à N?ng'),(4,'Ph?m Minh D?ng','0934567890','dung.pham@example.com','12 ???ng D, H?i Phòng'),(5,'Hoàng Th? Hà','0945678901','ha.hoang@example.com','34 ???ng E, C?n Th?'),(6,'V? Thanh H?ng','0976789012','hang.vu@example.com','56 ???ng F, Hà N?i'),(7,'Ph?m V?n Hùng','0913456789','hung.pham@example.com','78 ???ng G, TP HCM'),(8,'Ngô Th? Lan','0924567890','lan.ngo@example.com','90 ???ng H, ?à N?ng'),(9,'??ng V?n Lâm','0935678901','lam.dang@example.com','123 ???ng I, H?i Phòng'),(10,'Tr?nh Th? Mai','0946789012','mai.trinh@example.com','456 ???ng J, C?n Th?'),(11,'Nguy?n V?n Minh','0957890123','minh.nguyen@example.com','789 ???ng K, Hà N?i'),(12,'Tr?n Th? Nga','0968901234','nga.tran@example.com','12 ???ng L, TP HCM'),(13,'Ph?m V?n Nam','0979012345','nam.pham@example.com','34 ???ng M, ?à N?ng'),(14,'Lê Th? Oanh','0980123456','oanh.le@example.com','56 ???ng N, H?i Phòng'),(15,'Hoàng V?n Phát','0991234567','phat.hoang@example.com','78 ???ng O, C?n Th?'),(16,'Nguy?n Th? Qu?nh','0912345670','quynh.nguyen@example.com','90 ???ng P, Hà N?i'),(17,'Ph?m V?n S?n','0923456781','son.pham@example.com','123 ???ng Q, TP HCM'),(18,'Tr?n Th? Th?o','0934567892','thao.tran@example.com','456 ???ng R, ?à N?ng'),(19,'Lê V?n Tu?n','0945678903','tuan.le@example.com','789 ???ng S, H?i Phòng'),(20,'Ngô Th? Uyên','0956789014','uyen.ngo@example.com','12 ???ng T, C?n Th?'),(21,'Hoàng V?n Vinh','0967890125','vinh.hoang@example.com','34 ???ng U, Hà N?i'),(22,'Nguy?n Th? Y?n','0978901236','yen.nguyen@example.com','56 ???ng V, TP HCM'),(23,'Ph?m V?n ??t','0989012347','dat.pham@example.com','78 ???ng W, ?à N?ng'),(24,'Tr?n Th? Xuân','0910123458','xuan.tran@example.com','90 ???ng X, H?i Phòng'),(25,'Lê V?n Anh','0921234569','anh.le@example.com','123 ???ng Y, C?n Th?'),(26,'Hoàng Th? Bình','0932345670','binh.hoang@example.com','456 ???ng Z, Hà N?i'),(27,'Nguy?n V?n C??ng','0943456781','cuong.nguyen@example.com','789 ???ng AA, TP HCM'),(28,'Ph?m Th? Dung','0954567892','dung.pham@example.com','12 ???ng BB, ?à N?ng'),(29,'Tr?n V?n H?i','0965678903','hai.tran@example.com','34 ???ng CC, H?i Phòng'),(30,'Lê Th? H?ng','0976789014','hong.le@example.com','56 ???ng DD, C?n Th?'),(31,'Hoàng V?n Khánh','0987890125','khanh.hoang@example.com','78 ???ng EE, Hà N?i'),(32,'Nguy?n Th? Lan','0918901236','lan.nguyen@example.com','90 ???ng FF, TP HCM'),(33,'Ph?m V?n L?c','0929012347','loc.pham@example.com','123 ???ng GG, ?à N?ng'),(34,'Tr?n Th? Lý','0930123458','ly.tran@example.com','456 ???ng HH, H?i Phòng'),(35,'Lê V?n M?nh','0941234569','manh.le@example.com','789 ???ng II, C?n Th?'),(36,'Nguy?n Th? Nhung','0952345670','nhung.nguyen@example.com','12 ???ng JJ, Hà N?i'),(37,'Ph?m V?n Phúc','0963456781','phuc.pham@example.com','34 ???ng KK, TP HCM'),(38,'Tr?n Th? Quang','0974567892','quang.tran@example.com','56 ???ng LL, ?à N?ng'),(39,'Lê V?n Thành','0985678903','thanh.le@example.com','78 ???ng MM, H?i Phòng'),(40,'Hoàng Th? Tuy?t','0916789014','tuyet.hoang@example.com','90 ???ng NN, C?n Th?'),(41,'Nguy?n V?n Vi?t','0927890125','viet.nguyen@example.com','123 ???ng OO, Hà N?i'),(42,'Ph?m Th? Xuân','0938901236','xuan.pham@example.com','456 ???ng PP, TP HCM'),(43,'Tr?n V?n Yên','0949012347','yen.tran@example.com','789 ???ng QQ, ?à N?ng'),(44,'Lê Th? Ánh','0950123458','anh.le@example.com','12 ???ng RR, H?i Phòng'),(45,'Hoàng V?n B?o','0961234569','bao.hoang@example.com','34 ???ng SS, C?n Th?'),(46,'Nguy?n Th? Châu','0972345670','chau.nguyen@example.com','56 ???ng TT, Hà N?i'),(47,'Ph?m V?n Duy','0983456781','duy.pham@example.com','78 ???ng UU, TP HCM'),(48,'Tr?n Th? Giang','0914567892','giang.tran@example.com','90 ???ng VV, ?à N?ng'),(49,'Lê V?n Hoàng','0925678903','hoang.le@example.com','123 ???ng WW, H?i Phòng'),(50,'Hoàng Th? Khuê','0936789014','khue.hoang@example.com','456 ???ng XX, C?n Th?');
/*!40000 ALTER TABLE `khachhang` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `linhkien`
--

DROP TABLE IF EXISTS `linhkien`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `linhkien` (
  `ID_linh_kien` int NOT NULL AUTO_INCREMENT,
  `Ten_linh_kien` varchar(255) DEFAULT NULL,
  `Loai_linh_kien` varchar(255) DEFAULT NULL,
  `Gia_nhap` float DEFAULT NULL,
  `Gia_ban` float DEFAULT NULL,
  `So_luong_ton_kho` int DEFAULT NULL,
  PRIMARY KEY (`ID_linh_kien`)
) ENGINE=InnoDB AUTO_INCREMENT=51 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `linhkien`
--

LOCK TABLES `linhkien` WRITE;
/*!40000 ALTER TABLE `linhkien` DISABLE KEYS */;
INSERT INTO `linhkien` VALUES (1,'Mainboard ASUS ROG','Mainboard',3500000,4500000,20),(2,'RAM Kingston 8GB','RAM',600000,750000,35),(3,'SSD Samsung 500GB','SSD',1500000,1800000,50),(4,'CPU Intel i5 12400F','CPU',4000000,5200000,15),(5,'Ngu?n Corsair 650W','Ngu?n máy tính',1300000,1600000,25),(6,'VGA NVIDIA RTX 3060','Card ?? h?a',8500000,9700000,10),(7,'? c?ng HDD Seagate 1TB','HDD',1200000,1400000,40),(8,'T?n nhi?t CoolerMaster','T?n nhi?t',500000,650000,30),(9,'Case máy tính Xigmatek','Case',700000,900000,20),(10,'Bàn phím Logitech K120','Ph? ki?n',200000,250000,60),(11,'Chu?t Razer DeathAdder','Ph? ki?n',800000,1000000,45),(12,'Màn hình Dell 24\"','Màn hình',3500000,4200000,18),(13,'Tai nghe SteelSeries Arctis','Ph? ki?n',1800000,2200000,12),(14,'Webcam Logitech C920','Ph? ki?n',1000000,1300000,25),(15,'Card m?ng TP-Link','Ph? ki?n',200000,300000,50),(16,'Laptop pin Dell 60Wh','Pin laptop',800000,1000000,10),(17,'Adapter s?c Lenovo','S?c laptop',500000,700000,20),(18,'Pin CMOS CR2032','Pin CMOS',50000,70000,100),(19,'Qu?t t?n nhi?t 120mm','T?n nhi?t',100000,150000,50),(20,'K?p gi? cáp CoolerMaster','Ph? ki?n',50000,80000,75),(21,'Dây ngu?n máy tính','Cáp',100000,150000,60),(22,'?èn LED RGB Corsair','Ph? ki?n',250000,350000,40),(23,'B? chia USB 3.0','Ph? ki?n',200000,300000,50),(24,'Module WiFi Intel','Ph? ki?n',350000,500000,15),(25,'B? nâng c?p RAM laptop','RAM',750000,1000000,20),(26,'T?n nhi?t n??c NZXT','T?n nhi?t',2500000,3000000,8),(27,'? c?ng SSD NVMe 1TB','SSD',2200000,2700000,25),(28,'Mainboard MSI MAG','Mainboard',3200000,4000000,10),(29,'RAM Corsair 16GB','RAM',1400000,1800000,30),(30,'CPU AMD Ryzen 7 5800X','CPU',7000000,8500000,12),(31,'Ngu?n Seasonic 750W','Ngu?n máy tính',1900000,2500000,20),(32,'Card ?? h?a AMD RX 6700 XT','Card ?? h?a',9500000,12000000,10),(33,'Màn hình LG UltraGear 27\"','Màn hình',7000000,8500000,15),(34,'Laptop Pin HP 45Wh','Pin laptop',900000,1200000,8),(35,'Adapter s?c Asus','S?c laptop',600000,800000,15),(36,'? c?ng HDD Western Digital 2TB','HDD',2200000,2700000,10),(37,'T?n nhi?t khí Deepcool','T?n nhi?t',400000,550000,20),(38,'Case máy tính NZXT','Case',1800000,2200000,10),(39,'Webcam Razer Kiyo','Ph? ki?n',2200000,2600000,5),(40,'Tai nghe HyperX Cloud II','Ph? ki?n',2300000,2800000,15),(41,'Chu?t Logitech MX Master','Ph? ki?n',1700000,2000000,20),(42,'Dây HDMI 2.0','Cáp',150000,200000,50),(43,'??u chuy?n USB-C sang HDMI','Ph? ki?n',300000,450000,30),(44,'Pin d? phòng RAVPower 10000mAh','Ph? ki?n',800000,1000000,15),(45,'B? v? sinh laptop','Ph? ki?n',150000,200000,60),(46,'?èn bàn LED Xiaomi','Ph? ki?n',500000,700000,25),(47,'Th? nh? Sandisk 128GB','Th? nh?',400000,550000,30),(48,'? c?ng di ??ng Seagate 5TB','HDD',3500000,4000000,12),(49,'Màn hình Samsung Smart Monitor','Màn hình',8500000,10000000,8),(50,'Bàn phím c? Keychron K6','Ph? ki?n',2000000,2400000,25);
/*!40000 ALTER TABLE `linhkien` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `nhanvien`
--

DROP TABLE IF EXISTS `nhanvien`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `nhanvien` (
  `ID_nhan_vien` int NOT NULL AUTO_INCREMENT,
  `Ho_ten` varchar(255) DEFAULT NULL,
  `Vai_tro` varchar(100) DEFAULT NULL,
  `Ten_dang_nhap` varchar(100) DEFAULT NULL,
  `Mat_khau` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`ID_nhan_vien`)
) ENGINE=InnoDB AUTO_INCREMENT=51 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `nhanvien`
--

LOCK TABLES `nhanvien` WRITE;
/*!40000 ALTER TABLE `nhanvien` DISABLE KEYS */;
INSERT INTO `nhanvien` VALUES (1,'Norma Fisher','Qu?n tr?','tammy76','r%7_LszReW'),(2,'Brian Hamilton','Nhân viên','tammywoods','t(&4eBYXnz'),(3,'Robert Thomas','Nhân viên','udavis','SeS7RDjVK('),(4,'Collin Lopez','Khách hàng','thomas12','uSGe0CowV#'),(5,'Louis Tucker','Nhân viên','megan30','wDCm*_d$+4'),(6,'Colin Greer','Khách hàng','myersmitchell','2@f0TacSXn'),(7,'Antonio Mcdonald','Qu?n tr?','lyonspeter','%tXbx%cpD5'),(8,'Jason Carroll','Khách hàng','deborah64','L^8SWiaXb#'),(9,'Sandra Miller','Khách hàng','hollymoore','qUMHdIbw$7'),(10,'Stacey Simpson','Khách hàng','mary06','nc@8U!@hy$'),(11,'William Garcia','Qu?n tr?','bburton','(6amZz+o%7'),(12,'Amanda Curry','Khách hàng','djoseph','1F6_LrF&j_'),(13,'Joshua Carter','Nhân viên','dcross','%2CI*tQxyD'),(14,'Nicholas Kline','Khách hàng','courtneybennett','&_%1HCzOVc'),(15,'Debbie Waters MD','Nhân viên','danny08','H33w3_DpS*'),(16,'Jenny Boyd','Khách hàng','martha73','H9sm#_7a(V'),(17,'Carlos Turner','Nhân viên','krivera','GR#&LQq^#7'),(18,'Karen Gibbs','Nhân viên','olawson','AU!0XfjGG0'),(19,'Andrew Butler','Qu?n tr?','mwu','+1IVGwM++X'),(20,'Ricardo Henry','Khách hàng','bishoptanner','d59UwG9h_y'),(21,'Jill Sherman','Qu?n tr?','okelly','60QUB4pr@P'),(22,'Steven Henderson','Qu?n tr?','wallsrobert','@#6Y#exf^^'),(23,'Andrea Barry','Qu?n tr?','aaronhopkins','9dv+1XNa7#'),(24,'Shawn Tran','Qu?n tr?','jack11','(f)4P5JFb9'),(25,'Bonnie Evans','Nhân viên','jyang','E)YZ6J!usK'),(26,'Rebecca Hill','Khách hàng','lauragriffin','&6LY_MZn32'),(27,'Randy Fuller','Nhân viên','rogerpotter','S@Y@7Y!hre'),(28,'Paul Stout','Nhân viên','johnsonlaura','R6u089Kd%R'),(29,'Mark Moore','Nhân viên','jamesbrittany','#MIVdja%A8'),(30,'Stephen Smith','Qu?n tr?','mcdanielchristopher','$X+qd6Al9*'),(31,'Matthew Mcdaniel','Qu?n tr?','sethfletcher','(5kElGg2vV'),(32,'Heidi Paul','Qu?n tr?','jesseevans','jrI@8YZjgJ'),(33,'Andrew Martin','Khách hàng','robertsadrian','@HuLVhrk6L'),(34,'Jacob Clark','Nhân viên','jacob34','p_D4$vJqf$'),(35,'Preston Gutierrez','Khách hàng','scottjones','#1O8YvBm&9'),(36,'Julia Walters','Nhân viên','jesse19','I4rF!xJ$+1'),(37,'Connie Decker','Nhân viên','calvinparker','N3LuPFYm^+'),(38,'Patricia Hudson','Nhân viên','joeanderson','VY6*nLEt$4'),(39,'Angela Taylor','Qu?n tr?','uwarner','gfxDKBa7%6'),(40,'Brittany Johnson','Nhân viên','johnsonbrady','$b_uC_ba5k'),(41,'Nancy Parks','Khách hàng','kmalone','@fMQg_Co66'),(42,'Sean Garcia','Nhân viên','nmckinney','lg#u)0Ik5E'),(43,'Alexis Moreno','Nhân viên','andrea08','#H(8Ivz6)e'),(44,'Ruben King','Khách hàng','knightmark','Rq0q$9Vx$+'),(45,'Victoria Smith','Qu?n tr?','ashleyramos','t0X7X^v8^p'),(46,'Kimberly Cruz','Khách hàng','sbaker','87RBD6Yw!!'),(47,'Kristina Jenkins','Nhân viên','rachelcox','Y3gUr8vl#L'),(48,'Thomas Reilly','Khách hàng','qshepard','&#!6iTjkG5'),(49,'Beth Page','Nhân viên','lynn67','TD(22Bcuov'),(50,'Charles Hernandez','Khách hàng','william22','f7WQuddG#l');
/*!40000 ALTER TABLE `nhanvien` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `nhanvien_quyen`
--

DROP TABLE IF EXISTS `nhanvien_quyen`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `nhanvien_quyen` (
  `ID_nhan_vien` int DEFAULT NULL,
  `ID_quyen` int DEFAULT NULL,
  KEY `ID_nhan_vien` (`ID_nhan_vien`),
  KEY `ID_quyen` (`ID_quyen`),
  CONSTRAINT `nhanvien_quyen_ibfk_1` FOREIGN KEY (`ID_nhan_vien`) REFERENCES `nhanvien` (`ID_nhan_vien`),
  CONSTRAINT `nhanvien_quyen_ibfk_2` FOREIGN KEY (`ID_quyen`) REFERENCES `quyen` (`ID_quyen`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `nhanvien_quyen`
--

LOCK TABLES `nhanvien_quyen` WRITE;
/*!40000 ALTER TABLE `nhanvien_quyen` DISABLE KEYS */;
INSERT INTO `nhanvien_quyen` VALUES (1,1),(2,2),(3,3),(4,1),(5,2),(6,3),(7,1),(8,2),(9,3),(10,1),(11,2),(12,3),(13,1),(14,2),(15,3),(16,1),(17,2),(18,3),(19,1),(20,2),(21,3),(22,1),(23,2),(24,3),(25,1),(26,2),(27,3),(28,1),(29,2),(30,3),(31,1),(32,2),(33,3),(34,1),(35,2),(36,3),(37,1),(38,2),(39,3),(40,1),(41,2),(42,3),(43,1),(44,2),(45,3),(46,1),(47,2),(48,3),(49,1),(50,2);
/*!40000 ALTER TABLE `nhanvien_quyen` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `phieusuachua`
--

DROP TABLE IF EXISTS `phieusuachua`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `phieusuachua` (
  `ID_phieu_sua_chua` int NOT NULL AUTO_INCREMENT,
  `Ngay_tiep_nhan` date DEFAULT NULL,
  `Mo_ta_loi` varchar(255) DEFAULT NULL,
  `Tinh_trang` varchar(100) DEFAULT NULL,
  `ID_phieu_tiep_nhan` int DEFAULT NULL,
  PRIMARY KEY (`ID_phieu_sua_chua`),
  KEY `ID_phieu_tiep_nhan` (`ID_phieu_tiep_nhan`),
  CONSTRAINT `phieusuachua_ibfk_1` FOREIGN KEY (`ID_phieu_tiep_nhan`) REFERENCES `phieutiepnhanthietbi` (`ID_phieu_tiep_nhan`)
) ENGINE=InnoDB AUTO_INCREMENT=51 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `phieusuachua`
--

LOCK TABLES `phieusuachua` WRITE;
/*!40000 ALTER TABLE `phieusuachua` DISABLE KEYS */;
INSERT INTO `phieusuachua` VALUES (1,'2024-01-01','Không kh?i ??ng ???c','?ang x? lý',1),(2,'2024-01-02','Màn hình không hi?n th?','?ã hoàn thành',2),(3,'2024-01-03','Loa không ho?t ??ng','?ang x? lý',3),(4,'2024-01-04','Bàn phím b? k?t','?ã hoàn thành',4),(5,'2024-01-05','Pin s?c không vào','?ang x? lý',5),(6,'2024-01-06','Nhi?t ?? máy quá cao','?ã hoàn thành',6),(7,'2024-01-07','? c?ng không nh?n','?ang x? lý',7),(8,'2024-01-08','Không nh?n thi?t b? USB','?ã hoàn thành',8),(9,'2024-01-09','H? ?i?u hành không kh?i ??ng','?ang x? lý',9),(10,'2024-01-10','K?t n?i WiFi không ?n ??nh','?ã hoàn thành',10),(11,'2024-01-11','C?ng HDMI không ho?t ??ng','?ang x? lý',11),(12,'2024-01-12','Qu?t gió phát ra ti?ng ?n','?ã hoàn thành',12),(13,'2024-01-13','Th?i l??ng pin gi?m nhanh','?ang x? lý',13),(14,'2024-01-14','Máy không nh?n th? nh?','?ã hoàn thành',14),(15,'2024-01-15','Camera không ho?t ??ng','?ang x? lý',15),(16,'2024-01-16','Máy kh?i ??ng l?i liên t?c','?ã hoàn thành',16),(17,'2024-01-17','Máy b? treo khi kh?i ??ng','?ang x? lý',17),(18,'2024-01-18','Màn hình b? v?','?ã hoàn thành',18),(19,'2024-01-19','?èn bàn phím không sáng','?ang x? lý',19),(20,'2024-01-20','Máy không nh?n sim','?ã hoàn thành',20),(21,'2024-01-21','?ng d?ng b? l?i','?ang x? lý',21),(22,'2024-01-22','Ph?n m?m không t??ng thích','?ã hoàn thành',22),(23,'2024-01-23','Màn hình hi?n th? b? s?c','?ang x? lý',23),(24,'2024-01-24','C?ng s?c b? l?ng','?ã hoàn thành',24),(25,'2024-01-25','Máy không nh?n tai nghe','?ang x? lý',25),(26,'2024-01-26','M?t âm thanh trong video','?ã hoàn thành',26),(27,'2024-01-27','Không th? cài ??t ph?n m?m','?ang x? lý',27),(28,'2024-01-28','H? th?ng b? ch?m','?ã hoàn thành',28),(29,'2024-01-29','? c?ng b? ??y không rõ lý do','?ang x? lý',29),(30,'2024-01-30','Máy b? nhi?m virus','?ã hoàn thành',30),(31,'2024-01-31','Th? nh? không ??c ???c','?ang x? lý',31),(32,'2024-02-01','C?m ?ng không ho?t ??ng','?ã hoàn thành',32),(33,'2024-02-02','Phím ngu?n b? li?t','?ang x? lý',33),(34,'2024-02-03','?ng d?ng b? treo','?ã hoàn thành',34),(35,'2024-02-04','Máy b? nóng quá m?c','?ang x? lý',35),(36,'2024-02-05','Không nh?n k?t n?i Bluetooth','?ã hoàn thành',36),(37,'2024-02-06','Màn hình không sáng','?ang x? lý',37),(38,'2024-02-07','Không th? truy c?p m?ng','?ã hoàn thành',38),(39,'2024-02-08','L?i h? ?i?u hành','?ang x? lý',39),(40,'2024-02-09','Máy không t?t ???c','?ã hoàn thành',40),(41,'2024-02-10','?ng d?ng kh?i ch?y ch?m','?ang x? lý',41),(42,'2024-02-11','Máy không nh?n ? CD/DVD','?ã hoàn thành',42),(43,'2024-02-12','Camera không l?y nét','?ang x? lý',43),(44,'2024-02-13','?èn báo ngu?n không sáng','?ã hoàn thành',44),(45,'2024-02-14','Màn hình nh?p nháy','?ang x? lý',45),(46,'2024-02-15','Không th? kh?i ??ng l?i máy','?ã hoàn thành',46),(47,'2024-02-16','D? li?u b? m?t không rõ lý do','?ang x? lý',47),(48,'2024-02-17','Máy không nh?n chu?t','?ã hoàn thành',48),(49,'2024-02-18','C?ng Ethernet không ho?t ??ng','?ang x? lý',49),(50,'2024-02-19','B? nh? RAM b? l?i','?ã hoàn thành',50);
/*!40000 ALTER TABLE `phieusuachua` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `phieusuachua_thongtinloi`
--

DROP TABLE IF EXISTS `phieusuachua_thongtinloi`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `phieusuachua_thongtinloi` (
  `ID_phieu_sua_chua` int DEFAULT NULL,
  `ID_loi` int DEFAULT NULL,
  KEY `ID_phieu_sua_chua` (`ID_phieu_sua_chua`),
  KEY `ID_loi` (`ID_loi`),
  CONSTRAINT `phieusuachua_thongtinloi_ibfk_1` FOREIGN KEY (`ID_phieu_sua_chua`) REFERENCES `phieusuachua` (`ID_phieu_sua_chua`),
  CONSTRAINT `phieusuachua_thongtinloi_ibfk_2` FOREIGN KEY (`ID_loi`) REFERENCES `danhmucloi` (`ID_loi`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `phieusuachua_thongtinloi`
--

LOCK TABLES `phieusuachua_thongtinloi` WRITE;
/*!40000 ALTER TABLE `phieusuachua_thongtinloi` DISABLE KEYS */;
INSERT INTO `phieusuachua_thongtinloi` VALUES (1,1),(1,2),(2,3),(2,4),(3,1),(3,2),(4,5),(4,6),(5,7),(5,8),(6,9),(6,10),(7,3),(7,5),(8,2),(8,4),(9,6),(9,7),(10,8),(10,1),(11,9),(11,10),(12,2),(12,4),(13,3),(13,5),(14,6),(14,7),(15,8),(15,9),(16,10),(16,1),(17,2),(17,3),(18,4),(18,5),(19,6),(19,7),(20,8),(20,9),(21,1),(21,2),(22,3),(22,4),(23,5),(23,6),(24,7),(24,8),(25,9),(25,10),(26,1),(26,2),(27,3),(27,4),(28,5),(28,6);
/*!40000 ALTER TABLE `phieusuachua_thongtinloi` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `phieutiepnhanthietbi`
--

DROP TABLE IF EXISTS `phieutiepnhanthietbi`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `phieutiepnhanthietbi` (
  `ID_phieu_tiep_nhan` int NOT NULL AUTO_INCREMENT,
  `Ngay_tiep_nhan` date DEFAULT NULL,
  `ID_khach_hang` int DEFAULT NULL,
  `ID_thiet_bi` int DEFAULT NULL,
  `ID_nhan_vien` int DEFAULT NULL,
  PRIMARY KEY (`ID_phieu_tiep_nhan`),
  KEY `ID_khach_hang` (`ID_khach_hang`),
  KEY `ID_thiet_bi` (`ID_thiet_bi`),
  KEY `ID_nhan_vien` (`ID_nhan_vien`),
  CONSTRAINT `phieutiepnhanthietbi_ibfk_1` FOREIGN KEY (`ID_khach_hang`) REFERENCES `khachhang` (`ID_khach_hang`),
  CONSTRAINT `phieutiepnhanthietbi_ibfk_2` FOREIGN KEY (`ID_thiet_bi`) REFERENCES `thietbi` (`ID_thiet_bi`),
  CONSTRAINT `phieutiepnhanthietbi_ibfk_3` FOREIGN KEY (`ID_nhan_vien`) REFERENCES `nhanvien` (`ID_nhan_vien`)
) ENGINE=InnoDB AUTO_INCREMENT=51 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `phieutiepnhanthietbi`
--

LOCK TABLES `phieutiepnhanthietbi` WRITE;
/*!40000 ALTER TABLE `phieutiepnhanthietbi` DISABLE KEYS */;
INSERT INTO `phieutiepnhanthietbi` VALUES (1,'2024-01-01',1,1,1),(2,'2024-01-02',2,2,2),(3,'2024-01-03',3,3,3),(4,'2024-01-04',4,4,4),(5,'2024-01-05',5,5,5),(6,'2024-01-06',6,6,1),(7,'2024-01-07',7,7,2),(8,'2024-01-08',8,8,3),(9,'2024-01-09',9,9,4),(10,'2024-01-10',10,10,5),(11,'2024-01-11',11,11,1),(12,'2024-01-12',12,12,2),(13,'2024-01-13',13,13,3),(14,'2024-01-14',14,14,4),(15,'2024-01-15',15,15,5),(16,'2024-01-16',16,16,1),(17,'2024-01-17',17,17,2),(18,'2024-01-18',18,18,3),(19,'2024-01-19',19,19,4),(20,'2024-01-20',20,20,5),(21,'2024-01-21',21,21,1),(22,'2024-01-22',22,22,2),(23,'2024-01-23',23,23,3),(24,'2024-01-24',24,24,4),(25,'2024-01-25',25,25,5),(26,'2024-01-26',26,26,1),(27,'2024-01-27',27,27,2),(28,'2024-01-28',28,28,3),(29,'2024-01-29',29,29,4),(30,'2024-01-30',30,30,5),(31,'2024-01-31',31,31,1),(32,'2024-02-01',32,32,2),(33,'2024-02-02',33,33,3),(34,'2024-02-03',34,34,4),(35,'2024-02-04',35,35,5),(36,'2024-02-05',36,36,1),(37,'2024-02-06',37,37,2),(38,'2024-02-07',38,38,3),(39,'2024-02-08',39,39,4),(40,'2024-02-09',40,40,5),(41,'2024-02-10',41,41,1),(42,'2024-02-11',42,42,2),(43,'2024-02-12',43,43,3),(44,'2024-02-13',44,44,4),(45,'2024-02-14',45,45,5),(46,'2024-02-15',46,46,1),(47,'2024-02-16',47,47,2),(48,'2024-02-17',48,48,3),(49,'2024-02-18',49,49,4),(50,'2024-02-19',50,50,5);
/*!40000 ALTER TABLE `phieutiepnhanthietbi` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `quyen`
--

DROP TABLE IF EXISTS `quyen`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `quyen` (
  `ID_quyen` int NOT NULL AUTO_INCREMENT,
  `Ten_quyen` varchar(255) DEFAULT NULL,
  `Mo_ta` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`ID_quyen`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `quyen`
--

LOCK TABLES `quyen` WRITE;
/*!40000 ALTER TABLE `quyen` DISABLE KEYS */;
INSERT INTO `quyen` VALUES (1,'Qu?n tr?','Quy?n truy c?p và qu?n lý toàn b? h? th?ng'),(2,'Nhân viên','Quy?n s? d?ng các ch?c n?ng liên quan ??n nghi?p v?'),(3,'Khách hàng','Quy?n theo dõi thông tin và tr?ng thái các yêu c?u');
/*!40000 ALTER TABLE `quyen` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `thietbi`
--

DROP TABLE IF EXISTS `thietbi`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `thietbi` (
  `ID_thiet_bi` int NOT NULL AUTO_INCREMENT,
  `Hang` varchar(255) DEFAULT NULL,
  `Model` varchar(255) DEFAULT NULL,
  `Thong_tin_ky_thuat` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`ID_thiet_bi`)
) ENGINE=InnoDB AUTO_INCREMENT=51 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `thietbi`
--

LOCK TABLES `thietbi` WRITE;
/*!40000 ALTER TABLE `thietbi` DISABLE KEYS */;
INSERT INTO `thietbi` VALUES (1,'Apple','iPhone 13','128GB, A15 Bionic, OLED Display'),(2,'Samsung','Galaxy S21','256GB, Exynos 2100, AMOLED Display'),(3,'Dell','XPS 13','Intel i7, 16GB RAM, 512GB SSD'),(4,'HP','Pavilion 15','Intel i5, 8GB RAM, 256GB SSD'),(5,'Asus','ROG Strix G15','AMD Ryzen 7, 16GB RAM, 1TB SSD'),(6,'Apple','MacBook Air M2','M2 Chip, 8GB RAM, 256GB SSD'),(7,'Lenovo','ThinkPad X1','Intel i7, 16GB RAM, 512GB SSD'),(8,'Acer','Aspire 7','AMD Ryzen 5, 8GB RAM, 512GB SSD'),(9,'Microsoft','Surface Pro 7','Intel i5, 8GB RAM, 128GB SSD'),(10,'Apple','iPad Pro','256GB, M1 Chip, Liquid Retina Display'),(11,'Samsung','Galaxy Tab S8','128GB, Snapdragon 8 Gen 1, AMOLED Display'),(12,'Xiaomi','Mi 11','128GB, Snapdragon 888, AMOLED Display'),(13,'Apple','iPhone SE (2022)','64GB, A15 Bionic, Retina HD Display'),(14,'Samsung','Galaxy Z Fold 3','256GB, Snapdragon 888, Foldable Display'),(15,'Dell','Inspiron 14','Intel i3, 8GB RAM, 256GB SSD'),(16,'HP','OMEN 15','AMD Ryzen 9, 16GB RAM, 1TB SSD'),(17,'Asus','ZenBook 14','Intel i5, 8GB RAM, 512GB SSD'),(18,'Lenovo','Yoga Slim 7','AMD Ryzen 7, 16GB RAM, 1TB SSD'),(19,'Acer','Nitro 5','Intel i7, 16GB RAM, 512GB SSD'),(20,'Microsoft','Surface Laptop Go','Intel i5, 8GB RAM, 128GB SSD'),(21,'Apple','MacBook Pro 14','M1 Pro Chip, 16GB RAM, 512GB SSD'),(22,'Samsung','Galaxy Watch 4','Wear OS, Exynos W920, AMOLED Display'),(23,'Garmin','Forerunner 945','Sports Watch, GPS, 32GB Storage'),(24,'Fitbit','Charge 5','Fitness Tracker, AMOLED Display'),(25,'Huawei','Watch GT 3','HarmonyOS, 4GB Storage, AMOLED Display'),(26,'Sony','PlayStation 5','825GB SSD, Custom AMD RDNA 2 GPU'),(27,'Microsoft','Xbox Series X','1TB SSD, Custom AMD RDNA 2 GPU'),(28,'Nintendo','Switch OLED','64GB Storage, OLED Display'),(29,'LG','Gram 16','Intel i7, 16GB RAM, 1TB SSD'),(30,'Apple','iMac 24','M1 Chip, 8GB RAM, 256GB SSD'),(31,'Razer','Blade 15','Intel i7, 16GB RAM, 1TB SSD'),(32,'Google','Pixel 6','128GB, Google Tensor, AMOLED Display'),(33,'OnePlus','9 Pro','256GB, Snapdragon 888, AMOLED Display'),(34,'Realme','GT Neo 2','128GB, Snapdragon 870, AMOLED Display'),(35,'Vivo','X70 Pro','256GB, Exynos 1080, AMOLED Display'),(36,'Oppo','Find X3 Pro','256GB, Snapdragon 888, AMOLED Display'),(37,'Apple','AirPods Pro','Wireless, Noise Cancellation, H1 Chip'),(38,'Samsung','Galaxy Buds Pro','Wireless, ANC, AKG Sound'),(39,'Sony','WH-1000XM4','Wireless Headphones, ANC, LDAC Support'),(40,'Bose','QuietComfort 45','Wireless Headphones, ANC'),(41,'JBL','Charge 5','Portable Speaker, Bluetooth, Waterproof'),(42,'Marshall','Stanmore II','Wireless Speaker, Classic Design'),(43,'Google','Nest Audio','Smart Speaker, Google Assistant'),(44,'Amazon','Echo Dot (4th Gen)','Smart Speaker, Alexa'),(45,'Apple','HomePod Mini','Smart Speaker, Siri'),(46,'Dell','Alienware m15','Intel i9, 32GB RAM, 2TB SSD'),(47,'HP','Spectre x360','Intel i7, 16GB RAM, 1TB SSD'),(48,'Asus','TUF Gaming F15','Intel i5, 8GB RAM, 512GB SSD'),(49,'Lenovo','IdeaPad 5','AMD Ryzen 5, 8GB RAM, 256GB SSD'),(50,'Acer','Swift 3','Intel i5, 8GB RAM, 512GB SSD');
/*!40000 ALTER TABLE `thietbi` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-12-18 22:58:45
