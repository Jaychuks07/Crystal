using System;

namespace Crystal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter num1! ");

            int num1 = Int32.Parse(Console.ReadLine());

            Console.Write("Enter num2! ");

            int num2 = Int32.Parse(Console.ReadLine());

            int result = num1 + num2;

            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
