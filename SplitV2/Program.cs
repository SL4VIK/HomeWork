using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplitV2
{
    static class Program
    {
        public static string[] Splitt(this string MyString, params char[] Separator)
        {
            if (MyString == null) return null;
            else
            {

                string[] Result = new string[0];
                int LastWordIndex = 0;


                for (int i = 0; i < MyString.Length; i++)
                {
                    if (Separator.Contains(MyString[i]))
                    {
                        char[] temp = new char[i - LastWordIndex];
                        for (int j = LastWordIndex, k = 0; j < i; k++, j++)
                        {
                            temp[k] = MyString[j];
                        }
                        Array.Resize(ref Result, Result.Length + 1);
                        Result[Result.Length - 1] = new string(temp);
                        LastWordIndex = i;
                    }
                }
                return Result;
            }
        }
        static void Main(string[] args)
        {
            string SomeWords = "If you go up,you will see a sun";
            foreach (var i in SomeWords.Split(new char[] { ' ', ',' }))
            {
                Console.WriteLine(i);
            }
        }
    }
}
