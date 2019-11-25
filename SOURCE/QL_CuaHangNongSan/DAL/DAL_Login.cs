using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DAL
{
    public enum LoginResult
    {
        Disabled, Invalid, Success
    }

    public class DAL_Login
    {
        SeasonalFoodsDataContext context = Context.getInstance();

        public int checkConfig()
        {
            if (DAL.Properties.Settings.Default.SeasonalFoodsConnectionString == "")
                return 1;
            try
            {
                SqlConnection conn = new SqlConnection(DAL.Properties.Settings.Default.SeasonalFoodsConnectionString);
                conn.Open();
                return 0;
            }
            catch (Exception)
            {
                return 2;
            }
        }

        public LoginResult checkUser(string userName, string passWord)
        {
            TAI_KHOAN result = context.TAI_KHOANs.Where(tk => tk.TENDN == userName && tk.MATKHAU == passWord).FirstOrDefault();
            if (result == null)
                return LoginResult.Invalid;
            else
            {
                if(result.HOATDONG == "False")
                    return LoginResult.Disabled; 
                return LoginResult.Success;
            }
        }

        public TAI_KHOAN getTaiKhoan(string userName, string passWord)
        {
            TAI_KHOAN result = context.TAI_KHOANs.Where(tk => tk.TENDN == userName && tk.MATKHAU == passWord).FirstOrDefault();
            return result;
        }
    }
}
