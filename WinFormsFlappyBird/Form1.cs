﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace WinFormsFlappyBird
{
    public partial class Form1 : Form
    {
        int pipeSpeed = 8;
        int gravity = 10;
        private int score = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            flappyBird.Top += gravity;
            pipeBottom.Left -= pipeSpeed;
            pipeTop.Left -= pipeSpeed;
            scoreText.Text = "Score: " + score;

            if (pipeBottom.Left < -150)
            {
                pipeBottom.Left = 800;
                score++;
            }

            if (pipeTop.Left < -180)
            {
                pipeTop.Left = 950;
                score++;
            }

            if (flappyBird.Bounds.IntersectsWith(pipeBottom.Bounds) ||
                flappyBird.Bounds.IntersectsWith(pipeTop.Bounds) ||
                flappyBird.Bounds.IntersectsWith(ground.Bounds) ||
                flappyBird.Top < -25)
            {
                endGame();
            }
        }

        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -10;
            }
        }

        private void gamekeyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 10;
            }
        }

        private void endGame()
        {
            gameTimer.Stop();
            scoreText.Text += " Game over!!!";
        }
    }
}