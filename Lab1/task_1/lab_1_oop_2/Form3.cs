using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_1_oop_2
{
    public partial class Form3 : Form
    {
        Form opener;
        public Form3(Form parentForm)
        {
            InitializeComponent();
            opener = parentForm;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            opener.Close();
            this.Close();
        }
    }
}
