using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALKhuyenMai
    {
        SeasonalFoodsDataContext context = new SeasonalFoodsDataContext();

        //private bool isExisM(string maHH)
        //{
        //    return context.HANGHOAs.Count(t => t.MASP.Equals(maHH)) > 0 ? true : false;
        //}

        //public string taoMaHangHoa(string maLoai)
        //{
        //    string maHH = "";
        //    int count = 1;
        //    do
        //    {
        //        if (!isExisHH(maLoai + "_" + count))
        //        {
        //            maHH = maLoai + "_" + count;
        //            break;
        //        }
        //        count++;
        //    } while (count != 0);
        //    return maHH;
        //}
    }
}
