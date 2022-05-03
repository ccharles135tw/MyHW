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

        private void button4_Click(object sender, EventArgs e)
        {
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
            DirectoryInfo dir = new DirectoryInfo(@"C:\Windows");
            FileInfo[] files = dir.GetFiles();
            var a = from i in files
                    orderby i.Length descending
                    group i by FileSize(i.Length);
            foreach(var i in a)
            {
                TreeNode x = treeView1.Nodes.Add(i.Key.ToString());
                foreach(var j in i)
                {
                    x.Nodes.Add($"{j.Name}, Size : {j.Length}");
                }
            }
        }
        string FileSize(long x)
        {
            if(x.ToString().Length > 6)
            {
                return "Large";
            }
            else if(x.ToString().Length > 5)
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
            DirectoryInfo dir = new DirectoryInfo(@"C:\Windows");
            FileInfo[] files = dir.GetFiles();
            var a = from i in files
                    orderby i.CreationTime.Year descending
                    group i by i.CreationTime.Year >= System.DateTime.Now.Year - 1? "一年內":"一年前";

            foreach (var i in a)
            {
                TreeNode x = treeView1.Nodes.Add(i.Key.ToString());
                foreach (var j in i)
                {
                    x.Nodes.Add($"{j.Name}, CreationTime : {j.CreationTime}");
                }
            }
        }
    }
}
