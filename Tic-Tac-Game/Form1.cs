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
            MessageBox.Show("Игроки ходят по очереди.\r\nНолик считается игроком1\r\nКрестик - игроком 2.\r\nВ первую игру первый ход делается ноликом.\r\nКаждую последующую игру первый ход меняется\r\nна противоположный знак.\r\nНажимать на уже занятую ячейку не стоит.\r\nХороших вам крестико-ноликовых игр.\r\nИ пусть победит сильнейший.\r\n", "Правила игры");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            user_click(ref flag, button1, 0, 0);
            win_game();
            draw_game();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            user_click(ref flag, button2, 0, 1);
            win_game();
            draw_game();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            user_click(ref flag, button3, 0, 2);
            win_game();
            draw_game();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            user_click(ref flag, button4, 1, 0);
            win_game();
            draw_game();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            user_click(ref flag, button5, 1, 1);
            win_game();
            draw_game();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            user_click(ref flag, button6, 1, 2);
            win_game();
            draw_game();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            user_click(ref flag, button7, 2, 0);
            win_game();
            draw_game();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            user_click(ref flag, button8, 2, 1);
            win_game();
            draw_game();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            user_click(ref flag, button9, 2, 2);
            win_game();
            draw_game();
        }

        public void user_click(ref int flag, Button buttonx, int line, int column)
        {
            if (mas[line, column] == 0)
            {
                if (flag == 1)
                {
                    buttonx.Text = "O";
                    mas[line, column] = flag;
                    flag = 2;
                }
                else
                {
                    buttonx.Text = "X";
                    mas[line, column] = flag;
                    flag = 1;
                }
            }
            else
            {
                MessageBox.Show("Эта ячейка занята \n выбери другую");               
            }
        }


        public void win_game()
        {
            int count5 = 0, count6 = 0, count7 = 0, count8 = 0;

            for (int i = 0; i < N; i++)
            {
                int count1 = 0, count2 = 0, count3 = 0, count4 = 0;
                for (int j = 0; j < N; j++)
                {
                    //проверка на победу в строках или столбцах
                    if (mas[i, j] == 1)
                        count1++;
                    else if (mas[i, j] == 2)
                        count2++;
                    if (mas[j, i] == 1)
                        count3++;
                    else if (mas[j, i] == 2)
                        count4++;                  
                }
                //проверка на победу в диагоналях
                if (mas[i, i] == 1)
                    count5++;
                else if (mas[i, i] == 2)
                    count6++;
                if (mas[N - 1 - i, i] == 1)
                    count7++; 
                else if(mas[N - 1 - i, i] == 2)
                    count8++;
                if (count1 == 3 || count3 ==3 || count5==3 ||count7 ==3)
                {
                   
                    MessageBox.Show("Победа игрока 1");
                    restart_game();
                    break;

                }
                else if (count2 == 3 || count4 ==3 || count6==3 || count8==3)
                {
                    MessageBox.Show("Победа игрока 2");
                    restart_game();
                    break;
                }
            }
        }

        public void draw_game()
        {
            bool draw = false;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (mas[i, j] == 0)
                        draw = true;
                }
            }
            if (draw == false) {
                MessageBox.Show("Ничья");
                restart_game();
            }        
        }

        public void restart_game()
        {
            DialogResult res = MessageBox.Show("Начать заново", "", MessageBoxButtons.OKCancel);
            if (res == DialogResult.OK)
            {
                mas = new int[N, N];
                button1.Text = "";
                button2.Text = "";
                button3.Text = "";
                button4.Text = "";
                button5.Text = "";
                button6.Text = "";
                button7.Text = "";
                button8.Text = "";
                button9.Text = "";


            }
            else
            {
                Close();
            }
        }

    }
}
