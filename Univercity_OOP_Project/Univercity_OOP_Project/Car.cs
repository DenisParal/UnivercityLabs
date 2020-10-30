using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Univercity_OOP_Project
{
    public class Car:Automobile
    {
        public Car()
        {
            type = "Car";
        }
        public override void calculate_real_price()
        {
            double price = start_price;
            for(int i = manufacture_year; i < DateTime.Now.Year; i++)
            {
                price = price * 0.9;
            }
            real_price = Math.Round(price, 2);
        }
    }
}
