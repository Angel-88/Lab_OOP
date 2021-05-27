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
    class Square:Figure
    {
        int sideLength;
        public Square(int sideLength)
        {
            this.sideLength = sideLength;
        }
        public override void DrawBlack(Graphics g)
        {
            g.DrawRectangle(new Pen(Color.Black), x_center - sideLength / 2, y_center - sideLength / 2, sideLength, sideLength);
        }
        public override void HideDrawingBackGround(Graphics g)
        {
            g.Clear(Color.Empty);
        }
    }
}
