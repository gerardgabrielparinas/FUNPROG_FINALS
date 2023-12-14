using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Trex_runner
{
    class Ground
    {
        public int X = -1;
        public int Y = 414;

        public void DrawGround(Graphics g, Pen p)
        {
            g.DrawLine(p, X, Y, X + 800, Y);
            g.DrawLine(p, X + 800, Y, X + 800, Y + 30);
            g.DrawLine(p, X + 800, Y + 30, X, Y + 30);
            g.DrawLine(p, X, Y + 30, X, Y);
        }
    }
}
