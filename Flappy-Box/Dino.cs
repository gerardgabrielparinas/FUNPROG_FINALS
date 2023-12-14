using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Trex_runner
{
    class Dino
    {
        public int X = 60;
        public int Y = 130;

        public bool isJumping = false;
        public int jumpSpeed = 13;
        public int force = 16;
        

        public void DrawDino(Graphics g, Pen p)
        {
            g.DrawLine(p, X, Y, X + 40, Y);
            g.DrawLine(p, X + 40, Y, X + 40, Y + 20);
            g.DrawLine(p, X + 40, Y + 20, X, Y + 20);
            g.DrawLine(p, X, Y + 20, X, Y);

            //Y += jumpSpeed;

            if (isJumping == true)
            {
                jumpSpeed = -7;
                //force -= 1;
            }
            else
            {
                jumpSpeed = 7;     
            }
        }
    }
} 
      