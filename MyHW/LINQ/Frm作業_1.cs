using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyHomeWork
{
    public partial class Frm作業_1 : Form
    {
        public Frm作業_1()
        {
            InitializeComponent();
            this.ordersTableAdapter1.Fill(nwDataSet2.Orders);
            this.order_DetailsTableAdapter1.Fill(nwDataSet2.Order_Details);
            this.productsTableAdapter1.Fill(nwDataSet2.Products);
            load_combobox_items();
        }
        void load_combobox_items()
        {
            var a = from i in nwDataSet2.Orders
                    select i.OrderDate.Year;

            foreach (var i in a)
            {
                if (comboBox1.Items.Contains(i))
                {
                    continue;
                }
                else
                {
                    comboBox1.Items.Add(i);
                }
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //this.nwDataSet1.Products.Take(10);//Top 10 Skip(10)

            //Distinct()
        }

        private void button14_Click(object sender, EventArgs e)
        {
            System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(@"c:\windows");
            System.IO.FileInfo[] files = dir.GetFiles();

            var a = from i in files
                    where i.Extension == ".log"
                    select i;
            this.dataGridView1.DataSource = a.ToList();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var a = from i in nwDataSet2.Orders
                    where valueNull(i.ItemArray)
                    select i;
            this.dataGridView1.DataSource = a.ToList();

            var b = from j in nwDataSet2.Order_Details
                    select j;
            this.dataGridView2.DataSource = b.ToList();
        }
        bool valueNull(object[] x)
        {
            foreach(object i in x)
            {
                if (i is DBNull)
                {
                    return false;
                }
            }
            return true;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(@"c:\windows");
            System.IO.FileInfo[] files = dir.GetFiles();

            var a = from i in files
                    where i.CreationTime.Year > 2017
                    select i;
            this.dataGridView1.DataSource = a.ToList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(@"c:\windows");
            System.IO.FileInfo[] files = dir.GetFiles();

            var a = from i in files
                    where i.Length > 200000
                    select i;
            this.dataGridView1.DataSource = a.ToList();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var a = from i in nwDataSet2.Orders
                    where !i.IsShipRegionNull() && !i.IsShippedDateNull() && !i.IsShipPostalCodeNull() && i.OrderDate.Year == int.Parse(comboBox1.SelectedItem.ToString())
                    select i;
            this.dataGridView1.DataSource = a.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var a = from i in nwDataSet2.Order_Details
                    where orderID_Exist(i.OrderID)
                    select i;
            this.dataGridView2.DataSource = a.ToList();
        }
        bool orderID_Exist(int x)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (int.Parse(dataGridView1.Rows[i].Cells["OrderID"].Value.ToString()) == x)
                {
                    return true;
                }
            }
            return false;
        }
        int value = 0, value_old = 0;
        bool boolean = true; 
        private void button13_Click_1(object sender, EventArgs e)
        {
            if (value > nwDataSet2.Products.Count - 1)
            {
                value = nwDataSet2.Products.Count - 1;
            }
            if (!boolean)
            {
                value += value_old;
                boolean = !boolean;
            }
            int b = int.Parse(textBox1.Text);
            this.dataGridView1.DataSource = nwDataSet2.Products.Skip(value).Take(b).ToList();
            value += b;
            value_old = b;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (boolean)
            {
                value -= value_old;
                boolean = !boolean;
            }
            int b = int.Parse(textBox1.Text);
            value -= b;
            this.dataGridView1.DataSource = nwDataSet2.Products.Skip(value).Take(b).ToList();
            value_old = b;
            if (value < 0)
            {
                value = 0;
            }
        }
    }
}