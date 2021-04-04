using System;
using System.Drawing;
using System.Windows.Forms;

namespace Delegates2
{
    public partial class Form1 : Form
    {
        private EventHandler TransparencyEventHandler;
        private EventHandler BackgroundColorEventHandler;
        private EventHandler HelloWorldEventHandler;

        public Form1()
        {
            InitializeComponent();
            TransparencyEventHandler = ButtonTransparency_Click;
            BackgroundColorEventHandler = ButtonBackGround_Click;
            HelloWorldEventHandler = ButtonHelloWorld_Click;
        }

        private void ButtonTransparency_Click(object sender, EventArgs e)
        {
            ActiveForm.Opacity = ActiveForm.Opacity == 1.0 ? 0.5 : 1.0;
        }

        private void ButtonBackGround_Click(object sender, EventArgs e)
        {
            ActiveForm.BackColor = ActiveForm.BackColor == Color.Azure ? Color.OrangeRed : Color.Azure;
        }

        private void ButtonHelloWorld_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello Home!#Stay_Home_2021");
        }

        private void ButtonSetOfActions_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Я супермегакнопка,\nі цього мене не позбавиш!");
        }

        private void CheckBoxTransparency_Click(object sender, EventArgs e)
        {
            if (CheckBoxTransparency.Checked)
            {
                ButtonSetOfActions.Click += TransparencyEventHandler;
            }
            else
            {
                ButtonSetOfActions.Click -= TransparencyEventHandler;
            }
        }

        private void CheckBoxBackgroundColor_Click(object sender, EventArgs e)
        {
            if (CheckBoxBackgroundColor.Checked)
            {
                ButtonSetOfActions.Click += BackgroundColorEventHandler;
            }
            else
            {
                ButtonSetOfActions.Click -= BackgroundColorEventHandler;
            }
        }

        private void CheckBoxHelloWorld_Click(object sender, EventArgs e)
        {
            if (CheckBoxHelloWorld.Checked)
            {
                ButtonSetOfActions.Click += HelloWorldEventHandler;
            }
            else
            {
                ButtonSetOfActions.Click -= HelloWorldEventHandler;
            }
        }
	}
}