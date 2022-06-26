using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diffi_helman
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Clear();
          
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            int g = 0;
            int p = 0;
            int a = 0;
            int b = 0;
            string nomber = "0";
            if (radioButton1.Checked)
            {
                // определяем какой вариант выбран и присваиваем значение
                g = 35;
                p = 41;
                a = 2;
                b = 3;
                nomber = "Задание №: 1";
            }
            else
            if (radioButton2.Checked)
            {
                // определяем какой вариант выбран и присваиваем значение
                g = 14;
                p = 10;
                a = 1;
                b = 3;
                nomber = "Задание №: 2";
            }
            else
            if (radioButton3.Checked)
            {
                // определяем какой вариант выбран и присваиваем значение
                g = 15;
                p = 14;
                a = 4;
                b = 5;
                nomber = "Задание №: 3";
            }
            else
            if (radioButton4.Checked)
            {
                // определяем какой вариант выбран и присваиваем значение
                g = 5;
                p = 6;
                a = 2;
                b = 5;
                nomber = "Задание №: 4";
            }
            else
            if (radioButton5.Checked)
            {
                // определяем какой вариант выбран и присваиваем значение
                g = 3;
                p = 17;
                a = 3;
                b = 3;
                nomber = "Задание №: 5";
            }
            else
            {
                // определяем какой вариант выбран и присваиваем значение
                g = Convert.ToInt32(textBox2.Text);
                p = Convert.ToInt32(textBox3.Text);
                a = Convert.ToInt32(textBox4.Text);
                b = Convert.ToInt32(textBox5.Text);
                nomber = "Ключ создан из ваших данных";
            }
            // вычисляется A и B (остаток от деления) и пересылаются обоим пользователям
            ulong A = Convert.ToUInt64(Math.Pow(g, a) % p);
            ulong B = Convert.ToUInt64(Math.Pow(g, b) % p);
            // 1 пользователь
            ulong Ka = Convert.ToUInt64(Math.Pow(B,a) % p);
            // 2 пользаватель
            ulong Kb = Convert.ToUInt64(Math.Pow(A, b) % p);
            if (Ka == Kb)
            {
                textBox1.Text = (nomber) + Environment.NewLine +
                (Ka + " = " + Kb) + Environment.NewLine +
                ("Число '" + Ka +"' можно использовать в качестве секретного ключа.");
            }
            else
            {
                textBox1.Text = (Ka + " # " + Kb) + Environment.NewLine +
                    ("ПРОИЗОШЛА НЕИЗВЕСТНАЯ ОШИБКА!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
        }
    }
}
