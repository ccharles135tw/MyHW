using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyHW
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            Frm標準練習 f = new Frm標準練習();
            f.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(f);
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            FrmCategoryProducts f = new FrmCategoryProducts();
            f.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(f);
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            Frmhw3 f = new Frmhw3();
            f.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(f);
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            FrmDataSet_結構 f = new FrmDataSet_結構();
            f.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(f);
            f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            FrmAdventureWorks f = new FrmAdventureWorks();
            f.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(f);
            f.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            FrmMyAlbum_V1 f = new FrmMyAlbum_V1();
            f.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(f);
            f.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            FrmMyAlbum_V2 f = new FrmMyAlbum_V2();
            f.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(f);
            f.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            FrmCustomers f = new FrmCustomers();
            f.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(f);
            f.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            Form1 f = new Form1();
            f.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(f);
            f.Show();
        }
    }

}
