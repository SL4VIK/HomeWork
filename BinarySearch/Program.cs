using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class Program
    {
        static int BinarySearch(int[] mas, int number)
        {
            int left = 0;
            int right = mas.Length;

            while (true)
            {
                int mid = left + (right - left) / 2;

                if (mas[mid] == number)
                    return mid;

                if (mas[mid] > number)
                    right = mid;
                else
                    left = mid + 1;
            }
        }
        static void Main(string[] args)
        {
            int[] mas = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int number = 8;
            Console.WriteLine(BinarySearch(mas, number));




            Console.ReadLine();
        }
    }
}
