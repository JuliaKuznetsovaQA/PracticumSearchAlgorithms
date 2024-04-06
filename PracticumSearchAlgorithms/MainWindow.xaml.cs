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
            int n = a.Length;
            int cmp = 0;
            int tr = 0;

            Random random = new Random();

            for (int i = 0; i < n; i++)
            {
                a[i] = random.Next(100);
                textbox1.Text += a[i] + "\n";
            }


            // сортировка пузырьком

            for (int k = 0; k < n-1; k++)
            {
                for (int i = 0; i < n - k-1; i++)
                {
                    cmp ++;
                    if (a[i] > a[i + 1])
                    {
                        tr ++;
                        int x = a[i];
                        a[i] = a[i+1];
                        a[i+1] = x;
                    }
                }
            }


            for (int i = 0; i < n; i++)
            {
                textbox2.Text += a[i] + "\n";
            }


            textbox3.Text += "количество сравнений = " + cmp + "\n" + "количество перестановок = " + tr;


            /*    поиск min и max в массиве
                int min = a[0];
                int max = a[0];

                for (int i = 0; i < n; i++)
                {
                    if (a[i] < min)
                    {
                        min = a[i];
                    }
                    if (a[i] > max)
                    {
                        max = a[i];
                    }
                }


                textbox2.Text = "min = " + min;
                textbox3.Text = "max = " + max; */


            /* обмен значениями двух переменных
            int a = 5;
            int b = 3;
            int c = a;

            a = b;
            b = c;

            textbox1.Text = "a = " + a + ", b = " + b; */
        }
    }
}
