﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        int X, Y;
        int W, H;

        public Form1()
        {
            InitializeComponent();
            X = Y = 0;
            W = H = 100;
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            Y = vScrollBar1.Value;
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            trackBar1.Maximum = Width - W;
            vScrollBar1.Maximum = Height - H;
            e.Graphics.FillRectangle(new SolidBrush(SystemColors.ControlDark), X, Y, W, H);
            TransparencyKey = SystemColors.ControlDark;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            X = trackBar1.Value;
            Invalidate();
        }
    }
}
