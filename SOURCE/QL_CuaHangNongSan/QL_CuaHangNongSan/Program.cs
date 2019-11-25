using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QL_CuaHangNongSan
{
    static class Program
    {
        public static frmLogin frmLogin = null;
        public static frmKetNoi frmCauHinh = null;
        public static frmMain frmMain = null;
        //sub form
        public static frmHoaDon frmHoaDon = null;

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
