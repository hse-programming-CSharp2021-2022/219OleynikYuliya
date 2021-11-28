using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        string[] strs = new string[]
        {
            "one", "two", "three"
        };
        private void initButton_Click(object sender, EventArgs e)
        {
            textBox.Lines = strs;
        }
        private void changeButton_Click(object sender, EventArgs e)
        {
            string[] str2 = textBox.Lines;
            string strJoin = string.Join(" ", str2);
            MessageBox.Show(strJoin);
        }
    }
}
