using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gitmyfirstapp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
           // int c = Add(2,8);
            Console.WriteLine(Add(2,8));
            Console.ReadKey();
        }

        static int Add(int a,int b)
        {
           int c= a + b;
            return c;
        }
    }
}
