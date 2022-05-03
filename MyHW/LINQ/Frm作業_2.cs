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
    public partial class Frm作業_2 : Form
    {
        public Frm作業_2()
        {
            InitializeComponent();
            this.productPhotoTableAdapter1.Fill(awDataSet1.ProductPhoto);
            GetYear();
            comboBox2.SelectedIndex = comboBox3.SelectedIndex = 0;
        }

        void GetYear()
        {
            var a = from i in awDataSet1.ProductPhoto
                    select i.ModifiedDate.Year;
            foreach(int i in a)
            {
                if (comboBox3.Items.Contains(i))
                {
                    continue;
                }
                comboBox3.Items.Add(i);
            }

        }

        void ToList_Binding(IEnumerable<AWDataSet.ProductPhotoRow> a)
        {
            pictureBox1.DataBindings.Clear();
            bindingSource1.DataSource = a.ToList();
            dataGridView1.DataSource = bindingSource1.DataSource;
            pictureBox1.DataBindings.Add("Image", bindingSource1, "LargePhoto", true);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            IEnumerable<AWDataSet.ProductPhotoRow> a = from i in awDataSet1.ProductPhoto
                                                       select i;
            ToList_Binding(a);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bindingSource1.Position = dataGridView1.CurrentCell.RowIndex;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var a = from i in awDataSet1.ProductPhoto
                    where dateTimePicker1.Value.Date <= i.ModifiedDate.Date && dateTimePicker2.Value.Date >= i.ModifiedDate.Date
                    select i;
            ToList_Binding(a);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var a = from i in awDataSet1.ProductPhoto
                    where i.ModifiedDate.Year == (int)comboBox3.SelectedItem
                    select i;
            ToList_Binding(a);
        }
        private void button10_Click(object sender, EventArgs e)
        {
            int start = 0, end = 0;
            if(comboBox2.SelectedItem.ToString() == "第一季")
            {
                start = 1;
                end = 3;
            }
            else if (comboBox2.SelectedItem.ToString() == "第二季")
            {
                start = 4;
                end = 6;
            }
            else if (comboBox2.SelectedItem.ToString() == "第三季")
            {
                start = 7;
                end = 9;
            }
            else
            {
                start = 10;
                end = 12;
            }
            var a = from i in awDataSet1.ProductPhoto
                    where i.ModifiedDate.Month >= start && end >= i.ModifiedDate.Month
                    select i;
            ToList_Binding(a);
            MessageBox.Show($"{comboBox2.SelectedItem}，共 {a.Count()} 筆");
        }
    }
}
