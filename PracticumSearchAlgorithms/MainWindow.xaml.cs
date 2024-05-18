using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

            /* binary search (бинарный поиск) 

            int[] ar = new int[11];
            int n = ar.Length;

            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                ar[i] = rnd.Next(20);
                textbox1.Text += ar[i] + "\n";
            }

            for (int i = 0; i < n; i++)
            {
                int min = i;

                for (int j = i + 1; j < n; j++)
                {
                    if (ar[j] < ar[min])
                    {
                        min = j;
                    }
                }

                int tmp = ar[min];
                ar[min] = ar[i];
                ar[i] = tmp;
                {

                }
            }

            for (int i = 0; i < n; i++)
            {
                textbox2.Text += ar[i] + "\n";
            }

            int x = 10;
            bool found = false;

            int a = 0;
            int b = n - 1;

            while (b > a + 1)
            {
                int k = (a + b) / 2;

                if (ar[k] == x)
                {
                    found = true;
                    textbox3.Text = "x found: " + k;
                    break;
                }
                else
                {
                    if (ar[k] > x)
                    {
                        b = k;
                    }
                    else
                    {
                        a = k;
                    }
                }
            }

            if (!found )
            {
                textbox3.Text = "Искомый элемент не найден";
            }
            */

            /* случайное перемешивание массива

            textbox1.Text = "";
            textbox2.Text = "";
            int[] a = new int[10];
            int n = a.Length;

            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                a[i] = rnd.Next(n);
                textbox1.Text += a[i] + "\n";
            }

            for (int i = 0; i < n; i++)
            {
                int j = rnd.Next(n);
                int tmp = a[i];
                a[i] = a[j];
                a[j] = tmp;
            }

            for (int i = 0; i < n; i++)
            {
                textbox2.Text += a[i] + "\n";
            }
            */

            /* перемешивание массива случайным образом, с использованием буферного массива

            textbox1.Text = "";
            textbox2.Text = "";
            int[] a = new int[10];
            int[] b = new int[10];
            int n = a.Length, c = n;

            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                a[i] = rnd.Next(20);
                b[i] = a[i];
                textbox1.Text += a[i] + "\n";
            }

            for (int i = 0; i < n; i++)
            {
                int j = rnd.Next(c);
                a[i] = b[i];
                for (int k = j; k < c - 2; k++)
                {
                    b[k] = b[k + 1];
                }
                c--;
            }

            for (int i = 0; i < n; i++)
            {
                textbox2.Text += a[i] + "\n";
            }
            */

            /* транспонирование матрицы
            textbox1.Text = "";
            textbox2.Text = "";
            int[,] a = { { 1, 2, 3, 4, 5 }, { 1, 2, 3, 4, 5 }, { 1, 2, 3, 4, 5 }, { 1, 2, 3, 4, 5 }, { 1, 2, 3, 4, 5 } };
            int[,] b = new int[5,5];
            

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    textbox1.Text += a[i, j] + " ";
                }
                textbox1.Text += "\n";
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    b[i, j] = a[j, i];
                }
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    textbox2.Text += b[i, j] + " ";
                }
                textbox2.Text += "\n";
            }
            */

            /* простые числа по Эратосфену
            textbox1.Text = "";
            textbox2.Text = "";
            int[] a = new int[50];

            for (int i = 0; i < a.Length; i++)
            {
                a[i] = i;
                textbox1.Text += a[i] + "\n";
            }

            int m = 2;
            int j = 0;
            a[1] = 0;

            while(m < a.Length)
            {
                if (a[m] != 0)
                {
                    j = m * 2;

                    while (j < a.Length)
                    {
                        a[j] = 0;
                        j += m;
                    }
                }
                m++;
            }

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != 0)
                {
                    textbox2.Text += a[i] + "\n";
                }
            }
            */

            /* НОД way 1

            textbox1.Text = "";
            textbox2.Text = "";

            int a = 17;
            int b = 34;
            int min = a;
            int nod = 0;

            for(int i = min; i > 1; i--)
            {
                if (a % i == 0 && b % i == 0) 
                {
                    nod = i;
                    break;
                }
            }

            if (nod != 0)
            {
                textbox1.Text += nod;
            }
            */

            /* Алгоритм Евклида (поиск наибольшего общего делителя)
            textbox1.Text = "";
            textbox2.Text = "";

            int a = 17;
            int b = 34;
            int nod = 0;

            while (a != 0 && b != 0)
            {
                if (a > b)
                {
                    a = a % b;
                }
                else
                {
                    b = b % a;
                }
            }

            nod = a + b;
            textbox1.Text += nod;
            */

            
        }
    }
}
