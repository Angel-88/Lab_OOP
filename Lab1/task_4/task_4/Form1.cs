using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int numberLabel = 1;

        private void button1_Click(object sender, EventArgs e)
        {
            Label label = new Label();
            label.AutoSize = true;
            label.Font = new Font("Arial", 10F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label.Location = new Point(0, 0);
            label.Name = "labels" + numberLabel;
            label.Size = new Size(121, 21);
            label.Text = "label " + numberLabel;
            label.Click += label_Click;
            label.Dock = DockStyle.Top;
            Controls.Add(label);
            ++numberLabel;
        }

        private void label_Click(object sender, EventArgs e)
        {

        }
    }
}
