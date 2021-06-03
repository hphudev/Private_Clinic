﻿CREATE DATABASE QUANLYPHONGMACHTU
USE QUANLYPHONGMACHTU

CREATE TABLE BENHNHAN
(
	MABENHNHAN NVARCHAR(7) PRIMARY KEY, 
	HOTEN NVARCHAR(50), 
	GIOITINH NVARCHAR(4), 
	NGAYSINH SMALLDATETIME CHECK (NGAYSINH <= GETDATE()), 
	DIACHI NVARCHAR(100), 
	NGAYKHAMBENH SMALLDATETIME CHECK (NGAYKHAMBENH >= GETDATE())
)

CREATE TABLE THAMSO
(
	TENTHAMSO NVARCHAR(20) PRIMARY KEY, 
	GIATRI INT
)

CREATE TABLE DONVITINH
(
	MADONVITINH NVARCHAR(5) PRIMARY KEY, 
	TENDONVITINH NVARCHAR(20)
)

CREATE TABLE THUOC
(
	MATHUOC NVARCHAR(6) PRIMARY KEY, 
	TENTHUOC NVARCHAR(50), 
	SOLUONGTON INT CHECK (SOLUONGTON >= 0), 
	DONGIANHAP INT CHECK (DONGIANHAP >= 0), 
	DONGIABAN INT, 
	MADONVITINH NVARCHAR(5), 
	TYLETINHDONGIABAN INT CHECK (TYLETINHDONGIABAN >= 100), 
	CONSTRAINT FKDONVITINH FOREIGN KEY (MADONVITINH) REFERENCES DONVITINH (MADONVITINH)
)

CREATE TABLE PHIEUNT
(
	MAPHIEUNT NVARCHAR(8) PRIMARY KEY, 
	NGAYNHAPTHUOC SMALLDATETIME CHECK (NGAYNHAPTHUOC >= GETDATE())
)

CREATE TABLE CTPHIEUNT
(
	MACTPHIEUNT NVARCHAR(10) PRIMARY KEY, 
	MAPHIEUNT NVARCHAR(8), 
	MATHUOC NVARCHAR(6), 
	SOLUONGNHAP INT CHECK (SOLUONGNHAP > 0), 
	CONSTRAINT FKPHIEUNT FOREIGN KEY (MAPHIEUNT) REFERENCES PHIEUNT (MAPHIEUNT), 
	CONSTRAINT FKTHUOCCTPHIEUNT FOREIGN KEY (MATHUOC) REFERENCES THUOC (MATHUOC)
)

CREATE TABLE BENH
(
	MABENH NVARCHAR(3) PRIMARY KEY, 
	TENBENH NVARCHAR(50)
)

CREATE TABLE PHIEUKB
(
	MAPHIEUKB NVARCHAR(8) PRIMARY KEY, 
	MABENHNHAN NVARCHAR(7), 
	TRIEUCHUNG NVARCHAR(50), 
	MABENH NVARCHAR(3), 
	CONSTRAINT FKBENHNHANPHIEUKB FOREIGN KEY (MABENHNHAN) REFERENCES BENHNHAN (MABENHNHAN), 
	CONSTRAINT FKBENH FOREIGN KEY (MABENH) REFERENCES BENH (MABENH)
)

CREATE TABLE CACHDUNG
(
	MACACHDUNG NVARCHAR(4) PRIMARY KEY, 
	TENCACHDUNG NVARCHAR(20)
)

CREATE TABLE CTPHIEUKB
(
	MACTPHIEUKB NVARCHAR(10) PRIMARY KEY, 
	MAPHIEUKB NVARCHAR(8), 
	MATHUOC NVARCHAR(6), 
	SOLUONG INT CHECK (SOLUONG > 0), 
	MACACHDUNG NVARCHAR(4), 
	TIENTHUOC INT, 
	CONSTRAINT FKPHIEUKB FOREIGN KEY (MAPHIEUKB) REFERENCES PHIEUKB (MAPHIEUKB), 
	CONSTRAINT FKTHUOCCTPHIEUKB FOREIGN KEY (MATHUOC) REFERENCES THUOC (MATHUOC), 
	CONSTRAINT FKCACHDUNG FOREIGN KEY (MACACHDUNG) REFERENCES CACHDUNG (MACACHDUNG)
)

CREATE TABLE HOADON
(
	SOHD NVARCHAR(7) PRIMARY KEY, 
	MABENHNHAN NVARCHAR(7), 
	TIENKHAM INT, 
	TONGTIENTHUOC INT, 
	CONSTRAINT FKBENHNHANHD FOREIGN KEY (MABENHNHAN) REFERENCES BENHNHAN (MABENHNHAN)
)

CREATE TABLE DOANHTHU
(
	MADOANHTHU NVARCHAR(7) PRIMARY KEY, 
	NGAYLAP SMALLDATETIME CHECK (YEAR(NGAYLAP) < YEAR(GETDATE()) OR (YEAR(NGAYLAP) = YEAR(GETDATE()) 
		AND (MONTH(NGAYLAP) < MONTH(GETDATE())))), 
	SOBENHNHAN INT, 
	DOANHTHU INT, 
	TYLE INT
)

CREATE TABLE SUDUNGTHUOC
(
	MASUDUNGTHUOC NVARCHAR(8) PRIMARY KEY, 
	THANG INT CHECK (THANG >= 1 AND THANG <= 12), 
	NAM INT, 
	MATHUOC NVARCHAR(6), 
	SOLUONGDUNG INT, 
	SOLANDUNG INT, 
	CONSTRAINT THANGNAM CHECK (NAM < YEAR(GETDATE()) OR (NAM = YEAR(GETDATE()) AND 
		THANG < MONTH(GETDATE()))), 
	CONSTRAINT FKTHUOCSUDUNGTHUOC FOREIGN KEY (MATHUOC) REFERENCES THUOC (MATHUOC)
)

CREATE TRIGGER TINHDONGIABAN ON THUOC
FOR INSERT, UPDATE
AS
	BEGIN
		UPDATE THUOC
		SET DONGIABAN = DONGIANHAP * TYLETINHDONGIABAN / 100
	END

CREATE TRIGGER TINHTIENTHUOC ON CTPHIEUKB
FOR INSERT, UPDATE
AS
    BEGIN
		UPDATE CTPHIEUKB
		SET TIENTHUOC = SOLUONG * (
								      SELECT DONGIABAN
									  FROM THUOC
									  WHERE CTPHIEUKB.MATHUOC = THUOC.MATHUOC
								  )
	END

CREATE TRIGGER TINHTIENKHAM ON HOADON
FOR INSERT, UPDATE
AS
	BEGIN
		UPDATE HOADON
		SET TIENKHAM = (
						   SELECT GIATRI
						   FROM THAMSO
						   WHERE TENTHAMSO = 'Tiền khám'
					   )
	END

CREATE TRIGGER TINHTONGTIENTHUOC ON HOADON
FOR INSERT, UPDATE
AS
	BEGIN
		UPDATE HOADON
		SET TONGTIENTHUOC = (
								SELECT SUM(TIENTHUOC)
								FROM CTPHIEUKB CTP, PHIEUKB P
								WHERE CTP.MAPHIEUKB = P.MAPHIEUKB AND HOADON.MABENHNHAN = P.MABENHNHAN
							)
	END

CREATE TRIGGER DIEUCHINHTHONGTINCTPHIEUKBTINHTONGTIENTHUOC ON CTPHIEUKB
FOR INSERT, UPDATE, DELETE
AS
	BEGIN
		UPDATE HOADON
		SET TONGTIENTHUOC = (
								SELECT SUM(TIENTHUOC)
								FROM CTPHIEUKB CTP, PHIEUKB P
								WHERE CTP.MAPHIEUKB = P.MAPHIEUKB AND HOADON.MABENHNHAN = P.MABENHNHAN
							)
		WHERE MABENHNHAN = (
								SELECT MABENHNHAN
								FROM INSERTED I, PHIEUKB P
								WHERE I.MAPHIEUKB = P.MAPHIEUKB
								UNION
								SELECT MABENHNHAN
								FROM DELETED D, PHIEUKB P
								WHERE D.MAPHIEUKB = P.MAPHIEUKB
							)
	END

CREATE TRIGGER DEMSOBENHNHAN ON DOANHTHU
FOR INSERT, UPDATE
AS
	BEGIN
		UPDATE DOANHTHU
		SET SOBENHNHAN = (
							 SELECT COUNT(*)
							 FROM BENHNHAN
							 WHERE NGAYLAP = NGAYKHAMBENH
						 )
	END

ALTER TRIGGER DIEUCHINHTHONGTINBENHNHAN ON BENHNHAN
FOR INSERT, UPDATE, DELETE
AS
	BEGIN
		UPDATE DOANHTHU
		SET SOBENHNHAN = (
							 SELECT COUNT(*)
							 FROM BENHNHAN BN
							 WHERE NGAYLAP = BN.NGAYKHAMBENH
						 )
		WHERE NGAYLAP = (
							SELECT NGAYKHAMBENH
							FROM INSERTED
							UNION
							SELECT NGAYKHAMBENH
							FROM DELETED
						)
	END

CREATE TRIGGER TINHDOANHTHU ON DOANHTHU
FOR INSERT, UPDATE
AS
	BEGIN
		UPDATE DOANHTHU
		SET DOANHTHU = (
						   SELECT SUM(TONGTIENTHUOC)
						   FROM HOADON HD, BENHNHAN BN
						   WHERE HD.MABENHNHAN = BN.MABENHNHAN AND NGAYKHAMBENH = NGAYLAP
					   )
	END

CREATE TRIGGER DIEUCHINHTHONGTINHOADON ON HOADON
FOR INSERT, UPDATE, DELETE
AS
	BEGIN
		UPDATE DOANHTHU
		SET DOANHTHU = (
						   SELECT SUM(TONGTIENTHUOC)
						   FROM HOADON HD, BENHNHAN BN
						   WHERE HD.MABENHNHAN = BN.MABENHNHAN AND NGAYKHAMBENH = NGAYLAP
					   )
		WHERE NGAYLAP = (
							SELECT NGAYKHAMBENH
							FROM INSERTED I, BENHNHAN BN
							WHERE I.MABENHNHAN = BN.MABENHNHAN
							UNION
							SELECT NGAYKHAMBENH
							FROM DELETED D, BENHNHAN BN
							WHERE D.MABENHNHAN = BN.MABENHNHAN
						)
	END

CREATE TRIGGER SUANGAYKHAMBENH ON BENHNHAN
FOR UPDATE
AS
	BEGIN
		UPDATE DOANHTHU
		SET DOANHTHU = (
						   SELECT SUM(TONGTIENTHUOC)
						   FROM HOADON HD, BENHNHAN BN
						   WHERE HD.MABENHNHAN = BN.MABENHNHAN AND NGAYKHAMBENH = NGAYLAP
					   )
		WHERE NGAYLAP = (
							SELECT I.NGAYKHAMBENH
							FROM INSERTED I, BENHNHAN BN
							WHERE I.MABENHNHAN = BN.MABENHNHAN
							UNION
							SELECT D.NGAYKHAMBENH
							FROM DELETED D, BENHNHAN BN
							WHERE D.MABENHNHAN = BN.MABENHNHAN
						)
	END

CREATE TRIGGER TINHTYLEDOANHTHU ON DOANHTHU
FOR INSERT, UPDATE
AS
	BEGIN
		UPDATE DOANHTHU
		SET TYLE = DOANHTHU * 100 / (
										SELECT SUM(DT.DOANHTHU)
										FROM DOANHTHU DT
										WHERE MONTH(DT.NGAYLAP) = MONTH(DOANHTHU.NGAYLAP)
									)
	END

CREATE TRIGGER TINHSOLUONGTHUOCSUDUNG ON SUDUNGTHUOC
FOR INSERT, UPDATE
AS
	BEGIN
		UPDATE SUDUNGTHUOC
		SET SOLUONGDUNG = (
							  SELECT SUM(SOLUONGNHAP)
							  FROM CTPHIEUNT CTP, PHIEUNT P
							  WHERE SUDUNGTHUOC.MATHUOC = CTP.MATHUOC AND P.MAPHIEUNT = CTP.MACTPHIEUNT 
								AND SUDUNGTHUOC.THANG = MONTH(P.NGAYNHAPTHUOC) 
								AND SUDUNGTHUOC.NAM = YEAR(P.NGAYNHAPTHUOC)
						  ) - (
								  SELECT SUM(SOLUONG)
								  FROM CTPHIEUKB CTP, PHIEUKB P, BENHNHAN BN
								  WHERE CTP.MAPHIEUKB = P.MAPHIEUKB AND BN.MABENHNHAN = P.MABENHNHAN 
									  AND SUDUNGTHUOC.MATHUOC = CTP.MATHUOC 
									  AND SUDUNGTHUOC.THANG = MONTH(NGAYKHAMBENH) 
									  AND SUDUNGTHUOC.NAM = YEAR(NGAYKHAMBENH)
							  ) + (
									  SELECT SOLUONGTON
									  FROM THUOC
									  WHERE SUDUNGTHUOC.MATHUOC = THUOC.MATHUOC
								  )
	END

CREATE TRIGGER DIEUCHINHTHONGTINCTPHIEUNT ON CTPHIEUNT
FOR INSERT, UPDATE, DELETE
AS
	BEGIN
		UPDATE SUDUNGTHUOC
		SET SOLUONGDUNG = (
							  SELECT SUM(SOLUONGNHAP)
							  FROM CTPHIEUNT CTP, PHIEUNT P
							  WHERE SUDUNGTHUOC.MATHUOC = CTP.MATHUOC AND P.MAPHIEUNT = CTP.MACTPHIEUNT 
								AND SUDUNGTHUOC.THANG = MONTH(P.NGAYNHAPTHUOC) 
								AND SUDUNGTHUOC.NAM = YEAR(P.NGAYNHAPTHUOC)
						  ) - (
								  SELECT SUM(SOLUONG)
								  FROM CTPHIEUKB CTP, PHIEUKB P, BENHNHAN BN
								  WHERE CTP.MAPHIEUKB = P.MAPHIEUKB AND BN.MABENHNHAN = P.MABENHNHAN 
									  AND SUDUNGTHUOC.MATHUOC = CTP.MATHUOC 
									  AND SUDUNGTHUOC.THANG = MONTH(NGAYKHAMBENH) 
									  AND SUDUNGTHUOC.NAM = YEAR(NGAYKHAMBENH)
							  ) + (
									  SELECT SOLUONGTON
									  FROM THUOC
									  WHERE SUDUNGTHUOC.MATHUOC = THUOC.MATHUOC
								  )
		WHERE MATHUOC = (
							SELECT MATHUOC
							FROM INSERTED
							UNION
							SELECT MATHUOC
							FROM DELETED
						)
	END

CREATE TRIGGER SUANGAYNHAPTHUOC ON PHIEUNT
FOR UPDATE
AS
	BEGIN
		UPDATE SUDUNGTHUOC
		SET SOLUONGDUNG = (
							  SELECT SUM(SOLUONGNHAP)
							  FROM CTPHIEUNT CTP, PHIEUNT P
							  WHERE SUDUNGTHUOC.MATHUOC = CTP.MATHUOC AND P.MAPHIEUNT = CTP.MACTPHIEUNT 
								AND SUDUNGTHUOC.THANG = MONTH(P.NGAYNHAPTHUOC) 
								AND SUDUNGTHUOC.NAM = YEAR(P.NGAYNHAPTHUOC)
						  ) - (
								  SELECT SUM(SOLUONG)
								  FROM CTPHIEUKB CTP, PHIEUKB P, BENHNHAN BN
								  WHERE CTP.MAPHIEUKB = P.MAPHIEUKB AND BN.MABENHNHAN = P.MABENHNHAN 
									  AND SUDUNGTHUOC.MATHUOC = CTP.MATHUOC 
									  AND SUDUNGTHUOC.THANG = MONTH(NGAYKHAMBENH) 
									  AND SUDUNGTHUOC.NAM = YEAR(NGAYKHAMBENH)
							  ) + (
									  SELECT SOLUONGTON
									  FROM THUOC
									  WHERE SUDUNGTHUOC.MATHUOC = THUOC.MATHUOC
								  )
		WHERE MATHUOC = (
							SELECT MATHUOC
							FROM INSERTED
							UNION
							SELECT MATHUOC
							FROM DELETED
						)
	END

CREATE TRIGGER DIEUCHINHTHONGTINCTPHIEUKBTINHSOLUONGTHUOCSUDUNG ON CTPHIEUKB
FOR INSERT, UPDATE, DELETE
AS
	BEGIN
		UPDATE SUDUNGTHUOC
		SET SOLUONGDUNG = (
							  SELECT SUM(SOLUONGNHAP)
							  FROM CTPHIEUNT CTP, PHIEUNT P
							  WHERE SUDUNGTHUOC.MATHUOC = CTP.MATHUOC AND P.MAPHIEUNT = CTP.MACTPHIEUNT 
								AND SUDUNGTHUOC.THANG = MONTH(P.NGAYNHAPTHUOC) 
								AND SUDUNGTHUOC.NAM = YEAR(P.NGAYNHAPTHUOC)
						  ) - (
								  SELECT SUM(SOLUONG)
								  FROM CTPHIEUKB CTP, PHIEUKB P, BENHNHAN BN
								  WHERE CTP.MAPHIEUKB = P.MAPHIEUKB AND BN.MABENHNHAN = P.MABENHNHAN 
									  AND SUDUNGTHUOC.MATHUOC = CTP.MATHUOC 
									  AND SUDUNGTHUOC.THANG = MONTH(NGAYKHAMBENH) 
									  AND SUDUNGTHUOC.NAM = YEAR(NGAYKHAMBENH)
							  ) + (
									  SELECT SOLUONGTON
									  FROM THUOC
									  WHERE SUDUNGTHUOC.MATHUOC = THUOC.MATHUOC
								  )
		WHERE MATHUOC = (
							SELECT MATHUOC
							FROM INSERTED
							UNION
							SELECT MATHUOC
							FROM DELETED
						)
	END
INSERT INTO BENHNHAN VALUES('9', '1', '1', '2021/6/2', '1', '2021/6/4')
CREATE TRIGGER SUANGAYKHAMBENHTINHSOLUONGTHUOCSUDUNG ON BENHNHAN
FOR UPDATE
AS
	BEGIN
		UPDATE SUDUNGTHUOC
		SET SOLUONGDUNG = (
							  SELECT SUM(SOLUONGNHAP)
							  FROM CTPHIEUNT CTP, PHIEUNT P
							  WHERE SUDUNGTHUOC.MATHUOC = CTP.MATHUOC AND P.MAPHIEUNT = CTP.MACTPHIEUNT 
								AND SUDUNGTHUOC.THANG = MONTH(P.NGAYNHAPTHUOC) 
								AND SUDUNGTHUOC.NAM = YEAR(P.NGAYNHAPTHUOC)
						  ) - (
								  SELECT SUM(SOLUONG)
								  FROM CTPHIEUKB CTP, PHIEUKB P, BENHNHAN BN
								  WHERE CTP.MAPHIEUKB = P.MAPHIEUKB AND BN.MABENHNHAN = P.MABENHNHAN 
									  AND SUDUNGTHUOC.MATHUOC = CTP.MATHUOC 
									  AND SUDUNGTHUOC.THANG = MONTH(NGAYKHAMBENH) 
									  AND SUDUNGTHUOC.NAM = YEAR(NGAYKHAMBENH)
							  ) + (
									  SELECT SOLUONGTON
									  FROM THUOC
									  WHERE SUDUNGTHUOC.MATHUOC = THUOC.MATHUOC
								  )
		WHERE MATHUOC = (
							SELECT CTP.MATHUOC
							FROM INSERTED I, PHIEUKB P, CTPHIEUKB CTP
							WHERE I.MABENHNHAN = P.MABENHNHAN AND P.MAPHIEUKB = CTP.MAPHIEUKB
							UNION
							SELECT CTP.MATHUOC
							FROM DELETED D, PHIEUKB P, CTPHIEUKB CTP
							WHERE D.MABENHNHAN = P.MABENHNHAN AND P.MAPHIEUKB = CTP.MAPHIEUKB
						)
	END

CREATE TRIGGER DEMSOLANDUNG ON SUDUNGTHUOC
FOR INSERT, UPDATE
AS
	BEGIN
		UPDATE SUDUNGTHUOC
		SET SOLANDUNG = (
							SELECT COUNT(*)
							FROM CTPHIEUKB CTP, PHIEUKB P, BENHNHAN BN
							WHERE CTP.MAPHIEUKB = P.MAPHIEUKB AND P.MABENHNHAN = BN.MABENHNHAN 
								AND SUDUNGTHUOC.MATHUOC = CTP.MATHUOC 
								AND SUDUNGTHUOC.THANG = MONTH(NGAYKHAMBENH) 
								AND SUDUNGTHUOC.NAM = YEAR(NGAYKHAMBENH)
						)
	END

CREATE TRIGGER DIEUCHINHTHONGTINCTPHIEUKB ON CTPHIEUKB
FOR INSERT, UPDATE, DELETE
AS
	BEGIN
		UPDATE SUDUNGTHUOC
		SET SOLANDUNG = (
							SELECT COUNT(*)
							FROM CTPHIEUKB CTP, PHIEUKB P, BENHNHAN BN
							WHERE CTP.MAPHIEUKB = P.MAPHIEUKB AND P.MABENHNHAN = BN.MABENHNHAN 
								AND SUDUNGTHUOC.MATHUOC = CTP.MATHUOC 
								AND SUDUNGTHUOC.THANG = MONTH(NGAYKHAMBENH) 
								AND SUDUNGTHUOC.NAM = YEAR(NGAYKHAMBENH)
						)
		WHERE MATHUOC = (
							SELECT MATHUOC
							FROM INSERTED
							UNION
							SELECT MATHUOC
							FROM DELETED
						)
	END

CREATE TRIGGER SUANGAYKHAMBENHDEMSOLANDUNG ON BENHNHAN
FOR UPDATE
AS
	BEGIN
		UPDATE SUDUNGTHUOC
		SET SOLANDUNG = (
							SELECT COUNT(*)
							FROM CTPHIEUKB CTP, PHIEUKB P, BENHNHAN BN
							WHERE CTP.MAPHIEUKB = P.MAPHIEUKB AND P.MABENHNHAN = BN.MABENHNHAN 
								AND SUDUNGTHUOC.MATHUOC = CTP.MATHUOC 
								AND SUDUNGTHUOC.THANG = MONTH(NGAYKHAMBENH) 
								AND SUDUNGTHUOC.NAM = YEAR(NGAYKHAMBENH)
						)
		WHERE MATHUOC = (
							SELECT CTP.MATHUOC
							FROM INSERTED I, CTPHIEUKB CTP, PHIEUKB P
							WHERE I.MABENHNHAN = P.MABENHNHAN AND CTP.MAPHIEUKB = P.MAPHIEUKB
							UNION
							SELECT CTP.MATHUOC
							FROM DELETED D, CTPHIEUKB CTP, PHIEUKB P
							WHERE D.MABENHNHAN = P.MABENHNHAN AND CTP.MAPHIEUKB = P.MAPHIEUKB
						)
	END