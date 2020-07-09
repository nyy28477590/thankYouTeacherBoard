using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thankYouTeacher
{
    public partial class Form1 : Form
    {
        int score1 = 0;
        int score2 = 0;
        int score3 = 0;
        int score4 = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player_add = new System.Media.SoundPlayer(@"D:\商務謝師夜\加分.wav");
            player_add.Play();
            int point = Convert.ToInt32(tb_point.Text);
            if(rdb1.Checked == true)
            {
                score1 += point;
                score_1.Text = score1.ToString();
            }
            else if(rdb2.Checked == true)
            {
                score2 += point;
                score_2.Text = score2.ToString();
            }
            else if(rdb3.Checked == true)
            {
                score3 += point;
                score_3.Text = score3.ToString();
            }
            else
            {
                score4 += point;
                score_4.Text = score4.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player_start = new System.Media.SoundPlayer(@"D:\商務謝師夜\遊戲開始.wav");
            player_start.Play();
            score_1.Text = "0";
            score_2.Text = "0";
            score_3.Text = "0";
            score_4.Text = "0";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player_stop = new System.Media.SoundPlayer(@"D:\商務謝師夜\結束.wav");
            player_stop.Play();
            score_1.Text = "0";
            score_2.Text = "0";
            score_3.Text = "0";
            score_4.Text = "0";
            score1 = 0;
            score2 = 0;
            score3 = 0;
            score4 = 0;

            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player_result = new System.Media.SoundPlayer(@"D:\商務謝師夜\結算.wav");
            player_result.Play();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string group1, group2, group3, group4;
            group1 = textBox1.Text;
            textBox1.Visible = false;
            name_1.Text = group1;

            group2 = textBox2.Text;
            textBox2.Visible = false;
            name_2.Text = group2;

            group3 = textBox3.Text;
            textBox3.Visible = false;
            name_3.Text = group3;

            group4 = textBox4.Text;
            textBox4.Visible = false;
            name_4.Text = group4;
        }
    }
}
