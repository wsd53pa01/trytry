using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaculateBMI005
{
    public partial class Form1 : Form
    {
        private List<Range> _range = new List<Range>();
        public Form1()
        {
            InitializeComponent();
            CreateRange();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double height;
            double weight;
            Bmi bmi = new Bmi();
            if (double.TryParse(textBox1.Text, out height) && double.TryParse(textBox2.Text, out weight))
            {
                bmi.height = double.Parse(textBox1.Text);
                bmi.weight = double.Parse(textBox2.Text);
                foreach (var item in _range)
                {
                    if (bmi.bmi() < item.rangeBmi)
                    {
                        MessageBox.Show("您的BMI值為 : " + bmi.result() + " 級別 : " + item.rangeResult);
                        return;
                    }
                    

                }
                MessageBox.Show("您的BMI值為 : " + bmi.result() + " 級別 : " + "重度肥胖");
            }
            else MessageBox.Show("請輸入正常數值非其他文字", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void CreateRange()
        {
            _range.Add(new Range { rangeBmi = 18.5, rangeResult = "過輕" });
            _range.Add(new Range { rangeBmi = 24, rangeResult = "標準" });
            _range.Add(new Range { rangeBmi = 27, rangeResult = "過重" });
            _range.Add(new CaculateBMI005.Range { rangeBmi = 30, rangeResult = "輕度肥胖" });
            _range.Add(new CaculateBMI005.Range { rangeBmi = 35, rangeResult = "中度肥胖" });
        }

    }
}

