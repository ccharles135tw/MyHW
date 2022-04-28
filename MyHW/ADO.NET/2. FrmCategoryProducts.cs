using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MyHW
{
    public partial class FrmCategoryProducts : Form
    {
        public FrmCategoryProducts()
        {
            InitializeComponent();

            //connected: add comboboxitem 
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Northwind;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select CategoryName from Categories", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                comboBox1.Items.Add(reader["categoryname"]);
            }
            conn.Close();

            //disconnected 1 :add comboboxitem
            SqlConnection conn1 = new SqlConnection("Data Source=.;Initial Catalog=Northwind;Integrated Security=True");
            SqlDataAdapter adapter = new SqlDataAdapter("select CategoryName from Categories", conn1);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                comboBox2.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }

            //disconnect 2 :add comboboxitem
            this.categoriesTableAdapter1.Fill(this.nwDataSet1.Categories);
            for (int i = 0; i < nwDataSet1.Categories.Rows.Count; i++)
            {
                comboBox3.Items.Add(nwDataSet1.Categories.Rows[i][1].ToString());
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Northwind;Integrated Security=True");
            conn.Open();
            //v1 if

            //SqlCommand cmd = new SqlCommand("select * from Categories join Products on Categories.CategoryID = Products.CategoryID order by Categories.CategoryID", conn);
            //SqlDataReader reader = cmd.ExecuteReader();
            //listBox1.Items.Clear();
            //while (reader.Read())
            //{
            //    if (reader["categoryname"].ToString() == comboBox1.SelectedItem.ToString())
            //    {
            //        listBox1.Items.Add(reader["productname"]);
            //    }
            //}

            //
            //v2 where

            string str1 = $"'{comboBox1.SelectedItem.ToString()}'",
                       str2 = "select * from Categories join Products on Categories.CategoryID = Products.CategoryID where Categories.CategoryName = ";
            SqlCommand cmd = new SqlCommand(str2+str1, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            listBox1.Items.Clear();
            while (reader.Read())
            { 
                listBox1.Items.Add(reader["productname"]);
            }

            //

            conn.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Northwind;Integrated Security=True");

            //v1 if

            //SqlDataAdapter adapter = new SqlDataAdapter("select ProductName,categoryname from Categories join Products on Categories.CategoryID = Products.CategoryID order by Categories.CategoryID", conn);
            //DataSet ds = new DataSet();
            //adapter.Fill(ds);
            //listBox2.Items.Clear();
            //for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            //{
            //    if (comboBox2.SelectedItem.ToString() == ds.Tables[0].Rows[i][1].ToString())
            //        listBox2.Items.Add(ds.Tables[0].Rows[i]["ProductName"].ToString());
            //}

            //
            //v2 where

            string str1 = $"'{comboBox2.SelectedItem.ToString()}'",
                       str2 = "select * from Categories join Products on Categories.CategoryID = Products.CategoryID where Categories.CategoryName = ";
            SqlDataAdapter adapter = new SqlDataAdapter(str2 + str1, conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            listBox2.Items.Clear();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                listBox2.Items.Add(ds.Tables[0].Rows[i]["ProductName"].ToString());
            }

            //
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox3.Items.Clear();
            //v1

            //productsTableAdapter1.Fill(nwDataSet2.Products);
            //string ID="";
            //for (int i = 0; i < nwDataSet1.Tables[0].Rows.Count; i++)
            //{
            //    if (nwDataSet1.Categories.Rows[i]["CategoryName"].ToString() == comboBox3.SelectedItem.ToString())
            //    {
            //        ID = nwDataSet1.Categories.Rows[i]["CategoryID"].ToString();
            //    }
            //}
            //for (int j = 0; j < nwDataSet2.Products.Rows.Count; j++)
            //{
            //    if (ID == nwDataSet2.Products.Rows[j]["CategoryID"].ToString())
            //    {
            //        listBox3.Items.Add(nwDataSet2.Products.Rows[j]["ProductName"].ToString());
            //    }
            //}

            //
            //v2

            string str = $"{comboBox3.Text}";
            nwDataSet2.EnforceConstraints = false;
            productsTableAdapter1.FillBy(nwDataSet2.Products,str); 
            for (int i = 0; i < nwDataSet2.Products.Rows.Count; i++)
            {
                listBox3.Items.Add(nwDataSet2.Products.Rows[i]["ProductName"].ToString());
            }

            //
        }
    }
}
