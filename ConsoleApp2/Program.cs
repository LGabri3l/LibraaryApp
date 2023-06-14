using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
           // int i;
           // int j;
           // int result;

           // //i =1 ; j =2;

           // //result = i + j;

           ////Console.WriteLine(result);

           // Console.WriteLine("type your first number");
           // i = Console.
           // Console.WriteLine("Type another number");
           // j= Console.Read();
           // result = i + j;
           // Console.WriteLine(result);
           for (int i =1; i <=100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine(i + " FizzBazz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine(i + " Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine(i + " Bazz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }

            string text = "Hello Mundo Crazy";
            string result = string.Empty;

            foreach (char c in text)
            {
                result = c + result;
            }
            Console.WriteLine(result);
        }
    }
}
