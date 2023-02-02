﻿USE QUANLYPHONGKHAM
INSERT INTO PATIENT VALUES (1, 'Nguyen Van A', N'Nam', N'Hà Nội', '0123456789', '01/01/1990')
INSERT INTO PATIENT VALUES (2, 'Nguyen Van B', N'Nữ', N'Thái Nguyên', '0123456789', '02/26/2003')
INSERT INTO PATIENT VALUES (3, 'Nguyen Van C', N'Nam', N'Nam Định', '0123456789', '07/15/1966')
INSERT INTO PATIENT VALUES (4, 'Nguyen Van D', N'Nữ', N'Ninh Bình', '0123456789', '09/30/1994')
INSERT INTO PATIENT VALUES (5, 'Nguyen Van E', N'Nam', N'Nghệ An', '0123456789', '04/26/1984')
INSERT INTO PATIENT VALUES (6, 'Nguyen Van F', N'Nữ', N'Quảng Ninh', '0123456789', '06/30/2005')

INSERT INTO DRUG_STORAGE VALUES (1, 'Kho thuoc A')
INSERT INTO DRUG_STORAGE VALUES (2, 'Kho thuoc B')

INSERT INTO DRUG_TYPE VALUES (1, 'Thuoc', '')
INSERT INTO DRUG_TYPE VALUES (2, 'Thuoc bo sung', '')

INSERT INTO DRUG_STORAGE_TYPES VALUES (1, 1)
INSERT INTO DRUG_STORAGE_TYPES VALUES (2, 2)

INSERT INTO DRUG VALUES (1, 1, N'Panadol 500mg', N'Viên', 'A', '', 10000)
INSERT INTO DRUG VALUES (2, 1, N'Zinc 70mg' , N'Viên', 'B', '', 5000)
INSERT INTO DRUG VALUES (3, 2, N'Vitamin C 1000mg', N'Viên', 'C', '', 20000)
INSERT INTO DRUG VALUES (4, 2, N'Vitamin D 1000mg', N'Viên', 'D', '', 20000)

INSERT INTO DRUG_STORAGE_DATA VALUES (1, 1, 100)
INSERT INTO DRUG_STORAGE_DATA VALUES (1, 2, 100)
INSERT INTO DRUG_STORAGE_DATA VALUES (2, 3, 100)
INSERT INTO DRUG_STORAGE_DATA VALUES (2, 4, 100)

INSERT INTO SERVICE VALUES (1, N'Khám bệnh', N'Lần', 50000, '')
INSERT INTO SERVICE VALUES (2, N'Kiểm tra sức khỏe', N'Lần', 100000, '')
INSERT INTO SERVICE VALUES (3, N'Chụp X-Quang toàn thân', N'Lần', 300000, '')
INSERT INTO SERVICE VALUES (4, N'Chụp CT', N'Lần', 2000000, '')
INSERT INTO SERVICE VALUES (5, N'Nội soi dạ dày', N'Lần', 1800000, '')
INSERT INTO SERVICE VALUES (6, N'Siêu âm 2D - bụng', N'Lần', 200000, '')

INSERT INTO EMPLOYEE VALUES (0, 'Admin', 'Admin', 'admin', 'admin')
INSERT INTO EMPLOYEE VALUES (1, N'Tran Van A', N'Bác sĩ', 'tranvana', 'bacsi')
INSERT INTO EMPLOYEE VALUES (2, N'Tran Van B', N'Nhân viên', 'tranvanb', 'nhanvien')

INSERT INTO EXAMINE VALUES (1, 1, 1)
INSERT INTO EXAMINE VALUES (2, 2, 2)
INSERT INTO EXAMINE VALUES (3, 2, 3)
INSERT INTO EXAMINE VALUES (4, 2, 4)
INSERT INTO EXAMINE VALUES (5, 1, 5)
INSERT INTO EXAMINE VALUES (6, 2, 6)


INSERT INTO MEDICALRECORD VALUES (1, 1, '2023-1-28', 38.2, 60.5, 'Cam cum', '', 1)
INSERT INTO MEDICALRECORD VALUES (2, 2, '2023-1-29', 38.5, 71.2, 'Sot ret', '', 1)
INSERT INTO MEDICALRECORD VALUES (3, 3, '2023-1-30', 37.5, 55.0, 'Gay xuong', '', 1)
INSERT INTO MEDICALRECORD VALUES (4, 4, '2023-1-30', 37.8, 63.2, '', 'Yeu cau chup CT', 0)
INSERT INTO MEDICALRECORD VALUES (5, 5, '2023-1-30', 37.6, 77.8, '', 'Yeu cau chup X-quang', 0)
INSERT INTO MEDICALRECORD VALUES (6, 6, '2023-1-30', 38.3, 50.1, '', '', 0)

INSERT INTO PRESCRIPTION VALUES (1, 1, 6)
INSERT INTO PRESCRIPTION VALUES (1, 2, 6)
INSERT INTO PRESCRIPTION VALUES (2, 3, 6)
INSERT INTO PRESCRIPTION VALUES (2, 4, 6)
INSERT INTO PRESCRIPTION VALUES (3, 1, 12)

INSERT INTO SERVICEBILL VALUES (1, 1, 1)
INSERT INTO SERVICEBILL VALUES (2, 1, 1)
INSERT INTO SERVICEBILL VALUES (3, 3, 1)
INSERT INTO SERVICEBILL VALUES (4, 4, 1)
INSERT INTO SERVICEBILL VALUES (5, 3, 1)
INSERT INTO SERVICEBILL VALUES (6, 5, 1)

INSERT INTO PERMISSION VALUES (0, 1, 1, 1, 1, 1, 1, 1)
INSERT INTO PERMISSION VALUES (1, 1, 0, 0, 0, 0, 0, 0)
INSERT INTO PERMISSION VALUES (2, 0, 0, 1, 0, 0, 1, 1)