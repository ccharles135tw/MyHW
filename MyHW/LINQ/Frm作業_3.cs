using MyHW;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyHomeWork
{
    public partial class Frm作業_3 : Form
    {
        public Frm作業_3()
        {
            InitializeComponent();
        }
        void ClearAll()
        {
            dataGridView1.DataSource = null;
            dataGridView2.DataSource = null;
            treeView1.Nodes.Clear();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            ClearAll();
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            TreeNode x = treeView1.Nodes.Add("除3餘數為0");
            TreeNode y = treeView1.Nodes.Add("除3餘數為1");
            TreeNode z = treeView1.Nodes.Add("除3餘數為2");
            for (int i = 0; i < nums.Length; i++)
            {
                if (i % 3 == 0)
                {
                    x.Nodes.Add(nums[i].ToString());
                }
                else if (i % 3 == 1)
                {
                    y.Nodes.Add(nums[i].ToString());
                }
                else
                {
                    z.Nodes.Add(nums[i].ToString());
                }
            }
        }

        private void button38_Click(object sender, EventArgs e)
        {
            ClearAll();
            DirectoryInfo dir = new DirectoryInfo(@"C:\Windows");
            FileInfo[] files = dir.GetFiles();
            var a = from i in files
                    orderby i.Length descending
                    group i by FileSize(i.Length);
            foreach (var i in a)
            {
                TreeNode x = treeView1.Nodes.Add(i.Key.ToString());
                foreach (var j in i)
                {
                    x.Nodes.Add($"{j.Name}, Size : {j.Length}");
                }
            }
        }
        string FileSize(long x)
        {
            if (x.ToString().Length > 6)
            {
                return "Large";
            }
            else if (x.ToString().Length > 5)
            {
                return "Medium";
            }
            else
            {
                return "Small";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ClearAll();
            DirectoryInfo dir = new DirectoryInfo(@"C:\Windows");
            FileInfo[] files = dir.GetFiles();
            var a = from i in files
                    orderby i.CreationTime.Year descending
                    group i by i.CreationTime.Year >= System.DateTime.Now.Year - 1 ? "一年內" : "一年前";

            foreach (var i in a)
            {
                TreeNode x = treeView1.Nodes.Add(i.Key.ToString());
                foreach (var j in i)
                {
                    x.Nodes.Add($"{j.Name}, CreationTime : {j.CreationTime}");
                }
            }
        }
        NorthwindEntities dbcontext = new NorthwindEntities();

        private void button8_Click(object sender, EventArgs e)
        {
            ClearAll();
            int prod_count = dbcontext.Products.Count();
            int count = 0;
            var a = dbcontext.Products.AsEnumerable().OrderBy(i => i.UnitPrice).GroupBy(i=>Price(prod_count, ref count));
            dataGridView1.DataSource = a.ToList();
            count = 0;
            foreach (var i in a)
            {
                TreeNode x = treeView1.Nodes.Add(i.Key.ToString());
                foreach (var j in i)
                {
                    x.Nodes.Add($"{j.ProductName}, Price : {j.UnitPrice}");
                }
            }

            dataGridView2.DataSource = (from i in dbcontext.Products
                                        orderby i.UnitPrice ascending
                                        select i).ToList();
        }
        string Price(int prod_count, ref int count)
        {
            if (count < prod_count / 3)
            {
                count++;
                return "低價";
            }
            else if (count < (prod_count / 3) * 2)
            {
                count++;
                return "中價";
            }
            else
            {
                return "高價";
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            ClearAll();
            var a = from i in dbcontext.Orders
                    group i by i.OrderDate.Value.Year into j
                    select new { Year = j.Key, Count = j.Count(), Group = j };
            foreach (var i in a)
            {
                TreeNode x = treeView1.Nodes.Add(i.Year.ToString());
                foreach (var j in i.Group)
                {
                    x.Nodes.Add($"{j.CustomerID}, OrderDate : {j.OrderDate}");
                }
            }
            dataGridView1.DataSource = a.ToList();
            dataGridView2.DataSource = (from i in dbcontext.Orders
                                        select i).ToList();

        }

        private void button10_Click(object sender, EventArgs e)
        {
            ClearAll();
            var a = from i in dbcontext.Orders
                    group i by new { i.OrderDate.Value.Year, i.OrderDate.Value.Month } into j
                    select new { Year_Month = j.Key, Group = j };
            dataGridView1.DataSource = a.ToList();
            foreach (var i in a)
            {
                TreeNode x = treeView1.Nodes.Add($"{i.Year_Month.Year}年 - {i.Year_Month.Month}月");
                foreach (var j in i.Group)
                {
                    x.Nodes.Add($"{j.CustomerID}, OrderDate : {j.OrderDate}");
                }
            }
            dataGridView2.DataSource = (from i in dbcontext.Orders
                                        select i).ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClearAll();
            var a = from i in dbcontext.Orders
                    from j in i.Order_Details
                    select new
                    {
                        UnitPrice = j.UnitPrice,
                        Quantity = j.Quantity,
                        Discount = (1 - j.Discount),
                        Year = i.OrderDate.Value.Year
                    };
            dataGridView1.DataSource = a.ToList();

            var b = from i in dbcontext.Order_Details.AsEnumerable()
                    group i by i.Order.OrderDate.Value.Year into j
                    orderby j.Sum(n => n.UnitPrice * n.Quantity * (decimal)(1 - n.Discount)) descending
                    select new { Year = j.Key, Total = j.Sum(n => n.UnitPrice * n.Quantity * (decimal)(1 - n.Discount)) };
            dataGridView2.DataSource = b.ToList();

            foreach (var i in b)
            {
                TreeNode x = treeView1.Nodes.Add($"{i.Year}年");
                x.Nodes.Add($"{i.Total:c2}");
            }

            MessageBox.Show($"總銷售金額 :{a.AsEnumerable().Sum(i => i.UnitPrice * i.Quantity * (decimal)i.Discount):c2}");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearAll();
            var a = from i in dbcontext.Order_Details.AsEnumerable()
                    group i by i.Order.EmployeeID into j
                    orderby j.Sum(n => n.UnitPrice * n.Quantity * (decimal)(1 - n.Discount)) descending
                    select new { j.Key, Total = j.Sum(n => n.UnitPrice * n.Quantity * (decimal)(1 - n.Discount))};
            dataGridView1.DataSource = a.Take(5).ToList();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ClearAll();
            dataGridView1.DataSource = dbcontext.Products.OrderByDescending(p => p.UnitPrice).Take(5).ToList();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ClearAll();
            bool result = dbcontext.Products.Any(p => p.UnitPrice > 300);
            MessageBox.Show(result.ToString());
        }
    }
}
