using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Circle cr = new Circle(0);
        bool DrawCircle = false;
        Square sq = new Square(0);
        bool DrawSquare = false;
        Rhomb rh = new Rhomb(0, 0);
        bool DrawRhomb = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        //Circle
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            button1.Visible = false;
            Start.Visible = true;
        }
        private void textbox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
        private void Start_Click(object sender, EventArgs e)
        {
            try
            {
                int radius = int.Parse(textBox1.Text);
                if (radius >= 102 || radius <= 0)
                {
                    MessageBox.Show("Введiть число бiльше 0 та менше 102!", "Помилка", MessageBoxButtons.OK);
                }
                else
                {
                    cr = new Circle(radius);
                    DrawCircle = true;
                    textBox1.Visible = false;
                    Start.Visible = false;
                    button6.Visible = true;
                }
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Введiть число!", "Помилка", MessageBoxButtons.OK);
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            cr.HideBackGround = true;
            DrawCircle = false;
            cr.MoveRight(pictureBox1);
            button6.Visible = false;
            button1.Visible = true;
            textBox1.Text = "Введiть радiус кола";
        }
        //Square
        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Visible = true;
            button4.Visible = true;
            button2.Visible = false;
        }
        private void textbox2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                int sideLength = int.Parse(textBox2.Text);
                if (sideLength >= 202 || sideLength <= 0)
                {
                    MessageBox.Show("Введiть будь ласка число бiльше 0 та менше 202", "Помилка", MessageBoxButtons.OK);
                }
                else
                {
                    sq = new Square(sideLength);
                    DrawSquare = true;
                    textBox2.Visible = false;
                    button4.Visible = false;
                    button7.Visible = true;
                }
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Введiть число!", "Помилка", MessageBoxButtons.OK);
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            sq.HideBackGround = true;
            DrawSquare = false;
            sq.MoveRight(pictureBox2);
            button7.Visible = false;
            button2.Visible = true;
            textBox2.Text = "Введiть довжину сторони квадрату";
        }
        //Rhomb
        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Visible = true;
            button5.Visible = true;
            button3.Visible = false;
        }
        private void textbox3_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
        }
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                int[] diagonals= Array.ConvertAll(textBox3.Text.Trim().Split(' '),int.Parse);
                if (diagonals[0] >= 202|| diagonals[1] >= 202 || diagonals[0]<= 0||diagonals[1]<=0)
                {
                    MessageBox.Show("Введiть будь ласка числа бiльше 0 або менше 285!", "Помилка", MessageBoxButtons.OK);
                }
                else
                {
                    rh = new Rhomb(diagonals[0],diagonals[1]);
                    DrawRhomb = true;
                    textBox3.Visible = false;
                    button5.Visible = false;
                    button8.Visible = true;
                }
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Введiть 2 числа через пропуск!", "Помилка", MessageBoxButtons.OK);
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Введiть 2 числа через пропуск!", "Помилка", MessageBoxButtons.OK);
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            rh.HideBackGround = true;
            DrawRhomb = false;
            rh.MoveRight(pictureBox3);
            button8.Visible = false;
            button3.Visible = true;
            textBox2.Text = "Введiть дiагоналi ромба";
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (DrawCircle)
            {
                cr.MoveRight(pictureBox1);
                cr.x_center += 3;
            }
            if (cr.x_center >= 1000)
            {
                DrawCircle = false;
            }
            if (DrawSquare)
            {
                sq.MoveRight(pictureBox2);
                sq.x_center += 3;
            }
            if (sq.x_center >= 1000)
            {
                DrawSquare = false;
            }
            if (DrawRhomb)
            {
                rh.MoveRight(pictureBox3);
                rh.x_center += 3;
            }
            if (rh.x_center >= 1000)
            {
                DrawRhomb = false;
            }
        }
    }
}
