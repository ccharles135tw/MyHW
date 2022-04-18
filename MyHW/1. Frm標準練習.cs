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
    public partial class Frm標準練習 : Form
    {
        public Frm標準練習()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int i = int.Parse(textBox4.Text);
            string str;
            if (i % 2 == 0)
            {
                str = "Even";
            }
            else
            {
                str = "Odd";
            }
            lblResult.Text = String.Format("Number {0} is {1}.", i, str);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] intarr = { 1, 2, 3 };
            Array.Sort(intarr);
            lblResult.Text = "3個數的最大值 :" + intarr[intarr.Length - 1].ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int cnt = 0;
            for (int i = int.Parse(textBox1.Text); i <= int.Parse(textBox2.Text); i += int.Parse(textBox3.Text))
            {
                cnt += i;
            }
            lblResult.Text = String.Format("From {0} to {1} ,Step {2} = {3}", textBox1.Text, textBox2.Text, textBox3.Text, cnt);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int cnt = 0, start = int.Parse(textBox1.Text);
            while (start <= int.Parse(textBox2.Text))
            {
                cnt += start;
                start += int.Parse(textBox3.Text);
            }
            lblResult.Text = String.Format("From {0} to {1} ,Step {2} = {3}", textBox1.Text, textBox2.Text, textBox3.Text, cnt);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int cnt = 0, start = int.Parse(textBox1.Text);
            do
            {
                cnt += start;
                start += int.Parse(textBox3.Text);
            } while (start <= int.Parse(textBox2.Text));
            lblResult.Text = String.Format("From {0} to {1} ,Step {2} = {3}", textBox1.Text, textBox2.Text, textBox3.Text, cnt);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string str = "";
            for(int i = 1; i < 10; i++)
            {
                for(int j = 1; j < 10; j++)
                {
                    str += String.Format("{0} x {1} = {2} |",j,i,(j*i).ToString("00"));
                }
                str += '\n';
            }
            lblResult.Text = str;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            int i = 100;
            string str = "";
            while (i >= 1)
            {
                if (i % 2 != 0)
                {
                    str = "1"+str;
                }
                else
                {
                    str = "0" + str;
                }
                i /= 2;
            }
            lblResult.Text = str;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int[] intarr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            int cnt = 0;
            for(int i = 0; i < intarr.Length; i++)
            {
                if (intarr[i] % 2 == 0)
                {
                    cnt++;
                }
            }
            lblResult.Text = String.Format("1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 統計\n奇數: {0} \n偶數: {1}", intarr.Length - cnt,cnt);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            string[] strarr = {"Decimal", "pricePerOunce", "17.36m", "The", "current", "price", "is", "per", "ounce"};
            string result = "";
            int len = 0;
            foreach(string i in strarr)
            {
                if (i.Length > len)
                {
                    len= i.Length;
                    result = i;
                }
            }
            lblResult.Text = result;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string[] strarr = { "Decimal", "pricePerOunce", "17.36m", "The", "current", "price", "is", "per", "ounce"};
            int cnt = 0;
            string result = "";
            foreach (string i in strarr)
            {
                result += i + ", ";
                if (i.Contains("c") == true || i.Contains("C") == true)
                {
                    cnt++;
                }
            }
            lblResult.Text = result + "\n有C或c的有 " + cnt + " 個.";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lblResult.Text =  "最大值" +intParams(1, 2, 3, 4, 5, 6, 7, 8, 9);
        }
        int intParams(params int[] i)
        {
            int max = int.MinValue,maxvalue=0;
            foreach(int j in i)
            {
                if (j > max)
                {
                    max = j;
                    maxvalue = max;
                }
            }
            return maxvalue;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int[] i = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            lblResult.Text = String.Format("最大值: {0} , 最小值: {1}", i.Max(), i.Min());
        }

        private void button19_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";
            int[] arr = new int[6];
            Random ran = new Random(int.Parse(DateTime.Now.ToString("HHmmssfff")));
            for (int i = 0; i < 6; i++)
            {
                arr[i] = ran.Next(1, 49);
                for (int j = 0; j < i; j++)
                {
                    while (arr[j] == arr[i])
                    {
                        j = 0;
                        arr[i] = ran.Next(1, 49);
                    }
                }
                lblResult.Text += arr[i] +" ";
            }
        }
    }
}
