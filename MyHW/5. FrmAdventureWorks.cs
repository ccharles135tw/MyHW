
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
    public partial class FrmAdventureWorks : Form
    {
        public FrmAdventureWorks()
        {
            InitializeComponent();
            aWDataSet.EnforceConstraints = false;
            productPhotoTableAdapter.comboFillByYear(aWDataSet.ProductPhoto);
            
            for (int i = 0; i < aWDataSet.ProductPhoto.Rows.Count; i++)
            {
                comboBox1.Items.Add(aWDataSet.ProductPhoto.Rows[i]["year"]);
            }
        }

        private void FrmAdventureWorks_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'aWDataSet.ProductPhoto' 資料表。您可以視需要進行移動或移除。
            this.productPhotoTableAdapter.Fill(this.aWDataSet.ProductPhoto);

        }

        private void productPhotoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productPhotoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aWDataSet);

        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.productPhotoBindingSource.MoveFirst();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.productPhotoBindingSource.MovePrevious();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.productPhotoBindingSource.MoveNext();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.productPhotoBindingSource.MoveLast();
        }

        private void productPhotoBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            label4.Text = $"{this.productPhotoBindingSource.Position + 1}/{this.productPhotoBindingSource.Count}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime fromDate = dateTimePicker1.Value;
            DateTime toDate = dateTimePicker2.Value;
            productPhotoTableAdapter.FillByDate(aWDataSet.ProductPhoto, fromDate, toDate);
            productPhotoBindingSource.DataSource = aWDataSet.ProductPhoto;
            productPhotoDataGridView.DataSource = productPhotoBindingSource;
            productPhotoBindingNavigator.BindingSource = productPhotoBindingSource;
        }
        bool flag = true;

        private void button2_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                productPhotoDataGridView.Sort(productPhotoDataGridView.Columns[3], ListSortDirection.Descending);
                flag = !flag;
            }
            else
            {
                productPhotoDataGridView.Sort(productPhotoDataGridView.Columns[3], ListSortDirection.Ascending);
                flag = !flag;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            productPhotoTableAdapter.FillByYear(aWDataSet.ProductPhoto,decimal.Parse(comboBox1.Text));
            productPhotoBindingSource.DataSource = aWDataSet.ProductPhoto;
            productPhotoDataGridView.DataSource = productPhotoBindingSource;
            productPhotoBindingNavigator.BindingSource = productPhotoBindingSource;
        }
    }
}
