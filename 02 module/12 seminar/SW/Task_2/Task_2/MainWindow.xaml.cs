using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Task_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        int i = 0;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            textBlock.Text += sender.ToString()[sender.ToString().Length - 1];
            i+=1;
        }

        private void delete_Click(object sender, RoutedEventArgs e)
        {
            textBlock.Text = textBlock.Text[..^1];
        }
    }
}
