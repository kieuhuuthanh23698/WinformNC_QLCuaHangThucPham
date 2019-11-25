using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
    public class DAL_HoaDon
    {
        SeasonalFoodsDataContext context = Context.getInstance();

        public List<HANGHOA> getHangHoa(string loaiHang) {
            var lstHangHoa = context.getHangHoa_Loai(loaiHang);
            var kq = lstHangHoa.ToList().ConvertAll(t => new HANGHOA {
                MASP = t.MASP,
                TENSP = t.TENSP,
                GIA_BAN = (double)t.GIA_BAN,
                DVT = t.DVT,
                SOLUONG = t.SOLUONG
            });
            return kq.ToList<HANGHOA>();
        }

        public List<DANH_MUC_SP> getDanhMuc()
        {
            return context.DANH_MUC_SPs.ToList();
        }

        public List<HANGHOA> searchHangHoa(string valueSearch)
        {
            var lstHangHoa = context.HANGHOAs.Where(t => t.TENSP.Contains(valueSearch) || t.MASP == valueSearch || t.MALOAI == valueSearch);
            var kq = lstHangHoa.ToList().ConvertAll(t => new HANGHOA
            {
                MASP = t.MASP,
                TENSP = t.TENSP,
                GIA_BAN = (double)t.GIA_BAN,
                DVT = t.DVT,
                SOLUONG = t.SOLUONG
            });
            return kq.ToList<HANGHOA>();
        }

        public int getSoLuongHoaDon() {
           
        }
    }
}
