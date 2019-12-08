using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QL_CuaHangNongSan
{
    static class Program
    {
        public static frmLogin frmLogin = null;
        public static frmKetNoi frmCauHinh = null;
        public static frmDoiMatKhau frmDoiMatKhau = null;
        public static frmMain frmMain = null;
        //form business
        public static frmHoaDon frmHoaDon = null;
        //form danh mục
        public static frmDanhMucMatHang frmDanhMucMatHang = null;
        public static frmDanhMucKhachHang frmDanhMucKhachHang = null;
        public static frmDanhMucNhanVien frmDanhMucNhanVien = null;
        //form thống kê
        public static frmThongKeHoaDon frmThongKeHoaDon = null;


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmLogin = new frmLogin();
            //frmCauHinh = new frmKetNoi();
            //frmMain = new frmMain();
            Application.Run(frmLogin);
        }
    }
}
