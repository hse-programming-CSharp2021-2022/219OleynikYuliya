﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            buttonShow.Visible = false;
        }

        string[] lines = { "one", "two", "three"};

        private void buttonInit_Click(object sender, EventArgs e)
        {
            textBox1.Lines = lines;
            buttonShow.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}