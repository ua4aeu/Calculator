using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // -------------------- кнопка "Посчитать" --------------------
        private void button1_Click(object sender, EventArgs e) // при клике на кнопку button1 происходит событие:
        {
            double a, b; // определяем переменные ( у нас тип double)
            a = Convert.ToDouble(textBox1.Text); // присваиваем значение - то, что ввели в поле textBox1
            b = Convert.ToDouble(textBox2.Text); // присваиваем значение - то, что ввели в поле textBox2
            
            switch (comboBox1.Text) // проверяем, какой арифм. знак выбрал пользователь +, -, * или /
            { 
                case "+":
                textBox3.Text=Convert.ToString(a + b); // в поле textBox3 (Результат) выводим а+b
                    break;
                case "-":
                textBox3.Text = Convert.ToString(a - b); // в поле textBox3 (Результат) выводим а-b
                    break;
                case "*":
                    textBox3.Text = Convert.ToString(a * b); // в поле textBox3 (Результат) выводим а*b
                    break;
                case "/":
                    textBox3.Text = Convert.ToString(a / b); // в поле textBox3 (Результат) выводим а/b
                    if(b==0) // проверяем деление на ноль
                    {
                        MessageBox.Show("На ноль делить нельзя!"); // всплывающее окно
                    }
                    break;
                    // !!!  почему Convert.ToString? - потому что в поле можно вводить или выводить только String
            } 
        }
        // -------------------- кнопка "Очистить" --------------------
        private void button2_Click(object sender, EventArgs e) // при клике на кнопку button2:
        {
            textBox1.Text = ""; // очищаем поле textBox1
            textBox2.Text = ""; // очищаем поле textBox2
            textBox3.Text = ""; // очищаем поле textBox3 (результат)
            comboBox1.Text = ""; // очищаем поле comboBox1 (выбор знака)
        }

        private void button3_Click(object sender, EventArgs e) // кнопка "?"
        {
            MessageBox.Show("ПРОСТОЙ КАЛЬКУЛЯТОР.\nСложение\nВычитание\nУмножение\nДеление\n2020г."); // всплывающее окно
        }
    }
}
