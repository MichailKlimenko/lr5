using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace лр5
{
    public partial class Form1 : Form
    {
        private Set set1 = new Set();
        private Set set2 = new Set();
        public Form1()
        {
            InitializeComponent();
            set1.Add(1); // Инициализация множества
            set2.Add(2); // Инициализация множества
        }

        private void button1_Click(object sender, EventArgs e)
        {
            set1.AddRandom();
            listBox1.Items.Add("Добавлен случайный элемент в первое множество: " + set1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            set2.AddRandom();
            listBox1.Items.Add("Добавлен случайный элемент во второе множество: " + set2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Set unionSet = set1 + set2;
            listBox1.Items.Add("Результат объединения: " + unionSet);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool result = set1.CompareTo(set2) <= 0;
            listBox1.Items.Add("Первое множество меньше или равно второму: " + (result ? "Да" : "Нет"));

        }

        private void button6_Click(object sender, EventArgs e)
        {
            int power = (int)set1;
            listBox1.Items.Add("Мощность первого множества: " + power);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int element = set1[0];
            listBox1.Items.Add("Первый элемент первого множества: " + element);
        }
    }
}
