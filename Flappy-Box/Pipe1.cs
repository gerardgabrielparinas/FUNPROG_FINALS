using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Trex_runner
{
    class Pipe1
    {
        public int X = 800;
        public int Y = 413;

        public int moveSpeed = 10;
        public int Bounds = 0;

        public void DrawPipe1(Graphics g, Pen p)
        {
            g.DrawLine(p, X, Y, X + 70, Y);
            g.DrawLine(p, X + 70, Y, X + 70, Y - 140);
            g.DrawLine(p, X + 70, Y - 140, X, Y - 140);
            g.DrawLine(p, X, Y - 140, X, Y);
        }
    }
}
