using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab8_LP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            dataGridView1.RowCount = 5;
            dataGridView1.ColumnCount = 5;
            int[,] X = new int[5, 5];
            int H = 0, sum = 0;
            Random rnd = new Random();
            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 5; j++)
                { 
                    X[i, j] = rnd.Next(-50, 50);
                    dataGridView1.Rows[i].Cells[j].Value = X[i, j].ToString();
                    if (X[i, 4] > 0)
                    H++; 
                 }


            if (H < 3)
            {
                textBox1.Text += Convert.ToString("Все положительные числа: "); 
                for(int i = 0;i < 5; i++)
                {
                    for(int j = 0;j < 5;j++)
                    {
                        if (X[i, j] > 0)
                            textBox1.Text += Convert.ToString(X[i, j] + " ");
                    }
                }
            }
            else if (H >= 3)
            {
                textBox1.Text += Convert.ToString("Сумма элементов главной диагонали матрицы: ");
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (i == j)
                            sum += X[i, j];
                    }
                }
                textBox1.Text += Convert.ToString(sum);
            }


        }
    }
}

















