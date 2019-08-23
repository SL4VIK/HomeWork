using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    static class Program
    {
        static int[] Find(this string MyString, string Substring)
        {
            if (!MyString.Contains(Substring)) return new int[] { -1, -1 };
            else return new int[] { MyString.IndexOf(Substring), MyString.IndexOf(Substring) + Substring.Length - 1 };
        }
        static void Main(string[] args)
        {
            string MyString = "qwerty";
            string Substring = "ty";
            var result = MyString.Find(Substring);
            Console.WriteLine($"String \"{Substring}\" in string  \"{MyString}\" starts at {result[0]}  index and ends with {result[1]}");
            Console.ReadKey();
        }
    }
}
