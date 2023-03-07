using System;
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
        int gravity = 5;
        private int score = 0;

        public Form1()
        {
            InitializeComponent();
        }

        // private void pipeBottom_Click(object sender, EventArgs e)
        // {
        //     throw new System.NotImplementedException();
        // }

        private void gameTimerEvent(object sender, ElapsedEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
        }

        private void gamekeyisup(object sender, KeyEventArgs e)
        {
        }
    }
}