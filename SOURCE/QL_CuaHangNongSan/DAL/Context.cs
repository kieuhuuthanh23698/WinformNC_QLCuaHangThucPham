using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
    public static class Context
    {
        public static SeasonalFoodsDataContext context;

        public static SeasonalFoodsDataContext getInstance() {
            if (context == null)
                context = new SeasonalFoodsDataContext();
            return context;
        }

    }
}
