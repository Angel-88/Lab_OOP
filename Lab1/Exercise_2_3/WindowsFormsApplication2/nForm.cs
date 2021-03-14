using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class nForm :  Form1
    {
        public nForm()
        {
            InitializeComponent();
        }

        private void nForm_Load(object sender, EventArgs e)
        {
            nForm nform = new nForm();
            nform.Owner = this;
        }

      
    }
}
