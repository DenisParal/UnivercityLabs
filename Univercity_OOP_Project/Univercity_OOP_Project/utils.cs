using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Univercity_OOP_Project
{
    public class comparer_by_year : Comparer<Automobile>
    {
        public override int Compare(Automobile a1, Automobile a2)
        {
            return a2.MANUFACTURE_YEAR - a1.MANUFACTURE_YEAR;
        } 
    }
    public class comparer_by_price : Comparer<Automobile>
    {
        public override int Compare(Automobile a1, Automobile a2)
        {
            return Convert.ToInt32(a2.REAL_PRICE - a1.REAL_PRICE);
        }
    }
}
