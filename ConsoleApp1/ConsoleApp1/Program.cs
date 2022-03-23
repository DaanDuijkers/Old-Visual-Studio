using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 97;
            int b = 20;
            int divide = a / b;
            int remainder = a % b;
            int x = ((a / b) / b) / b;
            int y = ((a % b) % b) % b;

            Console.WriteLine(divide);
            Console.WriteLine(remainder);
            Console.WriteLine(x);
            Console.WriteLine(y);

            Console.ReadKey();
        }
    }
}
