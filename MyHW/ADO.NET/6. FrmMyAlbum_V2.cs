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
    public partial class FrmMyAlbum_V2 : Form
    {
        public FrmMyAlbum_V2()
        {
            InitializeComponent();
            initial();
            crud();
            comboBox1.SelectedIndex = 0;
            this.flowLayoutPanel3.AllowDrop = true;
            this.flowLayoutPanel3.DragEnter += FlowLayoutPanel3_DragEnter;
            this.flowLayoutPanel3.DragDrop += FlowLayoutPanel3_DragDrop;
        }

        private void FlowLayoutPanel3_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string i in files)
            {
                PictureBox pic = new PictureBox();
                pic.Image = Image.FromFile(i);
                pic.SizeMode = PictureBoxSizeMode.StretchImage;
                pic.Width = 120;
                pic.Height = 80;

                this.flowLayoutPanel3.Controls.Add(pic);
                try
                {
                    using (SqlConnection conn = new SqlConnection(Settings.Default.MyAlbum))
                    {
                        conn.Open();
                        SqlCommand command = new SqlCommand();

                        byte[] bytes;
                        MemoryStream ms = new MemoryStream();
                        pic.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                        bytes = ms.GetBuffer();

                        command.CommandText = "Insert into ImageTable(Country,Image) values(@Country,@Image)";
                        command.Parameters.Add("@Country", SqlDbType.NVarChar).Value = comboBox1.Text;
                        command.Parameters.Add("@Image", SqlDbType.Image).Value = bytes;

                        command.Connection = conn;
                        int a = command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void FlowLayoutPanel3_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void initial()
        {
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
                        comboBox1.Items.Add(reader["Country"].ToString());
                        LinkLabel x = new LinkLabel();
                        x.Text = reader["Country"].ToString();
                        x.Top = 10 * i;
                        x.Left = 20;
                        i += 5;
                        x.Tag = reader["Country"].ToString();
                        x.Click += X_Click;
                        this.flowLayoutPanel2.Controls.Add(x);
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
            if (this.folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                DirectoryInfo directory = new DirectoryInfo(folderBrowserDialog1.SelectedPath);
                FileInfo[] filelist = directory.GetFiles("*", SearchOption.AllDirectories);

                foreach (FileInfo i in filelist)
                {
                    PictureBox pic = new PictureBox();
                    FileStream fs = File.OpenRead(folderBrowserDialog1.SelectedPath + @"\" + i);
                    pic.Image = Image.FromFile(fs.Name);
                    fs.Close();
                    pic.SizeMode = PictureBoxSizeMode.StretchImage;
                    pic.Width = 120;
                    pic.Height = 80;
                    this.flowLayoutPanel3.Controls.Add(pic);
                    try
                    {
                        using (SqlConnection conn = new SqlConnection(Settings.Default.MyAlbum))
                        {
                            conn.Open();
                            SqlCommand command = new SqlCommand();
                            byte[] bytes;
                            MemoryStream ms = new MemoryStream();
                            pic.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                            bytes = ms.GetBuffer();
                            command.CommandText = "Insert into ImageTable(Country,Image) values(@Country,@Image)";
                            command.Parameters.Add("@Country", SqlDbType.NVarChar).Value = comboBox1.Text;
                            command.Parameters.Add("@Image", SqlDbType.Image).Value = bytes;
                            command.Connection = conn;
                            command.ExecuteNonQuery();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
        void crud()
        {
            splitContainer4.Panel2.Controls.Clear();
            CRUD f = new CRUD();
            f.TopLevel = false;
            splitContainer4.Panel2.Controls.Add(f);
            f.Show();
        }
    }
}
