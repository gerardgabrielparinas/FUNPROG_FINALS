using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Trex_runner
{
    class Pipe5
    {
        public int X = 1500;
        public int Y = 413;

        public int moveSpeed = 10;

        public void DrawPipe5(Graphics g, Pen p)
        {
            g.DrawLine(p, X, Y, X + 70, Y);
            g.DrawLine(p, X + 70, Y, X + 70, Y - 50);
            g.DrawLine(p, X + 70, Y - 50, X, Y - 50);
            g.DrawLine(p, X, Y - 50, X, Y);
        }
    }
}
