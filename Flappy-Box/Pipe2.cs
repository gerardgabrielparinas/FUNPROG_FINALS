using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Trex_runner
{
    class Pipe2
    {
        public int X = 850;
        public int Y = 1;

        public int moveSpeed = 10;
        public int Bounds = 0;
        
        public void DrawPipe2(Graphics g, Pen p)
        {
            g.DrawLine(p, X, Y, X + 70, Y);
            g.DrawLine(p, X + 70, Y, X + 70, Y + 120);
            g.DrawLine(p, X + 70, Y + 120, X, Y + 120);
            g.DrawLine(p, X, Y + 120, X, Y);
        }
    }
} 
