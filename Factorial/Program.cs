using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    public class Factorial
    {
        public int number;


        public Factorial(int a)
        {
            number = a;
        }
        public int Calculate()
        {
            return Calculate(number);
        }

        public int Calculate(int a)
        {
            if (a == 0 || a == 1) return 1;
            return a * Calculate(a - 1);
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            Factorial obj  = new Factorial(a);
            Console.WriteLine(obj.Calculate());
            Console.ReadKey();
            

        }
    }
}
