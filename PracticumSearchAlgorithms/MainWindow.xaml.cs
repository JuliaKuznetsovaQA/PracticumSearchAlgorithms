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

namespace PracticumSearchAlgorithms
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, RoutedEventArgs e)
        {
            textbox1.Text = "";
            textbox2.Text = "";
            textbox3.Text = "";

            int[] a = new int[10];

            Random random = new Random();

            textbox2.Text = "Hi!";

            for (int i = 0; i < a.Length; i++)
            {
                a[i] = random.Next(100);
                textbox1.Text += a[i] + "\n";
            }

            /* int a = 5;
            int b = 3;
            int c = a;

            a = b;
            b = c;

            textbox1.Text = "a = " + a + ", b = " + b; */
        }
    }
}
