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
    public partial class FrmCustomers : Form
    {
        public FrmCustomers()
        {
            InitializeComponent();
            comboBox1.Items.Add("All Countries");
            comboBox1.SelectedIndex = 0;
            LoadCountrytoCombobox();
            LoadAllCountry();
            getcolumns();
            
        }
        List<string> AllCountryName = new List<string>();
        void GroupByCountry()
        {
            this.listView1.Items.Clear();
            this.listView1.View = View.Details;
            foreach (string i in AllCountryName)
            {
                ListViewGroup lvg1 = new ListViewGroup();
                lvg1.Header = i;
                lvg1.Name = i;
                listView1.Groups.Add(lvg1);
            }
            if(comboBox1.SelectedItem.ToString() == "All Countries")
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(Settings.Default.MyNWConnectionString))
                    {
                        conn.Open();
                        SqlCommand command = new SqlCommand();
                        command.CommandText = $"select * from Customers";
                        command.Connection = conn;

                        SqlDataReader reader = command.ExecuteReader();
                        //listView1.Items.Clear();
                        while (reader.Read())
                        {
                            ListViewItem lvi = listView1.Items.Add(reader[0].ToString());
                            if (lvi.Index % 2 == 0)
                            {
                                lvi.BackColor = Color.Gray;
                            }
                            else
                            {
                                lvi.BackColor = Color.Blue;
                            }

                            for (int i = 1; i < reader.FieldCount; i++)
                            {

                                if (reader.IsDBNull(i))
                                {
                                    lvi.SubItems.Add("空值");
                                }
                                else
                                {
                                    lvi.SubItems.Add(reader[i].ToString());
                                }
                            }
                            lvi.Group = this.listView1.Groups[lvi.SubItems[8].Text];
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(Settings.Default.MyNWConnectionString))
                    {
                        conn.Open();
                        SqlCommand command = new SqlCommand();
                        command.CommandText = $"select * from Customers where country = '{comboBox1.SelectedItem}'";
                        command.Connection = conn;

                        SqlDataReader reader = command.ExecuteReader();
                        listView1.Items.Clear();
                        Random ran = new Random();
                        while (reader.Read())
                        {
                            ListViewItem lvi = listView1.Items.Add(reader[0].ToString());
                            if (lvi.Index % 2 == 0)
                            {
                                lvi.BackColor = Color.Gray;
                            }
                            else
                            {
                                lvi.BackColor = Color.Blue;
                            }

                            for (int i = 1; i < reader.FieldCount; i++)
                            {

                                if (reader.IsDBNull(i))
                                {
                                    lvi.SubItems.Add("空值");
                                }
                                else
                                {
                                    lvi.SubItems.Add(reader[i].ToString());
                                }
                            }
                            lvi.Group = this.listView1.Groups[lvi.SubItems[8].Text];
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }


        }

        private void LoadAllCountry()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.MyNWConnectionString))
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand();
                    command.CommandText = "select * from Customers";
                    command.Connection = conn;

                    SqlDataReader reader = command.ExecuteReader();
                    listView1.Items.Clear();
                    Random ran = new Random();
                    while (reader.Read())
                    {
                        ListViewItem lvi = listView1.Items.Add(reader[0].ToString());
                        if (lvi.Index % 2 == 0)
                        {
                            lvi.BackColor = Color.Gray;
                        }
                        else
                        {
                            lvi.BackColor = Color.Blue;
                        }

                        for (int i = 1; i < reader.FieldCount; i++)
                        {

                            if (reader.IsDBNull(i))
                            {
                                lvi.SubItems.Add("空值");
                            }
                            else
                            {
                                lvi.SubItems.Add(reader[i].ToString());
                            }

                        }
                    }
                    this.listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void getcolumns()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.MyNWConnectionString))
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand("select * from Customers", conn);
                    SqlDataReader reader = command.ExecuteReader();
                    DataTable table = reader.GetSchemaTable();

                    for (int i = 0; i < table.Rows.Count; i++)
                    {
                        this.listView1.Columns.Add(table.Rows[i][0].ToString());
                    }
                    this.listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LoadCountrytoCombobox()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.MyNWConnectionString))
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand("select distinct Country from Customers", conn);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        comboBox1.Items.Add(reader["country"]);
                        AllCountryName.Add(reader["country"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "All Countries")
            {
                LoadAllCountry();
            }
            else
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(Settings.Default.MyNWConnectionString))
                    {
                        conn.Open();
                        SqlCommand command = new SqlCommand();
                        command.CommandText = $"select * from Customers where country = '{comboBox1.SelectedItem}'";
                        command.Connection = conn;

                        SqlDataReader reader = command.ExecuteReader();
                        listView1.Items.Clear();
                        Random ran = new Random();
                        while (reader.Read())
                        {
                            ListViewItem lvi = listView1.Items.Add(reader[0].ToString());
                            if (lvi.Index % 2 == 0)
                            {
                                lvi.BackColor = Color.Gray;
                            }
                            else
                            {
                                lvi.BackColor = Color.Blue;
                            }

                            for (int i = 1; i < reader.FieldCount; i++)
                            {

                                if (reader.IsDBNull(i))
                                {
                                    lvi.SubItems.Add("空值");
                                }
                                else
                                {
                                    lvi.SubItems.Add(reader[i].ToString());
                                }

                            }
                        }
                        this.listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.listView1.View = View.Details;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.listView1.View = View.LargeIcon;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            this.listView1.View = View.SmallIcon;
        }

        private void customerIDAscToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != 0)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(Settings.Default.MyNWConnectionString))
                    {
                        conn.Open();
                        SqlCommand command = new SqlCommand();
                        command.CommandText = $"select * from Customers where country = '{comboBox1.SelectedItem}' order by CustomerID asc";
                        command.Connection = conn;

                        SqlDataReader reader = command.ExecuteReader();
                        listView1.Items.Clear();
                        Random ran = new Random();
                        while (reader.Read())
                        {
                            ListViewItem lvi = listView1.Items.Add(reader[0].ToString());
                            if (lvi.Index % 2 == 0)
                            {
                                lvi.BackColor = Color.Gray;
                            }
                            else
                            {
                                lvi.BackColor = Color.Blue;
                            }

                            for (int i = 1; i < reader.FieldCount; i++)
                            {

                                if (reader.IsDBNull(i))
                                {
                                    lvi.SubItems.Add("空值");
                                }
                                else
                                {
                                    lvi.SubItems.Add(reader[i].ToString());
                                }

                            }
                        }
                        this.listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(Settings.Default.MyNWConnectionString))
                    {
                        conn.Open();
                        SqlCommand command = new SqlCommand();
                        command.CommandText = $"select * from Customers order by CustomerID asc";
                        command.Connection = conn;

                        SqlDataReader reader = command.ExecuteReader();
                        listView1.Items.Clear();
                        Random ran = new Random();
                        while (reader.Read())
                        {
                            ListViewItem lvi = listView1.Items.Add(reader[0].ToString());
                            if (lvi.Index % 2 == 0)
                            {
                                lvi.BackColor = Color.Gray;
                            }
                            else
                            {
                                lvi.BackColor = Color.Blue;
                            }

                            for (int i = 1; i < reader.FieldCount; i++)
                            {

                                if (reader.IsDBNull(i))
                                {
                                    lvi.SubItems.Add("空值");
                                }
                                else
                                {
                                    lvi.SubItems.Add(reader[i].ToString());
                                }

                            }
                        }
                        this.listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void customerIDDescToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != 0)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(Settings.Default.MyNWConnectionString))
                    {
                        conn.Open();
                        SqlCommand command = new SqlCommand();
                        command.CommandText = $"select * from Customers where country = '{comboBox1.SelectedItem}' order by CustomerID desc";
                        command.Connection = conn;

                        SqlDataReader reader = command.ExecuteReader();
                        listView1.Items.Clear();
                        Random ran = new Random();
                        while (reader.Read())
                        {
                            ListViewItem lvi = listView1.Items.Add(reader[0].ToString());
                            if (lvi.Index % 2 == 0)
                            {
                                lvi.BackColor = Color.Gray;
                            }
                            else
                            {
                                lvi.BackColor = Color.Blue;
                            }

                            for (int i = 1; i < reader.FieldCount; i++)
                            {

                                if (reader.IsDBNull(i))
                                {
                                    lvi.SubItems.Add("空值");
                                }
                                else
                                {
                                    lvi.SubItems.Add(reader[i].ToString());
                                }

                            }
                        }
                        this.listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(Settings.Default.MyNWConnectionString))
                    {
                        conn.Open();
                        SqlCommand command = new SqlCommand();
                        command.CommandText = $"select * from Customers order by CustomerID desc";
                        command.Connection = conn;

                        SqlDataReader reader = command.ExecuteReader();
                        listView1.Items.Clear();
                        Random ran = new Random();
                        while (reader.Read())
                        {
                            ListViewItem lvi = listView1.Items.Add(reader[0].ToString());
                            if (lvi.Index % 2 == 0)
                            {
                                lvi.BackColor = Color.Gray;
                            }
                            else
                            {
                                lvi.BackColor = Color.Blue;
                            }

                            for (int i = 1; i < reader.FieldCount; i++)
                            {

                                if (reader.IsDBNull(i))
                                {
                                    lvi.SubItems.Add("空值");
                                }
                                else
                                {
                                    lvi.SubItems.Add(reader[i].ToString());
                                }

                            }
                        }
                        this.listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void countryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GroupByCountry();
        }

        private void 無ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "All Countries")
            {
                LoadAllCountry();
            }
            else
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(Settings.Default.MyNWConnectionString))
                    {
                        conn.Open();
                        SqlCommand command = new SqlCommand();
                        command.CommandText = $"select * from Customers where country = '{comboBox1.SelectedItem}'";
                        command.Connection = conn;

                        SqlDataReader reader = command.ExecuteReader();
                        listView1.Items.Clear();
                        Random ran = new Random();
                        while (reader.Read())
                        {
                            ListViewItem lvi = listView1.Items.Add(reader[0].ToString());
                            if (lvi.Index % 2 == 0)
                            {
                                lvi.BackColor = Color.Gray;
                            }
                            else
                            {
                                lvi.BackColor = Color.Blue;
                            }

                            for (int i = 1; i < reader.FieldCount; i++)
                            {

                                if (reader.IsDBNull(i))
                                {
                                    lvi.SubItems.Add("空值");
                                }
                                else
                                {
                                    lvi.SubItems.Add(reader[i].ToString());
                                }

                            }
                        }
                        this.listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}

