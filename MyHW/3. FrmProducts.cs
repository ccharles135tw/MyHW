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
    public partial class Frmhw3 : Form
    {
        public Frmhw3()
        {
            InitializeComponent();
        }
        int cnt = 0;
        private void productsBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.productsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.nWDataSet);
        }

        private void Frmhw3_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'nWDataSet.Products' 資料表。您可以視需要進行移動或移除。
            this.productsTableAdapter.Fill(this.nWDataSet.Products);

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            productsBindingSource.MoveFirst();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.productsBindingSource.MovePrevious();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.productsBindingSource.MoveNext();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.productsBindingSource.MoveLast();
        }

        private void productsBindingSource_CurrentChanged_1(object sender, EventArgs e)
        {
            label4.Text = $"{this.productsBindingSource.Position + 1}/{this.productsBindingSource.Count}";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            productsTableAdapter.FillBySearch(nWDataSet.Products,textBox3.Text);
            productsBindingSource.DataSource = nWDataSet.Products;
            productsDataGridView.DataSource = productsBindingSource;
            productsBindingNavigator.BindingSource = productsBindingSource;
            label5.Text = $"結果   {nWDataSet.Products.Count}   筆";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            productsTableAdapter.FillByUnitPrice(nWDataSet.Products,decimal.Parse(textBox1.Text), decimal.Parse(textBox2.Text));
            productsBindingSource.DataSource = nWDataSet.Products;
            productsDataGridView.DataSource = productsBindingSource;
            productsBindingNavigator.BindingSource = productsBindingSource;
            label5.Text = $"結果   {nWDataSet.Products.Count}   筆";
        }

    }
}
