﻿using System;
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
namespace CaculateBMI003
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CreateRange();
        }

        private Dictionary<int, Range> _range;

        private void button1_Click(object sender, EventArgs e)
        {
            double height;
            double weight;
            Bmi bmi = new Bmi();
            if (double.TryParse(textBox1.Text, out height) && double.TryParse(textBox2.Text, out weight))
            {
                bmi.height = double.Parse(textBox1.Text);
                bmi.weight = double.Parse(textBox2.Text);
                for (int i = 1; i < 6; i++)
                {
                    if (bmi.bmi() < _range[i].rangeBmi)
                    {
                        MessageBox.Show("您的BMI值為 : " + bmi.result() + " 級別 : " + _range[i].rangeResult );
                        return;
                    }
                }
                MessageBox.Show("您的BMI值為 : " + bmi.result() + " 級別 : " + "過度肥胖");
            }
            else MessageBox.Show("請輸入正常數值非其他文字", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void CreateRange()
        {
            _range = new Dictionary<int, Range>();
            _range.Add(1, new Range { rangeBmi = 18.5, rangeResult = "過輕" });
            _range.Add(2, new CaculateBMI003.Range { rangeBmi = 24, rangeResult = "標準" });
            _range.Add(3, new CaculateBMI003.Range { rangeBmi = 27, rangeResult = "過重" });
            _range.Add(4, new Range { rangeBmi = 30, rangeResult = "輕度肥胖" });
            _range.Add(5, new Range { rangeBmi = 35, rangeResult = "中度肥胖" });

        }


    }
}
