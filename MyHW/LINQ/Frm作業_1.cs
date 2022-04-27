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
            load_combobox_items();
        }
        void load_combobox_items()
        {
            var a = from i in nwDataSet2.Orders
                    select new { i.OrderDate.Year };

            foreach (var i in a)
            {
                if (comboBox1.Items.Contains(i.Year))
                {
                    continue;
                }
                else
                {
                    comboBox1.Items.Add(i.Year);
                }
            }
        }
        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

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
                    where !i.IsShipRegionNull() && !i.IsShippedDateNull() && !i.IsShipPostalCodeNull()
                    select i;
            this.dataGridView1.DataSource = a.ToList();

            var b = from j in nwDataSet2.Order_Details
                    select j;
            this.dataGridView2.DataSource = b.ToList();
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
    }
}
