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
    public partial class FrmDataSet_結構 : Form
    {
        public FrmDataSet_結構()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.customersTableAdapter1.Fill(this.nwDataSet1.Customers);
            this.categoriesTableAdapter1.Fill(this.nwDataSet1.Categories);
            this.productsTableAdapter1.Fill(this.nwDataSet1.Products);

            this.dataGridView1.DataSource = nwDataSet1.Customers;
            this.dataGridView2.DataSource = nwDataSet1.Categories;
            this.dataGridView3.DataSource = nwDataSet1.Products;

            listBox1.Items.Clear();
            for (int i = 0; i < nwDataSet1.Tables.Count; i++)
            {
                DataTable table = this.nwDataSet1.Tables[i];
                listBox1.Items.Add(table.TableName);
                //listBox2.Items.Add(nwDataSet1.Tables[i].TableName);

                //取得 schema
                string str = "";
                for (int column = 0; column < table.Columns.Count; column++)
                {
                    str += $"{table.Columns[column].ColumnName,-60}";
                }
                listBox1.Items.Add(str);
                listBox1.Items.Add("==========================================================");

                //nwDataSet1.Tables[i].Columns


                //table row
                string str2 = "";
                //int max = 0;
                const int max = 60;
                for (int row = 0; row < table.Rows.Count; row++)
                {
                    str2 = "";
                    for (int column = 0; column < table.Columns.Count; column++)
                    {
                        //MessageBox.Show(nwDataSet1.Products[0].ProductName);
                        str2 += $"{table.Rows[row][column],-max}";

                    }

                    listBox1.Items.Add(str2);

                }
                listBox1.Items.Add("==========================================================");
            }
        }
    }
}
