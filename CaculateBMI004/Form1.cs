using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/// <summary>
/// 小於 18.5     過輕
/// 18.5 ~ 24    標準
/// 24 ~ 27      過重
/// 27 ~ 30      輕度肥胖
/// 30 ~ 35      中度肥胖
/// 大於 35      重度肥胖
/// </summary>
namespace CaculateBMI004
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        string[,] range = new string[5, 2] { { "18.5", "過輕" }, { "24", "標準" }, { "27", "過重" }, { "30", "輕度肥胖" }, { "35", "中度肥胖" } };

        private void button1_Click(object sender, EventArgs e)
        {

            double height;
            double weight;
            Bmi bmi = new Bmi();
            if (double.TryParse(textBox1.Text, out height) && double.TryParse(textBox2.Text, out weight))
            {
                int i = 0;
                bmi.height = double.Parse(textBox1.Text);
                bmi.weight = double.Parse(textBox2.Text);
                while (i < 5)
                {
                    if (bmi.bmi() < double.Parse(range[i, 0]))
                    {
                        MessageBox.Show("您的BMI值為 : " + bmi.result() + " 級別 : " + range[i,1]);
                        return;
                    }
                    i = ++i;
                }
                MessageBox.Show("您的BMI值為 : " + bmi.result() + " 級別 : " + "過度肥胖");
            }
            else MessageBox.Show("請輸入正常數值非其他文字", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}

