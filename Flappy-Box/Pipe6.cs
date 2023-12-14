using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Trex_runner
{
    class Pipe6
    {
        public int X = 1550;
        public int Y = 1;

        public int moveSpeed = 10;

        public void DrawPipe6(Graphics g, Pen p)
        {
            g.DrawLine(p, X, Y, X + 70, Y);
            g.DrawLine(p, X + 70, Y, X + 70, Y + 180);
            g.DrawLine(p, X + 70, Y + 180, X, Y + 180);
            g.DrawLine(p, X, Y + 180, X, Y);
        }
    }
}
