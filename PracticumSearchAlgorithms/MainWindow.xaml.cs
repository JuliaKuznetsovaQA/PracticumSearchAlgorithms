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

            /* simple bubble sort
             
                        int[] a = new int[10];
            int n = a.Length;
            int changes = 0;
            int swap_count = 0;

            Random random = new Random();

            for (int i = 0; i < n; i++)
            {
                a[i] = random.Next(100);
                textbox1.Text += a[i] + "\n";
            }

            for (int k = 0; k < n; k++)
            {
                for (int i = 0; i < n - k - 1; i++)
                {
                    changes ++;
                    if (a[i] > a[i + 1])
                    {
                        swap_count++;
                        int с = a[i];
                        a[i] = a[i + 1];
                        a[i + 1] = с;
                    }

                }
                
            }


            for (int i = 0; i < n; i++)
            {
                textbox2.Text += a[i] + "\n";
            }


            textbox3.Text += "количество сравнений = " + changes + "\n" + "количество перестановок = " + swap_count;
            */

            /* bubble sort swapped

            int[] a = new int[10];
            int n = a.Length;
            int changes = 0;
            int swap_count = 0;

            Random random = new Random();

            for (int i = 0; i < n; i++)
            {
                a[i] = random.Next(100);
                textbox1.Text += a[i] + "\n";
            }

            for (int k = 0; k < n; k++)
            {
                bool swap_exists = false;  // усовершенствованный пузырек (переменная swap_exists проверяет, были ли перестановки в проверке)

                for (int i = 0; i < n - k - 1; i++)
                {
                    changes ++;
                    if (a[i] > a[i + 1])
                    {
                        swap_count++;
                        swap_exists = true;  // усовершенствованный пузырек
                        int с = a[i];
                        a[i] = a[i + 1];
                        a[i + 1] = с;
                    }

                }
                if (!swap_exists)   // усовершенствованный пузырек
                {
                    break;
                }
            }


            for (int i = 0; i < n; i++)
            {
                textbox2.Text += a[i] + "\n";
            }


            textbox3.Text += "количество сравнений = " + changes + "\n" + "количество перестановок = " + swap_count;
            */

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

            /* insert sort (сортировка вставками) 

            int[] a = new int[10];
            int n = a.Length;

            Random rnd = new Random();  
            for (int i = 0; i < n; i++)
            {
                a[i] = rnd.Next(100);
                textbox1.Text += a[i] + "\n";
            }

            for (int i = 0; i < n; i++)
            {
                int x = a[i];

                for (int j = i - 1; j >= 0 && a[j] > x; j--)
                {
                    a[j + 1] = a[j];
                    a[j] = x;
                }
            }

            for (int i = 0; i < n; i++)
            {
                textbox2.Text += a[i] + "\n";
            }
            */

            /* selection sort (сортировка методом выбора) 

            int[] a = new int[10];
            int n = a.Length;

            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                a[i] = rnd.Next(100);
                textbox1.Text += a[i] + "\n";
            }

            for (int i = 0; i < n; i++)
            {
                int min = i;

                for (int j = i + 1; j < n; j++)
                {
                    if (a[j] < a[min])
                    {
                        min = j;
                    }
                }

                int tmp = a[min];
                a[min] = a[i]; 
                a[i] = tmp;
                {

                }
            }

            for (int i = 0; i < n; i++)
            {
                textbox2.Text += a[i] + "\n";
            }
            */

            /* linear search (последовательный поиск) 

            int[] a = new int[10];
            int n = a.Length;

            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                a[i] = rnd.Next(20);
                textbox1.Text += a[i] + "\n";
            }

            int x = 10;

            bool found = false;
            int k = 0;

            for (int i = 0; i < n; i++)
            {
                if (a[i] == x)
                {
                    found = true;
                    k = i;
                    break;
                }
            }

            if (found)
            {
                textbox2.Text = "Индекс элемента: " + k;
            }
            else
            {
                textbox2.Text = "Искомый элемент не найден";
            }
            */



        }
    }
}
