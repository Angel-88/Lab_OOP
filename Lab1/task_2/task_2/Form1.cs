using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool n = true;

        private void button1_Click(object sender, EventArgs e)
        {
            while (n == true)
            {

                foreach (Control control in Controls.OfType<Label>())
                {
                    if (control.Text == "label4")
                    {
                        n = false;
                    }
                    control.Dispose();
                }
            }
        }
    }

}
