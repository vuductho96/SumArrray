
using System;
namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            int[] numbers = { 2, 5, 9, 6, 7 };
            Console.Write("Vi trí 0 là  "); 
            Console.Write(numbers[0]);
            Console.Write("Vi trí 2 là  ");
            Console.Write(numbers[2]);
            Console.Write("Vi trí 3 là  ");
            Console.WriteLine(numbers[3]);
           
            for (int i = 0; i < numbers.Length; i++)
            {
               total =total+  numbers[i];
               
            }
            Console.WriteLine(total);
        }
    }
}