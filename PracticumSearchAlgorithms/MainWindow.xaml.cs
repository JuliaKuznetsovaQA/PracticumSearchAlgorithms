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
            int len = a.Length;

            Random random = new Random();

            for (int i = 0; i < len; i++)
            {
                a[i] = random.Next(100);
                textbox1.Text += a[i] + "\n";
            }

            int min = a[0];

            for (int i = 0; i < len; i++)
            {
                if (a[i] < min)
                {
                    min = a[i];
                }
            }

            int max = a[0];

            for (int i = 0; i < len; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                }
            }

            textbox2.Text = "min = " + min;
            textbox3.Text = "max = " + max;


            /* int a = 5;
            int b = 3;
            int c = a;

            a = b;
            b = c;

            textbox1.Text = "a = " + a + ", b = " + b; */
        }
    }
}
