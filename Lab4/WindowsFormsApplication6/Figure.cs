using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    abstract class Figure
    {
        public int x_center=100;
        public int y_center=100;
        public bool HideBackGround = false;
        public abstract void DrawBlack(Graphics g);
        public abstract void HideDrawingBackGround(Graphics g);
        public void MoveRight(PictureBox picture)
        {
            Bitmap bmp = new Bitmap(picture.Width, picture.Height);
            Graphics g = Graphics.FromImage(bmp);
            DrawBlack(g);
            if (HideBackGround)
            {
                HideDrawingBackGround(g);
            }
            picture.Image = bmp;
        }
    }
}
