using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace task_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        string selectedColor;

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] colors = { "Жовтий", "Синій", "Червоний" };
            listBox1.Items.AddRange(colors);

            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
        }


        void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedColor = listBox1.SelectedItem.ToString();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            switch (selectedColor)
            {
                case "Жовтий":
                    pictureBox1.BackColor = Color.Yellow;
                    break;

                case "Червоний":
                    pictureBox1.BackColor = Color.Red;
                    break;

                case "Синій":
                    pictureBox1.BackColor = Color.Blue;
                    break;
            }
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Green;
        }
    }

}
