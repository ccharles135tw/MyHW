using MyHW;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinqLabs
{
    public partial class Frm考試 : Form
    {
        public Frm考試()
        {
            InitializeComponent();

            students_scores = new List<Student>()
                                         {
                                            new Student{ Name = "aaa", Class = "CS_101", Chi = 80, Eng = 80, Math = 50, Gender = "Male" },
                                            new Student{ Name = "bbb", Class = "CS_102", Chi = 80, Eng = 80, Math = 100, Gender = "Male" },
                                            new Student{ Name = "ccc", Class = "CS_101", Chi = 60, Eng = 50, Math = 75, Gender = "Female" },
                                            new Student{ Name = "ddd", Class = "CS_102", Chi = 80, Eng = 70, Math = 85, Gender = "Female" },
                                            new Student{ Name = "eee", Class = "CS_101", Chi = 80, Eng = 80, Math = 50, Gender = "Female" },
                                            new Student{ Name = "fff", Class = "CS_102", Chi = 80, Eng = 80, Math = 80, Gender = "Female" },

                                          };
            
            Random ran = new Random(int.Parse(DateTime.Now.ToString("HHmmssfff")));
            for (int i = 0; i < 100; i++)
            {
                students_100_score.Add(new Student
                {
                    Name = $"學生{i + 1}",
                    Chi = ran.Next(60, 101),
                    Eng = ran.Next(60, 101),
                    Math = ran.Next(60, 101)
                });
            }
        }

        List<Student> students_scores;
        List<Student> students_100_score = new List<Student>();
        public class Student
        {
            public string Name { get; set; }
            public string Class { get; set; }
            public int Chi { get; set; }
            public int Eng { get; internal set; }
            public int Math { get; set; }
            public string Gender { get; set; }
        }
        void ClearAll()
        {
            chart1.Series.Clear();
            dataGridView1.DataSource = null;
            dataGridView2.DataSource = null;
            dataGridView3.DataSource = null;
        }
        private void button36_Click(object sender, EventArgs e)
        {
            #region 搜尋 班級學生成績

            // 
            // 共幾個 學員成績 ?						
            MessageBox.Show("共幾個 學員成績 ?");
            ClearAll();
            var z = from i in students_scores
                    select new { i.Name, i.Chi, i.Eng, i.Math };

            foreach (var i in z)
            {
                chart1.Series.Add(i.Name);
                chart1.Series[i.Name].Points.AddXY("國文", i.Chi);
                chart1.Series[i.Name].Points.AddXY("英文", i.Eng);
                chart1.Series[i.Name].Points.AddXY("數學", i.Math);
                chart1.Series[i.Name].IsValueShownAsLabel = true;

            }
            // 找出 前面三個 的學員所有科目成績
            MessageBox.Show("找出 前面三個 的學員所有科目成績");
            ClearAll();
            var a = from i in students_scores.Take(3)
                    select new { i.Name, i.Chi, i.Eng, i.Math };

            foreach (var i in a)
            {
                chart1.Series.Add(i.Name);
                chart1.Series[i.Name].Points.AddXY("國文", i.Chi);
                chart1.Series[i.Name].Points.AddXY("英文", i.Eng);
                chart1.Series[i.Name].Points.AddXY("數學", i.Math);
                chart1.Series[i.Name].IsValueShownAsLabel = true;

            }

            // 找出 後面兩個 的學員所有科目成績	
            MessageBox.Show("找出 後面兩個 的學員所有科目成績");
            ClearAll();
            var b = from i in students_scores.Skip(students_scores.Count - 2)
                    select new { i.Name, i.Chi, i.Eng, i.Math };

            foreach (var i in b)
            {
                chart1.Series.Add(i.Name);
                chart1.Series[i.Name].Points.AddXY("國文", i.Chi);
                chart1.Series[i.Name].Points.AddXY("英文", i.Eng);
                chart1.Series[i.Name].Points.AddXY("數學", i.Math);
                chart1.Series[i.Name].IsValueShownAsLabel = true;
            }

            // 找出 Name 'aaa','bbb','ccc' 的學員國文英文科目成績				
            MessageBox.Show("找出 Name 'aaa','bbb','ccc' 的學員國文英文科目成績	");
            ClearAll();
            var c = from i in students_scores
                    where i.Name == "aaa" || i.Name == "bbb" || i.Name == "ccc"
                    select new { i.Name, i.Chi, i.Eng };
            foreach (var i in c)
            {
                chart1.Series.Add(i.Name);
                chart1.Series[i.Name].Points.AddXY("國文", i.Chi);
                chart1.Series[i.Name].Points.AddXY("英文", i.Eng);
                chart1.Series[i.Name].IsValueShownAsLabel = true;
            }
            // 找出學員 'bbb' 的成績	                          
            MessageBox.Show("找出學員 'bbb' 的成績");
            ClearAll();
            var d = from i in students_scores
                    where i.Name == "bbb"
                    select new { i.Name, i.Chi, i.Eng, i.Math };
            foreach (var i in d)
            {
                chart1.Series.Add(i.Name);
                chart1.Series[i.Name].Points.AddXY("國文", i.Chi);
                chart1.Series[i.Name].Points.AddXY("英文", i.Eng);
                chart1.Series[i.Name].Points.AddXY("數學", i.Math);
                chart1.Series[i.Name].IsValueShownAsLabel = true;
            }
            // 找出除了 'bbb' 學員的學員的所有成績 ('bbb' 退學)	
            MessageBox.Show("找出除了 'bbb' 學員的學員的所有成績 ('bbb' 退學)");
            ClearAll();
            var f = from i in students_scores
                    where i.Name != "bbb"
                    select new { i.Name, i.Chi, i.Eng, i.Math };
            foreach (var i in f)
            {
                chart1.Series.Add(i.Name);
                chart1.Series[i.Name].Points.AddXY("國文", i.Chi);
                chart1.Series[i.Name].Points.AddXY("英文", i.Eng);
                chart1.Series[i.Name].Points.AddXY("數學", i.Math);
                chart1.Series[i.Name].IsValueShownAsLabel = true;
            }
            // 找出 'aaa', 'bbb' 'ccc' 學員 國文數學兩科 科目成績  |				
            // 數學不及格 ... 是誰 
            MessageBox.Show("找出 'aaa', 'bbb' 'ccc' 學員 國文數學兩科 科目成績，數學不及格 ... 是誰");
            ClearAll();
            var g = from i in students_scores
                    where i.Name == "aaa" || i.Name == "bbb" || i.Name == "ccc"
                    select new { i.Name, i.Chi, i.Math };
            foreach (var i in g)
            {
                chart1.Series.Add(i.Name);
                chart1.Series[i.Name].Points.AddXY("國文", i.Chi);
                chart1.Series[i.Name].Points.AddXY("數學", i.Math);
                chart1.Series[i.Name].IsValueShownAsLabel = true;
                if (i.Math < 60)
                {
                    MessageBox.Show($"{i.Name}數學成績 :{i.Math} => 不及格");
                }
            }
            #endregion
        }

        private void button37_Click(object sender, EventArgs e)
        {
            ClearAll();
            //個人 sum, min, max, avg
            MessageBox.Show("個人 sum, min, max, avg");
            var a = from i in students_scores
                    select new { i.Name, i.Chi, i.Eng, i.Math };
            chart1.Series.Add("Sum");
            chart1.Series.Add("Min");
            chart1.Series.Add("Max");
            chart1.Series.Add("Avg");
            foreach (var i in a)
            {
                chart1.Series["Sum"].Points.AddXY(i.Name, i.Math + i.Eng + i.Chi);
                chart1.Series["Min"].Points.AddXY(i.Name, Math.Min(Math.Min(i.Math, i.Chi), i.Eng));
                chart1.Series["Max"].Points.AddXY(i.Name, Math.Max(Math.Max(i.Math, i.Chi), i.Eng));
                chart1.Series["Avg"].Points.AddXY(i.Name, (i.Math + i.Eng + i.Chi) / 3);
                chart1.Series["Sum"].IsValueShownAsLabel = true;
                chart1.Series["Min"].IsValueShownAsLabel = true;
                chart1.Series["Max"].IsValueShownAsLabel = true;
                chart1.Series["Avg"].IsValueShownAsLabel = true;
            }

            //各科 sum, min, max, avg
            MessageBox.Show("各科 sum, min, max, avg");
            ClearAll();
            chart1.Series.Add("Sum");
            chart1.Series.Add("Min");
            chart1.Series.Add("Max");
            chart1.Series.Add("Avg");
            int sum_chi = students_scores.Sum(n => n.Chi);
            int sum_eng = students_scores.Sum(n => n.Eng);
            int sum_math = students_scores.Sum(n => n.Math);

            int min_chi = students_scores.Min(n => n.Chi);
            int min_eng = students_scores.Min(n => n.Eng);
            int min_math = students_scores.Min(n => n.Math);

            int max_chi = students_scores.Max(n => n.Chi);
            int max_eng = students_scores.Max(n => n.Eng);
            int max_math = students_scores.Max(n => n.Math);

            int avg_chi = (int)students_scores.Average(n => n.Chi);
            int avg_eng = (int)students_scores.Average(n => n.Eng);
            int avg_math = (int)students_scores.Average(n => n.Math);

            chart1.Series["Sum"].Points.AddXY("國文", sum_chi);
            chart1.Series["Min"].Points.AddXY("國文", min_chi);
            chart1.Series["Max"].Points.AddXY("國文", max_chi);
            chart1.Series["Avg"].Points.AddXY("國文", avg_chi);

            chart1.Series["Sum"].Points.AddXY("英文", sum_eng);
            chart1.Series["Min"].Points.AddXY("英文", min_eng);
            chart1.Series["Max"].Points.AddXY("英文", max_eng);
            chart1.Series["Avg"].Points.AddXY("英文", avg_eng);

            chart1.Series["Sum"].Points.AddXY("數學", sum_math);
            chart1.Series["Min"].Points.AddXY("數學", min_math);
            chart1.Series["Max"].Points.AddXY("數學", max_math);
            chart1.Series["Avg"].Points.AddXY("數學", avg_math);

            chart1.Series["Sum"].IsValueShownAsLabel = true;
            chart1.Series["Min"].IsValueShownAsLabel = true;
            chart1.Series["Max"].IsValueShownAsLabel = true;
            chart1.Series["Avg"].IsValueShownAsLabel = true;
        }

        private void button33_Click(object sender, EventArgs e)
        {
            ClearAll();
            // split=> 分成 三群 '待加強'(60~69) '佳'(70~89) '優良'(90~100) 
            // print 每一群是哪幾個 ? (每一群 sort by 分數 descending)
            MessageBox.Show("三群,每一群是哪幾個");
            chart1.Series.Add("待加強'(60~69)");
            chart1.Series.Add("佳'(70~89)");
            chart1.Series.Add("優良'(90~100)");

            var a = from i in students_100_score
                    where i.Chi < 70
                    select new { i.Name, i.Chi };
            chart1.Series["待加強'(60~69)"].Points.AddXY("國文", a.Count());
            dataGridView1.DataSource = a.ToList();
            var b = from i in students_100_score
                    where i.Chi > 69 && i.Chi < 90
                select new { i.Name, i.Chi };
            chart1.Series["佳'(70~89)"].Points.AddXY("國文", b.Count());
            dataGridView2.DataSource = b.ToList();
            var c = from i in students_100_score
                    where i.Chi > 89 && i.Chi < 101
                    select new {i.Name, i.Chi };
            chart1.Series["優良'(90~100)"].Points.AddXY("國文", c.Count());
            dataGridView3.DataSource = c.ToList();

            chart1.Series["待加強'(60~69)"].IsValueShownAsLabel = true;
            chart1.Series["佳'(70~89)"].IsValueShownAsLabel = true;
            chart1.Series["優良'(90~100)"].IsValueShownAsLabel = true;

        }

        private void button35_Click(object sender, EventArgs e)
        {
            ClearAll();
            // 統計 :　所有隨機分數出現的次數/比率; sort ascending or descending
            var a = from i in students_100_score
                    orderby i.Eng 
                    group i by new { Eng_Score = i.Eng } into j
                    select new { Eng_Score = j.Key.Eng_Score,Count = j.Count() };
            dataGridView1.DataSource = a.ToList();
            chart1.ChartAreas[0].AxisY.LabelStyle.Format = " 0% ";
            chart1.ChartAreas[0].AxisY.Interval = 0.01;
            foreach (var i in a)
            {
                chart1.Series.Add(i.Eng_Score.ToString());
                chart1.Series[i.Eng_Score.ToString()].Points.AddXY("分數出現次數比率",(decimal)i.Count/100);
            }
        }
        NorthwindEntities dbcontext = new NorthwindEntities();

        private void button34_Click(object sender, EventArgs e)
        {
            ClearAll();
            MessageBox.Show("每年最高/低訂單");
            // 年度最高銷售金額 年度最低銷售金額 
            var a = from i in dbcontext.Orders.AsEnumerable()
                    group i by i.OrderDate.Value.Year into j
                    select new {max= j.Max(m=>m.Order_Details.Sum(n => n.UnitPrice * n.Quantity * (decimal)(1 - n.Discount))), min = j.Min(m => m.Order_Details.Sum(n => n.UnitPrice * n.Quantity * (decimal)(1 - n.Discount))), Year = j.Key};
            dataGridView1.DataSource = a.ToList();
            chart1.Series.Add("每年最高訂單");
            chart1.Series.Add("每年最低訂單");
            chart1.Series["每年最高訂單"].IsValueShownAsLabel = true;
            chart1.Series["每年最低訂單"].IsValueShownAsLabel = true;
            foreach (var i in a)
            {
                chart1.Series["每年最高訂單"].Points.AddXY(i.Year, i.max);
                chart1.Series["每年最低訂單"].Points.AddXY(i.Year, i.min);
            }

            // 那一年總銷售最好 ? 那一年總銷售最不好 ?
            MessageBox.Show("年總銷售最好/不好");
            ClearAll();
            var b = from i in dbcontext.Orders.AsEnumerable()
                    group i by i.OrderDate.Value.Year into j
                    select new { total = j.Sum(n => n.Order_Details.Sum(m => m.UnitPrice * m.Quantity * (decimal)(1 - m.Discount))),Year = j.Key};
            dataGridView2.DataSource = b.ToList();

            
            decimal year_max_value = b.Max(n=>n.total);
            decimal year_min_value = b.Min(n => n.total);
            int year_max_int = b.Where(n => n.total == year_max_value).Select(m => m.Year).First();
            int year_min_int = b.Where(n => n.total == year_min_value).Select(m => m.Year).First();
            chart1.Series.Add("年總銷售最高");
            chart1.Series.Add("年總銷售最低");
            chart1.Series["年總銷售最高"].Points.AddXY(year_max_int,year_max_value);
            chart1.Series["年總銷售最低"].Points.AddXY(year_min_int,year_min_value);
            chart1.Series["年總銷售最高"].IsValueShownAsLabel = true;
            chart1.Series["年總銷售最低"].IsValueShownAsLabel = true;
            // 那一個月總銷售最好 ? 那一個月總銷售最不好 ?
            MessageBox.Show("月銷售最高/低");
            ClearAll();
            var c = from i in dbcontext.Orders.AsEnumerable()
                    group i by new { i.OrderDate.Value.Year, i.OrderDate.Value.Month } into j
                    select new { Month_Total = j.Sum(n => n.Order_Details.Sum(m => m.UnitPrice * m.Quantity * (decimal)(1 - m.Discount))),Year_Month = $"{j.Key.Year}年{j.Key.Month}"};
            dataGridView1.DataSource = c.ToList();
            decimal month_max_value = c.Max(n => n.Month_Total);
            decimal month_min_value = c.Min(n => n.Month_Total);
            string month_max_str = c.Where(n => n.Month_Total == month_max_value).Select(m => m.Year_Month).First();
            string month_min_str = c.Where(n => n.Month_Total == month_min_value).Select(m => m.Year_Month).First();
            chart1.Series.Add("月銷售最高");
            chart1.Series.Add("月銷售最低");
            chart1.Series["月銷售最高"].Points.AddXY(month_max_str, month_max_value);
            chart1.Series["月銷售最高"].Points.AddXY(month_min_str, month_min_value);
            chart1.Series["月銷售最高"].IsValueShownAsLabel = true;
            chart1.Series["月銷售最高"].IsValueShownAsLabel = true;

            // 每年 總銷售分析 圖
            MessageBox.Show("每年 總銷售分析 圖");
            ClearAll();
            var d = from i in dbcontext.Orders.AsEnumerable()
                    group i by i.OrderDate.Value.Year into j
                    select new { Year_Total = j.Sum(n => n.Order_Details.Sum(m => m.UnitPrice * m.Quantity * (decimal)(1 - m.Discount))), Year = j.Key };
            dataGridView1.DataSource = d.ToList();
            chart1.Series.Add("年銷售總額");
            foreach (var i in d)
            {
                chart1.Series["年銷售總額"].Points.AddXY($"{i.Year}年銷售總額", i.Year_Total);
            }
            chart1.Series["年銷售總額"].IsValueShownAsLabel = true;

            // 每月 總銷售分析 圖
            MessageBox.Show("每月 總銷售分析 圖");
            ClearAll();
            var f = from i in dbcontext.Orders.AsEnumerable()
                    group i by new { i.OrderDate.Value.Year, i.OrderDate.Value.Month } into j
                    select new {Month_Sum = j.Sum(n => n.Order_Details.Sum(m => m.UnitPrice * m.Quantity * (decimal)(1 - m.Discount))),Year_Month = $"{j.Key.Year}年{j.Key.Month}月" };
            dataGridView1.DataSource = f.ToList();
            chart1.Series.Add("月銷售總額");
            foreach (var i in f)
            {
                chart1.Series["月銷售總額"].Points.AddXY($"{i.Year_Month}月銷售總額", i.Month_Sum);
            }
            chart1.Series["月銷售總額"].IsValueShownAsLabel = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ClearAll();
            var a = from i in dbcontext.Orders.AsEnumerable()
                    group i by new { i.OrderDate.Value.Year } into j
                    select new { Year_Total = j.Sum(n => n.Order_Details.Sum(m => m.UnitPrice * m.Quantity * (decimal)(1 - m.Discount))) ,Year = j.Key};
            chart1.ChartAreas[0].AxisY.LabelStyle.Format = " 0% ";
            chart1.ChartAreas[0].AxisY.Interval = 0.5;
            chart1.Series.Add("年銷售成長率");
            var b = a.ToList();
            for(int i = 1; i < b.Count(); i++)
            {
                chart1.Series["年銷售成長率"].Points.AddXY($"{b[i].Year}年成長率", (decimal)((b[i].Year_Total- b[i - 1].Year_Total )/ b[i - 1].Year_Total));
            }
            chart1.Series["年銷售成長率"].IsValueShownAsLabel = true;
        }
    }
}
