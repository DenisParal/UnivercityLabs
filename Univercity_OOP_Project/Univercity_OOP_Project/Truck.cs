using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Univercity_OOP_Project
{
    public class Truck:Automobile
    {
        public Truck()
        {
            type = "Truck";
        }
        public override void calculate_real_price()
        {
            double price = start_price;
            int year = DateTime.Now.Year;
            if (year - manufacture_year <= 3)
            {
                price = price * 0.9;
            }else if(year - manufacture_year <= 10)
            {
                price = price * 0.8;
            }
            else
            {
                price = price * 0.7;
            }
            real_price = Math.Round(price,2);
        }
    }
}
