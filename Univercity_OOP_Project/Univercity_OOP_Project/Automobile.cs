using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Univercity_OOP_Project
{
    public abstract class Automobile
    {
        public void init_data(string model, int manufacture_year, double start_price)
        {
            this.model=model;
            this.manufacture_year = manufacture_year;
            this.start_price = start_price;
        }
        abstract public void calculate_real_price();
        public string MODEL
        {
            get { return model; }
        }
        public int MANUFACTURE_YEAR
        {
            get { return manufacture_year; }
        }
        public double START_PRICE
        {
            get { return start_price; }
        }
        public double REAL_PRICE
        {
            get { return real_price; }
        }
        public string TYPE
        {
            get { return type; }
        }
        protected string model;
        protected int manufacture_year;
        protected double start_price;
        protected double real_price;
        protected string type = "Auto";
    }
}
