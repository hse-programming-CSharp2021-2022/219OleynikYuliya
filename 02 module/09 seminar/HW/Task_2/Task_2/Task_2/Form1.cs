using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] lines = new string[] { "Кошка", "Собака", "Лошадь", "Корова", "Мышь", "Бык" };
        string[] newLines = null;

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void buttonInit_Click(object sender, EventArgs e)
        {
            listBox1.Visible = true;
            listBox1.Items.Clear();
            listBox1.Items.AddRange(lines);
            newLines = lines;
            buttonDelete.Visible = true;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectionMode == SelectionMode.One)
            {
                int n = listBox1.SelectedIndex;
                if (n == -1)
                {
                    MessageBox.Show("Список пуст или \r\nнет выделенного элемента!");
                    return;
                }

                listBox1.Items.RemoveAt(n);
            }
            else
            {
                var m = listBox1.SelectedItems;
                if (m.Count > 0)
                {
                    newLines = newLines.Where(x => !m.Contains(x)).ToArray();
                    listBox1.Items.Clear();
                    listBox1.Items.AddRange(newLines);
                }
                else
                {
                    MessageBox.Show("Список пуст или \r\nнет выделенного элемента!");
                    return;
                }
            }

        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectionMode == SelectionMode.One)
            {
                listBox1.SelectionMode = SelectionMode.MultiExtended;
                buttonSelect.Text = "Выбрать один элемент";
            }
            else
            {
                listBox1.SelectionMode = SelectionMode.One;
                buttonSelect.Text = "Выбрать несколько элементов";
            }
        }
    }
}
