using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trex_runner
{
    public partial class GameScreen : Form
    {
        public GameScreen()
        {
            InitializeComponent();
        }

        Dino player1 = new Dino();
        Ground ground = new Ground();
        Pipe1 pipe1 = new Pipe1();
        Pipe2 pipe2 = new Pipe2();
        Pipe3 pipe3 = new Pipe3();
        Pipe4 pipe4 = new Pipe4();
        Pipe5 pipe5 = new Pipe5();
        Pipe6 pipe6 = new Pipe6();
        Graphics gfx;
        Pen pen, pen2, pen3;

        int score = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            gfx = CreateGraphics();
            pen = new Pen(Color.Brown, 4.0f);
            pen2 = new Pen(Color.Black, 4.0f);
            pen3 = new Pen(Color.Green, 4.0f);
        }

        private void tRender_Tick(object sender, EventArgs e)
        {
            gfx.Clear(this.BackColor);
            player1.DrawDino(gfx, pen2);
            ground.DrawGround(gfx, pen);
            pipe1.DrawPipe1(gfx, pen3);
            pipe2.DrawPipe2(gfx, pen3);
            pipe3.DrawPipe3(gfx, pen3);
            pipe4.DrawPipe4(gfx, pen3);
            pipe5.DrawPipe5(gfx, pen3);
            pipe6.DrawPipe6(gfx, pen3);
        }

        private void tGameTimer_Tick(object sender, EventArgs e)
        {
            pipe1.X -= pipe1.moveSpeed;
            pipe2.X -= pipe2.moveSpeed;
            pipe3.X -= pipe3.moveSpeed;
            pipe4.X -= pipe4.moveSpeed;
            pipe5.X -= pipe5.moveSpeed;
            pipe6.X -= pipe6.moveSpeed;
            scoreText.Text = "Score: " + score;

            player1.Y += player1.jumpSpeed;

            if(pipe1.X < -10)
            {
                pipe1.X = 800;
                score++;
            }

            if(pipe2.X < -10)
            {
                pipe2.X = 800;
                
            }
            
            if(pipe3.X < -10)
            {
                pipe3.X = 900;
                score++;
            }

            if(pipe4.X < -10)
            {
                pipe4.X = 950;
            }

            if(pipe5.X < -10)
            {
                pipe5.X = 1000;
                score++;
            }

            if(pipe6.X < -10)
            {
                pipe6.X = 1050;
            }

            if(score > 10)
            {
                pipe1.moveSpeed = 15;
                pipe2.moveSpeed = 15;
                pipe3.moveSpeed = 15;
                pipe4.moveSpeed = 15;
                pipe5.moveSpeed = 15;
                pipe6.moveSpeed = 15;
            }

            if(score > 15)
            {
                pipe1.moveSpeed = 20;
                pipe2.moveSpeed = 20;
                pipe3.moveSpeed = 20;
                pipe4.moveSpeed = 20;
                pipe5.moveSpeed = 20;
                pipe6.moveSpeed = 20;
            }

            if(score > 20)
            {
                pipe1.moveSpeed = 25;
                pipe2.moveSpeed = 25;
                pipe3.moveSpeed = 25;
                pipe4.moveSpeed = 25;
                pipe5.moveSpeed = 25;
                pipe6.moveSpeed = 25;
            }

            if(score > 25)
            {
                pipe1.moveSpeed = 30;
                pipe2.moveSpeed = 30;
                pipe3.moveSpeed = 30;
                pipe4.moveSpeed = 30;
                pipe5.moveSpeed = 30;
                pipe6.moveSpeed = 30;
            }

            if(score > 35)
            {
                pipe1.moveSpeed = 27;
                pipe2.moveSpeed = 30;
                pipe3.moveSpeed = 20;
                pipe4.moveSpeed = 25;
                pipe5.moveSpeed = 15;
                pipe6.moveSpeed = 29;
            }

            if(player1.Y + 20 > pipe1.Y - 140 && player1.X + 40 > pipe1.X - 10 ||
                player1.Y < pipe2.Y + 120 && player1.X > pipe2.X - 50 ||
                player1.Y + 20 > pipe3.Y - 150 && player1.X + 40 > pipe3.X - 10 ||
                player1.Y < pipe4.Y + 90 && player1.X > pipe4.X - 50 ||
                player1.Y + 20 > pipe5.Y - 50 && player1.X + 40 > pipe5.X - 10 ||
                player1.Y < pipe6.Y + 180 && player1.X > pipe6.X - 50 ||
                player1.Y + 20 >= ground.Y || player1.Y < 0)
            {
                endGame();
                
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Space" && player1.isJumping == false)
            {
                player1.isJumping = true;

            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (player1.isJumping)
            {
                player1.isJumping = false;

            }
        }

        private void endGame()
        {
            tGameTimer.Stop();
            scoreText.Text += " Game Over!";
        }
        
    }
} 

 
   