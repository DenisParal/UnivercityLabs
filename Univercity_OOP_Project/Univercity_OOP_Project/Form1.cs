using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Univercity_OOP_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void clear_all_text()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void try_add(Automobile auto)
        {
            bool identity = true;
            foreach (var item in list)
            {
                if (item == auto)
                {
                    identity = false;
                    break;
                }
            }
            if (identity)
            {
                auto.calculate_real_price();
                list.Add(auto);
                string record=auto.TYPE+" "+auto.MODEL+" "+auto.MANUFACTURE_YEAR.ToString()+" "+auto.START_PRICE.ToString()+" "+auto.REAL_PRICE.ToString();
                listBox1.Items.Add(record);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0 || textBox2.Text.Length==0 || textBox3.Text.Length==0 || comboBox1.SelectedItem==null)
            {
                MessageBox.Show("Please, fill all textboxes");
                return;
            }
            string auto_type = comboBox1.SelectedItem.ToString();
            string model = textBox1.Text;
            int year = Convert.ToInt32(textBox2.Text);
            double price = Convert.ToDouble(textBox3.Text);
            clear_all_text();
            Automobile auto;
            if (auto_type == "Car")
            {
                auto = new Car();
            }
            else
            {
                auto = new Truck();
            }
            auto.init_data(model, year, price);
            try_add(auto);
        }

        private List<Automobile> list = new List<Automobile>();

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == 8)
                return;
            else
                e.Handled = true;
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == 8)
                return;
            else
                e.Handled = true;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || (e.KeyChar > 64 && e.KeyChar < 91) || (e.KeyChar > 96 && e.KeyChar < 123) || e.KeyChar == 8)
                return;
            else
                e.Handled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox4.Text.Length != 0)
            {
                int index = Convert.ToInt32(textBox4.Text)-1;
                if (index > listBox1.Items.Count)
                {
                    MessageBox.Show("Index is bigger than auto count");
                    return;
                }
                if(index < 0)
                {
                    MessageBox.Show("Incorrect index");
                    return;
                }
                textBox4.Clear();
                list.RemoveAt(index);
                listBox1.Items.RemoveAt(index);
            }
            else
            {
                list.RemoveAt(listBox1.SelectedIndex);
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == 8)
                return;
            else
                e.Handled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            list.Sort(new comparer_by_year());
            listBox1.Items.Clear();
            foreach (var auto in list)
            {
                string record = auto.TYPE + " " + auto.MODEL + " " + auto.MANUFACTURE_YEAR.ToString() + " " + auto.START_PRICE.ToString() + " " + auto.REAL_PRICE.ToString();
                listBox1.Items.Add(record);
            }
        }

        public void add_in_list(Automobile auto)
        {
            string record = auto.TYPE + " " + auto.MODEL + " " + auto.MANUFACTURE_YEAR.ToString() + " " + auto.START_PRICE.ToString() + " " + auto.REAL_PRICE.ToString();
            listBox1.Items.Add(record);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            list.Sort(new comparer_by_price());
            listBox1.Items.Clear();
            foreach (var auto in list)
            {
                add_in_list(auto);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            list.Add(list[index]);
            add_in_list(list[list.Count-1]);
        }
    }
}
