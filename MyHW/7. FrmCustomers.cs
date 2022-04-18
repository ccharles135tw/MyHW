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
            comboBox1.Items.Add("All Country");
            LoadCountrytoCombobox();
            LoadCountrytogroupByStripMenu();
            LoadAllCountry();
            getcolumns();
            comboBox1.SelectedIndex = 0;
        }

        private void LoadCountrytogroupByStripMenu()
        {
            ToolStripMenuItem a = new ToolStripMenuItem();
            a.Text = "All Country";
            a.Tag = "All Country";
            a.Click += C_Click;
            groupByToolStripMenuItem.DropDownItems.Add(a);
            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.MyNWConnectionString))
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand("select distinct Country from Customers", conn);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        ToolStripMenuItem c = new ToolStripMenuItem();
                        c.Text = reader["country"].ToString();
                        c.Tag = reader["country"].ToString();
                        c.Click += C_Click;
                        groupByToolStripMenuItem.DropDownItems.Add(c);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void C_Click(object sender, EventArgs e)
        {
            string tag = ((object)sender).ToString();
            
            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.MyNWConnectionString))
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand();
                    if(tag == "All Country")
                    {
                        command.CommandText = $"select country,format(sum(unitprice*quantity*(1-discount)),'c','en-us') from Customers c join[Orders] o on c.CustomerID = o.CustomerID join[Order Details] od on o.OrderID = od.OrderID group by country";
                    }
                    else
                    {
                        command.CommandText = $"select country,format(sum(unitprice*quantity*(1-discount)),'c','en-us') from Customers c join[Orders] o on c.CustomerID = o.CustomerID join[Order Details] od on o.OrderID = od.OrderID where country = '{tag}' group by country";
                    }
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
            if(comboBox1.Text == "All Country")
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

        private void customerIDDescToolStripMenuItem_Click(object sender, EventArgs e)
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


    }
}
//========================
//2. ContextMenuStrip2
//選擇性作業
//Groups
//USA (100) 
//UK (20)

//this.listview1.visible = false;
//ListViewItem lvi = this.listView1.Items.Add(dataReader[0].ToString());

//if (this.listView1.Groups["USA"] == null)
//{                       {
//    ListViewGroup group = this.listView1.Groups.Add("USA", "USA"); //Add(string key, string headerText);
//    group.Tag = 0;
//    lvi.Group = group; 
//}
//else
//{
//    ListViewGroup group = this.listView1.Groups["USA"]; 
//    lvi.Group = group;
//}

//this.listView1.Groups["USA"].Tag = 
//this.listView1.Groups["USA"].Header = 

