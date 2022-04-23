using MyHW;
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

namespace MyHomeWork
{
    public partial class FrmLogon : Form
    {
        public FrmLogon()
        {
            InitializeComponent();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.MyNWConnectionString))
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand();
                    command.CommandText = $"select * from MyMember where UserName = @UserName and Password = @Password";
                    command.Parameters.Add("@UserName", SqlDbType.NVarChar, 16).Value = UsernameTextBox.Text;
                    command.Parameters.Add("@Password", SqlDbType.NVarChar, 40).Value = PasswordTextBox.Text;
                    command.Connection = conn;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        MessageBox.Show("Log On 成功");
                        HomePage f = new HomePage();
                        this.Visible = false;
                        f.ShowDialog();
                        if(f.DialogResult == DialogResult.Cancel)
                        {
                            this.Visible = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Log On 失敗");
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
            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.MyNWConnectionString))
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand();
                    command.CommandText = "InsertMember";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("@UserName", SqlDbType.NVarChar, 16).Value = UsernameTextBox.Text;
                    command.Parameters.Add("@Password", SqlDbType.NVarChar, 40).Value = PasswordTextBox.Text;
                    command.Connection = conn;
                    SqlParameter p1 = new SqlParameter();
                    p1.ParameterName = "@Return_Value";
                    p1.Direction = ParameterDirection.ReturnValue;
                    command.Parameters.Add(p1);

                    int a = command.ExecuteNonQuery();
                    MessageBox.Show("Add Member 成功");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
