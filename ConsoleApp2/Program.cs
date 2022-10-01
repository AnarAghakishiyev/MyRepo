using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 7;
            int b = 3;
            int c = 1;

            for (int i = 0; i < b; i++)
            {
                c *= a;
            }
            Console.WriteLine(c);
            
        }
    }
}
