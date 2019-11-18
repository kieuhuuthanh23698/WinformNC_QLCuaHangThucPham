using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QL_CuaHangNongSan
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static Form main;
        public static Form login;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            main = new frmKetNoi();
            main.Show();
            Application.Run();
        }
    }
}
