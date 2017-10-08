using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test01
{
    class Program
    {
        static void Main(string[] args)
        {
            string newstring = "A String";
            foreach (char item in newstring)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("the length of the string is {0}", newstring.Length);
            Console.WriteLine("the upper string is {0}", newstring.ToUpper());
            Console.WriteLine("the lower string is {0}", newstring.ToLower());
            Console.ReadKey();
        }
    }
}
