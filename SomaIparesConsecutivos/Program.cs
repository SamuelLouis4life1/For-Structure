using System;

/// <summary>
/// Uri 1071
/// Leia 2 valores inteiros X e Y. A seguir, calcule e mostre a soma dos números impares entre eles
/// </summary>

namespace SomaIparesConsecutivos
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, soma, min, max;

            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            if (x < y)
            {
                min = x;
                max = y;
            }
            else
            {
                min = y;
                max = x;
            }

            soma = 0;
            for (int i = min + 1; i < max; i++)
            {
                if (i % 2 != 0)
                {
                    soma = soma + i;
                }
            }
            Console.WriteLine(soma);
            Console.ReadLine();
        }
    }
}
