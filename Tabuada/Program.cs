using System;

/// <summary>
/// Uri 1078
/// Leia 1 valor inteiro N (2 < N < 1000). A seguir, mostre a tabuada de N: 
/// 1 x N = N       2 x N = 2N          ....        10xN = 10N 
/// </summary>

namespace Tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            int i;

            N = int.Parse(Console.ReadLine());

            for (i = 1; i <= 10; i++)
            {
                int resultato = i * N;
                Console.WriteLine(i + " x " + N + " = " + resultato);
            }
            Console.ReadLine();
        }
    }
}
