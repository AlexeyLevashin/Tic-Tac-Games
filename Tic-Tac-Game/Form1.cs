using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Game
{
    public partial class Form1 : Form
    {
        const int N = 3;
        int[,] mas = new int[N, N];
        int flag = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            user_click(ref flag, button1, 0, 0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            user_click(ref flag, button2, 0, 1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            user_click(ref flag, button3, 0, 2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            user_click(ref flag, button4, 1, 0);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            user_click(ref flag, button5, 1, 1);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            user_click(ref flag, button6, 1, 2);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            user_click(ref flag, button7, 2, 0);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            user_click(ref flag, button8, 2, 1);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            user_click(ref flag, button9, 2, 2);
        }

        public void user_click(ref int flag, Button buttonx, int line, int column)
        {
            label1.Text = "Ошибки не найдены";
            if (mas[line, column] == 0)
            {
                if (flag == 1)
                {
                    buttonx.Text = "O";
                    flag = 2;
                }
                else
                {
                    buttonx.Text = "X";
                    flag = 1;
                }
                mas[line, column] = flag;

            }
            else
                label1.Text = "Эта ячейка занята,\n выбери другую";

        }


    }
}
