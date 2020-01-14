using System;

namespace ForStructure1
{
    class Program
    {
        /// <summary>
        /// A program that reads integer N and then N integers At the end, shows the sum of N numbers read
        /// </summary>
       
        static void Main(string[] args)
        {
            int sum, value, N;

            Console.WriteLine("How many integers will you type ? ");
            N = int.Parse(Console.ReadLine());

            sum = 0;
            for (int i = 1; i <= N; i++)
            {
                Console.Write("Value #{0}: ", i);
                value = int.Parse(Console.ReadLine());
                sum = sum + value;
            }
            Console.WriteLine("The Sum of the numbers = " + sum);
            Console.ReadLine();

        }
    }
}
