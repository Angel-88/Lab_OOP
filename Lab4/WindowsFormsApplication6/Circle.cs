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
    class Circle: Figure
    {
        public int radius;
        public Circle(int radius)
        {
            this.radius = radius;
        }
        public override void DrawBlack(Graphics g)
        {
            g.DrawEllipse(new Pen(Color.Black), x_center - radius, y_center - radius, radius*2, radius * 2);
        }
        public override void HideDrawingBackGround(Graphics g)
        {
            g.Clear(Color.Empty);
        }
    }
}
