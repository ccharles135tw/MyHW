using MyHW.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyHW
{
    public partial class FrmMyAlbum_V1 : Form
    {
        public FrmMyAlbum_V1()
        {
            InitializeComponent();
            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.MyAlbum))
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand("select distinct Country from ImageTable", conn);
                    SqlDataReader reader = command.ExecuteReader();

                    int i = 1;
                    while (reader.Read())
                    {
                        LinkLabel x = new LinkLabel();
                        x.Text = reader["Country"].ToString();
                        x.Top = 10 * i;
                        x.Left = 20;
                        i += 5;
                        x.Tag = reader["Country"].ToString();
                        x.Click += X_Click;
                        this.Controls.Add(x);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void X_Click(object sender, EventArgs e)
        {
            LinkLabel l = (LinkLabel)sender;
            string str = (l.Tag).ToString();
            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.MyAlbum))
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand($"select Image from ImageTable where country = '{str}'");                    
                    command.Connection = conn;
                    SqlDataReader reader = command.ExecuteReader();
                    this.flowLayoutPanel1.Controls.Clear();
                    while (reader.Read())
                    {
                        byte[] bytes = (byte[])reader["Image"];
                        MemoryStream ms = new MemoryStream(bytes);
                        PictureBox p = new PictureBox()
                        {
                            Image = Image.FromStream(ms),
                            SizeMode = PictureBoxSizeMode.StretchImage

                        };
                        this.flowLayoutPanel1.Controls.Add(p);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CRUD f = new CRUD();
            f.Show();
        }
    }
}
