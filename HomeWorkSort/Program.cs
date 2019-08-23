using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkOOP
{
    class Program
    {
        static char[] BubbleSort(char[] mas)
        {
            char a;
            for (int i = 0; i < mas.Length; i++)
            {
                for (int j = i + 1; j < mas.Length; j++)
                {
                    if (mas[i] > mas[j])
                    {
                        a = mas[i];
                        mas[i] = mas[j];
                        mas[j] = a;
                    }
                }
            }
            return mas;
        }
        static int[] InsertionSort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int b = array[i];
                int j = i;
                while (j > 0 && b < array[j - 1])
                {
                    array[j] = array[j - 1];
                    j--;
                }
                array[j] = b;
            }
            return array;
        }
        static void Main(string[] args)
        {
            char[] mas = { '1', '4', '2', '3', '7', '6', '9', '5', '8', };
            BubbleSort(mas);
            Console.WriteLine("BubbleSort:");
            for (int i = 0; i < mas.Length; i++)
            {
                Console.Write($"{ mas[i]}, ");
            }
            Console.WriteLine();
            int[] array = { 1, 2, 7, 6, 3, 4, 9, 5, 8 };
            InsertionSort(array);
            Console.WriteLine("InsertionSort:");
            for (int i = 0; i < mas.Length; i++)
            {
                Console.Write($"{ array[i]}, ");
            }




            Console.ReadKey();
        }
    }
}