using MyHW.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyHW
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadData();
            
        }
        void NodeSelected_Son()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.MyNWConnectionString))
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand();
                    command.CommandText = $"select * from Customers where City = '{this.treeView1.SelectedNode.Text}'";
                    command.Connection = conn;

                    SqlDataReader reader = command.ExecuteReader();
                    this.dataGridView1.DataSource = null;
                    this.dataGridView1.Rows.Clear();
                    int cnt = 0;
                    while (reader.Read())
                    {
                        dataGridView1.Rows.Add();
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            dataGridView1.Rows[cnt].Cells[i].Value = reader[i];
                        }
                        cnt++;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void NodeSelected_Father()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.MyNWConnectionString))
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand();
                    command.CommandText = $"select * from Customers where Country = '{this.treeView1.SelectedNode.Text}'";
                    command.Connection = conn;

                    SqlDataReader reader = command.ExecuteReader();
                    this.dataGridView1.DataSource = null;
                    this.dataGridView1.Rows.Clear();
                    int cnt = 0;
                    while (reader.Read())
                    {
                        dataGridView1.Rows.Add();
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            dataGridView1.Rows[cnt].Cells[i].Value = reader[i];
                        }
                        cnt++;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void LoadData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.MyNWConnectionString))
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand();
                    command.CommandText = "select distinct country,city from Customers";
                    command.Connection = conn;

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        treeView1.BeginUpdate();
                        if (treeView1.Nodes.ContainsKey(reader[0].ToString()))
                        {
                            treeView1.Nodes[reader[0].ToString()].Nodes.Add(reader[1].ToString());
                            continue;
                        }
                        else
                        {
                            treeView1.Nodes.Add(reader[0].ToString(), reader[0].ToString());
                            treeView1.Nodes[reader[0].ToString()].Nodes.Add(reader[1].ToString());
                        }
                        treeView1.EndUpdate();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'nWDataSet.Customers' 資料表。您可以視需要進行移動或移除。
            this.customersTableAdapter.Fill(this.nWDataSet.Customers);
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if(treeView1.SelectedNode.Level == 0)
            {
                NodeSelected_Father();
            }
            else
            {
                NodeSelected_Son();
            }
        }
    }
}
