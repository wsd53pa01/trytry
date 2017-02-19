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
namespace CaculateBMI3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            double height;
            double weight;
            if (double.TryParse(textBox1.Text, out height) && double.TryParse(textBox2.Text, out weight))
            {
                double bmi = weight / ((height * height) / 10000);
                string result = bmi.ToString("#.##");
                MessageBox.Show("您的BMI值為 : " + result + " 級別 : " + level(bmi));
            }
            else MessageBox.Show("請輸入正常數值非其他文字", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private static string level(double bmi)
        {
            if (bmi < 18.5)
            {
                return "過輕";
            }
            else if (bmi < 24)
            {
                return "標準";
            }
            else if (bmi < 27)
            {
                return "過重";
            }
            else if (bmi < 30)
            {
                return "輕度肥胖";
            }
            else if (bmi < 35)
            {
                return "中度肥胖";
            }

            else return "重度肥胖";
        }

    }
}
