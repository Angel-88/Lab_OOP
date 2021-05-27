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
    class Rhomb:Figure
    {
        int horDiagLen;
        int vertDiagLen;
        public Rhomb(int horDiagLen,int vertDiagLen)
        {
            this.horDiagLen = horDiagLen;
            this.vertDiagLen = vertDiagLen;
        }
        public override void DrawBlack(Graphics g)
        {
            PointF first = new PointF(x_center - horDiagLen / 2, y_center - horDiagLen / 2);
            PointF second = new PointF(x_center + vertDiagLen / 2, y_center - vertDiagLen / 2);
            PointF third = new PointF(x_center + horDiagLen / 2, y_center + horDiagLen / 2);
            PointF forth = new PointF(x_center - vertDiagLen / 2, y_center + vertDiagLen / 2);
            g.DrawPolygon(new Pen(Color.Black), new PointF[]{ first, second, third, forth });
        }
        public override void HideDrawingBackGround(Graphics g)
        {
            g.Clear(Color.Empty);
        }
    }
}
