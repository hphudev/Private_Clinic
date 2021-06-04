﻿USE QUANLYPHONGMACHTU

CREATE TABLE CTKB
(
	MACTKB NVARCHAR(9) PRIMARY KEY, 
	MABENHNHAN NVARCHAR(7), 
	NGAYKHAMBENH SMALLDATETIME CHECK (NGAYKHAMBENH >= GETDATE()), 
	CONSTRAINT FKBENHNHANCTKB FOREIGN KEY (MABENHNHAN) REFERENCES BENHNHAN (MABENHNHAN)
)

ALTER TABLE BENHNHAN
DROP CONSTRAINT CK__BENHNHAN__NGAYKH__25869641
ALTER TABLE BENHNHAN
DROP COLUMN NGAYKHAMBENH

ALTER TABLE CTPHIEUNT
DROP CONSTRAINT FKPHIEUNT
DROP TABLE PHIEUNT

DROP TABLE CTPHIEUNT
CREATE TABLE CTPHIEUNT
(
	MACTPHIEUNT NVARCHAR(10) PRIMARY KEY, 
	MATHUOC NVARCHAR(6), 
	SOLUONGNHAP INT CHECK (SOLUONGNHAP > 0), 
	NGAYNHAPTHUOC SMALLDATETIME CHECK (NGAYNHAPTHUOC >= GETDATE()), 
	DONGIABANHIENTAI INT, 
	TYLETINHDONGIABANHIENTAI INT, 
	CONSTRAINT FKTHUOCCTPHIEUNT FOREIGN KEY (MATHUOC) REFERENCES THUOC (MATHUOC)
)

ALTER TRIGGER TINHTIENTHUOC ON CTPHIEUKB
FOR INSERT
AS
    BEGIN
		UPDATE CTPHIEUKB
		SET TIENTHUOC = SOLUONG * (
								      SELECT DONGIABAN
									  FROM THUOC
									  WHERE CTPHIEUKB.MATHUOC = THUOC.MATHUOC
								  )
	END

ALTER TRIGGER TINHTIENKHAM ON HOADON
FOR INSERT
AS
	BEGIN
		UPDATE HOADON
		SET TIENKHAM = (
						   SELECT GIATRI
						   FROM THAMSO
						   WHERE TENTHAMSO = 'Tiền khám'
					   )
	END

ALTER TRIGGER TINHTONGTIENTHUOC ON HOADON
FOR INSERT
AS
	BEGIN
		UPDATE HOADON
		SET TONGTIENTHUOC = (
								SELECT SUM(TIENTHUOC)
								FROM CTPHIEUKB CTP, PHIEUKB P
								WHERE CTP.MAPHIEUKB = P.MAPHIEUKB AND HOADON.MABENHNHAN = P.MABENHNHAN
							)
	END

DROP TRIGGER DIEUCHINHTHONGTINCTPHIEUKBTINHTONGTIENTHUOC
CREATE TRIGGER DIEUCHINHCTPHIEUKB ON CTPHIEUKB
FOR INSERT, UPDATE
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

ALTER TRIGGER DEMSOBENHNHAN ON DOANHTHU
FOR INSERT
AS
	BEGIN
		UPDATE DOANHTHU
		SET SOBENHNHAN = (
							 SELECT COUNT(*)
							 FROM BENHNHAN BN, CTKB CT
							 WHERE NGAYLAP = NGAYKHAMBENH AND BN.MABENHNHAN = CT.MABENHNHAN
						 )
	END

DROP TRIGGER DIEUCHINHTHONGTINBENHNHAN
CREATE TRIGGER THEMBENHNHAN ON BENHNHAN
FOR INSERT
AS
	BEGIN
		UPDATE DOANHTHU
		SET SOBENHNHAN = (
							 SELECT COUNT(*)
							 FROM BENHNHAN BN, CTKB CT
							 WHERE NGAYLAP = NGAYKHAMBENH AND BN.MABENHNHAN = CT.MABENHNHAN
						 )
		WHERE NGAYLAP = (
							SELECT NGAYKHAMBENH
							FROM INSERTED I, CTKB CT
							WHERE I.MABENHNHAN = CT.MABENHNHAN
						)
	END

ALTER TRIGGER TINHDOANHTHU ON DOANHTHU
FOR INSERT
AS
	BEGIN
		UPDATE DOANHTHU
		SET DOANHTHU = (
						   SELECT SUM(TONGTIENTHUOC)
						   FROM HOADON HD, BENHNHAN BN, CTKB CT
						   WHERE HD.MABENHNHAN = BN.MABENHNHAN AND BN.MABENHNHAN = CT.MABENHNHAN 
							   AND NGAYKHAMBENH = NGAYLAP
					   )
	END

DROP TRIGGER DIEUCHINHTHONGTINHOADON	
CREATE TRIGGER DIEUCHINHHOADON ON HOADON
FOR INSERT, UPDATE
AS
	BEGIN
		UPDATE DOANHTHU
		SET DOANHTHU = (
						   SELECT SUM(TONGTIENTHUOC)
						   FROM HOADON HD, BENHNHAN BN, CTKB CT
						   WHERE HD.MABENHNHAN = BN.MABENHNHAN AND CT.MABENHNHAN = BN.MABENHNHAN 
							   AND NGAYKHAMBENH = NGAYLAP
					   )
		WHERE NGAYLAP = (
							SELECT NGAYKHAMBENH
							FROM INSERTED I, BENHNHAN BN, CTKB CT
							WHERE I.MABENHNHAN = BN.MABENHNHAN AND CT.MABENHNHAN = BN.MABENHNHAN
							UNION
							SELECT NGAYKHAMBENH
							FROM DELETED D, BENHNHAN BN, CTKB CT
							WHERE D.MABENHNHAN = BN.MABENHNHAN AND CT.MABENHNHAN = BN.MABENHNHAN
						)
	END

DROP TRIGGER SUANGAYKHAMBENH

ALTER TRIGGER TINHSOLUONGTHUOCSUDUNG ON SUDUNGTHUOC
FOR INSERT
AS
	BEGIN
		UPDATE SUDUNGTHUOC
		SET SOLUONGDUNG = (
								SELECT SUM(SOLUONG)
								FROM CTPHIEUKB CTP, PHIEUKB P, BENHNHAN BN, CTKB CT
								WHERE CTP.MAPHIEUKB = P.MAPHIEUKB AND BN.MABENHNHAN = P.MABENHNHAN 
									AND BN.MABENHNHAN = CT.MABENHNHAN 
									AND SUDUNGTHUOC.MATHUOC = CTP.MATHUOC 
									AND SUDUNGTHUOC.THANG = MONTH(NGAYKHAMBENH) 
									AND SUDUNGTHUOC.NAM = YEAR(NGAYKHAMBENH) 
						  )
	END

DROP TRIGGER DIEUCHINHTHONGTINCTPHIEUNT
DROP TRIGGER SUANGAYNHAPTHUOC

DROP TRIGGER DIEUCHINHTHONGTINCTPHIEUKBTINHSOLUONGTHUOCSUDUNG
CREATE TRIGGER DIEUCHINHCTPHIEUKBA ON CTPHIEUKB
FOR INSERT
AS
	BEGIN
		UPDATE SUDUNGTHUOC
		SET SOLUONGDUNG = (
							    SELECT SUM(SOLUONG)
								FROM CTPHIEUKB CTP, PHIEUKB P, BENHNHAN BN, CTKB CT
								WHERE CTP.MAPHIEUKB = P.MAPHIEUKB AND BN.MABENHNHAN = P.MABENHNHAN 
									AND BN.MABENHNHAN = CT.MABENHNHAN 
									AND SUDUNGTHUOC.MATHUOC = CTP.MATHUOC 
									AND SUDUNGTHUOC.THANG = MONTH(NGAYKHAMBENH) 
									AND SUDUNGTHUOC.NAM = YEAR(NGAYKHAMBENH) 
						  )
		WHERE MATHUOC = (
							SELECT MATHUOC
							FROM INSERTED
						)
	END

DROP TRIGGER SUANGAYKHAMBENHTINHSOLUONGTHUOCSUDUNG

ALTER TRIGGER DEMSOLANDUNG ON SUDUNGTHUOC
FOR INSERT
AS
	BEGIN
		UPDATE SUDUNGTHUOC
		SET SOLANDUNG = (
							SELECT COUNT(*)
							FROM CTPHIEUKB CTP, PHIEUKB P, BENHNHAN BN, CTKB CT
							WHERE CTP.MAPHIEUKB = P.MAPHIEUKB AND P.MABENHNHAN = BN.MABENHNHAN
								AND BN.MABENHNHAN = CT.MABENHNHAN
								AND SUDUNGTHUOC.MATHUOC = CTP.MATHUOC 
								AND SUDUNGTHUOC.THANG = MONTH(CT.NGAYKHAMBENH) 
								AND SUDUNGTHUOC.NAM = YEAR(CT.NGAYKHAMBENH)
						)
	END

DROP TRIGGER DIEUCHINHTHONGTINCTPHIEUKB
CREATE TRIGGER DIEUCHINHCTPHIEUKBB ON CTPHIEUKB
FOR INSERT
AS
	BEGIN
		UPDATE SUDUNGTHUOC
		SET SOLANDUNG = (
							SELECT COUNT(*)
							FROM CTPHIEUKB CTP, PHIEUKB P, BENHNHAN BN, CTKB CT
							WHERE CTP.MAPHIEUKB = P.MAPHIEUKB AND P.MABENHNHAN = BN.MABENHNHAN
								AND BN.MABENHNHAN = CT.MABENHNHAN
								AND SUDUNGTHUOC.MATHUOC = CTP.MATHUOC 
								AND SUDUNGTHUOC.THANG = MONTH(CT.NGAYKHAMBENH) 
								AND SUDUNGTHUOC.NAM = YEAR(CT.NGAYKHAMBENH)
						)
		WHERE MATHUOC = (
							SELECT MATHUOC
							FROM INSERTED
						)
	END

DROP TRIGGER SUANGAYKHAMBENHDEMSOLANDUNG

ALTER TABLE BENHNHAN
ADD CONSTRAINT CHECKGIOITINH CHECK ((GIOITINH = 'Nam' OR GIOITINH = 'Nữ' OR GIOITINH = 'Khác') 
	AND GIOITINH IS NOT NULL)

ALTER TABLE BENHNHAN
ADD CONSTRAINT CHECKHOTEN CHECK (HOTEN IS NOT NULL)

ALTER TABLE BENHNHAN
ADD CONSTRAINT CHECKDIACHI CHECK (DIACHI IS NOT NULL)

ALTER TABLE BENHNHAN
ADD CONSTRAINT CHECKNGAYSINH CHECK (NGAYSINH IS NOT NULL)

ALTER TABLE THAMSO
ADD CONSTRAINT CHECKGIATRI CHECK (GIATRI > 0 AND GIATRI IS NOT NULL)

ALTER TABLE THUOC
ADD CONSTRAINT CHECKTENTHUOC CHECK (TENTHUOC IS NOT NULL)

ALTER TABLE THUOC
ADD CONSTRAINT CHECKSOLUONGTON CHECK (SOLUONGTON IS NOT NULL)

ALTER TABLE THUOC
ADD CONSTRAINT CHECKDONGIANHAP CHECK (DONGIANHAP IS NOT NULL)

ALTER TABLE THUOC
ADD CONSTRAINT CHECKMADONVITINH CHECK (MADONVITINH IS NOT NULL)

ALTER TABLE THUOC
ADD CONSTRAINT CHECKTYLETINHDONGIABAN CHECK (TYLETINHDONGIABAN IS NOT NULL)

ALTER TABLE CTPHIEUNT
ADD CONSTRAINT CHECKMATHUOC CHECK (MATHUOC IS NOT NULL)

ALTER TABLE CTPHIEUNT
ADD CONSTRAINT CHECKSOLUONGNHAP CHECK (SOLUONGNHAP IS NOT NULL)

ALTER TABLE CTPHIEUNT
ADD CONSTRAINT CHECKNGAYNHAPTHUOC CHECK (NGAYNHAPTHUOC IS NOT NULL)

ALTER TABLE BENH
ADD CONSTRAINT CHECKTENBENH CHECK (TENBENH IS NOT NULL)

ALTER TABLE PHIEUKB
ADD CONSTRAINT CHECKMABENHNHAN CHECK (MABENHNHAN IS NOT NULL)

ALTER TABLE PHIEUKB
ADD CONSTRAINT CHECKTRIEUCHUNG CHECK (TRIEUCHUNG IS NOT NULL)

ALTER TABLE PHIEUKB
ADD CONSTRAINT CHECKMABENH CHECK (MABENH IS NOT NULL)

ALTER TABLE CTPHIEUKB
ADD CONSTRAINT CHECKMAPHIEUKB CHECK (MAPHIEUKB IS NOT NULL)

ALTER TABLE CTPHIEUKB
ADD CONSTRAINT CHECKMATHUOCA CHECK (MATHUOC IS NOT NULL)

ALTER TABLE CTPHIEUKB
ADD CONSTRAINT CHECKSOLUONG CHECK (SOLUONG IS NOT NULL)

ALTER TABLE CTPHIEUKB
ADD CONSTRAINT CHECKMACACHDUNG CHECK (MACACHDUNG IS NOT NULL)

ALTER TABLE CACHDUNG
ADD CONSTRAINT CHECKTENCACHDUNG CHECK (TENCACHDUNG IS NOT NULL)

ALTER TABLE DONVITINH
ADD CONSTRAINT CHECKTENDONVITINH CHECK (TENDONVITINH IS NOT NULL)

ALTER TABLE HOADON
ADD CONSTRAINT CHECKMABENHNHANA CHECK (MABENHNHAN IS NOT NULL)

ALTER TABLE DOANHTHU
ADD CONSTRAINT CHECKNGAYLAP CHECK (NGAYLAP IS NOT NULL)

ALTER TABLE SUDUNGTHUOC
ADD CONSTRAINT CHECKTHANG CHECK (THANG IS NOT NULL)

ALTER TABLE SUDUNGTHUOC
ADD CONSTRAINT CHECKNAM CHECK (NAM IS NOT NULL)

ALTER TABLE SUDUNGTHUOC
ADD CONSTRAINT CHECKMATHUOCB CHECK (MATHUOC IS NOT NULL)

ALTER TABLE CTKB
ADD CONSTRAINT CHECKMABENHNHANB CHECK (MABENHNHAN IS NOT NULL)

ALTER TABLE CTKB
ADD CONSTRAINT CHECKNGAYKHAMBENH CHECK (NGAYKHAMBENH IS NOT NULL)

ALTER TABLE THUOC
ADD CONSTRAINT SOLUONGTON DEFAULT 0 FOR [SOLUONGTON]

ALTER TABLE THUOC
ADD CONSTRAINT PRIMARYKEYTHUOC UNIQUE (MATHUOC, MADONVITINH)

ALTER TABLE BENH
ADD CONSTRAINT PRIMARYKEYBENH UNIQUE (TENBENH)

ALTER TABLE CTPHIEUKB 
ADD	CONSTRAINT PRIMARYKEYCTPHIEUKB UNIQUE (MAPHIEUKB, MATHUOC)

ALTER TABLE CACHDUNG
ADD CONSTRAINT PRIMARYKEYCACHDUNG UNIQUE (TENCACHDUNG)

ALTER TABLE DONVITINH
ADD CONSTRAINT PRIMARYKEYDONVITINH UNIQUE (TENDONVITINH)

ALTER TABLE DOANHTHU
ADD CONSTRAINT PRIMARYKEYDOANHTHU UNIQUE (NGAYLAP)

ALTER TABLE SUDUNGTHUOC
ADD CONSTRAINT PRIMARYKEYSUDUNGTHUOC UNIQUE (THANG, NAM, MATHUOC)

ALTER TABLE CTKB
ADD CONSTRAINT PRIMARYKEYCTKB UNIQUE (MABENHNHAN, NGAYKHAMBENH)

CREATE TRIGGER NHAPTHUOC ON CTPHIEUNT
FOR INSERT
AS
	BEGIN
		UPDATE THUOC
		SET SOLUONGTON += (
							  SELECT I.SOLUONGNHAP
							  FROM INSERTED I
						  )
		WHERE MATHUOC = (
							SELECT I.MATHUOC
							FROM INSERTED I
						)
	END

CREATE TRIGGER SUDUNGTHUOCA ON CTPHIEUKB
FOR INSERT
AS
	BEGIN
		UPDATE THUOC
		SET SOLUONGTON -= (
							  SELECT I.SOLUONG
							  FROM INSERTED I
						  )
		WHERE MATHUOC = (
							SELECT I.MATHUOC
							FROM INSERTED I
						)
	END

CREATE TRIGGER TINHDONGIABANHIENTAI ON CTPHIEUNT
FOR INSERT
AS
	BEGIN
		UPDATE CTPHIEUNT
		SET DONGIABANHIENTAI = (
								   SELECT T.DONGIABAN
								   FROM THUOC T
								   WHERE T.MATHUOC = CTPHIEUNT.MATHUOC
							   )
	END

CREATE TRIGGER TINHTYLEDONGIABANHIENTAI ON CTPHIEUNT
FOR INSERT
AS
	BEGIN
		UPDATE CTPHIEUNT
		SET TYLETINHDONGIABANHIENTAI = (
								   SELECT T.TYLETINHDONGIABAN
								   FROM THUOC T
								   WHERE T.MATHUOC = CTPHIEUNT.MATHUOC
							   )
	END