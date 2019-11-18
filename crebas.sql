/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2008                    */
/* Created on:     18/11/2019 1:38:00 CH                        */
/*==============================================================*/


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('BANG_GIA') and o.name = 'FK_BANG_GIA_RELATIONS_HANGHOA')
alter table BANG_GIA
   drop constraint FK_BANG_GIA_RELATIONS_HANGHOA
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CHI_TIET_CC') and o.name = 'FK_CHI_TIET_RELATIONS_DANH_MUC')
alter table CHI_TIET_CC
   drop constraint FK_CHI_TIET_RELATIONS_DANH_MUC
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CHI_TIET_CC') and o.name = 'FK_CHI_TIET_RELATIONS_NHA_CUNG')
alter table CHI_TIET_CC
   drop constraint FK_CHI_TIET_RELATIONS_NHA_CUNG
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CHI_TIET_DDH') and o.name = 'FK_CHI_TIET_RELATIONS_HANGHOA')
alter table CHI_TIET_DDH
   drop constraint FK_CHI_TIET_RELATIONS_HANGHOA
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CHI_TIET_DDH') and o.name = 'FK_CHI_TIET_RELATIONS_DON_DAT_')
alter table CHI_TIET_DDH
   drop constraint FK_CHI_TIET_RELATIONS_DON_DAT_
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CHI_TIET_HD') and o.name = 'FK_CHI_TIET_RELATIONS_HOA_DON')
alter table CHI_TIET_HD
   drop constraint FK_CHI_TIET_RELATIONS_HOA_DON
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CHI_TIET_HD') and o.name = 'FK_CHI_TIET_RELATIONS_HANGHOA')
alter table CHI_TIET_HD
   drop constraint FK_CHI_TIET_RELATIONS_HANGHOA
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('DON_DAT_HANG_NCC') and o.name = 'FK_DON_DAT__RELATIONS_NHA_CUNG')
alter table DON_DAT_HANG_NCC
   drop constraint FK_DON_DAT__RELATIONS_NHA_CUNG
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('HANGHOA') and o.name = 'FK_HANGHOA_RELATIONS_DANH_MUC')
alter table HANGHOA
   drop constraint FK_HANGHOA_RELATIONS_DANH_MUC
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('HOA_DON') and o.name = 'FK_HOA_DON_RELATIONS_THE_THAN')
alter table HOA_DON
   drop constraint FK_HOA_DON_RELATIONS_THE_THAN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('HOA_DON') and o.name = 'FK_HOA_DON_RELATIONS_NHANVIEN')
alter table HOA_DON
   drop constraint FK_HOA_DON_RELATIONS_NHANVIEN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('KHUYEN_MAI') and o.name = 'FK_KHUYEN_M_RELATIONS_HANGHOA')
alter table KHUYEN_MAI
   drop constraint FK_KHUYEN_M_RELATIONS_HANGHOA
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('LO_HANG') and o.name = 'FK_LO_HANG_RELATIONS_PHIEUNHA')
alter table LO_HANG
   drop constraint FK_LO_HANG_RELATIONS_PHIEUNHA
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('LO_HANG') and o.name = 'FK_LO_HANG_RELATIONS_HANGHOA')
alter table LO_HANG
   drop constraint FK_LO_HANG_RELATIONS_HANGHOA
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PHIEUNHAP') and o.name = 'FK_PHIEUNHA_RELATIONS_DON_DAT_')
alter table PHIEUNHAP
   drop constraint FK_PHIEUNHA_RELATIONS_DON_DAT_
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TAI_KHOAN') and o.name = 'FK_TAI_KHOA_RELATIONS_NHANVIEN')
alter table TAI_KHOAN
   drop constraint FK_TAI_KHOA_RELATIONS_NHANVIEN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('THE_THANH_VIEN') and o.name = 'FK_THE_THAN_SO_HUU_KHACH_HA')
alter table THE_THANH_VIEN
   drop constraint FK_THE_THAN_SO_HUU_KHACH_HA
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('BANG_GIA')
            and   name  = 'RELATIONSHIP_10_FK'
            and   indid > 0
            and   indid < 255)
   drop index BANG_GIA.RELATIONSHIP_10_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('BANG_GIA')
            and   type = 'U')
   drop table BANG_GIA
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('CHI_TIET_CC')
            and   name  = 'RELATIONSHIP_15_FK'
            and   indid > 0
            and   indid < 255)
   drop index CHI_TIET_CC.RELATIONSHIP_15_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('CHI_TIET_CC')
            and   name  = 'RELATIONSHIP_14_FK'
            and   indid > 0
            and   indid < 255)
   drop index CHI_TIET_CC.RELATIONSHIP_14_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CHI_TIET_CC')
            and   type = 'U')
   drop table CHI_TIET_CC
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('CHI_TIET_DDH')
            and   name  = 'RELATIONSHIP_17_FK'
            and   indid > 0
            and   indid < 255)
   drop index CHI_TIET_DDH.RELATIONSHIP_17_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('CHI_TIET_DDH')
            and   name  = 'RELATIONSHIP_16_FK'
            and   indid > 0
            and   indid < 255)
   drop index CHI_TIET_DDH.RELATIONSHIP_16_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CHI_TIET_DDH')
            and   type = 'U')
   drop table CHI_TIET_DDH
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('CHI_TIET_HD')
            and   name  = 'RELATIONSHIP_9_FK'
            and   indid > 0
            and   indid < 255)
   drop index CHI_TIET_HD.RELATIONSHIP_9_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('CHI_TIET_HD')
            and   name  = 'RELATIONSHIP_8_FK'
            and   indid > 0
            and   indid < 255)
   drop index CHI_TIET_HD.RELATIONSHIP_8_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CHI_TIET_HD')
            and   type = 'U')
   drop table CHI_TIET_HD
go

if exists (select 1
            from  sysobjects
           where  id = object_id('DANH_MUC_SP')
            and   type = 'U')
   drop table DANH_MUC_SP
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('DON_DAT_HANG_NCC')
            and   name  = 'RELATIONSHIP_18_FK'
            and   indid > 0
            and   indid < 255)
   drop index DON_DAT_HANG_NCC.RELATIONSHIP_18_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('DON_DAT_HANG_NCC')
            and   type = 'U')
   drop table DON_DAT_HANG_NCC
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('HANGHOA')
            and   name  = 'RELATIONSHIP_13_FK'
            and   indid > 0
            and   indid < 255)
   drop index HANGHOA.RELATIONSHIP_13_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('HANGHOA')
            and   type = 'U')
   drop table HANGHOA
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('HOA_DON')
            and   name  = 'RELATIONSHIP_7_FK'
            and   indid > 0
            and   indid < 255)
   drop index HOA_DON.RELATIONSHIP_7_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('HOA_DON')
            and   name  = 'RELATIONSHIP_3_FK'
            and   indid > 0
            and   indid < 255)
   drop index HOA_DON.RELATIONSHIP_3_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('HOA_DON')
            and   type = 'U')
   drop table HOA_DON
go

if exists (select 1
            from  sysobjects
           where  id = object_id('KHACH_HANG')
            and   type = 'U')
   drop table KHACH_HANG
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('KHUYEN_MAI')
            and   name  = 'RELATIONSHIP_11_FK'
            and   indid > 0
            and   indid < 255)
   drop index KHUYEN_MAI.RELATIONSHIP_11_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('KHUYEN_MAI')
            and   type = 'U')
   drop table KHUYEN_MAI
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('LO_HANG')
            and   name  = 'RELATIONSHIP_21_FK'
            and   indid > 0
            and   indid < 255)
   drop index LO_HANG.RELATIONSHIP_21_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('LO_HANG')
            and   name  = 'RELATIONSHIP_20_FK'
            and   indid > 0
            and   indid < 255)
   drop index LO_HANG.RELATIONSHIP_20_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('LO_HANG')
            and   type = 'U')
   drop table LO_HANG
go

if exists (select 1
            from  sysobjects
           where  id = object_id('NHANVIEN')
            and   type = 'U')
   drop table NHANVIEN
go

if exists (select 1
            from  sysobjects
           where  id = object_id('NHA_CUNG_CAP')
            and   type = 'U')
   drop table NHA_CUNG_CAP
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PHIEUNHAP')
            and   name  = 'RELATIONSHIP_19_FK'
            and   indid > 0
            and   indid < 255)
   drop index PHIEUNHAP.RELATIONSHIP_19_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PHIEUNHAP')
            and   type = 'U')
   drop table PHIEUNHAP
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('TAI_KHOAN')
            and   name  = 'RELATIONSHIP_6_FK'
            and   indid > 0
            and   indid < 255)
   drop index TAI_KHOAN.RELATIONSHIP_6_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TAI_KHOAN')
            and   type = 'U')
   drop table TAI_KHOAN
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('THE_THANH_VIEN')
            and   name  = 'SO_HUU_FK'
            and   indid > 0
            and   indid < 255)
   drop index THE_THANH_VIEN.SO_HUU_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('THE_THANH_VIEN')
            and   type = 'U')
   drop table THE_THANH_VIEN
go

/*==============================================================*/
/* Table: BANG_GIA                                              */
/*==============================================================*/
create table BANG_GIA (
   MASP                 char(10)             not null,
   NGAYBD               datetime             not null,
   NGAYKT               datetime             null,
   GIA_BAN              float                null,
   constraint PK_BANG_GIA primary key nonclustered (MASP, NGAYBD)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_10_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_10_FK on BANG_GIA (
MASP ASC
)
go

/*==============================================================*/
/* Table: CHI_TIET_CC                                           */
/*==============================================================*/
create table CHI_TIET_CC (
   MALOAI               char(10)             not null,
   MANCC                char(10)             not null,
   constraint PK_CHI_TIET_CC primary key (MALOAI, MANCC)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_14_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_14_FK on CHI_TIET_CC (
MALOAI ASC
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_15_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_15_FK on CHI_TIET_CC (
MANCC ASC
)
go

/*==============================================================*/
/* Table: CHI_TIET_DDH                                          */
/*==============================================================*/
create table CHI_TIET_DDH (
   MASP                 char(10)             not null,
   MADDH                char(10)             not null,
   SOLUONGDAT           int                  null,
   constraint PK_CHI_TIET_DDH primary key (MASP, MADDH)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_16_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_16_FK on CHI_TIET_DDH (
MASP ASC
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_17_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_17_FK on CHI_TIET_DDH (
MADDH ASC
)
go

/*==============================================================*/
/* Table: CHI_TIET_HD                                           */
/*==============================================================*/
create table CHI_TIET_HD (
   MAHD                 char(10)             not null,
   MASP                 char(10)             not null,
   SOLUONG_BAN          float                null,
   DONGIA_BAN           float                null,
   constraint PK_CHI_TIET_HD primary key ()
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_8_FK                                     */
/*==============================================================*/
create index RELATIONSHIP_8_FK on CHI_TIET_HD (
MAHD ASC
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_9_FK                                     */
/*==============================================================*/
create index RELATIONSHIP_9_FK on CHI_TIET_HD (
MASP ASC
)
go

/*==============================================================*/
/* Table: DANH_MUC_SP                                           */
/*==============================================================*/
create table DANH_MUC_SP (
   MALOAI               char(10)             not null,
   TENLOAI              varchar(50)          null,
   DVT                  varchar(3)           null,
   constraint PK_DANH_MUC_SP primary key nonclustered (MALOAI)
)
go

/*==============================================================*/
/* Table: DON_DAT_HANG_NCC                                      */
/*==============================================================*/
create table DON_DAT_HANG_NCC (
   MADDH                char(10)             not null,
   MANCC                char(10)             null,
   NGAYDAT              datetime             null,
   GHICHU_DDH           varchar(100)         null,
   constraint PK_DON_DAT_HANG_NCC primary key nonclustered (MADDH)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_18_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_18_FK on DON_DAT_HANG_NCC (
MANCC ASC
)
go

/*==============================================================*/
/* Table: HANGHOA                                               */
/*==============================================================*/
create table HANGHOA (
   MASP                 char(10)             not null,
   MALOAI               char(10)             null,
   TENSP                varchar(50)          null,
   constraint PK_HANGHOA primary key nonclustered (MASP)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_13_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_13_FK on HANGHOA (
MALOAI ASC
)
go

/*==============================================================*/
/* Table: HOA_DON                                               */
/*==============================================================*/
create table HOA_DON (
   MAHD                 char(10)             not null,
   MANV                 char(10)             null,
   MATHE                numeric(10)          null,
   NGAYLAP              datetime             null,
   TONGTIEN             float                null,
   GIAMGIA              float                null,
   TIENTHOI             float                null,
   constraint PK_HOA_DON primary key nonclustered (MAHD)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_3_FK                                     */
/*==============================================================*/
create index RELATIONSHIP_3_FK on HOA_DON (
MATHE ASC
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_7_FK                                     */
/*==============================================================*/
create index RELATIONSHIP_7_FK on HOA_DON (
MANV ASC
)
go

/*==============================================================*/
/* Table: KHACH_HANG                                            */
/*==============================================================*/
create table KHACH_HANG (
   CMND                 numeric(10)          not null,
   TENKH                varchar(50)          null,
   PHAI                 varchar(3)           null,
   DIACHI               varchar(100)         null,
   SDT                  numeric(10)          null,
   GHICHU               varchar(100)         null,
   constraint PK_KHACH_HANG primary key nonclustered (CMND)
)
go

/*==============================================================*/
/* Table: KHUYEN_MAI                                            */
/*==============================================================*/
create table KHUYEN_MAI (
   MASP                 char(10)             not null,
   NGAYBD_KM            datetime             not null,
   NGAYKT_KM            datetime             null,
   GIAMGIA              float                null,
   constraint PK_KHUYEN_MAI primary key nonclustered (MASP, NGAYBD_KM)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_11_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_11_FK on KHUYEN_MAI (
MASP ASC
)
go

/*==============================================================*/
/* Table: LO_HANG                                               */
/*==============================================================*/
create table LO_HANG (
   MALO                 char(10)             not null,
   MASP                 char(10)             not null,
   MAPN                 char(10)             not null,
   NGAYSX               datetime             null,
   HANSD                datetime             null,
   SOLUONGNHAP          int                  null,
   SOLUONG_TRENQUAY     int                  null,
   DONGIA_NHAP          float                null,
   constraint PK_LO_HANG primary key nonclustered (MALO)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_20_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_20_FK on LO_HANG (
MAPN ASC
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_21_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_21_FK on LO_HANG (
MASP ASC
)
go

/*==============================================================*/
/* Table: NHANVIEN                                              */
/*==============================================================*/
create table NHANVIEN (
   MANV                 char(10)             not null,
   TENNV                varchar(50)          null,
   CHUCVU               varchar(50)          null,
   PHAI_NV              varchar(3)           null,
   DIACHI_NV            varchar(100)         null,
   SDT_NV               numeric(10)          null,
   constraint PK_NHANVIEN primary key nonclustered (MANV)
)
go

/*==============================================================*/
/* Table: NHA_CUNG_CAP                                          */
/*==============================================================*/
create table NHA_CUNG_CAP (
   MANCC                char(10)             not null,
   TEN_NCC              varchar(50)          null,
   DIACHI_NCC           varchar(100)         null,
   EMAIL_NCC            varchar(50)          null,
   SDT_NCC              numeric(10)          null,
   constraint PK_NHA_CUNG_CAP primary key nonclustered (MANCC)
)
go

/*==============================================================*/
/* Table: PHIEUNHAP                                             */
/*==============================================================*/
create table PHIEUNHAP (
   MAPN                 char(10)             not null,
   MADDH                char(10)             null,
   NGAYLAP_PN           datetime             null,
   TONGTIEN_PN          float                null,
   constraint PK_PHIEUNHAP primary key nonclustered (MAPN)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_19_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_19_FK on PHIEUNHAP (
MADDH ASC
)
go

/*==============================================================*/
/* Table: TAI_KHOAN                                             */
/*==============================================================*/
create table TAI_KHOAN (
   TENDN                char(20)             not null,
   MANV                 char(10)             null,
   MATKHAU              char(20)             null,
   QUYEN                varchar(5)           null,
   constraint PK_TAI_KHOAN primary key nonclustered (TENDN)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_6_FK                                     */
/*==============================================================*/
create index RELATIONSHIP_6_FK on TAI_KHOAN (
MANV ASC
)
go

/*==============================================================*/
/* Table: THE_THANH_VIEN                                        */
/*==============================================================*/
create table THE_THANH_VIEN (
   MATHE                numeric(10)          not null,
   CMND                 numeric(10)          null,
   NGAYCAPTHE           datetime             null,
   TICHLUY              float                null,
   TINHTRANG            bit                  null,
   constraint PK_THE_THANH_VIEN primary key nonclustered (MATHE)
)
go

/*==============================================================*/
/* Index: SO_HUU_FK                                             */
/*==============================================================*/
create index SO_HUU_FK on THE_THANH_VIEN (
CMND ASC
)
go

alter table BANG_GIA
   add constraint FK_BANG_GIA_RELATIONS_HANGHOA foreign key (MASP)
      references HANGHOA (MASP)
go

alter table CHI_TIET_CC
   add constraint FK_CHI_TIET_RELATIONS_DANH_MUC foreign key (MALOAI)
      references DANH_MUC_SP (MALOAI)
go

alter table CHI_TIET_CC
   add constraint FK_CHI_TIET_RELATIONS_NHA_CUNG foreign key (MANCC)
      references NHA_CUNG_CAP (MANCC)
go

alter table CHI_TIET_DDH
   add constraint FK_CHI_TIET_RELATIONS_HANGHOA foreign key (MASP)
      references HANGHOA (MASP)
go

alter table CHI_TIET_DDH
   add constraint FK_CHI_TIET_RELATIONS_DON_DAT_ foreign key (MADDH)
      references DON_DAT_HANG_NCC (MADDH)
go

alter table CHI_TIET_HD
   add constraint FK_CHI_TIET_RELATIONS_HOA_DON foreign key (MAHD)
      references HOA_DON (MAHD)
go

alter table CHI_TIET_HD
   add constraint FK_CHI_TIET_RELATIONS_HANGHOA foreign key (MASP)
      references HANGHOA (MASP)
go

alter table DON_DAT_HANG_NCC
   add constraint FK_DON_DAT__RELATIONS_NHA_CUNG foreign key (MANCC)
      references NHA_CUNG_CAP (MANCC)
go

alter table HANGHOA
   add constraint FK_HANGHOA_RELATIONS_DANH_MUC foreign key (MALOAI)
      references DANH_MUC_SP (MALOAI)
go

alter table HOA_DON
   add constraint FK_HOA_DON_RELATIONS_THE_THAN foreign key (MATHE)
      references THE_THANH_VIEN (MATHE)
go

alter table HOA_DON
   add constraint FK_HOA_DON_RELATIONS_NHANVIEN foreign key (MANV)
      references NHANVIEN (MANV)
go

alter table KHUYEN_MAI
   add constraint FK_KHUYEN_M_RELATIONS_HANGHOA foreign key (MASP)
      references HANGHOA (MASP)
go

alter table LO_HANG
   add constraint FK_LO_HANG_RELATIONS_PHIEUNHA foreign key (MAPN)
      references PHIEUNHAP (MAPN)
go

alter table LO_HANG
   add constraint FK_LO_HANG_RELATIONS_HANGHOA foreign key (MASP)
      references HANGHOA (MASP)
go

alter table PHIEUNHAP
   add constraint FK_PHIEUNHA_RELATIONS_DON_DAT_ foreign key (MADDH)
      references DON_DAT_HANG_NCC (MADDH)
go

alter table TAI_KHOAN
   add constraint FK_TAI_KHOA_RELATIONS_NHANVIEN foreign key (MANV)
      references NHANVIEN (MANV)
go

alter table THE_THANH_VIEN
   add constraint FK_THE_THAN_SO_HUU_KHACH_HA foreign key (CMND)
      references KHACH_HANG (CMND)
go

