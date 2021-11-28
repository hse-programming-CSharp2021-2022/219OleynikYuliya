using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp4_2_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Rate rate = new Rate();
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rate.Hits += 1;
            hitsLabel.Text = rate.Hits.ToString();
        }    

        private void Form1_Click(object sender, EventArgs e)
        {
            rate.Fails += 1;
            failsLabel.Text = rate.Fails.ToString();
        }

        class Rate
        {
            public uint Hits { get; set; }
            public uint Fails { get; set; }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            button1.Visible = !button1.Visible;
        }
    }
}
